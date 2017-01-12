Public Class frmOrdenes

    Private Sub frmOrdenes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Código para llenar el datagridview cuando carga la forma
        Me.S_ORDTableAdapter.Fill(Me.DataSetOracle.S_ORD)

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
        'Habilitar textboxes para que el usuario pueda editar
        IDTextBox.Enabled = True
        CUSTOMER_IDTextBox.Enabled = True
        DATE_ORDEREDDateTimePicker.Enabled = True
        DATE_SHIPPEDDateTimePicker.Enabled = True
        SALES_REP_IDTextBox.Enabled = True
        TOTALTextBox.Enabled = True
        PAYMENT_TYPETextBox.Enabled = True
        ORDER_FILLEDTextBox.Enabled = True
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            'Guardar cambios hechos u ordenes añadidas
            S_ORDBindingSource.EndEdit()
            S_ORDTableAdapter.Update(DataSetOracle.S_ORD)

            'Desabilitar textboxes para que el usuario no pueda editar
            IDTextBox.Enabled = False
            CUSTOMER_IDTextBox.Enabled = False
            DATE_ORDEREDDateTimePicker.Enabled = False
            DATE_SHIPPEDDateTimePicker.Enabled = False
            SALES_REP_IDTextBox.Enabled = False
            TOTALTextBox.Enabled = False
            PAYMENT_TYPETextBox.Enabled = False
            ORDER_FILLEDTextBox.Enabled = False
        Catch ex As DataException
            MessageBox.Show("No puede haber valores en blanco")
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        'Eliminar orden seleccionada
        S_ORDBindingSource.RemoveCurrent()
        S_ORDTableAdapter.Update(DataSetOracle.S_ORD)
    End Sub

    Private Sub btnbuscar_Click(sender As Object, e As EventArgs) Handles btnbuscar.Click
        'Buscar orden por ID de orden o ID de cliente
        Dim buscar As String = txtSearchOrder.Text
        'Si el usuario no ha seleccionado criterio de busqueda, devoler error
        If rbID.Checked = False And rbCustID.Checked = False Then
            MessageBox.Show("Seleccione un criterio de búsqueda")
        ElseIf rbCustID.Checked = True Then
            'Validar si el usuario entró un ID numérico
            If IsNumeric(txtSearchOrder.Text) Then
                Me.S_ORDTableAdapter.FillBySearch(Me.DataSetOracle.S_ORD, buscar)
            Else
                MessageBox.Show("El valor debe ser numérico")
            End If
        ElseIf rbID.Checked = True Then
            'Validar si el usuario entró un ID numérico
            If IsNumeric(txtSearchOrder.Text) Then
                Me.S_ORDTableAdapter.FillByID(Me.DataSetOracle.S_ORD, buscar)
            Else
                MessageBox.Show("El valor debe ser numérico")
            End If
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        'Habilitar textboxes para añadir nueva orden
        IDTextBox.Enabled = True
        CUSTOMER_IDTextBox.Enabled = True
        DATE_ORDEREDDateTimePicker.Enabled = True
        DATE_SHIPPEDDateTimePicker.Enabled = True
        SALES_REP_IDTextBox.Enabled = True
        TOTALTextBox.Enabled = True
        PAYMENT_TYPETextBox.Enabled = True
        ORDER_FILLEDTextBox.Enabled = True

        'Código para añadir nueva orden
        S_ORDBindingSource.AddNew()
    End Sub
End Class