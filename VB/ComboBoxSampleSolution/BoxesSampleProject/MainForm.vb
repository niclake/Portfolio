
Option Explicit On
Public Class MainForm

    Private Sub ExitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitButton.Click
        'close the application
        Me.Close()

    End Sub

    
    Private Sub DisplayButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DisplayButton.Click
        'Display number of names
        MessageBox.Show("The number of registrations is: " & NamesComboBox.Items.Count.ToString(), "Registration count", MessageBoxButtons.OK)
    End Sub

    Private Sub AddButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddButton.Click
        'Add name to end of list
        Dim i As Integer
        Dim ItemFoundBoolean As Boolean

        'initialize variables
        i = 0
        ItemFoundBoolean = False

        If NamesComboBox.Text <> "" Then
            'search for duplicate name
            Do Until ItemFoundBoolean Or i = NamesComboBox.Items.Count
                If NamesComboBox.Text.ToUpper = NamesComboBox.Items(i).ToUpper Then
                    ItemFoundBoolean = True
                Else
                    i = i + 1
                End If
            Loop
            'evaluate boolean
            If ItemFoundBoolean Then
                MessageBox.Show("Name already exists in list.  Please enter another name.", "Name entry error")
            Else
                'add name to list
                NamesComboBox.Items.Add(NamesComboBox.Text)
                NamesComboBox.Text = ""
            End If 'boolean
        Else 'nothing in entry box
            MessageBox.Show("Please enter a name to add to the list.", "Missing Entry")
            NamesComboBox.Focus()
        End If
    End Sub

    Private Sub InsertButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InsertButton.Click
        If NamesComboBox.Text <> "" Then
            'add name to list
            NamesComboBox.Items.Insert(0, NamesComboBox.Text)
            NamesComboBox.Text = ""
        Else
            MessageBox.Show("Please enter a name to add to the list.", "Missing Entry")
            NamesComboBox.Focus()
        End If
    End Sub

    Private Sub RemoveButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveButton.Click
        Dim AnswerDialogResult As DialogResult

        With NamesComboBox
            If .SelectedIndex <> -1 Then
                AnswerDialogResult = MessageBox.Show("Are you sure you want to remove this name?", "Delete Name?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If AnswerDialogResult = DialogResult.Yes Then
                    .Items.Remove(.Text)
                Else
                    .SelectedIndex = -1
                End If
            Else
                MessageBox.Show("No name selected.", "Delete Error")
            End If
        End With
    End Sub
End Class
