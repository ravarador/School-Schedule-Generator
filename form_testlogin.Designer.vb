<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class form_testlogin
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtbox_pass = New System.Windows.Forms.TextBox()
        Me.txtbox_user = New System.Windows.Forms.TextBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Coral
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.txtbox_user)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.txtbox_pass)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Location = New System.Drawing.Point(442, 42)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(262, 361)
        Me.Panel1.TabIndex = 0
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.configuration_with_db.My.Resources.Resources.password_icon
        Me.PictureBox2.Location = New System.Drawing.Point(7, 149)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox2.TabIndex = 13
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.configuration_with_db.My.Resources.Resources.username_icon
        Me.PictureBox1.Location = New System.Drawing.Point(7, 69)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(108, 182)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 11)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "PASSWORD"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(108, 102)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 11)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "USERNAME"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.GhostWhite
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button3.Location = New System.Drawing.Point(83, 277)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(111, 21)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "Create Account"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Lucida Console", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(83, 221)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(111, 51)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "LOG IN"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txtbox_pass
        '
        Me.txtbox_pass.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtbox_pass.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtbox_pass.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbox_pass.ForeColor = System.Drawing.Color.Black
        Me.txtbox_pass.Location = New System.Drawing.Point(37, 149)
        Me.txtbox_pass.MaxLength = 15
        Me.txtbox_pass.Multiline = True
        Me.txtbox_pass.Name = "txtbox_pass"
        Me.txtbox_pass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtbox_pass.Size = New System.Drawing.Size(200, 30)
        Me.txtbox_pass.TabIndex = 8
        Me.txtbox_pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtbox_user
        '
        Me.txtbox_user.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtbox_user.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtbox_user.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbox_user.ForeColor = System.Drawing.Color.Black
        Me.txtbox_user.Location = New System.Drawing.Point(37, 69)
        Me.txtbox_user.Margin = New System.Windows.Forms.Padding(9)
        Me.txtbox_user.MaxLength = 15
        Me.txtbox_user.Multiline = True
        Me.txtbox_user.Name = "txtbox_user"
        Me.txtbox_user.Size = New System.Drawing.Size(200, 30)
        Me.txtbox_user.TabIndex = 7
        Me.txtbox_user.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.configuration_with_db.My.Resources.Resources.amalogo_loginform
        Me.PictureBox3.Location = New System.Drawing.Point(-42, 42)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(478, 361)
        Me.PictureBox3.TabIndex = 1
        Me.PictureBox3.TabStop = False
        '
        'form_testlogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.configuration_with_db.My.Resources.Resources.background_for_login
        Me.ClientSize = New System.Drawing.Size(753, 450)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "form_testlogin"
        Me.Text = "form_testlogin"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents txtbox_user As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtbox_pass As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents PictureBox3 As PictureBox
End Class
