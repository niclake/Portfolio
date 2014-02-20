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
        Me.NamesComboBox = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.AddButton = New System.Windows.Forms.Button
        Me.InsertButton = New System.Windows.Forms.Button
        Me.DisplayButton = New System.Windows.Forms.Button
        Me.RemoveButton = New System.Windows.Forms.Button
        Me.ExitButton = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'NamesComboBox
        '
        Me.NamesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.NamesComboBox.FormattingEnabled = True
        Me.NamesComboBox.Items.AddRange(New Object() {"Michaels, Brenda", "Harlow, Ronald", "Thomas, Renee", "Early, Mark"})
        Me.NamesComboBox.Location = New System.Drawing.Point(68, 36)
        Me.NamesComboBox.Margin = New System.Windows.Forms.Padding(2)
        Me.NamesComboBox.Name = "NamesComboBox"
        Me.NamesComboBox.Size = New System.Drawing.Size(120, 86)
        Me.NamesComboBox.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(44, 7)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(186, 20)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Field Trip Registration"
        '
        'AddButton
        '
        Me.AddButton.Location = New System.Drawing.Point(38, 167)
        Me.AddButton.Margin = New System.Windows.Forms.Padding(2)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(89, 31)
        Me.AddButton.TabIndex = 7
        Me.AddButton.Text = "Add Name"
        Me.AddButton.UseVisualStyleBackColor = True
        '
        'InsertButton
        '
        Me.InsertButton.Location = New System.Drawing.Point(38, 212)
        Me.InsertButton.Margin = New System.Windows.Forms.Padding(2)
        Me.InsertButton.Name = "InsertButton"
        Me.InsertButton.Size = New System.Drawing.Size(89, 31)
        Me.InsertButton.TabIndex = 7
        Me.InsertButton.Text = "Insert Name"
        Me.InsertButton.UseVisualStyleBackColor = True
        '
        'DisplayButton
        '
        Me.DisplayButton.Location = New System.Drawing.Point(142, 167)
        Me.DisplayButton.Margin = New System.Windows.Forms.Padding(2)
        Me.DisplayButton.Name = "DisplayButton"
        Me.DisplayButton.Size = New System.Drawing.Size(88, 31)
        Me.DisplayButton.TabIndex = 7
        Me.DisplayButton.Text = "Display Count"
        Me.DisplayButton.UseVisualStyleBackColor = True
        '
        'RemoveButton
        '
        Me.RemoveButton.Location = New System.Drawing.Point(142, 212)
        Me.RemoveButton.Margin = New System.Windows.Forms.Padding(2)
        Me.RemoveButton.Name = "RemoveButton"
        Me.RemoveButton.Size = New System.Drawing.Size(88, 31)
        Me.RemoveButton.TabIndex = 7
        Me.RemoveButton.Text = "Remove Name"
        Me.RemoveButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(107, 257)
        Me.ExitButton.Margin = New System.Windows.Forms.Padding(2)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(56, 28)
        Me.ExitButton.TabIndex = 8
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(259, 310)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.InsertButton)
        Me.Controls.Add(Me.RemoveButton)
        Me.Controls.Add(Me.DisplayButton)
        Me.Controls.Add(Me.AddButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.NamesComboBox)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "MainForm"
        Me.Text = "Combo Box Processing"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents NamesComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents AddButton As System.Windows.Forms.Button
    Friend WithEvents InsertButton As System.Windows.Forms.Button
    Friend WithEvents DisplayButton As System.Windows.Forms.Button
    Friend WithEvents RemoveButton As System.Windows.Forms.Button
    Friend WithEvents ExitButton As System.Windows.Forms.Button

End Class
