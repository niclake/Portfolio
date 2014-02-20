<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
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
        Me.DisplayButton = New System.Windows.Forms.Button
        Me.ExitButton = New System.Windows.Forms.Button
        Me.SquaresLabel = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'DisplayButton
        '
        Me.DisplayButton.Location = New System.Drawing.Point(184, 53)
        Me.DisplayButton.Name = "DisplayButton"
        Me.DisplayButton.Size = New System.Drawing.Size(75, 33)
        Me.DisplayButton.TabIndex = 0
        Me.DisplayButton.Text = "&Display"
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(184, 115)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(75, 33)
        Me.ExitButton.TabIndex = 1
        Me.ExitButton.Text = "E&xit"
        '
        'SquaresLabel
        '
        Me.SquaresLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SquaresLabel.Location = New System.Drawing.Point(12, 9)
        Me.SquaresLabel.Name = "SquaresLabel"
        Me.SquaresLabel.Size = New System.Drawing.Size(138, 172)
        Me.SquaresLabel.TabIndex = 2
        Me.SquaresLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(271, 202)
        Me.Controls.Add(Me.SquaresLabel)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.DisplayButton)
        Me.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Even Squares"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DisplayButton As System.Windows.Forms.Button
    Friend WithEvents ExitButton As System.Windows.Forms.Button
    Friend WithEvents SquaresLabel As System.Windows.Forms.Label

End Class
