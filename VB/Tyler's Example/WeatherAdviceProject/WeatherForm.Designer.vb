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
        Me.NameTextBox = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.printbtn = New System.Windows.Forms.Button
        Me.ExitBtn = New System.Windows.Forms.Button
        Me.SunnyPictureBox = New System.Windows.Forms.PictureBox
        Me.SnowyPictureBox = New System.Windows.Forms.PictureBox
        Me.RainyPictureBox = New System.Windows.Forms.PictureBox
        Me.CloudyPictureBox = New System.Windows.Forms.PictureBox
        Me.WeatherGroupBox = New System.Windows.Forms.GroupBox
        Me.CloudyRadioButton = New System.Windows.Forms.RadioButton
        Me.RainyRadioButton = New System.Windows.Forms.RadioButton
        Me.SnowyRadioButton = New System.Windows.Forms.RadioButton
        Me.SunnyRadioButton = New System.Windows.Forms.RadioButton
        Me.MessageLabel = New System.Windows.Forms.Label
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ResetButton = New System.Windows.Forms.Button
        CType(Me.SunnyPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SnowyPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RainyPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CloudyPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.WeatherGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'NameTextBox
        '
        Me.NameTextBox.Location = New System.Drawing.Point(185, 13)
        Me.NameTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(170, 23)
        Me.NameTextBox.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.NameTextBox, "Type your name in this box")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(45, 16)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter your &name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(184, 300)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(171, 16)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Programmed by: Tyler Glass"
        '
        'printbtn
        '
        Me.printbtn.Location = New System.Drawing.Point(266, 236)
        Me.printbtn.Margin = New System.Windows.Forms.Padding(4)
        Me.printbtn.Name = "printbtn"
        Me.printbtn.Size = New System.Drawing.Size(88, 23)
        Me.printbtn.TabIndex = 3
        Me.printbtn.Text = "&Print"
        Me.ToolTip1.SetToolTip(Me.printbtn, "Click here to send form to print preview")
        Me.printbtn.UseVisualStyleBackColor = True
        '
        'ExitBtn
        '
        Me.ExitBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ExitBtn.Location = New System.Drawing.Point(266, 268)
        Me.ExitBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.ExitBtn.Name = "ExitBtn"
        Me.ExitBtn.Size = New System.Drawing.Size(88, 23)
        Me.ExitBtn.TabIndex = 4
        Me.ExitBtn.Text = "E&xit"
        Me.ExitBtn.UseVisualStyleBackColor = True
        '
        'SunnyPictureBox
        '
        Me.SunnyPictureBox.Image = Global.WindowsApplication1.My.Resources.Resources.Sun
        Me.SunnyPictureBox.Location = New System.Drawing.Point(185, 57)
        Me.SunnyPictureBox.Margin = New System.Windows.Forms.Padding(4)
        Me.SunnyPictureBox.Name = "SunnyPictureBox"
        Me.SunnyPictureBox.Size = New System.Drawing.Size(74, 61)
        Me.SunnyPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.SunnyPictureBox.TabIndex = 5
        Me.SunnyPictureBox.TabStop = False
        Me.SunnyPictureBox.Visible = False
        '
        'SnowyPictureBox
        '
        Me.SnowyPictureBox.Image = Global.WindowsApplication1.My.Resources.Resources.Snow
        Me.SnowyPictureBox.Location = New System.Drawing.Point(266, 57)
        Me.SnowyPictureBox.Margin = New System.Windows.Forms.Padding(4)
        Me.SnowyPictureBox.Name = "SnowyPictureBox"
        Me.SnowyPictureBox.Size = New System.Drawing.Size(72, 61)
        Me.SnowyPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.SnowyPictureBox.TabIndex = 6
        Me.SnowyPictureBox.TabStop = False
        Me.SnowyPictureBox.Visible = False
        '
        'RainyPictureBox
        '
        Me.RainyPictureBox.Image = Global.WindowsApplication1.My.Resources.Resources.Rain
        Me.RainyPictureBox.Location = New System.Drawing.Point(185, 126)
        Me.RainyPictureBox.Margin = New System.Windows.Forms.Padding(4)
        Me.RainyPictureBox.Name = "RainyPictureBox"
        Me.RainyPictureBox.Size = New System.Drawing.Size(74, 60)
        Me.RainyPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.RainyPictureBox.TabIndex = 7
        Me.RainyPictureBox.TabStop = False
        Me.RainyPictureBox.Visible = False
        '
        'CloudyPictureBox
        '
        Me.CloudyPictureBox.Image = Global.WindowsApplication1.My.Resources.Resources.Cloud
        Me.CloudyPictureBox.Location = New System.Drawing.Point(267, 126)
        Me.CloudyPictureBox.Margin = New System.Windows.Forms.Padding(4)
        Me.CloudyPictureBox.Name = "CloudyPictureBox"
        Me.CloudyPictureBox.Size = New System.Drawing.Size(72, 60)
        Me.CloudyPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.CloudyPictureBox.TabIndex = 8
        Me.CloudyPictureBox.TabStop = False
        Me.CloudyPictureBox.Visible = False
        '
        'WeatherGroupBox
        '
        Me.WeatherGroupBox.Controls.Add(Me.CloudyRadioButton)
        Me.WeatherGroupBox.Controls.Add(Me.RainyRadioButton)
        Me.WeatherGroupBox.Controls.Add(Me.SnowyRadioButton)
        Me.WeatherGroupBox.Controls.Add(Me.SunnyRadioButton)
        Me.WeatherGroupBox.Location = New System.Drawing.Point(12, 48)
        Me.WeatherGroupBox.Name = "WeatherGroupBox"
        Me.WeatherGroupBox.Size = New System.Drawing.Size(141, 138)
        Me.WeatherGroupBox.TabIndex = 2
        Me.WeatherGroupBox.TabStop = False
        Me.WeatherGroupBox.Text = "Weather Conditions:"
        '
        'CloudyRadioButton
        '
        Me.CloudyRadioButton.AutoSize = True
        Me.CloudyRadioButton.Location = New System.Drawing.Point(18, 102)
        Me.CloudyRadioButton.Name = "CloudyRadioButton"
        Me.CloudyRadioButton.Size = New System.Drawing.Size(64, 20)
        Me.CloudyRadioButton.TabIndex = 3
        Me.CloudyRadioButton.TabStop = True
        Me.CloudyRadioButton.Text = "&Cloudy"
        Me.CloudyRadioButton.UseVisualStyleBackColor = True
        '
        'RainyRadioButton
        '
        Me.RainyRadioButton.AutoSize = True
        Me.RainyRadioButton.Location = New System.Drawing.Point(18, 76)
        Me.RainyRadioButton.Name = "RainyRadioButton"
        Me.RainyRadioButton.Size = New System.Drawing.Size(57, 20)
        Me.RainyRadioButton.TabIndex = 2
        Me.RainyRadioButton.TabStop = True
        Me.RainyRadioButton.Text = "&Rainy"
        Me.RainyRadioButton.UseVisualStyleBackColor = True
        '
        'SnowyRadioButton
        '
        Me.SnowyRadioButton.AutoSize = True
        Me.SnowyRadioButton.Location = New System.Drawing.Point(18, 50)
        Me.SnowyRadioButton.Name = "SnowyRadioButton"
        Me.SnowyRadioButton.Size = New System.Drawing.Size(64, 20)
        Me.SnowyRadioButton.TabIndex = 1
        Me.SnowyRadioButton.TabStop = True
        Me.SnowyRadioButton.Text = "Sno&wy"
        Me.SnowyRadioButton.UseVisualStyleBackColor = True
        '
        'SunnyRadioButton
        '
        Me.SunnyRadioButton.AutoSize = True
        Me.SunnyRadioButton.Location = New System.Drawing.Point(18, 24)
        Me.SunnyRadioButton.Name = "SunnyRadioButton"
        Me.SunnyRadioButton.Size = New System.Drawing.Size(61, 20)
        Me.SunnyRadioButton.TabIndex = 0
        Me.SunnyRadioButton.TabStop = True
        Me.SunnyRadioButton.Text = "&Sunny"
        Me.SunnyRadioButton.UseVisualStyleBackColor = True
        '
        'MessageLabel
        '
        Me.MessageLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.MessageLabel.Location = New System.Drawing.Point(9, 204)
        Me.MessageLabel.Name = "MessageLabel"
        Me.MessageLabel.Size = New System.Drawing.Size(251, 87)
        Me.MessageLabel.TabIndex = 5
        Me.MessageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.ResetButton.Location = New System.Drawing.Point(266, 204)
        Me.ResetButton.Name = "ResetButton"
        Me.ResetButton.Size = New System.Drawing.Size(88, 23)
        Me.ResetButton.TabIndex = 9
        Me.ResetButton.Text = "Rese&t"
        Me.ResetButton.UseVisualStyleBackColor = True
        '
        'WeatherForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.ExitBtn
        Me.ClientSize = New System.Drawing.Size(367, 323)
        Me.Controls.Add(Me.ResetButton)
        Me.Controls.Add(Me.MessageLabel)
        Me.Controls.Add(Me.WeatherGroupBox)
        Me.Controls.Add(Me.CloudyPictureBox)
        Me.Controls.Add(Me.RainyPictureBox)
        Me.Controls.Add(Me.SnowyPictureBox)
        Me.Controls.Add(Me.SunnyPictureBox)
        Me.Controls.Add(Me.ExitBtn)
        Me.Controls.Add(Me.printbtn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.NameTextBox)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "WeatherForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Weather Advice"
        CType(Me.SunnyPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SnowyPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RainyPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CloudyPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.WeatherGroupBox.ResumeLayout(False)
        Me.WeatherGroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents printbtn As System.Windows.Forms.Button
    Friend WithEvents ExitBtn As System.Windows.Forms.Button
    Friend WithEvents SunnyPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents SnowyPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents RainyPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents CloudyPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents WeatherGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents CloudyRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents RainyRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents SnowyRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents SunnyRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents MessageLabel As System.Windows.Forms.Label
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents ResetButton As System.Windows.Forms.Button

End Class
