<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuantitySelect
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmQuantitySelect))
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.productid = New DevExpress.XtraEditors.TextEdit()
        Me.mode = New DevExpress.XtraEditors.TextEdit()
        Me.txtproduct = New DevExpress.XtraEditors.TextEdit()
        Me.cmdaction = New DevExpress.XtraEditors.SimpleButton()
        Me.txtUnit = New DevExpress.XtraEditors.TextEdit()
        Me.txtQuantity = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtUnitPrice = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtTotalCost = New DevExpress.XtraEditors.TextEdit()
        Me.id = New DevExpress.XtraEditors.TextEdit()
        Me.txtRemarks = New DevExpress.XtraEditors.MemoEdit()
        Me.catid = New DevExpress.XtraEditors.TextEdit()
        CType(Me.productid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtproduct.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUnit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQuantity.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUnitPrice.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalCost.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.id.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRemarks.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.catid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl3
        '
        Me.LabelControl3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(51, 11)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(110, 15)
        Me.LabelControl3.TabIndex = 574
        Me.LabelControl3.Text = "Particular item name"
        '
        'productid
        '
        Me.productid.Location = New System.Drawing.Point(103, 275)
        Me.productid.Name = "productid"
        Me.productid.Properties.Appearance.Options.UseFont = True
        Me.productid.Properties.Appearance.Options.UseTextOptions = True
        Me.productid.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.productid.Properties.ReadOnly = True
        Me.productid.Size = New System.Drawing.Size(34, 20)
        Me.productid.TabIndex = 573
        '
        'mode
        '
        Me.mode.Location = New System.Drawing.Point(183, 275)
        Me.mode.Name = "mode"
        Me.mode.Properties.Appearance.Options.UseFont = True
        Me.mode.Properties.Appearance.Options.UseTextOptions = True
        Me.mode.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.mode.Properties.ReadOnly = True
        Me.mode.Size = New System.Drawing.Size(34, 20)
        Me.mode.TabIndex = 572
        '
        'txtproduct
        '
        Me.txtproduct.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtproduct.Location = New System.Drawing.Point(51, 30)
        Me.txtproduct.Name = "txtproduct"
        Me.txtproduct.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold)
        Me.txtproduct.Properties.Appearance.Options.UseFont = True
        Me.txtproduct.Properties.ReadOnly = True
        Me.txtproduct.Size = New System.Drawing.Size(416, 26)
        Me.txtproduct.TabIndex = 570
        '
        'cmdaction
        '
        Me.cmdaction.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdaction.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.cmdaction.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.cmdaction.Appearance.Options.UseFont = True
        Me.cmdaction.Location = New System.Drawing.Point(285, 488)
        Me.cmdaction.Name = "cmdaction"
        Me.cmdaction.Size = New System.Drawing.Size(182, 36)
        Me.cmdaction.TabIndex = 3
        Me.cmdaction.Text = "Add to Current Request"
        '
        'txtUnit
        '
        Me.txtUnit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtUnit.Location = New System.Drawing.Point(371, 61)
        Me.txtUnit.Name = "txtUnit"
        Me.txtUnit.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtUnit.Properties.Appearance.Options.UseFont = True
        Me.txtUnit.Properties.Appearance.Options.UseTextOptions = True
        Me.txtUnit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtUnit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtUnit.Properties.ReadOnly = True
        Me.txtUnit.Size = New System.Drawing.Size(96, 28)
        Me.txtUnit.TabIndex = 565
        '
        'txtQuantity
        '
        Me.txtQuantity.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtQuantity.EditValue = "1"
        Me.txtQuantity.EnterMoveNextControl = True
        Me.txtQuantity.Location = New System.Drawing.Point(285, 61)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtQuantity.Properties.Appearance.Options.UseFont = True
        Me.txtQuantity.Properties.Appearance.Options.UseTextOptions = True
        Me.txtQuantity.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtQuantity.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtQuantity.Properties.Mask.EditMask = "n"
        Me.txtQuantity.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtQuantity.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtQuantity.Size = New System.Drawing.Size(82, 28)
        Me.txtQuantity.TabIndex = 0
        '
        'LabelControl6
        '
        Me.LabelControl6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.LabelControl6.Appearance.Options.UseFont = True
        Me.LabelControl6.Location = New System.Drawing.Point(229, 66)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(48, 17)
        Me.LabelControl6.TabIndex = 566
        Me.LabelControl6.Text = "Quantity"
        '
        'LabelControl1
        '
        Me.LabelControl1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(222, 98)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(55, 17)
        Me.LabelControl1.TabIndex = 567
        Me.LabelControl1.Text = "Unit Price"
        '
        'txtUnitPrice
        '
        Me.txtUnitPrice.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtUnitPrice.EditValue = ""
        Me.txtUnitPrice.Location = New System.Drawing.Point(285, 93)
        Me.txtUnitPrice.Name = "txtUnitPrice"
        Me.txtUnitPrice.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtUnitPrice.Properties.Appearance.Options.UseFont = True
        Me.txtUnitPrice.Properties.Appearance.Options.UseTextOptions = True
        Me.txtUnitPrice.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtUnitPrice.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtUnitPrice.Properties.Mask.EditMask = "n"
        Me.txtUnitPrice.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtUnitPrice.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtUnitPrice.Size = New System.Drawing.Size(182, 28)
        Me.txtUnitPrice.TabIndex = 1
        '
        'LabelControl2
        '
        Me.LabelControl2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(248, 130)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(29, 17)
        Me.LabelControl2.TabIndex = 568
        Me.LabelControl2.Text = "Total"
        '
        'txtTotalCost
        '
        Me.txtTotalCost.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotalCost.EditValue = "0.00"
        Me.txtTotalCost.Location = New System.Drawing.Point(285, 125)
        Me.txtTotalCost.Name = "txtTotalCost"
        Me.txtTotalCost.Properties.Appearance.BackColor = System.Drawing.Color.Yellow
        Me.txtTotalCost.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtTotalCost.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txtTotalCost.Properties.Appearance.Options.UseBackColor = True
        Me.txtTotalCost.Properties.Appearance.Options.UseFont = True
        Me.txtTotalCost.Properties.Appearance.Options.UseForeColor = True
        Me.txtTotalCost.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTotalCost.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtTotalCost.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtTotalCost.Properties.Mask.EditMask = "n"
        Me.txtTotalCost.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtTotalCost.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtTotalCost.Properties.ReadOnly = True
        Me.txtTotalCost.Size = New System.Drawing.Size(182, 28)
        Me.txtTotalCost.TabIndex = 564
        '
        'id
        '
        Me.id.Location = New System.Drawing.Point(143, 275)
        Me.id.Name = "id"
        Me.id.Properties.Appearance.Options.UseFont = True
        Me.id.Properties.Appearance.Options.UseTextOptions = True
        Me.id.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.id.Properties.ReadOnly = True
        Me.id.Size = New System.Drawing.Size(34, 20)
        Me.id.TabIndex = 569
        '
        'txtRemarks
        '
        Me.txtRemarks.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRemarks.EditValue = ""
        Me.txtRemarks.Location = New System.Drawing.Point(51, 159)
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtRemarks.Properties.Appearance.Options.UseFont = True
        Me.txtRemarks.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtRemarks.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtRemarks.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtRemarks.Properties.NullValuePrompt = "Specify transaction remarks. i.e name of person, details, etc"
        Me.txtRemarks.Properties.NullValuePromptShowForEmptyValue = True
        Me.txtRemarks.Size = New System.Drawing.Size(416, 323)
        Me.txtRemarks.TabIndex = 2
        '
        'catid
        '
        Me.catid.Location = New System.Drawing.Point(63, 275)
        Me.catid.Name = "catid"
        Me.catid.Properties.Appearance.Options.UseFont = True
        Me.catid.Properties.Appearance.Options.UseTextOptions = True
        Me.catid.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.catid.Properties.ReadOnly = True
        Me.catid.Size = New System.Drawing.Size(34, 20)
        Me.catid.TabIndex = 930
        '
        'frmQuantitySelect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(506, 551)
        Me.Controls.Add(Me.txtRemarks)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.txtproduct)
        Me.Controls.Add(Me.cmdaction)
        Me.Controls.Add(Me.txtUnit)
        Me.Controls.Add(Me.txtQuantity)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.txtUnitPrice)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.txtTotalCost)
        Me.Controls.Add(Me.catid)
        Me.Controls.Add(Me.productid)
        Me.Controls.Add(Me.mode)
        Me.Controls.Add(Me.id)
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(522, 590)
        Me.Name = "frmQuantitySelect"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Particular item confirmation"
        CType(Me.productid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtproduct.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUnit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQuantity.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUnitPrice.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalCost.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.id.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRemarks.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.catid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents productid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents mode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtproduct As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmdaction As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtUnit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtQuantity As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtUnitPrice As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTotalCost As DevExpress.XtraEditors.TextEdit
    Friend WithEvents id As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtRemarks As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents catid As DevExpress.XtraEditors.TextEdit
End Class
