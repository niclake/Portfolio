Option Strict On

Public Class ClassificationForm
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents CrHoursLabel As System.Windows.Forms.Label
    Friend WithEvents CrHoursTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CalculateButton As System.Windows.Forms.Button
    Friend WithEvents ClassTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ClearButton As System.Windows.Forms.Button
    Friend WithEvents ExitButton As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.CrHoursLabel = New System.Windows.Forms.Label
        Me.CrHoursTextBox = New System.Windows.Forms.TextBox
        Me.CalculateButton = New System.Windows.Forms.Button
        Me.ClassTextBox = New System.Windows.Forms.TextBox
        Me.ClearButton = New System.Windows.Forms.Button
        Me.ExitButton = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'CrHoursLabel
        '
        Me.CrHoursLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CrHoursLabel.Location = New System.Drawing.Point(0, 16)
        Me.CrHoursLabel.Name = "CrHoursLabel"
        Me.CrHoursLabel.Size = New System.Drawing.Size(152, 32)
        Me.CrHoursLabel.TabIndex = 0
        Me.CrHoursLabel.Text = "Enter the number of earned credit hours:"
        Me.CrHoursLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CrHoursTextBox
        '
        Me.CrHoursTextBox.Location = New System.Drawing.Point(160, 24)
        Me.CrHoursTextBox.Name = "CrHoursTextBox"
        Me.CrHoursTextBox.Size = New System.Drawing.Size(40, 20)
        Me.CrHoursTextBox.TabIndex = 1
        '
        'CalculateButton
        '
        Me.CalculateButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CalculateButton.Location = New System.Drawing.Point(48, 64)
        Me.CalculateButton.Name = "CalculateButton"
        Me.CalculateButton.Size = New System.Drawing.Size(190, 27)
        Me.CalculateButton.TabIndex = 2
        Me.CalculateButton.Text = "&Determine Classification"
        Me.CalculateButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ClassTextBox
        '
        Me.ClassTextBox.Location = New System.Drawing.Point(24, 112)
        Me.ClassTextBox.Name = "ClassTextBox"
        Me.ClassTextBox.ReadOnly = True
        Me.ClassTextBox.Size = New System.Drawing.Size(240, 20)
        Me.ClassTextBox.TabIndex = 3
        Me.ClassTextBox.TabStop = False
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(32, 152)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(75, 23)
        Me.ClearButton.TabIndex = 4
        Me.ClearButton.Text = "&Clear"
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(152, 152)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(75, 23)
        Me.ExitButton.TabIndex = 5
        Me.ExitButton.Text = "E&xit"
        '
        'ClassificationForm
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(292, 198)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.ClassTextBox)
        Me.Controls.Add(Me.CalculateButton)
        Me.Controls.Add(Me.CrHoursTextBox)
        Me.Controls.Add(Me.CrHoursLabel)
        Me.Controls.Add(Me.ExitButton)
        Me.Name = "ClassificationForm"
        Me.Text = "Classification Finder"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub ExitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub ClearButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearButton.Click
        'Set text boxes equal to null string
        CrHoursTextBox.Text = ""
        ClassTextBox.Text = ""

        'Give focus to Credit Hours text box
        CrHoursTextBox.Focus()
    End Sub

    Private Sub CalculateButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalculateButton.Click
        'Declare variables
        Dim CrHoursInteger As Integer
        Dim ClassString As String

        'check for blank credit hours text box
        If CrHoursTextBox.Text <> "" Then

            Try 'input credit hours
                CrHoursInteger = Integer.Parse(CrHoursTextBox.Text)

                'verify that credit hours is a positive number
                If CrHoursInteger > 0 Then

                    'Call function to find correct classification
                    ClassString = FindClass(CrHoursInteger)

                    'display classification on form
                    ClassTextBox.Text = "You are classified as a " & ClassString

                Else 'handle negative value for credit hours
                    MessageBox.Show("Please enter positive value for credit hours.  Re-enter", "Input Error")
                    With CrHoursTextBox
                        .Focus()
                        .SelectAll()
                    End With

                End If

            Catch CrHoursException As FormatException 'handle invalid characters in credit hours textbox
                MessageBox.Show("Please enter numeric value for credit hours.  Re-enter", "Input Error")
                With CrHoursTextBox
                    .Focus()
                    .SelectAll()
                End With
            End Try

        Else 'handle missing credit hours
            MessageBox.Show("Please enter a value for credit hours.   Please enter a value", "Input Error")
            With CrHoursTextBox
                .Focus()
            End With
        End If

    End Sub

    Function FindClass(ByVal HoursCredit As Integer) As String
        'declare variable
        Dim StudentClassificationString As String

        Select Case HoursCredit
            Case Is <= 29
                StudentClassificationString = "freshman"
            Case Is <= 59
                StudentClassificationString = "sophomore"
            Case Is <= 89
                StudentClassificationString = "junior"
            Case Else
                StudentClassificationString = "senior"
        End Select

        'return classification (two options)
        Return StudentClassificationString
        'FindClass = StudentClassificationString << also works

    End Function
End Class