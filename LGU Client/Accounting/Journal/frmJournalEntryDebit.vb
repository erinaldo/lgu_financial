Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmJournalEntryDebit
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmGLJournalDetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = ico
        LoadItem()
        LoadExpenditureItem()
        If mode.Text = "edit" Then
            showItemTicketItemInfo()
        End If
    End Sub

    Public Sub LoadExpenditureItem()
        LoadXgridLookupSearch("select itemcode as code, officeid, (select itemname from tblglitem where itemcode=a.itemcode) as 'Select',  (select officename from tblcompoffice where officeid=a.officeid) as Center, Amount from tblrequisitionfund as a where pid='" & pid.Text & "' ", "tblrequisitionfund", txtExpiditureClass, gridExpenditure)
        gridExpenditure.Columns("code").Visible = False
        gridExpenditure.Columns("officeid").Visible = False
        XgridColCurrency({"Amount"}, gridExpenditure)
    End Sub

    Private Sub txtExpiditureClass_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtExpiditureClass.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtExpiditureClass.Properties.View.FocusedRowHandle.ToString)
        txtDebit.Text = txtExpiditureClass.Properties.View.GetFocusedRowCellValue("Amount").ToString()
        officeid.Text = txtExpiditureClass.Properties.View.GetFocusedRowCellValue("officeid").ToString()
    End Sub
    Private Sub frmGLJournalDetails_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Public Sub LoadItem()
        If globalSpecialApprover = True Or globalRootUser = True Then
            LoadXgridLookupSearch("select if(sl=1,itemcode,'') as itemcode,  if(sl=1,itemname,'') as itemname, " & GlobalGLitemname & " as 'Item Name', if(a.sl=1,1,0) as sl from tblglitem as a ", "tblglitem", txtItem, gridItem)
        Else
            LoadXgridLookupSearch("select if(sl=1,itemcode,'') as itemcode,  if(sl=1,itemname,'') as itemname, " & GlobalGLitemname & " as 'Item Name', if(a.sl=1,1,0) as sl from tblglitem as a where (gl=1 or glgroup=1 or itemcode in (select itemcode from tblglaccountfilter where permissioncode='" & globalpermissioncode & "')) ", "tblglitem", txtItem, GridItem)
        End If

        XgridHideColumn({"itemcode", "itemname", "debit", "sl"}, GridItem)
    End Sub

    Private Sub gridItem_RowCellStyle(ByVal sender As Object, ByVal e As RowCellStyleEventArgs) Handles gridItem.RowCellStyle
        Dim View As GridView = sender
        Dim sl As Boolean = CBool(View.GetRowCellDisplayText(e.RowHandle, View.Columns("sl")))
        If sl = False Then
            e.Appearance.BackColor = Color.LightYellow
            e.Appearance.ForeColor = Color.Black
            e.Appearance.Font = New Font(e.Appearance.Font.FontFamily, e.Appearance.Font.Size, FontStyle.Bold)
        End If
    End Sub

    Private Sub txtItem_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtItem.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtItem.Properties.View.FocusedRowHandle.ToString)
        txtDebit.Focus()
    End Sub

    Public Sub showItemTicketItemInfo()
        com.CommandText = "select * from tbljournalentryitem where id='" & id.Text & "'" : rst = com.ExecuteReader
        While rst.Read
            txtItem.EditValue = rst("itemcode").ToString
            officeid.Text = rst("centercode").ToString
            ckEnableTagClass.Checked = CBool(rst("tagclass").ToString)
            txtExpiditureClass.EditValue = rst("classcode").ToString
            txtDebit.Text = rst("debit").ToString
        End While
        rst.Close()
    End Sub

    Private Sub cmdOk_Click(sender As Object, e As EventArgs) Handles cmdOk.Click
        If txtItem.Text = "" Then
            XtraMessageBox.Show("Please select item name!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtItem.Focus()
            Exit Sub

        ElseIf Val(CC(txtDebit.Text)) = 0 Then
            XtraMessageBox.Show("Please enter either credit or debit amount!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub

        End If

        If mode.Text = "edit" Then
            com.CommandText = "UPDATE tbljournalentryitem set  " _
                         + " fundcode='" & frmJournalEntry.fundcode.Text & "', " _
                         + " periodcode='" & frmJournalEntry.periodcode.Text & "', " _
                         + " yeartrn='" & frmJournalEntry.yeartrn.Text & "', " _
                         + " postingdate=current_date, " _
                         + " centercode='" & officeid.Text & "', " _
                         + " tagclass=" & ckEnableTagClass.CheckState & ", " _
                         + " classcode='" & If(ckEnableTagClass.Checked, txtExpiditureClass.EditValue, "") & "', " _
                         + " itemcode='" & txtItem.EditValue & "', " _
                         + " itemname='" & rchar(txtItem.Text) & "', " _
                         + " checkno='', " _
                         + " debit='" & Val(CC(txtDebit.Text)) & "', " _
                         + " credit='0' where id='" & id.Text & "'" : com.ExecuteNonQuery()
            If frmJournalEntry.Visible = True Then
                frmJournalEntry.LoadAccountTitle()
            End If
            Me.Close()
        Else
            com.CommandText = "insert into tbljournalentryitem set jevno='" & If(jevno.Text = "", globaluserid & "-temp", jevno.Text) & "', " _
                         + " fundcode='" & frmJournalEntry.fundcode.Text & "', " _
                         + " periodcode='" & frmJournalEntry.periodcode.Text & "', " _
                         + " yeartrn='" & frmJournalEntry.yeartrn.Text & "', " _
                         + " postingdate=current_date, " _
                         + " centercode='" & officeid.Text & "', " _
                         + " tagclass=" & ckEnableTagClass.CheckState & ", " _
                         + " classcode='" & If(ckEnableTagClass.Checked, txtExpiditureClass.EditValue, "") & "', " _
                         + " itemcode='" & txtItem.EditValue & "', " _
                         + " itemname='" & rchar(txtItem.Text) & "', " _
                         + " checkno='', " _
                         + " debit='" & Val(CC(txtDebit.Text)) & "', " _
                         + " credit='0'  " : com.ExecuteNonQuery()
            If Val(CC(txtDebit.Text)) > 0 Then
                txtDebit.Text = "0.00"
                txtItem.Focus()
                txtItem.ShowPopup()
            Else
                txtDebit.Text = "0.00"
                txtItem.EditValue = Nothing
            End If

            ckEnableTagClass.Checked = False
            If frmJournalEntry.Visible = True Then
                frmJournalEntry.LoadAccountTitle()
            End If

        End If

    End Sub

    Private Sub txtDebit_GotFocus(sender As Object, e As EventArgs) Handles txtDebit.GotFocus
        Me.AcceptButton = cmdOk
    End Sub

    Private Sub value_EditValueChanged(sender As Object, e As EventArgs) Handles txtDebit.EditValueChanged
        If Val(CC(txtDebit.Text)) > 0 Then
            Me.AcceptButton = cmdOk

        Else
            Me.AcceptButton = Nothing
        End If
    End Sub

    Private Sub ckEnableTagClass_CheckedChanged(sender As Object, e As EventArgs) Handles ckEnableTagClass.CheckedChanged
        If ckEnableTagClass.Checked Then
            txtExpiditureClass.Enabled = True
        Else
            officeid.Text = ""
            txtExpiditureClass.Enabled = False
            txtExpiditureClass.EditValue = Nothing
        End If
    End Sub
End Class