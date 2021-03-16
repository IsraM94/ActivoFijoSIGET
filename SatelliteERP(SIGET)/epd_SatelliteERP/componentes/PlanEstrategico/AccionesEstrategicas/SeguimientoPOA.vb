Public Class SeguimientoPOA

#Region "Properties"
    Private objsql As New POA_SQLServer
    Private dtObjetivos As New DataTable
    Private dtEjes As New DataTable
    Property _id_Result As Long
    Property _Update As Boolean = False
    Property Anio As Integer = 0
    Property Fecha As String = ""
    Property Id_Department As Integer = 0
    Property Id_EncabezadoPOA As Integer = 0
    Property TipoUsuario As String = ""
    Property ResponsableEje As String = ""
    Property ResponsableAut As String = ""
    Property Objetivo As String = ""

    Property EstatusSeguimiento As String = ""

    Property VistaSeguimiento As Boolean = False
    Enum funcion
        Actualizar
        Agregar
    End Enum
    Property OpcionSeleccionada As funcion
#End Region

    Private Sub Config_InsertUserAccesos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtAnio.Text = Date.Now.Year + 1
        lblGerencia.Text = _NombreDepartamento
        lblFechaP.Text = Date.Now.Date.ToString("dd-MM-yyyy").ToString
        Try
            Dim dt As New DataTable
            Dim dt3 As New DataTable
            Using objDatos As New POA_SQLServer
                txtObjetivo.Text = objDatos.ERP_StrategicPlan_GetStrategicObjectiveDepartment
                dt = objDatos.ERP_StrategicPlan_GetResponsibleExecution(0)
                dt3 = objDatos.ERP_StrategicPlan_GetResponsibleExecution(0)
            End Using
            cbResponsable.DataSource = dt
            cbResponsable.DisplayMember = "Name"
            cbResponsable.ValueMember = "Id_responsibleExecution"

            cbAutorizacion.DataSource = dt3
            cbAutorizacion.DisplayMember = "Name"
            cbAutorizacion.ValueMember = "Id_responsibleExecution"
        Catch ex As Exception

        End Try

        Try
            Dim dataInfo As DataTable = objsql.ERP_StrategicPlan_getMeses

            Dim dataSelect As DataTable = dataInfo.Clone
            dataSelect.Rows.Add(0, "Seleccione")


            For Each Info As DataRow In dataInfo.Rows
                dataSelect.ImportRow(Info)
            Next

            comboMeses.DataSource = dataSelect
            comboMeses.DisplayMember = "Mes"
            comboMeses.ValueMember = "IdMEs"
        Catch ex As Exception

        End Try

        If Not _Update = True Then
            Anio = txtAnio.Text
        Else
            txtAnio.Text = Anio.ToString
            lblFechaP.Text = Fecha.ToString
            Try
                cbResponsable.SelectedValue = ResponsableEje.ToString
            Catch ex As Exception

            End Try
            Try
                cbAutorizacion.SelectedValue = ResponsableAut.ToString
            Catch ex As Exception

            End Try
            txtObjetivo.Text = Objetivo.ToString
        End If

        If Id_Department > 0 And Id_EncabezadoPOA > 0 Then
            _Id_DptoPlani = Id_Department
            GetAccionesEstrategicas(Id_Department, Id_EncabezadoPOA)
        Else
            If _Id_DptoPlani = 0 And Id_EncabezadoPOA = 0 Then
                Anio = 0
            End If
            If _Id_DptoPlani > 0 Then
                GetAccionesEstrategicas(_Id_DptoPlani, Id_EncabezadoPOA)
            Else
                GetAccionesEstrategicas(_Id_DepartmentGlobal, Id_EncabezadoPOA)
            End If
        End If
        cbTipo.SelectedIndex = 0


        DGAcciones.Columns("IdAccionPOA").DisplayIndex = 1
        DGAcciones.Columns("CodigoAccion").DisplayIndex = 2
        DGAcciones.Columns("Accion").DisplayIndex = 3
        DGAcciones.Columns("Lider").DisplayIndex = 4
        DGAcciones.Columns("TipoMedicionPOA").DisplayIndex = 5
        DGAcciones.Columns("IndicadorA").DisplayIndex = 6
        DGAcciones.Columns("MetaPOA").DisplayIndex = 7
        DGAcciones.Columns("EneroPOA").DisplayIndex = 8
        DGAcciones.Columns("EneroE").DisplayIndex = 9
        DGAcciones.Columns("FebreroPOA").DisplayIndex = 10
        DGAcciones.Columns("FebreroE").DisplayIndex = 11
        DGAcciones.Columns("MarzoPOA").DisplayIndex = 12
        DGAcciones.Columns("MarzoE").DisplayIndex = 13
        DGAcciones.Columns("AbrilPOA").DisplayIndex = 14
        DGAcciones.Columns("AbrilE").DisplayIndex = 15
        DGAcciones.Columns("MayoPOA").DisplayIndex = 16
        DGAcciones.Columns("MayoE").DisplayIndex = 17
        DGAcciones.Columns("JunioPOA").DisplayIndex = 18
        DGAcciones.Columns("JunioE").DisplayIndex = 19
        DGAcciones.Columns("JulioPOA").DisplayIndex = 20
        DGAcciones.Columns("JulioE").DisplayIndex = 21
        DGAcciones.Columns("AgostoPOA").DisplayIndex = 22
        DGAcciones.Columns("AgostoE").DisplayIndex = 23
        DGAcciones.Columns("SeptiembrePOA").DisplayIndex = 24
        DGAcciones.Columns("SeptiembreE").DisplayIndex = 25
        DGAcciones.Columns("OctubrePOA").DisplayIndex = 26
        DGAcciones.Columns("OctubreE").DisplayIndex = 27
        DGAcciones.Columns("NoviembrePOA").DisplayIndex = 28
        DGAcciones.Columns("NoviembreE").DisplayIndex = 29
        DGAcciones.Columns("DiciembrePOA").DisplayIndex = 30
        DGAcciones.Columns("DiciembreE").DisplayIndex = 31
        DGAcciones.Columns("RecursosPOA").DisplayIndex = 32
        DGAcciones.Columns("IdTipoMedicion").DisplayIndex = 33

        If TipoUsuario = "Estandar" Then
            btnProcesos.Text = "Enviar a Aprobación"
        ElseIf TipoUsuario = "Gerente" Then
            btnProcesos.Text = "Aprobar o Rechazar"
        ElseIf TipoUsuario = "Planificacion" Then
            btnProcesos.Text = "Aprobar o Rechazar"
        End If

        If VistaSeguimiento Then
            ' btnProcesos.Visible = False
        End If
    End Sub
    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub GetAccionesEstrategicas(ByVal Id_Departamento As Integer, ByVal Id_EncabezadoPOA As Integer)
        Using objDatos As New POA_SQLServer
            Try
                Dim DtAcciones = objDatos.ERP_StrategicPlan_GetStrategicActionsbyDeparmentEjecucion(Id_Departamento, Anio, Id_EncabezadoPOA)
                If DtAcciones IsNot Nothing Then
                    DGAcciones.DataSource = DtAcciones
                    DGAcciones.AutoGenerateColumns = False
                    DGAcciones.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
                    DGAcciones.Font = New Font("Segoe UI", 10)
                    DGAcciones.RowHeadersVisible = False

                    DGAcciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect
                    DGAcciones.MultiSelect = False

                    DGAcciones.AllowUserToResizeColumns = False
                    DGAcciones.AllowUserToAddRows = False
                    DGAcciones.AllowUserToDeleteRows = False

                    Dim Dtp As New DataTable
                    Dtp = objDatos.ERP_StrategicPlan_MeasureType()

                    TipoMedicionPOA.DataSource = Dtp
                    TipoMedicionPOA.DisplayMember = "NameMeasure"
                    TipoMedicionPOA.ValueMember = "Id_MeasureType"

                    If _Update Then
                        For i As Integer = 0 To DGAcciones.Rows.Count - 1
                            Try
                                If DGAcciones.Rows(i).Cells("IdTipoMedicion").Value > 0 Then
                                    DGAcciones.Rows(i).Cells("TipoMedicionPOA").Value = DGAcciones.Rows(i).Cells("IdTipoMedicion").Value
                                End If
                            Catch ex As Exception

                            End Try

                            Try
                                If DGAcciones.Rows(i).Cells(comboMeses.SelectedItem(1).ToString.Trim & "POA").Value <= 0 Then
                                    DGAcciones.Rows(i).Visible = False
                                End If
                            Catch ex As Exception

                            End Try
                        Next
                    End If

                    For i As Integer = DGAcciones.Rows.Count - 1 To 0 Step -1
                        Try
                            If DGAcciones.Rows(i).Cells(comboMeses.SelectedItem(1).ToString.Trim & "POA").Value <= 0 Then
                                DGAcciones.Rows(i).Visible = False
                            End If
                        Catch ex As Exception

                        End Try
                    Next

                    For i As Integer = DGAcciones.Rows.Count - 1 To 0 Step -1
                        Try
                            If DGAcciones.Rows(i).Cells(comboMeses.SelectedItem(1).ToString.Trim & "POA").Value <= 0 Then
                                DGAcciones.Rows(i).Visible = False
                            End If
                        Catch ex As Exception

                        End Try
                    Next

                    DGAcciones.Columns("IdTipoMedicion").Visible = False
                    DGAcciones.Columns("TipoMedicion").Visible = False

                End If
            Catch ex As ArgumentException
                Using objLog As New ProcessGeneral
                    objLog.AlmacenarLog(4, ex.Message, System.Reflection.MethodBase.GetCurrentMethod().Name)
                End Using
            Catch ex As Exception
                Using objLog As New ProcessGeneral
                    objLog.AlmacenarLog(4, ex.Message, System.Reflection.MethodBase.GetCurrentMethod().Name)
                End Using
            End Try
        End Using
    End Sub

    Private Sub GetAccionesdeApoyo()
        Using objDatos As New POA_SQLServer
            Try
                Dim DtAcciones As New DataTable
                DtAcciones = objDatos.ERP_StrategicPlan_GetOperationalActionPOA(txtAnio.Text)
                If DtAcciones IsNot Nothing Then
                    DGAcciones.DataSource = DtAcciones
                    DGAcciones.AutoGenerateColumns = False
                    DGAcciones.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
                    DGAcciones.Font = New Font("Segoe UI", 11)
                    DGAcciones.RowHeadersVisible = False

                    DGAcciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect
                    DGAcciones.MultiSelect = False

                    DGAcciones.AllowUserToResizeColumns = False
                    DGAcciones.AllowUserToAddRows = False
                    DGAcciones.AllowUserToDeleteRows = False

                    If _Update Then
                        For i As Integer = 0 To DGAcciones.Rows.Count - 1
                            If DGAcciones.Rows(i).Cells("TipoMedicion").Value > 0 Then
                                DGAcciones.Rows(i).Cells("TipoMedicionPOA").Value = DGAcciones.Rows(i).Cells("TipoMedicion").Value
                            End If
                        Next
                    End If

                    For i As Integer = 0 To DGAcciones.Rows.Count - 1
                        If DGAcciones.Rows(i).Cells("MetaPOA").Value <= 0 Then
                            DGAcciones.Rows(i).Visible = False
                        End If

                    Next

                    Try
                        For i As Integer = 0 To DGAcciones.Columns.Count - 1
                            DGAcciones.Columns(i).Visible = False
                        Next
                        If comboMeses.SelectedItem(1).ToString.Trim <> "Seleccione" Then
                            For i As Integer = 0 To DGAcciones.Columns.Count - 1
                                If DGAcciones.Columns(i).Name.ToString.ToUpper = (comboMeses.SelectedItem(1).ToString.Trim & "POA").ToString.ToUpper Or DGAcciones.Columns(i).Name.ToString.ToUpper = (comboMeses.SelectedItem(1).ToString.Trim & "E").ToString.ToUpper Then
                                    DGAcciones.Columns(i).Visible = True
                                End If
                            Next
                        Else
                            For i As Integer = 3 To DGAcciones.Columns.Count - 1
                                DGAcciones.Columns(i).Visible = True
                            Next
                        End If


                        For i As Integer = 0 To DGAcciones.Rows.Count - 1
                            DGAcciones.Rows(i).Visible = True
                        Next

                        For i As Integer = 0 To DGAcciones.Rows.Count - 1
                            If Convert.ToInt32(DGAcciones.Rows(i).Cells(comboMeses.SelectedItem(1).ToString.Trim & "POA").Value.ToString.ToUpper) <= 0 Then
                                DGAcciones.Rows(i).Visible = False
                            End If
                        Next

                    Catch ex As Exception

                    End Try


                    DGAcciones.Columns("IdAccionPOA").Visible = False
                    DGAcciones.Columns("TipoMedicionPOA").Visible = False

                    DGAcciones.Columns("Accion").Visible = True
                    DGAcciones.Columns("Lider").Visible = True
                    DGAcciones.Columns("IndicadorA").Visible = True
                    DGAcciones.Columns("CodigoAccion").Visible = True

                End If
            Catch ex As ArgumentException
                Using objLog As New ProcessGeneral
                    objLog.AlmacenarLog(4, ex.Message, System.Reflection.MethodBase.GetCurrentMethod().Name)
                End Using
            Catch ex As Exception
                Using objLog As New ProcessGeneral
                    objLog.AlmacenarLog(4, ex.Message, System.Reflection.MethodBase.GetCurrentMethod().Name)
                End Using
            End Try

        End Using
    End Sub

    Private Sub txtEnero_TextChanged(sender As Object, e As EventArgs)
        If Not IsNumeric(sender.Text) Then
            sender.Text = ""
        End If
    End Sub

    Private Sub txtFebrero_TextChanged(sender As Object, e As EventArgs)
        If Not IsNumeric(sender.Text) Then
            sender.Text = ""
        End If
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbTipo.SelectedIndexChanged
        Try
            If cbTipo.Text = "Acciones de Apoyo" Then
                GetAccionesdeApoyo()
                GBData.Text = "Acciones de Apoyo"
            Else
                GetAccionesEstrategicas(_Id_DptoPlani, Id_EncabezadoPOA)
                GBData.Text = "Acciones Estrategicas"
            End If

            comboMeses_SelectedIndexChanged(Nothing, Nothing)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub AgregarEjecucionToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Try
            If Not IsNothing(DGAcciones.SelectedRows) Then
                Using obj As New AgregarAvanceEjecucion
                    obj.Accion = DGAcciones.CurrentRow.Cells("Accion").Value.ToString
                    obj.IdAccionPOA = DGAcciones.CurrentRow.Cells("IdAccionPOA").Value.ToString
                    obj.Anio = txtAnio.Text

                    obj.ShowDialog()
                    GetAccionesEstrategicas(_Id_DptoPlani, Id_EncabezadoPOA)
                End Using
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub comboMeses_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboMeses.SelectedIndexChanged
        Try
            For i As Integer = 0 To DGAcciones.Columns.Count - 1
                DGAcciones.Columns(i).Visible = False
            Next
            If comboMeses.SelectedItem(1).ToString.Trim <> "Seleccione" Then
                For i As Integer = 0 To DGAcciones.Columns.Count - 1
                    If DGAcciones.Columns(i).Name.ToString.ToUpper = (comboMeses.SelectedItem(1).ToString.Trim & "POA").ToString.ToUpper Or DGAcciones.Columns(i).Name.ToString.ToUpper = (comboMeses.SelectedItem(1).ToString.Trim & "E").ToString.ToUpper Then
                        DGAcciones.Columns(i).Visible = True
                    End If
                Next
            Else
                For i As Integer = 3 To DGAcciones.Columns.Count - 1
                    DGAcciones.Columns(i).Visible = True
                Next
            End If


            For i As Integer = 0 To DGAcciones.Rows.Count - 1
                DGAcciones.Rows(i).Visible = True
            Next

            For i As Integer = 0 To DGAcciones.Rows.Count - 1
                If Convert.ToInt32(DGAcciones.Rows(i).Cells(comboMeses.SelectedItem(1).ToString.Trim & "POA").Value.ToString.ToUpper) <= 0 Then
                    DGAcciones.Rows(i).Visible = False
                End If
            Next

        Catch ex As Exception

        End Try


        DGAcciones.Columns("IdAccionPOA").Visible = False
        DGAcciones.Columns("TipoMedicionPOA").Visible = False

        DGAcciones.Columns("Accion").Visible = True
        DGAcciones.Columns("Lider").Visible = True
        DGAcciones.Columns("IndicadorA").Visible = True
        DGAcciones.Columns("CodigoAccion").Visible = True
        If comboMeses.SelectedItem(0).ToString <> "0" Then
            Using obj As New POA_SQLServer
                Dim TipoAccion As Integer = 0
                Try
                    If cbTipo.SelectedItem.ToString = "Acciones Estrategicas" Then
                        TipoAccion = 1
                    ElseIf cbTipo.SelectedItem = "Acciones de Apoyo" Then
                        TipoAccion = 2
                    End If
                Catch ex As Exception

                End Try
                EstatusSeguimiento = obj.ERP_StrategicPlan_GetPOASeguimientoStatus(Convert.ToInt32(comboMeses.SelectedItem(0).ToString), Id_EncabezadoPOA, TipoAccion)
                EstatusSeguimiento = EstatusSeguimiento.ToString.Split("-")(0).ToString.Trim
                lblStatusMes.Text = EstatusSeguimiento
            End Using
        End If
    End Sub

    Private Sub DGAcciones_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGAcciones.CellDoubleClick
        Try

            If VistaSeguimiento Then
                MessageBox.Show("No tiene permisos para reportar la ejecución.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            If TipoUsuario <> "Estandar" Then
                MessageBox.Show("No tiene permisos para reportar la ejecución.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            Using obj As New POA_SQLServer
                Try
                    Dim TipoAccion As Integer = 0
                    Try
                        If cbTipo.SelectedItem.ToString = "Acciones Estrategicas" Then
                            TipoAccion = 1
                        ElseIf cbTipo.SelectedItem = "Acciones de Apoyo" Then
                            TipoAccion = 2
                        End If
                    Catch ex As Exception

                    End Try
                    EstatusSeguimiento = obj.ERP_StrategicPlan_GetPOASeguimientoStatus(Convert.ToInt32(comboMeses.SelectedItem(0).ToString), Id_EncabezadoPOA, TipoAccion)
                    EstatusSeguimiento = EstatusSeguimiento.ToString.Split("-")(0).ToString.Trim
                    If EstatusSeguimiento <> "En Proceso" Then
                        MessageBox.Show("No tiene permisos para reportar la ejecución.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Exit Sub
                    End If
                Catch ex As Exception

                End Try
            End Using

            If Not IsNothing(DGAcciones.SelectedRows) Then
                Try
                    If comboMeses.SelectedValue < 1 Then
                        MessageBox.Show("Debe de seleccionar un Mes para reportar la Ejecución", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Exit Sub
                    End If
                Catch ex As Exception

                End Try
                Using obj As New AgregarAvanceEjecucion
                    obj.Accion = DGAcciones.CurrentRow.Cells("Accion").Value.ToString
                    obj.IdAccionPOA = DGAcciones.CurrentRow.Cells("IdAccionPOA").Value.ToString
                    obj.Mes = comboMeses.SelectedValue
                    obj.Anio = txtAnio.Text
                    obj.Documentos = False
                    Try
                        If cbTipo.SelectedItem.ToString = "Acciones Estrategicas" Then
                            obj._TipoAccion = 1
                        ElseIf cbTipo.SelectedItem = "Acciones de Apoyo" Then
                            obj._TipoAccion = 2
                        End If
                    Catch ex As Exception

                    End Try

                    obj.MesString = comboMeses.SelectedItem(1).ToString
                    obj.ShowDialog()
                    If cbTipo.SelectedItem.ToString = "Acciones Estrategicas" Then
                        GetAccionesEstrategicas(_Id_DptoPlani, Id_EncabezadoPOA)
                    ElseIf cbTipo.SelectedItem = "Acciones de Apoyo" Then
                        GetAccionesdeApoyo()
                    End If
                End Using
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If Not IsNothing(DGAcciones.CurrentRow) Then
                Try
                    If comboMeses.SelectedValue < 1 Then
                        MessageBox.Show("Debe de seleccionar un Mes para reportar la Ejecución", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Exit Sub
                    End If
                Catch ex As Exception

                End Try
                Using obj As New AgregarAvanceEjecucion
                    obj.Accion = DGAcciones.CurrentRow.Cells(3).Value.ToString
                    obj.IdAccionPOA = DGAcciones.CurrentRow.Cells(1).Value.ToString
                    obj.Mes = comboMeses.SelectedValue
                    obj.Anio = txtAnio.Text
                    obj.Documentos = True
                    obj.MesString = comboMeses.SelectedItem(1).ToString
                    obj.ShowDialog()
                End Using
            Else
                MessageBox.Show("Debe de seleccionar una Acción", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtAnio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAnio.KeyPress
        If Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub btnProcesos_Click(sender As Object, e As EventArgs) Handles btnProcesos.Click

        Try
            If comboMeses.SelectedValue < 1 Then
                MessageBox.Show("Debe de seleccionar un Mes para procesar el Seguimiento", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
        Catch ex As Exception

        End Try

        Dim Id_Seguimiento As Integer = 0
        Using obj As New POA_SQLServer
            Try
                Dim TipoAccion As Integer = 0
                Try
                    If cbTipo.SelectedItem.ToString = "Acciones Estrategicas" Then
                        TipoAccion = 1
                    ElseIf cbTipo.SelectedItem = "Acciones de Apoyo" Then
                        TipoAccion = 2
                    End If
                Catch ex As Exception

                End Try
                EstatusSeguimiento = obj.ERP_StrategicPlan_GetPOASeguimientoStatus(Convert.ToInt32(comboMeses.SelectedItem(0).ToString), Id_EncabezadoPOA, TipoAccion)
                Id_Seguimiento = EstatusSeguimiento.ToString.Split("-")(1).ToString.Trim
                EstatusSeguimiento = EstatusSeguimiento.ToString.Split("-")(0).ToString.Trim

            Catch ex As Exception

            End Try
        End Using
        If TipoUsuario = "Estandar" Then
            If EstatusSeguimiento <> "En Proceso" And EstatusSeguimiento <> "Rechazado Gerencia" Then
                MessageBox.Show("No tiene Permisos para Modificar el Seguimiento POA - " & EstatusSeguimiento, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            Using OBJ As New AprobarRechazarPoaSeguimiento
                OBJ.IdEncabezadoPOA = Id_EncabezadoPOA
                OBJ.Gerencia = _NombreDepartamento
                OBJ.Id_Mes = comboMeses.SelectedItem(0).ToString()
                OBJ.TipoAutorizacion = False
                OBJ.Id_Seguimiento = Id_Seguimiento
                OBJ.Autorizacion = True
                OBJ.Mes = comboMeses.SelectedItem(1).ToString()
                OBJ.ShowDialog()
            End Using
        ElseIf TipoUsuario = "Gerente" Then

            If Not EstatusSeguimiento.ToString.Contains("Rechazado Planificación") And Not EstatusSeguimiento.ToString.Contains("Autorización Gerencia") Then
                MessageBox.Show("No tiene Permisos para Modificar el Seguimiento POA - " & EstatusSeguimiento, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            Using OBJ As New AprobarRechazarPoaSeguimiento
                OBJ.IdEncabezadoPOA = Id_EncabezadoPOA
                OBJ.Gerencia = _NombreDepartamento
                OBJ.Id_Seguimiento = Id_Seguimiento
                OBJ.Id_Mes = comboMeses.SelectedItem(0).ToString()
                OBJ.TipoAutorizacion = False
                OBJ.Autorizacion = False
                OBJ.Mes = comboMeses.SelectedItem(1).ToString()
                OBJ.ShowDialog()
            End Using
        ElseIf TipoUsuario = "Planificacion" Then
            If Not EstatusSeguimiento.ToString.Contains("Aprobado Gerencia") Then
                MessageBox.Show("No tiene Permisos para Modificar el Seguimiento POA - " & EstatusSeguimiento, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            Using OBJ As New AprobarRechazarPoaSeguimiento
                OBJ.IdEncabezadoPOA = Id_EncabezadoPOA
                OBJ.Gerencia = _NombreDepartamento
                OBJ.Id_Mes = comboMeses.SelectedItem(0).ToString()
                OBJ.Id_Seguimiento = Id_Seguimiento
                OBJ.TipoAutorizacion = True
                OBJ.Autorizacion = False
                OBJ.Mes = comboMeses.SelectedItem(1).ToString()
                OBJ.ShowDialog()
            End Using
        End If
        Using obj As New POA_SQLServer
            Try
                Dim TipoAccion As Integer = 0
                Try
                    If cbTipo.SelectedItem.ToString = "Acciones Estrategicas" Then
                        TipoAccion = 1
                    ElseIf cbTipo.SelectedItem = "Acciones de Apoyo" Then
                        TipoAccion = 2
                    End If
                Catch ex As Exception

                End Try
                EstatusSeguimiento = obj.ERP_StrategicPlan_GetPOASeguimientoStatus(Convert.ToInt32(comboMeses.SelectedItem(0).ToString), Id_EncabezadoPOA, TipoAccion)
                Id_Seguimiento = EstatusSeguimiento.ToString.Split("-")(1).ToString.Trim
                EstatusSeguimiento = EstatusSeguimiento.ToString.Split("-")(0).ToString.Trim
                lblStatusMes.Text = EstatusSeguimiento
            Catch ex As Exception

            End Try
        End Using
    End Sub
End Class