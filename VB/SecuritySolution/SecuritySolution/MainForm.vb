Public Class MainForm

    Private Sub ExitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitButton.Click
        'close everything
        Me.Close()
        MyLoginForm.Close()
    End Sub
End Class
