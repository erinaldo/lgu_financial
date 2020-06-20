Imports DevExpress.XtraEditors
Imports DevExpress.Skins
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmExpenditureClass
    Private Sub frmFund_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        SetIcon(Me)
        filter()
        LoadExpenditureItem()
        ShowUnfilteredClient()
        ShowfilteredClients()
    End Sub


#Region "Expenditure Info"
    Public Sub filter()
        LoadXgrid("Select  Code, Description  from tblexpenditureclass order by code asc", "tblexpenditureclass", Em, GridView1, Me)
        XgridColAlign({"Code"}, GridView1, DevExpress.Utils.HorzAlignment.Center)
        GridView1.BestFitColumns()
    End Sub

    Private Sub cmdSaveButton_Click(sender As Object, e As EventArgs) Handles cmdSaveButton.Click
        If countqry("tblexpenditureclass", "code='" & code.Text & "'") > 0 And mode.Text <> "edit" Then
            XtraMessageBox.Show("Code already exists!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            code.Focus()
            Exit Sub

        ElseIf txtDescription.Text = "" Then
            XtraMessageBox.Show("Please enter description!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtDescription.Focus()
            Exit Sub
        End If
        If mode.Text = "edit" Then
            com.CommandText = "update tblexpenditureclass set description='" & rchar(txtDescription.Text) & "' where code='" & code.Text & "'" : com.ExecuteNonQuery()
        Else
            com.CommandText = "insert into tblexpenditureclass set code='" & code.Text & "' ,description='" & rchar(txtDescription.Text) & "'" : com.ExecuteNonQuery()
        End If
        code.Text = "" : mode.Text = "" : code.Enabled = True : txtDescription.Text = "" : code.Focus() : filter()
        XtraMessageBox.Show("fund successfully saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Public Sub showInfo()
        If code.Text = "" Then Exit Sub
        com.CommandText = "select * from tblexpenditureclass where code='" & code.Text & "'" : rst = com.ExecuteReader
        While rst.Read
            txtDescription.Text = rst("description").ToString
        End While
        rst.Close()
    End Sub

    Private Sub cmdEdit_Click(sender As Object, e As EventArgs) Handles cmdEdit.Click
        mode.Text = "" : code.Enabled = False
        code.Text = GridView1.GetFocusedRowCellValue("Code").ToString
        mode.Text = "edit"
        showInfo()
    End Sub

    Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
        If XtraMessageBox.Show("Are you sure you want to permanently remove selected item? ", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            Dim I As Integer = 0
            For I = 0 To GridView1.SelectedRowsCount - 1
                com.CommandText = "delete from tblexpenditureclass where code='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "Code") & "' " : com.ExecuteNonQuery()
            Next
            filter()
        End If
    End Sub

#End Region


#Region "Expenditure Tagging"
    Private Sub XtraTabControl1_SelectedPageChanged(sender As Object, e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles XtraTabControl1.SelectedPageChanged
        LoadExpenditureItem()
    End Sub

    Public Sub LoadExpenditureItem()
        LoadXgridLookupEdit("select code, description as 'Select' from tblexpenditureclass order by description asc", "tblexpenditureclass", txtTagCashFlowName, gridTagCashFlowName, Me)
        gridTagCashFlowName.Columns("code").Visible = False
    End Sub

    Private Sub txtTagCashFlowName_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTagCashFlowName.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtTagCashFlowName.Properties.View.FocusedRowHandle.ToString)
        expenditurecode.Text = txtTagCashFlowName.Properties.View.GetFocusedRowCellValue("code").ToString()
        ShowUnfilteredClient()
        ShowfilteredClients()
    End Sub

    Public Sub ShowUnfilteredClient()
        Dim cifquery As String = ""
        com.CommandText = "select glitemcode from tblexpendituretagging where expenditurecode='" & expenditurecode.Text & "'" : rst = com.ExecuteReader
        While rst.Read
            cifquery = cifquery + "'" & rst("glitemcode").ToString & "',"
        End While
        rst.Close()
        If cifquery.Length > 0 Then
            cifquery = cifquery.Remove(cifquery.Length - 1, 1)
            cifquery = " where itemcode not in(" & cifquery & ")"
        End If
        If expenditurecode.Text <> "" Then
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
        If expenditurecode.Text <> "" Then
            LoadXgrid("select glitemcode, (select itemname from tblglitem where itemcode= tblexpendituretagging.glitemcode) as 'Account Title' from tblexpendituretagging where expenditurecode='" & expenditurecode.Text & "' order by (select itemname from tblglitem where itemcode= tblexpendituretagging.glitemcode)  asc", "tblexpendituretagging", Em_filtered, gridFiltered, Me)
            gridFiltered.Columns("glitemcode").Visible = False
            XgridColMemo({"Account Title"}, gridFiltered)
            XgridColWidth({"Account Title"}, gridFiltered, Em_filtered.Width)
        End If
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles cmdMoveRight.Click
        For I = 0 To gridUnFiltered.SelectedRowsCount - 1
            If gridUnFiltered.GetRowCellValue(gridUnFiltered.GetSelectedRows(I), "itemcode").ToString <> "" Then
                com.CommandText = "insert into tblexpendituretagging set glitemcode='" & gridUnFiltered.GetRowCellValue(gridUnFiltered.GetSelectedRows(I), "itemcode").ToString & "', expenditurecode='" & expenditurecode.Text & "'" : com.ExecuteNonQuery()
            End If
        Next
        ShowUnfilteredClient()
        ShowfilteredClients()
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles cmdMoveLeft.Click
        For I = 0 To gridFiltered.SelectedRowsCount - 1
            com.CommandText = "delete from tblexpendituretagging where glitemcode='" & gridFiltered.GetRowCellValue(gridFiltered.GetSelectedRows(I), "glitemcode").ToString & "' and expenditurecode='" & expenditurecode.Text & "'" : com.ExecuteNonQuery()
        Next
        ShowUnfilteredClient()
        ShowfilteredClients()
    End Sub
#End Region

End Class