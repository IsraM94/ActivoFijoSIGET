Public Class MatrizProceso

#Region "Properties"
    Private objsql As New POA_SQLServer
    Private dtObjetivos As New DataTable
    Private dtEjes As New DataTable
    Private dtResult As New DataTable
    Private bandera As Long = 0
    Property _isInsert As Boolean = True
    Property _quinquenio As String = Year(Now)
    Property _nameobjetivo As String = ""
    Property _servicio As String = ""
    Property _idobjetivo As Long = 0

    Enum funcion
        Actualizar
        Agregar
    End Enum
    Property OpcionSeleccionada As funcion
#End Region

    Private Sub Config_InsertUserAccesos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dtObjetivos = objsql.ERP_StrategicPlan_GetStrategicObjective(0)
        comboListObjetivo.DataSource = dtObjetivos
        comboListObjetivo.DisplayMember = "Name"
        comboListObjetivo.ValueMember = "ID_StrategicObjective"

        If Not _VerTodos Then
            comboListObjetivo.Visible = False
        End If

        txt_Quinquenio.Focus()
        txt_Quinquenio.Text = _quinquenio.ToString.Split("-")(0).ToString.Trim
        comboListObjetivo.Text = _nameobjetivo

        If _isInsert <> True Then
            GetEjesById(_idobjetivo)
            bandera = 1
        End If

        DG_Ejes.AutoGenerateColumns = False
        DG_Ejes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
        DG_Ejes.Font = New Font("Segoe UI", 11)
        'DG_Ejes.RowHeadersVisible = False
        DG_Ejes.Columns(0).Width = 75
        DG_Ejes.Columns(1).Width = 100
        DG_Ejes.Columns(2).Width = 650
        DG_Ejes.Columns(3).Width = 200

    End Sub

    Private Sub cmdGrabar_Click(sender As Object, e As EventArgs) Handles btnSeleccionar.Click
        Using obj As New MatrizProcesoEjes
            If obj.ShowDialog() = DialogResult.OK Then
                DG_Ejes.Rows.Add(obj._ideje, obj._CodeAxesFi, obj._nameeje, 0)
                'readResult(ideje)
            End If

        End Using
    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        DG_Ejes.Rows.Remove(DG_Ejes.CurrentRow)
    End Sub


    Private Sub GetEjesById(ByVal _id As Long)
        Using objDatos As New POA_SQLServer
            Try
                dtEjes = objDatos.ERP_StrategicPlan_GetProcessAxcesByID(_id)
                If dtEjes IsNot Nothing Then
                    DG_Ejes.AutoGenerateColumns = False
                    DG_Ejes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
                    DG_Ejes.Font = New Font("Segoe UI", 11)
                    'DG_Ejes.RowHeadersVisible = False
                    DG_Ejes.Columns(0).Width = 75
                    DG_Ejes.Columns(1).Width = 650
                    DG_Ejes.Columns(2).Width = 200

                    'DG_Ejes.ReadOnly = True
                    DG_Ejes.SelectionMode = DataGridViewSelectionMode.FullRowSelect
                    DG_Ejes.MultiSelect = False

                    DG_Ejes.AllowUserToResizeColumns = False
                    DG_Ejes.AllowUserToAddRows = False
                    DG_Ejes.AllowUserToDeleteRows = False

                    Try
                        For Each info As DataRow In dtEjes.Rows
                            DG_Ejes.Rows.Add(info("ID_Eje").ToString, info("CodeAxes").ToString, info("Eje").ToString, info("Percentage").ToString, info("ID_ProcessAxes").ToString)
                        Next
                    Catch ex As Exception

                    End Try

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


    Private Sub GetResult(ByVal _idEje As Long, ByVal _idEjeadd As Long)
        Using objDatos As New POA_SQLServer
            Try
                dtResult = objDatos.ERP_StrategicPlan_SearchResultByIdAxes(_idEje, bandera, _idEjeadd)
                If dtResult IsNot Nothing Then
                    DG_Result.AutoGenerateColumns = False
                    DG_Result.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
                    DG_Result.Font = New Font("Segoe UI", 11)
                    'DG_Result.RowHeadersVisible = False
                    DG_Result.Columns(0).Width = 75
                    DG_Result.Columns(1).Width = 100
                    DG_Result.Columns(2).Width = 650
                    DG_Result.Columns(3).Width = 200

                    'DG_Result.ReadOnly = True
                    DG_Result.SelectionMode = DataGridViewSelectionMode.FullRowSelect
                    DG_Result.MultiSelect = False

                    DG_Result.AllowUserToResizeColumns = False
                    DG_Result.AllowUserToAddRows = False
                    DG_Result.AllowUserToDeleteRows = False
                    DG_Result.DataSource = dtResult

                    Try
                        DG_Indicadores.DataSource = Nothing
                    Catch ex As Exception

                    End Try
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

    Private Sub GetIndicator(ByVal id_Result As Long, ByVal Id_Axes As Integer)
        Using objDatos As New POA_SQLServer
            Try
                dtResult = objDatos.ERP_StrategicPlan_SearchIndicatortByIdResult(id_Result, Id_Axes)
                If dtResult IsNot Nothing Then
                    DG_Indicadores.AutoGenerateColumns = False
                    DG_Indicadores.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
                    DG_Indicadores.Font = New Font("Segoe UI", 11)
                    DG_Indicadores.Columns(0).Width = 75
                    DG_Indicadores.Columns(1).Width = 100
                    DG_Indicadores.RowHeadersVisible = False
                    DG_Indicadores.Columns(2).Width = 650
                    DG_Indicadores.Columns(3).Width = 200

                    'DG_Indicadores.ReadOnly = True
                    DG_Indicadores.SelectionMode = DataGridViewSelectionMode.FullRowSelect
                    DG_Indicadores.MultiSelect = False

                    DG_Indicadores.AllowUserToResizeColumns = False
                    DG_Indicadores.AllowUserToAddRows = False
                    DG_Indicadores.AllowUserToDeleteRows = False
                    DG_Indicadores.DataSource = dtResult
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

    Private Sub cmdCancelar_Click(sender As Object, e As EventArgs) Handles cmdCancelar.Click
        DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub cmdGuardar_Click(sender As Object, e As EventArgs) Handles cmdGuardar.Click
        If txt_Quinquenio.Text = "" Then
            MessageBox.Show("No puede dejar campos en blanco.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_Quinquenio.Focus()
            Exit Sub
        End If


        If IsNumeric(txt_Quinquenio.Text) Then
            If txt_Quinquenio.Text.Length < 4 Or txt_Quinquenio.Text.Length > 4 Then
                MessageBox.Show("Favor ingrese un año correcto.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                txt_Quinquenio.Focus()
                Exit Sub
            End If
        Else
            MessageBox.Show("Favor ingrese un año correcto.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_Quinquenio.Focus()
            Exit Sub
        End If
        Dim Bandera As Boolean = False
        For i As Integer = Date.Now.Year - 25 To Date.Now.Year + 10
            If txt_Quinquenio.Text.ToString.Trim = i.ToString Then
                Bandera = True
                Exit For
            End If
        Next

        If Not Bandera Then
            MessageBox.Show("Favor ingrese un año correcto.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_Quinquenio.Focus()
            Exit Sub
        End If


        Try
            If DG_Ejes.Rows.Count <= 0 Then
                MessageBox.Show("Debe de ingresar los EJES para crear la planificación.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                DG_Ejes.Focus()
                Exit Sub
            End If
        Catch ex As Exception

        End Try

        Dim _IdProcess As Long
        Dim _IdProcessAxes As Long
        If _idobjetivo = 0 Then
            _IdProcess = objsql.ERP_StrategicPlan_InserProcess(0, _Id_DptoPlani, txt_Quinquenio.Text)
        Else
            _IdProcess = objsql.ERP_StrategicPlan_InserProcess(_idobjetivo, _Id_DptoPlani, txt_Quinquenio.Text)
        End If

        If _IdProcess = "999999999" Then
            MessageBox.Show("El Quinquenio ingresado ya existe, favor verificar la información.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If


        For Each value As DataGridViewRow In DG_Ejes.SelectedRows
            Dim idAxes As Long = value.Cells("IDStrategicAxes").Value
            Dim porcentaje As Double = value.Cells("PorcentajeEje").Value

            _IdProcessAxes = objsql.ERP_StrategicPlan_InserProcessAxes(_IdProcess, idAxes, porcentaje)

            If _IdProcessAxes > 0 Then
                For Each ResultadoInfo As DataGridViewRow In DG_Result.SelectedRows
                    Dim IdResultado As Long = ResultadoInfo.Cells("ID").Value
                    porcentaje = ResultadoInfo.Cells("PorcentajeResult").Value

                    Dim _IdProcessAxesResultado As Integer = objsql.ERP_StrategicPlan_InserProcessResult(_IdProcessAxes, IdResultado, porcentaje, _IdProcess)
                    Dim Resp As Integer = 0
                    If _IdProcessAxesResultado > 0 Then
                        Try
                            If (DG_Indicadores.Rows.Count <= 0) Then
                                Resp = _IdProcessAxesResultado
                            Else
                                For Each ResultadoIndi As DataGridViewRow In DG_Indicadores.Rows
                                    Dim IdIndicador As Long = ResultadoIndi.Cells("IdIndi").Value
                                    porcentaje = ResultadoIndi.Cells("PorcentajeIndicadores").Value

                                    Resp = objsql.ERP_StrategicPlan_InserProcessIndicator(_IdProcessAxesResultado, IdIndicador, porcentaje, _IdProcess, IdResultado)
                                Next
                            End If
                        Catch ex As Exception

                        End Try
                        If Resp > 0 Then
                            If bandera > 0 Then
                                MessageBox.Show("Registro Editado con Exito", "Ingreso  Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Else
                                MessageBox.Show("Registro ingresado con Exito", "Ingreso  Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            End If
                        Else
                            MessageBox.Show("Ocurrio un Erro por favor intente de nuevo", "Error al Procesar", MessageBoxButtons.OK, MessageBoxIcon.Error)

                        End If
                    End If
                Next
            End If

        Next

    End Sub

    Private Sub txt_Quinquenio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_Quinquenio.KeyPress
        If Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub DG_Ejes_Click(sender As Object, e As EventArgs) Handles DG_Ejes.Click
        If DG_Ejes.CurrentRow IsNot Nothing Then
            Dim _idEje As Long = DG_Ejes.CurrentRow.Cells("ID_ProcessAxes").Value
            Dim _idEjeaddd As Long = DG_Ejes.CurrentRow.Cells("IDStrategicAxes").Value
            GetResult(_idEje, _idEjeaddd)
        End If
    End Sub

    Private Sub DG_Result_Click(sender As Object, e As EventArgs) Handles DG_Result.Click
        If DG_Result.SelectedRows IsNot Nothing Then
            Try
                Dim _idResult As Long = DG_Result.CurrentRow.Cells("Id").Value
                Dim _idEje As Long = DG_Ejes.CurrentRow.Cells("ID_ProcessAxes").Value
                GetIndicator(_idResult, _idEje)
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub DG_Ejes_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DG_Ejes.CellEndEdit
        If Not IsNumeric(DG_Ejes.Rows(e.RowIndex).Cells("PorcentajeEje").Value) Then
            DG_Ejes.Rows(e.RowIndex).Cells("PorcentajeEje").Value = 0
        End If
    End Sub

    Private Sub DG_Result_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DG_Result.CellEndEdit
        If Not IsNumeric(DG_Result.Rows(e.RowIndex).Cells("PorcentajeResult").Value) Then
            DG_Result.Rows(e.RowIndex).Cells("PorcentajeResult").Value = 0
        End If
    End Sub

    Private Sub DG_Indicadores_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DG_Indicadores.CellEndEdit
        If Not IsNumeric(DG_Indicadores.Rows(e.RowIndex).Cells("PorcentajeIndicadores").Value) Then
            DG_Indicadores.Rows(e.RowIndex).Cells("PorcentajeIndicadores").Value = 0
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If DG_Result.SelectedRows IsNot Nothing Then
            Try
                Dim _idResult As Long = DG_Result.CurrentRow.Cells("ID_ProcessResult").Value
                Dim _idResultAdd As Long = DG_Result.CurrentRow.Cells("ID").Value

                Using obj As New PorcentajeAccionesEstrategicas
                    obj._id_Result = _idResultAdd
                    obj._Anio = Convert.ToInt32(txt_Quinquenio.Text.ToString.Split(" - ")(0).ToString.Trim)
                    obj.ShowDialog()
                End Using

            Catch ex As Exception
                'MessageBox.Show("Prueba" & ex.ToString)
            End Try

        End If
    End Sub

    Private Sub txt_Quinquenio_TextChanged(sender As Object, e As EventArgs) Handles txt_Quinquenio.TextChanged
        Try
            If IsNumeric(txt_Quinquenio.Text.ToString) Then
                lblAnio.Text = " - " & (Convert.ToInt32(txt_Quinquenio.Text.ToString) + 4).ToString
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class