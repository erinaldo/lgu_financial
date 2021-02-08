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
        If countqry("tbldisbursementvoucher", "voucherno='" & voucherno.Text & "'") = 0 And gridRequisition.RowCount > 0 Then
            If XtraMessageBox.Show("System found transaction currently not validated! " & Environment.NewLine & "Are you sure you want to cancel current transaction?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
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
        txtVoucherDate.EditValue = Now
        'txtCheckDate.EditValue = Now
        If mode.Text <> "edit" Then
            CreateTrnReference()
            cmdSave.Text = "Save Voucher"
        Else
            ShowVoucherInfo()
        End If
        SplashScreenManager.CloseForm()
    End Sub

    Public Sub CreateTrnReference()
        trnreference.Text = getGlobalTrnid() & "-" & globaluserid
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
        txtVoucherDate.Properties.MinValue = CDate("01/01/" & yearcode.Text)
        txtVoucherDate.Properties.MaxValue = CDate("12/31/" & yearcode.Text)
        LoadOffice()
    End Sub

    Public Sub LoadOffice()
        If periodcode.Text = "" Then Exit Sub
        LoadXgridLookupSearch("select officeid, officename as 'Select' from tblcompoffice where officeid in (select officeid from tblrequisition where approved=1 and periodcode='" & periodcode.Text & "')  order by officename asc", "tblcompoffice", txtOffice, gridOffice)
        gridOffice.Columns("officeid").Visible = False
    End Sub

    Public Sub ShowVoucherInfo()
        Dim budgettitle As String = "" : Dim officeid As String = ""
        com.CommandText = "select * from tbldisbursementvoucher as a where id='" & id.Text & "'" : rst = com.ExecuteReader
        While rst.Read
            txtFund.EditValue = rst("periodcode").ToString
            periodcode.Text = rst("periodcode").ToString
            seriesno.Text = rst("seriesno").ToString
            yearcode.Text = rst("yearcode").ToString
            yeartrn.Text = rst("yeartrn").ToString
            officeid = rst("officeid").ToString
            checkno.Text = rst("checkno").ToString
            txtVoucherDate.EditValue = CDate(rst("voucherdate").ToString)
            voucherno.Text = rst("voucherno").ToString
            txtSupplier.EditValue = rst("supplierid").ToString
            fundcode.Text = rst("fundcode").ToString

            txtVoucherAmount.EditValue = rst("amount").ToString
            If CBool(rst("cleared")) = True Or CBool(rst("cancelled")) = True Then
                mode.Text = "view"
                InfoControl(True)
            Else
                InfoControl(False)
            End If
        End While
        rst.Close()
        LoadVoucherExpenses()
        LoadOffice()
        txtOffice.EditValue = officeid

    End Sub

    Public Function InfoControl(ByVal readonlyform As Boolean)
        txtFund.ReadOnly = readonlyform
        txtVoucherDate.ReadOnly = readonlyform
        txtSupplier.ReadOnly = readonlyform

        If readonlyform = True Then
            Em_requisition.ContextMenuStrip = Nothing
            SimpleButton1.Visible = False
            cmdPrint.Visible = False
            cmdSave.Text = "Close Window"
        Else
            Em_requisition.ContextMenuStrip = ContextRequisition
            SimpleButton1.Visible = True
            cmdPrint.Visible = True
            cmdSave.Text = "Save Voucher"
        End If
    End Function

    Public Sub LoadVoucherExpenses()
        LoadXgrid("select id, pid as 'Entry Code', date_format(postingdate,'%Y-%m-%d') as 'Date', requestno as 'Request No',(select officename from tblcompoffice where officeid=a.officeid) as 'Office', (select description from tblrequisitiontype where code=a.requesttype) as 'Request Type', Amount,Purpose from tbldisbursementdetails as a where voucherno='" & voucherno.Text & "' order by postingdate asc", "tbldisbursementdetails", Em_requisition, gridRequisition, Me)

        XgridHideColumn({"id"}, gridRequisition)
        XgridColAlign({"Entry Code", "Request No", "Request Type", "Date"}, gridRequisition, DevExpress.Utils.HorzAlignment.Center)
        XgridColCurrency({"Amount"}, gridRequisition)
        XgridGeneralSummaryCurrency({"Amount"}, gridRequisition)
        XgridColWidth({"Amount"}, gridRequisition, 100)
        txtVoucherAmount.EditValue = gridRequisition.Columns("Amount").SummaryText

        If gridRequisition.RowCount > 0 Then
            txtFund.ReadOnly = True
            txtOffice.ReadOnly = True
        Else
            txtFund.ReadOnly = False
            txtOffice.ReadOnly = False
        End If
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
        ElseIf txtOffice.Text = "" Then
            XtraMessageBox.Show("Please select office ", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtOffice.Focus()
            Exit Sub
        ElseIf txtVoucherDate.Text = "" Then
            XtraMessageBox.Show("Please select voucher date ", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtVoucherDate.Focus()
            Exit Sub
        End If
        frmVoucherRequisitionItem.periodcode.Text = periodcode.Text
        frmVoucherRequisitionItem.voucherno.Text = voucherno.Text
        frmVoucherRequisitionItem.trnreference.Text = trnreference.Text
        frmVoucherRequisitionItem.officeid.Text = txtOffice.EditValue
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
                    CreateTrnReference()
                    XtraMessageBox.Show("Disbursement voucher successfully saved", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()
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
        ElseIf gridRequisition.RowCount = 0 Then
            XtraMessageBox.Show("Please add requisition item atleast one item", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
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
                   + " officeid='" & txtOffice.EditValue & "', " _
                   + " amount='" & Val(CC(txtVoucherAmount.EditValue)) & "' " _
                   + " where id='" & id.Text & "'" : com.ExecuteNonQuery()
        Else

            yeartrn.Text = CDate(txtVoucherDate.EditValue).ToString("yyyy")
            Dim vno As String = getVoucherNumber(yeartrn.Text, "tbldisbursementvoucher")
            voucherno.Text = fundcode.Text & "-" & yeartrn.Text & "-" & CDate(txtVoucherDate.EditValue).ToString("MM") & "-" & vno
            seriesno.Text = vno

            com.CommandText = "insert into tbldisbursementvoucher set " _
                   + " voucherno='" & voucherno.Text & "', " _
                   + " fundcode='" & fundcode.Text & "', " _
                   + " periodcode='" & periodcode.Text & "', " _
                   + " yearcode='" & yearcode.Text & "', " _
                   + " seriesno='" & seriesno.Text & "', " _
                   + " yeartrn='" & yeartrn.Text & "', " _
                   + " voucherdate='" & ConvertDate(txtVoucherDate.EditValue) & "', " _
                   + " supplierid='" & txtSupplier.EditValue & "', " _
                   + " officeid='" & txtOffice.EditValue & "', " _
                   + " checkno='', " _
                   + " checkbank='', " _
                   + " checkdate=null, " _
                   + " amount='" & Val(CC(txtVoucherAmount.EditValue)) & "', " _
                   + " trnby='" & globaluserid & "', " _
                   + " datetrn=current_timestamp " : com.ExecuteNonQuery()
            com.CommandText = "update tbldisbursementdetails set voucherno='" & voucherno.Text & "' where trnreference='" & trnreference.Text & "'" : com.ExecuteNonQuery()
        End If
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

    Private Sub cmdPrint_Click(sender As Object, e As EventArgs) Handles cmdPrint.Click
        If countqry("tbljournalentryvoucher", "dvno='" & voucherno.Text & "'") = 0 Then
            XtraMessageBox.Show("No journal entry for this voucher please create before print", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        ElseIf checkno.Text = "" Then
            XtraMessageBox.Show("Voucher check is currently not issued! ", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If mode.Text = "view" Then
            PrintDisbursementVoucher(voucherno.Text, Me)
        Else
            If CheckSecurity() = True Then
                If XtraMessageBox.Show("Are you sure you want to continue? ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                    SaveVoucherInfo()
                    PrintDisbursementVoucher(voucherno.Text, Me)
                End If
            End If
        End If
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        cmdAddApprovedRequisition.PerformClick()
    End Sub
End Class