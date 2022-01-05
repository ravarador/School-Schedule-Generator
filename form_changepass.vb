Imports System.Data.SQLite
Public Class form_changepass

    Dim loginDb As String = "loginDb.db"
    Dim connectionString As String = "Data Source=loginDb.Db;Version=3;"
    Dim ds As New DataSet
    Dim sqlite_conn As SQLiteConnection
    Dim sqlite_cmd As SQLiteCommand

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            sqlite_conn = New SQLiteConnection("Data Source=loginDb.db;Version=3;")

            ' open the connection
            sqlite_conn.Open()
            'verify user and pass

            sqlite_cmd = sqlite_conn.CreateCommand()
            'INSERT INTO DATABASE TABLE
            sqlite_cmd.CommandText = "UPDATE login_table SET login_pass='" & txtbox_newpass.Text & "' WHERE login_user='" & form_login.txtbox_user.Text & "';"
            sqlite_cmd.ExecuteNonQuery()
            sqlite_conn.Close()
            MessageBox.Show("Password changed successfully")

            txtbox_newpass.Text = ""
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Me.Dispose()
    End Sub

    Private Sub form_changepass_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Panel1.BackColor = Color.FromArgb(70, 255, 255, 255)
    End Sub

    Private Sub txtbox_pass_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Char.IsLetterOrDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtbox_pass_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub txtbox_user_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Char.IsLetterOrDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtbox_user_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbox_newpass.KeyPress
        If Char.IsLetterOrDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles txtbox_newpass.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
        End If
    End Sub


End Class