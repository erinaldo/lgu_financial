Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraSplashScreen

Public Class frmVoucherInfo
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmVoucherInfo_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub
    Private Sub frmHotelGroupCheckin_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If countqry("tbldisbursementvoucher", "voucherno='" & voucherno.Text & "'") = 0 And (Gridview1.RowCount > 0 Or gridRequisition.RowCount > 0) Then
            If XtraMessageBox.Show("System found transaction currently not validated! Are you sure you want to cancel current transaction?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
                com.CommandText = "delete from tbldisbursementvoucheritem where voucherno='" & voucherno.Text & "'" : com.ExecuteNonQuery()
                com.CommandText = "UPDATE tblrequisition set paid=0 where pid in (select pid from tbldisbursementdetails where voucherno='" & voucherno.Text & "')" : com.ExecuteNonQuery()
                com.CommandText = "DELETE FROM tbldisbursementdetails where voucherno='" & voucherno.Text & "'" : com.ExecuteNonQuery()
            Else
                e.Cancel = True
            End If
        End If

    End Sub
    
    Private Sub frmBudgetVoucherInfo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = ico
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        LoadFund()
        LoadSupplier()
        If mode.Text <> "edit" Then
            CreateControlNumber()
            cmdSave.Text = "Save Voucher"
        Else
            ShowVoucherInfo()
        End If
        LoadDisbursementItem()
        LoadVoucherExpenses()
        SplashScreenManager.CloseForm()
    End Sub

    Public Sub LoadFund()
        LoadXgridLookupSearch("SELECT periodcode as code,fundcode,yeartrn, concat(yeartrn,'-',(select Description from tblfund where code=tblfundperiod.fundcode)) as 'Select'  from tblfundperiod where closed=0 order by yeartrn asc", "tblfundperiod", txtFund, gridFund)
        XgridHideColumn({"code", "fundcode", "yeartrn"}, gridFund)
    End Sub
    Private Sub txtFund_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFund.EditValueChanged
        On Error Resume Next
        periodcode.Text = txtFund.Properties.View.GetFocusedRowCellValue("code").ToString()
        fundcode.Text = txtFund.Properties.View.GetFocusedRowCellValue("fundcode").ToString()
        yearcode.Text = txtFund.Properties.View.GetFocusedRowCellValue("yeartrn").ToString()
    End Sub

    Public Sub ShowVoucherInfo()
        Dim budgettitle As String = ""
        com.CommandText = "select * from tbldisbursementvoucher as a where id='" & id.Text & "'" : rst = com.ExecuteReader
        While rst.Read
            txtFund.EditValue = rst("periodcode").ToString
            seriesno.Text = rst("seriesno").ToString
            yearcode.Text = rst("yearcode").ToString
            yeartrn.Text = rst("yeartrn").ToString
            txtVoucherDate.EditValue = rst("voucherdate").ToString
            voucherno.Text = rst("voucherno").ToString
            txtSupplier.EditValue = rst("supplierid").ToString
            fundcode.Text = rst("fundcode").ToString
            periodcode.Text = rst("periodcode").ToString
            radPaymentType.EditValue = rst("typeofpayment").ToString
            txtRequisitionAmount.EditValue = rst("amount").ToString
            txtVoucherAmount.EditValue = rst("amount").ToString
            If CBool(rst("cleared")) = True Or CBool(rst("cancelled")) = True Then
                mode.Text = "view"
                InfoControl(True)
            Else
                InfoControl(False)
            End If
        End While
        rst.Close()

    End Sub

    Public Function InfoControl(ByVal readonlyform As Boolean)
        txtFund.ReadOnly = readonlyform
        txtVoucherDate.ReadOnly = readonlyform
        radPaymentType.ReadOnly = readonlyform
        txtSupplier.ReadOnly = readonlyform

        If readonlyform = True Then
            Em.ContextMenuStrip = Nothing
            Em_requisition.ContextMenuStrip = Nothing
            cmdSave.Text = "Close Window"
        Else
            Em.ContextMenuStrip = ContexExplaination
            Em_requisition.ContextMenuStrip = ContextRequisition
            cmdSave.Text = "Save Voucher"
        End If
    End Function


    Public Sub CreateControlNumber()
        If txtVoucherDate.Text <> "" Then
            yeartrn.Text = CDate(txtVoucherDate.EditValue).ToString("yy")
            Dim vno As String = getVoucherNumber(yeartrn.Text, "tbldisbursementvoucher")
            voucherno.Text = fundcode.Text & "-" & yeartrn.Text & "-" & CDate(txtVoucherDate.EditValue).ToString("MM") & "-" & vno
            seriesno.Text = vno
        End If
    End Sub

    Public Sub LoadDisbursementItem()
        LoadXgrid("select id,Explaination, Amount from tbldisbursementvoucheritem where voucherno='" & voucherno.Text & "' ", "tbldisbursementvoucheritem", Em, Gridview1, Me)
        XgridHideColumn({"id"}, Gridview1)
        XgridColWidth({"Amount"}, Gridview1, 186)
        XgridColWidth({"Explaination"}, Gridview1, 450)
        Gridview1.Columns("Explaination").OptionsColumn.AllowEdit = False
        Gridview1.Columns("Explaination").OptionsColumn.AllowFocus = False

        Gridview1.Columns("Explaination").AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Gridview1.Columns("Explaination").ColumnEdit = MemoEdit
        XgridColCurrency({"Amount"}, Gridview1)
        XgridGeneralSummaryCurrency({"Amount"}, Gridview1)
        txtVoucherAmount.EditValue = Gridview1.Columns("Amount").SummaryText
    End Sub

    Public Sub LoadVoucherExpenses()
        LoadXgrid("select id, pid as 'Entry Code', date_format(postingdate,'%Y-%m-%d') as 'Date', requestno as 'Request No',(select officename from tblcompoffice where officeid=a.officeid) as 'Office', (select description from tblrequisitiontype where code=a.requesttype) as 'Request Type', Amount,Purpose from tbldisbursementdetails as a where voucherno='" & voucherno.Text & "' order by postingdate asc", "tbldisbursementdetails", Em_requisition, gridRequisition, Me)

        XgridHideColumn({"id"}, gridRequisition)
        XgridColAlign({"Entry Code", "Request No", "Request Type", "Date"}, gridRequisition, DevExpress.Utils.HorzAlignment.Center)
        XgridColCurrency({"Amount"}, gridRequisition)
        XgridGeneralSummaryCurrency({"Amount"}, gridRequisition)
        XgridColWidth({"Amount"}, gridRequisition, 100)
        txtRequisitionAmount.EditValue = gridRequisition.Columns("Amount").SummaryText
    End Sub

    Private Sub Em_requisition_DoubleClick(sender As Object, e As EventArgs) Handles Em_requisition.DoubleClick
        frmRequisitionInfo.mode.Text = ""
        frmRequisitionInfo.pid.Text = gridRequisition.GetFocusedRowCellValue("Entry Code").ToString
        frmRequisitionInfo.mode.Text = "edit"
        If frmRequisitionInfo.Visible = False Then
            frmRequisitionInfo.Show(Me)
        Else
            frmRequisitionInfo.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub cmdAddApprovedRequisition_Click(sender As Object, e As EventArgs) Handles cmdAddApprovedRequisition.Click
        If txtFund.Text = "" Then
            XtraMessageBox.Show("Please select fund ", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtFund.Focus()
            Exit Sub
        ElseIf txtVoucherDate.Text = "" Then
            XtraMessageBox.Show("Please select voucher date ", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtVoucherDate.Focus()
            Exit Sub
        End If
        frmVoucherRequisitionItem.voucherno.Text = voucherno.Text
        frmVoucherRequisitionItem.ShowDialog(Me)
    End Sub

    Private Sub cmdRemoveRequisition_Click(sender As Object, e As EventArgs) Handles cmdRemoveRequisition.Click
        If gridRequisition.RowCount = 0 Then
            XtraMessageBox.Show("There is no item selected! make sure, the selection is on the list", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        If XtraMessageBox.Show("Are you sure you want to continue?", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            For I = 0 To gridRequisition.SelectedRowsCount - 1
                com.CommandText = "UPDATE tblrequisition set paid=0 where pid='" & gridRequisition.GetRowCellValue(gridRequisition.GetSelectedRows(I), "Entry Code").ToString & "'" : com.ExecuteNonQuery()
                com.CommandText = "DELETE FROM tbldisbursementdetails where id='" & gridRequisition.GetRowCellValue(gridRequisition.GetSelectedRows(I), "id").ToString & "'" : com.ExecuteNonQuery()
            Next
            LoadVoucherExpenses()
        End If
    End Sub


    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        If mode.Text = "view" Then
            Me.Close()
        Else
            If CheckSecurity() = True Then
                If XtraMessageBox.Show("Are you sure you want to continue? ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                    SaveVoucherInfo()
                    If frmDisbursementList.Visible = True Then
                        frmDisbursementList.ViewList()
                    End If
                    XtraMessageBox.Show("Disbursement voucher successfully saved", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        End If
       
    End Sub

    Public Function CheckSecurity() As Boolean
        If txtFund.Text = "" Then
            XtraMessageBox.Show("Please select fund ", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtVoucherDate.Focus()
            Return False
        ElseIf txtVoucherDate.Text = "" Then
            XtraMessageBox.Show("Please select voucher date ", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtVoucherDate.Focus()
            Return False
        ElseIf txtSupplier.Text = "" Then
            XtraMessageBox.Show("Please select supplier ", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtSupplier.Focus()
            Return False
        ElseIf Gridview1.RowCount = 0 Then
            XtraMessageBox.Show("Please add disbursment item atleast one item", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        ElseIf gridRequisition.RowCount = 0 Then
            XtraMessageBox.Show("Please add requisition item atleast one item", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        ElseIf Val(CC(txtVoucherAmount.EditValue)) <> Val(CC(txtRequisitionAmount.EditValue)) Then
            XtraMessageBox.Show("Requisition amount does not match with voucher amount", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        Else
            Return True
        End If
    End Function

    Public Sub SaveVoucherInfo()
        If mode.Text = "edit" Then
            com.CommandText = "UPDATE tbldisbursementvoucher set  " _
                   + " voucherno='" & voucherno.Text & "', " _
                   + " fundcode='" & fundcode.Text & "', " _
                   + " periodcode='" & periodcode.Text & "', " _
                   + " yearcode='" & yearcode.Text & "', " _
                   + " seriesno='" & seriesno.Text & "', " _
                   + " yeartrn='" & yeartrn.Text & "', " _
                   + " voucherdate='" & ConvertDate(txtVoucherDate.EditValue) & "', " _
                   + " supplierid='" & txtSupplier.EditValue & "', " _
                   + " typeofpayment='" & radPaymentType.EditValue & "', " _
                   + " amount='" & Val(CC(txtRequisitionAmount.EditValue)) & "' " _
                   + " where id='" & id.Text & "'" : com.ExecuteNonQuery()
        Else
            com.CommandText = "insert into tbldisbursementvoucher set " _
                   + " voucherno='" & voucherno.Text & "', " _
                   + " fundcode='" & fundcode.Text & "', " _
                   + " periodcode='" & periodcode.Text & "', " _
                   + " yearcode='" & yearcode.Text & "', " _
                   + " seriesno='" & seriesno.Text & "', " _
                   + " yeartrn='" & yeartrn.Text & "', " _
                   + " voucherdate='" & ConvertDate(txtVoucherDate.EditValue) & "', " _
                   + " supplierid='" & txtSupplier.EditValue & "', " _
                   + " typeofpayment='" & radPaymentType.EditValue & "', " _
                   + " amount='" & Val(CC(txtRequisitionAmount.EditValue)) & "', " _
                   + " trnby='" & globaluserid & "', " _
                   + " datetrn=current_timestamp " : com.ExecuteNonQuery()
        End If
    End Sub

    Private Sub cmdRefresh_Click(sender As Object, e As EventArgs) Handles cmdRefresh.Click
        LoadDisbursementItem()
    End Sub

    Private Sub cmdAdd_Click(sender As Object, e As EventArgs) Handles cmdAdd.Click
        If txtVoucherDate.Text = "" Then
            XtraMessageBox.Show("Please select voucher date ", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtVoucherDate.Focus()
            Exit Sub
        End If
        frmVoucherItem.voucherno.Text = voucherno.Text
        If frmVoucherItem.Visible = True Then
            frmVoucherItem.Focus()
        Else
            frmVoucherItem.Show(Me)
        End If
    End Sub

    Private Sub cmdEdit_Click(sender As Object, e As EventArgs) Handles cmdEdit.Click
        If txtVoucherDate.Text = "" Then
            XtraMessageBox.Show("Please select voucher date ", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtVoucherDate.Focus()
            Exit Sub
        End If
        frmVoucherItem.mode.Text = "edit"
        frmVoucherItem.voucherno.Text = voucherno.Text
        frmVoucherItem.id.Text = Gridview1.GetFocusedRowCellValue("id").ToString
        If frmVoucherItem.Visible = True Then
            frmVoucherItem.Focus()
        Else
            frmVoucherItem.Show(Me)
        End If
    End Sub

    Private Sub cmdRemove_Click(sender As Object, e As EventArgs) Handles cmdRemove.Click
        If Gridview1.RowCount = 0 Then
            XtraMessageBox.Show("There is no item selected! make sure, the selection is on the list", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        If XtraMessageBox.Show("Are you sure you want to permanently delete this item? ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            Dim I As Integer = 0
            For I = 0 To Gridview1.SelectedRowsCount - 1
                com.CommandText = "delete tbldisbursementvoucheritem where id='" & Gridview1.GetRowCellValue(Gridview1.GetSelectedRows(I), "id") & "' " : com.ExecuteNonQuery()
            Next
        End If

    End Sub

    Private Sub txtVoucherDate_EditValueChanged(sender As Object, e As EventArgs) Handles txtVoucherDate.EditValueChanged
        If mode.Text = "edit" Then Exit Sub
        CreateControlNumber()
    End Sub

    Private Sub budgetyear_EditValueChanged(sender As Object, e As EventArgs) Handles yeartrn.EditValueChanged
        If yeartrn.Text = "" Then Exit Sub
        txtVoucherDate.Properties.MinValue = CDate("January 01, " & yeartrn.Text).ToString("MMMM dd, yyyy")
        txtVoucherDate.Properties.MaxValue = CDate("December 31, " & yeartrn.Text).ToString("MMMM dd, yyyy")
        txtVoucherDate.EditValue = CDate(Now.ToString("MMMM dd, ") & yeartrn.Text)
    End Sub
 

    Private Sub HyperlinkLabelControl1_Click(sender As Object, e As EventArgs) Handles HyperlinkLabelControl1.Click
        frmSupplierInfo.ShowDialog(Me)
        LoadSupplier()
    End Sub

    Public Sub LoadSupplier()
        LoadXgridLookupSearch("select supplierid as code,suppliername as 'Select', completeaddress, tin from tblsupplier where deleted=0 order by suppliername asc", "tblsupplier", txtSupplier, gridSupplier)
        gridSupplier.Columns("code").Visible = False
        XgridHideColumn({"code", "completeaddress", "tin"}, gridSupplier)
    End Sub

   
    Private Sub cmdRefreshRequisition_Click(sender As Object, e As EventArgs) Handles cmdRefreshRequisition.Click
        LoadVoucherExpenses()
    End Sub

    
End Class