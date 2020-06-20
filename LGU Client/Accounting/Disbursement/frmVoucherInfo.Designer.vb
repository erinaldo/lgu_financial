<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVoucherInfo
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
        Me.components = New System.ComponentModel.Container()
        Me.yeartrn = New DevExpress.XtraEditors.ButtonEdit()
        Me.seriesno = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.txtVoucherDate = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.txtRequisitionAmount = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.radPaymentType = New DevExpress.XtraEditors.RadioGroup()
        Me.id = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.mode = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl15 = New DevExpress.XtraEditors.LabelControl()
        Me.voucherno = New DevExpress.XtraEditors.TextEdit()
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton()
        Me.Em = New DevExpress.XtraGrid.GridControl()
        Me.ContexExplaination = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmdAdd = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdRemove = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdRefresh = New System.Windows.Forms.ToolStripMenuItem()
        Me.Gridview1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txtVoucherAmount = New DevExpress.XtraEditors.TextEdit()
        Me.txtSupplier = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.gridSupplier = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.HyperlinkLabelControl1 = New DevExpress.XtraEditors.HyperlinkLabelControl()
        Me.txtFund = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.gridFund = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.fundcode = New DevExpress.XtraEditors.TextEdit()
        Me.periodcode = New DevExpress.XtraEditors.TextEdit()
        Me.yearcode = New DevExpress.XtraEditors.TextEdit()
        Me.Em_requisition = New DevExpress.XtraGrid.GridControl()
        Me.ContextRequisition = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmdAddApprovedRequisition = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdRemoveRequisition = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdRefreshRequisition = New System.Windows.Forms.ToolStripMenuItem()
        Me.gridRequisition = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.yeartrn.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.seriesno.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtVoucherDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtVoucherDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRequisitionAmount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.radPaymentType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.id.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.voucherno.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContexExplaination.SuspendLayout()
        CType(Me.Gridview1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtVoucherAmount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSupplier.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridSupplier, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFund.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridFund, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fundcode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.periodcode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.yearcode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Em_requisition, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextRequisition.SuspendLayout()
        CType(Me.gridRequisition, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'yeartrn
        '
        Me.yeartrn.EditValue = ""
        Me.yeartrn.Location = New System.Drawing.Point(874, 86)
        Me.yeartrn.Name = "yeartrn"
        Me.yeartrn.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.yeartrn.Properties.Appearance.Options.UseFont = True
        Me.yeartrn.Properties.Appearance.Options.UseTextOptions = True
        Me.yeartrn.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.yeartrn.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.yeartrn.Properties.Mask.BeepOnError = True
        Me.yeartrn.Properties.ReadOnly = True
        Me.yeartrn.Size = New System.Drawing.Size(49, 22)
        Me.yeartrn.TabIndex = 933
        Me.yeartrn.Visible = False
        '
        'seriesno
        '
        Me.seriesno.EditValue = ""
        Me.seriesno.EnterMoveNextControl = True
        Me.seriesno.Location = New System.Drawing.Point(874, 111)
        Me.seriesno.Name = "seriesno"
        Me.seriesno.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.seriesno.Properties.Appearance.Options.UseFont = True
        Me.seriesno.Properties.MaxLength = 50
        Me.seriesno.Properties.ReadOnly = True
        Me.seriesno.Size = New System.Drawing.Size(49, 22)
        Me.seriesno.TabIndex = 928
        Me.seriesno.Visible = False
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.LabelControl8.Appearance.Options.UseFont = True
        Me.LabelControl8.Appearance.Options.UseTextOptions = True
        Me.LabelControl8.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl8.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.LabelControl8.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal
        Me.LabelControl8.Location = New System.Drawing.Point(55, 90)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(79, 17)
        Me.LabelControl8.TabIndex = 927
        Me.LabelControl8.Text = "Voucher Date"
        '
        'txtVoucherDate
        '
        Me.txtVoucherDate.EditValue = Nothing
        Me.txtVoucherDate.EnterMoveNextControl = True
        Me.txtVoucherDate.Location = New System.Drawing.Point(143, 85)
        Me.txtVoucherDate.Name = "txtVoucherDate"
        Me.txtVoucherDate.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtVoucherDate.Properties.Appearance.Options.UseFont = True
        Me.txtVoucherDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtVoucherDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtVoucherDate.Properties.Mask.EditMask = "MMMM dd, yyyy"
        Me.txtVoucherDate.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtVoucherDate.Size = New System.Drawing.Size(170, 24)
        Me.txtVoucherDate.TabIndex = 926
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.LabelControl7.Appearance.Options.UseFont = True
        Me.LabelControl7.Appearance.Options.UseTextOptions = True
        Me.LabelControl7.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl7.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.LabelControl7.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal
        Me.LabelControl7.Location = New System.Drawing.Point(21, 263)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(113, 17)
        Me.LabelControl7.TabIndex = 925
        Me.LabelControl7.Text = "Requisition Amount"
        '
        'txtRequisitionAmount
        '
        Me.txtRequisitionAmount.EditValue = "0"
        Me.txtRequisitionAmount.EnterMoveNextControl = True
        Me.txtRequisitionAmount.Location = New System.Drawing.Point(143, 257)
        Me.txtRequisitionAmount.Name = "txtRequisitionAmount"
        Me.txtRequisitionAmount.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.75!)
        Me.txtRequisitionAmount.Properties.Appearance.Options.UseFont = True
        Me.txtRequisitionAmount.Properties.Appearance.Options.UseTextOptions = True
        Me.txtRequisitionAmount.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtRequisitionAmount.Properties.Mask.EditMask = "n"
        Me.txtRequisitionAmount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtRequisitionAmount.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtRequisitionAmount.Properties.MaxLength = 50
        Me.txtRequisitionAmount.Properties.ReadOnly = True
        Me.txtRequisitionAmount.Size = New System.Drawing.Size(149, 28)
        Me.txtRequisitionAmount.TabIndex = 924
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseTextOptions = True
        Me.LabelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.LabelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal
        Me.LabelControl1.Location = New System.Drawing.Point(385, 34)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(364, 17)
        Me.LabelControl1.TabIndex = 919
        Me.LabelControl1.Text = "Disbursement Explanation (Right Click to Add, Edit or Remove)"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Appearance.Options.UseTextOptions = True
        Me.LabelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl2.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.LabelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal
        Me.LabelControl2.Location = New System.Drawing.Point(59, 141)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(75, 17)
        Me.LabelControl2.TabIndex = 915
        Me.LabelControl2.Text = "Classification"
        '
        'radPaymentType
        '
        Me.radPaymentType.EditValue = "ca"
        Me.radPaymentType.Location = New System.Drawing.Point(143, 141)
        Me.radPaymentType.Name = "radPaymentType"
        Me.radPaymentType.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.radPaymentType.Properties.Appearance.Options.UseFont = True
        Me.radPaymentType.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem("ca", "Cash Advance"), New DevExpress.XtraEditors.Controls.RadioGroupItem("reimbursement", "Reimbursement"), New DevExpress.XtraEditors.Controls.RadioGroupItem("others", "Others")})
        Me.radPaymentType.Size = New System.Drawing.Size(232, 84)
        Me.radPaymentType.TabIndex = 901
        '
        'id
        '
        Me.id.EditValue = ""
        Me.id.EnterMoveNextControl = True
        Me.id.Location = New System.Drawing.Point(929, 86)
        Me.id.Name = "id"
        Me.id.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.id.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.id.Properties.Appearance.Options.UseFont = True
        Me.id.Properties.Appearance.Options.UseForeColor = True
        Me.id.Properties.Appearance.Options.UseTextOptions = True
        Me.id.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.id.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.id.Properties.MaxLength = 50
        Me.id.Properties.ReadOnly = True
        Me.id.Size = New System.Drawing.Size(49, 22)
        Me.id.TabIndex = 914
        Me.id.Visible = False
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Appearance.Options.UseTextOptions = True
        Me.LabelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl3.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.LabelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal
        Me.LabelControl3.Location = New System.Drawing.Point(37, 12)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(305, 28)
        Me.LabelControl3.TabIndex = 912
        Me.LabelControl3.Text = "Disbursement Voucher Information"
        '
        'mode
        '
        Me.mode.EditValue = ""
        Me.mode.EnterMoveNextControl = True
        Me.mode.Location = New System.Drawing.Point(929, 111)
        Me.mode.Name = "mode"
        Me.mode.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.mode.Properties.Appearance.Options.UseFont = True
        Me.mode.Properties.MaxLength = 50
        Me.mode.Properties.ReadOnly = True
        Me.mode.Size = New System.Drawing.Size(49, 22)
        Me.mode.TabIndex = 910
        Me.mode.Visible = False
        '
        'LabelControl15
        '
        Me.LabelControl15.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.LabelControl15.Appearance.Options.UseFont = True
        Me.LabelControl15.Appearance.Options.UseTextOptions = True
        Me.LabelControl15.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl15.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.LabelControl15.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal
        Me.LabelControl15.Location = New System.Drawing.Point(92, 118)
        Me.LabelControl15.Name = "LabelControl15"
        Me.LabelControl15.Size = New System.Drawing.Size(42, 17)
        Me.LabelControl15.TabIndex = 909
        Me.LabelControl15.Text = "DV No."
        '
        'voucherno
        '
        Me.voucherno.EditValue = ""
        Me.voucherno.EnterMoveNextControl = True
        Me.voucherno.Location = New System.Drawing.Point(143, 113)
        Me.voucherno.Name = "voucherno"
        Me.voucherno.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.voucherno.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.voucherno.Properties.Appearance.Options.UseFont = True
        Me.voucherno.Properties.Appearance.Options.UseForeColor = True
        Me.voucherno.Properties.Appearance.Options.UseTextOptions = True
        Me.voucherno.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.voucherno.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.voucherno.Properties.ReadOnly = True
        Me.voucherno.Size = New System.Drawing.Size(170, 24)
        Me.voucherno.TabIndex = 908
        '
        'cmdSave
        '
        Me.cmdSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.cmdSave.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmdSave.Appearance.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmdSave.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.cmdSave.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.cmdSave.Appearance.Options.UseBackColor = True
        Me.cmdSave.Appearance.Options.UseFont = True
        Me.cmdSave.Location = New System.Drawing.Point(401, 614)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(196, 35)
        Me.cmdSave.TabIndex = 907
        Me.cmdSave.Text = "Save Voucher"
        '
        'Em
        '
        Me.Em.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Em.ContextMenuStrip = Me.ContexExplaination
        Me.Em.Location = New System.Drawing.Point(385, 55)
        Me.Em.MainView = Me.Gridview1
        Me.Em.Name = "Em"
        Me.Em.Size = New System.Drawing.Size(602, 262)
        Me.Em.TabIndex = 913
        Me.Em.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.Gridview1})
        '
        'ContexExplaination
        '
        Me.ContexExplaination.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdAdd, Me.cmdEdit, Me.cmdRemove, Me.ToolStripSeparator1, Me.cmdRefresh})
        Me.ContexExplaination.Name = "gridmenustrip"
        Me.ContexExplaination.Size = New System.Drawing.Size(200, 98)
        '
        'cmdAdd
        '
        Me.cmdAdd.Image = Global.LGUClient.My.Resources.Resources.notebook__plus
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(199, 22)
        Me.cmdAdd.Text = "Add Disbursement Item"
        '
        'cmdEdit
        '
        Me.cmdEdit.Image = Global.LGUClient.My.Resources.Resources.notebook__pencil
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(199, 22)
        Me.cmdEdit.Text = "Edit Selected Item"
        '
        'cmdRemove
        '
        Me.cmdRemove.Image = Global.LGUClient.My.Resources.Resources.notebook__minus
        Me.cmdRemove.Name = "cmdRemove"
        Me.cmdRemove.Size = New System.Drawing.Size(199, 22)
        Me.cmdRemove.Text = "Remove Selected Item"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(196, 6)
        '
        'cmdRefresh
        '
        Me.cmdRefresh.Image = Global.LGUClient.My.Resources.Resources.arrow_continue_090
        Me.cmdRefresh.Name = "cmdRefresh"
        Me.cmdRefresh.Size = New System.Drawing.Size(199, 22)
        Me.cmdRefresh.Text = "Refresh Item List"
        '
        'Gridview1
        '
        Me.Gridview1.Appearance.FooterPanel.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Gridview1.Appearance.FooterPanel.Options.UseFont = True
        Me.Gridview1.Appearance.GroupFooter.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Gridview1.Appearance.GroupFooter.Options.UseFont = True
        Me.Gridview1.Appearance.HeaderPanel.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Gridview1.Appearance.HeaderPanel.Options.UseFont = True
        Me.Gridview1.Appearance.Row.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gridview1.Appearance.Row.Options.UseFont = True
        Me.Gridview1.GridControl = Me.Em
        Me.Gridview1.Name = "Gridview1"
        Me.Gridview1.OptionsBehavior.Editable = False
        Me.Gridview1.OptionsView.RowAutoHeight = True
        Me.Gridview1.OptionsView.ShowFooter = True
        Me.Gridview1.OptionsView.ShowGroupPanel = False
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Appearance.Options.UseTextOptions = True
        Me.LabelControl4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl4.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.LabelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal
        Me.LabelControl4.Location = New System.Drawing.Point(37, 294)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(97, 17)
        Me.LabelControl4.TabIndex = 939
        Me.LabelControl4.Text = "Voucher Amount"
        '
        'txtVoucherAmount
        '
        Me.txtVoucherAmount.EditValue = "0"
        Me.txtVoucherAmount.EnterMoveNextControl = True
        Me.txtVoucherAmount.Location = New System.Drawing.Point(143, 288)
        Me.txtVoucherAmount.Name = "txtVoucherAmount"
        Me.txtVoucherAmount.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.75!)
        Me.txtVoucherAmount.Properties.Appearance.Options.UseFont = True
        Me.txtVoucherAmount.Properties.Appearance.Options.UseTextOptions = True
        Me.txtVoucherAmount.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtVoucherAmount.Properties.Mask.EditMask = "n"
        Me.txtVoucherAmount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtVoucherAmount.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtVoucherAmount.Properties.MaxLength = 50
        Me.txtVoucherAmount.Properties.ReadOnly = True
        Me.txtVoucherAmount.Size = New System.Drawing.Size(149, 28)
        Me.txtVoucherAmount.TabIndex = 938
        '
        'txtSupplier
        '
        Me.txtSupplier.EditValue = "sss"
        Me.txtSupplier.Location = New System.Drawing.Point(143, 228)
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
        Me.txtSupplier.Size = New System.Drawing.Size(232, 26)
        Me.txtSupplier.TabIndex = 950
        '
        'gridSupplier
        '
        Me.gridSupplier.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gridSupplier.Name = "gridSupplier"
        Me.gridSupplier.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridSupplier.OptionsView.ShowGroupPanel = False
        '
        'HyperlinkLabelControl1
        '
        Me.HyperlinkLabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.HyperlinkLabelControl1.Appearance.Options.UseFont = True
        Me.HyperlinkLabelControl1.Location = New System.Drawing.Point(100, 232)
        Me.HyperlinkLabelControl1.Name = "HyperlinkLabelControl1"
        Me.HyperlinkLabelControl1.Size = New System.Drawing.Size(34, 17)
        Me.HyperlinkLabelControl1.TabIndex = 965
        Me.HyperlinkLabelControl1.Text = "Payee"
        '
        'txtFund
        '
        Me.txtFund.EditValue = "sss"
        Me.txtFund.Location = New System.Drawing.Point(143, 56)
        Me.txtFund.Name = "txtFund"
        Me.txtFund.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtFund.Properties.Appearance.Options.UseFont = True
        Me.txtFund.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtFund.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtFund.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtFund.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtFund.Properties.DisplayMember = "Select"
        Me.txtFund.Properties.NullText = ""
        Me.txtFund.Properties.PopupView = Me.gridFund
        Me.txtFund.Properties.ValueMember = "code"
        Me.txtFund.Size = New System.Drawing.Size(232, 26)
        Me.txtFund.TabIndex = 971
        '
        'gridFund
        '
        Me.gridFund.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gridFund.Name = "gridFund"
        Me.gridFund.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridFund.OptionsView.ShowGroupPanel = False
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.LabelControl6.Appearance.Options.UseFont = True
        Me.LabelControl6.Location = New System.Drawing.Point(64, 60)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(70, 17)
        Me.LabelControl6.TabIndex = 972
        Me.LabelControl6.Text = "Fund Period"
        '
        'fundcode
        '
        Me.fundcode.EditValue = ""
        Me.fundcode.EnterMoveNextControl = True
        Me.fundcode.Location = New System.Drawing.Point(874, 137)
        Me.fundcode.Name = "fundcode"
        Me.fundcode.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.fundcode.Properties.Appearance.Options.UseFont = True
        Me.fundcode.Properties.MaxLength = 50
        Me.fundcode.Properties.ReadOnly = True
        Me.fundcode.Size = New System.Drawing.Size(49, 22)
        Me.fundcode.TabIndex = 973
        Me.fundcode.Visible = False
        '
        'periodcode
        '
        Me.periodcode.EditValue = ""
        Me.periodcode.EnterMoveNextControl = True
        Me.periodcode.Location = New System.Drawing.Point(929, 137)
        Me.periodcode.Name = "periodcode"
        Me.periodcode.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.periodcode.Properties.Appearance.Options.UseFont = True
        Me.periodcode.Properties.MaxLength = 50
        Me.periodcode.Properties.ReadOnly = True
        Me.periodcode.Size = New System.Drawing.Size(49, 22)
        Me.periodcode.TabIndex = 974
        Me.periodcode.Visible = False
        '
        'yearcode
        '
        Me.yearcode.EditValue = ""
        Me.yearcode.EnterMoveNextControl = True
        Me.yearcode.Location = New System.Drawing.Point(874, 164)
        Me.yearcode.Name = "yearcode"
        Me.yearcode.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.yearcode.Properties.Appearance.Options.UseFont = True
        Me.yearcode.Properties.MaxLength = 50
        Me.yearcode.Properties.ReadOnly = True
        Me.yearcode.Size = New System.Drawing.Size(49, 22)
        Me.yearcode.TabIndex = 975
        Me.yearcode.Visible = False
        '
        'Em_requisition
        '
        Me.Em_requisition.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Em_requisition.ContextMenuStrip = Me.ContextRequisition
        Me.Em_requisition.Location = New System.Drawing.Point(12, 358)
        Me.Em_requisition.MainView = Me.gridRequisition
        Me.Em_requisition.Name = "Em_requisition"
        Me.Em_requisition.Size = New System.Drawing.Size(975, 249)
        Me.Em_requisition.TabIndex = 976
        Me.Em_requisition.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridRequisition})
        '
        'ContextRequisition
        '
        Me.ContextRequisition.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdAddApprovedRequisition, Me.cmdRemoveRequisition, Me.ToolStripSeparator2, Me.cmdRefreshRequisition})
        Me.ContextRequisition.Name = "gridmenustrip"
        Me.ContextRequisition.Size = New System.Drawing.Size(214, 76)
        '
        'cmdAddApprovedRequisition
        '
        Me.cmdAddApprovedRequisition.Image = Global.LGUClient.My.Resources.Resources.notebook__plus
        Me.cmdAddApprovedRequisition.Name = "cmdAddApprovedRequisition"
        Me.cmdAddApprovedRequisition.Size = New System.Drawing.Size(213, 22)
        Me.cmdAddApprovedRequisition.Text = "Add Approved Requisition"
        '
        'cmdRemoveRequisition
        '
        Me.cmdRemoveRequisition.Image = Global.LGUClient.My.Resources.Resources.notebook__minus
        Me.cmdRemoveRequisition.Name = "cmdRemoveRequisition"
        Me.cmdRemoveRequisition.Size = New System.Drawing.Size(213, 22)
        Me.cmdRemoveRequisition.Text = "Remove Selected Item"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(210, 6)
        '
        'cmdRefreshRequisition
        '
        Me.cmdRefreshRequisition.Image = Global.LGUClient.My.Resources.Resources.arrow_continue_090
        Me.cmdRefreshRequisition.Name = "cmdRefreshRequisition"
        Me.cmdRefreshRequisition.Size = New System.Drawing.Size(213, 22)
        Me.cmdRefreshRequisition.Text = "Refresh Item List"
        '
        'gridRequisition
        '
        Me.gridRequisition.Appearance.FooterPanel.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.gridRequisition.Appearance.FooterPanel.Options.UseFont = True
        Me.gridRequisition.Appearance.GroupFooter.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.gridRequisition.Appearance.GroupFooter.Options.UseFont = True
        Me.gridRequisition.Appearance.HeaderPanel.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.gridRequisition.Appearance.HeaderPanel.Options.UseFont = True
        Me.gridRequisition.Appearance.Row.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridRequisition.Appearance.Row.Options.UseFont = True
        Me.gridRequisition.GridControl = Me.Em_requisition
        Me.gridRequisition.Name = "gridRequisition"
        Me.gridRequisition.OptionsBehavior.Editable = False
        Me.gridRequisition.OptionsView.ColumnAutoWidth = False
        Me.gridRequisition.OptionsView.RowAutoHeight = True
        Me.gridRequisition.OptionsView.ShowFooter = True
        Me.gridRequisition.OptionsView.ShowGroupPanel = False
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.LabelControl10.Appearance.Options.UseFont = True
        Me.LabelControl10.Appearance.Options.UseTextOptions = True
        Me.LabelControl10.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl10.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.LabelControl10.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal
        Me.LabelControl10.Location = New System.Drawing.Point(12, 337)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(765, 17)
        Me.LabelControl10.TabIndex = 977
        Me.LabelControl10.Text = "Tagging of approved requisition list proceeding to disbursement voucher (Right Cl" & _
    "ick to Add, Edit or Remove, Double click to view)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'frmVoucherInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1004, 663)
        Me.Controls.Add(Me.LabelControl10)
        Me.Controls.Add(Me.Em_requisition)
        Me.Controls.Add(Me.yearcode)
        Me.Controls.Add(Me.periodcode)
        Me.Controls.Add(Me.fundcode)
        Me.Controls.Add(Me.txtFund)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.HyperlinkLabelControl1)
        Me.Controls.Add(Me.txtSupplier)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.txtVoucherAmount)
        Me.Controls.Add(Me.yeartrn)
        Me.Controls.Add(Me.seriesno)
        Me.Controls.Add(Me.LabelControl8)
        Me.Controls.Add(Me.txtVoucherDate)
        Me.Controls.Add(Me.LabelControl7)
        Me.Controls.Add(Me.txtRequisitionAmount)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.radPaymentType)
        Me.Controls.Add(Me.id)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.mode)
        Me.Controls.Add(Me.LabelControl15)
        Me.Controls.Add(Me.voucherno)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.Em)
        Me.HelpButton = True
        Me.MinimumSize = New System.Drawing.Size(1020, 702)
        Me.Name = "frmVoucherInfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Disbursement Voucher Information"
        CType(Me.yeartrn.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.seriesno.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtVoucherDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtVoucherDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRequisitionAmount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.radPaymentType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.id.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.voucherno.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContexExplaination.ResumeLayout(False)
        CType(Me.Gridview1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtVoucherAmount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSupplier.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridSupplier, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFund.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridFund, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fundcode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.periodcode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.yearcode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Em_requisition, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextRequisition.ResumeLayout(False)
        CType(Me.gridRequisition, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents yeartrn As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents seriesno As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtVoucherDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtRequisitionAmount As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents radPaymentType As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents id As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents mode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl15 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents voucherno As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Em As DevExpress.XtraGrid.GridControl
    Friend WithEvents ContexExplaination As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmdAdd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdRemove As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdRefresh As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Gridview1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtVoucherAmount As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtSupplier As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents gridSupplier As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents HyperlinkLabelControl1 As DevExpress.XtraEditors.HyperlinkLabelControl
    Friend WithEvents txtFund As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents gridFund As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents fundcode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents periodcode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents yearcode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Em_requisition As DevExpress.XtraGrid.GridControl
    Friend WithEvents gridRequisition As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ContextRequisition As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmdAddApprovedRequisition As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdRemoveRequisition As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdRefreshRequisition As System.Windows.Forms.ToolStripMenuItem
End Class
