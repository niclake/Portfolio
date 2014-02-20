'Program:    Signal Flags Project
'Programmer: Nic Lake
'Date:       6 Sept 2010
'Purpose:    Practice working with enabling/making elements visable in programs


Public Class MainForm
    Private Sub ExitButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ExitButton.Click
        'Close application
        Me.Close()
    End Sub

    Private Sub PrintButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PrintButton.Click
        'Send from to print preview window
        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm1.Print()
    End Sub

    Private Sub SignInButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SignInButton.Click
        'Disable the Sign In area
        SignInGroupBox.Enabled = False

        'Submit authorization code, enable Alphabetic Character window
        ABCGroupBox.Enabled = True

        'Show check box
        ShowFlagCheckBox.Visible = True
    End Sub

    Private Sub CharlieRadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CharlieRadioButton.CheckedChanged
        'Show image in picture box, change name to name of flag, and display instruction
        FlagPictureBox.Image = My.Resources.charlie
        FlagNameLabel.Text = "Charlie"
        FlagInstructionLabel.Text = "Yes or Affirmative."
    End Sub

    Private Sub GolfRadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GolfRadioButton.CheckedChanged
        'Show image in picture box, change name to name of flag, and display instruction
        FlagPictureBox.Image = My.Resources.golf
        FlagNameLabel.Text = "Golf"
        FlagInstructionLabel.Text = "I require a pilot."
    End Sub

    Private Sub IndiaRadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IndiaRadioButton.CheckedChanged
        'Show image in picture box, change name to name of flag, and display instruction
        FlagPictureBox.Image = My.Resources.india
        FlagNameLabel.Text = "India"
        FlagInstructionLabel.Text = "Coming Alongside."
    End Sub

    Private Sub PapaRadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PapaRadioButton.CheckedChanged
        'Show image in picture box, change name to name of flag, and display instruction
        FlagPictureBox.Image = My.Resources.papa
        FlagNameLabel.Text = "Papa"
        FlagInstructionLabel.Text = "All personnel return to ship; proceeding to sea."
    End Sub

    Private Sub TangoRadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TangoRadioButton.CheckedChanged
        'Show image in picture box, change name to name of flag, and display instruction
        FlagPictureBox.Image = My.Resources.tango
        FlagNameLabel.Text = "Tango"
        FlagInstructionLabel.Text = "Do not pass ahead of me."
    End Sub

    Private Sub ZuluRadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ZuluRadioButton.CheckedChanged
        'Show image in picture box, change name to name of flag, and display instruction
        FlagPictureBox.Image = My.Resources.zulu
        FlagNameLabel.Text = "Zulu"
        FlagInstructionLabel.Text = "I require a tug."
    End Sub

    Private Sub ShowFlagCheckBox_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ShowFlagCheckBox.CheckedChanged
        FlagPictureBox.Visible = ShowFlagCheckBox.Checked
    End Sub
End Class
