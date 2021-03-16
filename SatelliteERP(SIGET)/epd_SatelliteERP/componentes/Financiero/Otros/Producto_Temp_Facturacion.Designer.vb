<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Producto_Temp_Facturacion
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbUnit = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CB_EsGrabado = New System.Windows.Forms.CheckBox()
        Me.txtSaleAmount = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.cmdAceptar = New System.Windows.Forms.Button()
        Me.txtNameProduct = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.cbUnit)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.CB_EsGrabado)
        Me.GroupBox1.Controls.Add(Me.txtSaleAmount)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cmdCancel)
        Me.GroupBox1.Controls.Add(Me.cmdAceptar)
        Me.GroupBox1.Controls.Add(Me.txtNameProduct)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(11, 11)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(492, 335)
        Me.GroupBox1.TabIndex = 31
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Productos Temporales para Facturación"
        '
        'cbUnit
        '
        Me.cbUnit.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbUnit.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbUnit.BackColor = System.Drawing.Color.Gainsboro
        Me.cbUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbUnit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbUnit.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbUnit.FormattingEnabled = True
        Me.cbUnit.Location = New System.Drawing.Point(189, 168)
        Me.cbUnit.Name = "cbUnit"
        Me.cbUnit.Size = New System.Drawing.Size(171, 29)
        Me.cbUnit.TabIndex = 58
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 168)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(177, 25)
        Me.Label3.TabIndex = 59
        Me.Label3.Text = "Unidad de Medida :"
        '
        'CB_EsGrabado
        '
        Me.CB_EsGrabado.AutoSize = True
        Me.CB_EsGrabado.Checked = True
        Me.CB_EsGrabado.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CB_EsGrabado.Location = New System.Drawing.Point(366, 168)
        Me.CB_EsGrabado.Name = "CB_EsGrabado"
        Me.CB_EsGrabado.Size = New System.Drawing.Size(109, 29)
        Me.CB_EsGrabado.TabIndex = 2
        Me.CB_EsGrabado.Text = "Grabado"
        Me.CB_EsGrabado.UseVisualStyleBackColor = True
        '
        'txtSaleAmount
        '
        Me.txtSaleAmount.BackColor = System.Drawing.Color.Gainsboro
        Me.txtSaleAmount.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSaleAmount.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaleAmount.Location = New System.Drawing.Point(305, 215)
        Me.txtSaleAmount.Name = "txtSaleAmount"
        Me.txtSaleAmount.Size = New System.Drawing.Size(170, 26)
        Me.txtSaleAmount.TabIndex = 3
        Me.txtSaleAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(93, 215)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(207, 25)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Precio Unitario Sin IVA:"
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
        Me.cmdCancel.Location = New System.Drawing.Point(376, 261)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(98, 29)
        Me.cmdCancel.TabIndex = 4
        Me.cmdCancel.Text = "Cancelar"
        Me.cmdCancel.UseVisualStyleBackColor = False
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
        Me.cmdAceptar.Location = New System.Drawing.Point(272, 261)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(98, 29)
        Me.cmdAceptar.TabIndex = 4
        Me.cmdAceptar.Text = "Aceptar"
        Me.cmdAceptar.UseVisualStyleBackColor = False
        '
        'txtNameProduct
        '
        Me.txtNameProduct.BackColor = System.Drawing.Color.Gainsboro
        Me.txtNameProduct.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNameProduct.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNameProduct.Location = New System.Drawing.Point(6, 57)
        Me.txtNameProduct.Multiline = True
        Me.txtNameProduct.Name = "txtNameProduct"
        Me.txtNameProduct.Size = New System.Drawing.Size(467, 104)
        Me.txtNameProduct.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(224, 25)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Descripción del Producto"
        '
        'Producto_Temp_Facturacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(514, 358)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Producto_Temp_Facturacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Mantenimiento_Departamentos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Private WithEvents cmdCancel As Button
    Private WithEvents cmdAceptar As Button
    Private WithEvents txtNameProduct As TextBox
    Private WithEvents Label1 As Label
    Private WithEvents txtSaleAmount As TextBox
    Private WithEvents Label2 As Label
    Friend WithEvents CB_EsGrabado As CheckBox
    Private WithEvents cbUnit As ComboBox
    Private WithEvents Label3 As Label
End Class
