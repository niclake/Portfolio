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
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.displayLabel = New System.Windows.Forms.Label
        Me.startTextBox = New System.Windows.Forms.TextBox
        Me.endTextBox = New System.Windows.Forms.TextBox
        Me.stepTextBox = New System.Windows.Forms.TextBox
        Me.displayButton = New System.Windows.Forms.Button
        Me.clearButton = New System.Windows.Forms.Button
        Me.quitButton = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Initial value:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 19)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "&Ending value:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 19)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "&Step increment:"
        '
        'displayLabel
        '
        Me.displayLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.displayLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.displayLabel.Location = New System.Drawing.Point(292, 33)
        Me.displayLabel.Name = "displayLabel"
        Me.displayLabel.Size = New System.Drawing.Size(112, 218)
        Me.displayLabel.TabIndex = 9
        '
        'startTextBox
        '
        Me.startTextBox.Location = New System.Drawing.Point(148, 33)
        Me.startTextBox.Name = "startTextBox"
        Me.startTextBox.Size = New System.Drawing.Size(30, 27)
        Me.startTextBox.TabIndex = 1
        '
        'endTextBox
        '
        Me.endTextBox.Location = New System.Drawing.Point(148, 66)
        Me.endTextBox.Name = "endTextBox"
        Me.endTextBox.Size = New System.Drawing.Size(30, 27)
        Me.endTextBox.TabIndex = 3
        '
        'stepTextBox
        '
        Me.stepTextBox.Location = New System.Drawing.Point(148, 99)
        Me.stepTextBox.Name = "stepTextBox"
        Me.stepTextBox.Size = New System.Drawing.Size(30, 27)
        Me.stepTextBox.TabIndex = 5
        '
        'displayButton
        '
        Me.displayButton.Location = New System.Drawing.Point(35, 149)
        Me.displayButton.Name = "displayButton"
        Me.displayButton.Size = New System.Drawing.Size(217, 30)
        Me.displayButton.TabIndex = 6
        Me.displayButton.Text = "&Display"
        Me.displayButton.UseVisualStyleBackColor = True
        '
        'clearButton
        '
        Me.clearButton.Location = New System.Drawing.Point(35, 185)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Size = New System.Drawing.Size(217, 30)
        Me.clearButton.TabIndex = 7
        Me.clearButton.Text = "&Clear"
        Me.clearButton.UseVisualStyleBackColor = True
        '
        'quitButton
        '
        Me.quitButton.Location = New System.Drawing.Point(35, 221)
        Me.quitButton.Name = "quitButton"
        Me.quitButton.Size = New System.Drawing.Size(217, 30)
        Me.quitButton.TabIndex = 8
        Me.quitButton.Text = "&Quit"
        Me.quitButton.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(427, 291)
        Me.Controls.Add(Me.quitButton)
        Me.Controls.Add(Me.clearButton)
        Me.Controls.Add(Me.displayButton)
        Me.Controls.Add(Me.stepTextBox)
        Me.Controls.Add(Me.endTextBox)
        Me.Controls.Add(Me.startTextBox)
        Me.Controls.Add(Me.displayLabel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "MainForm"
        Me.Text = "For Next Loop Demo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents displayLabel As System.Windows.Forms.Label
    Friend WithEvents startTextBox As System.Windows.Forms.TextBox
    Friend WithEvents endTextBox As System.Windows.Forms.TextBox
    Friend WithEvents stepTextBox As System.Windows.Forms.TextBox
    Friend WithEvents displayButton As System.Windows.Forms.Button
    Friend WithEvents clearButton As System.Windows.Forms.Button
    Friend WithEvents quitButton As System.Windows.Forms.Button

End Class
