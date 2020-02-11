<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Debug
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.nodejs_port_dir = New System.Windows.Forms.Label()
        Me.nodejs_modules_dir = New System.Windows.Forms.Label()
        Me.nodejs_src_dir = New System.Windows.Forms.Label()
        Me.nodejs_script_location_text = New System.Windows.Forms.Label()
        Me.nodejs_script_location_both = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'nodejs_port_dir
        '
        Me.nodejs_port_dir.AutoSize = True
        Me.nodejs_port_dir.Location = New System.Drawing.Point(13, 13)
        Me.nodejs_port_dir.Name = "nodejs_port_dir"
        Me.nodejs_port_dir.Size = New System.Drawing.Size(79, 13)
        Me.nodejs_port_dir.TabIndex = 0
        Me.nodejs_port_dir.Text = "nodejs_port_dir"
        '
        'nodejs_modules_dir
        '
        Me.nodejs_modules_dir.AutoSize = True
        Me.nodejs_modules_dir.Location = New System.Drawing.Point(13, 30)
        Me.nodejs_modules_dir.Name = "nodejs_modules_dir"
        Me.nodejs_modules_dir.Size = New System.Drawing.Size(100, 13)
        Me.nodejs_modules_dir.TabIndex = 1
        Me.nodejs_modules_dir.Text = "nodejs_modules_dir"
        '
        'nodejs_src_dir
        '
        Me.nodejs_src_dir.AutoSize = True
        Me.nodejs_src_dir.Location = New System.Drawing.Point(13, 47)
        Me.nodejs_src_dir.Name = "nodejs_src_dir"
        Me.nodejs_src_dir.Size = New System.Drawing.Size(75, 13)
        Me.nodejs_src_dir.TabIndex = 2
        Me.nodejs_src_dir.Text = "nodejs_src_dir"
        '
        'nodejs_script_location_text
        '
        Me.nodejs_script_location_text.AutoSize = True
        Me.nodejs_script_location_text.Location = New System.Drawing.Point(13, 81)
        Me.nodejs_script_location_text.Name = "nodejs_script_location_text"
        Me.nodejs_script_location_text.Size = New System.Drawing.Size(135, 13)
        Me.nodejs_script_location_text.TabIndex = 3
        Me.nodejs_script_location_text.Text = "nodejs_script_location_text"
        '
        'nodejs_script_location_both
        '
        Me.nodejs_script_location_both.AutoSize = True
        Me.nodejs_script_location_both.Location = New System.Drawing.Point(13, 94)
        Me.nodejs_script_location_both.Name = "nodejs_script_location_both"
        Me.nodejs_script_location_both.Size = New System.Drawing.Size(139, 13)
        Me.nodejs_script_location_both.TabIndex = 4
        Me.nodejs_script_location_both.Text = "nodejs_script_location_both"
        '
        'Debug
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.nodejs_script_location_both)
        Me.Controls.Add(Me.nodejs_script_location_text)
        Me.Controls.Add(Me.nodejs_src_dir)
        Me.Controls.Add(Me.nodejs_modules_dir)
        Me.Controls.Add(Me.nodejs_port_dir)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Debug"
        Me.Text = "Developer Debug"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents nodejs_port_dir As Label
    Friend WithEvents nodejs_modules_dir As Label
    Friend WithEvents nodejs_src_dir As Label
    Friend WithEvents nodejs_script_location_text As Label
    Friend WithEvents nodejs_script_location_both As Label
End Class
