Public Class ERP_Mantenimiento_WorkLocation
    Private objDatos As New Generic_SQLServer
    Private objSQL As New Operaciones_SQLServer
    Private dtLinea As DataTable
    Private _dtComboUbicacion As DataTable
    Property Id_Company_FK As Long
    Property _isInsert As Boolean
    Property Name_WorkPosition As String
    Property Name_WorkAddress As String
    Property id_Worklocation As Long = 0
    Property id_Ubicacion As Long = 0
    Property id_UbicacionPrimaria As Long = 0
    Property Title As String

    Private Sub Mantenimiento_WorkPosition_Load(sender As Object, e As EventArgs) Handles Me.Load

        Dim dt As New DataTable
        Using obj As New Generic_SQLServer
            dt = obj.SP_ERP_Inventory_GetLocationPrimary()
        End Using
        cmb_UbicaconPrimaria.DataSource = dt
        cmb_UbicaconPrimaria.ValueMember = "ID_Location"
        cmb_UbicaconPrimaria.DisplayMember = "NameLocation"
        cmb_UbicaconPrimaria.SelectedIndex = -1

        If id_Worklocation <> 0 Then
            txtWorkLocation.Text = Name_WorkPosition
            txtAddressLocation.Text = Name_WorkAddress
            GroupBox1.Text = Title
            cmb_UbicaconPrimaria.SelectedValue = id_UbicacionPrimaria
        End If



    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        If cmb_UbicaconPrimaria.SelectedIndex = -1 Then
            MessageBox.Show("Por favor seleccione la Ubicacion Primaria", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            cmb_UbicaconPrimaria.Focus()
            Exit Sub
        End If

        If txtWorkLocation.Text = "" Then
            MessageBox.Show("No puede dejar campos vacíos", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtWorkLocation.Focus()
            Exit Sub
        End If
        If txtAddressLocation.Text = "" Then
            MessageBox.Show("No puede dejar campos vacíos", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtAddressLocation.Focus()
            Exit Sub
        End If
        If id_Worklocation > 0 Then ' Es modificacion
            Dim resp As String = objDatos.ERP_RRHH_SetLocation(id_Worklocation, Data_Id_Company, txtWorkLocation.Text, txtAddressLocation.Text, cmb_UbicaconPrimaria.SelectedValue)
            If resp = "OK" Then
                DialogResult = DialogResult.OK
                MessageBox.Show("Registro actualizado exitosamente", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Close()
            Else
                If resp.Split("|")(0) = "ER" Then

                    MessageBox.Show("Error al actualizar datos, " & resp.Split("|")(1), Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    'Else
                    '    MessageBox.Show("Error al actualizar datos", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Else
            Dim resp As String = objDatos.ERP_RRHH_InsertLocation(Data_Id_Company, txtWorkLocation.Text, txtAddressLocation.Text, cmb_UbicaconPrimaria.SelectedValue)
            If resp = "OK" Then
                DialogResult = DialogResult.OK
                MessageBox.Show("Registro insertado exitosamente", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Close()
            Else
                If resp.Split("|")(0) = "ER" Then
                    MessageBox.Show("Error al insertar datos, " & resp.Split("|")(1), Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    'Else
                    '    MessageBox.Show("Error al insertar datos", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            End If
        End If
    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        DialogResult = DialogResult.None
        Close()
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
#Region " Move Form "
    Public MoveForm As Boolean
    Public MoveForm_MousePosition As Point
    Public Sub MoveForm_MouseDown(sender As Object, e As MouseEventArgs) Handles _
    MyBase.MouseDown ' Add more handles here (Example: PictureBox1.MouseDown)
        If e.Button = MouseButtons.Left Then
            MoveForm = True
            Me.Cursor = Cursors.NoMove2D
            MoveForm_MousePosition = e.Location
        End If
    End Sub
    Public Sub MoveForm_MouseMove(sender As Object, e As MouseEventArgs) Handles _
    MyBase.MouseMove ' Add more handles here (Example: PictureBox1.MouseMove)
        If MoveForm Then
            Me.Location = Me.Location + (e.Location - MoveForm_MousePosition)
        End If
    End Sub
    Public Sub MoveForm_MouseUp(sender As Object, e As MouseEventArgs) Handles _
    MyBase.MouseUp ' Add more handles here (Example: PictureBox1.MouseUp)
        If e.Button = MouseButtons.Left Then
            MoveForm = False
            Me.Cursor = Cursors.Default
        End If
    End Sub
#End Region
End Class