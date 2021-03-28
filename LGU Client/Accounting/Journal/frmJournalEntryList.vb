Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System.Drawing
Imports System.IO
Imports System.Drawing.Printing
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Base

Public Class frmJournalEntryList
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

        ViewList()
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
            KeyWordSearch = If(ckPendingRequisition.Checked, " cleared=0 and cancelled=0  ", " date_format(postingdate,'%Y-%m-%d') between '" & ConvertDate(txtDateFrom.EditValue) & "' and '" & ConvertDate(txtDateTo.EditValue) & "' ")
        Else
            KeyWordSearch = " (jevno like '%" & rchar(txtSearchBar.Text) & "%' or " _
                        + " date_format(postingdate,'%Y-%m-%d') like '%" & rchar(txtSearchBar.Text) & "%')"
        End If
        LoadXgrid("SELECT id as 'Entry Code', pid, if(cancelled,'CANCELLED',if(cleared,'CLEARED', 'PENDING')) as Status, " _
                        + " jevno as 'JEV No.', " _
                        + " concat((select codename from tblfund where code=a.fundcode),'-',yeartrn) as 'Fund Period',  " _
                        + " (select officename from tblcompoffice where officeid = a.officeid) as 'Office', " _
                        + " date_format(postingdate,'%Y-%m-%d') as 'Posting Date', " _
                        + " (select sum(debit) from tbljournalentryitem where jevno=a.jevno) as Amount, Remarks, " _
                        + " (select voucherno from tbldisbursementvoucher where voucherid=a.dvid) as 'DV #', payrollno as 'Payroll #',rcdno as 'RCD #',lrno as 'LR #',aeno as 'AE #', " _
                        + " (select fullname from tblaccounts where accountid=a.trnby) as 'Posted By', " _
                        + " date_format(datetrn,'%Y-%m-%d') as 'Date Posted', " _
                        + " Cleared, date_format(datecleared,'%Y-%m-%d') as 'Date Cleared', " _
                        + " Cancelled, date_format(datecancelled,'%Y-%m-%d') as 'Date Cancelled' " _
                        + " FROM tbljournalentryvoucher as a " _
                        + " where  " _
                        + KeyWordSearch _
                        + " order by jevno asc", "tbljournalentryvoucher", Em, GridView1, Me)
        XgridHideColumn({"pid"}, GridView1)
        XgridColCurrency({"Amount"}, GridView1)
        XgridColAlign({"Entry Code", "JEV No.", "Status", "Fund Period", "Posting Date", "Date Posted", "Cleared", "Date Cleared", "Cancelled", "Date Cancelled"}, GridView1, DevExpress.Utils.HorzAlignment.Center)
        XgridColAlign({"DV #", "Payroll #", "RCD #", "LR #", "AE #"}, GridView1, DevExpress.Utils.HorzAlignment.Center)
        XgridGeneralSummaryCurrency({"Amount"}, GridView1)
        GridView1.BestFitColumns()
        XgridColWidth({"Remarks"}, GridView1, 250)
        GridView1.Columns("Remarks").OptionsColumn.AllowEdit = False
        GridView1.Columns("Remarks").OptionsColumn.AllowFocus = False

        'GridView1.Columns("Remarks").AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        'GridView1.Columns("Remarks").ColumnEdit = MemoEdit
        DXgridColumnIndexing(Me.Name, GridView1)
        SaveFilterColumn(GridView1, Me.Text)
    End Sub

    Private Sub gridview1_RowCellStyle(ByVal sender As Object, ByVal e As RowCellStyleEventArgs) Handles GridView1.RowCellStyle
        Dim View As GridView = sender
        Dim status As String = View.GetRowCellDisplayText(e.RowHandle, View.Columns("Status"))
        If status = "CANCELLED" Then
            e.Appearance.ForeColor = Color.Red
            e.Appearance.Font = New Font(gen_fontfamily, gen_FontSize, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, (CByte(204)))
        Else
            If e.Column.Name = "colStatus" Then
                If status = "PENDING" Then
                    e.Appearance.BackColor = Color.Orange
                    e.Appearance.BackColor2 = Color.Orange
                    e.Appearance.ForeColor = Color.Black

                ElseIf status = "CLEARED" Then
                    e.Appearance.BackColor = Color.Green
                    e.Appearance.BackColor2 = Color.Green
                    e.Appearance.ForeColor = Color.White
                End If
            End If
        End If


    End Sub

    Private Sub GridView1_DragObjectDrop(sender As Object, e As DevExpress.XtraGrid.Views.Base.DragObjectDropEventArgs) Handles GridView1.DragObjectDrop
        XgridColumnDropChanged(GridView1, Me.Name)
    End Sub

    Private Sub GridView1_ColumnWidthChanged(sender As Object, e As ColumnEventArgs) Handles GridView1.ColumnWidthChanged
        XgridColumnWidthChanged(GridView1, Me.Name)
    End Sub

    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles cmdPrint.Click
        DXExportGridToExcel(Me.Text, GridView1)
    End Sub

    Private Sub cmdNew_Click(sender As Object, e As EventArgs)
        If globalAllowAdd = False Then
            MessageBox.Show("Your access not allowed to add!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        frmJournalEntry.ShowDialog(Me)
    End Sub

    Private Sub cmdLocalData_Click(sender As Object, e As EventArgs) Handles cmdLocalData.Click
        ViewList()
    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        If globalAllowDelete = False Then
            XtraMessageBox.Show("Your access not allowed to cancel!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        ElseIf CBool(GridView1.GetFocusedRowCellValue("Cleared").ToString) Then
            XtraMessageBox.Show("Selected entry is already cleared!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub

        ElseIf CBool(GridView1.GetFocusedRowCellValue("Cancelled").ToString) Then
            XtraMessageBox.Show("Selected entry is already cancelled!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If XtraMessageBox.Show("Are you sure you want to continue?", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            Dim I As Integer = 0
            For I = 0 To GridView1.SelectedRowsCount - 1
                com.CommandText = "update tbljournalentryvoucher set cancelled=1,cancelledby='" & globaluserid & "',datecancelled=current_timestamp where jevno='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "JEV No.") & "' " : com.ExecuteNonQuery()
                com.CommandText = "update tbljournalentryitem set cancelled=1  where jevno='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "JEV No.") & "'" : com.ExecuteNonQuery()
                com.CommandText = "update `tblrequisition` set jev=0 where pid='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "pid") & "'" : com.ExecuteNonQuery()
            Next
            ViewList()
            XtraMessageBox.Show("JEV successfully cancelled!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub cmdView_Click(sender As Object, e As EventArgs) Handles cmdView.Click
        frmJournalEntry.mode.Text = ""
        frmJournalEntry.jevno.Text = GridView1.GetFocusedRowCellValue("JEV No.").ToString
        frmJournalEntry.mode.Text = "edit"
        If frmJournalEntry.Visible = False Then
            frmJournalEntry.Show(Me)
        Else
            frmJournalEntry.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub CmdColumnSettings_Click(sender As Object, e As EventArgs) Handles cmdColumnSettings.Click
        Dim colname As String = ""
        For I = 0 To GridView1.Columns.Count - 1
            colname += GridView1.Columns(I).FieldName & ","
        Next
        frmColumnFilter.txtColumn.Text = colname.Remove(colname.Count - 1, 1)
        frmColumnFilter.GetFilterInfo(GridView1, Me.Text)
        frmColumnFilter.ShowDialog(Me)
    End Sub

    Private Sub cmdFilterSearch_Click(sender As Object, e As EventArgs) Handles cmdFilterSearch.Click
        ViewList()
    End Sub

    Private Sub Em_DoubleClick(sender As Object, e As EventArgs) Handles Em.DoubleClick
        frmJournalEntry.mode.Text = ""
        frmJournalEntry.jevno.Text = GridView1.GetFocusedRowCellValue("JEV No.").ToString
        frmJournalEntry.mode.Text = "edit"
        If frmJournalEntry.Visible = False Then
            frmJournalEntry.Show(Me)
        Else
            frmJournalEntry.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub ckPendingRequisition_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ckPendingRequisition_CheckedChanged_1(sender As Object, e As EventArgs) Handles ckPendingRequisition.CheckedChanged
        If ckPendingRequisition.Checked Then
            txtDateFrom.Enabled = False
            txtDateTo.Enabled = False
        Else
            txtDateFrom.Enabled = True
            txtDateTo.Enabled = True
        End If
        ViewList()
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
        End If
        If XtraMessageBox.Show("Are you sure you want to continue?", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            Dim I As Integer = 0
            For I = 0 To GridView1.SelectedRowsCount - 1
                com.CommandText = "update tbljournalentryvoucher set cleared=1,clearedby='" & globaluserid & "',datecleared=current_timestamp where jevno='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "JEV No.") & "' " : com.ExecuteNonQuery()
                'com.CommandText = "insert into tbltransactionentries (fundcode,yeartrn,postingdate,officeid,jevno,cifid,ornumber,itemcode,itemname,explaination, debit,credit,cashflowcode,collection,formcode,invrefcode,datetrn,trnby) " _
                '        + "select fundcode,yeartrn,postingdate,centercode,jevno,'','',itemcode,itemname,'" & rchar(GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "Remarks")) & "', debit,credit,'',0,'','',current_timestamp,'" & globaluserid & "' from tbljournalentryitem where jevno='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "JEV No.") & "'" : com.ExecuteNonQuery()
            Next
            ViewList()
            XtraMessageBox.Show("Journal entry voucher successfully cleared!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class