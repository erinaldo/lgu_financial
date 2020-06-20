<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAssignAccountable
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
        Me.cmdset = New System.Windows.Forms.Button()
        Me.txtAccountable = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.invcode = New DevExpress.XtraEditors.TextEdit()
        Me.accountid = New DevExpress.XtraEditors.TextEdit()
        CType(Me.invcode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.accountid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdset
        '
        Me.cmdset.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.cmdset.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdset.Location = New System.Drawing.Point(212, 47)
        Me.cmdset.Name = "cmdset"
        Me.cmdset.Size = New System.Drawing.Size(118, 30)
        Me.cmdset.TabIndex = 5
        Me.cmdset.Text = "Confirm Change"
        Me.cmdset.UseVisualStyleBackColor = True
        '
        'txtAccountable
        '
        Me.txtAccountable.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtAccountable.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txtAccountable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtAccountable.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtAccountable.FormattingEnabled = True
        Me.txtAccountable.Location = New System.Drawing.Point(122, 18)
        Me.txtAccountable.Name = "txtAccountable"
        Me.txtAccountable.Size = New System.Drawing.Size(208, 25)
        Me.txtAccountable.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(23, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 17)
        Me.Label3.TabIndex = 377
        Me.Label3.Text = "Select Account"
        '
        'invcode
        '
        Me.invcode.Location = New System.Drawing.Point(481, 27)
        Me.invcode.Name = "invcode"
        Me.invcode.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.invcode.Properties.Appearance.Options.UseFont = True
        Me.invcode.Properties.Appearance.Options.UseTextOptions = True
        Me.invcode.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.invcode.Properties.ReadOnly = True
        Me.invcode.Size = New System.Drawing.Size(77, 24)
        Me.invcode.TabIndex = 662
        Me.invcode.Visible = False
        '
        'accountid
        '
        Me.accountid.Location = New System.Drawing.Point(481, 57)
        Me.accountid.Name = "accountid"
        Me.accountid.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.accountid.Properties.Appearance.Options.UseFont = True
        Me.accountid.Properties.Appearance.Options.UseTextOptions = True
        Me.accountid.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.accountid.Properties.ReadOnly = True
        Me.accountid.Size = New System.Drawing.Size(77, 24)
        Me.accountid.TabIndex = 664
        Me.accountid.Visible = False
        '
        'frmAssignAccountable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(355, 99)
        Me.Controls.Add(Me.accountid)
        Me.Controls.Add(Me.invcode)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtAccountable)
        Me.Controls.Add(Me.cmdset)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.MaximizeBox = False
        Me.Name = "frmAssignAccountable"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Assign Accountable"
        CType(Me.invcode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.accountid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdset As System.Windows.Forms.Button
    Friend WithEvents txtAccountable As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents invcode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents accountid As DevExpress.XtraEditors.TextEdit
End Class
