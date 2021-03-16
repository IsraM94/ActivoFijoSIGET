Public Class ERP_Compras_TipoCompra
	Property IS_Sugerido As Boolean = False
	Property IS_Manual As Boolean = False
	Property IS_File As Boolean = False
	Private Sub ERP_Compras_TipoCompra_Load(sender As Object, e As EventArgs) Handles MyBase.Load

	End Sub

	Private Sub cmdContinuar_Click(sender As Object, e As EventArgs) Handles cmdContinuar.Click
		If rbSugerido.Checked Then
			IS_Sugerido = True
		End If
		If rbManual.Checked Then
			IS_Manual = True
		End If
		If rbCargarArchivo.Checked Then
			IS_File = True
		End If
		Me.DialogResult = DialogResult.OK
	End Sub

	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		Me.DialogResult = DialogResult.Cancel
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