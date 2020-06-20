Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraSplashScreen

Public Class frmJournalEntry
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
        If countqry("tbljournalentryvoucher", "jevno='" & jevno.Text & "'") = 0 And Gridview1.RowCount > 0 Then
            If XtraMessageBox.Show("System found transaction currently not validated! Are you sure you want to cancel current transaction?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
                com.CommandText = "delete from tbljournalentryitem where jevno='" & jevno.Text & "'" : com.ExecuteNonQuery()
            Else
                e.Cancel = True
            End If
        End If

    End Sub

    Private Sub frmBudgetVoucherInfo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = ico
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        LoadFund()
        If mode.Text <> "edit" Then
            txtJevNo.Text = "AUTO GENERATED"
            cmdSave.Text = "Save Journal"
        Else
            ShowVoucherInfo()
        End If
        LoadAccountTitle()
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
        yeartrn.Text = txtFund.Properties.View.GetFocusedRowCellValue("yeartrn").ToString()
    End Sub

    Public Sub ShowVoucherInfo()
        Dim budgettitle As String = ""
        com.CommandText = "select * from tbljournalentryvoucher as a where jevno='" & jevno.Text & "'" : rst = com.ExecuteReader
        While rst.Read
            txtJevNo.Text = rst("jevno").ToString
            txtFund.EditValue = rst("periodcode").ToString
            yeartrn.Text = rst("yeartrn").ToString
            txtJournalDate.EditValue = rst("postingdate").ToString
            fundcode.Text = rst("fundcode").ToString
            periodcode.Text = rst("periodcode").ToString
            txtRemarks.Text = rst("remarks").ToString
            txtDVNo.Text = rst("dvno").ToString
            txtPayrollNo.Text = rst("payrollno").ToString
            txtRCDNo.Text = rst("rcdno").ToString
            txtLRNo.Text = rst("lrno").ToString
            txtAENo.Text = rst("aeno").ToString
            If CBool(rst("cancelled")) Then
                cmdPrint.Visible = False
            Else
                cmdPrint.Visible = True
            End If
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
        txtJournalDate.ReadOnly = readonlyform
        txtRemarks.ReadOnly = readonlyform

        If readonlyform = True Then
            Em.ContextMenuStrip = Nothing
            cmdSave.Text = "Close Window"
        Else
            Em.ContextMenuStrip = ContexEntries
            cmdSave.Text = "Save Voucher"
        End If
    End Function

    Public Sub LoadAccountTitle()
        LoadXgrid("select id, (select officename from tblcompoffice where officeid=tbljournalentryitem.centercode) as 'Responsibility Center', " _
                  + " (select description from tblexpenditureitem where id=tbljournalentryitem.classcode) as 'Expenditure Item',  " _
                  + " itemname as 'Account and Explaination', itemcode as 'Account Code', Debit, Credit, checkno as 'Check No.' " _
                  + " from tbljournalentryitem where jevno='" & If(jevno.Text = "", globaluserid & "-temp", jevno.Text) & "' ", "tbljournalentryitem", Em, Gridview1, Me)
        XgridHideColumn({"id"}, Gridview1)
        XgridColWidth({"Debit", "Credit"}, Gridview1, 140)
        XgridColWidth({"Account and Explaination"}, Gridview1, 250)
        XgridColAlign({"Account Code", "Check No."}, Gridview1, DevExpress.Utils.HorzAlignment.Center)
        Gridview1.Columns("Account and Explaination").OptionsColumn.AllowEdit = False
        Gridview1.Columns("Account and Explaination").OptionsColumn.AllowFocus = False

        Gridview1.Columns("Account and Explaination").AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Gridview1.Columns("Account and Explaination").ColumnEdit = MemoEdit
        XgridColCurrency({"Debit", "Credit"}, Gridview1)
        XgridGeneralSummaryCurrency({"Debit", "Credit"}, Gridview1)
    End Sub

    Private Sub cmdAddApprovedRequisition_Click(sender As Object, e As EventArgs)
        If txtFund.Text = "" Then
            XtraMessageBox.Show("Please select fund ", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtFund.Focus()
            Exit Sub
        ElseIf txtJournalDate.Text = "" Then
            XtraMessageBox.Show("Please select voucher date ", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtJournalDate.Focus()
            Exit Sub
        End If
        frmVoucherRequisitionItem.voucherno.Text = jevno.Text
        frmVoucherRequisitionItem.ShowDialog(Me)
    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        If mode.Text = "view" Then
            Me.Close()
        Else
            If CheckSecurity() = True Then
                If XtraMessageBox.Show("Are you sure you want to continue? ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                    SaveVoucherInfo()
                    If frmJournalEntryList.Visible = True Then
                        frmJournalEntryList.ViewList()
                    End If

                    If frmDisbursementList.Visible = True Then
                        frmDisbursementList.ViewList()
                    End If
                    XtraMessageBox.Show("Journal entry voucher successfully saved", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        End If

    End Sub

    Public Function CheckSecurity() As Boolean
        If txtFund.Text = "" Then
            XtraMessageBox.Show("Please select fund ", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtJournalDate.Focus()
            Return False
        ElseIf txtJournalDate.Text = "" Then
            XtraMessageBox.Show("Please select voucher date ", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtJournalDate.Focus()
            Return False
        ElseIf Val(CC(Gridview1.Columns("Debit").SummaryItem.SummaryValue)) <> Val(CC(Gridview1.Columns("Credit").SummaryItem.SummaryValue)) Then
            XtraMessageBox.Show("Total debit and total credit not match!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        ElseIf Gridview1.RowCount = 0 Then
            XtraMessageBox.Show("Please add disbursment item atleast one item", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        Else
            Return True
        End If
    End Function

    Public Sub SaveVoucherInfo()
        If mode.Text = "edit" Then
            com.CommandText = "UPDATE tbljournalentryvoucher set  " _
                   + " fundcode='" & fundcode.Text & "', " _
                   + " periodcode='" & periodcode.Text & "', " _
                   + " yeartrn='" & yeartrn.Text & "', " _
                   + " postingdate='" & ConvertDate(txtJournalDate.EditValue) & "', " _
                   + " remarks='" & rchar(txtRemarks.Text) & "', " _
                   + " dvno='" & txtDVNo.Text & "', " _
                   + " payrollno='" & txtPayrollNo.Text & "', " _
                   + " rcdno='" & txtRCDNo.Text & "', " _
                   + " lrno='" & txtLRNo.Text & "', " _
                   + " aeno='" & txtAENo.Text & "' " _
                   + " where jevno='" & jevno.Text & "'" : com.ExecuteNonQuery()
        Else
            Dim newjevno As String = fundcode.Text & "-" & yeartrn.Text & "-" & CDate(txtJournalDate.EditValue).ToString("MM") & "-" & GetSequenceNo(periodcode.Text, "jevseries")
            com.CommandText = "insert into tbljournalentryvoucher set " _
                   + " jevno='" & newjevno & "', " _
                   + " fundcode='" & fundcode.Text & "', " _
                   + " periodcode='" & periodcode.Text & "', " _
                   + " yeartrn='" & yeartrn.Text & "', " _
                   + " postingdate='" & ConvertDate(txtJournalDate.EditValue) & "', " _
                   + " remarks='" & rchar(txtRemarks.Text) & "', " _
                   + " dvno='" & txtDVNo.Text & "', " _
                   + " payrollno='" & txtPayrollNo.Text & "', " _
                   + " rcdno='" & txtRCDNo.Text & "', " _
                   + " lrno='" & txtLRNo.Text & "', " _
                   + " aeno='" & txtAENo.Text & "', " _
                   + " trnby='" & globaluserid & "', " _
                   + " datetrn=current_timestamp " : com.ExecuteNonQuery()
            com.CommandText = "update tbljournalentryitem set jevno='" & newjevno & "' where jevno='" & globaluserid & "-temp'" : com.ExecuteNonQuery()
            txtJevNo.Text = newjevno
            jevno.Text = newjevno
            mode.Text = "edit"
        End If
    End Sub

    Private Sub cmdRefresh_Click(sender As Object, e As EventArgs) Handles cmdRefresh.Click
        LoadAccountTitle()
    End Sub

    Private Sub cmdAdd_Click(sender As Object, e As EventArgs) Handles cmdAdd.Click
        If txtFund.Text = "" Then
            XtraMessageBox.Show("Please select fund ", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtJournalDate.Focus()
            Exit Sub
        ElseIf txtJournalDate.Text = "" Then
            XtraMessageBox.Show("Please select journal date ", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtJournalDate.Focus()
            Exit Sub
        End If
        frmJournalEntryItem.jevno.Text = jevno.Text
        If frmJournalEntryItem.Visible = True Then
            frmJournalEntryItem.Focus()
        Else
            frmJournalEntryItem.Show(Me)
        End If
    End Sub

    Private Sub cmdEdit_Click(sender As Object, e As EventArgs) Handles cmdEdit.Click
        If txtFund.Text = "" Then
            XtraMessageBox.Show("Please select fund ", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtJournalDate.Focus()
            Exit Sub
        ElseIf txtJournalDate.Text = "" Then
            XtraMessageBox.Show("Please select journal date ", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtJournalDate.Focus()
            Exit Sub
        End If
        frmJournalEntryItem.mode.Text = "edit"
        frmJournalEntryItem.jevno.Text = jevno.Text
        frmJournalEntryItem.id.Text = Gridview1.GetFocusedRowCellValue("id").ToString
        If frmJournalEntryItem.Visible = True Then
            frmJournalEntryItem.Focus()
        Else
            frmJournalEntryItem.Show(Me)
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
                com.CommandText = "delete from tbljournalentryitem where id='" & Gridview1.GetRowCellValue(Gridview1.GetSelectedRows(I), "id") & "' " : com.ExecuteNonQuery()
            Next
        End If

    End Sub

    Private Sub budgetyear_EditValueChanged(sender As Object, e As EventArgs) Handles yeartrn.EditValueChanged
        If yeartrn.Text = "" Then Exit Sub
        txtJournalDate.Properties.MinValue = CDate("January 01, " & yeartrn.Text).ToString("MMMM dd, yyyy")
        txtJournalDate.Properties.MaxValue = CDate("December 31, " & yeartrn.Text).ToString("MMMM dd, yyyy")
        txtJournalDate.EditValue = CDate(Now.ToString("MMMM dd, ") & yeartrn.Text)
    End Sub
     
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles cmdPrint.Click
        If mode.Text = "view" Then
            PrintJournalVoucher(jevno.Text, Me)
        Else
            If CheckSecurity() = True Then
                If XtraMessageBox.Show("Are you sure you want to continue? ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                    SaveVoucherInfo()
                    PrintJournalVoucher(jevno.Text, Me)
                End If
            End If
        End If
    End Sub
End Class