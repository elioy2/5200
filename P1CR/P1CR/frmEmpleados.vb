Public Class frmEmpleados


    Private Sub btnbuscar_Click(sender As Object, e As EventArgs) Handles btnbuscar.Click
        If txtSearchemp.TextLength <= 0 Or (rbID.Checked = False And rbNombre.Checked = False) Then
            MessageBox.Show("Entre algo ñeta")
        Else

        End If

    End Sub

    Private Sub CerrarToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Me.Close()

    End Sub

    Private Sub S_EMPBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.S_EMPBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSetOracle)

    End Sub

    Private Sub S_EMPBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs)
        Me.Validate()
        Me.S_EMPBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSetOracle)

    End Sub

    Private Sub S_EMPBindingNavigatorSaveItem_Click_2(sender As Object, e As EventArgs)
        Me.Validate()
        Me.S_EMPBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSetOracle)

    End Sub

    Private Sub frmEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSetOracle.S_EMP' table. You can move, or remove it, as needed.
        Me.S_EMPTableAdapter.Fill(Me.DataSetOracle.S_EMP)

    End Sub

    Private Sub VolverAlMenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VolverAlMenuToolStripMenuItem.Click
        MainForm.Show()
        Me.Close()
    End Sub

    Private Sub CerrarToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles CerrarToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class