Public Class ERP_MenuMetro

    Private Sub pbRestore_Click(sender As Object, e As EventArgs)
        End
    End Sub
    Private Sub TimerColorChange_Tick(sender As Object, e As EventArgs) Handles TimerColorChange.Tick
        If pnlFinansas.BackColor = System.Drawing.Color.FromArgb(69, 119, 186) Then
            pnlFinansas.BackColor = System.Drawing.Color.FromArgb(24, 105, 153)
            pnlInventory.BackColor = System.Drawing.Color.FromArgb(19, 120, 189)
            pnlRRHH.BackColor = System.Drawing.Color.FromArgb(95, 177, 245)
            pnlPlanificacion.BackColor = System.Drawing.Color.FromArgb(7, 70, 122)
            pnlAccounts.BackColor = System.Drawing.Color.FromArgb(50, 104, 169)
        ElseIf pnlFinansas.BackColor = System.Drawing.Color.FromArgb(24, 105, 153) Then
            pnlFinansas.BackColor = System.Drawing.Color.FromArgb(50, 104, 169)
            pnlInventory.BackColor = System.Drawing.Color.FromArgb(24, 105, 153)
            pnlRRHH.BackColor = System.Drawing.Color.FromArgb(95, 177, 245)
            pnlPlanificacion.BackColor = System.Drawing.Color.FromArgb(24, 105, 153)
            pnlAccounts.BackColor = System.Drawing.Color.FromArgb(95, 177, 245)
            BackColor = Color.FromArgb(27, 60, 80)
        ElseIf pnlFinansas.BackColor = System.Drawing.Color.FromArgb(50, 104, 169) Then
            pnlFinansas.BackColor = System.Drawing.Color.FromArgb(95, 177, 245)
            pnlInventory.BackColor = System.Drawing.Color.FromArgb(95, 177, 245)
            pnlRRHH.BackColor = System.Drawing.Color.FromArgb(50, 104, 169)
            pnlPlanificacion.BackColor = System.Drawing.Color.FromArgb(95, 177, 245)
            pnlAccounts.BackColor = System.Drawing.Color.FromArgb(7, 70, 122)
        ElseIf pnlFinansas.BackColor = System.Drawing.Color.FromArgb(95, 177, 245) Then
            pnlFinansas.BackColor = System.Drawing.Color.FromArgb(7, 70, 122)
            pnlInventory.BackColor = System.Drawing.Color.FromArgb(95, 177, 245)
            pnlRRHH.BackColor = System.Drawing.Color.FromArgb(50, 104, 169)
            pnlPlanificacion.BackColor = System.Drawing.Color.FromArgb(24, 105, 153)
            pnlAccounts.BackColor = System.Drawing.Color.FromArgb(69, 119, 186)
        Else
            pnlFinansas.BackColor = System.Drawing.Color.FromArgb(69, 119, 186)
            pnlInventory.BackColor = System.Drawing.Color.FromArgb(224, 225, 227)
            pnlRRHH.BackColor = System.Drawing.Color.FromArgb(7, 70, 122)
            pnlPlanificacion.BackColor = System.Drawing.Color.FromArgb(69, 119, 186)
            pnlAccounts.BackColor = System.Drawing.Color.FromArgb(50, 104, 169)
            BackColor = Color.FromArgb(53, 77, 91)
        End If
    End Sub
    Private Sub TimerClock_Tick(sender As Object, e As EventArgs) Handles TimerClock.Tick
        If Now.DayOfWeek = 0 Then
            LabelClockNameDay.Text = "Domingo"
        ElseIf Now.DayOfWeek = 1 Then
            LabelClockNameDay.Text = "Lunes"
        ElseIf Now.DayOfWeek = 2 Then
            LabelClockNameDay.Text = "Martes"
        ElseIf Now.DayOfWeek = 3 Then
            LabelClockNameDay.Text = "Miercoles"
        ElseIf Now.DayOfWeek = 4 Then
            LabelClockNameDay.Text = "Jueves"
        ElseIf Now.DayOfWeek = 5 Then
            LabelClockNameDay.Text = "Viernes"
        ElseIf Now.DayOfWeek = 6 Then
            LabelClockNameDay.Text = "Sabado"
        End If
        LabelClockNumberDay.Text = Now.Day
        LabelClockDate.Text = Now.ToString("MMMM").ToUpper & ", " & Now.Year
        LabelClockHours.Text = Now.ToString("HH:mm:ss") & " Horas"
    End Sub

    Friend Function DataCenter() As String
        ' Return _CadenaConexion
        Return My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Epdsoft\SatelliteERP", "ConnectionStrings", "Error") REM trae el valor del regedit
        Dim a As String = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Retail Pro\Epdsoft", "ConnectionStrings", "Error")
    End Function
    Private Sub ERP_MenuMetro_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim Parammargencod As Integer
        Dim Parammargensup As Integer
        Try

            Parammargencod = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Epdsoft\SatelliteERP", "Parammargencod", "Error")
        Catch ex As Exception
            MessageBox.Show("Problema con parametro de Barras", "Error de parametros", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End
        End Try

        Try

            Parammargensup = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Epdsoft\SatelliteERP", "Parammargensup", "Error")
        Catch ex As Exception
            MessageBox.Show("Problema con parametro de Barras", "Error de parametros", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End
        End Try

        _Parammargencod = Parammargencod
        _Parammargensup = Parammargensup

        Using obj As New LoginForm
            obj.StartPosition = FormStartPosition.CenterParent
            If Not obj.ShowDialog = DialogResult.OK Then
                Exit Sub
            Else
                Dim conexion As String = DataCenter()

                'conexion = conexion.Replace("[user]", _User)
                'conexion = conexion.Replace("[password]", _Password)
                My.Settings.Item("EPD_SatelliteERPConnectionString") = conexion
                My.Settings.Item("SatelliteERP_InventarioConnectionString") = conexion
            End If
        End Using
        Dim OpcionesMenu As DataTable
        Using objSql2 As New Generic_SQLServer
            OpcionesMenu = objSql2.GetAccessMenu(_UserSQL)
        End Using

        Dim IsPlanificacion As Boolean = False

        'Id_Department = _Id_DepartmentGlobal
        If (OpcionesMenu.Rows.Count > 0) Then
            For Each DataInfo As DataRow In OpcionesMenu.Rows
                If (DataInfo("rolUser").ToString.ToUpper = "MenuMetro_ActivoFijo".ToUpper) Then
                    pnlFinansas.Enabled = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "MenuMetro_Inventario".ToUpper) Then
                    pnlInventory.Enabled = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "MenuMetro_Usuario".ToUpper) Then
                    pnlUser.Enabled = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "MenuMetro_Configuracion".ToUpper) Then
                    pnlConfiguration.Enabled = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "MenuMetro_RecursosHumanos".ToUpper) Then
                    pnlRRHH.Enabled = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "MenuMetro_Respaldo".ToUpper) Then
                    pnlBackup.Enabled = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "Menu_Metro_All".ToUpper) Then

                    pnlFinansas.Enabled = True
                    pnlInventory.Enabled = True
                    pnlUser.Enabled = True
                    pnlConfiguration.Enabled = True
                    pnlRRHH.Enabled = True
                    pnlBackup.Enabled = True
                    pnlPlanificacion.Enabled = True
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "MenuMetro_Planificacion".ToUpper) Then
                    pnlPlanificacion.Enabled = True
                    IsPlanificacion = True
                End If
            Next
        End If
        Dim Bandera As Boolean = False

        Try
            If IsPlanificacion Then
                Dim dt As New DataTable
                Dim dt2 As New DataTable
                Using obj As New POA_SQLServer
                    dt = obj.ERP_StrategicPlan_GetStrategicActionsAlert(_Id_DepartmentGlobal)
                    dt2 = obj.ERP_StrategicPlan_GetStrategicActionsAlertOperational(_Id_DepartmentGlobal)
                End Using

                If Not IsNothing(dt) Then
                    If dt.Rows.Count > 0 Then
                        Bandera = True
                    End If
                End If

                If Not IsNothing(dt2) Then
                    If dt2.Rows.Count > 0 Then
                        Bandera = True
                    End If
                End If
                If Bandera Then
                    Using obj As New AlertaAcciones
                        obj.ShowDialog()
                    End Using
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub pnlFinansas_Click(sender As Object, e As EventArgs) Handles pnlFinansas.Click
        Using objView As New Fina_Procesos
            objView.ShowDialog()
        End Using
    End Sub

    Private Sub pnlEmployees_Click(sender As Object, e As EventArgs) Handles pnlInventory.Click
        Using objView As New Operacion_Procesos
            objView.StartPosition = FormStartPosition.CenterParent

            objView.ShowDialog()
        End Using
    End Sub

    Private Sub pnlRRHH_Click(sender As Object, e As EventArgs) Handles pnlRRHH.Click
        Using objView As New RRHH_Procesos
            objView.StartPosition = FormStartPosition.CenterParent
            objView.ShowDialog()
        End Using
    End Sub

    Private Sub pnlUser_Click(sender As Object, e As EventArgs) Handles pnlUser.Click
        Using obj As New Generic_User
            obj.StartPosition = FormStartPosition.CenterParent
            obj.ShowDialog()
        End Using
    End Sub

    Private Sub pnlConfiguration_Click(sender As Object, e As EventArgs) Handles pnlConfiguration.Click
        Using objView As New Generic_Process
            objView.ShowDialog()
        End Using
    End Sub

    Private Sub pnlBackup_Click(sender As Object, e As EventArgs) Handles pnlBackup.Click
        Using obj As New Backup_Respaldos
            obj.StartPosition = FormStartPosition.CenterParent
            obj.ShowDialog()
        End Using
    End Sub

    Private Sub pnlRestore_Click(sender As Object, e As EventArgs) Handles pnlRestore.Click
        Close()
    End Sub

    Private Sub pnlPlanificacion_Click(sender As Object, e As EventArgs) Handles pnlPlanificacion.Click
        Try
            Using objForm As New POA_Mantenimientos
                objForm.ShowDialog()
            End Using
        Catch ex As Exception

        End Try
    End Sub
End Class