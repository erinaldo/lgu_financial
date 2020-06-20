<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Me.components = New System.ComponentModel.Container()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.cmdlogin = New System.Windows.Forms.Button()
        Me.txtusername = New System.Windows.Forms.TextBox()
        Me.maindescription = New System.Windows.Forms.Label()
        Me.mainname = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.loadimage = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.txtversion = New System.Windows.Forms.TextBox()
        Me.txtDownloadLocation = New System.Windows.Forms.TextBox()
        Me.txtUpdateUrl = New System.Windows.Forms.TextBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        CType(Me.loadimage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtpassword
        '
        Me.txtpassword.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtpassword.Font = New System.Drawing.Font("Wingdings", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.txtpassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtpassword.Location = New System.Drawing.Point(26, 260)
        Me.txtpassword.Margin = New System.Windows.Forms.Padding(4)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(108)
        Me.txtpassword.Size = New System.Drawing.Size(187, 20)
        Me.txtpassword.TabIndex = 1
        Me.txtpassword.Text = "Password"
        Me.txtpassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmdlogin
        '
        Me.cmdlogin.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cmdlogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmdlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdlogin.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdlogin.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdlogin.Location = New System.Drawing.Point(63, 284)
        Me.cmdlogin.Name = "cmdlogin"
        Me.cmdlogin.Size = New System.Drawing.Size(105, 27)
        Me.cmdlogin.TabIndex = 2
        Me.cmdlogin.Text = "Confirm Login"
        Me.cmdlogin.UseCompatibleTextRendering = True
        Me.cmdlogin.UseVisualStyleBackColor = True
        '
        'txtusername
        '
        Me.txtusername.AcceptsReturn = True
        Me.txtusername.AcceptsTab = True
        Me.txtusername.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtusername.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtusername.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtusername.Location = New System.Drawing.Point(26, 233)
        Me.txtusername.Margin = New System.Windows.Forms.Padding(4)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(187, 22)
        Me.txtusername.TabIndex = 0
        Me.txtusername.Text = "Username"
        Me.txtusername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'maindescription
        '
        Me.maindescription.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.maindescription.BackColor = System.Drawing.Color.Transparent
        Me.maindescription.Font = New System.Drawing.Font("Segoe UI", 7.5!)
        Me.maindescription.ForeColor = System.Drawing.Color.Gray
        Me.maindescription.Location = New System.Drawing.Point(12, 617)
        Me.maindescription.Name = "maindescription"
        Me.maindescription.Size = New System.Drawing.Size(207, 12)
        Me.maindescription.TabIndex = 346
        Me.maindescription.Text = "Developed by Winter Bugahod"
        Me.maindescription.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'mainname
        '
        Me.mainname.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mainname.BackColor = System.Drawing.Color.Transparent
        Me.mainname.Cursor = System.Windows.Forms.Cursors.Default
        Me.mainname.Font = New System.Drawing.Font("Segoe UI Semibold", 8.0!, System.Drawing.FontStyle.Bold)
        Me.mainname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.mainname.Location = New System.Drawing.Point(12, 604)
        Me.mainname.Name = "mainname"
        Me.mainname.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.mainname.Size = New System.Drawing.Size(207, 12)
        Me.mainname.TabIndex = 345
        Me.mainname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LinkLabel1
        '
        Me.LinkLabel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LinkLabel1.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel1.Font = New System.Drawing.Font("Segoe UI", 7.0!)
        Me.LinkLabel1.LinkColor = System.Drawing.Color.Red
        Me.LinkLabel1.Location = New System.Drawing.Point(-2, 629)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(240, 14)
        Me.LinkLabel1.TabIndex = 354
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "www.coffeecupsoft.com"
        Me.LinkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'loadimage
        '
        Me.loadimage.BackColor = System.Drawing.Color.Transparent
        Me.loadimage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.loadimage.Location = New System.Drawing.Point(203, 349)
        Me.loadimage.Name = "loadimage"
        Me.loadimage.Size = New System.Drawing.Size(0, 0)
        Me.loadimage.TabIndex = 348
        Me.loadimage.TabStop = False
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 7.5!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(17, 216)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(207, 12)
        Me.Label1.TabIndex = 355
        Me.Label1.Text = "Enter Login Credential"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Timer1
        '
        Me.Timer1.Interval = 3000
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerReportsProgress = True
        Me.BackgroundWorker1.WorkerSupportsCancellation = True
        '
        'txtversion
        '
        Me.txtversion.Location = New System.Drawing.Point(257, 23)
        Me.txtversion.Name = "txtversion"
        Me.txtversion.Size = New System.Drawing.Size(66, 20)
        Me.txtversion.TabIndex = 358
        Me.txtversion.Visible = False
        '
        'txtDownloadLocation
        '
        Me.txtDownloadLocation.Location = New System.Drawing.Point(257, 81)
        Me.txtDownloadLocation.Name = "txtDownloadLocation"
        Me.txtDownloadLocation.Size = New System.Drawing.Size(66, 20)
        Me.txtDownloadLocation.TabIndex = 357
        Me.txtDownloadLocation.Visible = False
        '
        'txtUpdateUrl
        '
        Me.txtUpdateUrl.Location = New System.Drawing.Point(257, 52)
        Me.txtUpdateUrl.Name = "txtUpdateUrl"
        Me.txtUpdateUrl.Size = New System.Drawing.Size(66, 20)
        Me.txtUpdateUrl.TabIndex = 356
        Me.txtUpdateUrl.Visible = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(55, 203)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(130, 10)
        Me.ProgressBar1.TabIndex = 359
        Me.ProgressBar1.Visible = False
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackgroundImage = Global.LGUClient.My.Resources.Resources.loginbg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(233, 656)
        Me.Controls.Add(Me.txtusername)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.txtversion)
        Me.Controls.Add(Me.txtDownloadLocation)
        Me.Controls.Add(Me.txtUpdateUrl)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.loadimage)
        Me.Controls.Add(Me.maindescription)
        Me.Controls.Add(Me.mainname)
        Me.Controls.Add(Me.cmdlogin)
        Me.Controls.Add(Me.txtpassword)
        Me.MaximizeBox = False
        Me.Name = "frmLogin"
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Coffeecup"
        CType(Me.loadimage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtpassword As System.Windows.Forms.TextBox
    Friend WithEvents cmdlogin As System.Windows.Forms.Button
    Friend WithEvents txtusername As System.Windows.Forms.TextBox
    Friend WithEvents maindescription As System.Windows.Forms.Label
    Friend WithEvents mainname As System.Windows.Forms.Label
    Friend WithEvents loadimage As System.Windows.Forms.PictureBox
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents txtversion As System.Windows.Forms.TextBox
    Friend WithEvents txtDownloadLocation As System.Windows.Forms.TextBox
    Friend WithEvents txtUpdateUrl As System.Windows.Forms.TextBox
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar

End Class
