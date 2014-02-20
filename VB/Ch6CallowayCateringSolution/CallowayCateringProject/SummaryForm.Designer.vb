<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SummaryForm
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
        Me.EventsTextBox = New System.Windows.Forms.TextBox
        Me.RevenueTextBox = New System.Windows.Forms.TextBox
        Me.OKButton = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Number of Events:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Total Revenue:"
        '
        'EventsTextBox
        '
        Me.EventsTextBox.Location = New System.Drawing.Point(113, 20)
        Me.EventsTextBox.Name = "EventsTextBox"
        Me.EventsTextBox.ReadOnly = True
        Me.EventsTextBox.Size = New System.Drawing.Size(100, 20)
        Me.EventsTextBox.TabIndex = 2
        '
        'RevenueTextBox
        '
        Me.RevenueTextBox.Location = New System.Drawing.Point(113, 57)
        Me.RevenueTextBox.Name = "RevenueTextBox"
        Me.RevenueTextBox.ReadOnly = True
        Me.RevenueTextBox.Size = New System.Drawing.Size(100, 20)
        Me.RevenueTextBox.TabIndex = 3
        '
        'OKButton
        '
        Me.OKButton.Location = New System.Drawing.Point(78, 95)
        Me.OKButton.Name = "OKButton"
        Me.OKButton.Size = New System.Drawing.Size(75, 23)
        Me.OKButton.TabIndex = 4
        Me.OKButton.Text = "OK"
        Me.OKButton.UseVisualStyleBackColor = True
        '
        'SummaryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(232, 135)
        Me.Controls.Add(Me.OKButton)
        Me.Controls.Add(Me.RevenueTextBox)
        Me.Controls.Add(Me.EventsTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "SummaryForm"
        Me.Text = "Calloway Summary Statistics"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents EventsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RevenueTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OKButton As System.Windows.Forms.Button
End Class
