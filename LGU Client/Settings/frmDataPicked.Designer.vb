<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDataPicked
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDataPicked))
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditApproverToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.fieldname = New DevExpress.XtraEditors.TextEdit()
        Me.id = New DevExpress.XtraEditors.TextEdit()
        Me.mode = New DevExpress.XtraEditors.TextEdit()
        Me.txtDescription = New DevExpress.XtraEditors.TextEdit()
        Me.Em = New DevExpress.XtraGrid.GridControl()
        Me.gv_datapicked = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.fieldname.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.id.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescription.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gv_datapicked, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditApproverToolStripMenuItem, Me.ToolStripMenuItem4, Me.ToolStripSeparator1, Me.ToolStripMenuItem5})
        Me.ContextMenuStrip1.Name = "gridmenustrip"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(165, 76)
        '
        'EditApproverToolStripMenuItem
        '
        Me.EditApproverToolStripMenuItem.Image = Global.LGUClient.My.Resources.Resources.notebook__pencil
        Me.EditApproverToolStripMenuItem.Name = "EditApproverToolStripMenuItem"
        Me.EditApproverToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.EditApproverToolStripMenuItem.Text = "Edit Selected"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Image = Global.LGUClient.My.Resources.Resources.notebook__minus
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(164, 22)
        Me.ToolStripMenuItem4.Text = "Remove Selected"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(161, 6)
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Image = Global.LGUClient.My.Resources.Resources.arrow_continue_090
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(164, 22)
        Me.ToolStripMenuItem5.Text = "Refresh Data"
        '
        'fieldname
        '
        Me.fieldname.Location = New System.Drawing.Point(310, 217)
        Me.fieldname.Name = "fieldname"
        Me.fieldname.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fieldname.Properties.Appearance.Options.UseFont = True
        Me.fieldname.Properties.Appearance.Options.UseTextOptions = True
        Me.fieldname.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.fieldname.Properties.ReadOnly = True
        Me.fieldname.Size = New System.Drawing.Size(44, 20)
        Me.fieldname.TabIndex = 698
        Me.fieldname.Visible = False
        '
        'id
        '
        Me.id.Location = New System.Drawing.Point(250, 138)
        Me.id.Name = "id"
        Me.id.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.id.Properties.Appearance.Options.UseFont = True
        Me.id.Properties.Appearance.Options.UseTextOptions = True
        Me.id.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.id.Properties.ReadOnly = True
        Me.id.Size = New System.Drawing.Size(44, 20)
        Me.id.TabIndex = 696
        Me.id.Visible = False
        '
        'mode
        '
        Me.mode.Location = New System.Drawing.Point(143, 138)
        Me.mode.Name = "mode"
        Me.mode.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mode.Properties.Appearance.Options.UseFont = True
        Me.mode.Properties.Appearance.Options.UseTextOptions = True
        Me.mode.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.mode.Properties.ReadOnly = True
        Me.mode.Size = New System.Drawing.Size(44, 20)
        Me.mode.TabIndex = 697
        Me.mode.Visible = False
        '
        'txtDescription
        '
        Me.txtDescription.EditValue = ""
        Me.txtDescription.Location = New System.Drawing.Point(12, 8)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescription.Properties.Appearance.Options.UseFont = True
        Me.txtDescription.Properties.Appearance.Options.UseTextOptions = True
        Me.txtDescription.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.txtDescription.Properties.NullValuePrompt = "Please enter new item here and hit enter to insert"
        Me.txtDescription.Properties.NullValuePromptShowForEmptyValue = True
        Me.txtDescription.Size = New System.Drawing.Size(430, 26)
        Me.txtDescription.TabIndex = 0
        '
        'Em
        '
        Me.Em.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Em.Location = New System.Drawing.Point(12, 40)
        Me.Em.MainView = Me.gv_datapicked
        Me.Em.Name = "Em"
        Me.Em.Size = New System.Drawing.Size(430, 513)
        Me.Em.TabIndex = 695
        Me.Em.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gv_datapicked})
        '
        'gv_datapicked
        '
        Me.gv_datapicked.DetailHeight = 404
        Me.gv_datapicked.GridControl = Me.Em
        Me.gv_datapicked.Name = "gv_datapicked"
        Me.gv_datapicked.OptionsBehavior.Editable = False
        Me.gv_datapicked.OptionsView.ShowGroupPanel = False
        '
        'frmDataPicked
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(453, 563)
        Me.Controls.Add(Me.fieldname)
        Me.Controls.Add(Me.id)
        Me.Controls.Add(Me.mode)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.Em)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmDataPicked"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.fieldname.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.id.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescription.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gv_datapicked, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents EditApproverToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItem5 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents fieldname As DevExpress.XtraEditors.TextEdit
    Friend WithEvents id As DevExpress.XtraEditors.TextEdit
    Friend WithEvents mode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDescription As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Em As DevExpress.XtraGrid.GridControl
    Friend WithEvents gv_datapicked As DevExpress.XtraGrid.Views.Grid.GridView
End Class
