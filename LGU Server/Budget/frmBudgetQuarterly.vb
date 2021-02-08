
Imports DevExpress.Skins
Imports DevExpress.Utils
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid


Public Class frmBudgetQuarterly

    Private Sub frmFundPeriod_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        LoadFund()
        LoadOffice()

    End Sub

    Public Sub LoadFund()
        LoadXgridLookupSearch("SELECT periodcode as code,fundcode,yeartrn, concat(yeartrn,'-',(select Description from tblfund where code=tblfundperiod.fundcode)) as 'Select'  from tblfundperiod where closed=0 order by yeartrn asc", "tblfundperiod", txtFund, gridFund, Me)
        XgridHideColumn({"code", "fundcode", "yeartrn"}, gridFund)
    End Sub
    Private Sub txtFund_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFund.EditValueChanged
        On Error Resume Next
        periodcode.Text = txtFund.Properties.View.GetFocusedRowCellValue("code").ToString()
        fundcode.Text = txtFund.Properties.View.GetFocusedRowCellValue("fundcode").ToString()
        yearcode.Text = txtFund.Properties.View.GetFocusedRowCellValue("yeartrn").ToString()
        LoadExpenditureItem()
    End Sub

    Public Sub LoadOffice()
        LoadXgridLookupSearch("SELECT officeid as code, officename as 'Select'  from tblcompoffice where deleted=0 order by officename asc", "tblcompoffice", txtOffice, gridoffice, Me)
        XgridHideColumn({"code"}, gridoffice)
    End Sub

    Private Sub txtOffice_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtOffice.EditValueChanged
        On Error Resume Next
        officeid.Text = txtOffice.Properties.View.GetFocusedRowCellValue("code").ToString()
        LoadExpenditureItem()
    End Sub


    Public Sub LoadExpenditureItem()
        If txtFund.Text = "" Or (txtOffice.Text = "" And CheckEdit1.Checked = False) Then Exit Sub
        LoadXgrid("SELECT a.itemcode, (select officename from tblcompoffice where officeid=b.officeid) as 'Office', b.classcode as 'Class', a.itemname as 'Account Title', ifnull(b.totalbudget,0) as 'Total Budget', " _
                  + " amount-(select ifnull(sum(amount),0) from tblrequisitionfund as a where b.periodcode=a.periodcode And b.itemcode=a.itemcode And b.officeid=a.officeid And b.quarter=a.quarter And a.cancelled=0)  as 'Current Quarter Balance', quarter1 as '1st Quarter', quarter2 as '2nd Quarter', quarter3 as '3rd Quarter', quarter4 as '4th Quarter', " _
                  + " (select ifnull(sum(amount),0) from tblrequisitionfund as a where b.periodcode=a.periodcode and b.itemcode=a.itemcode And b.officeid=a.officeid And a.cancelled=0 and a.pid not in (select pid from tbldisbursementdetails as dd inner join tbldisbursementvoucher as dv on dd.voucherno=dv.voucherno and dv.checkno<>'')) as 'NYDD', " _
                  + " (select ifnull(sum(amount),0) from tblrequisitionfund as a where b.periodcode=a.periodcode and b.itemcode=a.itemcode And b.officeid=a.officeid And a.cancelled=0 and a.pid in (select pid from tbldisbursementdetails as dd inner join tbldisbursementvoucher as dv on dd.voucherno=dv.voucherno and dv.checkno<>'' and dv.cleared=0)) as 'DD', " _
                  + " (select ifnull(sum(amount),0) from tblrequisitionfund as a where b.periodcode=a.periodcode and b.itemcode=a.itemcode And b.officeid=a.officeid And a.cancelled=0 and a.pid in (select pid from tbldisbursementdetails as dd inner join tbldisbursementvoucher as dv on dd.voucherno=dv.voucherno and dv.checkno<>'' and dv.cleared=1)) as 'CLEARED' " _
                  + " FROM `tblglitem` as a left join tblbudgetcomposition as b on a.itemcode=b.itemcode and b.periodcode='" & periodcode.Text & "' " & If(CheckEdit1.Checked = True, "", " and b.officeid='" & officeid.Text & "' ") & "  where b.totalbudget > 0 order by (select officename from tblcompoffice where officeid=b.officeid),a.itemname asc;", "tblglitem", Em, GridView1, Me)
        XgridHideColumn({"itemcode"}, GridView1)
        XgridColCurrency({"Total Budget", "Current Quarter Balance", "NYDD", "DD", "CLEARED", "1st Quarter", "2nd Quarter", "3rd Quarter", "4th Quarter"}, GridView1)
        'XgridColWidth({"Total Budget", "Current Quarter Balance", "1st Quarter", "2nd Quarter", "3rd Quarter", "4th Quarter"}, GridView1, 130)
        'XgridColWidth({"Account Title"}, GridView1, Em.Width - GridView1.Columns("Amount").Width - 20)
        XgridColAlign({"Class"}, GridView1, HorzAlignment.Center)
        'XgridDisableColumn({"Account Title", "Class", "itemcode", "Amount"}, GridView1, False)
        XgridGeneralSummaryCurrency({"Total Budget", "Current Quarter Balance", "NYDD", "DD", "CLEARED", "1st Quarter", "2nd Quarter", "3rd Quarter", "4th Quarter"}, GridView1)
        'For Each col In GridView1.Columns
        '    col.OptionsColumn.AllowSort = DefaultBoolean.False
        'Next
        GridView1.BestFitColumns()

        If countqry("tblbudgetquarter", "fundperiod='" & periodcode.Text & "'") > 0 Then
            cmdSaveButton.Text = "Quarterly Closing"
        Else
            cmdSaveButton.Text = "Generate Quarter"
        End If

    End Sub

    Private Sub gridview1_RowCellStyle(ByVal sender As Object, ByVal e As RowCellStyleEventArgs) Handles GridView1.RowCellStyle
        Dim View As GridView = sender
        If e.Column.Name = "colAccountTitle" Then
            e.Appearance.ForeColor = Color.Black
            e.Appearance.BackColor = Color.LightYellow
            e.Appearance.BackColor2 = Color.LightYellow
        End If

    End Sub

    Private Sub cmdSaveButton_Click(sender As Object, e As EventArgs) Handles cmdSaveButton.Click
        If txtFund.Text = "" Then
            XtraMessageBox.Show("Please select fund period!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtFund.Focus()
            Exit Sub
        End If
        frmBudgetQuarterActivate.cmdOk.Text = "Create quarterly budget for " & txtFund.Text
        frmBudgetQuarterActivate.fundcode.Text = fundcode.Text
        frmBudgetQuarterActivate.periodcode.Text = periodcode.Text
        frmBudgetQuarterActivate.ShowDialog(Me)
    End Sub

    Private Sub CheckEdit1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckEdit1.CheckedChanged
        If CheckEdit1.Checked = True Then
            txtOffice.Enabled = False
        Else
            txtOffice.Enabled = True
        End If
        LoadExpenditureItem()
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        LoadExpenditureItem()
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        ExportGridToExcel(txtFund.Text & If(CheckEdit1.Checked = True, "", " - " & txtOffice.Text), GridView1)
    End Sub
End Class