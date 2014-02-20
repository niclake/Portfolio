Option Explicit On
Option Strict On


Public Class MainForm

    Private PaymentsDecimal() As Decimal

    Private Sub MainForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim FileNameString As String
        Dim NumElementsInteger As Integer

        FileNameString = CurDir() & "\payments.txt"

        Dim PaymentsStreamReader As System.IO.StreamReader = New System.IO.StreamReader(FileNameString)

        Do While PaymentsStreamReader.Peek <> -1
            ReDim Preserve PaymentsDecimal(NumElementsInteger)
            PaymentsDecimal(NumElementsInteger) = Convert.ToDecimal(PaymentsStreamReader.ReadLine)
            NumElementsInteger = NumElementsInteger + 1
        Loop

        FileClose()


        MessageBox.Show("File is loaded with " & NumElementsInteger & " payments")

    End Sub

    

    Private Sub ClearButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ClearButton.Click
        'remove values from listbox
        PmtListBox.Items.Clear()
    End Sub

    

    
    Private Sub AverageButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AverageButton.Click
        'declare variables
        Dim TotalDecimal, AvgDecimal As Decimal

        'For IndexInteger As Integer = 0 To PaymentsDecimal.Length - 1
        '    TotalDecimal = TotalDecimal + PaymentsDecimal(IndexInteger)

        'Next IndexInteger

        ''Calculate avg
        'Try
        '    AvgDecimal = TotalDecimal / PaymentsDecimal.Length

        '    AverageLabel.Text = AvgDecimal.ToString("C")

        'Catch ex As Exception
        '    MessageBox.Show("Array is empty, no results can be computed.", "Empty array")
        'End Try

        For Each OnePaymentDecimal As Decimal In PaymentsDecimal
            TotalDecimal = TotalDecimal + OnePaymentDecimal
        Next

        'Calculate avg
        Try
            AvgDecimal = TotalDecimal / PaymentsDecimal.Length

            AverageLabel.Text = AvgDecimal.ToString("C")

        Catch ex As Exception
            MessageBox.Show("Array is empty, no results can be computed.", "Empty array")
        End Try
    End Sub

    Private Sub MaxButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MaxButton.Click
        'declare variable
        Dim MaxDecimal As Decimal

        'initialize
        MaxDecimal = PaymentsDecimal(0)

        For Each OnePaymentDecimal As Decimal In PaymentsDecimal
            If OnePaymentDecimal > MaxDecimal Then
                MaxDecimal = OnePaymentDecimal
            End If
        Next

        MaxLabel.Text = MaxDecimal.ToString("C")
    End Sub

    Private Sub MinButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MinButton.Click
        'declare variable
        Dim MinDecimal As Decimal

        'initialize
        MinDecimal = PaymentsDecimal(0)

        For Each OnePaymentDecimal As Decimal In PaymentsDecimal
            If OnePaymentDecimal < MinDecimal Then
                MinDecimal = OnePaymentDecimal
            End If
        Next

        MinLabel.Text = MinDecimal.ToString("C")
    End Sub

    Private Sub DisplayButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DisplayButton.Click
        'Counter
        Dim IndexInteger As Integer

        Do While IndexInteger < PaymentsDecimal.Length
            PmtListBox.Items.Add(PaymentsDecimal(IndexInteger).ToString("C"))
            IndexInteger = IndexInteger + 1
        Loop
    End Sub
End Class
