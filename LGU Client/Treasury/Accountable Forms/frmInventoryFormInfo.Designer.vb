<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmInventoryFormInfo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInventoryFormInfo))
        Me.id = New DevExpress.XtraEditors.TextEdit()
        Me.formcode = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.txtCurrentNo = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtForm = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.gridForm = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.txtSeriesTo = New DevExpress.XtraEditors.TextEdit()
        Me.txtSeriesFrom = New DevExpress.XtraEditors.TextEdit()
        Me.cmdSaveButton = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.mode = New DevExpress.XtraEditors.TextEdit()
        CType(Me.id.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.formcode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCurrentNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtForm.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridForm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSeriesTo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSeriesFrom.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'id
        '
        Me.id.Location = New System.Drawing.Point(604, 34)
        Me.id.Name = "id"
        Me.id.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.id.Properties.Appearance.Options.UseFont = True
        Me.id.Properties.Appearance.Options.UseTextOptions = True
        Me.id.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.id.Properties.ReadOnly = True
        Me.id.Size = New System.Drawing.Size(77, 24)
        Me.id.TabIndex = 659
        Me.id.Visible = False
        '
        'formcode
        '
        Me.formcode.Location = New System.Drawing.Point(604, 92)
        Me.formcode.Name = "formcode"
        Me.formcode.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.formcode.Properties.Appearance.Options.UseFont = True
        Me.formcode.Properties.Appearance.Options.UseTextOptions = True
        Me.formcode.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.formcode.Properties.ReadOnly = True
        Me.formcode.Size = New System.Drawing.Size(77, 24)
        Me.formcode.TabIndex = 658
        Me.formcode.Visible = False
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.Location = New System.Drawing.Point(69, 108)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(68, 17)
        Me.LabelControl5.TabIndex = 656
        Me.LabelControl5.Text = "Current No."
        '
        'txtCurrentNo
        '
        Me.txtCurrentNo.EditValue = ""
        Me.txtCurrentNo.Location = New System.Drawing.Point(145, 105)
        Me.txtCurrentNo.Name = "txtCurrentNo"
        Me.txtCurrentNo.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCurrentNo.Properties.Appearance.Options.UseFont = True
        Me.txtCurrentNo.Properties.Appearance.Options.UseTextOptions = True
        Me.txtCurrentNo.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtCurrentNo.Size = New System.Drawing.Size(168, 24)
        Me.txtCurrentNo.TabIndex = 3
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(83, 80)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(54, 17)
        Me.LabelControl3.TabIndex = 654
        Me.LabelControl3.Text = "Series To"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(69, 26)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(68, 17)
        Me.LabelControl2.TabIndex = 653
        Me.LabelControl2.Text = "Select Form"
        '
        'txtForm
        '
        Me.txtForm.EditValue = "sss"
        Me.txtForm.Location = New System.Drawing.Point(145, 23)
        Me.txtForm.Name = "txtForm"
        Me.txtForm.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtForm.Properties.Appearance.Options.UseFont = True
        Me.txtForm.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtForm.Properties.DisplayMember = "Description"
        Me.txtForm.Properties.NullText = ""
        Me.txtForm.Properties.PopupView = Me.gridForm
        Me.txtForm.Properties.ValueMember = "code"
        Me.txtForm.Size = New System.Drawing.Size(251, 24)
        Me.txtForm.TabIndex = 0
        '
        'gridForm
        '
        Me.gridForm.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gridForm.Name = "gridForm"
        Me.gridForm.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridForm.OptionsView.ShowGroupPanel = False
        '
        'txtSeriesTo
        '
        Me.txtSeriesTo.EditValue = ""
        Me.txtSeriesTo.Location = New System.Drawing.Point(145, 77)
        Me.txtSeriesTo.Name = "txtSeriesTo"
        Me.txtSeriesTo.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSeriesTo.Properties.Appearance.Options.UseFont = True
        Me.txtSeriesTo.Properties.Appearance.Options.UseTextOptions = True
        Me.txtSeriesTo.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtSeriesTo.Size = New System.Drawing.Size(168, 24)
        Me.txtSeriesTo.TabIndex = 2
        '
        'txtSeriesFrom
        '
        Me.txtSeriesFrom.EditValue = ""
        Me.txtSeriesFrom.Location = New System.Drawing.Point(145, 50)
        Me.txtSeriesFrom.Name = "txtSeriesFrom"
        Me.txtSeriesFrom.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSeriesFrom.Properties.Appearance.Options.UseFont = True
        Me.txtSeriesFrom.Properties.Appearance.Options.UseTextOptions = True
        Me.txtSeriesFrom.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtSeriesFrom.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSeriesFrom.Size = New System.Drawing.Size(168, 24)
        Me.txtSeriesFrom.TabIndex = 1
        '
        'cmdSaveButton
        '
        Me.cmdSaveButton.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdSaveButton.Appearance.BackColor2 = System.Drawing.Color.Khaki
        Me.cmdSaveButton.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSaveButton.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.cmdSaveButton.Appearance.Options.UseBackColor = True
        Me.cmdSaveButton.Appearance.Options.UseFont = True
        Me.cmdSaveButton.Location = New System.Drawing.Point(145, 135)
        Me.cmdSaveButton.Name = "cmdSaveButton"
        Me.cmdSaveButton.Size = New System.Drawing.Size(168, 38)
        Me.cmdSaveButton.TabIndex = 4
        Me.cmdSaveButton.Text = "Save"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(68, 53)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(69, 17)
        Me.LabelControl1.TabIndex = 652
        Me.LabelControl1.Text = "Series From"
        '
        'mode
        '
        Me.mode.Location = New System.Drawing.Point(604, 61)
        Me.mode.Name = "mode"
        Me.mode.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mode.Properties.Appearance.Options.UseFont = True
        Me.mode.Properties.Appearance.Options.UseTextOptions = True
        Me.mode.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.mode.Properties.ReadOnly = True
        Me.mode.Size = New System.Drawing.Size(77, 24)
        Me.mode.TabIndex = 651
        Me.mode.Visible = False
        '
        'frmInventoryFormInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(488, 200)
        Me.Controls.Add(Me.id)
        Me.Controls.Add(Me.formcode)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.txtCurrentNo)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.txtForm)
        Me.Controls.Add(Me.txtSeriesTo)
        Me.Controls.Add(Me.txtSeriesFrom)
        Me.Controls.Add(Me.cmdSaveButton)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.mode)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmInventoryFormInfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Accountable Form Information"
        CType(Me.id.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.formcode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCurrentNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtForm.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridForm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSeriesTo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSeriesFrom.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents id As DevExpress.XtraEditors.TextEdit
    Friend WithEvents formcode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCurrentNo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtForm As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents gridForm As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtSeriesTo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtSeriesFrom As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmdSaveButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents mode As DevExpress.XtraEditors.TextEdit
End Class
