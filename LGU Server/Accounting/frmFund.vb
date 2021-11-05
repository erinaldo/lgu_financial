Imports DevExpress.XtraEditors
Imports DevExpress.Skins

Public Class frmFund
    Private Sub frmFund_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        SetIcon(Me)
        filter()

        LoadCategory()
        ShowUnfilteredProducts()
        ShowfilteredProducts()
        PermissionAccess({cmdMoveLeft, cmdMoveRight}, globalAdminAccess)
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

#Region "Filter"
    Private Sub XtraTabControl1_SelectedPageChanged(sender As Object, e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles XtraTabControl1.SelectedPageChanged
        LoadCategory()
    End Sub


    Public Sub LoadCategory()
        LoadXgridLookupSearch("select code, description 'Select' from tblfund order by description asc", "tblfund", txtFund, gridFund, Me)
        gridFund.Columns("code").Visible = False
    End Sub

    Private Sub txtprocat_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFund.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtFund.Properties.View.FocusedRowHandle.ToString)
        fundcode.Text = txtFund.Properties.View.GetFocusedRowCellValue("code").ToString()
        ShowUnfilteredProducts()
        ShowfilteredProducts()
    End Sub

    Public Sub ShowUnfilteredProducts()
        Dim filter As String = ""
        com.CommandText = "select officeid from tblfundfilter where fundcode='" & fundcode.Text & "'" : rst = com.ExecuteReader
        While rst.Read
            filter = filter + "'" & rst("officeid").ToString & "',"
        End While
        rst.Close()
        If filter.Length > 0 Then
            filter = filter.Remove(filter.Length - 1, 1)
            filter = " and officeid not in (" & filter & ")"
        End If
        If fundcode.Text <> "" Then
            LoadXgrid("select officeid, officename as 'Office' from tblcompoffice where deleted=0 " & filter & "  ", "tblcompoffice", Em_unfiltered, gridUnfiltered, Me)
            gridUnfiltered.Columns("officeid").Visible = False
            XgridColMemo({"Office"}, gridUnfiltered)
            XgridColWidth({"Office"}, gridUnfiltered, Em_unfiltered.Width)
        End If
    End Sub

    Public Sub ShowfilteredProducts()
        If fundcode.Text <> "" Then
            LoadXgrid("select officeid, (select officename from tblcompoffice where officeid= tblfundfilter.officeid) as 'Office' from tblfundfilter where fundcode='" & fundcode.Text & "' order by officeid asc", "tblfundfilter", Em_filtered, gridFiltered, Me)
            gridFiltered.Columns("officeid").Visible = False
            XgridColMemo({"Office"}, gridFiltered)
            XgridColWidth({"Office"}, gridFiltered, Em_filtered.Width)
        End If
    End Sub


    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles cmdMoveRight.Click
        For I = 0 To gridUnfiltered.SelectedRowsCount - 1
            com.CommandText = "insert into tblfundfilter set fundcode='" & fundcode.Text & "', officeid='" & gridUnfiltered.GetRowCellValue(gridUnfiltered.GetSelectedRows(I), "officeid").ToString & "'" : com.ExecuteNonQuery()
        Next
        ShowUnfilteredProducts()
        ShowfilteredProducts()
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles cmdMoveLeft.Click
        For I = 0 To gridFiltered.SelectedRowsCount - 1
            com.CommandText = "delete from tblfundfilter where officeid='" & gridFiltered.GetRowCellValue(gridFiltered.GetSelectedRows(I), "officeid").ToString & "' and fundcode='" & fundcode.Text & "'" : com.ExecuteNonQuery()
        Next
        ShowUnfilteredProducts()
        ShowfilteredProducts()
    End Sub


#End Region

End Class