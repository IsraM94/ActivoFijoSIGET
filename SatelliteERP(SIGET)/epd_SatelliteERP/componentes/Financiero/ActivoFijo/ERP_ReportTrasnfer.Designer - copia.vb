<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ERP_ReportTrasnfer
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ERP_ReportTrasnfer))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PnProcesando = New System.Windows.Forms.Panel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.gbFiltros = New System.Windows.Forms.GroupBox()
        Me.cmb_Unidad = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cmb_UbicaconSecundaria = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cmb_UbicaconPrimaria = New System.Windows.Forms.ComboBox()
        Me.label49 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CB_ContactEmploye = New System.Windows.Forms.ComboBox()
        Me.txtValorAdquisicion = New System.Windows.Forms.TextBox()
        Me.cmbVidaUtil = New System.Windows.Forms.ComboBox()
        Me.txtVidaUtil = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.dtpFechaDesde = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.dtpFechaHasta = New System.Windows.Forms.DateTimePicker()
        Me.cmbValorAdquisicion = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.cmbEstado = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmbFechaAdquisicion = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dtpFechaAdquisicion = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbSubClasificacion = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.cmbClasificacion = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cb_Reporte = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.lstClasificacion1 = New System.Windows.Forms.ListBox()
        Me.lstClasificacion2 = New System.Windows.Forms.ListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.PnProcesando.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbFiltros.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.PnProcesando)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.gbFiltros)
        Me.GroupBox1.Controls.Add(Me.cmdCancel)
        Me.GroupBox1.Controls.Add(Me.cmdSave)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.cb_Reporte)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(11, 11)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(1119, 750)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Reporte"
        '
        'PnProcesando
        '
        Me.PnProcesando.Controls.Add(Me.Label14)
        Me.PnProcesando.Controls.Add(Me.PictureBox2)
        Me.PnProcesando.Location = New System.Drawing.Point(1087, 86)
        Me.PnProcesando.Name = "PnProcesando"
        Me.PnProcesando.Size = New System.Drawing.Size(738, 612)
        Me.PnProcesando.TabIndex = 69
        Me.PnProcesando.Visible = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(204, 340)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(298, 25)
        Me.Label14.TabIndex = 69
        Me.Label14.Text = "Espere hasta que la tarea finalice"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(189, 18)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(329, 292)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 68
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(649, 461)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(46, 29)
        Me.PictureBox1.TabIndex = 84
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'gbFiltros
        '
        Me.gbFiltros.Controls.Add(Me.Button2)
        Me.gbFiltros.Controls.Add(Me.Button1)
        Me.gbFiltros.Controls.Add(Me.lstClasificacion2)
        Me.gbFiltros.Controls.Add(Me.lstClasificacion1)
        Me.gbFiltros.Controls.Add(Me.cmb_Unidad)
        Me.gbFiltros.Controls.Add(Me.Label15)
        Me.gbFiltros.Controls.Add(Me.cmb_UbicaconSecundaria)
        Me.gbFiltros.Controls.Add(Me.Label13)
        Me.gbFiltros.Controls.Add(Me.cmb_UbicaconPrimaria)
        Me.gbFiltros.Controls.Add(Me.label49)
        Me.gbFiltros.Controls.Add(Me.Label8)
        Me.gbFiltros.Controls.Add(Me.CB_ContactEmploye)
        Me.gbFiltros.Controls.Add(Me.txtValorAdquisicion)
        Me.gbFiltros.Controls.Add(Me.cmbVidaUtil)
        Me.gbFiltros.Controls.Add(Me.txtVidaUtil)
        Me.gbFiltros.Controls.Add(Me.Label12)
        Me.gbFiltros.Controls.Add(Me.dtpFechaDesde)
        Me.gbFiltros.Controls.Add(Me.Label11)
        Me.gbFiltros.Controls.Add(Me.dtpFechaHasta)
        Me.gbFiltros.Controls.Add(Me.cmbValorAdquisicion)
        Me.gbFiltros.Controls.Add(Me.Label19)
        Me.gbFiltros.Controls.Add(Me.cmbEstado)
        Me.gbFiltros.Controls.Add(Me.Label10)
        Me.gbFiltros.Controls.Add(Me.cmbFechaAdquisicion)
        Me.gbFiltros.Controls.Add(Me.Label7)
        Me.gbFiltros.Controls.Add(Me.dtpFechaAdquisicion)
        Me.gbFiltros.Controls.Add(Me.Label4)
        Me.gbFiltros.Controls.Add(Me.cmbSubClasificacion)
        Me.gbFiltros.Controls.Add(Me.Label6)
        Me.gbFiltros.Controls.Add(Me.Label3)
        Me.gbFiltros.Controls.Add(Me.txtNombre)
        Me.gbFiltros.Controls.Add(Me.cmbClasificacion)
        Me.gbFiltros.Controls.Add(Me.Label2)
        Me.gbFiltros.Controls.Add(Me.txtCodigo)
        Me.gbFiltros.Controls.Add(Me.Label1)
        Me.gbFiltros.Location = New System.Drawing.Point(22, 91)
        Me.gbFiltros.Name = "gbFiltros"
        Me.gbFiltros.Size = New System.Drawing.Size(1059, 607)
        Me.gbFiltros.TabIndex = 83
        Me.gbFiltros.TabStop = False
        Me.gbFiltros.Text = "Filtros del Reporte"
        '
        'cmb_Unidad
        '
        Me.cmb_Unidad.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmb_Unidad.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmb_Unidad.BackColor = System.Drawing.Color.Gainsboro
        Me.cmb_Unidad.ForeColor = System.Drawing.SystemColors.MenuText
        Me.cmb_Unidad.FormattingEnabled = True
        Me.cmb_Unidad.Location = New System.Drawing.Point(162, 401)
        Me.cmb_Unidad.Name = "cmb_Unidad"
        Me.cmb_Unidad.Size = New System.Drawing.Size(539, 28)
        Me.cmb_Unidad.TabIndex = 109
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.Label15.Location = New System.Drawing.Point(76, 404)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(77, 25)
        Me.Label15.TabIndex = 108
        Me.Label15.Text = "Unidad:"
        '
        'cmb_UbicaconSecundaria
        '
        Me.cmb_UbicaconSecundaria.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmb_UbicaconSecundaria.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmb_UbicaconSecundaria.BackColor = System.Drawing.Color.Gainsboro
        Me.cmb_UbicaconSecundaria.ForeColor = System.Drawing.SystemColors.MenuText
        Me.cmb_UbicaconSecundaria.FormattingEnabled = True
        Me.cmb_UbicaconSecundaria.Location = New System.Drawing.Point(162, 352)
        Me.cmb_UbicaconSecundaria.Name = "cmb_UbicaconSecundaria"
        Me.cmb_UbicaconSecundaria.Size = New System.Drawing.Size(538, 28)
        Me.cmb_UbicaconSecundaria.TabIndex = 107
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.Label13.Location = New System.Drawing.Point(55, 293)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(101, 50)
        Me.Label13.TabIndex = 106
        Me.Label13.Text = "Ubicación " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Primaria: "
        '
        'cmb_UbicaconPrimaria
        '
        Me.cmb_UbicaconPrimaria.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmb_UbicaconPrimaria.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmb_UbicaconPrimaria.BackColor = System.Drawing.Color.Gainsboro
        Me.cmb_UbicaconPrimaria.ForeColor = System.Drawing.SystemColors.MenuText
        Me.cmb_UbicaconPrimaria.FormattingEnabled = True
        Me.cmb_UbicaconPrimaria.Location = New System.Drawing.Point(162, 304)
        Me.cmb_UbicaconPrimaria.Name = "cmb_UbicaconPrimaria"
        Me.cmb_UbicaconPrimaria.Size = New System.Drawing.Size(538, 28)
        Me.cmb_UbicaconPrimaria.TabIndex = 105
        '
        'label49
        '
        Me.label49.AutoSize = True
        Me.label49.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.label49.Location = New System.Drawing.Point(46, 350)
        Me.label49.Name = "label49"
        Me.label49.Size = New System.Drawing.Size(110, 50)
        Me.label49.TabIndex = 104
        Me.label49.Text = "Ubicación " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Secundaria:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 13.25!)
        Me.Label8.Location = New System.Drawing.Point(27, 438)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(112, 25)
        Me.Label8.TabIndex = 103
        Me.Label8.Text = "Responsable"
        '
        'CB_ContactEmploye
        '
        Me.CB_ContactEmploye.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CB_ContactEmploye.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CB_ContactEmploye.BackColor = System.Drawing.Color.Gainsboro
        Me.CB_ContactEmploye.Font = New System.Drawing.Font("Segoe UI", 13.25!)
        Me.CB_ContactEmploye.FormattingEnabled = True
        Me.CB_ContactEmploye.Location = New System.Drawing.Point(163, 435)
        Me.CB_ContactEmploye.Name = "CB_ContactEmploye"
        Me.CB_ContactEmploye.Size = New System.Drawing.Size(538, 33)
        Me.CB_ContactEmploye.TabIndex = 102
        '
        'txtValorAdquisicion
        '
        Me.txtValorAdquisicion.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValorAdquisicion.Location = New System.Drawing.Point(588, 523)
        Me.txtValorAdquisicion.MaxLength = 7
        Me.txtValorAdquisicion.Name = "txtValorAdquisicion"
        Me.txtValorAdquisicion.Size = New System.Drawing.Size(113, 29)
        Me.txtValorAdquisicion.TabIndex = 101
        '
        'cmbVidaUtil
        '
        Me.cmbVidaUtil.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbVidaUtil.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbVidaUtil.BackColor = System.Drawing.Color.Gainsboro
        Me.cmbVidaUtil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbVidaUtil.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbVidaUtil.FormattingEnabled = True
        Me.cmbVidaUtil.Items.AddRange(New Object() {" ", "=", ">=", "<="})
        Me.cmbVidaUtil.Location = New System.Drawing.Point(163, 516)
        Me.cmbVidaUtil.Name = "cmbVidaUtil"
        Me.cmbVidaUtil.Size = New System.Drawing.Size(62, 29)
        Me.cmbVidaUtil.TabIndex = 99
        Me.cmbVidaUtil.Visible = False
        '
        'txtVidaUtil
        '
        Me.txtVidaUtil.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVidaUtil.Location = New System.Drawing.Point(231, 516)
        Me.txtVidaUtil.Name = "txtVidaUtil"
        Me.txtVidaUtil.Size = New System.Drawing.Size(47, 29)
        Me.txtVidaUtil.TabIndex = 98
        Me.txtVidaUtil.Visible = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 13.25!)
        Me.Label12.Location = New System.Drawing.Point(40, 559)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(110, 25)
        Me.Label12.TabIndex = 97
        Me.Label12.Text = "Fecha desde"
        '
        'dtpFechaDesde
        '
        Me.dtpFechaDesde.Enabled = False
        Me.dtpFechaDesde.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaDesde.Location = New System.Drawing.Point(163, 556)
        Me.dtpFechaDesde.Margin = New System.Windows.Forms.Padding(2)
        Me.dtpFechaDesde.Name = "dtpFechaDesde"
        Me.dtpFechaDesde.Size = New System.Drawing.Size(115, 29)
        Me.dtpFechaDesde.TabIndex = 96
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 13.25!)
        Me.Label11.Location = New System.Drawing.Point(409, 559)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(112, 25)
        Me.Label11.TabIndex = 95
        Me.Label11.Text = "Fecha Hasta "
        '
        'dtpFechaHasta
        '
        Me.dtpFechaHasta.Enabled = False
        Me.dtpFechaHasta.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaHasta.Location = New System.Drawing.Point(527, 556)
        Me.dtpFechaHasta.Margin = New System.Windows.Forms.Padding(2)
        Me.dtpFechaHasta.Name = "dtpFechaHasta"
        Me.dtpFechaHasta.Size = New System.Drawing.Size(115, 29)
        Me.dtpFechaHasta.TabIndex = 94
        '
        'cmbValorAdquisicion
        '
        Me.cmbValorAdquisicion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbValorAdquisicion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbValorAdquisicion.BackColor = System.Drawing.Color.Gainsboro
        Me.cmbValorAdquisicion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbValorAdquisicion.Font = New System.Drawing.Font("Segoe UI", 13.25!)
        Me.cmbValorAdquisicion.FormattingEnabled = True
        Me.cmbValorAdquisicion.Items.AddRange(New Object() {"", " =", ">=", "<="})
        Me.cmbValorAdquisicion.Location = New System.Drawing.Point(527, 520)
        Me.cmbValorAdquisicion.Name = "cmbValorAdquisicion"
        Me.cmbValorAdquisicion.Size = New System.Drawing.Size(54, 33)
        Me.cmbValorAdquisicion.TabIndex = 93
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(94, 474)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(56, 21)
        Me.Label19.TabIndex = 82
        Me.Label19.Text = "Estado"
        '
        'cmbEstado
        '
        Me.cmbEstado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbEstado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbEstado.BackColor = System.Drawing.Color.Gainsboro
        Me.cmbEstado.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbEstado.FormattingEnabled = True
        Me.cmbEstado.Location = New System.Drawing.Point(163, 471)
        Me.cmbEstado.Name = "cmbEstado"
        Me.cmbEstado.Size = New System.Drawing.Size(194, 29)
        Me.cmbEstado.TabIndex = 81
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 13.25!)
        Me.Label10.Location = New System.Drawing.Point(370, 520)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(150, 25)
        Me.Label10.TabIndex = 91
        Me.Label10.Text = "Valor Adquisición"
        '
        'cmbFechaAdquisicion
        '
        Me.cmbFechaAdquisicion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbFechaAdquisicion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbFechaAdquisicion.BackColor = System.Drawing.Color.Gainsboro
        Me.cmbFechaAdquisicion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFechaAdquisicion.Font = New System.Drawing.Font("Segoe UI", 13.25!)
        Me.cmbFechaAdquisicion.FormattingEnabled = True
        Me.cmbFechaAdquisicion.Items.AddRange(New Object() {" ", "=", ">=", "<="})
        Me.cmbFechaAdquisicion.Location = New System.Drawing.Point(527, 474)
        Me.cmbFechaAdquisicion.Name = "cmbFechaAdquisicion"
        Me.cmbFechaAdquisicion.Size = New System.Drawing.Size(54, 33)
        Me.cmbFechaAdquisicion.TabIndex = 90
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 13.25!)
        Me.Label7.Location = New System.Drawing.Point(1, 268)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(146, 25)
        Me.Label7.TabIndex = 87
        Me.Label7.Text = "Sub-Clasificacion"
        '
        'dtpFechaAdquisicion
        '
        Me.dtpFechaAdquisicion.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaAdquisicion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaAdquisicion.Location = New System.Drawing.Point(586, 477)
        Me.dtpFechaAdquisicion.Margin = New System.Windows.Forms.Padding(2)
        Me.dtpFechaAdquisicion.Name = "dtpFechaAdquisicion"
        Me.dtpFechaAdquisicion.Size = New System.Drawing.Size(115, 29)
        Me.dtpFechaAdquisicion.TabIndex = 72
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 13.25!)
        Me.Label4.Location = New System.Drawing.Point(74, 523)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 25)
        Me.Label4.TabIndex = 71
        Me.Label4.Text = "Vida Util"
        Me.Label4.Visible = False
        '
        'cmbSubClasificacion
        '
        Me.cmbSubClasificacion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbSubClasificacion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbSubClasificacion.BackColor = System.Drawing.Color.Gainsboro
        Me.cmbSubClasificacion.Font = New System.Drawing.Font("Segoe UI", 13.25!)
        Me.cmbSubClasificacion.FormattingEnabled = True
        Me.cmbSubClasificacion.Items.AddRange(New Object() {"Fecha de Transferencias", "Por Estado de activo"})
        Me.cmbSubClasificacion.Location = New System.Drawing.Point(158, 265)
        Me.cmbSubClasificacion.Name = "cmbSubClasificacion"
        Me.cmbSubClasificacion.Size = New System.Drawing.Size(538, 33)
        Me.cmbSubClasificacion.TabIndex = 86
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 13.25!)
        Me.Label6.Location = New System.Drawing.Point(39, 100)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(108, 25)
        Me.Label6.TabIndex = 85
        Me.Label6.Text = "Clasificacion"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 13.25!)
        Me.Label3.Location = New System.Drawing.Point(371, 475)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(155, 25)
        Me.Label3.TabIndex = 70
        Me.Label3.Text = "Fecha Adquisición"
        '
        'txtNombre
        '
        Me.txtNombre.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(158, 66)
        Me.txtNombre.MaxLength = 200
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(358, 29)
        Me.txtNombre.TabIndex = 3
        '
        'cmbClasificacion
        '
        Me.cmbClasificacion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbClasificacion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbClasificacion.BackColor = System.Drawing.Color.Gainsboro
        Me.cmbClasificacion.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.cmbClasificacion.Font = New System.Drawing.Font("Segoe UI", 13.25!)
        Me.cmbClasificacion.FormattingEnabled = True
        Me.cmbClasificacion.Items.AddRange(New Object() {"Fecha de Transferencias", "Por Estado de activo"})
        Me.cmbClasificacion.Location = New System.Drawing.Point(159, 226)
        Me.cmbClasificacion.Name = "cmbClasificacion"
        Me.cmbClasificacion.Size = New System.Drawing.Size(538, 32)
        Me.cmbClasificacion.TabIndex = 84
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(73, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nombre"
        '
        'txtCodigo
        '
        Me.txtCodigo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.Location = New System.Drawing.Point(158, 34)
        Me.txtCodigo.MaxLength = 15
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(245, 29)
        Me.txtCodigo.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(73, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Codigo"
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
        Me.cmdCancel.Location = New System.Drawing.Point(376, 704)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(118, 41)
        Me.cmdCancel.TabIndex = 2
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
        Me.cmdSave.Location = New System.Drawing.Point(249, 704)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(118, 41)
        Me.cmdSave.TabIndex = 1
        Me.cmdSave.Text = "Reporte"
        Me.cmdSave.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 13.25!)
        Me.Label5.Location = New System.Drawing.Point(17, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 25)
        Me.Label5.TabIndex = 61
        Me.Label5.Text = "Reporte:"
        '
        'cb_Reporte
        '
        Me.cb_Reporte.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cb_Reporte.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cb_Reporte.BackColor = System.Drawing.Color.Gainsboro
        Me.cb_Reporte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_Reporte.Font = New System.Drawing.Font("Segoe UI", 13.25!)
        Me.cb_Reporte.FormattingEnabled = True
        Me.cb_Reporte.Items.AddRange(New Object() {"Fecha de Transferencias Activo Fijo", "Por Estado de Activo Fijo", "Ficha Institucional Activo Fijo", "Ficha Clasificacion Activo Fijo", "Ficha Completa Activo Fijo", "Ficha Asignacion Activo Fijo", "Reporte por Clasificacion - Seguros", "Reporte General"})
        Me.cb_Reporte.Location = New System.Drawing.Point(119, 30)
        Me.cb_Reporte.Name = "cb_Reporte"
        Me.cb_Reporte.Size = New System.Drawing.Size(606, 33)
        Me.cb_Reporte.TabIndex = 0
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 13.25!)
        Me.Label9.Location = New System.Drawing.Point(-134, 144)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(103, 25)
        Me.Label9.TabIndex = 51
        Me.Label9.Text = "Ubicación : "
        '
        'BackgroundWorker1
        '
        '
        'lstClasificacion1
        '
        Me.lstClasificacion1.FormattingEnabled = True
        Me.lstClasificacion1.ItemHeight = 20
        Me.lstClasificacion1.Location = New System.Drawing.Point(158, 101)
        Me.lstClasificacion1.Name = "lstClasificacion1"
        Me.lstClasificacion1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lstClasificacion1.Size = New System.Drawing.Size(423, 84)
        Me.lstClasificacion1.TabIndex = 110
        '
        'lstClasificacion2
        '
        Me.lstClasificacion2.FormattingEnabled = True
        Me.lstClasificacion2.ItemHeight = 20
        Me.lstClasificacion2.Location = New System.Drawing.Point(627, 101)
        Me.lstClasificacion2.Name = "lstClasificacion2"
        Me.lstClasificacion2.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lstClasificacion2.Size = New System.Drawing.Size(423, 84)
        Me.lstClasificacion2.TabIndex = 111
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(584, 115)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(37, 23)
        Me.Button1.TabIndex = 112
        Me.Button1.Text = ">"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(584, 144)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(37, 23)
        Me.Button2.TabIndex = 113
        Me.Button2.Text = "<"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ERP_ReportTrasnfer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(1141, 772)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ERP_ReportTrasnfer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ERP_ReportTrasnfer"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.PnProcesando.ResumeLayout(False)
        Me.PnProcesando.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbFiltros.ResumeLayout(False)
        Me.gbFiltros.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Private WithEvents cmdCancel As Button
    Private WithEvents cmdSave As Button
    Private WithEvents Label5 As Label
    Private WithEvents cb_Reporte As ComboBox
    Private WithEvents Label9 As Label
    Friend WithEvents dtpFechaAdquisicion As DateTimePicker
    Private WithEvents Label4 As Label
    Private WithEvents Label3 As Label
    Private WithEvents Label19 As Label
    Private WithEvents cmbEstado As ComboBox
    Friend WithEvents gbFiltros As GroupBox
    Private WithEvents cmbVidaUtil As ComboBox
    Friend WithEvents txtVidaUtil As TextBox
    Private WithEvents Label12 As Label
    Friend WithEvents dtpFechaDesde As DateTimePicker
    Private WithEvents Label11 As Label
    Friend WithEvents dtpFechaHasta As DateTimePicker
    Private WithEvents cmbValorAdquisicion As ComboBox
    Private WithEvents Label10 As Label
    Private WithEvents cmbFechaAdquisicion As ComboBox
    Private WithEvents Label7 As Label
    Private WithEvents cmbSubClasificacion As ComboBox
    Private WithEvents Label6 As Label
    Friend WithEvents txtNombre As TextBox
    Private WithEvents cmbClasificacion As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtValorAdquisicion As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Private WithEvents Label8 As Label
    Private WithEvents CB_ContactEmploye As ComboBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents PnProcesando As Panel
    Private WithEvents Label14 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents cmb_UbicaconSecundaria As ComboBox
    Private WithEvents Label13 As Label
    Friend WithEvents cmb_UbicaconPrimaria As ComboBox
    Private WithEvents label49 As Label
    Friend WithEvents cmb_Unidad As ComboBox
    Private WithEvents Label15 As Label
    Friend WithEvents lstClasificacion1 As ListBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents lstClasificacion2 As ListBox
End Class
