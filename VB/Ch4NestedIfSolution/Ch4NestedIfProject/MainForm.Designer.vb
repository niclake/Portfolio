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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.PreferredRadioButton = New System.Windows.Forms.RadioButton
        Me.StdRadioButton = New System.Windows.Forms.RadioButton
        Me.SpecialRadioButton = New System.Windows.Forms.RadioButton
        Me.QuantityTextBox = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.FindButton = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.DiscountTextBox = New System.Windows.Forms.TextBox
        Me.ClearButton = New System.Windows.Forms.Button
        Me.ExitButton = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PreferredRadioButton)
        Me.GroupBox1.Controls.Add(Me.StdRadioButton)
        Me.GroupBox1.Controls.Add(Me.SpecialRadioButton)
        Me.GroupBox1.Location = New System.Drawing.Point(28, 49)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(128, 103)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Customer Type:"
        '
        'PreferredRadioButton
        '
        Me.PreferredRadioButton.AutoSize = True
        Me.PreferredRadioButton.Location = New System.Drawing.Point(30, 70)
        Me.PreferredRadioButton.Margin = New System.Windows.Forms.Padding(2)
        Me.PreferredRadioButton.Name = "PreferredRadioButton"
        Me.PreferredRadioButton.Size = New System.Drawing.Size(68, 17)
        Me.PreferredRadioButton.TabIndex = 2
        Me.PreferredRadioButton.Text = "Preferred"
        Me.PreferredRadioButton.UseVisualStyleBackColor = True
        '
        'StdRadioButton
        '
        Me.StdRadioButton.AutoSize = True
        Me.StdRadioButton.Checked = True
        Me.StdRadioButton.Location = New System.Drawing.Point(30, 26)
        Me.StdRadioButton.Margin = New System.Windows.Forms.Padding(2)
        Me.StdRadioButton.Name = "StdRadioButton"
        Me.StdRadioButton.Size = New System.Drawing.Size(68, 17)
        Me.StdRadioButton.TabIndex = 0
        Me.StdRadioButton.TabStop = True
        Me.StdRadioButton.Text = "Standard"
        Me.StdRadioButton.UseVisualStyleBackColor = True
        '
        'SpecialRadioButton
        '
        Me.SpecialRadioButton.AutoSize = True
        Me.SpecialRadioButton.Location = New System.Drawing.Point(30, 48)
        Me.SpecialRadioButton.Margin = New System.Windows.Forms.Padding(2)
        Me.SpecialRadioButton.Name = "SpecialRadioButton"
        Me.SpecialRadioButton.Size = New System.Drawing.Size(60, 17)
        Me.SpecialRadioButton.TabIndex = 1
        Me.SpecialRadioButton.Text = "Special"
        Me.SpecialRadioButton.UseVisualStyleBackColor = True
        '
        'QuantityTextBox
        '
        Me.QuantityTextBox.Location = New System.Drawing.Point(129, 176)
        Me.QuantityTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.QuantityTextBox.Name = "QuantityTextBox"
        Me.QuantityTextBox.Size = New System.Drawing.Size(48, 20)
        Me.QuantityTextBox.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 179)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Quantity ordered:"
        '
        'FindButton
        '
        Me.FindButton.Location = New System.Drawing.Point(38, 213)
        Me.FindButton.Margin = New System.Windows.Forms.Padding(2)
        Me.FindButton.Name = "FindButton"
        Me.FindButton.Size = New System.Drawing.Size(151, 26)
        Me.FindButton.TabIndex = 3
        Me.FindButton.Text = "&Find Discount"
        Me.FindButton.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(35, 260)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Discount:"
        '
        'DiscountTextBox
        '
        Me.DiscountTextBox.Location = New System.Drawing.Point(129, 260)
        Me.DiscountTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.DiscountTextBox.Name = "DiscountTextBox"
        Me.DiscountTextBox.ReadOnly = True
        Me.DiscountTextBox.Size = New System.Drawing.Size(48, 20)
        Me.DiscountTextBox.TabIndex = 7
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(38, 289)
        Me.ClearButton.Margin = New System.Windows.Forms.Padding(2)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(56, 25)
        Me.ClearButton.TabIndex = 4
        Me.ClearButton.Text = "&Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(119, 289)
        Me.ExitButton.Margin = New System.Windows.Forms.Padding(2)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(56, 25)
        Me.ExitButton.TabIndex = 5
        Me.ExitButton.Text = "E&xit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(35, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 20)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Discount Finder"
        '
        'MainForm
        '
        Me.AcceptButton = Me.FindButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(217, 333)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.DiscountTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.FindButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.QuantityTextBox)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "MainForm"
        Me.Text = "Nested If Example"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents PreferredRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents StdRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents SpecialRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents QuantityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents FindButton As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DiscountTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ClearButton As System.Windows.Forms.Button
    Friend WithEvents ExitButton As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label

End Class
