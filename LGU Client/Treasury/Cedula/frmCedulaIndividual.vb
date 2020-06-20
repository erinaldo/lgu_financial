Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmCedulaIndividual
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Insert) Then
            If txtCitizenship.Focused = True Then
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

    Private Sub frmCommunityTaxCollection_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub frmCommunityTaxCollection_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico
        txtPlaceIssue.Text = GlobalOrganizationName
        LoadCitizenship() : LoadBirthplace() : LoadProfession()
        com.CommandText = "DROP table if exists tmpcommunitytax;" : com.ExecuteNonQuery()
        com.CommandText = "CREATE TEMPORARY TABLE `tmpcommunitytax` (`id` int(10) unsigned NOT NULL AUTO_INCREMENT,`fundcode` varchar(5) NOT NULL,`yeartrn` varchar(4) NOT NULL,`cifid` varchar(100) NOT NULL,`communitytaxno` varchar(45) NOT NULL,`basiccomunitytax` double NOT NULL DEFAULT '0',`additionalcomunitytax` double NOT NULL DEFAULT '0',`inputbusiness` double NOT NULL DEFAULT '0',`totalbusiness` double NOT NULL DEFAULT '0',`inputsalary` double NOT NULL DEFAULT '0',`totalsalary` double NOT NULL DEFAULT '0',`inputrealproperty` double NOT NULL DEFAULT '0',`totalrealproperty` double NOT NULL DEFAULT '0',`subtotal` double NOT NULL DEFAULT '0',`intrate` double NOT NULL DEFAULT '0',`interest` double NOT NULL DEFAULT '0',`amountpaid` double NOT NULL DEFAULT '0',`postingdate` date NOT NULL,`processedby` varchar(100) NOT NULL,`dateprocessed` datetime NOT NULL,PRIMARY KEY (`id`)) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=latin1;" : com.ExecuteNonQuery()
        If mode.Text = "edit" Then
            txtFormTitle.Text = "EDITING MODE TRANSACTION"
            txtFormTitle.BackColor = Color.Red
            txtFormTitle.ForeColor = Color.White
            cmdEnterPayment.Text = "Confirm Update"
            yeartrn.ReadOnly = False
            txtCollectionDate.ReadOnly = False
            LoadCustomerInfo(cifid.Text, True)
        Else
            yeartrn.ReadOnly = True
            txtCollectionDate.ReadOnly = True
            BeginNewTransaction()
        End If
    End Sub

    Public Sub BeginNewTransaction()
        Dim ProceedOR As Boolean = False
        com.CommandText = "select * from tblforminventory where officeid='" & compOfficeid & "' and accountable='" & globaluserid & "' and inused=1 and formcode in (select defaultcedulaindividual from tbldefaultsettings) " : rst = com.ExecuteReader
        While rst.Read
            invrefcode.Text = rst("id").ToString
            formcode.Text = rst("formcode").ToString
            If Val(rst("currentno").ToString) = 0 Then
                txtORNumber.Text = ""
                ProceedOR = False
            Else
                txtORNumber.Text = rst("currentno").ToString
                ProceedOR = True
            End If
        End While
        rst.Close()
        If ProceedOR = False Then
            txtFormTitle.Text = "CEDULA REACHED SERIES NUMBER LIMIT"
            txtFormTitle.BackColor = Color.Red
            txtFormTitle.ForeColor = Color.White
            EnableControl(False)
        Else
            txtFormTitle.Text = txtFundTitle.Text
            txtFormTitle.BackColor = Color.WhiteSmoke
            txtFormTitle.ForeColor = Color.Blue
            EnableControl(True)
        End If
        ClearCustomerInfo()
    End Sub

    Public Sub ClearCustomerInfo()
        cifid.Text = ""
        txtFullname.Text = ""
        txtTIN.EditValue = Nothing
        txtGender.EditValue = Nothing
        txtAddress.EditValue = Nothing
        txtCivilStatus.EditValue = Nothing
        txtCitizenship.EditValue = Nothing
        txtICRNo.EditValue = Nothing
        txtBirthdate.EditValue = Nothing
        txtPlaceOfBirth.EditValue = Nothing
        txtHeight.EditValue = Nothing
        txtWeight.EditValue = Nothing
        txtProfession.EditValue = Nothing
        txtBasic.Text = "0"
        txtAdditional.Text = "0"
        txtInputBusiness.Text = "0"
        txtInputSalaries.Text = "0"
        txtInputRealProperty.Text = "0"
        txtInterestRate.Text = "0"
        txtFullname.Focus()
    End Sub

    Public Sub LoadCitizenship()
        LoadPickedDataTable("citizenship", txtCitizenship, gridCitizenship)
        gridCitizenship.Columns("id").Visible = False
    End Sub

    Public Sub LoadBirthplace()
        LoadPickedDataTable("birthplace", txtPlaceOfBirth, gridBirthplace)
        gridBirthplace.Columns("id").Visible = False
    End Sub

    Public Sub LoadProfession()
        LoadPickedDataTable("profession", txtProfession, gridProfession)
        gridProfession.Columns("id").Visible = False
    End Sub

    Private Sub txtFullname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFullname.KeyPress
        If e.KeyChar = Chr(13) Then
            If RemoveWhiteSpaces(txtFullname.Text, False) = "" Or RemoveWhiteSpaces(txtFullname.Text, False) = "%" Then Exit Sub
            If countqry("tbltaxpayerprofile", "fullname = '" & RemoveWhiteSpaces(txtFullname.Text, False) & "' and deleted=0") = 0 Then

                If countqry("tbltaxpayerprofile", "fullname like '%" & RemoveWhiteSpaces(txtFullname.Text, False) & "%' and deleted=0") = 0 Then
                    If XtraMessageBox.Show("No match found on your search query! Do you want to add new payors information?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
                        frmTaxPayerInfo.trnmode.Text = "cedulaindividual"
                        frmTaxPayerInfo.ShowDialog(Me)
                    End If
                Else
                    DXLoadToComboBoxQuery("fullname", "SELECT fullname FROM tbltaxpayerprofile  where fullname like '%" & RemoveWhiteSpaces(txtFullname.Text, False) & "%' and deleted=0 order by fullname asc;", txtFullname)
                End If
                txtFullname.ShowPopup()
                Exit Sub
            Else
                LoadCustomerInfo(RemoveWhiteSpaces(txtFullname.Text, False), False)
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
                txtFullname.Text = .Rows(cnt)("fullname").ToString()
                txtTIN.Text = .Rows(cnt)("tin").ToString()
                txtGender.EditValue = .Rows(cnt)("gender").ToString()
                txtAddress.Text = .Rows(cnt)("address").ToString()
                txtCivilStatus.EditValue = .Rows(cnt)("civilstatus").ToString()
                txtCitizenship.EditValue = .Rows(cnt)("citizenship").ToString()
                txtICRNo.Text = .Rows(cnt)("icrno").ToString()
                txtBirthdate.EditValue = If(.Rows(cnt)("birthdate").ToString = "", "", CDate(.Rows(cnt)("birthdate").ToString))
                txtPlaceOfBirth.EditValue = .Rows(cnt)("birthplace").ToString()
                txtHeight.Text = .Rows(cnt)("height").ToString()
                txtWeight.Text = .Rows(cnt)("weight").ToString()
                txtProfession.EditValue = .Rows(cnt)("profession").ToString()
                If .Rows(cnt)("gender").ToString() = "" Then
                    txtGender.Focus()
                Else
                    txtBasic.Focus()
                End If
            End With
        Next
        If mode.Text = "edit" Then
            loadCedulaInfo()
        End If
    End Sub

    Public Sub loadCedulaInfo()
        com.CommandText = "select * from tblcommunitytax where jevno='" & jevid.Text & "'" : rst = com.ExecuteReader
        While rst.Read
            txtORNumber.Text = rst("communitytaxno").ToString
            txtCollectionDate.EditValue = rst("postingdate").ToString
            yeartrn.Text = rst("yeartrn").ToString
            fundcode.Text = rst("fundcode").ToString
            txtBasic.Text = rst("basiccomunitytax")
            txtAdditional.Text = rst("additionalcomunitytax")
            txtInputBusiness.Text = rst("inputbusiness")
            txtInputSalaries.Text = rst("inputsalary")
            txtInputRealProperty.Text = rst("inputrealproperty")
            txtInterestRate.Text = rst("intrate")
        End While
        rst.Close()
    End Sub

    Public Sub EnableControl(ByVal yes As Boolean)
        txtFullname.Enabled = yes
        txtTIN.Enabled = yes
        txtGender.Enabled = yes
        txtAddress.Enabled = yes
        txtCivilStatus.Enabled = yes
        txtCitizenship.Enabled = yes
        txtICRNo.Enabled = yes
        txtBirthdate.Enabled = yes
        txtPlaceOfBirth.Enabled = yes
        txtHeight.Enabled = yes
        txtWeight.Enabled = yes
        txtProfession.Enabled = yes
        txtBasic.Enabled = yes
        txtAdditional.Enabled = yes
        txtInputBusiness.Enabled = yes
        txtInputSalaries.Enabled = yes
        txtInputRealProperty.Enabled = yes
        txtInterestRate.Enabled = yes
        cmdEnterPayment.Enabled = yes
    End Sub

    Private Sub txtRealPropertyTotal_EditValueChanged(sender As Object, e As EventArgs) Handles txtInputRealProperty.EditValueChanged
        txtTotalRealProperty.Text = Val(CC(txtInputRealProperty.Text)) * 0.001
    End Sub
    Private Sub txtInputBusiness_EditValueChanged(sender As Object, e As EventArgs) Handles txtInputBusiness.EditValueChanged
        txtTotalBusiness.Text = Val(CC(txtInputBusiness.Text)) * 0.001
    End Sub
    Private Sub txtInputSalaries_EditValueChanged(sender As Object, e As EventArgs) Handles txtInputSalaries.EditValueChanged
        txtTotalSalaries.Text = Val(CC(txtInputSalaries.Text)) * 0.001
    End Sub

    Private Sub ComputationTax(sender As Object, e As EventArgs) Handles txtBasic.EditValueChanged, txtAdditional.EditValueChanged, txtTotalBusiness.EditValueChanged, txtTotalSalaries.EditValueChanged, txtTotalRealProperty.EditValueChanged
        Calculator()
    End Sub

    Private Sub txtInterestRate_EditValueChanged(sender As Object, e As EventArgs) Handles txtInterestRate.EditValueChanged
        Calculator()
    End Sub

    Public Sub Calculator()
        Dim totalPayable As Double = Val(CC(txtBasic.Text)) + Val(CC(txtAdditional.Text)) + Val(CC(txtTotalBusiness.Text)) + Val(CC(txtTotalSalaries.Text)) + Val(CC(txtTotalRealProperty.Text))
        txtSubtotal.Text = totalPayable
        txtTotalInterest.Text = Math.Round(totalPayable * (Val(CC(txtInterestRate.Text)) / 100))
        txtAmountPaid.Text = Val(CC(totalPayable)) + Val(CC(txtTotalInterest.Text))
    End Sub

    Private Sub txtAmountPaid_EditValueChanged(sender As Object, e As EventArgs) Handles txtAmountPaid.EditValueChanged
        If Val(txtAmountPaid.EditValue) > 0 Then
            txtAmountInWords.Text = ConvertCurrencyToEnglish(Val(txtAmountPaid.EditValue))
        Else
            txtAmountInWords.Text = ""
        End If
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

    Private Sub cmdEnterPayment_Click(sender As Object, e As EventArgs) Handles cmdEnterPayment.Click
        If cifid.Text = "" Then
            XtraMessageBox.Show("Please select payor! search then hit enter!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtFullname.Focus()
            Exit Sub
        ElseIf Val(CC(txtAmountPaid.Text)) = 0 Then
            XtraMessageBox.Show("Please add collection charges!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtAmountPaid.Focus()
            Exit Sub
        End If

        If mode.Text = "edit" Then
            If XtraMessageBox.Show("Are you sure you want to continue update this transaction? ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                com.CommandText = "UPDATE tblcommunitytax set fundcode='" & fundcode.Text & "',yeartrn='" & yeartrn.Text & "',postingdate='" & ConvertDate(txtCollectionDate.EditValue) & "',cifid='" & cifid.Text & "',basiccomunitytax='" & txtBasic.EditValue & "',additionalcomunitytax='" & txtAdditional.EditValue & "',inputbusiness='" & txtInputBusiness.EditValue & "',totalbusiness='" & txtTotalBusiness.EditValue & "',inputsalary='" & txtInputSalaries.EditValue & "',totalsalary='" & txtTotalSalaries.EditValue & "',inputrealproperty='" & txtInputRealProperty.EditValue & "',totalrealproperty='" & txtTotalRealProperty.EditValue & "',subtotal='" & txtSubtotal.EditValue & "',intrate='" & txtInterestRate.EditValue & "',interest='" & txtTotalInterest.EditValue & "',amountpaid='" & txtAmountPaid.EditValue & "',paymentamount='" & txtAmountPaid.EditValue & "',paymentchange='0', processedby='" & globaluserid & "' where jevno='" & jevid.Text & "' and communitytaxno='" & txtORNumber.Text & "'" : com.ExecuteNonQuery()

                com.CommandText = "DELETE from tbltransactionentries where jevno='" & jevid.Text & "' and ornumber='" & txtORNumber.Text & "'" : com.ExecuteNonQuery()
                com.CommandText = "insert into tbltransactionentries (fundcode,yeartrn,postingdate,officeid,jevno,cifid,ornumber,itemcode,itemname,explaination,debit,credit,cashflowcode,collection,formcode,invrefcode,datetrn,trnby) " _
                     + "select '" & fundcode.Text & "','" & yeartrn.Text & "','" & ConvertDate(txtCollectionDate.EditValue) & "','" & compOfficeid & "','" & jevid.Text & "','" & cifid.Text & "','" & txtORNumber.Text & "',itemcode,itemname,'" & txtFullname.Text & "',if(debitentry=1," & Val(CC(txtAmountPaid.Text)) & ",0),if(debitentry=0," & Val(CC(txtAmountPaid.Text)) & ",0),'',1,'" & formcode.Text & "','" & invrefcode.Text & "',current_timestamp,'" & globaluserid & "' from tblglitem where treasury=1" : com.ExecuteNonQuery()

                com.CommandText = "insert into tbltransactionentries (fundcode,yeartrn,postingdate,officeid,jevno,cifid,ornumber,itemcode,itemname,explaination,debit,credit,cashflowcode,collection,formcode,invrefcode,datetrn,trnby) " _
                        + "select '" & fundcode.Text & "','" & yeartrn.Text & "','" & ConvertDate(txtCollectionDate.EditValue) & "','" & compOfficeid & "','" & jevid.Text & "','" & cifid.Text & "','" & txtORNumber.Text & "',itemcode,itemname,'" & txtFullname.Text & "',if(debitentry=1," & Val(CC(txtAmountPaid.Text)) & ",0),if(debitentry=0," & Val(CC(txtAmountPaid.Text)) & ",0),ifnull((select cashflowcode from tblcashflowtagging where glitemcode=tblglitem.itemcode),''),1,'" & formcode.Text & "','" & invrefcode.Text & "',current_timestamp,'" & globaluserid & "' from tblglitem where cedula=1" : com.ExecuteNonQuery()
                com.CommandText = "delete from tmpcommunitytax" : com.ExecuteNonQuery()
                frmCollectionDetails.ViewList()
                XtraMessageBox.Show("Record successfully updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            End If
        Else
            com.CommandText = "delete from tmpcommunitytax" : com.ExecuteNonQuery()
            com.CommandText = "insert into tmpcommunitytax set fundcode='" & fundcode.Text & "',yeartrn='" & yeartrn.Text & "',postingdate='" & ConvertDate(txtCollectionDate.EditValue) & "',cifid='" & cifid.Text & "',communitytaxno='" & txtORNumber.Text & "',basiccomunitytax='" & txtBasic.EditValue & "',additionalcomunitytax='" & txtAdditional.EditValue & "',inputbusiness='" & txtInputBusiness.EditValue & "',totalbusiness='" & txtTotalBusiness.EditValue & "',inputsalary='" & txtInputSalaries.EditValue & "',totalsalary='" & txtTotalSalaries.EditValue & "',inputrealproperty='" & txtInputRealProperty.EditValue & "',totalrealproperty='" & txtTotalRealProperty.EditValue & "',subtotal='" & txtSubtotal.EditValue & "',intrate='" & txtInterestRate.EditValue & "',interest='" & txtTotalInterest.EditValue & "',amountpaid='" & txtAmountPaid.EditValue & "',processedby='" & globaluserid & "',dateprocessed=current_timestamp" : com.ExecuteNonQuery()
            com.CommandText = "update tbltaxpayerprofile set address='" & rchar(txtAddress.Text) & "', gender='" & txtGender.EditValue & "',civilstatus='" & txtCivilStatus.EditValue & "', citizenship='" & txtCitizenship.EditValue & "', icrno='" & txtICRNo.Text & "', " & If(txtBirthdate.Text <> "", "birthdate='" & ConvertDate(txtBirthdate.EditValue) & "', ", "") & " birthplace='" & txtPlaceOfBirth.EditValue & "', height='" & rchar(txtHeight.Text) & "', weight='" & rchar(txtWeight.Text) & "', profession='" & txtProfession.EditValue & "', tin='" & txtTIN.Text & "' where cifid='" & cifid.Text & "' " : com.ExecuteNonQuery()
            frmCashPaymentConfirmation.txtORnumber.Text = txtORNumber.Text
            frmCashPaymentConfirmation.txTotalOnScreen.Text = txtAmountPaid.Text
            frmCashPaymentConfirmation.txtEnterPayment.Text = txtAmountPaid.Text
            frmCashPaymentConfirmation.cidid.Text = cifid.Text
            frmCashPaymentConfirmation.fundcode.Text = fundcode.Text
            frmCashPaymentConfirmation.trnmode.Text = "cedulaindividual"
            frmCashPaymentConfirmation.ShowDialog(Me)
            txtFullname.Focus()
        End If
    End Sub

    Public Sub ConfirmedTransaction(ByVal paymentamount As Double, ByVal paymentchange As Double)
        Dim jevno As String = fundcode.Text & "-" & yeartrn.Text & "-" & CDate(txtCollectionDate.EditValue).ToString("MM") & "-" & GetSequenceNo(periodcode.Text, "jevseries")
        com.CommandText = "insert into tblcommunitytax set fundcode='" & fundcode.Text & "',yeartrn='" & yeartrn.Text & "',postingdate='" & ConvertDate(txtCollectionDate.EditValue) & "',jevno='" & jevno & "',cifid='" & cifid.Text & "',communitytaxno='" & txtORNumber.Text & "',basiccomunitytax='" & txtBasic.EditValue & "',additionalcomunitytax='" & txtAdditional.EditValue & "',inputbusiness='" & txtInputBusiness.EditValue & "',totalbusiness='" & txtTotalBusiness.EditValue & "',inputsalary='" & txtInputSalaries.EditValue & "',totalsalary='" & txtTotalSalaries.EditValue & "',inputrealproperty='" & txtInputRealProperty.EditValue & "',totalrealproperty='" & txtTotalRealProperty.EditValue & "',subtotal='" & txtSubtotal.EditValue & "',intrate='" & txtInterestRate.EditValue & "',interest='" & txtTotalInterest.EditValue & "',amountpaid='" & txtAmountPaid.EditValue & "',paymentamount='" & paymentamount & "',paymentchange='" & paymentchange & "', processedby='" & globaluserid & "',dateprocessed=current_timestamp" : com.ExecuteNonQuery()
        com.CommandText = "insert into tbltransactionentries (fundcode,yeartrn,postingdate,officeid,jevno,cifid,ornumber,itemcode,itemname,explaination,debit,credit,cashflowcode,collection,formcode,invrefcode,datetrn,trnby) " _
             + "select '" & fundcode.Text & "','" & yeartrn.Text & "','" & ConvertDate(txtCollectionDate.EditValue) & "','" & compOfficeid & "','" & jevno & "','" & cifid.Text & "','" & txtORNumber.Text & "',itemcode,itemname,'" & txtFullname.Text & "',if(debitentry=1," & Val(CC(txtAmountPaid.Text)) & ",0),if(debitentry=0," & Val(CC(txtAmountPaid.Text)) & ",0),'',1,'" & formcode.Text & "','" & invrefcode.Text & "',current_timestamp,'" & globaluserid & "' from tblglitem where treasury=1" : com.ExecuteNonQuery()

        com.CommandText = "insert into tbltransactionentries (fundcode,yeartrn,postingdate,officeid,jevno,cifid,ornumber,itemcode,itemname,explaination,debit,credit,cashflowcode,collection,formcode,invrefcode,datetrn,trnby) " _
                + "select '" & fundcode.Text & "','" & yeartrn.Text & "','" & ConvertDate(txtCollectionDate.EditValue) & "','" & compOfficeid & "','" & jevno & "','" & cifid.Text & "','" & txtORNumber.Text & "',itemcode,itemname,'" & txtFullname.Text & "',if(debitentry=1," & Val(CC(txtAmountPaid.Text)) & ",0),if(debitentry=0," & Val(CC(txtAmountPaid.Text)) & ",0),ifnull((select cashflowcode from tblcashflowtagging where glitemcode=tblglitem.itemcode),''),1,'" & formcode.Text & "','" & invrefcode.Text & "',current_timestamp,'" & globaluserid & "' from tblglitem where cedula=1" : com.ExecuteNonQuery()
        com.CommandText = "delete from tmpcommunitytax" : com.ExecuteNonQuery()
        UpdateAccountableForm(invrefcode.Text)
        BeginNewTransaction()
        frmPaymentChangeCaption.txtChange.Text = FormatNumber(paymentchange, 2)
        frmPaymentChangeCaption.ShowDialog(Me)
        txtFullname.Focus()
    End Sub

    Private Sub txtInterestRate_GotFocus(sender As Object, e As EventArgs) Handles txtInterestRate.GotFocus
        Me.AcceptButton = cmdEnterPayment
    End Sub

    Private Sub txtInterestRate_LostFocus(sender As Object, e As EventArgs) Handles txtInterestRate.LostFocus
        Me.AcceptButton = Nothing
    End Sub
End Class