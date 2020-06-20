Imports DevExpress.XtraEditors
Imports DevExpress.Skins

Public Class frmAccountableForm
    Private Sub frmFund_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        LoadSystemFont()
        filter()
    End Sub

    Private Sub LoadSystemFont()
        txtFontName.Properties.Items.Clear()
        For Each oFont As FontFamily In FontFamily.Families
            txtFontName.Properties.Items.Add(oFont.Name)
        Next
    End Sub

    Public Sub filter()
        LoadXgrid("Select  Code, Description,enablePrintSettings as 'Enable Printing Settings', prnPapersize as 'Paper Size',prnMarginTop as 'Margin Top',prnMarginLeft as 'Margin Left', prnFontName as 'Font Name',prnFontSize as 'Font Size',prnLandScape as 'Landscape'  from tblaccountableform order by code asc", "tblaccountableform", Em, GridView1, Me)
        XgridColAlign({"Code", "Paper Size", "Margin Top", "Margin Left", "Font Size"}, GridView1, DevExpress.Utils.HorzAlignment.Center)
        GridView1.BestFitColumns()
    End Sub


    Private Sub cmdSaveButton_Click(sender As Object, e As EventArgs) Handles cmdSaveButton.Click
        If countqry("tblaccountableform", "code='" & code.Text & "'") > 0 And mode.Text <> "edit" Then
            XtraMessageBox.Show("Code already exists!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            code.Focus()
            Exit Sub
        ElseIf txtDescription.Text = "" Then
            XtraMessageBox.Show("Please enter description!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtDescription.Focus()
            Exit Sub
        ElseIf txtFontName.Text = "" And ckEnablePrintSettings.Checked = True Then
            XtraMessageBox.Show("Please select font name! use consolas as default", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtFontName.Focus()
            Exit Sub
        End If

        If mode.Text = "edit" Then
            com.CommandText = "update tblaccountableform set description='" & rchar(txtDescription.Text) & "',enablePrintSettings=" & ckEnablePrintSettings.CheckState & ", prnPapersize='" & Val(txtPaperSize.Text) & "',prnMarginTop='" & Val(txtMarginTop.Text) & "',prnMarginLeft='" & Val(txtMarginLeft.Text) & "',prnFontName='" & txtFontName.Text & "',prnFontSize='" & Val(txtFontSize.Text) & "',prnLandScape=" & ckLandScape.CheckState & " where code='" & code.Text & "'" : com.ExecuteNonQuery()
        Else
            com.CommandText = "insert into tblaccountableform set code='" & code.Text & "', description='" & rchar(txtDescription.Text) & "',enablePrintSettings=" & ckEnablePrintSettings.CheckState & ",prnPapersize='" & Val(txtPaperSize.Text) & "',prnMarginTop='" & Val(txtMarginTop.Text) & "',prnMarginLeft='" & Val(txtMarginLeft.Text) & "',prnFontName='" & txtFontName.Text & "',prnFontSize='" & Val(txtFontSize.Text) & "',prnLandScape=" & ckLandScape.CheckState & "" : com.ExecuteNonQuery()
        End If
        code.Text = "" : mode.Text = "" : code.Enabled = True : txtDescription.Text = "" : code.Focus() : ckEnablePrintSettings.Checked = False : ckLandScape.Checked = False : filter()
        XtraMessageBox.Show("Form successfully saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Public Sub showInfo()
        If code.Text = "" Then Exit Sub
        com.CommandText = "select * from tblaccountableform where code='" & code.Text & "'" : rst = com.ExecuteReader
        While rst.Read
            txtDescription.Text = rst("description").ToString
            ckEnablePrintSettings.Checked = CBool(rst("enablePrintSettings").ToString)
            txtPaperSize.Text = rst("prnPapersize").ToString
            txtMarginTop.Text = rst("prnMarginTop").ToString
            txtMarginLeft.Text = rst("prnMarginLeft").ToString
            txtFontName.Text = rst("prnFontName").ToString
            txtFontSize.Text = rst("prnFontSize").ToString
            ckLandScape.Checked = CBool(rst("prnLandScape").ToString)
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
                com.CommandText = "delete from tblaccountableform where code='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "Code") & "' " : com.ExecuteNonQuery()
            Next
            filter()
        End If
    End Sub

    Private Sub ckEnablePrintSettings_CheckedChanged(sender As Object, e As EventArgs) Handles ckEnablePrintSettings.CheckedChanged
        If ckEnablePrintSettings.Checked = True Then
            EnableControl(True)
        Else
            EnableControl(False)
        End If
    End Sub

    Public Function EnableControl(ByVal enable As Boolean)
        txtPaperSize.Enabled = enable
        txtMarginTop.Enabled = enable
        txtMarginLeft.Enabled = enable
        txtFontName.Enabled = enable
        txtFontSize.Enabled = enable
        ckLandScape.Enabled = enable
        Return True
    End Function
End Class