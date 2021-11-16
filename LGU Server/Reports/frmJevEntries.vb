Imports DevExpress.XtraEditors
Imports MySql.Data.MySqlClient
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraReports.UI
Imports DevExpress.Skins
Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmJevEntries
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
        Dim payeename As String = "ifnull((select suppliername from tblsupplier inner join tbldisbursementvoucher on tblsupplier.supplierid = tbldisbursementvoucher.supplierid where voucherid = a.dvid),'')"
        LoadXgrid("Select a.jevno as 'Jev No', itemname as 'Item Name',itemcode as 'Item Code',Debit,Credit,concat(if(" & payeename & "<>'',concat('('," & payeename & ",')'),''),' ', lcase(a.remarks))  as 'Explaination of Entry', " _
                  + " date_format(b.postingdate,'%d-%M-%y') as 'Date', " _
                  + " (select shortname from tblcompoffice where officeid=b.centercode) as 'Office', " _
                  + " concat((select shortname from tblcompoffice where officeid=b.centercode), '_',(select expenditurecode from tblexpendituretagging where glitemcode=b.classcode)) as 'Expenditure Classification', " _
                  + " (select itemname from tblglitem where itemcode=b.classcode) as 'Expenditure Item', " _
                  + " (select checkno from tbldisbursementvoucher where voucherid=a.dvid) as 'Check No.', " _
                  + " (select (select description from tblbankaccounts where code=tbldisbursementvoucher.checkbank) from tbldisbursementvoucher where voucherid=a.dvid) as 'Bank Account', " _
                  + " (select group_concat(requestno) from tblrequisition where pid=a.pid) as 'CAFOA/FURS', " _
                  + " (select voucherno from tbldisbursementvoucher where voucherid=a.dvid) as 'ChkDJ #', payrollno as 'Payroll #',rcdno as 'RCD #',lrno as 'LR #',aeno as 'AE #', " _
                  + " (select cashflowname from tblcashflowitem where code=b.cashflowitem) as 'Cash Flow Item'," _
                  + " date_format(datetrn,'%Y-%m-%d %r') as 'Date Posted',(select fullname from tblaccounts where accountid=a.trnby) as 'Posted By', b.Cancelled, if(b.Cancelled,'CANCELLED','VERIFIED') as Status from tbljournalentryvoucher as a inner join tbljournalentryitem as b on a.jevno=b.jevno where b.yeartrn='" & txtYear.Text & "' and b.fundcode='" & txtFund.EditValue & "' " & If(ckCancelled.Checked = True, "", " and b.cancelled=0") & " " & If(txtMonth.Text = "", "", " and ucase(date_format(b.postingdate,'%M')) ='" & txtMonth.Text & "'") & " order by b.jevno", "tbljournalentryvoucher", Em, GridView1, Me)
        XgridHideColumn({"Cancelled"}, GridView1)
        XgridColCurrency({"Debit", "Credit"}, GridView1)
        XgridColAlign({"Jev No", "Item Code", "Check No.", "Date", "Date Posted", "Status"}, GridView1, DevExpress.Utils.HorzAlignment.Center)
        XgridColAlign({"DV #", "Payroll #", "RCD #", "LR #", "AE #"}, GridView1, DevExpress.Utils.HorzAlignment.Center)
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
End Class

