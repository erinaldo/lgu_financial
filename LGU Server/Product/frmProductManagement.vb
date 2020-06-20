Imports DevExpress.XtraEditors
Imports MySql.Data.MySqlClient
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraReports.UI
Imports DevExpress.Skins
Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmProductManagement

    Private Sub frmProductManagement_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        SetIcon(Me)
        LoadReport()
        LoadCategory()
    End Sub

    Public Sub LoadCategory()
        LoadXgridLookupSearch("SELECT code, Description as 'Select' from tblproductcategory", "tblproductcategory", txtCategory, gridcategory, Me)
        gridcategory.Columns("code").Visible = False
    End Sub
    Private Sub txtCategory_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCategory.EditValueChanged
        On Error Resume Next
        categorycode.Text = txtCategory.Properties.View.GetFocusedRowCellValue("code").ToString()
        LoadReport()
    End Sub

    Public Sub LoadReport()
        If CheckEdit1.Checked = False And txtCategory.Text = "" Then Exit Sub
        LoadXgrid("Select productid as 'Code', productname as 'Transaction Item Name',categoryname as 'Category Name',classificationname as'Clasification', NonInventory, PPE, Consumable from tblproducts as a where (productname like '%" & txtfilter.Text & "%' or categoryname like '%" & txtfilter.Text & "%' or classificationname like '%" & txtfilter.Text & "%') " & If(CheckEdit1.Checked = True, "", " and categoryid='" & categorycode.Text & "' ") & " and deleted=0 order by productname asc", "tblproducts", Em, GridView1, Me)
        'XgridHideColumn({"Cancelled"}, GridView1)
        XgridColAlign({"Code", "NonInventory, PPE, Consumable"}, GridView1, DevExpress.Utils.HorzAlignment.Center)
        GridView1.BestFitColumns()
    End Sub

    Private Sub BarLargeButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarLargeButtonItem2.ItemClick
        Me.Close()
    End Sub

    Private Sub CheckEdit1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckEdit1.CheckedChanged
        If CheckEdit1.Checked = True Then
            txtCategory.Enabled = False
        Else
            txtCategory.Enabled = True
        End If
    End Sub

    Private Sub txtfilter_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtfilter.KeyPress
        If e.KeyChar() = Chr(13) Then
            LoadReport()
        End If
    End Sub
 
    Private Sub cmdNewProduct_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdNewProduct.ItemClick
        If frmProductInfo.Visible = True Then
            frmProductInfo.Focus()
        Else
            frmProductInfo.Show(Me)
        End If
    End Sub

    Private Sub cmdEdit_Click(sender As Object, e As EventArgs) Handles cmdEdit.Click
        frmProductInfo.mode.Text = ""
        frmProductInfo.code.Text = GridView1.GetFocusedRowCellValue("Code").ToString
        frmProductInfo.mode.Text = "edit"
        If frmProductInfo.Visible = True Then
            frmProductInfo.Focus()
        Else
            frmProductInfo.Show(Me)
        End If
    End Sub

    Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
        If XtraMessageBox.Show("Are you sure you want to permanently remove selected item? ", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            Dim I As Integer = 0
            For I = 0 To GridView1.SelectedRowsCount - 1
                com.CommandText = "update tblproducts set deleted=1 where productid='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "Code") & "' " : com.ExecuteNonQuery()
            Next
            LoadReport()
        End If
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        LoadReport()
    End Sub
End Class

