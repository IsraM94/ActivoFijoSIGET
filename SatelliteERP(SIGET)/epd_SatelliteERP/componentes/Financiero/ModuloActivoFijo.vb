Imports System.Windows.Forms.DataVisualization.Charting

Public Class ModuloActivoFijo
    Private objSql As New Financiero_SQLServer
    Property _tableFixedAssetsMaster As DataTable
    Private _tableTipoActivo As DataTable
    Private _tableFixedAssetsMaster_image As DataTable
	Private _tableMonto As DataTable
    Private objSql2 As New Generic_SQLServer
    Property OptionSelected As String = ""
    Private TransferProcess As Integer = 1
    Private Transfer As String = ""
    Private BanderaShow As Boolean = False
    Private OpcionesMenu As DataTable
    Private GridAProcesarCambios As String = ""
    Dim Amarillo_bandera As Bitmap = My.Resources.Resources.Amarillo_bandera
    Dim Roja_Bandera As Bitmap = Global.epd_SatelliteERP.My.Resources.Resources.Roja_Bandera
    Dim Verde_Bandera As Bitmap = Global.epd_SatelliteERP.My.Resources.Resources.Verde_bandera
    Dim Anaranjado_Bandera As Bitmap = Global.epd_SatelliteERP.My.Resources.Resources.Anaranjado_Bandera
    Dim Morado_Bandera As Bitmap = Global.epd_SatelliteERP.My.Resources.Resources.Morado_Bandera
    Dim Id_Department As Integer = 0
    Dim AsistenteAdministrativo As Boolean = False
    Private JefeAutorizacion As Boolean = False
    Private UsuarioEstandar As Boolean = False
    Private Encargado_ActivoFijo As Boolean = False
    Private Sub ModuloActivoFijo_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        BtnTransferenciaArchivo.Visible = False
        btnAllActivos.Visible = False
        btnSinAsignar.Visible = False
        btnConfirmarTransferencia.Visible = False
        btnBusquedadAct.Visible = False
        btnReporteTrasnferencias.Visible = False
        BtnAllTransfer.Visible = False
        btnCreateDepreciacion.Visible = False
        cmb_AprobarDepreciacion.Visible = False
        cmb_PendientesAprob.Visible = False
        cmb_ListadoDepreciaciones.Visible = False
        btnReportesDeprec.Visible = False
        cmdFicharesumidaDeActivo.Visible = True
        tcMain.TabPages.RemoveAt(4)
        BanderaShow = False

        OpcionesMenu = objSql2.GetAccessMenu(_UserSQL)
        Id_Department = _Id_DepartmentGlobal


        tcMain.TabPages.Remove(ActivoFijo)
        tcMain.TabPages.Remove(Translado)
        tcMain.TabPages.Remove(Depreciacion)
        tcMain.TabPages.Remove(IndicadoresPersonalizados)
        tcMain.TabPages.Remove(Amortización)

        If (OpcionesMenu.Rows.Count > 0) Then
            For Each DataInfo As DataRow In OpcionesMenu.Rows



                If (DataInfo("rolUser").ToString.ToUpper = "MN_Act_MenuVer_Indicadores".ToUpper) Then
                    tcMain.TabPages.Add(IndicadoresPersonalizados)
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "MN_Act_MenuVer_ActivoFijo".ToUpper) Then
                    tcMain.TabPages.Add(ActivoFijo)
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "MN_Act_MenuVer_TransladoActivoFijo".ToUpper) Then
                    tcMain.TabPages.Add(Translado)
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "MN_Act_MenuVer_Depreciacion".ToUpper) Then
                    tcMain.TabPages.Add(Depreciacion)
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "MN_Act_MenuVer_Amortizacion".ToUpper) Then
                    tcMain.TabPages.Add(Amortización)
                End If

                If (DataInfo("rolUser").ToString.ToUpper = "AF_ActivoFijo_AsistenteReportes".ToUpper) Then
                    AsistenteAdministrativo = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "AF_ActivoFijo_All".ToUpper) Then
                    BtnTransferenciaArchivo.Visible = True
                    btnAllActivos.Visible = True
                    btnSinAsignar.Visible = True
                    btnReporteTrasnferencias.Visible = True
                    'cmdReporteActivo.Visible = True
                    btnConfirmarTransferencia.Visible = True
                    btnBusquedadAct.Visible = True
                    BtnAllTransfer.Visible = True
                    BanderaShow = True
                    Id_Department = -1

                ElseIf (DataInfo("rolUser").ToString.ToUpper = "AF_ActivoFijo_TrasnferenciaAprobacion".ToUpper) Then
                    btnConfirmarTransferencia.Visible = True
                    btnBusquedadAct.Visible = True
                    BtnAllTransfer.Visible = True
                    BanderaShow = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "AF_ActivoFijo_Report".ToUpper) Then
                    btnReporteTrasnferencias.Visible = True
                    'cmdReporteActivo.Visible = True
                    BanderaShow = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "AF_ActivoFijo_transferir".ToUpper) Then
                    BtnTransferenciaArchivo.Visible = True
                    btnAllActivos.Visible = True
                    btnSinAsignar.Visible = True
                    BanderaShow = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "AF_ActivoFijo_TrasnferenciaBuscar".ToUpper) Then
                    btnBusquedadAct.Visible = True
                    BtnAllTransfer.Visible = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "AF_ActivoFijo_ReimprimirTransferencia".ToUpper) Then
                    cmdMovimientoActivo.Visible = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "AF_ActivoFijo_BuscarActivo".ToUpper) Then
                    btnBuscarActivo.Visible = True

                ElseIf (DataInfo("rolUser").ToString.ToUpper = "AF_ActivoFijo_ActivosDescargados".ToUpper) Then
                    cmdDescargados.Visible = True
                End If

                If (DataInfo("rolUser").ToString.ToUpper = "AF_Depreciation_All".ToUpper) Then
                    btnCreateDepreciacion.Visible = True
                    cmb_AprobarDepreciacion.Visible = True
                    cmb_PendientesAprob.Visible = True
                    cmb_ListadoDepreciaciones.Visible = True
                    'btnReportesDeprec.Visible = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "AF_Depreciation_Create".ToUpper) Then
                    btnCreateDepreciacion.Visible = True
                    cmb_ListadoDepreciaciones.Visible = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "AF_Depreciation_Aprobation".ToUpper) Then
                    cmb_PendientesAprob.Visible = True
                    cmb_ListadoDepreciaciones.Visible = True
                    cmb_AprobarDepreciacion.Visible = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "AF_Depreciation_Report".ToUpper) Then
                    btnReportesDeprec.Visible = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "AF_ActivoFijo_DepreciationShow".ToUpper) Then
                    cmdVerDepreciacion.Visible = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "AF_ActivoFijo_DepreciationBuscar".ToUpper) Then
                    cmdBuscarDepreciacion.Visible = True
                End If

                If (DataInfo("rolUser").ToString.ToUpper = "AF_Amortizacion_TodasOpciones".ToUpper) Then
                    btnCrearAmortizacion.Visible = True
                    btnPendientesAmortizacion.Visible = True
                    btnListadoAmortizaciones.Visible = True
                    btnVerAmortizacion.Visible = True
                    btnAprobarAmortizacion.Visible = True
                    btnBuscarAmortizacion.Visible = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "AF_Amortizacion_CrearAmortizacion".ToUpper) Then
                    btnCrearAmortizacion.Visible = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "AF_Amortizacion_PendientesAprobacion".ToUpper) Then
                    btnPendientesAmortizacion.Visible = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "AF_Amortizacion_ListadoAmortizaciones".ToUpper) Then
                    btnListadoAmortizaciones.Visible = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "AF_Amortizacion_VerAmortizacion".ToUpper) Then
                    btnVerAmortizacion.Visible = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "AF_Amortizacion_AprobarAmortizacion".ToUpper) Then
                    btnAprobarAmortizacion.Visible = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "AF_Amortizacion_ReporteAmortizacion".ToUpper) Then
                    btnReporteAmortizacion.Visible = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "AF_Amortizacion_BuscarAmortizacion".ToUpper) Then
                    btnBuscarAmortizacion.Visible = True
                End If

                If (DataInfo("rolUser").ToString.ToUpper = "AF_ActivoFijo_All".ToUpper) Then
                    cmdCreate.Visible = True
                    cmdCreate_Intengible.Visible = True
                    cmdModificar.Visible = True
                    btnTblDepreciacion.Visible = True
                    btnImport.Visible = True
                    cmdLegacy.Visible = True
                    cmd_FiltrarReportes.Visible = True
                    btnIndicadorActivos.Visible = True
                    btnIndicadorDptos.Visible = True
                    btnIndicadorEmpleados.Visible = True
                    cmdFichaTransparencia.Visible = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "AF_ActivoFijo_CrearActivoFijo".ToUpper) Then
                    cmdCreate.Visible = True
                    cmdCreate_Intengible.Visible = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "AF_ActivoFijo_ModificarActivoFijo".ToUpper) Then
                    cmdModificar.Visible = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "AF_ActivoFijo_VistaTablaDepreciacion".ToUpper) Then
                    btnTblDepreciacion.Visible = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "AF_ActivoFijo_Legacy".ToUpper) Then
                    btnImport.Visible = True
                    cmdLegacy.Visible = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "AF_ActivoFijo_FiltrarReportes".ToUpper) Then
                    cmd_FiltrarReportes.Visible = True
                End If

                If (DataInfo("rolUser").ToString.ToUpper = "AF_Indicadores".ToUpper) Then
                    btnIndicadorActivos.Visible = True
                    btnIndicadorDptos.Visible = True
                    btnIndicadorEmpleados.Visible = True
                End If

            Next
        End If


        Try
            If DG_FixedAssets.Rows.Count > 0 Then
                For Each item As DataGridViewRow In DG_FixedAssets.Rows
                    If (item.Cells("transferido" & GridAProcesarCambios).Value = "AUTORIZACION") Then
                        item.Cells("Imagen" & GridAProcesarCambios).Value = Anaranjado_Bandera
                    ElseIf (item.Cells("transferido" & GridAProcesarCambios).Value = "EN PROCESO") Then
                        item.Cells("Imagen" & GridAProcesarCambios).Value = Amarillo_bandera
                    ElseIf (item.Cells("transferido" & GridAProcesarCambios).Value = "RECHAZADO") Then
                        item.Cells("Imagen" & GridAProcesarCambios).Value = Morado_Bandera
                    ElseIf (item.Cells("transferido" & GridAProcesarCambios).Value = "NO") Then
                        item.Cells("Imagen" & GridAProcesarCambios).Value = Roja_Bandera
                    Else
                        item.Cells("Imagen" & GridAProcesarCambios).Value = Verde_Bandera
                    End If

                Next
                DG_FixedAssets.Update()
                DG_FixedAssets.RefreshEdit()
            End If
        Catch ex3 As Exception

        End Try

        btnIndicadorActivos.PerformClick()
    End Sub

    Private Sub FormatoGrid(ByVal GridProcess As DataGridView)
        GridProcess.AutoGenerateColumns = False
        GridProcess.Font = New Font("Segoe UI", 11)
        GridProcess.Columns(0).Width = 20
        GridProcess.Columns(1).Width = 120
        GridProcess.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        GridProcess.Columns(2).Width = 100
        GridProcess.Columns(3).Width = 200
        GridProcess.Columns(4).Width = 120

        GridProcess.Columns(5).Width = 120
        GridProcess.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        'GridProcess.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        GridProcess.Columns(5).DefaultCellStyle.Format = "c"
        GridProcess.Columns(6).Width = 120
        GridProcess.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        GridProcess.Columns(7).Width = 200
        GridProcess.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        GridProcess.Columns(8).Width = 200
        GridProcess.Columns(9).Width = 200
        GridProcess.Columns(10).Width = 200
        GridProcess.Columns(12).Width = 55
        GridProcess.Columns(12).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        GridProcess.ReadOnly = True
        GridProcess.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        GridProcess.MultiSelect = False
        GridProcess.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
        GridProcess.AllowUserToAddRows = False
        GridProcess.AllowUserToDeleteRows = False
        GridProcess.DataSource = _tableFixedAssetsMaster
        GridProcess.Refresh()
        If GridProcess.Rows.Count > 0 Then
            Try
                For Each item As DataGridViewRow In GridProcess.Rows
                    If (item.Cells("transferido").Value = "AUTORIZACION") Then
                        item.Cells("Imagen").Value = Anaranjado_Bandera
                    ElseIf (item.Cells("transferido" & GridAProcesarCambios).Value = "EN PROCESO") Then
                        item.Cells("Imagen" & GridAProcesarCambios).Value = Amarillo_bandera
                    ElseIf (item.Cells("transferido" & GridAProcesarCambios).Value = "RECHAZADO") Then
                        item.Cells("Imagen" & GridAProcesarCambios).Value = Morado_Bandera
                    ElseIf (item.Cells("transferido" & GridAProcesarCambios).Value = "NO") Then
                        item.Cells("Imagen" & GridAProcesarCambios).Value = Roja_Bandera
                    Else
                        item.Cells("Imagen" & GridAProcesarCambios).Value = Verde_Bandera
                    End If

                Next
            Catch ex As Exception

            End Try
        End If

        Dim Is_Posting As Boolean = False
        Dim Is_Square As Boolean = False
        Try
            _tableFixedAssetsMaster_image = objSql.ERP_FixedAssets_Masterimage_Select(GridProcess.CurrentRow.Cells("ID_FixedAssets" & GridAProcesarCambios).Value)

        Catch ex As Exception
            _tableFixedAssetsMaster_image = Nothing
        End Try


        For Each row As DataGridViewRow In GridProcess.Rows
            Try
                If Not row.Cells("Is_Posting" & GridAProcesarCambios).Value Is DBNull.Value Then
                    Is_Posting = row.Cells("Is_Posting" & GridAProcesarCambios).Value
                Else
                    Is_Posting = False
                End If
                If Not row.Cells("Is_Square" & GridAProcesarCambios).Value Is DBNull.Value Then
                    Is_Square = row.Cells("Is_Square" & GridAProcesarCambios).Value
                Else
                    Is_Square = False
                End If
                If Is_Posting Then
                    row.Cells("Imagen" & GridAProcesarCambios).Value = epd_SatelliteERP.My.Resources.Resources.Verde_bandera
                ElseIf Is_Square Then
                    row.Cells("Imagen" & GridAProcesarCambios).Value = epd_SatelliteERP.My.Resources.Resources.Amarillo_bandera
                End If
            Catch ex As Exception
                ' No existe cambio unicamente es valor nulo
            End Try
        Next

        GridProcess.Refresh()

    End Sub

    Private Sub GetDataActivoFijo(GridProcess As DataGridView, ByVal ExtraerTipos As Integer)
        'If objSql2.isMenber("fixedasset_accesGoods") Then
        '    _tableFixedAssetsMaster = objSql.GetFinance_FixedAssetsMaster_Select(Data_Id_Company, -1)
        'Else
        Dim PersonalActivoFijo As Integer = 0
        OpcionesMenu = objSql2.GetAccessMenu(_UserSQL)
        Id_Department = _Id_DepartmentGlobal
        If (OpcionesMenu.Rows.Count > 0) Then
            For Each DataInfo As DataRow In OpcionesMenu.Rows
                If (DataInfo("rolUser").ToString.ToUpper = "AF_ActivoFijo_All".ToUpper) Then
                    PersonalActivoFijo = 1
                    Id_Department = 0
                    'Exit For
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "AF_ActivoFijo_MostrarTodosActivos".ToUpper) Then
                    Id_Department = 0
                    PersonalActivoFijo = 1
                    Encargado_ActivoFijo = True

                ElseIf (DataInfo("rolUser").ToString.ToUpper = "AF_ActivoFijo_UsuarioEstandar".ToUpper) Then
                    Id_Department = _Id_DepartmentGlobal
                    PersonalActivoFijo = 0
                    UsuarioEstandar = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "AF_ActivoFijo_JefeUnidad".ToUpper) Then
                    PersonalActivoFijo = 1
                    btnConfirmarTransferencia.Text = "Autorizar Transferencia"
                End If
            Next
        End If
        Dim idemployee As Long = 0
        If PersonalActivoFijo = 1 Then
            idemployee = -1
        Else
            idemployee = _Id_EmployeeGlobal
        End If
        _tableFixedAssetsMaster = objSql.GetFinance_FixedAssetsMaster_Select(Data_Id_Company, Id_Department, idemployee, ExtraerTipos)
        '  End If

        GridAProcesarCambios = ""
        If (GridProcess.Name = "DG_FixedAssets_Trans") Then
            GridAProcesarCambios = "A"
        End If
        GridProcess.DataSource = _tableFixedAssetsMaster
        FormatoGrid(GridProcess)
    End Sub

    Private Sub GetDataActivoFijoDescargado(GridProcess As DataGridView)
        'If objSql2.isMenber("fixedasset_accesGoods") Then
        '    _tableFixedAssetsMaster = objSql.GetFinance_FixedAssetsMaster_Select(Data_Id_Company, -1)
        'Else

        _tableFixedAssetsMaster = objSql.GetFinance_FixedAssetsMaster_Descargados(Data_Id_Company)
        '  End If
        GridAProcesarCambios = ""
        If (GridProcess.Name = "DG_FixedAssets_Trans") Then
            GridAProcesarCambios = "A"
        End If

        FormatoGrid(GridProcess)
    End Sub

    Private Sub GetDataActivoFijo(ByVal busqueda As String, GridProcess As DataGridView)
        Dim PersonalActivoFijo As Integer = 0
        OpcionesMenu = objSql2.GetAccessMenu(_UserSQL)
        Id_Department = _Id_DepartmentGlobal
        If (OpcionesMenu.Rows.Count > 0) Then
            For Each DataInfo As DataRow In OpcionesMenu.Rows
                If (DataInfo("rolUser").ToString.ToUpper = "AF_ActivoFijo_All".ToUpper) Then
                    PersonalActivoFijo = 1
                    'Exit For
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "AF_ActivoFijo_MostrarTodosActivos".ToUpper) Then
                    Id_Department = 0
                    PersonalActivoFijo = 1
                    Encargado_ActivoFijo = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "AF_ActivoFijo_UsuarioEstandar".ToUpper) Then
                    Id_Department = _Id_DepartmentGlobal
                    PersonalActivoFijo = 0
                    UsuarioEstandar = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "AF_ActivoFijo_JefeUnidad".ToUpper) Then
                    PersonalActivoFijo = 1
                End If
            Next
        End If
        Dim idemployee As Long = 0
        If PersonalActivoFijo = 1 Then
            idemployee = -1
        Else
            idemployee = _Id_EmployeeGlobal
        End If

        _tableFixedAssetsMaster = objSql.GetFinance_FixedAssetsMaster_Select(Data_Id_Company, busqueda, Id_Department, TransferProcess, idemployee)
        FormatoGrid(GridProcess)
    End Sub

	'Funcion para cargar el parametro monto de adquisicion  

    Private Sub getDataMontoAdquisicion()

        _tableMonto = objsql.SP_ERP_ConfigAmountCapitalizable()
            DGWMontoAdquisicion.AutoGenerateColumns = False
            DGWMontoAdquisicion.Font = New Font("Segoe UI", 11)
            DGWMontoAdquisicion.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
            DGWMontoAdquisicion.ReadOnly = True
            DGWMontoAdquisicion.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            DGWMontoAdquisicion.MultiSelect = False
            ' DGWMontoAdquisicionas.AllowUserToResizeColumns = False
            DGWMontoAdquisicion.AllowUserToAddRows = False
            DGWMontoAdquisicion.AllowUserToDeleteRows = False
            DGWMontoAdquisicion.Columns(0).Width = 100
            DGWMontoAdquisicion.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
        DGWMontoAdquisicion.Columns(1).Width = 350
        'DGWMontoAdquisicion.Columns(2).Width = 180
        DGWMontoAdquisicion.DataSource = _tableMonto

    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles cmdLegacy.Click
        Using obj As New frmLegacy
            ''LEGACY
            REM row = _tableFixedAssetsMaster.Select("ID_FixedAssets=" & DG_FixedAssets.CurrentRow.Cells(1).Value)

            If obj.ShowDialog = DialogResult.OK Then
                GetDataActivoFijo(DG_FixedAssets, 2)
            End If
        End Using
    End Sub

    Private Sub btnImport_Click(sender As Object, e As EventArgs) Handles btnImport.Click
        Using obj As New frmImportDataXLS
            REM row = _tableFixedAssetsMaster.Select("ID_FixedAssets=" & DG_FixedAssets.CurrentRow.Cells(1).Value)
            obj.ShowDialog()
        End Using
    End Sub

    Private Sub cmdCreate_Click(sender As Object, e As EventArgs) Handles cmdCreate.Click
        Using obj As New Financiero_CreaActivoFijo
            obj.Is_Tangible = True
            obj.OpcionSeleccionada = Financiero_CreaActivoFijo.Funcion.Agregar
            If obj.ShowDialog = DialogResult.OK Then
                GetDataActivoFijo(DG_FixedAssets, 1)
            End If
        End Using
    End Sub

    Private Sub cmdCreate_Intengible_Click(sender As Object, e As EventArgs) Handles cmdCreate_Intengible.Click
        Using obj As New Financiero_CreaActivoFijo
            obj.Is_Tangible = False
            If obj.ShowDialog = DialogResult.OK Then
                GetDataActivoFijo(DG_FixedAssets, 0)
            End If
        End Using
    End Sub

    Private Sub cmdModificar_Click(sender As Object, e As EventArgs) Handles cmdModificar.Click
        Try
            If Not IsNothing(_tableFixedAssetsMaster) Then
                Using obj As New Financiero_CreaActivoFijo
                    If _tableFixedAssetsMaster.Rows.Count > 0 Then
                        obj.OpcionSeleccionada = Financiero_CreaActivoFijo.Funcion.Actualizar
                        Dim row() As DataRow
                        row = _tableFixedAssetsMaster.Select("ID_FixedAssets=" & DG_FixedAssets.CurrentRow.Cells(2).Value)
                        ' Fabio se tiene que verificar por que da error
                        Dim row2() As DataRow
                        Try
                            row2 = _tableFixedAssetsMaster_image.Select("ID_FixedAssets_FK =" & DG_FixedAssets.CurrentRow.Cells(2).Value)
                            obj.id_FixedAsset_FK = DG_FixedAssets.CurrentRow.Cells(1).Value
                            obj.id_fixedasset_table = DG_FixedAssets.CurrentRow.Cells(2).Value
                            obj.Is_Tangible = DG_FixedAssets.CurrentRow.Cells("tangible").Value
                        Catch ex As Exception

                        End Try
                        If row.Count > 0 Then
                            obj.rowRegistroActual = row(0)
                            Try
                                obj.rowRegistroActual2 = row2(0)
                            Catch ex As Exception
                                obj.rowRegistroActual2 = Nothing
                            End Try
                            If obj.ShowDialog = DialogResult.OK Then
                                GetDataActivoFijo(DG_FixedAssets, 2)
                            End If


                        End If
                    End If
                End Using
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmdReporteActivos_Click(sender As Object, e As EventArgs) Handles cmdReporteActivos.Click
        Using objReporteLegacy As New ERP_Inventory_SelectReportFixedAssetsLegacy()
            objReporteLegacy.Id_Company_FK = _ID_Company
            objReporteLegacy.ShowDialog()
        End Using
    End Sub

    Private Sub cmd_FiltrarReportes_Click(sender As Object, e As EventArgs) Handles cmd_FiltrarReportes.Click
        Using obj As New Financiero_CrearReporte
            'obj.Id_Reporte = dgv_GenericReports.CurrentRow.Cells("Id_Header").Value
            If obj.ShowDialog = DialogResult.OK Then
                'GetDataGenericReportHeader()
            End If
        End Using
    End Sub


    Private Sub btnBuscarActivo_Click(sender As Object, e As EventArgs) Handles btnBuscarActivo.Click
        Using obj As New ERP_Financiero_BuscarActivo
            TransferProcess = 1
            If obj.ShowDialog = DialogResult.OK Then
                GetDataActivoFijo(obj.busqueda, DG_FixedAssets)
            Else
                GetDataActivoFijo(DG_FixedAssets, 2)
            End If
        End Using
    End Sub

    Private Sub BtnTransferenciaArchivo_Click(sender As Object, e As EventArgs) Handles BtnTransferenciaArchivo.Click
        Try
            If Not objSql.ERP_validarSiExisteTransfereciaDeActivo(DG_FixedAssets.CurrentRow.Cells("Id_FixedAssets").Value) Then
                Using obj As New ERP_Transeferencia
                    obj.ID_FixedAssets = DG_FixedAssets.CurrentRow.Cells("Id_FixedAssets").Value
                    obj.Id_employee = DG_FixedAssets.CurrentRow.Cells("Id_ResponsiblePerson_FK").Value
                    obj.ActivoFijo = DG_FixedAssets.CurrentRow.Cells("Name_FiexdAssets").Value
                    obj.fechaIncial = DG_FixedAssets.CurrentRow.Cells("Date_Acquisition").Value

                    If obj.ShowDialog = DialogResult.OK Then
                        GetDataActivoFijo(DG_FixedAssets, 2)
                    End If
                End Using
            Else

                MessageBox.Show("El activo se encuentra en proceso de transferencia de dueño." & vbCrLf & "Espere a que sea Autorizado por su Jefe", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)

                'Dim Result = MessageBox.Show("El activo se encuentra en proceso de transferencia de dueño ¿Desea confirmar transferencia?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                'If Result = System.Windows.Forms.DialogResult.Yes Then
                '    confirmarTransferencia(DG_FixedAssets)
                'End If
            End If
        Catch ex As Exception

        End Try
    End Sub



    Private Sub btnSinAsignar_Click(sender As Object, e As EventArgs) Handles btnSinAsignar.Click
        DG_FixedAssets.DataSource = objSql.ERP_GetFixedAssetsSinAginacion()
        If DG_FixedAssets.Rows.Count > 0 Then
            'Dim imagen As Bitmap = Global.epd_SatelliteERP.My.Resources.Resources.Amarillo_bandera
            'For Each item As DataGridViewRow In DG_FixedAssets.Rows
            '    item.Cells("Imagen").Value = imagen
            'Next
        Else
            MessageBox.Show("Sin activos por asignar", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            GetDataActivoFijo(DG_FixedAssets, 2)
        End If
    End Sub

    Private Sub tcMain_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tcMain.SelectedIndexChanged
        Try
            OptionSelected = sender.SelectedTab.Name
            If sender.SelectedTab.Name = "Amortización" Then
                ListadoAmortizacion("Tod")
            ElseIf sender.SelectedTab.Name = "ActivoFijo" Then
                GetDataActivoFijo(DG_FixedAssets, 2)
            ElseIf sender.SelectedTab.Name = "Translado" Then
                If BanderaShow Then
                    EnProcesoTransferencia("")
                Else
                    MessageBox.Show("No hay Activos en Proceso de Transferencia", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            ElseIf sender.SelectedTab.Name = "Depreciacion" Then
                ListadoDepreciacion("Tod")
            ElseIf sender.SelectedTab.Name = "IndicadoresPersonalizados" Then
                btnIndicadorActivos.PerformClick()
            ElseIf sender.SelectedTab.Name = "Monto" Then
                getDataMontoAdquisicion()
            End If
        Catch ex As Exception
            GetDataActivoFijo(DG_FixedAssets, 2)
        End Try
    End Sub

    Private Sub EnProcesoTransferencia(Busquedad As String)
        Try


            Dim idemployee As Long = 0
            JefeAutorizacion = False
            Try
                Dim PersonalActivoFijo As Integer = 0
                OpcionesMenu = objSql2.GetAccessMenu(_UserSQL)
                Id_Department = _Id_DepartmentGlobal
                If (OpcionesMenu.Rows.Count > 0) Then
                    For Each DataInfo As DataRow In OpcionesMenu.Rows
                        If (DataInfo("rolUser").ToString.ToUpper = "AF_ActivoFijo_All".ToUpper) Then
                            PersonalActivoFijo = 1
                            'Exit For
                        ElseIf (DataInfo("rolUser").ToString.ToUpper = "AF_ActivoFijo_MostrarTodosActivos".ToUpper) Then
                            Id_Department = 0
                            PersonalActivoFijo = 1

                        ElseIf (DataInfo("rolUser").ToString.ToUpper = "AF_ActivoFijo_UsuarioEstandar".ToUpper) Then
                            Id_Department = _Id_DepartmentGlobal
                            PersonalActivoFijo = 0
                            UsuarioEstandar = True
                        ElseIf (DataInfo("rolUser").ToString.ToUpper = "AF_ActivoFijo_JefeUnidad".ToUpper) Then
                            PersonalActivoFijo = 1
                            JefeAutorizacion = True
                            btnConfirmarTransferencia.Text = "Autorizar Transferencia"
                        End If
                    Next
                End If

                If PersonalActivoFijo = 1 Then
                    idemployee = 0
                Else
                    idemployee = _Id_EmployeeGlobal
                End If
            Catch ex As Exception

            End Try


            _tableFixedAssetsMaster = objSql.ERP_GetInventoryTransferinProcess_FixedAssets(_ID_Company, Busquedad, Id_Department, idemployee)

            DG_FixedAssets_Trans.AutoGenerateColumns = False
            DG_FixedAssets.Font = New Font("Segoe UI", 11)
            DG_FixedAssets_Trans.Columns(0).Width = 20
            DG_FixedAssets_Trans.Columns(1).Width = 100
            DG_FixedAssets_Trans.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            DG_FixedAssets_Trans.Columns(2).Width = 200
            DG_FixedAssets_Trans.Columns(3).Width = 200

            DG_FixedAssets_Trans.Columns(4).Width = 125
            'DG_FixedAssets_Trans.Columns(4).DefaultCellStyle.Format = "c"
            DG_FixedAssets_Trans.Columns(5).Width = 100
            DG_FixedAssets_Trans.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

            DG_FixedAssets_Trans.Columns(6).Width = 100
            DG_FixedAssets_Trans.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            DG_FixedAssets_Trans.Columns(7).Width = 200

            DG_FixedAssets_Trans.Columns(8).Width = 200
            DG_FixedAssets_Trans.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            DG_FixedAssets_Trans.Columns(9).Width = 150
            DG_FixedAssets_Trans.Columns(10).Width = 200
            DG_FixedAssets_Trans.Columns(12).Width = 70
            DG_FixedAssets_Trans.Columns(12).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            DG_FixedAssets_Trans.ReadOnly = True
            DG_FixedAssets_Trans.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            DG_FixedAssets_Trans.MultiSelect = False
            DG_FixedAssets_Trans.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
            DG_FixedAssets_Trans.AllowUserToAddRows = False
            DG_FixedAssets_Trans.AllowUserToDeleteRows = False
            DG_FixedAssets_Trans.DataSource = _tableFixedAssetsMaster

            If DG_FixedAssets_Trans.Rows.Count > 0 Then
                Try

                    btnConfirmarTransferencia.Visible = True

                    For Each item As DataGridViewRow In DG_FixedAssets_Trans.Rows
                        If (item.Cells("transferidoA").Value = "AUTORIZACION") Then
                            item.Cells("ImagenA").Value = Anaranjado_Bandera
                        ElseIf (item.Cells("transferidoA").Value = "EN PROCESO") Then
                            item.Cells("ImagenA").Value = Amarillo_bandera
                        ElseIf (item.Cells("transferidoA").Value = "RECHAZADO") Then
                            item.Cells("ImagenA").Value = Morado_Bandera
                        ElseIf (item.Cells("transferidoA").Value = "NO") Then
                            item.Cells("ImagenA").Value = Roja_Bandera
                        Else
                            item.Cells("ImagenA").Value = Verde_Bandera
                        End If
                    Next
                Catch ex As Exception

                End Try
            Else
                MessageBox.Show("Sin activos en proceso de asignación", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                ' GetDataActivoFijo(DG_FixedAssets_Trans)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnConfirmarTransferencia_Click(sender As Object, e As EventArgs) Handles btnConfirmarTransferencia.Click
        'If (objSql.ERP_validarSiTienePermisosTransferenciaDeActivo(id_employe_FK)) Then
        'If objSql.ERP_validarSiExisteTransfereciaDeActivo(DG_FixedAssets_Trans.CurrentRow.Cells("Id_FixedAssets").Value) Then
        Dim ID_ActualRow As String = DG_FixedAssets_Trans.CurrentRow.Cells("IdActual").Value.ToString.Trim
        If UsuarioEstandar And DG_FixedAssets_Trans.CurrentRow.Cells("transferidoA").Value.ToString <> "EN PROCESO" Then
            If DG_FixedAssets_Trans.CurrentRow.Cells("transferidoA").Value <> "RECHAZADO" Then
                MessageBox.Show("La solicitud no ha sido Autorizada", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("La solicitud fue Rechazada por el Gerente", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        ElseIf DG_FixedAssets_Trans.CurrentRow.Cells("transferidoA").Value = "RECHAZADO" And JefeAutorizacion Then
            MessageBox.Show("La solicitud de transferencia ya esta Rechazada", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)

        ElseIf Encargado_ActivoFijo = True Then

            Try
                If objSql.ERP_validarSiExisteTransfereciaDeActivo(DG_FixedAssets_Trans.CurrentRow.Cells(2).Value) Then
                    ID_ActualRow = -1
                    confirmarTransferencia(DG_FixedAssets_Trans)

                Else
                    ID_ActualRow = -1
                    MessageBox.Show("La solicitud de transferencia ya esta cerrada", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)

                End If
            Catch ex As Exception

            End Try
        ElseIf ID_ActualRow <> _Id_EmployeeGlobal And DG_FixedAssets_Trans.CurrentRow.Cells("transferidoA").Value <> "AUTORIZACION" Then
            MessageBox.Show("Usted no puede confirmar la transferencia ya que el activo fijo no le ha sido asignado.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Try
                If objSql.ERP_validarSiExisteTransfereciaDeActivo(DG_FixedAssets_Trans.CurrentRow.Cells(2).Value) Then
                    confirmarTransferencia(DG_FixedAssets_Trans)
                Else
                    MessageBox.Show("La solicitud de transferencia ya esta cerrada", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Catch ex As Exception

            End Try
        End If
        'Else
        'MessageBox.Show("No tienes permisos para transferir el activo", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        'End If
    End Sub

    Private Sub confirmarTransferencia(DGProcesar As DataGridView)
        Using obj As New ERP_ConfirmTransfer
            _tableFixedAssetsMaster = objSql.ERP_GetActivoInventoryTrasnfer(DGProcesar.CurrentRow.Cells(2).Value)
            '_tableFixedAssetsMaster = objSql.ERP_GetActivoInventoryTrasnfer(DGProcesar.CurrentRow.Cells("Id_FixedAssets").Value)


            For Each row As DataRow In _tableFixedAssetsMaster.Rows
                Try
                    obj.idAntiguoDueno = row("id_previous_responsible_FK")
                    obj.idNuevoDueno = row("id_actual_responsible_FK")
                    obj.idMotivoTrans = row("id_reason_FK")
                    obj.ID_FixedAssets = row("ID_FixedAssets_FK")
                    obj.descripcionTrans = row("descripcion_transfers")
                    obj.IdLocationPrimary = row("idlocationPrimary")
                    obj.IdLocationSecundary = row("idlocationsecundary")
                    obj.Autorizacion = False
                    Try
                        If row("autorizado").ToString = "" Then
                            obj.Autorizacion = True
                        ElseIf Not Convert.ToBoolean(row("autorizado")) Then
                            obj.Autorizacion = True
                        End If
                    Catch ex As Exception

                    End Try
                    obj.Aprobacion = True
                    obj.id_trans = CInt(objSql.id_transfer)
                Catch ex As Exception
                    ' No existe cambio unicamente es valor nulo
                End Try
            Next


            obj.activoFijo = DG_FixedAssets_Trans.CurrentRow.Cells("Name_FiexdAssetsA").Value

            If obj.ShowDialog = DialogResult.OK Then
                EnProcesoTransferencia("")
            End If
        End Using
    End Sub

    Private Sub btnReporteTrasnferencias_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnBusquedadAct_Click(sender As Object, e As EventArgs) Handles btnBusquedadAct.Click
        Using obj As New ERP_Financiero_BuscarActivo
            TransferProcess = 0
            If obj.ShowDialog = DialogResult.OK Then
                EnProcesoTransferencia(obj.busqueda)
            Else
                EnProcesoTransferencia("")
            End If
        End Using
    End Sub

    Private Sub BtnAllTransfer_Click(sender As Object, e As EventArgs) Handles BtnAllTransfer.Click
        EnProcesoTransferencia("")
    End Sub

    Private Sub btnIndicadorDptos_Click(sender As Object, e As EventArgs) Handles btnIndicadorDptos.Click
        Try
            Dim dt As DataTable = objSql.ERP_GetIndicadorDepartment_FixedAssets(_ID_Company)
            Dim dtProcess As New DataTable("Info")
            dtProcess.Columns.Add("proceso")
            dtProcess.Columns.Add("transferido")
            dtProcess.Columns.Add("total")
            dtProcess.Columns.Add("department")
            Dim fila As DataRow = dtProcess.NewRow
            If dt.Rows.Count > 0 Then
                fila = dtProcess.NewRow
                fila("proceso") = 0
                fila("transferido") = 0
                fila("total") = 0
                fila("department") = ""

                Dim nombredpto As String = dt.Rows(0).Item("department").ToString
                For Each data As DataRow In dt.Rows
                    If (data("department") = nombredpto) Then

                        If (data("proceso") > 0) Then
                            fila("proceso") = data("proceso")
                        ElseIf (data("transferido") > 0) Then
                            fila("transferido") = data("transferido")
                        ElseIf (data("total") > 0) Then
                            fila("total") = data("total")
                        End If
                        fila("department") = data("department")
                    Else

                        nombredpto = data("department")
                        fila = dtProcess.NewRow
                        If (data("proceso") > 0) Then
                            fila("proceso") = data("proceso")
                        ElseIf (data("transferido") > 0) Then
                            fila("transferido") = data("transferido")
                        ElseIf (data("total") > 0) Then
                            fila("total") = data("total")
                        End If
                        fila("department") = data("department")
                    End If
                Next
                dtProcess.Rows.Add(fila)
                PnIndicadoresActivo.Controls.Clear()
                Dim x As Integer = 0
                Dim y As Integer = 35
                Dim proce As Integer = 0
                Dim trans As Integer = 0
                Dim sintra As Integer = 0
                Dim labelTitle As New Label
                labelTitle.Text = "Indicador de Transferencias por departamento"
                labelTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                labelTitle.Location = New System.Drawing.Point(180, 10)
                labelTitle.Size = New Size(450, 25)
                PnIndicadoresActivo.Controls.Add(labelTitle)
                For Each data As DataRow In dtProcess.Rows
                    proce = Verificar(data("proceso").ToString)
                    trans = Verificar(data("transferido").ToString)
                    sintra = Verificar(data("total").ToString)
                    Dim obj As New IndicadoresActFiDptos()
                    obj.loadControls(trans, proce, sintra, (proce + sintra + trans), data("department"), "")
                    obj.Location = New System.Drawing.Point(x, y)
                    PnIndicadoresActivo.Controls.Add(obj)
                    x += 390
                    If (x Mod 4 = 0) Then
                        y += 220
                        x = 0
                    End If
                Next
            Else
                MessageBox.Show("Sin activos en proceso de asignación", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                ' GetDataActivoFijo(DG_FixedAssets_Trans)
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Function Verificar(ByVal dato As String) As Double
        Try
            Return Convert.ToInt32(dato)
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Private Sub btnProcDepreciacion_Click(sender As Object, e As EventArgs) Handles btnCreateDepreciacion.Click
        Using obj As New Financiero_Procesos_Depreciacion
            obj.BanderaProceso = False
            obj.ShowDialog()
        End Using
        ListadoDepreciacion("Tod")
    End Sub

    Private Sub cmb_PendientesAprob_Click(sender As Object, e As EventArgs) Handles cmb_PendientesAprob.Click
        ListadoDepreciacion("Pend")
    End Sub



    Private Sub cmb_ListadoDepreciaciones_Click(sender As Object, e As EventArgs) Handles cmb_ListadoDepreciaciones.Click
        ListadoDepreciacion("Tod")
    End Sub

    Private Sub ListadoDepreciacion(ByVal Tipo As String)
        Dim dsData As New DataTable
        If Tipo = "Pend" Then
            dsData = objSql.GetFinance_DepreciationPendAproved(_ID_Company)
        ElseIf Tipo = "Tod" Then
            dsData = objSql.GetFinance_HeaderDepreciation(_ID_Company, "")
        Else
            dsData = objSql.GetFinance_HeaderDepreciation(_ID_Company, Tipo)
        End If

        If dsData.Rows.Count > 0 Then
            DGDepreciacion.DataSource = dsData

            DGDepreciacion.AutoGenerateColumns = False
            DGDepreciacion.Font = New Font("Segoe UI", 11)
            DGDepreciacion.Columns(0).Width = 20
            DGDepreciacion.Columns(1).Width = 140
            DGDepreciacion.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            DGDepreciacion.Columns(2).Width = 140
            DGDepreciacion.Columns(3).Width = 300
            DGDepreciacion.Columns(4).Width = 300
            DGDepreciacion.Columns(5).Width = 140
            DGDepreciacion.Columns(6).Width = 100


            DGDepreciacion.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            DGDepreciacion.MultiSelect = False
            DGDepreciacion.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
            DGDepreciacion.AllowUserToAddRows = False
            DGDepreciacion.AllowUserToDeleteRows = False

            Try
                If Tipo = "Pend" Then
                    For Each item As DataGridViewRow In DGDepreciacion.Rows
                        item.Cells("ImagenD").Value = Amarillo_bandera
                    Next
                Else
                    For Each item As DataGridViewRow In DGDepreciacion.Rows
                        If (item.Cells("statusApro").Value = 1) Then
                            item.Cells("ImagenD").Value = Amarillo_bandera
                        ElseIf (item.Cells("statusApro").Value = 2) Then
                            item.Cells("ImagenD").Value = Verde_Bandera
                        Else
                            item.Cells("ImagenD").Value = Roja_Bandera
                        End If
                    Next
                End If
            Catch ex As Exception

            End Try
        Else
            DGDepreciacion.DataSource = Nothing
        End If

    End Sub

    Private Sub ListadoAmortizacion(ByVal Tipo As String)
        Dim dsData As New DataTable
        If Tipo = "Pend" Then
            dsData = objSql.GetFinance_AmortizacionPendAproved(_ID_Company)
        ElseIf Tipo = "Tod" Then
            dsData = objSql.GetFinance_HeaderAmortizacion(_ID_Company, "")
        Else
            dsData = objSql.GetFinance_HeaderAmortizacion(_ID_Company, Tipo)
        End If

        If dsData.Rows.Count > 0 Then
            dgvAmortizacion.DataSource = dsData
            dgvAmortizacion.AutoGenerateColumns = False
            dgvAmortizacion.Font = New Font("Segoe UI", 11)
            dgvAmortizacion.Columns(0).Width = 20
            dgvAmortizacion.Columns(1).Width = 140
            dgvAmortizacion.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dgvAmortizacion.Columns(2).Width = 140
            dgvAmortizacion.Columns(3).Width = 300
            dgvAmortizacion.Columns(4).Width = 300
            dgvAmortizacion.Columns(5).Width = 140
            dgvAmortizacion.Columns(6).Width = 100
            dgvAmortizacion.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            dgvAmortizacion.MultiSelect = False
            dgvAmortizacion.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
            dgvAmortizacion.AllowUserToAddRows = False
            dgvAmortizacion.AllowUserToDeleteRows = False

            Try
                If Tipo = "Pend" Then
                    For Each item As DataGridViewRow In dgvAmortizacion.Rows
                        item.Cells("imagenAmortizacion").Value = Amarillo_bandera
                    Next
                Else
                    For Each item As DataGridViewRow In dgvAmortizacion.Rows
                        If (item.Cells("StatusA").Value = 1) Then
                            item.Cells("imagenAmortizacion").Value = Amarillo_bandera
                        ElseIf (item.Cells("StatusA").Value = 2) Then
                            item.Cells("imagenAmortizacion").Value = Verde_Bandera
                        Else
                            item.Cells("imagenAmortizacion").Value = Roja_Bandera
                        End If
                    Next
                End If
            Catch ex As Exception

            End Try
        Else
            dgvAmortizacion.DataSource = Nothing
        End If

    End Sub


    Private Sub cmb_AprobarDepreciacion_Click(sender As Object, e As EventArgs) Handles cmb_AprobarDepreciacion.Click
        Try
            If (DGDepreciacion.CurrentRow.Cells("status").Value = "En Proceso") Then

                Using obj As New Financiero_Procesos_Depreciacion
                    obj.BanderaProceso = True
                    obj.Id_HeaderDepreciationAproved = DGDepreciacion.CurrentRow.Cells("id_header").Value
                    obj.FechaSeleccionada = DGDepreciacion.CurrentRow.Cells("datedepreciation").Value
                    obj.Descripcion = DGDepreciacion.CurrentRow.Cells("descriptiondepre").Value
                    obj.ShowDialog()
                    ListadoDepreciacion("Tod")
                End Using
            Else
                MessageBox.Show("Esta solicitud ya fue procesada", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnTblDepreciacion_Click(sender As Object, e As EventArgs) Handles btnTblDepreciacion.Click
        Using obj As New Financiero_TablaDepreciacionPorProducto
            Try
                Dim row() As DataRow
                obj.vidaUtil = DG_FixedAssets.CurrentRow.Cells(12).Value
                obj.IdFixedAsset_FK = DG_FixedAssets.CurrentRow.Cells(2).Value
                row = _tableFixedAssetsMaster.Select("ID_FixedAssets=" & DG_FixedAssets.CurrentRow.Cells(2).Value)
                If row.Count > 0 Then
                    obj.rowRegistroActual = row(0)
                    If obj.ShowDialog = DialogResult.OK Then
                        GetDataActivoFijo(DG_FixedAssets, 2)
                    End If

                End If
            Catch ex As Exception
                MessageBox.Show("Sin datos para mostrar", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try

        End Using
    End Sub

    Private Sub btnIndicadorEmpleados_Click(sender As Object, e As EventArgs) Handles btnIndicadorEmpleados.Click
        Try
            Dim dt As DataTable = objSql.ERP_GetIndicadorEmployee_FixedAssets(_ID_Company)

            If dt.Rows.Count > 0 Then
                PnIndicadoresActivo.Controls.Clear()
                Dim ChartArea1 As ChartArea = New ChartArea()
                Dim Legend1 As Legend = New Legend()
                Legend1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                Dim Series1 As Series = New Series()
                Dim Chart1 = New Chart()
                Dim titulo As Title = New Title()
                PnIndicadoresActivo.Controls.Add(Chart1)
                For Each data As DataRow In dt.Rows
                    data("nombre") = "(" & data("total") & ") " & data("nombre")
                Next
                titulo.Text = "Top 10 de Transferencias por Empleado"
                titulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                Chart1.Titles.Add(titulo)
                ChartArea1.Name = "ChartArea1"
                Chart1.ChartAreas.Add(ChartArea1)
                Legend1.Name = "Legend1"
                Chart1.Legends.Add(Legend1)
                Chart1.Location = New System.Drawing.Point(13, 13)
                Chart1.Name = "Chart1"
                Series1.ChartArea = "ChartArea1"
                Series1.Legend = "Legend1"
                Series1.Name = "Series1"
                Series1.IsValueShownAsLabel = True
                Series1.LabelFormat = "#"
                Series1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
                Chart1.Series.Add(Series1)
                Chart1.Size = New System.Drawing.Size(750, 450)
                Chart1.TabIndex = 0
                Chart1.Text = "Chart1"

                Chart1.Series("Series1").XValueMember = "nombre"
                Chart1.Series("Series1").YValueMembers = "total"

                Chart1.DataSource = dt
            Else
                MessageBox.Show("Sin activos en proceso de asignación", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                ' GetDataActivoFijo(DG_FixedAssets_Trans)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnIndicadorActivos_Click(sender As Object, e As EventArgs) Handles btnIndicadorActivos.Click
        Dim ssm As New IndicadoresStatusActivo
        PnIndicadoresActivo.Controls.Add(ssm)

        Try
            Dim dt As DataTable = objSql.ERP_GetIndicadorState_FixedAssets(_ID_Company)
            If dt.Rows.Count > 0 Then
                PnIndicadoresActivo.Controls.Clear()
                Dim x As Integer = 0
                Dim y As Integer = 35
                Dim proce As Integer = 0
                Dim trans As Integer = 0
                Dim sintra As Integer = 0
                Dim Name_Deparmnet As String = dt.Rows(0).Item("Name_Deparmnet")
                Dim DT_BODEGAS_Ua As DataTable = dt.DefaultView.ToTable(True, "Name_Deparmnet")
                Dim labelTitle As New Label
                labelTitle.Text = "Indicador de Estado (Activo Fijo por Departamento)"
                labelTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                labelTitle.Location = New System.Drawing.Point(180, 10)
                labelTitle.Size = New Size(450, 25)
                PnIndicadoresActivo.Controls.Add(labelTitle)

                For i As Integer = 1 To DT_BODEGAS_Ua.Rows.Count

                    Dim DT_BODEGAS_U As DataRow() = dt.Select("Name_Deparmnet='" & DT_BODEGAS_Ua.Rows(i - 1).Item("Name_Deparmnet") & "'")
                    Dim aaa As DataTable = dt.Clone
                    aaa.Rows.Clear()
                    For u As Integer = 0 To DT_BODEGAS_U.Count - 1
                        aaa.ImportRow(DT_BODEGAS_U(u))
                        'dt.Rows.RemoveAt(u)
                    Next
                    aaa.DefaultView.Sort = "total desc"
                    aaa = aaa.DefaultView.ToTable

                    Dim obj As New IndicadoresStatusActivo()
                    obj.dt = aaa
                    obj.loadControls(aaa.Rows(0).Item("Name_Deparmnet"))
                    obj.Location = New System.Drawing.Point(x, y)
                    PnIndicadoresActivo.Controls.Add(obj)
                    x += 370
                    If (i Mod 2 = 0) Then
                        y += 425
                        x = 0
                    End If
                Next
            Else
                MessageBox.Show("Sin activos en proceso de asignación", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                ' GetDataActivoFijo(DG_FixedAssets_Trans)
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles btnReportesDeprec.Click
        Using OBJ As New ERP_ReportDepreciation
            OBJ.ShowDialog()
        End Using
    End Sub

    Private Sub cmdFicharesumidaDeActivo_Click(sender As Object, e As EventArgs) Handles cmdFicharesumidaDeActivo.Click
        Using objResumenActivo As New Ficha_Resumida_activo
            If objResumenActivo.ShowDialog = DialogResult.OK Then
                _FiltradoPor = ""
                If (objResumenActivo.UbicacionPrimaria <> 0) Then
                    _FiltradoPor = "  >>>Ubicacion Primaria: " & objResumenActivo.UbicacionPrimariaText
                End If

                If (objResumenActivo.UbicacionSecundaria <> 0) Then
                    _FiltradoPor += "  >>>Ubicacion Secundaria: " & objResumenActivo.UbicacionSecundariaText
                End If

                If (objResumenActivo.Unidad <> 0) Then
                    _FiltradoPor += "  >>>Unidad : " & objResumenActivo.UnidadText
                End If

                If (objResumenActivo.Responsable <> 0) Then
                    _FiltradoPor += "  >>>Responsable : " & objResumenActivo.ResponsableText
                End If
                _MostrarFiltro = True

                Dim dt As New DataTable
                Using Obj As New Operaciones_SQLServer
                    ' POCASANGRE dt = Obj.SP_ERP_Inventory_Ficha_Resumida_Activo(objResumenActivo.UbicacionPrimaria, objResumenActivo.UbicacionSecundaria, objResumenActivo.Unidad, objResumenActivo.Responsable)
                End Using
                Using objPartidaContable As New Financiero_ReportViewer(dt, "DataSet1", "epd_SatelliteERP.Ficha_Resumida_Activo.rdlc")
                    objPartidaContable.ShowDialog()
                End Using

            End If
        End Using
    End Sub

    Private Sub cmdReporteBajasActivos_Click(sender As Object, e As EventArgs) Handles cmdReporteBajasActivos.Click
        Using objFecha As New Inventario_fechas
            If objFecha.ShowDialog = DialogResult.OK Then
                Dim dt As New DataTable
                Using Obj As New Operaciones_SQLServer
                    ' dt = Obj.SP_ERP_Inventory_ReportePeriodicoBajas(objFecha.Fechainicio, objFecha.FechaFin)
                End Using
                Using objPartidaContable As New Financiero_ReportViewer(dt, "DataSet1", "epd_SatelliteERP.Bajas_Activo_Fijo.rdlc")
                    objPartidaContable.ShowDialog()
                End Using
            End If
        End Using
    End Sub

    Private Sub cmdReporteAltasActivoFijo_Click(sender As Object, e As EventArgs) Handles cmdReporteAltasActivoFijo.Click
        Using objFecha As New Inventario_fechas
            If objFecha.ShowDialog = DialogResult.OK Then
                Dim dt As New DataTable
                Using Obj As New Operaciones_SQLServer
                    'dt = Obj.SP_ERP_Inventory_ReportePeriodicoAltas(objFecha.Fechainicio, objFecha.FechaFin)
                End Using
                Using objPartidaContable As New Financiero_ReportViewer(dt, "DataSet1", "epd_SatelliteERP.Altas_Activo_Fijo.rdlc")
                    objPartidaContable.ShowDialog()
                End Using
            End If
        End Using
    End Sub

    Private Sub cmdReporteContableAltasBajasActivoFijo_Click(sender As Object, e As EventArgs) Handles ReporteContableAltasYBajasDeActivoToolStripMenuItem.Click
        Using objFecha As New Inventario_fechas
            If objFecha.ShowDialog = DialogResult.OK Then
                Dim dt As New DataTable
                Using Obj As New Operaciones_SQLServer
                    dt = Obj.SP_ERP_Inventory_RegistroContableAltasBaja(objFecha.Fechainicio, objFecha.FechaFin)
                End Using
                Using objPartidaContable As New Financiero_ReportViewer(dt, "DataSet1", "epd_SatelliteERP.Registro_Contable_Altas_Bajas_Activo.rdlc")
                    objPartidaContable.ShowDialog()
                End Using
            End If
        End Using
    End Sub

    Private Sub cmdReporteContableDepreaciacion_Click(sender As Object, e As EventArgs) Handles cmdReporteContableDepreaciacion.Click
        If DG_FixedAssets.CurrentRow IsNot Nothing Then
            '' Dim row() As DataRow
            Dim IdActivo As Long = DG_FixedAssets.CurrentRow.Cells(2).Value
            '' row = _tableFixedAssetsMaster.Select("ID_FixedAssets=" & DG_FixedAssets.CurrentRow.Cells(2).Value)
            Using objFecha As New Inventario_fechas
                If objFecha.ShowDialog = DialogResult.OK Then
                    Dim dt As New DataTable
                    Using Obj As New Operaciones_SQLServer
                        dt = Obj.SP_ERP_Inventory_ReportePeriodicoDepreciacionActivoFijoContable(_ID_Company, IdActivo, objFecha.Fechainicio, objFecha.FechaFin)
                    End Using
                    If (dt.Rows.Count > 0) Then
                        Using objPartidaContable As New Financiero_ReportViewer(dt, "DataSet1", "epd_SatelliteERP.Reporte_Contable_Depreciacion.rdlc")
                            objPartidaContable.ShowDialog()
                        End Using
                    Else
                        MessageBox.Show("No hay informacion para mostrar, favor generar la Depreciación", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If


                End If
            End Using
        Else
            MessageBox.Show("Seleccione un activo", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End If

    End Sub

    Private Sub cmdFichaTransparenciaa_Click(sender As Object, e As EventArgs) Handles cmdFichaTransparencia.Click
        Using obj As New Ficha_Transparencia
            If (obj.ShowDialog = DialogResult.OK) Then
                Dim dt As New DataTable
                Using ObjSQL As New Operaciones_SQLServer
                    'dt = ObjSQL.SP_ERP_Inventory_ReporteTransparencia(obj.id_tipo, obj.Monto)
                End Using
                Using objPartidaContable As New Financiero_ReportViewer(dt, "DataSet1", "epd_SatelliteERP.Ficha_Transparencia.rdlc")
                    objPartidaContable.ShowDialog()
                End Using
            End If
        End Using
    End Sub

    Private Sub cmdCuadroDepreciacion_Click(sender As Object, e As EventArgs) Handles cmdCuadroDepreciacion.Click
        Using objFecha As New Inventario_fechas
            If objFecha.ShowDialog = DialogResult.OK Then
                Dim dt As New DataTable
                Using Obj As New Operaciones_SQLServer
                    ' dt = Obj.SP_ERP_inventory_Cuadro_Depreciacion(objFecha.Fechainicio, objFecha.FechaFin)
                End Using
                Using objPartidaContable As New Financiero_ReportViewer(dt, "DataSet1", "epd_SatelliteERP.Reporte_Cuadro_Depreciacion.rdlc")
                    objPartidaContable.ShowDialog()
                End Using
            End If
        End Using
    End Sub

    Private Sub btnBienesCapitalizables_Click(sender As Object, e As EventArgs) Handles btnBienesCapitalizables.Click
        Using obj As New Ficha_Transparencia
            If (obj.ShowDialog = DialogResult.OK) Then
                Dim dt As New DataTable
                Using ObjSQL As New Operaciones_SQLServer
                    ' dt = ObjSQL.SP_ERP_Inventory_Detalle_General_Bienes(obj.id_tipo, obj.Monto)
                End Using
                Try
                    If (dt.Rows.Count > 0) Then
                        Using objPartidaContable As New Financiero_ReportViewer(dt, "DataSet1", "epd_SatelliteERP.Reporte_Detalle_General_Bienes_Capitalizables.rdlc")
                            objPartidaContable.ShowDialog()
                        End Using
                    Else
                        MessageBox.Show("No hay informacion para mostrar, favor generar la Depreciación", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information )
                    End If
                Catch ex As Exception

                End Try
            End If
        End Using
    End Sub

    Private Sub cmdModifcarMonto_Click(sender As Object, e As EventArgs) Handles cmdModifcarMonto.Click
        Using objAdd As New Configurar_Monto_Adquisicion

            objAdd._cantidad = DGWMontoAdquisicion.CurrentRow.Cells("Amount").Value

            objAdd._descripcion = DGWMontoAdquisicion.CurrentRow.Cells("Description").Value.ToString

            If objAdd.ShowDialog() = DialogResult.OK Then
                getDataMontoAdquisicion()
            End If
        End Using
    End Sub

    Private Sub cmdReportesActivos_Click(sender As Object, e As EventArgs) Handles btnReporteTrasnferencias.Click
        Using obj As New ERP_ReportTrasnfer
            obj._Asistente = AsistenteAdministrativo
            If obj.ShowDialog = DialogResult.OK Then
                GetDataActivoFijo(DG_FixedAssets_Trans, 2)
            End If
        End Using
        _MostrarFiltro = False
    End Sub

    Private Sub cmdReportePeriodicoDepreciacionActivo_Click(sender As Object, e As EventArgs) Handles cmdReportePeriodicoDepreciacionActivo.Click

        If DG_FixedAssets.CurrentRow IsNot Nothing Then
            '' Dim row() As DataRow
            Dim IdActivo As Long = DG_FixedAssets.CurrentRow.Cells(2).Value
            '' row = _tableFixedAssetsMaster.Select("ID_FixedAssets=" & DG_FixedAssets.CurrentRow.Cells(2).Value)
            Using objFecha As New Inventario_fechas
                If objFecha.ShowDialog = DialogResult.OK Then
                    Dim dt As New DataTable
                    Using Obj As New Operaciones_SQLServer
                        dt = Obj.SP_ERP_Inventory_ReportePeriodicoDepreciacionActivoFijo(objFecha.Fechainicio, objFecha.FechaFin, IdActivo)
                    End Using
                    Using objPartidaContable As New Financiero_ReportViewer(dt, "DataSet1", "epd_SatelliteERP.Reporte_periodico_Depreciacion_Activos.rdlc")
                        objPartidaContable.ShowDialog()
                    End Using
                End If
            End Using
        Else
            MessageBox.Show("Seleccione un activo", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End If
    End Sub

    Private Sub ReporteDeAmortizaciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteDeAmortizaciónToolStripMenuItem.Click
        Dim dt As New DataTable
        Using Obj As New Operaciones_SQLServer
            ' dt = Obj.SP_ERP_Inventory_ReporteAmortizacion()
        End Using
        Using objPartidaContable As New Financiero_ReportViewer(dt, "Informacion", "epd_SatelliteERP.Reporte_deAmortizacion.rdlc")
            objPartidaContable.ShowDialog()
        End Using
    End Sub

    Private Sub cmdDescargados_Click(sender As Object, e As EventArgs) Handles cmdDescargados.Click
        GetDataActivoFijoDescargado(DG_FixedAssets)
    End Sub


    Private Sub ActTodos_Click(sender As Object, e As EventArgs) Handles ActTodos.Click
        GetDataActivoFijo(DG_FixedAssets, 2)
    End Sub

    Private Sub ActTangibles_Click(sender As Object, e As EventArgs) Handles ActTangibles.Click
        GetDataActivoFijo(DG_FixedAssets, 1)
    End Sub

    Private Sub ActIntangibles_Click(sender As Object, e As EventArgs) Handles ActIntangibles.Click
        GetDataActivoFijo(DG_FixedAssets, 0)
    End Sub

    Private Sub cmdMovimientoActivo_Click(sender As Object, e As EventArgs) Handles cmdMovimientoActivo.Click
        Try
            If DG_FixedAssets_Trans.CurrentRow.Cells("transferidoA").Value = "SI" Then
                Dim ds As New DataSet
                Using objSQL As New Financiero_SQLServer
                    ds = objSQL.ERP_GetActivoInventoryTrasnferReport(DG_FixedAssets_Trans.CurrentRow.Cells("Id_FixedAssetsA").Value, DG_FixedAssets_Trans.CurrentRow.Cells("id_transferencia").Value, 0)
                End Using

                If (Not ds Is Nothing) Then
                    If (ds.Tables.Count > 0) Then
                        If (ds.Tables(0).Rows.Count > 0) Then
                            Dim dt As New DataTable
                            dt = ds.Tables(0)
                            Using objPartidaContable As New Financiero_ReportViewer(dt, "DataSet1", "epd_SatelliteERP.Reporte_TransferenciaActivoFijo.rdlc")
                                objPartidaContable.ShowDialog()
                            End Using
                        End If
                    End If
                End If
            ElseIf DG_FixedAssets_Trans.CurrentRow.Cells("transferidoA").Value = "EN PROCESO" Then
                MessageBox.Show("La solicitud de transferencia se encuentra en Proceso.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("La solicitud de transferencia fue Denegada.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub cmdVerDepreciacion_Click(sender As Object, e As EventArgs) Handles cmdVerDepreciacion.Click
        Try

            Using obj As New Financiero_Procesos_Depreciacion
                obj.BanderaProceso = True
                obj.ShowDepreciation = True
                obj.Id_HeaderDepreciationAproved = DGDepreciacion.CurrentRow.Cells("id_header").Value
                obj.FechaSeleccionada = DGDepreciacion.CurrentRow.Cells("datedepreciation").Value
                obj.Descripcion = DGDepreciacion.CurrentRow.Cells("descriptiondepre").Value

                obj.ShowDialog()
                ListadoDepreciacion("Tod")
            End Using
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmdBuscarDepreciacion_Click(sender As Object, e As EventArgs) Handles cmdBuscarDepreciacion.Click
        Using obj As New ERP_Financiero_BuscarActivo
            TransferProcess = 1
            If obj.ShowDialog = DialogResult.OK Then
                ListadoDepreciacion(obj.busqueda)
            Else
                ListadoDepreciacion("Tod")
            End If
        End Using

    End Sub

    Private Sub btnCrearAmortizacion_Click(sender As Object, e As EventArgs) Handles btnCrearAmortizacion.Click
        Using obj As New Financiero_Procesos_Amortizacion
            obj.BanderaProceso = False
            obj.ShowDialog()
        End Using
        ListadoAmortizacion("Tod")
    End Sub

    Private Sub btnVerAmortizacion_Click(sender As Object, e As EventArgs) Handles btnVerAmortizacion.Click
        Try

            Using obj As New Financiero_Procesos_Amortizacion
                obj.BanderaProceso = True
                obj.ShowAmortizacion = True
                obj.Id_HeaderAmortizacionAproved = dgvAmortizacion.CurrentRow.Cells("id_headerA").Value
                obj.FechaSeleccionada = dgvAmortizacion.CurrentRow.Cells("dateamortizacion").Value
                obj.Descripcion = dgvAmortizacion.CurrentRow.Cells("descriptionamortizacion").Value

                obj.ShowDialog()
                ListadoDepreciacion("Tod")
            End Using
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnPendientes_Click(sender As Object, e As EventArgs) Handles btnPendientesAmortizacion.Click
        ListadoAmortizacion("Pend")
    End Sub

    Private Sub btnListadoAmortizaciones_Click(sender As Object, e As EventArgs) Handles btnListadoAmortizaciones.Click
        ListadoAmortizacion("Tod")
    End Sub

    Private Sub btnAprobarAmortizacion_Click(sender As Object, e As EventArgs) Handles btnAprobarAmortizacion.Click
        Try
            If (dgvAmortizacion.CurrentRow.Cells("EstadoAmortizacion").Value = "En Proceso") Then

                Using obj As New Financiero_Procesos_Amortizacion
                    obj.BanderaProceso = True
                    obj.Id_HeaderAmortizacionAproved = dgvAmortizacion.CurrentRow.Cells("id_headerA").Value
                    obj.FechaSeleccionada = dgvAmortizacion.CurrentRow.Cells("dateAmortizacion").Value
                    obj.Descripcion = dgvAmortizacion.CurrentRow.Cells("descriptionAmortizacion").Value
                    obj.ShowDialog()
                    ListadoAmortizacion("Tod")
                End Using
            Else
                MessageBox.Show("Esta solicitud ya fue procesada", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnBuscarAmortizacion_Click(sender As Object, e As EventArgs) Handles btnBuscarAmortizacion.Click
        Using obj As New ERP_Financiero_BuscarActivo
            TransferProcess = 1
            If obj.ShowDialog = DialogResult.OK Then
                ListadoAmortizacion(obj.busqueda)
            Else
                ListadoAmortizacion("Tod")
            End If
        End Using
    End Sub

    Private Sub btnReporteAmortizacion_Click(sender As Object, e As EventArgs) Handles btnReporteAmortizacion.Click

        Try
            If (dgvAmortizacion.CurrentRow.Cells("EstadoAmortizacion").Value = "Aprobado") Then

                Dim IdHeader As Integer = dgvAmortizacion.CurrentRow.Cells("id_headerA").Value

                Dim dt As New DataTable
                Using Obj As New Operaciones_SQLServer
                    dt = Obj.SP_ERP_Inventory_ReporteAmortizacion(_ID_Company, IdHeader)
                End Using
                Using objPartidaContable As New Financiero_ReportViewer(dt, "Informacion", "epd_SatelliteERP.Reporte_deAmortizacion.rdlc")
                    objPartidaContable.ShowDialog()
                End Using
            Else
                MessageBox.Show("Esta Amortización no esta aprobada", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DG_FixedAssets_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DG_FixedAssets.CellContentClick

    End Sub

    Private Sub DG_FixedAssets_Trans_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DG_FixedAssets_Trans.CellContentClick

    End Sub
End Class
