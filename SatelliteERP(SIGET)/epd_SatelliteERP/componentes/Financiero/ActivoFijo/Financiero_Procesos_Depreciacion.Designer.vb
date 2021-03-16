<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Financiero_Procesos_Depreciacion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Financiero_Procesos_Depreciacion))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PnAgregarActivos = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnAgregarActivosA = New System.Windows.Forms.Button()
        Me.btnCerrarActivos = New System.Windows.Forms.Button()
        Me.DGBuscarActivos = New System.Windows.Forms.DataGridView()
        Me.PnProcesando = New System.Windows.Forms.Panel()
        Me.lblporcentaje = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.lblTotalAct = New System.Windows.Forms.Label()
        Me.btnTodos = New System.Windows.Forms.Button()
        Me.BtnProcRechazar = New System.Windows.Forms.Button()
        Me.btnVistaPrevia = New System.Windows.Forms.Button()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.BtnProcInformacion = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DTP_DateFactura = New System.Windows.Forms.DateTimePicker()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DGActivosFij = New System.Windows.Forms.DataGridView()
        Me.IdActivo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodigoActivo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreActivo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Amount_Acquired = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Vencimiento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Marca = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Modelo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NuSerie = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnEliminarListado = New System.Windows.Forms.Button()
        Me.btnAgregarActivos = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundWorker2 = New System.ComponentModel.BackgroundWorker()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaVencimiento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Marca1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Modelo1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NoSerie = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        Me.PnAgregarActivos.SuspendLayout()
        CType(Me.DGBuscarActivos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnProcesando.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGActivosFij, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.PnAgregarActivos)
        Me.GroupBox1.Controls.Add(Me.PnProcesando)
        Me.GroupBox1.Controls.Add(Me.btnLimpiar)
        Me.GroupBox1.Controls.Add(Me.lblTotalAct)
        Me.GroupBox1.Controls.Add(Me.btnTodos)
        Me.GroupBox1.Controls.Add(Me.BtnProcRechazar)
        Me.GroupBox1.Controls.Add(Me.btnVistaPrevia)
        Me.GroupBox1.Controls.Add(Me.cmdCancel)
        Me.GroupBox1.Controls.Add(Me.BtnProcInformacion)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.DTP_DateFactura)
        Me.GroupBox1.Controls.Add(Me.txtDescripcion)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.DGActivosFij)
        Me.GroupBox1.Controls.Add(Me.btnEliminarListado)
        Me.GroupBox1.Controls.Add(Me.btnAgregarActivos)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(14, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(644, 672)
        Me.GroupBox1.TabIndex = 69
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Procesar Depreciación Activo Fijo"
        '
        'PnAgregarActivos
        '
        Me.PnAgregarActivos.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.PnAgregarActivos.Controls.Add(Me.Label6)
        Me.PnAgregarActivos.Controls.Add(Me.btnAgregarActivosA)
        Me.PnAgregarActivos.Controls.Add(Me.btnCerrarActivos)
        Me.PnAgregarActivos.Controls.Add(Me.DGBuscarActivos)
        Me.PnAgregarActivos.Location = New System.Drawing.Point(0, 0)
        Me.PnAgregarActivos.Name = "PnAgregarActivos"
        Me.PnAgregarActivos.Size = New System.Drawing.Size(644, 672)
        Me.PnAgregarActivos.TabIndex = 76
        Me.PnAgregarActivos.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(174, 472)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(290, 50)
        Me.Label6.TabIndex = 79
        Me.Label6.Text = "Seleccione los Activos Fijos" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "para generar la Depreciación"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnAgregarActivosA
        '
        Me.btnAgregarActivosA.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarActivosA.Location = New System.Drawing.Point(200, 411)
        Me.btnAgregarActivosA.Name = "btnAgregarActivosA"
        Me.btnAgregarActivosA.Size = New System.Drawing.Size(129, 31)
        Me.btnAgregarActivosA.TabIndex = 78
        Me.btnAgregarActivosA.Text = "Agregar Activos"
        Me.btnAgregarActivosA.UseVisualStyleBackColor = True
        '
        'btnCerrarActivos
        '
        Me.btnCerrarActivos.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrarActivos.Location = New System.Drawing.Point(335, 411)
        Me.btnCerrarActivos.Name = "btnCerrarActivos"
        Me.btnCerrarActivos.Size = New System.Drawing.Size(129, 31)
        Me.btnCerrarActivos.TabIndex = 77
        Me.btnCerrarActivos.Text = "Cerrar"
        Me.btnCerrarActivos.UseVisualStyleBackColor = True
        '
        'DGBuscarActivos
        '
        Me.DGBuscarActivos.AllowUserToAddRows = False
        Me.DGBuscarActivos.AllowUserToDeleteRows = False
        Me.DGBuscarActivos.AllowUserToOrderColumns = True
        Me.DGBuscarActivos.AllowUserToResizeColumns = False
        Me.DGBuscarActivos.AllowUserToResizeRows = False
        Me.DGBuscarActivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGBuscarActivos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.FechaVencimiento, Me.Marca1, Me.Modelo1, Me.NoSerie})
        Me.DGBuscarActivos.Location = New System.Drawing.Point(5, 14)
        Me.DGBuscarActivos.Name = "DGBuscarActivos"
        Me.DGBuscarActivos.RowHeadersVisible = False
        Me.DGBuscarActivos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGBuscarActivos.Size = New System.Drawing.Size(624, 374)
        Me.DGBuscarActivos.TabIndex = 76
        '
        'PnProcesando
        '
        Me.PnProcesando.Controls.Add(Me.lblporcentaje)
        Me.PnProcesando.Controls.Add(Me.Label3)
        Me.PnProcesando.Controls.Add(Me.Label2)
        Me.PnProcesando.Controls.Add(Me.PictureBox1)
        Me.PnProcesando.Location = New System.Drawing.Point(26, 41)
        Me.PnProcesando.Name = "PnProcesando"
        Me.PnProcesando.Size = New System.Drawing.Size(581, 235)
        Me.PnProcesando.TabIndex = 69
        Me.PnProcesando.Visible = False
        '
        'lblporcentaje
        '
        Me.lblporcentaje.AutoSize = True
        Me.lblporcentaje.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblporcentaje.Location = New System.Drawing.Point(347, 180)
        Me.lblporcentaje.Name = "lblporcentaje"
        Me.lblporcentaje.Size = New System.Drawing.Size(0, 25)
        Me.lblporcentaje.TabIndex = 72
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(133, 171)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(189, 25)
        Me.Label3.TabIndex = 71
        Me.Label3.Text = "Avance del Proceso:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(133, 201)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(326, 25)
        Me.Label2.TabIndex = 69
        Me.Label2.Text = "Espere hasta que la Tarea se Finalice"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(212, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(164, 162)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 68
        Me.PictureBox1.TabStop = False
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiar.Location = New System.Drawing.Point(33, 242)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(129, 31)
        Me.btnLimpiar.TabIndex = 81
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'lblTotalAct
        '
        Me.lblTotalAct.AutoSize = True
        Me.lblTotalAct.Location = New System.Drawing.Point(522, 577)
        Me.lblTotalAct.Name = "lblTotalAct"
        Me.lblTotalAct.Size = New System.Drawing.Size(0, 25)
        Me.lblTotalAct.TabIndex = 80
        '
        'btnTodos
        '
        Me.btnTodos.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTodos.Location = New System.Drawing.Point(450, 242)
        Me.btnTodos.Name = "btnTodos"
        Me.btnTodos.Size = New System.Drawing.Size(152, 31)
        Me.btnTodos.TabIndex = 78
        Me.btnTodos.Text = "Todos los Activos"
        Me.btnTodos.UseVisualStyleBackColor = True
        '
        'BtnProcRechazar
        '
        Me.BtnProcRechazar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnProcRechazar.Location = New System.Drawing.Point(195, 625)
        Me.BtnProcRechazar.Name = "BtnProcRechazar"
        Me.BtnProcRechazar.Size = New System.Drawing.Size(109, 31)
        Me.BtnProcRechazar.TabIndex = 74
        Me.BtnProcRechazar.Text = "Rechazar"
        Me.BtnProcRechazar.UseVisualStyleBackColor = True
        '
        'btnVistaPrevia
        '
        Me.btnVistaPrevia.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVistaPrevia.Location = New System.Drawing.Point(46, 624)
        Me.btnVistaPrevia.Name = "btnVistaPrevia"
        Me.btnVistaPrevia.Size = New System.Drawing.Size(129, 31)
        Me.btnVistaPrevia.TabIndex = 73
        Me.btnVistaPrevia.Text = "Vista Previa"
        Me.btnVistaPrevia.UseVisualStyleBackColor = True
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
        Me.cmdCancel.Location = New System.Drawing.Point(453, 625)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(98, 29)
        Me.cmdCancel.TabIndex = 72
        Me.cmdCancel.Text = "Cerrar"
        Me.cmdCancel.UseVisualStyleBackColor = False
        '
        'BtnProcInformacion
        '
        Me.BtnProcInformacion.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnProcInformacion.Location = New System.Drawing.Point(321, 625)
        Me.BtnProcInformacion.Name = "BtnProcInformacion"
        Me.BtnProcInformacion.Size = New System.Drawing.Size(112, 31)
        Me.BtnProcInformacion.TabIndex = 71
        Me.BtnProcInformacion.Text = "Procesar"
        Me.BtnProcInformacion.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(206, 38)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(235, 20)
        Me.Label7.TabIndex = 63
        Me.Label7.Text = "Seleccione la Fecha Depreciación"
        '
        'DTP_DateFactura
        '
        Me.DTP_DateFactura.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTP_DateFactura.Location = New System.Drawing.Point(168, 61)
        Me.DTP_DateFactura.MinDate = New Date(1950, 1, 1, 0, 0, 0, 0)
        Me.DTP_DateFactura.Name = "DTP_DateFactura"
        Me.DTP_DateFactura.Size = New System.Drawing.Size(288, 27)
        Me.DTP_DateFactura.TabIndex = 64
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(118, 128)
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(434, 106)
        Me.txtDescripcion.TabIndex = 66
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(245, 105)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(174, 20)
        Me.Label1.TabIndex = 65
        Me.Label1.Text = "Descripción del Proceso"
        '
        'DGActivosFij
        '
        Me.DGActivosFij.AllowUserToAddRows = False
        Me.DGActivosFij.AllowUserToDeleteRows = False
        Me.DGActivosFij.AllowUserToOrderColumns = True
        Me.DGActivosFij.AllowUserToResizeColumns = False
        Me.DGActivosFij.AllowUserToResizeRows = False
        Me.DGActivosFij.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGActivosFij.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdActivo, Me.CodigoActivo, Me.NombreActivo, Me.Amount_Acquired, Me.Vencimiento, Me.Marca, Me.Modelo, Me.NuSerie})
        Me.DGActivosFij.Location = New System.Drawing.Point(7, 289)
        Me.DGActivosFij.Name = "DGActivosFij"
        Me.DGActivosFij.ReadOnly = True
        Me.DGActivosFij.RowHeadersVisible = False
        Me.DGActivosFij.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGActivosFij.Size = New System.Drawing.Size(631, 276)
        Me.DGActivosFij.TabIndex = 75
        '
        'IdActivo
        '
        Me.IdActivo.HeaderText = "IdActivo"
        Me.IdActivo.Name = "IdActivo"
        Me.IdActivo.ReadOnly = True
        Me.IdActivo.Visible = False
        Me.IdActivo.Width = 150
        '
        'CodigoActivo
        '
        Me.CodigoActivo.HeaderText = "Código"
        Me.CodigoActivo.Name = "CodigoActivo"
        Me.CodigoActivo.ReadOnly = True
        Me.CodigoActivo.Width = 140
        '
        'NombreActivo
        '
        Me.NombreActivo.HeaderText = "NombreActivo"
        Me.NombreActivo.Name = "NombreActivo"
        Me.NombreActivo.ReadOnly = True
        Me.NombreActivo.Width = 250
        '
        'Amount_Acquired
        '
        Me.Amount_Acquired.HeaderText = "Monto Adquisición"
        Me.Amount_Acquired.Name = "Amount_Acquired"
        Me.Amount_Acquired.ReadOnly = True
        '
        'Vencimiento
        '
        Me.Vencimiento.DataPropertyName = "FechaMaxDepreciacion"
        Me.Vencimiento.HeaderText = "Depreciación Final"
        Me.Vencimiento.Name = "Vencimiento"
        Me.Vencimiento.ReadOnly = True
        '
        'Marca
        '
        Me.Marca.DataPropertyName = "marca"
        Me.Marca.HeaderText = "Marca"
        Me.Marca.Name = "Marca"
        Me.Marca.ReadOnly = True
        Me.Marca.Width = 150
        '
        'Modelo
        '
        Me.Modelo.DataPropertyName = "modelo"
        Me.Modelo.HeaderText = "Modelo"
        Me.Modelo.Name = "Modelo"
        Me.Modelo.ReadOnly = True
        Me.Modelo.Width = 150
        '
        'NuSerie
        '
        Me.NuSerie.DataPropertyName = "Numero_Serie"
        Me.NuSerie.HeaderText = "Número Serie"
        Me.NuSerie.Name = "NuSerie"
        Me.NuSerie.ReadOnly = True
        Me.NuSerie.Width = 150
        '
        'btnEliminarListado
        '
        Me.btnEliminarListado.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarListado.Location = New System.Drawing.Point(168, 242)
        Me.btnEliminarListado.Name = "btnEliminarListado"
        Me.btnEliminarListado.Size = New System.Drawing.Size(129, 31)
        Me.btnEliminarListado.TabIndex = 77
        Me.btnEliminarListado.Text = "Eliminar Activo"
        Me.btnEliminarListado.UseVisualStyleBackColor = True
        '
        'btnAgregarActivos
        '
        Me.btnAgregarActivos.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarActivos.Location = New System.Drawing.Point(306, 242)
        Me.btnAgregarActivos.Name = "btnAgregarActivos"
        Me.btnAgregarActivos.Size = New System.Drawing.Size(129, 31)
        Me.btnAgregarActivos.TabIndex = 76
        Me.btnAgregarActivos.Text = "Buscar Activos"
        Me.btnAgregarActivos.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(353, 577)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(178, 25)
        Me.Label4.TabIndex = 79
        Me.Label4.Text = "Total de Activos: "
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerReportsProgress = True
        Me.BackgroundWorker1.WorkerSupportsCancellation = True
        '
        'BackgroundWorker2
        '
        Me.BackgroundWorker2.WorkerReportsProgress = True
        Me.BackgroundWorker2.WorkerSupportsCancellation = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID_FixedAssets"
        Me.DataGridViewTextBoxColumn1.HeaderText = "IdActivo"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Visible = False
        Me.DataGridViewTextBoxColumn1.Width = 150
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Number_Purchase"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Código"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 140
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Name_FiexdAssets"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Nombre Activo"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 250
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Amount_Acquired"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Monto Adquisición"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 125
        '
        'FechaVencimiento
        '
        Me.FechaVencimiento.DataPropertyName = "FechaMaxDepreciacion"
        Me.FechaVencimiento.HeaderText = "Depreciación Final"
        Me.FechaVencimiento.Name = "FechaVencimiento"
        Me.FechaVencimiento.Width = 130
        '
        'Marca1
        '
        Me.Marca1.DataPropertyName = "marca"
        Me.Marca1.HeaderText = "Marca"
        Me.Marca1.Name = "Marca1"
        Me.Marca1.Width = 150
        '
        'Modelo1
        '
        Me.Modelo1.DataPropertyName = "modelo"
        Me.Modelo1.HeaderText = "Modelo"
        Me.Modelo1.Name = "Modelo1"
        Me.Modelo1.Width = 150
        '
        'NoSerie
        '
        Me.NoSerie.DataPropertyName = "Numero_Serie"
        Me.NoSerie.HeaderText = "Número Serie"
        Me.NoSerie.Name = "NoSerie"
        Me.NoSerie.Width = 150
        '
        'Financiero_Procesos_Depreciacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(670, 696)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Financiero_Procesos_Depreciacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ERP_ReportTrasnfer"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.PnAgregarActivos.ResumeLayout(False)
        Me.PnAgregarActivos.PerformLayout()
        CType(Me.DGBuscarActivos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnProcesando.ResumeLayout(False)
        Me.PnProcesando.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGActivosFij, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PnProcesando As Panel
    Private WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Private WithEvents Label7 As Label
    Friend WithEvents DTP_DateFactura As DateTimePicker
    Friend WithEvents txtDescripcion As TextBox
    Private WithEvents Label1 As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents BtnProcInformacion As Button
    Private WithEvents cmdCancel As Button
    Private WithEvents lblporcentaje As Label
    Private WithEvents Label3 As Label
    Friend WithEvents btnVistaPrevia As Button
    Friend WithEvents BtnProcRechazar As Button
    Friend WithEvents BackgroundWorker2 As System.ComponentModel.BackgroundWorker
    Friend WithEvents DGActivosFij As DataGridView
    Friend WithEvents btnAgregarActivos As Button
    Friend WithEvents PnAgregarActivos As Panel
    Friend WithEvents btnAgregarActivosA As Button
    Friend WithEvents btnCerrarActivos As Button
    Friend WithEvents DGBuscarActivos As DataGridView
    Friend WithEvents btnEliminarListado As Button
    Friend WithEvents btnTodos As Button
    Friend WithEvents lblTotalAct As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents IdActivo As DataGridViewTextBoxColumn
    Friend WithEvents CodigoActivo As DataGridViewTextBoxColumn
    Friend WithEvents NombreActivo As DataGridViewTextBoxColumn
    Friend WithEvents Amount_Acquired As DataGridViewTextBoxColumn
    Friend WithEvents Vencimiento As DataGridViewTextBoxColumn
    Friend WithEvents Marca As DataGridViewTextBoxColumn
    Friend WithEvents Modelo As DataGridViewTextBoxColumn
    Friend WithEvents NuSerie As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents FechaVencimiento As DataGridViewTextBoxColumn
    Friend WithEvents Marca1 As DataGridViewTextBoxColumn
    Friend WithEvents Modelo1 As DataGridViewTextBoxColumn
    Friend WithEvents NoSerie As DataGridViewTextBoxColumn
End Class
