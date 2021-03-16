<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Config_Components
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
        Me.cmdPreview = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtY = New System.Windows.Forms.TextBox()
        Me.txtX = New System.Windows.Forms.TextBox()
        Me.CK_Underline = New System.Windows.Forms.CheckBox()
        Me.CK_Italic = New System.Windows.Forms.CheckBox()
        Me.CK_Bold = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CB_Size = New System.Windows.Forms.ComboBox()
        Me.Lbl_Color = New System.Windows.Forms.Label()
        Me.CB_Font = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CB_Aling = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.txtNameTax = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.cmdPreview)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.TxtY)
        Me.GroupBox1.Controls.Add(Me.txtX)
        Me.GroupBox1.Controls.Add(Me.CK_Underline)
        Me.GroupBox1.Controls.Add(Me.CK_Italic)
        Me.GroupBox1.Controls.Add(Me.CK_Bold)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.CB_Size)
        Me.GroupBox1.Controls.Add(Me.Lbl_Color)
        Me.GroupBox1.Controls.Add(Me.CB_Font)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.CB_Aling)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cmdCancel)
        Me.GroupBox1.Controls.Add(Me.cmdSave)
        Me.GroupBox1.Controls.Add(Me.txtNameTax)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(446, 301)
        Me.GroupBox1.TabIndex = 32
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Configuracion Campos"
        '
        'cmdPreview
        '
        Me.cmdPreview.BackColor = System.Drawing.Color.Gainsboro
        Me.cmdPreview.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdPreview.FlatAppearance.BorderSize = 0
        Me.cmdPreview.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.cmdPreview.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.cmdPreview.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdPreview.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPreview.Location = New System.Drawing.Point(88, 266)
        Me.cmdPreview.Name = "cmdPreview"
        Me.cmdPreview.Size = New System.Drawing.Size(98, 29)
        Me.cmdPreview.TabIndex = 47
        Me.cmdPreview.Text = "Preview"
        Me.cmdPreview.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(210, 220)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(27, 25)
        Me.Label8.TabIndex = 46
        Me.Label8.Text = "Y:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(83, 220)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(27, 25)
        Me.Label7.TabIndex = 45
        Me.Label7.Text = "X:"
        '
        'TxtY
        '
        Me.TxtY.Location = New System.Drawing.Point(258, 216)
        Me.TxtY.Name = "TxtY"
        Me.TxtY.Size = New System.Drawing.Size(72, 29)
        Me.TxtY.TabIndex = 44
        '
        'txtX
        '
        Me.txtX.Location = New System.Drawing.Point(116, 216)
        Me.txtX.Name = "txtX"
        Me.txtX.Size = New System.Drawing.Size(71, 29)
        Me.txtX.TabIndex = 43
        '
        'CK_Underline
        '
        Me.CK_Underline.AutoSize = True
        Me.CK_Underline.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.CK_Underline.Location = New System.Drawing.Point(299, 173)
        Me.CK_Underline.Name = "CK_Underline"
        Me.CK_Underline.Size = New System.Drawing.Size(121, 29)
        Me.CK_Underline.TabIndex = 42
        Me.CK_Underline.Text = "Subrallada"
        Me.CK_Underline.UseVisualStyleBackColor = True
        '
        'CK_Italic
        '
        Me.CK_Italic.AutoSize = True
        Me.CK_Italic.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.CK_Italic.Location = New System.Drawing.Point(193, 171)
        Me.CK_Italic.Name = "CK_Italic"
        Me.CK_Italic.Size = New System.Drawing.Size(81, 29)
        Me.CK_Italic.TabIndex = 41
        Me.CK_Italic.Text = "Italica"
        Me.CK_Italic.UseVisualStyleBackColor = True
        '
        'CK_Bold
        '
        Me.CK_Bold.AutoSize = True
        Me.CK_Bold.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.CK_Bold.Location = New System.Drawing.Point(89, 171)
        Me.CK_Bold.Name = "CK_Bold"
        Me.CK_Bold.Size = New System.Drawing.Size(98, 29)
        Me.CK_Bold.TabIndex = 40
        Me.CK_Bold.Text = "Negrilla"
        Me.CK_Bold.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(37, 142)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 25)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "Tamano:"
        '
        'CB_Size
        '
        Me.CB_Size.FormattingEnabled = True
        Me.CB_Size.Items.AddRange(New Object() {"8", "9", "10", "11", "12", "13", "14", "15"})
        Me.CB_Size.Location = New System.Drawing.Point(141, 136)
        Me.CB_Size.Name = "CB_Size"
        Me.CB_Size.Size = New System.Drawing.Size(71, 29)
        Me.CB_Size.TabIndex = 36
        '
        'Lbl_Color
        '
        Me.Lbl_Color.AutoSize = True
        Me.Lbl_Color.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Color.Location = New System.Drawing.Point(295, 66)
        Me.Lbl_Color.Name = "Lbl_Color"
        Me.Lbl_Color.Size = New System.Drawing.Size(58, 25)
        Me.Lbl_Color.TabIndex = 35
        Me.Lbl_Color.Text = "Color"
        '
        'CB_Font
        '
        Me.CB_Font.FormattingEnabled = True
        Me.CB_Font.Items.AddRange(New Object() {"Derecha", "Izquierda", "Centro"})
        Me.CB_Font.Location = New System.Drawing.Point(141, 101)
        Me.CB_Font.Name = "CB_Font"
        Me.CB_Font.Size = New System.Drawing.Size(212, 29)
        Me.CB_Font.TabIndex = 34
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(28, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 25)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Tipo Letra:"
        '
        'CB_Aling
        '
        Me.CB_Aling.FormattingEnabled = True
        Me.CB_Aling.Items.AddRange(New Object() {"Derecha", "Izquierda", "Centro", "Ubicacion Fija"})
        Me.CB_Aling.Location = New System.Drawing.Point(141, 66)
        Me.CB_Aling.Name = "CB_Aling"
        Me.CB_Aling.Size = New System.Drawing.Size(121, 29)
        Me.CB_Aling.TabIndex = 32
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(52, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 25)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Alinear:"
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
        Me.cmdCancel.Location = New System.Drawing.Point(297, 266)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(98, 29)
        Me.cmdCancel.TabIndex = 30
        Me.cmdCancel.Text = "Cancelar"
        Me.cmdCancel.UseVisualStyleBackColor = False
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
        Me.cmdSave.Location = New System.Drawing.Point(193, 266)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(98, 29)
        Me.cmdSave.TabIndex = 29
        Me.cmdSave.Text = "Grabar"
        Me.cmdSave.UseVisualStyleBackColor = False
        '
        'txtNameTax
        '
        Me.txtNameTax.BackColor = System.Drawing.Color.Gainsboro
        Me.txtNameTax.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNameTax.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNameTax.Location = New System.Drawing.Point(141, 29)
        Me.txtNameTax.Name = "txtNameTax"
        Me.txtNameTax.Size = New System.Drawing.Size(228, 26)
        Me.txtNameTax.TabIndex = 26
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 25)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Tipo Control:"
        '
        'Config_Components
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(469, 325)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Config_Components"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Config_Components"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Private WithEvents cmdCancel As Button
    Private WithEvents cmdSave As Button
    Private WithEvents txtNameTax As TextBox
    Private WithEvents Label1 As Label
    Friend WithEvents CB_Font As ComboBox
    Private WithEvents Label3 As Label
    Friend WithEvents CB_Aling As ComboBox
    Private WithEvents Label2 As Label
    Friend WithEvents CK_Bold As CheckBox
    Private WithEvents Label5 As Label
    Friend WithEvents CB_Size As ComboBox
    Private WithEvents Lbl_Color As Label
    Private WithEvents cmdPreview As Button
    Private WithEvents Label8 As Label
    Private WithEvents Label7 As Label
    Friend WithEvents TxtY As TextBox
    Friend WithEvents txtX As TextBox
    Friend WithEvents CK_Underline As CheckBox
    Friend WithEvents CK_Italic As CheckBox
End Class
