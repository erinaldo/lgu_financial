<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCashFlowItem
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
        Me.mode = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.cmdSaveButton = New DevExpress.XtraEditors.SimpleButton()
        Me.txtCashFlowName = New DevExpress.XtraEditors.TextEdit()
        Me.Em = New DevExpress.XtraGrid.GridControl()
        Me.gridmenustrip = New System.Windows.Forms.ContextMenuStrip()
        Me.cmdEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdDelete = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.code = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.tabCashflowInfo = New DevExpress.XtraTab.XtraTabPage()
        Me.tabCashflowTagging = New DevExpress.XtraTab.XtraTabPage()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.cmdMoveLeft = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdMoveRight = New DevExpress.XtraEditors.SimpleButton()
        Me.Em_unfiltered = New DevExpress.XtraGrid.GridControl()
        Me.gridUnFiltered = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.cashflowcode = New DevExpress.XtraEditors.TextEdit()
        Me.txtTagCashFlowName = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.gridTagCashFlowName = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Em_filtered = New DevExpress.XtraGrid.GridControl()
        Me.gridFiltered = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl1 = New DevExpress.XtraBars.BarDockControl()
        CType(Me.mode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCashFlowName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gridmenustrip.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.code.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.tabCashflowInfo.SuspendLayout()
        Me.tabCashflowTagging.SuspendLayout()
        CType(Me.Em_unfiltered, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridUnFiltered, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cashflowcode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTagCashFlowName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridTagCashFlowName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Em_filtered, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridFiltered, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mode
        '
        Me.mode.Location = New System.Drawing.Point(1055, 25)
        Me.mode.Name = "mode"
        Me.mode.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mode.Properties.Appearance.Options.UseFont = True
        Me.mode.Properties.Appearance.Options.UseTextOptions = True
        Me.mode.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.mode.Properties.ReadOnly = True
        Me.mode.Size = New System.Drawing.Size(77, 24)
        Me.mode.TabIndex = 508
        Me.mode.Visible = False
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(47, 50)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(97, 17)
        Me.LabelControl1.TabIndex = 510
        Me.LabelControl1.Text = "Cash Flow Name"
        '
        'cmdSaveButton
        '
        Me.cmdSaveButton.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdSaveButton.Appearance.BackColor2 = System.Drawing.Color.Khaki
        Me.cmdSaveButton.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSaveButton.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.cmdSaveButton.Appearance.Options.UseBackColor = True
        Me.cmdSaveButton.Appearance.Options.UseFont = True
        Me.cmdSaveButton.Location = New System.Drawing.Point(387, 77)
        Me.cmdSaveButton.Name = "cmdSaveButton"
        Me.cmdSaveButton.Size = New System.Drawing.Size(157, 31)
        Me.cmdSaveButton.TabIndex = 6
        Me.cmdSaveButton.Text = "Save"
        '
        'txtCashFlowName
        '
        Me.txtCashFlowName.EditValue = ""
        Me.txtCashFlowName.Location = New System.Drawing.Point(150, 47)
        Me.txtCashFlowName.Name = "txtCashFlowName"
        Me.txtCashFlowName.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCashFlowName.Properties.Appearance.Options.UseFont = True
        Me.txtCashFlowName.Size = New System.Drawing.Size(394, 24)
        Me.txtCashFlowName.TabIndex = 1
        '
        'Em
        '
        Me.Em.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Em.ContextMenuStrip = Me.gridmenustrip
        Me.Em.Location = New System.Drawing.Point(10, 113)
        Me.Em.MainView = Me.GridView1
        Me.Em.Name = "Em"
        Me.Em.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1})
        Me.Em.Size = New System.Drawing.Size(688, 355)
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
        'code
        '
        Me.code.Location = New System.Drawing.Point(150, 20)
        Me.code.Name = "code"
        Me.code.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.code.Properties.Appearance.Options.UseFont = True
        Me.code.Properties.Appearance.Options.UseTextOptions = True
        Me.code.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.code.Size = New System.Drawing.Size(129, 24)
        Me.code.TabIndex = 0
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(113, 23)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(31, 17)
        Me.LabelControl2.TabIndex = 644
        Me.LabelControl2.Text = "Code"
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.AppearancePage.Header.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.XtraTabControl1.AppearancePage.Header.Options.UseFont = True
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.tabCashflowInfo
        Me.XtraTabControl1.Size = New System.Drawing.Size(712, 506)
        Me.XtraTabControl1.TabIndex = 645
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.tabCashflowInfo, Me.tabCashflowTagging})
        '
        'tabCashflowInfo
        '
        Me.tabCashflowInfo.Controls.Add(Me.code)
        Me.tabCashflowInfo.Controls.Add(Me.LabelControl2)
        Me.tabCashflowInfo.Controls.Add(Me.mode)
        Me.tabCashflowInfo.Controls.Add(Me.LabelControl1)
        Me.tabCashflowInfo.Controls.Add(Me.cmdSaveButton)
        Me.tabCashflowInfo.Controls.Add(Me.Em)
        Me.tabCashflowInfo.Controls.Add(Me.txtCashFlowName)
        Me.tabCashflowInfo.Name = "tabCashflowInfo"
        Me.tabCashflowInfo.Size = New System.Drawing.Size(706, 474)
        Me.tabCashflowInfo.Text = "Cash Flow Info"
        '
        'tabCashflowTagging
        '
        Me.tabCashflowTagging.Controls.Add(Me.LabelControl3)
        Me.tabCashflowTagging.Controls.Add(Me.cmdMoveLeft)
        Me.tabCashflowTagging.Controls.Add(Me.cmdMoveRight)
        Me.tabCashflowTagging.Controls.Add(Me.Em_unfiltered)
        Me.tabCashflowTagging.Controls.Add(Me.cashflowcode)
        Me.tabCashflowTagging.Controls.Add(Me.txtTagCashFlowName)
        Me.tabCashflowTagging.Controls.Add(Me.Em_filtered)
        Me.tabCashflowTagging.Controls.Add(Me.barDockControlRight)
        Me.tabCashflowTagging.Controls.Add(Me.BarDockControl1)
        Me.tabCashflowTagging.Name = "tabCashflowTagging"
        Me.tabCashflowTagging.Size = New System.Drawing.Size(706, 474)
        Me.tabCashflowTagging.Text = "Cash Flow Tagging"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(9, 6)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(196, 17)
        Me.LabelControl3.TabIndex = 713
        Me.LabelControl3.Text = "Select cash flow transaction name"
        '
        'cmdMoveLeft
        '
        Me.cmdMoveLeft.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdMoveLeft.Appearance.Font = New System.Drawing.Font("Tahoma", 10.25!)
        Me.cmdMoveLeft.Appearance.Options.UseFont = True
        Me.cmdMoveLeft.Location = New System.Drawing.Point(328, 232)
        Me.cmdMoveLeft.Name = "cmdMoveLeft"
        Me.cmdMoveLeft.Size = New System.Drawing.Size(46, 46)
        Me.cmdMoveLeft.TabIndex = 710
        Me.cmdMoveLeft.Text = "<"
        '
        'cmdMoveRight
        '
        Me.cmdMoveRight.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdMoveRight.Appearance.Font = New System.Drawing.Font("Tahoma", 10.25!)
        Me.cmdMoveRight.Appearance.Options.UseFont = True
        Me.cmdMoveRight.Location = New System.Drawing.Point(328, 180)
        Me.cmdMoveRight.Name = "cmdMoveRight"
        Me.cmdMoveRight.Size = New System.Drawing.Size(46, 46)
        Me.cmdMoveRight.TabIndex = 709
        Me.cmdMoveRight.Text = ">"
        '
        'Em_unfiltered
        '
        Me.Em_unfiltered.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Em_unfiltered.Location = New System.Drawing.Point(9, 59)
        Me.Em_unfiltered.MainView = Me.gridUnFiltered
        Me.Em_unfiltered.Name = "Em_unfiltered"
        Me.Em_unfiltered.Size = New System.Drawing.Size(306, 408)
        Me.Em_unfiltered.TabIndex = 707
        Me.Em_unfiltered.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridUnFiltered})
        '
        'gridUnFiltered
        '
        Me.gridUnFiltered.Appearance.FocusedCell.BackColor = System.Drawing.Color.Yellow
        Me.gridUnFiltered.Appearance.FocusedCell.Options.UseBackColor = True
        Me.gridUnFiltered.GridControl = Me.Em_unfiltered
        Me.gridUnFiltered.Name = "gridUnFiltered"
        Me.gridUnFiltered.OptionsBehavior.Editable = False
        Me.gridUnFiltered.OptionsSelection.MultiSelect = True
        Me.gridUnFiltered.OptionsView.RowAutoHeight = True
        Me.gridUnFiltered.OptionsView.ShowGroupPanel = False
        '
        'cashflowcode
        '
        Me.cashflowcode.EditValue = ""
        Me.cashflowcode.Location = New System.Drawing.Point(323, 47)
        Me.cashflowcode.Name = "cashflowcode"
        Me.cashflowcode.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cashflowcode.Size = New System.Drawing.Size(33, 20)
        Me.cashflowcode.TabIndex = 706
        Me.cashflowcode.Visible = False
        '
        'txtTagCashFlowName
        '
        Me.txtTagCashFlowName.EditValue = ""
        Me.txtTagCashFlowName.Location = New System.Drawing.Point(9, 29)
        Me.txtTagCashFlowName.Name = "txtTagCashFlowName"
        Me.txtTagCashFlowName.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtTagCashFlowName.Properties.Appearance.Options.UseFont = True
        Me.txtTagCashFlowName.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.txtTagCashFlowName.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtTagCashFlowName.Properties.DisplayMember = "Cash Flow Name"
        Me.txtTagCashFlowName.Properties.ImmediatePopup = True
        Me.txtTagCashFlowName.Properties.NullText = ""
        Me.txtTagCashFlowName.Properties.PopupView = Me.gridTagCashFlowName
        Me.txtTagCashFlowName.Properties.ValueMember = "code"
        Me.txtTagCashFlowName.Size = New System.Drawing.Size(306, 24)
        Me.txtTagCashFlowName.TabIndex = 705
        '
        'gridTagCashFlowName
        '
        Me.gridTagCashFlowName.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gridTagCashFlowName.Name = "gridTagCashFlowName"
        Me.gridTagCashFlowName.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridTagCashFlowName.OptionsView.ShowGroupPanel = False
        '
        'Em_filtered
        '
        Me.Em_filtered.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Em_filtered.Location = New System.Drawing.Point(386, 59)
        Me.Em_filtered.MainView = Me.gridFiltered
        Me.Em_filtered.Name = "Em_filtered"
        Me.Em_filtered.Size = New System.Drawing.Size(310, 408)
        Me.Em_filtered.TabIndex = 708
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
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(706, 0)
        Me.barDockControlRight.Manager = Nothing
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 474)
        '
        'BarDockControl1
        '
        Me.BarDockControl1.CausesValidation = False
        Me.BarDockControl1.Dock = System.Windows.Forms.DockStyle.Right
        Me.BarDockControl1.Location = New System.Drawing.Point(706, 0)
        Me.BarDockControl1.Manager = Nothing
        Me.BarDockControl1.Size = New System.Drawing.Size(0, 474)
        '
        'frmCashFlowItem
        '
        Me.AcceptButton = Me.cmdSaveButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(712, 506)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.MinimumSize = New System.Drawing.Size(728, 545)
        Me.Name = "frmCashFlowItem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cash Flow Item"
        CType(Me.mode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCashFlowName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gridmenustrip.ResumeLayout(False)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.code.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.tabCashflowInfo.ResumeLayout(False)
        Me.tabCashflowInfo.PerformLayout()
        Me.tabCashflowTagging.ResumeLayout(False)
        Me.tabCashflowTagging.PerformLayout()
        CType(Me.Em_unfiltered, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridUnFiltered, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cashflowcode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTagCashFlowName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridTagCashFlowName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Em_filtered, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridFiltered, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents mode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmdSaveButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtCashFlowName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Em As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents gridmenustrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmdEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdDelete As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents RefreshToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents code As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents tabCashflowInfo As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tabCashflowTagging As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents cmdMoveLeft As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdMoveRight As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Em_unfiltered As DevExpress.XtraGrid.GridControl
    Friend WithEvents gridUnFiltered As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cashflowcode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTagCashFlowName As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents gridTagCashFlowName As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Em_filtered As DevExpress.XtraGrid.GridControl
    Friend WithEvents gridFiltered As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl1 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
End Class
