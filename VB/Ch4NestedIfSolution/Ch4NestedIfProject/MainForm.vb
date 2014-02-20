Option Strict On

Public Class MainForm

    Private Sub ClearButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearButton.Click
        'Clear textboxes
        QuantityTextBox.Clear()
        DiscountTextBox.Clear()

        'reset radio button
        StdRadioButton.Checked = True

    End Sub

    Private Sub ExitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitButton.Click
        'close application
        Me.Close()

    End Sub

    
    Private Sub FindButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FindButton.Click
        Dim QuantityInteger As Integer
        Dim DiscountDecimal As Decimal

        'get quantity input value
        QuantityInteger = Integer.Parse(QuantityTextBox.Text)

        'If StdRadioButton.Checked Then
        '    If QuantityInteger <= 200 Then
        '        DiscountDecimal = 0
        '    ElseIf QuantityInteger <= 400 Then
        '        DiscountDecimal = 0.03D
        '    Else
        '        DiscountDecimal = 0.06D
        '    End If

        'ElseIf SpecialRadioButton.Checked Then
        '    If QuantityInteger <= 200 Then
        '        DiscountDecimal = 0.02D
        '    ElseIf QuantityInteger <= 400 Then
        '        DiscountDecimal = 0.05D
        '    Else
        '        DiscountDecimal = 0.08D
        '    End If

        'ElseIf PreferredRadioButton.Checked Then
        '    If QuantityInteger <= 200 Then
        '        DiscountDecimal = 0.04D
        '    ElseIf QuantityInteger <= 400 Then
        '        DiscountDecimal = 0.07D
        '    Else
        '        DiscountDecimal = 0.1D
        '    End If
        'Else
        '    MessageBox.Show("Please select one of the radio buttons.", "Radio button error")
        '    StdRadioButton.Focus()
        '    StdRadioButton.Checked = False
        'End If

        Select Case QuantityInteger
            Case 0 To 200
                If StdRadioButton.Checked Then
                    DiscountDecimal = 0
                ElseIf SpecialRadioButton.Checked Then
                    DiscountDecimal = 0.02D
                ElseIf PreferredRadioButton.Checked Then
                    DiscountDecimal = 0.04D
                Else
                    MessageBox.Show("Please select one of the radio buttons.", "Radio button error")
                    StdRadioButton.Focus()
                    StdRadioButton.Checked = False
                End If
            Case 201 To 400
                If StdRadioButton.Checked Then
                    DiscountDecimal = 0.03D
                ElseIf SpecialRadioButton.Checked Then
                    DiscountDecimal = 0.05D
                ElseIf PreferredRadioButton.Checked Then
                    DiscountDecimal = 0.07D
                Else
                    MessageBox.Show("Please select one of the radio buttons.", "Radio button error")
                    StdRadioButton.Focus()
                    StdRadioButton.Checked = False
                End If
            Case Is > 400
                If StdRadioButton.Checked Then
                    DiscountDecimal = 0.06D
                ElseIf SpecialRadioButton.Checked Then
                    DiscountDecimal = 0.08D
                ElseIf PreferredRadioButton.Checked Then
                    DiscountDecimal = 0.1D
                Else
                    MessageBox.Show("Please select one of the radio buttons.", "Radio button error")
                    StdRadioButton.Focus()
                    StdRadioButton.Checked = False
                End If
        End Select

        DiscountTextBox.Text = DiscountDecimal.ToString("P")
    End Sub
End Class
