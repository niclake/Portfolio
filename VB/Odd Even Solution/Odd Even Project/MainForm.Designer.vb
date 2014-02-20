<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.CalcButton = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.OddCountLabel = New System.Windows.Forms.Label
        Me.OddTotalLabel = New System.Windows.Forms.Label
        Me.EvenCountLabel = New System.Windows.Forms.Label
        Me.EvenTotalLabel = New System.Windows.Forms.Label
        Me.ExitButton = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'CalcButton
        '
        Me.CalcButton.Location = New System.Drawing.Point(29, 63)
        Me.CalcButton.Name = "CalcButton"
        Me.CalcButton.Size = New System.Drawing.Size(75, 38)
        Me.CalcButton.TabIndex = 0
        Me.CalcButton.Text = "&Start"
        Me.CalcButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(148, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(149, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Odd number count:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(148, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(141, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Odd number total:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(148, 135)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(153, 19)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Even number count:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(148, 166)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(145, 19)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Even number total:"
        '
        'OddCountLabel
        '
        Me.OddCountLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.OddCountLabel.Location = New System.Drawing.Point(313, 63)
        Me.OddCountLabel.Name = "OddCountLabel"
        Me.OddCountLabel.Size = New System.Drawing.Size(50, 29)
        Me.OddCountLabel.TabIndex = 2
        '
        'OddTotalLabel
        '
        Me.OddTotalLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.OddTotalLabel.Location = New System.Drawing.Point(313, 94)
        Me.OddTotalLabel.Name = "OddTotalLabel"
        Me.OddTotalLabel.Size = New System.Drawing.Size(50, 29)
        Me.OddTotalLabel.TabIndex = 2
        '
        'EvenCountLabel
        '
        Me.EvenCountLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.EvenCountLabel.Location = New System.Drawing.Point(313, 125)
        Me.EvenCountLabel.Name = "EvenCountLabel"
        Me.EvenCountLabel.Size = New System.Drawing.Size(50, 29)
        Me.EvenCountLabel.TabIndex = 2
        '
        'EvenTotalLabel
        '
        Me.EvenTotalLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.EvenTotalLabel.Location = New System.Drawing.Point(313, 156)
        Me.EvenTotalLabel.Name = "EvenTotalLabel"
        Me.EvenTotalLabel.Size = New System.Drawing.Size(50, 29)
        Me.EvenTotalLabel.TabIndex = 2
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(29, 147)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(75, 38)
        Me.ExitButton.TabIndex = 0
        Me.ExitButton.Text = "E&xit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(438, 224)
        Me.Controls.Add(Me.EvenTotalLabel)
        Me.Controls.Add(Me.EvenCountLabel)
        Me.Controls.Add(Me.OddTotalLabel)
        Me.Controls.Add(Me.OddCountLabel)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.CalcButton)
        Me.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "MainForm"
        Me.Text = " "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CalcButton As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents OddCountLabel As System.Windows.Forms.Label
    Friend WithEvents OddTotalLabel As System.Windows.Forms.Label
    Friend WithEvents EvenCountLabel As System.Windows.Forms.Label
    Friend WithEvents EvenTotalLabel As System.Windows.Forms.Label
    Friend WithEvents ExitButton As System.Windows.Forms.Button

End Class
