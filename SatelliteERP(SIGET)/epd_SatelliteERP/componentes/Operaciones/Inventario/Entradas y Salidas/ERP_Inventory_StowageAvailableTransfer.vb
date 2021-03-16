Public Class ERP_Inventory_StowageAvailableTransfer

	Property _DT_Bodegas As New DataTable
	Property ID_Bodega As Long
	Private _dtComboUbicacion As New DataTable
	Property ID_BodegaTransf As Long = 0
	Property NameBodega As String = ""

	Private Sub loadUbicacion()
		Using objDatos As New Generic_SQLServer
            _dtComboUbicacion = objDatos.GetLocationStowage(_ID_Company)
            RemoveHandler cbUbicacion.SelectedIndexChanged, AddressOf cbUbicacion_SelectedIndexChanged
			cbUbicacion.DataSource = _dtComboUbicacion
			cbUbicacion.DisplayMember = "Description"
			cbUbicacion.ValueMember = "ID_Location"
			cbUbicacion.SelectedIndex = -1
			AddHandler cbUbicacion.SelectedIndexChanged, AddressOf cbUbicacion_SelectedIndexChanged
		End Using
	End Sub
	Private Sub LoadBodegas(ByVal ID_Ubicacion As Long)
		Using objsql As New Operaciones_SQLServer
            _DT_Bodegas = objsql.SP_ERP_Inventory_Get_StowageAvailableTransfer(ID_Ubicacion)
        End Using
		Dim DT_BODEGAS_U As DataRow() = _DT_Bodegas.Select("ID_Location_FK=" & ID_Ubicacion)
		Dim dt As New DataTable
		dt.Columns.Add("ID_Stowage")
		dt.Columns.Add("Name_Stowage")

		For Each row As DataRow In DT_BODEGAS_U
			dt.Rows.Add(row("ID_Stowage"), row("Name_Stowage"))
		Next row

		If dt.Rows.Count > 0 Then
			cbBodegas.DataSource = dt
			cbBodegas.ValueMember = "ID_Stowage"
			cbBodegas.DisplayMember = "Name_Stowage"
			cbBodegas.SelectedIndex = -1
		End If

	End Sub
	Private Sub ERP_Inventory_StowageAvailableTransfer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		loadUbicacion()

	End Sub

	Private Sub cmdprint_Click(sender As Object, e As EventArgs) Handles cmdprint.Click
		If cbBodegas.SelectedIndex = -1 Then
			MessageBox.Show("Seleccione una bodega para el proceso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
			Exit Sub
		End If
		ID_BodegaTransf = cbBodegas.SelectedValue
		NameBodega = cbBodegas.Text
		Me.DialogResult = DialogResult.OK
		Me.Close()
	End Sub

	Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
		Me.Close()
	End Sub

	Private Sub cbUbicacion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbUbicacion.SelectedIndexChanged
		If Not cbUbicacion.SelectedIndex = -1 Then
			LoadBodegas(cbUbicacion.SelectedValue)
		End If
	End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

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