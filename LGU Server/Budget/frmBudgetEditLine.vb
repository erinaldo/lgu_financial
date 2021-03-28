Imports DevExpress.XtraEditors
Imports DevExpress.Skins
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmBudgetEditLine
    Dim monthcode As String = ""
    Dim UpdateEnable As Boolean = False
    Dim FigureMatch As Boolean = False
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmBudgetEditLine_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)


    End Sub

    Private Sub id_EditValueChanged(sender As Object, e As EventArgs) Handles id.EditValueChanged
        UpdateEnable = False
        LoadBudgetInfo()
    End Sub

    Public Sub LoadBudgetInfo()
        com.CommandText = "select *,  (select officename from tblcompoffice where officeid=a.officeid) as office, " _
                            + " (select itemname from tblglitem where itemcode = a.itemcode) as itemname, " _
                            + " (select ifnull(sum(amount),0) from tblrequisitionfund as x where x.periodcode=a.periodcode and x.itemcode=a.itemcode And x.officeid=a.officeid and x.cancelled=0) as totalused, " _
                            + " amount-(select ifnull(sum(amount),0) from tblrequisitionfund as x where x.periodcode=a.periodcode and x.itemcode=a.itemcode and x.officeid=a.officeid and x.monthcode=a.monthcode and x.cancelled=0)  as balance " _
                            + " from tblbudgetcomposition as a where id='" & id.Text & "'" : rst = com.ExecuteReader
        While rst.Read
            monthcode = rst("monthcode").ToString
            txtOffice.Text = rst("office").ToString
            txtAccountTitle.Text = rst("itemname").ToString
            txtClass.Text = rst("classcode").ToString
            txtTotalBudget.EditValue = rst("totalbudget").ToString
            txtTotalUsed.EditValue = rst("totalused").ToString
            txtCurrentBalance.EditValue = rst("balance").ToString
            txtOriginalBalance.EditValue = rst("balance").ToString
            txtAmount.EditValue = rst("amount").ToString

            txtJanuary.EditValue = rst("january").ToString
            txtFebruary.EditValue = rst("february").ToString
            txtMarch.EditValue = rst("march").ToString
            txtApril.EditValue = rst("april").ToString
            txtMay.EditValue = rst("may").ToString
            txtJune.EditValue = rst("june").ToString
            txtJuly.EditValue = rst("july").ToString
            txtAugust.EditValue = rst("august").ToString
            txtSeptember.EditValue = rst("september").ToString
            txtOctober.EditValue = rst("october").ToString
            txtNovember.EditValue = rst("november").ToString
            txtDecember.EditValue = rst("december").ToString

            'txtJanuary.EditValue = If(monthcode = "01", rst("balance").ToString, rst("january").ToString)
            'txtFebruary.EditValue = If(monthcode = "02", rst("balance").ToString, rst("february").ToString)
            'txtMarch.EditValue = If(monthcode = "03", rst("balance").ToString, rst("march").ToString)
            'txtApril.EditValue = If(monthcode = "04", rst("balance").ToString, rst("april").ToString)
            'txtMay.EditValue = If(monthcode = "05", rst("balance").ToString, rst("may").ToString)
            'txtJune.EditValue = If(monthcode = "06", rst("balance").ToString, rst("june").ToString)
            'txtJuly.EditValue = If(monthcode = "07", rst("balance").ToString, rst("july").ToString)
            'txtAugust.EditValue = If(monthcode = "08", rst("balance").ToString, rst("august").ToString)
            'txtSeptember.EditValue = If(monthcode = "09", rst("balance").ToString, rst("september").ToString)
            'txtOctober.EditValue = If(monthcode = "10", rst("balance").ToString, rst("october").ToString)
            'txtNovember.EditValue = If(monthcode = "11", rst("balance").ToString, rst("november").ToString)
            'txtDecember.EditValue = If(monthcode = "12", rst("balance").ToString, rst("december").ToString)


        End While
        rst.Close()
        MonthControl()

    End Sub

    Public Sub MonthControl()
        Dim ctrl() As TextEdit = {txtJanuary, txtFebruary, txtMarch, txtApril, txtMay, txtJune, txtJuly, txtAugust, txtSeptember, txtOctober, txtNovember, txtDecember}
        If UpdateEnable Then
            For Each ctl In ctrl
                ctl.ReadOnly = False
            Next

            Dim i As Integer = 1
            For Each ctl In ctrl
                If i < Val(monthcode) Then
                    ctl.ReadOnly = True
                    ctl.Properties.Appearance.BackColor = DefaultBackColor
                ElseIf i = Val(monthcode) Then
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
        ButtonControl()
        Calculator()
    End Sub

    Public Sub ButtonControl()
        If UpdateEnable = False Then
            cmdSaveButton.Text = "Adjust Figure"
            cmdSaveButton.Appearance.BackColor = Color.Red
            cmdSaveButton.Appearance.ForeColor = Color.White
        Else
            cmdSaveButton.Text = "Confirm Save"
            cmdSaveButton.Appearance.BackColor = Color.ForestGreen
            cmdSaveButton.Appearance.ForeColor = Color.Black
        End If
    End Sub

    Public Sub Calculator()
        Dim TotalMonthly As Double = If(monthcode = "01", 0, Val(txtJanuary.EditValue)) _
                                   + If(monthcode = "02", 0, Val(txtFebruary.EditValue)) _
                                   + If(monthcode = "03", 0, Val(txtMarch.EditValue)) _
                                   + If(monthcode = "04", 0, Val(txtApril.EditValue)) _
                                   + If(monthcode = "05", 0, Val(txtMay.EditValue)) _
                                   + If(monthcode = "06", 0, Val(txtJune.EditValue)) _
                                   + If(monthcode = "07", 0, Val(txtJuly.EditValue)) _
                                   + If(monthcode = "08", 0, Val(txtAugust.EditValue)) _
                                   + If(monthcode = "09", 0, Val(txtSeptember.EditValue)) _
                                   + If(monthcode = "10", 0, Val(txtOctober.EditValue)) _
                                   + If(monthcode = "11", 0, Val(txtNovember.EditValue)) _
                                   + If(monthcode = "12", 0, Val(txtDecember.EditValue))

        txtOverallTotal.EditValue = Val(txtTotalUsed.EditValue) + Val(txtCurrentBalance.EditValue) + TotalMonthly

        If UpdateEnable Then
            If Val(CC(txtOverallTotal.Text)) <> Val(CC(txtTotalBudget.Text)) Then
                FigureMatch = False
                txtOverallTotal.Properties.Appearance.BackColor = Color.Red
                txtOverallTotal.Properties.Appearance.ForeColor = Color.White

                txtTotalBudget.Properties.Appearance.BackColor = Color.Red
                txtTotalBudget.Properties.Appearance.ForeColor = Color.White
            Else
                FigureMatch = True
                txtOverallTotal.Properties.Appearance.BackColor = Color.Lime
                txtOverallTotal.Properties.Appearance.ForeColor = Color.Black

                txtTotalBudget.Properties.Appearance.BackColor = Color.Lime
                txtTotalBudget.Properties.Appearance.ForeColor = Color.Black
            End If
        Else
            txtOverallTotal.Properties.Appearance.BackColor = DefaultBackColor
            txtOverallTotal.Properties.Appearance.ForeColor = DefaultForeColor

            txtTotalBudget.Properties.Appearance.BackColor = DefaultBackColor
            txtTotalBudget.Properties.Appearance.ForeColor = DefaultForeColor
        End If
    End Sub

    Private Sub Compute_EditValueChanged(sender As Object, e As EventArgs) Handles txtJanuary.EditValueChanged, txtFebruary.EditValueChanged, txtMarch.EditValueChanged, txtApril.EditValueChanged, txtMay.EditValueChanged, txtJune.EditValueChanged, txtJuly.EditValueChanged, txtAugust.EditValueChanged, txtSeptember.EditValueChanged, txtOctober.EditValueChanged, txtNovember.EditValueChanged, txtDecember.EditValueChanged
        If UpdateEnable Then
            If monthcode = "01" Then
                txtCurrentBalance.EditValue = Val(txtJanuary.EditValue) - Val(txtAmount.EditValue) + Val(txtOriginalBalance.EditValue)
            ElseIf monthcode = "02" Then
                txtCurrentBalance.EditValue = Val(txtFebruary.EditValue) - Val(txtAmount.EditValue) + Val(txtOriginalBalance.EditValue)
            ElseIf monthcode = "03" Then
                txtCurrentBalance.EditValue = Val(txtMarch.EditValue) - Val(txtAmount.EditValue) + Val(txtOriginalBalance.EditValue)
            ElseIf monthcode = "04" Then
                txtCurrentBalance.EditValue = Val(txtApril.EditValue) - Val(txtAmount.EditValue) + Val(txtOriginalBalance.EditValue)
            ElseIf monthcode = "05" Then
                txtCurrentBalance.EditValue = Val(txtMay.EditValue) - Val(txtAmount.EditValue) + Val(txtOriginalBalance.EditValue)
            ElseIf monthcode = "06" Then
                txtCurrentBalance.EditValue = Val(txtJune.EditValue) - Val(txtAmount.EditValue) + Val(txtOriginalBalance.EditValue)
            ElseIf monthcode = "07" Then
                txtCurrentBalance.EditValue = Val(txtJuly.EditValue) - Val(txtAmount.EditValue) + Val(txtOriginalBalance.EditValue)
            ElseIf monthcode = "08" Then
                txtCurrentBalance.EditValue = Val(txtAugust.EditValue) - Val(txtAmount.EditValue) + Val(txtOriginalBalance.EditValue)
            ElseIf monthcode = "09" Then
                txtCurrentBalance.EditValue = Val(txtSeptember.EditValue) - Val(txtAmount.EditValue) + Val(txtOriginalBalance.EditValue)
            ElseIf monthcode = "10" Then
                txtCurrentBalance.EditValue = Val(txtOctober.EditValue) - Val(txtAmount.EditValue) + Val(txtOriginalBalance.EditValue)
            ElseIf monthcode = "11" Then
                txtCurrentBalance.EditValue = Val(txtNovember.EditValue) - Val(txtAmount.EditValue) + Val(txtOriginalBalance.EditValue)
            ElseIf monthcode = "12" Then
                txtCurrentBalance.EditValue = Val(txtDecember.EditValue) - Val(txtAmount.EditValue) + Val(txtOriginalBalance.EditValue)
            End If
        End If
        Calculator()
    End Sub

    Private Sub cmdSaveButton_Click(sender As Object, e As EventArgs) Handles cmdSaveButton.Click
        If UpdateEnable = False Then
            UpdateEnable = True
            MonthControl()
        Else
            If FigureMatch = False Then
                XtraMessageBox.Show("Figure of total allocated budget doesn't match to overall total figure!" & Environment.NewLine & "Please adjust amount not more than or less than allocated budget " & Environment.NewLine & "amount and try again", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            If XtraMessageBox.Show("Are you sure you want to continue?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                Dim UpdateAmount As String = ""
                If monthcode = "01" Then
                    UpdateAmount = " amount=" & txtJanuary.EditValue & ", "
                ElseIf monthcode = "02" Then
                    UpdateAmount = " amount=" & txtFebruary.EditValue & ", "
                ElseIf monthcode = "03" Then
                    UpdateAmount = " amount=" & txtMarch.EditValue & ", "
                ElseIf monthcode = "04" Then
                    UpdateAmount = " amount=" & txtApril.EditValue & ", "
                ElseIf monthcode = "05" Then
                    UpdateAmount = " amount=" & txtMay.EditValue & ", "
                ElseIf monthcode = "06" Then
                    UpdateAmount = " amount=" & txtJune.EditValue & ", "
                ElseIf monthcode = "07" Then
                    UpdateAmount = " amount=" & txtJuly.EditValue & ", "
                ElseIf monthcode = "08" Then
                    UpdateAmount = " amount=" & txtAugust.EditValue & ", "
                ElseIf monthcode = "09" Then
                    UpdateAmount = " amount=" & txtSeptember.EditValue & ", "
                ElseIf monthcode = "10" Then
                    UpdateAmount = " amount=" & txtOctober.EditValue & ", "
                ElseIf monthcode = "11" Then
                    UpdateAmount = " amount=" & txtNovember.EditValue & ", "
                ElseIf monthcode = "12" Then
                    UpdateAmount = " amount=" & txtDecember.EditValue & ", "
                End If

                com.CommandText = "update tblbudgetcomposition set " & UpdateAmount & " january=" & txtJanuary.EditValue & ",february=" & txtFebruary.EditValue & ",march=" & txtMarch.EditValue & ",april=" & txtApril.EditValue & ",may=" & txtMay.EditValue & ",june=" & txtJune.EditValue & ",july=" & txtJuly.EditValue & ",august=" & txtAugust.EditValue & ",september=" & txtSeptember.EditValue & ",october=" & txtOctober.EditValue & ",november=" & txtNovember.EditValue & ",december=" & txtDecember.EditValue & " where id='" & id.Text & "'" : com.ExecuteNonQuery()
                UpdateEnable = False
                MonthControl()
                XtraMessageBox.Show("Figure successfully updated!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub
End Class