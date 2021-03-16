Public Class Financiero_Modulos

    Private objDatos As New Generic_SQLServer
    Property nameModule As String
    Property id As String

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub
    Property OpcionSeleccionada As Funcion
    Enum Funcion
        Agregar
        Actualizar
    End Enum

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        If Not txtModuleName.Text.Trim = "" Then
            Dim resultado As Integer = 0
            If OpcionSeleccionada = Funcion.Agregar Then
                resultado = objDatos.InsertModules(txtModuleName.Text)
                If resultado = 1 Then
                    MessageBox.Show("El registro se agregó correctamente", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    DialogResult = DialogResult.OK
                    Close()
                ElseIf resultado = 2 Then
                    MessageBox.Show("Ya existe un Modulo con este nombre, por favor verifique", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)

                    Exit Sub
                Else
                    MessageBox.Show("No se pudo agregar el registro", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            ElseIf OpcionSeleccionada = Funcion.Actualizar Then
                resultado = objDatos.UpdateModules(id, txtModuleName.Text)
                If resultado = 1 Then
                    MessageBox.Show("El registro se actualizo correctamente", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    DialogResult = DialogResult.OK
                    Close()
                ElseIf resultado = 2 Then
                    MessageBox.Show("Ya existe", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)

                    Exit Sub
                Else
                    MessageBox.Show("No se pudo actualizar el registro", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            End If
        Else
            MessageBox.Show("Ingresa un nombre de modulo", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtModuleName.Focus()

        End If
    End Sub

    Private Sub Financiero_Modulos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If OpcionSeleccionada = Funcion.Actualizar Then
            txtModuleName.Text = nameModule
        End If
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