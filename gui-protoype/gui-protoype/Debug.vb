Public Class Debug
    Private Sub Debug_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        nodejs_port_dir.Text = main.port_dir
        nodejs_modules_dir.Text = main.module_dir
        nodejs_src_dir.Text = main.src_dir

        nodejs_script_location_text.Text = main.script_location_textonly
        nodejs_script_location_both.Text = main.script_location_both
    End Sub
End Class