Imports DevExpress.XtraEditors
Imports DevExpress.Skins
Imports DevExpress.XtraGrid.Views.Grid
Imports MySql.Data.MySqlClient
Imports System.IO

Public Class frmRegistryExport
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmProductMesurement_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetIcon(Me)
        LoadFund()
        LoadClass()
    End Sub

    Public Sub LoadFund()
        LoadXgridLookupSearch("SELECT periodcode, concat((select description from tblfund where code=a.fundcode), '-', yeartrn) as fund FROM `tblfundperiod` as a where closed=0 " & If(LCase(globaluser) = "root", "", " and fundcode in (select fundcode from tblfundfilter where filtered_id='" & globalPermissionAccess & "' and filtered_type='server')") & "  order by fundcode;", "tblfundperiod", txtFund, gridFund, Me)
        gridFund.Columns("periodcode").Visible = False
    End Sub

    Public Sub LoadClass()
        LoadXgridLookupSearch("SELECT code, description FROM `tblexpenditureclass` order by description asc;", "tblexpenditureclass", txtClass, gridclass, Me)
        gridclass.Columns("code").Visible = False
    End Sub



    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        Using frm = FolderBrowserDialog1
            If frm.ShowDialog(Me) = DialogResult.OK Then
                ExportReport(frm.SelectedPath)
            End If
        End Using
    End Sub

    Public Sub ExportReport(ByVal location As String)
        If txtFund.Text = "" Or txtClass.Text = "" Or txtMonth.Text = "" Then Exit Sub
        Dim yearcode As String() = txtFund.EditValue.Split("-")



        Dim listOfficeid As New List(Of String)()
        com.CommandText = "select distinct officeid from tblbudgethistory where periodcode='" & txtFund.EditValue & "' and classcode='" & txtClass.EditValue & "' and monthcode='" & String.Format("{0:0#}", Month(txtMonth.EditValue & " 1, " & yearcode(1))) & "'" : rst = com.ExecuteReader
        While rst.Read
            listOfficeid.Add(rst("officeid").ToString)
        End While
        rst.Close()

        ProgressBarControl1.Properties.Step = 1
        ProgressBarControl1.Properties.PercentView = True
        ProgressBarControl1.Properties.Maximum = listOfficeid.Count - 1
        ProgressBarControl1.Properties.Minimum = 0
        ProgressBarControl1.Position = 0

        For Each officeid In listOfficeid.ToArray
            Dim BudgetQuery As String = " periodcode='" & txtFund.EditValue & "' and classcode='" & txtClass.EditValue & "' and monthcode='" & String.Format("{0:0#}", Month(txtMonth.EditValue & " 1, " & yearcode(1))) & "' and officeid='" & officeid & "' "

            If countqry("tblbudgethistory", BudgetQuery) > 0 Then
                Dim officename As String = qrysingledata("officename", "officename", "tblcompoffice where officeid='" & officeid & "'")
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



                Dim totalBudgetHistory As Double = Val(qrysingledata("total", "sum(totalbudget) - ifnull((select sum(amount) as totalsource from tblrequisitionfund as b inner join tblrequisition as c on b.pid=c.pid where b.periodcode='" & txtFund.EditValue & "'  and b.officeid='" & officeid & "' and b.classcode='" & txtClass.EditValue & "' and b.cancelled=0 and cast(b.monthcode as unsigned)<" & Month(txtMonth.EditValue & " 1, " & yearcode(1)) & "),0) as total", "tblbudgethistory where " & BudgetQuery & " "))
                Dim totalAllotment As Double = Val(qrysingledata("total", "sum(amount) as total", "tblbudgethistory where " & BudgetQuery & " "))
                Dim remainingBudget As Double = totalBudgetHistory
                Dim remainingAllotment As Double = totalAllotment

                da = Nothing : Dim dst = New DataSet : dst.Clear()
                da = New MySqlDataAdapter("select b.pid,postingdate,b.requestno, purpose, sum(amount) as totalsource from tblrequisitionfund as b inner join tblrequisition as c on b.pid=c.pid where b.periodcode='" & txtFund.EditValue & "'  and b.officeid='" & officeid & "' and b.classcode='" & txtClass.EditValue & "' and b.cancelled=0 and b.monthcode='" & String.Format("{0:0#}", Month(txtMonth.EditValue & " 1, " & yearcode(1))) & "'  group by b.pid", conn)
                da.Fill(dst, 0)
                For cnt = 0 To dst.Tables(0).Rows.Count - 1
                    With (dst.Tables(0))
                        Dim appropriation As Double = totalBudgetHistory

                        Dim ItemObligation As String = ""
                        com.CommandText = "select * from tblrequisitionfund where pid='" & .Rows(cnt)("pid").ToString() & "' and classcode='" & txtClass.EditValue & "' and cancelled=0" : rst = com.ExecuteReader
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

                Dim registryHtml As String = PrintRegistry(False, officename & " - " & txtClass.Text & " (" & txtClass.EditValue & ")", txtMonth.Text, FinalQuery, listItemName.ToArray, "REGISTRY_" & txtFund.EditValue & "_" & txtClass.EditValue & "_" & UCase(txtMonth.Text) & "_" & officename, Me)

                Dim registryLocation As String = location & "\" & txtFund.Text & "\" & txtMonth.Text & "\" & txtClass.Text
                If Not IO.Directory.Exists(registryLocation) Then
                    IO.Directory.CreateDirectory(registryLocation)
                End If

                Dim registryPDF As String = registryLocation & "\" & officename & ".pdf"
                If File.Exists(registryPDF) = True Then
                    File.Delete(registryPDF)
                End If
                SavePDFCopy(registryHtml, registryPDF)
                ProgressBarControl1.PerformStep()
                ProgressBarControl1.Update()
            End If

        Next
        ProgressBarControl1.Position = 0
        MessageBox.Show("Report Successfully Exported!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

End Class