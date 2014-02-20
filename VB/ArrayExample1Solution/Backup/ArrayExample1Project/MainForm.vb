Option Explicit On
Option Strict On


Public Class MainForm

    






    Private Sub clearButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ClearButton.Click
        'remove entries from list box
        EntriesListBox.Items.Clear()

    End Sub

    Private Sub exitButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub


   


   
    
End Class
