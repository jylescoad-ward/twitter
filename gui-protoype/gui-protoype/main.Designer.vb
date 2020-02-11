<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.TWEET_BUTTON = New System.Windows.Forms.Button()
        Me.tweetContent = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.textBoxCharCount = New System.Windows.Forms.Label()
        Me.tweet_link_label = New System.Windows.Forms.LinkLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AboutButton = New System.Windows.Forms.Button()
        Me.SetupButtom = New System.Windows.Forms.Button()
        Me.DebugButton = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.PickFileButton = New System.Windows.Forms.Button()
        Me.FileOnlyRadio = New System.Windows.Forms.RadioButton()
        Me.FileTextRadio = New System.Windows.Forms.RadioButton()
        Me.TextOnlyRadio = New System.Windows.Forms.RadioButton()
        Me.FileLocationLabel = New System.Windows.Forms.Label()
        Me.ShowLinkTimer = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TWEET_BUTTON
        '
        Me.TWEET_BUTTON.Font = New System.Drawing.Font("04b", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TWEET_BUTTON.Location = New System.Drawing.Point(6, 227)
        Me.TWEET_BUTTON.Name = "TWEET_BUTTON"
        Me.TWEET_BUTTON.Size = New System.Drawing.Size(143, 36)
        Me.TWEET_BUTTON.TabIndex = 0
        Me.TWEET_BUTTON.Text = "tweet"
        Me.TWEET_BUTTON.UseVisualStyleBackColor = True
        '
        'tweetContent
        '
        Me.tweetContent.Font = New System.Drawing.Font("Free Pixel", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tweetContent.Location = New System.Drawing.Point(6, 20)
        Me.tweetContent.Multiline = True
        Me.tweetContent.Name = "tweetContent"
        Me.tweetContent.Size = New System.Drawing.Size(433, 173)
        Me.tweetContent.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.textBoxCharCount)
        Me.GroupBox1.Controls.Add(Me.tweet_link_label)
        Me.GroupBox1.Controls.Add(Me.tweetContent)
        Me.GroupBox1.Controls.Add(Me.TWEET_BUTTON)
        Me.GroupBox1.Font = New System.Drawing.Font("Free Pixel", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(445, 270)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tweet Content"
        '
        'textBoxCharCount
        '
        Me.textBoxCharCount.AutoSize = True
        Me.textBoxCharCount.Location = New System.Drawing.Point(155, 227)
        Me.textBoxCharCount.Name = "textBoxCharCount"
        Me.textBoxCharCount.Size = New System.Drawing.Size(112, 14)
        Me.textBoxCharCount.TabIndex = 13
        Me.textBoxCharCount.Text = "Character Count"
        '
        'tweet_link_label
        '
        Me.tweet_link_label.AutoSize = True
        Me.tweet_link_label.Font = New System.Drawing.Font("Free Pixel", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tweet_link_label.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.tweet_link_label.Location = New System.Drawing.Point(3, 209)
        Me.tweet_link_label.Name = "tweet_link_label"
        Me.tweet_link_label.Size = New System.Drawing.Size(322, 14)
        Me.tweet_link_label.TabIndex = 8
        Me.tweet_link_label.TabStop = True
        Me.tweet_link_label.Text = "Tweet Link (will show full link once tweeted)"
        Me.tweet_link_label.VisitedLinkColor = System.Drawing.Color.Blue
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Free Pixel", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 302)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(557, 17)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "dont be a silly sausage because there is no confirmation box!"
        '
        'AboutButton
        '
        Me.AboutButton.Font = New System.Drawing.Font("Free Pixel", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AboutButton.Location = New System.Drawing.Point(466, 28)
        Me.AboutButton.Name = "AboutButton"
        Me.AboutButton.Size = New System.Drawing.Size(112, 25)
        Me.AboutButton.TabIndex = 9
        Me.AboutButton.Text = "About"
        Me.AboutButton.UseVisualStyleBackColor = True
        '
        'SetupButtom
        '
        Me.SetupButtom.Enabled = False
        Me.SetupButtom.Font = New System.Drawing.Font("Free Pixel", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SetupButtom.Location = New System.Drawing.Point(466, 60)
        Me.SetupButtom.Name = "SetupButtom"
        Me.SetupButtom.Size = New System.Drawing.Size(112, 25)
        Me.SetupButtom.TabIndex = 10
        Me.SetupButtom.Text = "Setup"
        Me.SetupButtom.UseVisualStyleBackColor = True
        '
        'DebugButton
        '
        Me.DebugButton.Font = New System.Drawing.Font("Free Pixel", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DebugButton.Location = New System.Drawing.Point(466, 248)
        Me.DebugButton.Name = "DebugButton"
        Me.DebugButton.Size = New System.Drawing.Size(112, 23)
        Me.DebugButton.TabIndex = 11
        Me.DebugButton.Text = "Debug"
        Me.DebugButton.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.PickFileButton)
        Me.GroupBox2.Controls.Add(Me.FileOnlyRadio)
        Me.GroupBox2.Controls.Add(Me.FileTextRadio)
        Me.GroupBox2.Controls.Add(Me.TextOnlyRadio)
        Me.GroupBox2.Location = New System.Drawing.Point(466, 92)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(112, 139)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Tweet Type"
        '
        'PickFileButton
        '
        Me.PickFileButton.Enabled = False
        Me.PickFileButton.Font = New System.Drawing.Font("Free Pixel", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PickFileButton.Location = New System.Drawing.Point(6, 110)
        Me.PickFileButton.Name = "PickFileButton"
        Me.PickFileButton.Size = New System.Drawing.Size(100, 23)
        Me.PickFileButton.TabIndex = 13
        Me.PickFileButton.Text = "Pick File"
        Me.PickFileButton.UseVisualStyleBackColor = True
        '
        'FileOnlyRadio
        '
        Me.FileOnlyRadio.AutoSize = True
        Me.FileOnlyRadio.Location = New System.Drawing.Point(6, 45)
        Me.FileOnlyRadio.Name = "FileOnlyRadio"
        Me.FileOnlyRadio.Size = New System.Drawing.Size(88, 18)
        Me.FileOnlyRadio.TabIndex = 2
        Me.FileOnlyRadio.Text = "File Only"
        Me.FileOnlyRadio.UseVisualStyleBackColor = True
        '
        'FileTextRadio
        '
        Me.FileTextRadio.AutoSize = True
        Me.FileTextRadio.Location = New System.Drawing.Point(6, 69)
        Me.FileTextRadio.Name = "FileTextRadio"
        Me.FileTextRadio.Size = New System.Drawing.Size(102, 18)
        Me.FileTextRadio.TabIndex = 1
        Me.FileTextRadio.Text = "File + Text"
        Me.FileTextRadio.UseVisualStyleBackColor = True
        '
        'TextOnlyRadio
        '
        Me.TextOnlyRadio.AutoSize = True
        Me.TextOnlyRadio.Checked = True
        Me.TextOnlyRadio.Location = New System.Drawing.Point(6, 21)
        Me.TextOnlyRadio.Name = "TextOnlyRadio"
        Me.TextOnlyRadio.Size = New System.Drawing.Size(88, 18)
        Me.TextOnlyRadio.TabIndex = 0
        Me.TextOnlyRadio.TabStop = True
        Me.TextOnlyRadio.Text = "Text Only"
        Me.TextOnlyRadio.UseVisualStyleBackColor = True
        '
        'FileLocationLabel
        '
        Me.FileLocationLabel.AutoSize = True
        Me.FileLocationLabel.Location = New System.Drawing.Point(18, 286)
        Me.FileLocationLabel.Name = "FileLocationLabel"
        Me.FileLocationLabel.Size = New System.Drawing.Size(98, 14)
        Me.FileLocationLabel.TabIndex = 13
        Me.FileLocationLabel.Text = "File Location"
        '
        'ShowLinkTimer
        '
        Me.ShowLinkTimer.Interval = 4000
        '
        'main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(590, 328)
        Me.Controls.Add(Me.FileLocationLabel)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.DebugButton)
        Me.Controls.Add(Me.SetupButtom)
        Me.Controls.Add(Me.AboutButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Free Pixel", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "main"
        Me.ShowIcon = False
        Me.Text = "DARiOX Basic TC"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TWEET_BUTTON As Button
    Friend WithEvents tweetContent As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tweet_link_label As LinkLabel
    Friend WithEvents AboutButton As Button
    Friend WithEvents SetupButtom As Button
    Friend WithEvents DebugButton As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents FileOnlyRadio As RadioButton
    Friend WithEvents FileTextRadio As RadioButton
    Friend WithEvents TextOnlyRadio As RadioButton
    Friend WithEvents textBoxCharCount As Label
    Friend WithEvents PickFileButton As Button
    Friend WithEvents FileLocationLabel As Label
    Friend WithEvents ShowLinkTimer As Timer
End Class
