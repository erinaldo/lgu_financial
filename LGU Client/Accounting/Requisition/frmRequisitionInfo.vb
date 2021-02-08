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
        If countqry("tblrequisitionitem", "pid='" & pid.Text & "'") > 0 Or countqry("tblrequisitionfund", "pid='" & pid.Text & "'") > 0 Then
            If countqry("tblrequisition", "pid='" & pid.Text & "'") = 0 Then
                If XtraMessageBox.Show("Are you sure you want to close current request? Closing unsaved request will cancelling all current transaction." & Environment.NewLine & "You may save it as draft for you able to edit this transaction later.", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
                    com.CommandText = "DELETE FROM tblrequisitionitem where pid='" & pid.Text & "'" : com.ExecuteNonQuery()
                    com.CommandText = "DELETE FROM tblrequisitionfund where pid='" & pid.Text & "'" : com.ExecuteNonQuery()
                    com.CommandText = "DELETE FROM tblrequisitionfiles where pid='" & pid.Text & "'" : com.ExecuteNonQuery()
                Else
                    e.Cancel = True
                End If
            End If
        End If
    End Sub

    Private Sub frmRequisitionInfo_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        txtSourceAmount.EditValue = qrysingledata("total", "sum(amount) as total", "tblrequisitionfund where pid='" & pid.Text & "'")
    End Sub

    Private Sub ffrmRequisitionInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico
        ApplySystemTheme(ToolStrip1)
        txtPostingDate.EditValue = CDate(Now)

        LoadOffice()
        LoadRequestBy()

        officeid.Text = compOfficeid
        txtOffice.EditValue = compOfficeid

        If mode.Text = "edit" Then
            ShowRequisitionInfo()
            LoadRequestType()
            LoadFund()
        Else
            LoadRequestType()
            LoadFund()
            pid.Text = GetRequisitionSeries()
            ReadOnlyForm(False, mode.Text)
            txtStatus.Text = "NEW REQUEST"
        End If
        LoadItem()
        LoadFiles()
        ApprovingHistory()

        LoadApproverDeatils()

    End Sub

    Public Sub ReadOnlyForm(ByVal readonlyForm As Boolean, ByVal mode As String)
        ReadOnlyTrn = readonlyForm
        txtRequestType.ReadOnly = readonlyForm

        txtRequestby.ReadOnly = readonlyForm
        txtFund.ReadOnly = readonlyForm
        txtPurpose.ReadOnly = readonlyForm
        txtPriority.ReadOnly = readonlyForm

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
            cmdSaveAsDraft.Visible = True
            linedraft.Visible = True
            cmdForApproval.Visible = True
            lineapproval.Visible = True
            linePrintPr.Visible = True


            linePrintPr.Visible = False
            cmdPrintPR.Visible = False

            lineCreatePO.Visible = False
            cmdCreatePO.Visible = False

        ElseIf mode = "approval" Or mode = "cancelled" Then
            cmdSaveAsDraft.Visible = False
            linedraft.Visible = False
            cmdForApproval.Visible = False
            lineapproval.Visible = False
            linePrintPr.Visible = False

            linePrintPr.Visible = False
            cmdPrintPR.Visible = False

            lineCreatePO.Visible = False
            cmdCreatePO.Visible = False

        ElseIf mode = "view" Or mode = "approved" Then
            cmdSaveAsDraft.Visible = False
            linedraft.Visible = False
            cmdForApproval.Visible = False
            lineapproval.Visible = False
            linePrintPr.Visible = False
            cmdPrintObligation.Visible = True
            linePrintObligation.Visible = True

            If EnablePR Then
                linePrintPr.Visible = True
                cmdPrintPR.Visible = True
            Else
                cmdPrintPR.Visible = False
                linePrintPr.Visible = False
            End If

            If EnablePO Then
                cmdCreatePO.Visible = True
                lineCreatePO.Visible = True
            Else
                lineCreatePO.Visible = False
                cmdCreatePO.Visible = False
            End If

            ShowReportTemplate()
        Else
            cmdSaveAsDraft.Visible = True
            linedraft.Visible = True
            cmdForApproval.Visible = True
            lineapproval.Visible = True
            linePrintPr.Visible = True
            cmdPrintObligation.Visible = False
            linePrintObligation.Visible = False

            If EnablePR Then
                linePrintPr.Visible = True
                cmdPrintPR.Visible = True
            Else
                cmdPrintPR.Visible = False
                linePrintPr.Visible = False
            End If

            If EnablePO Then
                cmdCreatePO.Visible = True
                lineCreatePO.Visible = True
            Else
                lineCreatePO.Visible = False
                cmdCreatePO.Visible = False
            End If
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
        LoadXgridLookupSearch("select code,description as 'Select',enablepr,enablepo from tblrequisitiontype " & If(LCase(globalusername) = "root", "", " where code in (select requestcode from tblrequisitionfilter where officeid='" & officeid.Text & "')") & " order by description asc", "tblrequisitiontype", txtRequestType, gridRequestType)
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
        End While
        rst.Close()
        If DirectApproved Then
            mode.Text = "direct"
            cmdForApproval.Text = "Proceed for DV Preparation"
        Else
            cmdForApproval.Text = "Submit for Approval"
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
        LoadXgridLookupSearch("select accountid as code, fullname as 'Select' from tblaccounts where officeid='" & officeid.Text & "'  order by fullname asc", "tblaccounts", txtRequestby, gridrequestby)
        gridrequestby.Columns("code").Visible = False
    End Sub

    Private Sub txtRequestby_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRequestby.EditValueChanged
        On Error Resume Next
        requestby.Text = txtRequestby.Properties.View.GetFocusedRowCellValue("code").ToString()
    End Sub

    Public Sub LoadFund()
        LoadXgridLookupSearch("SELECT periodcode as code,fundcode,yeartrn, concat(yeartrn,'-',(select Description from tblfund where code=tblfundperiod.fundcode)) as 'Select'  from tblfundperiod where closed=0 " & If(LCase(globalusername) = "root", "", " and fundcode in (select fundcode from tblfundfilter where officeid='" & officeid.Text & "')") & "  order by yeartrn asc", "tblfundperiod", txtFund, gridFund)
        XgridHideColumn({"code", "fundcode", "yeartrn"}, gridFund)
    End Sub
    Private Sub txtFund_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFund.EditValueChanged
        On Error Resume Next
        periodcode.Text = txtFund.Properties.View.GetFocusedRowCellValue("code").ToString()
        fundcode.Text = txtFund.Properties.View.GetFocusedRowCellValue("fundcode").ToString()
        yearcode.Text = txtFund.Properties.View.GetFocusedRowCellValue("yeartrn").ToString()
        txtPostingDate.Properties.MinValue = CDate("01/01/" & yearcode.Text)
        txtPostingDate.Properties.MaxValue = CDate("12/31/" & yearcode.Text)
    End Sub

    Public Sub LoadItem()
        LoadXgrid("Select id, itemname as 'Particular Name',Quantity, Unit, unitcost as 'Unit Cost',totalcost as 'Total Cost', Remarks " _
                           + " from tblrequisitionitem  " _
                           + " where pid = '" & pid.Text & "' order by itemname asc", "tblrequisitionitem", Em, GridView1, Me)
        XgridHideColumn({"id"}, GridView1)
        XgridColCurrency({"Unit Cost", "Total Cost"}, GridView1)
        XgridColAlign({"Unit", "Quantity"}, GridView1, DevExpress.Utils.HorzAlignment.Center)
        GridView1.Columns("Remarks").ColumnEdit = MemoEdit
        XgridGeneralSummaryCurrency({"Total Cost"}, GridView1)
        GridView1.BestFitColumns()

        If GridView1.RowCount > 0 Then
            txtRequestType.Properties.ReadOnly = True
            txtFund.Properties.ReadOnly = True
        Else
            If mode.Text = "edit" Then
                txtRequestType.Properties.ReadOnly = False
                txtFund.Properties.ReadOnly = False
            End If
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
        ElseIf txtFund.Text = "" Then
            XtraMessageBox.Show("Please select fund period!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtFund.Focus()
            Return False
        ElseIf txtPostingDate.Text = "" Then
            XtraMessageBox.Show("Please select posting date!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtPostingDate.Focus()
            Return False
        ElseIf txtPurpose.Text = "" Then
            XtraMessageBox.Show("Please enter request purpose!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtPurpose.Focus()
            Return False

        End If
        Return True
    End Function

    Private Sub ToolStripMenuItem5_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem5.Click
        LoadItem()
    End Sub

    Private Sub SelectItemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectItemToolStripMenuItem.Click
        If GridView1.RowCount = 0 Then
            XtraMessageBox.Show("Nothing is selected!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        frmQuantitySelect.mode.Text = ""
        frmQuantitySelect.id.Text = GridView1.GetFocusedRowCellValue("id").ToString
        frmQuantitySelect.mode.Text = "edit"
        frmQuantitySelect.ShowDialog(Me)
    End Sub

    Private Sub DeleteItemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteItemToolStripMenuItem.Click
        If GridView1.SelectedRowsCount = 0 Then
            XtraMessageBox.Show("Nothing is selected!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        If XtraMessageBox.Show("Are you sure you want to permanently remove selected item? ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            Dim I As Integer = 0
            For I = 0 To GridView1.SelectedRowsCount - 1
                com.CommandText = "delete from tblrequisitionitem where id='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "id") & "' " : com.ExecuteNonQuery()
            Next
            LoadItem()
        End If
    End Sub

    Public Sub ShowRequisitionInfo()
        da = Nothing : st = New DataSet
        da = New MySqlDataAdapter("select * from tblrequisition as a where pid='" & pid.Text & "'", conn)
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

                txtRequestNumber.Text = .Rows(cnt)("requestno").ToString()
                txtFund.EditValue = .Rows(cnt)("periodcode").ToString()
                txtOffice.EditValue = .Rows(cnt)("officeid").ToString()
                txtRequestby.EditValue = .Rows(cnt)("requestedby").ToString()
                txtRequestType.EditValue = .Rows(cnt)("requesttype").ToString()
                txtPostingDate.EditValue = CDate(.Rows(cnt)("postingdate").ToString())
                txtPurpose.Text = .Rows(cnt)("purpose").ToString()
                txtPriority.EditValue = .Rows(cnt)("priority").ToString()
                HeadOfficeApprover = CBool(.Rows(cnt)("headofficeapproval").ToString())
                If CBool(.Rows(cnt)("approved").ToString()) = True Then
                    ReadOnlyForm(True, "view")
                    If CBool(.Rows(cnt)("paid").ToString()) = True Then
                        txtStatus.Text = "DISBURSED"
                        tabDisbursement.PageVisible = True
                        LoadDisbursement()
                    Else
                        txtStatus.Text = "APPROVED"
                        tabDisbursement.PageVisible = False
                    End If
                Else
                    tabDisbursement.PageVisible = False
                    If CBool(.Rows(cnt)("cancelled").ToString()) = True Then
                        ReadOnlyForm(True, "cancelled")
                        txtStatus.Text = "CANCELLED"

                    ElseIf CBool(.Rows(cnt)("forapproval").ToString()) = True Then
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
            End With
        Next
        CheckOptionalSettings()
    End Sub

    Public Function SaveRequisitionInfo(ByVal draft As Boolean, ByVal forapproval As Boolean) As Boolean
        Try
            If mode.Text = "edit" Or mode.Text = "revise" Then
                com.CommandText = "Update tblrequisition set  " _
                                       + " pid='" & pid.Text & "', " _
                                       + " requestno='" & requestno.Text & "', " _
                                       + " requestedby='" & requestby.Text & "', " _
                                       + " officeid='" & txtOffice.EditValue & "', " _
                                       + " periodcode='" & periodcode.Text & "', " _
                                       + " fundcode='" & fundcode.Text & "', " _
                                       + " yeartrn='" & yearcode.Text & "', " _
                                       + " requesttype='" & requesttype.Text & "', " _
                                       + " postingdate='" & ConvertDate(txtPostingDate.Text) & "', " _
                                       + " purpose='" & rchar(txtPurpose.Text) & "', " _
                                       + " priority='" & txtPriority.Text & "'," _
                                       + " currentlevel='" & CurrentLevel.Text & "'," _
                                       + " currentapprover='" & CurrentApprover.Text & "', " _
                                       + " nextapprover='" & NextApprover.Text & "', " _
                                       + " draft=" & draft & ", " _
                                       + " hold=0, " _
                                       + " forapproval=" & forapproval & " where pid='" & pid.Text & "'" : com.ExecuteNonQuery()
            ElseIf mode.Text = "direct" Then
                Dim RequestNumber As String = periodcode.Text & "-" & CDate(txtPostingDate.EditValue).ToString("MM") & "-" & GetRequestNumber(periodcode.Text)
                com.CommandText = "INSERT INTO tblrequisition set  " _
                                       + " pid='" & pid.Text & "', " _
                                       + " requestno='" & RequestNumber & "', " _
                                       + " requestedby='" & requestby.Text & "', " _
                                       + " officeid='" & txtOffice.EditValue & "', " _
                                       + " periodcode='" & periodcode.Text & "', " _
                                       + " fundcode='" & fundcode.Text & "', " _
                                       + " yeartrn='" & yearcode.Text & "', " _
                                       + " requesttype='" & requesttype.Text & "', " _
                                       + " postingdate='" & ConvertDate(txtPostingDate.Text) & "', " _
                                       + " purpose='" & rchar(txtPurpose.Text) & "', " _
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
                com.CommandText = "update tblrequisitionfund set requestno='" & RequestNumber & "' where pid='" & pid.Text & "'" : com.ExecuteNonQuery()
            Else
                Dim RequestNumber As String = periodcode.Text & "-" & CDate(txtPostingDate.EditValue).ToString("MM") & "-" & GetRequestNumber(periodcode.Text)
                com.CommandText = "INSERT INTO tblrequisition set  " _
                                       + " pid='" & pid.Text & "', " _
                                       + " requestno='" & RequestNumber & "', " _
                                       + " requestedby='" & requestby.Text & "', " _
                                       + " officeid='" & txtOffice.EditValue & "', " _
                                       + " periodcode='" & periodcode.Text & "', " _
                                       + " fundcode='" & fundcode.Text & "', " _
                                       + " yeartrn='" & yearcode.Text & "', " _
                                       + " requesttype='" & requesttype.Text & "', " _
                                       + " postingdate='" & ConvertDate(txtPostingDate.Text) & "', " _
                                       + " purpose='" & rchar(txtPurpose.Text) & "', " _
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
                com.CommandText = "update tblrequisitionfund set requestno='" & RequestNumber & "' where pid='" & pid.Text & "'" : com.ExecuteNonQuery()
            End If
        Catch ex As Exception
            Return False
        End Try

        Return True
    End Function

    Public Sub ApprovingHistory()
        LoadXgrid("select (select officename from tblcompoffice where officeid=a.officeid) as 'Confirmed Office',ucase(status) as 'Status', Remarks, confirmby as 'Confirmed By', Position, date_format(dateconfirm,'%Y-%m-%d %r') as 'Date Confirmed' from tblapprovalhistory as a where mainreference='" & pid.Text & "'", "tblapprovalhistory", Em_approval, gridview_approval, Me)
        XgridColAlign({"Status", "Date Confirmed"}, gridview_approval, DevExpress.Utils.HorzAlignment.Center)
        gridview_approval.BestFitColumns()
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
        LoadXgrid("SELECT a.id,  if(a.cancelled,'CANCELLED',if(cleared,'CLEARED', 'PENDING')) as Status, " _
                      + " a.voucherno as 'Voucher No.', " _
                      + " date_format(voucherdate,'%Y-%m-%d') as 'Voucher Date', " _
                      + " (select suppliername from tblsupplier where supplierid = a.supplierid) as 'Supplier', " _
                      + " a.Amount, " _
                      + " (select fullname from tblaccounts where accountid=a.trnby) as 'Posted By', " _
                      + " date_format(datetrn,'%Y-%m-%d') as 'Date Posted' " _
                      + " FROM tbldisbursementvoucher as a inner join tbldisbursementdetails as b on a.voucherno = b.voucherno " _
                      + " where b.pid = '" & pid.Text & "' " _
                      + " order by a.voucherno asc", "tbldisbursementvoucher", Em_disbursement, gridDisbursement, Me)
        XgridHideColumn({"id"}, gridDisbursement)
        XgridColCurrency({"Amount"}, gridDisbursement)
        XgridColAlign({"Entry Code", "Status", "Fund Period", "Type of Payment", "Voucher Date", "Date Posted", "Cleared", "Date Cleared", "Cancelled", "Date Cancelled"}, gridDisbursement, DevExpress.Utils.HorzAlignment.Center)
        XgridGeneralSummaryCurrency({"Amount"}, gridDisbursement)
        gridDisbursement.BestFitColumns()
    End Sub

    Private Sub Em_disbursement_DoubleClick(sender As Object, e As EventArgs) Handles Em_disbursement.DoubleClick
        frmVoucherInfo.mode.Text = ""
        frmVoucherInfo.id.Text = gridDisbursement.GetFocusedRowCellValue("id").ToString
        frmVoucherInfo.mode.Text = "edit"
        If frmVoucherInfo.Visible = False Then
            frmVoucherInfo.Show(Me)
        Else
            frmVoucherInfo.WindowState = FormWindowState.Normal
        End If
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

                ElseIf status = "APPROVED" Then
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

    Private Sub cmdSaveFolio_Click(sender As Object, e As EventArgs) Handles cmdSaveAsDraft.Click
        If SecurityCheck() = True Then
            If Val(CC(txtSourceAmount.EditValue)) > 0 And Val(CC(txtSourceAmount.EditValue)) > Val(CC(GridView1.Columns("Total Cost").SummaryText)) Then
                XtraMessageBox.Show("Source of fund and request item doesn't match!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            ElseIf Val(CC(GridView1.Columns("Total Cost").SummaryText)) > txtSourceAmount.EditValue Then
                XtraMessageBox.Show("Insufficient allocated budget source! Please reduce amount", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
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
                XtraMessageBox.Show("Please select from budget source!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            ElseIf GridView1.RowCount = 0 Then
                XtraMessageBox.Show("Please select request particular item!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            ElseIf Val(CC(txtSourceAmount.EditValue)) > 0 And Val(CC(txtSourceAmount.EditValue)) > Val(CC(GridView1.Columns("Total Cost").SummaryText)) Then
                XtraMessageBox.Show("Source of fund and request item doesn't match!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            ElseIf Val(CC(GridView1.Columns("Total Cost").SummaryText)) > txtSourceAmount.EditValue Then
                XtraMessageBox.Show("Insufficient allocated budget source! Please reduce amount", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub

            End If

            Dim cnt As Integer = 0 : Dim requiredAttachment As String = "This request requires an attachment to proceed! Please provide attachment below:" & Environment.NewLine & Environment.NewLine
            com.CommandText = "select (select description from tbldocumenttype where code=tblapprovingattachment.doccode) as document from tblapprovingattachment where trncode='" & requesttype.Text & "' and appid='-' and doccode not in (SELECT b.docname FROM `tblrequisitionfiles` as a inner join lgufiledir.tblattachmentlogs as b on a.filecode=b.filecode and a.pid=b.refnumber where pid='" & pid.Text & "' and a.applevel='0' and a.requesttype='" & requesttype.Text & "' )" : rst = com.ExecuteReader
            While rst.Read
                cnt += 1
                requiredAttachment += cnt & ". " & rst("document").ToString & Environment.NewLine

            End While
            rst.Close()
            If countqry("tblapprovingattachment", "trncode='" & requesttype.Text & "' and appid='-'") > 0 Then
                If cnt > 0 Then
                    XtraMessageBox.Show(requiredAttachment, GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
            End If

            If DirectApproved Then
                If XtraMessageBox.Show("Make sure you want to proceed for DV preparation?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
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
                        com.CommandText = "insert into tblapprovalhistory set apptype='requisition', trncode='" & requesttype.Text & "',fundcode='" & fundcode.Text & "', mainreference='" & pid.Text & "', subreference='" & pid.Text & "', status='Processed', remarks='" & rchar(frmApprovalConfirmation.txtRemarks.Text) & "', applevel=0, officeid='" & compOfficeid & "', confirmid='" & globaluserid & "', confirmby='" & globalfullname & "', position='" & globalposition & "', dateconfirm=current_timestamp,finalapprover=0" : com.ExecuteNonQuery()
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

    Private Sub txtStatus_EditValueChanged(sender As Object, e As EventArgs) Handles txtStatus.EditValueChanged
        If txtStatus.Text = "PENDING" Or txtStatus.Text = "FOR APPROVAL" Or txtStatus.Text = "ON HOLD" Or txtStatus.Text = "NEW REQUEST" Then
            txtStatus.BackColor = Color.Orange
            txtStatus.ForeColor = Color.Black

        ElseIf txtStatus.Text = "DRAFT" Then
            txtStatus.BackColor = Color.LightGray
            txtStatus.ForeColor = Color.Black

        ElseIf txtStatus.Text = "APPROVED" Then
            txtStatus.BackColor = Color.Green
            txtStatus.ForeColor = Color.Black

        ElseIf txtStatus.Text = "DISBURSED" Then
            txtStatus.BackColor = Color.Gold
            txtStatus.ForeColor = Color.Black

        ElseIf txtStatus.Text = "CANCELLED" Then
            txtStatus.BackColor = Color.Red
            txtStatus.ForeColor = Color.White
        End If
    End Sub
     
    Private Sub AddItemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles cmdAddItem.Click
        If SecurityCheck() = True Then
            If Val(CC(txtSourceAmount.Text)) = 0 Then
                XtraMessageBox.Show("Please select from budget source!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
            frmSelectRequestItem.ShowDialog(Me)
        End If
    End Sub

    Private Sub cmdPrintPR_Click(sender As Object, e As EventArgs) Handles cmdPrintPR.Click
        If requestno.Text = "" Then
            XtraMessageBox.Show("Current request current not saved! Please save before continue printing", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        frmPurchaseRequest.pid.Text = pid.Text
        frmPurchaseRequest.txtPRNumber.Text = requestno.Text
        frmPurchaseRequest.officeid.Text = officeid.Text
        frmPurchaseRequest.txtOffice.Text = txtOffice.Text
        frmPurchaseRequest.txtPurpose.Text = txtPurpose.Text
        frmPurchaseRequest.ShowDialog(Me)
    End Sub

    Private Sub cmdCreatePO_Click(sender As Object, e As EventArgs) Handles cmdCreatePO.Click
        If requestno.Text = "" Then
            XtraMessageBox.Show("Current request current not saved! Please save before continue printing", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        frmPurchaseOrder.pid.Text = pid.Text
        frmPurchaseOrder.periodcode.Text = periodcode.Text
        frmPurchaseOrder.txtPRNumber.Text = requestno.Text
        frmPurchaseOrder.txtPostingDate.Text = txtPostingDate.Text
        frmPurchaseOrder.ShowDialog(Me)
    End Sub

    Private Sub cmdAddfiles_Click(sender As Object, e As EventArgs) Handles cmdAddfiles.Click
        If SecurityCheck() = True Then
            frmSourceOfFund.pid.Text = pid.Text
            frmSourceOfFund.periodcode.Text = periodcode.Text
            frmSourceOfFund.officeid.Text = officeid.Text
            frmSourceOfFund.requestno.Text = requestno.Text
            frmSourceOfFund.ReadOnlyTrn = ReadOnlyTrn
            frmSourceOfFund.ShowDialog(Me)
        End If
    End Sub

    Private Sub cmdPrintObligation_Click(sender As Object, e As EventArgs) Handles cmdPrintObligation.Click
        If countqry("tblfund", "code='" & fundcode.Text & "' and template='FURS'") > 0 Then
            cmdPrintObligation.Text = "Print FURS"
            PrintFundUtilization(pid.Text, Me)
        ElseIf countqry("tblfund", "code='" & fundcode.Text & "' and template='CAFOA'") > 0 Then
            PrintObligation(pid.Text, Me)
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