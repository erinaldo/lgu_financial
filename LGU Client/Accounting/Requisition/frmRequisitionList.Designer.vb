<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRequisitionList
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.HiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PropertiesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelloToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MustaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BottomToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.TopToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.RightToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.LeftToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.ContentPanel = New System.Windows.Forms.ToolStripContentPanel()
        Me.cms_em = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmdView = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdCancel = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdLocalData = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.cmdNewProperty = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdPrint = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdColumnSettings = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdClose = New System.Windows.Forms.ToolStripButton()
        Me.updates = New System.Windows.Forms.ToolStripLabel()
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.ckDisplayCancelled = New DevExpress.XtraEditors.CheckEdit()
        Me.ckAllType = New DevExpress.XtraEditors.CheckEdit()
        Me.ckViewAllOffice = New DevExpress.XtraEditors.CheckEdit()
        Me.txtOffice = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.gridOffice = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.lbloffice = New DevExpress.XtraEditors.LabelControl()
        Me.officeid = New DevExpress.XtraEditors.TextEdit()
        Me.requesttype = New DevExpress.XtraEditors.TextEdit()
        Me.cmdFilterSearch = New DevExpress.XtraEditors.SimpleButton()
        Me.txtRequestType = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.gridRequestType = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.txtDateFrom = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.txtDateTo = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.ckPendingRequisition = New DevExpress.XtraEditors.CheckEdit()
        Me.txtSearchBar = New DevExpress.XtraEditors.TextEdit()
        Me.Em = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.cms_em.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.ckDisplayCancelled.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ckAllType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ckViewAllOffice.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOffice.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridOffice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.officeid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.requesttype.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRequestType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridRequestType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDateFrom.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDateFrom.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDateTo.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDateTo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ckPendingRequisition.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSearchBar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'HiToolStripMenuItem
        '
        Me.HiToolStripMenuItem.Name = "HiToolStripMenuItem"
        Me.HiToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.HiToolStripMenuItem.Text = "Delete"
        '
        'PropertiesToolStripMenuItem
        '
        Me.PropertiesToolStripMenuItem.Name = "PropertiesToolStripMenuItem"
        Me.PropertiesToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.PropertiesToolStripMenuItem.Text = "Properties"
        '
        'HelloToolStripMenuItem
        '
        Me.HelloToolStripMenuItem.Name = "HelloToolStripMenuItem"
        Me.HelloToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.HelloToolStripMenuItem.Text = "View Remarks"
        '
        'MustaToolStripMenuItem
        '
        Me.MustaToolStripMenuItem.Name = "MustaToolStripMenuItem"
        Me.MustaToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.MustaToolStripMenuItem.Text = "Edit "
        '
        'BottomToolStripPanel
        '
        Me.BottomToolStripPanel.Location = New System.Drawing.Point(0, 0)
        Me.BottomToolStripPanel.Name = "BottomToolStripPanel"
        Me.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.BottomToolStripPanel.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.BottomToolStripPanel.Size = New System.Drawing.Size(0, 0)
        '
        'TopToolStripPanel
        '
        Me.TopToolStripPanel.Location = New System.Drawing.Point(0, 0)
        Me.TopToolStripPanel.Name = "TopToolStripPanel"
        Me.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.TopToolStripPanel.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.TopToolStripPanel.Size = New System.Drawing.Size(0, 0)
        '
        'RightToolStripPanel
        '
        Me.RightToolStripPanel.Location = New System.Drawing.Point(0, 0)
        Me.RightToolStripPanel.Name = "RightToolStripPanel"
        Me.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.RightToolStripPanel.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.RightToolStripPanel.Size = New System.Drawing.Size(0, 0)
        '
        'LeftToolStripPanel
        '
        Me.LeftToolStripPanel.Location = New System.Drawing.Point(0, 0)
        Me.LeftToolStripPanel.Name = "LeftToolStripPanel"
        Me.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.LeftToolStripPanel.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.LeftToolStripPanel.Size = New System.Drawing.Size(0, 0)
        '
        'ContentPanel
        '
        Me.ContentPanel.AutoScroll = True
        Me.ContentPanel.Size = New System.Drawing.Size(1143, 571)
        '
        'cms_em
        '
        Me.cms_em.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdView, Me.cmdCancel, Me.ToolStripSeparator4, Me.cmdLocalData})
        Me.cms_em.Name = "ContextMenuStrip1"
        Me.cms_em.Size = New System.Drawing.Size(203, 76)
        '
        'cmdView
        '
        Me.cmdView.Image = Global.LGUClient.My.Resources.Resources.notebook__arrow
        Me.cmdView.Name = "cmdView"
        Me.cmdView.Size = New System.Drawing.Size(202, 22)
        Me.cmdView.Text = "View Requisition Info"
        '
        'cmdCancel
        '
        Me.cmdCancel.Image = Global.LGUClient.My.Resources.Resources.notebook__minus
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(202, 22)
        Me.cmdCancel.Text = "Cancel Selected Request"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(199, 6)
        '
        'cmdLocalData
        '
        Me.cmdLocalData.Image = Global.LGUClient.My.Resources.Resources.arrow_continue_090
        Me.cmdLocalData.Name = "cmdLocalData"
        Me.cmdLocalData.Size = New System.Drawing.Size(202, 22)
        Me.cmdLocalData.Tag = "1"
        Me.cmdLocalData.Text = "Refresh Data"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.BackgroundImage = Global.LGUClient.My.Resources.Resources.wide_blank2
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdNewProperty, Me.ToolStripSeparator1, Me.cmdPrint, Me.ToolStripSeparator3, Me.cmdColumnSettings, Me.ToolStripSeparator2, Me.cmdClose})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Padding = New System.Windows.Forms.Padding(10, 2, 1, 2)
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.Size = New System.Drawing.Size(990, 31)
        Me.ToolStrip1.TabIndex = 317
        Me.ToolStrip1.Text = "ToolStrip3"
        '
        'cmdNewProperty
        '
        Me.cmdNewProperty.ForeColor = System.Drawing.Color.White
        Me.cmdNewProperty.Image = Global.LGUClient.My.Resources.Resources.receipt__plus
        Me.cmdNewProperty.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdNewProperty.Name = "cmdNewProperty"
        Me.cmdNewProperty.Size = New System.Drawing.Size(150, 24)
        Me.cmdNewProperty.Text = "Create New Requisition"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'cmdPrint
        '
        Me.cmdPrint.ForeColor = System.Drawing.Color.White
        Me.cmdPrint.Image = Global.LGUClient.My.Resources.Resources.document_excel_table
        Me.cmdPrint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(105, 24)
        Me.cmdPrint.Text = "Export to Excel"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 27)
        '
        'cmdColumnSettings
        '
        Me.cmdColumnSettings.ForeColor = System.Drawing.Color.White
        Me.cmdColumnSettings.Image = Global.LGUClient.My.Resources.Resources.application_task
        Me.cmdColumnSettings.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdColumnSettings.Name = "cmdColumnSettings"
        Me.cmdColumnSettings.Size = New System.Drawing.Size(115, 24)
        Me.cmdColumnSettings.Text = "Column Settings"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'cmdClose
        '
        Me.cmdClose.ForeColor = System.Drawing.Color.White
        Me.cmdClose.Image = Global.LGUClient.My.Resources.Resources.slash
        Me.cmdClose.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(103, 24)
        Me.cmdClose.Text = "Close Window"
        '
        'updates
        '
        Me.updates.BackColor = System.Drawing.Color.Transparent
        Me.updates.ForeColor = System.Drawing.Color.White
        Me.updates.Name = "updates"
        Me.updates.Size = New System.Drawing.Size(0, 24)
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl1.Horizontal = False
        Me.SplitContainerControl1.Location = New System.Drawing.Point(0, 31)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.ckDisplayCancelled)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.ckAllType)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.ckViewAllOffice)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.txtOffice)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.lbloffice)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.officeid)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.requesttype)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.cmdFilterSearch)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.txtRequestType)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.txtDateFrom)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.LabelControl6)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.LabelControl8)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.txtDateTo)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.LabelControl2)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.LabelControl1)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.ckPendingRequisition)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.txtSearchBar)
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.Em)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(990, 609)
        Me.SplitContainerControl1.SplitterPosition = 122
        Me.SplitContainerControl1.TabIndex = 823
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'ckDisplayCancelled
        '
        Me.ckDisplayCancelled.Location = New System.Drawing.Point(332, 7)
        Me.ckDisplayCancelled.Name = "ckDisplayCancelled"
        Me.ckDisplayCancelled.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.ckDisplayCancelled.Properties.Appearance.Options.UseFont = True
        Me.ckDisplayCancelled.Properties.Caption = "Display Cancelled Request"
        Me.ckDisplayCancelled.Size = New System.Drawing.Size(196, 21)
        Me.ckDisplayCancelled.TabIndex = 967
        '
        'ckAllType
        '
        Me.ckAllType.EditValue = True
        Me.ckAllType.Location = New System.Drawing.Point(454, 33)
        Me.ckAllType.Name = "ckAllType"
        Me.ckAllType.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.ckAllType.Properties.Appearance.Options.UseFont = True
        Me.ckAllType.Properties.Caption = "All"
        Me.ckAllType.Size = New System.Drawing.Size(49, 21)
        Me.ckAllType.TabIndex = 966
        '
        'ckViewAllOffice
        '
        Me.ckViewAllOffice.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ckViewAllOffice.Location = New System.Drawing.Point(694, 33)
        Me.ckViewAllOffice.Name = "ckViewAllOffice"
        Me.ckViewAllOffice.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.ckViewAllOffice.Properties.Appearance.Options.UseFont = True
        Me.ckViewAllOffice.Properties.Caption = "View All Requesting Offices"
        Me.ckViewAllOffice.Size = New System.Drawing.Size(196, 21)
        Me.ckViewAllOffice.TabIndex = 965
        '
        'txtOffice
        '
        Me.txtOffice.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtOffice.EditValue = "sss"
        Me.txtOffice.Location = New System.Drawing.Point(694, 58)
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
        Me.txtOffice.Size = New System.Drawing.Size(284, 26)
        Me.txtOffice.TabIndex = 963
        '
        'gridOffice
        '
        Me.gridOffice.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gridOffice.Name = "gridOffice"
        Me.gridOffice.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridOffice.OptionsView.ShowGroupPanel = False
        '
        'lbloffice
        '
        Me.lbloffice.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbloffice.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lbloffice.Appearance.Options.UseFont = True
        Me.lbloffice.Location = New System.Drawing.Point(585, 62)
        Me.lbloffice.Name = "lbloffice"
        Me.lbloffice.Size = New System.Drawing.Size(103, 17)
        Me.lbloffice.TabIndex = 964
        Me.lbloffice.Text = "Requesting Office"
        '
        'officeid
        '
        Me.officeid.Location = New System.Drawing.Point(941, 28)
        Me.officeid.Name = "officeid"
        Me.officeid.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.officeid.Properties.Appearance.Options.UseFont = True
        Me.officeid.Properties.Appearance.Options.UseTextOptions = True
        Me.officeid.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.officeid.Properties.ReadOnly = True
        Me.officeid.Size = New System.Drawing.Size(37, 24)
        Me.officeid.TabIndex = 962
        Me.officeid.Visible = False
        '
        'requesttype
        '
        Me.requesttype.Location = New System.Drawing.Point(898, 28)
        Me.requesttype.Name = "requesttype"
        Me.requesttype.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.requesttype.Properties.Appearance.Options.UseFont = True
        Me.requesttype.Properties.Appearance.Options.UseTextOptions = True
        Me.requesttype.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.requesttype.Properties.ReadOnly = True
        Me.requesttype.Size = New System.Drawing.Size(37, 24)
        Me.requesttype.TabIndex = 959
        Me.requesttype.Visible = False
        '
        'cmdFilterSearch
        '
        Me.cmdFilterSearch.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmdFilterSearch.Appearance.Options.UseFont = True
        Me.cmdFilterSearch.Location = New System.Drawing.Point(344, 60)
        Me.cmdFilterSearch.Name = "cmdFilterSearch"
        Me.cmdFilterSearch.Size = New System.Drawing.Size(106, 53)
        Me.cmdFilterSearch.TabIndex = 4
        Me.cmdFilterSearch.Text = "Filter Search"
        '
        'txtRequestType
        '
        Me.txtRequestType.EditValue = ""
        Me.txtRequestType.Enabled = False
        Me.txtRequestType.Location = New System.Drawing.Point(142, 30)
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
        Me.txtRequestType.Size = New System.Drawing.Size(308, 26)
        Me.txtRequestType.TabIndex = 1
        '
        'gridRequestType
        '
        Me.gridRequestType.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gridRequestType.Name = "gridRequestType"
        Me.gridRequestType.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridRequestType.OptionsView.ShowGroupPanel = False
        '
        'txtDateFrom
        '
        Me.txtDateFrom.EditValue = New Date(2019, 6, 10, 16, 23, 25, 399)
        Me.txtDateFrom.Enabled = False
        Me.txtDateFrom.EnterMoveNextControl = True
        Me.txtDateFrom.Location = New System.Drawing.Point(142, 60)
        Me.txtDateFrom.Name = "txtDateFrom"
        Me.txtDateFrom.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.txtDateFrom.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtDateFrom.Properties.Appearance.Options.UseFont = True
        Me.txtDateFrom.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtDateFrom.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtDateFrom.Properties.AutoHeight = False
        Me.txtDateFrom.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtDateFrom.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtDateFrom.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtDateFrom.Properties.Mask.EditMask = "MMMM dd, yyyy"
        Me.txtDateFrom.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtDateFrom.Size = New System.Drawing.Size(196, 25)
        Me.txtDateFrom.TabIndex = 2
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.LabelControl6.Appearance.Options.UseFont = True
        Me.LabelControl6.Location = New System.Drawing.Point(26, 64)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(108, 17)
        Me.LabelControl6.TabIndex = 927
        Me.LabelControl6.Text = "Posting Date From"
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.LabelControl8.Appearance.Options.UseFont = True
        Me.LabelControl8.Location = New System.Drawing.Point(54, 34)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(79, 17)
        Me.LabelControl8.TabIndex = 937
        Me.LabelControl8.Text = "Request Type"
        '
        'txtDateTo
        '
        Me.txtDateTo.EditValue = New Date(2019, 6, 10, 16, 23, 25, 399)
        Me.txtDateTo.Enabled = False
        Me.txtDateTo.EnterMoveNextControl = True
        Me.txtDateTo.Location = New System.Drawing.Point(142, 88)
        Me.txtDateTo.Name = "txtDateTo"
        Me.txtDateTo.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.txtDateTo.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtDateTo.Properties.Appearance.Options.UseFont = True
        Me.txtDateTo.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtDateTo.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtDateTo.Properties.AutoHeight = False
        Me.txtDateTo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtDateTo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtDateTo.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtDateTo.Properties.Mask.EditMask = "MMMM dd, yyyy"
        Me.txtDateTo.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtDateTo.Size = New System.Drawing.Size(196, 25)
        Me.txtDateTo.TabIndex = 3
        '
        'LabelControl2
        '
        Me.LabelControl2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(596, 90)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(92, 17)
        Me.LabelControl2.TabIndex = 931
        Me.LabelControl2.Text = "Advance Search"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(41, 92)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(93, 17)
        Me.LabelControl1.TabIndex = 929
        Me.LabelControl1.Text = "Posting Date To"
        '
        'ckPendingRequisition
        '
        Me.ckPendingRequisition.EditValue = True
        Me.ckPendingRequisition.Location = New System.Drawing.Point(142, 7)
        Me.ckPendingRequisition.Name = "ckPendingRequisition"
        Me.ckPendingRequisition.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.ckPendingRequisition.Properties.Appearance.Options.UseFont = True
        Me.ckPendingRequisition.Properties.Caption = "View All Pending Requisition"
        Me.ckPendingRequisition.Size = New System.Drawing.Size(196, 21)
        Me.ckPendingRequisition.TabIndex = 930
        '
        'txtSearchBar
        '
        Me.txtSearchBar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSearchBar.EditValue = ""
        Me.txtSearchBar.Location = New System.Drawing.Point(694, 87)
        Me.txtSearchBar.Name = "txtSearchBar"
        Me.txtSearchBar.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtSearchBar.Properties.Appearance.Options.UseFont = True
        Me.txtSearchBar.Properties.AutoHeight = False
        Me.txtSearchBar.Properties.MaxLength = 50
        Me.txtSearchBar.Properties.NullValuePrompt = "Enter any keyword to search"
        Me.txtSearchBar.Size = New System.Drawing.Size(284, 25)
        Me.txtSearchBar.TabIndex = 0
        '
        'Em
        '
        Me.Em.ContextMenuStrip = Me.cms_em
        Me.Em.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Em.Location = New System.Drawing.Point(0, 0)
        Me.Em.MainView = Me.GridView1
        Me.Em.MinimumSize = New System.Drawing.Size(574, 454)
        Me.Em.Name = "Em"
        Me.Em.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1})
        Me.Em.Size = New System.Drawing.Size(990, 477)
        Me.Em.TabIndex = 635
        Me.Em.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
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
        'frmRequisitionList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(990, 640)
        Me.Controls.Add(Me.SplitContainerControl1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MinimumSize = New System.Drawing.Size(1006, 679)
        Me.Name = "frmRequisitionList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Requisition Report"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.cms_em.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.ckDisplayCancelled.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ckAllType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ckViewAllOffice.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOffice.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridOffice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.officeid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.requesttype.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRequestType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridRequestType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDateFrom.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDateFrom.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDateTo.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDateTo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ckPendingRequisition.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSearchBar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents HiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PropertiesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelloToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MustaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BottomToolStripPanel As System.Windows.Forms.ToolStripPanel
    Friend WithEvents TopToolStripPanel As System.Windows.Forms.ToolStripPanel
    Friend WithEvents RightToolStripPanel As System.Windows.Forms.ToolStripPanel
    Friend WithEvents LeftToolStripPanel As System.Windows.Forms.ToolStripPanel
    Friend WithEvents ContentPanel As System.Windows.Forms.ToolStripContentPanel
    'Friend WithEvents mode As System.Windows.Forms.TextBox
    Friend WithEvents cms_em As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmdLocalData As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents updates As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdClose As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdView As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdPrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdCancel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdNewProperty As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents txtSearchBar As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmdColumnSettings As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDateTo As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDateFrom As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ckPendingRequisition As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents cmdFilterSearch As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtRequestType As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents gridRequestType As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents requesttype As DevExpress.XtraEditors.TextEdit
    Friend WithEvents officeid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtOffice As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents gridOffice As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents lbloffice As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ckViewAllOffice As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents ckAllType As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents Em As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents ckDisplayCancelled As DevExpress.XtraEditors.CheckEdit
End Class
