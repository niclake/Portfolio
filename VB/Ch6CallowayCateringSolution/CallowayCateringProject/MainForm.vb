'Project:    Create pricing form for catering business
'Programmer:
'Date:       October, 2010
'Purpose:    To calculate the cost of catering parties; Add splash screen and about screen.

Option Strict On

Public Class MainForm
    'Declare counter and accumulator variables
    Friend TotalEventsInteger As Integer
    Friend TotalRevenueDecimal As Decimal

    Private Sub CalculateToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalculateToolStripMenuItem.Click
        'Declare Variables
        Dim NumberOfGuestsInteger As Integer
        Dim PartyCostDecimal As Decimal


        'Declare Constants
        Const FIESTA_COST_Decimal As Decimal = 17.5D
        Const LUAU_COST_Decimal As Decimal = 19.5D
        Const TAILGATE_COST_Decimal As Decimal = 14.5D
        Const PICNIC_COST_Decimal As Decimal = 12.5D
        Const OPEN_BAR_COST_Decimal As Decimal = 25D

        'Get the number of guests from the form
        Try
            NumberOfGuestsInteger = Integer.Parse(GuestsTextBox.Text)
            'Check to see if number of guests is positive
            If NumberOfGuestsInteger > 0 Then
                'See if a radio button is actually checked before main decision logic
                If FiestaRadioButton.Checked Or LuauRadioButton.Checked Or TailgateRadioButton.Checked Or PicnicRadioButton.Checked Then
                    'Decision logic to find correct party cost with correct radio button
                    If FiestaRadioButton.Checked Then
                        'Fiesta is checked
                        PartyCostDecimal = NumberOfGuestsInteger * FIESTA_COST_Decimal
                    ElseIf LuauRadioButton.Checked Then
                        'Luau is checked
                        PartyCostDecimal = NumberOfGuestsInteger * LUAU_COST_Decimal
                    ElseIf TailgateRadioButton.Checked Then
                        'Tailgate is checked
                        PartyCostDecimal = NumberOfGuestsInteger * TAILGATE_COST_Decimal
                    ElseIf PicnicRadioButton.Checked Then
                        'Picnic is checked
                        PartyCostDecimal = NumberOfGuestsInteger * PICNIC_COST_Decimal
                    End If

                    'Check to see if they want an open bar
                    If OpenBarCheckBox.Checked Then
                        'Add the cost of open bar to party cost
                        PartyCostDecimal = PartyCostDecimal + OPEN_BAR_COST_Decimal * NumberOfGuestsInteger
                    End If

                    'Display the total cost
                    CostTextBox.Text = PartyCostDecimal.ToString("c")

                    'Count and Accumulate the totals
                    TotalEventsInteger = TotalEventsInteger + 1
                    TotalRevenueDecimal = TotalRevenueDecimal + PartyCostDecimal

                Else
                    'No party type selected
                    MessageBox.Show("Please select one of the party types", "Input Error")
                End If
            Else
                'Number of guests not a number greater than zero
                MessageBox.Show("The number of guests must be greater than zero", "Input Error")
                With GuestsTextBox
                    .Focus()
                    .SelectAll()
                End With
                'clear the party total just in case it was still set
                CostTextBox.Clear()
            End If

        Catch NumberofGuestsException As FormatException
            'Number of guests was left blank or contains bad data
            MessageBox.Show("The Number of Guests must be numeric.  Please re-enter", "Input Error")
            With GuestsTextBox
                .Focus()
                .SelectAll()
            End With
        End Try
    End Sub

    Private Sub SummaryToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SummaryToolStripMenuItem1.Click
        ''display summary info in message box
        'Dim MessageString As String

        ''concatenate the message
        'MessageString = "Number of events: " _
        ' & TotalEventsInteger.ToString _
        ' & Environment.NewLine & Environment.NewLine _
        ' & "Total Revenue: " _
        ' & TotalRevenueDecimal.ToString("c")
        'MessageBox.Show(MessageString, "Summary", MessageBoxButtons.OK, MessageBoxIcon.Information)

        'display SummaryForm
        SummaryForm.Show()

    End Sub

    Private Sub ResetToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResetToolStripMenuItem.Click
        'Declare variable to handle message box answer
        Dim ResetFormDialogResult As DialogResult

        'Prompt them to see if they really want to do this
        ResetFormDialogResult = MessageBox.Show("Do you really want to reset the running totals?", "Start over?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        'If yes is selected, clear everything; otherwise, do nothing
        If ResetFormDialogResult = DialogResult.Yes Then
            'Reset the counter and accumulator
            TotalEventsInteger = 0
            TotalRevenueDecimal = 0

            'Call the Clear procedure to clear remainder of form
            Call ClearToolStripMenuItem_Click(sender, e)

            'Set focus in number guests text box
            GuestsTextBox.Focus()
        End If
    End Sub

    Private Sub ClearToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearToolStripMenuItem.Click
        'clear the form
        GuestsTextBox.Clear()
        GuestsTextBox.Focus()

        FiestaRadioButton.Checked = False
        LuauRadioButton.Checked = False
        TailgateRadioButton.Checked = False
        PicnicRadioButton.Checked = False

        OpenBarCheckBox.Checked = False

        CostTextBox.Clear()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        'display message box
        'MessageBox.Show("Programmed by Student Name" & Environment.NewLine & "Last Updated: October 15, 2010", "Calloway Catering")

        'Display AboutBox form
        AboutBox.Show()

    End Sub
End Class
