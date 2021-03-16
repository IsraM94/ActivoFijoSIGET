Public Class ERP_Inventory_DialogProductEntry

	Property ID_Stowage As Long = 0
	Property Name_Company As String = ""
    Property ID_Customer As Long = 0
    Property MostrarFinalizacion As Boolean = False
    Property UpdateDataEntrada As Boolean = False
    Property CerrarProceso As Boolean = False
    Property Id_HeaderUpdate As Integer = 0
    Property edicion As Boolean = True
    Property row As DataRow
    Private _IS_Result As Boolean = False
    Private _IS_IVA As Integer = 0
    Private _IS_IVA1 As String = ""
    Private _DT_Products As New DataTable
	Private _Quantity As Double = 0
	Private _Price As Double = 0
	Private _Total As Double = 0
    Private _UnidadMedidas As Long = 0
    Private _UnidadMedidas1 As String = ""
    Private _IS_Unitarios As Integer = 0
    Private _IS_Unitarios1 As String = ""
    Private _FechaVencimiento As Date = Now.Date
    Private _IS_GeneredAccountPayable As Boolean = False
    Private _TotalGeneral As Double = 0
    Private _ModalidadCompra As String = ""

    Private _DT_Catalog As New DataTable
    Property _DT_Entrada As New DataTable
    Property _DT_EntradaDetails As New DataTable
    '-----------------------------------------
    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
		Me.DialogResult = DialogResult.Cancel
		Me.Close()
	End Sub

	Private Sub AgregarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarToolStripMenuItem.Click
		If _IS_GeneredAccountPayable Then
			MessageBox.Show("La cuenta por pagar ya ha sido generada", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error)
			Exit Sub
		End If
        Using objAdd As New Generic_SeleccionarProducto
            objAdd.ShowPrice = True
            objAdd.StartPosition = FormStartPosition.CenterParent
            If objAdd.ShowDialog() = DialogResult.OK Then
                row = objAdd.rowSelection
                _IS_Result = True
            Else
                Exit Sub
            End If
        End Using

        Dim dt As New DataTable
		Using objsql As New Operaciones_SQLServer
			dt = objsql.ERP_Generic_GetConversionUnitProducts(row("Id_Product"))
		End Using

		If _IS_Result Then
			Using objQuantity As New ERP_Inventory_Dialog_Quantity
				objQuantity.StartPosition = FormStartPosition.CenterParent
                objQuantity.DT_Unit = dt
                objQuantity.NameProduct = row("Name_Product")
                If objQuantity.ShowDialog() = DialogResult.OK Then

                    _Price = objQuantity.Price
                    _Quantity = objQuantity.Quantity
                    _UnidadMedidas = objQuantity.ID_Unit
                    _UnidadMedidas1 = objQuantity.Unidad
                    _FechaVencimiento = objQuantity._FechaVencimiento.ToString("yyyy-MM-dd")

                    _IS_Unitarios1 = objQuantity.check1
                    _IS_IVA1 = objQuantity.CheckIVA1
                    _IS_Unitarios = objQuantity.Check
                    _IS_IVA = objQuantity.CheckIVA
                Else
                    Exit Sub
				End If
			End Using
		End If
        If _IS_Unitarios Then
            _Total = _Price * _Quantity
        Else
            _Price = _Price / _Quantity
            _Total = _Price * _Quantity
        End If

		Dim Exist As Boolean = False
		For Each rowP As DataRow In _DT_Products.Rows
			If Not rowP Is Nothing Then
				If rowP("ID_Product") = row("Id_Product") Then
					Exist = True
				End If
			End If
		Next rowP
		If Not row Is Nothing Then
            If Not Exist Then
                Dim TableTemp As New DataTable("Info")
                TableTemp = _DT_Products.Clone

                Try
                    TableTemp.Rows.Add(row("Id_Product"), row("number_purchase"), row("Name_Product"), _Quantity, _Price, _Total, _UnidadMedidas, _UnidadMedidas1, _IS_Unitarios, _IS_IVA, _IS_Unitarios1, _IS_IVA1, _FechaVencimiento.ToString("dd-MM-yyyy"), row("Stock"))

                Catch ex As Exception
                    Try
                        TableTemp.Rows.Add(row("Id_Product"), row("number_purchase"), row("Name_Product"), _Quantity, _Price, _Total, _UnidadMedidas, _UnidadMedidas1, _IS_Unitarios, _FechaVencimiento.ToString("dd-MM-yyyy"), row("Stock"))

                    Catch ex2 As Exception

                    End Try
                End Try
                TableTemp.Merge(_DT_Products)
                _DT_Products = TableTemp
                dgvProducts.DataSource = _DT_Products
                dgvProducts.Columns(6).Visible = False
                dgvProducts.Columns(8).Visible = False
                dgvProducts.Columns(9).Visible = False
            Else
                MessageBox.Show("El producto que trata de ingresar ya existe en esta factura", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
			End If
		End If


		_Price = 0
		_Quantity = 0
		_Total = 0
	End Sub

    Private Sub LoadCatalog()
        Using objSQL As New Operaciones_SQLServer
            _DT_Catalog = objSQL.SP_ERP_Inventory_GetOutletCatalogFiltro(_ID_Company, 1) 'Se envia 1 indicando Entradas
        End Using
        If Not _DT_Catalog Is Nothing Then
            If _DT_Catalog.Rows.Count > 0 Then
                cb_Catalog.DataSource = _DT_Catalog
                cb_Catalog.ValueMember = "ID_Outlet"
                cb_Catalog.DisplayMember = "Name_Outlet"
                cb_Catalog.SelectedIndex = -1
            End If
        End If
    End Sub

    Private Sub ERP_Inventory_DialogProductEntry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		txtEmpresa.Text = Name_Company
        _DT_Products.Columns.Add("ID_Product", Type.GetType("System.Int64"))
        _DT_Products.Columns.Add("Barra", Type.GetType("System.String"))
        _DT_Products.Columns.Add("Name_Product", Type.GetType("System.String"))
        _DT_Products.Columns.Add("Cantidad", Type.GetType("System.Int32"))
        _DT_Products.Columns.Add("PrecioUnitario", Type.GetType("System.Double"))
		_DT_Products.Columns.Add("Total", Type.GetType("System.Double"))
        _DT_Products.Columns.Add("UnidadMedida", Type.GetType("System.Int64"))
        _DT_Products.Columns.Add("Unidad de Medida", Type.GetType("System.String"))
        _DT_Products.Columns.Add("IS_Unitario", Type.GetType("System.Int32"))
        _DT_Products.Columns.Add("IS_IVA", Type.GetType("System.Int32"))
        _DT_Products.Columns.Add("Es Unitario", Type.GetType("System.String"))
        _DT_Products.Columns.Add("Incluye IVA", Type.GetType("System.String"))
        _DT_Products.Columns.Add("FechaVencimiento", Type.GetType("System.String"))
        _DT_Products.Columns.Add("Stock", Type.GetType("System.Int64"))

        dgvProducts.Font = New Font("Segoe UI", 11)
        LoadCatalog()
        dgvProducts.DataSource = _DT_Products
        ' dgvProducts.Columns(5).Visible = False
        dgvProducts.Columns(7).Visible = False
        dgvProducts.Columns(8).Visible = False
        dgvProducts.Columns(7).Width = 150
        dgvProducts.Columns(12).Width = 150
        Try
            If (_DT_Entrada.Rows.Count > 0) Then
                For Each data As DataRow In _DT_Entrada.Rows
                    txtEmpresa.Text = data("Proveedor")
                    dtpInvoiceDate.Value = data("InvoiceDate").ToString
                    txtNumeroFactura.Text = data("InvoiceNumber").ToString
                    MostrarData(CB_TipoCompra, data("tipoCompra").ToString)
                    MostrarData(CB_ModalidadCompra, data("ModalidadCompra").ToString)
                    MostrarData(cb_Catalog, data("Name_Outlet").ToString)
                    txtOrdenCompras.Text = data("PurchaseOrders".ToString)
                    txtLot.Text = data("Number_Lot")
                    MostrarData(CB_FormaPago, data("WayToPay"))
                Next
            End If

            If (_DT_EntradaDetails.Rows.Count > 0) Then
                btnCerrarEntrada.Visible = True
                dgvProducts.DataSource = _DT_EntradaDetails
                dgvProducts.Columns(6).Visible = False
                dgvProducts.Columns(8).Visible = False
                dgvProducts.Columns(9).Visible = False
                _DT_Products = _DT_EntradaDetails
            End If
        Catch ex As Exception

        End Try

        If edicion = False Then
            txtEmpresa.Enabled = False
            dtpInvoiceDate.Enabled = False
            CB_TipoCompra.Enabled = False
            CB_ModalidadCompra.Enabled = False
            txtNumeroFactura.Enabled = False
            cb_Catalog.Enabled = False
            txtOrdenCompras.Enabled = False
            txtLot.Enabled = False
            dtpExpirationDate.Enabled = False
            CB_FormaPago.Enabled = False
            AgregarToolStripMenuItem.Visible = False
            EliminarToolStripMenuItem.Visible = False
            ModificarToolStripMenuItem.Visible = False
            cmdSave.Enabled = False
            btnCerrarEntrada.Enabled = False

        End If

        If MOstrarFinalizacion Then
            btnCerrarEntrada.Visible = True
        End If

        If CerrarProceso Then
            btnCerrarEntrada_Click(Nothing, Nothing)

        End If
    End Sub

    Private Sub MostrarData(ByVal combo As ComboBox, ByVal data As String)
        Dim cont As Integer = 0
        Try
            For Each Datacombo As String In combo.Items
                If (Datacombo = data) Then
                    combo.SelectedIndex = cont
                    Exit For
                End If
            Next
            cont += 1
        Catch ex As Exception
            Try
                cont = 0
                For i As Integer = 0 To combo.Items.Count
                    If (combo.Items(i).item(2) = data) Then
                        combo.SelectedIndex = cont
                        Exit For
                    End If
                    cont += 1
                Next
            Catch ex2 As Exception

            End Try
        End Try
    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click

        If (txtEmpresa.Text.ToString.Trim = "") Then
            MessageBox.Show("Por favor ingrese el nombre de la Empresa", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If

        If cb_Catalog.SelectedIndex = -1 Then
            MessageBox.Show("Por favor seleccione el tipo de entrada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If
        If Not dgvProducts.RowCount > 0 Then
            MessageBox.Show("Por favor agregue los productos a guardar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If

        If txtNumeroFactura.Text.Trim = "" Then
			MessageBox.Show("Por favor ingrese el número de factura", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
			txtNumeroFactura.Select()
			Exit Sub
		End If
        'If Not IsNumeric(txtNumeroFactura.Text.Trim) Then
        '	MessageBox.Show("Por favor ingrese el número de factura", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        '	txtNumeroFactura.Select()
        '	Exit Sub
        'End If

        'If CB_FormaPago.SelectedIndex = -1 Then
        '    MessageBox.Show("Por favor seleccione la forma de pago", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        '    Exit Sub
        'End If
        If CB_TipoCompra.SelectedIndex = -1 Then
            MessageBox.Show("Por favor seleccione un tipo de compra", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If

        If CB_ModalidadCompra.SelectedIndex = -1 Then
            MessageBox.Show("Por favor seleccione una Modalidad de Compra", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If

        If CB_TipoCompra.SelectedIndex = 0 Then
            If txtOrdenCompras.Text.Trim = "" Then
                MessageBox.Show("Por favor ingrese el número orden de compras", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                txtNumeroFactura.Select()
                Exit Sub
            End If
        End If


        '---------------------------------------------------------
        Dim resp As Integer = 0
        '---------------------------------------------------------
        Dim InvoiceNumber As String = txtNumeroFactura.Text.Trim
		Dim InvoiceDate As Date = dtpInvoiceDate.Text.Trim
        Dim WayToPay As String = CB_FormaPago.Text

        '----------------------------------------------------------
        Dim ID_Producto As Long = 0
		Dim Cantidad As Double = 0
		Dim Price As Double = 0
		Dim UnidadMedida As Long = 0
        Dim IS_Unitario As Integer = 0
        Dim IS_IVA As Integer = 0
        Dim ID_Entry As Long = 0
        ID_Entry = cb_Catalog.SelectedValue
        '----------------------------------------------------------
        REM generar encabezado de entrada
        Dim ID_Header As Long = 0
        Dim ID_Lot As Long = 0
        Dim NumberLot As String = txtLot.Text.Trim
        Dim ExpirationDate As Date = dtpExpirationDate.Value
        Dim tipoCompra As String = CB_TipoCompra.Text
        _ModalidadCompra = CB_ModalidadCompra.Text

        Dim Ordencompras As Long
        Try
            Ordencompras = txtOrdenCompras.Text
        Catch ex As Exception
            Ordencompras = 0
        End Try


        Using objSQL As New Operaciones_SQLServer

            ID_Lot = objSQL.SP_ERP_Inventory_InsertLot(NumberLot, ExpirationDate, ID_Stowage, UpdateDataEntrada)

            If (ID_Lot <= 0) Then
                MessageBox.Show("El lote ya esta registrado, por favor intente con otro", "Información", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Exit Sub
            End If
            ID_Header = objSQL.SP_ERP_Inventory_Add_InventoryHeader(_ID_Company, ID_Customer, ID_Stowage, InvoiceNumber, WayToPay, InvoiceDate, 0, ID_Lot,
                                                                    ID_Entry, Ordencompras, tipoCompra, _ModalidadCompra, UpdateDataEntrada, Id_HeaderUpdate
                                                                    )
        End Using

        '----------------------------------------------------------
        If ID_Header > 0 Then
            For Each dgvrow As DataGridViewRow In dgvProducts.Rows
                If Not dgvrow Is Nothing Then
                    Using ObjSQL As New Operaciones_SQLServer
                        ID_Producto = dgvrow.Cells("correlativo").Value
                        Cantidad = dgvrow.Cells("Cantidad").Value
                        Price = dgvrow.Cells("PrecioUnitario").Value
                        UnidadMedida = dgvrow.Cells("UnidadMedida").Value
                        _FechaVencimiento = dgvrow.Cells("FechaVencimiento").Value
                        If dgvrow.Cells("IS_Unitario").Value Then
                            IS_Unitario = 1
                        End If
                        If dgvrow.Cells("IS_IVA").Value Then
                            IS_IVA = 1
                        End If

                        resp = ObjSQL.SP_ERP_Inventory_Add_InventoryTemp(ID_Header, ID_Producto, ID_Stowage, Cantidad, Price, UnidadMedida, IS_Unitario, IS_IVA, ID_Lot, _FechaVencimiento)
                    End Using
                End If
                IS_Unitario = 0
                IS_IVA = 0
            Next dgvrow
        End If
		_TotalGeneral = CalculateSaldoDeudor()

        'If WayToPay.ToUpper = "CREDITO" Then REM Si el tipo de pago es credito se Genera una cuenta por pagar
        '          If Not _IS_GeneredAccountPayable Then
        '		Using objAccount As New ERP_Inventory_Dialog_ConfigureAccountPayable
        '			objAccount.Id_Customer = ID_Customer
        '			objAccount.NumberFactura = InvoiceNumber
        '			objAccount.MontoTotal = _TotalGeneral
        '			If objAccount.ShowDialog() Then
        '				_IS_GeneredAccountPayable = True
        '			End If
        '		End Using
        '	End If
        'End If
        '---------------------------------------------------------
        If resp = 1 Then
            MessageBox.Show("Entranda guardada en historial pendiente de cerrar", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.DialogResult = DialogResult.OK
            Me.Close()
        Else
            MessageBox.Show("Ocurrió un error al realizar la entrada de inventario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
		End If

	End Sub

    Private Function CalculateSaldoDeudor() As Double
        Dim Total As Double = 0
        For Each row As DataRow In _DT_Products.Rows
            If Not row Is Nothing Then
                Total += row("Total")
            End If
        Next row
        Return Total
    End Function
    Private Sub cmdAccountPayable_Click(sender As Object, e As EventArgs)
        _TotalGeneral = CalculateSaldoDeudor()
        Dim InvoiceNumber As String = txtNumeroFactura.Text.Trim
        If Not _IS_GeneredAccountPayable Then
            Using objAccount As New ERP_Inventory_Dialog_ConfigureAccountPayable
                objAccount.Id_Customer = ID_Customer
                objAccount.NumberFactura = InvoiceNumber
                objAccount.MontoTotal = _TotalGeneral
                If objAccount.ShowDialog() Then
                    _IS_GeneredAccountPayable = True
                End If
            End Using
        End If

    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
		If Not dgvProducts.CurrentRow Is Nothing Then
			Dim ID As Long = dgvProducts.CurrentRow.Cells("correlativo").Value
			Dim Producto As String = dgvProducts.CurrentRow.Cells("product").Value
            If MessageBox.Show("¿Está seguro que desea eliminar el artículo: " & Producto, "Información", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
                Try
                    For Each row As DataRow In _DT_Products.Rows
                        If Not row Is Nothing Then
                            If row("ID_Product") = ID Then
                                _DT_Products.Rows.Remove(row)
                                dgvProducts.DataSource = _DT_Products
                                Exit For
                            End If
                        End If
                    Next row
                Catch ex As System.InvalidOperationException
                    ' No hace nada
                End Try

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

    Private Sub CB_TipoCompra_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_TipoCompra.SelectedIndexChanged
        If CB_TipoCompra.SelectedIndex = 0 Or CB_TipoCompra.SelectedIndex = 2 Then
            txtOrdenCompras.Enabled = True
        Else

            txtOrdenCompras.Enabled = False

        End If

    End Sub

    Private Sub btnCerrarEntrada_Click(sender As Object, e As EventArgs) Handles btnCerrarEntrada.Click

        If (MessageBox.Show(" ¿Desea cerrar proceso?, no podra hacer mas cambios para esta entrada", Application.ProductName, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK) Then

            If (txtEmpresa.Text.ToString.Trim = "") Then
                MessageBox.Show("Por favor ingrese el nombre de la Empresa", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Exit Sub
            End If

            If cb_Catalog.SelectedIndex = -1 Then
                MessageBox.Show("Por favor seleccione el tipo de entrada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Exit Sub
            End If
            If Not dgvProducts.RowCount > 0 Then
                MessageBox.Show("Por favor agregue los productos a guardar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Exit Sub
            End If

            If txtNumeroFactura.Text.Trim = "" Then
                MessageBox.Show("Por favor ingrese el número de factura", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                txtNumeroFactura.Select()
                Exit Sub
            End If

            If CB_TipoCompra.SelectedIndex = -1 Then
                MessageBox.Show("Por favor seleccione un tipo de compra", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Exit Sub
            End If

            If CB_ModalidadCompra.SelectedIndex = -1 Then
                MessageBox.Show("Por favor seleccione una Modalidad de Compra", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Exit Sub
            End If

            If CB_TipoCompra.SelectedIndex = 0 Then
                If txtOrdenCompras.Text.Trim = "" Then
                    MessageBox.Show("Por favor ingrese el número orden de compras", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    txtNumeroFactura.Select()
                    Exit Sub
                End If
            End If


            '---------------------------------------------------------
            Dim resp As Integer = 0
            '---------------------------------------------------------
            Dim InvoiceNumber As String = txtNumeroFactura.Text.Trim
            Dim InvoiceDate As Date = dtpInvoiceDate.Text.Trim
            Dim WayToPay As String = CB_FormaPago.Text

            '----------------------------------------------------------
            Dim ID_Producto As Long = 0
            Dim Cantidad As Double = 0
            Dim Price As Double = 0
            Dim UnidadMedida As Long = 0
            Dim IS_Unitario As Integer = 0
            Dim IS_IVA As Integer = 0
            Dim ID_Entry As Long = 0
            ID_Entry = cb_Catalog.SelectedValue
            '----------------------------------------------------------
            REM generar encabezado de entrada
            Dim ID_Header As Long = 0
            Dim ID_Lot As Long = 0
            Dim NumberLot As String = txtLot.Text.Trim
            Dim ExpirationDate As Date = dtpExpirationDate.Value
            Dim tipoCompra As String = CB_TipoCompra.Text
            _ModalidadCompra = CB_ModalidadCompra.Text

            Dim Ordencompras As Long
            Try
                Ordencompras = txtOrdenCompras.Text
            Catch ex As Exception
                Ordencompras = 0
            End Try


            Using objSQL As New Operaciones_SQLServer
                ID_Lot = objSQL.SP_ERP_Inventory_InsertLot(NumberLot, ExpirationDate, ID_Stowage, UpdateDataEntrada)
                If (ID_Lot <= 0) Then
                    MessageBox.Show("El lote ya esta registrado, por favor intente con otro", "Información", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    Exit Sub
                End If
                ID_Header = objSQL.SP_ERP_Inventory_Add_InventoryHeader(_ID_Company, ID_Customer, ID_Stowage, InvoiceNumber, WayToPay, InvoiceDate, 0, ID_Lot, ID_Entry,
                                                                        Ordencompras, tipoCompra, _ModalidadCompra, UpdateDataEntrada, Id_HeaderUpdate, 1)
            End Using

            '----------------------------------------------------------
            If ID_Header > 0 Then
                For Each dgvrow As DataGridViewRow In dgvProducts.Rows
                    If Not dgvrow Is Nothing Then
                        Using ObjSQL As New Operaciones_SQLServer
                            ID_Producto = dgvrow.Cells("correlativo").Value
                            Cantidad = dgvrow.Cells("Cantidad").Value
                            Price = dgvrow.Cells("PrecioUnitario").Value
                            UnidadMedida = dgvrow.Cells("UnidadMedida").Value
                            _FechaVencimiento = dgvrow.Cells("FechaVencimiento").Value
                            If dgvrow.Cells("IS_Unitario").Value Then
                                IS_Unitario = 1
                            End If
                            If dgvrow.Cells("IS_IVA").Value Then
                                IS_IVA = 1
                            End If

                            resp = ObjSQL.SP_ERP_Inventory_Add_Inventory(ID_Header, ID_Producto, ID_Stowage, Cantidad, Price, UnidadMedida, IS_Unitario, IS_IVA, ID_Lot, _FechaVencimiento)
                        End Using
                    End If
                    IS_Unitario = 0
                    IS_IVA = 0
                Next dgvrow
            End If
            Using obj As New Operaciones_SQLServer
                resp = obj.SP_ERP_Inventory_CleanData(ID_Header)
            End Using
            _TotalGeneral = CalculateSaldoDeudor()

            'If WayToPay.ToUpper = "CREDITO" Then REM Si el tipo de pago es credito se Genera una cuenta por pagar
            '    If Not _IS_GeneredAccountPayable Then
            '        Using objAccount As New ERP_Inventory_Dialog_ConfigureAccountPayable
            '            objAccount.Id_Customer = ID_Customer
            '            objAccount.NumberFactura = InvoiceNumber
            '            objAccount.MontoTotal = _TotalGeneral
            '            If objAccount.ShowDialog() Then
            '                _IS_GeneredAccountPayable = True
            '            End If
            '        End Using
            '    End If
            'End If
            '---------------------------------------------------------
            If resp = 1 Then
                MessageBox.Show("Ingreso de inventario realizado exitosamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Dim dt As New DataTable
                Using objSQLBodega As New Operaciones_SQLServer
                    dt = objSQLBodega.ERP_Inventory_GetProducts_Stowage(Data_Id_Company, ID_Header)
                End Using

                Using objPartidaContable As New Financiero_ReportViewer(dt, "DSBodegasOperaciones", "epd_SatelliteERP.Reports_InventoryEntryProduct.rdlc")
                    objPartidaContable.ShowDialog()
                End Using
                Me.DialogResult = DialogResult.OK
                Me.Close()

            Else
                MessageBox.Show("Ocurrió un error al realizar la entrada de inventario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
            End If
        End If
    End Sub

    Private Sub ModificarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificarToolStripMenuItem.Click
        If dgvProducts.Rows.Count > 0 Then

            Using objQuantity As New Financiero_DocumentoFiscalDigiteNumero
                objQuantity.GroupBox1.Text = "Cantidad Productos"
                objQuantity.StartPosition = FormStartPosition.CenterParent
                objQuantity.UnidadSend = dgvProducts.SelectedRows.Item(0).Cells("Unidad de Medida").Value
                objQuantity.NombreProducto = dgvProducts.SelectedRows.Item(0).Cells("Product").Value
                If objQuantity.ShowDialog() = DialogResult.OK Then
                    _Quantity = objQuantity.NumeroFactura
                Else
                    Exit Sub
                End If
            End Using
            Try
                'If dgvProducts.SelectedRows.Item(0).Cells("Stock").Value < _Quantity Then ' validamos la cantidad de salida del producto
                '    MessageBox.Show("La cantidad solicitada no está disponible para la salida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                '    Exit Sub
                'End If

                _Price = dgvProducts.SelectedRows.Item(0).Cells("PrecioUnitario").Value
                If dgvProducts.SelectedRows.Item(0).Cells("IS_Unitario").Value Then
                    _Total = _Price * _Quantity
                Else
                    _Price = dgvProducts.SelectedRows.Item(0).Cells("Total1").Value
                    _Price = _Price / dgvProducts.SelectedRows.Item(0).Cells("Cantidad").Value
                    _Total = _Price * _Quantity
                End If

                dgvProducts.SelectedRows.Item(0).Cells("Cantidad").Value = _Quantity
                dgvProducts.SelectedRows.Item(0).Cells("Total1").Value = _Total
            Catch ex As Exception

            End Try
        End If
    End Sub

#End Region
End Class