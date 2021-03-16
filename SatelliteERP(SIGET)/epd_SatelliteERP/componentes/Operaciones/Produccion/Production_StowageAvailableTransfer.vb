Public Class Production_StowageAvailableTransfer

	Private _DT_Bodegas As New DataTable
	Property ID_Lot As Long = 0
	Property ID_Bodega As Long = 0
	Property Comentario As String = ""
	Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
		Me.DialogResult = DialogResult.Cancel
		Me.Close()
	End Sub


	Private Sub LoadBodegas()
		Using objsql As New Operaciones_SQLServer
			_DT_Bodegas = objsql.ERP_Production_Get_StowageAvailableTransfer(ID_Lot)
		End Using

		cbBodegas.DataSource = _DT_Bodegas
		cbBodegas.ValueMember = "ID_Stowage"
		cbBodegas.DisplayMember = "Name_Stowage"
		cbBodegas.SelectedIndex = -1
	End Sub

	Private Sub Production_StowageAvailableTransfer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		LoadBodegas()
	End Sub

    Private Sub cmdprint_Click(sender As Object, e As EventArgs) Handles cmdprint.Click
        If cbBodegas.SelectedIndex = -1 Then
            MessageBox.Show("Seleccione una bodega", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        If txtComentario.Text.Trim = "" Then
            MessageBox.Show("Por favor ingrese un comentario", "Información", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            txtComentario.Select()
            Exit Sub
        End If
        Comentario = txtComentario.Text.Trim
        ID_Bodega = cbBodegas.SelectedValue
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