<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class form_login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_login))
        Me.txtbox_user = New System.Windows.Forms.TextBox()
        Me.txtbox_pass = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtbox_create = New System.Windows.Forms.TextBox()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtbox_user
        '
        Me.txtbox_user.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtbox_user.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtbox_user.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbox_user.ForeColor = System.Drawing.Color.Black
        Me.txtbox_user.Location = New System.Drawing.Point(565, 122)
        Me.txtbox_user.Margin = New System.Windows.Forms.Padding(9)
        Me.txtbox_user.MaxLength = 15
        Me.txtbox_user.Multiline = True
        Me.txtbox_user.Name = "txtbox_user"
        Me.txtbox_user.Size = New System.Drawing.Size(200, 30)
        Me.txtbox_user.TabIndex = 1
        Me.txtbox_user.TabStop = False
        Me.txtbox_user.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtbox_pass
        '
        Me.txtbox_pass.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtbox_pass.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtbox_pass.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbox_pass.ForeColor = System.Drawing.Color.Black
        Me.txtbox_pass.Location = New System.Drawing.Point(565, 202)
        Me.txtbox_pass.MaxLength = 15
        Me.txtbox_pass.Multiline = True
        Me.txtbox_pass.Name = "txtbox_pass"
        Me.txtbox_pass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtbox_pass.Size = New System.Drawing.Size(200, 30)
        Me.txtbox_pass.TabIndex = 2
        Me.txtbox_pass.TabStop = False
        Me.txtbox_pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Lucida Console", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(611, 274)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(111, 51)
        Me.Button1.TabIndex = 3
        Me.Button1.TabStop = False
        Me.Button1.Text = "LOG IN"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.Black
        Me.TextBox1.Location = New System.Drawing.Point(57, 122)
        Me.TextBox1.MaxLength = 15
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(200, 30)
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.TabStop = False
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.White
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.ForeColor = System.Drawing.Color.Black
        Me.TextBox2.Location = New System.Drawing.Point(57, 202)
        Me.TextBox2.MaxLength = 15
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox2.Size = New System.Drawing.Size(200, 30)
        Me.TextBox2.TabIndex = 2
        Me.TextBox2.TabStop = False
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Lucida Console", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(106, 274)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(111, 50)
        Me.Button2.TabIndex = 3
        Me.Button2.TabStop = False
        Me.Button2.Text = "REGISTER"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(104, 155)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 11)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "CREATE USERNAME"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(104, 235)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 11)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "CREATE PASSWORD"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.GhostWhite
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button3.Location = New System.Drawing.Point(611, 332)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(111, 21)
        Me.Button3.TabIndex = 5
        Me.Button3.TabStop = False
        Me.Button3.Text = "Create Account"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.TextBox2)
        Me.Panel2.Controls.Add(Me.Button4)
        Me.Panel2.Controls.Add(Me.TextBox1)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Location = New System.Drawing.Point(508, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(0, 450)
        Me.Panel2.TabIndex = 4
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Ivory
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Location = New System.Drawing.Point(259, 3)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(21, 21)
        Me.Button4.TabIndex = 2
        Me.Button4.TabStop = False
        Me.Button4.Text = "X"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label5.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(0, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 11)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "REGISTRATION"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(636, 155)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 11)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "USERNAME"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(636, 235)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 11)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "PASSWORD"
        '
        'Button11
        '
        Me.Button11.BackColor = System.Drawing.Color.LightSlateGray
        Me.Button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button11.Font = New System.Drawing.Font("Arimo", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button11.ForeColor = System.Drawing.Color.White
        Me.Button11.Location = New System.Drawing.Point(765, 3)
        Me.Button11.Margin = New System.Windows.Forms.Padding(0)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(23, 23)
        Me.Button11.TabIndex = 7
        Me.Button11.TabStop = False
        Me.Button11.Text = "X"
        Me.Button11.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.configuration_with_db.My.Resources.Resources.password_icon
        Me.PictureBox2.Location = New System.Drawing.Point(535, 202)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox2.TabIndex = 6
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.configuration_with_db.My.Resources.Resources.username_icon
        Me.PictureBox1.Location = New System.Drawing.Point(535, 122)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightBlue
        Me.Panel1.BackgroundImage = Global.configuration_with_db.My.Resources.Resources.amalogo_loginform
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(510, 450)
        Me.Panel1.TabIndex = 3
        '
        'txtbox_create
        '
        Me.txtbox_create.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbox_create.Location = New System.Drawing.Point(614, 332)
        Me.txtbox_create.MaxLength = 8
        Me.txtbox_create.Name = "txtbox_create"
        Me.txtbox_create.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtbox_create.Size = New System.Drawing.Size(100, 20)
        Me.txtbox_create.TabIndex = 8
        Me.txtbox_create.TabStop = False
        Me.txtbox_create.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtbox_create.Visible = False
        '
        'form_login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(790, 450)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtbox_pass)
        Me.Controls.Add(Me.txtbox_user)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button11)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.txtbox_create)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "form_login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "form_login"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtbox_user As TextBox
    Friend WithEvents txtbox_pass As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button4 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button11 As Button
    Friend WithEvents txtbox_create As TextBox
End Class
