<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class form_classdatabase
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.datagridview_class = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DELETEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.button_close = New System.Windows.Forms.Button()
        Me.btn_delall = New System.Windows.Forms.Button()
        CType(Me.datagridview_class, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'datagridview_class
        '
        Me.datagridview_class.AllowUserToResizeColumns = False
        Me.datagridview_class.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datagridview_class.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.datagridview_class.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.datagridview_class.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.datagridview_class.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.datagridview_class.ColumnHeadersHeight = 50
        Me.datagridview_class.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.datagridview_class.ContextMenuStrip = Me.ContextMenuStrip1
        Me.datagridview_class.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.datagridview_class.GridColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.datagridview_class.Location = New System.Drawing.Point(206, 12)
        Me.datagridview_class.MultiSelect = False
        Me.datagridview_class.Name = "datagridview_class"
        Me.datagridview_class.RowHeadersVisible = False
        Me.datagridview_class.RowHeadersWidth = 50
        Me.datagridview_class.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datagridview_class.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.datagridview_class.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.datagridview_class.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.datagridview_class.RowTemplate.Height = 15
        Me.datagridview_class.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datagridview_class.Size = New System.Drawing.Size(890, 426)
        Me.datagridview_class.TabIndex = 1
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DELETEToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(114, 26)
        '
        'DELETEToolStripMenuItem
        '
        Me.DELETEToolStripMenuItem.Name = "DELETEToolStripMenuItem"
        Me.DELETEToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
        Me.DELETEToolStripMenuItem.Text = "DELETE"
        '
        'button_close
        '
        Me.button_close.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.button_close.BackColor = System.Drawing.Color.WhiteSmoke
        Me.button_close.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.button_close.Font = New System.Drawing.Font("Arimo", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_close.ForeColor = System.Drawing.Color.LightSlateGray
        Me.button_close.Location = New System.Drawing.Point(9, 9)
        Me.button_close.Margin = New System.Windows.Forms.Padding(0)
        Me.button_close.Name = "button_close"
        Me.button_close.Size = New System.Drawing.Size(23, 23)
        Me.button_close.TabIndex = 3
        Me.button_close.Text = "X"
        Me.button_close.UseVisualStyleBackColor = False
        '
        'btn_delall
        '
        Me.btn_delall.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btn_delall.FlatAppearance.BorderSize = 0
        Me.btn_delall.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_delall.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delall.ForeColor = System.Drawing.Color.White
        Me.btn_delall.Location = New System.Drawing.Point(9, 388)
        Me.btn_delall.Name = "btn_delall"
        Me.btn_delall.Size = New System.Drawing.Size(176, 50)
        Me.btn_delall.TabIndex = 4
        Me.btn_delall.Text = "DELETE ALL"
        Me.btn_delall.UseVisualStyleBackColor = False
        '
        'form_classdatabase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1104, 450)
        Me.Controls.Add(Me.btn_delall)
        Me.Controls.Add(Me.button_close)
        Me.Controls.Add(Me.datagridview_class)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "form_classdatabase"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "form_classdatabase"
        CType(Me.datagridview_class, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents datagridview_class As DataGridView
    Friend WithEvents button_close As Button
    Friend WithEvents btn_delall As Button
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents DELETEToolStripMenuItem As ToolStripMenuItem
End Class
