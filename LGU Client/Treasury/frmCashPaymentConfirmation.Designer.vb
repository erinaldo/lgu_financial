<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCashPaymentConfirmation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCashPaymentConfirmation))
        Me.grpTitle = New System.Windows.Forms.GroupBox()
        Me.trnmode = New DevExpress.XtraEditors.TextEdit()
        Me.cidid = New DevExpress.XtraEditors.TextEdit()
        Me.cmdCheckPrinter = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.fundcode = New DevExpress.XtraEditors.TextEdit()
        Me.txtORnumber = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtPaymentChange = New DevExpress.XtraEditors.TextEdit()
        Me.txtEnterPayment = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txTotalOnScreen = New DevExpress.XtraEditors.TextEdit()
        Me.grpTitle.SuspendLayout()
        CType(Me.trnmode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cidid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fundcode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtORnumber.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPaymentChange.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEnterPayment.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txTotalOnScreen.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpTitle
        '
        Me.grpTitle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpTitle.Controls.Add(Me.trnmode)
        Me.grpTitle.Controls.Add(Me.cidid)
        Me.grpTitle.Controls.Add(Me.cmdCheckPrinter)
        Me.grpTitle.Controls.Add(Me.LabelControl4)
        Me.grpTitle.Controls.Add(Me.fundcode)
        Me.grpTitle.Controls.Add(Me.txtORnumber)
        Me.grpTitle.Controls.Add(Me.LabelControl2)
        Me.grpTitle.Controls.Add(Me.LabelControl1)
        Me.grpTitle.Controls.Add(Me.txtPaymentChange)
        Me.grpTitle.Controls.Add(Me.txtEnterPayment)
        Me.grpTitle.Controls.Add(Me.LabelControl3)
        Me.grpTitle.Controls.Add(Me.txTotalOnScreen)
        Me.grpTitle.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpTitle.Location = New System.Drawing.Point(12, 6)
        Me.grpTitle.Name = "grpTitle"
        Me.grpTitle.Size = New System.Drawing.Size(503, 403)
        Me.grpTitle.TabIndex = 0
        Me.grpTitle.TabStop = False
        Me.grpTitle.Text = "Cash Payment Confirmation"
        '
        'trnmode
        '
        Me.trnmode.EditValue = ""
        Me.trnmode.EnterMoveNextControl = True
        Me.trnmode.Location = New System.Drawing.Point(635, 189)
        Me.trnmode.Name = "trnmode"
        Me.trnmode.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.trnmode.Properties.Appearance.Options.UseFont = True
        Me.trnmode.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.trnmode.Properties.MaxLength = 50
        Me.trnmode.Properties.ReadOnly = True
        Me.trnmode.Size = New System.Drawing.Size(45, 24)
        Me.trnmode.TabIndex = 833
        Me.trnmode.Visible = False
        '
        'cidid
        '
        Me.cidid.EditValue = ""
        Me.cidid.EnterMoveNextControl = True
        Me.cidid.Location = New System.Drawing.Point(849, 168)
        Me.cidid.Name = "cidid"
        Me.cidid.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.cidid.Properties.Appearance.Options.UseFont = True
        Me.cidid.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cidid.Properties.MaxLength = 50
        Me.cidid.Properties.ReadOnly = True
        Me.cidid.Size = New System.Drawing.Size(45, 24)
        Me.cidid.TabIndex = 832
        Me.cidid.Visible = False
        '
        'cmdCheckPrinter
        '
        Me.cmdCheckPrinter.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.cmdCheckPrinter.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdCheckPrinter.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCheckPrinter.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.cmdCheckPrinter.Appearance.Options.UseBackColor = True
        Me.cmdCheckPrinter.Appearance.Options.UseFont = True
        Me.cmdCheckPrinter.ImageOptions.Image = Global.LGUClient.My.Resources.Resources.DefaultPrinter_32x32
        Me.cmdCheckPrinter.Location = New System.Drawing.Point(88, 342)
        Me.cmdCheckPrinter.Name = "cmdCheckPrinter"
        Me.cmdCheckPrinter.Size = New System.Drawing.Size(319, 38)
        Me.cmdCheckPrinter.TabIndex = 1
        Me.cmdCheckPrinter.Text = "Confirm Print Receipt and Proceed Payment"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Location = New System.Drawing.Point(60, 27)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(383, 17)
        Me.LabelControl4.TabIndex = 829
        Me.LabelControl4.Text = "Please enter payment amount more than total transaction amount"
        '
        'fundcode
        '
        Me.fundcode.EditValue = ""
        Me.fundcode.EnterMoveNextControl = True
        Me.fundcode.Location = New System.Drawing.Point(849, 138)
        Me.fundcode.Name = "fundcode"
        Me.fundcode.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.fundcode.Properties.Appearance.Options.UseFont = True
        Me.fundcode.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.fundcode.Properties.MaxLength = 50
        Me.fundcode.Properties.ReadOnly = True
        Me.fundcode.Size = New System.Drawing.Size(45, 24)
        Me.fundcode.TabIndex = 830
        Me.fundcode.Visible = False
        '
        'txtORnumber
        '
        Me.txtORnumber.EditValue = ""
        Me.txtORnumber.EnterMoveNextControl = True
        Me.txtORnumber.Location = New System.Drawing.Point(52, 50)
        Me.txtORnumber.Name = "txtORnumber"
        Me.txtORnumber.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 15.75!)
        Me.txtORnumber.Properties.Appearance.Options.UseFont = True
        Me.txtORnumber.Properties.Appearance.Options.UseTextOptions = True
        Me.txtORnumber.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtORnumber.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtORnumber.Properties.MaxLength = 50
        Me.txtORnumber.Properties.ReadOnly = True
        Me.txtORnumber.Size = New System.Drawing.Size(398, 38)
        Me.txtORnumber.TabIndex = 828
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(52, 257)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(97, 17)
        Me.LabelControl2.TabIndex = 659
        Me.LabelControl2.Text = "Payment Change"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(52, 174)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(83, 17)
        Me.LabelControl1.TabIndex = 658
        Me.LabelControl1.Text = "Enter Payment"
        '
        'txtPaymentChange
        '
        Me.txtPaymentChange.EditValue = "0"
        Me.txtPaymentChange.Location = New System.Drawing.Point(52, 276)
        Me.txtPaymentChange.Name = "txtPaymentChange"
        Me.txtPaymentChange.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPaymentChange.Properties.Appearance.Options.UseFont = True
        Me.txtPaymentChange.Properties.Appearance.Options.UseTextOptions = True
        Me.txtPaymentChange.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtPaymentChange.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtPaymentChange.Properties.Mask.EditMask = "n"
        Me.txtPaymentChange.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtPaymentChange.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtPaymentChange.Properties.MaxLength = 50
        Me.txtPaymentChange.Properties.ReadOnly = True
        Me.txtPaymentChange.Size = New System.Drawing.Size(398, 58)
        Me.txtPaymentChange.TabIndex = 657
        '
        'txtEnterPayment
        '
        Me.txtEnterPayment.EditValue = "0"
        Me.txtEnterPayment.Location = New System.Drawing.Point(52, 195)
        Me.txtEnterPayment.Name = "txtEnterPayment"
        Me.txtEnterPayment.Properties.Appearance.BackColor = System.Drawing.Color.Yellow
        Me.txtEnterPayment.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEnterPayment.Properties.Appearance.Options.UseBackColor = True
        Me.txtEnterPayment.Properties.Appearance.Options.UseFont = True
        Me.txtEnterPayment.Properties.Appearance.Options.UseTextOptions = True
        Me.txtEnterPayment.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtEnterPayment.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtEnterPayment.Properties.Mask.EditMask = "n"
        Me.txtEnterPayment.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtEnterPayment.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtEnterPayment.Properties.MaxLength = 50
        Me.txtEnterPayment.Size = New System.Drawing.Size(398, 58)
        Me.txtEnterPayment.TabIndex = 0
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(52, 92)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(97, 17)
        Me.LabelControl3.TabIndex = 655
        Me.LabelControl3.Text = "Total transaction"
        '
        'txTotalOnScreen
        '
        Me.txTotalOnScreen.EditValue = "0"
        Me.txTotalOnScreen.Location = New System.Drawing.Point(52, 112)
        Me.txTotalOnScreen.Name = "txTotalOnScreen"
        Me.txTotalOnScreen.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txTotalOnScreen.Properties.Appearance.Options.UseFont = True
        Me.txTotalOnScreen.Properties.Appearance.Options.UseTextOptions = True
        Me.txTotalOnScreen.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txTotalOnScreen.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txTotalOnScreen.Properties.Mask.EditMask = "n"
        Me.txTotalOnScreen.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txTotalOnScreen.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txTotalOnScreen.Properties.MaxLength = 50
        Me.txTotalOnScreen.Properties.ReadOnly = True
        Me.txTotalOnScreen.Size = New System.Drawing.Size(398, 58)
        Me.txTotalOnScreen.TabIndex = 0
        '
        'frmCashPaymentConfirmation
        '
        Me.AcceptButton = Me.cmdCheckPrinter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(527, 421)
        Me.Controls.Add(Me.grpTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmCashPaymentConfirmation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cash Payment Confirmation"
        Me.grpTitle.ResumeLayout(False)
        Me.grpTitle.PerformLayout()
        CType(Me.trnmode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cidid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fundcode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtORnumber.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPaymentChange.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEnterPayment.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txTotalOnScreen.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpTitle As System.Windows.Forms.GroupBox
    Friend WithEvents txTotalOnScreen As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPaymentChange As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtORnumber As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmdCheckPrinter As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtEnterPayment As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cidid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents fundcode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents trnmode As DevExpress.XtraEditors.TextEdit
End Class
