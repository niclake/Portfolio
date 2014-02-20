'Project:    Very Very Boards
'Programmer: Nic Lake
'Date:       27 Aug 2010 (Due 30 Aug 2010)
'Purpose:    Display operating hours for different store locations throughout the city.

Public Class MainForm

    Private Sub DowntownButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DowntownButton.Click
        'Assign address and hours for Downtown location
        AddressLabel.Text = "123 University Ave." & vbNewLine & "Boardville, CA 54321"
        AddressLabel.BackColor = Color.PaleGoldenrod
        AddressLabel.BorderStyle = BorderStyle.FixedSingle
        HoursLabel.Text = "Hours" & vbNewLine & "Mon-Fri 10am to 9pm" & vbNewLine & "Sat 9am to 10pm" & vbNewLine & "Sun Noon to 7pm"
        HoursLabel.BackColor = Color.PaleGoldenrod
        HoursLabel.BorderStyle = BorderStyle.FixedSingle
        'Highlight active button for user
        DowntownButton.BackColor = Color.PaleGoldenrod
        MallButton.BackColor = Color.Transparent
        SuburbsButton.BackColor = Color.Transparent
    End Sub

    Private Sub MallButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MallButton.Click
        'Assign address and hours for Mall location
        AddressLabel.Text = "Hanover Park Mall" & vbNewLine & "1005 Center St." & vbNewLine & "Boardville, CA 54321"
        AddressLabel.BackColor = Color.PaleGoldenrod
        AddressLabel.BorderStyle = BorderStyle.FixedSingle
        HoursLabel.Text = "Hours" & vbNewLine & "Mon-Fri 10am to 9pm" & vbNewLine & "Sat 10am to 8pm" & vbNewLine & "Sun Noon to 8pm"
        HoursLabel.BackColor = Color.PaleGoldenrod
        HoursLabel.BorderStyle = BorderStyle.FixedSingle
        'Highlight active button for user
        DowntownButton.BackColor = Color.Transparent
        MallButton.BackColor = Color.PaleGoldenrod
        SuburbsButton.BackColor = Color.Transparent
    End Sub

    Private Sub SuburbsButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SuburbsButton.Click
        'Assign address and hours for Suburbs location
        AddressLabel.Text = "300 Rainbow Ave." & vbNewLine & "Boardville, CA 54321"
        AddressLabel.BackColor = Color.PaleGoldenrod
        AddressLabel.BorderStyle = BorderStyle.FixedSingle
        HoursLabel.Text = "Hours" & vbNewLine & "Mon-Fri 9am to 7pm" & vbNewLine & "Sat 9am to 10pm" & vbNewLine & "Sun 10am to 7pm"
        HoursLabel.BackColor = Color.PaleGoldenrod
        HoursLabel.BorderStyle = BorderStyle.FixedSingle
        'Highlight active button for user
        DowntownButton.BackColor = Color.Transparent
        MallButton.BackColor = Color.Transparent
        SuburbsButton.BackColor = Color.PaleGoldenrod
    End Sub

    Private Sub PrintButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintButton.Click
        'Send screen to Print Preview window
        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm1.Print()
    End Sub

    Private Sub ExitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitButton.Click
        'Exit the program
        Me.Close()
    End Sub
End Class
