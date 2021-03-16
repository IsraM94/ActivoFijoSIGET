Imports System.IO

Public Class ModuloCompras
    Private objOperacion As New Operaciones_SQLServer
    Private objGeneric As New Generic_SQLServer
    Private _tableArticulos As DataTable
    Private _tableCustomer As DataTable
    Private _tablePurchaseOrders As DataTable
    Private _tableExistencia As DataTable
    Private _tableAlertas As DataTable
    Private _TypeCustomer As Long = 0
    REM` Private _tableInvoiceHeader As DataTable
    Private Sub tcMain_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tcMain.SelectedIndexChanged
        If sender.SelectedTab.Name = "Reportes" Then
            REM GetDataProyectos()
        ElseIf sender.SelectedTab.Name = "Articulos"
            GetDataProductos()
        ElseIf sender.Selectedtab.Name = "ClientesProveedores"
            GetClientes()
        ElseIf sender.Selectedtab.Name = "Compras" Then
            GetDataOrdenesCompra()
        ElseIf sender.Selectedtab.Name = "Existencias" Then
            GetDataExistencia()
        ElseIf sender.Selectedtab.Name = "AlertasProductos" Then
            GetDataAlertar()
        End If
    End Sub
    Private Sub GetDataAlertar()
        _tableAlertas = objOperacion.GetInventoryProductsOnAlert(Data_Id_Company)
        'DGV_AlertasProduct.AutoGenerateColumns = False
        'DGV_AlertasProduct.Font = New Font("Segoe UI", 11)
        'DGV_AlertasProduct.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        'DGV_AlertasProduct.ReadOnly = True
        'DGV_AlertasProduct.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        'DGV_AlertasProduct.MultiSelect = False

        'DGV_AlertasProduct.AllowUserToAddRows = False
        'DGV_AlertasProduct.AllowUserToDeleteRows = False
        'DGV_AlertasProduct.Columns(0).Width = 100
        'DGV_AlertasProduct.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight

        'DGV_AlertasProduct.Columns(1).Width = 240
        'DGV_AlertasProduct.Columns(2).Width = 150

        'DGV_AlertasProduct.Columns(3).Width = 280
        'DGV_AlertasProduct.Columns(4).Width = 150
        'DGV_AlertasProduct.Columns(5).Width = 95
        'DGV_AlertasProduct.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
        'DGV_AlertasProduct.Columns(5).DefaultCellStyle.Format = "#0"
        'DGV_AlertasProduct.Columns(6).Width = 95
        'DGV_AlertasProduct.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
        'DGV_AlertasProduct.Columns(6).DefaultCellStyle.Format = "#0"
        'DGV_AlertasProduct.DataSource = _tableAlertas

    End Sub
    Private Sub GetClientes()
        '_tableCustomer = objGeneric.GetCustomerClientList(Data_Id_Company, -1, -1, -1, 2)
        'DGVClientes.AutoGenerateColumns = False
        'DGVClientes.Font = New Font("Segoe UI", 11)
        'DGVClientes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
        'DGVClientes.ReadOnly = True
        'DGVClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        'DGVClientes.MultiSelect = False

        'DGVClientes.AllowUserToAddRows = False
        'DGVClientes.AllowUserToDeleteRows = False

        'DGVClientes.DataSource = _tableCustomer
    End Sub

    Private Sub GetDataExistencia()
        'Dim Ds As New EPD_SatelliteERPDataSet_Inventario
        'Dim dt As New EPD_SatelliteERPDataSet_InventarioTableAdapters.ERP_SP_Inventory_Report_PriceListTableAdapter
        'dt.Fill(Ds.ERP_SP_Inventory_Report_PriceList)
        '_tableExistencia = Ds.Tables("ERP_SP_Inventory_Report_PriceList")
        'DGV_Existencia.AutoGenerateColumns = False
        'DGV_Existencia.Font = New Font("Segoe UI", 11)
        'DGV_Existencia.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
        'DGV_Existencia.ReadOnly = True
        'DGV_Existencia.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        'DGV_Existencia.MultiSelect = False

        'DGV_Existencia.AllowUserToAddRows = False
        'DGV_Existencia.AllowUserToDeleteRows = False
        'DGV_Existencia.Columns(0).Width = 90
        'DGV_Existencia.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
        'DGV_Existencia.Columns(1).Width = 350
        'DGV_Existencia.Columns(2).Width = 160
        'DGV_Existencia.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
        'DGV_Existencia.Columns(2).DefaultCellStyle.Format = "c"
        'DGV_Existencia.Columns(3).Width = 160
        'DGV_Existencia.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
        'DGV_Existencia.Columns(4).Width = 120
        'DGV_Existencia.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
        'DGV_Existencia.Columns(4).DefaultCellStyle.Format = "#,###"

        'DGV_Existencia.Columns(5).Width = 100
        'DGV_Existencia.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
        'DGV_Existencia.Columns(5).DefaultCellStyle.Format = "c"

        'DGV_Existencia.Columns(6).Width = 100
        'DGV_Existencia.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
        'DGV_Existencia.Columns(6).DefaultCellStyle.Format = "c"

        'DGV_Existencia.Columns(7).Width = 100
        'DGV_Existencia.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
        'DGV_Existencia.Columns(7).DefaultCellStyle.Format = "c"

        'DGV_Existencia.DataSource = _tableExistencia
    End Sub

    Private Sub GetDataOrdenesCompra()

		_tablePurchaseOrders = objOperacion.GetInventoryPurchaseOrders()
		DGV_PurchaseOrders.AutoGenerateColumns = False
        DGV_PurchaseOrders.Font = New Font("Segoe UI", 11)
        DGV_PurchaseOrders.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
        DGV_PurchaseOrders.ReadOnly = True
        DGV_PurchaseOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DGV_PurchaseOrders.MultiSelect = False

        DGV_PurchaseOrders.AllowUserToAddRows = False
        DGV_PurchaseOrders.AllowUserToDeleteRows = False
        DGV_PurchaseOrders.Columns(0).Width = 100
        DGV_PurchaseOrders.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
        DGV_PurchaseOrders.Columns(1).Width = 90
        DGV_PurchaseOrders.Columns(2).Width = 350
        DGV_PurchaseOrders.Columns(3).Width = 250

        DGV_PurchaseOrders.Columns(4).Width = 120
        DGV_PurchaseOrders.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
        DGV_PurchaseOrders.Columns(4).DefaultCellStyle.Format = "c"
        DGV_PurchaseOrders.Columns(5).Width = 120
        DGV_PurchaseOrders.Columns(6).Width = 120
        DGV_PurchaseOrders.DataSource = _tablePurchaseOrders

    End Sub
    Private Sub GetDataProductos()
        _tableArticulos = objGeneric.GetProduct(Data_Id_Company, "%%")
        'DGW_Product.AutoGenerateColumns = False
        'DGW_Product.Font = New Font("Segoe UI", 11)
        'DGW_Product.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
        'DGW_Product.ReadOnly = True
        'DGW_Product.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        'DGW_Product.MultiSelect = False

        'DGW_Product.AllowUserToAddRows = False
        'DGW_Product.AllowUserToDeleteRows = False
        'DGW_Product.Columns(0).Width = 100
        'DGW_Product.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
        'DGW_Product.Columns(1).Width = 250
        'DGW_Product.Columns(2).Width = 200
        'DGW_Product.Columns(3).Width = 160
        'DGW_Product.Columns(4).Width = 220
        'DGW_Product.Columns(5).Width = 120
        'DGW_Product.Columns(6).Width = 120
        'DGW_Product.DataSource = _tableArticulos
    End Sub

	Private Sub cmdReporteCatalogoCliente_Click(sender As Object, e As EventArgs)
		Dim Ds As New EPD_SatelliteERPDataSet_Inventario
		Dim dt As New EPD_SatelliteERPDataSet_InventarioTableAdapters.ERP_SP_Inventory_Report_CatalogCustomersTableAdapter
		Dim dt1 As DataTable
		dt.Fill(Ds.ERP_SP_Inventory_Report_CatalogCustomers)
		dt1 = Ds.Tables(0)
		Using objPartidaContable As New Financiero_ReportViewer(dt1, "CatalogoClientes", "epd_SatelliteERP.Inventario_CatalogClientes.rdlc")
			objPartidaContable.ShowDialog()
		End Using
	End Sub

	Private Sub cmdReporteProveedores_Click(sender As Object, e As EventArgs)
		Dim Ds As New EPD_SatelliteERPDataSet_Inventario
		Dim dt As New EPD_SatelliteERPDataSet_InventarioTableAdapters.ERP_SP_Inventory_Report_CatalogCustomersTableAdapter
		Dim dt1 As DataTable
		dt.Fill(Ds.ERP_SP_Inventory_Report_CatalogCustomers)
		dt1 = Ds.Tables(0)
		Using objPartidaContable As New Financiero_ReportViewer(dt1, "CatalogoClientes", "epd_SatelliteERP.Inventario_ReporteProveedores.rdlc")
			objPartidaContable.ShowDialog()
		End Using
	End Sub

	Private Sub cmdCatalogoClienteFinanciero_Click(sender As Object, e As EventArgs)
		Dim Ds As New EPD_SatelliteERPDataSet_Inventario
		Dim dt As New EPD_SatelliteERPDataSet_InventarioTableAdapters.ERP_SP_Inventory_Report_CatalogueFinancialCustomersTableAdapter
		Dim dt1 As DataTable
		dt.Fill(Ds.ERP_SP_Inventory_Report_CatalogueFinancialCustomers)
		dt1 = Ds.Tables("ERP_SP_Inventory_Report_CatalogueFinancialCustomers")
		Using objPartidaContable As New Financiero_ReportViewer(dt1, "Datos", "epd_SatelliteERP.Inventario_CatalogFinanciero.rdlc")
			objPartidaContable.ShowDialog()
		End Using
	End Sub

	Private Sub cmdFichaCliente_Click(sender As Object, e As EventArgs)
		Dim Ds As New EPD_SatelliteERPDataSet_Inventario
		Dim dt As New EPD_SatelliteERPDataSet_InventarioTableAdapters.ERP_SP_Inventory_Report_Report_CustomerCardTableAdapter
		Dim dt1 As DataTable
		dt.Fill(Ds.ERP_SP_Inventory_Report_Report_CustomerCard)
		dt1 = Ds.Tables("ERP_SP_Inventory_Report_Report_CustomerCard")
		Using objPartidaContable As New Financiero_ReportViewer(dt1, "Datos", "epd_SatelliteERP.Inventario_CatalogClienteCard.rdlc")
			objPartidaContable.ShowDialog()
		End Using
	End Sub

	Private Sub cmdPrecioPublico_Click(sender As Object, e As EventArgs)
		Dim Ds As New EPD_SatelliteERPDataSet_Inventario
		Dim dt As New EPD_SatelliteERPDataSet_InventarioTableAdapters.ERP_SP_Inventory_Report_PriceListTableAdapter
		Dim dt1 As DataTable
		dt.Fill(Ds.ERP_SP_Inventory_Report_PriceList)
		dt1 = Ds.Tables("ERP_SP_Inventory_Report_PriceList")
		Using objPartidaContable As New Financiero_ReportViewer(dt1, "Datos", "epd_SatelliteERP.Inventario_ListaPreciosPublico.rdlc")
			objPartidaContable.ShowDialog()
		End Using
	End Sub

	Private Sub cmdSugeridosCompra_Click(sender As Object, e As EventArgs)
		Dim Ds As New EPD_SatelliteERPDataSet_Inventario
		Dim dt As New EPD_SatelliteERPDataSet_InventarioTableAdapters.ERP_SP_Inventory_Report_PriceListTableAdapter
		Dim dt1 As DataTable
		dt.Fill(Ds.ERP_SP_Inventory_Report_PriceList)
		dt1 = Ds.Tables("ERP_SP_Inventory_Report_PriceList")
		Using objPartidaContable As New Financiero_ReportViewer(dt1, "Datos", "epd_SatelliteERP.Inventario_ListaMasimoMinimos.rdlc")
			objPartidaContable.ShowDialog()
		End Using
	End Sub

	Private Sub cmdListadoExistencias_Click(sender As Object, e As EventArgs)
		Dim Ds As New EPD_SatelliteERPDataSet_Inventario
		Dim dt As New EPD_SatelliteERPDataSet_InventarioTableAdapters.ERP_SP_Inventory_Report_PriceListTableAdapter
		Dim dt1 As DataTable
		dt.Fill(Ds.ERP_SP_Inventory_Report_PriceList)
		dt1 = Ds.Tables("ERP_SP_Inventory_Report_PriceList")
		Using objPartidaContable As New Financiero_ReportViewer(dt1, "Datos", "epd_SatelliteERP.Inventario_ListaExistencias.rdlc")
			objPartidaContable.ShowDialog()
		End Using
	End Sub

	Private Sub cmdListadoExistenciasValorizado_Click(sender As Object, e As EventArgs)
		Dim Ds As New EPD_SatelliteERPDataSet_Inventario
		Dim dt As New EPD_SatelliteERPDataSet_InventarioTableAdapters.ERP_SP_Inventory_Report_PriceListTableAdapter
		Dim dt1 As DataTable
		dt.Fill(Ds.ERP_SP_Inventory_Report_PriceList)
		dt1 = Ds.Tables("ERP_SP_Inventory_Report_PriceList")
		Using objPartidaContable As New Financiero_ReportViewer(dt1, "Datos", "epd_SatelliteERP.Inventario_ListaExistenciasValorizado.rdlc")
			objPartidaContable.ShowDialog()
		End Using
	End Sub

	Private Sub cmdListadoCostoUtilidades_Click(sender As Object, e As EventArgs)
		Dim Ds As New EPD_SatelliteERPDataSet_Inventario
		Dim dt As New EPD_SatelliteERPDataSet_InventarioTableAdapters.ERP_SP_Inventory_Report_PriceListTableAdapter
		Dim dt1 As DataTable
		dt.Fill(Ds.ERP_SP_Inventory_Report_PriceList)
		dt1 = Ds.Tables("ERP_SP_Inventory_Report_PriceList")
		Using objPartidaContable As New Financiero_ReportViewer(dt1, "Datos", "epd_SatelliteERP.Inventario_ListaCostosUtilidades.rdlc")
			objPartidaContable.ShowDialog()
		End Using
	End Sub

	Private Sub cmdUnidadesVendidas_Click(sender As Object, e As EventArgs)
		Dim Ds As New EPD_SatelliteERPDataSet_Inventario
		Dim dt As New EPD_SatelliteERPDataSet_InventarioTableAdapters.ERP_SP_Inventory_Report_PriceListTableAdapter
		Dim dt1 As DataTable
		dt.Fill(Ds.ERP_SP_Inventory_Report_PriceList)
		dt1 = Ds.Tables("ERP_SP_Inventory_Report_PriceList")
		Using objPartidaContable As New Financiero_ReportViewer(dt1, "Datos", "epd_SatelliteERP.Inventario_ListaUnidadesVendidas.rdlc")
			objPartidaContable.ShowDialog()
		End Using
	End Sub

	Private Sub cmdKardex_Click(sender As Object, e As EventArgs)
		Dim Ds As New EPD_SatelliteERPDataSet_Inventario
		Dim dt As New EPD_SatelliteERPDataSet_InventarioTableAdapters.ERP_SP_Inventory_Report_KardexTableAdapter
		Dim dt1 As DataTable
		dt.Fill(Ds.ERP_SP_Inventory_Report_Kardex)
		dt1 = Ds.Tables("ERP_SP_Inventory_Report_Kardex")
		Using objPartidaContable As New Financiero_ReportViewer(dt1, "Datos", "epd_SatelliteERP.Inventario_Kardex.rdlc")
			objPartidaContable.ShowDialog()
		End Using
	End Sub

	Private Sub cmdEstadoCuentaCliente_Click(sender As Object, e As EventArgs)
		Dim Ds As New EPD_SatelliteERPDataSet_Inventario
		Dim dt As New EPD_SatelliteERPDataSet_InventarioTableAdapters.ERP_SP_Inventory_Report_AccountStatusTableAdapter
		Dim dt1 As DataTable
		dt.Fill(Ds.ERP_SP_Inventory_Report_AccountStatus)
		dt1 = Ds.Tables("ERP_SP_Inventory_Report_AccountStatus")
		Using objPartidaContable As New Financiero_ReportViewer(dt1, "Datos", "epd_SatelliteERP.Inventario_EstadoCuentaCliente.rdlc")
			objPartidaContable.ShowDialog()
		End Using
	End Sub

	Private Sub cmdPumpRegister_Click(sender As Object, e As EventArgs)
		Dim Ds As New EPD_SatelliteERPDataSet_Inventario
		Dim dt As New EPD_SatelliteERPDataSet_InventarioTableAdapters.ERP_SP_Inventory_Report_PumpReadingsTableAdapter
		Dim dt1 As DataTable
		dt.Fill(Ds.ERP_SP_Inventory_Report_PumpReadings)
		dt1 = Ds.Tables("ERP_SP_Inventory_Report_PumpReadings")
		Using objPartidaContable As New Financiero_ReportViewer(dt1, "Datos", "epd_SatelliteERP.Inventario_PumpReadings.rdlc")
			objPartidaContable.ShowDialog()
		End Using
	End Sub

	Private Sub cmdDryStockSales_Click(sender As Object, e As EventArgs)
		Dim Ds As New EPD_SatelliteERPDataSet_Inventario
		Dim dt As New EPD_SatelliteERPDataSet_InventarioTableAdapters.ERP_SP_Inventory_Report_DryStockSalesSectionTableAdapter
		Dim dt1 As DataTable
		dt.Fill(Ds.ERP_SP_Inventory_Report_DryStockSalesSection)
		dt1 = Ds.Tables("ERP_SP_Inventory_Report_DryStockSalesSection")
		Using objPartidaContable As New Financiero_ReportViewer(dt1, "Datos", "epd_SatelliteERP.Inventario_DryStockSales.rdlc")
			objPartidaContable.ShowDialog()
		End Using
	End Sub

	Private Sub cmdWetStockSalesSection_Click(sender As Object, e As EventArgs)
		Dim Ds As New EPD_SatelliteERPDataSet_Inventario
		Dim dt As New EPD_SatelliteERPDataSet_InventarioTableAdapters.ERP_SP_Inventory_Report_WetStockSalesSectionTableAdapter
		Dim dt1 As DataTable
		dt.Fill(Ds.ERP_SP_Inventory_Report_WetStockSalesSection)
		dt1 = Ds.Tables("ERP_SP_Inventory_Report_WetStockSalesSection")
		Using objPartidaContable As New Financiero_ReportViewer(dt1, "Datos", "epd_SatelliteERP.Inventario_WetStockSalesSection.rdlc")
			objPartidaContable.ShowDialog()
		End Using
	End Sub

	Private Sub cmdPaidInsSection_Click(sender As Object, e As EventArgs)
		Dim Ds As New EPD_SatelliteERPDataSet_Inventario
		Dim dt As New EPD_SatelliteERPDataSet_InventarioTableAdapters.ERP_SP_Inventory_Report_PaidInsSectionTableAdapter
		Dim dt1 As DataTable
		dt.Fill(Ds.ERP_SP_Inventory_Report_PaidInsSection)
		dt1 = Ds.Tables("ERP_SP_Inventory_Report_PaidInsSection")
		Using objPartidaContable As New Financiero_ReportViewer(dt1, "Datos", "epd_SatelliteERP.Inventario_PaidInSection.rdlc")
			objPartidaContable.ShowDialog()
		End Using
	End Sub

	Private Sub cmdTenderCollectionSection_Click(sender As Object, e As EventArgs)
		Dim Ds As New EPD_SatelliteERPDataSet_Inventario
		Dim dt As New EPD_SatelliteERPDataSet_InventarioTableAdapters.ERP_SP_Inventory_Report_TenderCollectionSectionTableAdapter
		Dim dt1 As DataTable
		dt.Fill(Ds.ERP_SP_Inventory_Report_TenderCollectionSection)
		dt1 = Ds.Tables("ERP_SP_Inventory_Report_TenderCollectionSection")
		Using objPartidaContable As New Financiero_ReportViewer(dt1, "Datos", "epd_SatelliteERP.Inventario_TenderCollectionSection.rdlc")
			objPartidaContable.ShowDialog()
		End Using
	End Sub

	Private Sub cmdFuelReconciliation_Click(sender As Object, e As EventArgs)
		Dim Ds As New EPD_SatelliteERPDataSet_Inventario
		Dim dt As New EPD_SatelliteERPDataSet_InventarioTableAdapters.ERP_SP_Inventory_Report_FuelReconciliationTableAdapter
		Dim dt1 As DataTable
		dt.Fill(Ds.ERP_SP_Inventory_Report_FuelReconciliation)
		dt1 = Ds.Tables("ERP_SP_Inventory_Report_FuelReconciliation")
		Using objPartidaContable As New Financiero_ReportViewer(dt1, "Datos", "epd_SatelliteERP.Inventario_FuelReconciliationSection.rdlc")
			objPartidaContable.ShowDialog()
		End Using
	End Sub

	Private Sub Button5_Click(sender As Object, e As EventArgs)
		Using Objcreate As New ERP_ClientesCuentasPorCobrar
			Objcreate.TipoConsulta = ERP_ClientesCuentasPorCobrar.Proceso.Proveedores
			Objcreate.OpcionSeleccionada = ERP_ClientesCuentasPorCobrar.Funcion.Agregar
			If Objcreate.ShowDialog() = DialogResult.OK Then
				GetClientes()
			End If
		End Using
	End Sub


	Private WithEvents obj As New ERP_Inventory_Busqueda
	Sub pp(ByVal StringDigitado As String) Handles obj.EventDatosDigitados

		Dim dv As DataView
		If tcMain.SelectedTab.Name = "ClientesProveedores" Then
			dv = New DataView(_tableCustomer, "Name_Company Like '%" & StringDigitado & "%' ", "Name_Company Desc", DataViewRowState.CurrentRows)
			'	DGVClientes.DataSource = dv
		Else
			dv = New DataView(_tableArticulos, "Name_Product Like '%" & StringDigitado & "%' or Description like '%" & StringDigitado & "%' ", "Name_Product Desc", DataViewRowState.CurrentRows)

		End If
	End Sub
	Private Sub cmdBuscarArticulos_Click(sender As Object, e As EventArgs)
		obj.ShowDialog()
	End Sub
	Private Sub cmdBusquedaProveedor_Click(sender As Object, e As EventArgs)
		obj.ShowDialog()
	End Sub
	Private Sub Button6_Click_1(sender As Object, e As EventArgs) Handles Button6.Click
		If Not DGV_PurchaseOrders.CurrentRow Is Nothing Then
			Dim ID_Orden As Integer = DGV_PurchaseOrders.CurrentRow.Cells(0).Value
            If MessageBox.Show("¿Está seguro que desea eliminar la orden de compra número: " & ID_Orden & "?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
                Dim resp As Integer = objGeneric.UpdateStateOrder(_ID_Company, ID_Orden, 4) ' se desactiva la orden de compra
                If resp = 1 Then
                    MessageBox.Show("Orden de compra eliminada exitosamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Ocurrió un error al eliminar la orden de compra", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
            GetDataOrdenesCompra()
		End If
	End Sub

	Private Sub cmdInventaryCrearOrdenesSugeridas_Click(sender As Object, e As EventArgs)
		Using obj As New ERP_InventorySuggestedShopping

			obj.ShowDialog()
		End Using
		GetDataOrdenesCompra()
	End Sub

	Private Sub cmdComprasCrearOrden_Click(sender As Object, e As EventArgs) Handles cmdComprasCrearOrden.Click
		' Llama factura

		Using obj As New Generic_SeleccionarCliente
			obj.StartPosition = FormStartPosition.CenterParent
			If obj.ShowDialog() = DialogResult.OK Then
				Using objTipo As New ERP_Compras_TipoCompra
					If (objTipo.ShowDialog()) = DialogResult.OK Then

						Using objFac As New ERP_Inventary_CreaOrden
							objFac.objCustomerRow = obj.rowSelection

							If objTipo.IS_File Then
								objFac.IS_Sugerido = False
							ElseIf objTipo.IS_Manual
								objFac.IS_Sugerido = False
							ElseIf objTipo.IS_Sugerido
								objFac.IS_Sugerido = True
							End If
							objFac.ID_Stowage = 0
							objFac.ID_CUSTOMER = obj.rowSelection(0)
							If objFac.ShowDialog() = DialogResult.OK Then
								GetDataOrdenesCompra()
							End If
						End Using
					Else
						Exit Sub
					End If
				End Using

			End If
		End Using

	End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Dim dt As New DataTable
        Using objsql As New Operaciones_SQLServer
            dt = objsql.GetInventoryPurchaseOrders()
        End Using

        Using objPartidaContable As New Financiero_ReportViewer(dt, "DataSet1", "epd_SatelliteERP.Inventory_OrderCompraList.rdlc")
            objPartidaContable.ShowDialog()
        End Using
    End Sub

    Private Sub cmdInventaryExistenciaList_Click(sender As Object, e As EventArgs)
		Dim Ds As New EPD_SatelliteERPDataSet_Inventario
		Dim dt As New EPD_SatelliteERPDataSet_InventarioTableAdapters.ERP_SP_Inventory_Report_PriceListTableAdapter
		Dim dt1 As DataTable
		dt.Fill(Ds.ERP_SP_Inventory_Report_PriceList)
		dt1 = Ds.Tables("ERP_SP_Inventory_Report_PriceList")
		Using objPartidaContable As New Financiero_ReportViewer(dt1, "Datos", "epd_SatelliteERP.Inventario_ListaExistenciasValorizado.rdlc")
			objPartidaContable.ShowDialog()
		End Using
	End Sub

	Private Sub cmdInventario_PrecioPublico_Click(sender As Object, e As EventArgs)
		Dim Ds As New EPD_SatelliteERPDataSet_Inventario
		Dim dt As New EPD_SatelliteERPDataSet_InventarioTableAdapters.ERP_SP_Inventory_Report_PriceListTableAdapter
		Dim dt1 As DataTable
		dt.Fill(Ds.ERP_SP_Inventory_Report_PriceList)
		dt1 = Ds.Tables("ERP_SP_Inventory_Report_PriceList")
		Using objPartidaContable As New Financiero_ReportViewer(dt1, "DatosPrecioPublico", "epd_SatelliteERP.Inventario_ListaPreciosPublico.rdlc")
			objPartidaContable.ShowDialog()
		End Using
	End Sub

	Private Sub cmdInventario_SugeridoCompra_Click(sender As Object, e As EventArgs)
		Dim Ds As New EPD_SatelliteERPDataSet_Inventario
		Dim dt As New EPD_SatelliteERPDataSet_InventarioTableAdapters.ERP_SP_Inventory_Report_PriceListTableAdapter
		Dim dt1 As DataTable
		dt.Fill(Ds.ERP_SP_Inventory_Report_PriceList)
		dt1 = Ds.Tables("ERP_SP_Inventory_Report_PriceList")
		Using objPartidaContable As New Financiero_ReportViewer(dt1, "DatosSugerenciaCompras", "epd_SatelliteERP.Inventario_ListaMasimoMinimos.rdlc")
			objPartidaContable.ShowDialog()
		End Using
	End Sub

	Private Sub cmdInventario_ListaExistencias_Click(sender As Object, e As EventArgs)
		Dim Ds As New EPD_SatelliteERPDataSet_Inventario
		Dim dt As New EPD_SatelliteERPDataSet_InventarioTableAdapters.ERP_SP_Inventory_Report_PriceListTableAdapter
		Dim dt1 As DataTable
		dt.Fill(Ds.ERP_SP_Inventory_Report_PriceList)
		dt1 = Ds.Tables("ERP_SP_Inventory_Report_PriceList")
		Using objPartidaContable As New Financiero_ReportViewer(dt1, "DatosExistencias", "epd_SatelliteERP.Inventario_ListaExistencias.rdlc")
			objPartidaContable.ShowDialog()
		End Using
	End Sub

	Private Sub cmdInventario_ListaExistenciaValorizado_Click(sender As Object, e As EventArgs)
		Dim Ds As New EPD_SatelliteERPDataSet_Inventario
		Dim dt As New EPD_SatelliteERPDataSet_InventarioTableAdapters.ERP_SP_Inventory_Report_PriceListTableAdapter
		Dim dt1 As DataTable
		dt.Fill(Ds.ERP_SP_Inventory_Report_PriceList)
		dt1 = Ds.Tables("ERP_SP_Inventory_Report_PriceList")
		Using objPartidaContable As New Financiero_ReportViewer(dt1, "DatosExistenciasValorizada", "epd_SatelliteERP.Inventario_ListaExistenciasValorizado.rdlc")
			objPartidaContable.ShowDialog()
		End Using
	End Sub

	Private Sub cmdInventario_ListaCostoUtilidades_Click(sender As Object, e As EventArgs)
		Dim Ds As New EPD_SatelliteERPDataSet_Inventario
		Dim dt As New EPD_SatelliteERPDataSet_InventarioTableAdapters.ERP_SP_Inventory_Report_PriceListTableAdapter
		Dim dt1 As DataTable
		dt.Fill(Ds.ERP_SP_Inventory_Report_PriceList)
		dt1 = Ds.Tables("ERP_SP_Inventory_Report_PriceList")
		Using objPartidaContable As New Financiero_ReportViewer(dt1, "DatosCostosUtilidades", "epd_SatelliteERP.Inventario_ListaCostosUtilidades.rdlc")
			objPartidaContable.ShowDialog()
		End Using
	End Sub

	Private Sub cmdCompras_ListaExistencias_Click(sender As Object, e As EventArgs) Handles cmdCompras_ListaExistencias.Click
		Dim Ds As New EPD_SatelliteERPDataSet_Inventario
		Dim dt As New EPD_SatelliteERPDataSet_InventarioTableAdapters.ERP_SP_Inventory_Report_PriceListTableAdapter
		Dim dt1 As DataTable
		dt.Fill(Ds.ERP_SP_Inventory_Report_PriceList)
		dt1 = Ds.Tables("ERP_SP_Inventory_Report_PriceList")
		Using objPartidaContable As New Financiero_ReportViewer(dt1, "DatosExistencias", "epd_SatelliteERP.Inventario_ListaExistencias.rdlc")
			objPartidaContable.ShowDialog()
		End Using
	End Sub

	Private Sub cmdCompras_ListaExistenciasValorizada_Click(sender As Object, e As EventArgs) Handles cmdCompras_ListaExistenciasValorizada.Click
		Dim Ds As New EPD_SatelliteERPDataSet_Inventario
		Dim dt As New EPD_SatelliteERPDataSet_InventarioTableAdapters.ERP_SP_Inventory_Report_PriceListTableAdapter
		Dim dt1 As DataTable
		dt.Fill(Ds.ERP_SP_Inventory_Report_PriceList)
		dt1 = Ds.Tables("ERP_SP_Inventory_Report_PriceList")
		Using objPartidaContable As New Financiero_ReportViewer(dt1, "DatosExistenciasValorizada", "epd_SatelliteERP.Inventario_ListaExistenciasValorizado.rdlc")
			objPartidaContable.ShowDialog()
		End Using
	End Sub

	Private Sub cmdProveedores_ListaClientes_Click(sender As Object, e As EventArgs)
		Dim Ds As New EPD_SatelliteERPDataSet_Inventario
		Dim dt As New EPD_SatelliteERPDataSet_InventarioTableAdapters.ERP_SP_Inventory_Report_CatalogCustomersTableAdapter
		Dim dt1 As DataTable
		dt.Fill(Ds.ERP_SP_Inventory_Report_CatalogCustomers)
		dt1 = Ds.Tables(0)
		Using objPartidaContable As New Financiero_ReportViewer(dt1, "CatalogoClientes", "epd_SatelliteERP.Inventario_CatalogClientes.rdlc")
			objPartidaContable.ShowDialog()
		End Using
	End Sub

	Private Sub cmdProveedores_ListaClientesFinanciero_Click(sender As Object, e As EventArgs)
		Dim Ds As New EPD_SatelliteERPDataSet_Inventario
		Dim dt As New EPD_SatelliteERPDataSet_InventarioTableAdapters.ERP_SP_Inventory_Report_CatalogueFinancialCustomersTableAdapter
		Dim dt1 As DataTable
		dt.Fill(Ds.ERP_SP_Inventory_Report_CatalogueFinancialCustomers)
		dt1 = Ds.Tables("ERP_SP_Inventory_Report_CatalogueFinancialCustomers")
		Using objPartidaContable As New Financiero_ReportViewer(dt1, "Datos", "epd_SatelliteERP.Inventario_CatalogFinanciero.rdlc")
			objPartidaContable.ShowDialog()
		End Using
	End Sub

	Private Sub cmdProveedores_FichaCliente_Click(sender As Object, e As EventArgs)
		Dim Ds As New EPD_SatelliteERPDataSet_Inventario
		Dim dt As New EPD_SatelliteERPDataSet_InventarioTableAdapters.ERP_SP_Inventory_Report_Report_CustomerCardTableAdapter
		Dim dt1 As DataTable
		dt.Fill(Ds.ERP_SP_Inventory_Report_Report_CustomerCard)
		dt1 = Ds.Tables("ERP_SP_Inventory_Report_Report_CustomerCard")
		Using objPartidaContable As New Financiero_ReportViewer(dt1, "DatosCliente", "epd_SatelliteERP.Inventario_CatalogClienteCard.rdlc")
			objPartidaContable.ShowDialog()
		End Using
	End Sub

	Private Sub cmdProveedores_ListaProveedores_Click(sender As Object, e As EventArgs)
		Dim Ds As New EPD_SatelliteERPDataSet_Inventario
		Dim dt As New EPD_SatelliteERPDataSet_InventarioTableAdapters.ERP_SP_Inventory_Report_CatalogCustomersTableAdapter
		Dim dt1 As DataTable
		dt.Fill(Ds.ERP_SP_Inventory_Report_CatalogCustomers)
		dt1 = Ds.Tables(0)
		Using objPartidaContable As New Financiero_ReportViewer(dt1, "CatalogoClientes", "epd_SatelliteERP.Inventario_ReporteProveedores.rdlc")
			objPartidaContable.ShowDialog()
		End Using
	End Sub

	Private Sub cmd_Productos_ListaExistencias_Click(sender As Object, e As EventArgs)
		Dim Ds As New EPD_SatelliteERPDataSet_Inventario
		Dim dt As New EPD_SatelliteERPDataSet_InventarioTableAdapters.ERP_SP_Inventory_Report_PriceListTableAdapter
		Dim dt1 As DataTable
		dt.Fill(Ds.ERP_SP_Inventory_Report_PriceList)
		dt1 = Ds.Tables("ERP_SP_Inventory_Report_PriceList")
		Using objPartidaContable As New Financiero_ReportViewer(dt1, "DatosExistencias", "epd_SatelliteERP.Inventario_ListaExistencias.rdlc")
			objPartidaContable.ShowDialog()
		End Using
	End Sub
	Private Sub cmd_Productos_ListaExistenciasValorizadas_Click(sender As Object, e As EventArgs)
		Dim Ds As New EPD_SatelliteERPDataSet_Inventario
		Dim dt As New EPD_SatelliteERPDataSet_InventarioTableAdapters.ERP_SP_Inventory_Report_PriceListTableAdapter
		Dim dt1 As DataTable
		dt.Fill(Ds.ERP_SP_Inventory_Report_PriceList)
		dt1 = Ds.Tables("ERP_SP_Inventory_Report_PriceList")
		Using objPartidaContable As New Financiero_ReportViewer(dt1, "DatosExistenciasValorizada", "epd_SatelliteERP.Inventario_ListaExistenciasValorizado.rdlc")
			objPartidaContable.ShowDialog()
		End Using
	End Sub

	Private Sub cmd_Productos_ListaCostosUtilidades_Click(sender As Object, e As EventArgs)
		Dim Ds As New EPD_SatelliteERPDataSet_Inventario
		Dim dt As New EPD_SatelliteERPDataSet_InventarioTableAdapters.ERP_SP_Inventory_Report_PriceListTableAdapter
		Dim dt1 As DataTable
		dt.Fill(Ds.ERP_SP_Inventory_Report_PriceList)
		dt1 = Ds.Tables("ERP_SP_Inventory_Report_PriceList")
		Using objPartidaContable As New Financiero_ReportViewer(dt1, "DatosCostosUtilidades", "epd_SatelliteERP.Inventario_ListaCostosUtilidades.rdlc")
			objPartidaContable.ShowDialog()
		End Using
	End Sub
	Private Sub cmd_Productos_UnidadesVendidas_Click(sender As Object, e As EventArgs)
		Dim Ds As New EPD_SatelliteERPDataSet_Inventario
		Dim dt As New EPD_SatelliteERPDataSet_InventarioTableAdapters.ERP_SP_Inventory_Report_PriceListTableAdapter
		Dim dt1 As DataTable
		dt.Fill(Ds.ERP_SP_Inventory_Report_PriceList)
		dt1 = Ds.Tables("ERP_SP_Inventory_Report_PriceList")
		Using objPartidaContable As New Financiero_ReportViewer(dt1, "DatosUnidadesVendidas", "epd_SatelliteERP.Inventario_ListaUnidadesVendidas.rdlc")
			objPartidaContable.ShowDialog()
		End Using
	End Sub
	Private Sub cmd_Productos_Kardex_Click(sender As Object, e As EventArgs)
		Dim Ds As New EPD_SatelliteERPDataSet_Inventario
		Dim dt As New EPD_SatelliteERPDataSet_InventarioTableAdapters.ERP_SP_Inventory_Report_KardexTableAdapter
		Dim dt1 As DataTable
		dt.Fill(Ds.ERP_SP_Inventory_Report_Kardex)
		dt1 = Ds.Tables("ERP_SP_Inventory_Report_Kardex")
		Using objPartidaContable As New Financiero_ReportViewer(dt1, "DatosKardex", "epd_SatelliteERP.Inventario_Kardex.rdlc")
			objPartidaContable.ShowDialog()
		End Using
	End Sub

	Private Sub cmd_Productos_Crear_Click(sender As Object, e As EventArgs)
		Using obj As New Generic_SeleccionarCliente
			obj.StartPosition = FormStartPosition.CenterParent
			If obj.ShowDialog() = DialogResult.OK Then

				Using objArticulo As New ERP_Inventory_CreateProduct
					objArticulo.objCustomerRow = obj.rowSelection
					objArticulo.StartPosition = FormStartPosition.CenterParent
					objArticulo.OpcionSeleccionada = ERP_Inventory_CreateProduct.funcion.Agregar
					If objArticulo.ShowDialog = DialogResult.OK Then

					End If
				End Using
			End If
		End Using
	End Sub

	Private Sub cmdAlertaProduct_CrearOrdenesCompras_Click(sender As Object, e As EventArgs)
		Using obj As New ERP_InventorySuggestedShopping
			obj.ShowDialog()
		End Using
	End Sub

    Private Sub cmdOrderDetails_Click(sender As Object, e As EventArgs) Handles cmdOrderDetails.Click
        Dim dt As New DataTable
        Dim valor As Long = 0
        If DGV_PurchaseOrders.Focus = True Then
            valor = DGV_PurchaseOrders.CurrentRow.Cells("Id_PurchaseOrder").Value
        End If
        Using objsql As New Operaciones_SQLServer
            dt = objsql.ERP_SP_Report_Inventory_GenerateOrderDetails(valor)
        End Using

        Using objPartidaContable As New Financiero_ReportViewer(dt, "DataSet1", "epd_SatelliteERP.Inventory_DetailsOrderCompraList.rdlc")
            objPartidaContable.WindowState = FormWindowState.Maximized
            objPartidaContable.ShowDialog()
        End Using
    End Sub
End Class
