Imports System.IO
Imports System.Windows.Forms.DataVisualization.Charting

Public Class ModuloCuentasPorCobrar
    Private objFinance As New Financiero_SQLServer
    Private objGeneric As New Generic_SQLServer
    Private _tableConfigBilling As DataTable
    Private _tableInvoiceHeader As DataTable
    Private _tableInvoiceHeaderQuotation As DataTable
    Private _tableCustomer As DataTable
    Private _tableCustomerBalanceDue As DataTable
    Private _tableProject As DataTable
    Private _IsFacturacion As Boolean = False

    Private Sub tcMain_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tcMain.SelectedIndexChanged
        If sender.SelectedTab.Name = "Facturacion" Then
            GetDataFacturas()
        ElseIf sender.SelectedTab.Name = "CuentasActivas" Then
            GetClientes()
        ElseIf sender.SelectedTab.Name = "ClientesMora" Then
            GetClientesMora()
        ElseIf sender.SelectedTab.Name = "Proyectos" Then
            GetProyectos()
        ElseIf sender.SelectedTab.Name = "Cotizaciones" Then
            GetDataCotizaciones()
        ElseIf sender.SelectedTab.Name = "IndicadorVentas" Then
            LoadData()
        ElseIf sender.SelectedTab.Name = "TypeCreditLine" Then
            GetDataTypeCreditLine()
        ElseIf sender.SelectedTab.Name = "PartialPaymentsCatalog" Then
            GetPartialPaymentsCatalog()
        ElseIf sender.SelectedTab.Name = "ComprasIngreso" Then
            GetDataCompras()
        Else
            LoadAnalisisEntradaSalida()

        End If
    End Sub
    Private Sub GetClientesMora()
        _tableCustomerBalanceDue = objGeneric.GetListAccountsReceivableBalanceDue(Data_Id_Company)
        DGV_CustomMora.AutoGenerateColumns = False
        DGV_CustomMora.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
        DGV_CustomMora.Font = New Font("Segoe UI", 11)
        DGV_CustomMora.Columns(0).Width = 100
        DGV_CustomMora.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DGV_CustomMora.Columns(1).Width = 250
        DGV_CustomMora.Columns(2).Width = 200
        DGV_CustomMora.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DGV_CustomMora.Columns(3).DefaultCellStyle.Format = "c"
        DGV_CustomMora.Columns(3).Width = 120
        DGV_CustomMora.Columns(4).Width = 120
        DGV_CustomMora.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        DGV_CustomMora.Columns(5).Width = 120
        DGV_CustomMora.Columns(6).Width = 120
        DGV_CustomMora.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        DGV_CustomMora.Columns(7).Width = 120
        DGV_CustomMora.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DGV_CustomMora.Columns(7).DefaultCellStyle.Format = "c"

        DGV_CustomMora.Columns(8).Width = 120
        DGV_CustomMora.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DGV_CustomMora.Columns(8).DefaultCellStyle.Format = "c"

        DGV_CustomMora.Columns(9).Width = 120
        DGV_CustomMora.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DGV_CustomMora.Columns(9).DefaultCellStyle.Format = "c"

        DGV_CustomMora.Columns(10).Width = 120
        DGV_CustomMora.Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DGV_CustomMora.Columns(10).DefaultCellStyle.Format = "c"

        DGV_CustomMora.ReadOnly = True
        DGV_CustomMora.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DGV_CustomMora.MultiSelect = False

        DGV_CustomMora.AllowUserToResizeColumns = False
        DGV_CustomMora.AllowUserToAddRows = False
        DGV_CustomMora.AllowUserToDeleteRows = False
        DGV_CustomMora.DataSource = _tableCustomerBalanceDue

    End Sub
    Private Sub GetProyectos()
        _tableProject = objFinance.GetFinance_ProjectList(Data_Id_Company)
        DGV_Proyectos.AutoGenerateColumns = False
        DGV_Proyectos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
        DGV_Proyectos.Font = New Font("Segoe UI", 11)
        DGV_Proyectos.Columns(0).Width = 100
        DGV_Proyectos.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DGV_Proyectos.Columns(1).Width = 250
        DGV_Proyectos.Columns(2).Width = 200
        DGV_Proyectos.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DGV_Proyectos.Columns(3).DefaultCellStyle.Format = "c"
        DGV_Proyectos.Columns(3).Width = 120
        DGV_Proyectos.Columns(4).Width = 120
        DGV_Proyectos.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        DGV_Proyectos.Columns(5).Width = 120
        DGV_Proyectos.Columns(6).Width = 120
        DGV_Proyectos.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DGV_Proyectos.Columns(7).Width = 120
        DGV_Proyectos.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DGV_Proyectos.Columns(7).DefaultCellStyle.Format = "c"
        DGV_Proyectos.Columns(8).Width = 120
        DGV_Proyectos.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DGV_Proyectos.Columns(8).DefaultCellStyle.Format = "c"
        DGV_Proyectos.Columns(9).Width = 120
        DGV_Proyectos.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DGV_Proyectos.Columns(9).DefaultCellStyle.Format = "c"
        DGV_Proyectos.Columns(10).Width = 120
        DGV_Proyectos.Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DGV_Proyectos.Columns(10).DefaultCellStyle.Format = "c"
        DGV_Proyectos.ReadOnly = True
        DGV_Proyectos.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DGV_Proyectos.MultiSelect = False
        DGV_Proyectos.AllowUserToResizeColumns = False
        DGV_Proyectos.AllowUserToAddRows = False
        DGV_Proyectos.AllowUserToDeleteRows = False
        DGV_Proyectos.DataSource = _tableProject

    End Sub

    Private Sub GetClientes()
        _tableCustomer = objGeneric.GetCustomerClientList(Data_Id_Company, -1, -1, -1, 1)
        DGVClientes.AutoGenerateColumns = False
        DGVClientes.Font = New Font("Segoe UI", 11)
        DGVClientes.Columns(0).Width = 120
        DGVClientes.Columns(1).Width = 120
        DGVClientes.Columns(2).Width = 250
        DGVClientes.Columns(3).Width = 300
        DGVClientes.Columns(4).Width = 300
        DGVClientes.Columns(5).Width = 120
        DGVClientes.Columns(6).Width = 250
        DGVClientes.ReadOnly = True
        DGVClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DGVClientes.MultiSelect = False
        DGVClientes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
        DGVClientes.AllowUserToResizeColumns = False
        DGVClientes.AllowUserToAddRows = False
        DGVClientes.AllowUserToDeleteRows = False
        DGVClientes.DataSource = _tableInvoiceHeader

        DGVClientes.DataSource = _tableCustomer
    End Sub
    Private Sub GetDataFacturas()
        _tableInvoiceHeader = objFinance.GetInvoice_TransactionHeader_Select(Data_Id_Company, Data_BusinessDay)
        DGW_FacturasLista.AutoGenerateColumns = False
        DGW_FacturasLista.Font = New Font("Segoe UI", 11)
        DGW_FacturasLista.Columns(0).Width = 35
        DGW_FacturasLista.Columns(1).Width = 90
        DGW_FacturasLista.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        DGW_FacturasLista.Columns(2).Width = 100
        DGW_FacturasLista.Columns(3).Width = 280
        DGW_FacturasLista.Columns(4).Width = 100
        DGW_FacturasLista.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DGW_FacturasLista.Columns(4).DefaultCellStyle.Format = "c"

        DGW_FacturasLista.Columns(5).Width = 100
        DGW_FacturasLista.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DGW_FacturasLista.Columns(5).Width = 130
        DGW_FacturasLista.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        DGW_FacturasLista.Columns(6).Width = 130
        DGW_FacturasLista.Columns(7).Width = 130
        DGW_FacturasLista.Columns(8).Width = 180

        DGW_FacturasLista.ReadOnly = True
        DGW_FacturasLista.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DGW_FacturasLista.MultiSelect = False
        DGW_FacturasLista.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
        DGW_FacturasLista.AllowUserToResizeColumns = False
        DGW_FacturasLista.AllowUserToAddRows = False
        DGW_FacturasLista.AllowUserToDeleteRows = False
        DGW_FacturasLista.DataSource = _tableInvoiceHeader
        EstadosGrid_Factura()
    End Sub

    Private Sub GetDataTypeCreditLine()
        _tableCustomer = objGeneric.ERP_SP_GetTypeCreditLine(Data_Id_Company)
        dgvTypeCreditLine.AutoGenerateColumns = False
        dgvTypeCreditLine.Font = New Font("Segoe UI", 11)
        dgvTypeCreditLine.Columns(0).Width = 120
        dgvTypeCreditLine.Columns(1).Width = 120
        dgvTypeCreditLine.Columns(2).Width = 250
        dgvTypeCreditLine.Columns(3).Width = 300
        dgvTypeCreditLine.Columns(4).Width = 300
        dgvTypeCreditLine.Columns(5).Width = 120
        dgvTypeCreditLine.Columns(6).Width = 250
        dgvTypeCreditLine.ReadOnly = True
        dgvTypeCreditLine.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvTypeCreditLine.MultiSelect = False
        dgvTypeCreditLine.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
        dgvTypeCreditLine.AllowUserToResizeColumns = False
        dgvTypeCreditLine.AllowUserToAddRows = False
        dgvTypeCreditLine.AllowUserToDeleteRows = False
        dgvTypeCreditLine.DataSource = _tableInvoiceHeader

        dgvTypeCreditLine.DataSource = _tableCustomer
    End Sub

    Private Sub GetPartialPaymentsCatalog()
        _tableCustomer = objGeneric.ERP_AccountsReceivable_GET_PartialPaymentsCatalog(Data_Id_Company)
        dgvPartialPayments.AutoGenerateColumns = False
        dgvPartialPayments.Font = New Font("Segoe UI", 11)
        dgvPartialPayments.Columns(0).Width = 120
        dgvPartialPayments.Columns(1).Width = 120
        dgvPartialPayments.Columns(2).Width = 250
        dgvPartialPayments.Columns(3).Width = 300
        dgvPartialPayments.Columns(4).Width = 300
        dgvPartialPayments.Columns(5).Width = 120
        dgvPartialPayments.ReadOnly = True
        dgvPartialPayments.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvPartialPayments.MultiSelect = False
        dgvPartialPayments.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
        dgvPartialPayments.AllowUserToResizeColumns = False
        dgvPartialPayments.AllowUserToAddRows = False
        dgvPartialPayments.AllowUserToDeleteRows = False
        dgvPartialPayments.DataSource = _tableInvoiceHeader

        dgvPartialPayments.DataSource = _tableCustomer
    End Sub

    Private Sub EstadosGrid_Factura()
        For Each row As DataGridViewRow In DGW_FacturasLista.Rows
            Try
                row.Cells("Imagen").Value = Nothing
                If row.Cells("StatusTransaction").Value = "True" Then
                    row.Cells("Imagen").Value = epd_SatelliteERP.My.Resources.Resources.Verde_Bandera
                Else
                    row.Cells("Imagen").Value = epd_SatelliteERP.My.Resources.Resources.Roja_Bandera
                End If
            Catch ex As Exception
                ' No existe cambio unicamente es valor nulo
                row.Cells("Imagen").Value = epd_SatelliteERP.My.Resources.Resources.Verde_Bandera
            End Try
        Next
    End Sub
    Sub New(ByVal IsFacturacion As Boolean, Optional ByVal IsCompra As Boolean = False)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        'If IsFacturacion Then
        '    tcMain.TabPages.Remove(tcMain.TabPages.Item(0))
        '    tcMain.TabPages.Remove(tcMain.TabPages.Item(1))
        '    tcMain.TabPages.Remove(tcMain.TabPages.Item(1))
        '    tcMain.TabPages.Remove(tcMain.TabPages.Item(2))
        '    tcMain.TabPages.Remove(tcMain.TabPages.Item(2))
        '    REM tcMain.TabPages.Remove(tcMain.TabPages.Item(3))
        '    _IsFacturacion = IsFacturacion
        '    GetDataFacturas()

        'Else
        '    tcMain.TabPages.Remove(tcMain.TabPages.Item(3))
        'End If
        If Not IsCompra Then
            If IsFacturacion Then
                tcMain.TabPages.Remove(tcMain.TabPages.Item(0))
                tcMain.TabPages.Remove(tcMain.TabPages.Item(1))
                tcMain.TabPages.Remove(tcMain.TabPages.Item(1))
                tcMain.TabPages.Remove(tcMain.TabPages.Item(2))
                tcMain.TabPages.Remove(tcMain.TabPages.Item(2))
                REM tcMain.TabPages.Remove(tcMain.TabPages.Item(3))
                _IsFacturacion = IsFacturacion
                GetDataFacturas()

            Else
                tcMain.TabPages.Remove(tcMain.TabPages.Item(3))
            End If
        Else
            tcMain.TabPages.Remove(tcMain.TabPages.Item(0))
            tcMain.TabPages.Remove(tcMain.TabPages.Item(1))
            tcMain.TabPages.Remove(tcMain.TabPages.Item(1))
            tcMain.TabPages.Remove(tcMain.TabPages.Item(1))
            tcMain.TabPages.Remove(tcMain.TabPages.Item(2))
            tcMain.TabPages.Remove(tcMain.TabPages.Item(4))
            tcMain.TabPages.Remove(tcMain.TabPages.Item(4))
            tcMain.TabPages.Remove(tcMain.TabPages.Item(4))
            _IsFacturacion = IsFacturacion
            GetDataFacturas()
            'tcMain.TabPages.Remove(tcMain.TabPages.Item(6))
        End If

    End Sub
    Private Sub GetDataCotizaciones()
        _tableInvoiceHeaderQuotation = objFinance.GetQuotation_TransactionHeader_Select(Data_Id_Company, Data_BusinessDay)
        DGW_CotizacionLista.AutoGenerateColumns = False
        DGW_CotizacionLista.Font = New Font("Segoe UI", 11)
        DGW_CotizacionLista.Columns(0).Width = 90
        DGW_CotizacionLista.Columns(1).Width = 100
        DGW_CotizacionLista.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DGW_CotizacionLista.Columns(2).Width = 280
        DGW_CotizacionLista.Columns(3).Width = 100
        DGW_CotizacionLista.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DGW_CotizacionLista.Columns(3).DefaultCellStyle.Format = "c"

        DGW_CotizacionLista.Columns(4).Width = 100
        DGW_CotizacionLista.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DGW_CotizacionLista.Columns(5).Width = 130
        DGW_CotizacionLista.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        DGW_CotizacionLista.Columns(6).Width = 130
        DGW_CotizacionLista.Columns(7).Width = 180
        DGW_CotizacionLista.ReadOnly = True
        DGW_CotizacionLista.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DGW_CotizacionLista.MultiSelect = False
        REM DGW_CotizacionLista.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
        DGW_CotizacionLista.AllowUserToResizeColumns = False
        DGW_CotizacionLista.AllowUserToAddRows = False
        DGW_CotizacionLista.AllowUserToDeleteRows = False
        DGW_CotizacionLista.DataSource = _tableInvoiceHeaderQuotation
    End Sub

    Private Sub GetDataCompras()
        _tableInvoiceHeader = objFinance.GetInvoice_PurchasesHeader_Select(Data_Id_Company, Data_BusinessDay)
        DGW_ComprasLista.AutoGenerateColumns = False
        DGW_ComprasLista.Font = New Font("Segoe UI", 11)
        DGW_ComprasLista.Columns(0).Width = 35
        DGW_ComprasLista.Columns(1).Width = 90
        DGW_ComprasLista.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        DGW_ComprasLista.Columns(2).Width = 100
        DGW_ComprasLista.Columns(3).Width = 280
        DGW_ComprasLista.Columns(4).Width = 100
        DGW_ComprasLista.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DGW_ComprasLista.Columns(4).DefaultCellStyle.Format = "c"

        DGW_ComprasLista.Columns(5).Width = 100
        DGW_ComprasLista.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DGW_ComprasLista.Columns(5).Width = 130
        DGW_ComprasLista.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        DGW_ComprasLista.Columns(6).Width = 130
        DGW_ComprasLista.Columns(7).Width = 130
        DGW_ComprasLista.Columns(8).Width = 180

        DGW_ComprasLista.ReadOnly = True
        DGW_ComprasLista.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DGW_ComprasLista.MultiSelect = False
        DGW_ComprasLista.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
        DGW_ComprasLista.AllowUserToResizeColumns = False
        DGW_ComprasLista.AllowUserToAddRows = False
        DGW_ComprasLista.AllowUserToDeleteRows = False
        DGW_ComprasLista.DataSource = _tableInvoiceHeader
        EstadosGrid_Compra()
    End Sub
    Private Sub cmd_ConfigFactura_Preview_Click(sender As Object, e As EventArgs) Handles cmd_ConfigFactura_Preview.Click
        Panel_ConfiguracionFacturaTrabajo.Controls.Clear()
        PPC_ConfigFactura = New PrintPreviewControl
        PPC_ConfigFactura.Dock = DockStyle.Fill
        Panel_ConfiguracionFacturaTrabajo.Controls.Add(PPC_ConfigFactura)
        _tableConfigBilling = objFinance.GetConfigBilling_Select(Data_Id_Company, 2)
        Dim ds As New DataSet

        Dim xmlDatos As System.IO.StringReader = New System.IO.StringReader(_tableConfigBilling.Rows(0)("Config_XML"))
        Dim xmlSchema As System.IO.StringReader = New System.IO.StringReader(_tableConfigBilling.Rows(0)("Schema_XML"))

        ds.ReadXmlSchema(xmlSchema)
        ds.ReadXml(xmlDatos)

        'CREDITO FISCAL
        'CONSUMIDOR FINAL
        Dim imagen As New PictureBox

        Dim imageData As Byte() = DirectCast(_tableConfigBilling.Rows(0)("picture"), Byte())
        If Not imageData Is Nothing Then
            Using ms As New MemoryStream(imageData, 0, imageData.Length)
                ms.Write(imageData, 0, imageData.Length)
                imagen.Image = Image.FromStream(ms, True)
            End Using
        End If

        Dim obj As New Config_Factua("CONSUMIDOR FINAL", ds, imagen)
        obj.FacEncabezado(1234, "Nombre Cliente o Razon Social", "12343-3", "0000-000000-0-000", Now, "La Direccion", "SOFTWARE",
                          "Sucursal", "Vendedor", "FormaPago", "12345", "San Salvador")
        For i As Integer = 1 To 6
            If True Then
                obj.facDetalle("12", 3, "GAL", "La fecturacion realiza muchos lineas dependera del producto que el usuaio ingrese en los productos", 12.12, 0, 0, 212, False)
            Else
                obj.facDetalle("12", 3, "GAL", "Producto # " & i.ToString, 12.12, 0, 0, 212, False)

            End If
        Next
        obj.FacResumen(10, 10, 10, 10, 10, 10, 10, 999999.99, 1)
        obj.Preview(PPC_ConfigFactura)

    End Sub

    Private Sub cmd_ConfigCF_ZoomMAS_Click(sender As Object, e As EventArgs) Handles cmd_ConfigCF_ZoomMAS.Click
        For Each obj As Object In Panel_ConfiguracionFacturaTrabajo.Controls
            If TypeOf obj Is ConfiguraFacturaDisplayControls Then
                obj.Zoom(0.1)
            Else
                PPC_ConfigFactura.Zoom += 0.1
            End If

        Next

    End Sub

    Private Sub cmd_ConfigCF_ZoomMenos_Click(sender As Object, e As EventArgs) Handles cmd_ConfigCF_ZoomMenos.Click
        For Each obj As Object In Panel_ConfiguracionFacturaTrabajo.Controls
            If TypeOf obj Is ConfiguraFacturaDisplayControls Then
                obj.Zoom(-0.1)
            Else
                PPC_ConfigFactura.Zoom -= 0.1
            End If

        Next
    End Sub

    Private Sub cmd_ConfigCF_Preview_Click(sender As Object, e As EventArgs) Handles cmd_ConfigCF_Preview.Click
        Panel_ConfiguracionFacturaTrabajo.Controls.Clear()
        PPC_ConfigFactura = New PrintPreviewControl
        PPC_ConfigFactura.Dock = DockStyle.Fill
        Panel_ConfiguracionFacturaTrabajo.Controls.Add(PPC_ConfigFactura)

        _tableConfigBilling = objFinance.GetConfigBilling_Select(Data_Id_Company, 1)
        Dim ds As New DataSet

        Dim xmlDatos As System.IO.StringReader = New System.IO.StringReader(_tableConfigBilling.Rows(0)("Config_XML"))
        Dim xmlSchema As System.IO.StringReader = New System.IO.StringReader(_tableConfigBilling.Rows(0)("Schema_XML"))

        ds.ReadXmlSchema(xmlSchema)
        ds.ReadXml(xmlDatos)

        'CREDITO FISCAL
        'CONSUMIDOR FINAL
        Dim imagen As New PictureBox

        Dim imageData As Byte() = DirectCast(_tableConfigBilling.Rows(0)("picture"), Byte())
        If Not imageData Is Nothing Then
            Using ms As New MemoryStream(imageData, 0, imageData.Length)
                ms.Write(imageData, 0, imageData.Length)
                imagen.Image = Image.FromStream(ms, True)
            End Using
        End If
        Dim obj As New Config_Factua("CREDITO FISCAL", ds, imagen)
        obj.FacEncabezado(1234, "Nombre Cliente o Razon Social", "12343-3", "0000-000000-0-000", Now, "La Direccion", "SOFTWARE",
                          "Sucursal", "Vendedor", "FormaPago", "12345", "San Salvador")
        For i As Integer = 1 To 6
            If True Then
                obj.facDetalle("12", 3, "GAL", "La fecturacion realiza muchos lineas dependera del producto que el usuaio ingrese en los productos", 12.12, 0, 0, 212, False)
            Else
                obj.facDetalle("12", 3, "GAL", "Producto # " & i.ToString, 12.12, 0, 0, 212, False)

            End If
        Next
        obj.FacResumen(10, 10, 10, 10, 10, 10, 10, 999999.99, 1)
        obj.Preview(PPC_ConfigFactura)
    End Sub

    Private Sub cmd_ConfigFactura_Config_Click(sender As Object, e As EventArgs) Handles cmd_ConfigFactura_Config.Click
        Panel_ConfiguracionFacturaTrabajo.Controls.Clear()
        _tableConfigBilling = objFinance.GetConfigBilling_Select(Data_Id_Company, 2)
        Dim ds As New DataSet

        Dim xmlDatos As System.IO.StringReader = New System.IO.StringReader(_tableConfigBilling.Rows(0)("Config_XML"))
        Dim xmlSchema As System.IO.StringReader = New System.IO.StringReader(_tableConfigBilling.Rows(0)("Schema_XML"))
        Dim picFac As New PictureBox

        Dim imageData As Byte() = DirectCast(_tableConfigBilling.Rows(0)("picture"), Byte())
        If Not imageData Is Nothing Then
            Using ms As New MemoryStream(imageData, 0, imageData.Length)
                ms.Write(imageData, 0, imageData.Length)
                picFac.Image = Image.FromStream(ms, True)
            End Using
        End If
        ds.ReadXmlSchema(xmlSchema)
        ds.ReadXml(xmlDatos)
        Dim obj As New ConfiguraFacturaDisplayControls(False, ds, picFac, _tableConfigBilling.Rows(0)("ID_Billing"), _tableConfigBilling.Rows(0)("ID_Type_Billing_FK"))
        obj.Dock = DockStyle.Fill
        Panel_ConfiguracionFacturaTrabajo.Controls.Add(obj)
    End Sub

    Private Sub cmd_ConfigCF_Config_Click(sender As Object, e As EventArgs) Handles cmd_ConfigCF_Config.Click
        Panel_ConfiguracionFacturaTrabajo.Controls.Clear()
        _tableConfigBilling = objFinance.GetConfigBilling_Select(Data_Id_Company, 1)
        Dim ds As New DataSet

        Dim xmlDatos As System.IO.StringReader = New System.IO.StringReader(_tableConfigBilling.Rows(0)("Config_XML"))
        Dim xmlSchema As System.IO.StringReader = New System.IO.StringReader(_tableConfigBilling.Rows(0)("Schema_XML"))
        Dim picFac As New PictureBox

        Dim imageData As Byte() = DirectCast(_tableConfigBilling.Rows(0)("picture"), Byte())
        If Not imageData Is Nothing Then
            Using ms As New MemoryStream(imageData, 0, imageData.Length)
                ms.Write(imageData, 0, imageData.Length)
                picFac.Image = Image.FromStream(ms, True)
            End Using
        End If
        ds.ReadXmlSchema(xmlSchema)
        ds.ReadXml(xmlDatos)
        Dim obj As New ConfiguraFacturaDisplayControls(True, ds, picFac, _tableConfigBilling.Rows(0)("ID_Billing"), _tableConfigBilling.Rows(0)("ID_Type_Billing_FK"))
        obj.Dock = DockStyle.Fill
        Panel_ConfiguracionFacturaTrabajo.Controls.Add(obj)
    End Sub

    Private Sub cmdCreateFactura_Click(sender As Object, e As EventArgs) Handles cmdCreateFactura.Click
        ' Llama factura
        Using obj As New Generic_SeleccionarCliente
            obj.StartPosition = FormStartPosition.CenterParent
            If obj.ShowDialog() = DialogResult.OK Then
                Using objFac As New Financiero_DocumentoFiscal("CONSUMIDOR FINAL")
                    objFac.objCustomerRow = obj.rowSelection
                    If objFac.ShowDialog() = DialogResult.OK Then
                        GetDataFacturas()
                    End If
                End Using
            End If
        End Using
    End Sub

    Private Sub cmdCreateCF_Click(sender As Object, e As EventArgs) Handles cmdCreateCF.Click
        Using obj As New Generic_SeleccionarCliente
            obj.StartPosition = FormStartPosition.CenterParent
            If obj.ShowDialog() = DialogResult.OK Then
                Using objFac As New Financiero_DocumentoFiscal("CREDITO FISCAL")
                    objFac.objCustomerRow = obj.rowSelection
                    If objFac.ShowDialog() = DialogResult.OK Then
                        GetDataFacturas()
                    End If
                End Using
            End If
        End Using
    End Sub

    Private Sub cmdLineaCredito_Click(sender As Object, e As EventArgs) Handles cmdLineaCredito.Click
        Using objLinea As New ERP_CreditLine
            objLinea.Id_Customer = DGVClientes.CurrentRow.Cells(0).Value
            objLinea.Cliente = DGVClientes.CurrentRow.Cells(3).Value
            objLinea.DUI = ""
            objLinea.Telefono = DGVClientes.CurrentRow.Cells(5).Value
            objLinea.Email = DGVClientes.CurrentRow.Cells(6).Value
            objLinea.ShowDialog()
        End Using
    End Sub

    Private Sub cmdReporteCatalogoCliente_Click(sender As Object, e As EventArgs) Handles cmdReporteCatalogoCliente.Click
        Dim Ds As New EPD_SatelliteERPDataSet_Inventario
        Dim dt As New EPD_SatelliteERPDataSet_InventarioTableAdapters.ERP_SP_Inventory_Report_CatalogCustomersTableAdapter
        Dim dt1 As DataTable
        dt.Fill(Ds.ERP_SP_Inventory_Report_CatalogCustomers)
        dt1 = Ds.Tables(0)
        Using objPartidaContable As New Financiero_ReportViewer(dt1, "CatalogoClientes", "epd_SatelliteERP.Inventario_CatalogClientes.rdlc")
            objPartidaContable.ShowDialog()
        End Using
    End Sub

    Private Sub cmdCatalogoClienteFinanciero_Click(sender As Object, e As EventArgs) Handles cmdCatalogoClienteFinanciero.Click
        Dim dt As New DataTable
        Using objsql As New Financiero_SQLServer
            dt = objsql.ERP_SP_Inventory_Report_CatalogueFinancialCustomers
        End Using
        Using objPartidaContable As New Financiero_ReportViewer(dt, "Data", "epd_SatelliteERP.Reporte_CatalogoFinanciero.rdlc")
            objPartidaContable.ShowDialog()
        End Using
    End Sub

    Private Sub cmdFichaCliente_Click(sender As Object, e As EventArgs) Handles cmdFichaCliente.Click
        Dim Ds As New EPD_SatelliteERPDataSet_Inventario
        Dim dt As New EPD_SatelliteERPDataSet_InventarioTableAdapters.ERP_SP_Inventory_Report_Report_CustomerCardTableAdapter
        Dim dt1 As DataTable
        dt.Fill(Ds.ERP_SP_Inventory_Report_Report_CustomerCard)
        dt1 = Ds.Tables("ERP_SP_Inventory_Report_Report_CustomerCard")
        Using objPartidaContable As New Financiero_ReportViewer(dt1, "DatosCliente", "epd_SatelliteERP.Inventario_CatalogClienteCard.rdlc")
            objPartidaContable.ShowDialog()
        End Using
    End Sub

    Private Sub cmdCrearCliente_Click(sender As Object, e As EventArgs) Handles cmdCrearCliente.Click
        Using Objcreate As New ERP_ClientesCuentasPorCobrar
            Objcreate.TipoConsulta = ERP_ClientesCuentasPorCobrar.Proceso.Clientes
            Objcreate.OpcionSeleccionada = ERP_ClientesCuentasPorCobrar.Funcion.Agregar
            If Objcreate.ShowDialog() = DialogResult.OK Then
                GetClientes()
            End If
        End Using
    End Sub

    Private Sub cmdModificarCliente_Click(sender As Object, e As EventArgs) Handles cmdModificarCliente.Click
        Using ObjUpdate As New ERP_ClientesCuentasPorCobrar
            ObjUpdate.TipoConsulta = ERP_ClientesCuentasPorCobrar.Proceso.Clientes
            ObjUpdate.OpcionSeleccionada = ERP_ClientesCuentasPorCobrar.Funcion.Actualizar
            For Each row As DataRow In _tableCustomer.Select("Id_Customer=" & DGVClientes.CurrentRow.Cells(0).Value)
                ObjUpdate.IsBigContributter = row("Is_BigContributor")
                ObjUpdate.Id_Customer = row("Id_Customer")
                ObjUpdate.id_Company = row("id_Company_FK")
                ObjUpdate.Id_TypeCustomer_FK = row("Id_TypeCustomer_FK")
                ObjUpdate.Id_Minicipality_FK = row("Id_Minicipality_FK")
                ObjUpdate.Id_EmployeelContact_FK = row("Id_EmployeelContact_FK")
                ObjUpdate.Id_CompanyCategory_Fk = row("Id_CompanyCategory_Fk")
                ObjUpdate.Is_Exempt = row("Is_Exempt")
                ObjUpdate.Is_LegalEntity = row("Is_LegalEntity")
                ObjUpdate.Business_Name = row("Business_Name")
                ObjUpdate.Commercial_Name = row("Commercial_Name")
                ObjUpdate.First_Name = row("First_Name")
                ObjUpdate.Last_Name = row("Last_Name")
                ObjUpdate.Address = row("Address")
                ObjUpdate.OfficePhone = row("OfficePhone")
                ObjUpdate.Email_Contact = row("Email_Contact")
                ObjUpdate.Identity_DocumentNumber = row("Identity_DocumentNumber")
                ObjUpdate.Tax_Registration_Number = row("Tax_Registration_Number")
                ObjUpdate.Tax_Identification_Number = row("Tax_Identification_Number")
                ObjUpdate.Turning_Company = row("Turning_Company")
                ObjUpdate.Company_Category = row("Company_Category")
                ObjUpdate.Is_Supplier = row("Is_supplier")
            Next
            If ObjUpdate.ShowDialog() = DialogResult.OK Then
                GetClientes()
            End If
        End Using
    End Sub

    Private Sub cmdAgregarCobro_Click(sender As Object, e As EventArgs)
        Using objCobro As New ERP_CuentasPorCobrar_AgregarCxC(DGVClientes.CurrentRow.Cells(0).Value)
            objCobro.Id_Customer = DGVClientes.CurrentRow.Cells(0).Value
            Try
                objCobro.ShowDialog()
            Catch ex As Exception

            End Try

        End Using
    End Sub

    Private Sub cmdCuentaCxC_AgregarCobro_Click(sender As Object, e As EventArgs) Handles cmdCuentaCxC_AgregarCobro.Click
        Using objCobro As New ERP_CuentasPorCobrar_AgregarCobro
            objCobro.StartPosition = FormStartPosition.CenterParent
            objCobro.Id_Customer = DGVClientes.CurrentRow.Cells(0).Value
            objCobro.ShowDialog()
        End Using
    End Sub

    Private Sub cmdCuotaClienteMora_Click(sender As Object, e As EventArgs) Handles cmdCuotaClienteMora.Click
        Using objCobro As New ERP_CuentasPorCobrar_AgregarCobro
            For Each row As DataRow In _tableCustomerBalanceDue.Rows
                If DGV_CustomMora.CurrentRow.Cells(0).Value = row("ID_AccountsList") Then
                    objCobro.Id_Customer = row("ID_Customer")
                    Exit For
                End If
            Next
            If objCobro.ShowDialog() = DialogResult.OK Then
                GetClientesMora()
            End If
        End Using

    End Sub

    Private Sub ModuloCuentasPorCobrar_Load(sender As Object, e As EventArgs) Handles Me.Load
        If _IsFacturacion Then
            GetDataFacturas()
        Else
            flpCalendar.Controls.Clear()
            Dim obj As New calendar
            obj.OpcionCuenta = ERP_Calendar.TipoCuenta.Cuenta_Cobrar
            flpCalendar.Controls.Add(obj)
            flpCalendar.Dock = DockStyle.Fill

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Using obj As New ERP_Calendar
            obj.OpcionCuenta = ERP_Calendar.TipoCuenta.Cuenta_Cobrar
            obj.ShowDialog()
        End Using
    End Sub
    Private Sub gbStudentDetails_Enter(sender As Object, e As EventArgs) Handles gbStudentDetails.Enter
        Dim obj As New calendar
        obj.OpcionCuenta = ERP_Calendar.TipoCuenta.Cuenta_Cobrar
        flpCalendar.Controls.Add(obj)
    End Sub
    Private Sub cmdFacturacion_Re_Print_Click(sender As Object, e As EventArgs) Handles cmdFacturacion_Re_Print.Click
        If DGW_FacturasLista.CurrentRow.Cells(9).Value = False Then
            MessageBox.Show("Factura anulada, no se puede reimprimir.", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            ImprimirFacturas(False)
        End If

    End Sub
    Private Function ImprimirFacturas(ByVal IsPrinter As Boolean) As String
        Dim dt As DataTable = objFinance.GetInvoice_TransactionDetail_Select(Data_Id_Company, DGW_FacturasLista.CurrentRow.Cells(1).Value)
        Dim _TipoFactura As String = DGW_FacturasLista.CurrentRow.Cells(6).Value.ToString.ToUpper
        Using objFinance As New Financiero_SQLServer
            'TODO:Se tiene que configurar para procesar otros documentos.
            Dim ID_Type_Billing As Integer = 1
            If _TipoFactura = "CONSUMIDOR FINAL" Then
                ID_Type_Billing = 2
            End If
            Dim _tableConfigBilling As DataTable = objFinance.GetConfigBilling_Select(Data_Id_Company, ID_Type_Billing)
            Dim ds As New DataSet

            Dim xmlDatos As System.IO.StringReader = New System.IO.StringReader(_tableConfigBilling.Rows(0)("Config_XML"))
            Dim xmlSchema As System.IO.StringReader = New System.IO.StringReader(_tableConfigBilling.Rows(0)("Schema_XML"))
            ds.ReadXmlSchema(xmlSchema)
            ds.ReadXml(xmlDatos)
            'CREDITO FISCAL
            'CONSUMIDOR FINAL
            Dim imagen As New PictureBox

            Dim imageData As Byte() = DirectCast(_tableConfigBilling.Rows(0)("picture"), Byte())
            If Not imageData Is Nothing Then
                Using ms As New MemoryStream(imageData, 0, imageData.Length)
                    ms.Write(imageData, 0, imageData.Length)
                    imagen.Image = Image.FromStream(ms, True)
                End Using
            End If
            Dim obj As New Config_Factua(_TipoFactura, ds, imagen)
            Dim NombreComercial As String = dt.Rows(0)("Commercial_Name")
            If NombreComercial = "" Then
                NombreComercial = DGW_FacturasLista.CurrentRow.Cells(3).Value.ToString
            End If


            obj.FacEncabezado(dt.Rows(0)("ID_Customer_FK"), NombreComercial, dt.Rows(0)("Tax_Registration_Number"), dt.Rows(0)("Tax_Identification_Number"), dt.Rows(0)("BusinessDay"), dt.Rows(0)("Address"), dt.Rows(0)("Turning_Company"),
                              "Sucursal", "Vendedor", dt.Rows(0)("PurchaseType"), "", dt.Rows(0)("Name_Department"))
            For Each row As DataRow In dt.Rows
                obj.facDetalle(0, row("Quantity"),
                                      "Unidad",
                                      row("Description"),
                                      row("PriceWithoutIva"), 0,
                                      row("PriceWithIVA"),
                                      row("TotalAmount"), False)
            Next
            Dim subTotal As Decimal = CDec(dt.Rows(0)("Fullpayment"))
            obj.FacResumen(0, subTotal, dt.Rows(0)("IVA_Paid"), (CDec(dt.Rows(0)("Fullpayment")) - CDec(dt.Rows(0)("IVA_Paid"))), 0, 0, 0, CDec(dt.Rows(0)("Fullpayment")), 0)
            If IsPrinter Then
                obj.Imprimir()
            Else
                Using objPreview As New Financiero_PreviewDocFiscal
                    objPreview.objFactura = obj
                    objPreview.ShowDialog()
                End Using
            End If
        End Using
        Return "OK"
        'TODO: Validar esta parte que se garantice que devuelve OK si se imprimio la factura de una forma adecuada.
    End Function
    Private Sub cmdCotizacionCF_Crear_Click(sender As Object, e As EventArgs) Handles cmdCotizacionCF_Crear.Click
        Using obj As New Generic_SeleccionarCliente
            obj.StartPosition = FormStartPosition.CenterParent
            If obj.ShowDialog() = DialogResult.OK Then
                Using objFac As New Financiero_DocumentoFiscal("CREDITO FISCAL", True)
                    objFac.objCustomerRow = obj.rowSelection
                    If objFac.ShowDialog() = DialogResult.OK Then
                        GetDataCotizaciones()
                    End If
                End Using
            End If
        End Using
    End Sub
    Private Sub cmdCotizacionFactura_Crear_Click(sender As Object, e As EventArgs) Handles cmdCotizacionFactura_Crear.Click
        Using obj As New Generic_SeleccionarCliente
            obj.StartPosition = FormStartPosition.CenterParent
            If obj.ShowDialog() = DialogResult.OK Then
                Using objFac As New Financiero_DocumentoFiscal("CONSUMIDOR FINAL", True)
                    objFac.objCustomerRow = obj.rowSelection
                    If objFac.ShowDialog() = DialogResult.OK Then
                        GetDataCotizaciones()
                    End If
                End Using
            End If
        End Using
    End Sub
    Private Sub cmdCotizacionCF_ReImpresion_Click(sender As Object, e As EventArgs) Handles cmdCotizacionCF_ReImpresion.Click
        REM Cotizacion o Preventa
        Try
            Dim ID_CotizacionIngresada As Long = DGW_CotizacionLista.CurrentRow.Cells(0).Value
            Using objPartidaContable As New Financiero_ReportViewer("ERP_SP_Invoice_Quotation_TransactionDetail_SelectTableAdapter")
                objPartidaContable.Id_AccountingIitemHeading = ID_CotizacionIngresada
                objPartidaContable.ShowDialog()
            End Using
        Catch ex As Exception
            ' Nada no hace ninguna accion
        End Try
    End Sub
    Private Sub cmdCotizacionFactura_Modificar_Click(sender As Object, e As EventArgs) Handles cmdCotizacionFactura_Modificar.Click
        Try
            Dim ID_CotizacionIngresada As Long = DGW_CotizacionLista.CurrentRow.Cells(0).Value
            For Each row As DataRow In _tableInvoiceHeaderQuotation.Select("ID_TransactionHeader=" & ID_CotizacionIngresada.ToString)
                Dim dtTempCliente As DataTable = objGeneric.GetCustomerMaster(Data_Id_Company, DGW_CotizacionLista.CurrentRow.Cells(2).Value)
                For Each row1 As DataRow In dtTempCliente.Rows
                    Dim TipoDocumento As String = DGW_CotizacionLista.CurrentRow.Cells(5).Value
                    Using objModificacion As New Financiero_DocumentoFiscal(TipoDocumento.ToUpper(), True)
                        objModificacion.Is_Modificacion = True
                        objModificacion.IS_Update = True
                        objModificacion.ID_CotizacionHeader = ID_CotizacionIngresada.ToString
                        Dim Ds As New EPD_SatelliteERPDataSet
                        Dim dt As New EPD_SatelliteERPDataSetTableAdapters.ERP_SP_Invoice_Quotation_TransactionDetail_SelectTableAdapter
                        dt.Fill(Ds.ERP_SP_Invoice_Quotation_TransactionDetail_Select, ID_CotizacionIngresada, Data_Id_Company) ' este 
                        objModificacion.objDetalleFacturaRow = Ds.ERP_SP_Invoice_Quotation_TransactionDetail_Select
                        objModificacion.objCustomerRow = row1
                        If objModificacion.ShowDialog() = DialogResult.OK Then
                            GetDataCotizaciones()
                        End If
                    End Using
                Next row1
            Next
        Catch ex As Exception
            ' Nada no hace ninguna accion
        End Try
    End Sub
    Private Sub cmdFacturacion_Anulacion_Click(sender As Object, e As EventArgs) Handles cmdFacturacion_Anulacion.Click
        Dim ID_Factura As Long = DGW_FacturasLista.CurrentRow.Cells(1).Value
        Dim StatusTransaction As Boolean = DGW_FacturasLista.CurrentRow.Cells("StatusTransaction").Value
        Dim BusinessDayFactura As Date = DGW_FacturasLista.CurrentRow.Cells("BusinessDay").Value
        Dim dt As DataTable
        If StatusTransaction Then
            If BusinessDayFactura.ToString("yyyyMM") = Now.ToString("yyyyMM") Then
                Using objObservacion As New Generico_DesicionObservacion
                    If objObservacion.ShowDialog() = DialogResult.OK Then
                        If objFinance.SetInvoice_TransactionVoid(ID_Factura, Data_Id_Company, objObservacion.Observacion) = "OK" Then
                            dt = objFinance.ERP_SP_Get_Invoice_TransactionDetail(ID_Factura)
                            For Each row As DataRow In dt.Rows
                                objFinance.ERP_SP_Inventory_RecoverProducts(Long.Parse(row("ID_TransactionHeader_FK")), Long.Parse(row("ID_TransactionDetail")))
                            Next
                            GetDataFacturas()
                        End If
                    End If
                End Using
            Else
                MessageBox.Show("No puede anular facturas de otros meses", "SatelliteERP", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If


        Else
            MessageBox.Show("No puede anular nuevamente una factura", "SatelliteERP", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub
    Private Sub DGW_FacturasLista_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGW_FacturasLista.ColumnHeaderMouseClick
        EstadosGrid_Factura()
    End Sub
    Private Sub cmdCotizacion_ConvertirFactura_Click(sender As Object, e As EventArgs) Handles cmdCotizacion_ConvertirFactura.Click
        Try
            Dim ID_CotizacionIngresada As Long = DGW_CotizacionLista.CurrentRow.Cells(0).Value
            For Each row As DataRow In _tableInvoiceHeaderQuotation.Select("ID_TransactionHeader=" & ID_CotizacionIngresada.ToString)
                Dim dtTempCliente As DataTable = objGeneric.GetCustomerMaster(Data_Id_Company, DGW_CotizacionLista.CurrentRow.Cells(2).Value)
                For Each row1 As DataRow In dtTempCliente.Rows
                    Dim TipoDocumento As String = DGW_CotizacionLista.CurrentRow.Cells(5).Value
                    Using objModificacion As New Financiero_DocumentoFiscal(TipoDocumento.ToUpper(), False)
                        objModificacion.Is_Modificacion = True
                        objModificacion.Is_Cotizacion = True
                        Dim Ds As New EPD_SatelliteERPDataSet
                        Dim dt As New EPD_SatelliteERPDataSetTableAdapters.ERP_SP_Invoice_Quotation_TransactionDetail_SelectTableAdapter
                        dt.Fill(Ds.ERP_SP_Invoice_Quotation_TransactionDetail_Select, ID_CotizacionIngresada, Data_Id_Company) ' este 
                        objModificacion.objDetalleFacturaRow = Ds.ERP_SP_Invoice_Quotation_TransactionDetail_Select
                        objModificacion.objCustomerRow = row1
                        objModificacion.No_Cotizacion = ID_CotizacionIngresada
                        If objModificacion.ShowDialog() = DialogResult.OK Then
                            GetDataCotizaciones()
                        End If
                    End Using
                Next row1
            Next
        Catch ex As Exception
            ' Nada no hace ninguna accion
        End Try
    End Sub
    Private Sub cmdCotizacion_Anular_Click(sender As Object, e As EventArgs) Handles cmdCotizacion_Anular.Click
        Dim ID_Cotizacion As Long = DGW_CotizacionLista.CurrentRow.Cells(0).Value
        Using objObservacion As New Generico_DesicionObservacion
            If objObservacion.ShowDialog() = DialogResult.OK Then
                If objFinance.SetInvoice_TransactionVoid(ID_Cotizacion, Data_Id_Company, objObservacion.Observacion) = "OK" Then
                    objFinance.SetQuotation_TransactionVoid(ID_Cotizacion, Data_Id_Company, objObservacion.Observacion, 0)
                    GetDataCotizaciones()
                End If
            End If
        End Using
    End Sub

    Private Sub cmdCuentasActivas_CrearManual_Click(sender As Object, e As EventArgs) Handles cmdCuentasActivas_CrearManual.Click
        Dim ID_Cliente As Long = DGVClientes.CurrentRow.Cells(0).Value
        Dim _Dt_DatosCliente As DataTable
        Using objsql As New Generic_SQLServer
            _Dt_DatosCliente = objsql.GetCreditLine(Data_Id_Company, ID_Cliente, True, False, False) ' Tipo de busqueda 2 para ID_Customer
        End Using
        '' En este momento tomara la primera cuenta y luego hay que poner un list para mas de una cuenta activa


        Using objLista As New ERP_CuentasPorCobrar_Crea(ID_Cliente)
            objLista.NombreCliente = DGVClientes.CurrentRow.Cells(3).Value
            objLista.DT_CreditLine = _Dt_DatosCliente
            REM            objLista.DT_LineasCredito = _Dt_DatosCliente
            objLista.ShowDialog()
            REM  _Id_row = objLista.RowSeleccion
        End Using



    End Sub

    Private Sub cmdCuentasActivas_EstadoCuentaCliente_Click(sender As Object, e As EventArgs) Handles cmdCuentasActivas_EstadoCuentaCliente.Click
        If Not DGVClientes.CurrentRow Is Nothing Then
            Dim ID_Cliente As Long = DGVClientes.CurrentRow.Cells(0).Value
            Dim dt As New DataTable
            Using objSQL As New Financiero_SQLServer
                dt = objSQL.ERP_Finance_Reports_AccountStatusMonth(ID_Cliente)
            End Using
            Using objPartidaContable As New Financiero_ReportViewer(dt, "DataReport", "epd_SatelliteERP.Reporte_EstadoCuentaMonth.rdlc")
                objPartidaContable.ShowDialog()
            End Using

        End If
    End Sub

    Private Sub cmdCuentaActiva_PagoCuotaFecha_Click(sender As Object, e As EventArgs) Handles cmdCuentaActiva_PagoCuotaFecha.Click
        Using obj As New ERP_CuentasPorCobrar_CobrosProgramados
            obj.ShowDialog()
        End Using
    End Sub

    Private Sub cmdCuentaActiva_EstadoPagos_Click(sender As Object, e As EventArgs) Handles cmdCuentaActiva_EstadoPagos.Click
        If Not DGVClientes.CurrentRow Is Nothing Then
            Dim ID_Cliente As Long = DGVClientes.CurrentRow.Cells(0).Value
            Dim FechaInicial As Date = Now.Date
            Dim FechaFinal As Date = Now.Date
            Dim generar As Boolean = False
            Using objFechas As New ERP_CuentasPorCobrar_DialogFechasSelect
                If objFechas.ShowDialog = DialogResult.OK Then
                    FechaInicial = objFechas.FechaInicial
                    FechaFinal = objFechas.FechaFinal
                    generar = True
                End If
            End Using

            If generar Then
                Dim dt As New DataTable
                Using objSQL As New Financiero_SQLServer
                    dt = objSQL.ERP_Finance_Report_PartialPayments(ID_Cliente, FechaInicial, FechaFinal)
                End Using
                Using objPartidaContable As New Financiero_ReportViewer(dt, "DataReport", "epd_SatelliteERP.Reporte_PagosParciales.rdlc")
                    objPartidaContable.ShowDialog()
                End Using
            End If
        End If
    End Sub

    Private Sub cmd_CuentasActivas_AddPayment_Click(sender As Object, e As EventArgs) Handles cmd_CuentasActivas_AddPayment.Click
        If Not DGVClientes.CurrentRow Is Nothing Then
            Dim ID As Long = DGVClientes.CurrentRow.Cells("Id_Customer").Value
            Using objPago As New ERP_CuentasPorCobrar_PagosFechas
                objPago.ID_Customer = ID
                objPago.ShowDialog()
            End Using
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Using obj As New ERP_CuentasPorCobrar_CuadreEntregaVendedor
            obj.ShowDialog()
        End Using
    End Sub

    Private Sub cmdCotizaciones_OrdenProduccion_Click(sender As Object, e As EventArgs) Handles cmdCotizaciones_OrdenProduccion.Click
        Dim Fecha As Date = Nothing
        Using obj As New ERP_CuentasPorCobrar_ProductionDate
            If obj.ShowDialog = DialogResult.OK Then
                Fecha = obj.Fecha
                Dim dt As New DataTable
                Using objsql As New Financiero_SQLServer
                    dt = objsql.ERP_Prod_SP_ProductionOrder(Fecha)
                End Using

                If Not dt Is Nothing Then
                    If dt.Rows.Count > 0 Then
                        Using objPartidaContable As New Financiero_ReportViewer(dt, "DataProduction", "epd_SatelliteERP.Report_ProductionOrder.rdlc")
                            objPartidaContable.ShowDialog()
                        End Using
                    Else
                        MessageBox.Show("No existen pedidos pendientes de producción para esta fecha", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                Else
                    MessageBox.Show("No existen pedidos pendientes de producción para esta fecha", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        End Using
    End Sub

    Private Sub cmdCotizaciones_EntregaVendedor_Click(sender As Object, e As EventArgs) Handles cmdCotizaciones_EntregaVendedor.Click
        Dim Fecha As Date = Nothing
        Using obj As New ERP_CuentasPorCobrar_ProductionDate
            obj.Text = "Fecha de Cotizaciones"
            If obj.ShowDialog = DialogResult.OK Then
                Fecha = obj.Fecha
                Dim dt As New DataTable
                Using objsql As New Financiero_SQLServer
                    dt = objsql.ERP_Prod_SP_ProductionOrderDelivery(Fecha)
                End Using

                If Not dt Is Nothing Then
                    If dt.Rows.Count > 0 Then
                        Using objPartidaContable As New Financiero_ReportViewer(dt, "DataSet1", "epd_SatelliteERP.Report_EntregaVendedores.rdlc")
                            objPartidaContable.ShowDialog()
                        End Using
                    Else
                        MessageBox.Show("No existen entregas pendientes para esta fecha", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                Else
                    MessageBox.Show("No existen entregas pendientes para esta fecha", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        End Using
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim Fecha As Date = Nothing
        Using obj As New ERP_CuentasPorCobrar_ProductionDate
            If obj.ShowDialog = DialogResult.OK Then
                Fecha = obj.Fecha
                Dim dt As New DataTable
                Using objsql As New Financiero_SQLServer
                    dt = objsql.ERP_Prod_SP_ProductionOrderDeliveryReport(Fecha)
                End Using

                If Not dt Is Nothing Then
                    If dt.Rows.Count > 0 Then
                        Using objPartidaContable As New Financiero_ReportViewer(dt, "DataEntregas", "epd_SatelliteERP.Report_Entregas.rdlc")
                            objPartidaContable.ShowDialog()
                        End Using
                    Else
                        MessageBox.Show("No existen pedidos pendientes de producción para esta fecha", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                Else
                    MessageBox.Show("No existen pedidos pendientes de producción para esta fecha", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        End Using
    End Sub

    Private Sub cmdCuentasActivas_DeudasClientes_Click(sender As Object, e As EventArgs) Handles cmdCuentasActivas_DeudasClientes.Click
        If Not DGVClientes.CurrentRow Is Nothing Then
            Dim ID_Cliente As Long = DGVClientes.CurrentRow.Cells(0).Value
            Dim dt As New DataTable
            Using objSQL As New Financiero_SQLServer
                dt = objSQL.ReporteDeudaPorCliente(ID_Cliente)
            End Using
            ' dt1 = Ds.Tables("ERP_SP_Inventory_Report_AccountStatus")
            Using obj As New Financiero_ReportViewer(dt, "datos", "epd_SatelliteERP.Reporte_DeudasPorCliente.rdlc")
                obj.WindowState = FormWindowState.Maximized
                obj.ShowDialog()
            End Using

        End If
    End Sub

    Private Sub cmdCuentasActivas_DeudasVendedor_Click(sender As Object, e As EventArgs) Handles cmdCuentasActivas_DeudasVendedor.Click
        Using objVReporteVendedores As New ERP_CuentasPorCobrar_VendedorSelect
            objVReporteVendedores.ShowDialog()
        End Using
    End Sub

    Private Sub cmdCuentasActivas_CotizacionPorCliente_Click(sender As Object, e As EventArgs) Handles cmdCuentasActivas_CotizacionPorCliente.Click
        Dim ID_Cliente As Long = DGVClientes.CurrentRow.Cells(0).Value
        Using objFechas As New ERP_CuentasPorCobrar_DialogFechasSelect
            If objFechas.ShowDialog = DialogResult.OK Then
                'FechaInicial = objFechas.FechaInicial
                'FechaFinal = objFechas.FechaFinal
                Dim dt As New DataTable
                Using objsql As New Financiero_SQLServer
                    dt = objsql.ERP_SP_Invoice_Quotation_Transaction_Report(Data_Id_Company, ID_Cliente, objFechas.FechaInicial.ToString("yyyy/MM/dd"), objFechas.FechaFinal.ToString("yyyy/MM/dd"))
                End Using

                Using objPartidaContable As New Financiero_ReportViewer(dt, "datos", "epd_SatelliteERP.Reports_Customer_Quotation.rdlc")
                    objPartidaContable.ShowDialog()
                End Using

            End If
        End Using
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Using obj As New ReporteVentas
            obj.ShowDialog()
        End Using
    End Sub

    Private Sub cmdPagos_Click(sender As Object, e As EventArgs) Handles cmdPagos.Click
        Dim ID_Cliente As Long = DGVClientes.CurrentRow.Cells(0).Value
        Using obj As New ERP_CuentasPorCobrar_PagosMensuales
            obj.ID_Customer = ID_Cliente
            obj.ShowDialog()
        End Using
    End Sub

    Private Sub cmdIndicador_Click(sender As Object, e As EventArgs) Handles cmdIndicador.Click
        If Not DGVClientes.CurrentRow Is Nothing Then
            Using obj As New ERP_Inventory_StatusProduct
                obj.TipoProceso = ERP_Inventory_StatusProduct.Process.CuentasPorCobrar
                obj.ShowDialog()
            End Using
        End If
    End Sub

    Private Sub cmdMontosVencidos_Click(sender As Object, e As EventArgs) Handles cmdMontosVencidos.Click
        If Not DGVClientes.CurrentRow Is Nothing Then
            Using obj As New ERP_Inventory_StatusProduct
                obj.TipoProceso = ERP_Inventory_StatusProduct.Process.vencidas
                obj.ShowDialog()
            End Using
        End If
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles cmdCxCMora_Autorizaciones.Click
        Using obj As New Generic_RequestPending
            obj.ShowDialog()
        End Using
    End Sub

    Private Sub Button10_Click_1(sender As Object, e As EventArgs) Handles Button10.Click
        Using obj As New Financiero_ReportViewer(New DataTable, "datos", "epd_SatelliteERP.Reports_ProductionFlow.rdlc", True)
            obj.ShowDialog()
        End Using
    End Sub

    Public Sub LoadData()
        Dim ds As New DataSet
        Using objsql As New Financiero_SQLServer
            ds = objsql.ERP_Finance_Report_SalesHistory
        End Using
        If Not ds Is Nothing Then
            If ds.Tables.Count = 3 Then
                GenerateKPIHoras(ds.Tables(2))
                GenerateKPIMes(ds.Tables(1))
                GenerateKPIAnio(ds.Tables(0))
            End If
        End If
    End Sub

    Private Sub GenerateKPIHoras(ByVal Info As DataTable)
        Try
            lblHoras.Text = "Ventas por hora del dia actual: " + Info.Rows(0).Item("Dia")
            chartHoras.Series(0)("PieLabelStyle") = "Inside"
            chartHoras.Series(0).Font = New System.Drawing.Font("Tahoma", 9.0F, System.Drawing.FontStyle.Regular)

            Dim CArea As ChartArea = chartHoras.ChartAreas(0)
            CArea.AxisX.MajorGrid.Enabled = False
            CArea.AxisX.LabelStyle.Font = New System.Drawing.Font("Times New Roman", 8.0F, System.Drawing.FontStyle.Italic)
            CArea.AxisY.MajorGrid.Enabled = False
            'CArea.AxisX.LabelStyle.Angle = -90
            CArea.AxisX.Interval = 1
            chartHoras.ChartAreas(0).AxisY.LabelStyle.Format = ("C")
            chartHoras.Series(0).BorderWidth = 1
            chartHoras.Series(0).BorderColor = System.Drawing.Color.FromArgb(26, 59, 105)
            chartHoras.Series(0).Color = Color.LightGreen
            chartHoras.Legends(0).Enabled = True
            chartHoras.Legends(0).Docking = Docking.Right
            chartHoras.Legends(0).Alignment = System.Drawing.StringAlignment.Center
            chartHoras.Series(0).Label = "#VALY" '"#VALY (#PERCENT{P0})"
            chartHoras.Series(0).LegendText = "Horas"
            '	chartHoras.ChartAreas(0).Area3DStyle.Enable3D = True
            Dim series1 As Series = chartHoras.Series(0)
            chartHoras.DataSource = Info
            series1.Name = "Ventas Horas"
            chartHoras.Series(series1.Name).XValueMember = "Hora"
            chartHoras.Series(series1.Name).YValueMembers = "Monto"
        Catch ex As Exception

        End Try
    End Sub

    Private Sub GenerateKPIMes(ByVal Info As DataTable)
        Try
            lblMes.Text = "Ventas diarias del mes de : " + Info.Rows(0).Item("Mes")
            ChartMes.Series(0)("PieLabelStyle") = "Inside"
            ChartMes.Series(0).Font = New System.Drawing.Font("Tahoma", 9.0F, System.Drawing.FontStyle.Regular)
            ChartMes.Series(0).BorderWidth = 1

            Dim CArea As ChartArea = ChartMes.ChartAreas(0)
            CArea.AxisX.MajorGrid.Enabled = False
            'CArea.AxisX.LabelStyle.Font = New System.Drawing.Font("Times New Roman", 8.0F, System.Drawing.FontStyle.Italic)
            CArea.AxisY.MajorGrid.Enabled = False
            'CArea.AxisX.LabelStyle.Angle = -90
            'CArea.AxisX.Interval = 1
            ChartMes.Series(0).BorderColor = System.Drawing.Color.FromArgb(26, 59, 105)
            ChartMes.Legends(0).Enabled = True
            ChartMes.Legends(0).Docking = Docking.Right
            ChartMes.Legends(0).Alignment = System.Drawing.StringAlignment.Center
            ChartMes.ChartAreas(0).AxisY.LabelStyle.Format = ("C")
            ChartMes.Series(0).Label = "#VALY"
            ChartMes.Series(0).LegendText = "Dias"
            '	ChartMes.ChartAreas(0).Area3DStyle.Enable3D = True
            Dim series1 As Series = ChartMes.Series(0)
            ChartMes.DataSource = Info
            series1.Name = "Ventas Dias"
            ChartMes.Series(series1.Name).XValueMember = "Dia"
            ChartMes.Series(series1.Name).YValueMembers = "Monto"
        Catch ex As Exception

        End Try

    End Sub

    Private Sub GenerateKPIAnio(ByVal Info As DataTable)
        Try
            lblAnio.Text = "Ventas mensuales del año: " + Info.Rows(0).Item("Anio")
            ChartAnio.Series(0)("PieLabelStyle") = "Inside"
            ChartAnio.Series(0).Font = New System.Drawing.Font("Tahoma", 9.0F, System.Drawing.FontStyle.Regular)
            ChartAnio.Series(0).BorderWidth = 1
            Dim CArea As ChartArea = ChartAnio.ChartAreas(0)
            CArea.AxisX.MajorGrid.Enabled = False
            CArea.AxisX.LabelStyle.Font = New System.Drawing.Font("Times New Roman", 8.0F, System.Drawing.FontStyle.Italic)
            CArea.AxisY.MajorGrid.Enabled = False
            CArea.AxisX.LabelStyle.Angle = -90
            CArea.AxisX.Interval = 1
            ChartAnio.Series(0).BorderColor = System.Drawing.Color.FromArgb(26, 59, 105)
            ChartAnio.Legends(0).Enabled = True
            ChartAnio.Legends(0).Docking = Docking.Right
            ChartAnio.Legends(0).Alignment = System.Drawing.StringAlignment.Center
            ChartAnio.ChartAreas(0).AxisY.LabelStyle.Format = ("C")
            ChartAnio.Series(0).Label = "#VALY"
            ChartAnio.Series(0).Label = "#VALY"
            ChartAnio.Series(0).LegendText = "Meses"
            'ChartAnio.ChartAreas(0).Area3DStyle.Enable3D = True
            Dim series1 As Series = ChartAnio.Series(0)
            ChartAnio.DataSource = Info
            series1.Name = "Ventas Año"
            ChartAnio.Series(series1.Name).XValueMember = "Mes"
            ChartAnio.Series(series1.Name).YValueMembers = "Monto"
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnLogEntriesExitsActualMonth_Click(sender As Object, e As EventArgs) Handles btnLogEntriesExitsActualMonth.Click
        Dim Ds As New EPD_SatelliteERPFinanceLog
        Dim dt As New EPD_SatelliteERPFinanceLogTableAdapters.ERP_Finance_Report_LogEntriesAndExitsTableAdapter
        Dim dt1 As DataTable
        dt.Fill(Ds.ERP_Finance_Report_LogEntriesAndExits, 0, 0, 1)
        dt1 = Ds.Tables(0)
        Using objPartidaContable As New Financiero_ReportViewer(dt1, "DsLogEntriesAndExits", "epd_SatelliteERP.Finance_Report_LogEntriesAndExitsActualMonth.rdlc")
            objPartidaContable.ShowDialog()
        End Using
    End Sub

    Private Sub btnLogEntriesExitsActualYear_Click(sender As Object, e As EventArgs) Handles btnLogEntriesExitsActualYear.Click
        Dim Ds As New EPD_SatelliteERPFinanceLog
        Dim dt As New EPD_SatelliteERPFinanceLogTableAdapters.ERP_Finance_Report_LogEntriesAndExitsTableAdapter
        Dim dt1 As DataTable
        dt.Fill(Ds.ERP_Finance_Report_LogEntriesAndExits, Now.Year, 0, 2)
        dt1 = Ds.Tables(0)
        Using objPartidaContable As New Financiero_ReportViewer(dt1, "DsLogEntriesAndExits", "epd_SatelliteERP.Finance_Report_LogEntriesAndExitsActualYear.rdlc")
            objPartidaContable.ShowDialog()
        End Using
    End Sub

    Private Sub LoadAnalisisEntradaSalida()
        Dim dt As New DataTable
        Using objsql As New Financiero_SQLServer
            dt = objsql.ERP_Finance_Report_LogEntriesAndExitsAnalisis(0)
        End Using
        GenerateKPIAnalisis(dt)
    End Sub

    Private Sub GenerateKPIAnalisis(ByVal Info As DataTable)
        Try
            lblEntradasSalidas.Text = "Analisis de Ventas del año " + Info.Rows(0).Item("Anio")
            ChartAnalisis.Series(0)("PieLabelStyle") = "Inside"
            ChartAnalisis.Series(0).Font = New System.Drawing.Font("calibri", 9.0F, System.Drawing.FontStyle.Bold)
            ChartAnalisis.Series(1).Font = New System.Drawing.Font("calibri", 9.0F, System.Drawing.FontStyle.Bold)
            ChartAnalisis.Series(2).Font = New System.Drawing.Font("calibri", 9.0F, System.Drawing.FontStyle.Bold)
            ChartAnalisis.Series(0).BorderWidth = 1

            ChartAnalisis.BackColor = Color.FromArgb(127, Color.White)
            ChartAnalisis.ChartAreas(0).BackColor = Color.White
            ChartAnalisis.Series(0).Color = Color.FromArgb(97, 176, 54)
            ChartAnalisis.Series(1).Color = Color.FromArgb(127, Color.DarkRed)
            ChartAnalisis.Series(2).Color = Color.FromArgb(127, Color.Yellow)

            Dim CArea As ChartArea = ChartAnalisis.ChartAreas(0)
            '	CArea.AxisX.MajorGrid.Enabled = False
            CArea.AxisX.LabelStyle.Font = New System.Drawing.Font("Times New Roman", 12.0F, System.Drawing.FontStyle.Bold)
            '	CArea.AxisY.MajorGrid.Enabled = False
            CArea.AxisX.LabelStyle.Angle = -90
            'CArea.AxisX.Interval = 1
            ' ChartAnalisis.ChartAreas(0).Area3DStyle.Enable3D = True
            REM ChartAnalisis.ItemStyle.SurfaceAlphaTransparency = 0.75F
            REM ChartAnalisis.FocusedItemStyle.SurfaceAlphaTransparency = 0.75F
            REM ChartAnalisis.FocusedItemStyle.SurfaceBrightnessFactor = 0.3F

            ChartAnalisis.Series(0).BorderColor = System.Drawing.Color.FromArgb(26, 59, 105)
            ChartAnalisis.Legends(0).Enabled = True
            ChartAnalisis.Legends(0).Docking = Docking.Right
            ChartAnalisis.Legends(0).Alignment = System.Drawing.StringAlignment.Center
            ChartAnalisis.ChartAreas(0).AxisY.LabelStyle.Format = ("C")

            ChartAnalisis.Series(0).Label = "$#VALY"
            ChartAnalisis.Series(1).Label = "$#VALY"
            ChartAnalisis.Series(2).Label = "$#VALY"
            ChartAnalisis.Series(0).SmartLabelStyle.Enabled = True
            ChartAnalisis.Series(0).LabelFormat = "###,###,##0.00"
            ChartAnalisis.Series(0).LegendText = "Entradas"
            ChartAnalisis.Series(1).LegendText = "Salidas"
            ChartAnalisis.Series(2).LegendText = "Neto"

            ChartAnalisis.Series(0).LabelBackColor = Color.Green
            ChartAnalisis.Series(1).LabelBackColor = Color.Red
            ChartAnalisis.Series(2).LabelBackColor = Color.Yellow



            ChartAnalisis.Series(0).LabelForeColor = Color.White
            ChartAnalisis.Series(1).LabelForeColor = Color.White
            ChartAnalisis.Series(2).LabelForeColor = Color.Black

            'ChartAnio.ChartAreas(0).Area3DStyle.Enable3D = True
            Dim series1 As Series = ChartAnalisis.Series(0)
            Dim series2 As Series = ChartAnalisis.Series(1)
            Dim series3 As Series = ChartAnalisis.Series(2)

            ChartAnalisis.DataSource = Info

            series1.Name = "Entradas"
            series2.Name = "Salidas"
            series3.Name = "Utilidad"

            ChartAnalisis.Series(series1.Name).XValueMember = "Mes"
            ChartAnalisis.Series(series1.Name).YValueMembers = "Entrada"

            ChartAnalisis.Series(series2.Name).XValueMember = "Mes"
            ChartAnalisis.Series(series2.Name).YValueMembers = "Salida"

            ChartAnalisis.Series(series3.Name).XValueMember = "Mes"
            ChartAnalisis.Series(series3.Name).YValueMembers = "Neto"

        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmdCrearTypeCreditLine_Click(sender As Object, e As EventArgs) Handles cmdCrearTypeCreditLine.Click
        Using objAdd As New ERP_Mantenimiento_TypeCreditLine
            objAdd.Id_Company_FK = _ID_Company
            objAdd.id_TypeCreditLine = 0
            If objAdd.ShowDialog() = DialogResult.OK Then
                GetDataTypeCreditLine()
            End If
        End Using
    End Sub

    Private Sub cmdActualizarTypeCreditLine_Click(sender As Object, e As EventArgs) Handles cmdActualizarTypeCreditLine.Click
        Using objAdd As New ERP_Mantenimiento_TypeCreditLine
            objAdd.Title = "Modificar Tipo de Producto"
            objAdd.Id_Company_FK = _ID_Company
            objAdd.id_TypeCreditLine = dgvTypeCreditLine.CurrentRow.Cells("Id_TypeCreditLine").Value
            objAdd.Name_TypeCreditLine = dgvTypeCreditLine.CurrentRow.Cells("Type_CreditLine").Value
            objAdd.Description_TypeCreditLine = dgvTypeCreditLine.CurrentRow.Cells("DescriptionCreditLine").Value
            If objAdd.ShowDialog() = DialogResult.OK Then
                GetDataTypeCreditLine()
            End If
        End Using
    End Sub

    Private Sub cmdEliminarTypeCreditLine_Click(sender As Object, e As EventArgs) Handles cmdEliminarTypeCreditLine.Click
        If Not dgvTypeCreditLine.CurrentRow Is Nothing Then
            Dim ID_CustomerType As Long = dgvTypeCreditLine.CurrentRow.Cells("Id_TypeCreditLine").Value
            Dim NameOutletCatalog As String = dgvTypeCreditLine.CurrentRow.Cells("Type_CreditLine").Value
            Dim resp As String = ""
            If MessageBox.Show("¿Está seguro que desea eliminar el Tipo de Producto: " & NameOutletCatalog & "?", "Información", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
                Using objDelete As New Generic_SQLServer
                    resp = objDelete.ERP_SP_DelTypeCreditLine(ID_CustomerType, _ID_Company)
                End Using
                If resp = "OK" Then
                    MessageBox.Show("Registro eliminado exitosamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    GetDataTypeCreditLine()
                Else
                    MessageBox.Show("Ocurrió un error al eliminar el Tipo de Producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        End If
    End Sub

    Private Sub cmdCrearPartialPayment_Click(sender As Object, e As EventArgs) Handles cmdCrearPartialPayment.Click
        Using objAdd As New ERP_Mantenimiento_PartialPaymentsCatalog
            objAdd.Id_Company_FK = _ID_Company
            objAdd.id_Catalog = 0
            If objAdd.ShowDialog() = DialogResult.OK Then
                GetPartialPaymentsCatalog()
            End If
        End Using
    End Sub

    Private Sub cmdActualizarPartialPayment_Click(sender As Object, e As EventArgs) Handles cmdActualizarPartialPayment.Click
        Using objAdd As New ERP_Mantenimiento_PartialPaymentsCatalog
            objAdd.Title = "Modificar Opción Pago Parcial"
            objAdd.Id_Company_FK = _ID_Company
            objAdd.id_Catalog = dgvPartialPayments.CurrentRow.Cells("Id_Catalog").Value
            objAdd.Name_Catalog = dgvPartialPayments.CurrentRow.Cells("DescriptionCatalog").Value
            If objAdd.ShowDialog() = DialogResult.OK Then
                GetPartialPaymentsCatalog()
            End If
        End Using
    End Sub

    Private Sub cmdEliminarPartialPayment_Click(sender As Object, e As EventArgs) Handles cmdEliminarPartialPayment.Click
        If Not dgvPartialPayments.CurrentRow Is Nothing Then
            Dim ID_CustomerType As Long = dgvPartialPayments.CurrentRow.Cells("Id_Catalog").Value
            Dim NameOutletCatalog As String = dgvPartialPayments.CurrentRow.Cells("DescriptionCatalog").Value
            Dim resp As String = ""
            If MessageBox.Show("¿Está seguro que desea eliminar el Tipo de Producto: " & NameOutletCatalog & "?", "Información", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
                Using objDelete As New Generic_SQLServer
                    resp = objDelete.ERP_AccountsReceivable_Del_PartialPaymentsCatalog(ID_CustomerType, _ID_Company)
                End Using
                If resp = "OK" Then
                    MessageBox.Show("Registro eliminado exitosamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    GetPartialPaymentsCatalog()
                Else
                    MessageBox.Show("Ocurrió un error al eliminar el Tipo de Producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        End If
    End Sub
    Private Sub EstadosGrid_Compra()
        For Each row As DataGridViewRow In DGW_ComprasLista.Rows
            Try
                row.Cells("imagenCompra").Value = Nothing
                If row.Cells("StatusTransaction").Value = "True" Then
                    row.Cells("imagenCompra").Value = epd_SatelliteERP.My.Resources.Resources.Verde_Bandera
                Else
                    row.Cells("imagenCompra").Value = epd_SatelliteERP.My.Resources.Resources.Roja_Bandera
                End If
            Catch ex As Exception
                ' No existe cambio unicamente es valor nulo
                row.Cells("imagenCompra").Value = epd_SatelliteERP.My.Resources.Resources.Verde_Bandera
            End Try
        Next
    End Sub
    Private Sub cmdCompraFactura_Click(sender As Object, e As EventArgs) Handles cmdCompraFactura.Click
        Using obj As New Generic_SeleccionarCliente
            obj.StartPosition = FormStartPosition.CenterParent
            If obj.ShowDialog() = DialogResult.OK Then
                Using objFac As New Financiero_IngresoCompras("CONSUMIDOR FINAL")
                    objFac.objCustomerRow = obj.rowSelection
                    If objFac.ShowDialog() = DialogResult.OK Then
                        GetDataCompras()
                    End If
                End Using
            End If
        End Using
    End Sub

    Private Sub cmdCompraCreditoFiscal_Click(sender As Object, e As EventArgs) Handles cmdCompraCreditoFiscal.Click
        Using obj As New Generic_SeleccionarCliente
            obj.StartPosition = FormStartPosition.CenterParent
            If obj.ShowDialog() = DialogResult.OK Then
                Using objFac As New Financiero_IngresoCompras("CREDITO FISCAL")
                    objFac.objCustomerRow = obj.rowSelection
                    If objFac.ShowDialog() = DialogResult.OK Then
                        GetDataFacturas()
                    End If
                End Using
            End If
        End Using
    End Sub

    Private Sub cmdLibroVentasFactura_Click(sender As Object, e As EventArgs) Handles cmdLibroVentasFactura.Click
        Using objCaptura As New DigitaPeriodo
            Dim Periodo As String = ""
            If objCaptura.ShowDialog = DialogResult.OK Then
                Periodo = objCaptura.Periodo
                Dim dt As New DataTable
                Using obj As New Financiero_SQLServer
                    dt = obj.Book_Shopping_Taxpayer_Select(Data_Id_Company, Periodo)
                End Using
                Using objPartidaContable As New Financiero_ReportViewer(dt, Financiero_ReportViewer.TipoLibroIVA.Ventas_LibroComsumidorFinal, "datos", "epd_SatelliteERP.Libro_ConsumidorFinal.rdlc")
                    objPartidaContable.ShowDialog()
                End Using
            End If

        End Using
    End Sub

    Private Sub cmdImpresionLibroCreditoFiscal_Click(sender As Object, e As EventArgs) Handles cmdImpresionLibroCreditoFiscal.Click
        Using objCaptura As New DigitaPeriodo
            Dim Periodo As String = ""
            If objCaptura.ShowDialog = DialogResult.OK Then
                Periodo = objCaptura.Periodo
                Dim dt As New DataTable
                Using obj As New Financiero_SQLServer
                    dt = obj.Book_Taxpayer_Sales_Select(Data_Id_Company, Periodo)
                End Using
                Using objPartidaContable As New Financiero_ReportViewer(dt, Financiero_ReportViewer.TipoLibroIVA.Ventas_LiborContibuyentes, "datos", "epd_SatelliteERP.Libro_Contribuyente.rdlc")
                    objPartidaContable.ShowDialog()
                End Using
            End If

        End Using

    End Sub

    Private Sub cmdComprasLibro_Click(sender As Object, e As EventArgs) Handles cmdComprasLibro.Click
        Using objCaptura As New DigitaPeriodo
            Dim Periodo As String = ""
            If objCaptura.ShowDialog = DialogResult.OK Then
                Periodo = objCaptura.Periodo
                Dim dt As New DataTable
                Using obj As New Financiero_SQLServer
                    dt = obj.Book_Purchases_Taxpayer_Select(Data_Id_Company, Periodo)
                End Using
                Using objPartidaContable As New Financiero_ReportViewer(dt, Financiero_ReportViewer.TipoLibroIVA.Ventas_LiborContibuyentes, "datos", "epd_SatelliteERP.Libro_Compras.rdlc")
                    objPartidaContable.ShowDialog()
                End Using
            End If

        End Using

    End Sub

    Private Sub DGW_FacturasLista_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGW_FacturasLista.CellContentClick

    End Sub
End Class
