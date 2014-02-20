'Programmer: Nic Lake
'Assignment: Health Club Solution
'Due Date  : 4 Oct 2010
'Goal      : Calculate amount owed based on # of months, membership type, and whether discount is present.

Public Class MainForm

    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        'declare all variables
        Dim MonthsInteger As Integer
        Dim CostDecimal As Decimal
        Const SINGLE_COST_Decimal As Decimal = 38
        Const FAMILY_COST_Decimal As Decimal = 58
        Const SENIOR_COST_Decimal As Decimal = 27
        Const DISCOUNT_Decimal As Decimal = 0.1D

        Try
            'read months text box
            MonthsInteger = Integer.Parse(MonthsTextBox.Text)

            'calculate costs
            Select Case MonthsInteger
                Case Is < 0
                    MessageBox.Show("Please enter the number of months that you would like to prepay.", "Prepaid months error.")
                    With MonthsTextBox
                        .Focus()
                        .SelectAll()
                    End With
                Case Is < 3
                    'Advise changing number of months
                    CostLabel.Text = "You must pre-pay at least 3 months in advance."
                    With MonthsTextBox
                        .Focus()
                        .SelectAll()
                    End With
                Case Is >= 3
                    'calculate base cost
                    If SingleRadioButton.Checked Then
                        CostDecimal = MonthsInteger * SINGLE_COST_Decimal
                    ElseIf FamilyRadioButton.Checked Then
                        CostDecimal = MonthsInteger * FAMILY_COST_Decimal
                    ElseIf SeniorRadioButton.Checked Then
                        CostDecimal = MonthsInteger * SENIOR_COST_Decimal
                    Else
                        CostLabel.Text = "Please select a membership type above."
                    End If

                    'Check for discount, and display
                    If DiscountCheckBox.Checked Then
                        CostDecimal = CostDecimal * (1 - DISCOUNT_Decimal)
                        CostLabel.Text = "Payment required: " & CostDecimal.ToString("C")
                    Else
                        CostLabel.Text = "Payment required: " & CostDecimal.ToString("C")
                    End If
            End Select

        Catch MonthsException As FormatException
            MessageBox.Show("Please enter the number of months that you would like to prepay.", "Prepaid months error.")
            With MonthsTextBox
                .Focus()
                .SelectAll()
            End With
        End Try
    End Sub

    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        'Clear everything
        CostLabel.Text = ""
        MonthsTextBox.Text = ""
        SingleRadioButton.Checked = True
        MonthsTextBox.Focus()
    End Sub
End Class
