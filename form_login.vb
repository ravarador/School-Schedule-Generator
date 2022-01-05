Imports System.Data.SQLite
Public Class form_login

    Dim loginDb As String = "loginDb.db"
    Dim connectionString As String = "Data Source=loginDb.Db;Version=3;"

    Dim ds As New DataSet
    Dim create_table As String = String.Empty
    Dim sqlite_conn As SQLiteConnection
    Dim sqlite_cmd As SQLiteCommand
    Dim query As string
    Public Sub create_sqlite_database()
        If Not My.Computer.FileSystem.FileExists("loginDb.db") Then

            Try

                SQLiteConnection.CreateFile(loginDb)
                MessageBox.Show("Database for LOGIN has been created.")

            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub form_login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            connectionString = String.Format(connectionString, loginDb)
            create_sqlite_database()
            create_table &= "CREATE TABLE IF NOT EXISTS login_table (login_user TEXT UNIQUE NOT NULL, login_pass TEXT NOT NULL)"
            Try
                Using con As New SQLiteConnection(connectionString)
                    con.Open()
                    Using cmd As New SQLiteCommand(create_table, con)
                        cmd.ExecuteNonQuery()
                    End Using
                End Using
            Catch ex As Exception

            End Try
        Catch ex As Exception

        End Try

    End Sub

    Public Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If (txtbox_user.Text <> "" And txtbox_pass.Text <> "") Then
                sqlite_conn = New SQLiteConnection("Data Source=loginDb.db;Version=3;")

                ' open the connection
                sqlite_conn.Open()
                Dim x As Integer
                'verify user and pass
                Dim adapter As New SQLiteDataAdapter("SELECT * FROM login_table WHERE login_user = '" & txtbox_user.Text & "' AND login_pass = '" & txtbox_pass.Text & "'", connectionString)

                adapter.Fill(ds, "login_table")
                x = ds.Tables("login_table").Rows.Count
                If x <> 0 Then

                    form_main.Show()
                    Me.Hide()
                    txtbox_pass.Text = ""
                    ds.Clear()
                Else
                    MessageBox.Show("Invalid user name and password", "Access denied", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtbox_pass.Text = ""
                    txtbox_pass.Focus()
                End If

                sqlite_conn.Close()
            Else
                MessageBox.Show("Incomplete form!")
            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        txtbox_create.Visible = True
        Button3.Visible = False

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Do
            Panel2.Width = Panel2.Width - 2
        Loop Until Panel2.Width = 0
        txtbox_create.Visible = False
        Button3.Visible = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Try
            If TextBox1.Text <> "" And TextBox2.Text <> "" Then
                If TextBox2.Text.Length > 7 Then
                    sqlite_conn = New SQLiteConnection("Data Source=loginDb.db;Version=3;")

                    ' open the connection:
                    sqlite_conn.Open()

                    sqlite_cmd = sqlite_conn.CreateCommand()
                    'INSERT INTO DATABASE TABLE
                    sqlite_cmd.CommandText = "INSERT INTO login_table (login_user,login_pass) VALUES ('" & TextBox1.Text & "','" & TextBox2.Text & "');"
                    sqlite_cmd.ExecuteNonQuery()
                    sqlite_conn.Close()
                    MessageBox.Show("User Created!")
                    TextBox1.Text = ""
                    TextBox2.Text = ""
                    txtbox_create.Visible = False
                    Button3.Visible = True
                    Do
                        Panel2.Width = Panel2.Width - 2
                    Loop Until Panel2.Width = 0
                Else
                    MessageBox.Show("Please input at least 8 characters!")
                End If
            Else
                MessageBox.Show("Incomplete form!")
            End If
        Catch ex As Exception
            MessageBox.Show("Username/Password already exists")
        End Try


    End Sub


    Private Sub txtbox_pass_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbox_pass.KeyPress
        If Char.IsLetterOrDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtbox_pass_KeyDown(sender As Object, e As KeyEventArgs) Handles txtbox_pass.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub txtbox_user_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbox_user.KeyPress
        If Char.IsLetterOrDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtbox_user_KeyDown(sender As Object, e As KeyEventArgs) Handles txtbox_user.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If Char.IsLetterOrDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If Char.IsLetterOrDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub TextBox2_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox2.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Application.Exit()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)

        form_changepass.ShowDialog()
    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs)
        form_changepass.ShowDialog()
    End Sub

    Private Sub txtbox_create_TextChanged(sender As Object, e As EventArgs) Handles txtbox_create.TextChanged
        If txtbox_create.Text = "admin" Then
            Do
                Panel2.Width = Panel2.Width + 2
            Loop Until Panel2.Width = 282
            txtbox_create.Text = ""
        End If
    End Sub

    Private Sub txtbox_create_MouseLeave(sender As Object, e As EventArgs) Handles txtbox_create.MouseLeave
        txtbox_create.Visible = False
        Button3.Visible = True
    End Sub


End Class