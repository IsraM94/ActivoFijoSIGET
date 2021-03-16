<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class createLot
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.PanelDias = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.chkLunes = New System.Windows.Forms.CheckBox()
        Me.chkJueves = New System.Windows.Forms.CheckBox()
        Me.chkMiercoles = New System.Windows.Forms.CheckBox()
        Me.chkDomingo = New System.Windows.Forms.CheckBox()
        Me.chkViernes = New System.Windows.Forms.CheckBox()
        Me.chmMartes = New System.Windows.Forms.CheckBox()
        Me.chkSabado = New System.Windows.Forms.CheckBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Animales = New System.Windows.Forms.TabPage()
        Me.dgvDetails = New System.Windows.Forms.DataGridView()
        Me.MenuOpcion = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.BorrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cbAnimal = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Masivo = New System.Windows.Forms.TabPage()
        Me.txtPesoPromedio = New System.Windows.Forms.TextBox()
        Me.Label_PesoPromedio = New System.Windows.Forms.Label()
        Me.txtCantidadProducto = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtDescripcionProducto = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtIdProducto = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btnContinuar = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbUbicacion = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cbBodega = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.cbFlow = New System.Windows.Forms.ComboBox()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        Me.PanelDias.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.Animales.SuspendLayout()
        CType(Me.dgvDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuOpcion.SuspendLayout()
        Me.Masivo.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(102, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Flujo:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(43, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 24)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Descripción"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox2.Controls.Add(Me.PanelDias)
        Me.GroupBox2.Controls.Add(Me.TabControl1)
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Controls.Add(Me.btnContinuar)
        Me.GroupBox2.Controls.Add(Me.Button5)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(11, 268)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(652, 411)
        Me.GroupBox2.TabIndex = 33
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Lista Animales"
        '
        'PanelDias
        '
        Me.PanelDias.Controls.Add(Me.Label9)
        Me.PanelDias.Controls.Add(Me.chkLunes)
        Me.PanelDias.Controls.Add(Me.chkJueves)
        Me.PanelDias.Controls.Add(Me.chkMiercoles)
        Me.PanelDias.Controls.Add(Me.chkDomingo)
        Me.PanelDias.Controls.Add(Me.chkViernes)
        Me.PanelDias.Controls.Add(Me.chmMartes)
        Me.PanelDias.Controls.Add(Me.chkSabado)
        Me.PanelDias.Location = New System.Drawing.Point(6, 329)
        Me.PanelDias.Name = "PanelDias"
        Me.PanelDias.Size = New System.Drawing.Size(640, 40)
        Me.PanelDias.TabIndex = 55
        Me.PanelDias.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(-2, 11)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(102, 20)
        Me.Label9.TabIndex = 55
        Me.Label9.Text = "Dias Proceso:"
        '
        'chkLunes
        '
        Me.chkLunes.AutoSize = True
        Me.chkLunes.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkLunes.Location = New System.Drawing.Point(101, 11)
        Me.chkLunes.Name = "chkLunes"
        Me.chkLunes.Size = New System.Drawing.Size(60, 21)
        Me.chkLunes.TabIndex = 49
        Me.chkLunes.Text = "Lunes"
        Me.chkLunes.UseVisualStyleBackColor = True
        '
        'chkJueves
        '
        Me.chkJueves.AutoSize = True
        Me.chkJueves.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkJueves.Location = New System.Drawing.Point(333, 11)
        Me.chkJueves.Name = "chkJueves"
        Me.chkJueves.Size = New System.Drawing.Size(65, 21)
        Me.chkJueves.TabIndex = 52
        Me.chkJueves.Text = "Jueves"
        Me.chkJueves.UseVisualStyleBackColor = True
        '
        'chkMiercoles
        '
        Me.chkMiercoles.AutoSize = True
        Me.chkMiercoles.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMiercoles.Location = New System.Drawing.Point(243, 11)
        Me.chkMiercoles.Name = "chkMiercoles"
        Me.chkMiercoles.Size = New System.Drawing.Size(84, 21)
        Me.chkMiercoles.TabIndex = 54
        Me.chkMiercoles.Text = "Miercoles"
        Me.chkMiercoles.UseVisualStyleBackColor = True
        '
        'chkDomingo
        '
        Me.chkDomingo.AutoSize = True
        Me.chkDomingo.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDomingo.Location = New System.Drawing.Point(558, 11)
        Me.chkDomingo.Name = "chkDomingo"
        Me.chkDomingo.Size = New System.Drawing.Size(81, 21)
        Me.chkDomingo.TabIndex = 50
        Me.chkDomingo.Text = "Domingo"
        Me.chkDomingo.UseVisualStyleBackColor = True
        '
        'chkViernes
        '
        Me.chkViernes.AutoSize = True
        Me.chkViernes.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkViernes.Location = New System.Drawing.Point(404, 11)
        Me.chkViernes.Name = "chkViernes"
        Me.chkViernes.Size = New System.Drawing.Size(70, 21)
        Me.chkViernes.TabIndex = 51
        Me.chkViernes.Text = "Viernes"
        Me.chkViernes.UseVisualStyleBackColor = True
        '
        'chmMartes
        '
        Me.chmMartes.AutoSize = True
        Me.chmMartes.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chmMartes.Location = New System.Drawing.Point(169, 11)
        Me.chmMartes.Name = "chmMartes"
        Me.chmMartes.Size = New System.Drawing.Size(68, 21)
        Me.chmMartes.TabIndex = 48
        Me.chmMartes.Text = "Martes"
        Me.chmMartes.UseVisualStyleBackColor = True
        '
        'chkSabado
        '
        Me.chkSabado.AutoSize = True
        Me.chkSabado.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSabado.Location = New System.Drawing.Point(480, 11)
        Me.chkSabado.Name = "chkSabado"
        Me.chkSabado.Size = New System.Drawing.Size(72, 21)
        Me.chkSabado.TabIndex = 53
        Me.chkSabado.Text = "Sabado"
        Me.chkSabado.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.Animales)
        Me.TabControl1.Controls.Add(Me.Masivo)
        Me.TabControl1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(6, 23)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(637, 305)
        Me.TabControl1.TabIndex = 47
        '
        'Animales
        '
        Me.Animales.Controls.Add(Me.dgvDetails)
        Me.Animales.Controls.Add(Me.cbAnimal)
        Me.Animales.Controls.Add(Me.Label4)
        Me.Animales.Controls.Add(Me.btnAdd)
        Me.Animales.Location = New System.Drawing.Point(4, 29)
        Me.Animales.Name = "Animales"
        Me.Animales.Padding = New System.Windows.Forms.Padding(3)
        Me.Animales.Size = New System.Drawing.Size(629, 272)
        Me.Animales.TabIndex = 0
        Me.Animales.UseVisualStyleBackColor = True
        '
        'dgvDetails
        '
        Me.dgvDetails.AllowUserToAddRows = False
        Me.dgvDetails.AllowUserToDeleteRows = False
        Me.dgvDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetails.ContextMenuStrip = Me.MenuOpcion
        Me.dgvDetails.Location = New System.Drawing.Point(3, 47)
        Me.dgvDetails.Name = "dgvDetails"
        Me.dgvDetails.ReadOnly = True
        Me.dgvDetails.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvDetails.RowHeadersVisible = False
        Me.dgvDetails.Size = New System.Drawing.Size(619, 219)
        Me.dgvDetails.TabIndex = 32
        '
        'MenuOpcion
        '
        Me.MenuOpcion.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BorrarToolStripMenuItem})
        Me.MenuOpcion.Name = "MenuOpcion"
        Me.MenuOpcion.Size = New System.Drawing.Size(107, 26)
        '
        'BorrarToolStripMenuItem
        '
        Me.BorrarToolStripMenuItem.Name = "BorrarToolStripMenuItem"
        Me.BorrarToolStripMenuItem.Size = New System.Drawing.Size(106, 22)
        Me.BorrarToolStripMenuItem.Text = "Borrar"
        '
        'cbAnimal
        '
        Me.cbAnimal.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbAnimal.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbAnimal.BackColor = System.Drawing.Color.Gainsboro
        Me.cbAnimal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbAnimal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbAnimal.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbAnimal.FormattingEnabled = True
        Me.cbAnimal.Location = New System.Drawing.Point(71, 10)
        Me.cbAnimal.Name = "cbAnimal"
        Me.cbAnimal.Size = New System.Drawing.Size(447, 29)
        Me.cbAnimal.TabIndex = 46
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(-2, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 25)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Animal:"
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.Gainsboro
        Me.btnAdd.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.btnAdd.FlatAppearance.BorderSize = 0
        Me.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(524, 10)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(98, 29)
        Me.btnAdd.TabIndex = 35
        Me.btnAdd.Text = "Agregar"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'Masivo
        '
        Me.Masivo.Controls.Add(Me.txtPesoPromedio)
        Me.Masivo.Controls.Add(Me.Label_PesoPromedio)
        Me.Masivo.Controls.Add(Me.txtCantidadProducto)
        Me.Masivo.Controls.Add(Me.Label8)
        Me.Masivo.Controls.Add(Me.Label7)
        Me.Masivo.Controls.Add(Me.txtDescripcionProducto)
        Me.Masivo.Controls.Add(Me.Label6)
        Me.Masivo.Controls.Add(Me.txtIdProducto)
        Me.Masivo.Location = New System.Drawing.Point(4, 29)
        Me.Masivo.Name = "Masivo"
        Me.Masivo.Padding = New System.Windows.Forms.Padding(3)
        Me.Masivo.Size = New System.Drawing.Size(629, 272)
        Me.Masivo.TabIndex = 1
        Me.Masivo.UseVisualStyleBackColor = True
        '
        'txtPesoPromedio
        '
        Me.txtPesoPromedio.BackColor = System.Drawing.Color.Gainsboro
        Me.txtPesoPromedio.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPesoPromedio.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPesoPromedio.Location = New System.Drawing.Point(261, 188)
        Me.txtPesoPromedio.MaxLength = 50
        Me.txtPesoPromedio.Multiline = True
        Me.txtPesoPromedio.Name = "txtPesoPromedio"
        Me.txtPesoPromedio.ShortcutsEnabled = False
        Me.txtPesoPromedio.Size = New System.Drawing.Size(285, 35)
        Me.txtPesoPromedio.TabIndex = 55
        Me.txtPesoPromedio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label_PesoPromedio
        '
        Me.Label_PesoPromedio.AutoSize = True
        Me.Label_PesoPromedio.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_PesoPromedio.Location = New System.Drawing.Point(111, 199)
        Me.Label_PesoPromedio.Name = "Label_PesoPromedio"
        Me.Label_PesoPromedio.Size = New System.Drawing.Size(145, 24)
        Me.Label_PesoPromedio.TabIndex = 54
        Me.Label_PesoPromedio.Text = "Peso Promedio:"
        '
        'txtCantidadProducto
        '
        Me.txtCantidadProducto.BackColor = System.Drawing.Color.Gainsboro
        Me.txtCantidadProducto.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCantidadProducto.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidadProducto.Location = New System.Drawing.Point(261, 147)
        Me.txtCantidadProducto.MaxLength = 50
        Me.txtCantidadProducto.Multiline = True
        Me.txtCantidadProducto.Name = "txtCantidadProducto"
        Me.txtCantidadProducto.ShortcutsEnabled = False
        Me.txtCantidadProducto.Size = New System.Drawing.Size(285, 35)
        Me.txtCantidadProducto.TabIndex = 53
        Me.txtCantidadProducto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(89, 158)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(170, 24)
        Me.Label8.TabIndex = 52
        Me.Label8.Text = "Cantidad Producto:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(66, 65)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(196, 24)
        Me.Label7.TabIndex = 51
        Me.Label7.Text = "Descripción Producto:"
        '
        'txtDescripcionProducto
        '
        Me.txtDescripcionProducto.BackColor = System.Drawing.Color.Gainsboro
        Me.txtDescripcionProducto.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDescripcionProducto.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcionProducto.Location = New System.Drawing.Point(262, 64)
        Me.txtDescripcionProducto.MaxLength = 50
        Me.txtDescripcionProducto.Multiline = True
        Me.txtDescripcionProducto.Name = "txtDescripcionProducto"
        Me.txtDescripcionProducto.ReadOnly = True
        Me.txtDescripcionProducto.ShortcutsEnabled = False
        Me.txtDescripcionProducto.Size = New System.Drawing.Size(283, 78)
        Me.txtDescripcionProducto.TabIndex = 50
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(149, 34)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(113, 24)
        Me.Label6.TabIndex = 49
        Me.Label6.Text = "ID Producto:"
        '
        'txtIdProducto
        '
        Me.txtIdProducto.BackColor = System.Drawing.Color.Gainsboro
        Me.txtIdProducto.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtIdProducto.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdProducto.Location = New System.Drawing.Point(262, 23)
        Me.txtIdProducto.MaxLength = 50
        Me.txtIdProducto.Multiline = True
        Me.txtIdProducto.Name = "txtIdProducto"
        Me.txtIdProducto.ReadOnly = True
        Me.txtIdProducto.ShortcutsEnabled = False
        Me.txtIdProducto.Size = New System.Drawing.Size(283, 35)
        Me.txtIdProducto.TabIndex = 48
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Gainsboro
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(377, 376)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(98, 29)
        Me.Button3.TabIndex = 33
        Me.Button3.Text = "Cancelar"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'btnContinuar
        '
        Me.btnContinuar.BackColor = System.Drawing.Color.Gainsboro
        Me.btnContinuar.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.btnContinuar.FlatAppearance.BorderSize = 0
        Me.btnContinuar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.btnContinuar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.btnContinuar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnContinuar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnContinuar.Location = New System.Drawing.Point(169, 376)
        Me.btnContinuar.Name = "btnContinuar"
        Me.btnContinuar.Size = New System.Drawing.Size(98, 29)
        Me.btnContinuar.TabIndex = 31
        Me.btnContinuar.Text = "Continuar"
        Me.btnContinuar.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Gainsboro
        Me.Button5.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.Button5.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(273, 376)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(98, 29)
        Me.Button5.TabIndex = 30
        Me.Button5.Text = "Limpiar"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'dtpDate
        '
        Me.dtpDate.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDate.Location = New System.Drawing.Point(156, 205)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(403, 29)
        Me.dtpDate.TabIndex = 37
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.cbUbicacion)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.cbBodega)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtDescripcion)
        Me.GroupBox1.Controls.Add(Me.cbFlow)
        Me.GroupBox1.Controls.Add(Me.dtpDate)
        Me.GroupBox1.Controls.Add(Me.Button7)
        Me.GroupBox1.Controls.Add(Me.Button8)
        Me.GroupBox1.Controls.Add(Me.Button9)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Button10)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(9, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(654, 254)
        Me.GroupBox1.TabIndex = 38
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Creación de Lote"
        '
        'cbUbicacion
        '
        Me.cbUbicacion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbUbicacion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbUbicacion.BackColor = System.Drawing.Color.Gainsboro
        Me.cbUbicacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbUbicacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbUbicacion.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbUbicacion.FormattingEnabled = True
        Me.cbUbicacion.Location = New System.Drawing.Point(157, 128)
        Me.cbUbicacion.Name = "cbUbicacion"
        Me.cbUbicacion.Size = New System.Drawing.Size(403, 29)
        Me.cbUbicacion.TabIndex = 49
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(51, 129)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(99, 24)
        Me.Label10.TabIndex = 48
        Me.Label10.Text = "Ubicación:"
        '
        'cbBodega
        '
        Me.cbBodega.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbBodega.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbBodega.BackColor = System.Drawing.Color.Gainsboro
        Me.cbBodega.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbBodega.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbBodega.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbBodega.FormattingEnabled = True
        Me.cbBodega.Location = New System.Drawing.Point(156, 164)
        Me.cbBodega.Name = "cbBodega"
        Me.cbBodega.Size = New System.Drawing.Size(403, 29)
        Me.cbBodega.TabIndex = 47
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(69, 164)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 24)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "Bodega:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(81, 208)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 24)
        Me.Label5.TabIndex = 45
        Me.Label5.Text = "Fecha:"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.BackColor = System.Drawing.Color.Gainsboro
        Me.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDescripcion.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.Location = New System.Drawing.Point(156, 71)
        Me.txtDescripcion.MaxLength = 50
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.ShortcutsEnabled = False
        Me.txtDescripcion.Size = New System.Drawing.Size(403, 51)
        Me.txtDescripcion.TabIndex = 36
        '
        'cbFlow
        '
        Me.cbFlow.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbFlow.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbFlow.BackColor = System.Drawing.Color.Gainsboro
        Me.cbFlow.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbFlow.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbFlow.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbFlow.FormattingEnabled = True
        Me.cbFlow.Location = New System.Drawing.Point(156, 32)
        Me.cbFlow.Name = "cbFlow"
        Me.cbFlow.Size = New System.Drawing.Size(403, 29)
        Me.cbFlow.TabIndex = 44
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.Gainsboro
        Me.Button7.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.Button7.FlatAppearance.BorderSize = 0
        Me.Button7.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.Button7.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Location = New System.Drawing.Point(426, 395)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(98, 29)
        Me.Button7.TabIndex = 33
        Me.Button7.Text = "Cancelar"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.Gainsboro
        Me.Button8.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.Button8.FlatAppearance.BorderSize = 0
        Me.Button8.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.Button8.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.Location = New System.Drawing.Point(114, 395)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(98, 29)
        Me.Button8.TabIndex = 31
        Me.Button8.Text = "Continuar"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.Gainsboro
        Me.Button9.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.Button9.FlatAppearance.BorderSize = 0
        Me.Button9.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.Button9.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button9.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.Location = New System.Drawing.Point(322, 395)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(98, 29)
        Me.Button9.TabIndex = 30
        Me.Button9.Text = "Limpiar"
        Me.Button9.UseVisualStyleBackColor = False
        '
        'Button10
        '
        Me.Button10.BackColor = System.Drawing.Color.Gainsboro
        Me.Button10.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.Button10.FlatAppearance.BorderSize = 0
        Me.Button10.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.Button10.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button10.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button10.Location = New System.Drawing.Point(218, 395)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(98, 29)
        Me.Button10.TabIndex = 29
        Me.Button10.Text = "Modificar"
        Me.Button10.UseVisualStyleBackColor = False
        '
        'createLot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(670, 691)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "createLot"
        Me.Text = "Producción - Crear Lotes"
        Me.GroupBox2.ResumeLayout(False)
        Me.PanelDias.ResumeLayout(False)
        Me.PanelDias.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.Animales.ResumeLayout(False)
        Me.Animales.PerformLayout()
        CType(Me.dgvDetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuOpcion.ResumeLayout(False)
        Me.Masivo.ResumeLayout(False)
        Me.Masivo.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents GroupBox2 As GroupBox
	Private WithEvents btnAdd As Button
	Private WithEvents Button3 As Button
	Friend WithEvents dgvDetails As DataGridView
	Private WithEvents btnContinuar As Button
	Private WithEvents Button5 As Button
	Private WithEvents Label4 As Label
	Friend WithEvents dtpDate As DateTimePicker
	Friend WithEvents GroupBox1 As GroupBox
	Private WithEvents Button7 As Button
	Private WithEvents Button8 As Button
	Private WithEvents Button9 As Button
	Private WithEvents Button10 As Button
	Friend WithEvents MenuOpcion As ContextMenuStrip
	Friend WithEvents BorrarToolStripMenuItem As ToolStripMenuItem
	Private WithEvents cbFlow As ComboBox
	Private WithEvents cbAnimal As ComboBox
	Friend WithEvents Label5 As Label
	Private WithEvents txtDescripcion As TextBox
	Private WithEvents cbBodega As ComboBox
	Friend WithEvents Label3 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents Animales As TabPage
    Friend WithEvents Masivo As TabPage
    Private WithEvents txtCantidadProducto As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Private WithEvents txtDescripcionProducto As TextBox
    Friend WithEvents Label6 As Label
    Private WithEvents txtIdProducto As TextBox
    Private WithEvents txtPesoPromedio As TextBox
    Friend WithEvents Label_PesoPromedio As Label
	Friend WithEvents PanelDias As Panel
	Friend WithEvents Label9 As Label
	Friend WithEvents chkLunes As CheckBox
	Friend WithEvents chkJueves As CheckBox
	Friend WithEvents chkMiercoles As CheckBox
	Friend WithEvents chkDomingo As CheckBox
	Friend WithEvents chkViernes As CheckBox
	Friend WithEvents chmMartes As CheckBox
	Friend WithEvents chkSabado As CheckBox
	Private WithEvents cbUbicacion As ComboBox
	Friend WithEvents Label10 As Label
End Class
