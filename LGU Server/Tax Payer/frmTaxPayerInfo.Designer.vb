<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTaxPayerInfo
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
        Me.mode = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtFullname = New DevExpress.XtraEditors.TextEdit()
        Me.txtAddress = New DevExpress.XtraEditors.TextEdit()
        Me.txtAgency = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.gridAgency = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.cifid = New DevExpress.XtraEditors.TextEdit()
        Me.txtContactNo = New DevExpress.XtraEditors.TextEdit()
        Me.txtGender = New DevExpress.XtraEditors.RadioGroup()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.txtBirthdate = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.txtProfession = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.gridProfession = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.cmdProfession = New System.Windows.Forms.LinkLabel()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.txtCivilStatus = New DevExpress.XtraEditors.RadioGroup()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.txtWeight = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.txtHeight = New DevExpress.XtraEditors.TextEdit()
        Me.cmdPlaceofBirth = New System.Windows.Forms.LinkLabel()
        Me.txtPlaceOfBirth = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.gridBirthplace = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.cmdCitizenship = New System.Windows.Forms.LinkLabel()
        Me.txtCitizenship = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.gridCitizenship = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.txtTIN = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.cmdSaveButton = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.mode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFullname.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAddress.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAgency.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridAgency, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cifid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtContactNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtGender.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBirthdate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBirthdate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtProfession.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridProfession, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCivilStatus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtWeight.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHeight.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPlaceOfBirth.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridBirthplace, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCitizenship.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridCitizenship, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTIN.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mode
        '
        Me.mode.Location = New System.Drawing.Point(509, 124)
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
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(90, 84)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(55, 17)
        Me.LabelControl1.TabIndex = 510
        Me.LabelControl1.Text = "Fullname"
        '
        'txtFullname
        '
        Me.txtFullname.EditValue = ""
        Me.txtFullname.Location = New System.Drawing.Point(153, 80)
        Me.txtFullname.Name = "txtFullname"
        Me.txtFullname.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtFullname.Properties.Appearance.Options.UseFont = True
        Me.txtFullname.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtFullname.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFullname.Size = New System.Drawing.Size(275, 26)
        Me.txtFullname.TabIndex = 1
        '
        'txtAddress
        '
        Me.txtAddress.EditValue = ""
        Me.txtAddress.Location = New System.Drawing.Point(153, 109)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtAddress.Properties.Appearance.Options.UseFont = True
        Me.txtAddress.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtAddress.Size = New System.Drawing.Size(275, 26)
        Me.txtAddress.TabIndex = 2
        '
        'txtAgency
        '
        Me.txtAgency.EditValue = "sss"
        Me.txtAgency.Location = New System.Drawing.Point(153, 51)
        Me.txtAgency.Name = "txtAgency"
        Me.txtAgency.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtAgency.Properties.Appearance.Options.UseFont = True
        Me.txtAgency.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtAgency.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtAgency.Properties.DisplayMember = "Select"
        Me.txtAgency.Properties.NullText = ""
        Me.txtAgency.Properties.PopupView = Me.gridAgency
        Me.txtAgency.Properties.ValueMember = "id"
        Me.txtAgency.Size = New System.Drawing.Size(275, 26)
        Me.txtAgency.TabIndex = 0
        '
        'gridAgency
        '
        Me.gridAgency.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gridAgency.Name = "gridAgency"
        Me.gridAgency.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridAgency.OptionsView.ShowGroupPanel = False
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(61, 55)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(84, 17)
        Me.LabelControl2.TabIndex = 634
        Me.LabelControl2.Text = "Select Agency"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(96, 113)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(49, 17)
        Me.LabelControl3.TabIndex = 635
        Me.LabelControl3.Text = "Address"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.Location = New System.Drawing.Point(73, 142)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(72, 17)
        Me.LabelControl5.TabIndex = 639
        Me.LabelControl5.Text = "Contact No."
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl7.Appearance.Options.UseFont = True
        Me.LabelControl7.Location = New System.Drawing.Point(55, 25)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(90, 17)
        Me.LabelControl7.TabIndex = 644
        Me.LabelControl7.Text = "Taxpayer Code"
        '
        'cifid
        '
        Me.cifid.Location = New System.Drawing.Point(153, 22)
        Me.cifid.Name = "cifid"
        Me.cifid.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cifid.Properties.Appearance.Options.UseFont = True
        Me.cifid.Properties.Appearance.Options.UseTextOptions = True
        Me.cifid.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.cifid.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cifid.Properties.ReadOnly = True
        Me.cifid.Size = New System.Drawing.Size(177, 26)
        Me.cifid.TabIndex = 645
        '
        'txtContactNo
        '
        Me.txtContactNo.EditValue = ""
        Me.txtContactNo.Location = New System.Drawing.Point(153, 138)
        Me.txtContactNo.Name = "txtContactNo"
        Me.txtContactNo.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtContactNo.Properties.Appearance.Options.UseFont = True
        Me.txtContactNo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtContactNo.Properties.Mask.BeepOnError = True
        Me.txtContactNo.Properties.Mask.EditMask = "(0999) 000-0000"
        Me.txtContactNo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
        Me.txtContactNo.Size = New System.Drawing.Size(177, 26)
        Me.txtContactNo.TabIndex = 3
        '
        'txtGender
        '
        Me.txtGender.EditValue = "M"
        Me.txtGender.EnterMoveNextControl = True
        Me.txtGender.Location = New System.Drawing.Point(153, 167)
        Me.txtGender.Name = "txtGender"
        Me.txtGender.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtGender.Properties.Appearance.Options.UseFont = True
        Me.txtGender.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtGender.Properties.Columns = 2
        Me.txtGender.Properties.ItemHorzAlignment = DevExpress.XtraEditors.RadioItemHorzAlignment.Far
        Me.txtGender.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem("M", "1. MALE"), New DevExpress.XtraEditors.Controls.RadioGroupItem("F", "2. FEMALE")})
        Me.txtGender.Size = New System.Drawing.Size(177, 32)
        Me.txtGender.TabIndex = 4
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl8.Appearance.Options.UseFont = True
        Me.LabelControl8.Location = New System.Drawing.Point(101, 171)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(44, 17)
        Me.LabelControl8.TabIndex = 648
        Me.LabelControl8.Text = "Gender"
        '
        'txtBirthdate
        '
        Me.txtBirthdate.EditValue = Nothing
        Me.txtBirthdate.EnterMoveNextControl = True
        Me.txtBirthdate.Location = New System.Drawing.Point(153, 231)
        Me.txtBirthdate.Name = "txtBirthdate"
        Me.txtBirthdate.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtBirthdate.Properties.Appearance.Options.UseFont = True
        Me.txtBirthdate.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtBirthdate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtBirthdate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtBirthdate.Properties.Mask.EditMask = "MMMM dd, yyyy"
        Me.txtBirthdate.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtBirthdate.Size = New System.Drawing.Size(238, 26)
        Me.txtBirthdate.TabIndex = 6
        '
        'LabelControl12
        '
        Me.LabelControl12.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl12.Appearance.Options.UseFont = True
        Me.LabelControl12.Location = New System.Drawing.Point(84, 237)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(61, 17)
        Me.LabelControl12.TabIndex = 1049
        Me.LabelControl12.Text = "Birth Date"
        '
        'txtProfession
        '
        Me.txtProfession.EditValue = "sss"
        Me.txtProfession.EnterMoveNextControl = True
        Me.txtProfession.Location = New System.Drawing.Point(153, 427)
        Me.txtProfession.Name = "txtProfession"
        Me.txtProfession.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtProfession.Properties.Appearance.Options.UseFont = True
        Me.txtProfession.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtProfession.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtProfession.Properties.DisplayMember = "Select"
        Me.txtProfession.Properties.NullText = ""
        Me.txtProfession.Properties.PopupView = Me.gridProfession
        Me.txtProfession.Properties.ValueMember = "id"
        Me.txtProfession.Size = New System.Drawing.Size(275, 26)
        Me.txtProfession.TabIndex = 11
        '
        'gridProfession
        '
        Me.gridProfession.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gridProfession.Name = "gridProfession"
        Me.gridProfession.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridProfession.OptionsView.ShowGroupPanel = False
        '
        'cmdProfession
        '
        Me.cmdProfession.AutoSize = True
        Me.cmdProfession.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.cmdProfession.LinkColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdProfession.Location = New System.Drawing.Point(71, 429)
        Me.cmdProfession.Name = "cmdProfession"
        Me.cmdProfession.Size = New System.Drawing.Size(74, 19)
        Me.cmdProfession.TabIndex = 1048
        Me.cmdProfession.TabStop = True
        Me.cmdProfession.Text = "Profession"
        Me.cmdProfession.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelControl11
        '
        Me.LabelControl11.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl11.Appearance.Options.UseFont = True
        Me.LabelControl11.Location = New System.Drawing.Point(79, 294)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(66, 17)
        Me.LabelControl11.TabIndex = 1047
        Me.LabelControl11.Text = "Civil Status"
        '
        'txtCivilStatus
        '
        Me.txtCivilStatus.EditValue = "single"
        Me.txtCivilStatus.EnterMoveNextControl = True
        Me.txtCivilStatus.Location = New System.Drawing.Point(153, 290)
        Me.txtCivilStatus.Name = "txtCivilStatus"
        Me.txtCivilStatus.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtCivilStatus.Properties.Appearance.Options.UseFont = True
        Me.txtCivilStatus.Properties.Appearance.Options.UseTextOptions = True
        Me.txtCivilStatus.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.txtCivilStatus.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtCivilStatus.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtCivilStatus.Properties.ItemHorzAlignment = DevExpress.XtraEditors.RadioItemHorzAlignment.Near
        Me.txtCivilStatus.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem("single", "1. SINGLE"), New DevExpress.XtraEditors.Controls.RadioGroupItem("married", "2. MARRIED"), New DevExpress.XtraEditors.Controls.RadioGroupItem("widow", "3. WIDOW / WIDOWER / LEGALLY SEPARATED"), New DevExpress.XtraEditors.Controls.RadioGroupItem("divorced", "4. DIVORCED")})
        Me.txtCivilStatus.Properties.ItemsLayout = DevExpress.XtraEditors.RadioGroupItemsLayout.Flow
        Me.txtCivilStatus.Size = New System.Drawing.Size(275, 76)
        Me.txtCivilStatus.TabIndex = 8
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl10.Appearance.Options.UseFont = True
        Me.LabelControl10.Location = New System.Drawing.Point(101, 404)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(44, 17)
        Me.LabelControl10.TabIndex = 1046
        Me.LabelControl10.Text = "Weight"
        '
        'txtWeight
        '
        Me.txtWeight.EditValue = ""
        Me.txtWeight.EnterMoveNextControl = True
        Me.txtWeight.Location = New System.Drawing.Point(153, 398)
        Me.txtWeight.Name = "txtWeight"
        Me.txtWeight.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtWeight.Properties.Appearance.Options.UseFont = True
        Me.txtWeight.Properties.Appearance.Options.UseTextOptions = True
        Me.txtWeight.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtWeight.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtWeight.Properties.MaxLength = 50
        Me.txtWeight.Size = New System.Drawing.Size(177, 26)
        Me.txtWeight.TabIndex = 10
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl9.Appearance.Options.UseFont = True
        Me.LabelControl9.Location = New System.Drawing.Point(96, 375)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(49, 17)
        Me.LabelControl9.TabIndex = 1045
        Me.LabelControl9.Text = "Heighht"
        '
        'txtHeight
        '
        Me.txtHeight.EditValue = ""
        Me.txtHeight.EnterMoveNextControl = True
        Me.txtHeight.Location = New System.Drawing.Point(153, 369)
        Me.txtHeight.Name = "txtHeight"
        Me.txtHeight.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtHeight.Properties.Appearance.Options.UseFont = True
        Me.txtHeight.Properties.Appearance.Options.UseTextOptions = True
        Me.txtHeight.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtHeight.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtHeight.Properties.MaxLength = 50
        Me.txtHeight.Size = New System.Drawing.Size(177, 26)
        Me.txtHeight.TabIndex = 9
        '
        'cmdPlaceofBirth
        '
        Me.cmdPlaceofBirth.AutoSize = True
        Me.cmdPlaceofBirth.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.cmdPlaceofBirth.LinkColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdPlaceofBirth.Location = New System.Drawing.Point(52, 267)
        Me.cmdPlaceofBirth.Name = "cmdPlaceofBirth"
        Me.cmdPlaceofBirth.Size = New System.Drawing.Size(93, 19)
        Me.cmdPlaceofBirth.TabIndex = 1044
        Me.cmdPlaceofBirth.TabStop = True
        Me.cmdPlaceofBirth.Text = "Place of Birth"
        '
        'txtPlaceOfBirth
        '
        Me.txtPlaceOfBirth.EditValue = "sss"
        Me.txtPlaceOfBirth.EnterMoveNextControl = True
        Me.txtPlaceOfBirth.Location = New System.Drawing.Point(153, 261)
        Me.txtPlaceOfBirth.Name = "txtPlaceOfBirth"
        Me.txtPlaceOfBirth.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtPlaceOfBirth.Properties.Appearance.Options.UseFont = True
        Me.txtPlaceOfBirth.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtPlaceOfBirth.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtPlaceOfBirth.Properties.DisplayMember = "Select"
        Me.txtPlaceOfBirth.Properties.NullText = ""
        Me.txtPlaceOfBirth.Properties.PopupView = Me.gridBirthplace
        Me.txtPlaceOfBirth.Properties.ValueMember = "id"
        Me.txtPlaceOfBirth.Size = New System.Drawing.Size(238, 26)
        Me.txtPlaceOfBirth.TabIndex = 7
        '
        'gridBirthplace
        '
        Me.gridBirthplace.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gridBirthplace.Name = "gridBirthplace"
        Me.gridBirthplace.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridBirthplace.OptionsView.ShowGroupPanel = False
        '
        'cmdCitizenship
        '
        Me.cmdCitizenship.AutoSize = True
        Me.cmdCitizenship.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.cmdCitizenship.LinkColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdCitizenship.Location = New System.Drawing.Point(66, 206)
        Me.cmdCitizenship.Name = "cmdCitizenship"
        Me.cmdCitizenship.Size = New System.Drawing.Size(79, 19)
        Me.cmdCitizenship.TabIndex = 1043
        Me.cmdCitizenship.TabStop = True
        Me.cmdCitizenship.Text = "Citizenship"
        '
        'txtCitizenship
        '
        Me.txtCitizenship.EditValue = "sss"
        Me.txtCitizenship.EnterMoveNextControl = True
        Me.txtCitizenship.Location = New System.Drawing.Point(153, 202)
        Me.txtCitizenship.Name = "txtCitizenship"
        Me.txtCitizenship.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtCitizenship.Properties.Appearance.Options.UseFont = True
        Me.txtCitizenship.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtCitizenship.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtCitizenship.Properties.DisplayMember = "Select"
        Me.txtCitizenship.Properties.NullText = ""
        Me.txtCitizenship.Properties.PopupView = Me.gridCitizenship
        Me.txtCitizenship.Properties.ValueMember = "id"
        Me.txtCitizenship.Size = New System.Drawing.Size(238, 26)
        Me.txtCitizenship.TabIndex = 5
        '
        'gridCitizenship
        '
        Me.gridCitizenship.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gridCitizenship.Name = "gridCitizenship"
        Me.gridCitizenship.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridCitizenship.OptionsView.ShowGroupPanel = False
        '
        'txtTIN
        '
        Me.txtTIN.EditValue = ""
        Me.txtTIN.EnterMoveNextControl = True
        Me.txtTIN.Location = New System.Drawing.Point(153, 456)
        Me.txtTIN.Name = "txtTIN"
        Me.txtTIN.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtTIN.Properties.Appearance.Options.UseFont = True
        Me.txtTIN.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTIN.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtTIN.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtTIN.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTIN.Properties.Mask.BeepOnError = True
        Me.txtTIN.Properties.Mask.EditMask = "000-000-000-00000"
        Me.txtTIN.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
        Me.txtTIN.Properties.MaxLength = 50
        Me.txtTIN.Size = New System.Drawing.Size(177, 26)
        Me.txtTIN.TabIndex = 12
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Location = New System.Drawing.Point(124, 460)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(21, 17)
        Me.LabelControl4.TabIndex = 1051
        Me.LabelControl4.Text = "TIN"
        '
        'cmdSaveButton
        '
        Me.cmdSaveButton.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdSaveButton.Appearance.BackColor2 = System.Drawing.Color.Khaki
        Me.cmdSaveButton.Appearance.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSaveButton.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.cmdSaveButton.Appearance.Options.UseBackColor = True
        Me.cmdSaveButton.Appearance.Options.UseFont = True
        Me.cmdSaveButton.Location = New System.Drawing.Point(153, 486)
        Me.cmdSaveButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdSaveButton.Name = "cmdSaveButton"
        Me.cmdSaveButton.Size = New System.Drawing.Size(177, 39)
        Me.cmdSaveButton.TabIndex = 1052
        Me.cmdSaveButton.Text = "Create Backup"
        '
        'frmTaxPayerInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(486, 545)
        Me.Controls.Add(Me.cmdSaveButton)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.txtTIN)
        Me.Controls.Add(Me.txtBirthdate)
        Me.Controls.Add(Me.LabelControl12)
        Me.Controls.Add(Me.txtProfession)
        Me.Controls.Add(Me.cmdProfession)
        Me.Controls.Add(Me.LabelControl11)
        Me.Controls.Add(Me.txtCivilStatus)
        Me.Controls.Add(Me.LabelControl10)
        Me.Controls.Add(Me.txtWeight)
        Me.Controls.Add(Me.LabelControl9)
        Me.Controls.Add(Me.txtHeight)
        Me.Controls.Add(Me.cmdPlaceofBirth)
        Me.Controls.Add(Me.txtPlaceOfBirth)
        Me.Controls.Add(Me.cmdCitizenship)
        Me.Controls.Add(Me.txtCitizenship)
        Me.Controls.Add(Me.LabelControl8)
        Me.Controls.Add(Me.txtGender)
        Me.Controls.Add(Me.txtContactNo)
        Me.Controls.Add(Me.cifid)
        Me.Controls.Add(Me.LabelControl7)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.txtAgency)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.txtFullname)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.mode)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmTaxPayerInfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tax Payer Information"
        CType(Me.mode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFullname.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAddress.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAgency.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridAgency, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cifid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtContactNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtGender.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBirthdate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBirthdate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtProfession.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridProfession, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCivilStatus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtWeight.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHeight.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPlaceOfBirth.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridBirthplace, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCitizenship.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridCitizenship, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTIN.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtFullname As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtAddress As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtAgency As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents gridAgency As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cifid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtContactNo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtGender As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtBirthdate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtProfession As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents gridProfession As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cmdProfession As System.Windows.Forms.LinkLabel
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCivilStatus As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtWeight As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtHeight As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmdPlaceofBirth As System.Windows.Forms.LinkLabel
    Friend WithEvents txtPlaceOfBirth As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents gridBirthplace As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cmdCitizenship As System.Windows.Forms.LinkLabel
    Friend WithEvents txtCitizenship As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents gridCitizenship As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtTIN As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmdSaveButton As DevExpress.XtraEditors.SimpleButton
End Class
