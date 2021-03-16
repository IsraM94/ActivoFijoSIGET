<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CreacionPOA
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnHistorialRechazos = New System.Windows.Forms.Button()
        Me.txtObjetivo = New System.Windows.Forms.TextBox()
        Me.LinkAcciones = New System.Windows.Forms.LinkLabel()
        Me.lblFechaP = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.cbTipo = New System.Windows.Forms.ComboBox()
        Me.cbAutorizacion = New System.Windows.Forms.ComboBox()
        Me.cbResponsable = New System.Windows.Forms.ComboBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.lblFechaPresentacion = New System.Windows.Forms.Label()
        Me.lblGerencia = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.btnGrabar = New System.Windows.Forms.Button()
        Me.txtAnio = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.GBData = New System.Windows.Forms.GroupBox()
        Me.DGAcciones = New System.Windows.Forms.DataGridView()
        Me.IdAccionPOA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodeAccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Accion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Lider = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoMedicionPOA = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.IndicadorA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MetaPOA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EneroPOA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FebreroPOA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MarzoPOA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AbrilPOA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MayoPOA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JunioPOA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JulioPOA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AgostoPOA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SeptiembrePOA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OctubrePOA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NoviembrePOA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiciembrePOA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AplicaNo = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.RecursosPOA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdTipoMedicion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        Me.GBData.SuspendLayout()
        CType(Me.DGAcciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.cmdCancel.Location = New System.Drawing.Point(890, 679)
        Me.cmdCancel.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(131, 34)
        Me.cmdCancel.TabIndex = 4
        Me.cmdCancel.Text = "Cerrar"
        Me.cmdCancel.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.btnHistorialRechazos)
        Me.GroupBox1.Controls.Add(Me.txtObjetivo)
        Me.GroupBox1.Controls.Add(Me.LinkAcciones)
        Me.GroupBox1.Controls.Add(Me.lblFechaP)
        Me.GroupBox1.Controls.Add(Me.Label23)
        Me.GroupBox1.Controls.Add(Me.cbTipo)
        Me.GroupBox1.Controls.Add(Me.cbAutorizacion)
        Me.GroupBox1.Controls.Add(Me.cbResponsable)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.lblFechaPresentacion)
        Me.GroupBox1.Controls.Add(Me.lblGerencia)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.btnGrabar)
        Me.GroupBox1.Controls.Add(Me.cmdCancel)
        Me.GroupBox1.Controls.Add(Me.txtAnio)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.GBData)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(7, 10)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(1029, 734)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Creación de POA"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(400, 679)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(231, 36)
        Me.Button1.TabIndex = 41
        Me.Button1.Text = "Enviar a Aprobación"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnHistorialRechazos
        '
        Me.btnHistorialRechazos.BackColor = System.Drawing.Color.Gainsboro
        Me.btnHistorialRechazos.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.btnHistorialRechazos.FlatAppearance.BorderSize = 0
        Me.btnHistorialRechazos.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.btnHistorialRechazos.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.btnHistorialRechazos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHistorialRechazos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHistorialRechazos.Location = New System.Drawing.Point(857, 40)
        Me.btnHistorialRechazos.Margin = New System.Windows.Forms.Padding(4)
        Me.btnHistorialRechazos.Name = "btnHistorialRechazos"
        Me.btnHistorialRechazos.Size = New System.Drawing.Size(151, 38)
        Me.btnHistorialRechazos.TabIndex = 40
        Me.btnHistorialRechazos.Text = "Historial Rechazos"
        Me.btnHistorialRechazos.UseVisualStyleBackColor = False
        '
        'txtObjetivo
        '
        Me.txtObjetivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObjetivo.Location = New System.Drawing.Point(156, 155)
        Me.txtObjetivo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtObjetivo.MaxLength = 9999999
        Me.txtObjetivo.Multiline = True
        Me.txtObjetivo.Name = "txtObjetivo"
        Me.txtObjetivo.Size = New System.Drawing.Size(865, 109)
        Me.txtObjetivo.TabIndex = 0
        '
        'LinkAcciones
        '
        Me.LinkAcciones.AutoSize = True
        Me.LinkAcciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkAcciones.Location = New System.Drawing.Point(794, 303)
        Me.LinkAcciones.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LinkAcciones.Name = "LinkAcciones"
        Me.LinkAcciones.Size = New System.Drawing.Size(227, 24)
        Me.LinkAcciones.TabIndex = 39
        Me.LinkAcciones.TabStop = True
        Me.LinkAcciones.Text = "Crear Acciones de Apoyo"
        Me.LinkAcciones.Visible = False
        '
        'lblFechaP
        '
        Me.lblFechaP.AutoSize = True
        Me.lblFechaP.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaP.Location = New System.Drawing.Point(233, 69)
        Me.lblFechaP.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFechaP.Name = "lblFechaP"
        Me.lblFechaP.Size = New System.Drawing.Size(0, 24)
        Me.lblFechaP.TabIndex = 38
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(69, 303)
        Me.Label23.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(139, 24)
        Me.Label23.TabIndex = 37
        Me.Label23.Text = "Tipo de Acción"
        '
        'cbTipo
        '
        Me.cbTipo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbTipo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbTipo.BackColor = System.Drawing.Color.Gainsboro
        Me.cbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTipo.FormattingEnabled = True
        Me.cbTipo.Items.AddRange(New Object() {"Acciones Estrategicas", "Acciones de Apoyo"})
        Me.cbTipo.Location = New System.Drawing.Point(237, 297)
        Me.cbTipo.Margin = New System.Windows.Forms.Padding(4)
        Me.cbTipo.Name = "cbTipo"
        Me.cbTipo.Size = New System.Drawing.Size(466, 30)
        Me.cbTipo.TabIndex = 36
        '
        'cbAutorizacion
        '
        Me.cbAutorizacion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbAutorizacion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbAutorizacion.BackColor = System.Drawing.Color.Gainsboro
        Me.cbAutorizacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbAutorizacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbAutorizacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbAutorizacion.FormattingEnabled = True
        Me.cbAutorizacion.Location = New System.Drawing.Point(693, 105)
        Me.cbAutorizacion.Margin = New System.Windows.Forms.Padding(4)
        Me.cbAutorizacion.Name = "cbAutorizacion"
        Me.cbAutorizacion.Size = New System.Drawing.Size(325, 30)
        Me.cbAutorizacion.TabIndex = 33
        '
        'cbResponsable
        '
        Me.cbResponsable.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbResponsable.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbResponsable.BackColor = System.Drawing.Color.Gainsboro
        Me.cbResponsable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbResponsable.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbResponsable.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbResponsable.FormattingEnabled = True
        Me.cbResponsable.Location = New System.Drawing.Point(156, 105)
        Me.cbResponsable.Margin = New System.Windows.Forms.Padding(4)
        Me.cbResponsable.Name = "cbResponsable"
        Me.cbResponsable.Size = New System.Drawing.Size(325, 30)
        Me.cbResponsable.TabIndex = 32
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(536, 115)
        Me.Label21.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(128, 24)
        Me.Label21.TabIndex = 10
        Me.Label21.Text = "Jefe Autoriza: "
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(23, 105)
        Me.Label20.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(131, 48)
        Me.Label20.TabIndex = 9
        Me.Label20.Text = "Persona " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Responsable: "
        '
        'lblFechaPresentacion
        '
        Me.lblFechaPresentacion.AutoSize = True
        Me.lblFechaPresentacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaPresentacion.Location = New System.Drawing.Point(21, 69)
        Me.lblFechaPresentacion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFechaPresentacion.Name = "lblFechaPresentacion"
        Me.lblFechaPresentacion.Size = New System.Drawing.Size(189, 24)
        Me.lblFechaPresentacion.TabIndex = 8
        Me.lblFechaPresentacion.Text = "Fecha Presentación: "
        '
        'lblGerencia
        '
        Me.lblGerencia.AutoSize = True
        Me.lblGerencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGerencia.Location = New System.Drawing.Point(179, 42)
        Me.lblGerencia.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblGerencia.Name = "lblGerencia"
        Me.lblGerencia.Size = New System.Drawing.Size(0, 18)
        Me.lblGerencia.TabIndex = 7
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(37, 39)
        Me.Label19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(97, 24)
        Me.Label19.TabIndex = 6
        Me.Label19.Text = "Gerencia: "
        '
        'btnGrabar
        '
        Me.btnGrabar.BackColor = System.Drawing.Color.Gainsboro
        Me.btnGrabar.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.btnGrabar.FlatAppearance.BorderSize = 0
        Me.btnGrabar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.btnGrabar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.btnGrabar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGrabar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGrabar.Location = New System.Drawing.Point(662, 679)
        Me.btnGrabar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnGrabar.Name = "btnGrabar"
        Me.btnGrabar.Size = New System.Drawing.Size(201, 34)
        Me.btnGrabar.TabIndex = 4
        Me.btnGrabar.Text = "Guardar y Cerrar"
        Me.btnGrabar.UseVisualStyleBackColor = False
        '
        'txtAnio
        '
        Me.txtAnio.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAnio.Location = New System.Drawing.Point(672, 42)
        Me.txtAnio.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAnio.Name = "txtAnio"
        Me.txtAnio.Size = New System.Drawing.Size(167, 28)
        Me.txtAnio.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(610, 46)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Año:"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(64, 158)
        Me.Label22.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(84, 24)
        Me.Label22.TabIndex = 35
        Me.Label22.Text = "Objetivo:"
        '
        'GBData
        '
        Me.GBData.Controls.Add(Me.DGAcciones)
        Me.GBData.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBData.Location = New System.Drawing.Point(10, 336)
        Me.GBData.Margin = New System.Windows.Forms.Padding(4)
        Me.GBData.Name = "GBData"
        Me.GBData.Padding = New System.Windows.Forms.Padding(4)
        Me.GBData.Size = New System.Drawing.Size(1011, 335)
        Me.GBData.TabIndex = 5
        Me.GBData.TabStop = False
        Me.GBData.Text = "Acciones Estrategicas"
        '
        'DGAcciones
        '
        Me.DGAcciones.AllowUserToAddRows = False
        Me.DGAcciones.AllowUserToDeleteRows = False
        Me.DGAcciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGAcciones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdAccionPOA, Me.CodeAccion, Me.Accion, Me.Lider, Me.TipoMedicionPOA, Me.IndicadorA, Me.MetaPOA, Me.EneroPOA, Me.FebreroPOA, Me.MarzoPOA, Me.AbrilPOA, Me.MayoPOA, Me.JunioPOA, Me.JulioPOA, Me.AgostoPOA, Me.SeptiembrePOA, Me.OctubrePOA, Me.NoviembrePOA, Me.DiciembrePOA, Me.AplicaNo, Me.RecursosPOA, Me.IdTipoMedicion})
        Me.DGAcciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGAcciones.Location = New System.Drawing.Point(4, 25)
        Me.DGAcciones.Margin = New System.Windows.Forms.Padding(4)
        Me.DGAcciones.MultiSelect = False
        Me.DGAcciones.Name = "DGAcciones"
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGAcciones.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGAcciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DGAcciones.Size = New System.Drawing.Size(1003, 306)
        Me.DGAcciones.TabIndex = 0
        '
        'IdAccionPOA
        '
        Me.IdAccionPOA.DataPropertyName = "IdAccion"
        Me.IdAccionPOA.HeaderText = "Id"
        Me.IdAccionPOA.Name = "IdAccionPOA"
        Me.IdAccionPOA.Visible = False
        '
        'CodeAccion
        '
        Me.CodeAccion.DataPropertyName = "CodigoAccion"
        Me.CodeAccion.HeaderText = "CodigoAccion"
        Me.CodeAccion.Name = "CodeAccion"
        Me.CodeAccion.Width = 140
        '
        'Accion
        '
        Me.Accion.DataPropertyName = "Accion"
        Me.Accion.HeaderText = "Accion Estrategica"
        Me.Accion.Name = "Accion"
        Me.Accion.Width = 450
        '
        'Lider
        '
        Me.Lider.DataPropertyName = "Gerencia"
        Me.Lider.HeaderText = "Unidad Lider"
        Me.Lider.Name = "Lider"
        Me.Lider.Width = 200
        '
        'TipoMedicionPOA
        '
        Me.TipoMedicionPOA.HeaderText = "TipoMedicion"
        Me.TipoMedicionPOA.Name = "TipoMedicionPOA"
        Me.TipoMedicionPOA.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.TipoMedicionPOA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.TipoMedicionPOA.Width = 225
        '
        'IndicadorA
        '
        Me.IndicadorA.DataPropertyName = "indicador"
        Me.IndicadorA.HeaderText = "Indicador Acción"
        Me.IndicadorA.MaxInputLength = 500
        Me.IndicadorA.Name = "IndicadorA"
        Me.IndicadorA.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.IndicadorA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.IndicadorA.Width = 400
        '
        'MetaPOA
        '
        Me.MetaPOA.DataPropertyName = "Meta"
        Me.MetaPOA.HeaderText = "Meta Dic"
        Me.MetaPOA.MaxInputLength = 100
        Me.MetaPOA.Name = "MetaPOA"
        Me.MetaPOA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'EneroPOA
        '
        Me.EneroPOA.DataPropertyName = "Enero"
        Me.EneroPOA.HeaderText = "Enero"
        Me.EneroPOA.Name = "EneroPOA"
        '
        'FebreroPOA
        '
        Me.FebreroPOA.DataPropertyName = "Febrero"
        Me.FebreroPOA.HeaderText = "Febrero"
        Me.FebreroPOA.Name = "FebreroPOA"
        '
        'MarzoPOA
        '
        Me.MarzoPOA.DataPropertyName = "Marzo"
        Me.MarzoPOA.HeaderText = "Marzo"
        Me.MarzoPOA.Name = "MarzoPOA"
        '
        'AbrilPOA
        '
        Me.AbrilPOA.DataPropertyName = "Abril"
        Me.AbrilPOA.HeaderText = "Abril"
        Me.AbrilPOA.Name = "AbrilPOA"
        '
        'MayoPOA
        '
        Me.MayoPOA.DataPropertyName = "Mayo"
        Me.MayoPOA.HeaderText = "Mayo"
        Me.MayoPOA.Name = "MayoPOA"
        '
        'JunioPOA
        '
        Me.JunioPOA.DataPropertyName = "Junio"
        Me.JunioPOA.HeaderText = "Junio"
        Me.JunioPOA.Name = "JunioPOA"
        '
        'JulioPOA
        '
        Me.JulioPOA.DataPropertyName = "Julio"
        Me.JulioPOA.HeaderText = "Julio"
        Me.JulioPOA.Name = "JulioPOA"
        '
        'AgostoPOA
        '
        Me.AgostoPOA.DataPropertyName = "Agosto"
        Me.AgostoPOA.HeaderText = "Agosto"
        Me.AgostoPOA.Name = "AgostoPOA"
        '
        'SeptiembrePOA
        '
        Me.SeptiembrePOA.DataPropertyName = "Septiembre"
        Me.SeptiembrePOA.HeaderText = "Septiembre"
        Me.SeptiembrePOA.Name = "SeptiembrePOA"
        '
        'OctubrePOA
        '
        Me.OctubrePOA.DataPropertyName = "Octubre"
        Me.OctubrePOA.HeaderText = "Octubre"
        Me.OctubrePOA.Name = "OctubrePOA"
        '
        'NoviembrePOA
        '
        Me.NoviembrePOA.DataPropertyName = "Noviembre"
        Me.NoviembrePOA.HeaderText = "Noviembre"
        Me.NoviembrePOA.Name = "NoviembrePOA"
        '
        'DiciembrePOA
        '
        Me.DiciembrePOA.DataPropertyName = "Diciembre"
        Me.DiciembrePOA.HeaderText = "Diciembre"
        Me.DiciembrePOA.Name = "DiciembrePOA"
        '
        'AplicaNo
        '
        Me.AplicaNo.HeaderText = "Aplica Recursos"
        Me.AplicaNo.Name = "AplicaNo"
        Me.AplicaNo.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.AplicaNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'RecursosPOA
        '
        Me.RecursosPOA.DataPropertyName = "Recursos"
        Me.RecursosPOA.HeaderText = "Recursos"
        Me.RecursosPOA.Name = "RecursosPOA"
        '
        'IdTipoMedicion
        '
        Me.IdTipoMedicion.DataPropertyName = "IdTipoMedicion"
        Me.IdTipoMedicion.HeaderText = "IdTipoMedicion"
        Me.IdTipoMedicion.Name = "IdTipoMedicion"
        Me.IdTipoMedicion.Visible = False
        '
        'CreacionPOA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CadetBlue
        Me.ClientSize = New System.Drawing.Size(1045, 759)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "CreacionPOA"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ERP_CreditLine"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GBData.ResumeLayout(False)
        CType(Me.DGAcciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents cmdCancel As Button
    Friend WithEvents GroupBox1 As GroupBox
    Private WithEvents btnGrabar As Button
    Friend WithEvents txtAnio As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GBData As GroupBox
    Friend WithEvents DGAcciones As DataGridView
    Friend WithEvents lblGerencia As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents lblFechaPresentacion As Label
    Private WithEvents cbTipo As ComboBox
    Friend WithEvents txtObjetivo As TextBox
    Private WithEvents cbAutorizacion As ComboBox
    Private WithEvents cbResponsable As ComboBox
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents lblFechaP As Label
    Friend WithEvents LinkAcciones As LinkLabel
    Friend WithEvents IdAccionPOA As DataGridViewTextBoxColumn
    Friend WithEvents CodeAccion As DataGridViewTextBoxColumn
    Friend WithEvents Accion As DataGridViewTextBoxColumn
    Friend WithEvents Lider As DataGridViewTextBoxColumn
    Friend WithEvents TipoMedicionPOA As DataGridViewComboBoxColumn
    Friend WithEvents IndicadorA As DataGridViewTextBoxColumn
    Friend WithEvents MetaPOA As DataGridViewTextBoxColumn
    Friend WithEvents EneroPOA As DataGridViewTextBoxColumn
    Friend WithEvents FebreroPOA As DataGridViewTextBoxColumn
    Friend WithEvents MarzoPOA As DataGridViewTextBoxColumn
    Friend WithEvents AbrilPOA As DataGridViewTextBoxColumn
    Friend WithEvents MayoPOA As DataGridViewTextBoxColumn
    Friend WithEvents JunioPOA As DataGridViewTextBoxColumn
    Friend WithEvents JulioPOA As DataGridViewTextBoxColumn
    Friend WithEvents AgostoPOA As DataGridViewTextBoxColumn
    Friend WithEvents SeptiembrePOA As DataGridViewTextBoxColumn
    Friend WithEvents OctubrePOA As DataGridViewTextBoxColumn
    Friend WithEvents NoviembrePOA As DataGridViewTextBoxColumn
    Friend WithEvents DiciembrePOA As DataGridViewTextBoxColumn
    Friend WithEvents AplicaNo As DataGridViewCheckBoxColumn
    Friend WithEvents RecursosPOA As DataGridViewTextBoxColumn
    Friend WithEvents IdTipoMedicion As DataGridViewTextBoxColumn
    Private WithEvents btnHistorialRechazos As Button
    Friend WithEvents Button1 As Button
End Class
