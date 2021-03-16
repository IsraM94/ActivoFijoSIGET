Imports Microsoft.Reporting.WinForms

Public Class Production_Resumen
	Private _dt As New DataTable
    Public Property ID_Lot As Long = 0

    Public Property ID_Process As Long = 0

    Public Property ID_Hours As Long = 0

    Public Property TipoReport As String = 0
    Private dt1 As DataTable

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub

    Private Sub Production_Resumen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rpActividades.ShowToolBar = False
        Dim ds As New EPD_SatelliteERPDataSet2


        Dim da As New EPD_SatelliteERPDataSet2TableAdapters.SP_Report_ScheduledGeneralTableAdapter
            da.Fill(ds.SP_Report_ScheduledGeneral, ID_Lot, ID_Process, ID_Hours)


            REM dt1 = ds.Tables("SP_Report_Scheduled")
            rpActividades.LocalReport.ReportEmbeddedResource = "epd_SatelliteERP.Operaciones_Report_ScheduledGeneral.rdlc"
        REM dt.Fill(Ds.SP_Report_ScheduledGeneral, ID_Lot, ID_Process, ID_Hours)

        dt1 = ds.Tables("SP_Report_ScheduledGeneral")

        Dim datasource As ReportDataSource = New ReportDataSource("ScheduledGeneral", dt1)
        rpActividades.LocalReport.EnableExternalImages = True
        Dim imagePath As String = New Uri(_CompanyLogo).AbsoluteUri
        Dim parameter As New ReportParameter("pathLogo", imagePath)
        rpActividades.LocalReport.SetParameters(parameter)

        Dim parm = New ReportParameter()
        'parm = (New ReportParameter("path", "C:\Users\epdsoft6\Pictures\cartonhuevos.png", True))
        'Me.ReportViewer1.LocalReport.SetParameters(parm)
        parm = (New ReportParameter("CompanyName", _CompanyName, True))
        rpActividades.LocalReport.SetParameters(parm)
        parm = (New ReportParameter("HeaderColor", _HeaderReportColor, True))
        rpActividades.LocalReport.SetParameters(parm)
        rpActividades.LocalReport.DataSources.Add(datasource)
            Me.rpActividades.RefreshReport()


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Using obj As New Operaciones_SQLServer
            For Each row As DataRow In dt1.Rows
                obj.ERP_Prod_ConsumptionFlowproducts_add(row("id_Production"), row("Id_ProcessCurrent"), row("id_Product"), ID_Hours, row("TotalSalidaProducto"))
            Next
        End Using
        rpActividades.PrintDialog()
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