Imports System.IO

Public Class MainForm
    Structure Meals
        Dim NumberString As String
        Dim NameString As String
        Dim CategoryString As String
        Dim GroupString As String
        Dim ServingsInteger As Integer
        Dim PrepInteger As Integer
        Dim VeganBoolean As Boolean
    End Structure
    Private MyMeals() As Meals
    Private MealsReader As StreamReader
    Private NumMealsInteger As Integer

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        'close app
        Me.Close()
    End Sub

    Private Sub ClearButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearButton.Click
        'clear all elements
        NumberTextBox.Text = ""
        NameTextBox.Text = ""
        CategoryComboBox.SelectedIndex = -1
        GroupComboBox.SelectedIndex = -1
        ServingsTextBox.Text = ""
        PrepTextBox.Text = ""
        VeganComboBox.SelectedIndex = -1
        RecipeListBox.Items.Clear()
    End Sub

    Private Sub HelpToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpToolStripMenuItem.Click
        'display message box
        MessageBox.Show("Please remember to open a file prior to attempting a search.", "Help")
    End Sub

    Private Sub OpenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripMenuItem.Click
        'declarations
        Dim ResponseDialogResult As DialogResult
        Dim LineString As String
        Dim FieldsString() As String
        Dim Delimiter As Char = CChar(",")

        'set up and display the open file dialog box
        With OpenFileDialog1
            'current directory
            .InitialDirectory = Directory.GetCurrentDirectory
            .FileName = "recipelist.txt"
            .Title = "Select file to open or directory for the file"

            'display open file dialog box
            ResponseDialogResult = .ShowDialog()

            'handle the user's response
            If ResponseDialogResult <> Windows.Forms.DialogResult.Cancel Then
                MealsReader = New StreamReader(.FileName)

            End If
        End With

        'perform loop to enter entire file into the array
        Do While MealsReader.Peek <> -1
            'resize array
            ReDim Preserve MyMeals(NumMealsInteger)

            'read in a line of data from file
            LineString = MealsReader.ReadLine

            'split the line of data into its components
            FieldsString = LineString.Split(Delimiter)

            'assign values to correct positions in array
            MyMeals(NumMealsInteger).NumberString = FieldsString(0)
            MyMeals(NumMealsInteger).NameString = FieldsString(1)
            MyMeals(NumMealsInteger).CategoryString = FieldsString(2)
            MyMeals(NumMealsInteger).GroupString = FieldsString(3)
            MyMeals(NumMealsInteger).ServingsInteger = FieldsString(4)
            MyMeals(NumMealsInteger).PrepInteger = FieldsString(5)
            MyMeals(NumMealsInteger).VeganBoolean = FieldsString(6)

            'incriment counter
            NumMealsInteger = NumMealsInteger + 1
        Loop
        'close input file
        MealsReader.Close()
        'message to user
        MessageBox.Show("File has been loaded.", "File loaded")
    End Sub

    Private Sub NumberButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumberButton.Click
        'Get user's entry for recipe number, and display results.
        'Declare variables
        Dim SearchNumberString As String
        Dim MatchFoundBoolean As Boolean
        Dim IndexInteger As Integer

        'initialize variables
        MatchFoundBoolean = False
        IndexInteger = 0
        SearchNumberString = NumberTextBox.Text

        'Search for match
        If SearchNumberString <> "" Then  'check for blank zip code
            Do Until MatchFoundBoolean Or IndexInteger > MyMeals.Length - 1
                If SearchNumberString = MyMeals(IndexInteger).NumberString Then
                    MatchFoundBoolean = True
                    NameTextBox.Text = MyMeals(IndexInteger).NameString
                    CategoryComboBox.Text = MyMeals(IndexInteger).CategoryString
                    GroupComboBox.Text = MyMeals(IndexInteger).GroupString
                    ServingsTextBox.Text = MyMeals(IndexInteger).ServingsInteger
                    PrepTextBox.Text = MyMeals(IndexInteger).PrepInteger
                    VeganComboBox.Text = MyMeals(IndexInteger).VeganBoolean
                Else
                    IndexInteger = IndexInteger + 1
                End If
            Loop

            'handle no match situation
            If Not MatchFoundBoolean Then
                MessageBox.Show("No meal with that number.", "Not Found")
                NumberTextBox.Focus()
                NumberTextBox.SelectAll()
            End If

        Else
            'handle empty textbox situation
            MessageBox.Show("Please enter a number for the search", "Missing meal number")
        End If
    End Sub

    Private Sub NameButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NameButton.Click
        'Get user's entry of recipe name; search and display possible matches.
        'Declare variables
        Dim SearchNameString As String
        Dim MatchFoundBoolean As Boolean
        Dim IndexInteger As Integer

        'initialize variables and list box
        MatchFoundBoolean = False
        IndexInteger = 0
        SearchNameString = NameTextBox.Text
        RecipeListBox.Items.Clear()

        'Search for match
        If SearchNameString <> "" Then  'check for blank name box
            For IndexInteger = 0 To MyMeals.Length - 1
                If InStr(MyMeals(IndexInteger).NameString.ToUpper, SearchNameString.ToUpper) > 0 Then
                    'display names in list box
                    RecipeListBox.Items.Add(MyMeals(IndexInteger).NameString)
                End If
            Next IndexInteger
        Else
            'handle empty textbox situation
            MessageBox.Show("Please enter a name in the search", "Missing meal name")
        End If
    End Sub

    Private Sub CategoryButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CategoryButton.Click
        'Get user's entry of category; search and display possible matches.
        'Declare variables
        Dim SearchCategoryString As String
        Dim MatchFoundBoolean As Boolean
        Dim IndexInteger As Integer

        'initialize variables and list box
        MatchFoundBoolean = False
        IndexInteger = 0
        SearchCategoryString = CategoryComboBox.Text
        RecipeListBox.Items.Clear()

        'Search for match
        If SearchCategoryString <> "" Then  'check for blank category box
            For IndexInteger = 0 To MyMeals.Length - 1
                If CategoryComboBox.Text.ToString = MyMeals(IndexInteger).CategoryString Then
                    'display names in list box
                    RecipeListBox.Items.Add(MyMeals(IndexInteger).NameString)
                End If
            Next IndexInteger
        Else
            'handle empty textbox situation
            MessageBox.Show("Please select an option from the category box", "Missing category selection")
        End If
    End Sub

    Private Sub GroupButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupButton.Click
        'Get user's entry of group selection; search and display possible matches.
        'Declare variables
        Dim SearchGroupString As String
        Dim MatchFoundBoolean As Boolean
        Dim IndexInteger As Integer

        'initialize variables and list box
        MatchFoundBoolean = False
        IndexInteger = 0
        SearchGroupString = GroupComboBox.Text
        RecipeListBox.Items.Clear()

        'Search for match
        If SearchGroupString <> "" Then  'check for blank group selection box
            For IndexInteger = 0 To MyMeals.Length - 1
                If GroupComboBox.Text.ToString = MyMeals(IndexInteger).GroupString Then
                    'display names in list box
                    RecipeListBox.Items.Add(MyMeals(IndexInteger).NameString)
                End If
            Next IndexInteger
        Else
            'handle empty selection situation
            MessageBox.Show("Please select an option from the group box", "Missing category selection")
        End If
    End Sub

    Private Sub GroupPrepButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupPrepButton.Click
        'Get user's entry of group and prep time; search and display possible matches.
        'Declare variables
        Dim SearchGroupString As String
        Dim SearchPrepString As String
        Dim MatchFoundBoolean As Boolean
        Dim IndexInteger As Integer

        'initialize variables and list box
        MatchFoundBoolean = False
        IndexInteger = 0
        SearchGroupString = GroupComboBox.Text
        SearchPrepString = PrepTextBox.Text
        RecipeListBox.Items.Clear()

        'Search for match
        If SearchGroupString <> "" Then  'check for blank group box
            If SearchPrepString <> "" Then 'check for blank prep box
                For IndexInteger = 0 To MyMeals.Length - 1
                    If GroupComboBox.Text.ToString = MyMeals(IndexInteger).GroupString And PrepTextBox.Text.ToString = MyMeals(IndexInteger).PrepInteger Then
                        'display names in list box
                        RecipeListBox.Items.Add(MyMeals(IndexInteger).NameString)
                    End If
                Next IndexInteger
            Else
                'handle empty textbox situation
                MessageBox.Show("Please enter a time in the prep box", "Missing prep time")
            End If
        Else
            'handle no selection in group
            MessageBox.Show("Please select an option from the group box", "Missing group box selection")
        End If
    End Sub

    Private Sub GroupServingsButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupServingsButton.Click
        'Get user's entry of group and servings; search and display possible matches.
        'Declare variables
        Dim SearchGroupString As String
        Dim SearchServingsString As String
        Dim MatchFoundBoolean As Boolean
        Dim IndexInteger As Integer

        'initialize variables and list box
        MatchFoundBoolean = False
        IndexInteger = 0
        SearchGroupString = GroupComboBox.Text
        SearchServingsString = ServingsTextBox.Text
        RecipeListBox.Items.Clear()

        'Search for match
        If SearchGroupString <> "" Then  'check for blank group box
            If SearchServingsString <> "" Then 'check for blank serving box
                For IndexInteger = 0 To MyMeals.Length - 1
                    If GroupComboBox.Text.ToString = MyMeals(IndexInteger).GroupString And ServingsTextBox.Text.ToString = MyMeals(IndexInteger).ServingsInteger Then
                        'display names in list box
                        RecipeListBox.Items.Add(MyMeals(IndexInteger).NameString)
                    End If
                Next IndexInteger
            Else
                'handle empty textbox situation
                MessageBox.Show("Please enter a number in the servings box", "Missing prep time")
            End If
        Else
            'handle no selection
            MessageBox.Show("Please select an option from the group box", "Missing group box selection")
        End If
    End Sub

    Private Sub VegButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VegButton.Click
        'Get user's entry of recipe name; search and display possible matches.
        'Declare variables
        Dim SearchGroupString As String
        Dim SearchVeganBoolean As Boolean
        Dim MatchFoundBoolean As Boolean
        Dim IndexInteger As Integer

        'initialize variables and list box
        MatchFoundBoolean = False
        IndexInteger = 0
        SearchGroupString = GroupComboBox.Text
        RecipeListBox.Items.Clear()

        'Search for match
        If SearchGroupString <> "" Then  'check for blank group box
            If VeganComboBox.SelectedIndex <> -1 Then 'check for blank vegan box
                'assign T/F for Vegan
                If VeganComboBox.Text = True Then
                    SearchVeganBoolean = True
                Else
                    SearchVeganBoolean = False
                End If

                For IndexInteger = 0 To MyMeals.Length - 1
                    If GroupComboBox.Text.ToString = MyMeals(IndexInteger).GroupString And SearchVeganBoolean = MyMeals(IndexInteger).VeganBoolean Then
                        'display names in list box
                        RecipeListBox.Items.Add(MyMeals(IndexInteger).NameString)
                    End If
                Next IndexInteger
            Else
                'handle empty textbox situation
                MessageBox.Show("Please select True or False from the Vegetarian box", "Invalid vegetarian entry")
            End If
        Else
            'handle no selection
            MessageBox.Show("Please select an option from the group box", "Missing group box selection")
        End If
    End Sub

    Private Sub RecipeListBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RecipeListBox.SelectedIndexChanged
        'Find row with meal name and input all data into fields
        'declare variables
        Dim MatchFoundBoolean As Boolean
        Dim IndexInteger As Integer

        'initialize variables
        MatchFoundBoolean = False
        IndexInteger = 0

        Do Until MatchFoundBoolean
            If MyMeals(IndexInteger).NameString = RecipeListBox.SelectedItem.ToString Then
                MatchFoundBoolean = True
                'assign data to boxes
                NumberTextBox.Text = MyMeals(IndexInteger).NumberString
                NameTextBox.Text = MyMeals(IndexInteger).NameString
                CategoryComboBox.Text = MyMeals(IndexInteger).CategoryString
                GroupComboBox.Text = MyMeals(IndexInteger).GroupString
                ServingsTextBox.Text = MyMeals(IndexInteger).ServingsInteger
                PrepTextBox.Text = MyMeals(IndexInteger).PrepInteger
                VeganComboBox.Text = MyMeals(IndexInteger).VeganBoolean
            Else
                IndexInteger = IndexInteger + 1
            End If
        Loop
    End Sub
End Class
