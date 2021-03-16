Public Class Ficha_Resumida_activo
    Public Property UbicacionPrimaria As Long = 0
    Public Property UbicacionPrimariaText As String = 0
    Public Property UbicacionSecundaria As Long = 0
    Public Property UbicacionSecundariaText As String = 0
    Public Property Unidad As Long = 0
    Public Property UnidadText As String = 0
    Public Property Genrencia As Long = 0
    Public Property Responsable As Long = 0
    Public Property ResponsableText As String = 0
    Private Sub cmdEnviar_Click(sender As Object, e As EventArgs) Handles cmdEnviar.Click
        If cmb_UbicaconPrimaria.SelectedIndex = -1 And cmb_UbicaconSecundaria.SelectedIndex = -1 And cmb_Unidad.SelectedIndex = -1 And cmb_Responsable.SelectedIndex = -1 Then


            MessageBox.Show("Selecione almenos una opción", "información", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return
        End If

        UbicacionPrimaria = cmb_UbicaconPrimaria.SelectedValue
        UbicacionPrimariaText = cmb_UbicaconPrimaria.Text.ToString
        UbicacionSecundaria = cmb_UbicaconSecundaria.SelectedValue
        UbicacionSecundariaText = cmb_UbicaconSecundaria.Text.ToString


        Unidad = cmb_Unidad.SelectedValue
        UnidadText = cmb_Unidad.Text.ToString
        Responsable = cmb_Responsable.SelectedValue
        ResponsableText = cmb_Responsable.Text.ToString
        Me.DialogResult = DialogResult.OK
        Me.Close()

    End Sub

    Private Sub cmdCancelar_Click(sender As Object, e As EventArgs) Handles cmdCancelar.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub



    Private Sub LOadData()
        Dim dt As New DataTable
        Using obj As New Generic_SQLServer
            dt = obj.SP_ERP_Inventory_GetLocationPrimary()
        End Using
        cmb_UbicaconPrimaria.DataSource = dt
        cmb_UbicaconPrimaria.ValueMember = "ID_Location"
        cmb_UbicaconPrimaria.DisplayMember = "NameLocation"
        cmb_UbicaconPrimaria.SelectedIndex = -1


        'Dim dtS As New DataTable
        'Using obj As New Generic_SQLServer
        '    dtS = obj.SP_ERP_Inventory_GetLocationSecundary()
        'End Using
        'cmb_UbicaconSecundaria.DataSource = dtS
        'cmb_UbicaconSecundaria.ValueMember = "Id_Location"
        'cmb_UbicaconSecundaria.DisplayMember = "Name_Location"
        'cmb_UbicaconSecundaria.SelectedIndex = -1


        Dim dtu As New DataTable
        Using obj As New Generic_SQLServer
            dtu = obj.SP_ERP_Inventary_GetUnidadesOrganizativas()
        End Using
        cmb_Unidad.DataSource = dtu
        cmb_Unidad.ValueMember = "Id_Deparment"
        cmb_Unidad.DisplayMember = "Name_Deparmnet"
        cmb_Unidad.SelectedIndex = -1


        Dim dtr As New DataTable
        Using obj As New Generic_SQLServer
            dtr = obj.SP_ERP_Inventory_getEmpleadoResponsable(0)
        End Using
        cmb_Responsable.DataSource = dtr
        cmb_Responsable.ValueMember = "Id_employee"
        cmb_Responsable.DisplayMember = "LastName_employee"
        cmb_Responsable.SelectedIndex = -1



    End Sub

    Private Sub Ficha_Resumida_activo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LOadData()
    End Sub

    Public Event DropDownOpened As EventHandler

    Private abierto As Integer = 1
    Private abierto2 As Integer = 1

    Private Sub cmb_UbicaconPrimaria_DropDown(sender As Object, e As EventArgs) Handles cmb_UbicaconPrimaria.DropDown
        abierto2 = 0
    End Sub

    Private Sub cmb_UbicaconPrimaria_DropDownClosed(sender As Object, e As EventArgs) Handles cmb_UbicaconPrimaria.DropDownClosed
        abierto2 = 1
    End Sub

    Private Sub cmb_UbicaconPrimaria_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmb_UbicaconPrimaria.KeyPress
        If (abierto2 = 0) Then
            e.Handled = True
        End If
    End Sub


    Private Sub cmb_UbicaconSecundaria_DropDown(sender As Object, e As EventArgs) Handles cmb_UbicaconSecundaria.DropDown
        abierto2 = 0
    End Sub

    Private Sub cmb_UbicaconSecundaria_DropDownClosed(sender As Object, e As EventArgs) Handles cmb_UbicaconSecundaria.DropDownClosed
        abierto2 = 1
    End Sub

    Private Sub cmb_UbicaconSecundaria_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmb_UbicaconSecundaria.KeyPress
        If (abierto2 = 0) Then
            e.Handled = True
        End If
    End Sub

    Private Sub cmb_Unidad_DropDown(sender As Object, e As EventArgs) Handles cmb_Unidad.DropDown
        abierto2 = 0
    End Sub

    Private Sub cmb_Unidad_DropDownClosed(sender As Object, e As EventArgs) Handles cmb_Unidad.DropDownClosed
        abierto2 = 1
    End Sub

    Private Sub cmb_Unidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmb_Unidad.KeyPress
        If (abierto2 = 0) Then
            e.Handled = True
        End If
    End Sub

    Private Sub cmb_Responsable_DropDown(sender As Object, e As EventArgs) Handles cmb_Responsable.DropDown
        abierto2 = 0
    End Sub

    Private Sub cmb_Responsable_DropDownClosed(sender As Object, e As EventArgs) Handles cmb_Responsable.DropDownClosed
        abierto2 = 1
    End Sub

    Private Sub cmb_Responsable_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmb_Responsable.KeyPress
        If (abierto2 = 0) Then
            e.Handled = True
        End If
    End Sub
    Private objSqlHumanResources As New HumanResources_SQLServer
    Private Sub cmb_UbicaconPrimaria_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_UbicaconPrimaria.SelectedIndexChanged
        If (cmb_UbicaconPrimaria.SelectedIndex >= 0) Then
            Try
                cmb_UbicaconSecundaria.DataSource = Nothing
                Dim _dtLocation As New DataTable
                _dtLocation = objSqlHumanResources.GetLocationByPrimary(Data_Id_Company, cmb_UbicaconPrimaria.SelectedValue)
                If (_dtLocation.Rows.Count > 0) Then
                    cmb_UbicaconSecundaria.DataSource = _dtLocation
                    cmb_UbicaconSecundaria.DisplayMember = "Name_Location"
                    cmb_UbicaconSecundaria.ValueMember = "Id_Location"
                    cmb_UbicaconSecundaria.SelectedIndex = -1
                End If
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub cmb_Unidad_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_Unidad.SelectedIndexChanged
        cmb_Responsable.DataSource = Nothing
        If (cmb_Unidad.SelectedIndex >= 0) Then

            Try
                Dim dtInfo As New DataTable

                Using obj As New Generic_SQLServer
                    dtInfo = obj.SP_ERP_Inventory_getEmpleadoResponsable(cmb_Unidad.SelectedValue)
                End Using
                cmb_Responsable.DataSource = dtInfo
                cmb_Responsable.ValueMember = "Id_employee"
                cmb_Responsable.DisplayMember = "LastName_employee"
                cmb_Responsable.SelectedIndex = -1
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub cmb_UbicaconSecundaria_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_UbicaconSecundaria.SelectedIndexChanged
        'cmb_Responsable.DataSource = Nothing
        'If (cmb_UbicaconSecundaria.SelectedIndex >= 0) Then
        '    Dim dtu As New DataTable
        '    Using obj As New Generic_SQLServer
        '        dtu = obj.SP_ERP_Inventary_GetUnidadesOrganizativasUbicacion(cmb_UbicaconSecundaria.SelectedValue)
        '    End Using
        '    cmb_Unidad.DataSource = dtu
        '    cmb_Unidad.ValueMember = "Id_Deparment"
        '    cmb_Unidad.DisplayMember = "Name_Deparmnet"
        '    cmb_Unidad.SelectedIndex = -1
        'End If
    End Sub
End Class