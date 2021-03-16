<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ERP_Inventory_Dialog_InventoryDepartures
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmdRechazar = New System.Windows.Forms.Button()
        Me.cmdAprobar = New System.Windows.Forms.Button()
        Me.btnEmviarApro = New System.Windows.Forms.Button()
        Me.lblDestino = New System.Windows.Forms.Label()
        Me.cb_Catalog = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.pnRechazo = New System.Windows.Forms.Panel()
        Me.pnPru = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cmdGuardar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtRechazo = New System.Windows.Forms.TextBox()
        Me.dgvProductsOutput = New System.Windows.Forms.DataGridView()
        Me.Id_Product = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Correlativo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.product = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Stock = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Menu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AgregarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.lblValor = New System.Windows.Forms.Label()
        Me.txtComentarios = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.pnRechazo.SuspendLayout()
        Me.pnPru.SuspendLayout()
        CType(Me.dgvProductsOutput, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Menu.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.cmdRechazar)
        Me.GroupBox1.Controls.Add(Me.cmdAprobar)
        Me.GroupBox1.Controls.Add(Me.btnEmviarApro)
        Me.GroupBox1.Controls.Add(Me.lblDestino)
        Me.GroupBox1.Controls.Add(Me.cb_Catalog)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.cmdCancel)
        Me.GroupBox1.Controls.Add(Me.cmdSave)
        Me.GroupBox1.Controls.Add(Me.lblValor)
        Me.GroupBox1.Controls.Add(Me.txtComentarios)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(810, 524)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Salida de Producto"
        '
        'cmdRechazar
        '
        Me.cmdRechazar.BackColor = System.Drawing.Color.Gainsboro
        Me.cmdRechazar.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdRechazar.FlatAppearance.BorderSize = 0
        Me.cmdRechazar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.cmdRechazar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.cmdRechazar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdRechazar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdRechazar.Location = New System.Drawing.Point(180, 490)
        Me.cmdRechazar.Name = "cmdRechazar"
        Me.cmdRechazar.Size = New System.Drawing.Size(98, 28)
        Me.cmdRechazar.TabIndex = 14
        Me.cmdRechazar.Text = "Rechazar"
        Me.cmdRechazar.UseVisualStyleBackColor = False
        Me.cmdRechazar.Visible = False
        '
        'cmdAprobar
        '
        Me.cmdAprobar.BackColor = System.Drawing.Color.Gainsboro
        Me.cmdAprobar.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdAprobar.FlatAppearance.BorderSize = 0
        Me.cmdAprobar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.cmdAprobar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.cmdAprobar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAprobar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAprobar.Location = New System.Drawing.Point(68, 490)
        Me.cmdAprobar.Name = "cmdAprobar"
        Me.cmdAprobar.Size = New System.Drawing.Size(98, 28)
        Me.cmdAprobar.TabIndex = 13
        Me.cmdAprobar.Text = "Aprobar"
        Me.cmdAprobar.UseVisualStyleBackColor = False
        Me.cmdAprobar.Visible = False
        '
        'btnEmviarApro
        '
        Me.btnEmviarApro.BackColor = System.Drawing.Color.Gainsboro
        Me.btnEmviarApro.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.btnEmviarApro.FlatAppearance.BorderSize = 0
        Me.btnEmviarApro.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.btnEmviarApro.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.btnEmviarApro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEmviarApro.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEmviarApro.Location = New System.Drawing.Point(540, 490)
        Me.btnEmviarApro.Name = "btnEmviarApro"
        Me.btnEmviarApro.Size = New System.Drawing.Size(163, 28)
        Me.btnEmviarApro.TabIndex = 45
        Me.btnEmviarApro.Text = "Enviar a Aprobación"
        Me.btnEmviarApro.UseVisualStyleBackColor = False
        Me.btnEmviarApro.Visible = False
        '
        'lblDestino
        '
        Me.lblDestino.AutoSize = True
        Me.lblDestino.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDestino.Location = New System.Drawing.Point(280, 136)
        Me.lblDestino.Name = "lblDestino"
        Me.lblDestino.Size = New System.Drawing.Size(45, 21)
        Me.lblDestino.TabIndex = 44
        Me.lblDestino.Text = "none"
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
        Me.cb_Catalog.Location = New System.Drawing.Point(135, 38)
        Me.cb_Catalog.Name = "cb_Catalog"
        Me.cb_Catalog.Size = New System.Drawing.Size(624, 29)
        Me.cb_Catalog.TabIndex = 43
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(19, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 21)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Tipo de Salida:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.pnRechazo)
        Me.GroupBox2.Controls.Add(Me.dgvProductsOutput)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 153)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(798, 334)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Productos"
        '
        'pnRechazo
        '
        Me.pnRechazo.BackColor = System.Drawing.Color.CadetBlue
        Me.pnRechazo.Controls.Add(Me.pnPru)
        Me.pnRechazo.Location = New System.Drawing.Point(174, 32)
        Me.pnRechazo.Name = "pnRechazo"
        Me.pnRechazo.Size = New System.Drawing.Size(439, 181)
        Me.pnRechazo.TabIndex = 46
        Me.pnRechazo.Visible = False
        '
        'pnPru
        '
        Me.pnPru.BackColor = System.Drawing.SystemColors.Control
        Me.pnPru.Controls.Add(Me.Button1)
        Me.pnPru.Controls.Add(Me.cmdGuardar)
        Me.pnPru.Controls.Add(Me.Label1)
        Me.pnPru.Controls.Add(Me.txtRechazo)
        Me.pnPru.Location = New System.Drawing.Point(10, 8)
        Me.pnPru.Name = "pnPru"
        Me.pnPru.Size = New System.Drawing.Size(417, 161)
        Me.pnPru.TabIndex = 13
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
        Me.Button1.Location = New System.Drawing.Point(229, 124)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(98, 28)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Cancelar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'cmdGuardar
        '
        Me.cmdGuardar.BackColor = System.Drawing.Color.Gainsboro
        Me.cmdGuardar.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdGuardar.FlatAppearance.BorderSize = 0
        Me.cmdGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.cmdGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.cmdGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdGuardar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGuardar.Location = New System.Drawing.Point(114, 124)
        Me.cmdGuardar.Name = "cmdGuardar"
        Me.cmdGuardar.Size = New System.Drawing.Size(98, 28)
        Me.cmdGuardar.TabIndex = 9
        Me.cmdGuardar.Text = "Rechazar"
        Me.cmdGuardar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(186, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Motivo del Rechazo"
        '
        'txtRechazo
        '
        Me.txtRechazo.Location = New System.Drawing.Point(8, 29)
        Me.txtRechazo.Multiline = True
        Me.txtRechazo.Name = "txtRechazo"
        Me.txtRechazo.Size = New System.Drawing.Size(402, 83)
        Me.txtRechazo.TabIndex = 0
        '
        'dgvProductsOutput
        '
        Me.dgvProductsOutput.AllowUserToAddRows = False
        Me.dgvProductsOutput.AllowUserToDeleteRows = False
        Me.dgvProductsOutput.AllowUserToResizeColumns = False
        Me.dgvProductsOutput.AllowUserToResizeRows = False
        Me.dgvProductsOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProductsOutput.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id_Product, Me.Correlativo, Me.product, Me.Cantidad, Me.Stock})
        Me.dgvProductsOutput.ContextMenuStrip = Me.Menu
        Me.dgvProductsOutput.Location = New System.Drawing.Point(5, 25)
        Me.dgvProductsOutput.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvProductsOutput.MultiSelect = False
        Me.dgvProductsOutput.Name = "dgvProductsOutput"
        Me.dgvProductsOutput.ReadOnly = True
        Me.dgvProductsOutput.RowHeadersVisible = False
        Me.dgvProductsOutput.RowTemplate.Height = 24
        Me.dgvProductsOutput.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProductsOutput.Size = New System.Drawing.Size(778, 292)
        Me.dgvProductsOutput.TabIndex = 1
        '
        'Id_Product
        '
        Me.Id_Product.DataPropertyName = "ID_Product"
        Me.Id_Product.HeaderText = "Correlativo"
        Me.Id_Product.Name = "Id_Product"
        Me.Id_Product.ReadOnly = True
        Me.Id_Product.Visible = False
        Me.Id_Product.Width = 160
        '
        'Correlativo
        '
        Me.Correlativo.DataPropertyName = "number_Purchase"
        Me.Correlativo.HeaderText = "Correlativo"
        Me.Correlativo.Name = "Correlativo"
        Me.Correlativo.ReadOnly = True
        Me.Correlativo.Width = 160
        '
        'product
        '
        Me.product.DataPropertyName = "Name_Product"
        Me.product.HeaderText = "Descripción"
        Me.product.Name = "product"
        Me.product.ReadOnly = True
        Me.product.Width = 500
        '
        'Cantidad
        '
        Me.Cantidad.DataPropertyName = "Cantidad"
        DataGridViewCellStyle1.Format = "N2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.Cantidad.DefaultCellStyle = DataGridViewCellStyle1
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.ReadOnly = True
        Me.Cantidad.Width = 110
        '
        'Stock
        '
        Me.Stock.DataPropertyName = "stock"
        Me.Stock.HeaderText = "Stock"
        Me.Stock.Name = "Stock"
        Me.Stock.ReadOnly = True
        Me.Stock.Visible = False
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
        Me.cmdCancel.Location = New System.Drawing.Point(427, 490)
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
        Me.cmdSave.Location = New System.Drawing.Point(284, 490)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(128, 28)
        Me.cmdSave.TabIndex = 8
        Me.cmdSave.Text = "Guardar y Salir"
        Me.cmdSave.UseVisualStyleBackColor = False
        '
        'lblValor
        '
        Me.lblValor.AutoSize = True
        Me.lblValor.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValor.Location = New System.Drawing.Point(26, 79)
        Me.lblValor.Name = "lblValor"
        Me.lblValor.Size = New System.Drawing.Size(102, 21)
        Me.lblValor.TabIndex = 0
        Me.lblValor.Text = "Comentarios:"
        '
        'txtComentarios
        '
        Me.txtComentarios.BackColor = System.Drawing.Color.Gainsboro
        Me.txtComentarios.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtComentarios.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtComentarios.Location = New System.Drawing.Point(135, 79)
        Me.txtComentarios.MaxLength = 250
        Me.txtComentarios.Multiline = True
        Me.txtComentarios.Name = "txtComentarios"
        Me.txtComentarios.ShortcutsEnabled = False
        Me.txtComentarios.Size = New System.Drawing.Size(624, 50)
        Me.txtComentarios.TabIndex = 2
        '
        'ERP_Inventory_Dialog_InventoryDepartures
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CadetBlue
        Me.ClientSize = New System.Drawing.Size(829, 544)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ERP_Inventory_Dialog_InventoryDepartures"
        Me.Text = "ERP_Inventory_Dialog_InventoryDepartures"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.pnRechazo.ResumeLayout(False)
        Me.pnPru.ResumeLayout(False)
        Me.pnPru.PerformLayout()
        CType(Me.dgvProductsOutput, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Menu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Private WithEvents cb_Catalog As ComboBox
    Private WithEvents Label2 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dgvProductsOutput As DataGridView
    Private WithEvents cmdCancel As Button
    Private WithEvents cmdSave As Button
    Private WithEvents lblValor As Label
    Private WithEvents txtComentarios As TextBox
    Friend WithEvents Menu As ContextMenuStrip
    Friend WithEvents AgregarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As ToolStripMenuItem
    Private WithEvents lblDestino As Label
    Private WithEvents btnEmviarApro As Button
    Private WithEvents cmdRechazar As Button
    Private WithEvents cmdAprobar As Button
    Friend WithEvents pnRechazo As Panel
    Friend WithEvents pnPru As Panel
    Private WithEvents Button1 As Button
    Private WithEvents cmdGuardar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtRechazo As TextBox
    Friend WithEvents ModificarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Id_Product As DataGridViewTextBoxColumn
    Friend WithEvents Correlativo As DataGridViewTextBoxColumn
    Friend WithEvents product As DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents Stock As DataGridViewTextBoxColumn
End Class
