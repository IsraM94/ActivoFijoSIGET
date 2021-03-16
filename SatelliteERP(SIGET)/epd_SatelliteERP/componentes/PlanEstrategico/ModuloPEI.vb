Public Class ModuloPEI
    Private objSqlDB As New POA_SQLServer
    Private dtGerencia As DataTable
    Private dtObjetivos As DataTable
    Private dtEjeEstrategico As DataTable
    Private dtEjesEstrategicos As DataTable
    Private dtEResponsableEjecucion As DataTable
    Private dtResult As DataTable
    Private dtIndicatos As DataTable
    Private dtCollectingAgency As DataTable
    Private dtMunicipality As DataTable
    Private dtCountry As DataTable
    Private dtUnitMeasure As DataTable
    Private dtInstitutionalPhilosophy As DataTable
    Private OpcionesMenu As DataTable
    Private objSql2 As New Generic_SQLServer
    Private dtProbabilityOccurrence As DataTable
    Private dtImpactGrade As DataTable
    Private objDB As New POA_SQLServer
    Private dtProcess As DataTable
    Private _UsuarioPlanificacion As Integer = 0
    Private _UsuarioFortalecimiento As Boolean = False

    Private Sub ModuloUsers_Load(sender As Object, e As EventArgs) Handles Me.Load

        OpcionesMenu = objSql2.GetAccessMenu(_UserSQL)
        _VerTodos = False
        _Id_DptoPlani = 0

        tabPEI.TabPages.Remove(TabPageObjetivos)
        tabPEI.TabPages.Remove(TagPageEstrategicos)
        tabPEI.TabPages.Remove(TabPageResultado)
        tabPEI.TabPages.Remove(TabPageIndicador)
        tabPEI.TabPages.Remove(TagPageAccionesEstrategicas)
        tabPEI.TabPages.Remove(TabModuloPei)
        tabPEI.TabPages.Remove(TagPageGerencia)

        If (OpcionesMenu.Rows.Count > 0) Then
            For Each DataInfo As DataRow In OpcionesMenu.Rows

                If (DataInfo("rolUser").ToString.ToUpper = "MN_PEI_MenuVer_A_Objetivo".ToString.ToUpper) Then
                    tabPEI.TabPages.Add(TabPageObjetivos)
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "MN_PEI_MenuVer_B_Ejes".ToString.ToUpper) Then
                    tabPEI.TabPages.Add(TagPageEstrategicos)
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "MN_PEI_MenuVer_C_Resultado".ToString.ToUpper) Then
                    tabPEI.TabPages.Add(TabPageResultado)
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "MN_PEI_MenuVer_D_Indicadores".ToString.ToUpper) Then
                    tabPEI.TabPages.Add(TabPageIndicador)
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "MN_PEI_MenuVer_E_AccionesEstrategicas".ToString.ToUpper) Then
                    tabPEI.TabPages.Add(TagPageAccionesEstrategicas)
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "MN_PEI_MenuVer_F_MatrizPEI".ToString.ToUpper) Then
                    tabPEI.TabPages.Add(TabModuloPei)
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "MN_PEI_MenuVer_G_Departamentos".ToString.ToUpper) Then
                    tabPEI.TabPages.Add(TagPageGerencia)
                End If

                If (DataInfo("rolUser").ToString.ToUpper = "PLA_Planificacion_PEI_DPTO_A_Crear".ToString.ToUpper) Then
                    cmdCreateGerencia.Visible = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "PLA_Planificacion_PEI_DPTO_B_Modificar".ToString.ToUpper) Then
                    cmdModifyGerencia.Visible = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "PLA_Planificacion_PEI_DPTO_C_Eliminar".ToString.ToUpper) Then
                    DeleteGerencia.Visible = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "PLA_Planificacion_PEI_OBJ_A_Crear".ToString.ToUpper) Then
                    cmdAgregarObjetivo.Visible = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "PLA_Planificacion_PEI_OBJ_B_Ver".ToString.ToUpper) Then
                    cmdVerObjetivos.Visible = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "PLA_Planificacion_PEI_OBJ_C_Modificar".ToString.ToUpper) Then
                    cmdModificarObjetivo.Visible = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "PLA_Planificacion_PEI_OBJ_D_Desactivar".ToString.ToUpper) Then
                    cmdEliminarObjetivo.Visible = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "PLA_Planificacion_PEI_EJE_A_Ver".ToString.ToUpper) Then
                    cmdVerEjesEstrategicos.Visible = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "PLA_Planificacion_PEI_EJE_B_Crear".ToString.ToUpper) Then
                    cmdAgregarEjesEstrategicos.Visible = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "PLA_Planificacion_PEI_EJE_C_Modificar".ToString.ToUpper) Then
                    cmdModificarEjesEstrategicos.Visible = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "PLA_Planificacion_PEI_EJE_D_Desactivar".ToString.ToUpper) Then
                    cmdEliminarEjesEstrategicos.Visible = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "PLA_Planificacion_PEI_RES_A_Ver".ToString.ToUpper) Then
                    cmdVerResultado.Visible = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "PLA_Planificacion_PEI_RES_B_Crear".ToString.ToUpper) Then
                    cmdAgregarResultado.Visible = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "PLA_Planificacion_PEI_RES_C_Modificar".ToString.ToUpper) Then
                    cmdModificarResultado.Visible = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "PLA_Planificacion_PEI_RES_D_Desactivar".ToString.ToUpper) Then
                    cmdEliminarResultado.Visible = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "PLA_Planificacion_PEI_IND_A_Ver".ToString.ToUpper) Then
                    cmdVerIndicador.Visible = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "PLA_Planificacion_PEI_IND_B_Crear".ToString.ToUpper) Then
                    cmdAgregarIndicador.Visible = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "PLA_Planificacion_PEI_IND_C_Modificar".ToString.ToUpper) Then
                    cmdModificarIndicador.Visible = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "PLA_Planificacion_PEI_IND_D_Desactivar".ToString.ToUpper) Then
                    cmdEliminarIndicador.Visible = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "PLA_Planificacion_PEI_ACC_A_Ver".ToString.ToUpper) Then
                    cmdVerAccionesEstrategicas.Visible = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "PLA_Planificacion_PEI_ACC_B_Crear".ToString.ToUpper) Then
                    cmdAgregarEstrategicas.Visible = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "PLA_Planificacion_PEI_ACC_C_Modificar".ToString.ToUpper) Then
                    cmdModificarEstrategica.Visible = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "PLA_Planificacion_PEI_ACC_D_Desactivar".ToString.ToUpper) Then
                    cmdEliminarEstrategicas.Visible = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "PLA_Planificacion_PEI_ACC_E_Reordenar".ToString.ToUpper) Then
                    btnReordenar.Visible = True

                ElseIf (DataInfo("rolUser").ToString.ToUpper = "PLA_Planificacion_PEI_PRO_A_Crear".ToString.ToUpper) Then
                    cmdAgregarPEI.Visible = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "PLA_Planificacion_PEI_PRO_B_Modificar".ToString.ToUpper) Then
                    cmdModificarPEI.Visible = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "PLA_Planificacion_PEI_PRO_C_Reporte".ToString.ToUpper) Then
                    btnReportePEI.Visible = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "PLA_Planificacion_PEI_PRO_D_EnviarAprobacion".ToString.ToUpper) Then
                    btnEnviarAprobacion.Visible = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "PLA_Planificacion_PEI_PRO_E_AprobacionGeren".ToString.ToUpper) Then
                    btnAprRecGerencia.Visible = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "PLA_Planificacion_PEI_PRO_F_AprobacionPlani".ToString.ToUpper) Then
                    btnAproRechPlanificacion.Visible = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "PLA_Planificacion_PEI_PRO_G_Historial".ToString.ToUpper) Then
                    btnHistorialObservaciones.Visible = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "PLA_Planificacion_PEI_PRO_H_SubirDocumentos".ToString.ToUpper) Then
                    btnSubirDocPEI.Visible = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "PLA_Planificacion_PEI_PRO_G_UsuarioFortalecimiento".ToString.ToUpper) Then
                    _UsuarioFortalecimiento = True

                ElseIf (DataInfo("rolUser").ToString.ToUpper = "PLA_Planificacion_POASuperUsuario".ToString.ToUpper) Then
                    _SuperUsuarioPlanificacion = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "PLA_Planificacion_VerTodo".ToString.ToUpper) Then
                    _VerTodos = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "PLA_Planificacion_POA_PRO_E_AprobacionPlani".ToString.ToUpper) Then
                    _UsuarioPlanificacion = True
                End If

            Next
        End If


        If Not _VerTodos Then
            _Id_DptoPlani = _Id_DepartmentGlobal
        End If

        GetManagement()

        GetProcess()

        Dim dataInfoGerencia As DataTable = objSqlDB.ERP_StrategicPlan_GetManagement()

        Dim dataSelect As DataTable = dataInfoGerencia.Clone
        dataSelect.Rows.Add(0, "Seleccione")


        For Each Info As DataRow In dataInfoGerencia.Rows
            dataSelect.ImportRow(Info)
        Next
        CargarCombo(cbObjetivosGerencia, dataSelect)
        CargarCombo(cbGerenciaEstrategica, dataSelect)
        CargarCombo(cbGerenciaResultados, dataSelect)
        CargarCombo(cbGerenciaIndicadores, dataSelect)
        CargarCombo(cbGerenciaEjes, dataSelect)
        CargarCombo(cbGerenciaPEI, dataSelect)

        Try
            GetStrategicObjectives(cbObjetivosGerencia.SelectedValue)
        Catch ex As Exception
            GetStrategicObjectives(0)
        End Try



        If Not _DepartamentoHijo Then
            cmdAgregarPEI.Enabled = False
            cmdModificarPEI.Enabled = False
        End If


    End Sub

    Sub CargarCombo(ByVal Combo As ComboBox, ByVal Dt As DataTable)
        Combo.DataSource = Dt
        Combo.DisplayMember = "Name"
        Combo.ValueMember = "Id_Deparment"

    End Sub
    Private Sub tabMantenimientos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tabPEI.SelectedIndexChanged
        Try
            If sender.SelectedTab.Name = "TagPageGerencia" Then
                GetManagement()
            ElseIf sender.SelectedTab.Name = "TabPageObjetivos" Then
                Try
                    GetStrategicObjectives(cbObjetivosGerencia.SelectedValue)
                Catch ex As Exception
                    GetStrategicObjectives(0)
                End Try
            ElseIf sender.SelectedTab.Name = "TagPageEstrategicos" Then
                Try
                    GetStrategicAxes(cbGerenciaEjes.SelectedValue)
                Catch ex As Exception
                    GetStrategicAxes(0)
                End Try
            ElseIf sender.SelectedTab.Name = "TagPageAccionesEstrategicas" Then
                Try
                    GetStrategicActions(cbGerenciaEstrategica.SelectedValue)
                Catch ex As Exception
                    GetStrategicActions(0)
                End Try

            ElseIf sender.SelectedTab.Name = "TabPageResultado" Then
                Try
                    GetResult(cbGerenciaResultados.SelectedValue)
                Catch ex As Exception
                    GetResult(0)
                End Try
            ElseIf sender.SelectedTab.Name = "TabPageIndicador" Then
                Try
                    GetIndicator(cbGerenciaIndicadores.SelectedValue)
                Catch ex As Exception
                    GetIndicator(0)
                End Try
            ElseIf sender.SelectedTab.Name = "TabModuloPei" Then
                GetProcess()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmdCreate_CategoryMaintenance_Click(sender As Object, e As EventArgs)
        Using obj As New Config_UserAccess
            obj._username = DG_Gerencia.CurrentRow.Cells("UserName").Value
            obj.ShowDialog()
        End Using
    End Sub

    Private Sub cmdModifyGerencia_Click(sender As Object, e As EventArgs) Handles cmdModifyGerencia.Click
        Try
            Using obj As New POA_InsertGerencia
                'obj.GroupBox1.Text = "Configuración Modificar Usuarios"
                obj._isInsert = False
                obj._id_Management = DG_Gerencia.CurrentRow.Cells("ID_Management").Value
                obj._name = DG_Gerencia.CurrentRow.Cells("NameManegement").Value.ToString
                obj._description = DG_Gerencia.CurrentRow.Cells("InternalCode").Value.ToString
                obj._servicio = DG_Gerencia.CurrentRow.Cells("servicio").Value.ToString
                obj._Padre = Convert.ToBoolean(DG_Gerencia.CurrentRow.Cells("Padre").Value)
                If obj.ShowDialog() = DialogResult.OK Then
                    GetManagement()
                End If

            End Using
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmdCreateGerencia_Click(sender As Object, e As EventArgs) Handles cmdCreateGerencia.Click
        Using obj As New POA_InsertGerencia
            If obj.ShowDialog() = DialogResult.OK Then
                GetManagement()
            End If
        End Using
    End Sub

    Private Sub GetManagement()
        Using objDatos As New POA_SQLServer
            Try
                dtGerencia = objDatos.ERP_StrategicPlan_GetManagement()
                If dtGerencia IsNot Nothing Then
                    DG_Gerencia.AutoGenerateColumns = False
                    DG_Gerencia.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
                    DG_Gerencia.Font = New Font("Segoe UI", 11)
                    DG_Gerencia.RowHeadersVisible = False
                    DG_Gerencia.Columns(0).Width = 75
                    DG_Gerencia.Columns(1).Width = 500
                    DG_Gerencia.Columns(2).Width = 200
                    DG_Gerencia.Columns(3).Width = 400
                    DG_Gerencia.Columns(3).DefaultCellStyle.Format = "yyyy/MM/dd HH:mm:ss"
                    DG_Gerencia.Columns(4).Width = 125
                    DG_Gerencia.Columns(5).Width = 125

                    DG_Gerencia.ReadOnly = True
                    DG_Gerencia.SelectionMode = DataGridViewSelectionMode.FullRowSelect
                    DG_Gerencia.MultiSelect = False

                    DG_Gerencia.AllowUserToResizeColumns = False
                    DG_Gerencia.AllowUserToAddRows = False
                    DG_Gerencia.AllowUserToDeleteRows = False
                    DG_Gerencia.DataSource = dtGerencia
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

    Private Sub GetStrategicObjectives(ByVal Id_Departamento As Integer)
        Using objDatos As New POA_SQLServer
            Try

                If Id_Departamento > 0 Then
                    dtObjetivos = objDatos.ERP_StrategicPlan_GetStrategicObjective(Id_Departamento)
                Else
                    dtObjetivos = objDatos.ERP_StrategicPlan_GetStrategicObjective(_Id_DptoPlani)
                End If


                If dtObjetivos IsNot Nothing Then

                    Try
                        For Each DataIn In dtObjetivos.Rows
                            If DataIn("Tipo").ToString = "0" Then
                                cmdModificarObjetivo.Enabled = False
                                cmdEliminarObjetivo.Enabled = False
                                cmdAgregarObjetivo.Enabled = False
                            End If
                        Next
                    Catch ex As Exception

                    End Try

                    DG_Objetivo.AutoGenerateColumns = False
                    DG_Objetivo.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
                    DG_Objetivo.Font = New Font("Segoe UI", 11)
                    DG_Objetivo.RowHeadersVisible = False
                    DG_Objetivo.Columns(0).Width = 75
                    DG_Objetivo.Columns(1).Width = 100
                    DG_Objetivo.Columns(2).Width = 400
                    DG_Objetivo.Columns(3).Width = 600
                    DG_Objetivo.Columns(4).Width = 600
                    DG_Objetivo.Columns(5).Width = 125
                    DG_Objetivo.Columns(5).DefaultCellStyle.Format = "yyyy/MM/dd HH:mm:ss"
                    DG_Objetivo.Columns(6).Width = 125
                    DG_Objetivo.Columns(7).Width = 125

                    DG_Objetivo.ReadOnly = True
                    DG_Objetivo.SelectionMode = DataGridViewSelectionMode.FullRowSelect
                    DG_Objetivo.MultiSelect = False

                    DG_Objetivo.AllowUserToResizeColumns = False
                    DG_Objetivo.AllowUserToAddRows = False
                    DG_Objetivo.AllowUserToDeleteRows = False
                    DG_Objetivo.DataSource = dtObjetivos
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

    Private Sub GetStrategicAxes(ByVal Id_Departamento As Integer)
        Using objDatos As New POA_SQLServer
            Try
                dtEjeEstrategico = objDatos.ERP_StrategicPlan_GetStrategicAxes(0, Id_Departamento)
                If dtEjeEstrategico IsNot Nothing Then
                    DG_EjesEstrategicos.AutoGenerateColumns = False
                    DG_EjesEstrategicos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
                    DG_EjesEstrategicos.Font = New Font("Segoe UI", 11)
                    DG_EjesEstrategicos.RowHeadersVisible = False
                    DG_EjesEstrategicos.Columns(0).Width = 75
                    DG_EjesEstrategicos.Columns(1).Width = 75
                    DG_EjesEstrategicos.Columns(2).Width = 600
                    DG_EjesEstrategicos.Columns(3).Width = 600
                    DG_EjesEstrategicos.Columns(4).Width = 125
                    DG_EjesEstrategicos.Columns(4).DefaultCellStyle.Format = "yyyy/MM/dd HH:mm:ss"
                    DG_EjesEstrategicos.Columns(5).Width = 125
                    DG_EjesEstrategicos.Columns(6).Width = 125

                    DG_EjesEstrategicos.ReadOnly = True
                    DG_EjesEstrategicos.SelectionMode = DataGridViewSelectionMode.FullRowSelect
                    DG_EjesEstrategicos.MultiSelect = False

                    DG_EjesEstrategicos.AllowUserToResizeColumns = False
                    DG_EjesEstrategicos.AllowUserToAddRows = False
                    DG_EjesEstrategicos.AllowUserToDeleteRows = False
                    DG_EjesEstrategicos.DataSource = dtEjeEstrategico
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

    Private Sub GetStrategicActions(ByVal Id_Departamento As Integer)
        Using objDatos As New POA_SQLServer
            Try
                dtEjesEstrategicos = objDatos.ERP_StrategicPlan_GetStrategicActions(0, Id_Departamento)
                If dtEjesEstrategicos IsNot Nothing Then
                    DG_AccionesEstrategica.AutoGenerateColumns = False
                    DG_AccionesEstrategica.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
                    DG_AccionesEstrategica.Font = New Font("Segoe UI", 11)
                    DG_AccionesEstrategica.RowHeadersVisible = False
                    DG_AccionesEstrategica.Columns(0).Width = 75
                    DG_AccionesEstrategica.Columns(1).Width = 75
                    DG_AccionesEstrategica.Columns(2).Width = 500
                    DG_AccionesEstrategica.Columns(3).Width = 500
                    DG_AccionesEstrategica.Columns(4).Width = 500
                    DG_AccionesEstrategica.Columns(5).Width = 300
                    DG_AccionesEstrategica.Columns(6).Width = 300
                    DG_AccionesEstrategica.Columns(7).Width = 125
                    DG_AccionesEstrategica.Columns("FechaVencimientoAcciones").DefaultCellStyle.Format = "dd/MM/yyyy"
                    DG_AccionesEstrategica.Columns(9).Width = 125
                    DG_AccionesEstrategica.Columns(10).Width = 125

                    DG_AccionesEstrategica.ReadOnly = True
                    DG_AccionesEstrategica.SelectionMode = DataGridViewSelectionMode.FullRowSelect
                    DG_AccionesEstrategica.MultiSelect = False

                    DG_AccionesEstrategica.AllowUserToResizeColumns = False
                    DG_AccionesEstrategica.AllowUserToAddRows = False
                    DG_AccionesEstrategica.AllowUserToDeleteRows = False
                    DG_AccionesEstrategica.DataSource = dtEjesEstrategicos
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


    Private Sub GetResult(ByVal Id_Departamento As Integer)
        Using objDatos As New POA_SQLServer
            Try
                dtResult = objDatos.ERP_StrategicPlan_GetResult(0, Id_Departamento)
                If dtResult IsNot Nothing Then
                    DG_Result.AutoGenerateColumns = False
                    DG_Result.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
                    DG_Result.Font = New Font("Segoe UI", 11)
                    DG_Result.RowHeadersVisible = False
                    DG_Result.Columns(0).Width = 75
                    DG_Result.Columns(1).Width = 75
                    DG_Result.Columns(2).Width = 500
                    DG_Result.Columns(3).Width = 500
                    DG_Result.Columns(4).Width = 400
                    DG_Result.Columns(4).DefaultCellStyle.Format = "yyyy/MM/dd HH:mm:ss"
                    DG_Result.Columns(5).Width = 125
                    DG_Result.Columns(6).Width = 125

                    DG_Result.ReadOnly = True
                    DG_Result.SelectionMode = DataGridViewSelectionMode.FullRowSelect
                    DG_Result.MultiSelect = False

                    DG_Result.AllowUserToResizeColumns = False
                    DG_Result.AllowUserToAddRows = False
                    DG_Result.AllowUserToDeleteRows = False
                    DG_Result.DataSource = dtResult
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

    Private Sub GetIndicator(ByVal Id_departamento As Integer)
        Using objDatos As New POA_SQLServer
            Try
                dtIndicatos = objDatos.ERP_StrategicPlan_Getindicator(Id_departamento)
                If dtIndicatos IsNot Nothing Then
                    DG_Indicadores.AutoGenerateColumns = False
                    DG_Indicadores.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
                    DG_Indicadores.Font = New Font("Segoe UI", 11)
                    DG_Indicadores.RowHeadersVisible = False
                    DG_Indicadores.Columns(0).Width = 75
                    DG_Indicadores.Columns(1).Width = 75
                    DG_Indicadores.Columns(2).Width = 500
                    DG_Indicadores.Columns(3).Width = 500
                    DG_Indicadores.Columns(4).Width = 500
                    DG_Indicadores.Columns(4).DefaultCellStyle.Format = "yyyy/MM/dd HH:mm:ss"
                    DG_Indicadores.Columns(5).Width = 125
                    DG_Indicadores.Columns(6).Width = 125

                    DG_Indicadores.ReadOnly = True
                    DG_Indicadores.SelectionMode = DataGridViewSelectionMode.FullRowSelect
                    DG_Indicadores.MultiSelect = False

                    DG_Indicadores.AllowUserToResizeColumns = False
                    DG_Indicadores.AllowUserToAddRows = False
                    DG_Indicadores.AllowUserToDeleteRows = False
                    DG_Indicadores.DataSource = dtIndicatos
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



    Private Sub DeleteGerencia_Click(sender As Object, e As EventArgs) Handles DeleteGerencia.Click
        Try
            Dim mensaje As String = "¿Está seguro(a) que quiere eliminar la siguiente Gerencia y/o Unidad de Asesoría : " & vbCrLf &
               "Nombre : " & DG_Gerencia.CurrentRow.Cells(1).Value & vbCrLf & "?"

            If MessageBox.Show(mensaje, Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                If objSqlDB.EERP_StrategicPlan_DeleteManagement(DG_Gerencia.CurrentRow.Cells(0).Value) = "OK" Then
                    GetManagement()
                Else
                    MessageBox.Show("Error en eliminación de usuario.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub


    Private Sub cmdAgregarObjetivo_Click(sender As Object, e As EventArgs) Handles cmdAgregarObjetivo.Click
        Using obj As New POA_InsertObjetivos
            obj._View = False
            If obj.ShowDialog() = DialogResult.OK Then
                GetStrategicObjectives(0)
            End If
        End Using
    End Sub

    Private Sub cmdModificarObjetivo_Click(sender As Object, e As EventArgs) Handles cmdModificarObjetivo.Click
        Try
            Using obj As New POA_InsertObjetivos
                'obj.GroupBox1.Text = "Configuración Modificar Usuarios"
                obj._isInsert = False
                obj._View = False
                obj._id_Objective = DG_Objetivo.CurrentRow.Cells("ID_StrategicObjective").Value
                obj._name = DG_Objetivo.CurrentRow.Cells("NameObjetivoEstrategico").Value
                obj._description = DG_Objetivo.CurrentRow.Cells("DescripcionObjective").Value
                If obj.ShowDialog() = DialogResult.OK Then
                    GetStrategicObjectives(0)
                End If

            End Using
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmdEliminarObjetivo_Click(sender As Object, e As EventArgs) Handles cmdEliminarObjetivo.Click
        Try
            Dim mensaje As String = "¿Está seguro(a) que quiere Desactivar el Objetivo Estratégico : " & vbCrLf &
              "Nombre : " & DG_Objetivo.CurrentRow.Cells(3).Value & vbCrLf & "?"

            If MessageBox.Show(mensaje, Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                If objSqlDB.EERP_StrategicPlan_DeleteObjective(DG_Objetivo.CurrentRow.Cells(0).Value) = "OK" Then
                    GetStrategicObjectives(0)
                Else
                    MessageBox.Show("Error en eliminación de Objetivo.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub


    Private Sub cmdAgregarEjesEstrategicos_Click(sender As Object, e As EventArgs) Handles cmdAgregarEjesEstrategicos.Click
        Dim codigoEje As String = ""
        Using objC As New POA_SQLServer
            codigoEje = objC.ERP_StrategicPlan_GetStrategicAxesCode(_Id_DptoPlani)
        End Using
        Try
            If codigoEje.ToString.Substring(0, 1).ToString = "0" Then
                MessageBox.Show("Debe ingresar el Objetivo Estratégico", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
        Catch ex As Exception

        End Try
        Using obj As New POA_InsertEjesEstrategicos
            obj._CodigoEje = codigoEje
            obj.ShowDialog()
            GetStrategicAxes(0)

        End Using
    End Sub

    Private Sub cmdModificarEjesEstrategicos_Click(sender As Object, e As EventArgs) Handles cmdModificarEjesEstrategicos.Click
        Try
            Using obj As New POA_InsertEjesEstrategicos
                'obj.GroupBox1.Text = "Configuración Modificar Usuarios"
                obj._isInsert = False
                obj._VerEje = True
                obj._id_strategicAxes = DG_EjesEstrategicos.CurrentRow.Cells("ID_StrategicAxes").Value
                obj._name = DG_EjesEstrategicos.CurrentRow.Cells("NameEjesEstrategicos").Value
                obj._description = DG_EjesEstrategicos.CurrentRow.Cells("DescripcionEjesEstrategicos").Value
                obj._CodigoEje = DG_EjesEstrategicos.CurrentRow.Cells("CodigoEje").Value
                obj._IdUnidadLider = DG_EjesEstrategicos.CurrentRow.Cells("Id_UnidadLider").Value

                If obj.ShowDialog() = DialogResult.OK Then
                    GetStrategicAxes(0)
                End If

            End Using
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmdEliminarEjesEstrategicos_Click(sender As Object, e As EventArgs) Handles cmdEliminarEjesEstrategicos.Click
        Try
            Dim mensaje As String = "¿Está seguro(a) que quiere eliminar el siguiente Ejes Estratégicos  : " & vbCrLf &
                "Nombre : " & DG_EjesEstrategicos.CurrentRow.Cells(1).Value & vbCrLf & "?"

            If MessageBox.Show(mensaje, Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                If objSqlDB.EERP_StrategicPlan_DeleteStrategicAxes(DG_EjesEstrategicos.CurrentRow.Cells(0).Value) = "OK" Then
                    GetStrategicAxes(0)
                Else
                    MessageBox.Show("Error en eliminación de Eje Estrategico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmdAgregarEstrategicas_Click(sender As Object, e As EventArgs) Handles cmdAgregarEstrategicas.Click
        Using obj As New POA_InsertAccionesEstrategicas

            If txtAnioQuinquenio.Text.ToString.Trim = "" Then
                MessageBox.Show("Debe ingresar el año inicio del Quinquenio.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtAnioQuinquenio.Focus()
                Exit Sub
            End If

            If IsNumeric(txtAnioQuinquenio.Text) Then
                If txtAnioQuinquenio.Text.Length < 4 Or txtAnioQuinquenio.Text.Length > 4 Then
                    MessageBox.Show("Favor ingrese un año correcto.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtAnioQuinquenio.Focus()
                    Exit Sub
                End If
            Else
                MessageBox.Show("Favor ingrese un año correcto.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtAnioQuinquenio.Focus()
                Exit Sub
            End If
            Dim Bandera As Boolean = False
            For i As Integer = Date.Now.Year - 25 To Date.Now.Year + 10
                If txtAnioQuinquenio.Text.ToString.Trim = i.ToString Then
                    Bandera = True
                    Exit For
                End If
            Next

            If Not Bandera Then
                MessageBox.Show("Favor ingrese un año correcto.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtAnioQuinquenio.Focus()
                Exit Sub
            End If


            obj._AnioInicial = txtAnioQuinquenio.Text
            If obj.ShowDialog() = DialogResult.OK Then
                GetStrategicActions(0)
            End If
        End Using
    End Sub

    Private Sub cmdModificarEstrategica_Click(sender As Object, e As EventArgs) Handles cmdModificarEstrategica.Click
        Try
            Using obj As New POA_InsertAccionesEstrategicas
                'obj.GroupBox1.Text = "Configuración Modificar Usuarios"
                obj._isInsert = False
                obj._id_StrategicActions = DG_AccionesEstrategica.CurrentRow.Cells("ID_StrategicActions").Value
                obj._name = DG_AccionesEstrategica.CurrentRow.Cells("NameAccionesEstrategicas").Value
                obj._description = DG_AccionesEstrategica.CurrentRow.Cells("DescriptionAccionesEstrategicas").Value
                obj._result = DG_AccionesEstrategica.CurrentRow.Cells("Resultado").Value
                obj._UnidadLider = DG_AccionesEstrategica.CurrentRow.Cells("UnidadLider").Value.ToString
                obj._TipoMedicion = 0
                obj._Anio1 = DG_AccionesEstrategica.CurrentRow.Cells("Anio1").Value.ToString
                obj._Anio2 = DG_AccionesEstrategica.CurrentRow.Cells("Anio2").Value.ToString
                obj._Anio3 = DG_AccionesEstrategica.CurrentRow.Cells("Anio3").Value.ToString
                obj._Anio4 = DG_AccionesEstrategica.CurrentRow.Cells("Anio4").Value.ToString
                obj._Anio5 = DG_AccionesEstrategica.CurrentRow.Cells("Anio5").Value.ToString
                obj._Quinquenio = DG_AccionesEstrategica.CurrentRow.Cells("QuinquenioAcc").Value.ToString
                obj._Fecha = DG_AccionesEstrategica.CurrentRow.Cells("FechaVencimientoAcciones").Value.ToString
                obj._AnioInicial = DG_AccionesEstrategica.CurrentRow.Cells("QuinquenioAcc").Value.ToString
                obj._AccionApoyo = DG_AccionesEstrategica.CurrentRow.Cells("AccionApoyo").Value.ToString
                obj._Indicador = "" 'DG_AccionesEstrategica.CurrentRow.Cells("UnidadLiderAc").Value.ToString
                If obj.ShowDialog() = DialogResult.OK Then
                    GetStrategicActions(0)
                End If

            End Using
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmdEliminarEstrategicas_Click(sender As Object, e As EventArgs) Handles cmdEliminarEstrategicas.Click
        Try
            Dim mensaje As String = "¿Está seguro(a) que quiere eliminar el siguiente Acciones Estratégicas   : " & vbCrLf &
               "Nombre : " & DG_AccionesEstrategica.CurrentRow.Cells(1).Value & vbCrLf & "?"

            If MessageBox.Show(mensaje, Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                If objSqlDB.EERP_StrategicPlan_DeleteStrategicActions(DG_AccionesEstrategica.CurrentRow.Cells(0).Value) = "OK" Then
                    GetStrategicActions(0)
                Else
                    MessageBox.Show("Error en eliminación la Accion estrategica.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmdAgregarResultado_Click(sender As Object, e As EventArgs) Handles cmdAgregarResultado.Click
        Using obj As New POA_InsertResult
            If obj.ShowDialog() = DialogResult.OK Then
                GetResult(0)
            End If
        End Using
    End Sub

    Private Sub cmdModificarResultado_Click(sender As Object, e As EventArgs) Handles cmdModificarResultado.Click
        Try
            Using obj As New POA_InsertResult
                obj._isInsert = False
                obj._id_result = DG_Result.CurrentRow.Cells("ID_Result").Value
                obj._name = DG_Result.CurrentRow.Cells("NameResultado").Value
                obj._description = DG_Result.CurrentRow.Cells("DescriptionResult").Value
                obj._ejesestrategicos = DG_Result.CurrentRow.Cells("EjeEstrategico").Value
                If obj.ShowDialog() = DialogResult.OK Then
                    GetResult(0)
                End If
            End Using
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmdEliminarResultado_Click(sender As Object, e As EventArgs) Handles cmdEliminarResultado.Click
        Try
            Dim mensaje As String = "¿Está seguro(a) que quiere eliminar el Resultado   : " & vbCrLf &
              "Nombre : " & DG_Result.CurrentRow.Cells(1).Value & vbCrLf & "?"
            If MessageBox.Show(mensaje, Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                If objSqlDB.EERP_StrategicPlan_DeleteResult(DG_Result.CurrentRow.Cells(0).Value) = "OK" Then
                    GetResult(0)
                Else
                    MessageBox.Show("Error en eliminación el Resultado.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub


    Private Sub cmdAgregarIndicador_Click(sender As Object, e As EventArgs) Handles cmdAgregarIndicador.Click
        Using obj As New POA_InsertIndicators
            If obj.ShowDialog() = DialogResult.OK Then
                GetIndicator(0)
            End If
        End Using
    End Sub

    Private Sub cmdModificarIndicador_Click(sender As Object, e As EventArgs) Handles cmdModificarIndicador.Click
        Try
            Using obj As New POA_InsertIndicators
                'obj.GroupBox1.Text = "Configuración Modificar Usuarios"
                obj._isInsert = False
                obj._id_Indicador = DG_Indicadores.CurrentRow.Cells("ID_indicator").Value
                obj._name = DG_Indicadores.CurrentRow.Cells("NameIndicador").Value
                obj._description = DG_Indicadores.CurrentRow.Cells("DescriptionIndicator").Value
                obj._Result = DG_Indicadores.CurrentRow.Cells("result").Value
                If obj.ShowDialog() = DialogResult.OK Then
                    GetIndicator(0)
                End If
            End Using
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmdEliminarIndicador_Click(sender As Object, e As EventArgs) Handles cmdEliminarIndicador.Click
        Try
            Dim mensaje As String = "¿Está seguro(a) que quiere eliminar el Indicador   : " & vbCrLf &
             "Nombre : " & DG_Indicadores.CurrentRow.Cells(1).Value & vbCrLf & "?"
            If MessageBox.Show(mensaje, Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                If objSqlDB.EERP_StrategicPlan_Deleteindicators(DG_Indicadores.CurrentRow.Cells(0).Value) = "OK" Then
                    GetIndicator(0)
                Else
                    MessageBox.Show("Error en eliminación el Resultado.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmdVerObjetivos_Click(sender As Object, e As EventArgs) Handles cmdVerObjetivos.Click
        Try
            Using obj As New POA_InsertObjetivos
                'obj.GroupBox1.Text = "Configuración Modificar Usuarios"
                obj._isInsert = False
                obj._View = True
                obj._id_Objective = DG_Objetivo.CurrentRow.Cells("ID_StrategicObjective").Value
                obj._name = DG_Objetivo.CurrentRow.Cells("NameObjetivoEstrategico").Value
                obj._description = DG_Objetivo.CurrentRow.Cells("DescripcionObjective").Value
                If obj.ShowDialog() = DialogResult.OK Then
                    GetStrategicObjectives(0)
                End If

            End Using
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cbObjetivosGerencia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbObjetivosGerencia.SelectedIndexChanged
        Try
            GetStrategicObjectives(cbObjetivosGerencia.SelectedValue)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cbGerenciaEstrategicos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbGerenciaEjes.SelectedIndexChanged
        Try
            GetStrategicAxes(cbGerenciaEjes.SelectedValue)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cbGerenciaResultados_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbGerenciaResultados.SelectedIndexChanged
        Try
            GetResult(cbGerenciaResultados.SelectedValue)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cbGerenciaIndicadores_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbGerenciaIndicadores.SelectedIndexChanged
        Try
            GetIndicator(cbGerenciaIndicadores.SelectedValue)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cbGerenciaEstrategica_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbGerenciaEstrategica.SelectedIndexChanged
        Try
            GetStrategicActions(cbGerenciaEstrategica.SelectedValue)
        Catch ex As Exception

        End Try
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles cmdAgregarPEI.Click
        Using obj As New MatrizProceso
            obj.ShowDialog()
            GetProcess()

        End Using
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles cmdModificarPEI.Click

        Try
            If Not IsNothing(DG_Process.SelectedRows) Then
                If Not DG_Process.CurrentRow.Cells("StatusPEI").Value.ToString.Contains("En Proceso") And Not DG_Process.CurrentRow.Cells("StatusPEI").Value.ToString.Contains("Rechazado Gerencia") Then
                    MessageBox.Show("No tiene Permisos para Modificar el PEI", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If

                Using obj As New MatrizProceso
                    'obj.GroupBox1.Text = "Configuración Modificar Usuarios"
                    obj._isInsert = False
                    obj._quinquenio = DG_Process.CurrentRow.Cells("Quinquenio").Value.ToString
                    obj._nameobjetivo = DG_Process.CurrentRow.Cells("objetivo").Value.ToString
                    obj._idobjetivo = DG_Process.CurrentRow.Cells("ID_Objective_FK").Value.ToString
                    obj.ShowDialog()
                    GetProcess()

                End Using
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DeleteUsers_Click(sender As Object, e As EventArgs)
        Try
            Dim mensaje As String = "¿Está seguro(a) que quiere eliminar el Proceso: " & vbCrLf &
                "Nombre : " & DG_Process.CurrentRow.Cells(1).Value & vbCrLf & "?"

            If MessageBox.Show(mensaje, Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                If objDB.EERP_StrategicPlan_DeleteProcess(DG_Process.CurrentRow.Cells(0).Value) = "OK" Then
                    GetProcess()
                Else
                    MessageBox.Show("Error en eliminación el Proceso.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub GetProcess()
        Using objDatos As New POA_SQLServer
            Try
                dtProcess = objDatos.ERP_StrategicPlan_GetProcess()
                If dtProcess IsNot Nothing Then
                    DG_Process.AutoGenerateColumns = False
                    DG_Process.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
                    DG_Process.Font = New Font("Segoe UI", 11)
                    DG_Process.RowHeadersVisible = False
                    DG_Process.Columns(0).Width = 75
                    DG_Process.Columns(1).Width = 450
                    DG_Process.Columns(2).Width = 120
                    DG_Process.Columns(3).Width = 225
                    DG_Process.Columns(3).DefaultCellStyle.Format = "yyyy/MM/dd HH:mm:ss"
                    DG_Process.Columns(4).Width = 125
                    DG_Process.Columns(5).Width = 125

                    DG_Process.ReadOnly = True
                    DG_Process.SelectionMode = DataGridViewSelectionMode.FullRowSelect
                    DG_Process.MultiSelect = False

                    DG_Process.AllowUserToResizeColumns = False
                    DG_Process.AllowUserToAddRows = False
                    DG_Process.AllowUserToDeleteRows = False
                    DG_Process.DataSource = dtProcess
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

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnReportePEI.Click
        Try
            If Not IsNothing(DG_Process.SelectedRows) Then
                Dim _idobjetivo As Integer = DG_Process.CurrentRow.Cells("ID_Objective_FK").Value.ToString
                Dim objetivo As String = DG_Process.CurrentRow.Cells("objetivo").Value.ToString
                Dim dptonombre As String = ""
                Dim IdDptoSend As Integer = 0

                If _UsuarioPlanificacion Then
                    IdDptoSend = cbGerenciaPEI.SelectedValue
                    Try
                        If cbGerenciaPEI.SelectedItem(1).ToString.Trim = "Seleccione" Then

                            dptonombre = _NombreDepartamento
                        Else
                            dptonombre = cbGerenciaPEI.SelectedItem(1)
                        End If
                    Catch ex As Exception

                    End Try
                Else
                    If _UsuarioFortalecimiento Then
                        IdDptoSend = 0
                        Try
                            If cbGerenciaPEI.SelectedItem(1).ToString.Trim = "Seleccione" Then

                                dptonombre = _NombreDepartamento
                            Else
                                dptonombre = cbGerenciaPEI.SelectedItem(1)
                            End If
                        Catch ex As Exception

                        End Try
                    Else
                        IdDptoSend = _Id_DepartmentGlobal
                        dptonombre = _NombreDepartamento
                    End If


                End If


                'Dim Ds As New ReportePEI
                'Dim dt As New ReportePEITableAdapters.ERP_StrategicPlan_ReportePeiTableAdapter
                'Dim CadenaConexion As String = dt.Connection.ConnectionString.ToString.Replace("[user]", _UserSQL).Replace("[password]", _Password)
                Dim dt1 As DataTable
                'dt.Connection.ConnectionString = CadenaConexion
                'dt.Fill(Ds.ERP_StrategicPlan_ReportePei, _idobjetivo, IdDptoSend)
                'dt1 = Ds.Tables(0)

                'Dim dt2 As New ReportePEITableAdapters.ERP_StrategicPlan_ReportePeiAccionesTableAdapter
                Dim dt12 As DataTable
                'dt2.Connection.ConnectionString = CadenaConexion
                'dt2.Fill(Ds.ERP_StrategicPlan_ReportePeiAcciones, _idobjetivo, IdDptoSend)
                'dt12 = Ds.Tables(0)


                Using objPartidaContable As New Planificacion_ReportViewer(dt1, "ReportePei", dt12, "ReportePeiAcciones", "epd_SatelliteERP.ReportePEI.rdlc", _idobjetivo, objetivo, _NombreDepartamento, IdDptoSend)
                    objPartidaContable.ShowDialog()
                End Using

            End If

        Catch ex As Exception
            Using objLog As New ProcessGeneral
                objLog.AlmacenarLog(5, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
            End Using
        End Try
    End Sub

    Private Sub cmdVerEjesEstrategicos_Click(sender As Object, e As EventArgs) Handles cmdVerEjesEstrategicos.Click
        Try
            Using obj As New POA_InsertEjesEstrategicos
                'obj.GroupBox1.Text = "Configuración Modificar Usuarios"
                obj._VerEje = False
                obj._isInsert = False
                obj._id_strategicAxes = DG_EjesEstrategicos.CurrentRow.Cells("ID_StrategicAxes").Value
                obj._name = DG_EjesEstrategicos.CurrentRow.Cells("NameEjesEstrategicos").Value
                obj._description = DG_EjesEstrategicos.CurrentRow.Cells("DescripcionEjesEstrategicos").Value
                obj._CodigoEje = DG_EjesEstrategicos.CurrentRow.Cells("CodigoEje").Value
                obj._IdUnidadLider = DG_EjesEstrategicos.CurrentRow.Cells("Id_UnidadLider").Value

                If obj.ShowDialog() = DialogResult.OK Then
                    GetStrategicAxes(0)
                End If

            End Using
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmdVerResultado_Click(sender As Object, e As EventArgs) Handles cmdVerResultado.Click
        Try
            Using obj As New POA_InsertResult
                'obj.GroupBox1.Text = "Configuración Modificar Usuarios"
                obj._isInsert = False
                obj._VerResultado = False
                obj._id_result = DG_Result.CurrentRow.Cells("ID_Result").Value
                obj._name = DG_Result.CurrentRow.Cells("NameResultado").Value
                obj._description = DG_Result.CurrentRow.Cells("DescriptionResult").Value
                obj._ejesestrategicos = DG_Result.CurrentRow.Cells("EjeEstrategico").Value
                If obj.ShowDialog() = DialogResult.OK Then
                    GetResult(0)
                End If
            End Using
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmdVerIndicador_Click(sender As Object, e As EventArgs) Handles cmdVerIndicador.Click
        Try
            Using obj As New POA_InsertIndicators
                'obj.GroupBox1.Text = "Configuración Modificar Usuarios"
                obj._isInsert = False
                obj._VerIndicador = False
                obj._id_Indicador = DG_Indicadores.CurrentRow.Cells("ID_indicator").Value
                obj._name = DG_Indicadores.CurrentRow.Cells("NameIndicador").Value
                obj._description = DG_Indicadores.CurrentRow.Cells("DescriptionIndicator").Value
                obj._Result = DG_Indicadores.CurrentRow.Cells("result").Value
                If obj.ShowDialog() = DialogResult.OK Then
                    GetIndicator(0)
                End If
            End Using
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmdVerAccionesEstrategicas_Click(sender As Object, e As EventArgs) Handles cmdVerAccionesEstrategicas.Click
        Try
            Using obj As New POA_InsertAccionesEstrategicas
                'obj.GroupBox1.Text = "Configuración Modificar Usuarios"
                obj._isInsert = False
                obj._VerAccion = False
                obj._id_StrategicActions = DG_AccionesEstrategica.CurrentRow.Cells("ID_StrategicActions").Value
                obj._name = DG_AccionesEstrategica.CurrentRow.Cells("NameAccionesEstrategicas").Value
                obj._description = DG_AccionesEstrategica.CurrentRow.Cells("DescriptionAccionesEstrategicas").Value
                obj._result = DG_AccionesEstrategica.CurrentRow.Cells("Resultado").Value
                obj._UnidadLider = DG_AccionesEstrategica.CurrentRow.Cells("UnidadLider").Value.ToString
                obj._Anio1 = DG_AccionesEstrategica.CurrentRow.Cells("Anio1").Value.ToString
                obj._Anio2 = DG_AccionesEstrategica.CurrentRow.Cells("Anio2").Value.ToString
                obj._Anio3 = DG_AccionesEstrategica.CurrentRow.Cells("Anio3").Value.ToString
                obj._Anio4 = DG_AccionesEstrategica.CurrentRow.Cells("Anio4").Value.ToString
                obj._Anio5 = DG_AccionesEstrategica.CurrentRow.Cells("Anio5").Value.ToString
                obj._TipoMedicion = 0
                obj._Fecha = DG_AccionesEstrategica.CurrentRow.Cells("FechaVencimientoAcciones").Value.ToString
                obj._Indicador = "" 'DG_AccionesEstrategica.CurrentRow.Cells("UnidadLiderAc").Value.ToString
                If obj.ShowDialog() = DialogResult.OK Then
                    GetStrategicActions(0)
                End If

            End Using
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnReordenar_Click(sender As Object, e As EventArgs) Handles btnReordenar.Click
        Using objDatos As New POA_SQLServer
            Try
                objDatos.ERP_SP_CrearCodigoAcciones()
                GetStrategicActions(0)
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

    Private Sub btnEnviarAprobacion_Click(sender As Object, e As EventArgs) Handles btnEnviarAprobacion.Click
        Try
            If DG_Process.CurrentRow.Cells("StatusPEI").Value.ToString <> "En Proceso" And DG_Process.CurrentRow.Cells("StatusPEI").Value.ToString <> "Rechazado Gerencia" Then
                MessageBox.Show("No tiene Permisos para Modificar el PEI", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            Using OBJ As New AprobarRechazarPei
                OBJ.Anio = DG_Process.CurrentRow.Cells("Quinquenio").Value.ToString
                OBJ.IdPEI = DG_Process.CurrentRow.Cells("ID_Process").Value.ToString
                OBJ.Gerencia = _NombreDepartamento
                OBJ.Id_DepartamentoPOA = _Id_DepartmentGlobal
                OBJ.TipoAutorizacion = False
                OBJ.Autorizacion = True
                OBJ.ShowDialog()
                GetProcess()
            End Using
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnAprRecGerencia_Click(sender As Object, e As EventArgs) Handles btnAprRecGerencia.Click
        Try

            If Not DG_Process.CurrentRow.Cells("StatusPEI").Value.ToString.Contains("Rechazado Planificación") And Not DG_Process.CurrentRow.Cells("StatusPEI").Value.ToString.Contains("Autorización Gerencia") Then
                MessageBox.Show("No tiene Permisos para Modificar el PEI", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            Using OBJ As New AprobarRechazarPei
                OBJ.Anio = DG_Process.CurrentRow.Cells("Quinquenio").Value.ToString
                OBJ.IdPEI = DG_Process.CurrentRow.Cells("ID_Process").Value.ToString
                OBJ.Gerencia = _NombreDepartamento
                OBJ.Id_DepartamentoPOA = _Id_DepartmentGlobal
                OBJ.TipoAutorizacion = False

                OBJ.ShowDialog()
                GetProcess()
            End Using
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnAproRechPlanificacion_Click(sender As Object, e As EventArgs) Handles btnAproRechPlanificacion.Click
        Try

            If Not DG_Process.CurrentRow.Cells("StatusPEI").Value.ToString.Contains("Aprobado Gerencia") Then
                MessageBox.Show("No tiene Permisos para Modificar el PEI", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            Using OBJ As New AprobarRechazarPei
                OBJ.Anio = DG_Process.CurrentRow.Cells("Quinquenio").Value.ToString
                OBJ.IdPEI = DG_Process.CurrentRow.Cells("ID_Process").Value.ToString
                OBJ.Gerencia = _NombreDepartamento
                OBJ.Id_DepartamentoPOA = _Id_DepartmentGlobal
                OBJ.TipoAutorizacion = True

                OBJ.ShowDialog()
                GetProcess()
            End Using
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnHistorialObservaciones_Click(sender As Object, e As EventArgs) Handles btnHistorialObservaciones.Click
        Try
            If Not IsNothing(DG_Process.CurrentRow) Then
                Using obj As New RechazosPEI
                    obj.IdEncabezado = DG_Process.CurrentRow.Cells("Id_Process").Value.ToString
                    obj.ShowDialog()
                End Using
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnSubirDocPEI_click(sender As Object, e As EventArgs) Handles btnSubirDocPEI.Click
        Try
            If Not IsNothing(DG_Process.CurrentRow) Then
                Using obj As New SubirDocumentosRespaldo
                    obj._Id_Encabezado = DG_Process.CurrentRow.Cells("Id_Process").Value.ToString
                    obj.Anio = 0
                    obj._PEI = True
                    obj._POA = False
                    obj.ShowDialog()
                End Using
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cbGerenciaPEI_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbGerenciaPEI.SelectedIndexChanged
        Try
            GetProcess()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtAnioQuinquenio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAnioQuinquenio.KeyPress
        If Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub DG_AccionesEstrategica_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DG_AccionesEstrategica.CellContentClick

    End Sub
End Class
