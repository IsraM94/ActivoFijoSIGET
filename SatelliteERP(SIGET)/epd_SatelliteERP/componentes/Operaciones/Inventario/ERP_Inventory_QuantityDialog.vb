Public Class ERP_Inventory_QuantityDialog
	Property Quantity As Double
	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		Me.DialogResult = DialogResult.Cancel
		Me.Close()
	End Sub

	Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
		If txtCantidad.Text.Trim = "" Then
			MessageBox.Show("Por favor ingrese la cantidad de salida", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
			Exit Sub
		End If
		If Not IsNumeric(txtCantidad.Text.Trim) Then
            MessageBox.Show("Por favor ingrese una cantidad numérica", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
		End If
		_Quantity = txtCantidad.Text.Trim
		Me.DialogResult = DialogResult.OK
		Me.Close()
	End Sub

    Private Sub Cantidad_Enter(sender As Object, e As EventArgs) Handles Cantidad.Enter

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