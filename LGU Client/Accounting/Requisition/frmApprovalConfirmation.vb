Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO
Imports DevExpress.XtraEditors

Public Class frmApprovalConfirmation
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmApprovalConfirmation_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub frmApprovalConfirmation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico
        If mode.Text = "cancel" Then
            lbltitle.Text = "Please enter your cancel remarks to support cancel reason"
            cmdConfirm.Text = "Confirm Cancel"
        Else
            lbltitle.Text = "Please enter your confirmation remarks so next approver will depends on it"
            cmdConfirm.Text = "Confirm Request"
        End If
    End Sub

    Private Sub cmdaction_Click(sender As Object, e As EventArgs) Handles cmdConfirm.Click
        If mode.Text = "logs" Then
            If XtraMessageBox.Show("Are you sure you want to continue? ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                frmRequisitionInfo.requestLogHistory(txtRemarks.Text, "Process")
                Me.Hide()
            End If
        ElseIf mode.Text = "hold" Then
            If XtraMessageBox.Show("Are you sure you want to continue? ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                frmRequisitionForApprovalInfo.requestLogHistory(txtRemarks.Text, "Hold")
                Me.Hide()
            End If
        ElseIf mode.Text = "cancel" Then
            If XtraMessageBox.Show("Are you sure you want to continue cancel selected request? ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                frmRequisitionList.CancelRequest(txtRemarks.Text)
                Me.Hide()
            End If
        ElseIf mode.Text = "approved" Then
            If XtraMessageBox.Show("Are you sure you want to continue? ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                frmRequisitionForApprovalInfo.RequestConfirmation(txtRemarks.Text, "Approved")
                Me.Hide()
            End If
        End If
    End Sub
End Class