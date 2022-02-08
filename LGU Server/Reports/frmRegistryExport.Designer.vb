<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRegistryExport
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.gridmenustrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmdCloseBalanceDefault = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdCloseBalanceRecompute = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProgressBarControl1 = New DevExpress.XtraEditors.ProgressBarControl()
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.txtTotalVoucher = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txtMonth = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.txtClass = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.gridclass = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtFund = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.gridFund = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.gridmenustrip.SuspendLayout()
        CType(Me.ProgressBarControl1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMonth.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtClass.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridclass, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFund.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridFund, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gridmenustrip
        '
        Me.gridmenustrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.gridmenustrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdCloseBalanceDefault, Me.cmdCloseBalanceRecompute, Me.ToolStripSeparator1, Me.RefreshToolStripMenuItem})
        Me.gridmenustrip.Name = "gridmenustrip"
        Me.gridmenustrip.Size = New System.Drawing.Size(437, 88)
        '
        'cmdCloseBalanceDefault
        '
        Me.cmdCloseBalanceDefault.Image = Global.LGUFinancial.My.Resources.Resources.tick
        Me.cmdCloseBalanceDefault.Name = "cmdCloseBalanceDefault"
        Me.cmdCloseBalanceDefault.Size = New System.Drawing.Size(436, 26)
        Me.cmdCloseBalanceDefault.Text = "Close and transfer all balances for next month"
        '
        'cmdCloseBalanceRecompute
        '
        Me.cmdCloseBalanceRecompute.Image = Global.LGUFinancial.My.Resources.Resources.exclamation_red_frame
        Me.cmdCloseBalanceRecompute.Name = "cmdCloseBalanceRecompute"
        Me.cmdCloseBalanceRecompute.Size = New System.Drawing.Size(436, 26)
        Me.cmdCloseBalanceRecompute.Text = "Close and transfer all balances for next month (Re-Update Balances)"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(433, 6)
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.Image = Global.LGUFinancial.My.Resources.Resources.arrow_continue_090_left
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(436, 26)
        Me.RefreshToolStripMenuItem.Text = "Refresh data table list"
        '
        'ProgressBarControl1
        '
        Me.ProgressBarControl1.Location = New System.Drawing.Point(138, 133)
        Me.ProgressBarControl1.Name = "ProgressBarControl1"
        Me.ProgressBarControl1.Properties.ShowTitle = True
        Me.ProgressBarControl1.Size = New System.Drawing.Size(294, 31)
        Me.ProgressBarControl1.TabIndex = 1012
        '
        'cmdSave
        '
        Me.cmdSave.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmdSave.Appearance.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmdSave.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.cmdSave.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.cmdSave.Appearance.Options.UseBackColor = True
        Me.cmdSave.Appearance.Options.UseFont = True
        Me.cmdSave.Location = New System.Drawing.Point(138, 168)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(294, 34)
        Me.cmdSave.TabIndex = 1009
        Me.cmdSave.Text = "Confirm Export"
        '
        'txtTotalVoucher
        '
        Me.txtTotalVoucher.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtTotalVoucher.Appearance.Options.UseFont = True
        Me.txtTotalVoucher.Location = New System.Drawing.Point(138, 108)
        Me.txtTotalVoucher.Name = "txtTotalVoucher"
        Me.txtTotalVoucher.Size = New System.Drawing.Size(294, 17)
        Me.txtTotalVoucher.TabIndex = 1017
        Me.txtTotalVoucher.Text = "Please select option above before proceed export"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Location = New System.Drawing.Point(56, 84)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(76, 17)
        Me.LabelControl4.TabIndex = 1023
        Me.LabelControl4.Text = "Select Month"
        '
        'txtMonth
        '
        Me.txtMonth.EditValue = ""
        Me.txtMonth.Location = New System.Drawing.Point(138, 81)
        Me.txtMonth.Name = "txtMonth"
        Me.txtMonth.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtMonth.Properties.Appearance.Options.UseFont = True
        Me.txtMonth.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtMonth.Properties.AppearanceDropDown.Options.UseFont = True
        Me.txtMonth.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtMonth.Properties.Items.AddRange(New Object() {"JANUARY", "FEBRUARY", "MARCH", "APRIL", "MAY", "JUNE", "JULY", "AUGUST", "SEPTEMBER", "OCTOBER", "NOVEMBER", "DECEMBER"})
        Me.txtMonth.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.txtMonth.Size = New System.Drawing.Size(294, 24)
        Me.txtMonth.TabIndex = 1022
        '
        'txtClass
        '
        Me.txtClass.EditValue = "sss"
        Me.txtClass.Location = New System.Drawing.Point(138, 54)
        Me.txtClass.Name = "txtClass"
        Me.txtClass.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtClass.Properties.Appearance.Options.UseFont = True
        Me.txtClass.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtClass.Properties.DisplayMember = "description"
        Me.txtClass.Properties.NullText = ""
        Me.txtClass.Properties.PopupView = Me.gridclass
        Me.txtClass.Properties.ValueMember = "code"
        Me.txtClass.Size = New System.Drawing.Size(294, 24)
        Me.txtClass.TabIndex = 1020
        '
        'gridclass
        '
        Me.gridclass.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gridclass.Name = "gridclass"
        Me.gridclass.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridclass.OptionsView.ShowGroupPanel = False
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(64, 57)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(68, 17)
        Me.LabelControl3.TabIndex = 1021
        Me.LabelControl3.Text = "Select Class"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(25, 31)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(107, 17)
        Me.LabelControl2.TabIndex = 1019
        Me.LabelControl2.Text = "Select fund period"
        '
        'txtFund
        '
        Me.txtFund.EditValue = "sss"
        Me.txtFund.Location = New System.Drawing.Point(138, 28)
        Me.txtFund.Name = "txtFund"
        Me.txtFund.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtFund.Properties.Appearance.Options.UseFont = True
        Me.txtFund.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtFund.Properties.DisplayMember = "fund"
        Me.txtFund.Properties.NullText = ""
        Me.txtFund.Properties.PopupView = Me.gridFund
        Me.txtFund.Properties.ValueMember = "periodcode"
        Me.txtFund.Size = New System.Drawing.Size(294, 24)
        Me.txtFund.TabIndex = 1018
        '
        'gridFund
        '
        Me.gridFund.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gridFund.Name = "gridFund"
        Me.gridFund.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridFund.OptionsView.ShowGroupPanel = False
        '
        'frmRegistryExport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(504, 215)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.txtMonth)
        Me.Controls.Add(Me.txtClass)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.txtFund)
        Me.Controls.Add(Me.txtTotalVoucher)
        Me.Controls.Add(Me.ProgressBarControl1)
        Me.Controls.Add(Me.cmdSave)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRegistryExport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Export Registry Report Batching"
        Me.gridmenustrip.ResumeLayout(False)
        CType(Me.ProgressBarControl1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMonth.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtClass.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridclass, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFund.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridFund, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gridmenustrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmdCloseBalanceDefault As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RefreshToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdCloseBalanceRecompute As ToolStripMenuItem
    Friend WithEvents ProgressBarControl1 As DevExpress.XtraEditors.ProgressBarControl
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents txtTotalVoucher As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtMonth As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txtClass As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents gridclass As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtFund As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents gridFund As DevExpress.XtraGrid.Views.Grid.GridView
End Class
