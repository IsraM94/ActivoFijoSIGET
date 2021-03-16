Public Class POA_EvaluacionMapa

#Region "Properties"
    Private objsql As New POA_SQLServer
    Private _Inactivas As Boolean = False
    Private _Activas As Boolean = False
    Private _Atrasadas As Boolean = False
    Private _DT_CreditLine As DataTable = Nothing
    Private _DT_TypeCreditLine As DataTable = Nothing
    Property _isInsert As Boolean = True
    Property _name As String = ""
    Property _description As String = ""
    Property _Datos As DataGridViewSelectedRowCollection
    Private IdMapRisk As Integer = 0
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
                txt_POA_Proceso.Enabled = False
                txt_POA_Objetivos.Text = Data.Cells("ObjetivoMap").Value.ToString
                txt_POA_Objetivos.Enabled = False
                txtPOA_DescripcionRiesgo.Text = Data.Cells("DescripcionMap").Value.ToString
                txtPOA_DescripcionRiesgo.Enabled = False
                txt_POA_Indicador.Text = Data.Cells("IndicadorMap").Value.ToString
                txt_POA_Indicador.Enabled = False
                txt_POA_SeguimientoEvaluacion.Text = Data.Cells("SeguimientoMap").Value.ToString
                txt_POA_SeguimientoEvaluacion.Enabled = False
                txt_POA_EquipoResponsable.Text = Data.Cells("EquipoMap").Value.ToString
                txt_POA_EquipoResponsable.Enabled = False
                IdMapRisk = Data.Cells("ID_RiskMap").Value.ToString
                cbProbabilidad.SelectedValue = Data.Cells("ProbabilidadMap").Value.ToString
                cbGrado.SelectedValue = Data.Cells("GradoMap").Value.ToString
            Next

            Try
                Dim dt As New DataTable
                Dim dt3 As New DataTable
                Using objDatos As New POA_SQLServer
                    dt = objDatos.ERP_StrategicPlan_GetMapRiesgoAcciones(IdMapRisk)
                End Using

                DG_AccionesMAnejo.DataSource = dt

                DG_AccionesMAnejo.AllowUserToResizeColumns = False
                DG_AccionesMAnejo.AllowUserToAddRows = False
                DG_AccionesMAnejo.AllowUserToDeleteRows = False
            Catch ex As Exception

            End Try

        End If
    End Sub

    Private Sub cmdGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        If txt_POA_Proceso.Text = "" Or txt_POA_Objetivos.Text = " " Then
            MessageBox.Show("No puede dejar campos en blanco.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_POA_Proceso.Focus()
            Exit Sub
        End If
        If MessageBox.Show("¿Esta seguro de Guardar la Información?", "Información", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then

            objsql.ERP_StrategicPlan_UpdateMapRiesgoEvaluacion(IdMapRisk, cbProbabilidad.SelectedItem(1).ToString.Split("-")(0), cbGrado.SelectedItem(1).ToString.Split("-")(0), cbResponsable.SelectedValue, cbAutorizacion.SelectedValue)
            If DG_AccionesMAnejo.Rows.Count > 0 Then
                For i As Integer = 0 To DG_AccionesMAnejo.Rows.Count - 1
                    Try
                        objsql.ERP_StrategicPlan_InsertMapRiesgoAccionesEvaluacion(IdMapRisk, DG_AccionesMAnejo.Rows(i).Cells("ID_ManagementActions").Value.ToString(), DG_AccionesMAnejo.Rows(i).Cells("Resultados").Value.ToString(), DG_AccionesMAnejo.Rows(i).Cells("Observaciones").Value.ToString())
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
                Probabilidad = cbProbabilidad.SelectedItem(1).ToString.Split("-")(0).ToString.Trim
                Grado = cbGrado.SelectedItem(1).ToString.Split("-")(0).ToString.Trim
            Catch ex As Exception

            End Try
            If Probabilidad > 0 And Grado > 0 Then

                Total = Convert.ToInt16(Probabilidad) * Convert.ToInt16(Grado)
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
                Probabilidad = cbProbabilidad.SelectedItem(1).ToString.Split("-")(0).ToString.Trim
                Grado = cbGrado.SelectedItem(1).ToString.Split("-")(0).ToString.Trim
            Catch ex As Exception

            End Try
            If Probabilidad > 0 And Grado > 0 Then

                Total = Convert.ToInt16(Probabilidad) * Convert.ToInt16(Grado)
                If Total >= 20 Then
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
            End If
        Catch ex As Exception

        End Try
        lblSeveridad.BackColor = Color.White
    End Sub

End Class