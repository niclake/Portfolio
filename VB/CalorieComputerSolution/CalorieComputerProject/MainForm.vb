'Project:    Calorie Calculator
'Programmer: Nic Lake
'Date:       13 Sept 2010
'Purpose:    Practice declaring/using variables, calculate total calories


Public Class MainForm

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

                    'calculations
                    CarbDecimal = CarbDecimal * CARB_CONVERSION_RATE_DECIMAL
                    TotalDecimal = TotalDecimal + CarbDecimal

                    FatDecimal = FatDecimal * FAT_CONVERSION_RATE_DECIMAL
                    TotalDecimal = TotalDecimal + FatDecimal

                    ProteinDecimal = ProteinDecimal * PROTEIN_CONVERSION_RATE_DECIMAL
                    TotalDecimal = TotalDecimal + ProteinDecimal

                    'display total
                    TotalTextBox.Text = TotalDecimal.ToString

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
End Class
