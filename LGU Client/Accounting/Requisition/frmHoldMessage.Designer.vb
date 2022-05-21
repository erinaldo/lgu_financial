<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHoldMessage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHoldMessage))
        Me.productid = New DevExpress.XtraEditors.TextEdit()
        Me.code = New DevExpress.XtraEditors.TextEdit()
        Me.cmdSaveButton = New DevExpress.XtraEditors.SimpleButton()
        Me.mode = New DevExpress.XtraEditors.TextEdit()
        Me.txtMessage = New DevExpress.XtraEditors.MemoEdit()
        CType(Me.productid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.code.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMessage.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'productid
        '
        Me.productid.EditValue = "REQUISITION HOLD"
        Me.productid.Location = New System.Drawing.Point(21, 12)
        Me.productid.Name = "productid"
        Me.productid.Properties.Appearance.BackColor = System.Drawing.Color.Red
        Me.productid.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.productid.Properties.Appearance.ForeColor = System.Drawing.Color.White
        Me.productid.Properties.Appearance.Options.UseBackColor = True
        Me.productid.Properties.Appearance.Options.UseFont = True
        Me.productid.Properties.Appearance.Options.UseForeColor = True
        Me.productid.Properties.Appearance.Options.UseTextOptions = True
        Me.productid.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.productid.Properties.ReadOnly = True
        Me.productid.Size = New System.Drawing.Size(558, 36)
        Me.productid.TabIndex = 677
        '
        'code
        '
        Me.code.EditValue = ""
        Me.code.Enabled = False
        Me.code.Location = New System.Drawing.Point(742, 51)
        Me.code.Name = "code"
        Me.code.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.code.Properties.Appearance.Options.UseFont = True
        Me.code.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.code.Properties.ReadOnly = True
        Me.code.Size = New System.Drawing.Size(85, 24)
        Me.code.TabIndex = 668
        Me.code.Visible = False
        '
        'cmdSaveButton
        '
        Me.cmdSaveButton.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdSaveButton.Appearance.BackColor2 = System.Drawing.Color.Khaki
        Me.cmdSaveButton.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSaveButton.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.cmdSaveButton.Appearance.Options.UseBackColor = True
        Me.cmdSaveButton.Appearance.Options.UseFont = True
        Me.cmdSaveButton.Location = New System.Drawing.Point(211, 229)
        Me.cmdSaveButton.Name = "cmdSaveButton"
        Me.cmdSaveButton.Size = New System.Drawing.Size(178, 34)
        Me.cmdSaveButton.TabIndex = 664
        Me.cmdSaveButton.Text = "Make Revision"
        '
        'mode
        '
        Me.mode.Location = New System.Drawing.Point(659, 51)
        Me.mode.Name = "mode"
        Me.mode.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mode.Properties.Appearance.Options.UseFont = True
        Me.mode.Properties.Appearance.Options.UseTextOptions = True
        Me.mode.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.mode.Properties.ReadOnly = True
        Me.mode.Size = New System.Drawing.Size(77, 24)
        Me.mode.TabIndex = 667
        Me.mode.Visible = False
        '
        'txtMessage
        '
        Me.txtMessage.EditValue = ""
        Me.txtMessage.Location = New System.Drawing.Point(21, 54)
        Me.txtMessage.Name = "txtMessage"
        Me.txtMessage.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 15.75!)
        Me.txtMessage.Properties.Appearance.ForeColor = System.Drawing.Color.Red
        Me.txtMessage.Properties.Appearance.Options.UseFont = True
        Me.txtMessage.Properties.Appearance.Options.UseForeColor = True
        Me.txtMessage.Properties.ReadOnly = True
        Me.txtMessage.Size = New System.Drawing.Size(558, 167)
        Me.txtMessage.TabIndex = 678
        '
        'frmHoldMessage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(598, 273)
        Me.Controls.Add(Me.productid)
        Me.Controls.Add(Me.code)
        Me.Controls.Add(Me.cmdSaveButton)
        Me.Controls.Add(Me.mode)
        Me.Controls.Add(Me.txtMessage)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmHoldMessage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Message"
        CType(Me.productid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.code.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMessage.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents productid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents code As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmdSaveButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents mode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtMessage As DevExpress.XtraEditors.MemoEdit
End Class
