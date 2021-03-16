<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Mantenimiento_Generic_Taxes
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.comboListCollectingAgency = New System.Windows.Forms.ComboBox()
        Me.txtNameTax = New System.Windows.Forms.TextBox()
        Me.label49 = New System.Windows.Forms.Label()
        Me.txtMontoHacer = New System.Windows.Forms.TextBox()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.GB_TypeTax = New System.Windows.Forms.GroupBox()
        Me.RB_Product = New System.Windows.Forms.RadioButton()
        Me.RB_Line = New System.Windows.Forms.RadioButton()
        Me.rb_Parent = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.GB_TypeTax.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(36, 110)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(168, 25)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Nombre Impuesto:"
        '
        'comboListCollectingAgency
        '
        Me.comboListCollectingAgency.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.comboListCollectingAgency.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.comboListCollectingAgency.BackColor = System.Drawing.Color.Gainsboro
        Me.comboListCollectingAgency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboListCollectingAgency.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.comboListCollectingAgency.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboListCollectingAgency.FormattingEnabled = True
        Me.comboListCollectingAgency.Location = New System.Drawing.Point(222, 69)
        Me.comboListCollectingAgency.Name = "comboListCollectingAgency"
        Me.comboListCollectingAgency.Size = New System.Drawing.Size(258, 29)
        Me.comboListCollectingAgency.TabIndex = 21
        '
        'txtNameTax
        '
        Me.txtNameTax.BackColor = System.Drawing.Color.Gainsboro
        Me.txtNameTax.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNameTax.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNameTax.Location = New System.Drawing.Point(222, 110)
        Me.txtNameTax.MaxLength = 50
        Me.txtNameTax.Name = "txtNameTax"
        Me.txtNameTax.Size = New System.Drawing.Size(256, 26)
        Me.txtNameTax.TabIndex = 26
        '
        'label49
        '
        Me.label49.AutoSize = True
        Me.label49.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.label49.Location = New System.Drawing.Point(27, 69)
        Me.label49.Name = "label49"
        Me.label49.Size = New System.Drawing.Size(183, 25)
        Me.label49.TabIndex = 20
        Me.label49.Text = "Colector Impuestos: "
        '
        'txtMontoHacer
        '
        Me.txtMontoHacer.BackColor = System.Drawing.Color.Gainsboro
        Me.txtMontoHacer.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMontoHacer.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMontoHacer.Location = New System.Drawing.Point(344, 281)
        Me.txtMontoHacer.MaxLength = 5
        Me.txtMontoHacer.Name = "txtMontoHacer"
        Me.txtMontoHacer.Size = New System.Drawing.Size(129, 26)
        Me.txtMontoHacer.TabIndex = 27
        Me.txtMontoHacer.Text = "0"
        Me.txtMontoHacer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cmdSave
        '
        Me.cmdSave.BackColor = System.Drawing.Color.Gainsboro
        Me.cmdSave.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdSave.FlatAppearance.BorderSize = 0
        Me.cmdSave.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.cmdSave.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.cmdSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdSave.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSave.Location = New System.Drawing.Point(271, 327)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(98, 29)
        Me.cmdSave.TabIndex = 29
        Me.cmdSave.Text = "Grabar"
        Me.cmdSave.UseVisualStyleBackColor = False
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
        Me.cmdCancel.Location = New System.Drawing.Point(375, 327)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(98, 29)
        Me.cmdCancel.TabIndex = 30
        Me.cmdCancel.Text = "Cancelar"
        Me.cmdCancel.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Controls.Add(Me.GB_TypeTax)
        Me.GroupBox1.Controls.Add(Me.cmdCancel)
        Me.GroupBox1.Controls.Add(Me.cmdSave)
        Me.GroupBox1.Controls.Add(Me.txtMontoHacer)
        Me.GroupBox1.Controls.Add(Me.label49)
        Me.GroupBox1.Controls.Add(Me.txtNameTax)
        Me.GroupBox1.Controls.Add(Me.comboListCollectingAgency)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 9)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(492, 374)
        Me.GroupBox1.TabIndex = 30
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Configuración Impuestos"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.Label2.Location = New System.Drawing.Point(269, 282)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 25)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Valor: "
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.CheckBox1.Location = New System.Drawing.Point(48, 278)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(143, 29)
        Me.CheckBox1.TabIndex = 32
        Me.CheckBox1.Text = "Es Porcentaje"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'GB_TypeTax
        '
        Me.GB_TypeTax.Controls.Add(Me.RB_Product)
        Me.GB_TypeTax.Controls.Add(Me.RB_Line)
        Me.GB_TypeTax.Controls.Add(Me.rb_Parent)
        Me.GB_TypeTax.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.GB_TypeTax.Location = New System.Drawing.Point(33, 154)
        Me.GB_TypeTax.Name = "GB_TypeTax"
        Me.GB_TypeTax.Size = New System.Drawing.Size(440, 100)
        Me.GB_TypeTax.TabIndex = 31
        Me.GB_TypeTax.TabStop = False
        Me.GB_TypeTax.Text = "Tipo de Impuesto"
        '
        'RB_Product
        '
        Me.RB_Product.AutoSize = True
        Me.RB_Product.Location = New System.Drawing.Point(290, 40)
        Me.RB_Product.Name = "RB_Product"
        Me.RB_Product.Size = New System.Drawing.Size(107, 29)
        Me.RB_Product.TabIndex = 2
        Me.RB_Product.TabStop = True
        Me.RB_Product.Text = "Producto"
        Me.RB_Product.UseVisualStyleBackColor = True
        '
        'RB_Line
        '
        Me.RB_Line.AutoSize = True
        Me.RB_Line.Location = New System.Drawing.Point(170, 40)
        Me.RB_Line.Name = "RB_Line"
        Me.RB_Line.Size = New System.Drawing.Size(75, 29)
        Me.RB_Line.TabIndex = 1
        Me.RB_Line.TabStop = True
        Me.RB_Line.Text = "Linea"
        Me.RB_Line.UseVisualStyleBackColor = True
        '
        'rb_Parent
        '
        Me.rb_Parent.AutoSize = True
        Me.rb_Parent.Location = New System.Drawing.Point(37, 40)
        Me.rb_Parent.Name = "rb_Parent"
        Me.rb_Parent.Size = New System.Drawing.Size(85, 29)
        Me.rb_Parent.TabIndex = 0
        Me.rb_Parent.TabStop = True
        Me.rb_Parent.Text = "Global"
        Me.rb_Parent.UseVisualStyleBackColor = True
        '
        'Mantenimiento_Generic_Taxes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(515, 391)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Mantenimiento_Generic_Taxes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Mantenimiento_Generic_Taxes"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GB_TypeTax.ResumeLayout(False)
        Me.GB_TypeTax.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents Label1 As Label
    Private WithEvents comboListCollectingAgency As ComboBox
    Private WithEvents txtNameTax As TextBox
    Private WithEvents label49 As Label
    Private WithEvents txtMontoHacer As TextBox
    Private WithEvents cmdSave As Button
    Private WithEvents cmdCancel As Button
    Friend WithEvents GroupBox1 As GroupBox
    Private WithEvents Label2 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents GB_TypeTax As GroupBox
    Friend WithEvents RB_Product As RadioButton
    Friend WithEvents RB_Line As RadioButton
    Friend WithEvents rb_Parent As RadioButton
End Class
