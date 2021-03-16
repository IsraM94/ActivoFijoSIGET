Imports Microsoft.Reporting.WinForms

Public Class Operaciones_ReportViewer

    Dim _NombreTablaDS As String = ""
    Private _NoReporte As Integer = 0
    Private _IsParametersDS As Boolean = False
    Property Id_AccountingIitemHeading As Long = 0
    Private _DtGeneric As DataTable
    Private _tableName As String
    Private _ReportName As String
    Sub New(ByVal dt As DataTable, ByVal tableName As String, ByVal ReportName As String)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        _IsParametersDS = True
        _tableName = tableName
        _ReportName = ReportName
        _DtGeneric = dt
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
    Private Sub Finaciero_ReportViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim x As String = ReportViewer1.LocalReport.ReportEmbeddedResource
        Dim datasource As ReportDataSource = New ReportDataSource(_tableName, _DtGeneric)
        ReportViewer1.LocalReport.DataSources.Add(datasource)
        ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
        ReportViewer1.LocalReport.ReportEmbeddedResource = _ReportName
        ReportViewer1.LocalReport.EnableExternalImages = True
        Dim imagePath As String = New Uri(_CompanyLogo).AbsoluteUri
        Dim parameter As New ReportParameter("pathLogo", imagePath)
        ReportViewer1.LocalReport.SetParameters(parameter)

        Dim parm = New ReportParameter()
        'parm = (New ReportParameter("path", "C:\Users\epdsoft6\Pictures\cartonhuevos.png", True))
        'Me.ReportViewer1.LocalReport.SetParameters(parm)
        parm = (New ReportParameter("CompanyName", _CompanyName, True))
        Me.ReportViewer1.LocalReport.SetParameters(parm)

        parm = (New ReportParameter("HeaderColor", _HeaderReportColor, True))
        Me.ReportViewer1.LocalReport.SetParameters(parm)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class