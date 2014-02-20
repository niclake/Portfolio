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
        Me.ResetButton = New System.Windows.Forms.Button
        Me.TotalsGroupBox = New System.Windows.Forms.GroupBox
        Me.NumItemsLabel = New System.Windows.Forms.Label
        Me.GrandTotalLabel = New System.Windows.Forms.Label
        Me.GrandTotalTextBox = New System.Windows.Forms.TextBox
        Me.TotalFatLabel = New System.Windows.Forms.Label
        Me.NumItemsTextBox = New System.Windows.Forms.TextBox
        Me.TotalProteinLabel = New System.Windows.Forms.Label
        Me.TotalFatTextBox = New System.Windows.Forms.TextBox
        Me.TotalCarbsLabel = New System.Windows.Forms.Label
        Me.TotalProteinTextBox = New System.Windows.Forms.TextBox
        Me.TotalCarbTextBox = New System.Windows.Forms.TextBox
        Me.TotalsGroupBox.SuspendLayout()
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
        Me.FatLabel.Size = New System.Drawing.Size(67, 13)
        Me.FatLabel.TabIndex = 2
        Me.FatLabel.Text = "Grams of fat:"
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
        Me.ComputeButton.Size = New System.Drawing.Size(186, 23)
        Me.ComputeButton.TabIndex = 3
        Me.ComputeButton.Text = "&Compute Calories"
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
        Me.ClearButton.Text = "C&lear Form"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'QuitButton
        '
        Me.QuitButton.Location = New System.Drawing.Point(141, 218)
        Me.QuitButton.Name = "QuitButton"
        Me.QuitButton.Size = New System.Drawing.Size(75, 43)
        Me.QuitButton.TabIndex = 5
        Me.QuitButton.Text = "&Quit"
        Me.QuitButton.UseVisualStyleBackColor = True
        '
        'ResetButton
        '
        Me.ResetButton.Location = New System.Drawing.Point(388, 218)
        Me.ResetButton.Name = "ResetButton"
        Me.ResetButton.Size = New System.Drawing.Size(75, 43)
        Me.ResetButton.TabIndex = 13
        Me.ResetButton.Text = "&Reset Form"
        Me.ResetButton.UseVisualStyleBackColor = True
        '
        'TotalsGroupBox
        '
        Me.TotalsGroupBox.Controls.Add(Me.NumItemsLabel)
        Me.TotalsGroupBox.Controls.Add(Me.GrandTotalLabel)
        Me.TotalsGroupBox.Controls.Add(Me.GrandTotalTextBox)
        Me.TotalsGroupBox.Controls.Add(Me.TotalFatLabel)
        Me.TotalsGroupBox.Controls.Add(Me.NumItemsTextBox)
        Me.TotalsGroupBox.Controls.Add(Me.TotalProteinLabel)
        Me.TotalsGroupBox.Controls.Add(Me.TotalFatTextBox)
        Me.TotalsGroupBox.Controls.Add(Me.TotalCarbsLabel)
        Me.TotalsGroupBox.Controls.Add(Me.TotalProteinTextBox)
        Me.TotalsGroupBox.Controls.Add(Me.TotalCarbTextBox)
        Me.TotalsGroupBox.Location = New System.Drawing.Point(233, 5)
        Me.TotalsGroupBox.Name = "TotalsGroupBox"
        Me.TotalsGroupBox.Size = New System.Drawing.Size(244, 196)
        Me.TotalsGroupBox.TabIndex = 14
        Me.TotalsGroupBox.TabStop = False
        Me.TotalsGroupBox.Text = "Totals"
        '
        'NumItemsLabel
        '
        Me.NumItemsLabel.AutoSize = True
        Me.NumItemsLabel.Location = New System.Drawing.Point(87, 132)
        Me.NumItemsLabel.Name = "NumItemsLabel"
        Me.NumItemsLabel.Size = New System.Drawing.Size(114, 13)
        Me.NumItemsLabel.TabIndex = 21
        Me.NumItemsLabel.Text = "- Total number of items"
        Me.NumItemsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GrandTotalLabel
        '
        Me.GrandTotalLabel.AutoSize = True
        Me.GrandTotalLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrandTotalLabel.Location = New System.Drawing.Point(87, 169)
        Me.GrandTotalLabel.Name = "GrandTotalLabel"
        Me.GrandTotalLabel.Size = New System.Drawing.Size(146, 13)
        Me.GrandTotalLabel.TabIndex = 18
        Me.GrandTotalLabel.Text = "- Grand Total of Calories"
        '
        'GrandTotalTextBox
        '
        Me.GrandTotalTextBox.Location = New System.Drawing.Point(10, 166)
        Me.GrandTotalTextBox.Name = "GrandTotalTextBox"
        Me.GrandTotalTextBox.ReadOnly = True
        Me.GrandTotalTextBox.Size = New System.Drawing.Size(66, 20)
        Me.GrandTotalTextBox.TabIndex = 17
        '
        'TotalFatLabel
        '
        Me.TotalFatLabel.AutoSize = True
        Me.TotalFatLabel.Location = New System.Drawing.Point(87, 60)
        Me.TotalFatLabel.Name = "TotalFatLabel"
        Me.TotalFatLabel.Size = New System.Drawing.Size(95, 13)
        Me.TotalFatLabel.TabIndex = 17
        Me.TotalFatLabel.Text = "- Total grams of fat"
        Me.TotalFatLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'NumItemsTextBox
        '
        Me.NumItemsTextBox.Location = New System.Drawing.Point(10, 129)
        Me.NumItemsTextBox.Name = "NumItemsTextBox"
        Me.NumItemsTextBox.ReadOnly = True
        Me.NumItemsTextBox.Size = New System.Drawing.Size(66, 20)
        Me.NumItemsTextBox.TabIndex = 16
        '
        'TotalProteinLabel
        '
        Me.TotalProteinLabel.AutoSize = True
        Me.TotalProteinLabel.Location = New System.Drawing.Point(87, 95)
        Me.TotalProteinLabel.Name = "TotalProteinLabel"
        Me.TotalProteinLabel.Size = New System.Drawing.Size(115, 13)
        Me.TotalProteinLabel.TabIndex = 16
        Me.TotalProteinLabel.Text = "- Total grams of protein"
        Me.TotalProteinLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TotalFatTextBox
        '
        Me.TotalFatTextBox.Location = New System.Drawing.Point(10, 57)
        Me.TotalFatTextBox.Name = "TotalFatTextBox"
        Me.TotalFatTextBox.ReadOnly = True
        Me.TotalFatTextBox.Size = New System.Drawing.Size(66, 20)
        Me.TotalFatTextBox.TabIndex = 14
        '
        'TotalCarbsLabel
        '
        Me.TotalCarbsLabel.AutoSize = True
        Me.TotalCarbsLabel.Location = New System.Drawing.Point(87, 25)
        Me.TotalCarbsLabel.Name = "TotalCarbsLabel"
        Me.TotalCarbsLabel.Size = New System.Drawing.Size(145, 13)
        Me.TotalCarbsLabel.TabIndex = 15
        Me.TotalCarbsLabel.Text = "- Total grams of carbohydrate"
        Me.TotalCarbsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TotalProteinTextBox
        '
        Me.TotalProteinTextBox.Location = New System.Drawing.Point(10, 92)
        Me.TotalProteinTextBox.Name = "TotalProteinTextBox"
        Me.TotalProteinTextBox.ReadOnly = True
        Me.TotalProteinTextBox.Size = New System.Drawing.Size(66, 20)
        Me.TotalProteinTextBox.TabIndex = 15
        '
        'TotalCarbTextBox
        '
        Me.TotalCarbTextBox.Location = New System.Drawing.Point(10, 22)
        Me.TotalCarbTextBox.Name = "TotalCarbTextBox"
        Me.TotalCarbTextBox.ReadOnly = True
        Me.TotalCarbTextBox.Size = New System.Drawing.Size(66, 20)
        Me.TotalCarbTextBox.TabIndex = 13
        '
        'MainForm
        '
        Me.AcceptButton = Me.ComputeButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(489, 273)
        Me.Controls.Add(Me.TotalsGroupBox)
        Me.Controls.Add(Me.ResetButton)
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
        Me.Text = "Calorie Calculator"
        Me.TotalsGroupBox.ResumeLayout(False)
        Me.TotalsGroupBox.PerformLayout()
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
    Friend WithEvents ResetButton As System.Windows.Forms.Button
    Friend WithEvents TotalsGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents GrandTotalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NumItemsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TotalFatTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TotalProteinTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TotalCarbTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GrandTotalLabel As System.Windows.Forms.Label
    Friend WithEvents TotalFatLabel As System.Windows.Forms.Label
    Friend WithEvents TotalCarbsLabel As System.Windows.Forms.Label
    Friend WithEvents NumItemsLabel As System.Windows.Forms.Label
    Friend WithEvents TotalProteinLabel As System.Windows.Forms.Label

End Class
