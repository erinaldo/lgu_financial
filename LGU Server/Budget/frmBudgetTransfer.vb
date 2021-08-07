Imports DevExpress.XtraEditors
Imports DevExpress.Skins
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmBudgetTransfer
    Dim MonthCode As String = ""
    Dim UpdateEnable As Boolean = False
    Dim FromFigureMatch As Boolean = False
    Dim TransFigureMatch As Boolean = False
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmBudgetEditLine_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        LoadOffice()
    End Sub

    Private Sub cmdSaveButton_Click(sender As Object, e As EventArgs) Handles cmdFromSaveButton.Click
        If UpdateEnable = False Then
            UpdateEnable = True
            FromMonthControl()
            TransMonthControl()
            ButtonControl()
        Else
            If txtTransOffice.Text = "" Then
                XtraMessageBox.Show("Please select target transfer office", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            ElseIf txtTransItemCode.Text = "" Then
                XtraMessageBox.Show("Please select target transfer account title", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            ElseIf FromFigureMatch = False Then
                XtraMessageBox.Show("Source transfer figure of total allocated budget doesn't match to overall total figure!" & Environment.NewLine & "Please adjust amount not more than or less than allocated budget " & Environment.NewLine & "amount and try again", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            ElseIf TransFigureMatch = False Then
                XtraMessageBox.Show("Target transfer figure of total allocated budget doesn't match to overall total figure!" & Environment.NewLine & "Please adjust amount not more than or less than allocated budget " & Environment.NewLine & "amount and try again", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            If XtraMessageBox.Show("Are you sure you want to continue?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                FromAdjustFigure()
                TransAdjustFigure()

                UpdateEnable = False
                XtraMessageBox.Show("Transfer successfully updated!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Public Sub ButtonControl()
        If UpdateEnable = False Then
            cmdFromSaveButton.Text = "Adjust Transfer Figure"
            cmdFromSaveButton.Appearance.BackColor = Color.Red
            cmdFromSaveButton.Appearance.ForeColor = Color.White
        Else
            cmdFromSaveButton.Text = "Confirm Save"
            cmdFromSaveButton.Appearance.BackColor = Color.ForestGreen
            cmdFromSaveButton.Appearance.ForeColor = Color.Black
        End If
    End Sub

#Region "SOURCE FUND"
    Private Sub id_EditValueChanged(sender As Object, e As EventArgs) Handles from_id.EditValueChanged
        UpdateEnable = False
        FromLoadBudgetInfo()
    End Sub

    Public Sub FromLoadBudgetInfo()
        com.CommandText = "select *,(select officename from tblcompoffice where officeid=a.officeid) as office, " _
                            + " (select itemname from tblglitem where itemcode = a.itemcode) as itemname, " _
                            + " (select description from tblexpenditureclass where code = a.classcode) as class, " _
                            + " (select ifnull(sum(amount),0) from tblrequisitionfund as x where x.periodcode=a.periodcode and x.itemcode=a.itemcode And x.officeid=a.officeid and x.cancelled=0) as totalused, " _
                            + " amount-(select ifnull(sum(amount),0) from tblrequisitionfund as x where x.periodcode=a.periodcode and x.itemcode=a.itemcode and x.officeid=a.officeid and x.monthcode=a.monthcode and x.cancelled=0)  as balance " _
                            + " from tblbudgetcomposition as a where id='" & from_id.Text & "'" : rst = com.ExecuteReader
        While rst.Read
            fundcode.Text = rst("fundcode").ToString
            yearcode.Text = rst("yearcode").ToString
            MonthCode = rst("monthcode").ToString
            periodcode.Text = rst("periodcode").ToString
            txtFromOffice.Text = rst("office").ToString
            txtFromAccountTitle.Text = rst("itemname").ToString
            txtFromClass.Text = rst("class").ToString
            txtFromClassCode.Text = rst("classcode").ToString
            txtFromTotalBudget.EditValue = rst("totalbudget").ToString
            txtFromTotalBudgetOriginal.EditValue = rst("totalbudget").ToString
            txtFromTotalUsed.EditValue = rst("totalused").ToString
            txtFromCurrentBalance.EditValue = rst("balance").ToString
            txtFromOriginalBalance.EditValue = rst("balance").ToString
            txtFromAmount.EditValue = rst("amount").ToString

            txtFromJanuary.EditValue = rst("january").ToString
            txtFromFebruary.EditValue = rst("february").ToString
            txtFromMarch.EditValue = rst("march").ToString
            txtFromApril.EditValue = rst("april").ToString
            txtFromMay.EditValue = rst("may").ToString
            txtFromJune.EditValue = rst("june").ToString
            txtFromJuly.EditValue = rst("july").ToString
            txtFromAugust.EditValue = rst("august").ToString
            txtFromSeptember.EditValue = rst("september").ToString
            txtFromOctober.EditValue = rst("october").ToString
            txtFromNovember.EditValue = rst("november").ToString
            txtFromDecember.EditValue = rst("december").ToString
        End While
        rst.Close()
        FromMonthControl()

    End Sub

    Public Sub FromMonthControl()
        Dim ctrl() As TextEdit = {txtFromJanuary, txtFromFebruary, txtFromMarch, txtFromApril, txtFromMay, txtFromJune, txtFromJuly, txtFromAugust, txtFromSeptember, txtFromOctober, txtFromNovember, txtFromDecember}
        If UpdateEnable Then
            For Each ctl In ctrl
                ctl.ReadOnly = False
            Next

            Dim i As Integer = 1
            For Each ctl In ctrl
                If i < Val(MonthCode) Then
                    ctl.ReadOnly = True
                    ctl.Properties.Appearance.BackColor = DefaultBackColor
                ElseIf i = Val(MonthCode) Then
                    ctl.Properties.Appearance.BackColor = Color.Aqua
                Else
                    ctl.Properties.Appearance.BackColor = Color.White
                End If
                i += 1
            Next
        Else
            For Each ctl In ctrl
                ctl.ReadOnly = True
                ctl.Properties.Appearance.BackColor = DefaultBackColor
            Next
        End If
        FromCalculator()
    End Sub



    Public Sub FromCalculator()
        Dim TotalMonthly As Double = If(MonthCode = "01", 0, Val(txtFromJanuary.EditValue)) _
                                   + If(MonthCode = "02", 0, Val(txtFromFebruary.EditValue)) _
                                   + If(MonthCode = "03", 0, Val(txtFromMarch.EditValue)) _
                                   + If(MonthCode = "04", 0, Val(txtFromApril.EditValue)) _
                                   + If(MonthCode = "05", 0, Val(txtFromMay.EditValue)) _
                                   + If(MonthCode = "06", 0, Val(txtFromJune.EditValue)) _
                                   + If(MonthCode = "07", 0, Val(txtFromJuly.EditValue)) _
                                   + If(MonthCode = "08", 0, Val(txtFromAugust.EditValue)) _
                                   + If(MonthCode = "09", 0, Val(txtFromSeptember.EditValue)) _
                                   + If(MonthCode = "10", 0, Val(txtFromOctober.EditValue)) _
                                   + If(MonthCode = "11", 0, Val(txtFromNovember.EditValue)) _
                                   + If(MonthCode = "12", 0, Val(txtFromDecember.EditValue))

        txtFromOverallTotal.EditValue = Val(txtFromTotalUsed.EditValue) + Val(txtFromCurrentBalance.EditValue) + TotalMonthly

        If UpdateEnable Then
            If Val(CC(txtFromOverallTotal.Text)) <> Val(CC(txtFromTotalBudget.Text)) Then
                FromFigureMatch = False
                txtFromOverallTotal.Properties.Appearance.BackColor = Color.Red
                txtFromOverallTotal.Properties.Appearance.ForeColor = Color.White

                txtFromTotalBudget.Properties.Appearance.BackColor = Color.Red
                txtFromTotalBudget.Properties.Appearance.ForeColor = Color.White
            Else
                FromFigureMatch = True
                txtFromOverallTotal.Properties.Appearance.BackColor = Color.Lime
                txtFromOverallTotal.Properties.Appearance.ForeColor = Color.Black

                txtFromTotalBudget.Properties.Appearance.BackColor = Color.Lime
                txtFromTotalBudget.Properties.Appearance.ForeColor = Color.Black
            End If
        Else
            txtFromOverallTotal.Properties.Appearance.BackColor = DefaultBackColor
            txtFromOverallTotal.Properties.Appearance.ForeColor = DefaultForeColor

            txtFromTotalBudget.Properties.Appearance.BackColor = DefaultBackColor
            txtFromTotalBudget.Properties.Appearance.ForeColor = DefaultForeColor
        End If
    End Sub

    Private Sub Compute_EditValueChanged(sender As Object, e As EventArgs) Handles txtFromJanuary.EditValueChanged, txtFromFebruary.EditValueChanged, txtFromMarch.EditValueChanged, txtFromApril.EditValueChanged, txtFromMay.EditValueChanged, txtFromJune.EditValueChanged, txtFromJuly.EditValueChanged, txtFromAugust.EditValueChanged, txtFromSeptember.EditValueChanged, txtFromOctober.EditValueChanged, txtFromNovember.EditValueChanged, txtFromDecember.EditValueChanged
        If UpdateEnable Then
            If MonthCode = "01" Then
                txtFromCurrentBalance.EditValue = Val(txtFromJanuary.EditValue) - Val(txtFromAmount.EditValue) + Val(txtFromOriginalBalance.EditValue)
            ElseIf MonthCode = "02" Then
                txtFromCurrentBalance.EditValue = Val(txtFromFebruary.EditValue) - Val(txtFromAmount.EditValue) + Val(txtFromOriginalBalance.EditValue)
            ElseIf MonthCode = "03" Then
                txtFromCurrentBalance.EditValue = Val(txtFromMarch.EditValue) - Val(txtFromAmount.EditValue) + Val(txtFromOriginalBalance.EditValue)
            ElseIf MonthCode = "04" Then
                txtFromCurrentBalance.EditValue = Val(txtFromApril.EditValue) - Val(txtFromAmount.EditValue) + Val(txtFromOriginalBalance.EditValue)
            ElseIf MonthCode = "05" Then
                txtFromCurrentBalance.EditValue = Val(txtFromMay.EditValue) - Val(txtFromAmount.EditValue) + Val(txtFromOriginalBalance.EditValue)
            ElseIf MonthCode = "06" Then
                txtFromCurrentBalance.EditValue = Val(txtFromJune.EditValue) - Val(txtFromAmount.EditValue) + Val(txtFromOriginalBalance.EditValue)
            ElseIf MonthCode = "07" Then
                txtFromCurrentBalance.EditValue = Val(txtFromJuly.EditValue) - Val(txtFromAmount.EditValue) + Val(txtFromOriginalBalance.EditValue)
            ElseIf MonthCode = "08" Then
                txtFromCurrentBalance.EditValue = Val(txtFromAugust.EditValue) - Val(txtFromAmount.EditValue) + Val(txtFromOriginalBalance.EditValue)
            ElseIf MonthCode = "09" Then
                txtFromCurrentBalance.EditValue = Val(txtFromSeptember.EditValue) - Val(txtFromAmount.EditValue) + Val(txtFromOriginalBalance.EditValue)
            ElseIf MonthCode = "10" Then
                txtFromCurrentBalance.EditValue = Val(txtFromOctober.EditValue) - Val(txtFromAmount.EditValue) + Val(txtFromOriginalBalance.EditValue)
            ElseIf MonthCode = "11" Then
                txtFromCurrentBalance.EditValue = Val(txtFromNovember.EditValue) - Val(txtFromAmount.EditValue) + Val(txtFromOriginalBalance.EditValue)
            ElseIf MonthCode = "12" Then
                txtFromCurrentBalance.EditValue = Val(txtFromDecember.EditValue) - Val(txtFromAmount.EditValue) + Val(txtFromOriginalBalance.EditValue)
            End If
        End If
        FromCalculator()
    End Sub

    Public Sub FromAdjustFigure()
        Dim UpdateAmount As String = ""
        If MonthCode = "01" Then
            UpdateAmount = " amount=" & txtFromJanuary.EditValue & ", "
        ElseIf MonthCode = "02" Then
            UpdateAmount = " amount=" & txtFromFebruary.EditValue & ", "
        ElseIf MonthCode = "03" Then
            UpdateAmount = " amount=" & txtFromMarch.EditValue & ", "
        ElseIf MonthCode = "04" Then
            UpdateAmount = " amount=" & txtFromApril.EditValue & ", "
        ElseIf MonthCode = "05" Then
            UpdateAmount = " amount=" & txtFromMay.EditValue & ", "
        ElseIf MonthCode = "06" Then
            UpdateAmount = " amount=" & txtFromJune.EditValue & ", "
        ElseIf MonthCode = "07" Then
            UpdateAmount = " amount=" & txtFromJuly.EditValue & ", "
        ElseIf MonthCode = "08" Then
            UpdateAmount = " amount=" & txtFromAugust.EditValue & ", "
        ElseIf MonthCode = "09" Then
            UpdateAmount = " amount=" & txtFromSeptember.EditValue & ", "
        ElseIf MonthCode = "10" Then
            UpdateAmount = " amount=" & txtFromOctober.EditValue & ", "
        ElseIf MonthCode = "11" Then
            UpdateAmount = " amount=" & txtFromNovember.EditValue & ", "
        ElseIf MonthCode = "12" Then
            UpdateAmount = " amount=" & txtFromDecember.EditValue & ", "
        End If

        com.CommandText = "update tblbudgetcomposition set " & UpdateAmount & " totalbudget='" & txtFromTotalBudget.EditValue & "', january=" & txtFromJanuary.EditValue & ",february=" & txtFromFebruary.EditValue & ",march=" & txtFromMarch.EditValue & ",april=" & txtFromApril.EditValue & ",may=" & txtFromMay.EditValue & ",june=" & txtFromJune.EditValue & ",july=" & txtFromJuly.EditValue & ",august=" & txtFromAugust.EditValue & ",september=" & txtFromSeptember.EditValue & ",october=" & txtFromOctober.EditValue & ",november=" & txtFromNovember.EditValue & ",december=" & txtFromDecember.EditValue & " where id='" & from_id.Text & "'" : com.ExecuteNonQuery()
        UpdateEnable = False
        FromMonthControl()
    End Sub


#End Region

#Region "TARGET FUND"
    Private Sub trans_id_EditValueChanged(sender As Object, e As EventArgs) Handles trans_id.EditValueChanged
        TransLoadBudgetInfo()
    End Sub
    Public Sub LoadOffice()
        LoadXgridLookupSearch("SELECT officeid, officename as 'Office'  from tblcompoffice where deleted=0 order by officename asc", "tblcompoffice", txtTransOffice, gridoffice, Me)
        XgridHideColumn({"officeid"}, gridoffice)
    End Sub

    Private Sub txtTransOffice_EditValueChanged(sender As Object, e As EventArgs) Handles txtTransOffice.EditValueChanged
        trans_id.Text = "" : txtAmountTransfer.Text = 0
        TransLoadBudgetInfo()
    End Sub


    Private Sub HyperlinkLabelControl2_Click(sender As Object, e As EventArgs) Handles cmdSelectAccountTitle.Click
        frmBudgetTransferItem.officeid.Text = txtTransOffice.EditValue
        frmBudgetTransferItem.periodcode.Text = periodcode.Text
        frmBudgetTransferItem.ShowDialog(Me)
        If frmBudgetTransferItem.TransactionDone = True Then
            If frmBudgetTransferItem.SelectedTid = "" Then
                txtTransItemCode.Text = frmBudgetTransferItem.SelectedItemCode
                txtTransAccountTitle.Text = frmBudgetTransferItem.SelectedItemName
                txtTransClassCode.Text = frmBudgetTransferItem.SelectedClassCode
                txtTransClass.Text = frmBudgetTransferItem.SelectedClassName
            Else
                trans_id.Text = frmBudgetTransferItem.SelectedTid
                TransLoadBudgetInfo()
            End If


            frmBudgetTransferItem.TransactionDone = False
            frmBudgetTransferItem.Dispose()

        End If
    End Sub



    Public Sub TransLoadBudgetInfo()
        If Not trans_id.Text = "" Then
            com.CommandText = "select *,(select officename from tblcompoffice where officeid=a.officeid) as office, " _
                            + " (select itemname from tblglitem where itemcode = a.itemcode) as itemname, " _
                            + " (select description from tblexpenditureclass where code = a.classcode) as class, " _
                            + " (select ifnull(sum(amount),0) from tblrequisitionfund as x where x.periodcode=a.periodcode and x.itemcode=a.itemcode And x.officeid=a.officeid and x.cancelled=0) as totalused, " _
                            + " amount-(select ifnull(sum(amount),0) from tblrequisitionfund as x where x.periodcode=a.periodcode and x.itemcode=a.itemcode and x.officeid=a.officeid and x.monthcode=a.monthcode and x.cancelled=0)  as balance " _
                            + " from tblbudgetcomposition as a where id='" & trans_id.Text & "'" : rst = com.ExecuteReader
            While rst.Read
                periodcode.Text = rst("periodcode").ToString
                txtTransItemCode.Text = rst("itemcode").ToString
                txtTransAccountTitle.Text = rst("itemname").ToString
                txtTransClass.Text = rst("class").ToString
                txtTransClassCode.Text = rst("classcode").ToString
                txtTransTotalBudgetOriginal.EditValue = rst("totalbudget").ToString
                txtTransTotalBudget.EditValue = rst("totalbudget").ToString
                txtTransTotalUsed.EditValue = rst("totalused").ToString
                txtTransCurrentBalance.EditValue = rst("balance").ToString
                txtTransOriginalBalance.EditValue = rst("balance").ToString
                txtTransAmount.EditValue = rst("amount").ToString

                txtTransJanuary.EditValue = rst("january").ToString
                txtTransFebruary.EditValue = rst("february").ToString
                txtTransMarch.EditValue = rst("march").ToString
                txtTransApril.EditValue = rst("april").ToString
                txtTransMay.EditValue = rst("may").ToString
                txtTransJune.EditValue = rst("june").ToString
                txtTransJuly.EditValue = rst("july").ToString
                txtTransAugust.EditValue = rst("august").ToString
                txtTransSeptember.EditValue = rst("september").ToString
                txtTransOctober.EditValue = rst("october").ToString
                txtTransNovember.EditValue = rst("november").ToString
                txtTransDecember.EditValue = rst("december").ToString
            End While
            rst.Close()
            TransMonthControl()
        Else
            txtTransItemCode.Text = ""
            txtTransAccountTitle.Text = ""
            txtTransClass.Text = ""
            txtTransClassCode.Text = ""
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
        End If


    End Sub

    Public Sub TransMonthControl()
        Dim ctrl() As TextEdit = {txtTransJanuary, txtTransFebruary, txtTransMarch, txtTransApril, txtTransMay, txtTransJune, txtTransJuly, txtTransAugust, txtTransSeptember, txtTransOctober, txtTransNovember, txtTransDecember}
        If UpdateEnable Then
            For Each ctl In ctrl
                ctl.ReadOnly = False
            Next

            Dim i As Integer = 1
            For Each ctl In ctrl
                If i < Val(MonthCode) Then
                    ctl.ReadOnly = True
                    ctl.Properties.Appearance.BackColor = DefaultBackColor
                ElseIf i = Val(MonthCode) Then
                    ctl.Properties.Appearance.BackColor = Color.Aqua
                Else
                    ctl.Properties.Appearance.BackColor = Color.White
                End If
                i += 1
            Next
            txtTransOffice.ReadOnly = False
            txtAmountTransfer.ReadOnly = False
            cmdSelectAccountTitle.Enabled = True
        Else
            For Each ctl In ctrl
                ctl.ReadOnly = True
                ctl.Properties.Appearance.BackColor = DefaultBackColor
            Next
            txtTransOffice.ReadOnly = True
            txtAmountTransfer.ReadOnly = True
            cmdSelectAccountTitle.Enabled = False
        End If
        TransButtonControl()
        TransCalculator()
    End Sub

    Public Sub TransButtonControl()
        If UpdateEnable = False Then
            cmdFromSaveButton.Text = "Adjust Figure"
            cmdFromSaveButton.Appearance.BackColor = Color.Red
            cmdFromSaveButton.Appearance.ForeColor = Color.White
        Else
            cmdFromSaveButton.Text = "Confirm Save"
            cmdFromSaveButton.Appearance.BackColor = Color.ForestGreen
            cmdFromSaveButton.Appearance.ForeColor = Color.Black
        End If
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

        If UpdateEnable Then
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
        Else
            txtTransOverallTotal.Properties.Appearance.BackColor = DefaultBackColor
            txtTransOverallTotal.Properties.Appearance.ForeColor = DefaultForeColor

            txtTransTotalBudget.Properties.Appearance.BackColor = DefaultBackColor
            txtTransTotalBudget.Properties.Appearance.ForeColor = DefaultForeColor
        End If
    End Sub

    Private Sub Compute_Trans_EditValueChanged(sender As Object, e As EventArgs) Handles txtTransJanuary.EditValueChanged, txtTransFebruary.EditValueChanged, txtTransMarch.EditValueChanged, txtTransApril.EditValueChanged, txtTransMay.EditValueChanged, txtTransJune.EditValueChanged, txtTransJuly.EditValueChanged, txtTransAugust.EditValueChanged, txtTransSeptember.EditValueChanged, txtTransOctober.EditValueChanged, txtTransNovember.EditValueChanged, txtTransDecember.EditValueChanged, txtFromSeptember.EditValueChanged, txtFromOctober.EditValueChanged, txtFromNovember.EditValueChanged, txtFromMay.EditValueChanged, txtFromMarch.EditValueChanged, txtFromJune.EditValueChanged, txtFromJuly.EditValueChanged, txtFromJanuary.EditValueChanged, txtFromFebruary.EditValueChanged, txtFromDecember.EditValueChanged, txtFromAugust.EditValueChanged, txtFromApril.EditValueChanged
        If UpdateEnable Then
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

        If Not trans_id.Text = "" Then
            com.CommandText = "update tblbudgetcomposition set " & UpdateAmount & " monthcode='" & MonthCode & "', totalbudget='" & txtTransTotalBudget.EditValue & "', january=" & txtTransJanuary.EditValue & ",february=" & txtTransFebruary.EditValue & ",march=" & txtTransMarch.EditValue & ",april=" & txtTransApril.EditValue & ",may=" & txtTransMay.EditValue & ",june=" & txtTransJune.EditValue & ",july=" & txtTransJuly.EditValue & ",august=" & txtTransAugust.EditValue & ",september=" & txtTransSeptember.EditValue & ",october=" & txtTransOctober.EditValue & ",november=" & txtTransNovember.EditValue & ",december=" & txtTransDecember.EditValue & " where id='" & trans_id.Text & "'" : com.ExecuteNonQuery()
        Else
            com.CommandText = "insert into tblbudgetcomposition set periodcode='" & periodcode.Text & "', " _
                    + " fundcode='" & fundcode.Text & "', " _
                    + " yearcode='" & yearcode.Text & "', " _
                    + " officeid='" & txtTransOffice.EditValue & "', " _
                    + " classcode='" & txtTransClassCode.Text & "', " _
                    + " itemcode='" & txtTransItemCode.Text & "', " _
                    + " itemname='" & rchar(txtTransAccountTitle.Text) & "', " _
                    + " monthcode='" & MonthCode & "', " _
                    + " " & UpdateAmount & " totalbudget='" & txtTransTotalBudget.EditValue & "', january=" & txtTransJanuary.EditValue & ",february=" & txtTransFebruary.EditValue & ",march=" & txtTransMarch.EditValue & ",april=" & txtTransApril.EditValue & ",may=" & txtTransMay.EditValue & ",june=" & txtTransJune.EditValue & ",july=" & txtTransJuly.EditValue & ",august=" & txtTransAugust.EditValue & ",september=" & txtTransSeptember.EditValue & ",october=" & txtTransOctober.EditValue & ",november=" & txtTransNovember.EditValue & ",december=" & txtTransDecember.EditValue & "" : com.ExecuteNonQuery()
        End If
        TransMonthControl()
    End Sub

    Private Sub txtAmountTransfer_EditValueChanged(sender As Object, e As EventArgs) Handles txtAmountTransfer.EditValueChanged
        If Val(txtAmountTransfer.EditValue) > 0 Then
            txtFromTotalBudget.EditValue = Val(txtFromTotalBudgetOriginal.EditValue) - Val(txtAmountTransfer.EditValue)
            txtTransTotalBudget.EditValue = Val(txtTransTotalBudgetOriginal.EditValue) + Val(txtAmountTransfer.EditValue)
            FromCalculator()
            TransCalculator()
        End If
    End Sub


#End Region

End Class