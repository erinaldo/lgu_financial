Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO
Imports DevExpress.XtraEditors

Public Class frmVoucherCheckInfo
    Dim oldvoucherno As String = ""
    Dim oldvoucherdate As String = ""
    Dim oldcheckno As String = ""
    Dim oldcheckbank As String = ""
    Dim oldcheckdate As String = ""

    Dim current_month_voucher As Boolean = False
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmVoucherCheckInfo_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub
    Private Sub frmVoucherCheckInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico
        ViewInfo()
    End Sub

    Public Sub ViewInfo()
        com.CommandText = "select *, (select description from tblbankaccounts where code=a.checkbank) as bank, " _
                           + "if(date_format(voucherdate,'%Y-%M') = date_format(current_date,'%Y-%M'), true, false) as current_month_voucher " _
                           + " from tbldisbursementvoucher as a where voucherid='" & id.Text & "'" : rst = com.ExecuteReader
        While rst.Read
            oldvoucherno = rst("voucherno").ToString
            oldvoucherdate = rst("voucherdate").ToString
            oldcheckno = rst("checkno").ToString
            oldcheckbank = rst("checkbank").ToString
            oldcheckdate = If(rst("checkdate").ToString = "", "", CDate(rst("checkdate").ToString))

            voucherno.Text = rst("voucherno").ToString
            txtCheckNo.Text = rst("checkno").ToString
            txtCheckBankName.Text = rst("bank").ToString
            txtAmount.Text = rst("checkamount").ToString
            txtCheckDate.Text = If(rst("checkdate").ToString = "", "", CDate(rst("checkdate").ToString))
            ckCheckIssued.Checked = rst("checkissued")
            fundcode.Text = rst("fundcode").ToString
            pid.Text = rst("pid").ToString
            current_month_voucher = CBool(rst("current_month_voucher").ToString)
        End While
        rst.Close()

        If countqry("tbldisbursementcheckhistory", "voucherid='" & id.Text & "'") > 0 Then
            Me.Size = New Size(445, 519)
            showCheckHistory()
        Else
            Me.Size = New Size(445, 265)
        End If

        If ckCheckIssued.Checked Then
            If Not current_month_voucher Then
                txtCheckNo.ReadOnly = True
                txtCheckDate.ReadOnly = True
                HyperlinkLabelControl1.Visible = True
                voucherno.Focus()
            Else
                txtCheckNo.ReadOnly = False
                txtCheckDate.ReadOnly = False
                HyperlinkLabelControl1.Visible = False
            End If
        Else
            txtCheckNo.ReadOnly = False
            txtCheckDate.ReadOnly = False
            HyperlinkLabelControl1.Visible = False
            txtCheckNo.Focus()
        End If
    End Sub
    Public Sub showCheckHistory()
        LoadXgrid("SELECT voucherno as 'Voucher No.', date_format(voucherdate,'%Y-%m-%d') as 'Date', checkno as 'Check No.', date_format(checkdate,'%Y-%m-%d') as 'Check Date'  FROM tbldisbursementcheckhistory as a " _
                        + " where voucherid='" & id.Text & "' order by voucherdate asc", "tbldisbursementcheckhistory", Em, GridView1, Me)
        XgridColAlign({"Date", "Voucher No.", "Check No.", "Check Date"}, GridView1, DevExpress.Utils.HorzAlignment.Center)
        GridView1.BestFitColumns()
    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        If txtCheckNo.Text = "" Then
            XtraMessageBox.Show("Please enter check number", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtCheckNo.Focus()
            Exit Sub
        ElseIf txtCheckBankName.Text = "" Then
            XtraMessageBox.Show("Please enter bank name", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtCheckBankName.Focus()
            Exit Sub
        ElseIf txtCheckDate.Text = "" Then
            XtraMessageBox.Show("Please select check date", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtCheckDate.Focus()
            Exit Sub
        ElseIf countqry("tbldisbursementvoucher", "checkno='" & txtCheckNo.Text & "' and voucherid<>'" & id.Text & "' and cancelled=0") > 0 Then
            XtraMessageBox.Show("Check number is already exists", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtCheckNo.Focus()
            Exit Sub
        End If
        If XtraMessageBox.Show("Are you sure you want to continue? ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then

            com.CommandText = "update tblrequisition set paid=1 where pid='" & pid.Text & "'" : com.ExecuteNonQuery()
            If ckCheckIssued.Checked = True Then
                If current_month_voucher Then
                    com.CommandText = "UPDATE tbldisbursementvoucher set  " _
                            + " checkissued=1, " _
                            + " checkno='" & txtCheckNo.Text & "', " _
                            + If(txtCheckDate.Text = "", "checkdate=null ", " checkdate='" & ConvertDate(txtCheckDate.EditValue) & "' ") _
                            + " where voucherid='" & id.Text & "'" : com.ExecuteNonQuery()
                Else
                    Dim yeartrn = CDate(txtCheckDate.EditValue).ToString("yyyy")
                    Dim vno As String = getVoucherNumber(yeartrn, fundcode.Text, "tbldisbursementvoucher")
                    voucherno.Text = fundcode.Text & "-" & yeartrn & "-" & CDate(txtCheckDate.EditValue).ToString("MM") & "-" & vno
                    seriesno.Text = vno

                    com.CommandText = "UPDATE tbldisbursementvoucher set  " _
                           + " checkissued=1, " _
                           + " voucherno='" & voucherno.Text & "', " _
                           + If(Not current_month_voucher, " voucherdate=current_date, ", "") _
                           + " seriesno='" & seriesno.Text & "', " _
                           + " checkno='" & txtCheckNo.Text & "', " _
                           + If(txtCheckDate.Text = "", "checkdate=null ", " checkdate='" & ConvertDate(txtCheckDate.EditValue) & "' ") _
                           + " where voucherid='" & id.Text & "'" : com.ExecuteNonQuery()
                End If
                com.CommandText = "insert into tbldisbursementcheckhistory set pid='" & pid.Text & "', voucherid='" & id.Text & "', voucherno='" & oldvoucherno & "', voucherdate='" & ConvertDate(CDate(oldvoucherdate)) & "', checkno='" & oldcheckno & "', checkbank='" & oldcheckbank & "', checkdate='" & ConvertDate(CDate(oldcheckdate)) & "'" : com.ExecuteNonQuery()

            Else
                Dim yeartrn = CDate(txtCheckDate.EditValue).ToString("yyyy")
                Dim vno As String = getVoucherNumber(yeartrn, fundcode.Text, "tbldisbursementvoucher")
                voucherno.Text = fundcode.Text & "-" & yeartrn & "-" & CDate(txtCheckDate.EditValue).ToString("MM") & "-" & vno
                seriesno.Text = vno

                com.CommandText = "UPDATE tbldisbursementvoucher set  " _
                             + " checkissued=1, " _
                             + " voucherno='" & voucherno.Text & "', " _
                             + If(Not current_month_voucher, " voucherdate=current_date, ", "") _
                             + " seriesno='" & seriesno.Text & "', " _
                             + " checkno='" & txtCheckNo.Text & "', " _
                             + If(txtCheckDate.Text = "", "checkdate=null ", " checkdate='" & ConvertDate(txtCheckDate.EditValue) & "' ") _
                             + " where voucherid='" & id.Text & "'" : com.ExecuteNonQuery()
            End If
            frmDisbursementList.ViewList()
            XtraMessageBox.Show("Disbursement check successfully saved", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        End If
    End Sub

    Private Sub HyperlinkLabelControl1_Click(sender As Object, e As EventArgs) Handles HyperlinkLabelControl1.Click
        If XtraMessageBox.Show("Are you you want to change current check number and date?  ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
            txtCheckNo.ReadOnly = False
            txtCheckDate.ReadOnly = False

            txtCheckNo.Text = ""
            txtCheckDate.EditValue = Nothing
        End If
    End Sub
End Class