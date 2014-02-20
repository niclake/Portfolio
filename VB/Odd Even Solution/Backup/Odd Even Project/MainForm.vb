Option Explicit On
Option Strict On
Imports System.Globalization


Public Class MainForm

    Private Sub exitButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles exitButton.Click
        Me.Close()

    End Sub

    
    Private Sub calcButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles calcButton.Click
        'declare variables
        Dim inputValue As String
        Dim userValue, oddCount, oddTotal, evenCount, evenTotal As Integer
        Dim isConverted As Boolean

        'get user initial value
        inputValue = InputBox("Enter an integer.  Click Cancel to quit", "Odd Even")

        'loop to process all entries
        Do While inputValue <> String.Empty
            'convert value to integer
            isConverted = Integer.TryParse(inputValue, userValue)

            If userValue Mod 2 = 1 Then
                oddCount = oddCount + 1
                oddTotal = oddTotal + userValue
            Else
                evenCount = evenCount + 1
                evenTotal = evenTotal + userValue
            End If

            inputValue = InputBox("Enter an integer.  Click Cancel to quit", "Odd Even")

        Loop

        oddCountLabel.Text = oddCount.ToString
        oddTotalLabel.Text = oddTotal.ToString
        evenCountLabel.Text = evenCount.ToString
        evenTotalLabel.Text = evenTotal.ToString

    End Sub
End Class
