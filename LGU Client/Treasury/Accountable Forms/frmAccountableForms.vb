Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System.Drawing
Imports System.IO
Imports System.Drawing.Printing
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Base

Public Class frmAccountableForms
    ' The class that will do the printing process.
    Private BandgridView As GridView
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean

        Return ProcessCmdKey
    End Function

    Private Sub frmAccountableForms_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = ico
        ApplySystemTheme(ToolStrip3)
        LoadForm()
        ViewList()
    End Sub

    Public Sub LoadForm()
        LoadXgridLookupSearch("SELECT code,Description from tblaccountableform order by Description", "tblaccountableform", txtForm, gridForm)
        gridForm.Columns("code").Visible = False
    End Sub

    Public Sub ViewList()
        LoadXgrid("Select  id as 'Inventory Code',accountable, (select description from tblaccountableform where code=a.formcode) as 'Form',formcode as 'Form Code', SeriesFrom,SeriesTo,CurrentNo,  (select sum(credit) from tbltransactionentries where cancelled=0 and invrefcode=a.id and ornumber between a.seriesfrom and a.seriesto) as 'Total Collection', (select fullname from tblaccounts where accountid=a.accountable) as 'Accountable Person', InUsed, " & FormatDate("dateupdated", False) & " as 'Date Updated',   (select fullname from tblaccounts where accountid=a.entryby) as 'Entry By' , " & FormatDate("dateentry", False) & " as 'Date Entry' " _
                  + " from tblforminventory as a where inused=" & ckCurrentlyInUsed.CheckState & If(ckViewAllForms.Checked = True, "", " and formcode='" & txtForm.EditValue & "' ") & " " & If(LCase(globalusername) = "root" Or globalSpecialApprover = True, "", " and officeid='" & compOfficeid & "'") & " order by seriesfrom asc", "tblforminventory", Em, GridView1, Me)
        XgridHideColumn({"accountable"}, GridView1)
        XgridColAlign({"Inventory Code", "Form Code", "SeriesFrom", "SeriesTo", "CurrentNo", "Date Updated", "Date Entry"}, GridView1, DevExpress.Utils.HorzAlignment.Center)
        XgridColCurrency({"Total Collection"}, GridView1)
        XgridGeneralSummaryCurrency({"Total Collection"}, GridView1)
        DXgridColumnIndexing(Me.Name, GridView1)
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
        DXPrintDatagridview(Me.Text & "<br/><strong>" & Me.Text & "</strong>", "Accountable Form Inventory", "Report as of from " & CDate(Now).ToString("MMMM, dd yyyy"), GridView1, Me)
    End Sub

    Private Sub ExportToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim f As FolderBrowserDialog = New FolderBrowserDialog
        Try
            If f.ShowDialog() = DialogResult.OK Then
                dst.WriteXml(f.SelectedPath & "\" & LCase(Me.Text) & ".xls")
                ' MessageBox.Show("Your file successfully exported with filename " & LCase(Me.Text) & ".xls", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                MainForm.NotifyIcon1.BalloonTipIcon = ToolTipIcon.Info
                MainForm.NotifyIcon1.BalloonTipTitle = "Successfully Exported"
                MainForm.NotifyIcon1.BalloonTipText = "Your file successfully exported at " & f.SelectedPath & "\" & LCase(Me.Text) & ".xls"
                MainForm.NotifyIcon1.ShowBalloonTip(1000)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub cmdNew_Click(sender As Object, e As EventArgs) Handles cmdNew.Click
        If globalAllowAdd = False Then
            XtraMessageBox.Show("Your access not allowed to add!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        If frmInventoryFormInfo.Visible = False Then
            frmInventoryFormInfo.Show(Me)
        Else
            frmInventoryFormInfo.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub cmdLocalData_Click(sender As Object, e As EventArgs) Handles cmdLocalData.Click
        ViewList()
    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        If globalAllowDelete = False Then
            XtraMessageBox.Show("Your access not allowed to delete!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        If XtraMessageBox.Show("Are you sure you want to permanently remove selected item? ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            Dim I As Integer = 0
            For I = 0 To GridView1.SelectedRowsCount - 1
                If countqry("tbltransactionentries", "invrefcode='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "Inventory Code") & "'") > 0 Then
                    XtraMessageBox.Show("Form Inventory " & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "Inventory Code") & " cannot be delete due to form is already in use!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Else
                    com.CommandText = "delete from tblforminventory where id='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "Inventory Code") & "' " : com.ExecuteNonQuery()
                End If
            Next
            ViewList()
        End If
    End Sub

    Private Sub cmdView_Click(sender As Object, e As EventArgs) Handles cmdView.Click
        If globalAllowEdit = False Then
            XtraMessageBox.Show("Your access not allowed to edit!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        frmInventoryFormInfo.mode.Text = ""
        frmInventoryFormInfo.id.Text = GridView1.GetFocusedRowCellValue("Inventory Code").ToString
        frmInventoryFormInfo.mode.Text = "edit"
        If frmInventoryFormInfo.Visible = False Then
            frmInventoryFormInfo.Show(Me)
        Else
            frmInventoryFormInfo.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub AssignAccountableToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AssignAccountableToolStripMenuItem.Click
        If GridView1.GetFocusedRowCellValue("Accountable Person").ToString <> "" Then
            XtraMessageBox.Show("Selected accountable form is already assigned!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        frmAssignAccountable.invcode.Text = GridView1.GetFocusedRowCellValue("Inventory Code").ToString
        If frmAssignAccountable.Visible = False Then
            frmAssignAccountable.Show(Me)
        Else
            frmAssignAccountable.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub ViewDetailTransactionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewDetailTransactionToolStripMenuItem.Click
        frmCollectionDetails.invrefcode.Text = GridView1.GetFocusedRowCellValue("Inventory Code").ToString
        frmCollectionDetails.accountable.Text = GridView1.GetFocusedRowCellValue("accountable").ToString
        frmCollectionDetails.seriesfrom.Text = GridView1.GetFocusedRowCellValue("SeriesFrom").ToString
        frmCollectionDetails.seriesto.Text = GridView1.GetFocusedRowCellValue("SeriesTo").ToString
        frmCollectionDetails.Text = GridView1.GetFocusedRowCellValue("Accountable Person").ToString & " (" & GridView1.GetFocusedRowCellValue("SeriesFrom").ToString & " - " & GridView1.GetFocusedRowCellValue("SeriesTo").ToString & ")"
        If frmCollectionDetails.Visible = True Then
            frmCollectionDetails.Focus()
        Else
            frmCollectionDetails.Show(Me)
        End If
    End Sub

    Private Sub ckCurrentlyInUsed_CheckedChanged(sender As Object, e As EventArgs) Handles ckCurrentlyInUsed.CheckedChanged
        ViewList()
    End Sub

    Private Sub ckViewAllForms_CheckedChanged(sender As Object, e As EventArgs) Handles ckViewAllForms.CheckedChanged
        If ckViewAllForms.Checked = True Then
            txtForm.Enabled = False
        Else
            txtForm.Enabled = True
        End If
        ViewList()
    End Sub

    Private Sub txtForm_EditValueChanged(sender As Object, e As EventArgs) Handles txtForm.EditValueChanged
        ViewList()
    End Sub
End Class