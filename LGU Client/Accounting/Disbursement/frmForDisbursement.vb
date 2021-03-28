Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO
Imports DevExpress.XtraEditors

Public Class frmForDisbursement
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmSelectRequestItem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = ico
        filterItem()
        txtSearchBar.Focus()
    End Sub

    Public Sub filterItem()
        Dim KeyWordSearch As String = ""
        KeyWordSearch = " and (requestno like '%" & rchar(txtSearchBar.Text) & "%' or " _
                        + " postingdate like '%" & rchar(txtSearchBar.Text) & "%' or " _
                        + " (select description from tblrequisitiontype where code=a.requesttype) like '%" & rchar(txtSearchBar.Text) & "%' or " _
                        + " (select description from tblrequisitiontype where code=a.requesttype) like '%" & rchar(txtSearchBar.Text) & "%' or " _
                        + " Purpose like '%" & rchar(txtSearchBar.Text) & "%')"

        LoadXgrid("SELECT pid as 'Entry Code', if(cancelled,'CANCELLED',if(approved,'APPROVED',if(draft,'DRAFT',if(hold,'HOLD',if(forapproval,'FOR APPROVAL','-'))))) as Status, " _
                        + " requestno as 'Request No.', " _
                        + " (select description from tblrequisitiontype where code=a.requesttype) as 'Request Type' ," _
                        + " concat((select codename from tblfund where code=a.fundcode),'-',yeartrn) as 'Fund Period',  " _
                        + " date_format(postingdate,'%Y-%m-%d') as 'Posting Date', " _
                        + " (select officename from tblcompoffice where officeid = a.officeid) as 'Office', " _
                        + " (select fullname from tblaccounts where accountid=a.requestedby) as 'Requested By', " _
                        + " (select itemname from tblglitem where itemcode=a.sourcefund) as 'Source Fund', " _
                        + " (select sum(amount) from tblrequisitionfund where pid=a.pid) as 'Total Amount', " _
                        + " Purpose, " _
                        + " Priority, " _
                        + " (select fullname from tblaccounts where accountid=a.trnby) as 'Posted By', " _
                        + " date_format(datetrn,'%Y-%m-%d') as 'Date Posted', " _
                        + " Approved, date_format(dateapproved,'%Y-%m-%d') as 'Date Approved' " _
                        + " FROM tblrequisition as a " _
                        + " where approved=1 and cancelled=0" _
                        + KeyWordSearch _
                        + " order by requestno asc", "tblrequisition", Em, GridView1, Me)

        XgridColCurrency({"Total Amount"}, GridView1)
        XgridColAlign({"Entry Code", "Status", "Fund Period", "Request Type", "Posting Date", "Date Posted", "Draft", "ForApproval", "Hold", "Approved", "Date Approved", "Cancelled", "Date Cancelled"}, GridView1, DevExpress.Utils.HorzAlignment.Center)
        XgridGeneralSummaryCurrency({"Total Amount"}, GridView1)

        DXgridColumnIndexing(Me.Name, GridView1)
        GridView1.BestFitColumns()
        XgridColWidth({"Purpose"}, GridView1, 300)
        XgridColMemo({"Purpose"}, GridView1)
        SaveFilterColumn(GridView1, Me.Text)
    End Sub

    Private Sub SelectItemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectItemToolStripMenuItem.Click
        'com.CommandText = "select *,ifnull((select supplierid from tblpurchaseorder where pid=a.pid),'') as supplierid, " _
        '                        + " (select itemname from tblglitem where itemcode=a.sourcefund) as itemname, " _
        '                        + " (select sum(totalcost) from tblrequisitionitem where pid=a.pid) as amount, " _
        '                        + " ifnull((select sum(totalcost) from tblrequisitionitem where pid=a.pid),0) - ifnull((select sum(voucheramount) from tbldisbursementvoucher where pid=a.pid and cancelled=0),0) as balance from tblrequisition as a where pid='" & GridView1.GetFocusedRowCellValue("Entry Code").ToString() & "'" : rst = com.ExecuteReader()
        'While rst.Read
        '    frmVoucherInfo.sourcefund.Text = rst("sourcefund").ToString
        '    frmVoucherInfo.txtApprovedAmount.EditValue = rst("amount").ToString
        '    frmVoucherInfo.txtBalanceAmount.EditValue = rst("balance").ToString
        '    frmVoucherInfo.txtSourceofFund.Text = rst("itemname").ToString
        'End While
        'rst.Close()

    End Sub

    Private Sub ToolStripMenuItem5_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem5.Click
        filterItem()
    End Sub

    Private Sub Em_KeyDown(sender As Object, e As KeyEventArgs) Handles Em.KeyDown
        If e.KeyCode() = Keys.Enter Then
            SelectItemToolStripMenuItem.PerformClick()
        End If
    End Sub

    Private Sub txtfilter_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSearchBar.KeyPress
        If e.KeyChar() = Chr(13) Then
            filterItem()
        End If
    End Sub
End Class