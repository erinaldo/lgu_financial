<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProductItem
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProductItem))
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.productid = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtUnit = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.HyperlinkLabelControl1 = New DevExpress.XtraEditors.HyperlinkLabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.cmdCategory = New DevExpress.XtraEditors.HyperlinkLabelControl()
        Me.cmdClassification = New DevExpress.XtraEditors.HyperlinkLabelControl()
        Me.ckpooption = New DevExpress.XtraEditors.RadioGroup()
        Me.txtClassification = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.gridClass = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.txtCategory = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.gridcategory = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.code = New DevExpress.XtraEditors.TextEdit()
        Me.txtDescription = New DevExpress.XtraEditors.TextEdit()
        Me.cmdSaveButton = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.mode = New DevExpress.XtraEditors.TextEdit()
        CType(Me.productid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUnit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ckpooption.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtClassification.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridClass, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCategory.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridcategory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.code.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescription.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.SimpleButton1.Appearance.BackColor2 = System.Drawing.Color.Khaki
        Me.SimpleButton1.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton1.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.SimpleButton1.Appearance.Options.UseBackColor = True
        Me.SimpleButton1.Appearance.Options.UseFont = True
        Me.SimpleButton1.Location = New System.Drawing.Point(341, 267)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(119, 34)
        Me.SimpleButton1.TabIndex = 665
        Me.SimpleButton1.Text = "Exit Form"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Location = New System.Drawing.Point(88, 26)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(60, 17)
        Me.LabelControl4.TabIndex = 678
        Me.LabelControl4.Text = "Item Code"
        '
        'productid
        '
        Me.productid.EditValue = "SYSTEM GENERATED"
        Me.productid.Location = New System.Drawing.Point(157, 23)
        Me.productid.Name = "productid"
        Me.productid.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.productid.Properties.Appearance.Options.UseFont = True
        Me.productid.Properties.Appearance.Options.UseTextOptions = True
        Me.productid.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.productid.Properties.ReadOnly = True
        Me.productid.Size = New System.Drawing.Size(178, 24)
        Me.productid.TabIndex = 677
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Italic)
        Me.LabelControl3.Appearance.ForeColor = System.Drawing.Color.Gray
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Appearance.Options.UseForeColor = True
        Me.LabelControl3.Location = New System.Drawing.Point(263, 110)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(107, 13)
        Me.LabelControl3.TabIndex = 676
        Me.LabelControl3.Text = "i.e pcs, box, bottle, unit"
        '
        'txtUnit
        '
        Me.txtUnit.Location = New System.Drawing.Point(157, 104)
        Me.txtUnit.Name = "txtUnit"
        Me.txtUnit.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtUnit.Properties.Appearance.Options.UseFont = True
        Me.txtUnit.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtUnit.Properties.AppearanceDropDown.Options.UseFont = True
        Me.txtUnit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtUnit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.txtUnit.Size = New System.Drawing.Size(100, 24)
        Me.txtUnit.TabIndex = 661
        '
        'HyperlinkLabelControl1
        '
        Me.HyperlinkLabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.HyperlinkLabelControl1.Appearance.Options.UseFont = True
        Me.HyperlinkLabelControl1.Location = New System.Drawing.Point(41, 107)
        Me.HyperlinkLabelControl1.Name = "HyperlinkLabelControl1"
        Me.HyperlinkLabelControl1.Size = New System.Drawing.Size(107, 17)
        Me.HyperlinkLabelControl1.TabIndex = 675
        Me.HyperlinkLabelControl1.Text = "Unit Measurement"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Italic)
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.Gray
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseForeColor = True
        Me.LabelControl1.Location = New System.Drawing.Point(157, 83)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(303, 13)
        Me.LabelControl1.TabIndex = 674
        Me.LabelControl1.Text = "Particular name with brand name and unit mesaurement, model"
        '
        'cmdCategory
        '
        Me.cmdCategory.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.cmdCategory.Appearance.Options.UseFont = True
        Me.cmdCategory.Location = New System.Drawing.Point(57, 134)
        Me.cmdCategory.Name = "cmdCategory"
        Me.cmdCategory.Size = New System.Drawing.Size(91, 17)
        Me.cmdCategory.TabIndex = 673
        Me.cmdCategory.Text = "Select Category"
        '
        'cmdClassification
        '
        Me.cmdClassification.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.cmdClassification.Appearance.Options.UseFont = True
        Me.cmdClassification.Location = New System.Drawing.Point(35, 161)
        Me.cmdClassification.Name = "cmdClassification"
        Me.cmdClassification.Size = New System.Drawing.Size(113, 17)
        Me.cmdClassification.TabIndex = 672
        Me.cmdClassification.Text = "Select Classification"
        '
        'ckpooption
        '
        Me.ckpooption.Location = New System.Drawing.Point(157, 186)
        Me.ckpooption.Name = "ckpooption"
        Me.ckpooption.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.ckpooption.Properties.Appearance.Options.UseFont = True
        Me.ckpooption.Properties.Appearance.Options.UseTextOptions = True
        Me.ckpooption.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.ckpooption.Properties.Columns = 1
        Me.ckpooption.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(CType(0, Short), "Non-Inventory Item (i.e Services, Billings and Payables)"), New DevExpress.XtraEditors.Controls.RadioGroupItem(CType(1, Short), "Consumable (i.e. Direct Cost, Office Supplies and Raw Materials)"), New DevExpress.XtraEditors.Controls.RadioGroupItem(CType(2, Short), "PPE (i.e. Property, Plan and Equipment )")})
        Me.ckpooption.Properties.ReadOnly = True
        Me.ckpooption.Size = New System.Drawing.Size(378, 75)
        Me.ckpooption.TabIndex = 671
        '
        'txtClassification
        '
        Me.txtClassification.EditValue = ""
        Me.txtClassification.Location = New System.Drawing.Point(157, 158)
        Me.txtClassification.Name = "txtClassification"
        Me.txtClassification.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtClassification.Properties.Appearance.Options.UseFont = True
        Me.txtClassification.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtClassification.Properties.DisplayMember = "Select"
        Me.txtClassification.Properties.NullText = ""
        Me.txtClassification.Properties.PopupView = Me.gridClass
        Me.txtClassification.Properties.ValueMember = "code"
        Me.txtClassification.Size = New System.Drawing.Size(284, 24)
        Me.txtClassification.TabIndex = 663
        '
        'gridClass
        '
        Me.gridClass.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gridClass.Name = "gridClass"
        Me.gridClass.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridClass.OptionsView.ShowGroupPanel = False
        '
        'txtCategory
        '
        Me.txtCategory.EditValue = ""
        Me.txtCategory.Location = New System.Drawing.Point(157, 131)
        Me.txtCategory.Name = "txtCategory"
        Me.txtCategory.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtCategory.Properties.Appearance.Options.UseFont = True
        Me.txtCategory.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtCategory.Properties.DisplayMember = "Select"
        Me.txtCategory.Properties.NullText = ""
        Me.txtCategory.Properties.PopupView = Me.gridcategory
        Me.txtCategory.Properties.ValueMember = "code"
        Me.txtCategory.Size = New System.Drawing.Size(284, 24)
        Me.txtCategory.TabIndex = 662
        '
        'gridcategory
        '
        Me.gridcategory.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gridcategory.Name = "gridcategory"
        Me.gridcategory.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridcategory.OptionsView.ShowGroupPanel = False
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
        'txtDescription
        '
        Me.txtDescription.EditValue = ""
        Me.txtDescription.Location = New System.Drawing.Point(157, 52)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.75!)
        Me.txtDescription.Properties.Appearance.Options.UseFont = True
        Me.txtDescription.Size = New System.Drawing.Size(378, 26)
        Me.txtDescription.TabIndex = 660
        '
        'cmdSaveButton
        '
        Me.cmdSaveButton.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdSaveButton.Appearance.BackColor2 = System.Drawing.Color.Khaki
        Me.cmdSaveButton.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSaveButton.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.cmdSaveButton.Appearance.Options.UseBackColor = True
        Me.cmdSaveButton.Appearance.Options.UseFont = True
        Me.cmdSaveButton.Location = New System.Drawing.Point(157, 267)
        Me.cmdSaveButton.Name = "cmdSaveButton"
        Me.cmdSaveButton.Size = New System.Drawing.Size(178, 34)
        Me.cmdSaveButton.TabIndex = 664
        Me.cmdSaveButton.Text = "Save Information"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(84, 56)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(64, 17)
        Me.LabelControl2.TabIndex = 666
        Me.LabelControl2.Text = "Item Name"
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
        'frmProductItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(596, 326)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.productid)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.txtUnit)
        Me.Controls.Add(Me.HyperlinkLabelControl1)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.cmdCategory)
        Me.Controls.Add(Me.cmdClassification)
        Me.Controls.Add(Me.ckpooption)
        Me.Controls.Add(Me.txtClassification)
        Me.Controls.Add(Me.txtCategory)
        Me.Controls.Add(Me.code)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.cmdSaveButton)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.mode)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(612, 365)
        Me.Name = "frmProductItem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transaction Item Information"
        CType(Me.productid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUnit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ckpooption.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtClassification.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridClass, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCategory.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridcategory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.code.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescription.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents productid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtUnit As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents HyperlinkLabelControl1 As DevExpress.XtraEditors.HyperlinkLabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmdCategory As DevExpress.XtraEditors.HyperlinkLabelControl
    Friend WithEvents cmdClassification As DevExpress.XtraEditors.HyperlinkLabelControl
    Friend WithEvents ckpooption As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents txtClassification As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents gridClass As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtCategory As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents gridcategory As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents code As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDescription As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmdSaveButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents mode As DevExpress.XtraEditors.TextEdit
End Class
