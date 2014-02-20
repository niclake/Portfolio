Public Class frmClassification
  Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

  Public Sub New()
    MyBase.New()

    'This call is required by the Windows Form Designer.
    InitializeComponent()

    'Add any initialization after the InitializeComponent() call

  End Sub

  'Form overrides dispose to clean up the component list.
  Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
    If disposing Then
      If Not (components Is Nothing) Then
        components.Dispose()
      End If
    End If
    MyBase.Dispose(disposing)
  End Sub

  'Required by the Windows Form Designer
  Private components As System.ComponentModel.IContainer

  'NOTE: The following procedure is required by the Windows Form Designer
  'It can be modified using the Windows Form Designer.  
  'Do not modify it using the code editor.
  Friend WithEvents lblCrHours As System.Windows.Forms.Label
  Friend WithEvents txtCrHours As System.Windows.Forms.TextBox
  Friend WithEvents btnCalculate As System.Windows.Forms.Button
  Friend WithEvents txtClass As System.Windows.Forms.TextBox
  Friend WithEvents btnClear As System.Windows.Forms.Button
  Friend WithEvents btnExit As System.Windows.Forms.Button
  <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.lblCrHours = New System.Windows.Forms.Label
        Me.txtCrHours = New System.Windows.Forms.TextBox
        Me.btnCalculate = New System.Windows.Forms.Button
        Me.txtClass = New System.Windows.Forms.TextBox
        Me.btnClear = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'lblCrHours
        '
        Me.lblCrHours.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCrHours.Location = New System.Drawing.Point(0, 16)
        Me.lblCrHours.Name = "lblCrHours"
        Me.lblCrHours.Size = New System.Drawing.Size(152, 32)
        Me.lblCrHours.TabIndex = 0
        Me.lblCrHours.Text = "Enter the number of earned credit hours:"
        Me.lblCrHours.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCrHours
        '
        Me.txtCrHours.Location = New System.Drawing.Point(160, 24)
        Me.txtCrHours.Name = "txtCrHours"
        Me.txtCrHours.Size = New System.Drawing.Size(40, 20)
        Me.txtCrHours.TabIndex = 1
        Me.txtCrHours.Text = ""
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(48, 64)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(168, 24)
        Me.btnCalculate.TabIndex = 2
        Me.btnCalculate.Text = "Determine Classification"
        Me.btnCalculate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtClass
        '
        Me.txtClass.Location = New System.Drawing.Point(24, 112)
        Me.txtClass.Name = "txtClass"
        Me.txtClass.Size = New System.Drawing.Size(240, 20)
        Me.txtClass.TabIndex = 3
        Me.txtClass.Text = ""
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(32, 152)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "Clear"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(152, 152)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit"
        '
        'frmClassification
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(292, 198)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.txtClass)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtCrHours)
        Me.Controls.Add(Me.lblCrHours)
        Me.Controls.Add(Me.btnExit)
        Me.Name = "frmClassification"
        Me.Text = "Classification Finder"
        Me.ResumeLayout(False)

    End Sub

#End Region

  Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
    End
  End Sub

  Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
    'Set text boxes equal to null string
    txtCrHours.Text = ""
    txtClass.Text = ""

    'Give focus to Credit Hours text box
    txtCrHours.Focus()
  End Sub

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click

    End Sub
End Class
