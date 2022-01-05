Imports System.Data.SQLite
Public Class form_main
    Dim sqlite_conn As SQLiteConnection
    Dim configDb As String = "configDb.db"
    Dim connectionString As String = "Data Source={0};Version=3;"
    Dim a As Integer
    Dim i As Integer
    Public Sub create_sqlite_database()
        If Not My.Computer.FileSystem.FileExists("configDb.db") Then

            Try
                SQLiteConnection.CreateFile(configDb)

                MessageBox.Show("Database for LIST has been created.")

            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub form_main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        connectionString = String.Format(connectionString, configDb)
        create_sqlite_database()
        Try
            Try
                Dim adapter As New SQLiteDataAdapter("SELECT * FROM Instructor_list", connectionString)
                Dim table As New DataTable()
                adapter.Fill(table)
                listbox_instructor.DisplayMember = "instructor_name"
                listbox_instructor.DataSource = table
            Catch ex As Exception

            End Try

            Try
                Dim adapter As New SQLiteDataAdapter("SELECT * FROM Section_list", connectionString)
                Dim table As New DataTable()
                adapter.Fill(table)
                listbox_section.DisplayMember = "section_name"
                listbox_section.DataSource = table
            Catch ex As Exception

            End Try

            Try
                Dim adapter As New SQLiteDataAdapter("SELECT * FROM Room_list", connectionString)
                Dim table As New DataTable()
                adapter.Fill(table)
                listbox_room.DisplayMember = "room_name"
                listbox_room.DataSource = table
            Catch ex As Exception

            End Try

            Try
                Dim adapter As New SQLiteDataAdapter("SELECT * FROM Subject_list", connectionString)
                Dim table As New DataTable()
                adapter.Fill(table)
                listbox_subject.DisplayMember = "subject_name"
                listbox_subject.DataSource = table
            Catch ex As Exception
                MessageBox.Show("No table has been detected. Please create one." + Environment.NewLine + "MANAGE DATABASE --> Create Table")
            End Try

            Try
                Dim adapter As New SQLiteDataAdapter("SELECT * FROM Class_list", connectionString)
                Dim table As New DataTable()
                adapter.Fill(table)
                listbox_class.DisplayMember = "prof_id"
                listbox_class.DataSource = table
            Catch ex As Exception
                MessageBox.Show("No table has been detected. Please create one." + Environment.NewLine + "MANAGE DATABASE --> Create Table")
            End Try

            Try
                Dim adapter As New SQLiteDataAdapter("SELECT * FROM Class_list", connectionString)
                Dim table As New DataTable()
                adapter.Fill(table)
                form_classdatabase.datagridview_class.DataSource = table
            Catch ex As Exception

            End Try
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btn_manage_db_Click(sender As Object, e As EventArgs) Handles btn_manage_db.Click
        form_viewdatabase.Show()

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Application.Exit()

    End Sub

    Private Sub btn_addinstructor_Click(sender As Object, e As EventArgs) Handles btn_addinstructor.Click
        form_addinstructor.ShowDialog()

    End Sub

    Private Sub btn_addsection_Click(sender As Object, e As EventArgs) Handles btn_addsection.Click
        form_addsection.ShowDialog()
    End Sub

    Private Sub btn_addroom_Click(sender As Object, e As EventArgs) Handles btn_addroom.Click
        form_addroom.ShowDialog()
    End Sub

    Private Sub btn_addsubject_Click(sender As Object, e As EventArgs) Handles btn_addsubject.Click
        form_addsubject.ShowDialog()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim validate_instructor As Integer
        Dim validate_subject As Integer
        Dim validate_section As Integer
        Dim validate_room As Integer
        validate_instructor = listbox_instructor.SelectedIndex.ToString + 1 'IT COUNTS HOW MANY INDICES ARE THERE IN THE LIST BOX
        validate_subject = listbox_subject.SelectedIndex.ToString + 1
        validate_section = listbox_section.SelectedIndex.ToString + 1
        validate_room = listbox_room.Items.Count

        If validate_instructor > 0 And validate_subject > 0 And validate_section > 0 And validate_room > 0 Then

            Try
                'Temporary or maybe permanent solution
                Dim dirPath As String = My.Application.Info.DirectoryPath
                My.Computer.FileSystem.CurrentDirectory = dirPath 'Directory where the config file will be created
                My.Computer.FileSystem.DeleteFile(dirPath + "\SchedGenConfig.cfg") 'Delete the file if the file exists. 
            Catch
                'Do nothing
            End Try
            form_viewdatabase.Show()
            form_classdatabase.Show()
            Dim count As Integer

            Try

                For i = 0 To listbox_instructor.Items.Count - 1
                    'Do stuff
                    'Label2.Text = form_viewdatabase.datagridview_instructor(0, i).Value
                    count = i + 1

                    Dim file As System.IO.StreamWriter
                    Dim dirPath As String = My.Application.Info.DirectoryPath
                    My.Computer.FileSystem.CurrentDirectory = dirPath 'Directory where the config file will be created
                    file = My.Computer.FileSystem.OpenTextFileWriter("SchedGenConfig.cfg", True)
                    file.WriteLine("")
                    file.WriteLine("#prof")
                    file.WriteLine("    id = " + count.ToString)
                    file.WriteLine("    name = " + form_viewdatabase.datagridview_instructor(0, i).Value.ToString)
                    file.WriteLine("#end")
                    file.Close()

                Next

                count = 0

                For i = 0 To listbox_subject.Items.Count - 1
                    'Do stuff
                    'Label2.Text = form_viewdatabase.datagridview_instructor(0, i).Value
                    count = i + 1

                    Dim file As System.IO.StreamWriter
                    Dim dirPath As String = My.Application.Info.DirectoryPath
                    My.Computer.FileSystem.CurrentDirectory = dirPath 'Directory where the config file will be created
                    file = My.Computer.FileSystem.OpenTextFileWriter("SchedGenConfig.cfg", True)
                    file.WriteLine("")
                    file.WriteLine("#course")
                    file.WriteLine("    id = " + count.ToString)
                    file.WriteLine("    name = " + form_viewdatabase.datagridview_subject(0, i).Value.ToString)
                    file.WriteLine("#end")
                    file.Close()

                Next

                count = 0

                For i = 0 To listbox_room.Items.Count - 1
                    'Do stuff
                    'Label2.Text = form_viewdatabase.datagridview_instructor(0, i).Value
                    count = i + 1

                    Dim file As System.IO.StreamWriter
                    Dim dirPath As String = My.Application.Info.DirectoryPath
                    My.Computer.FileSystem.CurrentDirectory = dirPath 'Directory where the config file will be created
                    file = My.Computer.FileSystem.OpenTextFileWriter("SchedGenConfig.cfg", True)
                    file.WriteLine("")
                    file.WriteLine("#room")
                    file.WriteLine("    name = " + form_viewdatabase.datagridview_room(0, i).Value.ToString)
                    file.WriteLine("    lab = " + form_viewdatabase.datagridview_room(1, i).Value.ToString)
                    file.WriteLine("    size = " + form_viewdatabase.datagridview_room(2, i).Value.ToString)
                    file.WriteLine("#end")
                    file.Close()

                Next

                count = 0

                For i = 0 To listbox_section.Items.Count - 1

                    'Do stuff
                    'Label2.Text = form_viewdatabase.datagridview_instructor(0, i).Value
                    count = i + 1

                    Dim file As System.IO.StreamWriter
                    Dim dirPath As String = My.Application.Info.DirectoryPath
                    My.Computer.FileSystem.CurrentDirectory = dirPath 'Directory where the config file will be created
                    file = My.Computer.FileSystem.OpenTextFileWriter("SchedGenConfig.cfg", True)
                    file.WriteLine("")
                    file.WriteLine("#group")
                    file.WriteLine("    id = " + count.ToString)
                    file.WriteLine("    name = " + form_viewdatabase.datagridview_section(0, i).Value.ToString)
                    file.WriteLine("    size = " + form_viewdatabase.datagridview_section(1, i).Value.ToString)
                    file.WriteLine("#end")
                    file.Close()

                Next







                i = 0
                Do
                    Dim file As System.IO.StreamWriter
                    Dim dirPath As String = My.Application.Info.DirectoryPath
                    My.Computer.FileSystem.CurrentDirectory = dirPath 'Directory where the config file will be created
                    file = My.Computer.FileSystem.OpenTextFileWriter("SchedGenConfig.cfg", True)
                    file.WriteLine("")
                    file.WriteLine("#class")
                    file.WriteLine("    professor = " + form_classdatabase.datagridview_class(0, i).Value.ToString())
                    file.WriteLine("    course = " + form_classdatabase.datagridview_class(2, i).Value.ToString)
                    file.WriteLine("    group = " + form_classdatabase.datagridview_class(5, i).Value.ToString)
                    file.WriteLine("    duration = " + form_classdatabase.datagridview_class(4, i).Value.ToString)
                    file.WriteLine("    lab = " + form_classdatabase.datagridview_class(7, i).Value.ToString)
                    file.WriteLine("#end")
                    file.Close()
                    i = i + 1
                Loop While i < listbox_class.Items.Count
            Catch ex As Exception

            End Try



            form_classdatabase.Close()
            form_viewdatabase.Close()
        End If


    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs)

        Try
            Dim adapter As New SQLiteDataAdapter("SELECT * FROM Instructor_list", connectionString)
            Dim table As New DataTable()
            adapter.Fill(table)
            listbox_instructor.DisplayMember = "instructor_name"
            listbox_instructor.DataSource = table
        Catch ex As Exception

        End Try

        Try
            Dim adapter As New SQLiteDataAdapter("SELECT * FROM Section_list", connectionString)
            Dim table As New DataTable()
            adapter.Fill(table)
            listbox_section.DisplayMember = "section_name"
            listbox_section.DataSource = table
        Catch ex As Exception

        End Try

        Try
            Dim adapter As New SQLiteDataAdapter("SELECT * FROM Room_list", connectionString)
            Dim table As New DataTable()
            adapter.Fill(table)
            listbox_room.DisplayMember = "room_name"
            listbox_room.DataSource = table
        Catch ex As Exception

        End Try

        Try
            Dim adapter As New SQLiteDataAdapter("SELECT * FROM Subject_list", connectionString)
            Dim table As New DataTable()
            adapter.Fill(table)
            listbox_subject.DisplayMember = "subject_name"
            listbox_subject.DataSource = table
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles btn_createclass.Click
        If listbox_instructor.Items.Count > 0 And listbox_section.Items.Count > 0 And listbox_subject.Items.Count > 0 Then
            form_createclass.ShowDialog()
        Else
            MessageBox.Show("Incomplete!")
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        form_addinstructor.ShowDialog()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Try
            Dim dirPath As String = My.Application.Info.DirectoryPath & "\SchedGenRavni.exe"
            Process.Start(dirPath)
        Catch ex As Exception
            MessageBox.Show("File not found.")
        End Try


    End Sub

    Private Sub btn_changepass_Click(sender As Object, e As EventArgs) Handles btn_changepass.Click

        form_changepass.ShowDialog()
    End Sub

    Private Sub btn_signout_Click(sender As Object, e As EventArgs) Handles btn_signout.Click
        Me.Close()
        form_login.Show()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        form_backup.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        form_classdatabase.Show()

        Try
            Dim adapter As New SQLiteDataAdapter("SELECT * FROM Class_list", connectionString)
            Dim table As New DataTable()
            adapter.Fill(table)
            form_classdatabase.datagridview_class.DataSource = table
        Catch ex As Exception

        End Try

    End Sub
End Class
