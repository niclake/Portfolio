Public Class MainForm

    Private PieceCountInteger As Integer
    Private PersonCountInteger As Integer
    Private TotalPayDecimal As Decimal


    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        MessageBox.Show("Programmed by: Nic Lake", "Program Info")
    End Sub

    Private Sub PrintToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintToolStripMenuItem.Click, PrintToolStripMenuItem1.Click
        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm1.Print()
    End Sub

    Private Sub ClearAllToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearAllToolStripMenuItem.Click
        Dim Answer As DialogResult
        Answer = MessageBox.Show("Are you sure you want to clear the summary?", "Clear summary", MessageBoxButtons.YesNo)
        If Answer = vbYes Then
            PieceCountInteger = 0
            PersonCountInteger = 0
            TotalPayDecimal = 0

            NameTextBox.Text = ""
            NumPiecesTextBox.Text = ""
            AmountEarnedTextBox.Text = ""
            NameTextBox.Focus()
        End If
    End Sub

    Private Sub CalculateToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalculateToolStripMenuItem.Click, CalculateToolStripMenuItem1.Click
        Dim NameString As String
        Dim PiecesInt As Integer
        Dim AmountDecimal As Decimal

        If NameTextBox.Text <> "" Then
            NameString = NameTextBox.Text
            Try
                PiecesInt = Integer.Parse(NumPiecesTextBox.Text)

                PieceCountInteger = PieceCountInteger + PiecesInt
                PersonCountInteger = PersonCountInteger + 1

                AmountDecimal = Calculate(PiecesInt)

                AmountEarnedTextBox.Text = AmountDecimal.ToString("C")

            Catch PiecesException As FormatException
                MessageBox.Show("Please enter a valid number of pieces.", "Piece entry error")
                NumPiecesTextBox.Focus()
                NumPiecesTextBox.SelectAll()
            End Try
        Else
            MessageBox.Show("Please enter a name.", "Name entry error")
            NameTextBox.Focus()
            NameTextBox.SelectAll()
        End If
    End Sub

    Private Sub SummaryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SummaryToolStripMenuItem.Click
        If PersonCountInteger >= 1 Then
            Dim AvgSales As Decimal
            Dim PieceString As String
            Dim TotalString As String
            Dim AvgString As String
            Dim MessageString As String

            AvgSales = TotalPayDecimal / PersonCountInteger

            PieceString = PieceCountInteger.ToString
            TotalString = TotalPayDecimal.ToString("C")
            AvgString = AvgSales.ToString("C")

            MessageString = "Total pieces:  " & PieceString & Environment.NewLine & "Total pay:  " & TotalString & Environment.NewLine & "Average pay per person:  " & AvgString

            MessageBox.Show(MessageString, "Summary")
        Else
            MessageBox.Show("You have not submitted any calculations yet.", "Summary Error")
            NameTextBox.Focus()
            NameTextBox.SelectAll()
        End If
    End Sub

    Function Calculate(ByVal PiecesInteger As Integer)
        Dim Amount As Decimal

        Select Case PiecesInteger
            Case Is <= 0
                Amount = 0
            Case 1 To 199
                Amount = PiecesInteger * 0.5D
            Case 200 To 399
                Amount = PiecesInteger * 0.55D
            Case 400 To 599
                Amount = PiecesInteger * 0.6D
            Case Is >= 600
                Amount = PiecesInteger * 0.65D
        End Select

        TotalPayDecimal = TotalPayDecimal + Amount

        Return Amount

    End Function

    Private Sub ClearToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearToolStripMenuItem.Click, ClearToolStripMenuItem1.Click
        NameTextBox.Text = ""
        NumPiecesTextBox.Text = ""
        AmountEarnedTextBox.Text = ""
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click, ExitToolStripMenuItem1.Click
        Me.Close()
    End Sub

    Private Sub BackcolorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackcolorToolStripMenuItem.Click
        With ColorDialog1
            .ShowDialog()
            Me.BackColor = .Color
        End With
    End Sub

    Private Sub FontToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FontToolStripMenuItem.Click
        With FontDialog1
            .ShowDialog()
            Me.Font = .Font
        End With
    End Sub

    Private Sub CalculateToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalculateToolStripMenuItem1.Click
        Call CalculateToolStripMenuItem_Click(sender, e)
    End Sub
End Class
