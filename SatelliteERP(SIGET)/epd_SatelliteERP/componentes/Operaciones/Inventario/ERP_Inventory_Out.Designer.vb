<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ERP_Inventory_Out
	Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbAverias = New System.Windows.Forms.RadioButton()
        Me.rbTransito = New System.Windows.Forms.RadioButton()
        Me.rbTraslado = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdProc = New System.Windows.Forms.Button()
        Me.DETALLE = New System.Windows.Forms.DataGridView()
        Me.CMS_Product = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.ID_Proveedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BarCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Unit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DETALLE, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CMS_Product.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.rbAverias)
        Me.GroupBox1.Controls.Add(Me.rbTransito)
        Me.GroupBox1.Controls.Add(Me.rbTraslado)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cmdProc)
        Me.GroupBox1.Controls.Add(Me.DETALLE)
        Me.GroupBox1.Controls.Add(Me.cmdCancel)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(14, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(847, 472)
        Me.GroupBox1.TabIndex = 31
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Salida de Inventario"
        '
        'rbAverias
        '
        Me.rbAverias.AutoSize = True
        Me.rbAverias.Location = New System.Drawing.Point(355, 41)
        Me.rbAverias.Name = "rbAverias"
        Me.rbAverias.Size = New System.Drawing.Size(109, 29)
        Me.rbAverias.TabIndex = 47
        Me.rbAverias.Text = "Averias"
        Me.rbAverias.UseVisualStyleBackColor = True
        '
        'rbTransito
        '
        Me.rbTransito.AutoSize = True
        Me.rbTransito.Location = New System.Drawing.Point(233, 41)
        Me.rbTransito.Name = "rbTransito"
        Me.rbTransito.Size = New System.Drawing.Size(116, 29)
        Me.rbTransito.TabIndex = 46
        Me.rbTransito.Text = "Transito"
        Me.rbTransito.UseVisualStyleBackColor = True
        '
        'rbTraslado
        '
        Me.rbTraslado.AutoSize = True
        Me.rbTraslado.Checked = True
        Me.rbTraslado.Location = New System.Drawing.Point(105, 41)
        Me.rbTraslado.Name = "rbTraslado"
        Me.rbTraslado.Size = New System.Drawing.Size(122, 29)
        Me.rbTraslado.TabIndex = 45
        Me.rbTraslado.TabStop = True
        Me.rbTraslado.Text = "Traslado"
        Me.rbTraslado.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 25)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "Tipo:"
        '
        'cmdProc
        '
        Me.cmdProc.BackColor = System.Drawing.Color.Gainsboro
        Me.cmdProc.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdProc.FlatAppearance.BorderSize = 0
        Me.cmdProc.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.cmdProc.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.cmdProc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdProc.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdProc.Location = New System.Drawing.Point(639, 425)
        Me.cmdProc.Name = "cmdProc"
        Me.cmdProc.Size = New System.Drawing.Size(98, 29)
        Me.cmdProc.TabIndex = 43
        Me.cmdProc.Text = "Procesar"
        Me.cmdProc.UseVisualStyleBackColor = False
        '
        'DETALLE
        '
        Me.DETALLE.AllowUserToAddRows = False
        Me.DETALLE.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DETALLE.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DETALLE.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID_Proveedor, Me.BarCode, Me.Unit, Me.Descripcion, Me.price, Me.Quantity})
        Me.DETALLE.ContextMenuStrip = Me.CMS_Product
        Me.DETALLE.EnableHeadersVisualStyles = False
        Me.DETALLE.Location = New System.Drawing.Point(6, 92)
        Me.DETALLE.Name = "DETALLE"
        Me.DETALLE.RowHeadersVisible = False
        Me.DETALLE.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DETALLE.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DETALLE.Size = New System.Drawing.Size(835, 305)
        Me.DETALLE.TabIndex = 6
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
        'cmdCancel
        '
        Me.cmdCancel.BackColor = System.Drawing.Color.Gainsboro
        Me.cmdCancel.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdCancel.FlatAppearance.BorderSize = 0
        Me.cmdCancel.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.cmdCancel.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.cmdCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCancel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancel.Location = New System.Drawing.Point(743, 425)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(98, 29)
        Me.cmdCancel.TabIndex = 30
        Me.cmdCancel.Text = "Cancelar"
        Me.cmdCancel.UseVisualStyleBackColor = False
        '
        'ID_Proveedor
        '
        Me.ID_Proveedor.HeaderText = "ID_Proveedor"
        Me.ID_Proveedor.Name = "ID_Proveedor"
        Me.ID_Proveedor.ReadOnly = True
        Me.ID_Proveedor.Visible = False
        Me.ID_Proveedor.Width = 80
        '
        'BarCode
        '
        Me.BarCode.HeaderText = "Código de Barra"
        Me.BarCode.Name = "BarCode"
        Me.BarCode.ReadOnly = True
        Me.BarCode.Width = 60
        '
        'Unit
        '
        Me.Unit.HeaderText = "Unidad de Medida"
        Me.Unit.Name = "Unit"
        Me.Unit.ReadOnly = True
        Me.Unit.Width = 300
        '
        'Descripcion
        '
        Me.Descripcion.HeaderText = "Descripción"
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.ReadOnly = True
        '
        'price
        '
        Me.price.HeaderText = "Precio de venta"
        Me.price.Name = "price"
        Me.price.ReadOnly = True
        '
        'Quantity
        '
        Me.Quantity.HeaderText = "Cantidad"
        Me.Quantity.Name = "Quantity"
        Me.Quantity.ReadOnly = True
        '
        'ERP_Inventory_Out
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(873, 497)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "ERP_Inventory_Out"
        Me.Text = "ERP_Inventory_Out"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DETALLE, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CMS_Product.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
	Friend WithEvents rbAverias As RadioButton
	Friend WithEvents rbTransito As RadioButton
	Friend WithEvents rbTraslado As RadioButton
	Friend WithEvents Label1 As Label
	Private WithEvents cmdProc As Button
	Friend WithEvents DETALLE As DataGridView
	Private WithEvents cmdCancel As Button
	Friend WithEvents CMS_Product As ContextMenuStrip
	Friend WithEvents NuevoToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents EliminarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ID_Proveedor As DataGridViewTextBoxColumn
    Friend WithEvents BarCode As DataGridViewTextBoxColumn
    Friend WithEvents Unit As DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As DataGridViewTextBoxColumn
    Friend WithEvents price As DataGridViewTextBoxColumn
    Friend WithEvents Quantity As DataGridViewTextBoxColumn
End Class
