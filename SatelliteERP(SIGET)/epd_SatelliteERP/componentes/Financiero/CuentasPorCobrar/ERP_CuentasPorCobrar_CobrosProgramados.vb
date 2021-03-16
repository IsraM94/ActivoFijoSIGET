Public Class ERP_CuentasPorCobrar_CobrosProgramados

	Private _DT_Clients As New DataTable
	Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
		Me.Close()
	End Sub

	Private Sub cmdGrabar_Click(sender As Object, e As EventArgs) Handles cmdGrabar.Click
		If Not dgvClientes.RowCount = 0 Then
			Dim dt As New DataTable
			dt.Columns.Add("Nombre")
			dt.Columns.Add("Fecha")
			dt.Columns.Add("monto")
			dt.Columns.Add("Firma1")
			dt.Columns.Add("Firma2")
			dt.Columns.Add("Firma3")
			dt.Columns.Add("monto2")
			Dim Anio As Integer = dtpFechaCobro.Value.ToString("yyyy")
			Dim mes As Integer = dtpFechaCobro.Value.ToString("MM")
			Dim diasMes As Integer = DateTime.DaysInMonth(Anio, mes)
			Dim fechas As Date
			Dim Add As Boolean = False
			Dim Nombre As String = ""
			Dim report As Boolean = False
			For Each dgvRow As DataGridViewRow In dgvClientes.Rows
				If dgvRow.Cells("Activo").Value Then
					report = True
					Nombre = dgvRow.Cells("Name_Company").Value
					For i = 1 To diasMes
						fechas = New Date(Anio, mes, i)
						If rbTodos.Checked Then
							dt.Rows.Add(Nombre, fechas.ToString("dd/MM/yyyy"), "", "", "", "", "")
						Else
							Dim Dia As Integer = Weekday(fechas)
							If Dia = 1 And chkLunes.Checked Then
								Add = True
							ElseIf Dia = 2 And chkMartes.Checked Then
								Add = True
							ElseIf Dia = 3 And chkMiercoles.Checked Then
								Add = True
							ElseIf Dia = 4 And chkJueves.Checked Then
								Add = True
							ElseIf Dia = 5 And chkViernes.Checked Then
								Add = True
							ElseIf Dia = 6 And chkSabado.Checked Then
								Add = True
							ElseIf Dia = 7 And chkDomingo.Checked Then
								Add = True
							End If

							If Add Then
								dt.Rows.Add(Nombre, fechas.ToString("dd/MM/yyyy"), "", "", "", "", "")
							End If
							Add = False
						End If
					Next i
				End If
				Dim a = dt.Rows.Count
			Next dgvRow
			If report Then
				Using objPartidaContable As New Financiero_ReportViewer(dt, "DataSet1", "epd_SatelliteERP.Reporte_PagosPorFecha.rdlc")
					objPartidaContable.ShowDialog()
				End Using
			Else
				MessageBox.Show("Por favor seleccione un proveedor para generar el cobro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
			End If
		End If
	End Sub

	Private Sub ERP_CuentasPorCobrar_CobrosProgramados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		loadDgv()
		DisableDays()
	End Sub

	Private Sub loadDgv()
		Using objGeneric As New Generic_SQLServer
			_DT_Clients = objGeneric.GetCustomerClientList(_ID_Company, -1, -1, -1, 1)
			dgvClientes.DataSource = _DT_Clients
		End Using

	End Sub

	Private Sub rbTodos_CheckedChanged(sender As Object, e As EventArgs) Handles rbTodos.CheckedChanged
		DisableDays()
	End Sub


	Private Function Days(ByVal fecha As Date) As String
		Dim resp As String = ""
		resp = fecha.ToString("dddd")
		Return resp
	End Function

	Private Sub DisableDays()
		chkLunes.Enabled = False
		chkMartes.Enabled = False
		chkMiercoles.Enabled = False
		chkJueves.Enabled = False
		chkViernes.Enabled = False
		chkSabado.Enabled = False
		chkDomingo.Enabled = False

		chkLunes.Checked = False
		chkMartes.Checked = False
		chkMiercoles.Checked = False
		chkJueves.Checked = False
		chkViernes.Checked = False
		chkSabado.Checked = False
		chkDomingo.Checked = False
	End Sub

	Private Sub EnableDays()
		chkLunes.Enabled = True
		chkMartes.Enabled = True
		chkMiercoles.Enabled = True
		chkJueves.Enabled = True
		chkViernes.Enabled = True
		chkSabado.Enabled = True
		chkDomingo.Enabled = True

		chkLunes.Checked = True
	End Sub

	Private Sub rbEspecificos_CheckedChanged(sender As Object, e As EventArgs) Handles rbEspecificos.CheckedChanged
		EnableDays()
	End Sub

	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		If Not dgvClientes.RowCount = 0 Then
			Dim dt As New DataTable
			dt.Columns.Add("ID", Type.GetType("System.String"))
			dt.Columns.Add("Nombre")
			dt.Columns.Add("Fecha")
			dt.Columns.Add("monto")
			dt.Columns.Add("Firma1")
			dt.Columns.Add("Firma2")
			dt.Columns.Add("Firma3")
			dt.Columns.Add("monto2")
			Dim Anio As Integer = dtpFechaCobro.Value.ToString("yyyy")
			Dim mes As Integer = dtpFechaCobro.Value.ToString("MM")
			Dim diasMes As Integer = DateTime.DaysInMonth(Anio, mes)
			Dim fechas As Date
			Dim Add As Boolean = False
			Dim Nombre As String = ""
			Dim report As Boolean = False
			Dim id As Integer = 1
			For Each dgvRow As DataGridViewRow In dgvClientes.Rows
				If dgvRow.Cells("Activo").Value Then
					report = True
					Nombre = dgvRow.Cells("Name_Company").Value
					For i = 1 To diasMes
						fechas = New Date(Anio, mes, i)
						If rbTodos.Checked Then
							dt.Rows.Add(id, Nombre, fechas.ToString("dd/MM/yyyy"), "", "", "", "", "")
						Else
							Dim Dia As Integer = Weekday(fechas)
							If Dia = 1 And chkLunes.Checked Then
								Add = True
							ElseIf Dia = 2 And chkMartes.Checked Then
								Add = True
							ElseIf Dia = 3 And chkMiercoles.Checked Then
								Add = True
							ElseIf Dia = 4 And chkJueves.Checked Then
								Add = True
							ElseIf Dia = 5 And chkViernes.Checked Then
								Add = True
							ElseIf Dia = 6 And chkSabado.Checked Then
								Add = True
							ElseIf Dia = 7 And chkDomingo.Checked Then
								Add = True
							End If

							If Add Then
								dt.Rows.Add(id, Nombre, fechas.ToString("dd/MM/yyyy"), "", "", "", "", "")
							End If
							Add = False
						End If
					Next i
				End If
				id += 1
				Dim a = dt.Rows.Count
			Next dgvRow
			If report Then
				Using objPartidaContable As New Financiero_ReportViewer(dt, "DataSet1", "epd_SatelliteERP.Reporte_PagosPorFechaV2.rdlc")
					objPartidaContable.ShowDialog()
				End Using
			Else
				MessageBox.Show("Por favor seleccione un proveedor para generar el cobro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
			End If
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