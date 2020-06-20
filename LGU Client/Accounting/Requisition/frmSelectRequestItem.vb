Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO
Imports DevExpress.XtraEditors

Public Class frmSelectRequestItem
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmSelectRequestItem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = ico
        filterItem()
        txtfilter.Focus()
    End Sub

    Public Sub filterItem()
        LoadXgrid("Select productid as 'Item Code',categoryid, " _
                           + " productname as 'Particular Name', " _
                           + " categoryname  as 'Category', classificationname as 'Class Name', Unit " _
                           + " from tblproducts  " _
                           + " where deleted=0 and (productname like '%" & rchar(txtfilter.Text) & "%' or productid like '%" & rchar(txtfilter.Text) & "%') " _
                           + " order by productname asc", "tblproducts", Em, GridView1, Me)
        XgridHideColumn({"categoryid"}, GridView1)
        GridView1.Columns("Item Code").Width = 70
        XgridColAlign({"Item Code"}, GridView1, DevExpress.Utils.HorzAlignment.Center)
        GridView1.Columns("Particular Name").ColumnEdit = MemoEdit
    End Sub

    Private Sub SelectItemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectItemToolStripMenuItem.Click
        frmQuantitySelect.productid.Text = GridView1.GetFocusedRowCellValue("Item Code").ToString()
        frmQuantitySelect.txtproduct.Text = GridView1.GetFocusedRowCellValue("Particular Name").ToString()
        frmQuantitySelect.txtUnit.Text = GridView1.GetFocusedRowCellValue("Unit").ToString()
        frmQuantitySelect.catid.Text = GridView1.GetFocusedRowCellValue("categoryid").ToString()
        frmQuantitySelect.Show(Me)
    End Sub

    Private Sub ToolStripMenuItem5_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem5.Click
        filterItem()
    End Sub
 
    Private Sub Em_KeyDown(sender As Object, e As KeyEventArgs) Handles Em.KeyDown
        If e.KeyCode() = Keys.Enter Then
            SelectItemToolStripMenuItem.PerformClick()
        End If
    End Sub

    Private Sub txtfilter_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtfilter.KeyPress
        If e.KeyChar() = Chr(13) Then
            filterItem()
        End If
    End Sub

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub cmdAddnew_Click(sender As Object, e As EventArgs) Handles cmdAddnew.Click
        frmProductItem.ShowDialog(Me)
    End Sub
End Class