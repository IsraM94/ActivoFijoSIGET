<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CxC
	Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
		Me.Label1 = New System.Windows.Forms.Label()
		Me.lblID_Solicitud = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.lblMonto = New System.Windows.Forms.Label()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.txtComentario = New System.Windows.Forms.TextBox()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.lblFecha = New System.Windows.Forms.Label()
		Me.Label11 = New System.Windows.Forms.Label()
		Me.Label12 = New System.Windows.Forms.Label()
		Me.txtCliente = New System.Windows.Forms.TextBox()
		Me.txtEmpleado = New System.Windows.Forms.TextBox()
		Me.cmdAprobar = New System.Windows.Forms.Button()
		Me.cmdDenegar = New System.Windows.Forms.Button()
		Me.txtCredito = New System.Windows.Forms.TextBox()
		Me.txtTipo = New System.Windows.Forms.TextBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(13, 12)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(64, 13)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "ID Solicitud:"
		'
		'lblID_Solicitud
		'
		Me.lblID_Solicitud.AutoSize = True
		Me.lblID_Solicitud.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblID_Solicitud.Location = New System.Drawing.Point(80, 12)
		Me.lblID_Solicitud.Name = "lblID_Solicitud"
		Me.lblID_Solicitud.Size = New System.Drawing.Size(63, 13)
		Me.lblID_Solicitud.TabIndex = 1
		Me.lblID_Solicitud.Text = "12456789"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.Location = New System.Drawing.Point(101, 32)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(64, 20)
		Me.Label3.TabIndex = 2
		Me.Label3.Text = "Monto:"
		'
		'lblMonto
		'
		Me.lblMonto.AutoSize = True
		Me.lblMonto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblMonto.Location = New System.Drawing.Point(171, 32)
		Me.lblMonto.Name = "lblMonto"
		Me.lblMonto.Size = New System.Drawing.Size(64, 20)
		Me.lblMonto.TabIndex = 3
		Me.lblMonto.Text = "$12.00"
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.Location = New System.Drawing.Point(3, 137)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(57, 13)
		Me.Label6.TabIndex = 5
		Me.Label6.Text = "Empleado:"
		'
		'txtComentario
		'
		Me.txtComentario.Enabled = False
		Me.txtComentario.Location = New System.Drawing.Point(3, 178)
		Me.txtComentario.Multiline = True
		Me.txtComentario.Name = "txtComentario"
		Me.txtComentario.ReadOnly = True
		Me.txtComentario.Size = New System.Drawing.Size(351, 75)
		Me.txtComentario.TabIndex = 6
		'
		'Label7
		'
		Me.Label7.AutoSize = True
		Me.Label7.Location = New System.Drawing.Point(3, 162)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(68, 13)
		Me.Label7.TabIndex = 7
		Me.Label7.Text = "Comentarios:"
		'
		'Label8
		'
		Me.Label8.AutoSize = True
		Me.Label8.Location = New System.Drawing.Point(13, 108)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(42, 13)
		Me.Label8.TabIndex = 9
		Me.Label8.Text = "Cliente:"
		'
		'lblFecha
		'
		Me.lblFecha.AutoSize = True
		Me.lblFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblFecha.Location = New System.Drawing.Point(247, 12)
		Me.lblFecha.Name = "lblFecha"
		Me.lblFecha.Size = New System.Drawing.Size(63, 13)
		Me.lblFecha.TabIndex = 11
		Me.lblFecha.Text = "12456789"
		'
		'Label11
		'
		Me.Label11.AutoSize = True
		Me.Label11.Location = New System.Drawing.Point(201, 12)
		Me.Label11.Name = "Label11"
		Me.Label11.Size = New System.Drawing.Size(40, 13)
		Me.Label11.TabIndex = 10
		Me.Label11.Text = "Fecha:"
		'
		'Label12
		'
		Me.Label12.AutoSize = True
		Me.Label12.Location = New System.Drawing.Point(12, 85)
		Me.Label12.Name = "Label12"
		Me.Label12.Size = New System.Drawing.Size(43, 13)
		Me.Label12.TabIndex = 13
		Me.Label12.Text = "Credito:"
		'
		'txtCliente
		'
		Me.txtCliente.Enabled = False
		Me.txtCliente.Location = New System.Drawing.Point(59, 105)
		Me.txtCliente.Name = "txtCliente"
		Me.txtCliente.ReadOnly = True
		Me.txtCliente.Size = New System.Drawing.Size(295, 20)
		Me.txtCliente.TabIndex = 14
		'
		'txtEmpleado
		'
		Me.txtEmpleado.Enabled = False
		Me.txtEmpleado.Location = New System.Drawing.Point(59, 134)
		Me.txtEmpleado.Name = "txtEmpleado"
		Me.txtEmpleado.ReadOnly = True
		Me.txtEmpleado.Size = New System.Drawing.Size(295, 20)
		Me.txtEmpleado.TabIndex = 15
		'
		'cmdAprobar
		'
		Me.cmdAprobar.Location = New System.Drawing.Point(109, 259)
		Me.cmdAprobar.Name = "cmdAprobar"
		Me.cmdAprobar.Size = New System.Drawing.Size(75, 23)
		Me.cmdAprobar.TabIndex = 16
		Me.cmdAprobar.Text = "Aprobar"
		Me.cmdAprobar.UseVisualStyleBackColor = True
		'
		'cmdDenegar
		'
		Me.cmdDenegar.Location = New System.Drawing.Point(190, 258)
		Me.cmdDenegar.Name = "cmdDenegar"
		Me.cmdDenegar.Size = New System.Drawing.Size(75, 23)
		Me.cmdDenegar.TabIndex = 17
		Me.cmdDenegar.Text = "Denegar"
		Me.cmdDenegar.UseVisualStyleBackColor = True
		'
		'txtCredito
		'
		Me.txtCredito.Enabled = False
		Me.txtCredito.Location = New System.Drawing.Point(59, 82)
		Me.txtCredito.Name = "txtCredito"
		Me.txtCredito.ReadOnly = True
		Me.txtCredito.Size = New System.Drawing.Size(295, 20)
		Me.txtCredito.TabIndex = 18
		'
		'txtTipo
		'
		Me.txtTipo.Enabled = False
		Me.txtTipo.Location = New System.Drawing.Point(59, 57)
		Me.txtTipo.Name = "txtTipo"
		Me.txtTipo.ReadOnly = True
		Me.txtTipo.Size = New System.Drawing.Size(295, 20)
		Me.txtTipo.TabIndex = 20
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(19, 60)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(31, 13)
		Me.Label2.TabIndex = 19
		Me.Label2.Text = "Tipo:"
		'
		'CxC
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.White
		Me.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Controls.Add(Me.txtTipo)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.txtCredito)
		Me.Controls.Add(Me.cmdDenegar)
		Me.Controls.Add(Me.cmdAprobar)
		Me.Controls.Add(Me.txtEmpleado)
		Me.Controls.Add(Me.txtCliente)
		Me.Controls.Add(Me.Label12)
		Me.Controls.Add(Me.lblFecha)
		Me.Controls.Add(Me.Label11)
		Me.Controls.Add(Me.Label8)
		Me.Controls.Add(Me.Label7)
		Me.Controls.Add(Me.txtComentario)
		Me.Controls.Add(Me.Label6)
		Me.Controls.Add(Me.lblMonto)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.lblID_Solicitud)
		Me.Controls.Add(Me.Label1)
		Me.Name = "CxC"
		Me.Size = New System.Drawing.Size(358, 289)
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Label1 As Label
	Friend WithEvents lblID_Solicitud As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents lblMonto As Label
	Friend WithEvents Label6 As Label
	Friend WithEvents txtComentario As TextBox
	Friend WithEvents Label7 As Label
	Friend WithEvents Label8 As Label
	Friend WithEvents lblFecha As Label
	Friend WithEvents Label11 As Label
	Friend WithEvents Label12 As Label
	Friend WithEvents txtCliente As TextBox
	Friend WithEvents txtEmpleado As TextBox
	Friend WithEvents cmdAprobar As Button
	Friend WithEvents cmdDenegar As Button
	Friend WithEvents txtCredito As TextBox
	Friend WithEvents txtTipo As TextBox
	Friend WithEvents Label2 As Label
End Class
