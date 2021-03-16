Public Class Production_OutputAnimals

	Private _DT_Animal As New DataTable
	Private _DT_Catalog As New DataTable
	Private _DT_Lotes As New DataTable
	Private _DT_Bodegas As New DataTable
    Property ID_Lot As Long = 0
    Property ID_ProductoSalida As Long = 0
    Private Sub LoadAnimals()
		Using ObjSQL As New Operaciones_SQLServer
			_DT_Animal = ObjSQL.ERP_Prod_SP_Select_AnimalsLot(ID_Lot)
		End Using
		dgvDetails.DataSource = _DT_Animal
		dgvDetails.AutoGenerateColumns = False
	End Sub
	Private Sub LoadMother()
		Using ObjSQL As New Operaciones_SQLServer
			_DT_Animal = ObjSQL.ERP_Prod_SP_Select_AnimalsLotMother(ID_Lot)
		End Using
		dgvDetails.DataSource = _DT_Animal
		dgvDetails.AutoGenerateColumns = False
	End Sub


	Private Sub LoadBodegas()
		Using objsql As New Operaciones_SQLServer
			_DT_Bodegas = objsql.ERP_Prod_SP_Select_StowageEmpty
		End Using
		cbBodega.DataSource = _DT_Bodegas
		cbBodega.ValueMember = "ID_Stowage"
		cbBodega.DisplayMember = "Name_Stowage"
		cbBodega.SelectedIndex = -1
	End Sub

	Private Sub LoadLotes()
		Using objsql As New Operaciones_SQLServer
			_DT_Lotes = objsql.ERP_Production_Get_LotAvailableTransfer(ID_Lot)
		End Using
		cbLote.DataSource = _DT_Lotes
		cbLote.ValueMember = "ID_Production"
		cbLote.DisplayMember = "ID_Production"
		cbLote.SelectedIndex = -1
	End Sub

	Private Sub LoadCatalog()
		Using objSQL As New Operaciones_SQLServer
			_DT_Catalog = objSQL.SP_ERP_Inventory_GetOutletCatalog(_ID_Company)
		End Using
		If Not _DT_Catalog Is Nothing Then
			If _DT_Catalog.Rows.Count > 0 Then
				RemoveHandler cbTipoSalida.SelectedIndexChanged, AddressOf cbTipoSalida_SelectedIndexChanged
				cbTipoSalida.DataSource = _DT_Catalog
				cbTipoSalida.ValueMember = "ID_Outlet"
				cbTipoSalida.DisplayMember = "Name_Outlet"
				cbTipoSalida.SelectedIndex = -1
				AddHandler cbTipoSalida.SelectedIndexChanged, AddressOf cbTipoSalida_SelectedIndexChanged
			End If
		End If

	End Sub

	Private Sub Production_OutputAnimals_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		dgvDetails.AutoGenerateColumns = False
		LoadCatalog()
		LoadLotes()
		LoadBodegas()
	End Sub

	Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
		Me.DialogResult = DialogResult.Cancel
		Me.Close()
	End Sub

	Private Sub cmdNext_Click(sender As Object, e As EventArgs) Handles cmdNext.Click
		Dim Salida As Boolean = False
		For Each row As DataRow In _DT_Animal.Rows
			If row("Procesar") Then
				Salida = True
			End If
		Next row

		If Salida Then
			If cbTipoSalida.SelectedIndex = -1 Then
				MessageBox.Show("Por favor seleccione el tipo de salida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
				Exit Sub
			End If
			If txtComentario.Text.Trim = "" Then
				MessageBox.Show("Por favor ingrese un comentario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
				txtComentario.Select()
				Exit Sub
			End If
			'------------------------------------------------------
			Dim ID_TipoSalida As Long = cbTipoSalida.SelectedValue
			Dim Comentario As String = txtComentario.Text.Trim
			Dim ID_Bodega As Long = 0
			Dim LoteDestino As Long = 0

			If ID_TipoSalida = 3 Then ' Traslado
				ID_Bodega = cbBodega.SelectedValue
			End If

			If ID_TipoSalida = 1 Then
				LoteDestino = cbLote.SelectedValue
			End If

			Dim ID_Header_Output As Long = 0
			Dim dt As New DataTable
			Using objSQL As New Operaciones_SQLServer
				dt = objSQL.ERP_Prod_SP_AnimalTransfersHeader(_ID_Company, ID_TipoSalida, Comentario)
			End Using
			If Not dt Is Nothing Then
				If dt.Rows.Count > 0 Then
					ID_Header_Output = dt.Rows(0).Item("resp")
				End If
			End If

            Dim ID_Producto As Long = ID_ProductoSalida
            Dim IS_Mother As Integer = 0

			If rbMother.Checked Then
				IS_Mother = 1
			End If

			Dim resp As Integer = 0

			If ID_Header_Output > 0 Then
				Using objSQL As New Operaciones_SQLServer
					For Each row As DataRow In _DT_Animal.Rows
                        If row("Procesar") Then
                            resp = objSQL.ERP_Prod_SP_AnimalTransfers(_ID_Company, _ID_Customer, ID_Bodega, ID_Producto, ID_TipoSalida, IS_Mother, ID_Header_Output, row("id_animal"), row("id_animal"), row("Peso"), ID_Bodega, LoteDestino)
                        End If
                    Next row
				End Using
				If resp = 1 Then
                    MessageBox.Show("Transferencia realizada exitosamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    LoadAnimals()
                Else
                    MessageBox.Show("Ocurrió un error al procesar la transferencia", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
			Else
                MessageBox.Show("Ocurrió un error al generar el encabezado de salida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

		Else
			MessageBox.Show("Por favor seleccione un animal para la salida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
		End If
	End Sub

	Private Sub EditarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarToolStripMenuItem.Click
		If Not dgvDetails.CurrentRow Is Nothing Then
			Dim ID_AnimalOut As Long = dgvDetails.CurrentRow.Cells("id_animal").Value
			Using objDetails As New Production_OutPutDetails
				objDetails.NameAnimal = dgvDetails.CurrentRow.Cells("NameAnimal").Value
				objDetails.Salida = dgvDetails.CurrentRow.Cells("Procesar").Value
				objDetails.Peso = dgvDetails.CurrentRow.Cells("Peso").Value
				If objDetails.ShowDialog = DialogResult.OK Then
					For Each row As DataRow In _DT_Animal.Rows
						If row("id_animal") = ID_AnimalOut Then
							row("Peso") = objDetails.Peso
							row("Procesar") = objDetails.Salida
						End If
					Next
					dgvDetails.DataSource = _DT_Animal
				End If
			End Using
		End If
	End Sub

	Private Sub cbTipoSalida_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbTipoSalida.SelectedIndexChanged
		If Not cbTipoSalida.SelectedIndex = -1 Then
			If cbTipoSalida.SelectedValue = 3 Then
				cbBodega.Enabled = True
				cbLote.Enabled = False
			ElseIf cbTipoSalida.SelectedValue = 1
				cbBodega.Enabled = False
				cbLote.Enabled = True
			Else
				cbBodega.Enabled = False
				cbBodega.SelectedIndex = -1
				cbLote.Enabled = False
				cbLote.SelectedIndex = -1
			End If
		End If
	End Sub

	Private Sub rbMother_CheckedChanged(sender As Object, e As EventArgs) Handles rbMother.CheckedChanged
		If rbMother.Checked Then
			LoadMother()
		Else
			LoadAnimals()
		End If
	End Sub
	Private Sub rbHijos_CheckedChanged(sender As Object, e As EventArgs) Handles rbHijos.CheckedChanged
		If rbHijos.Checked Then
			LoadAnimals()
		Else
			LoadMother()
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