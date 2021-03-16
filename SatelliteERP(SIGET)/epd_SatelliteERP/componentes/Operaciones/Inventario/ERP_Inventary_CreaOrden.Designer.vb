<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ERP_Inventary_CreaOrden
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
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtTotalVenta = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
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
        Me.CMS_Product = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.GroupBox2.SuspendLayout()
        CType(Me.DETALLE, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CMS_Product.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.DETALLE)
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
        Me.GroupBox1.Location = New System.Drawing.Point(10, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(924, 581)
        Me.GroupBox1.TabIndex = 30
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Creación de Orden"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtTotalVenta)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Location = New System.Drawing.Point(310, 464)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(604, 71)
        Me.GroupBox2.TabIndex = 42
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Totales"
        '
        'txtTotalVenta
        '
        Me.txtTotalVenta.BackColor = System.Drawing.Color.Gainsboro
        Me.txtTotalVenta.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTotalVenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalVenta.Location = New System.Drawing.Point(431, 30)
        Me.txtTotalVenta.MaxLength = 14
        Me.txtTotalVenta.Name = "txtTotalVenta"
        Me.txtTotalVenta.ReadOnly = True
        Me.txtTotalVenta.Size = New System.Drawing.Size(157, 22)
        Me.txtTotalVenta.TabIndex = 30
        Me.txtTotalVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(297, 33)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(128, 20)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Estimado Orden:"
        '
        'DETALLE
        '
        Me.DETALLE.AllowUserToAddRows = False
        Me.DETALLE.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DETALLE.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DETALLE.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Cantidad, Me.Unidad, Me.Descripcion, Me.PrecioUnitario, Me.VentaNoSujetas, Me.VentasExentas, Me.VentasGrabadas, Me.tipo, Me.Id_Product})
        Me.DETALLE.ContextMenuStrip = Me.CMS_Product
        Me.DETALLE.EnableHeadersVisualStyles = False
        Me.DETALLE.Location = New System.Drawing.Point(6, 129)
        Me.DETALLE.Name = "DETALLE"
        Me.DETALLE.RowHeadersVisible = False
        Me.DETALLE.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DETALLE.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DETALLE.Size = New System.Drawing.Size(912, 329)
        Me.DETALLE.TabIndex = 6
        '
        'Cantidad
        '
        Me.Cantidad.HeaderText = "Cant. compra"
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.ReadOnly = True
        Me.Cantidad.Width = 180
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
        Me.VentasGrabadas.Width = 120
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
        'CMS_Product
        '
        Me.CMS_Product.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem, Me.EliminarToolStripMenuItem})
        Me.CMS_Product.Name = "CMS_Product"
        Me.CMS_Product.Size = New System.Drawing.Size(118, 48)
        '
        'NuevoToolStripMenuItem
        '
        Me.NuevoToolStripMenuItem.Name = "NuevoToolStripMenuItem"
        Me.NuevoToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.NuevoToolStripMenuItem.Text = "Nuevo"
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
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
        Me.CB_FormaPago.Location = New System.Drawing.Point(715, 91)
        Me.CB_FormaPago.Name = "CB_FormaPago"
        Me.CB_FormaPago.Size = New System.Drawing.Size(203, 29)
        Me.CB_FormaPago.TabIndex = 41
        '
        'txtNIT
        '
        Me.txtNIT.BackColor = System.Drawing.Color.Gainsboro
        Me.txtNIT.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNIT.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNIT.Location = New System.Drawing.Point(402, 94)
        Me.txtNIT.Name = "txtNIT"
        Me.txtNIT.Size = New System.Drawing.Size(171, 26)
        Me.txtNIT.TabIndex = 40
        '
        'txtNRC
        '
        Me.txtNRC.BackColor = System.Drawing.Color.Gainsboro
        Me.txtNRC.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNRC.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNRC.Location = New System.Drawing.Point(216, 97)
        Me.txtNRC.Name = "txtNRC"
        Me.txtNRC.Size = New System.Drawing.Size(141, 26)
        Me.txtNRC.TabIndex = 39
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(362, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 21)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "NIT : "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(151, 97)
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
        Me.txtRazonSocial.Location = New System.Drawing.Point(216, 59)
        Me.txtRazonSocial.Name = "txtRazonSocial"
        Me.txtRazonSocial.Size = New System.Drawing.Size(702, 26)
        Me.txtRazonSocial.TabIndex = 36
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(33, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(177, 25)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Nombre proveedor:"
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
        Me.txtPartida_NoPartida.Location = New System.Drawing.Point(650, 27)
        Me.txtPartida_NoPartida.Name = "txtPartida_NoPartida"
        Me.txtPartida_NoPartida.Size = New System.Drawing.Size(263, 26)
        Me.txtPartida_NoPartida.TabIndex = 22
        Me.txtPartida_NoPartida.Text = "0"
        Me.txtPartida_NoPartida.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'label50
        '
        Me.label50.AutoSize = True
        Me.label50.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label50.Location = New System.Drawing.Point(593, 32)
        Me.label50.Name = "label50"
        Me.label50.Size = New System.Drawing.Size(45, 21)
        Me.label50.TabIndex = 19
        Me.label50.Text = "No.  :"
        '
        'label49
        '
        Me.label49.AutoSize = True
        Me.label49.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label49.Location = New System.Drawing.Point(579, 97)
        Me.label49.Name = "label49"
        Me.label49.Size = New System.Drawing.Size(130, 21)
        Me.label49.TabIndex = 20
        Me.label49.Text = "Forma de Pago  : "
        '
        'ERP_Inventary_CreaOrden
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(943, 601)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ERP_Inventary_CreaOrden"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Financiero_DocumentoFiscal"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DETALLE, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CMS_Product.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Private WithEvents Label3 As Label
    Private WithEvents txtRazonSocial As TextBox
    Private WithEvents Label2 As Label
    Private WithEvents cmdCancel As Button
    Private WithEvents cmdPrint As Button
    Private WithEvents txtPartida_NoPartida As TextBox
    Private WithEvents label50 As Label
    Private WithEvents label49 As Label
    Private WithEvents txtNIT As TextBox
    Private WithEvents txtNRC As TextBox
    Private WithEvents Label4 As Label
    Private WithEvents CB_FormaPago As ComboBox
    Friend WithEvents DETALLE As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtTotalVenta As TextBox
    Friend WithEvents Label6 As Label
	Friend WithEvents CMS_Product As ContextMenuStrip
	Friend WithEvents NuevoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents Cantidad As DataGridViewTextBoxColumn
	Friend WithEvents Unidad As DataGridViewTextBoxColumn
	Friend WithEvents Descripcion As DataGridViewTextBoxColumn
	Friend WithEvents PrecioUnitario As DataGridViewTextBoxColumn
	Friend WithEvents VentaNoSujetas As DataGridViewTextBoxColumn
	Friend WithEvents VentasExentas As DataGridViewTextBoxColumn
	Friend WithEvents VentasGrabadas As DataGridViewTextBoxColumn
	Friend WithEvents tipo As DataGridViewTextBoxColumn
	Friend WithEvents Id_Product As DataGridViewTextBoxColumn
End Class
