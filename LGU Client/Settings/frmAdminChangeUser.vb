Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO
Imports System.Net

Public Class frmAdminChangeUser
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            If cmdset.Focused = True Then
                txtUserAccount.Focus()
            Else
                Me.Close()
            End If

        End If
        Return ProcessCmdKey
    End Function

    Private Sub cmdset_Click(sender As Object, e As EventArgs) Handles cmdset.Click
        If txtUserAccount.Text = "" Then
            MessageBox.Show("Please select user account!", compOfficename, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtUserAccount.Focus()
            Exit Sub
        End If
        If MessageBox.Show("Are you sure you want to continue? ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            CloseSystemDeclaration()
            If OpenMysqlConnection() = True Then
                globaluserid = DirectCast(txtUserAccount.SelectedItem, ComboBoxItem).HiddenValue()
                LoadAccountDetails(globaluserid)
                MainForm.ValidateUserAccounts()
                MainForm.LoadMainSystemSettings()
                Me.Close()
            End If
        End If
    End Sub

    Private Sub txtUserAccount_GotFocus(sender As Object, e As EventArgs) Handles txtUserAccount.GotFocus
        Me.AcceptButton = Nothing
    End Sub
 
    Private Sub txtUserAccount_KeyDown(sender As Object, e As KeyEventArgs) Handles txtUserAccount.KeyDown
        If e.KeyData = Keys.Enter Then
            If txtUserAccount.Text = "" Or txtUserAccount.Text = "%" Then Exit Sub
            If countqry("tblaccounts", " concat(accountid,' - ',fullname)  = '" & txtUserAccount.Text & "'") = 0 Then
                LoadToComboBoxDB("SELECT accountid,concat(accountid,' - ',fullname) as 'user' FROM tblaccounts where coffeecupuser=1 and deleted=0 and (fullname  like '%" & txtUserAccount.Text & "%' or designation  like '%" & txtUserAccount.Text & "%' or (select officename from tblcompoffice where officeid = tblaccounts.officeid) like  '%" & txtUserAccount.Text & "%')  order by fullname asc;", "user", "accountid", txtUserAccount)
                txtUserAccount.DroppedDown = True
            Else
                viewAccountinfo()
                cmdset.Focus()
            End If
        End If
    End Sub
    Public Sub viewAccountinfo()
        com.CommandText = "select *,(select officename from tblcompoffice where officeid = tblaccounts.officeid) as 'office',(select Description from tblclientaccess where accesscode = tblaccounts.coffeecupuser)  as 'permissiontemp' from tblaccounts where accountid='" & DirectCast(txtUserAccount.SelectedItem, ComboBoxItem).HiddenValue() & "'" : rst = com.ExecuteReader()
        While rst.Read
            txtFeatures.Text = "Username: " & rst("username").ToString & Environment.NewLine _
                            + "Account Name: " & rst("fullname").ToString & Environment.NewLine _
                            + "Position: " & rst("designation").ToString & Environment.NewLine _
                            + "Branch: " & rst("office").ToString & Environment.NewLine _
                            + "Permission: " & rst("permissiontemp").ToString
        End While
        rst.Close()
        Me.AcceptButton = cmdset
    End Sub

     
    Private Sub frmAdminChangeUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico
    End Sub
 
End Class