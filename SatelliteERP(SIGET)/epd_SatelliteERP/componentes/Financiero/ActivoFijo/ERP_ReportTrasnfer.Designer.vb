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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.cb_ReporteTransferencia = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.cb_ReporteActivoFijo = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.btnLimpieza = New System.Windows.Forms.Button()
        Me.gbFiltros = New System.Windows.Forms.GroupBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.cbOrdenadoPor = New System.Windows.Forms.ComboBox()
        Me.chkFechas = New System.Windows.Forms.CheckBox()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.lstUnida2 = New System.Windows.Forms.ListBox()
        Me.lstUnida1 = New System.Windows.Forms.ListBox()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lstUbicacionSecundaria2 = New System.Windows.Forms.ListBox()
        Me.lstUbicacionSecundaria1 = New System.Windows.Forms.ListBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.lstUbicacionPrimaria2 = New System.Windows.Forms.ListBox()
        Me.lstUbicacionPrimaria1 = New System.Windows.Forms.ListBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.lstSubClasificacion2 = New System.Windows.Forms.ListBox()
        Me.lstSubClasificacion1 = New System.Windows.Forms.ListBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lstClasificacion2 = New System.Windows.Forms.ListBox()
        Me.lstClasificacion1 = New System.Windows.Forms.ListBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.label49 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CB_ContactEmploye = New System.Windows.Forms.ComboBox()
        Me.txtValorAdquisicion = New System.Windows.Forms.TextBox()
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbVidaUtil = New System.Windows.Forms.ComboBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.GroupBox1.SuspendLayout()
        Me.PnProcesando.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.gbFiltros.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.PnProcesando)
        Me.GroupBox1.Controls.Add(Me.TabControl1)
        Me.GroupBox1.Controls.Add(Me.btnLimpieza)
        Me.GroupBox1.Controls.Add(Me.gbFiltros)
        Me.GroupBox1.Controls.Add(Me.cmdCancel)
        Me.GroupBox1.Controls.Add(Me.cmdSave)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cmbVidaUtil)
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
        Me.PnProcesando.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnProcesando.Location = New System.Drawing.Point(2, 21)
        Me.PnProcesando.Name = "PnProcesando"
        Me.PnProcesando.Size = New System.Drawing.Size(1115, 727)
        Me.PnProcesando.TabIndex = 69
        Me.PnProcesando.Visible = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(383, 478)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(298, 25)
        Me.Label14.TabIndex = 69
        Me.Label14.Text = "Espere hasta que la tarea finalice"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(368, 156)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(329, 292)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 68
        Me.PictureBox2.TabStop = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(5, 24)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1076, 102)
        Me.TabControl1.TabIndex = 85
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.cb_ReporteTransferencia)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Location = New System.Drawing.Point(4, 29)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1068, 69)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Reporte de Transferencia"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'cb_ReporteTransferencia
        '
        Me.cb_ReporteTransferencia.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cb_ReporteTransferencia.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cb_ReporteTransferencia.BackColor = System.Drawing.Color.Gainsboro
        Me.cb_ReporteTransferencia.Font = New System.Drawing.Font("Segoe UI", 13.25!)
        Me.cb_ReporteTransferencia.FormattingEnabled = True
        Me.cb_ReporteTransferencia.Items.AddRange(New Object() {"Fecha de Transferencias Activo Fijo", "Por Estado de Activo Fijo", "Ficha Institucional Activo Fijo", "Ficha Clasificacion Activo Fijo", "Ficha Completa Activo Fijo", "Ficha Asignacion Activo Fijo", "Reporte por Clasificacion - Seguros", "Reporte General"})
        Me.cb_ReporteTransferencia.Location = New System.Drawing.Point(168, 18)
        Me.cb_ReporteTransferencia.Name = "cb_ReporteTransferencia"
        Me.cb_ReporteTransferencia.Size = New System.Drawing.Size(891, 33)
        Me.cb_ReporteTransferencia.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 13.25!)
        Me.Label5.Location = New System.Drawing.Point(66, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 25)
        Me.Label5.TabIndex = 61
        Me.Label5.Text = "Reporte:"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.cb_ReporteActivoFijo)
        Me.TabPage2.Controls.Add(Me.Label16)
        Me.TabPage2.Location = New System.Drawing.Point(4, 29)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1068, 69)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Reporte de Activo Fijo"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'cb_ReporteActivoFijo
        '
        Me.cb_ReporteActivoFijo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cb_ReporteActivoFijo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cb_ReporteActivoFijo.BackColor = System.Drawing.Color.Gainsboro
        Me.cb_ReporteActivoFijo.Font = New System.Drawing.Font("Segoe UI", 13.25!)
        Me.cb_ReporteActivoFijo.FormattingEnabled = True
        Me.cb_ReporteActivoFijo.Items.AddRange(New Object() {"Reporte Ficha Resumida Activo", "Historico de Depreciación de Activo", "Reporte Cuadro Depreciación", "Reporte Ficha Transparencia", "Reporte Detalle Bienes Capitalizables", "Reporte Períodico Depreciación Activos", "Reporte Contable Altas y Bajas de Activo", "Reporte Períodico de Altas Activo", "Reporte Períodico de Bajas Activo", "Reporte de Amortización"})
        Me.cb_ReporteActivoFijo.Location = New System.Drawing.Point(140, 15)
        Me.cb_ReporteActivoFijo.Name = "cb_ReporteActivoFijo"
        Me.cb_ReporteActivoFijo.Size = New System.Drawing.Size(891, 33)
        Me.cb_ReporteActivoFijo.TabIndex = 62
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe UI", 13.25!)
        Me.Label16.Location = New System.Drawing.Point(38, 17)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(78, 25)
        Me.Label16.TabIndex = 63
        Me.Label16.Text = "Reporte:"
        '
        'btnLimpieza
        '
        Me.btnLimpieza.BackColor = System.Drawing.Color.Gainsboro
        Me.btnLimpieza.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.btnLimpieza.FlatAppearance.BorderSize = 0
        Me.btnLimpieza.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.btnLimpieza.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.btnLimpieza.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLimpieza.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpieza.Location = New System.Drawing.Point(319, 704)
        Me.btnLimpieza.Name = "btnLimpieza"
        Me.btnLimpieza.Size = New System.Drawing.Size(118, 41)
        Me.btnLimpieza.TabIndex = 84
        Me.btnLimpieza.Text = "Limpiar Filtros"
        Me.btnLimpieza.UseVisualStyleBackColor = False
        '
        'gbFiltros
        '
        Me.gbFiltros.Controls.Add(Me.Label17)
        Me.gbFiltros.Controls.Add(Me.cbOrdenadoPor)
        Me.gbFiltros.Controls.Add(Me.chkFechas)
        Me.gbFiltros.Controls.Add(Me.Button9)
        Me.gbFiltros.Controls.Add(Me.Button10)
        Me.gbFiltros.Controls.Add(Me.lstUnida2)
        Me.gbFiltros.Controls.Add(Me.lstUnida1)
        Me.gbFiltros.Controls.Add(Me.Button7)
        Me.gbFiltros.Controls.Add(Me.Button8)
        Me.gbFiltros.Controls.Add(Me.Label15)
        Me.gbFiltros.Controls.Add(Me.lstUbicacionSecundaria2)
        Me.gbFiltros.Controls.Add(Me.lstUbicacionSecundaria1)
        Me.gbFiltros.Controls.Add(Me.Button5)
        Me.gbFiltros.Controls.Add(Me.PictureBox1)
        Me.gbFiltros.Controls.Add(Me.Button6)
        Me.gbFiltros.Controls.Add(Me.lstUbicacionPrimaria2)
        Me.gbFiltros.Controls.Add(Me.lstUbicacionPrimaria1)
        Me.gbFiltros.Controls.Add(Me.Button3)
        Me.gbFiltros.Controls.Add(Me.Button4)
        Me.gbFiltros.Controls.Add(Me.lstSubClasificacion2)
        Me.gbFiltros.Controls.Add(Me.lstSubClasificacion1)
        Me.gbFiltros.Controls.Add(Me.Button2)
        Me.gbFiltros.Controls.Add(Me.Button1)
        Me.gbFiltros.Controls.Add(Me.lstClasificacion2)
        Me.gbFiltros.Controls.Add(Me.lstClasificacion1)
        Me.gbFiltros.Controls.Add(Me.Label13)
        Me.gbFiltros.Controls.Add(Me.label49)
        Me.gbFiltros.Controls.Add(Me.Label8)
        Me.gbFiltros.Controls.Add(Me.CB_ContactEmploye)
        Me.gbFiltros.Controls.Add(Me.txtValorAdquisicion)
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
        Me.gbFiltros.Controls.Add(Me.Label6)
        Me.gbFiltros.Controls.Add(Me.Label3)
        Me.gbFiltros.Controls.Add(Me.txtNombre)
        Me.gbFiltros.Controls.Add(Me.Label2)
        Me.gbFiltros.Controls.Add(Me.txtCodigo)
        Me.gbFiltros.Controls.Add(Me.Label1)
        Me.gbFiltros.Location = New System.Drawing.Point(22, 126)
        Me.gbFiltros.Name = "gbFiltros"
        Me.gbFiltros.Size = New System.Drawing.Size(1059, 568)
        Me.gbFiltros.TabIndex = 83
        Me.gbFiltros.TabStop = False
        Me.gbFiltros.Text = "Filtros del Reporte"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Segoe UI", 13.25!)
        Me.Label17.Location = New System.Drawing.Point(32, 491)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(112, 25)
        Me.Label17.TabIndex = 133
        Me.Label17.Text = "Ordenar Por:"
        '
        'cbOrdenadoPor
        '
        Me.cbOrdenadoPor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbOrdenadoPor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbOrdenadoPor.BackColor = System.Drawing.Color.Gainsboro
        Me.cbOrdenadoPor.Font = New System.Drawing.Font("Segoe UI", 13.25!)
        Me.cbOrdenadoPor.FormattingEnabled = True
        Me.cbOrdenadoPor.Items.AddRange(New Object() {"Codigo", "Bien", "Clasificación", "Responsable", "Unidad Organizativa", "Marca", "Modelo", "Numero de Serie", "Ubicación Secundaria", "Ubicación Primaria", "Observación"})
        Me.cbOrdenadoPor.Location = New System.Drawing.Point(155, 483)
        Me.cbOrdenadoPor.Name = "cbOrdenadoPor"
        Me.cbOrdenadoPor.Size = New System.Drawing.Size(363, 33)
        Me.cbOrdenadoPor.TabIndex = 132
        '
        'chkFechas
        '
        Me.chkFechas.AutoSize = True
        Me.chkFechas.Location = New System.Drawing.Point(793, 444)
        Me.chkFechas.Name = "chkFechas"
        Me.chkFechas.Size = New System.Drawing.Size(133, 24)
        Me.chkFechas.TabIndex = 131
        Me.chkFechas.Text = "Activar Fechas"
        Me.chkFechas.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(581, 408)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(37, 23)
        Me.Button9.TabIndex = 130
        Me.Button9.Text = "<"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(581, 379)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(37, 23)
        Me.Button10.TabIndex = 129
        Me.Button10.Text = ">"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'lstUnida2
        '
        Me.lstUnida2.FormattingEnabled = True
        Me.lstUnida2.ItemHeight = 20
        Me.lstUnida2.Location = New System.Drawing.Point(624, 373)
        Me.lstUnida2.Name = "lstUnida2"
        Me.lstUnida2.Size = New System.Drawing.Size(423, 64)
        Me.lstUnida2.TabIndex = 128
        '
        'lstUnida1
        '
        Me.lstUnida1.FormattingEnabled = True
        Me.lstUnida1.ItemHeight = 20
        Me.lstUnida1.Location = New System.Drawing.Point(155, 373)
        Me.lstUnida1.Name = "lstUnida1"
        Me.lstUnida1.Size = New System.Drawing.Size(423, 64)
        Me.lstUnida1.TabIndex = 127
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(584, 331)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(37, 23)
        Me.Button7.TabIndex = 125
        Me.Button7.Text = "<"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(584, 302)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(37, 23)
        Me.Button8.TabIndex = 124
        Me.Button8.Text = ">"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.Label15.Location = New System.Drawing.Point(72, 379)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(77, 25)
        Me.Label15.TabIndex = 108
        Me.Label15.Text = "Unidad:"
        '
        'lstUbicacionSecundaria2
        '
        Me.lstUbicacionSecundaria2.FormattingEnabled = True
        Me.lstUbicacionSecundaria2.ItemHeight = 20
        Me.lstUbicacionSecundaria2.Location = New System.Drawing.Point(624, 299)
        Me.lstUbicacionSecundaria2.Name = "lstUbicacionSecundaria2"
        Me.lstUbicacionSecundaria2.Size = New System.Drawing.Size(423, 64)
        Me.lstUbicacionSecundaria2.TabIndex = 123
        '
        'lstUbicacionSecundaria1
        '
        Me.lstUbicacionSecundaria1.FormattingEnabled = True
        Me.lstUbicacionSecundaria1.ItemHeight = 20
        Me.lstUbicacionSecundaria1.Location = New System.Drawing.Point(155, 299)
        Me.lstUbicacionSecundaria1.Name = "lstUbicacionSecundaria1"
        Me.lstUbicacionSecundaria1.Size = New System.Drawing.Size(423, 64)
        Me.lstUbicacionSecundaria1.TabIndex = 122
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(581, 259)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(37, 23)
        Me.Button5.TabIndex = 121
        Me.Button5.Text = "<"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(676, 598)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(46, 29)
        Me.PictureBox1.TabIndex = 84
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(581, 230)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(37, 23)
        Me.Button6.TabIndex = 120
        Me.Button6.Text = ">"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'lstUbicacionPrimaria2
        '
        Me.lstUbicacionPrimaria2.FormattingEnabled = True
        Me.lstUbicacionPrimaria2.ItemHeight = 20
        Me.lstUbicacionPrimaria2.Location = New System.Drawing.Point(624, 222)
        Me.lstUbicacionPrimaria2.Name = "lstUbicacionPrimaria2"
        Me.lstUbicacionPrimaria2.Size = New System.Drawing.Size(423, 64)
        Me.lstUbicacionPrimaria2.TabIndex = 119
        '
        'lstUbicacionPrimaria1
        '
        Me.lstUbicacionPrimaria1.FormattingEnabled = True
        Me.lstUbicacionPrimaria1.ItemHeight = 20
        Me.lstUbicacionPrimaria1.Location = New System.Drawing.Point(155, 222)
        Me.lstUbicacionPrimaria1.Name = "lstUbicacionPrimaria1"
        Me.lstUbicacionPrimaria1.Size = New System.Drawing.Size(423, 64)
        Me.lstUbicacionPrimaria1.TabIndex = 118
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(581, 181)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(37, 23)
        Me.Button3.TabIndex = 117
        Me.Button3.Text = "<"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(581, 152)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(37, 23)
        Me.Button4.TabIndex = 116
        Me.Button4.Text = ">"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'lstSubClasificacion2
        '
        Me.lstSubClasificacion2.FormattingEnabled = True
        Me.lstSubClasificacion2.ItemHeight = 20
        Me.lstSubClasificacion2.Location = New System.Drawing.Point(624, 145)
        Me.lstSubClasificacion2.Name = "lstSubClasificacion2"
        Me.lstSubClasificacion2.Size = New System.Drawing.Size(423, 64)
        Me.lstSubClasificacion2.TabIndex = 115
        '
        'lstSubClasificacion1
        '
        Me.lstSubClasificacion1.FormattingEnabled = True
        Me.lstSubClasificacion1.ItemHeight = 20
        Me.lstSubClasificacion1.Location = New System.Drawing.Point(155, 145)
        Me.lstSubClasificacion1.Name = "lstSubClasificacion1"
        Me.lstSubClasificacion1.Size = New System.Drawing.Size(423, 64)
        Me.lstSubClasificacion1.TabIndex = 114
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(581, 108)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(37, 23)
        Me.Button2.TabIndex = 113
        Me.Button2.Text = "<"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(581, 79)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(37, 23)
        Me.Button1.TabIndex = 112
        Me.Button1.Text = ">"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lstClasificacion2
        '
        Me.lstClasificacion2.FormattingEnabled = True
        Me.lstClasificacion2.ItemHeight = 20
        Me.lstClasificacion2.Location = New System.Drawing.Point(624, 70)
        Me.lstClasificacion2.Name = "lstClasificacion2"
        Me.lstClasificacion2.Size = New System.Drawing.Size(423, 64)
        Me.lstClasificacion2.TabIndex = 111
        '
        'lstClasificacion1
        '
        Me.lstClasificacion1.FormattingEnabled = True
        Me.lstClasificacion1.ItemHeight = 20
        Me.lstClasificacion1.Location = New System.Drawing.Point(155, 70)
        Me.lstClasificacion1.Name = "lstClasificacion1"
        Me.lstClasificacion1.Size = New System.Drawing.Size(423, 64)
        Me.lstClasificacion1.TabIndex = 110
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.Label13.Location = New System.Drawing.Point(52, 234)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(101, 50)
        Me.Label13.TabIndex = 106
        Me.Label13.Text = "Ubicación " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Primaria: "
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'label49
        '
        Me.label49.AutoSize = True
        Me.label49.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.label49.Location = New System.Drawing.Point(43, 298)
        Me.label49.Name = "label49"
        Me.label49.Size = New System.Drawing.Size(110, 50)
        Me.label49.TabIndex = 104
        Me.label49.Text = "Ubicación " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Secundaria:"
        Me.label49.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 13.25!)
        Me.Label8.Location = New System.Drawing.Point(28, 453)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(116, 25)
        Me.Label8.TabIndex = 103
        Me.Label8.Text = "Responsable:"
        '
        'CB_ContactEmploye
        '
        Me.CB_ContactEmploye.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CB_ContactEmploye.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CB_ContactEmploye.BackColor = System.Drawing.Color.Gainsboro
        Me.CB_ContactEmploye.Font = New System.Drawing.Font("Segoe UI", 13.25!)
        Me.CB_ContactEmploye.FormattingEnabled = True
        Me.CB_ContactEmploye.Location = New System.Drawing.Point(155, 444)
        Me.CB_ContactEmploye.Name = "CB_ContactEmploye"
        Me.CB_ContactEmploye.Size = New System.Drawing.Size(363, 33)
        Me.CB_ContactEmploye.TabIndex = 102
        '
        'txtValorAdquisicion
        '
        Me.txtValorAdquisicion.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValorAdquisicion.Location = New System.Drawing.Point(925, 528)
        Me.txtValorAdquisicion.MaxLength = 7
        Me.txtValorAdquisicion.Name = "txtValorAdquisicion"
        Me.txtValorAdquisicion.Size = New System.Drawing.Size(113, 29)
        Me.txtValorAdquisicion.TabIndex = 101
        '
        'txtVidaUtil
        '
        Me.txtVidaUtil.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVidaUtil.Location = New System.Drawing.Point(1047, 579)
        Me.txtVidaUtil.Name = "txtVidaUtil"
        Me.txtVidaUtil.Size = New System.Drawing.Size(47, 29)
        Me.txtVidaUtil.TabIndex = 98
        Me.txtVidaUtil.Visible = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 13.25!)
        Me.Label12.Location = New System.Drawing.Point(544, 471)
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
        Me.dtpFechaDesde.Location = New System.Drawing.Point(673, 467)
        Me.dtpFechaDesde.Margin = New System.Windows.Forms.Padding(2)
        Me.dtpFechaDesde.Name = "dtpFechaDesde"
        Me.dtpFechaDesde.Size = New System.Drawing.Size(115, 29)
        Me.dtpFechaDesde.TabIndex = 96
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 13.25!)
        Me.Label11.Location = New System.Drawing.Point(808, 471)
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
        Me.dtpFechaHasta.Location = New System.Drawing.Point(932, 467)
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
        Me.cmbValorAdquisicion.Location = New System.Drawing.Point(864, 525)
        Me.cmbValorAdquisicion.Name = "cmbValorAdquisicion"
        Me.cmbValorAdquisicion.Size = New System.Drawing.Size(54, 33)
        Me.cmbValorAdquisicion.TabIndex = 93
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(21, 537)
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
        Me.cmbEstado.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbEstado.FormattingEnabled = True
        Me.cmbEstado.Location = New System.Drawing.Point(83, 525)
        Me.cmbEstado.Name = "cmbEstado"
        Me.cmbEstado.Size = New System.Drawing.Size(244, 33)
        Me.cmbEstado.TabIndex = 81
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 13.25!)
        Me.Label10.Location = New System.Drawing.Point(708, 529)
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
        Me.cmbFechaAdquisicion.Location = New System.Drawing.Point(513, 525)
        Me.cmbFechaAdquisicion.Name = "cmbFechaAdquisicion"
        Me.cmbFechaAdquisicion.Size = New System.Drawing.Size(54, 33)
        Me.cmbFechaAdquisicion.TabIndex = 90
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 13.25!)
        Me.Label7.Location = New System.Drawing.Point(32, 152)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(112, 50)
        Me.Label7.TabIndex = 87
        Me.Label7.Text = "Sub" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Clasificación:"
        '
        'dtpFechaAdquisicion
        '
        Me.dtpFechaAdquisicion.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaAdquisicion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaAdquisicion.Location = New System.Drawing.Point(572, 528)
        Me.dtpFechaAdquisicion.Margin = New System.Windows.Forms.Padding(2)
        Me.dtpFechaAdquisicion.Name = "dtpFechaAdquisicion"
        Me.dtpFechaAdquisicion.Size = New System.Drawing.Size(115, 29)
        Me.dtpFechaAdquisicion.TabIndex = 72
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 13.25!)
        Me.Label6.Location = New System.Drawing.Point(36, 91)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(112, 25)
        Me.Label6.TabIndex = 85
        Me.Label6.Text = "Clasificación:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 13.25!)
        Me.Label3.Location = New System.Drawing.Point(352, 533)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(155, 25)
        Me.Label3.TabIndex = 70
        Me.Label3.Text = "Fecha Adquisición"
        '
        'txtNombre
        '
        Me.txtNombre.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(689, 27)
        Me.txtNombre.MaxLength = 200
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(358, 29)
        Me.txtNombre.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(618, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nombre"
        '
        'txtCodigo
        '
        Me.txtCodigo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.Location = New System.Drawing.Point(155, 27)
        Me.txtCodigo.MaxLength = 15
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(423, 29)
        Me.txtCodigo.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(70, 33)
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
        Me.cmdCancel.Location = New System.Drawing.Point(581, 704)
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
        Me.cmdSave.Location = New System.Drawing.Point(454, 704)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(118, 41)
        Me.cmdSave.TabIndex = 1
        Me.cmdSave.Text = "Reporte Trans."
        Me.cmdSave.UseVisualStyleBackColor = False
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
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 13.25!)
        Me.Label4.Location = New System.Drawing.Point(877, 711)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 25)
        Me.Label4.TabIndex = 71
        Me.Label4.Text = "Vida Util"
        Me.Label4.Visible = False
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
        Me.cmbVidaUtil.Location = New System.Drawing.Point(954, 704)
        Me.cmbVidaUtil.Name = "cmbVidaUtil"
        Me.cmbVidaUtil.Size = New System.Drawing.Size(62, 29)
        Me.cmbVidaUtil.TabIndex = 99
        Me.cmbVidaUtil.Visible = False
        '
        'BackgroundWorker1
        '
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
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.gbFiltros.ResumeLayout(False)
        Me.gbFiltros.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Private WithEvents cmdCancel As Button
    Private WithEvents cmdSave As Button
    Private WithEvents Label5 As Label
    Private WithEvents cb_ReporteTransferencia As ComboBox
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
    Private WithEvents Label6 As Label
    Friend WithEvents txtNombre As TextBox
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
    Private WithEvents Label13 As Label
    Private WithEvents label49 As Label
    Private WithEvents Label15 As Label
    Friend WithEvents lstClasificacion1 As ListBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents lstClasificacion2 As ListBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents lstSubClasificacion2 As ListBox
    Friend WithEvents lstSubClasificacion1 As ListBox
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents lstUbicacionPrimaria2 As ListBox
    Friend WithEvents lstUbicacionPrimaria1 As ListBox
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents lstUbicacionSecundaria2 As ListBox
    Friend WithEvents lstUbicacionSecundaria1 As ListBox
    Friend WithEvents Button9 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents lstUnida2 As ListBox
    Friend WithEvents lstUnida1 As ListBox
    Private WithEvents btnLimpieza As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Private WithEvents cb_ReporteActivoFijo As ComboBox
    Private WithEvents Label16 As Label
    Friend WithEvents chkFechas As CheckBox
    Private WithEvents Label17 As Label
    Private WithEvents cbOrdenadoPor As ComboBox
End Class
