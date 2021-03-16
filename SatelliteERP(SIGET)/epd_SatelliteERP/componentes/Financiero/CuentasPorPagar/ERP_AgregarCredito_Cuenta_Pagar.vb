Public Class ERP_CPC_AgregarCobro

    Sub New(ByVal IdCustomer As Long)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        Id_Customer = IdCustomer
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
    Property Id_Customer As Long

    Private _DT_Cliente As New DataTable
    Private _DT_TypeDocument As New DataTable
    Private _DT_CreditLine As New DataTable


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
                    cbTypeDocument.SelectedIndex = -1
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
        Try
            Using objSql As New Financiero_SQLServer
                _DT_Cliente = objSql.GetListClient(Data_Id_Company)
            End Using
            If _DT_Cliente IsNot Nothing Then
                If _DT_Cliente.Rows.Count <> 0 Then
                    RemoveHandler cbCliente.SelectedIndexChanged, AddressOf cbCliente_SelectedIndexChanged
                    cbCliente.DataSource = _DT_Cliente
                    cbCliente.DisplayMember = "Name_Company"
                    cbCliente.ValueMember = "Id_Customer"
                    cbCliente.SelectedIndex = -1

                    cbCliente.SelectedValue = Id_Customer
                    cbCliente.Enabled = False
                    For Each row As DataRow In _DT_Cliente.Select("Id_Customer=" & Id_Customer)
                        txtCodigoCliente.Text = row.Item("Id_Customer")
                        txtDireccion.Text = row.Item("Address")
                        txtDocumentoCliente.Text = row.Item("Identity_DocumentNumber")
                        txtTelefono.Text = row.Item("OfficePhone")
                        txtTipoCliente.Text = row.Item("DescriptionCustomer")
                    Next row

                    REM  AddHandler cbCliente.SelectedIndexChanged, AddressOf cbCliente_SelectedIndexChanged

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

#End Region

    Private Sub rbEmpresa_CheckedChanged(sender As Object, e As EventArgs)
        clean()
    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        If Not dgvCobros.CurrentRow Is Nothing Then
            If Not cbCliente.SelectedIndex = -1 Then
                If Not cbTypeDocument.SelectedIndex = -1 Then
                    If Not txtDocumento.Text.Trim = "" Then
                        If Not txtSaldoDeudor.Text.Trim = "" Then
                            If Not txtDescripcionCredito.Text = "" Then
                                Dim ID_Customer As Long = cbCliente.SelectedValue
                                Dim ID_TypeDocument As Long = cbTypeDocument.SelectedValue
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
                                    resp = ObjSQL.AddAccountsPayable(_ID_Company, ID_Customer, ID_TypeDocument, NumDoc, SaldoDeudor, NumCuotas, FechaInicio, TipoPago, DescripcionCredito)
                                End Using
                                If resp <> 0 Then
                                    For Each Fila As DataGridViewRow In dgvCobros.Rows
                                        If Not Fila Is Nothing Then
                                            Using ObjSQL As New Financiero_SQLServer
                                                ObjSQL.AddDetailsAccountsPayable(resp, Fila.Cells("NoCuota").Value, Fila.Cells("Fecha de Pago").Value, Fila.Cells("Monto a Pagar").Value)
                                            End Using
                                        End If
                                    Next Fila
                                    MessageBox.Show("Registro insertado exitosamente", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
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
                        MessageBox.Show("Por favor ingrese el código ó correlativo del documento", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    End If
                Else
                    MessageBox.Show("Por favor seleccione un tipo de documento", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
                End If
            Else
                MessageBox.Show("Por favor seleccione un cliente autorizado ó ingrese uno nuevo", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
            End If
        End If
    End Sub

    Private Sub cmdGenerar_Click(sender As Object, e As EventArgs) Handles cmdGenerar.Click
        If txtSaldoDeudor.Text.Trim = "" Then
            MessageBox.Show("Por favor ingrese el saldo deudor, para poder realizar el cálculo", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
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

        dgvCobros.DataSource = DT
        dgvCobros.Columns(2).DefaultCellStyle.Format = "c"
        dgvCobros.Columns(1).DefaultCellStyle.Format = "dd/MM/yyyy"
        dgvCobros.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvCobros.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvCobros.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
    End Sub

    Private Sub cbCliente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCliente.SelectedIndexChanged
        If cbCliente.SelectedIndex <> -1 Then
            If _DT_Cliente.Rows.Count <> 0 Then
                Dim Id_cliente As Long = cbCliente.SelectedValue.ToString
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

    Private Sub txtConcepto_KeyPress(sender As Object, e As KeyPressEventArgs)
        Using objval As New Validaciones
            e.Handled = objval.JustLettersAndPunctuation(sender, e)
        End Using
    End Sub

    Private Sub txtSaldoDeudor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSaldoDeudor.KeyPress
        If Not Char.IsControl(e.KeyChar) Then
            Using objval As New Validaciones
                e.Handled = objval.Validar_Money(sender, e, txtSaldoDeudor)
            End Using
        End If
    End Sub


    Private Sub txtCuotas_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCuotas.KeyPress
        Using objval As New Validaciones
            e.Handled = objval.JustNumbers(sender, e)
        End Using
    End Sub

    Private Sub clean()
        txtDescripcionCredito.Text = ""
        txtCuotas.Text = ""
        txtCodigoCliente.Text = ""
        txtDireccion.Text = ""
        txtDocumentoCliente.Text = ""
        txtTelefono.Text = ""
        txtTipoCliente.Text = ""
        cbCliente.SelectedIndex = -1
        FillCbCliente()
        dgvCobros.DataSource = Nothing
        txtDocumento.Text = ""
        txtSaldoDeudor.Text = ""
        cbTypeDocument.SelectedIndex = -1
    End Sub

    Private Sub txtDescripcionCredito_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDescripcionCredito.KeyPress
        Using objval As New Validaciones
            e.Handled = objval.JustLettersAndPunctuation(sender, e)
        End Using
    End Sub


    Private Sub txtDocumento_keyPress(sender As Object, e As KeyPressEventArgs) Handles txtDocumento.KeyPress
        If Not IsNumeric(e.KeyChar) And e.KeyChar <> Convert.ToChar(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtCuotas_kreypress(sender As Object, e As KeyPressEventArgs) Handles txtCuotas.KeyPress
        If Not IsNumeric(e.KeyChar) And e.KeyChar <> Convert.ToChar(Keys.Back) Then
            e.Handled = True
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