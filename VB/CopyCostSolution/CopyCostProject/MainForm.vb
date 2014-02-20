Public Class MainForm

    Private Sub ComputeCostButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComputeCostButton.Click
        Dim NumCopiesDecimal As Decimal
        Dim Cost As Decimal

        Try
            NumCopiesDecimal = Decimal.Parse(NumCopiesTextBox.Text)

            If NumCopiesDecimal <= 100 Then
                Cost = NumCopiesDecimal * 0.115
            Else
                Cost = 100 * 0.115 + (NumCopiesDecimal - 100) * 0.085
            End If

            CostTextBox.Text = Cost.ToString("C")

        Catch NumCopiesException As FormatException
            'handle exception for NumCopies
            MessageBox.Show("Invalid entry in number of copies box.  Please re-enter.", "Number of copies entry error")
            With NumCopiesTextBox
                .Focus()
                .SelectAll()
            End With
        End Try
    End Sub
End Class
