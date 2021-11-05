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
        LoadFund()
        LoadData()

        PermissionAccess({cmdSave}, globalAllowAdd)
        PermissionAccess({cmdEdit}, globalAllowEdit)
        PermissionAccess({cmdDelete}, globalAllowDelete)
    End Sub

    Public Sub LoadData()
        If txtFund.Text = "" Then Exit Sub
        LoadXgrid("select id, code as 'Account No.', description as 'Bank Name' from tblbankaccounts where (fundcode='" & txtFund.EditValue & "' or fundcode='') order by description asc ", "tblbankaccounts", Em, GridView1, Me)
        XgridHideColumn({"id"}, GridView1)
        XgridColAlign({"Account No."}, GridView1, DevExpress.Utils.HorzAlignment.Center)
        XgridColWidth({"Account No."}, GridView1, 140)
    End Sub

    Public Sub LoadFund()
        LoadXgridLookupSearch("SELECT code,Description from tblfund", "tblfund", txtFund, gridFund, Me)
        gridFund.Columns("code").Visible = False
    End Sub
    Private Sub txtFund_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFund.EditValueChanged
        'On Error Resume Next
        LoadData()
    End Sub

    Private Sub cmdOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        If txtFund.Text = "" Then
            XtraMessageBox.Show("Please select fund type!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtFund.Focus()
            Exit Sub
        ElseIf txtBankCode.Text = "" Then
            XtraMessageBox.Show("Please enter bank account number!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtDescription.Focus()
            Exit Sub
        ElseIf txtDescription.Text = "" Then
            XtraMessageBox.Show("Please enter bank name!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtDescription.Focus()
            Exit Sub

        ElseIf countqry("tblbankaccounts", "code='" & txtBankCode.Text & "'") > 0 And mode.Text <> "edit" Then
            XtraMessageBox.Show("Bank account number already exist!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtDescription.Focus()
            Exit Sub

        ElseIf countqry("tblbankaccounts", "description='" & rchar(txtDescription.Text) & "'") > 0 And mode.Text <> "edit" Then
            XtraMessageBox.Show("Bank name already exist!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtDescription.Focus()
            Exit Sub

        End If
        If mode.Text = "edit" Then
            com.CommandText = "update tblbankaccounts set fundcode='" & txtFund.EditValue & "', code='" & txtBankCode.Text & "', description='" & rchar(txtDescription.Text) & "' where id='" & id.Text & "'" : com.ExecuteNonQuery()
        Else
            com.CommandText = "insert into tblbankaccounts set fundcode='" & txtFund.EditValue & "', code='" & txtBankCode.Text & "', description='" & rchar(txtDescription.Text) & "'" : com.ExecuteNonQuery()
        End If

        LoadData()
        mode.Text = ""
        id.Text = ""
        txtBankCode.Text = ""
        txtDescription.Text = "" : txtBankCode.Focus()
        XtraMessageBox.Show("Bank account successfully saved!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
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
        id.Text = GridView1.GetFocusedRowCellValue("id").ToString
        com.CommandText = "select * from tblbankaccounts where id='" & id.Text & "'" : rst = com.ExecuteReader
        While rst.Read
            txtFund.EditValue = rst("fundcode").ToString
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
            XtraMessageBox.Show("Bank account successfully deleted", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        LoadData()
    End Sub

End Class