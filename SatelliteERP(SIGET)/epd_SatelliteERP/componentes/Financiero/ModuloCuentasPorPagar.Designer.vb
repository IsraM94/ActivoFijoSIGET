<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ModuloCuentasPorPagar
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.tcMain = New System.Windows.Forms.TabControl()
        Me.VistaGeneral = New System.Windows.Forms.TabPage()
        Me.gbStudentDetails = New System.Windows.Forms.GroupBox()
        Me.flpCalendar = New System.Windows.Forms.FlowLayoutPanel()
        Me.ClientesMora = New System.Windows.Forms.TabPage()
        Me.TLP_PlanDePagos = New System.Windows.Forms.TableLayoutPanel()
        Me.DGV_CustomMora = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SaldoMora = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID_Customer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FlowLayoutPanel3 = New System.Windows.Forms.FlowLayoutPanel()
        Me.cmdCuotaClienteMora = New System.Windows.Forms.Button()
        Me.GraficosFacturacion = New System.Windows.Forms.TabPage()
        Me.Financiero_GraficoFacturacion1 = New epd_SatelliteERP.Financiero_GraficoFacturacion()
        Me.CuentasActivas = New System.Windows.Forms.TabPage()
        Me.TLP_Clientes = New System.Windows.Forms.TableLayoutPanel()
        Me.DGVClientes = New System.Windows.Forms.DataGridView()
        Me.ID_Customer_FK = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Is_Supplier = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Tipo_Cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cliente_RazonSocial = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre_Comercial = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tel_Oficina = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CorreoContacto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FlowLayoutPanel5 = New System.Windows.Forms.FlowLayoutPanel()
        Me.cmdCrearCliente = New System.Windows.Forms.Button()
        Me.cmdModificarCliente = New System.Windows.Forms.Button()
        Me.cmdAgregarCxC = New System.Windows.Forms.Button()
        Me.cmdCuentaCxC_AgregarCobro = New System.Windows.Forms.Button()
        Me.cmdReporteCatalogoCliente = New System.Windows.Forms.Button()
        Me.cmdCatalogoClienteFinanciero = New System.Windows.Forms.Button()
        Me.cmdFichaCliente = New System.Windows.Forms.Button()
        Me.cmdReportPayableAccounts = New System.Windows.Forms.Button()
        Me.cmdCuentasActivasPagosRealizados = New System.Windows.Forms.Button()
        Me.cmdCuentasActivasPagosRealizadosCliente = New System.Windows.Forms.Button()
        Me.cmdCuentasActivasPagosVencidos = New System.Windows.Forms.Button()
        Me.cmdCuentasActivasPagosVencidosCliente = New System.Windows.Forms.Button()
        Me.cmdCuentasActivasPagosProximos = New System.Windows.Forms.Button()
        Me.cmdCuentasActivasPagosCliente = New System.Windows.Forms.Button()
        Me.DocumentType = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.dgvDocumentType = New System.Windows.Forms.DataGridView()
        Me.ID_CreditDocument = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Description = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Is_Invoice = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn46 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn47 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn48 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn49 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FlowLayoutPanel11 = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnCrearTipoDocumento = New System.Windows.Forms.Button()
        Me.btnActualizarTipoDocumento = New System.Windows.Forms.Button()
        Me.btnEliminarTipoDocumento = New System.Windows.Forms.Button()
        Me.btnListadoTipoDocumento = New System.Windows.Forms.Button()
        Me.tcMain.SuspendLayout()
        Me.VistaGeneral.SuspendLayout()
        Me.gbStudentDetails.SuspendLayout()
        Me.ClientesMora.SuspendLayout()
        Me.TLP_PlanDePagos.SuspendLayout()
        CType(Me.DGV_CustomMora, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel3.SuspendLayout()
        Me.GraficosFacturacion.SuspendLayout()
        Me.CuentasActivas.SuspendLayout()
        Me.TLP_Clientes.SuspendLayout()
        CType(Me.DGVClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel5.SuspendLayout()
        Me.DocumentType.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.dgvDocumentType, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel11.SuspendLayout()
        Me.SuspendLayout()
        '
        'tcMain
        '
        Me.tcMain.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.tcMain.Controls.Add(Me.VistaGeneral)
        Me.tcMain.Controls.Add(Me.ClientesMora)
        Me.tcMain.Controls.Add(Me.GraficosFacturacion)
        Me.tcMain.Controls.Add(Me.CuentasActivas)
        Me.tcMain.Controls.Add(Me.DocumentType)
        Me.tcMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tcMain.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tcMain.HotTrack = True
        Me.tcMain.Location = New System.Drawing.Point(0, 0)
        Me.tcMain.Name = "tcMain"
        Me.tcMain.SelectedIndex = 0
        Me.tcMain.Size = New System.Drawing.Size(1095, 579)
        Me.tcMain.TabIndex = 1
        Me.tcMain.TabStop = False
        '
        'VistaGeneral
        '
        Me.VistaGeneral.BackColor = System.Drawing.Color.White
        Me.VistaGeneral.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.VistaGeneral.Controls.Add(Me.gbStudentDetails)
        Me.VistaGeneral.Location = New System.Drawing.Point(4, 35)
        Me.VistaGeneral.Name = "VistaGeneral"
        Me.VistaGeneral.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.VistaGeneral.Size = New System.Drawing.Size(1087, 540)
        Me.VistaGeneral.TabIndex = 0
        Me.VistaGeneral.Text = "Vista General"
        '
        'gbStudentDetails
        '
        Me.gbStudentDetails.Controls.Add(Me.flpCalendar)
        Me.gbStudentDetails.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbStudentDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.gbStudentDetails.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbStudentDetails.ForeColor = System.Drawing.Color.Black
        Me.gbStudentDetails.Location = New System.Drawing.Point(3, 3)
        Me.gbStudentDetails.Name = "gbStudentDetails"
        Me.gbStudentDetails.Size = New System.Drawing.Size(1079, 532)
        Me.gbStudentDetails.TabIndex = 0
        Me.gbStudentDetails.TabStop = False
        Me.gbStudentDetails.Text = "Calendario Cuentas por Pagar"
        '
        'flpCalendar
        '
        Me.flpCalendar.AutoScroll = True
        Me.flpCalendar.BackColor = System.Drawing.Color.White
        Me.flpCalendar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flpCalendar.Location = New System.Drawing.Point(3, 21)
        Me.flpCalendar.Name = "flpCalendar"
        Me.flpCalendar.Size = New System.Drawing.Size(1073, 508)
        Me.flpCalendar.TabIndex = 0
        '
        'ClientesMora
        '
        Me.ClientesMora.Controls.Add(Me.TLP_PlanDePagos)
        Me.ClientesMora.Location = New System.Drawing.Point(4, 35)
        Me.ClientesMora.Name = "ClientesMora"
        Me.ClientesMora.Size = New System.Drawing.Size(1087, 540)
        Me.ClientesMora.TabIndex = 5
        Me.ClientesMora.Text = "CxP Mora"
        Me.ClientesMora.UseVisualStyleBackColor = True
        '
        'TLP_PlanDePagos
        '
        Me.TLP_PlanDePagos.ColumnCount = 1
        Me.TLP_PlanDePagos.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLP_PlanDePagos.Controls.Add(Me.DGV_CustomMora, 0, 1)
        Me.TLP_PlanDePagos.Controls.Add(Me.FlowLayoutPanel3, 0, 0)
        Me.TLP_PlanDePagos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TLP_PlanDePagos.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TLP_PlanDePagos.Location = New System.Drawing.Point(0, 0)
        Me.TLP_PlanDePagos.Name = "TLP_PlanDePagos"
        Me.TLP_PlanDePagos.RowCount = 2
        Me.TLP_PlanDePagos.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75.0!))
        Me.TLP_PlanDePagos.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLP_PlanDePagos.Size = New System.Drawing.Size(1087, 540)
        Me.TLP_PlanDePagos.TabIndex = 3
        '
        'DGV_CustomMora
        '
        Me.DGV_CustomMora.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGV_CustomMora.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.SaldoMora, Me.Column1, Me.ID_Customer})
        Me.DGV_CustomMora.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGV_CustomMora.EnableHeadersVisualStyles = False
        Me.DGV_CustomMora.Location = New System.Drawing.Point(3, 78)
        Me.DGV_CustomMora.Name = "DGV_CustomMora"
        Me.DGV_CustomMora.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DGV_CustomMora.RowHeadersVisible = False
        Me.DGV_CustomMora.ShowCellErrors = False
        Me.DGV_CustomMora.ShowCellToolTips = False
        Me.DGV_CustomMora.ShowEditingIcon = False
        Me.DGV_CustomMora.ShowRowErrors = False
        Me.DGV_CustomMora.Size = New System.Drawing.Size(1081, 459)
        Me.DGV_CustomMora.TabIndex = 2
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID_AccountsList"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Correlativo"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 107
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Business_Name"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Cliente / Razón Social"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 179
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Concepto"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Línea Crédito"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 122
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Saldo"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Saldo Total"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 110
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "MoraDias"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Mora Días"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 102
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "DateInit"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Fec. Inicio Mora"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 138
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "CountDocuments"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Cant. Doc."
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 101
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Saldo30"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Saldo Mora 30"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Width = 131
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Saldo60"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Saldo Mora 60"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.Width = 131
        '
        'SaldoMora
        '
        Me.SaldoMora.DataPropertyName = "Saldo90"
        Me.SaldoMora.HeaderText = "Saldo Mora 90"
        Me.SaldoMora.Name = "SaldoMora"
        Me.SaldoMora.Width = 131
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "SaldoMas120"
        Me.Column1.HeaderText = "Saldo Mora más 120"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 165
        '
        'ID_Customer
        '
        Me.ID_Customer.DataPropertyName = "Id_Customer"
        Me.ID_Customer.HeaderText = "Id_Customer"
        Me.ID_Customer.Name = "ID_Customer"
        Me.ID_Customer.Visible = False
        '
        'FlowLayoutPanel3
        '
        Me.FlowLayoutPanel3.Controls.Add(Me.cmdCuotaClienteMora)
        Me.FlowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel3.Location = New System.Drawing.Point(3, 3)
        Me.FlowLayoutPanel3.Name = "FlowLayoutPanel3"
        Me.FlowLayoutPanel3.Size = New System.Drawing.Size(1081, 69)
        Me.FlowLayoutPanel3.TabIndex = 1
        '
        'cmdCuotaClienteMora
        '
        Me.cmdCuotaClienteMora.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.cmdCuotaClienteMora.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdCuotaClienteMora.FlatAppearance.BorderSize = 0
        Me.cmdCuotaClienteMora.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdCuotaClienteMora.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdCuotaClienteMora.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCuotaClienteMora.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCuotaClienteMora.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmdCuotaClienteMora.Location = New System.Drawing.Point(3, 3)
        Me.cmdCuotaClienteMora.Name = "cmdCuotaClienteMora"
        Me.cmdCuotaClienteMora.Size = New System.Drawing.Size(131, 66)
        Me.cmdCuotaClienteMora.TabIndex = 43
        Me.cmdCuotaClienteMora.Text = "Pago Cuota o total"
        Me.cmdCuotaClienteMora.UseVisualStyleBackColor = False
        '
        'GraficosFacturacion
        '
        Me.GraficosFacturacion.Controls.Add(Me.Financiero_GraficoFacturacion1)
        Me.GraficosFacturacion.Location = New System.Drawing.Point(4, 35)
        Me.GraficosFacturacion.Name = "GraficosFacturacion"
        Me.GraficosFacturacion.Size = New System.Drawing.Size(1087, 540)
        Me.GraficosFacturacion.TabIndex = 8
        Me.GraficosFacturacion.Text = "Gráficos Facturación"
        Me.GraficosFacturacion.UseVisualStyleBackColor = True
        '
        'Financiero_GraficoFacturacion1
        '
        Me.Financiero_GraficoFacturacion1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Financiero_GraficoFacturacion1.Location = New System.Drawing.Point(0, 0)
        Me.Financiero_GraficoFacturacion1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Financiero_GraficoFacturacion1.Name = "Financiero_GraficoFacturacion1"
        Me.Financiero_GraficoFacturacion1.Size = New System.Drawing.Size(1087, 540)
        Me.Financiero_GraficoFacturacion1.TabIndex = 0
        '
        'CuentasActivas
        '
        Me.CuentasActivas.Controls.Add(Me.TLP_Clientes)
        Me.CuentasActivas.Location = New System.Drawing.Point(4, 35)
        Me.CuentasActivas.Name = "CuentasActivas"
        Me.CuentasActivas.Size = New System.Drawing.Size(1087, 540)
        Me.CuentasActivas.TabIndex = 9
        Me.CuentasActivas.Text = "Cuentas Activas"
        Me.CuentasActivas.UseVisualStyleBackColor = True
        '
        'TLP_Clientes
        '
        Me.TLP_Clientes.ColumnCount = 1
        Me.TLP_Clientes.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLP_Clientes.Controls.Add(Me.DGVClientes, 0, 1)
        Me.TLP_Clientes.Controls.Add(Me.FlowLayoutPanel5, 0, 0)
        Me.TLP_Clientes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TLP_Clientes.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TLP_Clientes.Location = New System.Drawing.Point(0, 0)
        Me.TLP_Clientes.Name = "TLP_Clientes"
        Me.TLP_Clientes.RowCount = 2
        Me.TLP_Clientes.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 152.0!))
        Me.TLP_Clientes.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLP_Clientes.Size = New System.Drawing.Size(1087, 540)
        Me.TLP_Clientes.TabIndex = 3
        '
        'DGVClientes
        '
        Me.DGVClientes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGVClientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID_Customer_FK, Me.Is_Supplier, Me.Tipo_Cliente, Me.Cliente_RazonSocial, Me.Nombre_Comercial, Me.Tel_Oficina, Me.CorreoContacto})
        Me.DGVClientes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGVClientes.EnableHeadersVisualStyles = False
        Me.DGVClientes.Location = New System.Drawing.Point(3, 155)
        Me.DGVClientes.Name = "DGVClientes"
        Me.DGVClientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DGVClientes.RowHeadersVisible = False
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.DGVClientes.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DGVClientes.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.DGVClientes.ShowCellErrors = False
        Me.DGVClientes.ShowCellToolTips = False
        Me.DGVClientes.ShowEditingIcon = False
        Me.DGVClientes.ShowRowErrors = False
        Me.DGVClientes.Size = New System.Drawing.Size(1081, 382)
        Me.DGVClientes.TabIndex = 2
        '
        'ID_Customer_FK
        '
        Me.ID_Customer_FK.DataPropertyName = "Id_Customer"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.ID_Customer_FK.DefaultCellStyle = DataGridViewCellStyle3
        Me.ID_Customer_FK.HeaderText = "Correlativo"
        Me.ID_Customer_FK.Name = "ID_Customer_FK"
        Me.ID_Customer_FK.Width = 107
        '
        'Is_Supplier
        '
        Me.Is_Supplier.DataPropertyName = "Is_Supplier"
        Me.Is_Supplier.FalseValue = "0"
        Me.Is_Supplier.HeaderText = "Es Proveedor"
        Me.Is_Supplier.Name = "Is_Supplier"
        Me.Is_Supplier.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Is_Supplier.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Is_Supplier.TrueValue = "1"
        Me.Is_Supplier.Width = 120
        '
        'Tipo_Cliente
        '
        Me.Tipo_Cliente.DataPropertyName = "DescriptionCustomer"
        Me.Tipo_Cliente.HeaderText = "Tipo Cliente"
        Me.Tipo_Cliente.Name = "Tipo_Cliente"
        Me.Tipo_Cliente.Width = 114
        '
        'Cliente_RazonSocial
        '
        Me.Cliente_RazonSocial.DataPropertyName = "Name_Company"
        Me.Cliente_RazonSocial.HeaderText = "Cliente / Razón social"
        Me.Cliente_RazonSocial.Name = "Cliente_RazonSocial"
        Me.Cliente_RazonSocial.Width = 179
        '
        'Nombre_Comercial
        '
        Me.Nombre_Comercial.DataPropertyName = "Commercial_Name"
        Me.Nombre_Comercial.HeaderText = "Nombre Comercial"
        Me.Nombre_Comercial.Name = "Nombre_Comercial"
        Me.Nombre_Comercial.Width = 160
        '
        'Tel_Oficina
        '
        Me.Tel_Oficina.DataPropertyName = "OfficePhone"
        Me.Tel_Oficina.HeaderText = "Tel. Oficina"
        Me.Tel_Oficina.Name = "Tel_Oficina"
        Me.Tel_Oficina.Width = 108
        '
        'CorreoContacto
        '
        Me.CorreoContacto.DataPropertyName = "Email_Contact"
        Me.CorreoContacto.HeaderText = "Correo Contacto"
        Me.CorreoContacto.Name = "CorreoContacto"
        Me.CorreoContacto.Width = 143
        '
        'FlowLayoutPanel5
        '
        Me.FlowLayoutPanel5.Controls.Add(Me.cmdCrearCliente)
        Me.FlowLayoutPanel5.Controls.Add(Me.cmdModificarCliente)
        Me.FlowLayoutPanel5.Controls.Add(Me.cmdAgregarCxC)
        Me.FlowLayoutPanel5.Controls.Add(Me.cmdCuentaCxC_AgregarCobro)
        Me.FlowLayoutPanel5.Controls.Add(Me.cmdReporteCatalogoCliente)
        Me.FlowLayoutPanel5.Controls.Add(Me.cmdCatalogoClienteFinanciero)
        Me.FlowLayoutPanel5.Controls.Add(Me.cmdFichaCliente)
        Me.FlowLayoutPanel5.Controls.Add(Me.cmdReportPayableAccounts)
        Me.FlowLayoutPanel5.Controls.Add(Me.cmdCuentasActivasPagosRealizados)
        Me.FlowLayoutPanel5.Controls.Add(Me.cmdCuentasActivasPagosRealizadosCliente)
        Me.FlowLayoutPanel5.Controls.Add(Me.cmdCuentasActivasPagosVencidos)
        Me.FlowLayoutPanel5.Controls.Add(Me.cmdCuentasActivasPagosVencidosCliente)
        Me.FlowLayoutPanel5.Controls.Add(Me.cmdCuentasActivasPagosProximos)
        Me.FlowLayoutPanel5.Controls.Add(Me.cmdCuentasActivasPagosCliente)
        Me.FlowLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel5.Location = New System.Drawing.Point(3, 3)
        Me.FlowLayoutPanel5.Name = "FlowLayoutPanel5"
        Me.FlowLayoutPanel5.Size = New System.Drawing.Size(1081, 146)
        Me.FlowLayoutPanel5.TabIndex = 1
        '
        'cmdCrearCliente
        '
        Me.cmdCrearCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.cmdCrearCliente.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdCrearCliente.FlatAppearance.BorderSize = 0
        Me.cmdCrearCliente.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdCrearCliente.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdCrearCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCrearCliente.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCrearCliente.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmdCrearCliente.Location = New System.Drawing.Point(3, 3)
        Me.cmdCrearCliente.Name = "cmdCrearCliente"
        Me.cmdCrearCliente.Size = New System.Drawing.Size(118, 66)
        Me.cmdCrearCliente.TabIndex = 35
        Me.cmdCrearCliente.Text = "  Crear    Cliente"
        Me.cmdCrearCliente.UseVisualStyleBackColor = False
        '
        'cmdModificarCliente
        '
        Me.cmdModificarCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.cmdModificarCliente.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdModificarCliente.FlatAppearance.BorderSize = 0
        Me.cmdModificarCliente.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdModificarCliente.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdModificarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdModificarCliente.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdModificarCliente.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmdModificarCliente.Location = New System.Drawing.Point(127, 3)
        Me.cmdModificarCliente.Name = "cmdModificarCliente"
        Me.cmdModificarCliente.Size = New System.Drawing.Size(118, 66)
        Me.cmdModificarCliente.TabIndex = 36
        Me.cmdModificarCliente.Text = "Modificar Cliente"
        Me.cmdModificarCliente.UseVisualStyleBackColor = False
        '
        'cmdAgregarCxC
        '
        Me.cmdAgregarCxC.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.cmdAgregarCxC.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdAgregarCxC.FlatAppearance.BorderSize = 0
        Me.cmdAgregarCxC.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdAgregarCxC.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdAgregarCxC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAgregarCxC.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAgregarCxC.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmdAgregarCxC.Location = New System.Drawing.Point(251, 3)
        Me.cmdAgregarCxC.Name = "cmdAgregarCxC"
        Me.cmdAgregarCxC.Size = New System.Drawing.Size(137, 66)
        Me.cmdAgregarCxC.TabIndex = 41
        Me.cmdAgregarCxC.Text = "Agregar Cuenta por Pagar"
        Me.cmdAgregarCxC.UseVisualStyleBackColor = False
        '
        'cmdCuentaCxC_AgregarCobro
        '
        Me.cmdCuentaCxC_AgregarCobro.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.cmdCuentaCxC_AgregarCobro.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdCuentaCxC_AgregarCobro.FlatAppearance.BorderSize = 0
        Me.cmdCuentaCxC_AgregarCobro.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdCuentaCxC_AgregarCobro.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdCuentaCxC_AgregarCobro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCuentaCxC_AgregarCobro.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCuentaCxC_AgregarCobro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmdCuentaCxC_AgregarCobro.Location = New System.Drawing.Point(394, 3)
        Me.cmdCuentaCxC_AgregarCobro.Name = "cmdCuentaCxC_AgregarCobro"
        Me.cmdCuentaCxC_AgregarCobro.Size = New System.Drawing.Size(137, 66)
        Me.cmdCuentaCxC_AgregarCobro.TabIndex = 42
        Me.cmdCuentaCxC_AgregarCobro.Text = "Realizar Pago"
        Me.cmdCuentaCxC_AgregarCobro.UseVisualStyleBackColor = False
        '
        'cmdReporteCatalogoCliente
        '
        Me.cmdReporteCatalogoCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.cmdReporteCatalogoCliente.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdReporteCatalogoCliente.FlatAppearance.BorderSize = 0
        Me.cmdReporteCatalogoCliente.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdReporteCatalogoCliente.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdReporteCatalogoCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdReporteCatalogoCliente.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdReporteCatalogoCliente.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmdReporteCatalogoCliente.Location = New System.Drawing.Point(537, 3)
        Me.cmdReporteCatalogoCliente.Name = "cmdReporteCatalogoCliente"
        Me.cmdReporteCatalogoCliente.Size = New System.Drawing.Size(116, 66)
        Me.cmdReporteCatalogoCliente.TabIndex = 37
        Me.cmdReporteCatalogoCliente.Text = "Catálogo de Clientes"
        Me.cmdReporteCatalogoCliente.UseVisualStyleBackColor = False
        '
        'cmdCatalogoClienteFinanciero
        '
        Me.cmdCatalogoClienteFinanciero.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.cmdCatalogoClienteFinanciero.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdCatalogoClienteFinanciero.FlatAppearance.BorderSize = 0
        Me.cmdCatalogoClienteFinanciero.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdCatalogoClienteFinanciero.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdCatalogoClienteFinanciero.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCatalogoClienteFinanciero.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCatalogoClienteFinanciero.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmdCatalogoClienteFinanciero.Location = New System.Drawing.Point(659, 3)
        Me.cmdCatalogoClienteFinanciero.Name = "cmdCatalogoClienteFinanciero"
        Me.cmdCatalogoClienteFinanciero.Size = New System.Drawing.Size(158, 66)
        Me.cmdCatalogoClienteFinanciero.TabIndex = 39
        Me.cmdCatalogoClienteFinanciero.Text = "Catálogo de Clientes Financiero"
        Me.cmdCatalogoClienteFinanciero.UseVisualStyleBackColor = False
        '
        'cmdFichaCliente
        '
        Me.cmdFichaCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.cmdFichaCliente.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdFichaCliente.FlatAppearance.BorderSize = 0
        Me.cmdFichaCliente.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdFichaCliente.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdFichaCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdFichaCliente.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdFichaCliente.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmdFichaCliente.Location = New System.Drawing.Point(823, 3)
        Me.cmdFichaCliente.Name = "cmdFichaCliente"
        Me.cmdFichaCliente.Size = New System.Drawing.Size(118, 66)
        Me.cmdFichaCliente.TabIndex = 40
        Me.cmdFichaCliente.Text = "Ficha Cliente"
        Me.cmdFichaCliente.UseVisualStyleBackColor = False
        '
        'cmdReportPayableAccounts
        '
        Me.cmdReportPayableAccounts.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.cmdReportPayableAccounts.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdReportPayableAccounts.FlatAppearance.BorderSize = 0
        Me.cmdReportPayableAccounts.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdReportPayableAccounts.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdReportPayableAccounts.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdReportPayableAccounts.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdReportPayableAccounts.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmdReportPayableAccounts.Location = New System.Drawing.Point(3, 75)
        Me.cmdReportPayableAccounts.Name = "cmdReportPayableAccounts"
        Me.cmdReportPayableAccounts.Size = New System.Drawing.Size(144, 66)
        Me.cmdReportPayableAccounts.TabIndex = 40
        Me.cmdReportPayableAccounts.Text = "Reporte Cuentas por Pagar"
        Me.cmdReportPayableAccounts.UseVisualStyleBackColor = False
        '
        'cmdCuentasActivasPagosRealizados
        '
        Me.cmdCuentasActivasPagosRealizados.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.cmdCuentasActivasPagosRealizados.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdCuentasActivasPagosRealizados.FlatAppearance.BorderSize = 0
        Me.cmdCuentasActivasPagosRealizados.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdCuentasActivasPagosRealizados.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdCuentasActivasPagosRealizados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCuentasActivasPagosRealizados.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCuentasActivasPagosRealizados.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmdCuentasActivasPagosRealizados.Location = New System.Drawing.Point(153, 75)
        Me.cmdCuentasActivasPagosRealizados.Name = "cmdCuentasActivasPagosRealizados"
        Me.cmdCuentasActivasPagosRealizados.Size = New System.Drawing.Size(135, 66)
        Me.cmdCuentasActivasPagosRealizados.TabIndex = 49
        Me.cmdCuentasActivasPagosRealizados.Text = "Pagos Realizados"
        Me.cmdCuentasActivasPagosRealizados.UseVisualStyleBackColor = False
        '
        'cmdCuentasActivasPagosRealizadosCliente
        '
        Me.cmdCuentasActivasPagosRealizadosCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.cmdCuentasActivasPagosRealizadosCliente.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdCuentasActivasPagosRealizadosCliente.FlatAppearance.BorderSize = 0
        Me.cmdCuentasActivasPagosRealizadosCliente.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdCuentasActivasPagosRealizadosCliente.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdCuentasActivasPagosRealizadosCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCuentasActivasPagosRealizadosCliente.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCuentasActivasPagosRealizadosCliente.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmdCuentasActivasPagosRealizadosCliente.Location = New System.Drawing.Point(294, 75)
        Me.cmdCuentasActivasPagosRealizadosCliente.Name = "cmdCuentasActivasPagosRealizadosCliente"
        Me.cmdCuentasActivasPagosRealizadosCliente.Size = New System.Drawing.Size(157, 66)
        Me.cmdCuentasActivasPagosRealizadosCliente.TabIndex = 50
        Me.cmdCuentasActivasPagosRealizadosCliente.Text = "Pagos Realizados por Cliente"
        Me.cmdCuentasActivasPagosRealizadosCliente.UseVisualStyleBackColor = False
        '
        'cmdCuentasActivasPagosVencidos
        '
        Me.cmdCuentasActivasPagosVencidos.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.cmdCuentasActivasPagosVencidos.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdCuentasActivasPagosVencidos.FlatAppearance.BorderSize = 0
        Me.cmdCuentasActivasPagosVencidos.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdCuentasActivasPagosVencidos.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdCuentasActivasPagosVencidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCuentasActivasPagosVencidos.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCuentasActivasPagosVencidos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmdCuentasActivasPagosVencidos.Location = New System.Drawing.Point(457, 75)
        Me.cmdCuentasActivasPagosVencidos.Name = "cmdCuentasActivasPagosVencidos"
        Me.cmdCuentasActivasPagosVencidos.Size = New System.Drawing.Size(135, 66)
        Me.cmdCuentasActivasPagosVencidos.TabIndex = 51
        Me.cmdCuentasActivasPagosVencidos.Text = "Pagos Vencidos"
        Me.cmdCuentasActivasPagosVencidos.UseVisualStyleBackColor = False
        '
        'cmdCuentasActivasPagosVencidosCliente
        '
        Me.cmdCuentasActivasPagosVencidosCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.cmdCuentasActivasPagosVencidosCliente.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdCuentasActivasPagosVencidosCliente.FlatAppearance.BorderSize = 0
        Me.cmdCuentasActivasPagosVencidosCliente.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdCuentasActivasPagosVencidosCliente.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdCuentasActivasPagosVencidosCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCuentasActivasPagosVencidosCliente.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCuentasActivasPagosVencidosCliente.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmdCuentasActivasPagosVencidosCliente.Location = New System.Drawing.Point(598, 75)
        Me.cmdCuentasActivasPagosVencidosCliente.Name = "cmdCuentasActivasPagosVencidosCliente"
        Me.cmdCuentasActivasPagosVencidosCliente.Size = New System.Drawing.Size(147, 66)
        Me.cmdCuentasActivasPagosVencidosCliente.TabIndex = 52
        Me.cmdCuentasActivasPagosVencidosCliente.Text = "Pagos Vencidos por Cliente"
        Me.cmdCuentasActivasPagosVencidosCliente.UseVisualStyleBackColor = False
        '
        'cmdCuentasActivasPagosProximos
        '
        Me.cmdCuentasActivasPagosProximos.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.cmdCuentasActivasPagosProximos.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdCuentasActivasPagosProximos.FlatAppearance.BorderSize = 0
        Me.cmdCuentasActivasPagosProximos.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdCuentasActivasPagosProximos.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdCuentasActivasPagosProximos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCuentasActivasPagosProximos.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCuentasActivasPagosProximos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmdCuentasActivasPagosProximos.Location = New System.Drawing.Point(751, 75)
        Me.cmdCuentasActivasPagosProximos.Name = "cmdCuentasActivasPagosProximos"
        Me.cmdCuentasActivasPagosProximos.Size = New System.Drawing.Size(135, 66)
        Me.cmdCuentasActivasPagosProximos.TabIndex = 53
        Me.cmdCuentasActivasPagosProximos.Text = "Pagos Próximos"
        Me.cmdCuentasActivasPagosProximos.UseVisualStyleBackColor = False
        '
        'cmdCuentasActivasPagosCliente
        '
        Me.cmdCuentasActivasPagosCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.cmdCuentasActivasPagosCliente.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdCuentasActivasPagosCliente.FlatAppearance.BorderSize = 0
        Me.cmdCuentasActivasPagosCliente.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdCuentasActivasPagosCliente.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdCuentasActivasPagosCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCuentasActivasPagosCliente.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCuentasActivasPagosCliente.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmdCuentasActivasPagosCliente.Location = New System.Drawing.Point(892, 75)
        Me.cmdCuentasActivasPagosCliente.Name = "cmdCuentasActivasPagosCliente"
        Me.cmdCuentasActivasPagosCliente.Size = New System.Drawing.Size(147, 66)
        Me.cmdCuentasActivasPagosCliente.TabIndex = 54
        Me.cmdCuentasActivasPagosCliente.Text = "Pagos Próximos por Cliente"
        Me.cmdCuentasActivasPagosCliente.UseVisualStyleBackColor = False
        '
        'DocumentType
        '
        Me.DocumentType.Controls.Add(Me.TableLayoutPanel1)
        Me.DocumentType.Location = New System.Drawing.Point(4, 35)
        Me.DocumentType.Name = "DocumentType"
        Me.DocumentType.Size = New System.Drawing.Size(1087, 540)
        Me.DocumentType.TabIndex = 10
        Me.DocumentType.Text = "Tipo de Documento"
        Me.DocumentType.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.dgvDocumentType, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.FlowLayoutPanel11, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 81.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1087, 540)
        Me.TableLayoutPanel1.TabIndex = 8
        '
        'dgvDocumentType
        '
        Me.dgvDocumentType.AllowUserToAddRows = False
        Me.dgvDocumentType.AllowUserToDeleteRows = False
        Me.dgvDocumentType.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvDocumentType.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID_CreditDocument, Me.Description, Me.Is_Invoice, Me.DataGridViewTextBoxColumn46, Me.DataGridViewTextBoxColumn47, Me.DataGridViewTextBoxColumn48, Me.DataGridViewTextBoxColumn49})
        Me.dgvDocumentType.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvDocumentType.EnableHeadersVisualStyles = False
        Me.dgvDocumentType.Location = New System.Drawing.Point(3, 84)
        Me.dgvDocumentType.Name = "dgvDocumentType"
        Me.dgvDocumentType.ReadOnly = True
        Me.dgvDocumentType.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvDocumentType.RowHeadersVisible = False
        Me.dgvDocumentType.ShowCellErrors = False
        Me.dgvDocumentType.ShowCellToolTips = False
        Me.dgvDocumentType.ShowEditingIcon = False
        Me.dgvDocumentType.ShowRowErrors = False
        Me.dgvDocumentType.Size = New System.Drawing.Size(1081, 453)
        Me.dgvDocumentType.TabIndex = 0
        '
        'ID_CreditDocument
        '
        Me.ID_CreditDocument.DataPropertyName = "ID_CreditDocument"
        Me.ID_CreditDocument.HeaderText = "Correlativo"
        Me.ID_CreditDocument.Name = "ID_CreditDocument"
        Me.ID_CreditDocument.ReadOnly = True
        Me.ID_CreditDocument.Width = 80
        '
        'Description
        '
        Me.Description.DataPropertyName = "Description"
        Me.Description.HeaderText = "Descripción de Tipo de Documento"
        Me.Description.Name = "Description"
        Me.Description.ReadOnly = True
        '
        'Is_Invoice
        '
        Me.Is_Invoice.DataPropertyName = "Is_Invoice"
        Me.Is_Invoice.HeaderText = "Es Factura"
        Me.Is_Invoice.Name = "Is_Invoice"
        Me.Is_Invoice.ReadOnly = True
        Me.Is_Invoice.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Is_Invoice.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'DataGridViewTextBoxColumn46
        '
        Me.DataGridViewTextBoxColumn46.DataPropertyName = "UsersCreate"
        Me.DataGridViewTextBoxColumn46.HeaderText = "Create User"
        Me.DataGridViewTextBoxColumn46.Name = "DataGridViewTextBoxColumn46"
        Me.DataGridViewTextBoxColumn46.ReadOnly = True
        '
        'DataGridViewTextBoxColumn47
        '
        Me.DataGridViewTextBoxColumn47.DataPropertyName = "DateCreate"
        Me.DataGridViewTextBoxColumn47.HeaderText = "Create Date"
        Me.DataGridViewTextBoxColumn47.Name = "DataGridViewTextBoxColumn47"
        Me.DataGridViewTextBoxColumn47.ReadOnly = True
        '
        'DataGridViewTextBoxColumn48
        '
        Me.DataGridViewTextBoxColumn48.DataPropertyName = "UsersModify"
        Me.DataGridViewTextBoxColumn48.HeaderText = "Modify User"
        Me.DataGridViewTextBoxColumn48.Name = "DataGridViewTextBoxColumn48"
        Me.DataGridViewTextBoxColumn48.ReadOnly = True
        '
        'DataGridViewTextBoxColumn49
        '
        Me.DataGridViewTextBoxColumn49.DataPropertyName = "DateModify"
        Me.DataGridViewTextBoxColumn49.HeaderText = "Fecha de Modificación"
        Me.DataGridViewTextBoxColumn49.Name = "DataGridViewTextBoxColumn49"
        Me.DataGridViewTextBoxColumn49.ReadOnly = True
        '
        'FlowLayoutPanel11
        '
        Me.FlowLayoutPanel11.Controls.Add(Me.btnCrearTipoDocumento)
        Me.FlowLayoutPanel11.Controls.Add(Me.btnActualizarTipoDocumento)
        Me.FlowLayoutPanel11.Controls.Add(Me.btnEliminarTipoDocumento)
        Me.FlowLayoutPanel11.Controls.Add(Me.btnListadoTipoDocumento)
        Me.FlowLayoutPanel11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel11.Location = New System.Drawing.Point(3, 3)
        Me.FlowLayoutPanel11.Name = "FlowLayoutPanel11"
        Me.FlowLayoutPanel11.Size = New System.Drawing.Size(1081, 75)
        Me.FlowLayoutPanel11.TabIndex = 1
        '
        'btnCrearTipoDocumento
        '
        Me.btnCrearTipoDocumento.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.btnCrearTipoDocumento.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.btnCrearTipoDocumento.FlatAppearance.BorderSize = 0
        Me.btnCrearTipoDocumento.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnCrearTipoDocumento.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnCrearTipoDocumento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCrearTipoDocumento.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCrearTipoDocumento.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnCrearTipoDocumento.Location = New System.Drawing.Point(3, 3)
        Me.btnCrearTipoDocumento.Name = "btnCrearTipoDocumento"
        Me.btnCrearTipoDocumento.Size = New System.Drawing.Size(121, 66)
        Me.btnCrearTipoDocumento.TabIndex = 40
        Me.btnCrearTipoDocumento.Text = "Crear"
        Me.btnCrearTipoDocumento.UseVisualStyleBackColor = False
        '
        'btnActualizarTipoDocumento
        '
        Me.btnActualizarTipoDocumento.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.btnActualizarTipoDocumento.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.btnActualizarTipoDocumento.FlatAppearance.BorderSize = 0
        Me.btnActualizarTipoDocumento.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnActualizarTipoDocumento.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnActualizarTipoDocumento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnActualizarTipoDocumento.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActualizarTipoDocumento.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnActualizarTipoDocumento.Location = New System.Drawing.Point(130, 3)
        Me.btnActualizarTipoDocumento.Name = "btnActualizarTipoDocumento"
        Me.btnActualizarTipoDocumento.Size = New System.Drawing.Size(121, 66)
        Me.btnActualizarTipoDocumento.TabIndex = 38
        Me.btnActualizarTipoDocumento.Text = "Modificar"
        Me.btnActualizarTipoDocumento.UseVisualStyleBackColor = False
        '
        'btnEliminarTipoDocumento
        '
        Me.btnEliminarTipoDocumento.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.btnEliminarTipoDocumento.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.btnEliminarTipoDocumento.FlatAppearance.BorderSize = 0
        Me.btnEliminarTipoDocumento.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnEliminarTipoDocumento.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnEliminarTipoDocumento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminarTipoDocumento.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarTipoDocumento.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnEliminarTipoDocumento.Location = New System.Drawing.Point(257, 3)
        Me.btnEliminarTipoDocumento.Name = "btnEliminarTipoDocumento"
        Me.btnEliminarTipoDocumento.Size = New System.Drawing.Size(121, 66)
        Me.btnEliminarTipoDocumento.TabIndex = 39
        Me.btnEliminarTipoDocumento.Text = "Eliminar"
        Me.btnEliminarTipoDocumento.UseVisualStyleBackColor = False
        '
        'btnListadoTipoDocumento
        '
        Me.btnListadoTipoDocumento.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.btnListadoTipoDocumento.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.btnListadoTipoDocumento.FlatAppearance.BorderSize = 0
        Me.btnListadoTipoDocumento.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnListadoTipoDocumento.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnListadoTipoDocumento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnListadoTipoDocumento.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnListadoTipoDocumento.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnListadoTipoDocumento.Location = New System.Drawing.Point(384, 3)
        Me.btnListadoTipoDocumento.Name = "btnListadoTipoDocumento"
        Me.btnListadoTipoDocumento.Size = New System.Drawing.Size(119, 66)
        Me.btnListadoTipoDocumento.TabIndex = 43
        Me.btnListadoTipoDocumento.Text = "Listado Tipo de Proveedor"
        Me.btnListadoTipoDocumento.UseVisualStyleBackColor = False
        '
        'ModuloCuentasPorPagar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.tcMain)
        Me.Name = "ModuloCuentasPorPagar"
        Me.Size = New System.Drawing.Size(1095, 579)
        Me.tcMain.ResumeLayout(False)
        Me.VistaGeneral.ResumeLayout(False)
        Me.gbStudentDetails.ResumeLayout(False)
        Me.ClientesMora.ResumeLayout(False)
        Me.TLP_PlanDePagos.ResumeLayout(False)
        CType(Me.DGV_CustomMora, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel3.ResumeLayout(False)
        Me.GraficosFacturacion.ResumeLayout(False)
        Me.CuentasActivas.ResumeLayout(False)
        Me.TLP_Clientes.ResumeLayout(False)
        CType(Me.DGVClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel5.ResumeLayout(False)
        Me.DocumentType.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.dgvDocumentType, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel11.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents tcMain As TabControl
    Private WithEvents VistaGeneral As TabPage
    Private WithEvents gbStudentDetails As GroupBox
    Friend WithEvents ClientesMora As TabPage
    Friend WithEvents GraficosFacturacion As TabPage
    Friend WithEvents Financiero_GraficoFacturacion1 As Financiero_GraficoFacturacion
    Friend WithEvents CuentasActivas As TabPage
    Friend WithEvents TLP_Clientes As TableLayoutPanel
    Friend WithEvents FlowLayoutPanel5 As FlowLayoutPanel
    Private WithEvents cmdCrearCliente As Button
    Private WithEvents cmdModificarCliente As Button
    Private WithEvents cmdReporteCatalogoCliente As Button
    Private WithEvents cmdCatalogoClienteFinanciero As Button
    Private WithEvents cmdFichaCliente As Button
    Private WithEvents cmdAgregarCxC As Button
    Private WithEvents cmdCuentaCxC_AgregarCobro As Button
    Friend WithEvents TLP_PlanDePagos As TableLayoutPanel
    Friend WithEvents FlowLayoutPanel3 As FlowLayoutPanel
    Private WithEvents cmdCuotaClienteMora As Button
    Friend WithEvents DGV_CustomMora As DataGridView
    Friend WithEvents DGVClientes As DataGridView
    Private WithEvents cmdReportPayableAccounts As Button
    Private WithEvents cmdCuentasActivasPagosRealizados As Button
    Private WithEvents cmdCuentasActivasPagosRealizadosCliente As Button
    Private WithEvents cmdCuentasActivasPagosVencidos As Button
    Private WithEvents cmdCuentasActivasPagosVencidosCliente As Button
    Private WithEvents cmdCuentasActivasPagosProximos As Button
    Private WithEvents cmdCuentasActivasPagosCliente As Button
    Friend WithEvents flpCalendar As FlowLayoutPanel
    Friend WithEvents DocumentType As TabPage
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents dgvDocumentType As DataGridView
    Friend WithEvents FlowLayoutPanel11 As FlowLayoutPanel
    Private WithEvents btnCrearTipoDocumento As Button
    Private WithEvents btnActualizarTipoDocumento As Button
    Private WithEvents btnEliminarTipoDocumento As Button
    Private WithEvents btnListadoTipoDocumento As Button
    Friend WithEvents ID_CreditDocument As DataGridViewTextBoxColumn
    Friend WithEvents Description As DataGridViewTextBoxColumn
    Friend WithEvents Is_Invoice As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn46 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn47 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn48 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn49 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents SaldoMora As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents ID_Customer As DataGridViewTextBoxColumn
    Friend WithEvents ID_Customer_FK As DataGridViewTextBoxColumn
    Friend WithEvents Is_Supplier As DataGridViewCheckBoxColumn
    Friend WithEvents Tipo_Cliente As DataGridViewTextBoxColumn
    Friend WithEvents Cliente_RazonSocial As DataGridViewTextBoxColumn
    Friend WithEvents Nombre_Comercial As DataGridViewTextBoxColumn
    Friend WithEvents Tel_Oficina As DataGridViewTextBoxColumn
    Friend WithEvents CorreoContacto As DataGridViewTextBoxColumn
End Class
