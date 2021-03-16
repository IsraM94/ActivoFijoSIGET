<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Production_OutputAnimals
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
        Me.rbHijos = New System.Windows.Forms.RadioButton()
        Me.rbMother = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cbLote = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbBodega = New System.Windows.Forms.ComboBox()
        Me.txtComentario = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbTipoSalida = New System.Windows.Forms.ComboBox()
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
        Me.cmdNext = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Menu.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.rbHijos)
        Me.GroupBox1.Controls.Add(Me.rbMother)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.cmdCancel)
        Me.GroupBox1.Controls.Add(Me.dgvDetails)
        Me.GroupBox1.Controls.Add(Me.cmdNext)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(6, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(796, 559)
        Me.GroupBox1.TabIndex = 37
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Lista Animales"
        '
        'rbHijos
        '
        Me.rbHijos.AutoSize = True
        Me.rbHijos.Location = New System.Drawing.Point(119, 24)
        Me.rbHijos.Name = "rbHijos"
        Me.rbHijos.Size = New System.Drawing.Size(75, 29)
        Me.rbHijos.TabIndex = 53
        Me.rbHijos.TabStop = True
        Me.rbHijos.Text = "Hijos"
        Me.rbHijos.UseVisualStyleBackColor = True
        '
        'rbMother
        '
        Me.rbMother.AutoSize = True
        Me.rbMother.Location = New System.Drawing.Point(18, 24)
        Me.rbMother.Name = "rbMother"
        Me.rbMother.Size = New System.Drawing.Size(96, 29)
        Me.rbMother.TabIndex = 52
        Me.rbMother.TabStop = True
        Me.rbMother.Text = "Madres"
        Me.rbMother.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cbLote)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.cbBodega)
        Me.GroupBox2.Controls.Add(Me.txtComentario)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.cbTipoSalida)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(14, 297)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(776, 221)
        Me.GroupBox2.TabIndex = 51
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Detalle de salida"
        '
        'cbLote
        '
        Me.cbLote.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbLote.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbLote.BackColor = System.Drawing.Color.Gainsboro
        Me.cbLote.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbLote.Enabled = False
        Me.cbLote.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbLote.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbLote.FormattingEnabled = True
        Me.cbLote.Location = New System.Drawing.Point(121, 62)
        Me.cbLote.Name = "cbLote"
        Me.cbLote.Size = New System.Drawing.Size(646, 29)
        Me.cbLote.TabIndex = 57
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(-1, 62)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(125, 26)
        Me.Label5.TabIndex = 58
        Me.Label5.Text = "Lote Destino:"
        '
        'cbBodega
        '
        Me.cbBodega.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbBodega.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbBodega.BackColor = System.Drawing.Color.Gainsboro
        Me.cbBodega.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbBodega.Enabled = False
        Me.cbBodega.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbBodega.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbBodega.FormattingEnabled = True
        Me.cbBodega.Location = New System.Drawing.Point(121, 94)
        Me.cbBodega.Name = "cbBodega"
        Me.cbBodega.Size = New System.Drawing.Size(646, 29)
        Me.cbBodega.TabIndex = 53
        '
        'txtComentario
        '
        Me.txtComentario.BackColor = System.Drawing.Color.Gainsboro
        Me.txtComentario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtComentario.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtComentario.Location = New System.Drawing.Point(121, 134)
        Me.txtComentario.MaxLength = 150
        Me.txtComentario.Multiline = True
        Me.txtComentario.Name = "txtComentario"
        Me.txtComentario.Size = New System.Drawing.Size(646, 71)
        Me.txtComentario.TabIndex = 56
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(38, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 26)
        Me.Label3.TabIndex = 54
        Me.Label3.Text = "Destino:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 134)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(118, 26)
        Me.Label4.TabIndex = 55
        Me.Label4.Text = "Comentario:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(11, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 26)
        Me.Label2.TabIndex = 52
        Me.Label2.Text = "Tipo Salida:"
        '
        'cbTipoSalida
        '
        Me.cbTipoSalida.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbTipoSalida.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbTipoSalida.BackColor = System.Drawing.Color.Gainsboro
        Me.cbTipoSalida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTipoSalida.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbTipoSalida.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTipoSalida.FormattingEnabled = True
        Me.cbTipoSalida.Location = New System.Drawing.Point(121, 26)
        Me.cbTipoSalida.Name = "cbTipoSalida"
        Me.cbTipoSalida.Size = New System.Drawing.Size(646, 29)
        Me.cbTipoSalida.TabIndex = 51
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
        Me.cmdCancel.Location = New System.Drawing.Point(398, 524)
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
        Me.dgvDetails.Location = New System.Drawing.Point(11, 59)
        Me.dgvDetails.Name = "dgvDetails"
        Me.dgvDetails.ReadOnly = True
        Me.dgvDetails.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvDetails.RowHeadersVisible = False
        Me.dgvDetails.Size = New System.Drawing.Size(779, 232)
        Me.dgvDetails.TabIndex = 32
        '
        'Producto
        '
        Me.Producto.DataPropertyName = "id_animal"
        Me.Producto.HeaderText = "Código Animal"
        Me.Producto.Name = "Producto"
        Me.Producto.ReadOnly = True
        Me.Producto.Width = 200
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
        Me.NameAnimal.HeaderText = "Nombre Animal"
        Me.NameAnimal.Name = "NameAnimal"
        Me.NameAnimal.ReadOnly = True
        Me.NameAnimal.Width = 375
        '
        'Tipo
        '
        Me.Tipo.DataPropertyName = "Tipo"
        Me.Tipo.HeaderText = "Tipo"
        Me.Tipo.Name = "Tipo"
        Me.Tipo.ReadOnly = True
        Me.Tipo.Visible = False
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
        'cmdNext
        '
        Me.cmdNext.BackColor = System.Drawing.Color.Gainsboro
        Me.cmdNext.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdNext.FlatAppearance.BorderSize = 0
        Me.cmdNext.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.cmdNext.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.cmdNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdNext.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNext.Location = New System.Drawing.Point(294, 524)
        Me.cmdNext.Name = "cmdNext"
        Me.cmdNext.Size = New System.Drawing.Size(98, 29)
        Me.cmdNext.TabIndex = 31
        Me.cmdNext.Text = "Continuar"
        Me.cmdNext.UseVisualStyleBackColor = False
        '
        'Production_OutputAnimals
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(813, 575)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Production_OutputAnimals"
        Me.Text = "Production_OutputAnimals"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgvDetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Menu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
	Private WithEvents cmdCancel As Button
	Friend WithEvents dgvDetails As DataGridView
	Private WithEvents cmdNext As Button
	Friend WithEvents GroupBox2 As GroupBox
	Private WithEvents cbBodega As ComboBox
	Private WithEvents txtComentario As TextBox
	Friend WithEvents Label3 As Label
	Friend WithEvents Label4 As Label
	Friend WithEvents Label2 As Label
	Private WithEvents cbTipoSalida As ComboBox
    Friend WithEvents Menu As ContextMenuStrip
    Friend WithEvents EditarToolStripMenuItem As ToolStripMenuItem
    Private WithEvents cbLote As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents rbHijos As RadioButton
    Friend WithEvents rbMother As RadioButton
    Friend WithEvents Producto As DataGridViewTextBoxColumn
    Friend WithEvents id_animal As DataGridViewTextBoxColumn
    Friend WithEvents NameAnimal As DataGridViewTextBoxColumn
    Friend WithEvents Tipo As DataGridViewTextBoxColumn
    Friend WithEvents CodigoTipo As DataGridViewTextBoxColumn
    Friend WithEvents Peso As DataGridViewTextBoxColumn
    Friend WithEvents Procesar As DataGridViewCheckBoxColumn
End Class
