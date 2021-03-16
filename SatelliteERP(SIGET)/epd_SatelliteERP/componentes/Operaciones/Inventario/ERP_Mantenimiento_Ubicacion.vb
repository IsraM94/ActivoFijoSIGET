Public Class ERP_Mantenimiento_Ubicacion
    Private objDatos As New Generic_SQLServer
    Private objSQL As New Operaciones_SQLServer
    Private dtLocation As DataTable
    Private _dtComboMunicipality As DataTable
    Private _dtComboDepartamentos As DataTable
    Property Id_Company_FK As Long
    Property Name_Location As String
    Property id_Location As Long = 0
    Property id_Municipality As Long = 0
    Property id_Department As Long = 0
    Property Title As String

    Private Sub Mantenimiento_Generic_Municipality_Load(sender As Object, e As EventArgs) Handles Me.Load
        _dtComboDepartamentos = objDatos.GetDeparment(Id_Company_FK)
        cmbDepartamentos.DataSource = _dtComboDepartamentos
        cmbDepartamentos.DisplayMember = "name_Department"
        cmbDepartamentos.ValueMember = "id_Department"

        llenacmbMunicipality()

        If id_Location <> 0 Then
            '' txtNameLocation.Text = Name_Location
            txtNameLocation.Text = Name_Location
            GroupBox1.Text = Title
            cmbDepartamentos.SelectedValue = id_Department
            cmbMunicipalidad.SelectedValue = id_Municipality

        End If
    End Sub

    Private Sub llenacmbMunicipality()
        cmbMunicipalidad.Text = ""
        If (id_Department = 0) Then
            id_Department = 1
        End If
        _dtComboMunicipality = objDatos.GetMunicipalityByID(Id_Company_FK, id_Department)
        cmbMunicipalidad.DataSource = _dtComboMunicipality
        cmbMunicipalidad.DisplayMember = "name_Municipality"
        cmbMunicipalidad.ValueMember = "id_minicipality"
    End Sub


    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        If txtNameLocation.Text = "" Then
            MessageBox.Show("Por favor escriba el nombre de la ubicación", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtNameLocation.Focus()
            Exit Sub
        End If
        If cmbDepartamentos.SelectedIndex = -1 Then
			MessageBox.Show("Por favor seleccione el departamento", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
			cmbDepartamentos.Focus()
			Exit Sub
		End If
		If cmbMunicipalidad.SelectedIndex = -1 Then
			MessageBox.Show("Por favor seleccione la municipalidad", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
			cmbMunicipalidad.Focus()
			Exit Sub
		End If

        If id_Location > 0 Then ' Es modificacion
            Dim resp As String = objDatos.SetLocation(Id_Company_FK, id_Location, cmbMunicipalidad.SelectedValue, txtNameLocation.Text)
            If resp = "OK" Then
                DialogResult = DialogResult.OK
                MessageBox.Show("Registro actualizado exitosamente", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Close()
            Else
                If resp.Split("|")(0) = "ER" Then
                MessageBox.Show("Error al actualizar datos, " & resp.Split("|")(1), Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)

                End If

            End If
        Else
            id_Location = cmbMunicipalidad.SelectedValue
            Dim resp As String = objDatos.InsertLocation(Id_Company_FK, id_Location, txtNameLocation.Text)
            If resp = "OK" Then
                DialogResult = DialogResult.OK
                MessageBox.Show("Registro insertado exitosamente", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Close()
            Else
                If resp.Split("|")(0) = "ER" Then
                    MessageBox.Show("Error al actualizar datos, " & resp.Split("|")(1), Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)

                End If

            End If
        End If
    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        DialogResult = DialogResult.None
        Close()
    End Sub

    Private Sub cmbDerpartamentos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDepartamentos.SelectionChangeCommitted
        id_Department = cmbDepartamentos.SelectedValue
        llenacmbMunicipality()
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