Imports DevExpress.XtraEditors
Imports DevExpress.Skins
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmProductCategory

    Private Sub frmProductCategory_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub frmProductCategory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        SetIcon(Me)
        filter()
    End Sub

    Public Sub filter()
        LoadXgrid("Select  Code, Description, NonInventory, PPE, Consumable   from tblproductcategory order by code asc", "tblproductcategory", Em, GridView1, Me)
        XgridColAlign({"Code", "NonInventory", "PPE", "Consumable"}, GridView1, DevExpress.Utils.HorzAlignment.Center)
        XgridColWidth({"Code"}, GridView1, 80)

    End Sub

    Private Sub cmdSaveButton_Click(sender As Object, e As EventArgs) Handles cmdSaveButton.Click
        If countqry("tblproductcategory", "code='" & code.Text & "'") > 0 And mode.Text <> "edit" Then
            XtraMessageBox.Show("Code already exists!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            code.Focus()
            Exit Sub

        ElseIf txtDescription.Text = "" Then
            XtraMessageBox.Show("Please enter description!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtDescription.Focus()
            Exit Sub

        ElseIf ckpooption.SelectedIndex = -1 Then
            XtraMessageBox.Show("Please select category type!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ckpooption.Focus()
            Exit Sub
        End If
        If mode.Text = "edit" Then
            com.CommandText = "update tblproductcategory set description='" & rchar(txtDescription.Text) & "' " & If(ckpooption.SelectedIndex = 0, ",noninventory=1", ",noninventory=0") & If(ckpooption.SelectedIndex = 1, ",consumable=1", ",consumable=0") & If(ckpooption.SelectedIndex = 2, ",ppe=1", ",ppe=0") & " where code='" & code.Text & "'" : com.ExecuteNonQuery()
            com.CommandText = "update tblproducts set categoryname='" & txtDescription.Text & "' " & If(ckpooption.SelectedIndex = 0, ",noninventory=1", ",noninventory=0") & If(ckpooption.SelectedIndex = 1, ",consumable=1", ",consumable=0") & If(ckpooption.SelectedIndex = 2, ",ppe=1", ",ppe=0") & " where categoryid='" & code.Text & "'" : com.ExecuteNonQuery()

            XtraMessageBox.Show("Item successfully saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            com.CommandText = "insert into tblproductcategory set description='" & rchar(txtDescription.Text) & "' " & If(ckpooption.SelectedIndex = 0, ",noninventory=1", ",noninventory=0") & If(ckpooption.SelectedIndex = 1, ",consumable=1", ",consumable=0") & If(ckpooption.SelectedIndex = 2, ",ppe=1", ",ppe=0") & "" : com.ExecuteNonQuery()
        End If
        code.Text = "" : mode.Text = "" : txtDescription.Text = "" : txtDescription.Focus() : filter()

    End Sub
    Public Sub showInfo()
        If code.Text = "" Then Exit Sub
        com.CommandText = "select *, CASE WHEN noninventory = 1 THEN 0 WHEN consumable = 1 then 1 when ppe = 1 then 2 else -1 END as InventoryType from tblproductcategory where code='" & code.Text & "'" : rst = com.ExecuteReader
        While rst.Read
            txtDescription.Text = rst("description").ToString
            ckpooption.SelectedIndex = CInt(rst("InventoryType").ToString)
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
                com.CommandText = "delete from tblproductcategory where code='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "Code") & "' " : com.ExecuteNonQuery()
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