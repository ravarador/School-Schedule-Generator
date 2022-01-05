Imports System.Data.SQLite
Public Class form_addsection
    Dim connectionString As String = "Data Source=configDb.db;Version=3;"
    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Me.Dispose()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sqlite_conn As SQLiteConnection
        Dim sqlite_cmd As SQLiteCommand

        If (TextBox1.Text <> "" And TextBox2.Text <> "") Then
            Try
                'update datagridview
                Dim adapter As New SQLiteDataAdapter("SELECT * FROM Section_list", connectionString)
                Dim table As New DataTable()
                adapter.Fill(table)
                form_viewdatabase.datagridview_section.DataSource = table
                Try
                    ' create a new database connection:
                    sqlite_conn = New SQLiteConnection("Data Source=configDb.db;Version=3;")

                    ' open the connection:
                    sqlite_conn.Open()

                    sqlite_cmd = sqlite_conn.CreateCommand()

                    sqlite_cmd.CommandText = "INSERT INTO Section_list (section_name,section_size) VALUES ('" & TextBox1.Text & "','" & TextBox2.Text & "');"
                    sqlite_cmd.ExecuteNonQuery()
                    sqlite_conn.Close()
                    TextBox1.Text = ""
                    TextBox2.Text = ""

                Catch ex As Exception
                    MessageBox.Show("Section name already exists!")
                End Try

                'update datagridview
                Dim adapter3 As New SQLiteDataAdapter("SELECT * FROM Section_list", connectionString)
                Dim table3 As New DataTable()
                adapter.Fill(table3)
                form_viewdatabase.datagridview_section.DataSource = table3

                Dim adapter1 As New SQLiteDataAdapter("SELECT * FROM Section_list", connectionString)
                Dim table1 As New DataTable()
                adapter.Fill(table1)
                form_main.listbox_section.DisplayMember = "section_name"
                form_main.listbox_section.DataSource = table1


            Catch ex As Exception
                MessageBox.Show("No table has been detected. Please create one." + Environment.NewLine + "MANAGE DATABASE --> Create Table")
            End Try
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
        If Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
End Class