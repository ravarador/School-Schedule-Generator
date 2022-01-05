<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class form_changepass
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtbox_newpass = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Lucida Console", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(156, 201)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(111, 51)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "CHANGE PASSWORD"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txtbox_newpass
        '
        Me.txtbox_newpass.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtbox_newpass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtbox_newpass.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbox_newpass.ForeColor = System.Drawing.Color.Black
        Me.txtbox_newpass.Location = New System.Drawing.Point(132, 106)
        Me.txtbox_newpass.MaxLength = 15
        Me.txtbox_newpass.Multiline = True
        Me.txtbox_newpass.Name = "txtbox_newpass"
        Me.txtbox_newpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtbox_newpass.Size = New System.Drawing.Size(200, 30)
        Me.txtbox_newpass.TabIndex = 3
        Me.txtbox_newpass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(178, 139)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 11)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "NEW PASSWORD"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.configuration_with_db.My.Resources.Resources.password_icon
        Me.PictureBox3.Location = New System.Drawing.Point(102, 106)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox3.TabIndex = 12
        Me.PictureBox3.TabStop = False
        '
        'Button11
        '
        Me.Button11.BackColor = System.Drawing.Color.LightSlateGray
        Me.Button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button11.Font = New System.Drawing.Font("Arimo", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button11.ForeColor = System.Drawing.Color.White
        Me.Button11.Location = New System.Drawing.Point(524, 9)
        Me.Button11.Margin = New System.Windows.Forms.Padding(0)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(23, 23)
        Me.Button11.TabIndex = 14
        Me.Button11.Text = "X"
        Me.Button11.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.txtbox_newpass)
        Me.Panel1.Location = New System.Drawing.Point(51, 39)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(428, 372)
        Me.Panel1.TabIndex = 15
        '
        'form_changepass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.BackgroundImage = Global.configuration_with_db.My.Resources.Resources.bg_changepass
        Me.ClientSize = New System.Drawing.Size(556, 450)
        Me.Controls.Add(Me.Button11)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "form_changepass"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "form_changepass"
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents txtbox_newpass As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Button11 As Button
    Friend WithEvents Panel1 As Panel
End Class
