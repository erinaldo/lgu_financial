Imports DevExpress.XtraEditors
Imports DevExpress
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraReports.UI
Imports DevExpress.Skins
Imports DevExpress.XtraSplashScreen
Imports DevExpress.Utils

Public Class frmDepartment
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        ElseIf keyData = Keys.F1 Then


        End If
        Return ProcessCmdKey
    End Function

    Public Sub filter()
        LoadXgrid("Select officeid as 'Code', officename as 'Department',shortname as 'Short Name', centercode as 'Responsibility Center', Address, contactnumber as 'Contact Number',ifnull( (select (select fullname from tblaccounts where accountid = tblcompofficerlog.officerid) from tblcompofficerlog where officeid=b.officeid and current=1 ),'NOT ASSIGNED') as 'Officer Incharge',case when officeemail='' then 'No Email' else officeemail end as 'Email Address', SB  from tblcompoffice as b where deleted=0 order by officename asc", "tblcompoffice", Em, GridView1, Me)
        XgridColAlign({"Code", "Initial Code", "Responsibility Center"}, GridView1, HorzAlignment.Center)
        GridView1.BestFitColumns()
    End Sub

    Private Sub EditToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        If GridView1.GetFocusedRowCellValue("Code") = "" Then
            XtraMessageBox.Show("There is no item selected! make sure, the selection is on the list", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        frmDepartmentInfo.mode.Text = ""
        frmDepartmentInfo.id.Text = GridView1.GetFocusedRowCellValue("Code").ToString
        frmDepartmentInfo.mode.Text = "edit"
        If frmDepartmentInfo.Visible = True Then
            frmDepartmentInfo.Focus()
        Else
            frmDepartmentInfo.Show(Me)
        End If
       

    End Sub

    Private Sub frmProductCat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        filter()

        If globalAllowAdd = True Or LCase(globaluser) = "root" Then
            cmdAdd.Visibility = XtraBars.BarItemVisibility.Always
        Else
            cmdAdd.Visibility = XtraBars.BarItemVisibility.Never
        End If
        If globalAllowEdit = True Or LCase(globaluser) = "root" Then
            cmdEdit.Visible = True
        Else
            cmdEdit.Visible = False
        End If
        If globalAllowDelete = True Or LCase(globaluser) = "root" Then
            cmdRemove.Enabled = True
        Else
            cmdRemove.Enabled = False
        End If

    End Sub

    Private Sub RefreshToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshToolStripMenuItem.Click
        filter()
    End Sub

    Private Sub RemoveItemToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRemove.Click
        If GridView1.GetFocusedRowCellValue("Code") = "" Then
            XtraMessageBox.Show("There is no item selected! make sure, the selection is on the list", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        If XtraMessageBox.Show("Are you sure you want to permanently delete this item? " & todelete, compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            For I = 0 To GridView1.SelectedRowsCount - 1
                com.CommandText = "UPDATE tblcompoffice set deleted=1 where officeid='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "Code") & "' " : com.ExecuteNonQuery()
            Next
            filter()
        End If
    End Sub

    Private Sub BarLargeButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdClose.ItemClick
        Me.Close()
    End Sub
    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdAdd.ItemClick
       If frmDepartmentInfo.Visible = True Then
            frmDepartmentInfo.Focus()
        Else
            frmDepartmentInfo.Show(Me)
        End If
        frmDepartmentInfo.mode.Text = "new"
    End Sub


    Private Sub BarButtonItem1_ItemClick(sender As Object, e As XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        PrintGeneralReport(Me.Text, "", GridView1, Me)
    End Sub

    Private Sub txtPrevBalance_SelectedValueChanged(sender As Object, e As EventArgs)
        filter()
    End Sub
End Class
