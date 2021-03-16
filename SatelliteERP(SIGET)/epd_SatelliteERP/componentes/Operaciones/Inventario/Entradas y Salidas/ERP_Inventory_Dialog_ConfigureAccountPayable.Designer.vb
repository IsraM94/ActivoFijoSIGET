<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ERP_Inventory_Dialog_ConfigureAccountPayable
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.cmdGenerar = New System.Windows.Forms.Button()
        Me.rbDiario = New System.Windows.Forms.RadioButton()
        Me.rbSemanal = New System.Windows.Forms.RadioButton()
        Me.rbQuincenal = New System.Windows.Forms.RadioButton()
        Me.rbMensual = New System.Windows.Forms.RadioButton()
        Me.txtCuotas = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dgvCobros = New System.Windows.Forms.DataGridView()
        Me.dtpDateInit = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtDescripcionCredito = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtSaldoDeudor = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtDocumento = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblDepartment = New System.Windows.Forms.Label()
        Me.cbTypeDocument = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dgvCobros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.cmdCancel)
        Me.GroupBox1.Controls.Add(Me.cmdSave)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(9, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(973, 451)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cuentas por Pagar"
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
        Me.cmdCancel.Location = New System.Drawing.Point(852, 407)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(98, 29)
        Me.cmdCancel.TabIndex = 25
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
        Me.cmdSave.Location = New System.Drawing.Point(748, 407)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(98, 29)
        Me.cmdSave.TabIndex = 24
        Me.cmdSave.Text = "Grabar"
        Me.cmdSave.UseVisualStyleBackColor = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.cmdGenerar)
        Me.GroupBox4.Controls.Add(Me.rbDiario)
        Me.GroupBox4.Controls.Add(Me.rbSemanal)
        Me.GroupBox4.Controls.Add(Me.rbQuincenal)
        Me.GroupBox4.Controls.Add(Me.rbMensual)
        Me.GroupBox4.Controls.Add(Me.txtCuotas)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.dgvCobros)
        Me.GroupBox4.Controls.Add(Me.dtpDateInit)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(6, 154)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(935, 228)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Forma de Pago"
        '
        'cmdGenerar
        '
        Me.cmdGenerar.BackColor = System.Drawing.Color.Gainsboro
        Me.cmdGenerar.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdGenerar.FlatAppearance.BorderSize = 0
        Me.cmdGenerar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.cmdGenerar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.cmdGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdGenerar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGenerar.Location = New System.Drawing.Point(713, 187)
        Me.cmdGenerar.Name = "cmdGenerar"
        Me.cmdGenerar.Size = New System.Drawing.Size(148, 27)
        Me.cmdGenerar.TabIndex = 23
        Me.cmdGenerar.Text = "Generar Pagos"
        Me.cmdGenerar.UseVisualStyleBackColor = False
        '
        'rbDiario
        '
        Me.rbDiario.AutoSize = True
        Me.rbDiario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbDiario.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.rbDiario.Location = New System.Drawing.Point(793, 145)
        Me.rbDiario.Name = "rbDiario"
        Me.rbDiario.Size = New System.Drawing.Size(80, 29)
        Me.rbDiario.TabIndex = 22
        Me.rbDiario.TabStop = True
        Me.rbDiario.Text = "Diario"
        Me.rbDiario.UseVisualStyleBackColor = True
        '
        'rbSemanal
        '
        Me.rbSemanal.AutoSize = True
        Me.rbSemanal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbSemanal.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.rbSemanal.Location = New System.Drawing.Point(674, 145)
        Me.rbSemanal.Name = "rbSemanal"
        Me.rbSemanal.Size = New System.Drawing.Size(101, 29)
        Me.rbSemanal.TabIndex = 21
        Me.rbSemanal.TabStop = True
        Me.rbSemanal.Text = "Semanal"
        Me.rbSemanal.UseVisualStyleBackColor = True
        '
        'rbQuincenal
        '
        Me.rbQuincenal.AutoSize = True
        Me.rbQuincenal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbQuincenal.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.rbQuincenal.Location = New System.Drawing.Point(793, 110)
        Me.rbQuincenal.Name = "rbQuincenal"
        Me.rbQuincenal.Size = New System.Drawing.Size(115, 29)
        Me.rbQuincenal.TabIndex = 20
        Me.rbQuincenal.TabStop = True
        Me.rbQuincenal.Text = "Quincenal"
        Me.rbQuincenal.UseVisualStyleBackColor = True
        '
        'rbMensual
        '
        Me.rbMensual.AutoSize = True
        Me.rbMensual.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbMensual.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.rbMensual.Location = New System.Drawing.Point(674, 110)
        Me.rbMensual.Name = "rbMensual"
        Me.rbMensual.Size = New System.Drawing.Size(101, 29)
        Me.rbMensual.TabIndex = 19
        Me.rbMensual.TabStop = True
        Me.rbMensual.Text = "Mensual"
        Me.rbMensual.UseVisualStyleBackColor = True
        '
        'txtCuotas
        '
        Me.txtCuotas.BackColor = System.Drawing.Color.Gainsboro
        Me.txtCuotas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCuotas.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCuotas.Location = New System.Drawing.Point(781, 79)
        Me.txtCuotas.MaxLength = 2
        Me.txtCuotas.Name = "txtCuotas"
        Me.txtCuotas.ShortcutsEnabled = False
        Me.txtCuotas.Size = New System.Drawing.Size(109, 26)
        Me.txtCuotas.TabIndex = 18
        Me.txtCuotas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.Label10.Location = New System.Drawing.Point(675, 79)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(100, 25)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "N° Cuotas:"
        '
        'dgvCobros
        '
        Me.dgvCobros.AllowUserToAddRows = False
        Me.dgvCobros.AllowUserToDeleteRows = False
        Me.dgvCobros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvCobros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCobros.Location = New System.Drawing.Point(10, 35)
        Me.dgvCobros.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvCobros.MultiSelect = False
        Me.dgvCobros.Name = "dgvCobros"
        Me.dgvCobros.ReadOnly = True
        Me.dgvCobros.RowTemplate.Height = 24
        Me.dgvCobros.Size = New System.Drawing.Size(617, 188)
        Me.dgvCobros.TabIndex = 0
        '
        'dtpDateInit
        '
        Me.dtpDateInit.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDateInit.Location = New System.Drawing.Point(793, 33)
        Me.dtpDateInit.Margin = New System.Windows.Forms.Padding(2)
        Me.dtpDateInit.Name = "dtpDateInit"
        Me.dtpDateInit.Size = New System.Drawing.Size(127, 33)
        Me.dtpDateInit.TabIndex = 17
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.Label3.Location = New System.Drawing.Point(640, 37)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(152, 25)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Fecha de Inicio : "
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtDescripcionCredito)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.txtSaldoDeudor)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.txtDocumento)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.lblDepartment)
        Me.GroupBox3.Controls.Add(Me.cbTypeDocument)
        Me.GroupBox3.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(6, 32)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(935, 116)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Información de Cobro"
        '
        'txtDescripcionCredito
        '
        Me.txtDescripcionCredito.BackColor = System.Drawing.Color.Gainsboro
        Me.txtDescripcionCredito.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDescripcionCredito.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcionCredito.Location = New System.Drawing.Point(653, 32)
        Me.txtDescripcionCredito.MaxLength = 50
        Me.txtDescripcionCredito.Name = "txtDescripcionCredito"
        Me.txtDescripcionCredito.ShortcutsEnabled = False
        Me.txtDescripcionCredito.Size = New System.Drawing.Size(255, 26)
        Me.txtDescripcionCredito.TabIndex = 11
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.Label13.Location = New System.Drawing.Point(487, 34)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(164, 25)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Concepto Crédito:"
        '
        'txtSaldoDeudor
        '
        Me.txtSaldoDeudor.BackColor = System.Drawing.Color.Gainsboro
        Me.txtSaldoDeudor.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSaldoDeudor.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaldoDeudor.Location = New System.Drawing.Point(653, 68)
        Me.txtSaldoDeudor.MaxLength = 15
        Me.txtSaldoDeudor.Name = "txtSaldoDeudor"
        Me.txtSaldoDeudor.ShortcutsEnabled = False
        Me.txtSaldoDeudor.Size = New System.Drawing.Size(255, 26)
        Me.txtSaldoDeudor.TabIndex = 13
        Me.txtSaldoDeudor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.Label9.Location = New System.Drawing.Point(516, 69)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(131, 25)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Saldo Deudor:"
        '
        'txtDocumento
        '
        Me.txtDocumento.BackColor = System.Drawing.Color.Gainsboro
        Me.txtDocumento.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDocumento.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDocumento.Location = New System.Drawing.Point(187, 67)
        Me.txtDocumento.MaxLength = 20
        Me.txtDocumento.Name = "txtDocumento"
        Me.txtDocumento.ShortcutsEnabled = False
        Me.txtDocumento.Size = New System.Drawing.Size(267, 26)
        Me.txtDocumento.TabIndex = 12
        Me.txtDocumento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.Label7.Location = New System.Drawing.Point(41, 68)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(145, 25)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "N° Documento: "
        '
        'lblDepartment
        '
        Me.lblDepartment.AutoSize = True
        Me.lblDepartment.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.lblDepartment.Location = New System.Drawing.Point(5, 33)
        Me.lblDepartment.Name = "lblDepartment"
        Me.lblDepartment.Size = New System.Drawing.Size(182, 25)
        Me.lblDepartment.TabIndex = 0
        Me.lblDepartment.Text = "Tipo de Documento:"
        '
        'cbTypeDocument
        '
        Me.cbTypeDocument.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbTypeDocument.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbTypeDocument.BackColor = System.Drawing.Color.Gainsboro
        Me.cbTypeDocument.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTypeDocument.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbTypeDocument.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTypeDocument.FormattingEnabled = True
        Me.cbTypeDocument.Location = New System.Drawing.Point(187, 32)
        Me.cbTypeDocument.Name = "cbTypeDocument"
        Me.cbTypeDocument.Size = New System.Drawing.Size(286, 29)
        Me.cbTypeDocument.TabIndex = 10
        '
        'ERP_Inventory_Dialog_ConfigureAccountPayable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CadetBlue
        Me.ClientSize = New System.Drawing.Size(990, 472)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ERP_Inventory_Dialog_ConfigureAccountPayable"
        Me.Text = "ERP_Inventory_Dialog_ConfigureAccountPayable"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.dgvCobros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
	Private WithEvents cmdSave As Button
	Friend WithEvents GroupBox4 As GroupBox
	Private WithEvents cmdGenerar As Button
	Friend WithEvents rbDiario As RadioButton
	Friend WithEvents rbSemanal As RadioButton
	Friend WithEvents rbQuincenal As RadioButton
	Friend WithEvents rbMensual As RadioButton
	Private WithEvents txtCuotas As TextBox
	Private WithEvents Label10 As Label
	Friend WithEvents dgvCobros As DataGridView
	Friend WithEvents dtpDateInit As DateTimePicker
	Private WithEvents Label3 As Label
	Friend WithEvents GroupBox3 As GroupBox
	Private WithEvents txtDescripcionCredito As TextBox
	Private WithEvents Label13 As Label
	Private WithEvents txtSaldoDeudor As TextBox
	Private WithEvents Label9 As Label
	Private WithEvents txtDocumento As TextBox
	Private WithEvents Label7 As Label
	Private WithEvents lblDepartment As Label
	Private WithEvents cbTypeDocument As ComboBox
	Private WithEvents cmdCancel As Button
End Class
