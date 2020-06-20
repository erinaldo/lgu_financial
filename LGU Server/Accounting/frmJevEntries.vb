﻿Imports DevExpress.XtraEditors
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
        LoadXgridLookupSearch("SELECT code,Description from tblfund", "tblfund", txtFund, gridFund, Me)
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
        LoadXgrid("Select a.jevno as 'Jev No',itemname as 'Item Name',itemcode as 'Item Code',Debit,Credit,lcase(a.remarks) as 'Explaination of Entry', date_format(b.postingdate,'%d-%M-%y') as 'Date', (select shortname from tblcompoffice where officeid=b.centercode) as 'Office', (select description from tblexpenditureitem where id=b.classcode) as 'Expenditure Item', checkno as 'Check No.', dvno as 'DV #', payrollno as 'Payroll #',rcdno as 'RCD #',lrno as 'LR #',aeno as 'AE #', date_format(datetrn,'%Y-%m-%d %r') as 'Date Posted',(select fullname from tblaccounts where accountid=a.trnby) as 'Posted By', b.Cancelled from tbljournalentryvoucher as a inner join tbljournalentryitem as b on a.jevno=b.jevno where b.yeartrn='" & txtYear.Text & "' and b.fundcode='" & txtFund.EditValue & "' " & If(ckCancelled.Checked = True, "", " and b.cancelled=0") & " " & If(txtMonth.Text = "", "", " and ucase(date_format(b.postingdate,'%M')) ='" & txtMonth.Text & "'") & " order by b.jevno", "tbljournalentryvoucher", Em, GridView1, Me)
        XgridHideColumn({"Cancelled"}, GridView1)
        XgridColCurrency({"Debit", "Credit"}, GridView1)
        XgridColAlign({"Jev No", "Item Code", "Check No.", "Date", "Date Posted"}, GridView1, DevExpress.Utils.HorzAlignment.Center)
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

