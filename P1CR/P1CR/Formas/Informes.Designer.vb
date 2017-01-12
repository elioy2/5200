<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Informes
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
        Me.Clientes_OrdenesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetOracle = New P1CR.DataSetOracle()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VolverAlMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientsDate_rpt = New P1CR.DataSetOracleTableAdapters.ClientsDate_rpt()
        Me.Empleado_rptBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Empleado_rptTableAdapter = New P1CR.DataSetOracleTableAdapters.Empleado_rptTableAdapter()
        Me.Orders_rptBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.Clientes_OrdenesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetOracle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.Empleado_rptBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Orders_rptBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Clientes_OrdenesBindingSource
        '
        Me.Clientes_OrdenesBindingSource.DataMember = "Clientes_Ordenes"
        Me.Clientes_OrdenesBindingSource.DataSource = Me.DataSetOracle
        '
        'DataSetOracle
        '
        Me.DataSetOracle.DataSetName = "DataSetOracle"
        Me.DataSetOracle.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.Empleado_rptBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "P1CR.Empleados.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 24)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(784, 537)
        Me.ReportViewer1.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(784, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VolverAlMenuToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'VolverAlMenuToolStripMenuItem
        '
        Me.VolverAlMenuToolStripMenuItem.Name = "VolverAlMenuToolStripMenuItem"
        Me.VolverAlMenuToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.VolverAlMenuToolStripMenuItem.Text = "Volver al Menu"
        '
        'ClientsDate_rpt
        '
        Me.ClientsDate_rpt.ClearBeforeFill = True
        '
        'Empleado_rptBindingSource
        '
        Me.Empleado_rptBindingSource.DataMember = "Empleado_rpt"
        Me.Empleado_rptBindingSource.DataSource = Me.DataSetOracle
        '
        'Empleado_rptTableAdapter
        '
        Me.Empleado_rptTableAdapter.ClearBeforeFill = True
        '
        'Orders_rptBindingSource
        '
        Me.Orders_rptBindingSource.DataMember = "Orders_rpt"
        Me.Orders_rptBindingSource.DataSource = Me.DataSetOracle
        '
        'Informes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Informes"
        Me.Text = "Informes"
        CType(Me.Clientes_OrdenesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetOracle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.Empleado_rptBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Orders_rptBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VolverAlMenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Clientes_OrdenesBindingSource As BindingSource
    Friend WithEvents DataSetOracle As DataSetOracle
    Friend WithEvents ClientsDate_rpt As DataSetOracleTableAdapters.ClientsDate_rpt
    Friend WithEvents Empleado_rptBindingSource As BindingSource
    Friend WithEvents Empleado_rptTableAdapter As DataSetOracleTableAdapters.Empleado_rptTableAdapter
    Friend WithEvents Orders_rptBindingSource As BindingSource
End Class
