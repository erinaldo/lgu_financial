<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRequisitionInfo
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.txtRequestNumber = New DevExpress.XtraEditors.TextEdit()
        Me.mode = New DevExpress.XtraEditors.TextEdit()
        Me.trnmode = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txtFund = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.gridFund = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.txtPostingDate = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.txtPurpose = New DevExpress.XtraEditors.MemoEdit()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.txtSource = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.gridSource = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtCurrentBalance = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.Em = New DevExpress.XtraGrid.GridControl()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmdAddItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.txtRequestType = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.gridRequestType = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.tabParticular = New DevExpress.XtraTab.XtraTabPage()
        Me.TextEdit4 = New DevExpress.XtraEditors.TextEdit()
        Me.tabAttachment = New DevExpress.XtraTab.XtraTabPage()
        Me.Em_files = New DevExpress.XtraGrid.GridControl()
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdViewAttachmentMain = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdRemoveAttachment = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.gridview_files = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RepositoryItemCheckEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl1 = New DevExpress.XtraBars.BarDockControl()
        Me.NextApprover = New DevExpress.XtraEditors.TextEdit()
        Me.CurrentLevel = New DevExpress.XtraEditors.TextEdit()
        Me.ckFinalApprover = New DevExpress.XtraEditors.CheckEdit()
        Me.CurrentApprover = New DevExpress.XtraEditors.TextEdit()
        Me.tabApprovalHistory = New DevExpress.XtraTab.XtraTabPage()
        Me.Em_approval = New DevExpress.XtraGrid.GridControl()
        Me.gridview_approval = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RepositoryItemCheckEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.tabDisbursement = New DevExpress.XtraTab.XtraTabPage()
        Me.Em_disbursement = New DevExpress.XtraGrid.GridControl()
        Me.gridDisbursement = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RepositoryItemCheckEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.periodcode = New DevExpress.XtraEditors.TextEdit()
        Me.fundcode = New DevExpress.XtraEditors.TextEdit()
        Me.yearcode = New DevExpress.XtraEditors.TextEdit()
        Me.requesttype = New DevExpress.XtraEditors.TextEdit()
        Me.sourceid = New DevExpress.XtraEditors.TextEdit()
        Me.pid = New DevExpress.XtraEditors.TextEdit()
        Me.requestno = New DevExpress.XtraEditors.TextEdit()
        Me.txtRequestby = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.gridrequestby = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.requestby = New DevExpress.XtraEditors.TextEdit()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.cmdClose = New System.Windows.Forms.ToolStripButton()
        Me.linedraft = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdSaveAsDraft = New System.Windows.Forms.ToolStripButton()
        Me.lineapproval = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdForApproval = New System.Windows.Forms.ToolStripButton()
        Me.lineUpload = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdDocManager = New System.Windows.Forms.ToolStripButton()
        Me.linePrintPR = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdPrintPR = New System.Windows.Forms.ToolStripButton()
        Me.lineCreatePO = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdCreatePO = New System.Windows.Forms.ToolStripButton()
        Me.txtOffice = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.gridOffice = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.officeid = New DevExpress.XtraEditors.TextEdit()
        Me.txtStatus = New DevExpress.XtraEditors.TextEdit()
        Me.txtPriority = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.txtRequestNumber.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trnmode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFund.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridFund, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPostingDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPostingDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPurpose.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSource.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCurrentBalance.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRequestType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridRequestType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.tabParticular.SuspendLayout()
        CType(Me.TextEdit4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabAttachment.SuspendLayout()
        CType(Me.Em_files, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip2.SuspendLayout()
        CType(Me.gridview_files, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NextApprover.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CurrentLevel.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ckFinalApprover.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CurrentApprover.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabApprovalHistory.SuspendLayout()
        CType(Me.Em_approval, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridview_approval, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabDisbursement.SuspendLayout()
        CType(Me.Em_disbursement, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridDisbursement, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.periodcode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fundcode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.yearcode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.requesttype.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sourceid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.requestno.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRequestby.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridrequestby, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.requestby.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.txtOffice.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridOffice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.officeid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtStatus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPriority.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.Location = New System.Drawing.Point(24, 82)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(99, 17)
        Me.LabelControl5.TabIndex = 656
        Me.LabelControl5.Text = "Request Number"
        '
        'txtRequestNumber
        '
        Me.txtRequestNumber.EditValue = "AUTO GENERATE"
        Me.txtRequestNumber.Location = New System.Drawing.Point(132, 78)
        Me.txtRequestNumber.Name = "txtRequestNumber"
        Me.txtRequestNumber.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtRequestNumber.Properties.Appearance.Options.UseFont = True
        Me.txtRequestNumber.Properties.Appearance.Options.UseTextOptions = True
        Me.txtRequestNumber.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtRequestNumber.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtRequestNumber.Properties.ReadOnly = True
        Me.txtRequestNumber.Size = New System.Drawing.Size(184, 26)
        Me.txtRequestNumber.TabIndex = 3
        '
        'mode
        '
        Me.mode.Location = New System.Drawing.Point(24, 613)
        Me.mode.Name = "mode"
        Me.mode.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mode.Properties.Appearance.Options.UseFont = True
        Me.mode.Properties.Appearance.Options.UseTextOptions = True
        Me.mode.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.mode.Properties.ReadOnly = True
        Me.mode.Size = New System.Drawing.Size(37, 24)
        Me.mode.TabIndex = 651
        Me.mode.Visible = False
        '
        'trnmode
        '
        Me.trnmode.Location = New System.Drawing.Point(63, 613)
        Me.trnmode.Name = "trnmode"
        Me.trnmode.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.trnmode.Properties.Appearance.Options.UseFont = True
        Me.trnmode.Properties.Appearance.Options.UseTextOptions = True
        Me.trnmode.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.trnmode.Properties.ReadOnly = True
        Me.trnmode.Size = New System.Drawing.Size(37, 24)
        Me.trnmode.TabIndex = 661
        Me.trnmode.Visible = False
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Location = New System.Drawing.Point(53, 202)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(70, 17)
        Me.LabelControl4.TabIndex = 922
        Me.LabelControl4.Text = "Fund Period"
        '
        'txtFund
        '
        Me.txtFund.EditValue = "sss"
        Me.txtFund.Location = New System.Drawing.Point(132, 198)
        Me.txtFund.Name = "txtFund"
        Me.txtFund.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtFund.Properties.Appearance.Options.UseFont = True
        Me.txtFund.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtFund.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtFund.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtFund.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtFund.Properties.DisplayMember = "Select"
        Me.txtFund.Properties.NullText = ""
        Me.txtFund.Properties.PopupView = Me.gridFund
        Me.txtFund.Properties.ValueMember = "code"
        Me.txtFund.Size = New System.Drawing.Size(275, 26)
        Me.txtFund.TabIndex = 2
        '
        'gridFund
        '
        Me.gridFund.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gridFund.Name = "gridFund"
        Me.gridFund.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridFund.OptionsView.ShowGroupPanel = False
        '
        'txtPostingDate
        '
        Me.txtPostingDate.EditValue = New Date(2019, 6, 10, 16, 23, 25, 399)
        Me.txtPostingDate.EnterMoveNextControl = True
        Me.txtPostingDate.Location = New System.Drawing.Point(132, 228)
        Me.txtPostingDate.Name = "txtPostingDate"
        Me.txtPostingDate.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.txtPostingDate.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtPostingDate.Properties.Appearance.Options.UseFont = True
        Me.txtPostingDate.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtPostingDate.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtPostingDate.Properties.AutoHeight = False
        Me.txtPostingDate.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtPostingDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtPostingDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtPostingDate.Properties.Mask.EditMask = "MMMM dd, yyyy"
        Me.txtPostingDate.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtPostingDate.Size = New System.Drawing.Size(275, 25)
        Me.txtPostingDate.TabIndex = 3
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.LabelControl6.Appearance.Options.UseFont = True
        Me.LabelControl6.Location = New System.Drawing.Point(49, 233)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(74, 17)
        Me.LabelControl6.TabIndex = 925
        Me.LabelControl6.Text = "Posting Date"
        '
        'txtPurpose
        '
        Me.txtPurpose.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtPurpose.EditValue = ""
        Me.txtPurpose.Location = New System.Drawing.Point(132, 257)
        Me.txtPurpose.Name = "txtPurpose"
        Me.txtPurpose.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtPurpose.Properties.Appearance.Options.UseFont = True
        Me.txtPurpose.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtPurpose.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtPurpose.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtPurpose.Size = New System.Drawing.Size(275, 100)
        Me.txtPurpose.TabIndex = 4
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.LabelControl7.Appearance.Options.UseFont = True
        Me.LabelControl7.Location = New System.Drawing.Point(75, 259)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(48, 17)
        Me.LabelControl7.TabIndex = 927
        Me.LabelControl7.Text = "Purpose"
        '
        'txtSource
        '
        Me.txtSource.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtSource.EditValue = "sss"
        Me.txtSource.Location = New System.Drawing.Point(132, 390)
        Me.txtSource.Name = "txtSource"
        Me.txtSource.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtSource.Properties.Appearance.Options.UseFont = True
        Me.txtSource.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtSource.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtSource.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtSource.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtSource.Properties.DisplayMember = "Select"
        Me.txtSource.Properties.NullText = ""
        Me.txtSource.Properties.PopupView = Me.gridSource
        Me.txtSource.Properties.ValueMember = "code"
        Me.txtSource.Size = New System.Drawing.Size(275, 26)
        Me.txtSource.TabIndex = 5
        '
        'gridSource
        '
        Me.gridSource.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gridSource.Name = "gridSource"
        Me.gridSource.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridSource.OptionsView.ShowGroupPanel = False
        '
        'LabelControl1
        '
        Me.LabelControl1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(35, 394)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(88, 17)
        Me.LabelControl1.TabIndex = 928
        Me.LabelControl1.Text = "Source of Fund"
        '
        'txtCurrentBalance
        '
        Me.txtCurrentBalance.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtCurrentBalance.EditValue = ""
        Me.txtCurrentBalance.Location = New System.Drawing.Point(132, 419)
        Me.txtCurrentBalance.Name = "txtCurrentBalance"
        Me.txtCurrentBalance.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtCurrentBalance.Properties.Appearance.Options.UseFont = True
        Me.txtCurrentBalance.Properties.Appearance.Options.UseTextOptions = True
        Me.txtCurrentBalance.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtCurrentBalance.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtCurrentBalance.Properties.Mask.BeepOnError = True
        Me.txtCurrentBalance.Properties.Mask.EditMask = "N2"
        Me.txtCurrentBalance.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtCurrentBalance.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtCurrentBalance.Properties.ReadOnly = True
        Me.txtCurrentBalance.Size = New System.Drawing.Size(168, 26)
        Me.txtCurrentBalance.TabIndex = 5
        '
        'LabelControl2
        '
        Me.LabelControl2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(32, 423)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(91, 17)
        Me.LabelControl2.TabIndex = 931
        Me.LabelControl2.Text = "Current Balance"
        '
        'Em
        '
        Me.Em.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Em.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Em.Location = New System.Drawing.Point(0, 0)
        Me.Em.MainView = Me.GridView1
        Me.Em.Name = "Em"
        Me.Em.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1})
        Me.Em.Size = New System.Drawing.Size(693, 399)
        Me.Em.TabIndex = 934
        Me.Em.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdAddItem, Me.SelectItemToolStripMenuItem, Me.DeleteItemToolStripMenuItem, Me.ToolStripSeparator4, Me.ToolStripMenuItem5})
        Me.ContextMenuStrip1.Name = "gridmenustrip"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(141, 98)
        '
        'cmdAddItem
        '
        Me.cmdAddItem.Image = Global.LGUClient.My.Resources.Resources.notebook__plus
        Me.cmdAddItem.Name = "cmdAddItem"
        Me.cmdAddItem.Size = New System.Drawing.Size(140, 22)
        Me.cmdAddItem.Text = "Add Item"
        '
        'SelectItemToolStripMenuItem
        '
        Me.SelectItemToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.SelectItemToolStripMenuItem.Image = Global.LGUClient.My.Resources.Resources.notebook__pencil
        Me.SelectItemToolStripMenuItem.Name = "SelectItemToolStripMenuItem"
        Me.SelectItemToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.SelectItemToolStripMenuItem.Text = "Edit Item"
        '
        'DeleteItemToolStripMenuItem
        '
        Me.DeleteItemToolStripMenuItem.Image = Global.LGUClient.My.Resources.Resources.notebook__minus
        Me.DeleteItemToolStripMenuItem.Name = "DeleteItemToolStripMenuItem"
        Me.DeleteItemToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.DeleteItemToolStripMenuItem.Text = "Delete Item"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(137, 6)
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Image = Global.LGUClient.My.Resources.Resources.arrow_continue_090
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(140, 22)
        Me.ToolStripMenuItem5.Text = "Refresh Data"
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.Em
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsSelection.MultiSelect = True
        Me.GridView1.OptionsSelection.UseIndicatorForSelection = False
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.RowAutoHeight = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        Me.RepositoryItemCheckEdit1.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        '
        'txtRequestType
        '
        Me.txtRequestType.EditValue = "sss"
        Me.txtRequestType.Location = New System.Drawing.Point(132, 108)
        Me.txtRequestType.Name = "txtRequestType"
        Me.txtRequestType.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtRequestType.Properties.Appearance.Options.UseFont = True
        Me.txtRequestType.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtRequestType.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtRequestType.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtRequestType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtRequestType.Properties.DisplayMember = "Select"
        Me.txtRequestType.Properties.NullText = ""
        Me.txtRequestType.Properties.PopupView = Me.gridRequestType
        Me.txtRequestType.Properties.ValueMember = "code"
        Me.txtRequestType.Size = New System.Drawing.Size(275, 26)
        Me.txtRequestType.TabIndex = 0
        '
        'gridRequestType
        '
        Me.gridRequestType.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gridRequestType.Name = "gridRequestType"
        Me.gridRequestType.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridRequestType.OptionsView.ShowGroupPanel = False
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.LabelControl8.Appearance.Options.UseFont = True
        Me.LabelControl8.Location = New System.Drawing.Point(44, 112)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(79, 17)
        Me.LabelControl8.TabIndex = 935
        Me.LabelControl8.Text = "Request Type"
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.XtraTabControl1.AppearancePage.Header.Font = New System.Drawing.Font("Segoe UI", 10.75!)
        Me.XtraTabControl1.AppearancePage.Header.Options.UseFont = True
        Me.XtraTabControl1.Location = New System.Drawing.Point(427, 43)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.tabParticular
        Me.XtraTabControl1.Size = New System.Drawing.Size(699, 433)
        Me.XtraTabControl1.TabIndex = 940
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.tabParticular, Me.tabAttachment, Me.tabApprovalHistory, Me.tabDisbursement})
        '
        'tabParticular
        '
        Me.tabParticular.Controls.Add(Me.Em)
        Me.tabParticular.Controls.Add(Me.TextEdit4)
        Me.tabParticular.Name = "tabParticular"
        Me.tabParticular.Size = New System.Drawing.Size(693, 399)
        Me.tabParticular.Text = "Particular Item List"
        '
        'TextEdit4
        '
        Me.TextEdit4.Location = New System.Drawing.Point(1055, 25)
        Me.TextEdit4.Name = "TextEdit4"
        Me.TextEdit4.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextEdit4.Properties.Appearance.Options.UseFont = True
        Me.TextEdit4.Properties.Appearance.Options.UseTextOptions = True
        Me.TextEdit4.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.TextEdit4.Properties.ReadOnly = True
        Me.TextEdit4.Size = New System.Drawing.Size(77, 24)
        Me.TextEdit4.TabIndex = 508
        Me.TextEdit4.Visible = False
        '
        'tabAttachment
        '
        Me.tabAttachment.Controls.Add(Me.Em_files)
        Me.tabAttachment.Controls.Add(Me.barDockControlRight)
        Me.tabAttachment.Controls.Add(Me.BarDockControl1)
        Me.tabAttachment.Controls.Add(Me.NextApprover)
        Me.tabAttachment.Controls.Add(Me.CurrentLevel)
        Me.tabAttachment.Controls.Add(Me.ckFinalApprover)
        Me.tabAttachment.Controls.Add(Me.CurrentApprover)
        Me.tabAttachment.Name = "tabAttachment"
        Me.tabAttachment.Size = New System.Drawing.Size(693, 399)
        Me.tabAttachment.Text = "Attached Document Files"
        '
        'Em_files
        '
        Me.Em_files.ContextMenuStrip = Me.ContextMenuStrip2
        Me.Em_files.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Em_files.Location = New System.Drawing.Point(0, 0)
        Me.Em_files.MainView = Me.gridview_files
        Me.Em_files.Name = "Em_files"
        Me.Em_files.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit2})
        Me.Em_files.Size = New System.Drawing.Size(693, 399)
        Me.Em_files.TabIndex = 935
        Me.Em_files.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridview_files})
        '
        'ContextMenuStrip2
        '
        Me.ContextMenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.cmdViewAttachmentMain, Me.cmdRemoveAttachment, Me.ToolStripSeparator1, Me.ToolStripMenuItem2})
        Me.ContextMenuStrip2.Name = "gridmenustrip"
        Me.ContextMenuStrip2.Size = New System.Drawing.Size(213, 98)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripMenuItem1.Image = Global.LGUClient.My.Resources.Resources.inbox__plus
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(212, 22)
        Me.ToolStripMenuItem1.Text = "Attach Document Files"
        '
        'cmdViewAttachmentMain
        '
        Me.cmdViewAttachmentMain.Image = Global.LGUClient.My.Resources.Resources.inbox_document_text
        Me.cmdViewAttachmentMain.Name = "cmdViewAttachmentMain"
        Me.cmdViewAttachmentMain.Size = New System.Drawing.Size(212, 22)
        Me.cmdViewAttachmentMain.Text = "View Selected Attachment"
        '
        'cmdRemoveAttachment
        '
        Me.cmdRemoveAttachment.Image = Global.LGUClient.My.Resources.Resources.inbox__minus
        Me.cmdRemoveAttachment.Name = "cmdRemoveAttachment"
        Me.cmdRemoveAttachment.Size = New System.Drawing.Size(212, 22)
        Me.cmdRemoveAttachment.Text = "Remove Attachment"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(209, 6)
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Image = Global.LGUClient.My.Resources.Resources.arrow_continue_090
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(212, 22)
        Me.ToolStripMenuItem2.Text = "Refresh Data"
        '
        'gridview_files
        '
        Me.gridview_files.GridControl = Me.Em_files
        Me.gridview_files.Name = "gridview_files"
        Me.gridview_files.OptionsBehavior.Editable = False
        Me.gridview_files.OptionsSelection.MultiSelect = True
        Me.gridview_files.OptionsSelection.UseIndicatorForSelection = False
        Me.gridview_files.OptionsView.ColumnAutoWidth = False
        Me.gridview_files.OptionsView.ShowGroupPanel = False
        '
        'RepositoryItemCheckEdit2
        '
        Me.RepositoryItemCheckEdit2.Name = "RepositoryItemCheckEdit2"
        Me.RepositoryItemCheckEdit2.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(693, 0)
        Me.barDockControlRight.Manager = Nothing
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 399)
        '
        'BarDockControl1
        '
        Me.BarDockControl1.CausesValidation = False
        Me.BarDockControl1.Dock = System.Windows.Forms.DockStyle.Right
        Me.BarDockControl1.Location = New System.Drawing.Point(693, 0)
        Me.BarDockControl1.Manager = Nothing
        Me.BarDockControl1.Size = New System.Drawing.Size(0, 399)
        '
        'NextApprover
        '
        Me.NextApprover.Location = New System.Drawing.Point(322, 345)
        Me.NextApprover.Name = "NextApprover"
        Me.NextApprover.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NextApprover.Properties.Appearance.Options.UseFont = True
        Me.NextApprover.Properties.Appearance.Options.UseTextOptions = True
        Me.NextApprover.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.NextApprover.Properties.ReadOnly = True
        Me.NextApprover.Size = New System.Drawing.Size(37, 24)
        Me.NextApprover.TabIndex = 954
        Me.NextApprover.Visible = False
        '
        'CurrentLevel
        '
        Me.CurrentLevel.Location = New System.Drawing.Point(233, 345)
        Me.CurrentLevel.Name = "CurrentLevel"
        Me.CurrentLevel.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CurrentLevel.Properties.Appearance.Options.UseFont = True
        Me.CurrentLevel.Properties.Appearance.Options.UseTextOptions = True
        Me.CurrentLevel.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.CurrentLevel.Properties.ReadOnly = True
        Me.CurrentLevel.Size = New System.Drawing.Size(37, 24)
        Me.CurrentLevel.TabIndex = 952
        Me.CurrentLevel.Visible = False
        '
        'ckFinalApprover
        '
        Me.ckFinalApprover.Location = New System.Drawing.Point(365, 348)
        Me.ckFinalApprover.Name = "ckFinalApprover"
        Me.ckFinalApprover.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckFinalApprover.Properties.Appearance.Options.UseFont = True
        Me.ckFinalApprover.Properties.Caption = "FinalApprover"
        Me.ckFinalApprover.Size = New System.Drawing.Size(99, 19)
        Me.ckFinalApprover.TabIndex = 955
        Me.ckFinalApprover.Visible = False
        '
        'CurrentApprover
        '
        Me.CurrentApprover.Location = New System.Drawing.Point(279, 345)
        Me.CurrentApprover.Name = "CurrentApprover"
        Me.CurrentApprover.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CurrentApprover.Properties.Appearance.Options.UseFont = True
        Me.CurrentApprover.Properties.Appearance.Options.UseTextOptions = True
        Me.CurrentApprover.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.CurrentApprover.Properties.ReadOnly = True
        Me.CurrentApprover.Size = New System.Drawing.Size(37, 24)
        Me.CurrentApprover.TabIndex = 953
        Me.CurrentApprover.Visible = False
        '
        'tabApprovalHistory
        '
        Me.tabApprovalHistory.Controls.Add(Me.Em_approval)
        Me.tabApprovalHistory.Name = "tabApprovalHistory"
        Me.tabApprovalHistory.Size = New System.Drawing.Size(693, 399)
        Me.tabApprovalHistory.Text = "Approval History"
        '
        'Em_approval
        '
        Me.Em_approval.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Em_approval.Location = New System.Drawing.Point(0, 0)
        Me.Em_approval.MainView = Me.gridview_approval
        Me.Em_approval.Name = "Em_approval"
        Me.Em_approval.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit3})
        Me.Em_approval.Size = New System.Drawing.Size(693, 399)
        Me.Em_approval.TabIndex = 936
        Me.Em_approval.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridview_approval})
        '
        'gridview_approval
        '
        Me.gridview_approval.GridControl = Me.Em_approval
        Me.gridview_approval.Name = "gridview_approval"
        Me.gridview_approval.OptionsBehavior.Editable = False
        Me.gridview_approval.OptionsSelection.MultiSelect = True
        Me.gridview_approval.OptionsSelection.UseIndicatorForSelection = False
        Me.gridview_approval.OptionsView.ColumnAutoWidth = False
        Me.gridview_approval.OptionsView.ShowGroupPanel = False
        '
        'RepositoryItemCheckEdit3
        '
        Me.RepositoryItemCheckEdit3.Name = "RepositoryItemCheckEdit3"
        Me.RepositoryItemCheckEdit3.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        '
        'tabDisbursement
        '
        Me.tabDisbursement.Controls.Add(Me.Em_disbursement)
        Me.tabDisbursement.Name = "tabDisbursement"
        Me.tabDisbursement.Size = New System.Drawing.Size(693, 399)
        Me.tabDisbursement.Text = "Disbursement Voucher"
        '
        'Em_disbursement
        '
        Me.Em_disbursement.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Em_disbursement.Location = New System.Drawing.Point(0, 0)
        Me.Em_disbursement.MainView = Me.gridDisbursement
        Me.Em_disbursement.Name = "Em_disbursement"
        Me.Em_disbursement.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit4})
        Me.Em_disbursement.Size = New System.Drawing.Size(693, 399)
        Me.Em_disbursement.TabIndex = 935
        Me.Em_disbursement.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridDisbursement})
        '
        'gridDisbursement
        '
        Me.gridDisbursement.GridControl = Me.Em_disbursement
        Me.gridDisbursement.Name = "gridDisbursement"
        Me.gridDisbursement.OptionsBehavior.Editable = False
        Me.gridDisbursement.OptionsSelection.MultiSelect = True
        Me.gridDisbursement.OptionsSelection.UseIndicatorForSelection = False
        Me.gridDisbursement.OptionsView.ColumnAutoWidth = False
        Me.gridDisbursement.OptionsView.RowAutoHeight = True
        Me.gridDisbursement.OptionsView.ShowGroupPanel = False
        '
        'RepositoryItemCheckEdit4
        '
        Me.RepositoryItemCheckEdit4.Name = "RepositoryItemCheckEdit4"
        Me.RepositoryItemCheckEdit4.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        '
        'periodcode
        '
        Me.periodcode.Location = New System.Drawing.Point(141, 587)
        Me.periodcode.Name = "periodcode"
        Me.periodcode.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.periodcode.Properties.Appearance.Options.UseFont = True
        Me.periodcode.Properties.Appearance.Options.UseTextOptions = True
        Me.periodcode.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.periodcode.Properties.ReadOnly = True
        Me.periodcode.Size = New System.Drawing.Size(37, 24)
        Me.periodcode.TabIndex = 941
        Me.periodcode.Visible = False
        '
        'fundcode
        '
        Me.fundcode.Location = New System.Drawing.Point(180, 587)
        Me.fundcode.Name = "fundcode"
        Me.fundcode.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fundcode.Properties.Appearance.Options.UseFont = True
        Me.fundcode.Properties.Appearance.Options.UseTextOptions = True
        Me.fundcode.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.fundcode.Properties.ReadOnly = True
        Me.fundcode.Size = New System.Drawing.Size(37, 24)
        Me.fundcode.TabIndex = 942
        Me.fundcode.Visible = False
        '
        'yearcode
        '
        Me.yearcode.Location = New System.Drawing.Point(102, 613)
        Me.yearcode.Name = "yearcode"
        Me.yearcode.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.yearcode.Properties.Appearance.Options.UseFont = True
        Me.yearcode.Properties.Appearance.Options.UseTextOptions = True
        Me.yearcode.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.yearcode.Properties.ReadOnly = True
        Me.yearcode.Size = New System.Drawing.Size(37, 24)
        Me.yearcode.TabIndex = 943
        Me.yearcode.Visible = False
        '
        'requesttype
        '
        Me.requesttype.Location = New System.Drawing.Point(102, 587)
        Me.requesttype.Name = "requesttype"
        Me.requesttype.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.requesttype.Properties.Appearance.Options.UseFont = True
        Me.requesttype.Properties.Appearance.Options.UseTextOptions = True
        Me.requesttype.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.requesttype.Properties.ReadOnly = True
        Me.requesttype.Size = New System.Drawing.Size(37, 24)
        Me.requesttype.TabIndex = 944
        Me.requesttype.Visible = False
        '
        'sourceid
        '
        Me.sourceid.Location = New System.Drawing.Point(63, 587)
        Me.sourceid.Name = "sourceid"
        Me.sourceid.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sourceid.Properties.Appearance.Options.UseFont = True
        Me.sourceid.Properties.Appearance.Options.UseTextOptions = True
        Me.sourceid.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.sourceid.Properties.ReadOnly = True
        Me.sourceid.Size = New System.Drawing.Size(37, 24)
        Me.sourceid.TabIndex = 945
        Me.sourceid.Visible = False
        '
        'pid
        '
        Me.pid.Location = New System.Drawing.Point(180, 613)
        Me.pid.Name = "pid"
        Me.pid.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pid.Properties.Appearance.Options.UseFont = True
        Me.pid.Properties.Appearance.Options.UseTextOptions = True
        Me.pid.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.pid.Properties.ReadOnly = True
        Me.pid.Size = New System.Drawing.Size(37, 24)
        Me.pid.TabIndex = 946
        Me.pid.Visible = False
        '
        'requestno
        '
        Me.requestno.Location = New System.Drawing.Point(24, 587)
        Me.requestno.Name = "requestno"
        Me.requestno.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.requestno.Properties.Appearance.Options.UseFont = True
        Me.requestno.Properties.Appearance.Options.UseTextOptions = True
        Me.requestno.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.requestno.Properties.ReadOnly = True
        Me.requestno.Size = New System.Drawing.Size(37, 24)
        Me.requestno.TabIndex = 947
        Me.requestno.Visible = False
        '
        'txtRequestby
        '
        Me.txtRequestby.EditValue = "sss"
        Me.txtRequestby.Location = New System.Drawing.Point(132, 168)
        Me.txtRequestby.Name = "txtRequestby"
        Me.txtRequestby.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtRequestby.Properties.Appearance.Options.UseFont = True
        Me.txtRequestby.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtRequestby.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtRequestby.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtRequestby.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtRequestby.Properties.DisplayMember = "Select"
        Me.txtRequestby.Properties.NullText = ""
        Me.txtRequestby.Properties.PopupView = Me.gridrequestby
        Me.txtRequestby.Properties.ValueMember = "code"
        Me.txtRequestby.Size = New System.Drawing.Size(275, 26)
        Me.txtRequestby.TabIndex = 1
        '
        'gridrequestby
        '
        Me.gridrequestby.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gridrequestby.Name = "gridrequestby"
        Me.gridrequestby.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridrequestby.OptionsView.ShowGroupPanel = False
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.LabelControl9.Appearance.Options.UseFont = True
        Me.LabelControl9.Location = New System.Drawing.Point(59, 172)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(64, 17)
        Me.LabelControl9.TabIndex = 949
        Me.LabelControl9.Text = "Request By"
        '
        'requestby
        '
        Me.requestby.Location = New System.Drawing.Point(141, 613)
        Me.requestby.Name = "requestby"
        Me.requestby.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.requestby.Properties.Appearance.Options.UseFont = True
        Me.requestby.Properties.Appearance.Options.UseTextOptions = True
        Me.requestby.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.requestby.Properties.ReadOnly = True
        Me.requestby.Size = New System.Drawing.Size(37, 24)
        Me.requestby.TabIndex = 950
        Me.requestby.Visible = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.BackColor = System.Drawing.Color.Black
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdClose, Me.linedraft, Me.cmdSaveAsDraft, Me.lineapproval, Me.cmdForApproval, Me.lineUpload, Me.cmdDocManager, Me.linePrintPR, Me.cmdPrintPR, Me.lineCreatePO, Me.cmdCreatePO})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Padding = New System.Windows.Forms.Padding(10, 2, 1, 2)
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.Size = New System.Drawing.Size(1131, 35)
        Me.ToolStrip1.TabIndex = 951
        Me.ToolStrip1.Text = "ToolStrip3"
        '
        'cmdClose
        '
        Me.cmdClose.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.ForeColor = System.Drawing.Color.White
        Me.cmdClose.Image = Global.LGUClient.My.Resources.Resources.Action_Close
        Me.cmdClose.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmdClose.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(94, 28)
        Me.cmdClose.Text = "Exit Window"
        '
        'linedraft
        '
        Me.linedraft.Name = "linedraft"
        Me.linedraft.Size = New System.Drawing.Size(6, 31)
        '
        'cmdSaveAsDraft
        '
        Me.cmdSaveAsDraft.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSaveAsDraft.ForeColor = System.Drawing.Color.White
        Me.cmdSaveAsDraft.Image = Global.LGUClient.My.Resources.Resources.Save_16x16__2_
        Me.cmdSaveAsDraft.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmdSaveAsDraft.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdSaveAsDraft.Name = "cmdSaveAsDraft"
        Me.cmdSaveAsDraft.Size = New System.Drawing.Size(96, 28)
        Me.cmdSaveAsDraft.Text = "Save as Draft"
        '
        'lineapproval
        '
        Me.lineapproval.Name = "lineapproval"
        Me.lineapproval.Size = New System.Drawing.Size(6, 31)
        '
        'cmdForApproval
        '
        Me.cmdForApproval.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdForApproval.ForeColor = System.Drawing.Color.White
        Me.cmdForApproval.Image = Global.LGUClient.My.Resources.Resources.State_Validation_Valid
        Me.cmdForApproval.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmdForApproval.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdForApproval.Name = "cmdForApproval"
        Me.cmdForApproval.Size = New System.Drawing.Size(135, 28)
        Me.cmdForApproval.Text = "Submit for Approval"
        '
        'lineUpload
        '
        Me.lineUpload.Name = "lineUpload"
        Me.lineUpload.Size = New System.Drawing.Size(6, 31)
        '
        'cmdDocManager
        '
        Me.cmdDocManager.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDocManager.ForeColor = System.Drawing.Color.White
        Me.cmdDocManager.Image = Global.LGUClient.My.Resources.Resources.Upload_16x16
        Me.cmdDocManager.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmdDocManager.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdDocManager.Name = "cmdDocManager"
        Me.cmdDocManager.Size = New System.Drawing.Size(151, 28)
        Me.cmdDocManager.Text = "Upload Document Files"
        '
        'linePrintPR
        '
        Me.linePrintPR.Name = "linePrintPR"
        Me.linePrintPR.Size = New System.Drawing.Size(6, 31)
        Me.linePrintPR.Visible = False
        '
        'cmdPrintPR
        '
        Me.cmdPrintPR.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrintPR.ForeColor = System.Drawing.Color.White
        Me.cmdPrintPR.Image = Global.LGUClient.My.Resources.Resources.Print_16x16__2_
        Me.cmdPrintPR.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmdPrintPR.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdPrintPR.Name = "cmdPrintPR"
        Me.cmdPrintPR.Size = New System.Drawing.Size(148, 28)
        Me.cmdPrintPR.Text = "Print Purchase Request"
        Me.cmdPrintPR.Visible = False
        '
        'lineCreatePO
        '
        Me.lineCreatePO.Name = "lineCreatePO"
        Me.lineCreatePO.Size = New System.Drawing.Size(6, 31)
        Me.lineCreatePO.Visible = False
        '
        'cmdCreatePO
        '
        Me.cmdCreatePO.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCreatePO.ForeColor = System.Drawing.Color.White
        Me.cmdCreatePO.Image = Global.LGUClient.My.Resources.Resources.Copy_16x16__4_
        Me.cmdCreatePO.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmdCreatePO.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdCreatePO.Name = "cmdCreatePO"
        Me.cmdCreatePO.Size = New System.Drawing.Size(136, 28)
        Me.cmdCreatePO.Text = "Print Purchase Order"
        Me.cmdCreatePO.Visible = False
        '
        'txtOffice
        '
        Me.txtOffice.EditValue = "sss"
        Me.txtOffice.Location = New System.Drawing.Point(132, 138)
        Me.txtOffice.Name = "txtOffice"
        Me.txtOffice.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtOffice.Properties.Appearance.Options.UseFont = True
        Me.txtOffice.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtOffice.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtOffice.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtOffice.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtOffice.Properties.DisplayMember = "Select"
        Me.txtOffice.Properties.NullText = ""
        Me.txtOffice.Properties.PopupView = Me.gridOffice
        Me.txtOffice.Properties.ValueMember = "code"
        Me.txtOffice.Size = New System.Drawing.Size(275, 26)
        Me.txtOffice.TabIndex = 956
        '
        'gridOffice
        '
        Me.gridOffice.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gridOffice.Name = "gridOffice"
        Me.gridOffice.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridOffice.OptionsView.ShowGroupPanel = False
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(20, 142)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(103, 17)
        Me.LabelControl3.TabIndex = 957
        Me.LabelControl3.Text = "Requesting Office"
        '
        'officeid
        '
        Me.officeid.Location = New System.Drawing.Point(221, 587)
        Me.officeid.Name = "officeid"
        Me.officeid.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.officeid.Properties.Appearance.Options.UseFont = True
        Me.officeid.Properties.Appearance.Options.UseTextOptions = True
        Me.officeid.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.officeid.Properties.ReadOnly = True
        Me.officeid.Size = New System.Drawing.Size(37, 24)
        Me.officeid.TabIndex = 958
        Me.officeid.Visible = False
        '
        'txtStatus
        '
        Me.txtStatus.EditValue = "APPROVED"
        Me.txtStatus.Location = New System.Drawing.Point(132, 45)
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtStatus.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 12.75!)
        Me.txtStatus.Properties.Appearance.Options.UseBackColor = True
        Me.txtStatus.Properties.Appearance.Options.UseFont = True
        Me.txtStatus.Properties.Appearance.Options.UseTextOptions = True
        Me.txtStatus.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtStatus.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.txtStatus.Properties.ReadOnly = True
        Me.txtStatus.Size = New System.Drawing.Size(184, 28)
        Me.txtStatus.TabIndex = 959
        '
        'txtPriority
        '
        Me.txtPriority.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtPriority.EditValue = ""
        Me.txtPriority.Location = New System.Drawing.Point(132, 361)
        Me.txtPriority.Name = "txtPriority"
        Me.txtPriority.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtPriority.Properties.Appearance.Options.UseFont = True
        Me.txtPriority.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtPriority.Properties.AppearanceDropDown.Options.UseFont = True
        Me.txtPriority.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtPriority.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtPriority.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtPriority.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtPriority.Properties.Items.AddRange(New Object() {"Low", "Normal", "High", "Emergency"})
        Me.txtPriority.Properties.PopupSizeable = True
        Me.txtPriority.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.txtPriority.Size = New System.Drawing.Size(168, 26)
        Me.txtPriority.TabIndex = 960
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.LabelControl10.Appearance.Options.UseFont = True
        Me.LabelControl10.Location = New System.Drawing.Point(82, 367)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(41, 17)
        Me.LabelControl10.TabIndex = 961
        Me.LabelControl10.Text = "Priority"
        '
        'LabelControl11
        '
        Me.LabelControl11.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.LabelControl11.Appearance.Options.UseFont = True
        Me.LabelControl11.Location = New System.Drawing.Point(88, 51)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(35, 17)
        Me.LabelControl11.TabIndex = 962
        Me.LabelControl11.Text = "Status"
        '
        'frmRequisitionInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1131, 486)
        Me.Controls.Add(Me.LabelControl11)
        Me.Controls.Add(Me.LabelControl10)
        Me.Controls.Add(Me.txtStatus)
        Me.Controls.Add(Me.officeid)
        Me.Controls.Add(Me.txtOffice)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.requestby)
        Me.Controls.Add(Me.txtRequestby)
        Me.Controls.Add(Me.LabelControl9)
        Me.Controls.Add(Me.requestno)
        Me.Controls.Add(Me.pid)
        Me.Controls.Add(Me.sourceid)
        Me.Controls.Add(Me.requesttype)
        Me.Controls.Add(Me.yearcode)
        Me.Controls.Add(Me.fundcode)
        Me.Controls.Add(Me.periodcode)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Controls.Add(Me.txtRequestType)
        Me.Controls.Add(Me.LabelControl8)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.txtCurrentBalance)
        Me.Controls.Add(Me.txtSource)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.LabelControl7)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.txtPostingDate)
        Me.Controls.Add(Me.txtFund)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.trnmode)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.txtRequestNumber)
        Me.Controls.Add(Me.mode)
        Me.Controls.Add(Me.txtPurpose)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.txtPriority)
        Me.HelpButton = True
        Me.MinimumSize = New System.Drawing.Size(1147, 525)
        Me.Name = "frmRequisitionInfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Requistion Information"
        CType(Me.txtRequestNumber.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trnmode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFund.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridFund, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPostingDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPostingDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPurpose.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSource.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCurrentBalance.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRequestType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridRequestType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.tabParticular.ResumeLayout(False)
        CType(Me.TextEdit4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabAttachment.ResumeLayout(False)
        Me.tabAttachment.PerformLayout()
        CType(Me.Em_files, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip2.ResumeLayout(False)
        CType(Me.gridview_files, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NextApprover.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CurrentLevel.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ckFinalApprover.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CurrentApprover.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabApprovalHistory.ResumeLayout(False)
        CType(Me.Em_approval, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridview_approval, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabDisbursement.ResumeLayout(False)
        CType(Me.Em_disbursement, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridDisbursement, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.periodcode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fundcode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.yearcode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.requesttype.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sourceid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.requestno.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRequestby.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridrequestby, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.requestby.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.txtOffice.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridOffice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.officeid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtStatus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPriority.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtRequestNumber As DevExpress.XtraEditors.TextEdit
    Friend WithEvents mode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents trnmode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtFund As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents gridFund As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtPostingDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPurpose As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSource As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents gridSource As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCurrentBalance As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Em As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents txtRequestType As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents gridRequestType As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents tabParticular As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents TextEdit4 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents tabAttachment As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents Em_files As DevExpress.XtraGrid.GridControl
    Friend WithEvents gridview_files As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemCheckEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl1 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents periodcode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents fundcode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents yearcode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents requesttype As DevExpress.XtraEditors.TextEdit
    Friend WithEvents sourceid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents pid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents SelectItemToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteItemToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItem5 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents requestno As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtRequestby As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents gridrequestby As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents requestby As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ContextMenuStrip2 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdRemoveAttachment As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdViewAttachmentMain As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents cmdClose As System.Windows.Forms.ToolStripButton
    Friend WithEvents linedraft As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdSaveAsDraft As System.Windows.Forms.ToolStripButton
    Friend WithEvents lineapproval As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdForApproval As System.Windows.Forms.ToolStripButton
    Friend WithEvents lineUpload As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdDocManager As System.Windows.Forms.ToolStripButton
    Friend WithEvents tabApprovalHistory As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents Em_approval As DevExpress.XtraGrid.GridControl
    Friend WithEvents gridview_approval As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemCheckEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents CurrentLevel As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CurrentApprover As DevExpress.XtraEditors.TextEdit
    Friend WithEvents NextApprover As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtOffice As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents gridOffice As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents officeid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ckFinalApprover As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtStatus As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Private WithEvents txtPriority As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmdAddItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents linePrintPR As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdPrintPR As System.Windows.Forms.ToolStripButton
    Friend WithEvents lineCreatePO As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdCreatePO As System.Windows.Forms.ToolStripButton
    Friend WithEvents tabDisbursement As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents Em_disbursement As DevExpress.XtraGrid.GridControl
    Friend WithEvents gridDisbursement As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemCheckEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
End Class
