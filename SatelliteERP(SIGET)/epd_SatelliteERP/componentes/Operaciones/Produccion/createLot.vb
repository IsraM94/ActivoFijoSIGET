Public Class createLot

    Private _Id_Flow As Integer = 0
    Private _Descripcion As String = ""
    Private _FechaInicio As Date = Date.Now.ToString("d-M-yyyy")
    Private _dt As New DataTable
    Private _DT_Animales As New DataTable
    Private _Id_lot As Integer = 0
    Private dsData As New DataSet("Info")
	Private _DT_Bodegas As New DataTable
	Private _dtComboUbicacion As New DataTable
	Property ID_Ubicacion As Long = 0
	Enum TipoProceso
        AdicionProductos
        AdicionSubProductos
        AdicionarCantidadProduccion
    End Enum
    Private _TipoProceso As TipoProceso
    Property ID_Bodega As Long = 0
	Public Property Id_loteP As Integer
        Get
            Return _Id_lot
        End Get
        Set(value As Integer)
            _Id_lot = value
        End Set
    End Property


	Private Sub LoadStowage(ByVal ID_Ubicacion As Long)
		Using objsql As New Operaciones_SQLServer
			_DT_Bodegas = objsql.ERP_Prod_SP_Select_StowageEmpty
		End Using

		Dim DT_BODEGAS_U As DataRow() = _DT_Bodegas.Select("ID_Location_FK=" & ID_Ubicacion)
		Dim dt As New DataTable
		dt.Columns.Add("ID_Stowage")
		dt.Columns.Add("Name_Stowage")

		For Each row As DataRow In DT_BODEGAS_U
			dt.Rows.Add(row("ID_Stowage"), row("Name_Stowage"))
		Next row

		If dt.Rows.Count > 0 Then
			cbBodega.DataSource = dt
			cbBodega.ValueMember = "ID_Stowage"
			cbBodega.DisplayMember = "Name_Stowage"
			cbBodega.SelectedIndex = -1
		End If



	End Sub


	Private Sub loadUbicacion()
		Using objDatos As New Generic_SQLServer
			_dtComboUbicacion = objDatos.GetLocation(_ID_Company)
			RemoveHandler cbUbicacion.SelectedIndexChanged, AddressOf cbUbicacion_SelectedIndexChanged
			cbUbicacion.DataSource = _dtComboUbicacion
			cbUbicacion.DisplayMember = "Description"
			cbUbicacion.ValueMember = "ID_Location"
			cbUbicacion.SelectedIndex = -1
			AddHandler cbUbicacion.SelectedIndexChanged, AddressOf cbUbicacion_SelectedIndexChanged
		End Using
	End Sub

	Private tab0 As TabPage
	Private tab1 As TabPage
	Private Sub createLot_Load(sender As Object, e As EventArgs) Handles MyBase.Load

		tab1 = Me.TabControl1.TabPages(1)
		Using ObjSql As New Operaciones_SQLServer
            dsData = ObjSql.GetInfoFlow(1)
        End Using
        REM FillCB()
        loadUbicacion()
		_DT_Animales.Columns.Add("ID")
        _DT_Animales.Columns.Add("CodigoAnimal")
        _DT_Animales.Columns.Add("NombreAnimal")


        dgvDetails.DataSource = _DT_Animales
        dgvDetails.AutoGenerateColumns = True
        dgvDetails.Font = New Font("Segoe UI", 11)
        dgvDetails.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
        dgvDetails.ReadOnly = True
        dgvDetails.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvDetails.MultiSelect = False
        dgvDetails.AllowUserToResizeColumns = False
        dgvDetails.AllowUserToAddRows = False
        dgvDetails.AllowUserToDeleteRows = False

        Try
            If (dsData.Tables.Contains("Lot")) Then
				RemoveHandler cbFlow.SelectedIndexChanged, AddressOf cbFlow_SelectedIndexChanged
				cbFlow.DataSource = dsData.Tables("Lot")
                cbFlow.DisplayMember = "description_name"
                cbFlow.ValueMember = "id_typeflow"
				cbFlow.SelectedIndex = -1
				AddHandler cbFlow.SelectedIndexChanged, AddressOf cbFlow_SelectedIndexChanged
			End If
        Catch ex As Exception

        End Try

        If (Id_loteP > 0) Then
            FillDataLote(Id_loteP)
            btnContinuar.Text = "Modificar Lote"
            cbFlow.Enabled = False
            dtpDate.Enabled = False
        End If

        dgvDetails.Columns(0).Width = 100
        dgvDetails.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
        dgvDetails.Columns(1).Width = 205
        dgvDetails.Columns(2).Width = 310

    End Sub
    Private dtDatosEtapa As DataTable

    Private Sub FillCB(ByVal id_group As Long)
        Dim ds As New DataSet
        Using objsql As New Produccion_SQLProcess
            ds = objsql.Production_GetListProducts(Data_Id_Company, 1)
        End Using
        Dim DT_Animals As DataRow()
        DT_Animals = ds.Tables(0).Select("ID_Group_FK=" & id_group)

        Dim dt As New DataTable
        dt.Columns.Add("ID_Animal", Type.GetType("System.Int64"))
        dt.Columns.Add("Animal", Type.GetType("System.String"))

        For Each row As DataRow In DT_Animals
            dt.Rows.Add(row("ID_Animal"), row("Animal"))
        Next

        If Not ds Is Nothing Then
            If ds.Tables.Count > 0 Then
                _dt = ds.Tables(0)
                cbAnimal.DataSource = dt
                cbAnimal.DisplayMember = "Animal"
                cbAnimal.ValueMember = "ID_Animal"
                cbAnimal.SelectedIndex = -1
            End If
        End If
    End Sub

    Private Sub FillDataLote(ByVal Id_Lote As Integer)
        Dim ds As New DataSet
        Using objsql As New Produccion_SQLProcess
            ds = objsql.Production_GetDataLote(Data_Id_Company, Id_Lote)
        End Using
        If Not ds Is Nothing Then
            If ds.Tables.Count > 0 Then
                cbFlow.SelectedValue = ds.Tables(0).Rows(0).Item(0)
                txtDescripcion.Text = ds.Tables(0).Rows(0).Item(1).ToString
				dtpDate.Value = ds.Tables(0).Rows(0).Item(2).ToString
				cbUbicacion.SelectedValue = ds.Tables(0).Rows(0).Item(4).ToString
				cbBodega.SelectedValue = ds.Tables(0).Rows(0).Item(3).ToString
				_DT_Animales = ds.Tables(1)
				dgvDetails.DataSource = ds.Tables(1)
            End If
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub btnContinuar_Click(sender As Object, e As EventArgs) Handles btnContinuar.Click
		If (txtDescripcion.Text.ToString = "") Then
            MessageBox.Show("Debe ingresar una descripción", "ERP Produccion", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtDescripcion.Focus()
			Exit Sub
		End If
		If cbBodega.SelectedIndex = -1 Then
			MessageBox.Show("Por favor seleccione la bodega", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
			Exit Sub
		End If

		If Not chkLunes.Checked And chmMartes.Checked And chkMiercoles.Checked And chkJueves.Checked And chkViernes.Checked And chkSabado.Checked And chkDomingo.Checked Then
            MessageBox.Show("Por favor seleccione un día para la extracción", "error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
		End If


		_Id_Flow = cbFlow.SelectedItem(0)
        _Descripcion = txtDescripcion.Text.ToString.Trim
		_FechaInicio = dtpDate.Value
        ID_Bodega = cbBodega.SelectedValue
        If _TipoProceso = TipoProceso.AdicionarCantidadProduccion Then
            Dim _DT_Ingredients As DataTable
            Using objSQL1 As New Operaciones_SQLServer
                _DT_Ingredients = objSQL1.ERP_Inventory_Get_StockProductsForRecipe(ID_Bodega, txtIdProducto.Text, txtCantidadProducto.Text)
            End Using
            If _DT_Ingredients.Rows.Count = 0 Then
                MessageBox.Show("El producto configurado no es Fórmula o Receta, por favor verifique", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Exit Sub
            End If
            Dim Sale As Boolean = False
            Dim Detalle As String = "Detalle de insuficiencia de inventario" & vbCrLf & vbCrLf

            For Each row As DataRow In _DT_Ingredients.Rows
                Detalle &= (row("Name_Product") & Space(30)).ToString.Substring(0, 30) & vbTab & row("Estado") & vbCrLf
                If Not row("estado") = "OK" Then
                    Sale = True
                End If
            Next
            If Sale Then
                MessageBox.Show(Detalle & vbCrLf & "En Bodega seleccionada", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Exit Sub

            End If
        End If
        If (Id_loteP = 0) Then
            'If (_FechaInicio <= Date.Now.ToString("yyyy-M-d")) Then
            '    MessageBox.Show("Debe ingresar una fecha valida", "Creación de Lotes", MessageBoxButtons.OK, MessageBoxIcon.Information)
            '    Exit Sub
            'End If
        End If
        Dim ds As New DataSet("info")
        Dim resp As String = ""
        Using ObjSql As New Operaciones_SQLServer
			ds = ObjSql.CreateLot(_Id_Flow, _Descripcion, _FechaInicio, Id_loteP, ID_Bodega)
			Dim ID As Long = 0
            Dim ID_Process As Long = 0
            Dim Id_Lote As Long = 0
            If (ds.Tables.Contains("CreateLot")) Then
                For Each row As DataRow In ds.Tables("CreateLot").Rows
                    Id_Lote = row("ID_Production")
                    ID_Process = row("Id_ProcessCurrent")
                Next
				If (ID_Process <> 0 And Id_Lote <> 0) Then

					If cbFlow.SelectedValue = 18 Then
						If chkLunes.Checked Then
							SaveDay(Id_Lote, "Monday".ToUpper)
						End If
						If chkLunes.Checked Then
							SaveDay(Id_Lote, "Tuesday".ToUpper)
						End If
						If chkLunes.Checked Then
							SaveDay(Id_Lote, "Wednesday".ToUpper)
						End If
						If chkLunes.Checked Then
							SaveDay(Id_Lote, "Thursday".ToUpper)
						End If
						If chkLunes.Checked Then
							SaveDay(Id_Lote, "Friday".ToUpper)
						End If
						If chkLunes.Checked Then
							SaveDay(Id_Lote, "Saturday".ToUpper)
						End If
						If chkLunes.Checked Then
							SaveDay(Id_Lote, "Sunday".ToUpper)
						End If
					End If

					If _TipoProceso = TipoProceso.AdicionProductos Then
						For Each row As DataGridViewRow In dgvDetails.Rows
							ID = row.Cells(0).Value.ToString
							Using objsqlPro As New Produccion_SQLProcess
								objsqlPro.Production_AddProducts(Id_Lote, ID, ID_Process, dtpDate.Value, 2)
							End Using
						Next row
					ElseIf _TipoProceso = TipoProceso.AdicionarCantidadProduccion Then
						Using objsqlPro As New Produccion_SQLProcess
							objsqlPro.Production_AddPesosAnimales(txtIdProducto.Text, Id_Lote, 1, txtCantidadProducto.Text)
						End Using
					Else
						Using objsqlPro As New Produccion_SQLProcess
							For i As Long = 1 To txtCantidadProducto.Text
								objsqlPro.Production_AddPesosAnimales(txtIdProducto.Text, Id_Lote, 1, txtPesoPromedio.Text)
							Next
						End Using
					End If
                    MessageBox.Show("Proceso finalizado exitosamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()
				Else
                    MessageBox.Show("Error al almacenar la información", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()
                End If
            Else
                MessageBox.Show("Error al almacenar la información", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            End If

            Using obj As New Produccion_SQLProcess


            End Using
        End Using
    End Sub


	Private Function SaveDay(ByVal Lote As Long, ByVal Dia As String)
		Dim resp As Integer = 0
		Using ObjSql As New Operaciones_SQLServer
			resp = ObjSql.ERP_Prod_SP_ADD_DaysOfExtraction(Lote, Dia)
		End Using
		Return resp
	End Function
	Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim id As Long = cbAnimal.SelectedValue
        Dim estado As Boolean = True
        For Each row As DataRow In _dt.Rows
            If Not row Is Nothing Then
                If row("ID_animal") = id Then
                    For Each row2 As DataRow In _DT_Animales.Rows

                        Try
                            If row2("Id_Animal") = id Then
                                estado = False
                            End If
                        Catch ex As Exception
                            Try
                                If row2("Id") = id Then
                                    estado = False
                                End If
                            Catch ex2 As Exception

                            End Try
                        End Try
                    Next row2
                    If estado Then
                        _DT_Animales.Rows.Add(row("ID_Animal"), row("CodigoAnimal"), row("Animal"))
                        dgvDetails.DataSource = _DT_Animales
                        estado = True
                    End If
                End If
            End If
        Next row
        dgvDetails.Columns(0).Width = 100
        dgvDetails.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
        dgvDetails.Columns(1).Width = 205
        dgvDetails.Columns(2).Width = 310
    End Sub

    Private Sub BorrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BorrarToolStripMenuItem.Click
        dgvDetails.Rows.Remove(dgvDetails.CurrentRow)
    End Sub
	Private Id


	Private Sub cbFlow_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbFlow.SelectedIndexChanged
		If cbFlow.SelectedIndex = -1 Then
			Exit Sub
		End If


		Try
			If sender.SelectedValue = 18 Then
				PanelDias.Visible = True
			Else
				PanelDias.Visible = False
			End If
            REM FillCB()
            For Each row As DataRow In dsData.Tables("Lot").Select("id_TypeFlow=" & sender.SelectedValue)
				Try
					If IsDBNull(row("ID_Product_FK")) Then
						txtIdProducto.Text = ""
					Else
						txtIdProducto.Text = row("ID_Product_FK")
					End If

				Catch ex As Exception
					txtIdProducto.Text = ""
				End Try
				Try
					If IsDBNull(row("Name_Product")) Then
						txtDescripcionProducto.Text = ""
					Else

						txtDescripcionProducto.Text = row("Name_Product")
					End If
				Catch ex As Exception
					txtDescripcionProducto.Text = ""
				End Try
			Next
		Catch ex As Exception

		End Try
        REM Poner proceso llenado de animales

        REM Proceso de seleccion de tipo de captura
        Using obj As New Produccion_SQLProcess
			Try
				Dim dt As DataTable = obj.Flow_ListProcess(Data_Id_Company, sender.SelectedValue)
				Dim borrar As String = "gogla"
				For Each rowSeleccion As DataRow In dt.Select("OrderProcess=2")
					If rowSeleccion("ScreenToTun") = "Pantalla de Seleccion Animales" Then
						Me.TabControl1.TabPages(0).Enabled = True
						Me.TabControl1.SelectedTab = Me.TabControl1.TabPages(0)
                        'Me.TabControl1.TabPages(1).Hide()
                        ' Me.TabControl1.TabPages.Add("tab01")

                        If IsDBNull(rowSeleccion("Id_Group_FK")) Then

						Else
							FillCB(rowSeleccion("Id_Group_FK"))
						End If

						_TipoProceso = TipoProceso.AdicionProductos

					ElseIf rowSeleccion("ScreenToTun") = "Pantalla de Ingreso Masivo de Animales" Then
						Me.TabControl1.TabPages(0).Enabled = False
						Me.TabControl1.TabPages(1).Enabled = True
						Me.TabControl1.SelectedTab = Me.TabControl1.TabPages(1)
						_TipoProceso = TipoProceso.AdicionSubProductos
					ElseIf rowSeleccion("ScreenToTun") = "Produccion" Then
						Me.TabControl1.TabPages(0).Enabled = False
						Me.TabControl1.TabPages(1).Enabled = True
						Me.TabControl1.SelectedTab = Me.TabControl1.TabPages(1)
						Dim tab As TabPage = Me.TabControl1.TabPages(0)
						'Me.TabControl1.TabPages(0).Hide()

						txtPesoPromedio.Visible = False
						Label_PesoPromedio.Visible = False
						_TipoProceso = TipoProceso.AdicionarCantidadProduccion
					ElseIf rowSeleccion("ScreenToTun") = "Salida Programada Producto"
						Me.TabControl1.TabPages(1).Enabled = False
						Me.TabControl1.SelectedTab = Me.TabControl1.TabPages(0)
						Me.TabControl1.TabPages(1).Hide()
						Me.TabControl1.TabPages.Add(tab0)

						FillCB(rowSeleccion("Id_Group_FK"))
						_TipoProceso = TipoProceso.AdicionProductos
					Else
                        ' Se tiene que seguir configurando
                        _TipoProceso = TipoProceso.AdicionProductos
					End If
					Dim borrar1 As String = "gogla"
				Next
			Catch ex As Exception
				Dim borrar As String = "gogla"
			End Try

		End Using


	End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub cbUbicacion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbUbicacion.SelectedIndexChanged
        If Not cbUbicacion.SelectedIndex = -1 Then
            LoadStowage(cbUbicacion.SelectedValue)
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