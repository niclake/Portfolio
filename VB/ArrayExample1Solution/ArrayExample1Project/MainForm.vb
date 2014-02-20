Option Explicit On
Option Strict On


Public Class MainForm
    'declare the array as module-level array
    Private AnimalNames() As String       'declared as empty array
    Private NumElementsInteger As Integer       'represents number of items in array -default value = 0


    Private Sub clearButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ClearButton.Click
        'remove entries from list box
        EntriesListBox.Items.Clear()

    End Sub

    Private Sub exitButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

   
    
   
    Private Sub DisplayButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DisplayButton.Click
        ''display the values from array in list box using FOR/NEXT loop
        'For IndexInteger As Integer = 0 To AnimalNames.Length - 1
        '    EntriesListBox.Items.Add(AnimalNames(IndexInteger))
        'Next IndexInteger

        'display values from array in listbox using FOR/EACH loop
        For Each OneAnimalString As String In AnimalNames
            EntriesListBox.Items.Add(OneAnimalString)
        Next

    End Sub

    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ''assign values to array elements
        'AnimalNames(0) = "skunk"
        'AnimalNames(1) = "bear"
        'AnimalNames(2) = "fox"
        'AnimalNames(3) = "deer"
        'AnimalNames(4) = "squirrel"

        ''get array values from user
        'For CountInteger As Integer = 0 To AnimalNames.Length - 1
        '    AnimalNames(CountInteger) = InputBox("Enter the name of an aanimal", "User Entry")
        'Next CountInteger



        'get unknown number of entries from user
        Dim UserEntryString As String
        'get inital user entry
        UserEntryString = InputBox("Please enter name of animal, or 'end' to quit", "User Entry")

        Do Until UserEntryString.ToUpper = "END"
            ReDim Preserve AnimalNames(NumElementsInteger)
            AnimalNames(NumElementsInteger) = UserEntryString
            NumElementsInteger = NumElementsInteger + 1

            'get another user entry
            UserEntryString = InputBox("Please enter name of animal, or 'end' to quit", "User Entry")
        Loop


    End Sub
End Class
