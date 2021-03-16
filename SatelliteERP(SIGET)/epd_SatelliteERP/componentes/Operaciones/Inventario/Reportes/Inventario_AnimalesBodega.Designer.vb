<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inventario_AnimalesBodega
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
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.dgvDetails = New System.Windows.Forms.DataGridView()
		Me.Id_Production = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Semanas = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Tipoflow = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.cmdCancel = New System.Windows.Forms.Button()
		Me.GroupBox1.SuspendLayout()
		CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.dgvDetails, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'GroupBox1
		'
		Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
		Me.GroupBox1.Controls.Add(Me.Chart1)
		Me.GroupBox1.Controls.Add(Me.Label2)
		Me.GroupBox1.Controls.Add(Me.dgvDetails)
		Me.GroupBox1.Controls.Add(Me.Label1)
		Me.GroupBox1.Controls.Add(Me.cmdCancel)
		Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(793, 640)
		Me.GroupBox1.TabIndex = 2
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = "Animales por Bodega"
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
		Series1.Legend = "Legend1"
		Series1.Name = "Series1"
		Me.Chart1.Series.Add(Series1)
		Me.Chart1.Size = New System.Drawing.Size(781, 300)
		Me.Chart1.TabIndex = 14
		Me.Chart1.Text = "Chart1"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(308, 350)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(154, 25)
		Me.Label2.TabIndex = 13
		Me.Label2.Text = "Detalle por Lote"
		'
		'dgvDetails
		'
		Me.dgvDetails.AllowUserToAddRows = False
		Me.dgvDetails.AllowUserToDeleteRows = False
		Me.dgvDetails.BackgroundColor = System.Drawing.Color.White
		Me.dgvDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dgvDetails.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id_Production, Me.Semanas, Me.Tipoflow, Me.Cantidad})
		Me.dgvDetails.Cursor = System.Windows.Forms.Cursors.Default
		Me.dgvDetails.EnableHeadersVisualStyles = False
		Me.dgvDetails.Location = New System.Drawing.Point(12, 376)
		Me.dgvDetails.Name = "dgvDetails"
		Me.dgvDetails.ReadOnly = True
		Me.dgvDetails.RowHeadersVisible = False
		Me.dgvDetails.Size = New System.Drawing.Size(773, 216)
		Me.dgvDetails.TabIndex = 12
		'
		'Id_Production
		'
		Me.Id_Production.DataPropertyName = "Id_Production"
		Me.Id_Production.HeaderText = "Código Lote"
		Me.Id_Production.Name = "Id_Production"
		Me.Id_Production.ReadOnly = True
		Me.Id_Production.Width = 150
		'
		'Semanas
		'
		Me.Semanas.DataPropertyName = "Semanas"
		Me.Semanas.HeaderText = "Semanas"
		Me.Semanas.Name = "Semanas"
		Me.Semanas.ReadOnly = True
		Me.Semanas.Width = 150
		'
		'Tipoflow
		'
		Me.Tipoflow.DataPropertyName = "Tipoflow"
		Me.Tipoflow.HeaderText = "Flow"
		Me.Tipoflow.Name = "Tipoflow"
		Me.Tipoflow.ReadOnly = True
		Me.Tipoflow.Width = 320
		'
		'Cantidad
		'
		Me.Cantidad.DataPropertyName = "Cantidad"
		Me.Cantidad.HeaderText = "Cantidad"
		Me.Cantidad.Name = "Cantidad"
		Me.Cantidad.ReadOnly = True
		Me.Cantidad.Width = 150
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
		Me.cmdCancel.Location = New System.Drawing.Point(681, 598)
		Me.cmdCancel.Name = "cmdCancel"
		Me.cmdCancel.Size = New System.Drawing.Size(98, 28)
		Me.cmdCancel.TabIndex = 9
		Me.cmdCancel.Text = "Cerrar"
		Me.cmdCancel.UseVisualStyleBackColor = False
		'
		'Inventario_AnimalesBodega
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.CadetBlue
		Me.ClientSize = New System.Drawing.Size(817, 660)
		Me.Controls.Add(Me.GroupBox1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Name = "Inventario_AnimalesBodega"
		Me.Text = "Inventario_AnimalesBodega"
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout()
		CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.dgvDetails, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents GroupBox1 As GroupBox
	Friend WithEvents Label2 As Label
	Friend WithEvents dgvDetails As DataGridView
	Friend WithEvents Id_Production As DataGridViewTextBoxColumn
	Friend WithEvents Semanas As DataGridViewTextBoxColumn
	Friend WithEvents Tipoflow As DataGridViewTextBoxColumn
	Friend WithEvents Cantidad As DataGridViewTextBoxColumn
	Friend WithEvents Label1 As Label
	Private WithEvents cmdCancel As Button
	Friend WithEvents Chart1 As DataVisualization.Charting.Chart
End Class
