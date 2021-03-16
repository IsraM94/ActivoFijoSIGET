Imports Microsoft.Reporting.WinForms

Public Class Planificacion_ReportViewer

    Dim _NombreTablaDS As String = ""
    Private _NoReporte As Integer = 0
    Private _IsParametersDS As Boolean = False
    Property Id_AccountingIitemHeading As Long = 0
    Private _DtGeneric As DataTable
    Private _DtGeneric2 As DataTable
    Private _DtGeneric3 As DataTable
    Private _tableName As String = ""
    Private _tableName2 As String = ""
    Private _tableName3 As String = ""
    Private _ReportName As String
    Private _TipoLibro As TipoLibroIVA
    Public Enum TipoLibroIVA As Integer
        Ventas_LibroComsumidorFinal
        Ventas_LiborContibuyentes
        Comras_Libro
    End Enum


    Sub New(ByVal dt As DataTable, ByVal tableName As String, ByVal dt2 As DataTable, ByVal tableName2 As String, ByVal ReportName As String, ByVal Id_Objetivo As Integer, ByVal Objetivo As String, ByVal Gerencia As String, ByVal IdDptoSend As Integer)

        ' This call is required by the designer.
        InitializeComponent()
        _IsParametersDS = True
        _tableName = tableName
        _tableName2 = tableName2
        _ReportName = ReportName
        _DtGeneric = dt
        _DtGeneric2 = dt2
        ' Add any initialization after the InitializeComponent() call.
        Using objOperaciones As New POA_SQLServer

            Dim ds As DataSet = objOperaciones.ERP_StrategicGetReporPei(Id_Objetivo, IdDptoSend)
            'Dim x As String = ReportViewer1.LocalReport.ReportEmbeddedResource
            Dim datasource1 As ReportDataSource = New ReportDataSource("ReportePei", ds.Tables(0))
            Dim datasource2 As ReportDataSource = New ReportDataSource("ReportePeiAcciones", ds.Tables(1))
            ReportViewer1.LocalReport.DataSources.Add(datasource1)
            ReportViewer1.LocalReport.DataSources.Add(datasource2)
            'ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
            ReportViewer1.LocalReport.ReportEmbeddedResource = "epd_SatelliteERP.ReportePEI.rdlc"
        End Using
        Try
            Dim parm = New ReportParameter()
            parm = (New ReportParameter("Gerencia", Gerencia.ToString.ToUpper, True))
            Me.ReportViewer1.LocalReport.SetParameters(parm)
            parm = (New ReportParameter("Objetivo", Objetivo, True))
            Me.ReportViewer1.LocalReport.SetParameters(parm)
        Catch ex As Exception

        End Try
    End Sub


    Sub New(ByVal dt As DataTable, ByVal tableName As String, ByVal dt2 As DataTable, ByVal tableName2 As String, ByVal dt3 As DataTable, ByVal tableName3 As String, ByVal ReportName As String, ByVal Id_Departamento As Integer, ByVal Anio As Integer, ByVal Id_Encabezado As Integer, ByVal Tipo As Integer)

        ' This call is required by the designer.
        InitializeComponent()
        _IsParametersDS = True
        _tableName = tableName
        _tableName2 = tableName2
        _tableName3 = tableName3
        _ReportName = ReportName
        _DtGeneric = dt
        _DtGeneric2 = dt2
        _DtGeneric3 = dt3
        ' Add any initialization after the InitializeComponent() call.
        Using objOperaciones As New POA_SQLServer
            Dim ds As New DataSet
            If Tipo = 1 Or Tipo = 3 Then
                ds = objOperaciones.ERP_StrategicGetReporPOAEjecucion(Id_Departamento, Anio, Id_Encabezado, _IdMesReportado)
                Dim datasource3 As ReportDataSource = New ReportDataSource("ReporteProgramados", ds.Tables("datos2"))
                ReportViewer1.LocalReport.DataSources.Add(datasource3)
            Else
                ds = objOperaciones.ERP_StrategicGetReporPOA(Id_Departamento, Anio, Id_Encabezado)
            End If

            'Dim x As String = ReportViewer1.LocalReport.ReportEmbeddedResource
            Dim datasource1 As ReportDataSource = New ReportDataSource("ReportePOA", ds.Tables("datos"))
            Dim datasource2 As ReportDataSource = New ReportDataSource("ReporteInfo", ds.Tables("datos1"))
            ReportViewer1.LocalReport.DataSources.Add(datasource1)
            ReportViewer1.LocalReport.DataSources.Add(datasource2)

            'ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
            If Tipo = 1 Then
                ReportViewer1.LocalReport.ReportEmbeddedResource = "epd_SatelliteERP.ReportePOASeguimiento.rdlc"
                Dim parm = New ReportParameter()
                parm = (New ReportParameter("MesReportado", _MesReportado, True))
                Me.ReportViewer1.LocalReport.SetParameters(parm)
            ElseIf Tipo = 3 Then
                ReportViewer1.LocalReport.ReportEmbeddedResource = "epd_SatelliteERP.ReporteStatusAcciones.rdlc"
            Else
                ReportViewer1.LocalReport.ReportEmbeddedResource = "epd_SatelliteERP.ReportePOA.rdlc"
            End If
        End Using

    End Sub



    Sub New(ByVal dt As DataTable, ByVal tableName As String, ByVal ReportName As String, ByVal Gerencia As String, ByVal Anio As Integer,
            ByVal Evaluacion As String, ByVal Descripcion As String, ByVal Responsable As String, ByVal Autorizacion As String)

        ' This call is required by the designer.
        InitializeComponent()
        _IsParametersDS = True
        _tableName = tableName
        _ReportName = ReportName
        _DtGeneric = dt
        ' Add any initialization after the InitializeComponent() call.
        'Dim dtInfo As DataTable = objOperaciones.ERP_StrategicPlan_GetMapRiesgoReport(Id_MapRisk)
        'Dim x As String = ReportViewer1.LocalReport.ReportEmbeddedResource
        Dim datasource1 As ReportDataSource = New ReportDataSource("ReporteMapaRiesgo", dt)
        ReportViewer1.LocalReport.DataSources.Add(datasource1)
        'ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)


        Dim parm = New ReportParameter()
        If ReportName.ToString.Contains("ReporteMapaRiesgoEvaluacion") Then
            ReportViewer1.LocalReport.ReportEmbeddedResource = "epd_SatelliteERP.ReporteMapaRiesgoEvaluacion.rdlc"
            parm = (New ReportParameter("Gerencia", Gerencia, True))
            Me.ReportViewer1.LocalReport.SetParameters(parm)
            parm = (New ReportParameter("Anio", Anio, True))
            Me.ReportViewer1.LocalReport.SetParameters(parm)
            parm = (New ReportParameter("Responsable", Responsable, True))
            Me.ReportViewer1.LocalReport.SetParameters(parm)
            parm = (New ReportParameter("Autorizacion", Autorizacion, True))
            Me.ReportViewer1.LocalReport.SetParameters(parm)

            parm = (New ReportParameter("Evaluacion", Evaluacion.ToString.ToUpper, True))
            Me.ReportViewer1.LocalReport.SetParameters(parm)
            parm = (New ReportParameter("Descripcion", Descripcion, True))
            Me.ReportViewer1.LocalReport.SetParameters(parm)
        Else
            ReportViewer1.LocalReport.ReportEmbeddedResource = ReportName
            parm = (New ReportParameter("Gerencia", Gerencia, True))
            Me.ReportViewer1.LocalReport.SetParameters(parm)
        End If
    End Sub
    Private Sub Finaciero_ReportViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If _IsParametersDS Then
            Dim x As String = ReportViewer1.LocalReport.ReportEmbeddedResource


            ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
            ReportViewer1.LocalReport.ReportEmbeddedResource = _ReportName
        Else
            If _NombreTablaDS = "ERP_Finance_ReportAccountingTableAdapter" Then
                If _Id_AccountingIitemHeading = 0 Then
                    MessageBox.Show("Parametros incorrectos", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Close()
                End If
                Dim Ds As New EPD_SatelliteERPDataSet
                Dim dt As New EPD_SatelliteERPDataSetTableAdapters.ERP_Finance_ReportAccountingTableAdapter
                dt.Fill(Ds.ERP_Finance_ReportAccounting, Data_Id_Company, Data_BusinessDay, _Id_AccountingIitemHeading)
                Dim x As String = ReportViewer1.LocalReport.ReportEmbeddedResource
                Dim datasource As ReportDataSource = New ReportDataSource("PartidaContable", Ds.Tables("ERP_Finance_ReportAccounting"))
                ReportViewer1.LocalReport.DataSources.Add(datasource)
                ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
                ReportViewer1.LocalReport.ReportEmbeddedResource = "epd_SatelliteERP.Financiero_PartidaContable.rdlc"
            ElseIf _NombreTablaDS = "ERP_Finance_ReportAccountingAllTableAdapter" Then
                Dim Ds As New EPD_SatelliteERPDataSet
                Dim dt As New EPD_SatelliteERPDataSetTableAdapters.ERP_Finance_ReportAccountingAllTableAdapter
                dt.Fill(Ds.ERP_Finance_ReportAccountingAll, Data_Id_Company, Data_BusinessDay)
                Dim x As String = ReportViewer1.LocalReport.ReportEmbeddedResource
                Dim datasource As ReportDataSource = New ReportDataSource("PartidaContable", Ds.Tables("ERP_Finance_ReportAccountingAll"))
                ReportViewer1.LocalReport.DataSources.Add(datasource)
                ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)

                ReportViewer1.LocalReport.ReportEmbeddedResource = "epd_SatelliteERP.Financiero_LibroDiario.rdlc"
            ElseIf _NombreTablaDS = "ERP_Finance_ReportAccountingHighTableAdapter" Then
                Dim Ds As New EPD_SatelliteERPDataSet
                Dim dt As New EPD_SatelliteERPDataSetTableAdapters.ERP_Finance_ReportAccountingHighTableAdapter
                dt.Fill(Ds.ERP_Finance_ReportAccountingHigh, Data_Id_Company, True, Data_LongAccount) ' este 
                Dim x As String = ReportViewer1.LocalReport.ReportEmbeddedResource
                Dim datasource As ReportDataSource = New ReportDataSource("LibroMayor", Ds.Tables("ERP_Finance_ReportAccountingHigh"))
                ReportViewer1.LocalReport.DataSources.Add(datasource)
                ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
                If _NoReporte = 0 Then ' Libro Mayor
                    ReportViewer1.LocalReport.ReportEmbeddedResource = "epd_SatelliteERP.Financiero_LibroMayor.rdlc"
                Else
                    ReportViewer1.LocalReport.ReportEmbeddedResource = "epd_SatelliteERP.Financiero_BalanceComprobacion.rdlc"
                End If
            ElseIf _NombreTablaDS = "ERP_Finance_Reports_SubledgerTableAdapter" Then
                Dim Ds As New EPD_SatelliteERPDataSet
                Dim dt As New EPD_SatelliteERPDataSetTableAdapters.ERP_Finance_Reports_SubledgerTableAdapter
                dt.Fill(Ds.ERP_Finance_Reports_Subledger, Data_Id_Company) ' este 
                Dim x As String = ReportViewer1.LocalReport.ReportEmbeddedResource
                Dim datasource As ReportDataSource = New ReportDataSource("LibroAuxiliar", Ds.Tables("ERP_Finance_Reports_Subledger"))
                ReportViewer1.LocalReport.DataSources.Add(datasource)
                ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
                ReportViewer1.LocalReport.ReportEmbeddedResource = "epd_SatelliteERP.Financiero_LibroAuxiliar.rdlc"
            ElseIf _NombreTablaDS = "ERP_Finance_ReportBalanceTableAdapter" Then
                Dim Ds As New EPD_SatelliteERPDataSet
                Dim dt As New EPD_SatelliteERPDataSetTableAdapters.ERP_Finance_ReportBalanceTableAdapter
                dt.Fill(Ds.ERP_Finance_ReportBalance, Data_Id_Company, Data_LongAccount) ' este 
                Dim x As String = ReportViewer1.LocalReport.ReportEmbeddedResource
                Dim datasource As ReportDataSource = New ReportDataSource("BalanceGeneral", Ds.Tables("ERP_Finance_ReportBalance"))
                ReportViewer1.LocalReport.DataSources.Add(datasource)
                ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
                ReportViewer1.LocalReport.ReportEmbeddedResource = "epd_SatelliteERP.Financiero_BalanceGeneral.rdlc"
            ElseIf _NombreTablaDS = "ERP_SP_Invoice_Quotation_TransactionDetail_SelectTableAdapter" Then
                Dim Ds As New EPD_SatelliteERPDataSet
                Dim dt As New EPD_SatelliteERPDataSetTableAdapters.ERP_SP_Invoice_Quotation_TransactionDetail_SelectTableAdapter
                dt.Fill(Ds.ERP_SP_Invoice_Quotation_TransactionDetail_Select, Id_AccountingIitemHeading, Data_Id_Company) ' este 
                Dim x As String = ReportViewer1.LocalReport.ReportEmbeddedResource
                Dim datasource As ReportDataSource = New ReportDataSource("CotizacionDataSet", Ds.Tables("ERP_SP_Invoice_Quotation_TransactionDetail_Select"))
                ReportViewer1.LocalReport.DataSources.Add(datasource)
                ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
                ReportViewer1.LocalReport.ReportEmbeddedResource = "epd_SatelliteERP.ReporteCotizaciones.rdlc"
            Else
                MessageBox.Show("Reporte no definido")
            End If
        End If

        ''Dim filepath As String = "C:\pruebaimage.jpg"
        'Dim filepath = New Uri("C:\pruebaimage.jpg")
        'Dim path = New ReportParameter("path", filepath.ToString())

        'Me.ReportViewer1.LocalReport.SetParameters(path)
        'path = (New ReportParameter("Company", _CompanyName, True))
        'Me.ReportViewer1.LocalReport.SetParameters(path)

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