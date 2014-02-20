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
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.averageLabel = New System.Windows.Forms.Label
        Me.highLabel = New System.Windows.Forms.Label
        Me.lowLabel = New System.Windows.Forms.Label
        Me.numberAboveLabel = New System.Windows.Forms.Label
        Me.calcButton = New System.Windows.Forms.Button
        Me.exitButton = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(149, 21)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Average gas price:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(34, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(144, 21)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Highest gas price:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(36, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(141, 21)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Lowest gas price:"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(12, 149)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(165, 52)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Number of prices above the average:"
        '
        'averageLabel
        '
        Me.averageLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.averageLabel.Location = New System.Drawing.Point(184, 40)
        Me.averageLabel.Name = "averageLabel"
        Me.averageLabel.Size = New System.Drawing.Size(77, 26)
        Me.averageLabel.TabIndex = 3
        '
        'highLabel
        '
        Me.highLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.highLabel.Location = New System.Drawing.Point(184, 79)
        Me.highLabel.Name = "highLabel"
        Me.highLabel.Size = New System.Drawing.Size(77, 26)
        Me.highLabel.TabIndex = 5
        '
        'lowLabel
        '
        Me.lowLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lowLabel.Location = New System.Drawing.Point(183, 118)
        Me.lowLabel.Name = "lowLabel"
        Me.lowLabel.Size = New System.Drawing.Size(78, 26)
        Me.lowLabel.TabIndex = 7
        '
        'numberAboveLabel
        '
        Me.numberAboveLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.numberAboveLabel.Location = New System.Drawing.Point(183, 159)
        Me.numberAboveLabel.Name = "numberAboveLabel"
        Me.numberAboveLabel.Size = New System.Drawing.Size(78, 26)
        Me.numberAboveLabel.TabIndex = 9
        '
        'calcButton
        '
        Me.calcButton.Location = New System.Drawing.Point(70, 222)
        Me.calcButton.Name = "calcButton"
        Me.calcButton.Size = New System.Drawing.Size(107, 31)
        Me.calcButton.TabIndex = 0
        Me.calcButton.Text = "&Calculate"
        Me.calcButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(70, 259)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(107, 31)
        Me.exitButton.TabIndex = 1
        Me.exitButton.Text = "&Exit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(291, 327)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.calcButton)
        Me.Controls.Add(Me.numberAboveLabel)
        Me.Controls.Add(Me.lowLabel)
        Me.Controls.Add(Me.highLabel)
        Me.Controls.Add(Me.averageLabel)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "MainForm"
        Me.Text = "Gas Price Analysis"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents averageLabel As System.Windows.Forms.Label
    Friend WithEvents highLabel As System.Windows.Forms.Label
    Friend WithEvents lowLabel As System.Windows.Forms.Label
    Friend WithEvents numberAboveLabel As System.Windows.Forms.Label
    Friend WithEvents calcButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button

End Class
