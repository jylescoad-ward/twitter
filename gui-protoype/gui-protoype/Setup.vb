Public Class Setup
    Private Sub Setup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        config_location_label.Text = main.config_location
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If My.Computer.FileSystem.FileExists(main.config_location) Then
            My.Computer.FileSystem.DeleteFile(main.config_location)
        End If
        Dim file As System.IO.StreamWriter
        file = My.Computer.FileSystem.OpenTextFileWriter(main.config_location, True)
        file.WriteLine("{")
        file.WriteLine("""" & apikey.Text & """,")
        file.WriteLine("""" & apisecret.Text & """,")
        file.WriteLine("""" & accesskey.Text & """,")
        file.WriteLine("""" & accesstoken.Text & """")
        file.WriteLine("}")
        file.Close()
    End Sub
End Class