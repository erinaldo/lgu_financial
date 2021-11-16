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
        LoadItemInfo()
    End Sub

    Private Sub trncode_EditValueChanged(sender As Object, e As EventArgs) Handles trncode.EditValueChanged
        LoadItemInfo()
    End Sub

    Public Sub LoadItemInfo()
        com.CommandText = "select *,(select itemname from tblglitem where itemcode=a.glitemcode) as itemname from tblcollectionitem as a where trncode='" & trncode.Text & "'" : rst = com.ExecuteReader
        While rst.Read
            grpTitle.Text = rst("trnname").ToString
            txtCollectionName.Text = rst("trnname").ToString
            txtAmount.Text = rst("amount").ToString
            glitemcode.Text = rst("glitemcode").ToString
            glitemname.Text = rst("itemname").ToString
            If CBool(rst("locked")) Then
                txtAmount.ReadOnly = True
                txtExplaination.Focus()
                txtExplaination.TabIndex = 0
                txtAmount.TabIndex = 1
            Else
                txtAmount.ReadOnly = False
                txtAmount.Focus()
                txtAmount.TabIndex = 0
                txtExplaination.TabIndex = 1
            End If
        End While
        rst.Close()
    End Sub

    Private Sub cmdSaveButton_Click(sender As Object, e As EventArgs) Handles cmdSaveButton.Click
        If XtraMessageBox.Show("Are you sure you want to continue? ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            Dim isdebit As Boolean = False : Dim cashflowcode As String = ""
            com.CommandText = "select *,(select cashflowcode from tblcashflowtagging where glitemcode=a.itemcode) as cashflowcode, " _
                        + " count((select id from tblglreverseitem where itemcode=a.itemcode)) as reverseitem, " _
                        + " (select debit from tblglreverseitem where itemcode=a.itemcode) as reversedebit " _
                        + " from tblglitem as a where itemcode='" & glitemcode.Text & "'" : rst = com.ExecuteReader
            While rst.Read
                If CInt(rst("reverseitem")) > 0 Then
                    isdebit = rst("reversedebit")
                Else
                    isdebit = rst("debitentry")
                End If
                cashflowcode = rst("cashflowcode").ToString
            End While
            rst.Close()
            frmCollectionPosting.ProcessCollection(trncode.Text, grpTitle.Text, glitemcode.Text, glitemname.Text, txtExplaination.Text, isdebit, Val(CC(txtAmount.Text)), cashflowcode)
            Me.Close()
        End If
    End Sub


End Class