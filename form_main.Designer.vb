<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class form_main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_main))
        Me.Button11 = New System.Windows.Forms.Button()
        Me.btn_changepass = New System.Windows.Forms.Button()
        Me.btn_signout = New System.Windows.Forms.Button()
        Me.listbox_instructor = New System.Windows.Forms.ListBox()
        Me.listbox_section = New System.Windows.Forms.ListBox()
        Me.btn_manage_db = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btn_addsubject = New System.Windows.Forms.Button()
        Me.btn_addroom = New System.Windows.Forms.Button()
        Me.btn_addsection = New System.Windows.Forms.Button()
        Me.btn_addinstructor = New System.Windows.Forms.Button()
        Me.listbox_room = New System.Windows.Forms.ListBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.listbox_subject = New System.Windows.Forms.ListBox()
        Me.btn_createclass = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.listbox_class = New System.Windows.Forms.ListBox()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button11
        '
        Me.Button11.BackColor = System.Drawing.Color.White
        Me.Button11.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button11.Font = New System.Drawing.Font("Arimo", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button11.ForeColor = System.Drawing.Color.LightSlateGray
        Me.Button11.Location = New System.Drawing.Point(9, 9)
        Me.Button11.Margin = New System.Windows.Forms.Padding(0)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(23, 23)
        Me.Button11.TabIndex = 9
        Me.Button11.Text = "X"
        Me.Button11.UseVisualStyleBackColor = False
        '
        'btn_changepass
        '
        Me.btn_changepass.BackColor = System.Drawing.Color.LightSlateGray
        Me.btn_changepass.FlatAppearance.BorderSize = 0
        Me.btn_changepass.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_changepass.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_changepass.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_changepass.Location = New System.Drawing.Point(983, 2)
        Me.btn_changepass.Name = "btn_changepass"
        Me.btn_changepass.Size = New System.Drawing.Size(119, 19)
        Me.btn_changepass.TabIndex = 10
        Me.btn_changepass.Text = "Change Password"
        Me.btn_changepass.UseVisualStyleBackColor = False
        '
        'btn_signout
        '
        Me.btn_signout.BackColor = System.Drawing.Color.LightSlateGray
        Me.btn_signout.FlatAppearance.BorderSize = 0
        Me.btn_signout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_signout.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_signout.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_signout.Location = New System.Drawing.Point(1108, 2)
        Me.btn_signout.Name = "btn_signout"
        Me.btn_signout.Size = New System.Drawing.Size(111, 19)
        Me.btn_signout.TabIndex = 10
        Me.btn_signout.Text = "Sign Out"
        Me.btn_signout.UseVisualStyleBackColor = False
        '
        'listbox_instructor
        '
        Me.listbox_instructor.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.listbox_instructor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.listbox_instructor.Font = New System.Drawing.Font("Segoe Condensed", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listbox_instructor.ForeColor = System.Drawing.Color.White
        Me.listbox_instructor.FormattingEnabled = True
        Me.listbox_instructor.ItemHeight = 15
        Me.listbox_instructor.Location = New System.Drawing.Point(51, 183)
        Me.listbox_instructor.Name = "listbox_instructor"
        Me.listbox_instructor.Size = New System.Drawing.Size(292, 407)
        Me.listbox_instructor.TabIndex = 0
        '
        'listbox_section
        '
        Me.listbox_section.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.listbox_section.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.listbox_section.Font = New System.Drawing.Font("Segoe Condensed", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listbox_section.ForeColor = System.Drawing.Color.White
        Me.listbox_section.FormattingEnabled = True
        Me.listbox_section.ItemHeight = 15
        Me.listbox_section.Location = New System.Drawing.Point(927, 183)
        Me.listbox_section.Name = "listbox_section"
        Me.listbox_section.Size = New System.Drawing.Size(292, 407)
        Me.listbox_section.TabIndex = 1
        '
        'btn_manage_db
        '
        Me.btn_manage_db.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btn_manage_db.FlatAppearance.BorderSize = 0
        Me.btn_manage_db.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_manage_db.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_manage_db.ForeColor = System.Drawing.Color.White
        Me.btn_manage_db.Location = New System.Drawing.Point(51, 605)
        Me.btn_manage_db.Name = "btn_manage_db"
        Me.btn_manage_db.Size = New System.Drawing.Size(143, 34)
        Me.btn_manage_db.TabIndex = 5
        Me.btn_manage_db.Text = "LIST DB"
        Me.btn_manage_db.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Panel2.Controls.Add(Me.btn_addsubject)
        Me.Panel2.Controls.Add(Me.btn_addroom)
        Me.Panel2.Controls.Add(Me.btn_addsection)
        Me.Panel2.Controls.Add(Me.btn_addinstructor)
        Me.Panel2.Location = New System.Drawing.Point(51, 43)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1168, 123)
        Me.Panel2.TabIndex = 0
        '
        'btn_addsubject
        '
        Me.btn_addsubject.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.btn_addsubject.BackgroundImage = Global.configuration_with_db.My.Resources.Resources.icon_subject2
        Me.btn_addsubject.FlatAppearance.BorderSize = 0
        Me.btn_addsubject.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_addsubject.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_addsubject.ForeColor = System.Drawing.Color.White
        Me.btn_addsubject.Location = New System.Drawing.Point(292, 0)
        Me.btn_addsubject.Name = "btn_addsubject"
        Me.btn_addsubject.Size = New System.Drawing.Size(292, 123)
        Me.btn_addsubject.TabIndex = 4
        Me.btn_addsubject.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.btn_addsubject.UseVisualStyleBackColor = False
        '
        'btn_addroom
        '
        Me.btn_addroom.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btn_addroom.BackgroundImage = Global.configuration_with_db.My.Resources.Resources.icon_room2
        Me.btn_addroom.FlatAppearance.BorderSize = 0
        Me.btn_addroom.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_addroom.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_addroom.ForeColor = System.Drawing.Color.DimGray
        Me.btn_addroom.Location = New System.Drawing.Point(584, 0)
        Me.btn_addroom.Name = "btn_addroom"
        Me.btn_addroom.Size = New System.Drawing.Size(292, 123)
        Me.btn_addroom.TabIndex = 3
        Me.btn_addroom.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.btn_addroom.UseVisualStyleBackColor = False
        '
        'btn_addsection
        '
        Me.btn_addsection.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btn_addsection.BackgroundImage = Global.configuration_with_db.My.Resources.Resources.icon_section2
        Me.btn_addsection.FlatAppearance.BorderSize = 0
        Me.btn_addsection.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_addsection.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_addsection.ForeColor = System.Drawing.Color.White
        Me.btn_addsection.Location = New System.Drawing.Point(876, 0)
        Me.btn_addsection.Name = "btn_addsection"
        Me.btn_addsection.Size = New System.Drawing.Size(292, 123)
        Me.btn_addsection.TabIndex = 2
        Me.btn_addsection.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.btn_addsection.UseVisualStyleBackColor = False
        '
        'btn_addinstructor
        '
        Me.btn_addinstructor.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.btn_addinstructor.BackgroundImage = Global.configuration_with_db.My.Resources.Resources.icon_instructor2
        Me.btn_addinstructor.FlatAppearance.BorderSize = 0
        Me.btn_addinstructor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_addinstructor.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_addinstructor.ForeColor = System.Drawing.Color.White
        Me.btn_addinstructor.Location = New System.Drawing.Point(0, 0)
        Me.btn_addinstructor.Name = "btn_addinstructor"
        Me.btn_addinstructor.Size = New System.Drawing.Size(292, 123)
        Me.btn_addinstructor.TabIndex = 1
        Me.btn_addinstructor.Text = "."
        Me.btn_addinstructor.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.btn_addinstructor.UseVisualStyleBackColor = False
        '
        'listbox_room
        '
        Me.listbox_room.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.listbox_room.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.listbox_room.Enabled = False
        Me.listbox_room.Font = New System.Drawing.Font("Segoe Condensed", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listbox_room.ForeColor = System.Drawing.Color.DimGray
        Me.listbox_room.FormattingEnabled = True
        Me.listbox_room.ItemHeight = 15
        Me.listbox_room.Location = New System.Drawing.Point(635, 183)
        Me.listbox_room.Name = "listbox_room"
        Me.listbox_room.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.listbox_room.Size = New System.Drawing.Size(292, 407)
        Me.listbox_room.TabIndex = 0
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.Location = New System.Drawing.Point(635, 605)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(295, 34)
        Me.Button5.TabIndex = 6
        Me.Button5.Text = "CREATE CONFIG FILE"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'listbox_subject
        '
        Me.listbox_subject.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.listbox_subject.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.listbox_subject.Font = New System.Drawing.Font("Segoe Condensed", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listbox_subject.ForeColor = System.Drawing.Color.White
        Me.listbox_subject.FormattingEnabled = True
        Me.listbox_subject.ItemHeight = 15
        Me.listbox_subject.Location = New System.Drawing.Point(343, 183)
        Me.listbox_subject.Name = "listbox_subject"
        Me.listbox_subject.Size = New System.Drawing.Size(292, 407)
        Me.listbox_subject.TabIndex = 0
        '
        'btn_createclass
        '
        Me.btn_createclass.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btn_createclass.FlatAppearance.BorderSize = 0
        Me.btn_createclass.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_createclass.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_createclass.ForeColor = System.Drawing.Color.White
        Me.btn_createclass.Location = New System.Drawing.Point(340, 605)
        Me.btn_createclass.Name = "btn_createclass"
        Me.btn_createclass.Size = New System.Drawing.Size(298, 34)
        Me.btn_createclass.TabIndex = 7
        Me.btn_createclass.Text = "CREATE CLASSES"
        Me.btn_createclass.UseVisualStyleBackColor = False
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Button9.FlatAppearance.BorderSize = 0
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button9.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.ForeColor = System.Drawing.Color.White
        Me.Button9.Location = New System.Drawing.Point(927, 605)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(292, 34)
        Me.Button9.TabIndex = 8
        Me.Button9.Text = "OPEN GENERATOR"
        Me.Button9.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LightSlateGray
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.Control
        Me.Button1.Location = New System.Drawing.Point(858, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(119, 19)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Backup Database"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(194, 605)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(146, 34)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "CLASS DB"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'listbox_class
        '
        Me.listbox_class.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.listbox_class.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.listbox_class.Enabled = False
        Me.listbox_class.Font = New System.Drawing.Font("Segoe Condensed", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listbox_class.ForeColor = System.Drawing.Color.DimGray
        Me.listbox_class.FormattingEnabled = True
        Me.listbox_class.ItemHeight = 15
        Me.listbox_class.Location = New System.Drawing.Point(1238, 43)
        Me.listbox_class.Name = "listbox_class"
        Me.listbox_class.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.listbox_class.Size = New System.Drawing.Size(292, 542)
        Me.listbox_class.TabIndex = 0
        '
        'form_main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSlateGray
        Me.ClientSize = New System.Drawing.Size(1227, 647)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btn_signout)
        Me.Controls.Add(Me.btn_changepass)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button11)
        Me.Controls.Add(Me.btn_createclass)
        Me.Controls.Add(Me.listbox_subject)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.listbox_class)
        Me.Controls.Add(Me.listbox_room)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btn_manage_db)
        Me.Controls.Add(Me.listbox_section)
        Me.Controls.Add(Me.listbox_instructor)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "form_main"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button11 As Button
    Friend WithEvents btn_changepass As Button
    Friend WithEvents btn_signout As Button
    Friend WithEvents listbox_instructor As ListBox
    Friend WithEvents listbox_section As ListBox
    Friend WithEvents btn_manage_db As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btn_addsubject As Button
    Friend WithEvents btn_addroom As Button
    Friend WithEvents btn_addsection As Button
    Friend WithEvents btn_addinstructor As Button
    Friend WithEvents listbox_room As ListBox
    Friend WithEvents Button5 As Button
    Friend WithEvents listbox_subject As ListBox
    Friend WithEvents btn_createclass As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents listbox_class As ListBox
End Class
