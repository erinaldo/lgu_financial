Imports DevExpress.XtraEditors
Imports DevExpress.Skins
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmCashFlowItem
    Private Sub frmCashFlowItem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        filter()
        LoadCashFlowItem()
        ShowUnfilteredClient()
        ShowfilteredClients()
    End Sub

#Region "CashFlowInfo"
    Public Sub filter()
        LoadXgrid("Select Code, CashFlowName from tblcashflowitem as a order by CashFlowName asc", "tblcashflowitem", Em, GridView1, Me)
        XgridColAlign({"Code"}, GridView1, DevExpress.Utils.HorzAlignment.Center)
        GridView1.BestFitColumns()
    End Sub

    Private Sub cmdSaveButton_Click(sender As Object, e As EventArgs) Handles cmdSaveButton.Click
        If countqry("tblcashflowitem", "code='" & code.Text & "'") > 0 And mode.Text <> "edit" Then
            XtraMessageBox.Show("Code already exists!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            code.Focus()
            Exit Sub
        ElseIf txtCashFlowName.Text = "" Then
            XtraMessageBox.Show("Please enter cash flow name!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtCashFlowName.Focus()
            Exit Sub

        End If
        If mode.Text = "edit" Then
            com.CommandText = "update tblcashflowitem set CashFlowName='" & rchar(txtCashFlowName.Text) & "' where code='" & code.Text & "'" : com.ExecuteNonQuery()
        Else
            com.CommandText = "insert into tblcashflowitem set  code='" & code.Text & "', CashFlowName='" & rchar(txtCashFlowName.Text) & "'" : com.ExecuteNonQuery()
        End If
        code.Text = "" : mode.Text = "" : txtCashFlowName.Text = "" : txtCashFlowName.Text = "" : txtCashFlowName.Focus() : filter() : code.Enabled = True
        XtraMessageBox.Show("Cash flow item successfully saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Public Sub showInfo()
        If code.Text = "" Then Exit Sub
        com.CommandText = "select * from tblcashflowitem where code='" & code.Text & "'" : rst = com.ExecuteReader
        While rst.Read
            txtCashFlowName.Text = rst("CashFlowName").ToString
        End While
        rst.Close()
    End Sub

    Private Sub cmdEdit_Click(sender As Object, e As EventArgs) Handles cmdEdit.Click
        mode.Text = "" : code.Enabled = False
        code.Text = GridView1.GetFocusedRowCellValue("Code").ToString
        mode.Text = "edit"
        showInfo()
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        filter()
    End Sub

    Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
        If XtraMessageBox.Show("Are you sure you want to permanently remove selected item? ", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            Dim I As Integer = 0
            For I = 0 To GridView1.SelectedRowsCount - 1
                com.CommandText = "delete from tblcashflowitem where code='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "Code") & "' " : com.ExecuteNonQuery()
            Next
            filter()
        End If
    End Sub
#End Region


#Region "Cashflow Tagging"
    Private Sub XtraTabControl1_SelectedPageChanged(sender As Object, e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles XtraTabControl1.SelectedPageChanged
        LoadCashFlowItem()
    End Sub

    Public Sub LoadCashFlowItem()
        LoadXgridLookupEdit("select code, cashflowname as 'Cash Flow Name' from tblcashflowitem order by cashflowname asc", "tblcashflowitem", txtTagCashFlowName, gridTagCashFlowName, Me)
        gridTagCashFlowName.Columns("code").Visible = False
    End Sub

    Private Sub txtTagCashFlowName_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTagCashFlowName.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtTagCashFlowName.Properties.View.FocusedRowHandle.ToString)
        cashflowcode.Text = txtTagCashFlowName.Properties.View.GetFocusedRowCellValue("code").ToString()
        ShowUnfilteredClient()
        ShowfilteredClients()
    End Sub

    Public Sub ShowUnfilteredClient()
        Dim cifquery As String = ""
        com.CommandText = "select glitemcode from tblcashflowtagging where cashflowcode='" & cashflowcode.Text & "'" : rst = com.ExecuteReader
        While rst.Read
            cifquery = cifquery + "'" & rst("glitemcode").ToString & "',"
        End While
        rst.Close()
        If cifquery.Length > 0 Then
            cifquery = cifquery.Remove(cifquery.Length - 1, 1)
            cifquery = " where itemcode not in(" & cifquery & ")"
        End If
        If cashflowcode.Text <> "" Then
            LoadXgrid("select if(sl=1,itemcode,'') as itemcode,  if(sl=1,itemname,'') as itemname, " & GlobalGLitemname & " as 'Account Title', debitentry,if(a.sl=1,1,0) as sl from tblglitem as a " & cifquery & "", "tblglitem", Em_unfiltered, gridUnFiltered, Me)
            gridUnFiltered.Columns("itemcode").Visible = False
            XgridColMemo({"Account Title"}, gridUnFiltered)
            XgridColWidth({"Account Title"}, gridUnFiltered, Em_unfiltered.Width)

            XgridHideColumn({"itemcode", "itemname", "debitentry", "sl"}, gridUnFiltered)
            RemoveHandler gridUnFiltered.RowCellStyle, New RowCellStyleEventHandler(AddressOf GridRowCellStyle)
            AddHandler gridUnFiltered.RowCellStyle, New RowCellStyleEventHandler(AddressOf GridRowCellStyle)
        End If
    End Sub

    Private Sub GridRowCellStyle(ByVal sender As Object, ByVal e As RowCellStyleEventArgs)
        Dim View As GridView = sender
        Dim sl As Boolean = CBool(View.GetRowCellDisplayText(e.RowHandle, View.Columns("sl")))
        If sl = False Then
            'e.Appearance.BackColor = Color.LightYellow
            'e.Appearance.ForeColor = Color.Black
            e.Appearance.Font = New Font(e.Appearance.Font.FontFamily, e.Appearance.Font.Size, FontStyle.Bold)
        End If
    End Sub


    Public Sub ShowfilteredClients()
        If cashflowcode.Text <> "" Then
            LoadXgrid("select glitemcode, (select itemname from tblglitem where itemcode= tblcashflowtagging.glitemcode) as 'Account Title' from tblcashflowtagging where cashflowcode='" & cashflowcode.Text & "' order by (select itemname from tblglitem where itemcode= tblcashflowtagging.glitemcode)  asc", "tblcashflowtagging", Em_filtered, gridFiltered, Me)
            gridFiltered.Columns("glitemcode").Visible = False
            XgridColMemo({"Account Title"}, gridFiltered)
            XgridColWidth({"Account Title"}, gridFiltered, Em_filtered.Width)
        End If
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles cmdMoveRight.Click
        For I = 0 To gridUnFiltered.SelectedRowsCount - 1
            If gridUnFiltered.GetRowCellValue(gridUnFiltered.GetSelectedRows(I), "itemcode").ToString <> "" Then
                com.CommandText = "insert into tblcashflowtagging set glitemcode='" & gridUnFiltered.GetRowCellValue(gridUnFiltered.GetSelectedRows(I), "itemcode").ToString & "', cashflowcode='" & cashflowcode.Text & "'" : com.ExecuteNonQuery()
            End If
        Next
        ShowUnfilteredClient()
        ShowfilteredClients()
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles cmdMoveLeft.Click
        For I = 0 To gridFiltered.SelectedRowsCount - 1
            com.CommandText = "delete from tblcashflowtagging where glitemcode='" & gridFiltered.GetRowCellValue(gridFiltered.GetSelectedRows(I), "glitemcode").ToString & "' and cashflowcode='" & cashflowcode.Text & "'" : com.ExecuteNonQuery()
        Next
        ShowUnfilteredClient()
        ShowfilteredClients()
    End Sub
#End Region


End Class