Imports Microsoft.Office.Interop
Imports DevExpress.LookAndFeel
Imports DevExpress.XtraBars.Helpers
Imports DevExpress.XtraEditors
Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraBars
Imports DevExpress.XtraBars.Ribbon

'Imports MySql.Data.MySqlClient ' this is to import MySQL.NET


Public Class MdiMainmenu
    Public DataBook As Excel.Workbook
    Public DS_ChartOfAccount As Excel.Worksheet

    Dim cv As Boolean = False
    Public Property AllowCustomLookAndFeel As Boolean = True
    Dim validateRemote As Boolean = False
    Sub New()
        InitSkins()
        InitializeComponent()
        Me.InitSkinGallery()
    End Sub

    Sub InitSkins()
        DevExpress.Skins.SkinManager.EnableFormSkins()
        DevExpress.UserSkins.OfficeSkins.Register()
        DevExpress.UserSkins.BonusSkins.Register()
        UserLookAndFeel.Default.SetSkinStyle(globaltheme)

    End Sub
    Private Sub InitSkinGallery()
        SkinHelper.InitSkinGallery(rgbiSkins, True)
    End Sub

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Control + Keys.Q) Then
            Me.Close()

        End If
        Return ProcessCmdKey
    End Function


    Private Sub mdiProcurement_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        For i As Integer = My.Application.OpenForms.Count - 1 To 0 Step -1
            If My.Application.OpenForms.Item(i) IsNot Me And My.Application.OpenForms.Item(i) IsNot frmLogin Then
                My.Application.OpenForms.Item(i).Close()
            End If
        Next i

        If XtraMessageBox.Show("Are you sure you want to logoff your account " & globaluser & "@" & globalfullname & " on " & globaldate & " - " & GlobalTime() & ") ?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            ExitSystemVariable()
            SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
            frmLogin.Show()
            SplashScreenManager.CloseForm()
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub MdiCoffeeCup_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        loadIcons() : SetIcon(Me)
        LoadCompanySystemModule()
    End Sub

    Public Sub LoadCompanySystemModule()
        connectServer()
        DevExpress.Skins.SkinManager.EnableFormSkins()
        DevExpress.UserSkins.BonusSkins.Register()

        DefaultLookAndFeel1.LookAndFeel.SkinName = globaltheme.ToString()

        com.CommandText = "select * from tblcompanysettings" : rst = com.ExecuteReader
        While rst.Read
            Dim picbox As New PictureBox
            ConvertDatabaseImage("logo", picbox)
            If System.IO.File.Exists(Application.StartupPath.ToString & "\img\" & rst("companycode").ToString & ".png") = True Then
                System.IO.File.Delete(Application.StartupPath.ToString & "\img\" & rst("companycode").ToString & ".png")
            End If
            If Not picbox.Image Is Nothing Then
                picbox.Image.Save(Application.StartupPath.ToString & "\img\" & rst("companycode").ToString & ".png", System.Drawing.Imaging.ImageFormat.Png)
            End If
        End While
        rst.Close()

        cmdMenuPurchasingAbout.Caption = "About " & GlobalSystemName
        Me.Text = GlobalSystemName & " " & compname + " - Login as " & LCase(globaluser) & "@" & LCase(globalfullname)
        CustomizeSystemIcon(GlobalIconFolder)
    End Sub

    Public Sub CustomizeSystemIcon(ByVal iconfolder As String)
        On Error Resume Next
        Dim mCurrentItem As BarItem
        For Each currentPage As RibbonPage In Me.MainMenu.Pages
            currentPage.Appearance.Font = New System.Drawing.Font(GlobalPageFontName, GlobalPageFontSize, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            For Each currentGroup As RibbonPageGroup In currentPage.Groups
                'currentGroup.Page.Appearance.Font = New System.Drawing.Font(GlobalMenuFontName, GlobalMenuFontSize, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                For Each currenLink As BarItemLink In currentGroup.ItemLinks
                    mCurrentItem = currenLink.Item
                    mCurrentItem.LargeGlyph = Nothing
                    If IO.File.Exists(Application.StartupPath.ToString & "\icon\" & iconfolder & "\" & mCurrentItem.Name & ".png") = True Then
                        mCurrentItem.LargeGlyph = Image.FromFile(Application.StartupPath.ToString & "\icon\" & iconfolder & "\" & mCurrentItem.Name & ".png")
                    Else
                        mCurrentItem.LargeGlyph = Image.FromFile(Application.StartupPath.ToString & "\icon\default\" & mCurrentItem.Name & ".png")
                    End If
                    mCurrentItem.ItemAppearance.Disabled.Font = New System.Drawing.Font(GlobalMenuFontName, GlobalMenuFontSize, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                    mCurrentItem.ItemAppearance.Hovered.Font = New System.Drawing.Font(GlobalMenuFontName, GlobalMenuFontSize, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                    mCurrentItem.ItemAppearance.Normal.Font = New System.Drawing.Font(GlobalMenuFontName, GlobalMenuFontSize, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                    mCurrentItem.ItemAppearance.Pressed.Font = New System.Drawing.Font(GlobalMenuFontName, GlobalMenuFontSize, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                Next currenLink
            Next currentGroup
        Next currentPage
        '#other menu
    End Sub

    Private Sub BarButtonItem295_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdMenuLogout.ItemClick
        Me.Close()
    End Sub

    Private Sub BarButtonItem1_ItemClick_2(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdMenuHelp.ItemClick
        XtraMessageBox.Show("Send email to Winter Bugahod @ Katipunan Bank IT Dept. at Email Add. winterbugahod@yahoo.com ", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub BarButtonItem25_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdUserAccountManagement.ItemClick
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        frmUsersAccounts.MdiParent = Me
        frmUsersAccounts.Show()
        frmUsersAccounts.Focus()
        frmUsersAccounts.filteruser()
        SplashScreenManager.CloseForm()
    End Sub

    Private Sub BarButtonItem31_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdCorporateProfileSettings.ItemClick
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        If frmCompanySettings.Visible = True Then
            frmCompanySettings.Focus()
        Else
            frmCompanySettings.Show(Me)
        End If
        SplashScreenManager.CloseForm()
    End Sub

    Private Sub BarButtonItem32_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdCorporateDivision.ItemClick
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        frmDepartment.MdiParent = Me
        frmDepartment.Show()
        frmDepartment.Focus()
        frmDepartment.filter()
        SplashScreenManager.CloseForm()
    End Sub

    Private Sub BarButtonItem25_ItemClick_1(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdLoginAppearance.ItemClick
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        If frmAppearance.Visible = True Then
            frmAppearance.Focus()
        Else
            frmAppearance.Show(Me)
        End If
        SplashScreenManager.CloseForm()
    End Sub

    Private Sub BarButtonItem34_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdGeneralSettings.ItemClick
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        If frmGeneralSettings.Visible = True Then
            frmGeneralSettings.Focus()
        Else
            frmGeneralSettings.Show(Me)
        End If
        SplashScreenManager.CloseForm()
    End Sub

    Private Sub BarButtonItem31_ItemClick_1(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdMenuExit.ItemClick
        Dim gdt As String = GlobalDateTime()
        If XtraMessageBox.Show("Are you sure you want to exit system " & globaluser & "@" & globalfullname & " on " & globaldate & " - " & GlobalTime() & ") ?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            com.CommandText = "update tbllogin set outtime='" & gdt & "'  where userid='" & globaluserid & "'" : com.ExecuteNonQuery()
            End
        End If
    End Sub

    Private Sub BarButtonItem39_ItemClick_1(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdMyUserProfile.ItemClick
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        If frmUserProfile.Visible = True Then
            frmUserProfile.Focus()
        Else
            frmUserProfile.Show(Me)
        End If
        SplashScreenManager.CloseForm()
    End Sub
    Private Sub BarButtonItem35_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmdMenuAccountProfile.ItemClick

        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        frmUserProfile.Show(Me)
        SplashScreenManager.CloseForm()
    End Sub

    Private Sub BarButtonItem1_ItemClick_1(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles cmdWhatsNew.ItemClick
        Dim whats_new_location As String = Application.StartupPath.ToString & "\WhatsNew.rtf"
        Dim p As New System.Diagnostics.Process
        Dim s As New System.Diagnostics.ProcessStartInfo(whats_new_location)
        s.UseShellExecute = True
        s.WindowStyle = ProcessWindowStyle.Normal
        p.StartInfo = s
        p.Start()
    End Sub

    Private Sub BarButtonItem7_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem7.ItemClick
        If frmDatabaseRepair.Visible = True Then
            frmDatabaseRepair.Focus()
        Else
            frmDatabaseRepair.Show(Me)
        End If
    End Sub

    Private Sub cmdDatabaseRepair_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmdDatabaseRepair.ItemClick
        If frmDatabaseRepair.Visible = True Then
            frmDatabaseRepair.Focus()
        Else
            frmDatabaseRepair.Show(Me)
        End If
    End Sub

    Private Sub cmdBackupDatabase_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmdBackupDatabase.ItemClick
        If frmBackupTool.Visible = True Then
            frmBackupTool.Focus()
        Else
            frmBackupTool.Show(Me)
        End If
    End Sub

    Private Sub BarButtonItem8_ItemClick_1(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem8.ItemClick
        SplashScreenManager.CloseForm()
        rst.Close()
    End Sub

    Private Sub cmdFund_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmdFund.ItemClick
        If frmFund.Visible = True Then
            frmFund.Focus()
        Else
            frmFund.Show(Me)
        End If
    End Sub

    Private Sub cmdFundPeriod_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmdFundPeriod.ItemClick
        If frmFundPeriod.Visible = True Then
            frmFundPeriod.Focus()
        Else
            frmFundPeriod.Show(Me)
        End If
    End Sub

    Private Sub cmdCashflowItem_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmdCashflowItem.ItemClick
        If frmCashFlowItem.Visible = True Then
            frmCashFlowItem.Focus()
        Else
            frmCashFlowItem.Show(Me)
        End If
    End Sub

    Private Sub cmdAccountableForm_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmdAccountableForm.ItemClick
        If frmAccountableForm.Visible = True Then
            frmAccountableForm.Focus()
        Else
            frmAccountableForm.Show(Me)
        End If
    End Sub

    Private Sub cmdClientAccess_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmdClientAccess.ItemClick
        If frmClientUserPermission.Visible = True Then
            frmClientUserPermission.Focus()
        Else
            frmClientUserPermission.Show(Me)
        End If
    End Sub

    Private Sub cmdAccountTitleFilter_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmdAccountTitleFilter.ItemClick
        If frmTransactionCodeFilter.Visible = True Then
            frmTransactionCodeFilter.Focus()
        Else
            frmTransactionCodeFilter.Show(Me)
        End If
    End Sub

    Private Sub cmdJevReporting_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmdReportEntries.ItemClick
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        frmReportEntries.MdiParent = Me
        frmReportEntries.Show()
        frmReportEntries.Focus()
        SplashScreenManager.CloseForm()
    End Sub

    Private Sub cmdCollectionItem_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmdCollectionItem.ItemClick
        If frmCollectionItem.Visible = True Then
            frmCollectionItem.Focus()
        Else
            frmCollectionItem.Show(Me)
        End If
    End Sub

    Private Sub cmdTaxPayer_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmdTaxPayer.ItemClick
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        frmTaxpayerRecord.MdiParent = Me
        frmTaxpayerRecord.Show()
        frmTaxpayerRecord.Focus()
        SplashScreenManager.CloseForm()
    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmdExpenditureClass.ItemClick
        If frmExpenditureClass.Visible = True Then
            frmExpenditureClass.Focus()
        Else
            frmExpenditureClass.Show(Me)
        End If
    End Sub

    Private Sub cmdBudgetComposition_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmdBudgetComposition.ItemClick
        If frmBudgetComposition.Visible = True Then
            frmBudgetComposition.Focus()
        Else
            frmBudgetComposition.Show(Me)
        End If
    End Sub

    Private Sub cmdProductCategory_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmdProductCategory.ItemClick
        If frmProductCategory.Visible = True Then
            frmProductCategory.Focus()
        Else
            frmProductCategory.Show(Me)
        End If
    End Sub

    Private Sub cmdProductClassification_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmdProductClassification.ItemClick
        'If frmProductClass.Visible = True Then
        '    frmProductClass.Focus()
        'Else
        '    frmProductClass.Show(Me)
        'End If
    End Sub

    Private Sub cmdProductManagement_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmdProductManagement.ItemClick
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        frmProductManagement.MdiParent = Me
        frmProductManagement.Show()
        frmProductManagement.Focus()
        SplashScreenManager.CloseForm()
    End Sub

    Private Sub cmdNewProduct_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmdNewProduct.ItemClick
        If frmProductInfo.Visible = True Then
            frmProductInfo.Focus()
        Else
            frmProductInfo.Show(Me)
        End If
    End Sub

    Private Sub cmdRequisitionType_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmdRequisitionType.ItemClick
        If frmRequisitionType.Visible = True Then
            frmRequisitionType.Focus()
        Else
            frmRequisitionType.Show(Me)
        End If
    End Sub
 
    Private Sub cmdDocumentType_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmdDocumentType.ItemClick
        If frmDocumentType.Visible = True Then
            frmDocumentType.Focus()
        Else
            frmDocumentType.Show(Me)
        End If
    End Sub

    Private Sub cmdApprovingProcess_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmdApprovingProcess.ItemClick
        If frmApprovingProcess.Visible = True Then
            frmApprovingProcess.Focus()
        Else
            frmApprovingProcess.Show(Me)
        End If
    End Sub

    Private Sub cmdBankAccount_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmdBankAccount.ItemClick
        If frmBankAccounts.Visible = True Then
            frmBankAccounts.Focus()
        Else
            frmBankAccounts.Show(Me)
        End If
    End Sub

    Private Sub cmdExpenditureItem_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmdExpenditureItem.ItemClick
        If frmExpenditureItem.Visible = True Then
            frmExpenditureItem.Focus()
        Else
            frmExpenditureItem.Show(Me)
        End If
    End Sub

    Private Sub cmdJevEntries_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmdJevEntries.ItemClick
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        frmJevEntries.MdiParent = Me
        frmJevEntries.Show()
        frmJevEntries.Focus()
        SplashScreenManager.CloseForm()
    End Sub

    Private Sub cmdUpdateChartofAccounts_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmdUpdateChartofAccounts.ItemClick
        frmGLCaptureChartofAccount.ShowDialog(Me)
    End Sub

    Private Sub cmdGLItem_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmdGLItem.ItemClick
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        If frmGLChartofAccounts.Visible = True Then
            frmGLChartofAccounts.Focus()
        Else
            frmGLChartofAccounts.Show(Me)
        End If
        SplashScreenManager.CloseForm()
    End Sub

    Private Sub cmdInventoryAdjustment_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmdAdvanceSearch.ItemClick
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        frmErrorCorrect.MdiParent = Me
        frmErrorCorrect.Show()
        frmErrorCorrect.Focus()
        SplashScreenManager.CloseForm()
    End Sub

    Private Sub cmdRequisitionFilter_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmdRequisitionFilter.ItemClick
        If frmRequisitionFilter.Visible = True Then
            frmRequisitionFilter.Focus()
        Else
            frmRequisitionFilter.Show(Me)
        End If
    End Sub

    Private Sub cmdCashItem_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmdCashItem.ItemClick
        If frmCashItem.Visible = True Then
            frmCashItem.Focus()
        Else
            frmCashItem.Show(Me)
        End If
    End Sub

    Private Sub cmdQuarterlyBudget_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmdQuarterlyBudget.ItemClick
        If frmBudgetQuarterly.Visible = True Then
            frmBudgetQuarterly.Focus()
        Else
            frmBudgetQuarterly.Show(Me)
        End If
    End Sub

    Private Sub cmdAROexcemption_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmdAROexcemption.ItemClick
        If frmGLAroFilter.Visible = True Then
            frmGLAroFilter.Focus()
        Else
            frmGLAroFilter.Show(Me)
        End If
    End Sub

    Private Sub cmdCheckApprovalFilter_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmdCheckApprovalFilter.ItemClick
        If frmCheckApprovalFilter.Visible = True Then
            frmCheckApprovalFilter.Focus()
        Else
            frmCheckApprovalFilter.Show(Me)
        End If
    End Sub
End Class