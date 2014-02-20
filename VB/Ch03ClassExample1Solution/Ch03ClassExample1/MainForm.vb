'Project:    Sale Price Calculator
'Programmer: Nic Lake
'Date:       10 Sept 2010
'Purpose:    Practice declaring/using variables, calculate price w/ discounts

Option Strict On


Public Class MainForm

    Private Sub PrintButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintButton.Click
        'send form to print preview
        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm1.Print()

    End Sub

    Private Sub ExitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitButton.Click
        'close application
        Me.Close()

    End Sub

    
    Private Sub ComputeButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComputeButton.Click
        'declare variables
        Dim ItemPriceDecimal As Decimal
        Dim DiscountPercentDecimal As Decimal
        Dim DiscountAmountDecimal As Decimal
        Dim SalePriceDecimal As Decimal

        'input item price and discount percent

        Try
            ItemPriceDecimal = Decimal.Parse(PriceTextBox.Text)

            Try
                DiscountPercentDecimal = Decimal.Parse(DiscountPercentTextBox.Text)

                'calculations
                DiscountPercentDecimal = DiscountPercentDecimal / 100
                DiscountAmountDecimal = ItemPriceDecimal * DiscountPercentDecimal
                SalePriceDecimal = ItemPriceDecimal - DiscountAmountDecimal

                'display sales price on form
                SalePriceTextBox.Text = SalePriceDecimal.ToString("c")

            Catch DiscountException As FormatException
                'handle an exception for discount percent
                MessageBox.Show("Invalid entry in Discount Percent Text Box.  Please re-enter.", "Discount Percent Entry Error")
                With DiscountPercentTextBox
                    .Focus()
                    .SelectAll()
                End With

            End Try

        Catch PriceException As FormatException
            'handle an exception for price
            MessageBox.Show("Invalid entry in Price Text Box.  Please re-enter.", "Price Entry Error")
            With PriceTextBox
                .Focus()
                .SelectAll()
            End With
        End Try

    End Sub

    Private Sub ClearButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearButton.Click
        'clear form, reposition cursor in PriceTextBox
        DiscountPercentTextBox.Clear()
        SalePriceTextBox.Clear()
        With PriceTextBox
            .Clear()
            .Focus()
        End With
    End Sub
End Class
