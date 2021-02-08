<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSourceOfFundInfo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSourceOfFundInfo))
        Me.cmdaction = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtAmount = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtAvailableBalance = New DevExpress.XtraEditors.TextEdit()
        Me.txtSource = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.gridSource = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.officeid = New DevExpress.XtraEditors.TextEdit()
        Me.periodcode = New DevExpress.XtraEditors.TextEdit()
        Me.sourceid = New DevExpress.XtraEditors.TextEdit()
        Me.pid = New DevExpress.XtraEditors.TextEdit()
        Me.requestno = New DevExpress.XtraEditors.TextEdit()
        Me.quarter = New DevExpress.XtraEditors.TextEdit()
        Me.classcode = New DevExpress.XtraEditors.TextEdit()
        CType(Me.txtAmount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAvailableBalance.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSource.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.officeid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.periodcode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sourceid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.requestno.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.quarter.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.classcode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdaction
        '
        Me.cmdaction.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.cmdaction.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.cmdaction.Appearance.Options.UseFont = True
        Me.cmdaction.Location = New System.Drawing.Point(210, 104)
        Me.cmdaction.Name = "cmdaction"
        Me.cmdaction.Size = New System.Drawing.Size(182, 36)
        Me.cmdaction.TabIndex = 3
        Me.cmdaction.Text = "Save"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(157, 78)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(45, 17)
        Me.LabelControl1.TabIndex = 567
        Me.LabelControl1.Text = "Amount"
        '
        'txtAmount
        '
        Me.txtAmount.EditValue = "0"
        Me.txtAmount.Location = New System.Drawing.Point(210, 72)
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
        Me.txtAmount.Size = New System.Drawing.Size(182, 28)
        Me.txtAmount.TabIndex = 1
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(102, 47)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(100, 17)
        Me.LabelControl2.TabIndex = 568
        Me.LabelControl2.Text = "Available Balance"
        '
        'txtAvailableBalance
        '
        Me.txtAvailableBalance.EditValue = "0.00"
        Me.txtAvailableBalance.Location = New System.Drawing.Point(210, 41)
        Me.txtAvailableBalance.Name = "txtAvailableBalance"
        Me.txtAvailableBalance.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtAvailableBalance.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txtAvailableBalance.Properties.Appearance.Options.UseFont = True
        Me.txtAvailableBalance.Properties.Appearance.Options.UseForeColor = True
        Me.txtAvailableBalance.Properties.Appearance.Options.UseTextOptions = True
        Me.txtAvailableBalance.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtAvailableBalance.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtAvailableBalance.Properties.Mask.EditMask = "n"
        Me.txtAvailableBalance.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtAvailableBalance.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtAvailableBalance.Properties.NullText = "0"
        Me.txtAvailableBalance.Properties.ReadOnly = True
        Me.txtAvailableBalance.Size = New System.Drawing.Size(182, 28)
        Me.txtAvailableBalance.TabIndex = 564
        '
        'txtSource
        '
        Me.txtSource.EditValue = "sss"
        Me.txtSource.Location = New System.Drawing.Point(117, 12)
        Me.txtSource.Name = "txtSource"
        Me.txtSource.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtSource.Properties.Appearance.Options.UseFont = True
        Me.txtSource.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtSource.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtSource.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtSource.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtSource.Properties.DisplayMember = "Select"
        Me.txtSource.Properties.NullText = ""
        Me.txtSource.Properties.PopupView = Me.gridSource
        Me.txtSource.Properties.ValueMember = "itemcode"
        Me.txtSource.Size = New System.Drawing.Size(275, 26)
        Me.txtSource.TabIndex = 929
        '
        'gridSource
        '
        Me.gridSource.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gridSource.Name = "gridSource"
        Me.gridSource.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridSource.OptionsView.ShowGroupPanel = False
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(20, 16)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(88, 17)
        Me.LabelControl3.TabIndex = 930
        Me.LabelControl3.Text = "Source of Fund"
        '
        'officeid
        '
        Me.officeid.Location = New System.Drawing.Point(20, 116)
        Me.officeid.Name = "officeid"
        Me.officeid.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.officeid.Properties.Appearance.Options.UseFont = True
        Me.officeid.Properties.Appearance.Options.UseTextOptions = True
        Me.officeid.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.officeid.Properties.ReadOnly = True
        Me.officeid.Size = New System.Drawing.Size(37, 24)
        Me.officeid.TabIndex = 959
        Me.officeid.Visible = False
        '
        'periodcode
        '
        Me.periodcode.Location = New System.Drawing.Point(59, 116)
        Me.periodcode.Name = "periodcode"
        Me.periodcode.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.periodcode.Properties.Appearance.Options.UseFont = True
        Me.periodcode.Properties.Appearance.Options.UseTextOptions = True
        Me.periodcode.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.periodcode.Properties.ReadOnly = True
        Me.periodcode.Size = New System.Drawing.Size(37, 24)
        Me.periodcode.TabIndex = 960
        Me.periodcode.Visible = False
        '
        'sourceid
        '
        Me.sourceid.Location = New System.Drawing.Point(99, 116)
        Me.sourceid.Name = "sourceid"
        Me.sourceid.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sourceid.Properties.Appearance.Options.UseFont = True
        Me.sourceid.Properties.Appearance.Options.UseTextOptions = True
        Me.sourceid.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.sourceid.Properties.ReadOnly = True
        Me.sourceid.Size = New System.Drawing.Size(37, 24)
        Me.sourceid.TabIndex = 961
        Me.sourceid.Visible = False
        '
        'pid
        '
        Me.pid.Location = New System.Drawing.Point(20, 90)
        Me.pid.Name = "pid"
        Me.pid.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pid.Properties.Appearance.Options.UseFont = True
        Me.pid.Properties.Appearance.Options.UseTextOptions = True
        Me.pid.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.pid.Properties.ReadOnly = True
        Me.pid.Size = New System.Drawing.Size(37, 24)
        Me.pid.TabIndex = 963
        Me.pid.Visible = False
        '
        'requestno
        '
        Me.requestno.Location = New System.Drawing.Point(59, 90)
        Me.requestno.Name = "requestno"
        Me.requestno.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.requestno.Properties.Appearance.Options.UseFont = True
        Me.requestno.Properties.Appearance.Options.UseTextOptions = True
        Me.requestno.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.requestno.Properties.ReadOnly = True
        Me.requestno.Size = New System.Drawing.Size(37, 24)
        Me.requestno.TabIndex = 964
        Me.requestno.Visible = False
        '
        'quarter
        '
        Me.quarter.Location = New System.Drawing.Point(99, 90)
        Me.quarter.Name = "quarter"
        Me.quarter.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.quarter.Properties.Appearance.Options.UseFont = True
        Me.quarter.Properties.Appearance.Options.UseTextOptions = True
        Me.quarter.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.quarter.Properties.ReadOnly = True
        Me.quarter.Size = New System.Drawing.Size(37, 24)
        Me.quarter.TabIndex = 965
        Me.quarter.Visible = False
        '
        'classcode
        '
        Me.classcode.Location = New System.Drawing.Point(138, 116)
        Me.classcode.Name = "classcode"
        Me.classcode.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.classcode.Properties.Appearance.Options.UseFont = True
        Me.classcode.Properties.Appearance.Options.UseTextOptions = True
        Me.classcode.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.classcode.Properties.ReadOnly = True
        Me.classcode.Size = New System.Drawing.Size(37, 24)
        Me.classcode.TabIndex = 966
        Me.classcode.Visible = False
        '
        'frmSourceOfFundInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(413, 155)
        Me.Controls.Add(Me.classcode)
        Me.Controls.Add(Me.quarter)
        Me.Controls.Add(Me.requestno)
        Me.Controls.Add(Me.pid)
        Me.Controls.Add(Me.sourceid)
        Me.Controls.Add(Me.periodcode)
        Me.Controls.Add(Me.officeid)
        Me.Controls.Add(Me.txtSource)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.cmdaction)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.txtAvailableBalance)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmSourceOfFundInfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Source of Fund Info"
        CType(Me.txtAmount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAvailableBalance.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSource.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.officeid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.periodcode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sourceid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.requestno.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.quarter.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.classcode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdaction As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtAmount As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtAvailableBalance As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtSource As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents gridSource As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents officeid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents periodcode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents sourceid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents pid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents requestno As DevExpress.XtraEditors.TextEdit
    Friend WithEvents quarter As DevExpress.XtraEditors.TextEdit
    Friend WithEvents classcode As DevExpress.XtraEditors.TextEdit
End Class
