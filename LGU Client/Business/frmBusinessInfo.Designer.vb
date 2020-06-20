<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBusinessInfo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBusinessInfo))
        Me.id = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.txtContactNo = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtCompanyName = New DevExpress.XtraEditors.TextEdit()
        Me.cmdSaveButton = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.mode = New DevExpress.XtraEditors.TextEdit()
        Me.txtAddress = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.txtDateIncorporation = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.txtNatureofBusiness = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.gridNatureofBusiness = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.txtContactPerson = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.ckActived = New DevExpress.XtraEditors.CheckEdit()
        Me.LinkLabel3 = New System.Windows.Forms.LinkLabel()
        Me.txtPlaceofIncorporation = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.gridPlaceofIncorporation = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.txtTIN = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtKindofOrganization = New DevExpress.XtraEditors.RadioGroup()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.trnmode = New DevExpress.XtraEditors.TextEdit()
        Me.txtTaxPayerName = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.cifid = New DevExpress.XtraEditors.TextEdit()
        CType(Me.id.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtContactNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCompanyName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAddress.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDateIncorporation.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDateIncorporation.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNatureofBusiness.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridNatureofBusiness, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtContactPerson.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ckActived.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPlaceofIncorporation.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridPlaceofIncorporation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTIN.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtKindofOrganization.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trnmode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTaxPayerName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cifid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'id
        '
        Me.id.Location = New System.Drawing.Point(497, 96)
        Me.id.Name = "id"
        Me.id.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.id.Properties.Appearance.Options.UseFont = True
        Me.id.Properties.Appearance.Options.UseTextOptions = True
        Me.id.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.id.Properties.ReadOnly = True
        Me.id.Size = New System.Drawing.Size(37, 24)
        Me.id.TabIndex = 659
        Me.id.Visible = False
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.Location = New System.Drawing.Point(94, 334)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(69, 17)
        Me.LabelControl5.TabIndex = 656
        Me.LabelControl5.Text = "Contact No."
        '
        'txtContactNo
        '
        Me.txtContactNo.EditValue = ""
        Me.txtContactNo.Location = New System.Drawing.Point(171, 330)
        Me.txtContactNo.Name = "txtContactNo"
        Me.txtContactNo.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtContactNo.Properties.Appearance.Options.UseFont = True
        Me.txtContactNo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtContactNo.Properties.Mask.BeepOnError = True
        Me.txtContactNo.Properties.Mask.EditMask = "(0999) 000-0000"
        Me.txtContactNo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
        Me.txtContactNo.Size = New System.Drawing.Size(212, 28)
        Me.txtContactNo.TabIndex = 8
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(55, 95)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(108, 17)
        Me.LabelControl3.TabIndex = 654
        Me.LabelControl3.Text = "Complete Address"
        '
        'txtCompanyName
        '
        Me.txtCompanyName.EditValue = ""
        Me.txtCompanyName.Location = New System.Drawing.Point(171, 58)
        Me.txtCompanyName.Name = "txtCompanyName"
        Me.txtCompanyName.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtCompanyName.Properties.Appearance.Options.UseFont = True
        Me.txtCompanyName.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtCompanyName.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCompanyName.Size = New System.Drawing.Size(288, 28)
        Me.txtCompanyName.TabIndex = 1
        '
        'cmdSaveButton
        '
        Me.cmdSaveButton.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdSaveButton.Appearance.BackColor2 = System.Drawing.Color.Khaki
        Me.cmdSaveButton.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSaveButton.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.cmdSaveButton.Appearance.Options.UseBackColor = True
        Me.cmdSaveButton.Appearance.Options.UseFont = True
        Me.cmdSaveButton.Location = New System.Drawing.Point(171, 422)
        Me.cmdSaveButton.Name = "cmdSaveButton"
        Me.cmdSaveButton.Size = New System.Drawing.Size(168, 38)
        Me.cmdSaveButton.TabIndex = 11
        Me.cmdSaveButton.Text = "Save"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(69, 62)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(94, 17)
        Me.LabelControl1.TabIndex = 652
        Me.LabelControl1.Text = "Company Name"
        '
        'mode
        '
        Me.mode.Location = New System.Drawing.Point(497, 123)
        Me.mode.Name = "mode"
        Me.mode.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mode.Properties.Appearance.Options.UseFont = True
        Me.mode.Properties.Appearance.Options.UseTextOptions = True
        Me.mode.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.mode.Properties.ReadOnly = True
        Me.mode.Size = New System.Drawing.Size(37, 24)
        Me.mode.TabIndex = 651
        Me.mode.Visible = False
        '
        'txtAddress
        '
        Me.txtAddress.EditValue = ""
        Me.txtAddress.Location = New System.Drawing.Point(171, 90)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtAddress.Properties.Appearance.Options.UseFont = True
        Me.txtAddress.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtAddress.Properties.AppearanceDisabled.Options.UseFont = True
        Me.txtAddress.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtAddress.Properties.AppearanceDropDown.Options.UseFont = True
        Me.txtAddress.Properties.AppearanceFocused.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtAddress.Properties.AppearanceFocused.Options.UseFont = True
        Me.txtAddress.Properties.AppearanceItemDisabled.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtAddress.Properties.AppearanceItemDisabled.Options.UseFont = True
        Me.txtAddress.Properties.AppearanceItemHighlight.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtAddress.Properties.AppearanceItemHighlight.Options.UseFont = True
        Me.txtAddress.Properties.AppearanceItemSelected.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtAddress.Properties.AppearanceItemSelected.Options.UseFont = True
        Me.txtAddress.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtAddress.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.txtAddress.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtAddress.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtAddress.Properties.ImmediatePopup = True
        Me.txtAddress.Size = New System.Drawing.Size(288, 28)
        Me.txtAddress.TabIndex = 2
        '
        'txtDateIncorporation
        '
        Me.txtDateIncorporation.EditValue = New Date(2019, 6, 10, 16, 23, 25, 399)
        Me.txtDateIncorporation.EnterMoveNextControl = True
        Me.txtDateIncorporation.Location = New System.Drawing.Point(171, 122)
        Me.txtDateIncorporation.Name = "txtDateIncorporation"
        Me.txtDateIncorporation.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.txtDateIncorporation.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtDateIncorporation.Properties.Appearance.Options.UseFont = True
        Me.txtDateIncorporation.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtDateIncorporation.Properties.AppearanceDropDown.Options.UseFont = True
        Me.txtDateIncorporation.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtDateIncorporation.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtDateIncorporation.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtDateIncorporation.Properties.Mask.EditMask = "MMMM dd, yyyy"
        Me.txtDateIncorporation.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtDateIncorporation.Size = New System.Drawing.Size(212, 28)
        Me.txtDateIncorporation.TabIndex = 3
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Location = New System.Drawing.Point(53, 127)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(110, 17)
        Me.LabelControl4.TabIndex = 922
        Me.LabelControl4.Text = "Date Incorporation"
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.LinkLabel2.Location = New System.Drawing.Point(40, 270)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(123, 19)
        Me.LinkLabel2.TabIndex = 928
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Nature of Buisness"
        '
        'txtNatureofBusiness
        '
        Me.txtNatureofBusiness.EditValue = "sss"
        Me.txtNatureofBusiness.Location = New System.Drawing.Point(171, 266)
        Me.txtNatureofBusiness.Name = "txtNatureofBusiness"
        Me.txtNatureofBusiness.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtNatureofBusiness.Properties.Appearance.Options.UseFont = True
        Me.txtNatureofBusiness.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtNatureofBusiness.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtNatureofBusiness.Properties.DisplayMember = "Select"
        Me.txtNatureofBusiness.Properties.NullText = ""
        Me.txtNatureofBusiness.Properties.PopupView = Me.gridNatureofBusiness
        Me.txtNatureofBusiness.Properties.ValueMember = "id"
        Me.txtNatureofBusiness.Size = New System.Drawing.Size(212, 28)
        Me.txtNatureofBusiness.TabIndex = 6
        '
        'gridNatureofBusiness
        '
        Me.gridNatureofBusiness.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gridNatureofBusiness.Name = "gridNatureofBusiness"
        Me.gridNatureofBusiness.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridNatureofBusiness.OptionsView.ShowGroupPanel = False
        '
        'txtContactPerson
        '
        Me.txtContactPerson.EditValue = ""
        Me.txtContactPerson.Location = New System.Drawing.Point(171, 298)
        Me.txtContactPerson.Name = "txtContactPerson"
        Me.txtContactPerson.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtContactPerson.Properties.Appearance.Options.UseFont = True
        Me.txtContactPerson.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtContactPerson.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtContactPerson.Size = New System.Drawing.Size(212, 28)
        Me.txtContactPerson.TabIndex = 7
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.LabelControl7.Appearance.Options.UseFont = True
        Me.LabelControl7.Location = New System.Drawing.Point(36, 303)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(127, 17)
        Me.LabelControl7.TabIndex = 930
        Me.LabelControl7.Text = "Contact Person Name"
        '
        'ckActived
        '
        Me.ckActived.EditValue = True
        Me.ckActived.Location = New System.Drawing.Point(171, 394)
        Me.ckActived.Name = "ckActived"
        Me.ckActived.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.ckActived.Properties.Appearance.Options.UseFont = True
        Me.ckActived.Properties.Caption = "Tag as Actived Company"
        Me.ckActived.Size = New System.Drawing.Size(212, 21)
        Me.ckActived.TabIndex = 10
        '
        'LinkLabel3
        '
        Me.LinkLabel3.AutoSize = True
        Me.LinkLabel3.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.LinkLabel3.Location = New System.Drawing.Point(20, 157)
        Me.LinkLabel3.Name = "LinkLabel3"
        Me.LinkLabel3.Size = New System.Drawing.Size(143, 19)
        Me.LinkLabel3.TabIndex = 933
        Me.LinkLabel3.TabStop = True
        Me.LinkLabel3.Text = "Place of Incorporation"
        '
        'txtPlaceofIncorporation
        '
        Me.txtPlaceofIncorporation.EditValue = "sss"
        Me.txtPlaceofIncorporation.Location = New System.Drawing.Point(171, 154)
        Me.txtPlaceofIncorporation.Name = "txtPlaceofIncorporation"
        Me.txtPlaceofIncorporation.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtPlaceofIncorporation.Properties.Appearance.Options.UseFont = True
        Me.txtPlaceofIncorporation.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtPlaceofIncorporation.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtPlaceofIncorporation.Properties.DisplayMember = "Select"
        Me.txtPlaceofIncorporation.Properties.NullText = ""
        Me.txtPlaceofIncorporation.Properties.PopupView = Me.gridPlaceofIncorporation
        Me.txtPlaceofIncorporation.Properties.ValueMember = "id"
        Me.txtPlaceofIncorporation.Size = New System.Drawing.Size(212, 28)
        Me.txtPlaceofIncorporation.TabIndex = 4
        '
        'gridPlaceofIncorporation
        '
        Me.gridPlaceofIncorporation.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gridPlaceofIncorporation.Name = "gridPlaceofIncorporation"
        Me.gridPlaceofIncorporation.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridPlaceofIncorporation.OptionsView.ShowGroupPanel = False
        '
        'txtTIN
        '
        Me.txtTIN.EditValue = ""
        Me.txtTIN.EnterMoveNextControl = True
        Me.txtTIN.Location = New System.Drawing.Point(171, 362)
        Me.txtTIN.Name = "txtTIN"
        Me.txtTIN.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtTIN.Properties.Appearance.Options.UseFont = True
        Me.txtTIN.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTIN.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtTIN.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTIN.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtTIN.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtTIN.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTIN.Properties.Mask.BeepOnError = True
        Me.txtTIN.Properties.Mask.EditMask = "000-000-000-00000"
        Me.txtTIN.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
        Me.txtTIN.Properties.MaxLength = 50
        Me.txtTIN.Size = New System.Drawing.Size(212, 28)
        Me.txtTIN.TabIndex = 9
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(143, 367)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(20, 17)
        Me.LabelControl2.TabIndex = 935
        Me.LabelControl2.Text = "TIN"
        '
        'txtKindofOrganization
        '
        Me.txtKindofOrganization.EditValue = "single"
        Me.txtKindofOrganization.EnterMoveNextControl = True
        Me.txtKindofOrganization.Location = New System.Drawing.Point(171, 186)
        Me.txtKindofOrganization.Name = "txtKindofOrganization"
        Me.txtKindofOrganization.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.txtKindofOrganization.Properties.Appearance.Options.UseFont = True
        Me.txtKindofOrganization.Properties.Appearance.Options.UseTextOptions = True
        Me.txtKindofOrganization.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.txtKindofOrganization.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtKindofOrganization.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtKindofOrganization.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtKindofOrganization.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtKindofOrganization.Properties.ItemHorzAlignment = DevExpress.XtraEditors.RadioItemHorzAlignment.Near
        Me.txtKindofOrganization.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem("corporation", "1. CORPORATION"), New DevExpress.XtraEditors.Controls.RadioGroupItem("association", "2. ASSOCIATION"), New DevExpress.XtraEditors.Controls.RadioGroupItem("partnership", "3. PARTNERSHIP")})
        Me.txtKindofOrganization.Properties.ItemsLayout = DevExpress.XtraEditors.RadioGroupItemsLayout.Flow
        Me.txtKindofOrganization.Size = New System.Drawing.Size(212, 76)
        Me.txtKindofOrganization.TabIndex = 5
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.LabelControl6.Appearance.Options.UseFont = True
        Me.LabelControl6.Location = New System.Drawing.Point(42, 190)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(121, 17)
        Me.LabelControl6.TabIndex = 937
        Me.LabelControl6.Text = "Kind of Organization"
        '
        'trnmode
        '
        Me.trnmode.Location = New System.Drawing.Point(497, 153)
        Me.trnmode.Name = "trnmode"
        Me.trnmode.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.trnmode.Properties.Appearance.Options.UseFont = True
        Me.trnmode.Properties.Appearance.Options.UseTextOptions = True
        Me.trnmode.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.trnmode.Properties.ReadOnly = True
        Me.trnmode.Size = New System.Drawing.Size(37, 24)
        Me.trnmode.TabIndex = 938
        Me.trnmode.Visible = False
        '
        'txtTaxPayerName
        '
        Me.txtTaxPayerName.Location = New System.Drawing.Point(171, 26)
        Me.txtTaxPayerName.Name = "txtTaxPayerName"
        Me.txtTaxPayerName.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtTaxPayerName.Properties.Appearance.Options.UseFont = True
        Me.txtTaxPayerName.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtTaxPayerName.Properties.AppearanceDisabled.Options.UseFont = True
        Me.txtTaxPayerName.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtTaxPayerName.Properties.AppearanceDropDown.Options.UseFont = True
        Me.txtTaxPayerName.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTaxPayerName.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtTaxPayerName.Properties.AppearanceItemDisabled.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtTaxPayerName.Properties.AppearanceItemDisabled.Options.UseFont = True
        Me.txtTaxPayerName.Properties.AppearanceItemHighlight.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtTaxPayerName.Properties.AppearanceItemHighlight.Options.UseFont = True
        Me.txtTaxPayerName.Properties.AppearanceItemSelected.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtTaxPayerName.Properties.AppearanceItemSelected.Options.UseFont = True
        Me.txtTaxPayerName.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtTaxPayerName.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.txtTaxPayerName.Properties.AutoComplete = False
        Me.txtTaxPayerName.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtTaxPayerName.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtTaxPayerName.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTaxPayerName.Properties.ImmediatePopup = True
        Me.txtTaxPayerName.Properties.PopupSizeable = True
        Me.txtTaxPayerName.Properties.ValidateOnEnterKey = True
        Me.txtTaxPayerName.Size = New System.Drawing.Size(288, 28)
        Me.txtTaxPayerName.TabIndex = 0
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.LabelControl8.Appearance.Options.UseFont = True
        Me.LabelControl8.Location = New System.Drawing.Point(68, 32)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(95, 17)
        Me.LabelControl8.TabIndex = 940
        Me.LabelControl8.Text = "Tax Payer Name"
        '
        'cifid
        '
        Me.cifid.Location = New System.Drawing.Point(497, 66)
        Me.cifid.Name = "cifid"
        Me.cifid.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cifid.Properties.Appearance.Options.UseFont = True
        Me.cifid.Properties.Appearance.Options.UseTextOptions = True
        Me.cifid.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.cifid.Properties.ReadOnly = True
        Me.cifid.Size = New System.Drawing.Size(37, 24)
        Me.cifid.TabIndex = 941
        Me.cifid.Visible = False
        '
        'frmBusinessInfo
        '
        Me.AcceptButton = Me.cmdSaveButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(496, 489)
        Me.Controls.Add(Me.cifid)
        Me.Controls.Add(Me.LabelControl8)
        Me.Controls.Add(Me.txtTaxPayerName)
        Me.Controls.Add(Me.trnmode)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.txtKindofOrganization)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.txtTIN)
        Me.Controls.Add(Me.LinkLabel3)
        Me.Controls.Add(Me.txtPlaceofIncorporation)
        Me.Controls.Add(Me.ckActived)
        Me.Controls.Add(Me.txtContactPerson)
        Me.Controls.Add(Me.LabelControl7)
        Me.Controls.Add(Me.LinkLabel2)
        Me.Controls.Add(Me.txtNatureofBusiness)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.txtDateIncorporation)
        Me.Controls.Add(Me.id)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.txtContactNo)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.txtCompanyName)
        Me.Controls.Add(Me.cmdSaveButton)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.mode)
        Me.Controls.Add(Me.txtAddress)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmBusinessInfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Business Information Form"
        CType(Me.id.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtContactNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCompanyName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAddress.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDateIncorporation.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDateIncorporation.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNatureofBusiness.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridNatureofBusiness, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtContactPerson.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ckActived.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPlaceofIncorporation.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridPlaceofIncorporation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTIN.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtKindofOrganization.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trnmode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTaxPayerName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cifid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents id As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtContactNo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCompanyName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmdSaveButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents mode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtAddress As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txtDateIncorporation As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LinkLabel2 As System.Windows.Forms.LinkLabel
    Friend WithEvents txtNatureofBusiness As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents gridNatureofBusiness As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtContactPerson As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ckActived As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LinkLabel3 As System.Windows.Forms.LinkLabel
    Friend WithEvents txtPlaceofIncorporation As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents gridPlaceofIncorporation As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtTIN As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtKindofOrganization As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents trnmode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTaxPayerName As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cifid As DevExpress.XtraEditors.TextEdit
End Class
