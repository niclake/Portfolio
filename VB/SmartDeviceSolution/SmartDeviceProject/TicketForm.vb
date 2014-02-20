Public Class TicketForm

    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        'Calculate and display fine

        'Declare constants
        Const METER_FINE_Decimal As Decimal = 35D
        Const ZONE_FINE_Decimal As Decimal = 75D
        Const BLOCK_FINE_Decimal As Decimal = 150D
        Const HANDICAP_FINE_Decimal As Decimal = 500D

        'declare variable
        Dim FineDecimal As Decimal

        If MeterRadioButton.Checked Or NoParkingRadioButton.Checked Or DrivewayRadioButton.Checked Or HandicapRadioButton.Checked = True Then

            'determine fine amount
            If MeterRadioButton.Checked Then
                FineDecimal = METER_FINE_Decimal
            ElseIf NoParkingRadioButton.Checked Then
                FineDecimal = ZONE_FINE_Decimal
            ElseIf DrivewayRadioButton.Checked Then
                FineDecimal = BLOCK_FINE_Decimal
            Else
                FineDecimal = HANDICAP_FINE_Decimal
            End If

            'check for repeat offender
            If RepeatCheckBox.Checked Then
                FineDecimal = FineDecimal * 2
            End If

            'display result
            DisplayLabel.Text = "Parking Ticket Fine: " & FineDecimal.ToString("C")
            DisplayLabel.Visible = True

        Else 'handle unchecked radio buttons
            MessageBox.Show("Please select one of the radio buttons", "Incomplete entry")
        End If
    End Sub

    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        'remove checks from radio buttons
        MeterRadioButton.Checked = False
        NoParkingRadioButton.Checked = False
        DrivewayRadioButton.Checked = False
        HandicapRadioButton.Checked = False

        'remove check from repeat offender box
        RepeatCheckBox.Checked = False

        'hide display label
        DisplayLabel.Visible = False

        'focus on first radio button
        MeterRadioButton.Focus()
        MeterRadioButton.Checked = False

    End Sub

    Private Sub TicketForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MeterRadioButton.Focus()
        MeterRadioButton.Checked = False
    End Sub
End Class
