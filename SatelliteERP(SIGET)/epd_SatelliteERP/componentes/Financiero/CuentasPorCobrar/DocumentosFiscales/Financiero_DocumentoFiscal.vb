Imports System.IO

Public Class Financiero_DocumentoFiscal
    Property objCustomerRow As DataRow
    Property objDetalleFacturaRow As DataTable

    Private _TipoFactura As String = "CREDITO FISCAL"
    Private _Direccion As String = ""
    Private _Giro As String = ""
    Private _Departamento As String = ""
    Private _IsCotizacion As Boolean = False
    Property Is_Modificacion As Boolean = False
    Private objGeneric As New Generic_SQLServer
    Property Is_Cotizacion As Boolean = False
	Property No_Cotizacion As Long
	Property IS_Update As Boolean = False
	Property ID_CotizacionHeader As Long = 0
	Sub New(ByVal TipoFactura As String, Optional IsCotizacion As Boolean = False)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        _TipoFactura = TipoFactura
        _IsCotizacion = IsCotizacion
    End Sub
    Private Sub Financiero_DocumentoFiscal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not _TipoFactura = "CREDITO FISCAL" Then
            GroupBox1.Text = "Documento - Factura Consumidor Final"

        End If
        If _IsCotizacion Then
            GroupBox1.Text &= " - Cotización"
            cmdNuevoProdTemoral.Visible = False
            cmdGuardar.Visible = True
        End If
        DETALLE.Font = New Font("Segoe UI", 11)

        DETALLE.Columns(0).Width = 90
        DETALLE.Columns(1).Width = 80
        DETALLE.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DETALLE.Columns(2).Width = 280
        DETALLE.Columns(3).Width = 100
        DETALLE.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DETALLE.Columns(3).DefaultCellStyle.Format = "c"

        DETALLE.Columns(4).Width = 95
        DETALLE.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DETALLE.Columns(4).DefaultCellStyle.Format = "c"
        DETALLE.Columns(5).Width = 95
        DETALLE.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DETALLE.Columns(5).DefaultCellStyle.Format = "c"

        DETALLE.Columns(6).Width = 95
        DETALLE.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DETALLE.Columns(6).DefaultCellStyle.Format = "c"
        DETALLE.Columns(7).Width = 95
        DETALLE.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DETALLE.Columns(7).DefaultCellStyle.Format = "c"
        DETALLE.ReadOnly = True
        DETALLE.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DETALLE.MultiSelect = False
        DETALLE.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
        DETALLE.AllowUserToResizeColumns = False
        DETALLE.AllowUserToAddRows = False
        DETALLE.AllowUserToDeleteRows = False
        If Is_Modificacion Then

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
            For Each row As DataRow In objDetalleFacturaRow.Rows

                AdicionarProducto(row("Description"), row("Quantity"))
            Next
        End If
    End Sub
    Private Sub AdicionarProducto(ByVal NameProduct As String, ByVal TotalProductos As Integer)
        Dim dtTemp As DataTable = objGeneric.GetProduct(Data_Id_Company, NameProduct)
        If Not dtTemp Is Nothing Then
            If dtTemp.Rows.Count > 0 Then
                Dim IsGrabado As Boolean = True
                Dim TotalGrabados As Decimal = 0D
                Dim TotalExentos As Decimal = 0D
                Try
                    IsGrabado = Not dtTemp(0)("IsExempt")
                Catch ex As Exception
                    IsGrabado = True
                End Try
                Try
                    If Not _TipoFactura = "CREDITO FISCAL" Then
                        Dim Price_Sale As Decimal = dtTemp(0)("Price_Sale") * (1 + Data_TaxPercentage)
                        TotalGrabados = TotalProductos * Price_Sale
                        DETALLE.Rows.Add(TotalProductos, dtTemp(0)("Name_UnitMeasure"), dtTemp(0)("Name_Product"), Price_Sale, 0.00, TotalExentos.ToString("######0.00"), TotalGrabados.ToString("######0.00"), IsGrabado, dtTemp(0)("id_product"))

                    Else
                        If IsGrabado Then
                            Dim Price_Sale As Decimal = dtTemp(0)("Price_Sale")
                            TotalGrabados = TotalProductos * Price_Sale
                            DETALLE.Rows.Add(TotalProductos, dtTemp(0)("Name_UnitMeasure"), dtTemp(0)("Name_Product"), Price_Sale, 0.00, TotalExentos.ToString("######0.00"), TotalGrabados.ToString("######0.00"), IsGrabado, dtTemp(0)("id_product"))
                        Else
                            TotalExentos = TotalProductos * dtTemp(0)("Price_Sale")
                            DETALLE.Rows.Add(TotalProductos, dtTemp(0)("Name_UnitMeasure"), dtTemp(0)("Name_Product"), dtTemp(0)("Price_Sale"), 0.00, TotalExentos.ToString("######0.00"), TotalGrabados.ToString("######0.00"), IsGrabado, dtTemp(0)("id_product"))
                        End If
                    End If
                Catch ex As Exception
                End Try
            End If
        End If


        CalcularTotales()

    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        DialogResult = DialogResult.No
        Close()
    End Sub

    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
        Using objProductSelect As New Generic_SeleccionarProducto
            If Not objProductSelect.ShowDialog() = DialogResult.OK Then
                Exit Sub
            End If
            REM DETALLE.Rows.Add(txtCantidadProd.Text, Unidad, cb_Productos.Text, precioSinIva, "0.00", totalPrecioExento.ToString("######0.00"), totalPrecioSinIva.ToString("######0.00"), IsGrabado)

            Dim borrar As String = ""

            Dim IsGrabado As Boolean = True
            Dim TotalProductos As Decimal = 1 ' Se tiene que pedir al usuario
            Using objNoDoc As New Financiero_DocumentoFiscalDigiteNumero
                objNoDoc.GroupBox1.Text = "Cantidad Productos"
                objNoDoc.NumeroFactura = TotalProductos
                objNoDoc.StartPosition = FormStartPosition.CenterParent
                If objNoDoc.ShowDialog = DialogResult.OK Then
                    TotalProductos = objNoDoc.NumeroFactura
                Else
                    Exit Sub
                End If
            End Using
			Dim valida As Boolean = False
			For Each dgv As DataGridViewRow In DETALLE.Rows
				If dgv.Cells("Id_Product").Value = objProductSelect.rowSelection("id_product") Then
					valida = True
				End If
			Next
			If valida Then
				MessageBox.Show("El producto ya existe en la factura", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
				Exit Sub
			End If

			Dim TotalGrabados As Decimal = 0D
            Dim TotalExentos As Decimal = 0D
            Try
                IsGrabado = Not objProductSelect.rowSelection("IsExempt")
            Catch ex As Exception
                IsGrabado = True
            End Try
            Try
                If Not _TipoFactura = "CREDITO FISCAL" Then
                    Dim Price_Sale As Decimal = objProductSelect.rowSelection("Price_Sale") * (1 + Data_TaxPercentage)
                    TotalGrabados = TotalProductos * Price_Sale
                    DETALLE.Rows.Add(TotalProductos, objProductSelect.rowSelection("Name_UnitMeasure"), objProductSelect.rowSelection("Name_Product"), Price_Sale, 0.00, TotalExentos.ToString("######0.00"), TotalGrabados.ToString("######0.00"), IsGrabado, objProductSelect.rowSelection("id_product"))

                Else
                    If IsGrabado Then
                        Dim Price_Sale As Decimal = objProductSelect.rowSelection("Price_Sale")
                        TotalGrabados = TotalProductos * Price_Sale
                        DETALLE.Rows.Add(TotalProductos, objProductSelect.rowSelection("Name_UnitMeasure"), objProductSelect.rowSelection("Name_Product"), Price_Sale, 0.00, TotalExentos.ToString("######0.00"), TotalGrabados.ToString("######0.00"), IsGrabado, objProductSelect.rowSelection("id_product"))


                    Else
                        TotalExentos = TotalProductos * objProductSelect.rowSelection("Price_Sale")
                        DETALLE.Rows.Add(TotalProductos, objProductSelect.rowSelection("Name_UnitMeasure"), objProductSelect.rowSelection("Name_Product"), objProductSelect.rowSelection("Price_Sale"), 0.00, TotalExentos.ToString("######0.00"), TotalGrabados.ToString("######0.00"), IsGrabado, objProductSelect.rowSelection("id_product"))

                    End If

                End If

            Catch ex As Exception

            End Try

            CalcularTotales()


        End Using
    End Sub
    Private Sub CalcularTotales(Optional ByVal IsRetencion As Boolean = False)
        Dim TotalGrabos As Decimal = 0.0
        Dim TotalExentos As Decimal = 0.0
        Dim TotalIva As Decimal = 0.0
        Dim TotalRetencion As Decimal = 0.0
        For Each row As DataGridViewRow In DETALLE.Rows
            TotalGrabos += row.Cells("VentasGrabadas").Value
            TotalExentos += row.Cells("VentasExentas").Value
        Next

        If Not _TipoFactura = "CREDITO FISCAL" Then
            TotalIva = 0.0
        Else
            TotalIva = Math.Round(TotalGrabos * Data_TaxPercentage, 2)
        End If

        If TotalGrabos > 100 Then ' poner parametro
            If objCustomerRow.Item("Is_BigContributor") Then
                IsRetencion = True
            End If
        End If


        If IsRetencion Then
            If _TipoFactura = "CREDITO FISCAL" Then
                TotalRetencion = TotalGrabos * 0.01 'TotalIva  * 0.01
            Else
                Dim totalSinIVa As Decimal = TotalGrabos / 1.13
                TotalRetencion = totalSinIVa * 0.01 'TotalIva  * 0.01
            End If

        Else
            TotalRetencion = 0.0
        End If
        txtSubTotal.Text = TotalGrabos.ToString("#,###,##0.00")


        txtIva.Text = TotalIva.ToString("#,###,##0.00")
        txtTotalExentas.Text = TotalExentos.ToString("#,###,##0.00")
        txtRetencion.Text = TotalRetencion.ToString("#,###,##0.00")
        txtTotalVenta.Text = (TotalGrabos + TotalIva + TotalExentos - TotalRetencion).ToString("#,###,##0.00")

    End Sub

    Private Sub cmdPreview_Click(sender As Object, e As EventArgs) Handles cmdPreview.Click
        CalcularTotales()

        If CB_FormaPago.Text.Length = 0 Then
            MessageBox.Show("Forma de Pago no puede ir sin datos", "Satellite ERP", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If DETALLE.RowCount = 0 Then
            MessageBox.Show("Tiene que seleccionar al menos un producto", "Satellite ERP", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        ImprimirFacturas(False)

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
                    MessageBox.Show("No está configurado el tipo de documento de crédito, verificar", "Satellite ERP", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
    Private Sub cmdPrint_Click(sender As Object, e As EventArgs) Handles cmdPrint.Click
        CalcularTotales()
        If CB_FormaPago.Text.Length = 0 Then
            MessageBox.Show("Forma de Pago no puede ir sin datos", "Satellite ERP", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If DETALLE.RowCount = 0 Then
            MessageBox.Show("Tiene que seleccionar al menos un producto", "Satellite ERP", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Dim BankAccount As String = ""
        Dim Id_BankCatalog As Long = 0
        Dim CheckNumber As String = ""

        'TODO: Se tiene que validar que todos los registros esten en base de datos
        '      antes de tirar la impresion.
        Dim NoDocumentoFiscal As Long = Now.Minute * 100 + Now.Second
        Dim ID_CotizacionIngresada As Long = 0
        If Not _IsCotizacion Then
            Using objNoDoc As New Financiero_DocumentoFiscalDigiteNumero
                objNoDoc.NumeroFactura = NoDocumentoFiscal
                objNoDoc.StartPosition = FormStartPosition.CenterParent
                If objNoDoc.ShowDialog = DialogResult.OK Then
                    NoDocumentoFiscal = objNoDoc.NumeroFactura
                Else
                    Exit Sub
                End If
            End Using
            If CB_FormaPago.Text.ToUpper = "CHEQUE" Then
                Using objCheque As New Financiero_DocumentoCheques
                    objCheque.StartPosition = FormStartPosition.CenterParent
                    If objCheque.ShowDialog = DialogResult.OK Then
                        BankAccount = objCheque.BankAccount
                        Id_BankCatalog = objCheque.Id_BankCatalog
                        CheckNumber = objCheque.CheckNumber
                    Else
                        Exit Sub
                    End If
                End Using
            ElseIf CB_FormaPago.Text.ToUpper = "CREDITO" Then

                Dim _Dt_DatosCliente As DataTable
                Using objsql As New Generic_SQLServer
                    _Dt_DatosCliente = objsql.GetCreditLine(Data_Id_Company, txtID_Customer.Text, True, False, False) ' Tipo de busqueda 2 para ID_Customer
                End Using
                Dim _Id_row As Integer = 0

                If _Dt_DatosCliente.Rows.Count > 1 Then
                    Using objLinea As New ERP_CreditLine
                        objLinea.Id_Customer = txtID_Customer.Text
                        objLinea.Cliente = txtRazonSocial.Text
                        objLinea.DUI = ""
                        objLinea.IS_Seleccion = True
                        If Not objLinea.ShowDialog() = DialogResult.OK Then
                            Exit Sub
                        Else
                            _Id_row = objLinea.LineaCreditoRetorno
                        End If

                    End Using
                ElseIf _Dt_DatosCliente.Rows.Count = 0 Then
                    MessageBox.Show("No tiene configurada linea de crédito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                Else

                    _Id_row = _Dt_DatosCliente.Rows(0)(0)
                End If
                If _Id_row = -1 Then
                    MessageBox.Show("Crédito no disponible.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
                For Each row As DataRow In _Dt_DatosCliente.Select("id_LineaDeCredito=" & _Id_row)
                    If Not CreateCreditPayment(row, NoDocumentoFiscal, _TipoFactura) Then
                        MessageBox.Show("Fondos insuficientes en linea de crédito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                Next


            End If
        Else
            ' Se pone cero por que no exxiste no. credito fiscal
            NoDocumentoFiscal = 0

        End If

        Using objDatos As New Financiero_SQLServer
            Dim resp As String = ""
            'TODO: No almacena exeptan se tiene que adiconar
            Dim ID_PaymentType As Long = 1
            If _TipoFactura = "CONSUMIDOR FINAL" Then
                ID_PaymentType = 2
            End If
            If Not _IsCotizacion Then
                Dim ID_HeaderOutput As Long = 0
                Dim ID_Bodega As Long = 1 ' Temporal
                Using objSQL As New Operaciones_SQLServer
                    ID_HeaderOutput = objSQL.SP_ERP_Inventory_Output_InventoryHeader(1, 2, "Venta por Factura", 0)
                End Using

                resp = objDatos.SetInvoice_TransactionHeader(1, Data_Id_Company, "", ID_PaymentType, 0, 0, txtID_Customer.Text, txtTotalVenta.Text, txtIva.Text, 0, NoDocumentoFiscal, CB_FormaPago.Text, BankAccount, Id_BankCatalog, CheckNumber)
                If resp.Split("|")(0) = "OK" Then
                    For Each row As DataGridViewRow In DETALLE.Rows
                        If Not row.Cells("Cantidad").Value.ToString() = "" Then
                            objDatos.SetInvoice_TransactionDetail(resp.Split("|")(1), Data_Id_Company, row.Cells("Id_Product").Value,
                                                                  row.Cells("Descripcion").Value, row.Cells("Cantidad").Value,
                                                                  row.Cells("PrecioUnitario").Value, row.Cells("PrecioUnitario").Value,
                                                                  0, row.Cells("VentasGrabadas").Value, row.Cells("VentasExentas").Value, Data_BusinessDay,
                                                                  0, 0, True, ID_HeaderOutput, ID_Bodega)
                        End If
                    Next
                    If Is_Cotizacion Then
                        objDatos.SetQuotation_TransactionVoid(No_Cotizacion, Data_Id_Company, "Facturacion", resp.Split("|")(1))
                    End If
                End If

            Else
				REM Cotizacion o Preventa
				If ID_CotizacionHeader = 0 Then
					resp = objDatos.SetQuotation_TransactionHeader(1, Data_Id_Company, "", ID_PaymentType, 0, 0, txtID_Customer.Text, txtTotalVenta.Text, txtIva.Text, 0, NoDocumentoFiscal, 1, CB_FormaPago.Text)
					ID_CotizacionIngresada = resp.Split("|")(1)
				Else
					objDatos.ERP_SP_Invoice_Quotation_CLEAN_TransactionDetail(ID_CotizacionHeader)
					ID_CotizacionIngresada = ID_CotizacionHeader
					resp = "OK|" & ID_CotizacionHeader
				End If

				If resp.Split("|")(0) = "OK" Then
                    For Each row As DataGridViewRow In DETALLE.Rows
                        If Not row.Cells("Cantidad").Value.ToString() = "" Then
                            objDatos.SetQuotation_TransactionDetail(resp.Split("|")(1), Data_Id_Company, row.Cells("Id_Product").Value,
                                                                    row.Cells("Unidad").Value,
                                                                  row.Cells("Descripcion").Value, row.Cells("Cantidad").Value,
                                                                  row.Cells("PrecioUnitario").Value, row.Cells("PrecioUnitario").Value,
                                                                  0, row.Cells("VentasGrabadas").Value, row.Cells("VentasExentas").Value, Data_BusinessDay,
                                                                  0, 0, True)
                        End If
                    Next

                End If
            End If
        End Using
        If Not _IsCotizacion Then
            ImprimirFacturas(True)
        Else
            REM Imprimir Cotizacion o preventa
            REM   Dim dt As DataTable = objSql.GetFinance_ReportBalance_History(Data_Id_Company, Data_LongAccount, DGW_YearCurrentList.CurrentRow.Cells(1).Value)

            Using objPartidaContable As New Financiero_ReportViewer("ERP_SP_Invoice_Quotation_TransactionDetail_SelectTableAdapter")
                objPartidaContable.Id_AccountingIitemHeading = ID_CotizacionIngresada
                objPartidaContable.ShowDialog()
            End Using
        End If

        DialogResult = DialogResult.OK
        Close()
    End Sub
    Private Function ImprimirFacturas(ByVal IsPrinter As Boolean) As String
        Using objFinance As New Financiero_SQLServer
            'TODO:Se tiene que configurar para procesar otros documentos.
            Dim ID_Type_Billing As Integer = 1
            If _TipoFactura = "CONSUMIDOR FINAL" Then
                ID_Type_Billing = 2
            End If
            Dim _tableConfigBilling As DataTable = objFinance.GetConfigBilling_Select(Data_Id_Company, ID_Type_Billing)
            Dim ds As New DataSet

            Dim xmlDatos As System.IO.StringReader = New System.IO.StringReader(_tableConfigBilling.Rows(0)("Config_XML"))
            Dim xmlSchema As System.IO.StringReader = New System.IO.StringReader(_tableConfigBilling.Rows(0)("Schema_XML"))
            ds.ReadXmlSchema(xmlSchema)
            ds.ReadXml(xmlDatos)
            'CREDITO FISCAL
            'CONSUMIDOR FINAL
            Dim imagen As New PictureBox

            Dim imageData As Byte() = DirectCast(_tableConfigBilling.Rows(0)("picture"), Byte())
            If Not imageData Is Nothing Then
                Using ms As New MemoryStream(imageData, 0, imageData.Length)
                    ms.Write(imageData, 0, imageData.Length)
                    imagen.Image = Image.FromStream(ms, True)
                End Using
            End If

            Dim obj As New Config_Factua(_TipoFactura, ds, imagen)
            obj.FacEncabezado(txtID_Customer.Text, txtRazonSocial.Text, txtNRC.Text, txtNIT.Text, Now, _Direccion, _Giro,
                              "Sucursal", "Vendedor", CB_FormaPago.Text, "", _Departamento)

            For Each row As DataGridViewRow In DETALLE.Rows
                If Not row.Cells("Cantidad").Value.ToString() = "" Then
                    obj.facDetalle(0, row.Cells("Cantidad").Value,
                                       row.Cells("Unidad").Value,
                                       row.Cells("Descripcion").Value,
                                       row.Cells("PrecioUnitario").Value, 0,
                                       row.Cells("VentasExentas").Value,
                                       row.Cells("VentasGrabadas").Value, False)

                End If
            Next
            Dim subTotal As Decimal = CDec(txtIva.Text) + CDec(txtSubTotal.Text)
            If ID_Type_Billing = 2 Then
                subTotal -= txtRetencion.Text
            End If
            obj.FacResumen(0, txtSubTotal.Text, txtIva.Text, subTotal, 0, 0, txtTotalExentas.Text, txtTotalVenta.Text, txtRetencion.Text)
            If IsPrinter Then
                obj.Imprimir()
            Else
                Using objPreview As New Financiero_PreviewDocFiscal

                    objPreview.objFactura = obj
                    objPreview.ShowDialog()
                End Using


            End If
        End Using
        Return "OK"
        'TODO: Validar esta parte que se garantice que devuelve OK si se imprimio la factura de una forma adecuada.
    End Function

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        Try
            DETALLE.Rows.Remove(DETALLE.CurrentRow)
        Catch ex As Exception
        End Try
        CalcularTotales()
    End Sub
    Private Sub cmdNuevoProdTemoral_Click(sender As Object, e As EventArgs) Handles cmdNuevoProdTemoral.Click

        Using objProductTemp As New Producto_Temp_Facturacion
            Dim UnidadMedida As String = "UNI"
            If objProductTemp.ShowDialog = DialogResult.OK Then

                UnidadMedida = objProductTemp.UnidadMedida
                Dim IsGrabado As Boolean = True
                Dim TotalProductos As Decimal = 1 ' Se tiene que pedir al usuario
                Using objNoDoc As New Financiero_DocumentoFiscalDigiteNumero
                    objNoDoc.GroupBox1.Text = "Cantidad Productos"
                    objNoDoc.NumeroFactura = TotalProductos
                    objNoDoc.StartPosition = FormStartPosition.CenterParent
                    If objNoDoc.ShowDialog = DialogResult.OK Then
                        TotalProductos = objNoDoc.NumeroFactura
                    Else
                        Exit Sub
                    End If
                End Using
                Dim TotalGrabados As Decimal = 0D
                Dim TotalExentos As Decimal = 0D
                Try
                    IsGrabado = objProductTemp.EsGrabado
                Catch ex As Exception
                    IsGrabado = True
                End Try
                Try
                    If Not _TipoFactura = "CREDITO FISCAL" Then
                        Dim Price_Sale As Decimal = objProductTemp.SalesAmount * (1 + Data_TaxPercentage)
                        TotalGrabados = TotalProductos * Price_Sale
                        DETALLE.Rows.Add(TotalProductos, UnidadMedida, objProductTemp.Name_Product, Price_Sale, 0.00, TotalExentos.ToString("######0.00"), TotalGrabados.ToString("######0.00"), IsGrabado, -1)
                    Else
                        If IsGrabado Then
                            Dim Price_Sale As Decimal = objProductTemp.SalesAmount
                            TotalGrabados = TotalProductos * Price_Sale
                            DETALLE.Rows.Add(TotalProductos, UnidadMedida, objProductTemp.Name_Product, Price_Sale, 0.00, TotalExentos.ToString("######0.00"), TotalGrabados.ToString("######0.00"), IsGrabado, -1)
                        Else
                            TotalExentos = TotalProductos * objProductTemp.SalesAmount
                            DETALLE.Rows.Add(TotalProductos, UnidadMedida, objProductTemp.Name_Product, objProductTemp.SalesAmount, 0.00, TotalExentos.ToString("######0.00"), TotalGrabados.ToString("######0.00"), IsGrabado, -1)
                        End If
                    End If
                Catch ex As Exception
                End Try
            End If
        End Using
        CalcularTotales()
    End Sub

    Private Sub cmdGuardar_Click(sender As Object, e As EventArgs) Handles cmdGuardar.Click
        CalcularTotales()
        If CB_FormaPago.Text.Length = 0 Then
            MessageBox.Show("Forma de Pago no puede ir sin datos", "Satellite ERP", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If DETALLE.RowCount = 0 Then
            MessageBox.Show("Tiene que seleccionar al menos un producto", "Satellite ERP", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
            resp = objDatos.SetQuotation_TransactionHeader(1, Data_Id_Company, "", ID_PaymentType, 0, 0, txtID_Customer.Text, txtTotalVenta.Text, txtIva.Text, 0, NoDocumentoFiscal, 1, CB_FormaPago.Text)
            ID_CotizacionIngresada = resp.Split("|")(1)
            If resp.Split("|")(0) = "OK" Then
                For Each row As DataGridViewRow In DETALLE.Rows
                    If Not row.Cells("Cantidad").Value.ToString() = "" Then
                        objDatos.SetQuotation_TransactionDetail(resp.Split("|")(1), Data_Id_Company, row.Cells("Id_Product").Value,
                                                                row.Cells("Unidad").Value,
                                                              row.Cells("Descripcion").Value, row.Cells("Cantidad").Value,
                                                              row.Cells("PrecioUnitario").Value, row.Cells("PrecioUnitario").Value,
                                                              0, row.Cells("VentasGrabadas").Value, row.Cells("VentasExentas").Value, Data_BusinessDay,
                                                              0, 0, True)
                    End If
                Next

            End If
        End Using
        DialogResult = DialogResult.OK
        Close()
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