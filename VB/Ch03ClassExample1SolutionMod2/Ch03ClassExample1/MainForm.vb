'Project:     Ch03ClassExample1 - Modified
'Programmer:  R Roth
'Date:        Sept 2010
'Purpose:     Demonstrate use of numeric variables, calculations, and displaying output;
'             adds use of counter and accumulator to produce summary information

Option Strict On

Public Class MainForm
    'declare module-level variables
    Private ItemCountInteger As Integer
    Private TotalDiscDecimal As Decimal

    Private Sub ComputeButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComputeButton.Click
        'Calculate Sale Price

        'Declare local variables
        Dim PriceDecimal As Decimal
        Dim DiscountPercentDecimal As Decimal
        Dim DiscountAmountDecimal As Decimal
        Dim SalePriceDecimal As Decimal
        Dim AverageDiscountPercentDecimal As Decimal

        Try
            'Convert price value to decimal variable
            PriceDecimal = Decimal.Parse(PriceTextBox.Text)

            Try
                'if price was converted successfully, try to convert discount percent
                DiscountPercentDecimal = Decimal.Parse(DiscountPercentTextBox.Text) / 100

                'Calculate sale price
                DiscountAmountDecimal = PriceDecimal * DiscountPercentDecimal
                SalePriceDecimal = PriceDecimal - DiscountAmountDecimal

                'count and accumulate totals
                ItemCountInteger = ItemCountInteger + 1
                TotalDiscDecimal = TotalDiscDecimal + DiscountPercentDecimal

                'computer average discount percent
                AverageDiscountPercentDecimal = TotalDiscDecimal / ItemCountInteger

                'Display results in textboxes
                SalePriceTextBox.Text = SalePriceDecimal.ToString("c")
                ItemSumTextBox.Text = ItemCountInteger.ToString
                AvgDiscTextBox.Text = AverageDiscountPercentDecimal.ToString("p")

            Catch DiscountPercentException As FormatException
                'handle a discount percent exception
                MessageBox.Show("Discount Percent must be numeric.", "Data entry error", MessageBoxButtons.OK, MessageBoxIcon.Information)
                With DiscountPercentTextBox
                    .Focus()
                    .SelectAll()
                End With
            End Try
        Catch PriceException As FormatException
            'handle a price exception
            MessageBox.Show("Price must be numeric.", "Data entry error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            With PriceTextBox
                .Focus()
                .SelectAll()
            End With

        End Try



    End Sub

    Private Sub ClearButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearButton.Click
        'clear form objects and put focus in price text box

        DiscountPercentTextBox.Text = ""

        SalePriceTextBox.Text = ""
        With PriceTextBox
            .Clear()
            .Focus()
        End With

    End Sub

    Private Sub ExitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitButton.Click
        'close the application
        Me.Close()

    End Sub

    Private Sub PrintButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintButton.Click
        'send form to print preview window
        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm1.Print()

    End Sub

    Private Sub ClearAllButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearAllButton.Click
        'reset counter and accumulator
        ItemCountInteger = 0
        TotalDiscDecimal = 0

        'clear form objects and put focus in price text box
        DiscountPercentTextBox.Text = ""
        SalePriceTextBox.Text = ""

        'clear summary area
        AvgDiscTextBox.Text = ""
        ItemSumTextBox.Text = ""

        'reset cursor for entry
        With PriceTextBox
            .Clear()
            .Focus()
        End With

    End Sub
End Class
