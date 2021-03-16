Public Class ModuloMapaRiesgo
    Private objDB As New POA_SQLServer
    Private dtProcess As DataTable
    Private dtDeparment As DataTable
    Private dtCollectingAgency As DataTable
    Private dtMunicipality As DataTable
    Private dtCountry As DataTable
    Private dtUnitMeasure As DataTable
    Private dtOperationalActions As DataTable
    Private dtProgrammedAction As DataTable
    Private dtProbabilityOccurrence As DataTable
    Private dtImpactGrade As DataTable
    Private _UsuarioEstandar As Boolean = False
    Private _UsuarioGerente As Boolean = False
    Private _UsuarioPlanificacion As Boolean = False
    Private OpcionesMenu As DataTable
    Private objSql2 As New Generic_SQLServer
    Private Id_DptoMap As Integer = 0
    Private Sub ModuloUsers_Load(sender As Object, e As EventArgs) Handles Me.Load
        cbGerenciaResponsableMap.Visible = False
        cbMapaRiesgoDpto.Visible = False

        OpcionesMenu = objSql2.GetAccessMenu(_UserSQL)
        _VerTodos = False
        _Id_DptoPlani = _Id_DepartmentGlobal

        tabMapaRiesgo.TabPages.Remove(TabPageProbabilidadOcurencia)
        tabMapaRiesgo.TabPages.Remove(TabPageGradoImpacto)
        tabMapaRiesgo.TabPages.Remove(TabPageMApaRiesgo)
        tabMapaRiesgo.TabPages.Remove(TabPageResponsableMapa)


        If (OpcionesMenu.Rows.Count > 0) Then
            For Each DataInfo As DataRow In OpcionesMenu.Rows
                If (DataInfo("rolUser").ToString.ToUpper = "MN_Mapa_MenuVer_A_MapaRiesgo".ToString.ToUpper) Then
                    tabMapaRiesgo.TabPages.Add(TabPageMApaRiesgo)
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "MN_Mapa_MenuVer_B_ResponsableMapa".ToString.ToUpper) Then
                    tabMapaRiesgo.TabPages.Add(TabPageResponsableMapa)
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "MN_Mapa_MenuVer_C_ProbabilidadOcurrencia".ToString.ToUpper) Then
                    tabMapaRiesgo.TabPages.Add(TabPageProbabilidadOcurencia)
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "MN_Mapa_MenuVer_D_GradoRiesgo".ToString.ToUpper) Then
                    tabMapaRiesgo.TabPages.Add(TabPageGradoImpacto)
                End If

                If (DataInfo("rolUser").ToString.ToUpper = "PLA_Planificacion_MAPA_MAP_A_Ver".ToString.ToUpper) Then
                    cmdMapaRiesgo.Visible = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "PLA_Planificacion_MAPA_MAP_B_Crear".ToString.ToUpper) Then
                    cmdAgregarMapaRiesgo.Visible = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "PLA_Planificacion_MAPA_MAP_C_Modificar".ToString.ToUpper) Then
                    cmdModificarMApaRiesgo.Visible = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "PLA_Planificacion_MAPA_MAP_D_ReporteMapa".ToString.ToUpper) Then
                    cmdImprimirMapa.Visible = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "PLA_Planificacion_MAPA_MAP_E_Evaluacion".ToString.ToUpper) Then
                    cmdRevaluacionMapaRiesgo.Visible = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "PLA_Planificacion_MAPA_MAP_F_EvaluacionReporte".ToString.ToUpper) Then
                    cmbImprimirEvaluacion.Visible = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "PLA_Planificacion_MAPA_MAP_G_SubirDocumento".ToString.ToUpper) Then
                    btnSubirDocMapa.Visible = True

                ElseIf (DataInfo("rolUser").ToString.ToUpper = "PLA_Planificacion_MAPA_PRO_A_Crear".ToString.ToUpper) Then
                    cmdAgregarProbabilidad.Visible = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "PLA_Planificacion_MAPA_PRO_B_Modificar".ToString.ToUpper) Then
                    cmdModificarProbabilidad.Visible = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "PLA_Planificacion_MAPA_PRO_C_Desactivar".ToString.ToUpper) Then
                    cmdEliminarProbabilidad.Visible = True

                ElseIf (DataInfo("rolUser").ToString.ToUpper = "PLA_Planificacion_MAPA_GRA_A_Crear".ToString.ToUpper) Then
                    cmdImpacto.Visible = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "PLA_Planificacion_MAPA_GRA_B_Modificar".ToString.ToUpper) Then
                    cmdModificarImpacto.Visible = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "PLA_Planificacion_MAPA_GRA_C_Desactivar".ToString.ToUpper) Then
                    cmdEliminarImpacto.Visible = True

                ElseIf (DataInfo("rolUser").ToString.ToUpper = "PLA_Planificacion_MAPA_RES_A_Crear".ToString.ToUpper) Then
                    cmdAgregarResponsableMapa.Visible = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "PLA_Planificacion_MAPA_RES_B_Modificar".ToString.ToUpper) Then
                    cmdModificarResponsableMapa.Visible = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "PLA_Planificacion_MAPA_RES_C_Desactivar".ToString.ToUpper) Then
                    cmdEliminarResponsableMapa.Visible = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "PLA_Planificacion_VerTodo".ToString.ToUpper) Then
                    _VerTodos = True
                End If
            Next
        End If

        Id_DptoMap = _Id_DepartmentGlobal
        If Not _VerTodos Then
            _Id_DptoPlani = _Id_DepartmentGlobal
        End If
        If _UsuarioPlanificacion Then
            _Id_DptoPlani = 0
            Id_DptoMap = 0
            Dim dataInfoE As DataTable = objDB.ERP_StrategicPlan_GetManagement()
            Dim dataSelect As DataTable = dataInfoE.Clone
            dataSelect.Rows.Add(0, "Seleccione")

            For Each Info As DataRow In dataInfoE.Rows
                dataSelect.ImportRow(Info)
            Next

            cbMapaRiesgoDpto.DataSource = dataSelect
            cbMapaRiesgoDpto.DisplayMember = "Name"
            cbMapaRiesgoDpto.ValueMember = "Id_Deparment"

            cbGerenciaResponsableMap.DataSource = dataSelect
            cbGerenciaResponsableMap.DisplayMember = "Name"
            cbGerenciaResponsableMap.ValueMember = "Id_Deparment"
            cbGerenciaResponsableMap.Visible = True
            cbMapaRiesgoDpto.Visible = True
        End If

        GetProcessMapRisk(0)

    End Sub
    Private Sub GetProcessMapRisk(ByVal Id_Departamento As Integer)
        Using objDatos As New POA_SQLServer
            Try
                cmdMapaRiesgo.Enabled = True
                cmdModificarMApaRiesgo.Enabled = True
                cmdRevaluacionMapaRiesgo.Enabled = True

                dtProcess = objDatos.ERP_StrategicPlan_GetMapRiesgo(Id_DptoMap)
                If dtProcess IsNot Nothing And dtProcess.Rows.Count > 0 Then

                    dgMapaRiesgo.AutoGenerateColumns = False
                    dgMapaRiesgo.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
                    dgMapaRiesgo.Font = New Font("Segoe UI", 11)
                    dgMapaRiesgo.RowHeadersVisible = False
                    dgMapaRiesgo.ReadOnly = True
                    dgMapaRiesgo.SelectionMode = DataGridViewSelectionMode.FullRowSelect
                    dgMapaRiesgo.MultiSelect = False

                    dgMapaRiesgo.AllowUserToResizeColumns = False
                    dgMapaRiesgo.AllowUserToAddRows = False
                    dgMapaRiesgo.AllowUserToDeleteRows = False
                    dgMapaRiesgo.DataSource = dtProcess
                Else
                    cmdMapaRiesgo.Enabled = False
                    cmdModificarMApaRiesgo.Enabled = False
                    cmdRevaluacionMapaRiesgo.Enabled = False
                    dgMapaRiesgo.DataSource = Nothing
                End If
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
    End Sub

    Private Sub cmdAgregarMapaRiesgo_Click(sender As Object, e As EventArgs) Handles cmdAgregarMapaRiesgo.Click
        Using obj As New POA_MapaRiesgo
            obj._Update = False
            obj._VerMapa = False
            If obj.ShowDialog() = DialogResult.OK Then
                GetProcessMapRisk(0)
            End If
        End Using
    End Sub

    Private Sub tabUsuarios_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tabMapaRiesgo.SelectedIndexChanged
        Try
            If sender.SelectedTab.Name = "TabPageMApaRiesgo" Then
                GetProcessMapRisk(0)
            ElseIf sender.SelectedTab.Name = "TabPageProbabilidadOcurencia" Then
                GetProbabilityOccurrence()
            ElseIf sender.SelectedTab.Name = "TabPageGradoImpacto" Then
                GetImpactGrade()
            ElseIf sender.SelectedTab.Name = "TabPageResponsableMapa" Then
                GetResponsibleExecution(Id_DptoMap)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmdMapaRiesgo_Click(sender As Object, e As EventArgs) Handles cmdMapaRiesgo.Click
        Try
            If Not IsNothing(dgMapaRiesgo.SelectedRows) Then
                Using obj As New POA_MapaRiesgo
                    obj._Update = False
                    obj._Datos = dgMapaRiesgo.SelectedRows
                    obj._isInsert = False
                    obj._VerMapa = True
                    If obj.ShowDialog() = DialogResult.OK Then

                    End If
                    GetProcessMapRisk(_Id_DptoPlani)
                End Using
            End If
        Catch ex As Exception
            Using objLog As New ProcessGeneral
                objLog.AlmacenarLog(5, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
            End Using
        End Try
    End Sub



    Private Sub cmdEliminarMapaRiesgo_Click(sender As Object, e As EventArgs) Handles cmdRevaluacionMapaRiesgo.Click
        Try
            If dgMapaRiesgo.CurrentRow.Cells("ProbabilidadOcurrenciaE").Value.ToString.Trim = "" And dgMapaRiesgo.CurrentRow.Cells("GradoImpactoE").Value.ToString.Trim = "" Then
                If Not IsNothing(dgMapaRiesgo.SelectedRows) Then
                    Using obj As New POA_EvaluacionMapa
                        obj._Datos = dgMapaRiesgo.SelectedRows
                        obj._isInsert = False
                        If obj.ShowDialog() = DialogResult.OK Then

                        End If
                        GetProcessMapRisk(0)
                    End Using
                End If
            Else
                MessageBox.Show("Ya se realizo la Re-Evaluación para el Mapa Seleccionado", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmdModificarMApaRiesgo_Click(sender As Object, e As EventArgs) Handles cmdModificarMApaRiesgo.Click
        Try
            If dgMapaRiesgo.CurrentRow.Cells("ProbabilidadOcurrenciaE").Value.ToString.Trim = "" And dgMapaRiesgo.CurrentRow.Cells("GradoImpactoE").Value.ToString.Trim = "" Then
                If Not IsNothing(dgMapaRiesgo.SelectedRows) Then
                    Using obj As New POA_MapaRiesgo
                        obj._Update = True
                        obj._VerMapa = False
                        obj._Datos = dgMapaRiesgo.SelectedRows
                        obj._isInsert = False
                        If obj.ShowDialog() = DialogResult.OK Then

                        End If
                        GetProcessMapRisk(_Id_DptoPlani)
                    End Using
                End If
            Else
                MessageBox.Show("Ya se realizo la Re-Evaluación para el Mapa Seleccionado", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmbImprimirEvaluacion_Click(sender As Object, e As EventArgs) Handles cmbImprimirEvaluacion.Click
        Try
            If Not IsNothing(dgMapaRiesgo.SelectedRows) Then

                If dgMapaRiesgo.CurrentRow.Cells("ProbabilidadOcurrenciaE").Value.ToString = "" Or dgMapaRiesgo.CurrentRow.Cells("ProbabilidadOcurrenciaE").Value.ToString = "0" Then
                    MessageBox.Show("Primero debe realizar la Re-Evaluación para imprimir el reporte", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If

                Dim ID_RiskMap As Integer = dgMapaRiesgo.CurrentRow.Cells("ID_RiskMap").Value.ToString
                Dim AnioMap As String = dgMapaRiesgo.CurrentRow.Cells("AnioMap").Value.ToString
                Dim Dpto As String = dgMapaRiesgo.CurrentRow.Cells("DptoMap").Value.ToString
                Dim Ds As New ReporteMapaRiesgo
                Dim dt As New ReporteMapaRiesgoTableAdapters.ERP_StrategicPlan_GetMapRiesgoReportEvaluacionTableAdapter
                Dim CadenaConexion As String = dt.Connection.ConnectionString.ToString.Replace("[user]", _UserSQL).Replace("[password]", _Password)
                Dim dt1 As DataTable
                dt.Connection.ConnectionString = CadenaConexion

                dt.Fill(Ds.ERP_StrategicPlan_GetMapRiesgoReportEvaluacion, ID_RiskMap)
                dt1 = Ds.Tables("ERP_StrategicPlan_GetMapRiesgoReportEvaluacion")

                Dim Evaluacion As String = "PROBABILIDAD DE OCURRENCIA: " + dgMapaRiesgo.CurrentRow.Cells("ProbabilidadOcurrenciaE").Value.ToString + "                    GRADO DE IMPACTO: " + dgMapaRiesgo.CurrentRow.Cells("GradoImpactoE").Value.ToString
                Dim Descripcion As String = dgMapaRiesgo.CurrentRow.Cells("SeveridadE").Value.ToString
                Dim Creacion As String = ""
                Dim Autorizacion As String = ""
                Try
                    Creacion = dgMapaRiesgo.CurrentRow.Cells("IdResponsableCEvaluacion").Value.ToString
                    Autorizacion = dgMapaRiesgo.CurrentRow.Cells("IdResponsableAEvaluacion").Value.ToString

                Catch ex As Exception
                    Creacion = ""
                    Autorizacion = ""
                End Try
                Using objPartidaContable As New Planificacion_ReportViewer(dt1, "ReporteMapaRiesgoEvaluacion", "epd_SatelliteERP.ReporteMapaRiesgoEvaluacion.rdlc", Dpto, AnioMap, Evaluacion, Descripcion, Creacion, Autorizacion)
                    objPartidaContable.ShowDialog()
                End Using

            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmdImprimirMapa_Click(sender As Object, e As EventArgs) Handles cmdImprimirMapa.Click
        Try
            If Not IsNothing(dgMapaRiesgo.SelectedRows) Then
                Dim ID_RiskMapa As Integer = dgMapaRiesgo.CurrentRow.Cells("ID_RiskMap").Value.ToString
                Dim AnioMap As String = dgMapaRiesgo.CurrentRow.Cells("AnioMap").Value.ToString
                Dim Dpto As String = dgMapaRiesgo.CurrentRow.Cells("DptoMap").Value.ToString
                Dim Ds As New ReporteMapaRiesgo
                Dim dt As New ReporteMapaRiesgoTableAdapters.ERP_StrategicPlan_GetMapRiesgoReportTableAdapter
                Dim CadenaConexion As String = dt.Connection.ConnectionString.ToString.Replace("[user]", _UserSQL).Replace("[password]", _Password)
                Dim dt1 As DataTable
                dt.Connection.ConnectionString = CadenaConexion

                dt.Fill(Ds.ERP_StrategicPlan_GetMapRiesgoReport, ID_RiskMapa)
                dt1 = Ds.Tables(1)
                Using objPartidaContable As New Planificacion_ReportViewer(dt1, "ReporteMapaRiesgo", "epd_SatelliteERP.ReporteMapaRiesgo.rdlc", Dpto , AnioMap, "", "", "", "")
                    objPartidaContable.ShowDialog()
                End Using
            End If

        Catch ex As Exception

        End Try
    End Sub


    Private Sub cmdAgragarProbabilidad_Click(sender As Object, e As EventArgs) Handles cmdAgregarProbabilidad.Click
        Using obj As New POA_InsertProbabilidad
            If obj.ShowDialog() = DialogResult.OK Then
                GetProbabilityOccurrence()
            End If
        End Using
    End Sub

    Private Sub cmdModificarProbabilidad_Click(sender As Object, e As EventArgs) Handles cmdModificarProbabilidad.Click
        Try
            Using obj As New POA_InsertProbabilidad
                'obj.GroupBox1.Text = "Configuración Modificar Usuarios"
                obj._isInsert = False
                obj._id_Probabilidad = DG_Probabilidad.CurrentRow.Cells("ID_ProbabilityOccurrence").Value
                obj._Probabilidad = DG_Probabilidad.CurrentRow.Cells("Probability").Value
                obj._Descripcion = DG_Probabilidad.CurrentRow.Cells("DescriptionProbabilidad").Value
                If obj.ShowDialog() = DialogResult.OK Then
                    GetProbabilityOccurrence()
                End If
            End Using
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmdEliminarProbabilidad_Click(sender As Object, e As EventArgs) Handles cmdEliminarProbabilidad.Click
        Try
            Dim mensaje As String = "¿Está seguro(a) que quiere eliminar la Probalidad de Ocurencia   : " & vbCrLf &
              "Nombre : " & DG_Probabilidad.CurrentRow.Cells(1).Value & vbCrLf & "?"
            If MessageBox.Show(mensaje, Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                If objDB.EERP_StrategicPlan_DeleteProbabilityOccurrence(DG_Probabilidad.CurrentRow.Cells(0).Value) = "OK" Then
                    GetProbabilityOccurrence()
                Else
                    MessageBox.Show("Error en eliminación La Probabilidad de Ocurencia.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub



    Private Sub cmdImpacto_Click(sender As Object, e As EventArgs) Handles cmdImpacto.Click
        Using obj As New POA_InsertGradoImpacto
            If obj.ShowDialog() = DialogResult.OK Then
                GetImpactGrade()
            End If
        End Using
    End Sub

    Private Sub cmdModificarImpacto_Click(sender As Object, e As EventArgs) Handles cmdModificarImpacto.Click
        Try
            Using obj As New POA_InsertGradoImpacto
                'obj.GroupBox1.Text = "Configuración Modificar Usuarios"
                obj._isInsert = False
                obj._id_gradoImpacto = DG_ImpactGrade.CurrentRow.Cells("ID_ImpactGrade").Value
                obj._Probabilidad = DG_ImpactGrade.CurrentRow.Cells("ProbabilityImpacto").Value
                obj._Descripcion = DG_ImpactGrade.CurrentRow.Cells("DescriptionImpacto").Value
                If obj.ShowDialog() = DialogResult.OK Then
                    GetImpactGrade()
                End If
            End Using
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmdEliminarImpacto_Click(sender As Object, e As EventArgs) Handles cmdEliminarImpacto.Click
        Try
            Dim mensaje As String = "¿Está seguro(a) que quiere eliminar el Grado de Impacto   : " & vbCrLf &
               "Nombre : " & DG_ImpactGrade.CurrentRow.Cells(1).Value & vbCrLf & "?"
            If MessageBox.Show(mensaje, Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                If objDB.EERP_StrategicPlan_DeleteImpactGrade(DG_ImpactGrade.CurrentRow.Cells(0).Value) = "OK" Then
                    GetImpactGrade()
                Else
                    MessageBox.Show("Error en eliminación La Probabilidad de Ocurencia.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub


    Private Sub GetProbabilityOccurrence()
        Using objDatos As New POA_SQLServer
            Try
                dtProbabilityOccurrence = objDatos.ERP_StrategicPlan_GetProbabilityOccurrence()
                If dtProbabilityOccurrence IsNot Nothing Then
                    DG_Probabilidad.AutoGenerateColumns = False
                    DG_Probabilidad.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
                    DG_Probabilidad.Font = New Font("Segoe UI", 11)
                    DG_Probabilidad.RowHeadersVisible = False
                    DG_Probabilidad.Columns(0).Width = 175
                    DG_Probabilidad.Columns(1).Width = 250
                    DG_Probabilidad.Columns(2).Width = 250
                    DG_Probabilidad.Columns(3).Width = 150
                    DG_Probabilidad.Columns(3).DefaultCellStyle.Format = "yyyy/MM/dd HH:mm:ss"
                    DG_Probabilidad.Columns(4).Width = 150
                    DG_Probabilidad.Columns(5).Width = 150
                    DG_Probabilidad.Columns(6).Width = 150
                    DG_Probabilidad.Columns(7).Width = 150

                    DG_Probabilidad.ReadOnly = True
                    DG_Probabilidad.SelectionMode = DataGridViewSelectionMode.FullRowSelect
                    DG_Probabilidad.MultiSelect = False

                    DG_Probabilidad.AllowUserToResizeColumns = False
                    DG_Probabilidad.AllowUserToAddRows = False
                    DG_Probabilidad.AllowUserToDeleteRows = False
                    DG_Probabilidad.DataSource = dtProbabilityOccurrence
                End If
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
    End Sub


    Private Sub GetImpactGrade()
        Using objDatos As New POA_SQLServer
            Try
                dtImpactGrade = objDatos.ERP_StrategicPlan_GetImpactGrade()
                If dtImpactGrade IsNot Nothing Then
                    DG_ImpactGrade.AutoGenerateColumns = False
                    DG_ImpactGrade.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
                    DG_ImpactGrade.Font = New Font("Segoe UI", 11)
                    DG_ImpactGrade.RowHeadersVisible = False
                    DG_ImpactGrade.Columns(0).Width = 175
                    DG_ImpactGrade.Columns(1).Width = 250
                    DG_ImpactGrade.Columns(2).Width = 250
                    DG_ImpactGrade.Columns(3).Width = 150
                    DG_ImpactGrade.Columns(3).DefaultCellStyle.Format = "yyyy/MM/dd HH:mm:ss"
                    DG_ImpactGrade.Columns(4).Width = 150
                    DG_ImpactGrade.Columns(5).Width = 150
                    DG_ImpactGrade.Columns(6).Width = 150
                    DG_ImpactGrade.Columns(7).Width = 150

                    DG_ImpactGrade.ReadOnly = True
                    DG_ImpactGrade.SelectionMode = DataGridViewSelectionMode.FullRowSelect
                    DG_ImpactGrade.MultiSelect = False

                    DG_ImpactGrade.AllowUserToResizeColumns = False
                    DG_ImpactGrade.AllowUserToAddRows = False
                    DG_ImpactGrade.AllowUserToDeleteRows = False
                    DG_ImpactGrade.DataSource = dtImpactGrade
                End If
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
    End Sub

    Private Sub cmdAgregarResponsableEjecucion_Click_1(sender As Object, e As EventArgs) Handles cmdAgregarResponsableMapa.Click
        Using obj As New POA_InsertResponsableMapRisk
            If obj.ShowDialog() = DialogResult.OK Then
                GetResponsibleExecution(Id_DptoMap)
            End If
        End Using
    End Sub

    Private Sub cmdModificarResponsableEjecucion_Click_1(sender As Object, e As EventArgs) Handles cmdModificarResponsableMapa.Click
        Try
            Using obj As New POA_InsertResponsableMapRisk
                obj._isInsert = False
                obj._id_ResponsableEjecucion = DG_ResponsableEjecucionMapa.CurrentRow.Cells("ID_ResponsibleMapRisk").Value
                obj._name = DG_ResponsableEjecucionMapa.CurrentRow.Cells("NameResponsableEjecucion").Value
                obj._description = DG_ResponsableEjecucionMapa.CurrentRow.Cells("DescriptionResponsableEjecucion").Value
                If obj.ShowDialog() = DialogResult.OK Then
                    GetResponsibleExecution(Id_DptoMap)
                End If
            End Using
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmdEliminarResponsableEjecucion_Click(sender As Object, e As EventArgs) Handles cmdEliminarResponsableMapa.Click
        Try
            Dim mensaje As String = "¿Está seguro(a) que quiere eliminar el responsable de la ejecución   : " & vbCrLf &
                "Nombre : " & DG_ResponsableEjecucionMapa.CurrentRow.Cells(1).Value & vbCrLf & "?"

            If MessageBox.Show(mensaje, Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                If objDB.EERP_StrategicPlan_DeleteResponsibleMapRisk(DG_ResponsableEjecucionMapa.CurrentRow.Cells(0).Value) = "OK" Then
                    GetResponsibleExecution(Id_DptoMap)
                Else
                    MessageBox.Show("Error en eliminación el responsable de ejecucion.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub GetResponsibleExecution(ByVal Id_departamento As Integer)
        Using objDatos As New POA_SQLServer
            Try
                Dim dtEResponsableMapRisk As New DataTable
                dtEResponsableMapRisk = objDatos.ERP_StrategicPlan_GetResponsibleMapRisk(Id_departamento)
                If dtEResponsableMapRisk IsNot Nothing Then
                    DG_ResponsableEjecucionMapa.AutoGenerateColumns = False
                    DG_ResponsableEjecucionMapa.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
                    DG_ResponsableEjecucionMapa.Font = New Font("Segoe UI", 11)
                    DG_ResponsableEjecucionMapa.RowHeadersVisible = False
                    DG_ResponsableEjecucionMapa.Columns(0).Width = 75
                    DG_ResponsableEjecucionMapa.Columns(1).Width = 600
                    DG_ResponsableEjecucionMapa.Columns(2).Width = 600
                    DG_ResponsableEjecucionMapa.Columns(3).Width = 125
                    DG_ResponsableEjecucionMapa.Columns(3).DefaultCellStyle.Format = "yyyy/MM/dd HH:mm:ss"
                    DG_ResponsableEjecucionMapa.Columns(4).Width = 125
                    DG_ResponsableEjecucionMapa.Columns(5).Width = 125

                    DG_ResponsableEjecucionMapa.ReadOnly = True
                    DG_ResponsableEjecucionMapa.SelectionMode = DataGridViewSelectionMode.FullRowSelect
                    DG_ResponsableEjecucionMapa.MultiSelect = False

                    DG_ResponsableEjecucionMapa.AllowUserToResizeColumns = False
                    DG_ResponsableEjecucionMapa.AllowUserToAddRows = False
                    DG_ResponsableEjecucionMapa.AllowUserToDeleteRows = False
                    DG_ResponsableEjecucionMapa.DataSource = dtEResponsableMapRisk
                End If
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
    End Sub

    Private Sub cbGerenciaResponsable_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbGerenciaResponsableMap.SelectedIndexChanged
        Try
            GetResponsibleExecution(cbGerenciaResponsableMap.SelectedValue)
        Catch ex As Exception
            Using objLog As New ProcessGeneral
                objLog.AlmacenarLog(5, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
            End Using
        End Try
    End Sub

    Private Sub btnSubirDocMapa_Click(sender As Object, e As EventArgs) Handles btnSubirDocMapa.Click
        Try
            If Not IsNothing(dgMapaRiesgo.CurrentRow) Then
                Using obj As New SubirDocumentosRespaldo
                    obj._Id_Encabezado = dgMapaRiesgo.CurrentRow.Cells("ID_RiskMap").Value.ToString
                    obj.Anio = 0
                    obj._PEI = False
                    obj._POA = False
                    obj._MAPA = True
                    obj.ShowDialog()
                End Using
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class
