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
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.ResetButton = New System.Windows.Forms.Button
        Me.ExitButton = New System.Windows.Forms.Button
        Me.ListboxSummaryButton = New System.Windows.Forms.Button
        Me.ComboBoxButton = New System.Windows.Forms.Button
        Me.MeatComboBox = New System.Windows.Forms.ComboBox
        Me.BreadComboBox = New System.Windows.Forms.ComboBox
        Me.SaladComboBox = New System.Windows.Forms.ComboBox
        Me.MeatListBox = New System.Windows.Forms.ListBox
        Me.BreadListBox = New System.Windows.Forms.ListBox
        Me.SaladListBox = New System.Windows.Forms.ListBox
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 4)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "List Boxes"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(199, 7)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Combo Boxes"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(199, 37)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Drop Down Style"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(199, 91)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = " Simple Style"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(199, 209)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Drop Down List Style"
        '
        'ResetButton
        '
        Me.ResetButton.Location = New System.Drawing.Point(86, 313)
        Me.ResetButton.Name = "ResetButton"
        Me.ResetButton.Size = New System.Drawing.Size(75, 23)
        Me.ResetButton.TabIndex = 7
        Me.ResetButton.Text = "Reset All"
        Me.ResetButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(191, 313)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(75, 23)
        Me.ExitButton.TabIndex = 7
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'ListboxSummaryButton
        '
        Me.ListboxSummaryButton.Location = New System.Drawing.Point(16, 266)
        Me.ListboxSummaryButton.Name = "ListboxSummaryButton"
        Me.ListboxSummaryButton.Size = New System.Drawing.Size(100, 23)
        Me.ListboxSummaryButton.TabIndex = 8
        Me.ListboxSummaryButton.Text = "List Box Summary"
        Me.ListboxSummaryButton.UseVisualStyleBackColor = True
        '
        'ComboBoxButton
        '
        Me.ComboBoxButton.Location = New System.Drawing.Point(188, 266)
        Me.ComboBoxButton.Name = "ComboBoxButton"
        Me.ComboBoxButton.Size = New System.Drawing.Size(117, 23)
        Me.ComboBoxButton.TabIndex = 8
        Me.ComboBoxButton.Text = "Combo Box Summary"
        Me.ComboBoxButton.UseVisualStyleBackColor = True
        '
        'MeatComboBox
        '
        Me.MeatComboBox.FormattingEnabled = True
        Me.MeatComboBox.Items.AddRange(New Object() {"Turkey", "Ham", "Roast Beef"})
        Me.MeatComboBox.Location = New System.Drawing.Point(202, 60)
        Me.MeatComboBox.Name = "MeatComboBox"
        Me.MeatComboBox.Size = New System.Drawing.Size(121, 21)
        Me.MeatComboBox.TabIndex = 9
        '
        'BreadComboBox
        '
        Me.BreadComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.BreadComboBox.FormattingEnabled = True
        Me.BreadComboBox.Items.AddRange(New Object() {"White", "Wheat", "Rye", "Pumpernickel", "Sourdough"})
        Me.BreadComboBox.Location = New System.Drawing.Point(202, 109)
        Me.BreadComboBox.Name = "BreadComboBox"
        Me.BreadComboBox.Size = New System.Drawing.Size(121, 98)
        Me.BreadComboBox.TabIndex = 10
        '
        'SaladComboBox
        '
        Me.SaladComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SaladComboBox.FormattingEnabled = True
        Me.SaladComboBox.Items.AddRange(New Object() {"Coleslaw", "Potato", "Dinner", "Caesar"})
        Me.SaladComboBox.Location = New System.Drawing.Point(202, 228)
        Me.SaladComboBox.Name = "SaladComboBox"
        Me.SaladComboBox.Size = New System.Drawing.Size(121, 21)
        Me.SaladComboBox.TabIndex = 11
        '
        'MeatListBox
        '
        Me.MeatListBox.FormattingEnabled = True
        Me.MeatListBox.Items.AddRange(New Object() {"Turkey", "Ham", "Roast Beef"})
        Me.MeatListBox.Location = New System.Drawing.Point(16, 26)
        Me.MeatListBox.Name = "MeatListBox"
        Me.MeatListBox.Size = New System.Drawing.Size(100, 56)
        Me.MeatListBox.TabIndex = 12
        '
        'BreadListBox
        '
        Me.BreadListBox.FormattingEnabled = True
        Me.BreadListBox.Items.AddRange(New Object() {"White", "Wheat", "Rye", "Pumpernickel", "Sourdough"})
        Me.BreadListBox.Location = New System.Drawing.Point(16, 110)
        Me.BreadListBox.Name = "BreadListBox"
        Me.BreadListBox.Size = New System.Drawing.Size(100, 56)
        Me.BreadListBox.TabIndex = 13
        '
        'SaladListBox
        '
        Me.SaladListBox.FormattingEnabled = True
        Me.SaladListBox.Items.AddRange(New Object() {"Dinner", "Caesar", "Coleslaw", "Potato"})
        Me.SaladListBox.Location = New System.Drawing.Point(16, 193)
        Me.SaladListBox.Name = "SaladListBox"
        Me.SaladListBox.Size = New System.Drawing.Size(100, 56)
        Me.SaladListBox.TabIndex = 14
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(342, 348)
        Me.Controls.Add(Me.SaladListBox)
        Me.Controls.Add(Me.BreadListBox)
        Me.Controls.Add(Me.MeatListBox)
        Me.Controls.Add(Me.SaladComboBox)
        Me.Controls.Add(Me.BreadComboBox)
        Me.Controls.Add(Me.MeatComboBox)
        Me.Controls.Add(Me.ComboBoxButton)
        Me.Controls.Add(Me.ListboxSummaryButton)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.ResetButton)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "MainForm"
        Me.Text = "List Boxes and Combo Boxes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ResetButton As System.Windows.Forms.Button
    Friend WithEvents ExitButton As System.Windows.Forms.Button
    Friend WithEvents ListboxSummaryButton As System.Windows.Forms.Button
    Friend WithEvents ComboBoxButton As System.Windows.Forms.Button
    Friend WithEvents MeatComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents BreadComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents SaladComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents MeatListBox As System.Windows.Forms.ListBox
    Friend WithEvents BreadListBox As System.Windows.Forms.ListBox
    Friend WithEvents SaladListBox As System.Windows.Forms.ListBox

End Class
