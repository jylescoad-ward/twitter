'the real question is, why the fuck did i make this?
'well, because i can so fuck off.

Public Class main
    Public currentdir = System.IO.Directory.GetCurrentDirectory
    Public port_dir = currentdir & "\data\node"
    Public module_dir = currentdir & "\data\node_modules"
    Public src_dir = currentdir & "\data"

    Public script_location_textonly = src_dir & "\text.js"
    Public script_location_both = src_dir & "\text_andor_file.js"

    Public tweetLink

    Public tweetAttachmentLocation

    Private Sub TweetTime() Handles TWEET_BUTTON.Click
        If System.IO.File.Exists(src_dir & "\content.tweet") Then
            My.Computer.FileSystem.DeleteFile(src_dir & "\content.tweet")
        End If

        If TextOnlyRadio.Checked Then
            tweetTextOnly()
        ElseIf FileOnlyRadio.Checked Then
            tweetFileOnly()
        ElseIf FileTextRadio.Checked Then
            tweetFilewithText()
        Else
            MsgBox("Program has encounted an impossible error. Aborting Process...")
            Application.Exit()
        End If

    End Sub

    'Character Counter
    Private Sub tweetContent_TextChanged(sender As Object, e As EventArgs) Handles tweetContent.KeyPress
        Dim charcount = tweetContent.Text.Trim().Length()
        textBoxCharCount.Text = charcount & "/280"
        If charcount >= 280 Then
            textBoxCharCount.ForeColor = Color.Red
        ElseIf charcount > 200 Then
            textBoxCharCount.ForeColor = Color.Orange
        Else
            textBoxCharCount.ForeColor = Color.Black
        End If
    End Sub


    'Radio Checks
    Private Sub TextOnlyRadio_CheckedChanged(sender As Object, e As EventArgs) Handles TextOnlyRadio.CheckedChanged
        If TextOnlyRadio.Checked Then
            PickFileButton.Enabled = False
            FileLocationLabel.Visible = False
        Else
            PickFileButton.Enabled = True
            FileLocationLabel.Visible = True
        End If
    End Sub
    Private Sub FileOnlyRadio_CheckedChanged(sender As Object, e As EventArgs) Handles FileOnlyRadio.CheckedChanged
        If FileOnlyRadio.Checked Then
            tweetContent.Enabled = False
            tweetContent.Text = "Tweet Content is Disabled, Please select file then tweet."
        Else
            tweetContent.Enabled = True
            tweetContent.Text = ""
        End If
    End Sub


    'Tweet File Types
    Sub tweetFileOnly()
        If My.Computer.FileSystem.FileExists(FileLocationLabel.Text) Then
            Dim tweetcontentstream As System.IO.StreamWriter
            tweetcontentstream = My.Computer.FileSystem.OpenTextFileWriter(src_dir & "\content.tweet", True)
            tweetcontentstream.Write("")
            tweetcontentstream.Close()
            Dim launch_script = port_dir & "\node.exe "
            Dim launch_args = script_location_both & "'" & FileLocationLabel.Text & "'"
            Dim launch_full = launch_script & launch_args
            startprocess(launch_script, launch_args)
            Exit Sub
        Else
            MsgBox("File Location is Invalid, Make sure File still exists if you did pick one." & vbCrLf & "If you have not picked a file, then please do.")
            Exit Sub
        End If

    End Sub
    Sub tweetTextOnly()
        If tweetContent.Text.Trim().Length() < 1 Then
            MsgBox("Nothing to tweet.")
            Exit Sub
        End If
        Dim tweetcontentstream As System.IO.StreamWriter
        tweetcontentstream = My.Computer.FileSystem.OpenTextFileWriter(src_dir & "\content.tweet", True)
        tweetcontentstream.Write(tweetContent.Text)
        tweetcontentstream.Close()
        Dim launch_script = port_dir & "\node.exe "
        Dim launch_args = script_location_textonly
        Dim launch_full = launch_script & launch_args
        startprocess(launch_script, launch_args)
    End Sub
    Sub tweetFilewithText()
        If tweetContent.Text.Trim().Length < 1 Then
            MsgBox("Nothing to Tweet.")
            Exit Sub
        End If
        'If My.Computer.FileSystem.FileExists(FileLocationLabel.Text) Then
        Dim tweetcontentstream As System.IO.StreamWriter
        tweetcontentstream = My.Computer.FileSystem.OpenTextFileWriter(src_dir & "\content.tweet", True)
        tweetcontentstream.Write(tweetContent.Text)
        tweetcontentstream.Close()
        Dim launch_script = port_dir & "\node.exe "
        Dim launch_args = script_location_both & " " & FileLocationLabel.Text
        Dim launch_full = launch_script & launch_args
        startprocess(launch_script, launch_args)
        Exit Sub
        'Else
        '    MsgBox("File Location is Invalid, Make sure File still exists if you did pick one." & vbCrLf & "If you have not picked a file, then please do.")
        '    Exit Sub
        'End If
    End Sub


    Private Sub PickFileButton_Click(sender As Object, e As EventArgs) Handles PickFileButton.Click
        Dim fd As OpenFileDialog = New OpenFileDialog()

        fd.Title = "Open File Dialog"
        fd.InitialDirectory = "C:\"
        fd.Filter = "All files (*.*)|*.*|All files (*.*)|*.*"
        fd.FilterIndex = 2
        fd.RestoreDirectory = True

        If fd.ShowDialog() = DialogResult.OK Then
            FileLocationLabel.Text = """" & fd.FileName & """"
        End If
    End Sub




    'Start Process with Logging.
    Public Sub startprocess(prc, args)
        Dim oProcess As New Process()
        If System.IO.File.Exists(currentdir & "/out.log") Then
            My.Computer.FileSystem.DeleteFile(currentdir & "/out.log")
        End If
        Dim oStartInfo As New ProcessStartInfo(prc, args)
        oStartInfo.UseShellExecute = False
        oStartInfo.RedirectStandardOutput = True
        oProcess.StartInfo = oStartInfo
        oProcess.Start()

        Dim sOutput As String
        Using oStreamReader As System.IO.StreamReader = oProcess.StandardOutput
            sOutput = oStreamReader.ReadToEnd()
        End Using
        tweet_link_label.Text = "Tweeting... (please wait a couple of seconds to get link <3 )"
        ShowLinkTimer.Start()
        tweetLink = sOutput
    End Sub
    Sub ShowLinkTimer_Tick(sender As Object, e As EventArgs) Handles ShowLinkTimer.Tick
        tweet_link_label.Text = tweetLink
        My.Computer.FileSystem.DeleteFile(src_dir & "\content.tweet")
    End Sub

    'Basic Stuff
    Private Sub AboutButton_Click(sender As Object, e As EventArgs) Handles AboutButton.Click
        About.Show()
    End Sub
    Private Sub SetupButton_Click(sender As Object, e As EventArgs) Handles SetupButtom.Click
        Setup.Show()
    End Sub

    Private Sub DebugButton_Click(sender As Object, e As EventArgs) Handles DebugButton.Click
        Debug.Show()
    End Sub


    Private Sub tweet_link_label_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles tweet_link_label.LinkClicked
        Process.Start(tweet_link_label.Text)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        MsgBox(tweetAttachmentLocation)
    End Sub
End Class
