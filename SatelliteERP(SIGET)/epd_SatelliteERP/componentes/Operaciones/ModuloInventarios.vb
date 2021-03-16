Imports System.IO

Public Class ModuloInventarios
	Private objOperacion As New Operaciones_SQLServer
	Private objGeneric As New Generic_SQLServer
	Private _tableArticulos As DataTable
    Private _tableCustomer As DataTable
    Private _tableModelo As DataTable
    Private _TypeCustomer As Long = 0
    Dim Amarillo_bandera As Bitmap = Global.epd_SatelliteERP.My.Resources.Resources.Amarillo_bandera
    Dim Roja_Bandera As Bitmap = Global.epd_SatelliteERP.My.Resources.Resources.Roja_Bandera
    Dim Verde_Bandera As Bitmap = Global.epd_SatelliteERP.My.Resources.Resources.Verde_bandera
    Dim Morado_Bandera As Bitmap = Global.epd_SatelliteERP.My.Resources.Resources.Morado_Bandera
    Dim Anaranjado_Bandera As Bitmap = Global.epd_SatelliteERP.My.Resources.Resources.Anaranjado_Bandera

    Property tabControl As Integer
    '------------------------------------
    Private _ID_Stowages As Long = 0
	Private _Name_Stowage As String = ""
    Private EncargadoBodega As Boolean = False
    Private IsJefe As Boolean = False

    Private _tableMarcas As DataTable
	Private _tableCategorias As DataTable
	Private _tableLineas As DataTable
	Private _tableBodegas As DataTable
	Private _tableLocation As DataTable
    Private _tableCatalagoSalida As DataTable
    Private _tableRequisiciones As DataTable
    Private _tableReason As DataTable
    Private Id_Proveedor As Integer = 0
    Private OpcionesMenu As DataTable
    Private objSql2 As New Generic_SQLServer

    Private AprobarSalidas As Boolean = False

    Private SeleccHistEmpleado As Boolean = False
    Private IdUnidadHist As Integer = 0
    '-----------------------------------
    REM` Private _tableInvoiceHeader As DataTable

    REM Aplicar roles
    Public Sub AplicarRoles()


        tcMain.TabPages.Remove(ClientesProveedores)
        tcMain.TabPages.Remove(Articulos)
        tcMain.TabPages.Remove(Requisiciones)
        tcMain.TabPages.Remove(TBodegas)
        tcMain.TabPages.Remove(Marcas)
        tcMain.TabPages.Remove(Categorias)
        tcMain.TabPages.Remove(Linea)
        tcMain.TabPages.Remove(Bodegas)
        tcMain.TabPages.Remove(Ubicacion)
        tcMain.TabPages.Remove(CatalagoSalidas)
        tcMain.TabPages.Remove(TipoCliente)
        tcMain.TabPages.Remove(GiroGeneral)
        tcMain.TabPages.Remove(UnitMeasure)
        tcMain.TabPages.Remove(ProductCondition)
        tcMain.TabPages.Remove(Modelo)
        tcMain.TabPages.Remove(Motivos)
        tcMain.TabPages.Remove(TPRequisitionTypes)


        tsDenegadas.Visible = True
        tsProceso.Visible = True
        tsRevision.Visible = True
        ToolStripSeparator16.Visible = True
        ToolStripSeparator15.Visible = True
        ToolStripSeparator14.Visible = True
        ToolStripSeparator13.Visible = False

        OpcionesMenu = objSql2.GetAccessMenu(_UserSQL)
        If (OpcionesMenu.Rows.Count > 0) Then
            For Each DataInfo As DataRow In OpcionesMenu.Rows
                If (DataInfo("rolUser").ToString.ToUpper = "MN_Alma_1_MenuVer_Proveedores".ToUpper) Then
                    tcMain.TabPages.Add(ClientesProveedores)
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "MN_Alma_2_MenuVer_Productos".ToUpper) Then
                    tcMain.TabPages.Add(Articulos)
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "MN_Alma_3_MenuVer_Requisiciones".ToUpper) Then
                    tcMain.TabPages.Add(Requisiciones)
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "MN_Alma_4_MenuVer_TrabajasConBodegas".ToUpper) Then
                    tcMain.TabPages.Add(TBodegas)
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "MN_Alma_MenuVer_Marcas".ToUpper) Then
                    tcMain.TabPages.Add(Marcas)
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "MN_Alma_MenuVer_Categoria".ToUpper) Then
                    tcMain.TabPages.Add(Categorias)
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "MN_Alma_MenuVer_Linea".ToUpper) Then
                    tcMain.TabPages.Add(Linea)
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "MN_Alma_MenuVer_Bodegas".ToUpper) Then
                    tcMain.TabPages.Add(Bodegas)
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "MN_Alma_MenuVer_Ubicacion".ToUpper) Then
                    tcMain.TabPages.Add(Ubicacion)
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "MN_Alma_MenuVer_CatEntradasSalidas".ToUpper) Then
                    tcMain.TabPages.Add(CatalagoSalidas)
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "MN_Alma_MenuVer_TipoProveedor".ToUpper) Then
                    tcMain.TabPages.Add(TipoCliente)
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "MN_Alma_MenuVer_GiroGeneral".ToUpper) Then
                    tcMain.TabPages.Add(GiroGeneral)
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "MN_Alma_MenuVer_UnidadMedida".ToUpper) Then
                    tcMain.TabPages.Add(UnitMeasure)
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "MN_Alma_MenuVer_TipoProducto".ToUpper) Then
                    tcMain.TabPages.Add(ProductCondition)
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "MN_Alma_MenuVer_MOdelo".ToUpper) Then
                    tcMain.TabPages.Add(Modelo)
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "MN_Alma_MenuVer_MotivosTranslados".ToUpper) Then
                    tcMain.TabPages.Add(Motivos)
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "MN_Alma_MenuVer_TipoRequisicion".ToUpper) Then
                    tcMain.TabPages.Add(TPRequisitionTypes)
                End If


                If (DataInfo("rolUser").ToString.ToUpper = "In_Bodegas_CrearBodega".ToUpper) Then
                    Button6.Visible = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "In_Bodegas_EliminarBodega".ToUpper) Then
                    Button8.Visible = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "In_Bodegas_ModificarBodega".ToUpper) Then
                    Button7.Visible = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "In_Bodegas_ReportesBodega".ToUpper) Then
                    Button4.Visible = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "In_Bodegas_BuscarBodegas".ToUpper) Then
                    btnBuscarBodega.Visible = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "In_Bodegas_TodasBodegas".ToUpper) Then
                    cmdTodasBodegas.Visible = True
                End If

                If (DataInfo("rolUser").ToString.ToUpper = "In_CatalogoSalidas_CrearCatalogodeSalida".ToUpper) Then
                    Button22.Visible = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "In_CatalogoSalidas_EliminarCatalogodeSalida".ToUpper) Then
                    Button24.Visible = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "In_CatalogoSalidas_ModificarCatalogodeSalida".ToUpper) Then
                    Button23.Visible = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "In_CatalogoSalidas_ReporteCatalogodeSalida".ToUpper) Then
                    Button11.Visible = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "In_CatalogoSalidas_BuscarCatalogodeSalida".ToUpper) Then
                    btnBuscarCatalogo.Visible = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "In_CatalogoSalidas_TodasCatalogodeSalida".ToUpper) Then
                    cmdTodosCatalogos.Visible = True
                End If

                If (DataInfo("rolUser").ToString.ToUpper = "In_Categorias_CrearCategoria".ToUpper) Then
                    Button9.Visible = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "In_Categorias_EliminarCategoria".ToUpper) Then
                    Button15.Visible = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "In_Categorias_ModificarCategoria".ToUpper) Then
                    Button14.Visible = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "In_Categorias_ReporteCategoria".ToUpper) Then
                    Button2.Visible = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "In_Categorias_BuscarCategoria".ToUpper) Then
                    btnBuscarCategoria.Visible = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "In_Categorias_TodasCategoria".ToUpper) Then
                    cmdTodasCategorias.Visible = True
                End If

                If (DataInfo("rolUser").ToString.ToUpper = "In_ClientesProveedores_CrearCliPro".ToUpper) Then
                    Button5.Visible = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "In_ClientesProveedores_ModificarCliPro".ToUpper) Then
                    cmdUpdateClients.Visible = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "In_ClientesProveedores_Report".ToUpper) Then
                    cmdClientes_CatalogoClientes.Visible = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "In_ClientesProveedores_ReportFichaProveedor".ToUpper) Then
                    cmdClientes_FichaCliente.Visible = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "In_ClientesProveedores_BuscarProveedor".ToUpper) Then
                    cmdBuscarProveedor.Visible = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "In_ClientesProveedores_TodosProveedor".ToUpper) Then
                    cmdTodosProveedores.Visible = True
                End If

                If (DataInfo("rolUser").ToString.ToUpper = "In_GiroGeneral_CrearGiroGeneral".ToUpper) Then
                    cmdCrearGiroGeneral.Visible = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "In_GiroGeneral_EliminarGiroGeneral".ToUpper) Then
                    cmdEliminarGiroGeneral.Visible = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "In_GiroGeneral_ModificarGiroGeneral".ToUpper) Then
                    cmdActualizarGiroGeneral.Visible = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "In_GiroGeneral_Reportes".ToUpper) Then
                    'cmdListadoGiroGeneral.Visible = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "In_GiroGeneral_Buscar".ToUpper) Then
                    btnGiroGeneral.Visible = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "In_GiroGeneral_Todos".ToUpper) Then
                    btnTodosGiroGeneral.Visible = True
                End If

                If (DataInfo("rolUser").ToString.ToUpper = "IN_Motivos_BuscarMotivos".ToUpper) Then
                    cmdTodosMotivos.Visible = True
                    cmdBuscarMotivos.Visible = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "IN_Motivos_CrearMotivos".ToUpper) Then
                    cmdCrearMotivos.Visible = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "IN_Motivos_ModificarMotivos".ToUpper) Then
                    cmdModificarMotivo.Visible = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "IN_Motivos_EliminarMotivos".ToUpper) Then
                    cmbEliminarMotivos.Visible = True
                End If


                If (DataInfo("rolUser").ToString.ToUpper = "In_Requisicion_CrearRequisicion".ToUpper) Then
                    cmd_CrearRequisicion.Visible = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "In_Requisicion_AprobarRequisicion".ToUpper) Then
                    cmd_AprobarRequisicion.Visible = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "In_Requisicion_AbastecerRequisicion".ToUpper) Then
                    cmd_AbasteceRequisicion.Visible = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "In_Requisicion_ReaperturarRequisicion".ToUpper) Then
                    cmdReaperturar.Visible = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "In_Requisicion_AbastecimientoReporte".ToUpper) Then
                    cmd_AbastecimientoReport.Visible = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "In_Requisicion_BuscarRequisicion".ToUpper) Then
                    btnBuscarRequisicion.Visible = True
                    btn_FiltrasRequisiciones.Visible = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "In_Requisicion_HistorialRequisiciones".ToUpper) Then
                    btnHistorial.Visible = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "In_Requisicion_VerRequisicion".ToUpper) Then
                    btnVerRequisicion.Visible = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "In_Requisicion_RequisicionesEncargadoBodega".ToUpper) Then
                    tsDenegadas.Visible = False
                    tsProceso.Visible = False
                    tsRevision.Visible = False
                    ToolStripSeparator16.Visible = False
                    ToolStripSeparator15.Visible = False
                    ToolStripSeparator14.Visible = False
                    ToolStripSeparator13.Visible = False
                    EncargadoBodega = True
                    btnVerRequisicion.Visible = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "In_Requisicion_RequisicionesEsJefe".ToUpper) Then
                    tsDenegadas.Visible = False
                    ToolStripSeparator13.Visible = False
                    IsJefe = True

                End If

                If (DataInfo("rolUser").ToString.ToUpper = "In_Lineas_CrearLinea".ToUpper) Then
                    Button16.Visible = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "In_Lineas_EliminarLinea".ToUpper) Then
                    Button18.Visible = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "In_Lineas_ModificarLinea".ToUpper) Then
                    Button17.Visible = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "In_Lineas_ReportesLinea".ToUpper) Then
                    Button3.Visible = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "In_Lineas_BuscarLinea".ToUpper) Then
                    btnBuscarLinea.Visible = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "In_Lineas_TodasLinea".ToUpper) Then
                    btnTodasLineas.Visible = True
                End If


                If (DataInfo("rolUser").ToString.ToUpper = "In_Marcas_CrearMarca".ToUpper) Then
                    btnAddMarcas.Visible = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "In_Marcas_EliminarMarca".ToUpper) Then
                    btnDeleteMarcas.Visible = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "In_Marcas_ModificarMarca".ToUpper) Then
                    btnUpdateMarcas.Visible = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "In_Marcas_ReporteMarca".ToUpper) Then
                    btnListMarcas.Visible = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "In_Marcas_BuscarMarca".ToUpper) Then
                    mostrarTiposMarcas.Visible = True
                    btnBuscarMarcas.Visible = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "In_Marcas_TodasMarca".ToUpper) Then
                    cmdTodasMarcas.Visible = True
                    mostrarTiposMarcas.Visible = True
                End If

                If (DataInfo("rolUser").ToString.ToUpper = "In_Modelo_CrearModelo".ToUpper) Then
                    Button1.Visible = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "In_Modelo_EliminarModelo".ToUpper) Then
                    Button25.Visible = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "In_Modelo_ModificarModelo".ToUpper) Then
                    Button13.Visible = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "In_Modelo_ReportesModelo".ToUpper) Then
                    Button26.Visible = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "In_Modelo_BuscarModelo".ToUpper) Then
                    btnBuscarModelo.Visible = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "In_Modelo_TodosModelo".ToUpper) Then
                    cmdTodosModelos.Visible = True
                End If

                If (DataInfo("rolUser").ToString.ToUpper = "In_ProductosActiculos_CrearArticulo".ToUpper) Then
                    cmdAddProduct.Visible = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "In_ProductosActiculos_EliminarArticulo".ToUpper) Then
                    cmdDelete.Visible = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "In_ProductosActiculos_ModificarArticulo".ToUpper) Then
                    cmdUpdateProduct.Visible = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "In_ProductosActiculos_BuscarProducto".ToUpper) Then
                    cmd_BuscarProducto.Visible = True
                    cmdProductos_Buscar.Visible = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "In_ProductosActiculos_TodosProductos".ToUpper) Then
                    btnTodosProductos.Visible = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "In_ProductosActiculos_Reportes".ToUpper) Then
                    cmdReportesProductos.Visible = True
                    cmdProductos_PrecioPublico.Visible = False
                    cmdProductos_SugeridoCompra.Visible = False
                    Button12.Visible = False
                End If


                If (DataInfo("rolUser").ToString.ToUpper = "In_TipoCliente_CrearTipoCliente".ToUpper) Then
                    btnCrearTipoCliente.Visible = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "In_TipoCliente_EliminarTipoCliente".ToUpper) Then
                    btnEliminarTipoCliente.Visible = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "In_TipoCliente_ModificarTipoCliente".ToUpper) Then
                    btnActualizarTipoCliente.Visible = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "In_TipoCliente_BuscarTipoCliente".ToUpper) Then
                    cmdBuscarTipoProveedor.Visible = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "In_TipoCliente_TodosTipoCliente".ToUpper) Then
                    cmdTodosProveed.Visible = True
                End If

                If (DataInfo("rolUser").ToString.ToUpper = "In_TipoProducto_CrearTipoProducto".ToUpper) Then
                    cmdCreateProductCondition.Visible = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "In_TipoProducto_EliminarTipoProducto".ToUpper) Then
                    cmdDeleteProductCondition.Visible = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "In_TipoProducto_ModificarTipoProducto".ToUpper) Then
                    cmdUpdateProductCondition.Visible = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "In_TipoProducto_ReporteTipoProducto".ToUpper) Then
                    cmdListProductCondition.Visible = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "In_TipoProducto_BuscarTipoProducto".ToUpper) Then
                    btnBuscarTipoProducto.Visible = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "In_TipoProducto_TodosTipoProducto".ToUpper) Then
                    cmdTodosTipoProducto.Visible = True
                End If

                If (DataInfo("rolUser").ToString.ToUpper = "In_TipoRequisicion_CrearTipoRequisicion".ToUpper) Then
                    cmdCrearTipoRequisicion.Visible = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "In_TipoRequisicion_EliminarTipoRequisicion".ToUpper) Then
                    cmdEliminarTipoRequisicion.Visible = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "In_TipoRequisicion_ModificarTipoRequisicion".ToUpper) Then
                    cmdModificarTipoRequisicion.Visible = True
                End If



                If (DataInfo("rolUser").ToString.ToUpper = "In_TrabajarConBodegas_Entradas".ToUpper) Then
                    cmdEntrada.Visible = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "In_TrabajarConBodegas_MaximosMinimos".ToUpper) Then
                    cmdMaximosYMinimos.Visible = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "In_TrabajarConBodegas_CrearSalidas".ToUpper) Then
                    cmdOutput.Visible = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "In_TrabajarConBodegas_VerSalidas".ToUpper) Then
                    cmdVerSalida.Visible = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "In_TrabajarConBodegas_AprobarSalidas".ToUpper) Then
                    AprobarSalidas = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "In_TrabajarConBodegas_Reportes".ToUpper) Then
                    cmdReporteInventario.Visible = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "In_TrabajarConBodegas_CambiarBodega".ToUpper) Then
                    cmdChange.Visible = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "In_TrabajarConBodegas_BuscarProductos".ToUpper) Then
                    cmd_BuscarProducto.Visible = True
                    cmdAllProducts.Visible = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "In_TrabajarConBodegas_BuscarEntradas".ToUpper) Then
                    btnBuscarEntradas.Visible = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "In_TrabajarConBodegas_TodasEntradas".ToUpper) Then
                    btnTodasEntradas.Visible = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "In_TrabajarConBodegas_HistorialEntradas".ToUpper) Then
                    btnHistorialEntradas.Visible = True
                End If

                If (DataInfo("rolUser").ToString.ToUpper = "In_Ubicacion_CrearUbicacion".ToUpper) Then
                    Button19.Visible = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "In_Ubicacion_EliminarUbicacion".ToUpper) Then
                    Button21.Visible = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "In_Ubicacion_ModificarUbicacion".ToUpper) Then
                    Button20.Visible = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "In_Ubicacion_ReportesUbicacion".ToUpper) Then
                    Button10.Visible = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "In_Ubicacion_BuscarUbicacion".ToUpper) Then
                    btnBusquedaUbicacion.Visible = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "In_Ubicacion_TodasUbicacion".ToUpper) Then
                    btnTodasUbicaciones.Visible = True
                End If

                If (DataInfo("rolUser").ToString.ToUpper = "In_UnidadMedida_CrearUnidadMedida".ToUpper) Then
                    cmdCreateUnitMeasure.Visible = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "In_UnidadMedida_EliminarUnidadMedida".ToUpper) Then
                    cmdDeleteUnitMeasure.Visible = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "In_UnidadMedida_ModificarUnidadMedida".ToUpper) Then
                    cmdUpdateUnitMeasure.Visible = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "In_UnidadMedida_ReporteUnidadMedida".ToUpper) Then
                    cmdListUnitMeasure.Visible = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "In_UnidadMedida_Buscar".ToUpper) Then
                    btnBuscarUnidadMedida.Visible = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "In_UnidadMedida_Todos".ToUpper) Then
                    btnTodosUnidadMedida.Visible = True
                End If
            Next DataInfo
        End If
    End Sub
    Private Sub tcMain_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tcMain.SelectedIndexChanged
        If sender.SelectedTab.Name = "Reportes" Then
            REM GetDataProyectos()
            HidenFuel()
        ElseIf sender.SelectedTab.Name = "Articulos" Then
            DGW_Product.Visible = True
            GetDataProductos()
        ElseIf sender.Selectedtab.Name = "ClientesProveedores" Then
            GetClientes()
        ElseIf sender.SelectedTab.Name = "Recetas" Then
            GetDataProductosRecipes()
        ElseIf sender.SelectedTab.Name = "TBodegas" Then
            getStowage()
            OcultarEntradas()
            dgEntradas.Visible = False
        ElseIf sender.SelectedTab.Name = "Marcas" Then
            GetDataMarcas()
        ElseIf sender.SelectedTab.Name = "Categorias" Then
            GetDataCategorias()
        ElseIf sender.SelectedTab.Name = "Linea" Then
            GetDataLineas()
        ElseIf sender.SelectedTab.Name = "Bodegas" Then
            GetDataBodegas()
        ElseIf sender.SelectedTab.Name = "Ubicacion" Then
            GetDataUbicacion()
        ElseIf sender.SelectedTab.Name = "CatalagoSalidas" Then
            GetDataCatalagoSalida()
        ElseIf sender.SelectedTab.Name = "TipoCliente" Then
            GetDataCustomerType()
        ElseIf sender.SelectedTab.Name = "GiroGeneral" Then
            GetDataGiroGeneral()
        ElseIf sender.SelectedTab.Name = "UnitMeasure" Then
            GetDataUnitMeasure()
        ElseIf sender.SelectedTab.Name = "ProductCondition" Then
            GetDataProductContidion()
        ElseIf sender.SelectedTab.Name = "Requisiciones" Then
            limpiezaData()
            dgvRequisiciones.Visible = True
            GetDataRequisition()
        ElseIf sender.SelectedTab.Name = "Motivos" Then
            GetDataRasones()
            limpiezaData()
        ElseIf sender.SelectedTab.Name = "Modelo" Then
            GetDataModelo()
        ElseIf sender.SelectedTab.Name = "TPRequisitionTypes" Then
            GetDataRequisitionTypes()
        End If

    End Sub


    Private Sub HidenFuel()
        cmdFuelReconciliation.Enabled = False
        cmdFuelReconciliation.Visible = False
        cmdTenderCollectionSection.Enabled = False
        cmdTenderCollectionSection.Visible = False
        cmdPaidInsSection.Enabled = False
        cmdPaidInsSection.Visible = False
        cmdWetStockSalesSection.Enabled = False
        cmdWetStockSalesSection.Visible = False
        cmdDryStockSales.Enabled = False
        cmdDryStockSales.Visible = False
        cmdPumpRegister.Enabled = False
        cmdPumpRegister.Visible = False
    End Sub


    Private Sub getStowage()
        Using ObjBodegas As New ERP_Inventory_Dialog_LocationAndStowage
            If ObjBodegas.ShowDialog = DialogResult.OK Then
                _ID_Stowages = ObjBodegas.ID_Stowage
                _Name_Stowage = ObjBodegas.Name_Stowage
                lblBodega.Text = "Bodega: " & _Name_Stowage
                lblUbicacion.Text = "Ubicación: " & ObjBodegas.NameLocation
                GetDataProductosStowage(_ID_Stowages)
            Else
                tcMain.SelectedIndex = 0
            End If
        End Using
    End Sub
    Private Sub GetDataRequisitionTypes()
        Using objsql As New Requisiciones_SQLServer
            _tableRequisiciones = objsql.SP_Inventory_SelectRequisitionTypes()
            dgvRequisicionesTypes.AutoGenerateColumns = False
            dgvRequisicionesTypes.Font = New Font("Segoe UI", 11)
            dgvRequisicionesTypes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
            dgvRequisicionesTypes.ReadOnly = True
            dgvRequisicionesTypes.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            dgvRequisicionesTypes.MultiSelect = False
            dgvRequisicionesTypes.AllowUserToResizeColumns = False
            dgvRequisicionesTypes.AllowUserToAddRows = False
            dgvRequisicionesTypes.AllowUserToDeleteRows = False
            dgvRequisicionesTypes.Columns(0).Width = 100
            dgvRequisicionesTypes.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
            dgvRequisicionesTypes.Columns(1).Width = 250
            dgvRequisicionesTypes.DataSource = _tableRequisiciones
        End Using
    End Sub
    Private Sub GetDataProductos(Optional ByVal where As String = "")
        _tableArticulos = objGeneric.GetProduct(Data_Id_Company, "%" & where & "%")
        DGW_Product.AutoGenerateColumns = False
        DGW_Product.Font = New Font("Segoe UI", 11)
        DGW_Product.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
        DGW_Product.ReadOnly = True
        DGW_Product.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DGW_Product.MultiSelect = False
        DGW_Product.AllowUserToResizeColumns = True
        DGW_Product.AllowUserToAddRows = False
        DGW_Product.AllowUserToDeleteRows = False
        DGW_Product.Columns(0).Width = 20
        DGW_Product.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
        DGW_Product.Columns(1).Width = 250
        DGW_Product.Columns(2).Width = 120
        DGW_Product.Columns(3).Width = 300
        DGW_Product.Columns(4).Width = 200
        DGW_Product.Columns(5).Width = 200
        DGW_Product.Columns(6).Width = 120
        DGW_Product.Columns(19).Width = 300
        DGW_Product.Columns(20).Width = 200
        DGW_Product.Columns(21).Width = 200
        DGW_Product.Columns(24).Width = 80
        DGW_Product.Columns(24).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight

        DGW_Product.DataSource = _tableArticulos

        If DGW_Product.Rows.Count > 0 Then
            Try
                For Each item As DataGridViewRow In DGW_Product.Rows
                    If (item.Cells("ExistenciasText").Value.ToString = "Verde") Then
                        item.Cells("Imagen").Value = Verde_Bandera
                    ElseIf (item.Cells("ExistenciasText").Value.ToString = "Amarillo") Then
                        item.Cells("Imagen").Value = Amarillo_bandera
                    Else
                        item.Cells("Imagen").Value = Roja_Bandera
                    End If

                Next
            Catch ex As Exception
                Try
                    For Each item As DataGridViewRow In DGW_Product.Rows
                        If (item.Cells("Existencias").Value.ToString = "Verde") Then
                            item.Cells("Imagen").Value = Verde_Bandera
                        ElseIf (item.Cells("Existencias").Value.ToString = "Amarillo") Then
                            item.Cells("Imagen").Value = Amarillo_bandera
                        Else
                            item.Cells("Imagen").Value = Roja_Bandera
                        End If

                    Next
                Catch ex2 As Exception

                End Try
            End Try
        End If

    End Sub

    Private Sub GetDataProductosStowage(ByVal ID_Stowage As Long)
        Using objSQL As New Operaciones_SQLServer
            _tableArticulos = objSQL.ERP_Inventory_GetProducts_Stowage(Data_Id_Company, "%%", ID_Stowage)
            dgvProductsStowage.AutoGenerateColumns = False
            dgvProductsStowage.Font = New Font("Segoe UI", 11)
            dgvProductsStowage.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
            dgvProductsStowage.ReadOnly = True
            dgvProductsStowage.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            dgvProductsStowage.MultiSelect = False
            dgvProductsStowage.AllowUserToResizeColumns = False
            dgvProductsStowage.AllowUserToAddRows = False
            dgvProductsStowage.AllowUserToDeleteRows = False
            dgvProductsStowage.Columns(0).Width = 20
            dgvProductsStowage.Columns(2).Width = 250
            dgvProductsStowage.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
            dgvProductsStowage.Columns(3).Width = 120
            dgvProductsStowage.Columns(4).Width = 300
            dgvProductsStowage.Columns(5).Width = 200
            dgvProductsStowage.Columns(6).Width = 150
            dgvProductsStowage.Columns(7).Width = 300
            dgvProductsStowage.Columns(21).Width = 220
            dgvProductsStowage.Columns(22).Width = 220
            dgvProductsStowage.Columns(23).Width = 220
            dgvProductsStowage.DataSource = _tableArticulos
        End Using

        If dgvProductsStowage.Rows.Count > 0 Then
            Try
                For Each item As DataGridViewRow In dgvProductsStowage.Rows
                    If (item.Cells("ExistenciasText").Value.ToString = "Verde") Then
                        item.Cells("Imagen1").Value = Verde_Bandera
                    ElseIf (item.Cells("ExistenciasText").Value.ToString = "Amarillo") Then
                        item.Cells("Imagen1").Value = Amarillo_bandera
                    Else
                        item.Cells("Imagen1").Value = Roja_Bandera
                    End If

                Next
            Catch ex As Exception
                Try
                    For Each item As DataGridViewRow In dgvProductsStowage.Rows
                        If (item.Cells("Existencias").Value.ToString = "Verde") Then
                            item.Cells("Imagen1").Value = Verde_Bandera
                        ElseIf (item.Cells("Existencias").Value.ToString = "Amarillo") Then
                            item.Cells("Imagen1").Value = Amarillo_bandera
                        Else
                            item.Cells("Imagen1").Value = Roja_Bandera
                        End If

                    Next
                Catch ex2 As Exception

                End Try
            End Try
        End If
    End Sub

    'Busqueda de productos
    Private Sub GetDataProductosStowage(ByVal ID_Stowage As Long, ByVal busqueda As String)
        Using objSQL As New Operaciones_SQLServer
            _tableArticulos = objSQL.ERP_Inventory_GetProducts_Stowage(Data_Id_Company, busqueda, ID_Stowage)
            dgvProductsStowage.AutoGenerateColumns = False
            dgvProductsStowage.Font = New Font("Segoe UI", 11)
            dgvProductsStowage.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
            dgvProductsStowage.ReadOnly = True
            dgvProductsStowage.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            dgvProductsStowage.MultiSelect = False
            dgvProductsStowage.AllowUserToResizeColumns = False
            dgvProductsStowage.AllowUserToAddRows = False
            dgvProductsStowage.AllowUserToDeleteRows = False

            dgvProductsStowage.Columns(0).Width = 20
            dgvProductsStowage.Columns(1).Width = 100
            dgvProductsStowage.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
            dgvProductsStowage.Columns(2).Width = 130
            dgvProductsStowage.Columns(3).Width = 200
            dgvProductsStowage.Columns(4).Width = 100
            dgvProductsStowage.Columns(5).Width = 250
            dgvProductsStowage.Columns(6).Width = 200
            dgvProductsStowage.Columns(21).Width = 220
            dgvProductsStowage.Columns(22).Width = 220
            dgvProductsStowage.Columns(23).Width = 220
            dgvProductsStowage.DataSource = _tableArticulos

            If dgvProductsStowage.Rows.Count > 0 Then
                Try
                    For Each item As DataGridViewRow In dgvProductsStowage.Rows
                        If (item.Cells("ExistenciasText").Value.ToString = "Verde") Then
                            item.Cells("Imagen1").Value = Verde_Bandera
                        ElseIf (item.Cells("ExistenciasText").Value.ToString = "Amarillo") Then
                            item.Cells("Imagen1").Value = Amarillo_bandera
                        Else
                            item.Cells("Imagen1").Value = Roja_Bandera
                        End If

                    Next
                Catch ex As Exception
                    Try
                        For Each item As DataGridViewRow In dgvProductsStowage.Rows
                            If (item.Cells("Existencias").Value.ToString = "Verde") Then
                                item.Cells("Imagen1").Value = Verde_Bandera
                            ElseIf (item.Cells("Existencias").Value.ToString = "Amarillo") Then
                                item.Cells("Imagen1").Value = Amarillo_bandera
                            Else
                                item.Cells("Imagen1").Value = Roja_Bandera
                            End If

                        Next
                    Catch ex2 As Exception

                    End Try
                End Try
            End If


        End Using
    End Sub


    Private Sub GetDataProductosRecipes()
        Using objsql As New Operaciones_SQLServer
            _tableArticulos = objsql.ERP_Inventory_GetProducts_Recipes(_ID_Company, "", 2)
            dgvRecipes.AutoGenerateColumns = False
            dgvRecipes.Font = New Font("Segoe UI", 11)
            dgvRecipes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
            dgvRecipes.ReadOnly = True
            dgvRecipes.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            dgvRecipes.MultiSelect = False
            dgvRecipes.AllowUserToResizeColumns = False
            dgvRecipes.AllowUserToAddRows = False
            dgvRecipes.AllowUserToDeleteRows = False
            dgvRecipes.Columns(0).Width = 100
            dgvRecipes.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
            dgvRecipes.Columns(1).Width = 250
            dgvRecipes.Columns(2).Width = 200
            dgvRecipes.Columns(3).Width = 160
            dgvRecipes.Columns(4).Width = 220
            dgvRecipes.Columns(5).Width = 120
            dgvRecipes.Columns(6).Width = 120
            ' dgvRecipes.Columns("Description").Width = 300
            dgvRecipes.DataSource = _tableArticulos
        End Using
    End Sub

    Private Sub GetDataMarcas()
        Using objsql As New Operaciones_SQLServer
            _tableMarcas = objsql.GetMarca(_ID_Company)
            dgvMarcas.AutoGenerateColumns = False
            dgvMarcas.Font = New Font("Segoe UI", 11)
            dgvMarcas.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
            dgvMarcas.ReadOnly = True
            dgvMarcas.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            dgvMarcas.MultiSelect = False
            'dgvMarcas.AllowUserToResizeColumns = False
            dgvMarcas.AllowUserToAddRows = False
            dgvMarcas.AllowUserToDeleteRows = False
            dgvMarcas.Columns(0).Width = 100
            dgvMarcas.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
            dgvMarcas.Columns(1).Width = 500
            dgvMarcas.DataSource = _tableMarcas
        End Using
    End Sub

    Private Sub GetDataMarcas(ByVal busqueda As String, Optional tipo As Integer = 0)
        Using objsql As New Operaciones_SQLServer
            _tableMarcas = objsql.GetMarca(_ID_Company, busqueda, tipo)
            dgvMarcas.AutoGenerateColumns = False
            dgvMarcas.Font = New Font("Segoe UI", 11)
            dgvMarcas.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
            dgvMarcas.ReadOnly = True
            dgvMarcas.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            dgvMarcas.MultiSelect = False
            'dgvMarcas.AllowUserToResizeColumns = False
            dgvMarcas.AllowUserToAddRows = False
            dgvMarcas.AllowUserToDeleteRows = False
            dgvMarcas.Columns(0).Width = 100
            dgvMarcas.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
            dgvMarcas.Columns(1).Width = 500
            dgvMarcas.DataSource = _tableMarcas
        End Using
    End Sub

    Private Sub GetDataCategorias()
        Using objsql As New Operaciones_SQLServer
            _tableCategorias = objsql.GetCategory(_ID_Company)
            dgvCategorias.AutoGenerateColumns = False
            dgvCategorias.Font = New Font("Segoe UI", 11)
            dgvCategorias.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
            dgvCategorias.ReadOnly = True
            dgvCategorias.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            dgvCategorias.MultiSelect = False
            ' dgvCategorias.AllowUserToResizeColumns = True
            dgvCategorias.AllowUserToAddRows = False
            dgvCategorias.AllowUserToDeleteRows = False
            dgvCategorias.Columns(0).Width = 100
            dgvCategorias.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
            dgvCategorias.Columns(1).Width = 300
            dgvCategorias.DataSource = _tableCategorias
        End Using
    End Sub

    Private Sub GetDataCategorias(ByVal busqueda As String)
        Using objsql As New Operaciones_SQLServer
            _tableCategorias = objsql.GetCategory(_ID_Company, busqueda)
            dgvCategorias.AutoGenerateColumns = False
            dgvCategorias.Font = New Font("Segoe UI", 11)
            dgvCategorias.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
            dgvCategorias.ReadOnly = True
            dgvCategorias.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            dgvCategorias.MultiSelect = False
            'dgvCategorias.AllowUserToResizeColumns = False
            dgvCategorias.AllowUserToAddRows = False
            dgvCategorias.AllowUserToDeleteRows = False
            dgvCategorias.Columns(0).Width = 100
            dgvCategorias.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
            dgvCategorias.Columns(1).Width = 300
            dgvCategorias.DataSource = _tableCategorias
        End Using
    End Sub

    Private Sub GetDataLineas()
        Using objsql As New Generic_SQLServer
            _tableLineas = objsql.GetLines(_ID_Company)
            dgvLineas.AutoGenerateColumns = False
            dgvLineas.Font = New Font("Segoe UI", 11)
            dgvLineas.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
            dgvLineas.ReadOnly = True
            dgvLineas.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            dgvLineas.MultiSelect = False
            ' dgvLineas.AllowUserToResizeColumns = False
            dgvLineas.AllowUserToAddRows = False
            dgvLineas.AllowUserToDeleteRows = False
            dgvLineas.Columns(0).Width = 100
            dgvLineas.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
            dgvLineas.Columns(1).Width = 250
            dgvLineas.Columns(2).Width = 250

            dgvLineas.DataSource = _tableLineas
        End Using
    End Sub

    Private Sub GetDataLineas(ByVal busqueda As String)
        Using objsql As New Generic_SQLServer
            _tableLineas = objsql.GetLines(_ID_Company, busqueda)
            dgvLineas.AutoGenerateColumns = False
            dgvLineas.Font = New Font("Segoe UI", 11)
            dgvLineas.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
            dgvLineas.ReadOnly = True
            dgvLineas.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            dgvLineas.MultiSelect = False
            ' dgvLineas.AllowUserToResizeColumns = False
            dgvLineas.AllowUserToAddRows = False
            dgvLineas.AllowUserToDeleteRows = False
            dgvLineas.Columns(0).Width = 100
            dgvLineas.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
            dgvLineas.Columns(1).Width = 250
            dgvLineas.Columns(2).Width = 250
            DGVClientes.DefaultCellStyle.WrapMode = DataGridViewTriState.True
            dgvLineas.DataSource = _tableLineas
        End Using
    End Sub
    Private Sub GetDataBodegas()
        Using objsql As New Generic_SQLServer
            _tableBodegas = objsql.GetStowages(_ID_Company)
            dgvBodegas.AutoGenerateColumns = False
            dgvBodegas.Font = New Font("Segoe UI", 11)
            dgvBodegas.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
            dgvBodegas.ReadOnly = True
            dgvBodegas.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            dgvBodegas.MultiSelect = False
            'dgvBodegas.AllowUserToResizeColumns = False
            dgvBodegas.AllowUserToAddRows = False
            dgvBodegas.AllowUserToDeleteRows = False
            dgvBodegas.Columns(0).Width = 100
            dgvBodegas.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
            dgvBodegas.Columns(1).Width = 500
            dgvBodegas.Columns(2).Width = 500
            dgvBodegas.Columns(3).Width = 200
            dgvBodegas.Columns(4).Width = 200
            dgvBodegas.Columns(5).Width = 150
            dgvBodegas.Columns(6).Width = 180
            dgvBodegas.DataSource = _tableBodegas
        End Using
    End Sub

    Private Sub GetDataBodegas(ByVal busqueda As String)
        Using objsql As New Generic_SQLServer
            _tableBodegas = objsql.GetStowages(_ID_Company, busqueda)
            dgvBodegas.AutoGenerateColumns = False
            dgvBodegas.Font = New Font("Segoe UI", 11)
            dgvBodegas.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
            dgvBodegas.ReadOnly = True
            dgvBodegas.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            dgvBodegas.MultiSelect = False
            'dgvBodegas.AllowUserToResizeColumns = False
            dgvBodegas.AllowUserToAddRows = False
            dgvBodegas.AllowUserToDeleteRows = False
            dgvBodegas.Columns(0).Width = 100
            dgvBodegas.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
            dgvBodegas.Columns(1).Width = 500
            dgvBodegas.Columns(2).Width = 500
            dgvBodegas.Columns(3).Width = 200
            dgvBodegas.Columns(4).Width = 200
            dgvBodegas.Columns(5).Width = 150
            dgvBodegas.Columns(6).Width = 200
            dgvBodegas.DataSource = _tableBodegas
        End Using
    End Sub

    Private Sub GetDataUbicacion()
        Using objsql As New Generic_SQLServer
            _tableLocation = objsql.GetLocation(_ID_Company)
            dgvUbicacion.AutoGenerateColumns = False
            dgvUbicacion.Font = New Font("Segoe UI", 11)
            dgvUbicacion.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
            dgvUbicacion.ReadOnly = True
            dgvUbicacion.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            dgvUbicacion.MultiSelect = False
            ' dgvUbicacion.AllowUserToResizeColumns = False
            dgvUbicacion.AllowUserToAddRows = False
            dgvUbicacion.AllowUserToDeleteRows = False
            dgvUbicacion.Columns(0).Width = 100
            dgvUbicacion.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
            dgvUbicacion.Columns(1).Width = 200
            dgvUbicacion.Columns(2).Width = 600
            dgvUbicacion.Columns(3).Width = 200
            dgvUbicacion.Columns(4).Width = 200
            dgvUbicacion.Columns(5).Width = 150
            dgvUbicacion.Columns(6).Width = 200
            dgvUbicacion.DataSource = _tableLocation
        End Using
    End Sub

    Private Sub GetDataUbicacion(ByVal busqueda As String)
        Using objsql As New Generic_SQLServer
            _tableLocation = objsql.GetLocation(_ID_Company, busqueda)
            dgvUbicacion.AutoGenerateColumns = False
            dgvUbicacion.Font = New Font("Segoe UI", 11)
            dgvUbicacion.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
            dgvUbicacion.ReadOnly = True
            dgvUbicacion.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            dgvUbicacion.MultiSelect = False
            ' dgvUbicacion.AllowUserToResizeColumns = False
            dgvUbicacion.AllowUserToAddRows = False
            dgvUbicacion.AllowUserToDeleteRows = False
            dgvUbicacion.Columns(0).Width = 100
            dgvUbicacion.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
            dgvUbicacion.Columns(1).Width = 200
            dgvUbicacion.Columns(2).Width = 600
            dgvUbicacion.Columns(3).Width = 200
            dgvUbicacion.Columns(4).Width = 200
            dgvUbicacion.Columns(5).Width = 150
            dgvUbicacion.Columns(6).Width = 200
            dgvUbicacion.DataSource = _tableLocation
        End Using
    End Sub

    Private Sub GetDataModelo()
        Using objsql As New Generic_SQLServer
            _tableModelo = objsql.GetModelo(_ID_Company)
            dgv_modelo.AutoGenerateColumns = False
            dgv_modelo.Font = New Font("Segoe UI", 11)
            dgv_modelo.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
            dgv_modelo.ReadOnly = True
            dgv_modelo.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            dgv_modelo.MultiSelect = False
            'dgv_modelo.AllowUserToResizeColumns = False
            dgv_modelo.AllowUserToAddRows = False
            dgv_modelo.AllowUserToDeleteRows = False
            dgv_modelo.Columns(0).Width = 100
            dgv_modelo.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
            dgv_modelo.Columns(1).Width = 200
            dgv_modelo.Columns(2).Width = 200
            dgv_modelo.Columns(3).Width = 200
            dgv_modelo.Columns(4).Width = 200
            dgv_modelo.Columns(5).Width = 150
            dgv_modelo.Columns(6).Width = 180
            dgv_modelo.Columns(7).Width = 180
            dgv_modelo.DataSource = _tableModelo
        End Using
    End Sub

    Private Sub GetDataModelo(ByVal busqueda As String)
        Using objsql As New Generic_SQLServer
            _tableModelo = objsql.GetModelo(_ID_Company, busqueda)
            dgv_modelo.AutoGenerateColumns = False
            dgv_modelo.Font = New Font("Segoe UI", 11)
            dgv_modelo.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
            dgv_modelo.ReadOnly = True
            dgv_modelo.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            dgv_modelo.MultiSelect = False
            'dgv_modelo.AllowUserToResizeColumns = False
            dgv_modelo.AllowUserToAddRows = False
            dgv_modelo.AllowUserToDeleteRows = False
            dgv_modelo.Columns(0).Width = 100
            dgv_modelo.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
            dgv_modelo.Columns(1).Width = 200
            dgv_modelo.Columns(2).Width = 400
            dgv_modelo.Columns(3).Width = 200
            dgv_modelo.Columns(4).Width = 200
            dgv_modelo.Columns(5).Width = 150
            dgv_modelo.Columns(6).Width = 200
            dgv_modelo.DataSource = _tableModelo
        End Using
    End Sub

    Private Sub GetDataCatalagoSalida()
        Using objsql As New Operaciones_SQLServer
            _tableCatalagoSalida = objsql.SP_ERP_Inventory_GetOutletCatalog(_ID_Company)
            dgvCatalogoSalida.AutoGenerateColumns = False
            dgvCatalogoSalida.Font = New Font("Segoe UI", 11)
            dgvCatalogoSalida.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
            dgvCatalogoSalida.ReadOnly = True
            dgvCatalogoSalida.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            dgvCatalogoSalida.MultiSelect = False
            'dgvCatalogoSalida.AllowUserToResizeColumns = False
            dgvCatalogoSalida.AllowUserToAddRows = False
            dgvCatalogoSalida.AllowUserToDeleteRows = False
            dgvCatalogoSalida.Columns(0).Width = 100
            dgvCatalogoSalida.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
            dgvCatalogoSalida.Columns(1).Width = 430
            dgvCatalogoSalida.DataSource = _tableCatalagoSalida
        End Using
    End Sub

    Private Sub GetDataCatalagoSalida(ByVal busqueda As String)
        Using objsql As New Operaciones_SQLServer
            _tableCatalagoSalida = objsql.SP_ERP_Inventory_GetOutletCatalog(_ID_Company, busqueda)
            dgvCatalogoSalida.AutoGenerateColumns = False
            dgvCatalogoSalida.Font = New Font("Segoe UI", 11)
            dgvCatalogoSalida.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
            dgvCatalogoSalida.ReadOnly = True
            dgvCatalogoSalida.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            dgvCatalogoSalida.MultiSelect = False
            ' dgvCatalogoSalida.AllowUserToResizeColumns = False
            dgvCatalogoSalida.AllowUserToAddRows = False
            dgvCatalogoSalida.AllowUserToDeleteRows = False
            dgvCatalogoSalida.Columns(0).Width = 100
            dgvCatalogoSalida.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
            dgvCatalogoSalida.Columns(1).Width = 430
            dgvCatalogoSalida.DataSource = _tableCatalagoSalida
        End Using
    End Sub

    Private Sub GetDataCustomerType()
        Using objsql As New Generic_SQLServer
            _tableCatalagoSalida = objsql.ERP_Generic_SP_GetTypeCustomer(_ID_Company)
            dgvCustomerType.AutoGenerateColumns = False
            dgvCustomerType.Font = New Font("Segoe UI", 11)
            dgvCustomerType.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
            dgvCustomerType.ReadOnly = True
            dgvCustomerType.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            dgvCustomerType.MultiSelect = False
            'dgvCustomerType.AllowUserToResizeColumns = False
            dgvCustomerType.AllowUserToAddRows = False
            dgvCustomerType.AllowUserToDeleteRows = False
            dgvCustomerType.Columns(0).Width = 100
            dgvCustomerType.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
            dgvCustomerType.Columns(1).Width = 150
            dgvCustomerType.Columns(2).Width = 250
            dgvCustomerType.Columns(3).Width = 160
            dgvCustomerType.Columns(4).Width = 160
            dgvCustomerType.Columns(5).Width = 160
            dgvCustomerType.Columns(6).Width = 180
            dgvCustomerType.DataSource = _tableCatalagoSalida
        End Using
    End Sub

    Private Sub GetDataCustomerType(ByVal busqueda As String)
        Using objsql As New Generic_SQLServer
            _tableCatalagoSalida = objsql.ERP_Generic_SP_GetTypeCustomer(_ID_Company, busqueda)
            dgvCustomerType.AutoGenerateColumns = False
            dgvCustomerType.Font = New Font("Segoe UI", 11)
            dgvCustomerType.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
            dgvCustomerType.ReadOnly = True
            dgvCustomerType.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            dgvCustomerType.MultiSelect = False
            ' dgvCustomerType.AllowUserToResizeColumns = False
            dgvCustomerType.AllowUserToAddRows = False
            dgvCustomerType.AllowUserToDeleteRows = False
            dgvCustomerType.Columns(0).Width = 100
            dgvCustomerType.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
            dgvCustomerType.Columns(1).Width = 150
            dgvCustomerType.Columns(2).Width = 250
            dgvCustomerType.Columns(3).Width = 160
            dgvCustomerType.Columns(4).Width = 160
            dgvCustomerType.Columns(5).Width = 160
            dgvCustomerType.Columns(6).Width = 160
            dgvCustomerType.DataSource = _tableCatalagoSalida
        End Using
    End Sub

    Private Sub GetDataGiroGeneral()
        Using objsql As New Generic_SQLServer
            _tableCatalagoSalida = objsql.ERP_Generic_SP_GetCompanyCategory(_ID_Company)
            dgvGiroGeneral.AutoGenerateColumns = False
            dgvGiroGeneral.Font = New Font("Segoe UI", 11)
            dgvGiroGeneral.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
            dgvGiroGeneral.ReadOnly = True
            dgvGiroGeneral.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            dgvGiroGeneral.MultiSelect = False
            '  dgvGiroGeneral.AllowUserToResizeColumns = False
            dgvGiroGeneral.AllowUserToAddRows = False
            dgvGiroGeneral.AllowUserToDeleteRows = False
            dgvGiroGeneral.Columns(0).Width = 100
            dgvGiroGeneral.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
            dgvGiroGeneral.Columns(1).Width = 400
            dgvGiroGeneral.Columns(2).Width = 160
            dgvGiroGeneral.Columns(3).Width = 180
            dgvGiroGeneral.Columns(4).Width = 160
            dgvGiroGeneral.Columns(5).Width = 180
            dgvGiroGeneral.DataSource = _tableCatalagoSalida
        End Using
    End Sub
    Private Sub GetDataGiroGeneral(ByVal busqueda As String)
        Using objsql As New Generic_SQLServer
            _tableCatalagoSalida = objsql.ERP_Generic_SP_GetCompanyCategory(_ID_Company, busqueda)
            dgvGiroGeneral.AutoGenerateColumns = False
            dgvGiroGeneral.Font = New Font("Segoe UI", 11)
            dgvGiroGeneral.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
            dgvGiroGeneral.ReadOnly = True
            dgvGiroGeneral.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            dgvGiroGeneral.MultiSelect = False
            '  dgvGiroGeneral.AllowUserToResizeColumns = False
            dgvGiroGeneral.AllowUserToAddRows = False
            dgvGiroGeneral.AllowUserToDeleteRows = False
            dgvGiroGeneral.Columns(0).Width = 100
            dgvGiroGeneral.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
            dgvGiroGeneral.Columns(1).Width = 400
            dgvGiroGeneral.Columns(2).Width = 160
            dgvGiroGeneral.Columns(3).Width = 180
            dgvGiroGeneral.Columns(4).Width = 160
            dgvGiroGeneral.Columns(5).Width = 180
            dgvGiroGeneral.DataSource = _tableCatalagoSalida
        End Using
    End Sub

    Private Sub GetDataUnitMeasure()
        Using objsql As New Generic_SQLServer
            _tableCatalagoSalida = objsql.ERP_Generic_SP_GetUnitMeasure(_ID_Company)
            dgvUnidadMedida.AutoGenerateColumns = False
            dgvUnidadMedida.Font = New Font("Segoe UI", 11)
            dgvUnidadMedida.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
            dgvUnidadMedida.ReadOnly = True
            dgvUnidadMedida.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            dgvUnidadMedida.MultiSelect = False
            'dgvUnidadMedida.AllowUserToResizeColumns = False
            dgvUnidadMedida.AllowUserToAddRows = False
            dgvUnidadMedida.AllowUserToDeleteRows = False
            dgvUnidadMedida.Columns(0).Width = 100
            dgvUnidadMedida.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
            dgvUnidadMedida.Columns(1).Width = 250
            dgvUnidadMedida.Columns(2).Width = 160
            dgvUnidadMedida.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
            dgvUnidadMedida.Columns(3).Width = 160
            dgvUnidadMedida.Columns(4).Width = 160
            dgvUnidadMedida.Columns(5).Width = 160
            dgvUnidadMedida.DataSource = _tableCatalagoSalida
        End Using
    End Sub

    Private Sub GetDataUnitMeasure(ByVal busqueda As String)
        Using objsql As New Generic_SQLServer
            _tableCatalagoSalida = objsql.ERP_Generic_SP_GetUnitMeasure(_ID_Company, busqueda)
            dgvUnidadMedida.AutoGenerateColumns = False
            dgvUnidadMedida.Font = New Font("Segoe UI", 11)
            dgvUnidadMedida.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
            dgvUnidadMedida.ReadOnly = True
            dgvUnidadMedida.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            dgvUnidadMedida.MultiSelect = False
            'dgvUnidadMedida.AllowUserToResizeColumns = False
            dgvUnidadMedida.AllowUserToAddRows = False
            dgvUnidadMedida.AllowUserToDeleteRows = False
            dgvUnidadMedida.Columns(0).Width = 100
            dgvUnidadMedida.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
            dgvUnidadMedida.Columns(1).Width = 250
            dgvUnidadMedida.Columns(2).Width = 160
            dgvUnidadMedida.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
            dgvUnidadMedida.Columns(3).Width = 160
            dgvUnidadMedida.Columns(4).Width = 160
            dgvUnidadMedida.Columns(5).Width = 160
            dgvUnidadMedida.DataSource = _tableCatalagoSalida
        End Using
    End Sub

    Private Sub GetDataProductContidion()
        Using objsql As New Generic_SQLServer
            _tableCatalagoSalida = objsql.SP_ERP_Generic_GetProductCondition(_ID_Company)
            dgvProductCondition.AutoGenerateColumns = False
            dgvProductCondition.Font = New Font("Segoe UI", 11)
            dgvProductCondition.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
            dgvProductCondition.ReadOnly = True
            dgvProductCondition.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            dgvProductCondition.MultiSelect = False
            ' dgvProductCondition.AllowUserToResizeColumns = False
            dgvProductCondition.AllowUserToAddRows = False
            dgvProductCondition.AllowUserToDeleteRows = False
            dgvProductCondition.Columns(0).Width = 100
            dgvProductCondition.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
            dgvProductCondition.Columns(1).Width = 250
            dgvProductCondition.Columns(2).Width = 160
            dgvProductCondition.Columns(3).Width = 160
            dgvProductCondition.Columns(4).Width = 160
            dgvProductCondition.Columns(5).Width = 180
            dgvProductCondition.DataSource = _tableCatalagoSalida
        End Using
    End Sub

    Private Sub GetDataProductContidion(ByVal busqueda As String)
        Using objsql As New Generic_SQLServer
            _tableCatalagoSalida = objsql.SP_ERP_Generic_GetProductCondition(_ID_Company, busqueda)
            dgvProductCondition.AutoGenerateColumns = False
            dgvProductCondition.Font = New Font("Segoe UI", 11)
            dgvProductCondition.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
            dgvProductCondition.ReadOnly = True
            dgvProductCondition.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            dgvProductCondition.MultiSelect = False
            ' dgvProductCondition.AllowUserToResizeColumns = False
            dgvProductCondition.AllowUserToAddRows = False
            dgvProductCondition.AllowUserToDeleteRows = False
            dgvProductCondition.Columns(0).Width = 100
            dgvProductCondition.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
            dgvProductCondition.Columns(1).Width = 250
            dgvProductCondition.Columns(2).Width = 160
            dgvProductCondition.Columns(3).Width = 160
            dgvProductCondition.Columns(4).Width = 160
            dgvProductCondition.Columns(5).Width = 180
            dgvProductCondition.DataSource = _tableCatalagoSalida
        End Using
    End Sub

    Private Sub GetDataRequisition()
        Using objsql As New Requisiciones_SQLServer
            If EncargadoBodega Then
                _tableRequisiciones = objsql.Inventory_GetRequisitionsHeaderEncargadoBodega(_Id_DepartmentAlmacen, "")
            ElseIf IsJefe = True Then
                _tableRequisiciones = objsql.Inventory_GetRequisitionsHeaderJefeBodega(_Id_DepartmentAlmacen, "")
            Else
                If (SeleccHistEmpleado = True) Then
                    _tableRequisiciones = objsql.Inventory_GetRequisitionsHeaderEmployee(IdUnidadHist)
                Else
                    _tableRequisiciones = objsql.Inventory_GetRequisitionsHeader(_Id_DepartmentAlmacen)
                End If
            End If

            dgvRequisiciones.AutoGenerateColumns = False
            dgvRequisiciones.Font = New Font("Segoe UI", 11)

            dgvRequisiciones.ReadOnly = True
            dgvRequisiciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            dgvRequisiciones.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
            dgvRequisiciones.MultiSelect = False
            ' dgvRequisiciones.AllowUserToResizeColumns = False
            dgvRequisiciones.AllowUserToAddRows = False
            dgvRequisiciones.AllowUserToDeleteRows = False

            dgvRequisiciones.DataSource = _tableRequisiciones
            ColocarImagenRequisicion()
        End Using
    End Sub

    Private Sub ColocarImagenRequisicion()
        Try
            dgvRequisiciones.Columns(0).Width = 20
            dgvRequisiciones.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
            dgvRequisiciones.Columns(2).Width = 200
            dgvRequisiciones.Columns(3).Width = 320
            dgvRequisiciones.Columns(4).Width = 400
            dgvRequisiciones.Columns(5).Width = 450
            dgvRequisiciones.Columns(6).Width = 300
            'dgvRequisiciones.Columns(5).Width = 160
            For Each item As DataGridViewRow In dgvRequisiciones.Rows
                Try
                    item.Cells("image").Value = Nothing
                    If (item.Cells("Is_Approved").Value.ToString = "En Proceso") Then
                        item.Cells("image").Value = Anaranjado_Bandera
                    ElseIf (item.Cells("Is_Approved").Value.ToString = "En Revisión") Then
                        item.Cells("image").Value = Amarillo_bandera
                    ElseIf (item.Cells("Is_Approved").Value.ToString = "Aprobado") Then
                        item.Cells("image").Value = Morado_Bandera
                    ElseIf (item.Cells("Is_Approved").Value.ToString = "Denegado") Then
                        item.Cells("image").Value = Roja_Bandera
                    Else
                        item.Cells("image").Value = Verde_Bandera
                    End If

                Catch ex As Exception

                End Try
            Next
        Catch ex As Exception

        End Try

    End Sub


    Private Sub GetDataRequisitionEncargadoBodega(ByVal Busquedad As String)
        Using objsql As New Requisiciones_SQLServer

            If (SeleccHistEmpleado = True) Then
                _tableRequisiciones = objsql.Inventory_GetRequisitionsHeaderEmployee(IdUnidadHist)
            Else
                _tableRequisiciones = objsql.Inventory_GetRequisitionsHeaderEncargadoBodega(_Id_DepartmentAlmacen, Busquedad)
            End If


            dgvRequisiciones.AutoGenerateColumns = False
            dgvRequisiciones.Font = New Font("Segoe UI", 11)

            dgvRequisiciones.ReadOnly = True
            dgvRequisiciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            dgvRequisiciones.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
            dgvRequisiciones.MultiSelect = False
            ' dgvRequisiciones.AllowUserToResizeColumns = False
            dgvRequisiciones.AllowUserToAddRows = False
            dgvRequisiciones.AllowUserToDeleteRows = False

            dgvRequisiciones.DataSource = _tableRequisiciones
            ColocarImagenRequisicion()
        End Using
    End Sub

    Private Sub GetDataRequisitionJefeBodega(ByVal Busquedad As String)
        Using objsql As New Requisiciones_SQLServer

            _tableRequisiciones = objsql.Inventory_GetRequisitionsHeaderJefeBodega(_Id_DepartmentAlmacen, Busquedad)


            dgvRequisiciones.AutoGenerateColumns = False
            dgvRequisiciones.Font = New Font("Segoe UI", 11)

            dgvRequisiciones.ReadOnly = True
            dgvRequisiciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            dgvRequisiciones.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
            dgvRequisiciones.MultiSelect = False
            ' dgvRequisiciones.AllowUserToResizeColumns = False
            dgvRequisiciones.AllowUserToAddRows = False
            dgvRequisiciones.AllowUserToDeleteRows = False

            dgvRequisiciones.DataSource = _tableRequisiciones
            ColocarImagenRequisicion()
        End Using
    End Sub


    Private Sub GetDataRequisition(ByVal busqueda As String, Optional tipo As Integer = 0)
        Using objsql As New Requisiciones_SQLServer
            _tableRequisiciones = objsql.Inventory_GetRequisitionsHeader(busqueda, tipo, _Id_DepartmentAlmacen)
            dgvRequisiciones.AutoGenerateColumns = False
            dgvRequisiciones.Font = New Font("Segoe UI", 11)

            dgvRequisiciones.ReadOnly = True
            dgvRequisiciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            dgvRequisiciones.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
            dgvRequisiciones.MultiSelect = False
            ' dgvRequisiciones.AllowUserToResizeColumns = False
            dgvRequisiciones.AllowUserToAddRows = False
            dgvRequisiciones.AllowUserToDeleteRows = False

            dgvRequisiciones.DataSource = _tableRequisiciones
            ColocarImagenRequisicion()
        End Using
    End Sub

    Private Sub GetDataRasones()
        Using objsql As New Operaciones_SQLServer
            _tableReason = objsql.ERP_SP_Inventory_GetReason()
            dgvReason.AutoGenerateColumns = False
            dgvReason.Font = New Font("Segoe UI", 11)
            dgvReason.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
            dgvReason.ReadOnly = True
            dgvReason.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            dgvReason.MultiSelect = False
            'dgvReason.AllowUserToResizeColumns = False
            dgvReason.AllowUserToAddRows = False
            dgvReason.AllowUserToDeleteRows = False
            dgvReason.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
            dgvReason.Columns(2).Width = 500
            dgvReason.DataSource = _tableReason
        End Using
    End Sub
    Private Sub GetDataRasones(ByVal busqueda As String)
        Using objsql As New Operaciones_SQLServer
            _tableReason = objsql.ERP_SP_Inventory_GetReason(busqueda)
            dgvReason.AutoGenerateColumns = False
            dgvReason.Font = New Font("Segoe UI", 11)
            dgvReason.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
            dgvReason.ReadOnly = True
            dgvReason.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            dgvReason.MultiSelect = False
            'dgvReason.AllowUserToResizeColumns = False
            dgvReason.AllowUserToAddRows = False
            dgvReason.AllowUserToDeleteRows = False
            dgvReason.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
            dgvReason.Columns(2).Width = 500
            dgvReason.DataSource = _tableReason
        End Using
    End Sub

    Private Sub cmdReporteCatalogoCliente_Click(sender As Object, e As EventArgs) Handles cmdReporteCatalogoCliente.Click
        Dim Ds As New EPD_SatelliteERPDataSet_Inventario
        Dim dt As New EPD_SatelliteERPDataSet_InventarioTableAdapters.ERP_SP_Inventory_Report_CatalogCustomersTableAdapter
        dt.Connection.ConnectionString = objOperacion.DataCenter
        Dim dt1 As DataTable
        dt.Fill(Ds.ERP_SP_Inventory_Report_CatalogCustomers)
        dt1 = Ds.Tables(0)
        Using objPartidaContable As New Financiero_ReportViewer(dt1, "CatalogoClientes", "epd_SatelliteERP.Inventario_CatalogClientes.rdlc")
            objPartidaContable.ShowDialog()
        End Using
    End Sub

    Private Sub cmdReporteProveedores_Click(sender As Object, e As EventArgs) Handles cmdReporteProveedores.Click
        Dim Ds As New EPD_SatelliteERPDataSet_Inventario
        Dim dt As New EPD_SatelliteERPDataSet_InventarioTableAdapters.ERP_SP_Inventory_Report_CatalogCustomersTableAdapter
        dt.Connection.ConnectionString = objOperacion.DataCenter
        Dim dt1 As DataTable
        dt.Fill(Ds.ERP_SP_Inventory_Report_CatalogCustomers)
        dt1 = Ds.Tables(0)
        Using objPartidaContable As New Financiero_ReportViewer(dt1, "CatalogoClientes", "epd_SatelliteERP.Inventario_ReporteProveedores.rdlc")
            objPartidaContable.ShowDialog()
        End Using
    End Sub

    Private Sub cmdCatalogoClienteFinanciero_Click(sender As Object, e As EventArgs) Handles cmdCatalogoClienteFinanciero.Click
        Dim Ds As New EPD_SatelliteERPDataSet_Inventario
        Dim dt As New EPD_SatelliteERPDataSet_InventarioTableAdapters.ERP_SP_Inventory_Report_CatalogueFinancialCustomersTableAdapter
        dt.Connection.ConnectionString = objOperacion.DataCenter
        Dim dt1 As DataTable
        dt.Fill(Ds.ERP_SP_Inventory_Report_CatalogueFinancialCustomers)
        dt1 = Ds.Tables("ERP_SP_Inventory_Report_CatalogueFinancialCustomers")
        dt1.TableName = "Datos"
        Using objPartidaContable As New Financiero_ReportViewer(dt1, "Datos", "epd_SatelliteERP.Inventario_CatalogFinanciero.rdlc")
            objPartidaContable.ShowDialog()
        End Using
    End Sub

    Private Sub cmdFichaCliente_Click(sender As Object, e As EventArgs) Handles cmdFichaCliente.Click
        Dim Ds As New EPD_SatelliteERPDataSet_Inventario
        Dim dt As New EPD_SatelliteERPDataSet_InventarioTableAdapters.ERP_SP_Inventory_Report_Report_CustomerCardTableAdapter
        dt.Connection.ConnectionString = objOperacion.DataCenter
        Dim dt1 As DataTable
        dt.Fill(Ds.ERP_SP_Inventory_Report_Report_CustomerCard)
        dt1 = Ds.Tables("ERP_SP_Inventory_Report_Report_CustomerCard")
        Using objPartidaContable As New Financiero_ReportViewer(dt1, "DatosCliente", "epd_SatelliteERP.Inventario_CatalogClienteCard.rdlc")
            objPartidaContable.ShowDialog()
        End Using
    End Sub

    Private Sub cmdPrecioPublico_Click(sender As Object, e As EventArgs) Handles cmdPrecioPublico.Click
        Dim Ds As New EPD_SatelliteERPDataSet_Inventario
        Dim dt As New EPD_SatelliteERPDataSet_InventarioTableAdapters.ERP_SP_Inventory_Report_PriceListTableAdapter
        dt.Connection.ConnectionString = objOperacion.DataCenter
        Dim dt1 As DataTable
        dt.Fill(Ds.ERP_SP_Inventory_Report_PriceList)
        dt1 = Ds.Tables("ERP_SP_Inventory_Report_PriceList")
        Using objPartidaContable As New Financiero_ReportViewer(dt1, "DatosPrecioPublico", "epd_SatelliteERP.Inventario_ListaPreciosPublico.rdlc")
            objPartidaContable.ShowDialog()
        End Using
    End Sub

    Private Sub cmdSugeridosCompra_Click(sender As Object, e As EventArgs) Handles cmdSugeridosCompra.Click
        Dim Ds As New EPD_SatelliteERPDataSet_Inventario
        Dim dt As New EPD_SatelliteERPDataSet_InventarioTableAdapters.ERP_SP_Inventory_Report_PriceListTableAdapter
        dt.Connection.ConnectionString = objOperacion.DataCenter
        Dim dt1 As DataTable
        dt.Fill(Ds.ERP_SP_Inventory_Report_PriceList)
        dt1 = Ds.Tables("ERP_SP_Inventory_Report_PriceList")
        Using objPartidaContable As New Financiero_ReportViewer(dt1, "DatosSugerenciaCompras", "epd_SatelliteERP.Inventario_ListaMasimoMinimos.rdlc")
            objPartidaContable.ShowDialog()
        End Using
    End Sub

    Private Sub cmdListadoExistencias_Click(sender As Object, e As EventArgs) Handles cmdListadoExistencias.Click
        Dim Ds As New EPD_SatelliteERPDataSet_Inventario
        Dim dt As New EPD_SatelliteERPDataSet_InventarioTableAdapters.ERP_SP_Inventory_Report_PriceListTableAdapter
        dt.Connection.ConnectionString = objOperacion.DataCenter
        Dim dt1 As DataTable
        dt.Fill(Ds.ERP_SP_Inventory_Report_PriceList)
        dt1 = Ds.Tables("ERP_SP_Inventory_Report_PriceList")
        Using objPartidaContable As New Financiero_ReportViewer(dt1, "DatosExistencias", "epd_SatelliteERP.Inventario_ListaExistencias.rdlc")
            objPartidaContable.ShowDialog()
        End Using
    End Sub

    Private Sub cmdListadoExistenciasValorizado_Click(sender As Object, e As EventArgs) Handles cmdListadoExistenciasValorizado.Click
        Dim Ds As New EPD_SatelliteERPDataSet_Inventario
        Dim dt As New EPD_SatelliteERPDataSet_InventarioTableAdapters.ERP_SP_Inventory_Report_PriceListTableAdapter
        dt.Connection.ConnectionString = objOperacion.DataCenter
        Dim dt1 As DataTable
        dt.Fill(Ds.ERP_SP_Inventory_Report_PriceList)
        dt1 = Ds.Tables("ERP_SP_Inventory_Report_PriceList")
        Using objPartidaContable As New Financiero_ReportViewer(dt1, "DatosExistenciasValorizada", "epd_SatelliteERP.Inventario_ListaExistenciasValorizado.rdlc")
            objPartidaContable.ShowDialog()
        End Using
    End Sub

    Private Sub cmdListadoCostoUtilidades_Click(sender As Object, e As EventArgs) Handles cmdListadoCostoUtilidades.Click
        Dim Ds As New EPD_SatelliteERPDataSet_Inventario
        Dim dt As New EPD_SatelliteERPDataSet_InventarioTableAdapters.ERP_SP_Inventory_Report_PriceListTableAdapter
        dt.Connection.ConnectionString = objOperacion.DataCenter
        Dim dt1 As DataTable
        dt.Fill(Ds.ERP_SP_Inventory_Report_PriceList)
        dt1 = Ds.Tables("ERP_SP_Inventory_Report_PriceList")
        Using objPartidaContable As New Financiero_ReportViewer(dt1, "DatosCostosUtilidades", "epd_SatelliteERP.Inventario_ListaCostosUtilidades.rdlc")
            objPartidaContable.ShowDialog()
        End Using
    End Sub

    Private Sub cmdUnidadesVendidas_Click(sender As Object, e As EventArgs) Handles cmdUnidadesVendidas.Click
        Dim Ds As New EPD_SatelliteERPDataSet_Inventario
        Dim dt As New EPD_SatelliteERPDataSet_InventarioTableAdapters.ERP_SP_Inventory_Report_PriceListTableAdapter
        dt.Connection.ConnectionString = objOperacion.DataCenter
        Dim dt1 As DataTable
        dt.Fill(Ds.ERP_SP_Inventory_Report_PriceList)
        dt1 = Ds.Tables("ERP_SP_Inventory_Report_PriceList")
        Using objPartidaContable As New Financiero_ReportViewer(dt1, "DatosUnidadesVendidas", "epd_SatelliteERP.Inventario_ListaUnidadesVendidas.rdlc")
            objPartidaContable.ShowDialog()
        End Using
    End Sub

    Private Sub cmdKardex_Click(sender As Object, e As EventArgs) Handles cmdKardex.Click
        Dim Ds As New EPD_SatelliteERPDataSet_Inventario
        Dim dt As New EPD_SatelliteERPDataSet_InventarioTableAdapters.ERP_SP_Inventory_Report_KardexTableAdapter
        dt.Connection.ConnectionString = objOperacion.DataCenter
        Dim dt1 As DataTable
        dt.Fill(Ds.ERP_SP_Inventory_Report_Kardex)
        dt1 = Ds.Tables("ERP_SP_Inventory_Report_Kardex")
        Using objPartidaContable As New Financiero_ReportViewer(dt1, "DatosKardex", "epd_SatelliteERP.Inventario_Kardex.rdlc")
            objPartidaContable.ShowDialog()
        End Using
    End Sub

    Private Sub cmdEstadoCuentaCliente_Click(sender As Object, e As EventArgs) Handles cmdEstadoCuentaCliente.Click
        Dim Ds As New EPD_SatelliteERPDataSet_Inventario
        Dim dt As New EPD_SatelliteERPDataSet_InventarioTableAdapters.ERP_SP_Inventory_Report_AccountStatusTableAdapter
        dt.Connection.ConnectionString = objOperacion.DataCenter
        Dim dt1 As DataTable
        dt.Fill(Ds.ERP_SP_Inventory_Report_AccountStatus)
        dt1 = Ds.Tables("ERP_SP_Inventory_Report_AccountStatus")
        Using objPartidaContable As New Financiero_ReportViewer(dt1, "Datos", "epd_SatelliteERP.Inventario_EstadoCuentaCliente.rdlc")
            objPartidaContable.ShowDialog()
        End Using
    End Sub

    Private Sub cmdPumpRegister_Click(sender As Object, e As EventArgs) Handles cmdPumpRegister.Click
        Dim Ds As New EPD_SatelliteERPDataSet_Inventario
        Dim dt As New EPD_SatelliteERPDataSet_InventarioTableAdapters.ERP_SP_Inventory_Report_PumpReadingsTableAdapter
        dt.Connection.ConnectionString = objOperacion.DataCenter
        Dim dt1 As DataTable
        dt.Fill(Ds.ERP_SP_Inventory_Report_PumpReadings)
        dt1 = Ds.Tables("ERP_SP_Inventory_Report_PumpReadings")
        Using objPartidaContable As New Financiero_ReportViewer(dt1, "Datos", "epd_SatelliteERP.Inventario_PumpReadings.rdlc")
            objPartidaContable.ShowDialog()
        End Using
    End Sub

    Private Sub cmdDryStockSales_Click(sender As Object, e As EventArgs) Handles cmdDryStockSales.Click
        Dim Ds As New EPD_SatelliteERPDataSet_Inventario
        Dim dt As New EPD_SatelliteERPDataSet_InventarioTableAdapters.ERP_SP_Inventory_Report_DryStockSalesSectionTableAdapter
        dt.Connection.ConnectionString = objOperacion.DataCenter
        Dim dt1 As DataTable
        dt.Fill(Ds.ERP_SP_Inventory_Report_DryStockSalesSection)
        dt1 = Ds.Tables("ERP_SP_Inventory_Report_DryStockSalesSection")
        Using objPartidaContable As New Financiero_ReportViewer(dt1, "Datos", "epd_SatelliteERP.Inventario_DryStockSales.rdlc")
            objPartidaContable.ShowDialog()
        End Using
    End Sub

    Private Sub cmdWetStockSalesSection_Click(sender As Object, e As EventArgs) Handles cmdWetStockSalesSection.Click
        Dim Ds As New EPD_SatelliteERPDataSet_Inventario
        Dim dt As New EPD_SatelliteERPDataSet_InventarioTableAdapters.ERP_SP_Inventory_Report_WetStockSalesSectionTableAdapter
        dt.Connection.ConnectionString = objOperacion.DataCenter
        Dim dt1 As DataTable
        dt.Fill(Ds.ERP_SP_Inventory_Report_WetStockSalesSection)
        dt1 = Ds.Tables("ERP_SP_Inventory_Report_WetStockSalesSection")
        Using objPartidaContable As New Financiero_ReportViewer(dt1, "Datos", "epd_SatelliteERP.Inventario_WetStockSalesSection.rdlc")
            objPartidaContable.ShowDialog()
        End Using
    End Sub

    Private Sub cmdPaidInsSection_Click(sender As Object, e As EventArgs) Handles cmdPaidInsSection.Click
        Dim Ds As New EPD_SatelliteERPDataSet_Inventario
        Dim dt As New EPD_SatelliteERPDataSet_InventarioTableAdapters.ERP_SP_Inventory_Report_PaidInsSectionTableAdapter
        dt.Connection.ConnectionString = objOperacion.DataCenter
        Dim dt1 As DataTable
        dt.Fill(Ds.ERP_SP_Inventory_Report_PaidInsSection)
        dt1 = Ds.Tables("ERP_SP_Inventory_Report_PaidInsSection")
        Using objPartidaContable As New Financiero_ReportViewer(dt1, "Datos", "epd_SatelliteERP.Inventario_PaidInSection.rdlc")
            objPartidaContable.ShowDialog()
        End Using
    End Sub

    Private Sub cmdTenderCollectionSection_Click(sender As Object, e As EventArgs) Handles cmdTenderCollectionSection.Click
        Dim Ds As New EPD_SatelliteERPDataSet_Inventario
        Dim dt As New EPD_SatelliteERPDataSet_InventarioTableAdapters.ERP_SP_Inventory_Report_TenderCollectionSectionTableAdapter
        dt.Connection.ConnectionString = objOperacion.DataCenter
        Dim dt1 As DataTable
        dt.Fill(Ds.ERP_SP_Inventory_Report_TenderCollectionSection)
        dt1 = Ds.Tables("ERP_SP_Inventory_Report_TenderCollectionSection")
        Using objPartidaContable As New Financiero_ReportViewer(dt1, "Datos", "epd_SatelliteERP.Inventario_TenderCollectionSection.rdlc")
            objPartidaContable.ShowDialog()
        End Using
    End Sub

    Private Sub cmdFuelReconciliation_Click(sender As Object, e As EventArgs) Handles cmdFuelReconciliation.Click
        Dim Ds As New EPD_SatelliteERPDataSet_Inventario
        Dim dt As New EPD_SatelliteERPDataSet_InventarioTableAdapters.ERP_SP_Inventory_Report_FuelReconciliationTableAdapter
        dt.Connection.ConnectionString = objOperacion.DataCenter
        Dim dt1 As DataTable
        dt.Fill(Ds.ERP_SP_Inventory_Report_FuelReconciliation)
        dt1 = Ds.Tables("ERP_SP_Inventory_Report_FuelReconciliation")
        Using objPartidaContable As New Financiero_ReportViewer(dt1, "Datos", "epd_SatelliteERP.Inventario_FuelReconciliationSection.rdlc")
            objPartidaContable.ShowDialog()
        End Using
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Using Objcreate As New ERP_ClientesCuentasPorCobrar
            'La siget solicito que todo fuera ingreso de proveedores
            _TypeCustomer = 2
            If _TypeCustomer = 1 Then
                Objcreate.TipoConsulta = ERP_ClientesCuentasPorCobrar.Proceso.Clientes
                Objcreate.OpcionSeleccionada = ERP_ClientesCuentasPorCobrar.Funcion.Actualizar
            ElseIf _TypeCustomer = 2 Then
                Objcreate.TipoConsulta = ERP_ClientesCuentasPorCobrar.Proceso.Proveedores
                Objcreate.OpcionSeleccionada = ERP_ClientesCuentasPorCobrar.Funcion.Agregar
            End If
            If Objcreate.ShowDialog() = DialogResult.OK Then
                GetClientes()
            End If
        End Using
    End Sub

    Private Sub GetClientes(Optional Busquedad As String = "")
        _tableCustomer = objGeneric.GetCustomerClientList(Data_Id_Company, 1, -1, -1, 1, Busquedad)
        DGVClientes.AutoGenerateColumns = False
        DGVClientes.ReadOnly = True
        DGVClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DGVClientes.MultiSelect = False
        DGVClientes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
        DGVClientes.AllowUserToAddRows = False
        DGVClientes.AllowUserToDeleteRows = False
        'Ancho de la columna  Email_Contact
        ' DGVClientes
        DGVClientes.Columns(0).Width = 100
        DGVClientes.Columns(1).Width = 100
        DGVClientes.Columns(2).Width = 130
        DGVClientes.Columns(3).Width = 150
        DGVClientes.Columns(4).Width = 400
        DGVClientes.Columns(5).Width = 400
        DGVClientes.Columns(7).Width = 250
        DGVClientes.Columns(18).Width = 400
        DGVClientes.Columns(19).Width = 200
        DGVClientes.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        'Justificacion
        DGVClientes.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
        DGVClientes.DataSource = _tableCustomer

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles cmdUpdateClients.Click
        Dim resul As DialogResult = Nothing
        If Not DGVClientes.CurrentRow Is Nothing Then
            Using ObjUpdate As New ERP_ClientesCuentasPorCobrar
                If _TypeCustomer = 1 Then
                    ObjUpdate.TipoConsulta = ERP_ClientesCuentasPorCobrar.Proceso.Clientes
                ElseIf _TypeCustomer = 2 Then
                    ObjUpdate.TipoConsulta = ERP_ClientesCuentasPorCobrar.Proceso.Proveedores
                End If
                ObjUpdate.OpcionSeleccionada = ERP_ClientesCuentasPorCobrar.Funcion.Actualizar
                Try
                    ObjUpdate.IsBigContributter = DGVClientes.CurrentRow.Cells("Is_BigContributor").Value.ToString
                    ObjUpdate.Id_Customer = DGVClientes.CurrentRow.Cells("Id_Customer").Value.ToString
                    ObjUpdate.id_Company = _ID_Company.ToString
                    ObjUpdate.Id_TypeCustomer_FK = DGVClientes.CurrentRow.Cells("Id_TypeCustomer_FK").Value.ToString
                    ObjUpdate.Id_Minicipality_FK = DGVClientes.CurrentRow.Cells("Id_Minicipality_FK").Value.ToString
                    ObjUpdate.Id_EmployeelContact_FK = DGVClientes.CurrentRow.Cells("Id_EmployeelContact_FK").Value.ToString
                    ObjUpdate.Id_CompanyCategory_Fk = DGVClientes.CurrentRow.Cells("Id_CompanyCategory_Fk").Value.ToString
                    ObjUpdate.Is_Exempt = DGVClientes.CurrentRow.Cells("Is_Exempt").Value.ToString
                    ObjUpdate.Is_LegalEntity = DGVClientes.CurrentRow.Cells("Is_LegalEntity").Value.ToString
                    ObjUpdate.Business_Name = DGVClientes.CurrentRow.Cells("Business_Name").Value.ToString
                    ObjUpdate.Commercial_Name = DGVClientes.CurrentRow.Cells("Commercial_Name1").Value.ToString
                    ObjUpdate.First_Name = DGVClientes.CurrentRow.Cells("First_Name").Value.ToString
                    ObjUpdate.Last_Name = DGVClientes.CurrentRow.Cells("Last_Name").Value.ToString
                    ObjUpdate.Address = DGVClientes.CurrentRow.Cells("Address").Value.ToString
                    ObjUpdate.OfficePhone = DGVClientes.CurrentRow.Cells("OfficePhone").Value.ToString
                    ObjUpdate.Email_Contact = DGVClientes.CurrentRow.Cells("Email_Contact").Value.ToString
                    ObjUpdate.Identity_DocumentNumber = DGVClientes.CurrentRow.Cells("numerodui").Value.ToString
                    ObjUpdate.Tax_Registration_Number = DGVClientes.CurrentRow.Cells("Tax_Registration_Number").Value.ToString
                    ObjUpdate.Tax_Identification_Number = DGVClientes.CurrentRow.Cells("Tax_Identification_Number").Value.ToString
                    ObjUpdate.Is_Supplier = DGVClientes.CurrentRow.Cells("Is_Supplier").Value.ToString
                    ObjUpdate.Turning_Company = DGVClientes.CurrentRow.Cells("Turning_Company").Value.ToString

                    ObjUpdate.IDSIC = DGVClientes.CurrentRow.Cells("IDSIC").ValueType.ToString
                    ObjUpdate.DepemdeSIC = ConvertToInteger(DGVClientes.CurrentRow.Cells("DepemdeSIC").Value.ToString)
                    ObjUpdate.Observaciones = DGVClientes.CurrentRow.Cells("Observaciones").Value.ToString

                    resul = ObjUpdate.ShowDialog()
                Catch ex As ArgumentException
                    MessageBox.Show("Ha ocurrido un error al mostrar la información", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Using objLog As New ProcessGeneral
                        objLog.AlmacenarLog(5, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                    End Using
                Catch ex As Exception
                    MessageBox.Show("Ha ocurrido un error al mostrar la información", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Using objLog As New ProcessGeneral
                        objLog.AlmacenarLog(5, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                    End Using
                End Try
            End Using
            If resul = System.Windows.Forms.DialogResult.OK Then
                GetClientes()
            End If
        End If
    End Sub

    Private Function ConvertToInteger(ByRef value As String) As Integer
        If String.IsNullOrEmpty(value) Then
            value = "0"
        End If
        If (value = False) Then
            value = "0"
        End If
        Return Convert.ToInt32(value)
    End Function

    Private Sub Button13_Click(sender As Object, e As EventArgs)
        Using ob As New ERP_Inventory_HeaderImputsAndOutputs
            If ob.ShowDialog = DialogResult.OK Then
                Using obj As New ERP_Inventory_Out
                    obj.ID_Header = ob.ID_Header
                    obj.ShowDialog()
                End Using
            End If
        End Using
    End Sub

    Private Sub cmdAddProduct_Click(sender As Object, e As EventArgs) Handles cmdAddProduct.Click
        Using objAdd As New ERP_Inventory_CreateProduct
            objAdd.OpcionSeleccionada = ERP_Inventory_CreateProduct.funcion.Agregar
            If Not objAdd.ShowDialog() = DialogResult.Cancel Then
                GetDataProductos()
            End If
        End Using
    End Sub

    Private Sub cmdUpdateProduct_Click(sender As Object, e As EventArgs) Handles cmdUpdateProduct.Click
        If Not DGW_Product.CurrentRow Is Nothing Then
            Using objupdate As New ERP_Inventory_CreateProduct
                objupdate.OpcionSeleccionada = ERP_Inventory_CreateProduct.funcion.Actualizar
                objupdate.Id_Product = DGW_Product.CurrentRow.Cells("Id_Product").Value
                objupdate.ID_Provider = DGW_Product.CurrentRow.Cells("Id_Customer_FK").Value
                objupdate._ProductoName = DGW_Product.CurrentRow.Cells("Name_Product").Value
                objupdate.Description = DGW_Product.CurrentRow.Cells("Descripcion").Value.ToString

                objupdate.BarCode = DGW_Product.CurrentRow.Cells("BarCode").Value
                objupdate.Id_ProductCondition = DGW_Product.CurrentRow.Cells("Id_ProductCondition_FK").Value
                objupdate.ID_Unit = DGW_Product.CurrentRow.Cells("Id_UnitMeasure_FK").Value
                objupdate.ID_Category = DGW_Product.CurrentRow.Cells("ID_Category_FK").Value
                objupdate.ID_Line = DGW_Product.CurrentRow.Cells("Id_Line_FK").Value
                objupdate.ID_Marca = DGW_Product.CurrentRow.Cells("ID_Marca").Value
                objupdate.PurchasePrice = DGW_Product.CurrentRow.Cells("Price_LastPpurchase").Value
                objupdate.Price_Average = DGW_Product.CurrentRow.Cells("Price_Average").Value
                objupdate.PriceSale = DGW_Product.CurrentRow.Cells("Price_Sale").Value
                objupdate.IsExempt = DGW_Product.CurrentRow.Cells("IsExempt").Value
                objupdate.IS_FinalProduct = DGW_Product.CurrentRow.Cells("IS_FinalProduct").Value
                objupdate.IS_RawMaterial = DGW_Product.CurrentRow.Cells("IS_RawMaterial").Value
                objupdate.IS_Recipe = DGW_Product.CurrentRow.Cells("IS_Recipe").Value
                objupdate.IS_Mixed = DGW_Product.CurrentRow.Cells("IS_Mixed").Value
                objupdate.base64String = DGW_Product.CurrentRow.Cells("Picture").Value
                objupdate.IS_SubProduct = DGW_Product.CurrentRow.Cells("SubProduct").Value
                objupdate.IS_SubProduct = DGW_Product.CurrentRow.Cells("SubProduct").Value
                objupdate.Conversion = DGW_Product.CurrentRow.Cells("ID_ConversionUnit").Value
                objupdate._NumberPurchase = DGW_Product.CurrentRow.Cells("Number_Purchase").Value
                If Not objupdate.ShowDialog() = DialogResult.Cancel Then
                    GetDataProductos()
                End If
            End Using

        End If
    End Sub

    Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
        If Not DGW_Product.CurrentRow Is Nothing Then
            Dim ID_Product As Long = DGW_Product.CurrentRow.Cells("Id_Product").Value
            Dim NameProduct As String = DGW_Product.CurrentRow.Cells("Name_Product").Value
            Dim resp As Integer = 0
            If MessageBox.Show("¿Está seguro que desea eliminar el producto: " & NameProduct & "?", "Información", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
                Using objDelete As New Operaciones_SQLServer
                    resp = objDelete.SP_ERP_Inventory_DeleteProducts(_ID_Company, ID_Product)
                End Using
                If resp = 1 Then
                    MessageBox.Show("Registro eliminado exitosamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    GetDataProductos()
                Else
                    MessageBox.Show("Ocurrió un error al eliminar el producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        End If
    End Sub

    Private Sub cmdAddRecipe_Click(sender As Object, e As EventArgs) Handles cmdAddRecipe.Click
        Using objAdd As New ERP_Inventory_CreateRecipe
            objAdd.TypeProcess = ERP_Inventory_CreateRecipe.Process.add
            objAdd.ShowDialog()
        End Using
    End Sub

    Private Sub cmdUpdateRecipe_Click(sender As Object, e As EventArgs) Handles cmdUpdateRecipe.Click
        If Not dgvRecipes.CurrentRow Is Nothing Then
            Using objUpdate As New ERP_Inventory_CreateRecipe
                objUpdate.TypeProcess = ERP_Inventory_CreateRecipe.Process.update
                objUpdate.ID_Product = dgvRecipes.CurrentRow.Cells("ID_Producto").Value
                If objUpdate.ShowDialog() = DialogResult.OK Then
                    GetDataProductosRecipes()
                End If
            End Using
        End If
    End Sub

    Private Sub cmdChange_Click(sender As Object, e As EventArgs) Handles cmdChange.Click
        OcultarEntradas()
        getStowage()
    End Sub

    Private Sub cmdEntrada_Click(sender As Object, e As EventArgs) Handles cmdEntrada.Click
        Dim row As DataRow
        Using objProveedores As New Generic_SeleccionarCliente
            objProveedores.Is_CustumerProvider = True
            If objProveedores.ShowDialog() = DialogResult.OK Then
                Using objAdd As New ERP_Inventory_DialogProductEntry
                    row = objProveedores.rowSelection
                    objAdd.MostrarFinalizacion = True
                    objAdd.Name_Company = row("Name_Company")
                    objAdd.ID_Customer = row("Id_Customer")
                    objAdd.ID_Stowage = _ID_Stowages
                    If objAdd.ShowDialog() = DialogResult.OK Then
                        GetDataEntradas("")
                    End If
                End Using
            End If
        End Using
    End Sub

    Private Sub cmdOutput_Click(sender As Object, e As EventArgs) Handles cmdOutput.Click
        OcultarEntradas()
        Using objOutput As New ERP_Inventory_Dialog_InventoryDepartures
            objOutput.ID_Stowage = _ID_Stowages
            objOutput.EstadoSalida = "Nuevo"
            If objOutput.ShowDialog() = DialogResult.OK Then
                GetDataProductosStowage(_ID_Stowages)
            End If
        End Using
    End Sub

    Private Sub Button6_Click_1(sender As Object, e As EventArgs) Handles btnAddMarcas.Click
        Using objAdd As New ERP_Mantenimiento_Marcas
            objAdd.Id_Company_FK = _ID_Company
            objAdd.id_Marca = 0
            If objAdd.ShowDialog() = DialogResult.OK Then
                GetDataMarcas()
            End If
        End Using
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles btnUpdateMarcas.Click
        Using objAdd As New ERP_Mantenimiento_Marcas
            objAdd.Title = "Modificar Marca"
            objAdd.Id_Company_FK = _ID_Company
            objAdd.id_Marca = dgvMarcas.CurrentRow.Cells("ID").Value
            Try
                objAdd.Name_Marcas = dgvMarcas.CurrentRow.Cells("Description").Value
            Catch ex As Exception
                objAdd.Name_Marcas = ""
            End Try
            Try
                objAdd.is_products = dgvMarcas.CurrentRow.Cells("Is_Products").Value
            Catch ex As Exception
                objAdd.is_products = False
            End Try
            Try
                objAdd.is_fixedAssets = dgvMarcas.CurrentRow.Cells("is_FixedAssets").Value
            Catch ex As Exception
                objAdd.is_fixedAssets = False
            End Try

            If objAdd.ShowDialog() = DialogResult.OK Then
                GetDataMarcas()
            End If
        End Using
    End Sub

    Private Sub btnDeleteMarcas_Click(sender As Object, e As EventArgs) Handles btnDeleteMarcas.Click
        If Not dgvMarcas.CurrentRow Is Nothing Then
            Dim ID_Marca As Long = dgvMarcas.CurrentRow.Cells("ID").Value
            Dim NameMarca As String = dgvMarcas.CurrentRow.Cells("Description").Value
            Dim resp As Integer = 0
            If MessageBox.Show("¿Está seguro que desea eliminar la Marca: " & NameMarca & "?", "Información", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
                Using objDelete As New Generic_SQLServer
                    resp = objDelete.DeleteMarca(_ID_Company, ID_Marca)
                End Using
                If resp = 1 Then
                    MessageBox.Show("Registro eliminado exitosamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    GetDataMarcas()
                Else
                    MessageBox.Show("Ocurrió un error al eliminar la Marca", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Using objAdd As New ERP_Mantenimiento_Category
            objAdd.Id_Company_FK = _ID_Company
            objAdd.id_Categoria = 0
            If objAdd.ShowDialog() = DialogResult.OK Then
                GetDataCategorias()
            End If
        End Using
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Using objAdd As New ERP_Mantenimiento_Category
            objAdd.Title = "Modificar Categorias"
            objAdd.Id_Company_FK = _ID_Company
            objAdd.id_Categoria = dgvCategorias.CurrentRow.Cells("ID_Cat").Value
            objAdd.Name_Categorias = dgvCategorias.CurrentRow.Cells("Description_Cat").Value
            objAdd.ledgerAccountNumber = dgvCategorias.CurrentRow.Cells("ledgerAccountproduct").Value.ToString
            objAdd.ledgerCodeProduct = dgvCategorias.CurrentRow.Cells("ledgercodeproduct").Value.ToString
            If objAdd.ShowDialog() = DialogResult.OK Then
                GetDataCategorias()
            End If
        End Using
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        If Not dgvCategorias.CurrentRow Is Nothing Then
            Dim ID_Categorias As Long = dgvCategorias.CurrentRow.Cells("ID_Cat").Value
            Dim NameCategorias As String = dgvCategorias.CurrentRow.Cells("Description_Cat").Value
            Dim resp As Integer = 0
            If MessageBox.Show("¿Está seguro que desea eliminar la Categoría: " & NameCategorias & "?", "Información", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
                Using objDelete As New Generic_SQLServer
                    resp = objDelete.DeleteCategoria(_ID_Company, ID_Categorias)
                End Using
                If resp = 1 Then
                    MessageBox.Show("Registro eliminado exitosamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    GetDataCategorias()
                Else
                    MessageBox.Show("Ocurrió un error al eliminar la Categoría", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        End If
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Using objAdd As New ERP_Mantenimiento_Line
            objAdd.Id_Company_FK = _ID_Company
            objAdd.id_Categoria = 0
            If objAdd.ShowDialog() = DialogResult.OK Then
                GetDataLineas()
            End If
        End Using
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Using objAdd As New ERP_Mantenimiento_Line
            objAdd.Title = "Modificar Linea"
            objAdd.Id_Company_FK = _ID_Company
            objAdd.id_Linea = dgvLineas.CurrentRow.Cells("ID_Line").Value
            objAdd.Name_Linea = dgvLineas.CurrentRow.Cells("Description_Line").Value
            objAdd.id_Categoria = dgvLineas.CurrentRow.Cells("IDCategory").Value
            If objAdd.ShowDialog() = DialogResult.OK Then
                GetDataLineas()
            End If
        End Using
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        If Not dgvLineas.CurrentRow Is Nothing Then
            Dim ID_Lineas As Long = dgvLineas.CurrentRow.Cells("ID_Line").Value
            Dim NameLineas As String = dgvLineas.CurrentRow.Cells("Description_Line").Value
            Dim resp As Integer = 0
            If MessageBox.Show("¿Está seguro que desea eliminar la Línea: " & NameLineas & "?", "Información", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
                Using objDelete As New Generic_SQLServer
                    resp = objDelete.DeleteLinea(_ID_Company, ID_Lineas)
                End Using
                If resp = 1 Then
                    MessageBox.Show("Registro eliminado exitosamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    GetDataLineas()
                Else
                    MessageBox.Show("Ocurrió un error al eliminar la Línea", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        End If
    End Sub

    Private Sub Button6_Click_2(sender As Object, e As EventArgs) Handles Button6.Click
        Using objAdd As New ERP_Mantenimiento_Bodegas
            objAdd.Id_Company_FK = _ID_Company
            objAdd.id_Bodega = 0
            If objAdd.ShowDialog() = DialogResult.OK Then
                GetDataBodegas()
            End If
        End Using
    End Sub

    Private Sub Button7_Click_1(sender As Object, e As EventArgs) Handles Button7.Click
        Using objAdd As New ERP_Mantenimiento_Bodegas
            objAdd.Title = "Modificar Bodega"
            objAdd.Id_Company_FK = _ID_Company
            objAdd.id_Bodega = dgvBodegas.CurrentRow.Cells("ID_Stowage").Value
            objAdd.Name_Bodega = dgvBodegas.CurrentRow.Cells("DescriptionBod").Value
            objAdd.id_Ubicacion = dgvBodegas.CurrentRow.Cells("IDLocationBod").Value
            If objAdd.ShowDialog() = DialogResult.OK Then
                GetDataBodegas()
            End If
        End Using
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If Not dgvBodegas.CurrentRow Is Nothing Then
            Dim ID_Bodegas As Long = dgvBodegas.CurrentRow.Cells("ID_Stowage").Value
            Dim NameBodegas As String = dgvBodegas.CurrentRow.Cells("DescriptionBod").Value
            Dim resp As Integer = 0
            If MessageBox.Show("¿Está seguro que desea eliminar la Bodega: " & NameBodegas & "?", "Información", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
                Using objDelete As New Generic_SQLServer
                    resp = objDelete.DeleteStowages(_ID_Company, ID_Bodegas)
                End Using
                If resp = 1 Then
                    MessageBox.Show("Registro eliminado exitosamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    GetDataBodegas()
                Else
                    MessageBox.Show("Ocurrió un error al eliminar la Bodega", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        End If
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        Using objAdd As New ERP_Mantenimiento_Ubicacion
            objAdd.Id_Company_FK = _ID_Company
            objAdd.id_Location = 0
            If objAdd.ShowDialog() = DialogResult.OK Then
                GetDataUbicacion()
            End If
        End Using
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        Using objAdd As New ERP_Mantenimiento_Ubicacion
            objAdd.Title = "Modificar Ubicacion"
            objAdd.Id_Company_FK = _ID_Company
            objAdd.id_Department = dgvUbicacion.CurrentRow.Cells("id_Departament").Value
            objAdd.id_Location = dgvUbicacion.CurrentRow.Cells("ID_Ubicacion").Value
            objAdd.Name_Location = dgvUbicacion.CurrentRow.Cells("DescriptionLocation").Value
            objAdd.id_Municipality = dgvUbicacion.CurrentRow.Cells("IDMunicipality").Value
            If objAdd.ShowDialog() = DialogResult.OK Then
                GetDataUbicacion()
            End If
        End Using
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        If Not dgvUbicacion.CurrentRow Is Nothing Then
            Dim ID_Ubicacion As Long = dgvUbicacion.CurrentRow.Cells("ID_Ubicacion").Value
            Dim NameUbicacion As String = dgvUbicacion.CurrentRow.Cells("DescriptionLocation").Value
            Dim resp As Integer = 0
            If MessageBox.Show("¿Está seguro que desea eliminar la Ubicación: " & NameUbicacion & "?", "Información", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
                Using objDelete As New Generic_SQLServer
                    resp = objDelete.DeleteLocation(_ID_Company, ID_Ubicacion)
                End Using
                If resp = 1 Then
                    MessageBox.Show("Registro eliminado exitosamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    GetDataUbicacion()
                Else
                    MessageBox.Show("Ocurrió un error al eliminar la Ubicación", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        End If
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        Using objAdd As New ERP_Mantenimiento_OutletCatalog
            objAdd.Id_Company_FK = _ID_Company
            objAdd.id_OutletCatalog = 0
            If objAdd.ShowDialog() = DialogResult.OK Then
                GetDataCatalagoSalida()
            End If
        End Using
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        Using objAdd As New ERP_Mantenimiento_OutletCatalog
            objAdd.Title = "Modificar Ubicacion"
            objAdd.Id_Company_FK = _ID_Company
            objAdd.id_OutletCatalog = dgvCatalogoSalida.CurrentRow.Cells("id_outlet").Value
            Try
                objAdd.IS_Entry = dgvCatalogoSalida.CurrentRow.Cells("IS_Entry").Value
            Catch ex As Exception
                objAdd.IS_Entry = 0
            End Try
            objAdd.Name_OutletCatalog = dgvCatalogoSalida.CurrentRow.Cells("DescriptionOutlet").Value
            If objAdd.ShowDialog() = DialogResult.OK Then
                GetDataCatalagoSalida()
            End If
        End Using
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        If Not dgvCatalogoSalida.CurrentRow Is Nothing Then
            Dim ID_OutletCatalog As Long = dgvCatalogoSalida.CurrentRow.Cells("id_outlet").Value
            Dim NameOutletCatalog As String = dgvCatalogoSalida.CurrentRow.Cells("DescriptionOutlet").Value
            Dim resp As Integer = 0
            If MessageBox.Show("¿Está seguro que desea eliminar el Catálogo de Salida: " & NameOutletCatalog & "?", "Información", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
                Using objDelete As New Operaciones_SQLServer
                    resp = objDelete.SP_ERP_Inventory_DeleteOutletCatalog(_ID_Company, ID_OutletCatalog)
                End Using
                If resp = 1 Then
                    MessageBox.Show("Registro eliminado exitosamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    GetDataCatalagoSalida()
                Else
                    MessageBox.Show("Ocurrió un error al eliminar el Catálago de Salida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        End If
    End Sub

    Private Sub cmdClientes_CatalogoClientes_Click(sender As Object, e As EventArgs) Handles cmdClientes_CatalogoClientes.Click
        _MostrarFiltro = False
        Dim Ds As New EPD_SatelliteERPDataSet_Inventario
        Dim dt As New EPD_SatelliteERPDataSet_InventarioTableAdapters.ERP_SP_Inventory_Report_CatalogCustomersTableAdapter

        Dim dt1 As DataTable
        dt.Fill(Ds.ERP_SP_Inventory_Report_CatalogCustomers)
        dt1 = Ds.Tables(0)
        Using objPartidaContable As New Financiero_ReportViewer(dt1, "CatalogoClientes", "epd_SatelliteERP.Inventario_CatalogClientes.rdlc")
            objPartidaContable.ShowDialog()
        End Using
    End Sub

    Private Sub cmdClientes_CatalogoFinanciero_Click(sender As Object, e As EventArgs) Handles cmdClientes_CatalogoFinanciero.Click
        Dim dt As New DataTable
        _MostrarFiltro = False
        Using objsql As New Financiero_SQLServer
            dt = objsql.ERP_SP_Inventory_Report_CatalogueFinancialCustomers
        End Using
        Using objPartidaContable As New Financiero_ReportViewer(dt, "Data", "epd_SatelliteERP.Reporte_CatalogoFinanciero.rdlc")
            objPartidaContable.ShowDialog()
        End Using
    End Sub

    Private Sub cmdClientes_FichaCliente_Click(sender As Object, e As EventArgs) Handles cmdClientes_FichaCliente.Click
        _MostrarFiltro = False
        Dim Ds As New EPD_SatelliteERPDataSet_Inventario
        Dim dt As New EPD_SatelliteERPDataSet_InventarioTableAdapters.ERP_SP_Inventory_Report_Report_CustomerCardTableAdapter
        Dim dt1 As DataTable
        dt.Fill(Ds.ERP_SP_Inventory_Report_Report_CustomerCard)
        dt1 = Ds.Tables("ERP_SP_Inventory_Report_Report_CustomerCard")
        Using objPartidaContable As New Financiero_ReportViewer(dt1, "DatosCliente", "epd_SatelliteERP.Inventario_CatalogClienteCard.rdlc")
            objPartidaContable.ShowDialog()
        End Using
    End Sub



    Private Sub cmdProductos_ExistenciaValorizada_Click(sender As Object, e As EventArgs)
        Dim Ds As New EPD_SatelliteERPDataSet_Inventario
        Dim dt As New EPD_SatelliteERPDataSet_InventarioTableAdapters.ERP_SP_Inventory_Report_PriceListTableAdapter
        Dim dt1 As DataTable
        dt.Fill(Ds.ERP_SP_Inventory_Report_PriceList)
        dt1 = Ds.Tables("ERP_SP_Inventory_Report_PriceList")
        Using objPartidaContable As New Financiero_ReportViewer(dt1, "DatosExistenciasValorizada", "epd_SatelliteERP.Inventario_ListaExistenciasValorizado.rdlc")
            objPartidaContable.ShowDialog()
        End Using
    End Sub

    Private Sub cmdProductos_PrecioPublico_Click(sender As Object, e As EventArgs) Handles cmdProductos_PrecioPublico.Click
        Dim Ds As New EPD_SatelliteERPDataSet_Inventario
        Dim dt As New EPD_SatelliteERPDataSet_InventarioTableAdapters.ERP_SP_Inventory_Report_PriceListTableAdapter
        Dim dt1 As DataTable
        dt.Fill(Ds.ERP_SP_Inventory_Report_PriceList)
        dt1 = Ds.Tables("ERP_SP_Inventory_Report_PriceList")
        Using objPartidaContable As New Financiero_ReportViewer(dt1, "DatosPrecioPublico", "epd_SatelliteERP.Inventario_ListaPreciosPublico.rdlc")
            objPartidaContable.ShowDialog()
        End Using
    End Sub

    Private Sub cmdProductos_SugeridoCompra_Click(sender As Object, e As EventArgs) Handles cmdProductos_SugeridoCompra.Click
        Dim Ds As New EPD_SatelliteERPDataSet_Inventario
        Dim dt As New EPD_SatelliteERPDataSet_InventarioTableAdapters.ERP_SP_Inventory_Report_PriceListTableAdapter
        Dim dt1 As DataTable
        dt.Fill(Ds.ERP_SP_Inventory_Report_PriceList)
        dt1 = Ds.Tables("ERP_SP_Inventory_Report_PriceList")
        Using objPartidaContable As New Financiero_ReportViewer(dt1, "DatosSugerenciaCompras", "epd_SatelliteERP.Inventario_ListaMasimoMinimos.rdlc")
            objPartidaContable.ShowDialog()
        End Using
    End Sub

    Private Sub cmdProductos_ListaExistencias_Click(sender As Object, e As EventArgs) Handles cmdProductos_ListaExistencias.Click
        Dim Ds As New EPD_SatelliteERPDataSet_Inventario
        Dim dt As New EPD_SatelliteERPDataSet_InventarioTableAdapters.ERP_SP_Inventory_Report_PriceListTableAdapter
        Dim dt1 As DataTable
        dt.Fill(Ds.ERP_SP_Inventory_Report_PriceList)
        dt1 = Ds.Tables("ERP_SP_Inventory_Report_PriceList")
        Using objPartidaContable As New Financiero_ReportViewer(dt1, "DatosExistencias", "epd_SatelliteERP.Inventario_ListaExistencias.rdlc")
            objPartidaContable.ShowDialog()
        End Using
    End Sub

    Private Sub cmdProductos_ListaExistenciasVal_Click(sender As Object, e As EventArgs) Handles cmdProductos_ListaExistenciasVal.Click

        Dim Ds As New EPD_SatelliteERPDataSet_Inventario
        Dim dt As New EPD_SatelliteERPDataSet_InventarioTableAdapters.ERP_SP_Inventory_Report_PriceListTableAdapter
        Dim dt1 As DataTable
        REM dt.Connection.ConnectionString = "Data Source=DESKTOP-S8O0798\SQLEXPRESS;Initial Catalog=EPD_SatelliteERP;integrated security=false; user id= sa; password=123456789"
        dt.Fill(Ds.ERP_SP_Inventory_Report_PriceList)
        dt1 = Ds.Tables("ERP_SP_Inventory_Report_PriceList")
        Using objPartidaContable As New Financiero_ReportViewer(dt1, "DatosExistenciasValorizada", "epd_SatelliteERP.Inventario_ListaExistenciasValorizado.rdlc")
            objPartidaContable.ShowDialog()
        End Using
    End Sub

    Private Sub cmdProductos_ListaCostosUtilidades_Click(sender As Object, e As EventArgs) Handles cmdProductos_ListaCostosUtilidades.Click
        Dim Ds As New EPD_SatelliteERPDataSet_Inventario
        Dim dt As New EPD_SatelliteERPDataSet_InventarioTableAdapters.ERP_SP_Inventory_Report_PriceListTableAdapter
        Dim dt1 As DataTable
        dt.Fill(Ds.ERP_SP_Inventory_Report_PriceList)
        dt1 = Ds.Tables("ERP_SP_Inventory_Report_PriceList")
        Using objPartidaContable As New Financiero_ReportViewer(dt1, "DatosCostosUtilidades", "epd_SatelliteERP.Inventario_ListaCostosUtilidades.rdlc")
            objPartidaContable.ShowDialog()
        End Using
    End Sub

    Private Sub cmdProductos_UnidadesVendidas_Click(sender As Object, e As EventArgs) Handles cmdProductos_UnidadesVendidas.Click
        Dim Ds As New EPD_SatelliteERPDataSet_Inventario
        Dim dt As New EPD_SatelliteERPDataSet_InventarioTableAdapters.ERP_SP_Inventory_Report_PriceListTableAdapter
        Dim dt1 As DataTable
        dt.Fill(Ds.ERP_SP_Inventory_Report_PriceList)
        dt1 = Ds.Tables("ERP_SP_Inventory_Report_PriceList")
        Using objPartidaContable As New Financiero_ReportViewer(dt1, "DatosUnidadesVendidas", "epd_SatelliteERP.Inventario_ListaUnidadesVendidas.rdlc")
            objPartidaContable.ShowDialog()
        End Using
    End Sub

    Private Sub cmdMaximosYMinimos_Click(sender As Object, e As EventArgs) Handles cmdMaximosYMinimos.Click
        OcultarEntradas()
        If Not dgvProductsStowage.CurrentRow Is Nothing Then
            Dim ID_Producto As Long = dgvProductsStowage.CurrentRow.Cells("Id_ProductoS").Value
            Dim NameProduct As String = dgvProductsStowage.CurrentRow.Cells("Name_Productos").Value
            Dim Maximo As Double = dgvProductsStowage.CurrentRow.Cells("top_Product").Value
            Dim Minimo As Double = dgvProductsStowage.CurrentRow.Cells("Least_Product").Value
            Dim dt As New DataTable
            Dim resp As Integer = 0
            Using obj As New ERP_Inventory_UpdateMaximusAndMinimous
                obj.NameProduct = NameProduct
                obj.Maximo = Maximo
                obj.Minimo = Minimo
                If obj.ShowDialog = DialogResult.OK Then
                    Maximo = obj.Maximo
                    Minimo = obj.Minimo
                    Using objSQL As New Operaciones_SQLServer
                        dt = objSQL.SP_ERP_Inventory_UpdateMaximusAndMinimous(_ID_Stowages, ID_Producto, Maximo, Minimo)
                    End Using
                    If Not dt Is Nothing Then
                        If dt.Rows.Count > 0 Then
                            resp = dt.Rows(0).Item(0)
                        End If
                    End If

                    If resp = 1 Then
                        MessageBox.Show("Proceso realizado exitosamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        GetDataProductosStowage(_ID_Stowages)
                    Else
                        MessageBox.Show("Ocurrió un error al realizar el proceso ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End If
            End Using
        End If
    End Sub

    Private Sub cmdAnimals_Click(sender As Object, e As EventArgs) Handles cmdAnimals.Click
        Using obj As New Inventario_AnimalesBodega
            obj.ID_Bodega = _ID_Stowages
            obj.NameBodega = _Name_Stowage
            obj.ShowDialog()
        End Using
    End Sub

    Private Sub cmdSubProductos_Click(sender As Object, e As EventArgs) Handles cmdSubProductos.Click
        If Not dgvProductsStowage.CurrentRow Is Nothing Then
            If dgvProductsStowage.CurrentRow.Cells("IS_SubProduct").Value Then
                Using obj As New ERP_Inventory_SubProducts
                    obj.ID_Product = dgvProductsStowage.CurrentRow.Cells("Id_ProductoS").Value
                    obj.ID_Bodega = _ID_Stowages
                    obj.ShowDialog()
                End Using
            Else
                MessageBox.Show("El producto seleccionado no aplica como SubProducto", "Información", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            End If

        End If
    End Sub

    Private Sub cmdIndicador_Click(sender As Object, e As EventArgs) Handles cmdIndicador.Click
        If Not dgvProductsStowage.CurrentRow Is Nothing Then
            Using obj As New ERP_Inventory_StatusProduct
                obj.TipoProceso = ERP_Inventory_StatusProduct.Process.Inventario
                obj.ID_Bodega = _ID_Stowages
                obj.ShowDialog()
            End Using
        End If
    End Sub

    Private Sub ModuloInventarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        tcMain.TabPages.Remove(Reportes)
        tcMain.TabPages.Remove(Recetas)
        _Id_DepartmentAlmacen = _Id_DepartmentGlobal
        Using objSql2 As New Generic_SQLServer
            OpcionesMenu = objSql2.GetAccessMenu(_UserSQL)
            If (OpcionesMenu.Rows.Count > 0) Then
                For Each DataInfo As DataRow In OpcionesMenu.Rows
                    If (DataInfo("rolUser").ToString.ToUpper = "In_RequisicionesAllDepartment".ToUpper) Then
                        _Id_DepartmentAlmacen = 0
                    End If
                Next
            End If


        End Using

        If (tabControl > 0) Then
            tcMain.SelectedIndex = tabControl
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnListMarcas.Click
        Dim dt As New DataTable
        Using objSQLBodega As New Generic_SQLServer
            dt = objSQLBodega.Inventory_GetInventoryMarcaReport(Data_Id_Company)
        End Using

        Using objPartidaContable As New Financiero_ReportViewer(dt, "Marcas", "epd_SatelliteERP.Reports_InventoryMarca.rdlc")
            objPartidaContable.ShowDialog()
        End Using
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim dt As New DataTable
        Using objSQLBodega As New Generic_SQLServer
            dt = objSQLBodega.Inventory_GetInventoryCategoriaReport(Data_Id_Company)
        End Using

        Using objPartidaContable As New Financiero_ReportViewer(dt, "Categorias", "epd_SatelliteERP.Reports_InventoryCategory.rdlc")
            objPartidaContable.ShowDialog()
        End Using
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim Ds As New EPD_SatelliteERPDataSet_ReportsInventory
        Dim dt As New EPD_SatelliteERPDataSet_ReportsInventoryTableAdapters.ERP_SP_ReportInventoryLineTableAdapter
        Dim dt1 As DataTable
        dt.Fill(Ds.ERP_SP_ReportInventoryLine, Data_Id_Company)
        dt1 = Ds.Tables(1)
        Using objPartidaContable As New Financiero_ReportViewer(dt1, "DSInventoryLine", "epd_SatelliteERP.Reports_InventoryLine.rdlc")
            objPartidaContable.ShowDialog()
        End Using
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'Dim Ds As New EPD_SatelliteERPDataSet_ReportsInventory
        'Dim dt As New EPD_SatelliteERPDataSet_ReportsInventoryTableAdapters.ERP_SP_ReportInventoryLineTableAdapter
        'Dim dt1 As DataTable
        'dt.Fill(Ds.ERP_SP_ReportInventoryLine, Data_Id_Company)
        'dt1 = Ds.Tables(1)
        'Using objPartidaContable As New Financiero_ReportViewer(dt1, "DSInventoryLine", "epd_SatelliteERP.Reports_InventoryLine.rdlc")
        '    objPartidaContable.ShowDialog()
        'End Using

        Dim dt As New DataTable
        Using objSQLBodega As New Bodega_SQLServer
            dt = objSQLBodega.Inventory_GetInventoryStowageReport(Data_Id_Company)
        End Using

        Using objPartidaContable As New Financiero_ReportViewer(dt, "DataSet1", "epd_SatelliteERP.Reports_InventoryBodega.rdlc")
            objPartidaContable.ShowDialog()
        End Using


    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Dim Ds As New EPD_SatelliteERPDataSet_ReportsInventory
        Dim dt As New EPD_SatelliteERPDataSet_ReportsInventoryTableAdapters.ERP_SP_ReportInventoryLocationTableAdapter
        Dim dt1 As DataTable
        dt.Fill(Ds.ERP_SP_ReportInventoryLocation, Data_Id_Company)
        dt1 = Ds.Tables(2)
        Using objPartidaContable As New Financiero_ReportViewer(dt1, "DSInventoryLocation", "epd_SatelliteERP.Reports_InventoryLocation.rdlc")
            objPartidaContable.ShowDialog()
        End Using
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Dim Ds As New EPD_SatelliteERPDataSet_ReportsInventory
        Dim dt As New EPD_SatelliteERPDataSet_ReportsInventoryTableAdapters.ERP_SP_ReportInventoryOutletCatalogTableAdapter
        Dim dt1 As DataTable
        dt.Fill(Ds.ERP_SP_ReportInventoryOutletCatalog, Data_Id_Company)
        dt1 = Ds.Tables(4)
        Using objPartidaContable As New Financiero_ReportViewer(dt1, "DSOutletCatalog", "epd_SatelliteERP.Reports_InventoryOutletCatalog.rdlc")
            objPartidaContable.ShowDialog()
        End Using
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Dim days As Integer
        Using obj As New Financiero_DocumentoFiscalDigiteNumero
            If obj.ShowDialog() = DialogResult.OK Then
                days = obj.NumeroFactura
            Else
                Exit Sub
            End If
        End Using

        Dim Ds As New EPD_SatelliteERPDataSet4
        Dim dt As New EPD_SatelliteERPDataSet4TableAdapters.SP_Prod_Report_ScheduledGeneralProjectionTableAdapter
        Dim dt1 As DataTable
        dt.Fill(Ds.SP_Prod_Report_ScheduledGeneralProjection, days)
        dt1 = Ds.Tables(0)
        Using objPartidaContable As New Financiero_ReportViewer(dt1, "DSProyecciones", "epd_SatelliteERP.Reports_InventoryProyecciones.rdlc")
            objPartidaContable.ShowDialog()
        End Using
    End Sub

    Private Sub btnSearchMarcas_Click(sender As Object, e As EventArgs) Handles btnSearchMarcas.Click
        Dim days As Integer
        Using obj As New Financiero_DocumentoFiscalDigiteNumero
            If obj.ShowDialog() = DialogResult.OK Then
                days = obj.NumeroFactura
            Else
                Exit Sub
            End If
        End Using
    End Sub

    Private Sub cmdFormulasTotal_Click(sender As Object, e As EventArgs) Handles cmdFormulasTotal.Click
        If Not dgvRecipes.CurrentRow Is Nothing Then
            Dim dt As New DataTable
            Using objSQL As New Operaciones_SQLServer
                dt = objSQL.ERP_SP_Inventory_Report_Formulas(0)
            End Using
            ' dt1 = Ds.Tables("ERP_SP_Inventory_Report_AccountStatus")
            Using obj As New Financiero_ReportViewer(dt, "DataSet1", "epd_SatelliteERP.Inventario_Formulas.rdlc")
                obj.WindowState = FormWindowState.Maximized
                obj.ShowDialog()
            End Using

        End If
    End Sub

    Private Sub cmdFormulasSeleccion_Click(sender As Object, e As EventArgs) Handles cmdFormulasSeleccion.Click
        If Not dgvRecipes.CurrentRow Is Nothing Then
            Dim ID_Recipe As Long = dgvRecipes.CurrentRow.Cells("ID_Producto").Value
            Dim dt As New DataTable
            Using objSQL As New Operaciones_SQLServer
                dt = objSQL.ERP_SP_Inventory_Report_Formulas(ID_Recipe)
            End Using
            ' dt1 = Ds.Tables("ERP_SP_Inventory_Report_AccountStatus")
            Using obj As New Financiero_ReportViewer(dt, "DataSet1", "epd_SatelliteERP.Inventario_Formulas.rdlc")
                obj.WindowState = FormWindowState.Maximized
                obj.ShowDialog()
            End Using

        End If
    End Sub

    Private Sub btnCrearTipoCliente_Click(sender As Object, e As EventArgs) Handles btnCrearTipoCliente.Click
        Using objAdd As New ERP_Mantenimiento_ClientType
            objAdd.Id_Company_FK = _ID_Company
            objAdd.id_OutletCatalog = 0
            If objAdd.ShowDialog() = DialogResult.OK Then
                GetDataCustomerType()
            End If
        End Using
    End Sub

    Private Sub btnActualizarTipoCliente_Click(sender As Object, e As EventArgs) Handles btnActualizarTipoCliente.Click
        Using objAdd As New ERP_Mantenimiento_ClientType
            objAdd.Title = "Modificar Tipo de Proveedor"
            objAdd.Id_Company_FK = _ID_Company
            objAdd.id_OutletCatalog = dgvCustomerType.CurrentRow.Cells("Id_TypeCustomer").Value
            objAdd.Name_OutletCatalog = dgvCustomerType.CurrentRow.Cells("DescriptionTypeCustomer").Value
            objAdd.TypeSystem = dgvCustomerType.CurrentRow.Cells("TypeSystem").Value
            If objAdd.ShowDialog() = DialogResult.OK Then
                GetDataCustomerType()
            End If
        End Using
    End Sub

    Private Sub btnEliminarTipoCliente_Click(sender As Object, e As EventArgs) Handles btnEliminarTipoCliente.Click
        If Not dgvCustomerType.CurrentRow Is Nothing Then
            Dim ID_CustomerType As Long = dgvCustomerType.CurrentRow.Cells("Id_TypeCustomer").Value
            Dim NameOutletCatalog As String = dgvCustomerType.CurrentRow.Cells("DescriptionTypeCustomer").Value
            Dim resp As String = ""
            If MessageBox.Show("¿Está seguro que desea eliminar el Tipo de Proveedor: " & NameOutletCatalog & "?", "Información", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
                Using objDelete As New Generic_SQLServer
                    resp = objDelete.ERP_Generic_SP_DelTypeCustomer(ID_CustomerType, _ID_Company)
                End Using
                If resp = "OK" Then
                    MessageBox.Show("Registro eliminado exitosamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    GetDataCustomerType()
                Else
                    MessageBox.Show("Ocurrió un error al eliminar el Tipo de Proveedor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        End If
    End Sub

    Private Sub cmdCrearGiroGeneral_Click(sender As Object, e As EventArgs) Handles cmdCrearGiroGeneral.Click
        Using objAdd As New ERP_Mantenimiento_GiroGeneral
            objAdd.Id_Company_FK = _ID_Company
            objAdd.id_OutletCatalog = 0
            If objAdd.ShowDialog() = DialogResult.OK Then
                GetDataGiroGeneral()
            End If
        End Using
    End Sub

    Private Sub cmdActualizarGiroGeneral_Click(sender As Object, e As EventArgs) Handles cmdActualizarGiroGeneral.Click
        Using objAdd As New ERP_Mantenimiento_GiroGeneral
            objAdd.Title = "Modificar Tipo de Proveedor"
            objAdd.Id_Company_FK = _ID_Company
            objAdd.id_OutletCatalog = dgvGiroGeneral.CurrentRow.Cells("ID_CompanyCategory").Value
            objAdd.Name_OutletCatalog = dgvGiroGeneral.CurrentRow.Cells("Description_CompanyCategory").Value
            If objAdd.ShowDialog() = DialogResult.OK Then
                GetDataGiroGeneral()
            End If
        End Using
    End Sub

    Private Sub cmdEliminarGiroGeneral_Click(sender As Object, e As EventArgs) Handles cmdEliminarGiroGeneral.Click
        If Not dgvGiroGeneral.CurrentRow Is Nothing Then
            Dim ID_CustomerType As Long = dgvGiroGeneral.CurrentRow.Cells("ID_CompanyCategory").Value
            Dim NameOutletCatalog As String = dgvGiroGeneral.CurrentRow.Cells("Description_CompanyCategory").Value
            Dim resp As String = ""
            If MessageBox.Show("¿Está seguro que desea eliminar el Tipo de Proveedor: " & NameOutletCatalog & "?", "Información", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
                Using objDelete As New Generic_SQLServer
                    resp = objDelete.ERP_Generic_SP_DelCompanyCategory(ID_CustomerType, _ID_Company)
                End Using
                If resp = "OK" Then
                    MessageBox.Show("Registro eliminado exitosamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    GetDataGiroGeneral()
                Else
                    MessageBox.Show("Ocurrió un error al eliminar el Tipo de Proveedor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        End If
    End Sub
    Private Sub cmdCreateUnitMeasure_Click(sender As Object, e As EventArgs) Handles cmdCreateUnitMeasure.Click
        Using objAdd As New ERP_Mantenimiento_MeasureUnit
            objAdd.Id_Company_FK = _ID_Company
            objAdd.id_UnitMeasure = 0
            If objAdd.ShowDialog() = DialogResult.OK Then
                GetDataUnitMeasure()
            End If
        End Using
    End Sub

    Private Sub cmdUpdateUnitMeasure_Click(sender As Object, e As EventArgs) Handles cmdUpdateUnitMeasure.Click
        Using objAdd As New ERP_Mantenimiento_MeasureUnit
            objAdd.Title = "Modificar Unidad de Medida"
            objAdd.Id_Company_FK = _ID_Company
            objAdd.id_UnitMeasure = dgvUnidadMedida.CurrentRow.Cells("Id_UnitMeasure").Value
            objAdd.Name_UnitMeasure = dgvUnidadMedida.CurrentRow.Cells("Name_UnitMeasure").Value
            objAdd.Name_UnitConversion = dgvUnidadMedida.CurrentRow.Cells("Unit_Conversion").Value
            If objAdd.ShowDialog() = DialogResult.OK Then
                GetDataUnitMeasure()
            End If
        End Using
    End Sub

    Private Sub cmdDeleteUnitMeasure_Click(sender As Object, e As EventArgs) Handles cmdDeleteUnitMeasure.Click
        If Not dgvUnidadMedida.CurrentRow Is Nothing Then
            Dim ID_CustomerType As Long = dgvUnidadMedida.CurrentRow.Cells("Id_UnitMeasure").Value
            Dim NameOutletCatalog As String = dgvUnidadMedida.CurrentRow.Cells("Name_UnitMeasure").Value
            Dim resp As String = ""
            If MessageBox.Show("¿Está seguro que desea eliminar Unidad de Medida: " & NameOutletCatalog & "?", "Información", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
                Using objDelete As New Generic_SQLServer
                    resp = objDelete.ERP_Generic_SP_DelUnitMeasure(ID_CustomerType, _ID_Company)
                End Using
                If resp = "OK" Then
                    MessageBox.Show("Registro eliminado exitosamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    GetDataUnitMeasure()
                Else
                    MessageBox.Show("Ocurrió un error al eliminar Unidad de Medida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        End If
    End Sub

    Private Sub cmdCreateProductCondition_Click(sender As Object, e As EventArgs) Handles cmdCreateProductCondition.Click
        Using objAdd As New ERP_Mantenimiento_ProductCondition
            objAdd.Id_Company_FK = _ID_Company
            objAdd.id_ProductCondition = 0
            If objAdd.ShowDialog() = DialogResult.OK Then
                GetDataProductContidion()
            End If
        End Using
    End Sub

    Private Sub cmdUpdateProductCondition_Click(sender As Object, e As EventArgs) Handles cmdUpdateProductCondition.Click
        Using objAdd As New ERP_Mantenimiento_ProductCondition
            objAdd.Title = "Modificar Tipo de Producto"
            objAdd.Id_Company_FK = _ID_Company
            objAdd.id_ProductCondition = dgvProductCondition.CurrentRow.Cells("id_ProductCondition").Value
            objAdd.Name_ProductCondition = dgvProductCondition.CurrentRow.Cells("Name_Condition").Value
            If objAdd.ShowDialog() = DialogResult.OK Then
                GetDataProductContidion()
            End If
        End Using
    End Sub

    Private Sub cmdDeleteProductCondition_Click(sender As Object, e As EventArgs) Handles cmdDeleteProductCondition.Click
        If Not dgvProductCondition.CurrentRow Is Nothing Then
            Dim ID_CustomerType As Long = dgvProductCondition.CurrentRow.Cells("id_ProductCondition").Value
            Dim NameOutletCatalog As String = dgvProductCondition.CurrentRow.Cells("Name_Condition").Value
            Dim resp As String = ""
            If MessageBox.Show("¿Está seguro que desea eliminar el Tipo de Producto: " & NameOutletCatalog & "?", "Información", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
                Using objDelete As New Generic_SQLServer
                    resp = objDelete.SP_ERP_Generic_DelProductCondition(ID_CustomerType, _ID_Company)
                End Using
                If resp = "OK" Then
                    MessageBox.Show("Registro eliminado exitosamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    GetDataProductContidion()
                Else
                    MessageBox.Show("Ocurrió un error al eliminar el Tipo de Producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        End If
    End Sub

    Private Sub cmdClientes_CatalogoProveedores_Click(sender As Object, e As EventArgs) Handles cmdClientes_CatalogoProveedores.Click
        Dim dt As New DataTable
        Dim valor As Long = 0

        Using objsql As New Operaciones_SQLServer
            dt = objsql.ERP_Generic_GetCustomerMaster_ProviderReport()
        End Using

        Using objPartidaContable As New Financiero_ReportViewer(dt, "DataSet1", "epd_SatelliteERP.Inventario_CatalogProveedores.rdlc")
            objPartidaContable.WindowState = FormWindowState.Maximized
            objPartidaContable.ShowDialog()
        End Using
    End Sub

    Private Sub cmdDeleteRecipe_Click(sender As Object, e As EventArgs) Handles cmdDeleteRecipe.Click
        If Not dgvRecipes.CurrentRow Is Nothing Then
            Dim ID_Recipe As Long = dgvRecipes.CurrentRow.Cells("ID_Producto").Value
            Dim name As String = dgvRecipes.CurrentRow.Cells("DataGridViewTextBoxColumn17").Value
            If MessageBox.Show("¿Está seguro que desea eliminar la receta " & name & "?", "Información", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
                Using objsql As New Generic_SQLServer
                    If objsql.ERP_Inventory_GetProducts_RecipesDelete(ID_Recipe) = 1 Then
                        MessageBox.Show("Receta eliminada exitosamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        GetDataProductosRecipes()
                    Else
                        MessageBox.Show("Ocurrio un error al eliminar la receta", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            End If
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Using objAdd As New ERP_Inventary_Modelo

            If objAdd.ShowDialog() = DialogResult.OK Then
                GetDataModelo()
            End If
        End Using
    End Sub

    Private Sub Button13_Click_1(sender As Object, e As EventArgs) Handles Button13.Click
        Using objAdd As New ERP_Inventary_Modelo
            objAdd.id = dgv_modelo.CurrentRow.Cells("ID_").Value
            objAdd.descripcion = dgv_modelo.CurrentRow.Cells("Description_").Value
            objAdd.marca_FK = dgv_modelo.CurrentRow.Cells("id_inventory_marca").Value
            objAdd.OpcionSeleccionada = ERP_Inventary_Modelo.Funcion.Actualizar
            If objAdd.ShowDialog() = DialogResult.OK Then
                GetDataModelo()
            End If
        End Using
    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        If Not dgv_modelo.CurrentRow Is Nothing Then
            Dim ID As Long = dgv_modelo.CurrentRow.Cells("ID_").Value
            If MessageBox.Show("¿Está seguro que desea eliminar el modelo?", "Información", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
                Using objsql As New Generic_SQLServer
                    If objsql.ERP_SP_DelModelo(ID) = "OK" Then
                        MessageBox.Show("Modelo eliminado exitosamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        GetDataModelo()
                    Else
                        MessageBox.Show("Ocurrió un error al eliminar la receta", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            End If
        End If
    End Sub

    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click
        'Dim Ds As New EPD_SatelliteERPDataSet_ReportsInventory
        'Dim dt As New EPD_SatelliteERPDataSet_ReportsInventoryTableAdapters.ERP_SP_ReportInventoryLineTableAdapter
        'Dim dt1 As DataTable
        'dt.Fill(Ds.ERP_SP_ReportInventoryLine, Data_Id_Company)
        'dt1 = Ds.Tables(1)
        'Using objPartidaContable As New Financiero_ReportViewer(dt1, "DSInventoryLine", "epd_SatelliteERP.Reports_InventoryLine.rdlc")
        '    objPartidaContable.ShowDialog()
        'End Using

        Dim dt As New DataTable
        Using objSQLBodega As New Generic_SQLServer
            dt = objSQLBodega.GetModelo(_ID_Company)
        End Using

        Using objPartidaContable As New Financiero_ReportViewer(dt, "DSModelos", "epd_SatelliteERP.Reports_InventoryModelo.rdlc")
            objPartidaContable.ShowDialog()
        End Using


    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscarMarcas.Click
        Using obj As New ERP_Financiero_BuscarActivo
            If obj.ShowDialog = DialogResult.OK Then
                GetDataMarcas(obj.busqueda)
            Else
                GetDataMarcas()
            End If
        End Using
    End Sub

    Private Sub btnBuscarCategoria_Click(sender As Object, e As EventArgs) Handles btnBuscarCategoria.Click
        Using obj As New ERP_Financiero_BuscarActivo
            If obj.ShowDialog = DialogResult.OK Then
                GetDataCategorias(obj.busqueda)
            Else
                GetDataCategorias()
            End If
        End Using
    End Sub

    Private Sub btnBuscarLinea_Click(sender As Object, e As EventArgs) Handles btnBuscarLinea.Click
        Using obj As New ERP_Financiero_BuscarActivo
            If obj.ShowDialog = DialogResult.OK Then
                GetDataLineas(obj.busqueda)
            Else
                GetDataLineas()
            End If
        End Using
    End Sub

    Private Sub btnBuscarBodega_Click(sender As Object, e As EventArgs) Handles btnBuscarBodega.Click
        Using obj As New ERP_Financiero_BuscarActivo
            If obj.ShowDialog = DialogResult.OK Then
                GetDataBodegas(obj.busqueda)
            Else
                GetDataBodegas()
            End If
        End Using
    End Sub

    Private Sub btnBusquedaUbicacion_Click(sender As Object, e As EventArgs) Handles btnBusquedaUbicacion.Click
        Using obj As New ERP_Financiero_BuscarActivo
            If obj.ShowDialog = DialogResult.OK Then
                GetDataUbicacion(obj.busqueda)
            Else
                GetDataUbicacion()
            End If
        End Using
    End Sub

    Private Sub btnBuscarCatalogo_Click(sender As Object, e As EventArgs) Handles btnBuscarCatalogo.Click
        Using obj As New ERP_Financiero_BuscarActivo
            If obj.ShowDialog = DialogResult.OK Then
                GetDataCatalagoSalida(obj.busqueda)
            Else
                GetDataCatalagoSalida()
            End If
        End Using
    End Sub

    Private Sub Button27_Click(sender As Object, e As EventArgs) Handles cmdBuscarTipoProveedor.Click
        Using obj As New ERP_Financiero_BuscarActivo
            If obj.ShowDialog = DialogResult.OK Then
                GetDataCustomerType(obj.busqueda)
            Else
                GetDataCustomerType()
            End If
        End Using
    End Sub

    Private Sub btnBuscarModelo_Click(sender As Object, e As EventArgs) Handles btnBuscarModelo.Click
        Using obj As New ERP_Financiero_BuscarActivo
            If obj.ShowDialog = DialogResult.OK Then
                GetDataModelo(obj.busqueda)
            Else
                GetDataModelo()
            End If
        End Using
    End Sub

    Private Sub cmd_CrearRequisicion_Click(sender As Object, e As EventArgs) Handles cmd_CrearRequisicion.Click
        Using objOutput As New ERP_Inventory_Dialog_Requisitions
            objOutput._is_creation = True
            If objOutput.ShowDialog() = DialogResult.OK Then
                GetDataRequisition()
            End If
        End Using
    End Sub

    Private Sub cmd_AprobarRequisicion_Click(sender As Object, e As EventArgs) Handles cmd_AprobarRequisicion.Click
        Try

            If dgvRequisiciones.SelectedRows(0).Cells("Is_Approved").Value = "En Proceso" Then
                MessageBox.Show("La Requisición se encuentra en proceso de creación", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf dgvRequisiciones.SelectedRows(0).Cells("Is_Approved").Value = "En Revisión" Then
                Using objAprobacion As New ERP_Inventory_Dialog_Requisitions
                    objAprobacion.ReaperturarRequ = False
                    objAprobacion._ID_Requisition_Header = dgvRequisiciones.SelectedRows(0).Cells("Id_Requisitions_Header").Value.ToString
                    objAprobacion._departamentoX = dgvRequisiciones.SelectedRows(0).Cells("deparment").Value.ToString
                    If objAprobacion.ShowDialog() = DialogResult.OK Then
                        GetDataRequisition()
                    End If
                End Using
            Else
                MessageBox.Show("La Requisición ya fue revisada", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button28_Click(sender As Object, e As EventArgs) Handles cmd_AbasteceRequisicion.Click
        Using objAbastecer As New ERP_Inventory_Dialog_Requisitions
            objAbastecer.ReaperturarRequ = False
            Try
                If (Not dgvRequisiciones.SelectedRows(0).Cells("Is_Approved").Value = "Aprobado" Or dgvRequisiciones.SelectedRows(0).Cells(
           "Is_Approved").Value = "No Aprobado") And Not dgvRequisiciones.SelectedRows(0).Cells("Is_Approved").Value = "Abastecido" Then
                    MessageBox.Show("La Requisición no ha sido Aprobada", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    If Not dgvRequisiciones.SelectedRows(0).Cells("Is_Approved").Value = "Abastecido" Then
                        objAbastecer._departamentoX = dgvRequisiciones.SelectedRows(0).Cells("deparment").Value
                        objAbastecer._ID_Requisition_Header = dgvRequisiciones.SelectedRows(0).Cells("Id_Requisitions_Header").Value.ToString
                        objAbastecer._Is_approval = True
                        objAbastecer._Abastecimiento = True
                        objAbastecer.Is_EncargadoBOdega = EncargadoBodega
                        objAbastecer.NUmeroRequisicion = dgvRequisiciones.SelectedRows(0).Cells("CodeRequisi").Value.ToString.Trim
                        If objAbastecer.ShowDialog() = DialogResult.OK Then
                            GetDataRequisition()
                        End If
                    Else
                        MessageBox.Show("La Requisición ya fue abastecida", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End If

            Catch ex As Exception

            End Try

        End Using
    End Sub

    Private Sub cmd_AbastecimientoReport_Click(sender As Object, e As EventArgs) Handles cmd_AbastecimientoReport.Click
        Try
            If Not dgvRequisiciones.SelectedRows(0).Cells("Is_Approved").Value = "Abastecido" Then
                MessageBox.Show("La Requisición no tiene reporte", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Dim dt As New DataTable
                Using objSQLRequisiciones As New Requisiciones_SQLServer
                    Dim _ID_Requisition_Header = dgvRequisiciones.SelectedRows(0).Cells("Id_Requisitions_Header").Value
                    dt = objSQLRequisiciones.Inventory_GetSuppliedRequisitionsReport(_ID_Requisition_Header)
                End Using

                Using objPartidaContable As New Financiero_ReportViewer(dt, "SuppliedRequisitions", "epd_SatelliteERP.Inventory_ReportSuppliedRequisitions.rdlc")
                    objPartidaContable.ShowDialog()
                End Using
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Button28_Click_1(sender As Object, e As EventArgs) Handles cmdCrearMotivos.Click
        Using objAdd As New ERP_Reason

            If objAdd.ShowDialog() = DialogResult.OK Then
                GetDataRasones()
            End If
        End Using
    End Sub

    Private Sub Button29_Click_1(sender As Object, e As EventArgs) Handles cmdModificarMotivo.Click
        Using objAdd As New ERP_Reason
            objAdd.id = dgvReason.CurrentRow.Cells("id_reason").Value
            objAdd.descripcion = dgvReason.CurrentRow.Cells("descrip_reason").Value
            objAdd.nombre = dgvReason.CurrentRow.Cells("name_reason").Value
            objAdd.OpcionSeleccionada = ERP_Inventary_Modelo.Funcion.Actualizar
            If objAdd.ShowDialog() = DialogResult.OK Then
                GetDataRasones()
            End If
        End Using
    End Sub

    Private Sub Button30_Click_1(sender As Object, e As EventArgs) Handles cmbEliminarMotivos.Click
        If Not dgvReason.CurrentRow Is Nothing Then
            Dim ID As Long = dgvReason.CurrentRow.Cells("id_reason").Value
            If MessageBox.Show("¿Está seguro que desea eliminar el motivo?", "Información", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
                Using objsql As New Generic_SQLServer
                    If objsql.ERP_SP_DelReason(ID) = "OK" Then
                        MessageBox.Show("Motivo eliminado exitosamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        GetDataRasones()
                    Else
                        MessageBox.Show("Ocurrió un error al eliminar el motivo", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            End If
        End If
    End Sub

    Private Sub Button32_Click_1(sender As Object, e As EventArgs) Handles cmdBuscarMotivos.Click
        Using obj As New ERP_Financiero_BuscarActivo
            If obj.ShowDialog = DialogResult.OK Then
                GetDataRasones(obj.busqueda)
            Else
                GetDataRasones()
            End If
        End Using
    End Sub

    Private Sub cmd_BuscarProducto_Click(sender As Object, e As EventArgs) Handles cmd_BuscarProducto.Click
        OcultarEntradas()
        Using obj As New ERP_Financiero_BuscarActivo
            If obj.ShowDialog = DialogResult.OK Then
                GetDataProductosStowage(_ID_Stowages, obj.busqueda)
                '  GetDataProductos(obj.busqueda)
            Else
                GetDataProductos()
            End If
        End Using
    End Sub

    Private Sub cmbFiltroMarca_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFiltroMarca.SelectedIndexChanged
        Dim valueSelect As Integer = cmbFiltroMarca.SelectedIndex
        GetDataMarcas("", valueSelect)
    End Sub

    Private Sub cmdProductos_Buscar_Click(sender As Object, e As EventArgs) Handles cmdProductos_Buscar.Click
        Using obj As New ERP_Financiero_BuscarActivo
            If obj.ShowDialog = DialogResult.OK Then
                GetDataProductos(obj.busqueda)
            Else
                GetDataProductos()
            End If
        End Using
    End Sub

    Private Sub cmdListProductCondition_Click(sender As Object, e As EventArgs) Handles cmdListProductCondition.Click
        Dim dt As New DataTable
        Using objSQLBodega As New Generic_SQLServer
            dt = objSQLBodega.SP_ERP_Generic_GetProductCondition(_ID_Company)
        End Using

        Using objPartidaContable As New Financiero_ReportViewer(dt, "DSProductCondition", "epd_SatelliteERP.Reports_InventoryProductType.rdlc")
            objPartidaContable.ShowDialog()
        End Using
    End Sub

    Private Sub cmdListUnitMeasure_Click(sender As Object, e As EventArgs) Handles cmdListUnitMeasure.Click
        Dim dt As New DataTable
        Using objSQLBodega As New Generic_SQLServer
            dt = objSQLBodega.ERP_Generic_SP_GetUnitMeasure(_ID_Company)
        End Using

        Using objPartidaContable As New Financiero_ReportViewer(dt, "DSUnidadMedida", "epd_SatelliteERP.Reports_InventoryUnitMeasure.rdlc")
            objPartidaContable.ShowDialog()
        End Using
    End Sub

#Region "Tipos de Requisiciones"
    Private Sub cmdCrearTipoRequisicion_Click(sender As Object, e As EventArgs) Handles cmdCrearTipoRequisicion.Click
        Using objOutput As New ERP_Inventory_Dialog_TypesRequisition
            If objOutput.ShowDialog() = DialogResult.OK Then
                GetDataRequisitionTypes()
            End If
        End Using
    End Sub

    Private Sub cmdModificarTipoRequisicion_Click(sender As Object, e As EventArgs) Handles cmdModificarTipoRequisicion.Click
        Using objAdd As New ERP_Inventory_Dialog_TypesRequisition
            objAdd.id_TypeRequisition = dgvRequisicionesTypes.CurrentRow.Cells("Id_RequisitionTypes").Value
            objAdd.TypeRequisition = dgvRequisicionesTypes.CurrentRow.Cells("RequisitionTypes").Value
            If objAdd.ShowDialog() = DialogResult.OK Then
                GetDataRequisitionTypes()
            End If
        End Using
    End Sub

    Private Sub cmdEliminarTipoRequisicion_Click(sender As Object, e As EventArgs) Handles cmdEliminarTipoRequisicion.Click

        If Not dgvRequisicionesTypes.CurrentRow Is Nothing Then
            Dim Id_RequisitionTypes As Long = dgvRequisicionesTypes.CurrentRow.Cells("Id_RequisitionTypes").Value
            Dim RequisitionTypes As String = dgvRequisicionesTypes.CurrentRow.Cells("RequisitionTypes").Value
            Dim resp As String = ""
            If MessageBox.Show("¿Está seguro que desea eliminar el Tipo de requisición: " & RequisitionTypes & "?", "Información", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
                Using objDelete As New Requisiciones_SQLServer
                    resp = objDelete.SP_Inventory_DeleteRequisitionType(Id_RequisitionTypes)
                End Using
                If resp = "1" Then
                    'MessageBox.Show("Registro eliminado exitosamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    GetDataRequisitionTypes()
                Else
                    MessageBox.Show("Ocurrió un error al eliminar el Tipo requisición", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        End If
    End Sub

    Private Sub btnGiroGeneral_Click(sender As Object, e As EventArgs) Handles btnGiroGeneral.Click
        Using obj As New ERP_Financiero_BuscarActivo
            If obj.ShowDialog = DialogResult.OK Then
                GetDataGiroGeneral(obj.busqueda)
            Else
                GetDataGiroGeneral()
            End If
        End Using
    End Sub

    Private Sub btnBuscarUnidadMedida_Click(sender As Object, e As EventArgs) Handles btnBuscarUnidadMedida.Click

        Using obj As New ERP_Financiero_BuscarActivo
            If obj.ShowDialog = DialogResult.OK Then
                GetDataUnitMeasure(obj.busqueda)
            Else
                GetDataUnitMeasure()
            End If
        End Using
    End Sub

    Private Sub btnBuscarTipoProducto_Click(sender As Object, e As EventArgs) Handles btnBuscarTipoProducto.Click
        Using obj As New ERP_Financiero_BuscarActivo
            If obj.ShowDialog = DialogResult.OK Then
                GetDataProductContidion(obj.busqueda)
            Else
                GetDataProductContidion()
            End If
        End Using
    End Sub

    Private Sub btnBuscarRequisicion_Click(sender As Object, e As EventArgs) Handles btnBuscarRequisicion.Click
        If EncargadoBodega Then
            SeleccHistEmpleado = False
            Using obj As New ERP_Financiero_BuscarActivo
                If obj.ShowDialog = DialogResult.OK Then
                    GetDataRequisitionEncargadoBodega(obj.busqueda)
                Else
                    GetDataRequisitionEncargadoBodega("")
                End If
            End Using
        ElseIf IsJefe Then
            SeleccHistEmpleado = False
            Using obj As New ERP_Financiero_BuscarActivo
                If obj.ShowDialog = DialogResult.OK Then
                    GetDataRequisitionJefeBodega(obj.busqueda)
                Else
                    GetDataRequisitionJefeBodega("")
                End If
            End Using
        Else

            SeleccHistEmpleado = False
            Using obj As New ERP_Financiero_BuscarActivo
                If obj.ShowDialog = DialogResult.OK Then
                    GetDataRequisition(obj.busqueda)
                Else
                    GetDataRequisition()
                End If
            End Using
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFiltroRequisiciones.SelectedIndexChanged
        Dim valueSelect As Integer = cmbFiltroRequisiciones.SelectedIndex
        GetDataRequisition("", valueSelect)
    End Sub

    Private Sub cmdReporteInventario_Click(sender As Object, e As EventArgs) Handles cmdReporteInventario.Click
        OcultarEntradas()
        Dim dt As New DataTable
        Using obj As New Operaciones_SQLServer
            dt = obj.ERP_SP_Inventory_Report_Lot(_ID_Stowages)
        End Using

        Using objPartidaContable As New Financiero_ReportViewer(dt, "DataSet1", "epd_SatelliteERP.Inventario_ReporteLotes.rdlc")
            objPartidaContable.ShowDialog()
        End Using
    End Sub

    Private Sub cmdSugeridoCompras_Click(sender As Object, e As EventArgs) Handles cmdSugeridoCompras.Click
        Dim dt As New DataTable
        Using Obj As New Operaciones_SQLServer
            dt = Obj.SP_ERP_Inventory_SugeridoCompras(_ID_Company)
        End Using
        Using objPartidaContable As New Financiero_ReportViewer(dt, "DataSet1", "epd_SatelliteERP.ComprasSugeridas.rdlc")
            objPartidaContable.ShowDialog()
        End Using
    End Sub

    Private Sub cmdExisteciasProductos_Click(sender As Object, e As EventArgs) Handles cmdExisteciasProductos.Click
        Using objFecha As New Inventario_fechas
            objFecha._ShowProduct = True
            objFecha._TipoInformacion = "Categorias"
            Dim dt As New DataTable
            Using Obj As New Operaciones_SQLServer
                ', objFecha.Fechainicio, objFecha.FechaFin, objFecha._IdCategory
                dt = Obj.SP_ERP_Inventory_SaldoExistencias(_ID_Company)
            End Using
            Using objPartidaContable As New Financiero_ReportViewer(dt, "DataSet1", "epd_SatelliteERP.SaldoExistencias.rdlc")
                objPartidaContable.ShowDialog()
            End Using
        End Using
    End Sub

    Private Sub cmdIngresoProductos_Click(sender As Object, e As EventArgs) Handles cmdIngresoProductos.Click
        Using objFecha As New Inventario_fechas
            objFecha._ShowProduct = True
            objFecha._TipoInformacion = "Proveedor"
            If objFecha.ShowDialog = DialogResult.OK Then
                Dim dt As New DataTable
                Using Obj As New Operaciones_SQLServer
                    dt = Obj.SP_ERP_Inventory_Ingreso_Productos(objFecha.Fechainicio, objFecha.FechaFin, objFecha._IdProveedor)
                End Using
                Using objPartidaContable As New Financiero_ReportViewer(dt, "DataSet1", "epd_SatelliteERP.Ingreso_de_productos.rdlc")
                    objPartidaContable.ShowDialog()
                End Using
            End If
        End Using

    End Sub

    Private Sub cmdSaldocuenta_Click(sender As Object, e As EventArgs) Handles cmdSaldocuenta.Click

        Using objSaldo As New Inventario_Saldo_Existencia

            If objSaldo.ShowDialog = DialogResult.OK Then
                Dim dt As New DataTable
                Using Obj As New Operaciones_SQLServer
                    dt = Obj.SP_ERP_Inventory_SaldoCuentas(_ID_Company, objSaldo.Anyo & objSaldo.Mes.ToString())
                End Using
                Using objPartidaContable As New Financiero_ReportViewer(dt, "DataSet1", "epd_SatelliteERP.Saldo_cuenta.rdlc")
                    objPartidaContable.ShowDialog()
                End Using
            End If
        End Using

    End Sub

    Private Sub cmdBienesEntregados_Click(sender As Object, e As EventArgs) Handles cmdBienesEntregados.Click
        Using objFecha As New Inventario_fechasEntregados
            If objFecha.ShowDialog = DialogResult.OK Then
                Dim dt As New DataTable
                Using Obj As New Operaciones_SQLServer
                    dt = Obj.SP_ERP_Inventory_BienesConsumosEntrgadosUnidadesOrganizativas(objFecha.Fechainicio, objFecha.FechaFin, objFecha._IdCategoria)
                End Using
                Using objPartidaContable As New Financiero_ReportViewer(dt, "DataSet1", "epd_SatelliteERP.Bienes_consumo_entregados.rdlc")
                    objPartidaContable.ShowDialog()
                End Using
            End If
        End Using
    End Sub

    Private Sub cmdProductosDepartamento_Click(sender As Object, e As EventArgs) Handles cmdProductosDepartamento.Click
        Using objFecha As New Inventario_fechas
            objFecha._ShowProduct = True
            objFecha._TipoInformacion = "Departamento"
            If objFecha.ShowDialog = DialogResult.OK Then
                Dim dt As New DataTable
                Using Obj As New Operaciones_SQLServer
                    dt = Obj.SP_ERP_Inventory_EntregaProductosDepartamento(objFecha.Fechainicio, objFecha.FechaFin, objFecha._IdDeparment)
                End Using
                Try
                    If (dt.Rows.Count <= 0) Then
                        MessageBox.Show("No hay información para Mostrar", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Exit Sub
                    End If
                Catch ex As Exception

                End Try
                Using objPartidaContable As New Financiero_ReportViewer(dt, "DataSet1", "epd_SatelliteERP.Entrega_Prductos_Departamento.rdlc")
                    objPartidaContable.ShowDialog()
                End Using
            End If
        End Using
    End Sub

    Private Sub cmdControlInventario_Click(sender As Object, e As EventArgs) Handles cmdControlInventario.Click
        Using objFecha As New Inventario_fechas
            If objFecha.ShowDialog = DialogResult.OK Then
                Dim dt As New DataTable
                Using Obj As New Operaciones_SQLServer
                    dt = Obj.SP_ERP_Inventory_ControlInventario(objFecha.Fechainicio, objFecha.FechaFin)
                End Using
                If dt.Rows.Count > 0 Then
                    Using objGenerador As New ReportProccesor
                        objGenerador.GenerarReporteControlInventario(dt, "EXISTENCIAS Y CONSUMO DE PRODUCTO DE ALMACEN")
                    End Using
                Else
                    MessageBox.Show("No hay datos que mostrar")
                End If


                ''''Using objPartidaContable As New Financiero_ReportViewer(dt, "DataSet1", "epd_SatelliteERP.Control_Inventario.rdlc")
                ''''    objPartidaContable.ShowDialog()
                ''''End Using
            End If
        End Using
    End Sub

    Private Sub cmdBalanceMensualAlmacen_Click(sender As Object, e As EventArgs) Handles cmdBalanceMensualAlmacen.Click

        Using objFecha As New Inventario_fechas
            objFecha._ShowProduct = True
            objFecha._TipoInformacion = "Categorias"
            If objFecha.ShowDialog = DialogResult.OK Then
                Dim dt As New DataTable
                Using Obj As New Operaciones_SQLServer
                    dt = Obj.SP_ERP_Inventory_Balance_Mensual_Almacen(objFecha._IdCategory)
                    Dim dtNew As DataTable
                    If (objFecha._IdCategory > 0) Then
                        ' sort and filter data
                        dtNew = SelectDataTable(dt, "ID = '" & objFecha._IdCategory & "' ", "id")
                        dt = dtNew
                    End If
                    dtNew = SelectDataTable(dt, "MM >= '" & objFecha.Fechainicio.Date.ToString("yyyyMM") & "' and MM <= '" & objFecha.FechaFin.Date.ToString("yyyyMM") & "'", "MM")
                    dt = dtNew


                End Using

                Using objPartidaContable As New Financiero_ReportViewer(dt, "DataSet1", "epd_SatelliteERP.Balance_Mensual_Almacen.rdlc")
                    objPartidaContable.ShowDialog()
                End Using
            End If
        End Using
    End Sub


    Function SelectDataTable(ByVal dt As DataTable, ByVal filter As String, ByVal sort As String) As DataTable

        Dim rows As DataRow()

        Dim dtNew As DataTable

        ' copy table structure
        dtNew = dt.Clone()

        ' sort and filter data
        rows = dt.Select(filter, sort)

        ' fill dtNew with selected rows

        For Each dr As DataRow In rows
            'Dim anio() As String = dr.Item(1).ToString.Split(" ")

            dtNew.ImportRow(dr)

        Next

        ' return filtered dt
        Return dtNew

    End Function

    'Private Sub cmdFicharesumidaActivo_Click(sender As Object, e As EventArgs) Handles cmdFicharesumidaActivo.Click
    '    Dim dt As New DataTable
    '    Using Obj As New Operaciones_SQLServer
    '        dt = Obj.SP_ERP_Inventory_Ficha_Resumida_Activo()
    '    End Using
    '    Using objPartidaContable As New Financiero_ReportViewer(dt, "DataSet1", "epd_SatelliteERP.Ficha_Resumida_Activo.rdlc")
    '        objPartidaContable.ShowDialog()
    '    End Using
    'End Sub

    Private Sub cmdEntradasProducto_Click(sender As Object, e As EventArgs) Handles cmdEntradasProducto.Click
        If DGW_Product.CurrentRow IsNot Nothing Then
            '' Dim row() As DataRow
            Dim IdProducto As Long = DGW_Product.CurrentRow.Cells("Id_Product").Value
            '' row = _tableFixedAssetsMaster.Select("ID_FixedAssets=" & DG_FixedAssets.CurrentRow.Cells(2).Value)

            Using objFecha As New Inventario_fechas
                If objFecha.ShowDialog = DialogResult.OK Then
                    Dim dt As New DataTable
                    Using Obj As New Operaciones_SQLServer
                        dt = Obj.SP_ERP_Inventory_Entradas_Por_Producto(objFecha.Fechainicio, objFecha.FechaFin, IdProducto)
                    End Using
                    Try
                        If dt.Rows.Count > 0 Then
                            Using objPartidaContable As New Financiero_ReportViewer(dt, "DataSet1", "epd_SatelliteERP.Reporte_Entradas_Producto.rdlc")
                                objPartidaContable.ShowDialog()
                            End Using
                        Else
                            MessageBox.Show("No hay informacion para mostrar", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Exit Sub
                        End If
                    Catch ex As Exception

                    End Try
                End If
            End Using


            'Dim dt As New DataTable
            'Using Obj As New Operaciones_SQLServer

            '    dt = Obj.SP_ERP_Inventory_Entradas_Por_Producto(IdProducto)
            'End Using
            'Using objPartidaContable As New Financiero_ReportViewer(dt, "DataSet1", "epd_SatelliteERP.Reporte_Entradas_Producto.rdlc")
            '    objPartidaContable.ShowDialog()
            'End Using

        Else
            MessageBox.Show("Seleccione un Producto", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End If
    End Sub

    Private Sub cmdSalidaProducto_Click(sender As Object, e As EventArgs) Handles ReporteSalidaDeProductoToolStripMenuItem.Click

        Using objFecha As New Inventario_fechas
            If objFecha.ShowDialog = DialogResult.OK Then
                Dim dt As New DataTable
                Using Obj As New Operaciones_SQLServer
                    dt = Obj.SP_ERP_Inventory_Reporte_Salida_Producto(objFecha.Fechainicio, objFecha.FechaFin, objFecha._IdProducto)
                End Using
                Using objPartidaContable As New Financiero_ReportViewer(dt, "DataSet1", "epd_SatelliteERP.Reporte_Salida_productos.rdlc")
                    objPartidaContable.ShowDialog()
                End Using
            End If
        End Using
    End Sub

    Private Sub cmdVerSalida_Click(sender As Object, e As EventArgs) Handles cmdVerSalida.Click
        OcultarEntradas()
        Try
            Using objOutput As New ERP_Inventory_Dialog_InventoryDeparturesAproved
                objOutput.ID_Stowage = _ID_Stowages
                objOutput._AProbacionSalida = AprobarSalidas
                If objOutput.ShowDialog() = DialogResult.OK Then
                End If
            End Using
        Catch ex As Exception

        End Try

    End Sub


    Private Sub btnTodas_Click(sender As Object, e As EventArgs)
        SeleccHistEmpleado = False
        GetDataRequisition()
    End Sub

    Private Sub btnAllProduct_Click(sender As Object, e As EventArgs) Handles btnTodosProductos.Click
        GetDataProductos()
    End Sub

    Private Sub cmdReaperturar_Click(sender As Object, e As EventArgs) Handles cmdReaperturar.Click
        Try
            If dgvRequisiciones.SelectedRows(0).Cells("Is_Approved").Value = "Denegado" Then
                Using objAprobacion As New ERP_Inventory_Dialog_Requisitions
                    objAprobacion.ReaperturarRequ = True
                    objAprobacion._ID_Requisition_Header = dgvRequisiciones.SelectedRows(0).Cells("Id_Requisitions_Header").Value
                    objAprobacion._departamentoX = dgvRequisiciones.SelectedRows(0).Cells("deparment").Value
                    objAprobacion.NUmeroRequisicion = dgvRequisiciones.SelectedRows(0).Cells("CodeRequisi").Value.ToString.Trim
                    If objAprobacion.ShowDialog() = DialogResult.OK Then
                        GetDataRequisition()
                    End If
                End Using
            ElseIf dgvRequisiciones.SelectedRows(0).Cells("Is_Approved").Value = "Abastecido" Then
                MessageBox.Show("La Requisición fue Abastecida", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf dgvRequisiciones.SelectedRows(0).Cells("Is_Approved").Value = "En Revisión" Then
                MessageBox.Show("La Requisición esta en Revisión", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                MessageBox.Show("La Requisición esta en Proceso", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmdBuscarProveedor_Click(sender As Object, e As EventArgs) Handles cmdBuscarProveedor.Click
        Using obj As New ERP_Financiero_BuscarActivo
            If obj.ShowDialog = DialogResult.OK Then
                GetClientes(obj.busqueda)
            Else
                GetClientes()
            End If
        End Using
    End Sub

    Private Sub cmdTodosProveedores_Click(sender As Object, e As EventArgs) Handles cmdTodosProveedores.Click
        GetClientes()
    End Sub


    Private Sub Button31_Click(sender As Object, e As EventArgs) Handles cmdTodasFormulas.Click
        GetDataProductosRecipes()
    End Sub

    Private Sub OcultarEntradas()
        btnVerEntradas.Visible = False
        btnReimpresionEntrada.Visible = False
        btnAgregarProductos.Visible = False
        btnTodasEntradas.Visible = False
        btnBuscarEntradas.Visible = False
        dgEntradas.Visible = False
    End Sub

    Private Sub cmdAllProducts_Click(sender As Object, e As EventArgs) Handles cmdAllProducts.Click
        OcultarEntradas()
        GetDataProductosStowage(_ID_Stowages, "")
    End Sub

    Private Sub cmdTodasMarcas_Click(sender As Object, e As EventArgs) Handles cmdTodasMarcas.Click
        GetDataMarcas()
    End Sub

    Private Sub cmdTodasCategorias_Click(sender As Object, e As EventArgs) Handles cmdTodasCategorias.Click
        GetDataCategorias()
    End Sub

    Private Sub Button31_Click_1(sender As Object, e As EventArgs) Handles btnTodasLineas.Click
        GetDataLineas()
    End Sub

    Private Sub cmdTodasBodegas_Click(sender As Object, e As EventArgs) Handles cmdTodasBodegas.Click
        GetDataBodegas()
    End Sub

    Private Sub Button33_Click(sender As Object, e As EventArgs) Handles btnTodasUbicaciones.Click
        GetDataUbicacion()
    End Sub

    Private Sub cmdTodosCatalogos_Click(sender As Object, e As EventArgs) Handles cmdTodosCatalogos.Click
        GetDataCatalagoSalida()
    End Sub

    Private Sub cmdTodosProveed_Click(sender As Object, e As EventArgs) Handles cmdTodosProveed.Click
        GetDataCustomerType()
    End Sub

    Private Sub cmdGiroGeneral_Click(sender As Object, e As EventArgs) Handles btnTodosGiroGeneral.Click
        GetDataGiroGeneral()
    End Sub

    Private Sub cmdUnidadMedida_Click(sender As Object, e As EventArgs) Handles btnTodosUnidadMedida.Click
        GetDataUnitMeasure()
    End Sub

    Private Sub cmdTipoProducto_Click(sender As Object, e As EventArgs) Handles cmdTodosTipoProducto.Click
        GetDataProductContidion()
    End Sub

    Private Sub cmdTodosModelos_Click(sender As Object, e As EventArgs) Handles cmdTodosModelos.Click
        GetDataModelo()
    End Sub

    Private Sub cmdTodosMotivos_Click(sender As Object, e As EventArgs) Handles cmdTodosMotivos.Click
        GetDataRasones()
    End Sub

    Private Sub btnVerRequisicion_Click(sender As Object, e As EventArgs) Handles btnVerRequisicion.Click
        Try
            Using objAprobacion As New ERP_Inventory_Dialog_Requisitions
                objAprobacion.ReaperturarRequ = True

                objAprobacion.NUmeroRequisicion = dgvRequisiciones.SelectedRows(0).Cells("CodeRequisi").Value.ToString.Trim
                If dgvRequisiciones.SelectedRows(0).Cells("Is_Approved").Value = "En Proceso" Then
                    objAprobacion.vista = False
                    objAprobacion._SendAproved = True
                Else
                    objAprobacion.vista = True
                    objAprobacion._SendAproved = False
                    objAprobacion.dgvProductsOutput.Enabled = False
                End If
                objAprobacion._ID_Requisition_Header = dgvRequisiciones.SelectedRows(0).Cells("Id_Requisitions_Header").Value
                objAprobacion._departamentoX = dgvRequisiciones.SelectedRows(0).Cells("deparment").Value

                objAprobacion.Is_EncargadoBOdega = False
                objAprobacion.Is_Jefe = False


                If objAprobacion.ShowDialog() = DialogResult.OK Then
                    GetDataRequisition()
                End If
            End Using

        Catch ex As Exception

        End Try
    End Sub

    Private Sub ToolStripMenuItem5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles tsRevision.Click
        SeleccHistEmpleado = False
        GetDataRequisition("", 1)
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles tsAprobacion.Click
        SeleccHistEmpleado = False
        GetDataRequisition("", 2)
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles tsDenegadas.Click
        SeleccHistEmpleado = False
        GetDataRequisition("", 3)
    End Sub

    Private Sub AbastecidasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles tsAbastecidas.Click
        SeleccHistEmpleado = False
        GetDataRequisition("", 4)
    End Sub

    Private Sub btnHistorial_Click(sender As Object, e As EventArgs) Handles btnHistorial.Click

        Using objEmpleado As New ERP_RequisicionesEmpleado
            If objEmpleado.ShowDialog = DialogResult.OK Then
                IdUnidadHist = objEmpleado.Unidad
                SeleccHistEmpleado = True
                GetDataRequisition()
            End If
        End Using

    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles tsProceso.Click
        SeleccHistEmpleado = False
        GetDataRequisition("", 5)
    End Sub


    Private Sub GetDataEntradas(ByVal Busquedad As String)
        Using objsql As New Requisiciones_SQLServer
            Try
                _tableRequisiciones = objsql.GetDataEntradaProdutos(Busquedad)
                dgEntradas.AutoGenerateColumns = False
                dgEntradas.Font = New Font("Segoe UI", 11)
                dgEntradas.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
                dgEntradas.ReadOnly = True
                dgEntradas.SelectionMode = DataGridViewSelectionMode.FullRowSelect
                dgEntradas.MultiSelect = False
                dgEntradas.AllowUserToResizeColumns = False
                dgEntradas.AllowUserToAddRows = False
                dgEntradas.AllowUserToDeleteRows = False

                dgEntradas.DataSource = _tableRequisiciones


                If dgEntradas.Rows.Count > 0 Then
                    Try
                        For Each item As DataGridViewRow In dgEntradas.Rows
                            If (item.Cells("isclose").Value.ToString = "Cerrada") Then
                                item.Cells("ImagenEn").Value = Verde_Bandera
                            Else
                                item.Cells("ImagenEn").Value = Amarillo_bandera
                            End If

                        Next
                    Catch ex As Exception

                    End Try
                End If

            Catch ex As Exception

            End Try
        End Using
    End Sub

    Private Sub Button34_Click(sender As Object, e As EventArgs) Handles btnHistorialEntradas.Click
        btnVerEntradas.Visible = True
        btnReimpresionEntrada.Visible = True
        btnAgregarProductos.Visible = True
        dgEntradas.Visible = True
        btnTodasEntradas.Visible = True
        btnBuscarEntradas.Visible = True
        GetDataEntradas("")
    End Sub

    Private Sub Button35_Click(sender As Object, e As EventArgs) Handles btnAgregarProductos.Click
        If Not dgvProductsStowage.CurrentRow Is Nothing Then
            Try
                If (dgEntradas.CurrentRow.Cells("isclose").Value = "Cerrada") Then
                    MessageBox.Show("La entrada se encuentra cerrada, debe de crear una nueva.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                Else
                    Dim Id_Header As Long = dgEntradas.CurrentRow.Cells("id_entrada").Value

                    Dim row As DataTable
                    Using objAdd As New ERP_Inventory_DialogProductEntry
                        objAdd.UpdateDataEntrada = True
                        Using objSQL As New Generic_SQLServer
                            row = objSQL.SP_ERP_AlmacenGetHeaderEntrada(Id_Header)
                            objAdd._DT_Entrada = row
                            row = objSQL.SP_ERP_AlmacenGetHeaderEntradaDetails(Id_Header)
                            objAdd._DT_EntradaDetails = row
                        End Using

                        objAdd.Id_HeaderUpdate = Id_Header
                        objAdd.ID_Customer = dgEntradas.CurrentRow.Cells("IdCustomer").Value.ToString
                        objAdd.ID_Stowage = dgEntradas.CurrentRow.Cells("IdStowage").Value.ToString
                        If objAdd.ShowDialog() = DialogResult.OK Then

                        End If
                    End Using
                End If
            Catch ex As Exception

            End Try
            GetDataEntradas("")
            GetDataProductos("")
        End If
    End Sub

    Private Sub Button37_Click(sender As Object, e As EventArgs) Handles btnVerEntradas.Click
        If Not dgvProductsStowage.CurrentRow Is Nothing Then
            Try
                Dim Id_Header As Long = dgEntradas.CurrentRow.Cells("id_entrada").Value

                Dim row As DataTable
                Using objAdd As New ERP_Inventory_DialogProductEntry
                    objAdd.UpdateDataEntrada = True
                    objAdd.edicion = False
                    Using objSQL As New Generic_SQLServer
                        row = objSQL.SP_ERP_AlmacenGetHeaderEntrada(Id_Header)
                        objAdd._DT_Entrada = row
                        row = objSQL.SP_ERP_AlmacenGetHeaderEntradaDetails(Id_Header)
                        objAdd._DT_EntradaDetails = row
                    End Using

                    objAdd.Id_HeaderUpdate = Id_Header
                    objAdd.ID_Customer = dgEntradas.CurrentRow.Cells("IdCustomer").Value.ToString
                    objAdd.ID_Stowage = dgEntradas.CurrentRow.Cells("IdStowage").Value.ToString
                    If objAdd.ShowDialog() = DialogResult.OK Then
                    End If
                End Using
            Catch ex As Exception

            End Try
            GetDataEntradas("")
        End If
    End Sub

    Private Sub btnReimpresionEntrada_Click(sender As Object, e As EventArgs) Handles btnReimpresionEntrada.Click
        If Not dgvProductsStowage.CurrentRow Is Nothing Then
            Try
                If dgEntradas.CurrentRow.Cells("isclose").Value = "En Proceso" Then
                    MessageBox.Show("La entrada esta en Proceso, debe finalizar para imprimir el reporte", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                Else
                    Dim Id_Header As Long = dgEntradas.CurrentRow.Cells("id_entrada").Value

                    Dim dt As New DataTable
                    Using objSQLBodega As New Operaciones_SQLServer
                        dt = objSQLBodega.ERP_Inventory_GetProducts_Stowage(Data_Id_Company, Id_Header)
                    End Using

                    Using objPartidaContable As New Financiero_ReportViewer(dt, "DSBodegasOperaciones", "epd_SatelliteERP.Reports_InventoryEntryProduct.rdlc")
                        objPartidaContable.ShowDialog()
                    End Using
                End If

            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub btnBuscarEntradas_Click(sender As Object, e As EventArgs) Handles btnBuscarEntradas.Click
        Using obj As New ERP_Financiero_BuscarActivo
            If obj.ShowDialog = DialogResult.OK Then
                GetDataEntradas(obj.busqueda)
                '  GetDataProductos(obj.busqueda)
            Else
                GetDataMarcas()
            End If
        End Using
    End Sub

    Private Sub btnTodasEntradas_Click(sender As Object, e As EventArgs) Handles btnTodasEntradas.Click
        GetDataEntradas("")
    End Sub

    Private Sub dgEntradas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgEntradas.CellContentClick

    End Sub

    Private Sub btnCerrarEntradas_Click(sender As Object, e As EventArgs)
        If Not dgvProductsStowage.CurrentRow Is Nothing Then
            Try
                Dim Id_Header As Long = dgEntradas.CurrentRow.Cells("id_entrada").Value
                If (dgEntradas.CurrentRow.Cells("isclose").Value = "Cerrada") Then
                    MessageBox.Show("La entrada se encuentra cerrada, debe de crear una nueva.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                Else
                    Dim row As DataTable
                    Using objAdd As New ERP_Inventory_DialogProductEntry
                        objAdd.UpdateDataEntrada = True
                        objAdd.edicion = False
                        Using objSQL As New Generic_SQLServer
                            row = objSQL.SP_ERP_AlmacenGetHeaderEntrada(Id_Header)
                            objAdd._DT_Entrada = row
                            row = objSQL.SP_ERP_AlmacenGetHeaderEntradaDetails(Id_Header)
                            objAdd._DT_EntradaDetails = row
                        End Using

                        objAdd.Id_HeaderUpdate = Id_Header
                        objAdd.ID_Customer = dgEntradas.CurrentRow.Cells("IdCustomer").Value.ToString
                        objAdd.ID_Stowage = dgEntradas.CurrentRow.Cells("IdStowage").Value.ToString
                        objAdd.CerrarProceso = True
                        If objAdd.ShowDialog() = DialogResult.OK Then

                        End If
                    End Using
                End If
            Catch ex As Exception

            End Try
            GetDataEntradas("")
        End If
    End Sub

    Private Sub ToolStripMenuItem5_Click_1(sender As Object, e As EventArgs) Handles tsRequisiciones.Click
        SeleccHistEmpleado = False
        If EncargadoBodega Then
            GetDataRequisitionEncargadoBodega("")
        Else
            GetDataRequisition()
        End If
    End Sub

    Private Sub limpiezaData()
        'DGVClientes.Visible = False
        'DGW_Product.Visible = False
        'dgvRequisiciones.Visible = False
        'dgEntradas.Visible = False
    End Sub

    Private Sub ReporteDeKardexToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteDeKardexToolStripMenuItem.Click
        Using objFecha As New Inventario_fechas
            objFecha._ID_Stowage = _ID_Stowages
            objFecha._ShowProduct = True
            If objFecha.ShowDialog = DialogResult.OK Then
                Dim dt As New DataTable
                Using Obj As New Operaciones_SQLServer
                    dt = Obj.SP_ERP_Inventory_Kardex(_ID_Company, objFecha.Fechainicio, objFecha.FechaFin, objFecha._IdProducto)
                End Using
                Using objPartidaContable As New Financiero_ReportViewer(dt, "DataSet1", "epd_SatelliteERP.Inventario_KardexDH.rdlc")
                    objPartidaContable.ShowDialog()
                End Using
            End If
        End Using
    End Sub
#End Region
End Class
