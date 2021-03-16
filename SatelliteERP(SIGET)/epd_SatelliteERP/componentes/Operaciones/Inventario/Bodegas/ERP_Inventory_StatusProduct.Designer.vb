<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ERP_Inventory_StatusProduct
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
		Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
		Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
		Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
		Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.dgvDetails = New System.Windows.Forms.DataGridView()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.cmdCancel = New System.Windows.Forms.Button()
		Me.Id_Product = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Name_Product = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Stock = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Name_UnitMeasure = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.dgvClients = New System.Windows.Forms.DataGridView()
		Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.GroupBox1.SuspendLayout()
		CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.dgvDetails, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.dgvClients, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'GroupBox1
		'
		Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
		Me.GroupBox1.Controls.Add(Me.dgvClients)
		Me.GroupBox1.Controls.Add(Me.Chart1)
		Me.GroupBox1.Controls.Add(Me.Label2)
		Me.GroupBox1.Controls.Add(Me.dgvDetails)
		Me.GroupBox1.Controls.Add(Me.Label1)
		Me.GroupBox1.Controls.Add(Me.cmdCancel)
		Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(793, 706)
		Me.GroupBox1.TabIndex = 3
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = "Productos por Bodega"
		'
		'Chart1
		'
		ChartArea1.Name = "ChartArea1"
		Me.Chart1.ChartAreas.Add(ChartArea1)
		Legend1.Name = "Legend1"
		Me.Chart1.Legends.Add(Legend1)
		Me.Chart1.Location = New System.Drawing.Point(6, 49)
		Me.Chart1.Name = "Chart1"
		Series1.ChartArea = "ChartArea1"
		Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut
		Series1.Legend = "Legend1"
		Series1.Name = "Series1"
		Me.Chart1.Series.Add(Series1)
		Me.Chart1.Size = New System.Drawing.Size(781, 371)
		Me.Chart1.TabIndex = 14
		Me.Chart1.Text = "Chart1"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(308, 423)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(199, 25)
		Me.Label2.TabIndex = 13
		Me.Label2.Text = "Detalle por Producto"
		'
		'dgvDetails
		'
		Me.dgvDetails.AllowUserToAddRows = False
		Me.dgvDetails.AllowUserToDeleteRows = False
		Me.dgvDetails.AllowUserToResizeRows = False
		Me.dgvDetails.BackgroundColor = System.Drawing.Color.White
		DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
		DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
		DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
		DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
		DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.dgvDetails.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
		Me.dgvDetails.ColumnHeadersHeight = 30
		Me.dgvDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
		Me.dgvDetails.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id_Product, Me.Name_Product, Me.Stock, Me.Name_UnitMeasure})
		Me.dgvDetails.Cursor = System.Windows.Forms.Cursors.Default
		DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window
		DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText
		DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
		DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
		DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
		Me.dgvDetails.DefaultCellStyle = DataGridViewCellStyle7
		Me.dgvDetails.EnableHeadersVisualStyles = False
		Me.dgvDetails.Location = New System.Drawing.Point(6, 451)
		Me.dgvDetails.Name = "dgvDetails"
		Me.dgvDetails.ReadOnly = True
		DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
		DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
		DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
		DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
		DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.dgvDetails.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
		Me.dgvDetails.RowHeadersVisible = False
		Me.dgvDetails.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
		DataGridViewCellStyle9.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.dgvDetails.RowsDefaultCellStyle = DataGridViewCellStyle9
		Me.dgvDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.dgvDetails.Size = New System.Drawing.Size(773, 216)
		Me.dgvDetails.TabIndex = 12
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(319, 20)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(129, 25)
		Me.Label1.TabIndex = 11
		Me.Label1.Text = "Total General"
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
		Me.cmdCancel.Location = New System.Drawing.Point(681, 672)
		Me.cmdCancel.Name = "cmdCancel"
		Me.cmdCancel.Size = New System.Drawing.Size(98, 28)
		Me.cmdCancel.TabIndex = 9
		Me.cmdCancel.Text = "Cerrar"
		Me.cmdCancel.UseVisualStyleBackColor = False
		'
		'Id_Product
		'
		Me.Id_Product.DataPropertyName = "Id_Product"
		DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
		Me.Id_Product.DefaultCellStyle = DataGridViewCellStyle5
		Me.Id_Product.HeaderText = "Código producto"
		Me.Id_Product.Name = "Id_Product"
		Me.Id_Product.ReadOnly = True
		Me.Id_Product.Width = 150
		'
		'Name_Product
		'
		Me.Name_Product.DataPropertyName = "Name_Product"
		Me.Name_Product.HeaderText = "Descripción"
		Me.Name_Product.Name = "Name_Product"
		Me.Name_Product.ReadOnly = True
		Me.Name_Product.Width = 350
		'
		'Stock
		'
		Me.Stock.DataPropertyName = "Stock"
		DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
		DataGridViewCellStyle6.Format = "N2"
		DataGridViewCellStyle6.NullValue = Nothing
		Me.Stock.DefaultCellStyle = DataGridViewCellStyle6
		Me.Stock.HeaderText = "Inventario"
		Me.Stock.Name = "Stock"
		Me.Stock.ReadOnly = True
		Me.Stock.Width = 120
		'
		'Name_UnitMeasure
		'
		Me.Name_UnitMeasure.DataPropertyName = "Name_UnitMeasure"
		Me.Name_UnitMeasure.HeaderText = "U. medida"
		Me.Name_UnitMeasure.Name = "Name_UnitMeasure"
		Me.Name_UnitMeasure.ReadOnly = True
		Me.Name_UnitMeasure.Width = 150
		'
		'dgvClients
		'
		Me.dgvClients.AllowUserToAddRows = False
		Me.dgvClients.AllowUserToDeleteRows = False
		Me.dgvClients.AllowUserToResizeRows = False
		Me.dgvClients.BackgroundColor = System.Drawing.Color.White
		Me.dgvClients.ColumnHeadersHeight = 30
		Me.dgvClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
		Me.dgvClients.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
		Me.dgvClients.Cursor = System.Windows.Forms.Cursors.Default
		Me.dgvClients.EnableHeadersVisualStyles = False
		Me.dgvClients.Location = New System.Drawing.Point(6, 451)
		Me.dgvClients.Name = "dgvClients"
		Me.dgvClients.ReadOnly = True
		Me.dgvClients.RowHeadersVisible = False
		Me.dgvClients.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
		DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.dgvClients.RowsDefaultCellStyle = DataGridViewCellStyle3
		Me.dgvClients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.dgvClients.Size = New System.Drawing.Size(773, 216)
		Me.dgvClients.TabIndex = 15
		'
		'DataGridViewTextBoxColumn1
		'
		Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID_Customer_FK"
		DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
		Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle1
		Me.DataGridViewTextBoxColumn1.HeaderText = "Código"
		Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
		Me.DataGridViewTextBoxColumn1.ReadOnly = True
		Me.DataGridViewTextBoxColumn1.Width = 130
		'
		'DataGridViewTextBoxColumn2
		'
		Me.DataGridViewTextBoxColumn2.DataPropertyName = "Cliente"
		Me.DataGridViewTextBoxColumn2.HeaderText = "Nombre"
		Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
		Me.DataGridViewTextBoxColumn2.ReadOnly = True
		Me.DataGridViewTextBoxColumn2.Width = 450
		'
		'DataGridViewTextBoxColumn3
		'
		Me.DataGridViewTextBoxColumn3.DataPropertyName = "Monto"
		DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
		DataGridViewCellStyle2.Format = "C2"
		DataGridViewCellStyle2.NullValue = Nothing
		Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle2
		Me.DataGridViewTextBoxColumn3.HeaderText = "Monto"
		Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
		Me.DataGridViewTextBoxColumn3.ReadOnly = True
		Me.DataGridViewTextBoxColumn3.Width = 170
		'
		'ERP_Inventory_StatusProduct
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.CadetBlue
		Me.ClientSize = New System.Drawing.Size(813, 726)
		Me.Controls.Add(Me.GroupBox1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Name = "ERP_Inventory_StatusProduct"
		Me.Text = "ERP_Inventory_StatusProduct"
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout()
		CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.dgvDetails, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.dgvClients, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents GroupBox1 As GroupBox
	Friend WithEvents Chart1 As DataVisualization.Charting.Chart
	Friend WithEvents Label2 As Label
	Friend WithEvents dgvDetails As DataGridView
	Friend WithEvents Label1 As Label
	Private WithEvents cmdCancel As Button
	Friend WithEvents Id_Product As DataGridViewTextBoxColumn
	Friend WithEvents Name_Product As DataGridViewTextBoxColumn
	Friend WithEvents Stock As DataGridViewTextBoxColumn
	Friend WithEvents Name_UnitMeasure As DataGridViewTextBoxColumn
	Friend WithEvents dgvClients As DataGridView
	Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
	Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
	Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
End Class
