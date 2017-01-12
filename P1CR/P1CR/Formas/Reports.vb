Public Class Reports
    Private Sub Reports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSetOracle.Empleado_rpt' table. You can move, or remove it, as needed.
        Me.Empleado_rptTableAdapter.Fill(Me.DataSetOracle.Empleado_rpt)
        'TODO: This line of code loads data into the 'DataSetOracle.Clientes_Ordenes' table. You can move, or remove it, as needed.
        Me.ClientsDate_rpt.Fill(Me.DataSetOracle.Clientes_Ordenes)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class