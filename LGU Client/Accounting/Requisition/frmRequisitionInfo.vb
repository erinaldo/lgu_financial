Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo

Public Class frmRequisitionInfo
    Private BandgridView As GridView
    Private ReadOnlyTrn As Boolean = False
    Private HeadOfficeApprover As Boolean = False
    Private DirectApproved As Boolean = False
    Private EnablePR As Boolean = False
    Private EnablePO As Boolean = False
    Private EnableVoucher As Boolean = True
    Private RequiredFund As Boolean = False
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmRequisitionInfo_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub frmRequisitionInfo_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If countqry("tmprequisitionfund", "pid='" & pid.Text & "'") > 0 Then
            If countqry("tblrequisition", "pid='" & pid.Text & "'") = 0 Then
                If XtraMessageBox.Show("Are you sure you want to close current request? Closing unsaved request will cancelling all current transaction." & Environment.NewLine & "You may save it as draft for you able to edit this transaction later.", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
                    com.CommandText = "DELETE FROM tmprequisitionfund where pid='" & pid.Text & "'" : com.ExecuteNonQuery()
                    com.CommandText = "DELETE FROM tblrequisitionfiles where pid='" & pid.Text & "'" : com.ExecuteNonQuery()
                Else
                    e.Cancel = True
                End If
            End If
        End If
    End Sub

    Private Sub frmRequisitionInfo_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        txtSourceAmount.EditValue = qrysingledata("total", "sum(amount) as total", "tmprequisitionfund where pid='" & pid.Text & "'")
    End Sub

    Private Sub ffrmRequisitionInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico
        ApplySystemTheme(ToolStrip1)

        LoadOffice()
        LoadRequestBy()
        LoadSupplier()

        officeid.Text = compOfficeid
        txtOffice.EditValue = compOfficeid


        If mode.Text = "edit" Then
            ShowRequisitionInfo()
            LoadRequestType()
            CreateFundTable()
            LoadRequisitionFund()
            LoadSource()

        ElseIf mode.Text = "duplicate" Then
            ShowRequisitionInfo()
            LoadRequestType()
            CreateFundTable()
            LoadRequisitionFund()
            DuplicateRequest()

        Else
            pid.Text = GetTransactionSeries("requisition")
            LoadRequestType()
            CreateFundTable()
            LoadRequisitionFund()
            ReadOnlyForm(False, mode.Text)
            txtStatus.Text = "NEW REQUEST"
        End If

        LoadFiles()
        ApprovingHistory()
        LoadApproverDeatils()


    End Sub
    Public Sub CreateFundTable()
        com.CommandText = "CREATE TEMPORARY TABLE IF NOT EXISTS `tmprequisitionfund` (  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,  `pid` varchar(45) NOT NULL DEFAULT '',  `officeid` varchar(45) NOT NULL DEFAULT '',  `periodcode` varchar(45) NOT NULL DEFAULT '',  `requestno` varchar(45) NOT NULL DEFAULT '',  `monthcode` varchar(2) NOT NULL DEFAULT '',  `classcode` varchar(45) NOT NULL DEFAULT '',  `itemcode` varchar(45) NOT NULL DEFAULT '',  `prevbalance` double NOT NULL DEFAULT '0',  `amount` double NOT NULL DEFAULT '0',  `newbalance` double NOT NULL DEFAULT '0',  `cancelled` tinyint(1) NOT NULL DEFAULT '0',  PRIMARY KEY (`id`)) ENGINE=InnoDB AUTO_INCREMENT=0 DEFAULT CHARSET=utf8;" : com.ExecuteNonQuery()
        com.CommandText = "DELETE FROM tmprequisitionfund where pid='" & pid.Text & "'" : com.ExecuteNonQuery()
        com.CommandText = "INSERT INTO tmprequisitionfund select * from tblrequisitionfund where pid='" & pid.Text & "'" : com.ExecuteNonQuery()
    End Sub

    Public Sub ReadOnlyForm(ByVal readonlyForm As Boolean, ByVal mode As String)
        ReadOnlyTrn = readonlyForm
        txtRequestType.ReadOnly = readonlyForm

        txtRequestby.ReadOnly = readonlyForm
        txtFund.ReadOnly = readonlyForm
        txtPurpose.ReadOnly = readonlyForm
        txtPriority.ReadOnly = readonlyForm
        txtSupplier.ReadOnly = readonlyForm
        txtAddSupplier.Enabled = If(readonlyForm, False, True)

        If globalSpecialApprover = True Then
            txtOffice.ReadOnly = readonlyForm
        Else
            txtOffice.ReadOnly = True
        End If

        If readonlyForm = True Then
            Em.ContextMenuStrip = Nothing
            cmdModifyAttachment.Visible = False
            cmdRemoveAttachment.Visible = False
            cmdAddParticularItem.Visible = False
        Else
            Em.ContextMenuStrip = ContextMenuStrip1
            cmdModifyAttachment.Visible = True
            cmdRemoveAttachment.Visible = True
            cmdAddParticularItem.Visible = True
        End If

        If mode = "edit" Then
            'cmdSaveAsDraft.Visible = True
            'linedraft.Visible = True
            cmdForApproval.Visible = True
            lineapproval.Visible = True

        ElseIf mode = "approval" Or mode = "cancelled" Then
            'cmdSaveAsDraft.Visible = False
            'linedraft.Visible = False
            cmdForApproval.Visible = False
            lineapproval.Visible = False

        ElseIf mode = "view" Or mode = "approved" Then
            'cmdSaveAsDraft.Visible = False
            'linedraft.Visible = False
            cmdForApproval.Visible = False
            lineapproval.Visible = False

            If DirectApproved Then
                cmdPrintObligation.Visible = False
                linePrintObligation.Visible = False
            Else
                cmdPrintObligation.Visible = True
                linePrintObligation.Visible = True
            End If

            ShowReportTemplate()
        Else
            'cmdSaveAsDraft.Visible = True
            'linedraft.Visible = True
            cmdForApproval.Visible = True
            lineapproval.Visible = True
            cmdPrintObligation.Visible = False
            linePrintObligation.Visible = False
        End If
    End Sub

    Public Sub ShowReportTemplate()
        If countqry("tblfund", "code='" & fundcode.Text & "' and template='FURS'") > 0 Then
            cmdPrintObligation.Text = "Print FURS"
        ElseIf countqry("tblfund", "code='" & fundcode.Text & "' and template='CAFOA'") > 0 Then
            cmdPrintObligation.Text = "Print CAFOA"
        Else
            cmdPrintObligation.Visible = False
        End If
    End Sub

    Public Sub LoadApproverDeatils()
        If HeadOfficeApprover = True Then
            CurrentLevel.Text = "0"
            CurrentApprover.Text = ""
            ckFinalApprover.Checked = False
        Else
            com.CommandText = "select * from tblapprovingprocess where apptype='requisition-approving-process' and trncode='" & requesttype.Text & "' and fundcode='" & fundcode.Text & "' and applevel=ifnull((select applevel+1 from tblapprovalhistory where apptype='requisition' and trncode='" & requesttype.Text & "' and fundcode='" & fundcode.Text & "' and mainreference='" & pid.Text & "' and applevel > 0 order by applevel desc limit 1),1)" : rst = com.ExecuteReader
            While rst.Read
                CurrentLevel.Text = rst("applevel").ToString
                CurrentApprover.Text = rst("officeid").ToString
                ckFinalApprover.Checked = CBool(rst("finalapp"))
            End While
            rst.Close()
        End If
        com.CommandText = "select * from tblapprovingprocess where apptype='requisition-approving-process' and trncode='" & requesttype.Text & "' and fundcode='" & fundcode.Text & "'  and applevel=" & Val(CurrentLevel.Text) + 1 & "" : rst = com.ExecuteReader
        While rst.Read
            NextApprover.Text = rst("officeid").ToString
        End While
        rst.Close()

    End Sub

    Public Sub LoadRequestType()
        LoadXgridLookupSearch("select code,description as 'Select',enablepr,enablepo from tblrequisitiontype " & If(LCase(globalusername) = "root", "", " where (code in (select requestcode from tblrequisitionfilter where officeid='" & officeid.Text & "') or code='" & requesttype.Text & "')") & " order by description asc", "tblrequisitiontype", txtRequestType, gridRequestType)
        XgridHideColumn({"code", "enablepr", "enablepo"}, gridRequestType)
    End Sub

    Private Sub txtRequestType_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRequestType.EditValueChanged
        On Error Resume Next
        requesttype.Text = txtRequestType.Properties.View.GetFocusedRowCellValue("code").ToString()
        CheckOptionalSettings()
        LoadApproverDeatils()
    End Sub
    Public Sub CheckOptionalSettings()
        com.CommandText = "select * from tblrequisitiontype where code='" & txtRequestType.EditValue & "'" : rst = com.ExecuteReader
        While rst.Read
            DirectApproved = CBool(rst("directapproved").ToString())
            EnablePR = CBool(rst("enablepr").ToString())
            EnablePO = CBool(rst("enablepo").ToString())
            EnableVoucher = CBool(rst("enablevoucher").ToString())
            RequiredFund = CBool(rst("requiredfund").ToString())
        End While
        rst.Close()
        If DirectApproved Then
            mode.Text = "direct"
            cmdForApproval.Text = "Proceed for DV Preparation"
        Else
            cmdForApproval.Text = "Submit for Approval"
        End If
        If EnableVoucher Then
            txtSupplier.Enabled = True
            If txtSupplier.ReadOnly Then
                txtAddSupplier.Enabled = False
            Else
                txtAddSupplier.Enabled = True
            End If
            LoadSupplier()
        Else
            txtSupplier.Enabled = False
            txtAddSupplier.Enabled = False
            txtSupplier.Properties.DataSource = Nothing
        End If
    End Sub

    Public Sub LoadOffice()
        LoadXgridLookupSearch("select officeid as code,officename as 'Select' from tblcompoffice where deleted = 0  order by officename asc", "tblcompoffice", txtOffice, gridOffice)
        gridOffice.Columns("code").Visible = False
    End Sub

    Private Sub txtOffice_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtOffice.EditValueChanged
        On Error Resume Next
        officeid.Text = txtOffice.Properties.View.GetFocusedRowCellValue("code").ToString()
        LoadRequestBy()
    End Sub

    Public Sub LoadRequestBy()
        If txtOffice.Text = "" Then Exit Sub
        LoadXgridLookupSearch("select accountid as code, fullname as 'Select' from tblaccounts where (officeid='" & officeid.Text & "' or accountid='" & requestby.Text & "')  order by fullname asc", "tblaccounts", txtRequestby, gridrequestby)
        gridrequestby.Columns("code").Visible = False
    End Sub

    Private Sub txtRequestby_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRequestby.EditValueChanged
        On Error Resume Next
        requestby.Text = txtRequestby.Properties.View.GetFocusedRowCellValue("code").ToString()
    End Sub

    Public Sub LoadSupplier()
        LoadXgridLookupSearch("select supplierid as code,suppliername as 'Select', completeaddress, tin from tblsupplier where deleted=0 order by suppliername asc", "tblsupplier", txtSupplier, gridSupplier)
        gridSupplier.Columns("code").Visible = False
        XgridHideColumn({"code", "completeaddress", "tin"}, gridSupplier)
    End Sub
    Private Sub HyperlinkLabelControl1_Click(sender As Object, e As EventArgs) Handles txtAddSupplier.Click
        frmSupplierInfo.ShowDialog(Me)
        LoadSupplier()
    End Sub

    Public Sub LoadRequisitionFund()
        LoadXgridLookupSearch("Select periodcode As code,fundcode,yeartrn, concat(yeartrn,'-',(select Description from tblfund where code=tblfundperiod.fundcode)) as 'Select'  from tblfundperiod where closed=0 " & If(LCase(globalusername) = "root", "", " and fundcode in (select fundcode from tblfundfilter where filtered_id='" & officeid.Text & "' and filtered_type='office')") & "  order by yeartrn asc", "tblfundperiod", txtFund, gridFund)
        XgridHideColumn({"code", "fundcode", "yeartrn"}, gridFund)
    End Sub
    Private Sub txtFund_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFund.EditValueChanged
        On Error Resume Next
        periodcode.Text = txtFund.Properties.View.GetFocusedRowCellValue("code").ToString()
        fundcode.Text = txtFund.Properties.View.GetFocusedRowCellValue("fundcode").ToString()
        yearcode.Text = txtFund.Properties.View.GetFocusedRowCellValue("yeartrn").ToString()
    End Sub

    Public Sub LoadSource()
        LoadXgrid("select id,classcode as 'Class', date_format(concat(date_format(current_date,'%Y'),'-',monthcode,'-1'),'%M') as 'Month', itemcode as 'Item Code', (select itemname from tblglitem where itemcode=a.itemcode) as 'Item Name', Amount from tmprequisitionfund as a where pid='" & pid.Text & "'", "tmprequisitionfund", Em, GridView1, Me)
        XgridHideColumn({"id"}, GridView1)
        XgridColAlign({"Item Code", "Class", "Month"}, GridView1, DevExpress.Utils.HorzAlignment.Center)
        XgridColCurrency({"Amount"}, GridView1)
        XgridGeneralSummaryCurrency({"Amount"}, GridView1)
        GridView1.BestFitColumns()
        If GridView1.RowCount > 0 Then
            txtRequestType.ReadOnly = True
            txtOffice.ReadOnly = True
            txtFund.ReadOnly = True
        Else
            txtRequestType.ReadOnly = False
            txtOffice.ReadOnly = False
            txtFund.ReadOnly = False
        End If
    End Sub


    Public Function SecurityCheck() As Boolean
        If txtRequestType.Text = "" Then
            XtraMessageBox.Show("Please select request type!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtRequestType.Focus()
            Return False
        ElseIf countqry("tblapprovingprocess", "trncode='" & txtRequestType.EditValue & "' and finalapp=1") = 0 And DirectApproved = False Then
            XtraMessageBox.Show("There's no configured approving for this type of request! Please contact accounting department", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtRequestType.Focus()
            Return False
        ElseIf txtRequestby.Text = "" Then
            XtraMessageBox.Show("Please select request by!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtRequestby.Focus()
            Return False
        ElseIf EnableVoucher = True And txtSupplier.Text = "" And txtSupplier.ReadOnly = False Then
            XtraMessageBox.Show("Please select payee!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtSupplier.Focus()
            Return False
        ElseIf txtFund.Text = "" Then
            XtraMessageBox.Show("Please select fund period!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtFund.Focus()
            Return False
        ElseIf txtPurpose.Text = "" Then
            XtraMessageBox.Show("Please enter request purpose!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtPurpose.Focus()
            Return False

        ElseIf txtPurpose.Text.Contains("(") Or txtPurpose.Text.Contains(")") Then
            XtraMessageBox.Show("Special character ""Open and Close parenthesis"" ( ) are Not allowed!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtPurpose.Focus()
            Return False


        End If
        Return True
    End Function

    Private Sub ToolStripMenuItem5_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem5.Click
        LoadSource()
    End Sub

    Private Sub SelectItemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectItemToolStripMenuItem.Click
        If GridView1.RowCount = 0 Then
            XtraMessageBox.Show("No selected item", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        frmSourceOfFundInfo.mode = "edit"
        frmSourceOfFundInfo.id = GridView1.GetFocusedRowCellValue("id").ToString
        frmSourceOfFundInfo.pid.Text = pid.Text
        frmSourceOfFundInfo.officeid.Text = officeid.Text
        frmSourceOfFundInfo.periodcode.Text = periodcode.Text
        frmSourceOfFundInfo.requestno.Text = requestno.Text
        frmSourceOfFundInfo.ShowDialog(Me)
    End Sub

    Private Sub DeleteItemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteItemToolStripMenuItem.Click
        If GridView1.RowCount = 0 Then
            XtraMessageBox.Show("No selected item", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If XtraMessageBox.Show("Are you sure you want To permanently remove selected item? ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            Dim I As Integer = 0
            For I = 0 To GridView1.SelectedRowsCount - 1
                com.CommandText = "delete from tmprequisitionfund where id='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "id") & "' " : com.ExecuteNonQuery()
            Next
            LoadSource()
        End If
    End Sub

    Public Sub ShowRequisitionInfo()
        da = Nothing : st = New DataSet
        da = New MySqlDataAdapter("select * from tblrequisition as a where pid='" & If(mode.Text = "duplicate", duplicateid.Text, pid.Text) & "'", conn)
        da.Fill(st, 0)
        For cnt = 0 To st.Tables(0).Rows.Count - 1
            With (st.Tables(0))
                officeid.Text = .Rows(cnt)("officeid").ToString()
                periodcode.Text = .Rows(cnt)("periodcode").ToString()
                fundcode.Text = .Rows(cnt)("fundcode").ToString()
                yearcode.Text = .Rows(cnt)("yeartrn").ToString()
                requesttype.Text = .Rows(cnt)("requesttype").ToString()
                requestno.Text = .Rows(cnt)("requestno").ToString()
                requestby.Text = .Rows(cnt)("requestedby").ToString()
                txtSupplier.EditValue = .Rows(cnt)("payee").ToString()
                txtRequestNumber.Text = .Rows(cnt)("requestno").ToString()
                txtFund.EditValue = .Rows(cnt)("periodcode").ToString()
                txtOffice.EditValue = .Rows(cnt)("officeid").ToString()
                txtRequestby.EditValue = .Rows(cnt)("requestedby").ToString()
                txtRequestType.EditValue = .Rows(cnt)("requesttype").ToString()
                txtPurpose.Text = .Rows(cnt)("purpose").ToString()
                txtPriority.EditValue = .Rows(cnt)("priority").ToString()
                HeadOfficeApprover = CBool(.Rows(cnt)("headofficeapproval").ToString())
                If CBool(.Rows(cnt)("cancelled").ToString()) = True Then
                    ReadOnlyForm(True, "cancelled")
                    txtStatus.Text = "CANCELLED"

                Else
                    If CBool(.Rows(cnt)("cleared").ToString()) = True Then
                        ReadOnlyForm(True, "view")
                        txtStatus.Text = "CHECK CLAIMED"
                        tabDisbursement.PageVisible = True
                        LoadDisbursement()
                    Else
                        If CBool(.Rows(cnt)("approved").ToString()) = True Then
                            ReadOnlyForm(True, "view")
                            If CBool(.Rows(cnt)("voucher").ToString()) = True Then
                                If CBool(.Rows(cnt)("paid").ToString()) = True Then
                                    txtStatus.Text = "CHECK ISSUED"
                                Else
                                    txtStatus.Text = "FOR CHECK ISSUANCE"
                                End If
                                tabDisbursement.PageVisible = True
                                LoadDisbursement()
                            Else
                                txtStatus.Text = "APPROVED"
                                tabDisbursement.PageVisible = False
                            End If
                        Else
                            tabDisbursement.PageVisible = False
                            If CBool(.Rows(cnt)("forapproval").ToString()) = True Then
                                ReadOnlyForm(True, "approval")
                                txtStatus.Text = "FOR APPROVAL"

                            ElseIf CBool(.Rows(cnt)("draft").ToString()) = True Then
                                ReadOnlyForm(False, "edit")
                                txtStatus.Text = "DRAFT"

                            ElseIf CBool(.Rows(cnt)("hold").ToString()) = True Then
                                ReadOnlyForm(False, "edit")
                                txtStatus.Text = "ON HOLD"
                            End If
                        End If
                    End If

                End If

            End With
        Next
        LoadRequestBy()
        CheckOptionalSettings()
    End Sub

    Public Sub DuplicateRequest()
        mode.Text = "new"
        pid.Text = GetTransactionSeries("requisition")
        ReadOnlyForm(False, mode.Text)
        txtStatus.Text = "NEW REQUEST"
        txtRequestNumber.Text = "AUTO GENERATE"
        tabDisbursement.PageVisible = False
        CheckOptionalSettings()

        com.CommandText = "insert into tmprequisitionfund (pid,officeid,periodcode,requestno,monthcode,classcode,itemcode,prevbalance,amount,newbalance,cancelled) " _
                        + " select '" & pid.Text & "',officeid,periodcode,requestno,(select monthcode from tblbudgetcomposition where periodcode=a.periodcode and classcode=a.classcode and itemcode=a.itemcode and officeid=a.officeid),classcode,itemcode,0,0,0,0 from tblrequisitionfund as a where pid='" & duplicateid.Text & "'" : com.ExecuteNonQuery()
        LoadSource()
    End Sub

    Private Sub txtStatus_EditValueChanged(sender As Object, e As EventArgs) Handles txtStatus.EditValueChanged
        If txtStatus.Text = "PENDING" Or txtStatus.Text = "FOR APPROVAL" Or txtStatus.Text = "ON HOLD" Or txtStatus.Text = "NEW REQUEST" Then
            txtStatus.BackColor = Color.Orange
            txtStatus.ForeColor = Color.Black

        ElseIf txtStatus.Text = "FOR CHECK ISSUANCE" Then
            txtStatus.BackColor = Color.Khaki
            txtStatus.ForeColor = Color.Black

        ElseIf txtStatus.Text = "DRAFT" Then
            txtStatus.BackColor = Color.LightGray
            txtStatus.ForeColor = Color.Black

        ElseIf txtStatus.Text = "APPROVED" Then
            txtStatus.BackColor = Color.Green
            txtStatus.ForeColor = Color.Black

        ElseIf txtStatus.Text = "CHECK ISSUED" Then
            txtStatus.BackColor = Color.LightSkyBlue
            txtStatus.ForeColor = Color.Black

        ElseIf txtStatus.Text = "CHECK CLAIMED" Then
            txtStatus.BackColor = Color.Gold
            txtStatus.ForeColor = Color.Black

        ElseIf txtStatus.Text = "CANCELLED" Then
            txtStatus.BackColor = Color.Red
            txtStatus.ForeColor = Color.White
        End If
    End Sub

    Public Function SaveRequisitionInfo(ByVal draft As Boolean, ByVal forapproval As Boolean) As Boolean
        Try
            If mode.Text = "edit" Or mode.Text = "revise" Then
                com.CommandText = "Update tblrequisition set  " _
                                       + " pid='" & pid.Text & "', " _
                                       + " requestno='" & requestno.Text & "', " _
                                       + " requestedby='" & requestby.Text & "', " _
                                       + " payee='" & txtSupplier.EditValue & "', " _
                                       + " officeid='" & txtOffice.EditValue & "', " _
                                       + " periodcode='" & periodcode.Text & "', " _
                                       + " fundcode='" & fundcode.Text & "', " _
                                       + " yeartrn='" & yearcode.Text & "', " _
                                       + " requesttype='" & requesttype.Text & "', " _
                                       + " purpose='" & rchar(RemoveWhitespace(txtPurpose.Text)) & "', " _
                                       + " priority='" & txtPriority.Text & "'," _
                                       + " currentlevel='" & CurrentLevel.Text & "'," _
                                       + " currentapprover='" & CurrentApprover.Text & "', " _
                                       + " nextapprover='" & NextApprover.Text & "', " _
                                       + " draft=" & draft & ", " _
                                       + " hold=0, " _
                                       + " forapproval=" & forapproval & " where pid='" & pid.Text & "'" : com.ExecuteNonQuery()
            ElseIf mode.Text = "direct" Then
                Dim CurrentMonth As String = qrysingledata("mo", "date_format(current_date,'%m') as mo", "tblcompanysettings limit 1")
                Dim RequestNumber As String = periodcode.Text & "-" & CurrentMonth & "-" & GetRequestNumber(periodcode.Text)
                com.CommandText = "INSERT INTO tblrequisition set  " _
                                       + " pid='" & pid.Text & "', " _
                                       + " requestno='" & RequestNumber & "', " _
                                       + " requestedby='" & requestby.Text & "', " _
                                       + " payee='" & txtSupplier.EditValue & "', " _
                                       + " officeid='" & txtOffice.EditValue & "', " _
                                       + " periodcode='" & periodcode.Text & "', " _
                                       + " fundcode='" & fundcode.Text & "', " _
                                       + " yeartrn='" & yearcode.Text & "', " _
                                       + " requesttype='" & requesttype.Text & "', " _
                                       + " postingdate=current_date, " _
                                       + " purpose='" & rchar(RemoveWhitespace(txtPurpose.Text)) & "', " _
                                       + " priority='" & txtPriority.Text & "'," _
                                       + " headofficeapproval=0," _
                                       + " currentlevel='0'," _
                                       + " currentapprover='', " _
                                       + " nextapprover='', " _
                                       + " draft=0, " _
                                       + " forapproval=0, " _
                                       + " approved=1, " _
                                       + " trnby='" & globaluserid & "', " _
                                       + " datetrn=current_timestamp " : com.ExecuteNonQuery()
                com.CommandText = "update tblrequisitionitem set requestno='" & RequestNumber & "' where pid='" & pid.Text & "'" : com.ExecuteNonQuery()
                com.CommandText = "update tmprequisitionfund set requestno='" & RequestNumber & "' where pid='" & pid.Text & "'" : com.ExecuteNonQuery()
            Else
                Dim CurrentMonth As String = qrysingledata("mo", "date_format(current_date,'%m') as mo", "tblcompanysettings limit 1")
                Dim RequestNumber As String = periodcode.Text & "-" & CurrentMonth & "-" & GetRequestNumber(periodcode.Text)
                com.CommandText = "INSERT INTO tblrequisition set  " _
                                       + " pid='" & pid.Text & "', " _
                                       + " requestno='" & RequestNumber & "', " _
                                       + " requestedby='" & requestby.Text & "', " _
                                       + " payee='" & txtSupplier.EditValue & "', " _
                                       + " officeid='" & txtOffice.EditValue & "', " _
                                       + " periodcode='" & periodcode.Text & "', " _
                                       + " fundcode='" & fundcode.Text & "', " _
                                       + " yeartrn='" & yearcode.Text & "', " _
                                       + " requesttype='" & requesttype.Text & "', " _
                                       + " postingdate=current_date, " _
                                       + " purpose='" & rchar(RemoveWhitespace(txtPurpose.Text)) & "', " _
                                       + " priority='" & txtPriority.Text & "'," _
                                       + " headofficeapproval=1," _
                                       + " currentlevel='0'," _
                                       + " currentapprover='', " _
                                       + " nextapprover='" & CurrentApprover.Text & "', " _
                                       + " draft=" & draft & ", " _
                                       + " forapproval=" & forapproval & ", " _
                                       + " trnby='" & globaluserid & "', " _
                                       + " datetrn=current_timestamp " : com.ExecuteNonQuery()
                com.CommandText = "update tblrequisitionitem set requestno='" & RequestNumber & "' where pid='" & pid.Text & "'" : com.ExecuteNonQuery()
                com.CommandText = "update tmprequisitionfund set requestno='" & RequestNumber & "' where pid='" & pid.Text & "'" : com.ExecuteNonQuery()
            End If
            com.CommandText = "DELETE FROM tblrequisitionfund where pid='" & pid.Text & "'" : com.ExecuteNonQuery()
            com.CommandText = "INSERT INTO tblrequisitionfund (pid,officeid,periodcode,requestno,monthcode,classcode,itemcode,prevbalance,amount,newbalance,cancelled) select pid,officeid,periodcode,requestno,monthcode,classcode,itemcode,prevbalance,amount,newbalance,cancelled from tmprequisitionfund where pid='" & pid.Text & "'" : com.ExecuteNonQuery()
        Catch ex As Exception
            Return False
        End Try

        Return True
    End Function

    Public Sub ApprovingHistory()
        LoadXgrid("select (select officename from tblcompoffice where officeid=a.officeid) as 'Confirmed Office',ucase(status) as 'Status', Remarks, " _
                  + " if(authorized=1, concat(confirmby,'\nAuthorized By: ',(select fullname from tblaccounts where accountid=a.authorizedby)), confirmby)  as 'Confirmed By', Position, date_format(dateconfirm,'%Y-%m-%d %r') as 'Date Confirmed' from tblapprovalhistory as a where mainreference='" & pid.Text & "'", "tblapprovalhistory", Em_approval, gridview_approval, Me)
        XgridColAlign({"Status", "Date Confirmed"}, gridview_approval, DevExpress.Utils.HorzAlignment.Center)
        gridview_approval.BestFitColumns()
        XgridColMemo({"Remarks", "Confirmed By"}, gridview_approval)
        XgridColWidth({"Remarks"}, gridview_approval, 300)


    End Sub

    Public Sub LoadFiles()
        dst.EnforceConstraints = False
        dst.Relations.Clear() : Em_files.LevelTree.Nodes.Clear()
        dst.Clear()
        LoadXgrid("select filecode, (select officename from tblcompoffice where officeid=a.officeid) as 'Attached By',(select concat(cast(count(*) as CHAR), ' File(s)') from " & sqlfiledir & ".tblattachmentlogs where refnumber=a.pid and trntype='requisition' and filecode=a.filecode) as 'Total Files', (select fullname from tblaccounts where accountid=a.trnby) as 'Posted By', date_format(datetrn, '%Y-%m-%d %r') as 'Date Posted' from tblrequisitionfiles as a where a.pid='" & pid.Text & "'", "tblrequisitionfiles", Em_files, gridview_files, Me)
        msda.SelectCommand.CommandTimeout = 6000000
        msda.Fill(dst, "tblrequisitionfiles")
        XgridColAlign({"Date Posted", "Total Files"}, gridview_files, DevExpress.Utils.HorzAlignment.Center)
        XgridHideColumn({"filecode"}, gridview_files)
        gridview_files.BestFitColumns()
        gridview_files.Columns("Attached By").Width = gridview_files.Columns("Attached By").Width + 30

        msda = New MySqlDataAdapter("select filecode,docname, (select description from tbldocumenttype where code=b.docname) as 'Document Name', concat(cast(count(*) as CHAR), ' File(s)') as 'Total Files' from " & sqlfiledir & ".tblattachmentlogs as b where refnumber='" & pid.Text & "' and trntype='requisition' group by filecode, docname ", conn)
        msda.Fill(dst, "tblattachmentlogs")

        BandgridView = New GridView(Em_files)
        LoadGridviewAppearance(BandgridView)
        Dim keyColumn As DataColumn = dst.Tables("tblrequisitionfiles").Columns("filecode")
        Dim foreignKeyColumn2 As DataColumn = dst.Tables("tblattachmentlogs").Columns("filecode")

        dst.Relations.Add("AttachedDocumentFiles", keyColumn, foreignKeyColumn2)
        Em_files.LevelTree.Nodes.Add("AttachedDocumentFiles", BandgridView)

        Em_files.DataSource = dst.Tables("tblrequisitionfiles")

        BandgridView.PopulateColumns(dst.Tables("tblattachmentlogs"))

        BandgridView.OptionsView.RowAutoHeight = True
        BandgridView.OptionsCustomization.AllowGroup = False
        BandgridView.OptionsView.ShowGroupPanel = False
        BandgridView.OptionsBehavior.Editable = False


        If BandgridView.RowCount > 0 Then
            BandgridView.Columns("Document Name").ColumnEdit.AutoHeight = True
        End If

        XgridHideColumn({"filecode", "docname"}, BandgridView)
        XgridColAlign({"Total Files"}, BandgridView, DevExpress.Utils.HorzAlignment.Center)
        XgridColMemo({"Document Name"}, BandgridView)
        XgridColWidth({"Document Name"}, BandgridView, 250)
        XgridHideColumn({"filecode"}, gridview_files)

        'RemoveHandler BandgridView.MouseDown, New MouseEventHandler(AddressOf MouseEvent)
        'AddHandler BandgridView.MouseDown, New MouseEventHandler(AddressOf MouseEvent)

        'RemoveHandler BandgridView.RowCellClick, New RowCellClickEventHandler(AddressOf RowCellClickEvent)
        'AddHandler BandgridView.RowCellClick, New RowCellClickEventHandler(AddressOf RowCellClickEvent)

        'RemoveHandler BandgridView.FocusedRowChanged, New DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(AddressOf FocusedRowChanged)
        'AddHandler BandgridView.FocusedRowChanged, New DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(AddressOf FocusedRowChanged)

    End Sub

    Public Sub LoadDisbursement()
        LoadXgrid("SELECT if(cancelled,'CANCELLED',if(cleared,'CLEARED', 'PENDING')) as Status, " _
                      + " voucherno as 'Voucher No.', " _
                      + " date_format(voucherdate,'%Y-%m-%d') as 'Voucher Date', " _
                      + " (select suppliername from tblsupplier where supplierid = a.supplierid) as 'Payee', " _
                      + " Amount, " _
                      + " checkno as 'Check No.', " _
                      + " checkdate as 'Check Date', " _
                      + " (select fullname from tblaccounts where accountid=a.trnby) as 'Posted By', " _
                      + " date_format(datetrn,'%Y-%m-%d') as 'Date Posted' " _
                      + " FROM tbldisbursementvoucher as a " _
                      + " where pid = '" & pid.Text & "' " _
                      + " order by voucherno asc", "tbldisbursementvoucher", Em_disbursement, gridDisbursement, Me)
        XgridColCurrency({"Amount"}, gridDisbursement)
        XgridColAlign({"Entry Code", "Status", "Fund Period", "Type of Payment", "Voucher Date", "Date Posted", "Cleared", "Date Cleared", "Cancelled", "Date Cancelled"}, gridDisbursement, DevExpress.Utils.HorzAlignment.Center)
        XgridGeneralSummaryCurrency({"Amount"}, gridDisbursement)
        gridDisbursement.BestFitColumns()
    End Sub

    Private Sub gridDisbursement_RowCellStyle(ByVal sender As Object, ByVal e As RowCellStyleEventArgs) Handles gridDisbursement.RowCellStyle
        Dim View As GridView = sender
        Dim status As String = View.GetRowCellDisplayText(e.RowHandle, View.Columns("Status"))
        If status = "CANCELLED" Then
            e.Appearance.ForeColor = Color.Red
            e.Appearance.Font = New Font(gen_fontfamily, gen_FontSize, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, (CByte(204)))
        Else
            If e.Column.Name = "colStatus" Then
                If status = "PENDING" Then
                    e.Appearance.BackColor = Color.Orange
                    e.Appearance.BackColor2 = Color.Orange
                    e.Appearance.ForeColor = Color.Black

                ElseIf status = "CLEARED" Then
                    e.Appearance.BackColor = Color.Green
                    e.Appearance.BackColor2 = Color.Green
                    e.Appearance.ForeColor = Color.White
                End If
            End If
        End If
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        ToolStripButton3.PerformClick()
    End Sub

    Private Sub RemoveAttachementToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles cmdRemoveAttachment.Click
        If gridview_files.SelectedRowsCount = 0 Then
            XtraMessageBox.Show("Nothing is selected!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        If XtraMessageBox.Show("Are you sure you want to permanently remove selected item? ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            Dim I As Integer = 0
            For I = 0 To gridview_files.SelectedRowsCount - 1


                dst = Nothing : dst = New DataSet
                msda = New MySqlDataAdapter("select * from " & sqlfiledir & ".tblattachmentlogs where refnumber='" & pid.Text & "' and trntype='requisition' and filecode='" & gridview_files.GetRowCellValue(gridview_files.GetSelectedRows(I), "filecode").ToString() & "'", conn)
                msda.Fill(dst, 0)
                For cnt = 0 To dst.Tables(0).Rows.Count - 1
                    With (dst.Tables(0))
                        com.CommandText = "delete from " & sqlfiledir & "." & .Rows(cnt)("databasename").ToString() & " where refnumber='" & pid.Text & "' and trntype='requisition' and filecode='" & .Rows(cnt)("filecode").ToString() & "'" : com.ExecuteNonQuery()
                    End With
                Next
                com.CommandText = "delete from " & sqlfiledir & ".tblattachmentlogs where refnumber='" & pid.Text & "' and trntype='requisition' and filecode='" & gridview_files.GetRowCellValue(gridview_files.GetSelectedRows(I), "filecode").ToString() & "'" : com.ExecuteNonQuery()
                com.CommandText = "delete from tblrequisitionfiles where pid='" & pid.Text & "' and filecode='" & gridview_files.GetRowCellValue(gridview_files.GetSelectedRows(I), "filecode").ToString() & "'" : com.ExecuteNonQuery()
            Next
            LoadFiles()
        End If
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        LoadFiles()
    End Sub

    Private Sub ViewSelectedMainDocumentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles cmdViewAttachmentMain.Click
        If gridview_files.SelectedRowsCount > 0 Then
            Dim list As New ArrayList
            For I = 0 To gridview_files.SelectedRowsCount - 1
                com.CommandText = "select * from " & sqlfiledir & ".tblattachmentlogs where refnumber='" & pid.Text & "' and trntype='requisition' and filecode='" & gridview_files.GetRowCellValue(gridview_files.GetSelectedRows(I), "filecode").ToString() & "'" : rst = com.ExecuteReader
                While rst.Read
                    list.Add(rst("id").ToString)
                End While
                rst.Close()
            Next
            ViewAttachmentPackage_Individual(list.ToArray)
        End If
    End Sub

    Private Sub cmdSaveFolio_Click(sender As Object, e As EventArgs)
        If SecurityCheck() = True Then
            If XtraMessageBox.Show("Are you sure you want to continue? ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                If SaveRequisitionInfo(True, False) = True Then
                    If frmRequisitionList.Visible = True Then
                        frmRequisitionList.ViewList()
                    End If
                    XtraMessageBox.Show("Requisition successfully saved as draft!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()
                End If
            End If
        End If
    End Sub


    Private Sub cmdConfirmReservation_Click(sender As Object, e As EventArgs) Handles cmdForApproval.Click
        If SecurityCheck() = True Then
            If Val(CC(txtSourceAmount.Text)) = 0 Then
                XtraMessageBox.Show("Please select from item from budget source!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            ElseIf GridView1.RowCount = 0 Then
                XtraMessageBox.Show("Please select from item from budget source!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            Dim cnt As Integer = 0 : Dim requiredAttachment As String = "This request requires an attachment to proceed! Please provide attachment below:" & Environment.NewLine & Environment.NewLine
            com.CommandText = "select description from tblapprovingattachment as x inner join tbldocumenttype as  y on x.doccode=y.code where  y.required=1 and trncode='" & requesttype.Text & "' and appid='-' and doccode not in (SELECT b.docname FROM `tblrequisitionfiles` as a inner join lgufiledir.tblattachmentlogs as b on a.filecode=b.filecode and a.pid=b.refnumber where pid='" & pid.Text & "' and a.applevel='0' and a.requesttype='" & requesttype.Text & "' )" : rst = com.ExecuteReader
            While rst.Read
                cnt += 1
                requiredAttachment += cnt & ". " & rst("description").ToString & Environment.NewLine

            End While
            rst.Close()
            If countqry("tblapprovingattachment", "trncode='" & requesttype.Text & "' and appid='-'") > 0 Then
                If cnt > 0 Then
                    XtraMessageBox.Show(requiredAttachment, GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
            End If

            If DirectApproved Then
                If XtraMessageBox.Show("Are sure you want to proceed for DV preparation?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                    If SaveRequisitionInfo(False, False) = True Then
                        com.CommandText = "insert into tblapprovalhistory set apptype='requisition', trncode='" & requesttype.Text & "',fundcode='" & fundcode.Text & "', mainreference='" & pid.Text & "', subreference='" & pid.Text & "', status='DONE', remarks='Proceed for DV preparation', applevel=0, officeid='" & compOfficeid & "', confirmid='" & globaluserid & "', confirmby='" & globalfullname & "', position='" & globalposition & "', dateconfirm=current_timestamp,finalapprover=0" : com.ExecuteNonQuery()
                        If frmRequisitionList.Visible = True Then
                            frmRequisitionList.ViewList()
                        End If
                        XtraMessageBox.Show("Requisition successfully done!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.Close()
                        frmApprovalConfirmation.Close()
                    End If
                End If
            Else
                frmApprovalConfirmation.mode.Text = "logs"
                frmApprovalConfirmation.ShowDialog(Me)
                If frmApprovalConfirmation.TransactionDone = True Then

                    If SaveRequisitionInfo(False, True) = True Then
                        com.CommandText = "insert into tblapprovalhistory set apptype='requisition', trncode='" & requesttype.Text & "',fundcode='" & fundcode.Text & "', mainreference='" & pid.Text & "', subreference='" & pid.Text & "', status='Processed', remarks='" & rchar(RemoveWhitespace(frmApprovalConfirmation.txtRemarks.Text)) & "', applevel=0, officeid='" & compOfficeid & "', confirmid='" & globaluserid & "', confirmby='" & globalfullname & "', position='" & globalposition & "', dateconfirm=current_timestamp,finalapprover=0" : com.ExecuteNonQuery()
                        If frmRequisitionList.Visible = True Then
                            frmRequisitionList.ViewList()
                        End If
                        XtraMessageBox.Show("Requisition successfully submitted for approval!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.Close()
                        frmApprovalConfirmation.Close()
                    End If

                    frmApprovalConfirmation.TransactionDone = False
                    frmApprovalConfirmation.Dispose()
                End If

            End If

        End If
    End Sub

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub AddItemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles cmdAddItem.Click
        If SecurityCheck() = True Then
            Dim ServerDate As Date = GetServerDate()
            If getCurrentTransactionMonth(periodcode.Text) <> ServerDate.ToString("MM") Then
                XtraMessageBox.Show("Transaction month is not updated! Please contact accounting department", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
            frmSourceOfFundInfo.pid.Text = pid.Text
            frmSourceOfFundInfo.officeid.Text = officeid.Text
            frmSourceOfFundInfo.periodcode.Text = periodcode.Text
            frmSourceOfFundInfo.requestno.Text = requestno.Text
            frmSourceOfFundInfo.requiredfund = RequiredFund
            frmSourceOfFundInfo.ShowDialog(Me)
        End If
    End Sub

    Private Sub cmdPrintObligation_Click(sender As Object, e As EventArgs) Handles cmdPrintObligation.Click
        If countqry("tblfund", "code='" & fundcode.Text & "' and template='FURS'") > 0 Then
            cmdPrintObligation.Text = "Print FURS"
            PrintFURS(pid.Text, True, Me)
        ElseIf countqry("tblfund", "code='" & fundcode.Text & "' and template='CAFOA'") > 0 Then
            PrintCAFOA(pid.Text, True, Me)
        End If
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles cmdAddParticularItem.Click
        cmdAddItem.PerformClick()
    End Sub

    Private Sub cmdItemRefresh_Click(sender As Object, e As EventArgs) Handles cmdItemRefresh.Click
        ToolStripMenuItem5.PerformClick()
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        If XtraMessageBox.Show("Make sure your scanned document are ready before proceeding" & Environment.NewLine & "attachment manager to avoid upload files cancellation! " & Environment.NewLine & Environment.NewLine & "Are you sure you want to continue? ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
            XtraTabControl1.SelectedTabPage = tabAttachment
            frmRequisitionDocManager.applevel.Text = "0"
            frmRequisitionDocManager.requesttype.Text = requesttype.Text
            frmRequisitionDocManager.pid.Text = pid.Text
            frmRequisitionDocManager.mode.Text = "new"
            If frmRequisitionDocManager.Visible = True Then
                frmRequisitionDocManager.Focus()
            Else
                frmRequisitionDocManager.Show(Me)
            End If
        End If
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        ToolStripMenuItem2.PerformClick()
    End Sub

    Private Sub ModifyAttachmentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles cmdModifyAttachment.Click
        XtraTabControl1.SelectedTabPage = tabAttachment
        frmRequisitionDocManager.applevel.Text = "0"
        frmRequisitionDocManager.requesttype.Text = requesttype.Text
        frmRequisitionDocManager.pid.Text = pid.Text
        frmRequisitionDocManager.filecode.Text = gridview_files.GetFocusedRowCellValue("filecode").ToString
        frmRequisitionDocManager.mode.Text = "edit"
        If frmRequisitionDocManager.Visible = True Then
            frmRequisitionDocManager.Focus()
        Else
            frmRequisitionDocManager.Show(Me)
        End If
    End Sub

End Class