Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO
Imports DevExpress.XtraEditors

Public Class frmCollectionInputAmount
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmCustomerInfo_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub frmCustomerInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico

    End Sub
     
    Private Sub cmdSaveButton_Click(sender As Object, e As EventArgs) Handles cmdSaveButton.Click
        If XtraMessageBox.Show("Are you sure you want to continue? ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            Dim isdebit As Boolean = False : Dim cashflowcode As String = ""
            com.CommandText = "select *,(select cashflowcode from tblcashflowtagging where glitemcode=tblglitem.itemcode) as cashflowcode  from tblglitem where itemcode='" & glitemcode.Text & "'" : rst = com.ExecuteReader
            While rst.Read
                isdebit = rst("debitentry")
                cashflowcode = rst("cashflowcode").ToString
            End While
            rst.Close()
            frmCollectionPosting.ProcessCollection(trncode.Text, grpTitle.Text, glitemcode.Text, glitemname.Text, txtExplaination.Text, isdebit, Val(CC(txtAmount.Text)), cashflowcode)
            Me.Close()
        End If
    End Sub
End Class