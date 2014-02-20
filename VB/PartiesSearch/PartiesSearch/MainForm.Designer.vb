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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.NumberTextBox = New System.Windows.Forms.TextBox
        Me.NameTextBox = New System.Windows.Forms.TextBox
        Me.PrepTextBox = New System.Windows.Forms.TextBox
        Me.ServingsTextBox = New System.Windows.Forms.TextBox
        Me.CategoryComboBox = New System.Windows.Forms.ComboBox
        Me.GroupComboBox = New System.Windows.Forms.ComboBox
        Me.RecipeListBox = New System.Windows.Forms.ListBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.NameButton = New System.Windows.Forms.Button
        Me.NumberButton = New System.Windows.Forms.Button
        Me.CategoryButton = New System.Windows.Forms.Button
        Me.GroupButton = New System.Windows.Forms.Button
        Me.GroupPrepButton = New System.Windows.Forms.Button
        Me.GroupServingsButton = New System.Windows.Forms.Button
        Me.VegButton = New System.Windows.Forms.Button
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.ClearButton = New System.Windows.Forms.Button
        Me.VeganComboBox = New System.Windows.Forms.ComboBox
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(658, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem, Me.ToolStripSeparator1, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.OpenToolStripMenuItem.Text = "&Open"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(100, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Recipie Number:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(55, 193)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Vegetarian:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(19, 167)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Prep Time (mins):"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(68, 141)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 16)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Servings:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(51, 114)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 16)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Meal Group:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(31, 87)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(101, 16)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Food Category:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(34, 61)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(98, 16)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Recipie Name:"
        '
        'NumberTextBox
        '
        Me.NumberTextBox.Location = New System.Drawing.Point(138, 34)
        Me.NumberTextBox.Name = "NumberTextBox"
        Me.NumberTextBox.Size = New System.Drawing.Size(42, 20)
        Me.NumberTextBox.TabIndex = 8
        '
        'NameTextBox
        '
        Me.NameTextBox.Location = New System.Drawing.Point(138, 60)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(224, 20)
        Me.NameTextBox.TabIndex = 9
        '
        'PrepTextBox
        '
        Me.PrepTextBox.Location = New System.Drawing.Point(138, 166)
        Me.PrepTextBox.Name = "PrepTextBox"
        Me.PrepTextBox.Size = New System.Drawing.Size(42, 20)
        Me.PrepTextBox.TabIndex = 11
        '
        'ServingsTextBox
        '
        Me.ServingsTextBox.Location = New System.Drawing.Point(138, 140)
        Me.ServingsTextBox.Name = "ServingsTextBox"
        Me.ServingsTextBox.Size = New System.Drawing.Size(42, 20)
        Me.ServingsTextBox.TabIndex = 12
        '
        'CategoryComboBox
        '
        Me.CategoryComboBox.FormattingEnabled = True
        Me.CategoryComboBox.Items.AddRange(New Object() {"Beef", "Fish", "Poultry", "Vegetables and Legumes", "Hot and Cold Appetizers", "Salads and Dressings", "Soups", "Sandwiches", "Eggs and Omelets", "Cakes and Pastries", "Pies and Tarts", "Cookies", "Breads and Baked Goods", "Sauces and Dips"})
        Me.CategoryComboBox.Location = New System.Drawing.Point(138, 86)
        Me.CategoryComboBox.Name = "CategoryComboBox"
        Me.CategoryComboBox.Size = New System.Drawing.Size(181, 21)
        Me.CategoryComboBox.TabIndex = 14
        '
        'GroupComboBox
        '
        Me.GroupComboBox.FormattingEnabled = True
        Me.GroupComboBox.Items.AddRange(New Object() {"Appetizer", "Breakfast", "Brunch", "Dinner", "Lunch"})
        Me.GroupComboBox.Location = New System.Drawing.Point(138, 113)
        Me.GroupComboBox.Name = "GroupComboBox"
        Me.GroupComboBox.Size = New System.Drawing.Size(121, 21)
        Me.GroupComboBox.TabIndex = 15
        '
        'RecipeListBox
        '
        Me.RecipeListBox.FormattingEnabled = True
        Me.RecipeListBox.Location = New System.Drawing.Point(385, 60)
        Me.RecipeListBox.Name = "RecipeListBox"
        Me.RecipeListBox.Size = New System.Drawing.Size(242, 147)
        Me.RecipeListBox.TabIndex = 16
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(382, 37)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(179, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Click on a recipe to display its details"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(60, 267)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 16)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Search by:"
        '
        'NameButton
        '
        Me.NameButton.Location = New System.Drawing.Point(138, 250)
        Me.NameButton.Name = "NameButton"
        Me.NameButton.Size = New System.Drawing.Size(110, 23)
        Me.NameButton.TabIndex = 19
        Me.NameButton.Text = "Recipe Name"
        Me.NameButton.UseVisualStyleBackColor = True
        '
        'NumberButton
        '
        Me.NumberButton.Location = New System.Drawing.Point(138, 223)
        Me.NumberButton.Name = "NumberButton"
        Me.NumberButton.Size = New System.Drawing.Size(110, 23)
        Me.NumberButton.TabIndex = 20
        Me.NumberButton.Text = "Recipe Number"
        Me.NumberButton.UseVisualStyleBackColor = True
        '
        'CategoryButton
        '
        Me.CategoryButton.Location = New System.Drawing.Point(138, 277)
        Me.CategoryButton.Name = "CategoryButton"
        Me.CategoryButton.Size = New System.Drawing.Size(110, 23)
        Me.CategoryButton.TabIndex = 21
        Me.CategoryButton.Text = "Food Category"
        Me.CategoryButton.UseVisualStyleBackColor = True
        '
        'GroupButton
        '
        Me.GroupButton.Location = New System.Drawing.Point(138, 304)
        Me.GroupButton.Name = "GroupButton"
        Me.GroupButton.Size = New System.Drawing.Size(110, 23)
        Me.GroupButton.TabIndex = 22
        Me.GroupButton.Text = "Meal Group"
        Me.GroupButton.UseVisualStyleBackColor = True
        '
        'GroupPrepButton
        '
        Me.GroupPrepButton.Location = New System.Drawing.Point(252, 250)
        Me.GroupPrepButton.Name = "GroupPrepButton"
        Me.GroupPrepButton.Size = New System.Drawing.Size(110, 23)
        Me.GroupPrepButton.TabIndex = 23
        Me.GroupPrepButton.Text = "Group and Prep"
        Me.GroupPrepButton.UseVisualStyleBackColor = True
        '
        'GroupServingsButton
        '
        Me.GroupServingsButton.Location = New System.Drawing.Point(252, 223)
        Me.GroupServingsButton.Name = "GroupServingsButton"
        Me.GroupServingsButton.Size = New System.Drawing.Size(110, 23)
        Me.GroupServingsButton.TabIndex = 24
        Me.GroupServingsButton.Text = "Group and Servings"
        Me.GroupServingsButton.UseVisualStyleBackColor = True
        '
        'VegButton
        '
        Me.VegButton.Location = New System.Drawing.Point(252, 277)
        Me.VegButton.Name = "VegButton"
        Me.VegButton.Size = New System.Drawing.Size(110, 23)
        Me.VegButton.TabIndex = 25
        Me.VegButton.Text = "Group and Vegan"
        Me.VegButton.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(252, 304)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(110, 23)
        Me.ClearButton.TabIndex = 26
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'VeganComboBox
        '
        Me.VeganComboBox.FormattingEnabled = True
        Me.VeganComboBox.Items.AddRange(New Object() {"True", "False"})
        Me.VeganComboBox.Location = New System.Drawing.Point(138, 192)
        Me.VeganComboBox.Name = "VeganComboBox"
        Me.VeganComboBox.Size = New System.Drawing.Size(74, 21)
        Me.VeganComboBox.TabIndex = 27
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(658, 341)
        Me.Controls.Add(Me.VeganComboBox)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.VegButton)
        Me.Controls.Add(Me.GroupServingsButton)
        Me.Controls.Add(Me.GroupPrepButton)
        Me.Controls.Add(Me.GroupButton)
        Me.Controls.Add(Me.CategoryButton)
        Me.Controls.Add(Me.NumberButton)
        Me.Controls.Add(Me.NameButton)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.RecipeListBox)
        Me.Controls.Add(Me.GroupComboBox)
        Me.Controls.Add(Me.CategoryComboBox)
        Me.Controls.Add(Me.ServingsTextBox)
        Me.Controls.Add(Me.PrepTextBox)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(Me.NumberTextBox)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MainForm"
        Me.Text = "Parties, Etc. Recipe Search"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents NumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PrepTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ServingsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CategoryComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents GroupComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents RecipeListBox As System.Windows.Forms.ListBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents NameButton As System.Windows.Forms.Button
    Friend WithEvents NumberButton As System.Windows.Forms.Button
    Friend WithEvents CategoryButton As System.Windows.Forms.Button
    Friend WithEvents GroupButton As System.Windows.Forms.Button
    Friend WithEvents GroupPrepButton As System.Windows.Forms.Button
    Friend WithEvents GroupServingsButton As System.Windows.Forms.Button
    Friend WithEvents VegButton As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ClearButton As System.Windows.Forms.Button
    Friend WithEvents VeganComboBox As System.Windows.Forms.ComboBox

End Class
