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
        loadOfficer()
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
            XtraMessageBox.Show("Please provide Department short name!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtShortName.Focus()
            Exit Sub
        ElseIf txtCompanyName.Text = "" Then
            XtraMessageBox.Show("Please provide Department Name!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtCompanyName.Focus()
            Exit Sub

        End If

        If mode.Text <> "edit" Then
           If countqry("tblcompoffice", "officename='" & rchar(txtCompanyName.Text) & "'") <> 0 Then
                XtraMessageBox.Show("Duplicate Department Name! please use unique one.", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtCompanyName.Focus()
                Exit Sub
            ElseIf countqry("tblcompoffice", "shortname='" & txtShortName.Text & "'") <> 0 Then
                XtraMessageBox.Show("Duplicate Department short name! please use unique one.", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtShortName.Focus()
                Exit Sub
            ElseIf countrecord("tblcompofficeseries") = 0 Then
                XtraMessageBox.Show("Office series not configured.", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
            Dim officeid As String = GetOfficeid()
            com.CommandText = "insert into tblcompoffice set officeid='" & officeid & "',officename='" & rchar(txtCompanyName.Text) & "',shortname='" & rchar(Trim(txtShortName.Text)) & "',centercode='" & txtCenterCode.Text & "', address='" & rchar(txtAddress.Text) & "', contactnumber='" & txtContactNumber.Text & "', officeemail='" & txtEmailAddress.Text & "',officerid='" & userid.Text & "'" : com.ExecuteNonQuery()
        Else
            com.CommandText = "update tblcompoffice set officename='" & rchar(txtCompanyName.Text) & "',shortname='" & rchar(Trim(txtShortName.Text)) & "',centercode='" & txtCenterCode.Text & "',  address='" & rchar(txtAddress.Text) & "', contactnumber='" & txtContactNumber.Text & "', officeemail='" & txtEmailAddress.Text & "',officerid='" & userid.Text & "' where officeid='" & id.Text & "'" : com.ExecuteNonQuery()
        End If

        clearfields()
        frmDepartment.filter()
        XtraMessageBox.Show("Office successfully saved!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Dim GlobalNumberOfDevision As Integer = 0
        Dim m_procurement As String = ""
        Dim InfoFile As String = ""
        If System.IO.File.Exists(Application.StartupPath.ToString & "\System.config") Then
            If System.IO.File.Exists(System_config) Then
                InfoFile = DecryptTripleDES(ReadFile(System_config))
                For Each strLine As String In InfoFile.Split(vbCrLf)
                    Dim word As String() = strLine.Split("=")
                    If word(0) = "division" Then
                        GlobalNumberOfDevision = word(1)
                    End If
                Next
            End If
        Else
            GlobalNumberOfDevision = 1
        End If
        If GlobalNumberOfDevision > 0 Then
            If countrecord("tblcompoffice") >= GlobalNumberOfDevision Then
                Me.Close()
            End If
        End If
    End Sub


    Public Sub loadOfficer()
        LoadXgridLookupSearch("select accountid, Fullname from tblaccounts where username<>'ROOT'", "tblaccounts", txtOfficerIncharge, s_grid, Me)
        s_grid.Columns("accountid").Visible = False
    End Sub

    Private Sub txtrequestby_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtOfficerIncharge.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtOfficerIncharge.Properties.View.FocusedRowHandle.ToString)
        userid.Text = txtOfficerIncharge.Properties.View.GetFocusedRowCellValue("accountid").ToString()
        txtOfficerIncharge.Text = txtOfficerIncharge.Properties.View.GetFocusedRowCellValue("Fullname").ToString()
    End Sub

    Public Sub clearfields()
        id.Text = ""
        txtShortName.Text = ""
        txtCompanyName.Text = ""
        txtAddress.Text = ""
        txtCenterCode.Text = ""
        txtContactNumber.Text = ""
        txtEmailAddress.Text = ""
        txtOfficerIncharge.Properties.DataSource = Nothing
        txtOfficerIncharge.Text = ""
        loadOfficer()
        userid.Text = ""
        mode.Text = ""

    End Sub

    Private Sub mode_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mode.EditValueChanged
        If mode.Text = "" Then Exit Sub
        com.CommandText = "select *, (select fullname from tblaccounts where accountid = tblcompoffice.officerid) as 'officer' from tblcompoffice where officeid='" & id.Text & "'"
        rst = com.ExecuteReader
        While rst.Read
            txtShortName.Text = rst("shortname").ToString
            txtCompanyName.Text = rst("officename").ToString
            txtCenterCode.Text = rst("centercode").ToString
            txtAddress.Text = rst("address").ToString
            txtContactNumber.Text = rst("contactnumber").ToString
            txtEmailAddress.Text = rst("officeemail").ToString
            txtOfficerIncharge.Text = rst("officer").ToString
            userid.Text = rst("officerid").ToString
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


End Class