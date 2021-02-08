Imports DevExpress.XtraEditors
Imports MySql.Data.MySqlClient
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraReports.UI
Imports DevExpress.Skins
Imports DevExpress.XtraSplashScreen

Public Class frmCheckApprovalFilter
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()

        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmTransactionCodeFilter_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        rst.Close()
    End Sub

    Private Sub frmGLAccountsFilter_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        LoadCategory()
        ShowUnfilteredProducts()
        ShowfilteredProducts()

    End Sub

    Public Sub LoadCategory()
        LoadXgridLookupSearch("select accesscode,description 'Select Permission' from tblclientaccess where generalapprover=1 order by description asc", "tblclientaccess", txtPermission, gvpermission, Me)
        gvpermission.Columns("accesscode").Visible = False
    End Sub

    Private Sub txtprocat_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPermission.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtPermission.Properties.View.FocusedRowHandle.ToString)
        permissioncode.Text = txtPermission.Properties.View.GetFocusedRowCellValue("accesscode").ToString()
        ShowUnfilteredProducts()
        ShowfilteredProducts()
    End Sub

    Public Sub ShowUnfilteredProducts()
        Dim productquery As String = ""
        com.CommandText = "select officeid from tblcheckapprovalfilter where permissioncode='" & permissioncode.Text & "'" : rst = com.ExecuteReader
        While rst.Read
            productquery = productquery + "'" & rst("officeid").ToString & "',"
        End While
        rst.Close()
        If productquery.Length > 0 Then
            productquery = productquery.Remove(productquery.Length - 1, 1)
            productquery = "where officeid not in (" & productquery & ")"
        End If
        If permissioncode.Text <> "" Then
            LoadXgrid("select officeid, officename as 'Office' from tblcompoffice " & productquery & " ", "tblcompoffice", Em_unfiltered, GridView1, Me)
            GridView1.Columns("officeid").Visible = False
            XgridColMemo({"Office"}, GridView1)
            XgridColWidth({"Office"}, GridView1, Em_unfiltered.Width)
        End If
    End Sub

    Public Sub ShowfilteredProducts()
        If permissioncode.Text <> "" Then
            LoadXgrid("select officeid, (select officename from tblcompoffice where officeid= tblcheckapprovalfilter.officeid) as 'Office' from tblcheckapprovalfilter where permissioncode='" & permissioncode.Text & "' order by officeid asc", "tblcheckapprovalfilter", Em_filtered, GridView2, Me)
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
            com.CommandText = "insert into tblcheckapprovalfilter set permissioncode='" & permissioncode.Text & "', officeid='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "officeid").ToString & "'" : com.ExecuteNonQuery()
        Next
        ShowUnfilteredProducts()
        ShowfilteredProducts()
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles cmdMoveLeft.Click
        For I = 0 To GridView2.SelectedRowsCount - 1
            com.CommandText = "delete from tblcheckapprovalfilter where officeid='" & GridView2.GetRowCellValue(GridView2.GetSelectedRows(I), "officeid").ToString & "' and permissioncode='" & permissioncode.Text & "'" : com.ExecuteNonQuery()
        Next
        ShowUnfilteredProducts()
        ShowfilteredProducts()
    End Sub


End Class

