<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmChatPicturePreview
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
        Me.Profileimg = New DevExpress.XtraEditors.PictureEdit()
        CType(Me.Profileimg.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Profileimg
        '
        Me.Profileimg.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Profileimg.Location = New System.Drawing.Point(0, 0)
        Me.Profileimg.Name = "Profileimg"
        Me.Profileimg.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.Profileimg.Properties.Appearance.Options.UseBackColor = True
        Me.Profileimg.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.Profileimg.Properties.ShowMenu = False
        Me.Profileimg.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
        Me.Profileimg.Size = New System.Drawing.Size(311, 343)
        Me.Profileimg.TabIndex = 363
        '
        'frmChatPicturePreview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(311, 343)
        Me.Controls.Add(Me.Profileimg)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmChatPicturePreview"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TopMost = True
        CType(Me.Profileimg.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Profileimg As DevExpress.XtraEditors.PictureEdit
End Class
