<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ERP_Inventory_HeaderImputsAndOutputs
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
        Me.txtComentario = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cmdContinuar = New System.Windows.Forms.Button()
        Me.txtAutorizo = New System.Windows.Forms.TextBox()
        Me.Cantidad.SuspendLayout()
        Me.SuspendLayout()
        '
        'Cantidad
        '
        Me.Cantidad.BackColor = System.Drawing.SystemColors.Control
        Me.Cantidad.Controls.Add(Me.Label2)
        Me.Cantidad.Controls.Add(Me.Label1)
        Me.Cantidad.Controls.Add(Me.txtComentario)
        Me.Cantidad.Controls.Add(Me.Button1)
        Me.Cantidad.Controls.Add(Me.cmdContinuar)
        Me.Cantidad.Controls.Add(Me.txtAutorizo)
        Me.Cantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cantidad.Location = New System.Drawing.Point(12, 12)
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.Size = New System.Drawing.Size(450, 237)
        Me.Cantidad.TabIndex = 1
        Me.Cantidad.TabStop = False
        Me.Cantidad.Text = "Cantidad"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 20)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Comentario:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 20)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Autorizó:"
        '
        'txtComentario
        '
        Me.txtComentario.Location = New System.Drawing.Point(130, 77)
        Me.txtComentario.MaxLength = 50
        Me.txtComentario.Multiline = True
        Me.txtComentario.Name = "txtComentario"
        Me.txtComentario.Size = New System.Drawing.Size(248, 87)
        Me.txtComentario.TabIndex = 9
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
        Me.Button1.Location = New System.Drawing.Point(346, 202)
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
        Me.cmdContinuar.Location = New System.Drawing.Point(242, 202)
        Me.cmdContinuar.Name = "cmdContinuar"
        Me.cmdContinuar.Size = New System.Drawing.Size(98, 29)
        Me.cmdContinuar.TabIndex = 7
        Me.cmdContinuar.Text = "Continuar"
        Me.cmdContinuar.UseVisualStyleBackColor = False
        '
        'txtAutorizo
        '
        Me.txtAutorizo.Location = New System.Drawing.Point(130, 39)
        Me.txtAutorizo.Name = "txtAutorizo"
        Me.txtAutorizo.Size = New System.Drawing.Size(248, 26)
        Me.txtAutorizo.TabIndex = 0
        '
        'ERP_Inventory_HeaderImputsAndOutputs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(474, 261)
        Me.Controls.Add(Me.Cantidad)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ERP_Inventory_HeaderImputsAndOutputs"
        Me.Text = "ERP_Inventory_HeaderImputsAndOutputs"
        Me.Cantidad.ResumeLayout(False)
        Me.Cantidad.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Cantidad As GroupBox
	Friend WithEvents Label2 As Label
	Friend WithEvents Label1 As Label
	Friend WithEvents txtComentario As TextBox
	Private WithEvents Button1 As Button
	Private WithEvents cmdContinuar As Button
	Friend WithEvents txtAutorizo As TextBox
End Class
