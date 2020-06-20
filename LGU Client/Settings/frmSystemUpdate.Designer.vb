<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSystemUpdate
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSystemUpdate))
        Me.cmdset = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtVersion = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtDetails = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtUrl = New System.Windows.Forms.TextBox()
        Me.txtFeatures = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RadioGroup1 = New DevExpress.XtraEditors.RadioGroup()
        Me.txtFileName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.RadioGroup1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdset
        '
        Me.cmdset.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdset.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdset.Location = New System.Drawing.Point(184, 314)
        Me.cmdset.Name = "cmdset"
        Me.cmdset.Size = New System.Drawing.Size(163, 30)
        Me.cmdset.TabIndex = 4
        Me.cmdset.Text = "Confirm"
        Me.cmdset.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(98, 267)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 15)
        Me.Label4.TabIndex = 366
        Me.Label4.Text = "Download Url"
        '
        'txtVersion
        '
        Me.txtVersion.BackColor = System.Drawing.SystemColors.Window
        Me.txtVersion.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtVersion.Location = New System.Drawing.Point(184, 132)
        Me.txtVersion.Margin = New System.Windows.Forms.Padding(4)
        Me.txtVersion.Name = "txtVersion"
        Me.txtVersion.Size = New System.Drawing.Size(137, 22)
        Me.txtVersion.TabIndex = 0
        Me.txtVersion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(132, 136)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 15)
        Me.Label5.TabIndex = 364
        Me.Label5.Text = "Version"
        '
        'txtDetails
        '
        Me.txtDetails.BackColor = System.Drawing.SystemColors.Window
        Me.txtDetails.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtDetails.Location = New System.Drawing.Point(184, 157)
        Me.txtDetails.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDetails.Name = "txtDetails"
        Me.txtDetails.ReadOnly = True
        Me.txtDetails.Size = New System.Drawing.Size(192, 22)
        Me.txtDetails.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label7.Location = New System.Drawing.Point(135, 159)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 15)
        Me.Label7.TabIndex = 368
        Me.Label7.Text = "Details"
        '
        'txtUrl
        '
        Me.txtUrl.BackColor = System.Drawing.SystemColors.Window
        Me.txtUrl.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtUrl.Location = New System.Drawing.Point(184, 263)
        Me.txtUrl.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUrl.Name = "txtUrl"
        Me.txtUrl.ReadOnly = True
        Me.txtUrl.Size = New System.Drawing.Size(347, 22)
        Me.txtUrl.TabIndex = 3
        Me.txtUrl.Text = "http://"
        '
        'txtFeatures
        '
        Me.txtFeatures.BackColor = System.Drawing.SystemColors.Window
        Me.txtFeatures.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtFeatures.Location = New System.Drawing.Point(184, 182)
        Me.txtFeatures.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFeatures.Multiline = True
        Me.txtFeatures.Name = "txtFeatures"
        Me.txtFeatures.Size = New System.Drawing.Size(347, 78)
        Me.txtFeatures.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(126, 183)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 15)
        Me.Label1.TabIndex = 371
        Me.Label1.Text = "Features"
        '
        'RadioGroup1
        '
        Me.RadioGroup1.EditValue = "Coffeecup Server"
        Me.RadioGroup1.Location = New System.Drawing.Point(184, 29)
        Me.RadioGroup1.Name = "RadioGroup1"
        Me.RadioGroup1.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.RadioGroup1.Properties.Appearance.Options.UseFont = True
        Me.RadioGroup1.Properties.ColumnIndent = 1
        Me.RadioGroup1.Properties.Columns = 1
        Me.RadioGroup1.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem("Coffeecup Server", "Coffeecup Server"), New DevExpress.XtraEditors.Controls.RadioGroupItem("Coffeecup Client", "Coffeecup Client"), New DevExpress.XtraEditors.Controls.RadioGroupItem("Attendance Console", "Attendance Console"), New DevExpress.XtraEditors.Controls.RadioGroupItem("Digital Dashboard", "Digital Dashboard")})
        Me.RadioGroup1.Size = New System.Drawing.Size(192, 99)
        Me.RadioGroup1.TabIndex = 378
        '
        'txtFileName
        '
        Me.txtFileName.BackColor = System.Drawing.SystemColors.Window
        Me.txtFileName.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtFileName.Location = New System.Drawing.Point(184, 288)
        Me.txtFileName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFileName.Name = "txtFileName"
        Me.txtFileName.Size = New System.Drawing.Size(192, 22)
        Me.txtFileName.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(117, 290)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 15)
        Me.Label2.TabIndex = 380
        Me.Label2.Text = "File Name"
        '
        'frmSystemUpdate
        '
        Me.AcceptButton = Me.cmdset
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(618, 376)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtFileName)
        Me.Controls.Add(Me.RadioGroup1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtFeatures)
        Me.Controls.Add(Me.txtUrl)
        Me.Controls.Add(Me.txtDetails)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtVersion)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmdset)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmSystemUpdate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "New System Version Updater"
        CType(Me.RadioGroup1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdset As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtVersion As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtDetails As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtUrl As System.Windows.Forms.TextBox
    Friend WithEvents txtFeatures As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents RadioGroup1 As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents txtFileName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
