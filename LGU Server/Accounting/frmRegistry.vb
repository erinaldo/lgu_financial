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

    Public Sub LoadReport()
        If txtFund.Text = "" Or txtOffice.Text = "" Or txtClass.Text = "" Or txtMonth.Text = "" Then Exit Sub

        Dim query As String = "" : Dim list As New List(Of String)() : Dim strRequisition As String = ""
        com.CommandText = "select * from tblbudgethistory where periodcode='" & txtFund.EditValue & "' and officeid='" & txtOffice.EditValue & "' and classcode='" & txtClass.EditValue & "' and monthcode='" & String.Format("{0:0#}", Month(txtMonth.EditValue & " 1, " & Now.Year)) & "' order by itemcode asc" : rst = com.ExecuteReader
        While rst.Read
            query += ", " & rst("amount").ToString & " as '" & rchar(rst("itemname").ToString) & "'"
            list.Add(rchar(rst("itemname").ToString))

            strRequisition += ", ifnull((select sum(amount) from tblrequisitionfund as b inner join tblrequisition as c on b.pid=c.pid where b.periodcode=a.periodcode and b.itemcode=a.itemcode and b.officeid=a.officeid and b.classcode=a.classcode and b.cancelled=0 and b.monthcode='" & rst("monthcode").ToString & "'),0) as ''" & rchar(rst("itemname").ToString) & "' "
        End While
        rst.Close()



        LoadXgrid("select * from (SELECT sum(totalbudget) as 'Amount of Appropriation', " _
                      + " sum(amount) as 'Amount of Allotment', " _
                      + " ' ' as 'Date', " _
                      + " ' ' as 'Reference/CAFOA No.', " _
                      + " concat((select officename from tblcompoffice where officeid=a.officeid),'_',classcode) as 'Particulars', " _
                      + " sum(amount) as 'Total Amount of Allotment Obligation' " _
                      + query _
                      + " FROM `tblbudgethistory` as a where periodcode='" & txtFund.EditValue & "' and classcode='" & txtClass.EditValue & "' and monthcode='" & String.Format("{0:0#}", Month(txtMonth.EditValue & " 1, " & Now.Year)) & "' and officeid='" & txtOffice.EditValue & "' union all " _
                      + " ) as x;", "tblbudgethistory", Em, GridView1, Me)

        Dim colCurrency As Array = {"Amount of Appropriation", "Amount of Allotment", "Total Amount of Allotment Obligation"}

        XgridColCurrency(colCurrency, GridView1)
        XgridColCurrency(list.ToArray, GridView1)
        XgridColAlign({"Date"}, GridView1, DevExpress.Utils.HorzAlignment.Center)
        XgridGeneralSummaryCurrency(colCurrency, GridView1)
        GridView1.BestFitColumns()
    End Sub

    'Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
    '    ExportGridToExcel(Me.Text & " " & If(txtMonth.Text = "", "", txtMonth.Text & " ") & txtOffice.Text & " - " & txtFund.Text, GridView1)
    'End Sub

    Private Sub BarLargeButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarLargeButtonItem2.ItemClick
        Me.Close()
    End Sub

    Private Sub cmdSaveButton_Click(sender As Object, e As EventArgs) Handles cmdSaveButton.Click
        LoadReport()
    End Sub
End Class

