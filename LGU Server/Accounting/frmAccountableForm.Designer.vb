<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAccountableForm
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
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.mode = New DevExpress.XtraEditors.TextEdit()
        Me.cmdSaveButton = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.code = New DevExpress.XtraEditors.TextEdit()
        Me.txtDescription = New DevExpress.XtraEditors.TextEdit()
        Me.Em = New DevExpress.XtraGrid.GridControl()
        Me.gridmenustrip = New System.Windows.Forms.ContextMenuStrip()
        Me.cmdEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdDelete = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.txtPaperSize = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtMarginTop = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtMarginLeft = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.txtFontSize = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.txtFontName = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.ckEnablePrintSettings = New DevExpress.XtraEditors.CheckEdit()
        Me.ckLandScape = New DevExpress.XtraEditors.CheckEdit()
        CType(Me.mode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.code.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescription.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gridmenustrip.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPaperSize.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMarginTop.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMarginLeft.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFontSize.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFontName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ckEnablePrintSettings.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ckLandScape.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(28, 45)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(66, 17)
        Me.LabelControl2.TabIndex = 507
        Me.LabelControl2.Text = "Description"
        '
        'mode
        '
        Me.mode.Location = New System.Drawing.Point(595, 336)
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
        'cmdSaveButton
        '
        Me.cmdSaveButton.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdSaveButton.Appearance.BackColor2 = System.Drawing.Color.Khaki
        Me.cmdSaveButton.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSaveButton.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.cmdSaveButton.Appearance.Options.UseBackColor = True
        Me.cmdSaveButton.Appearance.Options.UseFont = True
        Me.cmdSaveButton.Location = New System.Drawing.Point(102, 213)
        Me.cmdSaveButton.Name = "cmdSaveButton"
        Me.cmdSaveButton.Size = New System.Drawing.Size(149, 36)
        Me.cmdSaveButton.TabIndex = 8
        Me.cmdSaveButton.Text = "Save"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Location = New System.Drawing.Point(63, 17)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(31, 17)
        Me.LabelControl4.TabIndex = 628
        Me.LabelControl4.Text = "Code"
        '
        'code
        '
        Me.code.EditValue = ""
        Me.code.Location = New System.Drawing.Point(102, 14)
        Me.code.Name = "code"
        Me.code.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.code.Properties.Appearance.Options.UseFont = True
        Me.code.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.code.Size = New System.Drawing.Size(151, 24)
        Me.code.TabIndex = 0
        '
        'txtDescription
        '
        Me.txtDescription.EditValue = ""
        Me.txtDescription.Location = New System.Drawing.Point(102, 42)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescription.Properties.Appearance.Options.UseFont = True
        Me.txtDescription.Size = New System.Drawing.Size(263, 24)
        Me.txtDescription.TabIndex = 1
        '
        'Em
        '
        Me.Em.ContextMenuStrip = Me.gridmenustrip
        Me.Em.Location = New System.Drawing.Point(12, 269)
        Me.Em.MainView = Me.GridView1
        Me.Em.Name = "Em"
        Me.Em.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1})
        Me.Em.Size = New System.Drawing.Size(690, 244)
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
        'txtPaperSize
        '
        Me.txtPaperSize.EditValue = "50"
        Me.txtPaperSize.Enabled = False
        Me.txtPaperSize.Location = New System.Drawing.Point(102, 99)
        Me.txtPaperSize.Name = "txtPaperSize"
        Me.txtPaperSize.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPaperSize.Properties.Appearance.Options.UseFont = True
        Me.txtPaperSize.Properties.Appearance.Options.UseTextOptions = True
        Me.txtPaperSize.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtPaperSize.Size = New System.Drawing.Size(68, 24)
        Me.txtPaperSize.TabIndex = 2
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(33, 102)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(61, 17)
        Me.LabelControl1.TabIndex = 633
        Me.LabelControl1.Text = "Paper Size"
        '
        'txtMarginTop
        '
        Me.txtMarginTop.EditValue = "2"
        Me.txtMarginTop.Enabled = False
        Me.txtMarginTop.Location = New System.Drawing.Point(256, 99)
        Me.txtMarginTop.Name = "txtMarginTop"
        Me.txtMarginTop.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMarginTop.Properties.Appearance.Options.UseFont = True
        Me.txtMarginTop.Properties.Appearance.Options.UseTextOptions = True
        Me.txtMarginTop.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtMarginTop.Size = New System.Drawing.Size(68, 24)
        Me.txtMarginTop.TabIndex = 4
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(180, 102)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(69, 17)
        Me.LabelControl3.TabIndex = 635
        Me.LabelControl3.Text = "Margin Top"
        '
        'txtMarginLeft
        '
        Me.txtMarginLeft.EditValue = "2"
        Me.txtMarginLeft.Enabled = False
        Me.txtMarginLeft.Location = New System.Drawing.Point(256, 129)
        Me.txtMarginLeft.Name = "txtMarginLeft"
        Me.txtMarginLeft.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMarginLeft.Properties.Appearance.Options.UseFont = True
        Me.txtMarginLeft.Properties.Appearance.Options.UseTextOptions = True
        Me.txtMarginLeft.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtMarginLeft.Size = New System.Drawing.Size(68, 24)
        Me.txtMarginLeft.TabIndex = 5
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.Location = New System.Drawing.Point(182, 132)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(67, 17)
        Me.LabelControl5.TabIndex = 637
        Me.LabelControl5.Text = "Margin Left"
        '
        'txtFontSize
        '
        Me.txtFontSize.EditValue = "9"
        Me.txtFontSize.Enabled = False
        Me.txtFontSize.Location = New System.Drawing.Point(102, 129)
        Me.txtFontSize.Name = "txtFontSize"
        Me.txtFontSize.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFontSize.Properties.Appearance.Options.UseFont = True
        Me.txtFontSize.Properties.Appearance.Options.UseTextOptions = True
        Me.txtFontSize.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtFontSize.Size = New System.Drawing.Size(68, 24)
        Me.txtFontSize.TabIndex = 3
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Appearance.Options.UseFont = True
        Me.LabelControl6.Location = New System.Drawing.Point(42, 132)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(52, 17)
        Me.LabelControl6.TabIndex = 639
        Me.LabelControl6.Text = "Font Size"
        '
        'txtFontName
        '
        Me.txtFontName.Enabled = False
        Me.txtFontName.Location = New System.Drawing.Point(102, 159)
        Me.txtFontName.Name = "txtFontName"
        Me.txtFontName.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtFontName.Properties.Appearance.Options.UseFont = True
        Me.txtFontName.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtFontName.Properties.AppearanceDropDown.Options.UseFont = True
        Me.txtFontName.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtFontName.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.txtFontName.Size = New System.Drawing.Size(263, 24)
        Me.txtFontName.TabIndex = 6
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl7.Appearance.Options.UseFont = True
        Me.LabelControl7.Location = New System.Drawing.Point(30, 158)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(64, 17)
        Me.LabelControl7.TabIndex = 642
        Me.LabelControl7.Text = "Font Name"
        '
        'ckEnablePrintSettings
        '
        Me.ckEnablePrintSettings.Location = New System.Drawing.Point(102, 72)
        Me.ckEnablePrintSettings.Name = "ckEnablePrintSettings"
        Me.ckEnablePrintSettings.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.ckEnablePrintSettings.Properties.Appearance.Options.UseFont = True
        Me.ckEnablePrintSettings.Properties.Caption = "Enable default printing settings"
        Me.ckEnablePrintSettings.Size = New System.Drawing.Size(210, 21)
        Me.ckEnablePrintSettings.TabIndex = 643
        '
        'ckLandScape
        '
        Me.ckLandScape.Enabled = False
        Me.ckLandScape.Location = New System.Drawing.Point(102, 186)
        Me.ckLandScape.Name = "ckLandScape"
        Me.ckLandScape.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.ckLandScape.Properties.Appearance.Options.UseFont = True
        Me.ckLandScape.Properties.Caption = "Print Landscape"
        Me.ckLandScape.Size = New System.Drawing.Size(210, 21)
        Me.ckLandScape.TabIndex = 644
        '
        'frmAccountableForm
        '
        Me.AcceptButton = Me.cmdSaveButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(712, 523)
        Me.Controls.Add(Me.ckLandScape)
        Me.Controls.Add(Me.ckEnablePrintSettings)
        Me.Controls.Add(Me.LabelControl7)
        Me.Controls.Add(Me.txtFontName)
        Me.Controls.Add(Me.txtFontSize)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.txtMarginLeft)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.txtMarginTop)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.txtPaperSize)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.Em)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.code)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.cmdSaveButton)
        Me.Controls.Add(Me.mode)
        Me.Controls.Add(Me.LabelControl2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmAccountableForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Accountable Form"
        CType(Me.mode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.code.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescription.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gridmenustrip.ResumeLayout(False)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPaperSize.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMarginTop.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMarginLeft.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFontSize.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFontName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ckEnablePrintSettings.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ckLandScape.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents mode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmdSaveButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents code As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDescription As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Em As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents gridmenustrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmdEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdDelete As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents RefreshToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtPaperSize As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtMarginTop As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtMarginLeft As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtFontSize As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtFontName As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ckEnablePrintSettings As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents ckLandScape As DevExpress.XtraEditors.CheckEdit
End Class
