Option Explicit On
Option Strict On


Public Class MainForm

    Private payments(19) As Decimal

    Private Sub MainForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim fileName As String
        Dim index As Integer

        fileName = CurDir() & "\payments.txt"

        Dim paymentsStreamReader As System.IO.StreamReader = New System.IO.StreamReader(fileName)

        Do While paymentsStreamReader.Peek <> -1
            payments(index) = Convert.ToDecimal(paymentsStreamReader.ReadLine)
            index = index + 1
        Loop

        FileClose()

        MessageBox.Show("File is loaded")

    End Sub

    Private Sub averageButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles averageButton.Click
        'declare variables
        Dim totalPayments, averagePayments As Decimal
        Dim payment As Decimal

        'process all values in payment array
        For Each payment In payments
            totalPayments = totalPayments + payment
        Next

        'compute and display average
        averagePayments = totalPayments / payments.Length
        averageLabel.Text = averagePayments.ToString("C2")

    End Sub

    Private Sub maxButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles maxButton.Click
        'declare variables
        Dim maxPayment As Decimal
        Dim index As Integer

        'initialize 
        maxPayment = payments(0)

        'search
        For index = 0 To payments.Length - 1
            If payments(index) > maxPayment Then
                maxPayment = payments(index)
            End If
        Next index

        'display result
        maxLabel.Text = maxPayment.ToString("C2")
    End Sub

    Private Sub minButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles minButton.Click
        'declare variables
        Dim minPayment As Decimal
        Dim index As Integer

        'initialize 
        minPayment = payments(0)

        'search
        For index = 0 To payments.Length - 1
            If payments(index) < minPayment Then
                minPayment = payments(index)
            End If
        Next index

        'display result
        minLabel.Text = minPayment.ToString("C2")
    End Sub

    Private Sub displayButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles displayButton.Click
        'declare variables
        Dim payment As Decimal

        'process array and display each element in listbox
        For Each payment In payments
            pmtListBox.Items.Add(payment.ToString("n2").PadLeft(9))
        Next
    End Sub

    Private Sub clearButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles clearButton.Click
        'remove values from listbox
        pmtListBox.Items.Clear()
    End Sub

    Private Sub adjustButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles adjustButton.Click
        'declare variables
        Dim factor As Decimal
        Dim index As Integer

        factor = Convert.ToDecimal(InputBox("Enter the amount you would like to change all stored values"))

        For index = 0 To payments.Length - 1
            payments(index) = payments(index) + factor
            pmtListBox.Items.Add(payments(index).ToString("n2").PadLeft(9))
        Next index
    End Sub

    Private Sub ascSortButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ascSortButton.Click
        'sort in ascending order

        Array.Sort(payments)
    End Sub

    Private Sub dscSortButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dscSortButton.Click
        'sort in descending order
        Array.Sort(payments)
        Array.Reverse(payments)

    End Sub
End Class
