<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClientes
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
        Me.dgvClientes = New System.Windows.Forms.DataGridView()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PHONEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ADDRESSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CITYDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.STATEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COUNTRYDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ZIPCODEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CREDITRATINGDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SALESREPIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.REGIONIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COMMENTSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SCUSTOMERBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetOracle = New P1CR.DataSetOracle()
        Me.S_CUSTOMERTableAdapter = New P1CR.DataSetOracleTableAdapters.S_CUSTOMERTableAdapter()
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SCUSTOMERBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetOracle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvClientes
        '
        Me.dgvClientes.AllowUserToAddRows = False
        Me.dgvClientes.AutoGenerateColumns = False
        Me.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvClientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.NAMEDataGridViewTextBoxColumn, Me.PHONEDataGridViewTextBoxColumn, Me.ADDRESSDataGridViewTextBoxColumn, Me.CITYDataGridViewTextBoxColumn, Me.STATEDataGridViewTextBoxColumn, Me.COUNTRYDataGridViewTextBoxColumn, Me.ZIPCODEDataGridViewTextBoxColumn, Me.CREDITRATINGDataGridViewTextBoxColumn, Me.SALESREPIDDataGridViewTextBoxColumn, Me.REGIONIDDataGridViewTextBoxColumn, Me.COMMENTSDataGridViewTextBoxColumn})
        Me.dgvClientes.DataSource = Me.SCUSTOMERBindingSource
        Me.dgvClientes.Location = New System.Drawing.Point(12, 135)
        Me.dgvClientes.Name = "dgvClientes"
        Me.dgvClientes.Size = New System.Drawing.Size(760, 388)
        Me.dgvClientes.TabIndex = 0
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(160, 61)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 1
        Me.btnBuscar.Text = "&Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(13, 61)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(141, 20)
        Me.txtBuscar.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 539)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Total de resultados:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(115, 539)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 13)
        Me.Label2.TabIndex = 4
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        '
        'NAMEDataGridViewTextBoxColumn
        '
        Me.NAMEDataGridViewTextBoxColumn.DataPropertyName = "NAME"
        Me.NAMEDataGridViewTextBoxColumn.HeaderText = "NAME"
        Me.NAMEDataGridViewTextBoxColumn.Name = "NAMEDataGridViewTextBoxColumn"
        '
        'PHONEDataGridViewTextBoxColumn
        '
        Me.PHONEDataGridViewTextBoxColumn.DataPropertyName = "PHONE"
        Me.PHONEDataGridViewTextBoxColumn.HeaderText = "PHONE"
        Me.PHONEDataGridViewTextBoxColumn.Name = "PHONEDataGridViewTextBoxColumn"
        '
        'ADDRESSDataGridViewTextBoxColumn
        '
        Me.ADDRESSDataGridViewTextBoxColumn.DataPropertyName = "ADDRESS"
        Me.ADDRESSDataGridViewTextBoxColumn.HeaderText = "ADDRESS"
        Me.ADDRESSDataGridViewTextBoxColumn.Name = "ADDRESSDataGridViewTextBoxColumn"
        '
        'CITYDataGridViewTextBoxColumn
        '
        Me.CITYDataGridViewTextBoxColumn.DataPropertyName = "CITY"
        Me.CITYDataGridViewTextBoxColumn.HeaderText = "CITY"
        Me.CITYDataGridViewTextBoxColumn.Name = "CITYDataGridViewTextBoxColumn"
        '
        'STATEDataGridViewTextBoxColumn
        '
        Me.STATEDataGridViewTextBoxColumn.DataPropertyName = "STATE"
        Me.STATEDataGridViewTextBoxColumn.HeaderText = "STATE"
        Me.STATEDataGridViewTextBoxColumn.Name = "STATEDataGridViewTextBoxColumn"
        '
        'COUNTRYDataGridViewTextBoxColumn
        '
        Me.COUNTRYDataGridViewTextBoxColumn.DataPropertyName = "COUNTRY"
        Me.COUNTRYDataGridViewTextBoxColumn.HeaderText = "COUNTRY"
        Me.COUNTRYDataGridViewTextBoxColumn.Name = "COUNTRYDataGridViewTextBoxColumn"
        '
        'ZIPCODEDataGridViewTextBoxColumn
        '
        Me.ZIPCODEDataGridViewTextBoxColumn.DataPropertyName = "ZIP_CODE"
        Me.ZIPCODEDataGridViewTextBoxColumn.HeaderText = "ZIP_CODE"
        Me.ZIPCODEDataGridViewTextBoxColumn.Name = "ZIPCODEDataGridViewTextBoxColumn"
        '
        'CREDITRATINGDataGridViewTextBoxColumn
        '
        Me.CREDITRATINGDataGridViewTextBoxColumn.DataPropertyName = "CREDIT_RATING"
        Me.CREDITRATINGDataGridViewTextBoxColumn.HeaderText = "CREDIT_RATING"
        Me.CREDITRATINGDataGridViewTextBoxColumn.Name = "CREDITRATINGDataGridViewTextBoxColumn"
        '
        'SALESREPIDDataGridViewTextBoxColumn
        '
        Me.SALESREPIDDataGridViewTextBoxColumn.DataPropertyName = "SALES_REP_ID"
        Me.SALESREPIDDataGridViewTextBoxColumn.HeaderText = "SALES_REP_ID"
        Me.SALESREPIDDataGridViewTextBoxColumn.Name = "SALESREPIDDataGridViewTextBoxColumn"
        '
        'REGIONIDDataGridViewTextBoxColumn
        '
        Me.REGIONIDDataGridViewTextBoxColumn.DataPropertyName = "REGION_ID"
        Me.REGIONIDDataGridViewTextBoxColumn.HeaderText = "REGION_ID"
        Me.REGIONIDDataGridViewTextBoxColumn.Name = "REGIONIDDataGridViewTextBoxColumn"
        '
        'COMMENTSDataGridViewTextBoxColumn
        '
        Me.COMMENTSDataGridViewTextBoxColumn.DataPropertyName = "COMMENTS"
        Me.COMMENTSDataGridViewTextBoxColumn.HeaderText = "COMMENTS"
        Me.COMMENTSDataGridViewTextBoxColumn.Name = "COMMENTSDataGridViewTextBoxColumn"
        '
        'SCUSTOMERBindingSource
        '
        Me.SCUSTOMERBindingSource.DataMember = "S_CUSTOMER"
        Me.SCUSTOMERBindingSource.DataSource = Me.DataSetOracle
        '
        'DataSetOracle
        '
        Me.DataSetOracle.DataSetName = "DataSetOracle"
        Me.DataSetOracle.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'S_CUSTOMERTableAdapter
        '
        Me.S_CUSTOMERTableAdapter.ClearBeforeFill = True
        '
        'frmClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.dgvClientes)
        Me.Name = "frmClientes"
        Me.Text = "Clientes"
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SCUSTOMERBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetOracle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvClientes As DataGridView
    Friend WithEvents btnBuscar As Button
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents DataSetOracle As DataSetOracle
    Friend WithEvents SCUSTOMERBindingSource As BindingSource
    Friend WithEvents S_CUSTOMERTableAdapter As DataSetOracleTableAdapters.S_CUSTOMERTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NAMEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PHONEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ADDRESSDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CITYDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents STATEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents COUNTRYDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ZIPCODEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CREDITRATINGDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SALESREPIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents REGIONIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents COMMENTSDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
