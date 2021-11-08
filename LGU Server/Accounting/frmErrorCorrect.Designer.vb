<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmErrorCorrect
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
        Me.BarManager1 = New DevExpress.XtraBars.BarManager()
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.BarLargeButtonItem2 = New DevExpress.XtraBars.BarLargeButtonItem()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl1 = New DevExpress.XtraBars.BarDockControl()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.BarLargeButtonItem1 = New DevExpress.XtraBars.BarLargeButtonItem()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.txtRangeFrom = New DevExpress.XtraEditors.TextEdit()
        Me.Em = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.txtRangeFrom.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarLargeButtonItem2, Me.BarButtonItem1})
        Me.BarManager1.MainMenu = Me.Bar1
        Me.BarManager1.MaxItemId = 5
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
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarLargeButtonItem2), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1, True)})
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
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(1154, 24)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 649)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(1154, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 24)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 625)
        '
        'BarDockControl1
        '
        Me.BarDockControl1.CausesValidation = False
        Me.BarDockControl1.Dock = System.Windows.Forms.DockStyle.Right
        Me.BarDockControl1.Location = New System.Drawing.Point(1154, 24)
        Me.BarDockControl1.Manager = Me.BarManager1
        Me.BarDockControl1.Size = New System.Drawing.Size(0, 625)
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
        Me.barDockControlRight.Location = New System.Drawing.Point(1154, 24)
        Me.barDockControlRight.Manager = Nothing
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 625)
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl1.Horizontal = False
        Me.SplitContainerControl1.Location = New System.Drawing.Point(0, 24)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.LabelControl7)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.txtRangeFrom)
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.Em)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(1154, 625)
        Me.SplitContainerControl1.SplitterPosition = 66
        Me.SplitContainerControl1.TabIndex = 6
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl7.Appearance.Options.UseFont = True
        Me.LabelControl7.Location = New System.Drawing.Point(12, 8)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(217, 15)
        Me.LabelControl7.TabIndex = 862
        Me.LabelControl7.Text = "Enter any keywork to search and hit enter"
        '
        'txtRangeFrom
        '
        Me.txtRangeFrom.Location = New System.Drawing.Point(11, 28)
        Me.txtRangeFrom.MenuManager = Me.BarManager1
        Me.txtRangeFrom.Name = "txtRangeFrom"
        Me.txtRangeFrom.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtRangeFrom.Properties.Appearance.Options.UseFont = True
        Me.txtRangeFrom.Properties.NullValuePrompt = "Advance search item"
        Me.txtRangeFrom.Size = New System.Drawing.Size(385, 26)
        Me.txtRangeFrom.TabIndex = 0
        '
        'Em
        '
        Me.Em.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Em.Location = New System.Drawing.Point(0, 0)
        Me.Em.MainView = Me.GridView1
        Me.Em.Name = "Em"
        Me.Em.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1})
        Me.Em.Size = New System.Drawing.Size(1154, 549)
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
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        Me.RepositoryItemCheckEdit1.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        '
        'frmErrorCorrect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1154, 649)
        Me.Controls.Add(Me.SplitContainerControl1)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.BarDockControl1)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(372, 378)
        Me.Name = "frmErrorCorrect"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transaction Finder"
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.txtRangeFrom.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents txtRangeFrom As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
End Class
