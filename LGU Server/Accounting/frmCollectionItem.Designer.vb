<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCollectionItem
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
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton()
        Me.txtDescription = New DevExpress.XtraEditors.TextEdit()
        Me.Em = New DevExpress.XtraGrid.GridControl()
        Me.gridmenustrip = New System.Windows.Forms.ContextMenuStrip()
        Me.cmdEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdDelete = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtAccountTitle = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.gridFund = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.code = New DevExpress.XtraEditors.TextEdit()
        Me.mode = New DevExpress.XtraEditors.TextEdit()
        Me.txtAmount = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.txtDescription.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gridmenustrip.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAccountTitle.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridFund, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.code.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAmount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(49, 13)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(96, 17)
        Me.LabelControl1.TabIndex = 510
        Me.LabelControl1.Text = "Collection Name"
        '
        'cmdSave
        '
        Me.cmdSave.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdSave.Appearance.BackColor2 = System.Drawing.Color.Khaki
        Me.cmdSave.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSave.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.cmdSave.Appearance.Options.UseBackColor = True
        Me.cmdSave.Appearance.Options.UseFont = True
        Me.cmdSave.Location = New System.Drawing.Point(151, 98)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(135, 31)
        Me.cmdSave.TabIndex = 6
        Me.cmdSave.Text = "Save"
        '
        'txtDescription
        '
        Me.txtDescription.EditValue = ""
        Me.txtDescription.Location = New System.Drawing.Point(151, 10)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescription.Properties.Appearance.Options.UseFont = True
        Me.txtDescription.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtDescription.Size = New System.Drawing.Size(394, 26)
        Me.txtDescription.TabIndex = 0
        '
        'Em
        '
        Me.Em.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Em.ContextMenuStrip = Me.gridmenustrip
        Me.Em.Location = New System.Drawing.Point(12, 137)
        Me.Em.MainView = Me.GridView1
        Me.Em.Name = "Em"
        Me.Em.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1})
        Me.Em.Size = New System.Drawing.Size(648, 373)
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
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(71, 42)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(74, 17)
        Me.LabelControl2.TabIndex = 636
        Me.LabelControl2.Text = "Account Title"
        '
        'txtAccountTitle
        '
        Me.txtAccountTitle.EditValue = "sss"
        Me.txtAccountTitle.Location = New System.Drawing.Point(151, 39)
        Me.txtAccountTitle.Name = "txtAccountTitle"
        Me.txtAccountTitle.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtAccountTitle.Properties.Appearance.Options.UseFont = True
        Me.txtAccountTitle.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtAccountTitle.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtAccountTitle.Properties.DisplayMember = "Account Title"
        Me.txtAccountTitle.Properties.NullText = ""
        Me.txtAccountTitle.Properties.PopupView = Me.gridFund
        Me.txtAccountTitle.Properties.ValueMember = "itemcode"
        Me.txtAccountTitle.Size = New System.Drawing.Size(275, 26)
        Me.txtAccountTitle.TabIndex = 1
        '
        'gridFund
        '
        Me.gridFund.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gridFund.Name = "gridFund"
        Me.gridFund.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridFund.OptionsView.ShowGroupPanel = False
        '
        'code
        '
        Me.code.Location = New System.Drawing.Point(608, 43)
        Me.code.Name = "code"
        Me.code.Size = New System.Drawing.Size(45, 20)
        Me.code.TabIndex = 637
        Me.code.Visible = False
        '
        'mode
        '
        Me.mode.Location = New System.Drawing.Point(608, 69)
        Me.mode.Name = "mode"
        Me.mode.Size = New System.Drawing.Size(45, 20)
        Me.mode.TabIndex = 638
        Me.mode.Visible = False
        '
        'txtAmount
        '
        Me.txtAmount.EditValue = "0"
        Me.txtAmount.Location = New System.Drawing.Point(151, 68)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtAmount.Properties.Appearance.Options.UseFont = True
        Me.txtAmount.Properties.Appearance.Options.UseTextOptions = True
        Me.txtAmount.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtAmount.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtAmount.Properties.Mask.EditMask = "n"
        Me.txtAmount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtAmount.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtAmount.Properties.NullText = "0"
        Me.txtAmount.Size = New System.Drawing.Size(135, 26)
        Me.txtAmount.TabIndex = 639
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(55, 72)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(90, 17)
        Me.LabelControl3.TabIndex = 640
        Me.LabelControl3.Text = "Default Amount"
        '
        'frmCollectionItem
        '
        Me.AcceptButton = Me.cmdSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(668, 519)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.mode)
        Me.Controls.Add(Me.code)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.txtAccountTitle)
        Me.Controls.Add(Me.Em)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.cmdSave)
        Me.Name = "frmCollectionItem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Collection Transaction"
        CType(Me.txtDescription.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gridmenustrip.ResumeLayout(False)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAccountTitle.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridFund, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.code.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAmount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtDescription As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Em As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents gridmenustrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmdEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdDelete As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents RefreshToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtAccountTitle As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents gridFund As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents code As DevExpress.XtraEditors.TextEdit
    Friend WithEvents mode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtAmount As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
End Class
