Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO
Imports DevExpress.XtraEditors

Public Class frmPurchaseRequest
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmQuantitySelect_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub frmQuantitySelect_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = ico
        ShowItemInfo()
    End Sub

    Public Sub ShowItemInfo()
        com.CommandText = "select * from tblpurchaserequest where prnumber='" & txtPRNumber.Text & "'" : rst = com.ExecuteReader
        While rst.Read
            txtSection.Text = rst("section").ToString
            txtSaiNo.Text = rst("sai_no").ToString
            txtSaiDate.Text = If(rst("sai_date").ToString = "", "", CDate(rst("sai_date").ToString))
            txtAlobsNo.Text = rst("alobs_no").ToString
            txtAlobsDate.Text = If(rst("alobs_date").ToString = "", "", CDate(rst("alobs_date").ToString))
            txtPurpose.Text = rst("purpose").ToString
            txtAddPrintLine.Text = rst("printline").ToString
        End While
        rst.Close()
    End Sub

 
    Private Sub cmdaction_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdaction.Click
        If XtraMessageBox.Show("Are you sure you want to continue? ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            If countqry("tblpurchaserequest", "prnumber='" & txtPRNumber.Text & "'") = 0 Then
                com.CommandText = "insert into tblpurchaserequest set prnumber='" & txtPRNumber.Text & "', " _
                                       + " pid='" & pid.Text & "'," _
                                       + " pr_date='" & ConvertDate(txtPostingDate.EditValue) & "', " _
                                       + " officeid='" & officeid.Text & "', " _
                                       + " section='" & rchar(txtSection.Text) & "', " _
                                       + " sai_no='" & txtSaiNo.Text & "', " _
                                       + If(txtSaiDate.Text = "", " sai_date=null, ", " sai_date='" & ConvertDate(txtSaiDate.EditValue) & "', ") _
                                       + " alobs_no='" & txtAlobsNo.Text & "', " _
                                       + If(txtAlobsDate.Text = "", " alobs_date=null, ", " alobs_date='" & ConvertDate(txtAlobsDate.EditValue) & "', ") _
                                       + " purpose='" & rchar(txtPurpose.Text) & "', " _
                                       + " printline=" & txtAddPrintLine.Text & ", " _
                                       + " trnby='" & globaluserid & "', " _
                                       + " datetrn=current_timestamp" : com.ExecuteNonQuery()

                XtraMessageBox.Show("Purchase request successfully save!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                PrintPurchaseRequest(pid.Text, txtAddPrintLine.Text, Me)
            Else
                com.CommandText = "update tblpurchaserequest set prnumber='" & txtPRNumber.Text & "', " _
                                       + " pid='" & pid.Text & "'," _
                                       + " pr_date='" & ConvertDate(txtPostingDate.EditValue) & "', " _
                                       + " officeid='" & officeid.Text & "', " _
                                       + " section='" & rchar(txtSection.Text) & "', " _
                                       + " sai_no='" & txtSaiNo.Text & "', " _
                                       + If(txtSaiDate.Text = "", " sai_date=null, ", " sai_date='" & ConvertDate(txtSaiDate.EditValue) & "', ") _
                                       + " alobs_no='" & txtAlobsNo.Text & "', " _
                                       + If(txtAlobsDate.Text = "", " alobs_date=null, ", " alobs_date='" & ConvertDate(txtAlobsDate.EditValue) & "', ") _
                                       + " purpose='" & rchar(txtPurpose.Text) & "', " _
                                       + " printline=" & txtAddPrintLine.Text & ", " _
                                       + " trnby='" & globaluserid & "', " _
                                       + " datetrn=current_timestamp where prnumber='" & txtPRNumber.Text & "'" : com.ExecuteNonQuery()
                XtraMessageBox.Show("Purchase request successfully updated!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                PrintPurchaseRequest(pid.Text, txtAddPrintLine.Text, Me)

            End If
        End If

    End Sub

    
 
End Class