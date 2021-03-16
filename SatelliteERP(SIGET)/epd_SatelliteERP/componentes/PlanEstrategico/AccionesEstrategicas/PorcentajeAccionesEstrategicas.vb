Public Class PorcentajeAccionesEstrategicas

#Region "Properties"
    Private objsql As New POA_SQLServer
    Private dtObjetivos As New DataTable
    Private dtEjes As New DataTable
    Property _id_Result As Long
    Property _Anio As Long = 0
    Enum funcion
        Actualizar
        Agregar
    End Enum
    Property OpcionSeleccionada As funcion
#End Region

    Private Sub Config_InsertUserAccesos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetAccionesEstrategicas(_id_Result)
        Try
            DG_Acciones.Columns("Anio1").HeaderText = _Anio
            DG_Acciones.Columns("Anio2").HeaderText = _Anio + 1
            DG_Acciones.Columns("Anio3").HeaderText = _Anio + 2
            DG_Acciones.Columns("Anio4").HeaderText = _Anio + 3
            DG_Acciones.Columns("Anio5").HeaderText = _Anio + 4
        Catch ex As Exception

        End Try
    End Sub
    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub GetAccionesEstrategicas(ByVal Id_Resultado As Integer)
        Using objDatos As New POA_SQLServer
            Try
                dtEjes = objDatos.ERP_StrategicPlan_GetStrategicActionsResult(Id_Resultado)
                If dtEjes IsNot Nothing Then
                    DG_Acciones.AutoGenerateColumns = False
                    DG_Acciones.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
                    DG_Acciones.Font = New Font("Segoe UI", 11)
                    DG_Acciones.RowHeadersVisible = False
                    DG_Acciones.Columns(1).Width = 75
                    DG_Acciones.Columns(2).Width = 500

                    DG_Acciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect
                    DG_Acciones.MultiSelect = False

                    DG_Acciones.AllowUserToResizeColumns = False
                    DG_Acciones.AllowUserToAddRows = False
                    DG_Acciones.AllowUserToDeleteRows = False
                    DG_Acciones.DataSource = dtEjes
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

    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        Dim Bandera As Boolean = False
        Try
            Dim numero As Integer = 0
            For Each Accion As DataGridViewRow In DG_Acciones.Rows
                If ((Convert.ToDecimal(validarnumeros(Accion.Cells("Anio1").Value)) +
                    Convert.ToDecimal(validarnumeros(Accion.Cells("Anio2").Value)) +
                    Convert.ToDecimal(validarnumeros(Accion.Cells("Anio3").Value)) +
                    Convert.ToDecimal(validarnumeros(Accion.Cells("Anio4").Value)) +
                    Convert.ToDecimal(validarnumeros(Accion.Cells("Anio5").Value)))) <> 100 Then
                    DG_Acciones.Rows(numero).Selected = True
                    MessageBox.Show("Los porcentajes ingresados no suman el 100% para la Acción", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Bandera = True
                    Exit For
                End If
                numero += 1
            Next
        Catch ex As Exception
            Bandera = True
        End Try
        If bandera Then
            Exit Sub
        End If

        Try
            For Each Accion As DataGridViewRow In DG_Acciones.Rows

                objsql.ERP_StrategicPlan_UpdateStrategicActionsPercentage(Accion.Cells("Id_AccionP").Value, _id_Result, Accion.Cells("Anio1").Value.ToString, Accion.Cells("Anio2").Value.ToString, Accion.Cells("Anio3").Value.ToString, Accion.Cells("Anio4").Value.ToString, Accion.Cells("Anio5").Value.ToString)

            Next
            DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()
        Catch ex As Exception

        End Try
    End Sub


    Private Function validarnumeros(ByVal NUmero As String) As String
        Try
            Dim num As Integer = Convert.ToInt32(NUmero)
            If NUmero = "" Or NUmero.ToString.Trim = "" Then
                Return "0"
            Else
                If NUmero.ToString.Contains("$") Then
                    NUmero = NUmero.Replace("$", "").ToString.Trim
                End If
                Return NUmero
            End If
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Private Sub DG_Acciones_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DG_Acciones.CellValueChanged
        Try
            For Each DataInfo As DataGridViewRow In DG_Acciones.Rows

                DataInfo.Cells("TotalPro").Value = Convert.ToInt32(validarnumeros(DataInfo.Cells("Anio1").Value.ToString)) + Convert.ToInt32(validarnumeros(DataInfo.Cells("Anio2").Value.ToString)) + Convert.ToInt32(validarnumeros(DataInfo.Cells("Anio3").Value.ToString)) + Convert.ToInt32(validarnumeros(DataInfo.Cells("Anio4").Value.ToString)) + Convert.ToInt32(validarnumeros(DataInfo.Cells("Anio5").Value.ToString))
            Next
        Catch ex As Exception

        End Try
    End Sub
End Class