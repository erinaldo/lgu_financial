<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPurchaseOrder
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPurchaseOrder))
        Me.cmdaction = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.txtPRNumber = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtPostingDate = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.txtTIN = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.txtPONumber = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.txtPODate = New DevExpress.XtraEditors.DateEdit()
        Me.txtSupplier = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.gridSupplier = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.txtAddress = New DevExpress.XtraEditors.MemoEdit()
        Me.txtProcurementMode = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.gridProcurementMode = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.HyperlinkLabelControl1 = New DevExpress.XtraEditors.HyperlinkLabelControl()
        Me.HyperlinkLabelControl2 = New DevExpress.XtraEditors.HyperlinkLabelControl()
        Me.HyperlinkLabelControl3 = New DevExpress.XtraEditors.HyperlinkLabelControl()
        Me.txtPlaceofDelivery = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.gridPlaceOfDelivery = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.HyperlinkLabelControl4 = New DevExpress.XtraEditors.HyperlinkLabelControl()
        Me.txtDateDelivery = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.gridDateDelivery = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.HyperlinkLabelControl5 = New DevExpress.XtraEditors.HyperlinkLabelControl()
        Me.txtDeliveryTerm = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.gridDeliveryTerm = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.HyperlinkLabelControl6 = New DevExpress.XtraEditors.HyperlinkLabelControl()
        Me.txtPaymentTerm = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.gridPaymentTerm = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.periodcode = New DevExpress.XtraEditors.TextEdit()
        Me.pid = New DevExpress.XtraEditors.TextEdit()
        Me.Em = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.ckNegotiated = New DevExpress.XtraEditors.CheckEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtResolutionNo = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtDateApproved = New DevExpress.XtraEditors.DateEdit()
        Me.txtAddPrintLine = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.txtPRNumber.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPostingDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPostingDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTIN.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPONumber.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPODate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPODate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSupplier.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridSupplier, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAddress.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtProcurementMode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridProcurementMode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPlaceofDelivery.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridPlaceOfDelivery, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDateDelivery.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridDateDelivery, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDeliveryTerm.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridDeliveryTerm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPaymentTerm.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridPaymentTerm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.periodcode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ckNegotiated.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtResolutionNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDateApproved.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDateApproved.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAddPrintLine.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdaction
        '
        Me.cmdaction.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.cmdaction.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.cmdaction.Appearance.Options.UseFont = True
        Me.cmdaction.Location = New System.Drawing.Point(139, 513)
        Me.cmdaction.Name = "cmdaction"
        Me.cmdaction.Size = New System.Drawing.Size(184, 36)
        Me.cmdaction.TabIndex = 3
        Me.cmdaction.Text = "Save and Print"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.Location = New System.Drawing.Point(62, 200)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(67, 17)
        Me.LabelControl5.TabIndex = 932
        Me.LabelControl5.Text = "PR Number"
        '
        'txtPRNumber
        '
        Me.txtPRNumber.EditValue = ""
        Me.txtPRNumber.Location = New System.Drawing.Point(139, 196)
        Me.txtPRNumber.Name = "txtPRNumber"
        Me.txtPRNumber.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtPRNumber.Properties.Appearance.Options.UseFont = True
        Me.txtPRNumber.Properties.Appearance.Options.UseTextOptions = True
        Me.txtPRNumber.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtPRNumber.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtPRNumber.Properties.ReadOnly = True
        Me.txtPRNumber.Size = New System.Drawing.Size(184, 26)
        Me.txtPRNumber.TabIndex = 931
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(83, 229)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(46, 17)
        Me.LabelControl3.TabIndex = 936
        Me.LabelControl3.Text = "PR Date"
        '
        'txtPostingDate
        '
        Me.txtPostingDate.EditValue = New Date(2019, 6, 10, 16, 23, 25, 399)
        Me.txtPostingDate.EnterMoveNextControl = True
        Me.txtPostingDate.Location = New System.Drawing.Point(139, 225)
        Me.txtPostingDate.Name = "txtPostingDate"
        Me.txtPostingDate.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.txtPostingDate.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtPostingDate.Properties.Appearance.Options.UseFont = True
        Me.txtPostingDate.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtPostingDate.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtPostingDate.Properties.AutoHeight = False
        Me.txtPostingDate.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtPostingDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtPostingDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtPostingDate.Properties.Mask.EditMask = "MMMM dd, yyyy"
        Me.txtPostingDate.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtPostingDate.Properties.ReadOnly = True
        Me.txtPostingDate.Size = New System.Drawing.Size(184, 25)
        Me.txtPostingDate.TabIndex = 935
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.LabelControl9.Appearance.Options.UseFont = True
        Me.LabelControl9.Location = New System.Drawing.Point(109, 113)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(20, 17)
        Me.LabelControl9.TabIndex = 947
        Me.LabelControl9.Text = "TIN"
        '
        'txtTIN
        '
        Me.txtTIN.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtTIN.EditValue = ""
        Me.txtTIN.Location = New System.Drawing.Point(139, 109)
        Me.txtTIN.Name = "txtTIN"
        Me.txtTIN.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtTIN.Properties.Appearance.Options.UseFont = True
        Me.txtTIN.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTIN.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtTIN.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtTIN.Properties.ReadOnly = True
        Me.txtTIN.Size = New System.Drawing.Size(184, 26)
        Me.txtTIN.TabIndex = 946
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.LabelControl10.Appearance.Options.UseFont = True
        Me.LabelControl10.Location = New System.Drawing.Point(60, 142)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(69, 17)
        Me.LabelControl10.TabIndex = 951
        Me.LabelControl10.Text = "PO Number"
        '
        'txtPONumber
        '
        Me.txtPONumber.EditValue = ""
        Me.txtPONumber.Location = New System.Drawing.Point(139, 138)
        Me.txtPONumber.Name = "txtPONumber"
        Me.txtPONumber.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtPONumber.Properties.Appearance.Options.UseFont = True
        Me.txtPONumber.Properties.Appearance.Options.UseTextOptions = True
        Me.txtPONumber.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtPONumber.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtPONumber.Properties.ReadOnly = True
        Me.txtPONumber.Size = New System.Drawing.Size(184, 26)
        Me.txtPONumber.TabIndex = 950
        '
        'LabelControl11
        '
        Me.LabelControl11.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.LabelControl11.Appearance.Options.UseFont = True
        Me.LabelControl11.Location = New System.Drawing.Point(81, 171)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(48, 17)
        Me.LabelControl11.TabIndex = 953
        Me.LabelControl11.Text = "PO Date"
        '
        'txtPODate
        '
        Me.txtPODate.EditValue = New Date(2019, 6, 10, 16, 23, 25, 399)
        Me.txtPODate.EnterMoveNextControl = True
        Me.txtPODate.Location = New System.Drawing.Point(139, 167)
        Me.txtPODate.Name = "txtPODate"
        Me.txtPODate.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.txtPODate.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtPODate.Properties.Appearance.Options.UseFont = True
        Me.txtPODate.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtPODate.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtPODate.Properties.AutoHeight = False
        Me.txtPODate.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtPODate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtPODate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtPODate.Properties.Mask.EditMask = "MMMM dd, yyyy"
        Me.txtPODate.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtPODate.Size = New System.Drawing.Size(184, 25)
        Me.txtPODate.TabIndex = 952
        '
        'txtSupplier
        '
        Me.txtSupplier.EditValue = "sss"
        Me.txtSupplier.Location = New System.Drawing.Point(139, 14)
        Me.txtSupplier.Name = "txtSupplier"
        Me.txtSupplier.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtSupplier.Properties.Appearance.Options.UseFont = True
        Me.txtSupplier.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtSupplier.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtSupplier.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtSupplier.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtSupplier.Properties.DisplayMember = "Select"
        Me.txtSupplier.Properties.NullText = ""
        Me.txtSupplier.Properties.PopupView = Me.gridSupplier
        Me.txtSupplier.Properties.ValueMember = "code"
        Me.txtSupplier.Size = New System.Drawing.Size(275, 26)
        Me.txtSupplier.TabIndex = 958
        '
        'gridSupplier
        '
        Me.gridSupplier.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gridSupplier.Name = "gridSupplier"
        Me.gridSupplier.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridSupplier.OptionsView.ShowGroupPanel = False
        '
        'LabelControl13
        '
        Me.LabelControl13.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.LabelControl13.Appearance.Options.UseFont = True
        Me.LabelControl13.Location = New System.Drawing.Point(81, 47)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(48, 17)
        Me.LabelControl13.TabIndex = 961
        Me.LabelControl13.Text = "Address"
        '
        'txtAddress
        '
        Me.txtAddress.EditValue = ""
        Me.txtAddress.Location = New System.Drawing.Point(139, 44)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtAddress.Properties.Appearance.Options.UseFont = True
        Me.txtAddress.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtAddress.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtAddress.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtAddress.Properties.ReadOnly = True
        Me.txtAddress.Size = New System.Drawing.Size(367, 61)
        Me.txtAddress.TabIndex = 960
        '
        'txtProcurementMode
        '
        Me.txtProcurementMode.EditValue = "sss"
        Me.txtProcurementMode.Location = New System.Drawing.Point(139, 254)
        Me.txtProcurementMode.Name = "txtProcurementMode"
        Me.txtProcurementMode.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtProcurementMode.Properties.Appearance.Options.UseFont = True
        Me.txtProcurementMode.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtProcurementMode.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtProcurementMode.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtProcurementMode.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtProcurementMode.Properties.DisplayMember = "Select"
        Me.txtProcurementMode.Properties.NullText = ""
        Me.txtProcurementMode.Properties.PopupView = Me.gridProcurementMode
        Me.txtProcurementMode.Properties.ValueMember = "id"
        Me.txtProcurementMode.Size = New System.Drawing.Size(275, 26)
        Me.txtProcurementMode.TabIndex = 962
        '
        'gridProcurementMode
        '
        Me.gridProcurementMode.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gridProcurementMode.Name = "gridProcurementMode"
        Me.gridProcurementMode.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridProcurementMode.OptionsView.ShowGroupPanel = False
        '
        'HyperlinkLabelControl1
        '
        Me.HyperlinkLabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.HyperlinkLabelControl1.Appearance.Options.UseFont = True
        Me.HyperlinkLabelControl1.Location = New System.Drawing.Point(16, 258)
        Me.HyperlinkLabelControl1.Name = "HyperlinkLabelControl1"
        Me.HyperlinkLabelControl1.Size = New System.Drawing.Size(113, 17)
        Me.HyperlinkLabelControl1.TabIndex = 964
        Me.HyperlinkLabelControl1.Text = "Procurement Mode"
        '
        'HyperlinkLabelControl2
        '
        Me.HyperlinkLabelControl2.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.HyperlinkLabelControl2.Appearance.Options.UseFont = True
        Me.HyperlinkLabelControl2.Location = New System.Drawing.Point(81, 15)
        Me.HyperlinkLabelControl2.Name = "HyperlinkLabelControl2"
        Me.HyperlinkLabelControl2.Size = New System.Drawing.Size(48, 17)
        Me.HyperlinkLabelControl2.TabIndex = 965
        Me.HyperlinkLabelControl2.Text = "Supplier"
        '
        'HyperlinkLabelControl3
        '
        Me.HyperlinkLabelControl3.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.HyperlinkLabelControl3.Appearance.Options.UseFont = True
        Me.HyperlinkLabelControl3.Location = New System.Drawing.Point(33, 287)
        Me.HyperlinkLabelControl3.Name = "HyperlinkLabelControl3"
        Me.HyperlinkLabelControl3.Size = New System.Drawing.Size(96, 17)
        Me.HyperlinkLabelControl3.TabIndex = 967
        Me.HyperlinkLabelControl3.Text = "Place of Delivery"
        '
        'txtPlaceofDelivery
        '
        Me.txtPlaceofDelivery.EditValue = "sss"
        Me.txtPlaceofDelivery.Location = New System.Drawing.Point(139, 283)
        Me.txtPlaceofDelivery.Name = "txtPlaceofDelivery"
        Me.txtPlaceofDelivery.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtPlaceofDelivery.Properties.Appearance.Options.UseFont = True
        Me.txtPlaceofDelivery.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtPlaceofDelivery.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtPlaceofDelivery.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtPlaceofDelivery.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtPlaceofDelivery.Properties.DisplayMember = "Select"
        Me.txtPlaceofDelivery.Properties.NullText = ""
        Me.txtPlaceofDelivery.Properties.PopupView = Me.gridPlaceOfDelivery
        Me.txtPlaceofDelivery.Properties.ValueMember = "id"
        Me.txtPlaceofDelivery.Size = New System.Drawing.Size(275, 26)
        Me.txtPlaceofDelivery.TabIndex = 966
        '
        'gridPlaceOfDelivery
        '
        Me.gridPlaceOfDelivery.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gridPlaceOfDelivery.Name = "gridPlaceOfDelivery"
        Me.gridPlaceOfDelivery.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridPlaceOfDelivery.OptionsView.ShowGroupPanel = False
        '
        'HyperlinkLabelControl4
        '
        Me.HyperlinkLabelControl4.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.HyperlinkLabelControl4.Appearance.Options.UseFont = True
        Me.HyperlinkLabelControl4.Location = New System.Drawing.Point(52, 313)
        Me.HyperlinkLabelControl4.Name = "HyperlinkLabelControl4"
        Me.HyperlinkLabelControl4.Size = New System.Drawing.Size(77, 17)
        Me.HyperlinkLabelControl4.TabIndex = 969
        Me.HyperlinkLabelControl4.Text = "Date Delivery"
        '
        'txtDateDelivery
        '
        Me.txtDateDelivery.EditValue = "sss"
        Me.txtDateDelivery.Location = New System.Drawing.Point(139, 312)
        Me.txtDateDelivery.Name = "txtDateDelivery"
        Me.txtDateDelivery.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtDateDelivery.Properties.Appearance.Options.UseFont = True
        Me.txtDateDelivery.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtDateDelivery.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtDateDelivery.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtDateDelivery.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtDateDelivery.Properties.DisplayMember = "Select"
        Me.txtDateDelivery.Properties.NullText = ""
        Me.txtDateDelivery.Properties.PopupView = Me.gridDateDelivery
        Me.txtDateDelivery.Properties.ValueMember = "id"
        Me.txtDateDelivery.Size = New System.Drawing.Size(275, 26)
        Me.txtDateDelivery.TabIndex = 968
        '
        'gridDateDelivery
        '
        Me.gridDateDelivery.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gridDateDelivery.Name = "gridDateDelivery"
        Me.gridDateDelivery.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridDateDelivery.OptionsView.ShowGroupPanel = False
        '
        'HyperlinkLabelControl5
        '
        Me.HyperlinkLabelControl5.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.HyperlinkLabelControl5.Appearance.Options.UseFont = True
        Me.HyperlinkLabelControl5.Location = New System.Drawing.Point(49, 342)
        Me.HyperlinkLabelControl5.Name = "HyperlinkLabelControl5"
        Me.HyperlinkLabelControl5.Size = New System.Drawing.Size(80, 17)
        Me.HyperlinkLabelControl5.TabIndex = 971
        Me.HyperlinkLabelControl5.Text = "Delivery Term"
        '
        'txtDeliveryTerm
        '
        Me.txtDeliveryTerm.EditValue = "sss"
        Me.txtDeliveryTerm.Location = New System.Drawing.Point(139, 341)
        Me.txtDeliveryTerm.Name = "txtDeliveryTerm"
        Me.txtDeliveryTerm.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtDeliveryTerm.Properties.Appearance.Options.UseFont = True
        Me.txtDeliveryTerm.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtDeliveryTerm.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtDeliveryTerm.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtDeliveryTerm.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtDeliveryTerm.Properties.DisplayMember = "Select"
        Me.txtDeliveryTerm.Properties.NullText = ""
        Me.txtDeliveryTerm.Properties.PopupView = Me.gridDeliveryTerm
        Me.txtDeliveryTerm.Properties.ValueMember = "id"
        Me.txtDeliveryTerm.Size = New System.Drawing.Size(275, 26)
        Me.txtDeliveryTerm.TabIndex = 970
        '
        'gridDeliveryTerm
        '
        Me.gridDeliveryTerm.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gridDeliveryTerm.Name = "gridDeliveryTerm"
        Me.gridDeliveryTerm.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridDeliveryTerm.OptionsView.ShowGroupPanel = False
        '
        'HyperlinkLabelControl6
        '
        Me.HyperlinkLabelControl6.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.HyperlinkLabelControl6.Appearance.Options.UseFont = True
        Me.HyperlinkLabelControl6.Location = New System.Drawing.Point(46, 371)
        Me.HyperlinkLabelControl6.Name = "HyperlinkLabelControl6"
        Me.HyperlinkLabelControl6.Size = New System.Drawing.Size(83, 17)
        Me.HyperlinkLabelControl6.TabIndex = 973
        Me.HyperlinkLabelControl6.Text = "Payment Term"
        '
        'txtPaymentTerm
        '
        Me.txtPaymentTerm.EditValue = "sss"
        Me.txtPaymentTerm.Location = New System.Drawing.Point(139, 370)
        Me.txtPaymentTerm.Name = "txtPaymentTerm"
        Me.txtPaymentTerm.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtPaymentTerm.Properties.Appearance.Options.UseFont = True
        Me.txtPaymentTerm.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtPaymentTerm.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtPaymentTerm.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtPaymentTerm.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtPaymentTerm.Properties.DisplayMember = "Select"
        Me.txtPaymentTerm.Properties.NullText = ""
        Me.txtPaymentTerm.Properties.PopupView = Me.gridPaymentTerm
        Me.txtPaymentTerm.Properties.ValueMember = "id"
        Me.txtPaymentTerm.Size = New System.Drawing.Size(275, 26)
        Me.txtPaymentTerm.TabIndex = 972
        '
        'gridPaymentTerm
        '
        Me.gridPaymentTerm.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gridPaymentTerm.Name = "gridPaymentTerm"
        Me.gridPaymentTerm.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridPaymentTerm.OptionsView.ShowGroupPanel = False
        '
        'periodcode
        '
        Me.periodcode.Location = New System.Drawing.Point(329, 113)
        Me.periodcode.Name = "periodcode"
        Me.periodcode.Properties.Appearance.Options.UseFont = True
        Me.periodcode.Properties.Appearance.Options.UseTextOptions = True
        Me.periodcode.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.periodcode.Properties.ReadOnly = True
        Me.periodcode.Size = New System.Drawing.Size(47, 20)
        Me.periodcode.TabIndex = 974
        Me.periodcode.Visible = False
        '
        'pid
        '
        Me.pid.Location = New System.Drawing.Point(329, 140)
        Me.pid.Name = "pid"
        Me.pid.Properties.Appearance.Options.UseFont = True
        Me.pid.Properties.Appearance.Options.UseTextOptions = True
        Me.pid.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.pid.Properties.ReadOnly = True
        Me.pid.Size = New System.Drawing.Size(47, 20)
        Me.pid.TabIndex = 975
        Me.pid.Visible = False
        '
        'Em
        '
        Me.Em.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Em.Location = New System.Drawing.Point(519, 15)
        Me.Em.MainView = Me.GridView1
        Me.Em.MinimumSize = New System.Drawing.Size(556, 442)
        Me.Em.Name = "Em"
        Me.Em.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1})
        Me.Em.Size = New System.Drawing.Size(556, 545)
        Me.Em.TabIndex = 976
        Me.Em.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.Em
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsSelection.MultiSelect = True
        Me.GridView1.OptionsSelection.UseIndicatorForSelection = False
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.RowAutoHeight = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        Me.RepositoryItemCheckEdit1.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        '
        'ckNegotiated
        '
        Me.ckNegotiated.Location = New System.Drawing.Point(139, 431)
        Me.ckNegotiated.Name = "ckNegotiated"
        Me.ckNegotiated.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.ckNegotiated.Properties.Appearance.Options.UseFont = True
        Me.ckNegotiated.Properties.Caption = "Negotiated Purchased"
        Me.ckNegotiated.Size = New System.Drawing.Size(275, 21)
        Me.ckNegotiated.TabIndex = 977
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(46, 458)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(83, 17)
        Me.LabelControl1.TabIndex = 979
        Me.LabelControl1.Text = "Resolution No"
        '
        'txtResolutionNo
        '
        Me.txtResolutionNo.EditValue = ""
        Me.txtResolutionNo.Enabled = False
        Me.txtResolutionNo.Location = New System.Drawing.Point(139, 454)
        Me.txtResolutionNo.Name = "txtResolutionNo"
        Me.txtResolutionNo.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtResolutionNo.Properties.Appearance.Options.UseFont = True
        Me.txtResolutionNo.Properties.Appearance.Options.UseTextOptions = True
        Me.txtResolutionNo.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtResolutionNo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtResolutionNo.Size = New System.Drawing.Size(184, 26)
        Me.txtResolutionNo.TabIndex = 978
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(40, 487)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(89, 17)
        Me.LabelControl2.TabIndex = 981
        Me.LabelControl2.Text = "Date Approved"
        '
        'txtDateApproved
        '
        Me.txtDateApproved.EditValue = Nothing
        Me.txtDateApproved.Enabled = False
        Me.txtDateApproved.Location = New System.Drawing.Point(139, 483)
        Me.txtDateApproved.Name = "txtDateApproved"
        Me.txtDateApproved.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtDateApproved.Properties.Appearance.Options.UseFont = True
        Me.txtDateApproved.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtDateApproved.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtDateApproved.Properties.AppearanceFocused.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtDateApproved.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtDateApproved.Properties.AppearanceFocused.Options.UseFont = True
        Me.txtDateApproved.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtDateApproved.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtDateApproved.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtDateApproved.Properties.Mask.EditMask = "MMMM dd, yyyy"
        Me.txtDateApproved.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtDateApproved.Size = New System.Drawing.Size(184, 26)
        Me.txtDateApproved.TabIndex = 982
        '
        'txtAddPrintLine
        '
        Me.txtAddPrintLine.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtAddPrintLine.EditValue = "6"
        Me.txtAddPrintLine.Location = New System.Drawing.Point(139, 399)
        Me.txtAddPrintLine.Name = "txtAddPrintLine"
        Me.txtAddPrintLine.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtAddPrintLine.Properties.Appearance.Options.UseFont = True
        Me.txtAddPrintLine.Properties.Appearance.Options.UseTextOptions = True
        Me.txtAddPrintLine.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtAddPrintLine.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtAddPrintLine.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtAddPrintLine.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtAddPrintLine.Properties.Mask.EditMask = "N0"
        Me.txtAddPrintLine.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtAddPrintLine.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtAddPrintLine.Size = New System.Drawing.Size(62, 26)
        Me.txtAddPrintLine.TabIndex = 984
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Location = New System.Drawing.Point(50, 403)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(81, 17)
        Me.LabelControl4.TabIndex = 983
        Me.LabelControl4.Text = "Add Print Line"
        '
        'frmPurchaseOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1087, 572)
        Me.Controls.Add(Me.txtAddPrintLine)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.txtDateApproved)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.txtResolutionNo)
        Me.Controls.Add(Me.ckNegotiated)
        Me.Controls.Add(Me.Em)
        Me.Controls.Add(Me.pid)
        Me.Controls.Add(Me.periodcode)
        Me.Controls.Add(Me.HyperlinkLabelControl6)
        Me.Controls.Add(Me.txtPaymentTerm)
        Me.Controls.Add(Me.HyperlinkLabelControl5)
        Me.Controls.Add(Me.txtDeliveryTerm)
        Me.Controls.Add(Me.HyperlinkLabelControl4)
        Me.Controls.Add(Me.txtDateDelivery)
        Me.Controls.Add(Me.HyperlinkLabelControl3)
        Me.Controls.Add(Me.txtPlaceofDelivery)
        Me.Controls.Add(Me.HyperlinkLabelControl2)
        Me.Controls.Add(Me.HyperlinkLabelControl1)
        Me.Controls.Add(Me.txtProcurementMode)
        Me.Controls.Add(Me.LabelControl13)
        Me.Controls.Add(Me.txtSupplier)
        Me.Controls.Add(Me.LabelControl11)
        Me.Controls.Add(Me.txtPODate)
        Me.Controls.Add(Me.LabelControl10)
        Me.Controls.Add(Me.txtPONumber)
        Me.Controls.Add(Me.LabelControl9)
        Me.Controls.Add(Me.txtTIN)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.txtPostingDate)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.txtPRNumber)
        Me.Controls.Add(Me.cmdaction)
        Me.Controls.Add(Me.txtAddress)
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(1103, 508)
        Me.Name = "frmPurchaseOrder"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Purchase Order"
        CType(Me.txtPRNumber.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPostingDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPostingDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTIN.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPONumber.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPODate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPODate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSupplier.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridSupplier, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAddress.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtProcurementMode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridProcurementMode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPlaceofDelivery.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridPlaceOfDelivery, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDateDelivery.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridDateDelivery, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDeliveryTerm.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridDeliveryTerm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPaymentTerm.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridPaymentTerm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.periodcode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ckNegotiated.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtResolutionNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDateApproved.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDateApproved.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAddPrintLine.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdaction As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPRNumber As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPostingDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTIN As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPONumber As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPODate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtSupplier As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents gridSupplier As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtAddress As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents txtProcurementMode As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents gridProcurementMode As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents HyperlinkLabelControl1 As DevExpress.XtraEditors.HyperlinkLabelControl
    Friend WithEvents HyperlinkLabelControl2 As DevExpress.XtraEditors.HyperlinkLabelControl
    Friend WithEvents HyperlinkLabelControl3 As DevExpress.XtraEditors.HyperlinkLabelControl
    Friend WithEvents txtPlaceofDelivery As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents gridPlaceOfDelivery As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents HyperlinkLabelControl4 As DevExpress.XtraEditors.HyperlinkLabelControl
    Friend WithEvents txtDateDelivery As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents gridDateDelivery As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents HyperlinkLabelControl5 As DevExpress.XtraEditors.HyperlinkLabelControl
    Friend WithEvents txtDeliveryTerm As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents gridDeliveryTerm As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents HyperlinkLabelControl6 As DevExpress.XtraEditors.HyperlinkLabelControl
    Friend WithEvents txtPaymentTerm As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents gridPaymentTerm As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents periodcode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents pid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Em As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents ckNegotiated As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtResolutionNo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDateApproved As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtAddPrintLine As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
End Class
