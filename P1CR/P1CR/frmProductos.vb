Public Class frmProductos

    Private Sub frmProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSetOracle.S_PRODUCT' table. You can move, or remove it, as needed.
        Me.S_PRODUCTTableAdapter.Fill(Me.DataSetOracle.S_PRODUCT)

    End Sub

    Private Sub VolverAlMenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VolverAlMenuToolStripMenuItem.Click
        Me.Close()
        MainForm.Show()
    End Sub

    Private Sub CerrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarToolStripMenuItem.Click
        Me.Close()
        MainForm.Close()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        IDTextBox.Enabled = True
        NAMETextBox.Enabled = True
        SHORT_DESCTextBox.Enabled = True
        IMAGE_IDTextBox.Enabled = True
        SUGGESTED_WHLSL_PRICETextBox.Enabled = True
        WHLSL_UNITSTextBox.Enabled = True
        LONGTEXT_IDTextBox.Enabled = True
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            S_PRODUCTBindingSource.EndEdit()
            S_PRODUCTTableAdapter.Update(DataSetOracle.S_PRODUCT)
            IDTextBox.Enabled = False
            NAMETextBox.Enabled = False
            SHORT_DESCTextBox.Enabled = False
            IMAGE_IDTextBox.Enabled = False
            SUGGESTED_WHLSL_PRICETextBox.Enabled = False
            WHLSL_UNITSTextBox.Enabled = False
            LONGTEXT_IDTextBox.Enabled = False
        Catch ex As DataException
            MessageBox.Show("No puede haber valores en blanco")
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        S_PRODUCTBindingSource.RemoveCurrent()
        S_PRODUCTTableAdapter.Update(DataSetOracle.S_PRODUCT)
    End Sub

    Private Sub btnbuscar_Click(sender As Object, e As EventArgs) Handles btnbuscar.Click
        Dim buscar As String = txtSearchProduct.Text
        If rbID.Checked = False And rbNombre.Checked = False Then
            MessageBox.Show("Seleccione un criterio de búsqueda")
        ElseIf rbNombre.Checked = True Then
            Me.S_PRODUCTTableAdapter.FillBySearch(Me.DataSetOracle.S_PRODUCT, buscar)
        ElseIf rbID.Checked = True Then
            If IsNumeric(txtSearchProduct.Text) Then
                Me.S_PRODUCTTableAdapter.FillByID(Me.DataSetOracle.S_PRODUCT, buscar)
            Else
                MessageBox.Show("El valor debe ser numérico")
            End If
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        IDTextBox.Enabled = True
        NAMETextBox.Enabled = True
        SHORT_DESCTextBox.Enabled = True
        IMAGE_IDTextBox.Enabled = True
        SUGGESTED_WHLSL_PRICETextBox.Enabled = True
        WHLSL_UNITSTextBox.Enabled = True
        LONGTEXT_IDTextBox.Enabled = True
        S_PRODUCTBindingSource.AddNew()
    End Sub
End Class