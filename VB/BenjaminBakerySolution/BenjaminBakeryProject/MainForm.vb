'Nic Lake
'Bus. App. Dev. II
'BenjaminBakerySolution
'Work with combo boxes, do loops, and boolean

Public Class MainForm

    Private Sub ExitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub AddButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddButton.Click
        Dim InputString As String
        Dim i As Integer
        Dim iBoolean As Boolean

        i = 0
        iBoolean = False

        InputString = InputBox("Please enter a bagel type.", "Bagel type entry")

        If InputString <> "" Then
            Do Until iBoolean Or i = BagelComboBox.Items.Count
                If InputString.ToUpper = BagelComboBox.Items(i).ToUpper Then
                    iBoolean = True
                Else
                    i = i + 1
                End If
            Loop

            If iBoolean Then
                MessageBox.Show("That bagel type already exists in the list.  Please enter another.", "Bagel type already exists", MessageBoxButtons.OK)
                InputString = InputBox("Please enter a bagel type.", "Bagel type entry")
            Else
                BagelComboBox.Items.Add(InputString)
                InputString = ""
            End If
        Else
            MessageBox.Show("Please enter a bagel type.", "Bagel type entry error")
            InputString = InputBox("Please enter a bagel type.", "Bagel type entry")
        End If
    End Sub

    Private Sub CountButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CountButton.Click
        MessageBox.Show("Number of bagel types: " & BagelComboBox.Items.Count.ToString(), "Bagel type count", MessageBoxButtons.OK)
    End Sub

    Private Sub RemoveButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveButton.Click
        Dim YorN As DialogResult

        If BagelComboBox.SelectedIndex <> -1 Then
            YorN = MessageBox.Show("Are you sure you would like to remove this bagel type?", "Remove type?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If YorN = DialogResult.Yes Then
                BagelComboBox.Items.Remove(BagelComboBox.Text)
            Else
                BagelComboBox.SelectedIndex = -1
            End If
        Else
            MessageBox.Show("Please select the bagel type you would like to delete from the drop down list.", "Bagel type removeal error.", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub ClearButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearButton.Click
        Dim YorN As DialogResult

        YorN = MessageBox.Show("Are you sure you would like to clear the entire list?", "Clear list?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If YorN = DialogResult.Yes Then
            BagelComboBox.Items.Clear()
        Else
            BagelComboBox.SelectedIndex = -1
        End If
    End Sub
End Class
