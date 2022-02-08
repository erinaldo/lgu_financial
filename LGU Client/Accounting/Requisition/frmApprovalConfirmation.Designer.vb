﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmApprovalConfirmation
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
        Me.lbltitle = New DevExpress.XtraEditors.LabelControl()
        Me.cmdConfirm = New DevExpress.XtraEditors.SimpleButton()
        Me.txtRemarks = New DevExpress.XtraEditors.MemoEdit()
        Me.mode = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtAccessAccount = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.gridAccessTo = New DevExpress.XtraGrid.Views.Grid.GridView()
        CType(Me.txtRemarks.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAccessAccount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridAccessTo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbltitle
        '
        Me.lbltitle.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbltitle.Appearance.Options.UseFont = True
        Me.lbltitle.Location = New System.Drawing.Point(22, 12)
        Me.lbltitle.Name = "lbltitle"
        Me.lbltitle.Size = New System.Drawing.Size(394, 15)
        Me.lbltitle.TabIndex = 574
        Me.lbltitle.Text = "Please enter your confirmation remarks so next approver will depends on it"
        '
        'cmdConfirm
        '
        Me.cmdConfirm.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.cmdConfirm.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.cmdConfirm.Appearance.Options.UseFont = True
        Me.cmdConfirm.Location = New System.Drawing.Point(256, 114)
        Me.cmdConfirm.Name = "cmdConfirm"
        Me.cmdConfirm.Size = New System.Drawing.Size(182, 36)
        Me.cmdConfirm.TabIndex = 3
        Me.cmdConfirm.Text = "Confirm"
        '
        'txtRemarks
        '
        Me.txtRemarks.EditValue = ""
        Me.txtRemarks.Location = New System.Drawing.Point(22, 33)
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtRemarks.Properties.Appearance.Options.UseFont = True
        Me.txtRemarks.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtRemarks.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtRemarks.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtRemarks.Properties.NullValuePrompt = "Specify transaction remarks. i.e name of person, details, etc"
        Me.txtRemarks.Size = New System.Drawing.Size(416, 75)
        Me.txtRemarks.TabIndex = 0
        '
        'mode
        '
        Me.mode.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.mode.Location = New System.Drawing.Point(34, 196)
        Me.mode.Name = "mode"
        Me.mode.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mode.Properties.Appearance.Options.UseFont = True
        Me.mode.Properties.Appearance.Options.UseTextOptions = True
        Me.mode.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.mode.Properties.ReadOnly = True
        Me.mode.Size = New System.Drawing.Size(37, 24)
        Me.mode.TabIndex = 955
        Me.mode.Visible = False
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(42, 117)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(105, 17)
        Me.LabelControl1.TabIndex = 957
        Me.LabelControl1.Text = "Authorize Account"
        '
        'txtAccessAccount
        '
        Me.txtAccessAccount.EditValue = ""
        Me.txtAccessAccount.Location = New System.Drawing.Point(154, 113)
        Me.txtAccessAccount.Name = "txtAccessAccount"
        Me.txtAccessAccount.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.25!)
        Me.txtAccessAccount.Properties.Appearance.Options.UseFont = True
        Me.txtAccessAccount.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtAccessAccount.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtAccessAccount.Properties.DisplayMember = "Fullname"
        Me.txtAccessAccount.Properties.NullText = ""
        Me.txtAccessAccount.Properties.PopupView = Me.gridAccessTo
        Me.txtAccessAccount.Properties.ValueMember = "accessto"
        Me.txtAccessAccount.Size = New System.Drawing.Size(284, 26)
        Me.txtAccessAccount.TabIndex = 956
        '
        'gridAccessTo
        '
        Me.gridAccessTo.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gridAccessTo.Name = "gridAccessTo"
        Me.gridAccessTo.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridAccessTo.OptionsView.ShowGroupPanel = False
        '
        'frmApprovalConfirmation
        '
        Me.AcceptButton = Me.cmdConfirm
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(457, 163)
        Me.Controls.Add(Me.cmdConfirm)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.txtAccessAccount)
        Me.Controls.Add(Me.mode)
        Me.Controls.Add(Me.txtRemarks)
        Me.Controls.Add(Me.lbltitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.MaximizeBox = False
        Me.Name = "frmApprovalConfirmation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Request Confirmation"
        CType(Me.txtRemarks.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAccessAccount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridAccessTo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbltitle As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmdConfirm As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtRemarks As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents mode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtAccessAccount As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents gridAccessTo As DevExpress.XtraGrid.Views.Grid.GridView
End Class
