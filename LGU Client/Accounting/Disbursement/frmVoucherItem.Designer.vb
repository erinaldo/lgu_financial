<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVoucherItem
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
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtAmount = New DevExpress.XtraEditors.TextEdit()
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtExplaination = New DevExpress.XtraEditors.MemoEdit()
        Me.voucherno = New DevExpress.XtraEditors.ButtonEdit()
        Me.mode = New DevExpress.XtraEditors.ButtonEdit()
        Me.id = New DevExpress.XtraEditors.ButtonEdit()
        CType(Me.txtAmount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtExplaination.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.voucherno.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.id.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Appearance.Options.UseTextOptions = True
        Me.LabelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl3.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.LabelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal
        Me.LabelControl3.Location = New System.Drawing.Point(55, 80)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(44, 15)
        Me.LabelControl3.TabIndex = 837
        Me.LabelControl3.Text = "Amount"
        '
        'txtAmount
        '
        Me.txtAmount.EditValue = "0"
        Me.txtAmount.EnterMoveNextControl = True
        Me.txtAmount.Location = New System.Drawing.Point(105, 75)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtAmount.Properties.Appearance.Options.UseFont = True
        Me.txtAmount.Properties.Appearance.Options.UseTextOptions = True
        Me.txtAmount.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtAmount.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAmount.Properties.Mask.EditMask = "n"
        Me.txtAmount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtAmount.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtAmount.Properties.MaxLength = 50
        Me.txtAmount.Size = New System.Drawing.Size(147, 24)
        Me.txtAmount.TabIndex = 834
        '
        'cmdSave
        '
        Me.cmdSave.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdSave.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSave.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.cmdSave.Appearance.Options.UseBackColor = True
        Me.cmdSave.Appearance.Options.UseFont = True
        Me.cmdSave.Location = New System.Drawing.Point(105, 105)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(147, 32)
        Me.cmdSave.TabIndex = 835
        Me.cmdSave.Text = "Save"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(29, 24)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(70, 17)
        Me.LabelControl1.TabIndex = 836
        Me.LabelControl1.Text = "Explaination"
        '
        'txtExplaination
        '
        Me.txtExplaination.EditValue = ""
        Me.txtExplaination.Location = New System.Drawing.Point(105, 22)
        Me.txtExplaination.Name = "txtExplaination"
        Me.txtExplaination.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtExplaination.Properties.Appearance.Options.UseFont = True
        Me.txtExplaination.Size = New System.Drawing.Size(347, 48)
        Me.txtExplaination.TabIndex = 833
        '
        'voucherno
        '
        Me.voucherno.EditValue = ""
        Me.voucherno.Location = New System.Drawing.Point(365, 126)
        Me.voucherno.Name = "voucherno"
        Me.voucherno.Properties.Appearance.Options.UseTextOptions = True
        Me.voucherno.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.voucherno.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.voucherno.Properties.Mask.BeepOnError = True
        Me.voucherno.Properties.ReadOnly = True
        Me.voucherno.Size = New System.Drawing.Size(39, 20)
        Me.voucherno.TabIndex = 843
        Me.voucherno.Visible = False
        '
        'mode
        '
        Me.mode.EditValue = ""
        Me.mode.Location = New System.Drawing.Point(410, 126)
        Me.mode.Name = "mode"
        Me.mode.Properties.Appearance.Options.UseTextOptions = True
        Me.mode.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.mode.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.mode.Properties.Mask.BeepOnError = True
        Me.mode.Properties.ReadOnly = True
        Me.mode.Size = New System.Drawing.Size(39, 20)
        Me.mode.TabIndex = 839
        Me.mode.Visible = False
        '
        'id
        '
        Me.id.EditValue = ""
        Me.id.Location = New System.Drawing.Point(455, 126)
        Me.id.Name = "id"
        Me.id.Properties.Appearance.Options.UseTextOptions = True
        Me.id.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.id.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.id.Properties.Mask.BeepOnError = True
        Me.id.Properties.ReadOnly = True
        Me.id.Size = New System.Drawing.Size(39, 20)
        Me.id.TabIndex = 838
        Me.id.Visible = False
        '
        'frmVoucherItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(506, 164)
        Me.Controls.Add(Me.voucherno)
        Me.Controls.Add(Me.mode)
        Me.Controls.Add(Me.id)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.txtExplaination)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmVoucherItem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Disbursement Item"
        CType(Me.txtAmount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtExplaination.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.voucherno.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.id.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtAmount As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtExplaination As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents voucherno As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents mode As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents id As DevExpress.XtraEditors.ButtonEdit
End Class
