Imports System.IO

Public Class Financiero_Procesos_Depreciacion
    Private DsData As New DataSet
    Dim BanderaDepre As Boolean = True
    Private objSql2 As New Generic_SQLServer

    Private objSql As New Financiero_SQLServer
    Property FechaSeleccionada As Date
    Property Descripcion As String
    Dim Id_Department As Integer = 0
    Property _tableFixedAssetsMaster As DataTable
    Property Id_HeaderDepreciationAproved As Integer
    Private OpcionesMenu As DataTable
    Property BanderaProceso As Boolean = False

    Property ShowDepreciation As Boolean = False

    Private BanderaEncabezado As Boolean = True
    Private FechaProcesoPreview As Date
    Private RechazarDepre As Boolean = True
    Private IDString As String = ""
    Private FechasString As String = ""
    Private MostrarPanel = False

    Private _DataActivo As DataGridView

    Private Sub BtnProcInformacion_Click(sender As Object, e As EventArgs) Handles BtnProcInformacion.Click
        Try
            BanderaEncabezado = True
            If txtDescripcion.Text = "" Then
                MessageBox.Show("Debe ingresar una descripción", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtDescripcion.Focus()
                Exit Sub
            Else
                Control.CheckForIllegalCrossThreadCalls = False
                PnProcesando.Visible = True
                If Not BanderaProceso Then
                    FechaSeleccionada = DTP_DateFactura.Value.ToString("yyyy-MM-dd")
                    Descripcion = txtDescripcion.Text.ToString
                End If

                Try
                    _DataActivo = DGActivosFij

                Catch ex As Exception

                End Try
                If Id_HeaderDepreciationAproved > 0 Then
                    If MessageBox.Show("Esta seguro de Aprobar la Depreciación?", Application.CompanyName, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
                        BackgroundWorker1.RunWorkerAsync()
                    Else
                        PnProcesando.Visible = False
                    End If
                Else
                    If MessageBox.Show("Esta seguro de enviar a Aprobación la Depreciación?", Application.CompanyName, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
                        BackgroundWorker1.RunWorkerAsync()
                    Else
                        PnProcesando.Visible = False
                    End If
                End If


            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Try
            Dim vidautil As Integer = 0

            Using objSQL As New Financiero_SQLServer
                If Not BanderaProceso Then

                    Id_HeaderDepreciationAproved = objSQL.ERP_Finance_Set_FixedAssetDepreciationHeader(FechaSeleccionada, Descripcion, 0, 0)
                    Dim fechapro As Date
                    Try
                        For Each Seleccion As DataGridViewRow In _DataActivo.Rows

                            fechapro = Seleccion.Cells(4).Value.ToString

                            objSQL.ERP_Finance_Set_FixedAssetDepreciationIndividual(Seleccion.Cells(0).Value, Id_HeaderDepreciationAproved, fechapro)
                        Next
                    Catch ex As Exception

                    End Try

                    BanderaEncabezado = False
                    MessageBox.Show("La solicitud fue enviada a Aprobación", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Close()
                    Exit Sub
                End If
                If Id_HeaderDepreciationAproved > 0 Then
                    DsData = objSQL.ERP_Finance_Get_FixedAssetDepreciation(Id_HeaderDepreciationAproved)
                    Dim VidaUtilDias As Integer = 0
                    If DsData.Tables.Count > 0 Then
                        If DsData.Tables(0).Rows.Count > 0 Then
                            Dim porcentaje As Double = 0
                            Dim por As Double
                            Dim conta As Integer = 1
                            Dim numero As Integer = DsData.Tables(0).Rows.Count
                            por = conta / numero
                            For Each dataI As DataRow In DsData.Tables(0).Rows
                                por = conta / numero
                                porcentaje += por
                                porcentaje = Format(porcentaje, "##0.00")
                                lblporcentaje.Text = conta.ToString & " / " & numero.ToString
                                vidautil = dataI("VidaUtil")
                                If vidautil > 0 Then
                                    VidaUtilDias = DateDiff(DateInterval.Day, CType(dataI.Item("FechaProcess"), Date), CType(dataI.Item("FechaProcess"), Date).AddYears(vidautil))
                                    objSQL.ERP_Finance_Set_FixedAssetDepreciationIndividual(dataI("Amount_Acquired"), dataI("ResidualValue"), vidautil, dataI("Anio"), dataI("FechaProcess"), dataI("tipoCalculo"), Id_HeaderDepreciationAproved, dataI("ID_FixedAssets"), FechaSeleccionada, VidaUtilDias)
                                End If
                                conta += 1
                            Next
                        End If
                    End If
                    objSQL.ERP_Finance_Set_FixedAssetDepreciationHeader(FechaSeleccionada, Descripcion, 1, Id_HeaderDepreciationAproved)
                End If
            End Using
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Financiero_ProcesosDepreciacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        DTP_DateFactura.Format = DateTimePickerFormat.Custom
        DTP_DateFactura.CustomFormat = "dd/MM/yyyy"

        BackgroundWorker1.WorkerSupportsCancellation = True
        If Not BanderaProceso Then
            BtnProcRechazar.Enabled = False
        End If
        DGActivosFij.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        If (Id_HeaderDepreciationAproved > 0) Then
            Using objSQL As New Generic_SQLServer
                Dim dataInfo As DataTable = objSQL.ERP_GetReportDepreciationFixedAssetPreviewData(_ID_Company, Id_HeaderDepreciationAproved)
                Dim contador As Integer = 0
                If (dataInfo.Rows.Count > 0) Then
                    For Each Info As DataRow In dataInfo.Rows
                        Me.DGActivosFij.Rows.Add(Info("Id"), Info("Codigo"), Info("nombreactivo"), Info("MontoAdquisicion"), Info("FechaMaxDepreciacion"), Info("Marca"), Info("Modelo"), Info("Numero_Serie"))
                        contador += 1
                    Next
                    DGActivosFij.Font = New Font("Segoe UI", 11)
                    lblTotalAct.Text = contador.ToString
                End If

            End Using
        End If
        If BanderaProceso Then
            DTP_DateFactura.Value = FechaSeleccionada
            DTP_DateFactura.Enabled = False
            txtDescripcion.Text = Descripcion
            txtDescripcion.Enabled = False
            BtnProcRechazar.Enabled = True
            btnTodos.Enabled = False
            btnLimpiar.Enabled = False
            btnEliminarListado.Enabled = False
            btnAgregarActivos.Enabled = False
            btnVistaPrevia.Focus()
            If ShowDepreciation Then
                BtnProcRechazar.Enabled = False
                BtnProcInformacion.Enabled = False
            End If
        End If
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        PnProcesando.Visible = False
        If e.Cancelled Then
            MessageBox.Show("La acción fue cancelada", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf e.Error IsNot Nothing Then
            MessageBox.Show("Se produjo un error durante la ejecución", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If BanderaEncabezado Then
                MessageBox.Show("El proceso finalizó correctamente", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Close()
            End If

        End If


    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        Close()
    End Sub


#Region " Move Form "
    Public MoveForm As Boolean
    Public MoveForm_MousePosition As Point
    Public Sub MoveForm_MouseDown(sender As Object, e As MouseEventArgs) Handles _
    MyBase.MouseDown ' Add more handles here (Example: PictureBox1.MouseDown)
        If e.Button = MouseButtons.Left Then
            MoveForm = True
            Me.Cursor = Cursors.NoMove2D
            MoveForm_MousePosition = e.Location
        End If
    End Sub
    Public Sub MoveForm_MouseMove(sender As Object, e As MouseEventArgs) Handles _
    MyBase.MouseMove ' Add more handles here (Example: PictureBox1.MouseMove)
        If MoveForm Then
            Me.Location = Me.Location + (e.Location - MoveForm_MousePosition)
        End If
    End Sub
    Public Sub MoveForm_MouseUp(sender As Object, e As MouseEventArgs) Handles _
    MyBase.MouseUp ' Add more handles here (Example: PictureBox1.MouseUp)
        If e.Button = MouseButtons.Left Then
            MoveForm = False
            Me.Cursor = Cursors.Default
        End If
    End Sub

#End Region



    Private Sub btnVistaPrevia_Click(sender As Object, e As EventArgs) Handles btnVistaPrevia.Click
        FechaProcesoPreview = DTP_DateFactura.Value
        PnProcesando.Visible = True
        BanderaDepre = False
        Dim IdFixed As Integer = 0
        FechasString = FechaProcesoPreview.ToString("yyyy-MM-dd")

        Using objSQL As New Generic_SQLServer
            objSQL.ERP_DeletePreview()
        End Using
        Try
            For Each Seleccion As DataGridViewRow In DGActivosFij.Rows
                IdFixed = Seleccion.Cells(0).Value.ToString
                Using objSQL As New Generic_SQLServer
                    objSQL.ERP_InsertDataPreview(IdFixed, FechasString)
                End Using
            Next
        Catch ex As Exception

        End Try
        BanderaDepre = True
        BackgroundWorker2.RunWorkerAsync()

    End Sub

    Private Sub BackgroundWorker2_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker2.DoWork
        _FiltradoPor = "."
        _MostrarFiltro = True
        Using objSQL As New Generic_SQLServer

            Dim _DT_DataReporte As New DataTable("Info")

            If (BanderaDepre = True) Then
                If (Id_HeaderDepreciationAproved > 0) Then
                    _DT_DataReporte = objSQL.ERP_GetReportDepreciationFixedAssetPreviewAprob(_ID_Company, FechaProcesoPreview, Id_HeaderDepreciationAproved)
                Else
                    _DT_DataReporte = objSQL.ERP_GetReportDepreciationFixedAssetPreviewTemp(_ID_Company, FechasString, IDString)
                End If
            Else
                _DT_DataReporte = objSQL.ERP_GetReportDepreciationFixedAssetPreview(_ID_Company, FechaProcesoPreview, Id_HeaderDepreciationAproved)
            End If

            Try
                If _DT_DataReporte.Rows.Count > 0 Then
                    Using ObjReport As New ERP_PreviewDepreciacion
                        ObjReport._DSPreviewData = _DT_DataReporte
                        ObjReport.StartPosition = FormStartPosition.CenterScreen
                        ObjReport.ShowDialog()
                    End Using
                Else
                    MessageBox.Show("En este momento no se puede mostrar la Vista Previa", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Catch ex As Exception
                MessageBox.Show("En este momento no se puede mostrar la Vista Previa", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
        End Using
    End Sub

    Private Sub BackgroundWorker2_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker2.RunWorkerCompleted
        PnProcesando.Visible = False
    End Sub

    Private Sub BtnProcRechazar_Click(sender As Object, e As EventArgs) Handles BtnProcRechazar.Click
        btnVistaPrevia.Enabled = False
        BtnProcRechazar.Enabled = False
        BtnProcInformacion.Enabled = False
        btnCerrarActivos.Enabled = False

        RechazarDepre = True

        Using obj As New Financiero_Procesos_DepreciacionRechazo
                If obj.ShowDialog() = DialogResult.OK Then

                Using objSQL As New Financiero_SQLServer
                    Id_HeaderDepreciationAproved = objSQL.ERP_Finance_Set_FixedAssetDepreciationHeader(Date.Now(), obj.Observacion, 2, Id_HeaderDepreciationAproved)
                End Using
                Me.Close()

            End If
            End Using


    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs)
        RechazarDepre = False
        btnVistaPrevia.Enabled = True
        BtnProcRechazar.Enabled = True
        BtnProcInformacion.Enabled = True
        btnCerrarActivos.Enabled = True
    End Sub

    Private Sub btnAgregarActivos_Click(sender As Object, e As EventArgs) Handles btnAgregarActivos.Click
        Using obj As New ERP_Financiero_BuscarActivo

            If obj.ShowDialog = DialogResult.OK Then
                GetDataActivoFijo(obj.busqueda, DGBuscarActivos)
            Else
                MostrarPanel = False
                'GetDataActivoFijo(DGBuscarActivos)
            End If
        End Using
        If (MostrarPanel) Then
            PnAgregarActivos.Visible = True
        End If

    End Sub

    Private Sub GetDataActivoFijo(GridProcess As DataGridView)
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
                End If
            Next
        End If
        Dim idemployee As Long = 0
        If PersonalActivoFijo = 1 Then
            idemployee = -1
        Else
            idemployee = _Id_EmployeeGlobal
        End If
        FechaProcesoPreview = DTP_DateFactura.Value
        _tableFixedAssetsMaster = objSql.GetFinance_FixedAssetsMaster_SelectALL(Data_Id_Company, Id_Department, FechaProcesoPreview.ToString("yyyy-MM-dd"))
        Dim tablaCalc As New DataTable("Data")


        Dim qry = From dr As DataRow In _tableFixedAssetsMaster.AsEnumerable()
                  Where dr.Field(Of Boolean)("Capitalizable") = True
                  Select dr

        Dim con As Integer = 0
        Try
            tablaCalc = _tableFixedAssetsMaster.Clone()
            tablaCalc.Rows.Clear()
            tablaCalc = qry.CopyToDataTable
            lblTotalAct.Text = tablaCalc.Rows.Count.ToString
            Me.DGActivosFij.Rows.Clear()
            For Each Info As DataRow In tablaCalc.Rows
                'Añadir los valores obtenidos de la fila seleccionada
                'al segundo datagridview
                Me.DGActivosFij.Rows.Add(Info("Id_FixedAssets"), Info("Number_Purchase"), Info("Name_FiexdAssets"), Info("Amount_Acquired"), Info("FechaMaxDepreciacion"), Info("marca"), Info("modelo"), Info("Numero_Serie"))
                'eliminar la fila del DataGridView origen
                'DataGridView1.Rows.Remove(Seleccion)
                con += 1
            Next
        Catch ex As Exception

        End Try

        GridProcess.AutoGenerateColumns = False
        GridProcess.Font = New Font("Segoe UI", 11)
        GridProcess.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        GridProcess.ReadOnly = True
        GridProcess.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        GridProcess.MultiSelect = True
        GridProcess.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
        GridProcess.AllowUserToAddRows = False
        GridProcess.AllowUserToDeleteRows = False
        MostrarPanel = True
        If (con <= 0) Then
            MessageBox.Show("No hay Activos Fijos para el Proceso de Depreciación", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            MostrarPanel = False
        End If
        'GridProcess.DataSource = tablaCalc
    End Sub

    Private Sub GetDataActivoFijo(ByVal busqueda As String, GridProcess As DataGridView)
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
                End If
            Next
        End If
        Dim idemployee As Long = 0
        If PersonalActivoFijo = 1 Then
            idemployee = -1
        Else
            idemployee = _Id_EmployeeGlobal
        End If

        _tableFixedAssetsMaster = objSql.GetFinance_FixedAssetsMaster_Select(Data_Id_Company, busqueda, Id_Department, 0, idemployee)
        Dim tablaCalc As New DataTable("Data")

        Dim qry = From dr As DataRow In _tableFixedAssetsMaster.AsEnumerable()
                  Where dr.Field(Of Boolean)("Capitalizable") = True And valor(dr.Field(Of Boolean)("isDepreciated1")) = False
                  Select dr

        Try
            tablaCalc = _tableFixedAssetsMaster.Clone()

            tablaCalc.Rows.Clear()
            tablaCalc = qry.CopyToDataTable

        Catch ex As Exception
            If (ex.ToString.Contains("El origen no contiene DataRows")) Then
                MessageBox.Show("Debe verificar que el activo buscado, no este depreciado.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
        End Try
        MostrarPanel = True
        If (tablaCalc.Rows.Count <= 0) Then
            MostrarPanel = False
            MessageBox.Show("No hay Activos Fijos con ese nombre, favor realizar una nueva búsqueda", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        GridProcess.AutoGenerateColumns = False
        GridProcess.Font = New Font("Segoe UI", 11)
        GridProcess.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        GridProcess.ReadOnly = True
        GridProcess.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        GridProcess.MultiSelect = True
        GridProcess.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
        GridProcess.AllowUserToAddRows = False
        GridProcess.AllowUserToDeleteRows = False
        GridProcess.DataSource = tablaCalc
    End Sub

    Private Function valor(ByVal Data As String) As Boolean
        Try
            Return Convert.ToBoolean(Data)
        Catch ex As Exception
            Return False
        End Try
    End Function
    Private Sub btnCerrarActivos_Click(sender As Object, e As EventArgs) Handles btnCerrarActivos.Click
        PnAgregarActivos.Visible = False
    End Sub

    Private Sub btnAgregarActivosA_Click(sender As Object, e As EventArgs) Handles btnAgregarActivosA.Click
        Try
            Dim contador As Integer = 0
            Dim BanderaP As Boolean = True
            For Each Seleccion As DataGridViewRow In DGBuscarActivos.SelectedRows
                'Añadir los valores obtenidos de la fila seleccionada
                'al segundo datagridview
                BanderaP = True
                For Each Busquedad As DataGridViewRow In DGActivosFij.Rows

                    If (Seleccion.Cells(0).Value.ToString = Busquedad.Cells(0).Value.ToString) Then
                        BanderaP = False
                        Exit For
                    End If
                Next
                If (BanderaP = True) Then
                    Me.DGActivosFij.Rows.Add(ObtenerValoresFilaGrid(Seleccion))
                End If
                'eliminar la fila del DataGridView origen
                'DataGridView1.Rows.Remove(Seleccion)
            Next

            For Each Seleccion As DataGridViewRow In DGActivosFij.Rows
                contador += 1
            Next
            DGActivosFij.Font = New Font("Segoe UI", 11)
            DGBuscarActivos.DataSource = Nothing
            PnAgregarActivos.Visible = False
            lblTotalAct.Text = contador.ToString
        Catch ex As Exception

        End Try
    End Sub

    Function ObtenerValoresFilaGrid(ByVal fila As DataGridViewRow) As String()
        'Dimensionar el array al tamaño de columnas del DGV
        Dim Contenido(Me.DGBuscarActivos.ColumnCount - 1) As String
        'Rellenar el contenido con el valor de las celdas de la fila
        For Ndx As Integer = 0 To Contenido.Length - 1
            Contenido(Ndx) = fila.Cells(Ndx).Value
        Next
        Return Contenido
    End Function

    Function ObtenerValoresFila(ByVal fila As DataRow) As String()
        'Dimensionar el array al tamaño de columnas del DGV
        Dim Contenido(Me.DGBuscarActivos.ColumnCount - 1) As String
        'Rellenar el contenido con el valor de las celdas de la fila
        For Ndx As Integer = 0 To Contenido.Length - 1
            Contenido(Ndx) = fila.Item(Ndx).Value
        Next
        Return Contenido
    End Function

    Private Sub btnEliminarListado_Click(sender As Object, e As EventArgs) Handles btnEliminarListado.Click
        Try
            DGActivosFij.Rows.Remove(DGActivosFij.CurrentRow)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnTodos_Click(sender As Object, e As EventArgs) Handles btnTodos.Click
        Try
            GetDataActivoFijo(DGActivosFij)


            DGActivosFij.Font = New Font("Segoe UI", 11)
            DGBuscarActivos.DataSource = Nothing
            PnAgregarActivos.Visible = False
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        Try
            DGActivosFij.Rows.Clear()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DGActivosFij_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGActivosFij.CellContentClick

    End Sub
End Class