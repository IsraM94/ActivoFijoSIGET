<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class precios
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
        Me.Cantidad = New System.Windows.Forms.GroupBox()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cmdContinuar = New System.Windows.Forms.Button()
        Me.Cantidad.SuspendLayout()
        Me.SuspendLayout()
        '
        'Cantidad
        '
        Me.Cantidad.BackColor = System.Drawing.SystemColors.Control
        Me.Cantidad.Controls.Add(Me.txtPrecio)
        Me.Cantidad.Controls.Add(Me.Button1)
        Me.Cantidad.Controls.Add(Me.cmdContinuar)
        Me.Cantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cantidad.Location = New System.Drawing.Point(9, 10)
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.Size = New System.Drawing.Size(274, 126)
        Me.Cantidad.TabIndex = 3
        Me.Cantidad.TabStop = False
        Me.Cantidad.Text = "Precio de venta con IVA"
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(36, 37)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(218, 26)
        Me.txtPrecio.TabIndex = 9
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
        Me.Button1.Location = New System.Drawing.Point(140, 84)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(98, 29)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Cancelar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'cmdContinuar
        '
        Me.cmdContinuar.BackColor = System.Drawing.Color.Gainsboro
        Me.cmdContinuar.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdContinuar.FlatAppearance.BorderSize = 0
        Me.cmdContinuar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.cmdContinuar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.cmdContinuar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdContinuar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdContinuar.Location = New System.Drawing.Point(36, 84)
        Me.cmdContinuar.Name = "cmdContinuar"
        Me.cmdContinuar.Size = New System.Drawing.Size(98, 29)
        Me.cmdContinuar.TabIndex = 7
        Me.cmdContinuar.Text = "Continuar"
        Me.cmdContinuar.UseVisualStyleBackColor = False
        '
        'precios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(293, 148)
        Me.Controls.Add(Me.Cantidad)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "precios"
        Me.Text = "precios"
        Me.Cantidad.ResumeLayout(False)
        Me.Cantidad.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Cantidad As GroupBox
	Private WithEvents Button1 As Button
	Private WithEvents cmdContinuar As Button
	Friend WithEvents txtPrecio As TextBox
End Class
