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
        Me.AverageLabel = New System.Windows.Forms.Label
        Me.AverageButton = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.MaxLabel = New System.Windows.Forms.Label
        Me.MaxButton = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.MinLabel = New System.Windows.Forms.Label
        Me.MinButton = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.DscSortButton = New System.Windows.Forms.Button
        Me.AscSortButton = New System.Windows.Forms.Button
        Me.AdjustButton = New System.Windows.Forms.Button
        Me.ClearButton = New System.Windows.Forms.Button
        Me.DisplayButton = New System.Windows.Forms.Button
        Me.PmtListBox = New System.Windows.Forms.ListBox
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(146, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Average payments:"
        '
        'AverageLabel
        '
        Me.AverageLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AverageLabel.Location = New System.Drawing.Point(184, 15)
        Me.AverageLabel.Name = "AverageLabel"
        Me.AverageLabel.Size = New System.Drawing.Size(87, 32)
        Me.AverageLabel.TabIndex = 1
        Me.AverageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AverageButton
        '
        Me.AverageButton.Location = New System.Drawing.Point(90, 69)
        Me.AverageButton.Name = "AverageButton"
        Me.AverageButton.Size = New System.Drawing.Size(122, 33)
        Me.AverageButton.TabIndex = 2
        Me.AverageButton.Text = "Find Average"
        Me.AverageButton.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(132, 19)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Largest payment:"
        '
        'MaxLabel
        '
        Me.MaxLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MaxLabel.Location = New System.Drawing.Point(184, 14)
        Me.MaxLabel.Name = "MaxLabel"
        Me.MaxLabel.Size = New System.Drawing.Size(87, 32)
        Me.MaxLabel.TabIndex = 1
        Me.MaxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MaxButton
        '
        Me.MaxButton.Location = New System.Drawing.Point(90, 72)
        Me.MaxButton.Name = "MaxButton"
        Me.MaxButton.Size = New System.Drawing.Size(122, 33)
        Me.MaxButton.TabIndex = 2
        Me.MaxButton.Text = "Find Largest"
        Me.MaxButton.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 139)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(140, 19)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Smallest payment:"
        '
        'MinLabel
        '
        Me.MinLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MinLabel.Location = New System.Drawing.Point(184, 126)
        Me.MinLabel.Name = "MinLabel"
        Me.MinLabel.Size = New System.Drawing.Size(87, 32)
        Me.MinLabel.TabIndex = 4
        Me.MinLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MinButton
        '
        Me.MinButton.Location = New System.Drawing.Point(90, 175)
        Me.MinButton.Name = "MinButton"
        Me.MinButton.Size = New System.Drawing.Size(122, 37)
        Me.MinButton.TabIndex = 5
        Me.MinButton.Text = "Find Smallest"
        Me.MinButton.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.AverageLabel)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.AverageButton)
        Me.Panel1.Location = New System.Drawing.Point(27, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(282, 121)
        Me.Panel1.TabIndex = 6
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.MaxLabel)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.MinButton)
        Me.Panel2.Controls.Add(Me.MaxButton)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.MinLabel)
        Me.Panel2.Location = New System.Drawing.Point(27, 139)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(282, 230)
        Me.Panel2.TabIndex = 7
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.DscSortButton)
        Me.Panel3.Controls.Add(Me.AscSortButton)
        Me.Panel3.Controls.Add(Me.AdjustButton)
        Me.Panel3.Controls.Add(Me.ClearButton)
        Me.Panel3.Controls.Add(Me.DisplayButton)
        Me.Panel3.Controls.Add(Me.PmtListBox)
        Me.Panel3.Location = New System.Drawing.Point(338, 11)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(272, 387)
        Me.Panel3.TabIndex = 8
        '
        'DscSortButton
        '
        Me.DscSortButton.Location = New System.Drawing.Point(117, 229)
        Me.DscSortButton.Name = "DscSortButton"
        Me.DscSortButton.Size = New System.Drawing.Size(117, 50)
        Me.DscSortButton.TabIndex = 4
        Me.DscSortButton.Text = "Sort Descending"
        Me.DscSortButton.UseVisualStyleBackColor = True
        '
        'AscSortButton
        '
        Me.AscSortButton.Location = New System.Drawing.Point(117, 173)
        Me.AscSortButton.Name = "AscSortButton"
        Me.AscSortButton.Size = New System.Drawing.Size(116, 50)
        Me.AscSortButton.TabIndex = 4
        Me.AscSortButton.Text = "Sort Ascending"
        Me.AscSortButton.UseVisualStyleBackColor = True
        '
        'AdjustButton
        '
        Me.AdjustButton.Location = New System.Drawing.Point(117, 122)
        Me.AdjustButton.Name = "AdjustButton"
        Me.AdjustButton.Size = New System.Drawing.Size(116, 45)
        Me.AdjustButton.TabIndex = 3
        Me.AdjustButton.Text = "Adjust Values"
        Me.AdjustButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(117, 72)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(116, 44)
        Me.ClearButton.TabIndex = 2
        Me.ClearButton.Text = "Clear Listbox"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'DisplayButton
        '
        Me.DisplayButton.Location = New System.Drawing.Point(117, 23)
        Me.DisplayButton.Name = "DisplayButton"
        Me.DisplayButton.Size = New System.Drawing.Size(116, 43)
        Me.DisplayButton.TabIndex = 1
        Me.DisplayButton.Text = "Display Array"
        Me.DisplayButton.UseVisualStyleBackColor = True
        '
        'PmtListBox
        '
        Me.PmtListBox.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PmtListBox.FormattingEnabled = True
        Me.PmtListBox.ItemHeight = 18
        Me.PmtListBox.Location = New System.Drawing.Point(14, 16)
        Me.PmtListBox.Name = "PmtListBox"
        Me.PmtListBox.Size = New System.Drawing.Size(77, 346)
        Me.PmtListBox.TabIndex = 0
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(634, 410)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "MainForm"
        Me.Text = "Array Example 4"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents AverageLabel As System.Windows.Forms.Label
    Friend WithEvents AverageButton As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents MaxLabel As System.Windows.Forms.Label
    Friend WithEvents MaxButton As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents MinLabel As System.Windows.Forms.Label
    Friend WithEvents MinButton As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents DisplayButton As System.Windows.Forms.Button
    Friend WithEvents PmtListBox As System.Windows.Forms.ListBox
    Friend WithEvents ClearButton As System.Windows.Forms.Button
    Friend WithEvents AdjustButton As System.Windows.Forms.Button
    Friend WithEvents DscSortButton As System.Windows.Forms.Button
    Friend WithEvents AscSortButton As System.Windows.Forms.Button

End Class
