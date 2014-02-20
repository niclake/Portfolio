'Nic Lake
'Bus. App. Dev. II
'30 Dec 2010
'Practice using structures

Public Class MyLoginForm

    'create structure
    Structure Login
        Dim UsernameString As String
        Dim PasswordString As String
    End Structure

    Private LoginData(2) As Login
    'public attempts counter
    Public AttemptsInteger As Integer = 0


    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        'declare variables
        Dim UserString As String
        Dim PassString As String
        Dim IndexInteger As Integer
        Dim MatchFoundBoolean As Boolean

        'initialize variables
        IndexInteger = 0
        MatchFoundBoolean = False

        'get user input
        UserString = UsernameTextBox.Text
        PassString = PasswordTextBox.Text

        'search for match
        If UserString <> "" Then
            ''incriment attempts counter
            'AttemptsInteger = AttemptsInteger + 1

            'search loop
            Do Until MatchFoundBoolean Or IndexInteger > LoginData.Length - 1
                'check username
                If UserString.ToLower = LoginData(IndexInteger).UsernameString.ToLower Then
                    'Set boolean to true
                    MatchFoundBoolean = True
                Else
                    'incriment index counter if username doesn't exist
                    IndexInteger = IndexInteger + 1
                End If 'username check
            Loop

            If MatchFoundBoolean = True Then
                'check password against database
                If PassString = LoginData(IndexInteger).PasswordString Then
                    'password = match, show main form
                    Me.Hide()
                    MainForm.Show()
                Else
                    'password = wrong
                    'show message box, focus on password box and incriment index counter if password doesn't match
                    AttemptsInteger = AttemptsInteger + 1
                    If AttemptsInteger = 3 Then
                        'too many attempts. Close program
                        MessageBox.Show("Too many incorrect login attempts. Closing program.", "Login error")
                        Me.Close()
                    End If
                    MessageBox.Show("Incorrect password, try again.", "Password error")
                    PasswordTextBox.Focus()
                End If
            Else
                'incriment attempts counter, display message box, focus on username box
                AttemptsInteger = AttemptsInteger + 1
                If AttemptsInteger = 3 Then
                    'too many attempts. Close program
                    MessageBox.Show("Too many incorrect login attempts. Closing program.", "Login error")
                    Me.Close()
                End If
                MessageBox.Show("Username doesn't exist, please try again.", "Username error")
                UsernameTextBox.Focus()
            End If
        Else
            'handle blank username box
            MessageBox.Show("Please enter a username", "No username entered")
        End If

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        'close
        Me.Close()
    End Sub

    Private Sub MyLoginForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'load values into array
        LoginData(0).UsernameString = "alpha"
        LoginData(0).PasswordString = "a123"

        LoginData(1).UsernameString = "beta"
        LoginData(1).PasswordString = "b456"

        LoginData(2).UsernameString = "gamma"
        LoginData(2).PasswordString = "c789"

    End Sub
End Class
