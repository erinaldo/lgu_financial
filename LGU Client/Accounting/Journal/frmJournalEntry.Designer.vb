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
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.txtJournalDate = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.mode = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl15 = New DevExpress.XtraEditors.LabelControl()
        Me.jevno = New DevExpress.XtraEditors.TextEdit()
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton()
        Me.ContexEntries = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmdAdd = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExpenditureItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManualJournalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdRemove = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdRefresh = New System.Windows.Forms.ToolStripMenuItem()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.fundcode = New DevExpress.XtraEditors.TextEdit()
        Me.periodcode = New DevExpress.XtraEditors.TextEdit()
        Me.Gridview1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Em = New DevExpress.XtraGrid.GridControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.txtRemarks = New DevExpress.XtraEditors.MemoEdit()
        Me.cmdPrint = New DevExpress.XtraEditors.SimpleButton()
        Me.txtJevNo = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtDVNo = New DevExpress.XtraEditors.TextEdit()
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
        CType(Me.yeartrn.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtJournalDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtJournalDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.jevno.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContexEntries.SuspendLayout()
        CType(Me.fundcode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.periodcode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Gridview1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRemarks.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtJevNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDVNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPayrollNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRCDNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLRNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAENo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.officeid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOffice.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFund.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.LabelControl8.Appearance.Options.UseFont = True
        Me.LabelControl8.Appearance.Options.UseTextOptions = True
        Me.LabelControl8.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl8.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.LabelControl8.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal
        Me.LabelControl8.Location = New System.Drawing.Point(32, 141)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(51, 17)
        Me.LabelControl8.TabIndex = 927
        Me.LabelControl8.Text = "JEV Date"
        '
        'txtJournalDate
        '
        Me.txtJournalDate.EditValue = Nothing
        Me.txtJournalDate.EnterMoveNextControl = True
        Me.txtJournalDate.Location = New System.Drawing.Point(92, 138)
        Me.txtJournalDate.Name = "txtJournalDate"
        Me.txtJournalDate.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtJournalDate.Properties.Appearance.Options.UseFont = True
        Me.txtJournalDate.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtJournalDate.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtJournalDate.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtJournalDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtJournalDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtJournalDate.Properties.Mask.EditMask = "MMMM dd, yyyy"
        Me.txtJournalDate.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtJournalDate.Size = New System.Drawing.Size(232, 26)
        Me.txtJournalDate.TabIndex = 0
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
        Me.LabelControl3.Size = New System.Drawing.Size(298, 28)
        Me.LabelControl3.TabIndex = 912
        Me.LabelControl3.Text = "Journal Entry Voucher Information"
        '
        'mode
        '
        Me.mode.EditValue = ""
        Me.mode.EnterMoveNextControl = True
        Me.mode.Location = New System.Drawing.Point(819, 86)
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
        Me.LabelControl15.Location = New System.Drawing.Point(38, 87)
        Me.LabelControl15.Name = "LabelControl15"
        Me.LabelControl15.Size = New System.Drawing.Size(45, 17)
        Me.LabelControl15.TabIndex = 909
        Me.LabelControl15.Text = "JEV No."
        '
        'jevno
        '
        Me.jevno.EditValue = ""
        Me.jevno.EnterMoveNextControl = True
        Me.jevno.Location = New System.Drawing.Point(819, 140)
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
        Me.cmdSave.Location = New System.Drawing.Point(926, 503)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(196, 35)
        Me.cmdSave.TabIndex = 907
        Me.cmdSave.Text = "Save Journal"
        '
        'ContexEntries
        '
        Me.ContexEntries.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdAdd, Me.ToolStripMenuItem1, Me.cmdEdit, Me.cmdRemove, Me.ToolStripSeparator1, Me.cmdRefresh})
        Me.ContexEntries.Name = "gridmenustrip"
        Me.ContexEntries.Size = New System.Drawing.Size(192, 120)
        '
        'cmdAdd
        '
        Me.cmdAdd.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExpenditureItemToolStripMenuItem, Me.ManualJournalToolStripMenuItem})
        Me.cmdAdd.Image = Global.LGUClient.My.Resources.Resources.notebook__plus
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(191, 22)
        Me.cmdAdd.Text = "Addnew Debit Entry"
        '
        'ExpenditureItemToolStripMenuItem
        '
        Me.ExpenditureItemToolStripMenuItem.Name = "ExpenditureItemToolStripMenuItem"
        Me.ExpenditureItemToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.ExpenditureItemToolStripMenuItem.Text = "Expenditure Item"
        '
        'ManualJournalToolStripMenuItem
        '
        Me.ManualJournalToolStripMenuItem.Name = "ManualJournalToolStripMenuItem"
        Me.ManualJournalToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.ManualJournalToolStripMenuItem.Text = "Manual Journal"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Image = Global.LGUClient.My.Resources.Resources.notebook__plus
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(191, 22)
        Me.ToolStripMenuItem1.Text = "Addnew Credit Entry"
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
        Me.LabelControl6.Location = New System.Drawing.Point(13, 114)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(70, 17)
        Me.LabelControl6.TabIndex = 972
        Me.LabelControl6.Text = "Fund Period"
        '
        'fundcode
        '
        Me.fundcode.EditValue = ""
        Me.fundcode.EnterMoveNextControl = True
        Me.fundcode.Location = New System.Drawing.Point(874, 112)
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
        Me.periodcode.Location = New System.Drawing.Point(819, 112)
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
        Me.Em.Location = New System.Drawing.Point(341, 55)
        Me.Em.MainView = Me.Gridview1
        Me.Em.Name = "Em"
        Me.Em.Size = New System.Drawing.Size(781, 442)
        Me.Em.TabIndex = 3
        Me.Em.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.Gridview1})
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseTextOptions = True
        Me.LabelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.LabelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal
        Me.LabelControl1.Location = New System.Drawing.Point(341, 32)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(330, 17)
        Me.LabelControl1.TabIndex = 919
        Me.LabelControl1.Text = "Account Title Entries (Right Click to Add, Edit or Remove)"
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.LabelControl7.Appearance.Options.UseFont = True
        Me.LabelControl7.Location = New System.Drawing.Point(13, 168)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(70, 17)
        Me.LabelControl7.TabIndex = 977
        Me.LabelControl7.Text = "Explaination"
        '
        'txtRemarks
        '
        Me.txtRemarks.EditValue = ""
        Me.txtRemarks.Location = New System.Drawing.Point(92, 166)
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtRemarks.Properties.Appearance.Options.UseFont = True
        Me.txtRemarks.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtRemarks.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtRemarks.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
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
        Me.cmdPrint.Location = New System.Drawing.Point(724, 503)
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
        Me.txtJevNo.Location = New System.Drawing.Point(92, 82)
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
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(54, 356)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(29, 17)
        Me.LabelControl2.TabIndex = 981
        Me.LabelControl2.Text = "DV #"
        '
        'txtDVNo
        '
        Me.txtDVNo.EditValue = ""
        Me.txtDVNo.Location = New System.Drawing.Point(92, 352)
        Me.txtDVNo.Name = "txtDVNo"
        Me.txtDVNo.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtDVNo.Properties.Appearance.Options.UseFont = True
        Me.txtDVNo.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtDVNo.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtDVNo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtDVNo.Size = New System.Drawing.Size(232, 26)
        Me.txtDVNo.TabIndex = 4
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Location = New System.Drawing.Point(32, 385)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(51, 17)
        Me.LabelControl4.TabIndex = 983
        Me.LabelControl4.Text = "Payroll #"
        '
        'txtPayrollNo
        '
        Me.txtPayrollNo.EditValue = ""
        Me.txtPayrollNo.Location = New System.Drawing.Point(92, 381)
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
        Me.LabelControl5.Location = New System.Drawing.Point(46, 414)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(37, 17)
        Me.LabelControl5.TabIndex = 985
        Me.LabelControl5.Text = "RCD #"
        '
        'txtRCDNo
        '
        Me.txtRCDNo.EditValue = ""
        Me.txtRCDNo.Location = New System.Drawing.Point(92, 410)
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
        Me.LabelControl9.Location = New System.Drawing.Point(57, 443)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(26, 17)
        Me.LabelControl9.TabIndex = 987
        Me.LabelControl9.Text = "LR #"
        '
        'txtLRNo
        '
        Me.txtLRNo.EditValue = ""
        Me.txtLRNo.Location = New System.Drawing.Point(92, 439)
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
        Me.LabelControl10.Location = New System.Drawing.Point(56, 472)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(27, 17)
        Me.LabelControl10.TabIndex = 989
        Me.LabelControl10.Text = "AE #"
        '
        'txtAENo
        '
        Me.txtAENo.EditValue = ""
        Me.txtAENo.Location = New System.Drawing.Point(92, 468)
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
        Me.officeid.Location = New System.Drawing.Point(764, 86)
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
        Me.txtOffice.Location = New System.Drawing.Point(92, 53)
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
        Me.LabelControl11.Location = New System.Drawing.Point(49, 57)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(34, 17)
        Me.LabelControl11.TabIndex = 991
        Me.LabelControl11.Text = "Office"
        '
        'txtFund
        '
        Me.txtFund.EditValue = ""
        Me.txtFund.Location = New System.Drawing.Point(92, 110)
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
        'frmJournalEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1134, 546)
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
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.txtJevNo)
        Me.Controls.Add(Me.cmdPrint)
        Me.Controls.Add(Me.LabelControl7)
        Me.Controls.Add(Me.txtRemarks)
        Me.Controls.Add(Me.periodcode)
        Me.Controls.Add(Me.fundcode)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.yeartrn)
        Me.Controls.Add(Me.LabelControl8)
        Me.Controls.Add(Me.txtJournalDate)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.mode)
        Me.Controls.Add(Me.LabelControl15)
        Me.Controls.Add(Me.jevno)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.Em)
        Me.Controls.Add(Me.txtDVNo)
        Me.Controls.Add(Me.txtFund)
        Me.HelpButton = True
        Me.MinimumSize = New System.Drawing.Size(1150, 560)
        Me.Name = "frmJournalEntry"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Journal Entry Voucher Information"
        CType(Me.yeartrn.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtJournalDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtJournalDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.jevno.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContexEntries.ResumeLayout(False)
        CType(Me.fundcode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.periodcode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Gridview1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRemarks.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtJevNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDVNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPayrollNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRCDNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLRNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAENo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.officeid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOffice.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFund.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents yeartrn As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtJournalDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents mode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl15 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents jevno As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ContexEntries As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmdAdd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdRemove As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdRefresh As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents fundcode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents periodcode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Gridview1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Em As DevExpress.XtraGrid.GridControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtRemarks As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents cmdPrint As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtJevNo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDVNo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPayrollNo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtRCDNo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtLRNo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtAENo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ExpenditureItemToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManualJournalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents officeid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtOffice As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtFund As DevExpress.XtraEditors.TextEdit
End Class
