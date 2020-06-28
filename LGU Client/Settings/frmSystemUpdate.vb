Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO
Imports System.Net

Public Class frmSystemUpdate

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub cmdset_Click(sender As Object, e As EventArgs) Handles cmdset.Click
         If txtDetails.Text = "" Then
            MessageBox.Show("Please enter valid details!", compOfficename, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtDetails.Focus()
            Exit Sub

        ElseIf txtVersion.Text = "" Then
            MessageBox.Show("Please enter update version!", compOfficename, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtVersion.Focus()
            Exit Sub
        ElseIf txtUrl.Text = "" Then
            MessageBox.Show("Please enter url!", compOfficename, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtUrl.Focus()
            Exit Sub
        ElseIf txtFileName.Text = "" Then
            MessageBox.Show("Please enter filename!", compOfficename, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtFileName.Focus()
            Exit Sub
        End If

        While MainForm.BackgroundWorker1.IsBusy()
            Application.DoEvents()
        End While

        Dim fieldname As String = ""
        If RadioGroup1.SelectedIndex = 0 Then
            fieldname = "isserver=1"
        ElseIf RadioGroup1.SelectedIndex = 1 Then
            fieldname = "isclient=1"
        ElseIf RadioGroup1.SelectedIndex = 2 Then
            fieldname = "isconsole=1"
        ElseIf RadioGroup1.SelectedIndex = 3 Then
            fieldname = "isdashboard=1"
        End If
        com.CommandText = "update tblclientsystemupdate set active=0 where " & fieldname : com.ExecuteNonQuery()
        com.CommandText = "insert into tblclientsystemupdate set details='" & rchar(txtDetails.Text) & "', version='" & txtVersion.Text & "', downloadurl='" & rchar(txtUrl.Text) & rchar(txtFileName.Text) & "', features='" & rchar(txtFeatures.Text) & "', password='none', active=1, " & fieldname : com.ExecuteNonQuery()
        MessageBox.Show("New Version successfully Saved!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

  
    Private Sub frmSystemUpdate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico
        txtVersion.Text = fversion
        txtUrl.Text = GlobalDownloadDefaultLocation
    End Sub

    Private Sub RadioGroup1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles RadioGroup1.SelectedIndexChanged
        ShowDetails()
    End Sub

    Private Sub txtVersion_TextChanged(sender As Object, e As EventArgs) Handles txtVersion.TextChanged
        ShowDetails()
    End Sub
    Public Sub ShowDetails()
        txtDetails.Text = RadioGroup1.Text & " v" & txtVersion.Text
    End Sub
End Class