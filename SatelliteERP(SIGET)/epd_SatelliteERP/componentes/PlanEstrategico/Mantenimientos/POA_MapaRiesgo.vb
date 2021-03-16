Public Class POA_MapaRiesgo

#Region "Properties"
    Private objsql As New POA_SQLServer
    Property _isInsert As Boolean = True
    Property _Datos As DataGridViewSelectedRowCollection
    Property _IdMap As Integer = 0
    Property IdMapRisk As Integer = 0
    Property _Update As Boolean = False
    Property _VerMapa As Boolean = False
    Enum funcion
        Actualizar
        Agregar
    End Enum
    Property OpcionSeleccionada As funcion
#End Region

    Private Sub Config_InsertUserAccesos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim dt1, dt2, dt3, dt4 As New DataTable

            Using objDatos As New POA_SQLServer
                dt1 = objDatos.ERP_StrategicPlan_GetProbabilityOccurrenceMap()
                dt2 = objDatos.ERP_StrategicPlan_GetImpactGradeMap()

                dt3 = objDatos.ERP_StrategicPlan_GetResponsibleMapRisk(_Id_DepartmentGlobal)
                dt4 = objDatos.ERP_StrategicPlan_GetResponsibleMapRisk(_Id_DepartmentGlobal)

            End Using

            cbProbabilidad.DataSource = dt1
            cbProbabilidad.DisplayMember = "Nombre"
            cbProbabilidad.ValueMember = "Id"

            cbGrado.DataSource = dt2
            cbGrado.DisplayMember = "Nombre"
            cbGrado.ValueMember = "Id"

            cbResponsable.DataSource = dt3
            cbResponsable.DisplayMember = "Name"
            cbResponsable.ValueMember = "Id_responsibleMapRisk"

            cbAutorizacion.DataSource = dt4
            cbAutorizacion.DisplayMember = "Name"
            cbAutorizacion.ValueMember = "Id_responsibleMapRisk"
        Catch ex As Exception

        End Try


        If Not _isInsert Then
            For Each Data As DataGridViewRow In _Datos
                txt_POA_Proceso.Text = Data.Cells("ProcesoMap").Value.ToString
                txt_POA_Objetivos.Text = Data.Cells("ObjetivoMap").Value.ToString
                txtPOA_DescripcionRiesgo.Text = Data.Cells("DescripcionMap").Value.ToString
                txt_POA_Indicador.Text = Data.Cells("IndicadorMap").Value.ToString
                txt_POA_SeguimientoEvaluacion.Text = Data.Cells("SeguimientoMap").Value.ToString
                txt_POA_EquipoResponsable.Text = Data.Cells("EquipoMap").Value.ToString
                cbProbabilidad.SelectedValue = Data.Cells("ProbabilidadMap").Value.ToString
                cbGrado.SelectedValue = Data.Cells("GradoMap").Value.ToString
                IdMapRisk = Data.Cells("ID_RiskMap").Value.ToString
                If Not _Update Then
                    txt_POA_Proceso.Enabled = False
                    txt_POA_Objetivos.Enabled = False
                    txtPOA_DescripcionRiesgo.Enabled = False
                    txt_POA_Indicador.Enabled = False
                    txt_POA_SeguimientoEvaluacion.Enabled = False
                    txt_POA_EquipoResponsable.Enabled = False
                    cbProbabilidad.Enabled = False
                    cbGrado.Enabled = False
                End If
            Next

            Try
                Dim dt As New DataTable
                Dim dt3 As New DataTable
                Using objDatos As New POA_SQLServer
                    dt = objDatos.ERP_StrategicPlan_GetMapRiesgoAcciones(IdMapRisk)
                    dt3 = objDatos.ERP_StrategicPlan_GetMapRiesgoOperaciones(IdMapRisk)
                End Using

                DG_AccionesMAnejo.DataSource = dt
                DG_OpcionesManejo.DataSource = dt3
                If Not _Update Then
                    DG_OpcionesManejo.ReadOnly = True
                    DG_AccionesMAnejo.ReadOnly = True

                    DG_AccionesMAnejo.AllowUserToResizeColumns = False
                    DG_AccionesMAnejo.AllowUserToAddRows = False
                    DG_AccionesMAnejo.AllowUserToDeleteRows = False

                    DG_OpcionesManejo.AllowUserToResizeColumns = False
                    DG_OpcionesManejo.AllowUserToAddRows = False
                    DG_OpcionesManejo.AllowUserToDeleteRows = False
                End If
            Catch ex As Exception

            End Try

            If _Update Then
                btnGrabar.Text = "Editar"
            End If

        End If


        If _VerMapa Then
            btnGrabar.Visible = False
        End If


        txt_POA_Proceso.Focus()
    End Sub

    Private Sub cmdGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        If txt_POA_Proceso.Text.Trim = "" Then
            MessageBox.Show("No puede dejar campos en blanco. Proceso", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_POA_Proceso.Focus()
            Exit Sub
        End If

        If txt_POA_Objetivos.Text.ToString.Trim = "" Then
            MessageBox.Show("No puede dejar campos en blanco. Objetivos", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_POA_Objetivos.Focus()
            Exit Sub
        End If

        If txtPOA_DescripcionRiesgo.Text.ToString.Trim = "" Then
            MessageBox.Show("No puede dejar campos en blanco. Descripción del Riesgo", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtPOA_DescripcionRiesgo.Focus()
            Exit Sub
        End If

        If txt_POA_EquipoResponsable.Text.ToString.Trim = "" Then
            MessageBox.Show("No puede dejar campos en blanco. Equipo Responsable", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_POA_EquipoResponsable.Focus()
            Exit Sub
        End If

        If cbResponsable.SelectedIndex < -1 Then
            MessageBox.Show("No puede dejar campos en blanco. Responsable Creación", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            cbResponsable.Focus()
            Exit Sub
        End If

        If cbAutorizacion.SelectedIndex < -1 Then
            MessageBox.Show("No puede dejar campos en blanco. Responsable Autorización", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            cbAutorizacion.Focus()
            Exit Sub
        End If

        If DG_OpcionesManejo.Rows.Count <= 1 Then
            MessageBox.Show("No puede dejar campos en blanco, Opciones de Manejo.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            DG_OpcionesManejo.Focus()
            Exit Sub
        End If

        If DG_AccionesMAnejo.Rows.Count <= 1 Then
            MessageBox.Show("No puede dejar campos en blanco, Acciones de Manejo.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            DG_AccionesMAnejo.Focus()
            Exit Sub
        End If


        If txt_POA_SeguimientoEvaluacion.Text.ToString.Trim = "" Then
            MessageBox.Show("No puede dejar campos en blanco. Seguimiento y Evaluación", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_POA_SeguimientoEvaluacion.Focus()
            Exit Sub
        End If

        If txt_POA_Indicador.Text.ToString.Trim = "" Then
            MessageBox.Show("No puede dejar campos en blanco. Indicador", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_POA_Indicador.Focus()
            Exit Sub
        End If
        If MessageBox.Show("¿Esta seguro de Guardar la Información?", "Información", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then

            Dim IdMap As String = ""
            If _isInsert Then
                IdMap = objsql.ERP_StrategicPlan_InsertMapRiesgo(txt_POA_Proceso.Text.ToString, txt_POA_Objetivos.Text.ToString, txtPOA_DescripcionRiesgo.Text.ToString, cbProbabilidad.SelectedItem(1).ToString.Split("-")(0), cbGrado.SelectedItem(1).ToString.Split("-")(0), txt_POA_EquipoResponsable.Text.ToString, txt_POA_SeguimientoEvaluacion.Text.ToString, txt_POA_Indicador.Text.ToString, cbResponsable.SelectedValue, cbAutorizacion.SelectedValue)
            Else

                IdMap = objsql.ERP_StrategicPlan_UpdateMapRiesgo(_IdMapRisk, txt_POA_Proceso.Text.ToString, txt_POA_Objetivos.Text.ToString, txtPOA_DescripcionRiesgo.Text.ToString, cbProbabilidad.SelectedItem(1).ToString.Split("-")(0), cbGrado.SelectedItem(1).ToString.Split("-")(0), txt_POA_EquipoResponsable.Text.ToString, txt_POA_SeguimientoEvaluacion.Text.ToString, txt_POA_Indicador.Text.ToString, cbResponsable.SelectedValue, cbAutorizacion.SelectedValue)
            End If

            If DG_OpcionesManejo.Rows.Count > 0 Then
                For i As Integer = 0 To DG_OpcionesManejo.Rows.Count - 1
                    Try
                        objsql.ERP_StrategicPlan_InsertMapRiesgoOpciones(IdMap, DG_OpcionesManejo.Rows(i).Cells("OpcionesManejo").Value.ToString(), i)
                    Catch ex As Exception

                    End Try
                Next
            End If

            If DG_AccionesMAnejo.Rows.Count > 0 Then
                For i As Integer = 0 To DG_AccionesMAnejo.Rows.Count - 1
                    Try
                        objsql.ERP_StrategicPlan_InsertMapRiesgoAcciones(IdMap, DG_AccionesMAnejo.Rows(i).Cells("ManagementActions").Value.ToString(), i)
                    Catch ex As Exception

                    End Try
                Next
            End If

            DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()
        End If

    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Dim Probabilidad As Integer = 0
    Dim Grado As Integer = 0
    Dim Total As Integer = 0

    Private Sub cbProbabilidad_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbProbabilidad.SelectedIndexChanged
        Try
            Dim Probabilidad As Integer = 0
            Dim Grado As Integer = 0
            Try
                Probabilidad = Convert.ToInt16(cbProbabilidad.SelectedItem(1).ToString.Split("-")(0).Trim)
                Grado = Convert.ToInt16(cbGrado.SelectedItem(1).ToString.Split("-")(0).Trim)
            Catch ex As Exception

            End Try
            Total = Probabilidad * Grado
            If Total >= 20 Then
                '=SI(K58>=20;"INADMISIBLE";SI(K58>=12;"ALTO RIESGO";SI(K58>=8;"MEDIO RIESGO";SI(K58>=1;"BAJO RIESGO"))))
                lblSeveridad.Text = "INADMISIBLE"
                lblSeveridad.ForeColor = Color.Black
            ElseIf Total >= 12 Then
                lblSeveridad.Text = "ALTO RIESGO"
                lblSeveridad.ForeColor = Color.Red
            ElseIf Total >= 8 Then
                lblSeveridad.Text = "MEDIO RIESGO"
                lblSeveridad.ForeColor = Color.Orange
            ElseIf Total >= 1 Then
                lblSeveridad.Text = "BAJO RIESGO"
                lblSeveridad.ForeColor = Color.Green
            End If

        Catch ex As Exception
            lblSeveridad.Text = "BAJO RIESGO"
            lblSeveridad.ForeColor = Color.Green
        End Try
        lblSeveridad.BackColor = Color.White
    End Sub

    Private Sub cbGrado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbGrado.SelectedIndexChanged
        Try
            Dim Probabilidad As Integer = 0
            Dim Grado As Integer = 0
            Try
                Probabilidad = Convert.ToInt16(cbProbabilidad.SelectedItem(1).ToString.Split("-")(0).Trim)
                Grado = Convert.ToInt16(cbGrado.SelectedItem(1).ToString.Split("-")(0).Trim)
            Catch ex As Exception

            End Try
            Total = Probabilidad * Grado

            If Total >= 20 Then
                '=SI(K58>=20;"INADMISIBLE";SI(K58>=12;"ALTO RIESGO";SI(K58>=8;"MEDIO RIESGO";SI(K58>=1;"BAJO RIESGO"))))
                lblSeveridad.Text = "INADMISIBLE"
                lblSeveridad.ForeColor = Color.Black
            ElseIf Total >= 12 Then
                lblSeveridad.Text = "ALTO RIESGO"
                lblSeveridad.ForeColor = Color.Red
            ElseIf Total >= 8 Then
                lblSeveridad.Text = "MEDIO RIESGO"
                lblSeveridad.ForeColor = Color.Orange
            ElseIf Total >= 1 Then
                lblSeveridad.Text = "BAJO RIESGO"
                lblSeveridad.ForeColor = Color.Green
            End If
        Catch ex As Exception

        End Try
        lblSeveridad.BackColor = Color.White
    End Sub

End Class