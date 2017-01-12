Public Class Informes
    Private Sub Informes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'TODO: This line of code loads data into the 'DataSetOracle.Empleado_rpt' table. You can move, or remove it, as needed.
        Me.Empleado_rptTableAdapter.Fill(Me.DataSetOracle.Empleado_rpt)
        'TODO: This line of code loads data into the 'DataSetOracle.Clientes_Ordenes' table. You can move, or remove it, as needed.
        Me.ClientsDate_rpt.Fill(Me.DataSetOracle.Clientes_Ordenes)
        Me.ReportViewer1.RefreshReport()
        ''Fail aqui solo hago el lad pero tengo problemas con los adapter dinamicamente
        'Try
        '    With Me.ReportViewer1.LocalReport
        '        .ReportPath = "Reports\" & MainForm.report & ".rdlc"
        '    End With
        '    Me.ReportViewer1.RefreshReport()
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message, My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Try
    End Sub

    Private Sub VolverAlMenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VolverAlMenuToolStripMenuItem.Click

        MainForm.Show()
        Me.Close()
    End Sub


End Class