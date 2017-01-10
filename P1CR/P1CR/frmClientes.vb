Public Class frmClientes
    Private Sub frmClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSetOracle.S_CUSTOMER' table. You can move, or remove it, as needed.
        Me.S_CUSTOMERTableAdapter.Fill(Me.DataSetOracle.S_CUSTOMER)
        'Label2.Text = count().ToString

    End Sub

    Private Sub btnSearchClient_Click(sender As Object, e As EventArgs) Handles btnSearchClient.Click
        Dim buscar As String = txtSearchClient.Text
        Me.S_CUSTOMERTableAdapter.FillBySearch(Me.DataSetOracle.S_CUSTOMER, buscar)
        'Label2.Text = count().ToString
    End Sub

    Private Sub CerrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub VolverAlMenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VolverAlMenuToolStripMenuItem.Click
        MainForm.Show()
        Me.Close()
    End Sub

    Private Sub btnAddClient_Click(sender As Object, e As EventArgs) Handles btnAddClient.Click
        'IDTextBox.Clear()
        IDTextBox.Enabled = True
        'NAMETextBox.Clear()
        NAMETextBox.Enabled = True
        'PHONETextBox.Clear()
        PHONETextBox.Enabled = True
        'ADDRESSTextBox.Clear()
        ADDRESSTextBox.Enabled = True
        'COMMENTSTextBox.Clear()
        COMMENTSTextBox.Enabled = True
        'CITYTextBox.Clear()
        CITYTextBox.Enabled = True
        'STATETextBox.Clear()
        STATETextBox.Enabled = True
        'COUNTRYTextBox.Clear()
        COUNTRYTextBox.Enabled = True
        'ZIP_CODETextBox.Clear()
        ZIP_CODETextBox.Enabled = True
        'CREDIT_RATINGTextBox.Clear()
        CREDIT_RATINGTextBox.Enabled = True
        'SALES_REP_IDTextBox.Clear()
        SALES_REP_IDTextBox.Enabled = True
        'REGION_IDTextBox.Clear()
        REGION_IDTextBox.Enabled = True
        'IDTextBox.Focus()
        SCUSTOMERBindingSource.AddNew()
    End Sub

    Private Sub btnDeleteClient_Click(sender As Object, e As EventArgs) Handles btnDeleteClient.Click
        SCUSTOMERBindingSource.RemoveCurrent()
        S_CUSTOMERTableAdapter.Update(DataSetOracle.S_CUSTOMER)
    End Sub

    Private Sub btnSaveClient_Click(sender As Object, e As EventArgs) Handles btnSaveClient.Click
        SCUSTOMERBindingSource.EndEdit()
        S_CUSTOMERTableAdapter.Update(DataSetOracle.S_CUSTOMER)
    End Sub

    'Private Function count() As Integer
    'Dim conteo As Integer
    '   conteo = dgvClientes.RowCount
    'Return conteo
    'End Function
End Class