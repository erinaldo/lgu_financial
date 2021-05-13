Imports DevExpress.XtraEditors
Imports DevExpress.Skins
Imports DevExpress.Utils
Imports DevExpress.XtraGrid.Views.Grid
Imports Microsoft.Office.Interop

Public Class frmBudgetTransferItem
    Public TransactionDone As Boolean
    Public SelectedTid As String
    Public SelectedItemCode As String
    Public SelectedItemName As String
    Public SelectedClassCode As String
    Public SelectedClassName As String

    Private Sub frmFundPeriod_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        LoadExpensesGL()
        LoadExpenditureItem()
    End Sub

    Public Sub LoadExpensesGL()
        LoadXgridLookupSearch("SELECT code, description as 'Select' from tblexpenditureclass order by description asc", "tblexpenditureclass", txtClass, gridExpenseClass, Me)
        XgridColWidth({"code"}, gridExpenseClass, 60)
        XgridColAlign({"code"}, gridExpenseClass, HorzAlignment.Center)

        XgridHideColumn({"fundcode", "yeartrn"}, gridExpenseClass)
    End Sub

    Private Sub txtExpenseClass_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtClass.EditValueChanged
        LoadExpenditureItem()
    End Sub

    Public Sub LoadExpenditureItem()
        If txtClass.Text = "" Then Exit Sub
        LoadXgrid("SELECT ifnull(b.id,'') as tid, a.itemcode, a.itemname as 'Account Title', ifnull(b.totalbudget,0) as 'Current Balance'  FROM `tblglitem` as a left join tblbudgetcomposition as b on a.itemcode=b.itemcode and b.periodcode='" & periodcode.Text & "' and b.officeid='" & officeid.Text & "'  where a.itemcode in (select glitemcode from tblexpendituretagging where expenditurecode='" & txtClass.EditValue & "') order by a.itemname asc;", "tblglitem", Em, GridView1, Me)
        XgridHideColumn({"itemcode", "tid"}, GridView1)
        XgridColCurrency({"Current Balance"}, GridView1)
        XgridColWidth({"Amount"}, GridView1, 130)
        XgridColWidth({"Account Title"}, GridView1, Em.Width - GridView1.Columns("Current Balance").Width - 20)
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

    Private Sub cmdSaveButton_Click(sender As Object, e As EventArgs) Handles cmdSaveButton.Click
        TransactionDone = True
        SelectedTid = GridView1.GetFocusedRowCellValue("tid").ToString()
        SelectedItemCode = GridView1.GetFocusedRowCellValue("itemcode").ToString()
        SelectedItemName = GridView1.GetFocusedRowCellValue("Account Title").ToString()
        SelectedClassCode = txtClass.EditValue
        SelectedClassName = txtClass.Text
        Me.Close()
    End Sub

    Private Sub Em_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Em.KeyPress
        If e.KeyChar = Chr(13) Then
            cmdSaveButton.PerformClick()
        End If
    End Sub

    Private Sub officeid_EditValueChanged(sender As Object, e As EventArgs) Handles officeid.EditValueChanged
        LoadExpenditureItem()
    End Sub
End Class