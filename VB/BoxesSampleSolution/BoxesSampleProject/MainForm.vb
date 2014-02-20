Public Class MainForm

    Private Sub ExitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    
    Private Sub ComboBoxButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxButton.Click
        'produce order summary in message box
        Dim OrderString As String

        'build string
        OrderString = "You have ordered a " & Environment.NewLine & _
        MeatComboBox.Text & " sandwich on " & BreadComboBox.Text & Environment.NewLine & _
        "with " & SaladComboBox.Text

        MessageBox.Show(OrderString, "Order Summary", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub ListboxSummaryButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListboxSummaryButton.Click
        'produce order summary in message box
        Dim OrderString As String

        'build string
        OrderString = "You have ordered a " & Environment.NewLine & _
        MeatListBox.SelectedItem & " sandwich on " & BreadListBox.SelectedItem & Environment.NewLine & _
        "with " & SaladListBox.SelectedItem

        MessageBox.Show(OrderString, "Order Summary", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub ResetButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResetButton.Click
        MeatListBox.ClearSelected()
        BreadListBox.ClearSelected()
        SaladListBox.ClearSelected()

        MeatComboBox.SelectedIndex = -1
        BreadComboBox.SelectedIndex = -1
        SaladComboBox.SelectedIndex = -1

    End Sub
End Class
