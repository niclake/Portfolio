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
        Me.calcButton = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.oddCountLabel = New System.Windows.Forms.Label
        Me.oddTotalLabel = New System.Windows.Forms.Label
        Me.evenCountLabel = New System.Windows.Forms.Label
        Me.evenTotalLabel = New System.Windows.Forms.Label
        Me.exitButton = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'calcButton
        '
        Me.calcButton.Location = New System.Drawing.Point(29, 63)
        Me.calcButton.Name = "calcButton"
        Me.calcButton.Size = New System.Drawing.Size(75, 38)
        Me.calcButton.TabIndex = 0
        Me.calcButton.Text = "&Start"
        Me.calcButton.UseVisualStyleBackColor = True
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
        'oddCountLabel
        '
        Me.oddCountLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.oddCountLabel.Location = New System.Drawing.Point(313, 63)
        Me.oddCountLabel.Name = "oddCountLabel"
        Me.oddCountLabel.Size = New System.Drawing.Size(50, 29)
        Me.oddCountLabel.TabIndex = 2
        '
        'oddTotalLabel
        '
        Me.oddTotalLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.oddTotalLabel.Location = New System.Drawing.Point(313, 94)
        Me.oddTotalLabel.Name = "oddTotalLabel"
        Me.oddTotalLabel.Size = New System.Drawing.Size(50, 29)
        Me.oddTotalLabel.TabIndex = 2
        '
        'evenCountLabel
        '
        Me.evenCountLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.evenCountLabel.Location = New System.Drawing.Point(313, 125)
        Me.evenCountLabel.Name = "evenCountLabel"
        Me.evenCountLabel.Size = New System.Drawing.Size(50, 29)
        Me.evenCountLabel.TabIndex = 2
        '
        'evenTotalLabel
        '
        Me.evenTotalLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.evenTotalLabel.Location = New System.Drawing.Point(313, 156)
        Me.evenTotalLabel.Name = "evenTotalLabel"
        Me.evenTotalLabel.Size = New System.Drawing.Size(50, 29)
        Me.evenTotalLabel.TabIndex = 2
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(29, 147)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(75, 38)
        Me.exitButton.TabIndex = 0
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(438, 224)
        Me.Controls.Add(Me.evenTotalLabel)
        Me.Controls.Add(Me.evenCountLabel)
        Me.Controls.Add(Me.oddTotalLabel)
        Me.Controls.Add(Me.oddCountLabel)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.calcButton)
        Me.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "MainForm"
        Me.Text = " "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents calcButton As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents oddCountLabel As System.Windows.Forms.Label
    Friend WithEvents oddTotalLabel As System.Windows.Forms.Label
    Friend WithEvents evenCountLabel As System.Windows.Forms.Label
    Friend WithEvents evenTotalLabel As System.Windows.Forms.Label
    Friend WithEvents exitButton As System.Windows.Forms.Button

End Class
