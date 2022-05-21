Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO
Imports DevExpress.XtraEditors

Public Class frmHoldMessage

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmHoldMessage_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Dispose()
    End Sub

    Private Sub frmHoldMessage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = ico

    End Sub

    Private Sub cmdSaveButton_Click(sender As Object, e As EventArgs) Handles cmdSaveButton.Click
        Me.Close()
    End Sub
End Class