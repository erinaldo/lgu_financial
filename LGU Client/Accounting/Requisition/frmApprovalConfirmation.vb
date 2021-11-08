Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO
Imports DevExpress.XtraEditors

Public Class frmApprovalConfirmation
    Public TransactionDone As Boolean = False
    Public RequiredAdminOveride As Boolean = False
    Public RequiredAuthorizedAccess As Boolean = False
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    'Private Sub frmApprovalConfirmation_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
    '    Me.Dispose()
    'End Sub

    Private Sub frmApprovalConfirmation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico
        txtRemarks.Text = ""
        txtAccessAccount.EditValue = Nothing
        If mode.Text = "cancel" Then
            lbltitle.Text = "Please enter your cancel remarks to support cancel reason"
            cmdConfirm.Text = "Confirm Cancel"
        Else
            lbltitle.Text = "Please enter your confirmation remarks so next approver will depends on it"
            cmdConfirm.Text = "Confirm Request"
        End If
        If RequiredAuthorizedAccess = True Then
            Me.Size = New Size(473, 230)
            cmdConfirm.Location = New Point(256, 144)
            LabelControl1.Visible = True
            txtAccessAccount.Visible = True
            LoadAccessAccount()
        Else
            Me.Size = New Size(473, 202)
            cmdConfirm.Location = New Point(256, 114)
            LabelControl1.Visible = False
            txtAccessAccount.Visible = False
        End If
    End Sub

    Public Sub LoadAccessAccount()
        LoadXgridLookupSearch("select accessto, (select Fullname from tblaccounts where accountid=a.accessto) as 'Fullname' from tblauthorizedaccess as a where userid ='" & globaluserid & "' and current_date between datefrom and dateto order by accessto asc", "tblauthorizedaccess", txtAccessAccount, gridAccessTo)
        gridAccessTo.Columns("accessto").Visible = False
    End Sub

    Private Sub cmdaction_Click(sender As Object, e As EventArgs) Handles cmdConfirm.Click
        If mode.Text = "cancel" Then
            If txtRemarks.Text = "" Then
                MessageBox.Show("Please provide cancel reason to justify your actions!", "Error Access", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        ElseIf RequiredAuthorizedAccess = True And txtAccessAccount.Text = "" Then
            MessageBox.Show("Please select authorized account!", "Error Access", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If RequiredAdminOveride = True Then
            If XtraMessageBox.Show("This action required admin overide!" & Environment.NewLine & "Are you sure you want to continue?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
                frmAdminOveride.ShowDialog(Me)
                If frmAdminOveride.AccessOverride = True Then
                    TransactionDone = True
                    Me.Close()
                End If
                frmAdminOveride.AccessOverride = False
                frmAdminOveride.Dispose()
            End If
        Else
            If XtraMessageBox.Show("Are you sure you want to continue? ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                TransactionDone = True
                Me.Close()
            End If
        End If
    End Sub
End Class