Imports System.ComponentModel
Public Class frmClientes
    Private Sub frmClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Llenar datagridview para poder ver todos los records
        Me.S_CUSTOMERTableAdapter.Fill(Me.DataSetOracle.S_CUSTOMER)
    End Sub

    Private Sub btnSearchClient_Click(sender As Object, e As EventArgs) Handles btnSearchClient.Click
        'Validación para la búsqueda por nombre o por ID
        Dim buscar As String = txtSearchClient.Text
        If rbNombre.Checked = True Then
            Me.S_CUSTOMERTableAdapter.FillBySearch(Me.DataSetOracle.S_CUSTOMER, buscar)
        ElseIf rbID.Checked = True Then
            'Si el valor que entran para buscar por ID no es numérico, devolver error
            If IsNumeric(txtSearchClient.Text) Then
                Me.S_CUSTOMERTableAdapter.FillByID(Me.DataSetOracle.S_CUSTOMER, buscar)
            Else
                MessageBox.Show("El valor del campo debe ser numérico")
            End If
            'Si no hay nada seleccionado, devolver error
        ElseIf rbID.Checked = False And rbNombre.Checked = False Then
            MessageBox.Show("Favor seleccionar un criterio de búsqueda")
        End If
    End Sub

    Private Sub CerrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarToolStripMenuItem.Click
        'Cerrar el programa
        Me.Close()
        MainForm.Close()
    End Sub

    Private Sub VolverAlMenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VolverAlMenuToolStripMenuItem.Click
        'Regresar al menu
        MainForm.Show()
        Me.Close()
    End Sub

    Private Sub btnAddClient_Click(sender As Object, e As EventArgs) Handles btnAddClient.Click
        'Habilitar textboxes para poder entrar nuevo usuario
        IDTextBox.Enabled = True
        NAMETextBox.Enabled = True
        PHONETextBox.Enabled = True
        ADDRESSTextBox.Enabled = True
        COMMENTSTextBox.Enabled = True
        CITYTextBox.Enabled = True
        STATETextBox.Enabled = True
        COUNTRYTextBox.Enabled = True
        ZIP_CODETextBox.Enabled = True
        CREDIT_RATINGTextBox.Enabled = True
        SALES_REP_IDTextBox.Enabled = True
        REGION_IDTextBox.Enabled = True

        'Código para entrar nuevo usuario al binding source
        SCUSTOMERBindingSource.AddNew()


    End Sub

    Private Sub btnDeleteClient_Click(sender As Object, e As EventArgs) Handles btnDeleteClient.Click
        'Remover el usuario seleccionado del binding source y actualizar el data set
        SCUSTOMERBindingSource.RemoveCurrent()
        S_CUSTOMERTableAdapter.Update(DataSetOracle.S_CUSTOMER)
    End Sub

    Private Sub btnSaveClient_Click(sender As Object, e As EventArgs) Handles btnSaveClient.Click

        Try
            'Guardar los cambios hechos al cliente seleccionado o añadir nuevo cliente
            SCUSTOMERBindingSource.EndEdit()
            S_CUSTOMERTableAdapter.Update(DataSetOracle.S_CUSTOMER)

            'Desabilitar textboxes para que el usuario no pueda editar
            IDTextBox.Enabled = False
            NAMETextBox.Enabled = False
            PHONETextBox.Enabled = False
            ADDRESSTextBox.Enabled = False
            COMMENTSTextBox.Enabled = False
            CITYTextBox.Enabled = False
            STATETextBox.Enabled = False
            COUNTRYTextBox.Enabled = False
            ZIP_CODETextBox.Enabled = False
            CREDIT_RATINGTextBox.Enabled = False
            SALES_REP_IDTextBox.Enabled = False
            REGION_IDTextBox.Enabled = False
        Catch ex As DataException
            'Si el usuario deja algún campo requerido en blanco, mostrar mensaje
            MessageBox.Show("No puede haber valores en blanco")
        End Try

    End Sub

    Private Sub btnEditClient_Click(sender As Object, e As EventArgs) Handles btnEditClient.Click
        'Habilitar textboxes para que el usuario pueda editar
        IDTextBox.Enabled = True
        NAMETextBox.Enabled = True
        PHONETextBox.Enabled = True
        ADDRESSTextBox.Enabled = True
        COMMENTSTextBox.Enabled = True
        CITYTextBox.Enabled = True
        STATETextBox.Enabled = True
        COUNTRYTextBox.Enabled = True
        ZIP_CODETextBox.Enabled = True
        CREDIT_RATINGTextBox.Enabled = True
        SALES_REP_IDTextBox.Enabled = True
        IDTextBox.Enabled = True
        NAMETextBox.Enabled = True
        PHONETextBox.Enabled = True
        ADDRESSTextBox.Enabled = True
        COMMENTSTextBox.Enabled = True
        CITYTextBox.Enabled = True
        STATETextBox.Enabled = True
        COUNTRYTextBox.Enabled = True
        ZIP_CODETextBox.Enabled = True
        CREDIT_RATINGTextBox.Enabled = True
        SALES_REP_IDTextBox.Enabled = True
        REGION_IDTextBox.Enabled = True
        REGION_IDTextBox.Enabled = True
    End Sub
End Class