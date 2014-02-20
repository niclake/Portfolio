<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class MainForm
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
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.SeniorRadioButton = New System.Windows.Forms.RadioButton
        Me.FamilyRadioButton = New System.Windows.Forms.RadioButton
        Me.SingleRadioButton = New System.Windows.Forms.RadioButton
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.MonthsTextBox = New System.Windows.Forms.TextBox
        Me.DiscountCheckBox = New System.Windows.Forms.CheckBox
        Me.CostLabel = New System.Windows.Forms.Label
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
        Me.MenuItem1.Text = "Clear"
        '
        'MenuItem2
        '
        Me.MenuItem2.Text = "Calculate"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.SeniorRadioButton)
        Me.Panel1.Controls.Add(Me.FamilyRadioButton)
        Me.Panel1.Controls.Add(Me.SingleRadioButton)
        Me.Panel1.Location = New System.Drawing.Point(0, 20)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(240, 30)
        '
        'SeniorRadioButton
        '
        Me.SeniorRadioButton.Location = New System.Drawing.Point(174, 5)
        Me.SeniorRadioButton.Name = "SeniorRadioButton"
        Me.SeniorRadioButton.Size = New System.Drawing.Size(58, 20)
        Me.SeniorRadioButton.TabIndex = 5
        Me.SeniorRadioButton.TabStop = False
        Me.SeniorRadioButton.Text = "Senior"
        '
        'FamilyRadioButton
        '
        Me.FamilyRadioButton.Location = New System.Drawing.Point(86, 5)
        Me.FamilyRadioButton.Name = "FamilyRadioButton"
        Me.FamilyRadioButton.Size = New System.Drawing.Size(68, 20)
        Me.FamilyRadioButton.TabIndex = 4
        Me.FamilyRadioButton.TabStop = False
        Me.FamilyRadioButton.Text = "Family"
        '
        'SingleRadioButton
        '
        Me.SingleRadioButton.Checked = True
        Me.SingleRadioButton.Location = New System.Drawing.Point(8, 5)
        Me.SingleRadioButton.Name = "SingleRadioButton"
        Me.SingleRadioButton.Size = New System.Drawing.Size(58, 20)
        Me.SingleRadioButton.TabIndex = 3
        Me.SingleRadioButton.Text = "Single"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(55, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 20)
        Me.Label1.Text = "Membership Type"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(21, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 20)
        Me.Label2.Text = "Prepaid Months"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'MonthsTextBox
        '
        Me.MonthsTextBox.Location = New System.Drawing.Point(156, 59)
        Me.MonthsTextBox.Name = "MonthsTextBox"
        Me.MonthsTextBox.Size = New System.Drawing.Size(54, 21)
        Me.MonthsTextBox.TabIndex = 2
        '
        'DiscountCheckBox
        '
        Me.DiscountCheckBox.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.DiscountCheckBox.Location = New System.Drawing.Point(44, 92)
        Me.DiscountCheckBox.Name = "DiscountCheckBox"
        Me.DiscountCheckBox.Size = New System.Drawing.Size(155, 20)
        Me.DiscountCheckBox.TabIndex = 4
        Me.DiscountCheckBox.Text = "Discount Coupon?"
        '
        'CostLabel
        '
        Me.CostLabel.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.CostLabel.ForeColor = System.Drawing.Color.Red
        Me.CostLabel.Location = New System.Drawing.Point(0, 182)
        Me.CostLabel.Name = "CostLabel"
        Me.CostLabel.Size = New System.Drawing.Size(240, 58)
        Me.CostLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(240, 268)
        Me.Controls.Add(Me.CostLabel)
        Me.Controls.Add(Me.DiscountCheckBox)
        Me.Controls.Add(Me.MonthsTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Menu = Me.mainMenu1
        Me.Name = "MainForm"
        Me.Text = "Membership Calculator"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents MonthsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DiscountCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents CostLabel As System.Windows.Forms.Label
    Friend WithEvents SeniorRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents FamilyRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents SingleRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem

End Class
