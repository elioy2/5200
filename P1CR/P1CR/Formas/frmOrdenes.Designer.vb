<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmOrdenes
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
        Dim CUSTOMER_IDLabel As System.Windows.Forms.Label
        Dim DATE_ORDEREDLabel As System.Windows.Forms.Label
        Dim DATE_SHIPPEDLabel As System.Windows.Forms.Label
        Dim SALES_REP_IDLabel As System.Windows.Forms.Label
        Dim TOTALLabel As System.Windows.Forms.Label
        Dim PAYMENT_TYPELabel As System.Windows.Forms.Label
        Dim ORDER_FILLEDLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOrdenes))
        Me.btnbuscar = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtSearchOrder = New System.Windows.Forms.TextBox()
        Me.rbCustID = New System.Windows.Forms.RadioButton()
        Me.rbID = New System.Windows.Forms.RadioButton()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FIleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VolverAlMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ORDER_FILLEDTextBox = New System.Windows.Forms.TextBox()
        Me.PAYMENT_TYPETextBox = New System.Windows.Forms.TextBox()
        Me.TOTALTextBox = New System.Windows.Forms.TextBox()
        Me.SALES_REP_IDTextBox = New System.Windows.Forms.TextBox()
        Me.DATE_SHIPPEDDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.DATE_ORDEREDDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.CUSTOMER_IDTextBox = New System.Windows.Forms.TextBox()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.S_ORDBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetOracle = New P1CR.DataSetOracle()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CUSTOMERIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DATEORDEREDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DATESHIPPEDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SALESREPIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TOTALDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PAYMENTTYPEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ORDERFILLEDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.S_ORDTableAdapter = New P1CR.DataSetOracleTableAdapters.S_ORDTableAdapter()
        Me.TableAdapterManager = New P1CR.DataSetOracleTableAdapters.TableAdapterManager()
        IDLabel = New System.Windows.Forms.Label()
        CUSTOMER_IDLabel = New System.Windows.Forms.Label()
        DATE_ORDEREDLabel = New System.Windows.Forms.Label()
        DATE_SHIPPEDLabel = New System.Windows.Forms.Label()
        SALES_REP_IDLabel = New System.Windows.Forms.Label()
        TOTALLabel = New System.Windows.Forms.Label()
        PAYMENT_TYPELabel = New System.Windows.Forms.Label()
        ORDER_FILLEDLabel = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.S_ORDBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetOracle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(83, 28)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(21, 13)
        IDLabel.TabIndex = 0
        IDLabel.Text = "ID:"
        '
        'CUSTOMER_IDLabel
        '
        CUSTOMER_IDLabel.AutoSize = True
        CUSTOMER_IDLabel.Location = New System.Drawing.Point(19, 56)
        CUSTOMER_IDLabel.Name = "CUSTOMER_IDLabel"
        CUSTOMER_IDLabel.Size = New System.Drawing.Size(85, 13)
        CUSTOMER_IDLabel.TabIndex = 2
        CUSTOMER_IDLabel.Text = "CUSTOMER ID:"
        '
        'DATE_ORDEREDLabel
        '
        DATE_ORDEREDLabel.AutoSize = True
        DATE_ORDEREDLabel.Location = New System.Drawing.Point(8, 87)
        DATE_ORDEREDLabel.Name = "DATE_ORDEREDLabel"
        DATE_ORDEREDLabel.Size = New System.Drawing.Size(96, 13)
        DATE_ORDEREDLabel.TabIndex = 4
        DATE_ORDEREDLabel.Text = "DATE ORDERED:"
        '
        'DATE_SHIPPEDLabel
        '
        DATE_SHIPPEDLabel.AutoSize = True
        DATE_SHIPPEDLabel.Location = New System.Drawing.Point(15, 119)
        DATE_SHIPPEDLabel.Name = "DATE_SHIPPEDLabel"
        DATE_SHIPPEDLabel.Size = New System.Drawing.Size(89, 13)
        DATE_SHIPPEDLabel.TabIndex = 6
        DATE_SHIPPEDLabel.Text = "DATE SHIPPED:"
        '
        'SALES_REP_IDLabel
        '
        SALES_REP_IDLabel.AutoSize = True
        SALES_REP_IDLabel.Location = New System.Drawing.Point(385, 28)
        SALES_REP_IDLabel.Name = "SALES_REP_IDLabel"
        SALES_REP_IDLabel.Size = New System.Drawing.Size(83, 13)
        SALES_REP_IDLabel.TabIndex = 8
        SALES_REP_IDLabel.Text = "SALES REP ID:"
        '
        'TOTALLabel
        '
        TOTALLabel.AutoSize = True
        TOTALLabel.Location = New System.Drawing.Point(423, 57)
        TOTALLabel.Name = "TOTALLabel"
        TOTALLabel.Size = New System.Drawing.Size(45, 13)
        TOTALLabel.TabIndex = 10
        TOTALLabel.Text = "TOTAL:"
        '
        'PAYMENT_TYPELabel
        '
        PAYMENT_TYPELabel.AutoSize = True
        PAYMENT_TYPELabel.Location = New System.Drawing.Point(375, 85)
        PAYMENT_TYPELabel.Name = "PAYMENT_TYPELabel"
        PAYMENT_TYPELabel.Size = New System.Drawing.Size(93, 13)
        PAYMENT_TYPELabel.TabIndex = 12
        PAYMENT_TYPELabel.Text = "PAYMENT TYPE:"
        '
        'ORDER_FILLEDLabel
        '
        ORDER_FILLEDLabel.AutoSize = True
        ORDER_FILLEDLabel.Location = New System.Drawing.Point(380, 115)
        ORDER_FILLEDLabel.Name = "ORDER_FILLEDLabel"
        ORDER_FILLEDLabel.Size = New System.Drawing.Size(88, 13)
        ORDER_FILLEDLabel.TabIndex = 14
        ORDER_FILLEDLabel.Text = "ORDER FILLED:"
        '
        'btnbuscar
        '
        Me.btnbuscar.Location = New System.Drawing.Point(659, 119)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Size = New System.Drawing.Size(72, 59)
        Me.btnbuscar.TabIndex = 18
        Me.btnbuscar.Text = "Buscar"
        Me.btnbuscar.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(697, 77)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 32)
        Me.btnSave.TabIndex = 23
        Me.btnSave.Text = "Guardar"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(616, 77)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 32)
        Me.btnDelete.TabIndex = 22
        Me.btnDelete.Text = "Borrar"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(697, 32)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 32)
        Me.btnEdit.TabIndex = 21
        Me.btnEdit.Text = "Editar"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(616, 32)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 32)
        Me.btnAdd.TabIndex = 20
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.CUSTOMERIDDataGridViewTextBoxColumn, Me.DATEORDEREDDataGridViewTextBoxColumn, Me.DATESHIPPEDDataGridViewTextBoxColumn, Me.SALESREPIDDataGridViewTextBoxColumn, Me.TOTALDataGridViewTextBoxColumn, Me.PAYMENTTYPEDataGridViewTextBoxColumn, Me.ORDERFILLEDDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.S_ORDBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(204, 201)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(574, 254)
        Me.DataGridView1.TabIndex = 19
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtSearchOrder)
        Me.GroupBox1.Controls.Add(Me.rbCustID)
        Me.GroupBox1.Controls.Add(Me.rbID)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 201)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(192, 126)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Seleccionar Metodo De Busqueda"
        '
        'txtSearchOrder
        '
        Me.txtSearchOrder.Location = New System.Drawing.Point(9, 94)
        Me.txtSearchOrder.Name = "txtSearchOrder"
        Me.txtSearchOrder.Size = New System.Drawing.Size(177, 20)
        Me.txtSearchOrder.TabIndex = 0
        '
        'rbCustID
        '
        Me.rbCustID.AutoSize = True
        Me.rbCustID.Location = New System.Drawing.Point(18, 55)
        Me.rbCustID.Name = "rbCustID"
        Me.rbCustID.Size = New System.Drawing.Size(83, 17)
        Me.rbCustID.TabIndex = 1
        Me.rbCustID.TabStop = True
        Me.rbCustID.Text = "Customer ID"
        Me.rbCustID.UseVisualStyleBackColor = True
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
        Me.MenuStrip1.TabIndex = 24
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
        Me.GroupBox2.Controls.Add(ORDER_FILLEDLabel)
        Me.GroupBox2.Controls.Add(Me.ORDER_FILLEDTextBox)
        Me.GroupBox2.Controls.Add(PAYMENT_TYPELabel)
        Me.GroupBox2.Controls.Add(Me.PAYMENT_TYPETextBox)
        Me.GroupBox2.Controls.Add(TOTALLabel)
        Me.GroupBox2.Controls.Add(Me.TOTALTextBox)
        Me.GroupBox2.Controls.Add(SALES_REP_IDLabel)
        Me.GroupBox2.Controls.Add(Me.SALES_REP_IDTextBox)
        Me.GroupBox2.Controls.Add(DATE_SHIPPEDLabel)
        Me.GroupBox2.Controls.Add(Me.DATE_SHIPPEDDateTimePicker)
        Me.GroupBox2.Controls.Add(DATE_ORDEREDLabel)
        Me.GroupBox2.Controls.Add(Me.DATE_ORDEREDDateTimePicker)
        Me.GroupBox2.Controls.Add(CUSTOMER_IDLabel)
        Me.GroupBox2.Controls.Add(Me.CUSTOMER_IDTextBox)
        Me.GroupBox2.Controls.Add(IDLabel)
        Me.GroupBox2.Controls.Add(Me.IDTextBox)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 27)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(604, 166)
        Me.GroupBox2.TabIndex = 25
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Información de la orden"
        '
        'ORDER_FILLEDTextBox
        '
        Me.ORDER_FILLEDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.S_ORDBindingSource, "ORDER_FILLED", True))
        Me.ORDER_FILLEDTextBox.Enabled = False
        Me.ORDER_FILLEDTextBox.Location = New System.Drawing.Point(474, 112)
        Me.ORDER_FILLEDTextBox.Name = "ORDER_FILLEDTextBox"
        Me.ORDER_FILLEDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ORDER_FILLEDTextBox.TabIndex = 15
        '
        'PAYMENT_TYPETextBox
        '
        Me.PAYMENT_TYPETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.S_ORDBindingSource, "PAYMENT_TYPE", True))
        Me.PAYMENT_TYPETextBox.Enabled = False
        Me.PAYMENT_TYPETextBox.Location = New System.Drawing.Point(474, 82)
        Me.PAYMENT_TYPETextBox.Name = "PAYMENT_TYPETextBox"
        Me.PAYMENT_TYPETextBox.Size = New System.Drawing.Size(100, 20)
        Me.PAYMENT_TYPETextBox.TabIndex = 13
        '
        'TOTALTextBox
        '
        Me.TOTALTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.S_ORDBindingSource, "TOTAL", True))
        Me.TOTALTextBox.Enabled = False
        Me.TOTALTextBox.Location = New System.Drawing.Point(474, 54)
        Me.TOTALTextBox.Name = "TOTALTextBox"
        Me.TOTALTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TOTALTextBox.TabIndex = 11
        '
        'SALES_REP_IDTextBox
        '
        Me.SALES_REP_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.S_ORDBindingSource, "SALES_REP_ID", True))
        Me.SALES_REP_IDTextBox.Enabled = False
        Me.SALES_REP_IDTextBox.Location = New System.Drawing.Point(474, 25)
        Me.SALES_REP_IDTextBox.Name = "SALES_REP_IDTextBox"
        Me.SALES_REP_IDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SALES_REP_IDTextBox.TabIndex = 9
        '
        'DATE_SHIPPEDDateTimePicker
        '
        Me.DATE_SHIPPEDDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.S_ORDBindingSource, "DATE_SHIPPED", True))
        Me.DATE_SHIPPEDDateTimePicker.Enabled = False
        Me.DATE_SHIPPEDDateTimePicker.Location = New System.Drawing.Point(110, 115)
        Me.DATE_SHIPPEDDateTimePicker.Name = "DATE_SHIPPEDDateTimePicker"
        Me.DATE_SHIPPEDDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.DATE_SHIPPEDDateTimePicker.TabIndex = 7
        '
        'DATE_ORDEREDDateTimePicker
        '
        Me.DATE_ORDEREDDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.S_ORDBindingSource, "DATE_ORDERED", True))
        Me.DATE_ORDEREDDateTimePicker.Enabled = False
        Me.DATE_ORDEREDDateTimePicker.Location = New System.Drawing.Point(110, 83)
        Me.DATE_ORDEREDDateTimePicker.Name = "DATE_ORDEREDDateTimePicker"
        Me.DATE_ORDEREDDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.DATE_ORDEREDDateTimePicker.TabIndex = 5
        '
        'CUSTOMER_IDTextBox
        '
        Me.CUSTOMER_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.S_ORDBindingSource, "CUSTOMER_ID", True))
        Me.CUSTOMER_IDTextBox.Enabled = False
        Me.CUSTOMER_IDTextBox.Location = New System.Drawing.Point(110, 57)
        Me.CUSTOMER_IDTextBox.Name = "CUSTOMER_IDTextBox"
        Me.CUSTOMER_IDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CUSTOMER_IDTextBox.TabIndex = 3
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.S_ORDBindingSource, "ID", True))
        Me.IDTextBox.Enabled = False
        Me.IDTextBox.Location = New System.Drawing.Point(110, 28)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IDTextBox.TabIndex = 1
        '
        'S_ORDBindingSource
        '
        Me.S_ORDBindingSource.DataMember = "S_ORD"
        Me.S_ORDBindingSource.DataSource = Me.DataSetOracle
        '
        'DataSetOracle
        '
        Me.DataSetOracle.DataSetName = "DataSetOracle"
        Me.DataSetOracle.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CUSTOMERIDDataGridViewTextBoxColumn
        '
        Me.CUSTOMERIDDataGridViewTextBoxColumn.DataPropertyName = "CUSTOMER_ID"
        Me.CUSTOMERIDDataGridViewTextBoxColumn.HeaderText = "CUSTOMER_ID"
        Me.CUSTOMERIDDataGridViewTextBoxColumn.Name = "CUSTOMERIDDataGridViewTextBoxColumn"
        Me.CUSTOMERIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DATEORDEREDDataGridViewTextBoxColumn
        '
        Me.DATEORDEREDDataGridViewTextBoxColumn.DataPropertyName = "DATE_ORDERED"
        Me.DATEORDEREDDataGridViewTextBoxColumn.HeaderText = "DATE_ORDERED"
        Me.DATEORDEREDDataGridViewTextBoxColumn.Name = "DATEORDEREDDataGridViewTextBoxColumn"
        Me.DATEORDEREDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DATESHIPPEDDataGridViewTextBoxColumn
        '
        Me.DATESHIPPEDDataGridViewTextBoxColumn.DataPropertyName = "DATE_SHIPPED"
        Me.DATESHIPPEDDataGridViewTextBoxColumn.HeaderText = "DATE_SHIPPED"
        Me.DATESHIPPEDDataGridViewTextBoxColumn.Name = "DATESHIPPEDDataGridViewTextBoxColumn"
        Me.DATESHIPPEDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SALESREPIDDataGridViewTextBoxColumn
        '
        Me.SALESREPIDDataGridViewTextBoxColumn.DataPropertyName = "SALES_REP_ID"
        Me.SALESREPIDDataGridViewTextBoxColumn.HeaderText = "SALES_REP_ID"
        Me.SALESREPIDDataGridViewTextBoxColumn.Name = "SALESREPIDDataGridViewTextBoxColumn"
        Me.SALESREPIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TOTALDataGridViewTextBoxColumn
        '
        Me.TOTALDataGridViewTextBoxColumn.DataPropertyName = "TOTAL"
        Me.TOTALDataGridViewTextBoxColumn.HeaderText = "TOTAL"
        Me.TOTALDataGridViewTextBoxColumn.Name = "TOTALDataGridViewTextBoxColumn"
        Me.TOTALDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PAYMENTTYPEDataGridViewTextBoxColumn
        '
        Me.PAYMENTTYPEDataGridViewTextBoxColumn.DataPropertyName = "PAYMENT_TYPE"
        Me.PAYMENTTYPEDataGridViewTextBoxColumn.HeaderText = "PAYMENT_TYPE"
        Me.PAYMENTTYPEDataGridViewTextBoxColumn.Name = "PAYMENTTYPEDataGridViewTextBoxColumn"
        Me.PAYMENTTYPEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ORDERFILLEDDataGridViewTextBoxColumn
        '
        Me.ORDERFILLEDDataGridViewTextBoxColumn.DataPropertyName = "ORDER_FILLED"
        Me.ORDERFILLEDDataGridViewTextBoxColumn.HeaderText = "ORDER_FILLED"
        Me.ORDERFILLEDDataGridViewTextBoxColumn.Name = "ORDERFILLEDDataGridViewTextBoxColumn"
        Me.ORDERFILLEDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'S_ORDTableAdapter
        '
        Me.S_ORDTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.S_ORDTableAdapter = Me.S_ORDTableAdapter
        Me.TableAdapterManager.S_PRODUCTTableAdapter = Nothing
        Me.TableAdapterManager.S_REGIONTableAdapter = Nothing
        Me.TableAdapterManager.S_TITLETableAdapter = Nothing
        Me.TableAdapterManager.S_WAREHOUSETableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = P1CR.DataSetOracleTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'frmOrdenes
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
        Me.Name = "frmOrdenes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ordenes"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.S_ORDBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetOracle, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents txtSearchOrder As TextBox
    Friend WithEvents rbCustID As RadioButton
    Friend WithEvents rbID As RadioButton
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FIleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VolverAlMenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CerrarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DataSetOracle As DataSetOracle
    Friend WithEvents S_ORDBindingSource As BindingSource
    Friend WithEvents S_ORDTableAdapter As DataSetOracleTableAdapters.S_ORDTableAdapter
    Friend WithEvents TableAdapterManager As DataSetOracleTableAdapters.TableAdapterManager
    Friend WithEvents PAYMENT_TYPETextBox As TextBox
    Friend WithEvents TOTALTextBox As TextBox
    Friend WithEvents SALES_REP_IDTextBox As TextBox
    Friend WithEvents DATE_SHIPPEDDateTimePicker As DateTimePicker
    Friend WithEvents DATE_ORDEREDDateTimePicker As DateTimePicker
    Friend WithEvents CUSTOMER_IDTextBox As TextBox
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CUSTOMERIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DATEORDEREDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DATESHIPPEDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SALESREPIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TOTALDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PAYMENTTYPEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ORDERFILLEDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ORDER_FILLEDTextBox As TextBox
End Class
