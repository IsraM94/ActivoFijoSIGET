<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ERP_Inventory_CreateRecipe
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
        Me.GBPrimary = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cbProducts = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgvIngredients = New System.Windows.Forms.DataGridView()
        Me.Correlativo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID_Unit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnidadMedida = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tsmAdd = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmDelete = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdSaveRecipe = New System.Windows.Forms.Button()
        Me.GroupBoxEmployee = New System.Windows.Forms.GroupBox()
        Me.txtNameProduct = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblBarra = New System.Windows.Forms.Label()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.lblIDProduct = New System.Windows.Forms.Label()
        Me.lblCliente = New System.Windows.Forms.Label()
        Me.cmdCancelRecipe = New System.Windows.Forms.Button()
        Me.GBPrimary.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvIngredients, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.GroupBoxEmployee.SuspendLayout()
        Me.SuspendLayout()
        '
        'GBPrimary
        '
        Me.GBPrimary.BackColor = System.Drawing.SystemColors.Control
        Me.GBPrimary.Controls.Add(Me.GroupBox3)
        Me.GBPrimary.Controls.Add(Me.GroupBox2)
        Me.GBPrimary.Controls.Add(Me.cmdSaveRecipe)
        Me.GBPrimary.Controls.Add(Me.GroupBoxEmployee)
        Me.GBPrimary.Controls.Add(Me.cmdCancelRecipe)
        Me.GBPrimary.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GBPrimary.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBPrimary.Location = New System.Drawing.Point(8, 5)
        Me.GBPrimary.Name = "GBPrimary"
        Me.GBPrimary.Size = New System.Drawing.Size(816, 540)
        Me.GBPrimary.TabIndex = 1
        Me.GBPrimary.TabStop = False
        Me.GBPrimary.Text = "Agregar Receta"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cbProducts)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(19, 31)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Size = New System.Drawing.Size(792, 64)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Producto"
        '
        'cbProducts
        '
        Me.cbProducts.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbProducts.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbProducts.BackColor = System.Drawing.Color.Gainsboro
        Me.cbProducts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbProducts.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbProducts.FormattingEnabled = True
        Me.cbProducts.Location = New System.Drawing.Point(99, 27)
        Me.cbProducts.Name = "cbProducts"
        Me.cbProducts.Size = New System.Drawing.Size(688, 29)
        Me.cbProducts.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(9, 28)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 25)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Producto:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgvIngredients)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(19, 223)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(787, 273)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos Receta"
        '
        'dgvIngredients
        '
        Me.dgvIngredients.AllowUserToAddRows = False
        Me.dgvIngredients.AllowUserToDeleteRows = False
        Me.dgvIngredients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvIngredients.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Correlativo, Me.ID, Me.ID_Unit, Me.Descripcion, Me.UnidadMedida, Me.Cantidad})
        Me.dgvIngredients.ContextMenuStrip = Me.ContextMenuStrip1
        Me.dgvIngredients.Location = New System.Drawing.Point(14, 31)
        Me.dgvIngredients.MultiSelect = False
        Me.dgvIngredients.Name = "dgvIngredients"
        Me.dgvIngredients.ReadOnly = True
        Me.dgvIngredients.RowHeadersVisible = False
        Me.dgvIngredients.Size = New System.Drawing.Size(768, 227)
        Me.dgvIngredients.TabIndex = 0
        '
        'Correlativo
        '
        Me.Correlativo.DataPropertyName = "ID_Product"
        Me.Correlativo.HeaderText = "Correlativo"
        Me.Correlativo.Name = "Correlativo"
        Me.Correlativo.ReadOnly = True
        Me.Correlativo.Width = 150
        '
        'ID
        '
        Me.ID.DataPropertyName = "ID"
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.Visible = False
        '
        'ID_Unit
        '
        Me.ID_Unit.DataPropertyName = "ID_Unit"
        Me.ID_Unit.HeaderText = "ID_Unit"
        Me.ID_Unit.Name = "ID_Unit"
        Me.ID_Unit.ReadOnly = True
        Me.ID_Unit.Visible = False
        '
        'Descripcion
        '
        Me.Descripcion.DataPropertyName = "Description"
        Me.Descripcion.HeaderText = "Descripción"
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.ReadOnly = True
        Me.Descripcion.Width = 340
        '
        'UnidadMedida
        '
        Me.UnidadMedida.DataPropertyName = "DescriptionUnit"
        Me.UnidadMedida.HeaderText = "Unidad de Medida"
        Me.UnidadMedida.Name = "UnidadMedida"
        Me.UnidadMedida.ReadOnly = True
        Me.UnidadMedida.Width = 175
        '
        'Cantidad
        '
        Me.Cantidad.DataPropertyName = "Quantity"
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.ReadOnly = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmAdd, Me.EditarToolStripMenuItem, Me.tsmDelete})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(118, 70)
        '
        'tsmAdd
        '
        Me.tsmAdd.Name = "tsmAdd"
        Me.tsmAdd.Size = New System.Drawing.Size(117, 22)
        Me.tsmAdd.Text = "Agregar"
        '
        'EditarToolStripMenuItem
        '
        Me.EditarToolStripMenuItem.Name = "EditarToolStripMenuItem"
        Me.EditarToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.EditarToolStripMenuItem.Text = "Editar"
        '
        'tsmDelete
        '
        Me.tsmDelete.Name = "tsmDelete"
        Me.tsmDelete.Size = New System.Drawing.Size(117, 22)
        Me.tsmDelete.Text = "Eliminar"
        '
        'cmdSaveRecipe
        '
        Me.cmdSaveRecipe.BackColor = System.Drawing.Color.Gainsboro
        Me.cmdSaveRecipe.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdSaveRecipe.FlatAppearance.BorderSize = 0
        Me.cmdSaveRecipe.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.cmdSaveRecipe.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.cmdSaveRecipe.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdSaveRecipe.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSaveRecipe.Location = New System.Drawing.Point(599, 506)
        Me.cmdSaveRecipe.Name = "cmdSaveRecipe"
        Me.cmdSaveRecipe.Size = New System.Drawing.Size(98, 28)
        Me.cmdSaveRecipe.TabIndex = 5
        Me.cmdSaveRecipe.Text = "Guardar"
        Me.cmdSaveRecipe.UseVisualStyleBackColor = False
        '
        'GroupBoxEmployee
        '
        Me.GroupBoxEmployee.Controls.Add(Me.txtNameProduct)
        Me.GroupBoxEmployee.Controls.Add(Me.Label1)
        Me.GroupBoxEmployee.Controls.Add(Me.lblBarra)
        Me.GroupBoxEmployee.Controls.Add(Me.lbl1)
        Me.GroupBoxEmployee.Controls.Add(Me.lblIDProduct)
        Me.GroupBoxEmployee.Controls.Add(Me.lblCliente)
        Me.GroupBoxEmployee.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxEmployee.Location = New System.Drawing.Point(19, 97)
        Me.GroupBoxEmployee.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBoxEmployee.Name = "GroupBoxEmployee"
        Me.GroupBoxEmployee.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBoxEmployee.Size = New System.Drawing.Size(787, 125)
        Me.GroupBoxEmployee.TabIndex = 0
        Me.GroupBoxEmployee.TabStop = False
        Me.GroupBoxEmployee.Text = "Datos Producto"
        '
        'txtNameProduct
        '
        Me.txtNameProduct.Enabled = False
        Me.txtNameProduct.Location = New System.Drawing.Point(139, 70)
        Me.txtNameProduct.Multiline = True
        Me.txtNameProduct.Name = "txtNameProduct"
        Me.txtNameProduct.ReadOnly = True
        Me.txtNameProduct.Size = New System.Drawing.Size(643, 50)
        Me.txtNameProduct.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Descripción:"
        '
        'lblBarra
        '
        Me.lblBarra.AutoSize = True
        Me.lblBarra.Font = New System.Drawing.Font("Segoe UI", 12.25!)
        Me.lblBarra.Location = New System.Drawing.Point(477, 33)
        Me.lblBarra.Name = "lblBarra"
        Me.lblBarra.Size = New System.Drawing.Size(52, 23)
        Me.lblBarra.TabIndex = 0
        Me.lblBarra.Text = "None"
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.lbl1.Location = New System.Drawing.Point(378, 36)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(66, 25)
        Me.lbl1.TabIndex = 0
        Me.lbl1.Text = "Barra :"
        '
        'lblIDProduct
        '
        Me.lblIDProduct.AutoSize = True
        Me.lblIDProduct.Font = New System.Drawing.Font("Segoe UI", 12.25!)
        Me.lblIDProduct.Location = New System.Drawing.Point(208, 36)
        Me.lblIDProduct.Name = "lblIDProduct"
        Me.lblIDProduct.Size = New System.Drawing.Size(52, 23)
        Me.lblIDProduct.TabIndex = 0
        Me.lblIDProduct.Text = "None"
        '
        'lblCliente
        '
        Me.lblCliente.AutoSize = True
        Me.lblCliente.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCliente.Location = New System.Drawing.Point(21, 33)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(185, 25)
        Me.lblCliente.TabIndex = 0
        Me.lblCliente.Text = "Código de Producto:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'cmdCancelRecipe
        '
        Me.cmdCancelRecipe.BackColor = System.Drawing.Color.Gainsboro
        Me.cmdCancelRecipe.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdCancelRecipe.FlatAppearance.BorderSize = 0
        Me.cmdCancelRecipe.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.cmdCancelRecipe.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.cmdCancelRecipe.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCancelRecipe.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelRecipe.Location = New System.Drawing.Point(703, 506)
        Me.cmdCancelRecipe.Name = "cmdCancelRecipe"
        Me.cmdCancelRecipe.Size = New System.Drawing.Size(98, 28)
        Me.cmdCancelRecipe.TabIndex = 4
        Me.cmdCancelRecipe.Text = "Cancelar"
        Me.cmdCancelRecipe.UseVisualStyleBackColor = False
        '
        'ERP_Inventory_CreateRecipe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(836, 551)
        Me.Controls.Add(Me.GBPrimary)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ERP_Inventory_CreateRecipe"
        Me.Text = "ERP_Inventory_CreateRecipe"
        Me.GBPrimary.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgvIngredients, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.GroupBoxEmployee.ResumeLayout(False)
        Me.GroupBoxEmployee.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GBPrimary As GroupBox
	Private WithEvents cmdSaveRecipe As Button
	Friend WithEvents GroupBoxEmployee As GroupBox
	Friend WithEvents txtNameProduct As TextBox
	Private WithEvents Label1 As Label
	Private WithEvents lblBarra As Label
	Private WithEvents lbl1 As Label
	Private WithEvents lblIDProduct As Label
	Private WithEvents lblCliente As Label
	Private WithEvents cmdCancelRecipe As Button
	Friend WithEvents GroupBox2 As GroupBox
	Friend WithEvents GroupBox3 As GroupBox
	Private WithEvents Label6 As Label
	Private WithEvents cbProducts As ComboBox
	Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
	Friend WithEvents tsmAdd As ToolStripMenuItem
	Friend WithEvents tsmDelete As ToolStripMenuItem
	Friend WithEvents dgvIngredients As DataGridView
	Friend WithEvents Correlativo As DataGridViewTextBoxColumn
	Friend WithEvents ID As DataGridViewTextBoxColumn
	Friend WithEvents ID_Unit As DataGridViewTextBoxColumn
	Friend WithEvents Descripcion As DataGridViewTextBoxColumn
	Friend WithEvents UnidadMedida As DataGridViewTextBoxColumn
	Friend WithEvents Cantidad As DataGridViewTextBoxColumn
	Friend WithEvents EditarToolStripMenuItem As ToolStripMenuItem
End Class
