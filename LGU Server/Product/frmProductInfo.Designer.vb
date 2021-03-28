<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProductInfo
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
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.mode = New DevExpress.XtraEditors.TextEdit()
        Me.cmdSaveButton = New DevExpress.XtraEditors.SimpleButton()
        Me.txtDescription = New DevExpress.XtraEditors.TextEdit()
        Me.code = New DevExpress.XtraEditors.TextEdit()
        Me.txtCategory = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.gridcategory = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.categorycode = New DevExpress.XtraEditors.TextEdit()
        Me.ckpooption = New DevExpress.XtraEditors.RadioGroup()
        Me.cmdCategory = New DevExpress.XtraEditors.HyperlinkLabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.HyperlinkLabelControl1 = New DevExpress.XtraEditors.HyperlinkLabelControl()
        Me.txtUnit = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.productid = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.mode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescription.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.code.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCategory.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridcategory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.categorycode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ckpooption.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUnit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.productid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(84, 57)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(64, 17)
        Me.LabelControl2.TabIndex = 507
        Me.LabelControl2.Text = "Item Name"
        '
        'mode
        '
        Me.mode.Location = New System.Drawing.Point(669, 53)
        Me.mode.Name = "mode"
        Me.mode.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mode.Properties.Appearance.Options.UseFont = True
        Me.mode.Properties.Appearance.Options.UseTextOptions = True
        Me.mode.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.mode.Properties.ReadOnly = True
        Me.mode.Size = New System.Drawing.Size(77, 24)
        Me.mode.TabIndex = 508
        Me.mode.Visible = False
        '
        'cmdSaveButton
        '
        Me.cmdSaveButton.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdSaveButton.Appearance.BackColor2 = System.Drawing.Color.Khaki
        Me.cmdSaveButton.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSaveButton.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.cmdSaveButton.Appearance.Options.UseBackColor = True
        Me.cmdSaveButton.Appearance.Options.UseFont = True
        Me.cmdSaveButton.Location = New System.Drawing.Point(155, 241)
        Me.cmdSaveButton.Name = "cmdSaveButton"
        Me.cmdSaveButton.Size = New System.Drawing.Size(178, 34)
        Me.cmdSaveButton.TabIndex = 4
        Me.cmdSaveButton.Text = "Save Information"
        '
        'txtDescription
        '
        Me.txtDescription.EditValue = ""
        Me.txtDescription.Location = New System.Drawing.Point(155, 53)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.75!)
        Me.txtDescription.Properties.Appearance.Options.UseFont = True
        Me.txtDescription.Size = New System.Drawing.Size(378, 26)
        Me.txtDescription.TabIndex = 0
        '
        'code
        '
        Me.code.EditValue = ""
        Me.code.Enabled = False
        Me.code.Location = New System.Drawing.Point(752, 53)
        Me.code.Name = "code"
        Me.code.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.code.Properties.Appearance.Options.UseFont = True
        Me.code.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.code.Properties.ReadOnly = True
        Me.code.Size = New System.Drawing.Size(85, 24)
        Me.code.TabIndex = 629
        Me.code.Visible = False
        '
        'txtCategory
        '
        Me.txtCategory.EditValue = ""
        Me.txtCategory.Location = New System.Drawing.Point(155, 132)
        Me.txtCategory.Name = "txtCategory"
        Me.txtCategory.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtCategory.Properties.Appearance.Options.UseFont = True
        Me.txtCategory.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtCategory.Properties.DisplayMember = "Select"
        Me.txtCategory.Properties.NullText = ""
        Me.txtCategory.Properties.PopupView = Me.gridcategory
        Me.txtCategory.Properties.ValueMember = "code"
        Me.txtCategory.Size = New System.Drawing.Size(284, 24)
        Me.txtCategory.TabIndex = 2
        '
        'gridcategory
        '
        Me.gridcategory.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gridcategory.Name = "gridcategory"
        Me.gridcategory.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridcategory.OptionsView.ShowGroupPanel = False
        '
        'categorycode
        '
        Me.categorycode.EditValue = ""
        Me.categorycode.Enabled = False
        Me.categorycode.Location = New System.Drawing.Point(752, 83)
        Me.categorycode.Name = "categorycode"
        Me.categorycode.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.categorycode.Properties.Appearance.Options.UseFont = True
        Me.categorycode.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.categorycode.Properties.ReadOnly = True
        Me.categorycode.Size = New System.Drawing.Size(85, 24)
        Me.categorycode.TabIndex = 647
        Me.categorycode.Visible = False
        '
        'ckpooption
        '
        Me.ckpooption.Location = New System.Drawing.Point(155, 160)
        Me.ckpooption.Name = "ckpooption"
        Me.ckpooption.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.ckpooption.Properties.Appearance.Options.UseFont = True
        Me.ckpooption.Properties.Appearance.Options.UseTextOptions = True
        Me.ckpooption.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.ckpooption.Properties.Columns = 1
        Me.ckpooption.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(CType(0, Short), "Non-Inventory Item (i.e Services, Billings and Payables)"), New DevExpress.XtraEditors.Controls.RadioGroupItem(CType(1, Short), "Consumable (i.e. Direct Cost, Office Supplies and Raw Materials)"), New DevExpress.XtraEditors.Controls.RadioGroupItem(CType(2, Short), "PPE (i.e. Property, Plan and Equipment )")})
        Me.ckpooption.Properties.ReadOnly = True
        Me.ckpooption.Size = New System.Drawing.Size(378, 75)
        Me.ckpooption.TabIndex = 651
        '
        'cmdCategory
        '
        Me.cmdCategory.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.cmdCategory.Appearance.Options.UseFont = True
        Me.cmdCategory.Location = New System.Drawing.Point(57, 135)
        Me.cmdCategory.Name = "cmdCategory"
        Me.cmdCategory.Size = New System.Drawing.Size(91, 17)
        Me.cmdCategory.TabIndex = 653
        Me.cmdCategory.Text = "Select Category"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Italic)
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.Gray
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseForeColor = True
        Me.LabelControl1.Location = New System.Drawing.Point(155, 84)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(303, 13)
        Me.LabelControl1.TabIndex = 654
        Me.LabelControl1.Text = "Particular name with brand name and unit mesaurement, model"
        '
        'HyperlinkLabelControl1
        '
        Me.HyperlinkLabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.HyperlinkLabelControl1.Appearance.Options.UseFont = True
        Me.HyperlinkLabelControl1.Location = New System.Drawing.Point(41, 108)
        Me.HyperlinkLabelControl1.Name = "HyperlinkLabelControl1"
        Me.HyperlinkLabelControl1.Size = New System.Drawing.Size(107, 17)
        Me.HyperlinkLabelControl1.TabIndex = 655
        Me.HyperlinkLabelControl1.Text = "Unit Measurement"
        '
        'txtUnit
        '
        Me.txtUnit.Location = New System.Drawing.Point(155, 105)
        Me.txtUnit.Name = "txtUnit"
        Me.txtUnit.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtUnit.Properties.Appearance.Options.UseFont = True
        Me.txtUnit.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtUnit.Properties.AppearanceDropDown.Options.UseFont = True
        Me.txtUnit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtUnit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.txtUnit.Size = New System.Drawing.Size(100, 24)
        Me.txtUnit.TabIndex = 1
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Italic)
        Me.LabelControl3.Appearance.ForeColor = System.Drawing.Color.Gray
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Appearance.Options.UseForeColor = True
        Me.LabelControl3.Location = New System.Drawing.Point(261, 111)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(107, 13)
        Me.LabelControl3.TabIndex = 657
        Me.LabelControl3.Text = "i.e pcs, box, bottle, unit"
        '
        'productid
        '
        Me.productid.EditValue = "SYSTEM GENERATED"
        Me.productid.Location = New System.Drawing.Point(155, 26)
        Me.productid.Name = "productid"
        Me.productid.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.productid.Properties.Appearance.Options.UseFont = True
        Me.productid.Properties.Appearance.Options.UseTextOptions = True
        Me.productid.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.productid.Properties.ReadOnly = True
        Me.productid.Size = New System.Drawing.Size(178, 24)
        Me.productid.TabIndex = 658
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Location = New System.Drawing.Point(88, 29)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(60, 17)
        Me.LabelControl4.TabIndex = 659
        Me.LabelControl4.Text = "Item Code"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.SimpleButton1.Appearance.BackColor2 = System.Drawing.Color.Khaki
        Me.SimpleButton1.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton1.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.SimpleButton1.Appearance.Options.UseBackColor = True
        Me.SimpleButton1.Appearance.Options.UseFont = True
        Me.SimpleButton1.Location = New System.Drawing.Point(339, 241)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(119, 34)
        Me.SimpleButton1.TabIndex = 5
        Me.SimpleButton1.Text = "Exit Form"
        '
        'frmProductInfo
        '
        Me.AcceptButton = Me.cmdSaveButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(589, 289)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.productid)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.txtUnit)
        Me.Controls.Add(Me.HyperlinkLabelControl1)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.cmdCategory)
        Me.Controls.Add(Me.ckpooption)
        Me.Controls.Add(Me.categorycode)
        Me.Controls.Add(Me.txtCategory)
        Me.Controls.Add(Me.code)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.cmdSaveButton)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.mode)
        Me.Name = "frmProductInfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transaction Item Information"
        CType(Me.mode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescription.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.code.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCategory.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridcategory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.categorycode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ckpooption.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUnit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.productid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents mode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmdSaveButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtDescription As DevExpress.XtraEditors.TextEdit
    Friend WithEvents code As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCategory As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents gridcategory As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents categorycode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ckpooption As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents cmdCategory As DevExpress.XtraEditors.HyperlinkLabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents HyperlinkLabelControl1 As DevExpress.XtraEditors.HyperlinkLabelControl
    Friend WithEvents txtUnit As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents productid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
End Class
