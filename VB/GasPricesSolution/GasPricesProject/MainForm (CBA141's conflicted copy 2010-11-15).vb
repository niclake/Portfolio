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
End Class
