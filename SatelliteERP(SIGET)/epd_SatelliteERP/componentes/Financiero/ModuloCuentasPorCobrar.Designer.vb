<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ModuloCuentasPorCobrar
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
        Dim ChartArea5 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend5 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series7 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea6 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend6 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series8 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea7 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend7 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series9 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea8 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend8 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series10 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series11 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series12 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.tcMain = New System.Windows.Forms.TabControl()
        Me.VistaGeneral = New System.Windows.Forms.TabPage()
        Me.gbStudentDetails = New System.Windows.Forms.GroupBox()
        Me.flpCalendar = New System.Windows.Forms.FlowLayoutPanel()
        Me.Facturacion = New System.Windows.Forms.TabPage()
        Me.TLP_Facturacion = New System.Windows.Forms.TableLayoutPanel()
        Me.DGW_FacturasLista = New System.Windows.Forms.DataGridView()
        Me.imagen = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Correlativo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BusinessDay = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Commercial_Name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fullpayment = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DocumentNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescriptionCustomer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateCreate1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusTransaction = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.FechaAnulacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsuarioAnulo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.cmdCreateFactura = New System.Windows.Forms.Button()
        Me.cmdCreateCF = New System.Windows.Forms.Button()
        Me.cmdFacturacion_Re_Print = New System.Windows.Forms.Button()
        Me.cmdCorreoFactura = New System.Windows.Forms.Button()
        Me.cmdFacturacion_Anulacion = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.BusquedaGeneral1 = New epd_SatelliteERP.BusquedaGeneral()
        Me.Calendar1 = New epd_SatelliteERP.calendar()
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
        Me.FlowLayoutPanel3 = New System.Windows.Forms.FlowLayoutPanel()
        Me.cmdCuotaClienteMora = New System.Windows.Forms.Button()
        Me.cmdCxCMora_Autorizaciones = New System.Windows.Forms.Button()
        Me.cmdIndicador = New System.Windows.Forms.Button()
        Me.cmdMontosVencidos = New System.Windows.Forms.Button()
        Me.cmdCuentasActivas_DeudasVendedor = New System.Windows.Forms.Button()
        Me.Proyectos = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.DGV_Proyectos = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn26 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn27 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreProyecto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn28 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn30 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AvanceProyecto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn31 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn32 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn33 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn34 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FlowLayoutPanel6 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Cotizaciones = New System.Windows.Forms.TabPage()
        Me.TLP_Cotizaciones = New System.Windows.Forms.TableLayoutPanel()
        Me.DGW_CotizacionLista = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn2 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FlowLayoutPanel4 = New System.Windows.Forms.FlowLayoutPanel()
        Me.cmdCotizacionCF_Crear = New System.Windows.Forms.Button()
        Me.cmdCotizacionFactura_Crear = New System.Windows.Forms.Button()
        Me.cmdCotizacionFactura_Modificar = New System.Windows.Forms.Button()
        Me.cmdCotizacionCF_ReImpresion = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.cmdCotizacion_Anular = New System.Windows.Forms.Button()
        Me.cmdCotizacion_ConvertirFactura = New System.Windows.Forms.Button()
        Me.cmdCotizaciones_OrdenProduccion = New System.Windows.Forms.Button()
        Me.cmdCotizaciones_EntregaVendedor = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.ConfigurarFacturas = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.cmd_ConfigFactura_Preview = New System.Windows.Forms.Button()
        Me.cmd_ConfigCF_Preview = New System.Windows.Forms.Button()
        Me.cmd_ConfigFactura_Config = New System.Windows.Forms.Button()
        Me.cmd_ConfigCF_Config = New System.Windows.Forms.Button()
        Me.cmd_ConfigCF_ZoomMAS = New System.Windows.Forms.Button()
        Me.cmd_ConfigCF_ZoomMenos = New System.Windows.Forms.Button()
        Me.Panel_ConfiguracionFacturaTrabajo = New System.Windows.Forms.Panel()
        Me.PPC_ConfigFactura = New System.Windows.Forms.PrintPreviewControl()
        Me.GraficosFacturacion = New System.Windows.Forms.TabPage()
        Me.CuentasActivas = New System.Windows.Forms.TabPage()
        Me.TLP_Clientes = New System.Windows.Forms.TableLayoutPanel()
        Me.DGVClientes = New System.Windows.Forms.DataGridView()
        Me.Id_Customer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Is_Supplier = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn25 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Email_Contact = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FLPCuentasActivas = New System.Windows.Forms.FlowLayoutPanel()
        Me.cmdCrearCliente = New System.Windows.Forms.Button()
        Me.cmdModificarCliente = New System.Windows.Forms.Button()
        Me.cmdLineaCredito = New System.Windows.Forms.Button()
        Me.cmdCuentasActivas_CrearManual = New System.Windows.Forms.Button()
        Me.cmdCuentaCxC_AgregarCobro = New System.Windows.Forms.Button()
        Me.cmdReporteCatalogoCliente = New System.Windows.Forms.Button()
        Me.cmdCatalogoClienteFinanciero = New System.Windows.Forms.Button()
        Me.cmdFichaCliente = New System.Windows.Forms.Button()
        Me.cmdCuentasActivas_EstadoCuentaCliente = New System.Windows.Forms.Button()
        Me.cmdCuentaActiva_PagoCuotaFecha = New System.Windows.Forms.Button()
        Me.cmdCuentaActiva_EstadoPagos = New System.Windows.Forms.Button()
        Me.cmd_CuentasActivas_AddPayment = New System.Windows.Forms.Button()
        Me.cmdCuentasActivas_DeudasClientes = New System.Windows.Forms.Button()
        Me.cmdCuentasActivas_CotizacionPorCliente = New System.Windows.Forms.Button()
        Me.cmdPagos = New System.Windows.Forms.Button()
        Me.btnLogEntriesExitsActualMonth = New System.Windows.Forms.Button()
        Me.btnLogEntriesExitsActualYear = New System.Windows.Forms.Button()
        Me.btnLogEntriesExitsActualFilter = New System.Windows.Forms.Button()
        Me.IndicadorVentas = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblHoras = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.chartHoras = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.lblMes = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.lblAnio = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.ChartAnio = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.ChartMes = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.EntradasySalidas = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.ChartAnalisis = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.lblEntradasSalidas = New System.Windows.Forms.Label()
        Me.TypeCreditLine = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.dgvTypeCreditLine = New System.Windows.Forms.DataGridView()
        Me.Id_TypeCreditLine = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Type_CreditLine = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescriptionCreditLine = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn51 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn52 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn53 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn54 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FlowLayoutPanel12 = New System.Windows.Forms.FlowLayoutPanel()
        Me.cmdCrearTypeCreditLine = New System.Windows.Forms.Button()
        Me.cmdActualizarTypeCreditLine = New System.Windows.Forms.Button()
        Me.cmdEliminarTypeCreditLine = New System.Windows.Forms.Button()
        Me.cmdListadoTypeCreditLine = New System.Windows.Forms.Button()
        Me.PartialPaymentsCatalog = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel7 = New System.Windows.Forms.TableLayoutPanel()
        Me.dgvPartialPayments = New System.Windows.Forms.DataGridView()
        Me.Id_Catalog = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescriptionCatalog = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn36 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn37 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn38 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn39 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FlowLayoutPanel5 = New System.Windows.Forms.FlowLayoutPanel()
        Me.cmdCrearPartialPayment = New System.Windows.Forms.Button()
        Me.cmdActualizarPartialPayment = New System.Windows.Forms.Button()
        Me.cmdEliminarPartialPayment = New System.Windows.Forms.Button()
        Me.cmdListadoPartialPayment = New System.Windows.Forms.Button()
        Me.ComprasIngreso = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel8 = New System.Windows.Forms.TableLayoutPanel()
        Me.DGW_ComprasLista = New System.Windows.Forms.DataGridView()
        Me.imagenCompra = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn29 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn35 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn40 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn41 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn42 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn43 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn44 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn45 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn46 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FLP_IngresoCompras = New System.Windows.Forms.FlowLayoutPanel()
        Me.cmdCompraFactura = New System.Windows.Forms.Button()
        Me.cmdCompraCreditoFiscal = New System.Windows.Forms.Button()
        Me.cmdCompraImportado = New System.Windows.Forms.Button()
        Me.cmdLibroVentasFactura = New System.Windows.Forms.Button()
        Me.cmdImpresionLibroCreditoFiscal = New System.Windows.Forms.Button()
        Me.cmdComprasLibro = New System.Windows.Forms.Button()
        Me.BusquedaGeneral2 = New epd_SatelliteERP.BusquedaGeneral()
        Me.Calendar2 = New epd_SatelliteERP.calendar()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.tcMain.SuspendLayout()
        Me.VistaGeneral.SuspendLayout()
        Me.gbStudentDetails.SuspendLayout()
        Me.Facturacion.SuspendLayout()
        Me.TLP_Facturacion.SuspendLayout()
        CType(Me.DGW_FacturasLista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.ClientesMora.SuspendLayout()
        Me.TLP_PlanDePagos.SuspendLayout()
        CType(Me.DGV_CustomMora, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel3.SuspendLayout()
        Me.Proyectos.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.DGV_Proyectos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel6.SuspendLayout()
        Me.Cotizaciones.SuspendLayout()
        Me.TLP_Cotizaciones.SuspendLayout()
        CType(Me.DGW_CotizacionLista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel4.SuspendLayout()
        Me.ConfigurarFacturas.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.Panel_ConfiguracionFacturaTrabajo.SuspendLayout()
        Me.CuentasActivas.SuspendLayout()
        Me.TLP_Clientes.SuspendLayout()
        CType(Me.DGVClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FLPCuentasActivas.SuspendLayout()
        Me.IndicadorVentas.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.chartHoras, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.ChartAnio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.ChartMes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EntradasySalidas.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.Panel8.SuspendLayout()
        CType(Me.ChartAnalisis, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel7.SuspendLayout()
        Me.TypeCreditLine.SuspendLayout()
        Me.TableLayoutPanel6.SuspendLayout()
        CType(Me.dgvTypeCreditLine, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel12.SuspendLayout()
        Me.PartialPaymentsCatalog.SuspendLayout()
        Me.TableLayoutPanel7.SuspendLayout()
        CType(Me.dgvPartialPayments, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel5.SuspendLayout()
        Me.ComprasIngreso.SuspendLayout()
        Me.TableLayoutPanel8.SuspendLayout()
        CType(Me.DGW_ComprasLista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FLP_IngresoCompras.SuspendLayout()
        Me.SuspendLayout()
        '
        'tcMain
        '
        Me.tcMain.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.tcMain.Controls.Add(Me.VistaGeneral)
        Me.tcMain.Controls.Add(Me.Facturacion)
        Me.tcMain.Controls.Add(Me.ClientesMora)
        Me.tcMain.Controls.Add(Me.Proyectos)
        Me.tcMain.Controls.Add(Me.Cotizaciones)
        Me.tcMain.Controls.Add(Me.ConfigurarFacturas)
        Me.tcMain.Controls.Add(Me.GraficosFacturacion)
        Me.tcMain.Controls.Add(Me.CuentasActivas)
        Me.tcMain.Controls.Add(Me.IndicadorVentas)
        Me.tcMain.Controls.Add(Me.EntradasySalidas)
        Me.tcMain.Controls.Add(Me.TypeCreditLine)
        Me.tcMain.Controls.Add(Me.PartialPaymentsCatalog)
        Me.tcMain.Controls.Add(Me.ComprasIngreso)
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
        Me.gbStudentDetails.Text = "Calendario Cuentas por Cobrar"
        '
        'flpCalendar
        '
        Me.flpCalendar.AutoScroll = True
        Me.flpCalendar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flpCalendar.Location = New System.Drawing.Point(3, 21)
        Me.flpCalendar.Name = "flpCalendar"
        Me.flpCalendar.Size = New System.Drawing.Size(1073, 508)
        Me.flpCalendar.TabIndex = 0
        '
        'Facturacion
        '
        Me.Facturacion.Controls.Add(Me.TLP_Facturacion)
        Me.Facturacion.Location = New System.Drawing.Point(4, 35)
        Me.Facturacion.Name = "Facturacion"
        Me.Facturacion.Size = New System.Drawing.Size(1087, 540)
        Me.Facturacion.TabIndex = 4
        Me.Facturacion.Text = "Facturación"
        Me.Facturacion.UseVisualStyleBackColor = True
        '
        'TLP_Facturacion
        '
        Me.TLP_Facturacion.ColumnCount = 1
        Me.TLP_Facturacion.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLP_Facturacion.Controls.Add(Me.DGW_FacturasLista, 0, 1)
        Me.TLP_Facturacion.Controls.Add(Me.FlowLayoutPanel1, 0, 0)
        Me.TLP_Facturacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TLP_Facturacion.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TLP_Facturacion.Location = New System.Drawing.Point(0, 0)
        Me.TLP_Facturacion.Name = "TLP_Facturacion"
        Me.TLP_Facturacion.RowCount = 2
        Me.TLP_Facturacion.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75.0!))
        Me.TLP_Facturacion.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLP_Facturacion.Size = New System.Drawing.Size(1087, 540)
        Me.TLP_Facturacion.TabIndex = 1
        '
        'DGW_FacturasLista
        '
        Me.DGW_FacturasLista.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGW_FacturasLista.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.imagen, Me.Correlativo, Me.BusinessDay, Me.Commercial_Name, Me.Fullpayment, Me.DocumentNumber, Me.DescriptionCustomer, Me.Column8, Me.DateCreate1, Me.StatusTransaction, Me.FechaAnulacion, Me.UsuarioAnulo})
        Me.DGW_FacturasLista.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGW_FacturasLista.EnableHeadersVisualStyles = False
        Me.DGW_FacturasLista.Location = New System.Drawing.Point(3, 78)
        Me.DGW_FacturasLista.Name = "DGW_FacturasLista"
        Me.DGW_FacturasLista.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DGW_FacturasLista.RowHeadersVisible = False
        Me.DGW_FacturasLista.ShowCellErrors = False
        Me.DGW_FacturasLista.ShowCellToolTips = False
        Me.DGW_FacturasLista.ShowEditingIcon = False
        Me.DGW_FacturasLista.ShowRowErrors = False
        Me.DGW_FacturasLista.Size = New System.Drawing.Size(1081, 459)
        Me.DGW_FacturasLista.TabIndex = 0
        '
        'imagen
        '
        Me.imagen.HeaderText = ""
        Me.imagen.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch
        Me.imagen.Name = "imagen"
        Me.imagen.Width = 50
        '
        'Correlativo
        '
        Me.Correlativo.DataPropertyName = "ID_TransactionHeader"
        Me.Correlativo.HeaderText = "Correlativo"
        Me.Correlativo.Name = "Correlativo"
        Me.Correlativo.Width = 107
        '
        'BusinessDay
        '
        Me.BusinessDay.DataPropertyName = "BusinessDay"
        Me.BusinessDay.HeaderText = "Fecha"
        Me.BusinessDay.Name = "BusinessDay"
        Me.BusinessDay.Width = 72
        '
        'Commercial_Name
        '
        Me.Commercial_Name.DataPropertyName = "Commercial_Name"
        Me.Commercial_Name.HeaderText = "Cliente / Razón Social"
        Me.Commercial_Name.Name = "Commercial_Name"
        Me.Commercial_Name.Width = 179
        '
        'Fullpayment
        '
        Me.Fullpayment.DataPropertyName = "Fullpayment"
        Me.Fullpayment.HeaderText = "Total Factura"
        Me.Fullpayment.Name = "Fullpayment"
        Me.Fullpayment.Width = 120
        '
        'DocumentNumber
        '
        Me.DocumentNumber.DataPropertyName = "DocumentNumber"
        Me.DocumentNumber.HeaderText = "No. Fac/CF"
        Me.DocumentNumber.Name = "DocumentNumber"
        Me.DocumentNumber.Width = 105
        '
        'DescriptionCustomer
        '
        Me.DescriptionCustomer.DataPropertyName = "DescriptionCustomer"
        Me.DescriptionCustomer.HeaderText = "Tipo doc."
        Me.DescriptionCustomer.Name = "DescriptionCustomer"
        Me.DescriptionCustomer.Width = 96
        '
        'Column8
        '
        Me.Column8.DataPropertyName = "UsersCreate"
        Me.Column8.HeaderText = "Usuario"
        Me.Column8.Name = "Column8"
        Me.Column8.Width = 84
        '
        'DateCreate1
        '
        Me.DateCreate1.DataPropertyName = "DateCreate"
        Me.DateCreate1.HeaderText = "Fecha Creación"
        Me.DateCreate1.Name = "DateCreate1"
        Me.DateCreate1.Width = 134
        '
        'StatusTransaction
        '
        Me.StatusTransaction.DataPropertyName = "StatusTransaction"
        Me.StatusTransaction.HeaderText = "Activo"
        Me.StatusTransaction.Name = "StatusTransaction"
        Me.StatusTransaction.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.StatusTransaction.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.StatusTransaction.Width = 106
        '
        'FechaAnulacion
        '
        Me.FechaAnulacion.DataPropertyName = "DateCancellation"
        Me.FechaAnulacion.HeaderText = "Fecha Anulación"
        Me.FechaAnulacion.Name = "FechaAnulacion"
        Me.FechaAnulacion.Width = 142
        '
        'UsuarioAnulo
        '
        Me.UsuarioAnulo.DataPropertyName = "UsersCancellation"
        Me.UsuarioAnulo.HeaderText = "usuarioAnulo"
        Me.UsuarioAnulo.Name = "UsuarioAnulo"
        Me.UsuarioAnulo.Width = 121
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.cmdCreateFactura)
        Me.FlowLayoutPanel1.Controls.Add(Me.cmdCreateCF)
        Me.FlowLayoutPanel1.Controls.Add(Me.cmdFacturacion_Re_Print)
        Me.FlowLayoutPanel1.Controls.Add(Me.cmdCorreoFactura)
        Me.FlowLayoutPanel1.Controls.Add(Me.cmdFacturacion_Anulacion)
        Me.FlowLayoutPanel1.Controls.Add(Me.Button1)
        Me.FlowLayoutPanel1.Controls.Add(Me.Button4)
        Me.FlowLayoutPanel1.Controls.Add(Me.BusquedaGeneral1)
        Me.FlowLayoutPanel1.Controls.Add(Me.Calendar1)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(1081, 69)
        Me.FlowLayoutPanel1.TabIndex = 1
        '
        'cmdCreateFactura
        '
        Me.cmdCreateFactura.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.cmdCreateFactura.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdCreateFactura.FlatAppearance.BorderSize = 0
        Me.cmdCreateFactura.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdCreateFactura.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdCreateFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCreateFactura.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCreateFactura.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdCreateFactura.Location = New System.Drawing.Point(3, 3)
        Me.cmdCreateFactura.Name = "cmdCreateFactura"
        Me.cmdCreateFactura.Size = New System.Drawing.Size(98, 66)
        Me.cmdCreateFactura.TabIndex = 31
        Me.cmdCreateFactura.Text = "Crear Factura"
        Me.cmdCreateFactura.UseVisualStyleBackColor = False
        '
        'cmdCreateCF
        '
        Me.cmdCreateCF.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.cmdCreateCF.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdCreateCF.FlatAppearance.BorderSize = 0
        Me.cmdCreateCF.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdCreateCF.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdCreateCF.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCreateCF.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCreateCF.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdCreateCF.Location = New System.Drawing.Point(107, 3)
        Me.cmdCreateCF.Name = "cmdCreateCF"
        Me.cmdCreateCF.Size = New System.Drawing.Size(113, 66)
        Me.cmdCreateCF.TabIndex = 33
        Me.cmdCreateCF.Text = "Crear " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Crédito Fiscal"
        Me.cmdCreateCF.UseVisualStyleBackColor = False
        '
        'cmdFacturacion_Re_Print
        '
        Me.cmdFacturacion_Re_Print.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.cmdFacturacion_Re_Print.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdFacturacion_Re_Print.FlatAppearance.BorderSize = 0
        Me.cmdFacturacion_Re_Print.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdFacturacion_Re_Print.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdFacturacion_Re_Print.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdFacturacion_Re_Print.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdFacturacion_Re_Print.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdFacturacion_Re_Print.Location = New System.Drawing.Point(226, 3)
        Me.cmdFacturacion_Re_Print.Name = "cmdFacturacion_Re_Print"
        Me.cmdFacturacion_Re_Print.Size = New System.Drawing.Size(112, 66)
        Me.cmdFacturacion_Re_Print.TabIndex = 32
        Me.cmdFacturacion_Re_Print.Text = "Re-imprimir FAC/CF"
        Me.cmdFacturacion_Re_Print.UseVisualStyleBackColor = False
        '
        'cmdCorreoFactura
        '
        Me.cmdCorreoFactura.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.cmdCorreoFactura.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdCorreoFactura.FlatAppearance.BorderSize = 0
        Me.cmdCorreoFactura.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdCorreoFactura.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdCorreoFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCorreoFactura.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCorreoFactura.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdCorreoFactura.Location = New System.Drawing.Point(344, 3)
        Me.cmdCorreoFactura.Name = "cmdCorreoFactura"
        Me.cmdCorreoFactura.Size = New System.Drawing.Size(112, 66)
        Me.cmdCorreoFactura.TabIndex = 34
        Me.cmdCorreoFactura.Text = "Envío Correo FAC/CF"
        Me.cmdCorreoFactura.UseVisualStyleBackColor = False
        '
        'cmdFacturacion_Anulacion
        '
        Me.cmdFacturacion_Anulacion.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.cmdFacturacion_Anulacion.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdFacturacion_Anulacion.FlatAppearance.BorderSize = 0
        Me.cmdFacturacion_Anulacion.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdFacturacion_Anulacion.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdFacturacion_Anulacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdFacturacion_Anulacion.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdFacturacion_Anulacion.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdFacturacion_Anulacion.Location = New System.Drawing.Point(462, 3)
        Me.cmdFacturacion_Anulacion.Name = "cmdFacturacion_Anulacion"
        Me.cmdFacturacion_Anulacion.Size = New System.Drawing.Size(112, 66)
        Me.cmdFacturacion_Anulacion.TabIndex = 35
        Me.cmdFacturacion_Anulacion.Text = "Anular FAC/CF"
        Me.cmdFacturacion_Anulacion.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button1.Location = New System.Drawing.Point(580, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(123, 66)
        Me.Button1.TabIndex = 43
        Me.Button1.Text = "Listado facturas mes*"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.Button4.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button4.Location = New System.Drawing.Point(709, 3)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(174, 66)
        Me.Button4.TabIndex = 44
        Me.Button4.Text = "Archivo de Salida para contabilidad"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'BusquedaGeneral1
        '
        Me.BusquedaGeneral1.Location = New System.Drawing.Point(890, 5)
        Me.BusquedaGeneral1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BusquedaGeneral1.Name = "BusquedaGeneral1"
        Me.BusquedaGeneral1.Size = New System.Drawing.Size(173, 57)
        Me.BusquedaGeneral1.TabIndex = 46
        '
        'Calendar1
        '
        Me.Calendar1.CalendarDimensions = New System.Drawing.Size(0, 0)
        Me.Calendar1.Location = New System.Drawing.Point(4, 77)
        Me.Calendar1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Calendar1.Name = "Calendar1"
        Me.Calendar1.OpcionCuenta = epd_SatelliteERP.calendar.TipoCuenta.Cuenta_Cobrar
        Me.Calendar1.Size = New System.Drawing.Size(1196, 697)
        Me.Calendar1.TabIndex = 45
        '
        'ClientesMora
        '
        Me.ClientesMora.Controls.Add(Me.TLP_PlanDePagos)
        Me.ClientesMora.Location = New System.Drawing.Point(4, 35)
        Me.ClientesMora.Name = "ClientesMora"
        Me.ClientesMora.Size = New System.Drawing.Size(1087, 540)
        Me.ClientesMora.TabIndex = 5
        Me.ClientesMora.Text = "CxC Mora"
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
        Me.TLP_PlanDePagos.TabIndex = 2
        '
        'DGV_CustomMora
        '
        Me.DGV_CustomMora.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGV_CustomMora.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.SaldoMora, Me.Column1})
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
        Me.DGV_CustomMora.TabIndex = 0
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
        Me.DataGridViewTextBoxColumn4.HeaderText = "Linea Crédito"
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
        'FlowLayoutPanel3
        '
        Me.FlowLayoutPanel3.Controls.Add(Me.cmdCuotaClienteMora)
        Me.FlowLayoutPanel3.Controls.Add(Me.cmdCxCMora_Autorizaciones)
        Me.FlowLayoutPanel3.Controls.Add(Me.cmdIndicador)
        Me.FlowLayoutPanel3.Controls.Add(Me.cmdMontosVencidos)
        Me.FlowLayoutPanel3.Controls.Add(Me.cmdCuentasActivas_DeudasVendedor)
        Me.FlowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel3.Location = New System.Drawing.Point(3, 3)
        Me.FlowLayoutPanel3.Name = "FlowLayoutPanel3"
        Me.FlowLayoutPanel3.Size = New System.Drawing.Size(1081, 69)
        Me.FlowLayoutPanel3.TabIndex = 1
        '
        'cmdCuotaClienteMora
        '
        Me.cmdCuotaClienteMora.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.cmdCuotaClienteMora.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdCuotaClienteMora.FlatAppearance.BorderSize = 0
        Me.cmdCuotaClienteMora.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdCuotaClienteMora.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdCuotaClienteMora.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCuotaClienteMora.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCuotaClienteMora.Location = New System.Drawing.Point(3, 3)
        Me.cmdCuotaClienteMora.Name = "cmdCuotaClienteMora"
        Me.cmdCuotaClienteMora.Size = New System.Drawing.Size(142, 66)
        Me.cmdCuotaClienteMora.TabIndex = 43
        Me.cmdCuotaClienteMora.Text = "Pago Cuota o Total"
        Me.cmdCuotaClienteMora.UseVisualStyleBackColor = False
        '
        'cmdCxCMora_Autorizaciones
        '
        Me.cmdCxCMora_Autorizaciones.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.cmdCxCMora_Autorizaciones.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdCxCMora_Autorizaciones.FlatAppearance.BorderSize = 0
        Me.cmdCxCMora_Autorizaciones.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdCxCMora_Autorizaciones.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdCxCMora_Autorizaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCxCMora_Autorizaciones.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCxCMora_Autorizaciones.Location = New System.Drawing.Point(151, 3)
        Me.cmdCxCMora_Autorizaciones.Name = "cmdCxCMora_Autorizaciones"
        Me.cmdCxCMora_Autorizaciones.Size = New System.Drawing.Size(169, 66)
        Me.cmdCxCMora_Autorizaciones.TabIndex = 59
        Me.cmdCxCMora_Autorizaciones.Text = "Autorización Pendientes aprobar"
        Me.cmdCxCMora_Autorizaciones.UseVisualStyleBackColor = False
        '
        'cmdIndicador
        '
        Me.cmdIndicador.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.cmdIndicador.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdIndicador.FlatAppearance.BorderSize = 0
        Me.cmdIndicador.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdIndicador.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdIndicador.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdIndicador.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdIndicador.Location = New System.Drawing.Point(326, 3)
        Me.cmdIndicador.Name = "cmdIndicador"
        Me.cmdIndicador.Size = New System.Drawing.Size(143, 65)
        Me.cmdIndicador.TabIndex = 60
        Me.cmdIndicador.Text = "Top 5 de Cobros Pendientes"
        Me.cmdIndicador.UseVisualStyleBackColor = False
        '
        'cmdMontosVencidos
        '
        Me.cmdMontosVencidos.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.cmdMontosVencidos.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdMontosVencidos.FlatAppearance.BorderSize = 0
        Me.cmdMontosVencidos.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdMontosVencidos.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdMontosVencidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdMontosVencidos.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdMontosVencidos.Location = New System.Drawing.Point(475, 3)
        Me.cmdMontosVencidos.Name = "cmdMontosVencidos"
        Me.cmdMontosVencidos.Size = New System.Drawing.Size(150, 65)
        Me.cmdMontosVencidos.TabIndex = 61
        Me.cmdMontosVencidos.Text = "Indicador Montos Vencidos"
        Me.cmdMontosVencidos.UseVisualStyleBackColor = False
        '
        'cmdCuentasActivas_DeudasVendedor
        '
        Me.cmdCuentasActivas_DeudasVendedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.cmdCuentasActivas_DeudasVendedor.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdCuentasActivas_DeudasVendedor.FlatAppearance.BorderSize = 0
        Me.cmdCuentasActivas_DeudasVendedor.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdCuentasActivas_DeudasVendedor.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdCuentasActivas_DeudasVendedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCuentasActivas_DeudasVendedor.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCuentasActivas_DeudasVendedor.Location = New System.Drawing.Point(631, 3)
        Me.cmdCuentasActivas_DeudasVendedor.Name = "cmdCuentasActivas_DeudasVendedor"
        Me.cmdCuentasActivas_DeudasVendedor.Size = New System.Drawing.Size(143, 66)
        Me.cmdCuentasActivas_DeudasVendedor.TabIndex = 62
        Me.cmdCuentasActivas_DeudasVendedor.Text = "Deudas por Vendedor"
        Me.cmdCuentasActivas_DeudasVendedor.UseVisualStyleBackColor = False
        '
        'Proyectos
        '
        Me.Proyectos.Controls.Add(Me.TableLayoutPanel1)
        Me.Proyectos.Location = New System.Drawing.Point(4, 35)
        Me.Proyectos.Name = "Proyectos"
        Me.Proyectos.Size = New System.Drawing.Size(1087, 540)
        Me.Proyectos.TabIndex = 10
        Me.Proyectos.Text = "Gestión Proyectos"
        Me.Proyectos.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.DGV_Proyectos, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.FlowLayoutPanel6, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1087, 540)
        Me.TableLayoutPanel1.TabIndex = 4
        '
        'DGV_Proyectos
        '
        Me.DGV_Proyectos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.DGV_Proyectos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGV_Proyectos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn26, Me.DataGridViewTextBoxColumn27, Me.NombreProyecto, Me.DataGridViewTextBoxColumn28, Me.DataGridViewTextBoxColumn30, Me.AvanceProyecto, Me.DataGridViewTextBoxColumn31, Me.DataGridViewTextBoxColumn32, Me.DataGridViewTextBoxColumn33, Me.DataGridViewTextBoxColumn34})
        Me.DGV_Proyectos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGV_Proyectos.EnableHeadersVisualStyles = False
        Me.DGV_Proyectos.Location = New System.Drawing.Point(3, 78)
        Me.DGV_Proyectos.Name = "DGV_Proyectos"
        Me.DGV_Proyectos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DGV_Proyectos.RowHeadersVisible = False
        Me.DGV_Proyectos.ShowCellErrors = False
        Me.DGV_Proyectos.ShowCellToolTips = False
        Me.DGV_Proyectos.ShowEditingIcon = False
        Me.DGV_Proyectos.ShowRowErrors = False
        Me.DGV_Proyectos.Size = New System.Drawing.Size(1081, 459)
        Me.DGV_Proyectos.TabIndex = 0
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "ID_Project"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Correlativo"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 107
        '
        'DataGridViewTextBoxColumn26
        '
        Me.DataGridViewTextBoxColumn26.DataPropertyName = "BusinessDay"
        Me.DataGridViewTextBoxColumn26.HeaderText = "Fecha"
        Me.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26"
        Me.DataGridViewTextBoxColumn26.Width = 72
        '
        'DataGridViewTextBoxColumn27
        '
        Me.DataGridViewTextBoxColumn27.DataPropertyName = "Commercial_Name"
        Me.DataGridViewTextBoxColumn27.HeaderText = "Cliente / Razon Social"
        Me.DataGridViewTextBoxColumn27.Name = "DataGridViewTextBoxColumn27"
        Me.DataGridViewTextBoxColumn27.Width = 179
        '
        'NombreProyecto
        '
        Me.NombreProyecto.HeaderText = "Nombre Proyecto"
        Me.NombreProyecto.Name = "NombreProyecto"
        Me.NombreProyecto.Width = 151
        '
        'DataGridViewTextBoxColumn28
        '
        Me.DataGridViewTextBoxColumn28.DataPropertyName = "Fullpayment"
        Me.DataGridViewTextBoxColumn28.HeaderText = "Total Proyecto"
        Me.DataGridViewTextBoxColumn28.Name = "DataGridViewTextBoxColumn28"
        Me.DataGridViewTextBoxColumn28.Width = 130
        '
        'DataGridViewTextBoxColumn30
        '
        Me.DataGridViewTextBoxColumn30.DataPropertyName = "DescriptionCustomer"
        Me.DataGridViewTextBoxColumn30.HeaderText = "Tipo doc."
        Me.DataGridViewTextBoxColumn30.Name = "DataGridViewTextBoxColumn30"
        Me.DataGridViewTextBoxColumn30.Width = 96
        '
        'AvanceProyecto
        '
        Me.AvanceProyecto.HeaderText = "Avance %"
        Me.AvanceProyecto.Name = "AvanceProyecto"
        Me.AvanceProyecto.Width = 98
        '
        'DataGridViewTextBoxColumn31
        '
        Me.DataGridViewTextBoxColumn31.DataPropertyName = "UsersCreate"
        Me.DataGridViewTextBoxColumn31.HeaderText = "Usuario"
        Me.DataGridViewTextBoxColumn31.Name = "DataGridViewTextBoxColumn31"
        Me.DataGridViewTextBoxColumn31.Width = 84
        '
        'DataGridViewTextBoxColumn32
        '
        Me.DataGridViewTextBoxColumn32.DataPropertyName = "DateCreate"
        Me.DataGridViewTextBoxColumn32.HeaderText = "Fecha Creacion"
        Me.DataGridViewTextBoxColumn32.Name = "DataGridViewTextBoxColumn32"
        Me.DataGridViewTextBoxColumn32.Width = 134
        '
        'DataGridViewTextBoxColumn33
        '
        Me.DataGridViewTextBoxColumn33.DataPropertyName = "DateCancellation"
        Me.DataGridViewTextBoxColumn33.HeaderText = "Fecha Anulacion"
        Me.DataGridViewTextBoxColumn33.Name = "DataGridViewTextBoxColumn33"
        Me.DataGridViewTextBoxColumn33.Width = 142
        '
        'DataGridViewTextBoxColumn34
        '
        Me.DataGridViewTextBoxColumn34.DataPropertyName = "UsersCancellation"
        Me.DataGridViewTextBoxColumn34.HeaderText = "usuarioAnulo"
        Me.DataGridViewTextBoxColumn34.Name = "DataGridViewTextBoxColumn34"
        Me.DataGridViewTextBoxColumn34.Width = 121
        '
        'FlowLayoutPanel6
        '
        Me.FlowLayoutPanel6.Controls.Add(Me.Button2)
        Me.FlowLayoutPanel6.Controls.Add(Me.Button3)
        Me.FlowLayoutPanel6.Controls.Add(Me.Button5)
        Me.FlowLayoutPanel6.Controls.Add(Me.Button6)
        Me.FlowLayoutPanel6.Controls.Add(Me.Button7)
        Me.FlowLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel6.Location = New System.Drawing.Point(3, 3)
        Me.FlowLayoutPanel6.Name = "FlowLayoutPanel6"
        Me.FlowLayoutPanel6.Size = New System.Drawing.Size(1081, 69)
        Me.FlowLayoutPanel6.TabIndex = 1
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(3, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(98, 66)
        Me.Button2.TabIndex = 31
        Me.Button2.Text = "Crear Proyecto"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(107, 3)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(113, 66)
        Me.Button3.TabIndex = 33
        Me.Button3.Text = "Modificar Proyecto"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.Button5.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button5.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(226, 3)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(130, 66)
        Me.Button5.TabIndex = 32
        Me.Button5.Text = "Impresión Estado proyecto"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.Button6.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button6.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(362, 3)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(132, 66)
        Me.Button6.TabIndex = 34
        Me.Button6.Text = "Envio Correo Estado Proyecto"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.Button7.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.Button7.FlatAppearance.BorderSize = 0
        Me.Button7.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button7.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Location = New System.Drawing.Point(500, 3)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(112, 66)
        Me.Button7.TabIndex = 35
        Me.Button7.Text = "Anular Proyecto"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Cotizaciones
        '
        Me.Cotizaciones.Controls.Add(Me.TLP_Cotizaciones)
        Me.Cotizaciones.Location = New System.Drawing.Point(4, 35)
        Me.Cotizaciones.Name = "Cotizaciones"
        Me.Cotizaciones.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.Cotizaciones.Size = New System.Drawing.Size(1087, 540)
        Me.Cotizaciones.TabIndex = 6
        Me.Cotizaciones.Text = "Cotizaciones"
        Me.Cotizaciones.UseVisualStyleBackColor = True
        '
        'TLP_Cotizaciones
        '
        Me.TLP_Cotizaciones.ColumnCount = 1
        Me.TLP_Cotizaciones.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLP_Cotizaciones.Controls.Add(Me.DGW_CotizacionLista, 0, 1)
        Me.TLP_Cotizaciones.Controls.Add(Me.FlowLayoutPanel4, 0, 0)
        Me.TLP_Cotizaciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TLP_Cotizaciones.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TLP_Cotizaciones.Location = New System.Drawing.Point(3, 3)
        Me.TLP_Cotizaciones.Name = "TLP_Cotizaciones"
        Me.TLP_Cotizaciones.RowCount = 2
        Me.TLP_Cotizaciones.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.TLP_Cotizaciones.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLP_Cotizaciones.Size = New System.Drawing.Size(1081, 534)
        Me.TLP_Cotizaciones.TabIndex = 3
        '
        'DGW_CotizacionLista
        '
        Me.DGW_CotizacionLista.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGW_CotizacionLista.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewCheckBoxColumn2, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20})
        Me.DGW_CotizacionLista.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGW_CotizacionLista.EnableHeadersVisualStyles = False
        Me.DGW_CotizacionLista.Location = New System.Drawing.Point(3, 153)
        Me.DGW_CotizacionLista.Name = "DGW_CotizacionLista"
        Me.DGW_CotizacionLista.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DGW_CotizacionLista.RowHeadersVisible = False
        Me.DGW_CotizacionLista.ShowCellErrors = False
        Me.DGW_CotizacionLista.ShowCellToolTips = False
        Me.DGW_CotizacionLista.ShowEditingIcon = False
        Me.DGW_CotizacionLista.ShowRowErrors = False
        Me.DGW_CotizacionLista.Size = New System.Drawing.Size(1075, 378)
        Me.DGW_CotizacionLista.TabIndex = 0
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "ID_TransactionHeader"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Correlativo"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.Width = 107
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "BusinessDay"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Fecha"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.Width = 72
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "Commercial_Name"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Cliente / Razón Social"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.Width = 179
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "Fullpayment"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Total Factura"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.Width = 118
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "DocumentNumber"
        Me.DataGridViewTextBoxColumn15.HeaderText = "No. Fac/CF"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.Width = 104
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "DescriptionCustomer"
        Me.DataGridViewTextBoxColumn16.HeaderText = "Tipo doc."
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.Width = 96
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "UsersCreate"
        Me.DataGridViewTextBoxColumn17.HeaderText = "Usuario"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.Width = 84
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "DateCreate"
        Me.DataGridViewTextBoxColumn18.HeaderText = "Fecha Creación"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.Width = 134
        '
        'DataGridViewCheckBoxColumn2
        '
        Me.DataGridViewCheckBoxColumn2.DataPropertyName = "StatusTransaction"
        Me.DataGridViewCheckBoxColumn2.HeaderText = "EstadoDoc"
        Me.DataGridViewCheckBoxColumn2.Name = "DataGridViewCheckBoxColumn2"
        Me.DataGridViewCheckBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewCheckBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewCheckBoxColumn2.Width = 106
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "DateCancellation"
        Me.DataGridViewTextBoxColumn19.HeaderText = "Fecha Anulación"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.Width = 142
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "UsersCancellation"
        Me.DataGridViewTextBoxColumn20.HeaderText = "usuarioAnulo"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        Me.DataGridViewTextBoxColumn20.Width = 121
        '
        'FlowLayoutPanel4
        '
        Me.FlowLayoutPanel4.Controls.Add(Me.cmdCotizacionCF_Crear)
        Me.FlowLayoutPanel4.Controls.Add(Me.cmdCotizacionFactura_Crear)
        Me.FlowLayoutPanel4.Controls.Add(Me.cmdCotizacionFactura_Modificar)
        Me.FlowLayoutPanel4.Controls.Add(Me.cmdCotizacionCF_ReImpresion)
        Me.FlowLayoutPanel4.Controls.Add(Me.Button12)
        Me.FlowLayoutPanel4.Controls.Add(Me.cmdCotizacion_Anular)
        Me.FlowLayoutPanel4.Controls.Add(Me.cmdCotizacion_ConvertirFactura)
        Me.FlowLayoutPanel4.Controls.Add(Me.cmdCotizaciones_OrdenProduccion)
        Me.FlowLayoutPanel4.Controls.Add(Me.cmdCotizaciones_EntregaVendedor)
        Me.FlowLayoutPanel4.Controls.Add(Me.Button8)
        Me.FlowLayoutPanel4.Controls.Add(Me.Button9)
        Me.FlowLayoutPanel4.Controls.Add(Me.Button10)
        Me.FlowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel4.Location = New System.Drawing.Point(3, 3)
        Me.FlowLayoutPanel4.Name = "FlowLayoutPanel4"
        Me.FlowLayoutPanel4.Size = New System.Drawing.Size(1075, 144)
        Me.FlowLayoutPanel4.TabIndex = 1
        '
        'cmdCotizacionCF_Crear
        '
        Me.cmdCotizacionCF_Crear.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.cmdCotizacionCF_Crear.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdCotizacionCF_Crear.FlatAppearance.BorderSize = 0
        Me.cmdCotizacionCF_Crear.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdCotizacionCF_Crear.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdCotizacionCF_Crear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCotizacionCF_Crear.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCotizacionCF_Crear.Location = New System.Drawing.Point(3, 3)
        Me.cmdCotizacionCF_Crear.Name = "cmdCotizacionCF_Crear"
        Me.cmdCotizacionCF_Crear.Size = New System.Drawing.Size(119, 66)
        Me.cmdCotizacionCF_Crear.TabIndex = 31
        Me.cmdCotizacionCF_Crear.Text = "Crear Cotización CF"
        Me.cmdCotizacionCF_Crear.UseVisualStyleBackColor = False
        '
        'cmdCotizacionFactura_Crear
        '
        Me.cmdCotizacionFactura_Crear.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.cmdCotizacionFactura_Crear.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdCotizacionFactura_Crear.FlatAppearance.BorderSize = 0
        Me.cmdCotizacionFactura_Crear.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdCotizacionFactura_Crear.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdCotizacionFactura_Crear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCotizacionFactura_Crear.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCotizacionFactura_Crear.Location = New System.Drawing.Point(128, 3)
        Me.cmdCotizacionFactura_Crear.Name = "cmdCotizacionFactura_Crear"
        Me.cmdCotizacionFactura_Crear.Size = New System.Drawing.Size(137, 66)
        Me.cmdCotizacionFactura_Crear.TabIndex = 37
        Me.cmdCotizacionFactura_Crear.Text = "Crear Cotización Factura"
        Me.cmdCotizacionFactura_Crear.UseVisualStyleBackColor = False
        '
        'cmdCotizacionFactura_Modificar
        '
        Me.cmdCotizacionFactura_Modificar.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.cmdCotizacionFactura_Modificar.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdCotizacionFactura_Modificar.FlatAppearance.BorderSize = 0
        Me.cmdCotizacionFactura_Modificar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdCotizacionFactura_Modificar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdCotizacionFactura_Modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCotizacionFactura_Modificar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCotizacionFactura_Modificar.Location = New System.Drawing.Point(271, 3)
        Me.cmdCotizacionFactura_Modificar.Name = "cmdCotizacionFactura_Modificar"
        Me.cmdCotizacionFactura_Modificar.Size = New System.Drawing.Size(113, 66)
        Me.cmdCotizacionFactura_Modificar.TabIndex = 33
        Me.cmdCotizacionFactura_Modificar.Text = "Modificar Cotización"
        Me.cmdCotizacionFactura_Modificar.UseVisualStyleBackColor = False
        '
        'cmdCotizacionCF_ReImpresion
        '
        Me.cmdCotizacionCF_ReImpresion.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.cmdCotizacionCF_ReImpresion.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdCotizacionCF_ReImpresion.FlatAppearance.BorderSize = 0
        Me.cmdCotizacionCF_ReImpresion.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdCotizacionCF_ReImpresion.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdCotizacionCF_ReImpresion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCotizacionCF_ReImpresion.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCotizacionCF_ReImpresion.Location = New System.Drawing.Point(390, 3)
        Me.cmdCotizacionCF_ReImpresion.Name = "cmdCotizacionCF_ReImpresion"
        Me.cmdCotizacionCF_ReImpresion.Size = New System.Drawing.Size(112, 66)
        Me.cmdCotizacionCF_ReImpresion.TabIndex = 32
        Me.cmdCotizacionCF_ReImpresion.Text = "Re-imprimir Cotización"
        Me.cmdCotizacionCF_ReImpresion.UseVisualStyleBackColor = False
        '
        'Button12
        '
        Me.Button12.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.Button12.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.Button12.FlatAppearance.BorderSize = 0
        Me.Button12.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button12.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button12.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button12.Location = New System.Drawing.Point(508, 3)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(112, 66)
        Me.Button12.TabIndex = 34
        Me.Button12.Text = "Envio Correo Cotización"
        Me.Button12.UseVisualStyleBackColor = False
        '
        'cmdCotizacion_Anular
        '
        Me.cmdCotizacion_Anular.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.cmdCotizacion_Anular.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdCotizacion_Anular.FlatAppearance.BorderSize = 0
        Me.cmdCotizacion_Anular.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdCotizacion_Anular.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdCotizacion_Anular.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCotizacion_Anular.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCotizacion_Anular.Location = New System.Drawing.Point(626, 3)
        Me.cmdCotizacion_Anular.Name = "cmdCotizacion_Anular"
        Me.cmdCotizacion_Anular.Size = New System.Drawing.Size(112, 66)
        Me.cmdCotizacion_Anular.TabIndex = 35
        Me.cmdCotizacion_Anular.Text = "Anular Cotización"
        Me.cmdCotizacion_Anular.UseVisualStyleBackColor = False
        '
        'cmdCotizacion_ConvertirFactura
        '
        Me.cmdCotizacion_ConvertirFactura.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.cmdCotizacion_ConvertirFactura.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdCotizacion_ConvertirFactura.FlatAppearance.BorderSize = 0
        Me.cmdCotizacion_ConvertirFactura.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdCotizacion_ConvertirFactura.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdCotizacion_ConvertirFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCotizacion_ConvertirFactura.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCotizacion_ConvertirFactura.Location = New System.Drawing.Point(744, 3)
        Me.cmdCotizacion_ConvertirFactura.Name = "cmdCotizacion_ConvertirFactura"
        Me.cmdCotizacion_ConvertirFactura.Size = New System.Drawing.Size(112, 66)
        Me.cmdCotizacion_ConvertirFactura.TabIndex = 36
        Me.cmdCotizacion_ConvertirFactura.Text = "Convertir Factura/CF"
        Me.cmdCotizacion_ConvertirFactura.UseVisualStyleBackColor = False
        '
        'cmdCotizaciones_OrdenProduccion
        '
        Me.cmdCotizaciones_OrdenProduccion.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.cmdCotizaciones_OrdenProduccion.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdCotizaciones_OrdenProduccion.FlatAppearance.BorderSize = 0
        Me.cmdCotizaciones_OrdenProduccion.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdCotizaciones_OrdenProduccion.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdCotizaciones_OrdenProduccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCotizaciones_OrdenProduccion.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCotizaciones_OrdenProduccion.Location = New System.Drawing.Point(862, 3)
        Me.cmdCotizaciones_OrdenProduccion.Name = "cmdCotizaciones_OrdenProduccion"
        Me.cmdCotizaciones_OrdenProduccion.Size = New System.Drawing.Size(112, 66)
        Me.cmdCotizaciones_OrdenProduccion.TabIndex = 36
        Me.cmdCotizaciones_OrdenProduccion.Text = "Orden de Producción"
        Me.cmdCotizaciones_OrdenProduccion.UseVisualStyleBackColor = False
        '
        'cmdCotizaciones_EntregaVendedor
        '
        Me.cmdCotizaciones_EntregaVendedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.cmdCotizaciones_EntregaVendedor.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdCotizaciones_EntregaVendedor.FlatAppearance.BorderSize = 0
        Me.cmdCotizaciones_EntregaVendedor.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdCotizaciones_EntregaVendedor.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdCotizaciones_EntregaVendedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCotizaciones_EntregaVendedor.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCotizaciones_EntregaVendedor.Location = New System.Drawing.Point(3, 75)
        Me.cmdCotizaciones_EntregaVendedor.Name = "cmdCotizaciones_EntregaVendedor"
        Me.cmdCotizaciones_EntregaVendedor.Size = New System.Drawing.Size(112, 66)
        Me.cmdCotizaciones_EntregaVendedor.TabIndex = 36
        Me.cmdCotizaciones_EntregaVendedor.Text = "Entrega a Vendedor"
        Me.cmdCotizaciones_EntregaVendedor.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.Button8.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.Button8.FlatAppearance.BorderSize = 0
        Me.Button8.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button8.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.Location = New System.Drawing.Point(121, 75)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(137, 66)
        Me.Button8.TabIndex = 41
        Me.Button8.Text = "Recibir Vendedor"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.Button9.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.Button9.FlatAppearance.BorderSize = 0
        Me.Button9.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button9.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button9.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.Location = New System.Drawing.Point(264, 75)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(137, 66)
        Me.Button9.TabIndex = 42
        Me.Button9.Text = "Generar Orden de Producción"
        Me.Button9.UseVisualStyleBackColor = False
        '
        'Button10
        '
        Me.Button10.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.Button10.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.Button10.FlatAppearance.BorderSize = 0
        Me.Button10.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button10.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button10.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button10.Location = New System.Drawing.Point(407, 75)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(166, 66)
        Me.Button10.TabIndex = 42
        Me.Button10.Text = "Reporte de Producción de Flujos"
        Me.Button10.UseVisualStyleBackColor = False
        '
        'ConfigurarFacturas
        '
        Me.ConfigurarFacturas.Controls.Add(Me.TableLayoutPanel3)
        Me.ConfigurarFacturas.Location = New System.Drawing.Point(4, 35)
        Me.ConfigurarFacturas.Name = "ConfigurarFacturas"
        Me.ConfigurarFacturas.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.ConfigurarFacturas.Size = New System.Drawing.Size(1087, 540)
        Me.ConfigurarFacturas.TabIndex = 7
        Me.ConfigurarFacturas.Text = "Configurar Facturas"
        Me.ConfigurarFacturas.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.FlowLayoutPanel2, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Panel_ConfiguracionFacturaTrabajo, 0, 1)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(1081, 534)
        Me.TableLayoutPanel3.TabIndex = 2
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.Controls.Add(Me.cmd_ConfigFactura_Preview)
        Me.FlowLayoutPanel2.Controls.Add(Me.cmd_ConfigCF_Preview)
        Me.FlowLayoutPanel2.Controls.Add(Me.cmd_ConfigFactura_Config)
        Me.FlowLayoutPanel2.Controls.Add(Me.cmd_ConfigCF_Config)
        Me.FlowLayoutPanel2.Controls.Add(Me.cmd_ConfigCF_ZoomMAS)
        Me.FlowLayoutPanel2.Controls.Add(Me.cmd_ConfigCF_ZoomMenos)
        Me.FlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(1075, 69)
        Me.FlowLayoutPanel2.TabIndex = 1
        '
        'cmd_ConfigFactura_Preview
        '
        Me.cmd_ConfigFactura_Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.cmd_ConfigFactura_Preview.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmd_ConfigFactura_Preview.FlatAppearance.BorderSize = 0
        Me.cmd_ConfigFactura_Preview.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmd_ConfigFactura_Preview.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmd_ConfigFactura_Preview.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_ConfigFactura_Preview.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_ConfigFactura_Preview.Location = New System.Drawing.Point(3, 3)
        Me.cmd_ConfigFactura_Preview.Name = "cmd_ConfigFactura_Preview"
        Me.cmd_ConfigFactura_Preview.Size = New System.Drawing.Size(98, 66)
        Me.cmd_ConfigFactura_Preview.TabIndex = 31
        Me.cmd_ConfigFactura_Preview.Text = "Preview Factura"
        Me.cmd_ConfigFactura_Preview.UseVisualStyleBackColor = False
        '
        'cmd_ConfigCF_Preview
        '
        Me.cmd_ConfigCF_Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.cmd_ConfigCF_Preview.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmd_ConfigCF_Preview.FlatAppearance.BorderSize = 0
        Me.cmd_ConfigCF_Preview.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmd_ConfigCF_Preview.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmd_ConfigCF_Preview.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_ConfigCF_Preview.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_ConfigCF_Preview.Location = New System.Drawing.Point(107, 3)
        Me.cmd_ConfigCF_Preview.Name = "cmd_ConfigCF_Preview"
        Me.cmd_ConfigCF_Preview.Size = New System.Drawing.Size(125, 66)
        Me.cmd_ConfigCF_Preview.TabIndex = 32
        Me.cmd_ConfigCF_Preview.Text = "Preview Credito Fiscas"
        Me.cmd_ConfigCF_Preview.UseVisualStyleBackColor = False
        '
        'cmd_ConfigFactura_Config
        '
        Me.cmd_ConfigFactura_Config.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.cmd_ConfigFactura_Config.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmd_ConfigFactura_Config.FlatAppearance.BorderSize = 0
        Me.cmd_ConfigFactura_Config.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmd_ConfigFactura_Config.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmd_ConfigFactura_Config.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_ConfigFactura_Config.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_ConfigFactura_Config.Location = New System.Drawing.Point(238, 3)
        Me.cmd_ConfigFactura_Config.Name = "cmd_ConfigFactura_Config"
        Me.cmd_ConfigFactura_Config.Size = New System.Drawing.Size(98, 66)
        Me.cmd_ConfigFactura_Config.TabIndex = 33
        Me.cmd_ConfigFactura_Config.Text = "Configurar Factura"
        Me.cmd_ConfigFactura_Config.UseVisualStyleBackColor = False
        '
        'cmd_ConfigCF_Config
        '
        Me.cmd_ConfigCF_Config.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.cmd_ConfigCF_Config.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmd_ConfigCF_Config.FlatAppearance.BorderSize = 0
        Me.cmd_ConfigCF_Config.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmd_ConfigCF_Config.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmd_ConfigCF_Config.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_ConfigCF_Config.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_ConfigCF_Config.Location = New System.Drawing.Point(342, 3)
        Me.cmd_ConfigCF_Config.Name = "cmd_ConfigCF_Config"
        Me.cmd_ConfigCF_Config.Size = New System.Drawing.Size(125, 66)
        Me.cmd_ConfigCF_Config.TabIndex = 34
        Me.cmd_ConfigCF_Config.Text = "Configurar Credito Fiscas"
        Me.cmd_ConfigCF_Config.UseVisualStyleBackColor = False
        '
        'cmd_ConfigCF_ZoomMAS
        '
        Me.cmd_ConfigCF_ZoomMAS.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.cmd_ConfigCF_ZoomMAS.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmd_ConfigCF_ZoomMAS.FlatAppearance.BorderSize = 0
        Me.cmd_ConfigCF_ZoomMAS.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmd_ConfigCF_ZoomMAS.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmd_ConfigCF_ZoomMAS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_ConfigCF_ZoomMAS.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_ConfigCF_ZoomMAS.Location = New System.Drawing.Point(473, 3)
        Me.cmd_ConfigCF_ZoomMAS.Name = "cmd_ConfigCF_ZoomMAS"
        Me.cmd_ConfigCF_ZoomMAS.Size = New System.Drawing.Size(93, 66)
        Me.cmd_ConfigCF_ZoomMAS.TabIndex = 35
        Me.cmd_ConfigCF_ZoomMAS.Text = "+"
        Me.cmd_ConfigCF_ZoomMAS.UseVisualStyleBackColor = False
        '
        'cmd_ConfigCF_ZoomMenos
        '
        Me.cmd_ConfigCF_ZoomMenos.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.cmd_ConfigCF_ZoomMenos.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmd_ConfigCF_ZoomMenos.FlatAppearance.BorderSize = 0
        Me.cmd_ConfigCF_ZoomMenos.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmd_ConfigCF_ZoomMenos.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmd_ConfigCF_ZoomMenos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_ConfigCF_ZoomMenos.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_ConfigCF_ZoomMenos.Location = New System.Drawing.Point(572, 3)
        Me.cmd_ConfigCF_ZoomMenos.Name = "cmd_ConfigCF_ZoomMenos"
        Me.cmd_ConfigCF_ZoomMenos.Size = New System.Drawing.Size(91, 66)
        Me.cmd_ConfigCF_ZoomMenos.TabIndex = 36
        Me.cmd_ConfigCF_ZoomMenos.Text = "-"
        Me.cmd_ConfigCF_ZoomMenos.UseVisualStyleBackColor = False
        '
        'Panel_ConfiguracionFacturaTrabajo
        '
        Me.Panel_ConfiguracionFacturaTrabajo.Controls.Add(Me.PPC_ConfigFactura)
        Me.Panel_ConfiguracionFacturaTrabajo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_ConfiguracionFacturaTrabajo.Location = New System.Drawing.Point(3, 78)
        Me.Panel_ConfiguracionFacturaTrabajo.Name = "Panel_ConfiguracionFacturaTrabajo"
        Me.Panel_ConfiguracionFacturaTrabajo.Size = New System.Drawing.Size(1075, 453)
        Me.Panel_ConfiguracionFacturaTrabajo.TabIndex = 2
        '
        'PPC_ConfigFactura
        '
        Me.PPC_ConfigFactura.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PPC_ConfigFactura.Location = New System.Drawing.Point(0, 0)
        Me.PPC_ConfigFactura.Name = "PPC_ConfigFactura"
        Me.PPC_ConfigFactura.Size = New System.Drawing.Size(1075, 453)
        Me.PPC_ConfigFactura.TabIndex = 3
        '
        'GraficosFacturacion
        '
        Me.GraficosFacturacion.Location = New System.Drawing.Point(4, 35)
        Me.GraficosFacturacion.Name = "GraficosFacturacion"
        Me.GraficosFacturacion.Size = New System.Drawing.Size(1087, 540)
        Me.GraficosFacturacion.TabIndex = 8
        Me.GraficosFacturacion.Text = "Gráficos Facturación"
        Me.GraficosFacturacion.UseVisualStyleBackColor = True
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
        Me.TLP_Clientes.Controls.Add(Me.FLPCuentasActivas, 0, 0)
        Me.TLP_Clientes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TLP_Clientes.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TLP_Clientes.Location = New System.Drawing.Point(0, 0)
        Me.TLP_Clientes.Name = "TLP_Clientes"
        Me.TLP_Clientes.RowCount = 2
        Me.TLP_Clientes.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 81.0!))
        Me.TLP_Clientes.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLP_Clientes.Size = New System.Drawing.Size(1087, 540)
        Me.TLP_Clientes.TabIndex = 3
        '
        'DGVClientes
        '
        Me.DGVClientes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGVClientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id_Customer, Me.Is_Supplier, Me.DataGridViewTextBoxColumn22, Me.DataGridViewTextBoxColumn23, Me.DataGridViewTextBoxColumn24, Me.DataGridViewTextBoxColumn25, Me.Email_Contact})
        Me.DGVClientes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGVClientes.EnableHeadersVisualStyles = False
        Me.DGVClientes.Location = New System.Drawing.Point(3, 84)
        Me.DGVClientes.Name = "DGVClientes"
        Me.DGVClientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DGVClientes.RowHeadersVisible = False
        Me.DGVClientes.ShowCellErrors = False
        Me.DGVClientes.ShowCellToolTips = False
        Me.DGVClientes.ShowEditingIcon = False
        Me.DGVClientes.ShowRowErrors = False
        Me.DGVClientes.Size = New System.Drawing.Size(1081, 453)
        Me.DGVClientes.TabIndex = 0
        '
        'Id_Customer
        '
        Me.Id_Customer.DataPropertyName = "Id_Customer"
        Me.Id_Customer.HeaderText = "Correlativo"
        Me.Id_Customer.Name = "Id_Customer"
        Me.Id_Customer.Width = 107
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
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "DescriptionCustomer"
        Me.DataGridViewTextBoxColumn22.HeaderText = "Tipo Cliente"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        Me.DataGridViewTextBoxColumn22.Width = 114
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "Name_Company"
        Me.DataGridViewTextBoxColumn23.HeaderText = "Cliente / Razón Social"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        Me.DataGridViewTextBoxColumn23.Width = 179
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.DataPropertyName = "Commercial_Name"
        Me.DataGridViewTextBoxColumn24.HeaderText = "Nombre Comercial"
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        Me.DataGridViewTextBoxColumn24.Width = 160
        '
        'DataGridViewTextBoxColumn25
        '
        Me.DataGridViewTextBoxColumn25.DataPropertyName = "OfficePhone"
        Me.DataGridViewTextBoxColumn25.HeaderText = "Tel. Oficina"
        Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
        Me.DataGridViewTextBoxColumn25.Width = 108
        '
        'Email_Contact
        '
        Me.Email_Contact.DataPropertyName = "Email_Contact"
        Me.Email_Contact.HeaderText = "Correo Contacto"
        Me.Email_Contact.Name = "Email_Contact"
        Me.Email_Contact.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Email_Contact.Width = 143
        '
        'FLPCuentasActivas
        '
        Me.FLPCuentasActivas.AutoScroll = True
        Me.FLPCuentasActivas.Controls.Add(Me.cmdCrearCliente)
        Me.FLPCuentasActivas.Controls.Add(Me.cmdModificarCliente)
        Me.FLPCuentasActivas.Controls.Add(Me.cmdLineaCredito)
        Me.FLPCuentasActivas.Controls.Add(Me.cmdCuentasActivas_CrearManual)
        Me.FLPCuentasActivas.Controls.Add(Me.cmdCuentaCxC_AgregarCobro)
        Me.FLPCuentasActivas.Controls.Add(Me.cmdReporteCatalogoCliente)
        Me.FLPCuentasActivas.Controls.Add(Me.cmdCatalogoClienteFinanciero)
        Me.FLPCuentasActivas.Controls.Add(Me.cmdFichaCliente)
        Me.FLPCuentasActivas.Controls.Add(Me.cmdCuentasActivas_EstadoCuentaCliente)
        Me.FLPCuentasActivas.Controls.Add(Me.cmdCuentaActiva_PagoCuotaFecha)
        Me.FLPCuentasActivas.Controls.Add(Me.cmdCuentaActiva_EstadoPagos)
        Me.FLPCuentasActivas.Controls.Add(Me.cmd_CuentasActivas_AddPayment)
        Me.FLPCuentasActivas.Controls.Add(Me.cmdCuentasActivas_DeudasClientes)
        Me.FLPCuentasActivas.Controls.Add(Me.cmdCuentasActivas_CotizacionPorCliente)
        Me.FLPCuentasActivas.Controls.Add(Me.cmdPagos)
        Me.FLPCuentasActivas.Controls.Add(Me.btnLogEntriesExitsActualMonth)
        Me.FLPCuentasActivas.Controls.Add(Me.btnLogEntriesExitsActualYear)
        Me.FLPCuentasActivas.Controls.Add(Me.btnLogEntriesExitsActualFilter)
        Me.FLPCuentasActivas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FLPCuentasActivas.Location = New System.Drawing.Point(3, 3)
        Me.FLPCuentasActivas.Name = "FLPCuentasActivas"
        Me.FLPCuentasActivas.Size = New System.Drawing.Size(1081, 75)
        Me.FLPCuentasActivas.TabIndex = 1
        '
        'cmdCrearCliente
        '
        Me.cmdCrearCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.cmdCrearCliente.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdCrearCliente.FlatAppearance.BorderSize = 0
        Me.cmdCrearCliente.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdCrearCliente.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdCrearCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCrearCliente.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCrearCliente.Location = New System.Drawing.Point(3, 3)
        Me.cmdCrearCliente.Name = "cmdCrearCliente"
        Me.cmdCrearCliente.Size = New System.Drawing.Size(112, 66)
        Me.cmdCrearCliente.TabIndex = 35
        Me.cmdCrearCliente.Text = "  Crear    Cliente"
        Me.cmdCrearCliente.UseVisualStyleBackColor = False
        '
        'cmdModificarCliente
        '
        Me.cmdModificarCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.cmdModificarCliente.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdModificarCliente.FlatAppearance.BorderSize = 0
        Me.cmdModificarCliente.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdModificarCliente.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdModificarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdModificarCliente.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdModificarCliente.Location = New System.Drawing.Point(121, 3)
        Me.cmdModificarCliente.Name = "cmdModificarCliente"
        Me.cmdModificarCliente.Size = New System.Drawing.Size(112, 66)
        Me.cmdModificarCliente.TabIndex = 36
        Me.cmdModificarCliente.Text = "Modificar Cliente"
        Me.cmdModificarCliente.UseVisualStyleBackColor = False
        '
        'cmdLineaCredito
        '
        Me.cmdLineaCredito.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.cmdLineaCredito.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdLineaCredito.FlatAppearance.BorderSize = 0
        Me.cmdLineaCredito.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdLineaCredito.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdLineaCredito.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdLineaCredito.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLineaCredito.Location = New System.Drawing.Point(239, 3)
        Me.cmdLineaCredito.Name = "cmdLineaCredito"
        Me.cmdLineaCredito.Size = New System.Drawing.Size(110, 66)
        Me.cmdLineaCredito.TabIndex = 31
        Me.cmdLineaCredito.Text = "Línea Créditos"
        Me.cmdLineaCredito.UseVisualStyleBackColor = False
        '
        'cmdCuentasActivas_CrearManual
        '
        Me.cmdCuentasActivas_CrearManual.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.cmdCuentasActivas_CrearManual.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdCuentasActivas_CrearManual.FlatAppearance.BorderSize = 0
        Me.cmdCuentasActivas_CrearManual.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdCuentasActivas_CrearManual.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdCuentasActivas_CrearManual.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCuentasActivas_CrearManual.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCuentasActivas_CrearManual.Location = New System.Drawing.Point(355, 3)
        Me.cmdCuentasActivas_CrearManual.Name = "cmdCuentasActivas_CrearManual"
        Me.cmdCuentasActivas_CrearManual.Size = New System.Drawing.Size(112, 66)
        Me.cmdCuentasActivas_CrearManual.TabIndex = 44
        Me.cmdCuentasActivas_CrearManual.Text = "Cuenta Manual"
        Me.cmdCuentasActivas_CrearManual.UseVisualStyleBackColor = False
        '
        'cmdCuentaCxC_AgregarCobro
        '
        Me.cmdCuentaCxC_AgregarCobro.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.cmdCuentaCxC_AgregarCobro.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdCuentaCxC_AgregarCobro.FlatAppearance.BorderSize = 0
        Me.cmdCuentaCxC_AgregarCobro.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdCuentaCxC_AgregarCobro.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdCuentaCxC_AgregarCobro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCuentaCxC_AgregarCobro.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCuentaCxC_AgregarCobro.Location = New System.Drawing.Point(473, 3)
        Me.cmdCuentaCxC_AgregarCobro.Name = "cmdCuentaCxC_AgregarCobro"
        Me.cmdCuentaCxC_AgregarCobro.Size = New System.Drawing.Size(131, 66)
        Me.cmdCuentaCxC_AgregarCobro.TabIndex = 42
        Me.cmdCuentaCxC_AgregarCobro.Text = "Pago Cuota o Total"
        Me.cmdCuentaCxC_AgregarCobro.UseVisualStyleBackColor = False
        '
        'cmdReporteCatalogoCliente
        '
        Me.cmdReporteCatalogoCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.cmdReporteCatalogoCliente.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdReporteCatalogoCliente.FlatAppearance.BorderSize = 0
        Me.cmdReporteCatalogoCliente.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdReporteCatalogoCliente.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdReporteCatalogoCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdReporteCatalogoCliente.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdReporteCatalogoCliente.Location = New System.Drawing.Point(610, 3)
        Me.cmdReporteCatalogoCliente.Name = "cmdReporteCatalogoCliente"
        Me.cmdReporteCatalogoCliente.Size = New System.Drawing.Size(110, 66)
        Me.cmdReporteCatalogoCliente.TabIndex = 37
        Me.cmdReporteCatalogoCliente.Text = "Catálogo de Clientes"
        Me.cmdReporteCatalogoCliente.UseVisualStyleBackColor = False
        '
        'cmdCatalogoClienteFinanciero
        '
        Me.cmdCatalogoClienteFinanciero.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.cmdCatalogoClienteFinanciero.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdCatalogoClienteFinanciero.FlatAppearance.BorderSize = 0
        Me.cmdCatalogoClienteFinanciero.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdCatalogoClienteFinanciero.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdCatalogoClienteFinanciero.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCatalogoClienteFinanciero.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCatalogoClienteFinanciero.Location = New System.Drawing.Point(726, 3)
        Me.cmdCatalogoClienteFinanciero.Name = "cmdCatalogoClienteFinanciero"
        Me.cmdCatalogoClienteFinanciero.Size = New System.Drawing.Size(152, 66)
        Me.cmdCatalogoClienteFinanciero.TabIndex = 39
        Me.cmdCatalogoClienteFinanciero.Text = "Catálogo de Clientes Financiero"
        Me.cmdCatalogoClienteFinanciero.UseVisualStyleBackColor = False
        '
        'cmdFichaCliente
        '
        Me.cmdFichaCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.cmdFichaCliente.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdFichaCliente.FlatAppearance.BorderSize = 0
        Me.cmdFichaCliente.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdFichaCliente.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdFichaCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdFichaCliente.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdFichaCliente.Location = New System.Drawing.Point(884, 3)
        Me.cmdFichaCliente.Name = "cmdFichaCliente"
        Me.cmdFichaCliente.Size = New System.Drawing.Size(112, 66)
        Me.cmdFichaCliente.TabIndex = 40
        Me.cmdFichaCliente.Text = "Ficha Cliente"
        Me.cmdFichaCliente.UseVisualStyleBackColor = False
        '
        'cmdCuentasActivas_EstadoCuentaCliente
        '
        Me.cmdCuentasActivas_EstadoCuentaCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.cmdCuentasActivas_EstadoCuentaCliente.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdCuentasActivas_EstadoCuentaCliente.FlatAppearance.BorderSize = 0
        Me.cmdCuentasActivas_EstadoCuentaCliente.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdCuentasActivas_EstadoCuentaCliente.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdCuentasActivas_EstadoCuentaCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCuentasActivas_EstadoCuentaCliente.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCuentasActivas_EstadoCuentaCliente.Location = New System.Drawing.Point(3, 75)
        Me.cmdCuentasActivas_EstadoCuentaCliente.Name = "cmdCuentasActivas_EstadoCuentaCliente"
        Me.cmdCuentasActivas_EstadoCuentaCliente.Size = New System.Drawing.Size(132, 66)
        Me.cmdCuentasActivas_EstadoCuentaCliente.TabIndex = 45
        Me.cmdCuentasActivas_EstadoCuentaCliente.Text = "Estado de Cuenta Cliente"
        Me.cmdCuentasActivas_EstadoCuentaCliente.UseVisualStyleBackColor = False
        '
        'cmdCuentaActiva_PagoCuotaFecha
        '
        Me.cmdCuentaActiva_PagoCuotaFecha.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.cmdCuentaActiva_PagoCuotaFecha.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdCuentaActiva_PagoCuotaFecha.FlatAppearance.BorderSize = 0
        Me.cmdCuentaActiva_PagoCuotaFecha.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdCuentaActiva_PagoCuotaFecha.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdCuentaActiva_PagoCuotaFecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCuentaActiva_PagoCuotaFecha.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCuentaActiva_PagoCuotaFecha.Location = New System.Drawing.Point(141, 75)
        Me.cmdCuentaActiva_PagoCuotaFecha.Name = "cmdCuentaActiva_PagoCuotaFecha"
        Me.cmdCuentaActiva_PagoCuotaFecha.Size = New System.Drawing.Size(132, 66)
        Me.cmdCuentaActiva_PagoCuotaFecha.TabIndex = 45
        Me.cmdCuentaActiva_PagoCuotaFecha.Text = "Reporte Hoja de Cobro"
        Me.cmdCuentaActiva_PagoCuotaFecha.UseVisualStyleBackColor = False
        '
        'cmdCuentaActiva_EstadoPagos
        '
        Me.cmdCuentaActiva_EstadoPagos.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.cmdCuentaActiva_EstadoPagos.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdCuentaActiva_EstadoPagos.FlatAppearance.BorderSize = 0
        Me.cmdCuentaActiva_EstadoPagos.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdCuentaActiva_EstadoPagos.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdCuentaActiva_EstadoPagos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCuentaActiva_EstadoPagos.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCuentaActiva_EstadoPagos.Location = New System.Drawing.Point(279, 75)
        Me.cmdCuentaActiva_EstadoPagos.Name = "cmdCuentaActiva_EstadoPagos"
        Me.cmdCuentaActiva_EstadoPagos.Size = New System.Drawing.Size(132, 66)
        Me.cmdCuentaActiva_EstadoPagos.TabIndex = 45
        Me.cmdCuentaActiva_EstadoPagos.Text = "Estado de Pagos"
        Me.cmdCuentaActiva_EstadoPagos.UseVisualStyleBackColor = False
        '
        'cmd_CuentasActivas_AddPayment
        '
        Me.cmd_CuentasActivas_AddPayment.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.cmd_CuentasActivas_AddPayment.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmd_CuentasActivas_AddPayment.FlatAppearance.BorderSize = 0
        Me.cmd_CuentasActivas_AddPayment.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmd_CuentasActivas_AddPayment.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmd_CuentasActivas_AddPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_CuentasActivas_AddPayment.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_CuentasActivas_AddPayment.Location = New System.Drawing.Point(417, 75)
        Me.cmd_CuentasActivas_AddPayment.Name = "cmd_CuentasActivas_AddPayment"
        Me.cmd_CuentasActivas_AddPayment.Size = New System.Drawing.Size(132, 66)
        Me.cmd_CuentasActivas_AddPayment.TabIndex = 47
        Me.cmd_CuentasActivas_AddPayment.Text = "Agregar Pagos Fecha"
        Me.cmd_CuentasActivas_AddPayment.UseVisualStyleBackColor = False
        '
        'cmdCuentasActivas_DeudasClientes
        '
        Me.cmdCuentasActivas_DeudasClientes.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.cmdCuentasActivas_DeudasClientes.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdCuentasActivas_DeudasClientes.FlatAppearance.BorderSize = 0
        Me.cmdCuentasActivas_DeudasClientes.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdCuentasActivas_DeudasClientes.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdCuentasActivas_DeudasClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCuentasActivas_DeudasClientes.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCuentasActivas_DeudasClientes.Location = New System.Drawing.Point(555, 75)
        Me.cmdCuentasActivas_DeudasClientes.Name = "cmdCuentasActivas_DeudasClientes"
        Me.cmdCuentasActivas_DeudasClientes.Size = New System.Drawing.Size(132, 66)
        Me.cmdCuentasActivas_DeudasClientes.TabIndex = 49
        Me.cmdCuentasActivas_DeudasClientes.Text = "Deudas por Cliente"
        Me.cmdCuentasActivas_DeudasClientes.UseVisualStyleBackColor = False
        '
        'cmdCuentasActivas_CotizacionPorCliente
        '
        Me.cmdCuentasActivas_CotizacionPorCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.cmdCuentasActivas_CotizacionPorCliente.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdCuentasActivas_CotizacionPorCliente.FlatAppearance.BorderSize = 0
        Me.cmdCuentasActivas_CotizacionPorCliente.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdCuentasActivas_CotizacionPorCliente.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdCuentasActivas_CotizacionPorCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCuentasActivas_CotizacionPorCliente.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCuentasActivas_CotizacionPorCliente.Location = New System.Drawing.Point(693, 75)
        Me.cmdCuentasActivas_CotizacionPorCliente.Name = "cmdCuentasActivas_CotizacionPorCliente"
        Me.cmdCuentasActivas_CotizacionPorCliente.Size = New System.Drawing.Size(132, 66)
        Me.cmdCuentasActivas_CotizacionPorCliente.TabIndex = 50
        Me.cmdCuentasActivas_CotizacionPorCliente.Text = "Cotizaciones por Cliente"
        Me.cmdCuentasActivas_CotizacionPorCliente.UseVisualStyleBackColor = False
        '
        'cmdPagos
        '
        Me.cmdPagos.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.cmdPagos.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdPagos.FlatAppearance.BorderSize = 0
        Me.cmdPagos.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdPagos.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdPagos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdPagos.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPagos.Location = New System.Drawing.Point(831, 75)
        Me.cmdPagos.Name = "cmdPagos"
        Me.cmdPagos.Size = New System.Drawing.Size(112, 65)
        Me.cmdPagos.TabIndex = 55
        Me.cmdPagos.Text = "Reimpresión Comprobantes"
        Me.cmdPagos.UseVisualStyleBackColor = False
        '
        'btnLogEntriesExitsActualMonth
        '
        Me.btnLogEntriesExitsActualMonth.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.btnLogEntriesExitsActualMonth.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.btnLogEntriesExitsActualMonth.FlatAppearance.BorderSize = 0
        Me.btnLogEntriesExitsActualMonth.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnLogEntriesExitsActualMonth.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnLogEntriesExitsActualMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogEntriesExitsActualMonth.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogEntriesExitsActualMonth.Location = New System.Drawing.Point(3, 147)
        Me.btnLogEntriesExitsActualMonth.Name = "btnLogEntriesExitsActualMonth"
        Me.btnLogEntriesExitsActualMonth.Size = New System.Drawing.Size(173, 66)
        Me.btnLogEntriesExitsActualMonth.TabIndex = 56
        Me.btnLogEntriesExitsActualMonth.Text = "Reporte Entradas y Salidas Mes Actual"
        Me.btnLogEntriesExitsActualMonth.UseVisualStyleBackColor = False
        '
        'btnLogEntriesExitsActualYear
        '
        Me.btnLogEntriesExitsActualYear.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.btnLogEntriesExitsActualYear.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.btnLogEntriesExitsActualYear.FlatAppearance.BorderSize = 0
        Me.btnLogEntriesExitsActualYear.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnLogEntriesExitsActualYear.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnLogEntriesExitsActualYear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogEntriesExitsActualYear.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogEntriesExitsActualYear.Location = New System.Drawing.Point(182, 147)
        Me.btnLogEntriesExitsActualYear.Name = "btnLogEntriesExitsActualYear"
        Me.btnLogEntriesExitsActualYear.Size = New System.Drawing.Size(167, 66)
        Me.btnLogEntriesExitsActualYear.TabIndex = 57
        Me.btnLogEntriesExitsActualYear.Text = "Reporte Entradas y Salidas Año Actual"
        Me.btnLogEntriesExitsActualYear.UseVisualStyleBackColor = False
        '
        'btnLogEntriesExitsActualFilter
        '
        Me.btnLogEntriesExitsActualFilter.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.btnLogEntriesExitsActualFilter.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.btnLogEntriesExitsActualFilter.FlatAppearance.BorderSize = 0
        Me.btnLogEntriesExitsActualFilter.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnLogEntriesExitsActualFilter.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnLogEntriesExitsActualFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogEntriesExitsActualFilter.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogEntriesExitsActualFilter.Location = New System.Drawing.Point(355, 147)
        Me.btnLogEntriesExitsActualFilter.Name = "btnLogEntriesExitsActualFilter"
        Me.btnLogEntriesExitsActualFilter.Size = New System.Drawing.Size(160, 66)
        Me.btnLogEntriesExitsActualFilter.TabIndex = 58
        Me.btnLogEntriesExitsActualFilter.Text = "Reporte Entradas y Salidas Filtro"
        Me.btnLogEntriesExitsActualFilter.UseVisualStyleBackColor = False
        '
        'IndicadorVentas
        '
        Me.IndicadorVentas.BackColor = System.Drawing.Color.White
        Me.IndicadorVentas.Controls.Add(Me.TableLayoutPanel2)
        Me.IndicadorVentas.Location = New System.Drawing.Point(4, 35)
        Me.IndicadorVentas.Name = "IndicadorVentas"
        Me.IndicadorVentas.Size = New System.Drawing.Size(1087, 540)
        Me.IndicadorVentas.TabIndex = 11
        Me.IndicadorVentas.Text = "Indicador Ventas"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Panel2, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Panel1, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel4, 0, 2)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 3
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.97183!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.02817!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 287.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1087, 540)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.lblHoras)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1081, 24)
        Me.Panel2.TabIndex = 1
        '
        'lblHoras
        '
        Me.lblHoras.AutoSize = True
        Me.lblHoras.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHoras.Location = New System.Drawing.Point(415, 4)
        Me.lblHoras.Name = "lblHoras"
        Me.lblHoras.Size = New System.Drawing.Size(249, 23)
        Me.lblHoras.TabIndex = 0
        Me.lblHoras.Text = "Ventas por hora del dia actual"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.chartHoras)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 33)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1081, 216)
        Me.Panel1.TabIndex = 0
        '
        'chartHoras
        '
        ChartArea5.Name = "ChartArea1"
        Me.chartHoras.ChartAreas.Add(ChartArea5)
        Me.chartHoras.Dock = System.Windows.Forms.DockStyle.Fill
        Legend5.Name = "Legend1"
        Me.chartHoras.Legends.Add(Legend5)
        Me.chartHoras.Location = New System.Drawing.Point(0, 0)
        Me.chartHoras.Name = "chartHoras"
        Series7.ChartArea = "ChartArea1"
        Series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea
        Series7.Legend = "Legend1"
        Series7.MarkerColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Series7.Name = "Series1"
        Me.chartHoras.Series.Add(Series7)
        Me.chartHoras.Size = New System.Drawing.Size(1081, 216)
        Me.chartHoras.TabIndex = 0
        Me.chartHoras.Text = "Chart1"
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 2
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.Panel6, 1, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.Panel5, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.Panel3, 0, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.Panel4, 1, 1)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 255)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 2
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.47518!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.52483!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(1081, 282)
        Me.TableLayoutPanel4.TabIndex = 2
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.lblMes)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(543, 3)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(535, 32)
        Me.Panel6.TabIndex = 3
        '
        'lblMes
        '
        Me.lblMes.AutoSize = True
        Me.lblMes.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMes.Location = New System.Drawing.Point(132, 4)
        Me.lblMes.Name = "lblMes"
        Me.lblMes.Size = New System.Drawing.Size(187, 23)
        Me.lblMes.TabIndex = 1
        Me.lblMes.Text = "Ventas diarias del mes"
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.lblAnio)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(3, 3)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(534, 32)
        Me.Panel5.TabIndex = 2
        '
        'lblAnio
        '
        Me.lblAnio.AutoSize = True
        Me.lblAnio.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnio.Location = New System.Drawing.Point(186, 4)
        Me.lblAnio.Name = "lblAnio"
        Me.lblAnio.Size = New System.Drawing.Size(258, 23)
        Me.lblAnio.TabIndex = 1
        Me.lblAnio.Text = "Ventas mensuales del año 2017"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.ChartAnio)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(3, 41)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(534, 238)
        Me.Panel3.TabIndex = 0
        '
        'ChartAnio
        '
        ChartArea6.Name = "ChartArea1"
        Me.ChartAnio.ChartAreas.Add(ChartArea6)
        Me.ChartAnio.Dock = System.Windows.Forms.DockStyle.Fill
        Legend6.Name = "Legend1"
        Me.ChartAnio.Legends.Add(Legend6)
        Me.ChartAnio.Location = New System.Drawing.Point(0, 0)
        Me.ChartAnio.Name = "ChartAnio"
        Series8.ChartArea = "ChartArea1"
        Series8.Legend = "Legend1"
        Series8.Name = "Series1"
        Me.ChartAnio.Series.Add(Series8)
        Me.ChartAnio.Size = New System.Drawing.Size(534, 238)
        Me.ChartAnio.TabIndex = 1
        Me.ChartAnio.Text = "Chart2"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.ChartMes)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(543, 41)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(535, 238)
        Me.Panel4.TabIndex = 1
        '
        'ChartMes
        '
        ChartArea7.Name = "ChartArea1"
        Me.ChartMes.ChartAreas.Add(ChartArea7)
        Me.ChartMes.Dock = System.Windows.Forms.DockStyle.Fill
        Legend7.Name = "Legend1"
        Me.ChartMes.Legends.Add(Legend7)
        Me.ChartMes.Location = New System.Drawing.Point(0, 0)
        Me.ChartMes.Name = "ChartMes"
        Series9.ChartArea = "ChartArea1"
        Series9.Legend = "Legend1"
        Series9.Name = "Series1"
        Me.ChartMes.Series.Add(Series9)
        Me.ChartMes.Size = New System.Drawing.Size(535, 238)
        Me.ChartMes.TabIndex = 1
        Me.ChartMes.Text = "Chart3"
        '
        'EntradasySalidas
        '
        Me.EntradasySalidas.BackColor = System.Drawing.Color.White
        Me.EntradasySalidas.Controls.Add(Me.TableLayoutPanel5)
        Me.EntradasySalidas.Location = New System.Drawing.Point(4, 35)
        Me.EntradasySalidas.Name = "EntradasySalidas"
        Me.EntradasySalidas.Size = New System.Drawing.Size(1087, 540)
        Me.EntradasySalidas.TabIndex = 12
        Me.EntradasySalidas.Text = "Análisis de Ventas"
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 1
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.Panel8, 0, 1)
        Me.TableLayoutPanel5.Controls.Add(Me.Panel7, 0, 0)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 2
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.677903!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.3221!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(1087, 540)
        Me.TableLayoutPanel5.TabIndex = 1
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.ChartAnalisis)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel8.Location = New System.Drawing.Point(3, 44)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(1081, 493)
        Me.Panel8.TabIndex = 1
        '
        'ChartAnalisis
        '
        ChartArea8.Name = "ChartArea1"
        Me.ChartAnalisis.ChartAreas.Add(ChartArea8)
        Me.ChartAnalisis.Dock = System.Windows.Forms.DockStyle.Fill
        Legend8.Name = "Legend1"
        Me.ChartAnalisis.Legends.Add(Legend8)
        Me.ChartAnalisis.Location = New System.Drawing.Point(0, 0)
        Me.ChartAnalisis.Name = "ChartAnalisis"
        Series10.ChartArea = "ChartArea1"
        Series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series10.Legend = "Legend1"
        Series10.Name = "Series3"
        Series11.ChartArea = "ChartArea1"
        Series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series11.Legend = "Legend1"
        Series11.Name = "Series2"
        Series12.ChartArea = "ChartArea1"
        Series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series12.Legend = "Legend1"
        Series12.Name = "Series1"
        Me.ChartAnalisis.Series.Add(Series10)
        Me.ChartAnalisis.Series.Add(Series11)
        Me.ChartAnalisis.Series.Add(Series12)
        Me.ChartAnalisis.Size = New System.Drawing.Size(1081, 493)
        Me.ChartAnalisis.TabIndex = 0
        Me.ChartAnalisis.Text = "ChartAnalisis"
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.lblEntradasSalidas)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel7.Location = New System.Drawing.Point(3, 3)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(1081, 35)
        Me.Panel7.TabIndex = 0
        '
        'lblEntradasSalidas
        '
        Me.lblEntradasSalidas.AutoSize = True
        Me.lblEntradasSalidas.Location = New System.Drawing.Point(513, 6)
        Me.lblEntradasSalidas.Name = "lblEntradasSalidas"
        Me.lblEntradasSalidas.Size = New System.Drawing.Size(241, 25)
        Me.lblEntradasSalidas.TabIndex = 0
        Me.lblEntradasSalidas.Text = "Analisis de entradas y salidas"
        '
        'TypeCreditLine
        '
        Me.TypeCreditLine.Controls.Add(Me.TableLayoutPanel6)
        Me.TypeCreditLine.Location = New System.Drawing.Point(4, 35)
        Me.TypeCreditLine.Name = "TypeCreditLine"
        Me.TypeCreditLine.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.TypeCreditLine.Size = New System.Drawing.Size(1087, 540)
        Me.TypeCreditLine.TabIndex = 13
        Me.TypeCreditLine.Text = "Tipos de Líneas de Crédito"
        Me.TypeCreditLine.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.ColumnCount = 1
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel6.Controls.Add(Me.dgvTypeCreditLine, 0, 1)
        Me.TableLayoutPanel6.Controls.Add(Me.FlowLayoutPanel12, 0, 0)
        Me.TableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel6.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 2
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 81.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(1081, 534)
        Me.TableLayoutPanel6.TabIndex = 10
        '
        'dgvTypeCreditLine
        '
        Me.dgvTypeCreditLine.AllowUserToAddRows = False
        Me.dgvTypeCreditLine.AllowUserToDeleteRows = False
        Me.dgvTypeCreditLine.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvTypeCreditLine.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id_TypeCreditLine, Me.Type_CreditLine, Me.DescriptionCreditLine, Me.DataGridViewTextBoxColumn51, Me.DataGridViewTextBoxColumn52, Me.DataGridViewTextBoxColumn53, Me.DataGridViewTextBoxColumn54})
        Me.dgvTypeCreditLine.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvTypeCreditLine.EnableHeadersVisualStyles = False
        Me.dgvTypeCreditLine.Location = New System.Drawing.Point(3, 84)
        Me.dgvTypeCreditLine.Name = "dgvTypeCreditLine"
        Me.dgvTypeCreditLine.ReadOnly = True
        Me.dgvTypeCreditLine.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvTypeCreditLine.RowHeadersVisible = False
        Me.dgvTypeCreditLine.ShowCellErrors = False
        Me.dgvTypeCreditLine.ShowCellToolTips = False
        Me.dgvTypeCreditLine.ShowEditingIcon = False
        Me.dgvTypeCreditLine.ShowRowErrors = False
        Me.dgvTypeCreditLine.Size = New System.Drawing.Size(1075, 447)
        Me.dgvTypeCreditLine.TabIndex = 0
        '
        'Id_TypeCreditLine
        '
        Me.Id_TypeCreditLine.DataPropertyName = "Id_TypeCreditLine"
        Me.Id_TypeCreditLine.HeaderText = "Correlativo"
        Me.Id_TypeCreditLine.Name = "Id_TypeCreditLine"
        Me.Id_TypeCreditLine.ReadOnly = True
        Me.Id_TypeCreditLine.Width = 80
        '
        'Type_CreditLine
        '
        Me.Type_CreditLine.DataPropertyName = "TypeCreditLine"
        Me.Type_CreditLine.HeaderText = "Línea de Crédito"
        Me.Type_CreditLine.Name = "Type_CreditLine"
        Me.Type_CreditLine.ReadOnly = True
        '
        'DescriptionCreditLine
        '
        Me.DescriptionCreditLine.DataPropertyName = "DescriptionCreditLine"
        Me.DescriptionCreditLine.HeaderText = "Descripción"
        Me.DescriptionCreditLine.Name = "DescriptionCreditLine"
        Me.DescriptionCreditLine.ReadOnly = True
        '
        'DataGridViewTextBoxColumn51
        '
        Me.DataGridViewTextBoxColumn51.DataPropertyName = "CreateUser"
        Me.DataGridViewTextBoxColumn51.HeaderText = "Create User"
        Me.DataGridViewTextBoxColumn51.Name = "DataGridViewTextBoxColumn51"
        Me.DataGridViewTextBoxColumn51.ReadOnly = True
        '
        'DataGridViewTextBoxColumn52
        '
        Me.DataGridViewTextBoxColumn52.DataPropertyName = "CreateDate"
        Me.DataGridViewTextBoxColumn52.HeaderText = "Create Date"
        Me.DataGridViewTextBoxColumn52.Name = "DataGridViewTextBoxColumn52"
        Me.DataGridViewTextBoxColumn52.ReadOnly = True
        '
        'DataGridViewTextBoxColumn53
        '
        Me.DataGridViewTextBoxColumn53.DataPropertyName = "ModifyUser"
        Me.DataGridViewTextBoxColumn53.HeaderText = "Modify User"
        Me.DataGridViewTextBoxColumn53.Name = "DataGridViewTextBoxColumn53"
        Me.DataGridViewTextBoxColumn53.ReadOnly = True
        '
        'DataGridViewTextBoxColumn54
        '
        Me.DataGridViewTextBoxColumn54.DataPropertyName = "ModifyDate"
        Me.DataGridViewTextBoxColumn54.HeaderText = "Fecha de Modificación"
        Me.DataGridViewTextBoxColumn54.Name = "DataGridViewTextBoxColumn54"
        Me.DataGridViewTextBoxColumn54.ReadOnly = True
        '
        'FlowLayoutPanel12
        '
        Me.FlowLayoutPanel12.Controls.Add(Me.cmdCrearTypeCreditLine)
        Me.FlowLayoutPanel12.Controls.Add(Me.cmdActualizarTypeCreditLine)
        Me.FlowLayoutPanel12.Controls.Add(Me.cmdEliminarTypeCreditLine)
        Me.FlowLayoutPanel12.Controls.Add(Me.cmdListadoTypeCreditLine)
        Me.FlowLayoutPanel12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel12.Location = New System.Drawing.Point(3, 3)
        Me.FlowLayoutPanel12.Name = "FlowLayoutPanel12"
        Me.FlowLayoutPanel12.Size = New System.Drawing.Size(1075, 75)
        Me.FlowLayoutPanel12.TabIndex = 1
        '
        'cmdCrearTypeCreditLine
        '
        Me.cmdCrearTypeCreditLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.cmdCrearTypeCreditLine.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdCrearTypeCreditLine.FlatAppearance.BorderSize = 0
        Me.cmdCrearTypeCreditLine.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdCrearTypeCreditLine.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdCrearTypeCreditLine.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCrearTypeCreditLine.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCrearTypeCreditLine.Location = New System.Drawing.Point(3, 3)
        Me.cmdCrearTypeCreditLine.Name = "cmdCrearTypeCreditLine"
        Me.cmdCrearTypeCreditLine.Size = New System.Drawing.Size(112, 66)
        Me.cmdCrearTypeCreditLine.TabIndex = 40
        Me.cmdCrearTypeCreditLine.Text = "Crear"
        Me.cmdCrearTypeCreditLine.UseVisualStyleBackColor = False
        '
        'cmdActualizarTypeCreditLine
        '
        Me.cmdActualizarTypeCreditLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.cmdActualizarTypeCreditLine.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdActualizarTypeCreditLine.FlatAppearance.BorderSize = 0
        Me.cmdActualizarTypeCreditLine.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdActualizarTypeCreditLine.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdActualizarTypeCreditLine.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdActualizarTypeCreditLine.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdActualizarTypeCreditLine.Location = New System.Drawing.Point(121, 3)
        Me.cmdActualizarTypeCreditLine.Name = "cmdActualizarTypeCreditLine"
        Me.cmdActualizarTypeCreditLine.Size = New System.Drawing.Size(112, 66)
        Me.cmdActualizarTypeCreditLine.TabIndex = 38
        Me.cmdActualizarTypeCreditLine.Text = "Modificar"
        Me.cmdActualizarTypeCreditLine.UseVisualStyleBackColor = False
        '
        'cmdEliminarTypeCreditLine
        '
        Me.cmdEliminarTypeCreditLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.cmdEliminarTypeCreditLine.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdEliminarTypeCreditLine.FlatAppearance.BorderSize = 0
        Me.cmdEliminarTypeCreditLine.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdEliminarTypeCreditLine.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdEliminarTypeCreditLine.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdEliminarTypeCreditLine.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEliminarTypeCreditLine.Location = New System.Drawing.Point(239, 3)
        Me.cmdEliminarTypeCreditLine.Name = "cmdEliminarTypeCreditLine"
        Me.cmdEliminarTypeCreditLine.Size = New System.Drawing.Size(112, 66)
        Me.cmdEliminarTypeCreditLine.TabIndex = 39
        Me.cmdEliminarTypeCreditLine.Text = "Eliminar"
        Me.cmdEliminarTypeCreditLine.UseVisualStyleBackColor = False
        '
        'cmdListadoTypeCreditLine
        '
        Me.cmdListadoTypeCreditLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.cmdListadoTypeCreditLine.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdListadoTypeCreditLine.FlatAppearance.BorderSize = 0
        Me.cmdListadoTypeCreditLine.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdListadoTypeCreditLine.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdListadoTypeCreditLine.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdListadoTypeCreditLine.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdListadoTypeCreditLine.Location = New System.Drawing.Point(357, 3)
        Me.cmdListadoTypeCreditLine.Name = "cmdListadoTypeCreditLine"
        Me.cmdListadoTypeCreditLine.Size = New System.Drawing.Size(127, 66)
        Me.cmdListadoTypeCreditLine.TabIndex = 43
        Me.cmdListadoTypeCreditLine.Text = "Listado Líneas de Crédito"
        Me.cmdListadoTypeCreditLine.UseVisualStyleBackColor = False
        Me.cmdListadoTypeCreditLine.Visible = False
        '
        'PartialPaymentsCatalog
        '
        Me.PartialPaymentsCatalog.Controls.Add(Me.TableLayoutPanel7)
        Me.PartialPaymentsCatalog.Location = New System.Drawing.Point(4, 35)
        Me.PartialPaymentsCatalog.Name = "PartialPaymentsCatalog"
        Me.PartialPaymentsCatalog.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.PartialPaymentsCatalog.Size = New System.Drawing.Size(1087, 540)
        Me.PartialPaymentsCatalog.TabIndex = 14
        Me.PartialPaymentsCatalog.Text = "Catálogo Pagos Parciales"
        Me.PartialPaymentsCatalog.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel7
        '
        Me.TableLayoutPanel7.ColumnCount = 1
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel7.Controls.Add(Me.dgvPartialPayments, 0, 1)
        Me.TableLayoutPanel7.Controls.Add(Me.FlowLayoutPanel5, 0, 0)
        Me.TableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel7.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableLayoutPanel7.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel7.Name = "TableLayoutPanel7"
        Me.TableLayoutPanel7.RowCount = 2
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 81.0!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel7.Size = New System.Drawing.Size(1081, 534)
        Me.TableLayoutPanel7.TabIndex = 11
        '
        'dgvPartialPayments
        '
        Me.dgvPartialPayments.AllowUserToAddRows = False
        Me.dgvPartialPayments.AllowUserToDeleteRows = False
        Me.dgvPartialPayments.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvPartialPayments.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id_Catalog, Me.DescriptionCatalog, Me.DataGridViewTextBoxColumn36, Me.DataGridViewTextBoxColumn37, Me.DataGridViewTextBoxColumn38, Me.DataGridViewTextBoxColumn39})
        Me.dgvPartialPayments.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvPartialPayments.EnableHeadersVisualStyles = False
        Me.dgvPartialPayments.Location = New System.Drawing.Point(3, 84)
        Me.dgvPartialPayments.Name = "dgvPartialPayments"
        Me.dgvPartialPayments.ReadOnly = True
        Me.dgvPartialPayments.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvPartialPayments.RowHeadersVisible = False
        Me.dgvPartialPayments.ShowCellErrors = False
        Me.dgvPartialPayments.ShowCellToolTips = False
        Me.dgvPartialPayments.ShowEditingIcon = False
        Me.dgvPartialPayments.ShowRowErrors = False
        Me.dgvPartialPayments.Size = New System.Drawing.Size(1075, 447)
        Me.dgvPartialPayments.TabIndex = 0
        '
        'Id_Catalog
        '
        Me.Id_Catalog.DataPropertyName = "Id_Catalog"
        Me.Id_Catalog.HeaderText = "Correlativo"
        Me.Id_Catalog.Name = "Id_Catalog"
        Me.Id_Catalog.ReadOnly = True
        Me.Id_Catalog.Width = 80
        '
        'DescriptionCatalog
        '
        Me.DescriptionCatalog.DataPropertyName = "DescriptionCatalog"
        Me.DescriptionCatalog.HeaderText = "Descripción"
        Me.DescriptionCatalog.Name = "DescriptionCatalog"
        Me.DescriptionCatalog.ReadOnly = True
        '
        'DataGridViewTextBoxColumn36
        '
        Me.DataGridViewTextBoxColumn36.DataPropertyName = "Create_Users"
        Me.DataGridViewTextBoxColumn36.HeaderText = "Create User"
        Me.DataGridViewTextBoxColumn36.Name = "DataGridViewTextBoxColumn36"
        Me.DataGridViewTextBoxColumn36.ReadOnly = True
        '
        'DataGridViewTextBoxColumn37
        '
        Me.DataGridViewTextBoxColumn37.DataPropertyName = "Create_Date"
        Me.DataGridViewTextBoxColumn37.HeaderText = "Create Date"
        Me.DataGridViewTextBoxColumn37.Name = "DataGridViewTextBoxColumn37"
        Me.DataGridViewTextBoxColumn37.ReadOnly = True
        '
        'DataGridViewTextBoxColumn38
        '
        Me.DataGridViewTextBoxColumn38.DataPropertyName = "Modify_Users"
        Me.DataGridViewTextBoxColumn38.HeaderText = "Modify User"
        Me.DataGridViewTextBoxColumn38.Name = "DataGridViewTextBoxColumn38"
        Me.DataGridViewTextBoxColumn38.ReadOnly = True
        '
        'DataGridViewTextBoxColumn39
        '
        Me.DataGridViewTextBoxColumn39.DataPropertyName = "Modify_Date"
        Me.DataGridViewTextBoxColumn39.HeaderText = "Fecha de Modificación"
        Me.DataGridViewTextBoxColumn39.Name = "DataGridViewTextBoxColumn39"
        Me.DataGridViewTextBoxColumn39.ReadOnly = True
        '
        'FlowLayoutPanel5
        '
        Me.FlowLayoutPanel5.Controls.Add(Me.cmdCrearPartialPayment)
        Me.FlowLayoutPanel5.Controls.Add(Me.cmdActualizarPartialPayment)
        Me.FlowLayoutPanel5.Controls.Add(Me.cmdEliminarPartialPayment)
        Me.FlowLayoutPanel5.Controls.Add(Me.cmdListadoPartialPayment)
        Me.FlowLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel5.Location = New System.Drawing.Point(3, 3)
        Me.FlowLayoutPanel5.Name = "FlowLayoutPanel5"
        Me.FlowLayoutPanel5.Size = New System.Drawing.Size(1075, 75)
        Me.FlowLayoutPanel5.TabIndex = 1
        '
        'cmdCrearPartialPayment
        '
        Me.cmdCrearPartialPayment.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.cmdCrearPartialPayment.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdCrearPartialPayment.FlatAppearance.BorderSize = 0
        Me.cmdCrearPartialPayment.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdCrearPartialPayment.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdCrearPartialPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCrearPartialPayment.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCrearPartialPayment.Location = New System.Drawing.Point(3, 3)
        Me.cmdCrearPartialPayment.Name = "cmdCrearPartialPayment"
        Me.cmdCrearPartialPayment.Size = New System.Drawing.Size(112, 66)
        Me.cmdCrearPartialPayment.TabIndex = 40
        Me.cmdCrearPartialPayment.Text = "Crear"
        Me.cmdCrearPartialPayment.UseVisualStyleBackColor = False
        '
        'cmdActualizarPartialPayment
        '
        Me.cmdActualizarPartialPayment.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.cmdActualizarPartialPayment.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdActualizarPartialPayment.FlatAppearance.BorderSize = 0
        Me.cmdActualizarPartialPayment.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdActualizarPartialPayment.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdActualizarPartialPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdActualizarPartialPayment.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdActualizarPartialPayment.Location = New System.Drawing.Point(121, 3)
        Me.cmdActualizarPartialPayment.Name = "cmdActualizarPartialPayment"
        Me.cmdActualizarPartialPayment.Size = New System.Drawing.Size(112, 66)
        Me.cmdActualizarPartialPayment.TabIndex = 38
        Me.cmdActualizarPartialPayment.Text = "Modificar"
        Me.cmdActualizarPartialPayment.UseVisualStyleBackColor = False
        '
        'cmdEliminarPartialPayment
        '
        Me.cmdEliminarPartialPayment.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.cmdEliminarPartialPayment.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdEliminarPartialPayment.FlatAppearance.BorderSize = 0
        Me.cmdEliminarPartialPayment.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdEliminarPartialPayment.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdEliminarPartialPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdEliminarPartialPayment.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEliminarPartialPayment.Location = New System.Drawing.Point(239, 3)
        Me.cmdEliminarPartialPayment.Name = "cmdEliminarPartialPayment"
        Me.cmdEliminarPartialPayment.Size = New System.Drawing.Size(112, 66)
        Me.cmdEliminarPartialPayment.TabIndex = 39
        Me.cmdEliminarPartialPayment.Text = "Eliminar"
        Me.cmdEliminarPartialPayment.UseVisualStyleBackColor = False
        '
        'cmdListadoPartialPayment
        '
        Me.cmdListadoPartialPayment.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.cmdListadoPartialPayment.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdListadoPartialPayment.FlatAppearance.BorderSize = 0
        Me.cmdListadoPartialPayment.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdListadoPartialPayment.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdListadoPartialPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdListadoPartialPayment.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdListadoPartialPayment.Location = New System.Drawing.Point(357, 3)
        Me.cmdListadoPartialPayment.Name = "cmdListadoPartialPayment"
        Me.cmdListadoPartialPayment.Size = New System.Drawing.Size(127, 66)
        Me.cmdListadoPartialPayment.TabIndex = 43
        Me.cmdListadoPartialPayment.Text = "Listado Líneas de Crédito"
        Me.cmdListadoPartialPayment.UseVisualStyleBackColor = False
        Me.cmdListadoPartialPayment.Visible = False
        '
        'ComprasIngreso
        '
        Me.ComprasIngreso.Controls.Add(Me.TableLayoutPanel8)
        Me.ComprasIngreso.Location = New System.Drawing.Point(4, 35)
        Me.ComprasIngreso.Name = "ComprasIngreso"
        Me.ComprasIngreso.Size = New System.Drawing.Size(1087, 540)
        Me.ComprasIngreso.TabIndex = 15
        Me.ComprasIngreso.Text = "Ingreso Compras"
        Me.ComprasIngreso.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel8
        '
        Me.TableLayoutPanel8.ColumnCount = 1
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel8.Controls.Add(Me.DGW_ComprasLista, 0, 1)
        Me.TableLayoutPanel8.Controls.Add(Me.FLP_IngresoCompras, 0, 0)
        Me.TableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel8.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableLayoutPanel8.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel8.Name = "TableLayoutPanel8"
        Me.TableLayoutPanel8.RowCount = 2
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75.0!))
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel8.Size = New System.Drawing.Size(1087, 540)
        Me.TableLayoutPanel8.TabIndex = 3
        '
        'DGW_ComprasLista
        '
        Me.DGW_ComprasLista.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGW_ComprasLista.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.imagenCompra, Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn29, Me.DataGridViewTextBoxColumn35, Me.DataGridViewTextBoxColumn40, Me.DataGridViewTextBoxColumn41, Me.DataGridViewTextBoxColumn42, Me.DataGridViewTextBoxColumn43, Me.DataGridViewTextBoxColumn44, Me.DataGridViewCheckBoxColumn1, Me.DataGridViewTextBoxColumn45, Me.DataGridViewTextBoxColumn46})
        Me.DGW_ComprasLista.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGW_ComprasLista.EnableHeadersVisualStyles = False
        Me.DGW_ComprasLista.Location = New System.Drawing.Point(3, 78)
        Me.DGW_ComprasLista.Name = "DGW_ComprasLista"
        Me.DGW_ComprasLista.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DGW_ComprasLista.RowHeadersVisible = False
        Me.DGW_ComprasLista.ShowCellErrors = False
        Me.DGW_ComprasLista.ShowCellToolTips = False
        Me.DGW_ComprasLista.ShowEditingIcon = False
        Me.DGW_ComprasLista.ShowRowErrors = False
        Me.DGW_ComprasLista.Size = New System.Drawing.Size(1081, 459)
        Me.DGW_ComprasLista.TabIndex = 0
        '
        'imagenCompra
        '
        Me.imagenCompra.HeaderText = ""
        Me.imagenCompra.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch
        Me.imagenCompra.Name = "imagenCompra"
        Me.imagenCompra.Width = 50
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "Id_TransactionPurchases"
        Me.DataGridViewTextBoxColumn21.HeaderText = "Correlativo"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        Me.DataGridViewTextBoxColumn21.Width = 107
        '
        'DataGridViewTextBoxColumn29
        '
        Me.DataGridViewTextBoxColumn29.DataPropertyName = "BusinessDay"
        Me.DataGridViewTextBoxColumn29.HeaderText = "Fecha"
        Me.DataGridViewTextBoxColumn29.Name = "DataGridViewTextBoxColumn29"
        Me.DataGridViewTextBoxColumn29.Width = 72
        '
        'DataGridViewTextBoxColumn35
        '
        Me.DataGridViewTextBoxColumn35.DataPropertyName = "Commercial_Name"
        Me.DataGridViewTextBoxColumn35.HeaderText = "Cliente / Razón Social"
        Me.DataGridViewTextBoxColumn35.Name = "DataGridViewTextBoxColumn35"
        Me.DataGridViewTextBoxColumn35.Width = 179
        '
        'DataGridViewTextBoxColumn40
        '
        Me.DataGridViewTextBoxColumn40.DataPropertyName = "Fullpayment"
        Me.DataGridViewTextBoxColumn40.HeaderText = "Total Factura"
        Me.DataGridViewTextBoxColumn40.Name = "DataGridViewTextBoxColumn40"
        Me.DataGridViewTextBoxColumn40.Width = 120
        '
        'DataGridViewTextBoxColumn41
        '
        Me.DataGridViewTextBoxColumn41.DataPropertyName = "DocumentNumber"
        Me.DataGridViewTextBoxColumn41.HeaderText = "No. Fac/CF"
        Me.DataGridViewTextBoxColumn41.Name = "DataGridViewTextBoxColumn41"
        Me.DataGridViewTextBoxColumn41.Width = 105
        '
        'DataGridViewTextBoxColumn42
        '
        Me.DataGridViewTextBoxColumn42.DataPropertyName = "DescriptionCustomer"
        Me.DataGridViewTextBoxColumn42.HeaderText = "Tipo doc."
        Me.DataGridViewTextBoxColumn42.Name = "DataGridViewTextBoxColumn42"
        Me.DataGridViewTextBoxColumn42.Width = 96
        '
        'DataGridViewTextBoxColumn43
        '
        Me.DataGridViewTextBoxColumn43.DataPropertyName = "UsersCreate"
        Me.DataGridViewTextBoxColumn43.HeaderText = "Usuario"
        Me.DataGridViewTextBoxColumn43.Name = "DataGridViewTextBoxColumn43"
        Me.DataGridViewTextBoxColumn43.Width = 84
        '
        'DataGridViewTextBoxColumn44
        '
        Me.DataGridViewTextBoxColumn44.DataPropertyName = "DateCreate"
        Me.DataGridViewTextBoxColumn44.HeaderText = "Fecha Creación"
        Me.DataGridViewTextBoxColumn44.Name = "DataGridViewTextBoxColumn44"
        Me.DataGridViewTextBoxColumn44.Width = 134
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "StatusTransaction"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "Activo"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewCheckBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewCheckBoxColumn1.Width = 106
        '
        'DataGridViewTextBoxColumn45
        '
        Me.DataGridViewTextBoxColumn45.DataPropertyName = "DateCancellation"
        Me.DataGridViewTextBoxColumn45.HeaderText = "Fecha Anulación"
        Me.DataGridViewTextBoxColumn45.Name = "DataGridViewTextBoxColumn45"
        Me.DataGridViewTextBoxColumn45.Width = 142
        '
        'DataGridViewTextBoxColumn46
        '
        Me.DataGridViewTextBoxColumn46.DataPropertyName = "UsersCancellation"
        Me.DataGridViewTextBoxColumn46.HeaderText = "usuarioAnulo"
        Me.DataGridViewTextBoxColumn46.Name = "DataGridViewTextBoxColumn46"
        Me.DataGridViewTextBoxColumn46.Width = 121
        '
        'FLP_IngresoCompras
        '
        Me.FLP_IngresoCompras.Controls.Add(Me.cmdCompraFactura)
        Me.FLP_IngresoCompras.Controls.Add(Me.cmdCompraCreditoFiscal)
        Me.FLP_IngresoCompras.Controls.Add(Me.cmdCompraImportado)
        Me.FLP_IngresoCompras.Controls.Add(Me.cmdLibroVentasFactura)
        Me.FLP_IngresoCompras.Controls.Add(Me.cmdImpresionLibroCreditoFiscal)
        Me.FLP_IngresoCompras.Controls.Add(Me.cmdComprasLibro)
        Me.FLP_IngresoCompras.Controls.Add(Me.BusquedaGeneral2)
        Me.FLP_IngresoCompras.Controls.Add(Me.Calendar2)
        Me.FLP_IngresoCompras.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FLP_IngresoCompras.Location = New System.Drawing.Point(3, 3)
        Me.FLP_IngresoCompras.Name = "FLP_IngresoCompras"
        Me.FLP_IngresoCompras.Size = New System.Drawing.Size(1081, 69)
        Me.FLP_IngresoCompras.TabIndex = 1
        '
        'cmdCompraFactura
        '
        Me.cmdCompraFactura.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.cmdCompraFactura.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdCompraFactura.FlatAppearance.BorderSize = 0
        Me.cmdCompraFactura.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdCompraFactura.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdCompraFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCompraFactura.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCompraFactura.Location = New System.Drawing.Point(3, 3)
        Me.cmdCompraFactura.Name = "cmdCompraFactura"
        Me.cmdCompraFactura.Size = New System.Drawing.Size(98, 66)
        Me.cmdCompraFactura.TabIndex = 31
        Me.cmdCompraFactura.Text = "Compra Factura"
        Me.cmdCompraFactura.UseVisualStyleBackColor = False
        '
        'cmdCompraCreditoFiscal
        '
        Me.cmdCompraCreditoFiscal.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.cmdCompraCreditoFiscal.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdCompraCreditoFiscal.FlatAppearance.BorderSize = 0
        Me.cmdCompraCreditoFiscal.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdCompraCreditoFiscal.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdCompraCreditoFiscal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCompraCreditoFiscal.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCompraCreditoFiscal.Location = New System.Drawing.Point(107, 3)
        Me.cmdCompraCreditoFiscal.Name = "cmdCompraCreditoFiscal"
        Me.cmdCompraCreditoFiscal.Size = New System.Drawing.Size(120, 66)
        Me.cmdCompraCreditoFiscal.TabIndex = 33
        Me.cmdCompraCreditoFiscal.Text = "Compra " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Crédito Fiscal"
        Me.cmdCompraCreditoFiscal.UseVisualStyleBackColor = False
        '
        'cmdCompraImportado
        '
        Me.cmdCompraImportado.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.cmdCompraImportado.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdCompraImportado.FlatAppearance.BorderSize = 0
        Me.cmdCompraImportado.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdCompraImportado.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdCompraImportado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCompraImportado.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCompraImportado.Location = New System.Drawing.Point(233, 3)
        Me.cmdCompraImportado.Name = "cmdCompraImportado"
        Me.cmdCompraImportado.Size = New System.Drawing.Size(112, 66)
        Me.cmdCompraImportado.TabIndex = 32
        Me.cmdCompraImportado.Text = "Compra Importados"
        Me.cmdCompraImportado.UseVisualStyleBackColor = False
        '
        'cmdLibroVentasFactura
        '
        Me.cmdLibroVentasFactura.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.cmdLibroVentasFactura.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdLibroVentasFactura.FlatAppearance.BorderSize = 0
        Me.cmdLibroVentasFactura.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdLibroVentasFactura.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdLibroVentasFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdLibroVentasFactura.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLibroVentasFactura.Location = New System.Drawing.Point(351, 3)
        Me.cmdLibroVentasFactura.Name = "cmdLibroVentasFactura"
        Me.cmdLibroVentasFactura.Size = New System.Drawing.Size(133, 66)
        Me.cmdLibroVentasFactura.TabIndex = 43
        Me.cmdLibroVentasFactura.Text = "Libro de Ventas Factura"
        Me.cmdLibroVentasFactura.UseVisualStyleBackColor = False
        '
        'cmdImpresionLibroCreditoFiscal
        '
        Me.cmdImpresionLibroCreditoFiscal.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.cmdImpresionLibroCreditoFiscal.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdImpresionLibroCreditoFiscal.FlatAppearance.BorderSize = 0
        Me.cmdImpresionLibroCreditoFiscal.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdImpresionLibroCreditoFiscal.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdImpresionLibroCreditoFiscal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdImpresionLibroCreditoFiscal.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdImpresionLibroCreditoFiscal.Location = New System.Drawing.Point(490, 3)
        Me.cmdImpresionLibroCreditoFiscal.Name = "cmdImpresionLibroCreditoFiscal"
        Me.cmdImpresionLibroCreditoFiscal.Size = New System.Drawing.Size(112, 66)
        Me.cmdImpresionLibroCreditoFiscal.TabIndex = 35
        Me.cmdImpresionLibroCreditoFiscal.Text = "Libro ventas CF"
        Me.cmdImpresionLibroCreditoFiscal.UseVisualStyleBackColor = False
        '
        'cmdComprasLibro
        '
        Me.cmdComprasLibro.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.cmdComprasLibro.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdComprasLibro.FlatAppearance.BorderSize = 0
        Me.cmdComprasLibro.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdComprasLibro.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdComprasLibro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdComprasLibro.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdComprasLibro.Location = New System.Drawing.Point(608, 3)
        Me.cmdComprasLibro.Name = "cmdComprasLibro"
        Me.cmdComprasLibro.Size = New System.Drawing.Size(119, 66)
        Me.cmdComprasLibro.TabIndex = 44
        Me.cmdComprasLibro.Text = "Libro de Compras"
        Me.cmdComprasLibro.UseVisualStyleBackColor = False
        '
        'BusquedaGeneral2
        '
        Me.BusquedaGeneral2.Location = New System.Drawing.Point(734, 5)
        Me.BusquedaGeneral2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BusquedaGeneral2.Name = "BusquedaGeneral2"
        Me.BusquedaGeneral2.Size = New System.Drawing.Size(144, 57)
        Me.BusquedaGeneral2.TabIndex = 46
        '
        'Calendar2
        '
        Me.Calendar2.CalendarDimensions = New System.Drawing.Size(0, 0)
        Me.Calendar2.Location = New System.Drawing.Point(4, 77)
        Me.Calendar2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Calendar2.Name = "Calendar2"
        Me.Calendar2.OpcionCuenta = epd_SatelliteERP.calendar.TipoCuenta.Cuenta_Cobrar
        Me.Calendar2.Size = New System.Drawing.Size(1196, 697)
        Me.Calendar2.TabIndex = 45
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.HeaderText = ""
        Me.DataGridViewImageColumn1.Image = Global.epd_SatelliteERP.My.Resources.Resources.Roja_Bandera
        Me.DataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.Width = 50
        '
        'ModuloCuentasPorCobrar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.tcMain)
        Me.Name = "ModuloCuentasPorCobrar"
        Me.Size = New System.Drawing.Size(1095, 579)
        Me.tcMain.ResumeLayout(False)
        Me.VistaGeneral.ResumeLayout(False)
        Me.gbStudentDetails.ResumeLayout(False)
        Me.Facturacion.ResumeLayout(False)
        Me.TLP_Facturacion.ResumeLayout(False)
        CType(Me.DGW_FacturasLista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.ClientesMora.ResumeLayout(False)
        Me.TLP_PlanDePagos.ResumeLayout(False)
        CType(Me.DGV_CustomMora, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel3.ResumeLayout(False)
        Me.Proyectos.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.DGV_Proyectos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel6.ResumeLayout(False)
        Me.Cotizaciones.ResumeLayout(False)
        Me.TLP_Cotizaciones.ResumeLayout(False)
        CType(Me.DGW_CotizacionLista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel4.ResumeLayout(False)
        Me.ConfigurarFacturas.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.Panel_ConfiguracionFacturaTrabajo.ResumeLayout(False)
        Me.CuentasActivas.ResumeLayout(False)
        Me.TLP_Clientes.ResumeLayout(False)
        CType(Me.DGVClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FLPCuentasActivas.ResumeLayout(False)
        Me.IndicadorVentas.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.chartHoras, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.ChartAnio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        CType(Me.ChartMes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EntradasySalidas.ResumeLayout(False)
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        CType(Me.ChartAnalisis, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.TypeCreditLine.ResumeLayout(False)
        Me.TableLayoutPanel6.ResumeLayout(False)
        CType(Me.dgvTypeCreditLine, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel12.ResumeLayout(False)
        Me.PartialPaymentsCatalog.ResumeLayout(False)
        Me.TableLayoutPanel7.ResumeLayout(False)
        CType(Me.dgvPartialPayments, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel5.ResumeLayout(False)
        Me.ComprasIngreso.ResumeLayout(False)
        Me.TableLayoutPanel8.ResumeLayout(False)
        CType(Me.DGW_ComprasLista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FLP_IngresoCompras.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents tcMain As TabControl
    Private WithEvents VistaGeneral As TabPage
    Private WithEvents gbStudentDetails As GroupBox
    Friend WithEvents Facturacion As TabPage
    Friend WithEvents TLP_Facturacion As TableLayoutPanel
    Friend WithEvents DGW_FacturasLista As DataGridView
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents ClientesMora As TabPage
    Private WithEvents cmdCreateFactura As Button
    Private WithEvents cmdFacturacion_Re_Print As Button
    Friend WithEvents Cotizaciones As TabPage
    Friend WithEvents ConfigurarFacturas As TabPage
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Private WithEvents cmd_ConfigFactura_Preview As Button
    Private WithEvents cmd_ConfigCF_Preview As Button
    Private WithEvents cmd_ConfigFactura_Config As Button
    Private WithEvents cmd_ConfigCF_Config As Button
    Private WithEvents cmd_ConfigCF_ZoomMAS As Button
    Private WithEvents cmd_ConfigCF_ZoomMenos As Button
    Friend WithEvents Panel_ConfiguracionFacturaTrabajo As Panel
    Friend WithEvents PPC_ConfigFactura As PrintPreviewControl
    Private WithEvents cmdCreateCF As Button
    Private WithEvents cmdCorreoFactura As Button
    Friend WithEvents GraficosFacturacion As TabPage
    Friend WithEvents Financiero_GraficoFacturacion1 As Financiero_GraficoFacturacion
    Friend WithEvents TLP_PlanDePagos As TableLayoutPanel
    Friend WithEvents DGV_CustomMora As DataGridView
    Friend WithEvents FlowLayoutPanel3 As FlowLayoutPanel
    Friend WithEvents TLP_Cotizaciones As TableLayoutPanel
    Friend WithEvents DGW_CotizacionLista As DataGridView
    Friend WithEvents FlowLayoutPanel4 As FlowLayoutPanel
    Private WithEvents cmdCotizacionCF_Crear As Button
    Private WithEvents cmdCotizacionFactura_Modificar As Button
    Private WithEvents cmdCotizacionCF_ReImpresion As Button
    Private WithEvents Button12 As Button
    Private WithEvents cmdCotizacion_Anular As Button
    Private WithEvents cmdCotizacion_ConvertirFactura As Button
    Friend WithEvents CuentasActivas As TabPage
    Friend WithEvents TLP_Clientes As TableLayoutPanel
    Friend WithEvents DGVClientes As DataGridView
    Friend WithEvents FLPCuentasActivas As FlowLayoutPanel
    Private WithEvents cmdCrearCliente As Button
    Private WithEvents cmdModificarCliente As Button
    Private WithEvents cmdLineaCredito As Button
    Private WithEvents cmdReporteCatalogoCliente As Button
    Private WithEvents cmdCatalogoClienteFinanciero As Button
    Private WithEvents cmdFichaCliente As Button
    Private WithEvents cmdCuentaCxC_AgregarCobro As Button
    Private WithEvents cmdCuotaClienteMora As Button
    Friend WithEvents flpCalendar As FlowLayoutPanel
    Friend WithEvents Proyectos As TabPage
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents DGV_Proyectos As DataGridView
    Friend WithEvents FlowLayoutPanel6 As FlowLayoutPanel
    Private WithEvents Button2 As Button
    Private WithEvents Button3 As Button
    Private WithEvents Button5 As Button
    Private WithEvents Button6 As Button
    Private WithEvents Button7 As Button
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn26 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn27 As DataGridViewTextBoxColumn
    Friend WithEvents NombreProyecto As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn28 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn30 As DataGridViewTextBoxColumn
    Friend WithEvents AvanceProyecto As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn31 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn32 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn33 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn34 As DataGridViewTextBoxColumn
    Private WithEvents cmdCotizacionFactura_Crear As Button
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Private WithEvents cmdCuentasActivas_CrearManual As Button
    Private WithEvents cmdCuentasActivas_EstadoCuentaCliente As Button
    Private WithEvents cmdCuentaActiva_PagoCuotaFecha As Button
    Private WithEvents cmdCuentaActiva_EstadoPagos As Button
    Private WithEvents cmdCotizaciones_OrdenProduccion As Button
    Private WithEvents cmdCotizaciones_EntregaVendedor As Button
    Private WithEvents cmd_CuentasActivas_AddPayment As Button
    Private WithEvents Button1 As Button
    Private WithEvents Button4 As Button
    Private WithEvents Button8 As Button
    Private WithEvents Button9 As Button
    Private WithEvents cmdCuentasActivas_DeudasClientes As Button
    Private WithEvents cmdCuentasActivas_CotizacionPorCliente As Button
    Private WithEvents cmdPagos As Button
    Private WithEvents cmdCxCMora_Autorizaciones As Button
    Private WithEvents cmdIndicador As Button
    Private WithEvents cmdMontosVencidos As Button
    Private WithEvents cmdCuentasActivas_DeudasVendedor As Button
    Private WithEvents Button10 As Button
    Friend WithEvents Calendar1 As calendar
    Friend WithEvents BusquedaGeneral1 As BusquedaGeneral
    Friend WithEvents IndicadorVentas As TabPage
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblHoras As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents chartHoras As DataVisualization.Charting.Chart
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents lblMes As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents lblAnio As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents ChartAnio As DataVisualization.Charting.Chart
    Friend WithEvents Panel4 As Panel
    Friend WithEvents ChartMes As DataVisualization.Charting.Chart
    Private WithEvents btnLogEntriesExitsActualMonth As Button
    Private WithEvents btnLogEntriesExitsActualYear As Button
    Private WithEvents btnLogEntriesExitsActualFilter As Button
    Friend WithEvents EntradasySalidas As TabPage
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents ChartAnalisis As DataVisualization.Charting.Chart
    Friend WithEvents Panel7 As Panel
    Friend WithEvents lblEntradasSalidas As Label
    Friend WithEvents imagen As DataGridViewImageColumn
    Friend WithEvents Correlativo As DataGridViewTextBoxColumn
    Friend WithEvents BusinessDay As DataGridViewTextBoxColumn
    Friend WithEvents Commercial_Name As DataGridViewTextBoxColumn
    Friend WithEvents Fullpayment As DataGridViewTextBoxColumn
    Friend WithEvents DocumentNumber As DataGridViewTextBoxColumn
    Friend WithEvents DescriptionCustomer As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents DateCreate1 As DataGridViewTextBoxColumn
    Friend WithEvents StatusTransaction As DataGridViewCheckBoxColumn
    Friend WithEvents FechaAnulacion As DataGridViewTextBoxColumn
    Friend WithEvents UsuarioAnulo As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn2 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As DataGridViewTextBoxColumn
    Friend WithEvents Id_Customer As DataGridViewTextBoxColumn
    Friend WithEvents Is_Supplier As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn25 As DataGridViewTextBoxColumn
    Friend WithEvents Email_Contact As DataGridViewTextBoxColumn
    Friend WithEvents TypeCreditLine As TabPage
    Friend WithEvents PartialPaymentsCatalog As TabPage
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents dgvTypeCreditLine As DataGridView
    Friend WithEvents Id_TypeCreditLine As DataGridViewTextBoxColumn
    Friend WithEvents Type_CreditLine As DataGridViewTextBoxColumn
    Friend WithEvents DescriptionCreditLine As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn51 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn52 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn53 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn54 As DataGridViewTextBoxColumn
    Friend WithEvents FlowLayoutPanel12 As FlowLayoutPanel
    Private WithEvents cmdCrearTypeCreditLine As Button
    Private WithEvents cmdActualizarTypeCreditLine As Button
    Private WithEvents cmdEliminarTypeCreditLine As Button
    Private WithEvents cmdListadoTypeCreditLine As Button
    Friend WithEvents TableLayoutPanel7 As TableLayoutPanel
    Friend WithEvents dgvPartialPayments As DataGridView
    Friend WithEvents Id_Catalog As DataGridViewTextBoxColumn
    Friend WithEvents DescriptionCatalog As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn36 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn37 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn38 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn39 As DataGridViewTextBoxColumn
    Friend WithEvents FlowLayoutPanel5 As FlowLayoutPanel
    Private WithEvents cmdCrearPartialPayment As Button
    Private WithEvents cmdActualizarPartialPayment As Button
    Private WithEvents cmdEliminarPartialPayment As Button
    Private WithEvents cmdListadoPartialPayment As Button
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
    Friend WithEvents ComprasIngreso As TabPage
    Friend WithEvents TableLayoutPanel8 As TableLayoutPanel
    Friend WithEvents DGW_ComprasLista As DataGridView
    Friend WithEvents imagenCompra As DataGridViewImageColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn29 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn35 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn40 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn41 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn42 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn43 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn44 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn45 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn46 As DataGridViewTextBoxColumn
    Friend WithEvents FLP_IngresoCompras As FlowLayoutPanel
    Private WithEvents cmdCompraFactura As Button
    Private WithEvents cmdCompraCreditoFiscal As Button
    Private WithEvents cmdCompraImportado As Button
    Private WithEvents cmdLibroVentasFactura As Button
    Private WithEvents cmdImpresionLibroCreditoFiscal As Button
    Private WithEvents cmdComprasLibro As Button
    Friend WithEvents BusquedaGeneral2 As BusquedaGeneral
    Friend WithEvents Calendar2 As calendar
    Private WithEvents cmdFacturacion_Anulacion As Button
End Class
