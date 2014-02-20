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
        Me.NameLabel = New System.Windows.Forms.Label
        Me.DowntownButton = New System.Windows.Forms.Button
        Me.MallButton = New System.Windows.Forms.Button
        Me.SuburbsButton = New System.Windows.Forms.Button
        Me.PrintButton = New System.Windows.Forms.Button
        Me.ExitButton = New System.Windows.Forms.Button
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.AddressLabel = New System.Windows.Forms.Label
        Me.HeaderLabel = New System.Windows.Forms.Label
        Me.HoursLabel = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Location = New System.Drawing.Point(351, 397)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(50, 13)
        Me.NameLabel.TabIndex = 0
        Me.NameLabel.Text = "Nic Lake"
        '
        'DowntownButton
        '
        Me.DowntownButton.BackColor = System.Drawing.Color.Transparent
        Me.DowntownButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DowntownButton.Location = New System.Drawing.Point(35, 100)
        Me.DowntownButton.Name = "DowntownButton"
        Me.DowntownButton.Size = New System.Drawing.Size(87, 23)
        Me.DowntownButton.TabIndex = 1
        Me.DowntownButton.Text = "Downtown"
        Me.DowntownButton.UseVisualStyleBackColor = False
        '
        'MallButton
        '
        Me.MallButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MallButton.Location = New System.Drawing.Point(35, 150)
        Me.MallButton.Name = "MallButton"
        Me.MallButton.Size = New System.Drawing.Size(87, 23)
        Me.MallButton.TabIndex = 2
        Me.MallButton.Text = "Mall"
        Me.MallButton.UseVisualStyleBackColor = True
        '
        'SuburbsButton
        '
        Me.SuburbsButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SuburbsButton.Location = New System.Drawing.Point(35, 200)
        Me.SuburbsButton.Name = "SuburbsButton"
        Me.SuburbsButton.Size = New System.Drawing.Size(87, 23)
        Me.SuburbsButton.TabIndex = 3
        Me.SuburbsButton.Text = "Suburbs"
        Me.SuburbsButton.UseVisualStyleBackColor = True
        '
        'PrintButton
        '
        Me.PrintButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrintButton.Location = New System.Drawing.Point(35, 350)
        Me.PrintButton.Name = "PrintButton"
        Me.PrintButton.Size = New System.Drawing.Size(87, 23)
        Me.PrintButton.TabIndex = 4
        Me.PrintButton.Text = "Print"
        Me.PrintButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitButton.Location = New System.Drawing.Point(150, 350)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(84, 23)
        Me.ExitButton.TabIndex = 5
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'AddressLabel
        '
        Me.AddressLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddressLabel.Location = New System.Drawing.Point(150, 100)
        Me.AddressLabel.Name = "AddressLabel"
        Me.AddressLabel.Size = New System.Drawing.Size(221, 73)
        Me.AddressLabel.TabIndex = 6
        Me.AddressLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'HeaderLabel
        '
        Me.HeaderLabel.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.HeaderLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.HeaderLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HeaderLabel.Location = New System.Drawing.Point(32, 24)
        Me.HeaderLabel.Name = "HeaderLabel"
        Me.HeaderLabel.Size = New System.Drawing.Size(339, 53)
        Me.HeaderLabel.TabIndex = 7
        Me.HeaderLabel.Text = "Click on the buttons below to display the address of the store."
        Me.HeaderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'HoursLabel
        '
        Me.HoursLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HoursLabel.Location = New System.Drawing.Point(150, 200)
        Me.HoursLabel.Name = "HoursLabel"
        Me.HoursLabel.Size = New System.Drawing.Size(221, 115)
        Me.HoursLabel.TabIndex = 8
        Me.HoursLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.BurlyWood
        Me.ClientSize = New System.Drawing.Size(405, 414)
        Me.Controls.Add(Me.HoursLabel)
        Me.Controls.Add(Me.HeaderLabel)
        Me.Controls.Add(Me.AddressLabel)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.PrintButton)
        Me.Controls.Add(Me.SuburbsButton)
        Me.Controls.Add(Me.MallButton)
        Me.Controls.Add(Me.DowntownButton)
        Me.Controls.Add(Me.NameLabel)
        Me.Name = "MainForm"
        Me.Text = "Very Very Boards"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents NameLabel As System.Windows.Forms.Label
    Friend WithEvents DowntownButton As System.Windows.Forms.Button
    Friend WithEvents MallButton As System.Windows.Forms.Button
    Friend WithEvents SuburbsButton As System.Windows.Forms.Button
    Friend WithEvents PrintButton As System.Windows.Forms.Button
    Friend WithEvents ExitButton As System.Windows.Forms.Button
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents AddressLabel As System.Windows.Forms.Label
    Friend WithEvents HeaderLabel As System.Windows.Forms.Label
    Friend WithEvents HoursLabel As System.Windows.Forms.Label

End Class
