Imports DevExpress.XtraEditors
Imports DevExpress.Skins
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmPayeeTable

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
        LoadXgrid("Select supplierid as Code, suppliername as 'Complete Name', completeaddress as 'Address', contactno as 'Contact No.', TIN, (select fullname from tblaccounts where accountid=a.entryby) as 'Entry By', date_format(dateentry, '%Y-%m-%d %r') as 'Date Entry' from tblsupplier as a where deleted=0 order by suppliername asc", "tblsupplier", Em, GridView1, Me)

        XgridColWidth({"Code"}, GridView1, 80)
        XgridColMemo({"Address"}, GridView1)
        XgridColAlign({"Code", "Contact No.", "TIN"}, GridView1, DevExpress.Utils.HorzAlignment.Center)
    End Sub

    Private Sub cmdSaveButton_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        If countqry("tblsupplier", "supplierid='" & code.Text & "'") > 0 And mode.Text <> "edit" Then
            XtraMessageBox.Show("Code already exists!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            code.Focus()
            Exit Sub

        ElseIf txtFullname.Text = "" Then
            XtraMessageBox.Show("Please enter Payee's Name!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtFullname.Focus()
            Exit Sub
        ElseIf txtAddress.Text = "" Then
            XtraMessageBox.Show("Please enter Payee's Address!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtAddress.Focus()
            Exit Sub

        End If
        If mode.Text = "edit" Then
            com.CommandText = "update tblsupplier set suppliername='" & rchar(txtFullname.Text) & "', completeaddress='" & rchar(txtAddress.Text) & "', contactno='" & txtContactNumber.Text & "', tin='" & txtTIN.Text & "',entryby='" & globaluserid & "',dateentry=current_timestamp where supplierid='" & code.Text & "'" : com.ExecuteNonQuery()
            XtraMessageBox.Show("Item successfully saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            com.CommandText = "insert into tblsupplier set suppliername='" & rchar(txtFullname.Text) & "', completeaddress='" & rchar(txtAddress.Text) & "', contactno='" & txtContactNumber.Text & "', tin='" & txtTIN.Text & "',entryby='" & globaluserid & "', dateentry=current_timestamp" : com.ExecuteNonQuery()
        End If
        code.Text = "" : mode.Text = "" : txtFullname.Text = "" : txtAddress.Text = "" : txtContactNumber.Text = "" : txtTIN.Text = "" : txtFullname.Focus() : filter()

    End Sub

    Public Sub showInfo()
        If code.Text = "" Then Exit Sub
        com.CommandText = "select * from tblsupplier where supplierid='" & code.Text & "'" : rst = com.ExecuteReader
        While rst.Read
            txtFullname.Text = rst("suppliername").ToString
            txtAddress.Text = rst("completeaddress").ToString
            txtContactNumber.Text = rst("contactno").ToString
            txtTIN.Text = rst("tin").ToString
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
                com.CommandText = "update tblsupplier set entryby='" & globaluserid & "', dateentry=current_timestamp, deleted=1 where supplierid='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "Code") & "' " : com.ExecuteNonQuery()
            Next
            filter()
        End If
    End Sub

    Private Sub txtDescription_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFullname.KeyPress
        If e.KeyChar() = Chr(13) Then
            cmdSave.PerformClick()
        End If
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        filter()
    End Sub
End Class