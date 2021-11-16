Imports DevExpress.XtraEditors
Imports DevExpress.Skins

Public Class frmFund
    Private Sub frmFund_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        SetIcon(Me)
        filter()

        PermissionAccess({cmdOfficeMoveLeft, cmdOfficeMoveRight}, globalAdminAccess)
        PermissionAccess({cmdSave}, globalAllowAdd)
        PermissionAccess({cmdEdit}, globalAllowEdit)
        PermissionAccess({cmdDelete}, globalAllowDelete)
    End Sub

#Region "Information"

    Public Sub filter()
        LoadXgrid("Select  Code, CodeName, Description, Template from tblfund order by code asc", "tblfund", Em, GridView1, Me)
        XgridColAlign({"Code", "CodeName", "Template"}, GridView1, DevExpress.Utils.HorzAlignment.Center)
        GridView1.BestFitColumns()
    End Sub

    Private Sub cmdSaveButton_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        If countqry("tblfund", "code='" & code.Text & "'") > 0 And mode.Text <> "edit" Then
            XtraMessageBox.Show("Code already exists!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            code.Focus()
            Exit Sub
        ElseIf txtcodename.Text = "" Then
            XtraMessageBox.Show("Please enter code name!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtcodename.Focus()
            Exit Sub
        ElseIf txtDescription.Text = "" Then
            XtraMessageBox.Show("Please enter description!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtDescription.Focus()
            Exit Sub
        ElseIf txtTemplate.Text = "" Then
            XtraMessageBox.Show("Please select template!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtTemplate.Focus()
            Exit Sub
        End If
        If mode.Text = "edit" Then
            com.CommandText = "update tblfund set  codename='" & txtcodename.Text & "',description='" & rchar(txtDescription.Text) & "', template='" & txtTemplate.EditValue & "' where code='" & code.Text & "'" : com.ExecuteNonQuery()
        Else
            com.CommandText = "insert into tblfund set code='" & code.Text & "',codename='" & txtcodename.Text & "',description='" & rchar(txtDescription.Text) & "', template='" & txtTemplate.EditValue & "'" : com.ExecuteNonQuery()
        End If
        code.Text = "" : mode.Text = "" : code.Enabled = True : txtcodename.Text = "" : txtDescription.Text = "" : txtTemplate.SelectedIndex = -1 : code.Focus() : filter()
        XtraMessageBox.Show("fund successfully saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Public Sub showInfo()
        If code.Text = "" Then Exit Sub
        com.CommandText = "select * from tblfund where code='" & code.Text & "'" : rst = com.ExecuteReader
        While rst.Read
            txtcodename.Text = rst("codename").ToString
            txtDescription.Text = rst("description").ToString
            txtTemplate.EditValue = rst("template").ToString
        End While
        rst.Close()
    End Sub

    Private Sub cmdEdit_Click(sender As Object, e As EventArgs) Handles cmdEdit.Click
        mode.Text = "" : code.Enabled = False
        code.Text = GridView1.GetFocusedRowCellValue("Code").ToString
        mode.Text = "edit"
        showInfo()
    End Sub

    Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
        If XtraMessageBox.Show("Are you sure you want to permanently remove selected item? ", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            Dim I As Integer = 0
            For I = 0 To GridView1.SelectedRowsCount - 1
                com.CommandText = "delete from tblfund where code='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "Code") & "' " : com.ExecuteNonQuery()
            Next
            filter()
        End If
    End Sub
#End Region

    Private Sub XtraTabControl1_SelectedPageChanged(sender As Object, e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles XtraTabControl1.SelectedPageChanged
        If XtraTabControl1.SelectedTabPage Is tabOfficeFilter Then
            LoadOfficeFund()
        ElseIf XtraTabControl1.SelectedTabPage Is tabClientUserFilter Then
            LoadClientFund()
        ElseIf XtraTabControl1.SelectedTabPage Is tabServerUserFilter Then
            LoadServerFund()
        End If
    End Sub

#Region "DEPARTMENT FILTER"
    Public Sub LoadOfficeFund()
        LoadXgridLookupSearch("select code, description 'Select' from tblfund order by description asc", "tblfund", txtOfficeFund, grid_office_fund, Me)
        grid_office_fund.Columns("code").Visible = False
    End Sub

    Private Sub txtOfficeFund_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtOfficeFund.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtOfficeFund.Properties.View.FocusedRowHandle.ToString)
        ShowOfficeUnfiltered()
        ShowOfficefiltered()
    End Sub

    Public Sub ShowOfficeUnfiltered()
        Dim filter As String = ""
        com.CommandText = "select filtered_id from tblfundfilter where fundcode='" & txtOfficeFund.EditValue & "' and filtered_type='office'" : rst = com.ExecuteReader
        While rst.Read
            filter = filter + "'" & rst("filtered_id").ToString & "',"
        End While
        rst.Close()
        If filter.Length > 0 Then
            filter = filter.Remove(filter.Length - 1, 1)
            filter = " and officeid not in (" & filter & ")"
        End If
        If txtOfficeFund.EditValue <> "" Then
            LoadXgrid("select officeid, officename as 'Office' from tblcompoffice where deleted=0 " & filter & "  ", "tblcompoffice", em_office_unfiltered, grid_office_unfiltered, Me)
            grid_office_unfiltered.Columns("officeid").Visible = False
            XgridColMemo({"Office"}, grid_office_unfiltered)
            XgridColWidth({"Office"}, grid_office_unfiltered, em_office_unfiltered.Width)
        End If
    End Sub

    Public Sub ShowOfficefiltered()
        If txtOfficeFund.EditValue <> "" Then
            LoadXgrid("select id, (select officename from tblcompoffice where officeid= tblfundfilter.filtered_id) as 'Office' from tblfundfilter where fundcode='" & txtOfficeFund.EditValue & "' and filtered_type='office' order by filtered_id asc", "tblfundfilter", em_office_filtered, grid_office_filtered, Me)
            grid_office_filtered.Columns("id").Visible = False
            XgridColMemo({"Office"}, grid_office_filtered)
            XgridColWidth({"Office"}, grid_office_filtered, em_office_filtered.Width)
        End If
    End Sub


    Private Sub cmdOfficeMoveRight_Click(sender As Object, e As EventArgs) Handles cmdOfficeMoveRight.Click
        For I = 0 To grid_office_unfiltered.SelectedRowsCount - 1
            com.CommandText = "insert into tblfundfilter set fundcode='" & txtOfficeFund.EditValue & "', filtered_id='" & grid_office_unfiltered.GetRowCellValue(grid_office_unfiltered.GetSelectedRows(I), "officeid").ToString & "', filtered_type='office'" : com.ExecuteNonQuery()
        Next
        ShowOfficeUnfiltered()
        ShowOfficefiltered()
    End Sub

    Private Sub cmdOfficeMoveLeft_Click(sender As Object, e As EventArgs) Handles cmdOfficeMoveLeft.Click
        For I = 0 To grid_office_filtered.SelectedRowsCount - 1
            com.CommandText = "delete from tblfundfilter where id='" & grid_office_filtered.GetRowCellValue(grid_office_filtered.GetSelectedRows(I), "id").ToString & "'" : com.ExecuteNonQuery()
        Next
        ShowOfficeUnfiltered()
        ShowOfficefiltered()
    End Sub
#End Region

#Region "CLIENT USER FILTER"
    Public Sub LoadClientFund()
        LoadXgridLookupSearch("select code, description 'Select' from tblfund order by description asc", "tblfund", txtClientFund, grid_client_fund, Me)
        grid_client_fund.Columns("code").Visible = False
    End Sub

    Private Sub txtClientFund_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtClientFund.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtClientFund.Properties.View.FocusedRowHandle.ToString)
        ShowClientUnfiltered()
        ShowClientfiltered()
    End Sub

    Public Sub ShowClientUnfiltered()
        Dim filter As String = ""
        com.CommandText = "select filtered_id from tblfundfilter where fundcode='" & txtClientFund.EditValue & "' and filtered_type='client'" : rst = com.ExecuteReader
        While rst.Read
            filter = filter + "'" & rst("filtered_id").ToString & "',"
        End While
        rst.Close()
        If filter.Length > 0 Then
            filter = filter.Remove(filter.Length - 1, 1)
            filter = " and accesscode not in (" & filter & ")"
        End If
        If txtClientFund.EditValue <> "" Then
            LoadXgrid("select accesscode, description as 'Client Access' from tblclientaccess where accesscode>0 " & filter & "  ", "tblclientaccess", em_client_unfiltered, grid_client_unfiltered, Me)
            grid_client_unfiltered.Columns("accesscode").Visible = False
            XgridColMemo({"Client Access"}, grid_client_unfiltered)
            XgridColWidth({"Client Access"}, grid_client_unfiltered, em_client_unfiltered.Width)
        End If
    End Sub

    Public Sub ShowClientfiltered()
        If txtClientFund.EditValue <> "" Then
            LoadXgrid("select id, (select description from tblclientaccess where accesscode=tblfundfilter.filtered_id) as 'Client Access' from tblfundfilter where fundcode='" & txtClientFund.EditValue & "' and filtered_type='client' order by filtered_id asc", "tblfundfilter", em_client_filtered, grid_client_filtered, Me)
            grid_client_filtered.Columns("id").Visible = False
            XgridColMemo({"Client Access"}, grid_client_filtered)
            XgridColWidth({"Client Access"}, grid_client_filtered, em_client_filtered.Width)
        End If
    End Sub


    Private Sub cmdClientMoveRight_Click(sender As Object, e As EventArgs) Handles cmdClientMoveRight.Click
        For I = 0 To grid_client_unfiltered.SelectedRowsCount - 1
            com.CommandText = "insert into tblfundfilter set fundcode='" & txtClientFund.EditValue & "', filtered_id='" & grid_client_unfiltered.GetRowCellValue(grid_client_unfiltered.GetSelectedRows(I), "accesscode").ToString & "', filtered_type='client'" : com.ExecuteNonQuery()
        Next
        ShowClientUnfiltered()
        ShowClientfiltered()
    End Sub

    Private Sub cmdClientMoveLeft_Click(sender As Object, e As EventArgs) Handles cmdClientMoveLeft.Click
        For I = 0 To grid_client_filtered.SelectedRowsCount - 1
            com.CommandText = "delete from tblfundfilter where id='" & grid_client_filtered.GetRowCellValue(grid_client_filtered.GetSelectedRows(I), "id").ToString & "'" : com.ExecuteNonQuery()
        Next
        ShowClientUnfiltered()
        ShowClientfiltered()
    End Sub
#End Region

#Region "SERVER USER FILTER"
    Public Sub LoadServerFund()
        LoadXgridLookupSearch("select code, description 'Select' from tblfund order by description asc", "tblfund", txtServerFund, grid_server_fund, Me)
        grid_server_fund.Columns("code").Visible = False
    End Sub

    Private Sub txtServerFund_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtServerFund.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtServerFund.Properties.View.FocusedRowHandle.ToString)
        ShowServerUnfiltered()
        ShowServerfiltered()
    End Sub

    Public Sub ShowServerUnfiltered()
        Dim filter As String = ""
        com.CommandText = "select filtered_id from tblfundfilter where fundcode='" & txtServerFund.EditValue & "' and filtered_type='server'" : rst = com.ExecuteReader
        While rst.Read
            filter = filter + "'" & rst("filtered_id").ToString & "',"
        End While
        rst.Close()
        If filter.Length > 0 Then
            filter = filter.Remove(filter.Length - 1, 1)
            filter = " and percode not in (" & filter & ")"
        End If
        If txtServerFund.EditValue <> "" Then
            LoadXgrid("select percode, permission as 'Server Access' from tblpermissions where percode>0 " & filter & "  ", "tblpermissions", em_server_unfiltered, grid_server_unfiltered, Me)
            grid_server_unfiltered.Columns("percode").Visible = False
            XgridColMemo({"server Access"}, grid_server_unfiltered)
            XgridColWidth({"server Access"}, grid_server_unfiltered, em_server_unfiltered.Width)
        End If
    End Sub

    Public Sub ShowServerfiltered()
        If txtServerFund.EditValue <> "" Then
            LoadXgrid("select id, (select permission from tblpermissions where percode=tblfundfilter.filtered_id) as 'Server Access' from tblfundfilter where fundcode='" & txtServerFund.EditValue & "' and filtered_type='server' order by filtered_id asc", "tblfundfilter", em_server_filtered, grid_server_filtered, Me)
            grid_server_filtered.Columns("id").Visible = False
            XgridColMemo({"server Access"}, grid_server_filtered)
            XgridColWidth({"server Access"}, grid_server_filtered, em_server_filtered.Width)
        End If
    End Sub


    Private Sub cmdserverMoveRight_Click(sender As Object, e As EventArgs) Handles cmdServerMoveRight.Click
        For I = 0 To grid_server_unfiltered.SelectedRowsCount - 1
            com.CommandText = "insert into tblfundfilter set fundcode='" & txtServerFund.EditValue & "', filtered_id='" & grid_server_unfiltered.GetRowCellValue(grid_server_unfiltered.GetSelectedRows(I), "percode").ToString & "', filtered_type='server'" : com.ExecuteNonQuery()
        Next
        ShowServerUnfiltered()
        ShowServerfiltered()
    End Sub

    Private Sub cmdserverMoveLeft_Click(sender As Object, e As EventArgs) Handles cmdServerMoveLeft.Click
        For I = 0 To grid_server_filtered.SelectedRowsCount - 1
            com.CommandText = "delete from tblfundfilter where id='" & grid_server_filtered.GetRowCellValue(grid_server_filtered.GetSelectedRows(I), "id").ToString & "'" : com.ExecuteNonQuery()
        Next
        ShowServerUnfiltered()
        ShowServerfiltered()
    End Sub
#End Region

End Class