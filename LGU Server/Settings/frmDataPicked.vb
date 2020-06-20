Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System.IO
Imports System.Data
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraReports.UI
Imports DevExpress.Skins
Imports DevExpress.XtraSplashScreen

Public Class frmDataPicked
    Private gridsel As String = ""
    Private cpass As Boolean = False
    Private gridid As String
    Private trckdate As Date

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmDataPicked_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetIcon(Me)
        LoadDataPicked()
    End Sub

    Public Sub LoadDataPicked()
        LoadXgrid("select id, Description from tbldatapicked where fieldname='" & fieldname.Text & "' order by Description asc", "tbldatapicked", Em, gv_datapicked, Me)
        gv_datapicked.Columns("id").Visible = False
        gv_datapicked.BestFitColumns()
    End Sub

    Private Sub txtDescription_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDescription.KeyPress
        If e.KeyChar() = Chr(13) Then
            If txtDescription.Text = "" Then
                XtraMessageBox.Show("Please enter Description!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtDescription.Focus()
                Exit Sub
            ElseIf countqry("tbldatapicked", "fieldname='" & fieldname.Text & "' and Description='" & rchar(txtDescription.Text) & "' ") > 0 Then
                XtraMessageBox.Show("description is already exists!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtDescription.Focus()
                Exit Sub
            End If
            If mode.Text = "edit" Then
                com.CommandText = "UPDATE tbldatapicked set Description='" & rchar(txtDescription.Text) & "' where id='" & id.Text & "'" : com.ExecuteNonQuery()
            Else
                com.CommandText = "insert into tbldatapicked set fieldname='" & fieldname.Text & "', Description='" & rchar(txtDescription.Text) & "'" : com.ExecuteNonQuery()
            End If
            txtDescription.Text = "" : txtDescription.Focus() : mode.Text = "" : id.Text = ""
            LoadDataPicked()
        End If
    End Sub

    Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem4.Click
        If XtraMessageBox.Show("Are you sure you want to remove selected item? " & todelete, compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            For I = 0 To gv_datapicked.SelectedRowsCount - 1
                com.CommandText = "delete from tbldatapicked where id='" & gv_datapicked.GetRowCellValue(gv_datapicked.GetSelectedRows(I), "id").ToString & "'" : com.ExecuteNonQuery()
            Next
            LoadDataPicked()
        End If
    End Sub

    Private Sub EditApproverToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditApproverToolStripMenuItem.Click
        mode.Text = "edit"
        id.Text = gv_datapicked.GetFocusedRowCellValue("id").ToString()
        txtDescription.Text = gv_datapicked.GetFocusedRowCellValue("Description").ToString()
        txtDescription.Focus()
    End Sub
End Class