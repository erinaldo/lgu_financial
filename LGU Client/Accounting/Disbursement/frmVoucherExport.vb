Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO
Imports DevExpress.XtraEditors

Public Class frmVoucherExport
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmVoucherCheckInfo_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub
    Private Sub frmVoucherCheckInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico
        LoadYear()
        LoadFund()
    End Sub

    Public Sub LoadYear()
        DXLoadToComboBox("yeartrn", "tblfundperiod", txtYear, True)
    End Sub
    Private Sub txtYear_SelectedValueChanged(sender As Object, e As EventArgs) Handles txtYear.SelectedValueChanged
        LoadRecords()
    End Sub
    Public Sub LoadFund()
        LoadXgridLookupSearch("SELECT code,Description from tblfund", "tblfund", txtFund, gridFund)
        gridFund.Columns("code").Visible = False
    End Sub
    Private Sub txtFund_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFund.EditValueChanged
        On Error Resume Next
        LoadRecords()
    End Sub
    Private Sub txtMonth_SelectedValueChanged(sender As Object, e As EventArgs) Handles txtMonth.SelectedValueChanged
        LoadRecords()
    End Sub
    Public Sub LoadRecords()
        If txtYear.Text = "" Or txtFund.Text = "" Or txtMonth.Text = "" Then Exit Sub
        Dim totalRecords As Integer = countqry("tbldisbursementvoucher", "cancelled=0 and checkissued=1 and fundcode='" & txtFund.EditValue & "' and date_format(voucherdate, '%Y-%m')='" & txtYear.Text & "-" & String.Format("{0:0#}", Month(txtMonth.EditValue & " 1, " & txtYear.Text)) & "'")

        txtTotalVoucher.Text = totalRecords & " total disbursement voucher records"
    End Sub
    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        If txtYear.Text = "" Then
            XtraMessageBox.Show("Please select year!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtYear.Focus()
            Exit Sub
        ElseIf txtFund.Text = "" Then
            XtraMessageBox.Show("Please select fund type", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtFund.Focus()
            Exit Sub
        ElseIf txtMonth.Text = "" Then
            XtraMessageBox.Show("Please select month", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtMonth.Focus()
            Exit Sub
        End If

        Using frm = FolderBrowserDialog1
            If frm.ShowDialog(Me) = DialogResult.OK Then
                Dim Location As String = frm.SelectedPath
                VoucherExporter(True, "cancelled=0 and checkissued=1 and fundcode='" & txtFund.EditValue & "' and date_format(voucherdate, '%Y-%m')='" & txtYear.Text & "-" & String.Format("{0:0#}", Month(txtMonth.EditValue & " 1, " & txtYear.Text)) & "'", Location, ProgressBarControl1, Me)
            End If
        End Using
    End Sub


End Class