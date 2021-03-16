Imports System.IO
Imports System.Reflection
Imports System.Windows.Forms

Public Class ReportProccesor : Implements IDisposable
    Friend Function GenerarReporte(info As DataTable, dataMostrar As DataTable, TituloReporte As String) As Boolean
        Try
            Dim objExcel As Object
            Dim objWorkbook As Object
            Dim objSheet As Object
            objExcel = CreateObject("Excel.Application")
            objWorkbook = objExcel.WorkBooks.Add
            objSheet = objWorkbook.WorkSheets(1)
            objSheet.Name = "Reporte"
            objSheet.Cells.NumberFormat = "@"

            objSheet.Cells(2, 6).Value = _CompanyName
            Titulo(objSheet, "B2:M2")

            objSheet.Cells(4, 6).Value = TituloReporte
            Titulo(objSheet, "B4:M4")

            'objSheet.Cells(5, 10).Value = "Usuario Genero Reporte: " & _User
            objSheet.Range("B3:B3").Merge()

            'objSheet.Cells(6, 10).Value = "Fecha Generación: " & Now.Date.ToString
            objSheet.Range("B5:B5").Merge()

            objSheet.Range("A2").Select
            Dim ruta As String = "c:\temp"
            objSheet.Shapes.AddPicture(ruta & "\logo.jpg", False, True, 0, 0, 80, 60)

            Dim contadorFila As Integer = 8
            Dim contadorColumna As Integer = 7
            Dim cantColum As Integer = 0
            Dim divisionColum As Integer = 0
            For Each t As DataRow In dataMostrar.Rows
                contadorColumna = contadorColumna + 1
                cantColum = cantColum + 1
            Next
            If cantColum > 13 Then
                contadorColumna = 1
            Else
                divisionColum = cantColum / 2
                contadorColumna = 7 - divisionColum
            End If
            cantColum = 0
            contadorFila = contadorFila + 1
            'Imprimiendo Titulos
            For Each t As DataRow In dataMostrar.Rows
                objSheet.Cells(contadorFila, contadorColumna).Value = t.Item("Titulo")
                EncabIndividual(objSheet, contadorFila, contadorColumna)
                contadorColumna = contadorColumna + 1
                cantColum = cantColum + 1
            Next
            If cantColum > 13 Then
                contadorColumna = 1
            Else
                divisionColum = cantColum / 2
                contadorColumna = 7 - divisionColum
            End If
            contadorFila = contadorFila + 1
            Dim iniciodatos As Integer = contadorFila

            'Imprimiendo Reporte
            For Each columnaImprimir As DataRow In dataMostrar.Rows
                For i As Integer = 0 To info.Rows.Count - 1
                    objSheet.Cells(contadorFila, contadorColumna).Value = limpiaNulls(info.Rows(i).Item(columnaImprimir.Item("campo").ToString()).ToString())
                    contadorFila = contadorFila + 1
                Next i
                contadorFila = iniciodatos
                contadorColumna = contadorColumna + 1
            Next columnaImprimir

            objSheet.Columns.Autofit()

            objExcel.visible = True
            'objExcel.visible = True
        Catch ex As Exception
            MessageBox.Show("Ocurrio un error al generar el reporte" & ex.ToString, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Try
                Dim objSQL As New Generic_SQLServer
                objSQL.SaveLogException(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message.ToString)
            Catch ex2 As Exception

            End Try
            Return False
        End Try
        Return True
    End Function



    Friend Function GenerarReporteControlInventario(info As DataTable, TituloReporte As String) As Boolean
        Try
            Dim objExcel As Object
            Dim objWorkbook As Object
            Dim objSheet As Object
            objExcel = CreateObject("Excel.Application")
            objWorkbook = objExcel.WorkBooks.Add
            objSheet = objWorkbook.WorkSheets(1)
            objSheet.Name = "Reporte"
            objSheet.Cells.NumberFormat = "@"

            objSheet.Cells(2, 6).Value = _CompanyName
            Titulo(objSheet, "B2:M2")

            objSheet.Cells(4, 6).Value = TituloReporte
            Titulo(objSheet, "B4:M4")

            'objSheet.Cells(5, 10).Value = "Usuario Genero Reporte: " & _User
            objSheet.Range("B3:B3").Merge()

            'objSheet.Cells(6, 10).Value = "Fecha Generación: " & Now.Date.ToString
            objSheet.Range("B5:B5").Merge()

            objSheet.Range("A2").Select
            Dim ruta As String = "c:\temp"
            objSheet.Shapes.AddPicture(_CompanyLogo, False, True, 0, 0, 80, 60)

            Dim contadorFila As Integer = 8
            Dim contadorColumna As Integer = 7
            Dim cantColum As Integer = 0
            Dim divisionColum As Integer = 0
            For i As Integer = 0 To info.Columns.Count
                contadorColumna = contadorColumna + 1
                cantColum = cantColum + 1
            Next
            If cantColum > 13 Then
                contadorColumna = 1
            Else
                divisionColum = cantColum / 2
                contadorColumna = 7 - divisionColum
            End If
            cantColum = 0
            contadorFila = contadorFila + 1
            'Imprimiendo Titulos
            For i As Integer = 0 To info.Columns.Count - 1
                If info.Columns(i).ColumnName.ToString <> "Description" Then
                    objSheet.Cells(contadorFila, contadorColumna).Value = info.Columns(i).ColumnName
                    EncabIndividual(objSheet, contadorFila, contadorColumna)
                    contadorColumna = contadorColumna + 1
                    cantColum = cantColum + 1
                End If
            Next
            If cantColum > 13 Then
                contadorColumna = 1
            Else
                divisionColum = cantColum / 2
                contadorColumna = 7 - divisionColum
            End If
            contadorFila = contadorFila + 1
            Dim iniciodatos As Integer = contadorFila

            'Imprimiendo Reporte
            Dim filaproceso As Integer = 0
            Dim con As Integer = 0
            Dim tablaCalc As New DataTable("Data")
            Dim tablaDataProcess As New DataTable("Data")

            Try
                tablaCalc = info.DefaultView.ToTable(True, "Description")
            Catch ex As Exception

            End Try

            tablaDataProcess = info.Clone()
            For Each columnaImprimir As DataRow In tablaCalc.Rows
                Dim qry = From dr As DataRow In info.AsEnumerable()
                          Where dr.Field(Of String)("Description") = columnaImprimir("Description")
                          Select dr


                tablaDataProcess.Rows.Clear()
                tablaDataProcess = qry.CopyToDataTable
                Try
                    If cantColum > 13 Then
                        contadorColumna = 1
                    Else
                        divisionColum = cantColum / 2
                        contadorColumna = 7 - divisionColum
                    End If

                    objSheet.Cells(contadorFila, contadorColumna).Value = limpiaNulls(columnaImprimir("Description").ToString())

                    For s As Integer = 1 To tablaDataProcess.Columns.Count - 2
                        EncabIndividual(objSheet, contadorFila, s)

                    Next

                    Titulo(objSheet, "B" & contadorFila & ":Y" & contadorFila)

                    contadorFila += 1
                    filaproceso = 0
                    For e As Integer = 0 To tablaDataProcess.Rows.Count - 1
                        For i As Integer = 0 To tablaDataProcess.Columns.Count - 1
                            If info.Columns(i).ColumnName.ToString() <> "Description" Then
                                objSheet.Cells(contadorFila, contadorColumna).Value = limpiaNulls(tablaDataProcess.Rows(filaproceso).Item(info.Columns(i).ColumnName.ToString()).ToString())

                                '  contadorFila = contadorFila + 1
                                contadorColumna = contadorColumna + 1
                            End If
                        Next i
                        If cantColum > 13 Then
                            contadorColumna = 1
                        Else
                            divisionColum = cantColum / 2
                            contadorColumna = 7 - divisionColum
                        End If
                        contadorFila += 1
                        filaproceso += 1
                    Next
                Catch ex As Exception

                End Try
                'contadorFila = iniciodatos
                'contadorColumna = contadorColumna + 1

            Next columnaImprimir

            objSheet.Columns.Autofit()

            objExcel.visible = True
            'objExcel.visible = True
        Catch ex As Exception
            MessageBox.Show("Ocurrio un error al generar el reporte" & ex.ToString, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Try
                Dim objSQL As New Generic_SQLServer
                objSQL.SaveLogException(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message.ToString)
            Catch ex2 As Exception

            End Try
            Return False
        End Try
        Return True
    End Function



    Private Sub EncabIndividual(ByVal objSheet As Object, ByVal x As Integer, ByVal y As Integer)
        objSheet.Cells(x, y).Interior.Color = System.Drawing.Color.SteelBlue
        objSheet.Cells(x, y).HorizontalAlignment = -4108
        objSheet.Cells(x, y).VerticalAlignment = -4107
        objSheet.Cells(x, y).WrapText = False
        objSheet.Cells(x, y).Orientation = 0
        objSheet.Cells(x, y).AddIndent = False
        objSheet.Cells(x, y).IndentLevel = 0
        objSheet.Cells(x, y).ShrinkToFit = False
        objSheet.Cells(x, y).ReadingOrder = -5002
        objSheet.Cells(x, y).MergeCells = False
        objSheet.Cells(x, y).Font.Bold = True
        objSheet.Cells(x, y).Font.Color = System.Drawing.Color.White
        objSheet.Cells(x, y).Font.Size = 14

    End Sub

    Private Sub Titulo(ByVal objSheet As Object, ByVal ubicacion As String)
        objSheet.Range(ubicacion).HorizontalAlignment = -4108
        objSheet.Range(ubicacion).VerticalAlignment = -4107
        objSheet.Range(ubicacion).WrapText = False
        objSheet.Range(ubicacion).Orientation = 0
        objSheet.Range(ubicacion).AddIndent = False
        objSheet.Range(ubicacion).IndentLevel = 0
        objSheet.Range(ubicacion).ShrinkToFit = False
        objSheet.Range(ubicacion).ReadingOrder = -5002
        objSheet.Range(ubicacion).MergeCells = False
        objSheet.Range(ubicacion).Merge()
        objSheet.Range(ubicacion).Font.Name = "Arial"
        objSheet.Range(ubicacion).Font.Size = 16
        objSheet.Range(ubicacion).Font.Underline = -4142
        objSheet.Range(ubicacion).Font.ColorIndex = -4105
        objSheet.Range(ubicacion).Font.Underline = 2
        objSheet.Range(ubicacion).Font.Size = 14
    End Sub
    Function limpiaNulls(ByVal dato As Object) As String
        Dim valor = ""
        If Not IsDBNull(dato) Then
            valor = dato
        End If
        Return valor
    End Function


    'Public Function GenerarReporte(query As String, connectionString As String, configuracionCampos As DataTable, TituloReporte As String) As Boolean

    '    Using objSQL As New Generic_SQLServer
    '        Dim dt As DataTable = objSQL.EjecutarQuery(query)
    '        If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
    '            Return GenerarReporte(dt, configuracionCampos, TituloReporte)
    '        End If

    '    End Using
    '    Return False
    'End Function

    'Private Sub Encab(ByVal objSheet As Object, ByVal ubicacion As String)
    '    objSheet.Range(ubicacion).Interior.Color = System.Drawing.Color.SteelBlue
    '    objSheet.Range(ubicacion).HorizontalAlignment = -4108
    '    objSheet.Range(ubicacion).VerticalAlignment = -4107
    '    objSheet.Range(ubicacion).WrapText = False
    '    objSheet.Range(ubicacion).Orientation = 0
    '    objSheet.Range(ubicacion).AddIndent = False
    '    objSheet.Range(ubicacion).IndentLevel = 0
    '    objSheet.Range(ubicacion).ShrinkToFit = False
    '    objSheet.Range(ubicacion).ReadingOrder = -5002
    '    objSheet.Range(ubicacion).MergeCells = False
    '    objSheet.Range(ubicacion).Font.Bold = False
    'End Sub
#Region "IDisposable Support"
    Private disposedValue As Boolean ' To detect redundant calls

    ' IDisposable
    Protected Overridable Sub Dispose(disposing As Boolean)
        If Not disposedValue Then
            If disposing Then
                ' TODO: dispose managed state (managed objects).
            End If

            ' TODO: free unmanaged resources (unmanaged objects) and override Finalize() below.
            ' TODO: set large fields to null.
        End If
        disposedValue = True
    End Sub

    ' TODO: override Finalize() only if Dispose(disposing As Boolean) above has code to free unmanaged resources.
    'Protected Overrides Sub Finalize()
    '    ' Do not change this code.  Put cleanup code in Dispose(disposing As Boolean) above.
    '    Dispose(False)
    '    MyBase.Finalize()
    'End Sub

    ' This code added by Visual Basic to correctly implement the disposable pattern.
    Public Sub Dispose() Implements IDisposable.Dispose
        ' Do not change this code.  Put cleanup code in Dispose(disposing As Boolean) above.
        Dispose(True)
        ' TODO: uncomment the following line if Finalize() is overridden above.
        ' GC.SuppressFinalize(Me)
    End Sub
#End Region

End Class
