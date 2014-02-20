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
        Me.BagelComboBox = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.AddButton = New System.Windows.Forms.Button
        Me.RemoveButton = New System.Windows.Forms.Button
        Me.ClearButton = New System.Windows.Forms.Button
        Me.CountButton = New System.Windows.Forms.Button
        Me.ExitButton = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'BagelComboBox
        '
        Me.BagelComboBox.FormattingEnabled = True
        Me.BagelComboBox.Items.AddRange(New Object() {"Egg", "Plain", "Sesame", "Wheat"})
        Me.BagelComboBox.Location = New System.Drawing.Point(12, 40)
        Me.BagelComboBox.Name = "BagelComboBox"
        Me.BagelComboBox.Size = New System.Drawing.Size(121, 21)
        Me.BagelComboBox.Sorted = True
        Me.BagelComboBox.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Bagel Types"
        '
        'AddButton
        '
        Me.AddButton.Location = New System.Drawing.Point(151, 38)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(113, 23)
        Me.AddButton.TabIndex = 2
        Me.AddButton.Text = "Add Bagel Type"
        Me.AddButton.UseVisualStyleBackColor = True
        '
        'RemoveButton
        '
        Me.RemoveButton.Location = New System.Drawing.Point(151, 70)
        Me.RemoveButton.Name = "RemoveButton"
        Me.RemoveButton.Size = New System.Drawing.Size(113, 23)
        Me.RemoveButton.TabIndex = 3
        Me.RemoveButton.Text = "Remove Bagel Type"
        Me.RemoveButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(151, 102)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(113, 23)
        Me.ClearButton.TabIndex = 4
        Me.ClearButton.Text = "Clear Bagel List"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'CountButton
        '
        Me.CountButton.Location = New System.Drawing.Point(109, 134)
        Me.CountButton.Name = "CountButton"
        Me.CountButton.Size = New System.Drawing.Size(155, 23)
        Me.CountButton.TabIndex = 5
        Me.CountButton.Text = "Display Bagel Type Count"
        Me.CountButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(12, 134)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(75, 23)
        Me.ExitButton.TabIndex = 6
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(276, 177)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.CountButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.RemoveButton)
        Me.Controls.Add(Me.AddButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BagelComboBox)
        Me.Name = "MainForm"
        Me.Text = "Benjamin Bakery Bagels"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BagelComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents AddButton As System.Windows.Forms.Button
    Friend WithEvents RemoveButton As System.Windows.Forms.Button
    Friend WithEvents ClearButton As System.Windows.Forms.Button
    Friend WithEvents CountButton As System.Windows.Forms.Button
    Friend WithEvents ExitButton As System.Windows.Forms.Button

End Class
