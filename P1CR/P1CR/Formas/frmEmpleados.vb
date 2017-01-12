Public Class frmEmpleados


    Private Sub btnbuscar_Click(sender As Object, e As EventArgs) Handles btnbuscar.Click
        Dim buscar As String = txtSearchEmp.Text
        If rbID.Checked = False And rbNombre.Checked = False Then
            MessageBox.Show("Seleccione un criterio de búsqueda")
        ElseIf rbNombre.Checked = True Then
            Me.S_EMPTableAdapter.FillBySearch(Me.DataSetOracle.S_EMP, buscar)
        ElseIf rbID.Checked = True Then
            If IsNumeric(txtSearchEmp.Text) Then
                Me.S_EMPTableAdapter.FillByID(Me.DataSetOracle.S_EMP, buscar)
            Else
                MessageBox.Show("El valor debe ser numérico")
            End If
        End If

    End Sub

    Private Sub frmEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSetOracle.S_EMP' table. You can move, or remove it, as needed.
        Me.S_EMPTableAdapter.Fill(Me.DataSetOracle.S_EMP)

    End Sub

    Private Sub VolverAlMenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VolverAlMenuToolStripMenuItem.Click
        MainForm.Show()
        Me.Close()
    End Sub


    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
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
            S_EMPBindingSource.EndEdit()
            S_EMPTableAdapter.Update(DataSetOracle.S_EMP)
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
            MessageBox.Show("No puede haber valores en blanco")
        End Try
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
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
        S_EMPBindingSource.AddNew()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        S_EMPBindingSource.RemoveCurrent()
        S_EMPTableAdapter.Update(DataSetOracle.S_EMP)
    End Sub

    Private Sub CerrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarToolStripMenuItem.Click
        Me.Close()
        MainForm.Close()
    End Sub
End Class