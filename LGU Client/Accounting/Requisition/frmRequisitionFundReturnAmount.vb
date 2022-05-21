Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmRequisitionFundReturnAmount
    Public id As String = ""
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmRequisitionReturnAmount_FormClosed(ByVal sender As Object, ByVal e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub frmRequisitionReturnAmount_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Me.Icon = ico
    End Sub

    Private Sub cmdaction_Click(sender As Object, e As EventArgs) Handles cmdaction.Click
        If Val(txtAmount.EditValue) <= 0 Then
            XtraMessageBox.Show("Please enter valid amount!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        ElseIf val(txtAmount.EditValue) > val(txtRequestedAmount.EditValue) Then
            XtraMessageBox.Show("Please enter amount not more than obligated amount!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        com.CommandText = "update tmprequisitionfund set tempamount='" & CC(Val(txtAmount.EditValue)) & "' where id='" & id & "'" : com.ExecuteNonQuery()
        frmRequisitionFundReturn.LoadSource()
        Me.Close()
    End Sub
End Class