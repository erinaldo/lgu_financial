Imports DevExpress.XtraEditors
Imports MySql.Data.MySqlClient
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraReports.UI
Imports DevExpress.Skins
Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmReportEntries
    Private Sub frmReportEntries_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadFund()
    End Sub

    Public Sub LoadFund()
        LoadXgridLookupSearch("SELECT code,Description from tblfund " & If(LCase(globaluser) = "root", "", " where code in (select fundcode from tblfundfilter where filtered_id='" & globalPermissionAccess & "' and filtered_type='server')") & " ", "tblfund", txtFund, gridFund, Me)
        gridFund.Columns("code").Visible = False
    End Sub

    Private Sub txtFund_EditValueChanged(sender As Object, e As EventArgs) Handles txtFund.EditValueChanged
        LoadYear()
    End Sub

    Public Sub LoadYear()
        LoadToComboBox("yeartrn", "tblfundperiod where fundcode='" & txtFund.EditValue & "'", txtYear, True)
    End Sub

    Private Sub cmdSaveButton_Click(sender As Object, e As EventArgs) Handles cmdSaveButton.Click
        LoadReport()
    End Sub
    Public Sub LoadReport()
        LoadXgrid("Select jevno as 'Jev No',itemname as 'Item Name',itemcode as 'Item Code',Debit,Credit,lcase(explaination) as 'Explaination of Entry', ornumber as 'OR Number', " _
                  + " (select fullname from tbltaxpayerprofile where cifid=a.cifid) as 'Tax Payer Name', " _
                  + " date_format(postingdate,'%d-%M-%y') as 'Date', (select shortname from tblcompoffice where officeid=a.officeid) as 'Office', " _
                  + " (select (select cashflowname from tblcashflowitem where code=b.cashflowcode) from tblcashflowtagging as b where glitemcode=a.itemcode limit 1) as 'Cash Flow Item', " _
                  + " date_format(datetrn,'%Y-%m-%d %r') as 'Date Posted',(select fullname from tblaccounts where accountid=a.trnby) as 'Posted By', " _
                  + " Cancelled from tbltransactionentries as a where yeartrn='" & txtYear.Text & "' and fundcode='" & txtFund.EditValue & "' " & If(ckCancelled.Checked = True, "", " and cancelled=0") & " " & If(txtMonth.Text = "", "", " and ucase(date_format(postingdate,'%M')) ='" & txtMonth.Text & "'") & " " & If(CheckEdit1.Checked = True, " and cast(ornumber as unsigned) between " & txtRangeFrom.Text & " and " & txtRangeTo.Text & "", "") & " order by " & If(CheckEdit1.Checked = True, "ornumber asc", "postingdate,ornumber") & " ", "tblfundperiod", Em, GridView1, Me)
        XgridHideColumn({"Cancelled"}, GridView1)
        XgridColCurrency({"Debit", "Credit"}, GridView1)
        XgridColAlign({"Jev No", "Item Code", "OR Number", "Date", "Date Posted"}, GridView1, DevExpress.Utils.HorzAlignment.Center)
        XgridGeneralSummaryCurrency({"Debit", "Credit"}, GridView1)
        GridView1.BestFitColumns()
        GridView1.Columns("Explaination of Entry").Width = 300
    End Sub

    Private Sub gridview1_RowCellStyle(ByVal sender As Object, ByVal e As RowCellStyleEventArgs) Handles GridView1.RowCellStyle
        Dim View As GridView = sender
        If GridView1.RowCount > 0 Then
            Dim status As Boolean = CBool(GridView1.GetRowCellValue(e.RowHandle, "Cancelled").ToString)
            If status = True Then
                e.Appearance.ForeColor = Color.Red
                e.Appearance.Font = New Font(gen_fontfamily, gen_FontSize, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, (CByte(204)))
            End If
        End If

    End Sub
    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        ExportGridToExcel(Me.Text & " " & If(txtMonth.Text = "", "", txtMonth.Text & " ") & txtYear.Text & " - " & txtFund.Text, GridView1)
    End Sub

    Private Sub BarLargeButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarLargeButtonItem2.ItemClick
        Me.Close()
    End Sub

    Private Sub CheckEdit1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckEdit1.CheckedChanged
        If CheckEdit1.Checked = True Then
            txtRangeFrom.Enabled = True
            txtRangeTo.Enabled = True
            'cmdRange.Enabled = True
        Else
            txtRangeFrom.Enabled = False
            txtRangeTo.Enabled = False
            'cmdRange.Enabled = False
        End If
    End Sub

    Private Sub cmdRange_Click(sender As Object, e As EventArgs) Handles cmdRange.Click
        LoadReport()
    End Sub
End Class

