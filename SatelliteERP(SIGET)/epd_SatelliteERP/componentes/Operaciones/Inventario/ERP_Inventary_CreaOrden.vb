Imports System.IO

Public Class ERP_Inventary_CreaOrden

	Property IS_Sugerido As Boolean = False
	Property ID_Stowage As Long = 0
	Property ID_CUSTOMER As Long = 0
	Private _DT_SUGERIDO As New DataTable
	Private _TIPO_ORDEN As Integer = 0
	Property objCustomerRow As DataRow
	Sub New()
		InitializeComponent()
	End Sub
	Private Sub Financiero_DocumentoFiscal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		DETALLE.Font = New Font("Segoe UI", 11)
		DETALLE.Columns(0).Width = 140
		DETALLE.Columns(1).Width = 80
		DETALLE.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
		DETALLE.Columns(2).Width = 280
		DETALLE.Columns(3).Width = 100
		DETALLE.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
		DETALLE.Columns(3).DefaultCellStyle.Format = "c"
		DETALLE.Columns(4).Width = 100
		DETALLE.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
		DETALLE.Columns(4).DefaultCellStyle.Format = "c"
		DETALLE.Columns(5).Width = 100
		DETALLE.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
		DETALLE.Columns(5).DefaultCellStyle.Format = "c"
		DETALLE.Columns(6).Width = 100
		DETALLE.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
		DETALLE.Columns(6).DefaultCellStyle.Format = "c"
		DETALLE.Columns(7).Width = 100
		DETALLE.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
		DETALLE.Columns(7).DefaultCellStyle.Format = "c"
		DETALLE.ReadOnly = True
		DETALLE.SelectionMode = DataGridViewSelectionMode.FullRowSelect
		DETALLE.MultiSelect = False
		DETALLE.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
		DETALLE.AllowUserToResizeColumns = False
		DETALLE.AllowUserToAddRows = False
		DETALLE.AllowUserToDeleteRows = False
		txtRazonSocial.Text = objCustomerRow.Item("Name_Company")
		txtNIT.Text = objCustomerRow.Item("Tax_Identification_Number")
		txtNRC.Text = objCustomerRow.Item("Tax_Registration_Number")
		txtPartida_NoPartida.Text = objCustomerRow.Item("Id_Customer")

		If IS_Sugerido Then

			If ID_Stowage = 0 Then
				_TIPO_ORDEN = 0
			Else
				_TIPO_ORDEN = 1
			End If
			Using objsql As New Operaciones_SQLServer
				_DT_SUGERIDO = objsql.ERP_SP_Inventory_SuggestedShopping(ID_Stowage, _TIPO_ORDEN, ID_CUSTOMER)
			End Using

			If Not _DT_SUGERIDO Is Nothing Then
				If _DT_SUGERIDO.Rows.Count > 0 Then
					For Each row As DataRow In _DT_SUGERIDO.Rows
						If Not row Is Nothing Then
							If (row("Sugerido") > 0) Then


								Dim borrar As String = ""
								Dim IsGrabado As Boolean = True
								Dim TotalProductos As Double = row("Sugerido")
								Dim TotalGrabados As Decimal = 0D
								Dim TotalExentos As Decimal = 0D

								If row("Exento") Then
									IsGrabado = False
								Else
									IsGrabado = True
								End If

								Try
									If IsGrabado Then
										TotalGrabados = TotalProductos * row("Price_LastPpurchase") * (1 + Data_TaxPercentage)
									Else
										TotalExentos = TotalProductos * row("Price_LastPpurchase")
									End If
									DETALLE.Rows.Add(TotalProductos, row("Name_UnitMeasure"), row("Name_Product"), row("Price_LastPpurchase"), 0.00, TotalExentos.ToString("######0.00"), TotalGrabados.ToString("######0.00"), IsGrabado, row("Id_Product"))
								Catch ex As Exception

								End Try
								CalcularTotales()
							End If
						End If
					Next row
				Else
					' no existe sugerido
				End If
			Else
				' no existe sugerido
			End If
		End If
	End Sub

	Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
		DialogResult = DialogResult.No
		Close()
	End Sub

	Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
		Using objProductSelect As New Generic_SeleccionarProducto
			objProductSelect.Id_Customer_FK = txtPartida_NoPartida.Text
			If objProductSelect.ShowDialog() = DialogResult.OK Then


                REM DETALLE.Rows.Add(txtCantidadProd.Text, Unidad, cb_Productos.Text, precioSinIva, "0.00", totalPrecioExento.ToString("######0.00"), totalPrecioSinIva.ToString("######0.00"), IsGrabado)

                Dim borrar As String = ""

				Dim IsGrabado As Boolean = True
				Dim TotalProductos As Integer = 1 ' Se tiene que pedir al usuario
                Using objNoDoc As New Financiero_DocumentoFiscalDigiteNumero
					objNoDoc.GroupBox1.Text = "Cantidad Productos"
					objNoDoc.NumeroFactura = TotalProductos
					objNoDoc.StartPosition = FormStartPosition.CenterParent
					If objNoDoc.ShowDialog = DialogResult.OK Then
						TotalProductos = objNoDoc.NumeroFactura
					Else
						Exit Sub
					End If
				End Using


				Dim TotalGrabados As Decimal = 0D
				Dim TotalExentos As Decimal = 0D
				Try
					IsGrabado = Not objProductSelect.rowSelection("IsExempt")
				Catch ex As Exception
					IsGrabado = True
				End Try
				Try
					If IsGrabado Then
						TotalGrabados = TotalProductos * objProductSelect.rowSelection("Price_LastPpurchase") ' * (1 + Data_TaxPercentage)
					Else
                        TotalExentos = TotalProductos * objProductSelect.rowSelection("Price_LastPpurchase")
                    End If
                    DETALLE.Rows.Add(TotalProductos, objProductSelect.rowSelection("Name_UnitMeasure"), objProductSelect.rowSelection("Name_Product"), objProductSelect.rowSelection("Price_LastPpurchase"), 0.00, TotalExentos.ToString("######0.00"), TotalGrabados.ToString("######0.00"), IsGrabado, objProductSelect.rowSelection("id_product"))

                Catch ex As Exception

				End Try
			End If
			CalcularTotales()
		End Using
	End Sub
	Private Sub CalcularTotales(Optional ByVal IsRetencion As Boolean = False)
		Dim TotalGrabos As Decimal = 0.0
		Dim TotalExentos As Decimal = 0.0
		Dim TotalIva As Decimal = 0.0
		Dim TotalRetencion As Decimal = 0.0
		For Each row As DataGridViewRow In DETALLE.Rows
			TotalGrabos += row.Cells("VentasGrabadas").Value
			TotalExentos += row.Cells("VentasExentas").Value
		Next
		TotalIva = Math.Round(TotalGrabos * Data_TaxPercentage, 2)
		If IsRetencion Then
			TotalRetencion = TotalGrabos * 0.01 'TotalIva  * 0.01
        Else
			TotalRetencion = 0.0
		End If

		'txtTotalVenta.Text = (TotalGrabos + TotalIva + TotalExentos - TotalRetencion).ToString("#,###,##0.00")
		txtTotalVenta.Text = (TotalGrabos + TotalExentos - TotalRetencion).ToString("#,###,##0.00")
	End Sub

	Private Sub cmdPreview_Click(sender As Object, e As EventArgs)
		ImprimirFacturas(False)

	End Sub

	Private Sub cmdPrint_Click(sender As Object, e As EventArgs) Handles cmdPrint.Click
		If Not DETALLE.CurrentRow Is Nothing Then 'validar que gridview no este vacio 

            Using Obj As New ERP_Inventory_ProgressBarSuggested
				Obj.Type = ERP_Inventory_ProgressBarSuggested.Process.GenerateUser ' orden generada por el usuario
                Obj.data = DETALLE
				Obj.ID_Customer = objCustomerRow.Item("Id_Customer")
				Obj.ShowDialog()
			End Using
            'ImprimirFacturas(True)
            DialogResult = DialogResult.OK
			Close()
		End If

	End Sub
	Private Function ImprimirFacturas(ByVal IsPrinter As Boolean) As String
		Using objFinance As New Financiero_SQLServer
            'TODO:Se tiene que configurar para procesar otros documentos.
            Dim ID_Type_Billing As Integer = 1
			Dim _tableConfigBilling As DataTable = objFinance.GetConfigBilling_Select(Data_Id_Company, ID_Type_Billing)
			Dim ds As New DataSet

			Dim xmlDatos As System.IO.StringReader = New System.IO.StringReader(_tableConfigBilling.Rows(0)("Config_XML"))
			Dim xmlSchema As System.IO.StringReader = New System.IO.StringReader(_tableConfigBilling.Rows(0)("Schema_XML"))
			ds.ReadXmlSchema(xmlSchema)
			ds.ReadXml(xmlDatos)
            'CREDITO FISCAL
            'CONSUMIDOR FINAL
            Dim imagen As New PictureBox

			Dim imageData As Byte() = DirectCast(_tableConfigBilling.Rows(0)("picture"), Byte())
			If Not imageData Is Nothing Then
				Using ms As New MemoryStream(imageData, 0, imageData.Length)
					ms.Write(imageData, 0, imageData.Length)
					imagen.Image = Image.FromStream(ms, True)
				End Using
			End If

			Dim obj As New Config_Factua("CREDITO FISCAL", ds, imagen)
			obj.FacEncabezado(txtPartida_NoPartida.Text, txtRazonSocial.Text, txtNRC.Text, txtNIT.Text, Now, "La Direccion", "SOFTWARE",
							  "Sucursal", "Vendedor", CB_FormaPago.Text, "", "San Salvador")

			For Each row As DataGridViewRow In DETALLE.Rows
				If Not row.Cells("Cantidad").Value.ToString() = "" Then
					obj.facDetalle(0, row.Cells("Cantidad").Value,
									   row.Cells("Unidad").Value,
									   row.Cells("Descripcion").Value,
									   row.Cells("PrecioUnitario").Value, 0,
									   row.Cells("VentasExentas").Value,
									   row.Cells("VentasGrabadas").Value, False)

				End If
			Next
			'Dim subTotal As Decimal = CDec(txtIva.Text) + CDec(txtSubTotal.Text)
			'obj.FacResumen(0, txtSubTotal.Text, txtIva.Text, subTotal, 0, 0, txtTotalExentas.Text, txtTotalVenta.Text, txtRetencion.Text)
			'If IsPrinter Then
			'    obj.Imprimir()
			'Else
			Using objPreview As New Financiero_PreviewDocFiscal

				objPreview.objFactura = obj
				objPreview.ShowDialog()
			End Using


            'End If
        End Using
		Return "OK"
        'TODO: Validar esta parte que se garantice que devuelve OK si se imprimio la factura de una forma adecuada.
    End Function

	Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
		Try
			DETALLE.Rows.Remove(DETALLE.CurrentRow)
		Catch ex As Exception
		End Try

	End Sub

	Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

	End Sub

    Private Sub DETALLE_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DETALLE.CellContentClick

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