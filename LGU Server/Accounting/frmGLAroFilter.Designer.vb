<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmGLAroFilter
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.DockManager1 = New DevExpress.XtraBars.Docking.DockManager(Me.components)
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.BarLargeButtonItem2 = New DevExpress.XtraBars.BarLargeButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl1 = New DevExpress.XtraBars.BarDockControl()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.BarLargeButtonItem1 = New DevExpress.XtraBars.BarLargeButtonItem()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.Em_unfiltered = New DevExpress.XtraGrid.GridControl()
        Me.gridUnFiltered = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Em_filtered = New DevExpress.XtraGrid.GridControl()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.cmdMoveRight = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdMoveLeft = New DevExpress.XtraEditors.SimpleButton()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Em_unfiltered, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridUnFiltered, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Em_filtered, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DockManager1
        '
        Me.DockManager1.Form = Me
        Me.DockManager1.MenuManager = Me.BarManager1
        Me.DockManager1.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl"})
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.BarDockControl1)
        Me.BarManager1.DockManager = Me.DockManager1
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarLargeButtonItem2})
        Me.BarManager1.MainMenu = Me.Bar1
        Me.BarManager1.MaxItemId = 4
        Me.BarManager1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1})
        '
        'Bar1
        '
        Me.Bar1.BarName = "Custom 3"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.FloatLocation = New System.Drawing.Point(116, 149)
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarLargeButtonItem2)})
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
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(1141, 20)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 661)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(1141, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 20)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 641)
        '
        'BarDockControl1
        '
        Me.BarDockControl1.CausesValidation = False
        Me.BarDockControl1.Dock = System.Windows.Forms.DockStyle.Right
        Me.BarDockControl1.Location = New System.Drawing.Point(1141, 20)
        Me.BarDockControl1.Manager = Me.BarManager1
        Me.BarDockControl1.Size = New System.Drawing.Size(0, 641)
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
        Me.barDockControlRight.Location = New System.Drawing.Point(1141, 20)
        Me.barDockControlRight.Manager = Nothing
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 641)
        '
        'Em_unfiltered
        '
        Me.Em_unfiltered.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Em_unfiltered.Location = New System.Drawing.Point(3, 3)
        Me.Em_unfiltered.MainView = Me.gridUnFiltered
        Me.Em_unfiltered.Name = "Em_unfiltered"
        Me.Em_unfiltered.Size = New System.Drawing.Size(514, 635)
        Me.Em_unfiltered.TabIndex = 699
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
        'Em_filtered
        '
        Me.Em_filtered.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Em_filtered.Location = New System.Drawing.Point(623, 3)
        Me.Em_filtered.MainView = Me.GridView2
        Me.Em_filtered.Name = "Em_filtered"
        Me.Em_filtered.Size = New System.Drawing.Size(515, 635)
        Me.Em_filtered.TabIndex = 700
        Me.Em_filtered.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'GridView2
        '
        Me.GridView2.Appearance.FocusedCell.BackColor = System.Drawing.Color.Yellow
        Me.GridView2.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GridView2.GridControl = Me.Em_filtered
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsBehavior.Editable = False
        Me.GridView2.OptionsSelection.MultiSelect = True
        Me.GridView2.OptionsView.RowAutoHeight = True
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'cmdMoveRight
        '
        Me.cmdMoveRight.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdMoveRight.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdMoveRight.Appearance.Options.UseFont = True
        Me.cmdMoveRight.Location = New System.Drawing.Point(23, 51)
        Me.cmdMoveRight.Name = "cmdMoveRight"
        Me.cmdMoveRight.Size = New System.Drawing.Size(46, 46)
        Me.cmdMoveRight.TabIndex = 701
        Me.cmdMoveRight.Text = ">"
        '
        'cmdMoveLeft
        '
        Me.cmdMoveLeft.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdMoveLeft.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdMoveLeft.Appearance.Options.UseFont = True
        Me.cmdMoveLeft.Location = New System.Drawing.Point(23, 100)
        Me.cmdMoveLeft.Name = "cmdMoveLeft"
        Me.cmdMoveLeft.Size = New System.Drawing.Size(46, 46)
        Me.cmdMoveLeft.TabIndex = 702
        Me.cmdMoveLeft.Text = "<"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Em_filtered, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Em_unfiltered, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 20)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1141, 641)
        Me.TableLayoutPanel1.TabIndex = 708
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cmdMoveRight)
        Me.Panel1.Controls.Add(Me.cmdMoveLeft)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(523, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(94, 635)
        Me.Panel1.TabIndex = 0
        '
        'frmGLAroFilter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1141, 661)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.BarDockControl1)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.MinimumSize = New System.Drawing.Size(1131, 693)
        Me.Name = "frmGLAroFilter"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Monthly ARO Exemption (Note: Move item to the right to give access of a user)"
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Em_unfiltered, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridUnFiltered, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Em_filtered, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DockManager1 As DevExpress.XtraBars.Docking.DockManager
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
    Friend WithEvents cmdMoveLeft As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdMoveRight As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Em_filtered As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Em_unfiltered As DevExpress.XtraGrid.GridControl
    Friend WithEvents gridUnFiltered As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
End Class
