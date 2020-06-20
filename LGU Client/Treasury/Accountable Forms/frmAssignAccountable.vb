Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO
Imports System.Net
Imports DevExpress.XtraEditors

Public Class frmAssignAccountable
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function


    Private Sub frmAssignAccountable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico
        LoadToComboBoxDB("select accountid,fullname from tblaccounts where officeid='" & compOfficeid & "'", "fullname", "accountid", txtAccountable)
    End Sub

    Private Sub cmdset_Click(sender As Object, e As EventArgs) Handles cmdset.Click
        If txtAccountable.Text = "" Then
            XtraMessageBox.Show("Please select accountable person!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtAccountable.Focus()
            Exit Sub
        End If
        If XtraMessageBox.Show("Are you sure you want to continue? ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            com.CommandText = "insert into tblformreportlogs (invrefcode,formcode,beginning,datebeginning,ending,dateending,accountable) select id, formcode,currentno,current_timestamp,'',null,'" & DirectCast(txtAccountable.SelectedItem, ComboBoxItem).HiddenValue() & "' from tblforminventory where id='" & invcode.Text & "'" : com.ExecuteNonQuery()
            com.CommandText = "update tblforminventory set accountable='" & DirectCast(txtAccountable.SelectedItem, ComboBoxItem).HiddenValue() & "' where id='" & invcode.Text & "'" : com.ExecuteNonQuery()
            frmAccountableForms.ViewList()
            Me.Close()
        End If
    End Sub
End Class