Imports DevExpress.XtraEditors
Imports DevExpress
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraReports.UI
Imports DevExpress.Skins

Public Class frmDepartmentInfo
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        ElseIf keyData = Keys.F1 Then

        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmProductCat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        LoadOfficer()

        If globalAllowAdd = True Or LCase(globaluser) = "root" Then
            cmdSave.Enabled = True
        Else
            cmdSave.Enabled = False
        End If
        If globalAllowEdit = True Or LCase(globaluser) = "root" Then
            cmdEdit.Visible = True
        Else
            cmdEdit.Visible = False
        End If
        If globalAllowDelete = True Or LCase(globaluser) = "root" Then
            cmdRemove.Enabled = True
        Else
            cmdRemove.Enabled = False
        End If
    End Sub

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        If txtShortName.Text = "" Then
            XtraMessageBox.Show("Please provide Office short name!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtShortName.Focus()
            Exit Sub
        ElseIf txtCompanyName.Text = "" Then
            XtraMessageBox.Show("Please provide Office Name!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtCompanyName.Focus()
            Exit Sub

        End If

        If mode.Text <> "edit" Then
           If countqry("tblcompoffice", "officename='" & rchar(txtCompanyName.Text) & "'") <> 0 Then
                XtraMessageBox.Show("Duplicate Office Name! please use unique one.", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtCompanyName.Focus()
                Exit Sub
            ElseIf countqry("tblcompoffice", "shortname='" & txtShortName.Text & "'") <> 0 Then
                XtraMessageBox.Show("Duplicate Office short name! please use unique one.", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtShortName.Focus()
                Exit Sub
            ElseIf countrecord("tblcompofficeseries") = 0 Then
                XtraMessageBox.Show("Office series not configured.", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
            Dim officeid As String = GetOfficeid()
            com.CommandText = "insert into tblcompoffice set officeid='" & officeid & "',officename='" & rchar(txtCompanyName.Text) & "',shortname='" & rchar(Trim(txtShortName.Text)) & "',centercode='" & txtCenterCode.Text & "', address='" & rchar(txtAddress.Text) & "', contactnumber='" & txtContactNumber.Text & "', officeemail='" & txtEmailAddress.Text & "',officerid='" & userid.Text & "', sb=" & ckSB.CheckState & "" : com.ExecuteNonQuery()
            com.CommandText = "update tblcompofficerlog set officeid='" & officeid & "' where officeid='" & globaluserid & "-temp" & "'" : com.ExecuteNonQuery()
        Else
            com.CommandText = "update tblcompoffice set officename='" & rchar(txtCompanyName.Text) & "',shortname='" & rchar(Trim(txtShortName.Text)) & "',centercode='" & txtCenterCode.Text & "',  address='" & rchar(txtAddress.Text) & "', contactnumber='" & txtContactNumber.Text & "', officeemail='" & txtEmailAddress.Text & "',officerid='" & userid.Text & "', sb=" & ckSB.CheckState & " where officeid='" & id.Text & "'" : com.ExecuteNonQuery()
        End If

        clearfields()
        frmDepartment.filter()
        XtraMessageBox.Show("Office successfully saved!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub


    Public Sub clearfields()
        id.Text = ""
        txtShortName.Text = ""
        txtCompanyName.Text = ""
        txtAddress.Text = ""
        txtCenterCode.Text = ""
        txtContactNumber.Text = ""
        txtEmailAddress.Text = ""
        userid.Text = ""
        mode.Text = ""
        ckSB.Checked = False
        LoadOfficer()
    End Sub

    Public Sub LoadOfficer()
        LoadXgrid("Select id, (select fullname from tblaccounts where accountid=a.officerid) as 'Officer Name',position, date_format(datefrom,'%Y-%m-%d') as 'Date From', date_format(datefrom,'%Y-%m-%d') as 'Date To', Current from tblcompofficerlog as a where officeid='" & id.Text & "' order by datefrom asc", "tblcompofficerlog", Em, GridView1, Me)
        XgridHideColumn({"id"}, GridView1)
        XgridColAlign({"Date From", "Date To", "Current"}, GridView1, DevExpress.Utils.HorzAlignment.Center)
        GridView1.BestFitColumns()
    End Sub

    Private Sub cmdEdit_Click(sender As Object, e As EventArgs) Handles cmdEdit.Click
        frmDepartmentOfficer.id.Text = GridView1.GetFocusedRowCellValue("id").ToString
        frmDepartmentOfficer.mode.Text = "edit"
        frmDepartmentOfficer.ShowDialog(Me)
    End Sub

    Private Sub mode_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mode.EditValueChanged
        If mode.Text = "" Then Exit Sub
        com.CommandText = "select * from tblcompoffice where officeid='" & id.Text & "'"
        rst = com.ExecuteReader
        While rst.Read
            txtShortName.Text = rst("shortname").ToString
            txtCompanyName.Text = rst("officename").ToString
            txtCenterCode.Text = rst("centercode").ToString
            txtAddress.Text = rst("address").ToString
            txtContactNumber.Text = rst("contactnumber").ToString
            txtEmailAddress.Text = rst("officeemail").ToString
            ckSB.Checked = CBool(rst("sb").ToString)
        End While
        rst.Close()
    End Sub

    Private Sub frmProductCat_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        clearfields()
    End Sub


    Private Sub BarLargeButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdClose.ItemClick
        Me.Close()
    End Sub

    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        clearfields()
    End Sub

    Private Sub cmdUpdateAccountable_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUpdateAccountable.Click
        Me.Close()
    End Sub

    Private Sub AddOfficerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddOfficerToolStripMenuItem.Click
        frmDepartmentOfficer.officeid.Text = If(id.Text = "", globaluserid & "-temp", id.Text)
        frmDepartmentOfficer.ShowDialog()
    End Sub

    Private Sub cmdRemove_Click(sender As Object, e As EventArgs) Handles cmdRemove.Click
        If GridView1.GetFocusedRowCellValue("id").ToString = "" Then
            XtraMessageBox.Show("There is no item selected! make sure, the selection is on the list", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        If XtraMessageBox.Show("Are you sure you want to permanently delete this item? " & todelete, compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            For I = 0 To GridView1.SelectedRowsCount - 1
                com.CommandText = "delete from tblcompofficerlog where id='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "id") & "' " : com.ExecuteNonQuery()
            Next
            LoadOfficer()
        End If
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        LoadOfficer()
    End Sub
End Class