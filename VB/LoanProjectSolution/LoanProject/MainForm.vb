Public Class MainForm

    Private Sub CalcButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalcButton.Click
        'declare variables
        Dim SalaryDecimal As Decimal
        Dim YearsInteger As Integer
        Dim QualifyString As String

        'read in data and validate
        Try
            SalaryDecimal = Decimal.Parse(SalaryTextBox.Text)
            Try
                YearsInteger = Integer.Parse(YearsTextBox.Text)

                QualifyString = Qualify(SalaryDecimal, YearsInteger)


            Catch YearsException As FormatException

            End Try
        Catch SalaryException As FormatException

        End Try
    End Sub
End Class

Function Qualify(ByVal SalaryAmount As Decimal, ByVal Years As Integer) As String
    If SalaryAmount > 50000 Then
        If Years > 2 Then
            Qualify = "Qualified!"
        Else
            Qualify = "Not Qualified."
        End If
    Else
        If Years > 5 Then
            Qualify = "Qualified!"
        Else
            Qualify = "Not Qualified."
        End If
    End If
End Function