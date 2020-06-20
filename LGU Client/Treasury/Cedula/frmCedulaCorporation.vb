Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmCedulaCorporation
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Insert) Then
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

    Private Sub frmCommunityTaxCollection_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub frmCommunityTaxCollection_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico
        txtPlaceIssue.Text = GlobalOrganizationName
        LoadPlaceofIncorporation() : LoadNatureofBusiness()
        com.CommandText = "DROP table if exists tmpcommunitytaxcorp;" : com.ExecuteNonQuery()
        com.CommandText = "CREATE TEMPORARY TABLE `tmpcommunitytaxcorp` (`id` int(10) unsigned NOT NULL AUTO_INCREMENT,`fundcode` varchar(5) NOT NULL,`yeartrn` varchar(4) NOT NULL,`cifid` varchar(100) NOT NULL,`companyid` varchar(100) NOT NULL,`communitytaxno` varchar(45) NOT NULL,`basiccomunitytax` double NOT NULL DEFAULT '0',`additionalcomunitytax` double NOT NULL DEFAULT '0',`inputrealproperty` double NOT NULL DEFAULT '0',`totalrealproperty` double NOT NULL DEFAULT '0',`inputgrossreceipts` double NOT NULL DEFAULT '0',`totalgrossreceipts` double NOT NULL DEFAULT '0',`subtotal` double NOT NULL DEFAULT '0',`intrate` double NOT NULL DEFAULT '0',`interest` double NOT NULL DEFAULT '0',`amountpaid` double NOT NULL DEFAULT '0',`postingdate` date NOT NULL,`processedby` varchar(100) NOT NULL,`dateprocessed` datetime NOT NULL,PRIMARY KEY (`id`)) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=latin1;" : com.ExecuteNonQuery()
        If mode.Text = "edit" Then
            txtFormTitle.Text = "EDITING MODE TRANSACTION"
            txtFormTitle.BackColor = Color.Red
            txtFormTitle.ForeColor = Color.White
            cmdEnterPayment.Text = "Confirm Update"
            LoadCustomerInfo(companyid.Text, True)
        Else
            BeginNewTransaction()
        End If
    End Sub

    Public Sub BeginNewTransaction()
        Dim ProceedOR As Boolean = False
        com.CommandText = "select * from tblforminventory where officeid='" & compOfficeid & "' and accountable='" & globaluserid & "' and inused=1 and formcode in (select defaultcedulacorporate from tbldefaultsettings) " : rst = com.ExecuteReader
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
        txtTaxpayerName.Text = ""
        companyid.Text = ""
        txtCompanyName.Text = ""
        txtTIN.EditValue = Nothing
        txtAddress.EditValue = Nothing
        txtKindofOrganization.EditValue = Nothing
        txtPlaceofIncorporation.EditValue = Nothing
        txtNatureofBusiness.EditValue = Nothing
        txtBasic.Text = "0"
        txtAdditional.Text = "0"
        txtInputRealProperty.Text = "0"
        txtInputGrossReceipts.Text = "0"
        txtInputRealProperty.Text = "0"
        txtInterestRate.Text = "0"
        txtCompanyName.Focus()
    End Sub

    Public Sub LoadPlaceofIncorporation()
        LoadPickedDataTable("placeofincorporation", txtPlaceofIncorporation, gridPlaceofIncorporation)
        gridPlaceofIncorporation.Columns("id").Visible = False
    End Sub

    Public Sub LoadNatureofBusiness()
        LoadPickedDataTable("natureofbusiness", txtNatureofBusiness, gridNatureofBusiness)
        gridNatureofBusiness.Columns("id").Visible = False
    End Sub

    Private Sub txtFullname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCompanyName.KeyPress
        If e.KeyChar = Chr(13) Then
            If RemoveWhiteSpaces(txtCompanyName.Text, False) = "" Or RemoveWhiteSpaces(txtCompanyName.Text, False) = "%" Then Exit Sub
            If countqry("tblbusiness", "companyname = '" & RemoveWhiteSpaces(txtCompanyName.Text, False) & "' and deleted=0") = 0 Then

                If countqry("tblbusiness", "companyname like '%" & RemoveWhiteSpaces(txtCompanyName.Text, False) & "%' and deleted=0") = 0 Then
                    If XtraMessageBox.Show("No match found on your search query! Do you want to add new payors information?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
                        frmBusinessInfo.trnmode.Text = "cedulacorporate"
                        frmBusinessInfo.ShowDialog(Me)
                        txtBasic.Focus()
                    End If
                Else
                    DXLoadToComboBoxQuery("companyname", "SELECT companyname FROM tblbusiness  where companyname like '%" & RemoveWhiteSpaces(txtCompanyName.Text, False) & "%' and deleted=0 order by companyname asc;", txtCompanyName)
                End If
                txtCompanyName.ShowPopup()
                Exit Sub
            Else
                LoadCustomerInfo(RemoveWhiteSpaces(txtCompanyName.Text, False), False)
            End If
        End If
    End Sub

    Public Sub LoadCustomerInfo(ByVal parameter As String, ByVal querybyid As Boolean)
        dst = Nothing : dst = New DataSet
        If querybyid = True Then
            msda = New MySqlDataAdapter("select *,(select fullname from tbltaxpayerprofile where cifid=tblbusiness.cifid) as taxpayer from tblbusiness where id='" & parameter & "'  and deleted=0", conn)
        Else
            msda = New MySqlDataAdapter("select *,(select fullname from tbltaxpayerprofile where cifid=tblbusiness.cifid) as taxpayer from tblbusiness where companyname='" & parameter & "'  and deleted=0", conn)
        End If
        msda.Fill(dst, 0)
        For cnt = 0 To dst.Tables(0).Rows.Count - 1
            With (dst.Tables(0))
                cifid.Text = .Rows(cnt)("cifid").ToString()
                companyid.Text = .Rows(cnt)("id").ToString()
                txtCompanyName.Text = .Rows(cnt)("companyname").ToString()
                txtTaxpayerName.Text = .Rows(cnt)("taxpayer").ToString()
                txtTIN.Text = .Rows(cnt)("tin").ToString()
                txtAddress.Text = .Rows(cnt)("address").ToString()
                txtKindofOrganization.EditValue = .Rows(cnt)("kindoforganization").ToString()
                txtNatureofBusiness.EditValue = .Rows(cnt)("businessnature").ToString()
                txtDateIncorporation.EditValue = If(.Rows(cnt)("dateregincorporation").ToString = "", "", CDate(.Rows(cnt)("dateregincorporation").ToString))
                txtPlaceofIncorporation.EditValue = .Rows(cnt)("placeincorporation").ToString()
                txtBasic.Focus()
            End With
        Next
        If mode.Text = "edit" Then
            loadCedulaInfo()
        End If
    End Sub

    Public Sub loadCedulaInfo()
        com.CommandText = "select * from tblcommunitytaxcorp where jevno='" & jevid.Text & "'" : rst = com.ExecuteReader
        While rst.Read
            txtORNumber.Text = rst("communitytaxno").ToString
            txtCollectionDate.EditValue = rst("postingdate").ToString
            fundcode.Text = rst("fundcode").ToString
            txtBasic.Text = rst("basiccomunitytax")
            txtAdditional.Text = rst("additionalcomunitytax")
            txtInputRealProperty.Text = rst("inputrealproperty")
            txtInputGrossReceipts.Text = rst("inputgrossreceipts")
            txtInterestRate.Text = rst("intrate")
        End While
        rst.Close()
    End Sub

    Public Sub EnableControl(ByVal yes As Boolean)
        txtCompanyName.Enabled = yes
        txtTIN.Enabled = yes
        txtAddress.Enabled = yes
        txtKindofOrganization.Enabled = yes
        txtDateIncorporation.Enabled = yes
        txtPlaceofIncorporation.Enabled = yes
        txtNatureofBusiness.Enabled = yes
        txtBasic.Enabled = yes
        txtAdditional.Enabled = yes
        txtInputRealProperty.Enabled = yes
        txtInputGrossReceipts.Enabled = yes
        txtInterestRate.Enabled = yes
        cmdEnterPayment.Enabled = yes
    End Sub

    Private Sub txtInputRealProperty_EditValueChanged(sender As Object, e As EventArgs) Handles txtInputRealProperty.EditValueChanged
        txtTotalRealProperty.Text = Math.Round(Val(CC(txtInputRealProperty.Text)) * 0.0004)
    End Sub
    Private Sub txtInputGrossReceipts_EditValueChanged(sender As Object, e As EventArgs) Handles txtInputGrossReceipts.EditValueChanged
        txtTotalGrossReceipts.Text = Math.Round(Val(CC(txtInputGrossReceipts.Text)) * 0.0004)
    End Sub

    Private Sub ComputationTax(sender As Object, e As EventArgs) Handles txtBasic.EditValueChanged, txtAdditional.EditValueChanged, txtTotalRealProperty.EditValueChanged, txtTotalGrossReceipts.EditValueChanged
        Calculator()
    End Sub

    Private Sub txtInterestRate_EditValueChanged(sender As Object, e As EventArgs) Handles txtInterestRate.EditValueChanged
        Calculator()
    End Sub

    Public Sub Calculator()
        Dim totalPayable As Double = Val(CC(txtBasic.Text)) + Val(CC(txtAdditional.Text)) + Val(CC(txtTotalGrossReceipts.Text)) + Val(CC(txtTotalRealProperty.Text))
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

    Private Sub cmdEnterPayment_Click(sender As Object, e As EventArgs) Handles cmdEnterPayment.Click
        If companyid.Text = "" Then
            XtraMessageBox.Show("Please select payor! search then hit enter!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtCompanyName.Focus()
            Exit Sub
        ElseIf Val(CC(txtAmountPaid.Text)) = 0 Then
            XtraMessageBox.Show("Please add collection charges!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtAmountPaid.Focus()
            Exit Sub
        End If

        If mode.Text = "edit" Then
            If XtraMessageBox.Show("Are you sure you want to continue update this transaction? ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                com.CommandText = "UPDATE tblcommunitytaxcorp set fundcode='" & fundcode.Text & "',yeartrn='" & yeartrn.Text & "',postingdate='" & ConvertDate(txtCollectionDate.EditValue) & "',cifid='" & cifid.Text & "',companyid='" & companyid.Text & "',basiccomunitytax='" & txtBasic.EditValue & "',additionalcomunitytax='" & txtAdditional.EditValue & "',inputrealproperty='" & txtInputRealProperty.EditValue & "',totalrealproperty='" & txtTotalRealProperty.EditValue & "',inputgrossreceipts='" & txtInputGrossReceipts.EditValue & "',totalgrossreceipts='" & txtTotalGrossReceipts.EditValue & "', subtotal='" & txtSubtotal.EditValue & "',intrate='" & txtInterestRate.EditValue & "',interest='" & txtTotalInterest.EditValue & "',amountpaid='" & txtAmountPaid.EditValue & "',paymentamount='" & txtAmountPaid.EditValue & "',paymentchange='0', processedby='" & globaluserid & "' where jevno='" & jevid.Text & "' and communitytaxno='" & txtORNumber.Text & "'" : com.ExecuteNonQuery()

                com.CommandText = "DELETE from tbltransactionentries where jevno='" & jevid.Text & "' and ornumber='" & txtORNumber.Text & "'" : com.ExecuteNonQuery()
                com.CommandText = "insert into tbltransactionentries (fundcode,yeartrn,postingdate,officeid,jevno,cifid,companyid,ornumber,itemcode,itemname,explaination,debit,credit,cashflowcode,collection,formcode,invrefcode,datetrn,trnby) " _
                     + "select '" & fundcode.Text & "','" & yeartrn.Text & "','" & ConvertDate(txtCollectionDate.EditValue) & "','" & compOfficeid & "','" & jevid.Text & "','" & cifid.Text & "','" & companyid.Text & "','" & txtORNumber.Text & "',itemcode,itemname,'" & txtCompanyName.Text & "',if(debitentry=1," & Val(CC(txtAmountPaid.Text)) & ",0),if(debitentry=0," & Val(CC(txtAmountPaid.Text)) & ",0),'',1,'" & formcode.Text & "','" & invrefcode.Text & "',current_timestamp,'" & globaluserid & "' from tblglitem where treasury=1" : com.ExecuteNonQuery()

                com.CommandText = "insert into tbltransactionentries (fundcode,yeartrn,postingdate,officeid,jevno,cifid,companyid,ornumber,itemcode,itemname,explaination,debit,credit,cashflowcode,collection,formcode,invrefcode,datetrn,trnby) " _
                        + "select '" & fundcode.Text & "','" & yeartrn.Text & "','" & ConvertDate(txtCollectionDate.EditValue) & "','" & compOfficeid & "','" & jevid.Text & "','" & cifid.Text & "','" & companyid.Text & "','" & txtORNumber.Text & "',itemcode,itemname,'" & txtCompanyName.Text & "',if(debitentry=1," & Val(CC(txtAmountPaid.Text)) & ",0),if(debitentry=0," & Val(CC(txtAmountPaid.Text)) & ",0),ifnull((select cashflowcode from tblcashflowtagging where glitemcode=tblglitem.itemcode),''),1,'" & formcode.Text & "','" & invrefcode.Text & "',current_timestamp,'" & globaluserid & "' from tblglitem where cedula=1" : com.ExecuteNonQuery()
                com.CommandText = "delete from tmpcommunitytaxcorp" : com.ExecuteNonQuery()
                frmCollectionDetails.ViewList()
                XtraMessageBox.Show("Record successfully updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            End If
        Else
            com.CommandText = "delete from tmpcommunitytaxcorp" : com.ExecuteNonQuery()
            com.CommandText = "insert into tmpcommunitytaxcorp set fundcode='" & fundcode.Text & "',yeartrn='" & yeartrn.Text & "',postingdate='" & ConvertDate(txtCollectionDate.EditValue) & "',cifid='" & cifid.Text & "',companyid='" & companyid.Text & "',communitytaxno='" & txtORNumber.Text & "',basiccomunitytax='" & txtBasic.EditValue & "',additionalcomunitytax='" & txtAdditional.EditValue & "',inputrealproperty='" & txtInputRealProperty.EditValue & "',totalrealproperty='" & txtTotalRealProperty.EditValue & "',inputgrossreceipts='" & txtInputGrossReceipts.EditValue & "',totalgrossreceipts='" & txtTotalGrossReceipts.EditValue & "',subtotal='" & txtSubtotal.EditValue & "',intrate='" & txtInterestRate.EditValue & "',interest='" & txtTotalInterest.EditValue & "',amountpaid='" & txtAmountPaid.EditValue & "',processedby='" & globaluserid & "',dateprocessed=current_timestamp" : com.ExecuteNonQuery()
            com.CommandText = "update tblbusiness set address='" & rchar(txtAddress.Text) & "', " & If(txtDateIncorporation.Text <> "", "dateregincorporation='" & ConvertDate(txtDateIncorporation.EditValue) & "', ", "") & " placeincorporation='" & txtPlaceofIncorporation.EditValue & "', kindoforganization='" & txtKindofOrganization.EditValue & "',businessnature='" & txtNatureofBusiness.EditValue & "', tin='" & txtTIN.Text & "' where id='" & companyid.Text & "' " : com.ExecuteNonQuery()
            frmCashPaymentConfirmation.txtORnumber.Text = txtORNumber.Text
            frmCashPaymentConfirmation.txTotalOnScreen.Text = txtAmountPaid.Text
            frmCashPaymentConfirmation.txtEnterPayment.Text = txtAmountPaid.Text
            frmCashPaymentConfirmation.cidid.Text = companyid.Text
            frmCashPaymentConfirmation.fundcode.Text = fundcode.Text
            frmCashPaymentConfirmation.trnmode.Text = "cedulacorporate"
            frmCashPaymentConfirmation.ShowDialog(Me)
            txtCompanyName.Focus()
        End If
    End Sub

    Public Sub ConfirmedTransaction(ByVal paymentamount As Double, ByVal paymentchange As Double)
        Dim jevno As String = fundcode.Text & "-" & yeartrn.Text & "-" & CDate(txtCollectionDate.EditValue).ToString("MM") & "-" & GetSequenceNo(periodcode.Text, "jevseries")
        com.CommandText = "insert into tblcommunitytaxcorp set fundcode='" & fundcode.Text & "',yeartrn='" & yeartrn.Text & "',postingdate='" & ConvertDate(txtCollectionDate.EditValue) & "',jevno='" & jevno & "',cifid='" & cifid.Text & "',companyid='" & companyid.Text & "',communitytaxno='" & txtORNumber.Text & "',basiccomunitytax='" & txtBasic.EditValue & "',additionalcomunitytax='" & txtAdditional.EditValue & "',inputrealproperty='" & txtInputRealProperty.EditValue & "',totalrealproperty='" & txtTotalRealProperty.EditValue & "',inputgrossreceipts='" & txtInputGrossReceipts.EditValue & "',totalgrossreceipts='" & txtTotalGrossReceipts.EditValue & "',subtotal='" & txtSubtotal.EditValue & "',intrate='" & txtInterestRate.EditValue & "',interest='" & txtTotalInterest.EditValue & "',amountpaid='" & txtAmountPaid.EditValue & "',paymentamount='" & paymentamount & "',paymentchange='" & paymentchange & "', processedby='" & globaluserid & "',dateprocessed=current_timestamp" : com.ExecuteNonQuery()
        com.CommandText = "insert into tbltransactionentries (fundcode,yeartrn,postingdate,officeid,jevno,cifid,companyid,ornumber,itemcode,itemname,explaination,debit,credit,cashflowcode,collection,formcode,invrefcode,datetrn,trnby) " _
             + "select '" & fundcode.Text & "','" & yeartrn.Text & "','" & ConvertDate(txtCollectionDate.EditValue) & "','" & compOfficeid & "','" & jevno & "','" & cifid.Text & "','" & companyid.Text & "','" & txtORNumber.Text & "',itemcode,itemname,'" & txtCompanyName.Text & "',if(debitentry=1," & Val(CC(txtAmountPaid.Text)) & ",0),if(debitentry=0," & Val(CC(txtAmountPaid.Text)) & ",0),'',1,'" & formcode.Text & "','" & invrefcode.Text & "',current_timestamp,'" & globaluserid & "' from tblglitem where treasury=1" : com.ExecuteNonQuery()

        com.CommandText = "insert into tbltransactionentries (fundcode,yeartrn,postingdate,officeid,jevno,cifid,companyid,ornumber,itemcode,itemname,explaination,debit,credit,cashflowcode,collection,formcode,invrefcode,datetrn,trnby) " _
                + "select '" & fundcode.Text & "','" & yeartrn.Text & "','" & ConvertDate(txtCollectionDate.EditValue) & "','" & compOfficeid & "','" & jevno & "','" & cifid.Text & "','" & companyid.Text & "','" & txtORNumber.Text & "',itemcode,itemname,'" & txtCompanyName.Text & "',if(debitentry=1," & Val(CC(txtAmountPaid.Text)) & ",0),if(debitentry=0," & Val(CC(txtAmountPaid.Text)) & ",0),ifnull((select cashflowcode from tblcashflowtagging where glitemcode=tblglitem.itemcode),''),1,'" & formcode.Text & "','" & invrefcode.Text & "',current_timestamp,'" & globaluserid & "' from tblglitem where cedula=1" : com.ExecuteNonQuery()
        com.CommandText = "delete from tmpcommunitytaxcorp" : com.ExecuteNonQuery()
        UpdateAccountableForm(invrefcode.Text)
        BeginNewTransaction()
        frmPaymentChangeCaption.txtChange.Text = FormatNumber(paymentchange, 2)
        frmPaymentChangeCaption.ShowDialog(Me)
        txtCompanyName.Focus()
    End Sub

    Private Sub txtInterestRate_GotFocus(sender As Object, e As EventArgs) Handles txtInterestRate.GotFocus
        Me.AcceptButton = cmdEnterPayment
    End Sub

    Private Sub txtInterestRate_LostFocus(sender As Object, e As EventArgs) Handles txtInterestRate.LostFocus
        Me.AcceptButton = Nothing
    End Sub
End Class