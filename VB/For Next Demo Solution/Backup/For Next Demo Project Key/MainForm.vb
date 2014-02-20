'project name:
'Project purpose:
'Created/revised by:

Option Explicit On
Option Strict On

Imports System.Globalization

Public Class MainForm

    

    Private Sub clearButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clearButton.Click
        'clear textboxes and display label on form

        startTextBox.Clear()
        endTextBox.Clear()
        stepTextBox.Clear()
        displayLabel.Text = String.Empty

        'set focus in Initial value textbox
        startTextBox.Focus()

    End Sub

    
    Private Sub quitButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles quitButton.Click
        Me.Close()

    End Sub
End Class
