﻿Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System.Drawing
Imports System.IO
Imports System.Drawing.Printing
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Base

Public Class frmDisbursementList
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean

        Return ProcessCmdKey
    End Function

    Private Sub frmRequisitionList_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Dispose()
    End Sub

    Private Sub frmRequisitionList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = ico : ApplySystemTheme(ToolStrip1)
        txtDateFrom.EditValue = CDate(Now)
        txtDateTo.EditValue = CDate(Now)
        LoadFund()
        ViewList()
        txtFund.EditValue = loadDefaultSelection(Me.Name, txtFund.Name)
    End Sub

    Public Sub LoadFund()
        LoadXgridLookupSearch("Select code, Description as 'Select'  from tblfund " & If(LCase(globalusername) = "root", "", " where code in (select fundcode from tblfundfilter where filtered_id='" & compOfficeid & "' and filtered_type='office')") & "  order by code asc", "tblfund", txtFund, gridFund)
        XgridHideColumn({"code"}, gridFund)
    End Sub

    Private Sub txtSearchBar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSearchBar.KeyPress
        If e.KeyChar() = Chr(13) Then
            If txtSearchBar.Text = "" Then Exit Sub
            ViewList()
        End If

    End Sub

    Public Sub ViewList()
        Dim KeyWordSearch As String = ""
        If txtSearchBar.Text = "" Then
            If radFilter.EditValue = "pending" Then
                KeyWordSearch = " and cleared=0 and cancelled=0 "
            ElseIf radFilter.EditValue = "cancelled" Then
                KeyWordSearch = " and cancelled=1 "
            ElseIf radFilter.EditValue = "cleared" Then
                KeyWordSearch = " and cleared=1 and cancelled=0 "
            ElseIf radFilter.EditValue = "date" Then
                KeyWordSearch = " and date_format(voucherdate,'%Y-%m-%d') between '" & ConvertDate(txtDateFrom.EditValue) & "' and '" & ConvertDate(txtDateTo.EditValue) & "' "
            End If
            'KeyWordSearch = If(ckPendingRequisition.Checked, " cleared=0 and cancelled=0 and  " & If(ckUnissuedJev.Checked, " and voucherid not in (select dvid from tbljournalentryvoucher where cancelled=0) ", ""), " fundcode='" & txtFund.EditValue & "' and date_format(voucherdate,'%Y-%m-%d') between '" & ConvertDate(txtDateFrom.EditValue) & "' and '" & ConvertDate(txtDateTo.EditValue) & "' ")
        Else
            KeyWordSearch = " and (pid like '%" & rchar(txtSearchBar.Text) & "%' or " _
                        + " voucherno Like '%" & rchar(txtSearchBar.Text) & "%' or " _
                        + " checkno Like '%" & rchar(txtSearchBar.Text) & "%' or " _
                        + " date_format(voucherdate,'%Y-%m-%d') like '%" & rchar(txtSearchBar.Text) & "%' or " _
                        + " amount like '%" & rchar(txtSearchBar.Text) & "%' or " _
                        + " (select purpose from tblrequisition where pid=a.pid) like '%" & rchar(txtSearchBar.Text) & "%' or " _
                        + " (select suppliername from tblsupplier where supplierid = a.supplierid) like '%" & rchar(txtSearchBar.Text) & "%')"
        End If
        If CheckEdit1.Checked Then
            LoadXgrid("SELECT voucherid as 'Entry Code', " _
                        + " voucherno as 'Voucher No.', " _
                        + " date_format(voucherdate,'%Y-%m-%d') as 'Voucher Date', " _
                        + " (select suppliername from tblsupplier where supplierid = a.supplierid) as 'Payee', " _
                        + " checkissued as 'Check Issued', " _
                        + " checkno as 'Check No.', " _
                        + " checkamount as 'Check Amount', " _
                        + " (select description from tblbankaccounts where code=a.checkbank) as 'Bank Name', " _
                        + " date_format(checkdate,'%Y-%m-%d') as 'Check Date' " _
                        + " FROM tbldisbursementvoucher as a where fundcode='" & txtFund.EditValue & "' " & If(ckUnissuedJev.Checked, " and voucherid not in (select dvid from tbljournalentryvoucher where cancelled=0) ", "") _
                        + KeyWordSearch _
                        + " order by voucherno asc", "tbldisbursementvoucher", Em, GridView1, Me)

            XgridColCurrency({"Check Amount"}, GridView1)
            XgridColAlign({"Entry Code", "Voucher No.", "JEV No.", "Status", "Fund Period", "Type of Payment", "Voucher Date", "Check No.", "Check Date", "Date Posted", "Cleared", "Date Cleared", "Cancelled", "Date Cancelled"}, GridView1, DevExpress.Utils.HorzAlignment.Center)
            XgridGeneralSummaryCurrency({"Check Amount"}, GridView1)
            GridView1.BestFitColumns()
            DXgridColumnIndexing(Me.Name & "-check", GridView1)
            SaveFilterColumn(GridView1, Me.Name & "-check")
        Else
            LoadXgrid("SELECT pid, voucherid as 'Entry Code',periodcode,officeid, if(cancelled,'CANCELLED',if(cleared,'CLEARED', if(checkissued, 'CHECK ISSUED', 'PENDING'))) as Status, " _
                        + " voucherno as 'Voucher No.', " _
                        + " (select officename from tblcompoffice where officeid = a.officeid) as 'Office', " _
                        + " (select jevno from tbljournalentryvoucher where dvid=a.voucherid and cancelled=0 limit 1) as 'JEV No.', " _
                        + " concat((select codename from tblfund where code=a.fundcode),'-',yearcode) as 'Fund Period',  " _
                        + " Amount, " _
                        + " (select suppliername from tblsupplier where supplierid = a.supplierid) as 'Payee', " _
                        + " date_format(voucherdate,'%Y-%m-%d') as 'Voucher Date', " _
                        + " checkissued as 'Check Issued', " _
                        + " checkno as 'Check No.', " _
                        + " checkamount as 'Check Amount', " _
                        + " (select description from tblbankaccounts where code=a.checkbank) as 'Bank Name', " _
                        + " date_format(checkdate,'%Y-%m-%d') as 'Check Date', " _
                        + " (select fullname from tblaccounts where accountid=a.trnby) as 'Posted By', " _
                        + " date_format(datetrn,'%Y-%m-%d') as 'Date Posted', " _
                        + " Cleared, date_format(datecleared,'%Y-%m-%d') as 'Date Cleared', " _
                        + " Cancelled, date_format(datecancelled,'%Y-%m-%d') as 'Date Cancelled', " _
                        + " (select purpose from tblrequisition where pid=a.pid) as Remarks " _
                        + " FROM tbldisbursementvoucher as a " _
                        + " where fundcode='" & txtFund.EditValue & "' " & If(ckUnissuedJev.Checked, " and voucherid not in (select dvid from tbljournalentryvoucher where cancelled=0) ", "") _
                        + KeyWordSearch _
                        + " order by voucherno asc", "tbldisbursementvoucher", Em, GridView1, Me)

            XgridColCurrency({"Amount", "Check Amount"}, GridView1)
            XgridHideColumn({"periodcode", "officeid", "pid"}, GridView1)
            XgridColAlign({"Entry Code", "Voucher No.", "JEV No.", "Status", "Fund Period", "Type of Payment", "Voucher Date", "Check No.", "Check Date", "Date Posted", "Cleared", "Date Cleared", "Cancelled", "Date Cancelled"}, GridView1, DevExpress.Utils.HorzAlignment.Center)
            XgridGeneralSummaryCurrency({"Amount", "Check Amount"}, GridView1)
            GridView1.BestFitColumns()
            DXgridColumnIndexing(Me.Name & "-all", GridView1)
            SaveFilterColumn(GridView1, Me.Name & "-all")
        End If
        SaveDefaultSelection(Me.Name, txtFund.Name, txtFund.EditValue)
    End Sub

    Private Sub gridview1_RowCellStyle(ByVal sender As Object, ByVal e As RowCellStyleEventArgs) Handles GridView1.RowCellStyle
        If CheckEdit1.Checked = False Then
            Dim View As GridView = sender
            Dim status As String = View.GetRowCellDisplayText(e.RowHandle, View.Columns("Status"))
            If status = "CANCELLED" Then
                e.Appearance.ForeColor = Color.Red
                If Not gen_fontfamily Is Nothing Then
                    e.Appearance.Font = New Font(gen_fontfamily, gen_FontSize, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, (CByte(204)))
                End If
            Else
                If e.Column.Name = "colStatus" Then
                    If status = "PENDING" Then
                        e.Appearance.BackColor = Color.Orange
                        e.Appearance.BackColor2 = Color.Orange
                        e.Appearance.ForeColor = Color.Black

                    ElseIf status = "CHECK ISSUED" Then
                        e.Appearance.BackColor = Color.LightSkyBlue
                        e.Appearance.BackColor2 = Color.LightSkyBlue
                        e.Appearance.ForeColor = Color.Black

                    ElseIf status = "CLEARED" Then
                        e.Appearance.BackColor = Color.Green
                        e.Appearance.BackColor2 = Color.Green
                        e.Appearance.ForeColor = Color.White
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub GridView1_DragObjectDrop(sender As Object, e As DevExpress.XtraGrid.Views.Base.DragObjectDropEventArgs) Handles GridView1.DragObjectDrop
        XgridColumnDropChanged(GridView1, Me.Name & If(CheckEdit1.Checked, "-check", "-all"))
    End Sub

    Private Sub GridView1_ColumnWidthChanged(sender As Object, e As ColumnEventArgs) Handles GridView1.ColumnWidthChanged
        XgridColumnWidthChanged(GridView1, Me.Name & If(CheckEdit1.Checked, "-check", "-all"))
    End Sub

    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles cmdPrint.Click
        If CheckEdit1.Checked Then
            DXExportGridToExcel("Check Issuance Report", GridView1)
        Else
            DXExportGridToExcel(Me.Text, GridView1)
        End If

    End Sub

    Private Sub cmdNew_Click(sender As Object, e As EventArgs)
        If globalAllowAdd = False Then
            MessageBox.Show("Your access not allowed to add!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

    End Sub

    Private Sub cmdLocalData_Click(sender As Object, e As EventArgs) Handles cmdLocalData.Click
        ViewList()
    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        If globalAllowDelete = False Then
            XtraMessageBox.Show("Your access not allowed to delete!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
            'ElseIf CBool(GridView1.GetFocusedRowCellValue("Cleared").ToString) Then
            '    XtraMessageBox.Show("Selected request is already cleared!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error)
            '    Exit Sub

        ElseIf CBool(GridView1.GetFocusedRowCellValue("Cancelled").ToString) Then
            XtraMessageBox.Show("Selected request is already cancelled!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        frmApprovalConfirmation.RequiredAdminOveride = True
        frmApprovalConfirmation.mode.Text = "cancel"
        frmApprovalConfirmation.ShowDialog(Me)
        If frmApprovalConfirmation.TransactionDone = True Then
            For I = 0 To GridView1.SelectedRowsCount - 1
                CancelVoucher(GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "Entry Code"), GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "pid"), frmApprovalConfirmation.txtRemarks.Text)

            Next
            ViewList()
            frmApprovalConfirmation.Close()
            XtraMessageBox.Show("Voucher successfully cancelled!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Information)

            frmApprovalConfirmation.TransactionDone = False
            frmApprovalConfirmation.Dispose()
        End If

    End Sub


    Private Sub CmdColumnSettings_Click(sender As Object, e As EventArgs) Handles cmdColumnSettings.Click
        Dim colname As String = ""
        For I = 0 To GridView1.Columns.Count - 1
            colname += GridView1.Columns(I).FieldName & ","
        Next
        frmColumnFilter.txtColumn.Text = colname.Remove(colname.Count - 1, 1)

        frmColumnFilter.GetFilterInfo(GridView1, If(CheckEdit1.Checked, Me.Text & "-check", Me.Text & "-all"))
        frmColumnFilter.ShowDialog(Me)
    End Sub

    Private Sub cmdFilterSearch_Click(sender As Object, e As EventArgs) Handles cmdFilterSearch.Click
        ViewList()
    End Sub

    Private Sub Em_DoubleClick(sender As Object, e As EventArgs) Handles Em.DoubleClick
        cmdView.PerformClick()
    End Sub



    Private Sub cmdClearedDisbursement_Click(sender As Object, e As EventArgs) Handles cmdClearedDisbursement.Click
        If globalSpecialApprover = False And globalRootUser = False Then
            XtraMessageBox.Show("Your access not allowed to clear transaction!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        ElseIf CBool(GridView1.GetFocusedRowCellValue("Cleared").ToString) Then
            XtraMessageBox.Show("Selected request is already Cleared!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        ElseIf CBool(GridView1.GetFocusedRowCellValue("Cancelled").ToString) Then
            XtraMessageBox.Show("Selected request is already cancelled!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        ElseIf countqry("tbljournalentryvoucher", "dvid='" & GridView1.GetFocusedRowCellValue("Entry Code").ToString & "' and cancelled=0") = 0 Then
            XtraMessageBox.Show("No JEV found on this disbursement voucher! unable to clear", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        ElseIf GridView1.GetFocusedRowCellValue("Check No.").ToString = "" Then
            XtraMessageBox.Show("Please enter check number and check details!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        ElseIf GridView1.GetFocusedRowCellValue("Bank Name").ToString = "" Then
            XtraMessageBox.Show("Please update check bank name!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If XtraMessageBox.Show("Are you sure you want to continue?", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            Dim I As Integer = 0
            For I = 0 To GridView1.SelectedRowsCount - 1
                If GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "Check No.") <> "" Then
                    com.CommandText = "update tbldisbursementvoucher set cleared=1,clearedby='" & globaluserid & "',datecleared=current_timestamp where voucherid='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "Entry Code") & "' " : com.ExecuteNonQuery()
                    com.CommandText = "update tblrequisition set cleared=1 where pid ='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "pid") & "'" : com.ExecuteNonQuery()
                End If
            Next
            ViewList()
            XtraMessageBox.Show("Disbursement successfully cleared!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub CreateJEVTransactionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreateJEVTransactionToolStripMenuItem.Click
        If countqry("tbljournalentryvoucher", "dvid='" & GridView1.GetFocusedRowCellValue("Entry Code").ToString & "' and cancelled=0") > 0 Then
            XtraMessageBox.Show("JEV is already created for this disbursement voucher!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        ElseIf globalAuthJournalEntryVoucher = False Then
            XtraMessageBox.Show("Your access is not allowed to create JEV!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        frmJournalEntry.pid.Text = GridView1.GetFocusedRowCellValue("pid").ToString
        frmJournalEntry.dvid.Text = GridView1.GetFocusedRowCellValue("Entry Code").ToString
        frmJournalEntry.periodcode.Text = GridView1.GetFocusedRowCellValue("periodcode").ToString
        frmJournalEntry.txtRemarks.Text = GridView1.GetFocusedRowCellValue("Remarks").ToString
        frmJournalEntry.officeid.Text = GridView1.GetFocusedRowCellValue("officeid").ToString
        frmJournalEntry.txtOffice.Text = GridView1.GetFocusedRowCellValue("Office").ToString
        frmJournalEntry.ShowDialog(Me)
    End Sub

    Private Sub CheckIssuanceInfoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CheckIssuanceInfoToolStripMenuItem.Click
        If globalSpecialApprover = False And globalRootUser = False Then
            XtraMessageBox.Show("Your access not allowed to clear transaction!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        ElseIf countqry("tbljournalentryvoucher", "dvid='" & GridView1.GetFocusedRowCellValue("Entry Code").ToString & "' and cancelled=0") = 0 Then
            XtraMessageBox.Show("No journal entry for this voucher please create before issuing check", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        ElseIf GridView1.GetFocusedRowCellValue("Bank Name").ToString = "" Then
            XtraMessageBox.Show("No bank account for check issuance! Please contact accounting", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        ElseIf countqry("tblrequisition", "pid='" & GridView1.GetFocusedRowCellValue("pid").ToString & "' and approved=1 and checkapproved=0 and cancelled=0") > 0 Then
            XtraMessageBox.Show("Issuing check for this voucher is not allowed!" & Environment.NewLine & "Request is currently for approval for check issuance ", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
            'ElseIf CBool(GridView1.GetFocusedRowCellValue("Cleared").ToString) Then
            '    XtraMessageBox.Show("Selected request is already Cleared!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error)
            '    Exit Sub
            'ElseIf CBool(GridView1.GetFocusedRowCellValue("Cancelled").ToString) Then
            '    XtraMessageBox.Show("Selected request is already cancelled!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error)
            '    Exit Sub
        End If
        frmVoucherCheckInfo.id.Text = GridView1.GetFocusedRowCellValue("Entry Code").ToString
        frmVoucherCheckInfo.ShowDialog(Me)
    End Sub

    Private Sub PrintVoucherToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintVoucherToolStripMenuItem.Click
        If CBool(GridView1.GetFocusedRowCellValue("Cancelled").ToString) Then
            XtraMessageBox.Show("Printing not allowed! Selected voucher is already cancelled!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        ElseIf CBool(GridView1.GetFocusedRowCellValue("Check Issued").ToString) = False Then
            XtraMessageBox.Show("Voucher check is currently not issued! ", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        PrintDisbursementVoucher(GridView1.GetFocusedRowCellValue("Entry Code").ToString, True, Me)
    End Sub

    Private Sub cmdView_Click(sender As Object, e As EventArgs) Handles cmdView.Click
        If CheckEdit1.Checked = False Then
            frmRequisitionInfo.mode.Text = ""
            frmRequisitionInfo.pid.Text = GridView1.GetFocusedRowCellValue("pid").ToString
            frmRequisitionInfo.mode.Text = "edit"
            If frmRequisitionInfo.Visible = False Then
                frmRequisitionInfo.Show(Me)
            Else
                frmRequisitionInfo.WindowState = FormWindowState.Normal
            End If
        End If

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        frmVoucherExport.ShowDialog(Me)
    End Sub

    Private Sub ExportVoucherFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportVoucherFileToolStripMenuItem.Click
        If CBool(GridView1.GetFocusedRowCellValue("Cancelled").ToString) Then
            XtraMessageBox.Show("Printing not allowed! Selected voucher is already cancelled!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        ElseIf CBool(GridView1.GetFocusedRowCellValue("Check Issued").ToString) = False Then
            XtraMessageBox.Show("Voucher check is currently not issued! ", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Using frm = FolderBrowserDialog1
            If frm.ShowDialog(Me) = DialogResult.OK Then
                Dim Location As String = frm.SelectedPath
                VoucherExporter(False, "voucherid='" & GridView1.GetFocusedRowCellValue("Entry Code").ToString & "'", Location, Nothing, Me)
            End If
        End Using
    End Sub

    Private Sub CheckEdit1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckEdit1.CheckedChanged
        If CheckEdit1.Checked Then
            Em.ContextMenuStrip = Nothing
        Else
            Em.ContextMenuStrip = cms_em
        End If
        ViewList()
    End Sub

    Private Sub CheckEdit2_CheckedChanged(sender As Object, e As EventArgs) Handles ckUnissuedJev.CheckedChanged
        ViewList()
    End Sub

    Private Sub txtFund_EditValueChanged(sender As Object, e As EventArgs) Handles txtFund.EditValueChanged
        If txtFund.EditValue = "" Then Exit Sub
        ViewList()
    End Sub

    Private Sub radFilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles radFilter.SelectedIndexChanged
        If radFilter.EditValue = "date" Then
            txtDateFrom.Enabled = True
            txtDateTo.Enabled = True
        Else
            txtDateFrom.Enabled = False
            txtDateTo.Enabled = False
        End If
        ViewList()
    End Sub
End Class