'Project :   Campus Cheers
'Programmer: Nic Lake
'Date:       27 Aug 2010
'Purpose:    Display cheers for different Iowa universities, print it, and exit.


Public Class MainForm

    Private Sub UNIButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles UNIButton.Click
        'Assign Go Panthers to the CheerLabel, change label colors to UNI colors.'
        CheerLabel.Text = "Go Panthers!"
        CheerLabel.BackColor = Color.MediumPurple
        CheerLabel.ForeColor = Color.Gold
    End Sub

    Private Sub IowaButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles IowaButton.Click
        'Assign Go Hawkeyes to the CheerLabel, change label colors to Iowa colors.'
        CheerLabel.Text = "Go Hawkeyes!"
        CheerLabel.BackColor = Color.Black
        CheerLabel.ForeColor = Color.Gold
    End Sub

    Private Sub ISUButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ISUButton.Click
        'Assign Go Cyclones to the CheerLabel, change label colors to ISU colors.'
        CheerLabel.Text = "Go Cyclones!"
        CheerLabel.BackColor = Color.Red
        CheerLabel.ForeColor = Color.Gold
    End Sub

    Private Sub ExitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitButton.Click
        'Close application'
        Me.Close()
    End Sub

    Private Sub PrintButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintButton.Click
        'Send copy of form to Print Preview'
        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm1.Print()
    End Sub
End Class
