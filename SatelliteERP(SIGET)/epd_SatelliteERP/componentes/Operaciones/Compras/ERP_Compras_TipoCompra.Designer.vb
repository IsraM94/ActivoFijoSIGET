<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ERP_Compras_TipoCompra
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
        Me.rbCargarArchivo = New System.Windows.Forms.RadioButton()
        Me.rbManual = New System.Windows.Forms.RadioButton()
        Me.rbSugerido = New System.Windows.Forms.RadioButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cmdContinuar = New System.Windows.Forms.Button()
        Me.Cantidad.SuspendLayout()
        Me.SuspendLayout()
        '
        'Cantidad
        '
        Me.Cantidad.BackColor = System.Drawing.SystemColors.Control
        Me.Cantidad.Controls.Add(Me.rbCargarArchivo)
        Me.Cantidad.Controls.Add(Me.rbManual)
        Me.Cantidad.Controls.Add(Me.rbSugerido)
        Me.Cantidad.Controls.Add(Me.Button1)
        Me.Cantidad.Controls.Add(Me.cmdContinuar)
        Me.Cantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cantidad.Location = New System.Drawing.Point(6, 8)
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.Size = New System.Drawing.Size(302, 176)
        Me.Cantidad.TabIndex = 2
        Me.Cantidad.TabStop = False
        Me.Cantidad.Text = "Tipo Orden de compra"
        '
        'rbCargarArchivo
        '
        Me.rbCargarArchivo.AutoSize = True
        Me.rbCargarArchivo.Location = New System.Drawing.Point(19, 96)
        Me.rbCargarArchivo.Name = "rbCargarArchivo"
        Me.rbCargarArchivo.Size = New System.Drawing.Size(145, 24)
        Me.rbCargarArchivo.TabIndex = 11
        Me.rbCargarArchivo.Text = "Cargar Archivo"
        Me.rbCargarArchivo.UseVisualStyleBackColor = True
        '
        'rbManual
        '
        Me.rbManual.AutoSize = True
        Me.rbManual.Location = New System.Drawing.Point(19, 66)
        Me.rbManual.Name = "rbManual"
        Me.rbManual.Size = New System.Drawing.Size(85, 24)
        Me.rbManual.TabIndex = 10
        Me.rbManual.Text = "Manual"
        Me.rbManual.UseVisualStyleBackColor = True
        '
        'rbSugerido
        '
        Me.rbSugerido.AutoSize = True
        Me.rbSugerido.Checked = True
        Me.rbSugerido.Location = New System.Drawing.Point(19, 36)
        Me.rbSugerido.Name = "rbSugerido"
        Me.rbSugerido.Size = New System.Drawing.Size(268, 24)
        Me.rbSugerido.TabIndex = 9
        Me.rbSugerido.TabStop = True
        Me.rbSugerido.Text = "Sugerido (Máximos y Mínimos)"
        Me.rbSugerido.UseVisualStyleBackColor = True
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
        Me.Button1.Location = New System.Drawing.Point(156, 126)
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
        Me.cmdContinuar.Location = New System.Drawing.Point(52, 126)
        Me.cmdContinuar.Name = "cmdContinuar"
        Me.cmdContinuar.Size = New System.Drawing.Size(98, 29)
        Me.cmdContinuar.TabIndex = 7
        Me.cmdContinuar.Text = "Continuar"
        Me.cmdContinuar.UseVisualStyleBackColor = False
        '
        'ERP_Compras_TipoCompra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(316, 191)
        Me.Controls.Add(Me.Cantidad)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ERP_Compras_TipoCompra"
        Me.Text = "ERP_Compras_TipoCompra"
        Me.Cantidad.ResumeLayout(False)
        Me.Cantidad.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Cantidad As GroupBox
	Friend WithEvents rbCargarArchivo As RadioButton
	Friend WithEvents rbManual As RadioButton
	Friend WithEvents rbSugerido As RadioButton
	Private WithEvents Button1 As Button
	Private WithEvents cmdContinuar As Button
End Class
