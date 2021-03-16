Public Class ERP_Inventory_HeaderImputsAndOutputs
	Property Autorizo As String
	Property COmentario As String
	Property ID_Header As Long

	Private Sub cmdContinuar_Click(sender As Object, e As EventArgs) Handles cmdContinuar.Click
		If txtAutorizo.Text.Trim = "" Then
            MessageBox.Show("Por favor ingrese el usuario que autoriza", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
		End If
		If txtComentario.Text.Trim = "" Then
			MessageBox.Show("Por favor ingrese un comentario", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
			Exit Sub
		End If
		Using objSQL As New Generic_SQLServer
			Dim autorizo As String = txtAutorizo.Text.Trim
			Dim Comentario As String = txtComentario.Text.Trim
			Dim _ID_Company As Long = 1 REM Borrar
			ID_Header = objSQL.AddHeaderImputsAndOutputs(_ID_Company, autorizo, Comentario)
			Me.DialogResult = DialogResult.OK
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
#End Region


End Class