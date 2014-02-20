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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.CheerLabel = New System.Windows.Forms.Label
        Me.UNIButton = New System.Windows.Forms.Button
        Me.ISUButton = New System.Windows.Forms.Button
        Me.IowaButton = New System.Windows.Forms.Button
        Me.ExitButton = New System.Windows.Forms.Button
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.PrintButton = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'CheerLabel
        '
        Me.CheerLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CheerLabel.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheerLabel.Location = New System.Drawing.Point(12, 38)
        Me.CheerLabel.Name = "CheerLabel"
        Me.CheerLabel.Size = New System.Drawing.Size(317, 39)
        Me.CheerLabel.TabIndex = 0
        Me.CheerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'UNIButton
        '
        Me.UNIButton.BackColor = System.Drawing.Color.Silver
        Me.UNIButton.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UNIButton.Location = New System.Drawing.Point(35, 136)
        Me.UNIButton.Name = "UNIButton"
        Me.UNIButton.Size = New System.Drawing.Size(75, 23)
        Me.UNIButton.TabIndex = 1
        Me.UNIButton.Text = "UNI"
        Me.UNIButton.UseVisualStyleBackColor = False
        '
        'ISUButton
        '
        Me.ISUButton.BackColor = System.Drawing.Color.Silver
        Me.ISUButton.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ISUButton.Location = New System.Drawing.Point(133, 136)
        Me.ISUButton.Name = "ISUButton"
        Me.ISUButton.Size = New System.Drawing.Size(75, 23)
        Me.ISUButton.TabIndex = 2
        Me.ISUButton.Text = "ISU"
        Me.ISUButton.UseVisualStyleBackColor = False
        '
        'IowaButton
        '
        Me.IowaButton.BackColor = System.Drawing.Color.Silver
        Me.IowaButton.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IowaButton.Location = New System.Drawing.Point(234, 136)
        Me.IowaButton.Name = "IowaButton"
        Me.IowaButton.Size = New System.Drawing.Size(75, 23)
        Me.IowaButton.TabIndex = 3
        Me.IowaButton.Text = "Iowa"
        Me.IowaButton.UseVisualStyleBackColor = False
        '
        'ExitButton
        '
        Me.ExitButton.BackColor = System.Drawing.Color.Silver
        Me.ExitButton.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitButton.Location = New System.Drawing.Point(234, 279)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(75, 23)
        Me.ExitButton.TabIndex = 4
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = False
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'PrintButton
        '
        Me.PrintButton.BackColor = System.Drawing.Color.Silver
        Me.PrintButton.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrintButton.Location = New System.Drawing.Point(133, 279)
        Me.PrintButton.Name = "PrintButton"
        Me.PrintButton.Size = New System.Drawing.Size(75, 23)
        Me.PrintButton.TabIndex = 5
        Me.PrintButton.Text = "Print"
        Me.PrintButton.UseVisualStyleBackColor = False
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSlateGray
        Me.ClientSize = New System.Drawing.Size(341, 336)
        Me.Controls.Add(Me.PrintButton)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.IowaButton)
        Me.Controls.Add(Me.ISUButton)
        Me.Controls.Add(Me.UNIButton)
        Me.Controls.Add(Me.CheerLabel)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Campus Cheers"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CheerLabel As System.Windows.Forms.Label
    Friend WithEvents UNIButton As System.Windows.Forms.Button
    Friend WithEvents ISUButton As System.Windows.Forms.Button
    Friend WithEvents IowaButton As System.Windows.Forms.Button
    Friend WithEvents ExitButton As System.Windows.Forms.Button
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents PrintButton As System.Windows.Forms.Button

End Class
