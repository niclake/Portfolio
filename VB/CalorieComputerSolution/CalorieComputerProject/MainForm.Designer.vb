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
        Me.CarbsLabel = New System.Windows.Forms.Label
        Me.ProteinLabel = New System.Windows.Forms.Label
        Me.FatLabel = New System.Windows.Forms.Label
        Me.CarbsTextBox = New System.Windows.Forms.TextBox
        Me.ProteinTextBox = New System.Windows.Forms.TextBox
        Me.FatTextBox = New System.Windows.Forms.TextBox
        Me.ComputeButton = New System.Windows.Forms.Button
        Me.TotalLabel = New System.Windows.Forms.Label
        Me.TotalTextBox = New System.Windows.Forms.TextBox
        Me.ClearButton = New System.Windows.Forms.Button
        Me.QuitButton = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'CarbsLabel
        '
        Me.CarbsLabel.AutoSize = True
        Me.CarbsLabel.Location = New System.Drawing.Point(27, 30)
        Me.CarbsLabel.Name = "CarbsLabel"
        Me.CarbsLabel.Size = New System.Drawing.Size(117, 13)
        Me.CarbsLabel.TabIndex = 0
        Me.CarbsLabel.Text = "Grams of carbohydrate:"
        Me.CarbsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ProteinLabel
        '
        Me.ProteinLabel.AutoSize = True
        Me.ProteinLabel.Location = New System.Drawing.Point(57, 100)
        Me.ProteinLabel.Name = "ProteinLabel"
        Me.ProteinLabel.Size = New System.Drawing.Size(87, 13)
        Me.ProteinLabel.TabIndex = 1
        Me.ProteinLabel.Text = "Grams of protein:"
        Me.ProteinLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FatLabel
        '
        Me.FatLabel.AutoSize = True
        Me.FatLabel.Location = New System.Drawing.Point(74, 65)
        Me.FatLabel.Name = "FatLabel"
        Me.FatLabel.Size = New System.Drawing.Size(70, 13)
        Me.FatLabel.TabIndex = 2
        Me.FatLabel.Text = "Grams of Fat:"
        Me.FatLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CarbsTextBox
        '
        Me.CarbsTextBox.Location = New System.Drawing.Point(150, 27)
        Me.CarbsTextBox.Name = "CarbsTextBox"
        Me.CarbsTextBox.Size = New System.Drawing.Size(66, 20)
        Me.CarbsTextBox.TabIndex = 0
        '
        'ProteinTextBox
        '
        Me.ProteinTextBox.Location = New System.Drawing.Point(150, 97)
        Me.ProteinTextBox.Name = "ProteinTextBox"
        Me.ProteinTextBox.Size = New System.Drawing.Size(66, 20)
        Me.ProteinTextBox.TabIndex = 2
        '
        'FatTextBox
        '
        Me.FatTextBox.Location = New System.Drawing.Point(150, 62)
        Me.FatTextBox.Name = "FatTextBox"
        Me.FatTextBox.Size = New System.Drawing.Size(66, 20)
        Me.FatTextBox.TabIndex = 1
        '
        'ComputeButton
        '
        Me.ComputeButton.Location = New System.Drawing.Point(30, 132)
        Me.ComputeButton.Name = "ComputeButton"
        Me.ComputeButton.Size = New System.Drawing.Size(235, 23)
        Me.ComputeButton.TabIndex = 3
        Me.ComputeButton.Text = "Compute Calories"
        Me.ComputeButton.UseVisualStyleBackColor = True
        '
        'TotalLabel
        '
        Me.TotalLabel.AutoSize = True
        Me.TotalLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalLabel.Location = New System.Drawing.Point(55, 174)
        Me.TotalLabel.Name = "TotalLabel"
        Me.TotalLabel.Size = New System.Drawing.Size(89, 13)
        Me.TotalLabel.TabIndex = 7
        Me.TotalLabel.Text = "Total Calories:"
        '
        'TotalTextBox
        '
        Me.TotalTextBox.Location = New System.Drawing.Point(150, 171)
        Me.TotalTextBox.Name = "TotalTextBox"
        Me.TotalTextBox.ReadOnly = True
        Me.TotalTextBox.Size = New System.Drawing.Size(66, 20)
        Me.TotalTextBox.TabIndex = 5
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(30, 218)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(75, 43)
        Me.ClearButton.TabIndex = 4
        Me.ClearButton.Text = "Clear Form"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'QuitButton
        '
        Me.QuitButton.Location = New System.Drawing.Point(190, 218)
        Me.QuitButton.Name = "QuitButton"
        Me.QuitButton.Size = New System.Drawing.Size(75, 43)
        Me.QuitButton.TabIndex = 5
        Me.QuitButton.Text = "Quit"
        Me.QuitButton.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 273)
        Me.Controls.Add(Me.QuitButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.TotalTextBox)
        Me.Controls.Add(Me.TotalLabel)
        Me.Controls.Add(Me.ComputeButton)
        Me.Controls.Add(Me.FatTextBox)
        Me.Controls.Add(Me.ProteinTextBox)
        Me.Controls.Add(Me.CarbsTextBox)
        Me.Controls.Add(Me.FatLabel)
        Me.Controls.Add(Me.ProteinLabel)
        Me.Controls.Add(Me.CarbsLabel)
        Me.Name = "MainForm"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CarbsLabel As System.Windows.Forms.Label
    Friend WithEvents ProteinLabel As System.Windows.Forms.Label
    Friend WithEvents FatLabel As System.Windows.Forms.Label
    Friend WithEvents CarbsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ProteinTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FatTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ComputeButton As System.Windows.Forms.Button
    Friend WithEvents TotalLabel As System.Windows.Forms.Label
    Friend WithEvents TotalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ClearButton As System.Windows.Forms.Button
    Friend WithEvents QuitButton As System.Windows.Forms.Button

End Class
