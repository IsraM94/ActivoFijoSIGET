Public Class precios
	Property Precio As Double = 0

	Private Sub precios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		txtPrecio.Text = Math.Round(Precio * 1.13, 2).ToString("####0.00")
	End Sub

	Private Sub cmdContinuar_Click(sender As Object, e As EventArgs) Handles cmdContinuar.Click
		If txtPrecio.Text.Trim = "" Then
			Exit Sub
		End If
		If Not IsNumeric(txtPrecio.Text.Trim) Then
			Exit Sub
		End If
		Precio = txtPrecio.Text.Trim
		Precio = Precio / 1.13
		Precio = Math.Round(Precio, 4)
		Me.Close()
	End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
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