Public Class ERP_Inventory_SubProducts
	Property ID_Product As Long = 0
	Property ID_Bodega As Long = 0
	Private _DT_SubProducts As New DataTable
	Private Sub LoadSubProducts()
		Using objSQL As New Operaciones_SQLServer
			_DT_SubProducts = objSQL.SP_ERP_InventoryGetSubProducts(ID_Product, ID_Bodega)
		End Using
		dgvProducts.DataSource = _DT_SubProducts
	End Sub
	Private Sub ERP_Inventory_SubProducts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		LoadSubProducts()
	End Sub

	Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
		Me.Close()
	End Sub

	Private Sub cmdAdd_Click(sender As Object, e As EventArgs) Handles cmdAdd.Click
		Using objadd As New ERP_Inventory_Dialog_CreateSubProduct
			objadd.TipoProceso = ERP_Inventory_Dialog_CreateSubProduct.Process.add
			If objadd.ShowDialog() = DialogResult.OK Then
				Using objsql As New Operaciones_SQLServer
					Dim resp As Integer = objsql.SP_ERP_InventoryAddSubProducts(ID_Product, objadd.NameProduct, objadd.PriceProduct, ID_Bodega, _ID_Company)
					If resp = 1 Then
						MessageBox.Show("Subproducto agregado exitosamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
						LoadSubProducts()
					Else
                        MessageBox.Show("Ocurrió un error al agregar el subproducto", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
				End Using
			End If
		End Using
	End Sub

	Private Sub cmdUpdate_Click(sender As Object, e As EventArgs) Handles cmdUpdate.Click
		If Not dgvProducts.CurrentRow Is Nothing Then
			Using objUpdate As New ERP_Inventory_Dialog_CreateSubProduct
				objUpdate.TipoProceso = ERP_Inventory_Dialog_CreateSubProduct.Process.update
				Dim ID_SubProduct As Long = dgvProducts.CurrentRow.Cells("ID_SubProduct").Value
				objUpdate.NameProduct = dgvProducts.CurrentRow.Cells("NameProduct").Value
				objUpdate.PriceProduct = dgvProducts.CurrentRow.Cells("Price").Value
				If objUpdate.ShowDialog() = DialogResult.OK Then
					Using objSQl As New Operaciones_SQLServer
						Dim resp As Integer = objSQl.SP_ERP_InventoryUpdateSubProducts(ID_SubProduct, objUpdate.NameProduct, objUpdate.PriceProduct)
						If resp = 1 Then
							MessageBox.Show("Subproducto actualizado exitosamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
							LoadSubProducts()
						Else
                            MessageBox.Show("Ocurrió un error al actualizar el subproducto", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
					End Using
				End If
			End Using
		End If
	End Sub

    Private Sub dgvProducts_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProducts.CellContentClick

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