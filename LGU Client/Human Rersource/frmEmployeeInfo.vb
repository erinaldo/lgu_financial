Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors
Imports System.IO
Imports System.Text.RegularExpressions
Imports DevExpress.XtraGrid.Views.Grid
Imports MySql.Data.MySqlClient

Public Class frmEmployeeInfo

    Private Sub frmEmployeeInformation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico
        loadAssignedOffice()

        LoadPickedDataTable("cardtype", txtCardType, gvCardType)
        LoadCards()

        LoadPickedDataTable("schoolname", txtSchoolName, gvSchoolName)
        LoadPickedDataTable("course", txtCourse, gvCourse)
        LoadEducation()

        LoadPickedDataTable("companyname", txtSRCompany, gvCompanyName)
        LoadPickedDataTable("branchname", txtSRBranch, gvBranch)
        LoadPickedDataTable("position", txtSRDesignation, gvWorkPosition)
        LoadPickedDataTable("emp_status", txtSRStatus, gvSRStatus)
        LoadPickedDataTable("emp_base_rate", txtSRSalaryBase, gvSRSalaryBase)
        LoadPickedDataTable("sep_cause", txtSRSeparationCause, gvSeparationCause)
        LoadWork()

        LoadPickedDataTable("certificateissuedfrom", txtCertIssuedFrom, gvCertIssuedFrom)
        LoadPickedDataTable("typeofcertificate", txtTypeOfCertificate, gvtypeofcertificate)
        loadCertificate()

        LoadPickedDataTable("emp_title", txtTitle, gvTitle)
        LoadPickedDataTable("birth_place", txtBirthPlace, gvBirthPlace)
        LoadPickedDataTable("religion", txtreligion, gvReligion)
        LoadPickedDataTable("nationality", txtnationality, gvNationality)

        LoadPickedDataTable("designation", txtDesignation, gvDesignation)
        LoadPickedDataTable("emp_type", txtEmployeeType, gvEmployeeType)
        LoadPickedDataTable("emp_level", txtPositionLevel, gvPositionLevel)
        LoadPickedDataTable("emp_base_rate", txtBaseRatePay, gvBaseRatePay)

        LoadPickedDataTable("emp_rate", txtBasicRate, gvBasicRate)

        'DXLoadToComboBox("civilstatus", "tblemployees where civilstatus<>''", txtCivilStatus, True)

        DXLoadToComboBox("lv_abs_wpay", "tblemployeeservice where lv_abs_wpay<>''", txtSRLVABS, True)

        DXLoadToComboBox("per_add_purok", "tblemployees where per_add_purok<>''", txtPer_Add_purok, True)
        DXLoadToComboBox("per_add_brgy", "tblemployees where per_add_brgy<>''", txtPer_Add_Brgy, True)
        DXLoadToComboBox("per_add_city", "tblemployees where per_add_city<>''", txtPer_Add_City, True)
        DXLoadToComboBox("per_add_prov", "tblemployees where per_add_prov<>''", txtPer_Add_Prov, True)

        DXLoadToComboBox("cur_add_purok", "tblemployees where cur_add_purok<>''", txtCur_Add_Purok, True)
        DXLoadToComboBox("cur_add_brgy", "tblemployees where cur_add_brgy<>''", txtCur_Add_Brgy, True)
        DXLoadToComboBox("cur_add_city", "tblemployees where cur_add_city<>''", txtCur_Add_City, True)
        DXLoadToComboBox("cur_add_prov", "tblemployees where cur_add_prov<>''", txtCur_Add_Prov, True)

        If mode.Text = "edit" Then
            showInformation(id.Text)
        Else
            id.Text = GetTransactionSeries("employee_series")
        End If

    End Sub
    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Me.Close()
    End Sub


    Public Sub loadAssignedOffice()
        LoadXgridLookupSearch("select officeid as code, officename as 'Select' from tblcompoffice where deleted=0 order by officename", "tblcompoffice", txtAssignOffice, gv_assignoffice)
        gv_assignoffice.Columns("code").Visible = False
    End Sub

    Private Sub ckEnableContractPeriod_CheckedChanged(sender As Object, e As EventArgs) Handles ckEnableContractPeriod.CheckedChanged
        If ckEnableContractPeriod.Checked = True Then
            txtContractstartdate.Enabled = True
            txtContractenddate.Enabled = True
        Else
            txtContractstartdate.Enabled = False
            txtContractenddate.Enabled = False
            txtContractstartdate.Text = ""
            txtContractenddate.Text = ""
        End If
    End Sub

#Region "EMPLOYEE INFO"
    Private Sub cmdSaveDirect_Click(sender As Object, e As EventArgs) Handles cmdSaveDirect.Click
        If TrapInfo() Then
            SaveInfo()
        End If
    End Sub

    Public Sub SaveInfo()
        Dim query As String = " title='" & rchar(txtTitle.Text) & "', " _
                               + " lastname='" & rchar(txtlastname.Text) & "', " _
                               + " firstname='" & rchar(txtFistname.Text) & "', " _
                               + " middlename='" & rchar(txtmiddlename.Text) & "', " _
                               + " fullname='" & rchar(txtfullname.Text) & "', " _
                               + " extname='" & rchar(txtExtname.Text) & "', " _
                               + " nickname='" & rchar(txtnickname.Text) & "', " _
                               + If(txtBirthdate.Text <> "", "birthdate='" & ConvertDate(txtBirthdate.EditValue) & "', ", ", birthdate=null ") & " " _
                               + " birthplace='" & rchar(txtBirthPlace.EditValue) & "', " _
                               + " nationality='" & rchar(txtnationality.EditValue) & "', " _
                               + " religion='" & rchar(txtreligion.EditValue) & "', " _
                               + " gender='" & rchar(txtGender.Text) & "', " _
                               + " civilstatus='" & rchar(txtCivilStatus.Text) & "', " _
                               + " spousename='" & rchar(txtSpouseName.Text) & "', " _
                               + " height='" & rchar(txtHeight.Text) & "', " _
                               + " weight='" & rchar(txtWeight.Text) & "', " _
                               + " per_add_purok='" & rchar(txtPer_Add_purok.Text) & "', " _
                               + " per_add_brgy='" & rchar(txtPer_Add_Brgy.Text) & "', " _
                               + " per_add_city='" & rchar(txtPer_Add_City.Text) & "', " _
                               + " per_add_prov='" & rchar(txtPer_Add_Prov.Text) & "', " _
                               + " cur_add_purok='" & rchar(txtCur_Add_Purok.Text) & "', " _
                               + " cur_add_brgy='" & rchar(txtCur_Add_Brgy.Text) & "', " _
                               + " cur_add_city='" & rchar(txtCur_Add_City.Text) & "', " _
                               + " cur_add_prov='" & rchar(txtCur_Add_Prov.Text) & "', " _
                               + " contactnumber='" & txtContactnumber.Text & "', " _
                               + " homenumber='" & txthomenumber.Text & "', " _
                               + " emailaddress='" & txtemailaddress.Text & "', " _
                               + " inc_cont_person='" & rchar(txtInc_Cont_Person.Text) & "', " _
                               + " inc_cont_number='" & rchar(txtInc_Cont_Number.Text) & "', " _
                               + " inc_cont_address='" & rchar(txtInc_Cont_Address.Text) & "', " _
                               + " officeid='" & txtAssignOffice.EditValue & "', " _
                               + " designation='" & txtDesignation.EditValue & "', " _
                               + " employeetype='" & txtEmployeeType.EditValue & "', " _
                               + " positionlevel='" & txtPositionLevel.EditValue & "', " _
                               + " baseratepay='" & txtBaseRatePay.EditValue & "', " _
                               + " basicrate='" & txtBasicRate.EditValue & "', " _
                               + " contractperiod='" & ckEnableContractPeriod.CheckState & "', " _
                               + " datehired='" & ConvertDate(txtdatehired.Text) & "', " _
                               + " resigned='" & ckResigned.CheckState & "', " _
                               + If(ckResigned.Checked, " dateresigned ='" & ConvertDate(txtDateResigned.Text) & "', ", "dateresigned=null, ") _
                               + " retired='" & ckRetired.CheckState & "', " _
                               + If(ckRetired.Checked, " dateretired ='" & ConvertDate(txtDateResigned.Text) & "' ", "dateretired=null ") _
                               + If(txtDateRegular.Text = "", ", dateregular=null", ", dateregular='" & ConvertDate(txtDateRegular.EditValue) & "'") _
                               + If(ckEnableContractPeriod.Checked = False, ",contractstartdate=null, contractenddate=null ", ", contractstartdate='" & ConvertDate(txtContractstartdate.EditValue) & "', contractenddate='" & ConvertDate(txtContractenddate.EditValue) & "'")
        Dim employeeid As String = ""
        If countqry("tblemployees", "id='" & id.Text & "'") = 0 Then
            If txtEmployeeId.Text = "SYSTEM GENERATED" Or txtEmployeeId.Text = "" Then
                employeeid = GetTransactionSeries("employee_id")
                txtEmployeeId.Text = employeeid
            Else
                employeeid = txtEmployeeId.Text
            End If
            com.CommandText = "INSERT INTO tblemployees set id='" & id.Text & "', employeeid='" & employeeid & "', " & query & ", dateregistered=current_timestamp, registeredby='" & globaluserid & "'; " : com.ExecuteNonQuery()
        Else
            com.CommandText = "UPDATE tblemployees set employeeid='" & txtEmployeeId.Text & "', " & query & ", dateupdated=current_timestamp, updatedby='" & globaluserid & "' where id='" & id.Text & "' " : com.ExecuteNonQuery()
        End If

        If countqry("tblemployeepic", "employeeid='" & id.Text & "'") = 0 Then
            com.CommandText = "INSERT INTO tblemployeepic set employeeid='" & id.Text & "'" : com.ExecuteNonQuery()
            DXUpdateImage("employeeid='" & id.Text & "'", "img", "tblemployeepic", ProfilePic, Me)
        Else
            DXUpdateImage("employeeid='" & id.Text & "'", "img", "tblemployeepic", ProfilePic, Me)
        End If

        XtraMessageBox.Show("Employee information successfuly saved!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Public Sub showInformation(ByVal id As String)
        Try
            msda = Nothing : dst = New DataSet
            msda = New MySqlDataAdapter("select *, (select img from tblemployeepic where employeeid=a.id) as img from tblemployees as a where id='" & id & "'", conn)
            msda.Fill(dst, 0)
            For cnt = 0 To dst.Tables(0).Rows.Count - 1
                With (dst.Tables(0))
                    txtEmployeeId.Text = .Rows(cnt)("employeeid").ToString
                    txtTitle.Text = .Rows(cnt)("title").ToString
                    txtlastname.Text = .Rows(cnt)("lastname").ToString
                    txtFistname.Text = .Rows(cnt)("firstname").ToString
                    txtmiddlename.Text = .Rows(cnt)("middlename").ToString
                    txtfullname.Text = .Rows(cnt)("fullname").ToString
                    txtExtname.Text = .Rows(cnt)("extname").ToString
                    txtnickname.Text = .Rows(cnt)("nickname").ToString
                    txtBirthdate.EditValue = If(.Rows(cnt)("birthdate").ToString = "", "", CDate(.Rows(cnt)("birthdate").ToString))
                    txtBirthPlace.EditValue = .Rows(cnt)("birthplace").ToString
                    txtnationality.EditValue = .Rows(cnt)("nationality").ToString
                    txtreligion.EditValue = .Rows(cnt)("religion").ToString
                    txtGender.Text = .Rows(cnt)("gender").ToString
                    txtSpouseName.Text = .Rows(cnt)("spousename").ToString
                    txtCivilStatus.Text = .Rows(cnt)("civilstatus").ToString

                    txtHeight.Text = .Rows(cnt)("height").ToString
                    txtWeight.Text = .Rows(cnt)("weight").ToString

                    txtPer_Add_purok.Text = .Rows(cnt)("per_add_purok").ToString
                    txtPer_Add_Brgy.Text = .Rows(cnt)("per_add_brgy").ToString
                    txtPer_Add_City.Text = .Rows(cnt)("per_add_city").ToString
                    txtPer_Add_Prov.Text = .Rows(cnt)("per_add_prov").ToString

                    txtCur_Add_Purok.Text = .Rows(cnt)("cur_add_purok").ToString
                    txtCur_Add_Brgy.Text = .Rows(cnt)("cur_add_brgy").ToString
                    txtCur_Add_City.Text = .Rows(cnt)("cur_add_city").ToString
                    txtCur_Add_Prov.Text = .Rows(cnt)("cur_add_prov").ToString
                    txtContactnumber.Text = .Rows(cnt)("contactnumber").ToString
                    txthomenumber.Text = .Rows(cnt)("homenumber").ToString
                    txtemailaddress.Text = .Rows(cnt)("emailaddress").ToString
                    txtInc_Cont_Person.Text = .Rows(cnt)("inc_cont_person").ToString
                    txtInc_Cont_Number.Text = .Rows(cnt)("inc_cont_number").ToString
                    txtInc_Cont_Address.Text = .Rows(cnt)("inc_cont_address").ToString

                    txtAssignOffice.EditValue = .Rows(cnt)("officeid").ToString
                    txtDesignation.EditValue = .Rows(cnt)("designation").ToString
                    txtEmployeeType.EditValue = .Rows(cnt)("employeetype").ToString
                    txtPositionLevel.EditValue = .Rows(cnt)("positionlevel").ToString
                    txtBaseRatePay.EditValue = .Rows(cnt)("baseratepay").ToString
                    txtBasicRate.Text = .Rows(cnt)("basicrate").ToString

                    ckEnableContractPeriod.Checked = .Rows(cnt)("contractperiod")
                    txtContractstartdate.EditValue = If(.Rows(cnt)("contractstartdate").ToString = "", "", CDate(.Rows(cnt)("contractstartdate").ToString))
                    txtContractenddate.EditValue = If(.Rows(cnt)("contractenddate").ToString = "", "", CDate(.Rows(cnt)("contractenddate").ToString))
                    txtdatehired.EditValue = If(.Rows(cnt)("datehired").ToString = "", "", CDate(.Rows(cnt)("datehired").ToString))
                    txtDateRegular.EditValue = If(.Rows(cnt)("dateregular").ToString = "", "", CDate(.Rows(cnt)("dateregular").ToString))

                    ckResigned.Checked = .Rows(cnt)("resigned")
                    ckRetired.Checked = .Rows(cnt)("retired")
                    txtDateResigned.EditValue = If(.Rows(cnt)("dateresigned").ToString = "", "", CDate(.Rows(cnt)("dateresigned").ToString))
                    txtDateRetired.EditValue = If(.Rows(cnt)("dateretired").ToString = "", "", CDate(.Rows(cnt)("dateretired").ToString))


                    If .Rows(cnt)("img").ToString <> "" Then
                        imgBytes = CType(.Rows(cnt)("img"), Byte())
                        stream = New MemoryStream(imgBytes, 0, imgBytes.Length)
                        img = Image.FromStream(stream)
                        ProfilePic.Image = img
                    End If
                End With
            Next
            LoadCards()
            LoadEducation()
            LoadWork()
            loadCertificate()
        Catch errMYSQL As MySqlException
            XtraMessageBox.Show("Message:" & errMYSQL.Message & vbCrLf,
                             "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch errMS As Exception
            XtraMessageBox.Show("Message:" & errMS.Message & vbCrLf,
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub txtlastname_EditValueChanged(sender As Object, e As EventArgs) Handles txtlastname.EditValueChanged
        getFullname()
    End Sub

    Private Sub txtFistname_EditValueChanged(sender As Object, e As EventArgs) Handles txtFistname.EditValueChanged
        getFullname()
    End Sub

    Private Sub txtmiddlename_EditValueChanged(sender As Object, e As EventArgs) Handles txtmiddlename.EditValueChanged
        getFullname()
    End Sub

    Private Sub txtExtname_EditValueChanged(sender As Object, e As EventArgs) Handles txtExtname.EditValueChanged
        getFullname()
    End Sub
    Public Sub getFullname()
        Dim midlename As String = "" : Dim extentionname As String = ""
        If txtmiddlename.Text <> "" Then
            midlename = " " & txtmiddlename.Text
        Else
            midlename = ""
        End If
        If txtExtname.Text <> "" Then
            extentionname = " " & txtExtname.Text
        Else
            extentionname = ""
        End If
        If txtlastname.Text <> "" And txtFistname.Text <> "" Then
            txtfullname.Text = txtlastname.Text & ", " & txtFistname.Text & midlename & extentionname
        End If
    End Sub

    Private Sub signature_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ProfilePic.Validating
        resizesignature()
    End Sub

    Public Sub resizesignature()
        If ProfilePic.Image Is Nothing Then Exit Sub
        Dim Original As New Bitmap(ProfilePic.Image)
        ProfilePic.Image = Original

        Dim m As Int32 = 400
        Dim n As Int32 = m * Original.Height / Original.Width

        Dim Thumb As New Bitmap(m, n, Original.PixelFormat)
        Thumb.SetResolution(Original.HorizontalResolution, Original.VerticalResolution)

        Dim g As Graphics = Graphics.FromImage(Thumb)
        g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High

        g.DrawImage(Original, New Rectangle(0, 0, m, n))
        ProfilePic.Image = Thumb
    End Sub


    Public Function TrapInfo()
        If mode.Text = "edit" And txtEmployeeId.Text = "" Then
            MessageBox.Show("Employee ID cannot be blank!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtEmployeeId.Focus()
            Return False
        ElseIf txtTitle.Text = "" Then
            MessageBox.Show("Please select title!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtTitle.Focus()
            Return False
        ElseIf txtlastname.Text = "" Then
            MessageBox.Show("Please enter lastname!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtlastname.Focus()
            Return False
        ElseIf txtFistname.Text = "" Then
            MessageBox.Show("Please enter firstname!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtFistname.Focus()
            Return False
        ElseIf txtmiddlename.Text = "" Then
            MessageBox.Show("Please enter middle name!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtmiddlename.Focus()
            Return False
        ElseIf txtBirthdate.Text = "" Then
            MessageBox.Show("Please select birthdate!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtBirthdate.Focus()
            Return False
        ElseIf txtBirthPlace.Text = "" Then
            MessageBox.Show("Please select birth place!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtBirthPlace.Focus()
            Return False
        ElseIf txtGender.Text = "" Then
            MessageBox.Show("Please select gender!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtGender.Focus()
            Return False
        ElseIf txtCivilStatus.Text = "" Then
            MessageBox.Show("Please select civil status!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtCivilStatus.Focus()
            Return False
        ElseIf txtAssignOffice.Text = "" Then
            MessageBox.Show("Please select Office!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtAssignOffice.Focus()
            Return False
        ElseIf txtEmployeeType.Text = "" Then
            MessageBox.Show("Please select Employee Type !", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtEmployeeType.Focus()
            Return False
        ElseIf txtDesignation.Text = "" Then
            MessageBox.Show("Please select Position!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtDesignation.Focus()
            Return False
        ElseIf txtdatehired.Text = "" Then
            MessageBox.Show("Please enter Date Hired!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtdatehired.Focus()
            Return False
        ElseIf ckEnableContractPeriod.Checked = True And txtContractstartdate.Text = "" Then
            MessageBox.Show("Please enter Contract Start Date!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtContractstartdate.Focus()
            Return False
        ElseIf ckEnableContractPeriod.Checked = True And txtContractenddate.Text = "" Then
            MessageBox.Show("Please enter Contract End Date!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtContractenddate.Focus()
            Return False
        End If

        Return True
    End Function
#End Region

#Region "CARD"

    Private Sub HyperlinkLabelControl5_Click(sender As Object, e As EventArgs) Handles HyperlinkLabelControl5.Click
        frmDataPicked.fieldname.Text = "cardtype"
        frmDataPicked.Text = "Card Type"
        frmDataPicked.ShowDialog(Me)
        LoadPickedDataTable("cardtype", txtCardType, gvCardType)
    End Sub

    Public Sub LoadCards()
        LoadXgrid("select id, (select description from tbldatapicked where id=tblemployeecard.cardtype) as 'Card Type', cardnumber as 'Card Number',  " _
                  + " date_format(dateexpired,'%Y-%m-%d') as 'Date Expired', if(date_format(dateexpired,'%Y-%m-%d') > current_date, 'Expired','Active') as Status, " _
                  + " ifnull((select if(count(*)>0,cast(concat(count(*), ' File(s) Attached') as char),null) from " & sqlfiledir & ".tblattachmentlogs where refnumber = tblemployeecard.id and trntype='emp_card'),'-') as 'Attachment' " _
                  + " from tblemployeecard where employeeid='" & id.Text & "' order by dateexpired desc", "tblemployeecard", gridCard, g_card, Me)
        g_card.Columns("id").Visible = False
        XgridColAlign({"Education Type", "Period From", "Period To", "Attachment"}, g_card, DevExpress.Utils.HorzAlignment.Center)
    End Sub


    Private Sub cmdSaveCard_Click(sender As Object, e As EventArgs) Handles cmdSaveCard.Click
        If txtCardType.Text = "" Then
            XtraMessageBox.Show("Please select card type", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtSchoolName.Focus()
            Exit Sub
        ElseIf txtCardNumber.Text = "" Then
            XtraMessageBox.Show("Please select course", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtCourse.Focus()
            Exit Sub

        ElseIf ckCardExpiry.Checked = True And txtCardExpiry.Text = "" Then
            XtraMessageBox.Show("Please select expiry date", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtCourse.Focus()
            Exit Sub

        End If
        If mode_card.Text = "edit" Then
            com.CommandText = "UPDATE tblemployeecard set employeeid='" & id.Text & "', cardtype='" & txtCardType.EditValue & "',cardnumber='" & txtCardNumber.Text & "', withexpiry=" & ckCardExpiry.CheckState & If(txtCardExpiry.Text = "", "", ", dateexpired='" & ConvertDate(txtCardExpiry.EditValue) & "'") & " where id='" & id_card.Text & "'" : com.ExecuteNonQuery()
        Else
            com.CommandText = "INSERT INTO tblemployeecard set employeeid='" & id.Text & "', cardtype='" & txtCardType.EditValue & "',cardnumber='" & txtCardNumber.Text & "', withexpiry=" & ckCardExpiry.CheckState & If(txtCardExpiry.Text = "", "", ", dateexpired='" & ConvertDate(txtCardExpiry.EditValue) & "'") : com.ExecuteNonQuery()
        End If
        ClearCardInfo() : LoadCards()
        XtraMessageBox.Show("Card successfuly saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Public Sub ClearCardInfo()
        txtCardType.EditValue = Nothing
        txtCardNumber.Text = ""
        ckCardExpiry.Checked = False
        txtCardExpiry.EditValue = Nothing
    End Sub

    Public Sub ShowCardInfo()
        com.CommandText = "select * from tblemployeecard where id ='" & id_card.Text & "'" : rst = com.ExecuteReader()
        While rst.Read
            txtCardType.EditValue = rst("cardtype").ToString
            txtCardNumber.Text = rst("cardnumber").ToString
            ckCardExpiry.Checked = CBool(rst("withexpiry").ToString)
            txtCardExpiry.EditValue = If(rst("dateexpired").ToString = "", Nothing, rst("dateexpired").ToString)
        End While
        rst.Close()
    End Sub

#End Region

#Region "SCHOOL"

    Private Sub HyperlinkLabelControl2_Click(sender As Object, e As EventArgs) Handles HyperlinkLabelControl2.Click
        frmDataPicked.fieldname.Text = "schoolname"
        frmDataPicked.Text = "School Name"
        frmDataPicked.ShowDialog(Me)
        LoadPickedDataTable("schoolname", txtSchoolName, gvSchoolName)
    End Sub

    Private Sub HyperlinkLabelControl3_Click(sender As Object, e As EventArgs) Handles lblCourse.Click
        frmDataPicked.fieldname.Text = "course"
        frmDataPicked.Text = "Course"
        frmDataPicked.ShowDialog(Me)
        LoadPickedDataTable("course", txtCourse, gvCourse)
    End Sub

    Public Sub LoadEducation()
        LoadXgrid("select id, educationtype as 'Degree', " _
                  + " (select description from tbldatapicked where fieldname='schoolname' and id=tblemployeeeducation.schoolid) as 'School Name', " _
                  + " (select description from tbldatapicked where fieldname='course' and id=tblemployeeeducation.courseid) as 'Course', " _
                  + " date_format(datefrom,'%Y-%m-%d') as 'Period From', date_format(dateto,'%Y-%m-%d') as 'Period To', " _
                  + " ifnull((select if(count(*)>0,cast(concat(count(*), ' File(s) Attached') as char),null) from " & sqlfiledir & ".tblattachmentlogs where refnumber = tblemployeeeducation.id and trntype='emp_education'),'-') as 'Attachment' " _
                  + " from tblemployeeeducation where employeeid='" & id.Text & "' order by schoollevel desc", "tblemployeeeducation", gridEducation, g_education, Me)
        g_education.Columns("id").Visible = False
        XgridColAlign({"Education Type", "Period From", "Period To", "Attachment"}, g_education, DevExpress.Utils.HorzAlignment.Center)
    End Sub
    Private Sub ComboBoxEdit1_SelectedValueChanged(sender As Object, e As EventArgs) Handles txtEducType.SelectedValueChanged
        If txtEducType.SelectedIndex >= 3 Then
            txtCourse.Enabled = True
            lblCourse.Enabled = True
        Else
            txtCourse.Enabled = False
            lblCourse.Enabled = False
        End If
    End Sub

    Private Sub cmdEducation_Click(sender As Object, e As EventArgs) Handles cmdEducation.Click
        If txtSchoolName.Text = "" Then
            XtraMessageBox.Show("Please select school name", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtSchoolName.Focus()
            Exit Sub
        ElseIf txtEducType.SelectedIndex >= 3 And txtCourse.Text = "" Then
            XtraMessageBox.Show("Please select course", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtCourse.Focus()
            Exit Sub

        End If
        If mode_education.Text = "edit" Then
            com.CommandText = "UPDATE tblemployeeeducation set educationtype='" & txtEducType.Text & "',schoollevel='" & txtEducType.SelectedIndex & "', employeeid='" & id.Text & "', schoolid='" & txtSchoolName.EditValue & "',courseid='" & If(txtEducType.SelectedIndex = 3 Or txtEducType.SelectedIndex = 4, txtCourse.EditValue, "") & "' " & If(txtDateFrom.Text = "", "", ", datefrom='" & ConvertDate(txtDateFrom.EditValue) & "'") & " " & If(txtDateFrom.Text = "", "", ", dateto='" & ConvertDate(txtDateTo.EditValue) & "'") & " where id='" & id_education.Text & "'" : com.ExecuteNonQuery()
        Else
            com.CommandText = "INSERT INTO tblemployeeeducation set educationtype='" & txtEducType.Text & "',schoollevel='" & txtEducType.SelectedIndex & "', employeeid='" & id.Text & "', schoolid='" & txtSchoolName.EditValue & "',courseid='" & If(txtEducType.SelectedIndex = 3 Or txtEducType.SelectedIndex = 4, txtCourse.EditValue, "") & "' " & If(txtDateFrom.Text = "", "", ", datefrom='" & ConvertDate(txtDateFrom.EditValue) & "'") & " " & If(txtDateFrom.Text = "", "", ", dateto='" & ConvertDate(txtDateTo.EditValue) & "'") & "" : com.ExecuteNonQuery()
        End If
        ClearEducationArea() : LoadEducation()
        XtraMessageBox.Show("Education successfuly saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Public Sub ClearEducationArea()
        txtSchoolName.Text = Nothing

        txtCourse.Text = Nothing

        txtDateFrom.EditValue = Nothing
        txtDateTo.EditValue = Nothing
        id_education.Text = ""
        mode_education.Text = ""
    End Sub

    Public Sub ShowEducationInfo()
        com.CommandText = "select * from tblemployeeeducation where id ='" & id_education.Text & "'" : rst = com.ExecuteReader()
        While rst.Read
            txtEducType.SelectedIndex = rst("schoollevel").ToString
            txtSchoolName.EditValue = rst("schoolid").ToString
            txtCourse.EditValue = rst("courseid").ToString
            txtDateFrom.EditValue = rst("datefrom").ToString
            txtDateTo.EditValue = rst("datefrom").ToString
        End While
        rst.Close()
    End Sub


#End Region

#Region "WORK"
    Private Sub lblCompanyName_Click(sender As Object, e As EventArgs) Handles lblCompanyName.Click
        frmDataPicked.fieldname.Text = "companyname"
        frmDataPicked.Text = "Company Name"
        frmDataPicked.ShowDialog(Me)
        LoadPickedDataTable("companyname", txtSRCompany, gvCompanyName)
    End Sub
    Private Sub lblBranch_Click(sender As Object, e As EventArgs) Handles lblBranch.Click
        frmDataPicked.fieldname.Text = "branchname"
        frmDataPicked.Text = "Branch Name"
        frmDataPicked.ShowDialog(Me)
        LoadPickedDataTable("branchname", txtSRBranch, gvBranch)
    End Sub
    Private Sub lblPosition_Click(sender As Object, e As EventArgs) Handles lblPosition.Click
        frmDataPicked.fieldname.Text = "position"
        frmDataPicked.Text = "Designation"
        frmDataPicked.ShowDialog(Me)
        LoadPickedDataTable("position", txtSRDesignation, gvWorkPosition)
    End Sub

    Private Sub lblStatus_Click(sender As Object, e As EventArgs) Handles lblStatus.Click
        frmDataPicked.fieldname.Text = "emp_status"
        frmDataPicked.Text = "Status"
        frmDataPicked.ShowDialog(Me)
        LoadPickedDataTable("emp_status", txtSRStatus, gvSRStatus)
    End Sub

    Private Sub lblCause_Click(sender As Object, e As EventArgs) Handles lblCause.Click
        frmDataPicked.fieldname.Text = "sep_cause"
        frmDataPicked.Text = "Separation Cause"
        frmDataPicked.ShowDialog(Me)
        LoadPickedDataTable("sep_cause", txtSRSeparationCause, gvSeparationCause)
    End Sub

    Public Sub LoadWork()
        LoadXgrid("select id,date_format(datefrom,'%m/%d/%Y') as 'Date From', date_format(dateto,'%m/%d/%Y') as 'Date To', " _
                  + " (select description from tbldatapicked where id=a.desigid) as Designation, " _
                  + " (select description from tbldatapicked where id=a.statusid) as Status, " _
                  + " salaryrate as 'Salary Rate', " _
                  + " (select description from tbldatapicked where id=a.baserate) as 'Base Rate',  " _
                  + " (select description from tbldatapicked where id=a.companyid) as 'Office Station', " _
                  + " (select description from tbldatapicked where id=a.branchid) as 'Branch', " _
                  + " lv_abs_wpay as 'L/V ABS W/O Pay', date_format(sep_date,'%m/%d/%Y') as 'Separation Date', " _
                  + " (select description from tbldatapicked where id=a.sep_causeid) as 'Separation Cause', " _
                  + " round(datediff(dateto,datefrom)/365,0) as 'Year(s) in Service', " _
                  + " ifnull((select if(count(*)>0,cast(concat(count(*), ' File(s) Attached') as char),null) from " & sqlfiledir & ".tblattachmentlogs where refnumber = a.id and trntype='emp_service_record'),'-') as 'Attachment' " _
                  + " from tblemployeeservice as a where employeeid='" & id.Text & "' order by datefrom desc", "tblemployeeservice", gridWork, g_work, Me)


        g_work.Columns("id").Visible = False
        XgridColCurrency({"Salary Rate"}, g_work)
        XgridColAlign({"Date From", "Date To", "Office Station", "Designation", "Status", "Branch", "Separation Date", "Year(s) in Service", "Separation Cause", "Attachment"}, g_work, DevExpress.Utils.HorzAlignment.Center)
    End Sub

    Public Sub ShowWorkInfo()
        com.CommandText = "select * from tblemployeeservice where id ='" & id_work.Text & "'" : rst = com.ExecuteReader()
        While rst.Read
            txtSRDateFrom.EditValue = rst("datefrom").ToString
            txtSRDateTo.EditValue = rst("dateto").ToString
            txtSRDesignation.EditValue = rst("desigid").ToString
            txtSRStatus.EditValue = rst("statusid").ToString
            txtSRSalaryRate.Text = FormatNumber(rst("salaryrate").ToString, 2)
            txtSRSalaryBase.EditValue = rst("baserate").ToString
            txtSRCompany.EditValue = rst("companyid").ToString
            txtSRBranch.EditValue = rst("branchid").ToString
            txtSRLVABS.EditValue = rst("lv_abs_wpay").ToString
            txtSRSeparationDate.EditValue = rst("sep_date").ToString
            txtSRSeparationCause.EditValue = rst("sep_causeid").ToString
        End While
        rst.Close()
    End Sub
    Private Sub cmdWord_Click(sender As Object, e As EventArgs) Handles cmdSRSave.Click
        If txtSRDateFrom.Text = "" Then
            XtraMessageBox.Show("Please select date from", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtSRDateFrom.Focus()
            Exit Sub
        ElseIf txtSRDateTo.Text = "" Then
            XtraMessageBox.Show("Please select date to", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtSRDateTo.Focus()
            Exit Sub
        ElseIf txtSRDesignation.Text = "" Then
            XtraMessageBox.Show("Please select or enter designation", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtSRDesignation.Focus()
            Exit Sub
        ElseIf txtSRStatus.Text = "" Then
            XtraMessageBox.Show("Please select or enter status", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtSRStatus.Focus()
            Exit Sub
        ElseIf Val(CC(txtSRSalaryRate.Text)) > 0 And txtSRSalaryBase.Text = "" Then
            XtraMessageBox.Show("Please select or enter salary rate base", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtSRSalaryBase.Focus()
            Exit Sub
        ElseIf txtSRCompany.Text = "" Then
            XtraMessageBox.Show("Please select or enter company name", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtSRCompany.Focus()
            Exit Sub
        ElseIf txtSRBranch.Text = "" Then
            XtraMessageBox.Show("Please select or enter branch", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtSRBranch.Focus()
            Exit Sub
        ElseIf txtSRSeparationCause.Text = "" Then
            XtraMessageBox.Show("Please select or enter separation cause", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtSRSeparationCause.Focus()
            Exit Sub
        End If
        If mode_work.Text = "edit" Then
            com.CommandText = "UPDATE tblemployeeservice set employeeid='" & id.Text & "', " _
                                    + If(txtSRDateFrom.Text <> "", " datefrom='" & ConvertDate(txtSRDateFrom.EditValue) & "', ", " datefrom=null, ") _
                                    + If(txtSRDateTo.Text <> "", " dateto='" & ConvertDate(txtSRDateTo.EditValue) & "', ", " dateto=null, ") _
                                    + " desigid='" & txtSRDesignation.EditValue & "', " _
                                    + " statusid='" & txtSRStatus.EditValue & "', " _
                                    + " salaryrate='" & Val(CC(txtSRSalaryRate.Text)) & "', " _
                                    + " baserate='" & txtSRSalaryBase.EditValue & "', " _
                                    + " companyid='" & txtSRCompany.EditValue & "', " _
                                    + " branchid='" & txtSRBranch.EditValue & "', " _
                                    + " lv_abs_wpay='" & txtSRLVABS.Text & "', " _
                                    + If(txtSRSeparationDate.Text <> "", " sep_date='" & ConvertDate(txtSRSeparationDate.EditValue) & "', ", " sep_date=null, ") _
                                    + " sep_causeid='" & txtSRSeparationCause.EditValue & "' " _
                                    + " where id='" & id_work.Text & "'" : com.ExecuteNonQuery()
        Else
            com.CommandText = "INSERT INTO tblemployeeservice set employeeid='" & id.Text & "', " _
                                    + If(txtSRDateFrom.Text <> "", " datefrom='" & ConvertDate(txtSRDateFrom.EditValue) & "', ", " datefrom=null, ") _
                                    + If(txtSRDateTo.Text <> "", " dateto='" & ConvertDate(txtSRDateTo.EditValue) & "', ", " dateto=null, ") _
                                    + " desigid='" & txtSRDesignation.EditValue & "', " _
                                    + " statusid='" & txtSRStatus.EditValue & "', " _
                                    + " salaryrate='" & Val(CC(txtSRSalaryRate.Text)) & "', " _
                                    + " baserate='" & txtSRSalaryBase.EditValue & "', " _
                                    + " companyid='" & txtSRCompany.EditValue & "', " _
                                    + " branchid='" & txtSRBranch.EditValue & "', " _
                                    + " lv_abs_wpay='" & txtSRLVABS.Text & "', " _
                                    + If(txtSRSeparationDate.Text <> "", " sep_date='" & ConvertDate(txtSRSeparationDate.EditValue) & "', ", " sep_date=null, ") _
                                    + " sep_causeid='" & txtSRSeparationCause.EditValue & "' " _
                                    + "" : com.ExecuteNonQuery()
        End If

        ClearWorkArea()
        LoadWork()
        txtSRDateFrom.Focus()
        XtraMessageBox.Show("Service record successfuly saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Public Sub ClearWorkArea()
        txtSRCompany.Text = Nothing
        txtSRBranch.Text = Nothing
        txtSRSalaryBase.Text = Nothing
        txtSRDesignation.Text = Nothing
        txtSRStatus.Text = Nothing
        txtSRDateFrom.EditValue = Nothing
        txtSRDateTo.EditValue = Nothing
        txtSRSeparationDate.EditValue = Nothing
        txtSRSeparationCause.Text = Nothing
        txtSRLVABS.SelectedIndex = -1
        txtSRSalaryRate.Text = "0"
        id_work.Text = ""
        mode_work.Text = ""
    End Sub

#End Region

#Region "CERTIFICATE"
    Private Sub HyperlinkLabelControl3_Click_1(sender As Object, e As EventArgs) Handles cmdCertificateIssuedFrom.Click
        frmDataPicked.fieldname.Text = "certificateissuedfrom"
        frmDataPicked.Text = "Certificate Issued From"
        frmDataPicked.ShowDialog(Me)
        LoadPickedDataTable("certificateissuedfrom", txtCertIssuedFrom, gvCertIssuedFrom)
    End Sub

    Private Sub cmdTypeofcertificate_Click(sender As Object, e As EventArgs) Handles cmdTypeofcertificate.Click
        frmDataPicked.fieldname.Text = "typeofcertificate"
        frmDataPicked.Text = "Type of Certificate"
        frmDataPicked.ShowDialog(Me)
        LoadPickedDataTable("typeofcertificate", txtTypeOfCertificate, gvtypeofcertificate)
    End Sub

    Public Sub ShowCertificationInfo()
        com.CommandText = "select * from tblemployeecertification where id ='" & cert_id.Text & "'" : rst = com.ExecuteReader()
        While rst.Read
            txtCertIssuedFrom.EditValue = rst("certissuedfrom").ToString
            txtTypeOfCertificate.EditValue = rst("certid").ToString
            txtCertDate.Text = rst("certdate").ToString
            txtCertNo.Text = rst("certno").ToString
        End While
        rst.Close()
    End Sub

    Public Sub loadCertificate()
        LoadXgrid("select id,(select description from tbldatapicked where id=tblemployeecertification.certissuedfrom) as 'Issued From', " _
                  + " (select description from tbldatapicked where id=tblemployeecertification.certid) as 'Type of Certificate', certno as 'Certificate No.', " _
                  + " date_format(certdate,'%Y-%m-%d') as 'Certificate Date', " _
                  + " ifnull((select if(count(*)>0,cast(concat(count(*), ' File(s) Attached') as char),null) from " & sqlfiledir & ".tblattachmentlogs where refnumber = tblemployeecertification.id and trntype='emp_certificate'),'-') as 'Attachment' " _
                  + " from tblemployeecertification where employeeid='" & id.Text & "' order by certdate desc", "tblemployeecertification", Em_certificate, gridCertificate, Me)
        gridCertificate.Columns("id").Visible = False
        XgridColAlign({"Certificate No.", "Certificate Date", "Attachment"}, gridCertificate, DevExpress.Utils.HorzAlignment.Center)
    End Sub

    Private Sub cmdSaveCertificate_Click(sender As Object, e As EventArgs) Handles cmdSaveCertificate.Click
        If txtCertIssuedFrom.Text = "" Then
            XtraMessageBox.Show("Please select issued from", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtCertIssuedFrom.Focus()
            Exit Sub
        ElseIf txtTypeOfCertificate.Text = "" Then
            XtraMessageBox.Show("Please select type of certificate", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtTypeOfCertificate.Focus()
            Exit Sub
        End If
        If cert_mode.Text = "edit" Then
            com.CommandText = "UPDATE tblemployeecertification set employeeid='" & id.Text & "', certissuedfrom='" & txtCertIssuedFrom.EditValue & "', certid='" & txtTypeOfCertificate.EditValue & "', certno='" & txtCertNo.Text & "' " & If(txtCertDate.Text <> "", ",certdate='" & ConvertDate(txtCertDate.EditValue) & "'", "") & "  where id='" & cert_id.Text & "'" : com.ExecuteNonQuery()
        Else
            com.CommandText = "INSERT INTO tblemployeecertification set employeeid='" & id.Text & "', certissuedfrom='" & txtCertIssuedFrom.EditValue & "', certid='" & txtTypeOfCertificate.EditValue & "', certno='" & txtCertNo.Text & "' " & If(txtCertDate.Text <> "", ",certdate='" & ConvertDate(txtCertDate.EditValue) & "'", "") : com.ExecuteNonQuery()
        End If
        ClearCertificate()
        loadCertificate()
        txtCertIssuedFrom.Focus()
        XtraMessageBox.Show("certificate successfuly saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Public Sub ClearCertificate()
        txtCertIssuedFrom.Text = Nothing
        txtTypeOfCertificate.Text = Nothing
        txtCertDate.EditValue = Nothing
        txtCertNo.Text = ""
        cert_id.Text = ""
        cert_mode.Text = ""
    End Sub
#End Region

    Private Sub cmdEdit_Click(sender As Object, e As EventArgs) Handles cmdEdit.Click
        If XtraTabControl1.SelectedTabPage Is tabCard Then
            mode_card.Text = "edit"
            id_card.Text = g_card.GetFocusedRowCellValue("id").ToString
            ShowCardInfo()
        ElseIf XtraTabControl1.SelectedTabPage Is tabEducation Then
            mode_education.Text = "edit"
            id_education.Text = g_education.GetFocusedRowCellValue("id").ToString
            ShowEducationInfo()

        ElseIf XtraTabControl1.SelectedTabPage Is tabServiceRecord Then
            mode_work.Text = "edit"
            id_work.Text = g_work.GetFocusedRowCellValue("id").ToString
            ShowWorkInfo()

        ElseIf XtraTabControl1.SelectedTabPage Is tabCertification Then
            cert_mode.Text = "edit"
            cert_id.Text = gridCertificate.GetFocusedRowCellValue("id").ToString
            ShowCertificationInfo()
        End If
    End Sub

    Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
        If XtraMessageBox.Show("Are you sure you want to continue? ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            If XtraTabControl1.SelectedTabPage Is tabCard Then
                com.CommandText = "DELETE FROM tblemployeecard where id='" & g_card.GetFocusedRowCellValue("id") & "'" : com.ExecuteNonQuery()
                LoadCards()
            ElseIf XtraTabControl1.SelectedTabPage Is tabEducation Then
                com.CommandText = "DELETE FROM tblemployeeeducation where id='" & g_education.GetFocusedRowCellValue("id") & "'" : com.ExecuteNonQuery()
                LoadEducation()
            ElseIf XtraTabControl1.SelectedTabPage Is tabServiceRecord Then
                com.CommandText = "DELETE FROM tblemployeeservice where id='" & g_work.GetFocusedRowCellValue("id") & "'" : com.ExecuteNonQuery()
                LoadWork()
            ElseIf XtraTabControl1.SelectedTabPage Is tabCertification Then
                com.CommandText = "DELETE FROM tblemployeecertification where id='" & gridCertificate.GetFocusedRowCellValue("id") & "'" : com.ExecuteNonQuery()
                loadCertificate()
            End If
        End If
    End Sub

    Private Sub cmdRefresh_Click(sender As Object, e As EventArgs) Handles cmdRefresh.Click
        If XtraTabControl1.SelectedTabPage Is tabCard Then
            LoadCards()
        ElseIf XtraTabControl1.SelectedTabPage Is tabEducation Then
            LoadEducation()
        ElseIf XtraTabControl1.SelectedTabPage Is tabServiceRecord Then
            LoadWork()
        ElseIf XtraTabControl1.SelectedTabPage Is tabCertification Then
            loadCertificate()
        End If
    End Sub


    Private Sub SetAttachmentToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SetAttachmentToolStripMenuItem1.Click
        If XtraTabControl1.SelectedTabPage Is tabEducation Then
            frmFileUploader.trntype.Text = "emp_education"
            frmFileUploader.trncode.Text = g_education.GetFocusedRowCellValue("id").ToString
            frmFileUploader.Show(Me)
        ElseIf XtraTabControl1.SelectedTabPage Is tabCard Then
            frmFileUploader.trntype.Text = "emp_card"
            frmFileUploader.trncode.Text = g_education.GetFocusedRowCellValue("id").ToString
            frmFileUploader.Show(Me)
        ElseIf XtraTabControl1.SelectedTabPage Is tabServiceRecord Then
            frmFileUploader.trntype.Text = "emp_service_record"
            frmFileUploader.trncode.Text = g_work.GetFocusedRowCellValue("id").ToString
            frmFileUploader.Show(Me)
        ElseIf XtraTabControl1.SelectedTabPage Is tabCertification Then
            frmFileUploader.trntype.Text = "emp_certificate"
            frmFileUploader.trncode.Text = gridCertificate.GetFocusedRowCellValue("id").ToString
            frmFileUploader.Show(Me)
        End If
    End Sub

    Private Sub cmdViewAttachment_Click(sender As Object, e As EventArgs) Handles cmdViewAttachment.Click
        If XtraTabControl1.SelectedTabPage Is tabEducation Then
            frmFileViewer.trntype.Text = "emp_education"
            frmFileViewer.viewonly = If(globalAllowDelete, False, True)
            frmFileViewer.trncode.Text = g_education.GetFocusedRowCellValue("id").ToString
            frmFileViewer.Show(Me)
        ElseIf XtraTabControl1.SelectedTabPage Is tabCard Then
            frmFileViewer.trntype.Text = "emp_card"
            frmFileViewer.viewonly = If(globalAllowDelete, False, True)
            frmFileViewer.trncode.Text = g_work.GetFocusedRowCellValue("id").ToString
            frmFileViewer.Show(Me)
        ElseIf XtraTabControl1.SelectedTabPage Is tabServiceRecord Then
            frmFileViewer.trntype.Text = "emp_service_record"
            frmFileViewer.viewonly = If(globalAllowDelete, False, True)
            frmFileViewer.trncode.Text = g_work.GetFocusedRowCellValue("id").ToString
            frmFileViewer.Show(Me)
        ElseIf XtraTabControl1.SelectedTabPage Is tabCertification Then
            frmFileViewer.trntype.Text = "emp_certificate"
            frmFileViewer.viewonly = If(globalAllowDelete, False, True)
            frmFileViewer.trncode.Text = gridCertificate.GetFocusedRowCellValue("id").ToString
            frmFileViewer.Show(Me)
        End If

    End Sub

    Private Sub ExtractAttachmentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExtractAttachmentToolStripMenuItem.Click
        If XtraTabControl1.SelectedTabPage Is tabEducation Then
            ViewAttachmentPackage_All({g_education.GetFocusedRowCellValue("id").ToString()}, "emp_education")
        ElseIf XtraTabControl1.SelectedTabPage Is tabCard Then
            ViewAttachmentPackage_All({g_work.GetFocusedRowCellValue("id").ToString()}, "emp_card")
        ElseIf XtraTabControl1.SelectedTabPage Is tabServiceRecord Then
            ViewAttachmentPackage_All({g_work.GetFocusedRowCellValue("id").ToString()}, "emp_service_record")
        ElseIf XtraTabControl1.SelectedTabPage Is tabCertification Then
            ViewAttachmentPackage_All({gridCertificate.GetFocusedRowCellValue("id").ToString()}, "emp_certificate")
        End If
    End Sub

    Private Sub BarButtonItem4_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdPrint201File.ItemClick
        PrintEmployee201(id.Text, txtfullname.Text, Me)
    End Sub


    Private Sub cmdTitle_Click(sender As Object, e As EventArgs) Handles cmdTitle.Click
        frmDataPicked.fieldname.Text = "emp_title"
        frmDataPicked.Text = "Employee Title"
        frmDataPicked.ShowDialog(Me)
        LoadPickedDataTable("emp_title", txtTitle, gvTitle)
    End Sub

    Private Sub cmdBirthPlace_Click(sender As Object, e As EventArgs) Handles cmdBirthPlace.Click
        frmDataPicked.fieldname.Text = "birth_place"
        frmDataPicked.Text = "Birth Place"
        frmDataPicked.ShowDialog(Me)
        LoadPickedDataTable("birth_place", txtBirthPlace, gvBirthPlace)
    End Sub


    Private Sub cmdReligion_Click(sender As Object, e As EventArgs) Handles cmdReligion.Click
        frmDataPicked.fieldname.Text = "religion"
        frmDataPicked.Text = "Religion"
        frmDataPicked.ShowDialog(Me)
        LoadPickedDataTable("religion", txtreligion, gvReligion)
    End Sub

    Private Sub cmdNationality_Click(sender As Object, e As EventArgs) Handles cmdNationality.Click
        frmDataPicked.fieldname.Text = "nationality"
        frmDataPicked.Text = "Nationality"
        frmDataPicked.ShowDialog(Me)
        LoadPickedDataTable("nationality", txtnationality, gvNationality)
    End Sub

    Private Sub HyperlinkLabelControl1_Click(sender As Object, e As EventArgs) Handles HyperlinkLabelControl1.Click
        frmDataPicked.fieldname.Text = "designation"
        frmDataPicked.Text = "Designation"
        frmDataPicked.ShowDialog(Me)
        LoadPickedDataTable("designation", txtDesignation, gvDesignation)
    End Sub

    Private Sub HyperlinkLabelControl3_Click_2(sender As Object, e As EventArgs) Handles HyperlinkLabelControl3.Click
        frmDataPicked.fieldname.Text = "emp_type"
        frmDataPicked.Text = "Employee Type"
        frmDataPicked.ShowDialog(Me)
        LoadPickedDataTable("emp_type", txtEmployeeType, gvEmployeeType)
    End Sub
    Private Sub HyperlinkLabelControl6_Click(sender As Object, e As EventArgs) Handles HyperlinkLabelControl6.Click
        frmDataPicked.fieldname.Text = "emp_level"
        frmDataPicked.Text = "Position Level"
        frmDataPicked.ShowDialog(Me)
        LoadPickedDataTable("emp_level", txtPositionLevel, gvPositionLevel)
    End Sub

    Private Sub HyperlinkLabelControl7_Click(sender As Object, e As EventArgs) Handles HyperlinkLabelControl7.Click
        frmDataPicked.fieldname.Text = "emp_base_rate"
        frmDataPicked.Text = "Base Rate Pay"
        frmDataPicked.ShowDialog(Me)
        LoadPickedDataTable("emp_base_rate", txtBaseRatePay, gvBaseRatePay)
        LoadPickedDataTable("emp_base_rate", txtSRSalaryBase, gvSRSalaryBase)
    End Sub

    Private Sub HyperlinkLabelControl4_Click(sender As Object, e As EventArgs) Handles HyperlinkLabelControl4.Click
        frmDataPicked.fieldname.Text = "emp_rate"
        frmDataPicked.Text = "Basic Rate"
        frmDataPicked.ShowDialog(Me)
        LoadPickedDataTable("emp_rate", txtBasicRate, gvBasicRate)
    End Sub




    Private Sub ckCardExpiry_CheckedChanged(sender As Object, e As EventArgs) Handles ckCardExpiry.CheckedChanged
        If ckCardExpiry.Checked Then
            txtCardExpiry.Enabled = True
        Else
            txtCardExpiry.Enabled = False
        End If
    End Sub

    Private Sub cmdPrintServiceRecord_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdPrintServiceRecord.ItemClick
        PrintEmployeeServiceRecord(id.Text, txtfullname.Text, Me)
    End Sub

    Private Sub ckResigned_CheckedChanged(sender As Object, e As EventArgs) Handles ckResigned.CheckedChanged
        If ckResigned.Checked Then
            txtDateResigned.Enabled = True
        Else
            txtDateResigned.Enabled = False
        End If
    End Sub

    Private Sub ckRetired_CheckedChanged(sender As Object, e As EventArgs) Handles ckRetired.CheckedChanged
        If ckRetired.Checked Then
            txtDateRetired.Enabled = True
        Else
            txtDateRetired.Enabled = False
        End If
    End Sub
End Class