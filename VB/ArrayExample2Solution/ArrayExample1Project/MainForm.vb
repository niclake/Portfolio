Option Explicit On
Option Strict On


Public Class MainForm

    Private SalesGoalDecimal() As Decimal = {35000, 55000, 62500, 77000}

    Private Sub clearButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ClearButton.Click
        'remove selection from list box
        RegionsListBox.ClearSelected()

        'remove sales goal from label
        GoalLabel.Text = ""

    End Sub

    Private Sub exitButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'load region numbers in the list box
        For IndexInteger As Integer = 1 To 4
            RegionsListBox.Items.Add(IndexInteger.ToString)
        Next IndexInteger
    End Sub

    Private Sub RegionsListBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegionsListBox.SelectedIndexChanged
        'display sales goal for selected region
        If RegionsListBox.SelectedIndex <> -1 Then
            GoalLabel.Text = SalesGoalDecimal(RegionsListBox.SelectedIndex).ToString("C")
        End If
    End Sub
End Class
