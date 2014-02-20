'Project:    Calorie Calculator
'Programmer: Nic Lake
'Date:       13 Sept 2010
'Purpose:    Practice declaring/using variables, calculate total calories


Public Class MainForm

    Private TotalCarbDecimal As Decimal
    Private TotalFatDecimal As Decimal
    Private TotalProteinDecimal As Decimal
    Private GrandTotalDecimal As Decimal
    Private ItemCountDecimal As Decimal

    Private Sub ClearButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearButton.Click
        'clear all boxes, move cursor to first box
        With CarbsTextBox
            .Clear()
            .Focus()
        End With
        FatTextBox.Clear()
        ProteinTextBox.Clear()
        TotalTextBox.Clear()
    End Sub

    Private Sub QuitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuitButton.Click
        'exit the program]
        Me.Close()
    End Sub

    Private Sub ComputeButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComputeButton.Click
        'declare variables
        Dim CarbDecimal As Decimal
        Dim FatDecimal As Decimal
        Dim ProteinDecimal As Decimal
        Dim TotalDecimal As Decimal
        Dim CalcCarbDecimal As Decimal
        Dim CalcFatDecimal As Decimal
        Dim CalcProteinDecimal As Decimal

        'declare constants for conversion
        Const CARB_CONVERSION_RATE_DECIMAL As Decimal = 4
        Const FAT_CONVERSION_RATE_DECIMAL As Decimal = 9
        Const PROTEIN_CONVERSION_RATE_DECIMAL As Decimal = 4

        'input gram values, convert to totals
        Try
            CarbDecimal = Decimal.Parse(CarbsTextBox.Text)

            Try
                FatDecimal = Decimal.Parse(FatTextBox.Text)

                Try
                    ProteinDecimal = Decimal.Parse(ProteinTextBox.Text)

                    'increment counter
                    ItemCountDecimal = ItemCountDecimal + 1

                    'update totals
                    TotalCarbDecimal = TotalCarbDecimal + CarbDecimal
                    TotalFatDecimal = TotalFatDecimal + FatDecimal
                    TotalProteinDecimal = TotalProteinDecimal + ProteinDecimal

                    'calculations
                    CalcCarbDecimal = CarbDecimal * CARB_CONVERSION_RATE_DECIMAL
                    CalcFatDecimal = FatDecimal * FAT_CONVERSION_RATE_DECIMAL
                    CalcProteinDecimal = ProteinDecimal * PROTEIN_CONVERSION_RATE_DECIMAL
                    TotalDecimal = CalcCarbDecimal + CalcFatDecimal + CalcProteinDecimal

                    'update grand total
                    GrandTotalDecimal = GrandTotalDecimal + TotalDecimal

                    'display totals
                    TotalTextBox.Text = TotalDecimal.ToString
                    TotalCarbTextBox.Text = TotalCarbDecimal.ToString
                    TotalFatTextBox.Text = TotalFatDecimal.ToString
                    TotalProteinTextBox.Text = TotalProteinDecimal.ToString
                    NumItemsTextBox.Text = ItemCountDecimal.ToString
                    GrandTotalTextBox.Text = GrandTotalDecimal.ToString

                Catch ProteinException As FormatException
                    'handle exception for Protein
                    MessageBox.Show("Invalid entry for grams of protein.  Please re-enter.", "Grams of protein entry error.")
                    With ProteinTextBox
                        .Clear()
                        .Focus()
                    End With

                End Try

            Catch FatException As FormatException
                'handle exception for Fat
                MessageBox.Show("Invalid entry for grams of fat.  Please re-enter.", "Grams of fat entry error.")
                With FatTextBox
                    .Clear()
                    .Focus()
                End With
            End Try

        Catch CarbException As FormatException
            'handle exception for Carbohydrate
            MessageBox.Show("Invalid entry for grams of carbohydrate.  Please re-enter.", "Grams of protein entry error.")
            With CarbsTextBox
                .Clear()
                .Focus()
            End With
        End Try
    End Sub

    Private Sub ResetButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResetButton.Click
        'reset totals
        TotalCarbDecimal = 0
        TotalFatDecimal = 0
        TotalProteinDecimal = 0
        GrandTotalDecimal = 0
        ItemCountDecimal = 0

        'clear all boxes, move cursor to first box
        With CarbsTextBox
            .Clear()
            .Focus()
        End With
        FatTextBox.Clear()
        ProteinTextBox.Clear()
        TotalTextBox.Clear()
        TotalCarbTextBox.Clear()
        TotalFatTextBox.Clear()
        TotalProteinTextBox.Clear()
        NumItemsTextBox.Clear()
        GrandTotalTextBox.Clear()
    End Sub
End Class
