Public Class MainForm
    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        AboutBox1.ShowDialog()
    End Sub

    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click
        frmClientes.Show()
        Me.Hide()
    End Sub

    Private Sub OrdenesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrdenesToolStripMenuItem.Click
        frmOrdenes.Show()
        Me.Hide()
    End Sub

    Private Sub CerrarSesionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarSesionToolStripMenuItem.Click
        Login.Show()
        Me.Close()

    End Sub

    Private Sub EmpleadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmpleadosToolStripMenuItem.Click
        frmEmpleados.Show()
        Me.Hide()
    End Sub

    Private Sub ProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductosToolStripMenuItem.Click
        frmProductos.Show()
        Me.Hide()
    End Sub

    Private Sub ReporteAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteAToolStripMenuItem.Click
        Me.Hide()
        frmReporteA.Show()
    End Sub

    Private Sub ReporteBToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteBToolStripMenuItem.Click
        Me.Hide()
        frmReporteB.Show()
    End Sub

    Private Sub ReporteCToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteCToolStripMenuItem.Click
        Me.Hide()
        frmReporteC.Show()
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = Today
        Label3.Text = user
    End Sub
End Class
