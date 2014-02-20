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
        Me.startButton = New System.Windows.Forms.Button
        Me.DisplayLabel = New System.Windows.Forms.Label
        Me.exitButton = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'startButton
        '
        Me.startButton.Location = New System.Drawing.Point(101, 23)
        Me.startButton.Name = "startButton"
        Me.startButton.Size = New System.Drawing.Size(107, 40)
        Me.startButton.TabIndex = 0
        Me.startButton.Text = "&Start Here"
        Me.startButton.UseVisualStyleBackColor = True
        '
        'DisplayLabel
        '
        Me.DisplayLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DisplayLabel.Location = New System.Drawing.Point(24, 78)
        Me.DisplayLabel.Name = "DisplayLabel"
        Me.DisplayLabel.Size = New System.Drawing.Size(262, 212)
        Me.DisplayLabel.TabIndex = 2
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(101, 315)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(107, 40)
        Me.exitButton.TabIndex = 1
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(315, 399)
        Me.Controls.Add(Me.DisplayLabel)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.startButton)
        Me.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "MainForm"
        Me.Text = "Do Loop Example"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents startButton As System.Windows.Forms.Button
    Friend WithEvents DisplayLabel As System.Windows.Forms.Label
    Friend WithEvents exitButton As System.Windows.Forms.Button

End Class
