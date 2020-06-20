<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLXPrinterSettings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLXPrinterSettings))
        Me.cmdPrintLayout = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.cmdSaveSettings = New System.Windows.Forms.Button()
        Me.txtFontSize = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtFontName = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtSMarginLeft = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtSPaperWidth = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.ckEnableLxPrinter = New System.Windows.Forms.CheckBox()
        Me.txtPrinterName = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtSMarginTop = New System.Windows.Forms.TextBox()
        Me.ckTemporaryDisablePrinting = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'cmdPrintLayout
        '
        Me.cmdPrintLayout.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.cmdPrintLayout.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdPrintLayout.Location = New System.Drawing.Point(53, 264)
        Me.cmdPrintLayout.Name = "cmdPrintLayout"
        Me.cmdPrintLayout.Size = New System.Drawing.Size(126, 32)
        Me.cmdPrintLayout.TabIndex = 417
        Me.cmdPrintLayout.Text = "Print Layout"
        Me.cmdPrintLayout.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.Button2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button2.Location = New System.Drawing.Point(182, 264)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(117, 32)
        Me.Button2.TabIndex = 423
        Me.Button2.Text = "Print Test"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'cmdSaveSettings
        '
        Me.cmdSaveSettings.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.cmdSaveSettings.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdSaveSettings.Location = New System.Drawing.Point(302, 264)
        Me.cmdSaveSettings.Name = "cmdSaveSettings"
        Me.cmdSaveSettings.Size = New System.Drawing.Size(129, 32)
        Me.cmdSaveSettings.TabIndex = 422
        Me.cmdSaveSettings.Text = "Save Settings"
        Me.cmdSaveSettings.UseVisualStyleBackColor = True
        '
        'txtFontSize
        '
        Me.txtFontSize.Enabled = False
        Me.txtFontSize.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtFontSize.ForeColor = System.Drawing.Color.Black
        Me.txtFontSize.Location = New System.Drawing.Point(173, 192)
        Me.txtFontSize.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.txtFontSize.Name = "txtFontSize"
        Me.txtFontSize.Size = New System.Drawing.Size(95, 25)
        Me.txtFontSize.TabIndex = 420
        Me.txtFontSize.Text = "9"
        Me.txtFontSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label11.Location = New System.Drawing.Point(101, 197)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(60, 17)
        Me.Label11.TabIndex = 421
        Me.Label11.Text = "Font Size"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label10.Location = New System.Drawing.Point(87, 164)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 17)
        Me.Label10.TabIndex = 419
        Me.Label10.Text = "Font Name"
        '
        'txtFontName
        '
        Me.txtFontName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtFontName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txtFontName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtFontName.Enabled = False
        Me.txtFontName.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtFontName.ForeColor = System.Drawing.Color.Black
        Me.txtFontName.FormattingEnabled = True
        Me.txtFontName.ItemHeight = 17
        Me.txtFontName.Location = New System.Drawing.Point(173, 162)
        Me.txtFontName.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.txtFontName.Name = "txtFontName"
        Me.txtFontName.Size = New System.Drawing.Size(261, 25)
        Me.txtFontName.TabIndex = 418
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.DimGray
        Me.Label16.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label16.Location = New System.Drawing.Point(276, 111)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(84, 13)
        Me.Label16.TabIndex = 408
        Me.Label16.Text = "Default 2 spaces"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.DimGray
        Me.Label17.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label17.Location = New System.Drawing.Point(276, 84)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(122, 13)
        Me.Label17.TabIndex = 407
        Me.Label17.Text = "Default 50 standard size"
        '
        'txtSMarginLeft
        '
        Me.txtSMarginLeft.Enabled = False
        Me.txtSMarginLeft.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtSMarginLeft.ForeColor = System.Drawing.Color.Black
        Me.txtSMarginLeft.Location = New System.Drawing.Point(173, 133)
        Me.txtSMarginLeft.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.txtSMarginLeft.Name = "txtSMarginLeft"
        Me.txtSMarginLeft.Size = New System.Drawing.Size(95, 25)
        Me.txtSMarginLeft.TabIndex = 405
        Me.txtSMarginLeft.Text = "2"
        Me.txtSMarginLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label18.Location = New System.Drawing.Point(85, 136)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(75, 17)
        Me.Label18.TabIndex = 406
        Me.Label18.Text = "Margin Left"
        '
        'txtSPaperWidth
        '
        Me.txtSPaperWidth.Enabled = False
        Me.txtSPaperWidth.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtSPaperWidth.ForeColor = System.Drawing.Color.Black
        Me.txtSPaperWidth.Location = New System.Drawing.Point(173, 77)
        Me.txtSPaperWidth.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.txtSPaperWidth.Name = "txtSPaperWidth"
        Me.txtSPaperWidth.Size = New System.Drawing.Size(95, 25)
        Me.txtSPaperWidth.TabIndex = 403
        Me.txtSPaperWidth.Text = "50"
        Me.txtSPaperWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label19.Location = New System.Drawing.Point(36, 80)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(120, 17)
        Me.Label19.TabIndex = 404
        Me.Label19.Text = "Paper width Length"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label20.Location = New System.Drawing.Point(71, 54)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(88, 17)
        Me.Label20.TabIndex = 402
        Me.Label20.Text = "Printer Device"
        '
        'ckEnableLxPrinter
        '
        Me.ckEnableLxPrinter.AutoSize = True
        Me.ckEnableLxPrinter.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.ckEnableLxPrinter.ForeColor = System.Drawing.Color.Black
        Me.ckEnableLxPrinter.Location = New System.Drawing.Point(173, 27)
        Me.ckEnableLxPrinter.Name = "ckEnableLxPrinter"
        Me.ckEnableLxPrinter.Size = New System.Drawing.Size(126, 21)
        Me.ckEnableLxPrinter.TabIndex = 401
        Me.ckEnableLxPrinter.Text = "Enable LX Printer"
        Me.ckEnableLxPrinter.UseVisualStyleBackColor = True
        '
        'txtPrinterName
        '
        Me.txtPrinterName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtPrinterName.Enabled = False
        Me.txtPrinterName.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtPrinterName.ForeColor = System.Drawing.Color.Black
        Me.txtPrinterName.FormattingEnabled = True
        Me.txtPrinterName.ItemHeight = 17
        Me.txtPrinterName.Location = New System.Drawing.Point(173, 49)
        Me.txtPrinterName.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.txtPrinterName.Name = "txtPrinterName"
        Me.txtPrinterName.Size = New System.Drawing.Size(261, 25)
        Me.txtPrinterName.TabIndex = 400
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.DimGray
        Me.Label13.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label13.Location = New System.Drawing.Point(278, 137)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(84, 13)
        Me.Label13.TabIndex = 414
        Me.Label13.Text = "Default 2 spaces"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label14.Location = New System.Drawing.Point(85, 108)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(76, 17)
        Me.Label14.TabIndex = 413
        Me.Label14.Text = "Margin Top"
        '
        'txtSMarginTop
        '
        Me.txtSMarginTop.Enabled = False
        Me.txtSMarginTop.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtSMarginTop.ForeColor = System.Drawing.Color.Black
        Me.txtSMarginTop.Location = New System.Drawing.Point(173, 105)
        Me.txtSMarginTop.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.txtSMarginTop.Name = "txtSMarginTop"
        Me.txtSMarginTop.Size = New System.Drawing.Size(95, 25)
        Me.txtSMarginTop.TabIndex = 412
        Me.txtSMarginTop.Text = "2"
        Me.txtSMarginTop.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ckTemporaryDisablePrinting
        '
        Me.ckTemporaryDisablePrinting.AutoSize = True
        Me.ckTemporaryDisablePrinting.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.ckTemporaryDisablePrinting.ForeColor = System.Drawing.Color.Black
        Me.ckTemporaryDisablePrinting.Location = New System.Drawing.Point(173, 223)
        Me.ckTemporaryDisablePrinting.Name = "ckTemporaryDisablePrinting"
        Me.ckTemporaryDisablePrinting.Size = New System.Drawing.Size(185, 21)
        Me.ckTemporaryDisablePrinting.TabIndex = 424
        Me.ckTemporaryDisablePrinting.Text = "Temporary Disable Printing"
        Me.ckTemporaryDisablePrinting.UseVisualStyleBackColor = True
        '
        'frmLXPrinterSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(504, 319)
        Me.Controls.Add(Me.ckTemporaryDisablePrinting)
        Me.Controls.Add(Me.cmdPrintLayout)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.ckEnableLxPrinter)
        Me.Controls.Add(Me.cmdSaveSettings)
        Me.Controls.Add(Me.txtPrinterName)
        Me.Controls.Add(Me.txtFontSize)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtSPaperWidth)
        Me.Controls.Add(Me.txtFontName)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtSMarginLeft)
        Me.Controls.Add(Me.txtSMarginTop)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label16)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmLXPrinterSettings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "LX Printer Settings"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtFontSize As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtFontName As System.Windows.Forms.ComboBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtSMarginLeft As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtSPaperWidth As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents ckEnableLxPrinter As System.Windows.Forms.CheckBox
    Friend WithEvents txtPrinterName As System.Windows.Forms.ComboBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents cmdSaveSettings As System.Windows.Forms.Button
    Friend WithEvents cmdPrintLayout As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtSMarginTop As System.Windows.Forms.TextBox
    Friend WithEvents ckTemporaryDisablePrinting As System.Windows.Forms.CheckBox
End Class
