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
        Me.DisplayLabel = New System.Windows.Forms.Label
        Me.StartTextBox = New System.Windows.Forms.TextBox
        Me.EndTextBox = New System.Windows.Forms.TextBox
        Me.StepTextBox = New System.Windows.Forms.TextBox
        Me.DisplayButton = New System.Windows.Forms.Button
        Me.ClearButton = New System.Windows.Forms.Button
        Me.QuitButton = New System.Windows.Forms.Button
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
        'DisplayLabel
        '
        Me.DisplayLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DisplayLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DisplayLabel.Location = New System.Drawing.Point(303, 36)
        Me.DisplayLabel.Name = "DisplayLabel"
        Me.DisplayLabel.Size = New System.Drawing.Size(112, 218)
        Me.DisplayLabel.TabIndex = 9
        '
        'StartTextBox
        '
        Me.StartTextBox.Location = New System.Drawing.Point(148, 33)
        Me.StartTextBox.Name = "StartTextBox"
        Me.StartTextBox.Size = New System.Drawing.Size(30, 27)
        Me.StartTextBox.TabIndex = 1
        '
        'EndTextBox
        '
        Me.EndTextBox.Location = New System.Drawing.Point(148, 66)
        Me.EndTextBox.Name = "EndTextBox"
        Me.EndTextBox.Size = New System.Drawing.Size(30, 27)
        Me.EndTextBox.TabIndex = 3
        '
        'StepTextBox
        '
        Me.StepTextBox.Location = New System.Drawing.Point(148, 99)
        Me.StepTextBox.Name = "StepTextBox"
        Me.StepTextBox.Size = New System.Drawing.Size(30, 27)
        Me.StepTextBox.TabIndex = 5
        '
        'DisplayButton
        '
        Me.DisplayButton.Location = New System.Drawing.Point(35, 149)
        Me.DisplayButton.Name = "DisplayButton"
        Me.DisplayButton.Size = New System.Drawing.Size(217, 30)
        Me.DisplayButton.TabIndex = 6
        Me.DisplayButton.Text = "&Display"
        Me.DisplayButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(35, 185)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(217, 30)
        Me.ClearButton.TabIndex = 7
        Me.ClearButton.Text = "&Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'QuitButton
        '
        Me.QuitButton.Location = New System.Drawing.Point(35, 221)
        Me.QuitButton.Name = "QuitButton"
        Me.QuitButton.Size = New System.Drawing.Size(217, 30)
        Me.QuitButton.TabIndex = 8
        Me.QuitButton.Text = "&Quit"
        Me.QuitButton.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(427, 291)
        Me.Controls.Add(Me.QuitButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.DisplayButton)
        Me.Controls.Add(Me.StepTextBox)
        Me.Controls.Add(Me.EndTextBox)
        Me.Controls.Add(Me.StartTextBox)
        Me.Controls.Add(Me.DisplayLabel)
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
    Friend WithEvents DisplayLabel As System.Windows.Forms.Label
    Friend WithEvents StartTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EndTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StepTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DisplayButton As System.Windows.Forms.Button
    Friend WithEvents ClearButton As System.Windows.Forms.Button
    Friend WithEvents QuitButton As System.Windows.Forms.Button

End Class
