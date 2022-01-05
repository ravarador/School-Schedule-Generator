<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class form_viewdatabase
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_viewdatabase))
        Me.datagridview_instructor = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip_instructor = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DELETEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btn_create_table = New System.Windows.Forms.Button()
        Me.btn_delall_section = New System.Windows.Forms.Button()
        Me.btn_delall_room = New System.Windows.Forms.Button()
        Me.btn_delall_subject = New System.Windows.Forms.Button()
        Me.datagridview_section = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip_section = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DELETEToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.datagridview_room = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip_room = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DELETEToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.datagridview_subject = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip_subject = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DELETEToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.btn_delall_instructor = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.datagridview_instructor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip_instructor.SuspendLayout()
        CType(Me.datagridview_section, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip_section.SuspendLayout()
        CType(Me.datagridview_room, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip_room.SuspendLayout()
        CType(Me.datagridview_subject, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip_subject.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'datagridview_instructor
        '
        Me.datagridview_instructor.AllowUserToResizeColumns = False
        Me.datagridview_instructor.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datagridview_instructor.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.datagridview_instructor.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.datagridview_instructor.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.datagridview_instructor.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.datagridview_instructor.ColumnHeadersHeight = 50
        Me.datagridview_instructor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.datagridview_instructor.ColumnHeadersVisible = False
        Me.datagridview_instructor.ContextMenuStrip = Me.ContextMenuStrip_instructor
        Me.datagridview_instructor.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.datagridview_instructor.GridColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.datagridview_instructor.Location = New System.Drawing.Point(249, 55)
        Me.datagridview_instructor.MultiSelect = False
        Me.datagridview_instructor.Name = "datagridview_instructor"
        Me.datagridview_instructor.RowHeadersVisible = False
        Me.datagridview_instructor.RowHeadersWidth = 50
        Me.datagridview_instructor.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datagridview_instructor.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.datagridview_instructor.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.datagridview_instructor.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.datagridview_instructor.RowTemplate.Height = 15
        Me.datagridview_instructor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.datagridview_instructor.Size = New System.Drawing.Size(169, 308)
        Me.datagridview_instructor.TabIndex = 0
        '
        'ContextMenuStrip_instructor
        '
        Me.ContextMenuStrip_instructor.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DELETEToolStripMenuItem})
        Me.ContextMenuStrip_instructor.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip_instructor.Size = New System.Drawing.Size(114, 26)
        '
        'DELETEToolStripMenuItem
        '
        Me.DELETEToolStripMenuItem.Name = "DELETEToolStripMenuItem"
        Me.DELETEToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
        Me.DELETEToolStripMenuItem.Text = "DELETE"
        '
        'Button11
        '
        Me.Button11.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button11.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button11.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button11.Font = New System.Drawing.Font("Arimo", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button11.ForeColor = System.Drawing.Color.LightSlateGray
        Me.Button11.Location = New System.Drawing.Point(9, 9)
        Me.Button11.Margin = New System.Windows.Forms.Padding(0)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(23, 23)
        Me.Button11.TabIndex = 2
        Me.Button11.Text = "X"
        Me.Button11.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(23, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "INSTRUCTORS"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(684, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "SECTION"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(367, 5)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "ROOM"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(203, 5)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 20)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "SUBJECT"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(806, 5)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "SIZE"
        '
        'Label6
        '
        Me.Label6.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Label6.Cursor = System.Windows.Forms.Cursors.No
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(464, 5)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 20)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "TYPE"
        '
        'Label7
        '
        Me.Label7.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(551, 5)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 20)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "CAPACITY"
        '
        'btn_create_table
        '
        Me.btn_create_table.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btn_create_table.FlatAppearance.BorderSize = 0
        Me.btn_create_table.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_create_table.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_create_table.ForeColor = System.Drawing.Color.DimGray
        Me.btn_create_table.Location = New System.Drawing.Point(30, 68)
        Me.btn_create_table.Name = "btn_create_table"
        Me.btn_create_table.Size = New System.Drawing.Size(176, 50)
        Me.btn_create_table.TabIndex = 1
        Me.btn_create_table.Text = "CREATE TABLE"
        Me.btn_create_table.UseVisualStyleBackColor = False
        '
        'btn_delall_section
        '
        Me.btn_delall_section.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btn_delall_section.FlatAppearance.BorderSize = 0
        Me.btn_delall_section.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_delall_section.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delall_section.ForeColor = System.Drawing.Color.DimGray
        Me.btn_delall_section.Location = New System.Drawing.Point(30, 292)
        Me.btn_delall_section.Name = "btn_delall_section"
        Me.btn_delall_section.Size = New System.Drawing.Size(176, 50)
        Me.btn_delall_section.TabIndex = 3
        Me.btn_delall_section.Text = "DELETE ALL FROM SECTION"
        Me.btn_delall_section.UseVisualStyleBackColor = False
        '
        'btn_delall_room
        '
        Me.btn_delall_room.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.btn_delall_room.FlatAppearance.BorderSize = 0
        Me.btn_delall_room.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_delall_room.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delall_room.ForeColor = System.Drawing.Color.White
        Me.btn_delall_room.Location = New System.Drawing.Point(30, 236)
        Me.btn_delall_room.Name = "btn_delall_room"
        Me.btn_delall_room.Size = New System.Drawing.Size(176, 50)
        Me.btn_delall_room.TabIndex = 4
        Me.btn_delall_room.Text = "DELETE ALL FROM ROOM"
        Me.btn_delall_room.UseVisualStyleBackColor = False
        '
        'btn_delall_subject
        '
        Me.btn_delall_subject.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.btn_delall_subject.FlatAppearance.BorderSize = 0
        Me.btn_delall_subject.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_delall_subject.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delall_subject.ForeColor = System.Drawing.Color.White
        Me.btn_delall_subject.Location = New System.Drawing.Point(30, 180)
        Me.btn_delall_subject.Name = "btn_delall_subject"
        Me.btn_delall_subject.Size = New System.Drawing.Size(176, 50)
        Me.btn_delall_subject.TabIndex = 5
        Me.btn_delall_subject.Text = "DELETE ALL FROM SUBJECT"
        Me.btn_delall_subject.UseVisualStyleBackColor = False
        '
        'datagridview_section
        '
        Me.datagridview_section.AllowUserToResizeColumns = False
        Me.datagridview_section.AllowUserToResizeRows = False
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datagridview_section.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.datagridview_section.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.datagridview_section.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.datagridview_section.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.datagridview_section.ColumnHeadersHeight = 50
        Me.datagridview_section.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.datagridview_section.ColumnHeadersVisible = False
        Me.datagridview_section.ContextMenuStrip = Me.ContextMenuStrip_section
        Me.datagridview_section.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.datagridview_section.GridColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.datagridview_section.Location = New System.Drawing.Point(903, 55)
        Me.datagridview_section.MultiSelect = False
        Me.datagridview_section.Name = "datagridview_section"
        Me.datagridview_section.RowHeadersVisible = False
        Me.datagridview_section.RowHeadersWidth = 40
        Me.datagridview_section.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datagridview_section.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.datagridview_section.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.datagridview_section.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.datagridview_section.RowTemplate.Height = 15
        Me.datagridview_section.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.datagridview_section.Size = New System.Drawing.Size(234, 308)
        Me.datagridview_section.TabIndex = 1
        '
        'ContextMenuStrip_section
        '
        Me.ContextMenuStrip_section.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DELETEToolStripMenuItem1})
        Me.ContextMenuStrip_section.Name = "ContextMenuStrip_section"
        Me.ContextMenuStrip_section.Size = New System.Drawing.Size(114, 26)
        '
        'DELETEToolStripMenuItem1
        '
        Me.DELETEToolStripMenuItem1.Name = "DELETEToolStripMenuItem1"
        Me.DELETEToolStripMenuItem1.Size = New System.Drawing.Size(113, 22)
        Me.DELETEToolStripMenuItem1.Text = "DELETE"
        '
        'datagridview_room
        '
        Me.datagridview_room.AllowUserToResizeColumns = False
        Me.datagridview_room.AllowUserToResizeRows = False
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datagridview_room.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.datagridview_room.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.datagridview_room.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.datagridview_room.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.datagridview_room.ColumnHeadersHeight = 50
        Me.datagridview_room.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.datagridview_room.ColumnHeadersVisible = False
        Me.datagridview_room.ContextMenuStrip = Me.ContextMenuStrip_room
        Me.datagridview_room.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.datagridview_room.GridColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.datagridview_room.Location = New System.Drawing.Point(597, 55)
        Me.datagridview_room.MultiSelect = False
        Me.datagridview_room.Name = "datagridview_room"
        Me.datagridview_room.RowHeadersVisible = False
        Me.datagridview_room.RowHeadersWidth = 40
        Me.datagridview_room.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datagridview_room.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.datagridview_room.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.datagridview_room.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.datagridview_room.RowTemplate.Height = 15
        Me.datagridview_room.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.datagridview_room.Size = New System.Drawing.Size(300, 308)
        Me.datagridview_room.TabIndex = 2
        '
        'ContextMenuStrip_room
        '
        Me.ContextMenuStrip_room.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DELETEToolStripMenuItem2})
        Me.ContextMenuStrip_room.Name = "ContextMenuStrip_room"
        Me.ContextMenuStrip_room.Size = New System.Drawing.Size(114, 26)
        '
        'DELETEToolStripMenuItem2
        '
        Me.DELETEToolStripMenuItem2.Name = "DELETEToolStripMenuItem2"
        Me.DELETEToolStripMenuItem2.Size = New System.Drawing.Size(113, 22)
        Me.DELETEToolStripMenuItem2.Text = "DELETE"
        '
        'datagridview_subject
        '
        Me.datagridview_subject.AllowUserToResizeColumns = False
        Me.datagridview_subject.AllowUserToResizeRows = False
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datagridview_subject.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        Me.datagridview_subject.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.datagridview_subject.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.datagridview_subject.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.datagridview_subject.ColumnHeadersHeight = 50
        Me.datagridview_subject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.datagridview_subject.ColumnHeadersVisible = False
        Me.datagridview_subject.ContextMenuStrip = Me.ContextMenuStrip_subject
        Me.datagridview_subject.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.datagridview_subject.GridColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.datagridview_subject.Location = New System.Drawing.Point(424, 55)
        Me.datagridview_subject.MultiSelect = False
        Me.datagridview_subject.Name = "datagridview_subject"
        Me.datagridview_subject.RowHeadersVisible = False
        Me.datagridview_subject.RowHeadersWidth = 40
        Me.datagridview_subject.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datagridview_subject.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.datagridview_subject.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.datagridview_subject.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.datagridview_subject.RowTemplate.Height = 15
        Me.datagridview_subject.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.datagridview_subject.Size = New System.Drawing.Size(167, 308)
        Me.datagridview_subject.TabIndex = 3
        '
        'ContextMenuStrip_subject
        '
        Me.ContextMenuStrip_subject.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DELETEToolStripMenuItem3})
        Me.ContextMenuStrip_subject.Name = "ContextMenuStrip_subject"
        Me.ContextMenuStrip_subject.Size = New System.Drawing.Size(114, 26)
        '
        'DELETEToolStripMenuItem3
        '
        Me.DELETEToolStripMenuItem3.Name = "DELETEToolStripMenuItem3"
        Me.DELETEToolStripMenuItem3.Size = New System.Drawing.Size(113, 22)
        Me.DELETEToolStripMenuItem3.Text = "DELETE"
        '
        'btn_delall_instructor
        '
        Me.btn_delall_instructor.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btn_delall_instructor.FlatAppearance.BorderSize = 0
        Me.btn_delall_instructor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_delall_instructor.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delall_instructor.ForeColor = System.Drawing.Color.White
        Me.btn_delall_instructor.Location = New System.Drawing.Point(30, 124)
        Me.btn_delall_instructor.Name = "btn_delall_instructor"
        Me.btn_delall_instructor.Size = New System.Drawing.Size(176, 50)
        Me.btn_delall_instructor.TabIndex = 2
        Me.btn_delall_instructor.Text = "DELETE ALL FROM INSTRUCTORS"
        Me.btn_delall_instructor.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(249, 13)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(888, 36)
        Me.Panel1.TabIndex = 9
        '
        'form_viewdatabase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSlateGray
        Me.ClientSize = New System.Drawing.Size(1160, 382)
        Me.Controls.Add(Me.datagridview_subject)
        Me.Controls.Add(Me.datagridview_room)
        Me.Controls.Add(Me.btn_delall_subject)
        Me.Controls.Add(Me.datagridview_section)
        Me.Controls.Add(Me.datagridview_instructor)
        Me.Controls.Add(Me.btn_delall_room)
        Me.Controls.Add(Me.btn_delall_section)
        Me.Controls.Add(Me.btn_delall_instructor)
        Me.Controls.Add(Me.btn_create_table)
        Me.Controls.Add(Me.Button11)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(0, 450)
        Me.Name = "form_viewdatabase"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "form_viewdatabase"
        Me.TopMost = True
        CType(Me.datagridview_instructor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip_instructor.ResumeLayout(False)
        CType(Me.datagridview_section, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip_section.ResumeLayout(False)
        CType(Me.datagridview_room, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip_room.ResumeLayout(False)
        CType(Me.datagridview_subject, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip_subject.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents datagridview_instructor As DataGridView
    Friend WithEvents Button11 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ContextMenuStrip_instructor As ContextMenuStrip
    Friend WithEvents DELETEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btn_create_table As Button
    Friend WithEvents btn_delall_instructor As Button
    Friend WithEvents btn_delall_section As Button
    Friend WithEvents btn_delall_room As Button
    Friend WithEvents btn_delall_subject As Button
    Friend WithEvents datagridview_section As DataGridView
    Friend WithEvents datagridview_room As DataGridView
    Friend WithEvents datagridview_subject As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ContextMenuStrip_section As ContextMenuStrip
    Friend WithEvents DELETEToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ContextMenuStrip_room As ContextMenuStrip
    Friend WithEvents DELETEToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ContextMenuStrip_subject As ContextMenuStrip
    Friend WithEvents DELETEToolStripMenuItem3 As ToolStripMenuItem
End Class
