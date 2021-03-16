<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ERP_CuentasPorCobrar_PagosFechas
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
        Me.cmdDiasCobro = New System.Windows.Forms.GroupBox()
        Me.txtMonto = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chkDigitador = New System.Windows.Forms.CheckBox()
        Me.chkCliente = New System.Windows.Forms.CheckBox()
        Me.chkVendedor = New System.Windows.Forms.CheckBox()
        Me.dtpFechaCobro = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmdGrabar = New System.Windows.Forms.Button()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.GbClientes.SuspendLayout()
        Me.cmdDiasCobro.SuspendLayout()
        Me.SuspendLayout()
        '
        'GbClientes
        '
        Me.GbClientes.BackColor = System.Drawing.SystemColors.Control
        Me.GbClientes.Controls.Add(Me.cmdDiasCobro)
        Me.GbClientes.Controls.Add(Me.cmdGrabar)
        Me.GbClientes.Controls.Add(Me.cmdCancel)
        Me.GbClientes.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GbClientes.Location = New System.Drawing.Point(12, 12)
        Me.GbClientes.Name = "GbClientes"
        Me.GbClientes.Size = New System.Drawing.Size(586, 293)
        Me.GbClientes.TabIndex = 46
        Me.GbClientes.TabStop = False
        Me.GbClientes.Text = "Agregar Pago Parcial"
        '
        'cmdDiasCobro
        '
        Me.cmdDiasCobro.Controls.Add(Me.txtMonto)
        Me.cmdDiasCobro.Controls.Add(Me.Label2)
        Me.cmdDiasCobro.Controls.Add(Me.Label1)
        Me.cmdDiasCobro.Controls.Add(Me.chkDigitador)
        Me.cmdDiasCobro.Controls.Add(Me.chkCliente)
        Me.cmdDiasCobro.Controls.Add(Me.chkVendedor)
        Me.cmdDiasCobro.Controls.Add(Me.dtpFechaCobro)
        Me.cmdDiasCobro.Controls.Add(Me.Label10)
        Me.cmdDiasCobro.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDiasCobro.Location = New System.Drawing.Point(16, 24)
        Me.cmdDiasCobro.Name = "cmdDiasCobro"
        Me.cmdDiasCobro.Size = New System.Drawing.Size(550, 193)
        Me.cmdDiasCobro.TabIndex = 62
        Me.cmdDiasCobro.TabStop = False
        Me.cmdDiasCobro.Text = "Detalle"
        '
        'txtMonto
        '
        Me.txtMonto.Location = New System.Drawing.Point(177, 92)
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.Size = New System.Drawing.Size(304, 33)
        Me.txtMonto.TabIndex = 70
        Me.txtMonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.Label2.Location = New System.Drawing.Point(79, 139)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 25)
        Me.Label2.TabIndex = 69
        Me.Label2.Text = "Firmas:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.Label1.Location = New System.Drawing.Point(79, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 25)
        Me.Label1.TabIndex = 67
        Me.Label1.Text = "Monto:"
        '
        'chkDigitador
        '
        Me.chkDigitador.AutoSize = True
        Me.chkDigitador.Location = New System.Drawing.Point(394, 148)
        Me.chkDigitador.Name = "chkDigitador"
        Me.chkDigitador.Size = New System.Drawing.Size(113, 29)
        Me.chkDigitador.TabIndex = 66
        Me.chkDigitador.Text = "Digitador"
        Me.chkDigitador.UseVisualStyleBackColor = True
        '
        'chkCliente
        '
        Me.chkCliente.AutoSize = True
        Me.chkCliente.Location = New System.Drawing.Point(297, 148)
        Me.chkCliente.Name = "chkCliente"
        Me.chkCliente.Size = New System.Drawing.Size(91, 29)
        Me.chkCliente.TabIndex = 65
        Me.chkCliente.Text = "Cliente"
        Me.chkCliente.UseVisualStyleBackColor = True
        '
        'chkVendedor
        '
        Me.chkVendedor.AutoSize = True
        Me.chkVendedor.Location = New System.Drawing.Point(177, 148)
        Me.chkVendedor.Name = "chkVendedor"
        Me.chkVendedor.Size = New System.Drawing.Size(114, 29)
        Me.chkVendedor.TabIndex = 64
        Me.chkVendedor.Text = "Vendedor"
        Me.chkVendedor.UseVisualStyleBackColor = True
        '
        'dtpFechaCobro
        '
        Me.dtpFechaCobro.CustomFormat = "MMMM yyyy"
        Me.dtpFechaCobro.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaCobro.Location = New System.Drawing.Point(174, 32)
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
        Me.Label10.Size = New System.Drawing.Size(158, 25)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Fecha de Cobro : "
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
        Me.cmdGrabar.Location = New System.Drawing.Point(138, 240)
        Me.cmdGrabar.Name = "cmdGrabar"
        Me.cmdGrabar.Size = New System.Drawing.Size(153, 37)
        Me.cmdGrabar.TabIndex = 7
        Me.cmdGrabar.Text = "Procesar"
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
        Me.cmdCancel.Location = New System.Drawing.Point(297, 240)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(153, 37)
        Me.cmdCancel.TabIndex = 8
        Me.cmdCancel.Text = "Salir"
        Me.cmdCancel.UseVisualStyleBackColor = False
        '
        'ERP_CuentasPorCobrar_PagosFechas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(609, 316)
        Me.Controls.Add(Me.GbClientes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ERP_CuentasPorCobrar_PagosFechas"
        Me.Text = "ERP_CuentasPorCobrar_PagosFechas"
        Me.GbClientes.ResumeLayout(False)
        Me.cmdDiasCobro.ResumeLayout(False)
        Me.cmdDiasCobro.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GbClientes As GroupBox
	Friend WithEvents cmdDiasCobro As GroupBox
	Friend WithEvents chkDigitador As CheckBox
	Friend WithEvents chkCliente As CheckBox
	Friend WithEvents chkVendedor As CheckBox
	Friend WithEvents dtpFechaCobro As DateTimePicker
	Private WithEvents Label10 As Label
	Private WithEvents cmdGrabar As Button
	Private WithEvents cmdCancel As Button
	Private WithEvents Label2 As Label
	Private WithEvents Label1 As Label
	Friend WithEvents txtMonto As TextBox
End Class
