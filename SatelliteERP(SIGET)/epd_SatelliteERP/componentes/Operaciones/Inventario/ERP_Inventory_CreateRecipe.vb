Public Class ERP_Inventory_CreateRecipe
	Enum Process
		add
		update
	End Enum

	Public Property ID_Product As Long = 0
	Public Property NameProduct As String = ""
	Public Property CodeBar As String = ""
	Public Property TypeProcess As Process = Process.add

	Private _DT_ProductsRecipe As New DataTable
	Private _DT_Ingredients As New DataTable

	Private Sub ERP_Inventory_CreateRecipe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		_DT_Ingredients.Columns.Add("ID_Product", Type.GetType("System.Int64"))
		_DT_Ingredients.Columns.Add("Description", Type.GetType("System.String"))
		_DT_Ingredients.Columns.Add("ID_Unit", Type.GetType("System.Int64"))
		_DT_Ingredients.Columns.Add("DescriptionUnit", Type.GetType("System.String"))
		_DT_Ingredients.Columns.Add("Quantity", Type.GetType("System.Double"))
		_DT_Ingredients.Columns.Add("ID", Type.GetType("System.Int64"))
		dgvIngredients.DataSource = _DT_Ingredients

		If TypeProcess = Process.add Then
			FillCBProducts()
			GBPrimary.Text = "Agregar Receta"
		ElseIf TypeProcess = Process.update
			cmdSaveRecipe.Enabled = False
			cmdSaveRecipe.Visible = False
			cmdCancelRecipe.Text = "Salir"
			GBPrimary.Text = "Modificar Receta"
			FillCBProductsUpdate()
			cbProducts.SelectedValue = ID_Product
			cbProducts.Enabled = False
			loadInfo(ID_Product)
			loadIngredients()
		End If

	End Sub

	Private Sub cmdCancelRecipe_Click(sender As Object, e As EventArgs) Handles cmdCancelRecipe.Click
		Me.Close()
	End Sub

	Private Sub loadIngredients()
		If TypeProcess = Process.add Then
			EditarToolStripMenuItem.Visible = False
			EditarToolStripMenuItem.Enabled = False
		End If
		Using objSQL As New Operaciones_SQLServer
			_DT_Ingredients = objSQL.ERP_Inventory_GetIngredientsRecipe(ID_Product)
		End Using
		dgvIngredients.DataSource = _DT_Ingredients
	End Sub

	Private Sub FillCBProducts()
		Using objSQL As New Operaciones_SQLServer
			_DT_ProductsRecipe = objSQL.ERP_Inventory_GetProducts_Recipes(_ID_Company, "", 1)
		End Using
		If Not _DT_ProductsRecipe Is Nothing Then
			If _DT_ProductsRecipe.Rows.Count > 0 Then
				RemoveHandler cbProducts.SelectedIndexChanged, AddressOf cbProducts_SelectedIndexChanged
				cbProducts.DataSource = _DT_ProductsRecipe
				cbProducts.DisplayMember = "Name_Product"
				cbProducts.ValueMember = "Id_Product"
				AddHandler cbProducts.SelectedIndexChanged, AddressOf cbProducts_SelectedIndexChanged
			End If
		End If
	End Sub

	Private Sub FillCBProductsUpdate()
		Using objSQL As New Operaciones_SQLServer
			_DT_ProductsRecipe = objSQL.ERP_Inventory_GetProducts_Recipes(_ID_Company, "", 2)
		End Using
		If Not _DT_ProductsRecipe Is Nothing Then
			If _DT_ProductsRecipe.Rows.Count > 0 Then
				RemoveHandler cbProducts.SelectedIndexChanged, AddressOf cbProducts_SelectedIndexChanged
				cbProducts.DataSource = _DT_ProductsRecipe
				cbProducts.DisplayMember = "Name_Product"
				cbProducts.ValueMember = "Id_Product"
				AddHandler cbProducts.SelectedIndexChanged, AddressOf cbProducts_SelectedIndexChanged
			End If
		End If
	End Sub


	Private Sub cbProducts_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbProducts.SelectedIndexChanged
		If Not cbProducts.SelectedIndex = -1 Then
			Dim ID As Long = cbProducts.SelectedValue
			loadInfo(ID)
		End If
	End Sub

	Private Sub loadInfo(ByVal ID As Long)
		For Each row As DataRow In _DT_ProductsRecipe.Rows
			If Not row Is Nothing Then
				If row("Id_Product") = ID Then
					txtNameProduct.Text = row("Name_Product")
					lblIDProduct.Text = row("Id_Product")
					lblBarra.Text = row("BarCode")
				End If
			End If
		Next row
	End Sub

	Private Sub tsmAdd_Click(sender As Object, e As EventArgs) Handles tsmAdd.Click

        Dim ID As Long = cbProducts.SelectedValue
		Using objAdd As New ERP_Inventory_IngredientsRecipe
			If TypeProcess = Process.update Then
				objAdd.ID_Recipe = ID
				objAdd.typeProcess = ERP_Inventory_IngredientsRecipe.Process.addUpdate
				objAdd.ShowDialog()
				loadIngredients()
			Else
				objAdd.DT_Ingredients = _DT_Ingredients
				objAdd.typeProcess = ERP_Inventory_IngredientsRecipe.Process.add
				objAdd.ShowDialog()
				_DT_Ingredients = objAdd.DT_Ingredients
				dgvIngredients.DataSource = _DT_Ingredients
			End If
		End Using
	End Sub

	Private Sub tsmDelete_Click(sender As Object, e As EventArgs) Handles tsmDelete.Click
		If Not dgvIngredients.CurrentRow Is Nothing Then
			Dim id As Long = dgvIngredients.CurrentRow.Cells("Correlativo").Value
			Dim Articulos As String = dgvIngredients.CurrentRow.Cells("Descripcion").Value
			Dim ID_Ingredient As Long = dgvIngredients.CurrentRow.Cells("ID").Value
			If MessageBox.Show("¿Está seguro que desea eliminar el artículo:" & Articulos & " de la receta?", "Información", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then

				If ID_Ingredient <> 0 Then
					Using objUpdate As New Operaciones_SQLServer

						Dim resp As Long = 0
						resp = objUpdate.ERP_Inventory_DeleteIngredientsRecipe(ID_Ingredient)
						If resp = 1 Then
							MessageBox.Show("Ingrediente eliminado exitosamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
						Else
                            MessageBox.Show("Ocurrió un error al eliminar el ingrediente, por favor contacte a Soporte Técnico", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
					End Using
				Else
					For Each row As DataRow In _DT_Ingredients.Rows
						If row("ID_Product") = id Then
							_DT_Ingredients.Rows.Remove(row)
							dgvIngredients.DataSource = _DT_Ingredients

							Exit For
						End If
					Next row
				End If

				FillCBProductsUpdate()
				cbProducts.SelectedValue = ID_Product
				cbProducts.Enabled = False
				loadInfo(ID_Product)
				loadIngredients()

			End If
        End If
	End Sub

	Private Sub cmdSaveRecipe_Click(sender As Object, e As EventArgs) Handles cmdSaveRecipe.Click
		If cbProducts.SelectedIndex = -1 Then
            MessageBox.Show("Por favor seleccione un artículo para asignar la receta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
		End If
		'If _DT_Ingredients.Rows.Count <= 1 Then
		'	MessageBox.Show("La receta debe contener al menos dos productos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
		'	Exit Sub
		'End If
		Dim ID As Long = cbProducts.SelectedValue
		Dim resp As Integer = 0
		For Each row As DataRow In _DT_Ingredients.Rows
			If Not row Is Nothing Then
				Using objSQL As New Operaciones_SQLServer
					resp = objSQL.ERP_Inventory_ADDRecipe(ID, row("ID_Product"), row("Quantity"))
				End Using
			End If
		Next
		If resp = 1 Then
			MessageBox.Show("Receta agregada exitosamente", "información", MessageBoxButtons.OK, MessageBoxIcon.Information)
		End If
		Me.DialogResult = DialogResult.OK
		Me.Close()
	End Sub

	Private Sub EditarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarToolStripMenuItem.Click
		If Not dgvIngredients.CurrentRow Is Nothing Then
			Dim id As Long = dgvIngredients.CurrentRow.Cells("Correlativo").Value
			Dim UnidadMedida As String = dgvIngredients.CurrentRow.Cells("UnidadMedida").Value
			Dim ID_Ingredient As Long = dgvIngredients.CurrentRow.Cells("ID").Value
			Dim NameProduct As String = dgvIngredients.CurrentRow.Cells("Descripcion").Value
			Dim Cantidad As Double = dgvIngredients.CurrentRow.Cells("Cantidad").Value
			Using objUpdate As New ERP_Inventory_IngredientsRecipe
				objUpdate.typeProcess = ERP_Inventory_IngredientsRecipe.Process.update
				objUpdate.ID_Product = id
				objUpdate.Cantidad = Cantidad
				objUpdate.unidadMedida = UnidadMedida
				objUpdate.NameProduct = NameProduct
				objUpdate.ID_Ingredient = ID_Ingredient
				If objUpdate.ShowDialog() = DialogResult.OK Then
					loadIngredients()
				End If
			End Using
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