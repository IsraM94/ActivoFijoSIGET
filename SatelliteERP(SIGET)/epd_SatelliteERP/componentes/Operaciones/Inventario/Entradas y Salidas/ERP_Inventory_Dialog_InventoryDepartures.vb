Public Class ERP_Inventory_Dialog_InventoryDepartures
    Private _DT_Catalog As New DataTable
    Property ID_Stowage As Long = 0
    Private _DT_Products As New DataTable
    Property _DtProductsOutput As DataTable
    Property ComentarioSalida As String = ""
    Property TipoSalida As String = ""
    Property IdHeaderSalida As Integer = 0
    Property AprobarSalida As Boolean = False
    Property EstadoSalida As String = ""

    Private NombreProducto As String = ""
    Private UnidadMedida As String = ""

    Private _IS_Result As Boolean = False
    Private row As DataRow = Nothing
    Private _Quantity As Double = 0
    Private _ID_BodegaSalida As Long = 0
    Private _Name_BodegaSalida As String

    Private Sub LoadCatalog()
        Using objSQL As New Operaciones_SQLServer
            _DT_Catalog = objSQL.SP_ERP_Inventory_GetOutletCatalogFiltro(_ID_Company, 0) 'Se envia 0 indicando salidas
        End Using
        If Not _DT_Catalog Is Nothing Then
            If _DT_Catalog.Rows.Count > 0 Then
                RemoveHandler cb_Catalog.SelectedIndexChanged, AddressOf cb_Catalog_SelectedIndexChanged
                cb_Catalog.DataSource = _DT_Catalog
                cb_Catalog.ValueMember = "ID_Outlet"
                cb_Catalog.DisplayMember = "Name_Outlet"
                cb_Catalog.SelectedIndex = -1
                AddHandler cb_Catalog.SelectedIndexChanged, AddressOf cb_Catalog_SelectedIndexChanged
            End If
        End If
    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        If cb_Catalog.SelectedIndex = -1 Then
            MessageBox.Show("Seleccione un tipo de salida para los productos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If
        If txtComentarios.Text.Trim = "" Then
            MessageBox.Show("Por favor ingrese un comentario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            txtComentarios.Select()
            Exit Sub
        End If
        If dgvProductsOutput.RowCount = 0 Then
            MessageBox.Show("Seleccione al menos un producto para la salida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If
        Dim ID_Catalog As Long = cb_Catalog.SelectedValue
        Dim Comentario As String = txtComentarios.Text.Trim
        Dim Correlativo_Salida As Long = 0
        Dim resp As Integer = 0
        Using ObjSQl As New Operaciones_SQLServer
            If Not ID_Catalog = 5 Then
                Correlativo_Salida = ObjSQl.SP_ERP_Inventory_Output_InventoryHeader(ID_Stowage, ID_Catalog, Comentario, IdHeaderSalida)
            Else
                If _ID_BodegaSalida = 0 Then
                    MessageBox.Show("Seleccione la bodega para la salida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    Exit Sub
                End If
                Correlativo_Salida = ObjSQl.SP_ERP_Inventory_Output_InventoryHeaderBodega(ID_Stowage, ID_Catalog, Comentario, _ID_BodegaSalida, IdHeaderSalida)
            End If
        End Using

        If Correlativo_Salida > 0 Then
            For Each dgvRow As DataGridViewRow In dgvProductsOutput.Rows
                If Not dgvRow Is Nothing Then
                    Using ObjSQl As New Operaciones_SQLServer
                        resp = ObjSQl.SP_ERP_Inventory_Output_InventoryDetailsTemp(_ID_Company, Correlativo_Salida, ID_Stowage, dgvRow.Cells("Id_Product").Value, dgvRow.Cells("cantidad").Value)
                    End Using
                End If
            Next dgvRow

            If resp = 1 Then
                MessageBox.Show("Salida procesada exitosamente, Se envió a Aprobación.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.DialogResult = DialogResult.OK
                Me.Close()
            End If
        Else
            MessageBox.Show("Ocurrió un error al agregar el encabezado de la salida, contacte a Soporte Técnico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub AgregarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarToolStripMenuItem.Click
        Using objAdd As New Generic_SeleccionarProducto
            objAdd.ID_Stowage = ID_Stowage
            objAdd.IS_Bodega = True
            objAdd.StartPosition = FormStartPosition.CenterParent
            If objAdd.ShowDialog() = DialogResult.OK Then
                row = objAdd.rowSelection
                NombreProducto = row("Name_Product")
                UnidadMedida = row("Name_UnitMeasure")
                _IS_Result = True
            Else
                Exit Sub
            End If
        End Using
        If _IS_Result Then
            Using objQuantity As New Financiero_DocumentoFiscalDigiteNumero
                objQuantity.GroupBox1.Text = "Cantidad Productos"
                objQuantity.StartPosition = FormStartPosition.CenterParent
                objQuantity.NombreProducto = NombreProducto
                objQuantity.UnidadSend = UnidadMedida
                If objQuantity.ShowDialog() = DialogResult.OK Then
                    _Quantity = objQuantity.NumeroFactura
                Else
                    Exit Sub
                End If
            End Using
        End If
        If Not row Is Nothing Then
            If row("Stock") < _Quantity Then ' validamos la cantidad de salida del producto
                MessageBox.Show("La cantidad solicitada no está disponible para la salida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Exit Sub
            End If

            Dim Exist As Boolean = False
            For Each rowP As DataRow In _DT_Products.Rows
                If Not rowP Is Nothing Then
                    If rowP("ID_Product") = row("Id_Product") Then
                        Exist = True
                        Exit For
                    End If
                End If
            Next rowP
            If Not Exist Then
                Dim temp As New DataTable
                temp = _DT_Products.Clone
                temp.Rows.Clear()

                temp.Rows.Add(row("Id_Product"), row("Number_Purchase"), row("Name_Product"), _Quantity, row("Stock"))
                temp.Merge(_DT_Products)
                _DT_Products = temp
                dgvProductsOutput.DataSource = _DT_Products
            Else
                MessageBox.Show("El producto que trata de ingresar ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            End If
        End If

        _Quantity = 0
    End Sub

    Private Sub ERP_Inventory_Dialog_InventoryDepartures_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _DT_Products.Columns.Add("ID_Product", Type.GetType("System.Int64"))
        _DT_Products.Columns.Add("Number_Purchase", Type.GetType("System.String"))
        _DT_Products.Columns.Add("Name_Product", Type.GetType("System.String"))
        _DT_Products.Columns.Add("Cantidad", Type.GetType("System.Double"))
        _DT_Products.Columns.Add("Stock", Type.GetType("System.Int64"))
        LoadCatalog()
        Try
            If (_DtProductsOutput.Rows.Count > 0) Then
                _DT_Products = _DtProductsOutput
                txtComentarios.Text = ComentarioSalida
                cb_Catalog.SelectedText = TipoSalida
                Dim num As Integer = 0
                For Each item As Object In cb_Catalog.Items

                    Dim row As DataRowView = DirectCast(item, DataRowView)

                    If CStr(item("Name_Outlet")) = TipoSalida Then
                        cb_Catalog.SelectedIndex = num
                        Exit For
                    End If
                    num += 1
                Next
            End If
        Catch ex As Exception

        End Try
        dgvProductsOutput.DataSource = _DT_Products
        dgvProductsOutput.Font = New Font("Segoe UI", 11)
        If AprobarSalida Then
            cmdAprobar.Visible = True
            cmdRechazar.Visible = True
            cmdAprobar.Location = New System.Drawing.Point(200, 490)
            cmdRechazar.Location = New System.Drawing.Point(310, 490)
            btnEmviarApro.Visible = False
            cmdSave.Visible = False
        Else

        End If

        If EstadoSalida = "Aprobado" Or EstadoSalida = "Denegado" Then
            cmdRechazar.Visible = False
            cmdAprobar.Visible = False
            btnEmviarApro.Visible = False
            cmdSave.Visible = False
            cb_Catalog.Enabled = False
            Menu.Visible = False
            AgregarToolStripMenuItem.Visible = False
            EliminarToolStripMenuItem.Visible = False
            ModificarToolStripMenuItem.Visible = False
            txtComentarios.Enabled = False
        ElseIf EstadoSalida = "En Revisión" Then
            btnEmviarApro.Visible = False
            cmdSave.Visible = False
            cmdSave.Visible = False
            cb_Catalog.Enabled = False
            AgregarToolStripMenuItem.Visible = False
            EliminarToolStripMenuItem.Visible = False
            ModificarToolStripMenuItem.Visible = False
            Menu.Visible = False
            txtComentarios.Enabled = False
        ElseIf EstadoSalida = "En Proceso" And AprobarSalida = False Then
            btnEmviarApro.Visible = True
            cmdSave.Visible = True
        ElseIf EstadoSalida = "Nuevo" Then
            btnEmviarApro.Visible = True
        End If
        Try
            dgvProductsOutput.Columns(5).Visible = False
        Catch ex As Exception

        End Try
        Try
            dgvProductsOutput.Columns(4).Visible = False
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        If Not dgvProductsOutput.CurrentRow Is Nothing Then
            Dim ID As Long = dgvProductsOutput.CurrentRow.Cells("Id_Product").Value
            Dim Producto As String = dgvProductsOutput.CurrentRow.Cells("product").Value
            If MessageBox.Show("¿Está seguro que desea eliminar el artículo: " & Producto & "&", "Información", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
                For Each row As DataRow In _DT_Products.Rows
                    If Not row Is Nothing Then
                        If row("ID_Product") = ID Then
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
        If Not cb_Catalog.SelectedIndex = -1 Then
            If cb_Catalog.SelectedValue = 5 Then
                Using obj As New ERP_Inventory_StowageAvailableTransfer
                    obj.ID_Bodega = ID_Stowage
                    If obj.ShowDialog = DialogResult.OK Then
                        _ID_BodegaSalida = obj.ID_BodegaTransf
                        _Name_BodegaSalida = obj.NameBodega
                        lblDestino.Text = _Name_BodegaSalida
                    End If
                End Using
            Else
                _ID_BodegaSalida = 0
                _Name_BodegaSalida = ""
                lblDestino.Text = ""
            End If
        End If
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

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

    Private Sub btnEmviarApro_Click(sender As Object, e As EventArgs) Handles btnEmviarApro.Click
        Try
            Dim Correlativo_Salida As Long = 0
            If MessageBox.Show("Esta seguro de enviar a Aprobación?", Application.CompanyName, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then

                If cb_Catalog.SelectedIndex = -1 Then
                    MessageBox.Show("Seleccione un tipo de salida para los productos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    Exit Sub
                End If
                If txtComentarios.Text.Trim = "" Then
                    MessageBox.Show("Por favor ingrese un comentario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    txtComentarios.Select()
                    Exit Sub
                End If
                If dgvProductsOutput.RowCount = 0 Then
                    MessageBox.Show("Seleccione al menos un producto para la salida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    Exit Sub
                End If
                If IdHeaderSalida <= 0 Then
                    Dim ID_Catalog As Long = cb_Catalog.SelectedValue
                    Dim Comentario As String = txtComentarios.Text.Trim

                    Dim resp As Integer = 0
                    Using ObjSQl As New Operaciones_SQLServer
                        If Not ID_Catalog = 5 Then
                            Correlativo_Salida = ObjSQl.SP_ERP_Inventory_Output_InventoryHeader(ID_Stowage, ID_Catalog, Comentario, IdHeaderSalida)
                        Else
                            If _ID_BodegaSalida = 0 Then
                                MessageBox.Show("Seleccione la bodega para la salida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                                Exit Sub
                            End If
                            Correlativo_Salida = ObjSQl.SP_ERP_Inventory_Output_InventoryHeaderBodega(ID_Stowage, ID_Catalog, Comentario, _ID_BodegaSalida, IdHeaderSalida)
                        End If
                    End Using

                    If Correlativo_Salida > 0 Then
                        For Each dgvRow As DataGridViewRow In dgvProductsOutput.Rows
                            If Not dgvRow Is Nothing Then
                                Using ObjSQl As New Operaciones_SQLServer
                                    resp = ObjSQl.SP_ERP_Inventory_Output_InventoryDetailsTemp(_ID_Company, Correlativo_Salida, ID_Stowage, dgvRow.Cells("Id_Product").Value, dgvRow.Cells("cantidad").Value)
                                End Using
                            End If
                        Next dgvRow
                    Else
                        MessageBox.Show("Ocurrió un error al agregar el encabezado de la salida, contacte a Soporte Técnico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                    IdHeaderSalida = Correlativo_Salida
                End If
                If IdHeaderSalida > 0 Then
                    Using ObjSQl As New Operaciones_SQLServer
                        ObjSQl.SP_ERP_Inventory_Output_Aproved(ID_Stowage, IdHeaderSalida)
                    End Using
                    Me.DialogResult = DialogResult.OK
                    Me.Close()
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmdAprobar_Click(sender As Object, e As EventArgs) Handles cmdAprobar.Click
        Try
            If MessageBox.Show("Esta seguro de Aprobar la Salida?", Application.CompanyName, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
                If cb_Catalog.SelectedIndex = -1 Then
                    MessageBox.Show("Seleccione un tipo de salida para los productos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    Exit Sub
                End If
                If txtComentarios.Text.Trim = "" Then
                    MessageBox.Show("Por favor ingrese un comentario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    txtComentarios.Select()
                    Exit Sub
                End If
                If dgvProductsOutput.RowCount = 0 Then
                    MessageBox.Show("Seleccione al menos un producto para la salida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    Exit Sub
                End If
                Dim ID_Catalog As Long = cb_Catalog.SelectedValue
                Dim Comentario As String = txtComentarios.Text.Trim
                Dim Correlativo_Salida As Long = 0
                Dim resp As Integer = 0
                Using ObjSQl As New Operaciones_SQLServer
                    If Not ID_Catalog = 5 Then
                        Correlativo_Salida = ObjSQl.SP_ERP_Inventory_Output_InventoryHeader(ID_Stowage, ID_Catalog, Comentario, IdHeaderSalida)
                    Else
                        If _ID_BodegaSalida = 0 Then
                            MessageBox.Show("Seleccione la bodega para la salida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                            Exit Sub
                        End If
                        Correlativo_Salida = ObjSQl.SP_ERP_Inventory_Output_InventoryHeaderBodega(ID_Stowage, ID_Catalog, Comentario, _ID_BodegaSalida, IdHeaderSalida)
                    End If

                End Using

                If Correlativo_Salida > 0 Then
                    For Each dgvRow As DataGridViewRow In dgvProductsOutput.Rows
                        If Not dgvRow Is Nothing Then
                            Using ObjSQl As New Operaciones_SQLServer
                                resp = ObjSQl.SP_ERP_Inventory_Output_InventoryDetails(_ID_Company, Correlativo_Salida, ID_Stowage, dgvRow.Cells("Id_Product").Value, dgvRow.Cells("cantidad").Value)
                            End Using
                        End If
                    Next dgvRow

                    If resp = 1 Then
                        Dim dt As New DataTable
                        Using objSQLBodega As New Operaciones_SQLServer
                            dt = objSQLBodega.Inventory_OutputReport(Data_Id_Company, Correlativo_Salida)
                        End Using

                        Using objPartidaContable As New Financiero_ReportViewer(dt, "DSBodegasOperaciones", "epd_SatelliteERP.Reports_InventoryOutPutProduct.rdlc")
                            objPartidaContable.ShowDialog()
                        End Using
                        Me.DialogResult = DialogResult.OK
                        Me.Close()
                    End If
                Else
                    MessageBox.Show("Ocurrió un error al agregar el encabezado de la salida, contacte a Soporte Técnico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmdRechazar_Click(sender As Object, e As EventArgs) Handles cmdRechazar.Click
        cmdAprobar.Enabled = False
        pnRechazo.Visible = True
        txtRechazo.Text = ""

    End Sub

    Private Sub cmdGuardar_Click(sender As Object, e As EventArgs) Handles cmdGuardar.Click
        If MessageBox.Show("Esta seguro de rechazar la Salida?", Application.CompanyName, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
            Using objSQLBodega As New Operaciones_SQLServer
                objSQLBodega.Inventory_OutputRejection(IdHeaderSalida, txtRechazo.Text.ToString.Trim)
            End Using
            pnRechazo.Visible = False
            Me.Close()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        pnRechazo.Visible = False
        Me.Close()
    End Sub

    Private Sub ModificarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificarToolStripMenuItem.Click
        If dgvProductsOutput.Rows.Count > 0 Then

            Using objQuantity As New Financiero_DocumentoFiscalDigiteNumero
                objQuantity.GroupBox1.Text = "Cantidad Productos"
                objQuantity.StartPosition = FormStartPosition.CenterParent
                If objQuantity.ShowDialog() = DialogResult.OK Then
                    _Quantity = objQuantity.NumeroFactura
                Else
                    Exit Sub
                End If
            End Using
            Try
                If dgvProductsOutput.SelectedRows.Item(0).Cells("Stock").Value < _Quantity Then ' validamos la cantidad de salida del producto
                    MessageBox.Show("La cantidad solicitada no está disponible para la salida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    Exit Sub
                End If
                dgvProductsOutput.SelectedRows.Item(0).Cells("Cantidad").Value = _Quantity

            Catch ex As Exception

            End Try
        End If
    End Sub
#End Region
End Class