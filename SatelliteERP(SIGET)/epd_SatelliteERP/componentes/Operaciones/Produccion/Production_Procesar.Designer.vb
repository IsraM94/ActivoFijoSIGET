<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Production_Procesar
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
        Me.cmdCompletarEtapa = New System.Windows.Forms.Button()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.dgvDetails = New System.Windows.Forms.DataGridView()
        Me.Producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID_Father = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID_Animal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.unidadMedida = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Procesado = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.cmsEdit = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Seleccionar = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdprint = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmsEdit.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.cmdCompletarEtapa)
        Me.GroupBox1.Controls.Add(Me.cmdCancel)
        Me.GroupBox1.Controls.Add(Me.dgvDetails)
        Me.GroupBox1.Controls.Add(Me.cmdprint)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(666, 428)
        Me.GroupBox1.TabIndex = 34
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Lista Producción"
        '
        'cmdCompletarEtapa
        '
        Me.cmdCompletarEtapa.BackColor = System.Drawing.Color.Gainsboro
        Me.cmdCompletarEtapa.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdCompletarEtapa.FlatAppearance.BorderSize = 0
        Me.cmdCompletarEtapa.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.cmdCompletarEtapa.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.cmdCompletarEtapa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCompletarEtapa.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCompletarEtapa.Location = New System.Drawing.Point(391, 385)
        Me.cmdCompletarEtapa.Name = "cmdCompletarEtapa"
        Me.cmdCompletarEtapa.Size = New System.Drawing.Size(155, 29)
        Me.cmdCompletarEtapa.TabIndex = 34
        Me.cmdCompletarEtapa.Text = "Completar Etapa"
        Me.cmdCompletarEtapa.UseVisualStyleBackColor = False
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
        Me.cmdCancel.Location = New System.Drawing.Point(552, 385)
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
        Me.dgvDetails.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Producto, Me.ID_Father, Me.ID_Animal, Me.unidadMedida, Me.Procesado})
        Me.dgvDetails.ContextMenuStrip = Me.cmsEdit
        Me.dgvDetails.EnableHeadersVisualStyles = False
        Me.dgvDetails.Location = New System.Drawing.Point(6, 32)
        Me.dgvDetails.Name = "dgvDetails"
        Me.dgvDetails.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvDetails.RowHeadersVisible = False
        Me.dgvDetails.Size = New System.Drawing.Size(644, 332)
        Me.dgvDetails.TabIndex = 32
        '
        'Producto
        '
        Me.Producto.DataPropertyName = "CodigoAnimal"
        Me.Producto.HeaderText = "Código Animal"
        Me.Producto.Name = "Producto"
        Me.Producto.ReadOnly = True
        Me.Producto.Width = 150
        '
        'ID_Father
        '
        Me.ID_Father.DataPropertyName = "ID_Father"
        Me.ID_Father.HeaderText = "ID_Father"
        Me.ID_Father.Name = "ID_Father"
        Me.ID_Father.Visible = False
        '
        'ID_Animal
        '
        Me.ID_Animal.DataPropertyName = "ID_Animal"
        Me.ID_Animal.HeaderText = "ID_Animal"
        Me.ID_Animal.Name = "ID_Animal"
        Me.ID_Animal.Visible = False
        '
        'unidadMedida
        '
        Me.unidadMedida.DataPropertyName = "NameAnimal"
        Me.unidadMedida.HeaderText = "Nombre Animal"
        Me.unidadMedida.Name = "unidadMedida"
        Me.unidadMedida.ReadOnly = True
        Me.unidadMedida.Width = 325
        '
        'Procesado
        '
        Me.Procesado.DataPropertyName = "Procesado"
        Me.Procesado.HeaderText = "Procesado"
        Me.Procesado.Name = "Procesado"
        Me.Procesado.Width = 165
        '
        'cmsEdit
        '
        Me.cmsEdit.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Seleccionar})
        Me.cmsEdit.Name = "cmsEdit"
        Me.cmsEdit.Size = New System.Drawing.Size(135, 26)
        '
        'Seleccionar
        '
        Me.Seleccionar.Name = "Seleccionar"
        Me.Seleccionar.Size = New System.Drawing.Size(134, 22)
        Me.Seleccionar.Text = "Seleccionar"
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
        Me.cmdprint.Location = New System.Drawing.Point(287, 385)
        Me.cmdprint.Name = "cmdprint"
        Me.cmdprint.Size = New System.Drawing.Size(98, 29)
        Me.cmdprint.TabIndex = 31
        Me.cmdprint.Text = "Guardar"
        Me.cmdprint.UseVisualStyleBackColor = False
        '
        'Production_Procesar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(690, 452)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Production_Procesar"
        Me.Text = "Production_Procesar"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgvDetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmsEdit.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Private WithEvents cmdCancel As Button
    Friend WithEvents dgvDetails As DataGridView
    Private WithEvents cmdprint As Button
    Private WithEvents cmdCompletarEtapa As Button
	Friend WithEvents cmsEdit As ContextMenuStrip
	Friend WithEvents Seleccionar As ToolStripMenuItem
    Friend WithEvents Producto As DataGridViewTextBoxColumn
    Friend WithEvents ID_Father As DataGridViewTextBoxColumn
    Friend WithEvents ID_Animal As DataGridViewTextBoxColumn
    Friend WithEvents unidadMedida As DataGridViewTextBoxColumn
    Friend WithEvents Procesado As DataGridViewCheckBoxColumn
End Class
