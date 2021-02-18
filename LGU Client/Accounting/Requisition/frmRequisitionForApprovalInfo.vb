Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo

Public Class frmRequisitionForApprovalInfo
    Private BandgridView As GridView
    Private HeadOfficeApproval As Boolean = False
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    'Private Sub frmRequisitionInfo_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
    '    Me.Dispose()
    'End Sub

    Private Sub ffrmRequisitionInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico
        ApplySystemTheme(ToolStrip1)
        ShowApprovalInfo()
    End Sub

    Public Sub ShowApprovalInfo()
        ShowRequisitionInfo()
        LoadItem()
        LoadSource()
        LoadFiles()
        ApprovingHistory()
        LoadApproverDeatils()
        If approval.Text = "check" Then
            lineHold.Visible = False
            cmdHoldRequest.Visible = False
            cmdApprove.Text = "Approve for Check Issuance"
        Else
            cmdApprove.Text = "Approve Request"
        End If
    End Sub
    Public Sub LoadSource()
        LoadXgrid("select id,itemcode as 'Item Code', (select itemname from tblglitem where itemcode=a.itemcode) as 'Item Name', Amount, prevbalance as 'Prev Balance',newbalance as 'New Balance' from tblrequisitionfund as a where pid='" & pid.Text & "'", "tblrequisitionfund", Em_SourceFund, gridSourceFund, Me)
        XgridHideColumn({"id"}, gridSourceFund)
        XgridColAlign({"Item Code"}, gridSourceFund, DevExpress.Utils.HorzAlignment.Center)
        XgridColCurrency({"Amount", "Prev Balance", "New Balance"}, gridSourceFund)
        XgridGeneralSummaryCurrency({"Amount"}, gridSourceFund)
        gridSourceFund.BestFitColumns()
    End Sub

    Public Sub LoadApproverDeatils()
        com.CommandText = "select * from tblapprovingprocess where apptype='requisition-approving-process' and trncode='" & requesttype.Text & "' and fundcode='" & fundcode.Text & "' and applevel=ifnull((select applevel+1 from tblapprovalhistory where apptype='requisition' and trncode='" & requesttype.Text & "' and fundcode='" & fundcode.Text & "' and mainreference='" & pid.Text & "' and applevel > 0 order by applevel desc limit 1),1)" : rst = com.ExecuteReader
        While rst.Read
            appid.Text = rst("id").ToString
            If HeadOfficeApproval = True Then
                ckFinalApprover.Checked = False
            Else
                ckFinalApprover.Checked = CBool(rst("finalapp"))
            End If
            CurrentLevel.Text = rst("applevel").ToString
            If ckFinalApprover.Checked = True Then
                CurrentApprover.Text = ""
            Else
                CurrentApprover.Text = rst("officeid").ToString
            End If
        End While
        rst.Close()
        com.CommandText = "select * from tblapprovingprocess where apptype='requisition-approving-process' and trncode='" & requesttype.Text & "' and fundcode='" & fundcode.Text & "'  and applevel=" & Val(CurrentLevel.Text) + 1 & "" : rst = com.ExecuteReader
        While rst.Read
            NextApprover.Text = rst("officeid").ToString
        End While
        rst.Close()
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

    End Sub

    Public Sub ShowRequisitionInfo()
        da = New MySqlDataAdapter("select *, concat(yeartrn,'-',(select Description from tblfund where code=a.fundcode)) as fundperiod , " _
                                  + " (select officename from tblcompoffice where officeid=a.officeid) as office, " _
                                  + " (select fullname from tblaccounts where accountid=a.requestedby) as 'requestby', " _
                                  + " (select suppliername from tblsupplier where supplierid=a.payee) as supplier, " _
                                  + " (select description from tblrequisitiontype where code=a.requesttype) as 'typerequest', " _
                                  + " (select sum(amount) from tblrequisitionfund where pid=a.pid) as sourceamount " _
                                  + " from tblrequisition as a where pid='" & pid.Text & "'", conn)
        da.Fill(st, 0)
        For cnt = 0 To st.Tables(0).Rows.Count - 1
            With (st.Tables(0))
                fundcode.Text = .Rows(cnt)("fundcode").ToString()
                requestno.Text = .Rows(cnt)("requestno").ToString()
                txtRequestNumber.Text = .Rows(cnt)("requestno").ToString()
                requesttype.Text = .Rows(cnt)("requesttype").ToString()
                officeid.Text = .Rows(cnt)("officeid").ToString()
                txtFund.EditValue = .Rows(cnt)("fundperiod").ToString()

                txtOffice.EditValue = .Rows(cnt)("office").ToString()
                txtRequestby.EditValue = .Rows(cnt)("requestby").ToString()
                txtPayee.Text = .Rows(cnt)("supplier").ToString()

                txtRequestType.EditValue = .Rows(cnt)("typerequest").ToString()
                txtPostingDate.EditValue = .Rows(cnt)("postingdate").ToString()
                txtPurpose.Text = .Rows(cnt)("purpose").ToString()
                txtPriority.EditValue = .Rows(cnt)("priority").ToString()
                txtSourceAmount.EditValue = .Rows(cnt)("sourceamount").ToString()
                HeadOfficeApproval = CBool(.Rows(cnt)("headofficeapproval").ToString())

                If CBool(.Rows(cnt)("approved").ToString()) = True Then
                    txtStatus.Text = "APPROVED"
                Else
                    If CBool(.Rows(cnt)("cancelled").ToString()) = True Then
                        txtStatus.Text = "CANCELLED"

                    ElseIf CBool(.Rows(cnt)("forapproval").ToString()) = True Then
                        txtStatus.Text = "FOR APPROVAL"

                    ElseIf CBool(.Rows(cnt)("draft").ToString()) = True Then
                        txtStatus.Text = "DRAFT"

                    ElseIf CBool(.Rows(cnt)("hold").ToString()) = True Then
                        txtStatus.Text = "ON HOLD"
                    End If
                End If
            End With
        Next
       
    End Sub

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

    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        cmdDocManager.PerformClick()
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

    Private Sub cmdChargeToClientAccount_Click(sender As Object, e As EventArgs) Handles cmdDocManager.Click
        If XtraMessageBox.Show("Make sure your scanned document are ready before proceeding" & Environment.NewLine & "attachment manager to avoid upload files cancellation! " & Environment.NewLine & Environment.NewLine & "Are you sure you want to continue? ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
            XtraTabControl1.SelectedTabPage = tabAttachment
            frmRequisitionDocManager.requesttype.Text = requesttype.Text
            frmRequisitionDocManager.applevel.Text = CurrentLevel.Text
            frmRequisitionDocManager.pid.Text = pid.Text
            If frmRequisitionDocManager.Visible = True Then
                frmRequisitionDocManager.Focus()
            Else
                frmRequisitionDocManager.Show(Me)
            End If
        End If
    End Sub

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub cmdApprove_Click(sender As Object, e As EventArgs) Handles cmdApprove.Click
        Dim cnt As Integer = 0 : Dim requiredAttachment As String = "This approval requires an attachment to proceed! Please provide attachment below:" & Environment.NewLine & Environment.NewLine
        com.CommandText = "select (select description from tbldocumenttype where code=tblapprovingattachment.doccode) as document from tblapprovingattachment where trncode='" & requesttype.Text & "' and appid='" & appid.Text & "' and doccode not in (SELECT b.docname FROM `tblrequisitionfiles` as a inner join lgufiledir.tblattachmentlogs as b on a.filecode=b.filecode and a.pid=b.refnumber where pid='" & pid.Text & "' and a.applevel='" & CurrentLevel.Text & "' and a.requesttype='" & requesttype.Text & "' )" : rst = com.ExecuteReader
        While rst.Read
            cnt += 1
            requiredAttachment += cnt & ". " & rst("document").ToString & Environment.NewLine

        End While
        rst.Close()
        If cnt > 0 Then
            XtraMessageBox.Show(requiredAttachment, GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        frmApprovalConfirmation.mode.Text = "approved"
        frmApprovalConfirmation.ShowDialog(Me)
        If frmApprovalConfirmation.TransactionDone = True Then
            If approval.Text = "check" Then
                com.CommandText = "insert into tblapprovalhistory set apptype='requisition', trncode='" & requesttype.Text & "',fundcode='" & fundcode.Text & "' , mainreference='" & pid.Text & "', subreference='" & pid.Text & "', status='approved', remarks='" & rchar(frmApprovalConfirmation.txtRemarks.Text) & "', applevel=0, officeid='" & compOfficeid & "', confirmid='" & globaluserid & "', confirmby='" & globalfullname & "', position='" & globalposition & "', dateconfirm=current_timestamp,finalapprover=0" : com.ExecuteNonQuery()
                com.CommandText = "update tblrequisition set checkapproved=1 where pid='" & pid.Text & "'" : com.ExecuteNonQuery()

                If frmForApprovalCheckReleasing.Visible = True Then
                    frmForApprovalCheckReleasing.ViewList()
                End If
                frmApprovalConfirmation.TransactionDone = False
                frmApprovalConfirmation.Dispose()
                MainForm.Notification()
                XtraMessageBox.Show("Check issuance request successfully approved!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            Else
                com.CommandText = "insert into tblapprovalhistory set apptype='requisition', trncode='" & requesttype.Text & "', fundcode='" & fundcode.Text & "',  mainreference='" & pid.Text & "', subreference='" & pid.Text & "', status='Approved', remarks='" & rchar(frmApprovalConfirmation.txtRemarks.Text) & "', applevel='" & If(HeadOfficeApproval, "0", CurrentLevel.Text) & "', officeid='" & compOfficeid & "', confirmid='" & globaluserid & "', confirmby='" & globalfullname & "', position='" & globalposition & "', dateconfirm=current_timestamp,finalapprover=" & ckFinalApprover.CheckState & "" : com.ExecuteNonQuery()

                If ckFinalApprover.Checked = True Then
                    com.CommandText = "update tblrequisition set headofficeapproval=0, forapproval=0, approved=1, currentapprover='', nextapprover='', dateapproved=current_timestamp where pid='" & pid.Text & "'" : com.ExecuteNonQuery()
                Else
                    Dim newlevel As Integer : Dim newapprover As String = ""
                    If HeadOfficeApproval Then
                        com.CommandText = "select * from tblapprovingprocess where apptype='requisition-approving-process' and trncode='" & requesttype.Text & "' and fundcode='" & fundcode.Text & "' and applevel=" & Val(CurrentLevel.Text) & " " : rst = com.ExecuteReader
                    Else
                        com.CommandText = "select * from tblapprovingprocess where apptype='requisition-approving-process' and trncode='" & requesttype.Text & "' and fundcode='" & fundcode.Text & "' and applevel=" & Val(CurrentLevel.Text) + 1 & " " : rst = com.ExecuteReader
                    End If

                    While rst.Read
                        newlevel = rst("applevel").ToString
                        newapprover = rst("officeid").ToString
                    End While
                    rst.Close()

                    Dim nextApproval As String = ""
                    com.CommandText = "select * from tblapprovingprocess where apptype='requisition-approving-process' and trncode='" & requesttype.Text & "' and fundcode='" & fundcode.Text & "'  and applevel=" & Val(newlevel) + 1 & "" : rst = com.ExecuteReader
                    While rst.Read
                        nextApproval = rst("officeid").ToString
                    End While
                    rst.Close()

                    com.CommandText = "update tblrequisition set headofficeapproval=0, currentlevel='" & newlevel & "', currentapprover='" & newapprover & "', nextapprover='" & nextApproval & "' where pid='" & pid.Text & "'" : com.ExecuteNonQuery()
                End If

                If frmForApprovalRequisition.Visible = True Then
                    frmForApprovalRequisition.ViewList()
                End If

                frmApprovalConfirmation.TransactionDone = False
                frmApprovalConfirmation.Dispose()
                MainForm.Notification()
                XtraMessageBox.Show("Requisition successfully approved!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            End If
        End If

    End Sub

    Private Sub txtStatus_EditValueChanged(sender As Object, e As EventArgs) Handles txtStatus.EditValueChanged
        If txtStatus.Text = "PENDING" Or txtStatus.Text = "FOR APPROVAL" Or txtStatus.Text = "DRAFT" Or txtStatus.Text = "ON HOLD" Then
            txtStatus.BackColor = Color.Orange
            txtStatus.ForeColor = Color.Black

        ElseIf txtStatus.Text = "APPROVED" Then
            txtStatus.BackColor = Color.Green
            txtStatus.ForeColor = Color.White

        ElseIf txtStatus.Text = "CANCELLED" Then
            txtStatus.BackColor = Color.Red
            txtStatus.ForeColor = Color.White
        End If
    End Sub


    Private Sub cmdHoldRequest_Click(sender As Object, e As EventArgs) Handles cmdHoldRequest.Click
        frmApprovalConfirmation.ShowDialog(Me)
        If frmApprovalConfirmation.TransactionDone = True Then
            com.CommandText = "insert into tblapprovalhistory set apptype='requisition', trncode='" & requesttype.Text & "',fundcode='" & fundcode.Text & "' , mainreference='" & pid.Text & "', subreference='" & pid.Text & "', status='Hold', remarks='" & rchar(frmApprovalConfirmation.txtRemarks.Text) & "', applevel=0, officeid='" & compOfficeid & "', confirmid='" & globaluserid & "', confirmby='" & globalfullname & "', position='" & globalposition & "', dateconfirm=current_timestamp,finalapprover=0" : com.ExecuteNonQuery()
            com.CommandText = "update tblrequisition set forapproval=0, hold=1 where pid='" & pid.Text & "'" : com.ExecuteNonQuery()

            If frmForApprovalRequisition.Visible = True Then
                frmForApprovalRequisition.ViewList()
            End If

            frmApprovalConfirmation.TransactionDone = False
            frmApprovalConfirmation.Dispose()
            MainForm.Notification()
            XtraMessageBox.Show("Requisition successfully hold!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        End If
    End Sub

    Private Sub pid_EditValueChanged(sender As Object, e As EventArgs) Handles pid.EditValueChanged
        ShowApprovalInfo()
    End Sub
End Class