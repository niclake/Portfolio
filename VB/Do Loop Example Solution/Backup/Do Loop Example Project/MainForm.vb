Option Explicit On
Option Strict On
Imports System.Globalization


Public Class MainForm

    Private Sub startButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles startButton.Click
        'Declare variables
        Dim inputValue As String

        'Initialize user input value
        inputValue = InputBox("Please enter a word or phrase of your choice or 'End' to quit", "Do Loop Example")

        'Loop to get and display user's entries
        Do Until inputValue.ToUpper = "END"

            DisplayLabel.Text = DisplayLabel.Text & inputValue & ControlChars.NewLine
            inputValue = InputBox("Please enter a word or phrase of your choice or 'End' to quit", "Do Loop Example")
        Loop
    End Sub

    Private Sub exitButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles exitButton.Click
        Me.Close()

    End Sub
End Class
