Imports System.Data.SQLite

Public Class form_addinstructor
    Dim connectionString As String = "Data Source=configDb.db;Version=3;"
    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Me.Dispose()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim sqlite_conn As SQLiteConnection
        Dim sqlite_cmd As SQLiteCommand


        If (TextBox1.Text <> "") Then
                Try
                    'UPDATE THE DATAGRID VIEW
                    Dim adapter As New SQLiteDataAdapter("SELECT * FROM Instructor_list", connectionString)
                    Dim table As New DataTable()
                    adapter.Fill(table)
                    form_viewdatabase.datagridview_instructor.DataSource = table

                Try
                    ' create a new database connection:
                    sqlite_conn = New SQLiteConnection("Data Source=configDb.db;Version=3;")

                    ' open the connection:
                    sqlite_conn.Open()

                    sqlite_cmd = sqlite_conn.CreateCommand()
                    'INSERT INTO DATABASE TABLE
                    sqlite_cmd.CommandText = "INSERT INTO Instructor_list (instructor_name) VALUES ('" & TextBox1.Text & "');"
                    sqlite_cmd.ExecuteNonQuery()
                    sqlite_conn.Close()

                    TextBox1.Text = ""

                Catch ex As Exception

                    MessageBox.Show("Instructor name already exists!")

                End Try

                'UPDATE THE DATAGRID VIEW
                Dim adapter3 As New SQLiteDataAdapter("SELECT * FROM Instructor_list", connectionString)
                    Dim table3 As New DataTable()
                    adapter.Fill(table3)
                    form_viewdatabase.datagridview_instructor.DataSource = table3

                    'FILL THE LISTBOX WITH DATAGRID ITEMS
                    Dim adapter1 As New SQLiteDataAdapter("SELECT * FROM Instructor_list", connectionString)
                    Dim table1 As New DataTable()
                    adapter.Fill(table1)
                    form_main.listbox_instructor.DisplayMember = "instructor_name"
                    form_main.listbox_instructor.DataSource = table1

                Catch ex As Exception
                    MessageBox.Show("No table has been detected. Please create one." + Environment.NewLine + "MANAGE DATABASE --> Create Table")
                End Try

            End If


    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub


End Class