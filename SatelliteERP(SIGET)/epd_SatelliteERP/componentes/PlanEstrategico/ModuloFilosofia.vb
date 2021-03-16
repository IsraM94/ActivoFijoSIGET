Public Class ModuloFilosofia
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

    Private Sub ModuloUsers_Load(sender As Object, e As EventArgs) Handles Me.Load
        GetInstitutionalPhilosophy()

        OpcionesMenu = objSql2.GetAccessMenu(_UserSQL)
        _VerTodos = False
        _Id_DptoPlani = 0
        If (OpcionesMenu.Rows.Count > 0) Then
            For Each DataInfo As DataRow In OpcionesMenu.Rows


                If (DataInfo("rolUser").ToString.ToUpper = "PLA_Planificacion_FIL_A_VerFilosofia".ToUpper) Then
                    cmdVerFilosofiaInstitucional.Visible = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "PLA_Planificacion_FIL_B_AgregarFilosofia".ToUpper) Then
                    cmdAgregarFilosofiaInstitucional.Visible = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "PLA_Planificacion_FIL_C_ModificarFilosofia".ToUpper) Then
                    cmdModificarFilosofiaInstitucional.Visible = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "PLA_Planificacion_FIL_D_EliminarFilosofia".ToUpper) Then
                    cmdEliminarFilosofiaInstitucional.Visible = True
                End If

                If (DataInfo("rolUser").ToString.ToUpper = "PLA_Planificacion_VerTodo".ToString.ToUpper) Then
                    _VerTodos = True
                End If

            Next
        End If

        If Not _VerTodos Then
            _Id_DptoPlani = _Id_DepartmentGlobal

        End If

        If _VerTodos Then
            cmdAgregarFilosofiaInstitucional.Visible = True
            cmdModificarFilosofiaInstitucional.Visible = True
            cmdEliminarFilosofiaInstitucional.Visible = True
        End If
    End Sub

    Sub CargarCombo(ByVal Combo As ComboBox, ByVal Dt As DataTable)
        Combo.DataSource = Dt
        Combo.DisplayMember = "Name"
        Combo.ValueMember = "Id_Deparment"

    End Sub
    Private Sub tabMantenimientos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tabPlanificacion.SelectedIndexChanged
        If sender.SelectedTab.Name = "TabPageFilosofiaInstitucional" Then
            GetInstitutionalPhilosophy()
        End If
    End Sub

    Private Sub GetInstitutionalPhilosophy()
        Using objDatos As New POA_SQLServer
            Try
                dtInstitutionalPhilosophy = objDatos.ERP_StrategicPlan_GetInstitutionalPhilosophy()
                If dtInstitutionalPhilosophy IsNot Nothing Then
                    DG_Filosofia.AutoGenerateColumns = False
                    DG_Filosofia.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
                    DG_Filosofia.Font = New Font("Segoe UI", 11)
                    DG_Filosofia.RowHeadersVisible = False
                    DG_Filosofia.Columns(0).Width = 100
                    DG_Filosofia.Columns(1).Width = 500
                    DG_Filosofia.Columns(2).Width = 500
                    DG_Filosofia.Columns(3).Width = 125
                    DG_Filosofia.Columns(3).DefaultCellStyle.Format = "yyyy/MM/dd HH:mm:ss"
                    DG_Filosofia.Columns(4).Width = 125
                    DG_Filosofia.Columns(5).Width = 125

                    DG_Filosofia.ReadOnly = True
                    DG_Filosofia.SelectionMode = DataGridViewSelectionMode.FullRowSelect
                    DG_Filosofia.MultiSelect = False

                    DG_Filosofia.AllowUserToResizeColumns = False
                    DG_Filosofia.AllowUserToAddRows = False
                    DG_Filosofia.AllowUserToDeleteRows = False
                    DG_Filosofia.DataSource = dtInstitutionalPhilosophy
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

    Private Sub cmdAgregarFilosofiaInstitucional_Click(sender As Object, e As EventArgs) Handles cmdAgregarFilosofiaInstitucional.Click
        Using obj As New POA_InsertFilosofiaInstitucional
            obj._isInsert = true 
            obj._View = False
            If obj.ShowDialog() = DialogResult.OK Then
                GetInstitutionalPhilosophy()
            End If
        End Using
    End Sub

    Private Sub cmdModificarFilosofiaInstitucional_Click(sender As Object, e As EventArgs) Handles cmdModificarFilosofiaInstitucional.Click
        Try
            Using obj As New POA_InsertFilosofiaInstitucional
                'obj.GroupBox1.Text = "Configuración Modificar Usuarios"
                obj._isInsert = False
                obj._View = False
                obj._id_Philosophy = DG_Filosofia.CurrentRow.Cells("ID_InstitutionalPhilosophy").Value
                obj._mision = DG_Filosofia.CurrentRow.Cells("Mision").Value
                obj._vision = DG_Filosofia.CurrentRow.Cells("Vision").Value
                obj._valores = DG_Filosofia.CurrentRow.Cells("Valores").Value
                If obj.ShowDialog() = DialogResult.OK Then
                    GetInstitutionalPhilosophy()
                End If
            End Using
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmdEliminarFilosofiaInstitucional_Click(sender As Object, e As EventArgs) Handles cmdEliminarFilosofiaInstitucional.Click
        Try
            Dim mensaje As String = "¿Está seguro(a) que quiere eliminar La Filosofia Institucional   : " & vbCrLf &
             "Nombre : " & DG_Filosofia.CurrentRow.Cells(1).Value & vbCrLf & "?"
            If MessageBox.Show(mensaje, Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                If objSqlDB.EERP_StrategicPlan_DeleteInstitutionalPhilosophy(DG_Filosofia.CurrentRow.Cells(0).Value) = "OK" Then
                    GetInstitutionalPhilosophy()
                Else
                    MessageBox.Show("Error en eliminación la Filosofia Institucional.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmdVerFilosofiaInstitucional_Click(sender As Object, e As EventArgs) Handles cmdVerFilosofiaInstitucional.Click
        Try
            Using obj As New POA_InsertFilosofiaInstitucional
                obj._isInsert = False
                obj._View = True
                obj._id_Philosophy = DG_Filosofia.CurrentRow.Cells("ID_InstitutionalPhilosophy").Value
                obj._mision = DG_Filosofia.CurrentRow.Cells("Mision").Value
                obj._vision = DG_Filosofia.CurrentRow.Cells("Vision").Value
                obj._valores = DG_Filosofia.CurrentRow.Cells("Valores").Value
                If obj.ShowDialog() = DialogResult.OK Then
                    GetInstitutionalPhilosophy()
                End If
            End Using
        Catch ex As Exception

        End Try
    End Sub
End Class
