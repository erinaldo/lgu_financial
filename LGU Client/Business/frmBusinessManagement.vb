Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System.Drawing
Imports System.IO
Imports System.Drawing.Printing
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Base

Public Class frmBusinessManagement
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
                   + " companyname as 'Company Name', " _
                   + " Address, " _
                   + " date_format(dateregincorporation,'%Y-%m-%d') as 'Business Date', " _
                   + " (select description from tbldatapicked where id=a.placeincorporation) as 'Place of Incorporation', " _
                   + " ucase(kindoforganization) as 'Kind of Organization', " _
                   + " (select description from tbldatapicked where id=a.businessnature) as 'Nature of Business', " _
                   + " contactperson as 'Contact Person', " _
                   + " contactnumber as 'Contact Number', " _
                   + " Actived, " _
                   + " date_format(datetrn,'%Y-%m-%d %r') as 'Date Added', " _
                   + " (select fullname from tblaccounts where accountid=a.trnby) as 'Added By' " _
                   + " from tblbusiness as a where (companyname like '%" & rchar(txtSearchBar.Text) & "%' or  " _
                   + " (select description from tbldatapicked where id=a.placeincorporation) like '%" & rchar(txtSearchBar.Text) & "%' or " _
                   + " (select description from tbldatapicked where id=a.kindoforganization) like '%" & rchar(txtSearchBar.Text) & "%' or " _
                   + " (select description from tbldatapicked where id=a.businessnature) like '%" & rchar(txtSearchBar.Text) & "%' or " _
                   + " contactperson like '%" & rchar(txtSearchBar.Text) & "%') and deleted=0 ", "tblbusiness", Em, GridView1, Me)

 
        XgridColAlign({"Entry Code", "Business Date", "Place of Incorporation", "Kind of Organization", "Nature of Business", "Contact Number", "Added By", "Date Added"}, GridView1, DevExpress.Utils.HorzAlignment.Center)

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
        DXPrintDatagridview(Me.Text & "<br/><strong>" & Me.Text & "</strong>", "Business Report", "Report as of from " & CDate(Now).ToString("MMMM, dd yyyy"), GridView1, Me)
    End Sub

    Private Sub cmdNew_Click(sender As Object, e As EventArgs) Handles cmdNewProperty.Click
        If globalAllowAdd = False Then
            XtraMessageBox.Show("Your access not allowed to add!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        If frmBusinessInfo.Visible = False Then
            frmBusinessInfo.Show(Me)
        Else
            frmBusinessInfo.WindowState = FormWindowState.Normal
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
                com.CommandText = "UPDATE tblbusiness set deleted=1,deletedby='" & globaluserid & "',datedeleted=current_timestamp where id='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "Entry Code") & "' " : com.ExecuteNonQuery()
            Next
            ViewList()
        End If
    End Sub

    Private Sub cmdView_Click(sender As Object, e As EventArgs) Handles cmdView.Click
        frmBusinessInfo.mode.Text = ""
        frmBusinessInfo.id.Text = GridView1.GetFocusedRowCellValue("Entry Code").ToString
        frmBusinessInfo.mode.Text = "edit"
        If frmBusinessInfo.Visible = False Then
            frmBusinessInfo.Show(Me)
        Else
            frmBusinessInfo.WindowState = FormWindowState.Normal
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