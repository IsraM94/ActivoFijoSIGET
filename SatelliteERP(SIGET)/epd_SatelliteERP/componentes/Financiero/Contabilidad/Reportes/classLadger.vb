Imports System.Drawing.Printing

Public Class classLadger
    Friend WithEvents docPrint As New PrintDocument()
    Property PPC_Documents As PrintPreviewControl
    Dim _AnchoPapel As Integer = 600
    Dim _TamanoCaja As Integer = 20
    Private Sub docPrint_PrintPage(ByVal sender As Object, ByVal e As PrintPageEventArgs) Handles docPrint.PrintPage
        Dim FormatoCentro As New StringFormat
        FormatoCentro.Alignment = StringAlignment.Near
        Dim printFont15 As Font = New Font("Courier New", 10, FontStyle.Regular)
        Dim printFont10 As Font = New Font("Courier New", 9, FontStyle.Regular)

        Dim _NombreComercio As String = "EpdSoft S.A. de C.V."
        Dim _TituloReporte As String = "Libro Mayor"
        Dim LargoCaja As Integer = 20
        Dim UnibacionUltimaCajaCreada As Integer = 0
        REM +++ EMPRESA ++++
        Dim objBox As New Rectangle(New Point(0, _TamanoCaja), New Size(_AnchoPapel, LargoCaja)) ' 45 calcular cuantos caracteres tiene que bajar
        e.Graphics.DrawString(_NombreComercio, printFont15, Brushes.Black, objBox, FormatoCentro)
        e.Graphics.DrawRectangle(Pens.Transparent, objBox)
        UnibacionUltimaCajaCreada += LargoCaja
        LargoCaja = 20

        objBox = New Rectangle(New Point(0, UnibacionUltimaCajaCreada + _TamanoCaja), New Size(_AnchoPapel, LargoCaja)) ' 45 calcular cuantos caracteres tiene que bajar
        e.Graphics.DrawString(_TituloReporte, printFont15, Brushes.Black, objBox, FormatoCentro)
        e.Graphics.DrawRectangle(Pens.Transparent, objBox)

        UnibacionUltimaCajaCreada += LargoCaja + 40
        LargoCaja = 20

        e.Graphics.DrawLine(New Pen(Brushes.Black), 0, UnibacionUltimaCajaCreada + 10, 600, UnibacionUltimaCajaCreada + 10)
        Dim TituloDetalle As String = "Cuenta Contable".PadRight(40)
        TituloDetalle &= "Saldo Anterior".PadRight(20)
        TituloDetalle &= "Cargos".PadLeft(15)
        TituloDetalle &= "Abonos".PadLeft(15)
        TituloDetalle &= "Saldo Actual".PadLeft(15)

        objBox = New Rectangle(New Point(0, UnibacionUltimaCajaCreada + _TamanoCaja), New Size(_AnchoPapel, LargoCaja)) ' 45 calcular cuantos caracteres tiene que bajar
        e.Graphics.DrawString(TituloDetalle, printFont10, Brushes.Black, objBox, FormatoCentro)
        e.Graphics.DrawRectangle(Pens.Transparent, objBox)
        UnibacionUltimaCajaCreada += LargoCaja + 10
        e.Graphics.DrawLine(New Pen(Brushes.Black), 0, UnibacionUltimaCajaCreada, 600, UnibacionUltimaCajaCreada)
        LargoCaja = 15
        Dim LineaActual As String = ""
        Dim LineaAnterior As String = ""
        Dim IdCuenta As String = ""
        Dim LineaDetalle As String = ""
        'For i As Integer = NoRegistro To dtDetalle.Rows.Count - 1
        '    LineaDetalle = dtDetalle.Rows(i)("NumberAccount").ToString.Trim.PadRight(20)
        '    IdCuenta = dtDetalle.Rows(i)("NumberAccount").ToString.Trim
        '    LineaDetalle &= dtDetalle.Rows(i)("NombreCuentaContable").ToString.Trim.PadRight(20)
        '    LineaDetalle &= dtDetalle.Rows(i)("Concept_AccountingIitemBody").ToString.Trim.PadRight(20)
        '    LineaDetalle &= (CType(dtDetalle.Rows(i)("Item_Charge"), Decimal) + CType(dtDetalle.Rows(i)("Iteml_Deposit"), Decimal)).ToString("$#,##0.00").Trim.PadLeft(15)
        '    LineaDetalle &= (CType(dtDetalle.Rows(i)("Item_Charge"), Decimal)).ToString("$#,##0.00").Trim.PadLeft(15)
        '    LineaDetalle &= (CType(dtDetalle.Rows(i)("Iteml_Deposit"), Decimal)).ToString("$#,##0.00").Trim.PadLeft(15)
        '    Dim CuentaPadre As String = dtDetalle.Rows(i)("NumberAccount")
        '    Dim AcumlaCuentaContable As String = ""
        '    Dim NivelCuentaContable As Integer = 2

        '    For Each s As String In CuentaPadre.Split(".")

        '        If AcumlaCuentaContable = "" Then
        '            AcumlaCuentaContable = s
        '        Else
        '            AcumlaCuentaContable = AcumlaCuentaContable & "." & s
        '        End If
        '        If IdCuenta <> AcumlaCuentaContable Then
        '            If NivelCuentaContable = AcumlaCuentaContable.Split(".").Length Then
        '                If AcumlaCuentaContable <> dtDetalle.Rows(i)("NombreCuentaContable") Then
        '                    LineaActual = GetLineaPadre(AcumlaCuentaContable)
        '                    objBox = New Rectangle(New Point(0, UnibacionUltimaCajaCreada + objBorrar.ConfigField.X), New Size(_AnchoPapel, LargoCaja)) ' 45 calcular cuantos caracteres tiene que bajar
        '                    e.Graphics.DrawString(LineaActual, printFont10, Brushes.Black, objBox, FormatoCentro)
        '                    e.Graphics.DrawRectangle(Pens.Transparent, objBox)
        '                    UnibacionUltimaCajaCreada += LargoCaja
        '                End If
        '            End If
        '        End If
        '    Next


        'objBox = New Rectangle(New Point(0, UnibacionUltimaCajaCreada + objBorrar.ConfigField.X), New Size(_AnchoPapel, LargoCaja)) ' 45 calcular cuantos caracteres tiene que bajar
        '    e.Graphics.DrawString(LineaDetalle, printFont10, Brushes.Black, objBox, FormatoCentro)
        '    e.Graphics.DrawRectangle(Pens.Transparent, objBox)
        '    UnibacionUltimaCajaCreada += LargoCaja

        'Next

    End Sub
    Public Sub Preview()
        Dim _height As Integer = 500 + 100
        _AnchoPapel = 1200
        docPrint.DefaultPageSettings.PaperSize = New System.Drawing.Printing.PaperSize("PartidaContable", _AnchoPapel, _height)
        PPC_Documents.Document = docPrint
        PPC_Documents.StartPage = 0
        REM PPD_prueba.ShowDialog()
    End Sub
End Class
