<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmEmpleados
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
        Dim LAST_NAMELabel As System.Windows.Forms.Label
        Dim FIRST_NAMELabel As System.Windows.Forms.Label
        Dim USERIDLabel As System.Windows.Forms.Label
        Dim START_DATELabel As System.Windows.Forms.Label
        Dim COMMENTSLabel As System.Windows.Forms.Label
        Dim MANAGER_IDLabel As System.Windows.Forms.Label
        Dim TITLELabel As System.Windows.Forms.Label
        Dim DEPT_IDLabel As System.Windows.Forms.Label
        Dim SALARYLabel As System.Windows.Forms.Label
        Dim COMMISSION_PCTLabel As System.Windows.Forms.Label
        Dim PASSWORDLabel As System.Windows.Forms.Label
        Dim STATUSLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEmpleados))
        Me.rbID = New System.Windows.Forms.RadioButton()
        Me.rbNombre = New System.Windows.Forms.RadioButton()
        Me.txtSearchEmp = New System.Windows.Forms.TextBox()
        Me.btnbuscar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.gbempinfo = New System.Windows.Forms.GroupBox()
        Me.STATUSTextBox = New System.Windows.Forms.TextBox()
        Me.PASSWORDTextBox = New System.Windows.Forms.TextBox()
        Me.COMMISSION_PCTTextBox = New System.Windows.Forms.TextBox()
        Me.SALARYTextBox = New System.Windows.Forms.TextBox()
        Me.DEPT_IDTextBox = New System.Windows.Forms.TextBox()
        Me.TITLETextBox = New System.Windows.Forms.TextBox()
        Me.MANAGER_IDTextBox = New System.Windows.Forms.TextBox()
        Me.COMMENTSTextBox = New System.Windows.Forms.TextBox()
        Me.START_DATEDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.USERIDTextBox = New System.Windows.Forms.TextBox()
        Me.FIRST_NAMETextBox = New System.Windows.Forms.TextBox()
        Me.LAST_NAMETextBox = New System.Windows.Forms.TextBox()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VolverAlMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.S_EMPBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetOracle = New P1CR.DataSetOracle()
        Me.S_EMPTableAdapter = New P1CR.DataSetOracleTableAdapters.S_EMPTableAdapter()
        Me.TableAdapterManager = New P1CR.DataSetOracleTableAdapters.TableAdapterManager()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LASTNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FIRSTNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.USERIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.STARTDATEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MANAGERIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TITLEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DEPTIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SALARYDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.STATUSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        IDLabel = New System.Windows.Forms.Label()
        LAST_NAMELabel = New System.Windows.Forms.Label()
        FIRST_NAMELabel = New System.Windows.Forms.Label()
        USERIDLabel = New System.Windows.Forms.Label()
        START_DATELabel = New System.Windows.Forms.Label()
        COMMENTSLabel = New System.Windows.Forms.Label()
        MANAGER_IDLabel = New System.Windows.Forms.Label()
        TITLELabel = New System.Windows.Forms.Label()
        DEPT_IDLabel = New System.Windows.Forms.Label()
        SALARYLabel = New System.Windows.Forms.Label()
        COMMISSION_PCTLabel = New System.Windows.Forms.Label()
        PASSWORDLabel = New System.Windows.Forms.Label()
        STATUSLabel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.gbempinfo.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.S_EMPBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetOracle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(16, 28)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(21, 13)
        IDLabel.TabIndex = 0
        IDLabel.Text = "ID:"
        '
        'LAST_NAMELabel
        '
        LAST_NAMELabel.AutoSize = True
        LAST_NAMELabel.Location = New System.Drawing.Point(6, 54)
        LAST_NAMELabel.Name = "LAST_NAMELabel"
        LAST_NAMELabel.Size = New System.Drawing.Size(71, 13)
        LAST_NAMELabel.TabIndex = 2
        LAST_NAMELabel.Text = "LAST NAME:"
        '
        'FIRST_NAMELabel
        '
        FIRST_NAMELabel.AutoSize = True
        FIRST_NAMELabel.Location = New System.Drawing.Point(2, 80)
        FIRST_NAMELabel.Name = "FIRST_NAMELabel"
        FIRST_NAMELabel.Size = New System.Drawing.Size(75, 13)
        FIRST_NAMELabel.TabIndex = 4
        FIRST_NAMELabel.Text = "FIRST NAME:"
        '
        'USERIDLabel
        '
        USERIDLabel.AutoSize = True
        USERIDLabel.Location = New System.Drawing.Point(26, 106)
        USERIDLabel.Name = "USERIDLabel"
        USERIDLabel.Size = New System.Drawing.Size(51, 13)
        USERIDLabel.TabIndex = 6
        USERIDLabel.Text = "USERID:"
        '
        'START_DATELabel
        '
        START_DATELabel.AutoSize = True
        START_DATELabel.Location = New System.Drawing.Point(6, 143)
        START_DATELabel.Name = "START_DATELabel"
        START_DATELabel.Size = New System.Drawing.Size(78, 13)
        START_DATELabel.TabIndex = 8
        START_DATELabel.Text = "START DATE:"
        '
        'COMMENTSLabel
        '
        COMMENTSLabel.AutoSize = True
        COMMENTSLabel.Location = New System.Drawing.Point(298, 145)
        COMMENTSLabel.Name = "COMMENTSLabel"
        COMMENTSLabel.Size = New System.Drawing.Size(72, 13)
        COMMENTSLabel.TabIndex = 10
        COMMENTSLabel.Text = "COMMENTS:"
        '
        'MANAGER_IDLabel
        '
        MANAGER_IDLabel.AutoSize = True
        MANAGER_IDLabel.Location = New System.Drawing.Point(191, 31)
        MANAGER_IDLabel.Name = "MANAGER_IDLabel"
        MANAGER_IDLabel.Size = New System.Drawing.Size(78, 13)
        MANAGER_IDLabel.TabIndex = 12
        MANAGER_IDLabel.Text = "MANAGER ID:"
        '
        'TITLELabel
        '
        TITLELabel.AutoSize = True
        TITLELabel.Location = New System.Drawing.Point(229, 57)
        TITLELabel.Name = "TITLELabel"
        TITLELabel.Size = New System.Drawing.Size(40, 13)
        TITLELabel.TabIndex = 14
        TITLELabel.Text = "TITLE:"
        '
        'DEPT_IDLabel
        '
        DEPT_IDLabel.AutoSize = True
        DEPT_IDLabel.Location = New System.Drawing.Point(216, 83)
        DEPT_IDLabel.Name = "DEPT_IDLabel"
        DEPT_IDLabel.Size = New System.Drawing.Size(53, 13)
        DEPT_IDLabel.TabIndex = 16
        DEPT_IDLabel.Text = "DEPT ID:"
        '
        'SALARYLabel
        '
        SALARYLabel.AutoSize = True
        SALARYLabel.Location = New System.Drawing.Point(217, 109)
        SALARYLabel.Name = "SALARYLabel"
        SALARYLabel.Size = New System.Drawing.Size(52, 13)
        SALARYLabel.TabIndex = 18
        SALARYLabel.Text = "SALARY:"
        '
        'COMMISSION_PCTLabel
        '
        COMMISSION_PCTLabel.AutoSize = True
        COMMISSION_PCTLabel.Location = New System.Drawing.Point(384, 29)
        COMMISSION_PCTLabel.Name = "COMMISSION_PCTLabel"
        COMMISSION_PCTLabel.Size = New System.Drawing.Size(103, 13)
        COMMISSION_PCTLabel.TabIndex = 20
        COMMISSION_PCTLabel.Text = "COMMISSION PCT:"
        '
        'PASSWORDLabel
        '
        PASSWORDLabel.AutoSize = True
        PASSWORDLabel.Location = New System.Drawing.Point(414, 55)
        PASSWORDLabel.Name = "PASSWORDLabel"
        PASSWORDLabel.Size = New System.Drawing.Size(73, 13)
        PASSWORDLabel.TabIndex = 22
        PASSWORDLabel.Text = "PASSWORD:"
        '
        'STATUSLabel
        '
        STATUSLabel.AutoSize = True
        STATUSLabel.Location = New System.Drawing.Point(434, 81)
        STATUSLabel.Name = "STATUSLabel"
        STATUSLabel.Size = New System.Drawing.Size(53, 13)
        STATUSLabel.TabIndex = 24
        STATUSLabel.Text = "STATUS:"
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
        'txtSearchEmp
        '
        Me.txtSearchEmp.Location = New System.Drawing.Point(0, 94)
        Me.txtSearchEmp.Name = "txtSearchEmp"
        Me.txtSearchEmp.Size = New System.Drawing.Size(177, 20)
        Me.txtSearchEmp.TabIndex = 0
        '
        'btnbuscar
        '
        Me.btnbuscar.Location = New System.Drawing.Point(658, 126)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Size = New System.Drawing.Size(72, 59)
        Me.btnbuscar.TabIndex = 2
        Me.btnbuscar.Text = "Buscar"
        Me.btnbuscar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtSearchEmp)
        Me.GroupBox1.Controls.Add(Me.rbNombre)
        Me.GroupBox1.Controls.Add(Me.rbID)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 205)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(192, 120)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Seleccionar Metodo De Busqueda"
        '
        'gbempinfo
        '
        Me.gbempinfo.Controls.Add(STATUSLabel)
        Me.gbempinfo.Controls.Add(Me.STATUSTextBox)
        Me.gbempinfo.Controls.Add(PASSWORDLabel)
        Me.gbempinfo.Controls.Add(Me.PASSWORDTextBox)
        Me.gbempinfo.Controls.Add(COMMISSION_PCTLabel)
        Me.gbempinfo.Controls.Add(Me.COMMISSION_PCTTextBox)
        Me.gbempinfo.Controls.Add(SALARYLabel)
        Me.gbempinfo.Controls.Add(Me.SALARYTextBox)
        Me.gbempinfo.Controls.Add(DEPT_IDLabel)
        Me.gbempinfo.Controls.Add(Me.DEPT_IDTextBox)
        Me.gbempinfo.Controls.Add(TITLELabel)
        Me.gbempinfo.Controls.Add(Me.TITLETextBox)
        Me.gbempinfo.Controls.Add(MANAGER_IDLabel)
        Me.gbempinfo.Controls.Add(Me.MANAGER_IDTextBox)
        Me.gbempinfo.Controls.Add(COMMENTSLabel)
        Me.gbempinfo.Controls.Add(Me.COMMENTSTextBox)
        Me.gbempinfo.Controls.Add(START_DATELabel)
        Me.gbempinfo.Controls.Add(Me.START_DATEDateTimePicker)
        Me.gbempinfo.Controls.Add(USERIDLabel)
        Me.gbempinfo.Controls.Add(Me.USERIDTextBox)
        Me.gbempinfo.Controls.Add(FIRST_NAMELabel)
        Me.gbempinfo.Controls.Add(Me.FIRST_NAMETextBox)
        Me.gbempinfo.Controls.Add(LAST_NAMELabel)
        Me.gbempinfo.Controls.Add(Me.LAST_NAMETextBox)
        Me.gbempinfo.Controls.Add(IDLabel)
        Me.gbempinfo.Controls.Add(Me.IDTextBox)
        Me.gbempinfo.Location = New System.Drawing.Point(12, 27)
        Me.gbempinfo.Name = "gbempinfo"
        Me.gbempinfo.Size = New System.Drawing.Size(597, 172)
        Me.gbempinfo.TabIndex = 2
        Me.gbempinfo.TabStop = False
        Me.gbempinfo.Text = "Información de Empleado"
        '
        'STATUSTextBox
        '
        Me.STATUSTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.S_EMPBindingSource, "STATUS", True))
        Me.STATUSTextBox.Enabled = False
        Me.STATUSTextBox.Location = New System.Drawing.Point(493, 78)
        Me.STATUSTextBox.Name = "STATUSTextBox"
        Me.STATUSTextBox.Size = New System.Drawing.Size(100, 20)
        Me.STATUSTextBox.TabIndex = 25
        '
        'PASSWORDTextBox
        '
        Me.PASSWORDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.S_EMPBindingSource, "PASSWORD", True))
        Me.PASSWORDTextBox.Enabled = False
        Me.PASSWORDTextBox.Location = New System.Drawing.Point(493, 52)
        Me.PASSWORDTextBox.Name = "PASSWORDTextBox"
        Me.PASSWORDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PASSWORDTextBox.TabIndex = 23
        '
        'COMMISSION_PCTTextBox
        '
        Me.COMMISSION_PCTTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.S_EMPBindingSource, "COMMISSION_PCT", True))
        Me.COMMISSION_PCTTextBox.Enabled = False
        Me.COMMISSION_PCTTextBox.Location = New System.Drawing.Point(493, 26)
        Me.COMMISSION_PCTTextBox.Name = "COMMISSION_PCTTextBox"
        Me.COMMISSION_PCTTextBox.Size = New System.Drawing.Size(100, 20)
        Me.COMMISSION_PCTTextBox.TabIndex = 21
        '
        'SALARYTextBox
        '
        Me.SALARYTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.S_EMPBindingSource, "SALARY", True))
        Me.SALARYTextBox.Enabled = False
        Me.SALARYTextBox.Location = New System.Drawing.Point(275, 106)
        Me.SALARYTextBox.Name = "SALARYTextBox"
        Me.SALARYTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SALARYTextBox.TabIndex = 19
        '
        'DEPT_IDTextBox
        '
        Me.DEPT_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.S_EMPBindingSource, "DEPT_ID", True))
        Me.DEPT_IDTextBox.Enabled = False
        Me.DEPT_IDTextBox.Location = New System.Drawing.Point(275, 80)
        Me.DEPT_IDTextBox.Name = "DEPT_IDTextBox"
        Me.DEPT_IDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DEPT_IDTextBox.TabIndex = 17
        '
        'TITLETextBox
        '
        Me.TITLETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.S_EMPBindingSource, "TITLE", True))
        Me.TITLETextBox.Enabled = False
        Me.TITLETextBox.Location = New System.Drawing.Point(275, 54)
        Me.TITLETextBox.Name = "TITLETextBox"
        Me.TITLETextBox.Size = New System.Drawing.Size(100, 20)
        Me.TITLETextBox.TabIndex = 15
        '
        'MANAGER_IDTextBox
        '
        Me.MANAGER_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.S_EMPBindingSource, "MANAGER_ID", True))
        Me.MANAGER_IDTextBox.Enabled = False
        Me.MANAGER_IDTextBox.Location = New System.Drawing.Point(275, 28)
        Me.MANAGER_IDTextBox.Name = "MANAGER_IDTextBox"
        Me.MANAGER_IDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.MANAGER_IDTextBox.TabIndex = 13
        '
        'COMMENTSTextBox
        '
        Me.COMMENTSTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.S_EMPBindingSource, "COMMENTS", True))
        Me.COMMENTSTextBox.Enabled = False
        Me.COMMENTSTextBox.Location = New System.Drawing.Point(376, 142)
        Me.COMMENTSTextBox.Multiline = True
        Me.COMMENTSTextBox.Name = "COMMENTSTextBox"
        Me.COMMENTSTextBox.Size = New System.Drawing.Size(217, 20)
        Me.COMMENTSTextBox.TabIndex = 11
        '
        'START_DATEDateTimePicker
        '
        Me.START_DATEDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.S_EMPBindingSource, "START_DATE", True))
        Me.START_DATEDateTimePicker.Enabled = False
        Me.START_DATEDateTimePicker.Location = New System.Drawing.Point(90, 139)
        Me.START_DATEDateTimePicker.Name = "START_DATEDateTimePicker"
        Me.START_DATEDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.START_DATEDateTimePicker.TabIndex = 9
        '
        'USERIDTextBox
        '
        Me.USERIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.S_EMPBindingSource, "USERID", True))
        Me.USERIDTextBox.Enabled = False
        Me.USERIDTextBox.Location = New System.Drawing.Point(83, 103)
        Me.USERIDTextBox.Name = "USERIDTextBox"
        Me.USERIDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.USERIDTextBox.TabIndex = 7
        '
        'FIRST_NAMETextBox
        '
        Me.FIRST_NAMETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.S_EMPBindingSource, "FIRST_NAME", True))
        Me.FIRST_NAMETextBox.Enabled = False
        Me.FIRST_NAMETextBox.Location = New System.Drawing.Point(83, 77)
        Me.FIRST_NAMETextBox.Name = "FIRST_NAMETextBox"
        Me.FIRST_NAMETextBox.Size = New System.Drawing.Size(100, 20)
        Me.FIRST_NAMETextBox.TabIndex = 5
        '
        'LAST_NAMETextBox
        '
        Me.LAST_NAMETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.S_EMPBindingSource, "LAST_NAME", True))
        Me.LAST_NAMETextBox.Enabled = False
        Me.LAST_NAMETextBox.Location = New System.Drawing.Point(83, 51)
        Me.LAST_NAMETextBox.Name = "LAST_NAMETextBox"
        Me.LAST_NAMETextBox.Size = New System.Drawing.Size(100, 20)
        Me.LAST_NAMETextBox.TabIndex = 3
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.S_EMPBindingSource, "ID", True))
        Me.IDTextBox.Enabled = False
        Me.IDTextBox.Location = New System.Drawing.Point(83, 28)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IDTextBox.TabIndex = 1
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(784, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VolverAlMenuToolStripMenuItem, Me.CerrarToolStripMenuItem})
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
        'CerrarToolStripMenuItem
        '
        Me.CerrarToolStripMenuItem.Name = "CerrarToolStripMenuItem"
        Me.CerrarToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CerrarToolStripMenuItem.Text = "Cerrar"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.LASTNAMEDataGridViewTextBoxColumn, Me.FIRSTNAMEDataGridViewTextBoxColumn, Me.USERIDDataGridViewTextBoxColumn, Me.STARTDATEDataGridViewTextBoxColumn, Me.MANAGERIDDataGridViewTextBoxColumn, Me.TITLEDataGridViewTextBoxColumn, Me.DEPTIDDataGridViewTextBoxColumn, Me.SALARYDataGridViewTextBoxColumn, Me.STATUSDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.S_EMPBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(210, 205)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(574, 254)
        Me.DataGridView1.TabIndex = 4
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(615, 39)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 32)
        Me.btnAdd.TabIndex = 5
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(696, 39)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 32)
        Me.btnEdit.TabIndex = 6
        Me.btnEdit.Text = "Editar"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(615, 84)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 32)
        Me.btnDelete.TabIndex = 7
        Me.btnDelete.Text = "Borrar"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(696, 84)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 32)
        Me.btnSave.TabIndex = 8
        Me.btnSave.Text = "Guardar"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'S_EMPBindingSource
        '
        Me.S_EMPBindingSource.DataMember = "S_EMP"
        Me.S_EMPBindingSource.DataSource = Me.DataSetOracle
        '
        'DataSetOracle
        '
        Me.DataSetOracle.DataSetName = "DataSetOracle"
        Me.DataSetOracle.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'S_EMPTableAdapter
        '
        Me.S_EMPTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.S_CUSTOMERTableAdapter = Nothing
        Me.TableAdapterManager.S_DEPTTableAdapter = Nothing
        Me.TableAdapterManager.S_EMPTableAdapter = Me.S_EMPTableAdapter
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
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LASTNAMEDataGridViewTextBoxColumn
        '
        Me.LASTNAMEDataGridViewTextBoxColumn.DataPropertyName = "LAST_NAME"
        Me.LASTNAMEDataGridViewTextBoxColumn.HeaderText = "LAST_NAME"
        Me.LASTNAMEDataGridViewTextBoxColumn.Name = "LASTNAMEDataGridViewTextBoxColumn"
        Me.LASTNAMEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FIRSTNAMEDataGridViewTextBoxColumn
        '
        Me.FIRSTNAMEDataGridViewTextBoxColumn.DataPropertyName = "FIRST_NAME"
        Me.FIRSTNAMEDataGridViewTextBoxColumn.HeaderText = "FIRST_NAME"
        Me.FIRSTNAMEDataGridViewTextBoxColumn.Name = "FIRSTNAMEDataGridViewTextBoxColumn"
        Me.FIRSTNAMEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'USERIDDataGridViewTextBoxColumn
        '
        Me.USERIDDataGridViewTextBoxColumn.DataPropertyName = "USERID"
        Me.USERIDDataGridViewTextBoxColumn.HeaderText = "USERID"
        Me.USERIDDataGridViewTextBoxColumn.Name = "USERIDDataGridViewTextBoxColumn"
        Me.USERIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'STARTDATEDataGridViewTextBoxColumn
        '
        Me.STARTDATEDataGridViewTextBoxColumn.DataPropertyName = "START_DATE"
        Me.STARTDATEDataGridViewTextBoxColumn.HeaderText = "START_DATE"
        Me.STARTDATEDataGridViewTextBoxColumn.Name = "STARTDATEDataGridViewTextBoxColumn"
        Me.STARTDATEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MANAGERIDDataGridViewTextBoxColumn
        '
        Me.MANAGERIDDataGridViewTextBoxColumn.DataPropertyName = "MANAGER_ID"
        Me.MANAGERIDDataGridViewTextBoxColumn.HeaderText = "MANAGER_ID"
        Me.MANAGERIDDataGridViewTextBoxColumn.Name = "MANAGERIDDataGridViewTextBoxColumn"
        Me.MANAGERIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TITLEDataGridViewTextBoxColumn
        '
        Me.TITLEDataGridViewTextBoxColumn.DataPropertyName = "TITLE"
        Me.TITLEDataGridViewTextBoxColumn.HeaderText = "TITLE"
        Me.TITLEDataGridViewTextBoxColumn.Name = "TITLEDataGridViewTextBoxColumn"
        Me.TITLEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DEPTIDDataGridViewTextBoxColumn
        '
        Me.DEPTIDDataGridViewTextBoxColumn.DataPropertyName = "DEPT_ID"
        Me.DEPTIDDataGridViewTextBoxColumn.HeaderText = "DEPT_ID"
        Me.DEPTIDDataGridViewTextBoxColumn.Name = "DEPTIDDataGridViewTextBoxColumn"
        Me.DEPTIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SALARYDataGridViewTextBoxColumn
        '
        Me.SALARYDataGridViewTextBoxColumn.DataPropertyName = "SALARY"
        Me.SALARYDataGridViewTextBoxColumn.HeaderText = "SALARY"
        Me.SALARYDataGridViewTextBoxColumn.Name = "SALARYDataGridViewTextBoxColumn"
        Me.SALARYDataGridViewTextBoxColumn.ReadOnly = True
        '
        'STATUSDataGridViewTextBoxColumn
        '
        Me.STATUSDataGridViewTextBoxColumn.DataPropertyName = "STATUS"
        Me.STATUSDataGridViewTextBoxColumn.HeaderText = "STATUS"
        Me.STATUSDataGridViewTextBoxColumn.Name = "STATUSDataGridViewTextBoxColumn"
        Me.STATUSDataGridViewTextBoxColumn.ReadOnly = True
        '
        'frmEmpleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Menu
        Me.ClientSize = New System.Drawing.Size(784, 461)
        Me.Controls.Add(Me.btnbuscar)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.gbempinfo)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmEmpleados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Empleados"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gbempinfo.ResumeLayout(False)
        Me.gbempinfo.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.S_EMPBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetOracle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataSetOracle As DataSetOracle
    Friend WithEvents S_EMPBindingSource As BindingSource
    Friend WithEvents S_EMPTableAdapter As DataSetOracleTableAdapters.S_EMPTableAdapter
    Friend WithEvents TableAdapterManager As DataSetOracleTableAdapters.TableAdapterManager
    Friend WithEvents rbID As RadioButton
    Friend WithEvents rbNombre As RadioButton
    Friend WithEvents txtSearchEmp As TextBox
    Friend WithEvents btnbuscar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents gbempinfo As GroupBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VolverAlMenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CerrarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents STATUSTextBox As TextBox
    Friend WithEvents PASSWORDTextBox As TextBox
    Friend WithEvents COMMISSION_PCTTextBox As TextBox
    Friend WithEvents SALARYTextBox As TextBox
    Friend WithEvents DEPT_IDTextBox As TextBox
    Friend WithEvents TITLETextBox As TextBox
    Friend WithEvents MANAGER_IDTextBox As TextBox
    Friend WithEvents COMMENTSTextBox As TextBox
    Friend WithEvents START_DATEDateTimePicker As DateTimePicker
    Friend WithEvents USERIDTextBox As TextBox
    Friend WithEvents FIRST_NAMETextBox As TextBox
    Friend WithEvents LAST_NAMETextBox As TextBox
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LASTNAMEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FIRSTNAMEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents USERIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents STARTDATEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MANAGERIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TITLEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DEPTIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SALARYDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents STATUSDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
