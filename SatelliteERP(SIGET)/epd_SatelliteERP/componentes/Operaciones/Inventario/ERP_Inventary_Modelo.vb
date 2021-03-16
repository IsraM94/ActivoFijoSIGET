Public Class ERP_Inventary_Modelo
    Private objDatos As New Generic_SQLServer
    Property id As Integer
    Property descripcion As String
    Property marca_FK As Integer

    Property OpcionSeleccionada As Funcion

    Enum Funcion
        Agregar
        Actualizar
    End Enum
    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        If txtDescripcionModelo.Text.Trim = "" Then
            MessageBox.Show("Ingrese una descripcion", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtDescripcionModelo.Focus()
            Exit Sub
        End If
        If cmb_marca.SelectedIndex = -1 Then
            MessageBox.Show("Seleccione una Marca", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            cmb_marca.Focus()
            Exit Sub
        End If
        ''''''''''''''''


        ''''''''''''''''''

        If OpcionSeleccionada = Funcion.Agregar Then

            Dim resp As String = objDatos.ERP_SP_InsertModelo(_ID_Company, txtDescripcionModelo.Text, cmb_marca.SelectedValue)
            If resp = "OK" Then
                MessageBox.Show("El registro se agregó correctamente", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                DialogResult = DialogResult.OK
                Close()
            Else
                If resp.Split("|")(0) = "ER" Then
                    MessageBox.Show("Error al actualizar datos, " & resp.Split("|")(1), Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)

                End If
            End If
        ElseIf OpcionSeleccionada = Funcion.Actualizar Then

            Dim resp As String = objDatos.ERP_SP_UpdateModelo(id, _ID_Company, txtDescripcionModelo.Text, cmb_marca.SelectedValue)
            If resp = "OK" Then
                MessageBox.Show("El registro se actualizo correctamente", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                DialogResult = DialogResult.OK
                Close()
            Else
                If resp.Split("|")(0) = "ER" Then
                    MessageBox.Show("Error al insertar datos, " & resp.Split("|")(1), Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)

                End If
            End If

        End If
    End Sub

    Private _dtMarca As DataTable
    Private objSqlOperaciones As New Operaciones_SQLServer
    Private Sub ERP_Inventary_Modelo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _dtMarca = objSqlOperaciones.GetMarca(Data_Id_Company)
        cmb_marca.DataSource = _dtMarca
        cmb_marca.DisplayMember = "Description"
        cmb_marca.ValueMember = "ID"
        cmb_marca.SelectedIndex = -1
        If OpcionSeleccionada = Funcion.Actualizar Then
            'cmdDiscount.Enabled = True
            txtDescripcionModelo.Text = descripcion
            cmb_marca.SelectedValue = marca_FK
            cmdSave.Text = "Modificar"
        End If
    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        Close()
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