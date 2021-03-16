<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ERP_CuentasPorCobrar_AgregarCobro
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
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.GbClientes = New System.Windows.Forms.GroupBox()
        Me.cmdAnular = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.cbEmpleado = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.txtCantidadEntrego = New System.Windows.Forms.TextBox()
        Me.rbCheque = New System.Windows.Forms.RadioButton()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtCantidadCambio = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.rbEfectivo = New System.Windows.Forms.RadioButton()
        Me.rbTarjeta = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtLinea = New System.Windows.Forms.TextBox()
        Me.txtCreditoDescipcion = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtSaldo = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblFechaMaxPago = New System.Windows.Forms.Label()
        Me.lblEnunciadoFecha = New System.Windows.Forms.Label()
        Me.txtCantidadPagar = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbNCuota = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.rbFiniquito = New System.Windows.Forms.RadioButton()
        Me.rbCuota = New System.Windows.Forms.RadioButton()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtConcepto = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmdBuscar = New System.Windows.Forms.Button()
        Me.txtDocCredito = New System.Windows.Forms.TextBox()
        Me.txtcliente = New System.Windows.Forms.TextBox()
        Me.txtCodigoCliente = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtDocumento = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmdGrabar = New System.Windows.Forms.Button()
        Me.GbClientes.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
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
        Me.cmdCancel.Location = New System.Drawing.Point(715, 441)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(153, 37)
        Me.cmdCancel.TabIndex = 8
        Me.cmdCancel.Text = "Salir"
        Me.cmdCancel.UseVisualStyleBackColor = False
        '
        'GbClientes
        '
        Me.GbClientes.BackColor = System.Drawing.SystemColors.Control
        Me.GbClientes.Controls.Add(Me.cmdAnular)
        Me.GbClientes.Controls.Add(Me.GroupBox4)
        Me.GbClientes.Controls.Add(Me.GroupBox2)
        Me.GbClientes.Controls.Add(Me.GroupBox1)
        Me.GbClientes.Controls.Add(Me.cmdGrabar)
        Me.GbClientes.Controls.Add(Me.cmdCancel)
        Me.GbClientes.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GbClientes.Location = New System.Drawing.Point(12, 12)
        Me.GbClientes.Name = "GbClientes"
        Me.GbClientes.Size = New System.Drawing.Size(880, 485)
        Me.GbClientes.TabIndex = 44
        Me.GbClientes.TabStop = False
        Me.GbClientes.Text = "Agregar Cobros"
        '
        'cmdAnular
        '
        Me.cmdAnular.BackColor = System.Drawing.Color.Gainsboro
        Me.cmdAnular.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdAnular.FlatAppearance.BorderSize = 0
        Me.cmdAnular.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.cmdAnular.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.cmdAnular.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAnular.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAnular.Location = New System.Drawing.Point(397, 442)
        Me.cmdAnular.Name = "cmdAnular"
        Me.cmdAnular.Size = New System.Drawing.Size(153, 37)
        Me.cmdAnular.TabIndex = 65
        Me.cmdAnular.Text = "Anular"
        Me.cmdAnular.UseVisualStyleBackColor = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.cbEmpleado)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.GroupBox5)
        Me.GroupBox4.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(22, 295)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(846, 140)
        Me.GroupBox4.TabIndex = 64
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Forma de Pago"
        '
        'cbEmpleado
        '
        Me.cbEmpleado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbEmpleado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbEmpleado.BackColor = System.Drawing.Color.Gainsboro
        Me.cbEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbEmpleado.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbEmpleado.FormattingEnabled = True
        Me.cbEmpleado.Location = New System.Drawing.Point(553, 59)
        Me.cbEmpleado.Name = "cbEmpleado"
        Me.cbEmpleado.Size = New System.Drawing.Size(287, 29)
        Me.cbEmpleado.TabIndex = 65
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.Label14.Location = New System.Drawing.Point(445, 58)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(110, 25)
        Me.Label14.TabIndex = 66
        Me.Label14.Text = "Empleado : "
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.txtCantidadEntrego)
        Me.GroupBox5.Controls.Add(Me.rbCheque)
        Me.GroupBox5.Controls.Add(Me.Label11)
        Me.GroupBox5.Controls.Add(Me.Label8)
        Me.GroupBox5.Controls.Add(Me.txtCantidadCambio)
        Me.GroupBox5.Controls.Add(Me.Label9)
        Me.GroupBox5.Controls.Add(Me.rbEfectivo)
        Me.GroupBox5.Controls.Add(Me.rbTarjeta)
        Me.GroupBox5.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(27, 25)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(390, 104)
        Me.GroupBox5.TabIndex = 64
        Me.GroupBox5.TabStop = False
        '
        'txtCantidadEntrego
        '
        Me.txtCantidadEntrego.BackColor = System.Drawing.Color.Gainsboro
        Me.txtCantidadEntrego.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCantidadEntrego.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidadEntrego.Location = New System.Drawing.Point(237, 34)
        Me.txtCantidadEntrego.MaxLength = 20
        Me.txtCantidadEntrego.Name = "txtCantidadEntrego"
        Me.txtCantidadEntrego.ShortcutsEnabled = False
        Me.txtCantidadEntrego.Size = New System.Drawing.Size(104, 26)
        Me.txtCantidadEntrego.TabIndex = 72
        Me.txtCantidadEntrego.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'rbCheque
        '
        Me.rbCheque.AutoSize = True
        Me.rbCheque.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbCheque.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.rbCheque.Location = New System.Drawing.Point(18, 69)
        Me.rbCheque.Name = "rbCheque"
        Me.rbCheque.Size = New System.Drawing.Size(94, 29)
        Me.rbCheque.TabIndex = 71
        Me.rbCheque.Text = "Cheque"
        Me.rbCheque.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.Label11.Location = New System.Drawing.Point(171, 31)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(59, 25)
        Me.Label11.TabIndex = 70
        Me.Label11.Text = "Pago:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.Label8.Location = New System.Drawing.Point(147, 21)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(17, 25)
        Me.Label8.TabIndex = 68
        Me.Label8.Text = " "
        '
        'txtCantidadCambio
        '
        Me.txtCantidadCambio.BackColor = System.Drawing.Color.Gainsboro
        Me.txtCantidadCambio.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCantidadCambio.Enabled = False
        Me.txtCantidadCambio.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidadCambio.Location = New System.Drawing.Point(237, 66)
        Me.txtCantidadCambio.MaxLength = 20
        Me.txtCantidadCambio.Name = "txtCantidadCambio"
        Me.txtCantidadCambio.ReadOnly = True
        Me.txtCantidadCambio.ShortcutsEnabled = False
        Me.txtCantidadCambio.Size = New System.Drawing.Size(104, 26)
        Me.txtCantidadCambio.TabIndex = 67
        Me.txtCantidadCambio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.Label9.Location = New System.Drawing.Point(150, 66)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(81, 25)
        Me.Label9.TabIndex = 66
        Me.Label9.Text = "Cambio:"
        '
        'rbEfectivo
        '
        Me.rbEfectivo.AutoSize = True
        Me.rbEfectivo.Checked = True
        Me.rbEfectivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbEfectivo.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.rbEfectivo.Location = New System.Drawing.Point(18, 19)
        Me.rbEfectivo.Name = "rbEfectivo"
        Me.rbEfectivo.Size = New System.Drawing.Size(95, 29)
        Me.rbEfectivo.TabIndex = 63
        Me.rbEfectivo.TabStop = True
        Me.rbEfectivo.Text = "Efectivo"
        Me.rbEfectivo.UseVisualStyleBackColor = True
        '
        'rbTarjeta
        '
        Me.rbTarjeta.AutoSize = True
        Me.rbTarjeta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbTarjeta.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.rbTarjeta.Location = New System.Drawing.Point(18, 45)
        Me.rbTarjeta.Name = "rbTarjeta"
        Me.rbTarjeta.Size = New System.Drawing.Size(87, 29)
        Me.rbTarjeta.TabIndex = 62
        Me.rbTarjeta.Text = "Tarjeta"
        Me.rbTarjeta.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtLinea)
        Me.GroupBox2.Controls.Add(Me.txtCreditoDescipcion)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtSaldo)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.txtConcepto)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(22, 138)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(846, 151)
        Me.GroupBox2.TabIndex = 63
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Crédito"
        '
        'txtLinea
        '
        Me.txtLinea.BackColor = System.Drawing.Color.Gainsboro
        Me.txtLinea.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtLinea.Enabled = False
        Me.txtLinea.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLinea.Location = New System.Drawing.Point(108, 27)
        Me.txtLinea.MaxLength = 50
        Me.txtLinea.Name = "txtLinea"
        Me.txtLinea.ReadOnly = True
        Me.txtLinea.ShortcutsEnabled = False
        Me.txtLinea.Size = New System.Drawing.Size(267, 26)
        Me.txtLinea.TabIndex = 69
        '
        'txtCreditoDescipcion
        '
        Me.txtCreditoDescipcion.BackColor = System.Drawing.Color.Gainsboro
        Me.txtCreditoDescipcion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCreditoDescipcion.Enabled = False
        Me.txtCreditoDescipcion.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCreditoDescipcion.Location = New System.Drawing.Point(108, 88)
        Me.txtCreditoDescipcion.MaxLength = 50
        Me.txtCreditoDescipcion.Name = "txtCreditoDescipcion"
        Me.txtCreditoDescipcion.ReadOnly = True
        Me.txtCreditoDescipcion.ShortcutsEnabled = False
        Me.txtCreditoDescipcion.Size = New System.Drawing.Size(267, 26)
        Me.txtCreditoDescipcion.TabIndex = 68
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.Label15.Location = New System.Drawing.Point(23, 88)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(88, 25)
        Me.Label15.TabIndex = 67
        Me.Label15.Text = "Crédito : "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.Label6.Location = New System.Drawing.Point(36, 119)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 25)
        Me.Label6.TabIndex = 66
        Me.Label6.Text = "Saldo : "
        '
        'txtSaldo
        '
        Me.txtSaldo.BackColor = System.Drawing.Color.Gainsboro
        Me.txtSaldo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSaldo.Enabled = False
        Me.txtSaldo.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaldo.Location = New System.Drawing.Point(108, 118)
        Me.txtSaldo.MaxLength = 50
        Me.txtSaldo.Name = "txtSaldo"
        Me.txtSaldo.ReadOnly = True
        Me.txtSaldo.ShortcutsEnabled = False
        Me.txtSaldo.Size = New System.Drawing.Size(158, 26)
        Me.txtSaldo.TabIndex = 65
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblFechaMaxPago)
        Me.GroupBox3.Controls.Add(Me.lblEnunciadoFecha)
        Me.GroupBox3.Controls.Add(Me.txtCantidadPagar)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.cbNCuota)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.rbFiniquito)
        Me.GroupBox3.Controls.Add(Me.rbCuota)
        Me.GroupBox3.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(442, 15)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(387, 127)
        Me.GroupBox3.TabIndex = 64
        Me.GroupBox3.TabStop = False
        '
        'lblFechaMaxPago
        '
        Me.lblFechaMaxPago.AutoSize = True
        Me.lblFechaMaxPago.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.lblFechaMaxPago.Location = New System.Drawing.Point(222, 89)
        Me.lblFechaMaxPago.Name = "lblFechaMaxPago"
        Me.lblFechaMaxPago.Size = New System.Drawing.Size(60, 25)
        Me.lblFechaMaxPago.TabIndex = 71
        Me.lblFechaMaxPago.Text = "none "
        '
        'lblEnunciadoFecha
        '
        Me.lblEnunciadoFecha.AutoSize = True
        Me.lblEnunciadoFecha.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.lblEnunciadoFecha.Location = New System.Drawing.Point(12, 89)
        Me.lblEnunciadoFecha.Name = "lblEnunciadoFecha"
        Me.lblEnunciadoFecha.Size = New System.Drawing.Size(221, 25)
        Me.lblEnunciadoFecha.TabIndex = 70
        Me.lblEnunciadoFecha.Text = "Fecha Máxima de Pago : "
        '
        'txtCantidadPagar
        '
        Me.txtCantidadPagar.BackColor = System.Drawing.Color.Gainsboro
        Me.txtCantidadPagar.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCantidadPagar.Enabled = False
        Me.txtCantidadPagar.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidadPagar.Location = New System.Drawing.Point(239, 58)
        Me.txtCantidadPagar.MaxLength = 20
        Me.txtCantidadPagar.Name = "txtCantidadPagar"
        Me.txtCantidadPagar.ReadOnly = True
        Me.txtCantidadPagar.ShortcutsEnabled = False
        Me.txtCantidadPagar.Size = New System.Drawing.Size(104, 26)
        Me.txtCantidadPagar.TabIndex = 67
        Me.txtCantidadPagar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.Label3.Location = New System.Drawing.Point(147, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 25)
        Me.Label3.TabIndex = 66
        Me.Label3.Text = "Cantidad: "
        '
        'cbNCuota
        '
        Me.cbNCuota.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbNCuota.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbNCuota.BackColor = System.Drawing.Color.Gainsboro
        Me.cbNCuota.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbNCuota.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbNCuota.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbNCuota.FormattingEnabled = True
        Me.cbNCuota.Location = New System.Drawing.Point(239, 23)
        Me.cbNCuota.Name = "cbNCuota"
        Me.cbNCuota.Size = New System.Drawing.Size(124, 29)
        Me.cbNCuota.TabIndex = 64
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.Label4.Location = New System.Drawing.Point(142, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 25)
        Me.Label4.TabIndex = 65
        Me.Label4.Text = "N° Cuota : "
        '
        'rbFiniquito
        '
        Me.rbFiniquito.AutoSize = True
        Me.rbFiniquito.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbFiniquito.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.rbFiniquito.Location = New System.Drawing.Point(17, 56)
        Me.rbFiniquito.Name = "rbFiniquito"
        Me.rbFiniquito.Size = New System.Drawing.Size(103, 29)
        Me.rbFiniquito.TabIndex = 63
        Me.rbFiniquito.Text = "Finiquito"
        Me.rbFiniquito.UseVisualStyleBackColor = True
        '
        'rbCuota
        '
        Me.rbCuota.AutoSize = True
        Me.rbCuota.Checked = True
        Me.rbCuota.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbCuota.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.rbCuota.Location = New System.Drawing.Point(17, 27)
        Me.rbCuota.Name = "rbCuota"
        Me.rbCuota.Size = New System.Drawing.Size(79, 29)
        Me.rbCuota.TabIndex = 62
        Me.rbCuota.TabStop = True
        Me.rbCuota.Text = "Cuota"
        Me.rbCuota.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.Label12.Location = New System.Drawing.Point(44, 28)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(61, 25)
        Me.Label12.TabIndex = 59
        Me.Label12.Text = "Línea:"
        '
        'txtConcepto
        '
        Me.txtConcepto.BackColor = System.Drawing.Color.Gainsboro
        Me.txtConcepto.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtConcepto.Enabled = False
        Me.txtConcepto.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConcepto.Location = New System.Drawing.Point(108, 58)
        Me.txtConcepto.MaxLength = 50
        Me.txtConcepto.Name = "txtConcepto"
        Me.txtConcepto.ReadOnly = True
        Me.txtConcepto.ShortcutsEnabled = False
        Me.txtConcepto.Size = New System.Drawing.Size(267, 26)
        Me.txtConcepto.TabIndex = 53
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.Label2.Location = New System.Drawing.Point(1, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 25)
        Me.Label2.TabIndex = 52
        Me.Label2.Text = "Con.Línea : "
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmdBuscar)
        Me.GroupBox1.Controls.Add(Me.txtDocCredito)
        Me.GroupBox1.Controls.Add(Me.txtcliente)
        Me.GroupBox1.Controls.Add(Me.txtCodigoCliente)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtDocumento)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(22, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(846, 105)
        Me.GroupBox1.TabIndex = 62
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cliente"
        '
        'cmdBuscar
        '
        Me.cmdBuscar.BackColor = System.Drawing.Color.Gainsboro
        Me.cmdBuscar.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdBuscar.FlatAppearance.BorderSize = 0
        Me.cmdBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.cmdBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.cmdBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdBuscar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdBuscar.Location = New System.Drawing.Point(381, 32)
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.Size = New System.Drawing.Size(25, 27)
        Me.cmdBuscar.TabIndex = 67
        Me.cmdBuscar.Text = "..."
        Me.cmdBuscar.UseVisualStyleBackColor = False
        '
        'txtDocCredito
        '
        Me.txtDocCredito.BackColor = System.Drawing.Color.Gainsboro
        Me.txtDocCredito.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDocCredito.Enabled = False
        Me.txtDocCredito.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDocCredito.Location = New System.Drawing.Point(563, 32)
        Me.txtDocCredito.MaxLength = 50
        Me.txtDocCredito.Name = "txtDocCredito"
        Me.txtDocCredito.ReadOnly = True
        Me.txtDocCredito.ShortcutsEnabled = False
        Me.txtDocCredito.Size = New System.Drawing.Size(267, 26)
        Me.txtDocCredito.TabIndex = 55
        '
        'txtcliente
        '
        Me.txtcliente.BackColor = System.Drawing.Color.Gainsboro
        Me.txtcliente.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtcliente.Enabled = False
        Me.txtcliente.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcliente.Location = New System.Drawing.Point(108, 31)
        Me.txtcliente.MaxLength = 50
        Me.txtcliente.Name = "txtcliente"
        Me.txtcliente.ReadOnly = True
        Me.txtcliente.ShortcutsEnabled = False
        Me.txtcliente.Size = New System.Drawing.Size(267, 26)
        Me.txtcliente.TabIndex = 54
        '
        'txtCodigoCliente
        '
        Me.txtCodigoCliente.BackColor = System.Drawing.Color.Gainsboro
        Me.txtCodigoCliente.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCodigoCliente.Enabled = False
        Me.txtCodigoCliente.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigoCliente.Location = New System.Drawing.Point(108, 67)
        Me.txtCodigoCliente.MaxLength = 50
        Me.txtCodigoCliente.Name = "txtCodigoCliente"
        Me.txtCodigoCliente.ReadOnly = True
        Me.txtCodigoCliente.ShortcutsEnabled = False
        Me.txtCodigoCliente.Size = New System.Drawing.Size(267, 26)
        Me.txtCodigoCliente.TabIndex = 53
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.Label5.Location = New System.Drawing.Point(23, 67)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 25)
        Me.Label5.TabIndex = 52
        Me.Label5.Text = "Código : "
        '
        'txtDocumento
        '
        Me.txtDocumento.BackColor = System.Drawing.Color.Gainsboro
        Me.txtDocumento.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDocumento.Enabled = False
        Me.txtDocumento.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDocumento.Location = New System.Drawing.Point(562, 67)
        Me.txtDocumento.MaxLength = 20
        Me.txtDocumento.Name = "txtDocumento"
        Me.txtDocumento.ReadOnly = True
        Me.txtDocumento.ShortcutsEnabled = False
        Me.txtDocumento.Size = New System.Drawing.Size(267, 26)
        Me.txtDocumento.TabIndex = 51
        Me.txtDocumento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.Label7.Location = New System.Drawing.Point(423, 67)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(145, 25)
        Me.Label7.TabIndex = 50
        Me.Label7.Text = "N° Documento: "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.Label1.Location = New System.Drawing.Point(412, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(156, 25)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Doc. de Crédito : "
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.Label10.Location = New System.Drawing.Point(23, 32)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(85, 25)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Cliente : "
        '
        'cmdGrabar
        '
        Me.cmdGrabar.BackColor = System.Drawing.Color.Gainsboro
        Me.cmdGrabar.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdGrabar.FlatAppearance.BorderSize = 0
        Me.cmdGrabar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.cmdGrabar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.cmdGrabar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdGrabar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGrabar.Location = New System.Drawing.Point(556, 441)
        Me.cmdGrabar.Name = "cmdGrabar"
        Me.cmdGrabar.Size = New System.Drawing.Size(153, 37)
        Me.cmdGrabar.TabIndex = 7
        Me.cmdGrabar.Text = "Grabar"
        Me.cmdGrabar.UseVisualStyleBackColor = False
        '
        'ERP_CuentasPorCobrar_AgregarCobro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(904, 509)
        Me.Controls.Add(Me.GbClientes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ERP_CuentasPorCobrar_AgregarCobro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ERP_CobrosCuentaporCobrar"
        Me.GbClientes.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents GbClientes As System.Windows.Forms.GroupBox
    Private WithEvents cmdGrabar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents Label10 As System.Windows.Forms.Label
    Private WithEvents Label1 As System.Windows.Forms.Label
    Private WithEvents txtDocumento As System.Windows.Forms.TextBox
    Private WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Private WithEvents txtConcepto As System.Windows.Forms.TextBox
    Private WithEvents Label2 As System.Windows.Forms.Label
    Private WithEvents txtCodigoCliente As System.Windows.Forms.TextBox
    Private WithEvents Label5 As System.Windows.Forms.Label
    Private WithEvents Label12 As System.Windows.Forms.Label
    Private WithEvents Label6 As System.Windows.Forms.Label
    Private WithEvents txtSaldo As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Private WithEvents txtCantidadPagar As System.Windows.Forms.TextBox
    Private WithEvents Label3 As System.Windows.Forms.Label
    Private WithEvents cbNCuota As System.Windows.Forms.ComboBox
    Private WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents rbFiniquito As System.Windows.Forms.RadioButton
    Friend WithEvents rbCuota As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Private WithEvents cbEmpleado As System.Windows.Forms.ComboBox
    Private WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Private WithEvents Label11 As System.Windows.Forms.Label
    Private WithEvents Label8 As System.Windows.Forms.Label
    Private WithEvents txtCantidadCambio As System.Windows.Forms.TextBox
    Private WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents rbEfectivo As System.Windows.Forms.RadioButton
    Friend WithEvents rbTarjeta As System.Windows.Forms.RadioButton
    Friend WithEvents rbCheque As System.Windows.Forms.RadioButton
    Private WithEvents lblFechaMaxPago As System.Windows.Forms.Label
    Private WithEvents lblEnunciadoFecha As System.Windows.Forms.Label
    Private WithEvents txtDocCredito As System.Windows.Forms.TextBox
    Private WithEvents txtcliente As System.Windows.Forms.TextBox
    Private WithEvents cmdBuscar As System.Windows.Forms.Button
    Private WithEvents txtCantidadEntrego As System.Windows.Forms.TextBox
    Private WithEvents txtCreditoDescipcion As System.Windows.Forms.TextBox
    Private WithEvents Label15 As System.Windows.Forms.Label
    Private WithEvents txtLinea As System.Windows.Forms.TextBox
	Private WithEvents cmdAnular As Button
End Class
