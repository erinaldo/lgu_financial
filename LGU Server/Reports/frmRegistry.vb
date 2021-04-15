Imports DevExpress.XtraEditors
Imports MySql.Data.MySqlClient
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraReports.UI
Imports DevExpress.Skins
Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmRegistry
    Private Sub frmReportEntries_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadFund()
        LoadOffice()
        LoadClass()
    End Sub

    Public Sub LoadFund()
        LoadXgridLookupSearch("SELECT periodcode, concat((select description from tblfund where code=a.fundcode), '-', yeartrn) as fund FROM `tblfundperiod` as a where closed=0 order by fundcode;", "tblfundperiod", txtFund, gridFund, Me)
        gridFund.Columns("periodcode").Visible = False
    End Sub

    Public Sub LoadOffice()
        LoadXgridLookupSearch("SELECT officeid, officename FROM `tblcompoffice` where deleted=0 order by officename asc;", "tblcompoffice", txtOffice, gridoffice, Me)
        gridoffice.Columns("officeid").Visible = False
    End Sub

    Public Sub LoadClass()
        LoadXgridLookupSearch("SELECT code, description FROM `tblexpenditureclass` order by description asc;", "tblexpenditureclass", txtClass, gridclass, Me)
        gridclass.Columns("code").Visible = False
    End Sub

    Public Sub LoadReport(ByVal print As Boolean)
        If txtFund.Text = "" Or txtOffice.Text = "" Or txtClass.Text = "" Or txtMonth.Text = "" Then Exit Sub
        Dim yearcode As String() = txtFund.EditValue.Split("-")


        Dim BudgetQuery As String = " periodcode='" & txtFund.EditValue & "' and classcode='" & txtClass.EditValue & "' and monthcode='" & String.Format("{0:0#}", Month(txtMonth.EditValue & " 1, " & yearcode(1))) & "' and officeid='" & txtOffice.EditValue & "' "


        Dim query As String = "" : Dim listItemName As New List(Of String)() : Dim strRequisition As String = "" : Dim strItemColumn As String = "" : Dim ItemCode As String = "" : Dim BlanckItem As String = ""
        com.CommandText = "select * from tblbudgethistory where " & BudgetQuery & " order by itemcode asc" : rst = com.ExecuteReader
        While rst.Read
            listItemName.Add(rchar(rst("itemname").ToString))

            query += ", " & rst("amount").ToString & " as '" & rchar(rst("itemname").ToString) & "'"
            strItemColumn += "`" & rst("itemcode").ToString & "` DOUBLE NOT NULL DEFAULT 0,"
            ItemCode += ", `" & rst("itemcode").ToString & "`"
            BlanckItem += ", null "
        End While
        rst.Close()

        com.CommandText = "DROP TABLE IF EXISTS `tmpbudget`;" : com.ExecuteNonQuery()
        com.CommandText = "CREATE TEMPORARY TABLE `tmpbudget` (  `id` INTEGER UNSIGNED NOT NULL AUTO_INCREMENT, " _
                            + " `appropriation` DOUBLE Not NULL DEFAULT 0, " _
                            + " `allotment` DOUBLE Not NULL DEFAULT 0, " _
                            + " `datetrn` DATE, " _
                            + " `refno` VARCHAR(100) NOT NULL DEFAULT '', " _
                            + " `particular` VARCHAR(1000) NOT NULL DEFAULT '', " _
                            + " `obligation` DOUBLE NOT NULL DEFAULT 0, " _
                            + " " & strItemColumn & "  PRIMARY KEY (`id`)) ENGINE = InnoDB;" : com.ExecuteNonQuery()



        Dim totalBudgetHistory As Double = Val(qrysingledata("total", "sum(totalbudget) - ifnull((select sum(amount) as totalsource from tblrequisitionfund as b inner join tblrequisition as c on b.pid=c.pid where b.periodcode='" & txtFund.EditValue & "'  and b.officeid='" & txtOffice.EditValue & "' and b.classcode='" & txtClass.EditValue & "' and b.cancelled=0 and cast(b.monthcode as unsigned)<" & Month(txtMonth.EditValue & " 1, " & yearcode(1)) & "),0) as total", "tblbudgethistory where " & BudgetQuery & " "))
        Dim totalAllotment As Double = Val(qrysingledata("total", "sum(amount) as total", "tblbudgethistory where " & BudgetQuery & " "))
        Dim remainingBudget As Double = totalBudgetHistory
        Dim remainingAllotment As Double = totalAllotment

        da = Nothing : Dim dst = New DataSet : dst.Clear()
        da = New MySqlDataAdapter("select b.pid,postingdate,b.requestno, purpose, sum(amount) as totalsource from tblrequisitionfund as b inner join tblrequisition as c on b.pid=c.pid where b.periodcode='" & txtFund.EditValue & "'  and b.officeid='" & txtOffice.EditValue & "' and b.classcode='" & txtClass.EditValue & "' and b.cancelled=0 and b.monthcode='" & String.Format("{0:0#}", Month(txtMonth.EditValue & " 1, " & yearcode(1))) & "'  group by b.pid", conn)
        da.Fill(dst, 0)
        For cnt = 0 To dst.Tables(0).Rows.Count - 1
            With (dst.Tables(0))
                Dim appropriation As Double = totalBudgetHistory

                Dim ItemObligation As String = ""
                com.CommandText = "select * from tblrequisitionfund where pid='" & .Rows(cnt)("pid").ToString() & "' and classcode='" & txtClass.EditValue & "'  and cancelled=0" : rst = com.ExecuteReader
                While rst.Read
                    ItemObligation += ", `" & rst("itemcode").ToString & "`='" & rst("amount").ToString & "' "
                End While
                rst.Close()


                Dim totalSource As Double = Val(.Rows(cnt)("totalsource").ToString())
                remainingBudget = remainingBudget - totalSource
                remainingAllotment = remainingAllotment - totalSource

                com.CommandText = "insert into tmpbudget set appropriation='" & remainingBudget & "', " _
                                                         + " allotment='" & remainingAllotment & "', " _
                                                         + " datetrn='" & ConvertDate(.Rows(cnt)("postingdate").ToString()) & "', " _
                                                         + " refno='" & .Rows(cnt)("requestno").ToString() & "', " _
                                                         + " particular='" & rchar(.Rows(cnt)("purpose").ToString()) & "', " _
                                                         + " obligation='" & totalSource & "' " & ItemObligation : com.ExecuteNonQuery()
            End With
        Next

        Dim FinalQuery As String = "select * from (SELECT " & totalBudgetHistory & " as 'Amount of Appropriation', " _
                      + " sum(amount) as 'Amount of Allotment', " _
                      + " ' ' as 'Date', " _
                      + " ' ' as 'Reference/CAFOA No.', " _
                      + " concat((select officename from tblcompoffice where officeid=a.officeid),'_',classcode) as 'Particulars', " _
                      + " sum(amount) as 'Total Amount of Allotment Obligation' " _
                      + query _
                      + " FROM `tblbudgethistory` as a where " & BudgetQuery & "  UNION ALL " _
                      + " select null,null,null,null,null,null " & BlanckItem & " UNION ALL " _
                      + " select null,null,null,null,null,null " & BlanckItem & " UNION ALL " _
                      + " select appropriation,allotment, datetrn, refno, particular, obligation " & ItemCode & " from tmpbudget) as x;"


        LoadXgrid(FinalQuery, "tblbudgethistory", Em, GridView1, Me)

        Dim colCurrency As Array = {"Amount of Appropriation", "Amount of Allotment", "Total Amount of Allotment Obligation"}

        XgridColCurrency(colCurrency, GridView1)
        XgridColCurrency(listItemName.ToArray, GridView1)
        XgridColAlign({"Date"}, GridView1, DevExpress.Utils.HorzAlignment.Center)
        'XgridGeneralSummaryCurrency(colCurrency, GridView1)
        GridView1.BestFitColumns()
        XgridColMemo({"Particulars"}, GridView1)
        XgridColWrapText({"Particulars"}, GridView1)
        XgridColWidth({"Particulars"}, GridView1, 400)

        If print Then
            PrintRegistry(print, txtOffice.Text & " - " & txtClass.Text & " (" & txtClass.EditValue & ")", txtMonth.Text, FinalQuery, listItemName.ToArray, "REGISTRY_" & txtFund.EditValue & "_" & txtClass.EditValue & "_" & UCase(txtMonth.Text) & "_" & txtOffice.Text, Me)
        End If
    End Sub

    Private Sub BarLargeButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarLargeButtonItem2.ItemClick
        Me.Close()
    End Sub

    Private Sub cmdSaveButton_Click(sender As Object, e As EventArgs) Handles cmdSaveButton.Click
        LoadReport(False)
    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        ExportGridToExcel(Me.Text & " " & txtFund.EditValue & " " & txtClass.EditValue & " " & txtMonth.Text & " " & txtOffice.Text, GridView1)
    End Sub

    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        LoadReport(True)
    End Sub

    Private Sub BarButtonItem3_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        frmRegistryExport.ShowDialog(Me)
    End Sub
End Class

