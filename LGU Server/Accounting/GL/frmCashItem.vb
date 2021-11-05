Imports DevExpress.XtraEditors
Imports MySql.Data.MySqlClient
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraReports.UI
Imports DevExpress.Skins
Imports DevExpress.XtraSplashScreen

Public Class frmCashItem
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()

        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmCashItem_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        rst.Close()
    End Sub

    Private Sub frmCashItem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        ShowUnfilteredProducts()
        ShowfilteredProducts()
        PermissionAccess({cmdMoveLeft, cmdMoveRight}, globalAdminAccess)

    End Sub

    Public Sub ShowUnfilteredProducts()
        Dim productquery As String = ""
        com.CommandText = "select itemcode from tblglcashitem" : rst = com.ExecuteReader
        While rst.Read
            productquery = productquery + "'" & rst("itemcode").ToString & "',"
        End While
        rst.Close()
        If productquery.Length > 0 Then
            productquery = productquery.Remove(productquery.Length - 1, 1)
            productquery = "where itemcode not in (" & productquery & ")  and sl=1 "
        Else
            productquery = "where sl=1 "
        End If
        LoadXgrid("select itemcode, itemname as 'Item Name' from tblglitem " & productquery & " ", "tblglitem", Em_unfiltered, GridView1, Me)
        GridView1.Columns("itemcode").Visible = False
        XgridColMemo({"Item Name"}, GridView1)
        XgridColWidth({"Item Name"}, GridView1, Em_unfiltered.Width)
    End Sub

    Public Sub ShowfilteredProducts()
        LoadXgrid("select itemcode, (select itemname from tblglitem where itemcode= tblglcashitem.itemcode) as 'Item Name' from tblglcashitem order by id asc", "tblglcashitem", Em_filtered, GridView2, Me)
        GridView2.Columns("itemcode").Visible = False
        XgridColMemo({"Item Name"}, GridView2)
        XgridColWidth({"Item Name"}, GridView2, Em_filtered.Width)
    End Sub

    Private Sub BarLargeButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarLargeButtonItem2.ItemClick
        Me.Close()
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles cmdMoveRight.Click
        For I = 0 To GridView1.SelectedRowsCount - 1
            com.CommandText = "insert into tblglcashitem set itemcode='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "itemcode").ToString & "'" : com.ExecuteNonQuery()
        Next
        ShowUnfilteredProducts()
        ShowfilteredProducts()
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles cmdMoveLeft.Click
        For I = 0 To GridView2.SelectedRowsCount - 1
            com.CommandText = "delete from tblglcashitem where itemcode='" & GridView2.GetRowCellValue(GridView2.GetSelectedRows(I), "itemcode").ToString & "'" : com.ExecuteNonQuery()
        Next
        ShowUnfilteredProducts()
        ShowfilteredProducts()
    End Sub


End Class

