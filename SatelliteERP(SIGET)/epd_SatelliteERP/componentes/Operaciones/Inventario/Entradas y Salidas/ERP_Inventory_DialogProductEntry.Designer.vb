<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ERP_Inventory_DialogProductEntry
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnCerrarEntrada = New System.Windows.Forms.Button()
        Me.CB_FormaPago = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CB_ModalidadCompra = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CB_TipoCompra = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtOrdenCompras = New System.Windows.Forms.TextBox()
        Me.dtpExpirationDate = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtLot = New System.Windows.Forms.TextBox()
        Me.cb_Catalog = New System.Windows.Forms.ComboBox()
        Me.label49 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtEmpresa = New System.Windows.Forms.TextBox()
        Me.dtpInvoiceDate = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgvProducts = New System.Windows.Forms.DataGridView()
        Me.Menu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AgregarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblValor = New System.Windows.Forms.Label()
        Me.txtNumeroFactura = New System.Windows.Forms.TextBox()
        Me.correlativo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Barra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.product = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioUnitario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Stock = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Menu.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.btnCerrarEntrada)
        Me.GroupBox1.Controls.Add(Me.CB_FormaPago)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.CB_ModalidadCompra)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.CB_TipoCompra)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtOrdenCompras)
        Me.GroupBox1.Controls.Add(Me.dtpExpirationDate)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtLot)
        Me.GroupBox1.Controls.Add(Me.cb_Catalog)
        Me.GroupBox1.Controls.Add(Me.label49)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtEmpresa)
        Me.GroupBox1.Controls.Add(Me.dtpInvoiceDate)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.cmdCancel)
        Me.GroupBox1.Controls.Add(Me.cmdSave)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.lblValor)
        Me.GroupBox1.Controls.Add(Me.txtNumeroFactura)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(8, 11)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(839, 641)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Entrada de Producto"
        '
        'btnCerrarEntrada
        '
        Me.btnCerrarEntrada.BackColor = System.Drawing.Color.Gainsboro
        Me.btnCerrarEntrada.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.btnCerrarEntrada.FlatAppearance.BorderSize = 0
        Me.btnCerrarEntrada.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.btnCerrarEntrada.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.btnCerrarEntrada.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrarEntrada.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrarEntrada.Location = New System.Drawing.Point(651, 605)
        Me.btnCerrarEntrada.Name = "btnCerrarEntrada"
        Me.btnCerrarEntrada.Size = New System.Drawing.Size(157, 28)
        Me.btnCerrarEntrada.TabIndex = 57
        Me.btnCerrarEntrada.Text = "Cerrar Proceso"
        Me.btnCerrarEntrada.UseVisualStyleBackColor = False
        Me.btnCerrarEntrada.Visible = False
        '
        'CB_FormaPago
        '
        Me.CB_FormaPago.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CB_FormaPago.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CB_FormaPago.BackColor = System.Drawing.Color.Gainsboro
        Me.CB_FormaPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_FormaPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CB_FormaPago.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_FormaPago.FormattingEnabled = True
        Me.CB_FormaPago.Items.AddRange(New Object() {"CONTADO", "CREDITO", "CHEQUE"})
        Me.CB_FormaPago.Location = New System.Drawing.Point(589, 172)
        Me.CB_FormaPago.Name = "CB_FormaPago"
        Me.CB_FormaPago.Size = New System.Drawing.Size(229, 29)
        Me.CB_FormaPago.TabIndex = 9
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(407, 105)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(176, 21)
        Me.Label8.TabIndex = 55
        Me.Label8.Text = "Modalidad de Compra : "
        '
        'CB_ModalidadCompra
        '
        Me.CB_ModalidadCompra.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CB_ModalidadCompra.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CB_ModalidadCompra.BackColor = System.Drawing.Color.Gainsboro
        Me.CB_ModalidadCompra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_ModalidadCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CB_ModalidadCompra.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_ModalidadCompra.FormattingEnabled = True
        Me.CB_ModalidadCompra.Items.AddRange(New Object() {"LIBRE GESTION", "COMPRA DIRECTA"})
        Me.CB_ModalidadCompra.Location = New System.Drawing.Point(589, 102)
        Me.CB_ModalidadCompra.Name = "CB_ModalidadCompra"
        Me.CB_ModalidadCompra.Size = New System.Drawing.Size(229, 29)
        Me.CB_ModalidadCompra.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(458, 175)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(125, 21)
        Me.Label7.TabIndex = 53
        Me.Label7.Text = "Forma de Pago : "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(427, 69)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(156, 21)
        Me.Label6.TabIndex = 52
        Me.Label6.Text = "Método de Compra : "
        '
        'CB_TipoCompra
        '
        Me.CB_TipoCompra.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CB_TipoCompra.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CB_TipoCompra.BackColor = System.Drawing.Color.Gainsboro
        Me.CB_TipoCompra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_TipoCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CB_TipoCompra.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_TipoCompra.FormattingEnabled = True
        Me.CB_TipoCompra.Items.AddRange(New Object() {"ORDEN DE COMPRAS", "CAJA CHICA", "POR CONTRATO"})
        Me.CB_TipoCompra.Location = New System.Drawing.Point(589, 67)
        Me.CB_TipoCompra.Name = "CB_TipoCompra"
        Me.CB_TipoCompra.Size = New System.Drawing.Size(229, 29)
        Me.CB_TipoCompra.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(428, 138)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(154, 21)
        Me.Label5.TabIndex = 50
        Me.Label5.Text = "N° Orden Compras : "
        '
        'txtOrdenCompras
        '
        Me.txtOrdenCompras.BackColor = System.Drawing.Color.Gainsboro
        Me.txtOrdenCompras.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtOrdenCompras.Enabled = False
        Me.txtOrdenCompras.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOrdenCompras.Location = New System.Drawing.Point(589, 138)
        Me.txtOrdenCompras.MaxLength = 10
        Me.txtOrdenCompras.Name = "txtOrdenCompras"
        Me.txtOrdenCompras.ShortcutsEnabled = False
        Me.txtOrdenCompras.Size = New System.Drawing.Size(146, 26)
        Me.txtOrdenCompras.TabIndex = 8
        Me.txtOrdenCompras.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'dtpExpirationDate
        '
        Me.dtpExpirationDate.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpExpirationDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpExpirationDate.Location = New System.Drawing.Point(165, 213)
        Me.dtpExpirationDate.Name = "dtpExpirationDate"
        Me.dtpExpirationDate.Size = New System.Drawing.Size(229, 29)
        Me.dtpExpirationDate.TabIndex = 9
        Me.dtpExpirationDate.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 219)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(143, 21)
        Me.Label4.TabIndex = 47
        Me.Label4.Text = "Fecha Vencimiento:"
        Me.Label4.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(94, 182)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 21)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "Ingreso:"
        '
        'txtLot
        '
        Me.txtLot.BackColor = System.Drawing.Color.Gainsboro
        Me.txtLot.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtLot.Enabled = False
        Me.txtLot.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLot.Location = New System.Drawing.Point(165, 179)
        Me.txtLot.MaxLength = 15
        Me.txtLot.Name = "txtLot"
        Me.txtLot.ShortcutsEnabled = False
        Me.txtLot.Size = New System.Drawing.Size(229, 26)
        Me.txtLot.TabIndex = 4
        '
        'cb_Catalog
        '
        Me.cb_Catalog.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cb_Catalog.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cb_Catalog.BackColor = System.Drawing.Color.Gainsboro
        Me.cb_Catalog.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_Catalog.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cb_Catalog.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_Catalog.FormattingEnabled = True
        Me.cb_Catalog.Location = New System.Drawing.Point(165, 142)
        Me.cb_Catalog.Name = "cb_Catalog"
        Me.cb_Catalog.Size = New System.Drawing.Size(229, 29)
        Me.cb_Catalog.TabIndex = 3
        '
        'label49
        '
        Me.label49.AutoSize = True
        Me.label49.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label49.Location = New System.Drawing.Point(34, 146)
        Me.label49.Name = "label49"
        Me.label49.Size = New System.Drawing.Size(129, 21)
        Me.label49.TabIndex = 42
        Me.label49.Text = "Tipo de Entrada : "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(90, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 21)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Empresa:"
        '
        'txtEmpresa
        '
        Me.txtEmpresa.BackColor = System.Drawing.Color.Gainsboro
        Me.txtEmpresa.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEmpresa.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmpresa.Location = New System.Drawing.Point(165, 35)
        Me.txtEmpresa.MaxLength = 15
        Me.txtEmpresa.Multiline = True
        Me.txtEmpresa.Name = "txtEmpresa"
        Me.txtEmpresa.ShortcutsEnabled = False
        Me.txtEmpresa.Size = New System.Drawing.Size(229, 67)
        Me.txtEmpresa.TabIndex = 1
        '
        'dtpInvoiceDate
        '
        Me.dtpInvoiceDate.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpInvoiceDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpInvoiceDate.Location = New System.Drawing.Point(589, 32)
        Me.dtpInvoiceDate.Name = "dtpInvoiceDate"
        Me.dtpInvoiceDate.Size = New System.Drawing.Size(229, 29)
        Me.dtpInvoiceDate.TabIndex = 5
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgvProducts)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 248)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(827, 351)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Productos"
        '
        'dgvProducts
        '
        Me.dgvProducts.AllowUserToAddRows = False
        Me.dgvProducts.AllowUserToDeleteRows = False
        Me.dgvProducts.AllowUserToResizeColumns = False
        Me.dgvProducts.AllowUserToResizeRows = False
        Me.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProducts.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.correlativo, Me.Barra, Me.product, Me.Cantidad, Me.PrecioUnitario, Me.Total1, Me.Stock})
        Me.dgvProducts.ContextMenuStrip = Me.Menu
        Me.dgvProducts.Location = New System.Drawing.Point(5, 31)
        Me.dgvProducts.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvProducts.MultiSelect = False
        Me.dgvProducts.Name = "dgvProducts"
        Me.dgvProducts.ReadOnly = True
        Me.dgvProducts.RowHeadersVisible = False
        Me.dgvProducts.RowTemplate.Height = 24
        Me.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProducts.Size = New System.Drawing.Size(817, 315)
        Me.dgvProducts.TabIndex = 10
        '
        'Menu
        '
        Me.Menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarToolStripMenuItem, Me.ModificarToolStripMenuItem, Me.EliminarToolStripMenuItem})
        Me.Menu.Name = "Menu"
        Me.Menu.Size = New System.Drawing.Size(126, 70)
        '
        'AgregarToolStripMenuItem
        '
        Me.AgregarToolStripMenuItem.Name = "AgregarToolStripMenuItem"
        Me.AgregarToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.AgregarToolStripMenuItem.Text = "Agregar"
        '
        'ModificarToolStripMenuItem
        '
        Me.ModificarToolStripMenuItem.Name = "ModificarToolStripMenuItem"
        Me.ModificarToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.ModificarToolStripMenuItem.Text = "Modificar"
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
        '
        'cmdCancel
        '
        Me.cmdCancel.BackColor = System.Drawing.Color.Gainsboro
        Me.cmdCancel.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdCancel.FlatAppearance.BorderSize = 0
        Me.cmdCancel.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.cmdCancel.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.cmdCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCancel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancel.Location = New System.Drawing.Point(539, 605)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(98, 28)
        Me.cmdCancel.TabIndex = 9
        Me.cmdCancel.Text = "Cancelar"
        Me.cmdCancel.UseVisualStyleBackColor = False
        '
        'cmdSave
        '
        Me.cmdSave.BackColor = System.Drawing.Color.Gainsboro
        Me.cmdSave.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdSave.FlatAppearance.BorderSize = 0
        Me.cmdSave.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.cmdSave.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.cmdSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdSave.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSave.Location = New System.Drawing.Point(394, 605)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(130, 28)
        Me.cmdSave.TabIndex = 8
        Me.cmdSave.Text = "Guardar y salir"
        Me.cmdSave.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(476, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Fecha Factura:"
        '
        'lblValor
        '
        Me.lblValor.AutoSize = True
        Me.lblValor.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValor.Location = New System.Drawing.Point(19, 109)
        Me.lblValor.Name = "lblValor"
        Me.lblValor.Size = New System.Drawing.Size(144, 21)
        Me.lblValor.TabIndex = 0
        Me.lblValor.Text = "Número de factura:"
        '
        'txtNumeroFactura
        '
        Me.txtNumeroFactura.BackColor = System.Drawing.Color.Gainsboro
        Me.txtNumeroFactura.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNumeroFactura.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumeroFactura.Location = New System.Drawing.Point(165, 109)
        Me.txtNumeroFactura.MaxLength = 15
        Me.txtNumeroFactura.Name = "txtNumeroFactura"
        Me.txtNumeroFactura.ShortcutsEnabled = False
        Me.txtNumeroFactura.Size = New System.Drawing.Size(229, 26)
        Me.txtNumeroFactura.TabIndex = 2
        Me.txtNumeroFactura.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'correlativo
        '
        Me.correlativo.DataPropertyName = "ID_Product"
        Me.correlativo.HeaderText = "Correlativo"
        Me.correlativo.Name = "correlativo"
        Me.correlativo.ReadOnly = True
        Me.correlativo.Visible = False
        Me.correlativo.Width = 135
        '
        'Barra
        '
        Me.Barra.DataPropertyName = "Barra"
        Me.Barra.HeaderText = "Correlativo"
        Me.Barra.Name = "Barra"
        Me.Barra.ReadOnly = True
        Me.Barra.Width = 150
        '
        'product
        '
        Me.product.DataPropertyName = "Name_Product"
        Me.product.HeaderText = "Descripción"
        Me.product.Name = "product"
        Me.product.ReadOnly = True
        Me.product.Width = 270
        '
        'Cantidad
        '
        Me.Cantidad.DataPropertyName = "Cantidad"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle1.Format = "N2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.Cantidad.DefaultCellStyle = DataGridViewCellStyle1
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.ReadOnly = True
        Me.Cantidad.Width = 117
        '
        'PrecioUnitario
        '
        Me.PrecioUnitario.DataPropertyName = "PrecioUnitario"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle2.Format = "C4"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.PrecioUnitario.DefaultCellStyle = DataGridViewCellStyle2
        Me.PrecioUnitario.HeaderText = "Precio Unitario"
        Me.PrecioUnitario.Name = "PrecioUnitario"
        Me.PrecioUnitario.ReadOnly = True
        Me.PrecioUnitario.Width = 171
        '
        'Total1
        '
        Me.Total1.DataPropertyName = "Total"
        DataGridViewCellStyle3.Format = "C2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.Total1.DefaultCellStyle = DataGridViewCellStyle3
        Me.Total1.HeaderText = "Total"
        Me.Total1.Name = "Total1"
        Me.Total1.ReadOnly = True
        Me.Total1.Width = 120
        '
        'Stock
        '
        Me.Stock.DataPropertyName = "Stock"
        Me.Stock.HeaderText = "Stock"
        Me.Stock.Name = "Stock"
        Me.Stock.ReadOnly = True
        Me.Stock.Visible = False
        '
        'ERP_Inventory_DialogProductEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CadetBlue
        Me.ClientSize = New System.Drawing.Size(856, 661)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ERP_Inventory_DialogProductEntry"
        Me.Text = "ERP_Inventory_DialogProductEntry"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgvProducts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Menu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Private WithEvents cmdCancel As Button
    Private WithEvents cmdSave As Button
    Private WithEvents Label1 As Label
    Private WithEvents lblValor As Label
    Private WithEvents txtNumeroFactura As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dtpInvoiceDate As DateTimePicker
    Friend WithEvents Menu As ContextMenuStrip
    Friend WithEvents AgregarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As ToolStripMenuItem
    Private WithEvents Label2 As Label
    Private WithEvents txtEmpresa As TextBox
    Private WithEvents label49 As Label
    Friend WithEvents dgvProducts As DataGridView
    Private WithEvents cb_Catalog As ComboBox
    Friend WithEvents dtpExpirationDate As DateTimePicker
    Private WithEvents Label4 As Label
    Private WithEvents Label3 As Label
    Private WithEvents txtLot As TextBox
    Private WithEvents Label5 As Label
    Private WithEvents txtOrdenCompras As TextBox
    Private WithEvents Label7 As Label
    Private WithEvents Label6 As Label
    Private WithEvents CB_TipoCompra As ComboBox
    Private WithEvents Label8 As Label
    Private WithEvents CB_ModalidadCompra As ComboBox
    Private WithEvents CB_FormaPago As ComboBox
    Private WithEvents btnCerrarEntrada As Button
    Friend WithEvents ModificarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents correlativo As DataGridViewTextBoxColumn
    Friend WithEvents Barra As DataGridViewTextBoxColumn
    Friend WithEvents product As DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents PrecioUnitario As DataGridViewTextBoxColumn
    Friend WithEvents Total1 As DataGridViewTextBoxColumn
    Friend WithEvents Stock As DataGridViewTextBoxColumn
End Class
