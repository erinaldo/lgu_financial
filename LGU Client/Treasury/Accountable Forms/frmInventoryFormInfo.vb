Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO
Imports DevExpress.XtraEditors

Public Class frmInventoryFormInfo
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmFormInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico
        LoadForm()
    End Sub

    Public Sub LoadForm()
        LoadXgridLookupSearch("SELECT code,Description from tblaccountableform order by Description", "tblaccountableform", txtForm, gridForm)
        gridForm.Columns("code").Visible = False
    End Sub
    Private Sub txtFund_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtForm.EditValueChanged
        On Error Resume Next
        formcode.Text = txtForm.Properties.View.GetFocusedRowCellValue("code").ToString()
    End Sub

    Private Sub cmdSaveButton_Click(sender As Object, e As EventArgs) Handles cmdSaveButton.Click
        If txtForm.Text = "" Then
            XtraMessageBox.Show("Please select form!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtForm.Focus()
            Exit Sub
        ElseIf txtSeriesFrom.Text = "" Then
            XtraMessageBox.Show("Please enter series from!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtSeriesFrom.Focus()
            Exit Sub
        ElseIf txtSeriesTo.Text = "" Then
            XtraMessageBox.Show("Please enter series to!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtSeriesTo.Focus()
            Exit Sub
        ElseIf txtCurrentNo.Text = "" Then
            XtraMessageBox.Show("Please enter current no!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtCurrentNo.Focus()
            Exit Sub
        End If
        If mode.Text = "edit" Then
            com.CommandText = "update tblforminventory set formcode='" & formcode.Text & "',officeid='" & compOfficeid & "', seriesfrom='" & txtSeriesFrom.Text & "', seriesto='" & txtSeriesTo.Text & "',currentno='" & txtCurrentNo.Text & "',dateentry=current_timestamp,entryby='" & globaluserid & "'  where id='" & id.Text & "'" : com.ExecuteNonQuery()
        Else
            com.CommandText = "insert into tblforminventory set formcode='" & formcode.Text & "',officeid='" & compOfficeid & "',seriesfrom='" & txtSeriesFrom.Text & "', seriesto='" & txtSeriesTo.Text & "',currentno='" & txtCurrentNo.Text & "',dateentry=current_timestamp,entryby='" & globaluserid & "' " : com.ExecuteNonQuery()
        End If
        id.Text = "" : mode.Text = "" : formcode.Text = "" : txtForm.EditValue = Nothing : txtSeriesFrom.Text = "" : txtSeriesTo.Text = "" : txtCurrentNo.Text = "" : txtSeriesFrom.Focus()
        frmAccountableForms.ViewList()
        XtraMessageBox.Show("form successfully saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Public Sub showInfo()
        If id.Text = "" Then Exit Sub
        com.CommandText = "select * from tblforminventory where id='" & id.Text & "'" : rst = com.ExecuteReader
        While rst.Read
            txtForm.EditValue = rst("formcode").ToString
            formcode.Text = rst("formcode").ToString
            txtSeriesFrom.Text = rst("seriesfrom").ToString
            txtSeriesTo.Text = rst("seriesto").ToString
            txtCurrentNo.Text = rst("currentno").ToString
        End While
        rst.Close()

    End Sub

    Private Sub id_EditValueChanged(sender As Object, e As EventArgs) Handles id.EditValueChanged
        showInfo()
    End Sub
End Class