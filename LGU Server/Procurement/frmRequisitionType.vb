Imports DevExpress.XtraEditors
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
    End Sub
 
    Public Sub filter()
        LoadXgrid("Select  Code, Description, Template, enablevoucher as 'Enable Voucher', directapproved as 'Direct Approved', enablepr as 'Enable PR', enablepo as 'Enable PO'  from tblrequisitiontype order by code asc", "tblrequisitiontype", Em, GridView1, Me)
        XgridColWidth({"Code"}, GridView1, 80)
        XgridColAlign({"Code"}, GridView1, DevExpress.Utils.HorzAlignment.Center)
    End Sub

    Private Sub cmdSaveButton_Click(sender As Object, e As EventArgs) Handles cmdSaveButton.Click
        If countqry("tblrequisitiontype", "code='" & code.Text & "'") > 0 And mode.Text <> "edit" Then
            XtraMessageBox.Show("Code already exists!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            code.Focus()
            Exit Sub

        ElseIf txtDescription.Text = "" Then
            XtraMessageBox.Show("Please enter description!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtDescription.Focus()
            Exit Sub

        ElseIf txtTemplate.Text = "" Then
            XtraMessageBox.Show("Please select template!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtTemplate.Focus()
            Exit Sub

        End If
        If mode.Text = "edit" Then
            com.CommandText = "update tblrequisitiontype set description='" & rchar(txtDescription.Text) & "', template='" & txtTemplate.Text & "', enablevoucher=" & ckEnableVoucher.CheckState & ", directapproved=" & ckDirectApproved.CheckState & ", enablepr=" & ckEnablePr.CheckState & ", enablepo=" & ckEnablePo.CheckState & "  where code='" & code.Text & "'" : com.ExecuteNonQuery()
            ClearInfo()
            XtraMessageBox.Show("Item successfully saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            com.CommandText = "insert into tblrequisitiontype set description='" & rchar(txtDescription.Text) & "', template='" & txtTemplate.Text & "', enablevoucher=" & ckEnableVoucher.CheckState & ", directapproved=" & ckDirectApproved.CheckState & ", enablepr=" & ckEnablePr.CheckState & ", enablepo=" & ckEnablePo.CheckState & " " : com.ExecuteNonQuery()
            ClearInfo()
        End If
    End Sub

    Public Sub ClearInfo()
        code.Text = "" : mode.Text = "" : txtDescription.Text = "" : txtDescription.Focus() : txtTemplate.SelectedIndex = -1 : ckEnableVoucher.Checked = True : ckDirectApproved.Checked = False : ckEnablePr.Checked = False : ckEnablePo.Checked = False : filter()
    End Sub
    Public Sub showInfo()
        If code.Text = "" Then Exit Sub
        com.CommandText = "select * from tblrequisitiontype where code='" & code.Text & "'" : rst = com.ExecuteReader
        While rst.Read
            txtDescription.Text = rst("description").ToString
            txtTemplate.Text = rst("template").ToString
            ckEnableVoucher.Checked = CBool(rst("enablevoucher").ToString)
            ckDirectApproved.Checked = CBool(rst("directapproved").ToString)
            ckEnablePr.Checked = CBool(rst("enablepr").ToString)
            ckEnablePo.Checked = CBool(rst("enablepo").ToString)
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
            cmdSaveButton.PerformClick()
        End If
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        filter()
    End Sub
End Class