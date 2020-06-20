Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System.IO
Imports System.Data
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraBars
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.Skins
Imports DevExpress.XtraSplashScreen

Public Class frmCoffeecupServerPermission

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()

        End If
        Return ProcessCmdKey
    End Function

    Public Sub ClearFields()
        Load_Menu()
        txtpermission.Properties.DataSource = Nothing
        txtpermission.Text = ""
        percode.Text = ""
        If percode.Text <> "" Then
            cmdEditItem.Enabled = True
        Else
            cmdEditItem.Enabled = False
        End If
    End Sub
    Private Sub frmUsersAccounts_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        LoadGridviewAppearance(gv_permission)
        Load_Menu()
        LoadPermission()
        loadGridPermission()
    End Sub

    Public Sub loadGridPermission()
        LoadXgrid("Select replace(grouppermission,'rbn','') as 'GROUP',concat('             ',caption) as 'PERMISSION'  from tblpermissionstemplate where percode='" & percode.Text & "' and caption<>'' order by grouppermission,caption asc", "tblpermissionstemplate", Em, GridView1, Me)
        GridView1.Columns("GROUP").Group()
        XgridColWidth({"PERMISSION"}, GridView1, 400)
        GridView1.ExpandAllGroups()
        GridView1.BestFitColumns()
        If GridView1.RowCount > 0 And txtpermission.Text <> "" Then
            cmdExportExcel.Enabled = True
        Else
            cmdExportExcel.Enabled = False
        End If
    End Sub
    Public Sub LoadPermission()
        ClearFields()
        LoadXgridLookupSearch("SELECT percode,permission as 'Select Permission',approver from tblpermissions", "tblpermissions", txtpermission, gv_permission, Me)
        gv_permission.Columns("percode").Visible = False
        gv_permission.Columns("approver").Visible = False
    End Sub
    Private Sub txtpermission_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpermission.EditValueChanged
        On Error Resume Next
        percode.Text = txtpermission.Properties.View.GetFocusedRowCellValue("percode").ToString()
        If percode.Text <> "" Then
            Load_Menu()
            LoadPermissionTemplate()
            cmdEditItem.Enabled = True
            cmdDelete.Enabled = True
        Else
            Load_Menu()
            cmdEditItem.Enabled = False
            cmdDelete.Enabled = False
        End If
        loadGridPermission()
    End Sub
    Public Sub LoadPermissionTemplate()
        On Error Resume Next
        com.CommandText = "select * from tblpermissionstemplate where percode='" & percode.Text & "'" : rst = com.ExecuteReader
        While rst.Read
            If rst("grouppermission").ToString = "rbnAccounting" Then
                list_accounting.Items.Item(rst("menus").ToString).CheckState = CheckState.Checked

            ElseIf rst("grouppermission").ToString = "rbnSettings" Then
                list_settings.Items.Item(rst("menus").ToString).CheckState = CheckState.Checked
            End If
        End While
        rst.Close()

 

    End Sub
    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Me.Close()
    End Sub
    Sub Load_Menu()
        Dim mCurrentItem As BarItem
        list_accounting.Items.Clear()
        list_settings.Items.Clear()
        For Each currentPage As RibbonPage In MdiMainmenu.MainMenu.Pages
            For Each currentGroup As RibbonPageGroup In currentPage.Groups
                For Each currenLink As BarItemLink In currentGroup.ItemLinks
                    mCurrentItem = currenLink.Item
                    If currentPage.Name = "rbnAccounting" Then
                        If mCurrentItem.Visibility = BarItemVisibility.Always Then
                            list_accounting.Items.Add(mCurrentItem.Name, False)
                            list_accounting.Items.Item(mCurrentItem.Name).Description = mCurrentItem.Caption
                            list_accounting.Items.Item(mCurrentItem.Name).Value = mCurrentItem.Name
                        End If
                    ElseIf currentPage.Name = "rbnSettings" Then
                        If mCurrentItem.Visibility = BarItemVisibility.Always Then
                            list_settings.Items.Add(mCurrentItem.Name, False)
                            list_settings.Items.Item(mCurrentItem.Name).Description = mCurrentItem.Caption
                            list_settings.Items.Item(mCurrentItem.Name).Value = mCurrentItem.Name
                        End If

                    End If
                Next currenLink
            Next currentGroup
        Next currentPage
 
    End Sub

    Private Sub cmdFinish_Click(sender As Object, e As EventArgs) Handles cmdFinish.Click
        If txtpermission.Text = "" Then
            XtraMessageBox.Show("Please select Permission!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtpermission.Focus()
            Exit Sub
        End If
        'PROCUREMENT
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        com.CommandText = "DELETE from tblpermissionstemplate where percode='" & percode.Text & "'" : com.ExecuteNonQuery()
        com.CommandText = "DELETE from tblpermissionsclearing where percode='" & percode.Text & "'" : com.ExecuteNonQuery()
       

        'ACCOUNTING
        If list_accounting.CheckedItemsCount > 0 Then
            For n = 0 To list_accounting.CheckedItems.Count - 1
                com.CommandText = "insert into tblpermissionstemplate set percode='" & percode.Text & "',grouppermission='rbnAccounting', menus='" & list_accounting.Items.Item(list_accounting.CheckedItems.Item(n)).Value.ToString & "',caption='" & rchar(list_accounting.Items.Item(list_accounting.CheckedItems.Item(n)).Description.ToString) & "'" : com.ExecuteNonQuery()
            Next
        End If

        'SETTINGS
        If list_settings.CheckedItemsCount > 0 Then
            For n = 0 To list_settings.CheckedItems.Count - 1
                com.CommandText = "insert into tblpermissionstemplate set percode='" & percode.Text & "',grouppermission='rbnSettings', menus='" & list_settings.Items.Item(list_settings.CheckedItems.Item(n)).Value.ToString & "',caption='" & rchar(list_settings.Items.Item(list_settings.CheckedItems.Item(n)).Description.ToString) & "'" : com.ExecuteNonQuery()
            Next
        End If

        loadGridPermission()
        SplashScreenManager.CloseForm()
        XtraMessageBox.Show("Permission template Successfully Saved!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub CheckEdit1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckEdit1.CheckedChanged
        If XtraTabControl1.SelectedTabPage Is TabAccounting Then
            For n = 0 To list_accounting.ItemCount - 1
                If CheckEdit1.Checked = True Then
                    list_accounting.Items.Item(n).CheckState = CheckState.Checked
                End If
            Next
        ElseIf XtraTabControl1.SelectedTabPage Is tabSettings Then
            For n = 0 To list_settings.ItemCount - 1
                If CheckEdit1.Checked = True Then
                    list_settings.Items.Item(n).CheckState = CheckState.Checked
                End If
            Next
        End If
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
        If XtraMessageBox.Show("Are you sure you want to continue?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            com.CommandText = "delete from tblpermissions where percode='" & percode.Text & "'" : com.ExecuteNonQuery()
            com.CommandText = "delete from tblpermissionstemplate where percode='" & percode.Text & "'" : com.ExecuteNonQuery()
            com.CommandText = "delete from tblpermissionsclearing where percode='" & percode.Text & "'" : com.ExecuteNonQuery()
            LoadPermission()
            XtraMessageBox.Show("Permission Successfully deleted!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

#Region "ACTION BUTTON"

    Private Sub cmdAccountingSystem_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles cmdAccountingSystem.LinkClicked
        XtraTabControl1.SelectedTabPage = TabAccounting
        CheckEdit1.Checked = False
    End Sub

    Private Sub cmdSettings_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles cmdSettings.LinkClicked
        XtraTabControl1.SelectedTabPage = tabSettings
        CheckEdit1.Checked = False
    End Sub

    Private Sub cmdEditItem_Click(sender As Object, e As EventArgs) Handles cmdEditItem.Click
        frmCoffeecupServerPermissionInfo.percode.Text = percode.Text
        frmCoffeecupServerPermissionInfo.Show(Me)
    End Sub

    Private Sub cmdSelect_Click(sender As Object, e As EventArgs) Handles cmdSelect.Click
        frmCoffeecupServerPermissionInfo.Show(Me)
    End Sub

#End Region

  
    Private Sub BarButtonItem2_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmdExportExcel.ItemClick
        If GridView1.RowCount = 0 Then
            XtraMessageBox.Show("There's no item to export!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        Dim saveFileDialog1 As New SaveFileDialog()
        saveFileDialog1.Filter = "Report File (*.xlsx)|*.xlsx|All files (*.*)|*.*"
        saveFileDialog1.FileName = "Coffeecup Server Permission (" & txtpermission.Text & ").xlsx"
        saveFileDialog1.FilterIndex = 2
        saveFileDialog1.RestoreDirectory = True
        If saveFileDialog1.ShowDialog() = DialogResult.OK Then
            If System.IO.File.Exists(saveFileDialog1.FileName) = True Then
                System.IO.File.Delete(saveFileDialog1.FileName)
            End If
            GridView1.ExportToXlsx(saveFileDialog1.FileName)
            XtraMessageBox.Show("Export done successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class