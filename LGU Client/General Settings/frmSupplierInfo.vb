Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO
Imports DevExpress.XtraEditors

Public Class frmSupplierInfo
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmCustomerInfo_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub frmSupplierInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico
        DXLoadToComboBox("completeaddress", "tblsupplier", txtAddress, True)
    End Sub
 
    Private Sub cmdSaveButton_Click(sender As Object, e As EventArgs) Handles cmdSaveButton.Click
        If countqry("tblsupplier", "suppliername='" & rchar(txtFullname.Text) & "' and deleted=0") > 0 Then
            XtraMessageBox.Show("Supplier name already exists on the record! Please search exact keyword", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtFullname.Focus()
            Exit Sub

        ElseIf txtFullname.Text = "" Then
            XtraMessageBox.Show("Please enter fullname!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtFullname.Focus()
            Exit Sub
        ElseIf txtAddress.Text = "" Then
            XtraMessageBox.Show("Please enter address!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtAddress.Focus()
            Exit Sub
        End If
        If XtraMessageBox.Show("Are you sure you want to continue? ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            If mode.Text = "edit" Then
                com.CommandText = "update tblsupplier set suppliername='" & txtFullname.Text & "', completeaddress='" & rchar(txtAddress.Text) & "',contactno='" & txtContactNo.Text & "',tin='" & txtTIN.Text & "', dateentry=current_timestamp,entryby='" & globaluserid & "'  where supplierid='" & id.Text & "'" : com.ExecuteNonQuery()
            Else
                com.CommandText = "insert into tblsupplier set suppliername='" & txtFullname.Text & "', completeaddress='" & rchar(txtAddress.Text) & "',contactno='" & txtContactNo.Text & "',tin='" & txtTIN.Text & "', dateentry=current_timestamp,entryby='" & globaluserid & "' " : com.ExecuteNonQuery()
            End If
        
            id.Text = "" : mode.Text = "" : txtFullname.Text = "" : txtAddress.Text = "" : txtContactNo.Text = "" : txtTIN.Text = "" : trnmode.Text = ""
            Me.Close()
        End If
    End Sub

    Public Sub showInfo()
        If id.Text = "" Then Exit Sub
        com.CommandText = "select * from tblsupplier where supplierid='" & id.Text & "'" : rst = com.ExecuteReader
        While rst.Read
            txtFullname.Text = rst("fullname").ToString
            txtAddress.Text = rst("address").ToString
            txtContactNo.Text = rst("contactno").ToString
            txtTIN.Text = rst("tin").ToString
        End While
        rst.Close()
    End Sub

    Private Sub id_EditValueChanged(sender As Object, e As EventArgs) Handles id.EditValueChanged
        showInfo()
    End Sub
     
End Class