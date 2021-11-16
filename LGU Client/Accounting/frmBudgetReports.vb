Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System.Drawing
Imports System.IO
Imports System.Drawing.Printing
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Base

Public Class frmBudgetReports
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean

        Return ProcessCmdKey
    End Function

    Private Sub frmRequisitionList_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Dispose()
    End Sub

    Private Sub frmRequisitionList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = ico : ApplySystemTheme(ToolStrip1)
        LoadOffice()
        LoadFund()
        officeid.Text = compOfficeid
        txtOffice.EditValue = compOfficeid
        If globalSpecialApprover = True Or globalRootUser = True Then
            ckViewAllOffice.ReadOnly = False
            ckViewAllOffice.Checked = True
        Else
            ckViewAllOffice.ReadOnly = True
            ckViewAllOffice.Checked = False
        End If
        ViewList()
    End Sub


    Public Sub LoadOffice()
        LoadXgridLookupSearch("select officeid as code,officename as 'Select' from tblcompoffice where deleted=0 order by officename asc", "tblcompoffice", txtOffice, gridOffice)
        gridOffice.Columns("code").Visible = False
    End Sub

    Public Sub LoadFund()
        LoadXgridLookupSearch("SELECT periodcode as code,fundcode,yeartrn, concat(yeartrn,'-',(select Description from tblfund where code=tblfundperiod.fundcode)) as 'Select'  from tblfundperiod where closed=0 " & If(LCase(globalusername) = "root", "", " and fundcode in (select fundcode from tblfundfilter where filtered_id='" & globalAuthcode & "' and filtered_type='client')") & " order by yeartrn asc", "tblfundperiod", txtFund, gridFund)
        XgridHideColumn({"code", "fundcode", "yeartrn"}, gridFund)
    End Sub

    Private Sub txtFund_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFund.EditValueChanged
        On Error Resume Next
        periodcode.Text = txtFund.Properties.View.GetFocusedRowCellValue("code").ToString()
        yeartrn.Text = txtFund.Properties.View.GetFocusedRowCellValue("yeartrn").ToString()

    End Sub

    Private Sub txtOffice_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtOffice.EditValueChanged
        On Error Resume Next
        officeid.Text = txtOffice.Properties.View.GetFocusedRowCellValue("code").ToString()
        ViewList()
    End Sub
     
    Public Sub ViewList()
        If txtFund.Text = "" Then Exit Sub
        Dim strMonth As String = "" : Dim columnname As String = ""
        For i = 0 To 11
            columnname += CDate("1/1/" & yeartrn.Text).AddMonths(i).ToString("MMMM") & "-" & yeartrn.Text & ","
            strMonth += ", ifnull((select sum(amount) from tblrequisitionfund as b inner join tblrequisition as c on b.pid=c.pid where date_format(c.postingdate,'%Y-%m')='" & yeartrn.Text & "-" & CDate("1/1/" & yeartrn.Text).AddMonths(i).ToString("MM") & "' and b.periodcode=a.periodcode and b.itemcode=a.itemcode and b.officeid=a.officeid and b.cancelled=0),0) as '" & CDate("1/1/" & yeartrn.Text).AddMonths(i).ToString("MMMM") & "-" & yeartrn.Text & "' "
        Next

        LoadXgrid("select (select officename from tblcompoffice where officeid=a.officeid) as 'Department', " _
                  + " (select description from tblexpenditureclass where code=a.classcode) as 'Expenditure Class', " _
                  + " (select itemname from tblglitem where itemcode=a.itemcode) as 'Account Title', " _
                  + " totalbudget as 'Appropriation', " _
                  + " totalbudget - ifnull((select sum(amount) from tblrequisitionfund as b where b.periodcode=a.periodcode And b.itemcode=a.itemcode And b.officeid=a.officeid and b.cancelled=0),0) as 'Surplus' " _
                  + strMonth _
                  + " , ifnull((select sum(amount) from tblrequisitionfund as b where b.periodcode=a.periodcode And b.itemcode=a.itemcode And b.officeid=a.officeid and b.cancelled=0),0) as 'Total Posted' " _
                  + " from tblbudgetcomposition as a where totalbudget > 0 And periodcode='" & txtFund.EditValue & "' " & If(ckViewAllOffice.Checked, "", " and a.officeid='" & txtOffice.EditValue & "'"), "tblbudgetcomposition", Em, GridView1, Me)
        XgridColCurrency({"Appropriation", "Surplus", "Total Posted"}, GridView1)
        XgridGeneralSummaryCurrency({"Appropriation", "Surplus", "Total Posted"}, GridView1)
        For Each word In columnname.Split(New Char() {","c})
            XgridColCurrency({word}, GridView1)
            XgridGeneralSummaryCurrency({word}, GridView1)
        Next

        GridView1.BestFitColumns()
 
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
        DXExportGridToExcel(Me.Text, GridView1)
    End Sub

    Private Sub cmdFilterSearch_Click(sender As Object, e As EventArgs) Handles cmdFilterSearch.Click
        ViewList()
    End Sub
 
     
    Private Sub ckViewAllOffice_CheckedChanged(sender As Object, e As EventArgs) Handles ckViewAllOffice.CheckedChanged
        If ckViewAllOffice.Checked = True Then
            txtOffice.Enabled = False
            txtOffice.EditValue = Nothing
        Else
            txtOffice.Enabled = True
        End If
    End Sub
     
End Class