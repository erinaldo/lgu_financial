<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBackupTool
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
        Me.txtKey = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.cmdFinish = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.txtKey.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtKey
        '
        Me.txtKey.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtKey.EnterMoveNextControl = True
        Me.txtKey.Location = New System.Drawing.Point(86, 32)
        Me.txtKey.Name = "txtKey"
        Me.txtKey.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKey.Properties.Appearance.Options.UseFont = True
        Me.txtKey.Properties.Appearance.Options.UseTextOptions = True
        Me.txtKey.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtKey.Properties.ReadOnly = True
        Me.txtKey.Size = New System.Drawing.Size(309, 22)
        Me.txtKey.TabIndex = 610
        '
        'LabelControl1
        '
        Me.LabelControl1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(185, 13)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(111, 15)
        Me.LabelControl1.TabIndex = 611
        Me.LabelControl1.Text = "Backup Database File"
        '
        'cmdFinish
        '
        Me.cmdFinish.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdFinish.Appearance.BackColor2 = System.Drawing.Color.Khaki
        Me.cmdFinish.Appearance.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdFinish.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.cmdFinish.Appearance.Options.UseBackColor = True
        Me.cmdFinish.Appearance.Options.UseFont = True
        Me.cmdFinish.Location = New System.Drawing.Point(155, 61)
        Me.cmdFinish.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdFinish.Name = "cmdFinish"
        Me.cmdFinish.Size = New System.Drawing.Size(161, 39)
        Me.cmdFinish.TabIndex = 612
        Me.cmdFinish.Text = "Create Backup"
        '
        'frmBackupTool
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(482, 121)
        Me.Controls.Add(Me.cmdFinish)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.txtKey)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmBackupTool"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Database Backup Tool"
        CType(Me.txtKey.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtKey As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmdFinish As DevExpress.XtraEditors.SimpleButton
End Class
