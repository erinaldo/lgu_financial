Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System.Drawing
Imports System.IO
Imports System.Drawing.Printing
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Base

Public Class frmCollectionReport
    ' The class that will do the printing process.
    Private BandgridView As GridView
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        Return ProcessCmdKey
    End Function

    Private Sub frmCollectionReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = ico
        ApplySystemTheme(ToolStrip3)
        LoadForm()
        ViewList()
    End Sub

    Public Sub LoadForm()
        LoadXgridLookupSearch("SELECT code,Description from tblaccountableform order by Description", "tblaccountableform", txtForm, gridForm)
        gridForm.Columns("code").Visible = False
    End Sub

    Private Sub cmdSaveButton_Click(sender As Object, e As EventArgs) Handles cmdSaveButton.Click
        ViewList()
    End Sub

    Public Sub ViewList()
        If CheckEdit1.Checked = True Then
            LoadXgrid("Select id,accountable, (select description from tblaccountableform where code=a.formcode) as 'Form', (select fullname from tblaccounts where accountid=a.accountable) as 'Accountable Person', SeriesFrom, SeriesTo, CurrentNo,  (select sum(credit) from tbltransactionentries where cancelled=0 and invrefcode=a.id and formcode=a.formcode and trnby=a.accountable and ornumber between a.seriesfrom and a.seriesto) as 'Total Collection'  from tblforminventory as a where officeid='" & compOfficeid & "' and accountable='" & globaluserid & "' and formcode='" & txtForm.EditValue & "' order by seriesfrom asc", "tblforminventory", Em, GridView1, Me)
            XgridHideColumn({"id", "accountable"}, GridView1)
            XgridColAlign({"Form Code", "SeriesFrom", "SeriesTo", "CurrentNo", "Date Updated", "Date Entry"}, GridView1, DevExpress.Utils.HorzAlignment.Center)
            XgridColCurrency({"Total Collection"}, GridView1)
            XgridGeneralSummaryCurrency({"Total Collection"}, GridView1)
        Else
            LoadXgrid("Select invrefcode as id,accountable, (select description from tblaccountableform where code=a.formcode) as 'Form', (select fullname from tblaccounts where accountid=a.accountable) as 'Accountable Person', Beginning, Ending, (select sum(credit) from tbltransactionentries where cancelled=0 and invrefcode=a.invrefcode and formcode=a.formcode and trnby=a.accountable and ornumber between a.beginning and a.ending) as 'Total Collection' from tblformreportlogs as a where formcode='" & txtForm.EditValue & "' and accountable='" & globaluserid & "' and returned=1", "tblformreportlogs", Em, GridView1, Me)
            XgridHideColumn({"id", "accountable"}, GridView1)
            XgridColAlign({"Beginning", "Ending", "Form Code"}, GridView1, DevExpress.Utils.HorzAlignment.Center)
            XgridColCurrency({"Total Collection"}, GridView1)
            XgridGeneralSummaryCurrency({"Total Collection"}, GridView1)
        End If

        DXgridColumnIndexing(Me.Name & If(CheckEdit1.Checked = True, "1", "2"), GridView1)
    End Sub


    Private Sub GridView1_DragObjectDrop(sender As Object, e As DevExpress.XtraGrid.Views.Base.DragObjectDropEventArgs) Handles GridView1.DragObjectDrop
        XgridColumnDropChanged(GridView1, Me.Name & If(CheckEdit1.Checked = True, "1", "2"))
    End Sub

    Private Sub GridView1_ColumnWidthChanged(sender As Object, e As ColumnEventArgs) Handles GridView1.ColumnWidthChanged
        XgridColumnWidthChanged(GridView1, Me.Name & If(CheckEdit1.Checked = True, "1", "2"))
    End Sub


    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub cmdExport_Click(sender As Object, e As EventArgs) Handles cmdExport.Click
        DXExportGridToExcel(Me.Text, GridView1)
    End Sub

    Private Sub cmdLocalData_Click(sender As Object, e As EventArgs) Handles cmdLocalData.Click
        ViewList()
    End Sub

    Private Sub AssignAccountableToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AssignAccountableToolStripMenuItem.Click
        If CheckEdit1.Checked = True Then
            frmCollectionDetails.invrefcode.Text = GridView1.GetFocusedRowCellValue("id").ToString
            frmCollectionDetails.accountable.Text = GridView1.GetFocusedRowCellValue("accountable").ToString
            frmCollectionDetails.seriesfrom.Text = GridView1.GetFocusedRowCellValue("SeriesFrom").ToString
            frmCollectionDetails.seriesto.Text = GridView1.GetFocusedRowCellValue("SeriesTo").ToString
            frmCollectionDetails.Text = GridView1.GetFocusedRowCellValue("Accountable Person").ToString & " (" & GridView1.GetFocusedRowCellValue("SeriesFrom").ToString & " - " & GridView1.GetFocusedRowCellValue("SeriesTo").ToString & ")"
        Else
            frmCollectionDetails.invrefcode.Text = GridView1.GetFocusedRowCellValue("id").ToString
            frmCollectionDetails.accountable.Text = GridView1.GetFocusedRowCellValue("accountable").ToString
            frmCollectionDetails.seriesfrom.Text = GridView1.GetFocusedRowCellValue("Beginning").ToString
            frmCollectionDetails.seriesto.Text = GridView1.GetFocusedRowCellValue("Ending").ToString
            frmCollectionDetails.Text = GridView1.GetFocusedRowCellValue("Accountable Person").ToString & " (" & GridView1.GetFocusedRowCellValue("Beginning").ToString & " - " & GridView1.GetFocusedRowCellValue("Ending").ToString & ")"
        End If
        If frmCollectionDetails.Visible = True Then
            frmCollectionDetails.Focus()
        Else
            frmCollectionDetails.Show(Me)
        End If
    End Sub

    Private Sub CheckEdit1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckEdit1.CheckedChanged
        ViewList()
    End Sub
End Class