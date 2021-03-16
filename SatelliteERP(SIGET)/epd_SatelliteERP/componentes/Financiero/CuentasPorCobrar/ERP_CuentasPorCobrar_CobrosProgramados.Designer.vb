<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ERP_CuentasPorCobrar_CobrosProgramados
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
        Me.GbClientes = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dgvClientes = New System.Windows.Forms.DataGridView()
        Me.Activo = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Name_Company = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContactEmployee = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Company_Category = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmdDiasCobro = New System.Windows.Forms.GroupBox()
        Me.rbEspecificos = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rbTodos = New System.Windows.Forms.RadioButton()
        Me.chkDomingo = New System.Windows.Forms.CheckBox()
        Me.chkSabado = New System.Windows.Forms.CheckBox()
        Me.chkViernes = New System.Windows.Forms.CheckBox()
        Me.chkJueves = New System.Windows.Forms.CheckBox()
        Me.chkMiercoles = New System.Windows.Forms.CheckBox()
        Me.chkMartes = New System.Windows.Forms.CheckBox()
        Me.chkLunes = New System.Windows.Forms.CheckBox()
        Me.dtpFechaCobro = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmdGrabar = New System.Windows.Forms.Button()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.GbClientes.SuspendLayout()
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmdDiasCobro.SuspendLayout()
        Me.SuspendLayout()
        '
        'GbClientes
        '
        Me.GbClientes.BackColor = System.Drawing.SystemColors.Control
        Me.GbClientes.Controls.Add(Me.Button1)
        Me.GbClientes.Controls.Add(Me.dgvClientes)
        Me.GbClientes.Controls.Add(Me.cmdDiasCobro)
        Me.GbClientes.Controls.Add(Me.cmdGrabar)
        Me.GbClientes.Controls.Add(Me.cmdCancel)
        Me.GbClientes.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GbClientes.Location = New System.Drawing.Point(9, 9)
        Me.GbClientes.Name = "GbClientes"
        Me.GbClientes.Size = New System.Drawing.Size(850, 486)
        Me.GbClientes.TabIndex = 45
        Me.GbClientes.TabStop = False
        Me.GbClientes.Text = "Incluir en Cobro"
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
        Me.Button1.Location = New System.Drawing.Point(185, 443)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(153, 37)
        Me.Button1.TabIndex = 65
        Me.Button1.Text = "Generar Varios"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'dgvClientes
        '
        Me.dgvClientes.AllowUserToAddRows = False
        Me.dgvClientes.AllowUserToDeleteRows = False
        Me.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvClientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Activo, Me.Name_Company, Me.ContactEmployee, Me.Company_Category})
        Me.dgvClientes.Location = New System.Drawing.Point(16, 171)
        Me.dgvClientes.Name = "dgvClientes"
        Me.dgvClientes.RowHeadersVisible = False
        Me.dgvClientes.Size = New System.Drawing.Size(825, 266)
        Me.dgvClientes.TabIndex = 63
        '
        'Activo
        '
        Me.Activo.HeaderText = "Seleccionar"
        Me.Activo.Name = "Activo"
        Me.Activo.Width = 120
        '
        'Name_Company
        '
        Me.Name_Company.DataPropertyName = "Name_Company"
        Me.Name_Company.HeaderText = "Nombre Cliente"
        Me.Name_Company.Name = "Name_Company"
        Me.Name_Company.ReadOnly = True
        Me.Name_Company.Width = 550
        '
        'ContactEmployee
        '
        Me.ContactEmployee.DataPropertyName = "ContactEmployee"
        Me.ContactEmployee.HeaderText = "Empleado de Contacto"
        Me.ContactEmployee.Name = "ContactEmployee"
        Me.ContactEmployee.ReadOnly = True
        Me.ContactEmployee.Visible = False
        '
        'Company_Category
        '
        Me.Company_Category.DataPropertyName = "Company_Category"
        Me.Company_Category.HeaderText = "Categoría"
        Me.Company_Category.Name = "Company_Category"
        Me.Company_Category.ReadOnly = True
        Me.Company_Category.Width = 150
        '
        'cmdDiasCobro
        '
        Me.cmdDiasCobro.Controls.Add(Me.rbEspecificos)
        Me.cmdDiasCobro.Controls.Add(Me.Label1)
        Me.cmdDiasCobro.Controls.Add(Me.rbTodos)
        Me.cmdDiasCobro.Controls.Add(Me.chkDomingo)
        Me.cmdDiasCobro.Controls.Add(Me.chkSabado)
        Me.cmdDiasCobro.Controls.Add(Me.chkViernes)
        Me.cmdDiasCobro.Controls.Add(Me.chkJueves)
        Me.cmdDiasCobro.Controls.Add(Me.chkMiercoles)
        Me.cmdDiasCobro.Controls.Add(Me.chkMartes)
        Me.cmdDiasCobro.Controls.Add(Me.chkLunes)
        Me.cmdDiasCobro.Controls.Add(Me.dtpFechaCobro)
        Me.cmdDiasCobro.Controls.Add(Me.Label10)
        Me.cmdDiasCobro.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDiasCobro.Location = New System.Drawing.Point(16, 24)
        Me.cmdDiasCobro.Name = "cmdDiasCobro"
        Me.cmdDiasCobro.Size = New System.Drawing.Size(825, 142)
        Me.cmdDiasCobro.TabIndex = 62
        Me.cmdDiasCobro.TabStop = False
        Me.cmdDiasCobro.Text = "Detalle"
        '
        'rbEspecificos
        '
        Me.rbEspecificos.AutoSize = True
        Me.rbEspecificos.Location = New System.Drawing.Point(313, 71)
        Me.rbEspecificos.Name = "rbEspecificos"
        Me.rbEspecificos.Size = New System.Drawing.Size(165, 29)
        Me.rbEspecificos.TabIndex = 73
        Me.rbEspecificos.Text = "Días Específicos"
        Me.rbEspecificos.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(138, 25)
        Me.Label1.TabIndex = 72
        Me.Label1.Text = "Tipo de Cobro:"
        '
        'rbTodos
        '
        Me.rbTodos.AutoSize = True
        Me.rbTodos.Checked = True
        Me.rbTodos.Location = New System.Drawing.Point(153, 71)
        Me.rbTodos.Name = "rbTodos"
        Me.rbTodos.Size = New System.Drawing.Size(154, 29)
        Me.rbTodos.TabIndex = 71
        Me.rbTodos.TabStop = True
        Me.rbTodos.Text = "Todos los Días"
        Me.rbTodos.UseVisualStyleBackColor = True
        '
        'chkDomingo
        '
        Me.chkDomingo.AutoSize = True
        Me.chkDomingo.Location = New System.Drawing.Point(579, 101)
        Me.chkDomingo.Name = "chkDomingo"
        Me.chkDomingo.Size = New System.Drawing.Size(111, 29)
        Me.chkDomingo.TabIndex = 70
        Me.chkDomingo.Text = "Domingo"
        Me.chkDomingo.UseVisualStyleBackColor = True
        '
        'chkSabado
        '
        Me.chkSabado.AutoSize = True
        Me.chkSabado.Location = New System.Drawing.Point(487, 101)
        Me.chkSabado.Name = "chkSabado"
        Me.chkSabado.Size = New System.Drawing.Size(96, 29)
        Me.chkSabado.TabIndex = 69
        Me.chkSabado.Text = "Sábado"
        Me.chkSabado.UseVisualStyleBackColor = True
        '
        'chkViernes
        '
        Me.chkViernes.AutoSize = True
        Me.chkViernes.Location = New System.Drawing.Point(387, 101)
        Me.chkViernes.Name = "chkViernes"
        Me.chkViernes.Size = New System.Drawing.Size(94, 29)
        Me.chkViernes.TabIndex = 68
        Me.chkViernes.Text = "Viernes"
        Me.chkViernes.UseVisualStyleBackColor = True
        '
        'chkJueves
        '
        Me.chkJueves.AutoSize = True
        Me.chkJueves.Location = New System.Drawing.Point(294, 101)
        Me.chkJueves.Name = "chkJueves"
        Me.chkJueves.Size = New System.Drawing.Size(87, 29)
        Me.chkJueves.TabIndex = 67
        Me.chkJueves.Text = "Jueves"
        Me.chkJueves.UseVisualStyleBackColor = True
        '
        'chkMiercoles
        '
        Me.chkMiercoles.AutoSize = True
        Me.chkMiercoles.Location = New System.Drawing.Point(189, 101)
        Me.chkMiercoles.Name = "chkMiercoles"
        Me.chkMiercoles.Size = New System.Drawing.Size(112, 29)
        Me.chkMiercoles.TabIndex = 66
        Me.chkMiercoles.Text = "Miércoles"
        Me.chkMiercoles.UseVisualStyleBackColor = True
        '
        'chkMartes
        '
        Me.chkMartes.AutoSize = True
        Me.chkMartes.Location = New System.Drawing.Point(103, 101)
        Me.chkMartes.Name = "chkMartes"
        Me.chkMartes.Size = New System.Drawing.Size(90, 29)
        Me.chkMartes.TabIndex = 65
        Me.chkMartes.Text = "Martes"
        Me.chkMartes.UseVisualStyleBackColor = True
        '
        'chkLunes
        '
        Me.chkLunes.AutoSize = True
        Me.chkLunes.Location = New System.Drawing.Point(17, 101)
        Me.chkLunes.Name = "chkLunes"
        Me.chkLunes.Size = New System.Drawing.Size(80, 29)
        Me.chkLunes.TabIndex = 64
        Me.chkLunes.Text = "Lunes"
        Me.chkLunes.UseVisualStyleBackColor = True
        '
        'dtpFechaCobro
        '
        Me.dtpFechaCobro.CustomFormat = "MMMM yyyy"
        Me.dtpFechaCobro.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFechaCobro.Location = New System.Drawing.Point(171, 28)
        Me.dtpFechaCobro.Name = "dtpFechaCobro"
        Me.dtpFechaCobro.Size = New System.Drawing.Size(307, 33)
        Me.dtpFechaCobro.TabIndex = 63
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.Label10.Location = New System.Drawing.Point(23, 32)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(141, 25)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Mes de cobro : "
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
        Me.cmdGrabar.Location = New System.Drawing.Point(344, 443)
        Me.cmdGrabar.Name = "cmdGrabar"
        Me.cmdGrabar.Size = New System.Drawing.Size(153, 37)
        Me.cmdGrabar.TabIndex = 7
        Me.cmdGrabar.Text = "Generar"
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
        Me.cmdCancel.Location = New System.Drawing.Point(503, 443)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(153, 37)
        Me.cmdCancel.TabIndex = 8
        Me.cmdCancel.Text = "Salir"
        Me.cmdCancel.UseVisualStyleBackColor = False
        '
        'ERP_CuentasPorCobrar_CobrosProgramados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(867, 507)
        Me.Controls.Add(Me.GbClientes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ERP_CuentasPorCobrar_CobrosProgramados"
        Me.Text = "ERP_CuentasPorCobrar_CobrosProgramados"
        Me.GbClientes.ResumeLayout(False)
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmdDiasCobro.ResumeLayout(False)
        Me.cmdDiasCobro.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GbClientes As GroupBox
	Friend WithEvents dgvClientes As DataGridView
	Friend WithEvents cmdDiasCobro As GroupBox
	Friend WithEvents dtpFechaCobro As DateTimePicker
	Private WithEvents Label10 As Label
	Private WithEvents cmdGrabar As Button
	Private WithEvents cmdCancel As Button
	Friend WithEvents rbEspecificos As RadioButton
	Friend WithEvents Label1 As Label
	Friend WithEvents rbTodos As RadioButton
	Friend WithEvents chkDomingo As CheckBox
	Friend WithEvents chkSabado As CheckBox
	Friend WithEvents chkViernes As CheckBox
	Friend WithEvents chkJueves As CheckBox
	Friend WithEvents chkMiercoles As CheckBox
	Friend WithEvents chkMartes As CheckBox
	Friend WithEvents chkLunes As CheckBox
    Private WithEvents Button1 As Button
    Friend WithEvents Activo As DataGridViewCheckBoxColumn
    Friend WithEvents Name_Company As DataGridViewTextBoxColumn
    Friend WithEvents ContactEmployee As DataGridViewTextBoxColumn
    Friend WithEvents Company_Category As DataGridViewTextBoxColumn
End Class
