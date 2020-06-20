<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmJournalEntryItem
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmJournalEntryItem))
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtDebit = New DevExpress.XtraEditors.TextEdit()
        Me.cmdOk = New DevExpress.XtraEditors.SimpleButton()
        Me.mode = New DevExpress.XtraEditors.ButtonEdit()
        Me.id = New DevExpress.XtraEditors.ButtonEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtItem = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.gridItem = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txtCredit = New DevExpress.XtraEditors.TextEdit()
        Me.jevno = New DevExpress.XtraEditors.ButtonEdit()
        Me.txtOffice = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.gridOffice = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ckEnableCenter = New DevExpress.XtraEditors.CheckEdit()
        Me.ckEnableTagClass = New DevExpress.XtraEditors.CheckEdit()
        Me.txtExpiditureClass = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.gridExpenditure = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.txtCheckNo = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.txtDebit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.id.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtItem.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCredit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.jevno.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOffice.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridOffice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ckEnableCenter.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ckEnableTagClass.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtExpiditureClass.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridExpenditure, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCheckNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Appearance.Options.UseTextOptions = True
        Me.LabelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl3.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.LabelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal
        Me.LabelControl3.Location = New System.Drawing.Point(200, 208)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(37, 20)
        Me.LabelControl3.TabIndex = 837
        Me.LabelControl3.Text = "Debit"
        '
        'txtDebit
        '
        Me.txtDebit.EditValue = "0"
        Me.txtDebit.Location = New System.Drawing.Point(245, 205)
        Me.txtDebit.Name = "txtDebit"
        Me.txtDebit.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtDebit.Properties.Appearance.Options.UseFont = True
        Me.txtDebit.Properties.Appearance.Options.UseTextOptions = True
        Me.txtDebit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtDebit.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtDebit.Properties.AppearanceFocused.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtDebit.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtDebit.Properties.AppearanceFocused.Options.UseFont = True
        Me.txtDebit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtDebit.Properties.Mask.EditMask = "n"
        Me.txtDebit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtDebit.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtDebit.Properties.MaxLength = 50
        Me.txtDebit.Size = New System.Drawing.Size(181, 28)
        Me.txtDebit.TabIndex = 4
        '
        'cmdOk
        '
        Me.cmdOk.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdOk.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOk.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.cmdOk.Appearance.Options.UseBackColor = True
        Me.cmdOk.Appearance.Options.UseFont = True
        Me.cmdOk.Location = New System.Drawing.Point(245, 269)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(181, 32)
        Me.cmdOk.TabIndex = 6
        Me.cmdOk.Text = "Add to Journal"
        '
        'mode
        '
        Me.mode.EditValue = ""
        Me.mode.Location = New System.Drawing.Point(424, 397)
        Me.mode.Name = "mode"
        Me.mode.Properties.Appearance.Options.UseTextOptions = True
        Me.mode.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.mode.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.mode.Properties.Mask.BeepOnError = True
        Me.mode.Properties.ReadOnly = True
        Me.mode.Size = New System.Drawing.Size(39, 20)
        Me.mode.TabIndex = 839
        Me.mode.Visible = False
        '
        'id
        '
        Me.id.EditValue = ""
        Me.id.Location = New System.Drawing.Point(469, 397)
        Me.id.Name = "id"
        Me.id.Properties.Appearance.Options.UseTextOptions = True
        Me.id.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.id.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.id.Properties.Mask.BeepOnError = True
        Me.id.Properties.ReadOnly = True
        Me.id.Size = New System.Drawing.Size(39, 20)
        Me.id.TabIndex = 838
        Me.id.Visible = False
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(79, 21)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(223, 15)
        Me.LabelControl2.TabIndex = 841
        Me.LabelControl2.Text = "Select account title for specific transaction"
        '
        'txtItem
        '
        Me.txtItem.EditValue = ""
        Me.txtItem.Location = New System.Drawing.Point(79, 40)
        Me.txtItem.Name = "txtItem"
        Me.txtItem.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtItem.Properties.Appearance.Options.UseFont = True
        Me.txtItem.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtItem.Properties.AppearanceFocused.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtItem.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtItem.Properties.AppearanceFocused.Options.UseFont = True
        Me.txtItem.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtItem.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtItem.Properties.DisplayMember = "itemname"
        Me.txtItem.Properties.NullText = ""
        Me.txtItem.Properties.PopupView = Me.gridItem
        Me.txtItem.Properties.ValueMember = "itemcode"
        Me.txtItem.Size = New System.Drawing.Size(347, 26)
        Me.txtItem.TabIndex = 0
        '
        'gridItem
        '
        Me.gridItem.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gridItem.Name = "gridItem"
        Me.gridItem.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridItem.OptionsView.ShowGroupPanel = False
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Appearance.Options.UseTextOptions = True
        Me.LabelControl4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl4.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.LabelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal
        Me.LabelControl4.Location = New System.Drawing.Point(197, 239)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(40, 20)
        Me.LabelControl4.TabIndex = 843
        Me.LabelControl4.Text = "Credit"
        '
        'txtCredit
        '
        Me.txtCredit.EditValue = "0"
        Me.txtCredit.Location = New System.Drawing.Point(245, 236)
        Me.txtCredit.Name = "txtCredit"
        Me.txtCredit.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtCredit.Properties.Appearance.Options.UseFont = True
        Me.txtCredit.Properties.Appearance.Options.UseTextOptions = True
        Me.txtCredit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtCredit.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCredit.Properties.AppearanceFocused.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtCredit.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtCredit.Properties.AppearanceFocused.Options.UseFont = True
        Me.txtCredit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtCredit.Properties.Mask.EditMask = "n"
        Me.txtCredit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtCredit.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtCredit.Properties.MaxLength = 50
        Me.txtCredit.Size = New System.Drawing.Size(181, 28)
        Me.txtCredit.TabIndex = 5
        '
        'jevno
        '
        Me.jevno.EditValue = ""
        Me.jevno.Location = New System.Drawing.Point(379, 397)
        Me.jevno.Name = "jevno"
        Me.jevno.Properties.Appearance.Options.UseTextOptions = True
        Me.jevno.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.jevno.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.jevno.Properties.Mask.BeepOnError = True
        Me.jevno.Properties.ReadOnly = True
        Me.jevno.Size = New System.Drawing.Size(39, 20)
        Me.jevno.TabIndex = 844
        Me.jevno.Visible = False
        '
        'txtOffice
        '
        Me.txtOffice.EditValue = "sss"
        Me.txtOffice.Enabled = False
        Me.txtOffice.Location = New System.Drawing.Point(79, 91)
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
        Me.txtOffice.Properties.ValueMember = "code"
        Me.txtOffice.Size = New System.Drawing.Size(347, 26)
        Me.txtOffice.TabIndex = 1
        '
        'gridOffice
        '
        Me.gridOffice.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gridOffice.Name = "gridOffice"
        Me.gridOffice.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridOffice.OptionsView.ShowGroupPanel = False
        '
        'ckEnableCenter
        '
        Me.ckEnableCenter.Location = New System.Drawing.Point(79, 69)
        Me.ckEnableCenter.Name = "ckEnableCenter"
        Me.ckEnableCenter.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ckEnableCenter.Properties.Appearance.Options.UseFont = True
        Me.ckEnableCenter.Properties.Caption = "Enable tagging responsibility center to a specific entries"
        Me.ckEnableCenter.Size = New System.Drawing.Size(347, 19)
        Me.ckEnableCenter.TabIndex = 960
        '
        'ckEnableTagClass
        '
        Me.ckEnableTagClass.Location = New System.Drawing.Point(79, 123)
        Me.ckEnableTagClass.Name = "ckEnableTagClass"
        Me.ckEnableTagClass.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ckEnableTagClass.Properties.Appearance.Options.UseFont = True
        Me.ckEnableTagClass.Properties.Caption = "Enable tagging of expenditure item"
        Me.ckEnableTagClass.Size = New System.Drawing.Size(347, 19)
        Me.ckEnableTagClass.TabIndex = 962
        '
        'txtExpiditureClass
        '
        Me.txtExpiditureClass.EditValue = "sss"
        Me.txtExpiditureClass.Enabled = False
        Me.txtExpiditureClass.Location = New System.Drawing.Point(79, 145)
        Me.txtExpiditureClass.Name = "txtExpiditureClass"
        Me.txtExpiditureClass.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtExpiditureClass.Properties.Appearance.Options.UseFont = True
        Me.txtExpiditureClass.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtExpiditureClass.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtExpiditureClass.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtExpiditureClass.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtExpiditureClass.Properties.DisplayMember = "Select"
        Me.txtExpiditureClass.Properties.NullText = ""
        Me.txtExpiditureClass.Properties.PopupView = Me.gridExpenditure
        Me.txtExpiditureClass.Properties.ValueMember = "code"
        Me.txtExpiditureClass.Size = New System.Drawing.Size(347, 26)
        Me.txtExpiditureClass.TabIndex = 2
        '
        'gridExpenditure
        '
        Me.gridExpenditure.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gridExpenditure.Name = "gridExpenditure"
        Me.gridExpenditure.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridExpenditure.OptionsView.ShowGroupPanel = False
        '
        'txtCheckNo
        '
        Me.txtCheckNo.EditValue = ""
        Me.txtCheckNo.Location = New System.Drawing.Point(245, 176)
        Me.txtCheckNo.Name = "txtCheckNo"
        Me.txtCheckNo.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtCheckNo.Properties.Appearance.Options.UseFont = True
        Me.txtCheckNo.Properties.Appearance.Options.UseTextOptions = True
        Me.txtCheckNo.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtCheckNo.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCheckNo.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtCheckNo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtCheckNo.Size = New System.Drawing.Size(181, 26)
        Me.txtCheckNo.TabIndex = 3
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseTextOptions = True
        Me.LabelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.LabelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal
        Me.LabelControl1.Location = New System.Drawing.Point(171, 178)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(66, 20)
        Me.LabelControl1.TabIndex = 979
        Me.LabelControl1.Text = "Check No."
        '
        'frmJournalEntryItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(515, 333)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.txtExpiditureClass)
        Me.Controls.Add(Me.ckEnableCenter)
        Me.Controls.Add(Me.txtOffice)
        Me.Controls.Add(Me.jevno)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.txtCredit)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.txtItem)
        Me.Controls.Add(Me.mode)
        Me.Controls.Add(Me.id)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.txtDebit)
        Me.Controls.Add(Me.cmdOk)
        Me.Controls.Add(Me.txtCheckNo)
        Me.Controls.Add(Me.ckEnableTagClass)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmJournalEntryItem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Entry Information"
        CType(Me.txtDebit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.id.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtItem.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCredit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.jevno.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOffice.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridOffice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ckEnableCenter.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ckEnableTagClass.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtExpiditureClass.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridExpenditure, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCheckNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDebit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmdOk As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents mode As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents id As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtItem As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents gridItem As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCredit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents jevno As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents txtOffice As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents gridOffice As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ckEnableCenter As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents ckEnableTagClass As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtExpiditureClass As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents gridExpenditure As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtCheckNo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
End Class
