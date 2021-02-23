Imports System.Windows.Forms
Imports System.ComponentModel
Imports MySql.Data.MySqlClient
Imports System.Net.Mail
Imports DevExpress.LookAndFeel

Public Class MainForm
    Dim r As Rectangle = Screen.GetWorkingArea(Me)
    Private checkupdate As Boolean = True
    Dim bw As BackgroundWorker = New BackgroundWorker

    Sub New()
        InitSkins()
        InitializeComponent()
    End Sub

    Sub InitSkins()
        DevExpress.Skins.SkinManager.EnableFormSkins()
    End Sub
   
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Control) + Keys.F12 Then
            If LCase(globalusername) = "root" Then
                frmSystemUpdate.ShowDialog()
            Else
                MessageBox.Show("You are not allowed to enter this area!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        ElseIf keyData = (Keys.Control) + Keys.F11 Then
            If LCase(globalusername) = "root" Then
                frmAdminChangeUser.Show()
            End If
      
        End If
        Return ProcessCmdKey
    End Function

    Private Sub MainForm_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Notification()
        Timer1.Start()
    End Sub

    Private Sub MainForm_Deactivate(sender As Object, e As EventArgs) Handles Me.Deactivate
        Timer1.Stop()
    End Sub

    Private Sub MainForm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If ForceCloseSystem = False Then
            frmUserlogoff.ShowDialog()
            If formclose = False Then
                e.Cancel = True
                Exit Sub
            End If
            For i As Integer = My.Application.OpenForms.Count - 1 To 0 Step -1
                If My.Application.OpenForms.Item(i) IsNot Me And My.Application.OpenForms.Item(i) IsNot frmLogin Then
                    My.Application.OpenForms.Item(i).Close()
                End If
            Next i
            com.CommandText = "update tbllogin set outtime=current_timestamp  where userid='" & globaluserid & "' and outtime is null" : com.ExecuteNonQuery()
            CloseSystemDeclaration()
            frmLogin.Show()
        End If
    End Sub

    Private Sub MDIMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = ico
        bw.WorkerReportsProgress = True
        bw.WorkerSupportsCancellation = True
        AddHandler bw.DoWork, AddressOf bw_DoWork
        AddHandler bw.RunWorkerCompleted, AddressOf bw_RunWorkerCompleted
        'End declaration

        Notification()
        LoadMainSystemSettings()

        ToolStrip.Top = 0
        ToolStrip.Left = 0
        ToolStrip.Width = XtraScrollableControl1.Width - 20
        XtraScrollableControl1.HorizontalScroll.Visible = False

        txtVersion.Text = "Coffeecup " & fversion
        If globalUserRequiredUpdateInfo = True Then
            MessageBox.Show("New system update features can customized your own system prefered color, icons and profile picture, Please update your account information", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            ChangeAccountPasswordToolStripMenuItem.PerformClick()
        End If

        NotifyIcon1.Icon = Me.Icon

        If Not bw.IsBusy = True Then
            bw.RunWorkerAsync()
        End If

    End Sub

    Public Sub Notification()
        LoadSystemDefaultColor(globalFontColor)
        If globalAuthForApproval = True Or globalRootUser = True Then
            Dim requisition As Integer = countqry("tblrequisition", "(currentapprover = '" & compOfficeid & "' or (headofficeapproval=1 and officeid='" & compOfficeid & "') ) and forapproval=1 and draft=0 and cancelled=0")
            If requisition > 0 Then
                cmdforapproval.Text = "For Approval Request (" & requisition & ")"
                If globalFontColor = "LIGHT" Then
                    cmdforapproval.ForeColor = Color.Gold
                Else
                    cmdforapproval.ForeColor = Color.Red
                End If

            Else
                cmdforapproval.Text = "For Approval Request"
            End If
        End If

        If globalAuthCheckIssuanceRequest = True Or globalRootUser = True Then
            Dim checkissuance As Integer = countqry("tblrequisition", "approved=1 and checkapproved=0 and cancelled=0 and officeid in (select officeid from tblcheckapprovalfilter where permissioncode='" & globalAuthcode & "')")
            If checkissuance > 0 Then
                cmdCheckIssuanceRequest.Text = "Check Issuance Request (" & checkissuance & ")"
                If globalFontColor = "LIGHT" Then
                    cmdCheckIssuanceRequest.ForeColor = Color.Gold
                Else
                    cmdCheckIssuanceRequest.ForeColor = Color.Red
                End If

            Else
                cmdCheckIssuanceRequest.Text = "Check Issuance Request"
            End If
        End If

        If globalAuthRequisitionList = True Or globalRootUser = True Then
            Dim requisitionList As Integer = countqry("tblrequisition", "officeid='" & compOfficeid & "' and (forapproval=1 or draft=1 or hold=1) and cancelled=0")
            If requisitionList > 0 Then
                cmdRequisitionList.Text = "Pending Requisition (" & requisitionList & ")"
                If globalFontColor = "LIGHT" Then
                    cmdRequisitionList.ForeColor = Color.Gold
                Else
                    cmdRequisitionList.ForeColor = Color.Red
                End If

            Else
                cmdRequisitionList.Text = "Requisition Management"
            End If
        End If

        If globalAuthNewDisbursement = True Or globalRootUser = True Then
            Dim newdisbursementlist As Integer = countqry("tblrequisition", " approved=1 and cancelled=0 and voucher=0 and requesttype in (select code from tblrequisitiontype where enablevoucher=1)")
            If newdisbursementlist > 0 Then
                cmdNewDisbursement.Text = "New Disbursement (" & newdisbursementlist & ")"
                If globalFontColor = "LIGHT" Then
                    cmdNewDisbursement.ForeColor = Color.Gold
                Else
                    cmdNewDisbursement.ForeColor = Color.Red
                End If

            Else
                cmdNewDisbursement.Text = "New Disbursement"
            End If
        End If

        If globalAuthDisbursementList = True Or globalRootUser = True Then
            Dim disbursementlist As Integer = countqry("tbldisbursementvoucher", " cleared=0 and cancelled=0")
            If disbursementlist > 0 Then
                cmdDisbursementMgt.Text = "Disbursement Voucher (" & disbursementlist & ")"
                If globalFontColor = "LIGHT" Then
                    cmdDisbursementMgt.ForeColor = Color.Gold
                Else
                    cmdDisbursementMgt.ForeColor = Color.Red
                End If

            Else
                cmdDisbursementMgt.Text = "Disbursement Voucher"
            End If
        End If

        If globalAuthNewDirectJournal = True Or globalRootUser = True Then
            Dim newDirectJournal As Integer = countqry("tblrequisition", "approved=1 and cancelled=0 and jev=0 and requesttype in (select code from tblrequisitiontype where enablevoucher=0)")
            If newDirectJournal > 0 Then
                cmdDirectJournal.Text = "New Direct Journal (" & newDirectJournal & ")"
                If globalFontColor = "LIGHT" Then
                    cmdDirectJournal.ForeColor = Color.Gold
                Else
                    cmdDirectJournal.ForeColor = Color.Red
                End If

            Else
                cmdDirectJournal.Text = "New Direct Journal"
            End If
        End If

        If globalAuthJournalEntryVoucher = True Or globalRootUser = True Then
            Dim journallist As Integer = countqry("tbljournalentryvoucher", " cleared=0 and cancelled=0")
            If journallist > 0 Then
                cmdJournalEntryVoucher.Text = "Journal Entry Voucher (" & journallist & ")"
                If globalFontColor = "LIGHT" Then
                    cmdJournalEntryVoucher.ForeColor = Color.Gold
                Else
                    cmdJournalEntryVoucher.ForeColor = Color.Red
                End If

            Else
                cmdJournalEntryVoucher.Text = "Journal Entry Voucher"
            End If
        End If
    End Sub
   
    Public Sub LoadSystemAppearance(ByVal iconf As String, ByVal bgcolor As String, ByVal fontcolor As String)
        If Not ImageProfile Is Nothing Then
            Dim wd As Integer = ImageProfile.Height
            Dim CropRect As New Rectangle((ImageProfile.Width / 2) - (wd / 2), 0, wd, ImageProfile.Height)
            Dim CropImage = New Bitmap(CropRect.Width, CropRect.Height)
            Using grp = Graphics.FromImage(CropImage)
                grp.DrawImage(ImageProfile, New Rectangle(0, 0, CropRect.Width, CropRect.Height), CropRect, GraphicsUnit.Pixel)
            End Using
            Profileimg.Image = CropImage
        Else
            If IO.File.Exists(Application.StartupPath.ToString & "\Image\no-picture.jpg") = True Then
                Profileimg.Image = Image.FromFile(Application.StartupPath.ToString & "\Image\no-picture.jpg")
            Else
                Profileimg.Image = Nothing
            End If
        End If

        If iconf = "" Then
            iconf = "default"
        End If
        For Each ctrl In ToolStrip.Items
            If IO.File.Exists(Application.StartupPath.ToString & "\icon\" & iconf & "\" & ctrl.Name & ".png") = True Then
                ctrl.Image = Image.FromFile(Application.StartupPath.ToString & "\icon\" & iconf & "\" & ctrl.Name & ".png")
            ElseIf IO.File.Exists(Application.StartupPath.ToString & "\icon\default\" & ctrl.Name & ".png") = True Then
                ctrl.Image = Image.FromFile(Application.StartupPath.ToString & "\icon\default\" & ctrl.Name & ".png")
            Else

            End If
        Next

        If bgcolor = "" Then
            bgcolor = "34,34,34"
        End If

        Dim RGB As String() = bgcolor.Split(",")
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(Val(RGB(0)), Byte), Integer), CType(CType(Val(RGB(1)), Byte), Integer), CType(CType(Val(RGB(2)), Byte), Integer))
        XtraScrollableControl1.Appearance.ForeColor = Me.BackColor
        XtraScrollableControl1.Appearance.BackColor = Me.BackColor
        XtraScrollableControl1.Appearance.BackColor2 = Me.BackColor
        XtraScrollableControl1.LookAndFeel.SkinMaskColor = Me.BackColor
        XtraScrollableControl1.LookAndFeel.SkinMaskColor2 = Me.BackColor
        With Panel1
            .Width = XtraScrollableControl1.Width
            .Left = 0
            .Parent = XtraScrollableControl1
            .Height = 2
            .BackColor = Me.BackColor
            .BringToFront()

        End With

        If fontcolor = "" Then
            fontcolor = "LIGHT"
        End If
        LoadSystemDefaultColor(fontcolor)
    End Sub

    Public Sub LoadSystemDefaultColor(ByVal c As String)
        If c = "LIGHT" Then
            txtfullname.ForeColor = Color.White
            txtOffice.ForeColor = Color.LightGray
            txtPosition.ForeColor = Color.LightGray
            txtDateLogin.ForeColor = Color.LightGray
            txtVersion.ForeColor = Color.DimGray
            txtDeveloper.ForeColor = Color.DimGray
            For Each ctrl In ToolStrip.Items
                ctrl.ForeColor = Color.LightGray
            Next
            XtraScrollableControl1.LookAndFeel.SkinName = "DevExpress Dark Style"
        Else
            txtfullname.ForeColor = Color.Black
            txtOffice.ForeColor = Color.Black
            txtPosition.ForeColor = Color.Black
            txtDateLogin.ForeColor = Color.Black
            txtVersion.ForeColor = Color.Black
            txtDeveloper.ForeColor = Color.Black
            For Each ctrl In ToolStrip.Items
                ctrl.ForeColor = Color.Black
            Next
            XtraScrollableControl1.LookAndFeel.SkinName = "DevExpress Style"

        End If
    End Sub
    Public Sub LoadMainSystemSettings()
        Me.Cursor = Cursors.WaitCursor
        LoadFormAreaSize()

        ShowAllMenu(False)
        ValidateModule()
 
        ValidateUserAccounts()

        txtConnectedHost.Text = "Connected: " & sqlserver
        Me.Cursor = Cursors.Default
        Timer1.Enabled = True
    End Sub
    Public Sub LoadFormAreaSize()
        Me.Size = New Size(270, Screen.PrimaryScreen.WorkingArea.Height)
        Me.MaximumSize = New Size(270, Screen.PrimaryScreen.WorkingArea.Height)
        Me.MinimumSize = New Size(270, Screen.PrimaryScreen.WorkingArea.Height)
        Me.Location = New Point(r.Right - Me.Width, r.Bottom - Me.Height)
    End Sub

    Public Sub ValidateUserAccounts()
        txtfullname.Text = UCase(globalfullname)
        txtOffice.Text = compOfficename
        txtPosition.Text = globalposition
        txtDateLogin.Text = Format(Now, "MMMM dd, yyyy hh:mm:ss tt")
        lblSystemName.Text = "Coffeecup v" & fversion

        If LCase(globalusername) = "root" Then
            cmdChangeUserAccounts.Visible = True
        Else
            cmdChangeUserAccounts.Visible = False
        End If

        If countqry("tblaccountaccess", "userid='" & globaluserid & "'") > 1 Then
            cmdChangeUserAccess.Visible = True
        Else
            cmdChangeUserAccess.Visible = False
        End If
    End Sub

    Public Sub ValidateModule()
        If globalAuthCollectionPosting = True Then
            cmdCollection.Visible = True
            lineCollection.Visible = True
        Else
            cmdCollection.Visible = False
            lineCollection.Visible = False
        End If

        If globalAuthCedulaIndividual = True Then
            cmdCedulaIndividual.Visible = True
            lineCedulaIndividual.Visible = True
        Else
            cmdCedulaIndividual.Visible = False
            lineCedulaIndividual.Visible = False
        End If

        If globalAuthCedulaCorporation = True Then
            cmdCedulaCorporation.Visible = True
            lineCedulaCorporation.Visible = True
        Else
            cmdCedulaCorporation.Visible = False
            lineCedulaCorporation.Visible = False
        End If

        If globalAuthRealPropertyTax = True Then
            cmdRealPropertyTax.Visible = True
            lineRealPropertyTax.Visible = True
        Else
            cmdRealPropertyTax.Visible = False
            lineRealPropertyTax.Visible = False
        End If

        If globalAuthCollectionReport = True Then
            cmdCollectionReport.Visible = True
            lineCollectionReport.Visible = True
        Else
            cmdCollectionReport.Visible = False
            lineAccountableForms.Visible = False
        End If

        If globalAuthAccountableForm = True Then
            cmdAccountableForms.Visible = True
            lineAccountableForms.Visible = True
        Else
            cmdAccountableForms.Visible = False
            lineAccountableForms.Visible = False
        End If

        If globalAuthBusinessManagement = True Then
            cmdBusinessManagement.Visible = True
            lineBusinessManagement.Visible = True
        Else
            cmdBusinessManagement.Visible = False
            lineBusinessManagement.Visible = False
        End If

        If globalAuthRealPropertyMgt = True Then
            cmdRealPropertyManagement.Visible = True
            lineRealProperty.Visible = True
        Else
            cmdRealPropertyManagement.Visible = False
            lineRealProperty.Visible = False
        End If

        If globalAuthNewDirectJournal = True Then
            cmdDirectJournal.Visible = True
            lineDirectJournal.Visible = True
        Else
            cmdDirectJournal.Visible = False
            lineDirectJournal.Visible = False
        End If

        If globalAuthJournalEntryVoucher = True Then
            cmdJournalEntryVoucher.Visible = True
            lineJournalEntryVoucher.Visible = True
        Else
            cmdJournalEntryVoucher.Visible = False
            lineJournalEntryVoucher.Visible = False
        End If

        If globalAuthForApproval = True Then
            cmdforapproval.Visible = True
            lineForApproval.Visible = True
        Else
            cmdforapproval.Visible = False
            lineForApproval.Visible = False
        End If

        If globalAuthCheckIssuanceRequest = True Then
            cmdCheckIssuanceRequest.Visible = True
            lineCheckIssuanceRequest.Visible = True
        Else
            cmdCheckIssuanceRequest.Visible = False
            lineCheckIssuanceRequest.Visible = False
        End If

        If globalAuthNewRequisition = True Then
            cmdNewRequisition.Visible = True
            lineNewRequisition.Visible = True
        Else
            cmdNewRequisition.Visible = False
            lineNewRequisition.Visible = False
        End If

        If globalAuthRequisitionList = True Then
            cmdRequisitionList.Visible = True
            lineRequisitionList.Visible = True
        Else
            cmdRequisitionList.Visible = False
            lineRequisitionList.Visible = False
        End If

        If globalAuthNewDisbursement = True Then
            cmdNewDisbursement.Visible = True
            lineNewDisbursement.Visible = True
        Else
            cmdNewDisbursement.Visible = False
            lineNewDisbursement.Visible = False
        End If

        If globalAuthDisbursementList = True Then
            cmdDisbursementMgt.Visible = True
            lineDisbursementMgt.Visible = True
        Else
            cmdDisbursementMgt.Visible = False
            lineDisbursementMgt.Visible = False
        End If

        If globalAuthBudgetReport = True Then
            cmdBudgetReport.Visible = True
            lineBudgetReport.Visible = True
        Else
            cmdBudgetReport.Visible = False
            lineBudgetReport.Visible = False
        End If

        If LCase(globalusername) = "root" Then
            ShowAllMenu(True)
        End If
        Dim PanelHeight As Double = 0
        For Each itm In ToolStrip.Items
            If TypeOf itm Is ToolStripButton Or TypeOf itm Is ToolStripSeparator Then
                If itm.Visible = True Then
                    PanelHeight += itm.Height + itm.Padding.Top + itm.Padding.Bottom + itm.Margin.Top + itm.Margin.Bottom
                End If
            End If
        Next
        ToolStrip.Height = PanelHeight
        Panel1.Top = PanelHeight - 2
    End Sub

    Public Sub ShowAllMenu(ByVal showMenu As Boolean)
        cmdCollection.Visible = showMenu
        lineCollection.Visible = showMenu

        cmdCedulaIndividual.Visible = showMenu
        lineCedulaIndividual.Visible = showMenu

        cmdCedulaCorporation.Visible = showMenu
        lineCedulaCorporation.Visible = showMenu

        cmdRealPropertyTax.Visible = showMenu
        lineRealPropertyTax.Visible = showMenu

        cmdCollectionReport.Visible = showMenu
        lineCollectionReport.Visible = showMenu

        cmdAccountableForms.Visible = showMenu
        lineAccountableForms.Visible = showMenu

        cmdBusinessManagement.Visible = showMenu
        lineBusinessManagement.Visible = showMenu

        cmdRealPropertyManagement.Visible = showMenu
        lineRealProperty.Visible = showMenu

        cmdJournalEntryVoucher.Visible = showMenu
        lineJournalEntryVoucher.Visible = showMenu

        cmdforapproval.Visible = showMenu
        lineForApproval.Visible = showMenu

        cmdNewRequisition.Visible = showMenu
        lineNewRequisition.Visible = showMenu

        cmdRequisitionList.Visible = showMenu
        lineRequisitionList.Visible = showMenu

        cmdNewDisbursement.Visible = showMenu
        lineNewDisbursement.Visible = showMenu

        cmdDisbursementMgt.Visible = showMenu
        lineDisbursementMgt.Visible = showMenu

        cmdBudgetReport.Visible = showMenu
        lineBudgetReport.Visible = showMenu

    End Sub


    Private Sub BrowsePictureToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BrowsePictureToolStripMenuItem.Click
        ' (max size 163x163 png files)
        If MessageBox.Show("Please use PNG or GIF image file. (Max Resolution 163x163 Pixel size!). Are you sure you want to continue?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
            Dim objOpenFileDialog As New OpenFileDialog
            'Set the Open dialog properties
            With objOpenFileDialog
                ' .Filter = "JPEG files (.jpg)|*.jpg , PNG files (.png)|*.png , GIF files (.gif)|*.gif"
                .Filter = "PNG files (*.png)|*.png|JPG files (*.jpg)|*.jpg|GIF files (*.gif)|*.gif"
                .FilterIndex = 1
                .Title = "Open File Dialog"
            End With

            'Show the Open dialog and if the user clicks the Open button,
            'load the file
            If objOpenFileDialog.ShowDialog = System.Windows.Forms.DialogResult.OK Then
                Dim allText As String
                Try
                    'Read the contents of the file
                    allText = My.Computer.FileSystem.GetParentPath(objOpenFileDialog.FileName)
                    loadimage.ImageLocation = objOpenFileDialog.FileName
                Catch fileException As Exception
                    Throw fileException
                End Try
            End If

            'Clean up
            objOpenFileDialog.Dispose()
            objOpenFileDialog = Nothing
        End If
    End Sub

    Private Sub mainname_Click(sender As Object, e As EventArgs) Handles lblSystemName.Click
        frmSystemInfo.ShowDialog()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs)
        frmChatBoxMain.Show()
    End Sub


    Private Sub AboutCoffeecupToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutCoffeecupToolStripMenuItem.Click
        While BackgroundWorker1.IsBusy()
            Application.DoEvents()
        End While
        frmSystemInfo.ShowDialog()
    End Sub

    Private Sub ConnectionSetupToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConnectionSetupToolStripMenuItem.Click
        If LCase(globalusername) = "root" Then
            frmConnectionSetup.ShowDialog()
        Else
            MessageBox.Show("You are not allowed to enter this area!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub NotifyIcon1_BalloonTipClicked(sender As Object, e As EventArgs) Handles NotifyIcon1.BalloonTipClicked
        If frmChatBoxMain.Visible = False Then
            frmChatBoxMain.Show()
        Else
            frmChatBoxMain.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub DoThreadedStuff()
        If Me.InvokeRequired Then
            Me.Invoke(Sub() CheckChatNotification())
        Else
            CheckChatNotification()
        End If
    End Sub

    Private Sub bw_DoWork(ByVal sender As Object, ByVal e As DoWorkEventArgs)
        Dim worker As BackgroundWorker = CType(sender, BackgroundWorker)
        For i = 1 To 1
            Timer1.Stop()
            If bw.CancellationPending = True Then
                e.Cancel = True
                Exit For
            End If
            DoThreadedStuff()
            'System.Threading.Thread.Sleep(1000)
        Next
    End Sub

    Public Sub CheckChatNotification()
        dst2 = New DataSet : dst2.Clear()
        msda2 = New MySqlDataAdapter("select id, message,isnotified,(select fullname from tblaccounts where accountid=tblchatlogs.sender) as namesender from tblchatlogs where receiver='" & globaluserid & "' and isread=0", conn)
        msda2.SelectCommand.CommandTimeout = 6000000
        msda2.Fill(dst2, 0)

        For cnt = 0 To dst2.Tables(0).Rows.Count - 1
            If CBool(dst2.Tables(0).Rows(cnt)("isnotified").ToString()) = False Then
                com.CommandText = "update tblchatlogs set isnotified=1 where id='" & dst2.Tables(0).Rows(cnt)("id").ToString() & "'" : com.ExecuteNonQuery()
                If frmChatBoxMain.Visible = False Or frmChatBoxMain.WindowState = FormWindowState.Minimized Then
                    NotifyIcon1.BalloonTipIcon = ToolTipIcon.Info
                    NotifyIcon1.BalloonTipTitle = dst2.Tables(0).Rows(cnt)("namesender").ToString()
                    NotifyIcon1.BalloonTipText = dst2.Tables(0).Rows(cnt)("message").ToString() & Environment.NewLine & "Click here to view chat box.."
                    NotifyIcon1.ShowBalloonTip(1000)
                End If
            End If
        Next

        Dim msg As Integer = dst2.Tables(0).Rows.Count
        If msg > 0 Then
            cmdChatbox.Text = "Coffeecup Chat Box (" & msg & ")"
            If globalFontColor = "LIGHT" Then
                cmdChatbox.ForeColor = Color.Gold
            Else
                cmdChatbox.ForeColor = Color.Red
            End If
        Else
            cmdChatbox.Text = "Coffeecup Chat Box"

            If globalFontColor = "LIGHT" Then
                cmdChatbox.ForeColor = Color.LightGray
            Else
                cmdChatbox.ForeColor = Color.Black
            End If
        End If
    End Sub

    Private Sub bw_RunWorkerCompleted(ByVal sender As Object, ByVal e As RunWorkerCompletedEventArgs)
        If e.Error IsNot Nothing Then
            NotifyIcon1.BalloonTipIcon = ToolTipIcon.Error
            NotifyIcon1.BalloonTipTitle = "Cannot connect to server"
            NotifyIcon1.BalloonTipText = e.Result.ToString
            NotifyIcon1.ShowBalloonTip(1000)
        End If
        Timer1.Start()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        If frmSystemInfo.Visible = False Then
            frmSystemInfo.ShowDialog()
        Else
            frmSystemInfo.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Not bw.IsBusy = True Then
            bw.RunWorkerAsync()
        End If
    End Sub


    Private Sub ChangeAccountPasswordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangeAccountPasswordToolStripMenuItem.Click
        While BackgroundWorker1.IsBusy()
            Application.DoEvents()
        End While
        If frmAccountInformation.Visible = False Then
            frmAccountInformation.Show(Me)
        Else
            frmAccountInformation.WindowState = FormWindowState.Normal
        End If
    End Sub


    Private Sub cmdAccountableForms_Click_1(sender As Object, e As EventArgs) Handles cmdAccountableForms.Click
        If frmAccountableForms.Visible = False Then
            frmAccountableForms.Show(Me)
        Else
            frmAccountableForms.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles txtConnectedHost.LinkClicked
        'Process.Start("www.coffeecupsoft.com")
    End Sub

    Private Sub ProcessFlowAndFeaturesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProcessFlowAndFeaturesToolStripMenuItem.Click
        Dim whats_new_location As String = Application.StartupPath.ToString & "\processflow.pdf"
        Dim p As New System.Diagnostics.Process
        Dim s As New System.Diagnostics.ProcessStartInfo(whats_new_location)
        s.UseShellExecute = True
        s.WindowStyle = ProcessWindowStyle.Normal
        p.StartInfo = s
        p.Start()
    End Sub

    Private Sub cmdChangeUserAccess_Click(sender As Object, e As EventArgs) Handles cmdChangeUserAccess.Click
        frmChangeUserAccess.Show()
    End Sub

    Private Sub Profileimg_Click(sender As Object, e As EventArgs) Handles Profileimg.Click
        If frmAccountInformation.Visible = True Then
            frmAccountInformation.Focus()
        Else
            frmAccountInformation.ShowDialog(Me)
        End If
    End Sub

    Private Sub cmdChatbox_Click(sender As Object, e As EventArgs) Handles cmdChatbox.Click
        If frmChatBoxMain.Visible = True Then
            frmChatBoxMain.Focus()
        Else
            frmChatBoxMain.Show()
        End If
        frmChatBoxMain.ListControl1.Focus()
    End Sub

    Private Sub settingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles cmdContexChatBox.Click
        If frmChatBoxMain.Visible = True Then
            frmChatBoxMain.Focus()
        Else
            frmChatBoxMain.Show()
        End If
        frmChatBoxMain.ListControl1.Focus()
    End Sub


    Private Sub cmdCollection_Click(sender As Object, e As EventArgs) Handles cmdCollection.Click
        frmCollectionMenu.mode.Text = "collection"
        If frmCollectionMenu.Visible = True Then
            frmCollectionMenu.Focus()
        Else
            frmCollectionMenu.Show(Me)
        End If
    End Sub


    Private Sub cmdCommunityTax_Click(sender As Object, e As EventArgs) Handles cmdCedulaIndividual.Click
        frmCollectionMenu.mode.Text = "cedulaindividual"
        If frmCollectionMenu.Visible = True Then
            frmCollectionMenu.Focus()
        Else
            frmCollectionMenu.Show(Me)
        End If
    End Sub

    Private Sub cmdCedulaCorporation_Click(sender As Object, e As EventArgs) Handles cmdCedulaCorporation.Click
        frmCollectionMenu.mode.Text = "cedulacorporate"
        If frmCollectionMenu.Visible = True Then
            frmCollectionMenu.Focus()
        Else
            frmCollectionMenu.Show(Me)
        End If
    End Sub

    Public Sub ProceedCollection(ByVal proceed As Boolean, ByVal periodcode As String, ByVal fundcode As String, ByVal fundname As String, ByVal yeartrn As String, ByVal trndate As Date, ByVal mode As String, ByVal frm As Form)
        If proceed = True Then
            If mode = "collection" Then
                frmCollectionPosting.periodcode.Text = periodcode
                frmCollectionPosting.fundcode.Text = fundcode
                frmCollectionPosting.txtFundTitle.Text = fundname
                frmCollectionPosting.yeartrn.Text = yeartrn
                frmCollectionPosting.txtCollectionDate.EditValue = trndate
                If frmCollectionPosting.Visible = True Then
                    frmCollectionPosting.Focus()
                Else
                    frmCollectionPosting.Show(Me)
                End If
                frm.Close()

            ElseIf mode = "cedulaindividual" Then
                frmCedulaIndividual.periodcode.Text = periodcode
                frmCedulaIndividual.fundcode.Text = fundcode
                frmCedulaIndividual.txtFundTitle.Text = fundname
                frmCedulaIndividual.yeartrn.Text = yeartrn
                frmCedulaIndividual.txtCollectionDate.EditValue = trndate
                If frmCedulaIndividual.Visible = True Then
                    frmCedulaIndividual.Focus()
                Else
                    frmCedulaIndividual.Show(Me)
                End If
                frm.Close()

            ElseIf mode = "cedulacorporate" Then
                frmCedulaCorporation.periodcode.Text = periodcode
                frmCedulaCorporation.fundcode.Text = fundcode
                frmCedulaCorporation.txtFundTitle.Text = fundname
                frmCedulaCorporation.yeartrn.Text = yeartrn
                frmCedulaCorporation.txtCollectionDate.EditValue = trndate
                If frmCedulaCorporation.Visible = True Then
                    frmCedulaCorporation.Focus()
                Else
                    frmCedulaCorporation.Show(Me)
                End If
                frm.Close()


            ElseIf mode = "property" Then
                'LoadXgrid("Select  id as 'Inventory Code', (select description from tblaccountableform where code=a.formcode) as 'Form', SeriesFrom,SeriesTo,CurrentNo, InUsed  from tblforminventory as a where formcode in (select defaultpropertytax from tbldefaultsettings) and officeid='" & compOfficeid & "' and accountable='" & globaluserid & "' order by seriesfrom asc", "tblforminventory", Em, GridView1)
            End If
        End If
    End Sub

    Private Sub cmdUserSettings_Click_1(sender As Object, e As EventArgs) Handles cmdUserSettings.Click
        frmLXPrinterSettings.ShowDialog(Me)
    End Sub

    Private Sub CmdRealPropertyManagement_Click(sender As Object, e As EventArgs) Handles cmdRealPropertyManagement.Click
        If frmRealProperty.Visible = True Then
            frmRealProperty.Focus()
        Else
            frmRealProperty.Show(Me)
        End If
    End Sub

    Private Sub cmdAccountableReport_Click(sender As Object, e As EventArgs) Handles cmdCollectionReport.Click
        If frmCollectionReport.Visible = True Then
            frmCollectionReport.Focus()
        Else
            frmCollectionReport.Show(Me)
        End If
    End Sub

    Private Sub cmdRealPropertyTax_Click(sender As Object, e As EventArgs) Handles cmdRealPropertyTax.Click
        If frmRealPropertyTax.Visible = True Then
            frmRealPropertyTax.Focus()
        Else
            frmRealPropertyTax.Show(Me)
        End If
    End Sub

    
    Private Sub cmdBusinessManagement_Click(sender As Object, e As EventArgs) Handles cmdBusinessManagement.Click
        If frmBusinessManagement.Visible = True Then
            frmBusinessManagement.Focus()
        Else
            frmBusinessManagement.Show(Me)
        End If
    End Sub

   
    Private Sub cmdNewRequisition_Click(sender As Object, e As EventArgs) Handles cmdNewRequisition.Click
        If globalAllowAdd = False Then
            MessageBox.Show("Your access not allowed to add!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        frmRequisitionInfo.mode.Text = "new"
        If frmRequisitionInfo.Visible = True Then
            frmRequisitionInfo.Focus()
        Else
            frmRequisitionInfo.Show(Me)
        End If
    End Sub

    Private Sub cmdRequisitionList_Click(sender As Object, e As EventArgs) Handles cmdRequisitionList.Click
        If frmRequisitionList.Visible = True Then
            frmRequisitionList.Focus()
        Else
            frmRequisitionList.Show(Me)
        End If
    End Sub

    Private Sub cmdForApprovalList_Click(sender As Object, e As EventArgs) Handles cmdforapproval.Click
        If frmForApprovalRequisition.Visible = True Then
            frmForApprovalRequisition.Focus()
        Else
            frmForApprovalRequisition.ShowDialog(Me)
        End If
    End Sub

    Private Sub cmdNewDisbursement_Click(sender As Object, e As EventArgs) Handles cmdNewDisbursement.Click
        If globalAllowAdd = False Then
            MessageBox.Show("Your access not allowed to add!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        frmVoucherInfo.ShowDialog(Me)
    End Sub

    Private Sub cmdDisbursementMgt_Click(sender As Object, e As EventArgs) Handles cmdDisbursementMgt.Click
        If frmDisbursementList.Visible = True Then
            frmDisbursementList.Focus()
        Else
            frmDisbursementList.Show(Me)
        End If
    End Sub

    Private Sub cmdJournalEntryVoucher_Click(sender As Object, e As EventArgs) Handles cmdJournalEntryVoucher.Click
        If frmJournalEntryList.Visible = True Then
            frmJournalEntryList.Focus()
        Else
            frmJournalEntryList.Show(Me)
        End If
    End Sub

    Private Sub cmdBudgetReport_Click(sender As Object, e As EventArgs) Handles cmdBudgetReport.Click
        If frmBudgetReports.Visible = True Then
            frmBudgetReports.Focus()
        Else
            frmBudgetReports.Show(Me)
        End If
    End Sub

    Private Sub cmdCheckIssuanceRequest_Click(sender As Object, e As EventArgs) Handles cmdCheckIssuanceRequest.Click
        If frmForApprovalCheckReleasing.Visible = True Then
            frmForApprovalCheckReleasing.Focus()
        Else
            frmForApprovalCheckReleasing.ShowDialog(Me)
        End If
    End Sub

    Private Sub cmdDirectJournal_Click(sender As Object, e As EventArgs) Handles cmdDirectJournal.Click
        If frmNewDirectJournal.Visible = True Then
            frmNewDirectJournal.Focus()
        Else
            frmNewDirectJournal.ShowDialog(Me)
        End If
    End Sub
End Class
