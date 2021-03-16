Public Class ERP_CuentasPorCobrar_PagosMensuales

	Property ID_Customer As Long = 0
	Private _DT_Pagos As New DataTable
	Private Mes As Integer = 0
	Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
		Me.Close()
	End Sub

	Private Sub cmdNext_Click(sender As Object, e As EventArgs) Handles cmdNext.Click
		Mes = dtpFecha.Value.ToString("yyyyMM")
		Using objsql As New Financiero_SQLServer
			_DT_Pagos = objsql.ERP_Finance_MonthlyPayments(Mes, ID_Customer)
		End Using
		dgvPagos.DataSource = _DT_Pagos
	End Sub

	Private Sub ERP_CuentasPorCobrar_PagosMensuales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		dgvPagos.AutoGenerateColumns = False
	End Sub

    Private Sub cmdPrint_Click(sender As Object, e As EventArgs) Handles cmdPrint.Click
        If Not dgvPagos.CurrentRow Is Nothing Then
            Dim dt As New DataTable
            Dim Id_AccountReceivableListDetails As Long = dgvPagos.CurrentRow.Cells("Id_AccountReceivableListDetails_FK").Value
            Dim fecha As Date = dgvPagos.CurrentRow.Cells("paymentDate").Value
            Using objsql As New Financiero_SQLServer
                If dgvPagos.CurrentRow.Cells("IS_Partial").Value Then
                    dt = objsql.ERP_Finance_Report_Payments(_ID_Company, 0, ID_Customer, fecha, 0)
                    If dt.Rows.Count > 0 Then
                        Using objPartidaContable As New Financiero_ReportViewer(dt, "DataReport", "epd_SatelliteERP.Reporte_PagosParciales.rdlc")
                            objPartidaContable.ShowDialog()
                        End Using
                    End If
                Else
                    dt = objsql.ERP_Finance_Report_Payments(_ID_Company, Id_AccountReceivableListDetails, ID_Customer, Now.Date, 1)
                    If dt.Rows.Count > 0 Then
                        Using objPartidaContable As New Financiero_ReportViewer(dt, "DataPago", "epd_SatelliteERP.Reporte_ComprobantePagoCopia.rdlc")
                            objPartidaContable.ShowDialog()
                        End Using
                    End If
                End If
            End Using

        End If
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