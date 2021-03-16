Public Class ERP_AgregarPago_Cuenta_Pagar

    Private _Dt_DatosCliente As New DataTable
    Private _Id_row As Long = 0
    Private _Dt_Pagos As New DataTable
    Private _Id_AccountPayable As Long

    Property Id_Customer As Long = 0

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub

    Private Sub ERP_CobrosCuentaporCobrar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillcbEmpleado()
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

    Private Sub cmdBuscar_Click(sender As Object, e As EventArgs) Handles cmdBuscar.Click
        'Using objBuscar As New ERP_BuscarPago
        '    If objBuscar.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
        '        _Dt_DatosCliente = objBuscar.DT_Credit
        '        _Id_row = objBuscar.row
        '    End If
        'End Using
        'If _Dt_DatosCliente IsNot Nothing Then
        '    If _Dt_DatosCliente.Rows.Count <> 0 Then
        '        txtcliente.Text = _Dt_DatosCliente.Rows(_Id_row).Item("Name_Company")
        '        txtCodigoCliente.Text = _Dt_DatosCliente.Rows(_Id_row).Item("ID_Customer_FK")
        '        txtDocCredito.Text = _Dt_DatosCliente.Rows(_Id_row).Item("Doc_Credito")
        '        txtDocumento.Text = _Dt_DatosCliente.Rows(_Id_row).Item("DocumentNumber")
        '        txtCreditoDescipcion.Text = _Dt_DatosCliente.Rows(_Id_row).Item("Description_Credit")
        '        _Id_AccountPayable = _Dt_DatosCliente.Rows(_Id_row).Item("ID_AccountsPayableList")
        '        Fillpago()
        '    End If
        'End If
    End Sub

    Private Sub rbFiniquito_CheckedChanged(sender As Object, e As EventArgs) Handles rbFiniquito.CheckedChanged
        If rbFiniquito.Checked = True Then
            cbNCuotaPagar.Enabled = False
            lblEnunciadoFecha.Visible = False
            lblFechaMaxPago.Visible = False
            txtCantidadPagar.Text = txtSaldo.Text
            cbNCuotaPagar.SelectedIndex = -1
        ElseIf rbFiniquito.Checked = False Then
            cbNCuotaPagar.Enabled = True
            lblEnunciadoFecha.Visible = True
            lblFechaMaxPago.Visible = True
            txtCantidadPagar.Text = ""
        End If
    End Sub

    Private Sub rbEfectivo_CheckedChanged(sender As Object, e As EventArgs) Handles rbEfectivo.CheckedChanged
        If rbCheque.Checked = False Then
            txtCheque.Enabled = False
        ElseIf rbCheque.Checked = True Then
            txtCheque.Enabled = True
        End If
    End Sub

    Private Sub txtCantidadPagar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCantidadPagar.KeyPress
        Using objval As New Validaciones
            e.Handled = objval.Money(sender, e)
        End Using
    End Sub

    Private Sub Fillpago()
        Using objsql As New Financiero_SQLServer
            _Dt_Pagos = objsql.GetRestanteAccountsPayable(_Id_AccountPayable)
        End Using
        Try
            If _Dt_Pagos IsNot Nothing Then
                If _Dt_Pagos.Rows.Count <> 0 Then
                    RemoveHandler cbNCuotaPagar.SelectedIndexChanged, AddressOf cbNCuota_SelectedIndexChanged
                    cbNCuotaPagar.DataSource = _Dt_Pagos
                    cbNCuotaPagar.DisplayMember = "QuotaNumber"
                    cbNCuotaPagar.ValueMember = "ID_AccountsPayableDetails"
                    cbNCuotaPagar.SelectedIndex = -1
                    AddHandler cbNCuotaPagar.SelectedIndexChanged, AddressOf cbNCuota_SelectedIndexChanged
                    txtSaldo.Text = _Dt_Pagos.Rows(0).Item("payout")
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cbNCuota_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbNCuotaPagar.SelectedIndexChanged
        Dim valCuota As Long = 0
        valCuota = cbNCuotaPagar.SelectedValue
        For Each row As DataRow In _Dt_Pagos.Rows
            If Not row Is Nothing Then
                If row.Item("ID_AccountsPayableDetails") = valCuota Then
                    txtCantidadPagar.Text = row.Item("Ammount")
                    lblFechaMaxPago.Text = row.Item("PaymentDate")
                End If
            End If
        Next
    End Sub

    Private Sub cmdGrabar_Click(sender As Object, e As EventArgs) Handles cmdGrabar.Click
        Dim res As String = ""
        Dim TipoPago As Long = 0
        If rbEfectivo.Checked = True Then
            TipoPago = 1
        ElseIf rbCheque.Checked = True Then
            TipoPago = 3
            If txtCheque.Text.Trim = "" Then
                MessageBox.Show("Ingrese un número de Cheque", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        End If
        Dim Id_Empleado As Long = cbEmpleado.SelectedValue
        Dim Fecha_pago As String = dtpDatePay.Text
        Dim N_Cheque As String = txtCheque.Text.Trim
        If Not cbEmpleado.SelectedIndex = -1 Then
            If Not txtCantidadPagar.Text = "" Then
                Using objsql As New Financiero_SQLServer
                    If rbCuota.Checked = True Then 'Pago de Cuota
                        res = objsql.InsertAccountPayableQuota(_Id_AccountPayable, cbNCuotaPagar.SelectedValue, Data_Id_Company, TipoPago, Fecha_pago, N_Cheque, Id_Empleado)
                    Else
                        rbCuota.Checked = False 'Finiquitar Deuda
                        res = objsql.InsertAccountPayableFinalize(_Id_AccountPayable, Data_Id_Company, TipoPago, Fecha_pago, N_Cheque, Id_Empleado)
                    End If
                    If res = "ok" Then
                        MessageBox.Show("Pago se registró correctamente", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                        clearCliente()
                    Else
                        MessageBox.Show("Algo salió mal", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            Else
                MessageBox.Show("Seleccione una cuota", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Seleccione el empleado que realizó el pago", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub clearCliente()
        txtcliente.Clear()
        txtCantidadPagar.Clear()
        txtCodigoCliente.Clear()
        txtSaldo.Clear()
        txtDocumento.Clear()
        txtDocCredito.Clear()
        txtCreditoDescipcion.Clear()
        cbNCuotaPagar.DataSource = Nothing
        _Dt_DatosCliente = Nothing
        _Id_row = 0
        _Dt_Pagos = Nothing
        _Id_AccountPayable = 0
        lblFechaMaxPago.Text = "none"
        txtCheque.Clear()
    End Sub

    Private Sub txtCheque_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCheque.KeyPress
        Using objValidaciones As New Validaciones
            e.Handled = objValidaciones.JustNumbers(sender, e)
        End Using
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