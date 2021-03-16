<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class POA_EvaluacionMapa
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
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.GroupDatosUsuario = New System.Windows.Forms.GroupBox()
        Me.cbAutorizacion = New System.Windows.Forms.ComboBox()
        Me.cbResponsable = New System.Windows.Forms.ComboBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.cbGrado = New System.Windows.Forms.ComboBox()
        Me.cbProbabilidad = New System.Windows.Forms.ComboBox()
        Me.lblSeveridad = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_POA_Indicador = New System.Windows.Forms.TextBox()
        Me.txt_POA_SeguimientoEvaluacion = New System.Windows.Forms.TextBox()
        Me.DG_AccionesMAnejo = New System.Windows.Forms.DataGridView()
        Me.ID_ManagementActions = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ManagementActions = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Resultados = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Observaciones = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.CMSCreditLine = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.NuevaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActualizarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnGrabar = New System.Windows.Forms.Button()
        Me.GroupDatosUsuario.SuspendLayout()
        CType(Me.DG_AccionesMAnejo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CMSCreditLine.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
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
        Me.cmdCancel.Location = New System.Drawing.Point(1305, 737)
        Me.cmdCancel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(131, 34)
        Me.cmdCancel.TabIndex = 15
        Me.cmdCancel.Text = "Cancelar"
        Me.cmdCancel.UseVisualStyleBackColor = False
        '
        'GroupDatosUsuario
        '
        Me.GroupDatosUsuario.Controls.Add(Me.cbAutorizacion)
        Me.GroupDatosUsuario.Controls.Add(Me.cbResponsable)
        Me.GroupDatosUsuario.Controls.Add(Me.Label21)
        Me.GroupDatosUsuario.Controls.Add(Me.Label20)
        Me.GroupDatosUsuario.Controls.Add(Me.cbGrado)
        Me.GroupDatosUsuario.Controls.Add(Me.cbProbabilidad)
        Me.GroupDatosUsuario.Controls.Add(Me.lblSeveridad)
        Me.GroupDatosUsuario.Controls.Add(Me.Label5)
        Me.GroupDatosUsuario.Controls.Add(Me.txt_POA_Indicador)
        Me.GroupDatosUsuario.Controls.Add(Me.txt_POA_SeguimientoEvaluacion)
        Me.GroupDatosUsuario.Controls.Add(Me.DG_AccionesMAnejo)
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
        Me.GroupDatosUsuario.Location = New System.Drawing.Point(27, 39)
        Me.GroupDatosUsuario.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupDatosUsuario.Name = "GroupDatosUsuario"
        Me.GroupDatosUsuario.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupDatosUsuario.Size = New System.Drawing.Size(1416, 692)
        Me.GroupDatosUsuario.TabIndex = 0
        Me.GroupDatosUsuario.TabStop = False
        Me.GroupDatosUsuario.Text = "Datos Re-Evaluación de Riesgo"
        '
        'cbAutorizacion
        '
        Me.cbAutorizacion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbAutorizacion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbAutorizacion.BackColor = System.Drawing.Color.Gainsboro
        Me.cbAutorizacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbAutorizacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbAutorizacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbAutorizacion.FormattingEnabled = True
        Me.cbAutorizacion.Location = New System.Drawing.Point(908, 437)
        Me.cbAutorizacion.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbAutorizacion.Name = "cbAutorizacion"
        Me.cbAutorizacion.Size = New System.Drawing.Size(485, 38)
        Me.cbAutorizacion.TabIndex = 12
        '
        'cbResponsable
        '
        Me.cbResponsable.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbResponsable.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbResponsable.BackColor = System.Drawing.Color.Gainsboro
        Me.cbResponsable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbResponsable.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbResponsable.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbResponsable.FormattingEnabled = True
        Me.cbResponsable.Location = New System.Drawing.Point(251, 437)
        Me.cbResponsable.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbResponsable.Name = "cbResponsable"
        Me.cbResponsable.Size = New System.Drawing.Size(463, 38)
        Me.cbResponsable.TabIndex = 11
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(752, 452)
        Me.Label21.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(133, 28)
        Me.Label21.TabIndex = 47
        Me.Label21.Text = "Jefe Autoriza: "
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(15, 452)
        Me.Label20.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(203, 28)
        Me.Label20.TabIndex = 46
        Me.Label20.Text = "Persona Responsable: "
        '
        'cbGrado
        '
        Me.cbGrado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbGrado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbGrado.BackColor = System.Drawing.Color.Gainsboro
        Me.cbGrado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbGrado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbGrado.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbGrado.FormattingEnabled = True
        Me.cbGrado.Location = New System.Drawing.Point(1209, 161)
        Me.cbGrado.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbGrado.Name = "cbGrado"
        Me.cbGrado.Size = New System.Drawing.Size(199, 38)
        Me.cbGrado.TabIndex = 5
        '
        'cbProbabilidad
        '
        Me.cbProbabilidad.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbProbabilidad.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbProbabilidad.BackColor = System.Drawing.Color.Gainsboro
        Me.cbProbabilidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbProbabilidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbProbabilidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbProbabilidad.FormattingEnabled = True
        Me.cbProbabilidad.Location = New System.Drawing.Point(821, 161)
        Me.cbProbabilidad.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbProbabilidad.Name = "cbProbabilidad"
        Me.cbProbabilidad.Size = New System.Drawing.Size(224, 38)
        Me.cbProbabilidad.TabIndex = 4
        '
        'lblSeveridad
        '
        Me.lblSeveridad.AutoSize = True
        Me.lblSeveridad.Font = New System.Drawing.Font("Segoe UI", 15.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.lblSeveridad.Location = New System.Drawing.Point(981, 218)
        Me.lblSeveridad.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSeveridad.Name = "lblSeveridad"
        Me.lblSeveridad.Size = New System.Drawing.Size(0, 35)
        Me.lblSeveridad.TabIndex = 39
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.Label5.Location = New System.Drawing.Point(692, 218)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(244, 32)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "Severidad de Riesgo: "
        '
        'txt_POA_Indicador
        '
        Me.txt_POA_Indicador.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_POA_Indicador.Location = New System.Drawing.Point(935, 324)
        Me.txt_POA_Indicador.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_POA_Indicador.MaxLength = 200
        Me.txt_POA_Indicador.Multiline = True
        Me.txt_POA_Indicador.Name = "txt_POA_Indicador"
        Me.txt_POA_Indicador.Size = New System.Drawing.Size(459, 94)
        Me.txt_POA_Indicador.TabIndex = 10
        '
        'txt_POA_SeguimientoEvaluacion
        '
        Me.txt_POA_SeguimientoEvaluacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_POA_SeguimientoEvaluacion.Location = New System.Drawing.Point(328, 320)
        Me.txt_POA_SeguimientoEvaluacion.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_POA_SeguimientoEvaluacion.MaxLength = 200
        Me.txt_POA_SeguimientoEvaluacion.Multiline = True
        Me.txt_POA_SeguimientoEvaluacion.Name = "txt_POA_SeguimientoEvaluacion"
        Me.txt_POA_SeguimientoEvaluacion.Size = New System.Drawing.Size(465, 98)
        Me.txt_POA_SeguimientoEvaluacion.TabIndex = 7
        '
        'DG_AccionesMAnejo
        '
        Me.DG_AccionesMAnejo.AllowUserToAddRows = False
        Me.DG_AccionesMAnejo.AllowUserToDeleteRows = False
        Me.DG_AccionesMAnejo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_AccionesMAnejo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID_ManagementActions, Me.ManagementActions, Me.Resultados, Me.Observaciones})
        Me.DG_AccionesMAnejo.Location = New System.Drawing.Point(15, 516)
        Me.DG_AccionesMAnejo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DG_AccionesMAnejo.Name = "DG_AccionesMAnejo"
        Me.DG_AccionesMAnejo.RowHeadersVisible = False
        Me.DG_AccionesMAnejo.Size = New System.Drawing.Size(1395, 165)
        Me.DG_AccionesMAnejo.TabIndex = 13
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
        Me.ManagementActions.Width = 500
        '
        'Resultados
        '
        Me.Resultados.DataPropertyName = "Resultados"
        Me.Resultados.HeaderText = "Resultados Obtenidos"
        Me.Resultados.Name = "Resultados"
        Me.Resultados.Width = 250
        '
        'Observaciones
        '
        Me.Observaciones.DataPropertyName = "Observacion"
        Me.Observaciones.HeaderText = "Observaciones"
        Me.Observaciones.Name = "Observaciones"
        Me.Observaciones.Width = 250
        '
        'txt_POA_EquipoResponsable
        '
        Me.txt_POA_EquipoResponsable.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_POA_EquipoResponsable.Location = New System.Drawing.Point(263, 266)
        Me.txt_POA_EquipoResponsable.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_POA_EquipoResponsable.MaxLength = 200
        Me.txt_POA_EquipoResponsable.Name = "txt_POA_EquipoResponsable"
        Me.txt_POA_EquipoResponsable.Size = New System.Drawing.Size(563, 37)
        Me.txt_POA_EquipoResponsable.TabIndex = 6
        '
        'txtPOA_DescripcionRiesgo
        '
        Me.txtPOA_DescripcionRiesgo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPOA_DescripcionRiesgo.Location = New System.Drawing.Point(192, 142)
        Me.txtPOA_DescripcionRiesgo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPOA_DescripcionRiesgo.MaxLength = 200
        Me.txtPOA_DescripcionRiesgo.Multiline = True
        Me.txtPOA_DescripcionRiesgo.Name = "txtPOA_DescripcionRiesgo"
        Me.txtPOA_DescripcionRiesgo.Size = New System.Drawing.Size(441, 80)
        Me.txtPOA_DescripcionRiesgo.TabIndex = 3
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.Label10.Location = New System.Drawing.Point(804, 331)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(114, 32)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Indicador"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.Label9.Location = New System.Drawing.Point(8, 324)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(291, 64)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Seguimiento y evaluacion" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " en tiempo:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.Label8.Location = New System.Drawing.Point(31, 481)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(236, 32)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Acciones de Manejo:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.Label7.Location = New System.Drawing.Point(8, 270)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(234, 32)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Equipo Responsable:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.Label4.Location = New System.Drawing.Point(1055, 142)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(140, 64)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Grado " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "de Impacto:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.Label3.Location = New System.Drawing.Point(643, 145)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(169, 64)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Probabilidad " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "de Ocurrencia:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.Label2.Location = New System.Drawing.Point(7, 161)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(146, 64)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Descripción " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "del Riesgo:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.Label1.Location = New System.Drawing.Point(683, 42)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 32)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Objetivos:"
        '
        'txt_POA_Objetivos
        '
        Me.txt_POA_Objetivos.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_POA_Objetivos.Location = New System.Drawing.Point(821, 38)
        Me.txt_POA_Objetivos.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_POA_Objetivos.MaxLength = 200
        Me.txt_POA_Objetivos.Multiline = True
        Me.txt_POA_Objetivos.Name = "txt_POA_Objetivos"
        Me.txt_POA_Objetivos.Size = New System.Drawing.Size(587, 83)
        Me.txt_POA_Objetivos.TabIndex = 2
        '
        'lblValor
        '
        Me.lblValor.AutoSize = True
        Me.lblValor.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.lblValor.Location = New System.Drawing.Point(27, 38)
        Me.lblValor.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblValor.Name = "lblValor"
        Me.lblValor.Size = New System.Drawing.Size(103, 32)
        Me.lblValor.TabIndex = 6
        Me.lblValor.Text = "Proceso:"
        '
        'txt_POA_Proceso
        '
        Me.txt_POA_Proceso.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_POA_Proceso.Location = New System.Drawing.Point(192, 38)
        Me.txt_POA_Proceso.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_POA_Proceso.MaxLength = 150
        Me.txt_POA_Proceso.Multiline = True
        Me.txt_POA_Proceso.Name = "txt_POA_Proceso"
        Me.txt_POA_Proceso.Size = New System.Drawing.Size(441, 83)
        Me.txt_POA_Proceso.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(949, 219)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(267, 33)
        Me.Panel1.TabIndex = 41
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
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.GroupDatosUsuario)
        Me.GroupBox1.Controls.Add(Me.btnGrabar)
        Me.GroupBox1.Controls.Add(Me.cmdCancel)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(16, 14)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(1460, 789)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Re-Evaluación de Riesgos"
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
        Me.btnGrabar.Location = New System.Drawing.Point(1148, 737)
        Me.btnGrabar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnGrabar.Name = "btnGrabar"
        Me.btnGrabar.Size = New System.Drawing.Size(131, 34)
        Me.btnGrabar.TabIndex = 14
        Me.btnGrabar.Text = "Grabar"
        Me.btnGrabar.UseVisualStyleBackColor = False
        '
        'POA_EvaluacionMapa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CadetBlue
        Me.ClientSize = New System.Drawing.Size(1489, 817)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "POA_EvaluacionMapa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ERP_CreditLine"
        Me.GroupDatosUsuario.ResumeLayout(False)
        Me.GroupDatosUsuario.PerformLayout()
        CType(Me.DG_AccionesMAnejo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CMSCreditLine.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents cmdCancel As Button
    Friend WithEvents GroupDatosUsuario As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CMSCreditLine As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents NuevaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ActualizarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txt_POA_Proceso As TextBox
    Private WithEvents lblValor As Label
    Private WithEvents btnGrabar As Button
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
    Friend WithEvents Resultados As DataGridViewTextBoxColumn
    Friend WithEvents Observaciones As DataGridViewTextBoxColumn
    Private WithEvents cbAutorizacion As ComboBox
    Private WithEvents cbResponsable As ComboBox
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
End Class
