<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBudgetQuarterly
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
        Me.cmdSaveButton = New DevExpress.XtraEditors.SimpleButton()
        Me.Em = New DevExpress.XtraGrid.GridControl()
        Me.gridmenustrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmdEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdDelete = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.txtFund = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.gridFund = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.fundcode = New DevExpress.XtraEditors.TextEdit()
        Me.yearcode = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtOffice = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.gridoffice = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.periodcode = New DevExpress.XtraEditors.TextEdit()
        Me.officeid = New DevExpress.XtraEditors.TextEdit()
        Me.CheckEdit1 = New DevExpress.XtraEditors.CheckEdit()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gridmenustrip.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFund.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridFund, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fundcode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.yearcode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOffice.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridoffice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.periodcode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.officeid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdSaveButton
        '
        Me.cmdSaveButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdSaveButton.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdSaveButton.Appearance.BackColor2 = System.Drawing.Color.Khaki
        Me.cmdSaveButton.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSaveButton.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.cmdSaveButton.Appearance.Options.UseBackColor = True
        Me.cmdSaveButton.Appearance.Options.UseFont = True
        Me.cmdSaveButton.Location = New System.Drawing.Point(775, 21)
        Me.cmdSaveButton.Name = "cmdSaveButton"
        Me.cmdSaveButton.Size = New System.Drawing.Size(207, 56)
        Me.cmdSaveButton.TabIndex = 6
        Me.cmdSaveButton.Text = "Quarter Closing"
        '
        'Em
        '
        Me.Em.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Em.ContextMenuStrip = Me.gridmenustrip
        Me.Em.Location = New System.Drawing.Point(12, 106)
        Me.Em.MainView = Me.GridView1
        Me.Em.MinimumSize = New System.Drawing.Size(574, 454)
        Me.Em.Name = "Em"
        Me.Em.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1})
        Me.Em.Size = New System.Drawing.Size(971, 499)
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
        'txtFund
        '
        Me.txtFund.EditValue = "sss"
        Me.txtFund.Location = New System.Drawing.Point(166, 22)
        Me.txtFund.Name = "txtFund"
        Me.txtFund.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtFund.Properties.Appearance.Options.UseFont = True
        Me.txtFund.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtFund.Properties.DisplayMember = "Select"
        Me.txtFund.Properties.NullText = ""
        Me.txtFund.Properties.PopupView = Me.gridFund
        Me.txtFund.Properties.ValueMember = "code"
        Me.txtFund.Size = New System.Drawing.Size(275, 24)
        Me.txtFund.TabIndex = 0
        '
        'gridFund
        '
        Me.gridFund.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gridFund.Name = "gridFund"
        Me.gridFund.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridFund.OptionsView.ShowGroupPanel = False
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(90, 25)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(66, 17)
        Me.LabelControl2.TabIndex = 634
        Me.LabelControl2.Text = "Select Fund"
        '
        'fundcode
        '
        Me.fundcode.Location = New System.Drawing.Point(842, 163)
        Me.fundcode.Name = "fundcode"
        Me.fundcode.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fundcode.Properties.Appearance.Options.UseFont = True
        Me.fundcode.Properties.Appearance.Options.UseTextOptions = True
        Me.fundcode.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.fundcode.Properties.ReadOnly = True
        Me.fundcode.Size = New System.Drawing.Size(77, 24)
        Me.fundcode.TabIndex = 642
        Me.fundcode.Visible = False
        '
        'yearcode
        '
        Me.yearcode.Location = New System.Drawing.Point(842, 190)
        Me.yearcode.Name = "yearcode"
        Me.yearcode.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.yearcode.Properties.Appearance.Options.UseFont = True
        Me.yearcode.Properties.Appearance.Options.UseTextOptions = True
        Me.yearcode.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.yearcode.Properties.ReadOnly = True
        Me.yearcode.Size = New System.Drawing.Size(77, 24)
        Me.yearcode.TabIndex = 643
        Me.yearcode.Visible = False
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(84, 52)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(72, 17)
        Me.LabelControl3.TabIndex = 645
        Me.LabelControl3.Text = "Select Office"
        '
        'txtOffice
        '
        Me.txtOffice.EditValue = "sss"
        Me.txtOffice.Location = New System.Drawing.Point(166, 49)
        Me.txtOffice.Name = "txtOffice"
        Me.txtOffice.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtOffice.Properties.Appearance.Options.UseFont = True
        Me.txtOffice.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtOffice.Properties.DisplayMember = "Select"
        Me.txtOffice.Properties.NullText = ""
        Me.txtOffice.Properties.PopupView = Me.gridoffice
        Me.txtOffice.Properties.ValueMember = "code"
        Me.txtOffice.Size = New System.Drawing.Size(275, 24)
        Me.txtOffice.TabIndex = 644
        '
        'gridoffice
        '
        Me.gridoffice.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gridoffice.Name = "gridoffice"
        Me.gridoffice.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridoffice.OptionsView.ShowGroupPanel = False
        '
        'periodcode
        '
        Me.periodcode.Location = New System.Drawing.Point(842, 135)
        Me.periodcode.Name = "periodcode"
        Me.periodcode.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.periodcode.Properties.Appearance.Options.UseFont = True
        Me.periodcode.Properties.Appearance.Options.UseTextOptions = True
        Me.periodcode.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.periodcode.Properties.ReadOnly = True
        Me.periodcode.Size = New System.Drawing.Size(77, 24)
        Me.periodcode.TabIndex = 646
        Me.periodcode.Visible = False
        '
        'officeid
        '
        Me.officeid.Location = New System.Drawing.Point(842, 215)
        Me.officeid.Name = "officeid"
        Me.officeid.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.officeid.Properties.Appearance.Options.UseFont = True
        Me.officeid.Properties.Appearance.Options.UseTextOptions = True
        Me.officeid.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.officeid.Properties.ReadOnly = True
        Me.officeid.Size = New System.Drawing.Size(77, 24)
        Me.officeid.TabIndex = 649
        Me.officeid.Visible = False
        '
        'CheckEdit1
        '
        Me.CheckEdit1.Location = New System.Drawing.Point(166, 75)
        Me.CheckEdit1.Name = "CheckEdit1"
        Me.CheckEdit1.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.CheckEdit1.Properties.Appearance.Options.UseFont = True
        Me.CheckEdit1.Properties.Caption = "View all office"
        Me.CheckEdit1.Size = New System.Drawing.Size(117, 21)
        Me.CheckEdit1.TabIndex = 650
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton1.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.SimpleButton1.Appearance.Options.UseFont = True
        Me.SimpleButton1.Location = New System.Drawing.Point(563, 21)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(207, 56)
        Me.SimpleButton1.TabIndex = 651
        Me.SimpleButton1.Text = "Generate Exel Report"
        '
        'frmBudgetQuarterly
        '
        Me.AcceptButton = Me.cmdSaveButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(991, 617)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.CheckEdit1)
        Me.Controls.Add(Me.officeid)
        Me.Controls.Add(Me.periodcode)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.txtOffice)
        Me.Controls.Add(Me.yearcode)
        Me.Controls.Add(Me.fundcode)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.txtFund)
        Me.Controls.Add(Me.cmdSaveButton)
        Me.Controls.Add(Me.Em)
        Me.MinimumSize = New System.Drawing.Size(993, 649)
        Me.Name = "frmBudgetQuarterly"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Quarterly Budget"
        CType(Me.Em, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gridmenustrip.ResumeLayout(False)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFund.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridFund, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fundcode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.yearcode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOffice.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridoffice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.periodcode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.officeid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdSaveButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Em As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents gridmenustrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmdEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdDelete As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents RefreshToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtFund As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents gridFund As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents fundcode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents yearcode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtOffice As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents gridoffice As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents periodcode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents officeid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CheckEdit1 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
End Class
