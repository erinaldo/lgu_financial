Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Base

Public Class frmRealPropertyInfo
    Private ModifyEnable As Boolean
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Insert) Then
            If txtKindofProperty.Focused = True Then
                AddPickTable("kindofproperty", "Kind of Property")
                LoadKindofProperty()

            ElseIf txtClassification.Focused = True Then
                AddPickTable("propertyclasification", "Property Classification")
                LoadClassification()

            ElseIf txtActualUse.Focused = True Then
                AddPickTable("propertyactualuse", "Property Actual Use")
                LoadActualUse()
            End If
        End If
        Return ProcessCmdKey
    End Function

    Private Sub FrmRealPropertyInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico
        ApplySystemTheme(ToolStrip1)
        LoadKindofProperty()
        LoadClassification()
        LoadActualUse()
        LoadAttachmentFile()
        If mode.Text = "edit" Then
            cmdModify.Enabled = True
        Else
            cmdModify.Enabled = False
        End If
    End Sub

    Public Sub LoadKindofProperty()
        LoadPickedDataTable("kindofproperty", txtKindofProperty, gridKindofProperty)
        gridKindofProperty.Columns("id").Visible = False
    End Sub

    Public Sub LoadClassification()
        LoadPickedDataTable("propertyclasification", txtClassification, gridClassification)
        gridClassification.Columns("id").Visible = False
    End Sub

    Public Sub LoadActualUse()
        LoadPickedDataTable("propertyactualuse", txtActualUse, gridActualUse)
        gridActualUse.Columns("id").Visible = False
    End Sub

    Private Sub AddPickTable(ByVal fieldname As String, ByVal caption As String)
        frmDataPicked.fieldname.Text = fieldname
        frmDataPicked.Text = caption & " Table"
        frmDataPicked.ShowDialog(Me)
    End Sub

    Private Sub txtFullname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFullname.KeyPress
        If e.KeyChar = Chr(13) Then
            If RemoveWhiteSpaces(txtFullname.Text, False) = "" Or RemoveWhiteSpaces(txtFullname.Text, False) = "%" Then Exit Sub
            If countqry("tbltaxpayerprofile", "fullname = '" & RemoveWhiteSpaces(txtFullname.Text, False) & "'") = 0 Then

                If countqry("tbltaxpayerprofile", "fullname like '%" & RemoveWhiteSpaces(txtFullname.Text, False) & "%' ") = 0 Then
                    If XtraMessageBox.Show("No match found on your search query! Do you want to add new payors information?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
                        frmTaxPayerInfo.trnmode.Text = "property"
                        frmTaxPayerInfo.ShowDialog(Me)
                        txtCertificateNo.Focus()
                    End If
                Else
                    DXLoadToComboBoxQuery("fullname", "SELECT fullname FROM tbltaxpayerprofile  where fullname like '%" & RemoveWhiteSpaces(txtFullname.Text, False) & "%' order by fullname asc;", txtFullname)
                End If
                txtFullname.ShowPopup()
                Exit Sub
            Else
                LoadCustomerInfo(RemoveWhiteSpaces(txtFullname.Text, False), False)
            End If
        End If

    End Sub

    Public Sub LoadRealPropertyInfo()
        msda = New MySqlDataAdapter("select * from tblrealproperty where id='" & id.Text & "'", conn)
        msda.Fill(dst, 0)
        For cnt = 0 To dst.Tables(0).Rows.Count - 1
            With (dst.Tables(0))
                cifid.Text = .Rows(cnt)("cifid").ToString()
                txtCertificateNo.Text = .Rows(cnt)("certificateno").ToString()
                txtSerialNo.Text = .Rows(cnt)("serialno").ToString()
                txtLotAddress.Text = .Rows(cnt)("lotaddress").ToString()
                txtDateRegistered.EditValue = If(.Rows(cnt)("dateregistered").ToString = "", "", CDate(.Rows(cnt)("dateregistered").ToString))
                txtDateGranted.EditValue = If(.Rows(cnt)("dategranted").ToString = "", "", CDate(.Rows(cnt)("dategranted").ToString))
                txtBookNo.Text = .Rows(cnt)("bookno").ToString()
                txtPageNo.Text = .Rows(cnt)("pageno").ToString()
                txtKindofProperty.EditValue = .Rows(cnt)("kindofproperty").ToString()
                txtClassification.EditValue = .Rows(cnt)("classification").ToString()
                txtActualUse.Text = .Rows(cnt)("actualuse").ToString()
                txtTotalarea.Text = .Rows(cnt)("totalarea").ToString()
                txtLotBlockNo.Text = .Rows(cnt)("lotblockno").ToString()
                txtOrigCertificateNo.Text = .Rows(cnt)("orgcertificateno").ToString()
                txtOrigCaseNo.Text = .Rows(cnt)("orgcaseno").ToString()
                txtOrigDateRegistered.EditValue = If(.Rows(cnt)("orgdateregistered").ToString = "", "", CDate(.Rows(cnt)("orgdateregistered").ToString))
                txtOrigRegistryofDeeds.Text = .Rows(cnt)("orgregistrydeeds").ToString()
                txtOrigVolumeNo.Text = .Rows(cnt)("orgvolumeno").ToString()
                txtOrigOwnersName.Text = .Rows(cnt)("orgownername").ToString()
                txtOrigRecordNo.Text = .Rows(cnt)("orgrecordno").ToString()
                txtOrigDecreeNo.Text = .Rows(cnt)("orgdecreeno").ToString()
                txtOrigPageNo.Text = .Rows(cnt)("orgpageno").ToString()
            End With
        Next
        ModifyEnable = False
        LoadTaxDeclarationHistory()
        LoadAttachmentFile()
        LoadCustomerInfo(cifid.Text, True)
        ReadonlyControls(True)
    End Sub

    Private Sub cmdTaxRefresh_Click(sender As Object, e As EventArgs) Handles cmdTaxRefresh.Click
        LoadTaxDeclarationHistory()
    End Sub

    Public Sub LoadTaxDeclarationHistory()
        LoadXgrid("select id as 'Entry Code', taxdeclarationno as 'Tax Declaration No.',lotarea as 'Lot Area',marketvalue as 'Market Value',assessmentlevel as 'Assessment Level',assessedvalue as 'Assessed Value',Improvement,totalassessedvalue as 'Total Assessed Value', date_format(dateassessed,'%Y-%m-%d') as 'Date Assessed', " _
                    + " basictax as 'Basic Tax',basicpenalty as 'Basic Penalty',totalbasic as 'Total Basic', seftax as 'SEF Tax',sefpenalty as 'SEF Penalty',totalsef as 'Total SEF', totaltaxdue as 'Total Tax Due',date_format(duedate,'%Y-%m-%d') as 'Due Date',Paid,date_format(datepaid,'%Y-%m-%d') as 'Date Paid',ornumber as 'OR Number',paymentmode as 'Payment Mode'," _
                    + " (select fullname from tblaccounts where accountid=a.paymentby) as 'Payment Entered By',date_format(datetrn,'%Y-%m-%d %r') as 'Date Entry', (select fullname from tblaccounts where accountid=a.trnby) as 'Entry By' from tbltaxdeclaration as a where propertyno='" & txtCertificateNo.Text & "'", "tbltaxdeclaration", Em_TaxDeclaration, GridView2, Me)
        XgridHideColumn({"id"}, GridView2)
        XgridColCurrencyDecimalCount({"Lot Area"}, 0, GridView2)
        XgridColCurrency({"Lot Area", "Market Value", "Assessment Level", "Assessed Value", "Improvement", "Total Assessed Value", "Basic Tax", "Basic Penalty", "Total Basic", "SEF Tax", "SEF Penalty", "Total SEF", "Total Tax Due"}, GridView2)
        XgridColAlign({"Entry Code", "Lot Area", "Tax Declaration No.", "Assessment Level", "Date Assessed", "Due Date", "Date Paid", "OR Number", "Date Entry"}, GridView2, DevExpress.Utils.HorzAlignment.Center)
        DXgridColumnIndexing(Me.Name, GridView2)
        XgridGeneralSummaryCurrency({"Basic Tax", "Basic Penalty", "Assessed Value", "Improvement", "Total Assessed Value", "Total Basic", "SEF Tax", "SEF Penalty", "Total SEF", "Total Tax Due"}, GridView2)
        If GridView2.RowCount > 0 Then
            txtCertificateNo.Enabled = False
        Else
            txtCertificateNo.Enabled = True
        End If
    End Sub

    Private Sub GridView2_DragObjectDrop(sender As Object, e As DevExpress.XtraGrid.Views.Base.DragObjectDropEventArgs) Handles GridView2.DragObjectDrop
        XgridColumnDropChanged(GridView2, Me.Name)
    End Sub

    Private Sub GridView2_ColumnWidthChanged(sender As Object, e As ColumnEventArgs) Handles GridView2.ColumnWidthChanged
        XgridColumnWidthChanged(GridView2, Me.Name)
    End Sub

    Public Sub LoadAttachmentFile()
        LoadXgrid("select id,databasename, filename as 'File Name', if(((filesize/1024)/1024)<1, concat(format((filesize/1024),2),' KB'), concat(format(((filesize/1024)/1024),2),' MB')) as 'File Size' from " & sqlfiledir & ".tblattachmentlogs where refnumber='" & txtCertificateNo.Text & "' and trntype='realproperty'", sqlfiledir & ".tblattachmentlogs", Em, GridView1, Me)
        XgridHideColumn({"id", "databasename"}, GridView1)
        XgridColCurrency({"File Size"}, GridView1)
        GridView1.Columns("File Size").Width = 150
        If GridView1.RowCount > 0 Then
            txtCertificateNo.Enabled = False
        Else
            txtCertificateNo.Enabled = True
        End If
    End Sub

    Public Sub LoadCustomerInfo(ByVal parameter As String, ByVal querybyid As Boolean)
        dst = Nothing : dst = New DataSet
        If querybyid = True Then
            msda = New MySqlDataAdapter("select * from tbltaxpayerprofile where cifid='" & parameter & "'", conn)
        Else
            msda = New MySqlDataAdapter("select * from tbltaxpayerprofile where fullname='" & parameter & "'", conn)
        End If
        msda.Fill(dst, 0)
        For cnt = 0 To dst.Tables(0).Rows.Count - 1
            With (dst.Tables(0))
                cifid.Text = .Rows(cnt)("cifid").ToString()
                txtFullname.Text = .Rows(cnt)("fullname").ToString()
                txtTIN.Text = .Rows(cnt)("tin").ToString()
                cmdModify.Enabled = True
            End With
        Next
        If mode.Text = "" Then
            ReadonlyControls(False)
            txtCertificateNo.Focus()
            ModifyEnable = True
        End If
    End Sub

    Public Sub ReadonlyControls(ByVal yes As Boolean)
        txtFullname.ReadOnly = yes
        txtCertificateNo.ReadOnly = yes
        txtSerialNo.ReadOnly = yes
        txtLotAddress.ReadOnly = yes
        txtDateRegistered.ReadOnly = yes
        txtDateGranted.ReadOnly = yes
        txtBookNo.ReadOnly = yes
        txtPageNo.ReadOnly = yes
        txtKindofProperty.ReadOnly = yes
        txtClassification.ReadOnly = yes
        txtActualUse.ReadOnly = yes
        txtTotalarea.ReadOnly = yes
        txtLotBlockNo.ReadOnly = yes
        txtOrigCertificateNo.ReadOnly = yes
        txtOrigCaseNo.ReadOnly = yes
        txtOrigDateRegistered.ReadOnly = yes
        txtOrigRegistryofDeeds.ReadOnly = yes
        txtOrigVolumeNo.ReadOnly = yes
        txtOrigOwnersName.ReadOnly = yes
        txtOrigRecordNo.ReadOnly = yes
        txtOrigDecreeNo.ReadOnly = yes
        txtOrigPageNo.ReadOnly = yes

        If cifid.Text = "" Then
            txtFullname.ReadOnly = False
            cmdModify.Text = "Confirm Save Information"
            cmdModify.ForeColor = Color.Lime
        Else
            If yes = True Then
                cmdTaxAdd.Enabled = False
                cmdTaxEdit.Visible = False
                cmdTaxDelete.Visible = False
                cmdAddAttachment.Visible = False
                cmdDelete.Visible = False
                lineTaxDeclaration.Visible = False
                cmdModify.Text = "Modify Information"
                cmdModify.ForeColor = Color.Gold
            Else
                cmdTaxAdd.Enabled = True
                cmdTaxEdit.Visible = True
                cmdTaxDelete.Visible = True
                cmdAddAttachment.Visible = True
                cmdDelete.Visible = True
                lineTaxDeclaration.Visible = True
                cmdModify.Text = "Confirm Save Information"
                cmdModify.ForeColor = Color.Lime
            End If
        End If
    End Sub

    Private Sub CmdModify_Click(sender As Object, e As EventArgs) Handles cmdModify.Click
        If ModifyEnable = False Then
            If globalAllowEdit = False Then
                XtraMessageBox.Show("Your access not allowed to edit!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
            ReadonlyControls(False)
            ModifyEnable = True
        Else
            If globalAllowAdd = False And mode.Text = "" Then
                XtraMessageBox.Show("Your access not allowed to add!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            ElseIf globalAllowEdit = False And mode.Text = "edit" Then
                XtraMessageBox.Show("Your access not allowed to edit!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
            If cifid.Text = "" Then
                XtraMessageBox.Show("Please select taxpayer! search then hit enter!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtFullname.Focus()
                Exit Sub
            ElseIf txtCertificateNo.Text = "" Then
                XtraMessageBox.Show("Please enter certificate no.!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtCertificateNo.Focus()
                Exit Sub
            ElseIf countqry("tblrealproperty", "certificateno='" & txtCertificateNo.Text & "' and id<>'" & id.Text & "'") > 0 Then
                XtraMessageBox.Show("Property number is already exists!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtCertificateNo.Focus()
                Exit Sub
            End If
            If SaveInfo() = True Then
                ModifyEnable = False
            End If
        End If
    End Sub

    Public Function SaveInfo() As Boolean
        If XtraMessageBox.Show("Are you sure you want to continue? ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            Dim Details As String = " cifid='" & cifid.Text & "', " _
                                         + " certificateno='" & txtCertificateNo.Text & "', " _
                                         + " serialno='" & txtSerialNo.Text & "', " _
                                         + " lotaddress='" & txtLotAddress.Text & "', " _
                                         + If(txtDateRegistered.Text <> "", "dateregistered='" & ConvertDate(txtDateRegistered.EditValue) & "', ", "") _
                                         + If(txtDateGranted.Text <> "", "dategranted='" & ConvertDate(txtDateGranted.EditValue) & "', ", "") _
                                         + " bookno='" & txtBookNo.Text & "', " _
                                         + " pageno='" & txtPageNo.Text & "', " _
                                         + " kindofproperty='" & txtKindofProperty.EditValue & "', " _
                                         + " classification='" & txtClassification.EditValue & "', " _
                                         + " actualuse='" & txtActualUse.EditValue & "', " _
                                         + " totalarea='" & Val(txtTotalarea.EditValue) & "', " _
                                         + " lotblockno='" & txtLotBlockNo.Text & "', " _
                                         + " orgcertificateno='" & txtOrigCertificateNo.Text & "', " _
                                         + " orgcaseno='" & txtOrigCaseNo.Text & "', " _
                                          + If(txtOrigDateRegistered.Text <> "", "orgdateregistered='" & ConvertDate(txtOrigDateRegistered.EditValue) & "', ", "") _
                                         + " orgregistrydeeds='" & txtOrigRegistryofDeeds.Text & "', " _
                                         + " orgvolumeno='" & txtOrigVolumeNo.Text & "', " _
                                         + " orgownername='" & txtOrigOwnersName.Text & "', " _
                                         + " orgrecordno='" & txtOrigRecordNo.Text & "', " _
                                         + " orgdecreeno='" & txtOrigDecreeNo.Text & "', " _
                                         + " orgpageno='" & txtOrigPageNo.Text & "', "
            If mode.Text = "edit" Then
                com.CommandText = "UPDATE `tblrealproperty` set  " & Details & " " _
                                 + " dateupdated=current_timestamp, " _
                                 + " updateby='" & globaluserid & "' where id='" & id.Text & "'" : com.ExecuteNonQuery()
            Else
                com.CommandText = "INSERT INTO `tblrealproperty` set  " & Details _
                                 + " datetrn=current_timestamp, " _
                                 + " trnby='" & globaluserid & "'" : com.ExecuteNonQuery()
            End If
            ClearInformation()
            XtraMessageBox.Show("Record successfully saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return True
        End If
        Return False
    End Function

    Public Sub ClearInformation()
        cifid.Text = ""
        txtFullname.Text = ""
        txtTIN.Text = ""
        txtCertificateNo.Text = ""
        txtSerialNo.Text = ""
        txtLotAddress.Text = ""
        txtDateRegistered.EditValue = Nothing
        txtDateGranted.EditValue = Nothing
        txtBookNo.Text = ""
        txtPageNo.Text = ""
        txtKindofProperty.EditValue = Nothing
        txtClassification.EditValue = Nothing
        txtActualUse.EditValue = Nothing
        txtTotalarea.Text = "0"
        txtLotBlockNo.Text = ""
        txtOrigCertificateNo.Text = ""
        txtOrigCaseNo.Text = ""
        txtOrigDateRegistered.EditValue = Nothing
        txtOrigRegistryofDeeds.Text = ""
        txtOrigVolumeNo.Text = ""
        txtOrigOwnersName.Text = ""
        txtOrigRecordNo.Text = ""
        txtOrigDecreeNo.Text = ""
        txtOrigPageNo.Text = ""
        id.Text = ""
        mode.Text = ""
        txtFullname.Focus()
        cmdModify.Enabled = False
        LoadTaxDeclarationHistory()
        LoadAttachmentFile()
        ReadonlyControls(True)
    End Sub

    Private Sub CmdLocalData_Click(sender As Object, e As EventArgs) Handles cmdLocalData.Click
        LoadAttachmentFile()
    End Sub

    Private Sub cmdAddAttachment_Click(sender As Object, e As EventArgs) Handles cmdAddAttachment.Click
        If globalAllowAdd = False Then
            XtraMessageBox.Show("Your access not allowed to add!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        ElseIf txtCertificateNo.Text = "" Then
            XtraMessageBox.Show("Please enter certificate no.!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtCertificateNo.Focus()
            Exit Sub
        End If
        frmFileUploader.trncode.Text = txtCertificateNo.Text
        frmFileUploader.trntype.Text = "realproperty"
        frmFileUploader.ShowDialog(Me)
        LoadAttachmentFile()
    End Sub

    Private Sub CmdCancel_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
        If globalAllowDelete = False Then
            XtraMessageBox.Show("Your access not allowed to delete!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        If GridView1.SelectedRowsCount > 0 Then
            If XtraMessageBox.Show("Are you sure you want to permanently remove selected item? ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                Dim I As Integer = 0
                For I = 0 To GridView1.SelectedRowsCount - 1
                    com.CommandText = "delete from " & sqlfiledir & "." & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "databasename") & " where filename='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "File Name") & "' and refnumber='" & txtCertificateNo.Text & "'" : com.ExecuteNonQuery()
                    com.CommandText = "delete from " & sqlfiledir & ".tblattachmentlogs where filename='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "File Name") & "' and refnumber='" & txtCertificateNo.Text & "'" : com.ExecuteNonQuery()
                Next
                LoadAttachmentFile()
            End If
        End If
    End Sub

   
    Private Sub ViewSelectFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles cmdViewAttachement.Click
        If GridView1.SelectedRowsCount > 0 Then
            Dim list As New ArrayList
            For I = 0 To GridView1.SelectedRowsCount - 1

                list.Add(GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "id").ToString())
            Next
            ViewAttachmentPackage_Individual(list.ToArray)
        End If
    End Sub

 
    Private Sub cmdTaxEdit_Click(sender As Object, e As EventArgs) Handles cmdTaxEdit.Click
        If globalAllowEdit = False Then
            XtraMessageBox.Show("Your access not allowed to edit!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        If GridView2.SelectedRowsCount > 0 Then
            frmTaxDeclarationInfo.mode.Text = "edit"
            frmTaxDeclarationInfo.id.Text = GridView2.GetFocusedRowCellValue("Entry Code").ToString
            If frmTaxDeclarationInfo.Visible = False Then
                frmTaxDeclarationInfo.Show(Me)
            Else
                frmTaxDeclarationInfo.Focus()
            End If
        End If
    End Sub

    Private Sub cmdTaxDelete_Click(sender As Object, e As EventArgs) Handles cmdTaxDelete.Click
        If globalAllowDelete = False Then
            XtraMessageBox.Show("Your access not allowed to delete!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        If GridView2.SelectedRowsCount > 0 Then
            If XtraMessageBox.Show("Are you sure you want to permanently remove selected item? ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                Dim I As Integer = 0
                For I = 0 To GridView2.SelectedRowsCount - 1
                    com.CommandText = "delete from tbltaxdeclaration where id='" & GridView2.GetRowCellValue(GridView2.GetSelectedRows(I), "Entry Code") & "' " : com.ExecuteNonQuery()
                Next
                LoadTaxDeclarationHistory()
            End If
        End If
    End Sub

    Private Sub cmdColumnSettings_Click(sender As Object, e As EventArgs) Handles cmdColumnSettings.Click
        Dim colname As String = ""
        For I = 0 To GridView2.Columns.Count - 1
            colname += GridView2.Columns(I).FieldName & ","
        Next
        frmColumnFilter.txtColumn.Text = colname.Remove(colname.Count - 1, 1)
        frmColumnFilter.GetFilterInfo(GridView2, Me.Text)
        frmColumnFilter.ShowDialog(Me)
    End Sub

    Private Sub cmdTaxAdd_Click(sender As Object, e As EventArgs) Handles cmdTaxAdd.Click
        If globalAllowAdd = False Then
            XtraMessageBox.Show("Your access not allowed to add!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        ElseIf txtCertificateNo.Text = "" Then
            XtraMessageBox.Show("Please enter property no!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        frmTaxDeclarationInfo.txtlotarea.Text = txtTotalarea.EditValue
        frmTaxDeclarationInfo.txtpropertyno.Text = txtCertificateNo.Text
        frmTaxDeclarationInfo.cifid.Text = cifid.Text
        If frmTaxDeclarationInfo.Visible = False Then
            frmTaxDeclarationInfo.Show(Me)
        Else
            frmTaxDeclarationInfo.Focus()
        End If
    End Sub

   
    Private Sub mode_EditValueChanged(sender As Object, e As EventArgs) Handles mode.EditValueChanged
        If mode.Text = "edit" Then
            LoadRealPropertyInfo()
        End If
    End Sub

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        frmTaxPayerInfo.trnmode.Text = "property"
        frmTaxPayerInfo.ShowDialog(Me)
        txtCertificateNo.Focus()
    End Sub
End Class