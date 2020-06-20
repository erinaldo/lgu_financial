Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO
Imports DevExpress.XtraEditors

Public Class frmVoucherItem
      Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        If XtraMessageBox.Show("Are you sure you want to continue? ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            If mode.Text = "edit" Then
                com.CommandText = "Update tbldisbursementvoucheritem set voucherno='" & voucherno.Text & "', explaination='" & rchar(txtExplaination.Text) & "', amount='" & Val(CC(txtAmount.Text)) & "' where id='" & id.Text & "'" : com.ExecuteNonQuery()
            Else
                com.CommandText = "insert into tbldisbursementvoucheritem set voucherno='" & voucherno.Text & "', explaination='" & rchar(txtExplaination.Text) & "', amount='" & Val(CC(txtAmount.Text)) & "'" : com.ExecuteNonQuery()
            End If
            frmVoucherInfo.LoadDisbursementItem()
            Me.Close()
        End If
    End Sub

    Private Sub frmVoucherItem_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub frmBudgetNew_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico
        If mode.Text = "edit" Then
            LoadInfo()
        End If
    End Sub
    Public Sub LoadInfo()
        com.CommandText = "select * from tbldisbursementvoucheritem where id='" & id.Text & "'" : rst = com.ExecuteReader
        While rst.Read
            txtExplaination.Text = rst("explaination").ToString
            txtAmount.Text = FormatNumber(rst("amount").ToString, 2)
        End While
        rst.Close()

    End Sub
End Class