Public Class ERP_CuentasPorCobrar_Crea

    Property NombreCliente As String = ""
    Private _DT_TypeDocument As New DataTable
    Property DT_CreditLine As New DataTable
    Private objValidaciones As New Validaciones
    Sub New(ByVal IdCustomer As Long)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        Id_Customer = IdCustomer
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
    Property Id_Customer As Long
    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub

    Private Sub ERP_CPC_AgregarCobro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillCbCliente()
        FillCbTypeDocument()
    End Sub

#Region "FillCB"

    Private Sub FillCbTypeDocument()
        txtCliente.Text = NombreCliente
        cbCreditLine.DataSource = DT_CreditLine
        cbCreditLine.ValueMember = "Id_LineaDeCredito"  ' verificar
        cbCreditLine.DisplayMember = "TypeCreditLine"

        For Each row As DataRow In DT_CreditLine.Rows
            txtSaldoDeudor.Text = CType(row("valor"), Decimal).ToString("###,###,##0.00")
            Try
                txtCreditoDisponible.Text = CType(row("Saldo"), Decimal).ToString("###,###,##0.00")

            Catch ex As Exception
                txtCreditoDisponible.Text = 0.00
            End Try
            txtDescripcionCredito.Text = row("Concepto")
            Exit For
        Next
        'Using ObjSQL As New Generic_SQLServer
        '    _DT_TypeDocument = ObjSQL.GetTypeDocument
        'End Using
        'If Not _DT_TypeDocument Is Nothing Then
        '    If _DT_TypeDocument.Rows.Count <> 0 Then
        '        Try
        '            cbTypeDocument.DataSource = _DT_TypeDocument
        '            cbTypeDocument.ValueMember = "ID_CreditDocument"
        '            cbTypeDocument.DisplayMember = "Description"

        '        Catch ex As ArgumentException
        '            Using objLog As New ProcessGeneral
        '                objLog.AlmacenarLog(5, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
        '            End Using
        '        Catch ex As Exception
        '            Using objLog As New ProcessGeneral
        '                objLog.AlmacenarLog(5, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
        '            End Using
        '        End Try
        '    End If
        'End If
    End Sub
    Private Sub FillCbCliente()
    End Sub
    Private Sub fillCbCreditLine(ByVal ID_Customer As Long)
        'Using ObjSQL As New Generic_SQLServer
        '    _DT_CreditLine = ObjSQL.GetCreditLineByCustomer(ID_Customer)
        'End Using
        'If Not _DT_CreditLine Is Nothing Then
        '    Try
        '        RemoveHandler cbCreditLine.SelectedIndexChanged, AddressOf cbCreditLine_SelectedIndexChanged
        '        cbCreditLine.DataSource = _DT_CreditLine
        '        cbCreditLine.ValueMember = "Id_LineaDeCredito"  ' verificar
        '        cbCreditLine.DisplayMember = "TypeCreditLine"
        '        cbCreditLine.SelectedIndex = -1
        '        AddHandler cbCreditLine.SelectedIndexChanged, AddressOf cbCreditLine_SelectedIndexChanged
        '    Catch ex As ArgumentException
        '        Using objLog As New ProcessGeneral
        '            objLog.AlmacenarLog(5, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
        '        End Using
        '    Catch ex As Exception
        '        Using objLog As New ProcessGeneral
        '            objLog.AlmacenarLog(5, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
        '        End Using
        '    End Try
        'End If
    End Sub
#End Region
    Private Sub cmdNuevo_Click(sender As Object, e As EventArgs)
        Using objclient As New ERP_GenericCustomerClients
            objclient.TipoConsulta = ERP_GenericCustomerClients.OpcionSeleccionada.Clientes
            objclient.ShowDialog()
        End Using
    End Sub
    Private Sub rbEmpresa_CheckedChanged(sender As Object, e As EventArgs)
        clean()
    End Sub
    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        Dim valorPagar As Decimal = 0
        Try
            valorPagar = txtValorAutilizar.Text
        Catch ex As Exception

        End Try
        If Not valorPagar > 0 Then
            MessageBox.Show("El crédito a utilizar tiene que ser mayor a cero ", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If
        Dim Cuotas As Long = 0
        Try
            Cuotas = txtCuotas.Text
        Catch ex As Exception
        End Try
        If Not Cuotas > 0 Then
            MessageBox.Show("La cuota a utilizar tiene que ser mayor a cero ", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If
        If Not rbQuincenal.Checked And Not rbDiario.Checked And Not rbMensual.Checked And Not rbSemanal.Checked Then
            MessageBox.Show("Tiene que seleccionar frecuencia de pago", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If
        If dgvCobros.RowCount = 0 Then
            MessageBox.Show("No tiene generado ningún cobro", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If
        If Not txtDescripcion.Text.Length > 10 Then
            MessageBox.Show("Tiene que poner una descripción mayor a 10 caracteres", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If
        Dim resp As Integer
        Using ObjSQL As New Generic_SQLServer
			Dim ID_TypeDocument As Integer = 1 'QUITAR y color el tipo de documento
            Dim SaldoDeudor As Decimal = txtValorAutilizar.Text
            Dim ID_CreditLine As Long = DT_CreditLine.Rows(0)("Id_LineaDeCredito")
            Dim FechaInicio As Date = dtpDateInit.Value.ToString("dd/MM/yyyy")
            resp = ObjSQL.AddAccountsReceivable(_ID_Company, Id_Customer, ID_TypeDocument, ID_CreditLine, 1, SaldoDeudor, txtCuotas.Text, FechaInicio, "0", txtDescripcion.Text)
        End Using
        If resp <> 0 Then
            For Each Fila As DataGridViewRow In dgvCobros.Rows
                If Not Fila Is Nothing Then
                    Using ObjSQL As New Generic_SQLServer
                        ObjSQL.AddDetailsAccountsReceivable(resp, Fila.Cells("NoCuota").Value, Fila.Cells("FechaPago").Value, Fila.Cells("MontoCuota").Value)
                    End Using
                End If
            Next Fila
            MessageBox.Show("Registro insertado exitosamente", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            DialogResult = System.Windows.Forms.DialogResult.OK
            clean()
        End If

        'If Not dgvCobros.CurrentRow Is Nothing Then
        '    If Not cbCliente.SelectedIndex = -1 Then
        '        If Not cbTypeDocument.SelectedIndex = -1 Then
        '            If Not txtDocumento.Text.Trim = "" Then
        '                If Not txtConcepto.Text.Trim = "" Then
        '                    If Not txtSaldoDeudor.Text.Trim = "" Then
        '                        If Not txtDescripcionCredito.Text = "" Then
        '                            Dim ID_Customer As Long = cbCliente.SelectedValue
        '                            Dim ID_TypeDocument As Long = cbTypeDocument.SelectedValue
        '                            Dim ID_CreditLine As Long = cbCreditLine.SelectedValue
        '                            Dim NumDoc As Integer = txtDocumento.Text.Trim
        '                            Dim SaldoDeudor As Double = txtSaldoDeudor.Text.Trim
        '                            Dim NumCuotas As Integer = txtCuotas.Text.Trim
        '                            Dim FechaInicio As Date = dtpDateInit.Value.ToString("dd/MM/yyyy")
        '                            Dim TipoPago As Integer = 0
        '                            Dim DescripcionCredito As String = txtDescripcionCredito.Text.Trim
        '                            If rbMensual.Checked = True Then
        '                                TipoPago = 1
        '                            ElseIf rbQuincenal.Checked = True Then
        '                                TipoPago = 2
        '                            ElseIf rbSemanal.Checked = True Then
        '                                TipoPago = 3
        '                            ElseIf rbDiario.Checked = True Then
        '                                TipoPago = 4
        '                            End If
        '                           
        '                        Else
        '                            MessageBox.Show("Por favor inserte una descripción al crédito", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
        '                        End If
        '                    Else
        '                        MessageBox.Show("Por favor inserte un saldo deudor", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
        '                    End If
        '                Else
        '                    MessageBox.Show("Por favor ingrese un concepto para el crédito", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
        '                End If
        '            Else
        '                MessageBox.Show("Por favor ingrese el codigo ó correlativo del documento", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
        '            End If
        '        Else
        '            MessageBox.Show("Por favor seleccione un tipo de documento", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
        '        End If
        '    Else
        '        MessageBox.Show("Por favor seleccione un cliente autorizado  ó ingrese uno nuevo", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
        '    End If
        'End If
    End Sub

    Private Sub cmdGenerar_Click(sender As Object, e As EventArgs) Handles cmdGenerar.Click
        If txtValorAutilizar.Text.Trim = "" Then
            MessageBox.Show("Por favor ingrese el saldo deudor, para poder realizar el cálculo", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
            txtValorAutilizar.Select()
            Exit Sub
        End If
        If Not IsNumeric(txtValorAutilizar.Text.Trim) Then
            MessageBox.Show("Por favor ingrese un saldo deudor válido, para poder realizar el cálculo", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
            txtValorAutilizar.Select()
            Exit Sub
        End If
        Dim Saldo As Double = txtValorAutilizar.Text.Trim
        If Saldo <= 0 Then
            MessageBox.Show("Por favor ingrese un saldo deudor mayor que 0, para poder realizar el cálculo", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
            txtValorAutilizar.Select()
            Exit Sub
        End If
        If txtCuotas.Text.Trim = "" Then
            MessageBox.Show("Por favor ingrese el número de cuotas, para poder realizar el cálculo", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
            txtCuotas.Select()
            Exit Sub
        End If

        If Not IsNumeric(txtCuotas.Text.Trim) Then
            MessageBox.Show("Por favor ingrese el número de cuotas, para poder realizar el cálculo", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
            txtCuotas.Select()
            Exit Sub
        End If
        Dim Cuotas As Integer = txtCuotas.Text.Trim
        If Saldo <= 0 Then
            MessageBox.Show("Por favor ingrese el número de cuotas, para poder realizar el cálculo", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
            txtCuotas.Select()
            Exit Sub
        End If
        If dtpDateInit.Value <= Now Then
            MessageBox.Show("La fecha de inicio de pago tiene que ser mayor a la actual", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If
        If txtCreditoDisponible.Text.Trim = "" Then
            MessageBox.Show("No se puede calcular", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If
        Dim Credito As Double = txtCreditoDisponible.Text.Trim
        If Credito < Saldo Then
            MessageBox.Show("No se puede ejecutar el cálculo, verifique el crédito disponible", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If
        Dim entro As Boolean = False
        Dim DT As New DataTable
        DT.Columns.Add("NoCuota", Type.GetType("System.Int32"))
        DT.Columns.Add("Fecha de Pago", Type.GetType("System.DateTime"))
        DT.Columns.Add("Monto a Pagar", Type.GetType("System.Decimal"))
        Dim Fecha = dtpDateInit.Value
        For a As Integer = 0 To 10
            If Fecha.DayOfWeek = DayOfWeek.Saturday Or Fecha.DayOfWeek = DayOfWeek.Sunday Then
                Fecha = DateAdd("d", 1, Fecha)
            Else
                Exit For
            End If
        Next
        Dim CantidadCuotasMes As Integer = Cuotas
        For i = 0 To CantidadCuotasMes - 1
            If Not entro = False Then
                If rbMensual.Checked = True Then
                    Fecha = DateAdd("m", 1, Fecha)
                    For a As Integer = 0 To 10
                        If Fecha.DayOfWeek = DayOfWeek.Saturday Or Fecha.DayOfWeek = DayOfWeek.Sunday Then
                            Fecha = DateAdd("d", 1, Fecha)
                        Else
                            Exit For
                        End If
                    Next
                ElseIf rbQuincenal.Checked = True Then
                    Fecha = DateAdd("d", 15, Fecha)
                    For a As Integer = 0 To 10
                        If Fecha.DayOfWeek = DayOfWeek.Saturday Or Fecha.DayOfWeek = DayOfWeek.Sunday Then
                            Fecha = DateAdd("d", 1, Fecha)
                        Else
                            Exit For
                        End If
                    Next
                ElseIf rbSemanal.Checked = True Then
                    Fecha = DateAdd("d", 7, Fecha)
                    For a As Integer = 0 To 10
                        If Fecha.DayOfWeek = DayOfWeek.Saturday Or Fecha.DayOfWeek = DayOfWeek.Sunday Then
                            Fecha = DateAdd("d", 1, Fecha)
                        Else
                            Exit For
                        End If
                    Next
                ElseIf rbDiario.Checked = True Then
                    Fecha = DateAdd("d", 1, Fecha)
                    For a As Integer = 0 To 10
                        If Fecha.DayOfWeek = DayOfWeek.Saturday Or Fecha.DayOfWeek = DayOfWeek.Sunday Then
                            Fecha = DateAdd("d", 1, Fecha)
                        Else
                            Exit For
                        End If
                    Next
                End If
            Else
                entro = True
            End If

            DT.Rows.Add(i + 1, Fecha, Saldo / CantidadCuotasMes)
        Next i
        dgvCobros.Columns("MontoCuota").DefaultCellStyle.Format = "C2"
        dgvCobros.Columns("FechaPago").DefaultCellStyle.Format = "dd/MM/yyyy"
        dgvCobros.MultiSelect = False
        dgvCobros.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvCobros.DataSource = DT
    End Sub



    'Private Sub cbCreditLine_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCreditLine.SelectedIndexChanged
    '    If Not cbCreditLine.SelectedIndex = -1 Then
    '        Dim Id_Line As Long = cbCreditLine.SelectedValue
    '        For Each row As DataRow In _DT_CreditLine.Rows
    '            If row IsNot Nothing Then
    '                If row.Item("Id_LineaDeCredito") = Id_Line Then
    '                    txtConcepto.Text = row.Item("Concepto")
    '                    txtCreditoDisponible.Text = row.Item("Valor")
    '                End If
    '            End If
    '        Next row
    '    End If
    'End Sub

    Private Sub txtConcepto_KeyPress(sender As Object, e As KeyPressEventArgs)
        Using objval As New Validaciones
            e.Handled = objval.JustLettersAndPunctuation(sender, e)
        End Using
    End Sub

    Private Sub txtSaldoDeudor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSaldoDeudor.KeyPress
        Using objval As New Validaciones
            e.Handled = objval.Validar_Money(sender, e, txtSaldoDeudor)
        End Using
    End Sub

    Private Sub txtDocumento_KeyPress(sender As Object, e As KeyPressEventArgs)
        Using objval As New Validaciones
            e.Handled = objval.JustNumbers(sender, e)
        End Using
    End Sub

    Private Sub txtCuotas_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCuotas.KeyPress
        If Not IsNumeric(e.KeyChar) And e.KeyChar <> Convert.ToChar(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub clean()
        'txtDescripcionCredito.Text = ""
        'txtCreditoDisponible.Text = ""
        'txtConcepto.Text = ""
        'txtCuotas.Text = ""
        'txtCodigoCliente.Text = ""
        'txtDireccion.Text = ""
        'txtDocumentoCliente.Text = ""
        'txtTelefono.Text = ""
        'txtTipoCliente.Text = ""
        'cbCliente.SelectedIndex = -1
        'cbCreditLine.DataSource = Nothing
        'FillCbCliente()
        'dgvCobros.DataSource = Nothing
    End Sub

    Private Sub txtDescripcionCredito_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDescripcionCredito.KeyPress
        Using objval As New Validaciones
            e.Handled = objval.JustLettersAndPunctuation(sender, e)
        End Using
    End Sub

    Private Sub txtValorAutilizar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtValorAutilizar.KeyPress
        e.Handled = objValidaciones.Validar_Money(sender, e, txtValorAutilizar)
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    'Private Sub txtSaldoDeudor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSaldoDeudor.KeyPress
    '    e.Handled = objValidaciones.Validar_Money(sender, e, txtSaldoDeudor)
    'End Sub


    Private Sub txtCreditoDisponible_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCreditoDisponible.KeyPress
        e.Handled = objValidaciones.Validar_Money(sender, e, txtCreditoDisponible)
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