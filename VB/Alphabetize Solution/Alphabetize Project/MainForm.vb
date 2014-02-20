'Program:    Alphabetize words
'Programmer: R Roth
'Date:       October 2010
'Purpose:    To demonstrate creating a sub that will put three strings in alphabetical order

Option Strict On

Public Class MainForm

    Private Sub AlphabetizeButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles AlphabetizeButton.Click
        'Declare variables for three input words
        Dim FirstWord, SecondWord, ThirdWord As String

        'verify entries in each textbox and handle blank textboxes
        If FirstWordTextBox.Text <> "" Then
            If SecondWordTextBox.Text <> "" Then
                If ThirdWordTextBox.Text <> "" Then

                    'input user values from textboxes
                    FirstWord = FirstWordTextBox.Text
                    SecondWord = SecondWordTextBox.Text
                    ThirdWord = ThirdWordTextBox.Text

                    'call sequence sub
                    Call Sequence(FirstWord, SecondWord, ThirdWord)

                    'Display words in textbox
                    ResultTextBox.Text = FirstWord & " " & SecondWord & " " & ThirdWord

                Else 'handle missing third word
                    MessageBox.Show("Please make an entry in the third text box", "Missing Data")
                    With ThirdWordTextBox
                        .Focus()
                    End With
                End If
            Else 'handle missing second word
                MessageBox.Show("Please make an entry in the second text box", "Missing Data")
                With SecondWordTextBox
                    .Focus()
                End With
            End If
        Else 'handle missing first word
            MessageBox.Show("Please make an entry in the first text box", "Missing Data")
            With FirstWordTextBox
                .Focus()
            End With
        End If

    End Sub

    Sub Sequence(ByRef Word1String As String, ByRef Word2String As String, ByRef Word3String As String)
        If Word1String > Word2String Then
            Dim TempString As String
            TempString = Word1String
            Word1String = Word2String
            Word2String = TempString
        End If
        If Word1String > Word3String Then
            Dim TempString As String
            TempString = Word1String
            Word1String = Word3String
            Word3String = TempString
        End If
        If Word2String > Word3String Then
            Dim TempString As String
            TempString = Word2String
            Word2String = Word3String
            Word3String = TempString
        End If
    End Sub

    Private Sub ClearButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ClearButton.Click
        'clear textboxes
        SecondWordTextBox.Clear()
        ThirdWordTextBox.Clear()

        With FirstWordTextBox
            .Clear()
            .Focus()

        End With
    End Sub

    Private Sub ExitButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ExitButton.Click
        Me.Close()

    End Sub
End Class
