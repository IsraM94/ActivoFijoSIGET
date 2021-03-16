Public Class ERP_RequisicionesEmpleado
    Public Property Unidad As Long = 0
    Public Property UnidadText As String = 0
    Public Property Genrencia As Long = 0
    Public Property Responsable As Long = 0
    Public Property ResponsableText As String = 0
    Private Sub cmdEnviar_Click(sender As Object, e As EventArgs) Handles cmdEnviar.Click
        If cmb_Unidad.SelectedIndex = -1 And cmb_Responsable.SelectedIndex = -1 Then
            MessageBox.Show("Selecione almenos una opción", "información", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return
        End If

        Unidad = cmb_Unidad.SelectedValue
        Me.DialogResult = DialogResult.OK
        Me.Close()

    End Sub

    Private Sub cmdCancelar_Click(sender As Object, e As EventArgs) Handles cmdCancelar.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub LOadData()
        Dim dt As New DataTable
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

    Private Sub cmb_UbicaconSecundaria_SelectedIndexChanged(sender As Object, e As EventArgs)
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