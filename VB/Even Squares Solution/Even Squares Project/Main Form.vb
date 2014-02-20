' Project name:         Even Squares Project
' Project purpose:      The project displays the squares of the even
'                               integers over a range of values
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On

Public Class MainForm

    Private Sub ExitButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    
   
    Private Sub DisplayButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DisplayButton.Click
        Dim NumSquaredInteger, StartInteger, EndInteger As Integer

        StartInteger = Integer.Parse(InputBox("Please enter an integer to begin the series.", "Starting point"))
        EndInteger = Integer.Parse(InputBox("Please enter an integer to end the series.", "Ending point"))

        For IndexInteger As Integer = StartInteger To EndInteger Step 2
            NumSquaredInteger = IndexInteger * IndexInteger
            SquaresLabel.Text = SquaresLabel.Text & NumSquaredInteger.ToString & Environment.NewLine

        Next IndexInteger

    End Sub
End Class
