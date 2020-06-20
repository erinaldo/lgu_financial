Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO
Imports DevExpress.XtraEditors

Public Class frmTaxDeclarationInfo
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
      

        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmTaxDeclarationInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico
    End Sub

    Public Sub ShowDataInfo()
        com.CommandText = "select * from tbltaxdeclaration where id='" & id.Text & "'" : rst = com.ExecuteReader
        While rst.Read
            cifid.Text = rst("cifid").ToString()
            txtpropertyno.Text = rst("propertyno").ToString()
            txtTaxDeclarationNo.Text = rst("taxdeclarationno").ToString()
            txtlotarea.Text = rst("lotarea").ToString()
            txtMarketValue.Text = rst("marketvalue").ToString()
            txtassessmentlevel.Text = rst("assessmentlevel").ToString()
            txtAssessedValue.Text = rst("assessedvalue").ToString()
            txtImprovement.Text = rst("improvement").ToString()
            txtTotalAssessedValue.Text = rst("totalassessedvalue").ToString()
            txtdateassessed.Text = If(rst("dateassessed").ToString() = "", "", CDate(rst("dateassessed").ToString()))
            txtbasictax.Text = rst("basictax").ToString()
            txtbasicpenalty.Text = rst("basicpenalty").ToString()
            txtTotalBasic.Text = rst("totalbasic").ToString
            txtseftax.Text = rst("seftax").ToString()
            txtsefpenalty.Text = rst("sefpenalty").ToString()
            txtTotalSef.Text = rst("totalsef").ToString
            txttotaltaxdue.Text = rst("totaltaxdue").ToString()
            txtduedate.EditValue = If(rst("duedate").ToString() = "", "", CDate(rst("duedate").ToString()))
            ckPaid.Checked = rst("paid")
            txtdatepaid.EditValue = If(rst("datepaid").ToString() = "", "", CDate(rst("datepaid").ToString()))
            txtORNumber.Text = rst("ornumber").ToString()
            txtpaymentmode.Text = rst("paymentmode").ToString()
        End While
        rst.Close()
    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        If txtTaxDeclarationNo.Text = "" Then
            XtraMessageBox.Show("Please enter tax declaration no!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtTaxDeclarationNo.Focus()
            Exit Sub
        ElseIf txtlotarea.EditValue = 0 Then
            XtraMessageBox.Show("Please enter total lot area!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtlotarea.Focus()
            Exit Sub
        ElseIf txtassessmentlevel.EditValue = 0 Then
            XtraMessageBox.Show("Please enter assessment level!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtassessmentlevel.Focus()
            Exit Sub
        ElseIf txtAssessedValue.EditValue = 0 Then
            XtraMessageBox.Show("Please enter assessed value!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtAssessedValue.Focus()
            Exit Sub
        ElseIf txtdateassessed.Text = "" Then
            XtraMessageBox.Show("Please select date assessed!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtdateassessed.Focus()
            Exit Sub
        End If
        If XtraMessageBox.Show("Are you sure you want to continue? ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            Dim Details As String = " propertyno='" & txtpropertyno.Text & "', " _
                             + " cifid='" & cifid.Text & "' ," _
                             + " taxdeclarationno='" & txtTaxDeclarationNo.Text & "', " _
                             + " lotarea='" & Val(txtlotarea.EditValue) & "', " _
                             + " marketvalue='" & Val(txtMarketValue.EditValue) & "', " _
                             + " assessmentlevel='" & Val(txtassessmentlevel.EditValue) & "', " _
                             + " assessedvalue='" & Val(txtAssessedValue.EditValue) & "', " _
                             + " improvement='" & Val(txtImprovement.EditValue) & "', " _
                             + " totalassessedvalue='" & Val(txtTotalAssessedValue.EditValue) & "', " _
                             + If(txtdateassessed.Text <> "", "dateassessed='" & ConvertDate(txtdateassessed.EditValue) & "', ", "") _
                             + " basictax='" & Val(txtbasictax.EditValue) & "', " _
                             + " basicpenalty='" & Val(txtbasicpenalty.EditValue) & "', " _
                             + " totalbasic='" & Val(txtTotalBasic.EditValue) & "', " _
                             + " seftax='" & Val(txtseftax.EditValue) & "', " _
                             + " sefpenalty='" & Val(txtsefpenalty.EditValue) & "', " _
                             + " totalsef='" & Val(txtTotalSef.EditValue) & "', " _
                             + " totaltaxdue='" & Val(txttotaltaxdue.EditValue) & "', " _
                             + If(txtduedate.Text <> "", "duedate='" & ConvertDate(txtduedate.EditValue) & "', ", "") _
                             + " paid='" & ckPaid.CheckState & "', " _
                             + If(txtdatepaid.Text <> "" And ckPaid.Checked = True, "datepaid='" & ConvertDate(txtdatepaid.EditValue) & "', ", "") _
                             + " ornumber='" & If(ckPaid.Checked = True, txtORNumber.Text, "") & "', " _
                             + " paymentmode='" & If(ckPaid.Checked = True, txtpaymentmode.Text, "") & "', " _
                             + " paymentby='" & If(ckPaid.Checked = True, globaluserid, "") & "', "

            If mode.Text = "edit" Then
                com.CommandText = "UPDATE `tbltaxdeclaration` set " & Details & " dateupdated=current_timestamp, updatedby='" & globaluserid & "' where id='" & id.Text & "'" : com.ExecuteNonQuery()
            Else
                com.CommandText = "INSERT INTO `tbltaxdeclaration` set " & Details & " datetrn=current_timestamp, trnby='" & globaluserid & "'" : com.ExecuteNonQuery()
            End If
            ClearDataInfo() : frmRealPropertyInfo.LoadTaxDeclarationHistory()
            XtraMessageBox.Show("Tax declaration successfully saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Public Sub ClearDataInfo()
        txtTaxDeclarationNo.Text = ""
        txtlotarea.Text = "0"
        txtMarketValue.Text = "0"
        txtassessmentlevel.Text = "0"
        txtAssessedValue.Text = "0"
        txtImprovement.Text = "0"
        txtTotalAssessedValue.Text = "0"
        txtdateassessed.EditValue = Nothing
        txtbasictax.Text = "0"
        txtbasicpenalty.Text = "0"
        txtTotalBasic.Text = "0"
        txtseftax.Text = "0"
        txtsefpenalty.Text = "0"
        txtTotalSef.Text = "0"
        txttotaltaxdue.Text = "0"
        txtduedate.EditValue = Nothing
        ckPaid.Checked = False
        txtdatepaid.EditValue = Nothing
        txtORNumber.Text = ""
        txtpaymentmode.SelectedIndex = -1
        mode.Text = ""
        id.Text = ""
        txtTaxDeclarationNo.Focus()
    End Sub

    Private Sub ckPaid_CheckedChanged(sender As Object, e As EventArgs) Handles ckPaid.CheckedChanged
        If ckPaid.Checked = True Then
            txtdatepaid.ReadOnly = False
            txtpaymentmode.ReadOnly = False
            txtORNumber.ReadOnly = False
        Else
            txtdatepaid.ReadOnly = True
            txtpaymentmode.ReadOnly = True
            txtORNumber.ReadOnly = True
        End If
    End Sub

    Private Sub txtbasic_EditValueChanged(sender As Object, e As EventArgs) Handles txtbasictax.EditValueChanged, txtbasicpenalty.EditValueChanged
        txtTotalBasic.Text = Val(txtbasictax.EditValue) + Val(txtbasicpenalty.EditValue)
        TaxCalculator()
    End Sub

    Private Sub txtSef_EditValueChanged(sender As Object, e As EventArgs) Handles txtseftax.EditValueChanged, txtsefpenalty.EditValueChanged
        txtTotalSef.Text = Val(txtseftax.EditValue) + Val(txtsefpenalty.EditValue)
        TaxCalculator()
    End Sub

    Private Sub txtassessmentlevel_EditValueChanged(sender As Object, e As EventArgs) Handles txtassessmentlevel.EditValueChanged
        txtAssessedValue.Text = Val(txtMarketValue.EditValue) * (Val(txtassessmentlevel.EditValue) / 100)
    End Sub

    Public Sub TaxCalculator()
        txttotaltaxdue.Text = Val(txtbasictax.EditValue) + Val(txtbasicpenalty.EditValue) + Val(txtseftax.EditValue) + Val(txtsefpenalty.EditValue)
    End Sub

    Private Sub id_EditValueChanged(sender As Object, e As EventArgs) Handles id.EditValueChanged
        If mode.Text = "edit" Then
            ShowDataInfo()
        End If
    End Sub

    Private Sub txtAssessedValue_EditValueChanged(sender As Object, e As EventArgs) Handles txtAssessedValue.EditValueChanged, txtImprovement.EditValueChanged
        txtTotalAssessedValue.Text = Val(txtAssessedValue.EditValue) + Val(txtImprovement.EditValue)
    End Sub

    
End Class