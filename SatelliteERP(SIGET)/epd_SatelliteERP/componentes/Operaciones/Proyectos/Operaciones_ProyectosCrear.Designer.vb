<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Operaciones_ProyectosCrear
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.ProductosInterno = New System.Windows.Forms.TabPage()
        Me.DETALLE = New System.Windows.Forms.DataGridView()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Unidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioUnitario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VentaNoSujetas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VentasExentas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VentasGrabadas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Id_Product = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PresupuestosExterno = New System.Windows.Forms.TabPage()
        Me.RecursosHumanos = New System.Windows.Forms.TabPage()
        Me.Otros = New System.Windows.Forms.TabPage()
        Me.cmdPreview = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtRetencion = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtTotalVenta = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtTotalExentas = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtIva = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtSubTotal = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CB_FormaPago = New System.Windows.Forms.ComboBox()
        Me.txtNIT = New System.Windows.Forms.TextBox()
        Me.txtNRC = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtRazonSocial = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.cmdPrint = New System.Windows.Forms.Button()
        Me.txtPartida_NoPartida = New System.Windows.Forms.TextBox()
        Me.label50 = New System.Windows.Forms.Label()
        Me.label49 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.ProductosInterno.SuspendLayout()
        CType(Me.DETALLE, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.TabControl1)
        Me.GroupBox1.Controls.Add(Me.cmdPreview)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.CB_FormaPago)
        Me.GroupBox1.Controls.Add(Me.txtNIT)
        Me.GroupBox1.Controls.Add(Me.txtNRC)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtRazonSocial)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cmdCancel)
        Me.GroupBox1.Controls.Add(Me.cmdPrint)
        Me.GroupBox1.Controls.Add(Me.txtPartida_NoPartida)
        Me.GroupBox1.Controls.Add(Me.label50)
        Me.GroupBox1.Controls.Add(Me.label49)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(10, 9)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(847, 581)
        Me.GroupBox1.TabIndex = 31
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Creacion de Proyecto"
        '
        'ComboBox1
        '
        Me.ComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox1.BackColor = System.Drawing.Color.Gainsboro
        Me.ComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"CONTADO", "CREDITO", "CHEQUE"})
        Me.ComboBox1.Location = New System.Drawing.Point(701, 125)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(142, 29)
        Me.ComboBox1.TabIndex = 48
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.Gainsboro
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(184, 125)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(373, 26)
        Me.TextBox1.TabIndex = 47
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 128)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 21)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "Nombre Proyecto : "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(574, 130)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(116, 21)
        Me.Label9.TabIndex = 45
        Me.Label9.Text = "Tipo Proyecto : "
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.ProductosInterno)
        Me.TabControl1.Controls.Add(Me.PresupuestosExterno)
        Me.TabControl1.Controls.Add(Me.RecursosHumanos)
        Me.TabControl1.Controls.Add(Me.Otros)
        Me.TabControl1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(6, 160)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(830, 280)
        Me.TabControl1.TabIndex = 44
        '
        'ProductosInterno
        '
        Me.ProductosInterno.Controls.Add(Me.DETALLE)
        Me.ProductosInterno.Location = New System.Drawing.Point(4, 29)
        Me.ProductosInterno.Name = "ProductosInterno"
        Me.ProductosInterno.Padding = New System.Windows.Forms.Padding(3)
        Me.ProductosInterno.Size = New System.Drawing.Size(822, 247)
        Me.ProductosInterno.TabIndex = 0
        Me.ProductosInterno.Text = "Productos Internos"
        Me.ProductosInterno.UseVisualStyleBackColor = True
        '
        'DETALLE
        '
        Me.DETALLE.AllowUserToAddRows = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DETALLE.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DETALLE.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DETALLE.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DETALLE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DETALLE.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Cantidad, Me.Unidad, Me.Descripcion, Me.PrecioUnitario, Me.VentaNoSujetas, Me.VentasExentas, Me.VentasGrabadas, Me.tipo, Me.Id_Product})
        Me.DETALLE.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DETALLE.EnableHeadersVisualStyles = False
        Me.DETALLE.Location = New System.Drawing.Point(3, 3)
        Me.DETALLE.Name = "DETALLE"
        Me.DETALLE.RowHeadersVisible = False
        Me.DETALLE.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DETALLE.Size = New System.Drawing.Size(816, 241)
        Me.DETALLE.TabIndex = 6
        '
        'Cantidad
        '
        Me.Cantidad.HeaderText = "Cant."
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.ReadOnly = True
        Me.Cantidad.Width = 80
        '
        'Unidad
        '
        Me.Unidad.HeaderText = "Unidad"
        Me.Unidad.Name = "Unidad"
        Me.Unidad.ReadOnly = True
        Me.Unidad.Width = 60
        '
        'Descripcion
        '
        Me.Descripcion.HeaderText = "Descripción"
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.ReadOnly = True
        Me.Descripcion.Width = 300
        '
        'PrecioUnitario
        '
        Me.PrecioUnitario.HeaderText = "Precio Uni."
        Me.PrecioUnitario.Name = "PrecioUnitario"
        Me.PrecioUnitario.ReadOnly = True
        '
        'VentaNoSujetas
        '
        Me.VentaNoSujetas.HeaderText = "No sujetas"
        Me.VentaNoSujetas.Name = "VentaNoSujetas"
        Me.VentaNoSujetas.ReadOnly = True
        '
        'VentasExentas
        '
        Me.VentasExentas.HeaderText = "Exentas"
        Me.VentasExentas.Name = "VentasExentas"
        Me.VentasExentas.ReadOnly = True
        '
        'VentasGrabadas
        '
        Me.VentasGrabadas.HeaderText = "Grabadas"
        Me.VentasGrabadas.Name = "VentasGrabadas"
        Me.VentasGrabadas.ReadOnly = True
        '
        'tipo
        '
        Me.tipo.HeaderText = "Tipo"
        Me.tipo.Name = "tipo"
        Me.tipo.ReadOnly = True
        Me.tipo.Visible = False
        '
        'Id_Product
        '
        Me.Id_Product.HeaderText = "Id_Product"
        Me.Id_Product.Name = "Id_Product"
        '
        'PresupuestosExterno
        '
        Me.PresupuestosExterno.Location = New System.Drawing.Point(4, 29)
        Me.PresupuestosExterno.Name = "PresupuestosExterno"
        Me.PresupuestosExterno.Padding = New System.Windows.Forms.Padding(3)
        Me.PresupuestosExterno.Size = New System.Drawing.Size(822, 247)
        Me.PresupuestosExterno.TabIndex = 1
        Me.PresupuestosExterno.Text = "Presupuestos Externos"
        Me.PresupuestosExterno.UseVisualStyleBackColor = True
        '
        'RecursosHumanos
        '
        Me.RecursosHumanos.Location = New System.Drawing.Point(4, 29)
        Me.RecursosHumanos.Name = "RecursosHumanos"
        Me.RecursosHumanos.Size = New System.Drawing.Size(822, 247)
        Me.RecursosHumanos.TabIndex = 2
        Me.RecursosHumanos.Text = "Recurso Humano"
        Me.RecursosHumanos.UseVisualStyleBackColor = True
        '
        'Otros
        '
        Me.Otros.Location = New System.Drawing.Point(4, 29)
        Me.Otros.Name = "Otros"
        Me.Otros.Size = New System.Drawing.Size(822, 247)
        Me.Otros.TabIndex = 3
        Me.Otros.Text = "Otros Cargos"
        Me.Otros.UseVisualStyleBackColor = True
        '
        'cmdPreview
        '
        Me.cmdPreview.BackColor = System.Drawing.Color.Gainsboro
        Me.cmdPreview.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdPreview.FlatAppearance.BorderSize = 0
        Me.cmdPreview.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.cmdPreview.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.cmdPreview.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdPreview.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPreview.Location = New System.Drawing.Point(536, 545)
        Me.cmdPreview.Name = "cmdPreview"
        Me.cmdPreview.Size = New System.Drawing.Size(98, 29)
        Me.cmdPreview.TabIndex = 43
        Me.cmdPreview.Text = "Preview"
        Me.cmdPreview.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtRetencion)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.txtTotalVenta)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtTotalExentas)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txtIva)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txtSubTotal)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Location = New System.Drawing.Point(10, 446)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(831, 91)
        Me.GroupBox2.TabIndex = 42
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Totales"
        '
        'txtRetencion
        '
        Me.txtRetencion.BackColor = System.Drawing.Color.Gainsboro
        Me.txtRetencion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtRetencion.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRetencion.Location = New System.Drawing.Point(467, 56)
        Me.txtRetencion.MaxLength = 14
        Me.txtRetencion.Name = "txtRetencion"
        Me.txtRetencion.ReadOnly = True
        Me.txtRetencion.Size = New System.Drawing.Size(145, 22)
        Me.txtRetencion.TabIndex = 32
        Me.txtRetencion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(469, 28)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(123, 20)
        Me.Label10.TabIndex = 31
        Me.Label10.Text = "Retencion (1%):"
        '
        'txtTotalVenta
        '
        Me.txtTotalVenta.BackColor = System.Drawing.Color.Gainsboro
        Me.txtTotalVenta.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTotalVenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalVenta.Location = New System.Drawing.Point(674, 56)
        Me.txtTotalVenta.MaxLength = 14
        Me.txtTotalVenta.Name = "txtTotalVenta"
        Me.txtTotalVenta.ReadOnly = True
        Me.txtTotalVenta.Size = New System.Drawing.Size(145, 22)
        Me.txtTotalVenta.TabIndex = 30
        Me.txtTotalVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(670, 31)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(142, 20)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Total Presupuesto:"
        '
        'txtTotalExentas
        '
        Me.txtTotalExentas.BackColor = System.Drawing.Color.Gainsboro
        Me.txtTotalExentas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTotalExentas.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalExentas.Location = New System.Drawing.Point(316, 56)
        Me.txtTotalExentas.MaxLength = 14
        Me.txtTotalExentas.Name = "txtTotalExentas"
        Me.txtTotalExentas.ReadOnly = True
        Me.txtTotalExentas.Size = New System.Drawing.Size(145, 22)
        Me.txtTotalExentas.TabIndex = 28
        Me.txtTotalExentas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(318, 30)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(126, 20)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Ventas Exentas:"
        '
        'txtIva
        '
        Me.txtIva.BackColor = System.Drawing.Color.Gainsboro
        Me.txtIva.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtIva.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIva.Location = New System.Drawing.Point(165, 56)
        Me.txtIva.MaxLength = 14
        Me.txtIva.Name = "txtIva"
        Me.txtIva.ReadOnly = True
        Me.txtIva.Size = New System.Drawing.Size(145, 22)
        Me.txtIva.TabIndex = 26
        Me.txtIva.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(164, 30)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 20)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "IVA:"
        '
        'txtSubTotal
        '
        Me.txtSubTotal.BackColor = System.Drawing.Color.Gainsboro
        Me.txtSubTotal.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSubTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubTotal.Location = New System.Drawing.Point(12, 56)
        Me.txtSubTotal.MaxLength = 14
        Me.txtSubTotal.Name = "txtSubTotal"
        Me.txtSubTotal.ReadOnly = True
        Me.txtSubTotal.Size = New System.Drawing.Size(145, 22)
        Me.txtSubTotal.TabIndex = 24
        Me.txtSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(9, 35)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 20)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "SubTotal:"
        '
        'CB_FormaPago
        '
        Me.CB_FormaPago.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CB_FormaPago.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CB_FormaPago.BackColor = System.Drawing.Color.Gainsboro
        Me.CB_FormaPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CB_FormaPago.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_FormaPago.FormattingEnabled = True
        Me.CB_FormaPago.Items.AddRange(New Object() {"CONTADO", "CREDITO", "CHEQUE"})
        Me.CB_FormaPago.Location = New System.Drawing.Point(699, 88)
        Me.CB_FormaPago.Name = "CB_FormaPago"
        Me.CB_FormaPago.Size = New System.Drawing.Size(142, 29)
        Me.CB_FormaPago.TabIndex = 41
        '
        'txtNIT
        '
        Me.txtNIT.BackColor = System.Drawing.Color.Gainsboro
        Me.txtNIT.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNIT.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNIT.Location = New System.Drawing.Point(386, 91)
        Me.txtNIT.Name = "txtNIT"
        Me.txtNIT.Size = New System.Drawing.Size(171, 26)
        Me.txtNIT.TabIndex = 40
        '
        'txtNRC
        '
        Me.txtNRC.BackColor = System.Drawing.Color.Gainsboro
        Me.txtNRC.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNRC.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNRC.Location = New System.Drawing.Point(188, 94)
        Me.txtNRC.Name = "txtNRC"
        Me.txtNRC.Size = New System.Drawing.Size(153, 26)
        Me.txtNRC.TabIndex = 39
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(346, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 21)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "NIT : "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(104, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 21)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "N.R.C : "
        '
        'txtRazonSocial
        '
        Me.txtRazonSocial.BackColor = System.Drawing.Color.Gainsboro
        Me.txtRazonSocial.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtRazonSocial.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRazonSocial.Location = New System.Drawing.Point(188, 59)
        Me.txtRazonSocial.Name = "txtRazonSocial"
        Me.txtRazonSocial.Size = New System.Drawing.Size(653, 26)
        Me.txtRazonSocial.TabIndex = 36
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(17, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(146, 25)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Nombre cliente:"
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
        Me.cmdCancel.Location = New System.Drawing.Point(741, 545)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(98, 29)
        Me.cmdCancel.TabIndex = 30
        Me.cmdCancel.Text = "Cancelar"
        Me.cmdCancel.UseVisualStyleBackColor = False
        '
        'cmdPrint
        '
        Me.cmdPrint.BackColor = System.Drawing.Color.Gainsboro
        Me.cmdPrint.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdPrint.FlatAppearance.BorderSize = 0
        Me.cmdPrint.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.cmdPrint.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.cmdPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdPrint.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrint.Location = New System.Drawing.Point(640, 545)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(98, 29)
        Me.cmdPrint.TabIndex = 29
        Me.cmdPrint.Text = "Imprimir"
        Me.cmdPrint.UseVisualStyleBackColor = False
        '
        'txtPartida_NoPartida
        '
        Me.txtPartida_NoPartida.BackColor = System.Drawing.Color.Gainsboro
        Me.txtPartida_NoPartida.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPartida_NoPartida.Enabled = False
        Me.txtPartida_NoPartida.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPartida_NoPartida.Location = New System.Drawing.Point(634, 27)
        Me.txtPartida_NoPartida.Name = "txtPartida_NoPartida"
        Me.txtPartida_NoPartida.Size = New System.Drawing.Size(202, 26)
        Me.txtPartida_NoPartida.TabIndex = 22
        Me.txtPartida_NoPartida.Text = "0"
        Me.txtPartida_NoPartida.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'label50
        '
        Me.label50.AutoSize = True
        Me.label50.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label50.Location = New System.Drawing.Point(577, 32)
        Me.label50.Name = "label50"
        Me.label50.Size = New System.Drawing.Size(45, 21)
        Me.label50.TabIndex = 19
        Me.label50.Text = "No.  :"
        '
        'label49
        '
        Me.label49.AutoSize = True
        Me.label49.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label49.Location = New System.Drawing.Point(563, 94)
        Me.label49.Name = "label49"
        Me.label49.Size = New System.Drawing.Size(130, 21)
        Me.label49.TabIndex = 20
        Me.label49.Text = "Forma de Pago  : "
        '
        'Operaciones_ProyectosCrear
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(868, 596)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Operaciones_ProyectosCrear"
        Me.Text = "Operaciones_ProyectosCrear"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.ProductosInterno.ResumeLayout(False)
        CType(Me.DETALLE, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Private WithEvents cmdPreview As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtRetencion As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtTotalVenta As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtTotalExentas As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtIva As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtSubTotal As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents DETALLE As DataGridView
    Friend WithEvents Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents Unidad As DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As DataGridViewTextBoxColumn
    Friend WithEvents PrecioUnitario As DataGridViewTextBoxColumn
    Friend WithEvents VentaNoSujetas As DataGridViewTextBoxColumn
    Friend WithEvents VentasExentas As DataGridViewTextBoxColumn
    Friend WithEvents VentasGrabadas As DataGridViewTextBoxColumn
    Friend WithEvents tipo As DataGridViewTextBoxColumn
    Friend WithEvents Id_Product As DataGridViewTextBoxColumn
    Private WithEvents CB_FormaPago As ComboBox
    Private WithEvents txtNIT As TextBox
    Private WithEvents txtNRC As TextBox
    Private WithEvents Label4 As Label
    Private WithEvents Label3 As Label
    Private WithEvents txtRazonSocial As TextBox
    Private WithEvents Label2 As Label
    Private WithEvents cmdCancel As Button
    Private WithEvents cmdPrint As Button
    Private WithEvents txtPartida_NoPartida As TextBox
    Private WithEvents label50 As Label
    Private WithEvents label49 As Label
    Private WithEvents ComboBox1 As ComboBox
    Private WithEvents TextBox1 As TextBox
    Private WithEvents Label1 As Label
    Private WithEvents Label9 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents ProductosInterno As TabPage
    Friend WithEvents PresupuestosExterno As TabPage
    Friend WithEvents RecursosHumanos As TabPage
    Friend WithEvents Otros As TabPage
End Class
