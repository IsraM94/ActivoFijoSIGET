Public Class ERP_CuentasPorCobrar_DialogFechasSelect

	Property FechaInicial As Date = Nothing
	Property FechaFinal As Date = Nothing
	Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
		Me.DialogResult = DialogResult.Cancel
	End Sub

	Private Sub cmdGrabar_Click(sender As Object, e As EventArgs) Handles cmdGrabar.Click
		FechaInicial = dtpDateInit.Value
		FechaFinal = dtpDateEnd.Value
		If (FechaInicial > FechaFinal) Then
            MessageBox.Show("La fecha inicial no  puede ser mayor a la final", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
		End If
		Me.DialogResult = DialogResult.OK
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