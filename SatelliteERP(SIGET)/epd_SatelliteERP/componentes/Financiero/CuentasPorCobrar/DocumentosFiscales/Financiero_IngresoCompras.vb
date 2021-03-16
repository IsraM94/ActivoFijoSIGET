Imports System.IO

Public Class Financiero_IngresoCompras
    Property objCustomerRow As DataRow
    Property objDetalleFacturaRow As DataTable

    Private _TipoFactura As String = "CREDITO FISCAL"
    Private _Direccion As String = ""
    Private _Giro As String = ""
    Private _Departamento As String = ""
    Property Is_Modificacion As Boolean = False
    Private objGeneric As New Generic_SQLServer
    Property Is_Cotizacion As Boolean = False
    Property No_Cotizacion As Long
    Sub New(ByVal TipoFactura As String)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        _TipoFactura = TipoFactura

    End Sub
    Private Sub Financiero_DocumentoFiscal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CB_PeriodoFacturacion.Items.Clear()
        For i As Integer = 30 To 0 Step -1
            CB_PeriodoFacturacion.Items.Add(Now.AddMonths(i * -1).ToString("yyyy-MM"))
        Next
        If Not _TipoFactura = "CREDITO FISCAL" Then
            GroupBox1.Text = "Compra - Factura Consumidor Final"

        End If

        txtRazonSocial.Text = objCustomerRow.Item("Name_Company")
        txtNIT.Text = objCustomerRow.Item("Tax_Identification_Number")

        txtNRC.Text = objCustomerRow.Item("Tax_Registration_Number")

        txtID_Customer.Text = objCustomerRow.Item("Id_Customer")
        _Direccion = objCustomerRow.Item("Address")
        Try
            _Giro = objCustomerRow.Item("Turning_Company")
        Catch ex As Exception
            _Giro = ""
        End Try
        Try
            _Departamento = objCustomerRow.Item("Name_Municipality")
        Catch ex As Exception
            _Departamento = ""
        End Try
        If Is_Modificacion Then

        End If
    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        DialogResult = DialogResult.No
        Close()
    End Sub



    Public Function CreateCreditPayment(ByVal row As DataRow, ByVal NoFactura As Long, ByVal TypeInvoice As String) As Boolean
        Dim DaysInvoiceExpiration As Long = 15 ' default
        Try
            DaysInvoiceExpiration = row("DaysInvoiceExpiration")
        Catch ex As Exception
        End Try
        Dim Saldo As Decimal = 0
        Try
            Saldo = row("Saldo")
        Catch ex As Exception

        End Try
        If Saldo >= txtTotalVenta.Text Then
            Dim resp As Integer
            Using ObjSQL As New Generic_SQLServer
                Dim dtTemporal As DataTable = ObjSQL.GetTypeDocument()
                Dim ID_TypeDocument As Integer = 0
                For Each rowTemp As DataRow In dtTemporal.Select("Is_Invoice=1")
                    ID_TypeDocument = rowTemp("ID_CreditDocument")
                    Exit For
                Next
                If ID_TypeDocument = 0 Then
                    MessageBox.Show("No esta configurado el tipo de documento,de credito, verificar", "Satellite ERP", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return False
                End If
                Dim SaldoDeudor As Decimal = txtTotalVenta.Text
                Dim ID_CreditLine As Long = row("Id_LineaDeCredito")
                Dim FechaInicio As Date = Now.AddDays(DaysInvoiceExpiration)
                resp = ObjSQL.AddAccountsReceivable(_ID_Company, txtID_Customer.Text, ID_TypeDocument, ID_CreditLine, NoFactura, SaldoDeudor, 1, FechaInicio, "0", "Pago de Factura (" & TypeInvoice & "): " & NoFactura.ToString("0000000000"))
            End Using
            If resp <> 0 Then
                Using ObjSQL As New Generic_SQLServer

                    ObjSQL.AddDetailsAccountsReceivable(resp, 1, Now.AddDays(DaysInvoiceExpiration), txtTotalVenta.Text)
                End Using
                Return True
            Else
                Return False
            End If

        Else
            Return False
        End If




    End Function



    Private Sub cmdGuardar_Click(sender As Object, e As EventArgs) Handles cmdGuardar.Click
        If CB_FormaPago.Text.Length = 0 Then
            MessageBox.Show("Forma de Pago no puede ir sin datos", "Satellite ERP", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim BankAccount As String = ""
        Dim Id_BankCatalog As Long = 0
        Dim CheckNumber As String = ""

        'TODO: Se tiene que validar que todos los registros esten en base de datos
        '      antes de tirar la impresion.
        Dim NoDocumentoFiscal As Long = 0
        Dim ID_CotizacionIngresada As Long = 0
        Using objDatos As New Financiero_SQLServer
            Dim resp As String = ""
            'TODO: No almacena exeptan se tiene que adiconar
            Dim ID_PaymentType As Long = 1
            If _TipoFactura = "CONSUMIDOR FINAL" Then
                ID_PaymentType = 2
            End If
            REM Cotizacion o Preventa
            If txtTotalExentas.Text = "" Then
                txtTotalExentas.Text = "0.00"
            End If
            If txtTotalVenta.Text = "" Then
                txtTotalVenta.Text = "0.00"
            End If

            If txtIva.Text = "" Then
                txtIva.Text = "0.00"
            End If

            If txtFovial.Text = "" Then
                txtFovial.Text = "0.00"
            End If

            If txtCotrans.Text = "" Then
                txtCotrans.Text = "0.00"
            End If

            If txtSubTotal.Text = "" Then
                txtSubTotal.Text = "0.00"
            End If

            If txtTotalExentas.Text = "" Then
                txtTotalExentas.Text = "0.00"
            End If

            If txtRetencion.Text = "" Then
                txtRetencion.Text = "0.00"
            End If

            If txtCesc.Text = "" Then
                txtCesc.Text = "0.00"

            End If

            resp = objDatos.SetPurchases_TransactionHeader(Data_Id_Company, CB_PeriodoFacturacion.Text, txtNoDocumento.Text, CB_FormaPago.Text, 1, Data_BusinessDay, "", ID_PaymentType, txtID_Customer.Text, txtTotalVenta.Text, txtIva.Text, txtFovial.Text, txtCotrans.Text, txtSubTotal.Text, txtTotalExentas.Text, txtRetencion.Text, txtCesc.Text)

            ID_CotizacionIngresada = resp.Split("|")(1)
            If resp.Split("|")(0) = "OK" Then


            End If
        End Using
        DialogResult = DialogResult.OK
        Close()
    End Sub

    Private Sub txtSubTotal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSubTotal.KeyPress
        Using objValidaciones As New Validaciones
            If Not Char.IsControl(e.KeyChar) Then
                e.Handled = objValidaciones.Validar_Money(sender, e, txtSubTotal)
            End If
        End Using
    End Sub

    Private Sub txtTotalExentas_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTotalExentas.KeyPress
        Using objValidaciones As New Validaciones
            If Not Char.IsControl(e.KeyChar) Then
                e.Handled = objValidaciones.Validar_Money(sender, e, txtTotalExentas)
            End If
        End Using
    End Sub

    Private Sub txtIva_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIva.KeyPress
        Using objValidaciones As New Validaciones
            If Not Char.IsControl(e.KeyChar) Then
                e.Handled = objValidaciones.Validar_Money(sender, e, txtIva)
            End If
        End Using
    End Sub

    Private Sub txtRetencion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRetencion.KeyPress
        Using objValidaciones As New Validaciones
            If Not Char.IsControl(e.KeyChar) Then
                e.Handled = objValidaciones.Validar_Money(sender, e, txtRetencion)
            End If
        End Using
    End Sub

    Private Sub txtFovial_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFovial.KeyPress
        Using objValidaciones As New Validaciones
            If Not Char.IsControl(e.KeyChar) Then
                e.Handled = objValidaciones.Validar_Money(sender, e, txtFovial)
            End If
        End Using
    End Sub

    Private Sub txtCotrans_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCotrans.KeyPress
        Using objValidaciones As New Validaciones
            If Not Char.IsControl(e.KeyChar) Then
                e.Handled = objValidaciones.Validar_Money(sender, e, txtCotrans)
            End If
        End Using
    End Sub

    Private Sub txtCesc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCesc.KeyPress
        Using objValidaciones As New Validaciones
            If Not Char.IsControl(e.KeyChar) Then
                e.Handled = objValidaciones.Validar_Money(sender, e, txtCesc)
            End If
        End Using
    End Sub

    Private Sub txtTotalVenta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTotalVenta.KeyPress
        Using objValidaciones As New Validaciones
            If Not Char.IsControl(e.KeyChar) Then
                e.Handled = objValidaciones.Validar_Money(sender, e, txtTotalVenta)
            End If
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