<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSourceOfFund
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
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip()
        Me.cmdEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdRemove = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Em = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.cmdForApproval = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdAddfiles = New DevExpress.XtraEditors.SimpleButton()
        Me.requestno = New DevExpress.XtraEditors.TextEdit()
        Me.pid = New DevExpress.XtraEditors.TextEdit()
        Me.periodcode = New DevExpress.XtraEditors.TextEdit()
        Me.officeid = New DevExpress.XtraEditors.TextEdit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.requestno.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.periodcode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.officeid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdEdit, Me.cmdRemove, Me.ToolStripSeparator4, Me.ToolStripMenuItem5})
        Me.ContextMenuStrip1.Name = "gridmenustrip"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(157, 76)
        '
        'cmdEdit
        '
        Me.cmdEdit.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEdit.Image = Global.LGUClient.My.Resources.Resources.notebook__pencil
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(156, 22)
        Me.cmdEdit.Text = "Edit Source"
        '
        'cmdRemove
        '
        Me.cmdRemove.Image = Global.LGUClient.My.Resources.Resources.notebook__minus
        Me.cmdRemove.Name = "cmdRemove"
        Me.cmdRemove.Size = New System.Drawing.Size(156, 22)
        Me.cmdRemove.Text = "Remove Source"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(153, 6)
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Image = Global.LGUClient.My.Resources.Resources.arrow_continue_090
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(156, 22)
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
        Me.Em.Size = New System.Drawing.Size(602, 261)
        Me.Em.TabIndex = 3
        Me.Em.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.Em
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsSelection.MultiSelect = True
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.RowAutoHeight = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'cmdForApproval
        '
        Me.cmdForApproval.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdForApproval.Appearance.BackColor = System.Drawing.Color.Khaki
        Me.cmdForApproval.Appearance.BackColor2 = System.Drawing.Color.Khaki
        Me.cmdForApproval.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdForApproval.Appearance.Options.UseBackColor = True
        Me.cmdForApproval.Appearance.Options.UseFont = True
        Me.cmdForApproval.Location = New System.Drawing.Point(457, 279)
        Me.cmdForApproval.Name = "cmdForApproval"
        Me.cmdForApproval.Size = New System.Drawing.Size(157, 32)
        Me.cmdForApproval.TabIndex = 940
        Me.cmdForApproval.Text = "Close Window"
        '
        'cmdAddfiles
        '
        Me.cmdAddfiles.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdAddfiles.Appearance.BackColor = System.Drawing.Color.Khaki
        Me.cmdAddfiles.Appearance.BackColor2 = System.Drawing.Color.Khaki
        Me.cmdAddfiles.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAddfiles.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.cmdAddfiles.Appearance.Options.UseBackColor = True
        Me.cmdAddfiles.Appearance.Options.UseFont = True
        Me.cmdAddfiles.Location = New System.Drawing.Point(298, 279)
        Me.cmdAddfiles.Name = "cmdAddfiles"
        Me.cmdAddfiles.Size = New System.Drawing.Size(153, 32)
        Me.cmdAddfiles.TabIndex = 941
        Me.cmdAddfiles.Text = "Add Source"
        '
        'requestno
        '
        Me.requestno.Location = New System.Drawing.Point(64, 207)
        Me.requestno.Name = "requestno"
        Me.requestno.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.requestno.Properties.Appearance.Options.UseFont = True
        Me.requestno.Properties.Appearance.Options.UseTextOptions = True
        Me.requestno.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.requestno.Properties.ReadOnly = True
        Me.requestno.Size = New System.Drawing.Size(37, 24)
        Me.requestno.TabIndex = 968
        Me.requestno.Visible = False
        '
        'pid
        '
        Me.pid.Location = New System.Drawing.Point(21, 207)
        Me.pid.Name = "pid"
        Me.pid.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pid.Properties.Appearance.Options.UseFont = True
        Me.pid.Properties.Appearance.Options.UseTextOptions = True
        Me.pid.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.pid.Properties.ReadOnly = True
        Me.pid.Size = New System.Drawing.Size(37, 24)
        Me.pid.TabIndex = 967
        Me.pid.Visible = False
        '
        'periodcode
        '
        Me.periodcode.Location = New System.Drawing.Point(150, 207)
        Me.periodcode.Name = "periodcode"
        Me.periodcode.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.periodcode.Properties.Appearance.Options.UseFont = True
        Me.periodcode.Properties.Appearance.Options.UseTextOptions = True
        Me.periodcode.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.periodcode.Properties.ReadOnly = True
        Me.periodcode.Size = New System.Drawing.Size(37, 24)
        Me.periodcode.TabIndex = 966
        Me.periodcode.Visible = False
        '
        'officeid
        '
        Me.officeid.Location = New System.Drawing.Point(107, 207)
        Me.officeid.Name = "officeid"
        Me.officeid.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.officeid.Properties.Appearance.Options.UseFont = True
        Me.officeid.Properties.Appearance.Options.UseTextOptions = True
        Me.officeid.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.officeid.Properties.ReadOnly = True
        Me.officeid.Size = New System.Drawing.Size(37, 24)
        Me.officeid.TabIndex = 965
        Me.officeid.Visible = False
        '
        'frmSourceOfFund
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(625, 321)
        Me.Controls.Add(Me.requestno)
        Me.Controls.Add(Me.pid)
        Me.Controls.Add(Me.periodcode)
        Me.Controls.Add(Me.officeid)
        Me.Controls.Add(Me.cmdAddfiles)
        Me.Controls.Add(Me.cmdForApproval)
        Me.Controls.Add(Me.Em)
        Me.HelpButton = True
        Me.MaximizeBox = False
        Me.Name = "frmSourceOfFund"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Source of Fund"
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.Em, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.requestno.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.periodcode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.officeid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmdEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItem5 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Em As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cmdForApproval As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdAddfiles As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdRemove As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents requestno As DevExpress.XtraEditors.TextEdit
    Friend WithEvents pid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents periodcode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents officeid As DevExpress.XtraEditors.TextEdit
End Class
