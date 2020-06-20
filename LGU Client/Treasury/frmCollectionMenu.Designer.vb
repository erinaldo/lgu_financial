<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCollectionMenu
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
        Me.txtFundcode = New System.Windows.Forms.ComboBox()
        Me.TextEdit2 = New DevExpress.XtraEditors.TextEdit()
        Me.periodcode = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit()
        Me.Em = New DevExpress.XtraGrid.GridControl()
        Me.cms_em = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmdSetActiveForm = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdReturnForm = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdLocalData = New System.Windows.Forms.ToolStripMenuItem()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RepositoryItemPictureEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.mode = New DevExpress.XtraEditors.TextEdit()
        Me.fundcode = New DevExpress.XtraEditors.TextEdit()
        Me.yeartrn = New DevExpress.XtraEditors.TextEdit()
        Me.cmdStartCollection = New DevExpress.XtraEditors.SimpleButton()
        Me.txtCollectionDate = New DevExpress.XtraEditors.DateEdit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.periodcode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cms_em.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.mode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fundcode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.yeartrn.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCollectionDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCollectionDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtFundcode
        '
        Me.txtFundcode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtFundcode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txtFundcode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtFundcode.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtFundcode.FormattingEnabled = True
        Me.txtFundcode.Location = New System.Drawing.Point(128, 303)
        Me.txtFundcode.Name = "txtFundcode"
        Me.txtFundcode.Size = New System.Drawing.Size(266, 25)
        Me.txtFundcode.TabIndex = 378
        '
        'TextEdit2
        '
        Me.TextEdit2.EditValue = "Select Fund"
        Me.TextEdit2.EnterMoveNextControl = True
        Me.TextEdit2.Location = New System.Drawing.Point(19, 303)
        Me.TextEdit2.Name = "TextEdit2"
        Me.TextEdit2.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.TextEdit2.Properties.Appearance.Options.UseFont = True
        Me.TextEdit2.Properties.Appearance.Options.UseTextOptions = True
        Me.TextEdit2.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.TextEdit2.Properties.MaxLength = 50
        Me.TextEdit2.Properties.ReadOnly = True
        Me.TextEdit2.Size = New System.Drawing.Size(103, 24)
        Me.TextEdit2.TabIndex = 673
        '
        'periodcode
        '
        Me.periodcode.EditValue = ""
        Me.periodcode.EnterMoveNextControl = True
        Me.periodcode.Location = New System.Drawing.Point(202, 245)
        Me.periodcode.Name = "periodcode"
        Me.periodcode.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.periodcode.Properties.Appearance.Options.UseFont = True
        Me.periodcode.Properties.Appearance.Options.UseTextOptions = True
        Me.periodcode.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.periodcode.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.periodcode.Properties.MaxLength = 50
        Me.periodcode.Properties.ReadOnly = True
        Me.periodcode.Size = New System.Drawing.Size(67, 24)
        Me.periodcode.TabIndex = 672
        Me.periodcode.Visible = False
        '
        'TextEdit1
        '
        Me.TextEdit1.EditValue = "Posting Date"
        Me.TextEdit1.EnterMoveNextControl = True
        Me.TextEdit1.Location = New System.Drawing.Point(19, 332)
        Me.TextEdit1.Name = "TextEdit1"
        Me.TextEdit1.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.TextEdit1.Properties.Appearance.Options.UseFont = True
        Me.TextEdit1.Properties.Appearance.Options.UseTextOptions = True
        Me.TextEdit1.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.TextEdit1.Properties.MaxLength = 50
        Me.TextEdit1.Properties.ReadOnly = True
        Me.TextEdit1.Size = New System.Drawing.Size(103, 24)
        Me.TextEdit1.TabIndex = 674
        '
        'Em
        '
        Me.Em.ContextMenuStrip = Me.cms_em
        Me.Em.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Em.Font = New System.Drawing.Font("Tahoma", 6.75!)
        Me.Em.Location = New System.Drawing.Point(3, 21)
        Me.Em.MainView = Me.GridView1
        Me.Em.Name = "Em"
        Me.Em.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemPictureEdit1})
        Me.Em.Size = New System.Drawing.Size(611, 261)
        Me.Em.TabIndex = 821
        Me.Em.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'cms_em
        '
        Me.cms_em.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdSetActiveForm, Me.cmdReturnForm, Me.ToolStripSeparator4, Me.cmdLocalData})
        Me.cms_em.Name = "ContextMenuStrip1"
        Me.cms_em.Size = New System.Drawing.Size(194, 76)
        '
        'cmdSetActiveForm
        '
        Me.cmdSetActiveForm.Image = Global.LGUClient.My.Resources.Resources.notebook__arrow
        Me.cmdSetActiveForm.Name = "cmdSetActiveForm"
        Me.cmdSetActiveForm.Size = New System.Drawing.Size(193, 22)
        Me.cmdSetActiveForm.Text = "Set as in-used form"
        '
        'cmdReturnForm
        '
        Me.cmdReturnForm.Image = Global.LGUClient.My.Resources.Resources.notebook__backarrow
        Me.cmdReturnForm.Name = "cmdReturnForm"
        Me.cmdReturnForm.Size = New System.Drawing.Size(193, 22)
        Me.cmdReturnForm.Text = "Return form collection"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(190, 6)
        '
        'cmdLocalData
        '
        Me.cmdLocalData.Image = Global.LGUClient.My.Resources.Resources.arrow_continue_090
        Me.cmdLocalData.Name = "cmdLocalData"
        Me.cmdLocalData.Size = New System.Drawing.Size(193, 22)
        Me.cmdLocalData.Tag = "1"
        Me.cmdLocalData.Text = "Refresh Data"
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
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.OptionsView.WaitAnimationOptions = DevExpress.XtraEditors.WaitAnimationOptions.Indicator
        '
        'RepositoryItemPictureEdit1
        '
        Me.RepositoryItemPictureEdit1.Name = "RepositoryItemPictureEdit1"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.mode)
        Me.GroupBox1.Controls.Add(Me.fundcode)
        Me.GroupBox1.Controls.Add(Me.yeartrn)
        Me.GroupBox1.Controls.Add(Me.periodcode)
        Me.GroupBox1.Controls.Add(Me.Em)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(617, 285)
        Me.GroupBox1.TabIndex = 822
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Activate one of your accountable forms to start posting (right click then set in-" & _
    "used form)"
        '
        'mode
        '
        Me.mode.EditValue = ""
        Me.mode.EnterMoveNextControl = True
        Me.mode.Location = New System.Drawing.Point(141, 245)
        Me.mode.Name = "mode"
        Me.mode.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.mode.Properties.Appearance.Options.UseFont = True
        Me.mode.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.mode.Properties.MaxLength = 50
        Me.mode.Properties.ReadOnly = True
        Me.mode.Size = New System.Drawing.Size(55, 24)
        Me.mode.TabIndex = 824
        Me.mode.Visible = False
        '
        'fundcode
        '
        Me.fundcode.EditValue = ""
        Me.fundcode.EnterMoveNextControl = True
        Me.fundcode.Location = New System.Drawing.Point(80, 245)
        Me.fundcode.Name = "fundcode"
        Me.fundcode.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.fundcode.Properties.Appearance.Options.UseFont = True
        Me.fundcode.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.fundcode.Properties.MaxLength = 50
        Me.fundcode.Properties.ReadOnly = True
        Me.fundcode.Size = New System.Drawing.Size(55, 24)
        Me.fundcode.TabIndex = 823
        Me.fundcode.Visible = False
        '
        'yeartrn
        '
        Me.yeartrn.EditValue = ""
        Me.yeartrn.EnterMoveNextControl = True
        Me.yeartrn.Location = New System.Drawing.Point(19, 245)
        Me.yeartrn.Name = "yeartrn"
        Me.yeartrn.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.yeartrn.Properties.Appearance.Options.UseFont = True
        Me.yeartrn.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.yeartrn.Properties.MaxLength = 50
        Me.yeartrn.Properties.ReadOnly = True
        Me.yeartrn.Size = New System.Drawing.Size(55, 24)
        Me.yeartrn.TabIndex = 822
        Me.yeartrn.Visible = False
        '
        'cmdStartCollection
        '
        Me.cmdStartCollection.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdStartCollection.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdStartCollection.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.cmdStartCollection.Appearance.Options.UseBackColor = True
        Me.cmdStartCollection.Appearance.Options.UseFont = True
        Me.cmdStartCollection.ImageOptions.Image = Global.LGUClient.My.Resources.Resources.AssignTo_32x32__2_1
        Me.cmdStartCollection.Location = New System.Drawing.Point(400, 303)
        Me.cmdStartCollection.Name = "cmdStartCollection"
        Me.cmdStartCollection.Size = New System.Drawing.Size(229, 53)
        Me.cmdStartCollection.TabIndex = 833
        Me.cmdStartCollection.Text = "Start Collection Posting"
        '
        'txtCollectionDate
        '
        Me.txtCollectionDate.EditValue = New Date(2019, 6, 10, 16, 23, 25, 399)
        Me.txtCollectionDate.EnterMoveNextControl = True
        Me.txtCollectionDate.Location = New System.Drawing.Point(128, 331)
        Me.txtCollectionDate.Name = "txtCollectionDate"
        Me.txtCollectionDate.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.txtCollectionDate.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtCollectionDate.Properties.Appearance.Options.UseFont = True
        Me.txtCollectionDate.Properties.AutoHeight = False
        Me.txtCollectionDate.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtCollectionDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtCollectionDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtCollectionDate.Properties.Mask.EditMask = "MMMM dd, yyyy"
        Me.txtCollectionDate.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtCollectionDate.Size = New System.Drawing.Size(266, 25)
        Me.txtCollectionDate.TabIndex = 834
        '
        'frmCollectionMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(640, 366)
        Me.Controls.Add(Me.txtCollectionDate)
        Me.Controls.Add(Me.cmdStartCollection)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TextEdit1)
        Me.Controls.Add(Me.TextEdit2)
        Me.Controls.Add(Me.txtFundcode)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.MaximizeBox = False
        Me.Name = "frmCollectionMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Collection Menu Settings"
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.periodcode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cms_em.ResumeLayout(False)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.mode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fundcode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.yeartrn.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCollectionDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCollectionDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtFundcode As System.Windows.Forms.ComboBox
    Friend WithEvents TextEdit2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents periodcode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Em As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemPictureEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdStartCollection As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cms_em As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmdSetActiveForm As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdReturnForm As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdLocalData As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents fundcode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents yeartrn As DevExpress.XtraEditors.TextEdit
    Friend WithEvents mode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCollectionDate As DevExpress.XtraEditors.DateEdit
End Class
