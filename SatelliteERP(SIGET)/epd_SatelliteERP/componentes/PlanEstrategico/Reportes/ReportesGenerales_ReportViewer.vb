Imports Microsoft.Reporting.WinForms

Public Class ReportesGenerales_ReportViewer
    Dim _NombreTablaDS As String = ""
    Private _NoReporte As Integer = 0
    Private _IsParametersDS As Boolean = False
    Private _DtGeneric As DataTable
    Private _tableName As String
    Private _ReportName As String

    Sub New(ByVal dt As DataTable, ByVal tableName As String, ByVal ReportName As String, ByVal MesReportado As String, ByVal AnioInicio As String, ByVal AnioFin As String, ByVal Gerencia As String, ByVal Anio1 As Integer, ByVal Anio2 As Integer, ByVal Anio3 As Integer, ByVal Anio4 As Integer, ByVal Anio5 As Integer, ByVal TipoReporte As Integer, ByVal TotalRegistros As Integer)
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        _IsParametersDS = True
        _tableName = tableName
        _ReportName = ReportName
        _DtGeneric = dt

        Try
            ReportViewer1.LocalReport.ReportEmbeddedResource = _ReportName
            Dim parm = New ReportParameter()
            If TipoReporte = 1 Then
                parm = (New ReportParameter("MesReporte", MesReportado, True))
                Me.ReportViewer1.LocalReport.SetParameters(parm)
                parm = (New ReportParameter("Anio", AnioInicio.ToString, True))
                Me.ReportViewer1.LocalReport.SetParameters(parm)
                parm = (New ReportParameter("TotalRegistros", TotalRegistros, True))
                Me.ReportViewer1.LocalReport.SetParameters(parm)

            ElseIf TipoReporte = 2 Then
                parm = (New ReportParameter("TotalRegistros", TotalRegistros.ToString, True))
                Me.ReportViewer1.LocalReport.SetParameters(parm)
                parm = (New ReportParameter("Anio1", Anio1.ToString, True))
                Me.ReportViewer1.LocalReport.SetParameters(parm)
                parm = (New ReportParameter("VistaAnio1", EnvioAnio(Anio1.ToString), True))
                Me.ReportViewer1.LocalReport.SetParameters(parm)
                parm = (New ReportParameter("Anio2", Anio2.ToString, True))
                Me.ReportViewer1.LocalReport.SetParameters(parm)
                parm = (New ReportParameter("VistaAnio2", EnvioAnio(Anio2.ToString), True))
                Me.ReportViewer1.LocalReport.SetParameters(parm)
                parm = (New ReportParameter("Anio3", Anio3.ToString, True))
                Me.ReportViewer1.LocalReport.SetParameters(parm)
                parm = (New ReportParameter("VistaAnio3", EnvioAnio(Anio3.ToString), True))
                Me.ReportViewer1.LocalReport.SetParameters(parm)
                parm = (New ReportParameter("Anio4", Anio4.ToString, True))
                Me.ReportViewer1.LocalReport.SetParameters(parm)
                parm = (New ReportParameter("VistaAnio4", EnvioAnio(Anio4.ToString), True))
                Me.ReportViewer1.LocalReport.SetParameters(parm)
                parm = (New ReportParameter("Anio5", Anio5.ToString, True))
                Me.ReportViewer1.LocalReport.SetParameters(parm)
                parm = (New ReportParameter("VistaAnio5", EnvioAnio(Anio5.ToString), True))
                Me.ReportViewer1.LocalReport.SetParameters(parm)
                parm = (New ReportParameter("AnioInicio", AnioInicio.ToString, True))
                Me.ReportViewer1.LocalReport.SetParameters(parm)
                parm = (New ReportParameter("AnioFin", AnioFin.ToString, True))
                Me.ReportViewer1.LocalReport.SetParameters(parm)
            ElseIf TipoReporte = 3 Then
                parm = (New ReportParameter("MesReporte", MesReportado, True))
                Me.ReportViewer1.LocalReport.SetParameters(parm)
                parm = (New ReportParameter("TotalRegistros", TotalRegistros, True))
                Me.ReportViewer1.LocalReport.SetParameters(parm)
                parm = (New ReportParameter("Gerencia", Gerencia, True))
                Me.ReportViewer1.LocalReport.SetParameters(parm)
            End If
        Catch ex As Exception
        End Try

    End Sub

    Private Function EnvioAnio(ByVal Anio As Integer) As Integer
        If Anio > 0 Then
            Return 1
        Else
            Return 0
        End If
    End Function

    Private Sub Finaciero_ReportViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If _IsParametersDS Then
            Dim x As String = ReportViewer1.LocalReport.ReportEmbeddedResource
            Dim datasource As ReportDataSource = New ReportDataSource(_tableName, _DtGeneric)
            ReportViewer1.LocalReport.DataSources.Add(datasource)
            ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
            ReportViewer1.LocalReport.ReportEmbeddedResource = _ReportName
        Else
            MessageBox.Show("Reporte no definido")
        End If

        Try
            Try
                ReportViewer1.LocalReport.EnableExternalImages = True
                Dim imagePath As String = New Uri(_CompanyLogo).AbsoluteUri
                Dim parameter As New ReportParameter("pathLogo", imagePath)
                ReportViewer1.LocalReport.SetParameters(parameter)
            Catch ex As Exception
                Try
                    ReportViewer1.LocalReport.EnableExternalImages = True
                    Dim imagePath As String = New Uri(_CompanyLogo).AbsoluteUri
                    Dim parameter As New ReportParameter("pathLogo", imagePath)
                    ReportViewer1.LocalReport.SetParameters(parameter)
                Catch ex2 As Exception
                    ReportViewer1.LocalReport.EnableExternalImages = True
                    Dim parameter As New ReportParameter("pathLogo", ".")
                    ReportViewer1.LocalReport.SetParameters(parameter)
                End Try

            End Try

            Dim parm = New ReportParameter()
            'parm = (New ReportParameter("path", "C:\Users\epdsoft6\Pictures\cartonhuevos.png", True))
            'Me.ReportViewer1.LocalReport.SetParameters(parm)
            Try
                If _CompanyName = "" Then
                    parm = (New ReportParameter("CompanyName", " . ", True))
                    Me.ReportViewer1.LocalReport.SetParameters(parm)
                Else
                    parm = (New ReportParameter("CompanyName", _CompanyName, True))
                    Me.ReportViewer1.LocalReport.SetParameters(parm)

                End If

            Catch ex As Exception
                parm = (New ReportParameter("CompanyName", " . ", True))
                Me.ReportViewer1.LocalReport.SetParameters(parm)

            End Try

            Try
                If _HeaderReportColor = "" Then
                    parm = (New ReportParameter("HeaderColor", " . ", True))
                    Me.ReportViewer1.LocalReport.SetParameters(parm)
                Else
                    parm = (New ReportParameter("HeaderColor", _HeaderReportColor, True))
                    Me.ReportViewer1.LocalReport.SetParameters(parm)
                End If
            Catch ex As Exception

            End Try

            Try
                If (_MostrarFiltro) Then
                    parm = (New ReportParameter("FiltradoPor", _FiltradoPor, True))
                    Me.ReportViewer1.LocalReport.SetParameters(parm)
                End If
            Catch ex As Exception
                Try
                    parm = (New ReportParameter("FiltradoPor", " ", True))
                    Me.ReportViewer1.LocalReport.SetParameters(parm)
                Catch ex2 As Exception

                End Try
            End Try
        Catch ex As Exception

        End Try

        Me.ReportViewer1.RefreshReport()
    End Sub


End Class