Imports System.Drawing.Printing

Public Class Config_Reports
    Friend WithEvents docPrint As New PrintDocument()
    Dim dtDetalle As DataTable
    Dim dtCuentasContable As DataTable
    Private Sub cmdTesting_Click(sender As Object, e As EventArgs) Handles cmdTesting.Click
        NoRegistro = 0
        Preview()
    End Sub
    Dim _AnchoPapel As Integer = 600
    Dim NoRegistro As Integer = 0
    Private Sub docPrint_PrintPage(ByVal sender As Object, ByVal e As PrintPageEventArgs) Handles docPrint.PrintPage
        Dim FormatoCentro As New StringFormat
        FormatoCentro.Alignment = objBorrar.ConfigField.Aling
        Dim printFont15 As Font = New Font("Courier New", 10, FontStyle.Regular)
        Dim printFont10 As Font = New Font("Courier New", 9, FontStyle.Regular)

        Dim _NombreComercio As String = "EpdSoft S.A. de C.V."
        Dim _TituloReporte As String = "Partida Contable"
        Dim LargoCaja As Integer = 20
        Dim UnibacionUltimaCajaCreada As Integer = 0
        REM +++ EMPRESA ++++
        Dim objBox As New Rectangle(New Point(0, objBorrar.ConfigField.X), New Size(_AnchoPapel, LargoCaja)) ' 45 calcular cuantos caracteres tiene que bajar
        e.Graphics.DrawString(_NombreComercio, objBorrar.ConfigField.Font, Brushes.Black, objBox, FormatoCentro)
        e.Graphics.DrawRectangle(Pens.Transparent, objBox)
        UnibacionUltimaCajaCreada += LargoCaja
        LargoCaja = 20

        objBox = New Rectangle(New Point(0, UnibacionUltimaCajaCreada + objBorrar.ConfigField.X), New Size(_AnchoPapel, LargoCaja)) ' 45 calcular cuantos caracteres tiene que bajar
        e.Graphics.DrawString(_TituloReporte, objBorrar.ConfigField.Font, Brushes.Black, objBox, FormatoCentro)
        e.Graphics.DrawRectangle(Pens.Transparent, objBox)

        UnibacionUltimaCajaCreada += LargoCaja + 40
        LargoCaja = 20

        e.Graphics.DrawLine(New Pen(Brushes.Black), 0, UnibacionUltimaCajaCreada + 10, 600, UnibacionUltimaCajaCreada + 10)
        Dim TituloDetalle As String = "Cuenta Contable".PadRight(40)
        TituloDetalle &= "Concepto".PadRight(20)
        TituloDetalle &= "Parcial".PadLeft(15)
        TituloDetalle &= "Cargos".PadLeft(15)
        TituloDetalle &= "Abonos".PadLeft(15)

        objBox = New Rectangle(New Point(0, UnibacionUltimaCajaCreada + objBorrar.ConfigField.X), New Size(_AnchoPapel, LargoCaja)) ' 45 calcular cuantos caracteres tiene que bajar
        e.Graphics.DrawString(TituloDetalle, printFont10, Brushes.Black, objBox, FormatoCentro)
        e.Graphics.DrawRectangle(Pens.Transparent, objBox)
        UnibacionUltimaCajaCreada += LargoCaja + 10
        e.Graphics.DrawLine(New Pen(Brushes.Black), 0, UnibacionUltimaCajaCreada, 600, UnibacionUltimaCajaCreada)
        LargoCaja = 15
        Dim LineaActual As String = ""
        Dim LineaAnterior As String = ""
        Dim IdCuenta As String = ""
        Dim LineaDetalle As String = ""
        For i As Integer = NoRegistro To dtDetalle.Rows.Count - 1
            LineaDetalle = dtDetalle.Rows(i)("NumberAccount").ToString.Trim.PadRight(20)
            IdCuenta = dtDetalle.Rows(i)("NumberAccount").ToString.Trim
            LineaDetalle &= dtDetalle.Rows(i)("NombreCuentaContable").ToString.Trim.PadRight(20)
            LineaDetalle &= dtDetalle.Rows(i)("Concept_AccountingIitemBody").ToString.Trim.PadRight(20)
            LineaDetalle &= (CType(dtDetalle.Rows(i)("Item_Charge"), Decimal) + CType(dtDetalle.Rows(i)("Iteml_Deposit"), Decimal)).ToString("$#,##0.00").Trim.PadLeft(15)
            LineaDetalle &= (CType(dtDetalle.Rows(i)("Item_Charge"), Decimal)).ToString("$#,##0.00").Trim.PadLeft(15)
            LineaDetalle &= (CType(dtDetalle.Rows(i)("Iteml_Deposit"), Decimal)).ToString("$#,##0.00").Trim.PadLeft(15)
            Dim CuentaPadre As String = dtDetalle.Rows(i)("NumberAccount")
            Dim AcumlaCuentaContable As String = ""
            Dim NivelCuentaContable As Integer = 2

            For Each s As String In CuentaPadre.Split(".")

                If AcumlaCuentaContable = "" Then
                    AcumlaCuentaContable = s
                Else
                    AcumlaCuentaContable = AcumlaCuentaContable & "." & s
                End If
                If IdCuenta <> AcumlaCuentaContable Then
                    If NivelCuentaContable = AcumlaCuentaContable.Split(".").Length Then
                        If AcumlaCuentaContable <> dtDetalle.Rows(i)("NombreCuentaContable") Then
                            LineaActual = GetLineaPadre(AcumlaCuentaContable)
                            objBox = New Rectangle(New Point(0, UnibacionUltimaCajaCreada + objBorrar.ConfigField.X), New Size(_AnchoPapel, LargoCaja)) ' 45 calcular cuantos caracteres tiene que bajar
                            e.Graphics.DrawString(LineaActual, printFont10, Brushes.Black, objBox, FormatoCentro)
                            e.Graphics.DrawRectangle(Pens.Transparent, objBox)
                            UnibacionUltimaCajaCreada += LargoCaja
                        End If
                    End If
                End If
            Next


            objBox = New Rectangle(New Point(0, UnibacionUltimaCajaCreada + objBorrar.ConfigField.X), New Size(_AnchoPapel, LargoCaja)) ' 45 calcular cuantos caracteres tiene que bajar
            e.Graphics.DrawString(LineaDetalle, printFont10, Brushes.Black, objBox, FormatoCentro)
            e.Graphics.DrawRectangle(Pens.Transparent, objBox)
            UnibacionUltimaCajaCreada += LargoCaja

        Next
        'e.Graphics.DrawImage(My.Resources.Resources.logo, 1, 1)
        'Dim line As String = Nothing
        'If (line IsNot Nothing) Then
        '    e.HasMorePages = True
        'Else
        '    e.HasMorePages = False
        'End If
        '_CurrentPageNumber += 1
        'e.HasMorePages = _CurrentPageNumber
        ' -------------------------------------------
        ' -----Manejo de paginas------
        ' -------------------------------------------

        '    Static pageNum As Integer
        '    Dim prFont As New Font(”Verdana”, 24, GraphicsUnit.Point)
        '    e.Graphics.DrawString(
        '        ”PAGE ” & pageNum + 1, prFont,
        '        Brushes.Black, 700, 1050)
        '    e.Graphics.DrawRectangle(Pens.Blue, 0, 0, 300, 100)
        '    e.Graphics.DrawString(
        '    ”Printing with VB 2008”, prFont,
        'Brushes.Black, 10, 10)
        '    ' Add more printing statements here
        '    ' Following is the logic that determines whether we're done printing
        '    pageNum = pageNum + 1
        '    If pageNum <= 3 Then
        '        e.HasMorePages = True
        '    Else
        '        e.HasMorePages = False
        '        pageNum = 0
        '    End If
    End Sub

    Dim _CurrentPageNumber As Integer = 1
    Public Sub Preview()
        Dim _height As Integer = 500 + 100
        _AnchoPapel = 1200
        docPrint.DefaultPageSettings.PaperSize = New System.Drawing.Printing.PaperSize("PartidaContable", _AnchoPapel, _height)
        PPC_Documents.Document = docPrint
        PPC_Documents.StartPage = 0
        REM PPD_prueba.ShowDialog()
    End Sub

    Private Sub Config_Reports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim obj As New Financiero_SQLServer

        dtDetalle = obj.GeFinance_AccountingItem_Select(Data_Id_Company, 7)
        dtCuentasContable = obj.GetAccountingCatalog(Data_Id_Company)
        ListView1.Items.Add("Tititulo", 1)
        ListView1.Items.Add("Fecha", 2)
        ListView1.Items.Add("Linea", 3)

    End Sub
    Private Function GetLineaPadre(ByVal NumeroCuentaContable As String) As String
        Dim Linea As String = ""
        For Each row As DataRow In dtCuentasContable.Select("NumeroCuentaContable = '" & NumeroCuentaContable.ToString & "'")
            Linea = row("NumeroCuentaContable").ToString.PadRight(20) & row("NombreCuentaContable").ToString.PadRight(20)
            Exit For
        Next
        Return Linea
    End Function
    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        Dim obj As New Configurar_Campos

    End Sub
    Dim objBorrar As New Config_Components

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        objBorrar.ShowDialog()
        Preview()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        PPC_Documents.StartPage = PPC_Documents.StartPage + 1

    End Sub

    Private Sub cmdGeneraPartida_Click(sender As Object, e As EventArgs) Handles cmdGeneraPartida.Click
        Dim obj As New Financiero_SQLServer


        dtDetalle = obj.GeFinance_AccountingItem_Select(Data_Id_Company, 7)

        NoRegistro = 0
        Preview()
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