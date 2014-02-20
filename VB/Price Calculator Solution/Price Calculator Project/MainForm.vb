'Project:     Price Calculator 
'Programmer:  
'Date:        September 2010
'Purpose:     Demonstrate one-way decision logic using string value comparisons

Option Strict On

Public Class MainForm



    Private Sub ClearButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearButton.Click
        'clear textboxes

        PriceTextBox.Clear()
        NewPriceTextBox.Clear()
        MessageLabel.Text = ""

        'clear and set focus in Product textbox
        With ProductTextBox
            .Clear()
            .Focus()
        End With

    End Sub

    Private Sub QuitButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles QuitButton.Click
        'close application
        Me.Close()

    End Sub


    Private Sub CalculateButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalculateButton.Click
        'declare variables
        Dim ProductTypeString As String
        Dim PriceDecimal As Decimal

        'declare constant
        Const PRICE_INCREASE_FACTORDecimal As Decimal = 0.1D

        'get user entries
        ProductTypeString = ProductTextBox.Text
        Try
            PriceDecimal = Decimal.Parse(PriceTextBox.Text)

            'decision logic to determine if price increase applies
            If ProductTypeString.ToLower = "jacket" Or ProductTypeString.ToLower = "sweater" Then
                PriceDecimal = PriceDecimal + (PriceDecimal * PRICE_INCREASE_FACTORDecimal)
                MessageLabel.Text = "**Increase**"
            End If

            'display price on form
            NewPriceTextBox.Text = PriceDecimal.ToString("C")

        Catch ex As Exception

        End Try
    End Sub
End Class
