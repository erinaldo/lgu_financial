Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO
Imports DevExpress.XtraEditors

Public Class frmSourceOfFund
    Public ReadOnlyTrn As Boolean
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmSourceOfFund_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = ico
        LoadSource()
        If ReadOnlyTrn = False Then
            Em.ContextMenuStrip = ContextMenuStrip1
            cmdAddfiles.Visible = True
        Else
            Em.ContextMenuStrip = Nothing
            cmdAddfiles.Visible = False
        End If
    End Sub


    Public Sub LoadSource()
        LoadXgrid("select id,classcode as 'Class', Quarter, itemcode as 'Item Code', (select itemname from tblglitem where itemcode=a.itemcode) as 'Item Name', Amount from tmprequisitionfund as a where pid='" & pid.Text & "'", "tmprequisitionfund", Em, GridView1, Me)
        XgridHideColumn({"id"}, GridView1)
        XgridColAlign({"Item Code", "Class", "Quarter"}, GridView1, DevExpress.Utils.HorzAlignment.Center)
        XgridColCurrency({"Amount"}, GridView1)
        XgridGeneralSummaryCurrency({"Amount"}, GridView1)
        GridView1.BestFitColumns()
    End Sub

    Private Sub SelectItemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles cmdEdit.Click
        If GridView1.RowCount = 0 Then
            XtraMessageBox.Show("No selected item", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        frmSourceOfFundInfo.mode = "edit"
        frmSourceOfFundInfo.id = GridView1.GetFocusedRowCellValue("id").ToString
        frmSourceOfFundInfo.pid.Text = pid.Text
        frmSourceOfFundInfo.officeid.Text = officeid.Text
        frmSourceOfFundInfo.periodcode.Text = periodcode.Text
        frmSourceOfFundInfo.requestno.Text = requestno.Text
        frmSourceOfFundInfo.ShowDialog(Me)
    End Sub

    Private Sub cmdAddfiles_Click(sender As Object, e As EventArgs) Handles cmdAddfiles.Click
        frmSourceOfFundInfo.pid.Text = pid.Text
        frmSourceOfFundInfo.officeid.Text = officeid.Text
        frmSourceOfFundInfo.periodcode.Text = periodcode.Text
        frmSourceOfFundInfo.requestno.Text = requestno.Text
        frmSourceOfFundInfo.ShowDialog(Me)
    End Sub

    Private Sub cmdRemove_Click(sender As Object, e As EventArgs) Handles cmdRemove.Click
        If GridView1.RowCount = 0 Then
            XtraMessageBox.Show("No selected item", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If XtraMessageBox.Show("Are you sure you want to permanently remove selected item? ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            Dim I As Integer = 0
            For I = 0 To GridView1.SelectedRowsCount - 1
                com.CommandText = "delete from tmprequisitionfund where id='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "id") & "' " : com.ExecuteNonQuery()
            Next
            LoadSource()
        End If
    End Sub

    Private Sub ToolStripMenuItem5_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem5.Click
        LoadSource()
    End Sub

    Private Sub cmdForApproval_Click(sender As Object, e As EventArgs) Handles cmdForApproval.Click
        Me.Close()
    End Sub
End Class