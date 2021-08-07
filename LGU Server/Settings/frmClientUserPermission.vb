Imports DevExpress.XtraEditors
Imports MySql.Data.MySqlClient
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraReports.UI
Imports DevExpress.Skins
Imports DevExpress.XtraSplashScreen

Public Class frmClientUserPermission
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        ElseIf keyData = (Keys.Enter) Then
            If txtdesc.Focus = True Then
                SaveData()

            End If

        ElseIf keyData = Keys.F1 Then


        ElseIf keyData = Keys.F2 Then
            If SplitContainerControl1.Collapsed = True Then
                SplitContainerControl1.Collapsed = False
            Else
                SplitContainerControl1.Collapsed = True
            End If

        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmProductCat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        clearfields()
        LoadGridviewAppearance(GridView1)
        filter()
        Em.ForceInitialize()

        If globalAllowAdd = True Or LCase(globaluser) = "root" Then
            cmdUpdate.Enabled = True
        Else
            cmdUpdate.Enabled = False
        End If
        If globalAllowEdit = True Or LCase(globaluser) = "root" Then
            cmdEdit.Visible = True
        Else
            cmdEdit.Visible = False
        End If
        If globalAllowDelete = True Or LCase(globaluser) = "root" Then
            cmdDelete.Visible = True
        Else
            cmdDelete.Visible = False
        End If
        If globalAllowEdit = True Or globalAllowDelete = True Or LCase(globaluser) = "root" Then
            Em.ContextMenuStrip = gridmenustrip
        Else
            Em.ContextMenuStrip = Nothing
        End If
        ClearAuthority()
    End Sub

    Public Sub ClearAuthority()
        checklistbox.Items.Clear()
        checklistbox.Items.Add("Collection Posting")
        checklistbox.Items.Add("Cedula - Individual")
        checklistbox.Items.Add("Cedula - Corporation")
        checklistbox.Items.Add("Real Property Tax")
        checklistbox.Items.Add("Collection Report")
        checklistbox.Items.Add("Accountable Form")
        checklistbox.Items.Add("Business Management")
        checklistbox.Items.Add("Real Property Management")
        checklistbox.Items.Add("New Direct Journal")
        checklistbox.Items.Add("Journal Entry Voucher")
        checklistbox.Items.Add("For Approval Request")
        checklistbox.Items.Add("Check Issuance Request")
        checklistbox.Items.Add("New Requisition")
        checklistbox.Items.Add("Requisition Management")
        checklistbox.Items.Add("New Disbursement")
        checklistbox.Items.Add("Disbursement Management")
        checklistbox.Items.Add("Actual Budget Report")
        checklistbox.Items.Add("Human Resource")
    End Sub
    Public Sub filter()
        Dim strmodule As String = ""
        strmodule = ", collectionposting as 'Collection Posting' " _
                  + ", cedulaindividual as 'Cedula - Individual' " _
                  + ", cedulacorporate as 'Cedula - Corporation' " _
                  + ", realpropertytax as 'Real Property Tax' " _
                  + ", collectionreport as 'Collection Report' " _
                  + ", accountableform as 'Accountable Form' " _
                  + ", businessmgt as 'Business Management' " _
                  + ", realpropertymgt as 'Real Property Management' " _
                  + ", newdirectjournal as 'New Direct Journal' " _
                  + ", journalentryvoucher as 'Journal Entry Voucher' " _
                  + ", forapproval as 'For Approval Request' " _
                  + ", checkapproval as 'Check Issuance Request' " _
                  + ", newrequisition as 'New Requisition' " _
                  + ", requisitionlist as 'Requisition Management' " _
                  + ", newdisbursement as 'New Disbursement' " _
                  + ", disbursementlist as 'Disbursement Management' " _
                  + ", budgetreport as 'Actual Budget Report' " _
                  + ", humanresource as 'Human Resource' "





        LoadXgrid("Select accesscode as 'Access Code', description as 'Authorize Person', departmenthead as 'Department Head',  generalapprover as 'General Approver', specialapprover as 'Special Authority', AllowAdd,AllowEdit,AllowDelete " & strmodule & "  from tblclientaccess order by description asc", "tblclientaccess", Em, GridView1, Me)
        XgridColAlign({"Access Code"}, GridView1, DevExpress.Utils.HorzAlignment.Center)
        GridView1.BestFitColumns()
    End Sub

    Public Sub SaveData()
        If txtdesc.Text = "" Then
            XtraMessageBox.Show("Please enter authorized approver description!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtdesc.Focus()
        End If
        Dim checkeditem As String = "" : Dim I As Integer = 0
        For I = 0 To checklistbox.Items.Count - 1
            If checklistbox.GetItemChecked(I).ToString = True Then
                If checklistbox.Items(I).ToString = "Collection Posting" Then
                    checkeditem += "collectionposting=1,"
                End If
                If checklistbox.Items(I).ToString = "Cedula - Individual" Then
                    checkeditem += "cedulaindividual=1,"
                End If
                If checklistbox.Items(I).ToString = "Cedula - Corporation" Then
                    checkeditem += "cedulacorporate=1,"
                End If
                If checklistbox.Items(I).ToString = "Real Property Tax" Then
                    checkeditem += "realpropertytax=1,"
                End If
                If checklistbox.Items(I).ToString = "Collection Report" Then
                    checkeditem += "collectionreport=1,"
                End If
                If checklistbox.Items(I).ToString = "Accountable Form" Then
                    checkeditem += "accountableform=1,"
                End If
                If checklistbox.Items(I).ToString = "Business Management" Then
                    checkeditem += "businessmgt=1,"
                End If
                If checklistbox.Items(I).ToString = "Real Property Management" Then
                    checkeditem += "realpropertymgt=1,"
                End If
                If checklistbox.Items(I).ToString = "New Direct Journal" Then
                    checkeditem += "newdirectjournal=1,"
                End If
                If checklistbox.Items(I).ToString = "Journal Entry Voucher" Then
                    checkeditem += "journalentryvoucher=1,"
                End If
                If checklistbox.Items(I).ToString = "For Approval Request" Then
                    checkeditem += "forapproval=1,"
                End If
                If checklistbox.Items(I).ToString = "Check Issuance Request" Then
                    checkeditem += "checkapproval=1,"
                End If
                If checklistbox.Items(I).ToString = "New Requisition" Then
                    checkeditem += "newrequisition=1,"
                End If
                If checklistbox.Items(I).ToString = "Requisition Management" Then
                    checkeditem += "requisitionlist=1,"
                End If
                If checklistbox.Items(I).ToString = "New Disbursement" Then
                    checkeditem += "newdisbursement=1,"
                End If
                If checklistbox.Items(I).ToString = "Disbursement Management" Then
                    checkeditem += "disbursementlist=1,"
                End If
                If checklistbox.Items(I).ToString = "Actual Budget Report" Then
                    checkeditem += "budgetreport=1,"
                End If
                If checklistbox.Items(I).ToString = "Human Resource" Then
                    checkeditem += "humanresource=1,"
                End If
            End If
        Next
        If mode.Text <> "edit" Then
            If countqry("tblclientaccess", "description='" & rchar(txtdesc.Text) & "'") > 0 Then
                XtraMessageBox.Show("Duplicate Authorized Approver!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtdesc.SelectAll()
                txtdesc.Focus()
                Exit Sub
            End If
            com.CommandText = "insert into tblclientaccess set description='" & rchar(txtdesc.Text) & "', " & checkeditem & " generalapprover=" & ckGeneralApprover.CheckState & ", departmenthead=" & ckDepartmentHead.CheckState & ",specialapprover=" & ckSpecialApprover.CheckState & ", allowadd=" & ckAllowAdd.CheckState & ",allowedit=" & ckAllowEdit.CheckState & ", allowdelete=" & ckAllowDelete.CheckState & "" : com.ExecuteNonQuery()
        Else
            com.CommandText = "delete from tblclientaccess where accesscode='" & id.Text & "'" : com.ExecuteNonQuery()
            com.CommandText = "insert into tblclientaccess set accesscode='" & id.Text & "', description='" & rchar(txtdesc.Text) & "', " & checkeditem & " generalapprover=" & ckGeneralApprover.CheckState & ", departmenthead=" & ckDepartmentHead.CheckState & ",specialapprover=" & ckSpecialApprover.CheckState & ", allowadd=" & ckAllowAdd.CheckState & ",allowedit=" & ckAllowEdit.CheckState & ", allowdelete=" & ckAllowDelete.CheckState & "" : com.ExecuteNonQuery()
        End If

        clearfields() : ClearAuthority()
        filter()
        XtraMessageBox.Show("Access successfully saved!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Public Sub clearfields()
        id.Text = ""
        txtdesc.Text = ""
        ckGeneralApprover.Checked = False
        ckdepartmenthead.Checked = False
        ckSpecialApprover.Checked = False
        ckAllowAdd.Checked = False
        ckAllowEdit.Checked = False
        ckAllowDelete.Checked = False
        mode.Text = ""
    End Sub

    Private Sub mode_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mode.EditValueChanged
        If mode.Text = "" Then Exit Sub

        com.CommandText = "select * from tblclientaccess where accesscode='" & id.Text & "'"
        rst = com.ExecuteReader
        While rst.Read
            txtdesc.Text = rst("description").ToString
            ckdepartmenthead.Checked = rst("departmenthead")
            ckGeneralApprover.Checked = rst("generalapprover")
            ckSpecialApprover.Checked = rst("specialapprover")
            ckAllowAdd.Checked = rst("allowadd")
            ckAllowEdit.Checked = rst("allowedit")
            ckAllowDelete.Checked = rst("allowdelete")

            If rst("collectionposting") = True Then
                Dim I As Integer = 0
                For I = 0 To checklistbox.Items.Count - 1
                    If checklistbox.Items(I).ToString = "Collection Posting" Then
                        checklistbox.SetItemCheckState(I, CheckState.Checked)
                    End If
                Next
            End If
            If rst("cedulaindividual") = True Then
                Dim I As Integer = 0
                For I = 0 To checklistbox.Items.Count - 1
                    If checklistbox.Items(I).ToString = "Cedula - Individual" Then
                        checklistbox.SetItemCheckState(I, CheckState.Checked)
                    End If
                Next
            End If
            If rst("cedulacorporate") = True Then
                Dim I As Integer = 0
                For I = 0 To checklistbox.Items.Count - 1
                    If checklistbox.Items(I).ToString = "Cedula - Corporation" Then
                        checklistbox.SetItemCheckState(I, CheckState.Checked)
                    End If
                Next
            End If
            If rst("realpropertytax") = True Then
                Dim I As Integer = 0
                For I = 0 To checklistbox.Items.Count - 1
                    If checklistbox.Items(I).ToString = "Real Property Tax" Then
                        checklistbox.SetItemCheckState(I, CheckState.Checked)
                    End If
                Next
            End If
            If rst("collectionreport") = True Then
                Dim I As Integer = 0
                For I = 0 To checklistbox.Items.Count - 1
                    If checklistbox.Items(I).ToString = "Collection Report" Then
                        checklistbox.SetItemCheckState(I, CheckState.Checked)
                    End If
                Next
            End If
            If rst("accountableform") = True Then
                Dim I As Integer = 0
                For I = 0 To checklistbox.Items.Count - 1
                    If checklistbox.Items(I).ToString = "Accountable Form" Then
                        checklistbox.SetItemCheckState(I, CheckState.Checked)
                    End If
                Next
            End If
            If rst("businessmgt") = True Then
                Dim I As Integer = 0
                For I = 0 To checklistbox.Items.Count - 1
                    If checklistbox.Items(I).ToString = "Business Management" Then
                        checklistbox.SetItemCheckState(I, CheckState.Checked)
                    End If
                Next
            End If
            If rst("realpropertymgt") = True Then
                Dim I As Integer = 0
                For I = 0 To checklistbox.Items.Count - 1
                    If checklistbox.Items(I).ToString = "Real Property Management" Then
                        checklistbox.SetItemCheckState(I, CheckState.Checked)
                    End If
                Next
            End If

            If rst("newdirectjournal") = True Then
                Dim I As Integer = 0
                For I = 0 To checklistbox.Items.Count - 1
                    If checklistbox.Items(I).ToString = "New Direct Journal" Then
                        checklistbox.SetItemCheckState(I, CheckState.Checked)
                    End If
                Next
            End If

            If rst("journalentryvoucher") = True Then
                Dim I As Integer = 0
                For I = 0 To checklistbox.Items.Count - 1
                    If checklistbox.Items(I).ToString = "Journal Entry Voucher" Then
                        checklistbox.SetItemCheckState(I, CheckState.Checked)
                    End If
                Next
            End If

            If rst("forapproval") = True Then
                Dim I As Integer = 0
                For I = 0 To checklistbox.Items.Count - 1
                    If checklistbox.Items(I).ToString = "For Approval Request" Then
                        checklistbox.SetItemCheckState(I, CheckState.Checked)
                    End If
                Next
            End If

            If rst("checkapproval") = True Then
                Dim I As Integer = 0
                For I = 0 To checklistbox.Items.Count - 1
                    If checklistbox.Items(I).ToString = "Check Issuance Request" Then
                        checklistbox.SetItemCheckState(I, CheckState.Checked)
                    End If
                Next
            End If

            If rst("newrequisition") = True Then
                Dim I As Integer = 0
                For I = 0 To checklistbox.Items.Count - 1
                    If checklistbox.Items(I).ToString = "New Requisition" Then
                        checklistbox.SetItemCheckState(I, CheckState.Checked)
                    End If
                Next
            End If

            If rst("requisitionlist") = True Then
                Dim I As Integer = 0
                For I = 0 To checklistbox.Items.Count - 1
                    If checklistbox.Items(I).ToString = "Requisition Management" Then
                        checklistbox.SetItemCheckState(I, CheckState.Checked)
                    End If
                Next
            End If

            If rst("newdisbursement") = True Then
                Dim I As Integer = 0
                For I = 0 To checklistbox.Items.Count - 1
                    If checklistbox.Items(I).ToString = "New Disbursement" Then
                        checklistbox.SetItemCheckState(I, CheckState.Checked)
                    End If
                Next
            End If

            If rst("disbursementlist") = True Then
                Dim I As Integer = 0
                For I = 0 To checklistbox.Items.Count - 1
                    If checklistbox.Items(I).ToString = "Disbursement Management" Then
                        checklistbox.SetItemCheckState(I, CheckState.Checked)
                    End If
                Next
            End If

            If rst("budgetreport") = True Then
                Dim I As Integer = 0
                For I = 0 To checklistbox.Items.Count - 1
                    If checklistbox.Items(I).ToString = "Actual Budget Report" Then
                        checklistbox.SetItemCheckState(I, CheckState.Checked)
                    End If
                Next
            End If

            If rst("humanresource") = True Then
                Dim I As Integer = 0
                For I = 0 To checklistbox.Items.Count - 1
                    If checklistbox.Items(I).ToString = "Human Resource" Then
                        checklistbox.SetItemCheckState(I, CheckState.Checked)
                    End If
                Next
            End If

        End While
        rst.Close()

        If mode.Text = "edit" Then
            cmdUpdate.Enabled = True
        Else
            cmdUpdate.Enabled = False
        End If
    End Sub

    Private Sub EditToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        If GridView1.GetFocusedRowCellValue("Access Code").ToString = "" Then
            XtraMessageBox.Show("There is no item selected! make sure, the selection is on the list", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        clearfields() : ClearAuthority()
        mode.Text = ""
        id.Text = GridView1.GetFocusedRowCellValue("Access Code").ToString
        mode.Text = "edit"
        SplitContainerControl1.Collapsed = False
    End Sub

    Private Sub frmProductCat_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        clearfields()
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshToolStripMenuItem.Click
        filter()
    End Sub

    Private Sub RemoveItemToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        If GridView1.GetFocusedRowCellValue("Access Code").ToString = "" Then
            XtraMessageBox.Show("There is no item selected! make sure, the selection is on the list", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        If XtraMessageBox.Show("Are you sure you want to permanently delete this item? " & todelete, compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            DeleteRow("Access Code", "accesscode", "tblclientaccess", GridView1, Me)
        End If
    End Sub

    Private Sub BarLargeButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarLargeButtonItem2.ItemClick
        Me.Close()
    End Sub

    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        clearfields()
    End Sub

    Private Sub cmdUpdate_Click(sender As Object, e As EventArgs) Handles cmdUpdate.Click
        'Dim msg As String = ""
        'For I = 0 To checklistbox.Items.Count - 1
        '    msg += checklistbox.Items(I).ToString & Environment.NewLine
        'Next
        'MsgBox(msg)
        If txtdesc.Text = "" Then
            XtraMessageBox.Show("Please enter description", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtdesc.Focus()
            Exit Sub
        ElseIf checklistbox.Items.Count = 0 Then
            XtraMessageBox.Show("Please select atleast one permission", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        SaveData()
    End Sub

    Private Sub CheckEdit2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckEdit2.CheckedChanged
        Dim I As Integer = 0
        For I = 0 To checklistbox.Items.Count - 1
            If CheckEdit2.Checked = True Then
                checklistbox.SetItemCheckState(I, CheckState.Checked)
            Else
                checklistbox.SetItemCheckState(I, CheckState.Unchecked)
            End If
        Next
    End Sub

    Private Sub DuplicateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DuplicateToolStripMenuItem.Click
        com.CommandText = "INSERT INTO  `tblclientaccess` (description,departmenthead,generalapprover,specialapprover,allowadd,allowedit,allowdelete,collectionposting,cedulaindividual,cedulacorporate,realpropertytax,collectionreport,accountableform,businessmgt,realpropertymgt,newdirectjournal,journalentryvoucher,forapproval,checkapproval,newrequisition,requisitionlist,newdisbursement,disbursementlist,budgetreport,humanresource) " _
                               + " SELECT concat(description,' - copy'),departmenthead,generalapprover,specialapprover,allowadd,allowedit,allowdelete,collectionposting,cedulaindividual,cedulacorporate,realpropertytax,collectionreport,accountableform,businessmgt,realpropertymgt,newdirectjournal,journalentryvoucher,forapproval,checkapproval,newrequisition,requisitionlist,newdisbursement,disbursementlist,budgetreport,humanresource FROM `tblclientaccess` where accesscode='" & GridView1.GetFocusedRowCellValue("Access Code").ToString & "'" : com.ExecuteNonQuery()
        filter()
        XtraMessageBox.Show("Permission successfully duplicated", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        If GridView1.RowCount = 0 Then
            XtraMessageBox.Show("There's no item to export!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        Dim saveFileDialog1 As New SaveFileDialog()
        saveFileDialog1.Filter = "Report File (*.xlsx)|*.xlsx|All files (*.*)|*.*"
        saveFileDialog1.FileName = Me.Text & ".xlsx"
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

    Private Sub BarButtonItem3_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        PrintGeneralReport(Me.Text, "", GridView1, Me)
    End Sub
End Class