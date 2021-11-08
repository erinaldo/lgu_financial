<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAuthorizedUser
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAuthorizedUser))
        Me.lbloffice = New DevExpress.XtraEditors.LabelControl()
        Me.txtAccountName = New DevExpress.XtraEditors.TextEdit()
        Me.id = New DevExpress.XtraEditors.ButtonEdit()
        Me.mode = New DevExpress.XtraEditors.TextEdit()
        Me.gridmenustrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmdEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdDelete = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.cmdClose = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.Em = New DevExpress.XtraGrid.GridControl()
        Me.gridActiveAccess = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.tabActive = New DevExpress.XtraTab.XtraTabPage()
        Me.tabPrevious = New DevExpress.XtraTab.XtraTabPage()
        Me.Em_Logs = New DevExpress.XtraGrid.GridControl()
        Me.gridLogs = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RepositoryItemCheckEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl54 = New DevExpress.XtraEditors.LabelControl()
        Me.txtDateTo = New DevExpress.XtraEditors.DateEdit()
        Me.txtDateFrom = New DevExpress.XtraEditors.DateEdit()
        Me.txtAccessAccount = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.gridAccessTo = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton()
        Me.userid = New DevExpress.XtraEditors.TextEdit()
        Me.accessid = New DevExpress.XtraEditors.TextEdit()
        Me.ckEnableAuthorizedAccess = New DevExpress.XtraEditors.CheckEdit()
        CType(Me.txtAccountName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.id.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gridmenustrip.SuspendLayout()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridActiveAccess, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.tabActive.SuspendLayout()
        Me.tabPrevious.SuspendLayout()
        CType(Me.Em_Logs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridLogs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDateTo.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDateTo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDateFrom.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDateFrom.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAccessAccount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridAccessTo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.userid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.accessid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ckEnableAuthorizedAccess.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbloffice
        '
        Me.lbloffice.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.lbloffice.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.lbloffice.Appearance.Options.UseFont = True
        Me.lbloffice.Appearance.Options.UseForeColor = True
        Me.lbloffice.Appearance.Options.UseTextOptions = True
        Me.lbloffice.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lbloffice.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbloffice.Location = New System.Drawing.Point(10, 55)
        Me.lbloffice.Name = "lbloffice"
        Me.lbloffice.Size = New System.Drawing.Size(114, 16)
        Me.lbloffice.TabIndex = 390
        Me.lbloffice.Text = "Name of Account"
        '
        'txtAccountName
        '
        Me.txtAccountName.EditValue = ""
        Me.txtAccountName.EnterMoveNextControl = True
        Me.txtAccountName.Location = New System.Drawing.Point(132, 50)
        Me.txtAccountName.Name = "txtAccountName"
        Me.txtAccountName.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtAccountName.Properties.Appearance.Options.UseFont = True
        Me.txtAccountName.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtAccountName.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAccountName.Properties.ReadOnly = True
        Me.txtAccountName.Size = New System.Drawing.Size(284, 26)
        Me.txtAccountName.TabIndex = 0
        '
        'id
        '
        Me.id.EditValue = ""
        Me.id.Enabled = False
        Me.id.Location = New System.Drawing.Point(472, 78)
        Me.id.Name = "id"
        Me.id.Properties.Appearance.Options.UseTextOptions = True
        Me.id.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.id.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.id.Properties.Mask.BeepOnError = True
        Me.id.Size = New System.Drawing.Size(44, 20)
        Me.id.TabIndex = 386
        Me.id.Visible = False
        '
        'mode
        '
        Me.mode.Enabled = False
        Me.mode.EnterMoveNextControl = True
        Me.mode.Location = New System.Drawing.Point(472, 56)
        Me.mode.Name = "mode"
        Me.mode.Size = New System.Drawing.Size(44, 20)
        Me.mode.TabIndex = 388
        Me.mode.Visible = False
        '
        'gridmenustrip
        '
        Me.gridmenustrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdEdit, Me.cmdDelete, Me.ToolStripSeparator1, Me.RefreshToolStripMenuItem})
        Me.gridmenustrip.Name = "gridmenustrip"
        Me.gridmenustrip.Size = New System.Drawing.Size(165, 76)
        '
        'cmdEdit
        '
        Me.cmdEdit.Image = Global.LGUFinancial.My.Resources.Resources.lock__pencil
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(180, 22)
        Me.cmdEdit.Text = "Edit Selected"
        '
        'cmdDelete
        '
        Me.cmdDelete.Image = Global.LGUFinancial.My.Resources.Resources.lock__minus
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(180, 22)
        Me.cmdDelete.Text = "Remove Selected"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(177, 6)
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.Image = CType(resources.GetObject("RefreshToolStripMenuItem.Image"), System.Drawing.Image)
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.RefreshToolStripMenuItem.Text = "Refresh"
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar2})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.cmdClose})
        Me.BarManager1.MainMenu = Me.Bar2
        Me.BarManager1.MaxItemId = 2
        '
        'Bar2
        '
        Me.Bar2.BarName = "Main menu"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar2.FloatLocation = New System.Drawing.Point(52, 156)
        Me.Bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.cmdClose)})
        Me.Bar2.OptionsBar.AllowQuickCustomization = False
        Me.Bar2.OptionsBar.MultiLine = True
        Me.Bar2.OptionsBar.UseWholeRow = True
        Me.Bar2.Text = "Main menu"
        '
        'cmdClose
        '
        Me.cmdClose.Caption = "Close Window"
        Me.cmdClose.Id = 0
        Me.cmdClose.ItemAppearance.Disabled.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdClose.ItemAppearance.Disabled.Options.UseFont = True
        Me.cmdClose.ItemAppearance.Hovered.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdClose.ItemAppearance.Hovered.Options.UseFont = True
        Me.cmdClose.ItemAppearance.Normal.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdClose.ItemAppearance.Normal.Options.UseFont = True
        Me.cmdClose.ItemAppearance.Pressed.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdClose.ItemAppearance.Pressed.Options.UseFont = True
        Me.cmdClose.Name = "cmdClose"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(518, 22)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 514)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(518, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 22)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 492)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(518, 22)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 492)
        '
        'Em
        '
        Me.Em.ContextMenuStrip = Me.gridmenustrip
        Me.Em.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Em.Location = New System.Drawing.Point(0, 0)
        Me.Em.MainView = Me.gridActiveAccess
        Me.Em.Name = "Em"
        Me.Em.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1})
        Me.Em.Size = New System.Drawing.Size(509, 309)
        Me.Em.TabIndex = 935
        Me.Em.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridActiveAccess})
        '
        'gridActiveAccess
        '
        Me.gridActiveAccess.DetailHeight = 404
        Me.gridActiveAccess.GridControl = Me.Em
        Me.gridActiveAccess.Name = "gridActiveAccess"
        Me.gridActiveAccess.OptionsBehavior.Editable = False
        Me.gridActiveAccess.OptionsSelection.MultiSelect = True
        Me.gridActiveAccess.OptionsSelection.UseIndicatorForSelection = False
        Me.gridActiveAccess.OptionsView.ColumnAutoWidth = False
        Me.gridActiveAccess.OptionsView.RowAutoHeight = True
        Me.gridActiveAccess.OptionsView.ShowGroupPanel = False
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        Me.RepositoryItemCheckEdit1.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.XtraTabControl1.AppearancePage.Header.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.XtraTabControl1.AppearancePage.Header.Options.UseFont = True
        Me.XtraTabControl1.Location = New System.Drawing.Point(4, 173)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.tabActive
        Me.XtraTabControl1.Size = New System.Drawing.Size(511, 338)
        Me.XtraTabControl1.TabIndex = 936
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.tabActive, Me.tabPrevious})
        '
        'tabActive
        '
        Me.tabActive.Controls.Add(Me.Em)
        Me.tabActive.Name = "tabActive"
        Me.tabActive.Size = New System.Drawing.Size(509, 309)
        Me.tabActive.Text = "Active Access"
        '
        'tabPrevious
        '
        Me.tabPrevious.Controls.Add(Me.Em_Logs)
        Me.tabPrevious.Name = "tabPrevious"
        Me.tabPrevious.Size = New System.Drawing.Size(509, 309)
        Me.tabPrevious.Text = "Authorized Access Logs"
        '
        'Em_Logs
        '
        Me.Em_Logs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Em_Logs.Location = New System.Drawing.Point(0, 0)
        Me.Em_Logs.MainView = Me.gridLogs
        Me.Em_Logs.Name = "Em_Logs"
        Me.Em_Logs.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit2})
        Me.Em_Logs.Size = New System.Drawing.Size(509, 309)
        Me.Em_Logs.TabIndex = 936
        Me.Em_Logs.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridLogs})
        '
        'gridLogs
        '
        Me.gridLogs.DetailHeight = 404
        Me.gridLogs.GridControl = Me.Em_Logs
        Me.gridLogs.Name = "gridLogs"
        Me.gridLogs.OptionsBehavior.Editable = False
        Me.gridLogs.OptionsSelection.MultiSelect = True
        Me.gridLogs.OptionsSelection.UseIndicatorForSelection = False
        Me.gridLogs.OptionsView.ColumnAutoWidth = False
        Me.gridLogs.OptionsView.RowAutoHeight = True
        Me.gridLogs.OptionsView.ShowGroupPanel = False
        '
        'RepositoryItemCheckEdit2
        '
        Me.RepositoryItemCheckEdit2.Name = "RepositoryItemCheckEdit2"
        Me.RepositoryItemCheckEdit2.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(55, 112)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(69, 17)
        Me.LabelControl3.TabIndex = 944
        Me.LabelControl3.Text = "Date Period"
        '
        'LabelControl54
        '
        Me.LabelControl54.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LabelControl54.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.LabelControl54.Appearance.Options.UseFont = True
        Me.LabelControl54.Appearance.Options.UseForeColor = True
        Me.LabelControl54.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.LabelControl54.Location = New System.Drawing.Point(272, 113)
        Me.LabelControl54.Name = "LabelControl54"
        Me.LabelControl54.Size = New System.Drawing.Size(5, 15)
        Me.LabelControl54.TabIndex = 943
        Me.LabelControl54.Text = "-"
        '
        'txtDateTo
        '
        Me.txtDateTo.EditValue = Nothing
        Me.txtDateTo.Enabled = False
        Me.txtDateTo.EnterMoveNextControl = True
        Me.txtDateTo.Location = New System.Drawing.Point(280, 108)
        Me.txtDateTo.Name = "txtDateTo"
        Me.txtDateTo.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtDateTo.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtDateTo.Properties.Appearance.Options.UseBackColor = True
        Me.txtDateTo.Properties.Appearance.Options.UseFont = True
        Me.txtDateTo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtDateTo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtDateTo.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtDateTo.Properties.Mask.EditMask = "MMMM dd, yyyy"
        Me.txtDateTo.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtDateTo.Size = New System.Drawing.Size(136, 24)
        Me.txtDateTo.TabIndex = 2
        '
        'txtDateFrom
        '
        Me.txtDateFrom.EditValue = Nothing
        Me.txtDateFrom.Enabled = False
        Me.txtDateFrom.EnterMoveNextControl = True
        Me.txtDateFrom.Location = New System.Drawing.Point(132, 108)
        Me.txtDateFrom.Name = "txtDateFrom"
        Me.txtDateFrom.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtDateFrom.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtDateFrom.Properties.Appearance.Options.UseBackColor = True
        Me.txtDateFrom.Properties.Appearance.Options.UseFont = True
        Me.txtDateFrom.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtDateFrom.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtDateFrom.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtDateFrom.Properties.Mask.EditMask = "MMMM dd, yyyy"
        Me.txtDateFrom.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtDateFrom.Size = New System.Drawing.Size(136, 24)
        Me.txtDateFrom.TabIndex = 1
        '
        'txtAccessAccount
        '
        Me.txtAccessAccount.EditValue = ""
        Me.txtAccessAccount.Enabled = False
        Me.txtAccessAccount.Location = New System.Drawing.Point(132, 79)
        Me.txtAccessAccount.Name = "txtAccessAccount"
        Me.txtAccessAccount.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.25!)
        Me.txtAccessAccount.Properties.Appearance.Options.UseFont = True
        Me.txtAccessAccount.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtAccessAccount.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtAccessAccount.Properties.DisplayMember = "Fullname"
        Me.txtAccessAccount.Properties.NullText = ""
        Me.txtAccessAccount.Properties.PopupView = Me.gridAccessTo
        Me.txtAccessAccount.Properties.ValueMember = "accountid"
        Me.txtAccessAccount.Size = New System.Drawing.Size(284, 26)
        Me.txtAccessAccount.TabIndex = 0
        '
        'gridAccessTo
        '
        Me.gridAccessTo.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gridAccessTo.Name = "gridAccessTo"
        Me.gridAccessTo.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridAccessTo.OptionsView.ShowGroupPanel = False
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(10, 83)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(114, 17)
        Me.LabelControl1.TabIndex = 946
        Me.LabelControl1.Text = "Authorize Access to"
        '
        'cmdSave
        '
        Me.cmdSave.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.cmdSave.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.cmdSave.Appearance.Options.UseFont = True
        Me.cmdSave.Enabled = False
        Me.cmdSave.Location = New System.Drawing.Point(132, 135)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(136, 29)
        Me.cmdSave.TabIndex = 3
        Me.cmdSave.Text = "Save Access"
        '
        'userid
        '
        Me.userid.Enabled = False
        Me.userid.EnterMoveNextControl = True
        Me.userid.Location = New System.Drawing.Point(422, 54)
        Me.userid.Name = "userid"
        Me.userid.Size = New System.Drawing.Size(44, 20)
        Me.userid.TabIndex = 948
        Me.userid.Visible = False
        '
        'accessid
        '
        Me.accessid.Enabled = False
        Me.accessid.EnterMoveNextControl = True
        Me.accessid.Location = New System.Drawing.Point(422, 82)
        Me.accessid.Name = "accessid"
        Me.accessid.Size = New System.Drawing.Size(44, 20)
        Me.accessid.TabIndex = 949
        Me.accessid.Visible = False
        '
        'ckEnableAuthorizedAccess
        '
        Me.ckEnableAuthorizedAccess.Location = New System.Drawing.Point(132, 25)
        Me.ckEnableAuthorizedAccess.MenuManager = Me.BarManager1
        Me.ckEnableAuthorizedAccess.Name = "ckEnableAuthorizedAccess"
        Me.ckEnableAuthorizedAccess.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.ckEnableAuthorizedAccess.Properties.Appearance.Options.UseFont = True
        Me.ckEnableAuthorizedAccess.Properties.Caption = "Enable Authorized User Access"
        Me.ckEnableAuthorizedAccess.Size = New System.Drawing.Size(216, 21)
        Me.ckEnableAuthorizedAccess.TabIndex = 954
        '
        'frmAuthorizedUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(518, 514)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Controls.Add(Me.ckEnableAuthorizedAccess)
        Me.Controls.Add(Me.accessid)
        Me.Controls.Add(Me.userid)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.txtAccessAccount)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.LabelControl54)
        Me.Controls.Add(Me.txtDateTo)
        Me.Controls.Add(Me.txtDateFrom)
        Me.Controls.Add(Me.mode)
        Me.Controls.Add(Me.id)
        Me.Controls.Add(Me.txtAccountName)
        Me.Controls.Add(Me.lbloffice)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "frmAuthorizedUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Authorized Approval Access"
        Me.TopMost = True
        CType(Me.txtAccountName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.id.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gridmenustrip.ResumeLayout(False)
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridActiveAccess, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.tabActive.ResumeLayout(False)
        Me.tabPrevious.ResumeLayout(False)
        CType(Me.Em_Logs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridLogs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDateTo.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDateTo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDateFrom.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDateFrom.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAccessAccount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridAccessTo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.userid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.accessid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ckEnableAuthorizedAccess.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbloffice As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtAccountName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents id As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents mode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents gridmenustrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmdEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdDelete As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents RefreshToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents cmdClose As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents Em As DevExpress.XtraGrid.GridControl
    Friend WithEvents gridActiveAccess As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl54 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDateTo As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtDateFrom As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtAccessAccount As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents gridAccessTo As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents tabActive As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tabPrevious As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents Em_Logs As DevExpress.XtraGrid.GridControl
    Friend WithEvents gridLogs As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemCheckEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents userid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents accessid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ckEnableAuthorizedAccess As DevExpress.XtraEditors.CheckEdit
End Class
