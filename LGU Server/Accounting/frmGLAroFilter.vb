Imports DevExpress.XtraEditors
Imports MySql.Data.MySqlClient
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraReports.UI
Imports DevExpress.Skins
Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmGLAroFilter
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
        ShowUnfiltered()
        Showfiltered()
        PermissionAccess({cmdMoveLeft, cmdMoveRight}, globalAdminAccess)
    End Sub

    Public Sub ShowUnfiltered()
        LoadXgrid("select if(sl=1,itemcode,'') as itemcode,  if(sl=1,itemname,'') as itemname, " & GlobalGLitemname & " as 'Account Title', debitentry,if(a.sl=1,1,0) as sl from tblglitem as a where itemcode not in (select itemcode from tblglaroexemption)", "tblglitem", Em_unfiltered, gridUnFiltered, Me)
        gridUnFiltered.Columns("itemcode").Visible = False
        XgridColMemo({"Account Title"}, gridUnFiltered)
        XgridColWidth({"Account Title"}, gridUnFiltered, Em_unfiltered.Width)

        XgridHideColumn({"itemcode", "itemname", "debitentry", "sl"}, gridUnFiltered)
        RemoveHandler gridUnFiltered.RowCellStyle, New RowCellStyleEventHandler(AddressOf GridRowCellStyle)
        AddHandler gridUnFiltered.RowCellStyle, New RowCellStyleEventHandler(AddressOf GridRowCellStyle)
    End Sub
    Private Sub GridRowCellStyle(ByVal sender As Object, ByVal e As RowCellStyleEventArgs)
        Dim View As GridView = sender
        Dim sl As Boolean = CBool(View.GetRowCellDisplayText(e.RowHandle, View.Columns("sl")))
        If sl = False Then
            'e.Appearance.BackColor = Color.LightYellow
            'e.Appearance.ForeColor = Color.Black
            e.Appearance.Font = New Font(e.Appearance.Font.FontFamily, e.Appearance.Font.Size, FontStyle.Bold)
        End If
    End Sub

    Public Sub Showfiltered()
        LoadXgrid("select itemcode, itemname as 'Item Name' from tblglaroexemption order by itemcode asc", "tblglaroexemption", Em_filtered, GridView2, Me)
        GridView2.Columns("itemcode").Visible = False
        XgridColMemo({"Account Title"}, GridView2)
        XgridColWidth({"Account Title"}, GridView2, Em_filtered.Width)
    End Sub

    Private Sub BarLargeButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarLargeButtonItem2.ItemClick
        Me.Close()
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles cmdMoveRight.Click
        For I = 0 To gridUnFiltered.SelectedRowsCount - 1
            If gridUnFiltered.GetRowCellValue(gridUnFiltered.GetSelectedRows(I), "itemcode").ToString <> "" Then
                com.CommandText = "insert into tblglaroexemption set itemcode='" & gridUnFiltered.GetRowCellValue(gridUnFiltered.GetSelectedRows(I), "itemcode").ToString & "', itemname='" & rchar(gridUnFiltered.GetRowCellValue(gridUnFiltered.GetSelectedRows(I), "Account Title").ToString.Trim) & "'" : com.ExecuteNonQuery()
            End If
        Next
        ShowUnfiltered()
        Showfiltered()
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles cmdMoveLeft.Click
        For I = 0 To GridView2.SelectedRowsCount - 1
            com.CommandText = "delete from tblglaroexemption where itemcode='" & GridView2.GetRowCellValue(GridView2.GetSelectedRows(I), "itemcode").ToString & "'" : com.ExecuteNonQuery()
        Next
        ShowUnfiltered()
        Showfiltered()
    End Sub


End Class

