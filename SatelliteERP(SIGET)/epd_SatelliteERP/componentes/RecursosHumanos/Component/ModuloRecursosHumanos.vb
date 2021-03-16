Imports System.IO

Public Class ModuloRecursosHumanos
    Private objFinance As New Financiero_SQLServer
    Private objGeneric As New Generic_SQLServer
    Private _DT_Employee As DataTable
    Private _tableInvoiceHeader As DataTable
    Private _tableCustomer As DataTable
    Private _tableCustomerBalanceDue As DataTable
    Private _IsFacturacion As Boolean = False
    Private _ID_Employees As Long
    Private objSql2 As New Generic_SQLServer

    Private OpcionesMenu As DataTable


    REM Aplicar roles
    Public Sub AplicarRoles()

        tcMain.TabPages.Remove(NominaEmpleados)
        tcMain.TabPages.Remove(Departamentos)
        tcMain.TabPages.Remove(WorkPosition)
        tcMain.TabPages.Remove(UbicacionEmpleados)


        OpcionesMenu = objSql2.GetAccessMenu(_UserSQL)
        If (OpcionesMenu.Rows.Count > 0) Then
            For Each DataInfo As DataRow In OpcionesMenu.Rows


                If (DataInfo("rolUser").ToString.ToUpper = "MN_RRHH_MenuVer_Empleados".ToUpper) Then
                    tcMain.TabPages.Add(NominaEmpleados)
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "MN_RRHH_MenuVer_Departamentos".ToUpper) Then
                    tcMain.TabPages.Add(Departamentos)
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "MN_RRHH_MenuVer_PosicionTrabajo".ToUpper) Then
                    tcMain.TabPages.Add(WorkPosition)
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "MN_RRHH_MenuVer_Ubicacion".ToUpper) Then
                    tcMain.TabPages.Add(UbicacionEmpleados)
                End If

                If (DataInfo("rolUser").ToString.ToUpper = "RH_Departamentos_CrearDepartamento".ToUpper) Then
                    cmdCreateDepartment.Visible = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "RH_Departamentos_EliminarDepartamento".ToUpper) Then
                    cmdDeleteDepartment.Visible = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "RH_Departamentos_ModificarDepartamento".ToUpper) Then
                    cmdModifyDepartment.Visible = True
                End If

                If (DataInfo("rolUser").ToString.ToUpper = "RH_Empleados_CrearEmpleado".ToUpper) Then
                    Button1.Visible = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "RH_Empleados_EliminarEmpleado".ToUpper) Then
                    Button3.Visible = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "RH_Empleados_ModificarEmpleado".ToUpper) Then
                    Button2.Visible = True
                End If

                If (DataInfo("rolUser").ToString.ToUpper = "RH_PosicionTrabajo_CrearPosicionTrabajo".ToUpper) Then
                    cmbCreateWorkPosition.Visible = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "RH_PosicionTrabajo_EliminarPosicionTrabajo".ToUpper) Then
                    cmbEliminarWorkPosition.Visible = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "RH_PosicionTrabajo_ModificarPosicionTrabajo".ToUpper) Then
                    cmbActualizarWorkPosition.Visible = True
                End If

                If (DataInfo("rolUser").ToString.ToUpper = "RH_Ubicacion_CrearUbicacion".ToUpper) Then
                    cmdCrearUbicacion.Visible = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "RH_Ubicacion_EliminarUbicacion".ToUpper) Then
                    cmdEliminarUbicacion.Visible = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "RH_Ubicacion_ModificarUbicacion".ToUpper) Then
                    cmdModificarUbicacion.Visible = True
                End If

            Next
        End If
    End Sub
    Private Sub tcMain_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tcMain.SelectedIndexChanged
        If sender.SelectedTab.Name = "NominaEmpleados" Then
            GetEmpleados()
        ElseIf sender.SelectedTab.Name = "Departamentos" Then
            GetDepartamentos()
        ElseIf sender.SelectedTab.Name = "WorkPosition" Then
            GetWorkPosition()
        ElseIf sender.SelectedTab.Name = "UbicacionEmpleados" Then
            GetWorkLocation()

            'ElseIf sender.SelectedTab.Name = "DepartamentosEmpresa" Then
            '    GetDepartamentos()
        End If
    End Sub
    Private Sub GetEmpleados()
        Try

            _DT_Employee = objGeneric.GetEmployee(Data_Id_Company)
            If _DT_Employee IsNot Nothing Then
                dgvemployee.AutoGenerateColumns = False
                dgvemployee.Font = New Font("Segoe UI", 11)
                dgvemployee.ReadOnly = True
                dgvemployee.SelectionMode = DataGridViewSelectionMode.FullRowSelect
                dgvemployee.MultiSelect = False
                dgvemployee.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
                'dgvemployee.AllowUserToResizeColumns = False
                dgvemployee.AllowUserToAddRows = False
                dgvemployee.AllowUserToDeleteRows = False
                'dgvemployee.DataSource = _tableInvoiceHeader


                ' dgvemployee.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                ' dgvemployee.Columns("Id_Employee").Visible = False
                dgvemployee.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight

                dgvemployee.Columns("Id_Company_FK").Visible = False
                dgvemployee.Columns("Id_Department_FK").Visible = False
                dgvemployee.Columns("Id_WorkPosition_FK").Visible = False
                dgvemployee.Columns("Id_LocationJob_FK").Visible = False
                dgvemployee.DataSource = _DT_Employee
            End If
        Catch ex As Exception
            MessageBox.Show("Ocurrió un problema mientras se procesaba la información", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    ' busqueda de empleado rey
    Private Sub GetEmpleados(ByVal busqueda As String)
        Try
            _DT_Employee = objGeneric.GetEmployee(Data_Id_Company, busqueda)
            If _DT_Employee IsNot Nothing Then
                dgvemployee.AutoGenerateColumns = False
                dgvemployee.Font = New Font("Segoe UI", 11)
                dgvemployee.ReadOnly = True
                dgvemployee.SelectionMode = DataGridViewSelectionMode.FullRowSelect
                dgvemployee.MultiSelect = False
                dgvemployee.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
                'dgvemployee.AllowUserToResizeColumns = False
                dgvemployee.AllowUserToAddRows = False
                dgvemployee.AllowUserToDeleteRows = False
                'dgvemployee.DataSource = _tableInvoiceHeader


                ' dgvemployee.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                ' dgvemployee.Columns("Id_Employee").Visible = False
                dgvemployee.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight

                dgvemployee.Columns("Id_Company_FK").Visible = False
                dgvemployee.Columns("Id_Department_FK").Visible = False
                dgvemployee.Columns("Id_WorkPosition_FK").Visible = False
                dgvemployee.Columns("Id_LocationJob_FK").Visible = False
                dgvemployee.DataSource = _DT_Employee
            End If
        Catch ex As Exception
            MessageBox.Show("Ocurrió un problema mientras se procesaba la información", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Private Sub GetDepartamentos(ByVal busqueda As String)
        _tableCustomer = objGeneric.ERP_RRHH_GetDepartment(Data_Id_Company, busqueda)
        dgvDepartamentos.AutoGenerateColumns = False
        dgvDepartamentos.Font = New Font("Segoe UI", 11)
        dgvDepartamentos.Columns(0).Width = 87
        dgvDepartamentos.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight

        dgvDepartamentos.Columns(1).Width = 350
        dgvDepartamentos.Columns(2).Width = 160
        dgvDepartamentos.Columns(3).Width = 160
        dgvDepartamentos.Columns(4).Width = 160
        dgvDepartamentos.Columns(5).Width = 180
        dgvDepartamentos.ReadOnly = True
        dgvDepartamentos.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvDepartamentos.MultiSelect = False
        dgvDepartamentos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
        'dgvDepartamentos.AllowUserToResizeColumns = False
        dgvDepartamentos.AllowUserToAddRows = False
        dgvDepartamentos.AllowUserToDeleteRows = False
        dgvDepartamentos.DataSource = _tableInvoiceHeader

        dgvDepartamentos.DataSource = _tableCustomer
    End Sub

    Private Sub GetDepartamentos()
        _tableCustomer = objGeneric.ERP_RRHH_GetDepartment(Data_Id_Company)
        dgvDepartamentos.AutoGenerateColumns = False
        dgvDepartamentos.Font = New Font("Segoe UI", 11)
        dgvDepartamentos.Columns(0).Width = 87
        dgvDepartamentos.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight

        dgvDepartamentos.Columns(1).Width = 350
        dgvDepartamentos.Columns(2).Width = 160
        dgvDepartamentos.Columns(3).Width = 160
        dgvDepartamentos.Columns(4).Width = 160
        dgvDepartamentos.Columns(5).Width = 180
        dgvDepartamentos.ReadOnly = True
        dgvDepartamentos.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvDepartamentos.MultiSelect = False
        dgvDepartamentos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
        'dgvDepartamentos.AllowUserToResizeColumns = False
        dgvDepartamentos.AllowUserToAddRows = False
        dgvDepartamentos.AllowUserToDeleteRows = False
        dgvDepartamentos.DataSource = _tableInvoiceHeader

        dgvDepartamentos.DataSource = _tableCustomer
    End Sub

    Private Sub GetWorkPosition()
        _tableCustomer = objGeneric.ERP_RRHH_GetWorkPosition(Data_Id_Company)
        dgvWorkPosition.AutoGenerateColumns = False
        dgvWorkPosition.Font = New Font("Segoe UI", 11)
        dgvWorkPosition.Columns(0).Width = 120
        dgvWorkPosition.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight

        dgvWorkPosition.Columns(1).Width = 350
        dgvWorkPosition.Columns(2).Width = 350
        dgvWorkPosition.Columns(3).Width = 180
        dgvWorkPosition.Columns(4).Width = 180
        dgvWorkPosition.Columns(5).Width = 180
        dgvWorkPosition.Columns(6).Width = 180
        dgvWorkPosition.ReadOnly = True
        dgvWorkPosition.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvWorkPosition.MultiSelect = False
        dgvWorkPosition.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
        ' dgvWorkPosition.AllowUserToResizeColumns = False
        dgvWorkPosition.AllowUserToAddRows = False
        dgvWorkPosition.AllowUserToDeleteRows = False
        dgvWorkPosition.DataSource = _tableInvoiceHeader

        dgvWorkPosition.DataSource = _tableCustomer
    End Sub

    Private Sub GetWorkPosition(ByVal busqueda As String)
        _tableCustomer = objGeneric.ERP_RRHH_GetWorkPosition(Data_Id_Company, busqueda)
        dgvWorkPosition.AutoGenerateColumns = False
        dgvWorkPosition.Font = New Font("Segoe UI", 11)
        dgvWorkPosition.Columns(0).Width = 120
        dgvWorkPosition.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight

        dgvWorkPosition.Columns(1).Width = 350
        dgvWorkPosition.Columns(2).Width = 350
        dgvWorkPosition.Columns(3).Width = 180
        dgvWorkPosition.Columns(4).Width = 180
        dgvWorkPosition.Columns(5).Width = 180
        dgvWorkPosition.Columns(6).Width = 180
        dgvWorkPosition.ReadOnly = True
        dgvWorkPosition.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvWorkPosition.MultiSelect = False
        dgvWorkPosition.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
        ' dgvWorkPosition.AllowUserToResizeColumns = False
        dgvWorkPosition.AllowUserToAddRows = False
        dgvWorkPosition.AllowUserToDeleteRows = False
        dgvWorkPosition.DataSource = _tableInvoiceHeader

        dgvWorkPosition.DataSource = _tableCustomer
    End Sub

    Private Sub GetWorkLocation()
        _tableCustomer = objGeneric.ERP_RRHH_GetLocation(Data_Id_Company)
        dgvWorkLocation.AutoGenerateColumns = False
        dgvWorkLocation.Font = New Font("Segoe UI", 11)

        dgvWorkLocation.Columns(0).Width = 120
        dgvWorkLocation.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight

        dgvWorkLocation.Columns(1).Width = 350
        dgvWorkLocation.Columns(2).Width = 350
        dgvWorkLocation.Columns(3).Width = 160
        dgvWorkLocation.Columns(4).Width = 180
        dgvWorkLocation.Columns(5).Width = 160
        dgvWorkLocation.Columns(6).Width = 180
        dgvWorkLocation.ReadOnly = True
        dgvWorkLocation.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvWorkLocation.MultiSelect = False
        dgvWorkLocation.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
        'dgvWorkLocation.AllowUserToResizeColumns = False
        dgvWorkLocation.AllowUserToAddRows = False
        dgvWorkLocation.AllowUserToDeleteRows = False

        dgvWorkLocation.DataSource = _tableCustomer
    End Sub

    Private Sub GetWorkLocation(ByVal busqueda As String)
        _tableCustomer = objGeneric.ERP_RRHH_GetLocation(Data_Id_Company, busqueda)
        dgvWorkLocation.AutoGenerateColumns = False
        dgvWorkLocation.Font = New Font("Segoe UI", 11)

        dgvWorkLocation.Columns(0).Width = 120
        dgvWorkLocation.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight

        dgvWorkLocation.Columns(1).Width = 350
        dgvWorkLocation.Columns(2).Width = 160
        dgvWorkLocation.Columns(3).Width = 160
        dgvWorkLocation.Columns(4).Width = 180
        dgvWorkLocation.Columns(5).Width = 160
        dgvWorkLocation.Columns(6).Width = 180
        dgvWorkLocation.ReadOnly = True
        dgvWorkLocation.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvWorkLocation.MultiSelect = False
        dgvWorkLocation.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
        'dgvWorkLocation.AllowUserToResizeColumns = False
        dgvWorkLocation.AllowUserToAddRows = False
        dgvWorkLocation.AllowUserToDeleteRows = False

        dgvWorkLocation.DataSource = _tableCustomer
    End Sub

    Private Sub ModuloRecursosHumanos_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Using ObjSql As New RecursosHumanos_MantoEmpleados
            ObjSql.OpcionSeleccionada = RecursosHumanos_MantoEmpleados.funcion.Agregar
            ObjSql.ShowDialog()
        End Using
        GetEmpleados()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If dgvemployee.CurrentRow IsNot Nothing Then
            Using ObjUpdate As New RecursosHumanos_MantoEmpleados
                ObjUpdate.OpcionSeleccionada = RecursosHumanos_MantoEmpleados.Funcion.Actualizar
                Try

                    ObjUpdate.Id_Employee = dgvemployee.CurrentRow.Cells("Id_Employee").Value
                    ObjUpdate.Id_Company = dgvemployee.CurrentRow.Cells("Id_Company_FK").Value
                    ObjUpdate.id_Deparment = dgvemployee.CurrentRow.Cells("Id_Department_FK").Value
                    ObjUpdate.Deparment = dgvemployee.CurrentRow.Cells("Departamento").Value
                    ObjUpdate.Id_WorkPosition = dgvemployee.CurrentRow.Cells("Id_WorkPosition_FK").Value
                    ObjUpdate.WorkPosition = dgvemployee.CurrentRow.Cells("Posicion").Value
                    ObjUpdate.Id_Location = dgvemployee.CurrentRow.Cells("Id_LocationJob_FK").Value
                    ObjUpdate.Locationn = dgvemployee.CurrentRow.Cells("Ubicacion").Value
                    ObjUpdate.Name_employee = dgvemployee.CurrentRow.Cells("Nombre").Value.ToString
                    ObjUpdate.IdPrimaryLocation = dgvemployee.CurrentRow.Cells("IdPrimaryLocation").Value.ToString

                    Try
                        ObjUpdate.LastName_Employee = dgvemployee.CurrentRow.Cells("Apellido").Value.ToString
                    Catch ex As Exception
                        ObjUpdate.LastName_Employee = ""
                    End Try

                    Try
                        ObjUpdate.Id_legacy = dgvemployee.CurrentRow.Cells("id_responsable").Value.ToString
                    Catch ex As Exception
                        ObjUpdate.Id_legacy = 0
                    End Try

                    Try
                        ObjUpdate.SecondSurname_employee = dgvemployee.CurrentRow.Cells("SegundoApellido").Value.ToString
                    Catch ex As Exception
                        ObjUpdate.SecondSurname_employee = ""
                    End Try

                    Try
                        ObjUpdate.ThridSurname_employee = dgvemployee.CurrentRow.Cells("TercerNombre").Value.ToString
                    Catch ex As Exception
                        ObjUpdate.ThridSurname_employee = ""
                    End Try
                    Try
                        ObjUpdate.SecondName_Employee = dgvemployee.CurrentRow.Cells("SegundoNombre").Value.ToString
                    Catch ex As Exception
                        ObjUpdate.SecondName_Employee = ""
                    End Try
                    Try
                        ObjUpdate.ThridName_Employee = dgvemployee.CurrentRow.Cells("TercerApellido").Value.ToString
                    Catch ex As Exception
                        ObjUpdate.ThridName_Employee = ""
                    End Try
                    Try
                        ObjUpdate.UserSiget = dgvemployee.CurrentRow.Cells("UserSiget").Value.ToString
                    Catch ex As Exception
                        ObjUpdate.UserSiget = ""
                    End Try
                    Try
                        ObjUpdate.JefeInmediato = dgvemployee.CurrentRow.Cells("Id_employee_Boss_FK").Value.ToString
                    Catch ex As Exception
                        ObjUpdate.JefeInmediato = -1
                    End Try
                    'ObjUpdate.JefeInmediato = dgvemployee.CurrentRow.Cells("JefeInmediato").Value

                    If IsDBNull(dgvemployee.CurrentRow.Cells("DUI").Value) Then
                        ObjUpdate.DUI = ""
                    Else
                        ObjUpdate.DUI = dgvemployee.CurrentRow.Cells("DUI").Value.ToString
                    End If
                    Try
                        ObjUpdate.Email = dgvemployee.CurrentRow.Cells("Email").Value.ToString
                    Catch ex As Exception
                        ObjUpdate.Email = ""
                    End Try
                    Try

                        ObjUpdate.Telephone = dgvemployee.CurrentRow.Cells("Telefono").Value.ToString
                    Catch ex As Exception

                    End Try
                    Try
                        ObjUpdate.Extension = dgvemployee.CurrentRow.Cells("Extension").Value.ToString
                    Catch ex As Exception
                    End Try
                    Try
                        ObjUpdate.Salary = dgvemployee.CurrentRow.Cells("Salario").Value.ToString
                    Catch ex As Exception
                    End Try
                    ObjUpdate.ShowDialog()
                    Catch ex As ArgumentException
                        MessageBox.Show("Ocurrió un problema mientras se procesaba la información", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Catch ex As Exception
                        MessageBox.Show("Ocurrió un problema mientras se procesaba la información", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
            GetEmpleados()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If dgvemployee.CurrentRow IsNot Nothing Then
            Using objSql As New Generic_SQLServer
                _ID_Employees = dgvemployee.CurrentRow.Cells("Id_Employee").Value
                '_Id_Company = dgvemployee.CurrentRow.Cells("Id_Company_FK").Value
                Dim Nombre As String = dgvemployee.CurrentRow.Cells("Nombre").Value
                Dim Apellido As String = dgvemployee.CurrentRow.Cells("Apellido").Value
                If MessageBox.Show("¿Desea eliminar al empleado " & Nombre & " " & Apellido & "?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    Dim resultado As String = objSql.DelEmpoloyee(_ID_Employees)
                    If resultado = "OK" Then
                        MessageBox.Show("El registro ha sido eliminado exitosamente", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                        GetEmpleados()
                    End If
                End If
            End Using
        End If
    End Sub

    Private Sub cmdCreateDepartment_Click(sender As Object, e As EventArgs) Handles cmdCreateDepartment.Click
        Using obj As New ERP_Mantenimiento_Departamentos
            If obj.ShowDialog() = DialogResult.OK Then
                GetDepartamentos()
            End If
        End Using
    End Sub

    Private Sub cmdModifyDepartment_Click(sender As Object, e As EventArgs) Handles cmdModifyDepartment.Click
        Using obj As New ERP_Mantenimiento_Departamentos
            'obj.GroupBox1.Text = "Configuración Modificar Usuarios"
            obj._isInsert = False
            obj.Title = "Actualizar Departamento"
            obj.id_Department = dgvDepartamentos.CurrentRow.Cells("Id_Deparment").Value
            obj.Name_Department = dgvDepartamentos.CurrentRow.Cells("Name_Deparmnet").Value
            obj.CodigoInterno = dgvDepartamentos.CurrentRow.Cells("InternalCode").Value.ToString
            If obj.ShowDialog() = DialogResult.OK Then
                GetDepartamentos()
            End If

        End Using
    End Sub

    Private Sub cmdDeleteDepartment_Click(sender As Object, e As EventArgs) Handles cmdDeleteDepartment.Click
        Dim mensaje As String = "¿Está seguro(a) que quiere eliminar el siguiente departamento: " & vbCrLf & dgvDepartamentos.CurrentRow.Cells(1).Value & "?" & vbCrLf

        If MessageBox.Show(mensaje, Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If objGeneric.ERP_RRHH_DelDeparment(dgvDepartamentos.CurrentRow.Cells(0).Value, Data_Id_Company) = "OK" Then
                GetDepartamentos()
            Else
                MessageBox.Show("Error en eliminación de Departamento.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub cmbCreateWorkPosition_Click(sender As Object, e As EventArgs) Handles cmbCreateWorkPosition.Click
        Using obj As New ERP_Mantenimiento_WorkPosition
            If obj.ShowDialog() = DialogResult.OK Then
                GetWorkPosition()
            End If
        End Using
    End Sub

    Private Sub cmbActualizarWorkPosition_Click(sender As Object, e As EventArgs) Handles cmbActualizarWorkPosition.Click
        Using obj As New ERP_Mantenimiento_WorkPosition
            obj.GroupBox1.Text = "Modificar Posición de Trabajo"
            obj._isInsert = False
            obj.id_Workposition = dgvWorkPosition.CurrentRow.Cells("Id_WorkPosition").Value
            Try
                obj.Name_WorkPosition = dgvWorkPosition.CurrentRow.Cells("Name_WorkPosition").Value
            Catch ex As Exception

            End Try

            Try
                obj.Is_CustomerService = dgvWorkPosition.CurrentRow.Cells("Is_CustomerService").Value
            Catch ex As Exception
                obj.Is_CustomerService = False
            End Try
            If obj.ShowDialog() = DialogResult.OK Then
                GetWorkPosition()
            End If

        End Using
    End Sub

    Private Sub cmbEliminarWorkPosition_Click(sender As Object, e As EventArgs) Handles cmbEliminarWorkPosition.Click
        Dim mensaje As String = "¿Está seguro(a) que quiere eliminar la siguiente posición de trabajo: " & vbCrLf & dgvWorkPosition.CurrentRow.Cells(1).Value & "?" & vbCrLf

        If MessageBox.Show(mensaje, Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If objGeneric.ERP_RRHH_DelWorkPosition(_ID_Company, dgvWorkPosition.CurrentRow.Cells(0).Value) = "OK" Then
                GetWorkPosition()
            Else
                MessageBox.Show("Error en eliminación posición de trabajo.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub cmdCrearUbicacion_Click(sender As Object, e As EventArgs) Handles cmdCrearUbicacion.Click
        Using obj As New ERP_Mantenimiento_WorkLocation
            If obj.ShowDialog() = DialogResult.OK Then
                GetWorkLocation()
            End If
        End Using
    End Sub

    Private Sub cmdModificarUbicacion_Click(sender As Object, e As EventArgs) Handles cmdModificarUbicacion.Click
        Using obj As New ERP_Mantenimiento_WorkLocation
            obj.GroupBox1.Text = "Modificar Ubicación de Trabajo"
            obj._isInsert = False
            obj.id_Worklocation = dgvWorkLocation.CurrentRow.Cells("Id_Location").Value
            obj.Name_WorkPosition = dgvWorkLocation.CurrentRow.Cells("Name_Location").Value
            obj.Name_WorkAddress = dgvWorkLocation.CurrentRow.Cells("Address_Location").Value
            Try
                obj.id_UbicacionPrimaria = dgvWorkLocation.CurrentRow.Cells("IdLocationPrimary").Value.ToString
            Catch ex As Exception
                obj.id_UbicacionPrimaria = 0
            End Try
            If obj.ShowDialog() = DialogResult.OK Then
                GetWorkLocation()
            End If

        End Using
    End Sub

    Private Sub cmdEliminarUbicacion_Click(sender As Object, e As EventArgs) Handles cmdEliminarUbicacion.Click
        Dim mensaje As String = "¿Está seguro(a) que quiere eliminar la siguiente Ubicación de trabajo: " & vbCrLf & dgvWorkLocation.CurrentRow.Cells(1).Value & "?" & vbCrLf

        If MessageBox.Show(mensaje, Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If objGeneric.ERP_RRHH_DelLocation(dgvWorkLocation.CurrentRow.Cells(0).Value, Data_Id_Company) = "OK" Then
                GetWorkLocation()
            Else
                MessageBox.Show("Error en eliminación Ubicación de trabajo.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub btnBuscarEmpleado_Click(sender As Object, e As EventArgs) Handles btnBuscarEmpleado.Click
        Using obj As New ERP_Financiero_BuscarActivo
            If obj.ShowDialog = DialogResult.OK Then
                GetEmpleados(obj.busqueda)
            Else
                GetEmpleados()
            End If
        End Using
    End Sub

    Private Sub btnBuscarDepartamento_Click(sender As Object, e As EventArgs) Handles btnBuscarDepartamento.Click
        Using obj As New ERP_Financiero_BuscarActivo
            If obj.ShowDialog = DialogResult.OK Then
                GetDepartamentos(obj.busqueda)

            Else
                GetDepartamentos()

            End If
        End Using
    End Sub

    Private Sub btnBuscarPosicionTrabajo_Click(sender As Object, e As EventArgs) Handles btnBuscarPosicionTrabajo.Click
        Using obj As New ERP_Financiero_BuscarActivo
            If obj.ShowDialog = DialogResult.OK Then
                GetWorkPosition(obj.busqueda)
            Else
                GetWorkPosition()
            End If
        End Using
    End Sub

    Private Sub btnBuscarUbicacion_Click(sender As Object, e As EventArgs) Handles btnBuscarUbicacion.Click
        Using obj As New ERP_Financiero_BuscarActivo
            If obj.ShowDialog = DialogResult.OK Then
                GetWorkLocation(obj.busqueda)
            Else
                GetWorkLocation()
            End If
        End Using
    End Sub

    Private Sub btnAllEmpleados_Click(sender As Object, e As EventArgs) Handles btnAllEmpleados.Click
        GetEmpleados()
    End Sub
End Class
