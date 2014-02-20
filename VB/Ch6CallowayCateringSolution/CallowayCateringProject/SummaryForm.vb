Public Class SummaryForm

    Private Sub SummaryForm_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        'display summary totals from MainForm
        EventsTextBox.Text = MainForm.TotalEventsInteger
        RevenueTextBox.Text = MainForm.TotalRevenueDecimal.ToString("C")
    End Sub

    Private Sub OKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKButton.Click
        Me.Hide()
    End Sub
End Class