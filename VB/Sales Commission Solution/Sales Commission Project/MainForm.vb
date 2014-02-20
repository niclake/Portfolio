'Project:    Sales Commission Calculator  
'Programmer:
'Date:       September 2010
'purpose:    Demonstrate two-way decision logic using numeric value comparisons

Option Strict On



Public Class MainForm

   

    Private Sub ClearButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ClearButton.Click
        'Clear textboxes
        SalesGoalTextBox.Clear()
        CommissionTextBox.Clear()
        With SalesTextBox
            .Clear()
            .Focus()
        End With
    End Sub

    Private Sub ExitButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ExitButton.Click
        Me.Close()

    End Sub

    
    Private Sub CalculateButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalculateButton.Click
        'declare variables
        Dim ActualSalesDecimal, SalesGoalDecimal, CommissionDecimal As Decimal

        'declare constants
        Const HI_RATE_Decimal As Decimal = 0.2D
        Const LOW_RATE_Decimal As Decimal = 0.1D

        'get input values
        ActualSalesDecimal = Decimal.Parse(SalesTextBox.Text)
        SalesGoalDecimal = Decimal.Parse(SalesGoalTextBox.Text)

        'decision logic to calculate commission
        If ActualSalesDecimal >= (SalesGoalDecimal * 1.25) Then
            CommissionDecimal = ActualSalesDecimal * HI_RATE_Decimal
        Else
            CommissionDecimal = ActualSalesDecimal * LOW_RATE_Decimal
        End If

        'display commission
        CommissionTextBox.Text = CommissionDecimal.ToString("C")

    End Sub
End Class
