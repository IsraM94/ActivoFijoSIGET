Public Class ERP_CuentasPorCobrar_AgregarCxC

    Private _DT_Cliente As New DataTable
    Private _DT_TypeDocument As New DataTable
    Private _DT_CreditLine As New DataTable
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
        Using ObjSQL As New Generic_SQLServer
            _DT_TypeDocument = ObjSQL.GetTypeDocument
        End Using
        If Not _DT_TypeDocument Is Nothing Then
            If _DT_TypeDocument.Rows.Count <> 0 Then
                Try
                    cbTypeDocument.DataSource = _DT_TypeDocument
                    cbTypeDocument.ValueMember = "ID_CreditDocument"
                    cbTypeDocument.DisplayMember = "Description"

                Catch ex As ArgumentException
                    Using objLog As New ProcessGeneral
                        objLog.AlmacenarLog(5, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                    End Using
                Catch ex As Exception
                    Using objLog As New ProcessGeneral
                        objLog.AlmacenarLog(5, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                    End Using
                End Try
            End If
        End If
    End Sub

    Private Sub FillCbCliente()
        Dim LegalEntity As Boolean = False
        If rbEmpresa.Checked = True Then
            LegalEntity = True
        ElseIf rbPersonaNatural.Checked = True Then
            LegalEntity = False
        End If
        Try
            Using objSql As New Generic_SQLServer
                _DT_Cliente = objSql.GetListClient(Data_Id_Company, LegalEntity)
            End Using
            If _DT_Cliente IsNot Nothing Then
                If _DT_Cliente.Rows.Count <> 0 Then
                    RemoveHandler cbCliente.SelectedIndexChanged, AddressOf cbCliente_SelectedIndexChanged
                    cbCliente.DataSource = _DT_Cliente
                    cbCliente.DisplayMember = "Name_Company"
                    cbCliente.ValueMember = "Id_Customer"
                    cbCliente.SelectedIndex = -1

                    cbCliente.SelectedValue = Id_Customer
                    Dim Entro As Boolean = False
                    cbCliente.Enabled = False
                    For Each row As DataRow In _DT_Cliente.Select("Id_Customer=" & Id_Customer)
                        txtCodigoCliente.Text = row.Item("Id_Customer")
                        txtDireccion.Text = row.Item("Address")
                        txtDocumentoCliente.Text = row.Item("Identity_DocumentNumber")
                        txtTelefono.Text = row.Item("OfficePhone")
                        txtTipoCliente.Text = row.Item("DescriptionCustomer")
                        Entro = True
                    Next row
                    If Not Entro Then
                        MessageBox.Show("Cliente no posee linea de credito", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                        Close()
                    End If
                    fillCbCreditLine(Id_Customer)
                    REM AddHandler cbCliente.SelectedIndexChanged, AddressOf cbCliente_SelectedIndexChanged

                End If
            End If
        Catch ex As ArgumentException
            Using objLog As New ProcessGeneral
                objLog.AlmacenarLog(5, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
            End Using
        Catch ex As Exception
            Using objLog As New ProcessGeneral
                objLog.AlmacenarLog(5, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
            End Using
        End Try
    End Sub


    Private Sub fillCbCreditLine(ByVal ID_Customer As Long)
        Using ObjSQL As New Generic_SQLServer
            _DT_CreditLine = ObjSQL.GetCreditLineByCustomer(ID_Customer)
        End Using
        If Not _DT_CreditLine Is Nothing Then
            Try
                RemoveHandler cbCreditLine.SelectedIndexChanged, AddressOf cbCreditLine_SelectedIndexChanged
                cbCreditLine.DataSource = _DT_CreditLine
                cbCreditLine.ValueMember = "Id_LineaDeCredito"  ' verificar
                cbCreditLine.DisplayMember = "TypeCreditLine"
                cbCreditLine.SelectedIndex = -1
                AddHandler cbCreditLine.SelectedIndexChanged, AddressOf cbCreditLine_SelectedIndexChanged
            Catch ex As ArgumentException
                Using objLog As New ProcessGeneral
                    objLog.AlmacenarLog(5, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                End Using
            Catch ex As Exception
                Using objLog As New ProcessGeneral
                    objLog.AlmacenarLog(5, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                End Using
            End Try
        End If
    End Sub

#End Region

    Private Sub cmdNuevo_Click(sender As Object, e As EventArgs) Handles cmdNuevo.Click
        Using objclient As New ERP_GenericCustomerClients
            objclient.TipoConsulta = ERP_GenericCustomerClients.OpcionSeleccionada.Clientes
            objclient.ShowDialog()
        End Using
    End Sub

    Private Sub rbEmpresa_CheckedChanged(sender As Object, e As EventArgs) Handles rbEmpresa.CheckedChanged
        clean()
    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        If Not dgvCobros.CurrentRow Is Nothing Then
            If Not cbCliente.SelectedIndex = -1 Then
                If Not cbTypeDocument.SelectedIndex = -1 Then
                    If Not txtDocumento.Text.Trim = "" Then
                        If Not txtConcepto.Text.Trim = "" Then
                            If Not txtSaldoDeudor.Text.Trim = "" Then
                                If Not txtDescripcionCredito.Text = "" Then
                                    Dim ID_Customer As Long = cbCliente.SelectedValue
                                    Dim ID_TypeDocument As Long = cbTypeDocument.SelectedValue
                                    Dim ID_CreditLine As Long = cbCreditLine.SelectedValue
                                    Dim NumDoc As Integer = txtDocumento.Text.Trim
                                    Dim SaldoDeudor As Double = txtSaldoDeudor.Text.Trim
                                    Dim NumCuotas As Integer = txtCuotas.Text.Trim
                                    Dim FechaInicio As Date = dtpDateInit.Value.ToString("dd/MM/yyyy")
                                    Dim TipoPago As Integer = 0
                                    Dim DescripcionCredito As String = txtDescripcionCredito.Text.Trim
                                    If rbMensual.Checked = True Then
                                        TipoPago = 1
                                    ElseIf rbQuincenal.Checked = True Then
                                        TipoPago = 2
                                    ElseIf rbSemanal.Checked = True Then
                                        TipoPago = 3
                                    ElseIf rbDiario.Checked = True Then
                                        TipoPago = 4
                                    End If
                                    Dim resp As Integer
                                    Using ObjSQL As New Generic_SQLServer
                                        resp = ObjSQL.AddAccountsReceivable(_ID_Company, ID_Customer, ID_TypeDocument, ID_CreditLine, NumDoc, SaldoDeudor, NumCuotas, FechaInicio, TipoPago, DescripcionCredito)
                                    End Using
                                    If resp <> 0 Then
                                        For Each Fila As DataGridViewRow In dgvCobros.Rows
                                            If Not Fila Is Nothing Then
                                                Using ObjSQL As New Generic_SQLServer
                                                    ObjSQL.AddDetailsAccountsReceivable(resp, Fila.Cells("NoCuota").Value, Fila.Cells("Fecha de Pago").Value, Fila.Cells("Monto a Pagar").Value)
                                                End Using
                                            End If
                                        Next Fila
                                        MessageBox.Show("Registro insertado Exitósamente", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                                        DialogResult = System.Windows.Forms.DialogResult.OK
                                        clean()
                                    End If
                                Else
                                    MessageBox.Show("Por favor inserte una descripción al crédito", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
                                End If
                            Else
                                MessageBox.Show("Por favor inserte un saldo deudor", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
                            End If
                        Else
                            MessageBox.Show("Por favor ingrese un concepto para el crédito", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
                        End If
                    Else
                        MessageBox.Show("Por favor ingrese el código ó correlativo del documento", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    End If
                Else
                    MessageBox.Show("Por favor seleccione un tipo de documento", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
                End If
            Else
                MessageBox.Show("Por favor seleccione un cliente autorizado  ó ingrese uno nuevo", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
            End If
        End If
    End Sub

    Private Sub cmdGenerar_Click(sender As Object, e As EventArgs) Handles cmdGenerar.Click
        If txtSaldoDeudor.Text.Trim = "" Then
            MessageBox.Show("Por favor ingrese el Saldo deudor, para poder realizar el cálculo", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
            txtSaldoDeudor.Select()
            Exit Sub
        End If
        If Not IsNumeric(txtSaldoDeudor.Text.Trim) Then
            MessageBox.Show("Por favor ingrese un saldo deudor válido, para poder realizar el cálculo", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
            txtSaldoDeudor.Select()
            Exit Sub
        End If
        Dim Saldo As Double = txtSaldoDeudor.Text.Trim
        If Saldo <= 0 Then
            MessageBox.Show("Por favor ingrese un saldo deudor mayor que 0, para poder realizar el cálculo", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
            txtSaldoDeudor.Select()
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
			If Fecha.DayOfWeek = DayOfWeek.Sunday Then
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
						If Fecha.DayOfWeek = DayOfWeek.Sunday Then
							Fecha = DateAdd("d", 1, Fecha)
						Else
							Exit For
                        End If
                    Next
                ElseIf rbQuincenal.Checked = True Then
                    Fecha = DateAdd("d", 15, Fecha)
                    For a As Integer = 0 To 10
						If Fecha.DayOfWeek = DayOfWeek.Sunday Then
							Fecha = DateAdd("d", 1, Fecha)
						Else
							Exit For
                        End If
                    Next
                ElseIf rbSemanal.Checked = True Then
                    Fecha = DateAdd("d", 7, Fecha)
                    For a As Integer = 0 To 10
						If Fecha.DayOfWeek = DayOfWeek.Sunday Then
							Fecha = DateAdd("d", 1, Fecha)
						Else
							Exit For
                        End If
                    Next
                ElseIf rbDiario.Checked = True Then
                    Fecha = DateAdd("d", 1, Fecha)
                    For a As Integer = 0 To 10
						If Fecha.DayOfWeek = DayOfWeek.Sunday Then
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
        dgvCobros.DataSource = DT
    End Sub

    Private Sub cbCliente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCliente.SelectedIndexChanged
        If cbCliente.SelectedIndex <> -1 Then
            If _DT_Cliente.Rows.Count <> 0 Then
                Dim Id_cliente As Long = cbCliente.SelectedValue.ToString
                fillCbCreditLine(Id_cliente)
                For Each row As DataRow In _DT_Cliente.Rows
                    If row IsNot Nothing Then
                        If row.Item("Id_Customer") = Id_cliente Then
                            txtCodigoCliente.Text = row.Item("Id_Customer")
                            txtDireccion.Text = row.Item("Address")
                            txtDocumentoCliente.Text = row.Item("Identity_DocumentNumber")
                            txtTelefono.Text = row.Item("OfficePhone")
                            txtTipoCliente.Text = row.Item("DescriptionCustomer")
                        End If
                    End If
                Next row
            End If
        End If
    End Sub

    Private Sub cbCreditLine_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCreditLine.SelectedIndexChanged
        If Not cbCreditLine.SelectedIndex = -1 Then
            Dim Id_Line As Long = cbCreditLine.SelectedValue
            For Each row As DataRow In _DT_CreditLine.Rows
                If row IsNot Nothing Then
                    If row.Item("Id_LineaDeCredito") = Id_Line Then
                        txtConcepto.Text = row.Item("Concepto")
                        txtCreditoDisponible.Text = row.Item("Valor")
                    End If
                End If
            Next row
        End If
    End Sub

    Private Sub txtConcepto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtConcepto.KeyPress
        Using objval As New Validaciones
            e.Handled = objval.JustLettersAndPunctuation(sender, e)
        End Using
    End Sub

    Private Sub txtSaldoDeudor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSaldoDeudor.KeyPress
        Using objval As New Validaciones
            e.Handled = objval.Money(sender, e)
        End Using
    End Sub

    Private Sub txtDocumento_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDocumento.KeyPress
        Using objval As New Validaciones
            e.Handled = objval.JustNumbers(sender, e)
        End Using
    End Sub

    Private Sub txtCuotas_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCuotas.KeyPress
        Using objval As New Validaciones
            e.Handled = objval.JustNumbers(sender, e)
        End Using
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