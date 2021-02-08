Imports DevExpress.XtraEditors
Imports DevExpress.Skins
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmExpenditureItem
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmProductMesurement_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        LoadExpensesGL()
        LoadData()
    End Sub

    Public Sub LoadExpensesGL()
        LoadXgridLookupSearch("SELECT code, description as 'Select' from tblexpenditureclass order by description asc", "tblexpenditureclass", txtExpenseClass, gridExpenseClass, Me)
        XgridHideColumn({"code"}, gridExpenseClass)
    End Sub

    Private Sub txtExpenseClass_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtExpenseClass.EditValueChanged
        On Error Resume Next
        LoadData()
    End Sub

    Public Sub LoadData()
        LoadXgrid("select id as Code, description as 'Item Name', isBank from tblexpenditureitem where classcode='" & txtExpenseClass.EditValue & "' order by description asc ", "tblexpenditureitem", Em, GridView1, Me)
        XgridColAlign({"Code"}, GridView1, DevExpress.Utils.HorzAlignment.Center)
        GridView1.Columns("Code").Width = 80
    End Sub

    Private Sub cmdOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOk.Click
        If txtExpenseClass.Text = "" Then
            XtraMessageBox.Show("Please select class!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtExpenseClass.Focus()
            Exit Sub
        ElseIf txtDescription.Text = "" Then
            XtraMessageBox.Show("Please Enter account name!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtDescription.Focus()
            Exit Sub

        ElseIf countqry("tblexpenditureitem", "description='" & rchar(txtDescription.Text) & "'") > 0 And mode.Text <> "edit" Then
            XtraMessageBox.Show("account name already exist!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtDescription.Focus()
            Exit Sub

        End If
        If mode.Text = "edit" Then
            com.CommandText = "update tblexpenditureitem set classcode='" & txtExpenseClass.EditValue & "', description='" & rchar(txtDescription.Text) & "', isbank=" & CheckEdit1.CheckState & " where id='" & code.Text & "'" : com.ExecuteNonQuery()
        Else
            com.CommandText = "insert into tblexpenditureitem set classcode='" & txtExpenseClass.EditValue & "', description='" & rchar(txtDescription.Text) & "', isbank=" & CheckEdit1.CheckState & "" : com.ExecuteNonQuery()
        End If

        LoadData()
        mode.Text = ""
        code.Text = ""
        txtDescription.Text = "" : txtDescription.Focus()
        XtraMessageBox.Show("Item successfully saved!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub cmdEdit_Click(sender As Object, e As EventArgs) Handles cmdEdit.Click
        If GridView1.GetFocusedRowCellValue("Code").ToString = "" Then
            XtraMessageBox.Show("There is no item selected! make sure, the selection is on the list", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        mode.Text = ""
        code.Text = GridView1.GetFocusedRowCellValue("Code").ToString
        com.CommandText = "select * from tblexpenditureitem where id='" & code.Text & "'" : rst = com.ExecuteReader
        While rst.Read
            txtDescription.Text = rst("description").ToString
            CheckEdit1.Checked = rst("isbank")
        End While
        rst.Close()
        mode.Text = "edit"
    End Sub

    Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
        If XtraMessageBox.Show("Are you sure you want to delete selected item? ", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            For I = 0 To GridView1.SelectedRowsCount - 1
                com.CommandText = "delete from tblexpenditureitem where id='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "Code").ToString & "'" : com.ExecuteNonQuery()
            Next
            LoadData()
            XtraMessageBox.Show("Item successfully deleted", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        LoadData()
    End Sub

End Class