<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCollectionInputAmount
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCollectionInputAmount))
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.cmdSaveButton = New DevExpress.XtraEditors.SimpleButton()
        Me.trncode = New DevExpress.XtraEditors.TextEdit()
        Me.grpTitle = New System.Windows.Forms.GroupBox()
        Me.txtAmount = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.glitemcode = New DevExpress.XtraEditors.TextEdit()
        Me.txtCollectionName = New DevExpress.XtraEditors.TextEdit()
        Me.txtExplaination = New DevExpress.XtraEditors.TextEdit()
        Me.glitemname = New DevExpress.XtraEditors.TextEdit()
        CType(Me.trncode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpTitle.SuspendLayout()
        CType(Me.txtAmount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.glitemcode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCollectionName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtExplaination.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.glitemname.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.Location = New System.Drawing.Point(78, 61)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(45, 17)
        Me.LabelControl5.TabIndex = 656
        Me.LabelControl5.Text = "Amount"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(6, 28)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(117, 17)
        Me.LabelControl3.TabIndex = 654
        Me.LabelControl3.Text = "Nature of Collection"
        '
        'cmdSaveButton
        '
        Me.cmdSaveButton.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdSaveButton.Appearance.BackColor2 = System.Drawing.Color.Khaki
        Me.cmdSaveButton.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSaveButton.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.cmdSaveButton.Appearance.Options.UseBackColor = True
        Me.cmdSaveButton.Appearance.Options.UseFont = True
        Me.cmdSaveButton.Location = New System.Drawing.Point(131, 122)
        Me.cmdSaveButton.Name = "cmdSaveButton"
        Me.cmdSaveButton.Size = New System.Drawing.Size(168, 38)
        Me.cmdSaveButton.TabIndex = 2
        Me.cmdSaveButton.Text = "Confirm Post"
        '
        'trncode
        '
        Me.trncode.Location = New System.Drawing.Point(610, 24)
        Me.trncode.Name = "trncode"
        Me.trncode.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.trncode.Properties.Appearance.Options.UseFont = True
        Me.trncode.Properties.Appearance.Options.UseTextOptions = True
        Me.trncode.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.trncode.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.trncode.Properties.ReadOnly = True
        Me.trncode.Size = New System.Drawing.Size(42, 26)
        Me.trncode.TabIndex = 651
        '
        'grpTitle
        '
        Me.grpTitle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpTitle.Controls.Add(Me.glitemname)
        Me.grpTitle.Controls.Add(Me.txtCollectionName)
        Me.grpTitle.Controls.Add(Me.glitemcode)
        Me.grpTitle.Controls.Add(Me.txtAmount)
        Me.grpTitle.Controls.Add(Me.LabelControl1)
        Me.grpTitle.Controls.Add(Me.trncode)
        Me.grpTitle.Controls.Add(Me.cmdSaveButton)
        Me.grpTitle.Controls.Add(Me.LabelControl5)
        Me.grpTitle.Controls.Add(Me.LabelControl3)
        Me.grpTitle.Controls.Add(Me.txtExplaination)
        Me.grpTitle.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpTitle.Location = New System.Drawing.Point(12, 6)
        Me.grpTitle.Name = "grpTitle"
        Me.grpTitle.Size = New System.Drawing.Size(511, 177)
        Me.grpTitle.TabIndex = 657
        Me.grpTitle.TabStop = False
        '
        'txtAmount
        '
        Me.txtAmount.EditValue = "0"
        Me.txtAmount.Location = New System.Drawing.Point(131, 54)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.txtAmount.Properties.Appearance.Options.UseFont = True
        Me.txtAmount.Properties.Appearance.Options.UseTextOptions = True
        Me.txtAmount.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtAmount.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtAmount.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAmount.Properties.Mask.EditMask = "n"
        Me.txtAmount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtAmount.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtAmount.Properties.MaxLength = 50
        Me.txtAmount.Size = New System.Drawing.Size(175, 32)
        Me.txtAmount.TabIndex = 0
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(53, 92)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(70, 17)
        Me.LabelControl1.TabIndex = 657
        Me.LabelControl1.Text = "Explaination"
        '
        'glitemcode
        '
        Me.glitemcode.Location = New System.Drawing.Point(610, 52)
        Me.glitemcode.Name = "glitemcode"
        Me.glitemcode.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.glitemcode.Properties.Appearance.Options.UseFont = True
        Me.glitemcode.Properties.Appearance.Options.UseTextOptions = True
        Me.glitemcode.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.glitemcode.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.glitemcode.Properties.ReadOnly = True
        Me.glitemcode.Size = New System.Drawing.Size(42, 26)
        Me.glitemcode.TabIndex = 658
        '
        'txtCollectionName
        '
        Me.txtCollectionName.Location = New System.Drawing.Point(131, 24)
        Me.txtCollectionName.Name = "txtCollectionName"
        Me.txtCollectionName.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCollectionName.Properties.Appearance.Options.UseFont = True
        Me.txtCollectionName.Properties.Appearance.Options.UseTextOptions = True
        Me.txtCollectionName.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtCollectionName.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtCollectionName.Properties.ReadOnly = True
        Me.txtCollectionName.Size = New System.Drawing.Size(270, 26)
        Me.txtCollectionName.TabIndex = 659
        '
        'txtExplaination
        '
        Me.txtExplaination.EditValue = ""
        Me.txtExplaination.Location = New System.Drawing.Point(131, 90)
        Me.txtExplaination.Name = "txtExplaination"
        Me.txtExplaination.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtExplaination.Properties.Appearance.Options.UseFont = True
        Me.txtExplaination.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtExplaination.Size = New System.Drawing.Size(364, 26)
        Me.txtExplaination.TabIndex = 1
        '
        'glitemname
        '
        Me.glitemname.Location = New System.Drawing.Point(610, 83)
        Me.glitemname.Name = "glitemname"
        Me.glitemname.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.glitemname.Properties.Appearance.Options.UseFont = True
        Me.glitemname.Properties.Appearance.Options.UseTextOptions = True
        Me.glitemname.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.glitemname.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.glitemname.Properties.ReadOnly = True
        Me.glitemname.Size = New System.Drawing.Size(42, 26)
        Me.glitemname.TabIndex = 660
        '
        'frmCollectionInputAmount
        '
        Me.AcceptButton = Me.cmdSaveButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(535, 195)
        Me.Controls.Add(Me.grpTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmCollectionInputAmount"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transaction Confirmation"
        CType(Me.trncode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpTitle.ResumeLayout(False)
        Me.grpTitle.PerformLayout()
        CType(Me.txtAmount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.glitemcode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCollectionName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtExplaination.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.glitemname.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmdSaveButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents trncode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents grpTitle As System.Windows.Forms.GroupBox
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtAmount As DevExpress.XtraEditors.TextEdit
    Friend WithEvents glitemcode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCollectionName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtExplaination As DevExpress.XtraEditors.TextEdit
    Friend WithEvents glitemname As DevExpress.XtraEditors.TextEdit
End Class
