<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmClientes
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim IDLabel As System.Windows.Forms.Label
        Dim NAMELabel As System.Windows.Forms.Label
        Dim PHONELabel As System.Windows.Forms.Label
        Dim ADDRESSLabel As System.Windows.Forms.Label
        Dim COMMENTSLabel As System.Windows.Forms.Label
        Dim CITYLabel As System.Windows.Forms.Label
        Dim STATELabel As System.Windows.Forms.Label
        Dim COUNTRYLabel As System.Windows.Forms.Label
        Dim ZIP_CODELabel As System.Windows.Forms.Label
        Dim CREDIT_RATINGLabel As System.Windows.Forms.Label
        Dim SALES_REP_IDLabel As System.Windows.Forms.Label
        Dim REGION_IDLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmClientes))
        Me.mnuClientes = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VolverAlMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.SALES_REP_IDTextBox = New System.Windows.Forms.TextBox()
        Me.REGION_IDTextBox = New System.Windows.Forms.TextBox()
        Me.CREDIT_RATINGTextBox = New System.Windows.Forms.TextBox()
        Me.ZIP_CODETextBox = New System.Windows.Forms.TextBox()
        Me.COUNTRYTextBox = New System.Windows.Forms.TextBox()
        Me.STATETextBox = New System.Windows.Forms.TextBox()
        Me.CITYTextBox = New System.Windows.Forms.TextBox()
        Me.COMMENTSTextBox = New System.Windows.Forms.TextBox()
        Me.ADDRESSTextBox = New System.Windows.Forms.TextBox()
        Me.PHONETextBox = New System.Windows.Forms.TextBox()
        Me.NAMETextBox = New System.Windows.Forms.TextBox()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.dgvClients = New System.Windows.Forms.DataGridView()
        Me.btnSearchClient = New System.Windows.Forms.Button()
        Me.btnSaveClient = New System.Windows.Forms.Button()
        Me.btnDeleteClient = New System.Windows.Forms.Button()
        Me.btnEditClient = New System.Windows.Forms.Button()
        Me.btnAddClient = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtSearchClient = New System.Windows.Forms.TextBox()
        Me.rbNombre = New System.Windows.Forms.RadioButton()
        Me.rbID = New System.Windows.Forms.RadioButton()
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
        Me.TableAdapterManager = New P1CR.DataSetOracleTableAdapters.TableAdapterManager()
        IDLabel = New System.Windows.Forms.Label()
        NAMELabel = New System.Windows.Forms.Label()
        PHONELabel = New System.Windows.Forms.Label()
        ADDRESSLabel = New System.Windows.Forms.Label()
        COMMENTSLabel = New System.Windows.Forms.Label()
        CITYLabel = New System.Windows.Forms.Label()
        STATELabel = New System.Windows.Forms.Label()
        COUNTRYLabel = New System.Windows.Forms.Label()
        ZIP_CODELabel = New System.Windows.Forms.Label()
        CREDIT_RATINGLabel = New System.Windows.Forms.Label()
        SALES_REP_IDLabel = New System.Windows.Forms.Label()
        REGION_IDLabel = New System.Windows.Forms.Label()
        Me.mnuClientes.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvClients, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.SCUSTOMERBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetOracle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(5, 22)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(21, 13)
        IDLabel.TabIndex = 0
        IDLabel.Text = "ID:"
        '
        'NAMELabel
        '
        NAMELabel.AutoSize = True
        NAMELabel.Location = New System.Drawing.Point(5, 54)
        NAMELabel.Name = "NAMELabel"
        NAMELabel.Size = New System.Drawing.Size(41, 13)
        NAMELabel.TabIndex = 2
        NAMELabel.Text = "NAME:"
        '
        'PHONELabel
        '
        PHONELabel.AutoSize = True
        PHONELabel.Location = New System.Drawing.Point(5, 84)
        PHONELabel.Name = "PHONELabel"
        PHONELabel.Size = New System.Drawing.Size(48, 13)
        PHONELabel.TabIndex = 4
        PHONELabel.Text = "PHONE:"
        '
        'ADDRESSLabel
        '
        ADDRESSLabel.AutoSize = True
        ADDRESSLabel.Location = New System.Drawing.Point(5, 113)
        ADDRESSLabel.Name = "ADDRESSLabel"
        ADDRESSLabel.Size = New System.Drawing.Size(62, 13)
        ADDRESSLabel.TabIndex = 6
        ADDRESSLabel.Text = "ADDRESS:"
        '
        'COMMENTSLabel
        '
        COMMENTSLabel.AutoSize = True
        COMMENTSLabel.Location = New System.Drawing.Point(5, 163)
        COMMENTSLabel.Name = "COMMENTSLabel"
        COMMENTSLabel.Size = New System.Drawing.Size(72, 13)
        COMMENTSLabel.TabIndex = 8
        COMMENTSLabel.Text = "COMMENTS:"
        '
        'CITYLabel
        '
        CITYLabel.AutoSize = True
        CITYLabel.Location = New System.Drawing.Point(195, 25)
        CITYLabel.Name = "CITYLabel"
        CITYLabel.Size = New System.Drawing.Size(34, 13)
        CITYLabel.TabIndex = 10
        CITYLabel.Text = "CITY:"
        '
        'STATELabel
        '
        STATELabel.AutoSize = True
        STATELabel.Location = New System.Drawing.Point(195, 58)
        STATELabel.Name = "STATELabel"
        STATELabel.Size = New System.Drawing.Size(45, 13)
        STATELabel.TabIndex = 12
        STATELabel.Text = "STATE:"
        '
        'COUNTRYLabel
        '
        COUNTRYLabel.AutoSize = True
        COUNTRYLabel.Location = New System.Drawing.Point(195, 88)
        COUNTRYLabel.Name = "COUNTRYLabel"
        COUNTRYLabel.Size = New System.Drawing.Size(63, 13)
        COUNTRYLabel.TabIndex = 14
        COUNTRYLabel.Text = "COUNTRY:"
        '
        'ZIP_CODELabel
        '
        ZIP_CODELabel.AutoSize = True
        ZIP_CODELabel.Location = New System.Drawing.Point(195, 117)
        ZIP_CODELabel.Name = "ZIP_CODELabel"
        ZIP_CODELabel.Size = New System.Drawing.Size(60, 13)
        ZIP_CODELabel.TabIndex = 16
        ZIP_CODELabel.Text = "ZIP CODE:"
        '
        'CREDIT_RATINGLabel
        '
        CREDIT_RATINGLabel.AutoSize = True
        CREDIT_RATINGLabel.Location = New System.Drawing.Point(383, 25)
        CREDIT_RATINGLabel.Name = "CREDIT_RATINGLabel"
        CREDIT_RATINGLabel.Size = New System.Drawing.Size(94, 13)
        CREDIT_RATINGLabel.TabIndex = 18
        CREDIT_RATINGLabel.Text = "CREDIT RATING:"
        '
        'SALES_REP_IDLabel
        '
        SALES_REP_IDLabel.AutoSize = True
        SALES_REP_IDLabel.Location = New System.Drawing.Point(383, 58)
        SALES_REP_IDLabel.Name = "SALES_REP_IDLabel"
        SALES_REP_IDLabel.Size = New System.Drawing.Size(83, 13)
        SALES_REP_IDLabel.TabIndex = 20
        SALES_REP_IDLabel.Text = "SALES REP ID:"
        '
        'REGION_IDLabel
        '
        REGION_IDLabel.AutoSize = True
        REGION_IDLabel.Location = New System.Drawing.Point(383, 92)
        REGION_IDLabel.Name = "REGION_IDLabel"
        REGION_IDLabel.Size = New System.Drawing.Size(66, 13)
        REGION_IDLabel.TabIndex = 22
        REGION_IDLabel.Text = "REGION ID:"
        '
        'mnuClientes
        '
        Me.mnuClientes.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.mnuClientes.Location = New System.Drawing.Point(0, 0)
        Me.mnuClientes.Name = "mnuClientes"
        Me.mnuClientes.Size = New System.Drawing.Size(784, 24)
        Me.mnuClientes.TabIndex = 5
        Me.mnuClientes.Text = "MenuStrip1"
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.SALES_REP_IDTextBox)
        Me.GroupBox1.Controls.Add(REGION_IDLabel)
        Me.GroupBox1.Controls.Add(Me.REGION_IDTextBox)
        Me.GroupBox1.Controls.Add(SALES_REP_IDLabel)
        Me.GroupBox1.Controls.Add(CREDIT_RATINGLabel)
        Me.GroupBox1.Controls.Add(Me.CREDIT_RATINGTextBox)
        Me.GroupBox1.Controls.Add(ZIP_CODELabel)
        Me.GroupBox1.Controls.Add(Me.ZIP_CODETextBox)
        Me.GroupBox1.Controls.Add(COUNTRYLabel)
        Me.GroupBox1.Controls.Add(Me.COUNTRYTextBox)
        Me.GroupBox1.Controls.Add(STATELabel)
        Me.GroupBox1.Controls.Add(Me.STATETextBox)
        Me.GroupBox1.Controls.Add(CITYLabel)
        Me.GroupBox1.Controls.Add(Me.CITYTextBox)
        Me.GroupBox1.Controls.Add(COMMENTSLabel)
        Me.GroupBox1.Controls.Add(Me.COMMENTSTextBox)
        Me.GroupBox1.Controls.Add(ADDRESSLabel)
        Me.GroupBox1.Controls.Add(Me.ADDRESSTextBox)
        Me.GroupBox1.Controls.Add(PHONELabel)
        Me.GroupBox1.Controls.Add(Me.PHONETextBox)
        Me.GroupBox1.Controls.Add(NAMELabel)
        Me.GroupBox1.Controls.Add(Me.NAMETextBox)
        Me.GroupBox1.Controls.Add(IDLabel)
        Me.GroupBox1.Controls.Add(Me.IDTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(596, 210)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Información del Cliente"
        '
        'SALES_REP_IDTextBox
        '
        Me.SALES_REP_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SCUSTOMERBindingSource, "SALES_REP_ID", True))
        Me.SALES_REP_IDTextBox.Enabled = False
        Me.SALES_REP_IDTextBox.Location = New System.Drawing.Point(483, 54)
        Me.SALES_REP_IDTextBox.Name = "SALES_REP_IDTextBox"
        Me.SALES_REP_IDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SALES_REP_IDTextBox.TabIndex = 24
        '
        'REGION_IDTextBox
        '
        Me.REGION_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SCUSTOMERBindingSource, "REGION_ID", True))
        Me.REGION_IDTextBox.Enabled = False
        Me.REGION_IDTextBox.Location = New System.Drawing.Point(483, 88)
        Me.REGION_IDTextBox.Name = "REGION_IDTextBox"
        Me.REGION_IDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.REGION_IDTextBox.TabIndex = 23
        '
        'CREDIT_RATINGTextBox
        '
        Me.CREDIT_RATINGTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SCUSTOMERBindingSource, "CREDIT_RATING", True))
        Me.CREDIT_RATINGTextBox.Enabled = False
        Me.CREDIT_RATINGTextBox.Location = New System.Drawing.Point(483, 22)
        Me.CREDIT_RATINGTextBox.Name = "CREDIT_RATINGTextBox"
        Me.CREDIT_RATINGTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CREDIT_RATINGTextBox.TabIndex = 19
        '
        'ZIP_CODETextBox
        '
        Me.ZIP_CODETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SCUSTOMERBindingSource, "ZIP_CODE", True))
        Me.ZIP_CODETextBox.Enabled = False
        Me.ZIP_CODETextBox.Location = New System.Drawing.Point(264, 114)
        Me.ZIP_CODETextBox.Name = "ZIP_CODETextBox"
        Me.ZIP_CODETextBox.Size = New System.Drawing.Size(100, 20)
        Me.ZIP_CODETextBox.TabIndex = 17
        '
        'COUNTRYTextBox
        '
        Me.COUNTRYTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SCUSTOMERBindingSource, "COUNTRY", True))
        Me.COUNTRYTextBox.Enabled = False
        Me.COUNTRYTextBox.Location = New System.Drawing.Point(264, 85)
        Me.COUNTRYTextBox.Name = "COUNTRYTextBox"
        Me.COUNTRYTextBox.Size = New System.Drawing.Size(100, 20)
        Me.COUNTRYTextBox.TabIndex = 15
        '
        'STATETextBox
        '
        Me.STATETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SCUSTOMERBindingSource, "STATE", True))
        Me.STATETextBox.Enabled = False
        Me.STATETextBox.Location = New System.Drawing.Point(264, 55)
        Me.STATETextBox.Name = "STATETextBox"
        Me.STATETextBox.Size = New System.Drawing.Size(100, 20)
        Me.STATETextBox.TabIndex = 13
        '
        'CITYTextBox
        '
        Me.CITYTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SCUSTOMERBindingSource, "CITY", True))
        Me.CITYTextBox.Enabled = False
        Me.CITYTextBox.Location = New System.Drawing.Point(264, 22)
        Me.CITYTextBox.Name = "CITYTextBox"
        Me.CITYTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CITYTextBox.TabIndex = 11
        '
        'COMMENTSTextBox
        '
        Me.COMMENTSTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SCUSTOMERBindingSource, "COMMENTS", True))
        Me.COMMENTSTextBox.Enabled = False
        Me.COMMENTSTextBox.Location = New System.Drawing.Point(83, 150)
        Me.COMMENTSTextBox.Multiline = True
        Me.COMMENTSTextBox.Name = "COMMENTSTextBox"
        Me.COMMENTSTextBox.Size = New System.Drawing.Size(313, 40)
        Me.COMMENTSTextBox.TabIndex = 9
        '
        'ADDRESSTextBox
        '
        Me.ADDRESSTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SCUSTOMERBindingSource, "ADDRESS", True))
        Me.ADDRESSTextBox.Enabled = False
        Me.ADDRESSTextBox.Location = New System.Drawing.Point(73, 110)
        Me.ADDRESSTextBox.Name = "ADDRESSTextBox"
        Me.ADDRESSTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ADDRESSTextBox.TabIndex = 7
        '
        'PHONETextBox
        '
        Me.PHONETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SCUSTOMERBindingSource, "PHONE", True))
        Me.PHONETextBox.Enabled = False
        Me.PHONETextBox.Location = New System.Drawing.Point(73, 81)
        Me.PHONETextBox.Name = "PHONETextBox"
        Me.PHONETextBox.Size = New System.Drawing.Size(100, 20)
        Me.PHONETextBox.TabIndex = 5
        '
        'NAMETextBox
        '
        Me.NAMETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SCUSTOMERBindingSource, "NAME", True))
        Me.NAMETextBox.Enabled = False
        Me.NAMETextBox.Location = New System.Drawing.Point(73, 51)
        Me.NAMETextBox.Name = "NAMETextBox"
        Me.NAMETextBox.Size = New System.Drawing.Size(100, 20)
        Me.NAMETextBox.TabIndex = 3
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SCUSTOMERBindingSource, "ID", True))
        Me.IDTextBox.Enabled = False
        Me.IDTextBox.Location = New System.Drawing.Point(73, 22)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IDTextBox.TabIndex = 1
        '
        'dgvClients
        '
        Me.dgvClients.AllowUserToAddRows = False
        Me.dgvClients.AllowUserToDeleteRows = False
        Me.dgvClients.AutoGenerateColumns = False
        Me.dgvClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvClients.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.NAMEDataGridViewTextBoxColumn, Me.PHONEDataGridViewTextBoxColumn, Me.ADDRESSDataGridViewTextBoxColumn, Me.CITYDataGridViewTextBoxColumn, Me.STATEDataGridViewTextBoxColumn, Me.COUNTRYDataGridViewTextBoxColumn, Me.ZIPCODEDataGridViewTextBoxColumn, Me.CREDITRATINGDataGridViewTextBoxColumn, Me.SALESREPIDDataGridViewTextBoxColumn, Me.REGIONIDDataGridViewTextBoxColumn, Me.COMMENTSDataGridViewTextBoxColumn})
        Me.dgvClients.DataSource = Me.SCUSTOMERBindingSource
        Me.dgvClients.Location = New System.Drawing.Point(211, 243)
        Me.dgvClients.Name = "dgvClients"
        Me.dgvClients.ReadOnly = True
        Me.dgvClients.RowHeadersVisible = False
        Me.dgvClients.Size = New System.Drawing.Size(561, 206)
        Me.dgvClients.TabIndex = 7
        '
        'btnSearchClient
        '
        Me.btnSearchClient.Location = New System.Drawing.Point(658, 140)
        Me.btnSearchClient.Name = "btnSearchClient"
        Me.btnSearchClient.Size = New System.Drawing.Size(72, 59)
        Me.btnSearchClient.TabIndex = 9
        Me.btnSearchClient.Text = "Buscar"
        Me.btnSearchClient.UseVisualStyleBackColor = True
        '
        'btnSaveClient
        '
        Me.btnSaveClient.Location = New System.Drawing.Point(696, 98)
        Me.btnSaveClient.Name = "btnSaveClient"
        Me.btnSaveClient.Size = New System.Drawing.Size(75, 32)
        Me.btnSaveClient.TabIndex = 13
        Me.btnSaveClient.Text = "Guardar"
        Me.btnSaveClient.UseVisualStyleBackColor = True
        '
        'btnDeleteClient
        '
        Me.btnDeleteClient.Location = New System.Drawing.Point(615, 98)
        Me.btnDeleteClient.Name = "btnDeleteClient"
        Me.btnDeleteClient.Size = New System.Drawing.Size(75, 32)
        Me.btnDeleteClient.TabIndex = 12
        Me.btnDeleteClient.Text = "Borrar"
        Me.btnDeleteClient.UseVisualStyleBackColor = True
        '
        'btnEditClient
        '
        Me.btnEditClient.Location = New System.Drawing.Point(696, 53)
        Me.btnEditClient.Name = "btnEditClient"
        Me.btnEditClient.Size = New System.Drawing.Size(75, 32)
        Me.btnEditClient.TabIndex = 11
        Me.btnEditClient.Text = "Editar"
        Me.btnEditClient.UseVisualStyleBackColor = True
        '
        'btnAddClient
        '
        Me.btnAddClient.Location = New System.Drawing.Point(615, 53)
        Me.btnAddClient.Name = "btnAddClient"
        Me.btnAddClient.Size = New System.Drawing.Size(75, 32)
        Me.btnAddClient.TabIndex = 10
        Me.btnAddClient.Text = "Add"
        Me.btnAddClient.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtSearchClient)
        Me.GroupBox2.Controls.Add(Me.rbNombre)
        Me.GroupBox2.Controls.Add(Me.rbID)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 243)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(192, 120)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Seleccionar Metodo De Busqueda"
        '
        'txtSearchClient
        '
        Me.txtSearchClient.Location = New System.Drawing.Point(0, 94)
        Me.txtSearchClient.Name = "txtSearchClient"
        Me.txtSearchClient.Size = New System.Drawing.Size(177, 20)
        Me.txtSearchClient.TabIndex = 0
        '
        'rbNombre
        '
        Me.rbNombre.AutoSize = True
        Me.rbNombre.Location = New System.Drawing.Point(18, 55)
        Me.rbNombre.Name = "rbNombre"
        Me.rbNombre.Size = New System.Drawing.Size(62, 17)
        Me.rbNombre.TabIndex = 1
        Me.rbNombre.TabStop = True
        Me.rbNombre.Text = "Nombre"
        Me.rbNombre.UseVisualStyleBackColor = True
        '
        'rbID
        '
        Me.rbID.AutoSize = True
        Me.rbID.Location = New System.Drawing.Point(18, 19)
        Me.rbID.Name = "rbID"
        Me.rbID.Size = New System.Drawing.Size(36, 17)
        Me.rbID.TabIndex = 0
        Me.rbID.TabStop = True
        Me.rbID.Text = "ID"
        Me.rbID.UseVisualStyleBackColor = True
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NAMEDataGridViewTextBoxColumn
        '
        Me.NAMEDataGridViewTextBoxColumn.DataPropertyName = "NAME"
        Me.NAMEDataGridViewTextBoxColumn.HeaderText = "NAME"
        Me.NAMEDataGridViewTextBoxColumn.Name = "NAMEDataGridViewTextBoxColumn"
        Me.NAMEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PHONEDataGridViewTextBoxColumn
        '
        Me.PHONEDataGridViewTextBoxColumn.DataPropertyName = "PHONE"
        Me.PHONEDataGridViewTextBoxColumn.HeaderText = "PHONE"
        Me.PHONEDataGridViewTextBoxColumn.Name = "PHONEDataGridViewTextBoxColumn"
        Me.PHONEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ADDRESSDataGridViewTextBoxColumn
        '
        Me.ADDRESSDataGridViewTextBoxColumn.DataPropertyName = "ADDRESS"
        Me.ADDRESSDataGridViewTextBoxColumn.HeaderText = "ADDRESS"
        Me.ADDRESSDataGridViewTextBoxColumn.Name = "ADDRESSDataGridViewTextBoxColumn"
        Me.ADDRESSDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CITYDataGridViewTextBoxColumn
        '
        Me.CITYDataGridViewTextBoxColumn.DataPropertyName = "CITY"
        Me.CITYDataGridViewTextBoxColumn.HeaderText = "CITY"
        Me.CITYDataGridViewTextBoxColumn.Name = "CITYDataGridViewTextBoxColumn"
        Me.CITYDataGridViewTextBoxColumn.ReadOnly = True
        '
        'STATEDataGridViewTextBoxColumn
        '
        Me.STATEDataGridViewTextBoxColumn.DataPropertyName = "STATE"
        Me.STATEDataGridViewTextBoxColumn.HeaderText = "STATE"
        Me.STATEDataGridViewTextBoxColumn.Name = "STATEDataGridViewTextBoxColumn"
        Me.STATEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'COUNTRYDataGridViewTextBoxColumn
        '
        Me.COUNTRYDataGridViewTextBoxColumn.DataPropertyName = "COUNTRY"
        Me.COUNTRYDataGridViewTextBoxColumn.HeaderText = "COUNTRY"
        Me.COUNTRYDataGridViewTextBoxColumn.Name = "COUNTRYDataGridViewTextBoxColumn"
        Me.COUNTRYDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ZIPCODEDataGridViewTextBoxColumn
        '
        Me.ZIPCODEDataGridViewTextBoxColumn.DataPropertyName = "ZIP_CODE"
        Me.ZIPCODEDataGridViewTextBoxColumn.HeaderText = "ZIP_CODE"
        Me.ZIPCODEDataGridViewTextBoxColumn.Name = "ZIPCODEDataGridViewTextBoxColumn"
        Me.ZIPCODEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CREDITRATINGDataGridViewTextBoxColumn
        '
        Me.CREDITRATINGDataGridViewTextBoxColumn.DataPropertyName = "CREDIT_RATING"
        Me.CREDITRATINGDataGridViewTextBoxColumn.HeaderText = "CREDIT_RATING"
        Me.CREDITRATINGDataGridViewTextBoxColumn.Name = "CREDITRATINGDataGridViewTextBoxColumn"
        Me.CREDITRATINGDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SALESREPIDDataGridViewTextBoxColumn
        '
        Me.SALESREPIDDataGridViewTextBoxColumn.DataPropertyName = "SALES_REP_ID"
        Me.SALESREPIDDataGridViewTextBoxColumn.HeaderText = "SALES_REP_ID"
        Me.SALESREPIDDataGridViewTextBoxColumn.Name = "SALESREPIDDataGridViewTextBoxColumn"
        Me.SALESREPIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'REGIONIDDataGridViewTextBoxColumn
        '
        Me.REGIONIDDataGridViewTextBoxColumn.DataPropertyName = "REGION_ID"
        Me.REGIONIDDataGridViewTextBoxColumn.HeaderText = "REGION_ID"
        Me.REGIONIDDataGridViewTextBoxColumn.Name = "REGIONIDDataGridViewTextBoxColumn"
        Me.REGIONIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'COMMENTSDataGridViewTextBoxColumn
        '
        Me.COMMENTSDataGridViewTextBoxColumn.DataPropertyName = "COMMENTS"
        Me.COMMENTSDataGridViewTextBoxColumn.HeaderText = "COMMENTS"
        Me.COMMENTSDataGridViewTextBoxColumn.Name = "COMMENTSDataGridViewTextBoxColumn"
        Me.COMMENTSDataGridViewTextBoxColumn.ReadOnly = True
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
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.S_CUSTOMERTableAdapter = Me.S_CUSTOMERTableAdapter
        Me.TableAdapterManager.S_DEPTTableAdapter = Nothing
        Me.TableAdapterManager.S_EMPTableAdapter = Nothing
        Me.TableAdapterManager.S_IMAGETableAdapter = Nothing
        Me.TableAdapterManager.S_INVENTORYTableAdapter = Nothing
        Me.TableAdapterManager.S_ITEMTableAdapter = Nothing
        Me.TableAdapterManager.S_LONGTEXTTableAdapter = Nothing
        Me.TableAdapterManager.S_ORDTableAdapter = Nothing
        Me.TableAdapterManager.S_PRODUCTTableAdapter = Nothing
        Me.TableAdapterManager.S_REGIONTableAdapter = Nothing
        Me.TableAdapterManager.S_TITLETableAdapter = Nothing
        Me.TableAdapterManager.S_WAREHOUSETableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = P1CR.DataSetOracleTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'frmClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 461)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnSearchClient)
        Me.Controls.Add(Me.btnSaveClient)
        Me.Controls.Add(Me.btnDeleteClient)
        Me.Controls.Add(Me.btnEditClient)
        Me.Controls.Add(Me.btnAddClient)
        Me.Controls.Add(Me.dgvClients)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.mnuClientes)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.mnuClientes
        Me.Name = "frmClientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Clientes"
        Me.mnuClientes.ResumeLayout(False)
        Me.mnuClientes.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvClients, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.SCUSTOMERBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetOracle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataSetOracle As DataSetOracle
    Friend WithEvents SCUSTOMERBindingSource As BindingSource
    Friend WithEvents S_CUSTOMERTableAdapter As DataSetOracleTableAdapters.S_CUSTOMERTableAdapter
    Friend WithEvents mnuClientes As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VolverAlMenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CerrarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents TableAdapterManager As DataSetOracleTableAdapters.TableAdapterManager
    Friend WithEvents ADDRESSTextBox As TextBox
    Friend WithEvents PHONETextBox As TextBox
    Friend WithEvents NAMETextBox As TextBox
    Friend WithEvents COMMENTSTextBox As TextBox
    Friend WithEvents REGION_IDTextBox As TextBox
    Friend WithEvents CREDIT_RATINGTextBox As TextBox
    Friend WithEvents ZIP_CODETextBox As TextBox
    Friend WithEvents COUNTRYTextBox As TextBox
    Friend WithEvents STATETextBox As TextBox
    Friend WithEvents CITYTextBox As TextBox
    Friend WithEvents dgvClients As DataGridView
    Friend WithEvents btnSearchClient As Button
    Friend WithEvents btnSaveClient As Button
    Friend WithEvents btnDeleteClient As Button
    Friend WithEvents btnEditClient As Button
    Friend WithEvents btnAddClient As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtSearchClient As TextBox
    Friend WithEvents rbNombre As RadioButton
    Friend WithEvents rbID As RadioButton
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
    Friend WithEvents SALES_REP_IDTextBox As TextBox
End Class
