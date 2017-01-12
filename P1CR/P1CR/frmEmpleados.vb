Public Class frmEmpleados

    Private Sub btnbuscar_Click(sender As Object, e As EventArgs) Handles btnbuscar.Click
        'Código para buscar empleados
        Dim buscar As String = txtSearchEmp.Text
        'Si el usuario no ha seleccionado criterio de búsqueda, devolver error
        If rbID.Checked = False And rbNombre.Checked = False Then
            MessageBox.Show("Seleccione un criterio de búsqueda")
            'Si el usuario busca por nombre, ejecutar query correspondiente
        ElseIf rbNombre.Checked = True Then
            Me.S_EMPTableAdapter.FillBySearch(Me.DataSetOracle.S_EMP, buscar)
            'Si el usuario busca por ID, ejecutar query correspondiente
        ElseIf rbID.Checked = True Then
            If IsNumeric(txtSearchEmp.Text) Then
                Me.S_EMPTableAdapter.FillByID(Me.DataSetOracle.S_EMP, buscar)
            Else
                'Si el valor del ID no es numérico, devolver error
                MessageBox.Show("El valor debe ser numérico")
            End If
        End If

    End Sub

    Private Sub frmEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Llenar datagridview cuando carga la forma
        Me.S_EMPTableAdapter.Fill(Me.DataSetOracle.S_EMP)

    End Sub

    Private Sub VolverAlMenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VolverAlMenuToolStripMenuItem.Click
        'Cerrar forma y regresar al menu principal
        MainForm.Show()
        Me.Close()
    End Sub


    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        'Habilitar los textboxes para que el usuario pueda editar
        IDTextBox.Enabled = True
        LAST_NAMETextBox.Enabled = True
        FIRST_NAMETextBox.Enabled = True
        USERIDTextBox.Enabled = True
        START_DATEDateTimePicker.Enabled = True
        COMMENTSTextBox.Enabled = True
        MANAGER_IDTextBox.Enabled = True
        TITLETextBox.Enabled = True
        DEPT_IDTextBox.Enabled = True
        SALARYTextBox.Enabled = True
        COMMISSION_PCTTextBox.Enabled = True
        PASSWORDTextBox.Enabled = True
        STATUSTextBox.Enabled = True
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            'Guardar cualquier cambio hecho
            S_EMPBindingSource.EndEdit()
            S_EMPTableAdapter.Update(DataSetOracle.S_EMP)

            'Desabilitar textboxes para que el usuario no pueda editar
            IDTextBox.Enabled = False
            LAST_NAMETextBox.Enabled = False
            FIRST_NAMETextBox.Enabled = False
            USERIDTextBox.Enabled = False
            START_DATEDateTimePicker.Enabled = False
            COMMENTSTextBox.Enabled = False
            MANAGER_IDTextBox.Enabled = False
            TITLETextBox.Enabled = False
            DEPT_IDTextBox.Enabled = False
            SALARYTextBox.Enabled = False
            COMMISSION_PCTTextBox.Enabled = False
            PASSWORDTextBox.Enabled = False
            STATUSTextBox.Enabled = False
        Catch ex As DataException
            'Si el usuario deja algun campo requerido en blanco, notificarle
            MessageBox.Show("No puede haber valores en blanco")
        End Try
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        'Habilitar textboxes para poder añadir nuevo empleado
        IDTextBox.Enabled = True
        LAST_NAMETextBox.Enabled = True
        FIRST_NAMETextBox.Enabled = True
        USERIDTextBox.Enabled = True
        START_DATEDateTimePicker.Enabled = True
        COMMENTSTextBox.Enabled = True
        MANAGER_IDTextBox.Enabled = True
        TITLETextBox.Enabled = True
        DEPT_IDTextBox.Enabled = True
        SALARYTextBox.Enabled = True
        COMMISSION_PCTTextBox.Enabled = True
        PASSWORDTextBox.Enabled = True
        STATUSTextBox.Enabled = True

        'Código para añadir nuevo empleado
        S_EMPBindingSource.AddNew()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        'Borrar empleado seleccionado
        S_EMPBindingSource.RemoveCurrent()
        S_EMPTableAdapter.Update(DataSetOracle.S_EMP)
    End Sub

    Private Sub CerrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarToolStripMenuItem.Click
        'Cerrar el programa
        Me.Close()
        MainForm.Close()
    End Sub
End Class