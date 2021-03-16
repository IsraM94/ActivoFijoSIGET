<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ERP_Inventory_Dialog_Quantity
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
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundWorker2 = New System.ComponentModel.BackgroundWorker()
        Me.GBSearch = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtProducto = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpFechaVencimiento = New System.Windows.Forms.DateTimePicker()
        Me.chkIncluyeIVA = New System.Windows.Forms.CheckBox()
        Me.chkUnitario = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbUnidad = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.cmdOk = New System.Windows.Forms.Button()
        Me.GBSearch.SuspendLayout()
        Me.SuspendLayout()
        '
        'GBSearch
        '
        Me.GBSearch.BackColor = System.Drawing.SystemColors.Control
        Me.GBSearch.Controls.Add(Me.Label5)
        Me.GBSearch.Controls.Add(Me.txtProducto)
        Me.GBSearch.Controls.Add(Me.Label4)
        Me.GBSearch.Controls.Add(Me.dtpFechaVencimiento)
        Me.GBSearch.Controls.Add(Me.chkIncluyeIVA)
        Me.GBSearch.Controls.Add(Me.chkUnitario)
        Me.GBSearch.Controls.Add(Me.Label3)
        Me.GBSearch.Controls.Add(Me.cbUnidad)
        Me.GBSearch.Controls.Add(Me.Label1)
        Me.GBSearch.Controls.Add(Me.txtPrecio)
        Me.GBSearch.Controls.Add(Me.Label2)
        Me.GBSearch.Controls.Add(Me.txtCantidad)
        Me.GBSearch.Controls.Add(Me.cmdCancel)
        Me.GBSearch.Controls.Add(Me.cmdOk)
        Me.GBSearch.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBSearch.Location = New System.Drawing.Point(12, 12)
        Me.GBSearch.Name = "GBSearch"
        Me.GBSearch.Size = New System.Drawing.Size(469, 356)
        Me.GBSearch.TabIndex = 34
        Me.GBSearch.TabStop = False
        Me.GBSearch.Text = "Cantidad y Precio"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(20, 50)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(138, 21)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "Nombre Producto:"
        '
        'txtProducto
        '
        Me.txtProducto.BackColor = System.Drawing.Color.Gainsboro
        Me.txtProducto.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtProducto.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProducto.Location = New System.Drawing.Point(161, 45)
        Me.txtProducto.MaxLength = 15
        Me.txtProducto.Name = "txtProducto"
        Me.txtProducto.ShortcutsEnabled = False
        Me.txtProducto.Size = New System.Drawing.Size(302, 26)
        Me.txtProducto.TabIndex = 39
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(15, 179)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(143, 21)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "Fecha Vencimiento:"
        '
        'dtpFechaVencimiento
        '
        Me.dtpFechaVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaVencimiento.Location = New System.Drawing.Point(164, 167)
        Me.dtpFechaVencimiento.Name = "dtpFechaVencimiento"
        Me.dtpFechaVencimiento.Size = New System.Drawing.Size(157, 33)
        Me.dtpFechaVencimiento.TabIndex = 37
        '
        'chkIncluyeIVA
        '
        Me.chkIncluyeIVA.AutoSize = True
        Me.chkIncluyeIVA.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkIncluyeIVA.Location = New System.Drawing.Point(165, 241)
        Me.chkIncluyeIVA.Name = "chkIncluyeIVA"
        Me.chkIncluyeIVA.Size = New System.Drawing.Size(107, 24)
        Me.chkIncluyeIVA.TabIndex = 36
        Me.chkIncluyeIVA.Text = "Incluye IVA"
        Me.chkIncluyeIVA.UseVisualStyleBackColor = True
        '
        'chkUnitario
        '
        Me.chkUnitario.AutoSize = True
        Me.chkUnitario.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkUnitario.Location = New System.Drawing.Point(165, 211)
        Me.chkUnitario.Name = "chkUnitario"
        Me.chkUnitario.Size = New System.Drawing.Size(132, 24)
        Me.chkUnitario.TabIndex = 36
        Me.chkUnitario.Text = "Precio Unitario"
        Me.chkUnitario.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(84, 275)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 21)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "Unidad:"
        '
        'cbUnidad
        '
        Me.cbUnidad.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbUnidad.FormattingEnabled = True
        Me.cbUnidad.Location = New System.Drawing.Point(161, 272)
        Me.cbUnidad.Name = "cbUnidad"
        Me.cbUnidad.Size = New System.Drawing.Size(157, 28)
        Me.cbUnidad.TabIndex = 34
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(99, 127)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 21)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Precio :"
        '
        'txtPrecio
        '
        Me.txtPrecio.BackColor = System.Drawing.Color.Gainsboro
        Me.txtPrecio.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPrecio.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecio.Location = New System.Drawing.Point(165, 124)
        Me.txtPrecio.MaxLength = 15
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.ShortcutsEnabled = False
        Me.txtPrecio.Size = New System.Drawing.Size(156, 26)
        Me.txtPrecio.TabIndex = 2
        Me.txtPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(85, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 21)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Cantidad:"
        '
        'txtCantidad
        '
        Me.txtCantidad.BackColor = System.Drawing.Color.Gainsboro
        Me.txtCantidad.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCantidad.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidad.Location = New System.Drawing.Point(164, 88)
        Me.txtCantidad.MaxLength = 15
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.ShortcutsEnabled = False
        Me.txtCantidad.Size = New System.Drawing.Size(157, 26)
        Me.txtCantidad.TabIndex = 1
        Me.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
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
        Me.cmdCancel.Location = New System.Drawing.Point(220, 310)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(98, 29)
        Me.cmdCancel.TabIndex = 4
        Me.cmdCancel.Text = "Cancelar"
        Me.cmdCancel.UseVisualStyleBackColor = False
        '
        'cmdOk
        '
        Me.cmdOk.BackColor = System.Drawing.Color.Gainsboro
        Me.cmdOk.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdOk.FlatAppearance.BorderSize = 0
        Me.cmdOk.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.cmdOk.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.cmdOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdOk.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOk.Location = New System.Drawing.Point(116, 310)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(98, 29)
        Me.cmdOk.TabIndex = 3
        Me.cmdOk.Text = "OK"
        Me.cmdOk.UseVisualStyleBackColor = False
        '
        'ERP_Inventory_Dialog_Quantity
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CadetBlue
        Me.ClientSize = New System.Drawing.Size(493, 380)
        Me.Controls.Add(Me.GBSearch)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ERP_Inventory_Dialog_Quantity"
        Me.Text = "ERP_Inventory_Dialog_Quantity"
        Me.GBSearch.ResumeLayout(False)
        Me.GBSearch.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
	Friend WithEvents BackgroundWorker2 As System.ComponentModel.BackgroundWorker
	Friend WithEvents GBSearch As GroupBox
	Private WithEvents cmdCancel As Button
	Private WithEvents cmdOk As Button
	Private WithEvents Label1 As Label
	Private WithEvents txtPrecio As TextBox
	Private WithEvents Label2 As Label
	Private WithEvents txtCantidad As TextBox
	Friend WithEvents chkUnitario As CheckBox
	Private WithEvents Label3 As Label
	Friend WithEvents cbUnidad As ComboBox
    Friend WithEvents chkIncluyeIVA As CheckBox
    Private WithEvents Label4 As Label
    Friend WithEvents dtpFechaVencimiento As DateTimePicker
    Private WithEvents Label5 As Label
    Private WithEvents txtProducto As TextBox
End Class
