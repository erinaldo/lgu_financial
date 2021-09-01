Imports DevExpress.XtraEditors
Imports DevExpress.Skins
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmBudgetNew
    Dim MonthCode As String = ""
    Dim TransFigureMatch As Boolean = False
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmBudgetEditLine_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        com.CommandText = "SELECT monthcode FROM `tblbudgetmonthly` where fundperiod='100-2021' and closed=0 order by monthcode asc limit 1;" : rst = com.ExecuteReader
        While rst.Read
            MonthCode = rst("monthcode").ToString
        End While
        rst.Close()
        LoadOffice()
    End Sub

    Private Sub cmdSaveButton_Click(sender As Object, e As EventArgs) Handles cmdFromSaveButton.Click
        If txtTransOffice.Text = "" Then
            XtraMessageBox.Show("Please select office", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        ElseIf txtTransItemCode.Text = "" Then
            XtraMessageBox.Show("Please select account title", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        ElseIf TransFigureMatch = False Then
            XtraMessageBox.Show("Amount figure of total allocated budget doesn't match to overall total figure!" & Environment.NewLine & "Please adjust amount not more than or less than allocated budget " & Environment.NewLine & "amount and try again", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If XtraMessageBox.Show("Are you sure you want to continue?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            TransAdjustFigure()
            XtraMessageBox.Show("Fund composition successfully saved!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            ClearControlValue()
        End If
    End Sub

#Region "TARGET FUND"

    Public Sub LoadOffice()
        LoadXgridLookupSearch("SELECT officeid, officename as 'Office'  from tblcompoffice where deleted=0 order by officename asc", "tblcompoffice", txtTransOffice, gridoffice, Me)
        XgridHideColumn({"officeid"}, gridoffice)
    End Sub

    Private Sub txtTransOffice_EditValueChanged(sender As Object, e As EventArgs) Handles txtTransOffice.EditValueChanged
        txtAmountTransfer.Text = 0
        ClearControlValue()
    End Sub

    Private Sub HyperlinkLabelControl2_Click(sender As Object, e As EventArgs) Handles cmdSelectAccountTitle.Click
        frmBudgetTransferItem.officeid.Text = txtTransOffice.EditValue
        frmBudgetTransferItem.periodcode.Text = periodcode.Text
        frmBudgetTransferItem.mode.Text = "new"
        frmBudgetTransferItem.ShowDialog(Me)
        If frmBudgetTransferItem.TransactionDone = True Then
            txtTransItemCode.Text = frmBudgetTransferItem.SelectedItemCode
            txtTransAccountTitle.Text = frmBudgetTransferItem.SelectedItemName
            txtTransClassCode.Text = frmBudgetTransferItem.SelectedClassCode
            txtTransClass.Text = frmBudgetTransferItem.SelectedClassName
            frmBudgetTransferItem.TransactionDone = False
            frmBudgetTransferItem.Dispose()

        End If
    End Sub


    Public Sub ClearControlValue()
        txtTransItemCode.Text = ""
        txtTransAccountTitle.Text = ""
        txtTransClass.Text = ""
        txtTransClassCode.Text = ""
        txtAmountTransfer.EditValue = "0"
        txtTransTotalBudgetOriginal.EditValue = "0"
        txtTransTotalBudget.EditValue = "0"
        txtTransTotalUsed.EditValue = "0"
        txtTransCurrentBalance.EditValue = "0"
        txtTransOriginalBalance.EditValue = "0"
        txtTransAmount.EditValue = "0"

        txtTransJanuary.EditValue = "0"
        txtTransFebruary.EditValue = "0"
        txtTransMarch.EditValue = "0"
        txtTransApril.EditValue = "0"
        txtTransMay.EditValue = "0"
        txtTransJune.EditValue = "0"
        txtTransJuly.EditValue = "0"
        txtTransAugust.EditValue = "0"
        txtTransSeptember.EditValue = "0"
        txtTransOctober.EditValue = "0"
        txtTransNovember.EditValue = "0"
        txtTransDecember.EditValue = "0"
    End Sub





    Public Sub TransCalculator()
        Dim TotalMonthly As Double = If(MonthCode = "01", 0, Val(txtTransJanuary.EditValue)) _
                                   + If(MonthCode = "02", 0, Val(txtTransFebruary.EditValue)) _
                                   + If(MonthCode = "03", 0, Val(txtTransMarch.EditValue)) _
                                   + If(MonthCode = "04", 0, Val(txtTransApril.EditValue)) _
                                   + If(MonthCode = "05", 0, Val(txtTransMay.EditValue)) _
                                   + If(MonthCode = "06", 0, Val(txtTransJune.EditValue)) _
                                   + If(MonthCode = "07", 0, Val(txtTransJuly.EditValue)) _
                                   + If(MonthCode = "08", 0, Val(txtTransAugust.EditValue)) _
                                   + If(MonthCode = "09", 0, Val(txtTransSeptember.EditValue)) _
                                   + If(MonthCode = "10", 0, Val(txtTransOctober.EditValue)) _
                                   + If(MonthCode = "11", 0, Val(txtTransNovember.EditValue)) _
                                   + If(MonthCode = "12", 0, Val(txtTransDecember.EditValue))

        txtTransOverallTotal.EditValue = Val(txtTransTotalUsed.EditValue) + Val(txtTransCurrentBalance.EditValue) + TotalMonthly

        If Val(CC(txtTransOverallTotal.Text)) <> Val(CC(txtTransTotalBudget.Text)) Then
            TransFigureMatch = False
            txtTransOverallTotal.Properties.Appearance.BackColor = Color.Red
            txtTransOverallTotal.Properties.Appearance.ForeColor = Color.White

            txtTransTotalBudget.Properties.Appearance.BackColor = Color.Red
            txtTransTotalBudget.Properties.Appearance.ForeColor = Color.White
        Else
            TransFigureMatch = True
            txtTransOverallTotal.Properties.Appearance.BackColor = Color.Lime
            txtTransOverallTotal.Properties.Appearance.ForeColor = Color.Black

            txtTransTotalBudget.Properties.Appearance.BackColor = Color.Lime
            txtTransTotalBudget.Properties.Appearance.ForeColor = Color.Black
        End If
    End Sub

    Private Sub Compute_Trans_EditValueChanged(sender As Object, e As EventArgs) Handles txtTransJanuary.EditValueChanged, txtTransFebruary.EditValueChanged, txtTransMarch.EditValueChanged, txtTransApril.EditValueChanged, txtTransMay.EditValueChanged, txtTransJune.EditValueChanged, txtTransJuly.EditValueChanged, txtTransAugust.EditValueChanged, txtTransSeptember.EditValueChanged, txtTransOctober.EditValueChanged, txtTransNovember.EditValueChanged, txtTransDecember.EditValueChanged
        If MonthCode = "01" Then
            txtTransCurrentBalance.EditValue = Val(txtTransJanuary.EditValue) - Val(txtTransAmount.EditValue) + Val(txtTransOriginalBalance.EditValue)
        ElseIf MonthCode = "02" Then
            txtTransCurrentBalance.EditValue = Val(txtTransFebruary.EditValue) - Val(txtTransAmount.EditValue) + Val(txtTransOriginalBalance.EditValue)
        ElseIf MonthCode = "03" Then
            txtTransCurrentBalance.EditValue = Val(txtTransMarch.EditValue) - Val(txtTransAmount.EditValue) + Val(txtTransOriginalBalance.EditValue)
        ElseIf MonthCode = "04" Then
            txtTransCurrentBalance.EditValue = Val(txtTransApril.EditValue) - Val(txtTransAmount.EditValue) + Val(txtTransOriginalBalance.EditValue)
        ElseIf MonthCode = "05" Then
            txtTransCurrentBalance.EditValue = Val(txtTransMay.EditValue) - Val(txtTransAmount.EditValue) + Val(txtTransOriginalBalance.EditValue)
        ElseIf MonthCode = "06" Then
            txtTransCurrentBalance.EditValue = Val(txtTransJune.EditValue) - Val(txtTransAmount.EditValue) + Val(txtTransOriginalBalance.EditValue)
        ElseIf MonthCode = "07" Then
            txtTransCurrentBalance.EditValue = Val(txtTransJuly.EditValue) - Val(txtTransAmount.EditValue) + Val(txtTransOriginalBalance.EditValue)
        ElseIf MonthCode = "08" Then
            txtTransCurrentBalance.EditValue = Val(txtTransAugust.EditValue) - Val(txtTransAmount.EditValue) + Val(txtTransOriginalBalance.EditValue)
        ElseIf MonthCode = "09" Then
            txtTransCurrentBalance.EditValue = Val(txtTransSeptember.EditValue) - Val(txtTransAmount.EditValue) + Val(txtTransOriginalBalance.EditValue)
        ElseIf MonthCode = "10" Then
            txtTransCurrentBalance.EditValue = Val(txtTransOctober.EditValue) - Val(txtTransAmount.EditValue) + Val(txtTransOriginalBalance.EditValue)
        ElseIf MonthCode = "11" Then
            txtTransCurrentBalance.EditValue = Val(txtTransNovember.EditValue) - Val(txtTransAmount.EditValue) + Val(txtTransOriginalBalance.EditValue)
        ElseIf MonthCode = "12" Then
            txtTransCurrentBalance.EditValue = Val(txtTransDecember.EditValue) - Val(txtTransAmount.EditValue) + Val(txtTransOriginalBalance.EditValue)
        End If
        TransCalculator()
    End Sub

    Public Sub TransAdjustFigure()
        Dim UpdateAmount As String = ""
        If MonthCode = "01" Then
            UpdateAmount = " amount=" & txtTransJanuary.EditValue & ", "
        ElseIf MonthCode = "02" Then
            UpdateAmount = " amount=" & txtTransFebruary.EditValue & ", "
        ElseIf MonthCode = "03" Then
            UpdateAmount = " amount=" & txtTransMarch.EditValue & ", "
        ElseIf MonthCode = "04" Then
            UpdateAmount = " amount=" & txtTransApril.EditValue & ", "
        ElseIf MonthCode = "05" Then
            UpdateAmount = " amount=" & txtTransMay.EditValue & ", "
        ElseIf MonthCode = "06" Then
            UpdateAmount = " amount=" & txtTransJune.EditValue & ", "
        ElseIf MonthCode = "07" Then
            UpdateAmount = " amount=" & txtTransJuly.EditValue & ", "
        ElseIf MonthCode = "08" Then
            UpdateAmount = " amount=" & txtTransAugust.EditValue & ", "
        ElseIf MonthCode = "09" Then
            UpdateAmount = " amount=" & txtTransSeptember.EditValue & ", "
        ElseIf MonthCode = "10" Then
            UpdateAmount = " amount=" & txtTransOctober.EditValue & ", "
        ElseIf MonthCode = "11" Then
            UpdateAmount = " amount=" & txtTransNovember.EditValue & ", "
        ElseIf MonthCode = "12" Then
            UpdateAmount = " amount=" & txtTransDecember.EditValue & ", "
        End If

        com.CommandText = "insert into tblbudgetcomposition set periodcode='" & periodcode.Text & "', " _
                    + " fundcode='" & fundcode.Text & "', " _
                    + " yearcode='" & yearcode.Text & "', " _
                    + " officeid='" & txtTransOffice.EditValue & "', " _
                    + " classcode='" & txtTransClassCode.Text & "', " _
                    + " itemcode='" & txtTransItemCode.Text & "', " _
                    + " itemname='" & rchar(txtTransAccountTitle.Text) & "', " _
                    + " monthcode='" & MonthCode & "', " _
                    + " " & UpdateAmount & " totalbudget='" & txtTransTotalBudget.EditValue & "', january=" & txtTransJanuary.EditValue & ",february=" & txtTransFebruary.EditValue & ",march=" & txtTransMarch.EditValue & ",april=" & txtTransApril.EditValue & ",may=" & txtTransMay.EditValue & ",june=" & txtTransJune.EditValue & ",july=" & txtTransJuly.EditValue & ",august=" & txtTransAugust.EditValue & ",september=" & txtTransSeptember.EditValue & ",october=" & txtTransOctober.EditValue & ",november=" & txtTransNovember.EditValue & ",december=" & txtTransDecember.EditValue & "" : com.ExecuteNonQuery()

    End Sub

    Private Sub txtAmountTransfer_EditValueChanged(sender As Object, e As EventArgs) Handles txtAmountTransfer.EditValueChanged
        If Val(txtAmountTransfer.EditValue) > 0 Then
            txtTransTotalBudget.EditValue = Val(txtTransTotalBudgetOriginal.EditValue) + Val(txtAmountTransfer.EditValue)
            TransCalculator()
        End If
    End Sub
#End Region

End Class