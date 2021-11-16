Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Base

Public Class frmCollectionSearch
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            frmCollectionPosting.txtSearchBar.Focus()
            Me.Close()
        ElseIf keyData = Keys.Space Then
            If Me.txtSearchKeyword.Focus = True Then
                txtSearchKeyword.SelectAll()
                txtSearchKeyword.Focus()

            End If
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmCollectionSearch_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        frmCollectionPosting.txtSearchBar.Focus()
    End Sub


    Private Sub frmCollectionSearch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = ico
        SearchAccountTitle(txtSearchKeyword.Text)
        Em.Focus()
    End Sub

    Public Sub SearchAccountTitle(ByVal keyword As String)
        'If RemoveWhiteSpaces(keyword, True) = "" Or RemoveWhiteSpaces(keyword, True) = "%" Then Exit Sub
        Dim SearchCommand As String = " (" & SearchAdvanceCommand("itemname", RemoveWhiteSpaces(keyword, True)) & ") "

        LoadXgrid("SELECT trncode, trnname as 'Transaction Name',glitemcode as 'Item Code', (select itemname from tblglitem where itemcode=a.glitemcode)  as 'Account Title', Amount FROM tblcollectionitem as a  order by trnname asc;", "tblcollectionitem", Em, GridView1, Me)
        XgridHideColumn({"trncode", "Item Code", "Account Title"}, GridView1)
        XgridColAlign({"Item Code"}, GridView1, DevExpress.Utils.HorzAlignment.Center)
        XgridColCurrency({"Amount"}, GridView1)
        SplitContainerControl1.Panel2.Focus()
        Em.Focus()
        FocusOnItem(txtSearchKeyword.Text)
    End Sub

    Public Sub FocusOnItem(ByVal searchText As String)
        If searchText = "" Then
            GridView1.ActiveFilter.Clear()
        Else
            GridView1.ActiveFilter.Clear()
            GridView1.ActiveFilterString = "Contains([Transaction Name], '" & searchText & "')"
        End If

    End Sub

    Private Sub txtSearchKeywords_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSearchKeyword.KeyPress
        If e.KeyChar = Chr(13) Then
            SearchAccountTitle(txtSearchKeyword.Text)
        End If
    End Sub

    Private Sub PickSelectedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PickSelectedToolStripMenuItem.Click
        PickAccount(GridView1.GetFocusedRowCellValue("trncode").ToString)
    End Sub
    Private Sub Em_KeyDown(sender As Object, e As KeyEventArgs) Handles Em.KeyDown
        If e.KeyCode() = Keys.Enter Then
            PickAccount(GridView1.GetFocusedRowCellValue("trncode").ToString)
        End If
    End Sub

    Public Sub PickAccount(ByVal trncode As String)
        frmCollectionInputAmount.trncode.Text = trncode
        frmCollectionInputAmount.ShowDialog(Me)
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        SearchAccountTitle(txtSearchKeyword.Text)
    End Sub

End Class