<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRequisitionFundReturn
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
        Me.Em = New DevExpress.XtraGrid.GridControl()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmdAddItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.pid = New DevExpress.XtraEditors.TextEdit()
        Me.cmdSaveChanges = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdClose = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Em
        '
        Me.Em.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Em.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Em.Location = New System.Drawing.Point(6, 4)
        Me.Em.MainView = Me.GridView1
        Me.Em.Name = "Em"
        Me.Em.Size = New System.Drawing.Size(624, 277)
        Me.Em.TabIndex = 3
        Me.Em.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdAddItem, Me.ToolStripSeparator4, Me.ToolStripMenuItem5})
        Me.ContextMenuStrip1.Name = "gridmenustrip"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(176, 54)
        '
        'cmdAddItem
        '
        Me.cmdAddItem.Image = Global.LGUClient.My.Resources.Resources.notebook__backarrow
        Me.cmdAddItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmdAddItem.Name = "cmdAddItem"
        Me.cmdAddItem.Size = New System.Drawing.Size(175, 22)
        Me.cmdAddItem.Text = "Set Return Amount"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(172, 6)
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Image = Global.LGUClient.My.Resources.Resources.arrow_continue_090
        Me.ToolStripMenuItem5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(175, 22)
        Me.ToolStripMenuItem5.Text = "Refresh Data"
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.Em
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.RowAutoHeight = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'pid
        '
        Me.pid.Location = New System.Drawing.Point(274, 142)
        Me.pid.Name = "pid"
        Me.pid.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pid.Properties.Appearance.Options.UseFont = True
        Me.pid.Properties.Appearance.Options.UseTextOptions = True
        Me.pid.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.pid.Properties.ReadOnly = True
        Me.pid.Size = New System.Drawing.Size(37, 24)
        Me.pid.TabIndex = 947
        Me.pid.Visible = False
        '
        'cmdSaveChanges
        '
        Me.cmdSaveChanges.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.cmdSaveChanges.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdSaveChanges.Appearance.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmdSaveChanges.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSaveChanges.Appearance.Options.UseBackColor = True
        Me.cmdSaveChanges.Appearance.Options.UseFont = True
        Me.cmdSaveChanges.Location = New System.Drawing.Point(154, 289)
        Me.cmdSaveChanges.Name = "cmdSaveChanges"
        Me.cmdSaveChanges.Size = New System.Drawing.Size(157, 32)
        Me.cmdSaveChanges.TabIndex = 948
        Me.cmdSaveChanges.Text = "Save Changes"
        '
        'cmdClose
        '
        Me.cmdClose.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.cmdClose.Appearance.BackColor = System.Drawing.Color.Khaki
        Me.cmdClose.Appearance.BackColor2 = System.Drawing.Color.Khaki
        Me.cmdClose.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.Appearance.Options.UseBackColor = True
        Me.cmdClose.Appearance.Options.UseFont = True
        Me.cmdClose.Location = New System.Drawing.Point(317, 289)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(157, 32)
        Me.cmdClose.TabIndex = 949
        Me.cmdClose.Text = "Close Window"
        '
        'frmRequisitionFundReturn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(636, 330)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdSaveChanges)
        Me.Controls.Add(Me.pid)
        Me.Controls.Add(Me.Em)
        Me.HelpButton = True
        Me.Name = "frmRequisitionFundReturn"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Requisition Fund Return"
        CType(Me.Em, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Em As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents pid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmdSaveChanges As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdClose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents cmdAddItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents ToolStripMenuItem5 As ToolStripMenuItem
End Class
