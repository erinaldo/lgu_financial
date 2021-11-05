Imports DevExpress.XtraEditors
Imports DevExpress.Skins
Imports DevExpress.Utils
Imports DevExpress.XtraGrid.Views.Grid
Imports Microsoft.Office.Interop

Public Class frmBudgetComposition
    Public DataBook As Excel.Workbook
    Public DS_ChartOfAccount As Excel.Worksheet

    Private Sub frmFundPeriod_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        LoadFund()
        LoadOffice()
        LoadExpensesGL()
        PermissionAccess({cmdImport, cmdSave}, globalAdminAccess)
    End Sub

    Public Sub LoadFund()
        LoadXgridLookupSearch("SELECT periodcode as code,fundcode,yeartrn, concat(yeartrn,'-',(select Description from tblfund where code=tblfundperiod.fundcode)) as 'Select'  from tblfundperiod where closed=0 order by yeartrn asc", "tblfundperiod", txtFund, gridFund, Me)
        XgridHideColumn({"code", "fundcode", "yeartrn"}, gridFund)
    End Sub
    Private Sub txtFund_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFund.EditValueChanged
        On Error Resume Next
        periodcode.Text = txtFund.Properties.View.GetFocusedRowCellValue("code").ToString()
        fundcode.Text = txtFund.Properties.View.GetFocusedRowCellValue("fundcode").ToString()
        yearcode.Text = txtFund.Properties.View.GetFocusedRowCellValue("yeartrn").ToString()
        LoadExpenditureItem()
    End Sub

    Public Sub LoadOffice()
        LoadXgridLookupSearch("SELECT officeid as code, officename as 'Select'  from tblcompoffice where deleted=0 order by officename asc", "tblcompoffice", txtOffice, gridoffice, Me)
        XgridHideColumn({"code"}, gridoffice)
    End Sub

    Private Sub txtOffice_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtOffice.EditValueChanged
        On Error Resume Next
        officeid.Text = txtOffice.Properties.View.GetFocusedRowCellValue("code").ToString()
        LoadExpenditureItem()
    End Sub

    Public Sub LoadExpensesGL()
        LoadXgridLookupSearch("SELECT Code, description as 'Select' from tblexpenditureclass order by description asc", "tblexpenditureclass", txtExpenseClass, gridExpenseClass, Me)
        XgridColWidth({"Code"}, gridExpenseClass, 60)
        XgridColAlign({"Code"}, gridExpenseClass, HorzAlignment.Center)

        XgridHideColumn({"fundcode", "yeartrn"}, gridExpenseClass)
    End Sub

    Private Sub txtExpenseClass_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtExpenseClass.EditValueChanged
        On Error Resume Next
        expensecode.Text = txtExpenseClass.Properties.View.GetFocusedRowCellValue("Code").ToString()
        LoadExpenditureItem()
    End Sub

    Public Sub LoadExpenditureItem()
        If txtExpenseClass.Text = "" Or txtFund.Text = "" Or txtOffice.Text = "" Then Exit Sub
        LoadXgrid("SELECT a.itemcode, a.itemname as 'Account Title', ifnull(b.totalbudget,0) as Amount  FROM `tblglitem` as a left join tblbudgetcomposition as b on a.itemcode=b.itemcode and b.periodcode='" & periodcode.Text & "' and b.officeid='" & officeid.Text & "'  where a.itemcode in (select glitemcode from tblexpendituretagging where expenditurecode='" & expensecode.Text & "') order by a.itemname asc;", "tblglitem", Em, GridView1, Me)
        XgridHideColumn({"itemcode"}, GridView1)
        XgridColCurrency({"Amount"}, GridView1)
        XgridColWidth({"Amount"}, GridView1, 130)
        XgridColWidth({"Account Title"}, GridView1, Em.Width - GridView1.Columns("Amount").Width - 20)
        XgridDisableColumn({"Account Title", "itemcode"}, GridView1, False)
        XgridGeneralSummaryCurrency({"Amount"}, GridView1)
        For Each col In GridView1.Columns
            col.OptionsColumn.AllowSort = DefaultBoolean.False
        Next

    End Sub

    Private Sub gridview1_RowCellStyle(ByVal sender As Object, ByVal e As RowCellStyleEventArgs) Handles GridView1.RowCellStyle
        Dim View As GridView = sender
        If e.Column.Name = "colAccountTitle" Then
            e.Appearance.ForeColor = Color.Black
            e.Appearance.BackColor = Color.LightYellow
            e.Appearance.BackColor2 = Color.LightYellow
        End If

    End Sub

    Private Sub cmdSaveButton_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        If txtFund.Text = "" Then
            XtraMessageBox.Show("Budget select fund period!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtFund.Focus()
            Exit Sub
        ElseIf txtOffice.Text = "" Then
            XtraMessageBox.Show("Budget select office!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtOffice.Focus()
            Exit Sub
        ElseIf txtExpenseClass.Text = "" Then
            XtraMessageBox.Show("Budget select expenditure class!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtExpenseClass.Focus()
            Exit Sub
            'ElseIf countqry("tblbudgetquarter", "fundperiod='" & periodcode.Text & "'") > 0 Then
            '    XtraMessageBox.Show("Budget composition is already locked due to already generate quarterly budget", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            '    Exit Sub
        End If
        If XtraMessageBox.Show("Are you sure you want to continue? " & todelete, "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            SaveBudgetSetup()
            MessageBox.Show("Budget Successfuly Saved", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Public Sub SaveBudgetSetup()
        com.CommandText = "delete from tblbudgetcomposition where periodcode='" & periodcode.Text & "' and officeid='" & officeid.Text & "' and classcode='" & expensecode.Text & "'" : com.ExecuteNonQuery()
        For I = 0 To GridView1.RowCount - 1
            com.CommandText = "insert into tblbudgetcomposition set periodcode='" & periodcode.Text & "', fundcode='" & fundcode.Text & "',yearcode='" & yearcode.Text & "', officeid='" & officeid.Text & "',classcode='" & expensecode.Text & "', itemcode='" & GridView1.GetRowCellValue(I, "itemcode").ToString & "',itemname='" & rchar(GridView1.GetRowCellValue(I, "Account Title").ToString) & "', totalbudget='" & Val(CC(GridView1.GetRowCellValue(I, "Amount").ToString)) & "'" : com.ExecuteNonQuery()
        Next
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        If txtFund.Text = "" Then
            XtraMessageBox.Show("Budget select fund period!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtFund.Focus()
            Exit Sub
        ElseIf txtOffice.Text = "" Then
            XtraMessageBox.Show("Budget select office!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtOffice.Focus()
            Exit Sub
        ElseIf txtExpenseClass.Text = "" Then
            XtraMessageBox.Show("Budget select expenditure class!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtExpenseClass.Focus()
            Exit Sub
        End If
        LoadXgrid("SELECT a.itemcode, a.itemname, ifnull(b.totalbudget,0) as amount  FROM `tblglitem` as a left join tblbudgetcomposition as b on a.itemcode=b.itemcode and b.periodcode='" & periodcode.Text & "' and b.officeid='" & officeid.Text & "'  where a.itemcode in (select glitemcode from tblexpendituretagging where expenditurecode='" & expensecode.Text & "') order by a.itemname asc;", "tblglitem", Bm, GridView2, Me)
        ExportGridToExcel(txtFund.Text & " " & expensecode.Text & " " & Me.Text, GridView2)

    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles cmdImport.Click
        If txtFund.Text = "" Then
            XtraMessageBox.Show("Budget select fund period!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtFund.Focus()
            Exit Sub
        ElseIf txtOffice.Text = "" Then
            XtraMessageBox.Show("Budget select office!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtOffice.Focus()
            Exit Sub
        ElseIf txtExpenseClass.Text = "" Then
            XtraMessageBox.Show("Budget select expenditure class!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtExpenseClass.Focus()
            Exit Sub
        End If
        Try

            Dim objOpenFileDialog As New OpenFileDialog
            With objOpenFileDialog
                .Filter = "Excell files (*.xlsx)|*.xlsx|All files (*.*)|*.*"
                .FilterIndex = 1
                .Title = "Open File Dialog"
            End With

            If objOpenFileDialog.ShowDialog = System.Windows.Forms.DialogResult.OK Then
                '= objOpenFileDialog.FileName

                Dim CompleteQuery As String = ""
                Dim Cell As Excel.Range
                Dim ExcelApp As New Excel.Application
                DataBook = ExcelApp.Workbooks.Open(objOpenFileDialog.FileName)
                DS_ChartOfAccount = DataBook.Worksheets("Sheet")
                'START ITEM CAPTURE

                Dim arrayItem() As String = {"A", "B", "C"}
                For R = 2 To GetLastItemRow(objOpenFileDialog.FileName)
                    Dim coulumnCount As Integer = 0
                    Dim itemcode As String = "" : Dim itemname As String = "" : Dim amount As Double = 0
                    For Each valueArr As String In arrayItem
                        For Each Cell In DS_ChartOfAccount.Range(valueArr & R)
                            Dim value_x As String = ""
                            value_x = System.Convert.ToString(Cell.Cells.Value2)
                            If coulumnCount = 0 Then
                                itemcode = value_x
                            ElseIf coulumnCount = 1 Then
                                itemname = value_x
                            ElseIf coulumnCount = 2 Then
                                amount = If(value_x = "", 0, Val(CC(value_x)))
                            End If
                            coulumnCount = coulumnCount + 1
                        Next
                    Next

                    For I = 0 To GridView1.RowCount - 1
                        If GridView1.GetRowCellValue(I, "itemcode") = itemcode Then
                            GridView1.SetRowCellValue(I, "Amount", Val(amount))
                        End If
                    Next
                Next
                DataBook.Close(False)
                ExcelApp.Quit()

            End If
            objOpenFileDialog.Dispose()
            objOpenFileDialog = Nothing

        Catch fileException As Exception
            MsgBox(fileException.Message)
        End Try
    End Sub

    Public Function GetLastItemRow(ByVal location As String) As Long
        Dim xlApp As New Excel.Application
        Dim xlWb As Excel.Workbook
        Dim xlsheet As Excel.Worksheet
        GetLastItemRow = 0
        With xlApp
            .Visible = False
            xlWb = .Workbooks.Open(location)
            xlsheet = xlWb.Sheets("Sheet")
            With xlsheet
                GetLastItemRow = .Range("A" & .Rows.Count).End(Excel.XlDirection.xlUp).Row
            End With
            xlWb.Close(False)
            xlApp.Quit()
        End With
        Return GetLastItemRow
    End Function
End Class