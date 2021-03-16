<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ERP_CuentasPorCobrar_DialogFechasSelect
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
        Me.dtpDateEnd = New System.Windows.Forms.DateTimePicker()
        Me.dtpDateInit = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdGrabar = New System.Windows.Forms.Button()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.GbClientes.SuspendLayout()
        Me.SuspendLayout()
        '
        'GbClientes
        '
        Me.GbClientes.BackColor = System.Drawing.SystemColors.Control
        Me.GbClientes.Controls.Add(Me.dtpDateEnd)
        Me.GbClientes.Controls.Add(Me.dtpDateInit)
        Me.GbClientes.Controls.Add(Me.Label2)
        Me.GbClientes.Controls.Add(Me.Label1)
        Me.GbClientes.Controls.Add(Me.cmdGrabar)
        Me.GbClientes.Controls.Add(Me.cmdCancel)
        Me.GbClientes.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GbClientes.Location = New System.Drawing.Point(12, 12)
        Me.GbClientes.Name = "GbClientes"
        Me.GbClientes.Size = New System.Drawing.Size(584, 210)
        Me.GbClientes.TabIndex = 45
        Me.GbClientes.TabStop = False
        Me.GbClientes.Text = "Rango de Fechas"
        '
        'dtpDateEnd
        '
        Me.dtpDateEnd.Location = New System.Drawing.Point(134, 88)
        Me.dtpDateEnd.Name = "dtpDateEnd"
        Me.dtpDateEnd.Size = New System.Drawing.Size(423, 33)
        Me.dtpDateEnd.TabIndex = 12
        '
        'dtpDateInit
        '
        Me.dtpDateInit.Location = New System.Drawing.Point(134, 41)
        Me.dtpDateInit.Name = "dtpDateInit"
        Me.dtpDateInit.Size = New System.Drawing.Size(423, 33)
        Me.dtpDateInit.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 25)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Fecha Final:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 25)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Fecha Inicial:"
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
        Me.cmdGrabar.Location = New System.Drawing.Point(158, 151)
        Me.cmdGrabar.Name = "cmdGrabar"
        Me.cmdGrabar.Size = New System.Drawing.Size(153, 37)
        Me.cmdGrabar.TabIndex = 7
        Me.cmdGrabar.Text = "Continuar"
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
        Me.cmdCancel.Location = New System.Drawing.Point(317, 151)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(153, 37)
        Me.cmdCancel.TabIndex = 8
        Me.cmdCancel.Text = "Salir"
        Me.cmdCancel.UseVisualStyleBackColor = False
        '
        'ERP_CuentasPorCobrar_DialogFechasSelect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(608, 231)
        Me.Controls.Add(Me.GbClientes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ERP_CuentasPorCobrar_DialogFechasSelect"
        Me.Text = "ERP_CuentasPorCobrar_DialogFechasSelect"
        Me.GbClientes.ResumeLayout(False)
        Me.GbClientes.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GbClientes As GroupBox
	Friend WithEvents dtpDateEnd As DateTimePicker
	Friend WithEvents dtpDateInit As DateTimePicker
	Friend WithEvents Label2 As Label
	Friend WithEvents Label1 As Label
	Private WithEvents cmdGrabar As Button
	Private WithEvents cmdCancel As Button
End Class
