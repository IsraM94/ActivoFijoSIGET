Public Class ModuloUsers
    Private objUsersDB As New Generic_SQLServer
    Private AccessUserNameDT As DataTable
    Private dtDeparment As DataTable
    Private dtCollectingAgency As DataTable
    Private dtMunicipality As DataTable
    Private dtCountry As DataTable
    Private dtUnitMeasure As DataTable
    Private OpcionesMenu As DataTable
    Private objSql2 As New Generic_SQLServer


    Private _DT_Employee As DataTable
    Private Sub GetEmpleados()
        Try
            '_DT_Employee = objGeneric.GetEmployee(Data_Id_Company)
            If _DT_Employee IsNot Nothing Then
                DG_SystemUsers.AutoGenerateColumns = False
                DG_SystemUsers.Font = New Font("Segoe UI", 11)
                DG_SystemUsers.ReadOnly = True
                DG_SystemUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect
                DG_SystemUsers.MultiSelect = False
                DG_SystemUsers.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
                DG_SystemUsers.AllowUserToResizeColumns = False
                DG_SystemUsers.AllowUserToAddRows = False
                DG_SystemUsers.AllowUserToDeleteRows = False
                'dgvemployee.DataSource = _tableInvoiceHeader

                'dgvemployee.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                'dgvemployee.Columns("Id_Employee").Visible = False
                'dgvemployee.Columns("Id_Company_FK").Visible = False
                'dgvemployee.Columns("Id_Department_FK").Visible = False
                'dgvemployee.Columns("Id_WorkPosition_FK").Visible = False
                'dgvemployee.Columns("Id_LocationJob_FK").Visible = False
                'dgvemployee.DataSource = _DT_Employee
            End If
        Catch ex As Exception
            MessageBox.Show("Ocurrió un problema mientras se procesaba la información", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub ModuloUsers_Load(sender As Object, e As EventArgs) Handles Me.Load

        tabUsuarios.TabPages.Remove(TagPageUserAccess)
        tabUsuarios.TabPages.Remove(CambioPassword)

        OpcionesMenu = objSql2.GetAccessMenu(_UserSQL)

        If (OpcionesMenu.Rows.Count > 0) Then
            For Each DataInfo As DataRow In OpcionesMenu.Rows
                If (DataInfo("rolUser").ToString.ToUpper = "MN_USU_MenuVer_AccesoUsuarios".ToUpper) Then
                    tabUsuarios.TabPages.Add(TagPageUserAccess)
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "MN_USU_MenuVer_CambioPassword".ToUpper) Then
                    tabUsuarios.TabPages.Add(CambioPassword)
                End If

            Next
        End If

        GetAccessUserName()

    End Sub

    Private Sub cmdCreate_CategoryMaintenance_Click(sender As Object, e As EventArgs) Handles cmdAccessUsers.Click
        Using obj As New Config_UserAccess
            obj._username = DG_SystemUsers.CurrentRow.Cells("UserName").Value
            obj.ShowDialog()
        End Using
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles cmdModifyUsers.Click
        Try
            Using obj As New Config_InsertUserAccesos
                'obj.GroupBox1.Text = "Configuración Modificar Usuarios"
                obj._isInsert = False
                obj._id_username = DG_SystemUsers.CurrentRow.Cells("ID_UserName").Value
                obj._username = DG_SystemUsers.CurrentRow.Cells("UserName").Value
                obj._Rol = DG_SystemUsers.CurrentRow.Cells("idrol").Value.ToString
                obj._Empleado = DG_SystemUsers.CurrentRow.Cells("idempleado").Value.ToString
                obj.ShowDialog()
                If obj.Resp = "OK" Then
                    GetAccessUserName()
                ElseIf obj.Resp = "Cancel" Then
                    MessageBox.Show("El usuario que esta ingresando ya esta asociado a un empleado.", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Error al asignar el usuario, favor intente de nuevo.", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

            End Using
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles cmdCreateAccessUsers.Click
        Using obj As New Config_InsertUserAccesos
            obj._Rol = -1
            obj._Empleado = -1
            obj.ShowDialog()
            If obj.Resp = "OK" Then
                GetAccessUserName()
            ElseIf obj.Resp = "Cancel" Then
            Else
                MessageBox.Show("Error al crear el usuario, favor intente de nuevo.", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End Using
    End Sub


    Private Sub GetAccessUserName(Optional Busquedad As String = "")
        Using objDatos As New Generic_SQLServer
            Try
                AccessUserNameDT = objDatos.ERP_Config_GetAccessUserName(Busquedad)
                If AccessUserNameDT IsNot Nothing Then
                    DG_SystemUsers.AutoGenerateColumns = False
                    DG_SystemUsers.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
                    DG_SystemUsers.Font = New Font("Segoe UI", 11)
                    DG_SystemUsers.RowHeadersVisible = False
                    DG_SystemUsers.Columns(0).Width = 75
                    DG_SystemUsers.Columns(1).Width = 200
                    DG_SystemUsers.Columns(2).Width = 200
                    DG_SystemUsers.Columns(3).Width = 350
                    DG_SystemUsers.Columns(4).Width = 125
                    DG_SystemUsers.Columns(5).Width = 125
                    DG_SystemUsers.Columns(6).Width = 125
                    DG_SystemUsers.Columns(7).Width = 125

                    DG_SystemUsers.ReadOnly = True
                    DG_SystemUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect
                    DG_SystemUsers.MultiSelect = False

                    DG_SystemUsers.AllowUserToResizeColumns = False
                    DG_SystemUsers.AllowUserToAddRows = False
                    DG_SystemUsers.AllowUserToDeleteRows = False
                    DG_SystemUsers.DataSource = AccessUserNameDT
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

    Private Sub DeleteUsers_Click(sender As Object, e As EventArgs) Handles DeleteUsers.Click
        Try
            Dim mensaje As String = "¿Está seguro que quiere eliminar el siguiente usuario: " & vbCrLf &
                "Nombre : " & DG_SystemUsers.CurrentRow.Cells(1).Value & "?"

            If MessageBox.Show(mensaje, Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                If objUsersDB.ERP_Config_DeleteAccessUserName(DG_SystemUsers.CurrentRow.Cells(0).Value) = "OK" Then
                    GetAccessUserName()
                Else
                    MessageBox.Show("Error en eliminación de usuario.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DeactiveUsers_Click(sender As Object, e As EventArgs) Handles DeactiveUsers.Click

        Try
            Dim mensaje As String = "¿Está seguro que quiere desactivar el siguiente usuario: " & vbCrLf &
       "Nombre : " & DG_SystemUsers.CurrentRow.Cells(1).Value & "?"

            If MessageBox.Show(mensaje, Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                If objUsersDB.ERP_Config_DeactivateAccessUserName(DG_SystemUsers.CurrentRow.Cells(0).Value) = "OK" Then
                    GetAccessUserName()
                Else
                    MessageBox.Show("Error en desactivación de usuario.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        If txtPassActual.Text = "" Or txtPassActual.Text = " " Then
            MessageBox.Show("No puede dejar campos en blanco.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtPassActual.Focus()
            Exit Sub
        End If

        If txtNuevo.Text = "" Or txtNuevo.Text = " " Then
            MessageBox.Show("No puede dejar campos en blanco.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtNuevo.Focus()
            Exit Sub
        End If

        If txtConfirmarPassword.Text = "" Or txtConfirmarPassword.Text = " " Then
            MessageBox.Show("No puede dejar campos en blanco.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtConfirmarPassword.Focus()
            Exit Sub
        End If

        If (txtNuevo.Text.ToString.ToUpper <> txtConfirmarPassword.Text.ToString.ToUpper) Then
            MessageBox.Show("El password ingresado no es igual, favor verificar.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtConfirmarPassword.Focus()
            Exit Sub
        End If

        Dim dt As String = ""
        dt = objSql2.ERP_Config_UpdateAccessUserNamePassword(_Id_EmployeeGlobal, txtPassActual.Text, txtNuevo.Text.ToString, _UserSQL)

        If dt = "ERROR" Then
            MessageBox.Show("Error al cambiar el password, clave erronea.", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf dt = "ok" Then
            MessageBox.Show("Clave cambiada exitosamente.", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        txtConfirmarPassword.Text = ""
        txtNuevo.Text = ""
        txtPassActual.Text = ""
    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        txtConfirmarPassword.Text = ""
        txtNuevo.Text = ""
        txtPassActual.Text = ""
    End Sub

    Private Sub txtBusquedad_TextChanged(sender As Object, e As EventArgs) Handles txtBusquedad.TextChanged
        Try
            If txtBusquedad.Text.ToString.Length > 3 Then
                GetAccessUserName(txtBusquedad.Text.ToString.Trim)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtBusquedad_Enter(sender As Object, e As EventArgs) Handles txtBusquedad.Enter
        GetAccessUserName()
    End Sub
End Class
