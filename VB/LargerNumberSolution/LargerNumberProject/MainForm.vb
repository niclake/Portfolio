Public Class MainForm

    Private Sub FindLargerButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FindLargerButton.Click
        'declare variables
        Dim FirstNumDecimal As Decimal
        Dim SecondNumDecimal As Decimal

        Try
            FirstNumDecimal = Decimal.Parse(FirstNumTextBox.Text)

            Try
                SecondNumDecimal = Decimal.Parse(SecondNumTextBox.Text)

                FirstNumDecimal = FirstNumTextBox.Text
                SecondNumDecimal = SecondNumTextBox.Text

                If FirstNumDecimal > SecondNumDecimal Then
                    ResultTextBox.Text = "The larger number is " & FirstNumDecimal
                Else
                    ResultTextBox.Text = "The larger number is " & SecondNumDecimal
                End If

            Catch SecondNumException As FormatException
                'handle exception for Second Number
                MessageBox.Show("Invalid entry for second number.  Please re-enter.", "Second number entry error.")
                With SecondNumTextBox
                    .Focus()
                    .SelectAll()
                End With
            End Try

        Catch FirstNumException As FormatException
            'handle exception for First Number
            MessageBox.Show("Invalid entry for first number.  Please re-enter.", "First number entry error.")
            With FirstNumTextBox
                .Focus()
                .SelectAll()
            End With

        End Try
    End Sub
End Class
