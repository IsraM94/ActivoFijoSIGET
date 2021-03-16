Public Class ERP_Inventory_Out
	Property ID_Header As Long
	Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
		Try
			DETALLE.Rows.Remove(DETALLE.CurrentRow)
		Catch ex As Exception
		End Try
	End Sub

	Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
		Using Obj As New Generic_SeleccionarCliente
			If Obj.ShowDialog = DialogResult.OK Then
				Using ObjProduct As New Generic_SeleccionarProducto
					ObjProduct.Id_Customer_FK = Obj.rowSelection.Item(0)
					If ObjProduct.ShowDialog() = DialogResult.OK Then
						Using objQuantity As New ERP_Inventory_QuantityDialog
							If objQuantity.ShowDialog = DialogResult.OK Then
								DETALLE.Rows.Add(Obj.rowSelection.Item(0), ObjProduct.rowSelection("BarCode"), ObjProduct.rowSelection("Name_UnitMeasure"), ObjProduct.rowSelection("Name_Product"), ObjProduct.rowSelection("Price_Sale"), objQuantity.Quantity)
							End If
						End Using
					End If

				End Using
			End If
		End Using

	End Sub

	Private Sub ERP_Inventory_Out_Load(sender As Object, e As EventArgs) Handles MyBase.Load

	End Sub

	Private Sub cmdProc_Click(sender As Object, e As EventArgs) Handles cmdProc.Click
		Dim type As Integer = 0
		If rbAverias.Checked = True Then
			type = 2
		ElseIf rbTransito.Checked = True
			type = 3
		Else
			type = 4
		End If
		Dim _ID_Company As Integer = 1 REM Borrar
		Dim resp As Integer = 0
		If Not DETALLE.CurrentRow Is Nothing Then
			For Each fila As DataGridViewRow In DETALLE.Rows
				If Not fila Is Nothing Then
					Using ObjSQL As New Generic_SQLServer
						resp = ObjSQL.AddInventory(_ID_Header, _ID_Company, fila.Cells("ID_Proveedor").Value, fila.Cells("Barcode").Value, fila.Cells("Quantity").Value, type)
					End Using
				End If
			Next fila
			If resp = 1 Then
				MessageBox.Show("Salida procesada exitosamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
			Else
				MessageBox.Show("Salida procesada exitosamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error)
			End If
		End If
	End Sub

    Private Sub DETALLE_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DETALLE.CellContentClick

    End Sub
End Class