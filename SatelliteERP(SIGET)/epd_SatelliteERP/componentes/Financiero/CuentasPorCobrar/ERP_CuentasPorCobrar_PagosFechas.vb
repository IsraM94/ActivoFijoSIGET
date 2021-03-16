Public Class ERP_CuentasPorCobrar_PagosFechas
    Property objValidar As New Validaciones
    Property ID_Customer As Long = 0
    Private _MontoRestante As Double = 0
    Private MontoDeuda As Double = 0
    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
		Me.Close()
	End Sub

	Private Sub cmdGrabar_Click(sender As Object, e As EventArgs) Handles cmdGrabar.Click
		If txtMonto.Text.Trim = "" Then
			MessageBox.Show("Por favor ingrese el monto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
			txtMonto.Select()
			Exit Sub
		End If

		If Not IsNumeric(txtMonto.Text.Trim) Then
			MessageBox.Show("Por favor ingrese el monto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
			txtMonto.Select()
			Exit Sub
		End If

        If txtMonto.Text.Trim = 0 Then
            MessageBox.Show("Monto debe de ser mayor que $0.00", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            txtMonto.Select()
            Exit Sub
        End If

        Dim Monto As Double = txtMonto.Text.Trim
		Dim Fecha As Date = dtpFechaCobro.Value
		Dim FirmaCliente As Boolean = False
		Dim FirmaVendedor As Boolean = False
		Dim FirmaDigitador As Boolean = False

		If chkCliente.Checked Then FirmaCliente = True
		If chkDigitador.Checked Then FirmaDigitador = True
		If chkVendedor.Checked Then FirmaVendedor = True
        Dim dtGenerar As New DataTable
        Dim ID_PartialPayments As Long = 0
        Dim Procesado As Integer = 0
        Using objsql As New Financiero_SQLServer
            dtGenerar = objsql.ERP_Finance_PartialPayments(ID_Customer, Fecha, Monto, FirmaCliente, FirmaVendedor, FirmaDigitador)
        End Using
        If Not dtGenerar Is Nothing Then
            If dtGenerar.Rows.Count > 0 Then
                ID_PartialPayments = dtGenerar.Rows(0).Item("ID_PartialPayments")
                Procesado = dtGenerar.Rows(0).Item("resp")
            End If
        End If

        ' monto restante: se utiliza para saber si aun queda disponible del pago.

        Dim DT_Respuesta As New DataTable

        Dim resp As Integer = 0
        If ID_PartialPayments > 0 And Procesado = 1 Then
            resp = AddPayment(Monto, ID_PartialPayments)

            If resp = 1 Then
                MessageBox.Show("Pago procesado exitosamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf resp = 2 Then
                MessageBox.Show("No existen deudas para este cliente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ElseIf resp = 5 Then
                MessageBox.Show("El monto sobrepasa la deuda total, " & vbCrLf & "La deuda total es: " & MontoDeuda.ToString("$###,###,##0.00"), "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf resp = 0 Then
                MessageBox.Show("Ocurrió un error al procesar el pago", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            Dim dt As New DataTable
            Using objSQL As New Financiero_SQLServer
                dt = objSQL.ERP_Finance_Report_PartialPayments(ID_Customer, Fecha, Fecha)
            End Using
            Using objPartidaContable As New Financiero_ReportViewer(dt, "DataReport", "epd_SatelliteERP.Reporte_PagosParciales.rdlc")
                objPartidaContable.ShowDialog()
            End Using
            Me.Close()
        ElseIf ID_PartialPayments = 0 And Procesado = 2 Then
            MontoDeuda = dtGenerar.Rows(0).Item("MontoDeuda")
            MessageBox.Show("El monto sobrepasa la deuda total, " & vbCrLf & "La deuda total es: " & MontoDeuda.ToString("$###,###,##0.00"), "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        Else

            MessageBox.Show("Ocurrió un error al procesar el pago", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End If
	End Sub

	Private Function AddPayment(ByVal Monto As Double, ByVal ID_PartialPayments As Long)
		Dim DT_Respuesta As New DataTable
		Dim resp As String = ""
		Using objsql As New Financiero_SQLServer
			DT_Respuesta = objsql.ERP_Finance_PartialPaymentsDetails(ID_Customer, Monto, ID_PartialPayments)
			If DT_Respuesta.Rows.Count > 0 Then
				_MontoRestante = DT_Respuesta.Rows(0).Item("Disponible")
				resp = DT_Respuesta.Rows(0).Item("resp")
			End If
		End Using
        If resp = 1 Then
            'proceso finalizado
            resp = 1
        ElseIf resp = 2 Then
            ' generar cuenta por pagar
            resp = 2
            'Using objPayable As New ERP_Inventory_Dialog_ConfigureAccountPayable
            '    objPayable.Id_Customer = ID_Customer
            '    objPayable.MontoTotal = _MontoRestante
            'End Using

        ElseIf resp = 4 Then
            AddPayment(_MontoRestante, ID_PartialPayments)
        ElseIf resp = 5 Then
            resp = 5
            MontoDeuda = DT_Respuesta.Rows(0).Item("MontoDeuda")
        Else
			resp = 0
		End If

		Return resp
	End Function

    Private Sub txtMonto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMonto.KeyPress
        If Char.IsControl(e.KeyChar) = False Then
            e.Handled = objValidar.Validar_Money(sender, e, txtMonto)
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