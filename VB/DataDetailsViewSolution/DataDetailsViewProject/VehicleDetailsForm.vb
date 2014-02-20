Public Class VehicleDetailsForm

    Private Sub VehicleBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VehicleBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.VehicleBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.VBAutoDataSet)

    End Sub

    Private Sub VehicleDetailsForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'VBAutoDataSet.Vehicle' table. You can move, or remove it, as needed.
        Me.VehicleTableAdapter.Fill(Me.VBAutoDataSet.Vehicle)

    End Sub
End Class
