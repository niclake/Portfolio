<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VehicleDetailsForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VehicleDetailsForm))
        Dim InventoryIDLabel As System.Windows.Forms.Label
        Dim ManufacturerLabel As System.Windows.Forms.Label
        Dim ModelNameLabel As System.Windows.Forms.Label
        Dim YearLabel As System.Windows.Forms.Label
        Dim VehicleIDLabel As System.Windows.Forms.Label
        Dim CostValueLabel As System.Windows.Forms.Label
        Me.VBAutoDataSet = New DataDetailsViewProject.VBAutoDataSet
        Me.VehicleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VehicleTableAdapter = New DataDetailsViewProject.VBAutoDataSetTableAdapters.VehicleTableAdapter
        Me.TableAdapterManager = New DataDetailsViewProject.VBAutoDataSetTableAdapters.TableAdapterManager
        Me.VehicleBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton
        Me.VehicleBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.InventoryIDTextBox = New System.Windows.Forms.TextBox
        Me.ManufacturerTextBox = New System.Windows.Forms.TextBox
        Me.ModelNameTextBox = New System.Windows.Forms.TextBox
        Me.YearTextBox = New System.Windows.Forms.TextBox
        Me.VehicleIDTextBox = New System.Windows.Forms.TextBox
        Me.CostValueTextBox = New System.Windows.Forms.TextBox
        InventoryIDLabel = New System.Windows.Forms.Label
        ManufacturerLabel = New System.Windows.Forms.Label
        ModelNameLabel = New System.Windows.Forms.Label
        YearLabel = New System.Windows.Forms.Label
        VehicleIDLabel = New System.Windows.Forms.Label
        CostValueLabel = New System.Windows.Forms.Label
        CType(Me.VBAutoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VehicleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VehicleBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.VehicleBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'VBAutoDataSet
        '
        Me.VBAutoDataSet.DataSetName = "VBAutoDataSet"
        Me.VBAutoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VehicleBindingSource
        '
        Me.VehicleBindingSource.DataMember = "Vehicle"
        Me.VehicleBindingSource.DataSource = Me.VBAutoDataSet
        '
        'VehicleTableAdapter
        '
        Me.VehicleTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = DataDetailsViewProject.VBAutoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VehicleTableAdapter = Me.VehicleTableAdapter
        '
        'VehicleBindingNavigator
        '
        Me.VehicleBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.VehicleBindingNavigator.BindingSource = Me.VehicleBindingSource
        Me.VehicleBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.VehicleBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.VehicleBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.VehicleBindingNavigatorSaveItem})
        Me.VehicleBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.VehicleBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.VehicleBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.VehicleBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.VehicleBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.VehicleBindingNavigator.Name = "VehicleBindingNavigator"
        Me.VehicleBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.VehicleBindingNavigator.Size = New System.Drawing.Size(299, 25)
        Me.VehicleBindingNavigator.TabIndex = 0
        Me.VehicleBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 20)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(33, 13)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'VehicleBindingNavigatorSaveItem
        '
        Me.VehicleBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.VehicleBindingNavigatorSaveItem.Image = CType(resources.GetObject("VehicleBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.VehicleBindingNavigatorSaveItem.Name = "VehicleBindingNavigatorSaveItem"
        Me.VehicleBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.VehicleBindingNavigatorSaveItem.Text = "Save Data"
        '
        'InventoryIDLabel
        '
        InventoryIDLabel.AutoSize = True
        InventoryIDLabel.Location = New System.Drawing.Point(47, 67)
        InventoryIDLabel.Name = "InventoryIDLabel"
        InventoryIDLabel.Size = New System.Drawing.Size(68, 13)
        InventoryIDLabel.TabIndex = 1
        InventoryIDLabel.Text = "Inventory ID:"
        '
        'InventoryIDTextBox
        '
        Me.InventoryIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VehicleBindingSource, "InventoryID", True))
        Me.InventoryIDTextBox.Location = New System.Drawing.Point(126, 64)
        Me.InventoryIDTextBox.Name = "InventoryIDTextBox"
        Me.InventoryIDTextBox.Size = New System.Drawing.Size(61, 20)
        Me.InventoryIDTextBox.TabIndex = 2
        '
        'ManufacturerLabel
        '
        ManufacturerLabel.AutoSize = True
        ManufacturerLabel.Location = New System.Drawing.Point(47, 93)
        ManufacturerLabel.Name = "ManufacturerLabel"
        ManufacturerLabel.Size = New System.Drawing.Size(73, 13)
        ManufacturerLabel.TabIndex = 3
        ManufacturerLabel.Text = "Manufacturer:"
        '
        'ManufacturerTextBox
        '
        Me.ManufacturerTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VehicleBindingSource, "Manufacturer", True))
        Me.ManufacturerTextBox.Location = New System.Drawing.Point(126, 90)
        Me.ManufacturerTextBox.Name = "ManufacturerTextBox"
        Me.ManufacturerTextBox.Size = New System.Drawing.Size(83, 20)
        Me.ManufacturerTextBox.TabIndex = 4
        '
        'ModelNameLabel
        '
        ModelNameLabel.AutoSize = True
        ModelNameLabel.Location = New System.Drawing.Point(47, 119)
        ModelNameLabel.Name = "ModelNameLabel"
        ModelNameLabel.Size = New System.Drawing.Size(70, 13)
        ModelNameLabel.TabIndex = 5
        ModelNameLabel.Text = "Model Name:"
        '
        'ModelNameTextBox
        '
        Me.ModelNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VehicleBindingSource, "ModelName", True))
        Me.ModelNameTextBox.Location = New System.Drawing.Point(126, 116)
        Me.ModelNameTextBox.Name = "ModelNameTextBox"
        Me.ModelNameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ModelNameTextBox.TabIndex = 6
        '
        'YearLabel
        '
        YearLabel.AutoSize = True
        YearLabel.Location = New System.Drawing.Point(47, 145)
        YearLabel.Name = "YearLabel"
        YearLabel.Size = New System.Drawing.Size(32, 13)
        YearLabel.TabIndex = 7
        YearLabel.Text = "Year:"
        '
        'YearTextBox
        '
        Me.YearTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VehicleBindingSource, "Year", True))
        Me.YearTextBox.Location = New System.Drawing.Point(126, 142)
        Me.YearTextBox.Name = "YearTextBox"
        Me.YearTextBox.Size = New System.Drawing.Size(45, 20)
        Me.YearTextBox.TabIndex = 8
        '
        'VehicleIDLabel
        '
        VehicleIDLabel.AutoSize = True
        VehicleIDLabel.Location = New System.Drawing.Point(47, 171)
        VehicleIDLabel.Name = "VehicleIDLabel"
        VehicleIDLabel.Size = New System.Drawing.Size(59, 13)
        VehicleIDLabel.TabIndex = 9
        VehicleIDLabel.Text = "Vehicle ID:"
        '
        'VehicleIDTextBox
        '
        Me.VehicleIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VehicleBindingSource, "VehicleID", True))
        Me.VehicleIDTextBox.Location = New System.Drawing.Point(126, 168)
        Me.VehicleIDTextBox.Name = "VehicleIDTextBox"
        Me.VehicleIDTextBox.Size = New System.Drawing.Size(137, 20)
        Me.VehicleIDTextBox.TabIndex = 10
        '
        'CostValueLabel
        '
        CostValueLabel.AutoSize = True
        CostValueLabel.Location = New System.Drawing.Point(47, 197)
        CostValueLabel.Name = "CostValueLabel"
        CostValueLabel.Size = New System.Drawing.Size(65, 13)
        CostValueLabel.TabIndex = 11
        CostValueLabel.Text = "Dealer Cost:"
        '
        'CostValueTextBox
        '
        Me.CostValueTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VehicleBindingSource, "CostValue", True))
        Me.CostValueTextBox.Location = New System.Drawing.Point(126, 194)
        Me.CostValueTextBox.Name = "CostValueTextBox"
        Me.CostValueTextBox.Size = New System.Drawing.Size(73, 20)
        Me.CostValueTextBox.TabIndex = 12
        '
        'VehicleDetailsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(299, 273)
        Me.Controls.Add(InventoryIDLabel)
        Me.Controls.Add(Me.InventoryIDTextBox)
        Me.Controls.Add(ManufacturerLabel)
        Me.Controls.Add(Me.ManufacturerTextBox)
        Me.Controls.Add(ModelNameLabel)
        Me.Controls.Add(Me.ModelNameTextBox)
        Me.Controls.Add(YearLabel)
        Me.Controls.Add(Me.YearTextBox)
        Me.Controls.Add(VehicleIDLabel)
        Me.Controls.Add(Me.VehicleIDTextBox)
        Me.Controls.Add(CostValueLabel)
        Me.Controls.Add(Me.CostValueTextBox)
        Me.Controls.Add(Me.VehicleBindingNavigator)
        Me.Name = "VehicleDetailsForm"
        Me.Text = "Vehicle Details"
        CType(Me.VBAutoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VehicleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VehicleBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.VehicleBindingNavigator.ResumeLayout(False)
        Me.VehicleBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents VBAutoDataSet As DataDetailsViewProject.VBAutoDataSet
    Friend WithEvents VehicleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VehicleTableAdapter As DataDetailsViewProject.VBAutoDataSetTableAdapters.VehicleTableAdapter
    Friend WithEvents TableAdapterManager As DataDetailsViewProject.VBAutoDataSetTableAdapters.TableAdapterManager
    Friend WithEvents VehicleBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents VehicleBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents InventoryIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ManufacturerTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ModelNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents YearTextBox As System.Windows.Forms.TextBox
    Friend WithEvents VehicleIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CostValueTextBox As System.Windows.Forms.TextBox

End Class
