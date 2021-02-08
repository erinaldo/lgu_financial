<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmVoucherCheckInfo
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
        Me.txtCheckDate = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtCheckBankName = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtCheckNo = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl15 = New DevExpress.XtraEditors.LabelControl()
        Me.voucherno = New DevExpress.XtraEditors.TextEdit()
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton()
        Me.id = New DevExpress.XtraEditors.TextEdit()
        CType(Me.txtCheckDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCheckDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCheckBankName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCheckNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.voucherno.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.id.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtCheckDate
        '
        Me.txtCheckDate.EditValue = Nothing
        Me.txtCheckDate.EnterMoveNextControl = True
        Me.txtCheckDate.Location = New System.Drawing.Point(145, 99)
        Me.txtCheckDate.Name = "txtCheckDate"
        Me.txtCheckDate.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtCheckDate.Properties.Appearance.Options.UseFont = True
        Me.txtCheckDate.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCheckDate.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtCheckDate.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtCheckDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtCheckDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtCheckDate.Properties.Mask.EditMask = "MMMM dd, yyyy"
        Me.txtCheckDate.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtCheckDate.Size = New System.Drawing.Size(149, 26)
        Me.txtCheckDate.TabIndex = 1002
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.Location = New System.Drawing.Point(71, 102)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(65, 17)
        Me.LabelControl5.TabIndex = 1001
        Me.LabelControl5.Text = "Check Date"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(71, 75)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(66, 17)
        Me.LabelControl1.TabIndex = 1000
        Me.LabelControl1.Text = "Bank Name"
        '
        'txtCheckBankName
        '
        Me.txtCheckBankName.EditValue = ""
        Me.txtCheckBankName.Location = New System.Drawing.Point(145, 71)
        Me.txtCheckBankName.Name = "txtCheckBankName"
        Me.txtCheckBankName.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtCheckBankName.Properties.Appearance.Options.UseFont = True
        Me.txtCheckBankName.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCheckBankName.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtCheckBankName.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtCheckBankName.Size = New System.Drawing.Size(232, 26)
        Me.txtCheckBankName.TabIndex = 998
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(77, 47)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(59, 17)
        Me.LabelControl2.TabIndex = 999
        Me.LabelControl2.Text = "Check No."
        '
        'txtCheckNo
        '
        Me.txtCheckNo.EditValue = ""
        Me.txtCheckNo.Location = New System.Drawing.Point(145, 43)
        Me.txtCheckNo.Name = "txtCheckNo"
        Me.txtCheckNo.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtCheckNo.Properties.Appearance.Options.UseFont = True
        Me.txtCheckNo.Properties.Appearance.Options.UseTextOptions = True
        Me.txtCheckNo.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtCheckNo.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCheckNo.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtCheckNo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtCheckNo.Size = New System.Drawing.Size(149, 26)
        Me.txtCheckNo.TabIndex = 997
        '
        'LabelControl15
        '
        Me.LabelControl15.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.LabelControl15.Appearance.Options.UseFont = True
        Me.LabelControl15.Appearance.Options.UseTextOptions = True
        Me.LabelControl15.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl15.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.LabelControl15.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal
        Me.LabelControl15.Location = New System.Drawing.Point(94, 20)
        Me.LabelControl15.Name = "LabelControl15"
        Me.LabelControl15.Size = New System.Drawing.Size(42, 17)
        Me.LabelControl15.TabIndex = 1004
        Me.LabelControl15.Text = "DV No."
        '
        'voucherno
        '
        Me.voucherno.EditValue = ""
        Me.voucherno.EnterMoveNextControl = True
        Me.voucherno.Location = New System.Drawing.Point(145, 17)
        Me.voucherno.Name = "voucherno"
        Me.voucherno.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.voucherno.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.voucherno.Properties.Appearance.Options.UseFont = True
        Me.voucherno.Properties.Appearance.Options.UseForeColor = True
        Me.voucherno.Properties.Appearance.Options.UseTextOptions = True
        Me.voucherno.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.voucherno.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.voucherno.Properties.ReadOnly = True
        Me.voucherno.Size = New System.Drawing.Size(149, 24)
        Me.voucherno.TabIndex = 1003
        '
        'cmdSave
        '
        Me.cmdSave.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmdSave.Appearance.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmdSave.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.cmdSave.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.cmdSave.Appearance.Options.UseBackColor = True
        Me.cmdSave.Appearance.Options.UseFont = True
        Me.cmdSave.Location = New System.Drawing.Point(145, 128)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(149, 34)
        Me.cmdSave.TabIndex = 1005
        Me.cmdSave.Text = "Confirm"
        '
        'id
        '
        Me.id.EditValue = ""
        Me.id.Location = New System.Drawing.Point(459, 142)
        Me.id.Name = "id"
        Me.id.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.id.Properties.Appearance.Options.UseFont = True
        Me.id.Properties.Appearance.Options.UseTextOptions = True
        Me.id.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.id.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.id.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.id.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.id.Size = New System.Drawing.Size(35, 26)
        Me.id.TabIndex = 1006
        Me.id.Visible = False
        '
        'frmVoucherCheckInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(506, 180)
        Me.Controls.Add(Me.id)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.LabelControl15)
        Me.Controls.Add(Me.voucherno)
        Me.Controls.Add(Me.txtCheckDate)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.txtCheckBankName)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.txtCheckNo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmVoucherCheckInfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Disbursement Check Info"
        CType(Me.txtCheckDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCheckDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCheckBankName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCheckNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.voucherno.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.id.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtCheckDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCheckBankName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCheckNo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl15 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents voucherno As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents id As DevExpress.XtraEditors.TextEdit
End Class
