Imports DevExpress.XtraEditors
Imports MySql.Data.MySqlClient
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraReports.UI
Imports DevExpress.Skins
Imports DevExpress.XtraSplashScreen

Public Class frmRequisitionFilter
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()

        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmRequisitionFilter_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        rst.Close()
    End Sub

    Private Sub frmGLAccountsFilter_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        LoadCategory()
        ShowUnfilteredProducts()
        ShowfilteredProducts()
        PermissionAccess({cmdMoveLeft, cmdMoveRight}, globalAdminAccess)
    End Sub

    Public Sub LoadCategory()
        LoadXgridLookupSearch("select code, description 'Select' from tblrequisitiontype order by description asc", "tblrequisitiontype", txtRequisition, gridRequest, Me)
        gridRequest.Columns("code").Visible = False
    End Sub

    Private Sub txtprocat_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRequisition.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtRequisition.Properties.View.FocusedRowHandle.ToString)
        code.Text = txtRequisition.Properties.View.GetFocusedRowCellValue("code").ToString()
        ShowUnfilteredProducts()
        ShowfilteredProducts()
    End Sub

    Public Sub ShowUnfilteredProducts()
        Dim filter As String = ""
        com.CommandText = "select officeid from tblrequisitionfilter where requestcode='" & code.Text & "'" : rst = com.ExecuteReader
        While rst.Read
            filter = filter + "'" & rst("officeid").ToString & "',"
        End While
        rst.Close()
        If filter.Length > 0 Then
            filter = filter.Remove(filter.Length - 1, 1)
            filter = " and officeid not in (" & filter & ")"
        End If
        If code.Text <> "" Then
            LoadXgrid("select officeid, officename as 'Office' from tblcompoffice where deleted=0 " & filter & " ", "tblcompoffice", Em_unfiltered, GridView1, Me)
            GridView1.Columns("officeid").Visible = False
            XgridColMemo({"Office"}, GridView1)
            XgridColWidth({"Office"}, GridView1, Em_unfiltered.Width)
        End If
    End Sub

    Public Sub ShowfilteredProducts()
        If code.Text <> "" Then
            LoadXgrid("select officeid, (select officename from tblcompoffice where officeid= tblrequisitionfilter.officeid) as 'Office' from tblrequisitionfilter where requestcode='" & code.Text & "' order by officeid asc", "tblrequisitionfilter", Em_filtered, GridView2, Me)
            GridView2.Columns("officeid").Visible = False
            XgridColMemo({"Office"}, GridView2)
            XgridColWidth({"Office"}, GridView2, Em_filtered.Width)
        End If
    End Sub

    Private Sub BarLargeButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarLargeButtonItem2.ItemClick
        Me.Close()
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles cmdMoveRight.Click
        For I = 0 To GridView1.SelectedRowsCount - 1
            com.CommandText = "insert into tblrequisitionfilter set requestcode='" & code.Text & "', officeid='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "officeid").ToString & "'" : com.ExecuteNonQuery()
        Next
        ShowUnfilteredProducts()
        ShowfilteredProducts()
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles cmdMoveLeft.Click
        For I = 0 To GridView2.SelectedRowsCount - 1
            com.CommandText = "delete from tblrequisitionfilter where officeid='" & GridView2.GetRowCellValue(GridView2.GetSelectedRows(I), "officeid").ToString & "' and requestcode='" & code.Text & "'" : com.ExecuteNonQuery()
        Next
        ShowUnfilteredProducts()
        ShowfilteredProducts()
    End Sub


End Class

