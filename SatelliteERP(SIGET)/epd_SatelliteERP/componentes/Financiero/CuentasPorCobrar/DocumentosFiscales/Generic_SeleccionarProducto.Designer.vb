<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Generic_SeleccionarProducto
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DGW_Products = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cmdSeleccionar = New System.Windows.Forms.Button()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.lblNoCuentaContable = New System.Windows.Forms.Label()
        Me.txtWhere = New System.Windows.Forms.TextBox()
        Me.Id_Product = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Correlativo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Name_Product = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Price_Sale = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Existensias = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioCompra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.unidadMedida = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGW_Products, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.DGW_Products)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.cmdSeleccionar)
        Me.GroupBox1.Controls.Add(Me.cmdCancel)
        Me.GroupBox1.Controls.Add(Me.lblNoCuentaContable)
        Me.GroupBox1.Controls.Add(Me.txtWhere)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(678, 409)
        Me.GroupBox1.TabIndex = 34
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Selección de Productos"
        '
        'DGW_Products
        '
        Me.DGW_Products.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGW_Products.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id_Product, Me.Correlativo, Me.Name_Product, Me.Price_Sale, Me.Existensias, Me.PrecioCompra, Me.unidadMedida})
        Me.DGW_Products.EnableHeadersVisualStyles = False
        Me.DGW_Products.Location = New System.Drawing.Point(12, 67)
        Me.DGW_Products.Name = "DGW_Products"
        Me.DGW_Products.RowHeadersVisible = False
        Me.DGW_Products.ShowCellErrors = False
        Me.DGW_Products.ShowCellToolTips = False
        Me.DGW_Products.ShowEditingIcon = False
        Me.DGW_Products.ShowRowErrors = False
        Me.DGW_Products.Size = New System.Drawing.Size(654, 296)
        Me.DGW_Products.TabIndex = 22
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Gainsboro
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(632, 34)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(34, 27)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "X"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'cmdSeleccionar
        '
        Me.cmdSeleccionar.BackColor = System.Drawing.Color.Gainsboro
        Me.cmdSeleccionar.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdSeleccionar.FlatAppearance.BorderSize = 0
        Me.cmdSeleccionar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.cmdSeleccionar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.cmdSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdSeleccionar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSeleccionar.Location = New System.Drawing.Point(437, 370)
        Me.cmdSeleccionar.Name = "cmdSeleccionar"
        Me.cmdSeleccionar.Size = New System.Drawing.Size(98, 29)
        Me.cmdSeleccionar.TabIndex = 6
        Me.cmdSeleccionar.Text = "Seleccionar"
        Me.cmdSeleccionar.UseVisualStyleBackColor = False
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
        Me.cmdCancel.Location = New System.Drawing.Point(547, 369)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(98, 29)
        Me.cmdCancel.TabIndex = 6
        Me.cmdCancel.Text = "Cancelar"
        Me.cmdCancel.UseVisualStyleBackColor = False
        '
        'lblNoCuentaContable
        '
        Me.lblNoCuentaContable.AutoSize = True
        Me.lblNoCuentaContable.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.lblNoCuentaContable.Location = New System.Drawing.Point(11, 35)
        Me.lblNoCuentaContable.Name = "lblNoCuentaContable"
        Me.lblNoCuentaContable.Size = New System.Drawing.Size(82, 25)
        Me.lblNoCuentaContable.TabIndex = 20
        Me.lblNoCuentaContable.Text = "Buscar : "
        '
        'txtWhere
        '
        Me.txtWhere.BackColor = System.Drawing.Color.Gainsboro
        Me.txtWhere.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtWhere.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWhere.Location = New System.Drawing.Point(98, 35)
        Me.txtWhere.MaxLength = 50
        Me.txtWhere.Name = "txtWhere"
        Me.txtWhere.ShortcutsEnabled = False
        Me.txtWhere.Size = New System.Drawing.Size(528, 26)
        Me.txtWhere.TabIndex = 1
        '
        'Id_Product
        '
        Me.Id_Product.DataPropertyName = "Id_Product"
        Me.Id_Product.HeaderText = "Correlativo"
        Me.Id_Product.Name = "Id_Product"
        Me.Id_Product.Visible = False
        Me.Id_Product.Width = 175
        '
        'Correlativo
        '
        Me.Correlativo.DataPropertyName = "number_purchase"
        Me.Correlativo.HeaderText = "Correlativo"
        Me.Correlativo.Name = "Correlativo"
        Me.Correlativo.Width = 175
        '
        'Name_Product
        '
        Me.Name_Product.DataPropertyName = "Name_Product"
        Me.Name_Product.HeaderText = "Producto"
        Me.Name_Product.Name = "Name_Product"
        Me.Name_Product.Width = 475
        '
        'Price_Sale
        '
        Me.Price_Sale.DataPropertyName = "Price_LastPpurchase"
        Me.Price_Sale.HeaderText = "Precio Uni."
        Me.Price_Sale.Name = "Price_Sale"
        Me.Price_Sale.Visible = False
        '
        'Existensias
        '
        Me.Existensias.DataPropertyName = "0"
        Me.Existensias.HeaderText = "Exitencias"
        Me.Existensias.Name = "Existensias"
        Me.Existensias.Visible = False
        Me.Existensias.Width = 93
        '
        'PrecioCompra
        '
        Me.PrecioCompra.DataPropertyName = "Price_LastPpurchase"
        Me.PrecioCompra.HeaderText = "PrecioCompra"
        Me.PrecioCompra.Name = "PrecioCompra"
        Me.PrecioCompra.Visible = False
        '
        'unidadMedida
        '
        Me.unidadMedida.DataPropertyName = "Name_UnitMeasure"
        Me.unidadMedida.HeaderText = "UnidadMedida"
        Me.unidadMedida.Name = "unidadMedida"
        Me.unidadMedida.Visible = False
        '
        'Generic_SeleccionarProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CadetBlue
        Me.ClientSize = New System.Drawing.Size(697, 434)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Generic_SeleccionarProducto"
        Me.Text = "Generic_SeleccionarCliente"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DGW_Products, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Private WithEvents Button1 As Button
    Private WithEvents cmdCancel As Button
    Private WithEvents lblNoCuentaContable As Label
    Private WithEvents txtWhere As TextBox
    Friend WithEvents DGW_Products As DataGridView
    Private WithEvents cmdSeleccionar As Button
    Friend WithEvents Id_Product As DataGridViewTextBoxColumn
    Friend WithEvents Correlativo As DataGridViewTextBoxColumn
    Friend WithEvents Name_Product As DataGridViewTextBoxColumn
    Friend WithEvents Price_Sale As DataGridViewTextBoxColumn
    Friend WithEvents Existensias As DataGridViewTextBoxColumn
    Friend WithEvents PrecioCompra As DataGridViewTextBoxColumn
    Friend WithEvents unidadMedida As DataGridViewTextBoxColumn
End Class
