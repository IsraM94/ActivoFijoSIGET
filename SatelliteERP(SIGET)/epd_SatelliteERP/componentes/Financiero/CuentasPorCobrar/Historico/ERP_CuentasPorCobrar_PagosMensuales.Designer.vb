<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ERP_CuentasPorCobrar_PagosMensuales
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GbClientes = New System.Windows.Forms.GroupBox()
        Me.dgvPagos = New System.Windows.Forms.DataGridView()
        Me.ID_PartialPayments = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IS_Partial = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Id_AccountReceivableListDetails_FK = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.paymentDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ammount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmdNext = New System.Windows.Forms.Button()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdPrint = New System.Windows.Forms.Button()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.GbClientes.SuspendLayout()
        CType(Me.dgvPagos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GbClientes
        '
        Me.GbClientes.BackColor = System.Drawing.SystemColors.Control
        Me.GbClientes.Controls.Add(Me.dgvPagos)
        Me.GbClientes.Controls.Add(Me.cmdNext)
        Me.GbClientes.Controls.Add(Me.dtpFecha)
        Me.GbClientes.Controls.Add(Me.Label1)
        Me.GbClientes.Controls.Add(Me.cmdPrint)
        Me.GbClientes.Controls.Add(Me.cmdCancel)
        Me.GbClientes.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GbClientes.Location = New System.Drawing.Point(12, 12)
        Me.GbClientes.Name = "GbClientes"
        Me.GbClientes.Size = New System.Drawing.Size(669, 456)
        Me.GbClientes.TabIndex = 47
        Me.GbClientes.TabStop = False
        Me.GbClientes.Text = "Reimpresión de Cobros"
        '
        'dgvPagos
        '
        Me.dgvPagos.AllowUserToAddRows = False
        Me.dgvPagos.AllowUserToDeleteRows = False
        Me.dgvPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPagos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID_PartialPayments, Me.IS_Partial, Me.Id_AccountReceivableListDetails_FK, Me.paymentDate, Me.Ammount})
        Me.dgvPagos.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.dgvPagos.Location = New System.Drawing.Point(0, 103)
        Me.dgvPagos.MultiSelect = False
        Me.dgvPagos.Name = "dgvPagos"
        Me.dgvPagos.ReadOnly = True
        Me.dgvPagos.RowHeadersVisible = False
        Me.dgvPagos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPagos.Size = New System.Drawing.Size(655, 304)
        Me.dgvPagos.TabIndex = 13
        '
        'ID_PartialPayments
        '
        Me.ID_PartialPayments.DataPropertyName = "ID_PartialPayments"
        Me.ID_PartialPayments.HeaderText = "Correlativo"
        Me.ID_PartialPayments.Name = "ID_PartialPayments"
        Me.ID_PartialPayments.ReadOnly = True
        Me.ID_PartialPayments.Width = 150
        '
        'IS_Partial
        '
        Me.IS_Partial.DataPropertyName = "IS_Partial"
        Me.IS_Partial.HeaderText = "IS_Partial"
        Me.IS_Partial.Name = "IS_Partial"
        Me.IS_Partial.ReadOnly = True
        Me.IS_Partial.Visible = False
        '
        'Id_AccountReceivableListDetails_FK
        '
        Me.Id_AccountReceivableListDetails_FK.DataPropertyName = "Id_AccountReceivableListDetails_FK"
        Me.Id_AccountReceivableListDetails_FK.HeaderText = "Id_AccountReceivableListDetails_FK"
        Me.Id_AccountReceivableListDetails_FK.Name = "Id_AccountReceivableListDetails_FK"
        Me.Id_AccountReceivableListDetails_FK.ReadOnly = True
        Me.Id_AccountReceivableListDetails_FK.Visible = False
        '
        'paymentDate
        '
        Me.paymentDate.DataPropertyName = "paymentDate"
        DataGridViewCellStyle1.Format = "d"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.paymentDate.DefaultCellStyle = DataGridViewCellStyle1
        Me.paymentDate.HeaderText = "Fecha de Pago"
        Me.paymentDate.Name = "paymentDate"
        Me.paymentDate.ReadOnly = True
        Me.paymentDate.Width = 250
        '
        'Ammount
        '
        Me.Ammount.DataPropertyName = "Ammount"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle2.Format = "C2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.Ammount.DefaultCellStyle = DataGridViewCellStyle2
        Me.Ammount.HeaderText = "Monto Cancelado"
        Me.Ammount.Name = "Ammount"
        Me.Ammount.ReadOnly = True
        Me.Ammount.Width = 250
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
        Me.cmdNext.Location = New System.Drawing.Point(345, 52)
        Me.cmdNext.Name = "cmdNext"
        Me.cmdNext.Size = New System.Drawing.Size(153, 37)
        Me.cmdNext.TabIndex = 12
        Me.cmdNext.Text = "Continuar"
        Me.cmdNext.UseVisualStyleBackColor = False
        '
        'dtpFecha
        '
        Me.dtpFecha.CustomFormat = "MMMM yyyy"
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFecha.Location = New System.Drawing.Point(81, 52)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(245, 33)
        Me.dtpFecha.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 25)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Mes:"
        '
        'cmdPrint
        '
        Me.cmdPrint.BackColor = System.Drawing.Color.Gainsboro
        Me.cmdPrint.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdPrint.FlatAppearance.BorderSize = 0
        Me.cmdPrint.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.cmdPrint.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.cmdPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdPrint.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrint.Location = New System.Drawing.Point(163, 413)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(153, 37)
        Me.cmdPrint.TabIndex = 7
        Me.cmdPrint.Text = "Imprimir"
        Me.cmdPrint.UseVisualStyleBackColor = False
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
        Me.cmdCancel.Location = New System.Drawing.Point(322, 413)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(153, 37)
        Me.cmdCancel.TabIndex = 8
        Me.cmdCancel.Text = "Salir"
        Me.cmdCancel.UseVisualStyleBackColor = False
        '
        'ERP_CuentasPorCobrar_PagosMensuales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CadetBlue
        Me.ClientSize = New System.Drawing.Size(692, 477)
        Me.Controls.Add(Me.GbClientes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ERP_CuentasPorCobrar_PagosMensuales"
        Me.Text = "ERP_CuentasPorCobrar_PagosMensuales"
        Me.GbClientes.ResumeLayout(False)
        Me.GbClientes.PerformLayout()
        CType(Me.dgvPagos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GbClientes As GroupBox
	Friend WithEvents dgvPagos As DataGridView
	Private WithEvents cmdNext As Button
	Friend WithEvents dtpFecha As DateTimePicker
	Friend WithEvents Label1 As Label
	Private WithEvents cmdPrint As Button
	Private WithEvents cmdCancel As Button
	Friend WithEvents ID_PartialPayments As DataGridViewTextBoxColumn
	Friend WithEvents IS_Partial As DataGridViewTextBoxColumn
	Friend WithEvents Id_AccountReceivableListDetails_FK As DataGridViewTextBoxColumn
	Friend WithEvents paymentDate As DataGridViewTextBoxColumn
	Friend WithEvents Ammount As DataGridViewTextBoxColumn
End Class
