<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ERP_Inventory_IngredientsRecipe
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
        Me.GBPrimary = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblUnidad = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtBusqueda = New System.Windows.Forms.TextBox()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.cbProducts = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmdSaveRecipe = New System.Windows.Forms.Button()
        Me.cmdCancelRecipe = New System.Windows.Forms.Button()
        Me.GBPrimary.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GBPrimary
        '
        Me.GBPrimary.BackColor = System.Drawing.SystemColors.Control
        Me.GBPrimary.Controls.Add(Me.GroupBox3)
        Me.GBPrimary.Controls.Add(Me.cmdSaveRecipe)
        Me.GBPrimary.Controls.Add(Me.cmdCancelRecipe)
        Me.GBPrimary.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GBPrimary.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBPrimary.Location = New System.Drawing.Point(12, 12)
        Me.GBPrimary.Name = "GBPrimary"
        Me.GBPrimary.Size = New System.Drawing.Size(781, 262)
        Me.GBPrimary.TabIndex = 2
        Me.GBPrimary.TabStop = False
        Me.GBPrimary.Text = "Agregar Ingredientes Receta"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.lblUnidad)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.txtBusqueda)
        Me.GroupBox3.Controls.Add(Me.txtCantidad)
        Me.GroupBox3.Controls.Add(Me.cbProducts)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(19, 31)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Size = New System.Drawing.Size(741, 182)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Producto"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(415, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 25)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Cantidad:"
        '
        'lblUnidad
        '
        Me.lblUnidad.AutoSize = True
        Me.lblUnidad.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUnidad.Location = New System.Drawing.Point(171, 133)
        Me.lblUnidad.Name = "lblUnidad"
        Me.lblUnidad.Size = New System.Drawing.Size(62, 25)
        Me.lblUnidad.TabIndex = 19
        Me.lblUnidad.Text = "Libras"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 133)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(172, 25)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Unidad de Medida:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(21, 34)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 25)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Buscar:"
        '
        'txtBusqueda
        '
        Me.txtBusqueda.Location = New System.Drawing.Point(99, 31)
        Me.txtBusqueda.Name = "txtBusqueda"
        Me.txtBusqueda.Size = New System.Drawing.Size(637, 33)
        Me.txtBusqueda.TabIndex = 15
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(513, 125)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(214, 33)
        Me.txtCantidad.TabIndex = 14
        '
        'cbProducts
        '
        Me.cbProducts.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbProducts.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbProducts.BackColor = System.Drawing.Color.Gainsboro
        Me.cbProducts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbProducts.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbProducts.FormattingEnabled = True
        Me.cbProducts.Location = New System.Drawing.Point(99, 74)
        Me.cbProducts.Name = "cbProducts"
        Me.cbProducts.Size = New System.Drawing.Size(637, 29)
        Me.cbProducts.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(5, 74)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 25)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Producto:"
        '
        'cmdSaveRecipe
        '
        Me.cmdSaveRecipe.BackColor = System.Drawing.Color.Gainsboro
        Me.cmdSaveRecipe.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdSaveRecipe.FlatAppearance.BorderSize = 0
        Me.cmdSaveRecipe.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.cmdSaveRecipe.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.cmdSaveRecipe.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdSaveRecipe.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSaveRecipe.Location = New System.Drawing.Point(296, 228)
        Me.cmdSaveRecipe.Name = "cmdSaveRecipe"
        Me.cmdSaveRecipe.Size = New System.Drawing.Size(98, 28)
        Me.cmdSaveRecipe.TabIndex = 5
        Me.cmdSaveRecipe.Text = "Guardar"
        Me.cmdSaveRecipe.UseVisualStyleBackColor = False
        '
        'cmdCancelRecipe
        '
        Me.cmdCancelRecipe.BackColor = System.Drawing.Color.Gainsboro
        Me.cmdCancelRecipe.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdCancelRecipe.FlatAppearance.BorderSize = 0
        Me.cmdCancelRecipe.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.cmdCancelRecipe.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.cmdCancelRecipe.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCancelRecipe.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelRecipe.Location = New System.Drawing.Point(400, 228)
        Me.cmdCancelRecipe.Name = "cmdCancelRecipe"
        Me.cmdCancelRecipe.Size = New System.Drawing.Size(98, 28)
        Me.cmdCancelRecipe.TabIndex = 4
        Me.cmdCancelRecipe.Text = "Cancelar"
        Me.cmdCancelRecipe.UseVisualStyleBackColor = False
        '
        'ERP_Inventory_IngredientsRecipe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(801, 286)
        Me.Controls.Add(Me.GBPrimary)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ERP_Inventory_IngredientsRecipe"
        Me.Text = "ERP_Inventory_IngredientsRecipe"
        Me.GBPrimary.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GBPrimary As GroupBox
	Friend WithEvents GroupBox3 As GroupBox
	Private WithEvents Label3 As Label
	Private WithEvents lblUnidad As Label
	Private WithEvents Label1 As Label
	Private WithEvents Label5 As Label
	Friend WithEvents txtBusqueda As TextBox
	Friend WithEvents txtCantidad As TextBox
	Private WithEvents cbProducts As ComboBox
	Private WithEvents Label6 As Label
	Private WithEvents cmdSaveRecipe As Button
	Private WithEvents cmdCancelRecipe As Button
End Class
