Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO
Imports DevExpress.XtraEditors

Public Class frmCashPaymentConfirmation
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmCashPaymentConfirmation_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub frmCashPaymentConfirmation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico    
    End Sub
     
    Private Sub cmdCheckPrinter_Click(sender As Object, e As EventArgs) Handles cmdCheckPrinter.Click
        If trnmode.Text = "collection" Then
            If globalEnableTemporaryDisablePrinting = False Then
                PrintCollectionReceipt(txtORnumber.Text, cidid.Text, fundcode.Text, frmCedulaIndividual.invrefcode.Text, False)
            End If
            If XtraMessageBox.Show("Are you sure you want to continue? ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                Me.Hide()
                frmCollectionPosting.ConfirmedTransaction(Val(CC(txtEnterPayment.Text)), Val(CC(txtPaymentChange.Text)))
                Me.Close()
            End If
        ElseIf trnmode.Text = "cedulaindividual" Then
            If globalEnableTemporaryDisablePrinting = False Then
                PrintCedulaReceiptIndividual(txtORnumber.Text, cidid.Text, fundcode.Text, False)
            End If
            If XtraMessageBox.Show("Are you sure you want to continue? ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                Me.Hide()
                frmCedulaIndividual.ConfirmedTransaction(Val(CC(txtEnterPayment.Text)), Val(CC(txtPaymentChange.Text)))
                Me.Close()
            End If
        ElseIf trnmode.Text = "cedulacorporate" Then
            If globalEnableTemporaryDisablePrinting = False Then
                PrintCedulaReceiptCorporation(txtORnumber.Text, cidid.Text, fundcode.Text, False)
            End If
            If XtraMessageBox.Show("Are you sure you want to continue? ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                Me.Hide()
                frmCedulaCorporation.ConfirmedTransaction(Val(CC(txtEnterPayment.Text)), Val(CC(txtPaymentChange.Text)))
                Me.Close()
            End If
        End If

       
    End Sub

    Private Sub txtEnterPayment_EditValueChanged(sender As Object, e As EventArgs) Handles txtEnterPayment.EditValueChanged
        txtPaymentChange.Text = FormatNumber(Val(CC(txtEnterPayment.Text)) - Val(CC(txTotalOnScreen.Text)), 2)
        If Val(CC(txtPaymentChange.Text)) > 0 Then
            txtPaymentChange.BackColor = Color.Lime
            txtPaymentChange.ForeColor = Color.Black
        ElseIf Val(CC(txtPaymentChange.Text)) < 0 Then
            txtPaymentChange.BackColor = Color.Red
            txtPaymentChange.ForeColor = Color.White
        Else
            txtPaymentChange.BackColor = DefaultBackColor
            txtPaymentChange.ForeColor = DefaultForeColor
        End If
    End Sub
End Class