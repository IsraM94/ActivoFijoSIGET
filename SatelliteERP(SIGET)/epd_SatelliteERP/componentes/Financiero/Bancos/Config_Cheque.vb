Imports System.Drawing.Printing
Imports System.Drawing
Public Class Config_Cheque
    REM Variables PARA XML
    Private _IsPrinterFisico As Boolean = False
    Private Page_width As Integer = 703
    Private Page_height As Integer = 652
    Private Page_Img As String = ""
    Private _Data_CodigoCliente_IsActive As Boolean
    Private _Data_CodigoCliente_X As Integer
    Private _Data_CodigoCliente_Y As Integer
    Private _Data_NombreCliente_IsActive As Boolean
    Private _Data_NombreCliente_X As Integer
    Private _Data_NombreCliente_Y As Integer
    Private _Data_NRC_IsActive As Boolean
    Private _Data_NRC_X As Integer
    Private _Data_NRC_Y As Integer
    Private _Data_NIT_IsActive As Boolean
    Private _Data_NIT_X As Integer
    Private _Data_NIT_Y As Integer
    Private _Data_FECHA_IsActive As Boolean
    Private _Data_FECHA_X As Integer
    Private _Data_FECHA_Y As Integer
    Private _Data_GIRO_IsActive As Boolean
    Private _Data_GIRO_X As Integer
    Private _Data_GIRO_Y As Integer
    Private _Data_DIRECCION_IsActive As Boolean
    Private _Data_DIRECCION_X As Integer
    Private _Data_DIRECCION_Y As Integer

    Private _Data_DEPARTAMENTO_IsActive As Boolean
    Private _Data_DEPARTAMENTO_X As Integer
    Private _Data_DEPARTAMENTO_Y As Integer


    Private _Data_SUCURSAL_IsActive As Boolean
    Private _Data_SUCURSAL_X As Integer
    Private _Data_SUCURSAL_Y As Integer
    Private _Data_VENDEDOR_IsActive As Boolean
    Private _Data_VENDEDOR_X As Integer
    Private _Data_VENDEDOR_Y As Integer
    Private _Data_FORMAPAGO_IsActive As Boolean
    Private _Data_FORMAPAGO_X As Integer
    Private _Data_FORMAPAGO_Y As Integer
    Private _Data_PAGARE_IsActive As Boolean
    Private _Data_PAGARE_X As Integer
    Private _Data_PAGARE_Y As Integer

    Private _Data_TOTALDESCUENTOS_IsActive As Boolean
    Private _Data_TOTALDESCUENTOS_X As Integer
    Private _Data_TOTALDESCUENTOS_Y As Integer

    Private _Data_SUBTOTAL_IsActive As Boolean
    Private _Data_SUBTOTAL_X As Integer
    Private _Data_SUBTOTAL_Y As Integer

    Private _Data_SUMAS_IsActive As Boolean
    Private _Data_SUMAS_X As Integer
    Private _Data_SUMAS_Y As Integer

    Private _Data_IVA_IsActive As Boolean
    Private _Data_IVA_X As Integer
    Private _Data_IVA_Y As Integer

    Private _Data_TOTALCOTTRANS_IsActive As Boolean
    Private _Data_TOTALCOTTRANS_X As Integer
    Private _Data_TOTALCOTTRANS_Y As Integer

    Private _Data_TOTALFOVIAL_IsActive As Boolean
    Private _Data_TOTALFOVIAL_X As Integer
    Private _Data_TOTALFOVIAL_Y As Integer


    Private _Data_Retencion_IsActive As Boolean
    Private _Data_Retencion_X As Integer
    Private _Data_Retencion_Y As Integer

    Private _Data_TOTALAPagar_IsActive As Boolean
    Private _Data_TOTALAPagar_X As Integer
    Private _Data_TOTALAPagar_Y As Integer

    Private _Data_EXENTO_IsActive As Boolean
    Private _Data_EXENTO_X As Integer
    Private _Data_EXENTO_Y As Integer

    Private _Data_LETRAS_IsActive As Boolean
    Private _Data_LETRAS_X As Integer
    Private _Data_LETRAS_Y As Integer
    Private _Data_LETRAS_MaxLen As Integer
    Private _Data_CANTIDAD_IMPRESIONES As Integer
    Private _Data_Deta_Codigo_IsActive As Boolean
    Private _Data_Deta_Codigo_X As Integer
    Private _Data_Deta_Codigo_Y As Integer

    Private _Data_Deta_Unidad_IsActive As Boolean
    Private _Data_Deta_Unidad_X As Integer
    Private _Data_Deta_Unidad_Y As Integer

    Private _Data_Deta_Cantidad_IsActive As Boolean
    Private _Data_Deta_Cantidad_X As Integer
    Private _Data_Deta_Cantidad_Y As Integer

    Private _Data_Deta_Descripcion_IsActive As Boolean
    Private _Data_Deta_Descripcion_X As Integer
    Private _Data_Deta_Descripcion_Y As Integer

    Private _Data_Deta_PrecioUni_IsActive As Boolean
    Private _Data_Deta_PrecioUni_X As Integer
    Private _Data_Deta_PrecioUni_Y As Integer

    Private _Data_Deta_VentasNoSujetas_IsActive As Boolean
    Private _Data_Deta_VentasNoSujetas_X As Integer
    Private _Data_Deta_VentasNoSujetas_Y As Integer

    Private _Data_Deta_VentasExentas_IsActive As Boolean
    Private _Data_Deta_VentasExentas_X As Integer
    Private _Data_Deta_VentasExentas_Y As Integer

    Private _Data_Deta_VentasGrabadas_IsActive As Boolean
    Private _Data_Deta_VentasGrabadas_X As Integer
    Private _Data_Deta_VentasGrabadas_Y As Integer
    Private _Data_Deta_Ancho As Integer

    REM FIN
    Private _printerFont As New Font("Arial", 6)
    Private _printerFontCourierNew As New Font("Courier New", 9)
    Private _printerFontCourierNewTotal As New Font("Courier New", 9)
    '### Configuración de impresora ###
    Private WithEvents _printer As New PrintDocument()
    Private _detalles As DataTable
    REM DATOS ==================================
    Private _codigoCliente As String
    Private _NombreCliente As String
    Private _NRC As String
    Private _NIT As String
    Private _FechaImpresion As DateTime
    Private _Direccion As String
    Private _Giro As String
    Private _Sucursal As String
    Private _Vendedor As String
    Private _FormaPago As String
    Private _Pagare As String
    Private _Departamento As String
    Private ImagenFactura As Image

    Public Sub FacEncabezado(ByVal CodigoCliente As Long, ByVal NombreCliente As String, ByVal NRC As String,
                                  ByVal NIT As String, ByVal FechaImpresion As DateTime, ByVal Direccion As String,
                                  ByVal Giro As String, ByVal Sucursal As String, ByVal Vendedor As String,
                                  ByVal FormaPago As String, ByVal Pagare As String, ByVal Departamento As String)
        _codigoCliente = CodigoCliente
        _NombreCliente = NombreCliente
        _NIT = NIT
        _NRC = NRC
        _FechaImpresion = FechaImpresion
        _Direccion = Direccion
        _Giro = Giro
        _Sucursal = Sucursal
        _Vendedor = Vendedor
        _FormaPago = FormaPago
        _Pagare = Pagare
        _Departamento = Departamento


    End Sub
    Private _TotalDescuento As Decimal
    Private _SubTotal As Decimal
    Private _Sumas As Decimal
    Private _IVA As Decimal
    Private _TotalCottrans As Decimal
    Private _TotalFovial As Decimal
    Private _TotalAPagar As Decimal
    Private _TotalExento As Decimal
    Private _TotalRetencion As Decimal
    Public Sub FacResumen(ByVal TotalDescuento As Decimal, ByVal Sumas As Decimal, ByVal IVA As Decimal, ByVal SubTotal As Decimal, ByVal TotalCOTTRANS As Decimal,
                          ByVal TotalFOVIAL As Decimal, ByVal TotalExento As Decimal, ByVal TotalAPagar As String, ByVal TotalRetencion As String)
        _TotalDescuento = TotalDescuento
        _Sumas = Sumas
        _IVA = IVA
        _SubTotal = SubTotal
        _TotalCottrans = TotalCOTTRANS
        _TotalFovial = TotalFOVIAL
        _TotalExento = TotalExento
        _TotalAPagar = TotalAPagar
        _TotalRetencion = TotalRetencion
    End Sub
    'Public Sub FacResumen(ByVal codigo As String, ByVal cantidad As Decimal, ByVal unidad As String, ByVal descripcion As String, _
    '                           ByVal precioUnitario As Decimal, ByVal ventasNoSujetas As Decimal, ByVal ventasExentas As Decimal, _
    '                           ByVal ventasGravadas As Decimal, Optional ByVal esGasolina As Boolean = False)
    '    Dim productRow As DataRow = _detalles.NewRow()

    '    If (esGasolina) Then
    '        productRow("cantidad") = cantidad.ToString("0.000")
    '    Else
    '        productRow("cantidad") = CInt(cantidad).ToString()
    '    End If

    '    productRow("codigo") = codigo
    '    productRow("unidad") = unidad
    '    productRow("descripcion") = descripcion
    '    productRow("precio_unitario") = precioUnitario.ToString("$0.00")
    '    productRow("ventas_no_sujetas") = ventasNoSujetas.ToString("$0.00")
    '    productRow("ventas_exentas") = ventasExentas.ToString("$0.00")
    '    productRow("ventas_gravadas") = ventasGravadas.ToString("$0.00")
    '    _detalles.Rows.Add(productRow)
    'End Sub

    Public Sub facDetalle(ByVal codigo As String, ByVal cantidad As Decimal, ByVal unidad As String, ByVal descripcion As String,
                             ByVal precioUnitario As Decimal, ByVal ventasNoSujetas As Decimal, ByVal ventasExentas As Decimal,
                             ByVal ventasGravadas As Decimal, Optional ByVal esGasolina As Boolean = False)
        Dim productRow As DataRow = _detalles.NewRow()

        If (esGasolina) Then
            productRow("cantidad") = cantidad.ToString("0.000")
        Else
            productRow("cantidad") = CInt(cantidad).ToString()
        End If

        productRow("codigo") = codigo
        productRow("unidad") = unidad
        productRow("descripcion") = descripcion
        productRow("precio_unitario") = precioUnitario.ToString("$0.00")
        productRow("ventas_no_sujetas") = ventasNoSujetas.ToString("$0.00")
        productRow("ventas_exentas") = ventasExentas.ToString("$0.00")
        productRow("ventas_gravadas") = ventasGravadas.ToString("$0.00")
        _detalles.Rows.Add(productRow)
    End Sub

    Private Sub CargarConfiguracion(ByVal TipoFactura As String, ByVal DS_ConfigFacturas As DataSet)
        For Each row As DataRow In DS_ConfigFacturas.Tables("CondigutarFacturas").Rows
            If row("TipoFactura") = TipoFactura Then
                Page_width = row("Page_height")
                Page_height = row("Page_width")
                Page_Img = row("Page_Img")
                _Data_CodigoCliente_IsActive = row("_Data_CodigoCliente_IsActive")
                _Data_CodigoCliente_X = row("_Data_CodigoCliente_X")
                _Data_CodigoCliente_Y = row("_Data_CodigoCliente_Y")
                _Data_NombreCliente_IsActive = row("_Data_NombreCliente_IsActive")
                _Data_NombreCliente_X = row("_Data_NombreCliente_X")
                _Data_NombreCliente_Y = row("_Data_NombreCliente_Y")
                _Data_NRC_IsActive = row("_Data_NRC_IsActive")
                _Data_NRC_X = row("_Data_NRC_X")
                _Data_NRC_Y = row("_Data_NRC_Y")
                _Data_NIT_IsActive = row("_Data_NIT_IsActive")
                _Data_NIT_X = row("_Data_NIT_X")
                _Data_NIT_Y = row("_Data_NIT_Y")
                _Data_FECHA_IsActive = row("_Data_FECHA_IsActive")
                _Data_FECHA_X = row("_Data_FECHA_X")
                _Data_FECHA_Y = row("_Data_FECHA_Y")
                _Data_GIRO_IsActive = row("_Data_GIRO_IsActive")
                _Data_GIRO_X = row("_Data_GIRO_X")
                _Data_GIRO_Y = row("_Data_GIRO_Y")
                _Data_DIRECCION_IsActive = row("_Data_DIRECCION_IsActive")
                _Data_DIRECCION_X = row("_Data_DIRECCION_X")
                _Data_DIRECCION_Y = row("_Data_DIRECCION_Y")
                _Data_SUCURSAL_IsActive = row("_Data_SUCURSAL_IsActive")
                _Data_SUCURSAL_X = row("_Data_SUCURSAL_X")
                _Data_SUCURSAL_Y = row("_Data_SUCURSAL_Y")
                _Data_VENDEDOR_IsActive = row("_Data_VENDEDOR_IsActive")
                _Data_VENDEDOR_X = row("_Data_VENDEDOR_X")
                _Data_VENDEDOR_Y = row("_Data_VENDEDOR_Y")
                _Data_FORMAPAGO_IsActive = row("_Data_FORMAPAGO_IsActive")
                _Data_FORMAPAGO_X = row("_Data_FORMAPAGO_X")
                _Data_FORMAPAGO_Y = row("_Data_FORMAPAGO_Y")
                _Data_PAGARE_IsActive = row("_Data_PAGARE_IsActive")
                _Data_PAGARE_X = row("_Data_PAGARE_X")
                _Data_PAGARE_Y = row("_Data_PAGARE_Y")
                _Data_DEPARTAMENTO_IsActive = row("_Data_DEPARTAMENTO_IsActive")
                _Data_DEPARTAMENTO_X = row("_Data_DEPARTAMENTO_X")
                _Data_DEPARTAMENTO_Y = row("_Data_DEPARTAMENTO_Y")
                REM --------------------------
                _Data_TOTALDESCUENTOS_IsActive = row("_Data_TOTALDESCUENTO_IsActive")
                _Data_TOTALDESCUENTOS_X = row("_Data_TOTALDESCUENTO_X")
                _Data_TOTALDESCUENTOS_Y = row("_Data_TOTALDESCUENTO_Y")
                _Data_SUBTOTAL_IsActive = row("_Data_SUBTOTAL_IsActive")
                _Data_SUBTOTAL_X = row("_Data_SUBTOTAL_X")
                _Data_SUBTOTAL_Y = row("_Data_SUBTOTAL_Y")


                _Data_SUMAS_IsActive = row("_Data_SUMAS_IsActive")
                _Data_SUMAS_X = row("_Data_SUMAS_X")
                _Data_SUMAS_Y = row("_Data_SUMAS_Y")

                _Data_IVA_IsActive = row("_Data_IVA_IsActive")
                _Data_IVA_X = row("_Data_IVA_X")
                _Data_IVA_Y = row("_Data_IVA_Y")

                _Data_TOTALCOTTRANS_IsActive = row("_Data_TOTALCOTTRANS_IsActive")
                _Data_TOTALCOTTRANS_X = row("_Data_TOTALCOTTRANS_X")
                _Data_TOTALCOTTRANS_Y = row("_Data_TOTALCOTTRANS_Y")
                _Data_TOTALFOVIAL_IsActive = row("_Data_TOTALFOVIAL_IsActive")
                _Data_TOTALFOVIAL_X = row("_Data_TOTALFOVIAL_X")
                _Data_TOTALFOVIAL_Y = row("_Data_TOTALFOVIAL_Y")

                _Data_Retencion_IsActive = row("_Data_Retencion_IsActive")
                _Data_Retencion_X = row("_Data_Retencion_X")
                _Data_Retencion_Y = row("_Data_Retencion_Y")

                _Data_TOTALAPagar_IsActive = row("_Data_TotalAPagar_IsActive")
                _Data_TOTALAPagar_X = row("_Data_TotalAPagar_X")
                _Data_TOTALAPagar_Y = row("_Data_TotalAPagar_Y")
                _Data_EXENTO_IsActive = row("_Data_EXENTO_IsActive")
                _Data_EXENTO_X = row("_Data_EXENTO_X")
                _Data_EXENTO_Y = row("_Data_EXENTO_Y")
                _Data_LETRAS_IsActive = row("_Data_LETRAS_IsActive")
                _Data_LETRAS_X = row("_Data_LETRAS_X")
                _Data_LETRAS_Y = row("_Data_LETRAS_Y")
                _Data_LETRAS_MaxLen = row("_Data_LETRAS_MaxLen")
                _Data_CANTIDAD_IMPRESIONES = row("_DATA_CANTIDAD_IMPRESIONES")
                REM ---------------------------
                _Data_Deta_Codigo_IsActive = row("_Data_Deta_Codigo_IsActive")
                _Data_Deta_Codigo_X = row("_Data_Deta_Codigo_X")
                _Data_Deta_Codigo_Y = row("_Data_Deta_Codigo_Y")

                _Data_Deta_Unidad_IsActive = row("_Data_Deta_Unidad_IsActive")
                _Data_Deta_Unidad_X = row("_Data_Deta_Unidad_X")
                _Data_Deta_Unidad_Y = row("_Data_Deta_Unidad_Y")

                _Data_Deta_Cantidad_IsActive = row("_Data_Deta_Cantidad_IsActive")
                _Data_Deta_Cantidad_X = row("_Data_Deta_Cantidad_X")
                _Data_Deta_Cantidad_Y = row("_Data_Deta_Cantidad_Y")

                _Data_Deta_Descripcion_IsActive = row("_Data_Deta_Descripcion_IsActive")
                _Data_Deta_Descripcion_X = row("_Data_Deta_Descripcion_X")
                _Data_Deta_Descripcion_Y = row("_Data_Deta_Descripcion_Y")

                _Data_Deta_PrecioUni_IsActive = row("_Data_Deta_PrecioUni_IsActive")
                _Data_Deta_PrecioUni_X = row("_Data_Deta_PrecioUni_X")
                _Data_Deta_PrecioUni_Y = row("_Data_Deta_PrecioUni_Y")

                _Data_Deta_VentasNoSujetas_IsActive = row("_Data_Deta_VentasNoSujetas_IsActive")
                _Data_Deta_VentasNoSujetas_X = row("_Data_Deta_VentasNoSujetas_X")
                _Data_Deta_VentasNoSujetas_Y = row("_Data_Deta_VentasNoSujetas_Y")

                _Data_Deta_VentasExentas_IsActive = row("_Data_Deta_VentasExentas_IsActive")
                _Data_Deta_VentasExentas_X = row("_Data_Deta_VentasExentas_X")
                _Data_Deta_VentasExentas_Y = row("_Data_Deta_VentasExentas_Y")

                _Data_Deta_VentasGrabadas_IsActive = row("_Data_Deta_VentasGrabadas_IsActive")
                _Data_Deta_VentasGrabadas_X = row("_Data_Deta_VentasGrabadas_X")
                _Data_Deta_VentasGrabadas_Y = row("_Data_Deta_VentasGrabadas_Y")
                _Data_Deta_Ancho = row("_Data_Deta_Ancho")
                Exit For
                REM   objDatos.DS.Tables("ClientesCreditoFiscal").Rows.(row)
            End If
        Next
    End Sub
    Private Function GetPrinter() As String
        Dim printerName As String = String.Empty
        Dim path As String = System.Reflection.Assembly.GetExecutingAssembly().Location.Replace("\SatelliteFactura.exe", String.Empty)

        Using dsConfigXML As New DataSet()
            dsConfigXML.ReadXml(path & "\Formatos\config.xml")
            printerName = dsConfigXML.Tables(0).Rows(0)("consumidor_final").ToString().Trim()
            REM _incluirImagen = CBool(dsConfigXML.Tables(0).Rows(0)("image"))
            REM          _nombrePC = dsConfigXML.Tables(0).Rows(0)("pc_name").ToString().Trim()
        End Using

        Return printerName
    End Function

    Public Sub New(ByVal tipoFactura As String, ByVal dsConfigFac As DataSet, ByVal picFactura As PictureBox)
        CargarConfiguracion(tipoFactura, dsConfigFac)
        _detalles = New DataTable()
        _detalles.Columns.Add("codigo")
        _detalles.Columns.Add("cantidad")
        _detalles.Columns.Add("unidad")
        _detalles.Columns.Add("descripcion")
        _detalles.Columns.Add("precio_unitario")
        _detalles.Columns.Add("ventas_no_sujetas")
        _detalles.Columns.Add("ventas_exentas")
        _detalles.Columns.Add("ventas_gravadas")
        REM _fecha = GenerarFechaHora(Now)
        REM _printer.DefaultPageSettings.PaperSize = New PaperSize("CustomFacturaUno", 1050, 500)
        _printer.DefaultPageSettings.PaperSize = New PaperSize("CustomFactura", Page_width, Page_height)
        REM  _printer.PrinterSettings.PrinterName = GetPrinter()
        ImagenFactura = picFactura.Image
    End Sub


    Private Sub GenerarDocumento(ByVal sender As System.Object, ByVal pea As PrintPageEventArgs) Handles _printer.PrintPage
        Dim path As String = IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location)
        If Not _IsPrinterFisico Then
            REM pea.Graphics.DrawImage(Image.FromFile(Page_Img), New Point(0, 0))
            pea.Graphics.DrawImage(ImagenFactura, New Point(0, 0))

        End If
        If _Data_CodigoCliente_IsActive Then
            Imprimir(_codigoCliente, _printerFont, Brushes.Black, _Data_CodigoCliente_X, _Data_CodigoCliente_Y, pea)
        End If

        If _Data_NombreCliente_IsActive Then

            Imprimir(_NombreCliente, _printerFont, Brushes.Black, _Data_NombreCliente_X, _Data_NombreCliente_Y, pea)
        End If

        If _Data_NRC_IsActive Then
            Imprimir(_NRC, _printerFont, Brushes.Black, _Data_NRC_X, _Data_NRC_Y, pea)
        End If
        If _Data_NIT_IsActive Then
            Imprimir(_NIT, _printerFont, Brushes.Black, _Data_NIT_X, _Data_NIT_Y, pea)
        End If
        If _Data_FECHA_IsActive Then
            Imprimir(GenerarFechaHora(_FechaImpresion), _printerFont, Brushes.Black, _Data_FECHA_X, _Data_FECHA_Y, pea)
        End If

        If _Data_DIRECCION_IsActive Then
            Imprimir(_Direccion, _printerFont, Brushes.Black, _Data_DIRECCION_X, _Data_DIRECCION_Y, pea)
        End If
        If _Data_DEPARTAMENTO_IsActive Then
            Imprimir(_Departamento, _printerFont, Brushes.Black, _Data_DEPARTAMENTO_X, _Data_DEPARTAMENTO_Y, pea)
        End If
        If _Data_SUCURSAL_IsActive Then
            Imprimir(_Sucursal, _printerFont, Brushes.Black, _Data_SUCURSAL_X, _Data_SUCURSAL_Y, pea)
        End If

        If _Data_VENDEDOR_IsActive Then
            Imprimir(_Vendedor, _printerFont, Brushes.Black, _Data_VENDEDOR_X, _Data_VENDEDOR_Y, pea)
        End If

        If _Data_FORMAPAGO_IsActive Then
            Imprimir(_FormaPago, _printerFont, Brushes.Black, _Data_FORMAPAGO_X, _Data_FORMAPAGO_Y, pea)
        End If

        If _Data_PAGARE_IsActive Then
            Imprimir(_Pagare, _printerFont, Brushes.Black, _Data_PAGARE_X, _Data_PAGARE_Y, pea)
        End If
        If _Data_GIRO_IsActive Then
            Imprimir(_Giro, _printerFont, Brushes.Black, _Data_GIRO_X, _Data_GIRO_Y, pea)
        End If
        Dim y As Integer = _Data_Deta_Codigo_Y

        For Each producto As DataRow In _detalles.Rows
            If _Data_Deta_Codigo_IsActive Then
                Imprimir(producto("codigo").ToString(), _printerFontCourierNew, Brushes.Black, _Data_Deta_Codigo_X, y, pea)
            End If
            If _Data_Deta_Cantidad_IsActive Then
                If Not producto("cantidad").ToString() = "0" Then
                    Imprimir(producto("cantidad").ToString(), _printerFontCourierNew, Brushes.Black, _Data_Deta_Cantidad_X, y, pea)
                End If

            End If
            If _Data_Deta_Unidad_IsActive Then
                Imprimir(producto("unidad").ToString(), _printerFontCourierNew, Brushes.Black, _Data_Deta_Unidad_X, y, pea)
            End If
            If _Data_Deta_PrecioUni_IsActive Then
                If Not producto("precio_unitario").ToString() = "$0.00" Then
                    Imprimir(producto("precio_unitario").ToString(), _printerFontCourierNew, Brushes.Black, _Data_Deta_PrecioUni_X, y, pea)
                End If

            End If
            If _Data_Deta_VentasNoSujetas_IsActive Then
                If Not producto("ventas_no_sujetas").ToString() = "$0.00" Then
                    Imprimir(producto("ventas_no_sujetas").ToString(), _printerFontCourierNew, Brushes.Black, _Data_Deta_VentasNoSujetas_X, y, pea)
                End If
            End If
            If _Data_Deta_VentasExentas_IsActive Then
                If Not producto("ventas_exentas").ToString() = "$0.00" Then
                    Imprimir(producto("ventas_exentas").ToString(), _printerFontCourierNew, Brushes.Black, _Data_Deta_VentasExentas_X, y, pea)
                End If
            End If
            If _Data_Deta_VentasGrabadas_IsActive Then
                If Not producto("ventas_gravadas").ToString() = "$0.00" Then
                    Imprimir(FormatMoney(producto("ventas_gravadas")), _printerFontCourierNew, Brushes.Black, _Data_Deta_VentasGrabadas_X, y, pea)
                End If
            End If

            Dim NoCaracteresDivProducto As Integer = 50 'Se tiene que poner en parametro
            Dim NoSaldoLinea As Integer = 25 'Se tiene que poner en parametro
            Dim longitudProducto As Integer = producto("descripcion").ToString().Length / NoCaracteresDivProducto 'numero de carracteres por linea
            If longitudProducto = 0 Then
                longitudProducto = 1
            End If
            Dim PosInicialProdCorte As Integer = 0

            Dim cadena As String = CortarCadenas(producto("descripcion"), NoCaracteresDivProducto)
            Imprimir(cadena, _printerFontCourierNewTotal, Brushes.Black, _Data_Deta_Descripcion_X, y, pea)
            For I As Integer = 1 To longitudProducto
                '    Dim Linea As String
                '    Try
                '        Linea = producto("descripcion").ToString.Substring(PosInicialProdCorte, NoCaracteresDivProducto)
                '    Catch ex As Exception
                '        Linea = producto("descripcion").ToString.Substring(PosInicialProdCorte)
                '    End Try
                '    Imprimir(Linea, _printerFontCourierNewTotal, Brushes.Black, _Data_Deta_Descripcion_X, y, pea)
                If longitudProducto > 1 Then
                    y += NoSaldoLinea
                End If
                PosInicialProdCorte += NoCaracteresDivProducto
            Next
            If longitudProducto > 1 Then
                y = y - NoSaldoLinea
            End If
            Try
                Dim ppp() As String = producto("descripcion").ToString.Split(vbCrLf)
                y = y + ppp.Length * NoSaldoLinea
                If ppp.Length > 1 Then
                    y = y - NoSaldoLinea
                End If
            Catch ex As Exception
            End Try
            REM Imprimir(producto("descripcion").ToString(), _printerFont, Brushes.Black, 185.0, y, pea)
            y += _Data_Deta_Ancho
        Next
        If _Data_TOTALDESCUENTOS_IsActive Then
            Imprimir(FormatMoney(_TotalDescuento), _printerFontCourierNewTotal, Brushes.Black, _Data_TOTALDESCUENTOS_X, _Data_TOTALDESCUENTOS_Y, pea)
        End If
        If _Data_SUMAS_IsActive Then
            Imprimir(FormatMoney(_Sumas), _printerFontCourierNewTotal, Brushes.Black, _Data_SUMAS_X, _Data_SUMAS_Y, pea)
        End If
        If _Data_IVA_IsActive Then
            Imprimir(FormatMoney(_IVA), _printerFontCourierNewTotal, Brushes.Black, _Data_IVA_X, _Data_IVA_Y, pea)
        End If
        If _Data_SUBTOTAL_IsActive Then
            Imprimir(FormatMoney(_SubTotal), _printerFontCourierNewTotal, Brushes.Black, _Data_SUBTOTAL_X, _Data_SUBTOTAL_Y, pea)
        End If
        If _Data_TOTALCOTTRANS_IsActive Then
            Imprimir(FormatMoney(_TotalCottrans), _printerFontCourierNewTotal, Brushes.Black, _Data_TOTALCOTTRANS_X, _Data_TOTALCOTTRANS_Y, pea)
        End If
        If _Data_TOTALFOVIAL_IsActive Then
            Imprimir(FormatMoney(_TotalFovial), _printerFontCourierNewTotal, Brushes.Black, _Data_TOTALFOVIAL_X, _Data_TOTALFOVIAL_Y, pea)
        End If
        If _Data_Retencion_IsActive Then
            Imprimir(FormatMoney(_TotalRetencion), _printerFontCourierNewTotal, Brushes.Black, _Data_Retencion_X, _Data_Retencion_Y, pea)
        End If
        If _Data_TOTALAPagar_IsActive Then
            Imprimir(FormatMoney(_TotalAPagar), _printerFontCourierNewTotal, Brushes.Black, _Data_TOTALAPagar_X, _Data_TOTALAPagar_Y, pea)
        End If
        If _Data_EXENTO_IsActive Then
            Imprimir(FormatMoney(_TotalExento), _printerFontCourierNewTotal, Brushes.Black, _Data_EXENTO_X, _Data_EXENTO_Y, pea)
        End If

        If _Data_LETRAS_IsActive Then
            Try
                Dim cletras As String = Letras(_TotalAPagar)

                'cletras = "un mil novecientos treinta y dos "
                'y = _Data_LETRAS_Y
                'Imprimir(cletras, _printerFontCourierNew, Brushes.Black, _Data_LETRAS_X, y, pea)
                'y += 13
                'cletras = "con 30/100 Dolares"
                'Imprimir(cletras, _printerFontCourierNew, Brushes.Black, _Data_LETRAS_X, y, pea)

                y = _Data_LETRAS_Y
                Dim LineaLetras As String = ""
                For Each s As String In cletras.Split(" ")

                    If (LineaLetras & s).Length >= _Data_LETRAS_MaxLen Then
                        Imprimir(LineaLetras, _printerFontCourierNew, Brushes.Black, _Data_LETRAS_X, y, pea)
                        LineaLetras = ""
                        y += 13
                    End If
                    LineaLetras &= s & " "

                Next
                If LineaLetras.Trim.Length > 0 Then
                    Imprimir(LineaLetras, _printerFontCourierNew, Brushes.Black, _Data_LETRAS_X, y, pea)
                    LineaLetras = ""
                    y += 13
                End If
                'Dim PosInicialProdCorte As Integer = 0
                'Dim longitudProducto As Integer = cletras.Length / _Data_LETRAS_MaxLen 'numero de carracteres por linea
                'If longitudProducto = 0 Then
                '    longitudProducto = 1
                'End If
                'For I As Integer = 1 To longitudProducto
                '    Dim Linea As String
                '    Try
                '        Linea = cletras.Substring(PosInicialProdCorte, _Data_LETRAS_MaxLen) & "-"
                '    Catch ex As Exception
                '        Linea = cletras.Substring(PosInicialProdCorte)
                '    End Try
                '    Imprimir(Linea, _printerFontCourierNew, Brushes.Black, _Data_LETRAS_X, y, pea)
                '    If longitudProducto > 1 Then
                '        y += 13
                '    End If
                '    PosInicialProdCorte += _Data_LETRAS_MaxLen
                'Next
                REM Imprimir(letras(_TotalAPagar), _printerFontCourierNew, Brushes.Black, _Data_LETRAS_X, _Data_LETRAS_Y, pea)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        End If
    End Sub

    Private Function CortarCadenas(ByVal text As String, ByVal maxWidth As Integer) As String
        Dim LineaC As String = ""
        Dim retVal As String = String.Empty
        Dim valores() As String = text.Split(" ")
        Dim valor As String = ""
        Dim cade As String = ""
        Dim salto As Boolean = False

        For Each ele In valores
            valor &= ele + " "
            If (valor.Length > maxWidth) Then
                valor = valor.Substring(0, valor.Length - ele.Length - 1).Trim
                If (salto) Then
                    cade &= vbCrLf
                End If
                cade &= valor
                valor = ele + " "
                salto = True
            End If
        Next
        If (cade.Length > 0) Then
            cade &= vbCrLf + valor
        Else
            cade &= valor
        End If
        Return cade
    End Function


    Public Sub Imprimir()
        For i As Integer = 1 To _Data_CANTIDAD_IMPRESIONES
            _IsPrinterFisico = True
            MessageBox.Show("Por favor colocar la factura en impresor", "SatelliteFAC", MessageBoxButtons.OK, MessageBoxIcon.Information)
            _printer.Print()
        Next

    End Sub
    Public Sub Preview(ByVal PrintPreviewDialog1 As PrintPreviewDialog)
        PrintPreviewDialog1.Document = _printer 'PrintPreviewDialog associate with PrintDocument.
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Public Sub Preview(ByVal PrintPreviewDialog1 As PrintPreviewControl)
        PrintPreviewDialog1.Document = _printer 'PrintPreviewDialog associate with PrintDocument.
        PrintPreviewDialog1.Show()
    End Sub
    Private Sub Imprimir(ByVal detalle As String, ByVal f As Font, ByVal b As Brush, ByVal x As Decimal, ByVal y As Decimal, ByRef pea As PrintPageEventArgs)
        pea.Graphics.DrawString(detalle, f, b, x, y - 14)
    End Sub
    Private Function FormatMoney(ByVal Monto As Decimal) As String
        Dim cMonto As String = Monto.ToString("$#,###,###,##0.00")
        cMonto = Space(20 - cMonto.Length) & cMonto
        Return cMonto
    End Function
    Private Function GenerarFecha(ByVal fecha As DateTime) As String
        Dim mes As String = String.Empty
        Dim mesNum As Integer = fecha.Month

        If (mesNum = 1) Then
            mes = "ENE"
        ElseIf (mesNum = 2) Then
            mes = "FEB"
        ElseIf (mesNum = 3) Then
            mes = "MAR"
        ElseIf (mesNum = 4) Then
            mes = "ABR"
        ElseIf (mesNum = 5) Then
            mes = "MAY"
        ElseIf (mesNum = 6) Then
            mes = "JUN"
        ElseIf (mesNum = 7) Then
            mes = "JUL"
        ElseIf (mesNum = 8) Then
            mes = "AGO"
        ElseIf (mesNum = 9) Then
            mes = "SEP"
        ElseIf (mesNum = 10) Then
            mes = "OCT"
        ElseIf (mesNum = 11) Then
            mes = "NOV"
        Else
            mes = "DIC"
        End If

        Return (fecha.Day.ToString("00") & "/" & mes & "/" & fecha.Year.ToString())
    End Function
    Private Function GenerarFechaHora(ByVal fecha As DateTime) As String
        Dim mes As String = String.Empty
        Dim mesNum As Integer = fecha.Month

        If (mesNum = 1) Then
            mes = "ENE"
        ElseIf (mesNum = 2) Then
            mes = "FEB"
        ElseIf (mesNum = 3) Then
            mes = "MAR"
        ElseIf (mesNum = 4) Then
            mes = "ABR"
        ElseIf (mesNum = 5) Then
            mes = "MAY"
        ElseIf (mesNum = 6) Then
            mes = "JUN"
        ElseIf (mesNum = 7) Then
            mes = "JUL"
        ElseIf (mesNum = 8) Then
            mes = "AGO"
        ElseIf (mesNum = 9) Then
            mes = "SEP"
        ElseIf (mesNum = 10) Then
            mes = "OCT"
        ElseIf (mesNum = 11) Then
            mes = "NOV"
        Else
            mes = "DIC"
        End If
        REM  Return (fecha.Day.ToString("00") & "/" & mes & "/" & fecha.Year.ToString() & " " & Now.Hour.ToString("00") & ":" & Now.Minute.ToString("00"))
        Return (fecha.Day.ToString("00") & "/" & mes & "/" & fecha.Year.ToString())
    End Function
    Public Function Letras(ByVal numero As String) As String
        '********Declara variables de tipo cadena************
        Dim palabras, entero, dec, flag As String


        '********Declara variables de tipo entero***********
        Dim num, x, y As Integer

        flag = "N"

        '**********Número Negativo***********
        If Mid(numero, 1, 1) = "-" Then
            numero = Mid(numero, 2, numero.ToString.Length - 1).ToString
            palabras = "menos "
        End If

        '**********Si tiene ceros a la izquierda*************
        For x = 1 To numero.ToString.Length
            If Mid(numero, 1, 1) = "0" Then
                numero = Trim(Mid(numero, 2, numero.ToString.Length).ToString)
                If Trim(numero.ToString.Length) = 0 Then palabras = ""
            Else
                Exit For
            End If
        Next

        '*********Dividir parte entera y decimal************
        For y = 1 To Len(numero)
            If Mid(numero, y, 1) = "." Then
                flag = "S"
            Else
                If flag = "N" Then
                    entero = entero + Mid(numero, y, 1)
                Else
                    dec = dec + Mid(numero, y, 1)
                End If
            End If
        Next y

        If Len(dec) = 1 Then dec = dec & "0"

        '**********proceso de conversión***********
        flag = "N"

        If Val(numero) <= 999999999 Then
            For y = Len(entero) To 1 Step -1
                num = Len(entero) - (y - 1)
                Select Case y
                    Case 3, 6, 9
                        '**********Asigna las palabras para las centenas***********
                        Select Case Mid(entero, num, 1)
                            Case "1"
                                If Mid(entero, num + 1, 1) = "0" And Mid(entero, num + 2, 1) = "0" Then
                                    palabras = palabras & "cien "
                                Else
                                    palabras = palabras & "ciento "
                                End If
                            Case "2"
                                palabras = palabras & "doscientos "
                            Case "3"
                                palabras = palabras & "trescientos "
                            Case "4"
                                palabras = palabras & "cuatrocientos "
                            Case "5"
                                palabras = palabras & "quinientos "
                            Case "6"
                                palabras = palabras & "seiscientos "
                            Case "7"
                                palabras = palabras & "setecientos "
                            Case "8"
                                palabras = palabras & "ochocientos "
                            Case "9"
                                palabras = palabras & "novecientos "
                        End Select
                    Case 2, 5, 8
                        '*********Asigna las palabras para las decenas************
                        Select Case Mid(entero, num, 1)
                            Case "1"
                                If Mid(entero, num + 1, 1) = "0" Then
                                    flag = "S"
                                    palabras = palabras & "diez "
                                End If
                                If Mid(entero, num + 1, 1) = "1" Then
                                    flag = "S"
                                    palabras = palabras & "once "
                                End If
                                If Mid(entero, num + 1, 1) = "2" Then
                                    flag = "S"
                                    palabras = palabras & "doce "
                                End If
                                If Mid(entero, num + 1, 1) = "3" Then
                                    flag = "S"
                                    palabras = palabras & "trece "
                                End If
                                If Mid(entero, num + 1, 1) = "4" Then
                                    flag = "S"
                                    palabras = palabras & "catorce "
                                End If
                                If Mid(entero, num + 1, 1) = "5" Then
                                    flag = "S"
                                    palabras = palabras & "quince "
                                End If
                                If Mid(entero, num + 1, 1) > "5" Then
                                    flag = "N"
                                    palabras = palabras & "dieci"
                                End If
                            Case "2"
                                If Mid(entero, num + 1, 1) = "0" Then
                                    palabras = palabras & "veinte "
                                    flag = "S"
                                Else
                                    palabras = palabras & "veinti"
                                    flag = "N"
                                End If
                            Case "3"
                                If Mid(entero, num + 1, 1) = "0" Then
                                    palabras = palabras & "treinta "
                                    flag = "S"
                                Else
                                    palabras = palabras & "treinta y "
                                    flag = "N"
                                End If
                            Case "4"
                                If Mid(entero, num + 1, 1) = "0" Then
                                    palabras = palabras & "cuarenta "
                                    flag = "S"
                                Else
                                    palabras = palabras & "cuarenta y "
                                    flag = "N"
                                End If
                            Case "5"
                                If Mid(entero, num + 1, 1) = "0" Then
                                    palabras = palabras & "cincuenta "
                                    flag = "S"
                                Else
                                    palabras = palabras & "cincuenta y "
                                    flag = "N"
                                End If
                            Case "6"
                                If Mid(entero, num + 1, 1) = "0" Then
                                    palabras = palabras & "sesenta "
                                    flag = "S"
                                Else
                                    palabras = palabras & "sesenta y "
                                    flag = "N"
                                End If
                            Case "7"
                                If Mid(entero, num + 1, 1) = "0" Then
                                    palabras = palabras & "setenta "
                                    flag = "S"
                                Else
                                    palabras = palabras & "setenta y "
                                    flag = "N"
                                End If
                            Case "8"
                                If Mid(entero, num + 1, 1) = "0" Then
                                    palabras = palabras & "ochenta "
                                    flag = "S"
                                Else
                                    palabras = palabras & "ochenta y "
                                    flag = "N"
                                End If
                            Case "9"
                                If Mid(entero, num + 1, 1) = "0" Then
                                    palabras = palabras & "noventa "
                                    flag = "S"
                                Else
                                    palabras = palabras & "noventa y "
                                    flag = "N"
                                End If
                        End Select
                    Case 1, 4, 7
                        '*********Asigna las palabras para las unidades*********
                        Select Case Mid(entero, num, 1)
                            Case "1"
                                If flag = "N" Then
                                    If y = 1 Then
                                        palabras = palabras & "uno "
                                    Else
                                        palabras = palabras & "un "
                                    End If
                                End If
                            Case "2"
                                If flag = "N" Then palabras = palabras & "dos "
                            Case "3"
                                If flag = "N" Then palabras = palabras & "tres "
                            Case "4"
                                If flag = "N" Then palabras = palabras & "cuatro "
                            Case "5"
                                If flag = "N" Then palabras = palabras & "cinco "
                            Case "6"
                                If flag = "N" Then palabras = palabras & "seis "
                            Case "7"
                                If flag = "N" Then palabras = palabras & "siete "
                            Case "8"
                                If flag = "N" Then palabras = palabras & "ocho "
                            Case "9"
                                If flag = "N" Then palabras = palabras & "nueve "
                        End Select
                End Select

                '***********Asigna la palabra mil***************
                If y = 4 Then
                    If Mid(entero, 6, 1) <> "0" Or Mid(entero, 5, 1) <> "0" Or Mid(entero, 4, 1) <> "0" Or
                    (Mid(entero, 6, 1) = "0" And Mid(entero, 5, 1) = "0" And Mid(entero, 4, 1) = "0" And
                    Len(entero) <= 6) Then palabras = palabras & "mil "
                End If

                '**********Asigna la palabra millón*************
                If y = 7 Then
                    If Len(entero) = 7 And Mid(entero, 1, 1) = "1" Then
                        palabras = palabras & "millón "
                    Else
                        palabras = palabras & "millones "
                    End If
                End If
            Next y

            '**********Une la parte entera y la parte decimal*************
            If dec <> "" Then
                Letras = palabras & "con " & dec & "/100 Dolares"
            Else
                Letras = palabras & " Dolares"
            End If
        Else
            Letras = ""
        End If
    End Function
End Class