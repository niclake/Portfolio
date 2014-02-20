'project name:
'Project purpose:
'Created/revised by:

Option Explicit On
Option Strict On


Public Class MainForm

    Private Sub ClearButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearButton.Click
        'clear textboxes and display label on form

        StartTextBox.Clear()
        EndTextBox.Clear()
        StepTextBox.Clear()
        DisplayLabel.Text = String.Empty

        'set focus in Initial value textbox
        StartTextBox.Focus()

    End Sub

    Private Sub QuitButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles QuitButton.Click
        Me.Close()

    End Sub

    Private Sub DisplayButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DisplayButton.Click
        Dim StartDecimal, EndDecimal, StepDecimal, TotalDecimal As Decimal

        DisplayLabel.Text = ""

        StartDecimal = Decimal.Parse(StartTextBox.Text)
        EndDecimal = Decimal.Parse(EndTextBox.Text)
        StepDecimal = Decimal.Parse(StepTextBox.Text)

        For CountDecimal As Decimal = StartDecimal To EndDecimal Step StepDecimal
            DisplayLabel.Text = DisplayLabel.Text & CountDecimal & Environment.NewLine
            TotalDecimal = TotalDecimal + CountDecimal
        Next CountDecimal

        DisplayLabel.Text = DisplayLabel.Text & "Total: " & TotalDecimal
    End Sub
End Class