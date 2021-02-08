<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClientUserPermission
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.DockManager1 = New DevExpress.XtraBars.Docking.DockManager(Me.components)
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.BarLargeButtonItem2 = New DevExpress.XtraBars.BarLargeButtonItem()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl1 = New DevExpress.XtraBars.BarDockControl()
        Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.id = New DevExpress.XtraEditors.ButtonEdit()
        Me.txtdesc = New DevExpress.XtraEditors.TextEdit()
        Me.Em = New DevExpress.XtraGrid.GridControl()
        Me.gridmenustrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmdEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdDelete = New System.Windows.Forms.ToolStripMenuItem()
        Me.DuplicateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.BarLargeButtonItem1 = New DevExpress.XtraBars.BarLargeButtonItem()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.ckAllowDelete = New DevExpress.XtraEditors.CheckEdit()
        Me.ckAllowEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.ckAllowAdd = New DevExpress.XtraEditors.CheckEdit()
        Me.checklistbox = New DevExpress.XtraEditors.CheckedListBoxControl()
        Me.ckSpecialApprover = New DevExpress.XtraEditors.CheckEdit()
        Me.ckGeneralApprover = New DevExpress.XtraEditors.CheckEdit()
        Me.CheckEdit2 = New DevExpress.XtraEditors.CheckEdit()
        Me.cmdUpdate = New DevExpress.XtraEditors.SimpleButton()
        Me.ckDepartmentHead = New DevExpress.XtraEditors.CheckEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.mode = New DevExpress.XtraEditors.ButtonEdit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.id.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtdesc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gridmenustrip.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.ckAllowDelete.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ckAllowEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ckAllowAdd.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.checklistbox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ckSpecialApprover.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ckGeneralApprover.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ckDepartmentHead.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DockManager1
        '
        Me.DockManager1.Form = Me
        Me.DockManager1.MenuManager = Me.BarManager1
        Me.DockManager1.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl"})
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.BarDockControl1)
        Me.BarManager1.DockManager = Me.DockManager1
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarLargeButtonItem2, Me.BarButtonItem1, Me.BarButtonItem2, Me.BarButtonItem3, Me.BarButtonItem4})
        Me.BarManager1.MainMenu = Me.Bar1
        Me.BarManager1.MaxItemId = 7
        Me.BarManager1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1})
        '
        'Bar1
        '
        Me.Bar1.BarName = "Custom 3"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarLargeButtonItem2), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem2, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem3, True)})
        Me.Bar1.OptionsBar.AllowQuickCustomization = False
        Me.Bar1.OptionsBar.MultiLine = True
        Me.Bar1.OptionsBar.UseWholeRow = True
        Me.Bar1.Text = "Custom 3"
        '
        'BarLargeButtonItem2
        '
        Me.BarLargeButtonItem2.Caption = "&Close Window"
        Me.BarLargeButtonItem2.Id = 1
        Me.BarLargeButtonItem2.Name = "BarLargeButtonItem2"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Clear &Fileds"
        Me.BarButtonItem1.Id = 3
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "Export to Excel"
        Me.BarButtonItem2.Id = 4
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "Print Report"
        Me.BarButtonItem3.Id = 5
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(1036, 20)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 451)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(1036, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 20)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 431)
        '
        'BarDockControl1
        '
        Me.BarDockControl1.CausesValidation = False
        Me.BarDockControl1.Dock = System.Windows.Forms.DockStyle.Right
        Me.BarDockControl1.Location = New System.Drawing.Point(1036, 20)
        Me.BarDockControl1.Manager = Me.BarManager1
        Me.BarDockControl1.Size = New System.Drawing.Size(0, 431)
        '
        'BarButtonItem4
        '
        Me.BarButtonItem4.Caption = "BarButtonItem4"
        Me.BarButtonItem4.Id = 6
        Me.BarButtonItem4.Name = "BarButtonItem4"
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'id
        '
        Me.id.EditValue = ""
        Me.id.Location = New System.Drawing.Point(56, 144)
        Me.id.Name = "id"
        Me.id.Properties.Appearance.Options.UseTextOptions = True
        Me.id.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.id.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.id.Properties.Mask.BeepOnError = True
        Me.id.Properties.ReadOnly = True
        Me.id.Size = New System.Drawing.Size(64, 20)
        Me.id.TabIndex = 381
        Me.id.Visible = False
        '
        'txtdesc
        '
        Me.txtdesc.EditValue = ""
        Me.txtdesc.Location = New System.Drawing.Point(12, 24)
        Me.txtdesc.Name = "txtdesc"
        Me.txtdesc.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtdesc.Properties.Appearance.Options.UseFont = True
        Me.txtdesc.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtdesc.Size = New System.Drawing.Size(438, 26)
        Me.txtdesc.TabIndex = 0
        '
        'Em
        '
        Me.Em.ContextMenuStrip = Me.gridmenustrip
        Me.Em.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Em.Location = New System.Drawing.Point(0, 0)
        Me.Em.MainView = Me.GridView1
        Me.Em.Name = "Em"
        Me.Em.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1})
        Me.Em.Size = New System.Drawing.Size(564, 431)
        Me.Em.TabIndex = 2
        Me.Em.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'gridmenustrip
        '
        Me.gridmenustrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdEdit, Me.cmdDelete, Me.DuplicateToolStripMenuItem, Me.ToolStripSeparator1, Me.RefreshToolStripMenuItem})
        Me.gridmenustrip.Name = "gridmenustrip"
        Me.gridmenustrip.Size = New System.Drawing.Size(146, 98)
        '
        'cmdEdit
        '
        Me.cmdEdit.Image = Global.LGUFinancial.My.Resources.Resources.notebook__pencil
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(145, 22)
        Me.cmdEdit.Text = "Edit Category"
        '
        'cmdDelete
        '
        Me.cmdDelete.Image = Global.LGUFinancial.My.Resources.Resources.notebook__minus
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(145, 22)
        Me.cmdDelete.Text = "Remove Item"
        '
        'DuplicateToolStripMenuItem
        '
        Me.DuplicateToolStripMenuItem.Image = Global.LGUFinancial.My.Resources.Resources.blue_document_convert
        Me.DuplicateToolStripMenuItem.Name = "DuplicateToolStripMenuItem"
        Me.DuplicateToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.DuplicateToolStripMenuItem.Text = "Duplicate"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(142, 6)
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.Image = Global.LGUFinancial.My.Resources.Resources.arrow_continue_090_left
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.RefreshToolStripMenuItem.Text = "Refresh Data"
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.Em
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsSelection.MultiSelect = True
        Me.GridView1.OptionsSelection.UseIndicatorForSelection = False
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        Me.RepositoryItemCheckEdit1.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        '
        'BarLargeButtonItem1
        '
        Me.BarLargeButtonItem1.Caption = "&Close Window"
        Me.BarLargeButtonItem1.Id = 1
        Me.BarLargeButtonItem1.Name = "BarLargeButtonItem1"
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1036, 20)
        Me.barDockControlRight.Manager = Nothing
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 431)
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.CollapsePanel = DevExpress.XtraEditors.SplitCollapsePanel.Panel1
        Me.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl1.Location = New System.Drawing.Point(0, 20)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.ckAllowDelete)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.ckAllowEdit)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.ckAllowAdd)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.checklistbox)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.ckSpecialApprover)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.ckGeneralApprover)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.CheckEdit2)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.cmdUpdate)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.ckDepartmentHead)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.LabelControl2)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.txtdesc)
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.mode)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.id)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.Em)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(1036, 431)
        Me.SplitContainerControl1.SplitterPosition = 462
        Me.SplitContainerControl1.TabIndex = 386
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'ckAllowDelete
        '
        Me.ckAllowDelete.Location = New System.Drawing.Point(282, 79)
        Me.ckAllowDelete.MenuManager = Me.BarManager1
        Me.ckAllowDelete.Name = "ckAllowDelete"
        Me.ckAllowDelete.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.ckAllowDelete.Properties.Appearance.Options.UseFont = True
        Me.ckAllowDelete.Properties.Caption = "Allow Delete"
        Me.ckAllowDelete.Size = New System.Drawing.Size(118, 21)
        Me.ckAllowDelete.TabIndex = 621
        '
        'ckAllowEdit
        '
        Me.ckAllowEdit.Location = New System.Drawing.Point(144, 79)
        Me.ckAllowEdit.MenuManager = Me.BarManager1
        Me.ckAllowEdit.Name = "ckAllowEdit"
        Me.ckAllowEdit.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.ckAllowEdit.Properties.Appearance.Options.UseFont = True
        Me.ckAllowEdit.Properties.Caption = "Allow Edit"
        Me.ckAllowEdit.Size = New System.Drawing.Size(118, 21)
        Me.ckAllowEdit.TabIndex = 620
        '
        'ckAllowAdd
        '
        Me.ckAllowAdd.Location = New System.Drawing.Point(12, 79)
        Me.ckAllowAdd.MenuManager = Me.BarManager1
        Me.ckAllowAdd.Name = "ckAllowAdd"
        Me.ckAllowAdd.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.ckAllowAdd.Properties.Appearance.Options.UseFont = True
        Me.ckAllowAdd.Properties.Caption = "Allow Add"
        Me.ckAllowAdd.Size = New System.Drawing.Size(118, 21)
        Me.ckAllowAdd.TabIndex = 619
        '
        'checklistbox
        '
        Me.checklistbox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.checklistbox.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checklistbox.Appearance.Options.UseFont = True
        Me.checklistbox.CheckOnClick = True
        Me.checklistbox.HorizontalScrollbar = True
        Me.checklistbox.HotTrackItems = True
        Me.checklistbox.HotTrackSelectMode = DevExpress.XtraEditors.HotTrackSelectMode.SelectItemOnClick
        Me.checklistbox.Location = New System.Drawing.Point(12, 106)
        Me.checklistbox.Name = "checklistbox"
        Me.checklistbox.Size = New System.Drawing.Size(438, 277)
        Me.checklistbox.TabIndex = 618
        '
        'ckSpecialApprover
        '
        Me.ckSpecialApprover.Location = New System.Drawing.Point(282, 55)
        Me.ckSpecialApprover.MenuManager = Me.BarManager1
        Me.ckSpecialApprover.Name = "ckSpecialApprover"
        Me.ckSpecialApprover.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.ckSpecialApprover.Properties.Appearance.Options.UseFont = True
        Me.ckSpecialApprover.Properties.Caption = "Manage Other Offices"
        Me.ckSpecialApprover.Size = New System.Drawing.Size(159, 21)
        Me.ckSpecialApprover.TabIndex = 390
        '
        'ckGeneralApprover
        '
        Me.ckGeneralApprover.Location = New System.Drawing.Point(144, 55)
        Me.ckGeneralApprover.MenuManager = Me.BarManager1
        Me.ckGeneralApprover.Name = "ckGeneralApprover"
        Me.ckGeneralApprover.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.ckGeneralApprover.Properties.Appearance.Options.UseFont = True
        Me.ckGeneralApprover.Properties.Caption = "General Approver"
        Me.ckGeneralApprover.Size = New System.Drawing.Size(132, 21)
        Me.ckGeneralApprover.TabIndex = 389
        '
        'CheckEdit2
        '
        Me.CheckEdit2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CheckEdit2.Location = New System.Drawing.Point(15, 394)
        Me.CheckEdit2.MenuManager = Me.BarManager1
        Me.CheckEdit2.Name = "CheckEdit2"
        Me.CheckEdit2.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.CheckEdit2.Properties.Appearance.Options.UseFont = True
        Me.CheckEdit2.Properties.Caption = "Check all"
        Me.CheckEdit2.Size = New System.Drawing.Size(75, 20)
        Me.CheckEdit2.TabIndex = 388
        '
        'cmdUpdate
        '
        Me.cmdUpdate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdUpdate.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdUpdate.Appearance.BackColor2 = System.Drawing.Color.Khaki
        Me.cmdUpdate.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdUpdate.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.cmdUpdate.Appearance.Options.UseBackColor = True
        Me.cmdUpdate.Appearance.Options.UseFont = True
        Me.cmdUpdate.Location = New System.Drawing.Point(329, 389)
        Me.cmdUpdate.Name = "cmdUpdate"
        Me.cmdUpdate.Size = New System.Drawing.Size(121, 30)
        Me.cmdUpdate.TabIndex = 3
        Me.cmdUpdate.Text = "Confirm Save"
        '
        'ckDepartmentHead
        '
        Me.ckDepartmentHead.Location = New System.Drawing.Point(12, 55)
        Me.ckDepartmentHead.MenuManager = Me.BarManager1
        Me.ckDepartmentHead.Name = "ckDepartmentHead"
        Me.ckDepartmentHead.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.ckDepartmentHead.Properties.Appearance.Options.UseFont = True
        Me.ckDepartmentHead.Properties.Caption = "Department Heads"
        Me.ckDepartmentHead.Size = New System.Drawing.Size(124, 21)
        Me.ckDepartmentHead.TabIndex = 2
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(15, 7)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(130, 17)
        Me.LabelControl2.TabIndex = 386
        Me.LabelControl2.Text = "Access template name"
        '
        'mode
        '
        Me.mode.EditValue = ""
        Me.mode.Location = New System.Drawing.Point(126, 143)
        Me.mode.Name = "mode"
        Me.mode.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.mode.Properties.Appearance.Options.UseFont = True
        Me.mode.Properties.Appearance.Options.UseTextOptions = True
        Me.mode.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.mode.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.mode.Properties.Mask.BeepOnError = True
        Me.mode.Size = New System.Drawing.Size(64, 22)
        Me.mode.TabIndex = 382
        Me.mode.Visible = False
        '
        'frmClientUserPermission
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1036, 451)
        Me.Controls.Add(Me.SplitContainerControl1)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.BarDockControl1)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.MinimumSize = New System.Drawing.Size(360, 374)
        Me.Name = "frmClientUserPermission"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Client Access Management"
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.id.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtdesc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gridmenustrip.ResumeLayout(False)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.ckAllowDelete.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ckAllowEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ckAllowAdd.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.checklistbox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ckSpecialApprover.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ckGeneralApprover.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ckDepartmentHead.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DockManager1 As DevExpress.XtraBars.Docking.DockManager
    Friend WithEvents id As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents Em As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gridmenustrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmdEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdDelete As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents RefreshToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarLargeButtonItem1 As DevExpress.XtraBars.BarLargeButtonItem
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl1 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents BarLargeButtonItem2 As DevExpress.XtraBars.BarLargeButtonItem
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents txtdesc As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents mode As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents cmdUpdate As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ckDepartmentHead As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents CheckEdit2 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents ckGeneralApprover As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents ckSpecialApprover As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents DuplicateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem4 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents checklistbox As DevExpress.XtraEditors.CheckedListBoxControl
    Friend WithEvents ckAllowDelete As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents ckAllowEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents ckAllowAdd As DevExpress.XtraEditors.CheckEdit
End Class
