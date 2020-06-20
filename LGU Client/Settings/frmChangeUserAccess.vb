Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO
Imports System.Net

Public Class frmChangeUserAccess
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            If cmdset.Focused = True Then
                txtPermission.Focus()
            Else
                Me.Close()
            End If

        End If
        Return ProcessCmdKey
    End Function

    Private Sub cmdset_Click(sender As Object, e As EventArgs) Handles cmdset.Click
        If txtPermission.Text = "" Then
            MessageBox.Show("Please select user account!", compOfficename, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtPermission.Focus()
            Exit Sub
        End If
        If MessageBox.Show("To take effect of your new system access, system will automatically close and please login again! Are you sure you want to continue? ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            If OpenMysqlConnection() = True Then
                com.CommandText = "update tblaccounts set coffeecupposition='" & DirectCast(txtPermission.SelectedItem, ComboBoxItem).HiddenValue() & "' where accountid='" & globaluserid & "'" : com.ExecuteNonQuery()
                com.CommandText = "update tblaccountaccess set defaultaccess=0 where userid='" & globaluserid & "'" : com.ExecuteNonQuery()
                com.CommandText = "update tblaccountaccess set defaultaccess=1 where userid='" & globaluserid & "' and permission='" & DirectCast(txtPermission.SelectedItem, ComboBoxItem).HiddenValue() & "'" : com.ExecuteNonQuery()
                ForceCloseSystem = True
                For i As Integer = My.Application.OpenForms.Count - 1 To 0 Step -1
                    My.Application.OpenForms.Item(i).Close()
                Next i
                End
            End If
        End If
    End Sub

    Private Sub txtUserAccount_GotFocus(sender As Object, e As EventArgs) Handles txtPermission.GotFocus
        Me.AcceptButton = Nothing
    End Sub

    Private Sub frmChangeUserAccess_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadToComboBoxDB("select *,(select authDescription from tbluserauthority where authCode = tblaccountaccess.permission) as 'access' from tblaccountaccess where userid='" & globaluserid & "'", "access", "permission", txtPermission)
    End Sub
End Class