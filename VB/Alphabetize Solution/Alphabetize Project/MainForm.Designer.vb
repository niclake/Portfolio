<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.FirstWordTextBox = New System.Windows.Forms.TextBox
        Me.SecondWordTextBox = New System.Windows.Forms.TextBox
        Me.ThirdWordTextBox = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.AlphabetizeButton = New System.Windows.Forms.Button
        Me.ResultTextBox = New System.Windows.Forms.TextBox
        Me.ClearButton = New System.Windows.Forms.Button
        Me.ExitButton = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'FirstWordTextBox
        '
        Me.FirstWordTextBox.Location = New System.Drawing.Point(233, 29)
        Me.FirstWordTextBox.Name = "FirstWordTextBox"
        Me.FirstWordTextBox.Size = New System.Drawing.Size(137, 24)
        Me.FirstWordTextBox.TabIndex = 1
        '
        'SecondWordTextBox
        '
        Me.SecondWordTextBox.Location = New System.Drawing.Point(233, 63)
        Me.SecondWordTextBox.Name = "SecondWordTextBox"
        Me.SecondWordTextBox.Size = New System.Drawing.Size(137, 24)
        Me.SecondWordTextBox.TabIndex = 3
        '
        'ThirdWordTextBox
        '
        Me.ThirdWordTextBox.Location = New System.Drawing.Point(233, 97)
        Me.ThirdWordTextBox.Name = "ThirdWordTextBox"
        Me.ThirdWordTextBox.Size = New System.Drawing.Size(137, 24)
        Me.ThirdWordTextBox.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(75, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter &first word:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(52, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Enter &second word:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(70, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Enter &third word:"
        '
        'AlphabetizeButton
        '
        Me.AlphabetizeButton.Location = New System.Drawing.Point(95, 153)
        Me.AlphabetizeButton.Name = "AlphabetizeButton"
        Me.AlphabetizeButton.Size = New System.Drawing.Size(202, 37)
        Me.AlphabetizeButton.TabIndex = 6
        Me.AlphabetizeButton.Text = "&Alphabetize"
        Me.AlphabetizeButton.UseVisualStyleBackColor = True
        '
        'ResultTextBox
        '
        Me.ResultTextBox.Location = New System.Drawing.Point(14, 212)
        Me.ResultTextBox.Name = "ResultTextBox"
        Me.ResultTextBox.Size = New System.Drawing.Size(380, 24)
        Me.ResultTextBox.TabIndex = 9
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(52, 263)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(84, 37)
        Me.ClearButton.TabIndex = 7
        Me.ClearButton.Text = "&Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(207, 262)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(89, 37)
        Me.ExitButton.TabIndex = 8
        Me.ExitButton.Text = "E&xit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AcceptButton = Me.AlphabetizeButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(408, 337)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.ResultTextBox)
        Me.Controls.Add(Me.AlphabetizeButton)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ThirdWordTextBox)
        Me.Controls.Add(Me.SecondWordTextBox)
        Me.Controls.Add(Me.FirstWordTextBox)
        Me.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "MainForm"
        Me.Text = "Alphabetize Words"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FirstWordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SecondWordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ThirdWordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents AlphabetizeButton As System.Windows.Forms.Button
    Friend WithEvents ResultTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ClearButton As System.Windows.Forms.Button
    Friend WithEvents ExitButton As System.Windows.Forms.Button

End Class
