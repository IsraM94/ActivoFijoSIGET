<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Financiero_TablaDepreciacionPorProducto
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmdPrinReport = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.lblFechaDepreciacion = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtBalance = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DG_Depreciacion = New System.Windows.Forms.DataGridView()
        Me.DTP_DateFactura = New System.Windows.Forms.DateTimePicker()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.CB_FixedAssetsType = New System.Windows.Forms.ComboBox()
        Me.txtValorResidual = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtValorFactura = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtNameActive = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.txtNumeroActivoFijo = New System.Windows.Forms.TextBox()
        Me.label50 = New System.Windows.Forms.Label()
        Me.label49 = New System.Windows.Forms.Label()
        Me.CB_Depreciation = New System.Windows.Forms.ComboBox()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Imagen = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Correlativo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Name_FiexdAssets = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Date_Acquisition = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Amount_Acquired = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDepreciacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.isaproved = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DG_Depreciacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.cmdPrinReport)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.lblFechaDepreciacion)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtBalance)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Controls.Add(Me.DTP_DateFactura)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.CB_FixedAssetsType)
        Me.GroupBox1.Controls.Add(Me.txtValorResidual)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtValorFactura)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtNameActive)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cmdCancel)
        Me.GroupBox1.Controls.Add(Me.txtNumeroActivoFijo)
        Me.GroupBox1.Controls.Add(Me.label50)
        Me.GroupBox1.Controls.Add(Me.label49)
        Me.GroupBox1.Controls.Add(Me.CB_Depreciation)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(7, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(763, 560)
        Me.GroupBox1.TabIndex = 31
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Activo Fijo"
        '
        'cmdPrinReport
        '
        Me.cmdPrinReport.BackColor = System.Drawing.Color.Gainsboro
        Me.cmdPrinReport.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdPrinReport.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdPrinReport.FlatAppearance.BorderSize = 0
        Me.cmdPrinReport.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.cmdPrinReport.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.cmdPrinReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdPrinReport.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrinReport.Location = New System.Drawing.Point(543, 525)
        Me.cmdPrinReport.Name = "cmdPrinReport"
        Me.cmdPrinReport.Size = New System.Drawing.Size(98, 29)
        Me.cmdPrinReport.TabIndex = 72
        Me.cmdPrinReport.Text = "Imprimir"
        Me.cmdPrinReport.UseVisualStyleBackColor = False
        '
        'ComboBox1
        '
        Me.ComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox1.BackColor = System.Drawing.Color.Gainsboro
        Me.ComboBox1.Enabled = False
        Me.ComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Anual", "Mensual", "Dia"})
        Me.ComboBox1.Location = New System.Drawing.Point(172, 195)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(114, 29)
        Me.ComboBox1.TabIndex = 71
        '
        'lblFechaDepreciacion
        '
        Me.lblFechaDepreciacion.AutoSize = True
        Me.lblFechaDepreciacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaDepreciacion.Location = New System.Drawing.Point(527, 199)
        Me.lblFechaDepreciacion.Name = "lblFechaDepreciacion"
        Me.lblFechaDepreciacion.Size = New System.Drawing.Size(0, 20)
        Me.lblFechaDepreciacion.TabIndex = 70
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(347, 199)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(155, 20)
        Me.Label8.TabIndex = 69
        Me.Label8.Text = "Fecha Depreciación:"
        '
        'txtBalance
        '
        Me.txtBalance.BackColor = System.Drawing.Color.Gainsboro
        Me.txtBalance.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBalance.Enabled = False
        Me.txtBalance.Font = New System.Drawing.Font("Segoe UI", 13.25!)
        Me.txtBalance.Location = New System.Drawing.Point(635, 158)
        Me.txtBalance.Name = "txtBalance"
        Me.txtBalance.ReadOnly = True
        Me.txtBalance.Size = New System.Drawing.Size(114, 24)
        Me.txtBalance.TabIndex = 68
        Me.txtBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(476, 162)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(144, 20)
        Me.Label4.TabIndex = 67
        Me.Label4.Text = "Balance en Libros :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 199)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(144, 20)
        Me.Label3.TabIndex = 65
        Me.Label3.Text = "Tipo Depreciación :"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.DG_Depreciacion)
        Me.Panel1.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.Panel1.Location = New System.Drawing.Point(5, 231)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(748, 289)
        Me.Panel1.TabIndex = 64
        '
        'DG_Depreciacion
        '
        Me.DG_Depreciacion.AllowUserToAddRows = False
        Me.DG_Depreciacion.AllowUserToDeleteRows = False
        Me.DG_Depreciacion.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DG_Depreciacion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DG_Depreciacion.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Imagen, Me.Correlativo, Me.Name_FiexdAssets, Me.Date_Acquisition, Me.Amount_Acquired, Me.FechaDepreciacion, Me.isaproved})
        Me.DG_Depreciacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DG_Depreciacion.EnableHeadersVisualStyles = False
        Me.DG_Depreciacion.Location = New System.Drawing.Point(0, 0)
        Me.DG_Depreciacion.MultiSelect = False
        Me.DG_Depreciacion.Name = "DG_Depreciacion"
        Me.DG_Depreciacion.ReadOnly = True
        Me.DG_Depreciacion.RowHeadersVisible = False
        Me.DG_Depreciacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_Depreciacion.ShowCellErrors = False
        Me.DG_Depreciacion.ShowCellToolTips = False
        Me.DG_Depreciacion.ShowEditingIcon = False
        Me.DG_Depreciacion.ShowRowErrors = False
        Me.DG_Depreciacion.Size = New System.Drawing.Size(748, 289)
        Me.DG_Depreciacion.TabIndex = 63
        '
        'DTP_DateFactura
        '
        Me.DTP_DateFactura.Enabled = False
        Me.DTP_DateFactura.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTP_DateFactura.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTP_DateFactura.Location = New System.Drawing.Point(431, 93)
        Me.DTP_DateFactura.MinDate = New Date(1950, 1, 1, 0, 0, 0, 0)
        Me.DTP_DateFactura.Name = "DTP_DateFactura"
        Me.DTP_DateFactura.Size = New System.Drawing.Size(130, 27)
        Me.DTP_DateFactura.TabIndex = 62
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(57, 160)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(98, 20)
        Me.Label13.TabIndex = 59
        Me.Label13.Text = "Tipo Activo : "
        '
        'CB_FixedAssetsType
        '
        Me.CB_FixedAssetsType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CB_FixedAssetsType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CB_FixedAssetsType.BackColor = System.Drawing.Color.Gainsboro
        Me.CB_FixedAssetsType.Enabled = False
        Me.CB_FixedAssetsType.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CB_FixedAssetsType.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_FixedAssetsType.FormattingEnabled = True
        Me.CB_FixedAssetsType.Location = New System.Drawing.Point(171, 160)
        Me.CB_FixedAssetsType.Name = "CB_FixedAssetsType"
        Me.CB_FixedAssetsType.Size = New System.Drawing.Size(297, 29)
        Me.CB_FixedAssetsType.TabIndex = 60
        '
        'txtValorResidual
        '
        Me.txtValorResidual.BackColor = System.Drawing.Color.Gainsboro
        Me.txtValorResidual.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtValorResidual.Enabled = False
        Me.txtValorResidual.Font = New System.Drawing.Font("Segoe UI", 13.25!)
        Me.txtValorResidual.Location = New System.Drawing.Point(635, 121)
        Me.txtValorResidual.Name = "txtValorResidual"
        Me.txtValorResidual.ReadOnly = True
        Me.txtValorResidual.Size = New System.Drawing.Size(114, 24)
        Me.txtValorResidual.TabIndex = 54
        Me.txtValorResidual.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(501, 125)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 20)
        Me.Label1.TabIndex = 53
        Me.Label1.Text = "Valor Residual :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(312, 97)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(105, 20)
        Me.Label7.TabIndex = 45
        Me.Label7.Text = "Fecha Factura :"
        '
        'txtValorFactura
        '
        Me.txtValorFactura.BackColor = System.Drawing.Color.Gainsboro
        Me.txtValorFactura.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtValorFactura.Enabled = False
        Me.txtValorFactura.Font = New System.Drawing.Font("Segoe UI", 13.25!)
        Me.txtValorFactura.Location = New System.Drawing.Point(174, 93)
        Me.txtValorFactura.Name = "txtValorFactura"
        Me.txtValorFactura.ReadOnly = True
        Me.txtValorFactura.Size = New System.Drawing.Size(123, 24)
        Me.txtValorFactura.TabIndex = 44
        Me.txtValorFactura.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(96, 92)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 20)
        Me.Label6.TabIndex = 43
        Me.Label6.Text = "Valor :"
        '
        'txtNameActive
        '
        Me.txtNameActive.BackColor = System.Drawing.Color.Gainsboro
        Me.txtNameActive.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNameActive.Enabled = False
        Me.txtNameActive.Font = New System.Drawing.Font("Segoe UI", 13.25!)
        Me.txtNameActive.Location = New System.Drawing.Point(173, 62)
        Me.txtNameActive.MaxLength = 200
        Me.txtNameActive.Name = "txtNameActive"
        Me.txtNameActive.ReadOnly = True
        Me.txtNameActive.Size = New System.Drawing.Size(574, 24)
        Me.txtNameActive.TabIndex = 36
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(29, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 20)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Nombre Activo :"
        '
        'cmdCancel
        '
        Me.cmdCancel.BackColor = System.Drawing.Color.Gainsboro
        Me.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancel.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdCancel.FlatAppearance.BorderSize = 0
        Me.cmdCancel.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.cmdCancel.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.cmdCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCancel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancel.Location = New System.Drawing.Point(653, 526)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(98, 29)
        Me.cmdCancel.TabIndex = 30
        Me.cmdCancel.Text = "Cancelar"
        Me.cmdCancel.UseVisualStyleBackColor = False
        '
        'txtNumeroActivoFijo
        '
        Me.txtNumeroActivoFijo.BackColor = System.Drawing.Color.Gainsboro
        Me.txtNumeroActivoFijo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNumeroActivoFijo.Enabled = False
        Me.txtNumeroActivoFijo.Font = New System.Drawing.Font("Segoe UI", 13.25!)
        Me.txtNumeroActivoFijo.Location = New System.Drawing.Point(543, 24)
        Me.txtNumeroActivoFijo.Name = "txtNumeroActivoFijo"
        Me.txtNumeroActivoFijo.Size = New System.Drawing.Size(202, 24)
        Me.txtNumeroActivoFijo.TabIndex = 22
        Me.txtNumeroActivoFijo.Text = "0"
        Me.txtNumeroActivoFijo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'label50
        '
        Me.label50.AutoSize = True
        Me.label50.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label50.Location = New System.Drawing.Point(486, 26)
        Me.label50.Name = "label50"
        Me.label50.Size = New System.Drawing.Size(45, 20)
        Me.label50.TabIndex = 19
        Me.label50.Text = "No.  :"
        '
        'label49
        '
        Me.label49.AutoSize = True
        Me.label49.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label49.Location = New System.Drawing.Point(13, 128)
        Me.label49.Name = "label49"
        Me.label49.Size = New System.Drawing.Size(140, 18)
        Me.label49.TabIndex = 20
        Me.label49.Text = "Tipo Depreciación : "
        '
        'CB_Depreciation
        '
        Me.CB_Depreciation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CB_Depreciation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CB_Depreciation.BackColor = System.Drawing.Color.Gainsboro
        Me.CB_Depreciation.Enabled = False
        Me.CB_Depreciation.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CB_Depreciation.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_Depreciation.FormattingEnabled = True
        Me.CB_Depreciation.Location = New System.Drawing.Point(172, 125)
        Me.CB_Depreciation.Name = "CB_Depreciation"
        Me.CB_Depreciation.Size = New System.Drawing.Size(296, 29)
        Me.CB_Depreciation.TabIndex = 21
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.Frozen = True
        Me.DataGridViewImageColumn1.HeaderText = ""
        Me.DataGridViewImageColumn1.Image = Global.epd_SatelliteERP.My.Resources.Resources.Roja_Bandera
        Me.DataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewImageColumn1.Width = 50
        '
        'Imagen
        '
        Me.Imagen.Frozen = True
        Me.Imagen.HeaderText = ""
        Me.Imagen.Image = Global.epd_SatelliteERP.My.Resources.Resources.Roja_Bandera
        Me.Imagen.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch
        Me.Imagen.Name = "Imagen"
        Me.Imagen.ReadOnly = True
        Me.Imagen.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Imagen.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Imagen.Width = 50
        '
        'Correlativo
        '
        Me.Correlativo.DataPropertyName = "Anio"
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.Correlativo.DefaultCellStyle = DataGridViewCellStyle1
        Me.Correlativo.HeaderText = ""
        Me.Correlativo.Name = "Correlativo"
        Me.Correlativo.ReadOnly = True
        Me.Correlativo.Width = 150
        '
        'Name_FiexdAssets
        '
        Me.Name_FiexdAssets.DataPropertyName = "DepreciacionAnual"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        DataGridViewCellStyle2.Format = "C4"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.Name_FiexdAssets.DefaultCellStyle = DataGridViewCellStyle2
        Me.Name_FiexdAssets.HeaderText = "Cuota Depreciación"
        Me.Name_FiexdAssets.Name = "Name_FiexdAssets"
        Me.Name_FiexdAssets.ReadOnly = True
        Me.Name_FiexdAssets.Width = 180
        '
        'Date_Acquisition
        '
        Me.Date_Acquisition.DataPropertyName = "DepreciacionAcumulada"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        DataGridViewCellStyle3.Format = "C4"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.Date_Acquisition.DefaultCellStyle = DataGridViewCellStyle3
        Me.Date_Acquisition.HeaderText = "Depreciación Acumulada"
        Me.Date_Acquisition.Name = "Date_Acquisition"
        Me.Date_Acquisition.ReadOnly = True
        Me.Date_Acquisition.Width = 181
        '
        'Amount_Acquired
        '
        Me.Amount_Acquired.DataPropertyName = "ValorEnLibros"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        DataGridViewCellStyle4.Format = "C4"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.Amount_Acquired.DefaultCellStyle = DataGridViewCellStyle4
        Me.Amount_Acquired.HeaderText = "Valor Neto en Libros"
        Me.Amount_Acquired.Name = "Amount_Acquired"
        Me.Amount_Acquired.ReadOnly = True
        Me.Amount_Acquired.Width = 185
        '
        'FechaDepreciacion
        '
        Me.FechaDepreciacion.DataPropertyName = "FechaDepreciacion"
        Me.FechaDepreciacion.HeaderText = "Fecha Depreciacion"
        Me.FechaDepreciacion.Name = "FechaDepreciacion"
        Me.FechaDepreciacion.ReadOnly = True
        '
        'isaproved
        '
        Me.isaproved.DataPropertyName = "isaproved"
        Me.isaproved.HeaderText = "Estado"
        Me.isaproved.Name = "isaproved"
        Me.isaproved.ReadOnly = True
        Me.isaproved.Visible = False
        '
        'Financiero_TablaDepreciacionPorProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.CancelButton = Me.cmdCancel
        Me.ClientSize = New System.Drawing.Size(781, 575)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Financiero_TablaDepreciacionPorProducto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Financiero_TablaDepreciacionPorProducto"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.DG_Depreciacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DTP_DateFactura As DateTimePicker
    Private WithEvents Label13 As Label
    Private WithEvents CB_FixedAssetsType As ComboBox
    Private WithEvents txtValorResidual As TextBox
    Private WithEvents Label1 As Label
    Private WithEvents Label7 As Label
    Private WithEvents txtValorFactura As TextBox
    Private WithEvents Label6 As Label
    Private WithEvents txtNameActive As TextBox
    Private WithEvents Label2 As Label
    Private WithEvents cmdCancel As Button
    Private WithEvents txtNumeroActivoFijo As TextBox
    Private WithEvents label50 As Label
    Private WithEvents label49 As Label
    Private WithEvents CB_Depreciation As ComboBox
    Friend WithEvents DG_Depreciacion As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Private WithEvents Label3 As Label
    Private WithEvents lblFechaDepreciacion As Label
    Private WithEvents Label8 As Label
    Private WithEvents txtBalance As TextBox
    Private WithEvents Label4 As Label
    Private WithEvents ComboBox1 As ComboBox
    Private WithEvents cmdPrinReport As Button
    Friend WithEvents Imagen As DataGridViewImageColumn
    Friend WithEvents Correlativo As DataGridViewTextBoxColumn
    Friend WithEvents Name_FiexdAssets As DataGridViewTextBoxColumn
    Friend WithEvents Date_Acquisition As DataGridViewTextBoxColumn
    Friend WithEvents Amount_Acquired As DataGridViewTextBoxColumn
    Friend WithEvents FechaDepreciacion As DataGridViewTextBoxColumn
    Friend WithEvents isaproved As DataGridViewTextBoxColumn
End Class
