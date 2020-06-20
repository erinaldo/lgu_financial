<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTaxPayerInfo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTaxPayerInfo))
        Me.id = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.txtContactNo = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtAgency = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.gridAgency = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.txtFullname = New DevExpress.XtraEditors.TextEdit()
        Me.cmdSaveButton = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.mode = New DevExpress.XtraEditors.TextEdit()
        Me.cmdAgency = New System.Windows.Forms.LinkLabel()
        Me.trnmode = New DevExpress.XtraEditors.TextEdit()
        Me.txtTIN = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtAddress = New DevExpress.XtraEditors.ComboBoxEdit()
        CType(Me.id.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtContactNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAgency.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridAgency, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFullname.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trnmode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTIN.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAddress.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'id
        '
        Me.id.Location = New System.Drawing.Point(497, 104)
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
        Me.LabelControl5.Location = New System.Drawing.Point(51, 117)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(69, 17)
        Me.LabelControl5.TabIndex = 656
        Me.LabelControl5.Text = "Contact No."
        '
        'txtContactNo
        '
        Me.txtContactNo.EditValue = ""
        Me.txtContactNo.Location = New System.Drawing.Point(129, 114)
        Me.txtContactNo.Name = "txtContactNo"
        Me.txtContactNo.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtContactNo.Properties.Appearance.Options.UseFont = True
        Me.txtContactNo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtContactNo.Properties.Mask.BeepOnError = True
        Me.txtContactNo.Properties.Mask.EditMask = "(0999) 000-0000"
        Me.txtContactNo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
        Me.txtContactNo.Size = New System.Drawing.Size(168, 28)
        Me.txtContactNo.TabIndex = 3
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(72, 86)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(48, 17)
        Me.LabelControl3.TabIndex = 654
        Me.LabelControl3.Text = "Address"
        '
        'txtAgency
        '
        Me.txtAgency.EditValue = "sss"
        Me.txtAgency.Location = New System.Drawing.Point(129, 21)
        Me.txtAgency.Name = "txtAgency"
        Me.txtAgency.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtAgency.Properties.Appearance.Options.UseFont = True
        Me.txtAgency.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtAgency.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtAgency.Properties.DisplayMember = "Select"
        Me.txtAgency.Properties.NullText = ""
        Me.txtAgency.Properties.PopupView = Me.gridAgency
        Me.txtAgency.Properties.ValueMember = "id"
        Me.txtAgency.Size = New System.Drawing.Size(251, 28)
        Me.txtAgency.TabIndex = 0
        '
        'gridAgency
        '
        Me.gridAgency.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gridAgency.Name = "gridAgency"
        Me.gridAgency.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridAgency.OptionsView.ShowGroupPanel = False
        '
        'txtFullname
        '
        Me.txtFullname.EditValue = ""
        Me.txtFullname.Location = New System.Drawing.Point(129, 52)
        Me.txtFullname.Name = "txtFullname"
        Me.txtFullname.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtFullname.Properties.Appearance.Options.UseFont = True
        Me.txtFullname.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtFullname.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFullname.Size = New System.Drawing.Size(251, 28)
        Me.txtFullname.TabIndex = 1
        '
        'cmdSaveButton
        '
        Me.cmdSaveButton.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdSaveButton.Appearance.BackColor2 = System.Drawing.Color.Khaki
        Me.cmdSaveButton.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSaveButton.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.cmdSaveButton.Appearance.Options.UseBackColor = True
        Me.cmdSaveButton.Appearance.Options.UseFont = True
        Me.cmdSaveButton.Location = New System.Drawing.Point(129, 177)
        Me.cmdSaveButton.Name = "cmdSaveButton"
        Me.cmdSaveButton.Size = New System.Drawing.Size(168, 38)
        Me.cmdSaveButton.TabIndex = 5
        Me.cmdSaveButton.Text = "Save"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(69, 55)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(51, 17)
        Me.LabelControl1.TabIndex = 652
        Me.LabelControl1.Text = "Fullname"
        '
        'mode
        '
        Me.mode.Location = New System.Drawing.Point(497, 131)
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
        'cmdAgency
        '
        Me.cmdAgency.AutoSize = True
        Me.cmdAgency.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmdAgency.Location = New System.Drawing.Point(66, 24)
        Me.cmdAgency.Name = "cmdAgency"
        Me.cmdAgency.Size = New System.Drawing.Size(54, 19)
        Me.cmdAgency.TabIndex = 660
        Me.cmdAgency.TabStop = True
        Me.cmdAgency.Text = "Agency"
        '
        'trnmode
        '
        Me.trnmode.Location = New System.Drawing.Point(497, 161)
        Me.trnmode.Name = "trnmode"
        Me.trnmode.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.trnmode.Properties.Appearance.Options.UseFont = True
        Me.trnmode.Properties.Appearance.Options.UseTextOptions = True
        Me.trnmode.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.trnmode.Properties.ReadOnly = True
        Me.trnmode.Size = New System.Drawing.Size(37, 24)
        Me.trnmode.TabIndex = 661
        Me.trnmode.Visible = False
        '
        'txtTIN
        '
        Me.txtTIN.EditValue = ""
        Me.txtTIN.EnterMoveNextControl = True
        Me.txtTIN.Location = New System.Drawing.Point(129, 145)
        Me.txtTIN.Name = "txtTIN"
        Me.txtTIN.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtTIN.Properties.Appearance.Options.UseFont = True
        Me.txtTIN.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTIN.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtTIN.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTIN.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtTIN.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtTIN.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTIN.Properties.Mask.EditMask = "000-000-000-00000"
        Me.txtTIN.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
        Me.txtTIN.Properties.MaxLength = 50
        Me.txtTIN.Size = New System.Drawing.Size(168, 28)
        Me.txtTIN.TabIndex = 4
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(100, 149)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(20, 17)
        Me.LabelControl2.TabIndex = 920
        Me.LabelControl2.Text = "TIN"
        '
        'txtAddress
        '
        Me.txtAddress.EditValue = ""
        Me.txtAddress.Location = New System.Drawing.Point(129, 83)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtAddress.Properties.Appearance.Options.UseFont = True
        Me.txtAddress.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtAddress.Properties.AppearanceDropDown.Options.UseFont = True
        Me.txtAddress.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtAddress.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtAddress.Properties.ImmediatePopup = True
        Me.txtAddress.Size = New System.Drawing.Size(327, 28)
        Me.txtAddress.TabIndex = 2
        '
        'frmTaxPayerInfo
        '
        Me.AcceptButton = Me.cmdSaveButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(569, 234)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.txtTIN)
        Me.Controls.Add(Me.trnmode)
        Me.Controls.Add(Me.cmdAgency)
        Me.Controls.Add(Me.id)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.txtContactNo)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.txtAgency)
        Me.Controls.Add(Me.txtFullname)
        Me.Controls.Add(Me.cmdSaveButton)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.mode)
        Me.Controls.Add(Me.txtAddress)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmTaxPayerInfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Customer Information Form"
        CType(Me.id.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtContactNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAgency.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridAgency, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFullname.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trnmode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTIN.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAddress.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents id As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtContactNo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtAgency As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents gridAgency As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtFullname As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmdSaveButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents mode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmdAgency As System.Windows.Forms.LinkLabel
    Friend WithEvents trnmode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTIN As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtAddress As DevExpress.XtraEditors.ComboBoxEdit
End Class
