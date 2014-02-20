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
        Me.SalaryTextBox = New System.Windows.Forms.TextBox
        Me.YearsTextBox = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.CalcButton = New System.Windows.Forms.Button
        Me.ResultLabel = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'SalaryTextBox
        '
        Me.SalaryTextBox.Location = New System.Drawing.Point(154, 28)
        Me.SalaryTextBox.Name = "SalaryTextBox"
        Me.SalaryTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SalaryTextBox.TabIndex = 0
        '
        'YearsTextBox
        '
        Me.YearsTextBox.Location = New System.Drawing.Point(154, 76)
        Me.YearsTextBox.Name = "YearsTextBox"
        Me.YearsTextBox.Size = New System.Drawing.Size(100, 20)
        Me.YearsTextBox.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Current salary:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Years at Current Job:"
        '
        'CalcButton
        '
        Me.CalcButton.Location = New System.Drawing.Point(101, 118)
        Me.CalcButton.Name = "CalcButton"
        Me.CalcButton.Size = New System.Drawing.Size(75, 23)
        Me.CalcButton.TabIndex = 4
        Me.CalcButton.Text = "Calculate"
        Me.CalcButton.UseVisualStyleBackColor = True
        '
        'ResultLabel
        '
        Me.ResultLabel.ForeColor = System.Drawing.Color.Red
        Me.ResultLabel.Location = New System.Drawing.Point(26, 164)
        Me.ResultLabel.Name = "ResultLabel"
        Me.ResultLabel.Size = New System.Drawing.Size(228, 44)
        Me.ResultLabel.TabIndex = 5
        Me.ResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MainForm
        '
        Me.AcceptButton = Me.CalcButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 273)
        Me.Controls.Add(Me.ResultLabel)
        Me.Controls.Add(Me.CalcButton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.YearsTextBox)
        Me.Controls.Add(Me.SalaryTextBox)
        Me.Name = "MainForm"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SalaryTextBox As System.Windows.Forms.TextBox
    Friend WithEvents YearsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CalcButton As System.Windows.Forms.Button
    Friend WithEvents ResultLabel As System.Windows.Forms.Label

End Class
