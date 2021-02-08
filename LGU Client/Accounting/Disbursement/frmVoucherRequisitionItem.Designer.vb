<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVoucherRequisitionItem
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
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SelectItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.txtSearch = New DevExpress.XtraEditors.TextEdit()
        Me.officeid = New DevExpress.XtraEditors.TextEdit()
        Me.trnreference = New DevExpress.XtraEditors.TextEdit()
        Me.periodcode = New DevExpress.XtraEditors.TextEdit()
        Me.voucherno = New DevExpress.XtraEditors.TextEdit()
        Me.CheckEdit1 = New DevExpress.XtraEditors.CheckEdit()
        Me.cmdOk = New DevExpress.XtraEditors.SimpleButton()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.txtSearch.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.officeid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trnreference.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.periodcode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.voucherno.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SelectItemToolStripMenuItem, Me.ToolStripSeparator4, Me.ToolStripMenuItem5})
        Me.ContextMenuStrip1.Name = "gridmenustrip"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(161, 54)
        '
        'SelectItemToolStripMenuItem
        '
        Me.SelectItemToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SelectItemToolStripMenuItem.Image = Global.LGUClient.My.Resources.Resources.arrow_curve
        Me.SelectItemToolStripMenuItem.Name = "SelectItemToolStripMenuItem"
        Me.SelectItemToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.SelectItemToolStripMenuItem.Text = "Add to Request"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(157, 6)
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Image = Global.LGUClient.My.Resources.Resources.arrow_continue_090
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(160, 22)
        Me.ToolStripMenuItem5.Text = "Refresh Data"
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl1.Horizontal = False
        Me.SplitContainerControl1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.txtSearch)
        Me.SplitContainerControl1.Panel1.Padding = New System.Windows.Forms.Padding(6)
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.officeid)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.trnreference)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.periodcode)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.voucherno)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.CheckEdit1)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.cmdOk)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.dgv)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(931, 530)
        Me.SplitContainerControl1.SplitterPosition = 39
        Me.SplitContainerControl1.TabIndex = 12
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'txtSearch
        '
        Me.txtSearch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtSearch.EditValue = ""
        Me.txtSearch.Location = New System.Drawing.Point(6, 6)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.txtSearch.Properties.Appearance.Options.UseFont = True
        Me.txtSearch.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSearch.Size = New System.Drawing.Size(919, 26)
        Me.txtSearch.TabIndex = 2
        '
        'officeid
        '
        Me.officeid.EnterMoveNextControl = True
        Me.officeid.Location = New System.Drawing.Point(411, 222)
        Me.officeid.Name = "officeid"
        Me.officeid.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.officeid.Properties.Appearance.Options.UseFont = True
        Me.officeid.Size = New System.Drawing.Size(96, 20)
        Me.officeid.TabIndex = 776
        Me.officeid.Visible = False
        '
        'trnreference
        '
        Me.trnreference.EnterMoveNextControl = True
        Me.trnreference.Location = New System.Drawing.Point(411, 170)
        Me.trnreference.Name = "trnreference"
        Me.trnreference.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.trnreference.Properties.Appearance.Options.UseFont = True
        Me.trnreference.Size = New System.Drawing.Size(96, 20)
        Me.trnreference.TabIndex = 775
        Me.trnreference.Visible = False
        '
        'periodcode
        '
        Me.periodcode.EnterMoveNextControl = True
        Me.periodcode.Location = New System.Drawing.Point(411, 248)
        Me.periodcode.Name = "periodcode"
        Me.periodcode.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.periodcode.Properties.Appearance.Options.UseFont = True
        Me.periodcode.Size = New System.Drawing.Size(96, 20)
        Me.periodcode.TabIndex = 774
        Me.periodcode.Visible = False
        '
        'voucherno
        '
        Me.voucherno.EnterMoveNextControl = True
        Me.voucherno.Location = New System.Drawing.Point(411, 196)
        Me.voucherno.Name = "voucherno"
        Me.voucherno.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.voucherno.Properties.Appearance.Options.UseFont = True
        Me.voucherno.Size = New System.Drawing.Size(96, 20)
        Me.voucherno.TabIndex = 771
        Me.voucherno.Visible = False
        '
        'CheckEdit1
        '
        Me.CheckEdit1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CheckEdit1.Location = New System.Drawing.Point(14, 439)
        Me.CheckEdit1.Name = "CheckEdit1"
        Me.CheckEdit1.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckEdit1.Properties.Appearance.Options.UseFont = True
        Me.CheckEdit1.Properties.Caption = "Check All"
        Me.CheckEdit1.Size = New System.Drawing.Size(82, 20)
        Me.CheckEdit1.TabIndex = 769
        '
        'cmdOk
        '
        Me.cmdOk.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.cmdOk.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmdOk.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOk.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.cmdOk.Appearance.Options.UseBackColor = True
        Me.cmdOk.Appearance.Options.UseFont = True
        Me.cmdOk.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmdOk.Location = New System.Drawing.Point(330, 435)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(280, 35)
        Me.cmdOk.TabIndex = 767
        Me.cmdOk.Text = "Confirm add checked item to voucher"
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AllowUserToDeleteRows = False
        Me.dgv.AllowUserToResizeRows = False
        Me.dgv.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv.BackgroundColor = System.Drawing.Color.White
        Me.dgv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgv.Location = New System.Drawing.Point(6, 12)
        Me.dgv.Margin = New System.Windows.Forms.Padding(2)
        Me.dgv.MultiSelect = False
        Me.dgv.Name = "dgv"
        Me.dgv.RowHeadersVisible = False
        Me.dgv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.CornflowerBlue
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.dgv.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgv.Size = New System.Drawing.Size(919, 416)
        Me.dgv.TabIndex = 770
        '
        'frmVoucherRequisitionItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(931, 530)
        Me.Controls.Add(Me.SplitContainerControl1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpButton = True
        Me.Name = "frmVoucherRequisitionItem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add payable to disbursement voucher"
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.txtSearch.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.officeid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trnreference.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.periodcode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.voucherno.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents SelectItemToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItem5 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents txtSearch As DevExpress.XtraEditors.TextEdit
    Friend WithEvents voucherno As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CheckEdit1 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents cmdOk As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
    Friend WithEvents periodcode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents trnreference As DevExpress.XtraEditors.TextEdit
    Friend WithEvents officeid As DevExpress.XtraEditors.TextEdit
End Class
