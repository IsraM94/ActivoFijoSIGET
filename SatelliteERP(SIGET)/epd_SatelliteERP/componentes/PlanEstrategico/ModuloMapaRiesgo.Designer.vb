<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ModuloMapaRiesgo
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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
        Me.components = New System.ComponentModel.Container()
        Me.tabMapaRiesgo = New System.Windows.Forms.TabControl()
        Me.TabPageMApaRiesgo = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel11 = New System.Windows.Forms.TableLayoutPanel()
        Me.dgMapaRiesgo = New System.Windows.Forms.DataGridView()
        Me.ID_RiskMap = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProcesoMap = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ObjetivoMap = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionMap = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProbabilidadMap = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProbabilidadOcurrenciaE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GradoMap = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GradoImpactoE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SeveridadMap = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SeveridadE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EquipoMap = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SeguimientoMap = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IndicadorMap = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn70 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn63 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn71 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn72 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn73 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn80 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DptoMap = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AnioMap = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdResponsableCMapa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdResponsableAMapa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdResponsableCEvaluacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdResponsableAEvaluacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OpcionesReporte = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ReimprimirReporteDeIngresoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReimprimirReporteDeEvaluaciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FlowLayoutPanel13 = New System.Windows.Forms.FlowLayoutPanel()
        Me.cmdMapaRiesgo = New System.Windows.Forms.Button()
        Me.cmdAgregarMapaRiesgo = New System.Windows.Forms.Button()
        Me.cmdModificarMApaRiesgo = New System.Windows.Forms.Button()
        Me.cmdRevaluacionMapaRiesgo = New System.Windows.Forms.Button()
        Me.cmdImprimirMapa = New System.Windows.Forms.Button()
        Me.cmbImprimirEvaluacion = New System.Windows.Forms.Button()
        Me.cbMapaRiesgoDpto = New System.Windows.Forms.ComboBox()
        Me.TabPageProbabilidadOcurencia = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel9 = New System.Windows.Forms.TableLayoutPanel()
        Me.DG_Probabilidad = New System.Windows.Forms.DataGridView()
        Me.ID_ProbabilityOccurrence = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Probability = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescriptionProbabilidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn64 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn65 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn66 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn67 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn68 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn69 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FlowLayoutPanel11 = New System.Windows.Forms.FlowLayoutPanel()
        Me.cmdAgregarProbabilidad = New System.Windows.Forms.Button()
        Me.cmdModificarProbabilidad = New System.Windows.Forms.Button()
        Me.cmdEliminarProbabilidad = New System.Windows.Forms.Button()
        Me.TabPageGradoImpacto = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel10 = New System.Windows.Forms.TableLayoutPanel()
        Me.DG_ImpactGrade = New System.Windows.Forms.DataGridView()
        Me.ID_ImpactGrade = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProbabilityImpacto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescriptionImpacto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn74 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn75 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn76 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn77 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn78 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn79 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FlowLayoutPanel12 = New System.Windows.Forms.FlowLayoutPanel()
        Me.cmdImpacto = New System.Windows.Forms.Button()
        Me.cmdModificarImpacto = New System.Windows.Forms.Button()
        Me.cmdEliminarImpacto = New System.Windows.Forms.Button()
        Me.TabPageResponsableMapa = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.DG_ResponsableEjecucionMapa = New System.Windows.Forms.DataGridView()
        Me.ID_ResponsibleMapRisk = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameResponsableEjecucion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescriptionResponsableEjecucion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn25 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn26 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn27 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn28 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FlowLayoutPanel4 = New System.Windows.Forms.FlowLayoutPanel()
        Me.cmdAgregarResponsableMapa = New System.Windows.Forms.Button()
        Me.cmdModificarResponsableMapa = New System.Windows.Forms.Button()
        Me.cmdEliminarResponsableMapa = New System.Windows.Forms.Button()
        Me.cbGerenciaResponsableMap = New System.Windows.Forms.ComboBox()
        Me.btnSubirDocMapa = New System.Windows.Forms.Button()
        Me.tabMapaRiesgo.SuspendLayout()
        Me.TabPageMApaRiesgo.SuspendLayout()
        Me.TableLayoutPanel11.SuspendLayout()
        CType(Me.dgMapaRiesgo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.OpcionesReporte.SuspendLayout()
        Me.FlowLayoutPanel13.SuspendLayout()
        Me.TabPageProbabilidadOcurencia.SuspendLayout()
        Me.TableLayoutPanel9.SuspendLayout()
        CType(Me.DG_Probabilidad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel11.SuspendLayout()
        Me.TabPageGradoImpacto.SuspendLayout()
        Me.TableLayoutPanel10.SuspendLayout()
        CType(Me.DG_ImpactGrade, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel12.SuspendLayout()
        Me.TabPageResponsableMapa.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.DG_ResponsableEjecucionMapa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabMapaRiesgo
        '
        Me.tabMapaRiesgo.Controls.Add(Me.TabPageMApaRiesgo)
        Me.tabMapaRiesgo.Controls.Add(Me.TabPageProbabilidadOcurencia)
        Me.tabMapaRiesgo.Controls.Add(Me.TabPageGradoImpacto)
        Me.tabMapaRiesgo.Controls.Add(Me.TabPageResponsableMapa)
        Me.tabMapaRiesgo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabMapaRiesgo.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.tabMapaRiesgo.Location = New System.Drawing.Point(0, 0)
        Me.tabMapaRiesgo.Margin = New System.Windows.Forms.Padding(4)
        Me.tabMapaRiesgo.Name = "tabMapaRiesgo"
        Me.tabMapaRiesgo.SelectedIndex = 0
        Me.tabMapaRiesgo.Size = New System.Drawing.Size(1031, 599)
        Me.tabMapaRiesgo.TabIndex = 1
        '
        'TabPageMApaRiesgo
        '
        Me.TabPageMApaRiesgo.Controls.Add(Me.TableLayoutPanel11)
        Me.TabPageMApaRiesgo.Location = New System.Drawing.Point(4, 39)
        Me.TabPageMApaRiesgo.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPageMApaRiesgo.Name = "TabPageMApaRiesgo"
        Me.TabPageMApaRiesgo.Size = New System.Drawing.Size(1023, 556)
        Me.TabPageMApaRiesgo.TabIndex = 10
        Me.TabPageMApaRiesgo.Text = "Mapa de Riesgo"
        Me.TabPageMApaRiesgo.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel11
        '
        Me.TableLayoutPanel11.ColumnCount = 1
        Me.TableLayoutPanel11.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel11.Controls.Add(Me.dgMapaRiesgo, 0, 1)
        Me.TableLayoutPanel11.Controls.Add(Me.FlowLayoutPanel13, 0, 0)
        Me.TableLayoutPanel11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel11.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel11.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel11.Name = "TableLayoutPanel11"
        Me.TableLayoutPanel11.RowCount = 2
        Me.TableLayoutPanel11.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel11.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel11.Size = New System.Drawing.Size(1023, 556)
        Me.TableLayoutPanel11.TabIndex = 15
        '
        'dgMapaRiesgo
        '
        Me.dgMapaRiesgo.AllowUserToAddRows = False
        Me.dgMapaRiesgo.AllowUserToDeleteRows = False
        Me.dgMapaRiesgo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgMapaRiesgo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgMapaRiesgo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID_RiskMap, Me.ProcesoMap, Me.ObjetivoMap, Me.DescripcionMap, Me.ProbabilidadMap, Me.ProbabilidadOcurrenciaE, Me.GradoMap, Me.GradoImpactoE, Me.SeveridadMap, Me.SeveridadE, Me.EquipoMap, Me.SeguimientoMap, Me.IndicadorMap, Me.DataGridViewTextBoxColumn70, Me.DataGridViewTextBoxColumn63, Me.DataGridViewTextBoxColumn71, Me.DataGridViewTextBoxColumn72, Me.DataGridViewTextBoxColumn73, Me.DataGridViewTextBoxColumn80, Me.DptoMap, Me.AnioMap, Me.IdResponsableCMapa, Me.IdResponsableAMapa, Me.IdResponsableCEvaluacion, Me.IdResponsableAEvaluacion})
        Me.dgMapaRiesgo.ContextMenuStrip = Me.OpcionesReporte
        Me.dgMapaRiesgo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgMapaRiesgo.EnableHeadersVisualStyles = False
        Me.dgMapaRiesgo.Location = New System.Drawing.Point(4, 104)
        Me.dgMapaRiesgo.Margin = New System.Windows.Forms.Padding(4)
        Me.dgMapaRiesgo.Name = "dgMapaRiesgo"
        Me.dgMapaRiesgo.ReadOnly = True
        Me.dgMapaRiesgo.RowHeadersVisible = False
        Me.dgMapaRiesgo.ShowCellErrors = False
        Me.dgMapaRiesgo.ShowCellToolTips = False
        Me.dgMapaRiesgo.ShowEditingIcon = False
        Me.dgMapaRiesgo.ShowRowErrors = False
        Me.dgMapaRiesgo.Size = New System.Drawing.Size(1015, 448)
        Me.dgMapaRiesgo.TabIndex = 0
        '
        'ID_RiskMap
        '
        Me.ID_RiskMap.DataPropertyName = "ID_RiskMap"
        Me.ID_RiskMap.HeaderText = "ID"
        Me.ID_RiskMap.Name = "ID_RiskMap"
        Me.ID_RiskMap.ReadOnly = True
        Me.ID_RiskMap.Width = 89
        '
        'ProcesoMap
        '
        Me.ProcesoMap.DataPropertyName = "Proceso"
        Me.ProcesoMap.HeaderText = "Proceso"
        Me.ProcesoMap.Name = "ProcesoMap"
        Me.ProcesoMap.ReadOnly = True
        Me.ProcesoMap.Width = 350
        '
        'ObjetivoMap
        '
        Me.ObjetivoMap.DataPropertyName = "Objetivo"
        Me.ObjetivoMap.HeaderText = "Objetivo"
        Me.ObjetivoMap.Name = "ObjetivoMap"
        Me.ObjetivoMap.ReadOnly = True
        Me.ObjetivoMap.Width = 350
        '
        'DescripcionMap
        '
        Me.DescripcionMap.DataPropertyName = "DescripcionRiesgo"
        Me.DescripcionMap.HeaderText = "Descripcion de Riesgo"
        Me.DescripcionMap.Name = "DescripcionMap"
        Me.DescripcionMap.ReadOnly = True
        Me.DescripcionMap.Width = 350
        '
        'ProbabilidadMap
        '
        Me.ProbabilidadMap.DataPropertyName = "ProbabilidadOcurrencia"
        Me.ProbabilidadMap.HeaderText = "Probabilidad Impacto"
        Me.ProbabilidadMap.Name = "ProbabilidadMap"
        Me.ProbabilidadMap.ReadOnly = True
        '
        'ProbabilidadOcurrenciaE
        '
        Me.ProbabilidadOcurrenciaE.DataPropertyName = "ProbabilidadOcurrenciaEva"
        Me.ProbabilidadOcurrenciaE.HeaderText = "ProbabilidadOcurrencia Eva"
        Me.ProbabilidadOcurrenciaE.Name = "ProbabilidadOcurrenciaE"
        Me.ProbabilidadOcurrenciaE.ReadOnly = True
        '
        'GradoMap
        '
        Me.GradoMap.DataPropertyName = "GradoImpacto"
        Me.GradoMap.HeaderText = "Grado Impacto"
        Me.GradoMap.Name = "GradoMap"
        Me.GradoMap.ReadOnly = True
        '
        'GradoImpactoE
        '
        Me.GradoImpactoE.DataPropertyName = "GradoImpactoEva"
        Me.GradoImpactoE.HeaderText = "GradoImpacto Eva"
        Me.GradoImpactoE.Name = "GradoImpactoE"
        Me.GradoImpactoE.ReadOnly = True
        '
        'SeveridadMap
        '
        Me.SeveridadMap.DataPropertyName = "Severidad"
        Me.SeveridadMap.HeaderText = "Severidad"
        Me.SeveridadMap.Name = "SeveridadMap"
        Me.SeveridadMap.ReadOnly = True
        Me.SeveridadMap.Width = 250
        '
        'SeveridadE
        '
        Me.SeveridadE.DataPropertyName = "SeveridadEva"
        Me.SeveridadE.HeaderText = "Severidad Eva"
        Me.SeveridadE.Name = "SeveridadE"
        Me.SeveridadE.ReadOnly = True
        Me.SeveridadE.Width = 250
        '
        'EquipoMap
        '
        Me.EquipoMap.DataPropertyName = "EquipoResponsable"
        Me.EquipoMap.HeaderText = "Equipo Responsable"
        Me.EquipoMap.Name = "EquipoMap"
        Me.EquipoMap.ReadOnly = True
        Me.EquipoMap.Width = 250
        '
        'SeguimientoMap
        '
        Me.SeguimientoMap.DataPropertyName = "Seguimiento"
        Me.SeguimientoMap.HeaderText = "Seguimiento "
        Me.SeguimientoMap.Name = "SeguimientoMap"
        Me.SeguimientoMap.ReadOnly = True
        Me.SeguimientoMap.Width = 350
        '
        'IndicadorMap
        '
        Me.IndicadorMap.DataPropertyName = "Indicador"
        Me.IndicadorMap.HeaderText = "Indicador"
        Me.IndicadorMap.Name = "IndicadorMap"
        Me.IndicadorMap.ReadOnly = True
        Me.IndicadorMap.Width = 350
        '
        'DataGridViewTextBoxColumn70
        '
        Me.DataGridViewTextBoxColumn70.DataPropertyName = "DateCreate"
        Me.DataGridViewTextBoxColumn70.HeaderText = "Fecha Creo"
        Me.DataGridViewTextBoxColumn70.Name = "DataGridViewTextBoxColumn70"
        Me.DataGridViewTextBoxColumn70.ReadOnly = True
        Me.DataGridViewTextBoxColumn70.Width = 200
        '
        'DataGridViewTextBoxColumn63
        '
        Me.DataGridViewTextBoxColumn63.DataPropertyName = "UsersCreate"
        Me.DataGridViewTextBoxColumn63.HeaderText = "Usuario Creo"
        Me.DataGridViewTextBoxColumn63.Name = "DataGridViewTextBoxColumn63"
        Me.DataGridViewTextBoxColumn63.ReadOnly = True
        Me.DataGridViewTextBoxColumn63.Width = 200
        '
        'DataGridViewTextBoxColumn71
        '
        Me.DataGridViewTextBoxColumn71.DataPropertyName = "UsersModify"
        Me.DataGridViewTextBoxColumn71.HeaderText = "Usuario Mod."
        Me.DataGridViewTextBoxColumn71.Name = "DataGridViewTextBoxColumn71"
        Me.DataGridViewTextBoxColumn71.ReadOnly = True
        Me.DataGridViewTextBoxColumn71.Width = 200
        '
        'DataGridViewTextBoxColumn72
        '
        Me.DataGridViewTextBoxColumn72.DataPropertyName = "DateModify"
        Me.DataGridViewTextBoxColumn72.HeaderText = "Fecha Mod."
        Me.DataGridViewTextBoxColumn72.Name = "DataGridViewTextBoxColumn72"
        Me.DataGridViewTextBoxColumn72.ReadOnly = True
        Me.DataGridViewTextBoxColumn72.Width = 200
        '
        'DataGridViewTextBoxColumn73
        '
        Me.DataGridViewTextBoxColumn73.HeaderText = "id_Company_FK"
        Me.DataGridViewTextBoxColumn73.Name = "DataGridViewTextBoxColumn73"
        Me.DataGridViewTextBoxColumn73.ReadOnly = True
        Me.DataGridViewTextBoxColumn73.Visible = False
        '
        'DataGridViewTextBoxColumn80
        '
        Me.DataGridViewTextBoxColumn80.DataPropertyName = "estado"
        Me.DataGridViewTextBoxColumn80.HeaderText = "Estado"
        Me.DataGridViewTextBoxColumn80.Name = "DataGridViewTextBoxColumn80"
        Me.DataGridViewTextBoxColumn80.ReadOnly = True
        Me.DataGridViewTextBoxColumn80.Visible = False
        '
        'DptoMap
        '
        Me.DptoMap.DataPropertyName = "DptoMap"
        Me.DptoMap.HeaderText = ""
        Me.DptoMap.Name = "DptoMap"
        Me.DptoMap.ReadOnly = True
        Me.DptoMap.Visible = False
        '
        'AnioMap
        '
        Me.AnioMap.DataPropertyName = "AnioMap"
        Me.AnioMap.HeaderText = ""
        Me.AnioMap.Name = "AnioMap"
        Me.AnioMap.ReadOnly = True
        Me.AnioMap.Visible = False
        '
        'IdResponsableCMapa
        '
        Me.IdResponsableCMapa.DataPropertyName = "ResponsableCre"
        Me.IdResponsableCMapa.HeaderText = "IdResponsableCMapa"
        Me.IdResponsableCMapa.Name = "IdResponsableCMapa"
        Me.IdResponsableCMapa.ReadOnly = True
        Me.IdResponsableCMapa.Visible = False
        '
        'IdResponsableAMapa
        '
        Me.IdResponsableAMapa.DataPropertyName = "AutorizacionCre"
        Me.IdResponsableAMapa.HeaderText = "IdResponsableAMapa"
        Me.IdResponsableAMapa.Name = "IdResponsableAMapa"
        Me.IdResponsableAMapa.ReadOnly = True
        Me.IdResponsableAMapa.Visible = False
        '
        'IdResponsableCEvaluacion
        '
        Me.IdResponsableCEvaluacion.DataPropertyName = "ResponsableEva"
        Me.IdResponsableCEvaluacion.HeaderText = "IdResponsableCEvaluacion"
        Me.IdResponsableCEvaluacion.Name = "IdResponsableCEvaluacion"
        Me.IdResponsableCEvaluacion.ReadOnly = True
        Me.IdResponsableCEvaluacion.Visible = False
        '
        'IdResponsableAEvaluacion
        '
        Me.IdResponsableAEvaluacion.DataPropertyName = "AutorizacionEva"
        Me.IdResponsableAEvaluacion.HeaderText = "IdResponsableAEvaluacion"
        Me.IdResponsableAEvaluacion.Name = "IdResponsableAEvaluacion"
        Me.IdResponsableAEvaluacion.ReadOnly = True
        Me.IdResponsableAEvaluacion.Visible = False
        '
        'OpcionesReporte
        '
        Me.OpcionesReporte.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.OpcionesReporte.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReimprimirReporteDeIngresoToolStripMenuItem, Me.ReimprimirReporteDeEvaluaciónToolStripMenuItem})
        Me.OpcionesReporte.Name = "OpcionesReporte"
        Me.OpcionesReporte.Size = New System.Drawing.Size(306, 52)
        '
        'ReimprimirReporteDeIngresoToolStripMenuItem
        '
        Me.ReimprimirReporteDeIngresoToolStripMenuItem.Name = "ReimprimirReporteDeIngresoToolStripMenuItem"
        Me.ReimprimirReporteDeIngresoToolStripMenuItem.Size = New System.Drawing.Size(305, 24)
        Me.ReimprimirReporteDeIngresoToolStripMenuItem.Text = "Reimprimir Reporte de Ingreso"
        '
        'ReimprimirReporteDeEvaluaciónToolStripMenuItem
        '
        Me.ReimprimirReporteDeEvaluaciónToolStripMenuItem.Name = "ReimprimirReporteDeEvaluaciónToolStripMenuItem"
        Me.ReimprimirReporteDeEvaluaciónToolStripMenuItem.Size = New System.Drawing.Size(305, 24)
        Me.ReimprimirReporteDeEvaluaciónToolStripMenuItem.Text = "Reimprimir Reporte de Evaluación"
        '
        'FlowLayoutPanel13
        '
        Me.FlowLayoutPanel13.AutoScroll = True
        Me.FlowLayoutPanel13.Controls.Add(Me.cmdMapaRiesgo)
        Me.FlowLayoutPanel13.Controls.Add(Me.cmdAgregarMapaRiesgo)
        Me.FlowLayoutPanel13.Controls.Add(Me.cmdModificarMApaRiesgo)
        Me.FlowLayoutPanel13.Controls.Add(Me.cmdRevaluacionMapaRiesgo)
        Me.FlowLayoutPanel13.Controls.Add(Me.cmdImprimirMapa)
        Me.FlowLayoutPanel13.Controls.Add(Me.cmbImprimirEvaluacion)
        Me.FlowLayoutPanel13.Controls.Add(Me.btnSubirDocMapa)
        Me.FlowLayoutPanel13.Controls.Add(Me.cbMapaRiesgoDpto)
        Me.FlowLayoutPanel13.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel13.Location = New System.Drawing.Point(4, 4)
        Me.FlowLayoutPanel13.Margin = New System.Windows.Forms.Padding(4)
        Me.FlowLayoutPanel13.Name = "FlowLayoutPanel13"
        Me.FlowLayoutPanel13.Size = New System.Drawing.Size(1015, 92)
        Me.FlowLayoutPanel13.TabIndex = 1
        '
        'cmdMapaRiesgo
        '
        Me.cmdMapaRiesgo.BackColor = System.Drawing.Color.Gainsboro
        Me.cmdMapaRiesgo.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdMapaRiesgo.FlatAppearance.BorderSize = 0
        Me.cmdMapaRiesgo.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.cmdMapaRiesgo.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.cmdMapaRiesgo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdMapaRiesgo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdMapaRiesgo.Location = New System.Drawing.Point(4, 4)
        Me.cmdMapaRiesgo.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdMapaRiesgo.Name = "cmdMapaRiesgo"
        Me.cmdMapaRiesgo.Size = New System.Drawing.Size(117, 81)
        Me.cmdMapaRiesgo.TabIndex = 30
        Me.cmdMapaRiesgo.Text = "Ver Mapa de Riesgo"
        Me.cmdMapaRiesgo.UseVisualStyleBackColor = False
        Me.cmdMapaRiesgo.Visible = False
        '
        'cmdAgregarMapaRiesgo
        '
        Me.cmdAgregarMapaRiesgo.BackColor = System.Drawing.Color.Gainsboro
        Me.cmdAgregarMapaRiesgo.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdAgregarMapaRiesgo.FlatAppearance.BorderSize = 0
        Me.cmdAgregarMapaRiesgo.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.cmdAgregarMapaRiesgo.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.cmdAgregarMapaRiesgo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAgregarMapaRiesgo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAgregarMapaRiesgo.Location = New System.Drawing.Point(129, 4)
        Me.cmdAgregarMapaRiesgo.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdAgregarMapaRiesgo.Name = "cmdAgregarMapaRiesgo"
        Me.cmdAgregarMapaRiesgo.Size = New System.Drawing.Size(156, 81)
        Me.cmdAgregarMapaRiesgo.TabIndex = 30
        Me.cmdAgregarMapaRiesgo.Text = "Agregar Mapa de Riesgo"
        Me.cmdAgregarMapaRiesgo.UseVisualStyleBackColor = False
        Me.cmdAgregarMapaRiesgo.Visible = False
        '
        'cmdModificarMApaRiesgo
        '
        Me.cmdModificarMApaRiesgo.BackColor = System.Drawing.Color.Gainsboro
        Me.cmdModificarMApaRiesgo.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdModificarMApaRiesgo.FlatAppearance.BorderSize = 0
        Me.cmdModificarMApaRiesgo.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.cmdModificarMApaRiesgo.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.cmdModificarMApaRiesgo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdModificarMApaRiesgo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdModificarMApaRiesgo.Location = New System.Drawing.Point(293, 4)
        Me.cmdModificarMApaRiesgo.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdModificarMApaRiesgo.Name = "cmdModificarMApaRiesgo"
        Me.cmdModificarMApaRiesgo.Size = New System.Drawing.Size(169, 81)
        Me.cmdModificarMApaRiesgo.TabIndex = 30
        Me.cmdModificarMApaRiesgo.Text = "Modificar Mapa de Riesgo"
        Me.cmdModificarMApaRiesgo.UseVisualStyleBackColor = False
        Me.cmdModificarMApaRiesgo.Visible = False
        '
        'cmdRevaluacionMapaRiesgo
        '
        Me.cmdRevaluacionMapaRiesgo.BackColor = System.Drawing.Color.Gainsboro
        Me.cmdRevaluacionMapaRiesgo.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdRevaluacionMapaRiesgo.FlatAppearance.BorderSize = 0
        Me.cmdRevaluacionMapaRiesgo.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.cmdRevaluacionMapaRiesgo.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.cmdRevaluacionMapaRiesgo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdRevaluacionMapaRiesgo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdRevaluacionMapaRiesgo.Location = New System.Drawing.Point(470, 4)
        Me.cmdRevaluacionMapaRiesgo.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdRevaluacionMapaRiesgo.Name = "cmdRevaluacionMapaRiesgo"
        Me.cmdRevaluacionMapaRiesgo.Size = New System.Drawing.Size(155, 81)
        Me.cmdRevaluacionMapaRiesgo.TabIndex = 30
        Me.cmdRevaluacionMapaRiesgo.Text = "Re-Evaluación Riesgo"
        Me.cmdRevaluacionMapaRiesgo.UseVisualStyleBackColor = False
        Me.cmdRevaluacionMapaRiesgo.Visible = False
        '
        'cmdImprimirMapa
        '
        Me.cmdImprimirMapa.BackColor = System.Drawing.Color.Gainsboro
        Me.cmdImprimirMapa.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdImprimirMapa.FlatAppearance.BorderSize = 0
        Me.cmdImprimirMapa.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.cmdImprimirMapa.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.cmdImprimirMapa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdImprimirMapa.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.cmdImprimirMapa.Location = New System.Drawing.Point(633, 4)
        Me.cmdImprimirMapa.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdImprimirMapa.Name = "cmdImprimirMapa"
        Me.cmdImprimirMapa.Size = New System.Drawing.Size(149, 81)
        Me.cmdImprimirMapa.TabIndex = 30
        Me.cmdImprimirMapa.Text = "Reporte Mapa de Riesgo"
        Me.cmdImprimirMapa.UseVisualStyleBackColor = False
        Me.cmdImprimirMapa.Visible = False
        '
        'cmbImprimirEvaluacion
        '
        Me.cmbImprimirEvaluacion.BackColor = System.Drawing.Color.Gainsboro
        Me.cmbImprimirEvaluacion.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmbImprimirEvaluacion.FlatAppearance.BorderSize = 0
        Me.cmbImprimirEvaluacion.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.cmbImprimirEvaluacion.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.cmbImprimirEvaluacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbImprimirEvaluacion.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.cmbImprimirEvaluacion.Location = New System.Drawing.Point(790, 4)
        Me.cmbImprimirEvaluacion.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbImprimirEvaluacion.Name = "cmbImprimirEvaluacion"
        Me.cmbImprimirEvaluacion.Size = New System.Drawing.Size(195, 81)
        Me.cmbImprimirEvaluacion.TabIndex = 34
        Me.cmbImprimirEvaluacion.Text = "Reporte Evaluación de Riesgo"
        Me.cmbImprimirEvaluacion.UseVisualStyleBackColor = False
        Me.cmbImprimirEvaluacion.Visible = False
        '
        'cbMapaRiesgoDpto
        '
        Me.cbMapaRiesgoDpto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMapaRiesgoDpto.FormattingEnabled = True
        Me.cbMapaRiesgoDpto.Location = New System.Drawing.Point(193, 93)
        Me.cbMapaRiesgoDpto.Margin = New System.Windows.Forms.Padding(4)
        Me.cbMapaRiesgoDpto.Name = "cbMapaRiesgoDpto"
        Me.cbMapaRiesgoDpto.Size = New System.Drawing.Size(550, 38)
        Me.cbMapaRiesgoDpto.TabIndex = 33
        '
        'TabPageProbabilidadOcurencia
        '
        Me.TabPageProbabilidadOcurencia.Controls.Add(Me.TableLayoutPanel9)
        Me.TabPageProbabilidadOcurencia.Location = New System.Drawing.Point(4, 39)
        Me.TabPageProbabilidadOcurencia.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPageProbabilidadOcurencia.Name = "TabPageProbabilidadOcurencia"
        Me.TabPageProbabilidadOcurencia.Size = New System.Drawing.Size(1023, 556)
        Me.TabPageProbabilidadOcurencia.TabIndex = 11
        Me.TabPageProbabilidadOcurencia.Text = "Probabilidad de Ocurrencia"
        Me.TabPageProbabilidadOcurencia.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel9
        '
        Me.TableLayoutPanel9.ColumnCount = 1
        Me.TableLayoutPanel9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel9.Controls.Add(Me.DG_Probabilidad, 0, 1)
        Me.TableLayoutPanel9.Controls.Add(Me.FlowLayoutPanel11, 0, 0)
        Me.TableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel9.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel9.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel9.Name = "TableLayoutPanel9"
        Me.TableLayoutPanel9.RowCount = 2
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 92.0!))
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel9.Size = New System.Drawing.Size(1023, 556)
        Me.TableLayoutPanel9.TabIndex = 15
        '
        'DG_Probabilidad
        '
        Me.DG_Probabilidad.AllowUserToAddRows = False
        Me.DG_Probabilidad.AllowUserToDeleteRows = False
        Me.DG_Probabilidad.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DG_Probabilidad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_Probabilidad.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID_ProbabilityOccurrence, Me.Probability, Me.DescriptionProbabilidad, Me.DataGridViewTextBoxColumn64, Me.DataGridViewTextBoxColumn65, Me.DataGridViewTextBoxColumn66, Me.DataGridViewTextBoxColumn67, Me.DataGridViewTextBoxColumn68, Me.DataGridViewTextBoxColumn69})
        Me.DG_Probabilidad.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DG_Probabilidad.EnableHeadersVisualStyles = False
        Me.DG_Probabilidad.Location = New System.Drawing.Point(4, 96)
        Me.DG_Probabilidad.Margin = New System.Windows.Forms.Padding(4)
        Me.DG_Probabilidad.Name = "DG_Probabilidad"
        Me.DG_Probabilidad.ReadOnly = True
        Me.DG_Probabilidad.ShowCellErrors = False
        Me.DG_Probabilidad.ShowCellToolTips = False
        Me.DG_Probabilidad.ShowEditingIcon = False
        Me.DG_Probabilidad.ShowRowErrors = False
        Me.DG_Probabilidad.Size = New System.Drawing.Size(1015, 456)
        Me.DG_Probabilidad.TabIndex = 0
        '
        'ID_ProbabilityOccurrence
        '
        Me.ID_ProbabilityOccurrence.DataPropertyName = "ID_ProbabilityOccurrence"
        Me.ID_ProbabilityOccurrence.HeaderText = "ID"
        Me.ID_ProbabilityOccurrence.Name = "ID_ProbabilityOccurrence"
        Me.ID_ProbabilityOccurrence.ReadOnly = True
        Me.ID_ProbabilityOccurrence.Visible = False
        Me.ID_ProbabilityOccurrence.Width = 89
        '
        'Probability
        '
        Me.Probability.DataPropertyName = "Probability"
        Me.Probability.HeaderText = "Probabilidad"
        Me.Probability.Name = "Probability"
        Me.Probability.ReadOnly = True
        Me.Probability.Width = 89
        '
        'DescriptionProbabilidad
        '
        Me.DescriptionProbabilidad.DataPropertyName = "Description"
        Me.DescriptionProbabilidad.HeaderText = "Descripción"
        Me.DescriptionProbabilidad.Name = "DescriptionProbabilidad"
        Me.DescriptionProbabilidad.ReadOnly = True
        '
        'DataGridViewTextBoxColumn64
        '
        Me.DataGridViewTextBoxColumn64.DataPropertyName = "UsersCreate"
        Me.DataGridViewTextBoxColumn64.HeaderText = "Usuario Creo"
        Me.DataGridViewTextBoxColumn64.Name = "DataGridViewTextBoxColumn64"
        Me.DataGridViewTextBoxColumn64.ReadOnly = True
        Me.DataGridViewTextBoxColumn64.Width = 89
        '
        'DataGridViewTextBoxColumn65
        '
        Me.DataGridViewTextBoxColumn65.DataPropertyName = "DateCreate"
        Me.DataGridViewTextBoxColumn65.HeaderText = "Fecha Creo"
        Me.DataGridViewTextBoxColumn65.Name = "DataGridViewTextBoxColumn65"
        Me.DataGridViewTextBoxColumn65.ReadOnly = True
        Me.DataGridViewTextBoxColumn65.Width = 89
        '
        'DataGridViewTextBoxColumn66
        '
        Me.DataGridViewTextBoxColumn66.DataPropertyName = "UsersModify"
        Me.DataGridViewTextBoxColumn66.HeaderText = "Usuario Mod."
        Me.DataGridViewTextBoxColumn66.Name = "DataGridViewTextBoxColumn66"
        Me.DataGridViewTextBoxColumn66.ReadOnly = True
        '
        'DataGridViewTextBoxColumn67
        '
        Me.DataGridViewTextBoxColumn67.DataPropertyName = "DateModify"
        Me.DataGridViewTextBoxColumn67.HeaderText = "Fecha Mod."
        Me.DataGridViewTextBoxColumn67.Name = "DataGridViewTextBoxColumn67"
        Me.DataGridViewTextBoxColumn67.ReadOnly = True
        '
        'DataGridViewTextBoxColumn68
        '
        Me.DataGridViewTextBoxColumn68.HeaderText = "id_Company_FK"
        Me.DataGridViewTextBoxColumn68.Name = "DataGridViewTextBoxColumn68"
        Me.DataGridViewTextBoxColumn68.ReadOnly = True
        Me.DataGridViewTextBoxColumn68.Visible = False
        '
        'DataGridViewTextBoxColumn69
        '
        Me.DataGridViewTextBoxColumn69.DataPropertyName = "estado"
        Me.DataGridViewTextBoxColumn69.HeaderText = "Estado"
        Me.DataGridViewTextBoxColumn69.Name = "DataGridViewTextBoxColumn69"
        Me.DataGridViewTextBoxColumn69.ReadOnly = True
        '
        'FlowLayoutPanel11
        '
        Me.FlowLayoutPanel11.Controls.Add(Me.cmdAgregarProbabilidad)
        Me.FlowLayoutPanel11.Controls.Add(Me.cmdModificarProbabilidad)
        Me.FlowLayoutPanel11.Controls.Add(Me.cmdEliminarProbabilidad)
        Me.FlowLayoutPanel11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel11.Location = New System.Drawing.Point(4, 4)
        Me.FlowLayoutPanel11.Margin = New System.Windows.Forms.Padding(4)
        Me.FlowLayoutPanel11.Name = "FlowLayoutPanel11"
        Me.FlowLayoutPanel11.Size = New System.Drawing.Size(1015, 84)
        Me.FlowLayoutPanel11.TabIndex = 1
        '
        'cmdAgregarProbabilidad
        '
        Me.cmdAgregarProbabilidad.BackColor = System.Drawing.Color.Gainsboro
        Me.cmdAgregarProbabilidad.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdAgregarProbabilidad.FlatAppearance.BorderSize = 0
        Me.cmdAgregarProbabilidad.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.cmdAgregarProbabilidad.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.cmdAgregarProbabilidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAgregarProbabilidad.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAgregarProbabilidad.Location = New System.Drawing.Point(4, 4)
        Me.cmdAgregarProbabilidad.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdAgregarProbabilidad.Name = "cmdAgregarProbabilidad"
        Me.cmdAgregarProbabilidad.Size = New System.Drawing.Size(227, 81)
        Me.cmdAgregarProbabilidad.TabIndex = 30
        Me.cmdAgregarProbabilidad.Text = "Agregar Probabilidad Ocurrencia"
        Me.cmdAgregarProbabilidad.UseVisualStyleBackColor = False
        Me.cmdAgregarProbabilidad.Visible = False
        '
        'cmdModificarProbabilidad
        '
        Me.cmdModificarProbabilidad.BackColor = System.Drawing.Color.Gainsboro
        Me.cmdModificarProbabilidad.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdModificarProbabilidad.FlatAppearance.BorderSize = 0
        Me.cmdModificarProbabilidad.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.cmdModificarProbabilidad.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.cmdModificarProbabilidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdModificarProbabilidad.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdModificarProbabilidad.Location = New System.Drawing.Point(239, 4)
        Me.cmdModificarProbabilidad.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdModificarProbabilidad.Name = "cmdModificarProbabilidad"
        Me.cmdModificarProbabilidad.Size = New System.Drawing.Size(235, 81)
        Me.cmdModificarProbabilidad.TabIndex = 30
        Me.cmdModificarProbabilidad.Text = "Modificar Probabilidad Ocurencia"
        Me.cmdModificarProbabilidad.UseVisualStyleBackColor = False
        Me.cmdModificarProbabilidad.Visible = False
        '
        'cmdEliminarProbabilidad
        '
        Me.cmdEliminarProbabilidad.BackColor = System.Drawing.Color.Gainsboro
        Me.cmdEliminarProbabilidad.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdEliminarProbabilidad.FlatAppearance.BorderSize = 0
        Me.cmdEliminarProbabilidad.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.cmdEliminarProbabilidad.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.cmdEliminarProbabilidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdEliminarProbabilidad.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEliminarProbabilidad.Location = New System.Drawing.Point(482, 4)
        Me.cmdEliminarProbabilidad.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdEliminarProbabilidad.Name = "cmdEliminarProbabilidad"
        Me.cmdEliminarProbabilidad.Size = New System.Drawing.Size(227, 81)
        Me.cmdEliminarProbabilidad.TabIndex = 30
        Me.cmdEliminarProbabilidad.Text = "Eliminar Probabilidad Ocurencia"
        Me.cmdEliminarProbabilidad.UseVisualStyleBackColor = False
        Me.cmdEliminarProbabilidad.Visible = False
        '
        'TabPageGradoImpacto
        '
        Me.TabPageGradoImpacto.Controls.Add(Me.TableLayoutPanel10)
        Me.TabPageGradoImpacto.Location = New System.Drawing.Point(4, 39)
        Me.TabPageGradoImpacto.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPageGradoImpacto.Name = "TabPageGradoImpacto"
        Me.TabPageGradoImpacto.Size = New System.Drawing.Size(1023, 556)
        Me.TabPageGradoImpacto.TabIndex = 12
        Me.TabPageGradoImpacto.Text = "Grado de Impacto"
        Me.TabPageGradoImpacto.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel10
        '
        Me.TableLayoutPanel10.ColumnCount = 1
        Me.TableLayoutPanel10.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel10.Controls.Add(Me.DG_ImpactGrade, 0, 1)
        Me.TableLayoutPanel10.Controls.Add(Me.FlowLayoutPanel12, 0, 0)
        Me.TableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel10.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel10.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel10.Name = "TableLayoutPanel10"
        Me.TableLayoutPanel10.RowCount = 2
        Me.TableLayoutPanel10.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 92.0!))
        Me.TableLayoutPanel10.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel10.Size = New System.Drawing.Size(1023, 556)
        Me.TableLayoutPanel10.TabIndex = 15
        '
        'DG_ImpactGrade
        '
        Me.DG_ImpactGrade.AllowUserToAddRows = False
        Me.DG_ImpactGrade.AllowUserToDeleteRows = False
        Me.DG_ImpactGrade.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DG_ImpactGrade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_ImpactGrade.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID_ImpactGrade, Me.ProbabilityImpacto, Me.DescriptionImpacto, Me.DataGridViewTextBoxColumn74, Me.DataGridViewTextBoxColumn75, Me.DataGridViewTextBoxColumn76, Me.DataGridViewTextBoxColumn77, Me.DataGridViewTextBoxColumn78, Me.DataGridViewTextBoxColumn79})
        Me.DG_ImpactGrade.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DG_ImpactGrade.EnableHeadersVisualStyles = False
        Me.DG_ImpactGrade.Location = New System.Drawing.Point(4, 96)
        Me.DG_ImpactGrade.Margin = New System.Windows.Forms.Padding(4)
        Me.DG_ImpactGrade.Name = "DG_ImpactGrade"
        Me.DG_ImpactGrade.ReadOnly = True
        Me.DG_ImpactGrade.ShowCellErrors = False
        Me.DG_ImpactGrade.ShowCellToolTips = False
        Me.DG_ImpactGrade.ShowEditingIcon = False
        Me.DG_ImpactGrade.ShowRowErrors = False
        Me.DG_ImpactGrade.Size = New System.Drawing.Size(1015, 456)
        Me.DG_ImpactGrade.TabIndex = 0
        '
        'ID_ImpactGrade
        '
        Me.ID_ImpactGrade.DataPropertyName = "ID_ImpactGrade"
        Me.ID_ImpactGrade.HeaderText = "ID"
        Me.ID_ImpactGrade.Name = "ID_ImpactGrade"
        Me.ID_ImpactGrade.ReadOnly = True
        Me.ID_ImpactGrade.Visible = False
        Me.ID_ImpactGrade.Width = 89
        '
        'ProbabilityImpacto
        '
        Me.ProbabilityImpacto.DataPropertyName = "Probability"
        Me.ProbabilityImpacto.HeaderText = "Probabilidad"
        Me.ProbabilityImpacto.Name = "ProbabilityImpacto"
        Me.ProbabilityImpacto.ReadOnly = True
        Me.ProbabilityImpacto.Width = 89
        '
        'DescriptionImpacto
        '
        Me.DescriptionImpacto.DataPropertyName = "Description"
        Me.DescriptionImpacto.HeaderText = "Descripcion"
        Me.DescriptionImpacto.Name = "DescriptionImpacto"
        Me.DescriptionImpacto.ReadOnly = True
        '
        'DataGridViewTextBoxColumn74
        '
        Me.DataGridViewTextBoxColumn74.DataPropertyName = "UsersCreate"
        Me.DataGridViewTextBoxColumn74.HeaderText = "Usuario Creo"
        Me.DataGridViewTextBoxColumn74.Name = "DataGridViewTextBoxColumn74"
        Me.DataGridViewTextBoxColumn74.ReadOnly = True
        Me.DataGridViewTextBoxColumn74.Width = 89
        '
        'DataGridViewTextBoxColumn75
        '
        Me.DataGridViewTextBoxColumn75.DataPropertyName = "DateCreate"
        Me.DataGridViewTextBoxColumn75.HeaderText = "Fecha Creo"
        Me.DataGridViewTextBoxColumn75.Name = "DataGridViewTextBoxColumn75"
        Me.DataGridViewTextBoxColumn75.ReadOnly = True
        Me.DataGridViewTextBoxColumn75.Width = 89
        '
        'DataGridViewTextBoxColumn76
        '
        Me.DataGridViewTextBoxColumn76.DataPropertyName = "UsersModify"
        Me.DataGridViewTextBoxColumn76.HeaderText = "Usuario Mod."
        Me.DataGridViewTextBoxColumn76.Name = "DataGridViewTextBoxColumn76"
        Me.DataGridViewTextBoxColumn76.ReadOnly = True
        '
        'DataGridViewTextBoxColumn77
        '
        Me.DataGridViewTextBoxColumn77.DataPropertyName = "DateModify"
        Me.DataGridViewTextBoxColumn77.HeaderText = "Fecha Mod."
        Me.DataGridViewTextBoxColumn77.Name = "DataGridViewTextBoxColumn77"
        Me.DataGridViewTextBoxColumn77.ReadOnly = True
        '
        'DataGridViewTextBoxColumn78
        '
        Me.DataGridViewTextBoxColumn78.HeaderText = "id_Company_FK"
        Me.DataGridViewTextBoxColumn78.Name = "DataGridViewTextBoxColumn78"
        Me.DataGridViewTextBoxColumn78.ReadOnly = True
        Me.DataGridViewTextBoxColumn78.Visible = False
        '
        'DataGridViewTextBoxColumn79
        '
        Me.DataGridViewTextBoxColumn79.DataPropertyName = "estado"
        Me.DataGridViewTextBoxColumn79.HeaderText = "Estado"
        Me.DataGridViewTextBoxColumn79.Name = "DataGridViewTextBoxColumn79"
        Me.DataGridViewTextBoxColumn79.ReadOnly = True
        '
        'FlowLayoutPanel12
        '
        Me.FlowLayoutPanel12.Controls.Add(Me.cmdImpacto)
        Me.FlowLayoutPanel12.Controls.Add(Me.cmdModificarImpacto)
        Me.FlowLayoutPanel12.Controls.Add(Me.cmdEliminarImpacto)
        Me.FlowLayoutPanel12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel12.Location = New System.Drawing.Point(4, 4)
        Me.FlowLayoutPanel12.Margin = New System.Windows.Forms.Padding(4)
        Me.FlowLayoutPanel12.Name = "FlowLayoutPanel12"
        Me.FlowLayoutPanel12.Size = New System.Drawing.Size(1015, 84)
        Me.FlowLayoutPanel12.TabIndex = 1
        '
        'cmdImpacto
        '
        Me.cmdImpacto.BackColor = System.Drawing.Color.Gainsboro
        Me.cmdImpacto.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdImpacto.FlatAppearance.BorderSize = 0
        Me.cmdImpacto.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.cmdImpacto.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.cmdImpacto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdImpacto.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdImpacto.Location = New System.Drawing.Point(4, 4)
        Me.cmdImpacto.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdImpacto.Name = "cmdImpacto"
        Me.cmdImpacto.Size = New System.Drawing.Size(191, 81)
        Me.cmdImpacto.TabIndex = 30
        Me.cmdImpacto.Text = "Agregar Grado Impacto"
        Me.cmdImpacto.UseVisualStyleBackColor = False
        Me.cmdImpacto.Visible = False
        '
        'cmdModificarImpacto
        '
        Me.cmdModificarImpacto.BackColor = System.Drawing.Color.Gainsboro
        Me.cmdModificarImpacto.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdModificarImpacto.FlatAppearance.BorderSize = 0
        Me.cmdModificarImpacto.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.cmdModificarImpacto.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.cmdModificarImpacto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdModificarImpacto.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdModificarImpacto.Location = New System.Drawing.Point(203, 4)
        Me.cmdModificarImpacto.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdModificarImpacto.Name = "cmdModificarImpacto"
        Me.cmdModificarImpacto.Size = New System.Drawing.Size(201, 81)
        Me.cmdModificarImpacto.TabIndex = 30
        Me.cmdModificarImpacto.Text = "ModificarGrado Impacto"
        Me.cmdModificarImpacto.UseVisualStyleBackColor = False
        Me.cmdModificarImpacto.Visible = False
        '
        'cmdEliminarImpacto
        '
        Me.cmdEliminarImpacto.BackColor = System.Drawing.Color.Gainsboro
        Me.cmdEliminarImpacto.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdEliminarImpacto.FlatAppearance.BorderSize = 0
        Me.cmdEliminarImpacto.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.cmdEliminarImpacto.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.cmdEliminarImpacto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdEliminarImpacto.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEliminarImpacto.Location = New System.Drawing.Point(412, 4)
        Me.cmdEliminarImpacto.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdEliminarImpacto.Name = "cmdEliminarImpacto"
        Me.cmdEliminarImpacto.Size = New System.Drawing.Size(187, 81)
        Me.cmdEliminarImpacto.TabIndex = 30
        Me.cmdEliminarImpacto.Text = "Eliminar Grado Impacto"
        Me.cmdEliminarImpacto.UseVisualStyleBackColor = False
        Me.cmdEliminarImpacto.Visible = False
        '
        'TabPageResponsableMapa
        '
        Me.TabPageResponsableMapa.Controls.Add(Me.TableLayoutPanel3)
        Me.TabPageResponsableMapa.Location = New System.Drawing.Point(4, 39)
        Me.TabPageResponsableMapa.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPageResponsableMapa.Name = "TabPageResponsableMapa"
        Me.TabPageResponsableMapa.Size = New System.Drawing.Size(1023, 556)
        Me.TabPageResponsableMapa.TabIndex = 13
        Me.TabPageResponsableMapa.Text = "Responsable Mapa"
        Me.TabPageResponsableMapa.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.DG_ResponsableEjecucionMapa, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.FlowLayoutPanel4, 0, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel3.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 99.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(1023, 556)
        Me.TableLayoutPanel3.TabIndex = 11
        '
        'DG_ResponsableEjecucionMapa
        '
        Me.DG_ResponsableEjecucionMapa.AllowUserToAddRows = False
        Me.DG_ResponsableEjecucionMapa.AllowUserToDeleteRows = False
        Me.DG_ResponsableEjecucionMapa.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DG_ResponsableEjecucionMapa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_ResponsableEjecucionMapa.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID_ResponsibleMapRisk, Me.NameResponsableEjecucion, Me.DescriptionResponsableEjecucion, Me.DataGridViewTextBoxColumn23, Me.DataGridViewTextBoxColumn24, Me.DataGridViewTextBoxColumn25, Me.DataGridViewTextBoxColumn26, Me.DataGridViewTextBoxColumn27, Me.DataGridViewTextBoxColumn28})
        Me.DG_ResponsableEjecucionMapa.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DG_ResponsableEjecucionMapa.EnableHeadersVisualStyles = False
        Me.DG_ResponsableEjecucionMapa.Location = New System.Drawing.Point(4, 103)
        Me.DG_ResponsableEjecucionMapa.Margin = New System.Windows.Forms.Padding(4)
        Me.DG_ResponsableEjecucionMapa.Name = "DG_ResponsableEjecucionMapa"
        Me.DG_ResponsableEjecucionMapa.ReadOnly = True
        Me.DG_ResponsableEjecucionMapa.ShowCellErrors = False
        Me.DG_ResponsableEjecucionMapa.ShowCellToolTips = False
        Me.DG_ResponsableEjecucionMapa.ShowEditingIcon = False
        Me.DG_ResponsableEjecucionMapa.ShowRowErrors = False
        Me.DG_ResponsableEjecucionMapa.Size = New System.Drawing.Size(1015, 449)
        Me.DG_ResponsableEjecucionMapa.TabIndex = 0
        '
        'ID_ResponsibleMapRisk
        '
        Me.ID_ResponsibleMapRisk.DataPropertyName = "ID_ResponsibleMapRisk"
        Me.ID_ResponsibleMapRisk.HeaderText = "ID"
        Me.ID_ResponsibleMapRisk.Name = "ID_ResponsibleMapRisk"
        Me.ID_ResponsibleMapRisk.ReadOnly = True
        Me.ID_ResponsibleMapRisk.Width = 89
        '
        'NameResponsableEjecucion
        '
        Me.NameResponsableEjecucion.DataPropertyName = "Name"
        Me.NameResponsableEjecucion.HeaderText = "Responsable Ejecucion"
        Me.NameResponsableEjecucion.Name = "NameResponsableEjecucion"
        Me.NameResponsableEjecucion.ReadOnly = True
        Me.NameResponsableEjecucion.Width = 89
        '
        'DescriptionResponsableEjecucion
        '
        Me.DescriptionResponsableEjecucion.DataPropertyName = "Description"
        Me.DescriptionResponsableEjecucion.HeaderText = "Descripcion"
        Me.DescriptionResponsableEjecucion.Name = "DescriptionResponsableEjecucion"
        Me.DescriptionResponsableEjecucion.ReadOnly = True
        Me.DescriptionResponsableEjecucion.Visible = False
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "UsersCreate"
        Me.DataGridViewTextBoxColumn23.HeaderText = "Usuario Creo"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        Me.DataGridViewTextBoxColumn23.ReadOnly = True
        Me.DataGridViewTextBoxColumn23.Width = 89
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.DataPropertyName = "DateCreate"
        Me.DataGridViewTextBoxColumn24.HeaderText = "Fecha Creo"
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        Me.DataGridViewTextBoxColumn24.ReadOnly = True
        Me.DataGridViewTextBoxColumn24.Width = 89
        '
        'DataGridViewTextBoxColumn25
        '
        Me.DataGridViewTextBoxColumn25.DataPropertyName = "UsersModify"
        Me.DataGridViewTextBoxColumn25.HeaderText = "Usuario Mod."
        Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
        Me.DataGridViewTextBoxColumn25.ReadOnly = True
        '
        'DataGridViewTextBoxColumn26
        '
        Me.DataGridViewTextBoxColumn26.DataPropertyName = "DateModify"
        Me.DataGridViewTextBoxColumn26.HeaderText = "Fecha Mod."
        Me.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26"
        Me.DataGridViewTextBoxColumn26.ReadOnly = True
        '
        'DataGridViewTextBoxColumn27
        '
        Me.DataGridViewTextBoxColumn27.HeaderText = "id_Company_FK"
        Me.DataGridViewTextBoxColumn27.Name = "DataGridViewTextBoxColumn27"
        Me.DataGridViewTextBoxColumn27.ReadOnly = True
        Me.DataGridViewTextBoxColumn27.Visible = False
        '
        'DataGridViewTextBoxColumn28
        '
        Me.DataGridViewTextBoxColumn28.DataPropertyName = "estado"
        Me.DataGridViewTextBoxColumn28.HeaderText = "Estado"
        Me.DataGridViewTextBoxColumn28.Name = "DataGridViewTextBoxColumn28"
        Me.DataGridViewTextBoxColumn28.ReadOnly = True
        '
        'FlowLayoutPanel4
        '
        Me.FlowLayoutPanel4.AutoScroll = True
        Me.FlowLayoutPanel4.Controls.Add(Me.cmdAgregarResponsableMapa)
        Me.FlowLayoutPanel4.Controls.Add(Me.cmdModificarResponsableMapa)
        Me.FlowLayoutPanel4.Controls.Add(Me.cmdEliminarResponsableMapa)
        Me.FlowLayoutPanel4.Controls.Add(Me.cbGerenciaResponsableMap)
        Me.FlowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel4.Location = New System.Drawing.Point(4, 4)
        Me.FlowLayoutPanel4.Margin = New System.Windows.Forms.Padding(4)
        Me.FlowLayoutPanel4.Name = "FlowLayoutPanel4"
        Me.FlowLayoutPanel4.Size = New System.Drawing.Size(1015, 91)
        Me.FlowLayoutPanel4.TabIndex = 1
        '
        'cmdAgregarResponsableMapa
        '
        Me.cmdAgregarResponsableMapa.BackColor = System.Drawing.Color.Gainsboro
        Me.cmdAgregarResponsableMapa.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdAgregarResponsableMapa.FlatAppearance.BorderSize = 0
        Me.cmdAgregarResponsableMapa.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.cmdAgregarResponsableMapa.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.cmdAgregarResponsableMapa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAgregarResponsableMapa.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAgregarResponsableMapa.Location = New System.Drawing.Point(4, 4)
        Me.cmdAgregarResponsableMapa.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdAgregarResponsableMapa.Name = "cmdAgregarResponsableMapa"
        Me.cmdAgregarResponsableMapa.Size = New System.Drawing.Size(223, 81)
        Me.cmdAgregarResponsableMapa.TabIndex = 30
        Me.cmdAgregarResponsableMapa.Text = "Agregar Responsable Ejecucion"
        Me.cmdAgregarResponsableMapa.UseVisualStyleBackColor = False
        Me.cmdAgregarResponsableMapa.Visible = False
        '
        'cmdModificarResponsableMapa
        '
        Me.cmdModificarResponsableMapa.BackColor = System.Drawing.Color.Gainsboro
        Me.cmdModificarResponsableMapa.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdModificarResponsableMapa.FlatAppearance.BorderSize = 0
        Me.cmdModificarResponsableMapa.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.cmdModificarResponsableMapa.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.cmdModificarResponsableMapa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdModificarResponsableMapa.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdModificarResponsableMapa.Location = New System.Drawing.Point(235, 4)
        Me.cmdModificarResponsableMapa.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdModificarResponsableMapa.Name = "cmdModificarResponsableMapa"
        Me.cmdModificarResponsableMapa.Size = New System.Drawing.Size(236, 81)
        Me.cmdModificarResponsableMapa.TabIndex = 30
        Me.cmdModificarResponsableMapa.Text = "Modificar Responsable Ejecucion"
        Me.cmdModificarResponsableMapa.UseVisualStyleBackColor = False
        Me.cmdModificarResponsableMapa.Visible = False
        '
        'cmdEliminarResponsableMapa
        '
        Me.cmdEliminarResponsableMapa.BackColor = System.Drawing.Color.Gainsboro
        Me.cmdEliminarResponsableMapa.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdEliminarResponsableMapa.FlatAppearance.BorderSize = 0
        Me.cmdEliminarResponsableMapa.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.cmdEliminarResponsableMapa.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.cmdEliminarResponsableMapa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdEliminarResponsableMapa.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEliminarResponsableMapa.Location = New System.Drawing.Point(479, 4)
        Me.cmdEliminarResponsableMapa.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdEliminarResponsableMapa.Name = "cmdEliminarResponsableMapa"
        Me.cmdEliminarResponsableMapa.Size = New System.Drawing.Size(225, 81)
        Me.cmdEliminarResponsableMapa.TabIndex = 30
        Me.cmdEliminarResponsableMapa.Text = "Eliminar Responsable Ejecucion"
        Me.cmdEliminarResponsableMapa.UseVisualStyleBackColor = False
        Me.cmdEliminarResponsableMapa.Visible = False
        '
        'cbGerenciaResponsableMap
        '
        Me.cbGerenciaResponsableMap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbGerenciaResponsableMap.FormattingEnabled = True
        Me.cbGerenciaResponsableMap.Location = New System.Drawing.Point(4, 93)
        Me.cbGerenciaResponsableMap.Margin = New System.Windows.Forms.Padding(4)
        Me.cbGerenciaResponsableMap.Name = "cbGerenciaResponsableMap"
        Me.cbGerenciaResponsableMap.Size = New System.Drawing.Size(550, 38)
        Me.cbGerenciaResponsableMap.TabIndex = 38
        '
        'btnSubirDocMapa
        '
        Me.btnSubirDocMapa.BackColor = System.Drawing.Color.Gainsboro
        Me.btnSubirDocMapa.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.btnSubirDocMapa.FlatAppearance.BorderSize = 0
        Me.btnSubirDocMapa.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.btnSubirDocMapa.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.btnSubirDocMapa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSubirDocMapa.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubirDocMapa.Location = New System.Drawing.Point(4, 93)
        Me.btnSubirDocMapa.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSubirDocMapa.Name = "btnSubirDocMapa"
        Me.btnSubirDocMapa.Size = New System.Drawing.Size(181, 81)
        Me.btnSubirDocMapa.TabIndex = 49
        Me.btnSubirDocMapa.Text = "Subir Documentos PEI"
        Me.btnSubirDocMapa.UseVisualStyleBackColor = False
        Me.btnSubirDocMapa.Visible = False
        '
        'ModuloMapaRiesgo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.tabMapaRiesgo)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "ModuloMapaRiesgo"
        Me.Size = New System.Drawing.Size(1031, 599)
        Me.tabMapaRiesgo.ResumeLayout(False)
        Me.TabPageMApaRiesgo.ResumeLayout(False)
        Me.TableLayoutPanel11.ResumeLayout(False)
        CType(Me.dgMapaRiesgo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.OpcionesReporte.ResumeLayout(False)
        Me.FlowLayoutPanel13.ResumeLayout(False)
        Me.TabPageProbabilidadOcurencia.ResumeLayout(False)
        Me.TableLayoutPanel9.ResumeLayout(False)
        CType(Me.DG_Probabilidad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel11.ResumeLayout(False)
        Me.TabPageGradoImpacto.ResumeLayout(False)
        Me.TableLayoutPanel10.ResumeLayout(False)
        CType(Me.DG_ImpactGrade, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel12.ResumeLayout(False)
        Me.TabPageResponsableMapa.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        CType(Me.DG_ResponsableEjecucionMapa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tabMapaRiesgo As TabControl
    Friend WithEvents TabPageMApaRiesgo As TabPage
    Friend WithEvents TableLayoutPanel11 As TableLayoutPanel
    Friend WithEvents dgMapaRiesgo As DataGridView
    Friend WithEvents FlowLayoutPanel13 As FlowLayoutPanel
    Private WithEvents cmdMapaRiesgo As Button
    Private WithEvents cmdAgregarMapaRiesgo As Button
    Private WithEvents cmdModificarMApaRiesgo As Button
    Private WithEvents cmdRevaluacionMapaRiesgo As Button
    Private WithEvents cmdImprimirMapa As Button
    Friend WithEvents OpcionesReporte As ContextMenuStrip
    Friend WithEvents ReimprimirReporteDeIngresoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReimprimirReporteDeEvaluaciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents cbMapaRiesgoDpto As ComboBox
    Private WithEvents cmbImprimirEvaluacion As Button
    Friend WithEvents TabPageProbabilidadOcurencia As TabPage
    Friend WithEvents TabPageGradoImpacto As TabPage
    Friend WithEvents TableLayoutPanel10 As TableLayoutPanel
    Friend WithEvents DG_ImpactGrade As DataGridView
    Friend WithEvents FlowLayoutPanel12 As FlowLayoutPanel
    Private WithEvents cmdImpacto As Button
    Private WithEvents cmdModificarImpacto As Button
    Private WithEvents cmdEliminarImpacto As Button
    Friend WithEvents TableLayoutPanel9 As TableLayoutPanel
    Friend WithEvents DG_Probabilidad As DataGridView
    Friend WithEvents FlowLayoutPanel11 As FlowLayoutPanel
    Private WithEvents cmdAgregarProbabilidad As Button
    Private WithEvents cmdModificarProbabilidad As Button
    Private WithEvents cmdEliminarProbabilidad As Button
    Friend WithEvents ID_ProbabilityOccurrence As DataGridViewTextBoxColumn
    Friend WithEvents Probability As DataGridViewTextBoxColumn
    Friend WithEvents DescriptionProbabilidad As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn64 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn65 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn66 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn67 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn68 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn69 As DataGridViewTextBoxColumn
    Friend WithEvents ID_ImpactGrade As DataGridViewTextBoxColumn
    Friend WithEvents ProbabilityImpacto As DataGridViewTextBoxColumn
    Friend WithEvents DescriptionImpacto As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn74 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn75 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn76 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn77 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn78 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn79 As DataGridViewTextBoxColumn
    Friend WithEvents TabPageResponsableMapa As TabPage
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents DG_ResponsableEjecucionMapa As DataGridView
    Friend WithEvents FlowLayoutPanel4 As FlowLayoutPanel
    Private WithEvents cmdAgregarResponsableMapa As Button
    Private WithEvents cmdModificarResponsableMapa As Button
    Private WithEvents cmdEliminarResponsableMapa As Button
    Friend WithEvents cbGerenciaResponsableMap As ComboBox
    Friend WithEvents ID_ResponsibleMapRisk As DataGridViewTextBoxColumn
    Friend WithEvents NameResponsableEjecucion As DataGridViewTextBoxColumn
    Friend WithEvents DescriptionResponsableEjecucion As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn25 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn26 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn27 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn28 As DataGridViewTextBoxColumn
    Friend WithEvents ID_RiskMap As DataGridViewTextBoxColumn
    Friend WithEvents ProcesoMap As DataGridViewTextBoxColumn
    Friend WithEvents ObjetivoMap As DataGridViewTextBoxColumn
    Friend WithEvents DescripcionMap As DataGridViewTextBoxColumn
    Friend WithEvents ProbabilidadMap As DataGridViewTextBoxColumn
    Friend WithEvents ProbabilidadOcurrenciaE As DataGridViewTextBoxColumn
    Friend WithEvents GradoMap As DataGridViewTextBoxColumn
    Friend WithEvents GradoImpactoE As DataGridViewTextBoxColumn
    Friend WithEvents SeveridadMap As DataGridViewTextBoxColumn
    Friend WithEvents SeveridadE As DataGridViewTextBoxColumn
    Friend WithEvents EquipoMap As DataGridViewTextBoxColumn
    Friend WithEvents SeguimientoMap As DataGridViewTextBoxColumn
    Friend WithEvents IndicadorMap As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn70 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn63 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn71 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn72 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn73 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn80 As DataGridViewTextBoxColumn
    Friend WithEvents DptoMap As DataGridViewTextBoxColumn
    Friend WithEvents AnioMap As DataGridViewTextBoxColumn
    Friend WithEvents IdResponsableCMapa As DataGridViewTextBoxColumn
    Friend WithEvents IdResponsableAMapa As DataGridViewTextBoxColumn
    Friend WithEvents IdResponsableCEvaluacion As DataGridViewTextBoxColumn
    Friend WithEvents IdResponsableAEvaluacion As DataGridViewTextBoxColumn
    Private WithEvents btnSubirDocMapa As Button
End Class
