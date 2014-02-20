Option Explicit On
Option Strict On



Public Class MainForm


    Private Sub ExitButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ExitButton.Click
        Me.Close()

    End Sub

    
    Private Sub StartButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StartButton.Click
        'get words from user until user enters 'end'
        Dim InputString As String

        'get initial word from user
        InputString = InputBox("Please enter a word, or 'end' to quit.", "Do loop example")

        'loop to add user's words to listbox until user wants to quit
        Do Until InputString.ToLower = "end"
            DisplayListBox.Items.Add(InputString)
            'get another word from user
            InputString = InputBox("Please enter a word, or 'end' to quit.", "Do loop example")
        Loop
    End Sub

End Class
