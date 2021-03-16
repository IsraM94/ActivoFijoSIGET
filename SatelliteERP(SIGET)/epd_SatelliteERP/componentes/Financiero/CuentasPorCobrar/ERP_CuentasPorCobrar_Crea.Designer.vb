<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ERP_CuentasPorCobrar_Crea
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblCliente = New System.Windows.Forms.Label()
        Me.txtCliente = New System.Windows.Forms.TextBox()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtValorAutilizar = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdGenerar = New System.Windows.Forms.Button()
        Me.rbDiario = New System.Windows.Forms.RadioButton()
        Me.rbSemanal = New System.Windows.Forms.RadioButton()
        Me.rbQuincenal = New System.Windows.Forms.RadioButton()
        Me.rbMensual = New System.Windows.Forms.RadioButton()
        Me.txtCuotas = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dgvCobros = New System.Windows.Forms.DataGridView()
        Me.NoCuota = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaPago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MontoCuota = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dtpDateInit = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtDescripcionCredito = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cbCreditLine = New System.Windows.Forms.ComboBox()
        Me.txtCreditoDisponible = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtSaldoDeudor = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dgvCobros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.lblCliente)
        Me.GroupBox1.Controls.Add(Me.txtCliente)
        Me.GroupBox1.Controls.Add(Me.cmdCancel)
        Me.GroupBox1.Controls.Add(Me.cmdSave)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(716, 633)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Crea Cuenta Manual"
        '
        'lblCliente
        '
        Me.lblCliente.AutoSize = True
        Me.lblCliente.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.lblCliente.Location = New System.Drawing.Point(15, 32)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(85, 25)
        Me.lblCliente.TabIndex = 0
        Me.lblCliente.Text = "Cliente : "
        '
        'txtCliente
        '
        Me.txtCliente.BackColor = System.Drawing.Color.Gainsboro
        Me.txtCliente.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCliente.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCliente.Location = New System.Drawing.Point(106, 32)
        Me.txtCliente.MaxLength = 15
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.ReadOnly = True
        Me.txtCliente.ShortcutsEnabled = False
        Me.txtCliente.Size = New System.Drawing.Size(597, 26)
        Me.txtCliente.TabIndex = 16
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
        Me.cmdCancel.Location = New System.Drawing.Point(605, 594)
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
        Me.cmdSave.Location = New System.Drawing.Point(496, 594)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(98, 29)
        Me.cmdSave.TabIndex = 24
        Me.cmdSave.Text = "Grabar"
        Me.cmdSave.UseVisualStyleBackColor = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtDescripcion)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.txtValorAutilizar)
        Me.GroupBox4.Controls.Add(Me.Label1)
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
        Me.GroupBox4.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(20, 254)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(685, 334)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Forma de Pago:"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.BackColor = System.Drawing.Color.Gainsboro
        Me.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDescripcion.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.Location = New System.Drawing.Point(134, 290)
        Me.txtDescripcion.MaxLength = 50
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.ShortcutsEnabled = False
        Me.txtDescripcion.Size = New System.Drawing.Size(528, 26)
        Me.txtDescripcion.TabIndex = 17
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.Label2.Location = New System.Drawing.Point(13, 291)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 25)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Descripción:"
        '
        'txtValorAutilizar
        '
        Me.txtValorAutilizar.BackColor = System.Drawing.Color.Gainsboro
        Me.txtValorAutilizar.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtValorAutilizar.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValorAutilizar.Location = New System.Drawing.Point(546, 21)
        Me.txtValorAutilizar.MaxLength = 50
        Me.txtValorAutilizar.Name = "txtValorAutilizar"
        Me.txtValorAutilizar.ShortcutsEnabled = False
        Me.txtValorAutilizar.Size = New System.Drawing.Size(114, 26)
        Me.txtValorAutilizar.TabIndex = 17
        Me.txtValorAutilizar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.Label1.Location = New System.Drawing.Point(383, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(156, 25)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Crédito a utilizar:"
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
        Me.cmdGenerar.Location = New System.Drawing.Point(546, 90)
        Me.cmdGenerar.Name = "cmdGenerar"
        Me.cmdGenerar.Size = New System.Drawing.Size(118, 27)
        Me.cmdGenerar.TabIndex = 23
        Me.cmdGenerar.Text = "Plan de Pago"
        Me.cmdGenerar.UseVisualStyleBackColor = False
        '
        'rbDiario
        '
        Me.rbDiario.AutoSize = True
        Me.rbDiario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbDiario.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.rbDiario.Location = New System.Drawing.Point(370, 90)
        Me.rbDiario.Name = "rbDiario"
        Me.rbDiario.Size = New System.Drawing.Size(80, 29)
        Me.rbDiario.TabIndex = 22
        Me.rbDiario.TabStop = True
        Me.rbDiario.Text = "Diario"
        Me.rbDiario.UseVisualStyleBackColor = True
        '
        'rbSemanal
        '
        Me.rbSemanal.AutoSize = True
        Me.rbSemanal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbSemanal.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.rbSemanal.Location = New System.Drawing.Point(263, 90)
        Me.rbSemanal.Name = "rbSemanal"
        Me.rbSemanal.Size = New System.Drawing.Size(101, 29)
        Me.rbSemanal.TabIndex = 21
        Me.rbSemanal.TabStop = True
        Me.rbSemanal.Text = "Semanal"
        Me.rbSemanal.UseVisualStyleBackColor = True
        '
        'rbQuincenal
        '
        Me.rbQuincenal.AutoSize = True
        Me.rbQuincenal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbQuincenal.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.rbQuincenal.Location = New System.Drawing.Point(136, 90)
        Me.rbQuincenal.Name = "rbQuincenal"
        Me.rbQuincenal.Size = New System.Drawing.Size(115, 29)
        Me.rbQuincenal.TabIndex = 20
        Me.rbQuincenal.TabStop = True
        Me.rbQuincenal.Text = "Quincenal"
        Me.rbQuincenal.UseVisualStyleBackColor = True
        '
        'rbMensual
        '
        Me.rbMensual.AutoSize = True
        Me.rbMensual.Checked = True
        Me.rbMensual.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbMensual.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.rbMensual.Location = New System.Drawing.Point(27, 90)
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
        Me.txtCuotas.Location = New System.Drawing.Point(546, 53)
        Me.txtCuotas.MaxLength = 5
        Me.txtCuotas.Name = "txtCuotas"
        Me.txtCuotas.ShortcutsEnabled = False
        Me.txtCuotas.Size = New System.Drawing.Size(114, 26)
        Me.txtCuotas.TabIndex = 18
        Me.txtCuotas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.Label10.Location = New System.Drawing.Point(445, 53)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(100, 25)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "N° Cuotas:"
        '
        'dgvCobros
        '
        Me.dgvCobros.AllowUserToAddRows = False
        Me.dgvCobros.AllowUserToDeleteRows = False
        Me.dgvCobros.ColumnHeadersHeight = 50
        Me.dgvCobros.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NoCuota, Me.FechaPago, Me.MontoCuota})
        Me.dgvCobros.Location = New System.Drawing.Point(18, 131)
        Me.dgvCobros.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvCobros.MultiSelect = False
        Me.dgvCobros.Name = "dgvCobros"
        Me.dgvCobros.ReadOnly = True
        Me.dgvCobros.Size = New System.Drawing.Size(647, 154)
        Me.dgvCobros.TabIndex = 0
        '
        'NoCuota
        '
        Me.NoCuota.DataPropertyName = "NoCuota"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.NoCuota.DefaultCellStyle = DataGridViewCellStyle1
        Me.NoCuota.HeaderText = "No. Cuota"
        Me.NoCuota.Name = "NoCuota"
        Me.NoCuota.ReadOnly = True
        Me.NoCuota.Width = 195
        '
        'FechaPago
        '
        Me.FechaPago.DataPropertyName = "Fecha de Pago"
        Me.FechaPago.HeaderText = "Fecha Pago"
        Me.FechaPago.Name = "FechaPago"
        Me.FechaPago.ReadOnly = True
        Me.FechaPago.Width = 200
        '
        'MontoCuota
        '
        Me.MontoCuota.DataPropertyName = "Monto a Pagar"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.MontoCuota.DefaultCellStyle = DataGridViewCellStyle2
        Me.MontoCuota.HeaderText = "Monto Cuota"
        Me.MontoCuota.Name = "MontoCuota"
        Me.MontoCuota.ReadOnly = True
        Me.MontoCuota.Width = 200
        '
        'dtpDateInit
        '
        Me.dtpDateInit.CalendarFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDateInit.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDateInit.Location = New System.Drawing.Point(178, 41)
        Me.dtpDateInit.Margin = New System.Windows.Forms.Padding(2)
        Me.dtpDateInit.Name = "dtpDateInit"
        Me.dtpDateInit.Size = New System.Drawing.Size(127, 33)
        Me.dtpDateInit.TabIndex = 17
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.Label3.Location = New System.Drawing.Point(25, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(152, 25)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Fecha de Inicio : "
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtDescripcionCredito)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.cbCreditLine)
        Me.GroupBox3.Controls.Add(Me.txtCreditoDisponible)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.txtSaldoDeudor)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(20, 72)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(685, 176)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Linea de Crédito:"
        '
        'txtDescripcionCredito
        '
        Me.txtDescripcionCredito.BackColor = System.Drawing.Color.Gainsboro
        Me.txtDescripcionCredito.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDescripcionCredito.Enabled = False
        Me.txtDescripcionCredito.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcionCredito.Location = New System.Drawing.Point(26, 105)
        Me.txtDescripcionCredito.MaxLength = 50
        Me.txtDescripcionCredito.Multiline = True
        Me.txtDescripcionCredito.Name = "txtDescripcionCredito"
        Me.txtDescripcionCredito.ShortcutsEnabled = False
        Me.txtDescripcionCredito.Size = New System.Drawing.Size(438, 59)
        Me.txtDescripcionCredito.TabIndex = 11
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.Label13.Location = New System.Drawing.Point(22, 77)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(164, 25)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Concepto Crédito:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.Label12.Location = New System.Drawing.Point(22, 34)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(154, 25)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Linea de Crédito:"
        '
        'cbCreditLine
        '
        Me.cbCreditLine.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbCreditLine.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbCreditLine.BackColor = System.Drawing.Color.Gainsboro
        Me.cbCreditLine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCreditLine.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbCreditLine.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCreditLine.FormattingEnabled = True
        Me.cbCreditLine.Location = New System.Drawing.Point(178, 34)
        Me.cbCreditLine.Name = "cbCreditLine"
        Me.cbCreditLine.Size = New System.Drawing.Size(286, 29)
        Me.cbCreditLine.TabIndex = 14
        '
        'txtCreditoDisponible
        '
        Me.txtCreditoDisponible.BackColor = System.Drawing.Color.Gainsboro
        Me.txtCreditoDisponible.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCreditoDisponible.Enabled = False
        Me.txtCreditoDisponible.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCreditoDisponible.Location = New System.Drawing.Point(485, 138)
        Me.txtCreditoDisponible.MaxLength = 50
        Me.txtCreditoDisponible.Name = "txtCreditoDisponible"
        Me.txtCreditoDisponible.ShortcutsEnabled = False
        Me.txtCreditoDisponible.Size = New System.Drawing.Size(179, 26)
        Me.txtCreditoDisponible.TabIndex = 15
        Me.txtCreditoDisponible.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.Label11.Location = New System.Drawing.Point(480, 105)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(173, 25)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Crédito Disponible:"
        '
        'txtSaldoDeudor
        '
        Me.txtSaldoDeudor.BackColor = System.Drawing.Color.Gainsboro
        Me.txtSaldoDeudor.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSaldoDeudor.Enabled = False
        Me.txtSaldoDeudor.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaldoDeudor.Location = New System.Drawing.Point(483, 66)
        Me.txtSaldoDeudor.MaxLength = 15
        Me.txtSaldoDeudor.Name = "txtSaldoDeudor"
        Me.txtSaldoDeudor.ShortcutsEnabled = False
        Me.txtSaldoDeudor.Size = New System.Drawing.Size(179, 26)
        Me.txtSaldoDeudor.TabIndex = 13
        Me.txtSaldoDeudor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.Label9.Location = New System.Drawing.Point(485, 38)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(164, 25)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Crédito Otorgado:"
        '
        'ERP_CuentasPorCobrar_Crea
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(738, 658)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ERP_CuentasPorCobrar_Crea"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ERP_CPC_AgregarCobro"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.dgvCobros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents lblCliente As System.Windows.Forms.Label
    Friend WithEvents dtpDateInit As System.Windows.Forms.DateTimePicker
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
    Private WithEvents txtCreditoDisponible As System.Windows.Forms.TextBox
    Private WithEvents Label11 As System.Windows.Forms.Label
    Private WithEvents Label12 As System.Windows.Forms.Label
    Private WithEvents cbCreditLine As System.Windows.Forms.ComboBox
    Private WithEvents Label3 As System.Windows.Forms.Label
    Private WithEvents txtDescripcionCredito As System.Windows.Forms.TextBox
    Private WithEvents Label13 As System.Windows.Forms.Label
    Private WithEvents txtCliente As TextBox
    Private WithEvents txtValorAutilizar As TextBox
    Private WithEvents Label1 As Label
    Private WithEvents txtDescripcion As TextBox
    Private WithEvents Label2 As Label
    Friend WithEvents NoCuota As DataGridViewTextBoxColumn
    Friend WithEvents FechaPago As DataGridViewTextBoxColumn
    Friend WithEvents MontoCuota As DataGridViewTextBoxColumn
End Class
