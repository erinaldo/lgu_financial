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
        Me.tabFilter = New DevExpress.XtraTab.XtraTabPage()
        Me.fundcode = New DevExpress.XtraEditors.ButtonEdit()
        Me.cmdMoveLeft = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdMoveRight = New DevExpress.XtraEditors.SimpleButton()
        Me.Em_unfiltered = New DevExpress.XtraGrid.GridControl()
        Me.gridUnfiltered = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Em_filtered = New DevExpress.XtraGrid.GridControl()
        Me.gridFiltered = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.txtFund = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.gridFund = New DevExpress.XtraGrid.Views.Grid.GridView()
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
        Me.tabFilter.SuspendLayout()
        CType(Me.fundcode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Em_unfiltered, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridUnfiltered, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Em_filtered, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridFiltered, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFund.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridFund, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(31, 68)
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
        Me.LabelControl1.Location = New System.Drawing.Point(27, 42)
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
        Me.LabelControl4.Location = New System.Drawing.Point(66, 16)
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
        Me.Em.ContextMenuStrip = Me.gridmenustrip
        Me.Em.Location = New System.Drawing.Point(3, 165)
        Me.Em.MainView = Me.GridView1
        Me.Em.Name = "Em"
        Me.Em.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1})
        Me.Em.Size = New System.Drawing.Size(621, 314)
        Me.Em.TabIndex = 632
        Me.Em.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'gridmenustrip
        '
        Me.gridmenustrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdEdit, Me.cmdDelete, Me.ToolStripSeparator1, Me.RefreshToolStripMenuItem})
        Me.gridmenustrip.Name = "gridmenustrip"
        Me.gridmenustrip.Size = New System.Drawing.Size(145, 76)
        '
        'cmdEdit
        '
        Me.cmdEdit.Image = Global.LGUFinancial.My.Resources.Resources.notebook__pencil
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(144, 22)
        Me.cmdEdit.Text = "Edit Selected"
        '
        'cmdDelete
        '
        Me.cmdDelete.Image = Global.LGUFinancial.My.Resources.Resources.notebook__minus
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(144, 22)
        Me.cmdDelete.Text = "Remove Item"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(141, 6)
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.Image = Global.LGUFinancial.My.Resources.Resources.arrow_continue_090_left
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
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
        Me.XtraTabControl1.Size = New System.Drawing.Size(629, 515)
        Me.XtraTabControl1.TabIndex = 633
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.tabInfo, Me.tabFilter})
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
        Me.tabInfo.Size = New System.Drawing.Size(627, 486)
        Me.tabInfo.Text = "Fund Information"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(43, 94)
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
        Me.txtTemplate.Size = New System.Drawing.Size(168, 24)
        Me.txtTemplate.TabIndex = 961
        '
        'tabFilter
        '
        Me.tabFilter.Controls.Add(Me.fundcode)
        Me.tabFilter.Controls.Add(Me.cmdMoveLeft)
        Me.tabFilter.Controls.Add(Me.cmdMoveRight)
        Me.tabFilter.Controls.Add(Me.Em_unfiltered)
        Me.tabFilter.Controls.Add(Me.Em_filtered)
        Me.tabFilter.Controls.Add(Me.txtFund)
        Me.tabFilter.Name = "tabFilter"
        Me.tabFilter.Size = New System.Drawing.Size(627, 486)
        Me.tabFilter.Text = "Fund Access Filter"
        '
        'fundcode
        '
        Me.fundcode.EditValue = ""
        Me.fundcode.Location = New System.Drawing.Point(287, 12)
        Me.fundcode.Name = "fundcode"
        Me.fundcode.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.fundcode.Properties.Appearance.Options.UseFont = True
        Me.fundcode.Properties.Appearance.Options.UseTextOptions = True
        Me.fundcode.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.fundcode.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.fundcode.Properties.Mask.BeepOnError = True
        Me.fundcode.Properties.ReadOnly = True
        Me.fundcode.Size = New System.Drawing.Size(33, 22)
        Me.fundcode.TabIndex = 709
        Me.fundcode.Visible = False
        '
        'cmdMoveLeft
        '
        Me.cmdMoveLeft.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdMoveLeft.Appearance.Options.UseFont = True
        Me.cmdMoveLeft.Location = New System.Drawing.Point(287, 179)
        Me.cmdMoveLeft.Name = "cmdMoveLeft"
        Me.cmdMoveLeft.Size = New System.Drawing.Size(46, 46)
        Me.cmdMoveLeft.TabIndex = 708
        Me.cmdMoveLeft.Text = "<"
        '
        'cmdMoveRight
        '
        Me.cmdMoveRight.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdMoveRight.Appearance.Options.UseFont = True
        Me.cmdMoveRight.Location = New System.Drawing.Point(287, 127)
        Me.cmdMoveRight.Name = "cmdMoveRight"
        Me.cmdMoveRight.Size = New System.Drawing.Size(46, 46)
        Me.cmdMoveRight.TabIndex = 707
        Me.cmdMoveRight.Text = ">"
        '
        'Em_unfiltered
        '
        Me.Em_unfiltered.Location = New System.Drawing.Point(11, 38)
        Me.Em_unfiltered.MainView = Me.gridUnfiltered
        Me.Em_unfiltered.Name = "Em_unfiltered"
        Me.Em_unfiltered.Size = New System.Drawing.Size(272, 433)
        Me.Em_unfiltered.TabIndex = 705
        Me.Em_unfiltered.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridUnfiltered})
        '
        'gridUnfiltered
        '
        Me.gridUnfiltered.Appearance.FocusedCell.BackColor = System.Drawing.Color.Yellow
        Me.gridUnfiltered.Appearance.FocusedCell.Options.UseBackColor = True
        Me.gridUnfiltered.GridControl = Me.Em_unfiltered
        Me.gridUnfiltered.Name = "gridUnfiltered"
        Me.gridUnfiltered.OptionsBehavior.Editable = False
        Me.gridUnfiltered.OptionsSelection.MultiSelect = True
        Me.gridUnfiltered.OptionsView.RowAutoHeight = True
        Me.gridUnfiltered.OptionsView.ShowGroupPanel = False
        '
        'Em_filtered
        '
        Me.Em_filtered.Location = New System.Drawing.Point(337, 18)
        Me.Em_filtered.MainView = Me.gridFiltered
        Me.Em_filtered.Name = "Em_filtered"
        Me.Em_filtered.Size = New System.Drawing.Size(272, 453)
        Me.Em_filtered.TabIndex = 706
        Me.Em_filtered.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridFiltered})
        '
        'gridFiltered
        '
        Me.gridFiltered.Appearance.FocusedCell.BackColor = System.Drawing.Color.Yellow
        Me.gridFiltered.Appearance.FocusedCell.Options.UseBackColor = True
        Me.gridFiltered.GridControl = Me.Em_filtered
        Me.gridFiltered.Name = "gridFiltered"
        Me.gridFiltered.OptionsBehavior.Editable = False
        Me.gridFiltered.OptionsSelection.MultiSelect = True
        Me.gridFiltered.OptionsView.RowAutoHeight = True
        Me.gridFiltered.OptionsView.ShowGroupPanel = False
        '
        'txtFund
        '
        Me.txtFund.EditValue = ""
        Me.txtFund.Location = New System.Drawing.Point(11, 11)
        Me.txtFund.Name = "txtFund"
        Me.txtFund.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtFund.Properties.Appearance.Options.UseFont = True
        Me.txtFund.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtFund.Properties.DisplayMember = "Select"
        Me.txtFund.Properties.NullText = ""
        Me.txtFund.Properties.PopupView = Me.gridFund
        Me.txtFund.Properties.ValueMember = "code"
        Me.txtFund.Size = New System.Drawing.Size(272, 24)
        Me.txtFund.TabIndex = 704
        '
        'gridFund
        '
        Me.gridFund.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gridFund.Name = "gridFund"
        Me.gridFund.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridFund.OptionsView.ShowGroupPanel = False
        '
        'frmFund
        '
        Me.AcceptButton = Me.cmdSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(629, 515)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
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
        Me.tabFilter.ResumeLayout(False)
        CType(Me.fundcode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Em_unfiltered, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridUnfiltered, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Em_filtered, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridFiltered, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFund.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridFund, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents tabFilter As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents fundcode As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents cmdMoveLeft As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdMoveRight As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Em_unfiltered As DevExpress.XtraGrid.GridControl
    Friend WithEvents gridUnfiltered As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Em_filtered As DevExpress.XtraGrid.GridControl
    Friend WithEvents gridFiltered As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtFund As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents gridFund As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTemplate As DevExpress.XtraEditors.ComboBoxEdit
End Class
