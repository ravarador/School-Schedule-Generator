Imports System.Data.SQLite
Public Class form_createclass
    Dim connectionString As String = "Data Source=configDb.db;Version=3;"
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim t As String = "true"
        Dim f As String = "false"
        Dim a As Integer
        Dim b As Integer
        Dim c As Integer
        Dim aa As Integer
        Dim bb As Integer
        Dim cc As Integer
        Dim sqlite_conn As SQLiteConnection
        Dim sqlite_cmd As SQLiteCommand

        form_main.btn_createclass.Enabled = True
        Try
            If checkbox_yes.Checked = True Then

                a = form_main.listbox_instructor.SelectedIndex.ToString + 1 'GET index of instructor
                b = form_main.listbox_subject.SelectedIndex.ToString + 1 'GET index of subject
                c = form_main.listbox_section.SelectedIndex.ToString + 1 'GET index of section

                aa = form_main.listbox_instructor.SelectedIndex.ToString 'GET index of instructor
                bb = form_main.listbox_subject.SelectedIndex.ToString  'GET index of subject
                cc = form_main.listbox_section.SelectedIndex.ToString  'GET index of section
                If rad_1.Checked Then



                    Try
                        form_viewdatabase.Show()
                        ' create a new database connection:
                        sqlite_conn = New SQLiteConnection("Data Source=configDb.db;Version=3;")

                        ' open the connection:
                        sqlite_conn.Open()

                        sqlite_cmd = sqlite_conn.CreateCommand()
                        'INSERT INTO DATABASE TABLE
                        sqlite_cmd.CommandText = "INSERT INTO Class_list (prof_id,prof_name,course_id,course_name,duration,group_id,group_name,lab) VALUES ('" & a.ToString & "','" & form_viewdatabase.datagridview_instructor(0, aa).Value.ToString & "','" & b.ToString & "','" & form_viewdatabase.datagridview_subject(0, bb).Value.ToString & "', '" & "3" & "','" & c.ToString & "','" & form_viewdatabase.datagridview_section(0, cc).Value.ToString & "', '" & t & "');"
                        sqlite_cmd.ExecuteNonQuery()
                        sqlite_conn.Close()
                        form_viewdatabase.Close()
                    Catch ex As Exception
                        MessageBox.Show(ex.ToString)
                    End Try

                    MessageBox.Show(Me, "Class has been added" + Environment.NewLine + "Do you wish to continue?", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Question)
                    Me.Dispose()
                End If

                If rad_130.Checked Then
                    Try
                        form_viewdatabase.Show()
                        ' create a new database connection:
                        sqlite_conn = New SQLiteConnection("Data Source=configDb.db;Version=3;")

                        ' open the connection:
                        sqlite_conn.Open()

                        sqlite_cmd = sqlite_conn.CreateCommand()
                        'INSERT INTO DATABASE TABLE
                        sqlite_cmd.CommandText = "INSERT INTO Class_list (prof_id,prof_name,course_id,course_name,duration,group_id,group_name,lab) VALUES ('" & a.ToString & "','" & form_viewdatabase.datagridview_instructor(0, aa).Value.ToString & "','" & b.ToString & "','" & form_viewdatabase.datagridview_subject(0, bb).Value.ToString & "', '" & "4" & "','" & c.ToString & "','" & form_viewdatabase.datagridview_section(0, cc).Value.ToString & "', '" & t & "');"
                        sqlite_cmd.ExecuteNonQuery()
                        sqlite_conn.Close()
                        form_viewdatabase.Close()
                    Catch ex As Exception
                        MessageBox.Show(ex.ToString)
                    End Try

                    MessageBox.Show(Me, "Class has been added" + Environment.NewLine + "Do you wish to continue?", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Question)
                    Me.Dispose()
                End If

                If rad_2.Checked Then
                    Try
                        form_viewdatabase.Show()
                        ' create a new database connection:
                        sqlite_conn = New SQLiteConnection("Data Source=configDb.db;Version=3;")

                        ' open the connection:
                        sqlite_conn.Open()

                        sqlite_cmd = sqlite_conn.CreateCommand()
                        'INSERT INTO DATABASE TABLE
                        sqlite_cmd.CommandText = "INSERT INTO Class_list (prof_id,prof_name,course_id,course_name,duration,group_id,group_name,lab) VALUES ('" & a.ToString & "','" & form_viewdatabase.datagridview_instructor(0, aa).Value.ToString & "','" & b.ToString & "','" & form_viewdatabase.datagridview_subject(0, bb).Value.ToString & "', '" & "5" & "','" & c.ToString & "','" & form_viewdatabase.datagridview_section(0, cc).Value.ToString & "', '" & t & "');"
                        sqlite_cmd.ExecuteNonQuery()
                        sqlite_conn.Close()
                        form_viewdatabase.Close()
                    Catch ex As Exception
                        MessageBox.Show(ex.ToString)
                    End Try


                    MessageBox.Show(Me, "Class has been added" + Environment.NewLine + "Do you wish to continue?", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Question)
                    Me.Dispose()
                End If

                If rad_230.Checked Then

                    Try
                        form_viewdatabase.Show()
                        ' create a new database connection:
                        sqlite_conn = New SQLiteConnection("Data Source=configDb.db;Version=3;")

                        ' open the connection:
                        sqlite_conn.Open()

                        sqlite_cmd = sqlite_conn.CreateCommand()
                        'INSERT INTO DATABASE TABLE
                        sqlite_cmd.CommandText = "INSERT INTO Class_list (prof_id,prof_name,course_id,course_name,duration,group_id,group_name,lab) VALUES ('" & a.ToString & "','" & form_viewdatabase.datagridview_instructor(0, aa).Value.ToString & "','" & b.ToString & "','" & form_viewdatabase.datagridview_subject(0, bb).Value.ToString & "', '" & "6" & "','" & c.ToString & "','" & form_viewdatabase.datagridview_section(0, cc).Value.ToString & "', '" & t & "');"
                        sqlite_cmd.ExecuteNonQuery()
                        sqlite_conn.Close()
                        form_viewdatabase.Close()
                    Catch ex As Exception
                        MessageBox.Show(ex.ToString)
                    End Try

                    MessageBox.Show(Me, "Class has been added" + Environment.NewLine + "Do you wish to continue?", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Question)
                    Me.Dispose()
                End If

                If rad_3.Checked Then

                    Try
                        form_viewdatabase.Show()
                        ' create a new database connection:
                        sqlite_conn = New SQLiteConnection("Data Source=configDb.db;Version=3;")

                        ' open the connection:
                        sqlite_conn.Open()

                        sqlite_cmd = sqlite_conn.CreateCommand()
                        'INSERT INTO DATABASE TABLE
                        sqlite_cmd.CommandText = "INSERT INTO Class_list (prof_id,prof_name,course_id,course_name,duration,group_id,group_name,lab) VALUES ('" & a.ToString & "','" & form_viewdatabase.datagridview_instructor(0, aa).Value.ToString & "','" & b.ToString & "','" & form_viewdatabase.datagridview_subject(0, bb).Value.ToString & "', '" & "7" & "','" & c.ToString & "','" & form_viewdatabase.datagridview_section(0, cc).Value.ToString & "', '" & t & "');"
                        sqlite_cmd.ExecuteNonQuery()
                        sqlite_conn.Close()
                        form_viewdatabase.Close()
                    Catch ex As Exception
                        MessageBox.Show(ex.ToString)
                    End Try

                    MessageBox.Show(Me, "Class has been added" + Environment.NewLine + "Do you wish to continue?", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Question)
                    Me.Dispose()
                End If
            End If

            If checkbox_yes.Checked = False Then


                a = form_main.listbox_instructor.SelectedIndex.ToString + 1 'GET index of instructor
                b = form_main.listbox_subject.SelectedIndex.ToString + 1 'GET index of subject
                c = form_main.listbox_section.SelectedIndex.ToString + 1 'GET index of section

                aa = form_main.listbox_instructor.SelectedIndex.ToString 'GET index of instructor
                bb = form_main.listbox_subject.SelectedIndex.ToString  'GET index of subject
                cc = form_main.listbox_section.SelectedIndex.ToString  'GET index of section

                If rad_1.Checked Then

                    Try
                        form_viewdatabase.Show()
                        ' create a new database connection:
                        sqlite_conn = New SQLiteConnection("Data Source=configDb.db;Version=3;")

                        ' open the connection:
                        sqlite_conn.Open()

                        sqlite_cmd = sqlite_conn.CreateCommand()
                        'INSERT INTO DATABASE TABLE
                        sqlite_cmd.CommandText = "INSERT INTO Class_list (prof_id,prof_name,course_id,course_name,duration,group_id,group_name,lab) VALUES ('" & a.ToString & "','" & form_viewdatabase.datagridview_instructor(0, aa).Value.ToString & "','" & b.ToString & "','" & form_viewdatabase.datagridview_subject(0, bb).Value.ToString & "', '" & "3" & "','" & c.ToString & "','" & form_viewdatabase.datagridview_section(0, cc).Value.ToString & "', '" & f & "');"
                        sqlite_cmd.ExecuteNonQuery()
                        sqlite_conn.Close()
                        form_viewdatabase.Close()
                    Catch ex As Exception
                        MessageBox.Show(ex.ToString)
                    End Try

                    MessageBox.Show(Me, "Class has been added" + Environment.NewLine + "Do you wish to continue?", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Question)
                    Me.Dispose()
                End If

                If rad_130.Checked Then

                    Try
                        form_viewdatabase.Show()
                        ' create a new database connection:
                        sqlite_conn = New SQLiteConnection("Data Source=configDb.db;Version=3;")

                        ' open the connection:
                        sqlite_conn.Open()

                        sqlite_cmd = sqlite_conn.CreateCommand()
                        'INSERT INTO DATABASE TABLE
                        sqlite_cmd.CommandText = "INSERT INTO Class_list (prof_id,prof_name,course_id,course_name,duration,group_id,group_name,lab) VALUES ('" & a.ToString & "','" & form_viewdatabase.datagridview_instructor(0, aa).Value.ToString & "','" & b.ToString & "','" & form_viewdatabase.datagridview_subject(0, bb).Value.ToString & "', '" & "4" & "','" & c.ToString & "','" & form_viewdatabase.datagridview_section(0, cc).Value.ToString & "', '" & f & "');"
                        sqlite_cmd.ExecuteNonQuery()
                        sqlite_conn.Close()
                        form_viewdatabase.Close()
                    Catch ex As Exception
                        MessageBox.Show(ex.ToString)
                    End Try

                    MessageBox.Show(Me, "Class has been added" + Environment.NewLine + "Do you wish to continue?", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Question)
                    Me.Dispose()
                End If

                If rad_2.Checked Then

                    Try
                        form_viewdatabase.Show()
                        ' create a new database connection:
                        sqlite_conn = New SQLiteConnection("Data Source=configDb.db;Version=3;")

                        ' open the connection:
                        sqlite_conn.Open()

                        sqlite_cmd = sqlite_conn.CreateCommand()
                        'INSERT INTO DATABASE TABLE
                        sqlite_cmd.CommandText = "INSERT INTO Class_list (prof_id,prof_name,course_id,course_name,duration,group_id,group_name,lab) VALUES ('" & a.ToString & "','" & form_viewdatabase.datagridview_instructor(0, aa).Value.ToString & "','" & b.ToString & "','" & form_viewdatabase.datagridview_subject(0, bb).Value.ToString & "', '" & "5" & "','" & c.ToString & "','" & form_viewdatabase.datagridview_section(0, cc).Value.ToString & "', '" & f & "');"
                        sqlite_cmd.ExecuteNonQuery()
                        sqlite_conn.Close()
                        form_viewdatabase.Close()
                    Catch ex As Exception
                        MessageBox.Show(ex.ToString)
                    End Try

                    MessageBox.Show(Me, "Class has been added" + Environment.NewLine + "Do you wish to continue?", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Question)
                    Me.Dispose()
                End If

                If rad_230.Checked Then
                    Try
                        form_viewdatabase.Show()
                        ' create a new database connection:
                        sqlite_conn = New SQLiteConnection("Data Source=configDb.db;Version=3;")

                        ' open the connection:
                        sqlite_conn.Open()

                        sqlite_cmd = sqlite_conn.CreateCommand()
                        'INSERT INTO DATABASE TABLE
                        sqlite_cmd.CommandText = "INSERT INTO Class_list (prof_id,prof_name,course_id,course_name,duration,group_id,group_name,lab) VALUES ('" & a.ToString & "','" & form_viewdatabase.datagridview_instructor(0, aa).Value.ToString & "','" & b.ToString & "','" & form_viewdatabase.datagridview_subject(0, bb).Value.ToString & "', '" & "6" & "','" & c.ToString & "','" & form_viewdatabase.datagridview_section(0, cc).Value.ToString & "', '" & f & "');"
                        sqlite_cmd.ExecuteNonQuery()
                        sqlite_conn.Close()
                        form_viewdatabase.Close()
                    Catch ex As Exception
                        MessageBox.Show(ex.ToString)
                    End Try

                    MessageBox.Show(Me, "Class has been added" + Environment.NewLine + "Do you wish to continue?", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Question)
                    Me.Dispose()
                End If

                If rad_3.Checked Then
                    Try
                        form_viewdatabase.Show()
                        ' create a new database connection:
                        sqlite_conn = New SQLiteConnection("Data Source=configDb.db;Version=3;")

                        ' open the connection:
                        sqlite_conn.Open()

                        sqlite_cmd = sqlite_conn.CreateCommand()
                        'INSERT INTO DATABASE TABLE
                        sqlite_cmd.CommandText = "INSERT INTO Class_list (prof_id,prof_name,course_id,course_name,duration,group_id,group_name,lab) VALUES ('" & a.ToString & "','" & form_viewdatabase.datagridview_instructor(0, aa).Value.ToString & "','" & b.ToString & "','" & form_viewdatabase.datagridview_subject(0, bb).Value.ToString & "', '" & "7" & "','" & c.ToString & "','" & form_viewdatabase.datagridview_section(0, cc).Value.ToString & "', '" & f & "');"
                        sqlite_cmd.ExecuteNonQuery()
                        sqlite_conn.Close()
                        form_viewdatabase.Close()
                    Catch ex As Exception
                        MessageBox.Show(ex.ToString)
                    End Try

                    MessageBox.Show(Me, "Class has been added" + Environment.NewLine + "Do you wish to continue?", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Question)
                    Me.Dispose()
                End If
            ElseIf rad_1.Checked = False And rad_130.Checked = False And rad_2.Checked = False And rad_230.Checked = False And rad_3.Checked = False Then
                MessageBox.Show(Me, "Please select duration." + Environment.NewLine + "Do you wish to continue?", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Question)
            End If

            Try
                Dim adapter As New SQLiteDataAdapter("SELECT * FROM Class_list", connectionString)
                Dim table As New DataTable()
                adapter.Fill(table)
                form_classdatabase.datagridview_class.DataSource = table
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

            form_viewdatabase.Close()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Me.Dispose()
    End Sub
End Class