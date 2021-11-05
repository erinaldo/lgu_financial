<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFileViewer
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MyDataGridView = New System.Windows.Forms.DataGridView()
        Me.cms_em = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DeleteCategoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.trncode = New System.Windows.Forms.TextBox()
        Me.cmdExtract = New System.Windows.Forms.Button()
        Me.trntype = New System.Windows.Forms.TextBox()
        Me.cmdAttach = New System.Windows.Forms.Button()
        Me.RefreshFilesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        CType(Me.MyDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cms_em.SuspendLayout()
        Me.SuspendLayout()
        '
        'MyDataGridView
        '
        Me.MyDataGridView.AllowUserToAddRows = False
        Me.MyDataGridView.AllowUserToDeleteRows = False
        Me.MyDataGridView.AllowUserToResizeColumns = False
        Me.MyDataGridView.AllowUserToResizeRows = False
        Me.MyDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MyDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.MyDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.MyDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.MyDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MyDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.MyDataGridView.ContextMenuStrip = Me.cms_em
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.MyDataGridView.DefaultCellStyle = DataGridViewCellStyle2
        Me.MyDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.MyDataGridView.Margin = New System.Windows.Forms.Padding(2)
        Me.MyDataGridView.Name = "MyDataGridView"
        Me.MyDataGridView.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MyDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.MyDataGridView.RowHeadersVisible = False
        Me.MyDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.CornflowerBlue
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        Me.MyDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.MyDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MyDataGridView.Size = New System.Drawing.Size(482, 351)
        Me.MyDataGridView.TabIndex = 374
        '
        'cms_em
        '
        Me.cms_em.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeleteCategoryToolStripMenuItem, Me.ToolStripSeparator1, Me.RefreshFilesToolStripMenuItem})
        Me.cms_em.Name = "ContextMenuStrip1"
        Me.cms_em.Size = New System.Drawing.Size(140, 54)
        '
        'DeleteCategoryToolStripMenuItem
        '
        Me.DeleteCategoryToolStripMenuItem.Image = Global.LGUFinancial.My.Resources.Resources.inbox__minus
        Me.DeleteCategoryToolStripMenuItem.Name = "DeleteCategoryToolStripMenuItem"
        Me.DeleteCategoryToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.DeleteCategoryToolStripMenuItem.Text = "Delete File"
        '
        'trncode
        '
        Me.trncode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.trncode.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.trncode.ForeColor = System.Drawing.Color.Black
        Me.trncode.Location = New System.Drawing.Point(12, 357)
        Me.trncode.Margin = New System.Windows.Forms.Padding(4)
        Me.trncode.Name = "trncode"
        Me.trncode.ReadOnly = True
        Me.trncode.Size = New System.Drawing.Size(35, 22)
        Me.trncode.TabIndex = 416
        Me.trncode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.trncode.Visible = False
        '
        'cmdExtract
        '
        Me.cmdExtract.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.cmdExtract.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdExtract.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExtract.Location = New System.Drawing.Point(244, 356)
        Me.cmdExtract.Name = "cmdExtract"
        Me.cmdExtract.Size = New System.Drawing.Size(157, 30)
        Me.cmdExtract.TabIndex = 417
        Me.cmdExtract.Text = "Extract Files"
        Me.cmdExtract.UseVisualStyleBackColor = True
        '
        'trntype
        '
        Me.trntype.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.trntype.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.trntype.ForeColor = System.Drawing.Color.Black
        Me.trntype.Location = New System.Drawing.Point(55, 357)
        Me.trntype.Margin = New System.Windows.Forms.Padding(4)
        Me.trntype.Name = "trntype"
        Me.trntype.ReadOnly = True
        Me.trntype.Size = New System.Drawing.Size(35, 22)
        Me.trntype.TabIndex = 418
        Me.trntype.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.trntype.Visible = False
        '
        'cmdAttach
        '
        Me.cmdAttach.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.cmdAttach.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdAttach.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAttach.Location = New System.Drawing.Point(81, 356)
        Me.cmdAttach.Name = "cmdAttach"
        Me.cmdAttach.Size = New System.Drawing.Size(157, 30)
        Me.cmdAttach.TabIndex = 419
        Me.cmdAttach.Text = "Attach Files"
        Me.cmdAttach.UseVisualStyleBackColor = True
        '
        'RefreshFilesToolStripMenuItem
        '
        Me.RefreshFilesToolStripMenuItem.Image = Global.LGUFinancial.My.Resources.Resources.arrow_continue_090_left
        Me.RefreshFilesToolStripMenuItem.Name = "RefreshFilesToolStripMenuItem"
        Me.RefreshFilesToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.RefreshFilesToolStripMenuItem.Text = "Refresh Files"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(136, 6)
        '
        'frmFileViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(483, 396)
        Me.Controls.Add(Me.cmdAttach)
        Me.Controls.Add(Me.trntype)
        Me.Controls.Add(Me.cmdExtract)
        Me.Controls.Add(Me.trncode)
        Me.Controls.Add(Me.MyDataGridView)
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(345, 435)
        Me.Name = "frmFileViewer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "File Viewer"
        CType(Me.MyDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cms_em.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MyDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents trncode As System.Windows.Forms.TextBox
    Friend WithEvents cms_em As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents DeleteCategoryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdExtract As System.Windows.Forms.Button
    Friend WithEvents trntype As System.Windows.Forms.TextBox
    Friend WithEvents cmdAttach As Button
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents RefreshFilesToolStripMenuItem As ToolStripMenuItem
End Class
