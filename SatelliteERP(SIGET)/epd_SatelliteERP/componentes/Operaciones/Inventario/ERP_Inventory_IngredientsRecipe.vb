Public Class ERP_Inventory_IngredientsRecipe

	Private _DT_Products As New DataTable
	Enum Process
		add
		update
		addUpdate
	End Enum

	Property typeProcess As Process = Process.add
	Property ID_Product As Long = 0
	Property ID_Ingredient As Long = 0
	Property DT_Ingredients As New DataTable
	Property Cantidad As Double = 0
	Property unidadMedida As String
	Property NameProduct As String = ""
	Property ID_Recipe As Long = 0
	Private Sub cmdCancelRecipe_Click(sender As Object, e As EventArgs) Handles cmdCancelRecipe.Click
		Me.Close()
	End Sub

	Private Sub ERP_Inventory_IngredientsRecipe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		If typeProcess = Process.update Then
			GetDataProductos("")
			cbProducts.SelectedValue = ID_Product
			loadData(ID_Product)
			txtCantidad.Text = Cantidad
			txtBusqueda.Text = NameProduct
			lblUnidad.Text = unidadMedida
			txtBusqueda.Enabled = False
			cbProducts.Enabled = False
		End If
	End Sub

	Private Sub txtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles txtBusqueda.TextChanged
		Dim busqueda As String = txtBusqueda.Text.Trim
		If Not busqueda = "" Then
			GetDataProductos("%" & busqueda & "%")
		End If
	End Sub

	Private Sub GetDataProductos(ByVal Busqueda As String)
		Using objSQL As New Generic_SQLServer
			_DT_Products = objSQL.GetProduct(_ID_Company, Busqueda)
		End Using
		RemoveHandler cbProducts.SelectedIndexChanged, AddressOf cbProducts_SelectedIndexChanged
		cbProducts.DataSource = _DT_Products
		cbProducts.ValueMember = "Id_Product"
		cbProducts.DisplayMember = "Name_Product"
		cbProducts.SelectedIndex = -1
		AddHandler cbProducts.SelectedIndexChanged, AddressOf cbProducts_SelectedIndexChanged
	End Sub

	Private Sub cbProducts_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbProducts.SelectedIndexChanged
		If Not cbProducts.SelectedIndex = -1 Then
			Dim ID As Long = cbProducts.SelectedValue
			loadData(ID)
		End If
	End Sub

	Private Sub loadData(ByVal ID As Long)
		For Each row As DataRow In _DT_Products.Rows
			If Not row Is Nothing Then
				If row("Id_Product") = ID Then
					lblUnidad.Text = row("Name_UnitMeasure")
				End If
			End If
		Next row
	End Sub

	Private Sub cmdSaveRecipe_Click(sender As Object, e As EventArgs) Handles cmdSaveRecipe.Click

		If typeProcess = Process.add Then
			If cbProducts.SelectedIndex = -1 Then
				MessageBox.Show("Por favor seleccione un producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
				Exit Sub
			End If
		End If
		If txtCantidad.Text.Trim = "" Then
			MessageBox.Show("Por favor ingrese una cantidad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
			txtCantidad.Select()
			Exit Sub
		End If
		If Not IsNumeric(txtCantidad.Text.Trim) Then
			MessageBox.Show("Por favor ingrese una cantidad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
			txtCantidad.Select()
			Exit Sub
		End If
		Cantidad = txtCantidad.Text.Trim
		If Cantidad <= 0 Then
			MessageBox.Show("Por favor ingrese una cantidad mayor a cero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
			txtCantidad.Select()
			Exit Sub
		End If

		If typeProcess = Process.add Then
			Dim id As Long = cbProducts.SelectedValue
			For Each row As DataRow In _DT_Products.Rows
				If Not row Is Nothing Then
					For Each row1 As DataRow In DT_Ingredients.Rows
						If Not row1 Is Nothing Then
							If row1("ID_Product") = id Then
								MessageBox.Show("El producto ya existe en la receta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
								Exit Sub
							End If
						End If
					Next row1
					If row("Id_Product") = id Then
						DT_Ingredients.Rows.Add(id, row("Name_Product"), row("Id_UnitMeasure_FK"), row("Name_UnitMeasure"), Cantidad, 0)
						MessageBox.Show("Producto agregado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
						Exit For
						Me.Close()
					End If
				End If
			Next row
			Cantidad = txtCantidad.Text.Trim
		ElseIf typeProcess = Process.update
			Dim resp As Integer = 0
			Using objSQl As New Operaciones_SQLServer
				resp = objSQl.ERP_Inventory_UpdateIngredientsRecipe(ID_Ingredient, Cantidad)
			End Using
			If resp = 1 Then
				MessageBox.Show("Producto actualizado exitosamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
			End If
		ElseIf typeProcess = Process.addUpdate
			Dim id_P As Long = cbProducts.SelectedValue
			Dim resp As Integer = 0
			Using objSQl As New Operaciones_SQLServer
				resp = objSQl.ERP_Inventory_ADDRecipe(ID_Recipe, id_P, Cantidad)
			End Using
			If resp = 1 Then
				MessageBox.Show("Producto agregado exitosamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
			ElseIf resp = 2
				MessageBox.Show("El producto ya existe en la receta", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
				Exit Sub
			End If
		End If
		Me.DialogResult=DialogResult.OK
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

'fonomatic
'autoriza,
'callCEnter,
'Gmoney(Consultar EE1)
'reserva Delegate cheques()
'ivrGEn2
'bancamatic
'genPin
