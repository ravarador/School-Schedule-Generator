Imports System.Data.SQLite
Public Class form_addroom
    Dim connectionString As String = "Data Source=configDb.db;Version=3;"
    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Me.Dispose()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sqlite_conn As SQLiteConnection
        Dim sqlite_cmd As SQLiteCommand
        Dim t As String
        Dim f As String
        t = "true"
        f = "false"

        If (TextBox1.Text <> "" And TextBox2.Text <> "") Then
            Try
                'update datagridview
                Dim adapter As New SQLiteDataAdapter("SELECT * FROM Room_list", connectionString)
                Dim table As New DataTable()
                adapter.Fill(table)
                form_viewdatabase.datagridview_room.DataSource = table

                Try
                    ' create a new database connection:
                    sqlite_conn = New SQLiteConnection("Data Source=configDb.db;Version=3;")

                    ' open the connection:
                    sqlite_conn.Open()

                    sqlite_cmd = sqlite_conn.CreateCommand()
                    If CheckBox1.Checked = True Then
                        sqlite_cmd.CommandText = "INSERT INTO Room_list (room_name,room_type,room_capacity) VALUES ('" & TextBox1.Text & "', '" & t & "', '" & TextBox2.Text & "');"
                        sqlite_cmd.ExecuteNonQuery()
                        sqlite_conn.Close()
                    ElseIf CheckBox1.Checked = False Then
                        sqlite_cmd.CommandText = "INSERT INTO Room_list (room_name,room_type,room_capacity) VALUES ('" & TextBox1.Text & "', '" & f & "', '" & TextBox2.Text & "');"
                        sqlite_cmd.ExecuteNonQuery()
                        sqlite_conn.Close()
                    End If

                    TextBox1.Text = ""
                    TextBox2.Text = ""

                Catch ex As Exception
                    MessageBox.Show("Room name already exists!")
                End Try

                'update datagridview
                Dim adapter3 As New SQLiteDataAdapter("SELECT * FROM Room_list", connectionString)
                Dim table3 As New DataTable()
                adapter.Fill(table3)
                form_viewdatabase.datagridview_room.DataSource = table3


                'update listbox
                Dim adapter1 As New SQLiteDataAdapter("SELECT * FROM Room_list", connectionString)
                Dim table1 As New DataTable()
                adapter.Fill(table1)
                form_main.listbox_room.DisplayMember = "room_name"
                form_main.listbox_room.DataSource = table1

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