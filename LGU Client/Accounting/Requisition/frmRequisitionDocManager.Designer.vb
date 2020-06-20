<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRequisitionDocManager
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
        Me.components = New System.ComponentModel.Container()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SelectItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveAttachementToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Em = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.cmdForApproval = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdAddfiles = New DevExpress.XtraEditors.SimpleButton()
        Me.filecode = New DevExpress.XtraEditors.TextEdit()
        Me.pid = New DevExpress.XtraEditors.TextEdit()
        Me.applevel = New DevExpress.XtraEditors.TextEdit()
        Me.requesttype = New DevExpress.XtraEditors.TextEdit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.filecode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.applevel.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.requesttype.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SelectItemToolStripMenuItem, Me.RemoveAttachementToolStripMenuItem, Me.ToolStripSeparator4, Me.ToolStripMenuItem5})
        Me.ContextMenuStrip1.Name = "gridmenustrip"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(201, 98)
        '
        'SelectItemToolStripMenuItem
        '
        Me.SelectItemToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SelectItemToolStripMenuItem.Image = Global.LGUClient.My.Resources.Resources.inbox__plus
        Me.SelectItemToolStripMenuItem.Name = "SelectItemToolStripMenuItem"
        Me.SelectItemToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.SelectItemToolStripMenuItem.Text = "Attach Document Files"
        '
        'RemoveAttachementToolStripMenuItem
        '
        Me.RemoveAttachementToolStripMenuItem.Image = Global.LGUClient.My.Resources.Resources.inbox__minus
        Me.RemoveAttachementToolStripMenuItem.Name = "RemoveAttachementToolStripMenuItem"
        Me.RemoveAttachementToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.RemoveAttachementToolStripMenuItem.Text = "Remove Attachment"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(197, 6)
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Image = Global.LGUClient.My.Resources.Resources.arrow_continue_090
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(200, 22)
        Me.ToolStripMenuItem5.Text = "Refresh Data"
        '
        'Em
        '
        Me.Em.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Em.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Em.Location = New System.Drawing.Point(12, 12)
        Me.Em.MainView = Me.GridView1
        Me.Em.Name = "Em"
        Me.Em.Size = New System.Drawing.Size(697, 345)
        Me.Em.TabIndex = 3
        Me.Em.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
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
        'cmdForApproval
        '
        Me.cmdForApproval.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdForApproval.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdForApproval.Appearance.BackColor2 = System.Drawing.Color.Khaki
        Me.cmdForApproval.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdForApproval.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.cmdForApproval.Appearance.Options.UseBackColor = True
        Me.cmdForApproval.Appearance.Options.UseFont = True
        Me.cmdForApproval.Location = New System.Drawing.Point(401, 365)
        Me.cmdForApproval.Name = "cmdForApproval"
        Me.cmdForApproval.Size = New System.Drawing.Size(308, 38)
        Me.cmdForApproval.TabIndex = 940
        Me.cmdForApproval.Text = "Confirm Attachment Files"
        '
        'cmdAddfiles
        '
        Me.cmdAddfiles.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdAddfiles.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdAddfiles.Appearance.BackColor2 = System.Drawing.Color.Khaki
        Me.cmdAddfiles.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAddfiles.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.cmdAddfiles.Appearance.Options.UseBackColor = True
        Me.cmdAddfiles.Appearance.Options.UseFont = True
        Me.cmdAddfiles.Location = New System.Drawing.Point(199, 365)
        Me.cmdAddfiles.Name = "cmdAddfiles"
        Me.cmdAddfiles.Size = New System.Drawing.Size(196, 38)
        Me.cmdAddfiles.TabIndex = 941
        Me.cmdAddfiles.Text = "Attach Files"
        '
        'filecode
        '
        Me.filecode.Location = New System.Drawing.Point(12, 363)
        Me.filecode.Name = "filecode"
        Me.filecode.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.filecode.Properties.Appearance.Options.UseFont = True
        Me.filecode.Properties.Appearance.Options.UseTextOptions = True
        Me.filecode.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.filecode.Properties.ReadOnly = True
        Me.filecode.Size = New System.Drawing.Size(50, 24)
        Me.filecode.TabIndex = 943
        Me.filecode.Visible = False
        '
        'pid
        '
        Me.pid.Location = New System.Drawing.Point(68, 363)
        Me.pid.Name = "pid"
        Me.pid.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pid.Properties.Appearance.Options.UseFont = True
        Me.pid.Properties.Appearance.Options.UseTextOptions = True
        Me.pid.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.pid.Properties.ReadOnly = True
        Me.pid.Size = New System.Drawing.Size(50, 24)
        Me.pid.TabIndex = 944
        Me.pid.Visible = False
        '
        'applevel
        '
        Me.applevel.Location = New System.Drawing.Point(124, 363)
        Me.applevel.Name = "applevel"
        Me.applevel.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.applevel.Properties.Appearance.Options.UseFont = True
        Me.applevel.Properties.Appearance.Options.UseTextOptions = True
        Me.applevel.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.applevel.Properties.ReadOnly = True
        Me.applevel.Size = New System.Drawing.Size(50, 24)
        Me.applevel.TabIndex = 945
        Me.applevel.Visible = False
        '
        'requesttype
        '
        Me.requesttype.Location = New System.Drawing.Point(12, 393)
        Me.requesttype.Name = "requesttype"
        Me.requesttype.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.requesttype.Properties.Appearance.Options.UseFont = True
        Me.requesttype.Properties.Appearance.Options.UseTextOptions = True
        Me.requesttype.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.requesttype.Properties.ReadOnly = True
        Me.requesttype.Size = New System.Drawing.Size(50, 24)
        Me.requesttype.TabIndex = 946
        Me.requesttype.Visible = False
        '
        'frmRequisitionDocManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(720, 415)
        Me.Controls.Add(Me.requesttype)
        Me.Controls.Add(Me.applevel)
        Me.Controls.Add(Me.pid)
        Me.Controls.Add(Me.filecode)
        Me.Controls.Add(Me.cmdAddfiles)
        Me.Controls.Add(Me.cmdForApproval)
        Me.Controls.Add(Me.Em)
        Me.HelpButton = True
        Me.Name = "frmRequisitionDocManager"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Document Manager"
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.Em, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.filecode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.applevel.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.requesttype.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents SelectItemToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItem5 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Em As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cmdForApproval As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdAddfiles As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents filecode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents pid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents RemoveAttachementToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents applevel As DevExpress.XtraEditors.TextEdit
    Friend WithEvents requesttype As DevExpress.XtraEditors.TextEdit
End Class
