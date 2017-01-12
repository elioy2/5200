<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReporteA
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReporteA))
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VolverAlMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReporteBToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReporteCToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VWREPORTEABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetOracle = New P1CR.DataSetOracle()
        Me.VWREPORTEATableAdapter = New P1CR.DataSetOracleTableAdapters.VWREPORTEATableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.VWREPORTEABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetOracle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.VWREPORTEABindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "P1CR.Report1.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 53)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(784, 407)
        Me.ReportViewer1.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ReportesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(784, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VolverAlMenuToolStripMenuItem, Me.CerrarToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'VolverAlMenuToolStripMenuItem
        '
        Me.VolverAlMenuToolStripMenuItem.Name = "VolverAlMenuToolStripMenuItem"
        Me.VolverAlMenuToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.VolverAlMenuToolStripMenuItem.Text = "Volver al Menu"
        '
        'CerrarToolStripMenuItem
        '
        Me.CerrarToolStripMenuItem.Name = "CerrarToolStripMenuItem"
        Me.CerrarToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CerrarToolStripMenuItem.Text = "Cerrar"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReporteBToolStripMenuItem, Me.ReporteCToolStripMenuItem})
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.ReportesToolStripMenuItem.Text = "Reportes"
        '
        'ReporteBToolStripMenuItem
        '
        Me.ReporteBToolStripMenuItem.Name = "ReporteBToolStripMenuItem"
        Me.ReporteBToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ReporteBToolStripMenuItem.Text = "Reporte B"
        '
        'ReporteCToolStripMenuItem
        '
        Me.ReporteCToolStripMenuItem.Name = "ReporteCToolStripMenuItem"
        Me.ReporteCToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ReporteCToolStripMenuItem.Text = "Reporte C"
        '
        'VWREPORTEABindingSource
        '
        Me.VWREPORTEABindingSource.DataMember = "VWREPORTEA"
        Me.VWREPORTEABindingSource.DataSource = Me.DataSetOracle
        '
        'DataSetOracle
        '
        Me.DataSetOracle.DataSetName = "DataSetOracle"
        Me.DataSetOracle.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VWREPORTEATableAdapter
        '
        Me.VWREPORTEATableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Myriad Hebrew", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(105, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(611, 26)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Empleados con clientes que tienen órdenes mayores a $1,000.00"
        '
        'frmReporteA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 461)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmReporteA"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Empleados con clientes con ordenes sobre $1,000"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.VWREPORTEABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetOracle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents VWREPORTEABindingSource As BindingSource
    Friend WithEvents DataSetOracle As DataSetOracle
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VolverAlMenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CerrarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReporteBToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReporteCToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VWREPORTEATableAdapter As DataSetOracleTableAdapters.VWREPORTEATableAdapter
    Friend WithEvents Label1 As Label
End Class
