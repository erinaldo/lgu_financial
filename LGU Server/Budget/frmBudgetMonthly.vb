
Imports DevExpress.Skins
Imports DevExpress.Utils
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid


Public Class frmBudgetMonthly

    Private Sub frmFundPeriod_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        LoadFund()
        LoadOffice()
        PermissionAccess({cmdSaveButton}, globalAdminAccess)
        PermissionAccess({cmdNewFund}, globalAllowAdd)
        PermissionAccess({cmdTransfer}, globalAllowEdit)

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
        LoadXgrid("select *, COALESCE(NULLIF(((ifnull(January,0)+ifnull(February,0)+ifnull(March,0)+ifnull(April,0)+ifnull(May,0)+ifnull(June,0)+ifnull(July,0)+ifnull(August,0)+ifnull(September,0)+ifnull(October,0)+ifnull(November,0)+ifnull(December,0)+ifnull(nydd,0)+ifnull(dd,0)+ifnull(cleared,0)+`Current Month Balance`)-Amount)-`Total Budget`, 0.00), null) as VARIANCE " _
                  + " from (SELECT b.id, a.itemcode, (select officename from tblcompoffice where officeid=b.officeid) as 'Office', b.classcode as 'Class', a.itemname as 'Account Title', ifnull(b.totalbudget,0) as 'Total Budget', " _
                  + " amount-(select ifnull(sum(amount),0) from tblrequisitionfund as a where b.periodcode=a.periodcode And b.itemcode=a.itemcode And b.officeid=a.officeid And b.monthcode=a.monthcode And a.cancelled=0)  as 'Current Month Balance', " _
                  + " Amount, " _
                  + " if(January=0, null, January) As January, " _
                  + " if(February=0, null, February) As February, " _
                  + " if(March=0, null, March) As March, " _
                  + " if(April=0, null, April) As April, " _
                  + " if(May=0, null, May) As May, " _
                  + " if(June=0, null, June) As June, " _
                  + " if(July=0, null, July) As July, " _
                  + " if(August=0, null, August) As August, " _
                  + " if(September=0, null, September) As September, " _
                  + " if(October=0, null, October) As October, " _
                  + " if(November=0, null, November) As November, " _
                  + " if(December=0, null, December) As December, " _
                  + " COALESCE(NULLIF((Select ifnull(sum(amount),0) from tblrequisitionfund As a where b.periodcode= a.periodcode And b.itemcode = a.itemcode And b.officeid = a.officeid And a.cancelled = 0 And (a.pid Not in (select pid from tbldisbursementvoucher as dv where dv.cancelled=0) Or a.pid in (select pid from tbldisbursementvoucher as dv where dv.checkissued=0 And dv.cancelled=0))), 0 ), null) as 'NYDD', " _
                  + " COALESCE(NULLIF((select ifnull(sum(amount),0) from tblrequisitionfund as a where b.periodcode=a.periodcode and b.itemcode=a.itemcode And b.officeid=a.officeid And a.cancelled=0 and a.pid in (select pid from tbldisbursementvoucher as dv where dv.checkissued=1 and dv.cleared=0 and dv.cancelled=0)), 0), null) as 'DD', " _
                  + " COALESCE(NULLIF((select ifnull(sum(amount),0) from tblrequisitionfund as a where b.periodcode=a.periodcode and b.itemcode=a.itemcode And b.officeid=a.officeid And a.cancelled=0 and a.pid in (select pid from tbldisbursementvoucher as dv where dv.checkissued=1 and dv.cleared=1 and dv.cancelled=0)), 0), null) as 'CLEARED' " _
                  + " FROM `tblglitem` as a left join tblbudgetcomposition as b on a.itemcode=b.itemcode and b.periodcode='" & periodcode.Text & "' " & If(CheckEdit1.Checked = True, "", " and b.officeid='" & officeid.Text & "' ") & "  where b.totalbudget > 0) as x order by office,`Account Title` asc;", "tblglitem", Em, GridView1, Me)
        XgridHideColumn({"id", "itemcode"}, GridView1)
        XgridColCurrency({"Total Budget", "Current Month Balance", "NYDD", "DD", "CLEARED", "VARIANCE", "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"}, GridView1)
        XgridGeneralSummaryCurrency({"Total Budget", "Current Month Balance", "NYDD", "DD", "CLEARED", "VARIANCE", "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"}, GridView1)

        XgridHideColumn({"Amount"}, GridView1)
        'XgridColWidth({"Total Budget", "Current Quarter Balance", "1st Quarter", "2nd Quarter", "3rd Quarter", "4th Quarter"}, GridView1, 130)
        GridView1.BestFitColumns()
        XgridColWidth({"Account Title"}, GridView1, 300)
        XgridColAlign({"Class"}, GridView1, HorzAlignment.Center)
        'XgridDisableColumn({"Account Title", "Class", "itemcode", "Amount"}, GridView1, False)

        'For Each col In GridView1.Columns
        '    col.OptionsColumn.AllowSort = DefaultBoolean.False
        'Next


        If countqry("tblbudgetmonthly", "fundperiod='" & periodcode.Text & "'") > 0 Then
            cmdSaveButton.Text = "Monthly Closing"
        Else
            cmdSaveButton.Text = "Generate Monthly Budget"
        End If

    End Sub

    Private Sub gridview1_RowCellStyle(ByVal sender As Object, ByVal e As RowCellStyleEventArgs) Handles GridView1.RowCellStyle
        Dim View As GridView = sender
        If e.Column.Name = "colAccountTitle" Then
            e.Appearance.ForeColor = Color.Black
            e.Appearance.BackColor = Color.LightYellow
            e.Appearance.BackColor2 = Color.LightYellow
        ElseIf e.Column.Name = "colVARIANCE" Then
            Dim variance As Double = Val(View.GetRowCellDisplayText(e.RowHandle, View.Columns("VARIANCE")))
            If variance <> 0 Then
                e.Appearance.ForeColor = Color.White
                e.Appearance.BackColor = Color.Red
                e.Appearance.BackColor2 = Color.Red
            End If

        End If

    End Sub

    Private Sub cmdSaveButton_Click(sender As Object, e As EventArgs) Handles cmdSaveButton.Click
        If txtFund.Text = "" Then
            XtraMessageBox.Show("Please select fund period!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtFund.Focus()
            Exit Sub
        End If
        If frmBudgetMonthlyClosing.Visible Then
            frmBudgetMonthlyClosing.Focus()
        Else
            frmBudgetMonthlyClosing.cmdOk.Text = "Create monthly budget for " & txtFund.Text
            frmBudgetMonthlyClosing.fundcode.Text = fundcode.Text
            frmBudgetMonthlyClosing.periodcode.Text = periodcode.Text
            frmBudgetMonthlyClosing.Show(Me)
        End If
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

    Private Sub EditLineToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles cmdViewItem.Click
        If txtFund.Text = "" Then
            XtraMessageBox.Show("Please select fund period!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtFund.Focus()
            Exit Sub
        End If
        frmBudgetEditLine.id.Text = GridView1.GetFocusedRowCellValue("id").ToString()
        If frmBudgetEditLine.Visible Then
            frmBudgetEditLine.Focus()
        Else
            frmBudgetEditLine.Show(Me)
        End If
    End Sub

    Private Sub TranferSelectedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles cmdTransfer.Click
        If txtFund.Text = "" Then
            XtraMessageBox.Show("Please select fund period!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtFund.Focus()
            Exit Sub
        End If
        frmBudgetTransfer.from_id.Text = GridView1.GetFocusedRowCellValue("id").ToString()
        If frmBudgetTransfer.Visible Then
            frmBudgetTransfer.Focus()
        Else
            frmBudgetTransfer.Show(Me)
        End If
    End Sub

    Private Sub NewFundToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles cmdNewFund.Click
        If txtFund.Text = "" Then
            XtraMessageBox.Show("Please select fund period!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtFund.Focus()
            Exit Sub
        End If

        frmBudgetNew.periodcode.Text = periodcode.Text
        frmBudgetNew.fundcode.Text = fundcode.Text
        frmBudgetNew.yearcode.Text = yearcode.Text
        If frmBudgetNew.Visible Then
            frmBudgetNew.Focus()
        Else
            frmBudgetNew.Show(Me)
        End If
    End Sub
End Class