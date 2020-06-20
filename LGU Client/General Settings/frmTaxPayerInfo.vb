Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO
Imports DevExpress.XtraEditors

Public Class frmTaxPayerInfo
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        ElseIf keyData = (Keys.Insert) Then
            If txtAgency.Focused = True Then
                frmDataPicked.fieldname.Text = "agency"
                frmDataPicked.ShowDialog(Me)
                LoadAgency()
            
            End If
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmCustomerInfo_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub frmCustomerInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico
        DXLoadToComboBox("address", "tbltaxpayerprofile", txtAddress, True)
        LoadAgency()
    End Sub

    Public Sub LoadAgency()
        LoadPickedDataTable("agency", txtAgency, gridAgency)
        gridAgency.Columns("id").Visible = False
    End Sub

    Private Sub cmdSaveButton_Click(sender As Object, e As EventArgs) Handles cmdSaveButton.Click
        If countqry("tbltaxpayerprofile", "fullname='" & rchar(txtFullname.Text) & "' and deleted=0") > 0 Then
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
        If XtraMessageBox.Show("Are you sure you want to continue? ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            If mode.Text = "edit" Then
                com.CommandText = "update tbltaxpayerprofile set agencycode='" & txtAgency.EditValue & "',  fullname='" & txtFullname.Text & "', address='" & rchar(txtAddress.Text) & "',contactno='" & txtContactNo.Text & "',tin='" & txtTIN.Text & "', dateentry=current_timestamp,entryby='" & globaluserid & "'  where cifid='" & id.Text & "'" : com.ExecuteNonQuery()
            Else
                com.CommandText = "insert into tbltaxpayerprofile set agencycode='" & txtAgency.EditValue & "', fullname='" & txtFullname.Text & "', address='" & rchar(txtAddress.Text) & "',contactno='" & txtContactNo.Text & "',tin='" & txtTIN.Text & "', dateentry=current_timestamp,entryby='" & globaluserid & "' " : com.ExecuteNonQuery()
            End If
            If trnmode.Text = "collection" Then
                frmCollectionPosting.LoadCustomerInfo(txtFullname.Text, False)
                frmCollectionPosting.txtSearchBar.Focus()
            ElseIf trnmode.Text = "cedulaindividual" Then
                frmCedulaIndividual.LoadCustomerInfo(txtFullname.Text, False)
                If frmCedulaIndividual.txtGender.EditValue = "" Then
                    frmCedulaIndividual.txtGender.Focus()
                Else
                    frmCedulaIndividual.txtBasic.Focus()
                End If
            ElseIf trnmode.Text = "property" Then
                frmRealPropertyInfo.LoadCustomerInfo(txtFullname.Text, False)

            ElseIf trnmode.Text = "businessinfo" Then
                frmBusinessInfo.LoadCustomerInfo(txtFullname.Text, False)

            End If

            id.Text = "" : mode.Text = "" : txtAgency.EditValue = Nothing : txtFullname.Text = "" : txtAddress.Text = "" : txtContactNo.Text = "" : txtTIN.Text = "" : trnmode.Text = ""
            Me.Close()
        End If
    End Sub

    Public Sub showInfo()
        If id.Text = "" Then Exit Sub
        com.CommandText = "select * from tbltaxpayerprofile where cifid='" & id.Text & "'" : rst = com.ExecuteReader
        While rst.Read
            txtAgency.EditValue = rst("agencycode").ToString
            txtFullname.Text = rst("fullname").ToString
            txtAddress.Text = rst("address").ToString
            txtContactNo.Text = rst("contactno").ToString
            txtTIN.Text = rst("tin").ToString
        End While
        rst.Close()
    End Sub

    Private Sub id_EditValueChanged(sender As Object, e As EventArgs) Handles id.EditValueChanged
        showInfo()
    End Sub

    Private Sub cmdAgency_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles cmdAgency.LinkClicked
        frmDataPicked.fieldname.Text = "agency"
        frmDataPicked.Text = "Agency Table"
        frmDataPicked.ShowDialog(Me)
        LoadAgency()
    End Sub
End Class