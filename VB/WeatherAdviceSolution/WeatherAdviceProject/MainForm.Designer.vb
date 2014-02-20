<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WeatherForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WeatherForm))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.NameTextBox = New System.Windows.Forms.TextBox
        Me.ExitButton = New System.Windows.Forms.Button
        Me.PrintButton = New System.Windows.Forms.Button
        Me.WeatherGroupBox = New System.Windows.Forms.GroupBox
        Me.CloudyRadioButton = New System.Windows.Forms.RadioButton
        Me.RainyRadioButton = New System.Windows.Forms.RadioButton
        Me.SnowyRadioButton = New System.Windows.Forms.RadioButton
        Me.SunnyRadioButton = New System.Windows.Forms.RadioButton
        Me.SunnyPictureBox = New System.Windows.Forms.PictureBox
        Me.RainyPictureBox = New System.Windows.Forms.PictureBox
        Me.CloudyPictureBox = New System.Windows.Forms.PictureBox
        Me.SnowyPictureBox = New System.Windows.Forms.PictureBox
        Me.MessageLabel = New System.Windows.Forms.Label
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.ResetButton = New System.Windows.Forms.Button
        Me.WeatherGroupBox.SuspendLayout()
        CType(Me.SunnyPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RainyPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CloudyPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SnowyPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(212, 327)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Programmed by: Nic Lake"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 23)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(146, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Enter your name:"
        '
        'NameTextBox
        '
        Me.NameTextBox.Location = New System.Drawing.Point(169, 23)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(172, 22)
        Me.NameTextBox.TabIndex = 2
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(266, 295)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(75, 23)
        Me.ExitButton.TabIndex = 3
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'PrintButton
        '
        Me.PrintButton.Location = New System.Drawing.Point(266, 266)
        Me.PrintButton.Name = "PrintButton"
        Me.PrintButton.Size = New System.Drawing.Size(75, 23)
        Me.PrintButton.TabIndex = 4
        Me.PrintButton.Text = "Print"
        Me.PrintButton.UseVisualStyleBackColor = True
        '
        'WeatherGroupBox
        '
        Me.WeatherGroupBox.Controls.Add(Me.CloudyRadioButton)
        Me.WeatherGroupBox.Controls.Add(Me.RainyRadioButton)
        Me.WeatherGroupBox.Controls.Add(Me.SnowyRadioButton)
        Me.WeatherGroupBox.Controls.Add(Me.SunnyRadioButton)
        Me.WeatherGroupBox.Location = New System.Drawing.Point(14, 64)
        Me.WeatherGroupBox.Name = "WeatherGroupBox"
        Me.WeatherGroupBox.Size = New System.Drawing.Size(142, 132)
        Me.WeatherGroupBox.TabIndex = 5
        Me.WeatherGroupBox.TabStop = False
        Me.WeatherGroupBox.Text = "Weather Condition:"
        '
        'CloudyRadioButton
        '
        Me.CloudyRadioButton.AutoSize = True
        Me.CloudyRadioButton.Location = New System.Drawing.Point(13, 101)
        Me.CloudyRadioButton.Name = "CloudyRadioButton"
        Me.CloudyRadioButton.Size = New System.Drawing.Size(68, 20)
        Me.CloudyRadioButton.TabIndex = 3
        Me.CloudyRadioButton.TabStop = True
        Me.CloudyRadioButton.Text = "Cloudy"
        Me.CloudyRadioButton.UseVisualStyleBackColor = True
        '
        'RainyRadioButton
        '
        Me.RainyRadioButton.AutoSize = True
        Me.RainyRadioButton.Location = New System.Drawing.Point(13, 75)
        Me.RainyRadioButton.Name = "RainyRadioButton"
        Me.RainyRadioButton.Size = New System.Drawing.Size(61, 20)
        Me.RainyRadioButton.TabIndex = 2
        Me.RainyRadioButton.TabStop = True
        Me.RainyRadioButton.Text = "Rainy"
        Me.RainyRadioButton.UseVisualStyleBackColor = True
        '
        'SnowyRadioButton
        '
        Me.SnowyRadioButton.AutoSize = True
        Me.SnowyRadioButton.Location = New System.Drawing.Point(13, 49)
        Me.SnowyRadioButton.Name = "SnowyRadioButton"
        Me.SnowyRadioButton.Size = New System.Drawing.Size(66, 20)
        Me.SnowyRadioButton.TabIndex = 1
        Me.SnowyRadioButton.TabStop = True
        Me.SnowyRadioButton.Text = "Snowy"
        Me.SnowyRadioButton.UseVisualStyleBackColor = True
        '
        'SunnyRadioButton
        '
        Me.SunnyRadioButton.AutoSize = True
        Me.SunnyRadioButton.Location = New System.Drawing.Point(13, 23)
        Me.SunnyRadioButton.Name = "SunnyRadioButton"
        Me.SunnyRadioButton.Size = New System.Drawing.Size(63, 20)
        Me.SunnyRadioButton.TabIndex = 0
        Me.SunnyRadioButton.TabStop = True
        Me.SunnyRadioButton.Text = "Sunny"
        Me.SunnyRadioButton.UseVisualStyleBackColor = True
        '
        'SunnyPictureBox
        '
        Me.SunnyPictureBox.Image = Global.WeatherAdviceProject.My.Resources.Resources.Sun
        Me.SunnyPictureBox.Location = New System.Drawing.Point(204, 64)
        Me.SunnyPictureBox.Name = "SunnyPictureBox"
        Me.SunnyPictureBox.Size = New System.Drawing.Size(60, 60)
        Me.SunnyPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.SunnyPictureBox.TabIndex = 6
        Me.SunnyPictureBox.TabStop = False
        Me.SunnyPictureBox.Visible = False
        '
        'RainyPictureBox
        '
        Me.RainyPictureBox.Image = Global.WeatherAdviceProject.My.Resources.Resources.Rain
        Me.RainyPictureBox.Location = New System.Drawing.Point(204, 136)
        Me.RainyPictureBox.Name = "RainyPictureBox"
        Me.RainyPictureBox.Size = New System.Drawing.Size(60, 60)
        Me.RainyPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.RainyPictureBox.TabIndex = 7
        Me.RainyPictureBox.TabStop = False
        Me.RainyPictureBox.Visible = False
        '
        'CloudyPictureBox
        '
        Me.CloudyPictureBox.Image = Global.WeatherAdviceProject.My.Resources.Resources.Cloud
        Me.CloudyPictureBox.Location = New System.Drawing.Point(281, 136)
        Me.CloudyPictureBox.Name = "CloudyPictureBox"
        Me.CloudyPictureBox.Size = New System.Drawing.Size(60, 60)
        Me.CloudyPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.CloudyPictureBox.TabIndex = 8
        Me.CloudyPictureBox.TabStop = False
        Me.CloudyPictureBox.Visible = False
        '
        'SnowyPictureBox
        '
        Me.SnowyPictureBox.Image = Global.WeatherAdviceProject.My.Resources.Resources.Snow
        Me.SnowyPictureBox.Location = New System.Drawing.Point(281, 64)
        Me.SnowyPictureBox.Name = "SnowyPictureBox"
        Me.SnowyPictureBox.Size = New System.Drawing.Size(60, 60)
        Me.SnowyPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.SnowyPictureBox.TabIndex = 9
        Me.SnowyPictureBox.TabStop = False
        Me.SnowyPictureBox.Visible = False
        '
        'MessageLabel
        '
        Me.MessageLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MessageLabel.Location = New System.Drawing.Point(14, 207)
        Me.MessageLabel.Name = "MessageLabel"
        Me.MessageLabel.Size = New System.Drawing.Size(237, 111)
        Me.MessageLabel.TabIndex = 10
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'ResetButton
        '
        Me.ResetButton.Location = New System.Drawing.Point(266, 237)
        Me.ResetButton.Name = "ResetButton"
        Me.ResetButton.Size = New System.Drawing.Size(75, 23)
        Me.ResetButton.TabIndex = 11
        Me.ResetButton.Text = "Reset"
        Me.ResetButton.UseVisualStyleBackColor = True
        '
        'WeatherForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(355, 350)
        Me.Controls.Add(Me.ResetButton)
        Me.Controls.Add(Me.MessageLabel)
        Me.Controls.Add(Me.SnowyPictureBox)
        Me.Controls.Add(Me.CloudyPictureBox)
        Me.Controls.Add(Me.RainyPictureBox)
        Me.Controls.Add(Me.SunnyPictureBox)
        Me.Controls.Add(Me.WeatherGroupBox)
        Me.Controls.Add(Me.PrintButton)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "WeatherForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Weather Advice"
        Me.WeatherGroupBox.ResumeLayout(False)
        Me.WeatherGroupBox.PerformLayout()
        CType(Me.SunnyPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RainyPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CloudyPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SnowyPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ExitButton As System.Windows.Forms.Button
    Friend WithEvents PrintButton As System.Windows.Forms.Button
    Friend WithEvents WeatherGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents CloudyRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents RainyRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents SnowyRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents SunnyRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents SunnyPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents RainyPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents CloudyPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents SnowyPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents MessageLabel As System.Windows.Forms.Label
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents ResetButton As System.Windows.Forms.Button

End Class
