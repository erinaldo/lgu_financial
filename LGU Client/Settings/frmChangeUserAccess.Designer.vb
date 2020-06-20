<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmChangeUserAccess
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmChangeUserAccess))
        Me.cmdset = New System.Windows.Forms.Button()
        Me.txtPermission = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmdset
        '
        Me.cmdset.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdset.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdset.Location = New System.Drawing.Point(196, 43)
        Me.cmdset.Name = "cmdset"
        Me.cmdset.Size = New System.Drawing.Size(118, 30)
        Me.cmdset.TabIndex = 5
        Me.cmdset.Text = "Confirm Change"
        Me.cmdset.UseVisualStyleBackColor = True
        '
        'txtPermission
        '
        Me.txtPermission.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtPermission.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txtPermission.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtPermission.FormattingEnabled = True
        Me.txtPermission.Location = New System.Drawing.Point(106, 18)
        Me.txtPermission.Name = "txtPermission"
        Me.txtPermission.Size = New System.Drawing.Size(208, 21)
        Me.txtPermission.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(23, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 15)
        Me.Label3.TabIndex = 377
        Me.Label3.Text = "Select Access"
        '
        'frmChangeUserAccess
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(338, 87)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtPermission)
        Me.Controls.Add(Me.cmdset)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmChangeUserAccess"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Change User Access"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdset As System.Windows.Forms.Button
    Friend WithEvents txtPermission As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
