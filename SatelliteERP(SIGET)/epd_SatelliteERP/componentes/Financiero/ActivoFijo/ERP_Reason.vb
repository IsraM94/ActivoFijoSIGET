Public Class ERP_Reason
    Private objDatos As New Generic_SQLServer
    Property id As Integer
    Property descripcion As String
    Property nombre As String

    Property OpcionSeleccionada As Funcion

    Enum Funcion
        Agregar
        Actualizar
    End Enum
    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        Close()
    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        If txtNombreRazon.Text.Trim = "" Then
            MessageBox.Show("Ingresa un nombre de razon")
            Exit Sub
        End If
        If txtDescripcionRazon.Text.Trim = "" Then
            MessageBox.Show("Ingresa una descipcion de razon")
            Exit Sub
        End If


        'Dim resultado As Integer
        If OpcionSeleccionada = Funcion.Agregar Then
            Dim resp As String = objDatos.ERP_SP_InsertReason(txtNombreRazon.Text, txtDescripcionRazon.Text)

            If resp = "OK" Then
                MessageBox.Show("El registro se agregó correctamente", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                DialogResult = DialogResult.OK
                Close()
            ElseIf resp.Split("|")(0) = "ER" Then
                MessageBox.Show("Error al insertar datos, " & resp.Split("|")(1), Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)


            End If

        ElseIf OpcionSeleccionada = Funcion.Actualizar Then
            Dim resp As String = objDatos.ERP_SP_SetReason(id, txtNombreRazon.Text, txtDescripcionRazon.Text)

            If resp = "OK" Then
                MessageBox.Show("El registro se actualizo correctamente", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                DialogResult = DialogResult.OK
                Close()

            ElseIf resp.Split("|")(0) = "ER" Then

            MessageBox.Show("Error al actualizar datos, " & resp.Split("|")(1), Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If
        End If

    End Sub

    Private Sub ERP_Reason_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If OpcionSeleccionada = Funcion.Actualizar Then
            txtNombreRazon.Text = nombre
            txtDescripcionRazon.Text = descripcion
            cmdSave.Text = "Actualizar"
        End If
        txtNombreRazon.Focus()
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