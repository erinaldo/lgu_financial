Imports System.IO
Imports MySql.Data.MySqlClient
Imports DevExpress.XtraGrid.Design
Imports System.Xml

Module AccountInfo

    'General Settings
    Public GlobalAllowableAttachSize As Double = 102400
    Public GlobalDownloadDefaultLocation As String = ""
    Public GlobalBudgetDefaultDay As Integer
    Public ReportHeaderImg As Image = Nothing
    Public ReportFooterImg As Image = Nothing
    Public screenHeight As Integer
    Public screenWidth As Integer
    Public screenres As String
    Public globallogin As Boolean

    'Declaration of user accounts
    Public globalRootUser As Boolean
    Public globaluserid As String
    Public globalTransactionUserid As String
    Public globalfullname As String
    Public globalNickName As String
    Public globalposition As String
    Public globalEmailaddress As String
    Public globalcontact As String
    Public globalusername As String
    Public globalCoffeecupUser As Boolean
    Public globalpermissioncode As String
    Public globalBegginingCash As Double
    Public globalAssistantUserId As String
    Public globalAssistantFullName As String
    Public globalIconfolder As String
    Public globalBgColor As String
    Public globalFontColor As String
    Public globalUserRequiredUpdateInfo As String
    Public globalEnableAuthorizedAccess As Boolean
    Public ImageProfile As Image


    'Declaration of grid appearance
    Public gen_enablle_features As Boolean
    Public gen_fontfamily As String = "Segoe UI"
    Public gen_forecolor As String
    Public gen_FontSize As Single = 9.25!
    Public gen_schemestyle As String
    Public gen_paintstyle As String
    Public gen_Padding As Double
    Public gen_header_bold As Boolean
    Public gen_main_bold As Boolean
    Public gen_footer_bold As Boolean
    Public gen_evenrowenable As Boolean
    Public gen_ShowHorzLines As Boolean
    Public gen_ShowVertLines As Boolean
    Public gen_indicatorline As Boolean
    Public gen_filterappearance As Boolean

    'Declaration of user authority
    Public globalAuthcode As String
    Public globalAuthDescription As String
    Public globalGeneralApprover As Boolean
    Public globalDepartmentHead As Boolean
    Public globalSpecialApprover As Boolean
    Public globalAllowAdd As Boolean
    Public globalAllowEdit As Boolean
    Public globalAllowDelete As Boolean
    Public globalRequestOverride As Boolean
    Public globalAuthCollectionPosting As Boolean
    Public globalAuthCedulaIndividual As Boolean
    Public globalAuthCedulaCorporation As Boolean
    Public globalAuthRealPropertyTax As Boolean
    Public globalAuthCollectionReport As Boolean
    Public globalAuthAccountableForm As Boolean
    Public globalAuthBusinessManagement As Boolean
    Public globalAuthRealPropertyMgt As Boolean
    Public globalAuthNewDirectJournal As Boolean
    Public globalAuthJournalEntryVoucher As Boolean
    Public globalAuthForApproval As Boolean
    Public globalAuthCheckIssuanceRequest As Boolean
    Public globalAuthNewRequisition As Boolean
    Public globalAuthRequisitionList As Boolean
    Public globalAuthNewDisbursement As Boolean
    Public globalAuthDisbursementList As Boolean
    Public globalAuthBudgetReport As Boolean
    Public globalAuthHumanResource As Boolean


    'Declaration of company profile
    Public GlobalOrganizationName As String
    Public GlobalOrganizationAddress As String
    Public GlobalOrganizationEmail As String
    Public GlobalOrganizationWebsite As String
    Public GlobalOrganizationLogoURL As String
    Public GlobalOrganizationContactNumber As String

    Public GlobalMayorID As String
    Public GlobalMayorName As String
    Public GlobalMayorPosition As String

    Public GlobalViceMayorID As String
    Public GlobalViceMayorName As String
    Public GlobalViceMayorPosition As String

    Public GlobalAccountantID As String
    Public GlobalAccountantName As String
    Public GlobalAccountantPosition As String

    Public GlobalTreasurerID As String
    Public GlobalTreasurerName As String
    Public GlobalTreasurerPosition As String

    Public GlobalBudgetID As String
    Public GlobalBudgetName As String
    Public GlobalBudgetPosition As String

    Public GlobalHrmdID As String
    Public GlobalHrmdName As String
    Public GlobalHrmdPosition As String

    Public GlobalDefaultCollection As String
    Public GlobalDefaultCedulaIndividual As String
    Public GlobalDefaultCedulaCorporate As String
    Public GlobalDefaultPropertyTax As String

    Public compOfficeid As String
    Public compOfficename As String
    Public compAddress As String
    Public compEmailaddress As String
    Public compOfficerid As String
    Public compOfficerIncharge As String
    Public compOfficerEmail As String
    Public compOfficerPosition As String


    Public GlobalGLitemname As String = "if(a.level=0, a.itemname,if(a.level=1,concat('   ',a.itemname),if(a.level=2,concat('           ',a.itemname),if(a.level=3,concat('                  ',a.itemname),concat('                         ',a.itemname)))))"

    Public Sub check_win()
        screenHeight = My.Computer.Screen.Bounds.Height
        screenWidth = My.Computer.Screen.Bounds.Width
        screenres = "236," + screenHeight
    End Sub

    Public Function SetupCompanyHeader(ByVal companyid As String, ByVal center As Boolean)
        SetupCompanyHeader = ""
        com.CommandText = "select * from tblcompanysettings" : rst = com.ExecuteReader
        While rst.Read
            SetupCompanyHeader += "<p align='" & If(center = True, "center", "right") & "' ><strong>" & UCase(rst("companyname").ToString) & "</strong></br>" _
                    + rst("compadd").ToString & "<br/> " _
                    + rst("telephone").ToString & "<br/> "
        End While
        rst.Close()

        Return SetupCompanyHeader
    End Function

    Public Function LoadAccountDetails(ByVal userid As String)
        ImageProfile = Nothing
        com.CommandText = "select *,(select officename from tblcompoffice where officeid=tblaccounts.officeid) as Officename, " _
                                + " (select officeemail from tblcompoffice where officeid=tblaccounts.officeid) as officemail " _
                                + "  from tblaccounts where accountid='" & userid & "'" : rst = com.ExecuteReader
        While rst.Read
            globalTransactionUserid = userid
            compOfficeid = rst("officeid").ToString
            globalfullname = rst("fullname").ToString
            globalNickName = rst("nickname").ToString
            globalposition = StrConv(rst("designation").ToString, vbProperCase)
            globalusername = rst("username").ToString
            globalpermissioncode = rst("permission").ToString
            globalCoffeecupUser = rst("coffeecupuser")
            globalEmailaddress = rst("emailaddress").ToString
            globalBegginingCash = rst("cashbeggining")
            globalIconfolder = rst("iconfolderclient").ToString
            globalBgColor = rst("bgcolorclient").ToString
            globalFontColor = rst("fontcolorclient").ToString
            globalUserRequiredUpdateInfo = rst("requiredupdate")
            globalEnableAuthorizedAccess = rst("enableauthorizedaccess")

            If LCase(globalusername) = "root" Then
                globalRootUser = True
            Else
                globalRootUser = False
            End If

            If globalCoffeecupUser = True Then
                globalAuthcode = rst("clientaccesscode").ToString
            End If
            If rst("profileimg").ToString <> "" Then
                ImageProfile = ConvertImageBinary("profileimg")
            End If
        End While
        rst.Close()
        LoadUserGridAppearance()
        MainForm.LoadSystemAppearance(globalIconfolder, globalBgColor, globalFontColor)

        '#validate user authority
        com.CommandText = "select * from tblclientaccess where accesscode='" & globalAuthcode & "'" : rst = com.ExecuteReader
        While rst.Read
            globalAuthDescription = rst("description").ToString
            globalGeneralApprover = rst("generalapprover")
            globalDepartmentHead = rst("departmenthead")
            globalSpecialApprover = rst("specialapprover")
            globalAllowAdd = rst("allowadd")
            globalAllowEdit = rst("allowedit")
            globalAllowDelete = rst("allowdelete")
            globalRequestOverride = rst("requestoverride")
            globalAuthCollectionPosting = rst("collectionposting")
            globalAuthCedulaIndividual = rst("cedulaindividual")
            globalAuthCedulaCorporation = rst("cedulacorporate")
            globalAuthRealPropertyTax = rst("realpropertytax")
            globalAuthCollectionReport = rst("collectionreport")
            globalAuthAccountableForm = rst("accountableform")
            globalAuthBusinessManagement = rst("businessmgt")
            globalAuthRealPropertyMgt = rst("realpropertymgt")
            globalAuthNewDirectJournal = rst("newdirectjournal")
            globalAuthJournalEntryVoucher = rst("journalentryvoucher")
            globalAuthForApproval = rst("forapproval")
            globalAuthCheckIssuanceRequest = rst("checkapproval")
            globalAuthNewRequisition = rst("newrequisition")
            globalAuthRequisitionList = rst("requisitionlist")
            globalAuthNewDisbursement = rst("newdisbursement")
            globalAuthDisbursementList = rst("disbursementlist")
            globalAuthBudgetReport = rst("budgetreport")
            globalAuthHumanResource = rst("humanresource")
        End While
        rst.Close()

        If LCase(globalusername) = "root" Then
            globalAllowAdd = True
            globalAllowEdit = True
            globalAllowDelete = True
        End If

        '#validate Office Information settings 
        com.CommandText = "select * from tblcompoffice where officeid='" & compOfficeid & "'" : rst = com.ExecuteReader
        While rst.Read
            compOfficename = rst("officename").ToString
            compAddress = rst("address").ToString
            compEmailaddress = rst("officeemail").ToString
        End While
        rst.Close()

        com.CommandText = "select *,(select fullname from tblaccounts where accountid = a.officerid) as 'incharge', " _
                        + "(select emailaddress from tblaccounts where accountid = a.officerid) as 'officeremail', " _
                        + " (select designation from tblaccounts where accountid = a.officerid) as 'position' from tblcompofficerlog as a where officeid='" & compOfficeid & "' and current=1" : rst = com.ExecuteReader
        While rst.Read
            compOfficerid = rst("officerid").ToString
            compOfficerIncharge = rst("incharge").ToString
            compOfficerPosition = rst("position").ToString
            compOfficerEmail = rst("officeremail").ToString
        End While
        rst.Close()


        com.CommandText = "select *, " _
            + " (select fullname from tblaccounts where accountid=a.mayorname) as mayor, " _
            + " (select fullname from tblaccounts where accountid=a.vicemayorname) as vicemayor, " _
            + " (select fullname from tblaccounts where accountid=a.accountantname) as accountant, " _
            + " (select fullname from tblaccounts where accountid=a.treasurermame) as treasurer, " _
            + " (select fullname from tblaccounts where accountid=a.budgetname) as budget, " _
            + " (select fullname from tblaccounts where accountid=a.hrmdname) as hrmd " _
            + " from tblcompanysettings as a"
        rst = com.ExecuteReader
        While rst.Read
            GlobalOrganizationName = rst("companyname").ToString
            GlobalOrganizationAddress = rst("compadd").ToString
            GlobalOrganizationEmail = rst("email").ToString
            GlobalOrganizationWebsite = rst("website").ToString
            GlobalOrganizationLogoURL = rst("logourl").ToString
            GlobalOrganizationContactNumber = rst("telephone").ToString
            Dim picbox As New PictureBox
            ConvertDatabaseImage("logo", picbox)
            If System.IO.File.Exists(Application.StartupPath.ToString & "\Logo\logo.png") = True Then
                System.IO.File.Delete(Application.StartupPath.ToString & "\Logo\logo.png")
            End If
            If Not picbox.Image Is Nothing Then
                picbox.Image.Save(Application.StartupPath.ToString & "\Logo\logo.png", Imaging.ImageFormat.Png)
            End If

            GlobalMayorID = rst("mayorname").ToString
            GlobalMayorName = rst("mayor").ToString
            GlobalMayorPosition = rst("mayorposition").ToString

            GlobalViceMayorID = rst("vicemayorname").ToString
            GlobalViceMayorName = rst("vicemayor").ToString
            GlobalViceMayorPosition = rst("vicemayorposition").ToString

            GlobalAccountantID = rst("accountantname").ToString
            GlobalAccountantName = rst("accountant").ToString
            GlobalAccountantPosition = rst("accountantposition").ToString

            GlobalTreasurerID = rst("treasurermame").ToString
            GlobalTreasurerName = rst("treasurer").ToString
            GlobalTreasurerPosition = rst("treasurerposition").ToString

            GlobalBudgetID = rst("budgetname").ToString
            GlobalBudgetName = rst("budget").ToString
            GlobalBudgetPosition = rst("budgetposition").ToString

            GlobalHrmdID = rst("hrmdname").ToString
            GlobalHrmdName = rst("hrmd").ToString
            GlobalHrmdPosition = rst("hrmdposition").ToString
        End While
        rst.Close()


        '#validate system general settings 
        com.CommandText = "select * from tblgeneralsettings" : rst = com.ExecuteReader
        While rst.Read
            GlobalDownloadDefaultLocation = rst("downloaddefaultlocation").ToString
            GlobalAllowableAttachSize = Val(rst("allowableattachsize").ToString)
            GlobalBudgetDefaultDay = rst("budgetdefaultday")
        End While
        rst.Close()



        '#validate system general settings 
        com.CommandText = "select * from tbldefaultsettings" : rst = com.ExecuteReader
        While rst.Read
            GlobalDefaultCollection = rst("defaultcollection").ToString
            GlobalDefaultCedulaIndividual = rst("defaultcedulaindividual").ToString
            GlobalDefaultCedulaCorporate = rst("defaultcedulacorporate").ToString
            GlobalDefaultPropertyTax = rst("defaultpropertytax").ToString
        End While
        rst.Close()

        If System.IO.File.Exists(Application.StartupPath.ToString & "\Image\letterhead.jpg") = True Then
            ReportHeaderImg = Image.FromFile(Application.StartupPath.ToString & "\Image\letterhead.jpg")
        End If
        If System.IO.File.Exists(Application.StartupPath.ToString & "\Image\letterfooter.jpg") = True Then
            ReportFooterImg = Image.FromFile(Application.StartupPath.ToString & "\Image\letterfooter.jpg")
        End If
        Return 0
    End Function

    Public Sub LoadUserGridAppearance()
        If countqry("tblgridsettings", "userid='" & globaluserid & "'") = 0 Then
            gen_enablle_features = False
        Else
            com.CommandText = "select * from tblgridsettings where userid='" & globaluserid & "'" : rst = com.ExecuteReader
            While rst.Read
                gen_enablle_features = rst("grid_enableappearance")
                gen_fontfamily = rst("grid_fontfamily").ToString
                gen_forecolor = rst("grid_forntcolor").ToString
                gen_FontSize = rst("grid_fontsize").ToString
                gen_schemestyle = rst("grid_schemestyle").ToString
                gen_paintstyle = rst("grid_paintstyle").ToString
                gen_Padding = rst("grid_padding").ToString
                gen_header_bold = rst("grid_header_bold")
                gen_main_bold = rst("grid_main_bold")
                gen_footer_bold = rst("grid_footer_bold")
                gen_evenrowenable = rst("grid_evenrowenable")
                gen_ShowHorzLines = rst("grid_ShowHorzLines")
                gen_ShowVertLines = rst("grid_ShowVertLines")
                gen_indicatorline = rst("grid_indicatorline")
                gen_filterappearance = rst("grid_filterappearance")
            End While
            rst.Close()
        End If
    End Sub

    Public Function LoadGridviewAppearance(ByVal xgrid As DevExpress.XtraGrid.Views.Grid.GridView)
        Dim gvScheme As XAppearances = New XAppearances(Application.StartupPath & "\DevExpress.XtraGrid.Appearances.xml")
        Try
            xgrid.OptionsSelection.EnableAppearanceFocusedCell = False
            If gen_enablle_features = True Then
                For Each sch In gvScheme.FormatNames
                    If sch.ToString = gen_schemestyle Then
                        gvScheme.LoadScheme(gen_schemestyle, xgrid)
                    End If
                Next
                xgrid.PaintStyleName = gen_paintstyle
                If gen_indicatorline = True Then
                    xgrid.OptionsView.ShowIndicator = True
                Else
                    xgrid.OptionsView.ShowIndicator = False
                End If

                If gen_evenrowenable = True Then
                    xgrid.OptionsView.EnableAppearanceEvenRow = True
                    xgrid.OptionsView.EnableAppearanceOddRow = True
                Else
                    xgrid.OptionsView.EnableAppearanceEvenRow = False
                    xgrid.OptionsView.EnableAppearanceOddRow = False
                End If

                If gen_ShowHorzLines = True Then
                    xgrid.OptionsView.ShowHorzLines = True
                Else
                    xgrid.OptionsView.ShowHorzLines = False
                End If

                If gen_ShowVertLines = True Then
                    xgrid.OptionsView.ShowVertLines = True
                Else
                    xgrid.OptionsView.ShowVertLines = False
                End If
                If gen_header_bold = True Then
                    xgrid.Appearance.HeaderPanel.Font = New Font(gen_fontfamily, gen_FontSize, FontStyle.Bold, GraphicsUnit.Point, (CByte(204)))
                    xgrid.Appearance.GroupRow.Font = New Font(gen_fontfamily, gen_FontSize, FontStyle.Bold, GraphicsUnit.Point, (CByte(204)))
                Else
                    xgrid.Appearance.HeaderPanel.Font = New Font(gen_fontfamily, gen_FontSize, FontStyle.Regular, GraphicsUnit.Point, (CByte(204)))
                    xgrid.Appearance.GroupRow.Font = New Font(gen_fontfamily, gen_FontSize, FontStyle.Regular, GraphicsUnit.Point, (CByte(204)))
                End If

                If gen_main_bold = True Then
                    xgrid.Appearance.Row.Font = New Font(gen_fontfamily, gen_FontSize, FontStyle.Bold, GraphicsUnit.Point, (CByte(204)))
                Else
                    xgrid.Appearance.Row.Font = New Font(gen_fontfamily, gen_FontSize, FontStyle.Regular, GraphicsUnit.Point, (CByte(204)))
                End If

                If gen_footer_bold = True Then
                    xgrid.Appearance.FooterPanel.Font = New Font(gen_fontfamily, gen_FontSize, FontStyle.Bold, GraphicsUnit.Point, (CByte(204)))
                    xgrid.Appearance.GroupFooter.Font = New Font(gen_fontfamily, gen_FontSize, FontStyle.Bold, GraphicsUnit.Point, (CByte(204)))
                Else
                    xgrid.Appearance.FooterPanel.Font = New Font(gen_fontfamily, gen_FontSize, FontStyle.Regular, GraphicsUnit.Point, (CByte(204)))
                    xgrid.Appearance.GroupFooter.Font = New Font(gen_fontfamily, gen_FontSize, FontStyle.Regular, GraphicsUnit.Point, (CByte(204)))
                End If

                xgrid.Appearance.HeaderPanel.ForeColor = Color.FromName(gen_forecolor)
                xgrid.Appearance.Row.ForeColor = Color.FromName(gen_forecolor)
                xgrid.Appearance.FooterPanel.ForeColor = Color.FromName(gen_forecolor)
                xgrid.Appearance.GroupFooter.ForeColor = Color.FromName(gen_forecolor)
                xgrid.UserCellPadding = New Padding(gen_Padding)
            Else
                gvScheme.LoadScheme("Default", xgrid)
                xgrid.PaintStyleName = "Default"
            End If
        Catch ex As Exception
            gvScheme.LoadScheme("Default", xgrid)
            xgrid.PaintStyleName = "Default"
        End Try
        Return xgrid
    End Function

    Public Sub CloseSystemDeclaration()
        globallogin = False


        screenHeight = 0
        screenWidth = 0
        screenres = ""
        globallogin = False

        'Declaration of user accounts
        globaluserid = ""
        globalTransactionUserid = ""
        globalfullname = ""
        globalposition = ""
        globalEmailaddress = ""
        globalcontact = ""
        globalusername = ""
        globalCoffeecupUser = False
        globalpermissioncode = ""
        globalBegginingCash = 0
        globalIconfolder = ""
        globalBgColor = ""
        globalFontColor = ""
        globalEnableAuthorizedAccess = False

        'Declaration of appearance
        gen_enablle_features = False
        gen_fontfamily = ""
        gen_forecolor = ""
        gen_FontSize = 9
        gen_schemestyle = ""
        gen_paintstyle = ""
        gen_header_bold = False
        gen_main_bold = False
        gen_footer_bold = False
        gen_evenrowenable = False
        gen_ShowHorzLines = False
        gen_ShowVertLines = False
        gen_indicatorline = False
        gen_filterappearance = False

        'Declaration of user authority
        globalAuthcode = ""
        globalAuthDescription = ""
        globalGeneralApprover = False
        globalDepartmentHead = False
        globalSpecialApprover = False
        globalAllowAdd = False
        globalAllowEdit = False
        globalAllowDelete = False
        globalAuthCollectionPosting = False
        globalAuthCedulaIndividual = False
        globalAuthRealPropertyTax = False
        globalAuthCollectionReport = False
        globalAuthAccountableForm = False
        globalAuthBusinessManagement = False
        globalAuthRealPropertyMgt = False
        globalAuthNewDirectJournal = False
        globalAuthJournalEntryVoucher = False
        globalAuthForApproval = False
        globalAuthCheckIssuanceRequest = False
        globalAuthNewRequisition = False
        globalAuthRequisitionList = False
        globalAuthNewDisbursement = False
        globalAuthDisbursementList = False
        globalAuthBudgetReport = False
        globalAuthHumanResource = False

        GlobalDefaultCollection = ""
        GlobalDefaultCedulaIndividual = ""
        GlobalDefaultCedulaCorporate = ""
        GlobalDefaultPropertyTax = ""

        'Declaration of company profile
        GlobalOrganizationName = ""
        GlobalOrganizationAddress = ""
        GlobalOrganizationContactNumber = ""

        compOfficeid = ""
        compOfficename = ""
        compAddress = ""
        compEmailaddress = ""
        compOfficerid = ""
        compOfficerIncharge = ""
        compOfficerEmail = ""
        compOfficerPosition = ""
        globalSpecialApprover = False
        MainForm.ShowAllMenu(False)
        conn.Close()
    End Sub
End Module

