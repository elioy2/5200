<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProductos
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
        Dim IDLabel As System.Windows.Forms.Label
        Dim NAMELabel As System.Windows.Forms.Label
        Dim SHORT_DESCLabel As System.Windows.Forms.Label
        Dim LONGTEXT_IDLabel As System.Windows.Forms.Label
        Dim IMAGE_IDLabel As System.Windows.Forms.Label
        Dim SUGGESTED_WHLSL_PRICELabel As System.Windows.Forms.Label
        Dim WHLSL_UNITSLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProductos))
        Me.btnbuscar = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SHORTDESCDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LONGTEXTIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IMAGEIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SUGGESTEDWHLSLPRICEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WHLSLUNITSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.S_PRODUCTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetOracle = New P1CR.DataSetOracle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtSearchProduct = New System.Windows.Forms.TextBox()
        Me.rbNombre = New System.Windows.Forms.RadioButton()
        Me.rbID = New System.Windows.Forms.RadioButton()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FIleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VolverAlMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.WHLSL_UNITSTextBox = New System.Windows.Forms.TextBox()
        Me.SUGGESTED_WHLSL_PRICETextBox = New System.Windows.Forms.TextBox()
        Me.IMAGE_IDTextBox = New System.Windows.Forms.TextBox()
        Me.LONGTEXT_IDTextBox = New System.Windows.Forms.TextBox()
        Me.SHORT_DESCTextBox = New System.Windows.Forms.TextBox()
        Me.NAMETextBox = New System.Windows.Forms.TextBox()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.S_PRODUCTTableAdapter = New P1CR.DataSetOracleTableAdapters.S_PRODUCTTableAdapter()
        Me.TableAdapterManager = New P1CR.DataSetOracleTableAdapters.TableAdapterManager()
        IDLabel = New System.Windows.Forms.Label()
        NAMELabel = New System.Windows.Forms.Label()
        SHORT_DESCLabel = New System.Windows.Forms.Label()
        LONGTEXT_IDLabel = New System.Windows.Forms.Label()
        IMAGE_IDLabel = New System.Windows.Forms.Label()
        SUGGESTED_WHLSL_PRICELabel = New System.Windows.Forms.Label()
        WHLSL_UNITSLabel = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.S_PRODUCTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetOracle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(65, 33)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(21, 13)
        IDLabel.TabIndex = 0
        IDLabel.Text = "ID:"
        '
        'NAMELabel
        '
        NAMELabel.AutoSize = True
        NAMELabel.Location = New System.Drawing.Point(45, 59)
        NAMELabel.Name = "NAMELabel"
        NAMELabel.Size = New System.Drawing.Size(41, 13)
        NAMELabel.TabIndex = 2
        NAMELabel.Text = "NAME:"
        '
        'SHORT_DESCLabel
        '
        SHORT_DESCLabel.AutoSize = True
        SHORT_DESCLabel.Location = New System.Drawing.Point(6, 101)
        SHORT_DESCLabel.Name = "SHORT_DESCLabel"
        SHORT_DESCLabel.Size = New System.Drawing.Size(80, 13)
        SHORT_DESCLabel.TabIndex = 4
        SHORT_DESCLabel.Text = "SHORT DESC:"
        '
        'LONGTEXT_IDLabel
        '
        LONGTEXT_IDLabel.AutoSize = True
        LONGTEXT_IDLabel.Location = New System.Drawing.Point(352, 116)
        LONGTEXT_IDLabel.Name = "LONGTEXT_IDLabel"
        LONGTEXT_IDLabel.Size = New System.Drawing.Size(82, 13)
        LONGTEXT_IDLabel.TabIndex = 6
        LONGTEXT_IDLabel.Text = "LONGTEXT ID:"
        '
        'IMAGE_IDLabel
        '
        IMAGE_IDLabel.AutoSize = True
        IMAGE_IDLabel.Location = New System.Drawing.Point(376, 35)
        IMAGE_IDLabel.Name = "IMAGE_IDLabel"
        IMAGE_IDLabel.Size = New System.Drawing.Size(58, 13)
        IMAGE_IDLabel.TabIndex = 8
        IMAGE_IDLabel.Text = "IMAGE ID:"
        '
        'SUGGESTED_WHLSL_PRICELabel
        '
        SUGGESTED_WHLSL_PRICELabel.AutoSize = True
        SUGGESTED_WHLSL_PRICELabel.Location = New System.Drawing.Point(281, 64)
        SUGGESTED_WHLSL_PRICELabel.Name = "SUGGESTED_WHLSL_PRICELabel"
        SUGGESTED_WHLSL_PRICELabel.Size = New System.Drawing.Size(153, 13)
        SUGGESTED_WHLSL_PRICELabel.TabIndex = 10
        SUGGESTED_WHLSL_PRICELabel.Text = "SUGGESTED WHLSL PRICE:"
        '
        'WHLSL_UNITSLabel
        '
        WHLSL_UNITSLabel.AutoSize = True
        WHLSL_UNITSLabel.Location = New System.Drawing.Point(350, 90)
        WHLSL_UNITSLabel.Name = "WHLSL_UNITSLabel"
        WHLSL_UNITSLabel.Size = New System.Drawing.Size(84, 13)
        WHLSL_UNITSLabel.TabIndex = 12
        WHLSL_UNITSLabel.Text = "WHLSL UNITS:"
        '
        'btnbuscar
        '
        Me.btnbuscar.Location = New System.Drawing.Point(657, 128)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Size = New System.Drawing.Size(72, 59)
        Me.btnbuscar.TabIndex = 10
        Me.btnbuscar.Text = "Buscar"
        Me.btnbuscar.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(695, 86)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 32)
        Me.btnSave.TabIndex = 15
        Me.btnSave.Text = "Guardar"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(614, 86)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 32)
        Me.btnDelete.TabIndex = 14
        Me.btnDelete.Text = "Borrar"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(695, 41)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 32)
        Me.btnEdit.TabIndex = 13
        Me.btnEdit.Text = "Editar"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(614, 41)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 32)
        Me.btnAdd.TabIndex = 12
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.NAMEDataGridViewTextBoxColumn, Me.SHORTDESCDataGridViewTextBoxColumn, Me.LONGTEXTIDDataGridViewTextBoxColumn, Me.IMAGEIDDataGridViewTextBoxColumn, Me.SUGGESTEDWHLSLPRICEDataGridViewTextBoxColumn, Me.WHLSLUNITSDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.S_PRODUCTBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(204, 195)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(574, 254)
        Me.DataGridView1.TabIndex = 11
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
        'SHORTDESCDataGridViewTextBoxColumn
        '
        Me.SHORTDESCDataGridViewTextBoxColumn.DataPropertyName = "SHORT_DESC"
        Me.SHORTDESCDataGridViewTextBoxColumn.HeaderText = "SHORT_DESC"
        Me.SHORTDESCDataGridViewTextBoxColumn.Name = "SHORTDESCDataGridViewTextBoxColumn"
        Me.SHORTDESCDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LONGTEXTIDDataGridViewTextBoxColumn
        '
        Me.LONGTEXTIDDataGridViewTextBoxColumn.DataPropertyName = "LONGTEXT_ID"
        Me.LONGTEXTIDDataGridViewTextBoxColumn.HeaderText = "LONGTEXT_ID"
        Me.LONGTEXTIDDataGridViewTextBoxColumn.Name = "LONGTEXTIDDataGridViewTextBoxColumn"
        Me.LONGTEXTIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IMAGEIDDataGridViewTextBoxColumn
        '
        Me.IMAGEIDDataGridViewTextBoxColumn.DataPropertyName = "IMAGE_ID"
        Me.IMAGEIDDataGridViewTextBoxColumn.HeaderText = "IMAGE_ID"
        Me.IMAGEIDDataGridViewTextBoxColumn.Name = "IMAGEIDDataGridViewTextBoxColumn"
        Me.IMAGEIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SUGGESTEDWHLSLPRICEDataGridViewTextBoxColumn
        '
        Me.SUGGESTEDWHLSLPRICEDataGridViewTextBoxColumn.DataPropertyName = "SUGGESTED_WHLSL_PRICE"
        Me.SUGGESTEDWHLSLPRICEDataGridViewTextBoxColumn.HeaderText = "SUGGESTED_WHLSL_PRICE"
        Me.SUGGESTEDWHLSLPRICEDataGridViewTextBoxColumn.Name = "SUGGESTEDWHLSLPRICEDataGridViewTextBoxColumn"
        Me.SUGGESTEDWHLSLPRICEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'WHLSLUNITSDataGridViewTextBoxColumn
        '
        Me.WHLSLUNITSDataGridViewTextBoxColumn.DataPropertyName = "WHLSL_UNITS"
        Me.WHLSLUNITSDataGridViewTextBoxColumn.HeaderText = "WHLSL_UNITS"
        Me.WHLSLUNITSDataGridViewTextBoxColumn.Name = "WHLSLUNITSDataGridViewTextBoxColumn"
        Me.WHLSLUNITSDataGridViewTextBoxColumn.ReadOnly = True
        '
        'S_PRODUCTBindingSource
        '
        Me.S_PRODUCTBindingSource.DataMember = "S_PRODUCT"
        Me.S_PRODUCTBindingSource.DataSource = Me.DataSetOracle
        '
        'DataSetOracle
        '
        Me.DataSetOracle.DataSetName = "DataSetOracle"
        Me.DataSetOracle.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtSearchProduct)
        Me.GroupBox1.Controls.Add(Me.rbNombre)
        Me.GroupBox1.Controls.Add(Me.rbID)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 195)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(192, 126)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Seleccionar Metodo De Busqueda"
        '
        'txtSearchProduct
        '
        Me.txtSearchProduct.Location = New System.Drawing.Point(7, 94)
        Me.txtSearchProduct.Name = "txtSearchProduct"
        Me.txtSearchProduct.Size = New System.Drawing.Size(177, 20)
        Me.txtSearchProduct.TabIndex = 0
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
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FIleToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(784, 24)
        Me.MenuStrip1.TabIndex = 16
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FIleToolStripMenuItem
        '
        Me.FIleToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VolverAlMenuToolStripMenuItem, Me.CerrarToolStripMenuItem})
        Me.FIleToolStripMenuItem.Name = "FIleToolStripMenuItem"
        Me.FIleToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FIleToolStripMenuItem.Text = "&File"
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
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(WHLSL_UNITSLabel)
        Me.GroupBox2.Controls.Add(Me.WHLSL_UNITSTextBox)
        Me.GroupBox2.Controls.Add(SUGGESTED_WHLSL_PRICELabel)
        Me.GroupBox2.Controls.Add(Me.SUGGESTED_WHLSL_PRICETextBox)
        Me.GroupBox2.Controls.Add(IMAGE_IDLabel)
        Me.GroupBox2.Controls.Add(Me.IMAGE_IDTextBox)
        Me.GroupBox2.Controls.Add(LONGTEXT_IDLabel)
        Me.GroupBox2.Controls.Add(Me.LONGTEXT_IDTextBox)
        Me.GroupBox2.Controls.Add(SHORT_DESCLabel)
        Me.GroupBox2.Controls.Add(Me.SHORT_DESCTextBox)
        Me.GroupBox2.Controls.Add(NAMELabel)
        Me.GroupBox2.Controls.Add(Me.NAMETextBox)
        Me.GroupBox2.Controls.Add(IDLabel)
        Me.GroupBox2.Controls.Add(Me.IDTextBox)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 27)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(586, 162)
        Me.GroupBox2.TabIndex = 17
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Información del Producto"
        '
        'WHLSL_UNITSTextBox
        '
        Me.WHLSL_UNITSTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.S_PRODUCTBindingSource, "WHLSL_UNITS", True))
        Me.WHLSL_UNITSTextBox.Enabled = False
        Me.WHLSL_UNITSTextBox.Location = New System.Drawing.Point(440, 87)
        Me.WHLSL_UNITSTextBox.Name = "WHLSL_UNITSTextBox"
        Me.WHLSL_UNITSTextBox.Size = New System.Drawing.Size(100, 20)
        Me.WHLSL_UNITSTextBox.TabIndex = 13
        '
        'SUGGESTED_WHLSL_PRICETextBox
        '
        Me.SUGGESTED_WHLSL_PRICETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.S_PRODUCTBindingSource, "SUGGESTED_WHLSL_PRICE", True))
        Me.SUGGESTED_WHLSL_PRICETextBox.Enabled = False
        Me.SUGGESTED_WHLSL_PRICETextBox.Location = New System.Drawing.Point(440, 61)
        Me.SUGGESTED_WHLSL_PRICETextBox.Name = "SUGGESTED_WHLSL_PRICETextBox"
        Me.SUGGESTED_WHLSL_PRICETextBox.Size = New System.Drawing.Size(100, 20)
        Me.SUGGESTED_WHLSL_PRICETextBox.TabIndex = 11
        '
        'IMAGE_IDTextBox
        '
        Me.IMAGE_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.S_PRODUCTBindingSource, "IMAGE_ID", True))
        Me.IMAGE_IDTextBox.Enabled = False
        Me.IMAGE_IDTextBox.Location = New System.Drawing.Point(440, 32)
        Me.IMAGE_IDTextBox.Name = "IMAGE_IDTextBox"
        Me.IMAGE_IDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IMAGE_IDTextBox.TabIndex = 9
        '
        'LONGTEXT_IDTextBox
        '
        Me.LONGTEXT_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.S_PRODUCTBindingSource, "LONGTEXT_ID", True))
        Me.LONGTEXT_IDTextBox.Enabled = False
        Me.LONGTEXT_IDTextBox.Location = New System.Drawing.Point(440, 113)
        Me.LONGTEXT_IDTextBox.Name = "LONGTEXT_IDTextBox"
        Me.LONGTEXT_IDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.LONGTEXT_IDTextBox.TabIndex = 7
        '
        'SHORT_DESCTextBox
        '
        Me.SHORT_DESCTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.S_PRODUCTBindingSource, "SHORT_DESC", True))
        Me.SHORT_DESCTextBox.Enabled = False
        Me.SHORT_DESCTextBox.Location = New System.Drawing.Point(92, 98)
        Me.SHORT_DESCTextBox.Multiline = True
        Me.SHORT_DESCTextBox.Name = "SHORT_DESCTextBox"
        Me.SHORT_DESCTextBox.Size = New System.Drawing.Size(147, 48)
        Me.SHORT_DESCTextBox.TabIndex = 5
        '
        'NAMETextBox
        '
        Me.NAMETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.S_PRODUCTBindingSource, "NAME", True))
        Me.NAMETextBox.Enabled = False
        Me.NAMETextBox.Location = New System.Drawing.Point(92, 56)
        Me.NAMETextBox.Multiline = True
        Me.NAMETextBox.Name = "NAMETextBox"
        Me.NAMETextBox.Size = New System.Drawing.Size(147, 32)
        Me.NAMETextBox.TabIndex = 3
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.S_PRODUCTBindingSource, "ID", True))
        Me.IDTextBox.Enabled = False
        Me.IDTextBox.Location = New System.Drawing.Point(92, 30)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(147, 20)
        Me.IDTextBox.TabIndex = 1
        '
        'S_PRODUCTTableAdapter
        '
        Me.S_PRODUCTTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.S_CUSTOMERTableAdapter = Nothing
        Me.TableAdapterManager.S_DEPTTableAdapter = Nothing
        Me.TableAdapterManager.S_EMPTableAdapter = Nothing
        Me.TableAdapterManager.S_IMAGETableAdapter = Nothing
        Me.TableAdapterManager.S_INVENTORYTableAdapter = Nothing
        Me.TableAdapterManager.S_ITEMTableAdapter = Nothing
        Me.TableAdapterManager.S_LONGTEXTTableAdapter = Nothing
        Me.TableAdapterManager.S_ORDTableAdapter = Nothing
        Me.TableAdapterManager.S_PRODUCTTableAdapter = Me.S_PRODUCTTableAdapter
        Me.TableAdapterManager.S_REGIONTableAdapter = Nothing
        Me.TableAdapterManager.S_TITLETableAdapter = Nothing
        Me.TableAdapterManager.S_WAREHOUSETableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = P1CR.DataSetOracleTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'frmProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 461)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnbuscar)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmProductos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Productos"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.S_PRODUCTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetOracle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnbuscar As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtSearchProduct As TextBox
    Friend WithEvents rbNombre As RadioButton
    Friend WithEvents rbID As RadioButton
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FIleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VolverAlMenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CerrarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DataSetOracle As DataSetOracle
    Friend WithEvents S_PRODUCTBindingSource As BindingSource
    Friend WithEvents S_PRODUCTTableAdapter As DataSetOracleTableAdapters.S_PRODUCTTableAdapter
    Friend WithEvents TableAdapterManager As DataSetOracleTableAdapters.TableAdapterManager
    Friend WithEvents WHLSL_UNITSTextBox As TextBox
    Friend WithEvents SUGGESTED_WHLSL_PRICETextBox As TextBox
    Friend WithEvents IMAGE_IDTextBox As TextBox
    Friend WithEvents LONGTEXT_IDTextBox As TextBox
    Friend WithEvents SHORT_DESCTextBox As TextBox
    Friend WithEvents NAMETextBox As TextBox
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NAMEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SHORTDESCDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LONGTEXTIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IMAGEIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SUGGESTEDWHLSLPRICEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents WHLSLUNITSDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
