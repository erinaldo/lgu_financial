<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChatboxBlasting
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.CheckedListBox1 = New DevExpress.XtraEditors.CheckedListBoxControl()
        Me.userid = New DevExpress.XtraEditors.TextEdit()
        Me.cmdUpdate = New DevExpress.XtraEditors.SimpleButton()
        Me.CheckEdit1 = New DevExpress.XtraEditors.CheckEdit()
        Me.txtContent = New DevExpress.XtraEditors.MemoEdit()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtUserAccount = New System.Windows.Forms.ComboBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        CType(Me.CheckedListBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.userid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtContent.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CheckedListBox1
        '
        Me.CheckedListBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CheckedListBox1.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckedListBox1.Appearance.Options.UseFont = True
        Me.CheckedListBox1.CheckOnClick = True
        Me.CheckedListBox1.HorizontalScrollbar = True
        Me.CheckedListBox1.HotTrackItems = True
        Me.CheckedListBox1.HotTrackSelectMode = DevExpress.XtraEditors.HotTrackSelectMode.SelectItemOnClick
        Me.CheckedListBox1.Location = New System.Drawing.Point(2, 0)
        Me.CheckedListBox1.Name = "CheckedListBox1"
        Me.CheckedListBox1.Size = New System.Drawing.Size(284, 371)
        Me.CheckedListBox1.TabIndex = 617
        '
        'userid
        '
        Me.userid.EnterMoveNextControl = True
        Me.userid.Location = New System.Drawing.Point(439, 111)
        Me.userid.Name = "userid"
        Me.userid.Properties.Appearance.Options.UseTextOptions = True
        Me.userid.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.userid.Size = New System.Drawing.Size(71, 20)
        Me.userid.TabIndex = 619
        Me.userid.Visible = False
        '
        'cmdUpdate
        '
        Me.cmdUpdate.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.cmdUpdate.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdUpdate.Appearance.BackColor2 = System.Drawing.Color.Khaki
        Me.cmdUpdate.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdUpdate.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.cmdUpdate.Appearance.Options.UseBackColor = True
        Me.cmdUpdate.Appearance.Options.UseFont = True
        Me.cmdUpdate.Location = New System.Drawing.Point(570, 376)
        Me.cmdUpdate.Name = "cmdUpdate"
        Me.cmdUpdate.Size = New System.Drawing.Size(181, 30)
        Me.cmdUpdate.TabIndex = 620
        Me.cmdUpdate.Text = "Confirm Blast Message"
        '
        'CheckEdit1
        '
        Me.CheckEdit1.Location = New System.Drawing.Point(2, 377)
        Me.CheckEdit1.Name = "CheckEdit1"
        Me.CheckEdit1.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckEdit1.Properties.Appearance.Options.UseFont = True
        Me.CheckEdit1.Properties.Caption = "Check All"
        Me.CheckEdit1.Size = New System.Drawing.Size(75, 19)
        Me.CheckEdit1.TabIndex = 621
        '
        'txtContent
        '
        Me.txtContent.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtContent.EditValue = ""
        Me.txtContent.EnterMoveNextControl = True
        Me.txtContent.Location = New System.Drawing.Point(290, 43)
        Me.txtContent.Margin = New System.Windows.Forms.Padding(0)
        Me.txtContent.Name = "txtContent"
        Me.txtContent.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.txtContent.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContent.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtContent.Properties.Appearance.Options.UseFont = True
        Me.txtContent.Properties.Appearance.Options.UseForeColor = True
        Me.txtContent.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.txtContent.Properties.NullValuePrompt = "Type in your message here and press enter to send"
        Me.txtContent.Properties.NullValuePromptShowForEmptyValue = True
        Me.txtContent.Properties.Padding = New System.Windows.Forms.Padding(1, 5, 5, 5)
        Me.txtContent.Properties.ValidateOnEnterKey = True
        Me.txtContent.Size = New System.Drawing.Size(461, 328)
        Me.txtContent.TabIndex = 622
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(295, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 15)
        Me.Label3.TabIndex = 624
        Me.Label3.Text = "Message From"
        '
        'txtUserAccount
        '
        Me.txtUserAccount.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtUserAccount.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txtUserAccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtUserAccount.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserAccount.FormattingEnabled = True
        Me.txtUserAccount.Location = New System.Drawing.Point(385, 12)
        Me.txtUserAccount.Name = "txtUserAccount"
        Me.txtUserAccount.Size = New System.Drawing.Size(273, 23)
        Me.txtUserAccount.TabIndex = 623
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(290, 379)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(274, 23)
        Me.ProgressBar1.TabIndex = 625
        '
        'frmChatboxBlasting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(760, 414)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtUserAccount)
        Me.Controls.Add(Me.CheckEdit1)
        Me.Controls.Add(Me.cmdUpdate)
        Me.Controls.Add(Me.userid)
        Me.Controls.Add(Me.CheckedListBox1)
        Me.Controls.Add(Me.txtContent)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmChatboxBlasting"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Message Blasting"
        CType(Me.CheckedListBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.userid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtContent.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CheckedListBox1 As DevExpress.XtraEditors.CheckedListBoxControl
    Friend WithEvents userid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmdUpdate As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents CheckEdit1 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtContent As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtUserAccount As System.Windows.Forms.ComboBox
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
End Class
