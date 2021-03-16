Public Class ModuloContabilidad
    Private objSql As New Financiero_SQLServer
    Private _tableAccountingCatalog As DataTable
    Private _tableAccountingIitemHeading As DataTable
    Private _tableAccountingIitemHeadingPosting As DataTable
    Private _tableAccountingYearCurrent As DataTable
    Public Sub New()
        InitializeComponent()
        GetDataCatalogoCuentas()
    End Sub
    Private Sub GetDataCatalogoCuentas()
        _tableAccountingCatalog = objSql.GetAccountingCatalog(Data_Id_Company)
        TreeView1.Nodes.Clear()
        Dim parentnode As TreeNode
        parentnode = New TreeNode("CATALOGO")
        Dim IconTypeAccount As Integer = 0
        For Each row As DataRow In _tableAccountingCatalog.Rows
            Dim nodos() As String = row("NumeroCuentaContable").ToString.Split(".")
            Dim nameNodo As String = "n"
            Try
                If row("Is_Detail") Then
                    IconTypeAccount = 1
                End If
            Catch ex As Exception
                IconTypeAccount = False
            End Try
            For Each s As String In nodos
                nameNodo &= "." & s
                Dim pp() As TreeNode = parentnode.Nodes.Find(nameNodo, True)
                If pp.Length = 0 Then
                    Dim nameNodoPadre As String = nameNodo.Substring(0, nameNodo.Length - s.Length - 1)
                    If nameNodoPadre = "n" Then
                        parentnode.Nodes.Add(nameNodo, row("NumeroCuentaContable") & "-" & row("NombreCuentaContable"), IconTypeAccount, IconTypeAccount + 2) 'row("NombreCuentaContable"))
                        Exit For
                    Else
                        ' Buscar el nodo padre de el.
                        Dim ppPadre() As TreeNode = parentnode.Nodes.Find(nameNodoPadre, True)
                        If ppPadre.Length <> 0 Then
                            ppPadre(0).Nodes.Add(nameNodo, row("NumeroCuentaContable") & "-" & row("NombreCuentaContable"), IconTypeAccount, IconTypeAccount + 2)
                        End If
                    End If
                End If
            Next
            REM TreeView1.Nodes.Add(row("NombreCuentaContable"), row("NombreCuentaContable"))
        Next
        TreeView1.Nodes.Add(parentnode)
        TreeView1.ExpandAll()
        TreeView1.Refresh()

        DataGridView2.AutoGenerateColumns = False
        DataGridView2.DataSource = _tableAccountingCatalog
        DataGridView2.Columns(1).Width = 300

    End Sub
    Private Sub CrearCuentaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CrearCuentaToolStripMenuItem.Click
        Dim CurrentIndex As Integer = TreeView1.SelectedNode.Index
        Dim CurrentNode As TreeNode = TreeView1.SelectedNode
        Using obj As New Financiero_CrearCuentaContable
            obj.OpcionSeleccionada = Financiero_CrearCuentaContable.funcion.Agregar
            obj.NoCuentaContable = CurrentNode.Text.Split("-")(0)
            If obj.ShowDialog() = DialogResult.OK Then
                GetDataCatalogoCuentas()
            End If
        End Using
    End Sub
    Private Sub ModificarCuentaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificarCuentaToolStripMenuItem.Click
        Dim CurrentIndex As Integer = TreeView1.SelectedNode.Index
        Dim CurrentNode As TreeNode = TreeView1.SelectedNode
        Using obj As New Financiero_CrearCuentaContable
            obj.OpcionSeleccionada = Financiero_CrearCuentaContable.funcion.Actualizar
            obj.NoCuentaContable = CurrentNode.Text.Split("-")(0)
            obj.CuentaContable = CurrentNode.Text.Split("-")(1)
            For Each row As DataRow In _tableAccountingCatalog.Select("NumeroCuentaContable='" & obj.NoCuentaContable & "'")
                obj.Id_Account = row("Id_Account")
                obj.Id_Company_FK = Data_Id_Company
                Try
                    obj.Id_CashFlow = row("Id_CashFlow")
                Catch ex As Exception
                    obj.Id_CashFlow = -1
                End Try

                Try
                    obj.Is_Detail = row("Is_Detail")
                Catch ex As Exception
                    obj.Is_Detail = False
                End Try
                Try
                    obj.Id_TypeAccount_FK = row("Id_TypeAccount_FK")
                Catch ex As Exception
                    obj.Id_TypeAccount_FK = -1
                End Try
                Try
                    obj.Id_CashFlow = row("Id_CashFlow_FK")
                Catch ex As Exception
                    obj.Id_CashFlow = -1
                End Try
            Next
            If obj.ShowDialog() = DialogResult.OK Then
                GetDataCatalogoCuentas()
            End If
        End Using
    End Sub
    Private Sub GetDataPartidasContables()
        _tableAccountingIitemHeading = objSql.GetAccountingIitemHeading(Data_Id_Company, Data_BusinessDay)

        DG_AccountingIitemHeading.AutoGenerateColumns = False
        DG_AccountingIitemHeading.Columns(0).Width = 30
        DG_AccountingIitemHeading.Columns(1).Width = 80
        DG_AccountingIitemHeading.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DG_AccountingIitemHeading.Columns(2).Width = 80
        DG_AccountingIitemHeading.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        DG_AccountingIitemHeading.Columns(4).Width = 90
        DG_AccountingIitemHeading.Columns(5).Width = 160
        DG_AccountingIitemHeading.Columns(6).Width = 220
        DG_AccountingIitemHeading.Columns(7).Width = 120
        DG_AccountingIitemHeading.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DG_AccountingIitemHeading.Columns(7).DefaultCellStyle.Format = "c"
        DG_AccountingIitemHeading.Columns(8).Width = 120
        DG_AccountingIitemHeading.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DG_AccountingIitemHeading.Columns(8).DefaultCellStyle.Format = "c"
        DG_AccountingIitemHeading.Columns(12).Width = 140
        DG_AccountingIitemHeading.Columns(14).Width = 140

        DG_AccountingIitemHeading.ReadOnly = True
        DG_AccountingIitemHeading.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DG_AccountingIitemHeading.MultiSelect = False
        DG_AccountingIitemHeading.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
        DG_AccountingIitemHeading.AllowUserToResizeColumns = False
        DG_AccountingIitemHeading.AllowUserToAddRows = False
        DG_AccountingIitemHeading.AllowUserToDeleteRows = False
        DG_AccountingIitemHeading.DataSource = _tableAccountingIitemHeading
        Dim Is_Posting As Boolean = False
        Dim Is_Square As Boolean = False

        For Each row As DataGridViewRow In DG_AccountingIitemHeading.Rows
            Try
                If Not row.Cells("Is_Posting").Value Is DBNull.Value Then
                    Is_Posting = row.Cells("Is_Posting").Value
                Else
                    Is_Posting = False
                End If
                If Not row.Cells("Is_Square").Value Is DBNull.Value Then
                    Is_Square = row.Cells("Is_Square").Value
                Else
                    Is_Square = False
                End If
                If Is_Posting Then
                    row.Cells("Imagen").Value = epd_SatelliteERP.My.Resources.Resources.Verde_Bandera
                    row.Cells("Estado").Value = "Postiada"


                ElseIf Is_Square Then
                    row.Cells("Imagen").Value = epd_SatelliteERP.My.Resources.Resources.Amarillo_bandera
                    row.Cells("Estado").Value = "Cuadrada"
                Else
                    row.Cells("Estado").Value = "No Cuadrada"

                End If
            Catch ex As Exception
                ' No existe cambio unicamente es valor nulo
            End Try


        Next
        REM    DG_AccountingIitemHeading.Rows(0).Cells(0).Value = epd_SatelliteERP.My.Resources.Resources.Amarillo_bandera

        REM    DG_AccountingIitemHeading.Refresh()
    End Sub
    Private Sub GetDataContabilizar()
        _tableAccountingIitemHeadingPosting = objSql.GetAccountingIitemHeading(Data_Id_Company, Data_BusinessDay, True)

        DG_Contabilizar.AutoGenerateColumns = False
        DG_Contabilizar.Columns(0).Width = 30
        DG_Contabilizar.Columns(1).Width = 80
        DG_Contabilizar.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DG_Contabilizar.Columns(2).Width = 90
        DG_Contabilizar.Columns(3).Width = 160
        DG_Contabilizar.Columns(4).Width = 220
        DG_Contabilizar.Columns(5).Width = 120
        DG_Contabilizar.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DG_Contabilizar.Columns(5).DefaultCellStyle.Format = "c"
        DG_Contabilizar.Columns(6).Width = 120
        DG_Contabilizar.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DG_Contabilizar.Columns(6).DefaultCellStyle.Format = "c"
        DG_Contabilizar.Columns(10).Width = 140
        DG_Contabilizar.Columns(12).Width = 140

        DG_Contabilizar.ReadOnly = True
        DG_Contabilizar.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DG_Contabilizar.MultiSelect = False
        DG_Contabilizar.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
        DG_Contabilizar.AllowUserToResizeColumns = False
        DG_Contabilizar.AllowUserToAddRows = False
        DG_Contabilizar.AllowUserToDeleteRows = False
        DG_Contabilizar.DataSource = _tableAccountingIitemHeadingPosting
        Dim Is_Posting As Boolean = False
        Dim Is_Square As Boolean = False
        For Each row As DataGridViewRow In DG_Contabilizar.Rows
            Try
                If Not row.Cells("Is_Posting1").Value Is DBNull.Value Then
                    Is_Posting = row.Cells("Is_Posting1").Value
                Else
                    Is_Posting = False
                End If
                If Not row.Cells("Is_Square1").Value Is DBNull.Value Then
                    Is_Square = row.Cells("Is_Square1").Value
                Else
                    Is_Square = False
                End If

                If Is_Posting Then
                    row.Cells("Imagen1").Value = epd_SatelliteERP.My.Resources.Resources.Verde_Bandera
                ElseIf Is_Square Then
                    row.Cells("Imagen1").Value = epd_SatelliteERP.My.Resources.Resources.Amarillo_bandera
                End If
            Catch ex As Exception
                ' No existe cambio unicamente es valor nulo
            End Try
        Next
    End Sub
    Private Sub GetDataSaldosMexAnoActual()
        _tableAccountingYearCurrent = objSql.GetFinance_Ledger_History_SumValue(Data_Id_Company, Data_BusinessDay.Year)

        DGW_YearCurrentList.AutoGenerateColumns = False
        DGW_YearCurrentList.Columns(0).Width = 30
        DGW_YearCurrentList.Columns(1).Width = 140
        DGW_YearCurrentList.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DGW_YearCurrentList.Columns(2).Width = 140
        DGW_YearCurrentList.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DGW_YearCurrentList.Columns(2).DefaultCellStyle.Format = "c"

        DGW_YearCurrentList.Columns(3).Width = 140
        DGW_YearCurrentList.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DGW_YearCurrentList.Columns(3).DefaultCellStyle.Format = "c"

        DGW_YearCurrentList.Columns(4).Width = 140
        DGW_YearCurrentList.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DGW_YearCurrentList.Columns(4).DefaultCellStyle.Format = "c"

        DGW_YearCurrentList.Columns(5).Width = 164
        DGW_YearCurrentList.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DGW_YearCurrentList.Columns(5).DefaultCellStyle.Format = "c"
        DGW_YearCurrentList.Columns(6).Width = 164

        DGW_YearCurrentList.ReadOnly = True
        DGW_YearCurrentList.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DGW_YearCurrentList.MultiSelect = False
        DGW_YearCurrentList.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
        DGW_YearCurrentList.AllowUserToResizeColumns = False
        DGW_YearCurrentList.AllowUserToAddRows = False
        DGW_YearCurrentList.AllowUserToDeleteRows = False
        DGW_YearCurrentList.DataSource = _tableAccountingYearCurrent
        Dim Is_Posting As Boolean = False
        Dim Is_Square As Boolean = False
        For Each row As DataGridViewRow In DG_Contabilizar.Rows
            Try
                If Not row.Cells("Is_Posting1").Value Is DBNull.Value Then
                    Is_Posting = row.Cells("Is_Posting1").Value
                Else
                    Is_Posting = False
                End If
                If Not row.Cells("Is_Square1").Value Is DBNull.Value Then
                    Is_Square = row.Cells("Is_Square1").Value
                Else
                    Is_Square = False
                End If

                If Is_Posting Then
                    row.Cells("Imagen1").Value = epd_SatelliteERP.My.Resources.Resources.Verde_Bandera
                ElseIf Is_Square Then
                    row.Cells("Imagen1").Value = epd_SatelliteERP.My.Resources.Resources.Amarillo_bandera
                End If
            Catch ex As Exception
                ' No existe cambio unicamente es valor nulo
            End Try
        Next
    End Sub
    Private Sub GetDataSaldosMesAnoAnterior()
        _tableAccountingYearCurrent = objSql.GetFinance_Ledger_History_SumValue(Data_Id_Company, "")

        DGW_YearOLD.AutoGenerateColumns = False
        DGW_YearOLD.Columns(0).Width = 30
        DGW_YearOLD.Columns(1).Width = 140
        DGW_YearOLD.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DGW_YearOLD.Columns(2).Width = 140
        DGW_YearOLD.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DGW_YearOLD.Columns(2).DefaultCellStyle.Format = "c"

        DGW_YearOLD.Columns(3).Width = 140
        DGW_YearOLD.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DGW_YearOLD.Columns(3).DefaultCellStyle.Format = "c"

        DGW_YearOLD.Columns(4).Width = 140
        DGW_YearOLD.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DGW_YearOLD.Columns(4).DefaultCellStyle.Format = "c"
        DGW_YearOLD.Columns(5).Width = 164
        DGW_YearOLD.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DGW_YearOLD.Columns(5).DefaultCellStyle.Format = "c"
        DGW_YearOLD.Columns(6).Width = 164
        DGW_YearOLD.ReadOnly = True
        DGW_YearOLD.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DGW_YearOLD.MultiSelect = False
        DGW_YearOLD.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
        DGW_YearOLD.AllowUserToResizeColumns = False
        DGW_YearOLD.AllowUserToAddRows = False
        DGW_YearOLD.AllowUserToDeleteRows = False
        DGW_YearOLD.DataSource = _tableAccountingYearCurrent
        Dim Is_Posting As Boolean = False
        Dim Is_Square As Boolean = False
        For Each row As DataGridViewRow In DG_Contabilizar.Rows
            Try
                If Not row.Cells("Is_Posting1").Value Is DBNull.Value Then
                    Is_Posting = row.Cells("Is_Posting1").Value
                Else
                    Is_Posting = False
                End If
                If Not row.Cells("Is_Square1").Value Is DBNull.Value Then
                    Is_Square = row.Cells("Is_Square1").Value
                Else
                    Is_Square = False
                End If

                If Is_Posting Then
                    row.Cells("Imagen1").Value = epd_SatelliteERP.My.Resources.Resources.Verde_Bandera
                ElseIf Is_Square Then
                    row.Cells("Imagen1").Value = epd_SatelliteERP.My.Resources.Resources.Amarillo_bandera
                End If
            Catch ex As Exception
                ' No existe cambio unicamente es valor nulo
            End Try
        Next
    End Sub

    Private Sub cmdCreate_Click(sender As Object, e As EventArgs) Handles cmdCreate.Click
        Using obj As New Financiero_CrearPartidaContable
            obj.TipoIngreso = Financiero_CrearPartidaContable.TipoIngresoInfo.NuevoRegistro
            obj.TableCuentaContable = _tableAccountingCatalog
            obj.StartPosition = FormStartPosition.CenterParent
            If obj.ShowDialog() = DialogResult.OK Then
                GetDataPartidasContables()
            End If
        End Using
    End Sub

    Private Sub ModificarPartidaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificarPartidaToolStripMenuItem.Click
        If DG_AccountingIitemHeading.CurrentRow.Cells(3).Value = "Postiada" Then
            MessageBox.Show("No se puede modificar una partida posteada, por favor verifique.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Else
            Using obj As New Financiero_CrearPartidaContable
                obj.TipoIngreso = Financiero_CrearPartidaContable.TipoIngresoInfo.Modificacion
                obj.IdPartidaContable = DG_AccountingIitemHeading.CurrentRow.Cells(1).Value
                obj.Text_TypeItem = DG_AccountingIitemHeading.CurrentRow.Cells(5).Value
                obj.ConceptItem = DG_AccountingIitemHeading.CurrentRow.Cells(6).Value
                obj.TableCuentaContable = _tableAccountingCatalog
                obj.StartPosition = FormStartPosition.CenterParent
                If obj.ShowDialog() = DialogResult.OK Then
                    GetDataPartidasContables()
                End If
            End Using
        End If


    End Sub
    Private Sub tcMain_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tcMain.SelectedIndexChanged
        If sender.SelectedTab.Name = "TrabajarPartidas" Then
            GetDataPartidasContables()
            REM DG_AccountingIitemHeading.Rows(0).Cells(0).Value = epd_SatelliteERP.My.Resources.Resources.Amarillo_bandera
            REM tcMain.TabPages.Item(1).Refresh()
        ElseIf sender.SelectedTab.Name = "Contabilizar" Then
            GetDataContabilizar()
        ElseIf sender.selectedtab.name = "HistoryYear"
            GetDataSaldosMexAnoActual()
        ElseIf sender.selectedtab.name = "HistoryYearOld"
            GetDataSaldosMesAnoAnterior()

        End If
    End Sub

    Private Sub cmdContabilizar_Click(sender As Object, e As EventArgs) Handles cmdContabilizar.Click
        If MessageBox.Show("Esta seguro(a) de contabilizar esta partida.", Application.ProductName, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
            Dim resp As String = objSql.SetFinance_AccountingItem_Posting(Data_Id_Company, DG_Contabilizar.CurrentRow.Cells(1).Value)
            If resp.Substring(0, 2) = "OK" Then
                GetDataContabilizar()
            Else
                MessageBox.Show(resp.Split("|")(1), Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
            End If
        End If
    End Sub

    'Private Sub cmdLadgerPreview_Click(sender As Object, e As EventArgs) Handles cmdLadgerPreview.Click
    '    Dim objPreview As New classLadger
    '    objPreview.PPC_Documents = PPC_Preview
    '    objPreview.Preview()
    'End Sub

    Private Sub cmdPartidaContable_Click(sender As Object, e As EventArgs) Handles cmdPartidaContable.Click
        Using objPartidaContable As New Financiero_ReportViewer("ERP_Finance_ReportAccountingTableAdapter")
            objPartidaContable.ShowDialog()
        End Using
    End Sub

    Private Sub cmdPreview_Click(sender As Object, e As EventArgs) Handles cmdPreview.Click
        Using objPartidaContable As New Financiero_ReportViewer("ERP_Finance_ReportAccountingTableAdapter")
            objPartidaContable.Id_AccountingIitemHeading = DG_AccountingIitemHeading.CurrentRow.Cells(1).Value
            objPartidaContable.ShowDialog()
        End Using
    End Sub

    Private Sub cmdLibroMayor_Click(sender As Object, e As EventArgs) Handles cmdLibroMayor.Click

        Using objPartidaContable As New Financiero_ReportViewer("ERP_Finance_ReportAccountingAllTableAdapter")
            objPartidaContable.Id_AccountingIitemHeading = DG_AccountingIitemHeading.CurrentRow.Cells(1).Value
            objPartidaContable.ShowDialog()
        End Using
    End Sub

    Private Sub cmdContabilidadLibroMayorPreview_Click(sender As Object, e As EventArgs) Handles cmdContabilidadLibroMayorPreview.Click
        Using objPartidaContable As New Financiero_ReportViewer("ERP_Finance_ReportAccountingHighTableAdapter")
            objPartidaContable.ShowDialog()
        End Using
    End Sub

    Private Sub cmdContabilidadLibroAuxiliarPreview_Click(sender As Object, e As EventArgs) Handles cmdContabilidadLibroAuxiliarPreview.Click
        Using objPartidaContable As New Financiero_ReportViewer("ERP_Finance_Reports_SubledgerTableAdapter")
            objPartidaContable.ShowDialog()
        End Using
    End Sub

    Private Sub cmdBalance_Click(sender As Object, e As EventArgs) Handles cmdBalance.Click
        Using objPartidaContable As New Financiero_ReportViewer("ERP_Finance_ReportBalanceTableAdapter")
            objPartidaContable.ShowDialog()
        End Using
    End Sub

    Private Sub cmdBalanceComprobacion_Click(sender As Object, e As EventArgs) Handles cmdBalanceComprobacion.Click
        Using objPartidaContable As New Financiero_ReportViewer("ERP_Finance_ReportAccountingHighTableAdapter", 1)
            objPartidaContable.ShowDialog()
        End Using
    End Sub

    Private Sub cmdLadgerPrinter_Click(sender As Object, e As EventArgs) Handles cmdLadgerPrinter.Click

    End Sub

    Private Sub cmdClosePeriod_Click(sender As Object, e As EventArgs) Handles cmdClosePeriod.Click
        ' Pasos del cierre mensaual
        ' 1 - Hacer BK para evitar cualquier problema
        '       ERP_Tools_step_01_CreateBackup 'C:\EPD_SatelliteERP\bk1Test_Fecha_Step01.bak','EPD_SatelliteERP'
        ' 2 - Pasar de tablas ERP_Ledger_History,Finance_AccountingIitemBody_History, Finance_AccountingIitemHeading_History
        '       ERP_Tools_step_02_MigrateDataClose
        ' 3 - Borrar tablas sin truncate para no perder los ID's, 
        '       ERP_Tools_step_03_DeleteJobTables
        ' 4 - Eliminar los saldos anteriores del ERP_Ledger (tabla de trabajo mensual)
        '       ERP_Tools_step_04_LedgerBalances
        ' 5 - Hacer BK a base de datos o a tablas de contabilidad ??
        '       ERP_Tools_step_01_CreateBackup 'C:\EPD_SatelliteERP\bk1Test_Fecha_Step04.bak','EPD_SatelliteERP'
    End Sub

    Private Sub cmdPartidaGestionContable_Click(sender As Object, e As EventArgs) Handles cmdPartidaGestionContable.Click
        Using objPartidaContable As New Financiero_ReportViewer("ERP_Finance_ReportAccountingTableAdapter")
            objPartidaContable.Id_AccountingIitemHeading = DG_AccountingIitemHeading.CurrentRow.Cells(1).Value
            objPartidaContable.ShowDialog()
        End Using
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles cmdHistoryBalanceGeneral.Click
        Try
            If DGW_YearCurrentList.CurrentRow.Cells.Count > 0 Then
                Dim dt As DataTable = objSql.GetFinance_ReportBalance_History(Data_Id_Company, Data_LongAccount, DGW_YearCurrentList.CurrentRow.Cells(1).Value)
                Using objPartidaContable As New Financiero_ReportViewer(dt, "BalanceGeneral", "epd_SatelliteERP.Financiero_BalanceGeneral.rdlc")
                    objPartidaContable.ShowDialog()
                End Using
            End If
        Catch ex As System.NullReferenceException
            ' No existe ningun registro seleccionado, no se realiza ninguna accion
        End Try


    End Sub

    Private Sub cmdHistoryLibroMayor_Click(sender As Object, e As EventArgs) Handles cmdHistoryLibroMayor.Click
        Try
            If DGW_YearCurrentList.CurrentRow.Cells.Count > 0 Then
                Dim dt As DataTable = objSql.GetFinance_ReportAccountingHigh_History(Data_Id_Company, Data_LongAccount, DGW_YearCurrentList.CurrentRow.Cells(1).Value, True)
                Using objPartidaContable As New Financiero_ReportViewer(dt, "LibroMayor", "epd_SatelliteERP.Financiero_LibroMayor.rdlc")
                    objPartidaContable.ShowDialog()
                End Using
            End If
        Catch ex As System.NullReferenceException
            ' No existe ningun registro seleccionado, no se realiza ninguna accion
        End Try
    End Sub

    Private Sub cmdHistoryBalanceComprobacion_Click(sender As Object, e As EventArgs) Handles cmdHistoryBalanceComprobacion.Click
        Try
            Dim dt As DataTable = objSql.GetFinance_ReportAccountingHigh_History(Data_Id_Company, Data_LongAccount, DGW_YearCurrentList.CurrentRow.Cells(1).Value, True)
            Using objPartidaContable As New Financiero_ReportViewer(dt, "LibroMayor", "epd_SatelliteERP.Financiero_BalanceComprobacion.rdlc")
                objPartidaContable.ShowDialog()
            End Using
        Catch ex As System.NullReferenceException
            ' No existe ningun registro seleccionado, no se realiza ninguna accion
        End Try
    End Sub

    Private Sub cmdHistoryLibroAuxiliar_Click(sender As Object, e As EventArgs) Handles cmdHistoryLibroAuxiliar.Click
        Try
            Dim dt As DataTable = objSql.GetFinance_Reports_Subledger_History(Data_Id_Company, DGW_YearCurrentList.CurrentRow.Cells(1).Value)
            Using objPartidaContable As New Financiero_ReportViewer(dt, "LibroAuxiliar", "epd_SatelliteERP.Financiero_LibroAuxiliar.rdlc")
                objPartidaContable.ShowDialog()
            End Using
        Catch ex As System.NullReferenceException
            ' No existe ningun registro seleccionado, no se realiza ninguna accion
        End Try
    End Sub

    Private Sub cmdPartidaConfigSistemaExternoCreate_Click(sender As Object, e As EventArgs) Handles cmdPartidaConfigSistemaExternoCreate.Click
        Using objPartidaContable As New Financiero_PartidaConfExterna
            objPartidaContable.ShowDialog()
        End Using
    End Sub

    Private Sub CrearPartidaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CrearPartidaToolStripMenuItem.Click

    End Sub

    Private Sub cmd_Partida_CopiaPartida_Click(sender As Object, e As EventArgs) Handles cmd_Partida_CopiaPartida.Click
        Using obj As New Financiero_CrearPartidaContable
            obj.TipoIngreso = Financiero_CrearPartidaContable.TipoIngresoInfo.Copia
            obj.IdPartidaContable = DG_AccountingIitemHeading.CurrentRow.Cells(1).Value
            obj.Text_TypeItem = DG_AccountingIitemHeading.CurrentRow.Cells(5).Value
            obj.ConceptItem = DG_AccountingIitemHeading.CurrentRow.Cells(6).Value
            obj.TableCuentaContable = _tableAccountingCatalog
            obj.StartPosition = FormStartPosition.CenterParent
            If obj.ShowDialog() = DialogResult.OK Then
                GetDataPartidasContables()
            End If
        End Using
    End Sub

    Private Sub cmd_Partida_RevertirPartida_Click(sender As Object, e As EventArgs) Handles cmd_Partida_RevertirPartida.Click
        Using obj As New Financiero_CrearPartidaContable
            Dim IndicadorReversion As String = "Reversion"
            If DG_AccountingIitemHeading.CurrentRow.Cells(6).Value.ToString Like "*" & IndicadorReversion Then
                MessageBox.Show("Una Partida de Origen Reversion no se puede Revertir, por favor verifique.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Exit Sub
            End If
            obj.TipoIngreso = Financiero_CrearPartidaContable.TipoIngresoInfo.Reversion
            obj.IdPartidaContable = DG_AccountingIitemHeading.CurrentRow.Cells(1).Value
            obj.Text_TypeItem = DG_AccountingIitemHeading.CurrentRow.Cells(5).Value
            obj.ConceptItem = DG_AccountingIitemHeading.CurrentRow.Cells(6).Value.ToString.Trim & " - " & IndicadorReversion
            obj.TableCuentaContable = _tableAccountingCatalog
            obj.StartPosition = FormStartPosition.CenterParent
            If obj.ShowDialog() = DialogResult.OK Then

                GetDataPartidasContables()
            End If
        End Using
    End Sub

End Class
