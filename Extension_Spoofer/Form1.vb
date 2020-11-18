Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Using _Open_File_Dialog As OpenFileDialog = New OpenFileDialog()
            _Open_File_Dialog.Filter = "Executable files (*.exe)|*.exe"
            _Open_File_Dialog.ShowDialog()

            TextBox1.Text = _Open_File_Dialog.FileName
        End Using
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim RChar As String = ChrW("&H202E")
        Dim Name As String = TextBox2.Text & RChar & StrReverse(TextBox3.Text) & ".exe"

        My.Computer.FileSystem.RenameFile(TextBox1.Text, Name)
    End Sub

End Class