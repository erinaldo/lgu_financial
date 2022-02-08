Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System.Drawing
Imports System.IO
Imports System.Drawing.Printing
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Base

Public Class frmRealProperty
    ' The class that will do the printing process.
    Private BandgridView As GridView
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean

        Return ProcessCmdKey
    End Function

    Private Sub frmAccountableForms_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = ico
        ApplySystemTheme(ToolStrip1)
        ViewList()

    End Sub

    Private Sub txtSearchBar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSearchBar.KeyPress
        If e.KeyChar() = Chr(13) Then
            If txtSearchBar.Text = "" Then Exit Sub
            ViewList()
        End If

    End Sub

    Public Sub ViewList()
        LoadXgrid("Select  id as 'Entry Code', " _
                   + " (select fullname from tbltaxpayerprofile where cifid=a.cifid) as 'Tax Payer Name', " _
                   + " certificateno as 'Certificate No.', " _
                   + " serialno as 'Serial No.', " _
                   + " lotaddress as 'Lot Address', " _
                   + " date_format(dateregistered,'%Y-%m-%d') as 'Date Registered', " _
                   + " date_format(dategranted,'%Y-%m-%d') as 'Date Granted', " _
                   + " bookno as 'Book No.', " _
                   + " pageno as 'Page No.', " _
                   + " (select description from tbldatapicked where id=a.kindofproperty) as 'Kind of Property', " _
                   + " (select description from tbldatapicked where id=a.classification) as 'Clasification', " _
                   + " (select description from tbldatapicked where id=a.actualuse) as 'Actual Use', " _
                   + " totalarea as 'Total Area', " _
                   + " lotblockno as 'Lot Block No.', " _
                   + " (select marketvalue from tbltaxdeclaration where propertyno=a.certificateno order by dateassessed desc limit 1) as 'Market Value', " _
                   + " (select assessedvalue from tbltaxdeclaration where propertyno=a.certificateno order by dateassessed desc limit 1) as 'Assessed Value', " _
                   + " (select date_format(dateassessed,'%Y-%m-%d') from tbltaxdeclaration where propertyno=a.certificateno order by dateassessed limit 1) as 'Date Assessed', " _
                   + " (select sum(totaltaxdue) from tbltaxdeclaration where propertyno=a.certificateno and paid=0 order by dateassessed limit 1) as 'Total Tax Due', " _
                   + " date_format(lastdateassessed,'%Y-%m-%d') as 'Last Date Assessed', " _
                   + " orgcertificateno as 'Original Certification No.', " _
                   + " orgcaseno as 'Original Case No.', " _
                   + " date_format(orgdateregistered,'%Y-%m-%d') as 'Original Date Registered', " _
                   + " orgregistrydeeds as 'Original Registry of Deeds', " _
                   + " orgvolumeno as 'Original Volume No.', " _
                   + " orgownername as 'Original Owner Name', " _
                   + " orgrecordno as 'Original Record No.', " _
                   + " orgdecreeno as 'Original Decree No.', " _
                   + " orgpageno as 'Original Page No.', " _
                   + " (select fullname from tblaccounts where accountid=a.trnby) as 'Entry By' , " _
                   + " date_format(datetrn,'%Y-%m-%d %r') as 'Date Entry', " _
                   + " (select fullname from tblaccounts where accountid=a.updateby) as 'Updated By' , " _
                   + " date_format(dateupdated,'%Y-%m-%d %r') as 'Date Updated' " _
                   + " from tblrealproperty as a where ((select fullname from tbltaxpayerprofile where cifid=a.cifid) like '%" & rchar(txtSearchBar.Text) & "%' or certificateno like '%" & rchar(txtSearchBar.Text) & "%') and deleted=0 order by dateregistered desc limit 100", "tblrealproperty", Em, GridView1, Me)

        XgridColCurrency({"Assessed Value", "Market Value", "Total Tax Due"}, GridView1)
        XgridColCurrencyDecimalCount({"Total Area"}, 0, GridView1)
        XgridColAlign({"Entry Code", "Certificate No.", "Serial No.", "Date Registered", "Date Granted", "Book No.", "Page No.", "Kind of Property", "Clasification", "Actual Use", "Last Date Assessed",
                                "Date Assessed", "Lot Block No.", "Original Certification No.", "Original Case No.", "Original Date Registered", "Original Volume No.", "Original Record No.",
                                "Original Page No.", "Original Decree No.", "Date Entry", "Date Updated"}, GridView1, DevExpress.Utils.HorzAlignment.Center)

        XgridGeneralSummaryCurrency({"Market Value", "Total Tax Due"}, GridView1)


        DXgridColumnIndexing(Me.Name, GridView1)
        SaveFilterColumn(GridView1, Me.Text)
    End Sub

    Private Sub GridView1_DragObjectDrop(sender As Object, e As DevExpress.XtraGrid.Views.Base.DragObjectDropEventArgs) Handles GridView1.DragObjectDrop
        XgridColumnDropChanged(GridView1, Me.Name)
    End Sub

    Private Sub GridView1_ColumnWidthChanged(sender As Object, e As ColumnEventArgs) Handles GridView1.ColumnWidthChanged
        XgridColumnWidthChanged(GridView1, Me.Name)
    End Sub

    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles cmdPrint.Click
        DXPrintDatagridview(Me.Text & "<br/><strong>" & Me.Text & "</strong>", "Real Property", "Report as of from " & CDate(Now).ToString("MMMM, dd yyyy"), GridView1, Me)
    End Sub

    Private Sub cmdNew_Click(sender As Object, e As EventArgs) Handles cmdNewProperty.Click
        If globalAllowAdd = False Then
            XtraMessageBox.Show("Your access not allowed to add!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        If frmRealPropertyInfo.Visible = False Then
            frmRealPropertyInfo.Show(Me)
        Else
            frmRealPropertyInfo.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub cmdLocalData_Click(sender As Object, e As EventArgs) Handles cmdLocalData.Click
        ViewList()
    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        If globalAllowDelete = False Then
            XtraMessageBox.Show("Your access not allowed to delete!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        If XtraMessageBox.Show("Are you sure you want to permanently remove selected item? ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            Dim I As Integer = 0
            For I = 0 To GridView1.SelectedRowsCount - 1
                com.CommandText = "delete from tblrealproperty where id='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "Entry Code") & "' " : com.ExecuteNonQuery()
            Next
            ViewList()
        End If
    End Sub

    Private Sub cmdView_Click(sender As Object, e As EventArgs) Handles cmdView.Click
        frmRealPropertyInfo.mode.Text = ""
        frmRealPropertyInfo.id.Text = GridView1.GetFocusedRowCellValue("Entry Code").ToString
        frmRealPropertyInfo.mode.Text = "edit"
        If frmRealPropertyInfo.Visible = False Then
            frmRealPropertyInfo.Show(Me)
        Else
            frmRealPropertyInfo.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub CmdColumnSettings_Click(sender As Object, e As EventArgs) Handles cmdColumnSettings.Click
        Dim colname As String = ""
        For I = 0 To GridView1.Columns.Count - 1
            colname += GridView1.Columns(I).FieldName & ","
        Next
        frmColumnFilter.txtColumn.Text = colname.Remove(colname.Count - 1, 1)
        frmColumnFilter.GetFilterInfo(GridView1, Me.Text)
        frmColumnFilter.ShowDialog(Me)
    End Sub

End Class