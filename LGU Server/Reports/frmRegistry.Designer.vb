<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegistry
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
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.BarLargeButtonItem2 = New DevExpress.XtraBars.BarLargeButtonItem()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl1 = New DevExpress.XtraBars.BarDockControl()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.BarLargeButtonItem1 = New DevExpress.XtraBars.BarLargeButtonItem()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txtMonth = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.txtClass = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.gridclass = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.txtOffice = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.gridoffice = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.cmdSaveButton = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtFund = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.gridFund = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Em = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.txtMonth.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtClass.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridclass, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOffice.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridoffice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFund.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridFund, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.BarDockControl1)
        Me.BarManager1.DockWindowTabFont = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarLargeButtonItem2, Me.BarButtonItem1, Me.BarButtonItem2, Me.BarButtonItem3})
        Me.BarManager1.MainMenu = Me.Bar1
        Me.BarManager1.MaxItemId = 7
        Me.BarManager1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1})
        '
        'Bar1
        '
        Me.Bar1.BarAppearance.Disabled.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Bar1.BarAppearance.Disabled.Options.UseFont = True
        Me.Bar1.BarAppearance.Hovered.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Bar1.BarAppearance.Hovered.Options.UseFont = True
        Me.Bar1.BarAppearance.Normal.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Bar1.BarAppearance.Normal.Options.UseFont = True
        Me.Bar1.BarAppearance.Pressed.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Bar1.BarAppearance.Pressed.Options.UseFont = True
        Me.Bar1.BarName = "Custom 3"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarLargeButtonItem2), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem2, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem3, True)})
        Me.Bar1.OptionsBar.AllowQuickCustomization = False
        Me.Bar1.OptionsBar.MultiLine = True
        Me.Bar1.OptionsBar.UseWholeRow = True
        Me.Bar1.Text = "Custom 3"
        '
        'BarLargeButtonItem2
        '
        Me.BarLargeButtonItem2.Caption = "&Close Window"
        Me.BarLargeButtonItem2.Id = 1
        Me.BarLargeButtonItem2.Name = "BarLargeButtonItem2"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Export to Excel"
        Me.BarButtonItem1.Id = 4
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "Print Report Registry"
        Me.BarButtonItem2.Id = 5
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "Export Registry Batching"
        Me.BarButtonItem3.Id = 6
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(1197, 24)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 633)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(1197, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 24)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 609)
        '
        'BarDockControl1
        '
        Me.BarDockControl1.CausesValidation = False
        Me.BarDockControl1.Dock = System.Windows.Forms.DockStyle.Right
        Me.BarDockControl1.Location = New System.Drawing.Point(1197, 24)
        Me.BarDockControl1.Manager = Me.BarManager1
        Me.BarDockControl1.Size = New System.Drawing.Size(0, 609)
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'BarLargeButtonItem1
        '
        Me.BarLargeButtonItem1.Caption = "&Close Window"
        Me.BarLargeButtonItem1.Id = 1
        Me.BarLargeButtonItem1.Name = "BarLargeButtonItem1"
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1197, 24)
        Me.barDockControlRight.Manager = Nothing
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 609)
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl1.Horizontal = False
        Me.SplitContainerControl1.Location = New System.Drawing.Point(0, 24)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.LabelControl4)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.txtMonth)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.txtClass)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.txtOffice)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.LabelControl3)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.cmdSaveButton)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.LabelControl1)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.LabelControl2)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.txtFund)
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.Em)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(1197, 609)
        Me.SplitContainerControl1.SplitterPosition = 69
        Me.SplitContainerControl1.TabIndex = 6
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Location = New System.Drawing.Point(392, 14)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(76, 17)
        Me.LabelControl4.TabIndex = 644
        Me.LabelControl4.Text = "Select Month"
        '
        'txtMonth
        '
        Me.txtMonth.EditValue = ""
        Me.txtMonth.Location = New System.Drawing.Point(392, 35)
        Me.txtMonth.Name = "txtMonth"
        Me.txtMonth.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtMonth.Properties.Appearance.Options.UseFont = True
        Me.txtMonth.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtMonth.Properties.AppearanceDropDown.Options.UseFont = True
        Me.txtMonth.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtMonth.Properties.Items.AddRange(New Object() {"JANUARY", "FEBRUARY", "MARCH", "APRIL", "MAY", "JUNE", "JULY", "AUGUST", "SEPTEMBER", "OCTOBER", "NOVEMBER", "DECEMBER"})
        Me.txtMonth.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.txtMonth.Size = New System.Drawing.Size(156, 24)
        Me.txtMonth.TabIndex = 643
        '
        'txtClass
        '
        Me.txtClass.EditValue = "sss"
        Me.txtClass.Location = New System.Drawing.Point(234, 35)
        Me.txtClass.Name = "txtClass"
        Me.txtClass.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtClass.Properties.Appearance.Options.UseFont = True
        Me.txtClass.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtClass.Properties.DisplayMember = "description"
        Me.txtClass.Properties.NullText = ""
        Me.txtClass.Properties.PopupView = Me.gridclass
        Me.txtClass.Properties.ValueMember = "code"
        Me.txtClass.Size = New System.Drawing.Size(156, 24)
        Me.txtClass.TabIndex = 637
        '
        'gridclass
        '
        Me.gridclass.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gridclass.Name = "gridclass"
        Me.gridclass.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridclass.OptionsView.ShowGroupPanel = False
        '
        'txtOffice
        '
        Me.txtOffice.EditValue = "sss"
        Me.txtOffice.Location = New System.Drawing.Point(551, 35)
        Me.txtOffice.Name = "txtOffice"
        Me.txtOffice.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtOffice.Properties.Appearance.Options.UseFont = True
        Me.txtOffice.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtOffice.Properties.DisplayMember = "officename"
        Me.txtOffice.Properties.NullText = ""
        Me.txtOffice.Properties.PopupView = Me.gridoffice
        Me.txtOffice.Properties.ValueMember = "officeid"
        Me.txtOffice.Size = New System.Drawing.Size(167, 24)
        Me.txtOffice.TabIndex = 636
        '
        'gridoffice
        '
        Me.gridoffice.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gridoffice.Name = "gridoffice"
        Me.gridoffice.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridoffice.OptionsView.ShowGroupPanel = False
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(234, 14)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(68, 17)
        Me.LabelControl3.TabIndex = 642
        Me.LabelControl3.Text = "Select Class"
        '
        'cmdSaveButton
        '
        Me.cmdSaveButton.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdSaveButton.Appearance.BackColor2 = System.Drawing.Color.Khaki
        Me.cmdSaveButton.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSaveButton.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.cmdSaveButton.Appearance.Options.UseBackColor = True
        Me.cmdSaveButton.Appearance.Options.UseFont = True
        Me.cmdSaveButton.Location = New System.Drawing.Point(722, 34)
        Me.cmdSaveButton.Name = "cmdSaveButton"
        Me.cmdSaveButton.Size = New System.Drawing.Size(108, 25)
        Me.cmdSaveButton.TabIndex = 639
        Me.cmdSaveButton.Text = "Load Report"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(551, 14)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(72, 17)
        Me.LabelControl1.TabIndex = 638
        Me.LabelControl1.Text = "Select Office"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(12, 14)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(107, 17)
        Me.LabelControl2.TabIndex = 636
        Me.LabelControl2.Text = "Select fund period"
        '
        'txtFund
        '
        Me.txtFund.EditValue = "sss"
        Me.txtFund.Location = New System.Drawing.Point(12, 35)
        Me.txtFund.Name = "txtFund"
        Me.txtFund.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtFund.Properties.Appearance.Options.UseFont = True
        Me.txtFund.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtFund.Properties.DisplayMember = "fund"
        Me.txtFund.Properties.NullText = ""
        Me.txtFund.Properties.PopupView = Me.gridFund
        Me.txtFund.Properties.ValueMember = "periodcode"
        Me.txtFund.Size = New System.Drawing.Size(220, 24)
        Me.txtFund.TabIndex = 635
        '
        'gridFund
        '
        Me.gridFund.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gridFund.Name = "gridFund"
        Me.gridFund.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridFund.OptionsView.ShowGroupPanel = False
        '
        'Em
        '
        Me.Em.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Em.Location = New System.Drawing.Point(0, 0)
        Me.Em.MainView = Me.GridView1
        Me.Em.Name = "Em"
        Me.Em.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1})
        Me.Em.Size = New System.Drawing.Size(1197, 530)
        Me.Em.TabIndex = 633
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
        Me.GridView1.OptionsView.RowAutoHeight = True
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        Me.RepositoryItemCheckEdit1.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        '
        'frmRegistry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1197, 633)
        Me.Controls.Add(Me.SplitContainerControl1)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.BarDockControl1)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(328, 395)
        Me.Name = "frmRegistry"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registry Report"
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.txtMonth.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtClass.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridclass, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOffice.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridoffice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFund.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridFund, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarLargeButtonItem1 As DevExpress.XtraBars.BarLargeButtonItem
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl1 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents BarLargeButtonItem2 As DevExpress.XtraBars.BarLargeButtonItem
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents Em As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtFund As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents gridFund As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmdSaveButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtOffice As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents gridoffice As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtClass As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents gridclass As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtMonth As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
End Class
