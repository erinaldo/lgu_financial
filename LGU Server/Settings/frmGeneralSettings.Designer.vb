<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGeneralSettings
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
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.cmdSave = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.tabGeneral = New DevExpress.XtraTab.XtraTabPage()
        Me.txtWebserverAddress = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl18 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl17 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txtFileKB = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtFileMB = New DevExpress.XtraEditors.TextEdit()
        Me.tabAdvance = New DevExpress.XtraTab.XtraTabPage()
        Me.list_settings = New DevExpress.XtraEditors.CheckedListBoxControl()
        Me.tabTransactionSequence = New DevExpress.XtraTab.XtraTabPage()
        Me.Em = New DevExpress.XtraGrid.GridControl()
        Me.Gridview1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.tabDefaultSettings = New DevExpress.XtraTab.XtraTabPage()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.tabGeneral.SuspendLayout()
        CType(Me.txtWebserverAddress.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFileKB.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFileMB.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabAdvance.SuspendLayout()
        CType(Me.list_settings, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabTransactionSequence.SuspendLayout()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Gridview1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabDefaultSettings.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar2})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarButtonItem1, Me.cmdSave})
        Me.BarManager1.MainMenu = Me.Bar2
        Me.BarManager1.MaxItemId = 2
        '
        'Bar2
        '
        Me.Bar2.BarName = "Main menu"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1, True), New DevExpress.XtraBars.LinkPersistInfo(Me.cmdSave, True)})
        Me.Bar2.OptionsBar.AllowQuickCustomization = False
        Me.Bar2.OptionsBar.DrawDragBorder = False
        Me.Bar2.OptionsBar.MultiLine = True
        Me.Bar2.OptionsBar.UseWholeRow = True
        Me.Bar2.Text = "Main menu"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Close Window"
        Me.BarButtonItem1.Id = 0
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'cmdSave
        '
        Me.cmdSave.Caption = "Save Selected Tab Settings"
        Me.cmdSave.Id = 1
        Me.cmdSave.Name = "cmdSave"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(833, 20)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 549)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(833, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 20)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 529)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(833, 20)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 529)
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Location = New System.Drawing.Point(456, 268)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(125, 29)
        Me.SimpleButton3.TabIndex = 413
        Me.SimpleButton3.Text = "OK"
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.AppearancePage.Header.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XtraTabControl1.AppearancePage.Header.Options.UseFont = True
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 20)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.tabGeneral
        Me.XtraTabControl1.Size = New System.Drawing.Size(833, 529)
        Me.XtraTabControl1.TabIndex = 414
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.tabGeneral, Me.tabAdvance, Me.tabTransactionSequence, Me.tabDefaultSettings})
        Me.XtraTabControl1.Transition.AllowTransition = DevExpress.Utils.DefaultBoolean.[True]
        '
        'tabGeneral
        '
        Me.tabGeneral.Controls.Add(Me.txtWebserverAddress)
        Me.tabGeneral.Controls.Add(Me.LabelControl18)
        Me.tabGeneral.Controls.Add(Me.LabelControl17)
        Me.tabGeneral.Controls.Add(Me.LabelControl4)
        Me.tabGeneral.Controls.Add(Me.txtFileKB)
        Me.tabGeneral.Controls.Add(Me.LabelControl3)
        Me.tabGeneral.Controls.Add(Me.txtFileMB)
        Me.tabGeneral.Name = "tabGeneral"
        Me.tabGeneral.Size = New System.Drawing.Size(831, 504)
        Me.tabGeneral.Text = "General Settings"
        '
        'txtWebserverAddress
        '
        Me.txtWebserverAddress.EnterMoveNextControl = True
        Me.txtWebserverAddress.Location = New System.Drawing.Point(21, 36)
        Me.txtWebserverAddress.Name = "txtWebserverAddress"
        Me.txtWebserverAddress.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.txtWebserverAddress.Properties.Appearance.Options.UseFont = True
        Me.txtWebserverAddress.Size = New System.Drawing.Size(390, 26)
        Me.txtWebserverAddress.TabIndex = 684
        '
        'LabelControl18
        '
        Me.LabelControl18.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.LabelControl18.Appearance.Options.UseFont = True
        Me.LabelControl18.Location = New System.Drawing.Point(21, 15)
        Me.LabelControl18.Name = "LabelControl18"
        Me.LabelControl18.Size = New System.Drawing.Size(171, 19)
        Me.LabelControl18.TabIndex = 685
        Me.LabelControl18.Text = "Default Web Server Address"
        '
        'LabelControl17
        '
        Me.LabelControl17.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.LabelControl17.Appearance.Options.UseFont = True
        Me.LabelControl17.Location = New System.Drawing.Point(21, 72)
        Me.LabelControl17.Name = "LabelControl17"
        Me.LabelControl17.Size = New System.Drawing.Size(185, 19)
        Me.LabelControl17.TabIndex = 683
        Me.LabelControl17.Text = "Allowable Attachment File Size"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Location = New System.Drawing.Point(230, 99)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(16, 19)
        Me.LabelControl4.TabIndex = 682
        Me.LabelControl4.Text = "KB"
        '
        'txtFileKB
        '
        Me.txtFileKB.EditValue = "0"
        Me.txtFileKB.EnterMoveNextControl = True
        Me.txtFileKB.Location = New System.Drawing.Point(126, 96)
        Me.txtFileKB.Name = "txtFileKB"
        Me.txtFileKB.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.txtFileKB.Properties.Appearance.Options.UseFont = True
        Me.txtFileKB.Properties.Appearance.Options.UseTextOptions = True
        Me.txtFileKB.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtFileKB.Properties.Mask.EditMask = "n"
        Me.txtFileKB.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtFileKB.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtFileKB.Properties.ReadOnly = True
        Me.txtFileKB.Size = New System.Drawing.Size(100, 26)
        Me.txtFileKB.TabIndex = 681
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(99, 99)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(21, 19)
        Me.LabelControl3.TabIndex = 680
        Me.LabelControl3.Text = "MB"
        '
        'txtFileMB
        '
        Me.txtFileMB.EditValue = "0"
        Me.txtFileMB.EnterMoveNextControl = True
        Me.txtFileMB.Location = New System.Drawing.Point(21, 96)
        Me.txtFileMB.Name = "txtFileMB"
        Me.txtFileMB.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.txtFileMB.Properties.Appearance.Options.UseFont = True
        Me.txtFileMB.Properties.Appearance.Options.UseTextOptions = True
        Me.txtFileMB.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtFileMB.Properties.Mask.EditMask = "n"
        Me.txtFileMB.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtFileMB.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtFileMB.Size = New System.Drawing.Size(71, 26)
        Me.txtFileMB.TabIndex = 679
        '
        'tabAdvance
        '
        Me.tabAdvance.Controls.Add(Me.list_settings)
        Me.tabAdvance.Name = "tabAdvance"
        Me.tabAdvance.Size = New System.Drawing.Size(833, 502)
        Me.tabAdvance.Text = "Advance Option"
        '
        'list_settings
        '
        Me.list_settings.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.75!)
        Me.list_settings.Appearance.Options.UseFont = True
        Me.list_settings.Appearance.Options.UseTextOptions = True
        Me.list_settings.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.list_settings.Dock = System.Windows.Forms.DockStyle.Fill
        Me.list_settings.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Skinned
        Me.list_settings.HorizontalScrollbar = True
        Me.list_settings.HotTrackItems = True
        Me.list_settings.HotTrackSelectMode = DevExpress.XtraEditors.HotTrackSelectMode.SelectItemOnClick
        Me.list_settings.IncrementalSearch = True
        Me.list_settings.Location = New System.Drawing.Point(0, 0)
        Me.list_settings.MultiColumn = True
        Me.list_settings.Name = "list_settings"
        Me.list_settings.Size = New System.Drawing.Size(833, 502)
        Me.list_settings.TabIndex = 619
        '
        'tabTransactionSequence
        '
        Me.tabTransactionSequence.Controls.Add(Me.Em)
        Me.tabTransactionSequence.Name = "tabTransactionSequence"
        Me.tabTransactionSequence.Size = New System.Drawing.Size(833, 502)
        Me.tabTransactionSequence.Text = "Transaction Sequence"
        '
        'Em
        '
        Me.Em.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Em.Location = New System.Drawing.Point(0, 0)
        Me.Em.MainView = Me.Gridview1
        Me.Em.Name = "Em"
        Me.Em.Size = New System.Drawing.Size(833, 502)
        Me.Em.TabIndex = 866
        Me.Em.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.Gridview1})
        '
        'Gridview1
        '
        Me.Gridview1.Appearance.HeaderPanel.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Gridview1.Appearance.HeaderPanel.Options.UseFont = True
        Me.Gridview1.Appearance.Row.Font = New System.Drawing.Font("Segoe UI", 10.75!)
        Me.Gridview1.Appearance.Row.Options.UseFont = True
        Me.Gridview1.GridControl = Me.Em
        Me.Gridview1.Name = "Gridview1"
        Me.Gridview1.OptionsSelection.InvertSelection = True
        Me.Gridview1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect
        Me.Gridview1.OptionsView.ColumnAutoWidth = False
        Me.Gridview1.OptionsView.RowAutoHeight = True
        Me.Gridview1.OptionsView.ShowGroupPanel = False
        '
        'tabDefaultSettings
        '
        Me.tabDefaultSettings.Controls.Add(Me.GridControl1)
        Me.tabDefaultSettings.Name = "tabDefaultSettings"
        Me.tabDefaultSettings.Size = New System.Drawing.Size(833, 502)
        Me.tabDefaultSettings.Text = "Default Settings"
        '
        'GridControl1
        '
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView2
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(833, 502)
        Me.GridControl1.TabIndex = 867
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'GridView2
        '
        Me.GridView2.Appearance.HeaderPanel.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.GridView2.Appearance.HeaderPanel.Options.UseFont = True
        Me.GridView2.Appearance.Row.Font = New System.Drawing.Font("Segoe UI", 10.75!)
        Me.GridView2.Appearance.Row.Options.UseFont = True
        Me.GridView2.GridControl = Me.GridControl1
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsSelection.InvertSelection = True
        Me.GridView2.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect
        Me.GridView2.OptionsView.ColumnAutoWidth = False
        Me.GridView2.OptionsView.RowAutoHeight = True
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'frmGeneralSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(833, 549)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Controls.Add(Me.SimpleButton3)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "frmGeneralSettings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "General Settings"
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.tabGeneral.ResumeLayout(False)
        Me.tabGeneral.PerformLayout()
        CType(Me.txtWebserverAddress.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFileKB.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFileMB.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabAdvance.ResumeLayout(False)
        CType(Me.list_settings, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabTransactionSequence.ResumeLayout(False)
        CType(Me.Em, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Gridview1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabDefaultSettings.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents tabAdvance As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents cmdSave As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents list_settings As DevExpress.XtraEditors.CheckedListBoxControl
    Friend WithEvents tabTransactionSequence As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents Em As DevExpress.XtraGrid.GridControl
    Friend WithEvents Gridview1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents tabDefaultSettings As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents tabGeneral As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents txtWebserverAddress As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl18 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl17 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtFileKB As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtFileMB As DevExpress.XtraEditors.TextEdit
End Class
