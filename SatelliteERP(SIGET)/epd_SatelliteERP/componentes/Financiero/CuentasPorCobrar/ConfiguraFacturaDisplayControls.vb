Imports System.IO

Public Class ConfiguraFacturaDisplayControls
    Private _IsCreditoFiscal As Boolean
    Private _DS_Config As DataSet
    Private objFinance As New Financiero_SQLServer
    Private _PictureFactura As New PictureBox
    Private _ID_Billing As Long
    Private _ID_Type_Billing As Long
    Sub New(ByVal IsCreditoFiscal As Boolean, ByVal DS_Config As DataSet, picFac As PictureBox, ByVal ID_Billing As Long, ByVal ID_Type_Billing As Long)
        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        _IsCreditoFiscal = IsCreditoFiscal
        _DS_Config = DS_Config
        REM _PictureFactura = picFac
        PB_FacturaActual.Image = picFac.Image
        _PictureFactura.Image = picFac.Image
        _ID_Billing = ID_Billing
        _ID_Type_Billing = ID_Type_Billing
    End Sub
    Public Sub Zoom(ByVal incremento As Decimal)
        PPC_ConfigFactura.Zoom = PPC_ConfigFactura.Zoom + incremento
    End Sub
    Private Sub ConfiguraFacturaDisplayControls_Load(sender As Object, e As EventArgs) Handles Me.Load
        CB_TipoFactura.Enabled = False
        If _IsCreditoFiscal Then
            CB_TipoFactura.SelectedIndex = 0
        Else
            CB_TipoFactura.SelectedIndex = 1
        End If
        REM   PB_FacturaActual.BackgroundImage = _PictureFactura.BackgroundImage
    End Sub
    Private Sub CB_TipoFactura_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles CB_TipoFactura.SelectedIndexChanged
        PB_FacturaActual.Image = _PictureFactura.Image

        For Each row As DataRow In _DS_Config.Tables("CondigutarFacturas").Rows
            If row("TipoFactura") = CB_TipoFactura.Text Then
                txtHeight.Text = row("Page_height")
                txtWidth.Text = row("Page_width")
                TextBox1.Text = row("Page_Img")
                CB_CodigoCliente.Checked = row("_Data_CodigoCliente_IsActive")
                txt_CodigoCliente_X.Text = row("_Data_CodigoCliente_X")
                txt_CodigoCliente_Y.Text = row("_Data_CodigoCliente_Y")
                CB_NombreCliente.Checked = row("_Data_NombreCliente_IsActive")
                txt_NombreCliente_X.Text = row("_Data_NombreCliente_X")
                txt_NombreCliente_Y.Text = row("_Data_NombreCliente_Y")

                CB_NRC.Checked = row("_Data_NRC_IsActive")
                txt_NRC_X.Text = row("_Data_NRC_X")
                txt_NRC_Y.Text = row("_Data_NRC_Y")
                CB_NIT.Checked = row("_Data_NIT_IsActive")
                txt_NIT_X.Text = row("_Data_NIT_X")
                txt_NIT_Y.Text = row("_Data_NIT_Y")
                CB_FECHA.Checked = row("_Data_FECHA_IsActive")
                txt_Fecha_X.Text = row("_Data_FECHA_X")
                txt_Fecha_Y.Text = row("_Data_FECHA_Y")
                CB_GIRO.Checked = row("_Data_GIRO_IsActive")
                txt_Giro_X.Text = row("_Data_GIRO_X")
                txt_Giro_Y.Text = row("_Data_GIRO_Y")
                CB_DIRECCION.Checked = row("_Data_DIRECCION_IsActive")
                txt_Direccion_X.Text = row("_Data_DIRECCION_X")
                txt_Direccion_Y.Text = row("_Data_DIRECCION_Y")
                CB_Departa.Checked = row("_Data_DEPARTAMENTO_IsActive")
                txt_Departa_X.Text = row("_Data_DEPARTAMENTO_X")
                txt_Departa_Y.Text = row("_Data_DEPARTAMENTO_Y")

                CB_Sucursal.Checked = row("_Data_SUCURSAL_IsActive")
                txt_Sucursal_X.Text = row("_Data_SUCURSAL_X")
                txt_Sucursal_Y.Text = row("_Data_SUCURSAL_Y")
                CB_Vendedor.Checked = row("_Data_VENDEDOR_IsActive")
                txt_Vendedor_X.Text = row("_Data_VENDEDOR_X")
                txt_Vendedor_Y.Text = row("_Data_VENDEDOR_Y")
                CB_FormaPago.Checked = row("_Data_FORMAPAGO_IsActive")
                txt_FormaPago_X.Text = row("_Data_FORMAPAGO_X")
                txt_FormaPago_Y.Text = row("_Data_FORMAPAGO_Y")
                CB_Pagare.Checked = row("_Data_PAGARE_IsActive")
                txt_Pagare_X.Text = row("_Data_PAGARE_X")
                txt_Pagare_Y.Text = row("_Data_PAGARE_Y")
                CB_TotalDescuento.Checked = row("_Data_TotalDescuento_IsActive")
                txt_TotalDescuento_X.Text = row("_Data_TotalDescuento_X")
                txt_TotalDescuento_Y.Text = row("_Data_TotalDescuento_Y")
                CB_SubTotal.Checked = row("_Data_SubTotal_IsActive")

                CB_Sumas.Checked = row("_Data_Sumas_IsActive")
                txt_Sumas_X.Text = row("_Data_Sumas_X")
                txt_Sumas_Y.Text = row("_Data_Sumas_Y")
                CB_IVA.Checked = row("_Data_IVA_IsActive")
                txt_IVA_X.Text = row("_Data_IVA_X")
                txt_IVA_Y.Text = row("_Data_IVA_Y")

                txt_SubTotal_X.Text = row("_Data_SubTotal_X")
                txt_SubTotal_Y.Text = row("_Data_SubTotal_Y")
                CB_TotalCOTTRANS.Checked = row("_Data_TotalCOTTRANS_IsActive")
                txt_TotalCOTTRANS_X.Text = row("_Data_TotalCOTTRANS_X")
                txt_TotalCOTTRANS_Y.Text = row("_Data_TotalCOTTRANS_Y")
                CB_TotalFOVIAL.Checked = row("_Data_TotalFOVIAL_IsActive")
                txt_TotalFOVIAL_X.Text = row("_Data_TotalFOVIAL_X")
                txt_TotalFOVIAL_Y.Text = row("_Data_TotalFOVIAL_Y")
                CB_Exento.Checked = row("_Data_EXENTO_IsActive")
                txt_Exento_X.Text = row("_Data_EXENTO_X")
                txt_Exento_Y.Text = row("_Data_EXENTO_Y")

                CB_Retencion.Checked = row("_Data_Retencion_IsActive")
                txt_Retencion_X.Text = row("_Data_Retencion_X")
                txt_Retencion_Y.Text = row("_Data_Retencion_Y")

                CB_TotalAPagar.Checked = row("_Data_TotalAPagar_IsActive")
                txt_TotalAPagar_X.Text = row("_Data_TotalAPagar_X")
                txt_TotalAPagar_Y.Text = row("_Data_TotalAPagar_Y")


                CB_Deta_Codigo.Checked = row("_Data_Deta_Codigo_IsActive")
                txt_Deta_Codigo_X.Text = row("_Data_Deta_Codigo_X")
                txt_Deta_Codigo_Y.Text = row("_Data_Deta_Codigo_Y")

                CB_Deta_Unidad.Checked = row("_Data_Deta_Unidad_IsActive")
                txt_Deta_Unidad_X.Text = row("_Data_Deta_Unidad_X")
                txt_Deta_Unidad_Y.Text = row("_Data_Deta_Unidad_Y")

                CB_Deta_Cantidad.Checked = row("_Data_Deta_Cantidad_IsActive")
                txt_Deta_Cantidad_X.Text = row("_Data_Deta_Cantidad_X")
                txt_Deta_Cantidad_Y.Text = row("_Data_Deta_Cantidad_Y")

                CB_Deta_Descripcion.Checked = row("_Data_Deta_Descripcion_IsActive")
                txt_Deta_Descripcion_X.Text = row("_Data_Deta_Descripcion_X")
                txt_Deta_Descripcion_Y.Text = row("_Data_Deta_Descripcion_Y")

                CB_Deta_PrecioUni.Checked = row("_Data_Deta_PrecioUni_IsActive")
                txt_Deta_PrecioUni_X.Text = row("_Data_Deta_PrecioUni_X")
                txt_Deta_PrecioUni_Y.Text = row("_Data_Deta_PrecioUni_Y")

                CB_Deta_VentasNoSujetas.Checked = row("_Data_Deta_VentasNoSujetas_IsActive")
                txt_Deta_VentasNoSujetas_X.Text = row("_Data_Deta_VentasNoSujetas_X")
                txt_Deta_VentasNoSujetas_Y.Text = row("_Data_Deta_VentasNoSujetas_Y")

                CB_Deta_VentasExentas.Checked = row("_Data_Deta_VentasExentas_IsActive")
                txt_Deta_VentasExentas_X.Text = row("_Data_Deta_VentasExentas_X")
                txt_Deta_VentasExentas_Y.Text = row("_Data_Deta_VentasExentas_Y")

                CB_Deta_VentasGrabadas.Checked = row("_Data_Deta_VentasGrabadas_IsActive")
                txt_Deta_VentasGrabadas_X.Text = row("_Data_Deta_VentasGrabadas_X")
                txt_Deta_VentasGrabadas_Y.Text = row("_Data_Deta_VentasGrabadas_Y")
                txt_Deta_Ancho.Text = row("_Data_Deta_Ancho")
                CB_Letras.Checked = row("_Data_LETRAS_IsActive")
                txt_Letras_X.Text = row("_Data_LETRAS_X")
                txt_Letras_Y.Text = row("_Data_LETRAS_Y")
                txt_Letras_MaxLen.Text = row("_Data_LETRAS_MaxLen")
                txt_CantidadImpresiones.Text = row("_Data_CANTIDAD_IMPRESIONES")
                REM calc
                'chkCalc1.Checked = IIf(row("_Data_Calc_Desc1_IsActive") Is DBNull.Value, False, row("_Data_Calc_Desc1_IsActive"))
                'txtCalcDesc1.Text = row("_Data_Calc_Desc1").ToString
                'chkCalc2.Checked = IIf(row("_Data_Calc_Desc2_IsActive") Is DBNull.Value, False, row("_Data_Calc_Desc2_IsActive"))
                'txtCalcDesc2.Text = row("_Data_Calc_Desc2").ToString
                'chkCalc3.Checked = IIf(row("_Data_Calc_Desc3_IsActive") Is DBNull.Value, False, row("_Data_Calc_Desc3_IsActive"))
                'txtCalcDesc3.Text = row("_Data_Calc_Desc3").ToString
                'chkCalc4.Checked = IIf(row("_Data_Calc_Desc4_IsActive") Is DBNull.Value, False, row("_Data_Calc_Desc4_IsActive"))
                'txtCalcDesc4.Text = row("_Data_Calc_Desc4").ToString
                Exit For
                REM   objDatos.DS.Tables("ClientesCreditoFiscal").Rows.(row)
            End If
        Next
    End Sub

    Private Sub cmdPreview_Click(sender As Object, e As EventArgs) Handles cmdPreview.Click
        GrabarConfiguraciobFAC()
        Dim obj As New Config_Factua(CB_TipoFactura.Text, _DS_Config, PB_FacturaActual)
        obj.FacEncabezado(1234, "Nombre Cliente o Razon Social", "12343-3", "0000-000000-0-000", Now, "La Direccion", "SOFTWARE",
                          "Sucursal", "Vendedor", "FormaPago", "12345", "San Salvador")
        For i As Integer = 1 To txt_NoLineasProductos.Text
            If CB_TestProdutosLineas.Checked Then
				obj.facDetalle("12", 3, "GAL", "La fecturacion realiza muchos lineas dependera del producto que el usuaio ingrese en los productos", 12.12, 10, 10, 212, False)
			Else
                obj.facDetalle("12", 3, "GAL", "Producto # " & i.ToString, 12.12, 1, 2, 212, False)

            End If
        Next
        obj.FacResumen(10, 10, 10, 10, 10, 10, 10, 999999.99, 1)
        obj.Preview(PPC_ConfigFactura)
    End Sub
    Sub GrabarConfiguraciobFAC()
        Dim estaReg As Boolean = False
        For Each row As DataRow In _DS_Config.Tables("CondigutarFacturas").Rows
            If row("TipoFactura") = CB_TipoFactura.Text Then
                pasarDatos(row)
                estaReg = True
                Exit For
                REM   objDatos.DS.Tables("ClientesCreditoFiscal").Rows.(row)
            End If
        Next
        If Not estaReg Then
            Dim row As DataRow = _DS_Config.Tables("CondigutarFacturas").NewRow
            pasarDatos(row)
            _DS_Config.Tables("CondigutarFacturas").Rows.Add(row)
        End If
    End Sub
    Private Sub pasarDatos(ByRef row As DataRow)
        row("TipoFactura") = CB_TipoFactura.Text
        row("Page_height") = txtHeight.Text
        row("Page_width") = txtWidth.Text
        row("Page_Img") = TextBox1.Text
        row("_Data_CodigoCliente_IsActive") = CB_CodigoCliente.Checked
        row("_Data_CodigoCliente_X") = CInt(txt_CodigoCliente_X.Text)
        row("_Data_CodigoCliente_Y") = CInt(txt_CodigoCliente_Y.Text)
        row("_Data_NombreCliente_IsActive") = CB_NombreCliente.Checked
        row("_Data_NombreCliente_X") = CInt(txt_NombreCliente_X.Text)
        row("_Data_NombreCliente_Y") = CInt(txt_NombreCliente_Y.Text)
        row("_Data_NRC_IsActive") = CB_NRC.Checked
        row("_Data_NRC_X") = CInt(txt_NRC_X.Text)
        row("_Data_NRC_Y") = CInt(txt_NRC_Y.Text)
        row("_Data_NIT_IsActive") = CB_NIT.Checked
        row("_Data_NIT_X") = CInt(txt_NIT_X.Text)
        row("_Data_NIT_Y") = CInt(txt_NIT_Y.Text)
        row("_Data_FECHA_IsActive") = CB_FECHA.Checked
        row("_Data_FECHA_X") = CInt(txt_Fecha_X.Text)
        row("_Data_FECHA_Y") = CInt(txt_Fecha_Y.Text)
        row("_Data_GIRO_IsActive") = CB_GIRO.Checked
        row("_Data_GIRO_X") = CInt(txt_Giro_X.Text)
        row("_Data_GIRO_Y") = CInt(txt_Giro_Y.Text)
        row("_Data_DIRECCION_IsActive") = CB_DIRECCION.Checked
        row("_Data_DIRECCION_X") = CInt(txt_Direccion_X.Text)
        row("_Data_DIRECCION_Y") = CInt(txt_Direccion_Y.Text)
        row("_Data_DEPARTAMENTO_IsActive") = CB_Departa.Checked
        row("_Data_DEPARTAMENTO_X") = CInt(txt_Departa_X.Text)
        row("_Data_DEPARTAMENTO_Y") = CInt(txt_Departa_Y.Text)

        row("_Data_SUCURSAL_IsActive") = CB_Sucursal.Checked
        row("_Data_SUCURSAL_X") = CInt(txt_Sucursal_X.Text)
        row("_Data_SUCURSAL_Y") = CInt(txt_Sucursal_Y.Text)
        row("_Data_VENDEDOR_IsActive") = CB_Vendedor.Checked
        row("_Data_VENDEDOR_X") = CInt(txt_Vendedor_X.Text)
        row("_Data_VENDEDOR_Y") = CInt(txt_Vendedor_Y.Text)
        row("_Data_FORMAPAGO_IsActive") = CB_FormaPago.Checked
        row("_Data_FORMAPAGO_X") = CInt(txt_FormaPago_X.Text)
        row("_Data_FORMAPAGO_Y") = CInt(txt_FormaPago_Y.Text)
        row("_Data_PAGARE_IsActive") = CB_Pagare.Checked
        row("_Data_PAGARE_X") = CInt(txt_Pagare_X.Text)
        row("_Data_PAGARE_Y") = CInt(txt_Pagare_Y.Text)
        row("_Data_TotalDescuento_IsActive") = CB_TotalDescuento.Checked
        row("_Data_TotalDescuento_X") = CInt(txt_TotalDescuento_X.Text)
        row("_Data_TotalDescuento_Y") = CInt(txt_TotalDescuento_Y.Text)

        row("_Data_Sumas_IsActive") = CB_Sumas.Checked
        row("_Data_Sumas_X") = CInt(txt_Sumas_X.Text)
        row("_Data_Sumas_Y") = CInt(txt_Sumas_Y.Text)

        row("_Data_IVA_IsActive") = CB_IVA.Checked
        row("_Data_IVA_X") = CInt(txt_IVA_X.Text)
        row("_Data_IVA_Y") = CInt(txt_IVA_Y.Text)

        row("_Data_SubTotal_IsActive") = CB_SubTotal.Checked
        row("_Data_SubTotal_X") = CInt(txt_SubTotal_X.Text)
        row("_Data_SubTotal_Y") = CInt(txt_SubTotal_Y.Text)
        row("_Data_TotalCOTTRANS_IsActive") = CB_TotalCOTTRANS.Checked
        row("_Data_TotalCOTTRANS_X") = CInt(txt_TotalCOTTRANS_X.Text)
        row("_Data_TotalCOTTRANS_Y") = CInt(txt_TotalCOTTRANS_Y.Text)
        row("_Data_TotalFOVIAL_IsActive") = CB_TotalFOVIAL.Checked
        row("_Data_TotalFOVIAL_X") = CInt(txt_TotalFOVIAL_X.Text)
        row("_Data_TotalFOVIAL_Y") = CInt(txt_TotalFOVIAL_Y.Text)

        row("_Data_Exento_IsActive") = CB_Exento.Checked
        row("_Data_Exento_X") = CInt(txt_Exento_X.Text)
        row("_Data_Exento_Y") = CInt(txt_Exento_Y.Text)
        row("_Data_TotalAPagar_IsActive") = CB_TotalAPagar.Checked
        row("_Data_TotalAPagar_X") = CInt(txt_TotalAPagar_X.Text)
        row("_Data_TotalAPagar_Y") = CInt(txt_TotalAPagar_Y.Text)

        row("_Data_Retencion_IsActive") = CB_Retencion.Checked
        row("_Data_Retencion_X") = CInt(txt_Retencion_X.Text)
        row("_Data_Retencion_Y") = CInt(txt_Retencion_Y.Text)

        row("_Data_Deta_Codigo_IsActive") = CB_Deta_Codigo.Checked
        row("_Data_Deta_Codigo_X") = CInt(txt_Deta_Codigo_X.Text)
        row("_Data_Deta_Codigo_Y") = CInt(txt_Deta_Codigo_Y.Text)

        row("_Data_Deta_Unidad_IsActive") = CB_Deta_Unidad.Checked
        row("_Data_Deta_Unidad_X") = CInt(txt_Deta_Unidad_X.Text)
        row("_Data_Deta_Unidad_Y") = CInt(txt_Deta_Unidad_Y.Text)

        row("_Data_Deta_Cantidad_IsActive") = CB_Deta_Cantidad.Checked
        row("_Data_Deta_Cantidad_X") = CInt(txt_Deta_Cantidad_X.Text)
        row("_Data_Deta_Cantidad_Y") = CInt(txt_Deta_Cantidad_Y.Text)

        row("_Data_Deta_Descripcion_IsActive") = CB_Deta_Descripcion.Checked
        row("_Data_Deta_Descripcion_X") = CInt(txt_Deta_Descripcion_X.Text)
        row("_Data_Deta_Descripcion_Y") = CInt(txt_Deta_Descripcion_Y.Text)

        row("_Data_Deta_PrecioUni_IsActive") = CB_Deta_PrecioUni.Checked
        row("_Data_Deta_PrecioUni_X") = CInt(txt_Deta_PrecioUni_X.Text)
        row("_Data_Deta_PrecioUni_Y") = CInt(txt_Deta_PrecioUni_Y.Text)

        row("_Data_Deta_VentasNoSujetas_IsActive") = CB_Deta_VentasNoSujetas.Checked
        row("_Data_Deta_VentasNoSujetas_X") = CInt(txt_Deta_VentasNoSujetas_X.Text)
        row("_Data_Deta_VentasNoSujetas_Y") = CInt(txt_Deta_VentasNoSujetas_Y.Text)

        row("_Data_Deta_VentasExentas_IsActive") = CB_Deta_VentasExentas.Checked
        row("_Data_Deta_VentasExentas_X") = CInt(txt_Deta_VentasExentas_X.Text)
        row("_Data_Deta_VentasExentas_Y") = CInt(txt_Deta_VentasExentas_Y.Text)

        row("_Data_Deta_VentasGrabadas_IsActive") = CB_Deta_VentasGrabadas.Checked
        row("_Data_Deta_VentasGrabadas_X") = CInt(txt_Deta_VentasGrabadas_X.Text)
        row("_Data_Deta_VentasGrabadas_Y") = CInt(txt_Deta_VentasGrabadas_Y.Text)
        row("_Data_Deta_Ancho") = CInt(txt_Deta_Ancho.Text)
        row("_Data_LETRAS_IsActive") = CB_Letras.Checked
        row("_Data_LETRAS_X") = CInt(txt_Letras_X.Text)
        row("_Data_LETRAS_Y") = CInt(txt_Letras_Y.Text)
        row("_Data_LETRAS_MaxLen") = CInt(txt_Letras_MaxLen.Text)
        row("_Data_CANTIDAD_IMPRESIONES") = CInt(txt_CantidadImpresiones.Text)

        REM CALC
        'row("_Data_Calc_Desc1_IsActive") = chkCalc1.Checked
        'row("_Data_Calc_Desc1") = txtCalcDesc1.Text
        'row("_Data_Calc_Desc2_IsActive") = chkCalc2.Checked
        'row("_Data_Calc_Desc2") = txtCalcDesc2.Text
        'row("_Data_Calc_Desc3_IsActive") = chkCalc3.Checked
        'row("_Data_Calc_Desc3") = txtCalcDesc3.Text
        'row("_Data_Calc_Desc4_IsActive") = chkCalc4.Checked
        'row("_Data_Calc_Desc4") = txtCalcDesc4.Text
    End Sub

    Private Sub cmdBuscarFacturaImagen_Click(sender As Object, e As EventArgs) Handles cmdBuscarFacturaImagen.Click
        Dim openFileDialog As New OpenFileDialog
        openFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        openFileDialog.Filter = "jpg (*.jpg)|*.jpg|bmp (*.bmp)|*.bmp|png (*.png)|*.png|All Files (*.*)|*.*"

        If (openFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            PB_FacturaActual.Image = Image.FromFile(openFileDialog.FileName)
            PB_FacturaActual.SizeMode = PictureBoxSizeMode.StretchImage
            PB_FacturaActual.Refresh()
        End If

    End Sub

    Private Sub cmdGrabar_Click(sender As Object, e As EventArgs) Handles cmdGrabar.Click
        Dim Datos As String = _DS_Config.GetXml()
        Dim Schema As String = _DS_Config.GetXmlSchema
        Dim ms As New MemoryStream()
        PB_FacturaActual.Image.Save(ms, PB_FacturaActual.Image.RawFormat)
        Dim data As Byte() = ms.GetBuffer()
        objFinance.SetConfigBilling(_ID_Billing, Data_Id_Company, _ID_Type_Billing, CB_TipoFactura.Text, Datos, Schema, data, True)
    End Sub
End Class
