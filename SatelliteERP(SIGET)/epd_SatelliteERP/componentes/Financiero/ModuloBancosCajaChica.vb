Imports System.IO

Public Class ModuloBancosCajaChica
    Private objFinance As New Financiero_SQLServer
    Private objGeneric As New Generic_SQLServer
    Private _tableConfigBilling As DataTable
    Private _tableInvoiceHeader As DataTable
    Private _tableCustomer As DataTable
    Private _tableCustomerBalanceDue As DataTable
    Private _IsFacturacion As Boolean = False
    Private ConfigXML As String
    Private SchemaXML As String
    Private ConfigXMLa As New DataSet
    Private SchemaXMLa As New DataSet



    Private Sub tcMain_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tcMain.SelectedIndexChanged
        If sender.SelectedTab.Name = "saldoBancos" Then
            GetSaldoBancos()
        ElseIf sender.SelectedTab.Name = "Movimientos" Then
            GetMovimientosBancos()
        ElseIf sender.SelectedTab.Name = "SaldosCajaChica" Then
            GetSaldoCajaChica()
        ElseIf sender.SelectedTab.Name = "MovimientosCajaChica" Then
            GetMovimientosCajaChica()
        ElseIf sender.selectedtab.name = "ConfiguraciondeCheques" Then

        End If
    End Sub
    Sub New(is_bank As Boolean)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        If (is_bank) Then
            SaldosCajaChica.Parent = Nothing
            MovimientosCajaChica.Parent = Nothing
        Else
            saldoBancos.Parent = Nothing
            Movimientos.Parent = Nothing
            Cheques.Parent = Nothing
        End If

    End Sub
    Private Sub GetSaldoBancos()
        _tableCustomerBalanceDue = objGeneric.ERP_Finance_SelectBankBalance(Data_Id_Company, 0)
        DG_Bank.AutoGenerateColumns = False
        DG_Bank.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
        DG_Bank.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.NotSet
        DG_Bank.Font = New Font("Segoe UI", 11)
        DG_Bank.Columns(0).Width = 100
        DG_Bank.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DG_Bank.Columns(1).Width = 350
        DG_Bank.Columns(2).Width = 200
        DG_Bank.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DG_Bank.Columns(2).DefaultCellStyle.Format = "C"

        DG_Bank.Columns(3).Width = 250
        DG_Bank.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        DG_Bank.ReadOnly = True
        DG_Bank.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DG_Bank.MultiSelect = False

        DG_Bank.AllowUserToResizeColumns = False
        DG_Bank.AllowUserToAddRows = False
        DG_Bank.AllowUserToDeleteRows = False
        DG_Bank.DataSource = _tableCustomerBalanceDue

    End Sub
    Private Sub GetMovimientosBancos()
        _tableCustomerBalanceDue = objGeneric.ERP_Finance_SelectBankMovements(Data_Id_Company)
        DG_MovementBank.AutoGenerateColumns = False
        DG_MovementBank.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.NotSet
        DG_MovementBank.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
        DG_MovementBank.Font = New Font("Segoe UI", 11)
        DG_MovementBank.Columns(0).Width = 100
        DG_MovementBank.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DG_MovementBank.Columns(1).Width = 500
        DG_MovementBank.Columns(2).Width = 200
        DG_MovementBank.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DG_MovementBank.Columns(3).DefaultCellStyle.Format = "c"
        DG_MovementBank.Columns(3).Width = 250

        DG_MovementBank.ReadOnly = True
        DG_MovementBank.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DG_MovementBank.MultiSelect = False

        DG_MovementBank.AllowUserToResizeColumns = False
        DG_MovementBank.AllowUserToAddRows = False
        DG_MovementBank.AllowUserToDeleteRows = False
        DG_MovementBank.DataSource = _tableCustomerBalanceDue

    End Sub

    Private Sub GetSaldoCajaChica()
        _tableCustomerBalanceDue = objGeneric.ERP_Finance_SelectBankBalance(Data_Id_Company, 1)
        DGVCajaChica.AutoGenerateColumns = False
        DGVCajaChica.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
        DGVCajaChica.Font = New Font("Segoe UI", 11)
        DGVCajaChica.Columns(0).Width = 100
        DGVCajaChica.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DGVCajaChica.Columns(1).Width = 350
        DGVCajaChica.Columns(2).DefaultCellStyle.Format = "C"
        DGVCajaChica.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DGVCajaChica.Columns(2).Width = 200

        DGVCajaChica.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DGVCajaChica.Columns(3).Width = 250
        DGVCajaChica.Columns(3).Width = 250

        DGVCajaChica.ReadOnly = True
        DGVCajaChica.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DGVCajaChica.MultiSelect = False

        DGVCajaChica.AllowUserToResizeColumns = False
        DGVCajaChica.AllowUserToAddRows = False
        DGVCajaChica.AllowUserToDeleteRows = False
        DGVCajaChica.DataSource = _tableCustomerBalanceDue

    End Sub

    Private Sub GetMovimientosCajaChica()
        _tableCustomerBalanceDue = objGeneric.ERP_Finance_MovementsSelectPettyCash(Data_Id_Company)
        DGVMovementPettyCash.AutoGenerateColumns = False
        DGVMovementPettyCash.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
        DGVMovementPettyCash.Font = New Font("Segoe UI", 11)
        DGVMovementPettyCash.Columns(0).Width = 100
        DGVMovementPettyCash.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DGVMovementPettyCash.Columns(1).Width = 250
        DGVMovementPettyCash.Columns(2).Width = 200
        DGVMovementPettyCash.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DGVMovementPettyCash.Columns(3).DefaultCellStyle.Format = "C"
        DGVMovementPettyCash.Columns(3).Width = 350

        DGVMovementPettyCash.ReadOnly = True
        DGVMovementPettyCash.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DGVMovementPettyCash.MultiSelect = False

        DGVMovementPettyCash.AllowUserToResizeColumns = False
        DGVMovementPettyCash.AllowUserToAddRows = False
        DGVMovementPettyCash.AllowUserToDeleteRows = False
        DGVMovementPettyCash.DataSource = _tableCustomerBalanceDue

    End Sub

    Private Sub cmd_ConfigCheque_Config_Click(sender As Object, e As EventArgs) Handles cmd_ConfigCheque_Config.Click
        Dim _Id_row As Integer
        Using obj As New ERP_Bank_Research
            obj.StartPosition = FormStartPosition.CenterParent
            If obj.ShowDialog() = DialogResult.OK Then
                _Id_row = obj.rowSelection
                Panel_ConfiguracionCheque.Controls.Clear()
                _tableConfigBilling = objFinance.GetConfigCheck_Select(Data_Id_Company, _Id_row)

                If _tableConfigBilling.Rows.Count > 0 Then
                    Dim ds As New DataSet

                    Dim xmlDatos As System.IO.StringReader = New System.IO.StringReader(_tableConfigBilling.Rows(0)("Config_XML"))
                    Dim xmlSchema As System.IO.StringReader = New System.IO.StringReader(_tableConfigBilling.Rows(0)("Schema_XML"))
                    Dim picFac As New PictureBox

                    Dim imageData As Byte() = DirectCast(_tableConfigBilling.Rows(0)("picture"), Byte())
                    If Not imageData Is Nothing Then
                        Using ms As New MemoryStream(imageData, 0, imageData.Length)
                            ms.Write(imageData, 0, imageData.Length)
                            picFac.Image = Image.FromStream(ms, True)
                        End Using
                    End If
                    ds.ReadXmlSchema(xmlSchema)
                    ds.ReadXml(xmlDatos)
                    Dim objCheque As New ConfiguraChequeDisplayControls(False, ds, picFac, _tableConfigBilling.Rows(0)("ID_Check"), _tableConfigBilling.Rows(0)("ID_Bank_FK"))
                    objCheque.Dock = DockStyle.Fill
                    Panel_ConfiguracionCheque.Controls.Add(objCheque)
                Else
                    Dim ds As New DataSet


                    SchemaXMLa.ReadXmlSchema(My.Application.Info.DirectoryPath + "\SchemaXMLCheques.xml")
                    'ConfigXMLa.ReadXmlSchema(Application.StartupPath() + "\ConfigXMLCheques.xml")
                    ConfigXMLa.ReadXml(My.Application.Info.DirectoryPath + "\ConfigXMLCheques.xml")
                    Dim objCheque As New ConfiguraChequeDisplayControls(ConfigXMLa, SchemaXMLa, _id_row)
                    objCheque.Dock = DockStyle.Fill
                    Panel_ConfiguracionCheque.Controls.Add(objCheque)
                    MessageBox.Show("Error no existen configuraciones para este banco", "Configuración de Cheques", MessageBoxButtons.OK)
                End If
            End If
        End Using
    End Sub

    Private Sub cmd_ConfigCF_ZoomMAS_Click_1(sender As Object, e As EventArgs) Handles cmd_ConfigCF_ZoomMAS.Click
        For Each obj As Object In Panel_ConfiguracionCheque.Controls
            If TypeOf obj Is ConfiguraChequeDisplayControls Then
                obj.Zoom(0.1)
            Else
                PPC_ConfigCheque.Zoom += 0.1
            End If
        Next
    End Sub

    Private Sub cmd_ConfigCF_ZoomMenos_Click_1(sender As Object, e As EventArgs) Handles cmd_ConfigCF_ZoomMenos.Click
        For Each obj As Object In Panel_ConfiguracionCheque.Controls
            If TypeOf obj Is ConfiguraChequeDisplayControls Then
                obj.Zoom(-0.1)
            Else
                PPC_ConfigCheque.Zoom -= 0.1
            End If

        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Using obj As New ERP_Finance_Bank_Entradas
            obj.movementType = 1
            If obj.ShowDialog() = DialogResult.OK Then
                GetMovimientosBancos()
            End If
        End Using
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Using obj As New ERP_Finance_Bank_Entradas
            obj.movementType = 2
            obj.GBEntradaBancos.Text = "Configuracion Salida Bancos"
            If obj.ShowDialog() = DialogResult.OK Then
                GetMovimientosBancos()
            End If
        End Using
    End Sub

    Private Sub cmdCuotaClienteMora_Click(sender As Object, e As EventArgs) Handles cmdCuotaClienteMora.Click
        'PARA LA CREACION DE REPORTES

        Dim Ds As New EPD_SatelliteERPDataSet3
        Dim dt As New EPD_SatelliteERPDataSet3TableAdapters.ERP_Finance_ReportBankBalanceTableAdapter
        Dim dt1 As DataTable
        dt.Fill(Ds.ERP_Finance_ReportBankBalance, Data_Id_Company, False)
        dt1 = Ds.Tables(0)
        Using objPartidaContable As New Financiero_ReportViewer(dt1, "dsBancos", "epd_SatelliteERP.Reports_BankBalances.rdlc")
            objPartidaContable.ShowDialog()
        End Using

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Using obj As New ERP_Finance_Bank_Entradas
            obj.movementType = 3
            obj.ispettycash = True
            obj.GBEntradaBancos.Text = "Configuracion Entrada Caja Chica"
            If obj.ShowDialog() = DialogResult.OK Then
                GetMovimientosCajaChica()
            End If
        End Using
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Using obj As New ERP_Finance_Bank_Entradas
            obj.movementType = 4
            obj.ispettyCash = True
            obj.GBEntradaBancos.Text = "Configuracion Salida Caja Chica"
            If obj.ShowDialog() = DialogResult.OK Then
                GetMovimientosCajaChica()
            End If
        End Using
    End Sub

    Private Sub DG_Bank_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DG_Bank.CellContentClick

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim Ds As New EPD_SatelliteERPDataSet3
        Dim dt As New EPD_SatelliteERPDataSet3TableAdapters.ERP_Finance_ReportPettyCashTableAdapter
        Dim dt1 As DataTable
        dt.Fill(Ds.ERP_Finance_ReportPettyCash, Data_Id_Company, True)
        dt1 = Ds.Tables(1)
        Using objPartidaContable As New Financiero_ReportViewer(dt1, "DsPettyCash", "epd_SatelliteERP.Reports_PettyCashBalances.rdlc")
            objPartidaContable.ShowDialog()
        End Using
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Using objFiltro As New ERP_Finance_ReportsBankPettyCashfilter
            objFiltro.ShowDialog()
        End Using
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Using objFiltro As New ERP_Finance_ReportsBankPettyCashfilter
            objFiltro.ispettyCash = True
            objFiltro.GBFiltroBankPettyCash.Text = "Reporte de Movimientos Caja Chica"
            objFiltro.GBFiltroBankFilter.Text = "Filtro Caja Chica"
            objFiltro.chk_TodoBancos.Text = "Todas"
            objFiltro.chk_SeleccionarBancos.Text = "Seleccionar Caja Chica"
            objFiltro.ShowDialog()
        End Using
    End Sub
End Class
