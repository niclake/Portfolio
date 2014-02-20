'Program:       Ch02HandsOn - Modification
'Programmer:    
'Date:             Sept 2010
'Description:    Allow the user to sign in and display current sales promotion. Focus is on adding sign-in procedure.

Public Class MainForm

    Private Sub BooksRadioButton_CheckedChanged(ByVal sender As System.Object, _
      ByVal e As System.EventArgs) Handles BooksRadioButton.CheckedChanged
        ' Display the image and promotion for the Books department.

        DepartmentPictureBox.Image = My.Resources.Book
        PromotionTextBox.Text = "Buy two, get the second one for half price."
    End Sub

    Private Sub CoffeeBarRadioButton_CheckedChanged(ByVal sender As Object, _
      ByVal e As System.EventArgs) Handles CoffeeBarRadioButton.CheckedChanged
        ' Display the image and promotion for the Coffee Bar.

        DepartmentPictureBox.Image = My.Resources.Coffee
        PromotionTextBox.Text = "Celebrate the season with 20% off specialty drinks."
    End Sub

    Private Sub MusicRadioButton_CheckedChanged(ByVal sender As Object, _
      ByVal e As System.EventArgs) Handles MusicRadioButton.CheckedChanged
        ' Display the image and promotion for the Music department.

        DepartmentPictureBox.Image = My.Resources.Music
        PromotionTextBox.Text = "Get a free MP3 download with purchase of a CD."
    End Sub


    Private Sub PeriodicalsRadioButton_CheckedChanged(ByVal sender As Object, _
      ByVal e As System.EventArgs) Handles PeriodicalsRadioButton.CheckedChanged
        ' Display the image and promotion for the Periodicals department.

        DepartmentPictureBox.Image = My.Resources.Periodicals
        PromotionTextBox.Text = "Elite members receive 10% off every purchase."
    End Sub

    Private Sub ImageVisibleCheckBox_CheckedChanged(ByVal sender As System.Object, _
      ByVal e As System.EventArgs) Handles ImageVisibleCheckBox.CheckedChanged
        ' Set the visibility of the department image.

        DepartmentPictureBox.Visible = ImageVisibleCheckBox.Checked
    End Sub

    

    Private Sub PrintButton_Click(ByVal sender As System.Object, _
      ByVal e As System.EventArgs) Handles PrintButton.Click
        ' Print the form in the Print Preview window.

        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm1.Print()
    End Sub

    Private Sub ExitButton_Click(ByVal sender As System.Object, _
      ByVal e As System.EventArgs) Handles ExitButton.Click
        ' End the program.

        Me.Close()
    End Sub

    
   
    Private Sub SignInButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles SignInButton.Click
        'Set up form to display department group box, image, checkbox, and promotion label
        'Hide sign in group box
        DepartmentGroupBox.Enabled = True
        ImageVisibleCheckBox.Visible = True
        PromotionTextBox.Visible = True
        WelcomeRichTextBox.Visible = True

        'Display message in Welcome box
        WelcomeRichTextBox.Text = "Welcome Member #" & MemberIDMaskedTextBox.Text _
        & Environment.NewLine & NameTextBox.Text

        SignInGroupBox.Enabled = False
        SignInButton.Enabled = False

    End Sub
End Class
