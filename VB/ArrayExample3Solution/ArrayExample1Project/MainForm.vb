Option Explicit On
Option Strict On


Public Class MainForm

    Private SalesGoalDecimal() As Decimal = {35000, 55000, 62500, 77000}
    Private ActualSalesDecimal(3) As Decimal


    

    Private Sub ExitButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub


    

   
    

   

    
  
    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'get the user entry of actual sales for the four regions

        For IndexInteger As Integer = 1 To 4
            ActualSalesDecimal(IndexInteger - 1) = Convert.ToDecimal(InputBox("Enter the actual sales for Region " & IndexInteger & ":", "Actual Sales"))

        Next IndexInteger
    End Sub

    Private Sub ProcessButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProcessButton.Click
        'compare array values and display result of comparison

        For IndexInteger As Integer = 0 To 3
            If ActualSalesDecimal(IndexInteger) > SalesGoalDecimal(IndexInteger) Then
                GoalLabel.Text = GoalLabel.Text & "Region " & IndexInteger + 1 & " exceeded its sales goal." & Environment.NewLine
            ElseIf ActualSalesDecimal(IndexInteger) < SalesGoalDecimal(IndexInteger) Then
                GoalLabel.Text = GoalLabel.Text & "Region " & IndexInteger + 1 & " did not exceeded its sales goal." & Environment.NewLine
            Else
                GoalLabel.Text = GoalLabel.Text & "Region " & IndexInteger + 1 & " met its sales goal." & Environment.NewLine
            End If
        Next
    End Sub
End Class
