<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChatBoxMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmChatBoxMain))
        Me.cms_em = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ReportHistoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdLocalData = New System.Windows.Forms.ToolStripMenuItem()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.txtContent = New DevExpress.XtraEditors.MemoEdit()
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.CheckEdit1 = New DevExpress.XtraEditors.CheckEdit()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.txtWelcome = New DevExpress.XtraEditors.LabelControl()
        Me.txtNickname = New DevExpress.XtraEditors.TextEdit()
        Me.Profileimg = New DevExpress.XtraEditors.PictureEdit()
        Me.txtfullname = New System.Windows.Forms.Label()
        Me.txtOffice = New System.Windows.Forms.Label()
        Me.txtPosition = New System.Windows.Forms.Label()
        Me.txtStatus = New System.Windows.Forms.Label()
        Me.txtContactNumber = New System.Windows.Forms.Label()
        Me.txtEmailAddress = New System.Windows.Forms.LinkLabel()
        Me.ImageMenu = New System.Windows.Forms.ImageList(Me.components)
        Me.SplitContainerControl2 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.txtSearchUser = New DevExpress.XtraEditors.TextEdit()
        Me.ListControl1 = New LGUClient.ListControl()
        Me.imgstatus = New System.Windows.Forms.PictureBox()
        Me.txtAccountid = New DevExpress.XtraEditors.TextEdit()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.tmrReceivedMessage = New System.Windows.Forms.Timer(Me.components)
        Me.tmrWatchTyping = New System.Windows.Forms.Timer(Me.components)
        Me.tmrReadTyping = New System.Windows.Forms.Timer(Me.components)
        Me.tmrRefreshList = New System.Windows.Forms.Timer(Me.components)
        Me.tmrSeen = New System.Windows.Forms.Timer(Me.components)
        Me.cms_em.SuspendLayout()
        CType(Me.txtContent.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNickname.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Profileimg.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainerControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl2.SuspendLayout()
        CType(Me.txtSearchUser.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgstatus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAccountid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cms_em
        '
        Me.cms_em.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReportHistoryToolStripMenuItem, Me.ToolStripSeparator4, Me.cmdLocalData})
        Me.cms_em.Name = "ContextMenuStrip1"
        Me.cms_em.Size = New System.Drawing.Size(169, 54)
        '
        'ReportHistoryToolStripMenuItem
        '
        Me.ReportHistoryToolStripMenuItem.Image = Global.LGUClient.My.Resources.Resources.notebook_sticky_note
        Me.ReportHistoryToolStripMenuItem.Name = "ReportHistoryToolStripMenuItem"
        Me.ReportHistoryToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.ReportHistoryToolStripMenuItem.Text = "View Chat History"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(165, 6)
        '
        'cmdLocalData
        '
        Me.cmdLocalData.Image = Global.LGUClient.My.Resources.Resources.arrow_continue_090
        Me.cmdLocalData.Name = "cmdLocalData"
        Me.cmdLocalData.Size = New System.Drawing.Size(168, 22)
        Me.cmdLocalData.Tag = "1"
        Me.cmdLocalData.Text = "Refresh Data"
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebBrowser1.Location = New System.Drawing.Point(0, 0)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(456, 416)
        Me.WebBrowser1.TabIndex = 4
        '
        'txtContent
        '
        Me.txtContent.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtContent.EditValue = ""
        Me.txtContent.EnterMoveNextControl = True
        Me.txtContent.Location = New System.Drawing.Point(5, 3)
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
        Me.txtContent.Size = New System.Drawing.Size(436, 51)
        Me.txtContent.TabIndex = 1
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainerControl1.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.Panel2
        Me.SplitContainerControl1.Horizontal = False
        Me.SplitContainerControl1.Location = New System.Drawing.Point(7, 112)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.WebBrowser1)
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.txtContent)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(456, 482)
        Me.SplitContainerControl1.SplitterPosition = 61
        Me.SplitContainerControl1.TabIndex = 6
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'CheckEdit1
        '
        Me.CheckEdit1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckEdit1.Location = New System.Drawing.Point(340, 85)
        Me.CheckEdit1.Name = "CheckEdit1"
        Me.CheckEdit1.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckEdit1.Properties.Appearance.Options.UseFont = True
        Me.CheckEdit1.Properties.Appearance.Options.UseTextOptions = True
        Me.CheckEdit1.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.CheckEdit1.Properties.Caption = "Show Chat Details"
        Me.CheckEdit1.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.CheckEdit1.Size = New System.Drawing.Size(114, 19)
        Me.CheckEdit1.TabIndex = 374
        '
        'PanelControl1
        '
        Me.PanelControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelControl1.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.PanelControl1.Appearance.Options.UseBackColor = True
        Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl1.Controls.Add(Me.PictureBox3)
        Me.PanelControl1.Controls.Add(Me.txtWelcome)
        Me.PanelControl1.Controls.Add(Me.txtNickname)
        Me.PanelControl1.Location = New System.Drawing.Point(6, 5)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(457, 589)
        Me.PanelControl1.TabIndex = 375
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.LGUClient.My.Resources.Resources.Redo_32x32__2____Copy
        Me.PictureBox3.Location = New System.Drawing.Point(1, 6)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(39, 37)
        Me.PictureBox3.TabIndex = 367
        Me.PictureBox3.TabStop = False
        '
        'txtWelcome
        '
        Me.txtWelcome.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtWelcome.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.75!)
        Me.txtWelcome.Appearance.Options.UseFont = True
        Me.txtWelcome.Appearance.Options.UseTextOptions = True
        Me.txtWelcome.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.txtWelcome.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.txtWelcome.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.txtWelcome.Location = New System.Drawing.Point(46, 7)
        Me.txtWelcome.Name = "txtWelcome"
        Me.txtWelcome.Size = New System.Drawing.Size(384, 170)
        Me.txtWelcome.TabIndex = 0
        '
        'txtNickname
        '
        Me.txtNickname.Location = New System.Drawing.Point(344, 47)
        Me.txtNickname.Name = "txtNickname"
        Me.txtNickname.Size = New System.Drawing.Size(44, 20)
        Me.txtNickname.TabIndex = 373
        Me.txtNickname.Visible = False
        '
        'Profileimg
        '
        Me.Profileimg.Location = New System.Drawing.Point(7, 9)
        Me.Profileimg.Name = "Profileimg"
        Me.Profileimg.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.Profileimg.Properties.Appearance.Options.UseBackColor = True
        Me.Profileimg.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.Profileimg.Properties.ShowMenu = False
        Me.Profileimg.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
        Me.Profileimg.Size = New System.Drawing.Size(92, 94)
        Me.Profileimg.TabIndex = 362
        '
        'txtfullname
        '
        Me.txtfullname.AutoSize = True
        Me.txtfullname.BackColor = System.Drawing.Color.Transparent
        Me.txtfullname.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtfullname.ForeColor = System.Drawing.Color.Black
        Me.txtfullname.Location = New System.Drawing.Point(104, 12)
        Me.txtfullname.Name = "txtfullname"
        Me.txtfullname.Size = New System.Drawing.Size(144, 21)
        Me.txtfullname.TabIndex = 359
        Me.txtfullname.Text = "System Generated"
        Me.txtfullname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtOffice
        '
        Me.txtOffice.AutoSize = True
        Me.txtOffice.BackColor = System.Drawing.Color.Transparent
        Me.txtOffice.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtOffice.ForeColor = System.Drawing.Color.Black
        Me.txtOffice.Location = New System.Drawing.Point(104, 49)
        Me.txtOffice.Name = "txtOffice"
        Me.txtOffice.Size = New System.Drawing.Size(102, 15)
        Me.txtOffice.TabIndex = 361
        Me.txtOffice.Text = "System Generated"
        Me.txtOffice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtPosition
        '
        Me.txtPosition.AutoSize = True
        Me.txtPosition.BackColor = System.Drawing.Color.Transparent
        Me.txtPosition.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtPosition.ForeColor = System.Drawing.Color.Black
        Me.txtPosition.Location = New System.Drawing.Point(104, 33)
        Me.txtPosition.Name = "txtPosition"
        Me.txtPosition.Size = New System.Drawing.Size(102, 15)
        Me.txtPosition.TabIndex = 360
        Me.txtPosition.Text = "System Generated"
        '
        'txtStatus
        '
        Me.txtStatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtStatus.AutoSize = True
        Me.txtStatus.BackColor = System.Drawing.Color.Transparent
        Me.txtStatus.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtStatus.ForeColor = System.Drawing.Color.Green
        Me.txtStatus.Location = New System.Drawing.Point(404, 10)
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.Size = New System.Drawing.Size(49, 19)
        Me.txtStatus.TabIndex = 363
        Me.txtStatus.Text = "Online"
        Me.txtStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtContactNumber
        '
        Me.txtContactNumber.AutoSize = True
        Me.txtContactNumber.BackColor = System.Drawing.Color.Transparent
        Me.txtContactNumber.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.txtContactNumber.ForeColor = System.Drawing.Color.Black
        Me.txtContactNumber.Location = New System.Drawing.Point(126, 83)
        Me.txtContactNumber.Name = "txtContactNumber"
        Me.txtContactNumber.Size = New System.Drawing.Size(99, 13)
        Me.txtContactNumber.TabIndex = 367
        Me.txtContactNumber.Text = "System Generated"
        Me.txtContactNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtEmailAddress
        '
        Me.txtEmailAddress.AutoSize = True
        Me.txtEmailAddress.Location = New System.Drawing.Point(126, 65)
        Me.txtEmailAddress.Name = "txtEmailAddress"
        Me.txtEmailAddress.Size = New System.Drawing.Size(96, 13)
        Me.txtEmailAddress.TabIndex = 368
        Me.txtEmailAddress.TabStop = True
        Me.txtEmailAddress.Text = "System Generated"
        '
        'ImageMenu
        '
        Me.ImageMenu.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageMenu.ImageSize = New System.Drawing.Size(100, 100)
        Me.ImageMenu.TransparentColor = System.Drawing.Color.Transparent
        '
        'SplitContainerControl2
        '
        Me.SplitContainerControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerControl2.Name = "SplitContainerControl2"
        Me.SplitContainerControl2.Panel1.Controls.Add(Me.txtSearchUser)
        Me.SplitContainerControl2.Panel1.Controls.Add(Me.ListControl1)
        Me.SplitContainerControl2.Panel1.Padding = New System.Windows.Forms.Padding(5)
        Me.SplitContainerControl2.Panel1.Text = "Panel1"
        Me.SplitContainerControl2.Panel2.Controls.Add(Me.CheckEdit1)
        Me.SplitContainerControl2.Panel2.Controls.Add(Me.imgstatus)
        Me.SplitContainerControl2.Panel2.Controls.Add(Me.txtAccountid)
        Me.SplitContainerControl2.Panel2.Controls.Add(Me.Profileimg)
        Me.SplitContainerControl2.Panel2.Controls.Add(Me.txtfullname)
        Me.SplitContainerControl2.Panel2.Controls.Add(Me.txtEmailAddress)
        Me.SplitContainerControl2.Panel2.Controls.Add(Me.txtOffice)
        Me.SplitContainerControl2.Panel2.Controls.Add(Me.txtContactNumber)
        Me.SplitContainerControl2.Panel2.Controls.Add(Me.SplitContainerControl1)
        Me.SplitContainerControl2.Panel2.Controls.Add(Me.PictureBox2)
        Me.SplitContainerControl2.Panel2.Controls.Add(Me.txtPosition)
        Me.SplitContainerControl2.Panel2.Controls.Add(Me.PictureBox1)
        Me.SplitContainerControl2.Panel2.Controls.Add(Me.txtStatus)
        Me.SplitContainerControl2.Panel2.Controls.Add(Me.PanelControl1)
        Me.SplitContainerControl2.Panel2.Padding = New System.Windows.Forms.Padding(5)
        Me.SplitContainerControl2.Panel2.Text = "Panel2"
        Me.SplitContainerControl2.Size = New System.Drawing.Size(746, 603)
        Me.SplitContainerControl2.SplitterPosition = 272
        Me.SplitContainerControl2.TabIndex = 0
        Me.SplitContainerControl2.Text = "SplitContainerControl2"
        '
        'txtSearchUser
        '
        Me.txtSearchUser.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSearchUser.Location = New System.Drawing.Point(5, 8)
        Me.txtSearchUser.Name = "txtSearchUser"
        Me.txtSearchUser.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchUser.Properties.Appearance.Options.UseFont = True
        Me.txtSearchUser.Properties.NullValuePrompt = "Search coffeecup user here.."
        Me.txtSearchUser.Properties.NullValuePromptShowForEmptyValue = True
        Me.txtSearchUser.Size = New System.Drawing.Size(262, 24)
        Me.txtSearchUser.TabIndex = 369
        '
        'ListControl1
        '
        Me.ListControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListControl1.BackColor = System.Drawing.SystemColors.Control
        Me.ListControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListControl1.ContextMenuStrip = Me.cms_em
        Me.ListControl1.Location = New System.Drawing.Point(5, 35)
        Me.ListControl1.Margin = New System.Windows.Forms.Padding(0)
        Me.ListControl1.Name = "ListControl1"
        Me.ListControl1.Size = New System.Drawing.Size(262, 559)
        Me.ListControl1.TabIndex = 0
        '
        'imgstatus
        '
        Me.imgstatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.imgstatus.Image = Global.LGUClient.My.Resources.Resources.status_online
        Me.imgstatus.Location = New System.Drawing.Point(387, 12)
        Me.imgstatus.Name = "imgstatus"
        Me.imgstatus.Size = New System.Drawing.Size(17, 18)
        Me.imgstatus.TabIndex = 370
        Me.imgstatus.TabStop = False
        '
        'txtAccountid
        '
        Me.txtAccountid.Location = New System.Drawing.Point(469, 42)
        Me.txtAccountid.Name = "txtAccountid"
        Me.txtAccountid.Size = New System.Drawing.Size(44, 20)
        Me.txtAccountid.TabIndex = 369
        Me.txtAccountid.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.LGUClient.My.Resources.Resources.mobile_phone_off
        Me.PictureBox2.Location = New System.Drawing.Point(107, 81)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(17, 18)
        Me.PictureBox2.TabIndex = 366
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.LGUClient.My.Resources.Resources.mail
        Me.PictureBox1.Location = New System.Drawing.Point(107, 65)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(17, 18)
        Me.PictureBox1.TabIndex = 364
        Me.PictureBox1.TabStop = False
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "Blow")
        Me.ImageList1.Images.SetKeyName(1, "BornThisWay")
        Me.ImageList1.Images.SetKeyName(2, "FuckinPerfect")
        Me.ImageList1.Images.SetKeyName(3, "GiveMeEverything")
        Me.ImageList1.Images.SetKeyName(4, "INeedDoctor")
        Me.ImageList1.Images.SetKeyName(5, "LazySong")
        Me.ImageList1.Images.SetKeyName(6, "OnTheFloor")
        Me.ImageList1.Images.SetKeyName(7, "PartyRockAnthem")
        Me.ImageList1.Images.SetKeyName(8, "PriceTag")
        Me.ImageList1.Images.SetKeyName(9, "S&M")
        Me.ImageList1.Images.SetKeyName(10, "TillTheWorldEnds")
        Me.ImageList1.Images.SetKeyName(11, "TonightImLovingYou")
        '
        'tmrReceivedMessage
        '
        Me.tmrReceivedMessage.Enabled = True
        Me.tmrReceivedMessage.Interval = 1000
        '
        'tmrWatchTyping
        '
        Me.tmrWatchTyping.Enabled = True
        Me.tmrWatchTyping.Interval = 750
        '
        'tmrReadTyping
        '
        Me.tmrReadTyping.Enabled = True
        Me.tmrReadTyping.Interval = 750
        '
        'tmrRefreshList
        '
        Me.tmrRefreshList.Enabled = True
        Me.tmrRefreshList.Interval = 1000
        '
        'tmrSeen
        '
        Me.tmrSeen.Enabled = True
        Me.tmrSeen.Interval = 1000
        '
        'frmChatBoxMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(746, 603)
        Me.Controls.Add(Me.SplitContainerControl2)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MinimumSize = New System.Drawing.Size(762, 642)
        Me.Name = "frmChatBoxMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Coffeecup Chat Box"
        Me.cms_em.ResumeLayout(False)
        CType(Me.txtContent.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNickname.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Profileimg.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitContainerControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl2.ResumeLayout(False)
        CType(Me.txtSearchUser.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgstatus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAccountid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cms_em As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdLocalData As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportHistoryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents txtContent As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents Profileimg As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents txtfullname As System.Windows.Forms.Label
    Friend WithEvents txtOffice As System.Windows.Forms.Label
    Friend WithEvents txtPosition As System.Windows.Forms.Label
    Friend WithEvents txtStatus As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtContactNumber As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents txtEmailAddress As System.Windows.Forms.LinkLabel
    Friend WithEvents ImageMenu As System.Windows.Forms.ImageList
    Friend WithEvents SplitContainerControl2 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents ListControl1 As LGUClient.ListControl
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents txtSearchUser As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtAccountid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents tmrReceivedMessage As System.Windows.Forms.Timer
    Friend WithEvents imgstatus As System.Windows.Forms.PictureBox
    Friend WithEvents tmrWatchTyping As System.Windows.Forms.Timer
    Friend WithEvents tmrReadTyping As System.Windows.Forms.Timer
    Friend WithEvents tmrRefreshList As System.Windows.Forms.Timer
    Friend WithEvents tmrSeen As System.Windows.Forms.Timer
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents txtNickname As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents txtWelcome As DevExpress.XtraEditors.LabelControl
    Friend WithEvents CheckEdit1 As DevExpress.XtraEditors.CheckEdit
End Class
