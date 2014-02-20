' Zip Code Finder
' November 2010
' To learn how to work with a data structure

Public Class MainForm

    Structure ZipCodes
        Dim CityString As String
        Dim ZipString As String
    End Structure

    Private MyZipCodes(6) As ZipCodes


    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        'Close application
        Me.Close()
    End Sub

    Private Sub ClearToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearToolStripMenuItem.Click
        'Clear form
        CityTextBox.Text = ""
        ZipCodeTextBox.Text = ""
        CityTextBox.Focus()
    End Sub

    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'load values into array
        MyZipCodes(0).CityString = "Cedar Falls"
        MyZipCodes(0).ZipString = "50613"

        MyZipCodes(1).CityString = "Denver"
        MyZipCodes(1).ZipString = "50622"

        MyZipCodes(2).CityString = "Janesville"
        MyZipCodes(2).ZipString = "50647"

        MyZipCodes(3).CityString = "Waverly"
        MyZipCodes(3).ZipString = "50677"

        MyZipCodes(4).CityString = "Evansdale"
        MyZipCodes(4).ZipString = "50607"

        MyZipCodes(5).CityString = "Hudson"
        MyZipCodes(5).ZipString = "50643"

        MyZipCodes(6).CityString = "Dike"
        MyZipCodes(6).ZipString = "50624"

    End Sub


    Private Sub ByCityToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ByCityToolStripMenuItem1.Click
        'get users entry of city name, and search for that city's zip code

        Dim UserCityString As String
        Dim MatchFoundBoolean As Boolean
        Dim IndexInteger As Integer

        'initialize variables
        MatchFoundBoolean = False
        IndexInteger = 0

        'Get user input
        UserCityString = CityTextBox.Text

        'search for match
        If UserCityString <> "" Then
            'search loop
            Do Until MatchFoundBoolean Or IndexInteger > MyZipCodes.Length - 1
                If UserCityString.ToUpper = MyZipCodes(IndexInteger).CityString.ToUpper Then
                    MatchFoundBoolean = True
                    ZipCodeTextBox.Text = MyZipCodes(IndexInteger).ZipString
                Else
                    IndexInteger = IndexInteger + 1
                End If
            Loop

            'handle no match found
            If MatchFoundBoolean = False Then
                MessageBox.Show("No information for that city. Please try another.", "No information")
                CityTextBox.Focus()
                CityTextBox.SelectAll()
            End If

        Else
            'handle blank textbox
            MessageBox.Show("Must enter a city name.", "No data")
            CityTextBox.Focus()
        End If
    End Sub

    Private Sub ByZipCodeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ByZipCodeToolStripMenuItem.Click
        'get users entry of zip code, and search for that city's name

        Dim UserZipString As String
        Dim MatchFoundBoolean As Boolean
        Dim IndexInteger As Integer

        'initialize variables
        MatchFoundBoolean = False
        IndexInteger = 0

        'Get user input
        UserZipString = ZipCodeTextBox.Text

        'search for match
        If UserZipString <> "" Then
            'search loop
            Do Until MatchFoundBoolean Or IndexInteger > MyZipCodes.Length - 1
                If UserZipString = MyZipCodes(IndexInteger).ZipString Then
                    MatchFoundBoolean = True
                    CityTextBox.Text = MyZipCodes(IndexInteger).CityString
                Else
                    IndexInteger = IndexInteger + 1
                End If
            Loop

            'handle no match found
            If MatchFoundBoolean = False Then
                MessageBox.Show("No information for that zip code. Please try another.", "No information")
                ZipCodeTextBox.Focus()
                ZipCodeTextBox.SelectAll()
            End If

        Else
            'handle blank textbox
            MessageBox.Show("Must enter a zip code.", "No data")
            ZipCodeTextBox.Focus()
        End If
    End Sub
End Class
