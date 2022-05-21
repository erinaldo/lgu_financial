Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System.Drawing
Imports System.IO
Imports System.Drawing.Printing
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Base

Public Class frmRequisitionList
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean

        Return ProcessCmdKey
    End Function

    Private Sub frmRequisitionList_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Dispose()
    End Sub

    Private Sub frmRequisitionList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = ico : ApplySystemTheme(ToolStrip1)
        txtDateFrom.EditValue = CDate(Now)
        txtDateTo.EditValue = CDate(Now)
        LoadOffice()
        officeid.Text = compOfficeid
        txtOffice.EditValue = compOfficeid
        If globalSpecialApprover Then
            lbloffice.Visible = True
            txtOffice.Visible = True
            ckViewAllOffice.Visible = True
            ckViewAllOffice.Checked = True
        Else
            lbloffice.Visible = False
            txtOffice.Visible = False
            ckViewAllOffice.Visible = False
            ckViewAllOffice.Checked = False
        End If
        If globalRequestOverride Then
            cmdRequestOveride.Visible = True
            cmdReturnUnusedFund.Visible = True
        Else
            cmdRequestOveride.Visible = False
            cmdReturnUnusedFund.Visible = False
        End If
        LoadRequestType()
        LoadFund()
        ViewList()
        txtFund.EditValue = loadDefaultSelection(Me.Name, txtFund.Name)
    End Sub

    Public Sub LoadFund()
        LoadXgridLookupSearch("Select code, Description as 'Select'  from tblfund " & If(LCase(globalusername) = "root", "", " where code in (select fundcode from tblfundfilter where filtered_id='" & compOfficeid & "' and filtered_type='office')") & "  order by code asc", "tblfund", txtFund, gridFund)
        XgridHideColumn({"code"}, gridFund)
    End Sub

    Public Sub LoadOffice()
        LoadXgridLookupSearch("select officeid as code,officename as 'Select' from tblcompoffice where deleted=0 order by officename asc", "tblcompoffice", txtOffice, gridOffice)
        gridOffice.Columns("code").Visible = False
    End Sub

    Private Sub txtOffice_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtOffice.EditValueChanged
        On Error Resume Next
        officeid.Text = txtOffice.Properties.View.GetFocusedRowCellValue("code").ToString()
        ViewList()
    End Sub


    Public Sub LoadRequestType()
        LoadXgridLookupSearch("select code,description as 'Select' from tblrequisitiontype  order by description asc", "tblrequisitiontype", txtRequestType, gridRequestType)
        gridRequestType.Columns("code").Visible = False
    End Sub

    Private Sub txtSearchBar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSearchBar.KeyPress
        If e.KeyChar() = Chr(13) Then
            If txtSearchBar.Text = "" Then Exit Sub
            ViewList()
        End If

    End Sub

    Public Sub ViewList()
        If radFilter.EditValue Is Nothing Then Exit Sub
        Dim KeyWordSearch As String = ""
        If txtSearchBar.Text = "" Then
            If radFilter.EditValue = "pending" Then
                KeyWordSearch = " and cleared=0 and cancelled=0 "
            ElseIf radFilter.EditValue = "cancelled" Then
                KeyWordSearch = " and cancelled=1 "
            ElseIf radFilter.EditValue = "cleared" Then
                KeyWordSearch = " and cleared=1 and cancelled=0 "
            ElseIf radFilter.EditValue = "date" Then
                KeyWordSearch = " and date_format(postingdate,'%Y-%m-%d') between '" & ConvertDate(txtDateFrom.EditValue) & "' and '" & ConvertDate(txtDateTo.EditValue) & "' "
            End If
        Else
            KeyWordSearch = " and (pid like '%" & rchar(txtSearchBar.Text) & "%' or " _
                        + " requestno like '%" & rchar(txtSearchBar.Text) & "%' or " _
                        + " postingdate like '%" & rchar(txtSearchBar.Text) & "%' or " _
                        + " (select description from tblrequisitiontype where code=a.requesttype) like '%" & rchar(txtSearchBar.Text) & "%' or " _
                        + " (select suppliername from tblsupplier where supplierid=a.payee) like '%" & rchar(txtSearchBar.Text) & "%' or " _
                        + " Purpose like '%" & rchar(txtSearchBar.Text) & "%')"
        End If
        LoadXgrid("SELECT pid as 'Entry Code', periodcode, (select if(enablevoucher,true,false) from tblrequisitiontype where code=a.requesttype) as RequiredVoucher, " _
                        + " if(cancelled,'CANCELLED',if(cleared, if((select if(enablevoucher,true,false) from tblrequisitiontype where code=a.requesttype),  'CHECK RELEASED',  'CLEARED'), if(voucher,if(paid,'CHECK ISSUED','FOR CHECK ISSUANCE'),if(approved,'APPROVED',if(draft,'DRAFT',if(hold,'HOLD',if(forapproval,'FOR APPROVAL','-'))))))) as Status, " _
                        + " requestno as 'Request No.', " _
                        + " (select description from tblrequisitiontype where code=a.requesttype) as 'Request Type' ," _
                        + " concat((select codename from tblfund where code=a.fundcode),'-',yeartrn) as 'Fund Period',  " _
                        + " date_format(postingdate,'%Y-%m-%d') as 'Posting Date', " _
                        + " (select officename from tblcompoffice where officeid = a.officeid) as 'Office', " _
                        + " (select fullname from tblaccounts where accountid=a.requestedby) as 'Requested By', " _
                        + " (select sum(amount) from tblrequisitionfund where pid=a.pid) as 'Amount', " _
                        + " Purpose, " _
                        + " Priority, " _
                        + " (select suppliername from tblsupplier where supplierid=a.payee) as 'Payee', " _
                        + " (select fullname from tblaccounts where accountid=a.trnby) as 'Posted By', " _
                        + " date_format(datetrn,'%Y-%m-%d') as 'Date Posted', " _
                        + " Draft, " _
                        + " ForApproval, " _
                        + " Hold, " _
                        + " Cleared, " _
                        + " Paid as Voucher, " _
                        + " JEV, " _
                        + " if(headofficeapproval=1,'OFFICE HEAD', (select officename from tblcompoffice where officeid=a.currentapprover) ) as 'Current Approver', " _
                        + " (select officename from tblcompoffice where officeid=a.nextapprover) as 'Next Approver', " _
                        + " Approved, date_format(dateapproved,'%Y-%m-%d') as 'Date Approved', " _
                        + " if(Approved=1,if(checkapproved=1,'APPROVED','PENDING'),'') as 'Check Issuance', " _
                        + " Cancelled, " _
                        + " date_format(datecancelled,'%Y-%m-%d') as 'Date Cancelled' " _
                        + " FROM tblrequisition as a " _
                        + " where fundcode='" & txtFund.EditValue & "'  " _
                        + KeyWordSearch _
                        + If(ckViewAllOffice.Checked, "", " and officeid='" & officeid.Text & "' ") _
                        + If(ckAllType.Checked, "", " and requesttype='" & txtRequestType.EditValue & "' ") _
                        + If(globalDepartmentHead Or globalSpecialApprover, "", " and trnby='" & globaluserid & "' ") _
                        + " order by datetrn desc", "tblrequisition", Em, GridView1, Me)

        XgridColCurrency({"Amount"}, GridView1)

        XgridColAlign({"Entry Code", "Current Approver", "Next Approver", "Status", "Fund Period", "Posting Date", "Date Posted", "Draft", "ForApproval", "Hold", "Approved", "Date Approved", "Check Issuance", "Cancelled", "Date Cancelled"}, GridView1, DevExpress.Utils.HorzAlignment.Center)
        XgridGeneralSummaryCurrency({"Amount"}, GridView1)
        GridView1.BestFitColumns()
        DXgridColumnIndexing(Me.Name, GridView1)
        XgridHideColumn({"periodcode", "RequiredVoucher"}, GridView1)
        XgridColWidth({"Purpose"}, GridView1, 300)
        'XgridColMemo({"Purpose"}, GridView1)
        SaveFilterColumn(GridView1, Me.Name)
        SaveDefaultSelection(Me.Name, txtFund.Name, txtFund.EditValue)
    End Sub

    Private Sub gridview1_RowCellStyle(ByVal sender As Object, ByVal e As RowCellStyleEventArgs) Handles GridView1.RowCellStyle
        Dim View As GridView = sender
        Dim status As String = View.GetRowCellDisplayText(e.RowHandle, View.Columns("Status"))
        Dim requiredVoucher As Boolean = CBool(View.GetRowCellDisplayText(e.RowHandle, View.Columns("RequiredVoucher")))

        If requiredVoucher Then
            cmdClearedRequisition.Visible = False
        Else
            cmdClearedRequisition.Visible = True
        End If

        If status = "CANCELLED" Then
            e.Appearance.ForeColor = Color.Red
            e.Appearance.Font = New Font(gen_fontfamily, gen_FontSize, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, (CByte(204)))
        Else
            If e.Column.Name = "colStatus" Then
                If status = "FOR APPROVAL" Then
                    e.Appearance.BackColor = Color.Orange
                    e.Appearance.BackColor2 = Color.Orange
                    e.Appearance.ForeColor = Color.Black

                ElseIf status = "FOR CHECK ISSUANCE" Then
                    e.Appearance.BackColor = Color.Khaki
                    e.Appearance.BackColor2 = Color.Khaki
                    e.Appearance.ForeColor = Color.Black

                ElseIf status = "DRAFT" Then
                    e.Appearance.BackColor = Color.LightGray
                    e.Appearance.BackColor2 = Color.LightGray
                    e.Appearance.ForeColor = Color.Black

                ElseIf status = "HOLD" Then
                    e.Appearance.BackColor = Color.Red
                    e.Appearance.BackColor2 = Color.Red
                    e.Appearance.ForeColor = Color.White

                ElseIf status = "CHECK ISSUED" Then
                    e.Appearance.BackColor = Color.LightSkyBlue
                    e.Appearance.BackColor2 = Color.LightSkyBlue
                    e.Appearance.ForeColor = Color.Black

                ElseIf status = "CHECK RELEASED" Or status = "CLEARED" Then
                    e.Appearance.BackColor = Color.Gold
                    e.Appearance.BackColor2 = Color.Gold
                    e.Appearance.ForeColor = Color.Black

                ElseIf status = "APPROVED" Then
                    e.Appearance.BackColor = Color.Green
                    e.Appearance.BackColor2 = Color.Green
                    e.Appearance.ForeColor = Color.White
                End If
            End If
        End If


        If e.Column.Name = "colPriority" Then
            Dim priority As String = View.GetRowCellDisplayText(e.RowHandle, View.Columns("Priority"))
            If priority = "Emergency" Then
                e.Appearance.BackColor = Color.Red
                e.Appearance.BackColor2 = Color.Red
                e.Appearance.ForeColor = Color.White
            End If
        End If

        If e.Column.Name = "colCheckIssuance" Then
            Dim check As String = View.GetRowCellDisplayText(e.RowHandle, View.Columns("Check Issuance"))
            If check = "APPROVED" Then
                e.Appearance.ForeColor = Color.Green
            ElseIf check = "PENDING" Then
                e.Appearance.ForeColor = Color.Orange
            End If
        End If

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
        DXExportGridToExcel(If(txtRequestType.Text = "", "", txtRequestType.Text & " ") & Me.Text, GridView1)
    End Sub

    Private Sub cmdNew_Click(sender As Object, e As EventArgs) Handles cmdNewProperty.Click
        If globalAllowAdd = False Then
            XtraMessageBox.Show("Your access not allowed to add!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        frmRequisitionInfo.mode.Text = "new"
        If frmRequisitionInfo.Visible = True Then
            frmRequisitionInfo.Focus()
        Else
            frmRequisitionInfo.Show(Me)
        End If
    End Sub

    Private Sub cmdLocalData_Click(sender As Object, e As EventArgs) Handles cmdLocalData.Click
        ViewList()
    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        If globalAllowDelete = False Then
            XtraMessageBox.Show("Your access not allowed to delete!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        ElseIf CBool(GridView1.GetFocusedRowCellValue("Cancelled").ToString) Then
            XtraMessageBox.Show("Selected request is already cancelled!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        ElseIf getCurrentTransactionMonth(GridView1.GetFocusedRowCellValue("periodcode").ToString) = "" Then
            XtraMessageBox.Show("Period " & GridView1.GetFocusedRowCellValue("periodcode").ToString & " is already closed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If CBool(GridView1.GetFocusedRowCellValue("Approved").ToString) Then
            frmApprovalConfirmation.RequiredAdminOveride = True
        Else
            frmApprovalConfirmation.RequiredAdminOveride = False
        End If

        frmApprovalConfirmation.mode.Text = "cancel"
        frmApprovalConfirmation.ShowDialog(Me)
        If frmApprovalConfirmation.TransactionDone = True Then
            For I = 0 To GridView1.SelectedRowsCount - 1
                CancelRequisition(GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "Entry Code"), frmApprovalConfirmation.txtRemarks.Text)
            Next
            ViewList()
            frmApprovalConfirmation.Close()
            XtraMessageBox.Show("Requisition successfully cancelled!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Information)

            frmApprovalConfirmation.TransactionDone = False
            frmApprovalConfirmation.Dispose()
        End If

    End Sub

    Private Sub cmdView_Click(sender As Object, e As EventArgs) Handles cmdView.Click
        frmRequisitionInfo.mode.Text = ""
        frmRequisitionInfo.pid.Text = GridView1.GetFocusedRowCellValue("Entry Code").ToString
        frmRequisitionInfo.mode.Text = "edit"
        If frmRequisitionInfo.Visible = False Then
            frmRequisitionInfo.Show(Me)
        Else
            frmRequisitionInfo.WindowState = FormWindowState.Normal
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

    Private Sub cmdFilterSearch_Click(sender As Object, e As EventArgs) Handles cmdFilterSearch.Click
        ViewList()
    End Sub

    Private Sub Em_DoubleClick(sender As Object, e As EventArgs) Handles Em.DoubleClick
        frmRequisitionInfo.mode.Text = ""
        frmRequisitionInfo.pid.Text = GridView1.GetFocusedRowCellValue("Entry Code").ToString
        frmRequisitionInfo.mode.Text = "edit"
        If frmRequisitionInfo.Visible = False Then
            frmRequisitionInfo.Show(Me)
        Else
            frmRequisitionInfo.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub ckViewAllOffice_CheckedChanged(sender As Object, e As EventArgs) Handles ckViewAllOffice.CheckedChanged
        If ckViewAllOffice.Checked = True Then
            txtOffice.Enabled = False
            txtOffice.EditValue = Nothing
        Else
            txtOffice.Enabled = True
        End If
    End Sub

    Private Sub ckAllType_CheckedChanged(sender As Object, e As EventArgs) Handles ckAllType.CheckedChanged
        If ckAllType.Checked = True Then
            txtRequestType.Enabled = False
        Else
            txtRequestType.Enabled = True
        End If
        ViewList()
    End Sub

    Private Sub cmdDuplicate_Click(sender As Object, e As EventArgs) Handles cmdDuplicate.Click
        If globalAllowAdd = False Then
            XtraMessageBox.Show("Your access not allowed to add!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        frmRequisitionInfo.mode.Text = "duplicate"
        frmRequisitionInfo.duplicateid.Text = GridView1.GetFocusedRowCellValue("Entry Code").ToString
        If frmRequisitionInfo.Visible = True Then
            frmRequisitionInfo.Focus()
        Else
            frmRequisitionInfo.Show(Me)
        End If
    End Sub

    Private Sub cmdRequestOveride_Click(sender As Object, e As EventArgs) Handles cmdRequestOveride.Click
        If CBool(GridView1.GetFocusedRowCellValue("ForApproval").ToString) = False Then
            XtraMessageBox.Show("Only for approval request can be override!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        frmRequisitionInfo.mode.Text = ""
        frmRequisitionInfo.pid.Text = GridView1.GetFocusedRowCellValue("Entry Code").ToString
        frmRequisitionInfo.mode.Text = "edit"
        frmRequisitionInfo.RequestOveride = True
        If frmRequisitionInfo.Visible = False Then
            frmRequisitionInfo.Show(Me)
        Else
            frmRequisitionInfo.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub ClearedRequisitionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles cmdClearedRequisition.Click
        If globalSpecialApprover = False And globalRootUser = False Then
            XtraMessageBox.Show("Your access not allowed to clear transaction!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        If XtraMessageBox.Show("Are you sure you want to continue?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
            Dim message As String = ""
            For I = 0 To GridView1.SelectedRowsCount - 1
                If countqry("tblrequisition", "approved=1 and cleared=0 and pid='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "Entry Code") & "'") > 0 Or CBool(GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "RequiredVoucher")) = False Then
                    com.CommandText = "update tblrequisition set cleared=1 where pid='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "Entry Code") & "'" : com.ExecuteNonQuery()
                Else
                    message += GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "Request No.") & Environment.NewLine
                End If
            Next
            If message.Length > 0 Then
                ViewList()
                XtraMessageBox.Show("Some selected request successfully cleared! " & Environment.NewLine & "But requisition listed below are not valid for clearing" & Environment.NewLine & Environment.NewLine & message, "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                ViewList()
                XtraMessageBox.Show("Selected request successfully cleared!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub cmdReturnUnusedFund_Click(sender As Object, e As EventArgs) Handles cmdReturnUnusedFund.Click
        If CBool(GridView1.GetFocusedRowCellValue("Cleared").ToString) = False Then
            XtraMessageBox.Show("Only cleared request can be return fund!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub

        ElseIf getCurrentTransactionMonth(GridView1.GetFocusedRowCellValue("periodcode").ToString) = "" Then
            XtraMessageBox.Show("Period " & GridView1.GetFocusedRowCellValue("periodcode").ToString & " is already closed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub

        End If
        frmRequisitionFundReturn.pid.Text = GridView1.GetFocusedRowCellValue("Entry Code").ToString
        If frmRequisitionFundReturn.Visible = True Then
            frmRequisitionFundReturn.Focus()
        Else
            frmRequisitionFundReturn.ShowDialog(Me)
        End If
    End Sub

    Private Sub radFilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles radFilter.SelectedIndexChanged
        If radFilter.EditValue = "date" Then
            txtDateFrom.Enabled = True
            txtDateTo.Enabled = True
        Else
            txtDateFrom.Enabled = False
            txtDateTo.Enabled = False
        End If
        ViewList()
    End Sub

    Private Sub txtFund_EditValueChanged(sender As Object, e As EventArgs) Handles txtFund.EditValueChanged
        If txtFund.EditValue = "" Then Exit Sub
        ViewList()
    End Sub

    Private Sub txtRequestType_EditValueChanged(sender As Object, e As EventArgs) Handles txtRequestType.EditValueChanged
        If txtRequestType.EditValue.ToString = "" Then Exit Sub
        ViewList()
    End Sub
End Class