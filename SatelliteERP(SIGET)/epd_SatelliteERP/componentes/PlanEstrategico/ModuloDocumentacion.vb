Public Class ModuloDocumentacion
    Private objDB As New POA_SQLServer
    Private _UsuarioEstandar As Boolean = False
    Private _UsuarioGerente As Boolean = False
    Private _UsuarioPlanificacion As Boolean = False
    Private OpcionesMenu As DataTable
    Private objSql2 As New Generic_SQLServer
    Private Sub ModuloUsers_Load(sender As Object, e As EventArgs) Handles Me.Load
        cbGerenciaResponsableMap.Visible = False
        ComboDpto1.Visible = True
        ComboDpto2.Visible = True
        ComboDpto3.Visible = True


        OpcionesMenu = objSql2.GetAccessMenu(_UserSQL)
        _VerTodos = False
        _Id_DptoPlani = _Id_DepartmentGlobal


        If (OpcionesMenu.Rows.Count > 0) Then
            For Each DataInfoE As DataRow In OpcionesMenu.Rows
                If (DataInfoE("rolUser").ToString.ToUpper = "PLA_Planificacion_VerTodo".ToString.ToUpper) Then
                    _VerTodos = True
                ElseIf (DataInfoE("rolUser").ToString.ToUpper = "PLA_Planificacion_POA_PRO_C_EnviarAprobacion".ToString.ToUpper) Then
                    _UsuarioEstandar = True
                ElseIf (DataInfoE("rolUser").ToString.ToUpper = "PLA_Planificacion_POA_PRO_D_AprobacionGeren".ToString.ToUpper) Then
                    _UsuarioGerente = True
                ElseIf (DataInfoE("rolUser").ToString.ToUpper = "PLA_Planificacion_POA_PRO_E_AprobacionPlani".ToString.ToUpper) Then
                    _UsuarioPlanificacion = True
                End If
            Next
        End If

        If _UsuarioPlanificacion Then
            _Id_DptoPlani = 0
        End If
        Dim dataInfo As DataTable = objDB.ERP_StrategicPlan_GetManagement()

        Dim dataSelect As DataTable = dataInfo.Clone
        If _UsuarioPlanificacion Or _SuperUsuarioPlanificacion Then
            dataSelect.Rows.Add(0, "Seleccione")
        End If

        For Each Info As DataRow In dataInfo.Rows
            dataSelect.ImportRow(Info)
        Next


        ComboDpto1.DataSource = dataSelect
        ComboDpto1.DisplayMember = "Name"
        ComboDpto1.ValueMember = "Id_Deparment"

        ComboDpto2.DataSource = dataSelect
        ComboDpto2.DisplayMember = "Name"
        ComboDpto2.ValueMember = "Id_Deparment"

        ComboDpto3.DataSource = dataSelect
        ComboDpto3.DisplayMember = "Name"
        ComboDpto3.ValueMember = "Id_Deparment"

        ComboDpto4.DataSource = dataSelect
        ComboDpto4.DisplayMember = "Name"
        ComboDpto4.ValueMember = "Id_Deparment"

        Try
            dataInfo = objDB.ERP_StrategicPlan_getMeses

            dataSelect = dataInfo.Clone

            For Each Info As DataRow In dataInfo.Rows
                dataSelect.ImportRow(Info)
            Next

            ComboMesSeguimiento.DataSource = dataSelect
            ComboMesSeguimiento.DisplayMember = "Mes"
            ComboMesSeguimiento.ValueMember = "IdMes"
        Catch ex As Exception

        End Try


        Try
            dataInfo = objDB.ERP_StrategicPlan_getYear(ComboDpto3.SelectedValue)

            ComboAnio.DataSource = dataInfo
            ComboAnio.DisplayMember = "Anio"
            ComboAnio.ValueMember = "Anio"
        Catch ex As Exception

        End Try

        Try
            dataInfo = objDB.ERP_StrategicPlan_getYear(ComboDpto1.SelectedValue)

            ComboAnioPEI.DataSource = dataInfo
            ComboAnioPEI.DisplayMember = "Anio"
            ComboAnioPEI.ValueMember = "Anio"
        Catch ex As Exception

        End Try

        Try
            dataInfo = objDB.ERP_StrategicPlan_getYearPOA(ComboDpto2.SelectedValue)

            ComboAnioPOA.DataSource = dataInfo
            ComboAnioPOA.DisplayMember = "Anio"
            ComboAnioPOA.ValueMember = "Anio"
        Catch ex As Exception

        End Try


        Try
            dataInfo = objDB.ERP_StrategicPlan_getAniosMapa(ComboAnioMapa.SelectedValue)

            ComboAnioMapa.DataSource = dataInfo
            ComboAnioMapa.DisplayMember = "Anio"
            ComboAnioMapa.ValueMember = "Anio"
        Catch ex As Exception

        End Try

        CargarDocumentosRespaldo(dgvDocPEI, "PEI")

    End Sub

    Private Sub tabUsuarios_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tabMapaRiesgo.SelectedIndexChanged
        If sender.SelectedTab.Name = "TabPagePOAEjecucion" Then
            CargarDocumentosEjecucion()
        ElseIf sender.SelectedTab.Name = "TabPagePOAProgramación" Then
            CargarDocumentosRespaldo(dgvDocPOA, "POA")
        ElseIf sender.SelectedTab.Name = "TabPageDocumentosPEI" Then
            CargarDocumentosRespaldo(dgvDocPEI, "PEI")
        ElseIf sender.SelectedTab.Name = "TabPageMapaRiesgo" Then
            CargarDocumentosRespaldo(dgMapaRiesgoDoc, "MAPA")
        End If
    End Sub

    Private Sub ComboDpto3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboDpto3.SelectedIndexChanged
        CargarDocumentosEjecucion()
    End Sub
    Private Sub CargarDocumentosEjecucion()
        Try
            If ComboDpto3.SelectedItem(0) <= 0 And ComboMesSeguimiento.SelectedItem(0) <= 0 And ComboAnio.SelectedItem(0) <= 0 Then
                Exit Sub
            End If
        Catch ex As Exception
            Exit Sub
        End Try

        Using obj As New POA_SQLServer
            Try
                Dim dt As New DataTable
                dt = obj.ERP_StrategicPlan_getDocumentosEjecucion(ComboDpto3.SelectedItem(0), ComboMesSeguimiento.SelectedItem(0), ComboAnio.SelectedItem(0))

                If dt IsNot Nothing Then
                    dgvDocumentosEjecucion.AutoGenerateColumns = False

                    dgvDocumentosEjecucion.Font = New Font("Segoe UI", 11)
                    dgvDocumentosEjecucion.RowHeadersVisible = False

                    dgvDocumentosEjecucion.ReadOnly = True
                    'dgvDocumentosEjecucion.SelectionMode = DataGridViewSelectionMode.FullRowSelect
                    dgvDocumentosEjecucion.MultiSelect = False

                    dgvDocumentosEjecucion.AllowUserToResizeColumns = False
                    dgvDocumentosEjecucion.AllowUserToAddRows = False
                    dgvDocumentosEjecucion.AllowUserToDeleteRows = False
                    dgvDocumentosEjecucion.DataSource = dt

                    dgvDocumentosEjecucion.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
                    dgvDocumentosEjecucion.ScrollBars = ScrollBars.Both
                    dgvDocumentosEjecucion.ForeColor = Color.Black

                    dgvDocumentosEjecucion.DefaultCellStyle.WrapMode = DataGridViewTriState.True
                    dgvDocumentosEjecucion.Columns(2).Visible = False
                    If dt.Rows.Count > 0 Then
                        AgregarBoton(dgvDocumentosEjecucion)
                    End If
                End If
            Catch ex As Exception

            End Try
        End Using
    End Sub

    Private Sub CargarDocumentosRespaldo(ByVal GridProcess As DataGridView, ByVal Tipo As String)
        Try
            'If ComboDpto3.SelectedItem(0) <= 0 And ComboMesSeguimiento.SelectedItem(0) <= 0 And ComboAnio.SelectedItem(0) <= 0 Then
            '    Exit Sub
            'End If
        Catch ex As Exception

        End Try

        Using obj As New POA_SQLServer
            Try
                Dim dt As New DataTable
                If Tipo = "PEI" Then
                    dt = obj.ERP_StrategicPlan_GetDocumentRespaldoPEIPOA(ComboDpto1.SelectedItem(0), "TodosPEI", 0)
                ElseIf Tipo = "POA" Then
                    dt = obj.ERP_StrategicPlan_GetDocumentRespaldoPEIPOA(ComboDpto2.SelectedItem(0), "TodosPOA", ComboAnioPOA.SelectedItem(0))
                Else
                    dt = obj.ERP_StrategicPlan_GetDocumentRespaldoPEIPOA(ComboDpto2.SelectedItem(0), "TodosMAPA", ComboAnioMapa.SelectedItem(0))
                End If

                If dt IsNot Nothing Then
                    GridProcess.AutoGenerateColumns = False

                    GridProcess.Font = New Font("Segoe UI", 11)
                    GridProcess.RowHeadersVisible = False

                    GridProcess.ReadOnly = True
                    'GridProcess.SelectionMode = DataGridViewSelectionMode.FullRowSelect
                    GridProcess.MultiSelect = False

                    GridProcess.AllowUserToResizeColumns = False
                    GridProcess.AllowUserToAddRows = False
                    GridProcess.AllowUserToDeleteRows = False
                    GridProcess.DataSource = dt

                    GridProcess.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
                    GridProcess.ScrollBars = ScrollBars.Both
                    GridProcess.ForeColor = Color.Black

                    GridProcess.DefaultCellStyle.WrapMode = DataGridViewTriState.True
                    GridProcess.Columns(0).Visible = False
                    GridProcess.Columns(1).Visible = False


                    If Tipo = "PEI" Then
                        GridProcess.Columns("Anio").HeaderText = "Quinquenio PEI"
                    ElseIf Tipo = "MAPA" Then
                        GridProcess.Columns(2).Visible = False
                    Else
                        GridProcess.Columns("DataGridViewTextBoxColumn4").HeaderText = "Año POA"
                    End If

                    If dt.Rows.Count > 0 Then
                        AgregarBoton(GridProcess)
                    End If
                End If
            Catch ex As Exception

            End Try
        End Using
    End Sub



    Private Sub ComboMesSeguimiento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboMesSeguimiento.SelectedIndexChanged
        CargarDocumentosEjecucion()
    End Sub

    Private Sub ComboAnio_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboAnio.SelectedIndexChanged
        CargarDocumentosEjecucion()
    End Sub
    Sub AgregarBoton(ByVal Grid As Object)
        Dim bandera As Boolean = True
        For i As Integer = 0 To Grid.Columns.Count - 1
            If Grid.Columns(i).HeaderText = "Opciones" Then
                bandera = False
                Exit For
            End If
        Next
        If bandera Then
            Dim columna As New DataGridViewButtonColumn
            columna.Text = "Descargar"
            columna.HeaderText = "Opciones"
            columna.UseColumnTextForButtonValue = True
            columna.FlatStyle = FlatStyle.Popup
            columna.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            columna.DefaultCellStyle.ForeColor = Color.White
            columna.DefaultCellStyle.BackColor = Color.DarkBlue
            Grid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
            columna.Width = 150
            Grid.Columns.Add(columna)
        End If
    End Sub

    Private Sub ComboDpto1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboDpto1.SelectedIndexChanged
        CargarDocumentosRespaldo(dgvDocPEI, "PEI")
    End Sub

    Private Sub ComboAnioPEI_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboAnioPEI.SelectedIndexChanged
        CargarDocumentosRespaldo(dgvDocPEI, "PEI")
    End Sub

    Private Sub ComboDpto2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboDpto2.SelectedIndexChanged
        CargarDocumentosRespaldo(dgvDocPOA, "POA")
    End Sub

    Private Sub ComboAnioPOA_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboAnioPOA.SelectedIndexChanged
        CargarDocumentosRespaldo(dgvDocPOA, "POA")
    End Sub

    Private Sub dgvDocumentosEjecucion_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDocumentosEjecucion.CellClick
        Try
            If dgvDocumentosEjecucion.Columns(e.ColumnIndex).HeaderText = "Opciones" Then
                DescargarDocumentos(dgvDocumentosEjecucion.Rows(e.RowIndex).Cells(4).Value.ToString.Trim, dgvDocumentosEjecucion.Rows(e.RowIndex).Cells(2).Value.ToString)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgvDocPEI_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDocPEI.CellClick
        Try
            If dgvDocPEI.Columns(e.ColumnIndex).HeaderText = "Opciones" Then
                DescargarDocumentos(dgvDocPEI.Rows(e.RowIndex).Cells(3).Value.ToString.Trim, dgvDocPEI.Rows(e.RowIndex).Cells(1).Value.ToString)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgvDocPOA_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDocPOA.CellClick
        Try
            If dgvDocPOA.Columns(e.ColumnIndex).HeaderText = "Opciones" Then
                DescargarDocumentos(dgvDocPOA.Rows(e.RowIndex).Cells(4).Value.ToString.Trim, dgvDocPOA.Rows(e.RowIndex).Cells(1).Value.ToString)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgMapaRiesgoDoc_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgMapaRiesgoDoc.CellClick
        Try
            If dgMapaRiesgoDoc.Columns(e.ColumnIndex).HeaderText = "Opciones" Then
                DescargarDocumentos(dgMapaRiesgoDoc.Rows(e.RowIndex).Cells(4).Value.ToString.Trim, dgMapaRiesgoDoc.Rows(e.RowIndex).Cells(1).Value.ToString)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DescargarDocumentos(ByVal NombreDocumento As String, ByVal RutaDocumento As String)
        If NombreDocumento = "" Then
            MessageBox.Show("NO hay documentos de ejecución", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Try
            Dim Escritorio As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)

            Dim dlGuardar As New SaveFileDialog
            dlGuardar.InitialDirectory = Escritorio
            dlGuardar.Filter = "Todos (*.*)|*.*"
            dlGuardar.FilterIndex = 1
            Try
                dlGuardar.DefaultExt = NombreDocumento.ToString.Split(".")(1).ToString
            Catch ex As Exception

            End Try
            dlGuardar.FileName = Date.Now.Date.ToString("ddMMyyyy").ToString & "_" & NombreDocumento.ToString
            dlGuardar.OverwritePrompt = True
            dlGuardar.Title = "Guardar Documento Respaldo Ejecución"
            If dlGuardar.ShowDialog = DialogResult.OK Then

                My.Computer.Network.DownloadFile(RutaDocumento, dlGuardar.FileName)
                MessageBox.Show("Archivo descargado Exitosamente", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            If (ex.ToString.Contains("ya existe un archivo")) Then
                MessageBox.Show("Ya existe un archivo con el mismo nombre", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("No se puede decargar el archivo", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            Using process As New ProcessGeneral
                process.AlmacenarLog(5, ex.Message, System.Reflection.MethodBase.GetCurrentMethod().Name)
            End Using
        End Try
    End Sub

End Class
