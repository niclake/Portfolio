<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class TicketForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer
    Private mainMenu1 As System.Windows.Forms.MainMenu

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.mainMenu1 = New System.Windows.Forms.MainMenu
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.HandicapRadioButton = New System.Windows.Forms.RadioButton
        Me.DrivewayRadioButton = New System.Windows.Forms.RadioButton
        Me.NoParkingRadioButton = New System.Windows.Forms.RadioButton
        Me.MeterRadioButton = New System.Windows.Forms.RadioButton
        Me.RepeatCheckBox = New System.Windows.Forms.CheckBox
        Me.DisplayLabel = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'mainMenu1
        '
        Me.mainMenu1.MenuItems.Add(Me.MenuItem1)
        Me.mainMenu1.MenuItems.Add(Me.MenuItem2)
        '
        'MenuItem1
        '
        Me.MenuItem1.Text = "Display Fine"
        '
        'MenuItem2
        '
        Me.MenuItem2.Text = "Clear"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(5, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 20)
        Me.Label1.Text = "Parking Violation"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.HandicapRadioButton)
        Me.Panel1.Controls.Add(Me.DrivewayRadioButton)
        Me.Panel1.Controls.Add(Me.NoParkingRadioButton)
        Me.Panel1.Controls.Add(Me.MeterRadioButton)
        Me.Panel1.Location = New System.Drawing.Point(3, 23)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(234, 119)
        '
        'HandicapRadioButton
        '
        Me.HandicapRadioButton.Location = New System.Drawing.Point(12, 87)
        Me.HandicapRadioButton.Name = "HandicapRadioButton"
        Me.HandicapRadioButton.Size = New System.Drawing.Size(155, 20)
        Me.HandicapRadioButton.TabIndex = 3
        Me.HandicapRadioButton.Text = "Illegal Handicap Parking"
        '
        'DrivewayRadioButton
        '
        Me.DrivewayRadioButton.Location = New System.Drawing.Point(12, 61)
        Me.DrivewayRadioButton.Name = "DrivewayRadioButton"
        Me.DrivewayRadioButton.Size = New System.Drawing.Size(123, 20)
        Me.DrivewayRadioButton.TabIndex = 2
        Me.DrivewayRadioButton.Text = "Blocking Driveway"
        '
        'NoParkingRadioButton
        '
        Me.NoParkingRadioButton.Location = New System.Drawing.Point(12, 35)
        Me.NoParkingRadioButton.Name = "NoParkingRadioButton"
        Me.NoParkingRadioButton.Size = New System.Drawing.Size(114, 20)
        Me.NoParkingRadioButton.TabIndex = 1
        Me.NoParkingRadioButton.Text = "No Parking Zone"
        '
        'MeterRadioButton
        '
        Me.MeterRadioButton.Location = New System.Drawing.Point(12, 9)
        Me.MeterRadioButton.Name = "MeterRadioButton"
        Me.MeterRadioButton.Size = New System.Drawing.Size(100, 20)
        Me.MeterRadioButton.TabIndex = 0
        Me.MeterRadioButton.Text = "Expired Meter"
        '
        'RepeatCheckBox
        '
        Me.RepeatCheckBox.Location = New System.Drawing.Point(15, 148)
        Me.RepeatCheckBox.Name = "RepeatCheckBox"
        Me.RepeatCheckBox.Size = New System.Drawing.Size(123, 20)
        Me.RepeatCheckBox.TabIndex = 2
        Me.RepeatCheckBox.Text = "Repeat Offender"
        '
        'DisplayLabel
        '
        Me.DisplayLabel.ForeColor = System.Drawing.Color.Red
        Me.DisplayLabel.Location = New System.Drawing.Point(15, 181)
        Me.DisplayLabel.Name = "DisplayLabel"
        Me.DisplayLabel.Size = New System.Drawing.Size(211, 51)
        Me.DisplayLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'TicketForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(240, 268)
        Me.Controls.Add(Me.DisplayLabel)
        Me.Controls.Add(Me.RepeatCheckBox)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Menu = Me.mainMenu1
        Me.Name = "TicketForm"
        Me.Text = "Parking Fines"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents HandicapRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents DrivewayRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents NoParkingRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents MeterRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents RepeatCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents DisplayLabel As System.Windows.Forms.Label

End Class
