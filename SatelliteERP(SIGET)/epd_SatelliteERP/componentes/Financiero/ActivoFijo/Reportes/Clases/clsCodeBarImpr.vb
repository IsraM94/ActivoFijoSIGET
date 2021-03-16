
Imports System.Drawing.Printing
Imports System.IO

Public Class clsCodeBarImpr

    Private printPreviewDialog1 As New PrintPreviewDialog
    Private printFontDetalle As Font
    Private printFontDetallePrice As Font
    Private printFontEncabezado As Font = New Font("Courier New", 12)
    Private WithEvents docPrint As New PrintDocument()
    Private _codeBarValue As String
    Public Property codeBarValue() As String
        Get
            Return _codeBarValue
        End Get
        Set(ByVal value As String)
            _codeBarValue = value
        End Set
    End Property


    Public Sub Preview()

        Try
            docPrint.DefaultPageSettings.PaperSize = New System.Drawing.Printing.PaperSize("VinetaSIGET", 310, 110)
            printPreviewDialog1.Document = docPrint
            printPreviewDialog1.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub
    Public Sub Print()
        Dim keyValue As Object
        keyValue = 1
        If keyValue = "0" Then
            docPrint.Print()
        Else
            Preview()
        End If
    End Sub




    ' CAMBIO PARA IMPRIMIR TIPOS DE VENTAS




    Private Sub docPrint_PrintPage(ByVal sender As Object, ByVal e As PrintPageEventArgs) Handles docPrint.PrintPage
        Dim sngLineHeight As Single = 7 '  printFontDetalle.GetHeight + 1
        Dim sngXLocation As Single = 0
        Dim sngYLocation As Single = 150
        REM el tama;o de la imagen tiene que ser el exacto 228x80

        Dim b As BarcodeLib.Barcode = New BarcodeLib.Barcode()
        b.Alignment = BarcodeLib.AlignmentPositions.CENTER
        Dim type As BarcodeLib.TYPE = BarcodeLib.TYPE.UNSPECIFIED
        type = BarcodeLib.TYPE.CODE128A
        b.IncludeLabel = False
        b.RotateFlipType = System.Drawing.RotateFlipType.RotateNoneFlipNone
        b.LabelPosition = BarcodeLib.LabelPositions.BOTTOMCENTER


        Dim W As Integer = 300
        Dim H As Integer = 50
        Dim imagen As Bitmap = b.Encode(type, _codeBarValue, Color.Black, Color.White,W,h)





        sngYLocation += sngLineHeight
        sngYLocation += sngLineHeight



        Dim drawString As String = "SIGET-INVENTARIO"
        Dim drawFont As New Font("Century Gothic", 12, FontStyle.Bold)
        Dim drawBrush As New SolidBrush(Color.Black)
        e.Graphics.DrawString(drawString, drawFont, drawBrush, 85, (16 - _Parammargensup))

        e.Graphics.DrawImage(imagen, Integer.Parse(_Parammargencod), Integer.Parse((36 - _Parammargensup)))

        drawString = _codeBarValue.Substring(0, 3) & "-" & _codeBarValue.Substring(3, 3) & "-" & _codeBarValue.Substring(6)
        drawFont = New Font("Century Gothic", 12, FontStyle.Bold)
        drawBrush = New SolidBrush(Color.Black)
        e.Graphics.DrawString(drawString, drawFont, drawBrush, 85, (85 - _Parammargensup))



    End Sub
    Dim codigoBarrasF As String
    Dim logitudCodigoBarras As Integer
    Dim Grafico As System.Drawing.Graphics
    Private EAN As New PictureBox
    Public Sub CodeBarEan()
        Dim tipoCodBarras As Byte
        Select Case Len(_codeBarValue)
            Case 0 To 6

                Exit Sub
            Case 7 To 11
                tipoCodBarras = 7
                logitudCodigoBarras = 8
            Case 12 To 20
                tipoCodBarras = 12
                logitudCodigoBarras = 13
        End Select

        codigoBarrasF = formarCodBarras(_codeBarValue.Remove(tipoCodBarras))
        _codeBarValue = codigoBarrasF

        Grafico = EAN.CreateGraphics
        dibujarCodigoBarras(Grafico)
    End Sub
    Function formarCodBarras(ByVal codBarrasOr As String) As String
        formarCodBarras = codBarrasOr & comprobarDigitoControl(codBarrasOr)
    End Function

    Function comprobarDigitoControl(ByVal codigoBarras As String) As Byte
        Dim digito, calTotal As Byte
        Dim codTmp As String
        Dim bPal, numC As Byte

        Select Case Len(codigoBarras)
            Case 7, 12
                codTmp = Right("0000000000000000" & codigoBarras, 17)
                bPal = 3
                For numC = 1 To 17
                    calTotal = calTotal + Val(Mid(codTmp, numC, 1)) * bPal
                    bPal = 4 - bPal
                Next
                digito = calTotal Mod 10
                digito = IIf(digito = 0, 0, 10 - digito)
        End Select
        comprobarDigitoControl = digito
    End Function
    Dim CurrentX As Integer
    Dim CurrentY As Integer
    Dim TextoFont As New System.Drawing.Font("Microsoft Sans Serif", 8)

    Dim linea_actual As Integer = 0
    Dim pagina As Integer = 1
    Dim Tamaño As Byte = 1
    Dim ColorPen As New Pen(Brushes.Black, Tamaño)
    Private Sub dibujarCodigoBarras(ByVal Objeto As Object)
        Dim digCentral As Byte
        Dim lposX As Integer
        Dim i, j As Short
        Dim lCurNum, lPrimerNum As Integer
        Dim iMod As Short

        digCentral = IIf(logitudCodigoBarras = 8, 5, 8)


        Objeto.Clear(Color.White)

        lposX = 11

        For i = 1 To logitudCodigoBarras
            lCurNum = CInt(Mid(codigoBarrasF, i, 1))

            If i = 1 Then
                GuardBar(lposX, Objeto)
                lPrimerNum = lCurNum

                CurrentX = 2
                CurrentY = 66

                Objeto.DrawString(IIf(logitudCodigoBarras = 8, "<", lPrimerNum), TextoFont, Brushes.Black, CurrentX, CurrentY)

            End If

            If i <> 1 Or logitudCodigoBarras = 8 Then
                If i < digCentral Then
                    Select Case logitudCodigoBarras
                        Case 8
                            iMod = 0
                        Case 13
                            iMod = medIn(MdlLeft(lPrimerNum), i - 1)
                    End Select
                Else
                    iMod = 2
                End If
            End If

            If i = digCentral Then
                lposX = lposX + 2
                GuardBar(lposX, Objeto)
                lposX = lposX + 1
            End If

            If i <> 1 Then
                For j = 1 To 7
                    If medIn(Mdl(iMod)(lCurNum), j) = 1 Then
                        dibujarLinea(lposX, 0, Objeto)
                    End If

                    lposX = lposX + 1
                Next j

                CurrentX = lposX - 8
                CurrentY = 66

                If i >= digCentral Then
                    CurrentX = CurrentX - 1
                End If
                Objeto.DrawString(lCurNum, TextoFont, Brushes.Black, CurrentX, CurrentY)

            End If
        Next i

        CurrentX = lposX + 8
        CurrentY = 66

        GuardBar(lposX, Objeto)

        If logitudCodigoBarras = 8 Then
            CurrentX = lposX - 2

            Objeto.DrawString(">", TextoFont, Brushes.Black, CurrentX, CurrentY)

        End If


    End Sub
    Private Sub GuardBar(ByRef posX As Integer, ByVal Objeto As Object)
        dibujarLinea(posX, 6, Objeto)
        dibujarLinea(posX + 2, 6, Objeto)
        posX = posX + 3
    End Sub
    Private Sub dibujarLinea(ByRef posX As Integer, ByRef bExten As Byte, ByVal Objeto As Object)
        Objeto.DrawLine(ColorPen, posX, 5, posX, 66 + bExten)

    End Sub
    Function medIn(ByVal vTextoTmp As Object, ByVal vPosicion As Object) As Object
        medIn = CShort(Mid(vTextoTmp, vPosicion, 1))
    End Function
    Public Mdl(2) As Object
    Public MdlLeft As Object

    Function iniciarAr() As Boolean
        Mdl(0) = New Object() {"0001101", "0011001", "0010011", "0111101", "0100011", "0110001", "0101111", "0111011", "0110111", "0001011"}
        Mdl(1) = New Object() {"0100111", "0110011", "0011011", "0100001", "0011101", "0111001", "0000101", "0010001", "0001001", "0010111"}
        Mdl(2) = New Object() {"1110010", "1100110", "1101100", "1000010", "1011100", "1001110", "1010000", "1000100", "1001000", "1110100"}
        MdlLeft = New Object() {"000000", "001011", "001101", "001110", "010011", "011001", "011100", "010101", "010110", "011010"}
    End Function
End Class

