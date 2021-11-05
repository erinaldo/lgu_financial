﻿Imports System.Globalization
Imports MySql.Data.MySqlClient
Imports System.Security
Imports System.IO

Public Class frmFileViewer
    Public viewonly As Boolean = True
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()

        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmLoanAdjustment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico
        MyDataGridView.Rows.Clear()
        MyDataGridView.ColumnCount = 4
        MyDataGridView.ColumnHeadersVisible = True

        MyDataGridView.Columns(0).Name = "File Name"
        MyDataGridView.Columns(1).Name = "File Sized"
        MyDataGridView.Columns(2).Name = "database"
        MyDataGridView.Columns(3).Name = "archivedname"

        GridColumnAlignment(MyDataGridView, {"File Sized"}, DataGridViewContentAlignment.MiddleRight)
        GridHideColumn(MyDataGridView, {"database", "archivedname"})
        showExistingFile()

        If viewonly = True Then
            MyDataGridView.ContextMenuStrip = Nothing
        Else
            MyDataGridView.ContextMenuStrip = cms_em
        End If
    End Sub
    Public Sub showExistingFile()
        MyDataGridView.Rows.Clear()
        com.CommandText = "select * from " & sqlfiledir & ".tblattachmentlogs where refnumber='" & trncode.Text & "' " & If(trntype.Text = "", "", " and trntype='" & trntype.Text & "'") & "" : rst = com.ExecuteReader
        While rst.Read
            MyDataGridView.Rows.Add(rst("filename").ToString, FormatNumber((rst("filesize") / 1024), 2) & " KB", rst("databasename").ToString, rst("archievedname").ToString)
        End While
        rst.Close()
    End Sub

    Private Sub DeleteCategoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteCategoryToolStripMenuItem.Click
        If MyDataGridView.RowCount = 0 Then
            MsgBox("No item is selected!", MsgBoxStyle.Critical)
            Exit Sub
        End If
        If MessageBox.Show("Are you sure you want to continue?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            For Each rw As DataGridViewRow In MyDataGridView.SelectedRows
                If rw.Cells("database").Value.ToString <> "" Then
                    com.CommandText = "delete from " & sqlfiledir & "." & rw.Cells("database").Value.ToString & " where filename='" & rw.Cells("File Name").Value.ToString & "' and refnumber='" & trncode.Text & "' " & If(trntype.Text = "", "", " and trntype='" & trntype.Text & "'") & "" : com.ExecuteNonQuery()
                    com.CommandText = "delete from " & sqlfiledir & ".tblattachmentlogs where filename='" & rw.Cells("File Name").Value.ToString & "' and refnumber='" & trncode.Text & "' " & If(trntype.Text = "", "", " and trntype='" & trntype.Text & "'") & "" : com.ExecuteNonQuery()
                End If
            Next
            showExistingFile()
            MsgBox("File successfuly deleted!", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles cmdExtract.Click
        ViewAttachmentPackage_All({trncode.Text}, trntype.Text)
    End Sub

    Private Sub MyDataGridView_CellMouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles MyDataGridView.CellMouseDown
        If e.ColumnIndex >= 0 And e.RowIndex >= 0 Then
            Me.MyDataGridView.CurrentCell = Me.MyDataGridView.Rows(e.RowIndex).Cells(e.ColumnIndex)
        End If
    End Sub

    Private Sub cmdAttach_Click(sender As Object, e As EventArgs) Handles cmdAttach.Click
        frmFileUploader.trncode.Text = trncode.Text
        frmFileUploader.trntype.Text = trntype.Text
        frmFileUploader.ShowDialog()
    End Sub

    Private Sub frmFileViewer_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        showExistingFile()
    End Sub

    Private Sub RefreshFilesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshFilesToolStripMenuItem.Click
        showExistingFile()
    End Sub
End Class