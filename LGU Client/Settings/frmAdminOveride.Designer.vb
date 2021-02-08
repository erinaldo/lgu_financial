<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdminOveride
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
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtusername = New DevExpress.XtraEditors.TextEdit()
        Me.txtpassword = New DevExpress.XtraEditors.TextEdit()
        Me.cmdSaveButton = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.txtusername.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtpassword.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtusername
        '
        Me.txtusername.EnterMoveNextControl = True
        Me.txtusername.Location = New System.Drawing.Point(91, 37)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtusername.Properties.Appearance.Options.UseFont = True
        Me.txtusername.Properties.Appearance.Options.UseTextOptions = True
        Me.txtusername.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtusername.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtusername.Properties.NullValuePrompt = "Username"
        Me.txtusername.Size = New System.Drawing.Size(191, 24)
        Me.txtusername.TabIndex = 0
        '
        'txtpassword
        '
        Me.txtpassword.EditValue = ""
        Me.txtpassword.Location = New System.Drawing.Point(91, 64)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtpassword.Properties.Appearance.Options.UseFont = True
        Me.txtpassword.Properties.Appearance.Options.UseTextOptions = True
        Me.txtpassword.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtpassword.Properties.NullValuePrompt = "Password"
        Me.txtpassword.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(108)
        Me.txtpassword.Properties.UseSystemPasswordChar = True
        Me.txtpassword.Size = New System.Drawing.Size(191, 24)
        Me.txtpassword.TabIndex = 1
        '
        'cmdSaveButton
        '
        Me.cmdSaveButton.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdSaveButton.Appearance.BackColor2 = System.Drawing.Color.Khaki
        Me.cmdSaveButton.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSaveButton.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.cmdSaveButton.Appearance.Options.UseBackColor = True
        Me.cmdSaveButton.Appearance.Options.UseFont = True
        Me.cmdSaveButton.Location = New System.Drawing.Point(117, 92)
        Me.cmdSaveButton.Name = "cmdSaveButton"
        Me.cmdSaveButton.Size = New System.Drawing.Size(139, 26)
        Me.cmdSaveButton.TabIndex = 2
        Me.cmdSaveButton.Text = "Confirm"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseTextOptions = True
        Me.LabelControl1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.LabelControl1.Location = New System.Drawing.Point(57, 18)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(259, 13)
        Me.LabelControl1.TabIndex = 376
        Me.LabelControl1.Text = "Please enter authorized admin account to override"
        '
        'frmAdminOveride
        '
        Me.AcceptButton = Me.cmdSaveButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(376, 136)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.cmdSaveButton)
        Me.Controls.Add(Me.txtusername)
        Me.Controls.Add(Me.txtpassword)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.MaximizeBox = False
        Me.Name = "frmAdminOveride"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Admin Account Overide"
        Me.TopMost = True
        CType(Me.txtusername.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtpassword.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents txtusername As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtpassword As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmdSaveButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
End Class
