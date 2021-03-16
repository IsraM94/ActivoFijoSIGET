Public Class ERP_CuentasPorCobrar_AgregarCobro

    Private _Dt_DatosCliente As New DataTable
    Private _Id_row As Long = 0
    Private _Dt_Pagos As New DataTable
    Private _Id_AccountReceivable As Long
    Property Id_Customer As Long = 0
    Property IS_Calendar As Boolean = False
    Property ID_Cuenta As Long = 0
    Property ID_Cuota As Long = 0
    Private _CodigoCuota As Long = 0
    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub


    Private Sub ERP_CobrosCuentaporCobrar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillcbEmpleado()
        FillcbEmpresa()
		If txtSaldo.TEXT <> "" Then
			txtSaldo.Text = String.Format("{0:$#,###,###,###.##}", Convert.ToDouble(txtSaldo.Text))
		End If
		If _Id_AccountReceivable > 0 Then

		End If
	End Sub


    Private Sub cmdBuscar_Click(sender As Object, e As EventArgs) Handles cmdBuscar.Click
        'Using objBuscar As New ERP_BuscarCobro
        '    If objBuscar.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
        '        _Dt_DatosCliente = objBuscar.DT_Credit
        '        _Id_row = objBuscar.row
        '    End If
        'End Using

    End Sub

    Private Sub rbFiniquito_CheckedChanged(sender As Object, e As EventArgs) Handles rbFiniquito.CheckedChanged
        If rbFiniquito.Checked = True Then
            cbNCuota.Enabled = False
            lblEnunciadoFecha.Visible = False
            lblFechaMaxPago.Visible = False
            txtCantidadPagar.Text = txtSaldo.Text
            cbNCuota.SelectedIndex = -1
        ElseIf rbFiniquito.Checked = False Then
            cbNCuota.Enabled = True
            lblEnunciadoFecha.Visible = True
            lblFechaMaxPago.Visible = True
            txtCantidadPagar.Text = ""
        End If
    End Sub

    Private Sub rbEfectivo_CheckedChanged(sender As Object, e As EventArgs) Handles rbEfectivo.CheckedChanged
        If rbEfectivo.Checked = False Then
            txtCantidadCambio.Enabled = False
            txtCantidadEntrego.Enabled = False
            txtCantidadEntrego.Text = txtCantidadPagar.Text
        ElseIf rbEfectivo.Checked = True Then
            txtCantidadEntrego.Clear()
            txtCantidadCambio.Enabled = True
            txtCantidadEntrego.Enabled = True
        End If
    End Sub

    Private Sub txtCantidadPagar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCantidadPagar.KeyPress
        Using objval As New Validaciones
            e.Handled = objval.Money(sender, e)
        End Using
    End Sub

    Private Sub txtCantidadEntrego_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCantidadEntrego.KeyPress
        Using objval As New Validaciones
            e.Handled = objval.Validar_Money(sender, e, txtCantidadEntrego)
        End Using
    End Sub

    Private Sub txtCodigoEmpleado_KeyPress(sender As Object, e As KeyPressEventArgs)
        Using objval As New Validaciones
            e.Handled = objval.JustNumbers(sender, e)
        End Using
    End Sub

    Private Sub Fillpago()
        Using objsql As New Generic_SQLServer
            If IS_Calendar Then
                _Dt_Pagos = objsql.GetPagoRestante(ID_Cuenta)
            Else
                _Dt_Pagos = objsql.GetPagoRestante(_Id_AccountReceivable)
            End If

        End Using
        Try
            If _Dt_Pagos IsNot Nothing Then
                If _Dt_Pagos.Rows.Count <> 0 Then
                    RemoveHandler cbNCuota.SelectedIndexChanged, AddressOf cbNCuota_SelectedIndexChanged
                    cbNCuota.DataSource = _Dt_Pagos
                    cbNCuota.DisplayMember = "QuotaNumber"
                    cbNCuota.ValueMember = "ID_AccountsDetails"
                    cbNCuota.SelectedIndex = -1
                    AddHandler cbNCuota.SelectedIndexChanged, AddressOf cbNCuota_SelectedIndexChanged
                    txtSaldo.Text = _Dt_Pagos.Rows(0).Item("payout")
                Else
                    Me.Close()

                End If
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub FillcbEmpresa()
        Using objsql As New Generic_SQLServer
            _Dt_DatosCliente = objsql.SearchCobros(Data_Id_Company, Id_Customer, 2) ' Tipo de busqueda 2 para ID_Customer
        End Using

        If IS_Calendar Then
            For Each row As DataRow In _Dt_DatosCliente.Rows
                If Not row Is Nothing Then
                    If row("ID_AccountsList") = ID_Cuenta Then
                        txtcliente.Text = _Dt_DatosCliente.Rows(_Id_row).Item("Name_Company")
                        txtCodigoCliente.Text = _Dt_DatosCliente.Rows(_Id_row).Item("ID_Customer_FK")
                        txtDocCredito.Text = _Dt_DatosCliente.Rows(_Id_row).Item("Description")
                        txtDocumento.Text = _Dt_DatosCliente.Rows(_Id_row).Item("DocumentNumber")
                        txtLinea.Text = _Dt_DatosCliente.Rows(_Id_row).Item("TypeCreditLine")
                        txtConcepto.Text = _Dt_DatosCliente.Rows(_Id_row).Item("Concepto")
                        txtCreditoDescipcion.Text = _Dt_DatosCliente.Rows(_Id_row).Item("Description_Credit")
                        _Id_AccountReceivable = _Dt_DatosCliente.Rows(_Id_row).Item("ID_AccountsList")
                        Fillpago()

                        For Each row1 As DataRow In _Dt_Pagos.Rows
                            If Not row1 Is Nothing Then
                                If row1.Item("QuotaNumber") = ID_Cuota.ToString Then
									_CodigoCuota = row1.Item("ID_AccountsDetails")
									cbNCuota.SelectedValue = _CodigoCuota
									cbNCuota.SelectedItem = row1.Item("ID_AccountsDetails")
                                    Dim cantidad As String = Math.Round(row1.Item("Ammount"), 2)
                                    txtCantidadPagar.Text = cantidad
                                    lblFechaMaxPago.Text = row1.Item("PaymentDate")
                                    cbNCuota.Enabled = False
                                    Exit For
                                End If
                            End If
                        Next row1
                        Exit For
                    End If
                End If
            Next row
        Else
            If _Dt_DatosCliente IsNot Nothing Then
                If _Dt_DatosCliente.Rows.Count > 1 Then
                    Using objLista As New ERP_CuentasPorCobrar_ListaLineasCreditos
                        objLista.StartPosition = FormStartPosition.CenterParent
                        objLista.DT_LineasCredito = _Dt_DatosCliente
                        objLista.ShowDialog()
                        _Id_row = objLista.RowSeleccion
                    End Using
                End If

                If Not _Id_row = -1 Then
                    If _Dt_DatosCliente.Rows.Count <> 0 Then
                        txtcliente.Text = _Dt_DatosCliente.Rows(_Id_row).Item("Name_Company")
                        txtCodigoCliente.Text = _Dt_DatosCliente.Rows(_Id_row).Item("ID_Customer_FK")
                        txtDocCredito.Text = _Dt_DatosCliente.Rows(_Id_row).Item("Description")
                        txtDocumento.Text = _Dt_DatosCliente.Rows(_Id_row).Item("DocumentNumber")
                        txtLinea.Text = _Dt_DatosCliente.Rows(_Id_row).Item("TypeCreditLine")
                        txtConcepto.Text = _Dt_DatosCliente.Rows(_Id_row).Item("Concepto")
                        txtCreditoDescipcion.Text = _Dt_DatosCliente.Rows(_Id_row).Item("Description_Credit")
                        _Id_AccountReceivable = _Dt_DatosCliente.Rows(_Id_row).Item("ID_AccountsList")
                        Fillpago()
                    Else
                        MessageBox.Show("No existe plan de pagos activos", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Close()
                    End If
                Else
                    Close()
                End If

            End If
        End If
    End Sub
    Private Sub cbNCuota_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbNCuota.SelectedIndexChanged
        Dim valCuota As Long = 0
        valCuota = cbNCuota.SelectedValue
        For Each row As DataRow In _Dt_Pagos.Rows
            If Not row Is Nothing Then
                If row.Item("ID_AccountsDetails") = valCuota Then
                    Dim cantidad As String = Math.Round(row.Item("Ammount"), 2)
                    txtCantidadPagar.Text = cantidad
                    lblFechaMaxPago.Text = row.Item("PaymentDate")
                End If
            End If
        Next
        If txtCantidadPagar.Text <> "" Then
            txtCantidadPagar.Text = String.Format("{0:$#,###,###,###.##}", Convert.ToDouble(txtCantidadPagar.Text))
        End If
    End Sub

    Private Sub FillcbEmpleado()
        Dim DT_Empleado As New DataTable
        Using objsql As New Generic_SQLServer
            DT_Empleado = objsql.GetContactEmploye(Data_Id_Company)
        End Using
        If DT_Empleado IsNot Nothing Then
            If DT_Empleado.Rows.Count <> 0 Then
                cbEmpleado.DataSource = DT_Empleado
                cbEmpleado.ValueMember = "Id_employee"
                cbEmpleado.DisplayMember = "Contact"
                cbEmpleado.SelectedIndex = -1
            End If
        End If
    End Sub

    Private Sub cmdGrabar_Click(sender As Object, e As EventArgs) Handles cmdGrabar.Click
        Dim Id_Empleado As Long = cbEmpleado.SelectedValue
        Dim res As String = ""
        Dim TipoPago As Long = 0
        If rbEfectivo.Checked = True Then
            TipoPago = 1
        ElseIf rbCheque.Checked = True Then
            TipoPago = 3
        ElseIf rbTarjeta.Checked = True Then
            TipoPago = 2
        End If
        If Not cbEmpleado.SelectedIndex = -1 Then
            If Not txtCantidadPagar.Text = "" Then
                If Not txtCantidadEntrego.Text = "" Then
                    If Convert.ToDouble(txtCantidadEntrego.Text) >= Convert.ToDouble(txtCantidadPagar.Text.Replace("$", "")) Then
                        Using objsql As New Generic_SQLServer
                            If Not IS_Calendar Then
                                _CodigoCuota = cbNCuota.SelectedValue
                            End If
                            If rbCuota.Checked = True Then 'Pago de Cuota
                                Dim dt As New DataTable
                                dt = objsql.InsertAccountReceibaleQuota(Id_Empleado, _Id_AccountReceivable, _CodigoCuota, Data_Id_Company, TipoPago)
                                If Not dt Is Nothing Then
                                    If dt.Rows.Count > 0 Then
                                        Try
                                            If Not dt.Rows(0).Item(0) = "0" Then
                                                MessageBox.Show("Pago realizado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                                Using objPartidaContable As New Financiero_ReportViewer(dt, "DataPago", "epd_SatelliteERP.Reporte_ComprobantePago.rdlc")
                                                    objPartidaContable.ShowDialog()
                                                End Using
                                                Me.Close()
                                            Else
                                                MessageBox.Show("Ocurrió un error al procesar el cobro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                                            End If
                                        Catch ex As Exception
                                            MessageBox.Show("Ocurrió un error al procesar el cobro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                                        End Try
                                    End If
                                End If
                            Else
                                rbCuota.Checked = False 'Finiquitar Deuda
                                res = objsql.InsertAccountReceibaleFinalize(Id_Empleado, _Id_AccountReceivable, Data_Id_Company, TipoPago)
                            End If

                            If res = "ok" Then
                                DialogResult = DialogResult.OK
                            Else

                            End If
                        End Using
                    End If

                Else
                    MessageBox.Show("Ingrese la cantidad entregada ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                End If
            Else
                MessageBox.Show("Seleccione una cuota", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            End If
        Else
            MessageBox.Show("Seleccione el empleado que realiza el cobro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End If
    End Sub

    Private Sub txtCantidadEntrego_TextChanged(sender As Object, e As EventArgs) Handles txtCantidadEntrego.TextChanged
		If Not txtCantidadPagar.Text.Trim = "" Then
			If Not txtCantidadEntrego.Text.Trim = "" Then
				Dim pago As Double = Convert.ToDouble(txtCantidadEntrego.Text)
				Dim debe As Double = Convert.ToDouble(txtCantidadPagar.Text.ToString.Replace("$", ""))
				If IsNumeric(pago) Then
					If pago >= debe Then
						txtCantidadCambio.Text = (pago - debe).ToString("$ ###,###,##0.00")
					Else
						txtCantidadCambio.Text = ((debe - pago) * -1).ToString("$ ###,###,##0.00")
					End If
				Else
					txtCantidadCambio.Text = ("E")
				End If
			Else
				txtCantidadEntrego.Clear()
				txtCantidadCambio.Clear()
			End If
		Else
			txtCantidadEntrego.Clear()
			txtCantidadCambio.Clear()
		End If
    End Sub

    Private Sub clearCliente()
        txtcliente.Clear()
        txtCantidadEntrego.Clear()
        txtCantidadPagar.Clear()
        txtCantidadCambio.Clear()
        txtCodigoCliente.Clear()
        txtConcepto.Clear()
        txtSaldo.Clear()
        txtLinea.Clear()
        txtDocumento.Clear()
        txtDocCredito.Clear()
        txtCreditoDescipcion.Clear()
        cbNCuota.DataSource = Nothing
        _Dt_DatosCliente = Nothing
        _Id_row = 0
        _Dt_Pagos = Nothing
        _Id_AccountReceivable = 0
    End Sub

	Private Sub cmdAnular_Click(sender As Object, e As EventArgs) Handles cmdAnular.Click
		Dim ID_Employee As Long = 0
		Dim ID_Catalog As Long = 0
		Dim Commentary As String = ""
		Dim resp As Integer = 0
		If cbNCuota.SelectedIndex = -1 Then
			MessageBox.Show("Por favor seleccione la cuota a cancelar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
			Exit Sub
		End If
		If rbCuota.Checked Then
			_CodigoCuota = cbNCuota.SelectedValue
			Using objInfo As New Generic_DataRequest
				If objInfo.ShowDialog() = DialogResult.OK Then
					ID_Employee = objInfo.ID_Employee
					ID_Catalog = objInfo.ID_Catalog
					Commentary = objInfo.Commentary
					Using objSQl As New Financiero_SQLServer
						resp = objSQl.ERP_Generic_Add_RequestBox(1, ID_Employee, _CodigoCuota, ID_Catalog, 0, Commentary)
					End Using
					If resp = 1 Then
						MessageBox.Show("Solicitud ingresada exitosamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
						Me.Close()
					ElseIf resp = 2
						MessageBox.Show("Ya existe una solicitud para esta cuota, se encuentra en espera de aprobación", "Información", MessageBoxButtons.OK, MessageBoxIcon.Stop)
					Else
                        MessageBox.Show("Ocurrió un error al agregar la solicitud", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
				End If
			End Using
		Else
            MessageBox.Show("No se puede anular la cuenta completa", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
	End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub
End Class