Public Class frmProductos

    Private Sub frmProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Llenar datagridview cuando carga la forma
        Me.S_PRODUCTTableAdapter.Fill(Me.DataSetOracle.S_PRODUCT)

    End Sub

    Private Sub VolverAlMenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VolverAlMenuToolStripMenuItem.Click
        'Regresar al menu
        Me.Close()
        MainForm.Show()
    End Sub

    Private Sub CerrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarToolStripMenuItem.Click
        'Cerrar programa
        Me.Close()
        MainForm.Close()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        'Habilitar textboxes para editar producto seleccionado
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
            'Guardar cambios hechos o añadir nuevo producto
            S_PRODUCTBindingSource.EndEdit()
            S_PRODUCTTableAdapter.Update(DataSetOracle.S_PRODUCT)

            'Desabilitar textboxes para que el usuario no pueda editar
            IDTextBox.Enabled = False
            NAMETextBox.Enabled = False
            SHORT_DESCTextBox.Enabled = False
            IMAGE_IDTextBox.Enabled = False
            SUGGESTED_WHLSL_PRICETextBox.Enabled = False
            WHLSL_UNITSTextBox.Enabled = False
            LONGTEXT_IDTextBox.Enabled = False
        Catch ex As DataException
            'Si el usuario deja algun campo requerido en blanco, devolver error
            MessageBox.Show("No puede haber valores en blanco")
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        'Borrar producto seleccionado
        S_PRODUCTBindingSource.RemoveCurrent()
        S_PRODUCTTableAdapter.Update(DataSetOracle.S_PRODUCT)
    End Sub

    Private Sub btnbuscar_Click(sender As Object, e As EventArgs) Handles btnbuscar.Click
        'Buscar por ID o Nombre
        Dim buscar As String = txtSearchProduct.Text
        'Si el usuario no selecciona criterio de busqueda, devolver error
        If rbID.Checked = False And rbNombre.Checked = False Then
            MessageBox.Show("Seleccione un criterio de búsqueda")
        ElseIf rbNombre.Checked = True Then
            Me.S_PRODUCTTableAdapter.FillBySearch(Me.DataSetOracle.S_PRODUCT, buscar)
        ElseIf rbID.Checked = True Then
            'Si el ID entrado no es un valor numérico, devolver error
            If IsNumeric(txtSearchProduct.Text) Then
                Me.S_PRODUCTTableAdapter.FillByID(Me.DataSetOracle.S_PRODUCT, buscar)
            Else
                MessageBox.Show("El valor debe ser numérico")
            End If
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        'Habilitar textboxes para añadir nuevo producto
        IDTextBox.Enabled = True
        NAMETextBox.Enabled = True
        SHORT_DESCTextBox.Enabled = True
        IMAGE_IDTextBox.Enabled = True
        SUGGESTED_WHLSL_PRICETextBox.Enabled = True
        WHLSL_UNITSTextBox.Enabled = True
        LONGTEXT_IDTextBox.Enabled = True

        'Código para añadir nuevo producto
        S_PRODUCTBindingSource.AddNew()
    End Sub
End Class