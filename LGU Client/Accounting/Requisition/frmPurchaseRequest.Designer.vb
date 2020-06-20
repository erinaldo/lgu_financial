<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPurchaseRequest
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPurchaseRequest))
        Me.officeid = New DevExpress.XtraEditors.TextEdit()
        Me.cmdaction = New DevExpress.XtraEditors.SimpleButton()
        Me.txtPurpose = New DevExpress.XtraEditors.MemoEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.txtPRNumber = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.txtSection = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtPostingDate = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.txtSaiNo = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtAlobsNo = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.txtOffice = New DevExpress.XtraEditors.TextEdit()
        Me.txtSaiDate = New DevExpress.XtraEditors.DateEdit()
        Me.txtAlobsDate = New DevExpress.XtraEditors.DateEdit()
        Me.pid = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.txtAddPrintLine = New DevExpress.XtraEditors.TextEdit()
        CType(Me.officeid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPurpose.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPRNumber.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSection.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPostingDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPostingDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSaiNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAlobsNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOffice.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSaiDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSaiDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAlobsDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAlobsDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAddPrintLine.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'officeid
        '
        Me.officeid.Location = New System.Drawing.Point(492, 83)
        Me.officeid.Name = "officeid"
        Me.officeid.Properties.Appearance.Options.UseFont = True
        Me.officeid.Properties.Appearance.Options.UseTextOptions = True
        Me.officeid.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.officeid.Properties.ReadOnly = True
        Me.officeid.Size = New System.Drawing.Size(47, 20)
        Me.officeid.TabIndex = 573
        Me.officeid.Visible = False
        '
        'cmdaction
        '
        Me.cmdaction.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.cmdaction.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.cmdaction.Appearance.Options.UseFont = True
        Me.cmdaction.Location = New System.Drawing.Point(143, 350)
        Me.cmdaction.Name = "cmdaction"
        Me.cmdaction.Size = New System.Drawing.Size(182, 36)
        Me.cmdaction.TabIndex = 3
        Me.cmdaction.Text = "Save and Print"
        '
        'txtPurpose
        '
        Me.txtPurpose.EditValue = ""
        Me.txtPurpose.Location = New System.Drawing.Point(143, 241)
        Me.txtPurpose.Name = "txtPurpose"
        Me.txtPurpose.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtPurpose.Properties.Appearance.Options.UseFont = True
        Me.txtPurpose.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtPurpose.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtPurpose.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtPurpose.Properties.NullValuePrompt = "Specify transaction remarks. i.e name of person, details, etc"
        Me.txtPurpose.Properties.NullValuePromptShowForEmptyValue = True
        Me.txtPurpose.Size = New System.Drawing.Size(296, 75)
        Me.txtPurpose.TabIndex = 2
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.Location = New System.Drawing.Point(68, 16)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(67, 17)
        Me.LabelControl5.TabIndex = 932
        Me.LabelControl5.Text = "PR Number"
        '
        'txtPRNumber
        '
        Me.txtPRNumber.EditValue = ""
        Me.txtPRNumber.Location = New System.Drawing.Point(143, 12)
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
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.LabelControl7.Appearance.Options.UseFont = True
        Me.LabelControl7.Location = New System.Drawing.Point(93, 74)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(42, 17)
        Me.LabelControl7.TabIndex = 934
        Me.LabelControl7.Text = "Section"
        '
        'txtSection
        '
        Me.txtSection.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtSection.EditValue = ""
        Me.txtSection.Location = New System.Drawing.Point(143, 70)
        Me.txtSection.Name = "txtSection"
        Me.txtSection.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtSection.Properties.Appearance.Options.UseFont = True
        Me.txtSection.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtSection.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtSection.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtSection.Size = New System.Drawing.Size(275, 26)
        Me.txtSection.TabIndex = 933
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(89, 103)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(46, 17)
        Me.LabelControl3.TabIndex = 936
        Me.LabelControl3.Text = "PR Date"
        '
        'txtPostingDate
        '
        Me.txtPostingDate.EditValue = New Date(2019, 6, 10, 16, 23, 25, 399)
        Me.txtPostingDate.EnterMoveNextControl = True
        Me.txtPostingDate.Location = New System.Drawing.Point(143, 99)
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
        Me.txtPostingDate.Size = New System.Drawing.Size(184, 25)
        Me.txtPostingDate.TabIndex = 935
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Location = New System.Drawing.Point(86, 160)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(49, 17)
        Me.LabelControl4.TabIndex = 940
        Me.LabelControl4.Text = "SAI Date"
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.LabelControl8.Appearance.Options.UseFont = True
        Me.LabelControl8.Location = New System.Drawing.Point(92, 129)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(43, 17)
        Me.LabelControl8.TabIndex = 938
        Me.LabelControl8.Text = "SAI No."
        '
        'txtSaiNo
        '
        Me.txtSaiNo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtSaiNo.EditValue = ""
        Me.txtSaiNo.Location = New System.Drawing.Point(143, 127)
        Me.txtSaiNo.Name = "txtSaiNo"
        Me.txtSaiNo.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtSaiNo.Properties.Appearance.Options.UseFont = True
        Me.txtSaiNo.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtSaiNo.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtSaiNo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtSaiNo.Size = New System.Drawing.Size(184, 26)
        Me.txtSaiNo.TabIndex = 937
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(66, 217)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(69, 17)
        Me.LabelControl1.TabIndex = 944
        Me.LabelControl1.Text = "ALOBS Date"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(72, 188)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(63, 17)
        Me.LabelControl2.TabIndex = 942
        Me.LabelControl2.Text = "ALOBS No."
        '
        'txtAlobsNo
        '
        Me.txtAlobsNo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtAlobsNo.EditValue = ""
        Me.txtAlobsNo.Location = New System.Drawing.Point(143, 184)
        Me.txtAlobsNo.Name = "txtAlobsNo"
        Me.txtAlobsNo.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtAlobsNo.Properties.Appearance.Options.UseFont = True
        Me.txtAlobsNo.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtAlobsNo.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtAlobsNo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtAlobsNo.Size = New System.Drawing.Size(184, 26)
        Me.txtAlobsNo.TabIndex = 941
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.LabelControl6.Appearance.Options.UseFont = True
        Me.LabelControl6.Location = New System.Drawing.Point(87, 244)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(48, 17)
        Me.LabelControl6.TabIndex = 945
        Me.LabelControl6.Text = "Purpose"
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.LabelControl9.Appearance.Options.UseFont = True
        Me.LabelControl9.Location = New System.Drawing.Point(27, 45)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(108, 17)
        Me.LabelControl9.TabIndex = 947
        Me.LabelControl9.Text = "Office/Department"
        '
        'txtOffice
        '
        Me.txtOffice.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtOffice.EditValue = ""
        Me.txtOffice.Location = New System.Drawing.Point(143, 41)
        Me.txtOffice.Name = "txtOffice"
        Me.txtOffice.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtOffice.Properties.Appearance.Options.UseFont = True
        Me.txtOffice.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtOffice.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtOffice.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtOffice.Properties.ReadOnly = True
        Me.txtOffice.Size = New System.Drawing.Size(275, 26)
        Me.txtOffice.TabIndex = 946
        '
        'txtSaiDate
        '
        Me.txtSaiDate.EditValue = Nothing
        Me.txtSaiDate.Location = New System.Drawing.Point(143, 156)
        Me.txtSaiDate.Name = "txtSaiDate"
        Me.txtSaiDate.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtSaiDate.Properties.Appearance.Options.UseFont = True
        Me.txtSaiDate.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtSaiDate.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtSaiDate.Properties.AppearanceFocused.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtSaiDate.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtSaiDate.Properties.AppearanceFocused.Options.UseFont = True
        Me.txtSaiDate.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtSaiDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtSaiDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtSaiDate.Properties.Mask.EditMask = "MMMM dd, yyyy"
        Me.txtSaiDate.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtSaiDate.Size = New System.Drawing.Size(184, 26)
        Me.txtSaiDate.TabIndex = 948
        '
        'txtAlobsDate
        '
        Me.txtAlobsDate.EditValue = Nothing
        Me.txtAlobsDate.Location = New System.Drawing.Point(143, 213)
        Me.txtAlobsDate.Name = "txtAlobsDate"
        Me.txtAlobsDate.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtAlobsDate.Properties.Appearance.Options.UseFont = True
        Me.txtAlobsDate.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtAlobsDate.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtAlobsDate.Properties.AppearanceFocused.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtAlobsDate.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtAlobsDate.Properties.AppearanceFocused.Options.UseFont = True
        Me.txtAlobsDate.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtAlobsDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtAlobsDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtAlobsDate.Properties.Mask.EditMask = "MMMM dd, yyyy"
        Me.txtAlobsDate.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtAlobsDate.Size = New System.Drawing.Size(184, 26)
        Me.txtAlobsDate.TabIndex = 949
        '
        'pid
        '
        Me.pid.Location = New System.Drawing.Point(492, 109)
        Me.pid.Name = "pid"
        Me.pid.Properties.Appearance.Options.UseFont = True
        Me.pid.Properties.Appearance.Options.UseTextOptions = True
        Me.pid.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.pid.Properties.ReadOnly = True
        Me.pid.Size = New System.Drawing.Size(47, 20)
        Me.pid.TabIndex = 950
        Me.pid.Visible = False
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.LabelControl10.Appearance.Options.UseFont = True
        Me.LabelControl10.Location = New System.Drawing.Point(54, 324)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(81, 17)
        Me.LabelControl10.TabIndex = 951
        Me.LabelControl10.Text = "Add Print Line"
        '
        'txtAddPrintLine
        '
        Me.txtAddPrintLine.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtAddPrintLine.EditValue = "16"
        Me.txtAddPrintLine.Location = New System.Drawing.Point(143, 320)
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
        Me.txtAddPrintLine.TabIndex = 952
        '
        'frmPurchaseRequest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(476, 413)
        Me.Controls.Add(Me.txtAddPrintLine)
        Me.Controls.Add(Me.LabelControl10)
        Me.Controls.Add(Me.pid)
        Me.Controls.Add(Me.txtAlobsDate)
        Me.Controls.Add(Me.txtSaiDate)
        Me.Controls.Add(Me.LabelControl9)
        Me.Controls.Add(Me.txtOffice)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.txtAlobsNo)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.LabelControl8)
        Me.Controls.Add(Me.txtSaiNo)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.txtPostingDate)
        Me.Controls.Add(Me.LabelControl7)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.txtPRNumber)
        Me.Controls.Add(Me.txtPurpose)
        Me.Controls.Add(Me.officeid)
        Me.Controls.Add(Me.cmdaction)
        Me.Controls.Add(Me.txtSection)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmPurchaseRequest"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Purchase Request"
        CType(Me.officeid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPurpose.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPRNumber.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSection.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPostingDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPostingDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSaiNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAlobsNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOffice.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSaiDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSaiDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAlobsDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAlobsDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAddPrintLine.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents officeid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmdaction As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtPurpose As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPRNumber As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSection As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPostingDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSaiNo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtAlobsNo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtOffice As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtSaiDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtAlobsDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents pid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtAddPrintLine As DevExpress.XtraEditors.TextEdit
End Class
