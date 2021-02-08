Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmJournalEntryExpenditure

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
        LoadItem()
        PopulateGridViewControls("Select", 20, "CHECKBOX", dgv, True, False)
        PopulateGridViewControls("Item Code", 50, "", dgv, True, True)
        PopulateGridViewControls("Item Name", 50, "", dgv, True, True)
        PopulateGridViewControls("Amount", 30, "", dgv, True, True)
        PopulateGridViewControls("officeid", 50, "", dgv, False, True)
        LoadRequisition()
    End Sub


    Public Sub LoadItem()
        If globalSpecialApprover = True Or globalRootUser = True Then
            LoadXgridLookupSearch("select if(sl=1,itemcode,'') as itemcode,  if(sl=1,itemname,'') as itemname, " & GlobalGLitemname & " as 'Item Name', if(a.sl=1,1,0) as sl from tblglitem as a ", "tblglitem", txtItem, gridItem)
        Else
            LoadXgridLookupSearch("select if(sl=1,itemcode,'') as itemcode,  if(sl=1,itemname,'') as itemname, " & GlobalGLitemname & " as 'Item Name', if(a.sl=1,1,0) as sl from tblglitem as a where (gl=1 or glgroup=1 or itemcode in (select itemcode from tblglaccountfilter where permissioncode='" & globalpermissioncode & "')) ", "tblglitem", txtItem, gridItem)
        End If

        XgridHideColumn({"itemcode", "itemname", "debit", "sl"}, gridItem)
    End Sub

    Private Sub gridItem_RowCellStyle(ByVal sender As Object, ByVal e As RowCellStyleEventArgs) Handles gridItem.RowCellStyle
        Dim View As GridView = sender
        Dim sl As Boolean = CBool(View.GetRowCellDisplayText(e.RowHandle, View.Columns("sl")))
        If sl = False Then
            e.Appearance.BackColor = Color.LightYellow
            e.Appearance.ForeColor = Color.Black
            e.Appearance.Font = New Font(e.Appearance.Font.FontFamily, e.Appearance.Font.Size, FontStyle.Bold)
        End If
    End Sub

    Public Sub LoadRequisition()
        dgv.Rows.Clear()
        dst = Nothing : dst = New DataSet
        msda = New MySqlDataAdapter("select itemcode, officeid, (select itemname from tblglitem where itemcode=a.itemcode) as 'itemname', Amount from tblrequisitionfund as a where pid in (select pid from tbldisbursementdetails where voucherno='" & voucherno.Text & "') order by  a.itemcode asc ", conn)

        msda.Fill(dst, 0)
        For cnt = 0 To dst.Tables(0).Rows.Count - 1
            With (dst.Tables(0))
                dgv.Rows.Add(False, .Rows(cnt)("itemcode").ToString(),
                                                 .Rows(cnt)("itemname").ToString(),
                                                  Val(.Rows(cnt)("Amount").ToString()),
                                                 .Rows(cnt)("officeid").ToString())
            End With
        Next

        GridCurrencyColumn(dgv, {"Amount"})
        GridColumnWidth(dgv, {"Amount"}, 100)
        GridColumnAlignment(dgv, {"Item Code"}, DataGridViewContentAlignment.MiddleCenter)
        GridColumAutoWidth(dgv, {"Select", "Item Code", "Center", "Item Name"})
    End Sub


    Private Sub cmdOk_Click(sender As Object, e As EventArgs) Handles cmdOk.Click
        If txtItem.Text = "" Then
            XtraMessageBox.Show("Please select item name!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtItem.Focus()
            Exit Sub
        End If
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
                    com.CommandText = "insert into tbljournalentryitem set jevno='" & If(jevno.Text = "", globaluserid & "-temp", jevno.Text) & "', " _
                         + " fundcode='" & frmJournalEntry.fundcode.Text & "', " _
                         + " periodcode='" & frmJournalEntry.periodcode.Text & "', " _
                         + " yeartrn='" & frmJournalEntry.yeartrn.Text & "', " _
                         + " postingdate='" & ConvertDate(frmJournalEntry.txtJournalDate.EditValue) & "', " _
                         + " centercode='" & dgv.Item("officeid", I).Value & "', " _
                         + " tagclass=1, " _
                         + " classcode='" & dgv.Item("Item Code", I).Value & "', " _
                         + " itemcode='" & txtItem.EditValue & "', " _
                         + " itemname='" & rchar(txtItem.Text) & "', " _
                         + " checkno='', " _
                         + " debit='" & Val(CC(dgv.Item("Amount", I).Value)) & "', " _
                         + " credit='0'  " : com.ExecuteNonQuery()
                End If
            Next
            If frmJournalEntry.Visible = True Then
                frmJournalEntry.LoadAccountTitle()
            End If
            Me.Close()
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

End Class