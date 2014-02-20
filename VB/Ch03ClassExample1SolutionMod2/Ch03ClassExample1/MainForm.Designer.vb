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
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.PriceTextBox = New System.Windows.Forms.TextBox
        Me.DiscountPercentTextBox = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.ComputeButton = New System.Windows.Forms.Button
        Me.ClearButton = New System.Windows.Forms.Button
        Me.ExitButton = New System.Windows.Forms.Button
        Me.PrintButton = New System.Windows.Forms.Button
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.SalePriceTextBox = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.SummaryGroupBox = New System.Windows.Forms.GroupBox
        Me.AvgDiscTextBox = New System.Windows.Forms.TextBox
        Me.ItemSumTextBox = New System.Windows.Forms.TextBox
        Me.ClearAllButton = New System.Windows.Forms.Button
        Me.SummaryGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(57, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Item &price:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(7, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "&Discount percent:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(247, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(20, 16)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "%"
        '
        'PriceTextBox
        '
        Me.PriceTextBox.Location = New System.Drawing.Point(155, 47)
        Me.PriceTextBox.Name = "PriceTextBox"
        Me.PriceTextBox.Size = New System.Drawing.Size(81, 23)
        Me.PriceTextBox.TabIndex = 1
        '
        'DiscountPercentTextBox
        '
        Me.DiscountPercentTextBox.Location = New System.Drawing.Point(155, 73)
        Me.DiscountPercentTextBox.Name = "DiscountPercentTextBox"
        Me.DiscountPercentTextBox.Size = New System.Drawing.Size(81, 23)
        Me.DiscountPercentTextBox.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label4.Location = New System.Drawing.Point(12, 116)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(318, 10)
        Me.Label4.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label5.Location = New System.Drawing.Point(12, 196)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(318, 10)
        Me.Label5.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(61, 155)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 16)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Sale price:"
        '
        'ComputeButton
        '
        Me.ComputeButton.Location = New System.Drawing.Point(5, 363)
        Me.ComputeButton.Name = "ComputeButton"
        Me.ComputeButton.Size = New System.Drawing.Size(84, 28)
        Me.ComputeButton.TabIndex = 4
        Me.ComputeButton.Text = "&Compute"
        Me.ComputeButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ClearButton.Location = New System.Drawing.Point(95, 363)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(75, 28)
        Me.ClearButton.TabIndex = 5
        Me.ClearButton.Text = "C&lear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(257, 363)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(75, 28)
        Me.ExitButton.TabIndex = 7
        Me.ExitButton.Text = "E&xit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'PrintButton
        '
        Me.PrintButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.PrintButton.Location = New System.Drawing.Point(176, 363)
        Me.PrintButton.Name = "PrintButton"
        Me.PrintButton.Size = New System.Drawing.Size(75, 28)
        Me.PrintButton.TabIndex = 6
        Me.PrintButton.Text = "P&rint"
        Me.PrintButton.UseVisualStyleBackColor = True
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'SalePriceTextBox
        '
        Me.SalePriceTextBox.BackColor = System.Drawing.SystemColors.Control
        Me.SalePriceTextBox.Location = New System.Drawing.Point(155, 149)
        Me.SalePriceTextBox.Name = "SalePriceTextBox"
        Me.SalePriceTextBox.ReadOnly = True
        Me.SalePriceTextBox.Size = New System.Drawing.Size(81, 23)
        Me.SalePriceTextBox.TabIndex = 11
        Me.SalePriceTextBox.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 41)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(108, 16)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Number of items:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 76)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(158, 16)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Average discount percent:"
        '
        'SummaryGroupBox
        '
        Me.SummaryGroupBox.Controls.Add(Me.AvgDiscTextBox)
        Me.SummaryGroupBox.Controls.Add(Me.ItemSumTextBox)
        Me.SummaryGroupBox.Controls.Add(Me.Label8)
        Me.SummaryGroupBox.Controls.Add(Me.Label7)
        Me.SummaryGroupBox.Location = New System.Drawing.Point(23, 209)
        Me.SummaryGroupBox.Name = "SummaryGroupBox"
        Me.SummaryGroupBox.Size = New System.Drawing.Size(294, 116)
        Me.SummaryGroupBox.TabIndex = 14
        Me.SummaryGroupBox.TabStop = False
        Me.SummaryGroupBox.Text = "Summary:"
        '
        'AvgDiscTextBox
        '
        Me.AvgDiscTextBox.BackColor = System.Drawing.SystemColors.Control
        Me.AvgDiscTextBox.Location = New System.Drawing.Point(217, 71)
        Me.AvgDiscTextBox.Name = "AvgDiscTextBox"
        Me.AvgDiscTextBox.ReadOnly = True
        Me.AvgDiscTextBox.Size = New System.Drawing.Size(71, 23)
        Me.AvgDiscTextBox.TabIndex = 14
        Me.AvgDiscTextBox.TabStop = False
        '
        'ItemSumTextBox
        '
        Me.ItemSumTextBox.BackColor = System.Drawing.SystemColors.Control
        Me.ItemSumTextBox.Location = New System.Drawing.Point(217, 38)
        Me.ItemSumTextBox.Name = "ItemSumTextBox"
        Me.ItemSumTextBox.ReadOnly = True
        Me.ItemSumTextBox.Size = New System.Drawing.Size(71, 23)
        Me.ItemSumTextBox.TabIndex = 14
        Me.ItemSumTextBox.TabStop = False
        '
        'ClearAllButton
        '
        Me.ClearAllButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ClearAllButton.Location = New System.Drawing.Point(135, 329)
        Me.ClearAllButton.Name = "ClearAllButton"
        Me.ClearAllButton.Size = New System.Drawing.Size(75, 28)
        Me.ClearAllButton.TabIndex = 15
        Me.ClearAllButton.Text = "Clear &All"
        Me.ClearAllButton.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AcceptButton = Me.ComputeButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.ClearButton
        Me.ClientSize = New System.Drawing.Size(341, 403)
        Me.Controls.Add(Me.ClearAllButton)
        Me.Controls.Add(Me.SummaryGroupBox)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.PrintButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.ComputeButton)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.SalePriceTextBox)
        Me.Controls.Add(Me.DiscountPercentTextBox)
        Me.Controls.Add(Me.PriceTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "MainForm"
        Me.Text = "Sale Price Calculator"
        Me.SummaryGroupBox.ResumeLayout(False)
        Me.SummaryGroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PriceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DiscountPercentTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ComputeButton As System.Windows.Forms.Button
    Friend WithEvents ClearButton As System.Windows.Forms.Button
    Friend WithEvents ExitButton As System.Windows.Forms.Button
    Friend WithEvents PrintButton As System.Windows.Forms.Button
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents SalePriceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SummaryGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents AvgDiscTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ItemSumTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ClearAllButton As System.Windows.Forms.Button

End Class
