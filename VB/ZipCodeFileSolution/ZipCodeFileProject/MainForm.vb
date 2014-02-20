'Project:    Zip Code Search with file handling
'Programmer:
'Date:       December 2010
'Purpose:    This project reads an input file of cities/zip codes.
'            The standard file handling dialog boxes for opening and saving files are used
'            New cities/zip codes can be added by the user and saved to the file.
Option Strict On
Imports System.IO

Public Class MainForm
    Structure ZipCodes
        Dim CityString As String
        Dim ZipCodeString As String
    End Structure
    Private MyZipCodes() As ZipCodes
    Private NumCitiesInteger As Integer
    Private ZipCodeReader As StreamReader

    Private Sub ByCityToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ByCityToolStripMenuItem.Click
        'Get user's entry of city; search and display correct zip code.
        'Declare variables
        Dim SearchCityString As String
        Dim MatchFoundBoolean As Boolean
        Dim IndexInteger As Integer

        'initialize variables
        MatchFoundBoolean = False
        IndexInteger = 0
        SearchCityString = CityTextBox.Text

        'Search for match
        If SearchCityString <> "" Then  'check for blank City
            For IndexInteger = 0 To MyZipCodes.Length - 1
                If InStr(MyZipCodes(IndexInteger).CityString.ToUpper, SearchCityString.ToUpper) > 0 Then
                    CityListBox.Items.Add(MyZipCodes(IndexInteger).CityString)
                End If
            Next IndexInteger
        Else
            'handle empty textbox situation
            MessageBox.Show("Please enter a city for the search", "Missing City")
        End If
    End Sub

    Private Sub ClearFormToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearFormToolStripMenuItem.Click
        CityTextBox.Clear()
        ZipCodeTextBox.Clear()
        CityTextBox.Focus()
        CityListBox.Items.Clear()
    End Sub

    Private Sub ByZipCodeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ByZipCodeToolStripMenuItem.Click
        'Get user's entry of zip code; search and display correct city.
        'Declare variables
        Dim SearchzipString As String
        Dim MatchFoundBoolean As Boolean
        Dim IndexInteger As Integer

        'initialize variables
        MatchFoundBoolean = False
        IndexInteger = 0
        SearchzipString = ZipCodeTextBox.Text

        'Search for match
        If SearchzipString <> "" Then  'check for blank zip code
            Do Until MatchFoundBoolean Or IndexInteger > MyZipCodes.Length - 1
                If SearchzipString = MyZipCodes(IndexInteger).ZipCodeString Then
                    MatchFoundBoolean = True
                    CityTextBox.Text = MyZipCodes(IndexInteger).CityString
                Else
                    IndexInteger = IndexInteger + 1
                End If
            Loop

            'handle no match situation
            If Not MatchFoundBoolean Then
                MessageBox.Show("No city available for that zip code", "Not Found")
                ZipCodeTextBox.Focus()
                ZipCodeTextBox.SelectAll()
            End If

        Else
            'handle empty textbox situation
            MessageBox.Show("Please enter a zip code for the search", "Missing zip code")
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub HelpToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpToolStripMenuItem.Click
        MessageBox.Show("You must open the file of zipcodes before you can search.  Select File | Open, and choose the zipcode file you wish to use", "Getting Started")

    End Sub

    Private Sub OpenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripMenuItem.Click
        'declarations
        Dim ResponseDialogResult As DialogResult
        Dim LineString As String
        Dim FieldsString() As String
        Dim Delimiter As Char = CChar(",")

        'set up and display the open file dialog box
        With OpenFileDialog1
            'begin in the current directory
            .InitialDirectory = Directory.GetCurrentDirectory
            .FileName = "ZipCodes.txt"
            .Title = "Select file to open or directory for the file"

            'display the open file dialog box
            ResponseDialogResult = .ShowDialog()

            'handle the user's response
            If ResponseDialogResult <> Windows.Forms.DialogResult.Cancel Then
                ZipCodeReader = New StreamReader(.FileName)

            End If
        End With

        'perform loop to enter entire file into the array
        Do While ZipCodeReader.Peek <> -1
            'resize array
            ReDim Preserve MyZipCodes(NumCitiesInteger)

            'read in a line of data from file
            LineString = ZipCodeReader.ReadLine

            'split the line of data into its components
            FieldsString = LineString.Split(Delimiter)

            'assign values to correct positions in array
            MyZipCodes(NumCitiesInteger).CityString = FieldsString(0)
            MyZipCodes(NumCitiesInteger).ZipCodeString = FieldsString(1)

            'incriment counter
            NumCitiesInteger = NumCitiesInteger + 1
        Loop
        'close input file
        ZipCodeReader.Close()
        'message to user
        MessageBox.Show("File has been loaded.", "File loaded")
    End Sub

    Private Sub CityListBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CityListBox.SelectedIndexChanged
        'find row with city name and display the zip code for that city

        Dim MatchFoundBoolean As Boolean
        Dim IndexInteger As Integer

        MatchFoundBoolean = False
        IndexInteger = 0

        Do Until MatchFoundBoolean
            If MyZipCodes(IndexInteger).CityString = CityListBox.SelectedItem.ToString Then
                MatchFoundBoolean = True
                ZipCodeTextBox.Text = MyZipCodes(IndexInteger).ZipCodeString
                CityTextBox.Text = MyZipCodes(IndexInteger).CityString
            Else
                IndexInteger = IndexInteger + 1
            End If
        Loop
    End Sub

    Private Sub CityToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CityToolStripMenuItem.Click
        Dim NewCityString As String
        Dim NewZipCodeString As String

        'get user values from text boxes
        NewCityString = CityTextBox.Text
        NewZipCodeString = ZipCodeTextBox.Text

        If NewCityString <> "" Then
            If NewZipCodeString <> "" Then
                'resize array
                ReDim Preserve MyZipCodes(NumCitiesInteger)
                'assign each value to correct array position
                MyZipCodes(NumCitiesInteger).CityString = NewCityString
                MyZipCodes(NumCitiesInteger).ZipCodeString = NewZipCodeString

                'increment counter
                NumCitiesInteger = NumCitiesInteger + 1
            Else
                MessageBox.Show("Zip code text box is empty.", "Entry error")
                ZipCodeTextBox.Focus()
            End If
        Else
            MessageBox.Show("City text box is empty.", "Entry error")
            CityTextBox.Focus()
        End If
    End Sub
End Class
