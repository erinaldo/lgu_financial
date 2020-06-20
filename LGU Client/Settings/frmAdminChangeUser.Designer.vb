<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdminChangeUser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAdminChangeUser))
        Me.cmdset = New System.Windows.Forms.Button()
        Me.txtFeatures = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtUserAccount = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmdset
        '
        Me.cmdset.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdset.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdset.Location = New System.Drawing.Point(297, 145)
        Me.cmdset.Name = "cmdset"
        Me.cmdset.Size = New System.Drawing.Size(150, 30)
        Me.cmdset.TabIndex = 5
        Me.cmdset.Text = "Confirm Change"
        Me.cmdset.UseVisualStyleBackColor = True
        '
        'txtFeatures
        '
        Me.txtFeatures.BackColor = System.Drawing.SystemColors.Window
        Me.txtFeatures.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtFeatures.Location = New System.Drawing.Point(84, 37)
        Me.txtFeatures.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFeatures.Multiline = True
        Me.txtFeatures.Name = "txtFeatures"
        Me.txtFeatures.ReadOnly = True
        Me.txtFeatures.Size = New System.Drawing.Size(363, 104)
        Me.txtFeatures.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(36, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 15)
        Me.Label1.TabIndex = 371
        Me.Label1.Text = "Details"
        '
        'txtUserAccount
        '
        Me.txtUserAccount.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtUserAccount.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txtUserAccount.FormattingEnabled = True
        Me.txtUserAccount.Location = New System.Drawing.Point(84, 12)
        Me.txtUserAccount.Name = "txtUserAccount"
        Me.txtUserAccount.Size = New System.Drawing.Size(208, 21)
        Me.txtUserAccount.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(14, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 15)
        Me.Label3.TabIndex = 377
        Me.Label3.Text = "Select User"
        '
        'frmAdminChangeUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(458, 185)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtUserAccount)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtFeatures)
        Me.Controls.Add(Me.cmdset)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmAdminChangeUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Change User Account (Admin Access)"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdset As System.Windows.Forms.Button
    Friend WithEvents txtFeatures As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtUserAccount As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
