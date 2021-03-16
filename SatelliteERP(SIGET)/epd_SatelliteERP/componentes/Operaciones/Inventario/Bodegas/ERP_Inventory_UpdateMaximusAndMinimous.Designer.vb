<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ERP_Inventory_UpdateMaximusAndMinimous
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtMinimo = New System.Windows.Forms.TextBox()
        Me.txtMaximo = New System.Windows.Forms.TextBox()
        Me.txtNameProduct = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cmdAceptar = New System.Windows.Forms.Button()
        Me.Cantidad.SuspendLayout()
        Me.SuspendLayout()
        '
        'Cantidad
        '
        Me.Cantidad.BackColor = System.Drawing.SystemColors.Control
        Me.Cantidad.Controls.Add(Me.Label2)
        Me.Cantidad.Controls.Add(Me.Label1)
        Me.Cantidad.Controls.Add(Me.txtMinimo)
        Me.Cantidad.Controls.Add(Me.txtMaximo)
        Me.Cantidad.Controls.Add(Me.txtNameProduct)
        Me.Cantidad.Controls.Add(Me.Button1)
        Me.Cantidad.Controls.Add(Me.cmdAceptar)
        Me.Cantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cantidad.Location = New System.Drawing.Point(7, 9)
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.Size = New System.Drawing.Size(432, 274)
        Me.Cantidad.TabIndex = 1
        Me.Cantidad.TabStop = False
        Me.Cantidad.Text = "Configurar Máximos y Mínimos"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(94, 171)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 25)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Mínimo :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(92, 130)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 25)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Máximo :"
        '
        'txtMinimo
        '
        Me.txtMinimo.BackColor = System.Drawing.Color.Gainsboro
        Me.txtMinimo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMinimo.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMinimo.Location = New System.Drawing.Point(204, 172)
        Me.txtMinimo.MaxLength = 15
        Me.txtMinimo.Name = "txtMinimo"
        Me.txtMinimo.Size = New System.Drawing.Size(199, 26)
        Me.txtMinimo.TabIndex = 29
        Me.txtMinimo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtMaximo
        '
        Me.txtMaximo.BackColor = System.Drawing.Color.Gainsboro
        Me.txtMaximo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMaximo.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMaximo.Location = New System.Drawing.Point(206, 131)
        Me.txtMaximo.MaxLength = 15
        Me.txtMaximo.Name = "txtMaximo"
        Me.txtMaximo.Size = New System.Drawing.Size(199, 26)
        Me.txtMaximo.TabIndex = 28
        Me.txtMaximo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtNameProduct
        '
        Me.txtNameProduct.BackColor = System.Drawing.Color.Gainsboro
        Me.txtNameProduct.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNameProduct.Enabled = False
        Me.txtNameProduct.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNameProduct.Location = New System.Drawing.Point(22, 36)
        Me.txtNameProduct.MaxLength = 200
        Me.txtNameProduct.Multiline = True
        Me.txtNameProduct.Name = "txtNameProduct"
        Me.txtNameProduct.ReadOnly = True
        Me.txtNameProduct.Size = New System.Drawing.Size(387, 71)
        Me.txtNameProduct.TabIndex = 27
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
        Me.Button1.Location = New System.Drawing.Point(214, 228)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(98, 29)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Cancelar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'cmdAceptar
        '
        Me.cmdAceptar.BackColor = System.Drawing.Color.Gainsboro
        Me.cmdAceptar.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdAceptar.FlatAppearance.BorderSize = 0
        Me.cmdAceptar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.cmdAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.cmdAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAceptar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAceptar.Location = New System.Drawing.Point(110, 228)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(98, 29)
        Me.cmdAceptar.TabIndex = 7
        Me.cmdAceptar.Text = "Aceptar"
        Me.cmdAceptar.UseVisualStyleBackColor = False
        '
        'ERP_Inventory_UpdateMaximusAndMinimous
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CadetBlue
        Me.ClientSize = New System.Drawing.Size(446, 292)
        Me.Controls.Add(Me.Cantidad)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ERP_Inventory_UpdateMaximusAndMinimous"
        Me.Text = "ERP_Inventory_UpdateMaximusAndMinimous"
        Me.Cantidad.ResumeLayout(False)
        Me.Cantidad.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Cantidad As GroupBox
	Private WithEvents Button1 As Button
	Private WithEvents cmdAceptar As Button
	Private WithEvents txtMinimo As TextBox
	Private WithEvents txtMaximo As TextBox
	Private WithEvents txtNameProduct As TextBox
	Private WithEvents Label2 As Label
	Private WithEvents Label1 As Label
End Class
