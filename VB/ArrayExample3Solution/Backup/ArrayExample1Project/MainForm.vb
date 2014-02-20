Option Explicit On
Option Strict On


Public Class MainForm



    Private salesGoal() As Decimal = {35000D, 55000D, 62500D, 77000D}
    Private actualSales(3) As Decimal

    Private Sub exitButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub


    Private Sub MainForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'get actual sales for each region from user
        For index As Integer = 1 To 4
            actualSales(index - 1) = Convert.ToDecimal(InputBox("Enter actual sales for region " & index & ":", "Array Example 3"))
        Next index
    End Sub

    Private Sub displayButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles processButton.Click
        'declare variable
        Dim index As Integer

        'compare each actual sales figure with sales goal and display correct message
        For index = 0 To 3
            If actualSales(index) < salesGoal(index) Then
                goalLabel.Text = goalLabel.Text & "Region " & index + 1 & " missed its sales goal" & ControlChars.NewLine
            ElseIf actualSales(index) = salesGoal(index) Then
                goalLabel.Text = goalLabel.Text & "Region " & index + 1 & " met its sales goal" & ControlChars.NewLine
            Else
                goalLabel.Text = goalLabel.Text & "Region " & index + 1 & " exceeded its sales goal" & ControlChars.NewLine

            End If
        Next index
    End Sub
End Class
