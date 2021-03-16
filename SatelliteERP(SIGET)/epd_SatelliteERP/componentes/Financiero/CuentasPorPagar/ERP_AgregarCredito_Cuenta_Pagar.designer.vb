<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ERP_CPC_AgregarCobro
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.cmdGenerar = New System.Windows.Forms.Button()
        Me.rbDiario = New System.Windows.Forms.RadioButton()
        Me.rbSemanal = New System.Windows.Forms.RadioButton()
        Me.rbQuincenal = New System.Windows.Forms.RadioButton()
        Me.rbMensual = New System.Windows.Forms.RadioButton()
        Me.txtCuotas = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dgvCobros = New System.Windows.Forms.DataGridView()
        Me.dtpDateInit = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtDescripcionCredito = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtSaldoDeudor = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtDocumento = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblDepartment = New System.Windows.Forms.Label()
        Me.cbTypeDocument = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtTipoCliente = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbCliente = New System.Windows.Forms.ComboBox()
        Me.lblCliente = New System.Windows.Forms.Label()
        Me.txtDocumentoCliente = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCodigoCliente = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dgvCobros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.cmdCancel)
        Me.GroupBox1.Controls.Add(Me.cmdSave)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(973, 589)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cuentas por Pagar"
        '
        'cmdCancel
        '
        Me.cmdCancel.BackColor = System.Drawing.Color.Gainsboro
        Me.cmdCancel.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdCancel.FlatAppearance.BorderSize = 0
        Me.cmdCancel.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.cmdCancel.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.cmdCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCancel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancel.Location = New System.Drawing.Point(857, 550)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(98, 29)
        Me.cmdCancel.TabIndex = 25
        Me.cmdCancel.Text = "Cancelar"
        Me.cmdCancel.UseVisualStyleBackColor = False
        '
        'cmdSave
        '
        Me.cmdSave.BackColor = System.Drawing.Color.Gainsboro
        Me.cmdSave.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdSave.FlatAppearance.BorderSize = 0
        Me.cmdSave.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.cmdSave.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.cmdSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdSave.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSave.Location = New System.Drawing.Point(748, 550)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(98, 29)
        Me.cmdSave.TabIndex = 24
        Me.cmdSave.Text = "Grabar"
        Me.cmdSave.UseVisualStyleBackColor = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.cmdGenerar)
        Me.GroupBox4.Controls.Add(Me.rbDiario)
        Me.GroupBox4.Controls.Add(Me.rbSemanal)
        Me.GroupBox4.Controls.Add(Me.rbQuincenal)
        Me.GroupBox4.Controls.Add(Me.rbMensual)
        Me.GroupBox4.Controls.Add(Me.txtCuotas)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.dgvCobros)
        Me.GroupBox4.Controls.Add(Me.dtpDateInit)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(20, 316)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(935, 228)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Forma de Cobro"
        '
        'cmdGenerar
        '
        Me.cmdGenerar.BackColor = System.Drawing.Color.Gainsboro
        Me.cmdGenerar.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdGenerar.FlatAppearance.BorderSize = 0
        Me.cmdGenerar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.cmdGenerar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.cmdGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdGenerar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGenerar.Location = New System.Drawing.Point(713, 187)
        Me.cmdGenerar.Name = "cmdGenerar"
        Me.cmdGenerar.Size = New System.Drawing.Size(148, 27)
        Me.cmdGenerar.TabIndex = 23
        Me.cmdGenerar.Text = "Generar Cobros"
        Me.cmdGenerar.UseVisualStyleBackColor = False
        '
        'rbDiario
        '
        Me.rbDiario.AutoSize = True
        Me.rbDiario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbDiario.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.rbDiario.Location = New System.Drawing.Point(793, 145)
        Me.rbDiario.Name = "rbDiario"
        Me.rbDiario.Size = New System.Drawing.Size(80, 29)
        Me.rbDiario.TabIndex = 22
        Me.rbDiario.Text = "Diario"
        Me.rbDiario.UseVisualStyleBackColor = True
        '
        'rbSemanal
        '
        Me.rbSemanal.AutoSize = True
        Me.rbSemanal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbSemanal.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.rbSemanal.Location = New System.Drawing.Point(674, 145)
        Me.rbSemanal.Name = "rbSemanal"
        Me.rbSemanal.Size = New System.Drawing.Size(101, 29)
        Me.rbSemanal.TabIndex = 21
        Me.rbSemanal.Text = "Semanal"
        Me.rbSemanal.UseVisualStyleBackColor = True
        '
        'rbQuincenal
        '
        Me.rbQuincenal.AutoSize = True
        Me.rbQuincenal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbQuincenal.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.rbQuincenal.Location = New System.Drawing.Point(793, 110)
        Me.rbQuincenal.Name = "rbQuincenal"
        Me.rbQuincenal.Size = New System.Drawing.Size(115, 29)
        Me.rbQuincenal.TabIndex = 20
        Me.rbQuincenal.Text = "Quincenal"
        Me.rbQuincenal.UseVisualStyleBackColor = True
        '
        'rbMensual
        '
        Me.rbMensual.AutoSize = True
        Me.rbMensual.Checked = True
        Me.rbMensual.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbMensual.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.rbMensual.Location = New System.Drawing.Point(674, 110)
        Me.rbMensual.Name = "rbMensual"
        Me.rbMensual.Size = New System.Drawing.Size(101, 29)
        Me.rbMensual.TabIndex = 19
        Me.rbMensual.TabStop = True
        Me.rbMensual.Text = "Mensual"
        Me.rbMensual.UseVisualStyleBackColor = True
        '
        'txtCuotas
        '
        Me.txtCuotas.BackColor = System.Drawing.Color.Gainsboro
        Me.txtCuotas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCuotas.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCuotas.Location = New System.Drawing.Point(781, 79)
        Me.txtCuotas.MaxLength = 4
        Me.txtCuotas.Name = "txtCuotas"
        Me.txtCuotas.ShortcutsEnabled = False
        Me.txtCuotas.Size = New System.Drawing.Size(109, 26)
        Me.txtCuotas.TabIndex = 18
        Me.txtCuotas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.Label10.Location = New System.Drawing.Point(675, 79)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(100, 25)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "N° Cuotas:"
        '
        'dgvCobros
        '
        Me.dgvCobros.AllowUserToAddRows = False
        Me.dgvCobros.AllowUserToDeleteRows = False
        Me.dgvCobros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvCobros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCobros.Location = New System.Drawing.Point(10, 35)
        Me.dgvCobros.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvCobros.MultiSelect = False
        Me.dgvCobros.Name = "dgvCobros"
        Me.dgvCobros.ReadOnly = True
        Me.dgvCobros.RowTemplate.Height = 24
        Me.dgvCobros.Size = New System.Drawing.Size(617, 188)
        Me.dgvCobros.TabIndex = 0
        '
        'dtpDateInit
        '
        Me.dtpDateInit.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDateInit.Location = New System.Drawing.Point(793, 33)
        Me.dtpDateInit.Margin = New System.Windows.Forms.Padding(2)
        Me.dtpDateInit.Name = "dtpDateInit"
        Me.dtpDateInit.Size = New System.Drawing.Size(127, 33)
        Me.dtpDateInit.TabIndex = 17
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.Label3.Location = New System.Drawing.Point(640, 37)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(152, 25)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Fecha de Inicio : "
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtDescripcionCredito)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.txtSaldoDeudor)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.txtDocumento)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.lblDepartment)
        Me.GroupBox3.Controls.Add(Me.cbTypeDocument)
        Me.GroupBox3.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(20, 198)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(935, 116)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Información de Cobro"
        '
        'txtDescripcionCredito
        '
        Me.txtDescripcionCredito.BackColor = System.Drawing.Color.Gainsboro
        Me.txtDescripcionCredito.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDescripcionCredito.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcionCredito.Location = New System.Drawing.Point(653, 32)
        Me.txtDescripcionCredito.MaxLength = 50
        Me.txtDescripcionCredito.Name = "txtDescripcionCredito"
        Me.txtDescripcionCredito.ShortcutsEnabled = False
        Me.txtDescripcionCredito.Size = New System.Drawing.Size(255, 26)
        Me.txtDescripcionCredito.TabIndex = 11
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.Label13.Location = New System.Drawing.Point(487, 34)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(164, 25)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Concepto Crédito:"
        '
        'txtSaldoDeudor
        '
        Me.txtSaldoDeudor.BackColor = System.Drawing.Color.Gainsboro
        Me.txtSaldoDeudor.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSaldoDeudor.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaldoDeudor.Location = New System.Drawing.Point(653, 68)
        Me.txtSaldoDeudor.MaxLength = 15
        Me.txtSaldoDeudor.Name = "txtSaldoDeudor"
        Me.txtSaldoDeudor.Size = New System.Drawing.Size(255, 26)
        Me.txtSaldoDeudor.TabIndex = 13
        Me.txtSaldoDeudor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.Label9.Location = New System.Drawing.Point(516, 69)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(131, 25)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Saldo Deudor:"
        '
        'txtDocumento
        '
        Me.txtDocumento.BackColor = System.Drawing.Color.Gainsboro
        Me.txtDocumento.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDocumento.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDocumento.Location = New System.Drawing.Point(187, 67)
        Me.txtDocumento.MaxLength = 20
        Me.txtDocumento.Name = "txtDocumento"
        Me.txtDocumento.ShortcutsEnabled = False
        Me.txtDocumento.Size = New System.Drawing.Size(267, 26)
        Me.txtDocumento.TabIndex = 12
        Me.txtDocumento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.Label7.Location = New System.Drawing.Point(41, 68)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(145, 25)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "N° Documento: "
        '
        'lblDepartment
        '
        Me.lblDepartment.AutoSize = True
        Me.lblDepartment.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.lblDepartment.Location = New System.Drawing.Point(5, 33)
        Me.lblDepartment.Name = "lblDepartment"
        Me.lblDepartment.Size = New System.Drawing.Size(182, 25)
        Me.lblDepartment.TabIndex = 0
        Me.lblDepartment.Text = "Tipo de Documento:"
        '
        'cbTypeDocument
        '
        Me.cbTypeDocument.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbTypeDocument.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbTypeDocument.BackColor = System.Drawing.Color.Gainsboro
        Me.cbTypeDocument.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTypeDocument.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbTypeDocument.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTypeDocument.FormattingEnabled = True
        Me.cbTypeDocument.Location = New System.Drawing.Point(187, 32)
        Me.cbTypeDocument.Name = "cbTypeDocument"
        Me.cbTypeDocument.Size = New System.Drawing.Size(286, 29)
        Me.cbTypeDocument.TabIndex = 10
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtTipoCliente)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.cbCliente)
        Me.GroupBox2.Controls.Add(Me.lblCliente)
        Me.GroupBox2.Controls.Add(Me.txtDocumentoCliente)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txtDireccion)
        Me.GroupBox2.Controls.Add(Me.txtTelefono)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txtCodigoCliente)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(20, 30)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(935, 164)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Información Básica:"
        '
        'txtTipoCliente
        '
        Me.txtTipoCliente.BackColor = System.Drawing.Color.Gainsboro
        Me.txtTipoCliente.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTipoCliente.Enabled = False
        Me.txtTipoCliente.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipoCliente.Location = New System.Drawing.Point(653, 34)
        Me.txtTipoCliente.MaxLength = 50
        Me.txtTipoCliente.Name = "txtTipoCliente"
        Me.txtTipoCliente.ReadOnly = True
        Me.txtTipoCliente.ShortcutsEnabled = False
        Me.txtTipoCliente.Size = New System.Drawing.Size(255, 26)
        Me.txtTipoCliente.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.Label8.Location = New System.Drawing.Point(498, 31)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(143, 25)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Tipo de Proveedor:"
        '
        'cbCliente
        '
        Me.cbCliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbCliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbCliente.BackColor = System.Drawing.Color.Gainsboro
        Me.cbCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbCliente.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCliente.FormattingEnabled = True
        Me.cbCliente.Location = New System.Drawing.Point(184, 29)
        Me.cbCliente.Name = "cbCliente"
        Me.cbCliente.Size = New System.Drawing.Size(287, 29)
        Me.cbCliente.TabIndex = 3
        '
        'lblCliente
        '
        Me.lblCliente.AutoSize = True
        Me.lblCliente.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.lblCliente.Location = New System.Drawing.Point(100, 30)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(85, 25)
        Me.lblCliente.TabIndex = 0
        Me.lblCliente.Text = "Cliente : "
        '
        'txtDocumentoCliente
        '
        Me.txtDocumentoCliente.BackColor = System.Drawing.Color.Gainsboro
        Me.txtDocumentoCliente.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDocumentoCliente.Enabled = False
        Me.txtDocumentoCliente.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDocumentoCliente.Location = New System.Drawing.Point(184, 64)
        Me.txtDocumentoCliente.MaxLength = 50
        Me.txtDocumentoCliente.Name = "txtDocumentoCliente"
        Me.txtDocumentoCliente.ReadOnly = True
        Me.txtDocumentoCliente.ShortcutsEnabled = False
        Me.txtDocumentoCliente.Size = New System.Drawing.Size(267, 26)
        Me.txtDocumentoCliente.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.Label1.Location = New System.Drawing.Point(93, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "DUI/NIT : "
        '
        'txtDireccion
        '
        Me.txtDireccion.BackColor = System.Drawing.Color.Gainsboro
        Me.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDireccion.Enabled = False
        Me.txtDireccion.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDireccion.Location = New System.Drawing.Point(653, 66)
        Me.txtDireccion.MaxLength = 50
        Me.txtDireccion.Multiline = True
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.ReadOnly = True
        Me.txtDireccion.ShortcutsEnabled = False
        Me.txtDireccion.Size = New System.Drawing.Size(255, 58)
        Me.txtDireccion.TabIndex = 6
        '
        'txtTelefono
        '
        Me.txtTelefono.BackColor = System.Drawing.Color.Gainsboro
        Me.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTelefono.Enabled = False
        Me.txtTelefono.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefono.Location = New System.Drawing.Point(184, 132)
        Me.txtTelefono.MaxLength = 50
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.ReadOnly = True
        Me.txtTelefono.ShortcutsEnabled = False
        Me.txtTelefono.Size = New System.Drawing.Size(267, 26)
        Me.txtTelefono.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.Label6.Location = New System.Drawing.Point(85, 133)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 25)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Teléfono : "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.Label2.Location = New System.Drawing.Point(541, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 25)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Dirección : "
        '
        'txtCodigoCliente
        '
        Me.txtCodigoCliente.BackColor = System.Drawing.Color.Gainsboro
        Me.txtCodigoCliente.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCodigoCliente.Enabled = False
        Me.txtCodigoCliente.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigoCliente.Location = New System.Drawing.Point(184, 97)
        Me.txtCodigoCliente.MaxLength = 50
        Me.txtCodigoCliente.Name = "txtCodigoCliente"
        Me.txtCodigoCliente.ReadOnly = True
        Me.txtCodigoCliente.ShortcutsEnabled = False
        Me.txtCodigoCliente.Size = New System.Drawing.Size(267, 26)
        Me.txtCodigoCliente.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.Label5.Location = New System.Drawing.Point(98, 98)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 25)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Código : "
        '
        'ERP_CPC_AgregarCobro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(998, 610)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ERP_CPC_AgregarCobro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ERP_CPC_AgregarCobro"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.dgvCobros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents Label1 As System.Windows.Forms.Label
    Private WithEvents cbCliente As System.Windows.Forms.ComboBox
    Private WithEvents lblCliente As System.Windows.Forms.Label
    Private WithEvents txtDocumentoCliente As System.Windows.Forms.TextBox
    Private WithEvents txtDireccion As System.Windows.Forms.TextBox
    Private WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpDateInit As System.Windows.Forms.DateTimePicker
    Private WithEvents txtTelefono As System.Windows.Forms.TextBox
    Private WithEvents Label6 As System.Windows.Forms.Label
    Private WithEvents txtCodigoCliente As System.Windows.Forms.TextBox
    Private WithEvents Label5 As System.Windows.Forms.Label
    Private WithEvents cbTypeDocument As System.Windows.Forms.ComboBox
    Private WithEvents lblDepartment As System.Windows.Forms.Label
    Private WithEvents txtDocumento As System.Windows.Forms.TextBox
    Private WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Private WithEvents txtTipoCliente As System.Windows.Forms.TextBox
    Private WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Private WithEvents txtSaldoDeudor As System.Windows.Forms.TextBox
    Private WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents dgvCobros As System.Windows.Forms.DataGridView
    Private WithEvents cmdCancel As System.Windows.Forms.Button
    Private WithEvents cmdSave As System.Windows.Forms.Button
    Private WithEvents txtCuotas As System.Windows.Forms.TextBox
    Private WithEvents Label10 As System.Windows.Forms.Label
    Private WithEvents cmdGenerar As System.Windows.Forms.Button
    Friend WithEvents rbDiario As System.Windows.Forms.RadioButton
    Friend WithEvents rbSemanal As System.Windows.Forms.RadioButton
    Friend WithEvents rbQuincenal As System.Windows.Forms.RadioButton
    Friend WithEvents rbMensual As System.Windows.Forms.RadioButton
    Private WithEvents Label3 As System.Windows.Forms.Label
    Private WithEvents txtDescripcionCredito As System.Windows.Forms.TextBox
    Private WithEvents Label13 As System.Windows.Forms.Label
End Class
