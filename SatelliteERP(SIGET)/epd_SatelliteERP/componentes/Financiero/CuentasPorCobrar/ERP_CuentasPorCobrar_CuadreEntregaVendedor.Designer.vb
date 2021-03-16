<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ERP_CuentasPorCobrar_CuadreEntregaVendedor
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GbClientes = New System.Windows.Forms.GroupBox()
        Me.dgvProducts = New System.Windows.Forms.DataGridView()
        Me.Name_Company = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Description = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID_TransactionDetail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadEntregada = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmdNext = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cbVendedor = New System.Windows.Forms.ComboBox()
        Me.cmdGrabar = New System.Windows.Forms.Button()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.GbClientes.SuspendLayout()
        CType(Me.dgvProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GbClientes
        '
        Me.GbClientes.BackColor = System.Drawing.SystemColors.Control
        Me.GbClientes.Controls.Add(Me.dgvProducts)
        Me.GbClientes.Controls.Add(Me.GroupBox1)
        Me.GbClientes.Controls.Add(Me.cmdGrabar)
        Me.GbClientes.Controls.Add(Me.cmdCancel)
        Me.GbClientes.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GbClientes.Location = New System.Drawing.Point(12, 12)
        Me.GbClientes.Name = "GbClientes"
        Me.GbClientes.Size = New System.Drawing.Size(918, 574)
        Me.GbClientes.TabIndex = 45
        Me.GbClientes.TabStop = False
        Me.GbClientes.Text = "Entrega a Vendedor"
        '
        'dgvProducts
        '
        Me.dgvProducts.AllowUserToAddRows = False
        Me.dgvProducts.AllowUserToDeleteRows = False
        Me.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProducts.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Name_Company, Me.Description, Me.Total, Me.ID_TransactionDetail, Me.CantidadEntregada})
        Me.dgvProducts.Cursor = System.Windows.Forms.Cursors.Default
        Me.dgvProducts.Location = New System.Drawing.Point(9, 138)
        Me.dgvProducts.MultiSelect = False
        Me.dgvProducts.Name = "dgvProducts"
        Me.dgvProducts.RowHeadersVisible = False
        Me.dgvProducts.RowHeadersWidth = 65
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvProducts.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProducts.Size = New System.Drawing.Size(906, 387)
        Me.dgvProducts.TabIndex = 63
        '
        'Name_Company
        '
        Me.Name_Company.DataPropertyName = "Name_Company"
        Me.Name_Company.HeaderText = "Cliente"
        Me.Name_Company.Name = "Name_Company"
        Me.Name_Company.ReadOnly = True
        Me.Name_Company.Width = 250
        '
        'Description
        '
        Me.Description.DataPropertyName = "Description"
        Me.Description.HeaderText = "Producto"
        Me.Description.Name = "Description"
        Me.Description.ReadOnly = True
        Me.Description.Width = 350
        '
        'Total
        '
        Me.Total.DataPropertyName = "Total"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle1.Format = "N2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.Total.DefaultCellStyle = DataGridViewCellStyle1
        Me.Total.HeaderText = "Cantidad Pedida"
        Me.Total.Name = "Total"
        Me.Total.ReadOnly = True
        Me.Total.Width = 150
        '
        'ID_TransactionDetail
        '
        Me.ID_TransactionDetail.DataPropertyName = "ID_TransactionDetail"
        Me.ID_TransactionDetail.HeaderText = "ID_TransactionDetail"
        Me.ID_TransactionDetail.Name = "ID_TransactionDetail"
        Me.ID_TransactionDetail.ReadOnly = True
        Me.ID_TransactionDetail.Visible = False
        '
        'CantidadEntregada
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.CantidadEntregada.DefaultCellStyle = DataGridViewCellStyle2
        Me.CantidadEntregada.HeaderText = "Cantidad Entregada"
        Me.CantidadEntregada.MaxInputLength = 10
        Me.CantidadEntregada.Name = "CantidadEntregada"
        Me.CantidadEntregada.Width = 150
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmdNext)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.cbVendedor)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(213, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(596, 105)
        Me.GroupBox1.TabIndex = 62
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtros"
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
        Me.cmdNext.Location = New System.Drawing.Point(477, 67)
        Me.cmdNext.Name = "cmdNext"
        Me.cmdNext.Size = New System.Drawing.Size(101, 30)
        Me.cmdNext.TabIndex = 66
        Me.cmdNext.Text = "Continuar"
        Me.cmdNext.UseVisualStyleBackColor = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(108, 28)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(353, 33)
        Me.DateTimePicker1.TabIndex = 65
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.Label5.Location = New System.Drawing.Point(4, 67)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 25)
        Me.Label5.TabIndex = 52
        Me.Label5.Text = "Vendedor:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.Label10.Location = New System.Drawing.Point(23, 32)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(65, 25)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Fecha:"
        '
        'cbVendedor
        '
        Me.cbVendedor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbVendedor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbVendedor.BackColor = System.Drawing.Color.Gainsboro
        Me.cbVendedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbVendedor.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbVendedor.FormattingEnabled = True
        Me.cbVendedor.Location = New System.Drawing.Point(108, 70)
        Me.cbVendedor.Name = "cbVendedor"
        Me.cbVendedor.Size = New System.Drawing.Size(353, 29)
        Me.cbVendedor.TabIndex = 64
        '
        'cmdGrabar
        '
        Me.cmdGrabar.BackColor = System.Drawing.Color.Gainsboro
        Me.cmdGrabar.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdGrabar.FlatAppearance.BorderSize = 0
        Me.cmdGrabar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.cmdGrabar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.cmdGrabar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdGrabar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGrabar.Location = New System.Drawing.Point(562, 531)
        Me.cmdGrabar.Name = "cmdGrabar"
        Me.cmdGrabar.Size = New System.Drawing.Size(153, 37)
        Me.cmdGrabar.TabIndex = 7
        Me.cmdGrabar.Text = "Grabar"
        Me.cmdGrabar.UseVisualStyleBackColor = False
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
        Me.cmdCancel.Location = New System.Drawing.Point(721, 531)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(153, 37)
        Me.cmdCancel.TabIndex = 8
        Me.cmdCancel.Text = "Salir"
        Me.cmdCancel.UseVisualStyleBackColor = False
        '
        'ERP_CuentasPorCobrar_CuadreEntregaVendedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(942, 598)
        Me.Controls.Add(Me.GbClientes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ERP_CuentasPorCobrar_CuadreEntregaVendedor"
        Me.Text = "ERP_CuentasPorCobrar_CuadreEntregaVendedor"
        Me.GbClientes.ResumeLayout(False)
        CType(Me.dgvProducts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GbClientes As GroupBox
	Friend WithEvents dgvProducts As DataGridView
	Friend WithEvents GroupBox1 As GroupBox
	Private WithEvents cmdNext As Button
	Friend WithEvents DateTimePicker1 As DateTimePicker
	Private WithEvents Label5 As Label
	Private WithEvents Label10 As Label
	Private WithEvents cbVendedor As ComboBox
	Private WithEvents cmdGrabar As Button
	Private WithEvents cmdCancel As Button
    Friend WithEvents Name_Company As DataGridViewTextBoxColumn
    Friend WithEvents Description As DataGridViewTextBoxColumn
    Friend WithEvents Total As DataGridViewTextBoxColumn
    Friend WithEvents ID_TransactionDetail As DataGridViewTextBoxColumn
    Friend WithEvents CantidadEntregada As DataGridViewTextBoxColumn
End Class
