'Project:           Simple Array Example
'Programmer:
'Date:              November 2010
'Purpose:           To demonstrate the creation and use of an array

Public Class MainForm
    Private ProductNameString(9) As String

    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Load array with values
        ProductNameString(0) = "Paper"
        ProductNameString(1) = "Pencil"
        ProductNameString(2) = "Pen"
        ProductNameString(3) = "Ruler"
        ProductNameString(4) = "Stapler"
        ProductNameString(5) = "Notebook"
        ProductNameString(6) = "Envelope"
        ProductNameString(7) = "Paper clip"
        ProductNameString(8) = "Glue"
        ProductNameString(9) = "Highlighter"
        MessageBox.Show("Array is loaded", "Feedback")
    End Sub

    Private Sub ExitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitButton.Click
        'close the application
        Me.Close()
    End Sub

    Private Sub SearchButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchButton.Click
        'search for match to user's product entry
        Dim MatchFoundBoolean As Boolean = False
        Dim SearchString As String

        'get user's entry
        SearchString = ProductTextBox.Text

        'search for match
        If SearchString <> "" Then
            '    For Each OneProductString In ProductNameString
            '        If OneProductString.ToUpper = SearchString.ToUpper Then
            '            MatchFoundBoolean = True
            '        End If
            '    Next

            For IndexInteger As Integer = 0 To ProductNameString.Length - 1
                If ProductNameString(IndexInteger).ToUpper = SearchString.ToUpper Then
                    MatchFoundBoolean = True
                End If
            Next

            If MatchFoundBoolean Then
                MessageBox.Show(SearchString & " is available.", "Match found")
                ProductTextBox.Focus()
            Else
                MessageBox.Show(SearchString & " is not available.", "Match not found")
                ProductTextBox.Focus()
            End If

        Else
            MessageBox.Show("Please make an entry in the search box.", "Search error")
        End If

        
    End Sub
End Class
