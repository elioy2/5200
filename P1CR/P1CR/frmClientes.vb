Public Class frmClientes
    Private Sub frmClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSetOracle.S_CUSTOMER' table. You can move, or remove it, as needed.
        Me.S_CUSTOMERTableAdapter.Fill(Me.DataSetOracle.S_CUSTOMER)
        Label2.Text = count().ToString

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim buscar As String = txtBuscar.Text
        Me.S_CUSTOMERTableAdapter.FillBySearch(Me.DataSetOracle.S_CUSTOMER, buscar)
        Label2.Text = count().ToString
    End Sub

    Private Function count() As Integer
        Dim conteo As Integer
        conteo = dgvClientes.RowCount
        Return conteo
    End Function
End Class