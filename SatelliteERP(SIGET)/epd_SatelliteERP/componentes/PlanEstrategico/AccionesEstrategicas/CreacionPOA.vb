Public Class CreacionPOA

#Region "Properties"
    Private objsql As New POA_SQLServer
    Private dtObjetivos As New DataTable
    Private dtEjes As New DataTable
    Private TipoAccion As Integer = 0
    Private Split() As String
    Private Bandera As Boolean = False
    Property _id_Result As Long
    Property _Update As Boolean = False
    Property Anio As Integer = 0
    Property Fecha As String = ""

    Property ResponsableEje As String = ""
    Property ResponsableAut As String = ""
    Property Objetivo As String = ""
    Property Id_Department As Integer = 0
    Property Id_EncabezadoPOA As Integer = 0
    Property DtLimpio As DataTable
    Property AniosBd As String = ""
    Property EnviarAprobacion As Boolean = False
    Property NombreDepartamentoUpdate As String = ""
    Property _EnviarAprobacionDirecto As Boolean = False

    Enum funcion
        Actualizar
        Agregar
    End Enum
    Property OpcionSeleccionada As funcion
#End Region

    Private Sub Config_InsertUserAccesos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Id_Department > 0 Then
            lblGerencia.Text = NombreDepartamentoUpdate
        Else
            lblGerencia.Text = _NombreDepartamento
        End If

        lblFechaP.Text = Date.Now.Date.ToString("dd-MM-yyyy").ToString
        TipoAccion = 1
        'txtAnio.Text = Date.Now.Date.ToString("yyyy")
        txtAnio.Enabled = True
        If Anio <> 0 Then
            txtAnio.Text = Anio.ToString
            txtAnio.Enabled = False
        End If
        'If _SuperUsuarioPlanificacion Then
        '    _Id_DptoPlani = Id_Department
        'End If
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
            Anio = txtAnio.Text.ToString
        Catch ex As Exception
            Anio = 0
        End Try

        If Not _Update = True Then
            'If Id_Department > 0 And Id_EncabezadoPOA > 0 Then
            '    GetAccionesEstrategicas(Id_Department, Id_EncabezadoPOA, Anio)
            'Else
            '    If _Id_DptoPlani = 0 And Id_EncabezadoPOA = 0 Then
            '        Anio = 0
            '    End If
            '    If _Id_DptoPlani > 0 Then
            '        GetAccionesEstrategicas(_Id_DptoPlani, Id_EncabezadoPOA, Anio)
            '    Else
            '        GetAccionesEstrategicas(_Id_DepartmentGlobal, Id_EncabezadoPOA, Anio)
            '    End If
            'End If

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

        cbTipo.SelectedIndex = 0
        Try
            If Not _Update Then
                DGAcciones.AutoGenerateColumns = False
                DGAcciones.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
                DGAcciones.Font = New Font("calibri", 10)
                DGAcciones.RowHeadersVisible = False
                DGAcciones.Columns("RecursosPOA").DefaultCellStyle.Format = "###.##0.00"
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub GetAccionesEstrategicas(ByVal Id_Departamento As Integer, ByVal Id_EncabezadoPOA As Integer, ByVal AnioQuinquenio As Integer)
        Using objDatos As New POA_SQLServer
            Try
                Anio = txtAnio.Text.ToString
                Dim DtAcciones = objDatos.ERP_StrategicPlan_GetStrategicActionsbyDeparment(Id_Departamento, Anio, Id_EncabezadoPOA)
                DtLimpio = DtAcciones.Clone
                Try
                    DtAcciones.Columns.Remove("TotalAcciones")
                Catch ex As Exception

                End Try


                If DtAcciones IsNot Nothing Then
                    DGAcciones.DataSource = DtAcciones
                    DGAcciones.AutoGenerateColumns = False
                    DGAcciones.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
                    DGAcciones.Font = New Font("calibri", 10)
                    DGAcciones.RowHeadersVisible = False

                    DGAcciones.SelectionMode = DataGridViewSelectionMode.CellSelect
                    DGAcciones.MultiSelect = False

                    DGAcciones.Columns("RecursosPOA").DefaultCellStyle.Format = "###.##0.00"
                    DGAcciones.AllowUserToResizeColumns = False
                    DGAcciones.AllowUserToAddRows = False
                    DGAcciones.AllowUserToDeleteRows = False

                    Dim Dtp As New DataTable
                    Dtp = objDatos.ERP_StrategicPlan_MeasureType()

                    TipoMedicionPOA.DataSource = Dtp
                    TipoMedicionPOA.DisplayMember = "NameMeasure"
                    TipoMedicionPOA.ValueMember = "Id_MeasureType"


                    'Dim DtpData As New DataTable("Info")
                    'DtpData.Columns.Add("Valor")
                    'DtpData.Columns.Add("Tipo")


                    'DtpData.Rows.Add("1", "Aplica")
                    'DtpData.Rows.Add("2", "No Aplica")

                    'AplicaNo.DataSource = DtpData
                    'AplicaNo.DisplayMember = "Tipo"
                    'AplicaNo.ValueMember = "Valor"


                    If _Update Then


                        For i As Integer = 0 To DGAcciones.Rows.Count - 1
                            Try
                                If DGAcciones.Rows(i).Cells("RecursosPOA").Value.ToString.Replace("$", "") > 0 Then
                                    DGAcciones.Rows(i).Cells("AplicaNo").Value = True
                                Else
                                    DGAcciones.Rows(i).Cells("AplicaNo").Value = False
                                End If
                            Catch ex As Exception

                            End Try
                            'DGAcciones.Rows(i).Cells("AplicaNo").Value = 0
                            Try
                                If DGAcciones.Rows(i).Cells("IdTipoMedicion").Value > 0 Then
                                    DGAcciones.Rows(i).Cells("TipoMedicionPOA").Value = DGAcciones.Rows(i).Cells("IdTipoMedicion").Value
                                End If

                            Catch ex As Exception

                            End Try
                        Next
                    Else
                        For i As Integer = 0 To DGAcciones.Rows.Count - 1
                            Try
                                DGAcciones.Rows(i).Cells("AplicaNo").Value = True
                            Catch ex As Exception

                            End Try

                            Try
                                If DGAcciones.Rows(i).Cells("IdTipoMedicion").Value > 0 Then
                                    DGAcciones.Rows(i).Cells("TipoMedicionPOA").Value = Dtp.Rows(0).Item("Id_MeasureType")
                                End If

                            Catch ex As Exception

                            End Try
                        Next
                    End If

                    DGAcciones.AllowUserToOrderColumns = True
                    DGAcciones.Columns("IdAccionPOA").DisplayIndex = 1
                    DGAcciones.Columns("CodeAccion").DisplayIndex = 2
                    DGAcciones.Columns("Accion").DisplayIndex = 3
                    DGAcciones.Columns("Lider").DisplayIndex = 4
                    DGAcciones.Columns("TipoMedicionPOA").DisplayIndex = 5
                    DGAcciones.Columns("IndicadorA").DisplayIndex = 6
                    DGAcciones.Columns("MetaPOA").DisplayIndex = 7
                    DGAcciones.Columns("EneroPOA").DisplayIndex = 8
                    DGAcciones.Columns("FebreroPOA").DisplayIndex = 9
                    DGAcciones.Columns("MarzoPOA").DisplayIndex = 10
                    DGAcciones.Columns("AbrilPOA").DisplayIndex = 11
                    DGAcciones.Columns("MayoPOA").DisplayIndex = 12
                    DGAcciones.Columns("JunioPOA").DisplayIndex = 13
                    DGAcciones.Columns("JulioPOA").DisplayIndex = 14
                    DGAcciones.Columns("AgostoPOA").DisplayIndex = 15
                    DGAcciones.Columns("SeptiembrePOA").DisplayIndex = 16
                    DGAcciones.Columns("OctubrePOA").DisplayIndex = 17
                    DGAcciones.Columns("NoviembrePOA").DisplayIndex = 18
                    DGAcciones.Columns("DiciembrePOA").DisplayIndex = 19
                    DGAcciones.Columns("AplicaNo").DisplayIndex = 20
                    DGAcciones.Columns("RecursosPOA").DisplayIndex = 21
                    DGAcciones.Columns("IdTipoMedicion").DisplayIndex = 22

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

    Private Sub DataGridView1_DataError(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) _
     Handles DGAcciones.DataError

        'MessageBox.Show("Error:  " & e.Context.ToString())

        'If (e.Context = DataGridViewDataErrorContexts.Commit) _
        '    Then
        '    MessageBox.Show("Commit error")
        'End If
        'If (e.Context = DataGridViewDataErrorContexts.CurrentCellChange) Then
        '    MessageBox.Show("Cell change")
        'End If
        'If (e.Context = DataGridViewDataErrorContexts.Parsing) Then
        '    MessageBox.Show("parsing error")
        'End If
        'If (e.Context = DataGridViewDataErrorContexts.LeaveControl) Then
        '    MessageBox.Show("leave control error")
        'End If

        If (TypeOf (e.Exception) Is ConstraintException) Then
            Dim view As DataGridView = CType(sender, DataGridView)
            view.Rows(e.RowIndex).ErrorText = "an error"
            view.Rows(e.RowIndex).Cells(e.ColumnIndex) _
                .ErrorText = "an error"
            MsgBox("error")
            e.ThrowException = False
        End If

    End Sub

    Private Sub GetAccionesdeApoyo(ByVal Id_Departamento As Integer)
        Using objDatos As New POA_SQLServer
            Try
                Dim DtAcciones As New DataTable
                DtAcciones = objDatos.ERP_StrategicPlan_GetOperationalActionPOA(txtAnio.Text.ToString)
                If DtAcciones IsNot Nothing Then
                    DGAcciones.DataSource = DtAcciones
                    DGAcciones.AutoGenerateColumns = False
                    DGAcciones.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
                    DGAcciones.Font = New Font("calibri", 10)
                    DGAcciones.RowHeadersVisible = False


                    DGAcciones.SelectionMode = DataGridViewSelectionMode.CellSelect
                    DGAcciones.MultiSelect = False
                    ' DGAcciones.Columns("RecursosPOA").DefaultCellStyle.Format = "###.##0.00"
                    DGAcciones.AllowUserToResizeColumns = False
                    DGAcciones.AllowUserToAddRows = False
                    DGAcciones.AllowUserToDeleteRows = False


                    If _Update Then

                        For i As Integer = 0 To DGAcciones.Rows.Count - 1
                            Try
                                If DGAcciones.Rows(i).Cells("RecursosPOA").Value.ToString.Replace("$", "") > 0 Then
                                    DGAcciones.Rows(i).Cells("AplicaNo").Value = True
                                Else
                                    DGAcciones.Rows(i).Cells("AplicaNo").Value = False
                                End If
                            Catch ex As Exception

                            End Try
                            'DGAcciones.Rows(i).Cells("AplicaNo").Value = 0
                            Try
                                If DGAcciones.Rows(i).Cells("IdTipoMedicion").Value > 0 Then
                                    DGAcciones.Rows(i).Cells("TipoMedicionPOA").Value = DGAcciones.Rows(i).Cells("IdTipoMedicion").Value
                                End If

                            Catch ex As Exception
                                DGAcciones.Rows(i).Cells("TipoMedicionPOA").Value = 1
                            End Try
                        Next
                    Else
                        For i As Integer = 0 To DGAcciones.Rows.Count - 1
                            Try
                                DGAcciones.Rows(i).Cells("AplicaNo").Value = True
                            Catch ex As Exception

                            End Try
                        Next
                    End If


                    DGAcciones.AllowUserToOrderColumns = True
                    DGAcciones.Columns("IdAccionPOA").DisplayIndex = 1
                    DGAcciones.Columns("CodeAccion").DisplayIndex = 2
                    DGAcciones.Columns("Accion").DisplayIndex = 3
                    DGAcciones.Columns("Lider").DisplayIndex = 4
                    DGAcciones.Columns("TipoMedicionPOA").DisplayIndex = 5
                    DGAcciones.Columns("IndicadorA").DisplayIndex = 6
                    DGAcciones.Columns("MetaPOA").DisplayIndex = 7
                    DGAcciones.Columns("EneroPOA").DisplayIndex = 8
                    DGAcciones.Columns("FebreroPOA").DisplayIndex = 9
                    DGAcciones.Columns("MarzoPOA").DisplayIndex = 10
                    DGAcciones.Columns("AbrilPOA").DisplayIndex = 11
                    DGAcciones.Columns("MayoPOA").DisplayIndex = 12
                    DGAcciones.Columns("JunioPOA").DisplayIndex = 13
                    DGAcciones.Columns("JulioPOA").DisplayIndex = 14
                    DGAcciones.Columns("AgostoPOA").DisplayIndex = 15
                    DGAcciones.Columns("SeptiembrePOA").DisplayIndex = 16
                    DGAcciones.Columns("OctubrePOA").DisplayIndex = 17
                    DGAcciones.Columns("NoviembrePOA").DisplayIndex = 18
                    DGAcciones.Columns("DiciembrePOA").DisplayIndex = 19
                    DGAcciones.Columns("AplicaNo").DisplayIndex = 20
                    DGAcciones.Columns("RecursosPOA").DisplayIndex = 21
                    DGAcciones.Columns("IdTipoMedicion").DisplayIndex = 22

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

    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        Try


            If IsNumeric(txtAnio.Text) Then
                If txtAnio.Text.Length < 4 Or txtAnio.Text.Length > 4 Then
                    MessageBox.Show("Favor ingrese un año correcto.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    _EnviarAprobacionDirecto = False
                    Exit Sub
                End If
            Else
                MessageBox.Show("Favor ingrese un año correcto.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtAnio.Focus()
                _EnviarAprobacionDirecto = False
                Exit Sub
            End If
            Dim Bandera As Boolean = False
            For i As Integer = Date.Now.Year - 25 To Date.Now.Year + 10
                If txtAnio.Text.ToString.Trim = i.ToString Then
                    Bandera = True
                    Exit For
                End If
            Next
            If Not Bandera Then
                MessageBox.Show("Favor ingrese un año correcto.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtAnio.Focus()
                _EnviarAprobacionDirecto = False
                Exit Sub
            End If


            If Not _Update Then
                Try
                    Bandera = False
                    Split = AniosBd.ToString.Split(",")
                    For i As Integer = 0 To Split.Count - 1
                        If txtAnio.Text.ToString = Split(i).ToString And Split(i).ToString <> "" Then
                            Bandera = True
                        End If
                    Next
                    If Bandera And Split.Count > 0 Then
                        MessageBox.Show("El año digitado ya esta Ingresado, favor verificar la información", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                        _EnviarAprobacionDirecto = False
                        Exit Sub
                        'DialogResult = System.Windows.Forms.DialogResult.OK
                        'Me.Close()
                    End If
                Catch ex As Exception

                End Try
            End If
            Dim Aplica As Boolean = False
            Dim num As Integer = 0
            For Each DataInfo As DataGridViewRow In DGAcciones.Rows

                Try
                    Aplica = DataInfo.Cells("AplicaNo").Value
                Catch ex As Exception
                    Aplica = 0
                End Try

                If Aplica Then
                    Try
                        If DataInfo.Cells("RecursosPOA").Value.ToString.Trim.Replace("$", "") = "0" Or DataInfo.Cells("RecursosPOA").Value.ToString.Trim.Replace("$", "") = "0" Or
                        Convert.ToDecimal(DataInfo.Cells("RecursosPOA").Value.ToString.Trim.Replace("$", "")) <= 0 Or DataInfo.Cells("RecursosPOA").Value.ToString.Trim.Replace("$", "") = "" Then
                            MessageBox.Show("Debe de ingresar un Recurso para la Acción", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                            DGAcciones.Rows(num).Cells("RecursosPOA").Selected = True
                            _EnviarAprobacionDirecto = False
                            Exit Sub
                        End If
                    Catch ex As Exception
                        MessageBox.Show("Debe de ingresar un Recurso para la Acción", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                        DGAcciones.Rows(num).Cells("RecursosPOA").Selected = True
                        _EnviarAprobacionDirecto = False
                        Exit Sub
                    End Try
                Else
                    DGAcciones.Rows(num).Cells("RecursosPOA").Value = "0"
                End If
                num += 1
            Next


            Dim IdEncabezado As Integer = 0
            Dim IdptoSend As Integer = 0
            Try

                If Id_Department > 0 Then
                    IdptoSend = Id_Department
                Else
                    IdptoSend = _Id_DepartmentGlobal
                End If

                Dim Fecha() As String
                Try
                    Fecha = lblFechaP.Text.ToString.Replace("/", "-").Split("-")

                Catch ex As Exception
                    Try
                        Fecha = lblFechaP.Text.ToString.Split("/")

                    Catch e2x As Exception

                    End Try
                End Try


                Dim FechaReal As String = Fecha(2) & "-" & Fecha(1) & "-" & Fecha(0)
                IdEncabezado = objsql.ERP_StrategicPlan_ProcessPOAEncabezado(IdptoSend, txtAnio.Text, FechaReal, cbResponsable.SelectedValue, cbAutorizacion.SelectedValue, txtObjetivo.Text)
                Id_EncabezadoPOA = IdEncabezado
            Catch ex3 As Exception

            End Try
            Dim TipoMedicion As Integer = 0
            Aplica = 0
            For Each DataInfo As DataGridViewRow In DGAcciones.Rows

                Try
                    TipoMedicion = DataInfo.Cells("TipoMedicionPOA").Value.ToString()
                Catch ex As Exception
                    TipoMedicion = 0
                End Try

                Try
                    Aplica = Convert.ToInt32(DataInfo.Cells("AplicaNo").Value)
                Catch ex As Exception
                    Aplica = 0
                End Try

                If Aplica = 1 Or Aplica = True Then
                    If DataInfo.Cells("RecursosPOA").Value.ToString.Replace("$", "").Trim = "0" Then
                        MessageBox.Show("Debe de ingresar un Recurso para la Acción", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                        _EnviarAprobacionDirecto = False
                        Exit Sub
                    End If
                End If

                objsql.ERP_StrategicPlan_ProcessPOA(IdEncabezado, IdptoSend, DataInfo.Cells("IdAccionPOA").Value.ToString,
                                                    _Id_DptoPlani, txtAnio.Text.ToString,
                                                    validarnumeros(DataInfo.Cells("EneroPOA").Value.ToString),
                                                    validarnumeros(DataInfo.Cells("FebreroPOA").Value.ToString),
                                                    validarnumeros(DataInfo.Cells("MarzoPOA").Value.ToString),
                                                    validarnumeros(DataInfo.Cells("AbrilPOA").Value.ToString),
                                                    validarnumeros(DataInfo.Cells("MayoPOA").Value.ToString),
                                                    validarnumeros(DataInfo.Cells("JunioPOA").Value.ToString),
                                                    validarnumeros(DataInfo.Cells("JulioPOA").Value.ToString),
                                                    validarnumeros(DataInfo.Cells("AgostoPOA").Value.ToString),
                                                    validarnumeros(DataInfo.Cells("SeptiembrePOA").Value.ToString),
                                                    validarnumeros(DataInfo.Cells("OctubrePOA").Value.ToString),
                                                    validarnumeros(DataInfo.Cells("NoviembrePOA").Value.ToString),
                                                    validarnumeros(DataInfo.Cells("DiciembrePOA").Value.ToString),
                                                    TipoMedicion,
                                                    DataInfo.Cells("RecursosPOA").Value.ToString(),
                                                    DataInfo.Cells("MetaPOA").Value.ToString,
                                                    TipoAccion,
                                                    DataInfo.Cells("IndicadorA").Value.ToString)
            Next
            If EnviarAprobacion Then
                _EnviarAprobacionDirecto = True
                Exit Sub
            End If
            DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()
        Catch ex As Exception
            Using objLog As New ProcessGeneral
                objLog.AlmacenarLog(4, ex.Message, System.Reflection.MethodBase.GetCurrentMethod().Name)
            End Using
        End Try
    End Sub


    Private Function validarnumeros(ByVal NUmero As String) As String
        If NUmero = "" Or NUmero.ToString.Trim = "" Then
            Return "0"
        Else
            If NUmero.ToString.Contains("$") Then
                NUmero = NUmero.Replace("$", "").ToString.Trim
            End If
            Return NUmero
        End If
    End Function


    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbTipo.SelectedIndexChanged
        Try


            If IsNumeric(txtAnio.Text) Then
                If txtAnio.Text.Length < 4 Or txtAnio.Text.Length > 4 Then
                    MessageBox.Show("Favor ingrese un año correcto.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            Else
                'MessageBox.Show("Favor ingrese un año correcto.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtAnio.Focus()
                Exit Sub
            End If
            Dim Bandera As Boolean = False
            For i As Integer = Date.Now.Year - 25 To Date.Now.Year + 10
                If txtAnio.Text.ToString.Trim = i.ToString Then
                    Bandera = True
                    Exit For
                End If
            Next
            If Not Bandera Then
                MessageBox.Show("Favor ingrese un año correcto.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtAnio.Focus()
                Exit Sub
            End If

            Dim IdptoSend As Integer = 0

            If Id_Department > 0 Then
                IdptoSend = Id_Department
            Else
                IdptoSend = _Id_DptoPlani
            End If

            If cbTipo.Text = "Acciones de Apoyo" Then
                GetAccionesdeApoyo(IdptoSend)
                GBData.Text = "Acciones de Apoyo"
                TipoAccion = 2
                LinkAcciones.Visible = True
            Else
                GetAccionesEstrategicas(IdptoSend, Id_EncabezadoPOA, txtAnio.Text.ToString)
                GBData.Text = "Acciones Estrategicas"
                TipoAccion = 1
                LinkAcciones.Visible = False
            End If
            DGAcciones.Columns("IdTipoMedicion").Visible = False
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkAcciones.LinkClicked
        Using obj As New POA_InsertAccionesOperativas
            Try
                obj._AnioAc = txtAnio.Text
            Catch ex As Exception

            End Try
            obj.ShowDialog()
            GetAccionesdeApoyo(_Id_DptoPlani)
        End Using
    End Sub

    Private Sub txtAnio_Leave(sender As Object, e As EventArgs) Handles txtAnio.Leave
        Try
            Bandera = False
            Split = AniosBd.ToString.Split(",")
            For i As Integer = 0 To Split.Count - 1
                If txtAnio.Text.ToString = Split(i).ToString And Split(i).ToString <> "" Then
                    Bandera = True
                End If
            Next
            If Bandera And Split.Count > 0 Then
                MessageBox.Show("El año digitado ya esta Ingresado, favor verificar la información", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)

                'DialogResult = System.Windows.Forms.DialogResult.OK
                'Me.Close()
                DGAcciones.DataSource = DtLimpio
            Else
                ComboBox3_SelectedIndexChanged(Nothing, Nothing)
            End If


        Catch ex As Exception

        End Try
    End Sub

    Private Sub DGAcciones_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DGAcciones.CellValueChanged
        Try
            For Each DataInfo As DataGridViewRow In DGAcciones.Rows

                DataInfo.Cells("MetaPOA").Value = Convert.ToInt32(validarnumeros(DataInfo.Cells("EneroPOA").Value.ToString)) +
                                                    Convert.ToInt32(validarnumeros(DataInfo.Cells("FebreroPOA").Value.ToString)) +
                                                    Convert.ToInt32(validarnumeros(DataInfo.Cells("MarzoPOA").Value.ToString)) +
                                                    Convert.ToInt32(validarnumeros(DataInfo.Cells("AbrilPOA").Value.ToString)) +
                                                    Convert.ToInt32(validarnumeros(DataInfo.Cells("MayoPOA").Value.ToString)) +
                                                    Convert.ToInt32(validarnumeros(DataInfo.Cells("JunioPOA").Value.ToString)) +
                                                    Convert.ToInt32(validarnumeros(DataInfo.Cells("JulioPOA").Value.ToString)) +
                                                    Convert.ToInt32(validarnumeros(DataInfo.Cells("AgostoPOA").Value.ToString)) +
                                                    Convert.ToInt32(validarnumeros(DataInfo.Cells("SeptiembrePOA").Value.ToString)) +
                                                    Convert.ToInt32(validarnumeros(DataInfo.Cells("OctubrePOA").Value.ToString)) +
                                                    Convert.ToInt32(validarnumeros(DataInfo.Cells("NoviembrePOA").Value.ToString)) +
                                                    Convert.ToInt32(validarnumeros(DataInfo.Cells("DiciembrePOA").Value.ToString))
            Next
        Catch ex As Exception

        End Try

    End Sub


    Private Sub DGAcciones_Click(sender As Object, e As EventArgs) Handles DGAcciones.Click

        Dim ee As String = ""

        For Each DataInfo As DataGridViewRow In DGAcciones.Rows
            Try
                If DataInfo.Cells("AplicaNo").Value = False Then
                    If IsNothing(DataInfo.Cells("RecursosPOA").Value) Or DataInfo.Cells("RecursosPOA").Value.ToString = "0" Then
                        DataInfo.Cells("RecursosPOA").Value = "0"
                    End If
                End If
            Catch ex As Exception

            End Try
        Next
    End Sub

    Private Sub btnHistorialRechazos_Click(sender As Object, e As EventArgs) Handles btnHistorialRechazos.Click
        Using obj As New RechazosPOA
            obj.IdEncabezado = Id_EncabezadoPOA
            obj.ShowDialog()
        End Using
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try

            EnviarAprobacion = True
            btnGrabar_Click(Nothing, Nothing)
            If Not _EnviarAprobacionDirecto Then
                Exit Sub
            End If
            Dim total As Integer = 0
            Dim num As Integer = 0
            For Each DataInfo As DataGridViewRow In DGAcciones.Rows
                total = 0
                total = Convert.ToInt32(validarnumeros(DataInfo.Cells("EneroPOA").Value.ToString)) +
                                                    Convert.ToInt32(validarnumeros(DataInfo.Cells("FebreroPOA").Value.ToString)) +
                                                    Convert.ToInt32(validarnumeros(DataInfo.Cells("MarzoPOA").Value.ToString)) +
                                                    Convert.ToInt32(validarnumeros(DataInfo.Cells("AbrilPOA").Value.ToString)) +
                                                    Convert.ToInt32(validarnumeros(DataInfo.Cells("MayoPOA").Value.ToString)) +
                                                    Convert.ToInt32(validarnumeros(DataInfo.Cells("JunioPOA").Value.ToString)) +
                                                    Convert.ToInt32(validarnumeros(DataInfo.Cells("JulioPOA").Value.ToString)) +
                                                    Convert.ToInt32(validarnumeros(DataInfo.Cells("AgostoPOA").Value.ToString)) +
                                                    Convert.ToInt32(validarnumeros(DataInfo.Cells("SeptiembrePOA").Value.ToString)) +
                                                    Convert.ToInt32(validarnumeros(DataInfo.Cells("OctubrePOA").Value.ToString)) +
                                                    Convert.ToInt32(validarnumeros(DataInfo.Cells("NoviembrePOA").Value.ToString)) +
                                                    Convert.ToInt32(validarnumeros(DataInfo.Cells("DiciembrePOA").Value.ToString))

                Try
                    If DataInfo.Cells("TipoMedicionPOA").Value.ToString.Trim = 0 Then
                        DGAcciones.Rows(num).Cells("TipoMedicionPOA").Selected = True
                        If (MessageBox.Show("Hay acciones estrategicas que no poseen Tipo de Medición Asignado, desea continuar con el envio a Aprobación", Application.ProductName, MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = DialogResult.OK) Then
                            Exit For
                        Else
                            Exit Sub
                        End If
                    End If

                Catch ex As Exception
                    DGAcciones.Rows(num).Cells("TipoMedicionPOA").Selected = True
                    If (MessageBox.Show("Hay acciones estrategicas que no poseen Tipo de Medición Asignado, desea continuar con el envio a Aprobación", Application.ProductName, MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = DialogResult.OK) Then
                        Exit For
                    Else
                        Exit Sub
                    End If
                End Try


                If DataInfo.Cells("IndicadorA").Value.ToString.Trim = "" Then
                    DGAcciones.Rows(num).Cells("IndicadorA").Selected = True
                    If (MessageBox.Show("Hay acciones estrategicas que no poseen Indicador Asignado, desea continuar con el envio a Aprobación", Application.ProductName, MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = DialogResult.OK) Then
                        Exit For
                    Else
                        Exit Sub
                    End If
                End If


                If total = 0 Then
                    DGAcciones.Rows(num).Cells("MetaPOA").Selected = True
                    If (MessageBox.Show("Hay acciones estrategicas que no poseen programación, desea continuar con el envio a Aprobación", Application.ProductName, MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = DialogResult.OK) Then
                        Exit For
                    Else
                        Exit Sub
                    End If
                End If

                num += 1
            Next




            Using OBJ As New AprobarRechazarPoa
                OBJ.Anio = Anio
                OBJ.IdEncabezadoPOA = Id_EncabezadoPOA
                'OBJ.Gerencia = DG_POA.CurrentRow.Cells("Gerencia").Value.ToString
                OBJ.Id_DepartamentoPOA = _Id_DepartmentGlobal
                OBJ.TipoAutorizacion = False

                OBJ.Autorizacion = True
                OBJ.ShowDialog()
            End Using

        Catch ex As Exception

        End Try
        DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub
End Class