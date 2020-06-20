Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO
Imports DevExpress.XtraEditors

Public Class frmBusinessInfo
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        ElseIf keyData = (Keys.Insert) Then

            If txtPlaceofIncorporation.Focused = True Then
                frmDataPicked.fieldname.Text = "placeofincorporation"
                frmDataPicked.ShowDialog(Me)
                LoadPlaceofIncorporation()
            End If

            
            If txtNatureofBusiness.Focused = True Then
                frmDataPicked.fieldname.Text = "natureofbusiness"
                frmDataPicked.ShowDialog(Me)
                LoadNatureofBusiness()
            End If

            
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmBusinessManagement_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub frmBusinessManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico
        DXLoadToComboBox("address", "tbltaxpayerprofile", txtAddress, True)
        txtDateIncorporation.EditValue = CDate(Now)
        LoadPlaceofIncorporation()
        LoadNatureofBusiness()
        If mode.Text = "edit" Then
            showBusinessInfo()
        End If
    End Sub

    Private Sub txtFullname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTaxPayerName.KeyPress
        If e.KeyChar = Chr(13) Then
            If RemoveWhiteSpaces(txtTaxPayerName.Text, False) = "" Or RemoveWhiteSpaces(txtTaxPayerName.Text, False) = "%" Then Exit Sub
            If countqry("tbltaxpayerprofile", "fullname = '" & RemoveWhiteSpaces(txtTaxPayerName.Text, False) & "' and deleted=0") = 0 Then
                If countqry("tbltaxpayerprofile", "fullname like '%" & RemoveWhiteSpaces(txtTaxPayerName.Text, False) & "%' and deleted=0") = 0 Then
                    If XtraMessageBox.Show("No match found on your search query! Do you want to add new payors information?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
                        frmTaxPayerInfo.trnmode.Text = "businessinfo"
                        frmTaxPayerInfo.ShowDialog(Me)
                    End If
                Else
                    DXLoadToComboBoxQuery("fullname", "SELECT fullname FROM tbltaxpayerprofile  where fullname like '%" & RemoveWhiteSpaces(txtTaxPayerName.Text, False) & "%' and deleted=0 order by fullname asc;", txtTaxPayerName)
                End If
                txtTaxPayerName.ShowPopup()
                Exit Sub
            Else
                LoadCustomerInfo(RemoveWhiteSpaces(txtTaxPayerName.Text, False), False)
            End If
        End If
    End Sub

    Public Sub LoadCustomerInfo(ByVal parameter As String, ByVal querybyid As Boolean)
        dst = Nothing : dst = New DataSet
        If querybyid = True Then
            msda = New MySqlDataAdapter("select * from tbltaxpayerprofile where cifid='" & parameter & "'  and deleted=0", conn)
        Else
            msda = New MySqlDataAdapter("select * from tbltaxpayerprofile where fullname='" & parameter & "'  and deleted=0", conn)
        End If
        msda.Fill(dst, 0)
        For cnt = 0 To dst.Tables(0).Rows.Count - 1
            With (dst.Tables(0))
                cifid.Text = .Rows(cnt)("cifid").ToString()
                txtTaxPayerName.Text = .Rows(cnt)("fullname").ToString()
                txtTIN.Text = .Rows(cnt)("tin").ToString()
            End With
        Next
    End Sub

    Public Sub LoadPlaceofIncorporation()
        LoadPickedDataTable("placeofincorporation", txtPlaceofIncorporation, gridPlaceofIncorporation)
        gridPlaceofIncorporation.Columns("id").Visible = False
    End Sub
 
    Public Sub LoadNatureofBusiness()
        LoadPickedDataTable("natureofbusiness", txtNatureofBusiness, gridNatureofBusiness)
        gridNatureofBusiness.Columns("id").Visible = False
    End Sub

    Private Sub cmdSaveButton_Click(sender As Object, e As EventArgs) Handles cmdSaveButton.Click
        If cifid.Text = "" Then
            XtraMessageBox.Show("Please select taxpayer name!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtTaxPayerName.Focus()
            Exit Sub
        ElseIf txtCompanyName.Text = "" Then
            XtraMessageBox.Show("Please enter company name!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtCompanyName.Focus()
            Exit Sub
        ElseIf txtAddress.Text = "" Then
            XtraMessageBox.Show("Please enter address!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtAddress.Focus()
            Exit Sub
        ElseIf txtKindofOrganization.Text = "" Then
            XtraMessageBox.Show("Please select kind of business!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtKindofOrganization.Focus()
            Exit Sub
        ElseIf txtNatureofBusiness.Text = "" Then
            XtraMessageBox.Show("Please select nature of business!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtNatureofBusiness.Focus()
            Exit Sub
        ElseIf txtContactPerson.Text = "" Then
            XtraMessageBox.Show("Please enter contact person!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtContactPerson.Focus()
            Exit Sub
        ElseIf txtContactNo.Text = "" Then
            XtraMessageBox.Show("Please enter contact number!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtContactNo.Focus()
            Exit Sub
        End If
        If XtraMessageBox.Show("Are you sure you want to continue? ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            If mode.Text = "edit" Then
                com.CommandText = "update tblbusiness set cifid='" & cifid.Text & "', companyname='" & rchar(txtCompanyName.Text) & "', address='" & rchar(txtAddress.Text) & "',placeincorporation='" & txtPlaceofIncorporation.EditValue & "',dateregincorporation='" & ConvertDate(txtDateIncorporation.EditValue) & "', kindoforganization='" & txtKindofOrganization.EditValue & "',businessnature='" & txtNatureofBusiness.EditValue & "',contactperson='" & rchar(txtContactPerson.Text) & "', contactnumber='" & txtContactNo.Text & "', tin='" & txtTIN.EditValue & "', actived=" & ckActived.CheckState & " where id='" & id.Text & "'" : com.ExecuteNonQuery()
                frmBusinessManagement.ViewList()
                XtraMessageBox.Show("Record successfully updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            Else
                com.CommandText = "insert into tblbusiness set cifid='" & cifid.Text & "', companyname='" & rchar(txtCompanyName.Text) & "', address='" & rchar(txtAddress.Text) & "',placeincorporation='" & txtPlaceofIncorporation.EditValue & "', dateregincorporation='" & ConvertDate(txtDateIncorporation.EditValue) & "',kindoforganization='" & txtKindofOrganization.EditValue & "',businessnature='" & txtNatureofBusiness.EditValue & "',contactperson='" & rchar(txtContactPerson.Text) & "', contactnumber='" & txtContactNo.Text & "',tin='" & txtTIN.EditValue & "', actived=" & ckActived.CheckState & ", datetrn=current_timestamp, trnby='" & globaluserid & "'" : com.ExecuteNonQuery()
                If trnmode.Text = "cedulacorporate" Then
                    frmCedulaCorporation.LoadCustomerInfo(txtCompanyName.Text, False)
                    frmCedulaCorporation.txtBasic.Focus()
                    Me.Close()
                Else
                    ClearInfo()
                    frmBusinessManagement.ViewList()
                    XtraMessageBox.Show("Record successfully updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        End If
    End Sub

    Public Sub showBusinessInfo()
        If id.Text = "" Then Exit Sub
        dst = Nothing : dst = New DataSet
        msda = New MySqlDataAdapter("select *,(select fullname from tbltaxpayerprofile where cifid=tblbusiness.cifid) as taxpayer from tblbusiness where id='" & id.Text & "'", conn)
        msda.Fill(dst, 0)
        For cnt = 0 To dst.Tables(0).Rows.Count - 1
            With (dst.Tables(0))
                cifid.Text = .Rows(cnt)("cifid").ToString
                txtTaxPayerName.Text = .Rows(cnt)("taxpayer").ToString
                txtCompanyName.Text = .Rows(cnt)("companyname").ToString
                txtAddress.Text = .Rows(cnt)("address").ToString
                txtPlaceofIncorporation.EditValue = .Rows(cnt)("placeincorporation").ToString
                txtDateIncorporation.EditValue = .Rows(cnt)("dateregincorporation").ToString
                txtKindofOrganization.EditValue = .Rows(cnt)("kindoforganization").ToString
                txtNatureofBusiness.EditValue = .Rows(cnt)("businessnature").ToString
                txtContactPerson.Text = .Rows(cnt)("contactperson").ToString
                txtContactNo.Text = .Rows(cnt)("contactnumber").ToString
                txtTIN.EditValue = .Rows(cnt)("tin").ToString
                ckActived.Checked = CBool(.Rows(cnt)("actived").ToString)
            End With
        Next
    End Sub

    Public Sub ClearInfo()
        cifid.Text = ""
        txtTaxPayerName.Text = ""
        txtCompanyName.Text = ""
        txtAddress.Text = ""
        txtPlaceofIncorporation.EditValue = Nothing
        txtDateIncorporation.EditValue = CDate(Now)
        txtKindofOrganization.EditValue = Nothing
        txtNatureofBusiness.EditValue = Nothing
        txtContactPerson.Text = ""
        txtContactNo.Text = ""
        txtTIN.EditValue = Nothing
        mode.Text = ""
        id.Text = ""
        txtTaxPayerName.Focus()
    End Sub

    Private Sub id_EditValueChanged(sender As Object, e As EventArgs) Handles id.EditValueChanged
        showBusinessInfo()
    End Sub


    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        frmDataPicked.fieldname.Text = "placeofincorporation"
        frmDataPicked.ShowDialog(Me)
        LoadPlaceofIncorporation()
    End Sub
     
    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        frmDataPicked.fieldname.Text = "natureofbusiness"
        frmDataPicked.ShowDialog(Me)
        LoadNatureofBusiness()
    End Sub

End Class