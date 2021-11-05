﻿Imports DevExpress.XtraEditors
Imports DevExpress.Skins
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmRequisitionType

    Private Sub frmRequisitionType_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub frmRequisitionType_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        SetIcon(Me)
        filter()
        PermissionAccess({cmdSave}, globalAllowAdd)
        PermissionAccess({cmdEdit}, globalAllowEdit)
        PermissionAccess({cmdDelete}, globalAllowDelete)
    End Sub
 
    Public Sub filter()
        LoadXgrid("Select  Code, Description, enablevoucher as 'Enable Voucher', directapproved as 'Direct Approved', requiredfund as 'Required Fund' from tblrequisitiontype order by code asc", "tblrequisitiontype", Em, GridView1, Me)
        XgridColWidth({"Code"}, GridView1, 80)
        XgridColAlign({"Code"}, GridView1, DevExpress.Utils.HorzAlignment.Center)
    End Sub

    Private Sub cmdSaveButton_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        If countqry("tblrequisitiontype", "code='" & code.Text & "'") > 0 And mode.Text <> "edit" Then
            XtraMessageBox.Show("Code already exists!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            code.Focus()
            Exit Sub

        ElseIf txtDescription.Text = "" Then
            XtraMessageBox.Show("Please enter description!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtDescription.Focus()
            Exit Sub

        End If
        If mode.Text = "edit" Then
            com.CommandText = "update tblrequisitiontype set description='" & rchar(txtDescription.Text) & "', enablevoucher=" & ckEnableVoucher.CheckState & ", directapproved=" & ckDirectApproved.CheckState & ", requiredfund=" & ckRequiredFund.CheckState & "  where code='" & code.Text & "'" : com.ExecuteNonQuery()
            ClearInfo()
            XtraMessageBox.Show("Item successfully saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            com.CommandText = "insert into tblrequisitiontype set description='" & rchar(txtDescription.Text) & "', enablevoucher=" & ckEnableVoucher.CheckState & ", directapproved=" & ckDirectApproved.CheckState & ", requiredfund=" & ckRequiredFund.CheckState & "  " : com.ExecuteNonQuery()
            ClearInfo()
        End If
    End Sub

    Public Sub ClearInfo()
        code.Text = "" : mode.Text = "" : txtDescription.Text = "" : txtDescription.Focus() : ckEnableVoucher.Checked = True : ckDirectApproved.Checked = False : ckRequiredFund.Checked = False : filter()
    End Sub
    Public Sub showInfo()
        If code.Text = "" Then Exit Sub
        com.CommandText = "select * from tblrequisitiontype where code='" & code.Text & "'" : rst = com.ExecuteReader
        While rst.Read
            txtDescription.Text = rst("description").ToString
            ckEnableVoucher.Checked = CBool(rst("enablevoucher").ToString)
            ckDirectApproved.Checked = CBool(rst("directapproved").ToString)
            ckRequiredFund.Checked = CBool(rst("requiredfund").ToString)
        End While
        rst.Close()
    End Sub

    Private Sub cmdEdit_Click(sender As Object, e As EventArgs) Handles cmdEdit.Click
        mode.Text = ""
        code.Text = GridView1.GetFocusedRowCellValue("Code").ToString
        mode.Text = "edit"
        showInfo()
    End Sub

    Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
        If XtraMessageBox.Show("Are you sure you want to permanently remove selected item? ", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            Dim I As Integer = 0
            For I = 0 To GridView1.SelectedRowsCount - 1
                com.CommandText = "delete from tblrequisitiontype where code='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "Code") & "' " : com.ExecuteNonQuery()
            Next
            filter()
        End If
    End Sub

    Private Sub txtDescription_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDescription.KeyPress
        If e.KeyChar() = Chr(13) Then
            cmdSave.PerformClick()
        End If
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        filter()
    End Sub
End Class