<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmJournalEntryDebit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmJournalEntryDebit))
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtDebit = New DevExpress.XtraEditors.TextEdit()
        Me.cmdOk = New DevExpress.XtraEditors.SimpleButton()
        Me.mode = New DevExpress.XtraEditors.ButtonEdit()
        Me.id = New DevExpress.XtraEditors.ButtonEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtItem = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.gridItem = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.jevno = New DevExpress.XtraEditors.ButtonEdit()
        Me.ckEnableTagClass = New DevExpress.XtraEditors.CheckEdit()
        Me.txtExpiditureClass = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.gridExpenditure = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.officeid = New DevExpress.XtraEditors.ButtonEdit()
        Me.pid = New DevExpress.XtraEditors.ButtonEdit()
        CType(Me.txtDebit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.id.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtItem.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.jevno.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ckEnableTagClass.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtExpiditureClass.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridExpenditure, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.officeid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.LabelControl3.Location = New System.Drawing.Point(200, 128)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(37, 20)
        Me.LabelControl3.TabIndex = 837
        Me.LabelControl3.Text = "Debit"
        '
        'txtDebit
        '
        Me.txtDebit.EditValue = "0"
        Me.txtDebit.Location = New System.Drawing.Point(245, 125)
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
        Me.cmdOk.Location = New System.Drawing.Point(245, 158)
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
        Me.id.Location = New System.Drawing.Point(464, 238)
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
        'ckEnableTagClass
        '
        Me.ckEnableTagClass.Location = New System.Drawing.Point(79, 71)
        Me.ckEnableTagClass.Name = "ckEnableTagClass"
        Me.ckEnableTagClass.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ckEnableTagClass.Properties.Appearance.Options.UseFont = True
        Me.ckEnableTagClass.Properties.Caption = "Enable tagging of expenditure item"
        Me.ckEnableTagClass.Size = New System.Drawing.Size(347, 20)
        Me.ckEnableTagClass.TabIndex = 962
        '
        'txtExpiditureClass
        '
        Me.txtExpiditureClass.EditValue = "sss"
        Me.txtExpiditureClass.Enabled = False
        Me.txtExpiditureClass.Location = New System.Drawing.Point(79, 93)
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
        'officeid
        '
        Me.officeid.EditValue = ""
        Me.officeid.Location = New System.Drawing.Point(464, 212)
        Me.officeid.Name = "officeid"
        Me.officeid.Properties.Appearance.Options.UseTextOptions = True
        Me.officeid.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.officeid.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.officeid.Properties.Mask.BeepOnError = True
        Me.officeid.Properties.ReadOnly = True
        Me.officeid.Size = New System.Drawing.Size(39, 20)
        Me.officeid.TabIndex = 980
        Me.officeid.Visible = False
        '
        'pid
        '
        Me.pid.EditValue = ""
        Me.pid.Location = New System.Drawing.Point(464, 166)
        Me.pid.Name = "pid"
        Me.pid.Properties.Appearance.Options.UseTextOptions = True
        Me.pid.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.pid.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.pid.Properties.Mask.BeepOnError = True
        Me.pid.Properties.ReadOnly = True
        Me.pid.Size = New System.Drawing.Size(39, 20)
        Me.pid.TabIndex = 982
        Me.pid.Visible = False
        '
        'frmJournalEntryDebit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(515, 210)
        Me.Controls.Add(Me.pid)
        Me.Controls.Add(Me.officeid)
        Me.Controls.Add(Me.txtExpiditureClass)
        Me.Controls.Add(Me.jevno)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.txtItem)
        Me.Controls.Add(Me.mode)
        Me.Controls.Add(Me.id)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.txtDebit)
        Me.Controls.Add(Me.cmdOk)
        Me.Controls.Add(Me.ckEnableTagClass)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmJournalEntryDebit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Entry Information"
        CType(Me.txtDebit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.id.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtItem.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.jevno.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ckEnableTagClass.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtExpiditureClass.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridExpenditure, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.officeid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents jevno As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents ckEnableTagClass As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtExpiditureClass As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents gridExpenditure As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents officeid As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents pid As DevExpress.XtraEditors.ButtonEdit
End Class
