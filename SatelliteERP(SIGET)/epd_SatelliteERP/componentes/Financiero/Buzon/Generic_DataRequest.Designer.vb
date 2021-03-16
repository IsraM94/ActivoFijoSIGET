<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Generic_DataRequest
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
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cb_Employee = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cbType = New System.Windows.Forms.ComboBox()
        Me.cmdGrabar = New System.Windows.Forms.Button()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.GbClientes.SuspendLayout()
        Me.SuspendLayout()
        '
        'GbClientes
        '
        Me.GbClientes.BackColor = System.Drawing.SystemColors.Control
        Me.GbClientes.Controls.Add(Me.txtDescripcion)
        Me.GbClientes.Controls.Add(Me.Label13)
        Me.GbClientes.Controls.Add(Me.Label1)
        Me.GbClientes.Controls.Add(Me.cb_Employee)
        Me.GbClientes.Controls.Add(Me.Label12)
        Me.GbClientes.Controls.Add(Me.cbType)
        Me.GbClientes.Controls.Add(Me.cmdGrabar)
        Me.GbClientes.Controls.Add(Me.cmdCancel)
        Me.GbClientes.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GbClientes.Location = New System.Drawing.Point(7, 7)
        Me.GbClientes.Name = "GbClientes"
        Me.GbClientes.Size = New System.Drawing.Size(672, 373)
        Me.GbClientes.TabIndex = 46
        Me.GbClientes.TabStop = False
        Me.GbClientes.Text = "Datos Solicitud"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.BackColor = System.Drawing.Color.Gainsboro
        Me.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDescripcion.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.Location = New System.Drawing.Point(143, 156)
        Me.txtDescripcion.MaxLength = 150
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.ShortcutsEnabled = False
        Me.txtDescripcion.Size = New System.Drawing.Size(447, 136)
        Me.txtDescripcion.TabIndex = 20
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.Label13.Location = New System.Drawing.Point(14, 156)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(123, 25)
        Me.Label13.TabIndex = 19
        Me.Label13.Text = "Comentarios:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.Label1.Location = New System.Drawing.Point(37, 105)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 25)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Empleado:"
        '
        'cb_Employee
        '
        Me.cb_Employee.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cb_Employee.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cb_Employee.BackColor = System.Drawing.Color.Gainsboro
        Me.cb_Employee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_Employee.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cb_Employee.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_Employee.FormattingEnabled = True
        Me.cb_Employee.Location = New System.Drawing.Point(143, 101)
        Me.cb_Employee.Name = "cb_Employee"
        Me.cb_Employee.Size = New System.Drawing.Size(447, 29)
        Me.cb_Employee.TabIndex = 18
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.Label12.Location = New System.Drawing.Point(85, 54)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(53, 25)
        Me.Label12.TabIndex = 15
        Me.Label12.Text = "Tipo:"
        '
        'cbType
        '
        Me.cbType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbType.BackColor = System.Drawing.Color.Gainsboro
        Me.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbType.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbType.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbType.FormattingEnabled = True
        Me.cbType.Location = New System.Drawing.Point(143, 51)
        Me.cbType.Name = "cbType"
        Me.cbType.Size = New System.Drawing.Size(447, 29)
        Me.cbType.TabIndex = 16
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
        Me.cmdGrabar.Location = New System.Drawing.Point(243, 324)
        Me.cmdGrabar.Name = "cmdGrabar"
        Me.cmdGrabar.Size = New System.Drawing.Size(114, 37)
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
        Me.cmdCancel.Location = New System.Drawing.Point(363, 324)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(110, 37)
        Me.cmdCancel.TabIndex = 8
        Me.cmdCancel.Text = "Salir"
        Me.cmdCancel.UseVisualStyleBackColor = False
        '
        'Generic_DataRequest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(688, 391)
        Me.Controls.Add(Me.GbClientes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Generic_DataRequest"
        Me.Text = "Generic_DataRequest"
        Me.GbClientes.ResumeLayout(False)
        Me.GbClientes.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GbClientes As GroupBox
	Private WithEvents cmdGrabar As Button
	Private WithEvents cmdCancel As Button
	Private WithEvents Label1 As Label
	Private WithEvents cb_Employee As ComboBox
	Private WithEvents Label12 As Label
	Private WithEvents cbType As ComboBox
	Private WithEvents txtDescripcion As TextBox
	Private WithEvents Label13 As Label
End Class
