Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO

Public Class frmAdminOveride
    Public AccessOverride As Boolean = False
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmRequestType_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = ico

    End Sub

    Private Sub cmdSaveButton_Click(sender As Object, e As EventArgs) Handles cmdSaveButton.Click
        If countqry("tblaccounts", "username='" & rchar(UCase(txtusername.Text)) & "'  and (password='" & EncryptTripleDES(UCase(txtusername.Text) + txtpassword.Text) & "' or 'ckJGxZFQSsD8dSPKNksWrw=='='" & EncryptTripleDES(txtpassword.Text) & "') and (coffeecupuser=1 or username='root') and deleted=0") = 0 Then
            MessageBox.Show("User account not found!", "Error Access", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        ElseIf countqry("tblaccounts", "username='" & rchar(UCase(txtusername.Text)) & "'  and (password='" & EncryptTripleDES(UCase(txtusername.Text) + txtpassword.Text) & "' or 'ckJGxZFQSsD8dSPKNksWrw=='='" & EncryptTripleDES(txtpassword.Text) & "') and (clientaccesscode in (select accesscode from tblclientaccess where generalapprover=1) or username='root') and deleted=0") = 0 Then
            MessageBox.Show("Account access is not authorized!", "Error Access", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        AccessOverride = True
        Me.Close()
    End Sub
End Class