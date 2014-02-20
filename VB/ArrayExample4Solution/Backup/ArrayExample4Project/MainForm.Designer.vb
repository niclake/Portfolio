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
        Me.averageLabel = New System.Windows.Forms.Label
        Me.averageButton = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.maxLabel = New System.Windows.Forms.Label
        Me.maxButton = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.minLabel = New System.Windows.Forms.Label
        Me.minButton = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.dscSortButton = New System.Windows.Forms.Button
        Me.ascSortButton = New System.Windows.Forms.Button
        Me.adjustButton = New System.Windows.Forms.Button
        Me.clearButton = New System.Windows.Forms.Button
        Me.displayButton = New System.Windows.Forms.Button
        Me.pmtListBox = New System.Windows.Forms.ListBox
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
        'averageLabel
        '
        Me.averageLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.averageLabel.Location = New System.Drawing.Point(184, 15)
        Me.averageLabel.Name = "averageLabel"
        Me.averageLabel.Size = New System.Drawing.Size(87, 32)
        Me.averageLabel.TabIndex = 1
        Me.averageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'averageButton
        '
        Me.averageButton.Location = New System.Drawing.Point(90, 69)
        Me.averageButton.Name = "averageButton"
        Me.averageButton.Size = New System.Drawing.Size(122, 33)
        Me.averageButton.TabIndex = 2
        Me.averageButton.Text = "Find Average"
        Me.averageButton.UseVisualStyleBackColor = True
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
        'maxLabel
        '
        Me.maxLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.maxLabel.Location = New System.Drawing.Point(184, 14)
        Me.maxLabel.Name = "maxLabel"
        Me.maxLabel.Size = New System.Drawing.Size(87, 32)
        Me.maxLabel.TabIndex = 1
        Me.maxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'maxButton
        '
        Me.maxButton.Location = New System.Drawing.Point(90, 72)
        Me.maxButton.Name = "maxButton"
        Me.maxButton.Size = New System.Drawing.Size(122, 33)
        Me.maxButton.TabIndex = 2
        Me.maxButton.Text = "Find Largest"
        Me.maxButton.UseVisualStyleBackColor = True
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
        'minLabel
        '
        Me.minLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.minLabel.Location = New System.Drawing.Point(184, 126)
        Me.minLabel.Name = "minLabel"
        Me.minLabel.Size = New System.Drawing.Size(87, 32)
        Me.minLabel.TabIndex = 4
        Me.minLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'minButton
        '
        Me.minButton.Location = New System.Drawing.Point(90, 175)
        Me.minButton.Name = "minButton"
        Me.minButton.Size = New System.Drawing.Size(122, 37)
        Me.minButton.TabIndex = 5
        Me.minButton.Text = "Find Smallest"
        Me.minButton.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.averageLabel)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.averageButton)
        Me.Panel1.Location = New System.Drawing.Point(27, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(282, 121)
        Me.Panel1.TabIndex = 6
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.maxLabel)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.minButton)
        Me.Panel2.Controls.Add(Me.maxButton)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.minLabel)
        Me.Panel2.Location = New System.Drawing.Point(27, 139)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(282, 230)
        Me.Panel2.TabIndex = 7
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.dscSortButton)
        Me.Panel3.Controls.Add(Me.ascSortButton)
        Me.Panel3.Controls.Add(Me.adjustButton)
        Me.Panel3.Controls.Add(Me.clearButton)
        Me.Panel3.Controls.Add(Me.displayButton)
        Me.Panel3.Controls.Add(Me.pmtListBox)
        Me.Panel3.Location = New System.Drawing.Point(338, 11)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(272, 387)
        Me.Panel3.TabIndex = 8
        '
        'dscSortButton
        '
        Me.dscSortButton.Location = New System.Drawing.Point(117, 229)
        Me.dscSortButton.Name = "dscSortButton"
        Me.dscSortButton.Size = New System.Drawing.Size(117, 50)
        Me.dscSortButton.TabIndex = 4
        Me.dscSortButton.Text = "Sort Descending"
        Me.dscSortButton.UseVisualStyleBackColor = True
        '
        'ascSortButton
        '
        Me.ascSortButton.Location = New System.Drawing.Point(117, 173)
        Me.ascSortButton.Name = "ascSortButton"
        Me.ascSortButton.Size = New System.Drawing.Size(116, 50)
        Me.ascSortButton.TabIndex = 4
        Me.ascSortButton.Text = "Sort Ascending"
        Me.ascSortButton.UseVisualStyleBackColor = True
        '
        'adjustButton
        '
        Me.adjustButton.Location = New System.Drawing.Point(117, 122)
        Me.adjustButton.Name = "adjustButton"
        Me.adjustButton.Size = New System.Drawing.Size(116, 45)
        Me.adjustButton.TabIndex = 3
        Me.adjustButton.Text = "Adjust Values"
        Me.adjustButton.UseVisualStyleBackColor = True
        '
        'clearButton
        '
        Me.clearButton.Location = New System.Drawing.Point(117, 72)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Size = New System.Drawing.Size(116, 44)
        Me.clearButton.TabIndex = 2
        Me.clearButton.Text = "Clear Listbox"
        Me.clearButton.UseVisualStyleBackColor = True
        '
        'displayButton
        '
        Me.displayButton.Location = New System.Drawing.Point(117, 23)
        Me.displayButton.Name = "displayButton"
        Me.displayButton.Size = New System.Drawing.Size(116, 43)
        Me.displayButton.TabIndex = 1
        Me.displayButton.Text = "Display Array"
        Me.displayButton.UseVisualStyleBackColor = True
        '
        'pmtListBox
        '
        Me.pmtListBox.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pmtListBox.FormattingEnabled = True
        Me.pmtListBox.ItemHeight = 18
        Me.pmtListBox.Location = New System.Drawing.Point(14, 16)
        Me.pmtListBox.Name = "pmtListBox"
        Me.pmtListBox.Size = New System.Drawing.Size(65, 364)
        Me.pmtListBox.TabIndex = 0
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
    Friend WithEvents averageLabel As System.Windows.Forms.Label
    Friend WithEvents averageButton As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents maxLabel As System.Windows.Forms.Label
    Friend WithEvents maxButton As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents minLabel As System.Windows.Forms.Label
    Friend WithEvents minButton As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents displayButton As System.Windows.Forms.Button
    Friend WithEvents pmtListBox As System.Windows.Forms.ListBox
    Friend WithEvents clearButton As System.Windows.Forms.Button
    Friend WithEvents adjustButton As System.Windows.Forms.Button
    Friend WithEvents dscSortButton As System.Windows.Forms.Button
    Friend WithEvents ascSortButton As System.Windows.Forms.Button

End Class
