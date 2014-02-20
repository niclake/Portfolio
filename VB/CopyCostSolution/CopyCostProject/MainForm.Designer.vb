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
        Me.ComputeCostButton = New System.Windows.Forms.Button
        Me.NumCopiesTextBox = New System.Windows.Forms.TextBox
        Me.CostTextBox = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Number of copies:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(47, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Total cost:"
        '
        'ComputeCostButton
        '
        Me.ComputeCostButton.Location = New System.Drawing.Point(25, 56)
        Me.ComputeCostButton.Name = "ComputeCostButton"
        Me.ComputeCostButton.Size = New System.Drawing.Size(234, 35)
        Me.ComputeCostButton.TabIndex = 1
        Me.ComputeCostButton.Text = "&Compute Cost"
        Me.ComputeCostButton.UseVisualStyleBackColor = True
        '
        'NumCopiesTextBox
        '
        Me.NumCopiesTextBox.Location = New System.Drawing.Point(174, 26)
        Me.NumCopiesTextBox.Name = "NumCopiesTextBox"
        Me.NumCopiesTextBox.Size = New System.Drawing.Size(78, 20)
        Me.NumCopiesTextBox.TabIndex = 0
        '
        'CostTextBox
        '
        Me.CostTextBox.Location = New System.Drawing.Point(134, 105)
        Me.CostTextBox.Name = "CostTextBox"
        Me.CostTextBox.ReadOnly = True
        Me.CostTextBox.Size = New System.Drawing.Size(118, 20)
        Me.CostTextBox.TabIndex = 4
        '
        'MainForm
        '
        Me.AcceptButton = Me.ComputeCostButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 148)
        Me.Controls.Add(Me.CostTextBox)
        Me.Controls.Add(Me.NumCopiesTextBox)
        Me.Controls.Add(Me.ComputeCostButton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "MainForm"
        Me.Text = "Total Order Cost"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ComputeCostButton As System.Windows.Forms.Button
    Friend WithEvents NumCopiesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CostTextBox As System.Windows.Forms.TextBox

End Class
