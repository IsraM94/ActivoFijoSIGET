Imports System.Data.SqlClient

Public Class ReporteVentas

    Private _dataReporte As DataTable


	Private Sub AddTipoFactutaCombo(ByVal TipodeVenta As String)
		For Each s As String In ListBox_Factura.Items
			If s = TipodeVenta Then
				Exit Sub
			End If
		Next
		ListBox_Factura.Items.Add(TipodeVenta)
	End Sub
	Private Sub AddTipoPagoCombo(ByVal tipoPago As String)
		For Each s As String In ListBox_Pago.Items
			If s = tipoPago Then
				Exit Sub
			End If
		Next
		ListBox_Pago.Items.Add(tipoPago)
	End Sub




	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		Dim dt As New DataTable
		Dim fecha As Date = DateTimePicker1.Value
		Using objSQL As New Financiero_SQLServer
			If CB_Sumar.Checked Then
				dt = objSQL.ERP_Finance_DailySalesSUM(fecha)
			Else
				dt = objSQL.ERP_Finance_DailySales(fecha)
			End If
		End Using
		dgvReporte.DataSource = Nothing
		_dataReporte = Nothing
		dgvReporte.DataSource = dt
		_dataReporte = dt
		ListBox_Factura.Items.Clear()
		ListBox_Factura.Items.Add("(TODOS)")
		ListBox_Factura.SelectedIndex = 0
		ListBox_Pago.Items.Clear()
		ListBox_Pago.Items.Add("(TODOS)")
		ListBox_Pago.SelectedIndex = 0
		Dim TipoPagoDescripcion As String = ""
		For Each row As DataRow In dt.Rows
			If IsDBNull(row("TipoPagoDescripcion")) = False Then
				TipoPagoDescripcion = row("TipoPagoDescripcion")
			End If
			AddTipoFactutaCombo(row("TipodeVenta"))
			AddTipoPagoCombo(TipoPagoDescripcion)
		Next
	End Sub

	Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
		If (SaveFileDialog1.ShowDialog() = DialogResult.OK) Then
			Dim pathReporte As String = SaveFileDialog1.FileName

			For i As Integer = 0 To _dataReporte.Columns.Count - 1
				If (i = _dataReporte.Columns.Count - 1) Then
					System.IO.File.AppendAllText(pathReporte, _dataReporte.Columns(i).ColumnName & vbCrLf)
				Else
					System.IO.File.AppendAllText(pathReporte, _dataReporte.Columns(i).ColumnName & ",")
				End If
			Next
			Dim _genera As Boolean = True
			For Each registro As DataRow In _dataReporte.Rows
				If ListBox_Factura.Text = "(TODOS)" Then
					If ListBox_Pago.Text = "(TODOS)" Then
						_genera = True
					Else
						If ListBox_Pago.Text = registro("TipoPagoDescripcion") Then
							_genera = True
						Else
							_genera = False
						End If
					End If
				Else
					If ListBox_Factura.Text = registro("TipodeVenta") Then
						If ListBox_Pago.Text = "(TODOS)" Then
							_genera = True
						Else
							If ListBox_Pago.Text = registro("TipoPagoDescripcion") Then
								_genera = True
							Else
								_genera = False
							End If
						End If
					Else
						_genera = False
					End If
				End If

				If _genera Then
					For i As Integer = 0 To _dataReporte.Columns.Count - 1
						If (i = _dataReporte.Columns.Count - 1) Then
							System.IO.File.AppendAllText(pathReporte, registro(i).ToString().Replace(",", "") & vbCrLf)
						Else
							System.IO.File.AppendAllText(pathReporte, registro(i).ToString().Replace(",", "") & ",")
						End If
					Next
				End If
			Next
		End If
	End Sub

	Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
		Me.Close()
	End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class