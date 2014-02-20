Public Class MainForm

    Private Sub CalcButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalcButton.Click
        Dim Deposit, IRate As Decimal
        Dim Counter As Integer

        Deposit = Decimal.Parse(DepositTextBox.Text)
        IRate = InterestListBox.SelectedItem / 100

        For Counter = 3 To 15 Step 3
            InvestmentLabel.Text = InvestmentLabel.Text & _
            "Investment value after " & Counter & " years: " & _
            Financial.FV(IRate, Counter, -(Deposit), 0, DueDate.BegOfPeriod).ToString("C") & _
            Environment.NewLine
        Next Counter
    End Sub
End Class
