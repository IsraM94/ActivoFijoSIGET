Public Class Production_AddAnimals
    Property _id_Ciclo As Integer
    Property _id_Genetica As Integer
    Property _id_OriginType As Integer
    Property _id_Origin As Integer
    Property _id_Group As Integer
    Property _Comentarios As String
    Property _fechaProceso As String
    Property _fechaNacimiento As String
    Property id As Integer
    Property _idCompany As Integer
    Private objGeneric As New Generic_SQLServer
    Private _tableCicles As DataTable
    Private _Genetica As DataTable
    Private _OriginType As DataTable
    Private _Origin As DataTable
    Private _Group As DataTable

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _Genetica = objGeneric.GetGenetic(Data_Id_Company)
        cmbGeneticac.DataSource = _Genetica
        cmbGeneticac.DisplayMember = "Genetic_Name"
        cmbGeneticac.ValueMember = "ID_Genetic"

        _OriginType = objGeneric.GetOriginType(Data_Id_Company)
        cmbTipoOrigenc.DataSource = _OriginType
        cmbTipoOrigenc.DisplayMember = "typeorigin_Name"
        cmbTipoOrigenc.ValueMember = "ID_typeorigin"

        _Origin = objGeneric.GetOrigin(Data_Id_Company)
        cmbOrigenc.DataSource = _Origin
        cmbOrigenc.DisplayMember = "Origin_Name"
        cmbOrigenc.ValueMember = "ID_Origin"

        _Group = objGeneric.GetAnimalGroup(Data_Id_Company)
        cmbTipoGrupo.DataSource = _Group
        cmbTipoGrupo.DisplayMember = "Descripction"
        cmbTipoGrupo.ValueMember = "ID_Group"

        _tableCicles = objGeneric.GetCicles()
        cmbCicloc.DataSource = _tableCicles
        cmbCicloc.DisplayMember = "descripcion"
        cmbCicloc.ValueMember = "ID"





    End Sub

    Private Sub BtnCrear_Click(sender As Object, e As EventArgs) Handles btnCrear.Click

        If (txtCodigoAnimalc.Text.ToString = "") Then
            MessageBox.Show("Debe ingresar el código del animal", "ERP Produccion", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtCodigoAnimalc.Focus()
            Exit Sub
        End If

        If (txtNombreAnimalc.Text.ToString = "") Then
            MessageBox.Show("Debe ingresar el nombre del animal", "ERP Produccion", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtNombreAnimalc.Focus()
            Exit Sub
        End If

        If ValidarAnimales Then
            If (txtRegistroAnimalc.Text.ToString = "") Then
                MessageBox.Show("Debe ingresar el registro del animal", "ERP Produccion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtRegistroAnimalc.Focus()
                Exit Sub
            End If
            If (txtCodigoCamadac.Text.ToString = "") Then
                MessageBox.Show("Debe ingresar el código de camada del animal", "ERP Produccion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtCodigoCamadac.Focus()
                Exit Sub
            End If
            If (cmbTipoOrigenc.Text.ToString = "") Then
                MessageBox.Show("Debe ingresar el tipo de origen del animal", "ERP Produccion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                cmbTipoOrigenc.Focus()
                Exit Sub
            End If
            If (cmbOrigenc.Text.ToString = "") Then
                MessageBox.Show("Debe ingresar el origen del animal", "ERP Produccion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtCodigoAnimalc.Focus()
                Exit Sub
            End If
            If (txtLugarInicioc.Text.ToString = "") Then
                MessageBox.Show("Debe ingresar el lugar inicio del animal", "ERP Produccion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtLugarInicioc.Focus()
                Exit Sub
            End If
            If (txtPadrec.Text.ToString = "") Then
                MessageBox.Show("Debe ingresar el padre del animal", "ERP Produccion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtPadrec.Focus()
                Exit Sub
            End If
            If (txtMadrec.Text.ToString = "") Then
                MessageBox.Show("Debe ingresar la madre del animal", "ERP Produccion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtMadrec.Focus()
                Exit Sub
            End If
            If (txtPesoc.Text.ToString = "") Then
                MessageBox.Show("Debe ingresar el peso del animal", "ERP Produccion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtPesoc.Focus()
                Exit Sub
            End If
            If (txtPrecioc.Text.ToString = "") Then
                MessageBox.Show("Debe ingresar el precio del animal", "ERP Produccion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtPrecioc.Focus()
                Exit Sub
            End If
            If (txtComentariosc.Text.ToString = "") Then
                MessageBox.Show("Debe ingresar comentarios sobre animal", "ERP Produccion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtComentariosc.Focus()
                Exit Sub
            End If
        End If


        _id_Ciclo = cmbCicloc.SelectedValue
        _id_Genetica = cmbGeneticac.SelectedValue
        _id_OriginType = cmbTipoOrigenc.SelectedValue
        _id_Origin = cmbOrigenc.SelectedValue
        _id_Group = cmbTipoGrupo.SelectedValue
        _Comentarios = txtComentariosc.Text.ToString.Trim
        _fechaProceso = mcFechaProcesoc.Value.ToString("yyyy-M-d")
        _fechaNacimiento = mcFechaNacimientoc.Value.ToString("yyyy-M-d")

        Dim padre As String = txtPadrec.Text.ToString
        Dim madre As String = txtMadrec.Text.ToString

        Dim precio As Double
        If Not txtPrecioc.Text.Trim = "" Then
            precio = txtPrecioc.Text.ToString()
        Else
            precio = 0
        End If

        Dim peso As Double
        If Not txtPesoc.Text.Trim = "" Then
            peso = txtPrecioc.Text.ToString()
        Else
            peso = 0
        End If

        Dim LugarInicio As String = txtLugarInicioc.Text.ToString

        Dim CodigoCamada As Integer = 0
        If Not txtCodigoCamadac.Text.ToString = "" Then
            CodigoCamada = txtCodigoCamadac.Text.ToString()
        Else
            CodigoCamada = 0
        End If

        Dim codigoanimal As String = txtCodigoAnimalc.Text.ToString
        Dim RegistroAnimal As String = txtRegistroAnimalc.Text.ToString

        Dim resp As String = ""
        Using ObjSql As New Generic_SQLServer
            resp = ObjSql.AddAnimals(_id_Group, codigoanimal, txtNombreAnimalc.Text.ToString, _fechaProceso, _id_Ciclo, RegistroAnimal, _id_Genetica, _fechaNacimiento, CodigoCamada, _id_OriginType, _id_Origin, LugarInicio, padre, madre, peso, precio, _Comentarios)
            If (resp = "ok") Then
                MessageBox.Show("Animal agregado correctamente", "ERP Produccion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                DialogResult = DialogResult.OK
                Me.Close()
            Else
                MessageBox.Show("Código de animal ya existe", "ERP Produccion", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End Using
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If (txtCodigoAnimalc.Text.ToString = "") Then
            MessageBox.Show("Debe ingresar el código del animal", "ERP Produccion", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtCodigoAnimalc.Focus()
            Exit Sub
        End If
        If (txtNombreAnimalc.Text.ToString = "") Then
            MessageBox.Show("Debe ingresar el nombre del animal", "ERP Produccion", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtNombreAnimalc.Focus()
            Exit Sub
        End If
        If ValidarAnimales Then
            If (txtRegistroAnimalc.Text.ToString = "") Then
                MessageBox.Show("Debe ingresar el registro del animal", "ERP Produccion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtRegistroAnimalc.Focus()
                Exit Sub
            End If
            If (txtCodigoCamadac.Text.ToString = "") Then
                MessageBox.Show("Debe ingresar el código de camada del animal", "ERP Produccion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtCodigoCamadac.Focus()
                Exit Sub
            End If
            If (cmbTipoOrigenc.Text.ToString = "") Then
                MessageBox.Show("Debe ingresar el tipo de origen del animal", "ERP Produccion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                cmbTipoOrigenc.Focus()
                Exit Sub
            End If
            If (cmbOrigenc.Text.ToString = "") Then
                MessageBox.Show("Debe ingresar el origen del animal", "ERP Produccion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtCodigoAnimalc.Focus()
                Exit Sub
            End If
            If (txtLugarInicioc.Text.ToString = "") Then
                MessageBox.Show("Debe ingresar el lugar inicio del animal", "ERP Produccion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtLugarInicioc.Focus()
                Exit Sub
            End If
            If (txtPadrec.Text.ToString = "") Then
                MessageBox.Show("Debe ingresar el padre del animal", "ERP Produccion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtPadrec.Focus()
                Exit Sub
            End If
            If (txtMadrec.Text.ToString = "") Then
                MessageBox.Show("Debe ingresar la madre del animal", "ERP Produccion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtMadrec.Focus()
                Exit Sub
            End If
            If (txtPesoc.Text.ToString = "") Then
                MessageBox.Show("Debe ingresar el peso del animal", "ERP Produccion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtPesoc.Focus()
                Exit Sub
            End If
            If (txtPrecioc.Text.ToString = "") Then
                MessageBox.Show("Debe ingresar el precio del animal", "ERP Produccion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtPrecioc.Focus()
                Exit Sub
            End If
            If (txtComentariosc.Text.ToString = "") Then
                MessageBox.Show("Debe ingresar comentarios sobre animal", "ERP Produccion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtComentariosc.Focus()
                Exit Sub
            End If
        End If
        _id_Ciclo = cmbCicloc.SelectedValue
        _id_Genetica = cmbGeneticac.SelectedValue
        _id_OriginType = cmbTipoOrigenc.SelectedValue
        _id_Origin = cmbOrigenc.SelectedValue
        _id_Group = cmbTipoGrupo.SelectedValue
        _Comentarios = txtComentariosc.Text.ToString.Trim
        _fechaProceso = mcFechaProcesoc.Value.ToString("yyyy-M-d")
        _fechaNacimiento = mcFechaNacimientoc.Value.ToString("yyyy-M-d")

        'If (_fechaProceso < Date.Now.ToString("yyyy-M-d")) Then
        '    MessageBox.Show("Debe ingresar una fecha valida", "Creación de Animales", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    Exit Sub
        'End If


        Dim resp As String = ""
        Using ObjSql As New Generic_SQLServer
            resp = ObjSql.UpdateAnimals(_id_Group, _id, txtCodigoAnimalc.Text.ToString, txtNombreAnimalc.Text.ToString, _fechaProceso, _id_Ciclo, txtRegistroAnimalc.Text.ToString, _id_Genetica, _fechaNacimiento, txtCodigoCamadac.Text.ToString, _id_OriginType, _id_Origin, txtLugarInicioc.Text.ToString, txtPadrec.Text.ToString, txtMadrec.Text.ToString, txtPesoc.Text.ToString, txtPrecioc.Text.ToString, _Comentarios)
            If (resp = "ok") Then
                MessageBox.Show("Registro del animal modificado correctamente", "ERP Produccion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                DialogResult = DialogResult.OK

                Me.Close()
            Else
                MessageBox.Show("Código de animal ya existe", "ERP Produccion", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End Using

    End Sub

    Private Sub txtPesoc_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not IsNumeric(e.KeyChar) And Not e.KeyChar = "." And Not e.KeyChar = ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtPrecioc_Keypress(sender As Object, e As KeyPressEventArgs)
        If Not IsNumeric(e.KeyChar) And Not e.KeyChar = "." And Not e.KeyChar = ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        DialogResult = DialogResult.Cancel
        Me.Close()
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