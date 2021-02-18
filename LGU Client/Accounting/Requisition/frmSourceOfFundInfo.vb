Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmSourceOfFundInfo
    Public id As String = ""
    Public mode As String = ""
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmSourceOfFundInfo_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub frmQuantitySelect_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = ico
        LoadSourceFund()
        If mode = "edit" Then
            ShowItemInfo()
        End If
    End Sub

    Public Sub LoadSourceFund()
        If periodcode.Text = "" Then Exit Sub
        LoadXgridLookupSearch("select itemcode, quarter, classcode as Class, itemname as 'Select', balance as 'Current Balance' from (select itemcode, quarter, classcode, itemname, " _
                              + " amount-(select ifnull(sum(amount),0) from tblrequisitionfund as a where x.periodcode=a.periodcode And x.itemcode=a.itemcode and x.quarter=a.quarter And x.officeid=a.officeid And a.pid<>'" & pid.Text & "' and a.cancelled=0) as balance " _
                              + " from tblbudgetcomposition as x where periodcode='" & periodcode.Text & "' and officeid='" & officeid.Text & "') as i where i.balance > 0 order by i.classcode, i.itemname asc", "tblbudgetcomposition", txtSource, gridSource)
        XgridHideColumn({"itemcode", "quarter"}, gridSource)
        XgridColCurrency({"Current Balance"}, gridSource)
        XgridColAlign({"Class"}, gridSource, DevExpress.Utils.HorzAlignment.Center)
        XgridColWidth({"Class"}, gridSource, 40)
        XgridColWidth({"Current Balance"}, gridSource, 80)
    End Sub

    Private Sub gridview1_RowCellStyle(ByVal sender As Object, ByVal e As RowCellStyleEventArgs) Handles gridSource.RowCellStyle
        Dim View As GridView = sender
        If e.Column.Name = "colSelect" Then
            e.Appearance.ForeColor = Color.Black
            e.Appearance.BackColor = Color.LightYellow
            e.Appearance.BackColor2 = Color.LightYellow
        End If

    End Sub

    Private Sub txtSource_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSource.EditValueChanged
        On Error Resume Next
        sourceid.Text = txtSource.Properties.View.GetFocusedRowCellValue("itemcode").ToString()
        quarter.Text = txtSource.Properties.View.GetFocusedRowCellValue("quarter").ToString()
        classcode.Text = txtSource.Properties.View.GetFocusedRowCellValue("Class").ToString()
        txtAvailableBalance.Text = txtSource.Properties.View.GetFocusedRowCellValue("Current Balance").ToString()
        txtAmount.Focus()
    End Sub


    Public Sub ShowItemInfo()
        com.CommandText = "select * from tblrequisitionfund where id='" & id & "'" : rst = com.ExecuteReader
        While rst.Read
            txtSource.EditValue = rst("itemcode").ToString
            sourceid.Text = rst("itemcode").ToString
            quarter.Text = rst("quarter").ToString
            classcode.Text = rst("classcode").ToString
            txtAmount.EditValue = rst("amount").ToString
        End While
        rst.Close()
        txtAvailableBalance.EditValue = GetSourceFundBalance(periodcode.Text, sourceid.Text, officeid.Text)
    End Sub

    Public Function GetSourceFundBalance(ByVal periodcode As String, ByVal itemcode As String, ByVal officeid As String) As Double
        Dim currentbudget As Double = qrysingledata("amount", "amount", "tblbudgetcomposition where periodcode='" & periodcode & "' and itemcode='" & itemcode & "' and officeid='" & officeid & "'")
        Dim totaltransaction As Double = qrysingledata("totalpending", "ifnull(sum(amount),0) as totalpending", "tblrequisitionfund as a where a.periodcode='" & periodcode & "' and a.itemcode='" & itemcode & "' and a.officeid='" & officeid & "' and a.pid<>'" & pid.Text & "'")
        Return currentbudget - totaltransaction
    End Function

    Public Sub clearInfo()
        mode = ""
        id = ""
        txtSource.EditValue = Nothing
        sourceid.Text = ""
        quarter.Text = ""
        classcode.Text = ""
        txtAmount.Text = "0"
        txtAvailableBalance.Text = "0"
        txtSource.Focus()
    End Sub

    Private Sub txtAmount_EditValueChanged(sender As Object, e As EventArgs) Handles txtAmount.EditValueChanged
        If txtAmount.EditValue > 0 Then
            Me.AcceptButton = cmdaction
        Else
            Me.AcceptButton = Nothing
        End If
    End Sub

    Private Sub cmdaction_Click(sender As Object, e As EventArgs) Handles cmdaction.Click
        If txtSource.Text = "" Then
            XtraMessageBox.Show("Please select source of fund!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtSource.Focus()
            Exit Sub
        ElseIf Val(CC(txtAmount.Text)) <= 0 Then
            XtraMessageBox.Show("Please enter valid amount!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtAmount.Focus()
            Exit Sub
        ElseIf Val(CC(txtAmount.EditValue)) > Val(CC(txtAvailableBalance.EditValue)) Then
            XtraMessageBox.Show("Insufficient allocated budget balance! Please reduce amount", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        ElseIf countqry("tblrequisitionfund", " pid='" & pid.Text & "' and itemcode='" & sourceid.Text & "' and officeid ='" & officeid.Text & "' and periodcode='" & periodcode.Text & "' and id<>'" & id & "'") > 0 Then
            XtraMessageBox.Show("Source item is already added. Please modify exiting item", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If mode = "edit" Then
            com.CommandText = "update tblrequisitionfund set " _
                                + " pid='" & pid.Text & "', " _
                                + " officeid ='" & officeid.Text & "', " _
                                + " periodcode='" & periodcode.Text & "', " _
                                + " requestno='" & requestno.Text & "', " _
                                + " quarter='" & quarter.Text & "', " _
                                + " classcode='" & classcode.Text & "', " _
                                + " itemcode='" & sourceid.Text & "', " _
                                + " prevbalance='" & CC(txtAvailableBalance.EditValue) & "', " _
                                + " amount='" & CC(txtAmount.EditValue) & "', " _
                                + " newbalance='" & CC(txtAvailableBalance.EditValue) - CC(txtAmount.EditValue) & "' " _
                                + " where id='" & id & "'" : com.ExecuteNonQuery()
            frmSourceOfFund.LoadSource()
            'XtraMessageBox.Show("Fund successfully updated!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        Else
            com.CommandText = "insert into tblrequisitionfund set " _
                                + " pid='" & pid.Text & "', " _
                                + " officeid ='" & officeid.Text & "', " _
                                + " periodcode='" & periodcode.Text & "', " _
                                + " requestno='" & requestno.Text & "', " _
                                + " quarter='" & quarter.Text & "', " _
                                + " classcode='" & classcode.Text & "', " _
                                + " itemcode='" & sourceid.Text & "', " _
                                + " prevbalance='" & CC(txtAvailableBalance.EditValue) & "', " _
                                + " amount='" & CC(txtAmount.EditValue) & "', " _
                                + " newbalance='" & CC(txtAvailableBalance.EditValue) - CC(txtAmount.EditValue) & "'" : com.ExecuteNonQuery()
            clearInfo()
            frmSourceOfFund.LoadSource()
            XtraMessageBox.Show("Fund successfully added!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

End Class