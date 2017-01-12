Public Class frmReporteB
    Private Sub CerrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarToolStripMenuItem.Click
        Me.Close()
        MainForm.Close()
    End Sub

    Private Sub frmReporteB_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSetOracle.VWREPORTEB' table. You can move, or remove it, as needed.
        Me.VWREPORTEBTableAdapter.Fill(Me.DataSetOracle.VWREPORTEB)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ReporteBToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteBToolStripMenuItem.Click
        Me.Close()
        frmReporteA.Show()
    End Sub

    Private Sub VolverAlMenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VolverAlMenuToolStripMenuItem.Click
        Me.Close()
        MainForm.Show()
    End Sub

    Private Sub ReporteCToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteCToolStripMenuItem.Click
        Me.Close()
        frmReporteC.Show()
    End Sub
End Class