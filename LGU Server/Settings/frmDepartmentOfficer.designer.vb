<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDepartmentOfficer
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
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txtPosition = New DevExpress.XtraEditors.TextEdit()
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.mode = New DevExpress.XtraEditors.TextEdit()
        Me.id = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl54 = New DevExpress.XtraEditors.LabelControl()
        Me.txtDateTo = New DevExpress.XtraEditors.DateEdit()
        Me.txtDateFrom = New DevExpress.XtraEditors.DateEdit()
        Me.ckCurrent = New DevExpress.XtraEditors.CheckEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.officeid = New DevExpress.XtraEditors.TextEdit()
        Me.s_grid = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.txtOfficerIncharge = New DevExpress.XtraEditors.SearchLookUpEdit()
        CType(Me.txtPosition.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.id.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDateTo.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDateTo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDateFrom.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDateFrom.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ckCurrent.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.officeid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.s_grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOfficerIncharge.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Location = New System.Drawing.Point(55, 47)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(46, 17)
        Me.LabelControl4.TabIndex = 626
        Me.LabelControl4.Text = "Position"
        '
        'txtPosition
        '
        Me.txtPosition.EditValue = ""
        Me.txtPosition.EnterMoveNextControl = True
        Me.txtPosition.Location = New System.Drawing.Point(108, 43)
        Me.txtPosition.Name = "txtPosition"
        Me.txtPosition.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtPosition.Properties.Appearance.Options.UseFont = True
        Me.txtPosition.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtPosition.Size = New System.Drawing.Size(320, 26)
        Me.txtPosition.TabIndex = 1
        '
        'cmdSave
        '
        Me.cmdSave.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.cmdSave.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.cmdSave.Appearance.Options.UseFont = True
        Me.cmdSave.Location = New System.Drawing.Point(108, 101)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(117, 36)
        Me.cmdSave.TabIndex = 5
        Me.cmdSave.Text = "Save"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(24, 18)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(77, 17)
        Me.LabelControl2.TabIndex = 390
        Me.LabelControl2.Text = "Select Officer"
        '
        'mode
        '
        Me.mode.EnterMoveNextControl = True
        Me.mode.Location = New System.Drawing.Point(553, 49)
        Me.mode.Name = "mode"
        Me.mode.Size = New System.Drawing.Size(38, 20)
        Me.mode.TabIndex = 388
        Me.mode.Visible = False
        '
        'id
        '
        Me.id.EnterMoveNextControl = True
        Me.id.Location = New System.Drawing.Point(509, 49)
        Me.id.Name = "id"
        Me.id.Size = New System.Drawing.Size(38, 20)
        Me.id.TabIndex = 389
        Me.id.Visible = False
        '
        'LabelControl54
        '
        Me.LabelControl54.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LabelControl54.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.LabelControl54.Appearance.Options.UseFont = True
        Me.LabelControl54.Appearance.Options.UseForeColor = True
        Me.LabelControl54.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.LabelControl54.Location = New System.Drawing.Point(228, 77)
        Me.LabelControl54.Name = "LabelControl54"
        Me.LabelControl54.Size = New System.Drawing.Size(5, 15)
        Me.LabelControl54.TabIndex = 842
        Me.LabelControl54.Text = "-"
        '
        'txtDateTo
        '
        Me.txtDateTo.EditValue = Nothing
        Me.txtDateTo.EnterMoveNextControl = True
        Me.txtDateTo.Location = New System.Drawing.Point(235, 72)
        Me.txtDateTo.Name = "txtDateTo"
        Me.txtDateTo.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtDateTo.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtDateTo.Properties.Appearance.Options.UseBackColor = True
        Me.txtDateTo.Properties.Appearance.Options.UseFont = True
        Me.txtDateTo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtDateTo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtDateTo.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtDateTo.Properties.Mask.EditMask = "MMMM dd, yyyy"
        Me.txtDateTo.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtDateTo.Size = New System.Drawing.Size(117, 24)
        Me.txtDateTo.TabIndex = 3
        '
        'txtDateFrom
        '
        Me.txtDateFrom.EditValue = Nothing
        Me.txtDateFrom.EnterMoveNextControl = True
        Me.txtDateFrom.Location = New System.Drawing.Point(108, 72)
        Me.txtDateFrom.Name = "txtDateFrom"
        Me.txtDateFrom.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtDateFrom.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtDateFrom.Properties.Appearance.Options.UseBackColor = True
        Me.txtDateFrom.Properties.Appearance.Options.UseFont = True
        Me.txtDateFrom.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtDateFrom.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtDateFrom.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtDateFrom.Properties.Mask.EditMask = "MMMM dd, yyyy"
        Me.txtDateFrom.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtDateFrom.Size = New System.Drawing.Size(117, 24)
        Me.txtDateFrom.TabIndex = 2
        '
        'ckCurrent
        '
        Me.ckCurrent.Location = New System.Drawing.Point(358, 75)
        Me.ckCurrent.Name = "ckCurrent"
        Me.ckCurrent.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ckCurrent.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.ckCurrent.Properties.Appearance.Options.UseFont = True
        Me.ckCurrent.Properties.Appearance.Options.UseForeColor = True
        Me.ckCurrent.Properties.Caption = "Current"
        Me.ckCurrent.Size = New System.Drawing.Size(66, 20)
        Me.ckCurrent.TabIndex = 4
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(32, 75)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(69, 17)
        Me.LabelControl3.TabIndex = 852
        Me.LabelControl3.Text = "Date Period"
        '
        'officeid
        '
        Me.officeid.EnterMoveNextControl = True
        Me.officeid.Location = New System.Drawing.Point(509, 72)
        Me.officeid.Name = "officeid"
        Me.officeid.Size = New System.Drawing.Size(38, 20)
        Me.officeid.TabIndex = 853
        Me.officeid.Visible = False
        '
        's_grid
        '
        Me.s_grid.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.s_grid.Name = "s_grid"
        Me.s_grid.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.s_grid.OptionsView.ShowGroupPanel = False
        '
        'txtOfficerIncharge
        '
        Me.txtOfficerIncharge.EditValue = ""
        Me.txtOfficerIncharge.Location = New System.Drawing.Point(108, 14)
        Me.txtOfficerIncharge.Name = "txtOfficerIncharge"
        Me.txtOfficerIncharge.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtOfficerIncharge.Properties.Appearance.Options.UseFont = True
        Me.txtOfficerIncharge.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtOfficerIncharge.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtOfficerIncharge.Properties.DisplayMember = "Fullname"
        Me.txtOfficerIncharge.Properties.NullText = ""
        Me.txtOfficerIncharge.Properties.PopupView = Me.s_grid
        Me.txtOfficerIncharge.Properties.ValueMember = "accountid"
        Me.txtOfficerIncharge.Size = New System.Drawing.Size(213, 26)
        Me.txtOfficerIncharge.TabIndex = 0
        '
        'frmDepartmentOfficer
        '
        Me.AcceptButton = Me.cmdSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(447, 159)
        Me.Controls.Add(Me.officeid)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.ckCurrent)
        Me.Controls.Add(Me.LabelControl54)
        Me.Controls.Add(Me.txtDateTo)
        Me.Controls.Add(Me.txtDateFrom)
        Me.Controls.Add(Me.id)
        Me.Controls.Add(Me.mode)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.txtPosition)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.txtOfficerIncharge)
        Me.Controls.Add(Me.LabelControl2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmDepartmentOfficer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Officer Info"
        CType(Me.txtPosition.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.id.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDateTo.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDateTo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDateFrom.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDateFrom.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ckCurrent.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.officeid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.s_grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOfficerIncharge.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPosition As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents id As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl54 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDateTo As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtDateFrom As DevExpress.XtraEditors.DateEdit
    Friend WithEvents ckCurrent As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents officeid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents s_grid As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtOfficerIncharge As DevExpress.XtraEditors.SearchLookUpEdit
End Class
