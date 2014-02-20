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
        'declare variables
        Dim HoursInteger As Integer
        Dim ClassString As String

        'check for a blank credit hours textbox
        If CrHoursTextBox.Text <> "" Then
            Try
                HoursInteger = Integer.Parse(CrHoursTextBox.Text)

                If HoursInteger >= 0 Then

                    ''Option 1 separate If statements to find correct classification
                    'If HoursInteger <= 29 Then
                    '    ClassString = "Freshman"
                    'End If
                    'If HoursInteger >= 30 And HoursInteger <= 59 Then
                    '    ClassString = "sophomore"
                    'End If
                    'If HoursInteger >= 60 And HoursInteger <= 89 Then
                    '    ClassString = "junior"
                    'End If
                    'If HoursInteger >= 90 Then
                    '    ClassString = "senior"
                    'End If


                    'Option 2 If-Then-ElseIf structure

                    'If HoursInteger <= 29 Then
                    '    ClassString = "freshman"
                    'ElseIf HoursInteger <= 59 Then
                    '    ClassString = "sophomore"
                    'ElseIf HoursInteger <= 89 Then
                    '    ClassString = "junior"
                    'Else
                    '    ClassString = "senior"
                    'End If


                    'Option 3 Select Case Structure
                    Select Case HoursInteger
                        Case 0 To 29
                            ClassString = "freshman"
                        Case 30 To 59
                            ClassString = "sophomore"
                        Case 60 To 89
                            ClassString = "junior"
                        Case Else
                            ClassString = "senior"
                    End Select

                    'display class ifaction on form
                    ClassTextBox.Text = "You are a " & ClassString

                Else  'handle negative credit hours entry
                    MessageBox.Show("Cannot process negative credit hours.  Please re-enter", "Negative entry")
                    With CrHoursTextBox
                        .SelectAll()
                        .Focus()
                    End With

                End If



            Catch HoursException As FormatException 'handle invalid data
                MessageBox.Show("Cannot process entry value.  Please re-enter", "Invalid entry")
                With CrHoursTextBox
                    .SelectAll()
                    .Focus()
                End With
            End Try

        Else 'blank textbox error
            MessageBox.Show("Cannot process blank textbox.  Please re-enter", "Missing entry")
            With CrHoursTextBox
                .Focus()
            End With
        End If
    End Sub
End Class
