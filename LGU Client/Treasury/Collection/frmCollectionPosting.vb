Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO
Imports DevExpress.XtraEditors

Public Class frmCollectionPosting

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        ElseIf keyData = Keys.Space Then
            If Me.txtSearchBar.Focus = True Then
                txtSearchBar.SelectAll()
                txtSearchBar.Focus()
            End If
        ElseIf keyData = (Keys.F1) Then
            cmdPayorRegistration.PerformClick()

        ElseIf keyData = (Keys.F2) Then
            txtPayorName.Focus()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmCollectionPosting_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        If txtPayorName.Text = "" Then
            groupCustomer.Focus()
            txtPayorName.Focus()
        End If
    End Sub

    Private Sub frmCollectionPosting_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub frmCollectionPosting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico
        ApplySystemTheme(ToolStrip3)
        lblTransactionDate.Text = CDate(txtCollectionDate.EditValue).ToString("MMMM dd, yyyy") & " " & CDate(Now.ToString("hh:mm:ss tt"))
        lblFullname.Text = UCase(globalfullname)
        lblPosition.Text = globalposition

        com.CommandText = "DROP TEMPORARY TABLE if EXISTS tmpcollectionlist;" : com.ExecuteNonQuery()
        com.CommandText = "CREATE TEMPORARY TABLE  tmpcollectionlist (  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,  `fundcode` varchar(45) NOT NULL,  `yeartrn` varchar(4) NOT NULL,  `postingdate` date NOT NULL,  `jevno` varchar(45) NOT NULL,  `cifid` varchar(45) NOT NULL,  `ornumber` varchar(45) NOT NULL,  `total` double NOT NULL,  `check` tinyint(1) NOT NULL DEFAULT '0',  `cash` tinyint(1) NOT NULL DEFAULT '0',  `moneyorder` tinyint(1) NOT NULL DEFAULT '0',  `checkbank` varchar(45) NOT NULL,  `checknumber` varchar(45) NOT NULL,  `checkdate` varchar(45) NOT NULL,  PRIMARY KEY (`id`)) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=latin1;" : com.ExecuteNonQuery()
        com.CommandText = "DROP TEMPORARY TABLE if EXISTS tmpcollection;" : com.ExecuteNonQuery()
        com.CommandText = "CREATE TEMPORARY TABLE tmpcollection (  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,  `glitemcode` text, `glitemname` text, `trncode` text,  `trnname` text,`explaination` text,`debit` tinyint not null default 0,amount double default 0,`cashflowcode` text,  PRIMARY KEY (`id`)) ENGINE=InnoDB DEFAULT CHARSET=latin1;" : com.ExecuteNonQuery()

        If mode.Text = "edit" Then
            txtFormTitle.Text = "EDITING MODE TRANSACTION"
            txtFormTitle.BackColor = Color.Red
            txtFormTitle.ForeColor = Color.White
            cmdEnterPayment.Text = "Confirm Update"
            ShowCollectionInfo()
        Else
            BeginNewTransaction()
        End If
    End Sub

    Public Sub LoadCustomerInfo(ByVal fullname As String, ByVal newinfo As Boolean)
        If newinfo = True Then
            txtPayorName.Text = fullname
        End If
        com.CommandText = "select *,(select description from tbldatapicked where id=a.agencycode) as agency from tbltaxpayerprofile as a where fullname='" & fullname & "' and deleted=0 " : rst = com.ExecuteReader
        While rst.Read
            cifid.Text = rst("cifid").ToString
            txtAgency.Text = rst("agency")
        End While
        rst.Close()
        txtSearchBar.Focus()
    End Sub

    Public Sub ShowCollectionInfo()
        com.CommandText = "select * from tblcollectionlist where jevno='" & jevid.Text & "'" : rst = com.ExecuteReader
        While rst.Read
            fundcode.Text = rst("fundcode").ToString
            yeartrn.Text = rst("yeartrn").ToString
            txtCollectionDate.EditValue = rst("postingdate").ToString
            cifid.Text = rst("cifid").ToString
            txtORNumber.Text = rst("ornumber").ToString
            If CBool(rst("check")) = True Then
                radPaymentOption.EditValue = "check"
            ElseIf CBool(rst("cash")) = True Then
                radPaymentOption.EditValue = "cash"
            ElseIf CBool(rst("moneyorder")) = True Then
                radPaymentOption.EditValue = "moneyorder"
            End If
            txtDraweeBank.Text = rst("checkbank").ToString
            txtCheckNumber.Text = rst("checknumber").ToString
            txtCheckDate.Text = rst("checkdate").ToString
            trnby.Text = rst("trnby").ToString
        End While
        rst.Close()
        com.CommandText = "delete from tmpcollection" : com.ExecuteNonQuery()
        com.CommandText = "insert into tmpcollection (trncode,trnname,glitemcode,glitemname,explaination,debit,amount,cashflowcode) " _
                        + " select trncode,trnname,itemcode,itemname,explaination,if(debit>0,1,0),if(debit>0,debit,credit),cashflowcode from  tbltransactionentries where jevno='" & jevid.Text & "' and ornumber='" & txtORNumber.Text & "' and itemcode not in (select itemcode from tblglitem where treasury=1) " : com.ExecuteNonQuery()
        
        com.CommandText = "select *,(select description from tbldatapicked where id=a.agencycode) as agency from tbltaxpayerprofile as a where cifid='" & cifid.Text & "'" : rst = com.ExecuteReader
        While rst.Read
            cifid.Text = rst("cifid").ToString
            txtPayorName.Text = rst("fullname").ToString
            txtAgency.Text = rst("agency")
        End While
        rst.Close()

        LoadTransactionInfo()
    End Sub


    Public Sub BeginNewTransaction()
        txtPayorName.SelectedIndex = -1 : cifid.Text = "" : txtAgency.Text = ""
        groupCustomer.TabIndex = 0
        Dim ProceedOR As Boolean = False
        com.CommandText = "select * from tblforminventory where officeid='" & compOfficeid & "' and accountable='" & globaluserid & "' and inused=1 and formcode in (select defaultcollection from tbldefaultsettings) " : rst = com.ExecuteReader
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
            txtFormTitle.Text = "OR FORM REACHED SERIES NUMBER LIMIT"
            txtFormTitle.BackColor = Color.Red
            txtFormTitle.ForeColor = Color.White
            ClearControl(False)
        Else
            txtFormTitle.Text = txtFundTitle.Text
            txtFormTitle.BackColor = DefaultBackColor
            txtFormTitle.ForeColor = Color.Blue
            ClearControl(True)
        End If
        LoadTransactionInfo()
        txtPayorName.Focus()
    End Sub

    Public Sub ClearControl(ByVal proceed As Boolean)
        If proceed = True Then
            txtPayorName.Enabled = True
            txtAgency.Enabled = True
            txtSearchBar.Enabled = True
            cmdEnterPayment.Enabled = True
            cmdCancelTransaction.Enabled = True
            radPaymentOption.Enabled = True
        Else
            txtPayorName.Enabled = False
            txtAgency.Enabled = False
            txtSearchBar.Enabled = False
            cmdEnterPayment.Enabled = False
            cmdCancelTransaction.Enabled = False
            radPaymentOption.Enabled = False
        End If
    End Sub

    Public Sub LoadTransactionInfo()
        dst = Nothing : dst = New DataSet
        msda = New MySqlDataAdapter("select sum(amount) as total from tmpcollection", conn)
        msda.Fill(dst, 0)
        For cnt = 0 To dst.Tables(0).Rows.Count - 1
            With (dst.Tables(0))
                txtTotalOnScreen.Text = FormatNumber(Val(.Rows(cnt)("total").ToString()), 2)
            End With
        Next
        ShowCollectionEntries()
    End Sub

    Public Sub ConfirmedTransaction(ByVal paymentamount As Double, ByVal paymentchange As Double)
        Dim jevno As String = fundcode.Text & "-" & yeartrn.Text & "-" & CDate(txtCollectionDate.EditValue).ToString("MM") & "-" & GetSequenceNo(periodcode.Text, "jevseries")
        com.CommandText = "insert into tblcollectionlist set fundcode='" & fundcode.Text & "',yeartrn='" & yeartrn.Text & "',postingdate='" & ConvertDate(txtCollectionDate.EditValue) & "',jevno='" & jevno & "',cifid='" & cifid.Text & "',ornumber='" & txtORNumber.Text & "',total='" & Val(CC(txtTotalOnScreen.Text)) & "',`check`=" & If(radPaymentOption.EditValue = "check", "1", "0") & ",cash=" & If(radPaymentOption.EditValue = "cash", "1", "0") & ",moneyorder=" & If(radPaymentOption.EditValue = "moneyorder", "1", "0") & ",checkbank='" & txtDraweeBank.Text & "',checknumber='" & txtCheckNumber.Text & "',checkdate='" & txtCheckDate.Text & "',trnby='" & globaluserid & "',datetrn=current_timestamp" : com.ExecuteNonQuery()

        com.CommandText = "insert into tbltransactionentries (fundcode,yeartrn,postingdate,officeid,jevno,cifid,ornumber,itemcode,itemname,trncode,trnname,explaination,debit,credit,cashflowcode,collection,formcode,invrefcode,datetrn,trnby) " _
             + "select '" & fundcode.Text & "','" & yeartrn.Text & "','" & ConvertDate(txtCollectionDate.EditValue) & "','" & compOfficeid & "','" & jevno & "','" & cifid.Text & "','" & txtORNumber.Text & "',itemcode,itemname,'','','" & txtPayorName.Text & "',if(debitentry=1," & Val(CC(txtTotalOnScreen.Text)) & ",0),if(debitentry=0," & Val(CC(txtTotalOnScreen.Text)) & ",0),'',1,'" & formcode.Text & "','" & invrefcode.Text & "',current_timestamp,'" & globaluserid & "' from tblglitem where treasury=1" : com.ExecuteNonQuery()

        com.CommandText = "insert into tbltransactionentries (fundcode,yeartrn,postingdate,officeid,jevno,cifid,ornumber,itemcode,itemname,trncode,trnname,explaination,debit,credit,cashflowcode,collection,formcode,invrefcode,datetrn,trnby) " _
                + "select '" & fundcode.Text & "','" & yeartrn.Text & "','" & ConvertDate(txtCollectionDate.EditValue) & "','" & compOfficeid & "','" & jevno & "','" & cifid.Text & "','" & txtORNumber.Text & "',glitemcode,glitemname,trncode,trnname,explaination,if(debit=1,if(amount<0,-amount,amount),0),if(debit=0,if(amount<0,-amount,amount),0),cashflowcode,1,'" & formcode.Text & "','" & invrefcode.Text & "',current_timestamp,'" & globaluserid & "' from tmpcollection" : com.ExecuteNonQuery()
        com.CommandText = "delete from tmpcollection" : com.ExecuteNonQuery()

        UpdateAccountableForm(invrefcode.Text)
        BeginNewTransaction()
        frmPaymentChangeCaption.txtChange.Text = FormatNumber(paymentchange, 2)
        frmPaymentChangeCaption.ShowDialog(Me)
        BeginNewTransaction()
    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblTransactionDate.Text = CDate(txtCollectionDate.EditValue).ToString("MMMM dd, yyyy") & " " & CDate(Now.ToString("hh:mm:ss tt"))
    End Sub

    Private Sub cmdPrint_Click(sender As Object, e As EventArgs) Handles cmdPayorRegistration.Click
        frmTaxPayerInfo.ShowDialog(Me)
    End Sub

    Private Sub txtPayorName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPayorName.KeyPress
        If e.KeyChar = Chr(13) Then
            If RemoveWhiteSpaces(txtPayorName.Text, False) = "" Or RemoveWhiteSpaces(txtPayorName.Text, False) = "%" Then Exit Sub
            If countqry("tbltaxpayerprofile", "fullname = '" & RemoveWhiteSpaces(txtPayorName.Text, False) & "' and deleted=0") = 0 Then

                If countqry("tbltaxpayerprofile", "fullname like '%" & RemoveWhiteSpaces(txtPayorName.Text, False) & "%'  and deleted=0 ") = 0 Then
                    If XtraMessageBox.Show("No match found on your search query! Do you want to add new payors information?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
                        frmTaxPayerInfo.trnmode.Text = "collection"
                        frmTaxPayerInfo.ShowDialog(Me)
                        txtSearchBar.Focus()
                    End If
                Else
                    DXLoadToComboBoxQuery("fullname", "SELECT fullname FROM tbltaxpayerprofile  where fullname like '%" & RemoveWhiteSpaces(txtPayorName.Text, False) & "%' and deleted=0 order by fullname asc;", txtPayorName)
                    txtPayorName.ShowPopup()
                End If
            Else
                LoadCustomerInfo(RemoveWhiteSpaces(txtPayorName.Text, False), False)
            End If
        End If
    End Sub

    Private Sub txtSearchBar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSearchBar.KeyPress
        If e.KeyChar = Chr(13) Then
            If txtSearchBar.Text = "" And Val(CC(txtTotalOnScreen.Text)) > 0 Then
                cmdEnterPayment.PerformClick()
            Else
                If countqry("tblcollectionitem", "trnname='" & rchar(txtSearchBar.Text) & "'") > 0 Then

                Else
                    frmCollectionSearch.txtSearchKeyword.Text = txtSearchBar.Text
                    frmCollectionSearch.ShowDialog(Me)
                    frmCollectionSearch.Em.Focus()
                End If
            End If
        End If
    End Sub
    Public Sub ProcessCollection(ByVal trncode As String, ByVal trnname As String, ByVal glitemcode As String, ByVal glitemname As String, ByVal explaination As String, ByVal isdebit As Boolean, ByVal amount As Double, ByVal cashflowcode As String)
        com.CommandText = "insert into tmpcollection set trncode='" & trncode & "', trnname='" & rchar(trnname) & "',glitemcode='" & glitemcode & "', glitemname='" & rchar(glitemname) & "', explaination='" & rchar(explaination) & "', debit=" & isdebit & ", amount='" & Val(amount) & "', cashflowcode='" & cashflowcode & "'" : com.ExecuteNonQuery()
        LoadTransactionInfo()
        txtSearchBar.Text = "" : txtSearchBar.Focus()
    End Sub
    Public Sub ShowCollectionEntries()
        LoadXgrid("SELECT id, if(explaination='',trnname,concat(trnname,'\n-', explaination)) as 'Nature of Collection', glitemcode as 'Item Code', Amount  FROM tmpcollection;", "tmpcollection", Em, GridView1, Me)
        XgridColMemo({"Nature of Collection"}, GridView1)
        GridView1.Columns("Nature of Collection").Width = 300
        GridView1.Columns("Item Code").Width = 100
        GridView1.Columns("Amount").Width = 100
        XgridColCurrency({"Amount"}, GridView1)
        XgridColAlign({"Item Code"}, GridView1, DevExpress.Utils.HorzAlignment.Center)
        XgridGeneralSummaryCurrency({"Amount"}, GridView1)
        XgridHideColumn({"id"}, GridView1)
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        LoadTransactionInfo()
    End Sub

    Private Sub PickSelectedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PickSelectedToolStripMenuItem.Click
        If XtraMessageBox.Show("Are you sure you want to permanently remove selected item? ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            Dim I As Integer = 0
            For I = 0 To GridView1.SelectedRowsCount - 1
                com.CommandText = "delete from tmpcollection where id='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "id") & "' " : com.ExecuteNonQuery()
            Next
            LoadTransactionInfo()
        End If
    End Sub

    Private Sub cmdEnterPayment_Click(sender As Object, e As EventArgs) Handles cmdEnterPayment.Click
        If cifid.Text = "" Then
            XtraMessageBox.Show("Please select payor! search then hit enter!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtPayorName.Focus()
            Exit Sub
        ElseIf Val(CC(txtTotalOnScreen.Text)) = 0 Then
            XtraMessageBox.Show("Please add collection charges!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtSearchBar.Focus()
            Exit Sub
        End If
        If mode.Text = "edit" Then
            If XtraMessageBox.Show("Are you sure you want to continue update this transaction? ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                com.CommandText = "UPDATE tblcollectionlist set fundcode='" & fundcode.Text & "',yeartrn='" & yeartrn.Text & "',postingdate='" & ConvertDate(txtCollectionDate.EditValue) & "',cifid='" & cifid.Text & "',ornumber='" & txtORNumber.Text & "',total='" & Val(CC(txtTotalOnScreen.Text)) & "',`check`=" & If(radPaymentOption.EditValue = "check", "1", "0") & ",cash=" & If(radPaymentOption.EditValue = "cash", "1", "0") & ",moneyorder=" & If(radPaymentOption.EditValue = "moneyorder", "1", "0") & ",checkbank='" & txtDraweeBank.Text & "',checknumber='" & txtCheckNumber.Text & "',checkdate='" & txtCheckDate.Text & "' where jevno='" & jevid.Text & "' and ornumber='" & txtORNumber.Text & "'" : com.ExecuteNonQuery()

                com.CommandText = "DELETE from tbltransactionentries where jevno='" & jevid.Text & "' and ornumber='" & txtORNumber.Text & "'" : com.ExecuteNonQuery()
                com.CommandText = "insert into tbltransactionentries (fundcode,yeartrn,postingdate,officeid,jevno,cifid,ornumber,itemcode,itemname,trncode,trnname,explaination,debit,credit,cashflowcode,collection,formcode,invrefcode,datetrn,trnby) " _
                     + "select '" & fundcode.Text & "','" & yeartrn.Text & "','" & ConvertDate(txtCollectionDate.EditValue) & "','" & officeid.Text & "','" & jevid.Text & "','" & cifid.Text & "','" & txtORNumber.Text & "',itemcode,itemname,'','','" & txtPayorName.Text & "',if(debitentry=1," & Val(CC(txtTotalOnScreen.Text)) & ",0),if(debitentry=0," & Val(CC(txtTotalOnScreen.Text)) & ",0),'',1,'" & formcode.Text & "','" & invrefcode.Text & "',current_timestamp,'" & trnby.Text & "' from tblglitem where treasury=1" : com.ExecuteNonQuery()

                com.CommandText = "insert into tbltransactionentries (fundcode,yeartrn,postingdate,officeid,jevno,cifid,ornumber,itemcode,itemname,trncode,trnname,explaination,debit,credit,cashflowcode,collection,formcode,invrefcode,datetrn,trnby) " _
                        + "select '" & fundcode.Text & "','" & yeartrn.Text & "','" & ConvertDate(txtCollectionDate.EditValue) & "','" & officeid.Text & "','" & jevid.Text & "','" & cifid.Text & "','" & txtORNumber.Text & "',glitemcode,glitemname,trncode,trnname,explaination,if(debit=1,if(amount<0,-amount,amount),0),if(debit=0,if(amount<0,-amount,amount),0),cashflowcode,1,'" & formcode.Text & "','" & invrefcode.Text & "',current_timestamp,'" & trnby.Text & "' from tmpcollection" : com.ExecuteNonQuery()
                com.CommandText = "delete from tmpcollection" : com.ExecuteNonQuery()

                frmCollectionDetails.ViewList()
                XtraMessageBox.Show("Record successfully updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            End If
        Else
            com.CommandText = "delete from tmpcollectionlist" : com.ExecuteNonQuery()
            com.CommandText = "insert into tmpcollectionlist set fundcode='" & fundcode.Text & "',yeartrn='" & yeartrn.Text & "',postingdate='" & ConvertDate(txtCollectionDate.EditValue) & "',jevno='',cifid='" & cifid.Text & "',ornumber='" & txtORNumber.Text & "',total='" & Val(CC(txtTotalOnScreen.Text)) & "',`check`=" & If(radPaymentOption.EditValue = "check", "1", "0") & ",cash=" & If(radPaymentOption.EditValue = "cash", "1", "0") & ",moneyorder=" & If(radPaymentOption.EditValue = "moneyorder", "1", "0") & ",checkbank='" & txtDraweeBank.Text & "',checknumber='" & txtCheckNumber.Text & "',checkdate='" & txtCheckDate.Text & "'" : com.ExecuteNonQuery()
            frmCashPaymentConfirmation.txtORnumber.Text = txtORNumber.Text
            frmCashPaymentConfirmation.txTotalOnScreen.Text = txtTotalOnScreen.Text
            frmCashPaymentConfirmation.txtEnterPayment.Text = txtTotalOnScreen.Text
            frmCashPaymentConfirmation.cidid.Text = cifid.Text
            frmCashPaymentConfirmation.fundcode.Text = fundcode.Text
            frmCashPaymentConfirmation.trnmode.Text = "collection"
            frmCashPaymentConfirmation.ShowDialog(Me)
        End If
      
    End Sub

    Private Sub cmdCancelTransaction_Click(sender As Object, e As EventArgs) Handles cmdCancelTransaction.Click
        BeginNewTransaction()
    End Sub

 
    Private Sub radPaymentOption_SelectedIndexChanged(sender As Object, e As EventArgs) Handles radPaymentOption.SelectedIndexChanged
        If radPaymentOption.EditValue <> "cash" Then
            txtDraweeBank.Enabled = True
            txtCheckNumber.Enabled = True
            txtCheckDate.Enabled = True
        Else
            txtDraweeBank.Enabled = False
            txtCheckNumber.Enabled = False
            txtCheckDate.Enabled = False
        End If
    End Sub

    Private Sub cmdTransactionMenu_Click(sender As Object, e As EventArgs) Handles cmdTransactionMenu.Click
        Me.Close()
    End Sub
End Class