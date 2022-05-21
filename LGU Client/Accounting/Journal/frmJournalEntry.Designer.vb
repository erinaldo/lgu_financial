<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmJournalEntry
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
        Me.mode = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl15 = New DevExpress.XtraEditors.LabelControl()
        Me.jevno = New DevExpress.XtraEditors.TextEdit()
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton()
        Me.ContexEntries = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmdEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdRemove = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdRefresh = New System.Windows.Forms.ToolStripMenuItem()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.fundcode = New DevExpress.XtraEditors.TextEdit()
        Me.periodcode = New DevExpress.XtraEditors.TextEdit()
        Me.Gridview1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Em = New DevExpress.XtraGrid.GridControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.txtRemarks = New DevExpress.XtraEditors.MemoEdit()
        Me.cmdPrint = New DevExpress.XtraEditors.SimpleButton()
        Me.txtJevNo = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txtPayrollNo = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.txtRCDNo = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.txtLRNo = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.txtAENo = New DevExpress.XtraEditors.TextEdit()
        Me.officeid = New DevExpress.XtraEditors.TextEdit()
        Me.txtOffice = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.txtFund = New DevExpress.XtraEditors.TextEdit()
        Me.pid = New DevExpress.XtraEditors.TextEdit()
        Me.dvid = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtCheckBankName = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.gridBank = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.txtAmount = New DevExpress.XtraEditors.TextEdit()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ByExpenditureItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ByManualJournalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdNewEmployee = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        CType(Me.yeartrn.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.jevno.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContexEntries.SuspendLayout()
        CType(Me.fundcode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.periodcode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Gridview1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRemarks.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtJevNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPayrollNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRCDNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLRNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAENo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.officeid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOffice.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFund.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dvid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCheckBankName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridBank, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAmount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'yeartrn
        '
        Me.yeartrn.EditValue = ""
        Me.yeartrn.Location = New System.Drawing.Point(877, 131)
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
        'mode
        '
        Me.mode.EditValue = ""
        Me.mode.EnterMoveNextControl = True
        Me.mode.Location = New System.Drawing.Point(822, 131)
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
        Me.LabelControl15.Location = New System.Drawing.Point(34, 43)
        Me.LabelControl15.Name = "LabelControl15"
        Me.LabelControl15.Size = New System.Drawing.Size(45, 17)
        Me.LabelControl15.TabIndex = 909
        Me.LabelControl15.Text = "JEV No."
        '
        'jevno
        '
        Me.jevno.EditValue = ""
        Me.jevno.EnterMoveNextControl = True
        Me.jevno.Location = New System.Drawing.Point(822, 185)
        Me.jevno.Name = "jevno"
        Me.jevno.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.jevno.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.jevno.Properties.Appearance.Options.UseFont = True
        Me.jevno.Properties.Appearance.Options.UseForeColor = True
        Me.jevno.Properties.Appearance.Options.UseTextOptions = True
        Me.jevno.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.jevno.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.jevno.Properties.NullValuePrompt = "AUTO GENERATE"
        Me.jevno.Properties.ReadOnly = True
        Me.jevno.Size = New System.Drawing.Size(49, 24)
        Me.jevno.TabIndex = 908
        Me.jevno.Visible = False
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
        Me.cmdSave.Location = New System.Drawing.Point(898, 436)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(196, 35)
        Me.cmdSave.TabIndex = 907
        Me.cmdSave.Text = "Save Journal"
        '
        'ContexEntries
        '
        Me.ContexEntries.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdEdit, Me.cmdRemove, Me.ToolStripSeparator1, Me.cmdRefresh})
        Me.ContexEntries.Name = "gridmenustrip"
        Me.ContexEntries.Size = New System.Drawing.Size(192, 76)
        '
        'cmdEdit
        '
        Me.cmdEdit.Image = Global.LGUClient.My.Resources.Resources.notebook__pencil
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(191, 22)
        Me.cmdEdit.Text = "Edit Selected Item"
        '
        'cmdRemove
        '
        Me.cmdRemove.Image = Global.LGUClient.My.Resources.Resources.notebook__minus
        Me.cmdRemove.Name = "cmdRemove"
        Me.cmdRemove.Size = New System.Drawing.Size(191, 22)
        Me.cmdRemove.Text = "Remove Selected Item"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(188, 6)
        '
        'cmdRefresh
        '
        Me.cmdRefresh.Image = Global.LGUClient.My.Resources.Resources.arrow_continue_090
        Me.cmdRefresh.Name = "cmdRefresh"
        Me.cmdRefresh.Size = New System.Drawing.Size(191, 22)
        Me.cmdRefresh.Text = "Refresh Item List"
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.LabelControl6.Appearance.Options.UseFont = True
        Me.LabelControl6.Location = New System.Drawing.Point(9, 70)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(70, 17)
        Me.LabelControl6.TabIndex = 972
        Me.LabelControl6.Text = "Fund Period"
        '
        'fundcode
        '
        Me.fundcode.EditValue = ""
        Me.fundcode.EnterMoveNextControl = True
        Me.fundcode.Location = New System.Drawing.Point(877, 157)
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
        Me.periodcode.Location = New System.Drawing.Point(822, 157)
        Me.periodcode.Name = "periodcode"
        Me.periodcode.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.periodcode.Properties.Appearance.Options.UseFont = True
        Me.periodcode.Properties.MaxLength = 50
        Me.periodcode.Properties.ReadOnly = True
        Me.periodcode.Size = New System.Drawing.Size(49, 22)
        Me.periodcode.TabIndex = 974
        Me.periodcode.Visible = False
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
        Me.Gridview1.OptionsSelection.MultiSelect = True
        Me.Gridview1.OptionsView.ColumnAutoWidth = False
        Me.Gridview1.OptionsView.RowAutoHeight = True
        Me.Gridview1.OptionsView.ShowFooter = True
        Me.Gridview1.OptionsView.ShowGroupPanel = False
        '
        'Em
        '
        Me.Em.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Em.ContextMenuStrip = Me.ContexEntries
        Me.Em.Location = New System.Drawing.Point(323, 42)
        Me.Em.MainView = Me.Gridview1
        Me.Em.Name = "Em"
        Me.Em.Size = New System.Drawing.Size(772, 348)
        Me.Em.TabIndex = 3
        Me.Em.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.Gridview1})
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.LabelControl7.Appearance.Options.UseFont = True
        Me.LabelControl7.Location = New System.Drawing.Point(9, 96)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(70, 17)
        Me.LabelControl7.TabIndex = 977
        Me.LabelControl7.Text = "Explaination"
        '
        'txtRemarks
        '
        Me.txtRemarks.EditValue = ""
        Me.txtRemarks.Location = New System.Drawing.Point(86, 94)
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtRemarks.Properties.Appearance.Options.UseFont = True
        Me.txtRemarks.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtRemarks.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtRemarks.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtRemarks.Properties.ReadOnly = True
        Me.txtRemarks.Size = New System.Drawing.Size(232, 183)
        Me.txtRemarks.TabIndex = 1
        '
        'cmdPrint
        '
        Me.cmdPrint.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdPrint.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmdPrint.Appearance.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmdPrint.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.cmdPrint.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.cmdPrint.Appearance.Options.UseBackColor = True
        Me.cmdPrint.Appearance.Options.UseFont = True
        Me.cmdPrint.Location = New System.Drawing.Point(696, 436)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(196, 35)
        Me.cmdPrint.TabIndex = 978
        Me.cmdPrint.Text = "Print Journal"
        Me.cmdPrint.Visible = False
        '
        'txtJevNo
        '
        Me.txtJevNo.EditValue = ""
        Me.txtJevNo.EnterMoveNextControl = True
        Me.txtJevNo.Location = New System.Drawing.Point(86, 38)
        Me.txtJevNo.Name = "txtJevNo"
        Me.txtJevNo.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtJevNo.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txtJevNo.Properties.Appearance.Options.UseFont = True
        Me.txtJevNo.Properties.Appearance.Options.UseForeColor = True
        Me.txtJevNo.Properties.Appearance.Options.UseTextOptions = True
        Me.txtJevNo.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtJevNo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtJevNo.Properties.NullValuePrompt = "AUTO GENERATE"
        Me.txtJevNo.Properties.ReadOnly = True
        Me.txtJevNo.Size = New System.Drawing.Size(232, 26)
        Me.txtJevNo.TabIndex = 979
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Location = New System.Drawing.Point(28, 283)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(51, 17)
        Me.LabelControl4.TabIndex = 983
        Me.LabelControl4.Text = "Payroll #"
        '
        'txtPayrollNo
        '
        Me.txtPayrollNo.EditValue = ""
        Me.txtPayrollNo.Location = New System.Drawing.Point(86, 279)
        Me.txtPayrollNo.Name = "txtPayrollNo"
        Me.txtPayrollNo.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtPayrollNo.Properties.Appearance.Options.UseFont = True
        Me.txtPayrollNo.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtPayrollNo.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtPayrollNo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtPayrollNo.Size = New System.Drawing.Size(232, 26)
        Me.txtPayrollNo.TabIndex = 4
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.Location = New System.Drawing.Point(42, 311)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(37, 17)
        Me.LabelControl5.TabIndex = 985
        Me.LabelControl5.Text = "RCD #"
        '
        'txtRCDNo
        '
        Me.txtRCDNo.EditValue = ""
        Me.txtRCDNo.Location = New System.Drawing.Point(86, 307)
        Me.txtRCDNo.Name = "txtRCDNo"
        Me.txtRCDNo.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtRCDNo.Properties.Appearance.Options.UseFont = True
        Me.txtRCDNo.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtRCDNo.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtRCDNo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtRCDNo.Size = New System.Drawing.Size(232, 26)
        Me.txtRCDNo.TabIndex = 5
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.LabelControl9.Appearance.Options.UseFont = True
        Me.LabelControl9.Location = New System.Drawing.Point(53, 339)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(26, 17)
        Me.LabelControl9.TabIndex = 987
        Me.LabelControl9.Text = "LR #"
        '
        'txtLRNo
        '
        Me.txtLRNo.EditValue = ""
        Me.txtLRNo.Location = New System.Drawing.Point(86, 335)
        Me.txtLRNo.Name = "txtLRNo"
        Me.txtLRNo.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtLRNo.Properties.Appearance.Options.UseFont = True
        Me.txtLRNo.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtLRNo.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtLRNo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtLRNo.Size = New System.Drawing.Size(232, 26)
        Me.txtLRNo.TabIndex = 6
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.LabelControl10.Appearance.Options.UseFont = True
        Me.LabelControl10.Location = New System.Drawing.Point(52, 367)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(27, 17)
        Me.LabelControl10.TabIndex = 989
        Me.LabelControl10.Text = "AE #"
        '
        'txtAENo
        '
        Me.txtAENo.EditValue = ""
        Me.txtAENo.Location = New System.Drawing.Point(86, 363)
        Me.txtAENo.Name = "txtAENo"
        Me.txtAENo.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtAENo.Properties.Appearance.Options.UseFont = True
        Me.txtAENo.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtAENo.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtAENo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtAENo.Size = New System.Drawing.Size(232, 26)
        Me.txtAENo.TabIndex = 7
        '
        'officeid
        '
        Me.officeid.EditValue = ""
        Me.officeid.EnterMoveNextControl = True
        Me.officeid.Location = New System.Drawing.Point(767, 131)
        Me.officeid.Name = "officeid"
        Me.officeid.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.officeid.Properties.Appearance.Options.UseFont = True
        Me.officeid.Properties.MaxLength = 50
        Me.officeid.Properties.ReadOnly = True
        Me.officeid.Size = New System.Drawing.Size(49, 22)
        Me.officeid.TabIndex = 990
        Me.officeid.Visible = False
        '
        'txtOffice
        '
        Me.txtOffice.EditValue = ""
        Me.txtOffice.EnterMoveNextControl = True
        Me.txtOffice.Location = New System.Drawing.Point(86, 9)
        Me.txtOffice.Name = "txtOffice"
        Me.txtOffice.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtOffice.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txtOffice.Properties.Appearance.Options.UseFont = True
        Me.txtOffice.Properties.Appearance.Options.UseForeColor = True
        Me.txtOffice.Properties.Appearance.Options.UseTextOptions = True
        Me.txtOffice.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtOffice.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtOffice.Properties.ReadOnly = True
        Me.txtOffice.Size = New System.Drawing.Size(232, 26)
        Me.txtOffice.TabIndex = 992
        '
        'LabelControl11
        '
        Me.LabelControl11.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.LabelControl11.Appearance.Options.UseFont = True
        Me.LabelControl11.Appearance.Options.UseTextOptions = True
        Me.LabelControl11.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl11.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.LabelControl11.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal
        Me.LabelControl11.Location = New System.Drawing.Point(45, 13)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(34, 17)
        Me.LabelControl11.TabIndex = 991
        Me.LabelControl11.Text = "Office"
        '
        'txtFund
        '
        Me.txtFund.EditValue = ""
        Me.txtFund.Location = New System.Drawing.Point(86, 66)
        Me.txtFund.Name = "txtFund"
        Me.txtFund.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtFund.Properties.Appearance.Options.UseFont = True
        Me.txtFund.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtFund.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtFund.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtFund.Properties.ReadOnly = True
        Me.txtFund.Size = New System.Drawing.Size(232, 26)
        Me.txtFund.TabIndex = 1000
        '
        'pid
        '
        Me.pid.EditValue = ""
        Me.pid.EnterMoveNextControl = True
        Me.pid.Location = New System.Drawing.Point(767, 158)
        Me.pid.Name = "pid"
        Me.pid.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.pid.Properties.Appearance.Options.UseFont = True
        Me.pid.Properties.MaxLength = 50
        Me.pid.Properties.ReadOnly = True
        Me.pid.Size = New System.Drawing.Size(49, 22)
        Me.pid.TabIndex = 1001
        Me.pid.Visible = False
        '
        'dvid
        '
        Me.dvid.EditValue = ""
        Me.dvid.EnterMoveNextControl = True
        Me.dvid.Location = New System.Drawing.Point(767, 186)
        Me.dvid.Name = "dvid"
        Me.dvid.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.dvid.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.dvid.Properties.Appearance.Options.UseFont = True
        Me.dvid.Properties.Appearance.Options.UseForeColor = True
        Me.dvid.Properties.Appearance.Options.UseTextOptions = True
        Me.dvid.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.dvid.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.dvid.Properties.NullValuePrompt = "AUTO GENERATE"
        Me.dvid.Properties.ReadOnly = True
        Me.dvid.Size = New System.Drawing.Size(49, 24)
        Me.dvid.TabIndex = 1002
        Me.dvid.Visible = False
        '
        'LabelControl2
        '
        Me.LabelControl2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(326, 404)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(66, 17)
        Me.LabelControl2.TabIndex = 1008
        Me.LabelControl2.Text = "Bank Name"
        '
        'txtCheckBankName
        '
        Me.txtCheckBankName.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCheckBankName.EditValue = "sss"
        Me.txtCheckBankName.Location = New System.Drawing.Point(399, 399)
        Me.txtCheckBankName.Name = "txtCheckBankName"
        Me.txtCheckBankName.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtCheckBankName.Properties.Appearance.Options.UseFont = True
        Me.txtCheckBankName.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCheckBankName.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtCheckBankName.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtCheckBankName.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtCheckBankName.Properties.DisplayMember = "Bank Name"
        Me.txtCheckBankName.Properties.NullText = ""
        Me.txtCheckBankName.Properties.PopupView = Me.gridBank
        Me.txtCheckBankName.Properties.ValueMember = "Account No."
        Me.txtCheckBankName.Size = New System.Drawing.Size(441, 26)
        Me.txtCheckBankName.TabIndex = 1009
        '
        'gridBank
        '
        Me.gridBank.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gridBank.Name = "gridBank"
        Me.gridBank.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridBank.OptionsView.ShowGroupPanel = False
        '
        'LabelControl8
        '
        Me.LabelControl8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.LabelControl8.Appearance.Options.UseFont = True
        Me.LabelControl8.Location = New System.Drawing.Point(846, 402)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(83, 17)
        Me.LabelControl8.TabIndex = 1011
        Me.LabelControl8.Text = "Check Amount"
        '
        'txtAmount
        '
        Me.txtAmount.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAmount.EditValue = "0"
        Me.txtAmount.Location = New System.Drawing.Point(935, 398)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtAmount.Properties.Appearance.Options.UseFont = True
        Me.txtAmount.Properties.Appearance.Options.UseTextOptions = True
        Me.txtAmount.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtAmount.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtAmount.Properties.Mask.EditMask = "n"
        Me.txtAmount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtAmount.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtAmount.Properties.NullText = "0"
        Me.txtAmount.Properties.ReadOnly = True
        Me.txtAmount.Size = New System.Drawing.Size(159, 28)
        Me.txtAmount.TabIndex = 1010
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.BackgroundImage = Global.LGUClient.My.Resources.Resources.wide_blank2
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripDropDownButton1, Me.ToolStripSeparator3, Me.cmdNewEmployee, Me.ToolStripSeparator2, Me.ToolStripButton1, Me.ToolStripSeparator6})
        Me.ToolStrip1.Location = New System.Drawing.Point(321, 9)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Padding = New System.Windows.Forms.Padding(10, 2, 1, 2)
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.Size = New System.Drawing.Size(773, 31)
        Me.ToolStrip1.TabIndex = 1012
        Me.ToolStrip1.Text = "ToolStrip3"
        '
        'ToolStripDropDownButton1
        '
        Me.ToolStripDropDownButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ByExpenditureItemToolStripMenuItem, Me.ByManualJournalToolStripMenuItem})
        Me.ToolStripDropDownButton1.ForeColor = System.Drawing.Color.White
        Me.ToolStripDropDownButton1.Image = Global.LGUClient.My.Resources.Resources.notebook__arrow
        Me.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(141, 24)
        Me.ToolStripDropDownButton1.Text = "Addnew Debit Entry"
        '
        'ByExpenditureItemToolStripMenuItem
        '
        Me.ByExpenditureItemToolStripMenuItem.Image = Global.LGUClient.My.Resources.Resources._187
        Me.ByExpenditureItemToolStripMenuItem.Name = "ByExpenditureItemToolStripMenuItem"
        Me.ByExpenditureItemToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ByExpenditureItemToolStripMenuItem.Text = "By Expenditure Item"
        '
        'ByManualJournalToolStripMenuItem
        '
        Me.ByManualJournalToolStripMenuItem.Image = Global.LGUClient.My.Resources.Resources.notebook__pencil
        Me.ByManualJournalToolStripMenuItem.Name = "ByManualJournalToolStripMenuItem"
        Me.ByManualJournalToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ByManualJournalToolStripMenuItem.Text = "By Manual Journal"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 27)
        '
        'cmdNewEmployee
        '
        Me.cmdNewEmployee.ForeColor = System.Drawing.Color.White
        Me.cmdNewEmployee.Image = Global.LGUClient.My.Resources.Resources.notebook__backarrow
        Me.cmdNewEmployee.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdNewEmployee.Name = "cmdNewEmployee"
        Me.cmdNewEmployee.Size = New System.Drawing.Size(136, 24)
        Me.cmdNewEmployee.Text = "Addnew Credit Entry"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.ForeColor = System.Drawing.Color.White
        Me.ToolStripButton1.Image = Global.LGUClient.My.Resources.Resources.arrow_continue_090
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(114, 24)
        Me.ToolStripButton1.Text = "Refresh Item List"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 27)
        '
        'frmJournalEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1103, 483)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.LabelControl8)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.txtCheckBankName)
        Me.Controls.Add(Me.dvid)
        Me.Controls.Add(Me.pid)
        Me.Controls.Add(Me.txtOffice)
        Me.Controls.Add(Me.LabelControl11)
        Me.Controls.Add(Me.officeid)
        Me.Controls.Add(Me.LabelControl10)
        Me.Controls.Add(Me.txtAENo)
        Me.Controls.Add(Me.LabelControl9)
        Me.Controls.Add(Me.txtLRNo)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.txtRCDNo)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.txtPayrollNo)
        Me.Controls.Add(Me.txtJevNo)
        Me.Controls.Add(Me.cmdPrint)
        Me.Controls.Add(Me.LabelControl7)
        Me.Controls.Add(Me.txtRemarks)
        Me.Controls.Add(Me.periodcode)
        Me.Controls.Add(Me.fundcode)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.yeartrn)
        Me.Controls.Add(Me.mode)
        Me.Controls.Add(Me.LabelControl15)
        Me.Controls.Add(Me.jevno)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.Em)
        Me.Controls.Add(Me.txtFund)
        Me.HelpButton = True
        Me.MinimumSize = New System.Drawing.Size(1119, 522)
        Me.Name = "frmJournalEntry"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Journal Entry Voucher Information"
        CType(Me.yeartrn.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.jevno.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContexEntries.ResumeLayout(False)
        CType(Me.fundcode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.periodcode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Gridview1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRemarks.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtJevNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPayrollNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRCDNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLRNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAENo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.officeid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOffice.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFund.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dvid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCheckBankName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridBank, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAmount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents yeartrn As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents mode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl15 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents jevno As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ContexEntries As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmdEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdRemove As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdRefresh As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents fundcode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents periodcode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Gridview1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Em As DevExpress.XtraGrid.GridControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtRemarks As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents cmdPrint As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtJevNo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPayrollNo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtRCDNo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtLRNo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtAENo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents officeid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtOffice As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtFund As DevExpress.XtraEditors.TextEdit
    Friend WithEvents pid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents dvid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCheckBankName As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents gridBank As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtAmount As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripDropDownButton1 As ToolStripDropDownButton
    Friend WithEvents ByExpenditureItemToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents cmdNewEmployee As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents ByManualJournalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
End Class
