Option Strict On

Public Class MainForm

    Private Sub ClearButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearButton.Click
        Call Clear()

    End Sub

    Sub Clear()
        'Clear textboxes
        QuantityTextBox.Clear()
        DiscountTextBox.Clear()

        'reset radio button
        StdRadioButton.Focus()
        StdRadioButton.Checked = False
    End Sub


    Private Sub ExitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitButton.Click, ExitToolStripMenuItem.Click
        'close application
        Me.Close()

    End Sub

    
    Private Sub FindButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FindButton.Click
        'declare variables
        Dim QuantityInteger As Integer
        Dim DiscountDecimal As Decimal

        'check to ensure a radio button is selected
        If StdRadioButton.Checked Or SpecialRadioButton.Checked Or PreferredRadioButton.Checked Then

            'get valid quantity input value
            'check for blank textbox
            If QuantityTextBox.Text <> "" Then
                'check for numeric values in textbox
                Try
                    QuantityInteger = Integer.Parse(QuantityTextBox.Text)
                    'check for positive quantity
                    If QuantityInteger >= 0 Then

                        'call function to find Discount
                        DiscountDecimal = FindDiscount(QuantityInteger)

                        'display results on form
                        DiscountTextBox.Text = DiscountDecimal.ToString("P1")

                    Else ' handle negative value for quantity
                        MessageBox.Show("Please enter a positive quantity value", "Quantity Error")
                        QuantityTextBox.Focus()
                        QuantityTextBox.SelectAll()
                    End If

                Catch QuantityException As FormatException  'handle invalid data in quantity textbox
                    MessageBox.Show("Please enter a numeric quantity value", "Quantity Error")
                    QuantityTextBox.Focus()
                    QuantityTextBox.SelectAll()
                End Try

            Else  'handle empty quantity textbox
                MessageBox.Show("Please enter a  quantity value", "Quantity Error")
                QuantityTextBox.Focus()
            End If

        Else  ' error message for unselected radio buttons
            MessageBox.Show("Please select a radio button", "Entry Error")
            StdRadioButton.Focus()
            StdRadioButton.Checked = False
        End If
    End Sub

    Function FindDiscount(ByVal QuantInteger As Integer) As Decimal
        'use select case for logic stucture

        Select Case QuantInteger
            Case 0 To 200
                If StdRadioButton.Checked Then
                    FindDiscount = 0
                ElseIf SpecialRadioButton.Checked Then
                    FindDiscount = 0.02D
                Else
                    FindDiscount = 0.04D
                End If

            Case 201 To 400
                If StdRadioButton.Checked Then
                    FindDiscount = 0.03D
                ElseIf SpecialRadioButton.Checked Then
                    FindDiscount = 0.05D
                Else
                    FindDiscount = 0.07D
                End If

            Case Is >= 401
                If StdRadioButton.Checked Then
                    FindDiscount = 0.06D
                ElseIf SpecialRadioButton.Checked Then
                    FindDiscount = 0.08D
                Else
                    FindDiscount = 0.1D
                End If
        End Select
    End Function

    Private Sub PrintButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintButton.Click, PrintToolStripMenuItem.Click
        'send a copy of the form to Print Preview window
        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm1.Print()

    End Sub

    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'set the focus on first radio button, but don't select it
        StdRadioButton.Focus()
        StdRadioButton.Checked = False
    End Sub

    Private Sub DiscountToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DiscountToolStripMenuItem.Click
        Call FindButton_Click(sender, e)
    End Sub

    Private Sub ClearToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearToolStripMenuItem.Click
        Call Clear()
    End Sub

    Private Sub FormBackcolorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FormBackcolorToolStripMenuItem.Click
        'allow user to change form background color
        With ColorDialog1
            'save existing color of form background
            .Color = Me.BackColor
            'display color dialog box to user
            .ShowDialog()
            'set form backcolor to selected color
            Me.BackColor = .Color

        End With
    End Sub

    Private Sub FormFontToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FormFontToolStripMenuItem.Click
        'allow user to change form forecolor
        With ColorDialog1
            'save existing color of form forecolor property
            .Color = Me.ForeColor
            'display color dialog box to user
            .ShowDialog()
            'set form forecolor to selected color
            Me.ForeColor = .Color
        End With
    End Sub

    Private Sub TitleFontToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TitleFontToolStripMenuItem.Click
        'allow user to change fon of the title label
        With FontDialog1
            'save existing font
            .Font = Label3.Font
            'show dialog box
            .ShowDialog()
            'assign selection to title label
            Label3.Font = .Font
        End With
    End Sub

    
    Private Sub ClearToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearToolStripMenuItem1.Click
        'call existing clear procedure
        Call Clear()
    End Sub

    Private Sub PrintToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintToolStripMenuItem1.Click
        'call existing print procedure
        Call PrintButton_Click(sender, e)
    End Sub

    Private Sub ExitToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem1.Click
        'call existing exit procedure
        Call ExitButton_Click(sender, e)
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        'display programmer info
        MessageBox.Show("Programmed by: Nic Lake", "Program Info")
    End Sub
End Class
