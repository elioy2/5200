Imports System.ComponentModel
Public Class frmClientes
    Private Sub frmClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSetOracle.S_CUSTOMER' table. You can move, or remove it, as needed.
        Me.S_CUSTOMERTableAdapter.Fill(Me.DataSetOracle.S_CUSTOMER)
    End Sub

    Private Sub btnSearchClient_Click(sender As Object, e As EventArgs) Handles btnSearchClient.Click
        Dim buscar As String = txtSearchClient.Text
        If rbNombre.Checked = True Then
            Me.S_CUSTOMERTableAdapter.FillBySearch(Me.DataSetOracle.S_CUSTOMER, buscar)
        ElseIf rbID.Checked = True Then
            If IsNumeric(txtSearchClient.Text) Then
                Me.S_CUSTOMERTableAdapter.FillByID(Me.DataSetOracle.S_CUSTOMER, buscar)
            Else
                MessageBox.Show("El valor del campo debe ser numérico")
            End If
        ElseIf rbID.Checked = False And rbNombre.Checked = False Then
                MessageBox.Show("Favor seleccionar un criterio de búsqueda")
        End If
        'Label2.Text = count().ToString
    End Sub

    Private Sub CerrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarToolStripMenuItem.Click
        Me.Close()
        MainForm.Close()
    End Sub

    Private Sub VolverAlMenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VolverAlMenuToolStripMenuItem.Click
        MainForm.Show()
        Me.Close()
    End Sub

    Private Sub btnAddClient_Click(sender As Object, e As EventArgs) Handles btnAddClient.Click

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

        Try
            SCUSTOMERBindingSource.AddNew()
        Catch ex As Exception
            MessageBox.Show("hiciste algo mal" & ex.ToString)
            Me.Close()
        End Try


    End Sub

    Private Sub btnDeleteClient_Click(sender As Object, e As EventArgs) Handles btnDeleteClient.Click
        SCUSTOMERBindingSource.RemoveCurrent()
        S_CUSTOMERTableAdapter.Update(DataSetOracle.S_CUSTOMER)
    End Sub

    Private Sub btnSaveClient_Click(sender As Object, e As EventArgs) Handles btnSaveClient.Click
        Try
            SCUSTOMERBindingSource.EndEdit()
            S_CUSTOMERTableAdapter.Update(DataSetOracle.S_CUSTOMER)
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
            MessageBox.Show("No puede haber valores en blanco")
        End Try

    End Sub

    Private Sub btnEditClient_Click(sender As Object, e As EventArgs) Handles btnEditClient.Click
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






    'Private Function count() As Integer
    'Dim conteo As Integer
    '   conteo = dgvClientes.RowCount
    'Return conteo
    'End Function
End Class