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
        PermissionAccess({cmdSaveButton}, globalAllowEdit)

    End Sub

    Private Sub id_EditValueChanged(sender As Object, e As EventArgs) Handles id.EditValueChanged
        UpdateEnable = False
        LoadBudgetInfo()
    End Sub

    Public Sub LoadBudgetInfo()
        Dim officeid As String = ""
        Dim periodcode As String = ""
        Dim classcode As String = ""
        Dim itemcode As String = ""
        'com.CommandText = "select * from (select id, officeid,periodcode,monthcode,classcode,itemcode,itemname, (select officename from tblcompoffice where officeid=a.officeid) as office, " _
        '                    + " (select ifnull(sum(amount),0) from tblrequisitionfund as x where x.periodcode=a.periodcode and x.itemcode=a.itemcode And x.officeid=a.officeid and x.cancelled=0) as totalused, " _
        '                    + " (select ifnull(sum(amount),0) from tblrequisitionfund as x where x.periodcode=a.periodcode and x.itemcode=a.itemcode And x.officeid=a.officeid And x.cancelled=0 and (x.pid not in (select pid from tbldisbursementvoucher as dv where dv.cancelled=0) or x.pid in (select pid from tbldisbursementvoucher as dv where dv.checkissued=0 and dv.cancelled=0))) as 'NYDD', " _
        '                    + " (select ifnull(sum(amount),0) from tblrequisitionfund as x where x.periodcode=a.periodcode and x.itemcode=a.itemcode And x.officeid=a.officeid And x.cancelled=0 and x.pid in (select pid from tbldisbursementvoucher as dv where dv.checkissued=1 and dv.cleared=0 and dv.cancelled=0)) as 'DD', " _
        '                    + " (select ifnull(sum(amount),0) from tblrequisitionfund as x where x.periodcode=a.periodcode and x.itemcode=a.itemcode And x.officeid=a.officeid And x.cancelled=0 and x.pid in (select pid from tbldisbursementvoucher as dv where dv.checkissued=1 and dv.cleared=1 and dv.cancelled=0)) as 'CLEARED', " _
        '                    + " amount-(select ifnull(sum(amount),0) from tblrequisitionfund as x where x.periodcode=a.periodcode and x.itemcode=a.itemcode and x.officeid=a.officeid and x.monthcode=a.monthcode and x.cancelled=0)  as balance " _
        '                    + " from tblbudgetcomposition as a) as y where id='" & id.Text & "'" : rst = com.ExecuteReader

        com.CommandText = "select * from " _
                  + " (SELECT b.id, a.itemcode, b.officeid, b.periodcode, b.monthcode, b.classcode, a.itemname,b.amount, ifnull(b.totalbudget,0) as 'totalbudget', " _
                  + " (select officename from tblcompoffice where officeid=b.officeid) As 'Office', " _
                  + " January, February, March, April, May, June, July, August, September, October, November, December, " _
                  + " (select ifnull(sum(amount),0) from tblrequisitionfund as a where b.periodcode=a.periodcode And b.itemcode=a.itemcode And b.officeid=a.officeid And a.cancelled=0) as totalused, " _
                  + " amount-(select ifnull(sum(amount),0) from tblrequisitionfund as a where b.periodcode=a.periodcode And b.itemcode=a.itemcode And b.officeid=a.officeid And b.monthcode=a.monthcode And a.cancelled=0)  as balance " _
                  + " FROM `tblglitem` as a left join tblbudgetcomposition as b on a.itemcode=b.itemcode  where b.id ='" & id.Text & "') as x " : rst = com.ExecuteReader()
        While rst.Read
            officeid = rst("officeid").ToString
            periodcode = rst("periodcode").ToString
            monthcode = rst("monthcode").ToString
            classcode = rst("classcode").ToString
            itemcode = rst("itemcode").ToString
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
            'txtVariance.EditValue = Val(rst("totaltrans").ToString) - Val(rst("totalbudget").ToString)

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

        If id.Text <> "" Then
            LoadXgrid("select date_format(concat(date_format(current_date,'%Y'),'-',monthcode,'-1'),'%M') as 'Month', itemcode as 'Item Code', " _
                      + "(select itemname from tblglitem where itemcode=a.itemcode) as 'Item Name', Original, Amount, returnfund as 'Return', requestno as 'Request No.', (select purpose from tblrequisition where pid=a.pid) as Purpose from tblrequisitionfund as a where officeid='" & officeid & "' and periodcode='" & periodcode & "' and classcode='" & classcode & "' and itemcode='" & itemcode & "' and cancelled=0", "tblrequisitionfund", Em_Requisition, gridRequisition, Me)
            XgridColAlign({"Item Code", "Class", "Month", "Request No."}, gridRequisition, DevExpress.Utils.HorzAlignment.Center)
            XgridColCurrency({"Amount", "Original", "Return"}, gridRequisition)
            XgridGeneralSummaryCurrency({"Amount", "Original", "Return"}, gridRequisition)
            gridRequisition.BestFitColumns()

            LoadXgrid("select trncode, date_format(concat(date_format(datetransfer,'%Y'),'-',monthcode,'-1'),'%M') as 'Month', " _
                     + " (select officename from tblcompoffice where officeid = a.to_officeid) as 'Transfered To', " _
                     + " to_classcode as 'Class', " _
                     + " to_itemcode as 'Item Code', " _
                     + " to_itemname as 'Item Name', " _
                     + " amounttransfer as 'Amount', " _
                     + " ifnull((select if(count(*)>0,cast(concat(count(*), ' File(s) Attached') as char),null) from " & sqlfiledir & ".tblattachmentlogs where refnumber = a.trncode and trntype='fund_trans'),'-') as 'Attachment', " _
                     + " date_format(datetransfer, '%M %d, %Y %r') as 'Date Transfered', " _
                     + " (select fullname from tblaccounts where accountid=a.transferby) as 'Transfered By' " _
                     + " from tblbudgettransferlogs as a where periodcode='" & periodcode & "' and from_officeid='" & officeid & "' and from_classcode='" & classcode & "' and from_itemcode='" & itemcode & "'", "tblbudgettransferlogs", Em_Transfered, gridTransfered, Me)
            XgridHideColumn({"trncode"}, gridTransfered)
            XgridColAlign({"Month", "Class", "Month", "Item Code", "Attachment", "Date Transfered"}, gridTransfered, DevExpress.Utils.HorzAlignment.Center)
            XgridColCurrency({"Amount"}, gridTransfered)
            XgridGeneralSummaryCurrency({"Amount"}, gridTransfered)
            gridTransfered.BestFitColumns()
        End If

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
            txtTotalBudget.ReadOnly = False
        Else
            For Each ctl In ctrl
                ctl.ReadOnly = True
                ctl.Properties.Appearance.BackColor = DefaultBackColor
            Next
            txtTotalBudget.ReadOnly = True
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

        'If Val(CC(txtVariance.Text)) > 0 Then
        '    txtVariance.Properties.Appearance.BackColor = Color.Red
        '    txtVariance.Properties.Appearance.ForeColor = Color.White
        'Else
        '    txtVariance.Properties.Appearance.BackColor = DefaultBackColor
        '    txtVariance.Properties.Appearance.ForeColor = DefaultForeColor
        'End If
    End Sub

    Private Sub Compute_EditValueChanged(sender As Object, e As EventArgs) Handles txtTotalBudget.EditValueChanged, txtJanuary.EditValueChanged, txtFebruary.EditValueChanged, txtMarch.EditValueChanged, txtApril.EditValueChanged, txtMay.EditValueChanged, txtJune.EditValueChanged, txtJuly.EditValueChanged, txtAugust.EditValueChanged, txtSeptember.EditValueChanged, txtOctober.EditValueChanged, txtNovember.EditValueChanged, txtDecember.EditValueChanged
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

                com.CommandText = "update tblbudgetcomposition set totalbudget=" & txtTotalBudget.EditValue & ", " & UpdateAmount & " january=" & txtJanuary.EditValue & ",february=" & txtFebruary.EditValue & ",march=" & txtMarch.EditValue & ",april=" & txtApril.EditValue & ",may=" & txtMay.EditValue & ",june=" & txtJune.EditValue & ",july=" & txtJuly.EditValue & ",august=" & txtAugust.EditValue & ",september=" & txtSeptember.EditValue & ",october=" & txtOctober.EditValue & ",november=" & txtNovember.EditValue & ",december=" & txtDecember.EditValue & " where id='" & id.Text & "'" : com.ExecuteNonQuery()
                UpdateEnable = False
                MonthControl()
                XtraMessageBox.Show("Figure successfully updated!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub cmdTransfer_Click(sender As Object, e As EventArgs) Handles cmdTransfer.Click
        frmFileViewer.viewonly = True
        frmFileViewer.trncode.Text = gridTransfered.GetFocusedRowCellValue("trncode").ToString()
        frmFileViewer.trntype.Text = "fund_trans"
        frmFileViewer.ShowDialog()
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        LoadBudgetInfo()
    End Sub
End Class