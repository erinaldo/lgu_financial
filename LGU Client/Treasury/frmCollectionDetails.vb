Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System.Drawing
Imports System.IO
Imports System.Drawing.Printing
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Base

Public Class frmCollectionDetails
    ' The class that will do the printing process.
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmCollectionReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = ico
        ApplySystemTheme(ToolStrip3)
        ViewList()
    End Sub

    Public Sub ViewList()
        LoadXgrid("select id,jevno,formcode,fundcode,cifid,companyid,invrefcode,officeid,(select fullname from tbltaxpayerprofile where cifid=a.cifid) as 'Tax Payer', ornumber as 'OR Number', sum(credit) as Amount,(select fullname from tblaccounts where accountid=a.trnby) as 'Transaction By', date_format(datetrn, '%Y-%m-%d %r') as 'Date Transaction',Cancelled,(select fullname from tblaccounts where accountid=a.cancelledby) as 'Cancelled By' from tbltransactionentries as a where credit>0 and invrefcode='" & invrefcode.Text & "' group by jevno,ornumber order by ornumber asc", "tbltransactionentries", Em, GridView1, Me)
        XgridHideColumn({"id", "jevno", "formcode", "fundcode", "cifid", "companyid", "invrefcode", "officeid"}, GridView1)
        XgridColAlign({"Form Code", "OR Number", "Date Transaction"}, GridView1, DevExpress.Utils.HorzAlignment.Center)
        XgridColCurrency({"Amount"}, GridView1)
        XgridGeneralSummaryCurrency({"Amount"}, GridView1)
        DXgridColumnIndexing(Me.Name, GridView1)
    End Sub

    Private Sub gridview1_RowCellStyle(ByVal sender As Object, ByVal e As RowCellStyleEventArgs) Handles GridView1.RowCellStyle
        Dim View As GridView = sender
        If GridView1.RowCount > 0 Then
            Dim status As Boolean = CBool(GridView1.GetRowCellValue(e.RowHandle, "Cancelled").ToString)
            If status = True Then
                e.Appearance.ForeColor = Color.Red
                e.Appearance.Font = New Font(gen_fontfamily, gen_FontSize, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, (CByte(204)))
            End If
        End If
       
    End Sub

    Private Sub GridView1_DragObjectDrop(sender As Object, e As DevExpress.XtraGrid.Views.Base.DragObjectDropEventArgs) Handles GridView1.DragObjectDrop
        XgridColumnDropChanged(GridView1, Me.Name)
    End Sub

    Private Sub GridView1_ColumnWidthChanged(sender As Object, e As ColumnEventArgs) Handles GridView1.ColumnWidthChanged
        XgridColumnWidthChanged(GridView1, Me.Name)
    End Sub

    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub cmdExport_Click(sender As Object, e As EventArgs) Handles cmdExport.Click
        DXExportGridToExcel(Me.Text, GridView1)
    End Sub

    Private Sub cmdLocalData_Click(sender As Object, e As EventArgs) Handles cmdLocalData.Click
        ViewList()
    End Sub

    Private Sub AssignAccountableToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AssignAccountableToolStripMenuItem.Click
        If globalEnableTemporaryDisablePrinting = True Then
            XtraMessageBox.Show("Printing currently disable. please disable temporary offline printing and try again!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        If XtraMessageBox.Show("Are you sure you want to continue? ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            If GridView1.GetFocusedRowCellValue("formcode").ToString = GlobalDefaultCedulaIndividual Then
                PrintCedulaReceiptIndividual(GridView1.GetFocusedRowCellValue("OR Number").ToString, GridView1.GetFocusedRowCellValue("cifid").ToString, GridView1.GetFocusedRowCellValue("fundcode").ToString, True)
            ElseIf GridView1.GetFocusedRowCellValue("formcode").ToString = GlobalDefaultCedulaCorporate Then
                PrintCedulaReceiptCorporation(GridView1.GetFocusedRowCellValue("OR Number").ToString, GridView1.GetFocusedRowCellValue("companyid").ToString, GridView1.GetFocusedRowCellValue("fundcode").ToString, True)
            ElseIf GridView1.GetFocusedRowCellValue("formcode").ToString = GlobalDefaultCollection Then
                PrintCollectionReceipt(GridView1.GetFocusedRowCellValue("OR Number").ToString, GridView1.GetFocusedRowCellValue("cifid").ToString, GridView1.GetFocusedRowCellValue("fundcode").ToString, GridView1.GetFocusedRowCellValue("invrefcode").ToString, True)
            End If
        End If
    End Sub

    Private Sub EditTransactionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditTransactionToolStripMenuItem.Click
        If globalSpecialApprover = False And LCase(globalusername) <> "root" Then
            XtraMessageBox.Show("Your have no authority to edit. please seek assistance from accounting office!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If XtraMessageBox.Show("Are you sure you want to continue? ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            If GridView1.GetFocusedRowCellValue("formcode").ToString = GlobalDefaultCedulaIndividual Then
                frmCedulaIndividual.mode.Text = "edit"
                frmCedulaIndividual.jevid.Text = GridView1.GetFocusedRowCellValue("jevno").ToString
                frmCedulaIndividual.cifid.Text = GridView1.GetFocusedRowCellValue("cifid").ToString
                frmCedulaIndividual.formcode.Text = GridView1.GetFocusedRowCellValue("formcode").ToString
                frmCedulaIndividual.invrefcode.Text = GridView1.GetFocusedRowCellValue("invrefcode").ToString
                frmCollectionPosting.officeid.Text = GridView1.GetFocusedRowCellValue("officeid").ToString
                frmCedulaIndividual.ShowDialog(Me)
            ElseIf GridView1.GetFocusedRowCellValue("formcode").ToString = GlobalDefaultCedulaCorporate Then
                frmCedulaCorporation.mode.Text = "edit"
                frmCedulaCorporation.jevid.Text = GridView1.GetFocusedRowCellValue("jevno").ToString
                frmCedulaCorporation.companyid.Text = GridView1.GetFocusedRowCellValue("companyid").ToString
                frmCedulaCorporation.formcode.Text = GridView1.GetFocusedRowCellValue("formcode").ToString
                frmCedulaCorporation.invrefcode.Text = GridView1.GetFocusedRowCellValue("invrefcode").ToString
                frmCedulaCorporation.officeid.Text = GridView1.GetFocusedRowCellValue("officeid").ToString
                frmCedulaCorporation.ShowDialog(Me)
            ElseIf GridView1.GetFocusedRowCellValue("formcode").ToString = GlobalDefaultCollection Then
                frmCollectionPosting.mode.Text = "edit"
                frmCollectionPosting.jevid.Text = GridView1.GetFocusedRowCellValue("jevno").ToString
                frmCollectionPosting.cifid.Text = GridView1.GetFocusedRowCellValue("cifid").ToString
                frmCollectionPosting.formcode.Text = GridView1.GetFocusedRowCellValue("formcode").ToString
                frmCollectionPosting.invrefcode.Text = GridView1.GetFocusedRowCellValue("invrefcode").ToString
                frmCollectionPosting.officeid.Text = GridView1.GetFocusedRowCellValue("officeid").ToString
                frmCollectionPosting.ShowDialog(Me)
            End If
        End If
    End Sub

    Private Sub CancelTransactionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CancelTransactionToolStripMenuItem.Click
        If globalSpecialApprover = False And LCase(globalusername) <> "root" Then
            XtraMessageBox.Show("Your have no authority to cancel. please seek assistance from accounting office!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If MessageBox.Show("Are you sure you want to cancel selected transaction? ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
            If GridView1.GetFocusedRowCellValue("formcode").ToString = GlobalDefaultCedulaIndividual Then
                For I = 0 To GridView1.SelectedRowsCount - 1
                    If CBool(GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "Cancelled").ToString) = False Then
                        com.CommandText = "update tblcommunitytax set cancelled='1',cancelledby='" & globaluserid & "',datecancelled=current_timestamp where communitytaxno='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "OR Number").ToString() & "' and jevno='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "jevno").ToString() & "' " : com.ExecuteNonQuery()
                        com.CommandText = "update tbltransactionentries set cancelled='1',cancelledby='" & globaluserid & "',datecancelled=current_timestamp where ornumber='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "OR Number").ToString() & "' and jevno='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "jevno").ToString() & "' " : com.ExecuteNonQuery()
                    End If
                Next
            ElseIf GridView1.GetFocusedRowCellValue("formcode").ToString = GlobalDefaultCedulaCorporate Then
                For I = 0 To GridView1.SelectedRowsCount - 1
                    If CBool(GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "Cancelled").ToString) = False Then
                        com.CommandText = "update tblcommunitytaxcorp set cancelled='1',cancelledby='" & globaluserid & "',datecancelled=current_timestamp where communitytaxno='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "OR Number").ToString() & "' and jevno='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "jevno").ToString() & "' " : com.ExecuteNonQuery()
                        com.CommandText = "update tbltransactionentries set cancelled='1',cancelledby='" & globaluserid & "',datecancelled=current_timestamp where ornumber='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "OR Number").ToString() & "' and jevno='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "jevno").ToString() & "' " : com.ExecuteNonQuery()
                    End If
                Next
            ElseIf GridView1.GetFocusedRowCellValue("formcode").ToString = GlobalDefaultCollection Then
                For I = 0 To GridView1.SelectedRowsCount - 1
                    If CBool(GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "Cancelled").ToString) = False Then
                        com.CommandText = "update tblcollectionlist set cancelled='1',cancelledby='" & globaluserid & "',datecancelled=current_timestamp where ornumber='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "OR Number").ToString() & "' and jevno='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "jevno").ToString() & "' " : com.ExecuteNonQuery()
                        com.CommandText = "update tbltransactionentries set cancelled='1',cancelledby='" & globaluserid & "',datecancelled=current_timestamp where ornumber='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "OR Number").ToString() & "' and jevno='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "jevno").ToString() & "' " : com.ExecuteNonQuery()
                    End If
                Next
            End If
            ViewList()
        End If
    End Sub
End Class