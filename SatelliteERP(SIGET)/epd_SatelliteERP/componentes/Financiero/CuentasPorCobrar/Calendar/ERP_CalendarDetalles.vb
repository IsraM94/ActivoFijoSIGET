Public Class ERP_CalendarDetalles

    Property Fecha As Date = Nothing
    Property DetalleTipo As New Tipoconsulta
	Private _DT_Cuotas As New DataTable
	Enum Tipoconsulta
        Detalles_Cuenta_Cobrar
        Detalles_Cuenta_Pagar
    End Enum

    Private Sub ERP_CalendarDetalles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblFecha.Text = Fecha
        dgvClientes.AutoGenerateColumns = False
        dgvClientes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
        dgvClientes.Font = New Font("Segoe UI", 11)
        dgvClientes.RowHeadersVisible = False
        dgvClientes.Columns(0).Width = 100
        dgvClientes.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvClientes.Columns(1).Width = 500
        dgvClientes.Columns(2).Width = 200
        dgvClientes.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvClientes.Columns(3).DefaultCellStyle.Format = "c"
        dgvClientes.Columns(3).Width = 120
        dgvClientes.Columns(4).Width = 120


        dgvClientes.Columns(6).Width = 120
        dgvClientes.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvClientes.Columns(5).Width = 120



        dgvClientes.ReadOnly = True
        dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvClientes.MultiSelect = False

        dgvClientes.AllowUserToResizeColumns = False
        dgvClientes.AllowUserToAddRows = False
        dgvClientes.AllowUserToDeleteRows = False
        Select Case DetalleTipo
            Case Tipoconsulta.Detalles_Cuenta_Cobrar
                GbDetallesCPC.Text = "Cuentas por Cobrar"
                FilldgvAccountsReceivable()
            Case Tipoconsulta.Detalles_Cuenta_Pagar
                GbDetallesCPC.Text = "Cuentas por Pagar"
                FilldgvAccountsPayable()
        End Select

    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub

#Region "FillDGV"

    Private Sub FilldgvAccountsReceivable()
		dgvClientes.Columns("ID_AccountsPayableDetails").Visible = False
		Try
            Using objsql As New Generic_SQLServer
                _DT_Cuotas = objsql.GetQuotasdaysAccountReceivable(Data_Id_Company, Fecha)
            End Using
            If _DT_Cuotas.Rows.Count = 0 Then
                Close()
            End If

            If _DT_Cuotas IsNot Nothing Then
				dgvClientes.DataSource = _DT_Cuotas
			End If
		Catch ex As ArgumentException
            Using objLog As New ProcessGeneral
                objLog.AlmacenarLog(5, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
            End Using
        Catch ex As Exception
            Using objLog As New ProcessGeneral
                objLog.AlmacenarLog(5, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
            End Using
        End Try
    End Sub

    Private Sub FilldgvAccountsPayable()
        dgvClientes.Columns("ID_AccountsDetails").Visible = False

		Try
            Using objsql As New Generic_SQLServer
                _DT_Cuotas = objsql.GetQuotasdaysAccountPayable(Data_Id_Company, Fecha)
            End Using
            If _DT_Cuotas.Rows.Count = 0 Then
                Close()
            End If
            If _DT_Cuotas IsNot Nothing Then
				dgvClientes.DataSource = _DT_Cuotas
			End If
		Catch ex As ArgumentException
            Using objLog As New ProcessGeneral
                objLog.AlmacenarLog(5, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
            End Using
        Catch ex As Exception
            Using objLog As New ProcessGeneral
                objLog.AlmacenarLog(5, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
            End Using
        End Try
    End Sub


#End Region


	Private Sub cmdReporte_Click(sender As Object, e As EventArgs)
		'Using objReport As New PlantillaReporte("ERP_AR_GetQuotasbydayTableAdapter")
		'    objReport.FechaReport = _Fecha
		'    objReport.ShowDialog()
		'End Using
	End Sub

    Private Sub cmdPagar_Click(sender As Object, e As EventArgs) Handles cmdPagar.Click
        If Not dgvClientes.CurrentRow Is Nothing Then
            Dim ID_Cuenta As Long = dgvClientes.CurrentRow.Cells("ID_AccountsList").Value
            Dim ID_Cuota As Long = dgvClientes.CurrentRow.Cells("QuotaNumber").Value
            Dim ID_Cliente As Long = dgvClientes.CurrentRow.Cells("Id_Customer").Value

            'Select Case DetalleTipo
            '    Case Tipoconsulta.Detalles_Cuenta_Cobrar
            '        Using objPago As New ERP_CuentasPorCobrar_AgregarCobro
            '            objPago.IS_Calendar = True
            '            objPago.ID_Cuenta = ID_Cuenta
            '            objPago.ID_Cuota = ID_Cuota
            '            objPago.Id_Customer = ID_Cliente
            '            objPago.ShowDialog()
            '        End Using
            '    Case Tipoconsulta.Detalles_Cuenta_Pagar
            '        Using objPago As New ERP_CuentasPorPagar_AgregarCobro
            '            objPago.IS_Calendar = True
            '            objPago.ID_Cuenta = ID_Cuenta
            '            objPago.ID_Cuota = ID_Cuota
            '            objPago.Id_Customer = ID_Cliente
            '            objPago.ShowDialog()
            '        End Using
            'End Select
        End If
        Me.DialogResult = DialogResult.OK
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