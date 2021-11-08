Imports DevExpress.XtraEditors
Imports DevExpress
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraReports.UI
Imports DevExpress.Skins

Public Class frmAuthorizedUser
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        ElseIf keyData = Keys.F1 Then

        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmProductCat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        LoadAccessAccount()
        'txtDateFrom.EditValue = CDate(Now)
        'txtDateTo.EditValue = CDate(Now)
        PermissionAccess({cmdSave}, globalAllowAdd)
        PermissionAccess({cmdEdit}, globalAllowEdit)
        PermissionAccess({cmdDelete}, globalAllowDelete)
    End Sub

    Public Sub LoadAccessAccount()
        LoadXgridLookupSearch("select accountid, Fullname from tblaccounts where clientaccesscode in (select accesscode from tblclientaccess where generalapprover=1 or specialapprover=1) order by fullname asc", "tblaccounts", txtAccessAccount, gridAccessTo, Me)
        gridAccessTo.Columns("accountid").Visible = False
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        If txtAccessAccount.Text = "" Then
            XtraMessageBox.Show("Please select Authorize Access to!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtAccessAccount.Focus()
            Exit Sub
        ElseIf txtDateFrom.Text = "" Then
            XtraMessageBox.Show("Please select access date from!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtDateFrom.Focus()
            Exit Sub
        ElseIf txtDateTo.Text = "" Then
            XtraMessageBox.Show("Please select access date to!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtDateTo.Focus()
            Exit Sub
        End If

        If mode.Text <> "edit" Then
            com.CommandText = "insert into tblauthorizedaccess set userid='" & userid.Text & "',accessto='" & txtAccessAccount.EditValue & "',datefrom='" & ConvertDate(txtDateFrom.Text) & "', dateto='" & ConvertDate(txtDateTo.Text) & "', createdby='" & globaluserid & "', datecreated=current_timestamp " : com.ExecuteNonQuery()
        Else
            com.CommandText = "update tblauthorizedaccess set userid='" & userid.Text & "',accessto='" & txtAccessAccount.EditValue & "',datefrom='" & ConvertDate(txtDateFrom.Text) & "', dateto='" & ConvertDate(txtDateTo.Text) & "', createdby='" & globaluserid & "' where id='" & id.Text & "'" : com.ExecuteNonQuery()
        End If
        txtAccessAccount.EditValue = Nothing : txtDateFrom.Text = "" : txtDateTo.Text = "" : id.Text = "" : mode.Text = "" : LoadAccessRecords()
        XtraMessageBox.Show("Access successfully saved!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub XtraTabControl1_SelectedPageChanged(sender As Object, e As XtraTab.TabPageChangedEventArgs) Handles XtraTabControl1.SelectedPageChanged
        LoadAccessRecords()
    End Sub

    Public Sub LoadAccessRecords()
        If XtraTabControl1.SelectedTabPage Is tabActive Then
            LoadActiveAccess()

        ElseIf XtraTabControl1.SelectedTabPage Is tabPrevious Then
            LoadAccessLogs()
        End If
    End Sub

    Public Sub LoadActiveAccess()
        LoadXgrid("Select id, (select fullname from tblaccounts where accountid=a.accessto) as 'Authorized Access To', " _
                        + " date_format(datefrom,'%Y-%m-%d') as 'Date From', " _
                        + " date_format(dateto,'%Y-%m-%d') as 'Date To', " _
                        + " (select fullname from tblaccounts where accountid = a.createdby) as 'Created By', " _
                        + " date_format(datecreated,'%Y-%m-%d %r') as 'Date Created' " _
                        + " from tblauthorizedaccess as a where userid='" & userid.Text & "' and dateto >=current_date  order by datecreated asc", "tblauthorizedaccess", Em, gridActiveAccess, Me)

        XgridHideColumn({"id"}, gridActiveAccess)
        XgridColAlign({"Date From", "Date To", "Date Created"}, gridActiveAccess, DevExpress.Utils.HorzAlignment.Center)
        gridActiveAccess.BestFitColumns()
    End Sub

    Public Sub LoadAccessLogs()
        LoadXgrid("Select id, (select fullname from tblaccounts where accountid=a.accessto) as 'Authorized Access To', " _
                        + " date_format(datefrom,'%Y-%m-%d') as 'Date From', " _
                        + " date_format(dateto,'%Y-%m-%d') as 'Date To', " _
                        + " (select fullname from tblaccounts where accountid = a.createdby) as 'Created By', " _
                        + " date_format(datecreated,'%Y-%m-%d %r') as 'Date Created' " _
                        + " from tblauthorizedaccess as a where userid='" & userid.Text & "' and dateto < current_date order by datecreated asc", "tblauthorizedaccess", Em_Logs, gridLogs, Me)

        XgridHideColumn({"id"}, gridLogs)
        XgridColAlign({"Date From", "Date To", "Date Created"}, gridLogs, DevExpress.Utils.HorzAlignment.Center)
        gridActiveAccess.BestFitColumns()
    End Sub

    Private Sub cmdEdit_Click(sender As Object, e As EventArgs) Handles cmdEdit.Click
        id.Text = gridActiveAccess.GetFocusedRowCellValue("id").ToString
        mode.Text = "edit"
    End Sub

    Private Sub mode_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mode.EditValueChanged
        If mode.Text = "" Then Exit Sub
        com.CommandText = "select *,(select fullname from tblaccounts where accountid=a.userid) as username from tblauthorizedaccess as a where id='" & id.Text & "'"
        rst = com.ExecuteReader
        While rst.Read
            userid.Text = rst("userid").ToString
            txtAccessAccount.EditValue = rst("accessto").ToString
            txtDateFrom.Text = rst("datefrom").ToString
            txtDateTo.Text = rst("dateto").ToString
        End While
        rst.Close()
    End Sub

    Private Sub BarLargeButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdClose.ItemClick
        Me.Close()
    End Sub

    Private Sub cmdRemove_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
        If gridActiveAccess.GetFocusedRowCellValue("id").ToString = "" Then
            XtraMessageBox.Show("There is no item selected! make sure, the selection is on the list", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        If XtraMessageBox.Show("Are you sure you want to permanently delete this item? " & todelete, compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            For I = 0 To gridActiveAccess.SelectedRowsCount - 1
                com.CommandText = "delete from tblauthorizedaccess where id='" & gridActiveAccess.GetRowCellValue(gridActiveAccess.GetSelectedRows(I), "id") & "' " : com.ExecuteNonQuery()
            Next
            LoadActiveAccess()
        End If
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        LoadActiveAccess()
    End Sub


    Private Sub userid_EditValueChanged(sender As Object, e As EventArgs) Handles userid.EditValueChanged
        LoadActiveAccess() : mode.Text = "" : id.Text = ""
        ckEnableAuthorizedAccess.Checked = CBool(qrysingledata("enableauthorizedaccess", "enableauthorizedaccess", "tblaccounts where accountid='" & userid.Text & "'"))
    End Sub

    Private Sub ckEnableAuthorizedAccess_CheckedChanged(sender As Object, e As EventArgs) Handles ckEnableAuthorizedAccess.CheckedChanged
        com.CommandText = "update tblaccounts set enableauthorizedaccess=" & ckEnableAuthorizedAccess.Checked & " where accountid='" & userid.Text & "'" : com.ExecuteNonQuery()

        If ckEnableAuthorizedAccess.Checked Then
            txtAccessAccount.Enabled = True
            txtDateFrom.Enabled = True
            txtDateTo.Enabled = True
            Em.ContextMenuStrip = gridmenustrip
        Else
            txtAccessAccount.Enabled = False
            txtDateFrom.Enabled = False
            txtDateTo.Enabled = False
            Em.ContextMenuStrip = Nothing
        End If
    End Sub

End Class