Public Class ERP_Inventory_Dialog_Requisitions
    Private _DT_Stowage As New DataTable
    Private _DT_Employee As New DataTable
    Private _DT_RequisitionType As New DataTable
    Property ID_Stowage As Long = 0

    Private _DT_Products As New DataTable
    Private _IS_Result As Boolean = False
    Private row As DataRow = Nothing
    Private _Quantity As Double = 0
    Private _ID_BodegaSalida As Long = 0
    Private _Name_BodegaSalida As String
    Property _Is_Approved As Boolean
    Property _ID_Requisition_Header As Long = 0
    Property requisitionTypes As Long = 0
    Property _Is_approval As Boolean = False
    Property _is_creation As Boolean = False
    Property _departamentoX As String = ""
    Property _Abastecimiento As Boolean = False
    Property Correlativo_Salida As Long = 0
    Property Is_EncargadoBOdega As Boolean = False
    Property Is_Jefe As Boolean = False

    Property NUmeroRequisicion As String = ""

    Property vista As Boolean = False
    Private abierto As Integer = 1
    Private departamentos As New DataTable
    Private OpcionesMenu As DataTable
    Property _SendAproved As Boolean = False
    Property ReaperturarRequ As Boolean

    Private Sub LoadCatalog()
        Using objSQL As New Operaciones_SQLServer
            _DT_Stowage = objSQL.ERP_Prod_SP_Select_StowageEmpty()
        End Using
        Using objSql As New Requisiciones_SQLServer
            _DT_RequisitionType = objSql.Inventory_SelectRequisitions()
        End Using
        Using objSql As New Generic_SQLServer
            _DT_Employee = objSql.GetEmployee(_ID_Company)

            departamentos = objSql.ERP_RRHH_GetDepartment(_ID_Company)
        End Using
        cb_Catalog.DataSource = _DT_Stowage
        cb_Catalog.ValueMember = "ID_Stowage"
        cb_Catalog.DisplayMember = "Name_Stowage"
        cb_Catalog.SelectedValue = ID_Stowage

        Try
            cb_RequisitionType.DataSource = _DT_RequisitionType
            cb_RequisitionType.ValueMember = "Id_RequisitionTypes"
            cb_RequisitionType.DisplayMember = "RequisitionType"
            'cb_RequisitionType.SelectedValue = requisitionTypes
            cb_RequisitionType.SelectedIndex = 0
        Catch ex As Exception

        End Try

        cb_Employee.DataSource = _DT_Employee
        cb_Employee.ValueMember = "Id_employee"
        cb_Employee.DisplayMember = "Contact"
        cb_Employee.SelectedValue = _Id_EmployeeGlobal

        cb_departamento.DataSource = departamentos
        cb_departamento.ValueMember = "Id_deparment"
        cb_departamento.DisplayMember = "Name_Deparmnet"

        If _is_creation Then
            ModificarToolStripMenuItem.Visible = True
            cb_departamento.SelectedValue = _Id_DepartmentGlobal
        Else
            cb_departamento.Text = _departamentoX
        End If


        Using objSql2 As New Generic_SQLServer
            OpcionesMenu = objSql2.GetAccessMenu(_UserSQL)
            cb_Employee.Enabled = False
            cb_departamento.Enabled = False
            If (OpcionesMenu.Rows.Count > 0) Then
                For Each DataInfo As DataRow In OpcionesMenu.Rows
                    If (DataInfo("rolUser").ToString.ToUpper = "In_RequisicionesAllDepartment".ToUpper) Then 'cambio poca
                        cb_Employee.Enabled = True
                        cb_departamento.Enabled = True
                    End If
                Next
            End If
        End Using
    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        If cb_Catalog.SelectedIndex = -1 Then
            MessageBox.Show("Seleccione una bodega, por favor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If
        If cb_departamento.SelectedIndex = -1 Then
            MessageBox.Show("Selecione un Departamento, por favor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If
        'If cb_Employee.SelectedIndex = -1 Then
        '    MessageBox.Show("Selecione una persona, por favor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        '    Exit Sub
        'End If

        If dgvProductsOutput.RowCount = 0 Then
            MessageBox.Show("Tiene que seleccionar al menos un artículo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If

        If dgvProductsOutput.Rows(0).Cells("cantidad").Value = 0 Then
            MessageBox.Show("Ingrese una cantidad de abastecimiento para este producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If
        Dim ID_bodega As Long = cb_Catalog.SelectedValue
        If _Is_Approved Then
            If dgvProductsOutput.Rows(0).Cells("cantidad").Value < dgvProductsOutput.Rows(0).Cells("Cantidad Abastecida").Value Then
                MessageBox.Show("La cantidad de abastecimiento ingresada es mayor a la cantidad solicitadad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Exit Sub
            End If
            'If dgvProductsOutput.Rows(0).Cells(6).Value = "" Then
            '    MessageBox.Show("Ingrese una observación", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            '    Exit Sub
            'End If
            ID_bodega = dgvProductsOutput.Rows(0).Cells("Cod_Bodega").Value

        End If
        ' dgvRow.Cells(8).Value = bodega

        Dim TipoRequisicion = cb_RequisitionType.SelectedValue
        Dim IdEmpleado As Long = cb_Employee.SelectedValue

        Dim resp As Integer = 0
        Dim Correlativo_SalidaInventario As Long = 0
        Dim Id_Department As Integer = cb_departamento.SelectedValue

        Dim CodeRequisitions As String = ""
        Try
            CodeRequisitions = cb_departamento.SelectedItem(8).ToString.PadLeft(3, " ").ToString.Substring(0, 3) & Date.Now.Year.ToString & "R"
        Catch ex As Exception

        End Try


        If Not _Is_approval Then
            Using ObjSQl As New Requisiciones_SQLServer
                Correlativo_Salida = ObjSQl.ERP_Inventory_InsertRequisitions(_ID_Company, IdEmpleado, ID_bodega, Id_Department, TipoRequisicion, CodeRequisitions)
            End Using

            If Correlativo_Salida > 0 Then
                For Each dgvRow As DataGridViewRow In dgvProductsOutput.Rows
                    If Not dgvRow Is Nothing Then
                        Using ObjSQl As New Requisiciones_SQLServer
                            ' dgvProductsOutput.Rows(0).Cells(5).Value =
                            resp = ObjSQl.ERP_Inventory_InsertRequisitionsDetails(Correlativo_Salida, dgvRow.Cells("correlativo").Value, dgvRow.Cells("cantidad").Value, 0)
                        End Using
                    End If
                Next dgvRow

                If resp > 1 Then
                    MessageBox.Show("Requisición procesada exitosamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.DialogResult = DialogResult.OK
                    Me.Close()
                End If
            Else
                MessageBox.Show("Ocurrió un error al agregar el encabezado de la salida, contacte a Soporte Técnico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            If MessageBox.Show("¿Esta seguro que desea Abastecer la Requisión?", Application.CompanyName, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
                Using ObjSQl As New Requisiciones_SQLServer
                    Dim resultado As String = ""
                    Using ObjSQla As New Operaciones_SQLServer
                        Correlativo_SalidaInventario = ObjSQla.SP_ERP_Inventory_Output_InventoryHeader(ID_bodega, 0, "", 0)
                    End Using
                    Dim observacion As String = ""
                    For Each row As DataGridViewRow In dgvProductsOutput.Rows
                        Try
                            observacion = row.Cells("Observaciones").Value.ToString
                        Catch ex As Exception
                            observacion = ""
                        End Try
                        Try

                            resultado = ObjSQl.Inventory_InsertSupplyRequisitions(_ID_Company, _ID_Requisition_Header, row.Cells("Id_Requisitions_Details").Value.ToString, row.Cells("Cantidad Abastecida").Value, observacion, ID_bodega, Long.Parse(row.Cells("correlativo").Value), Correlativo_SalidaInventario)
                        Catch ex As Exception
                            resultado = 0
                        End Try

                    Next
                    If resultado = "1" Then
                        resultado = ObjSQl.SP_Inventory_SuppliedRequisitions(_ID_Requisition_Header, 1)
                        MessageBox.Show("Requisición abastecida exitosamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Dim dt As New DataTable
                        Using objSQLRequisiciones As New Requisiciones_SQLServer
                            dt = objSQLRequisiciones.Inventory_GetSuppliedRequisitionsReport(_ID_Requisition_Header)
                        End Using
                        Using objPartidaContable As New Financiero_ReportViewer(dt, "SuppliedRequisitions", "epd_SatelliteERP.Inventory_ReportSuppliedRequisitions.rdlc")
                            objPartidaContable.ShowDialog()
                        End Using
                        Me.DialogResult = DialogResult.OK
                        Me.Close()
                    End If
                End Using
            End If
        End If
    End Sub

    Private Sub AgregarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarToolStripMenuItem.Click
        If (cb_Catalog.SelectedIndex < 0) Then
            MessageBox.Show("Debe seleccionar una bodega", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Dim UnidadSend As String = ""
        Dim NombrePro As String = ""
        Using objAdd As New Generic_SeleccionarProducto
            objAdd.ID_Stowage = cb_Catalog.SelectedValue
            objAdd.IS_Bodega = True

            objAdd.StartPosition = FormStartPosition.CenterParent
            If objAdd.ShowDialog() = DialogResult.OK Then
                UnidadSend = objAdd.UnidadMedidaSend
                row = objAdd.rowSelection
                NombrePro = row("Name_Product").ToString
                _IS_Result = True
            Else
                Exit Sub
            End If
        End Using
        If _IS_Result Then
            Using objQuantity As New Financiero_DocumentoFiscalDigiteNumero
                objQuantity.GroupBox1.Text = "Cantidad Productos"
                objQuantity.UnidadSend = UnidadSend
                objQuantity.NombreProducto = NombrePro
                objQuantity.StartPosition = FormStartPosition.CenterParent
                If objQuantity.ShowDialog() = DialogResult.OK Then
                    _Quantity = objQuantity.NumeroFactura
                Else
                    Exit Sub
                End If
            End Using
        End If
        If Not row Is Nothing Then
            Try
                If row("Stock") < _Quantity Then ' validamos la cantidad de salida del producto
                    MessageBox.Show("La cantidad solicitada no está disponible para la salida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    Exit Sub
                End If
            Catch ex As Exception

            End Try

            Dim Exist As Boolean = False
            For Each rowP As DataRow In _DT_Products.Rows
                If Not rowP Is Nothing Then
                    If rowP("ID_Producto_FK") = row("Id_Product") Then
                        Exist = True
                    End If
                End If
            Next rowP
            If Not Exist Then
                Try

                    If (_DT_Products.Rows.Count <= 0) Then
                        For i = 0 To dgvProductsOutput.RowCount - 1
                            _DT_Products.Rows.Add(dgvProductsOutput.Rows(i).Cells(0).Value, dgvProductsOutput.Rows(i).Cells(1).Value, dgvProductsOutput.Rows(i).Cells(2).Value, dgvProductsOutput.Rows(i).Cells(3).Value, dgvProductsOutput.Rows(i).Cells(4).Value, dgvProductsOutput.Rows(i).Cells(5).Value)
                        Next
                    End If
                Catch ex As Exception

                End Try

                Dim dt_Temp As DataTable = _DT_Products.Clone

                dt_Temp.Rows.Add(row("Id_Product"), row("number_purchase"), row("Name_Product"), _Quantity, 0, 0, row("Name_UnitMeasure").ToString, row("Stock").ToString)
                dt_Temp.Merge(_DT_Products)
                dgvProductsOutput.DataSource = dt_Temp
                _DT_Products = dt_Temp
                dgvProductsOutput.Font = New Font("Segoe UI", 11)

                Try
                    dgvProductsOutput.Columns(8).Visible = False
                Catch ex As Exception

                End Try
                'btnEnviarApro.Visible = False
            Else
                MessageBox.Show("El producto que trata de ingresar ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            End If
        End If
        _Quantity = 0
    End Sub

    Private Sub ERP_Inventory_Dialog_InventoryDepartures_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _DT_Products.Columns.Add("Id_Producto_FK", Type.GetType("System.Int64"))
        _DT_Products.Columns.Add("Number_Purchase", Type.GetType("System.String"))
        _DT_Products.Columns.Add("Name_Product", Type.GetType("System.String"))
        _DT_Products.Columns.Add("RequiredQuantity", Type.GetType("System.Double"))
        _DT_Products.Columns.Add("Id_Requisitions_Header", Type.GetType("System.Int64"))
        _DT_Products.Columns.Add("Id_Requisitions_Details", Type.GetType("System.Int64"))
        _DT_Products.Columns.Add("Name_UnitMeasure", Type.GetType("System.String"))
        _DT_Products.Columns.Add("Existencia_Producto", Type.GetType("System.String"))

        dgvProductsOutput.Font = New Font("Segoe UI", 11)

        'dgvProductsOutput.DataSource = _DT_Products
        If NUmeroRequisicion <> "" Then
            lblTitRequ.Visible = True
            lblNumeroRequisicion.Text = NUmeroRequisicion
            cmdSave.Text = "Aprobar"
        End If
        LoadCatalog()
        cmdModificar.Visible = False


        dgvProductsOutput.Columns("ExistenciaPro").Visible = False

        If Is_EncargadoBOdega Or Is_Jefe Then
            dgvProductsOutput.Columns("ExistenciaPro").Visible = True
        End If

        If _ID_Requisition_Header > 0 Then
            Dim dsHeader As New DataSet
            Dim dsDetails As New DataSet
            Using objRequisiciones As New Requisiciones_SQLServer
                dsHeader = objRequisiciones.Inventory_GetRequisitionsHeaderByID(_ID_Requisition_Header)
                dsDetails = objRequisiciones.Inventory_GetRequisitionsDetailsByID(_ID_Requisition_Header)

                dgvProductsOutput.Font = New Font("Segoe UI", 11)
                dgvProductsOutput.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None

                dgvProductsOutput.MultiSelect = False

                dgvProductsOutput.AllowUserToDeleteRows = False
                'dgvProductsOutput.AllowUserToAddRows = False
                dgvProductsOutput.AutoGenerateColumns = False

                cb_Catalog.SelectedValue = dsHeader.Tables(0).Rows(0)(12)
                cb_Employee.SelectedValue = dsHeader.Tables(0).Rows(0)(2)
                cb_RequisitionType.SelectedValue = dsHeader.Tables(0).Rows(0)(1)
                Try
                    If (dsHeader.Tables(0).Rows(0)(14).ToString.Trim = "") Then
                        lblrazon.Visible = False
                        lblrazontext.Visible = False
                    Else
                        lblrazon.Text = dsHeader.Tables(0).Rows(0)(14).ToString.Trim
                    End If
                Catch ex As Exception

                End Try

                dgvProductsOutput.DataSource = dsDetails.Tables(0)

                Try

                    For i = 0 To dgvProductsOutput.RowCount - 1
                        Dim idheaderdetails As Integer = 0
                        Try
                            idheaderdetails = dgvProductsOutput.Rows(i).Cells(5).Value
                        Catch ex As Exception
                            idheaderdetails = 0
                        End Try
                        _DT_Products.Rows.Add(dgvProductsOutput.Rows(i).Cells(0).Value, dgvProductsOutput.Rows(i).Cells(1).Value, dgvProductsOutput.Rows(i).Cells(2).Value, dgvProductsOutput.Rows(i).Cells(3).Value, _ID_Requisition_Header, dgvProductsOutput.Rows(i).Cells(5).Value, dgvProductsOutput.Rows(i).Cells(6).Value.ToString, dgvProductsOutput.Rows(i).Cells(7).Value.ToString)
                    Next
                Catch ex As Exception
                    Dim aaa As String = ""
                End Try
                If _Is_approval Then
                    Dim cantAbastecida As New DataGridViewTextBoxColumn
                    cantAbastecida.Name = "Cantidad Abastecida"
                    cantAbastecida.DataPropertyName = "SuppliedQuantity"
                    cantAbastecida.ReadOnly = True
                    cantAbastecida.DefaultCellStyle.Format = "N2"
                    cantAbastecida.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    cantAbastecida.Width = 120

                    Dim Observaciones As New DataGridViewTextBoxColumn
                    Observaciones.Name = "Observaciones"
                    Observaciones.DataPropertyName = "Comments"
                    Observaciones.ReadOnly = True
                    Observaciones.Width = 150
                    Observaciones.Visible = False

                    Dim Bodega As New DataGridViewTextBoxColumn
                    Bodega.Name = "Bodega"
                    Bodega.ReadOnly = True
                    Bodega.Width = 120

                    Dim Cod_Bodega As New DataGridViewTextBoxColumn
                    Cod_Bodega.Name = "Cod_Bodega"
                    Cod_Bodega.ReadOnly = True
                    Cod_Bodega.Width = 50
                    Cod_Bodega.Visible = False

                    Dim btn As New DataGridViewButtonColumn()
                    btn.HeaderText = "Editar"
                    btn.Text = "Editar"
                    btn.Name = "Editar"
                    btn.UseColumnTextForButtonValue = True

                    dgvProductsOutput.Columns.Add(cantAbastecida)
                    dgvProductsOutput.Columns.Add(Observaciones)
                    dgvProductsOutput.Columns.Add(Bodega)
                    dgvProductsOutput.Columns.Add(Cod_Bodega)
                    dgvProductsOutput.Columns.Add(btn)
                    'dgvProductsOutput.Columns.Add(Editar)

                    'dsDetails.Tables(0).Columns.Add("QuantitySupplied", Type.GetType("System.Int64"))
                    'dsDetails.Tables(0).Columns.Add("Observacion", Type.GetType("System.String"))
                    dgvProductsOutput.Enabled = True
                    dgvProductsOutput.Columns(1).Width = 100
                    dgvProductsOutput.Columns(3).Width = 100
                    dgvProductsOutput.Columns(5).Width = 150
                    dgvProductsOutput.Columns(6).Width = 140
                    dgvProductsOutput.Columns(7).Width = 100

                    For Each dgvRow As DataGridViewRow In dgvProductsOutput.Rows
                        dgvRow.Cells("Bodega").Value = cb_Catalog.Text
                        dgvRow.Cells("Cod_Bodega").Value = cb_Catalog.SelectedValue
                    Next dgvRow

                Else
                    'dgvProductsOutput.Enabled = False
                End If

                If (ReaperturarRequ = False) Then
                    cb_Catalog.Enabled = False
                    cb_Employee.Enabled = False
                    cb_departamento.Enabled = False
                    cb_RequisitionType.Enabled = False
                    EliminarToolStripMenuItem.Visible = False
                    AgregarToolStripMenuItem.Visible = False
                End If

                ' cmdAprobar.Location = New Point(314, 490)
                ' cmdDenegar.Location = New Point(200, 490)
                If _Is_approval Then
                    cmdAprobar.Visible = False
                    cmdDenegar.Visible = False
                    cmdSave.Visible = True
                Else
                    cmdSave.Visible = False
                    cmdCancel.Location = New System.Drawing.Point(630, 447)
                    'cmdCancel.Location = New Point(273, 513)
                End If
                If (ReaperturarRequ) Then
                    cmdAprobar.Visible = False
                    cmdDenegar.Visible = False
                    cmdModificar.Location = New System.Drawing.Point(450, 447)
                    cmdModificar.Text = "Modificar"
                    AgregarToolStripMenuItem.Visible = True
                    EliminarToolStripMenuItem.Visible = True
                    ModificarToolStripMenuItem.Visible = True
                    cmdModificar.Visible = True
                End If


            End Using
        Else
            cmdAprobar.Visible = False
            cmdDenegar.Visible = False
            AgregarToolStripMenuItem.Visible = True
            EliminarToolStripMenuItem.Visible = True
        End If
        If vista Then
            cmdModificar.Visible = False
            cb_Catalog.Enabled = False
            cb_departamento.Enabled = False
        End If

        If _SendAproved = True Then
            btnEnviarApro.Visible = True
            btnEnviarApro.Location = New System.Drawing.Point(760, 445)
            cmdModificar.Text = "Guardar y Salir"
        End If

        If _Abastecimiento Then
            dgvProductsOutput.MultiSelect = False
            cmdSave.Text = "Abastecer y Salir"
            dgvProductsOutput.AllowUserToDeleteRows = False
            dgvProductsOutput.AllowUserToAddRows = False
            dgvProductsOutput.AutoGenerateColumns = False

        End If

        If Is_Jefe = True Or Is_EncargadoBOdega = True Then
            btnEnviarApro.Visible = False
            cmdModificar.Visible = False

        End If

    End Sub



    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub




    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        If Not dgvProductsOutput.CurrentRow Is Nothing Then
            Dim ID As Long = dgvProductsOutput.CurrentRow.Cells("correlativo").Value
            Dim Producto As String = dgvProductsOutput.CurrentRow.Cells("product").Value
            If MessageBox.Show("¿Está seguro que desea eliminar el artículo: " & Producto, "Información", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
                For Each row As DataRow In _DT_Products.Rows
                    If Not row Is Nothing Then
                        If row("ID_Producto_FK") = ID Then
                            _DT_Products.Rows.Remove(row)
                            dgvProductsOutput.DataSource = _DT_Products
                            Exit For
                        End If
                    End If
                Next row
            End If
        End If
    End Sub

    Private Sub cb_Catalog_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_Catalog.SelectedIndexChanged
        'If Not cb_Catalog.SelectedIndex = -1 Then
        '    If cb_Catalog.SelectedValue = 5 Then
        '        Using obj As New ERP_Inventory_StowageAvailableTransfer
        '            obj.ID_Bodega = ID_Stowage
        '            If obj.ShowDialog = DialogResult.OK Then
        '                _ID_BodegaSalida = obj.ID_BodegaTransf
        '                _Name_BodegaSalida = obj.NameBodega
        '                lblDestino.Text = _Name_BodegaSalida
        '            End If
        '        End Using
        '    Else
        '        _ID_BodegaSalida = 0
        '        _Name_BodegaSalida = ""
        '        lblDestino.Text = ""
        '    End If
        'End If
    End Sub

    Private Sub cmdAprobar_Click(sender As Object, e As EventArgs) Handles cmdAprobar.Click
        If MessageBox.Show("Esta seguro de Aprobar la Requisición?", Application.CompanyName, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = vbOK Then
            Using objSQL As New Requisiciones_SQLServer
                Dim resp As String = objSQL.Inventory_ApproveRequisitions(_ID_Requisition_Header, 1, "")
                If resp = "1" Then
                    MessageBox.Show("Requisición aprobada exitosamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.DialogResult = DialogResult.OK
                    Me.Close()
                End If
            End Using
        End If
    End Sub

    Private Sub cmdDenegar_Click(sender As Object, e As EventArgs) Handles cmdDenegar.Click
        cmdAprobar.Enabled = False
        cmdDenegar.Enabled = False
        pnRechazo.Visible = True
    End Sub

    Private Sub cb_Employee_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cb_Employee.KeyPress
        If (abierto = 0) Then
            e.Handled = True
        End If
    End Sub

    Private Sub cb_Employee_DropDownClosed(sender As Object, e As EventArgs) Handles cb_Employee.DropDownClosed
        abierto = 1
    End Sub

    Private Sub cb_Employee_DropDown(sender As Object, e As EventArgs) Handles cb_Employee.DropDown
        abierto = 0
    End Sub

    Private Sub dgvProductsOutput_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProductsOutput.CellContentClick
        Dim senderGrid = DirectCast(sender, DataGridView)

        If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso
           e.RowIndex >= 0 Then
            If senderGrid.SelectedRows.Count = 1 Then
                Dim id As Long = senderGrid.SelectedRows(0).Cells("Id_Requisitions_Details").Value
                Dim dt As DataTable = CType(dgvProductsOutput.DataSource, DataTable)

                For Each row As DataRow In dt.Select("Id_Requisitions_Details=" & id.ToString)

                    Using obj As New EditarRequisicion
                        obj.rowActual = row
                        obj.bodega = ID_Stowage

                        obj.StartPosition = FormStartPosition.CenterParent
                        If obj.ShowDialog() = DialogResult.OK Then
                            Dim bodega = obj.ID_Stowage
                            Dim cantidadentregada = obj.cantidadentregada
                            Dim observacion = obj.observaciones
                            Dim Nombre_Bodega = obj.Name_Stowage

                            For Each dgvRow As DataGridViewRow In dgvProductsOutput.Rows
                                If dgvRow.Cells("Id_Requisitions_Details").Value = id Then

                                    ' dgvProductsOutput.Rows(0).Cells(5).Value =
                                    dgvRow.Cells("Cantidad Abastecida").Value = cantidadentregada
                                    dgvRow.Cells("Observaciones").Value = observacion
                                    dgvRow.Cells("Bodega").Value = Nombre_Bodega
                                    dgvRow.Cells("Cod_Bodega").Value = bodega

                                End If
                            Next dgvRow
                        End If
                    End Using
                Next
            End If
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

    Private Sub cmdModificar_Click(sender As Object, e As EventArgs) Handles cmdModificar.Click
        If MessageBox.Show("Esta seguro/a de modificar la requisición", Application.ProductName, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = vbOK Then
            If cb_Catalog.SelectedIndex = -1 Then
                MessageBox.Show("Seleccione una bodega, por favor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Exit Sub
            End If
            'If cb_RequisitionType.SelectedIndex = -1 Then
            '    MessageBox.Show("Selecione un tipo de Requisición, por favor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            '    Exit Sub
            'End If
            If cb_Employee.SelectedIndex = -1 Then
                MessageBox.Show("Selecione una persona, por favor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Exit Sub
            End If

            If dgvProductsOutput.RowCount = 0 Then
                MessageBox.Show("Tiene que seleccionar al menos un artículo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Exit Sub
            End If

            If dgvProductsOutput.Rows(0).Cells("cantidad").Value = 0 Then
                MessageBox.Show("Ingrese una cantidad de abastecimiento para este producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Exit Sub
            End If
            Dim ID_bodega As Long = cb_Catalog.SelectedValue

            Dim TipoRequisicion = cb_RequisitionType.SelectedValue
            Dim IdEmpleado As Long = cb_Employee.SelectedValue
            Dim Correlativo_Salida As Long = 0
            Dim resp As Integer = 0
            Dim Correlativo_SalidaInventario As Long = 0
            Dim Id_Department As Integer = cb_departamento.SelectedValue

            Correlativo_Salida = _ID_Requisition_Header

            Try
                Using ObjSQl As New Requisiciones_SQLServer
                    ' dgvProductsOutput.Rows(0).Cells(5).Value =
                    ObjSQl.ERP_Inventory_InsertRequisitionsDetailsDisabled(_ID_Requisition_Header)
                End Using
            Catch ex As Exception

            End Try

            If Correlativo_Salida > 0 Then
                Dim idheaderdet As Integer = 0
                For Each dgvRow As DataGridViewRow In dgvProductsOutput.Rows
                    If Not dgvRow Is Nothing Then
                        Using ObjSQl As New Requisiciones_SQLServer
                            ' dgvProductsOutput.Rows(0).Cells(5).Value =
                            Try
                                idheaderdet = dgvRow.Cells("Id_Requisitions_Details").Value.ToString
                            Catch ex As Exception
                                idheaderdet = 0
                            End Try
                            resp = ObjSQl.ERP_Inventory_InsertRequisitionsDetails(_ID_Requisition_Header.ToString, dgvRow.Cells("correlativo").Value.ToString, dgvRow.Cells("cantidad").Value.ToString, idheaderdet)
                        End Using
                    End If
                Next dgvRow

                If resp > 1 Then
                    MessageBox.Show("Requisición procesada exitosamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.DialogResult = DialogResult.OK
                    Me.Close()
                End If
            Else
                MessageBox.Show("Ocurrió un error al Procesar la Información, contacte a Soporte Técnico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If

    End Sub

    Private Sub ModificarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificarToolStripMenuItem.Click
        If dgvProductsOutput.Rows.Count > 0 Then

            Using objQuantity As New Financiero_DocumentoFiscalDigiteNumero
                objQuantity.GroupBox1.Text = "Cantidad Productos"
                objQuantity.StartPosition = FormStartPosition.CenterParent
                objQuantity.UnidadSend = dgvProductsOutput.SelectedRows.Item(0).Cells("TipoUnidad").Value
                objQuantity.NombreProducto = dgvProductsOutput.SelectedRows.Item(0).Cells("Product").Value
                If objQuantity.ShowDialog() = DialogResult.OK Then
                    _Quantity = objQuantity.NumeroFactura
                Else
                    Exit Sub
                End If
            End Using
            Try
                If dgvProductsOutput.SelectedRows.Item(0).Cells("Existencia_Producto").Value < _Quantity Then ' validamos la cantidad de salida del producto
                    MessageBox.Show("La cantidad solicitada no está disponible para la salida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    Exit Sub
                End If
                dgvProductsOutput.SelectedRows.Item(0).Cells("Cantidad").Value = _Quantity

            Catch ex As Exception

            End Try
        End If

    End Sub

    Private Sub cmdDenegarRequ_Click(sender As Object, e As EventArgs) Handles cmdDenegarRequ.Click
        If MessageBox.Show("Esta seguro de Denegar la Requisición?", Application.CompanyName, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = vbOK Then
            If (txtRechazo.Text.ToString = "") Then
                txtRechazo.Focus()
                MessageBox.Show("Debe ingresar una razón para el rechazo", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            Using objSQL As New Requisiciones_SQLServer
                Dim resp As String = objSQL.Inventory_ApproveRequisitions(_ID_Requisition_Header, 0, txtRechazo.Text.ToString)
                If resp = "1" Then
                    MessageBox.Show("Requisición denegada exitosamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    pnRechazo.Visible = False
                    Me.DialogResult = DialogResult.OK
                    Me.Close()
                End If
            End Using
            cmdAprobar.Enabled = True
            cmdDenegar.Enabled = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        cmdAprobar.Enabled = True
        cmdDenegar.Enabled = True
        pnRechazo.Visible = False
    End Sub

    Private Sub btnEnviarApro_Click(sender As Object, e As EventArgs) Handles btnEnviarApro.Click
        Try

            If (MessageBox.Show("¿Desea enviar la requisicion? No podra hacer ningun cambio", Application.ProductName, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK) Then

                Try
                    If Not _ID_Requisition_Header > 0 Then
                        cmdSave_Click(Nothing, Nothing)
                    End If
                Catch ex As Exception

                End Try
                If Correlativo_Salida > 0 Or _ID_Requisition_Header > 0 Then
                Using ObjSQl As New Requisiciones_SQLServer

                    Dim resp As Integer = 0

                        If Correlativo_Salida > 0 Then
                        resp = ObjSQl.ERP_Inventory_InsertRequisitionHeaderAproved(Correlativo_Salida)
                    Else
                        resp = ObjSQl.ERP_Inventory_InsertRequisitionHeaderAproved(_ID_Requisition_Header)
                    End If
                    If resp = 1 Then
                        MessageBox.Show("Requisicion Procesada correctamente", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.DialogResult = DialogResult.OK
                        Me.Close()
                    End If
                End Using
            End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgvProductsOutput_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles dgvProductsOutput.RowsAdded
        If _is_creation Then
            btnEnviarApro.Visible = True
        End If
    End Sub
#End Region
End Class