Imports DevExpress.XtraEditors
Imports MySql.Data.MySqlClient
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraReports.UI
Imports DevExpress.Skins
Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmErrorCorrect
    Private Sub frmReportEntries_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
 
    Public Sub LoadReport()
        LoadXgrid("Select * from tbltransactionentries as a where " _
                  + " postingdate like '%" & rchar(txtRangeFrom.Text) & "%' or " _
                  + " jevno like '%" & rchar(txtRangeFrom.Text) & "%' or " _
                  + " ornumber like '%" & rchar(txtRangeFrom.Text) & "%' or " _
                  + " explaination like '%" & rchar(txtRangeFrom.Text) & "%' or " _
                  + " (select officename from tblcompoffice where officeid = a.officeid limit 1) like '%" & rchar(txtRangeFrom.Text) & "%' or " _
                  + " (select fullname from tbltaxpayerprofile where cifid = a.cifid limit 1) like '%" & rchar(txtRangeFrom.Text) & "%' or " _
                  + " (select fullname from tblaccounts where accountid = a.trnby limit 1) like '%" & rchar(txtRangeFrom.Text) & "%' " _
                  + " ", "tbltransactionentries", Em, GridView1, Me)
      
        GridView1.BestFitColumns()

    End Sub

    Private Sub gridview1_RowCellStyle(ByVal sender As Object, ByVal e As RowCellStyleEventArgs) Handles GridView1.RowCellStyle
        Dim View As GridView = sender
        If GridView1.RowCount > 0 Then
            Dim status As Boolean = CBool(GridView1.GetRowCellValue(e.RowHandle, "cancelled").ToString)
            If status = True Then
                e.Appearance.ForeColor = Color.Red
                e.Appearance.Font = New Font(gen_fontfamily, gen_FontSize, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, (CByte(204)))
            End If
        End If

    End Sub
    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        ExportGridToExcel(Me.Text, GridView1)
    End Sub

    Private Sub BarLargeButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarLargeButtonItem2.ItemClick
        Me.Close()
    End Sub

    Private Sub txtRangeFrom_EditValueChanged(sender As Object, e As EventArgs) Handles txtRangeFrom.EditValueChanged

    End Sub

    Private Sub txtRangeFrom_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRangeFrom.KeyPress
        If e.KeyChar = Chr(13) Then
            LoadReport()
        End If
    End Sub
End Class

