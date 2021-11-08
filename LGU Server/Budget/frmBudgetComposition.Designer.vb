<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBudgetComposition
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
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton()
        Me.Em = New DevExpress.XtraGrid.GridControl()
        Me.gridmenustrip = New System.Windows.Forms.ContextMenuStrip()
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
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtExpenseClass = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.gridExpenseClass = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.officeid = New DevExpress.XtraEditors.TextEdit()
        Me.expensecode = New DevExpress.XtraEditors.TextEdit()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdImport = New DevExpress.XtraEditors.SimpleButton()
        Me.Bm = New DevExpress.XtraGrid.GridControl()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RepositoryItemCheckEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
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
        CType(Me.txtExpenseClass.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridExpenseClass, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.officeid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.expensecode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdSave
        '
        Me.cmdSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.cmdSave.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdSave.Appearance.BackColor2 = System.Drawing.Color.Khaki
        Me.cmdSave.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSave.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.cmdSave.Appearance.Options.UseBackColor = True
        Me.cmdSave.Appearance.Options.UseFont = True
        Me.cmdSave.Location = New System.Drawing.Point(386, 562)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(168, 38)
        Me.cmdSave.TabIndex = 6
        Me.cmdSave.Text = "Save"
        '
        'Em
        '
        Me.Em.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Em.ContextMenuStrip = Me.gridmenustrip
        Me.Em.Location = New System.Drawing.Point(12, 102)
        Me.Em.MainView = Me.GridView1
        Me.Em.MinimumSize = New System.Drawing.Size(574, 454)
        Me.Em.Name = "Em"
        Me.Em.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1})
        Me.Em.Size = New System.Drawing.Size(578, 454)
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
        Me.txtFund.Location = New System.Drawing.Point(164, 12)
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
        Me.LabelControl2.Location = New System.Drawing.Point(88, 15)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(66, 17)
        Me.LabelControl2.TabIndex = 634
        Me.LabelControl2.Text = "Select Fund"
        '
        'fundcode
        '
        Me.fundcode.Location = New System.Drawing.Point(509, 77)
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
        Me.yearcode.Location = New System.Drawing.Point(509, 104)
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
        Me.LabelControl3.Location = New System.Drawing.Point(82, 42)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(72, 17)
        Me.LabelControl3.TabIndex = 645
        Me.LabelControl3.Text = "Select Office"
        '
        'txtOffice
        '
        Me.txtOffice.EditValue = "sss"
        Me.txtOffice.Location = New System.Drawing.Point(164, 39)
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
        Me.periodcode.Location = New System.Drawing.Point(509, 47)
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
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(86, 69)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(68, 17)
        Me.LabelControl1.TabIndex = 648
        Me.LabelControl1.Text = "Select Class"
        '
        'txtExpenseClass
        '
        Me.txtExpenseClass.EditValue = "sss"
        Me.txtExpenseClass.Location = New System.Drawing.Point(164, 66)
        Me.txtExpenseClass.Name = "txtExpenseClass"
        Me.txtExpenseClass.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtExpenseClass.Properties.Appearance.Options.UseFont = True
        Me.txtExpenseClass.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtExpenseClass.Properties.DisplayMember = "Select"
        Me.txtExpenseClass.Properties.NullText = ""
        Me.txtExpenseClass.Properties.PopupView = Me.gridExpenseClass
        Me.txtExpenseClass.Properties.ValueMember = "code"
        Me.txtExpenseClass.Size = New System.Drawing.Size(275, 24)
        Me.txtExpenseClass.TabIndex = 647
        '
        'gridExpenseClass
        '
        Me.gridExpenseClass.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gridExpenseClass.Name = "gridExpenseClass"
        Me.gridExpenseClass.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridExpenseClass.OptionsView.ShowGroupPanel = False
        '
        'officeid
        '
        Me.officeid.Location = New System.Drawing.Point(509, 129)
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
        'expensecode
        '
        Me.expensecode.Location = New System.Drawing.Point(509, 159)
        Me.expensecode.Name = "expensecode"
        Me.expensecode.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.expensecode.Properties.Appearance.Options.UseFont = True
        Me.expensecode.Properties.Appearance.Options.UseTextOptions = True
        Me.expensecode.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.expensecode.Properties.ReadOnly = True
        Me.expensecode.Size = New System.Drawing.Size(77, 24)
        Me.expensecode.TabIndex = 650
        Me.expensecode.Visible = False
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.SimpleButton1.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.SimpleButton1.Appearance.BackColor2 = System.Drawing.Color.Khaki
        Me.SimpleButton1.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton1.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.SimpleButton1.Appearance.Options.UseBackColor = True
        Me.SimpleButton1.Appearance.Options.UseFont = True
        Me.SimpleButton1.Location = New System.Drawing.Point(38, 562)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(168, 38)
        Me.SimpleButton1.TabIndex = 651
        Me.SimpleButton1.Text = "Export Excel"
        '
        'cmdImport
        '
        Me.cmdImport.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.cmdImport.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdImport.Appearance.BackColor2 = System.Drawing.Color.Khaki
        Me.cmdImport.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdImport.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.cmdImport.Appearance.Options.UseBackColor = True
        Me.cmdImport.Appearance.Options.UseFont = True
        Me.cmdImport.Location = New System.Drawing.Point(212, 562)
        Me.cmdImport.Name = "cmdImport"
        Me.cmdImport.Size = New System.Drawing.Size(168, 38)
        Me.cmdImport.TabIndex = 652
        Me.cmdImport.Text = "Import Excel"
        '
        'Bm
        '
        Me.Bm.ContextMenuStrip = Me.gridmenustrip
        Me.Bm.Location = New System.Drawing.Point(52, 146)
        Me.Bm.MainView = Me.GridView2
        Me.Bm.Name = "Bm"
        Me.Bm.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit2})
        Me.Bm.Size = New System.Drawing.Size(403, 265)
        Me.Bm.TabIndex = 653
        Me.Bm.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        Me.Bm.Visible = False
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me.Bm
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsSelection.MultiSelect = True
        Me.GridView2.OptionsSelection.UseIndicatorForSelection = False
        Me.GridView2.OptionsView.ColumnAutoWidth = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'RepositoryItemCheckEdit2
        '
        Me.RepositoryItemCheckEdit2.Name = "RepositoryItemCheckEdit2"
        Me.RepositoryItemCheckEdit2.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        '
        'frmBudgetComposition
        '
        Me.AcceptButton = Me.cmdSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(598, 607)
        Me.Controls.Add(Me.Bm)
        Me.Controls.Add(Me.cmdImport)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.expensecode)
        Me.Controls.Add(Me.officeid)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.txtExpenseClass)
        Me.Controls.Add(Me.periodcode)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.txtOffice)
        Me.Controls.Add(Me.yearcode)
        Me.Controls.Add(Me.fundcode)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.txtFund)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.Em)
        Me.MinimumSize = New System.Drawing.Size(600, 639)
        Me.Name = "frmBudgetComposition"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Budget Composition"
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
        CType(Me.txtExpenseClass.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridExpenseClass, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.officeid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.expensecode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
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
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtExpenseClass As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents gridExpenseClass As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents officeid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents expensecode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdImport As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Bm As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemCheckEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
End Class
