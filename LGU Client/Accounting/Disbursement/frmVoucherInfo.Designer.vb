<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmVoucherInfo
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
        Me.components = New System.ComponentModel.Container()
        Me.yeartrn = New DevExpress.XtraEditors.ButtonEdit()
        Me.seriesno = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.id = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.mode = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl15 = New DevExpress.XtraEditors.LabelControl()
        Me.voucherno = New DevExpress.XtraEditors.TextEdit()
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txtVoucherAmount = New DevExpress.XtraEditors.TextEdit()
        Me.txtSupplier = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.gridSupplier = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.HyperlinkLabelControl1 = New DevExpress.XtraEditors.HyperlinkLabelControl()
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
        Me.cmdPrint = New DevExpress.XtraEditors.SimpleButton()
        Me.txtVoucherDate = New DevExpress.XtraEditors.DateEdit()
        Me.gridFund = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.txtFund = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.trnreference = New DevExpress.XtraEditors.ButtonEdit()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.txtOffice = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.gridOffice = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.checkno = New DevExpress.XtraEditors.ButtonEdit()
        Me.officeid = New DevExpress.XtraEditors.ButtonEdit()
        CType(Me.yeartrn.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.seriesno.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.id.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.voucherno.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtVoucherAmount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSupplier.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridSupplier, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fundcode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.periodcode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.yearcode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Em_requisition, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextRequisition.SuspendLayout()
        CType(Me.gridRequisition, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtVoucherDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtVoucherDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridFund, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFund.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trnreference.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOffice.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridOffice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.checkno.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.officeid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'yeartrn
        '
        Me.yeartrn.EditValue = ""
        Me.yeartrn.Location = New System.Drawing.Point(708, 74)
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
        Me.seriesno.Location = New System.Drawing.Point(708, 99)
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
        Me.LabelControl8.Location = New System.Drawing.Point(34, 105)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(79, 17)
        Me.LabelControl8.TabIndex = 927
        Me.LabelControl8.Text = "Voucher Date"
        '
        'id
        '
        Me.id.EditValue = ""
        Me.id.EnterMoveNextControl = True
        Me.id.Location = New System.Drawing.Point(763, 74)
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
        Me.LabelControl3.Location = New System.Drawing.Point(37, 8)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(305, 28)
        Me.LabelControl3.TabIndex = 912
        Me.LabelControl3.Text = "Disbursement Voucher Information"
        '
        'mode
        '
        Me.mode.EditValue = ""
        Me.mode.EnterMoveNextControl = True
        Me.mode.Location = New System.Drawing.Point(763, 99)
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
        Me.LabelControl15.Location = New System.Drawing.Point(71, 132)
        Me.LabelControl15.Name = "LabelControl15"
        Me.LabelControl15.Size = New System.Drawing.Size(42, 17)
        Me.LabelControl15.TabIndex = 909
        Me.LabelControl15.Text = "DV No."
        '
        'voucherno
        '
        Me.voucherno.EditValue = ""
        Me.voucherno.EnterMoveNextControl = True
        Me.voucherno.Location = New System.Drawing.Point(122, 127)
        Me.voucherno.Name = "voucherno"
        Me.voucherno.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.voucherno.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.voucherno.Properties.Appearance.Options.UseFont = True
        Me.voucherno.Properties.Appearance.Options.UseForeColor = True
        Me.voucherno.Properties.Appearance.Options.UseTextOptions = True
        Me.voucherno.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.voucherno.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.voucherno.Properties.ReadOnly = True
        Me.voucherno.Size = New System.Drawing.Size(149, 24)
        Me.voucherno.TabIndex = 908
        '
        'cmdSave
        '
        Me.cmdSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdSave.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmdSave.Appearance.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmdSave.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.cmdSave.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.cmdSave.Appearance.Options.UseBackColor = True
        Me.cmdSave.Appearance.Options.UseFont = True
        Me.cmdSave.Location = New System.Drawing.Point(963, 491)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(133, 34)
        Me.cmdSave.TabIndex = 907
        Me.cmdSave.Text = "Save Voucher"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Appearance.Options.UseTextOptions = True
        Me.LabelControl4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl4.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.LabelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal
        Me.LabelControl4.Location = New System.Drawing.Point(16, 188)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(97, 17)
        Me.LabelControl4.TabIndex = 939
        Me.LabelControl4.Text = "Voucher Amount"
        '
        'txtVoucherAmount
        '
        Me.txtVoucherAmount.EditValue = "0"
        Me.txtVoucherAmount.EnterMoveNextControl = True
        Me.txtVoucherAmount.Location = New System.Drawing.Point(122, 182)
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
        Me.txtSupplier.Location = New System.Drawing.Point(122, 153)
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
        Me.txtSupplier.TabIndex = 3
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
        Me.HyperlinkLabelControl1.Location = New System.Drawing.Point(79, 157)
        Me.HyperlinkLabelControl1.Name = "HyperlinkLabelControl1"
        Me.HyperlinkLabelControl1.Size = New System.Drawing.Size(34, 17)
        Me.HyperlinkLabelControl1.TabIndex = 965
        Me.HyperlinkLabelControl1.Text = "Payee"
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.LabelControl6.Appearance.Options.UseFont = True
        Me.LabelControl6.Location = New System.Drawing.Point(43, 46)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(70, 17)
        Me.LabelControl6.TabIndex = 972
        Me.LabelControl6.Text = "Fund Period"
        '
        'fundcode
        '
        Me.fundcode.EditValue = ""
        Me.fundcode.EnterMoveNextControl = True
        Me.fundcode.Location = New System.Drawing.Point(708, 125)
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
        Me.periodcode.Location = New System.Drawing.Point(763, 125)
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
        Me.yearcode.Location = New System.Drawing.Point(708, 152)
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
        Me.Em_requisition.Location = New System.Drawing.Point(370, 42)
        Me.Em_requisition.MainView = Me.gridRequisition
        Me.Em_requisition.Name = "Em_requisition"
        Me.Em_requisition.Size = New System.Drawing.Size(726, 443)
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
        Me.gridRequisition.OptionsSelection.MultiSelect = True
        Me.gridRequisition.OptionsView.ColumnAutoWidth = False
        Me.gridRequisition.OptionsView.RowAutoHeight = True
        Me.gridRequisition.OptionsView.ShowFooter = True
        Me.gridRequisition.OptionsView.ShowGroupPanel = False
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LabelControl10.Appearance.Options.UseFont = True
        Me.LabelControl10.Appearance.Options.UseTextOptions = True
        Me.LabelControl10.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.LabelControl10.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal
        Me.LabelControl10.Location = New System.Drawing.Point(370, 8)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(385, 30)
        Me.LabelControl10.TabIndex = 977
        Me.LabelControl10.Text = "Tagging of approved requisition list proceeding to disbursement voucher" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Right C" &
    "lick to Add, Edit or Remove, Double click to view)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'cmdPrint
        '
        Me.cmdPrint.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdPrint.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.cmdPrint.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.cmdPrint.Appearance.Options.UseFont = True
        Me.cmdPrint.Location = New System.Drawing.Point(826, 491)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(133, 34)
        Me.cmdPrint.TabIndex = 979
        Me.cmdPrint.Text = "Print Voucher"
        '
        'txtVoucherDate
        '
        Me.txtVoucherDate.EditValue = New Date(2019, 6, 10, 16, 23, 25, 399)
        Me.txtVoucherDate.EnterMoveNextControl = True
        Me.txtVoucherDate.Location = New System.Drawing.Point(122, 100)
        Me.txtVoucherDate.Name = "txtVoucherDate"
        Me.txtVoucherDate.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.txtVoucherDate.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtVoucherDate.Properties.Appearance.Options.UseFont = True
        Me.txtVoucherDate.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtVoucherDate.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtVoucherDate.Properties.AutoHeight = False
        Me.txtVoucherDate.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtVoucherDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtVoucherDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtVoucherDate.Properties.Mask.EditMask = "MMMM dd, yyyy"
        Me.txtVoucherDate.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtVoucherDate.Size = New System.Drawing.Size(149, 25)
        Me.txtVoucherDate.TabIndex = 2
        '
        'gridFund
        '
        Me.gridFund.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gridFund.Name = "gridFund"
        Me.gridFund.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridFund.OptionsView.ShowGroupPanel = False
        '
        'txtFund
        '
        Me.txtFund.EditValue = "sss"
        Me.txtFund.Location = New System.Drawing.Point(122, 42)
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
        Me.txtFund.TabIndex = 1
        '
        'trnreference
        '
        Me.trnreference.EditValue = ""
        Me.trnreference.Location = New System.Drawing.Point(391, 175)
        Me.trnreference.Name = "trnreference"
        Me.trnreference.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.trnreference.Properties.Appearance.Options.UseFont = True
        Me.trnreference.Properties.Appearance.Options.UseTextOptions = True
        Me.trnreference.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.trnreference.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.trnreference.Properties.Mask.BeepOnError = True
        Me.trnreference.Properties.ReadOnly = True
        Me.trnreference.Size = New System.Drawing.Size(49, 22)
        Me.trnreference.TabIndex = 997
        Me.trnreference.Visible = False
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.SimpleButton1.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.SimpleButton1.Appearance.Options.UseFont = True
        Me.SimpleButton1.Location = New System.Drawing.Point(569, 491)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(253, 34)
        Me.SimpleButton1.TabIndex = 998
        Me.SimpleButton1.Text = "Add Approved Requisition"
        '
        'txtOffice
        '
        Me.txtOffice.EditValue = "sss"
        Me.txtOffice.Location = New System.Drawing.Point(122, 71)
        Me.txtOffice.Name = "txtOffice"
        Me.txtOffice.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtOffice.Properties.Appearance.Options.UseFont = True
        Me.txtOffice.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtOffice.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtOffice.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtOffice.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtOffice.Properties.DisplayMember = "Select"
        Me.txtOffice.Properties.NullText = ""
        Me.txtOffice.Properties.PopupView = Me.gridOffice
        Me.txtOffice.Properties.ValueMember = "officeid"
        Me.txtOffice.Size = New System.Drawing.Size(232, 26)
        Me.txtOffice.TabIndex = 999
        '
        'gridOffice
        '
        Me.gridOffice.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gridOffice.Name = "gridOffice"
        Me.gridOffice.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridOffice.OptionsView.ShowGroupPanel = False
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.LabelControl7.Appearance.Options.UseFont = True
        Me.LabelControl7.Location = New System.Drawing.Point(41, 75)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(72, 17)
        Me.LabelControl7.TabIndex = 1000
        Me.LabelControl7.Text = "Select Office"
        '
        'checkno
        '
        Me.checkno.EditValue = ""
        Me.checkno.Location = New System.Drawing.Point(391, 203)
        Me.checkno.Name = "checkno"
        Me.checkno.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.checkno.Properties.Appearance.Options.UseFont = True
        Me.checkno.Properties.Appearance.Options.UseTextOptions = True
        Me.checkno.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.checkno.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.checkno.Properties.Mask.BeepOnError = True
        Me.checkno.Properties.ReadOnly = True
        Me.checkno.Size = New System.Drawing.Size(49, 22)
        Me.checkno.TabIndex = 1001
        Me.checkno.Visible = False
        '
        'officeid
        '
        Me.officeid.EditValue = ""
        Me.officeid.Location = New System.Drawing.Point(391, 231)
        Me.officeid.Name = "officeid"
        Me.officeid.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.officeid.Properties.Appearance.Options.UseFont = True
        Me.officeid.Properties.Appearance.Options.UseTextOptions = True
        Me.officeid.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.officeid.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.officeid.Properties.Mask.BeepOnError = True
        Me.officeid.Properties.ReadOnly = True
        Me.officeid.Size = New System.Drawing.Size(49, 22)
        Me.officeid.TabIndex = 1002
        Me.officeid.Visible = False
        '
        'frmVoucherInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1108, 538)
        Me.Controls.Add(Me.officeid)
        Me.Controls.Add(Me.checkno)
        Me.Controls.Add(Me.txtOffice)
        Me.Controls.Add(Me.LabelControl7)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.trnreference)
        Me.Controls.Add(Me.txtVoucherDate)
        Me.Controls.Add(Me.cmdPrint)
        Me.Controls.Add(Me.LabelControl10)
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
        Me.Controls.Add(Me.id)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.mode)
        Me.Controls.Add(Me.LabelControl15)
        Me.Controls.Add(Me.voucherno)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.Em_requisition)
        Me.HelpButton = True
        Me.MinimumSize = New System.Drawing.Size(846, 411)
        Me.Name = "frmVoucherInfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Disbursement Voucher Information"
        CType(Me.yeartrn.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.seriesno.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.id.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.voucherno.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtVoucherAmount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSupplier.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridSupplier, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fundcode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.periodcode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.yearcode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Em_requisition, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextRequisition.ResumeLayout(False)
        CType(Me.gridRequisition, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtVoucherDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtVoucherDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridFund, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFund.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trnreference.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOffice.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridOffice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.checkno.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.officeid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents yeartrn As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents seriesno As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents id As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents mode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl15 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents voucherno As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtVoucherAmount As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtSupplier As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents gridSupplier As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents HyperlinkLabelControl1 As DevExpress.XtraEditors.HyperlinkLabelControl
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
    Friend WithEvents cmdPrint As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtVoucherDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents gridFund As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtFund As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents trnreference As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtOffice As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents gridOffice As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents checkno As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents officeid As DevExpress.XtraEditors.ButtonEdit
End Class
