Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System.IO
Imports System.Data
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraReports.UI
Imports DevExpress.Skins
Imports DevExpress.XtraSplashScreen

Public Class frmApprovingProcess
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        ElseIf keyData = Keys.F1 Then

        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmBiilSettings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        LoadOffice()
        LoadFund()
        LoadApproverList()

        If globalAllowEdit = True Or LCase(globaluser) = "root" Then
            Em.ContextMenuStrip = appStrip
        Else
            Em.ContextMenuStrip = Nothing
        End If
        If globalAllowAdd = True Or LCase(globaluser) = "root" Then
            cmdUpdate.Enabled = True
        Else
            cmdUpdate.Enabled = False
        End If
    End Sub

#Region "Approving Process"
    Private Sub txtProcessType_SelectedValueChanged(sender As Object, e As EventArgs) Handles txtProcessType.SelectedValueChanged
        txtRequestType.Enabled = True
        If txtProcessType.Text = "Requisition Approving Process" Then
            LoadXgridLookupEdit("select code,description as 'Select' from tblrequisitiontype  order by description asc", "tblrequisitiontype", txtRequestType, gridRequestType, Me)
            gridRequestType.Columns("code").Visible = False
        End If
    End Sub

    Private Sub txtRequestType_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRequestType.EditValueChanged
        On Error Resume Next
        ShowUnfilteredProducts()
        ShowfilteredProducts()
        LoadApproverList()
    End Sub

    Public Sub LoadFund()
        LoadXgridLookupSearch("select code, description 'Select' from tblfund order by description asc", "tblfund", txtFund, gridFund, Me)
        gridFund.Columns("code").Visible = False
    End Sub

    Private Sub txtFund_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFund.EditValueChanged
        On Error Resume Next
        LoadApproverList()
    End Sub


    Public Sub LoadOffice()
        LoadXgridLookupSearch("select officeid as code, officename as 'Select' from tblcompoffice order by officename asc", "tblcompoffice", txtOffice, gridOffice, Me)
        gridOffice.Columns("code").Visible = False
    End Sub

    Private Sub txtCustomizedCorporate_EditValueChanging(sender As Object, e As ChangingEventArgs) Handles txtOffice.EditValueChanging
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtOffice.Properties.View.FocusedRowHandle.ToString)
        officeid.Text = txtOffice.Properties.View.GetFocusedRowCellValue("code").ToString()
    End Sub

    Private Sub cmdRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefresh.Click
        LoadApproverList()
    End Sub

    Public Sub LoadApproverList()
        LoadXgrid("select id,trncode, applevel as 'Level', (select officename from tblcompoffice where officeid=tblapprovingprocess.officeid) as 'Approver', finalapp as 'Final', attachment as 'Attachment' from tblapprovingprocess where apptype='" & LCase(txtProcessType.Text.Replace(" ", "-")) & "' and trncode='" & txtRequestType.EditValue & "' and fundcode='" & txtFund.EditValue & "'  order by applevel asc", "tblapprovingprocess", Em, GridView1, Me)
        XgridHideColumn({"id", "trncode"}, GridView1)
        XgridColAlign({"Level", "Final", "Attachment"}, GridView1, DevExpress.Utils.HorzAlignment.Center)
        GridView1.BestFitColumns()
    End Sub

    Private Sub cmdConfirmsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUpdate.Click
        If txtProcessType.Text = "" Then
            XtraMessageBox.Show("Please select process type!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtProcessType.Focus()
            Exit Sub

        ElseIf txtRequestType.Text = "" Then
            XtraMessageBox.Show("Please select request type!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtRequestType.Focus()
            Exit Sub

        ElseIf txtapplevel.Text = "" Then
            XtraMessageBox.Show("Please select account level!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtapplevel.Focus()
            Exit Sub

        ElseIf txtOffice.Text = "" Then
            XtraMessageBox.Show("Please select office approving!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtOffice.Focus()
            Exit Sub
        ElseIf countqry("tblapprovingprocess", "apptype='" & LCase(txtProcessType.Text.Replace(" ", "-")) & "' and trncode='" & txtRequestType.EditValue & "' and fundcode='" & txtFund.EditValue & "' and finalapp=1 and id<>'" & id.Text & "'") > 0 And chfinal.Checked = True Then
            XtraMessageBox.Show("Final approver is allready added!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtOffice.Focus()
            Exit Sub
        End If
        If mode.Text = "edit" Then
            com.CommandText = "update tblapprovingprocess set apptype='" & LCase(txtProcessType.Text.Replace(" ", "-")) & "', trncode='" & txtRequestType.EditValue & "',fundcode='" & txtFund.EditValue & "', applevel='" & txtapplevel.Text & "', officeid='" & officeid.Text & "', finalapp='" & chfinal.CheckState & "', attachment=" & ckRequiredAttachment.CheckState & "  where id='" & id.Text & "'" : com.ExecuteNonQuery()
            LoadApproverList() : ClearForm()
            XtraMessageBox.Show("Account for approver successfully saved!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            com.CommandText = "insert into tblapprovingprocess set apptype='" & LCase(txtProcessType.Text.Replace(" ", "-")) & "', trncode='" & txtRequestType.EditValue & "',fundcode='" & txtFund.EditValue & "', applevel='" & txtapplevel.Text & "', officeid='" & officeid.Text & "', finalapp='" & chfinal.CheckState & "',attachment=" & ckRequiredAttachment.CheckState & "" : com.ExecuteNonQuery()
            LoadApproverList() : ClearForm() : txtOffice.ShowPopup()
            XtraMessageBox.Show("Account for approver successfully saved!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdInactive.Click
        If XtraMessageBox.Show("Are you sure you want to remove selected approver? " & todelete, compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            For I = 0 To GridView1.SelectedRowsCount - 1
                com.CommandText = "delete from tblapprovingprocess where id='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "id").ToString & "'" : com.ExecuteNonQuery()
                com.CommandText = "delete from tblapprovingattachment where trncode='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "trncode").ToString & "' and appid='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "id").ToString & "'" : com.ExecuteNonQuery()
            Next
            LoadApproverList()
        End If
    End Sub

    Public Sub ClearForm()
        id.Text = ""
        officeid.Text = ""
        txtOffice.EditValue = Nothing
        txtapplevel.Text = Val(txtapplevel.Text) + 1
        mode.Text = ""
    End Sub

    Private Sub EditApproverToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditApproverToolStripMenuItem.Click
        id.Text = GridView1.GetFocusedRowCellValue("id").ToString()
        dst = Nothing : dst = New DataSet
        msda = New MySqlDataAdapter("select * from tblapprovingprocess where id='" & id.Text & "'", conn)
        msda.Fill(dst, 0)
        For cnt = 0 To dst.Tables(0).Rows.Count - 1
            With (dst.Tables(0))
                txtRequestType.EditValue = .Rows(cnt)("trncode").ToString
                txtFund.EditValue = .Rows(cnt)("fundcode").ToString
                txtapplevel.Text = .Rows(cnt)("applevel").ToString
                officeid.Text = .Rows(cnt)("officeid").ToString
                txtOffice.EditValue = .Rows(cnt)("officeid").ToString
                chfinal.Checked = CBool(.Rows(cnt)("finalapp").ToString)
                ckRequiredAttachment.Checked = CBool(.Rows(cnt)("attachment").ToString)
            End With
        Next
        mode.Text = "" : mode.Text = "edit"
    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        ClearForm()
    End Sub

#End Region

#Region "FIlter"
    Private Sub tabsettings_SelectedPageChanged(sender As Object, e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles tabsettings.SelectedPageChanged
        LoadApprover()
    End Sub
#End Region

    Public Sub LoadApprover()
        LoadXgridLookupSearch("select id,concat(applevel, ' - ', (select officename from tblcompoffice where officeid=tblapprovingprocess.officeid)) as 'Select' from tblapprovingprocess where apptype='" & LCase(txtProcessType.Text.Replace(" ", "-")) & "' and trncode='" & txtRequestType.EditValue & "' order by applevel asc", "tblapprovingprocess", txtPermission, gvpermission, Me)
        gvpermission.Columns("id").Visible = False
    End Sub

    Private Sub txtprocat_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPermission.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtPermission.Properties.View.FocusedRowHandle.ToString)
        approverid.Text = txtPermission.Properties.View.GetFocusedRowCellValue("id").ToString()
        ShowUnfilteredProducts()
        ShowfilteredProducts()
    End Sub

    Public Sub ShowUnfilteredProducts()
        Dim code As String = ""
        com.CommandText = "select doccode from tblapprovingattachment where appid='" & approverid.Text & "' and trncode='" & txtRequestType.EditValue & "' and apptype='" & LCase(txtProcessType.Text.Replace(" ", "-")) & "'" : rst = com.ExecuteReader
        While rst.Read
            code = code + "'" & rst("doccode").ToString & "',"
        End While
        rst.Close()
        If code.Length > 0 Then
            code = code.Remove(code.Length - 1, 1)
            code = "where code not in (" & code & ")"
        End If
        If approverid.Text <> "" Then
            LoadXgrid("select cast(code as char) as code, description as 'Document Name' from tbldocumenttype " & code & " ", "tbldocumenttype", Em_unfiltered, GridView2, Me)
            Gridview2.Columns("code").Visible = False
            XgridColMemo({"Document Name"}, Gridview2)
            XgridColWidth({"Document Name"}, Gridview2, Em_unfiltered.Width)
        End If
    End Sub

    Public Sub ShowfilteredProducts()
        If approverid.Text <> "" Then
            LoadXgrid("select id, (select description from tbldocumenttype where code= tblapprovingattachment.doccode) as 'Document Name' from tblapprovingattachment where appid='" & approverid.Text & "' and trncode='" & txtRequestType.EditValue & "' and apptype='" & LCase(txtProcessType.Text.Replace(" ", "-")) & "' order by appid asc", "tblapprovingattachment", Em_filtered, GridView3, Me)
            GridView3.Columns("id").Visible = False
            XgridColMemo({"Document Name"}, Gridview3)
            XgridColWidth({"Document Name"}, Gridview3, Em_filtered.Width)
        End If
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles cmdMoveRight.Click
        For I = 0 To Gridview2.SelectedRowsCount - 1
            com.CommandText = "insert into tblapprovingattachment set apptype='" & LCase(txtProcessType.Text.Replace(" ", "-")) & "', trncode='" & txtRequestType.EditValue & "', appid='" & approverid.Text & "', doccode='" & GridView2.GetRowCellValue(GridView2.GetSelectedRows(I), "code").ToString & "'" : com.ExecuteNonQuery()
        Next
        ShowUnfilteredProducts()
        ShowfilteredProducts()
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles cmdMoveLeft.Click
        For I = 0 To Gridview3.SelectedRowsCount - 1
            com.CommandText = "delete from tblapprovingattachment where id='" & GridView3.GetRowCellValue(GridView3.GetSelectedRows(I), "id").ToString & "'" : com.ExecuteNonQuery()
        Next
        ShowUnfilteredProducts()
        ShowfilteredProducts()
    End Sub
 
  
    Private Sub tabsettings_SelectedPageChanging(sender As Object, e As DevExpress.XtraTab.TabPageChangingEventArgs) Handles tabsettings.SelectedPageChanging
       
        If txtRequestType.Text = "" Then
            XtraMessageBox.Show("Please select request type!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtRequestType.Focus()
            e.Cancel = True
        End If

    End Sub

    Private Sub ckRequester_CheckedChanged(sender As Object, e As EventArgs) Handles ckRequester.CheckedChanged
        If ckRequester.Checked = True Then
            txtPermission.Enabled = False
            txtPermission.EditValue = Nothing
            approverid.Text = "-"
        Else
            txtPermission.Enabled = True
        End If
        ShowUnfilteredProducts()
        ShowfilteredProducts()
    End Sub
End Class