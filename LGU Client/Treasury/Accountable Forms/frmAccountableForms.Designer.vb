<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAccountableForms
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Timer1 = New System.Windows.Forms.Timer()
        Me.HiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PropertiesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelloToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MustaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BottomToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.TopToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.RightToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.LeftToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.ContentPanel = New System.Windows.Forms.ToolStripContentPanel()
        Me.cms_em = New System.Windows.Forms.ContextMenuStrip()
        Me.cmdView = New System.Windows.Forms.ToolStripMenuItem()
        Me.AssignAccountableToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewDetailTransactionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdCancel = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdLocalData = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip3 = New System.Windows.Forms.ToolStrip()
        Me.cmdNew = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdPrint = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdClose = New System.Windows.Forms.ToolStripButton()
        Me.MyPrintDocument = New System.Drawing.Printing.PrintDocument()
        Me.updates = New System.Windows.Forms.ToolStripLabel()
        Me.RepositoryItemPictureEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Em = New DevExpress.XtraGrid.GridControl()
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.CheckEdit1 = New DevExpress.XtraEditors.CheckEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtAccountable = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.gridAccountable = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ckCurrentlyInUsed = New DevExpress.XtraEditors.CheckEdit()
        Me.ckViewAllForms = New DevExpress.XtraEditors.CheckEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtForm = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.gridForm = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.cms_em.SuspendLayout()
        Me.ToolStrip3.SuspendLayout()
        CType(Me.RepositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAccountable.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridAccountable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ckCurrentlyInUsed.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ckViewAllForms.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtForm.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridForm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
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
        Me.cms_em.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdView, Me.AssignAccountableToolStripMenuItem, Me.ViewDetailTransactionToolStripMenuItem, Me.cmdCancel, Me.ToolStripSeparator4, Me.cmdLocalData})
        Me.cms_em.Name = "ContextMenuStrip1"
        Me.cms_em.Size = New System.Drawing.Size(196, 120)
        '
        'cmdView
        '
        Me.cmdView.Image = Global.LGUClient.My.Resources.Resources.notebook__pencil
        Me.cmdView.Name = "cmdView"
        Me.cmdView.Size = New System.Drawing.Size(195, 22)
        Me.cmdView.Text = "Edit Item"
        '
        'AssignAccountableToolStripMenuItem
        '
        Me.AssignAccountableToolStripMenuItem.Image = Global.LGUClient.My.Resources.Resources.notebook__arrow
        Me.AssignAccountableToolStripMenuItem.Name = "AssignAccountableToolStripMenuItem"
        Me.AssignAccountableToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.AssignAccountableToolStripMenuItem.Text = "Assign Accountable"
        '
        'ViewDetailTransactionToolStripMenuItem
        '
        Me.ViewDetailTransactionToolStripMenuItem.Image = Global.LGUClient.My.Resources.Resources._165
        Me.ViewDetailTransactionToolStripMenuItem.Name = "ViewDetailTransactionToolStripMenuItem"
        Me.ViewDetailTransactionToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.ViewDetailTransactionToolStripMenuItem.Text = "View Detail Transaction"
        '
        'cmdCancel
        '
        Me.cmdCancel.Image = Global.LGUClient.My.Resources.Resources.notebook__minus
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(195, 22)
        Me.cmdCancel.Text = "Delete Selected Item"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(192, 6)
        '
        'cmdLocalData
        '
        Me.cmdLocalData.Image = Global.LGUClient.My.Resources.Resources.arrow_continue_090
        Me.cmdLocalData.Name = "cmdLocalData"
        Me.cmdLocalData.Size = New System.Drawing.Size(195, 22)
        Me.cmdLocalData.Tag = "1"
        Me.cmdLocalData.Text = "Refresh Data"
        '
        'ToolStrip3
        '
        Me.ToolStrip3.AutoSize = False
        Me.ToolStrip3.BackgroundImage = Global.LGUClient.My.Resources.Resources.wide_blank2
        Me.ToolStrip3.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdNew, Me.ToolStripSeparator1, Me.cmdPrint, Me.ToolStripSeparator3, Me.cmdClose})
        Me.ToolStrip3.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip3.Name = "ToolStrip3"
        Me.ToolStrip3.Padding = New System.Windows.Forms.Padding(10, 2, 1, 2)
        Me.ToolStrip3.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip3.Size = New System.Drawing.Size(923, 31)
        Me.ToolStrip3.TabIndex = 317
        Me.ToolStrip3.Text = "ToolStrip3"
        '
        'cmdNew
        '
        Me.cmdNew.ForeColor = System.Drawing.Color.White
        Me.cmdNew.Image = Global.LGUClient.My.Resources.Resources.receipt__plus
        Me.cmdNew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdNew.Name = "cmdNew"
        Me.cmdNew.Size = New System.Drawing.Size(172, 24)
        Me.cmdNew.Text = "Addnew Accountable Form"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'cmdPrint
        '
        Me.cmdPrint.ForeColor = System.Drawing.Color.White
        Me.cmdPrint.Image = Global.LGUClient.My.Resources.Resources.Print_Normal
        Me.cmdPrint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(90, 24)
        Me.cmdPrint.Text = "Print Report"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 27)
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
        'RepositoryItemPictureEdit1
        '
        Me.RepositoryItemPictureEdit1.Name = "RepositoryItemPictureEdit1"
        '
        'GridView1
        '
        Me.GridView1.Appearance.GroupFooter.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.GridView1.Appearance.GroupFooter.Options.UseFont = True
        Me.GridView1.Appearance.GroupPanel.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.GridView1.Appearance.GroupPanel.Options.UseFont = True
        Me.GridView1.Appearance.GroupRow.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.GridView1.Appearance.GroupRow.Options.UseFont = True
        Me.GridView1.Appearance.HeaderPanel.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView1.Appearance.HeaderPanel.Options.UseFont = True
        Me.GridView1.Appearance.Row.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.GridView1.Appearance.Row.Options.UseFont = True
        Me.GridView1.Appearance.Row.Options.UseTextOptions = True
        Me.GridView1.Appearance.Row.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridView1.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.GridView1.Appearance.ViewCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridView1.GridControl = Me.Em
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AllowGroupExpandAnimation = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridView1.OptionsBehavior.AllowSortAnimation = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsImageLoad.AnimationType = DevExpress.Utils.ImageContentAnimationType.Expand
        Me.GridView1.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.AnimateAllContent
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.RowAutoHeight = True
        Me.GridView1.OptionsView.WaitAnimationOptions = DevExpress.XtraEditors.WaitAnimationOptions.Indicator
        '
        'Em
        '
        Me.Em.ContextMenuStrip = Me.cms_em
        Me.Em.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Em.Font = New System.Drawing.Font("Tahoma", 6.75!)
        Me.Em.Location = New System.Drawing.Point(0, 0)
        Me.Em.MainView = Me.GridView1
        Me.Em.Name = "Em"
        Me.Em.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemPictureEdit1})
        Me.Em.Size = New System.Drawing.Size(923, 569)
        Me.Em.TabIndex = 820
        Me.Em.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl1.Horizontal = False
        Me.SplitContainerControl1.Location = New System.Drawing.Point(0, 31)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.CheckEdit1)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.LabelControl1)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.txtAccountable)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.ckCurrentlyInUsed)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.ckViewAllForms)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.LabelControl2)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.txtForm)
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.Em)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(923, 671)
        Me.SplitContainerControl1.SplitterPosition = 92
        Me.SplitContainerControl1.TabIndex = 821
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'CheckEdit1
        '
        Me.CheckEdit1.Location = New System.Drawing.Point(388, 41)
        Me.CheckEdit1.Name = "CheckEdit1"
        Me.CheckEdit1.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckEdit1.Properties.Appearance.Options.UseFont = True
        Me.CheckEdit1.Properties.Caption = "View All Accountable"
        Me.CheckEdit1.Size = New System.Drawing.Size(134, 20)
        Me.CheckEdit1.TabIndex = 660
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(17, 42)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(109, 17)
        Me.LabelControl1.TabIndex = 659
        Me.LabelControl1.Text = "Select Accountable"
        '
        'txtAccountable
        '
        Me.txtAccountable.EditValue = ""
        Me.txtAccountable.Location = New System.Drawing.Point(131, 39)
        Me.txtAccountable.Name = "txtAccountable"
        Me.txtAccountable.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtAccountable.Properties.Appearance.Options.UseFont = True
        Me.txtAccountable.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtAccountable.Properties.DisplayMember = "AccountablePerson"
        Me.txtAccountable.Properties.NullText = ""
        Me.txtAccountable.Properties.PopupView = Me.gridAccountable
        Me.txtAccountable.Properties.ValueMember = "accountable"
        Me.txtAccountable.Size = New System.Drawing.Size(251, 24)
        Me.txtAccountable.TabIndex = 658
        '
        'gridAccountable
        '
        Me.gridAccountable.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gridAccountable.Name = "gridAccountable"
        Me.gridAccountable.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridAccountable.OptionsView.ShowGroupPanel = False
        '
        'ckCurrentlyInUsed
        '
        Me.ckCurrentlyInUsed.EditValue = True
        Me.ckCurrentlyInUsed.Location = New System.Drawing.Point(131, 67)
        Me.ckCurrentlyInUsed.Name = "ckCurrentlyInUsed"
        Me.ckCurrentlyInUsed.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckCurrentlyInUsed.Properties.Appearance.Options.UseFont = True
        Me.ckCurrentlyInUsed.Properties.Caption = "View currently in-used only"
        Me.ckCurrentlyInUsed.Size = New System.Drawing.Size(189, 20)
        Me.ckCurrentlyInUsed.TabIndex = 657
        '
        'ckViewAllForms
        '
        Me.ckViewAllForms.Location = New System.Drawing.Point(388, 15)
        Me.ckViewAllForms.Name = "ckViewAllForms"
        Me.ckViewAllForms.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckViewAllForms.Properties.Appearance.Options.UseFont = True
        Me.ckViewAllForms.Properties.Caption = "View All Forms"
        Me.ckViewAllForms.Size = New System.Drawing.Size(126, 20)
        Me.ckViewAllForms.TabIndex = 656
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(58, 15)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(68, 17)
        Me.LabelControl2.TabIndex = 655
        Me.LabelControl2.Text = "Select Form"
        '
        'txtForm
        '
        Me.txtForm.EditValue = ""
        Me.txtForm.Location = New System.Drawing.Point(131, 12)
        Me.txtForm.Name = "txtForm"
        Me.txtForm.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtForm.Properties.Appearance.Options.UseFont = True
        Me.txtForm.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtForm.Properties.DisplayMember = "Description"
        Me.txtForm.Properties.NullText = ""
        Me.txtForm.Properties.PopupView = Me.gridForm
        Me.txtForm.Properties.ValueMember = "code"
        Me.txtForm.Size = New System.Drawing.Size(251, 24)
        Me.txtForm.TabIndex = 654
        '
        'gridForm
        '
        Me.gridForm.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gridForm.Name = "gridForm"
        Me.gridForm.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridForm.OptionsView.ShowGroupPanel = False
        '
        'frmAccountableForms
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(923, 702)
        Me.Controls.Add(Me.SplitContainerControl1)
        Me.Controls.Add(Me.ToolStrip3)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MinimumSize = New System.Drawing.Size(897, 679)
        Me.Name = "frmAccountableForms"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Accountable Forms"
        Me.cms_em.ResumeLayout(False)
        Me.ToolStrip3.ResumeLayout(False)
        Me.ToolStrip3.PerformLayout()
        CType(Me.RepositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAccountable.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridAccountable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ckCurrentlyInUsed.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ckViewAllForms.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtForm.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridForm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
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
    Friend WithEvents ToolStrip3 As System.Windows.Forms.ToolStrip
    Friend WithEvents updates As System.Windows.Forms.ToolStripLabel
    Friend WithEvents MyPrintDocument As System.Drawing.Printing.PrintDocument
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdClose As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdView As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdPrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdCancel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdNew As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents RepositoryItemPictureEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Em As DevExpress.XtraGrid.GridControl
    Friend WithEvents AssignAccountableToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewDetailTransactionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents ckViewAllForms As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtForm As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents gridForm As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ckCurrentlyInUsed As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents CheckEdit1 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtAccountable As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents gridAccountable As DevExpress.XtraGrid.Views.Grid.GridView
End Class
