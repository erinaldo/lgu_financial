<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmFund
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
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.mode = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.code = New DevExpress.XtraEditors.TextEdit()
        Me.txtcodename = New DevExpress.XtraEditors.TextEdit()
        Me.txtDescription = New DevExpress.XtraEditors.TextEdit()
        Me.Em = New DevExpress.XtraGrid.GridControl()
        Me.gridmenustrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmdEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdDelete = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.tabInfo = New DevExpress.XtraTab.XtraTabPage()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtTemplate = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.tabOfficeFilter = New DevExpress.XtraTab.XtraTabPage()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.em_office_filtered = New DevExpress.XtraGrid.GridControl()
        Me.grid_office_filtered = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.em_office_unfiltered = New DevExpress.XtraGrid.GridControl()
        Me.grid_office_unfiltered = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.txtOfficeFund = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.grid_office_fund = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.cmdOfficeMoveRight = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdOfficeMoveLeft = New DevExpress.XtraEditors.SimpleButton()
        Me.tabClientUserFilter = New DevExpress.XtraTab.XtraTabPage()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.em_client_unfiltered = New DevExpress.XtraGrid.GridControl()
        Me.grid_client_unfiltered = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.txtClientFund = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.grid_client_fund = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cmdClientMoveRight = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdClientMoveLeft = New DevExpress.XtraEditors.SimpleButton()
        Me.em_client_filtered = New DevExpress.XtraGrid.GridControl()
        Me.grid_client_filtered = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.tabServerUserFilter = New DevExpress.XtraTab.XtraTabPage()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.em_server_unfiltered = New DevExpress.XtraGrid.GridControl()
        Me.grid_server_unfiltered = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.txtServerFund = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.grid_server_fund = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.cmdServerMoveRight = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdServerMoveLeft = New DevExpress.XtraEditors.SimpleButton()
        Me.em_server_filtered = New DevExpress.XtraGrid.GridControl()
        Me.grid_server_filtered = New DevExpress.XtraGrid.Views.Grid.GridView()
        CType(Me.mode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.code.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtcodename.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescription.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gridmenustrip.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.tabInfo.SuspendLayout()
        CType(Me.txtTemplate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabOfficeFilter.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.em_office_filtered, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_office_filtered, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.em_office_unfiltered, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_office_unfiltered, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOfficeFund.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_office_fund, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.tabClientUserFilter.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.em_client_unfiltered, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_client_unfiltered, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtClientFund.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_client_fund, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.em_client_filtered, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_client_filtered, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabServerUserFilter.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.em_server_unfiltered, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_server_unfiltered, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtServerFund.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_server_fund, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        CType(Me.em_server_filtered, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_server_filtered, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(30, 68)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(66, 17)
        Me.LabelControl2.TabIndex = 507
        Me.LabelControl2.Text = "Description"
        '
        'mode
        '
        Me.mode.Location = New System.Drawing.Point(585, 3)
        Me.mode.Name = "mode"
        Me.mode.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mode.Properties.Appearance.Options.UseFont = True
        Me.mode.Properties.Appearance.Options.UseTextOptions = True
        Me.mode.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.mode.Properties.ReadOnly = True
        Me.mode.Size = New System.Drawing.Size(28, 24)
        Me.mode.TabIndex = 508
        Me.mode.Visible = False
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(26, 42)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(70, 17)
        Me.LabelControl1.TabIndex = 510
        Me.LabelControl1.Text = "Code Name"
        '
        'cmdSave
        '
        Me.cmdSave.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdSave.Appearance.BackColor2 = System.Drawing.Color.Khaki
        Me.cmdSave.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSave.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.cmdSave.Appearance.Options.UseBackColor = True
        Me.cmdSave.Appearance.Options.UseFont = True
        Me.cmdSave.Location = New System.Drawing.Point(102, 119)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(168, 38)
        Me.cmdSave.TabIndex = 3
        Me.cmdSave.Text = "Save"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Location = New System.Drawing.Point(65, 16)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(31, 17)
        Me.LabelControl4.TabIndex = 628
        Me.LabelControl4.Text = "Code"
        '
        'code
        '
        Me.code.EditValue = ""
        Me.code.Location = New System.Drawing.Point(102, 13)
        Me.code.Name = "code"
        Me.code.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.code.Properties.Appearance.Options.UseFont = True
        Me.code.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.code.Size = New System.Drawing.Size(168, 24)
        Me.code.TabIndex = 629
        '
        'txtcodename
        '
        Me.txtcodename.EditValue = ""
        Me.txtcodename.Location = New System.Drawing.Point(102, 39)
        Me.txtcodename.Name = "txtcodename"
        Me.txtcodename.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcodename.Properties.Appearance.Options.UseFont = True
        Me.txtcodename.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtcodename.Size = New System.Drawing.Size(168, 24)
        Me.txtcodename.TabIndex = 630
        '
        'txtDescription
        '
        Me.txtDescription.EditValue = ""
        Me.txtDescription.Location = New System.Drawing.Point(102, 65)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescription.Properties.Appearance.Options.UseFont = True
        Me.txtDescription.Size = New System.Drawing.Size(357, 24)
        Me.txtDescription.TabIndex = 631
        '
        'Em
        '
        Me.Em.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Em.ContextMenuStrip = Me.gridmenustrip
        Me.Em.Location = New System.Drawing.Point(3, 164)
        Me.Em.MainView = Me.GridView1
        Me.Em.Name = "Em"
        Me.Em.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1})
        Me.Em.Size = New System.Drawing.Size(645, 300)
        Me.Em.TabIndex = 632
        Me.Em.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'gridmenustrip
        '
        Me.gridmenustrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.gridmenustrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdEdit, Me.cmdDelete, Me.ToolStripSeparator1, Me.RefreshToolStripMenuItem})
        Me.gridmenustrip.Name = "gridmenustrip"
        Me.gridmenustrip.Size = New System.Drawing.Size(149, 88)
        '
        'cmdEdit
        '
        Me.cmdEdit.Image = Global.LGUFinancial.My.Resources.Resources.notebook__pencil
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(148, 26)
        Me.cmdEdit.Text = "Edit Selected"
        '
        'cmdDelete
        '
        Me.cmdDelete.Image = Global.LGUFinancial.My.Resources.Resources.notebook__minus
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(148, 26)
        Me.cmdDelete.Text = "Remove Item"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(145, 6)
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.Image = Global.LGUFinancial.My.Resources.Resources.arrow_continue_090_left
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(148, 26)
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
        'XtraTabControl1
        '
        Me.XtraTabControl1.AppearancePage.Header.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.XtraTabControl1.AppearancePage.Header.Options.UseFont = True
        Me.XtraTabControl1.AppearancePage.HeaderActive.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.XtraTabControl1.AppearancePage.HeaderActive.Options.UseFont = True
        Me.XtraTabControl1.AppearancePage.HeaderDisabled.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.XtraTabControl1.AppearancePage.HeaderDisabled.Options.UseFont = True
        Me.XtraTabControl1.AppearancePage.HeaderHotTracked.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.XtraTabControl1.AppearancePage.HeaderHotTracked.Options.UseFont = True
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.tabInfo
        Me.XtraTabControl1.Size = New System.Drawing.Size(653, 495)
        Me.XtraTabControl1.TabIndex = 633
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.tabInfo, Me.tabOfficeFilter, Me.tabClientUserFilter, Me.tabServerUserFilter})
        '
        'tabInfo
        '
        Me.tabInfo.Controls.Add(Me.LabelControl3)
        Me.tabInfo.Controls.Add(Me.txtTemplate)
        Me.tabInfo.Controls.Add(Me.code)
        Me.tabInfo.Controls.Add(Me.LabelControl2)
        Me.tabInfo.Controls.Add(Me.Em)
        Me.tabInfo.Controls.Add(Me.mode)
        Me.tabInfo.Controls.Add(Me.txtDescription)
        Me.tabInfo.Controls.Add(Me.LabelControl1)
        Me.tabInfo.Controls.Add(Me.txtcodename)
        Me.tabInfo.Controls.Add(Me.cmdSave)
        Me.tabInfo.Controls.Add(Me.LabelControl4)
        Me.tabInfo.Name = "tabInfo"
        Me.tabInfo.Size = New System.Drawing.Size(651, 466)
        Me.tabInfo.Text = "Fund Information"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(42, 94)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(54, 17)
        Me.LabelControl3.TabIndex = 962
        Me.LabelControl3.Text = "Template"
        '
        'txtTemplate
        '
        Me.txtTemplate.Location = New System.Drawing.Point(102, 91)
        Me.txtTemplate.Name = "txtTemplate"
        Me.txtTemplate.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtTemplate.Properties.Appearance.Options.UseFont = True
        Me.txtTemplate.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtTemplate.Properties.AppearanceDropDown.Options.UseFont = True
        Me.txtTemplate.Properties.AppearanceFocused.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtTemplate.Properties.AppearanceFocused.Options.UseFont = True
        Me.txtTemplate.Properties.AppearanceItemSelected.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtTemplate.Properties.AppearanceItemSelected.Options.UseFont = True
        Me.txtTemplate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtTemplate.Properties.Items.AddRange(New Object() {"FURS", "CAFOA"})
        Me.txtTemplate.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.txtTemplate.Size = New System.Drawing.Size(135, 24)
        Me.txtTemplate.TabIndex = 961
        '
        'tabOfficeFilter
        '
        Me.tabOfficeFilter.Controls.Add(Me.TableLayoutPanel2)
        Me.tabOfficeFilter.Name = "tabOfficeFilter"
        Me.tabOfficeFilter.Size = New System.Drawing.Size(651, 466)
        Me.tabOfficeFilter.Text = "Department Access Filter"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 42.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.em_office_filtered, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Panel3, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Panel4, 1, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(651, 466)
        Me.TableLayoutPanel2.TabIndex = 710
        '
        'em_office_filtered
        '
        Me.em_office_filtered.Dock = System.Windows.Forms.DockStyle.Fill
        Me.em_office_filtered.Location = New System.Drawing.Point(349, 3)
        Me.em_office_filtered.MainView = Me.grid_office_filtered
        Me.em_office_filtered.Name = "em_office_filtered"
        Me.em_office_filtered.Size = New System.Drawing.Size(299, 460)
        Me.em_office_filtered.TabIndex = 706
        Me.em_office_filtered.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grid_office_filtered})
        '
        'grid_office_filtered
        '
        Me.grid_office_filtered.Appearance.FocusedCell.BackColor = System.Drawing.Color.Yellow
        Me.grid_office_filtered.Appearance.FocusedCell.Options.UseBackColor = True
        Me.grid_office_filtered.GridControl = Me.em_office_filtered
        Me.grid_office_filtered.Name = "grid_office_filtered"
        Me.grid_office_filtered.OptionsBehavior.Editable = False
        Me.grid_office_filtered.OptionsSelection.MultiSelect = True
        Me.grid_office_filtered.OptionsView.RowAutoHeight = True
        Me.grid_office_filtered.OptionsView.ShowGroupPanel = False
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.em_office_unfiltered)
        Me.Panel3.Controls.Add(Me.txtOfficeFund)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(3, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(298, 460)
        Me.Panel3.TabIndex = 703
        '
        'em_office_unfiltered
        '
        Me.em_office_unfiltered.Dock = System.Windows.Forms.DockStyle.Fill
        Me.em_office_unfiltered.Location = New System.Drawing.Point(0, 24)
        Me.em_office_unfiltered.MainView = Me.grid_office_unfiltered
        Me.em_office_unfiltered.Name = "em_office_unfiltered"
        Me.em_office_unfiltered.Size = New System.Drawing.Size(298, 436)
        Me.em_office_unfiltered.TabIndex = 705
        Me.em_office_unfiltered.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grid_office_unfiltered})
        '
        'grid_office_unfiltered
        '
        Me.grid_office_unfiltered.Appearance.FocusedCell.BackColor = System.Drawing.Color.Yellow
        Me.grid_office_unfiltered.Appearance.FocusedCell.Options.UseBackColor = True
        Me.grid_office_unfiltered.GridControl = Me.em_office_unfiltered
        Me.grid_office_unfiltered.Name = "grid_office_unfiltered"
        Me.grid_office_unfiltered.OptionsBehavior.Editable = False
        Me.grid_office_unfiltered.OptionsSelection.MultiSelect = True
        Me.grid_office_unfiltered.OptionsView.RowAutoHeight = True
        Me.grid_office_unfiltered.OptionsView.ShowGroupPanel = False
        '
        'txtOfficeFund
        '
        Me.txtOfficeFund.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtOfficeFund.EditValue = ""
        Me.txtOfficeFund.Location = New System.Drawing.Point(0, 0)
        Me.txtOfficeFund.Name = "txtOfficeFund"
        Me.txtOfficeFund.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtOfficeFund.Properties.Appearance.Options.UseFont = True
        Me.txtOfficeFund.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtOfficeFund.Properties.DisplayMember = "Select"
        Me.txtOfficeFund.Properties.NullText = ""
        Me.txtOfficeFund.Properties.PopupView = Me.grid_office_fund
        Me.txtOfficeFund.Properties.ValueMember = "code"
        Me.txtOfficeFund.Size = New System.Drawing.Size(298, 24)
        Me.txtOfficeFund.TabIndex = 704
        '
        'grid_office_fund
        '
        Me.grid_office_fund.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.grid_office_fund.Name = "grid_office_fund"
        Me.grid_office_fund.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.grid_office_fund.OptionsView.ShowGroupPanel = False
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.cmdOfficeMoveRight)
        Me.Panel4.Controls.Add(Me.cmdOfficeMoveLeft)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(307, 3)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(36, 460)
        Me.Panel4.TabIndex = 0
        '
        'cmdOfficeMoveRight
        '
        Me.cmdOfficeMoveRight.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOfficeMoveRight.Appearance.Options.UseFont = True
        Me.cmdOfficeMoveRight.Location = New System.Drawing.Point(1, 47)
        Me.cmdOfficeMoveRight.Name = "cmdOfficeMoveRight"
        Me.cmdOfficeMoveRight.Size = New System.Drawing.Size(34, 36)
        Me.cmdOfficeMoveRight.TabIndex = 707
        Me.cmdOfficeMoveRight.Text = ">"
        '
        'cmdOfficeMoveLeft
        '
        Me.cmdOfficeMoveLeft.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOfficeMoveLeft.Appearance.Options.UseFont = True
        Me.cmdOfficeMoveLeft.Location = New System.Drawing.Point(1, 89)
        Me.cmdOfficeMoveLeft.Name = "cmdOfficeMoveLeft"
        Me.cmdOfficeMoveLeft.Size = New System.Drawing.Size(34, 36)
        Me.cmdOfficeMoveLeft.TabIndex = 708
        Me.cmdOfficeMoveLeft.Text = "<"
        '
        'tabClientUserFilter
        '
        Me.tabClientUserFilter.Controls.Add(Me.TableLayoutPanel1)
        Me.tabClientUserFilter.Name = "tabClientUserFilter"
        Me.tabClientUserFilter.Size = New System.Drawing.Size(651, 466)
        Me.tabClientUserFilter.Text = "Client User Access Filter"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 42.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.em_client_filtered, 2, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(651, 466)
        Me.TableLayoutPanel1.TabIndex = 709
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.em_client_unfiltered)
        Me.Panel2.Controls.Add(Me.txtClientFund)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(298, 460)
        Me.Panel2.TabIndex = 703
        '
        'em_client_unfiltered
        '
        Me.em_client_unfiltered.Dock = System.Windows.Forms.DockStyle.Fill
        Me.em_client_unfiltered.Location = New System.Drawing.Point(0, 24)
        Me.em_client_unfiltered.MainView = Me.grid_client_unfiltered
        Me.em_client_unfiltered.Name = "em_client_unfiltered"
        Me.em_client_unfiltered.Size = New System.Drawing.Size(298, 436)
        Me.em_client_unfiltered.TabIndex = 699
        Me.em_client_unfiltered.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grid_client_unfiltered})
        '
        'grid_client_unfiltered
        '
        Me.grid_client_unfiltered.Appearance.FocusedCell.BackColor = System.Drawing.Color.Yellow
        Me.grid_client_unfiltered.Appearance.FocusedCell.Options.UseBackColor = True
        Me.grid_client_unfiltered.GridControl = Me.em_client_unfiltered
        Me.grid_client_unfiltered.Name = "grid_client_unfiltered"
        Me.grid_client_unfiltered.OptionsBehavior.Editable = False
        Me.grid_client_unfiltered.OptionsSelection.MultiSelect = True
        Me.grid_client_unfiltered.OptionsView.RowAutoHeight = True
        Me.grid_client_unfiltered.OptionsView.ShowGroupPanel = False
        '
        'txtClientFund
        '
        Me.txtClientFund.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtClientFund.EditValue = ""
        Me.txtClientFund.Location = New System.Drawing.Point(0, 0)
        Me.txtClientFund.Name = "txtClientFund"
        Me.txtClientFund.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtClientFund.Properties.Appearance.Options.UseFont = True
        Me.txtClientFund.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtClientFund.Properties.DisplayMember = "Select"
        Me.txtClientFund.Properties.NullText = ""
        Me.txtClientFund.Properties.PopupView = Me.grid_client_fund
        Me.txtClientFund.Properties.ValueMember = "code"
        Me.txtClientFund.Size = New System.Drawing.Size(298, 24)
        Me.txtClientFund.TabIndex = 705
        '
        'grid_client_fund
        '
        Me.grid_client_fund.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.grid_client_fund.Name = "grid_client_fund"
        Me.grid_client_fund.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.grid_client_fund.OptionsView.ShowGroupPanel = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cmdClientMoveRight)
        Me.Panel1.Controls.Add(Me.cmdClientMoveLeft)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(307, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(36, 460)
        Me.Panel1.TabIndex = 0
        '
        'cmdClientMoveRight
        '
        Me.cmdClientMoveRight.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdClientMoveRight.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClientMoveRight.Appearance.Options.UseFont = True
        Me.cmdClientMoveRight.Location = New System.Drawing.Point(1, 47)
        Me.cmdClientMoveRight.Name = "cmdClientMoveRight"
        Me.cmdClientMoveRight.Size = New System.Drawing.Size(34, 36)
        Me.cmdClientMoveRight.TabIndex = 701
        Me.cmdClientMoveRight.Text = ">"
        '
        'cmdClientMoveLeft
        '
        Me.cmdClientMoveLeft.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdClientMoveLeft.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClientMoveLeft.Appearance.Options.UseFont = True
        Me.cmdClientMoveLeft.Location = New System.Drawing.Point(1, 89)
        Me.cmdClientMoveLeft.Name = "cmdClientMoveLeft"
        Me.cmdClientMoveLeft.Size = New System.Drawing.Size(34, 36)
        Me.cmdClientMoveLeft.TabIndex = 702
        Me.cmdClientMoveLeft.Text = "<"
        '
        'em_client_filtered
        '
        Me.em_client_filtered.Dock = System.Windows.Forms.DockStyle.Fill
        Me.em_client_filtered.Location = New System.Drawing.Point(349, 3)
        Me.em_client_filtered.MainView = Me.grid_client_filtered
        Me.em_client_filtered.Name = "em_client_filtered"
        Me.em_client_filtered.Size = New System.Drawing.Size(299, 460)
        Me.em_client_filtered.TabIndex = 700
        Me.em_client_filtered.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grid_client_filtered})
        '
        'grid_client_filtered
        '
        Me.grid_client_filtered.Appearance.FocusedCell.BackColor = System.Drawing.Color.Yellow
        Me.grid_client_filtered.Appearance.FocusedCell.Options.UseBackColor = True
        Me.grid_client_filtered.GridControl = Me.em_client_filtered
        Me.grid_client_filtered.Name = "grid_client_filtered"
        Me.grid_client_filtered.OptionsBehavior.Editable = False
        Me.grid_client_filtered.OptionsSelection.MultiSelect = True
        Me.grid_client_filtered.OptionsView.RowAutoHeight = True
        Me.grid_client_filtered.OptionsView.ShowGroupPanel = False
        '
        'tabServerUserFilter
        '
        Me.tabServerUserFilter.Controls.Add(Me.TableLayoutPanel3)
        Me.tabServerUserFilter.Name = "tabServerUserFilter"
        Me.tabServerUserFilter.Size = New System.Drawing.Size(651, 466)
        Me.tabServerUserFilter.Text = "Server User Access Filter"
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 3
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 42.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.Panel5, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Panel6, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.em_server_filtered, 2, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(651, 466)
        Me.TableLayoutPanel3.TabIndex = 710
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.em_server_unfiltered)
        Me.Panel5.Controls.Add(Me.txtServerFund)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(3, 3)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(298, 460)
        Me.Panel5.TabIndex = 703
        '
        'em_server_unfiltered
        '
        Me.em_server_unfiltered.Dock = System.Windows.Forms.DockStyle.Fill
        Me.em_server_unfiltered.Location = New System.Drawing.Point(0, 24)
        Me.em_server_unfiltered.MainView = Me.grid_server_unfiltered
        Me.em_server_unfiltered.Name = "em_server_unfiltered"
        Me.em_server_unfiltered.Size = New System.Drawing.Size(298, 436)
        Me.em_server_unfiltered.TabIndex = 699
        Me.em_server_unfiltered.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grid_server_unfiltered})
        '
        'grid_server_unfiltered
        '
        Me.grid_server_unfiltered.Appearance.FocusedCell.BackColor = System.Drawing.Color.Yellow
        Me.grid_server_unfiltered.Appearance.FocusedCell.Options.UseBackColor = True
        Me.grid_server_unfiltered.GridControl = Me.em_server_unfiltered
        Me.grid_server_unfiltered.Name = "grid_server_unfiltered"
        Me.grid_server_unfiltered.OptionsBehavior.Editable = False
        Me.grid_server_unfiltered.OptionsSelection.MultiSelect = True
        Me.grid_server_unfiltered.OptionsView.RowAutoHeight = True
        Me.grid_server_unfiltered.OptionsView.ShowGroupPanel = False
        '
        'txtServerFund
        '
        Me.txtServerFund.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtServerFund.EditValue = ""
        Me.txtServerFund.Location = New System.Drawing.Point(0, 0)
        Me.txtServerFund.Name = "txtServerFund"
        Me.txtServerFund.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtServerFund.Properties.Appearance.Options.UseFont = True
        Me.txtServerFund.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtServerFund.Properties.DisplayMember = "Select"
        Me.txtServerFund.Properties.NullText = ""
        Me.txtServerFund.Properties.PopupView = Me.grid_server_fund
        Me.txtServerFund.Properties.ValueMember = "code"
        Me.txtServerFund.Size = New System.Drawing.Size(298, 24)
        Me.txtServerFund.TabIndex = 705
        '
        'grid_server_fund
        '
        Me.grid_server_fund.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.grid_server_fund.Name = "grid_server_fund"
        Me.grid_server_fund.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.grid_server_fund.OptionsView.ShowGroupPanel = False
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.cmdServerMoveRight)
        Me.Panel6.Controls.Add(Me.cmdServerMoveLeft)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(307, 3)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(36, 460)
        Me.Panel6.TabIndex = 0
        '
        'cmdServerMoveRight
        '
        Me.cmdServerMoveRight.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdServerMoveRight.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdServerMoveRight.Appearance.Options.UseFont = True
        Me.cmdServerMoveRight.Location = New System.Drawing.Point(1, 47)
        Me.cmdServerMoveRight.Name = "cmdServerMoveRight"
        Me.cmdServerMoveRight.Size = New System.Drawing.Size(34, 36)
        Me.cmdServerMoveRight.TabIndex = 701
        Me.cmdServerMoveRight.Text = ">"
        '
        'cmdServerMoveLeft
        '
        Me.cmdServerMoveLeft.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdServerMoveLeft.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdServerMoveLeft.Appearance.Options.UseFont = True
        Me.cmdServerMoveLeft.Location = New System.Drawing.Point(1, 89)
        Me.cmdServerMoveLeft.Name = "cmdServerMoveLeft"
        Me.cmdServerMoveLeft.Size = New System.Drawing.Size(34, 36)
        Me.cmdServerMoveLeft.TabIndex = 702
        Me.cmdServerMoveLeft.Text = "<"
        '
        'em_server_filtered
        '
        Me.em_server_filtered.Dock = System.Windows.Forms.DockStyle.Fill
        Me.em_server_filtered.Location = New System.Drawing.Point(349, 3)
        Me.em_server_filtered.MainView = Me.grid_server_filtered
        Me.em_server_filtered.Name = "em_server_filtered"
        Me.em_server_filtered.Size = New System.Drawing.Size(299, 460)
        Me.em_server_filtered.TabIndex = 700
        Me.em_server_filtered.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grid_server_filtered})
        '
        'grid_server_filtered
        '
        Me.grid_server_filtered.Appearance.FocusedCell.BackColor = System.Drawing.Color.Yellow
        Me.grid_server_filtered.Appearance.FocusedCell.Options.UseBackColor = True
        Me.grid_server_filtered.GridControl = Me.em_server_filtered
        Me.grid_server_filtered.Name = "grid_server_filtered"
        Me.grid_server_filtered.OptionsBehavior.Editable = False
        Me.grid_server_filtered.OptionsSelection.MultiSelect = True
        Me.grid_server_filtered.OptionsView.RowAutoHeight = True
        Me.grid_server_filtered.OptionsView.ShowGroupPanel = False
        '
        'frmFund
        '
        Me.AcceptButton = Me.cmdSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(653, 495)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Name = "frmFund"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Fund Table"
        CType(Me.mode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.code.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtcodename.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescription.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gridmenustrip.ResumeLayout(False)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.tabInfo.ResumeLayout(False)
        Me.tabInfo.PerformLayout()
        CType(Me.txtTemplate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabOfficeFilter.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        CType(Me.em_office_filtered, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_office_filtered, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        CType(Me.em_office_unfiltered, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_office_unfiltered, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOfficeFund.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_office_fund, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.tabClientUserFilter.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.em_client_unfiltered, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_client_unfiltered, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtClientFund.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_client_fund, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.em_client_filtered, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_client_filtered, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabServerUserFilter.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        CType(Me.em_server_unfiltered, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_server_unfiltered, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtServerFund.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_server_fund, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        CType(Me.em_server_filtered, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_server_filtered, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents mode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents code As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtcodename As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDescription As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Em As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents gridmenustrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmdEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdDelete As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents RefreshToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents tabInfo As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tabOfficeFilter As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents cmdOfficeMoveLeft As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdOfficeMoveRight As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents em_office_unfiltered As DevExpress.XtraGrid.GridControl
    Friend WithEvents grid_office_unfiltered As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents em_office_filtered As DevExpress.XtraGrid.GridControl
    Friend WithEvents grid_office_filtered As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtOfficeFund As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents grid_office_fund As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTemplate As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents tabClientUserFilter As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents cmdClientMoveRight As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdClientMoveLeft As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents em_client_filtered As DevExpress.XtraGrid.GridControl
    Friend WithEvents grid_client_filtered As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents em_client_unfiltered As DevExpress.XtraGrid.GridControl
    Friend WithEvents grid_client_unfiltered As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtClientFund As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents grid_client_fund As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents tabServerUserFilter As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents em_server_unfiltered As DevExpress.XtraGrid.GridControl
    Friend WithEvents grid_server_unfiltered As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtServerFund As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents grid_server_fund As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Panel6 As Panel
    Friend WithEvents cmdServerMoveRight As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdServerMoveLeft As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents em_server_filtered As DevExpress.XtraGrid.GridControl
    Friend WithEvents grid_server_filtered As DevExpress.XtraGrid.Views.Grid.GridView
End Class
