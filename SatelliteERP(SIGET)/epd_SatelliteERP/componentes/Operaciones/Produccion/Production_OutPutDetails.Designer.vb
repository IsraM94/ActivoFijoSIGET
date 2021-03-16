<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Production_OutPutDetails
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
        Me.chkSalida = New System.Windows.Forms.CheckBox()
        Me.txtPeso = New System.Windows.Forms.TextBox()
        Me.txtNameAnimal = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.cmdprint = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.chkSalida)
        Me.GroupBox1.Controls.Add(Me.txtPeso)
        Me.GroupBox1.Controls.Add(Me.txtNameAnimal)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cmdCancel)
        Me.GroupBox1.Controls.Add(Me.cmdprint)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(7, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(446, 220)
        Me.GroupBox1.TabIndex = 37
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detalle Animal"
        '
        'chkSalida
        '
        Me.chkSalida.AutoSize = True
        Me.chkSalida.Location = New System.Drawing.Point(104, 136)
        Me.chkSalida.Name = "chkSalida"
        Me.chkSalida.Size = New System.Drawing.Size(84, 29)
        Me.chkSalida.TabIndex = 40
        Me.chkSalida.Text = "Salida"
        Me.chkSalida.UseVisualStyleBackColor = True
        '
        'txtPeso
        '
        Me.txtPeso.BackColor = System.Drawing.Color.Gainsboro
        Me.txtPeso.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPeso.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPeso.Location = New System.Drawing.Point(102, 104)
        Me.txtPeso.MaxLength = 20
        Me.txtPeso.Name = "txtPeso"
        Me.txtPeso.ShortcutsEnabled = False
        Me.txtPeso.Size = New System.Drawing.Size(278, 26)
        Me.txtPeso.TabIndex = 39
        Me.txtPeso.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtNameAnimal
        '
        Me.txtNameAnimal.Enabled = False
        Me.txtNameAnimal.Location = New System.Drawing.Point(44, 32)
        Me.txtNameAnimal.Multiline = True
        Me.txtNameAnimal.Name = "txtNameAnimal"
        Me.txtNameAnimal.ReadOnly = True
        Me.txtNameAnimal.Size = New System.Drawing.Size(350, 51)
        Me.txtNameAnimal.TabIndex = 36
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(39, 105)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 25)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Peso:"
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
        Me.cmdCancel.Location = New System.Drawing.Point(211, 173)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(98, 29)
        Me.cmdCancel.TabIndex = 33
        Me.cmdCancel.Text = "Cancelar"
        Me.cmdCancel.UseVisualStyleBackColor = False
        '
        'cmdprint
        '
        Me.cmdprint.BackColor = System.Drawing.Color.Gainsboro
        Me.cmdprint.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdprint.FlatAppearance.BorderSize = 0
        Me.cmdprint.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.cmdprint.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.cmdprint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdprint.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdprint.Location = New System.Drawing.Point(107, 173)
        Me.cmdprint.Name = "cmdprint"
        Me.cmdprint.Size = New System.Drawing.Size(98, 29)
        Me.cmdprint.TabIndex = 31
        Me.cmdprint.Text = "Guardar"
        Me.cmdprint.UseVisualStyleBackColor = False
        '
        'Production_OutPutDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(461, 235)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Production_OutPutDetails"
        Me.Text = "Production_OutPutDetails"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
	Friend WithEvents chkSalida As CheckBox
	Private WithEvents txtPeso As TextBox
	Friend WithEvents txtNameAnimal As TextBox
	Friend WithEvents Label1 As Label
	Private WithEvents cmdCancel As Button
	Private WithEvents cmdprint As Button
End Class
