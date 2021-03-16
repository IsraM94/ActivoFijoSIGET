<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Production_AnimalsToSacrifice
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgvProduction = New System.Windows.Forms.DataGridView()
        Me.Id_Product = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Name_Product = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descripcion_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuProd = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.dgvDetails = New System.Windows.Forms.DataGridView()
        Me.Producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_animal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameAnimal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodigoTipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Peso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Procesar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Menu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdprint = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvProduction, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuProd.SuspendLayout()
        CType(Me.dgvDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Menu.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.dgvProduction)
        Me.GroupBox1.Controls.Add(Me.cmdCancel)
        Me.GroupBox1.Controls.Add(Me.dgvDetails)
        Me.GroupBox1.Controls.Add(Me.cmdprint)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(7, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(796, 677)
        Me.GroupBox1.TabIndex = 35
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Lista Producción"
        '
        'dgvProduction
        '
        Me.dgvProduction.AllowUserToAddRows = False
        Me.dgvProduction.AllowUserToDeleteRows = False
        Me.dgvProduction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProduction.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id_Product, Me.Name_Product, Me.Cantidad, Me.descripcion_name})
        Me.dgvProduction.ContextMenuStrip = Me.MenuProd
        Me.dgvProduction.EnableHeadersVisualStyles = False
        Me.dgvProduction.Location = New System.Drawing.Point(6, 238)
        Me.dgvProduction.Name = "dgvProduction"
        Me.dgvProduction.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvProduction.RowHeadersVisible = False
        Me.dgvProduction.Size = New System.Drawing.Size(779, 377)
        Me.dgvProduction.TabIndex = 34
        '
        'Id_Product
        '
        Me.Id_Product.DataPropertyName = "Id_Product"
        Me.Id_Product.HeaderText = "Código Producto"
        Me.Id_Product.Name = "Id_Product"
        Me.Id_Product.ReadOnly = True
        Me.Id_Product.Width = 150
        '
        'Name_Product
        '
        Me.Name_Product.DataPropertyName = "Name_Product"
        Me.Name_Product.HeaderText = "Nombre Producto"
        Me.Name_Product.Name = "Name_Product"
        Me.Name_Product.ReadOnly = True
        Me.Name_Product.Width = 320
        '
        'Cantidad
        '
        Me.Cantidad.DataPropertyName = "Cantidad"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Cantidad.DefaultCellStyle = DataGridViewCellStyle1
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.Width = 150
        '
        'descripcion_name
        '
        Me.descripcion_name.DataPropertyName = "descripcion_name"
        Me.descripcion_name.HeaderText = "Unidad de Medida"
        Me.descripcion_name.Name = "descripcion_name"
        Me.descripcion_name.ReadOnly = True
        Me.descripcion_name.Width = 150
        '
        'MenuProd
        '
        Me.MenuProd.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.MenuProd.Name = "Menu"
        Me.MenuProd.Size = New System.Drawing.Size(105, 26)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(104, 22)
        Me.ToolStripMenuItem1.Text = "Editar"
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
        Me.cmdCancel.Location = New System.Drawing.Point(402, 636)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(98, 29)
        Me.cmdCancel.TabIndex = 33
        Me.cmdCancel.Text = "Cancelar"
        Me.cmdCancel.UseVisualStyleBackColor = False
        '
        'dgvDetails
        '
        Me.dgvDetails.AllowUserToAddRows = False
        Me.dgvDetails.AllowUserToDeleteRows = False
        Me.dgvDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetails.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Producto, Me.id_animal, Me.NameAnimal, Me.Tipo, Me.CodigoTipo, Me.Peso, Me.Procesar})
        Me.dgvDetails.ContextMenuStrip = Me.Menu
        Me.dgvDetails.EnableHeadersVisualStyles = False
        Me.dgvDetails.Location = New System.Drawing.Point(6, 32)
        Me.dgvDetails.Name = "dgvDetails"
        Me.dgvDetails.ReadOnly = True
        Me.dgvDetails.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvDetails.RowHeadersVisible = False
        Me.dgvDetails.Size = New System.Drawing.Size(779, 183)
        Me.dgvDetails.TabIndex = 32
        '
        'Producto
        '
        Me.Producto.DataPropertyName = "id_animal"
        Me.Producto.HeaderText = "Código"
        Me.Producto.Name = "Producto"
        Me.Producto.ReadOnly = True
        Me.Producto.Width = 150
        '
        'id_animal
        '
        Me.id_animal.DataPropertyName = "id_animal"
        Me.id_animal.HeaderText = "id_animal"
        Me.id_animal.Name = "id_animal"
        Me.id_animal.ReadOnly = True
        Me.id_animal.Visible = False
        '
        'NameAnimal
        '
        Me.NameAnimal.DataPropertyName = "NameAnimal"
        Me.NameAnimal.HeaderText = "Nombre "
        Me.NameAnimal.Name = "NameAnimal"
        Me.NameAnimal.ReadOnly = True
        Me.NameAnimal.Width = 325
        '
        'Tipo
        '
        Me.Tipo.DataPropertyName = "Tipo"
        Me.Tipo.HeaderText = "Tipo"
        Me.Tipo.Name = "Tipo"
        Me.Tipo.ReadOnly = True
        '
        'CodigoTipo
        '
        Me.CodigoTipo.DataPropertyName = "CodigoTipo"
        Me.CodigoTipo.HeaderText = "CódigoTipo"
        Me.CodigoTipo.Name = "CodigoTipo"
        Me.CodigoTipo.ReadOnly = True
        Me.CodigoTipo.Visible = False
        '
        'Peso
        '
        Me.Peso.DataPropertyName = "Peso"
        Me.Peso.HeaderText = "Peso"
        Me.Peso.Name = "Peso"
        Me.Peso.ReadOnly = True
        '
        'Procesar
        '
        Me.Procesar.DataPropertyName = "Procesar"
        Me.Procesar.HeaderText = "Procesar"
        Me.Procesar.Name = "Procesar"
        Me.Procesar.ReadOnly = True
        Me.Procesar.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Procesar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'Menu
        '
        Me.Menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditarToolStripMenuItem})
        Me.Menu.Name = "Menu"
        Me.Menu.Size = New System.Drawing.Size(105, 26)
        '
        'EditarToolStripMenuItem
        '
        Me.EditarToolStripMenuItem.Name = "EditarToolStripMenuItem"
        Me.EditarToolStripMenuItem.Size = New System.Drawing.Size(104, 22)
        Me.EditarToolStripMenuItem.Text = "Editar"
        '
        'cmdprint
        '
        Me.cmdprint.BackColor = System.Drawing.Color.Gainsboro
        Me.cmdprint.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdprint.FlatAppearance.BorderSize = 0
        Me.cmdprint.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.cmdprint.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.cmdprint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdprint.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdprint.Location = New System.Drawing.Point(298, 636)
        Me.cmdprint.Name = "cmdprint"
        Me.cmdprint.Size = New System.Drawing.Size(98, 29)
        Me.cmdprint.TabIndex = 31
        Me.cmdprint.Text = "Guardar"
        Me.cmdprint.UseVisualStyleBackColor = False
        '
        'Production_AnimalsToSacrifice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(815, 696)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Production_AnimalsToSacrifice"
        Me.Text = "Production_Sacrifice"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgvProduction, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuProd.ResumeLayout(False)
        CType(Me.dgvDetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Menu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
	Private WithEvents cmdCancel As Button
	Friend WithEvents dgvDetails As DataGridView
	Private WithEvents cmdprint As Button
	Friend WithEvents Menu As ContextMenuStrip
	Friend WithEvents EditarToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents dgvProduction As DataGridView
	Friend WithEvents MenuProd As ContextMenuStrip
	Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents Id_Product As DataGridViewTextBoxColumn
    Friend WithEvents Name_Product As DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents descripcion_name As DataGridViewTextBoxColumn
    Friend WithEvents Producto As DataGridViewTextBoxColumn
    Friend WithEvents id_animal As DataGridViewTextBoxColumn
    Friend WithEvents NameAnimal As DataGridViewTextBoxColumn
    Friend WithEvents Tipo As DataGridViewTextBoxColumn
    Friend WithEvents CodigoTipo As DataGridViewTextBoxColumn
    Friend WithEvents Peso As DataGridViewTextBoxColumn
    Friend WithEvents Procesar As DataGridViewCheckBoxColumn
End Class
