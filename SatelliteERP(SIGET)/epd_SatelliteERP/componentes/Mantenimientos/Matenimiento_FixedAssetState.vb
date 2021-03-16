Public Class Matenimiento_FixedAssetState
    Private objDatos As New Generic_SQLServer
    Property id As Integer
    Property nombre As String
    Property descripcion As String
    Property Is_Low As Boolean

    Property OpcionSeleccionada As Funcion
    Enum Funcion
        Agregar
        Actualizar
    End Enum
    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click

        If txtNombreEstadoActivo.Text.Trim = "" Then
            MessageBox.Show("Ingrese un nombre de estado", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtNombreEstadoActivo.Focus()
            Exit Sub
        End If
        If txtDescripcion.Text.Trim = "" Then
            MessageBox.Show("Ingresa una descripción", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtDescripcion.Focus()
            Exit Sub
        End If


        If OpcionSeleccionada = Funcion.Agregar Then
            Dim resp As String = objDatos.ERP_InsertFixedAssets_State(txtNombreEstadoActivo.Text, txtDescripcion.Text, chkIsLow.Checked, chkDescargo.Checked)

            If resp = "OK" Then
                MessageBox.Show("El registro se inserto correctamente", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                DialogResult = DialogResult.OK
                Close()

            Else
                If resp.Split("|")(0) = "ER" Then
                    MessageBox.Show("Error al insertar datos, " & resp.Split("|")(1), Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    'Else
                    '    MessageBox.Show("Error al insertar datos", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
                ''MessageBox.Show("El registro no agregó correctamente", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        ElseIf OpcionSeleccionada = Funcion.Actualizar Then

            Dim resp As String = objDatos.ERP_SetFixedAssets_State(id, txtNombreEstadoActivo.Text, txtDescripcion.Text, chkIsLow.Checked, chkDescargo.Checked)
            If resp = "OK" Then
                MessageBox.Show("El registro se actualizo correctamente", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                DialogResult = DialogResult.OK
                Close()
            Else
                If resp.Split("|")(0) = "ER" Then
                    MessageBox.Show("Error al actualizar datos, " & resp.Split("|")(1), Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    'Else
                    '    MessageBox.Show("Error al actualizar datos", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        End If
    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        Close()
    End Sub

    Private Sub Matenimiento_FixedAssetState_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If OpcionSeleccionada = Funcion.Actualizar Then
            'cmdDiscount.Enabled = True
            txtNombreEstadoActivo.Text = nombre
            txtDescripcion.Text = descripcion
            chkIsLow.Checked = Is_Low
            cmdSave.Text = "Modificar"
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