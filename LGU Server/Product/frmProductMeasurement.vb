Imports DevExpress.XtraEditors
Imports DevExpress.Skins
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmProductMeasurement
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
        LoadXgrid("select id, unitname as 'Unit Measurement' from tblproductunit order by unitname asc ", "tblproductunit", Em, GridView1, Me)
        XgridHideColumn({"id"}, GridView1)
    End Sub

    Private Sub cmdOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOk.Click
        If txtDescription.Text = "" Then
            XtraMessageBox.Show("Please Enter unit name!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtDescription.Focus()
            Exit Sub
        ElseIf countqry("tblproductunit", "unitname='" & rchar(txtDescription.Text) & "'") > 0 And mode.Text <> "edit" Then
            XtraMessageBox.Show("unit name already exist!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            code.Focus()
            Exit Sub

        End If
        If mode.Text = "edit" Then
            com.CommandText = "update tblproductunit set unitname='" & rchar(txtDescription.Text) & "' where id='" & code.Text & "'" : com.ExecuteNonQuery()
        Else
            com.CommandText = "insert into tblproductunit set unitname='" & rchar(txtDescription.Text) & "'" : com.ExecuteNonQuery()
        End If

        LoadData()
        mode.Text = ""
        code.Text = ""
        txtDescription.Text = "" : txtDescription.Focus()
        XtraMessageBox.Show("Unit Measurement successfully saved!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
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
        com.CommandText = "select * from tblproductunit where id='" & code.Text & "'" : rst = com.ExecuteReader
        While rst.Read
            txtDescription.Text = rst("unitname").ToString
        End While
        rst.Close()
        mode.Text = "edit"
    End Sub

    Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
        If XtraMessageBox.Show("Are you sure you want to delete selected item? ", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            For I = 0 To GridView1.SelectedRowsCount - 1
                com.CommandText = "delete from tblproductunit where id='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "id").ToString & "'" : com.ExecuteNonQuery()
            Next
            LoadData()
            XtraMessageBox.Show("Unit Measurement successfully deleted", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        LoadData()
    End Sub

End Class