<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ERP_InventorySuggestedShopping
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
        Me.dgvSugerido = New System.Windows.Forms.DataGridView()
        Me.Incluir = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.id_Product = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sugerido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID_Proveedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmtsOptions = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EDITARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.cmdGenerate = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.dgvSugerido, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmtsOptions.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvSugerido
        '
        Me.dgvSugerido.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgvSugerido.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvSugerido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSugerido.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Incluir, Me.id_Product, Me.Column2, Me.Column3, Me.Sugerido, Me.ID_Proveedor})
        Me.dgvSugerido.ContextMenuStrip = Me.cmtsOptions
        Me.dgvSugerido.EnableHeadersVisualStyles = False
        Me.dgvSugerido.Location = New System.Drawing.Point(11, 28)
        Me.dgvSugerido.MultiSelect = False
        Me.dgvSugerido.Name = "dgvSugerido"
        Me.dgvSugerido.RowHeadersVisible = False
        Me.dgvSugerido.Size = New System.Drawing.Size(751, 276)
        Me.dgvSugerido.TabIndex = 2
        '
        'Incluir
        '
        Me.Incluir.HeaderText = "Incluir"
        Me.Incluir.Name = "Incluir"
        '
        'id_Product
        '
        Me.id_Product.DataPropertyName = "id_Product"
        Me.id_Product.HeaderText = "Correlativo"
        Me.id_Product.Name = "id_Product"
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "Commercial_Name"
        Me.Column2.HeaderText = "Proveedor"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "Name_Product"
        Me.Column3.HeaderText = "Producto"
        Me.Column3.Name = "Column3"
        '
        'Sugerido
        '
        Me.Sugerido.DataPropertyName = "Sugerido"
        Me.Sugerido.HeaderText = "Sugerido"
        Me.Sugerido.Name = "Sugerido"
        '
        'ID_Proveedor
        '
        Me.ID_Proveedor.HeaderText = "ID_Proveedor"
        Me.ID_Proveedor.Name = "ID_Proveedor"
        Me.ID_Proveedor.Visible = False
        '
        'cmtsOptions
        '
        Me.cmtsOptions.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EDITARToolStripMenuItem})
        Me.cmtsOptions.Name = "cmtsOptions"
        Me.cmtsOptions.Size = New System.Drawing.Size(105, 26)
        '
        'EDITARToolStripMenuItem
        '
        Me.EDITARToolStripMenuItem.Name = "EDITARToolStripMenuItem"
        Me.EDITARToolStripMenuItem.Size = New System.Drawing.Size(104, 22)
        Me.EDITARToolStripMenuItem.Text = "Editar"
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
        Me.cmdCancel.Location = New System.Drawing.Point(659, 310)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(98, 29)
        Me.cmdCancel.TabIndex = 32
        Me.cmdCancel.Text = "Cancelar"
        Me.cmdCancel.UseVisualStyleBackColor = False
        '
        'cmdGenerate
        '
        Me.cmdGenerate.BackColor = System.Drawing.Color.Gainsboro
        Me.cmdGenerate.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdGenerate.FlatAppearance.BorderSize = 0
        Me.cmdGenerate.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.cmdGenerate.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.cmdGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdGenerate.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGenerate.Location = New System.Drawing.Point(555, 310)
        Me.cmdGenerate.Name = "cmdGenerate"
        Me.cmdGenerate.Size = New System.Drawing.Size(98, 29)
        Me.cmdGenerate.TabIndex = 31
        Me.cmdGenerate.Text = "Generar"
        Me.cmdGenerate.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.dgvSugerido)
        Me.GroupBox1.Controls.Add(Me.cmdGenerate)
        Me.GroupBox1.Controls.Add(Me.cmdCancel)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(771, 349)
        Me.GroupBox1.TabIndex = 33
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Generación de Órdenes de Compra Máximos y Mínimos"
        '
        'ERP_InventorySuggestedShopping
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(793, 374)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ERP_InventorySuggestedShopping"
        Me.Text = "ERP_InventorySuggestedShopping"
        CType(Me.dgvSugerido, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmtsOptions.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvSugerido As DataGridView
    Friend WithEvents cmtsOptions As ContextMenuStrip
    Friend WithEvents EDITARToolStripMenuItem As ToolStripMenuItem
    Private WithEvents cmdCancel As Button
    Private WithEvents cmdGenerate As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Incluir As DataGridViewCheckBoxColumn
    Friend WithEvents id_Product As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Sugerido As DataGridViewTextBoxColumn
    Friend WithEvents ID_Proveedor As DataGridViewTextBoxColumn
End Class
