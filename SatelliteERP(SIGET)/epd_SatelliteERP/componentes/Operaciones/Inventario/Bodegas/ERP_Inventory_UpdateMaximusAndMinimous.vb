Public Class ERP_Inventory_UpdateMaximusAndMinimous

	Property NameProduct As String = ""
	Property Maximo As Double = 0
	Property Minimo As Double = 0
	Private Sub ERP_Inventory_UpdateMaximusAndMinimous_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		txtNameProduct.Text = NameProduct
		txtMaximo.Text = Maximo
		txtMinimo.Text = Minimo
	End Sub

	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		Me.DialogResult = DialogResult.Cancel
		Me.Close()
	End Sub

    Private Sub cmdAceptar_Click(sender As Object, e As EventArgs) Handles cmdAceptar.Click
        If txtMaximo.Text.Trim = "" Then
            MessageBox.Show("Por favor ingrese un valor para el máximo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            txtMaximo.Select()
            Exit Sub
        End If

        If Not IsNumeric(txtMaximo.Text.Trim) Then
            MessageBox.Show("Por favor ingrese un valor numérico para el máximo", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtMaximo.Select()
            Exit Sub
        End If

        If txtMinimo.Text.Trim = "" Then
            MessageBox.Show("Por favor ingrese un valor para el mínimo", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtMinimo.Select()
            Exit Sub
        End If

        If Not IsNumeric(txtMinimo.Text.Trim) Then
            MessageBox.Show("Por favor ingrese un valor numérico para el mínimo", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtMinimo.Select()
            Exit Sub
        End If

        Maximo = txtMaximo.Text.Trim
        Minimo = txtMinimo.Text.Trim

        If Minimo > Maximo Then
            MessageBox.Show("El numero Minimo, no puede ser mayor al numero Maximo", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtMinimo.Select()
            Exit Sub
        End If
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub


    Private Sub txtMaximo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMaximo.KeyPress
        Using objValidaciones As New Validaciones
            If Not Char.IsControl(e.KeyChar) Then
                e.Handled = objValidaciones.Validar_Money(sender, e, txtMaximo)
            End If
        End Using

    End Sub

    Private Sub txtMinimo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMinimo.KeyPress
        Using objValidaciones As New Validaciones
            If Not Char.IsControl(e.KeyChar) Then
                e.Handled = objValidaciones.Validar_Money(sender, e, txtMinimo)
            End If
        End Using

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

    Private Sub txtNameProduct_TextChanged(sender As Object, e As EventArgs) Handles txtNameProduct.TextChanged

    End Sub

    Private Sub Cantidad_Enter(sender As Object, e As EventArgs) Handles Cantidad.Enter

    End Sub
#End Region
End Class