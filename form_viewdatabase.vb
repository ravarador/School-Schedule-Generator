Imports System.Data.SQLite
Public Class form_viewdatabase
    'Dim connection As New SQLiteConnection("Data Source=C:\Users\Fantech\source\repos\configuration_with_db\configuration_with_db\bin\Debug\configDb.db; Version=3;")
    Dim connectionString As String = "Data Source=configDb.db;Version=3;"
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Dim sqlite_conn As SQLiteConnection
    Dim sqlite_cmd As SQLiteCommand
    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Me.Close()
    End Sub


    Private Sub form_viewdatabase_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try

            Try
                Dim adapter As New SQLiteDataAdapter("SELECT * FROM Instructor_list", connectionString)
                Dim table As New DataTable()
                adapter.Fill(table)
                datagridview_instructor.DataSource = table
            Catch ex As Exception

            End Try

            Try
                Dim adapter As New SQLiteDataAdapter("SELECT * FROM Section_list", connectionString)
                Dim table As New DataTable()
                adapter.Fill(table)
                datagridview_section.DataSource = table
            Catch ex As Exception

            End Try

            Try
                Dim adapter As New SQLiteDataAdapter("SELECT * FROM Room_list", connectionString)
                Dim table As New DataTable()
                adapter.Fill(table)
                datagridview_room.DataSource = table
            Catch ex As Exception

            End Try

            Try
                Dim adapter As New SQLiteDataAdapter("SELECT * FROM Subject_list", connectionString)
                Dim table As New DataTable()
                adapter.Fill(table)
                datagridview_subject.DataSource = table
            Catch ex As Exception

            End Try
        Catch ex As Exception
            MessageBox.Show("Please create tables")
        End Try

    End Sub

    Private Sub btn_create_table_Click(sender As Object, e As EventArgs) Handles btn_create_table.Click
        Dim create_table As String = String.Empty
        Dim create_table2 As String = String.Empty
        Dim create_table3 As String = String.Empty
        Dim create_table4 As String = String.Empty
        Dim create_table5 As String = String.Empty
        Try
            create_table &= "CREATE TABLE IF NOT EXISTS Instructor_list (instructor_name TEXT UNIQUE NOT NULL)"
            create_table2 &= "CREATE TABLE IF NOT EXISTS Section_list (section_name TEXT UNIQUE NOT NULL, section_size INT NOT NULL)"
            create_table3 &= "CREATE TABLE IF NOT EXISTS Room_list (room_name TEXT UNIQUE NOT NULL, room_type TEXT NOT NULL, room_capacity INT NOT NULL)"
            create_table4 &= "CREATE TABLE IF NOT EXISTS Subject_list (subject_name TEXT UNIQUE NOT NULL)"
            create_table5 &= "CREATE TABLE IF NOT EXISTS Class_list (prof_id TEXT NOT NULL,prof_name TEXT NOT NULL, course_id TEXT NOT NULL, course_name NOT NULL, duration TEXT NOT NULL, group_id TEXT NOT NULL, group_name TEXT NOT NULL, lab TEXT NOT NULL, magic_id INTEGER PRIMARY KEY NOT NULL)"

        Catch ex As Exception

        End Try


        Try
            Using con As New SQLiteConnection(connectionString)
                con.Open()
                Using cmd As New SQLiteCommand(create_table, con)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Using con As New SQLiteConnection(connectionString)
                con.Open()
                Using cmd As New SQLiteCommand(create_table2, con)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Using con As New SQLiteConnection(connectionString)
                con.Open()
                Using cmd As New SQLiteCommand(create_table3, con)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Using con As New SQLiteConnection(connectionString)
                con.Open()
                Using cmd As New SQLiteCommand(create_table4, con)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Using con As New SQLiteConnection(connectionString)
                con.Open()
                Using cmd As New SQLiteCommand(create_table5, con)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            MessageBox.Show("Table created successfully")

            Try
                Dim adapter As New SQLiteDataAdapter("SELECT * FROM Instructor_list", connectionString)
                Dim table As New DataTable()
                adapter.Fill(table)
                datagridview_instructor.DataSource = table
            Catch ex As Exception

            End Try

            Try
                Dim adapter As New SQLiteDataAdapter("SELECT * FROM Section_list", connectionString)
                Dim table As New DataTable()
                adapter.Fill(table)
                datagridview_section.DataSource = table
            Catch ex As Exception

            End Try

            Try
                Dim adapter As New SQLiteDataAdapter("SELECT * FROM Room_list", connectionString)
                Dim table As New DataTable()
                adapter.Fill(table)
                datagridview_room.DataSource = table
            Catch ex As Exception

            End Try

            Try
                Dim adapter As New SQLiteDataAdapter("SELECT * FROM Subject_list", connectionString)
                Dim table As New DataTable()
                adapter.Fill(table)
                datagridview_subject.DataSource = table
            Catch ex As Exception

            End Try

            Try
                Dim adapter As New SQLiteDataAdapter("SELECT * FROM Class_list", connectionString)
                Dim table As New DataTable()
                adapter.Fill(table)
                form_classdatabase.datagridview_class.DataSource = table
            Catch ex As Exception

            End Try

        Catch ex As Exception
            MessageBox.Show("create table failed")
        End Try

    End Sub

    Private Sub form_viewdatabase_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        Try
            drag = True
            mousex = Windows.Forms.Cursor.Position.X - Me.Left
            mousey = Windows.Forms.Cursor.Position.Y - Me.Top
        Catch ex As Exception

        End Try

    End Sub

    Private Sub form_viewdatabase_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        Try
            If drag Then
                Me.Top = Windows.Forms.Cursor.Position.Y - mousey
                Me.Left = Windows.Forms.Cursor.Position.X - mousex
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub form_viewdatabase_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        Try
            drag = False
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btn_delall_instructor_Click(sender As Object, e As EventArgs) Handles btn_delall_instructor.Click
        Try
            Dim sqlite_conn As SQLiteConnection
            Dim sqlite_cmd As SQLiteCommand

            Try
                ' create a new database connection:
                sqlite_conn = New SQLiteConnection("Data Source=configDb.db;Version=3;")

                ' open the connection:
                sqlite_conn.Open()

                sqlite_cmd = sqlite_conn.CreateCommand()

                sqlite_cmd.CommandText = "DELETE FROM Instructor_list"
                sqlite_cmd.ExecuteNonQuery()
                sqlite_conn.Close()


            Catch ex As Exception

            End Try

            Try
                Dim adapter As New SQLiteDataAdapter("SELECT * FROM Instructor_list", connectionString)
                Dim table As New DataTable()
                adapter.Fill(table)
                datagridview_instructor.DataSource = table
            Catch ex As Exception

            End Try

            Try
                Dim adapter As New SQLiteDataAdapter("SELECT * FROM Instructor_list", connectionString)
                Dim table As New DataTable()
                adapter.Fill(table)
                form_main.listbox_instructor.DisplayMember = "instructor_name"
                form_main.listbox_instructor.DataSource = table
            Catch ex As Exception

            End Try
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_delall_section_Click(sender As Object, e As EventArgs) Handles btn_delall_section.Click
        Try
            Dim sqlite_conn As SQLiteConnection
            Dim sqlite_cmd As SQLiteCommand

            Try
                ' create a new database connection:
                sqlite_conn = New SQLiteConnection("Data Source=configDb.db;Version=3;")

                ' open the connection:
                sqlite_conn.Open()

                sqlite_cmd = sqlite_conn.CreateCommand()

                sqlite_cmd.CommandText = "DELETE FROM Section_list"
                sqlite_cmd.ExecuteNonQuery()
                sqlite_conn.Close()


            Catch ex As Exception

            End Try

            Try
                Dim adapter As New SQLiteDataAdapter("SELECT * FROM Section_list", connectionString)
                Dim table As New DataTable()
                adapter.Fill(table)
                datagridview_section.DataSource = table
            Catch ex As Exception

            End Try

            Try
                Dim adapter As New SQLiteDataAdapter("SELECT * FROM Section_list", connectionString)
                Dim table As New DataTable()
                adapter.Fill(table)
                form_main.listbox_section.DisplayMember = "section_name"
                form_main.listbox_section.DataSource = table
            Catch ex As Exception

            End Try
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btn_delall_room_Click(sender As Object, e As EventArgs) Handles btn_delall_room.Click
        Try
            Dim sqlite_conn As SQLiteConnection
            Dim sqlite_cmd As SQLiteCommand

            Try
                ' create a new database connection:
                sqlite_conn = New SQLiteConnection("Data Source=configDb.db;Version=3;")

                ' open the connection:
                sqlite_conn.Open()

                sqlite_cmd = sqlite_conn.CreateCommand()

                sqlite_cmd.CommandText = "DELETE FROM Room_list"
                sqlite_cmd.ExecuteNonQuery()
                sqlite_conn.Close()


            Catch ex As Exception

            End Try

            Try
                Dim adapter As New SQLiteDataAdapter("SELECT * FROM Room_list", connectionString)
                Dim table As New DataTable()
                adapter.Fill(table)
                datagridview_room.DataSource = table
            Catch ex As Exception

            End Try

            Try
                Dim adapter As New SQLiteDataAdapter("SELECT * FROM Room_list", connectionString)
                Dim table As New DataTable()
                adapter.Fill(table)
                form_main.listbox_room.DisplayMember = "room_name"
                form_main.listbox_room.DataSource = table
            Catch ex As Exception

            End Try
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btn_delall_subject_Click(sender As Object, e As EventArgs) Handles btn_delall_subject.Click
        Try
            Dim sqlite_conn As SQLiteConnection
            Dim sqlite_cmd As SQLiteCommand

            Try
                ' create a new database connection:
                sqlite_conn = New SQLiteConnection("Data Source=configDb.db;Version=3;")

                ' open the connection:
                sqlite_conn.Open()

                sqlite_cmd = sqlite_conn.CreateCommand()

                sqlite_cmd.CommandText = "DELETE FROM Subject_list"
                sqlite_cmd.ExecuteNonQuery()
                sqlite_conn.Close()


            Catch ex As Exception

            End Try

            Try
                Dim adapter As New SQLiteDataAdapter("SELECT * FROM Subject_list", connectionString)
                Dim table As New DataTable()
                adapter.Fill(table)
                datagridview_subject.DataSource = table
            Catch ex As Exception

            End Try

            Try
                Dim adapter As New SQLiteDataAdapter("SELECT * FROM Subject_list", connectionString)
                Dim table As New DataTable()
                adapter.Fill(table)
                form_main.listbox_subject.DisplayMember = "subject_name"
                form_main.listbox_subject.DataSource = table
            Catch ex As Exception

            End Try
        Catch ex As Exception

        End Try

    End Sub

    Private Sub DELETEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DELETEToolStripMenuItem.Click
        Try
            Dim index As Integer
            index = datagridview_instructor.CurrentCell.RowIndex

            sqlite_conn = New SQLiteConnection("Data Source=configDb.db;Version=3;")

            ' open the connection:
            sqlite_conn.Open()

            sqlite_cmd = sqlite_conn.CreateCommand()
            'delete row
            sqlite_cmd.CommandText = "Delete from Instructor_list WHERE instructor_name='" & datagridview_instructor(0, index).Value.ToString & "';"
            sqlite_cmd.ExecuteNonQuery()
            sqlite_conn.Close()
            ' delete the selected row
            datagridview_instructor.Rows.RemoveAt(index)

            Dim adapter As New SQLiteDataAdapter("SELECT * FROM Instructor_list", connectionString)
            Dim table As New DataTable()
            adapter.Fill(table)
            form_main.listbox_instructor.DisplayMember = "instructor_name"
            form_main.listbox_instructor.DataSource = table
        Catch ex As Exception

        End Try

    End Sub

    Private Sub DELETEToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DELETEToolStripMenuItem1.Click
        Try
            Dim index As Integer
            index = datagridview_section.CurrentCell.RowIndex

            sqlite_conn = New SQLiteConnection("Data Source=configDb.db;Version=3;")

            ' open the connection:
            sqlite_conn.Open()

            sqlite_cmd = sqlite_conn.CreateCommand()
            'delete row
            sqlite_cmd.CommandText = "Delete from Section_list WHERE section_name='" & datagridview_section(0, index).Value.ToString & "';"
            sqlite_cmd.ExecuteNonQuery()
            sqlite_conn.Close()
            ' delete the selected row
            datagridview_section.Rows.RemoveAt(index)

            Dim adapter As New SQLiteDataAdapter("SELECT * FROM Section_list", connectionString)
            Dim table As New DataTable()
            adapter.Fill(table)
            form_main.listbox_section.DisplayMember = "section_name"
            form_main.listbox_section.DataSource = table
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DELETEToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles DELETEToolStripMenuItem2.Click
        Try
            Dim index As Integer
            index = datagridview_room.CurrentCell.RowIndex

            sqlite_conn = New SQLiteConnection("Data Source=configDb.db;Version=3;")

            ' open the connection:
            sqlite_conn.Open()

            sqlite_cmd = sqlite_conn.CreateCommand()
            'delete row
            sqlite_cmd.CommandText = "Delete from Room_list WHERE room_name='" & datagridview_room(0, index).Value.ToString & "';"
            sqlite_cmd.ExecuteNonQuery()
            sqlite_conn.Close()
            ' delete the selected row
            datagridview_room.Rows.RemoveAt(index)

            Dim adapter As New SQLiteDataAdapter("SELECT * FROM Room_list", connectionString)
            Dim table As New DataTable()
            adapter.Fill(table)
            form_main.listbox_room.DisplayMember = "room_name"
            form_main.listbox_room.DataSource = table
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DELETEToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles DELETEToolStripMenuItem3.Click
        Try
            Dim index As Integer
            index = datagridview_subject.CurrentCell.RowIndex

            sqlite_conn = New SQLiteConnection("Data Source=configDb.db;Version=3;")

            ' open the connection:
            sqlite_conn.Open()

            sqlite_cmd = sqlite_conn.CreateCommand()
            'delete row
            sqlite_cmd.CommandText = "Delete from Subject_list WHERE subject_name='" & datagridview_subject(0, index).Value.ToString & "';"
            sqlite_cmd.ExecuteNonQuery()
            sqlite_conn.Close()
            ' delete the selected row
            datagridview_subject.Rows.RemoveAt(index)

            Dim adapter As New SQLiteDataAdapter("SELECT * FROM Subject_list", connectionString)
            Dim table As New DataTable()
            adapter.Fill(table)
            form_main.listbox_subject.DisplayMember = "subject_name"
            form_main.listbox_subject.DataSource = table
        Catch ex As Exception

        End Try
    End Sub


End Class