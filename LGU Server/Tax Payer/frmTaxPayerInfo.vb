Imports DevExpress.XtraEditors
Imports DevExpress.Skins
Imports MySql.Data.MySqlClient

Public Class frmTaxPayerInfo

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Insert) Then
            If txtAgency.Focused = True Then
                frmDataPicked.fieldname.Text = "agency"
                frmDataPicked.ShowDialog(Me)
                LoadAgency()
            ElseIf txtCitizenship.Focused = True Then
                frmDataPicked.fieldname.Text = "citizenship"
                frmDataPicked.Text = "Citizenship Table"
                frmDataPicked.ShowDialog(Me)
                LoadCitizenship()
            ElseIf txtPlaceOfBirth.Focused = True Then
                frmDataPicked.fieldname.Text = "birthplace"
                frmDataPicked.Text = "Birthplace Table"
                frmDataPicked.ShowDialog(Me)
                LoadBirthplace()
            ElseIf txtProfession.Focused = True Then
                frmDataPicked.fieldname.Text = "profession"
                frmDataPicked.Text = "Profession Table"
                frmDataPicked.ShowDialog(Me)
                LoadProfession()
            End If
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmTaxPayerInfo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        LoadAgency() : LoadCitizenship() : LoadBirthplace() : LoadProfession()
        If mode.Text = "view" Then
            LoadCustomerInfo()
        Else
            ClearCustomerInfo()
        End If
    End Sub


    Public Sub LoadCustomerInfo()
        If cifid.Text = "" Then Exit Sub
        dst = Nothing : dst = New DataSet
        msda = New MySqlDataAdapter("select * from tbltaxpayerprofile where cifid='" & cifid.Text & "'  and deleted=0", conn)
        msda.Fill(dst, 0)
        For cnt = 0 To dst.Tables(0).Rows.Count - 1
            With (dst.Tables(0))
                txtAgency.EditValue = .Rows(cnt)("agencycode").ToString()
                cifid.Text = .Rows(cnt)("cifid").ToString()
                txtFullname.Text = .Rows(cnt)("fullname").ToString()
                txtContactNo.EditValue = .Rows(cnt)("contactno").ToString()
                txtTIN.Text = .Rows(cnt)("tin").ToString()
                txtGender.EditValue = .Rows(cnt)("gender").ToString()
                txtAddress.Text = .Rows(cnt)("address").ToString()
                txtCivilStatus.EditValue = .Rows(cnt)("civilstatus").ToString()
                txtCitizenship.EditValue = .Rows(cnt)("citizenship").ToString()
                txtBirthdate.EditValue = If(.Rows(cnt)("birthdate").ToString = "", "", CDate(.Rows(cnt)("birthdate").ToString))
                txtPlaceOfBirth.EditValue = .Rows(cnt)("birthplace").ToString()
                txtHeight.Text = .Rows(cnt)("height").ToString()
                txtWeight.Text = .Rows(cnt)("weight").ToString()
                txtProfession.EditValue = .Rows(cnt)("profession").ToString()
            End With
        Next
        EnableReadonly(True)
    End Sub

    Public Sub EnableReadonly(ByVal yes As Boolean)
        txtAgency.ReadOnly = yes
        txtFullname.ReadOnly = yes
        txtContactNo.ReadOnly = yes
        txtTIN.ReadOnly = yes
        txtGender.ReadOnly = yes
        txtAddress.ReadOnly = yes
        txtCivilStatus.ReadOnly = yes
        txtCitizenship.ReadOnly = yes
        txtBirthdate.ReadOnly = yes
        txtPlaceOfBirth.ReadOnly = yes
        txtHeight.ReadOnly = yes
        txtWeight.ReadOnly = yes
        txtProfession.ReadOnly = yes

        If mode.Text = "view" Then
            cmdSaveButton.Text = "Update Information"
            cmdSaveButton.Appearance.BackColor = System.Drawing.Color.FromArgb(255, 255, 128)
        Else
            cmdSaveButton.Text = "Save Information"
            cmdSaveButton.Appearance.BackColor = System.Drawing.Color.FromArgb(128, 255, 128)
        End If
    End Sub

    Public Sub ClearCustomerInfo()
        cifid.Text = "AUTO GENERATED"
        txtFullname.Text = ""
        txtTIN.EditValue = Nothing
        txtContactNo.EditValue = Nothing
        txtGender.EditValue = Nothing
        txtAddress.EditValue = Nothing
        txtCivilStatus.EditValue = Nothing
        txtCitizenship.EditValue = Nothing
        txtBirthdate.EditValue = Nothing
        txtPlaceOfBirth.EditValue = Nothing
        txtHeight.EditValue = Nothing
        txtWeight.EditValue = Nothing
        txtProfession.EditValue = Nothing
        txtFullname.Focus()
        mode.Text = ""
        EnableReadonly(False)
    End Sub

    Public Sub LoadAgency()
        LoadPickedDataTable("agency", txtAgency, gridAgency, Me)
        gridAgency.Columns("id").Visible = False
    End Sub


    Public Sub LoadCitizenship()
        LoadPickedDataTable("citizenship", txtCitizenship, gridCitizenship, Me)
        gridCitizenship.Columns("id").Visible = False
    End Sub

    Public Sub LoadBirthplace()
        LoadPickedDataTable("birthplace", txtPlaceOfBirth, gridBirthplace, Me)
        gridBirthplace.Columns("id").Visible = False
    End Sub

    Public Sub LoadProfession()
        LoadPickedDataTable("profession", txtProfession, gridProfession, Me)
        gridProfession.Columns("id").Visible = False
    End Sub


    Private Sub cmdCitizenship_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles cmdCitizenship.LinkClicked
        frmDataPicked.fieldname.Text = "citizenship"
        frmDataPicked.Text = "Citizenship Table"
        frmDataPicked.ShowDialog(Me)
        LoadCitizenship()
    End Sub

    Private Sub cmdPlaceofBirth_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles cmdPlaceofBirth.LinkClicked
        frmDataPicked.fieldname.Text = "birthplace"
        frmDataPicked.Text = "Birthplace Table"
        frmDataPicked.ShowDialog(Me)
        LoadBirthplace()
    End Sub

    Private Sub cmdProfession_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles cmdProfession.LinkClicked
        frmDataPicked.fieldname.Text = "profession"
        frmDataPicked.Text = "Profession Table"
        frmDataPicked.ShowDialog(Me)
        LoadProfession()
    End Sub

    Private Sub cmdSaveButton_Click(sender As Object, e As EventArgs) Handles cmdSaveButton.Click
        If mode.Text = "view" Then
            mode.Text = "edit"
            EnableReadonly(False)
        Else
            If countqry("tbltaxpayerprofile", "fullname='" & rchar(txtFullname.Text) & "' and cifid<>'" & cifid.Text & "' and deleted=0") > 0 Then
                XtraMessageBox.Show("Please customer name already exists on the record! Please search exact keyword", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtFullname.Focus()
                Exit Sub
            ElseIf txtAgency.Text = "" Then
                XtraMessageBox.Show("Please select agency!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtAgency.Focus()
                Exit Sub
            ElseIf txtFullname.Text = "" Then
                XtraMessageBox.Show("Please enter fullname!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtFullname.Focus()
                Exit Sub
            ElseIf txtAddress.Text = "" Then
                XtraMessageBox.Show("Please enter address!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtAddress.Focus()
                Exit Sub
            End If
            If mode.Text = "edit" Then
                com.CommandText = "update tbltaxpayerprofile set agencycode='" & txtAgency.EditValue & "',fullname='" & rchar(txtFullname.Text) & "',address='" & rchar(txtAddress.Text) & "',contactno='" & txtContactNo.Text & "', gender='" & txtGender.EditValue & "',civilstatus='" & txtCivilStatus.EditValue & "', citizenship='" & txtCitizenship.EditValue & "', " & If(txtBirthdate.Text <> "", "birthdate='" & ConvertDate(txtBirthdate.EditValue) & "', ", "") & " birthplace='" & txtPlaceOfBirth.EditValue & "', height='" & rchar(txtHeight.Text) & "', weight='" & rchar(txtWeight.Text) & "', profession='" & txtProfession.EditValue & "', tin='" & txtTIN.Text & "' where cifid='" & cifid.Text & "' " : com.ExecuteNonQuery()
                XtraMessageBox.Show("Record successfully updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            Else
                com.CommandText = "insert into tbltaxpayerprofile set agencycode='" & txtAgency.EditValue & "', fullname='" & rchar(txtFullname.Text) & "', address='" & rchar(txtAddress.Text) & "',contactno='" & txtContactNo.Text & "', gender='" & txtGender.EditValue & "',civilstatus='" & txtCivilStatus.EditValue & "', citizenship='" & txtCitizenship.EditValue & "', " & If(txtBirthdate.Text <> "", "birthdate='" & ConvertDate(txtBirthdate.EditValue) & "', ", "") & " birthplace='" & txtPlaceOfBirth.EditValue & "', height='" & rchar(txtHeight.Text) & "', weight='" & rchar(txtWeight.Text) & "', profession='" & txtProfession.EditValue & "', tin='" & txtTIN.Text & "', dateentry=current_timestamp, entryby='" & globaluserid & "' " : com.ExecuteNonQuery()
                ClearCustomerInfo()
                XtraMessageBox.Show("Record successfully added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If

    End Sub

    Private Sub cifid_EditValueChanged(sender As Object, e As EventArgs) Handles cifid.EditValueChanged
        If cifid.Text = "AUTO GENERATED" Or cifid.Text = "" Then Exit Sub
        LoadCustomerInfo()
    End Sub
End Class