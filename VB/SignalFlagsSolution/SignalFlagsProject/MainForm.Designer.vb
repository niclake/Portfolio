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
        Me.SignInGroupBox = New System.Windows.Forms.GroupBox
        Me.SignInButton = New System.Windows.Forms.Button
        Me.CodeMaskedTextBox = New System.Windows.Forms.MaskedTextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.ABCGroupBox = New System.Windows.Forms.GroupBox
        Me.ZuluRadioButton = New System.Windows.Forms.RadioButton
        Me.TangoRadioButton = New System.Windows.Forms.RadioButton
        Me.PapaRadioButton = New System.Windows.Forms.RadioButton
        Me.IndiaRadioButton = New System.Windows.Forms.RadioButton
        Me.GolfRadioButton = New System.Windows.Forms.RadioButton
        Me.CharlieRadioButton = New System.Windows.Forms.RadioButton
        Me.FlagPictureBox = New System.Windows.Forms.PictureBox
        Me.ShowFlagCheckBox = New System.Windows.Forms.CheckBox
        Me.FlagNameLabel = New System.Windows.Forms.Label
        Me.FlagInstructionLabel = New System.Windows.Forms.Label
        Me.PrintButton = New System.Windows.Forms.Button
        Me.ExitButton = New System.Windows.Forms.Button
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label2 = New System.Windows.Forms.Label
        Me.SignInGroupBox.SuspendLayout()
        Me.ABCGroupBox.SuspendLayout()
        CType(Me.FlagPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SignInGroupBox
        '
        Me.SignInGroupBox.Controls.Add(Me.SignInButton)
        Me.SignInGroupBox.Controls.Add(Me.CodeMaskedTextBox)
        Me.SignInGroupBox.Controls.Add(Me.Label1)
        Me.SignInGroupBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SignInGroupBox.Location = New System.Drawing.Point(12, 12)
        Me.SignInGroupBox.Name = "SignInGroupBox"
        Me.SignInGroupBox.Size = New System.Drawing.Size(340, 54)
        Me.SignInGroupBox.TabIndex = 0
        Me.SignInGroupBox.TabStop = False
        Me.SignInGroupBox.Text = "Sign In Here:"
        '
        'SignInButton
        '
        Me.SignInButton.Location = New System.Drawing.Point(244, 15)
        Me.SignInButton.Name = "SignInButton"
        Me.SignInButton.Size = New System.Drawing.Size(75, 33)
        Me.SignInButton.TabIndex = 1
        Me.SignInButton.Text = "&Sign In"
        Me.ToolTip1.SetToolTip(Me.SignInButton, "Sign in")
        Me.SignInButton.UseVisualStyleBackColor = True
        '
        'CodeMaskedTextBox
        '
        Me.CodeMaskedTextBox.Location = New System.Drawing.Point(195, 15)
        Me.CodeMaskedTextBox.Mask = "00000"
        Me.CodeMaskedTextBox.Name = "CodeMaskedTextBox"
        Me.CodeMaskedTextBox.Size = New System.Drawing.Size(43, 22)
        Me.CodeMaskedTextBox.TabIndex = 0
        Me.CodeMaskedTextBox.ValidatingType = GetType(Integer)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(183, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter your authorization code:"
        '
        'ABCGroupBox
        '
        Me.ABCGroupBox.Controls.Add(Me.ZuluRadioButton)
        Me.ABCGroupBox.Controls.Add(Me.TangoRadioButton)
        Me.ABCGroupBox.Controls.Add(Me.PapaRadioButton)
        Me.ABCGroupBox.Controls.Add(Me.IndiaRadioButton)
        Me.ABCGroupBox.Controls.Add(Me.GolfRadioButton)
        Me.ABCGroupBox.Controls.Add(Me.CharlieRadioButton)
        Me.ABCGroupBox.Enabled = False
        Me.ABCGroupBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ABCGroupBox.Location = New System.Drawing.Point(12, 72)
        Me.ABCGroupBox.Name = "ABCGroupBox"
        Me.ABCGroupBox.Size = New System.Drawing.Size(154, 123)
        Me.ABCGroupBox.TabIndex = 1
        Me.ABCGroupBox.TabStop = False
        Me.ABCGroupBox.Text = "Alphabetic Character:"
        '
        'ZuluRadioButton
        '
        Me.ZuluRadioButton.AutoSize = True
        Me.ZuluRadioButton.Location = New System.Drawing.Point(50, 73)
        Me.ZuluRadioButton.Name = "ZuluRadioButton"
        Me.ZuluRadioButton.Size = New System.Drawing.Size(34, 20)
        Me.ZuluRadioButton.TabIndex = 5
        Me.ZuluRadioButton.TabStop = True
        Me.ZuluRadioButton.Text = "&Z"
        Me.ZuluRadioButton.UseVisualStyleBackColor = True
        '
        'TangoRadioButton
        '
        Me.TangoRadioButton.AutoSize = True
        Me.TangoRadioButton.Location = New System.Drawing.Point(50, 47)
        Me.TangoRadioButton.Name = "TangoRadioButton"
        Me.TangoRadioButton.Size = New System.Drawing.Size(35, 20)
        Me.TangoRadioButton.TabIndex = 4
        Me.TangoRadioButton.TabStop = True
        Me.TangoRadioButton.Text = "&T"
        Me.TangoRadioButton.UseVisualStyleBackColor = True
        '
        'PapaRadioButton
        '
        Me.PapaRadioButton.AutoSize = True
        Me.PapaRadioButton.Location = New System.Drawing.Point(50, 21)
        Me.PapaRadioButton.Name = "PapaRadioButton"
        Me.PapaRadioButton.Size = New System.Drawing.Size(35, 20)
        Me.PapaRadioButton.TabIndex = 3
        Me.PapaRadioButton.TabStop = True
        Me.PapaRadioButton.Text = "&P"
        Me.PapaRadioButton.UseVisualStyleBackColor = True
        '
        'IndiaRadioButton
        '
        Me.IndiaRadioButton.AutoSize = True
        Me.IndiaRadioButton.Location = New System.Drawing.Point(9, 73)
        Me.IndiaRadioButton.Name = "IndiaRadioButton"
        Me.IndiaRadioButton.Size = New System.Drawing.Size(29, 20)
        Me.IndiaRadioButton.TabIndex = 2
        Me.IndiaRadioButton.TabStop = True
        Me.IndiaRadioButton.Text = "&I"
        Me.IndiaRadioButton.UseVisualStyleBackColor = True
        '
        'GolfRadioButton
        '
        Me.GolfRadioButton.AutoSize = True
        Me.GolfRadioButton.Location = New System.Drawing.Point(9, 47)
        Me.GolfRadioButton.Name = "GolfRadioButton"
        Me.GolfRadioButton.Size = New System.Drawing.Size(36, 20)
        Me.GolfRadioButton.TabIndex = 1
        Me.GolfRadioButton.TabStop = True
        Me.GolfRadioButton.Text = "&G"
        Me.GolfRadioButton.UseVisualStyleBackColor = True
        '
        'CharlieRadioButton
        '
        Me.CharlieRadioButton.AutoSize = True
        Me.CharlieRadioButton.Location = New System.Drawing.Point(9, 21)
        Me.CharlieRadioButton.Name = "CharlieRadioButton"
        Me.CharlieRadioButton.Size = New System.Drawing.Size(35, 20)
        Me.CharlieRadioButton.TabIndex = 0
        Me.CharlieRadioButton.TabStop = True
        Me.CharlieRadioButton.Text = "&C"
        Me.CharlieRadioButton.UseVisualStyleBackColor = True
        '
        'FlagPictureBox
        '
        Me.FlagPictureBox.Location = New System.Drawing.Point(172, 88)
        Me.FlagPictureBox.Name = "FlagPictureBox"
        Me.FlagPictureBox.Size = New System.Drawing.Size(105, 105)
        Me.FlagPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.FlagPictureBox.TabIndex = 4
        Me.FlagPictureBox.TabStop = False
        '
        'ShowFlagCheckBox
        '
        Me.ShowFlagCheckBox.AutoSize = True
        Me.ShowFlagCheckBox.Checked = True
        Me.ShowFlagCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ShowFlagCheckBox.Location = New System.Drawing.Point(283, 126)
        Me.ShowFlagCheckBox.Name = "ShowFlagCheckBox"
        Me.ShowFlagCheckBox.Size = New System.Drawing.Size(76, 17)
        Me.ShowFlagCheckBox.TabIndex = 2
        Me.ShowFlagCheckBox.Text = "S&how Flag"
        Me.ToolTip1.SetToolTip(Me.ShowFlagCheckBox, "Click to toggle the flag")
        Me.ShowFlagCheckBox.UseVisualStyleBackColor = True
        Me.ShowFlagCheckBox.Visible = False
        '
        'FlagNameLabel
        '
        Me.FlagNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlagNameLabel.ForeColor = System.Drawing.Color.Black
        Me.FlagNameLabel.Location = New System.Drawing.Point(172, 196)
        Me.FlagNameLabel.Name = "FlagNameLabel"
        Me.FlagNameLabel.Size = New System.Drawing.Size(105, 20)
        Me.FlagNameLabel.TabIndex = 6
        Me.FlagNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FlagInstructionLabel
        '
        Me.FlagInstructionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlagInstructionLabel.ForeColor = System.Drawing.Color.Red
        Me.FlagInstructionLabel.Location = New System.Drawing.Point(12, 234)
        Me.FlagInstructionLabel.Name = "FlagInstructionLabel"
        Me.FlagInstructionLabel.Size = New System.Drawing.Size(340, 19)
        Me.FlagInstructionLabel.TabIndex = 7
        Me.FlagInstructionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PrintButton
        '
        Me.PrintButton.Location = New System.Drawing.Point(91, 273)
        Me.PrintButton.Name = "PrintButton"
        Me.PrintButton.Size = New System.Drawing.Size(75, 23)
        Me.PrintButton.TabIndex = 3
        Me.PrintButton.Text = "P&rint"
        Me.ToolTip1.SetToolTip(Me.PrintButton, "Print the form")
        Me.PrintButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ExitButton.Location = New System.Drawing.Point(196, 273)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(75, 23)
        Me.ExitButton.TabIndex = 4
        Me.ExitButton.Text = "E&xit"
        Me.ToolTip1.SetToolTip(Me.ExitButton, "Close and exit the program")
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(226, 324)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(130, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Programmed By: Nic Lake"
        '
        'MainForm
        '
        Me.AcceptButton = Me.SignInButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.ExitButton
        Me.ClientSize = New System.Drawing.Size(364, 347)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.PrintButton)
        Me.Controls.Add(Me.FlagInstructionLabel)
        Me.Controls.Add(Me.FlagNameLabel)
        Me.Controls.Add(Me.ShowFlagCheckBox)
        Me.Controls.Add(Me.FlagPictureBox)
        Me.Controls.Add(Me.ABCGroupBox)
        Me.Controls.Add(Me.SignInGroupBox)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Navy Signal Flags"
        Me.SignInGroupBox.ResumeLayout(False)
        Me.SignInGroupBox.PerformLayout()
        Me.ABCGroupBox.ResumeLayout(False)
        Me.ABCGroupBox.PerformLayout()
        CType(Me.FlagPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SignInGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents SignInButton As System.Windows.Forms.Button
    Friend WithEvents CodeMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ABCGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents FlagPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents ShowFlagCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents CharlieRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents ZuluRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents TangoRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents PapaRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents IndiaRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents GolfRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents FlagNameLabel As System.Windows.Forms.Label
    Friend WithEvents FlagInstructionLabel As System.Windows.Forms.Label
    Friend WithEvents PrintButton As System.Windows.Forms.Button
    Friend WithEvents ExitButton As System.Windows.Forms.Button
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
