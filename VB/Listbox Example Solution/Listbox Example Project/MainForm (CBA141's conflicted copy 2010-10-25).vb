'Project:        List Box Project
'Date:           October 22, 2010
'Programmed by:
'Purpose:        To practice with listboxes

Option Explicit On



Public Class MainForm



    Private Sub ExitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub MainForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'assign values to list box
        CoursesListBox.Items.Add("150:032")
        CoursesListBox.Items.Add("150:034")
        CoursesListBox.Items.Add("150:112")
        CoursesListBox.Items.Add("150:120")
        CoursesListBox.Items.Add("150:125")
        CoursesListBox.Items.Add("150:140")
    End Sub

    Private Sub CoursesListBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CoursesListBox.SelectedIndexChanged
        'find and display course name for the selected course
        Select Case CoursesListBox.SelectedIndex
            Case 0
                CourseNameLabel.Text = "Business Application Development I"
            Case 1
                CourseNameLabel.Text = "Business Application Development II"
            Case 2
                CourseNameLabel.Text = "Systems Analysis and Design"
            Case 3
                CourseNameLabel.Text = "Database Management"
            Case 4
                CourseNameLabel.Text = "Information Systems Development"
            Case 5
                CourseNameLabel.Text = "Information Systems Management"
        End Select
    End Sub

    Private Sub ClearButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearButton.Click
        'clear form
        CourseNameLabel.Text = ""
        CoursesListBox.ClearSelected()
    End Sub
End Class
