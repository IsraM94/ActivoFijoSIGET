<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class POA_MapaRiesgo
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupDatosUsuario = New System.Windows.Forms.GroupBox()
        Me.cbAutorizacion = New System.Windows.Forms.ComboBox()
        Me.cbResponsable = New System.Windows.Forms.ComboBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.cbGrado = New System.Windows.Forms.ComboBox()
        Me.cbProbabilidad = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_POA_Indicador = New System.Windows.Forms.TextBox()
        Me.txt_POA_SeguimientoEvaluacion = New System.Windows.Forms.TextBox()
        Me.DG_AccionesMAnejo = New System.Windows.Forms.DataGridView()
        Me.ID_ManagementActions = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ManagementActions = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DG_OpcionesManejo = New System.Windows.Forms.DataGridView()
        Me.ID_DrivingOptions = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OpcionesManejo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_POA_EquipoResponsable = New System.Windows.Forms.TextBox()
        Me.txtPOA_DescripcionRiesgo = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_POA_Objetivos = New System.Windows.Forms.TextBox()
        Me.lblValor = New System.Windows.Forms.Label()
        Me.txt_POA_Proceso = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblSeveridad = New System.Windows.Forms.Label()
        Me.CMSCreditLine = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.NuevaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActualizarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnGrabar = New System.Windows.Forms.Button()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.GroupDatosUsuario.SuspendLayout()
        CType(Me.DG_AccionesMAnejo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DG_OpcionesManejo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.CMSCreditLine.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupDatosUsuario
        '
        Me.GroupDatosUsuario.BackColor = System.Drawing.SystemColors.Control
        Me.GroupDatosUsuario.Controls.Add(Me.btnGrabar)
        Me.GroupDatosUsuario.Controls.Add(Me.cmdCancel)
        Me.GroupDatosUsuario.Controls.Add(Me.cbAutorizacion)
        Me.GroupDatosUsuario.Controls.Add(Me.cbResponsable)
        Me.GroupDatosUsuario.Controls.Add(Me.Label21)
        Me.GroupDatosUsuario.Controls.Add(Me.Label20)
        Me.GroupDatosUsuario.Controls.Add(Me.cbGrado)
        Me.GroupDatosUsuario.Controls.Add(Me.cbProbabilidad)
        Me.GroupDatosUsuario.Controls.Add(Me.Label5)
        Me.GroupDatosUsuario.Controls.Add(Me.txt_POA_Indicador)
        Me.GroupDatosUsuario.Controls.Add(Me.txt_POA_SeguimientoEvaluacion)
        Me.GroupDatosUsuario.Controls.Add(Me.DG_AccionesMAnejo)
        Me.GroupDatosUsuario.Controls.Add(Me.DG_OpcionesManejo)
        Me.GroupDatosUsuario.Controls.Add(Me.Label6)
        Me.GroupDatosUsuario.Controls.Add(Me.txt_POA_EquipoResponsable)
        Me.GroupDatosUsuario.Controls.Add(Me.txtPOA_DescripcionRiesgo)
        Me.GroupDatosUsuario.Controls.Add(Me.Label10)
        Me.GroupDatosUsuario.Controls.Add(Me.Label9)
        Me.GroupDatosUsuario.Controls.Add(Me.Label8)
        Me.GroupDatosUsuario.Controls.Add(Me.Label7)
        Me.GroupDatosUsuario.Controls.Add(Me.Label4)
        Me.GroupDatosUsuario.Controls.Add(Me.Label3)
        Me.GroupDatosUsuario.Controls.Add(Me.Label2)
        Me.GroupDatosUsuario.Controls.Add(Me.Label1)
        Me.GroupDatosUsuario.Controls.Add(Me.txt_POA_Objetivos)
        Me.GroupDatosUsuario.Controls.Add(Me.lblValor)
        Me.GroupDatosUsuario.Controls.Add(Me.txt_POA_Proceso)
        Me.GroupDatosUsuario.Controls.Add(Me.Panel1)
        Me.GroupDatosUsuario.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupDatosUsuario.Location = New System.Drawing.Point(12, 11)
        Me.GroupDatosUsuario.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupDatosUsuario.Name = "GroupDatosUsuario"
        Me.GroupDatosUsuario.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupDatosUsuario.Size = New System.Drawing.Size(1214, 781)
        Me.GroupDatosUsuario.TabIndex = 0
        Me.GroupDatosUsuario.TabStop = False
        Me.GroupDatosUsuario.Text = "Datos Mapa de Riesgo"
        '
        'cbAutorizacion
        '
        Me.cbAutorizacion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbAutorizacion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbAutorizacion.BackColor = System.Drawing.Color.Gainsboro
        Me.cbAutorizacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbAutorizacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbAutorizacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbAutorizacion.FormattingEnabled = True
        Me.cbAutorizacion.Location = New System.Drawing.Point(842, 267)
        Me.cbAutorizacion.Margin = New System.Windows.Forms.Padding(4)
        Me.cbAutorizacion.Name = "cbAutorizacion"
        Me.cbAutorizacion.Size = New System.Drawing.Size(358, 28)
        Me.cbAutorizacion.TabIndex = 8
        '
        'cbResponsable
        '
        Me.cbResponsable.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbResponsable.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbResponsable.BackColor = System.Drawing.Color.Gainsboro
        Me.cbResponsable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbResponsable.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbResponsable.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbResponsable.FormattingEnabled = True
        Me.cbResponsable.Location = New System.Drawing.Point(265, 267)
        Me.cbResponsable.Margin = New System.Windows.Forms.Padding(4)
        Me.cbResponsable.Name = "cbResponsable"
        Me.cbResponsable.Size = New System.Drawing.Size(368, 28)
        Me.cbResponsable.TabIndex = 7
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(690, 275)
        Me.Label21.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(118, 20)
        Me.Label21.TabIndex = 43
        Me.Label21.Text = "Jefe Autoriza: "
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(31, 275)
        Me.Label20.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(183, 20)
        Me.Label20.TabIndex = 42
        Me.Label20.Text = "Persona Responsable: "
        '
        'cbGrado
        '
        Me.cbGrado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbGrado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbGrado.BackColor = System.Drawing.Color.Gainsboro
        Me.cbGrado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbGrado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbGrado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbGrado.FormattingEnabled = True
        Me.cbGrado.Location = New System.Drawing.Point(1003, 143)
        Me.cbGrado.Margin = New System.Windows.Forms.Padding(4)
        Me.cbGrado.Name = "cbGrado"
        Me.cbGrado.Size = New System.Drawing.Size(199, 33)
        Me.cbGrado.TabIndex = 5
        '
        'cbProbabilidad
        '
        Me.cbProbabilidad.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbProbabilidad.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbProbabilidad.BackColor = System.Drawing.Color.Gainsboro
        Me.cbProbabilidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbProbabilidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbProbabilidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbProbabilidad.FormattingEnabled = True
        Me.cbProbabilidad.Location = New System.Drawing.Point(699, 143)
        Me.cbProbabilidad.Margin = New System.Windows.Forms.Padding(4)
        Me.cbProbabilidad.Name = "cbProbabilidad"
        Me.cbProbabilidad.Size = New System.Drawing.Size(205, 33)
        Me.cbProbabilidad.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(694, 208)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(173, 20)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "Severidad de Riesgo: "
        '
        'txt_POA_Indicador
        '
        Me.txt_POA_Indicador.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_POA_Indicador.Location = New System.Drawing.Point(801, 636)
        Me.txt_POA_Indicador.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_POA_Indicador.MaxLength = 200
        Me.txt_POA_Indicador.Multiline = True
        Me.txt_POA_Indicador.Name = "txt_POA_Indicador"
        Me.txt_POA_Indicador.Size = New System.Drawing.Size(399, 79)
        Me.txt_POA_Indicador.TabIndex = 12
        '
        'txt_POA_SeguimientoEvaluacion
        '
        Me.txt_POA_SeguimientoEvaluacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_POA_SeguimientoEvaluacion.Location = New System.Drawing.Point(281, 632)
        Me.txt_POA_SeguimientoEvaluacion.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_POA_SeguimientoEvaluacion.MaxLength = 200
        Me.txt_POA_SeguimientoEvaluacion.Multiline = True
        Me.txt_POA_SeguimientoEvaluacion.Name = "txt_POA_SeguimientoEvaluacion"
        Me.txt_POA_SeguimientoEvaluacion.Size = New System.Drawing.Size(399, 83)
        Me.txt_POA_SeguimientoEvaluacion.TabIndex = 11
        '
        'DG_AccionesMAnejo
        '
        Me.DG_AccionesMAnejo.AllowUserToDeleteRows = False
        Me.DG_AccionesMAnejo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_AccionesMAnejo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID_ManagementActions, Me.ManagementActions})
        Me.DG_AccionesMAnejo.Location = New System.Drawing.Point(32, 502)
        Me.DG_AccionesMAnejo.Margin = New System.Windows.Forms.Padding(4)
        Me.DG_AccionesMAnejo.Name = "DG_AccionesMAnejo"
        Me.DG_AccionesMAnejo.Size = New System.Drawing.Size(1168, 118)
        Me.DG_AccionesMAnejo.TabIndex = 10
        '
        'ID_ManagementActions
        '
        Me.ID_ManagementActions.DataPropertyName = "ID_ManagementActions"
        Me.ID_ManagementActions.HeaderText = "Codigo"
        Me.ID_ManagementActions.Name = "ID_ManagementActions"
        Me.ID_ManagementActions.Visible = False
        '
        'ManagementActions
        '
        Me.ManagementActions.DataPropertyName = "ManagementActions"
        Me.ManagementActions.HeaderText = "Acciones de Manejo"
        Me.ManagementActions.Name = "ManagementActions"
        Me.ManagementActions.Width = 950
        '
        'DG_OpcionesManejo
        '
        Me.DG_OpcionesManejo.AllowUserToDeleteRows = False
        Me.DG_OpcionesManejo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_OpcionesManejo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID_DrivingOptions, Me.OpcionesManejo})
        Me.DG_OpcionesManejo.Location = New System.Drawing.Point(33, 346)
        Me.DG_OpcionesManejo.Margin = New System.Windows.Forms.Padding(4)
        Me.DG_OpcionesManejo.Name = "DG_OpcionesManejo"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DG_OpcionesManejo.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.DG_OpcionesManejo.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DG_OpcionesManejo.Size = New System.Drawing.Size(1168, 114)
        Me.DG_OpcionesManejo.TabIndex = 9
        '
        'ID_DrivingOptions
        '
        Me.ID_DrivingOptions.DataPropertyName = "ID_DrivingOptions"
        Me.ID_DrivingOptions.HeaderText = "Codigo"
        Me.ID_DrivingOptions.Name = "ID_DrivingOptions"
        Me.ID_DrivingOptions.Visible = False
        '
        'OpcionesManejo
        '
        Me.OpcionesManejo.DataPropertyName = "OpcionesManejo"
        Me.OpcionesManejo.HeaderText = "Opciones de Manejo"
        Me.OpcionesManejo.Name = "OpcionesManejo"
        Me.OpcionesManejo.Width = 950
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(31, 316)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(167, 20)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "Opciones de manejo:"
        '
        'txt_POA_EquipoResponsable
        '
        Me.txt_POA_EquipoResponsable.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_POA_EquipoResponsable.Location = New System.Drawing.Point(252, 217)
        Me.txt_POA_EquipoResponsable.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_POA_EquipoResponsable.MaxLength = 200
        Me.txt_POA_EquipoResponsable.Name = "txt_POA_EquipoResponsable"
        Me.txt_POA_EquipoResponsable.Size = New System.Drawing.Size(381, 30)
        Me.txt_POA_EquipoResponsable.TabIndex = 6
        '
        'txtPOA_DescripcionRiesgo
        '
        Me.txtPOA_DescripcionRiesgo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPOA_DescripcionRiesgo.Location = New System.Drawing.Point(131, 129)
        Me.txtPOA_DescripcionRiesgo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPOA_DescripcionRiesgo.MaxLength = 200
        Me.txtPOA_DescripcionRiesgo.Multiline = True
        Me.txtPOA_DescripcionRiesgo.Name = "txtPOA_DescripcionRiesgo"
        Me.txtPOA_DescripcionRiesgo.Size = New System.Drawing.Size(441, 80)
        Me.txtPOA_DescripcionRiesgo.TabIndex = 3
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(693, 644)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(77, 20)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Indicador"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(23, 635)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(198, 40)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Seguimiento y evaluación" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " en tiempo:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label8.Location = New System.Drawing.Point(30, 467)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(191, 28)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Acciones de Manejo:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(33, 224)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(167, 20)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Equipo Responsable:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(908, 136)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 40)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Grado " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "de Impacto:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(582, 136)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 40)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Probabilidad " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "de Ocurrencia:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 136)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 40)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Descripción " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "del Riesgo:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(582, 45)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 20)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Objetivos:"
        '
        'txt_POA_Objetivos
        '
        Me.txt_POA_Objetivos.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_POA_Objetivos.Location = New System.Drawing.Point(674, 39)
        Me.txt_POA_Objetivos.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_POA_Objetivos.MaxLength = 200
        Me.txt_POA_Objetivos.Multiline = True
        Me.txt_POA_Objetivos.Name = "txt_POA_Objetivos"
        Me.txt_POA_Objetivos.Size = New System.Drawing.Size(528, 83)
        Me.txt_POA_Objetivos.TabIndex = 2
        '
        'lblValor
        '
        Me.lblValor.AutoSize = True
        Me.lblValor.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValor.Location = New System.Drawing.Point(34, 41)
        Me.lblValor.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblValor.Name = "lblValor"
        Me.lblValor.Size = New System.Drawing.Size(76, 20)
        Me.lblValor.TabIndex = 6
        Me.lblValor.Text = "Proceso:"
        '
        'txt_POA_Proceso
        '
        Me.txt_POA_Proceso.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_POA_Proceso.Location = New System.Drawing.Point(131, 38)
        Me.txt_POA_Proceso.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_POA_Proceso.MaxLength = 150
        Me.txt_POA_Proceso.Multiline = True
        Me.txt_POA_Proceso.Name = "txt_POA_Proceso"
        Me.txt_POA_Proceso.Size = New System.Drawing.Size(441, 83)
        Me.txt_POA_Proceso.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.lblSeveridad)
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(912, 201)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(288, 43)
        Me.Panel1.TabIndex = 41
        '
        'lblSeveridad
        '
        Me.lblSeveridad.AutoSize = True
        Me.lblSeveridad.Font = New System.Drawing.Font("Segoe UI", 15.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.lblSeveridad.Location = New System.Drawing.Point(16, 4)
        Me.lblSeveridad.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSeveridad.Name = "lblSeveridad"
        Me.lblSeveridad.Size = New System.Drawing.Size(0, 35)
        Me.lblSeveridad.TabIndex = 39
        '
        'CMSCreditLine
        '
        Me.CMSCreditLine.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.CMSCreditLine.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevaToolStripMenuItem, Me.ActualizarToolStripMenuItem, Me.EliminarToolStripMenuItem})
        Me.CMSCreditLine.Name = "CMSCreditLine"
        Me.CMSCreditLine.Size = New System.Drawing.Size(143, 76)
        '
        'NuevaToolStripMenuItem
        '
        Me.NuevaToolStripMenuItem.Name = "NuevaToolStripMenuItem"
        Me.NuevaToolStripMenuItem.Size = New System.Drawing.Size(142, 24)
        Me.NuevaToolStripMenuItem.Text = "Nueva"
        '
        'ActualizarToolStripMenuItem
        '
        Me.ActualizarToolStripMenuItem.Name = "ActualizarToolStripMenuItem"
        Me.ActualizarToolStripMenuItem.Size = New System.Drawing.Size(142, 24)
        Me.ActualizarToolStripMenuItem.Text = "Modificar"
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(142, 24)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
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
        Me.btnGrabar.Location = New System.Drawing.Point(906, 737)
        Me.btnGrabar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnGrabar.Name = "btnGrabar"
        Me.btnGrabar.Size = New System.Drawing.Size(131, 34)
        Me.btnGrabar.TabIndex = 44
        Me.btnGrabar.Text = "Grabar"
        Me.btnGrabar.UseVisualStyleBackColor = False
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
        Me.cmdCancel.Location = New System.Drawing.Point(1063, 737)
        Me.cmdCancel.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(131, 34)
        Me.cmdCancel.TabIndex = 45
        Me.cmdCancel.Text = "Cancelar"
        Me.cmdCancel.UseVisualStyleBackColor = False
        '
        'POA_MapaRiesgo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CadetBlue
        Me.ClientSize = New System.Drawing.Size(1238, 803)
        Me.Controls.Add(Me.GroupDatosUsuario)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "POA_MapaRiesgo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ERP_CreditLine"
        Me.GroupDatosUsuario.ResumeLayout(False)
        Me.GroupDatosUsuario.PerformLayout()
        CType(Me.DG_AccionesMAnejo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DG_OpcionesManejo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.CMSCreditLine.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupDatosUsuario As GroupBox
    Friend WithEvents CMSCreditLine As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents NuevaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ActualizarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txt_POA_Proceso As TextBox
    Private WithEvents lblValor As Label
    Private WithEvents Label1 As Label
    Friend WithEvents txt_POA_Objetivos As TextBox
    Friend WithEvents txtPOA_DescripcionRiesgo As TextBox
    Private WithEvents Label10 As Label
    Private WithEvents Label9 As Label
    Private WithEvents Label8 As Label
    Private WithEvents Label7 As Label
    Private WithEvents Label4 As Label
    Private WithEvents Label3 As Label
    Private WithEvents Label2 As Label
    Friend WithEvents DG_OpcionesManejo As DataGridView
    Private WithEvents Label6 As Label
    Friend WithEvents txt_POA_EquipoResponsable As TextBox
    Friend WithEvents txt_POA_Indicador As TextBox
    Friend WithEvents txt_POA_SeguimientoEvaluacion As TextBox
    Friend WithEvents DG_AccionesMAnejo As DataGridView
    Private WithEvents lblSeveridad As Label
    Private WithEvents Label5 As Label
    Private WithEvents cbGrado As ComboBox
    Private WithEvents cbProbabilidad As ComboBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ID_ManagementActions As DataGridViewTextBoxColumn
    Friend WithEvents ManagementActions As DataGridViewTextBoxColumn
    Friend WithEvents ID_DrivingOptions As DataGridViewTextBoxColumn
    Friend WithEvents OpcionesManejo As DataGridViewTextBoxColumn
    Private WithEvents cbAutorizacion As ComboBox
    Private WithEvents cbResponsable As ComboBox
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Private WithEvents btnGrabar As Button
    Private WithEvents cmdCancel As Button
End Class
