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
        Me.FirstNumTextBox = New System.Windows.Forms.TextBox
        Me.SecondNumTextBox = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.FindLargerButton = New System.Windows.Forms.Button
        Me.ResultTextBox = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'FirstNumTextBox
        '
        Me.FirstNumTextBox.Location = New System.Drawing.Point(137, 15)
        Me.FirstNumTextBox.Name = "FirstNumTextBox"
        Me.FirstNumTextBox.Size = New System.Drawing.Size(64, 20)
        Me.FirstNumTextBox.TabIndex = 0
        '
        'SecondNumTextBox
        '
        Me.SecondNumTextBox.Location = New System.Drawing.Point(137, 51)
        Me.SecondNumTextBox.Name = "SecondNumTextBox"
        Me.SecondNumTextBox.Size = New System.Drawing.Size(64, 20)
        Me.SecondNumTextBox.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(58, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "First number:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(40, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Second number:"
        '
        'FindLargerButton
        '
        Me.FindLargerButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FindLargerButton.Location = New System.Drawing.Point(12, 95)
        Me.FindLargerButton.Name = "FindLargerButton"
        Me.FindLargerButton.Size = New System.Drawing.Size(233, 40)
        Me.FindLargerButton.TabIndex = 4
        Me.FindLargerButton.Text = "Find Larger Number"
        Me.FindLargerButton.UseVisualStyleBackColor = True
        '
        'ResultTextBox
        '
        Me.ResultTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ResultTextBox.Location = New System.Drawing.Point(12, 157)
        Me.ResultTextBox.Name = "ResultTextBox"
        Me.ResultTextBox.ReadOnly = True
        Me.ResultTextBox.Size = New System.Drawing.Size(233, 22)
        Me.ResultTextBox.TabIndex = 5
        Me.ResultTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'MainForm
        '
        Me.AcceptButton = Me.FindLargerButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(257, 189)
        Me.Controls.Add(Me.ResultTextBox)
        Me.Controls.Add(Me.FindLargerButton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SecondNumTextBox)
        Me.Controls.Add(Me.FirstNumTextBox)
        Me.Name = "MainForm"
        Me.Text = "Maximum"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FirstNumTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SecondNumTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents FindLargerButton As System.Windows.Forms.Button
    Friend WithEvents ResultTextBox As System.Windows.Forms.TextBox

End Class
