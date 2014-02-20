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
        Me.DepositTextBox = New System.Windows.Forms.TextBox
        Me.InterestListBox = New System.Windows.Forms.ListBox
        Me.InvestmentLabel = New System.Windows.Forms.Label
        Me.CalcButton = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Initial Deposit:     $"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Interest Rate:"
        '
        'DepositTextBox
        '
        Me.DepositTextBox.Location = New System.Drawing.Point(125, 14)
        Me.DepositTextBox.Name = "DepositTextBox"
        Me.DepositTextBox.Size = New System.Drawing.Size(108, 20)
        Me.DepositTextBox.TabIndex = 2
        '
        'InterestListBox
        '
        Me.InterestListBox.FormattingEnabled = True
        Me.InterestListBox.Items.AddRange(New Object() {"3.00", "3.25", "3.50", "3.75", "4.00", "4.25", "4.50", "4.75", "5.00", "5.25", "5.50", "5.75", "6.00", "6.25", "6.50", "6.75", "7.00"})
        Me.InterestListBox.Location = New System.Drawing.Point(125, 46)
        Me.InterestListBox.Name = "InterestListBox"
        Me.InterestListBox.Size = New System.Drawing.Size(54, 69)
        Me.InterestListBox.TabIndex = 4
        '
        'InvestmentLabel
        '
        Me.InvestmentLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.InvestmentLabel.Location = New System.Drawing.Point(12, 167)
        Me.InvestmentLabel.Name = "InvestmentLabel"
        Me.InvestmentLabel.Size = New System.Drawing.Size(221, 137)
        Me.InvestmentLabel.TabIndex = 5
        Me.InvestmentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CalcButton
        '
        Me.CalcButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CalcButton.Location = New System.Drawing.Point(12, 129)
        Me.CalcButton.Name = "CalcButton"
        Me.CalcButton.Size = New System.Drawing.Size(221, 23)
        Me.CalcButton.TabIndex = 6
        Me.CalcButton.Text = "Calculate"
        Me.CalcButton.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(249, 313)
        Me.Controls.Add(Me.CalcButton)
        Me.Controls.Add(Me.InvestmentLabel)
        Me.Controls.Add(Me.InterestListBox)
        Me.Controls.Add(Me.DepositTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "MainForm"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DepositTextBox As System.Windows.Forms.TextBox
    Friend WithEvents InterestListBox As System.Windows.Forms.ListBox
    Friend WithEvents InvestmentLabel As System.Windows.Forms.Label
    Friend WithEvents CalcButton As System.Windows.Forms.Button

End Class
