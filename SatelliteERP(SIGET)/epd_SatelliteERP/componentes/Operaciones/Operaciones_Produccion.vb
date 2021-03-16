Imports System.IO

Public Class Operaciones_Produccion
	Private objOperacion As New Operaciones_SQLServer
	Private objGeneric As New Generic_SQLServer
	Private _tableArticulos As DataTable
	Private _tableCustomer As DataTable
	Private _TypeCustomer As Long = 0
	Private id_lote As Integer = 0
	Private id_proceso As Integer = 0
	Private _id_cicloAct As Integer = 0
	Private _id_cicloRefe As Integer = 0
	Private _tableLote As DataTable
	Private _tableAnimals As DataTable
	Private _tableDescargaPro As DataTable
    REM` Private _tableInvoiceHeader As DataTable

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

	Sub New(ByVal load As Boolean)

        ' This call is required by the designer.
        InitializeComponent()
		GetLotes()
        ' Add any initialization after the InitializeComponent() call.

    End Sub
	Private Sub GetLotes()
        _tableLote = objGeneric.GetLotes(Data_Id_Company, 30, "1,2,3,4,5,6", 1)
        FLIndicators.Controls.Clear()

        For Each row As DataRow In _tableLote.Rows
            Dim obj As New Indicadores(Me)
            If Not row Is Nothing Then
                obj.loadControls(row("DiasMaximo"), row("PromedioDias"), row("NoSeleccionados"), row("NoTotal"), row("Picture"), row("Ciclo"), row("Flujo"), row("DiasRojo"), row("DiasAmarillo"), row("DiasVerde"))
            End If
            FLIndicators.Controls.Add(obj)
        Next row

        'DGVClientes.DataSource = _tableCustomer
    End Sub
    Private Sub tcMain_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tcMain.SelectedIndexChanged
        If sender.SelectedTab.Name = "Lista_Productos_proceso" Then
            GetDataProductProcess()
        ElseIf sender.SelectedTab.Name = "Articulos" Then

		ElseIf sender.Selectedtab.Name = "ClientesProveedores" Then

		ElseIf sender.Selectedtab.Name = "Indicadores" Then
            GetLotes()
        ElseIf sender.Selectedtab.Name = "StatusDiasVacio" Then
            GetLotesVacio()
        ElseIf sender.Selectedtab.Name = "Animales" Then
            GetAnimals()
        ElseIf sender.Selectedtab.Name = "DescargaProductos" Then
            GetDescargaProductos()
        ElseIf sender.Selectedtab.Name = "Genetica" Then
            GetGeneticaAnimales()
        ElseIf sender.Selectedtab.Name = "TipoOrigen" Then
            GetTipoOrigen()
        ElseIf sender.Selectedtab.Name = "OrigenAnimal" Then
            GetOrigen()
        ElseIf sender.selectedtab.name = "GrupoAnimales" Then
            GetAnimalGroup()
        End If
    End Sub

    Private Sub GetDataProductProcess()
        _tableArticulos = objGeneric.GetProductProcess(Data_Id_Company, "%%")
        DGW_ProductsProcess.AutoGenerateColumns = False
        DGW_ProductsProcess.Font = New Font("Segoe UI", 11)
        DGW_ProductsProcess.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
        DGW_ProductsProcess.ReadOnly = True
        DGW_ProductsProcess.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DGW_ProductsProcess.MultiSelect = False
        DGW_ProductsProcess.AllowUserToResizeColumns = False
        DGW_ProductsProcess.AllowUserToAddRows = False
        DGW_ProductsProcess.AllowUserToDeleteRows = False
        DGW_ProductsProcess.Columns(0).Width = 75
        DGW_ProductsProcess.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
        DGW_ProductsProcess.Columns(1).Width = 220
        DGW_ProductsProcess.Columns(2).Width = 220
        DGW_ProductsProcess.Columns(3).Width = 150
        DGW_ProductsProcess.Columns(4).Width = 150
        DGW_ProductsProcess.Columns(5).Width = 100
        DGW_ProductsProcess.Columns(6).Width = 100
        DGW_ProductsProcess.Columns(7).Width = 100
        DGW_ProductsProcess.Columns(8).Width = 100
        DGW_ProductsProcess.DataSource = _tableArticulos
        For Each row As DataGridViewRow In DGW_ProductsProcess.Rows
            If row.Cells("IS_StageAlarm").Value = True Then
                row.DefaultCellStyle.BackColor = Color.Red
            End If

        Next
    End Sub



	Private Sub cmdReporteCatalogoCliente_Click(sender As Object, e As EventArgs) Handles cmdCreateLote.Click

        Using obj As New createLot
            obj.ShowDialog()
        End Using
        GetDataProductProcess()
    End Sub

    Private Sub cmdReporteProveedores_Click(sender As Object, e As EventArgs) Handles cmdReporteProveedores.Click
        Try

            id_lote = DGW_ProductsProcess.CurrentRow.Cells(0).Value
            Dim EstapaCompleta As Boolean = False
            Dim ScreenToTun As String = ""
            Dim id_etapa As Long = 0
            Dim ID_Stowage_FK As Long = 1
            For Each row As DataRow In _tableArticulos.Select("id_production=" & id_lote.ToString)
                Try
                    EstapaCompleta = row("IS_CompletedPhase")
                Catch ex As Exception
                    EstapaCompleta = False
                End Try
                Try
                    REM "Salida diaria Producto"
                    ScreenToTun = row("ScreenToTun")
                Catch ex As Exception

                End Try
                Try
                    id_etapa = row("ID_Process")
                Catch ex As Exception

                End Try
                Try
                    ID_Stowage_FK = row("ID_Stowage_FK")
                Catch ex As Exception
                    ID_Stowage_FK = 0
                End Try
                Exit For
            Next
            If Not EstapaCompleta Then


                id_proceso = DGW_ProductsProcess.CurrentRow.Cells(9).Value
                _id_cicloAct = DGW_ProductsProcess.CurrentRow.Cells("Id_Circle").Value
                _id_cicloRefe = DGW_ProductsProcess.CurrentRow.Cells(11).Value
                If ScreenToTun = "Salida diaria Producto" Then
                    Using obj As New Production_AnimalsToSacrifice
                        id_lote = DGW_ProductsProcess.CurrentRow.Cells(0).Value
                        obj.ID_Etapa = DGW_ProductsProcess.CurrentRow.Cells(9).Value
                        obj.ID_Etapa = id_etapa
                        obj.ID_Lot = id_lote
                        obj.IS_ProductSelect = True
                        obj.ID_StowageCurrent = ID_Stowage_FK
                        obj.StartPosition = FormStartPosition.CenterParent
                        obj.ShowDialog()
                    End Using
                ElseIf ScreenToTun = "Pantalla de Sacrificio" Then
                    Using obj As New Production_AnimalsToSacrifice
                        id_lote = DGW_ProductsProcess.CurrentRow.Cells(0).Value
                        obj.ID_Etapa = DGW_ProductsProcess.CurrentRow.Cells(9).Value
                        obj.ID_Etapa = id_etapa
                        obj.ID_Lot = id_lote
                        obj.ID_StowageCurrent = ID_Stowage_FK
                        obj.StartPosition = FormStartPosition.CenterParent
                        obj.ShowDialog()
                    End Using
                ElseIf ScreenToTun = "Produccion" Then
                    Using obj As New Production_AnimalsToSacrifice
                        id_lote = DGW_ProductsProcess.CurrentRow.Cells(0).Value
                        obj.ID_Etapa = DGW_ProductsProcess.CurrentRow.Cells(9).Value
                        obj.ID_Etapa = id_etapa
                        obj.ID_Lot = id_lote
                        obj.ID_ProductFinal = DGW_ProductsProcess.CurrentRow.Cells("ID_Product_FK").Value
                        obj.IS_Products = 1
                        obj.ID_StowageCurrent = ID_Stowage_FK
                        obj.StartPosition = FormStartPosition.CenterParent
                        obj.ShowDialog()
                    End Using
                ElseIf ScreenToTun = "Salida Programada Producto" Then
                    Dim procesado As Integer = 0
                    Dim resp As Integer = 0

                    Using objSQL As New Operaciones_SQLServer
                        procesado = objSQL.ERP_Prod_SP_DaysOfExtraction(id_lote, 1)
                    End Using

                    If procesado = 1 Then

                        If (MessageBox.Show("Ya se ha procesado la salida para este lote, ¿desea procesar otra salida?", "Información", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)) = DialogResult.OK Then
                            Using objSQL As New Operaciones_SQLServer
                                resp = objSQL.ERP_Prod_SP_DaysOfExtraction(id_lote, 0)
                            End Using
                            If resp = 1 Then
                                Using obj As New Production_AnimalsToSacrifice
                                    id_lote = DGW_ProductsProcess.CurrentRow.Cells(0).Value
                                    obj.ID_Etapa = DGW_ProductsProcess.CurrentRow.Cells(9).Value
                                    obj.ID_Etapa = id_etapa
                                    obj.ID_Lot = id_lote
                                    obj.IS_ProductSelect = True
                                    obj.ID_ProductFinal = DGW_ProductsProcess.CurrentRow.Cells("ID_Product_FK").Value
                                    obj.IS_Products = 1
                                    obj.FinalizarLote = False
                                    obj.ID_StowageCurrent = ID_Stowage_FK
                                    obj.StartPosition = FormStartPosition.CenterParent
                                    obj.ShowDialog()
                                End Using
                            End If
                        End If
                    Else
                        Using objSQL As New Operaciones_SQLServer
                            resp = objSQL.ERP_Prod_SP_DaysOfExtraction(id_lote, 0)
                        End Using

                        If resp = 1 Then
                            Using obj As New Production_AnimalsToSacrifice
                                id_lote = DGW_ProductsProcess.CurrentRow.Cells(0).Value
                                obj.ID_Etapa = DGW_ProductsProcess.CurrentRow.Cells(9).Value
                                obj.ID_Etapa = id_etapa
                                obj.ID_Lot = id_lote
                                obj.IS_ProductSelect = True
                                obj.ID_ProductFinal = DGW_ProductsProcess.CurrentRow.Cells("ID_Product_FK").Value
                                obj.IS_Products = 1
                                obj.FinalizarLote = False
                                obj.ID_StowageCurrent = ID_Stowage_FK
                                obj.StartPosition = FormStartPosition.CenterParent
                                obj.ShowDialog()
                            End Using
                        End If
                    End If
                Else


                    If (_id_cicloAct = 4) Then
                        Using objPesos As New Production_Procesar
                            objPesos.Id_Proceso = id_proceso
                            objPesos.Id_Lote = id_lote
                            objPesos.CicloAct = _id_cicloAct
                            objPesos.CicloRef = _id_cicloRefe
                            objPesos.Pantalla = False
                            objPesos.IS_StageAlarm = DGW_ProductsProcess.CurrentRow.Cells("IS_StageAlarm").Value
                            If Not objPesos.ShowDialog() = DialogResult.OK Then
                                Exit Sub
                            End If
                        End Using
                    ElseIf id_proceso = 12 Then '' Finalizacio
                        Using obj As New Production_AnimalsToSacrifice
                            id_lote = DGW_ProductsProcess.CurrentRow.Cells(0).Value
                            obj.ID_Etapa = DGW_ProductsProcess.CurrentRow.Cells(9).Value
                            obj.ID_Etapa = 12 ' borrar
                            obj.ID_Lot = id_lote
                            obj.StartPosition = FormStartPosition.CenterParent
                            obj.ShowDialog()
                        End Using
                    ElseIf id_proceso = 6 Then
                        REM no hace nada
                    Else

                        Using obj As New Production_Procesar
                            obj.Id_Proceso = id_proceso
                            obj.CicloAct = _id_cicloAct
                            obj.CicloRef = _id_cicloRefe
                            obj.Id_Lote = id_lote
                            obj.IS_StageAlarm = DGW_ProductsProcess.CurrentRow.Cells("IS_StageAlarm").Value
                            obj.ShowDialog()
                        End Using
                    End If
                End If
            Else

                MessageBox.Show("La etapa está completa, no se puede modificar", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            If (DGW_ProductsProcess.Rows.Count >= 0) Then
                MessageBox.Show("Debe seleccionar un Lote", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End Try
        GetDataProductProcess()
    End Sub

    Private Sub cmdCatalogoClienteFinanciero_Click(sender As Object, e As EventArgs) Handles cmdCatalogoClienteFinanciero.Click
        Try
            id_lote = -1 ' El parametro tiene que ser -1 para entre a todo el proyecto
            id_proceso = 3 ' no importa el parametro no se utiliza en esta condicion

            Using objHours As New Production_SelectedHours
                objHours.IdProcess = id_proceso
                objHours.ShowDialog()
                If (objHours.IdHours <> 0) Then

                    Using obj As New Production_Resumen
                        obj.ID_Process = id_proceso
                        obj.ID_Lot = id_lote
                        obj.ID_Hours = objHours.IdHours
                        obj.TipoReport = "General"
                        obj.ShowDialog()
                    End Using
                End If
            End Using
        Catch ex As Exception
            If (DGW_ProductsProcess.Rows.Count >= 0) Then
                MessageBox.Show("Debe seleccionar un Lote", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End Try

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) 
        Using Objcreate As New ERP_ClientesCuentasPorCobrar
            If _TypeCustomer = 1 Then
                Objcreate.TipoConsulta = ERP_ClientesCuentasPorCobrar.Proceso.Clientes
                Objcreate.OpcionSeleccionada = ERP_ClientesCuentasPorCobrar.Funcion.Actualizar
            ElseIf _TypeCustomer = 2 Then
                Objcreate.TipoConsulta = ERP_ClientesCuentasPorCobrar.Proceso.Proveedores
                Objcreate.OpcionSeleccionada = ERP_ClientesCuentasPorCobrar.Funcion.Agregar
            End If
            If Objcreate.ShowDialog() = DialogResult.OK Then

			End If
        End Using
    End Sub

	'

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

    Private Sub cmdModLote_Click(sender As Object, e As EventArgs) Handles cmdModLote.Click
        Try
            Dim id_lote As Integer = DGW_ProductsProcess.CurrentRow.Cells(0).Value
            Using obj As New createLot
                obj.Id_loteP = id_lote
                obj.ShowDialog()
            End Using
            GetDataProductProcess()
        Catch ex As Exception
            If (DGW_ProductsProcess.Rows.Count >= 0) Then
                MessageBox.Show("Debe seleccionar un Lote", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End Try

    End Sub

    Private Sub btnFormDinamico_Click(sender As Object, e As EventArgs) Handles btnFormDinamico.Click
        Try
            Dim id As Integer = DGW_ProductsProcess.CurrentRow.Cells(9).Value
            Using obj As New FormDinamico

                obj.Correlativo = id
                obj.ShowDialog()
            End Using
        Catch ex As Exception
            If (DGW_ProductsProcess.Rows.Count >= 0) Then
                MessageBox.Show("Debe seleccionar un Lote", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End Try

    End Sub

    Private Sub GetLotesVacio()
        _tableLote = objGeneric.GetLotesVacio(Data_Id_Company)
        FLStatusDiasVacio.Controls.Clear()

        For Each row As DataRow In _tableLote.Rows
            Dim obj As New StatusDiasVacio(Me)
            If Not row Is Nothing Then
                obj.loadControls(row("CodigoAnimal"), row("nombre"), row("diasvacio"))
            End If
            FLStatusDiasVacio.Controls.Add(obj)
        Next row

        'DGVClientes.DataSource = _tableCustomer
    End Sub

    Private Sub GetAnimals()
        _tableAnimals = objGeneric.GetAnimalsList(0, "")
        DGVAnimals.DataSource = _tableAnimals
    End Sub
    Private Sub GetDescargaProductos()
        _tableDescargaPro = objOperacion.ERP_Prod_ConsumptionFlowproducts_Select()
        DGW_DescargaProductos.AutoGenerateColumns = False


        DGW_DescargaProductos.Font = New Font("Segoe UI", 11)
        REM DGW_DescargaProductos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
        DGW_DescargaProductos.ReadOnly = True
        DGW_DescargaProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DGW_DescargaProductos.MultiSelect = False

        DGW_DescargaProductos.AllowUserToAddRows = False
        DGW_DescargaProductos.AllowUserToDeleteRows = False
        DGW_DescargaProductos.Columns(0).Width = 100
        DGW_DescargaProductos.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
        DGW_DescargaProductos.Columns(1).Width = 200
        DGW_DescargaProductos.Columns(2).Width = 200
        DGW_DescargaProductos.Columns(3).Width = 200
        DGW_DescargaProductos.Columns(4).Width = 200
        DGW_DescargaProductos.Columns(5).Width = 100
        DGW_DescargaProductos.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
        DGW_DescargaProductos.Columns(6).Width = 100
        DGW_DescargaProductos.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight

        DGW_DescargaProductos.DataSource = _tableDescargaPro
    End Sub
    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Using obj As New Production_AddAnimals
            If obj.ShowDialog() = DialogResult.OK Then
                GetAnimals()
            End If
        End Using
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Dim resul As DialogResult = Nothing
        If DGVAnimals.CurrentRow IsNot Nothing Then
            Using ObjUpdate As New Production_AddAnimals
                Try
                    If (IsDBNull(DGVAnimals.CurrentRow.Cells("Nombre del Animal").Value)) Then
                        ObjUpdate.txtNombreAnimalc.Text = ""
                    Else
                        ObjUpdate.txtNombreAnimalc.Text = DGVAnimals.CurrentRow.Cells("Nombre del Animal").Value
                    End If

                    If (IsDBNull(DGVAnimals.CurrentRow.Cells("Codigo Animal").Value)) Then
                        ObjUpdate.txtCodigoAnimalc.Text = ""
                    Else
                        ObjUpdate.txtCodigoAnimalc.Text = DGVAnimals.CurrentRow.Cells("Codigo Animal").Value
                    End If

                    If (IsDBNull(DGVAnimals.CurrentRow.Cells("Fecha Proceso").Value)) Then
                        ObjUpdate.mcFechaProcesoc.Value = Date.Today
                    Else
                        ObjUpdate.mcFechaProcesoc.Value = DGVAnimals.CurrentRow.Cells("Fecha Proceso").Value
                    End If

                    If (IsDBNull(DGVAnimals.CurrentRow.Cells("ciclo").Value)) Then
                        ObjUpdate.cmbCicloc.Text = ""
                    Else

                    End If

                    If (IsDBNull(DGVAnimals.CurrentRow.Cells("Registro Animal").Value)) Then
                        ObjUpdate.txtRegistroAnimalc.Text = ""
                    Else
                        ObjUpdate.txtRegistroAnimalc.Text = DGVAnimals.CurrentRow.Cells("Registro Animal").Value
                    End If

                    If (IsDBNull(DGVAnimals.CurrentRow.Cells("Genetica").Value)) Then
                        ObjUpdate.cmbGeneticac.Text = ""
                    Else
                        ObjUpdate.cmbGeneticac.Text = DGVAnimals.CurrentRow.Cells("Genetica").Value
                    End If

                    If (IsDBNull(DGVAnimals.CurrentRow.Cells("Fecha de Nacimiento").Value)) Then
                        ObjUpdate.mcFechaNacimientoc.Text = ""
                    Else
                        ObjUpdate.mcFechaNacimientoc.Text = DGVAnimals.CurrentRow.Cells("Fecha de Nacimiento").Value
                    End If

                    If (IsDBNull(DGVAnimals.CurrentRow.Cells("Codigo de Manada").Value)) Then
                        ObjUpdate.txtCodigoCamadac.Text = ""
                    Else
                        ObjUpdate.txtCodigoCamadac.Text = DGVAnimals.CurrentRow.Cells("Codigo de Manada").Value
                    End If

                    If (IsDBNull(DGVAnimals.CurrentRow.Cells("Tipo de Origen").Value)) Then
                        ObjUpdate.cmbTipoOrigenc.Text = ""
                    Else
                        ObjUpdate.cmbTipoOrigenc.Text = DGVAnimals.CurrentRow.Cells("Tipo de Origen").Value
                    End If

                    If (IsDBNull(DGVAnimals.CurrentRow.Cells("Origen").Value)) Then
                        ObjUpdate.cmbOrigenc.Text = ""
                    Else
                        ObjUpdate.cmbOrigenc.Text = DGVAnimals.CurrentRow.Cells("Origen").Value
                    End If

                    If (IsDBNull(DGVAnimals.CurrentRow.Cells("Lugar de Inicio").Value)) Then
                        ObjUpdate.txtLugarInicioc.Text = ""
                    Else
                        ObjUpdate.txtLugarInicioc.Text = DGVAnimals.CurrentRow.Cells("Lugar de Inicio").Value
                    End If

                    If (IsDBNull(DGVAnimals.CurrentRow.Cells("Padre").Value)) Then
                        ObjUpdate.txtPadrec.Text = ""
                    Else
                        ObjUpdate.txtPadrec.Text = DGVAnimals.CurrentRow.Cells("Padre").Value
                    End If

                    If (IsDBNull(DGVAnimals.CurrentRow.Cells("Madre").Value)) Then
                        ObjUpdate.txtMadrec.Text = ""
                    Else
                        ObjUpdate.txtMadrec.Text = DGVAnimals.CurrentRow.Cells("Madre").Value
                    End If

                    If (IsDBNull(DGVAnimals.CurrentRow.Cells("Precio").Value)) Then
                        ObjUpdate.txtPrecioc.Text = ""
                    Else
                        ObjUpdate.txtPrecioc.Text = DGVAnimals.CurrentRow.Cells("Precio").Value
                    End If

                    If (IsDBNull(DGVAnimals.CurrentRow.Cells("Comentario de Animal").Value)) Then
                        ObjUpdate.txtComentariosc.Text = ""
                    Else
                        ObjUpdate.txtComentariosc.Text = DGVAnimals.CurrentRow.Cells("Comentario de Animal").Value
                    End If

                    If (IsDBNull(DGVAnimals.CurrentRow.Cells("Peso").Value)) Then
                        ObjUpdate.txtPesoc.Text = ""
                    Else
                        ObjUpdate.txtPesoc.Text = DGVAnimals.CurrentRow.Cells("Peso").Value
                    End If


                    Dim id_ciclo As Long = DGVAnimals.CurrentRow.Cells("ciclo").Value
                    Dim id_Genetica As Long
                    If (IsDBNull(DGVAnimals.CurrentRow.Cells("Genetica").Value)) Then
                        id_Genetica = 1
                    Else
                        id_Genetica = DGVAnimals.CurrentRow.Cells("Genetica").Value
                    End If

                    Dim id_TipoOrigen As Long

                    If (IsDBNull(DGVAnimals.CurrentRow.Cells("Tipo de Origen").Value)) Then
                        id_TipoOrigen = 1
                    Else
                        id_TipoOrigen = DGVAnimals.CurrentRow.Cells("Tipo de Origen").Value
                    End If
                    Dim id_Origen As Long
                    If (IsDBNull(DGVAnimals.CurrentRow.Cells("Origen").Value)) Then
                        id_Origen = 1
                    Else
                        id_Origen = DGVAnimals.CurrentRow.Cells("Origen").Value
                    End If
                    Dim id_Group As Long
                    If (IsDBNull(DGVAnimals.CurrentRow.Cells("Grupo").Value)) Then
                        id_Group = 1
                    Else
                        id_Group = DGVAnimals.CurrentRow.Cells("Grupo").Value
                    End If
                    Dim id As Long = DGVAnimals.CurrentRow.Cells("ID").Value
                    ObjUpdate._id_Ciclo = id_ciclo
                    ObjUpdate.cmbCicloc.SelectedValue = id_ciclo
                    ObjUpdate.cmbGeneticac.SelectedValue = id_Genetica
                    ObjUpdate.cmbTipoOrigenc.SelectedValue = id_TipoOrigen
                    ObjUpdate.cmbOrigenc.SelectedValue = id_Origen
                    ObjUpdate.cmbTipoGrupo.SelectedValue = id_Group
                    ObjUpdate.id = id
                    ObjUpdate.btnCrear.Visible = False
                    ObjUpdate.btnModificar.Visible = True
                    ObjUpdate.Text = "Produccion - Modificar Animal"
                    resul = ObjUpdate.ShowDialog()
                Catch ex As ArgumentException
                    Using objLog As New ProcessGeneral
                        objLog.AlmacenarLog(5, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                    End Using
                Catch ex As Exception
                    Using objLog As New ProcessGeneral
                        objLog.AlmacenarLog(5, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                    End Using
                End Try
            End Using
            If resul = System.Windows.Forms.DialogResult.OK Then
                GetAnimals()
            End If
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim DialogResult As DialogResult = MessageBox.Show("¿Realmente desea eliminar el registro del animal?", "Eliminar Animal", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        Dim resp As String
        Dim _id As Integer

        _id = DGVAnimals.CurrentRow.Cells("ID").Value

        If (DialogResult = DialogResult.OK) Then
            Using ObjSql As New Generic_SQLServer
                resp = ObjSql.DeleteAnimals(_id)
                If (resp = "ok") Then
                    MessageBox.Show("Animal eliminado correctamente", "ERP Produccion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    DialogResult = DialogResult.OK
                    GetAnimals()
                End If
            End Using
        End If
    End Sub

    Private Sub cmdReportGeneral_Click(sender As Object, e As EventArgs) Handles cmdReportGeneral.Click
        Try
            id_lote = DGW_ProductsProcess.CurrentRow.Cells("Correlativo").Value
            id_proceso = DGW_ProductsProcess.CurrentRow.Cells(9).Value

            Using objHours As New Production_SelectedHours
                objHours.IdProcess = id_proceso
                objHours.ShowDialog()
                If (objHours.IdHours <> 0) Then
                    Using obj As New Production_Resumen
                        obj.ID_Process = id_proceso
                        obj.ID_Lot = id_lote
                        obj.ID_Hours = objHours.IdHours
                        obj.ShowDialog()
                    End Using
                End If
            End Using
        Catch ex As Exception
            If (DGW_ProductsProcess.Rows.Count >= 0) Then
                MessageBox.Show("Debe seleccionar un Lote", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End Try
    End Sub

    Private Sub cmdCatalogoClienteFinancieroSeleccion_Click(sender As Object, e As EventArgs) Handles cmdCatalogoClienteFinancieroSeleccion.Click
        Try
            id_lote = DGW_ProductsProcess.CurrentRow.Cells("Correlativo").Value
            id_proceso = DGW_ProductsProcess.CurrentRow.Cells(9).Value

            Using objHours As New Production_SelectedHours
                objHours.IdProcess = 3 ' Se tiene que poner como parametro general
                objHours.ShowDialog()
                If (objHours.IdHours <> 0) Then

                    Using obj As New Production_Resumen
                        obj.ID_Process = id_proceso
                        obj.ID_Lot = id_lote
                        obj.ID_Hours = objHours.IdHours
                        obj.TipoReport = "indiv"
                        obj.ShowDialog()
                    End Using
                End If
            End Using
        Catch ex As Exception
            If (DGW_ProductsProcess.Rows.Count >= 0) Then
                MessageBox.Show("Debe seleccionar un Lote", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End Try
    End Sub

    Private Sub cmdPendienteDescarga_PasarInventario_Click(sender As Object, e As EventArgs) Handles cmdPendienteDescarga_PasarInventario.Click
        Dim ID_HeaderOutput As Long = 0
        Using objSQl As New Operaciones_SQLServer
            ID_HeaderOutput = objSQl.SP_ERP_Inventory_Output_InventoryHeader(1, 2, "Salida de por produccion", 0)
            If ID_HeaderOutput > 0 Then
                For Each row As DataRow In _tableDescargaPro.Rows
                    objSQl.SP_ERP_Inventory_Output_InventoryDetails(_ID_Company, ID_HeaderOutput, 1, row("id_product_FK"), row("TotalProduct"))
                    objOperacion.ERP_Prod_ConsumptionFlowproducts_update(row("Id_Transaction"))
                Next row
            End If
        End Using
        GetDescargaProductos()
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs)
        Using obj As New Production_AnimalsToSacrifice
            id_lote = DGW_ProductsProcess.CurrentRow.Cells("Correlativo").Value
            obj.ID_Etapa = DGW_ProductsProcess.CurrentRow.Cells(9).Value
            obj.ID_Etapa = 12 ' borrar
            obj.ID_Lot = id_lote
            obj.ShowDialog()
        End Using
    End Sub



#Region "Genetica"
    Private Sub GetGeneticaAnimales()
        _tableDescargaPro = objGeneric.GetGenetic(Data_Id_Company)
        DGW_Genetic.AutoGenerateColumns = False
        DGW_Genetic.Font = New Font("Segoe UI", 11)
        REM DGW_DescargaProductos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
        DGW_Genetic.ReadOnly = True
        DGW_Genetic.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DGW_Genetic.MultiSelect = False

        DGW_Genetic.AllowUserToAddRows = False
        DGW_Genetic.AllowUserToDeleteRows = False
        DGW_Genetic.Columns(0).Width = 100
        DGW_Genetic.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
        DGW_Genetic.Columns(1).Width = 200
        DGW_Genetic.Columns(2).Width = 200
        DGW_Genetic.Columns(3).Width = 200
        DGW_Genetic.Columns(4).Width = 200
        DGW_Genetic.Columns(5).Width = 100
        DGW_Genetic.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight

        DGW_Genetic.DataSource = _tableDescargaPro
    End Sub

    Private Sub cmdCreate_GeneticaAnimals_Click(sender As Object, e As EventArgs) Handles cmdCreate_GeneticaAnimals.Click
        Using obj As New Production_AddGenetic
            If obj.ShowDialog() = DialogResult.OK Then
                GetGeneticaAnimales()
            End If
        End Using
    End Sub

    Private Sub cmdUpdate_GeneticaAnimals_Click(sender As Object, e As EventArgs) Handles cmdUpdate_GeneticaAnimals.Click
        Dim resul As DialogResult = Nothing
        If DGW_Genetic.CurrentRow IsNot Nothing Then
            Using ObjUpdate As New Production_AddGenetic
                Try
                    ObjUpdate.Text = "Produccion - Modificar Genetica"
                    ObjUpdate.Id_Genetic = DGW_Genetic.CurrentRow.Cells("Id_Genetica").Value
                    ObjUpdate.Name_Genetic = DGW_Genetic.CurrentRow.Cells("Genetic_Name").Value
                    resul = ObjUpdate.ShowDialog()
                Catch ex As ArgumentException
                    Using objLog As New ProcessGeneral
                        objLog.AlmacenarLog(5, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                    End Using
                Catch ex As Exception
                    Using objLog As New ProcessGeneral
                        objLog.AlmacenarLog(5, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                    End Using
                End Try
            End Using
            If resul = System.Windows.Forms.DialogResult.OK Then
                GetGeneticaAnimales()
            End If
        End If
    End Sub

    Private Sub cmdDel_GeneticaAnimals_Click(sender As Object, e As EventArgs) Handles cmdDel_GeneticaAnimals.Click
        Dim DialogResult As DialogResult = MessageBox.Show("¿Realmente desea eliminar la Genética?", "Eliminar Genetica", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        Dim resp As String
        Dim _id As Integer

        _id = DGW_Genetic.CurrentRow.Cells("Id_Genetica").Value

        If (DialogResult = DialogResult.OK) Then
            Using ObjSql As New Generic_SQLServer
                resp = ObjSql.DelGenetic(_id, Data_Id_Company)
                If (resp = "OK") Then
                    MessageBox.Show("Genética eliminada correctamente", "ERP Produccion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    DialogResult = DialogResult.OK
                    GetGeneticaAnimales()
                End If
            End Using
        End If
    End Sub
#End Region

#Region "Tipo de Origen"
    Private Sub GetTipoOrigen()
        _tableDescargaPro = objGeneric.GetOriginType(Data_Id_Company)
        DGW_OriginType.AutoGenerateColumns = False
        DGW_OriginType.Font = New Font("Segoe UI", 11)
        DGW_OriginType.ReadOnly = True
        DGW_OriginType.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DGW_OriginType.MultiSelect = False

        DGW_OriginType.AllowUserToAddRows = False
        DGW_OriginType.AllowUserToDeleteRows = False
        DGW_OriginType.Columns(0).Width = 100
        DGW_OriginType.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
        DGW_OriginType.Columns(1).Width = 200
        DGW_OriginType.Columns(2).Width = 200
        DGW_OriginType.Columns(3).Width = 200
        DGW_OriginType.Columns(4).Width = 200
        DGW_OriginType.Columns(5).Width = 100
        DGW_OriginType.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight

        DGW_OriginType.DataSource = _tableDescargaPro
    End Sub

    Private Sub cmdCreate_TypeOrigin_Click(sender As Object, e As EventArgs) Handles cmdCreate_TypeOrigin.Click
        Using obj As New Production_AddOriginType
            If obj.ShowDialog() = DialogResult.OK Then
                GetTipoOrigen()
            End If
        End Using
    End Sub

    Private Sub cmdUpdate_TypeOrigin_Click(sender As Object, e As EventArgs) Handles cmdUpdate_TypeOrigin.Click
        Dim resul As DialogResult = Nothing
        If DGW_OriginType.CurrentRow IsNot Nothing Then
            Using ObjUpdate As New Production_AddOriginType
                Try
                    ObjUpdate.Text = "Produccion - Modificar Tipo de Origen"
                    ObjUpdate.Id_Genetic = DGW_OriginType.CurrentRow.Cells("Id_TypeOrigin").Value
                    ObjUpdate.Name_Genetic = DGW_OriginType.CurrentRow.Cells("TypeOrigin_Name").Value
                    resul = ObjUpdate.ShowDialog()
                Catch ex As ArgumentException
                    Using objLog As New ProcessGeneral
                        objLog.AlmacenarLog(5, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                    End Using
                Catch ex As Exception
                    Using objLog As New ProcessGeneral
                        objLog.AlmacenarLog(5, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                    End Using
                End Try
            End Using
            If resul = System.Windows.Forms.DialogResult.OK Then
                GetTipoOrigen()
            End If
        End If
    End Sub

    Private Sub cmdDel_TypeOrigin_Click(sender As Object, e As EventArgs) Handles cmdDel_TypeOrigin.Click
        Dim DialogResult As DialogResult = MessageBox.Show("¿Realmente desea eliminar el tipo de origen?", "Eliminar Genetica", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        Dim resp As String
        Dim _id As Integer

        _id = DGW_OriginType.CurrentRow.Cells("Id_TypeOrigin").Value

        If (DialogResult = DialogResult.OK) Then
            Using ObjSql As New Generic_SQLServer
                resp = ObjSql.DelOriginType(_id, Data_Id_Company)
                If (resp = "OK") Then
                    MessageBox.Show("Tipo de Origen eliminado correctamente", "ERP Produccion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    DialogResult = DialogResult.OK
                    GetTipoOrigen()
                End If
            End Using
        End If
    End Sub
#End Region

#Region "Origen"
    Private Sub GetOrigen()
        _tableDescargaPro = objGeneric.GetOrigin(Data_Id_Company)
        DGW_Origin.AutoGenerateColumns = False
        DGW_Origin.Font = New Font("Segoe UI", 11)
        DGW_Origin.ReadOnly = True
        DGW_Origin.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DGW_Origin.MultiSelect = False

        DGW_Origin.AllowUserToAddRows = False
        DGW_Origin.AllowUserToDeleteRows = False
        DGW_Origin.Columns(0).Width = 100
        DGW_Origin.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
        DGW_Origin.Columns(1).Width = 200
        DGW_Origin.Columns(2).Width = 200
        DGW_Origin.Columns(3).Width = 200
        DGW_Origin.Columns(4).Width = 200
        DGW_Origin.Columns(5).Width = 100
        DGW_Origin.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight

        DGW_Origin.DataSource = _tableDescargaPro
    End Sub

    Private Sub cmdCreate_Origin_Click(sender As Object, e As EventArgs) Handles cmdCreate_Origin.Click
        Using obj As New Production_AddOrigin
            If obj.ShowDialog() = DialogResult.OK Then
                GetOrigen()
            End If
        End Using
    End Sub

    Private Sub cmdUpdate_Origin_Click(sender As Object, e As EventArgs) Handles cmdUpdate_Origin.Click
        Dim resul As DialogResult = Nothing
        If DGW_Origin.CurrentRow IsNot Nothing Then
            Using ObjUpdate As New Production_AddOrigin
                Try
                    ObjUpdate.Text = "Produccion - Modificar Origen"
                    ObjUpdate.Id_Genetic = DGW_Origin.CurrentRow.Cells("Id_Origin").Value
                    ObjUpdate.Name_Genetic = DGW_Origin.CurrentRow.Cells("Origin_Name").Value
                    resul = ObjUpdate.ShowDialog()
                Catch ex As ArgumentException
                    Using objLog As New ProcessGeneral
                        objLog.AlmacenarLog(5, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                    End Using
                Catch ex As Exception
                    Using objLog As New ProcessGeneral
                        objLog.AlmacenarLog(5, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                    End Using
                End Try
            End Using
            If resul = System.Windows.Forms.DialogResult.OK Then
                GetOrigen()
            End If
        End If
    End Sub

    Private Sub cmdDel_Origin_Click(sender As Object, e As EventArgs) Handles cmdDel_Origin.Click
        Dim DialogResult As DialogResult = MessageBox.Show("¿Realmente desea eliminar el Origen?", "Eliminar Origen", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        Dim resp As String
        Dim _id As Integer

        _id = DGW_Origin.CurrentRow.Cells("Id_Origin").Value

        If (DialogResult = DialogResult.OK) Then
            Using ObjSql As New Generic_SQLServer
                resp = ObjSql.DelOrigin(_id, Data_Id_Company)
                If (resp = "OK") Then
                    MessageBox.Show("Origen eliminado correctamente", "ERP Produccion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    DialogResult = DialogResult.OK
                    GetOrigen()
                End If
            End Using
        End If
    End Sub
#End Region

#Region "GrupoAnimal"
    Private Sub GetAnimalGroup()
        _tableDescargaPro = objGeneric.GetAnimalGroup(Data_Id_Company)
        DGVAnimalGroup.AutoGenerateColumns = False
        DGVAnimalGroup.Font = New Font("Segoe UI", 11)
        DGVAnimalGroup.ReadOnly = True
        DGVAnimalGroup.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DGVAnimalGroup.MultiSelect = False

        DGVAnimalGroup.AllowUserToAddRows = False
        DGVAnimalGroup.AllowUserToDeleteRows = False
        DGVAnimalGroup.Columns(0).Width = 50
        DGVAnimalGroup.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
        DGVAnimalGroup.Columns(1).Width = 200
        DGVAnimalGroup.Columns(2).Width = 200
        DGVAnimalGroup.Columns(3).Width = 200
        DGVAnimalGroup.Columns(4).Width = 200
        DGVAnimalGroup.Columns(5).Width = 100
        DGVAnimalGroup.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight

        DGVAnimalGroup.DataSource = _tableDescargaPro
    End Sub

    Private Sub cmdCreate_AnimalGroup_Click(sender As Object, e As EventArgs) Handles cmdCreate_AnimalGroup.Click
        Using obj As New Production_AddAnimalGroup
            If obj.ShowDialog() = DialogResult.OK Then
                GetAnimalGroup()
            End If
        End Using
    End Sub

    Private Sub cmdUpdate_AnimalGroup_Click(sender As Object, e As EventArgs) Handles cmdUpdate_AnimalGroup.Click
        Dim resul As DialogResult = Nothing
        If DGVAnimalGroup.CurrentRow IsNot Nothing Then
            Using ObjUpdate As New Production_AddAnimalGroup
                Try
                    ObjUpdate.Text = "Produccion - Modificar Grupo Animal"
                    ObjUpdate.Id_AnimalGroup = DGVAnimalGroup.CurrentRow.Cells("Id_Group").Value
                    ObjUpdate.Name_Genetic = DGVAnimalGroup.CurrentRow.Cells("Description").Value
                    resul = ObjUpdate.ShowDialog()
                Catch ex As ArgumentException
                    Using objLog As New ProcessGeneral
                        objLog.AlmacenarLog(5, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                    End Using
                Catch ex As Exception
                    Using objLog As New ProcessGeneral
                        objLog.AlmacenarLog(5, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                    End Using
                End Try
            End Using
            If resul = System.Windows.Forms.DialogResult.OK Then
                GetAnimalGroup()
            End If
        End If
    End Sub

    Private Sub cmdDel_AnimalGroup_Click(sender As Object, e As EventArgs) Handles cmdDel_AnimalGroup.Click
        Dim DialogResult As DialogResult = MessageBox.Show("¿Realmente desea eliminar el Grupo Animal?", "Eliminar Grupo Animal", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        Dim resp As String
        Dim _id As Integer

        _id = DGVAnimalGroup.CurrentRow.Cells("Id_Group").Value

        If (DialogResult = DialogResult.OK) Then
            Using ObjSql As New Generic_SQLServer
                resp = ObjSql.DelAnimalGroup(_id, Data_Id_Company)
                If (resp = "OK") Then
                    MessageBox.Show("Grupo animal eliminado correctamente", "ERP Produccion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    DialogResult = DialogResult.OK
                    GetAnimalGroup()
                End If
            End Using
        End If
    End Sub




#End Region

    Private Sub cmdOutPut_Click(sender As Object, e As EventArgs) Handles cmdOutPut.Click
        If Not DGW_ProductsProcess.CurrentRow Is Nothing Then
            Using objOutPut As New Production_OutputAnimals
                objOutPut.ID_Lot = DGW_ProductsProcess.CurrentRow.Cells("Correlativo").Value
                objOutPut.ID_ProductoSalida = DGW_ProductsProcess.CurrentRow.Cells("ID_Product_FK").Value
                objOutPut.ShowDialog()
            End Using
        End If
    End Sub

    Private Sub Button16_Click_1(sender As Object, e As EventArgs) Handles Button16.Click
        If Not DGW_ProductsProcess.CurrentRow Is Nothing Then
            Dim ID_Bodega As Long = 0
            Dim Comentario As String = ""
            Dim resp As Integer = 0
            Dim dt As New DataTable
            Dim ID_Header As Long = 0
            Dim IS_Mother As Integer = 0
            Dim ID_Lote As Long = DGW_ProductsProcess.CurrentRow.Cells("Correlativo").Value
            Using obj As New Production_StowageAvailableTransfer
                obj.ID_Lot = ID_Lote
                If obj.ShowDialog = DialogResult.OK Then
                    ID_Bodega = obj.ID_Bodega
                    Comentario = obj.Comentario
                    Using objSQL As New Operaciones_SQLServer
                        dt = objSQL.ERP_Prod_SP_AnimalTransfersHeader(_ID_Company, 4, Comentario) ' 4 es el tipo de salida para Lote Completo
                        If Not dt Is Nothing Then
                            If dt.Rows.Count > 0 Then
                                ID_Header = dt.Rows(0).Item(0)
                            End If

                            If ID_Header > 0 Then
                                resp = objSQL.ERP_Prod_SP_AnimalTransfers(_ID_Company, 0, 0, 0, 4, IS_Mother, ID_Header, 0, 0, 0, ID_Bodega, ID_Lote)
                            End If
                            If resp = 1 Then
                                MessageBox.Show("Proceso finalizado exitosamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Else
                                MessageBox.Show("Ocurrió un error al realizar la transferencia", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End If
                        End If
                    End Using

                End If
            End Using

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) 

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) 

    End Sub

    Private Sub DGW_ProductsProcess_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGW_ProductsProcess.CellContentClick

    End Sub

    Private Sub DGVClientes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) 

    End Sub

    Private Sub DGW_Product_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) 

    End Sub
End Class
