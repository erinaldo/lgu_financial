<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRequisitionFundReturnAmount
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
        Me.cmdaction = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtAmount = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtAccountTitle = New DevExpress.XtraEditors.MemoEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtRequestedAmount = New DevExpress.XtraEditors.TextEdit()
        CType(Me.txtAmount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAccountTitle.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRequestedAmount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdaction
        '
        Me.cmdaction.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdaction.Appearance.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmdaction.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.cmdaction.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.cmdaction.Appearance.Options.UseBackColor = True
        Me.cmdaction.Appearance.Options.UseFont = True
        Me.cmdaction.Location = New System.Drawing.Point(168, 146)
        Me.cmdaction.Name = "cmdaction"
        Me.cmdaction.Size = New System.Drawing.Size(182, 35)
        Me.cmdaction.TabIndex = 3
        Me.cmdaction.Text = "Save"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(74, 119)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(87, 17)
        Me.LabelControl1.TabIndex = 567
        Me.LabelControl1.Text = "Return Amount"
        '
        'txtAmount
        '
        Me.txtAmount.EditValue = "0"
        Me.txtAmount.Location = New System.Drawing.Point(168, 114)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtAmount.Properties.Appearance.Options.UseFont = True
        Me.txtAmount.Properties.Appearance.Options.UseTextOptions = True
        Me.txtAmount.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtAmount.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtAmount.Properties.Mask.EditMask = "n"
        Me.txtAmount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtAmount.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtAmount.Properties.NullText = "0"
        Me.txtAmount.Size = New System.Drawing.Size(182, 28)
        Me.txtAmount.TabIndex = 0
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(30, 6)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(88, 17)
        Me.LabelControl2.TabIndex = 569
        Me.LabelControl2.Text = "Source of Fund"
        '
        'txtAccountTitle
        '
        Me.txtAccountTitle.EditValue = ""
        Me.txtAccountTitle.Location = New System.Drawing.Point(28, 27)
        Me.txtAccountTitle.Name = "txtAccountTitle"
        Me.txtAccountTitle.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtAccountTitle.Properties.Appearance.Options.UseFont = True
        Me.txtAccountTitle.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtAccountTitle.Properties.MaxLength = 50
        Me.txtAccountTitle.Properties.NullValuePrompt = "Enter any keyword to search"
        Me.txtAccountTitle.Properties.ReadOnly = True
        Me.txtAccountTitle.Size = New System.Drawing.Size(322, 53)
        Me.txtAccountTitle.TabIndex = 568
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(54, 88)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(107, 17)
        Me.LabelControl3.TabIndex = 571
        Me.LabelControl3.Text = "Obligated Amount"
        '
        'txtRequestedAmount
        '
        Me.txtRequestedAmount.EditValue = "0"
        Me.txtRequestedAmount.Location = New System.Drawing.Point(168, 83)
        Me.txtRequestedAmount.Name = "txtRequestedAmount"
        Me.txtRequestedAmount.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtRequestedAmount.Properties.Appearance.Options.UseFont = True
        Me.txtRequestedAmount.Properties.Appearance.Options.UseTextOptions = True
        Me.txtRequestedAmount.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtRequestedAmount.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtRequestedAmount.Properties.Mask.EditMask = "n"
        Me.txtRequestedAmount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtRequestedAmount.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtRequestedAmount.Properties.NullText = "0"
        Me.txtRequestedAmount.Properties.ReadOnly = True
        Me.txtRequestedAmount.Size = New System.Drawing.Size(182, 28)
        Me.txtRequestedAmount.TabIndex = 570
        '
        'frmRequisitionReturnAmount
        '
        Me.AcceptButton = Me.cmdaction
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(389, 199)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.txtRequestedAmount)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.cmdaction)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.txtAccountTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRequisitionReturnAmount"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Return Amount"
        CType(Me.txtAmount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAccountTitle.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRequestedAmount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdaction As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtAmount As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtAccountTitle As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtRequestedAmount As DevExpress.XtraEditors.TextEdit
End Class
