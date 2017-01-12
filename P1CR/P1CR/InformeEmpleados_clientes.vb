Public Class InformeEmpleados_clientes
    Private Sub InformeEmpleados_clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSetOracle.Report1DataTable' table. You can move, or remove it, as needed.
        Me.Report1DataTableTableAdapter.Fillrpt(Me.DataSetOracle.Report1DataTable)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class