<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ERP_Inventory_CreateProduct
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtNombreProducto = New System.Windows.Forms.TextBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.LinkLabel5 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel4 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel3 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.txtNumberPurchase = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmdSiguiente = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.chkUnitMeasure = New System.Windows.Forms.CheckBox()
        Me.cbConversion = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.chkSubProducto = New System.Windows.Forms.CheckBox()
        Me.chkRecipe = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rb_RawMaterial = New System.Windows.Forms.RadioButton()
        Me.rb_Mixed = New System.Windows.Forms.RadioButton()
        Me.rb_FinalProduct = New System.Windows.Forms.RadioButton()
        Me.pbImage = New System.Windows.Forms.PictureBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtPrice_Average = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbMarca = New System.Windows.Forms.ComboBox()
        Me.cbCategory = New System.Windows.Forms.ComboBox()
        Me.cbLine = New System.Windows.Forms.ComboBox()
        Me.cbTipo = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbUnit = New System.Windows.Forms.ComboBox()
        Me.txtPurchasePrice = New System.Windows.Forms.TextBox()
        Me.lblPriceLastPurchase = New System.Windows.Forms.Label()
        Me.txtPriceSale = New System.Windows.Forms.TextBox()
        Me.lblPriceSale = New System.Windows.Forms.Label()
        Me.checkIsExempt = New System.Windows.Forms.CheckBox()
        Me.txtBarCode = New System.Windows.Forms.TextBox()
        Me.lblBarcode = New System.Windows.Forms.Label()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.cbProvider = New System.Windows.Forms.ComboBox()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.pbImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.txtNombreProducto)
        Me.GroupBox1.Controls.Add(Me.lblNombre)
        Me.GroupBox1.Controls.Add(Me.LinkLabel5)
        Me.GroupBox1.Controls.Add(Me.LinkLabel4)
        Me.GroupBox1.Controls.Add(Me.LinkLabel3)
        Me.GroupBox1.Controls.Add(Me.LinkLabel2)
        Me.GroupBox1.Controls.Add(Me.LinkLabel1)
        Me.GroupBox1.Controls.Add(Me.txtNumberPurchase)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.cmdSiguiente)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.chkUnitMeasure)
        Me.GroupBox1.Controls.Add(Me.cbConversion)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.chkSubProducto)
        Me.GroupBox1.Controls.Add(Me.chkRecipe)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.pbImage)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtPrice_Average)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.cbMarca)
        Me.GroupBox1.Controls.Add(Me.cbCategory)
        Me.GroupBox1.Controls.Add(Me.cbLine)
        Me.GroupBox1.Controls.Add(Me.cbTipo)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cbUnit)
        Me.GroupBox1.Controls.Add(Me.txtPurchasePrice)
        Me.GroupBox1.Controls.Add(Me.lblPriceLastPurchase)
        Me.GroupBox1.Controls.Add(Me.txtPriceSale)
        Me.GroupBox1.Controls.Add(Me.lblPriceSale)
        Me.GroupBox1.Controls.Add(Me.checkIsExempt)
        Me.GroupBox1.Controls.Add(Me.txtBarCode)
        Me.GroupBox1.Controls.Add(Me.lblBarcode)
        Me.GroupBox1.Controls.Add(Me.txtDescription)
        Me.GroupBox1.Controls.Add(Me.lblName)
        Me.GroupBox1.Controls.Add(Me.cbProvider)
        Me.GroupBox1.Controls.Add(Me.cmdCancel)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 11)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(970, 574)
        Me.GroupBox1.TabIndex = 34
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Agregar Productos"
        '
        'txtNombreProducto
        '
        Me.txtNombreProducto.BackColor = System.Drawing.Color.Gainsboro
        Me.txtNombreProducto.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNombreProducto.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreProducto.Location = New System.Drawing.Point(149, 75)
        Me.txtNombreProducto.MaxLength = 100
        Me.txtNombreProducto.Name = "txtNombreProducto"
        Me.txtNombreProducto.Size = New System.Drawing.Size(802, 26)
        Me.txtNombreProducto.TabIndex = 2
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(53, 76)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(90, 25)
        Me.lblNombre.TabIndex = 103
        Me.lblNombre.Text = "Nombre :"
        '
        'LinkLabel5
        '
        Me.LinkLabel5.AutoSize = True
        Me.LinkLabel5.Location = New System.Drawing.Point(33, 46)
        Me.LinkLabel5.Name = "LinkLabel5"
        Me.LinkLabel5.Size = New System.Drawing.Size(112, 25)
        Me.LinkLabel5.TabIndex = 101
        Me.LinkLabel5.TabStop = True
        Me.LinkLabel5.Text = "Proveedor:"
        '
        'LinkLabel4
        '
        Me.LinkLabel4.AutoSize = True
        Me.LinkLabel4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel4.Location = New System.Drawing.Point(522, 243)
        Me.LinkLabel4.Name = "LinkLabel4"
        Me.LinkLabel4.Size = New System.Drawing.Size(155, 21)
        Me.LinkLabel4.TabIndex = 100
        Me.LinkLabel4.TabStop = True
        Me.LinkLabel4.Text = "Unidad de Medida:"
        '
        'LinkLabel3
        '
        Me.LinkLabel3.AutoSize = True
        Me.LinkLabel3.Location = New System.Drawing.Point(113, 235)
        Me.LinkLabel3.Name = "LinkLabel3"
        Me.LinkLabel3.Size = New System.Drawing.Size(64, 25)
        Me.LinkLabel3.TabIndex = 99
        Me.LinkLabel3.TabStop = True
        Me.LinkLabel3.Text = "Linea:"
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Location = New System.Drawing.Point(74, 208)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(103, 25)
        Me.LinkLabel2.TabIndex = 98
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Categoria:"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(559, 170)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(72, 25)
        Me.LinkLabel1.TabIndex = 97
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Marca:"
        '
        'txtNumberPurchase
        '
        Me.txtNumberPurchase.BackColor = System.Drawing.Color.Gainsboro
        Me.txtNumberPurchase.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNumberPurchase.Enabled = False
        Me.txtNumberPurchase.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumberPurchase.Location = New System.Drawing.Point(696, 311)
        Me.txtNumberPurchase.MaxLength = 50
        Me.txtNumberPurchase.Name = "txtNumberPurchase"
        Me.txtNumberPurchase.ReadOnly = True
        Me.txtNumberPurchase.Size = New System.Drawing.Size(255, 26)
        Me.txtNumberPurchase.TabIndex = 133
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(505, 309)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(188, 25)
        Me.Label8.TabIndex = 96
        Me.Label8.Text = "Código de Barras Int:"
        '
        'cmdSiguiente
        '
        Me.cmdSiguiente.BackColor = System.Drawing.Color.Gainsboro
        Me.cmdSiguiente.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdSiguiente.FlatAppearance.BorderSize = 0
        Me.cmdSiguiente.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.cmdSiguiente.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.cmdSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdSiguiente.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSiguiente.Location = New System.Drawing.Point(333, 535)
        Me.cmdSiguiente.Name = "cmdSiguiente"
        Me.cmdSiguiente.Size = New System.Drawing.Size(98, 29)
        Me.cmdSiguiente.TabIndex = 20
        Me.cmdSiguiente.Text = "Grabar"
        Me.cmdSiguiente.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(425, 344)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(36, 26)
        Me.Button1.TabIndex = 94
        Me.Button1.Text = "IVA"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'chkUnitMeasure
        '
        Me.chkUnitMeasure.AutoSize = True
        Me.chkUnitMeasure.Location = New System.Drawing.Point(952, 282)
        Me.chkUnitMeasure.Name = "chkUnitMeasure"
        Me.chkUnitMeasure.Size = New System.Drawing.Size(15, 14)
        Me.chkUnitMeasure.TabIndex = 93
        Me.chkUnitMeasure.UseVisualStyleBackColor = True
        '
        'cbConversion
        '
        Me.cbConversion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbConversion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbConversion.BackColor = System.Drawing.Color.Gainsboro
        Me.cbConversion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbConversion.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbConversion.FormattingEnabled = True
        Me.cbConversion.Location = New System.Drawing.Point(695, 274)
        Me.cbConversion.Name = "cbConversion"
        Me.cbConversion.Size = New System.Drawing.Size(254, 29)
        Me.cbConversion.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(509, 274)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(184, 25)
        Me.Label7.TabIndex = 92
        Me.Label7.Text = "Tipo de Conversión :"
        '
        'chkSubProducto
        '
        Me.chkSubProducto.AutoSize = True
        Me.chkSubProducto.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSubProducto.Location = New System.Drawing.Point(248, 429)
        Me.chkSubProducto.Name = "chkSubProducto"
        Me.chkSubProducto.Size = New System.Drawing.Size(140, 29)
        Me.chkSubProducto.TabIndex = 90
        Me.chkSubProducto.Text = "SubProducto"
        Me.chkSubProducto.UseVisualStyleBackColor = True
        Me.chkSubProducto.Visible = False
        '
        'chkRecipe
        '
        Me.chkRecipe.AutoSize = True
        Me.chkRecipe.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkRecipe.Location = New System.Drawing.Point(248, 402)
        Me.chkRecipe.Name = "chkRecipe"
        Me.chkRecipe.Size = New System.Drawing.Size(86, 29)
        Me.chkRecipe.TabIndex = 89
        Me.chkRecipe.Text = "Receta"
        Me.chkRecipe.UseVisualStyleBackColor = True
        Me.chkRecipe.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rb_RawMaterial)
        Me.GroupBox2.Controls.Add(Me.rb_Mixed)
        Me.GroupBox2.Controls.Add(Me.rb_FinalProduct)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(86, 429)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(375, 65)
        Me.GroupBox2.TabIndex = 88
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Tipo de Producto"
        '
        'rb_RawMaterial
        '
        Me.rb_RawMaterial.AutoSize = True
        Me.rb_RawMaterial.Location = New System.Drawing.Point(235, 23)
        Me.rb_RawMaterial.Name = "rb_RawMaterial"
        Me.rb_RawMaterial.Size = New System.Drawing.Size(126, 25)
        Me.rb_RawMaterial.TabIndex = 2
        Me.rb_RawMaterial.TabStop = True
        Me.rb_RawMaterial.Text = "Materia Prima"
        Me.rb_RawMaterial.UseVisualStyleBackColor = True
        '
        'rb_Mixed
        '
        Me.rb_Mixed.AutoSize = True
        Me.rb_Mixed.Location = New System.Drawing.Point(155, 23)
        Me.rb_Mixed.Name = "rb_Mixed"
        Me.rb_Mixed.Size = New System.Drawing.Size(67, 25)
        Me.rb_Mixed.TabIndex = 1
        Me.rb_Mixed.TabStop = True
        Me.rb_Mixed.Text = "Mixto"
        Me.rb_Mixed.UseVisualStyleBackColor = True
        '
        'rb_FinalProduct
        '
        Me.rb_FinalProduct.AutoSize = True
        Me.rb_FinalProduct.Location = New System.Drawing.Point(15, 23)
        Me.rb_FinalProduct.Name = "rb_FinalProduct"
        Me.rb_FinalProduct.Size = New System.Drawing.Size(128, 25)
        Me.rb_FinalProduct.TabIndex = 0
        Me.rb_FinalProduct.TabStop = True
        Me.rb_FinalProduct.Text = "Producto Final"
        Me.rb_FinalProduct.UseVisualStyleBackColor = True
        '
        'pbImage
        '
        Me.pbImage.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.pbImage.Location = New System.Drawing.Point(577, 376)
        Me.pbImage.Name = "pbImage"
        Me.pbImage.Size = New System.Drawing.Size(290, 177)
        Me.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbImage.TabIndex = 87
        Me.pbImage.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(492, 372)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(84, 25)
        Me.Label9.TabIndex = 86
        Me.Label9.Text = "Imagen :"
        '
        'txtPrice_Average
        '
        Me.txtPrice_Average.BackColor = System.Drawing.Color.Gainsboro
        Me.txtPrice_Average.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPrice_Average.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrice_Average.Location = New System.Drawing.Point(248, 314)
        Me.txtPrice_Average.MaxLength = 20
        Me.txtPrice_Average.Name = "txtPrice_Average"
        Me.txtPrice_Average.Size = New System.Drawing.Size(171, 26)
        Me.txtPrice_Average.TabIndex = 12
        Me.txtPrice_Average.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(88, 313)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(159, 25)
        Me.Label6.TabIndex = 81
        Me.Label6.Text = "Precio de Medio :"
        '
        'cbMarca
        '
        Me.cbMarca.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbMarca.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbMarca.BackColor = System.Drawing.Color.Gainsboro
        Me.cbMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbMarca.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMarca.FormattingEnabled = True
        Me.cbMarca.Location = New System.Drawing.Point(632, 170)
        Me.cbMarca.Name = "cbMarca"
        Me.cbMarca.Size = New System.Drawing.Size(317, 29)
        Me.cbMarca.TabIndex = 5
        '
        'cbCategory
        '
        Me.cbCategory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbCategory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbCategory.BackColor = System.Drawing.Color.Gainsboro
        Me.cbCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbCategory.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCategory.FormattingEnabled = True
        Me.cbCategory.Location = New System.Drawing.Point(183, 202)
        Me.cbCategory.Name = "cbCategory"
        Me.cbCategory.Size = New System.Drawing.Size(319, 29)
        Me.cbCategory.TabIndex = 6
        '
        'cbLine
        '
        Me.cbLine.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbLine.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbLine.BackColor = System.Drawing.Color.Gainsboro
        Me.cbLine.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbLine.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbLine.FormattingEnabled = True
        Me.cbLine.Location = New System.Drawing.Point(183, 235)
        Me.cbLine.Name = "cbLine"
        Me.cbLine.Size = New System.Drawing.Size(319, 29)
        Me.cbLine.TabIndex = 8
        '
        'cbTipo
        '
        Me.cbTipo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbTipo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbTipo.BackColor = System.Drawing.Color.Gainsboro
        Me.cbTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbTipo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTipo.FormattingEnabled = True
        Me.cbTipo.Location = New System.Drawing.Point(663, 204)
        Me.cbTipo.Name = "cbTipo"
        Me.cbTipo.Size = New System.Drawing.Size(286, 29)
        Me.cbTipo.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(521, 206)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(140, 25)
        Me.Label2.TabIndex = 67
        Me.Label2.Text = "Tipo Producto :"
        '
        'cbUnit
        '
        Me.cbUnit.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbUnit.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbUnit.BackColor = System.Drawing.Color.Gainsboro
        Me.cbUnit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbUnit.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbUnit.FormattingEnabled = True
        Me.cbUnit.Location = New System.Drawing.Point(695, 239)
        Me.cbUnit.Name = "cbUnit"
        Me.cbUnit.Size = New System.Drawing.Size(254, 29)
        Me.cbUnit.TabIndex = 9
        '
        'txtPurchasePrice
        '
        Me.txtPurchasePrice.BackColor = System.Drawing.Color.Gainsboro
        Me.txtPurchasePrice.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPurchasePrice.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPurchasePrice.Location = New System.Drawing.Point(248, 282)
        Me.txtPurchasePrice.MaxLength = 20
        Me.txtPurchasePrice.Name = "txtPurchasePrice"
        Me.txtPurchasePrice.Size = New System.Drawing.Size(171, 26)
        Me.txtPurchasePrice.TabIndex = 10
        Me.txtPurchasePrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblPriceLastPurchase
        '
        Me.lblPriceLastPurchase.AutoSize = True
        Me.lblPriceLastPurchase.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPriceLastPurchase.Location = New System.Drawing.Point(76, 281)
        Me.lblPriceLastPurchase.Name = "lblPriceLastPurchase"
        Me.lblPriceLastPurchase.Size = New System.Drawing.Size(172, 25)
        Me.lblPriceLastPurchase.TabIndex = 61
        Me.lblPriceLastPurchase.Text = "Precio de Compra :"
        '
        'txtPriceSale
        '
        Me.txtPriceSale.BackColor = System.Drawing.Color.Gainsboro
        Me.txtPriceSale.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPriceSale.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPriceSale.Location = New System.Drawing.Point(248, 344)
        Me.txtPriceSale.MaxLength = 20
        Me.txtPriceSale.Name = "txtPriceSale"
        Me.txtPriceSale.Size = New System.Drawing.Size(171, 26)
        Me.txtPriceSale.TabIndex = 14
        Me.txtPriceSale.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblPriceSale
        '
        Me.lblPriceSale.AutoSize = True
        Me.lblPriceSale.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPriceSale.Location = New System.Drawing.Point(63, 343)
        Me.lblPriceSale.Name = "lblPriceSale"
        Me.lblPriceSale.Size = New System.Drawing.Size(184, 25)
        Me.lblPriceSale.TabIndex = 59
        Me.lblPriceSale.Text = "Precio de Descargo :"
        '
        'checkIsExempt
        '
        Me.checkIsExempt.AutoSize = True
        Me.checkIsExempt.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkIsExempt.Location = New System.Drawing.Point(248, 376)
        Me.checkIsExempt.Name = "checkIsExempt"
        Me.checkIsExempt.Size = New System.Drawing.Size(88, 29)
        Me.checkIsExempt.TabIndex = 18
        Me.checkIsExempt.Text = "Exento"
        Me.checkIsExempt.UseVisualStyleBackColor = True
        Me.checkIsExempt.Visible = False
        '
        'txtBarCode
        '
        Me.txtBarCode.BackColor = System.Drawing.Color.Gainsboro
        Me.txtBarCode.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBarCode.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBarCode.Location = New System.Drawing.Point(183, 173)
        Me.txtBarCode.MaxLength = 30
        Me.txtBarCode.Name = "txtBarCode"
        Me.txtBarCode.Size = New System.Drawing.Size(319, 26)
        Me.txtBarCode.TabIndex = 4
        '
        'lblBarcode
        '
        Me.lblBarcode.AutoSize = True
        Me.lblBarcode.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBarcode.Location = New System.Drawing.Point(11, 170)
        Me.lblBarcode.Name = "lblBarcode"
        Me.lblBarcode.Size = New System.Drawing.Size(166, 25)
        Me.lblBarcode.TabIndex = 54
        Me.lblBarcode.Text = "Código de Barras :"
        '
        'txtDescription
        '
        Me.txtDescription.BackColor = System.Drawing.Color.Gainsboro
        Me.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDescription.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescription.Location = New System.Drawing.Point(151, 110)
        Me.txtDescription.MaxLength = 500
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(802, 54)
        Me.txtDescription.TabIndex = 3
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(27, 111)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(120, 25)
        Me.lblName.TabIndex = 48
        Me.lblName.Text = "Descripción :"
        '
        'cbProvider
        '
        Me.cbProvider.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbProvider.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbProvider.BackColor = System.Drawing.Color.Gainsboro
        Me.cbProvider.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbProvider.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbProvider.FormattingEnabled = True
        Me.cbProvider.Location = New System.Drawing.Point(151, 42)
        Me.cbProvider.Name = "cbProvider"
        Me.cbProvider.Size = New System.Drawing.Size(802, 29)
        Me.cbProvider.TabIndex = 1
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
        Me.cmdCancel.Location = New System.Drawing.Point(437, 537)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(98, 29)
        Me.cmdCancel.TabIndex = 21
        Me.cmdCancel.Text = "Cancelar"
        Me.cmdCancel.UseVisualStyleBackColor = False
        '
        'ERP_Inventory_CreateProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(994, 597)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "ERP_Inventory_CreateProduct"
        Me.Text = "ERP_ConfigurationProducts"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.pbImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Private WithEvents lblName As Label
    Private WithEvents cbProvider As ComboBox
    Private WithEvents cmdCancel As Button
    Private WithEvents cmdSiguiente As Button
    Private WithEvents cbUnit As ComboBox
    Private WithEvents txtPurchasePrice As TextBox
    Private WithEvents lblPriceLastPurchase As Label
    Private WithEvents txtPriceSale As TextBox
    Private WithEvents lblPriceSale As Label
    Friend WithEvents checkIsExempt As CheckBox
    Private WithEvents txtBarCode As TextBox
    Private WithEvents lblBarcode As Label
    Private WithEvents txtDescription As TextBox
    Private WithEvents cbTipo As ComboBox
    Private WithEvents Label2 As Label
    Private WithEvents cbMarca As ComboBox
    Private WithEvents cbCategory As ComboBox
    Private WithEvents cbLine As ComboBox
    Private WithEvents txtPrice_Average As TextBox
    Private WithEvents Label6 As Label
    Friend WithEvents pbImage As PictureBox
    Private WithEvents Label9 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents rb_RawMaterial As RadioButton
    Friend WithEvents rb_Mixed As RadioButton
    Friend WithEvents rb_FinalProduct As RadioButton
    Friend WithEvents chkRecipe As CheckBox
    Friend WithEvents chkSubProducto As CheckBox
    Private WithEvents cbConversion As ComboBox
    Friend WithEvents chkUnitMeasure As CheckBox
    Friend WithEvents Button1 As Button
    Private WithEvents txtNumberPurchase As TextBox
    Private WithEvents Label8 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents LinkLabel3 As LinkLabel
    Friend WithEvents LinkLabel4 As LinkLabel
    Friend WithEvents LinkLabel5 As LinkLabel
    Private WithEvents Label7 As Label
    Private WithEvents txtNombreProducto As TextBox
    Private WithEvents lblNombre As Label
End Class
