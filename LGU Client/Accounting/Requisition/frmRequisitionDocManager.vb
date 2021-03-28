Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO
Imports DevExpress.XtraEditors

Public Class frmRequisitionDocManager
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmRequisitionDocManager_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If GridView1.RowCount > 0 Then
            If countqry("tblrequisitionfiles", "pid='" & pid.Text & "' and filecode='" & filecode.Text & "' and officeid='" & compOfficeid & "'") = 0 Then
                If XtraMessageBox.Show("Are you sure you want to close current request? Closing unsaved request will cancelling all current transaction.", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
                    com.CommandText = "delete from " & sqlfiledir & ".tblattachmentlogs where refnumber='" & pid.Text & "' and trntype='requisition' and filecode='" & filecode.Text & "'" : com.ExecuteNonQuery()
                    com.CommandText = "delete from " & sqlfiledir & ".tbl" & GetAttachmentDate() & " where refnumber='" & pid.Text & "' and trntype='requisition' and filecode='" & filecode.Text & "'" : com.ExecuteNonQuery()
                Else
                    e.Cancel = True
                End If
            End If
        End If
    End Sub

    Private Sub frmRequisitionDocManager_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = ico
        If mode.Text <> "edit" Then
            cmdForApproval.Text = "Confirm Attachment Files"
            filecode.Text = getGlobalTrnid()
        Else
            cmdForApproval.Text = "Close Attachment Manager"
        End If

        filterItem()
    End Sub

    Public Sub filterItem()
        LoadXgrid("select refnumber, docname,databasename, (select description from tbldocumenttype where code=b.docname) as 'Document Name', concat(cast(count(*) as CHAR), ' File(s)') as 'Total Files' from " & sqlfiledir & ".tblattachmentlogs as b where refnumber='" & pid.Text & "'  and trntype='requisition' and filecode='" & filecode.Text & "' group by docname", "tblattachmentlogs", Em, GridView1, Me)
        XgridHideColumn({"refnumber", "docname", "databasename"}, GridView1)
        XgridColAlign({"Total Files"}, GridView1, DevExpress.Utils.HorzAlignment.Center)
        XgridColMemo({"Document Name"}, GridView1)
        GridView1.BestFitColumns()
        XgridColWidth({"Document Name"}, GridView1, 350)
    End Sub

    Private Sub SelectItemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectItemToolStripMenuItem.Click
        cmdAddfiles.PerformClick()
    End Sub

    Private Sub ToolStripMenuItem5_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem5.Click
        filterItem()
    End Sub
 
    Private Sub cmdAddfiles_Click(sender As Object, e As EventArgs) Handles cmdAddfiles.Click
        frmRequisitionBrowseFile.pid.Text = pid.Text
        frmRequisitionBrowseFile.filecode.Text = filecode.Text
        frmRequisitionBrowseFile.trntype.Text = "requisition"
        frmRequisitionBrowseFile.requesttype.Text = requesttype.Text
        If frmRequisitionBrowseFile.Visible = True Then
            frmRequisitionBrowseFile.Focus()
        Else
            frmRequisitionBrowseFile.Show(Me)
        End If
    End Sub

    Private Sub RemoveAttachementToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveAttachementToolStripMenuItem.Click
        If GridView1.SelectedRowsCount = 0 Then
            XtraMessageBox.Show("Nothing is selected!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        If XtraMessageBox.Show("Are you sure you want to permanently remove selected item? ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            Dim I As Integer = 0
            For I = 0 To GridView1.SelectedRowsCount - 1
                com.CommandText = "delete from " & sqlfiledir & ".tblattachmentlogs where refnumber='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "refnumber") & "' and trntype='requisition' and docname='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "docname") & "' and filecode='" & filecode.Text & "'" : com.ExecuteNonQuery()
                com.CommandText = "delete from " & sqlfiledir & "." & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "databasename") & " where refnumber='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "refnumber") & "' and trntype='requisition' and docname='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "docname") & "' and filecode='" & filecode.Text & "'" : com.ExecuteNonQuery()
            Next
            filterItem()
        End If
    End Sub

    Private Sub cmdForApproval_Click(sender As Object, e As EventArgs) Handles cmdForApproval.Click
        If mode.Text = "edit" Then
            Me.Close()
        Else
            If MessageBox.Show("Are you sure you want to continue?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                com.CommandText = "insert into tblrequisitionfiles set pid='" & pid.Text & "', requesttype='" & requesttype.Text & "', filecode='" & filecode.Text & "', applevel='" & applevel.Text & "', officeid='" & compOfficeid & "', trnby='" & globaluserid & "', datetrn=current_timestamp" : com.ExecuteNonQuery()
                If frmRequisitionInfo.Visible = True Then
                    frmRequisitionInfo.LoadFiles()
                End If
                If frmRequisitionForApprovalInfo.Visible = True Then
                    frmRequisitionForApprovalInfo.LoadFiles()
                End If
                XtraMessageBox.Show("Files successfully attached!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            End If
        End If

    End Sub
End Class