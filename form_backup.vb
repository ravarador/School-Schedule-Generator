Imports System.Data.SQLite
Public Class form_backup
    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Me.Dispose()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (FolderBrowserDialog1.ShowDialog() = DialogResult.OK) Then
            TextBox1.Text = FolderBrowserDialog1.SelectedPath
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim FileToCopy As String
        Dim NewCopy As String
        Dim dirPath As String = My.Application.Info.DirectoryPath
        My.Computer.FileSystem.CurrentDirectory = dirPath

        FileToCopy = dirPath + "\configDb.db"
        NewCopy = TextBox1.Text + "\" + TextBox2.Text + ".db"
        If TextBox1.Text <> "" And TextBox2.Text <> "" Then
            Try
                If System.IO.File.Exists(FileToCopy) = True Then
                    If System.IO.File.Exists(NewCopy) = False Then
                        System.IO.File.Copy(FileToCopy, NewCopy)
                        MessageBox.Show("Backup Successful!")
                    Else
                        MessageBox.Show("File name already exists! Select a different name.")
                    End If
                End If


            Catch ex As Exception

            End Try
        Else
            MessageBox.Show("All fields are required.")
        End If


    End Sub


    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

End Class