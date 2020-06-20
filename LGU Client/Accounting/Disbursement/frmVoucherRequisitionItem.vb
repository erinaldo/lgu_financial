Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO
Imports DevExpress.XtraEditors

Public Class frmVoucherRequisitionItem
    Delegate Sub Execute_Delegate()
    Private Sub Execute_ThreadSafe()
        If Me.InvokeRequired Then
            Dim MyDelegate As New Execute_Delegate(AddressOf Execute_ThreadSafe)
            Me.Invoke(MyDelegate)
        Else
            LoadRequisition()
        End If
    End Sub

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmVoucherPOSelect_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub frmClientInfo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = ico
        PopulateGridViewControls("Select", 20, "CHECKBOX", dgv, True, False)
        PopulateGridViewControls("Entry Code", 50, "", dgv, True, True)
        PopulateGridViewControls("Request No", 50, "", dgv, True, True)
        PopulateGridViewControls("Request Type", 50, "", dgv, True, True)
        PopulateGridViewControls("Office", 50, "", dgv, True, True)
        PopulateGridViewControls("Current Balance", 40, "", dgv, True, True)
        PopulateGridViewControls("Total", 30, "", dgv, True, True)
        PopulateGridViewControls("Payment", 10, "", dgv, True, False)
        PopulateGridViewControls("New Balance", 10, "", dgv, True, True)
        PopulateGridViewControls("Posting Date", 10, "", dgv, True, True)
        PopulateGridViewControls("Date Approved", 10, "", dgv, True, True)
        PopulateGridViewControls("Purpose", 50, "", dgv, True, False)
        PopulateGridViewControls("requesttype", 50, "", dgv, False, True)
        PopulateGridViewControls("officeid", 50, "", dgv, False, True)
        LoadRequisition()
    End Sub

    Public Sub LoadRequisition()
        dgv.Rows.Clear()
        dst = Nothing : dst = New DataSet
        msda = New MySqlDataAdapter("select *,ifnull((select sum(amount) from tbldisbursementdetails where pid=a.pid and cancelled=0),0) as payment, " _
                                    + " (select description from tblrequisitiontype where code=a.requesttype) as request_type, " _
                                    + " (select officename from tblcompoffice where officeid=a.officeid) as office, " _
                                    + " date_format(postingdate,'%Y-%m-%d') as 'PostingDate', " _
                                    + " date_format(dateapproved,'%Y-%m-%d') as 'DateApproved', " _
                                    + " (select sum(totalcost) from tblrequisitionitem where pid=a.pid) as TotalAmount " _
                                    + " from tblrequisition as a where approved=1 and paid=0 and cancelled=0 " & If(compAccountingOffice = True, "", " and officeid='" & compOfficeid & "'") & " " _
                                    + " and (pid like '%" & txtSearch.Text & "%' or " _
                                    + " (select officename from tblcompoffice where officeid=a.officeid) like '%" & txtSearch.Text & "%' or " _
                                    + " requestno like '%" & txtSearch.Text & "%') order by postingdate desc", conn)

        msda.Fill(dst, 0)
        For cnt = 0 To dst.Tables(0).Rows.Count - 1
            With (dst.Tables(0))
                dgv.Rows.Add(False, .Rows(cnt)("pid").ToString(), _
                                                 .Rows(cnt)("requestno").ToString(), _
                                                 .Rows(cnt)("request_type").ToString(), _
                                                 .Rows(cnt)("office").ToString(), _
                                                 Val(.Rows(cnt)("TotalAmount").ToString()) - Val(.Rows(cnt)("payment").ToString()), _
                                                 Val(.Rows(cnt)("TotalAmount").ToString()) - Val(.Rows(cnt)("payment").ToString()), _
                                                 Val(.Rows(cnt)("TotalAmount").ToString()) - Val(.Rows(cnt)("payment").ToString()), _
                                                 0, _
                                                 .Rows(cnt)("PostingDate").ToString(), _
                                                 .Rows(cnt)("DateApproved").ToString(), _
                                                 .Rows(cnt)("purpose").ToString(),
                                                 .Rows(cnt)("requesttype").ToString(),
                                                 .Rows(cnt)("officeid").ToString())
            End With
        Next

        GridCurrencyColumn(dgv, {"Current Balance", "Total", "Payment", "New Balance"})
        GridColumnWidth(dgv, {"Current Balance", "Total", "Payment", "New Balance"}, 100)
        GridColumnAlignment(dgv, {"Entry Code", "Request No", "Date Approved"}, DataGridViewContentAlignment.MiddleCenter)
        GridColumAutoWidth(dgv, {"Select", "Entry Code", "Request No", "Request Type", "Office", "Posting Date", "Date Approved", "Purpose"})
    End Sub


    Private Sub cmdOk_Click(sender As Object, e As EventArgs) Handles cmdOk.Click
        Dim Selected As Boolean = False
        For I = 0 To dgv.RowCount - 1
            If DirectCast(dgv.Rows(I).Cells("Select"), DataGridViewCheckBoxCell).Value = 1 Then
                Selected = True
            End If
        Next
        If Selected = False Then
            MessageBox.Show("No item selected", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        If XtraMessageBox.Show("Are you sure you want to continue?", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            For I = 0 To dgv.RowCount - 1
                If DirectCast(dgv.Rows(I).Cells("Select"), DataGridViewCheckBoxCell).Value = 1 Then
                    If Val(CC(dgv.Item("New Balance", I).Value)) > 0 Then
                        com.CommandText = "UPDATE tblrequisition set paid=0 where pid='" & dgv.Item("Entry Code", I).Value & "'" : com.ExecuteNonQuery()
                    Else
                        com.CommandText = "UPDATE tblrequisition set paid=1 where pid='" & dgv.Item("Entry Code", I).Value & "'" : com.ExecuteNonQuery()
                    End If
                    com.CommandText = "insert into tbldisbursementdetails set voucherno='" & voucherno.Text & "', pid='" & dgv.Item("Entry Code", I).Value & "', officeid='" & dgv.Item("officeid", I).Value & "', requestno='" & dgv.Item("Request No", I).Value & "',requesttype='" & dgv.Item("requesttype", I).Value & "',postingdate='" & ConvertDate(dgv.Item("Posting Date", I).Value) & "',  purpose='" & rchar(dgv.Item("Purpose", I).Value) & "', amount='" & Val(CC(dgv.Item("Payment", I).Value)) & "'" : com.ExecuteNonQuery()
                End If
            Next
            LoadRequisition()
            frmVoucherInfo.LoadVoucherExpenses()
        End If
    End Sub

    Private Sub CellValueChanged(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgv.CellValueChanged
        Dim gv As DataGridView = DirectCast(sender, DataGridView)
        Dim originalamount As Double = If(gv("Current Balance", e.RowIndex).Value.ToString = "", 0, Val(CC(gv("Current Balance", e.RowIndex).Value)))
        
        If e.ColumnIndex = 7 Then ' enter payment amount
            Dim Total As Double = If(gv("Total", e.RowIndex).Value.ToString = "", 0, Val(CC(gv("Total", e.RowIndex).Value)))
            Dim Tenderamount As Double = If(gv("Payment", e.RowIndex).Value.ToString = "", 0, Val(CC(gv("Payment", e.RowIndex).Value)))
            Dim totalBalance As Double = Total - Tenderamount
            gv("New Balance", e.RowIndex).Value = totalBalance
            If totalBalance < 0 Then
                gv("New Balance", e.RowIndex).Style.BackColor = Color.Red
                gv("New Balance", e.RowIndex).Style.SelectionBackColor = Color.Red
                gv("New Balance", e.RowIndex).Style.ForeColor = Color.White
                gv("New Balance", e.RowIndex).Style.SelectionForeColor = Color.White
            Else
                gv("New Balance", e.RowIndex).Style.BackColor = Color.LemonChiffon
                gv("New Balance", e.RowIndex).Style.SelectionBackColor = Color.LemonChiffon
                gv("New Balance", e.RowIndex).Style.ForeColor = Color.Black
                gv("New Balance", e.RowIndex).Style.SelectionForeColor = Color.Black
            End If
        End If

    End Sub

    Private Sub dgv_DataError(ByVal sender As Object, ByVal e As DataGridViewDataErrorEventArgs) Handles dgv.DataError

    End Sub

    Private Sub MyDataGridView_room_CellMouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgv.CellMouseDown
        On Error Resume Next
        If e.ColumnIndex >= 0 And e.RowIndex >= 0 Then
            Me.dgv.CurrentCell = Me.dgv.Rows(e.RowIndex).Cells(e.ColumnIndex)
        End If
    End Sub

    Private Sub txtSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSearch.KeyPress
        If e.KeyChar() = Chr(13) Then
            If txtSearch.Text = "" Then Exit Sub
            LoadRequisition()
        End If
    End Sub

    Private Sub CheckEdit1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckEdit1.CheckedChanged
        If CheckEdit1.Checked = True Then
            For x = 0 To dgv.RowCount - 1
                DirectCast(dgv.Rows(x).Cells("Select"), DataGridViewCheckBoxCell).Value = 1
            Next
        Else
            For x = 0 To dgv.RowCount - 1
                DirectCast(dgv.Rows(x).Cells("Select"), DataGridViewCheckBoxCell).Value = 0
            Next
        End If
    End Sub
 
    Private Sub txtfilter_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSearch.KeyPress
        If e.KeyChar() = Chr(13) Then
            LoadRequisition()
        End If
    End Sub
End Class