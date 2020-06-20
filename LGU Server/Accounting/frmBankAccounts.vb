Imports DevExpress.XtraEditors
Imports DevExpress.Skins
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmBankAccounts
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmProductMesurement_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        LoadData()
    End Sub

    Public Sub LoadData()
        LoadXgrid("select id,Code, description as 'Account Name' from tblbankaccounts order by description asc ", "tblbankaccounts", Em, GridView1, Me)
        XgridHideColumn({"id"}, GridView1)
        XgridColAlign({"Code"}, GridView1, DevExpress.Utils.HorzAlignment.Center)
    End Sub

    Private Sub cmdOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOk.Click
        If txtBankCode.Text = "" Then
            XtraMessageBox.Show("Please cnter code!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtDescription.Focus()
            Exit Sub
        ElseIf txtDescription.Text = "" Then
            XtraMessageBox.Show("Please Enter account name!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtDescription.Focus()
            Exit Sub
        
        ElseIf countqry("tblbankaccounts", "description='" & rchar(txtDescription.Text) & "'") > 0 And mode.Text <> "edit" Then
            XtraMessageBox.Show("account name already exist!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtDescription.Focus()
            Exit Sub

        End If
        If mode.Text = "edit" Then
            com.CommandText = "update tblbankaccounts set code='" & txtBankCode.Text & "', description='" & rchar(txtDescription.Text) & "' where id='" & code.Text & "'" : com.ExecuteNonQuery()
        Else
            com.CommandText = "insert into tblbankaccounts set code='" & txtBankCode.Text & "', description='" & rchar(txtDescription.Text) & "'" : com.ExecuteNonQuery()
        End If

        LoadData()
        mode.Text = ""
        code.Text = ""
        txtBankCode.Text = ""
        txtDescription.Text = "" : txtBankCode.Focus()
        XtraMessageBox.Show("Account successfully saved!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub cmdEdit_Click(sender As Object, e As EventArgs) Handles cmdEdit.Click
        If GridView1.GetFocusedRowCellValue("id").ToString = "" Then
            XtraMessageBox.Show("There is no item selected! make sure, the selection is on the list", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        mode.Text = ""
        code.Text = GridView1.GetFocusedRowCellValue("id").ToString
        com.CommandText = "select * from tblbankaccounts where id='" & code.Text & "'" : rst = com.ExecuteReader
        While rst.Read
            txtBankCode.Text = rst("code").ToString
            txtDescription.Text = rst("description").ToString
        End While
        rst.Close()
        mode.Text = "edit"
    End Sub

    Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
        If XtraMessageBox.Show("Are you sure you want to delete selected item? ", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            For I = 0 To GridView1.SelectedRowsCount - 1
                com.CommandText = "delete from tblbankaccounts where id='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "id").ToString & "'" : com.ExecuteNonQuery()
            Next
            LoadData()
            XtraMessageBox.Show("Account successfully deleted", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        LoadData()
    End Sub

End Class