Public Class ERP_CuentasPorPagar_AgregarCobro

    Private _Dt_DatosCliente As New DataTable
    Private _Id_row As Long = 0
    Private _Dt_Pagos As New DataTable
    Private _Id_AccountReceivable As Long
    Property _Id_PayDue As Long
    Property _IsDue As Boolean = False
    Private _Fecha_Pago As Date
    Private _NCheque As String
    Property Id_Customer As Long = 0
    Property IS_Calendar As Boolean = False
    Property ID_Cuenta As Long = 0
    Property ID_Cuota As Long = 0
    Private _CodigoCuota As Long = 0

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub


    Private Sub ERP_CobrosCuentaporPagar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillcbEmpleado()
        FillcbEmpresa()
        If txtSaldo.Text <> "" Then
            txtSaldo.Text = String.Format("{0:$#,###,###,###.##}", Convert.ToDouble(txtSaldo.Text))
        End If
    End Sub


    Private Sub cmdBuscar_Click(sender As Object, e As EventArgs)
        'Using objBuscar As New ERP_BuscarCobro
        '    If objBuscar.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
        '        _Dt_DatosCliente = objBuscar.DT_Credit
        '        _Id_row = objBuscar.row
        '    End If
        'End Using

    End Sub

    Private Sub rbFiniquito_CheckedChanged(sender As Object, e As EventArgs)
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

    Private Sub rbEfectivo_CheckedChanged(sender As Object, e As EventArgs)
        If rbEfectivo.Checked = False Then
            txtCheque.Enabled = False
        ElseIf rbEfectivo.Checked = True Then
            txtCheque.Enabled = True
        End If
    End Sub

    Private Sub txtCantidadPagar_KeyPress(sender As Object, e As KeyPressEventArgs)
        Using objval As New Validaciones
            e.Handled = objval.Money(sender, e)
        End Using
    End Sub

    Private Sub txtCantidadEntrego_KeyPress(sender As Object, e As KeyPressEventArgs)
        Using objval As New Validaciones
            e.Handled = objval.Money(sender, e)
        End Using
    End Sub

    Private Sub txtCodigoEmpleado_KeyPress(sender As Object, e As KeyPressEventArgs)
        Using objval As New Validaciones
            e.Handled = objval.JustNumbers(sender, e)
        End Using
    End Sub

    Private Sub Fillpago()
        Using objsql As New Generic_SQLServer
            _Dt_Pagos = objsql.GetPagoRestantePagos(_Id_AccountReceivable)
        End Using
        Try

            If _Dt_Pagos IsNot Nothing Then
                If _Dt_Pagos.Rows.Count <> 0 Then
                    RemoveHandler cbNCuota.SelectedIndexChanged, AddressOf cbNCuota_SelectedIndexChanged
                    cbNCuota.DataSource = _Dt_Pagos
                    cbNCuota.DisplayMember = "QuotaNumber"
                    cbNCuota.ValueMember = "ID_AccountsPayableDetails"
                    cbNCuota.SelectedIndex = -1
                    AddHandler cbNCuota.SelectedIndexChanged, AddressOf cbNCuota_SelectedIndexChanged
                    txtSaldo.Text = _Dt_Pagos.Rows(0).Item("payout")
                End If
                If IS_Calendar Then
                    cbNCuota.Text = ID_Cuota
                    cbNCuota.Enabled = False
                    rbCuota.Enabled = False
                    rbFiniquito.Enabled = False
                Else
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub FillcbEmpresa()
        Using objsql As New Generic_SQLServer
            _Dt_DatosCliente = objsql.SearchCobrosPagar(Data_Id_Company, Id_Customer, 2) ' Tipo de busqueda 2 para ID_Customer
        End Using


        If IS_Calendar Then
            If _Dt_DatosCliente.Rows.Count <> 0 Then
                For Each row As DataRow In _Dt_DatosCliente.Rows
                    If Not row Is Nothing Then
                        If row.Item("ID_AccountsPayableList") = ID_Cuenta Then
                            txtcliente.Text = row.Item("Name_Company")
                            txtCodigoCliente.Text = row.Item("ID_Customer_FK")
                            txtDocCredito.Text = row.Item("Description_Credit")
                            txtDocumento.Text = row.Item("DocumentNumber")
                            txtCreditoDescipcion.Text = row.Item("Description_Credit")
                            txtSaldo.Text = row.Item("SaldoDeudor")
                            _Id_AccountReceivable = row.Item("ID_AccountsPayableList")
                            Fillpago()

                        End If
                    End If
                Next
            Else
                MessageBox.Show("No existe plan de pagos activos", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Close()
            End If
        Else


            If Not _IsDue Then
                If _Dt_DatosCliente IsNot Nothing Then
                    If _Dt_DatosCliente.Rows.Count > 1 Then
                        Using objLista As New ERP_CuentasPorPagar_ListaLineasCreditos
                            objLista.DT_LineasCredito = _Dt_DatosCliente
                            objLista.ShowDialog()
                            _Id_row = objLista.RowSeleccion
                        End Using
                    End If
                End If
            Else
                _Id_row = -1
            End If
            If Not _Id_row = -1 Then
                If _Dt_DatosCliente.Rows.Count <> 0 Then
                    txtcliente.Text = _Dt_DatosCliente.Rows(_Id_row).Item("Name_Company")
                    txtCodigoCliente.Text = _Dt_DatosCliente.Rows(_Id_row).Item("ID_Customer_FK")
                    txtDocCredito.Text = _Dt_DatosCliente.Rows(_Id_row).Item("Description_Credit")
                    txtDocumento.Text = _Dt_DatosCliente.Rows(_Id_row).Item("DocumentNumber")
                    txtCreditoDescipcion.Text = _Dt_DatosCliente.Rows(_Id_row).Item("Description_Credit")
                    txtSaldo.Text = _Dt_DatosCliente.Rows(_Id_row).Item("SaldoDeudor")
                    _Id_AccountReceivable = _Dt_DatosCliente.Rows(_Id_row).Item("ID_AccountsPayableList")

                    Fillpago()
                Else
                    MessageBox.Show("No existe plan de pagos activos", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Close()
                End If
            ElseIf _Id_PayDue <> 0 Then
                If _Dt_DatosCliente.Rows.Count <> 0 Then
                    For Each row As DataRow In _Dt_DatosCliente.Rows
                        If Not row Is Nothing Then
                            If row.Item("ID_AccountsPayableList") = _Id_PayDue Then


                                txtcliente.Text = row.Item("Name_Company")
                                txtCodigoCliente.Text = row.Item("ID_Customer_FK")
                                txtDocCredito.Text = row.Item("Description_Credit")
                                txtDocumento.Text = row.Item("DocumentNumber")
                                txtCreditoDescipcion.Text = row.Item("Description_Credit")
                                txtSaldo.Text = row.Item("SaldoDeudor")
                                _Id_AccountReceivable = row.Item("ID_AccountsPayableList")
                                Fillpago()

                            End If
                        End If
                    Next



                Else
                    MessageBox.Show("No existe plan de pagos activos", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Close()
                End If
            Else
                Close()
            End If
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
        _Fecha_Pago = Today
        _NCheque = txtCheque.Text
        If rbEfectivo.Checked = True Then
            TipoPago = 1
        ElseIf rbCheque.Checked = True Then
            TipoPago = 3
        End If

        If Not cbEmpleado.SelectedIndex = -1 Then
            If Not txtCantidadPagar.Text = "" Then

                Using objsql As New Generic_SQLServer
                    If rbCuota.Checked = True Then 'Pago de Cuota
                        res = objsql.InsertAccountPayableQuota(Id_Empleado, _Id_AccountReceivable, cbNCuota.SelectedValue, Data_Id_Company, TipoPago, _Fecha_Pago, _NCheque)
                    Else
                        rbCuota.Checked = False 'Finiquitar Deuda
                        res = objsql.InsertAccountPayableFinalize(Id_Empleado, _Id_AccountReceivable, Data_Id_Company, TipoPago, _Fecha_Pago, _NCheque)
                    End If
                    If res = "ok" Then
                        MessageBox.Show("Pago realizado correctamente", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                        DialogResult = DialogResult.OK
                        clearCliente()
                        Close()
                    Else
                        MessageBox.Show("Algo salió mal", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            Else
                MessageBox.Show("Seleccione una cuota", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Seleccione el empleado que realiza el cobro", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    'Private Sub txtCantidadEntrego_TextChanged(sender As Object, e As EventArgs)
    '    If Not txtCantidadPagar.Text = "" Then
    '        If Not txtCantidadEntrego.Text = "" Then
    '            Dim pago As Double = Convert.ToDouble(txtCantidadEntrego.Text)
    '            Dim debe As Double = Convert.ToDouble(txtCantidadPagar.Text)
    '            If IsNumeric(pago) Then
    '                If pago >= debe Then
    '                    txtCantidadCambio.Text = pago - debe
    '                Else
    '                    txtCantidadCambio.Text = ("E")
    '                End If
    '            Else
    '                txtCantidadCambio.Text = ("E")
    '            End If
    '        End If
    '    Else
    '        txtCantidadEntrego.Clear()
    '    End If
    'End Sub

    Private Sub clearCliente()
        txtcliente.Clear()

        txtCantidadPagar.Clear()

        txtCodigoCliente.Clear()

        txtSaldo.Clear()

        txtDocumento.Clear()
        txtDocCredito.Clear()
        txtCreditoDescipcion.Clear()
        cbNCuota.DataSource = Nothing
        _Dt_DatosCliente = Nothing
        _Id_row = 0
        _Dt_Pagos = Nothing
        _Id_AccountReceivable = 0
    End Sub

    Private Sub cbNCuota_SelectedIndexChanged(sender As Object, e As EventArgs)
        Dim valCuota As Long = 0
        valCuota = cbNCuota.SelectedValue
        For Each row As DataRow In _Dt_Pagos.Rows
            If Not row Is Nothing Then
                If row.Item("ID_AccountsPayableDetails") = valCuota Then
                    txtCantidadPagar.Text = row.Item("Ammount")
                    lblFechaMaxPago.Text = row.Item("PaymentDate")
                    _Fecha_Pago = row.Item("PaymentDate")
                End If
            End If
        Next
        If txtCantidadPagar.Text <> "" Then
            txtCantidadPagar.Text = String.Format("{0:$#,###,###,###.##}", Convert.ToDouble(txtCantidadPagar.Text))
        End If
    End Sub

    Private Sub rbFiniquito_CheckedChanged_1(sender As Object, e As EventArgs) Handles rbFiniquito.CheckedChanged
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

    Private Sub rbCheque_CheckedChanged(sender As Object, e As EventArgs) Handles rbCheque.CheckedChanged
        If rbCheque.Checked = True Then
            txtCheque.Enabled = True
            txtCheque.Focus()
        ElseIf rbCheque.Checked = False Then
            txtCheque.Enabled = False
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