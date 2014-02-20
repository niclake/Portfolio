'Project Name:    Weather Advice
'Programmer:      Nic Lake
'Date:            30 Aug 2010
'Project Purpose: Allows us to learn several new controls and learn about
'                   user interface guidelines.

Public Class WeatherForm

    Private Sub ExitButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ExitButton.Click
        'close the application
        Me.Close()
    End Sub

    Private Sub PrintButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PrintButton.Click
        'send from to print preview window
        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm1.Print()
    End Sub

    Private Sub SunnyRadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SunnyRadioButton.CheckedChanged
        'dislpay sun icon in picture box
        SunnyPictureBox.Visible = True

        'hide other picture box images
        SnowyPictureBox.Visible = False
        RainyPictureBox.Visible = False
        CloudyPictureBox.Visible = False

        'display advice in label
        MessageLabel.Text = "Get your shades on, " & NameTextBox.Text & ", it's sunny!"
    End Sub

    Private Sub SnowyRadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SnowyRadioButton.CheckedChanged
        'display snow icon in picture box
        SnowyPictureBox.Visible = True

        'hide other picture box images
        SunnyPictureBox.Visible = False
        RainyPictureBox.Visible = False
        CloudyPictureBox.Visible = False

        'display advice in label
        MessageLabel.Text = "Put your boots on, " & NameTextBox.Text & ", it's snowing!"
    End Sub

    Private Sub RainyRadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RainyRadioButton.CheckedChanged
        'display rain in picture box
        RainyPictureBox.Visible = True

        'hide other picture box images
        SnowyPictureBox.Visible = False
        SunnyPictureBox.Visible = False
        CloudyPictureBox.Visible = False

        'display advice in label
        MessageLabel.Text = "Grab your umbrella, " & NameTextBox.Text & ", it's raining!"
    End Sub

    Private Sub CloudyRadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloudyRadioButton.CheckedChanged
        'display cloudy in picture box
        CloudyPictureBox.Visible = True

        'hid other picture box images
        SnowyPictureBox.Visible = False
        RainyPictureBox.Visible = False
        SunnyPictureBox.Visible = False

        'display advice in label
        MessageLabel.Text = "Don't forget your jacket, " & NameTextBox.Text & ", it's cloudy!"
    End Sub

    Private Sub ResetButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResetButton.Click
        'clear radio buttons
        SunnyRadioButton.Checked = False
        RainyRadioButton.Checked = False
        SnowyRadioButton.Checked = False
        CloudyRadioButton.Checked = False

        'clear images
        SnowyPictureBox.Visible = False
        RainyPictureBox.Visible = False
        SunnyPictureBox.Visible = False
        CloudyPictureBox.Visible = False

        'clear label
        MessageLabel.Text = ""

        'clear textbox and give it the focus
        With NameTextBox
            .Clear()
            .Focus()
        End With
    End Sub
End Class
