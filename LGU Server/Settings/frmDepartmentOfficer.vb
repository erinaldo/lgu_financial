Imports DevExpress.XtraEditors
Imports DevExpress
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraReports.UI
Imports DevExpress.Skins

Public Class frmDepartmentOfficer
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()

        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmProductCat_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub me_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        loadOfficer()

    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        If txtOfficerIncharge.Text = "" Then
            XtraMessageBox.Show("Please select officer incharge name!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtOfficerIncharge.Focus()
            Exit Sub
        ElseIf txtPosition.Text = "" Then
            XtraMessageBox.Show("Please enter position!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtPosition.Focus()
            Exit Sub
        ElseIf txtDateFrom.Text = "" Then
            XtraMessageBox.Show("Please select date from!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtDateFrom.Focus()
            Exit Sub
        ElseIf txtDateTo.Text = "" And ckCurrent.Checked = False Then
            XtraMessageBox.Show("Please select date to!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtDateTo.Focus()
            Exit Sub
        ElseIf countqry("tblcompofficerlog", "officeid='" & officeid.Text & "' and id<>'" & id.Text & "' and current=1") > 0 And ckCurrent.Checked Then
            XtraMessageBox.Show("There is already current officer incharge!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        If mode.Text <> "edit" Then
            com.CommandText = "insert into tblcompofficerlog set officeid='" & officeid.Text & "',officerid='" & txtOfficerIncharge.EditValue & "',position='" & rchar(txtPosition.Text) & "', datefrom='" & ConvertDate(txtDateFrom.EditValue) & "' " & If(ckCurrent.Checked, "", ", dateto='" & ConvertDate(txtDateTo.EditValue) & "'") & ",current=" & ckCurrent.CheckState & "" : com.ExecuteNonQuery()
        Else
            com.CommandText = "update tblcompofficerlog set officeid='" & officeid.Text & "',officerid='" & txtOfficerIncharge.EditValue & "',position='" & rchar(txtPosition.Text) & "', datefrom='" & ConvertDate(txtDateFrom.EditValue) & "' " & If(ckCurrent.Checked, "", ", dateto='" & ConvertDate(txtDateTo.EditValue) & "'") & ",current=" & ckCurrent.CheckState & " where id='" & id.Text & "'" : com.ExecuteNonQuery()
        End If
        frmDepartmentInfo.LoadOfficer()
        Me.Close()
    End Sub

    Public Sub loadOfficer()
        LoadXgridLookupSearch("select accountid, Fullname, Designation as Position from tblaccounts where username<>'ROOT'", "tblaccounts", txtOfficerIncharge, s_grid, Me)
        s_grid.Columns("accountid").Visible = False
    End Sub

    Private Sub txtOfficerIncharge_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtOfficerIncharge.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtOfficerIncharge.Properties.View.FocusedRowHandle.ToString)
        txtPosition.Text = txtOfficerIncharge.Properties.View.GetFocusedRowCellValue("Position").ToString()
    End Sub

    Public Sub clearfields()
        id.Text = ""
        txtOfficerIncharge.Properties.DataSource = Nothing
        txtOfficerIncharge.Text = ""
        txtPosition.Text = ""
        txtDateFrom.EditValue = Nothing
        txtDateTo.EditValue = Nothing
        loadOfficer()
        id.Text = ""
        mode.Text = ""
        txtOfficerIncharge.Focus()
    End Sub

    Private Sub mode_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mode.EditValueChanged
        If mode.Text = "" Then Exit Sub
        com.CommandText = "select * from tblcompofficerlog where id='" & id.Text & "'"
        rst = com.ExecuteReader
        While rst.Read
            officeid.Text = rst("officeid").ToString
            txtOfficerIncharge.Text = rst("officerid").ToString
            txtPosition.Text = rst("position").ToString
            txtDateFrom.EditValue = rst("datefrom").ToString
            txtDateTo.EditValue = rst("dateto").ToString
            ckCurrent.Checked = CBool(rst("current").ToString)
        End While
        rst.Close()
    End Sub


    Private Sub BarLargeButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Me.Close()
    End Sub

    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        clearfields()
    End Sub

    Private Sub cmdUpdateAccountable_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub ckCurrent_CheckedChanged(sender As Object, e As EventArgs) Handles ckCurrent.CheckedChanged
        If ckCurrent.Checked Then
            txtDateTo.EditValue = Nothing
            txtDateTo.Enabled = False
        Else
            txtDateTo.Enabled = True
        End If
    End Sub
End Class