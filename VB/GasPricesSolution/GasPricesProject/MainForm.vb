Option Explicit On
Option Strict On


Public Class MainForm
    Private GasPriceDecimal(99) As Decimal

    Private Sub MainForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim FileNameString As String
        Dim IndexInteger As Integer

        FileNameString = CurDir() & "\gasprices.txt"

        Dim GasPriceStreamReader As System.IO.StreamReader = New System.IO.StreamReader(FileNameString)

        Do While gasPriceStreamReader.Peek <> -1
            GasPriceDecimal(IndexInteger) = Convert.ToDecimal(GasPriceStreamReader.ReadLine)
            IndexInteger = IndexInteger + 1
        Loop

        FileClose()

        MessageBox.Show("Gas Prices are loaded")
    End Sub




    Private Sub exitButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles exitButton.Click
        Me.Close()

    End Sub

    Private Sub calcButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles calcButton.Click
        'declare variables
        Dim AvgDecimal As Decimal
        Dim AvgCount As Integer 

        'calculate average
        For IndexInteger As Integer = 0 To GasPriceDecimal.Length - 1
            AvgDecimal = AvgDecimal + GasPriceDecimal(IndexInteger)
        Next IndexInteger
        AvgDecimal = AvgDecimal / GasPriceDecimal.Length
        averageLabel.Text = AvgDecimal.ToString("C3")

        'find lowest price
        Array.Sort(GasPriceDecimal)
        lowLabel.Text = GasPriceDecimal(0).ToString("C3")

        'find highest price
        Array.Reverse(GasPriceDecimal)
        highLabel.Text = GasPriceDecimal(0).ToString("C3")

        'find # of prices above average
        For IndexInteger As Integer = 0 To GasPriceDecimal.Length - 1
            If AvgDecimal > GasPriceDecimal(IndexInteger) Then
                AvgCount = AvgCount + 1
            End If
        Next IndexInteger
        numberAboveLabel.Text = AvgCount.ToString


    End Sub
End Class
