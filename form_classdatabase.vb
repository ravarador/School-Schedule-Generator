Imports System.Data.SQLite
Public Class form_classdatabase
    Dim connectionString As String = "Data Source=configDb.db;Version=3;"
    Dim sqlite_conn As SQLiteConnection
    Dim sqlite_cmd As SQLiteCommand

    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles button_close.Click
        Me.Close()
    End Sub

    Private Sub form_classdatabase_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim adapter As New SQLiteDataAdapter("SELECT * FROM Class_list", connectionString)
            Dim table As New DataTable()
            adapter.Fill(table)
            datagridview_class.DataSource = table
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub form_classdatabase_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        Try
            drag = True
            mousex = Windows.Forms.Cursor.Position.X - Me.Left
            mousey = Windows.Forms.Cursor.Position.Y - Me.Top
        Catch ex As Exception

        End Try
    End Sub

    Private Sub form_classdatabase_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        Try
            If drag Then
                Me.Top = Windows.Forms.Cursor.Position.Y - mousey
                Me.Left = Windows.Forms.Cursor.Position.X - mousex
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub form_classdatabase_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        Try
            drag = False
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_delall_Click(sender As Object, e As EventArgs) Handles btn_delall.Click
        Dim sqlite_conn As SQLiteConnection
        Dim sqlite_cmd As SQLiteCommand

        Try
            ' create a new database connection:
            sqlite_conn = New SQLiteConnection("Data Source=configDb.db;Version=3;")

            ' open the connection:
            sqlite_conn.Open()

            sqlite_cmd = sqlite_conn.CreateCommand()

            sqlite_cmd.CommandText = "DELETE FROM Class_list"
            sqlite_cmd.ExecuteNonQuery()
            sqlite_conn.Close()


        Catch ex As Exception

        End Try

        Try
            Dim adapter As New SQLiteDataAdapter("SELECT * FROM Class_list", connectionString)
            Dim table As New DataTable()
            adapter.Fill(table)
            datagridview_class.DataSource = table
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

        Try
            Dim adapter As New SQLiteDataAdapter("SELECT * FROM Class_list", connectionString)
            Dim table As New DataTable()
            adapter.Fill(table)
            form_main.listbox_class.DisplayMember = "prof_id"
            form_main.listbox_class.DataSource = table
        Catch ex As Exception
            MessageBox.Show("No table has been detected. Please create one." + Environment.NewLine + "MANAGE DATABASE --> Create Table")
        End Try
    End Sub

    Private Sub DELETEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DELETEToolStripMenuItem.Click
        Try
            Dim index As Integer
            index = datagridview_class.CurrentCell.RowIndex

            sqlite_conn = New SQLiteConnection("Data Source=configDb.db;Version=3;")

            ' open the connection:
            sqlite_conn.Open()

            sqlite_cmd = sqlite_conn.CreateCommand()
            'delete row
            sqlite_cmd.CommandText = "Delete from Class_list WHERE magic_id='" & datagridview_class(8, index).Value.ToString & "';"
            sqlite_cmd.ExecuteNonQuery()
            sqlite_conn.Close()
            ' delete the selected row
            datagridview_class.Rows.RemoveAt(index)

            Dim adapter As New SQLiteDataAdapter("SELECT * FROM Class_list", connectionString)
            Dim table As New DataTable()
            adapter.Fill(table)
            form_main.listbox_class.DisplayMember = "prof_id"
            form_main.listbox_class.DataSource = table
        Catch ex As Exception

        End Try
    End Sub

End Class