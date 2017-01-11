Imports System.ComponentModel

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
        'IDTextBox.Focus()
        'Dim table As New DataTable
        'Dim sqlStr As String = "Select ID, First_Name || ' ' || Last_Name As Name FROM S_EMP WHERE MANAGER_ID = 3"
        'Dim connectionString As String = oradb
        'Dim dataAdapter As New Oracle.ManagedDataAccess.Client.OracleDataAdapter(sqlStr, connectionString)
        'Dim commandbuilder As New Oracle.ManagedDataAccess.Client.OracleCommandBuilder(dataAdapter)
        'dataAdapter.Fill(table)
        'SALES_REP_IDComboBox.DataSource = New BindingSource(table, Nothing)
        'SALES_REP_IDComboBox.DisplayMember = "Name"
        'SALES_REP_IDComboBox.ValueMember = "ID"
        'SALES_REP_IDComboBox.DataSource = SCUSTOMERBindingSource
        'SALES_REP_IDComboBox.DisplayMember = "SALES_REP_ID"
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
            MessageBox.Show("No puede haber valores nulos")
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