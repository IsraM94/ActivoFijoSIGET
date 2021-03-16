Imports System.IO

Public Class ModuloCuentasPorPagar
    Private objFinance As New Financiero_SQLServer
    Private objGeneric As New Generic_SQLServer
    Private _tableConfigBilling As DataTable
    Private _tableInvoiceHeader As DataTable
    Private _tableCustomer As DataTable
    Private _tableCustomerBalanceDue As DataTable
    Private _IsFacturacion As Boolean = False
    Private Sub tcMain_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tcMain.SelectedIndexChanged
        If sender.SelectedTab.Name = "CuentasActivas" Then
            GetClientes()
        ElseIf sender.SelectedTab.Name = "ClientesMora" Then
            GetClientesMora()
        ElseIf sender.SelectedTab.Name = "DocumentType" Then
            GetCreditDocument()
        ElseIf sender.SelectedTab.Name = "GraficosFacturacion" Then
            With Me.Financiero_GraficoFacturacion1

            End With

            'Dim areas1 As ChartArea = Me.Financiero_GraficoFacturacion1.ChartAreas.Add("Areas1")

            'With areas1
            'End With

            'Dim series1 As Series = Me.Financiero_GraficoFacturacion1.Series.Add("Series1")

            'With series1
            '    .ChartArea = areas1.Name
            '    .ChartType = SeriesChartType.Pie
            '    .Points.AddXY("Online", 60)
            '    .Points.AddXY("Offline", 40)
            'End With

            'Dim legends1 As Legend = Me.chrtRegisterAvailability.Legends.Add("Legends1")
        End If







    End Sub
    Private Sub GetClientesMora()
        _tableCustomerBalanceDue = objGeneric.GetListAccountsPayableBalanceDue(Data_Id_Company)
        DGV_CustomMora.AutoGenerateColumns = False
        DGV_CustomMora.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
        DGV_CustomMora.Font = New Font("Segoe UI", 11)
        DGV_CustomMora.Columns(0).Width = 100
        DGV_CustomMora.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DGV_CustomMora.Columns(1).Width = 250
        DGV_CustomMora.Columns(2).Width = 200
        DGV_CustomMora.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DGV_CustomMora.Columns(3).DefaultCellStyle.Format = "c"
        DGV_CustomMora.Columns(3).Width = 120
        DGV_CustomMora.Columns(4).Width = 120
        DGV_CustomMora.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        DGV_CustomMora.Columns(5).Width = 120
        DGV_CustomMora.Columns(6).Width = 120
        DGV_CustomMora.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        DGV_CustomMora.Columns(7).Width = 120
        DGV_CustomMora.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DGV_CustomMora.Columns(7).DefaultCellStyle.Format = "c"

        DGV_CustomMora.Columns(8).Width = 120
        DGV_CustomMora.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DGV_CustomMora.Columns(8).DefaultCellStyle.Format = "c"

        DGV_CustomMora.Columns(9).Width = 120
        DGV_CustomMora.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DGV_CustomMora.Columns(9).DefaultCellStyle.Format = "c"

        DGV_CustomMora.Columns(10).Width = 120
        DGV_CustomMora.Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DGV_CustomMora.Columns(10).DefaultCellStyle.Format = "c"

        DGV_CustomMora.ReadOnly = True
        DGV_CustomMora.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DGV_CustomMora.MultiSelect = False

        DGV_CustomMora.AllowUserToResizeColumns = False
        DGV_CustomMora.AllowUserToAddRows = False
        DGV_CustomMora.AllowUserToDeleteRows = False
        DGV_CustomMora.DataSource = _tableCustomerBalanceDue

    End Sub
    Private Sub GetClientes()
        _tableCustomer = objGeneric.GetCustomerClientList(Data_Id_Company, -1, -1, -1, 1)
        DGVClientes.AutoGenerateColumns = False
        DGVClientes.Font = New Font("Segoe UI", 11)
        DGVClientes.Columns(0).Width = 120
        DGVClientes.Columns(1).Width = 120
        DGVClientes.Columns(2).Width = 250
        DGVClientes.Columns(3).Width = 300
        DGVClientes.Columns(4).Width = 300
        DGVClientes.Columns(5).Width = 120
        DGVClientes.Columns(6).Width = 250
        DGVClientes.ReadOnly = True
        DGVClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DGVClientes.MultiSelect = False
        DGVClientes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
        DGVClientes.AllowUserToResizeColumns = False
        DGVClientes.AllowUserToAddRows = False
        DGVClientes.AllowUserToDeleteRows = False
        DGVClientes.DataSource = _tableInvoiceHeader

        DGVClientes.DataSource = _tableCustomer
    End Sub

    Private Sub GetCreditDocument()
        _tableCustomer = objGeneric.ERP_AR_GetCreditDocument(Data_Id_Company)
        dgvDocumentType.AutoGenerateColumns = False
        dgvDocumentType.Font = New Font("Segoe UI", 11)
        dgvDocumentType.Columns(0).Width = 120
        dgvDocumentType.Columns(1).Width = 120
        dgvDocumentType.Columns(2).Width = 250
        dgvDocumentType.Columns(3).Width = 300
        dgvDocumentType.Columns(4).Width = 300
        dgvDocumentType.Columns(5).Width = 120
        dgvDocumentType.Columns(6).Width = 250
        dgvDocumentType.ReadOnly = True
        dgvDocumentType.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvDocumentType.MultiSelect = False
        dgvDocumentType.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
        dgvDocumentType.AllowUserToResizeColumns = False
        dgvDocumentType.AllowUserToAddRows = False
        dgvDocumentType.AllowUserToDeleteRows = False
        dgvDocumentType.DataSource = _tableInvoiceHeader

        dgvDocumentType.DataSource = _tableCustomer
    End Sub


    Sub New(ByVal IsFacturacion As Boolean)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        If IsFacturacion Then
            tcMain.TabPages.Remove(tcMain.TabPages.Item(0))
            tcMain.TabPages.Remove(tcMain.TabPages.Item(1))
            tcMain.TabPages.Remove(tcMain.TabPages.Item(1))
            tcMain.TabPages.Remove(tcMain.TabPages.Item(1))
            tcMain.TabPages.Remove(tcMain.TabPages.Item(1))
            tcMain.TabPages.Remove(tcMain.TabPages.Item(1))
            _IsFacturacion = IsFacturacion
        End If
    End Sub
    Dim WithEvents obj As New calendar
    Private Sub ModuloCuentasPorCobrar_Load(sender As Object, e As EventArgs) Handles Me.Load

        obj.OpcionCuenta = ERP_Calendar.TipoCuenta.Cuenta_pagar

        flpCalendar.Controls.Add(obj)
        flpCalendar.Dock = DockStyle.Fill
    End Sub
    Sub EClass_EventHandler(ByVal respPago As DialogResult) Handles obj.EventCalendar
        REM obj = New calendar
        obj.OpcionCuenta = ERP_Calendar.TipoCuenta.Cuenta_pagar

        flpCalendar.Controls.Add(obj)
        flpCalendar.Dock = DockStyle.Fill

    End Sub
    Private Sub cmdReporteCatalogoCliente_Click(sender As Object, e As EventArgs) Handles cmdReporteCatalogoCliente.Click
        Dim Ds As New EPD_SatelliteERPDataSet_Inventario
        Dim dt As New EPD_SatelliteERPDataSet_InventarioTableAdapters.ERP_SP_Inventory_Report_CatalogCustomersTableAdapter
        Dim dt1 As DataTable
        dt.Fill(Ds.ERP_SP_Inventory_Report_CatalogCustomers)
        dt1 = Ds.Tables(0)
        Using objPartidaContable As New Financiero_ReportViewer(dt1, "CatalogoClientes", "epd_SatelliteERP.Inventario_CatalogClientes.rdlc")
            objPartidaContable.ShowDialog()
        End Using
    End Sub

    Private Sub cmdCatalogoClienteFinanciero_Click(sender As Object, e As EventArgs) Handles cmdCatalogoClienteFinanciero.Click
        Dim dt As New DataTable
        Using objsql As New Financiero_SQLServer
            dt = objsql.ERP_SP_Inventory_Report_CatalogueFinancialCustomers
        End Using
        Using objPartidaContable As New Financiero_ReportViewer(dt, "Data", "epd_SatelliteERP.Reporte_CatalogoFinanciero.rdlc")
            objPartidaContable.ShowDialog()
        End Using

    End Sub

    Private Sub cmdFichaCliente_Click(sender As Object, e As EventArgs) Handles cmdFichaCliente.Click
        Dim Ds As New EPD_SatelliteERPDataSet_Inventario
        Dim dt As New EPD_SatelliteERPDataSet_InventarioTableAdapters.ERP_SP_Inventory_Report_Report_CustomerCardTableAdapter
        Dim dt1 As DataTable
        dt.Fill(Ds.ERP_SP_Inventory_Report_Report_CustomerCard)
        dt1 = Ds.Tables("ERP_SP_Inventory_Report_Report_CustomerCard")
        Using objPartidaContable As New Financiero_ReportViewer(dt1, "DatosCliente", "epd_SatelliteERP.Inventario_CatalogClienteCard.rdlc")
            objPartidaContable.ShowDialog()
        End Using
    End Sub

    Private Sub cmdReportPayableAccount_Click(sender As Object, e As EventArgs) Handles cmdReportPayableAccounts.Click
        Using Objcreate As New ERP_Finance_ReportsPayableAccountsfilter
            Objcreate.ShowDialog()
        End Using
    End Sub

    Private Sub cmdCrearCliente_Click(sender As Object, e As EventArgs) Handles cmdCrearCliente.Click
        Using Objcreate As New ERP_ClientesCuentasPorCobrar
            Objcreate.TipoConsulta = ERP_ClientesCuentasPorCobrar.Proceso.Clientes
            Objcreate.OpcionSeleccionada = ERP_ClientesCuentasPorCobrar.Funcion.Agregar
            If Objcreate.ShowDialog() = DialogResult.OK Then
                GetClientes()
            End If
        End Using
    End Sub

    Private Sub cmdModificarCliente_Click(sender As Object, e As EventArgs) Handles cmdModificarCliente.Click
        Using ObjUpdate As New ERP_ClientesCuentasPorCobrar
            ObjUpdate.TipoConsulta = ERP_ClientesCuentasPorCobrar.Proceso.Clientes
            ObjUpdate.OpcionSeleccionada = ERP_ClientesCuentasPorCobrar.Funcion.Actualizar
            For Each row As DataRow In _tableCustomer.Select("Id_Customer=" & DGVClientes.CurrentRow.Cells(0).Value)
                ObjUpdate.IsBigContributter = row("Is_BigContributor")
                ObjUpdate.Id_Customer = row("Id_Customer")
                ObjUpdate.id_Company = row("id_Company_FK")
                ObjUpdate.Id_TypeCustomer_FK = row("Id_TypeCustomer_FK")
                ObjUpdate.Id_Minicipality_FK = row("Id_Minicipality_FK")
                ObjUpdate.Id_EmployeelContact_FK = row("Id_EmployeelContact_FK")
                ObjUpdate.Id_CompanyCategory_Fk = row("Id_CompanyCategory_Fk")
                ObjUpdate.Is_Exempt = row("Is_Exempt")
                ObjUpdate.Is_LegalEntity = row("Is_LegalEntity")
                ObjUpdate.Business_Name = row("Business_Name")
                ObjUpdate.Commercial_Name = row("Commercial_Name")
                ObjUpdate.First_Name = row("First_Name")
                ObjUpdate.Last_Name = row("Last_Name")
                ObjUpdate.Address = row("Address")
                ObjUpdate.OfficePhone = row("OfficePhone")
                ObjUpdate.Email_Contact = row("Email_Contact")
                ObjUpdate.Identity_DocumentNumber = row("Identity_DocumentNumber")
                ObjUpdate.Tax_Registration_Number = row("Tax_Registration_Number")
                ObjUpdate.Tax_Identification_Number = row("Tax_Identification_Number")
                ObjUpdate.Turning_Company = row("Turning_Company")
                ObjUpdate.Company_Category = row("ID_CompanyCategory_FK")
                ObjUpdate.Turning_Company = row("Turning_Company")
                ObjUpdate.Company_Category = row("Company_Category")
                ObjUpdate.Is_Supplier = row("Is_supplier")
            Next
            If ObjUpdate.ShowDialog() = DialogResult.OK Then
                GetClientes()
            End If
        End Using
    End Sub

    Private Sub cmdAgregarCobro_Click(sender As Object, e As EventArgs) Handles cmdAgregarCxC.Click
        'Cuenta por pagar
        Using objPago As New ERP_CPC_AgregarCobro(DGVClientes.CurrentRow.Cells(0).Value)
            objPago.Id_Customer = DGVClientes.CurrentRow.Cells(0).Value
            Try
                objPago.ShowDialog()
            Catch ex As Exception

            End Try

        End Using
    End Sub

    Private Sub cmdCuentaCxP_AgregarCobro_Click(sender As Object, e As EventArgs) Handles cmdCuentaCxC_AgregarCobro.Click
        REM Agregar pago de cuenta por pagar
        Using objPago As New ERP_CuentasPorPagar_AgregarCobro
            For Each row As DataRow In _tableCustomer.Rows
                If DGVClientes.CurrentRow.Cells(0).Value = row("ID_Customer") Then
                    objPago.Id_Customer = row("ID_Customer")
                    Exit For
                End If
            Next
            objPago.ShowDialog()

        End Using
        reloadcalendar()
    End Sub

    Private Sub cmdCuotaClienteMora_Click(sender As Object, e As EventArgs) Handles cmdCuotaClienteMora.Click
        Using objCobro As New ERP_CuentasPorPagar_AgregarCobro
            For Each row As DataRow In _tableCustomerBalanceDue.Rows
                If DGV_CustomMora.CurrentRow.Cells(0).Value = row("ID_AccountsList") Then
                    objCobro.Id_Customer = row("ID_Customer")
                    objCobro._IsDue = True
                    objCobro._Id_PayDue = row("ID_AccountsList")
                    Exit For
                End If
            Next
            If objCobro.ShowDialog() = DialogResult.OK Then
                GetClientesMora()
            End If

        End Using
        reloadcalendar()
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Using obj As New ERP_Calendar
            obj.OpcionCuenta = ERP_Calendar.TipoCuenta.Cuenta_pagar
            obj.ShowDialog()
        End Using
    End Sub

    Public Sub reloadcalendar()
        Dim obj As New calendar
        obj.OpcionCuenta = ERP_Calendar.TipoCuenta.Cuenta_pagar
        flpCalendar.Controls.Clear()
        flpCalendar.Controls.Add(obj)
        flpCalendar.Dock = DockStyle.Fill
    End Sub

	Private Sub cmdCuentasActivasPagosRealizados_Click(sender As Object, e As EventArgs) Handles cmdCuentasActivasPagosRealizados.Click
		If Not DGVClientes.CurrentRow Is Nothing Then
			Dim ID_Cliente As Long = DGVClientes.CurrentRow.Cells(0).Value
			Using objFechas As New ERP_CuentasPorCobrar_DialogFechasSelect
				If objFechas.ShowDialog = DialogResult.OK Then
					Dim dt As New DataTable
					Using objSQL As New Financiero_SQLServer
						dt = objSQL.ERP_AP_Report_PaymentsCompleted(ID_Cliente, 1, objFechas.FechaInicial, objFechas.FechaFinal)
					End Using
					' dt1 = Ds.Tables("ERP_SP_Inventory_Report_AccountStatus")
					Using obj As New Financiero_ReportViewer(dt, "DataSet1", "epd_SatelliteERP.Report_PaymentsCompleted.rdlc")
						obj.WindowState = FormWindowState.Maximized
						obj.ShowDialog()
					End Using
				End If
			End Using
		End If
	End Sub

	Private Sub cmdCuentasActivasPagosRealizadosCliente_Click(sender As Object, e As EventArgs) Handles cmdCuentasActivasPagosRealizadosCliente.Click
		If Not DGVClientes.CurrentRow Is Nothing Then
			Dim ID_Cliente As Long = DGVClientes.CurrentRow.Cells("ID_Customer_FK").Value
			Using objFechas As New ERP_CuentasPorCobrar_DialogFechasSelect
				If objFechas.ShowDialog = DialogResult.OK Then
					Dim dt As New DataTable
					Using objSQL As New Financiero_SQLServer
						dt = objSQL.ERP_AP_Report_PaymentsCompleted(ID_Cliente, 2, objFechas.FechaInicial, objFechas.FechaFinal)
					End Using
					' dt1 = Ds.Tables("ERP_SP_Inventory_Report_AccountStatus")
					Using obj As New Financiero_ReportViewer(dt, "DataSet1", "epd_SatelliteERP.Report_PaymentsCompleted.rdlc")
						obj.WindowState = FormWindowState.Maximized
						obj.ShowDialog()
					End Using
				End If
			End Using
		End If
	End Sub

	Private Sub cmdCuentasActivasPagosVencidos_Click(sender As Object, e As EventArgs) Handles cmdCuentasActivasPagosVencidos.Click
		If Not DGVClientes.CurrentRow Is Nothing Then
			Dim ID_Cliente As Long = DGVClientes.CurrentRow.Cells("ID_Customer_FK").Value

			Dim dt As New DataTable
			Using objSQL As New Financiero_SQLServer
				dt = objSQL.ERP_AP_Report_PendingPayments(ID_Cliente, 1)
			End Using
			Using obj As New Financiero_ReportViewer(dt, "data", "epd_SatelliteERP.Report_PendingPayments.rdlc")
				obj.WindowState = FormWindowState.Maximized
				obj.ShowDialog()
			End Using
		End If
	End Sub

	Private Sub cmdCuentasActivasPagosVencidosCliente_Click(sender As Object, e As EventArgs) Handles cmdCuentasActivasPagosVencidosCliente.Click
		If Not DGVClientes.CurrentRow Is Nothing Then
			Dim ID_Cliente As Long = DGVClientes.CurrentRow.Cells("ID_Customer_FK").Value

			Dim dt As New DataTable
			Using objSQL As New Financiero_SQLServer
				dt = objSQL.ERP_AP_Report_PendingPayments(ID_Cliente, 2)
			End Using
			Using obj As New Financiero_ReportViewer(dt, "data", "epd_SatelliteERP.Report_PendingPayments.rdlc")
				obj.WindowState = FormWindowState.Maximized
				obj.ShowDialog()
			End Using
		End If
	End Sub

	Private Sub cmdCuentasActivasPagosProximos_Click(sender As Object, e As EventArgs) Handles cmdCuentasActivasPagosProximos.Click
		If Not DGVClientes.CurrentRow Is Nothing Then
			Dim ID_Cliente As Long = DGVClientes.CurrentRow.Cells("ID_Customer_FK").Value

			Dim dt As New DataTable
			Using objSQL As New Financiero_SQLServer
				dt = objSQL.ERP_AP_Report_PendingPayments(ID_Cliente, 3)
			End Using
			Using obj As New Financiero_ReportViewer(dt, "data", "epd_SatelliteERP.Report_FuturePayments.rdlc")
				obj.WindowState = FormWindowState.Maximized
				obj.ShowDialog()
			End Using
		End If
	End Sub

	Private Sub cmdCuentasActivasPagosCliente_Click(sender As Object, e As EventArgs) Handles cmdCuentasActivasPagosCliente.Click
		If Not DGVClientes.CurrentRow Is Nothing Then
			Dim ID_Cliente As Long = DGVClientes.CurrentRow.Cells("ID_Customer_FK").Value

			Dim dt As New DataTable
			Using objSQL As New Financiero_SQLServer
				dt = objSQL.ERP_AP_Report_PendingPayments(ID_Cliente, 4)
			End Using
			Using obj As New Financiero_ReportViewer(dt, "data", "epd_SatelliteERP.Report_FuturePayments.rdlc")
				obj.WindowState = FormWindowState.Maximized
				obj.ShowDialog()
			End Using
		End If
	End Sub

    Private Sub btnCrearTipoDocumento_Click(sender As Object, e As EventArgs) Handles btnCrearTipoDocumento.Click
        Using objAdd As New ERP_GenericCreditDocument
            objAdd.Id_Company_FK = _ID_Company
            objAdd.id_DocumentType = 0
            If objAdd.ShowDialog() = DialogResult.OK Then
                GetCreditDocument()
            End If
        End Using
    End Sub

    Private Sub btnActualizarTipoDocumento_Click(sender As Object, e As EventArgs) Handles btnActualizarTipoDocumento.Click
        Using objAdd As New ERP_GenericCreditDocument
            objAdd.GbClientes.Text = "Modificar Tipo de Documento"
            objAdd.Id_Company_FK = _ID_Company
            objAdd.id_CreditDocument = dgvDocumentType.CurrentRow.Cells("ID_CreditDocument").Value
            objAdd.Name_CreditDocument = dgvDocumentType.CurrentRow.Cells("Description").Value
            objAdd.is_invoice = dgvDocumentType.CurrentRow.Cells("Is_Invoice").Value
            If objAdd.ShowDialog() = DialogResult.OK Then
                GetCreditDocument()
            End If
        End Using
    End Sub

    Private Sub btnEliminarTipoDocumento_Click(sender As Object, e As EventArgs) Handles btnEliminarTipoDocumento.Click
        If Not dgvDocumentType.CurrentRow Is Nothing Then
            Dim ID_CustomerType As Long = dgvDocumentType.CurrentRow.Cells("ID_CreditDocument").Value
            Dim NameOutletCatalog As String = dgvDocumentType.CurrentRow.Cells("Description").Value
            Dim resp As String = ""
            If MessageBox.Show("¿Está seguro que desea eliminar el Tipo de Proveedor: " & NameOutletCatalog & "?", "Información", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
                Using objDelete As New Generic_SQLServer
                    resp = objDelete.ERP_AR_DelCreditDocument(ID_CustomerType, _ID_Company)
                End Using
                If resp = "OK" Then
                    MessageBox.Show("Registro eliminado exitosamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    GetCreditDocument()
                Else
                    MessageBox.Show("Ocurrió un error al eliminar el Tipo de Proveedor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        End If
    End Sub

    Private Sub FlowLayoutPanel5_Paint(sender As Object, e As PaintEventArgs) Handles FlowLayoutPanel5.Paint

    End Sub
End Class
