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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.PreferredRadioButton = New System.Windows.Forms.RadioButton
        Me.StdRadioButton = New System.Windows.Forms.RadioButton
        Me.SpecialRadioButton = New System.Windows.Forms.RadioButton
        Me.QuantityTextBox = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.FindButton = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.DiscountTextBox = New System.Windows.Forms.TextBox
        Me.ClearButton = New System.Windows.Forms.Button
        Me.ExitButton = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.PrintButton = New System.Windows.Forms.Button
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DisplayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DiscountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.StyleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FormBackcolorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FormFontToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TitleFontToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog
        Me.FontDialog1 = New System.Windows.Forms.FontDialog
        Me.MainFormContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ClearToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.PrintToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.ExitToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.MainFormContextMenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PreferredRadioButton)
        Me.GroupBox1.Controls.Add(Me.StdRadioButton)
        Me.GroupBox1.Controls.Add(Me.SpecialRadioButton)
        Me.GroupBox1.Location = New System.Drawing.Point(30, 83)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(128, 103)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Customer Type:"
        '
        'PreferredRadioButton
        '
        Me.PreferredRadioButton.AutoSize = True
        Me.PreferredRadioButton.Location = New System.Drawing.Point(30, 70)
        Me.PreferredRadioButton.Margin = New System.Windows.Forms.Padding(2)
        Me.PreferredRadioButton.Name = "PreferredRadioButton"
        Me.PreferredRadioButton.Size = New System.Drawing.Size(68, 17)
        Me.PreferredRadioButton.TabIndex = 2
        Me.PreferredRadioButton.Text = "Preferred"
        Me.PreferredRadioButton.UseVisualStyleBackColor = True
        '
        'StdRadioButton
        '
        Me.StdRadioButton.AutoSize = True
        Me.StdRadioButton.Location = New System.Drawing.Point(30, 26)
        Me.StdRadioButton.Margin = New System.Windows.Forms.Padding(2)
        Me.StdRadioButton.Name = "StdRadioButton"
        Me.StdRadioButton.Size = New System.Drawing.Size(68, 17)
        Me.StdRadioButton.TabIndex = 0
        Me.StdRadioButton.Text = "Standard"
        Me.StdRadioButton.UseVisualStyleBackColor = True
        '
        'SpecialRadioButton
        '
        Me.SpecialRadioButton.AutoSize = True
        Me.SpecialRadioButton.Location = New System.Drawing.Point(30, 48)
        Me.SpecialRadioButton.Margin = New System.Windows.Forms.Padding(2)
        Me.SpecialRadioButton.Name = "SpecialRadioButton"
        Me.SpecialRadioButton.Size = New System.Drawing.Size(60, 17)
        Me.SpecialRadioButton.TabIndex = 1
        Me.SpecialRadioButton.Text = "Special"
        Me.SpecialRadioButton.UseVisualStyleBackColor = True
        '
        'QuantityTextBox
        '
        Me.QuantityTextBox.Location = New System.Drawing.Point(131, 210)
        Me.QuantityTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.QuantityTextBox.Name = "QuantityTextBox"
        Me.QuantityTextBox.Size = New System.Drawing.Size(48, 20)
        Me.QuantityTextBox.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(37, 213)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Quantity ordered:"
        '
        'FindButton
        '
        Me.FindButton.Location = New System.Drawing.Point(40, 247)
        Me.FindButton.Margin = New System.Windows.Forms.Padding(2)
        Me.FindButton.Name = "FindButton"
        Me.FindButton.Size = New System.Drawing.Size(151, 26)
        Me.FindButton.TabIndex = 3
        Me.FindButton.Text = "Find Discount"
        Me.FindButton.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(37, 294)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Discount:"
        '
        'DiscountTextBox
        '
        Me.DiscountTextBox.Location = New System.Drawing.Point(131, 294)
        Me.DiscountTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.DiscountTextBox.Name = "DiscountTextBox"
        Me.DiscountTextBox.ReadOnly = True
        Me.DiscountTextBox.Size = New System.Drawing.Size(48, 20)
        Me.DiscountTextBox.TabIndex = 9
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(22, 331)
        Me.ClearButton.Margin = New System.Windows.Forms.Padding(2)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(56, 25)
        Me.ClearButton.TabIndex = 4
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(144, 331)
        Me.ExitButton.Margin = New System.Windows.Forms.Padding(2)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(56, 25)
        Me.ExitButton.TabIndex = 6
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(37, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Discount Finder"
        '
        'PrintButton
        '
        Me.PrintButton.Location = New System.Drawing.Point(83, 332)
        Me.PrintButton.Name = "PrintButton"
        Me.PrintButton.Size = New System.Drawing.Size(56, 23)
        Me.PrintButton.TabIndex = 5
        Me.PrintButton.Text = "Print"
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
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.DisplayToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(217, 24)
        Me.MenuStrip1.TabIndex = 10
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrintToolStripMenuItem, Me.ToolStripSeparator1, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(35, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'PrintToolStripMenuItem
        '
        Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        Me.PrintToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PrintToolStripMenuItem.Text = "&Print"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(149, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'DisplayToolStripMenuItem
        '
        Me.DisplayToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DiscountToolStripMenuItem, Me.ClearToolStripMenuItem, Me.ToolStripSeparator2, Me.StyleToolStripMenuItem})
        Me.DisplayToolStripMenuItem.Name = "DisplayToolStripMenuItem"
        Me.DisplayToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.DisplayToolStripMenuItem.Text = "&Display"
        '
        'DiscountToolStripMenuItem
        '
        Me.DiscountToolStripMenuItem.Name = "DiscountToolStripMenuItem"
        Me.DiscountToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.DiscountToolStripMenuItem.Text = "Discount"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ClearToolStripMenuItem.Text = "Clear"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(149, 6)
        '
        'StyleToolStripMenuItem
        '
        Me.StyleToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FormBackcolorToolStripMenuItem, Me.FormFontToolStripMenuItem, Me.TitleFontToolStripMenuItem})
        Me.StyleToolStripMenuItem.Name = "StyleToolStripMenuItem"
        Me.StyleToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.StyleToolStripMenuItem.Text = "Style"
        '
        'FormBackcolorToolStripMenuItem
        '
        Me.FormBackcolorToolStripMenuItem.Name = "FormBackcolorToolStripMenuItem"
        Me.FormBackcolorToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.FormBackcolorToolStripMenuItem.Text = "Form Backcolor..."
        '
        'FormFontToolStripMenuItem
        '
        Me.FormFontToolStripMenuItem.Name = "FormFontToolStripMenuItem"
        Me.FormFontToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.FormFontToolStripMenuItem.Text = "Form Font Color..."
        '
        'TitleFontToolStripMenuItem
        '
        Me.TitleFontToolStripMenuItem.Name = "TitleFontToolStripMenuItem"
        Me.TitleFontToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.TitleFontToolStripMenuItem.Text = "Title Font..."
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(47, 20)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'MainFormContextMenuStrip
        '
        Me.MainFormContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClearToolStripMenuItem1, Me.ToolStripSeparator3, Me.PrintToolStripMenuItem1, Me.ToolStripSeparator4, Me.ExitToolStripMenuItem1})
        Me.MainFormContextMenuStrip.Name = "MainFormContextMenuStrip"
        Me.MainFormContextMenuStrip.Size = New System.Drawing.Size(102, 82)
        '
        'ClearToolStripMenuItem1
        '
        Me.ClearToolStripMenuItem1.Name = "ClearToolStripMenuItem1"
        Me.ClearToolStripMenuItem1.Size = New System.Drawing.Size(101, 22)
        Me.ClearToolStripMenuItem1.Text = "Clear"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(98, 6)
        '
        'PrintToolStripMenuItem1
        '
        Me.PrintToolStripMenuItem1.Name = "PrintToolStripMenuItem1"
        Me.PrintToolStripMenuItem1.Size = New System.Drawing.Size(101, 22)
        Me.PrintToolStripMenuItem1.Text = "Print"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(98, 6)
        '
        'ExitToolStripMenuItem1
        '
        Me.ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1"
        Me.ExitToolStripMenuItem1.Size = New System.Drawing.Size(101, 22)
        Me.ExitToolStripMenuItem1.Text = "Exit"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(217, 376)
        Me.ContextMenuStrip = Me.MainFormContextMenuStrip
        Me.Controls.Add(Me.PrintButton)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.DiscountTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.FindButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.QuantityTextBox)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "MainForm"
        Me.Text = "Nested If Example"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.MainFormContextMenuStrip.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents PreferredRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents StdRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents SpecialRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents QuantityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents FindButton As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DiscountTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ClearButton As System.Windows.Forms.Button
    Friend WithEvents ExitButton As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PrintButton As System.Windows.Forms.Button
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DisplayToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DiscountToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents StyleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FormBackcolorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FormFontToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TitleFontToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents FontDialog1 As System.Windows.Forms.FontDialog
    Friend WithEvents MainFormContextMenuStrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ClearToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PrintToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem

End Class
