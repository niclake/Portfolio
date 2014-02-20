Option Explicit On
Option Strict On
Imports System.Globalization

Public Class MainForm

    Private Sub MainForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'fill listbox with a few course numbers
        coursesListBox.Items.Add("150:032")
        coursesListBox.Items.Add("150:034")
        coursesListBox.Items.Add("150:112")
        coursesListBox.Items.Add("150:120")
        coursesListBox.Items.Add("150:125")
        coursesListBox.Items.Add("150:140")

    End Sub

    Private Sub coursesListBox_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles coursesListBox.SelectedValueChanged
        'declare variables
        Dim selection As Integer
        ' get users choice
        selection = coursesListBox.SelectedIndex

        'find and display course name
        Select Case selection
            Case 0
                courseNameLabel.Text = "Introduction to Business Programming"
            Case 1
                courseNameLabel.Text = "Business Programming"
            Case 2
                courseNameLabel.Text = "Systems Analysis and Design"
            Case 3
                courseNameLabel.Text = "Database Management and Theory"
            Case 4
                courseNameLabel.Text = "Information Systems Development"
            Case 5
                courseNameLabel.Text = "MIS Policy"
        End Select
    End Sub
End Class
