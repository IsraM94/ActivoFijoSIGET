<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Operaciones_Produccion
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
		Me.GrupoAnimales = New System.Windows.Forms.TabPage()
		Me.TLPAnimalGroups = New System.Windows.Forms.TableLayoutPanel()
		Me.DGVAnimalGroup = New System.Windows.Forms.DataGridView()
		Me.Id_Group = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Description = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.DataGridViewTextBoxColumn28 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.DataGridViewTextBoxColumn29 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.DataGridViewTextBoxColumn34 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.FlowLayoutPanel9 = New System.Windows.Forms.FlowLayoutPanel()
		Me.cmdCreate_AnimalGroup = New System.Windows.Forms.Button()
		Me.cmdUpdate_AnimalGroup = New System.Windows.Forms.Button()
		Me.cmdDel_AnimalGroup = New System.Windows.Forms.Button()
		Me.OrigenAnimal = New System.Windows.Forms.TabPage()
		Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
		Me.DGW_Origin = New System.Windows.Forms.DataGridView()
		Me.Id_Origin = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Origin_Name = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.DataGridViewTextBoxColumn30 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.DataGridViewTextBoxColumn31 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.DataGridViewTextBoxColumn32 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.DataGridViewTextBoxColumn33 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.FlowLayoutPanel8 = New System.Windows.Forms.FlowLayoutPanel()
		Me.cmdCreate_Origin = New System.Windows.Forms.Button()
		Me.cmdUpdate_Origin = New System.Windows.Forms.Button()
		Me.cmdDel_Origin = New System.Windows.Forms.Button()
		Me.TipoOrigen = New System.Windows.Forms.TabPage()
		Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
		Me.DGW_OriginType = New System.Windows.Forms.DataGridView()
		Me.Id_TypeOrigin = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.TypeOrigin_Name = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.DataGridViewTextBoxColumn25 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.DataGridViewTextBoxColumn26 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.FlowLayoutPanel7 = New System.Windows.Forms.FlowLayoutPanel()
		Me.cmdCreate_TypeOrigin = New System.Windows.Forms.Button()
		Me.cmdUpdate_TypeOrigin = New System.Windows.Forms.Button()
		Me.cmdDel_TypeOrigin = New System.Windows.Forms.Button()
		Me.Genetica = New System.Windows.Forms.TabPage()
		Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
		Me.DGW_Genetic = New System.Windows.Forms.DataGridView()
		Me.id_Genetica = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Genetic_Name = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Create_User = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.DataGridViewTextBoxColumn27 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.UserModify = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Modify_User = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.FlowLayoutPanel6 = New System.Windows.Forms.FlowLayoutPanel()
		Me.cmdCreate_GeneticaAnimals = New System.Windows.Forms.Button()
		Me.cmdUpdate_GeneticaAnimals = New System.Windows.Forms.Button()
		Me.cmdDel_GeneticaAnimals = New System.Windows.Forms.Button()
		Me.DescargaProductos = New System.Windows.Forms.TabPage()
		Me.TLP_PendientesDescarga = New System.Windows.Forms.TableLayoutPanel()
		Me.DGW_DescargaProductos = New System.Windows.Forms.DataGridView()
		Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.FlowLayoutPanel5 = New System.Windows.Forms.FlowLayoutPanel()
		Me.cmdPendienteDescarga_PasarInventario = New System.Windows.Forms.Button()
		Me.Animales = New System.Windows.Forms.TabPage()
		Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
		Me.DGVAnimals = New System.Windows.Forms.DataGridView()
		Me.FlowLayoutPanel4 = New System.Windows.Forms.FlowLayoutPanel()
		Me.Button14 = New System.Windows.Forms.Button()
		Me.Button15 = New System.Windows.Forms.Button()
		Me.btnEliminar = New System.Windows.Forms.Button()
		Me.StatusDiasVacio = New System.Windows.Forms.TabPage()
		Me.FLStatusDiasVacio = New System.Windows.Forms.FlowLayoutPanel()
		Me.Lista_Productos_proceso = New System.Windows.Forms.TabPage()
		Me.TLP_Facturacion = New System.Windows.Forms.TableLayoutPanel()
		Me.DGW_ProductsProcess = New System.Windows.Forms.DataGridView()
		Me.Correlativo = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.BusinessDay = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Commercial_Name = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Fullpayment = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.semana = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.DocumentNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Date_EndProject = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.UsuarioAnulo = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.IdProceso = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Id_Circle = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Id_CicloRef = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.IS_StageAlarm = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.ID_Product_FK = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
		Me.cmdCreateLote = New System.Windows.Forms.Button()
		Me.cmdModLote = New System.Windows.Forms.Button()
		Me.cmdCatalogoClienteFinanciero = New System.Windows.Forms.Button()
		Me.cmdCatalogoClienteFinancieroSeleccion = New System.Windows.Forms.Button()
		Me.cmdReporteProveedores = New System.Windows.Forms.Button()
		Me.btnFormDinamico = New System.Windows.Forms.Button()
		Me.cmdReportGeneral = New System.Windows.Forms.Button()
		Me.cmdOutPut = New System.Windows.Forms.Button()
		Me.Button16 = New System.Windows.Forms.Button()
		Me.VistaGeneral = New System.Windows.Forms.TabPage()
		Me.gbStudentDetails = New System.Windows.Forms.GroupBox()
		Me.FLIndicators = New System.Windows.Forms.FlowLayoutPanel()
		Me.tcMain = New System.Windows.Forms.TabControl()
		Me.GrupoAnimales.SuspendLayout()
		Me.TLPAnimalGroups.SuspendLayout()
		CType(Me.DGVAnimalGroup, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.FlowLayoutPanel9.SuspendLayout()
		Me.OrigenAnimal.SuspendLayout()
		Me.TableLayoutPanel4.SuspendLayout()
		CType(Me.DGW_Origin, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.FlowLayoutPanel8.SuspendLayout()
		Me.TipoOrigen.SuspendLayout()
		Me.TableLayoutPanel3.SuspendLayout()
		CType(Me.DGW_OriginType, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.FlowLayoutPanel7.SuspendLayout()
		Me.Genetica.SuspendLayout()
		Me.TableLayoutPanel2.SuspendLayout()
		CType(Me.DGW_Genetic, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.FlowLayoutPanel6.SuspendLayout()
		Me.DescargaProductos.SuspendLayout()
		Me.TLP_PendientesDescarga.SuspendLayout()
		CType(Me.DGW_DescargaProductos, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.FlowLayoutPanel5.SuspendLayout()
		Me.Animales.SuspendLayout()
		Me.TableLayoutPanel1.SuspendLayout()
		CType(Me.DGVAnimals, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.FlowLayoutPanel4.SuspendLayout()
		Me.StatusDiasVacio.SuspendLayout()
		Me.Lista_Productos_proceso.SuspendLayout()
		Me.TLP_Facturacion.SuspendLayout()
		CType(Me.DGW_ProductsProcess, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.FlowLayoutPanel1.SuspendLayout()
		Me.VistaGeneral.SuspendLayout()
		Me.gbStudentDetails.SuspendLayout()
		Me.tcMain.SuspendLayout()
		Me.SuspendLayout()
		'
		'GrupoAnimales
		'
		Me.GrupoAnimales.Controls.Add(Me.TLPAnimalGroups)
		Me.GrupoAnimales.Location = New System.Drawing.Point(4, 35)
		Me.GrupoAnimales.Name = "GrupoAnimales"
		Me.GrupoAnimales.Size = New System.Drawing.Size(1087, 540)
		Me.GrupoAnimales.TabIndex = 13
		Me.GrupoAnimales.Text = "Grupo Animales"
		Me.GrupoAnimales.UseVisualStyleBackColor = True
		'
		'TLPAnimalGroups
		'
		Me.TLPAnimalGroups.ColumnCount = 1
		Me.TLPAnimalGroups.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TLPAnimalGroups.Controls.Add(Me.DGVAnimalGroup, 0, 1)
		Me.TLPAnimalGroups.Controls.Add(Me.FlowLayoutPanel9, 0, 0)
		Me.TLPAnimalGroups.Dock = System.Windows.Forms.DockStyle.Fill
		Me.TLPAnimalGroups.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TLPAnimalGroups.Location = New System.Drawing.Point(0, 0)
		Me.TLPAnimalGroups.Name = "TLPAnimalGroups"
		Me.TLPAnimalGroups.RowCount = 2
		Me.TLPAnimalGroups.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 81.0!))
		Me.TLPAnimalGroups.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TLPAnimalGroups.Size = New System.Drawing.Size(1087, 540)
		Me.TLPAnimalGroups.TabIndex = 7
		'
		'DGVAnimalGroup
		'
		Me.DGVAnimalGroup.AllowUserToAddRows = False
		Me.DGVAnimalGroup.AllowUserToDeleteRows = False
		Me.DGVAnimalGroup.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
		Me.DGVAnimalGroup.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.DGVAnimalGroup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
		Me.DGVAnimalGroup.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id_Group, Me.Description, Me.DataGridViewTextBoxColumn22, Me.DataGridViewTextBoxColumn28, Me.DataGridViewTextBoxColumn29, Me.DataGridViewTextBoxColumn34})
		Me.DGVAnimalGroup.Dock = System.Windows.Forms.DockStyle.Fill
		Me.DGVAnimalGroup.EnableHeadersVisualStyles = False
		Me.DGVAnimalGroup.Location = New System.Drawing.Point(3, 84)
		Me.DGVAnimalGroup.Name = "DGVAnimalGroup"
		Me.DGVAnimalGroup.ReadOnly = True
		Me.DGVAnimalGroup.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
		Me.DGVAnimalGroup.RowHeadersVisible = False
		Me.DGVAnimalGroup.RowHeadersWidth = 50
		Me.DGVAnimalGroup.ShowCellErrors = False
		Me.DGVAnimalGroup.ShowCellToolTips = False
		Me.DGVAnimalGroup.ShowEditingIcon = False
		Me.DGVAnimalGroup.ShowRowErrors = False
		Me.DGVAnimalGroup.Size = New System.Drawing.Size(1081, 453)
		Me.DGVAnimalGroup.TabIndex = 3
		'
		'Id_Group
		'
		Me.Id_Group.DataPropertyName = "Id_Group"
		Me.Id_Group.HeaderText = "Correlativo"
		Me.Id_Group.Name = "Id_Group"
		Me.Id_Group.ReadOnly = True
		'
		'Description
		'
		Me.Description.DataPropertyName = "Descripction"
		Me.Description.HeaderText = "Descripción Grupo Animal"
		Me.Description.Name = "Description"
		Me.Description.ReadOnly = True
		'
		'DataGridViewTextBoxColumn22
		'
		Me.DataGridViewTextBoxColumn22.DataPropertyName = "Create_Users"
		Me.DataGridViewTextBoxColumn22.HeaderText = "Usuario Creó"
		Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
		Me.DataGridViewTextBoxColumn22.ReadOnly = True
		'
		'DataGridViewTextBoxColumn28
		'
		Me.DataGridViewTextBoxColumn28.DataPropertyName = "Create_Date"
		Me.DataGridViewTextBoxColumn28.HeaderText = "Fecha Creó"
		Me.DataGridViewTextBoxColumn28.Name = "DataGridViewTextBoxColumn28"
		Me.DataGridViewTextBoxColumn28.ReadOnly = True
		'
		'DataGridViewTextBoxColumn29
		'
		Me.DataGridViewTextBoxColumn29.DataPropertyName = "Modify_Users"
		Me.DataGridViewTextBoxColumn29.HeaderText = "Usuario Modificó"
		Me.DataGridViewTextBoxColumn29.Name = "DataGridViewTextBoxColumn29"
		Me.DataGridViewTextBoxColumn29.ReadOnly = True
		'
		'DataGridViewTextBoxColumn34
		'
		Me.DataGridViewTextBoxColumn34.DataPropertyName = "Modify_Date"
		Me.DataGridViewTextBoxColumn34.HeaderText = "Fecha Modificó"
		Me.DataGridViewTextBoxColumn34.Name = "DataGridViewTextBoxColumn34"
		Me.DataGridViewTextBoxColumn34.ReadOnly = True
		'
		'FlowLayoutPanel9
		'
		Me.FlowLayoutPanel9.Controls.Add(Me.cmdCreate_AnimalGroup)
		Me.FlowLayoutPanel9.Controls.Add(Me.cmdUpdate_AnimalGroup)
		Me.FlowLayoutPanel9.Controls.Add(Me.cmdDel_AnimalGroup)
		Me.FlowLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill
		Me.FlowLayoutPanel9.Location = New System.Drawing.Point(3, 3)
		Me.FlowLayoutPanel9.Name = "FlowLayoutPanel9"
		Me.FlowLayoutPanel9.Size = New System.Drawing.Size(1081, 75)
		Me.FlowLayoutPanel9.TabIndex = 1
		'
		'cmdCreate_AnimalGroup
		'
		Me.cmdCreate_AnimalGroup.BackColor = System.Drawing.Color.Gainsboro
		Me.cmdCreate_AnimalGroup.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
		Me.cmdCreate_AnimalGroup.FlatAppearance.BorderSize = 0
		Me.cmdCreate_AnimalGroup.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
		Me.cmdCreate_AnimalGroup.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
		Me.cmdCreate_AnimalGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.cmdCreate_AnimalGroup.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdCreate_AnimalGroup.Location = New System.Drawing.Point(3, 3)
		Me.cmdCreate_AnimalGroup.Name = "cmdCreate_AnimalGroup"
		Me.cmdCreate_AnimalGroup.Size = New System.Drawing.Size(112, 66)
		Me.cmdCreate_AnimalGroup.TabIndex = 35
		Me.cmdCreate_AnimalGroup.Text = "Crear"
		Me.cmdCreate_AnimalGroup.UseVisualStyleBackColor = False
		'
		'cmdUpdate_AnimalGroup
		'
		Me.cmdUpdate_AnimalGroup.BackColor = System.Drawing.Color.Gainsboro
		Me.cmdUpdate_AnimalGroup.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
		Me.cmdUpdate_AnimalGroup.FlatAppearance.BorderSize = 0
		Me.cmdUpdate_AnimalGroup.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
		Me.cmdUpdate_AnimalGroup.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
		Me.cmdUpdate_AnimalGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.cmdUpdate_AnimalGroup.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdUpdate_AnimalGroup.Location = New System.Drawing.Point(121, 3)
		Me.cmdUpdate_AnimalGroup.Name = "cmdUpdate_AnimalGroup"
		Me.cmdUpdate_AnimalGroup.Size = New System.Drawing.Size(112, 66)
		Me.cmdUpdate_AnimalGroup.TabIndex = 36
		Me.cmdUpdate_AnimalGroup.Text = "Modificar"
		Me.cmdUpdate_AnimalGroup.UseVisualStyleBackColor = False
		'
		'cmdDel_AnimalGroup
		'
		Me.cmdDel_AnimalGroup.BackColor = System.Drawing.Color.Gainsboro
		Me.cmdDel_AnimalGroup.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
		Me.cmdDel_AnimalGroup.FlatAppearance.BorderSize = 0
		Me.cmdDel_AnimalGroup.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
		Me.cmdDel_AnimalGroup.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
		Me.cmdDel_AnimalGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.cmdDel_AnimalGroup.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdDel_AnimalGroup.Location = New System.Drawing.Point(239, 3)
		Me.cmdDel_AnimalGroup.Name = "cmdDel_AnimalGroup"
		Me.cmdDel_AnimalGroup.Size = New System.Drawing.Size(110, 66)
		Me.cmdDel_AnimalGroup.TabIndex = 31
		Me.cmdDel_AnimalGroup.Text = "Eliminar"
		Me.cmdDel_AnimalGroup.UseVisualStyleBackColor = False
		'
		'OrigenAnimal
		'
		Me.OrigenAnimal.Controls.Add(Me.TableLayoutPanel4)
		Me.OrigenAnimal.Location = New System.Drawing.Point(4, 35)
		Me.OrigenAnimal.Name = "OrigenAnimal"
		Me.OrigenAnimal.Size = New System.Drawing.Size(1087, 540)
		Me.OrigenAnimal.TabIndex = 12
		Me.OrigenAnimal.Text = "Origen"
		Me.OrigenAnimal.UseVisualStyleBackColor = True
		'
		'TableLayoutPanel4
		'
		Me.TableLayoutPanel4.ColumnCount = 1
		Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TableLayoutPanel4.Controls.Add(Me.DGW_Origin, 0, 1)
		Me.TableLayoutPanel4.Controls.Add(Me.FlowLayoutPanel8, 0, 0)
		Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
		Me.TableLayoutPanel4.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TableLayoutPanel4.Location = New System.Drawing.Point(0, 0)
		Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
		Me.TableLayoutPanel4.RowCount = 2
		Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 81.0!))
		Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TableLayoutPanel4.Size = New System.Drawing.Size(1087, 540)
		Me.TableLayoutPanel4.TabIndex = 6
		'
		'DGW_Origin
		'
		Me.DGW_Origin.AllowUserToAddRows = False
		Me.DGW_Origin.AllowUserToDeleteRows = False
		Me.DGW_Origin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
		Me.DGW_Origin.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.DGW_Origin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
		Me.DGW_Origin.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id_Origin, Me.Origin_Name, Me.DataGridViewTextBoxColumn30, Me.DataGridViewTextBoxColumn31, Me.DataGridViewTextBoxColumn32, Me.DataGridViewTextBoxColumn33})
		Me.DGW_Origin.Dock = System.Windows.Forms.DockStyle.Fill
		Me.DGW_Origin.EnableHeadersVisualStyles = False
		Me.DGW_Origin.Location = New System.Drawing.Point(3, 84)
		Me.DGW_Origin.Name = "DGW_Origin"
		Me.DGW_Origin.ReadOnly = True
		Me.DGW_Origin.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
		Me.DGW_Origin.RowHeadersVisible = False
		Me.DGW_Origin.RowHeadersWidth = 50
		Me.DGW_Origin.ShowCellErrors = False
		Me.DGW_Origin.ShowCellToolTips = False
		Me.DGW_Origin.ShowEditingIcon = False
		Me.DGW_Origin.ShowRowErrors = False
		Me.DGW_Origin.Size = New System.Drawing.Size(1081, 453)
		Me.DGW_Origin.TabIndex = 3
		'
		'Id_Origin
		'
		Me.Id_Origin.DataPropertyName = "Id_Origin"
		Me.Id_Origin.HeaderText = "Correlativo"
		Me.Id_Origin.Name = "Id_Origin"
		Me.Id_Origin.ReadOnly = True
		'
		'Origin_Name
		'
		Me.Origin_Name.DataPropertyName = "Origin_Name"
		Me.Origin_Name.HeaderText = "Descripcion Origen"
		Me.Origin_Name.Name = "Origin_Name"
		Me.Origin_Name.ReadOnly = True
		'
		'DataGridViewTextBoxColumn30
		'
		Me.DataGridViewTextBoxColumn30.DataPropertyName = "Create_Users"
		Me.DataGridViewTextBoxColumn30.HeaderText = "Usuario Creó"
		Me.DataGridViewTextBoxColumn30.Name = "DataGridViewTextBoxColumn30"
		Me.DataGridViewTextBoxColumn30.ReadOnly = True
		'
		'DataGridViewTextBoxColumn31
		'
		Me.DataGridViewTextBoxColumn31.DataPropertyName = "Create_Date"
		Me.DataGridViewTextBoxColumn31.HeaderText = "Fecha Creó"
		Me.DataGridViewTextBoxColumn31.Name = "DataGridViewTextBoxColumn31"
		Me.DataGridViewTextBoxColumn31.ReadOnly = True
		'
		'DataGridViewTextBoxColumn32
		'
		Me.DataGridViewTextBoxColumn32.DataPropertyName = "Modify_Users"
		Me.DataGridViewTextBoxColumn32.HeaderText = "Usuario Modificó"
		Me.DataGridViewTextBoxColumn32.Name = "DataGridViewTextBoxColumn32"
		Me.DataGridViewTextBoxColumn32.ReadOnly = True
		'
		'DataGridViewTextBoxColumn33
		'
		Me.DataGridViewTextBoxColumn33.DataPropertyName = "Modify_Date"
		Me.DataGridViewTextBoxColumn33.HeaderText = "Fecha Modificó"
		Me.DataGridViewTextBoxColumn33.Name = "DataGridViewTextBoxColumn33"
		Me.DataGridViewTextBoxColumn33.ReadOnly = True
		'
		'FlowLayoutPanel8
		'
		Me.FlowLayoutPanel8.Controls.Add(Me.cmdCreate_Origin)
		Me.FlowLayoutPanel8.Controls.Add(Me.cmdUpdate_Origin)
		Me.FlowLayoutPanel8.Controls.Add(Me.cmdDel_Origin)
		Me.FlowLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill
		Me.FlowLayoutPanel8.Location = New System.Drawing.Point(3, 3)
		Me.FlowLayoutPanel8.Name = "FlowLayoutPanel8"
		Me.FlowLayoutPanel8.Size = New System.Drawing.Size(1081, 75)
		Me.FlowLayoutPanel8.TabIndex = 1
		'
		'cmdCreate_Origin
		'
		Me.cmdCreate_Origin.BackColor = System.Drawing.Color.Gainsboro
		Me.cmdCreate_Origin.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
		Me.cmdCreate_Origin.FlatAppearance.BorderSize = 0
		Me.cmdCreate_Origin.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
		Me.cmdCreate_Origin.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
		Me.cmdCreate_Origin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.cmdCreate_Origin.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdCreate_Origin.Location = New System.Drawing.Point(3, 3)
		Me.cmdCreate_Origin.Name = "cmdCreate_Origin"
		Me.cmdCreate_Origin.Size = New System.Drawing.Size(112, 66)
		Me.cmdCreate_Origin.TabIndex = 35
		Me.cmdCreate_Origin.Text = "Crear"
		Me.cmdCreate_Origin.UseVisualStyleBackColor = False
		'
		'cmdUpdate_Origin
		'
		Me.cmdUpdate_Origin.BackColor = System.Drawing.Color.Gainsboro
		Me.cmdUpdate_Origin.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
		Me.cmdUpdate_Origin.FlatAppearance.BorderSize = 0
		Me.cmdUpdate_Origin.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
		Me.cmdUpdate_Origin.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
		Me.cmdUpdate_Origin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.cmdUpdate_Origin.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdUpdate_Origin.Location = New System.Drawing.Point(121, 3)
		Me.cmdUpdate_Origin.Name = "cmdUpdate_Origin"
		Me.cmdUpdate_Origin.Size = New System.Drawing.Size(112, 66)
		Me.cmdUpdate_Origin.TabIndex = 36
		Me.cmdUpdate_Origin.Text = "Modificar"
		Me.cmdUpdate_Origin.UseVisualStyleBackColor = False
		'
		'cmdDel_Origin
		'
		Me.cmdDel_Origin.BackColor = System.Drawing.Color.Gainsboro
		Me.cmdDel_Origin.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
		Me.cmdDel_Origin.FlatAppearance.BorderSize = 0
		Me.cmdDel_Origin.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
		Me.cmdDel_Origin.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
		Me.cmdDel_Origin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.cmdDel_Origin.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdDel_Origin.Location = New System.Drawing.Point(239, 3)
		Me.cmdDel_Origin.Name = "cmdDel_Origin"
		Me.cmdDel_Origin.Size = New System.Drawing.Size(110, 66)
		Me.cmdDel_Origin.TabIndex = 31
		Me.cmdDel_Origin.Text = "Eliminar"
		Me.cmdDel_Origin.UseVisualStyleBackColor = False
		'
		'TipoOrigen
		'
		Me.TipoOrigen.Controls.Add(Me.TableLayoutPanel3)
		Me.TipoOrigen.Location = New System.Drawing.Point(4, 35)
		Me.TipoOrigen.Name = "TipoOrigen"
		Me.TipoOrigen.Size = New System.Drawing.Size(1087, 540)
		Me.TipoOrigen.TabIndex = 11
		Me.TipoOrigen.Text = "Tipo Origen"
		Me.TipoOrigen.UseVisualStyleBackColor = True
		'
		'TableLayoutPanel3
		'
		Me.TableLayoutPanel3.ColumnCount = 1
		Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TableLayoutPanel3.Controls.Add(Me.DGW_OriginType, 0, 1)
		Me.TableLayoutPanel3.Controls.Add(Me.FlowLayoutPanel7, 0, 0)
		Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
		Me.TableLayoutPanel3.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TableLayoutPanel3.Location = New System.Drawing.Point(0, 0)
		Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
		Me.TableLayoutPanel3.RowCount = 2
		Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 81.0!))
		Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TableLayoutPanel3.Size = New System.Drawing.Size(1087, 540)
		Me.TableLayoutPanel3.TabIndex = 6
		'
		'DGW_OriginType
		'
		Me.DGW_OriginType.AllowUserToAddRows = False
		Me.DGW_OriginType.AllowUserToDeleteRows = False
		Me.DGW_OriginType.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
		Me.DGW_OriginType.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.DGW_OriginType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
		Me.DGW_OriginType.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id_TypeOrigin, Me.TypeOrigin_Name, Me.DataGridViewTextBoxColumn23, Me.DataGridViewTextBoxColumn24, Me.DataGridViewTextBoxColumn25, Me.DataGridViewTextBoxColumn26})
		Me.DGW_OriginType.Dock = System.Windows.Forms.DockStyle.Fill
		Me.DGW_OriginType.EnableHeadersVisualStyles = False
		Me.DGW_OriginType.Location = New System.Drawing.Point(3, 84)
		Me.DGW_OriginType.Name = "DGW_OriginType"
		Me.DGW_OriginType.ReadOnly = True
		Me.DGW_OriginType.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
		Me.DGW_OriginType.RowHeadersVisible = False
		Me.DGW_OriginType.RowHeadersWidth = 50
		Me.DGW_OriginType.ShowCellErrors = False
		Me.DGW_OriginType.ShowCellToolTips = False
		Me.DGW_OriginType.ShowEditingIcon = False
		Me.DGW_OriginType.ShowRowErrors = False
		Me.DGW_OriginType.Size = New System.Drawing.Size(1081, 453)
		Me.DGW_OriginType.TabIndex = 3
		'
		'Id_TypeOrigin
		'
		Me.Id_TypeOrigin.DataPropertyName = "Id_TypeOrigin"
		Me.Id_TypeOrigin.HeaderText = "Correlativo"
		Me.Id_TypeOrigin.Name = "Id_TypeOrigin"
		Me.Id_TypeOrigin.ReadOnly = True
		'
		'TypeOrigin_Name
		'
		Me.TypeOrigin_Name.DataPropertyName = "TypeOrigin_Name"
		Me.TypeOrigin_Name.HeaderText = "Descripción Tipo de Origen"
		Me.TypeOrigin_Name.Name = "TypeOrigin_Name"
		Me.TypeOrigin_Name.ReadOnly = True
		'
		'DataGridViewTextBoxColumn23
		'
		Me.DataGridViewTextBoxColumn23.DataPropertyName = "Create_Users"
		Me.DataGridViewTextBoxColumn23.HeaderText = "Usuario Creó"
		Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
		Me.DataGridViewTextBoxColumn23.ReadOnly = True
		'
		'DataGridViewTextBoxColumn24
		'
		Me.DataGridViewTextBoxColumn24.DataPropertyName = "Create_Date"
		Me.DataGridViewTextBoxColumn24.HeaderText = "Fecha Creó"
		Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
		Me.DataGridViewTextBoxColumn24.ReadOnly = True
		'
		'DataGridViewTextBoxColumn25
		'
		Me.DataGridViewTextBoxColumn25.DataPropertyName = "Modify_Users"
		Me.DataGridViewTextBoxColumn25.HeaderText = "Usuario Modificó"
		Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
		Me.DataGridViewTextBoxColumn25.ReadOnly = True
		'
		'DataGridViewTextBoxColumn26
		'
		Me.DataGridViewTextBoxColumn26.DataPropertyName = "Modify_Date"
		Me.DataGridViewTextBoxColumn26.HeaderText = "Fecha Modificó"
		Me.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26"
		Me.DataGridViewTextBoxColumn26.ReadOnly = True
		'
		'FlowLayoutPanel7
		'
		Me.FlowLayoutPanel7.Controls.Add(Me.cmdCreate_TypeOrigin)
		Me.FlowLayoutPanel7.Controls.Add(Me.cmdUpdate_TypeOrigin)
		Me.FlowLayoutPanel7.Controls.Add(Me.cmdDel_TypeOrigin)
		Me.FlowLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill
		Me.FlowLayoutPanel7.Location = New System.Drawing.Point(3, 3)
		Me.FlowLayoutPanel7.Name = "FlowLayoutPanel7"
		Me.FlowLayoutPanel7.Size = New System.Drawing.Size(1081, 75)
		Me.FlowLayoutPanel7.TabIndex = 1
		'
		'cmdCreate_TypeOrigin
		'
		Me.cmdCreate_TypeOrigin.BackColor = System.Drawing.Color.Gainsboro
		Me.cmdCreate_TypeOrigin.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
		Me.cmdCreate_TypeOrigin.FlatAppearance.BorderSize = 0
		Me.cmdCreate_TypeOrigin.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
		Me.cmdCreate_TypeOrigin.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
		Me.cmdCreate_TypeOrigin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.cmdCreate_TypeOrigin.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdCreate_TypeOrigin.Location = New System.Drawing.Point(3, 3)
		Me.cmdCreate_TypeOrigin.Name = "cmdCreate_TypeOrigin"
		Me.cmdCreate_TypeOrigin.Size = New System.Drawing.Size(112, 66)
		Me.cmdCreate_TypeOrigin.TabIndex = 35
		Me.cmdCreate_TypeOrigin.Text = "Crear"
		Me.cmdCreate_TypeOrigin.UseVisualStyleBackColor = False
		'
		'cmdUpdate_TypeOrigin
		'
		Me.cmdUpdate_TypeOrigin.BackColor = System.Drawing.Color.Gainsboro
		Me.cmdUpdate_TypeOrigin.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
		Me.cmdUpdate_TypeOrigin.FlatAppearance.BorderSize = 0
		Me.cmdUpdate_TypeOrigin.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
		Me.cmdUpdate_TypeOrigin.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
		Me.cmdUpdate_TypeOrigin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.cmdUpdate_TypeOrigin.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdUpdate_TypeOrigin.Location = New System.Drawing.Point(121, 3)
		Me.cmdUpdate_TypeOrigin.Name = "cmdUpdate_TypeOrigin"
		Me.cmdUpdate_TypeOrigin.Size = New System.Drawing.Size(112, 66)
		Me.cmdUpdate_TypeOrigin.TabIndex = 36
		Me.cmdUpdate_TypeOrigin.Text = "Modificar"
		Me.cmdUpdate_TypeOrigin.UseVisualStyleBackColor = False
		'
		'cmdDel_TypeOrigin
		'
		Me.cmdDel_TypeOrigin.BackColor = System.Drawing.Color.Gainsboro
		Me.cmdDel_TypeOrigin.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
		Me.cmdDel_TypeOrigin.FlatAppearance.BorderSize = 0
		Me.cmdDel_TypeOrigin.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
		Me.cmdDel_TypeOrigin.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
		Me.cmdDel_TypeOrigin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.cmdDel_TypeOrigin.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdDel_TypeOrigin.Location = New System.Drawing.Point(239, 3)
		Me.cmdDel_TypeOrigin.Name = "cmdDel_TypeOrigin"
		Me.cmdDel_TypeOrigin.Size = New System.Drawing.Size(110, 66)
		Me.cmdDel_TypeOrigin.TabIndex = 31
		Me.cmdDel_TypeOrigin.Text = "Eliminar"
		Me.cmdDel_TypeOrigin.UseVisualStyleBackColor = False
		'
		'Genetica
		'
		Me.Genetica.Controls.Add(Me.TableLayoutPanel2)
		Me.Genetica.Location = New System.Drawing.Point(4, 35)
		Me.Genetica.Name = "Genetica"
		Me.Genetica.Size = New System.Drawing.Size(1087, 540)
		Me.Genetica.TabIndex = 10
		Me.Genetica.Text = "Genética Animal"
		Me.Genetica.UseVisualStyleBackColor = True
		'
		'TableLayoutPanel2
		'
		Me.TableLayoutPanel2.ColumnCount = 1
		Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TableLayoutPanel2.Controls.Add(Me.DGW_Genetic, 0, 1)
		Me.TableLayoutPanel2.Controls.Add(Me.FlowLayoutPanel6, 0, 0)
		Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
		Me.TableLayoutPanel2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
		Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
		Me.TableLayoutPanel2.RowCount = 2
		Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 81.0!))
		Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TableLayoutPanel2.Size = New System.Drawing.Size(1087, 540)
		Me.TableLayoutPanel2.TabIndex = 6
		'
		'DGW_Genetic
		'
		Me.DGW_Genetic.AllowUserToAddRows = False
		Me.DGW_Genetic.AllowUserToDeleteRows = False
		Me.DGW_Genetic.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
		Me.DGW_Genetic.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.DGW_Genetic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
		Me.DGW_Genetic.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_Genetica, Me.Genetic_Name, Me.Create_User, Me.DataGridViewTextBoxColumn27, Me.UserModify, Me.Modify_User})
		Me.DGW_Genetic.Dock = System.Windows.Forms.DockStyle.Fill
		Me.DGW_Genetic.EnableHeadersVisualStyles = False
		Me.DGW_Genetic.Location = New System.Drawing.Point(3, 84)
		Me.DGW_Genetic.Name = "DGW_Genetic"
		Me.DGW_Genetic.ReadOnly = True
		Me.DGW_Genetic.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
		Me.DGW_Genetic.RowHeadersVisible = False
		Me.DGW_Genetic.RowHeadersWidth = 50
		Me.DGW_Genetic.ShowCellErrors = False
		Me.DGW_Genetic.ShowCellToolTips = False
		Me.DGW_Genetic.ShowEditingIcon = False
		Me.DGW_Genetic.ShowRowErrors = False
		Me.DGW_Genetic.Size = New System.Drawing.Size(1081, 453)
		Me.DGW_Genetic.TabIndex = 2
		'
		'id_Genetica
		'
		Me.id_Genetica.DataPropertyName = "Id_Genetic"
		Me.id_Genetica.HeaderText = "Correlativo"
		Me.id_Genetica.Name = "id_Genetica"
		Me.id_Genetica.ReadOnly = True
		'
		'Genetic_Name
		'
		Me.Genetic_Name.DataPropertyName = "Genetic_Name"
		Me.Genetic_Name.HeaderText = "Descripción Genética"
		Me.Genetic_Name.Name = "Genetic_Name"
		Me.Genetic_Name.ReadOnly = True
		'
		'Create_User
		'
		Me.Create_User.DataPropertyName = "Create_Users"
		Me.Create_User.HeaderText = "Creación Usuario "
		Me.Create_User.Name = "Create_User"
		Me.Create_User.ReadOnly = True
		'
		'DataGridViewTextBoxColumn27
		'
		Me.DataGridViewTextBoxColumn27.DataPropertyName = "Create_Date"
		Me.DataGridViewTextBoxColumn27.HeaderText = "Creación Fecha "
		Me.DataGridViewTextBoxColumn27.Name = "DataGridViewTextBoxColumn27"
		Me.DataGridViewTextBoxColumn27.ReadOnly = True
		'
		'UserModify
		'
		Me.UserModify.DataPropertyName = "Modify_Users"
		Me.UserModify.HeaderText = "Modificación Usuario "
		Me.UserModify.Name = "UserModify"
		Me.UserModify.ReadOnly = True
		'
		'Modify_User
		'
		Me.Modify_User.DataPropertyName = "Modify_Date"
		Me.Modify_User.HeaderText = "Modificación Fecha "
		Me.Modify_User.Name = "Modify_User"
		Me.Modify_User.ReadOnly = True
		'
		'FlowLayoutPanel6
		'
		Me.FlowLayoutPanel6.Controls.Add(Me.cmdCreate_GeneticaAnimals)
		Me.FlowLayoutPanel6.Controls.Add(Me.cmdUpdate_GeneticaAnimals)
		Me.FlowLayoutPanel6.Controls.Add(Me.cmdDel_GeneticaAnimals)
		Me.FlowLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill
		Me.FlowLayoutPanel6.Location = New System.Drawing.Point(3, 3)
		Me.FlowLayoutPanel6.Name = "FlowLayoutPanel6"
		Me.FlowLayoutPanel6.Size = New System.Drawing.Size(1081, 75)
		Me.FlowLayoutPanel6.TabIndex = 1
		'
		'cmdCreate_GeneticaAnimals
		'
		Me.cmdCreate_GeneticaAnimals.BackColor = System.Drawing.Color.Gainsboro
		Me.cmdCreate_GeneticaAnimals.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
		Me.cmdCreate_GeneticaAnimals.FlatAppearance.BorderSize = 0
		Me.cmdCreate_GeneticaAnimals.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
		Me.cmdCreate_GeneticaAnimals.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
		Me.cmdCreate_GeneticaAnimals.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.cmdCreate_GeneticaAnimals.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdCreate_GeneticaAnimals.Location = New System.Drawing.Point(3, 3)
		Me.cmdCreate_GeneticaAnimals.Name = "cmdCreate_GeneticaAnimals"
		Me.cmdCreate_GeneticaAnimals.Size = New System.Drawing.Size(112, 66)
		Me.cmdCreate_GeneticaAnimals.TabIndex = 35
		Me.cmdCreate_GeneticaAnimals.Text = "Crear"
		Me.cmdCreate_GeneticaAnimals.UseVisualStyleBackColor = False
		'
		'cmdUpdate_GeneticaAnimals
		'
		Me.cmdUpdate_GeneticaAnimals.BackColor = System.Drawing.Color.Gainsboro
		Me.cmdUpdate_GeneticaAnimals.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
		Me.cmdUpdate_GeneticaAnimals.FlatAppearance.BorderSize = 0
		Me.cmdUpdate_GeneticaAnimals.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
		Me.cmdUpdate_GeneticaAnimals.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
		Me.cmdUpdate_GeneticaAnimals.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.cmdUpdate_GeneticaAnimals.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdUpdate_GeneticaAnimals.Location = New System.Drawing.Point(121, 3)
		Me.cmdUpdate_GeneticaAnimals.Name = "cmdUpdate_GeneticaAnimals"
		Me.cmdUpdate_GeneticaAnimals.Size = New System.Drawing.Size(112, 66)
		Me.cmdUpdate_GeneticaAnimals.TabIndex = 36
		Me.cmdUpdate_GeneticaAnimals.Text = "Modificar"
		Me.cmdUpdate_GeneticaAnimals.UseVisualStyleBackColor = False
		'
		'cmdDel_GeneticaAnimals
		'
		Me.cmdDel_GeneticaAnimals.BackColor = System.Drawing.Color.Gainsboro
		Me.cmdDel_GeneticaAnimals.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
		Me.cmdDel_GeneticaAnimals.FlatAppearance.BorderSize = 0
		Me.cmdDel_GeneticaAnimals.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
		Me.cmdDel_GeneticaAnimals.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
		Me.cmdDel_GeneticaAnimals.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.cmdDel_GeneticaAnimals.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdDel_GeneticaAnimals.Location = New System.Drawing.Point(239, 3)
		Me.cmdDel_GeneticaAnimals.Name = "cmdDel_GeneticaAnimals"
		Me.cmdDel_GeneticaAnimals.Size = New System.Drawing.Size(110, 66)
		Me.cmdDel_GeneticaAnimals.TabIndex = 31
		Me.cmdDel_GeneticaAnimals.Text = "Eliminar"
		Me.cmdDel_GeneticaAnimals.UseVisualStyleBackColor = False
		'
		'DescargaProductos
		'
		Me.DescargaProductos.Controls.Add(Me.TLP_PendientesDescarga)
		Me.DescargaProductos.Location = New System.Drawing.Point(4, 35)
		Me.DescargaProductos.Name = "DescargaProductos"
		Me.DescargaProductos.Size = New System.Drawing.Size(1087, 540)
		Me.DescargaProductos.TabIndex = 9
		Me.DescargaProductos.Text = "Pendiente descarga"
		Me.DescargaProductos.UseVisualStyleBackColor = True
		'
		'TLP_PendientesDescarga
		'
		Me.TLP_PendientesDescarga.ColumnCount = 1
		Me.TLP_PendientesDescarga.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TLP_PendientesDescarga.Controls.Add(Me.DGW_DescargaProductos, 0, 1)
		Me.TLP_PendientesDescarga.Controls.Add(Me.FlowLayoutPanel5, 0, 0)
		Me.TLP_PendientesDescarga.Dock = System.Windows.Forms.DockStyle.Fill
		Me.TLP_PendientesDescarga.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TLP_PendientesDescarga.Location = New System.Drawing.Point(0, 0)
		Me.TLP_PendientesDescarga.Name = "TLP_PendientesDescarga"
		Me.TLP_PendientesDescarga.RowCount = 2
		Me.TLP_PendientesDescarga.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 86.0!))
		Me.TLP_PendientesDescarga.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TLP_PendientesDescarga.Size = New System.Drawing.Size(1087, 540)
		Me.TLP_PendientesDescarga.TabIndex = 2
		'
		'DGW_DescargaProductos
		'
		Me.DGW_DescargaProductos.AllowUserToAddRows = False
		Me.DGW_DescargaProductos.AllowUserToDeleteRows = False
		Me.DGW_DescargaProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
		Me.DGW_DescargaProductos.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.DGW_DescargaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
		Me.DGW_DescargaProductos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20})
		Me.DGW_DescargaProductos.Dock = System.Windows.Forms.DockStyle.Fill
		Me.DGW_DescargaProductos.EnableHeadersVisualStyles = False
		Me.DGW_DescargaProductos.Location = New System.Drawing.Point(3, 89)
		Me.DGW_DescargaProductos.Name = "DGW_DescargaProductos"
		Me.DGW_DescargaProductos.ReadOnly = True
		Me.DGW_DescargaProductos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
		Me.DGW_DescargaProductos.RowHeadersVisible = False
		Me.DGW_DescargaProductos.RowHeadersWidth = 50
		Me.DGW_DescargaProductos.ShowCellErrors = False
		Me.DGW_DescargaProductos.ShowCellToolTips = False
		Me.DGW_DescargaProductos.ShowEditingIcon = False
		Me.DGW_DescargaProductos.ShowRowErrors = False
		Me.DGW_DescargaProductos.Size = New System.Drawing.Size(1081, 448)
		Me.DGW_DescargaProductos.TabIndex = 0
		'
		'DataGridViewTextBoxColumn12
		'
		Me.DataGridViewTextBoxColumn12.DataPropertyName = "Id_Transaction"
		Me.DataGridViewTextBoxColumn12.HeaderText = "Correlativo"
		Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
		Me.DataGridViewTextBoxColumn12.ReadOnly = True
		'
		'DataGridViewTextBoxColumn13
		'
		Me.DataGridViewTextBoxColumn13.DataPropertyName = "Descripction_Flow"
		Me.DataGridViewTextBoxColumn13.HeaderText = "Tipo de Lote"
		Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
		Me.DataGridViewTextBoxColumn13.ReadOnly = True
		'
		'DataGridViewTextBoxColumn14
		'
		Me.DataGridViewTextBoxColumn14.DataPropertyName = "Descripction_Lote"
		Me.DataGridViewTextBoxColumn14.HeaderText = "Descripción Lote"
		Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
		Me.DataGridViewTextBoxColumn14.ReadOnly = True
		'
		'DataGridViewTextBoxColumn15
		'
		Me.DataGridViewTextBoxColumn15.DataPropertyName = "descripction_Process"
		Me.DataGridViewTextBoxColumn15.HeaderText = "Proceso"
		Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
		Me.DataGridViewTextBoxColumn15.ReadOnly = True
		'
		'DataGridViewTextBoxColumn17
		'
		Me.DataGridViewTextBoxColumn17.DataPropertyName = "id_product_FK"
		Me.DataGridViewTextBoxColumn17.HeaderText = "ID Producto"
		Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
		Me.DataGridViewTextBoxColumn17.ReadOnly = True
		'
		'DataGridViewTextBoxColumn18
		'
		Me.DataGridViewTextBoxColumn18.DataPropertyName = "Name_Product"
		Me.DataGridViewTextBoxColumn18.HeaderText = "Descripción Producto"
		Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
		Me.DataGridViewTextBoxColumn18.ReadOnly = True
		'
		'DataGridViewTextBoxColumn19
		'
		Me.DataGridViewTextBoxColumn19.DataPropertyName = "TotalProduct"
		Me.DataGridViewTextBoxColumn19.HeaderText = "Total Salida"
		Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
		Me.DataGridViewTextBoxColumn19.ReadOnly = True
		'
		'DataGridViewTextBoxColumn20
		'
		Me.DataGridViewTextBoxColumn20.DataPropertyName = "Date_create"
		Me.DataGridViewTextBoxColumn20.HeaderText = "Fecha "
		Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
		Me.DataGridViewTextBoxColumn20.ReadOnly = True
		'
		'FlowLayoutPanel5
		'
		Me.FlowLayoutPanel5.Controls.Add(Me.cmdPendienteDescarga_PasarInventario)
		Me.FlowLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
		Me.FlowLayoutPanel5.Location = New System.Drawing.Point(3, 3)
		Me.FlowLayoutPanel5.Name = "FlowLayoutPanel5"
		Me.FlowLayoutPanel5.Size = New System.Drawing.Size(1081, 80)
		Me.FlowLayoutPanel5.TabIndex = 1
		'
		'cmdPendienteDescarga_PasarInventario
		'
		Me.cmdPendienteDescarga_PasarInventario.BackColor = System.Drawing.Color.Gainsboro
		Me.cmdPendienteDescarga_PasarInventario.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
		Me.cmdPendienteDescarga_PasarInventario.FlatAppearance.BorderSize = 0
		Me.cmdPendienteDescarga_PasarInventario.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
		Me.cmdPendienteDescarga_PasarInventario.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
		Me.cmdPendienteDescarga_PasarInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.cmdPendienteDescarga_PasarInventario.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdPendienteDescarga_PasarInventario.Location = New System.Drawing.Point(3, 3)
		Me.cmdPendienteDescarga_PasarInventario.Name = "cmdPendienteDescarga_PasarInventario"
		Me.cmdPendienteDescarga_PasarInventario.Size = New System.Drawing.Size(110, 66)
		Me.cmdPendienteDescarga_PasarInventario.TabIndex = 31
		Me.cmdPendienteDescarga_PasarInventario.Text = "Salida Inventario"
		Me.cmdPendienteDescarga_PasarInventario.UseVisualStyleBackColor = False
		'
		'Animales
		'
		Me.Animales.Controls.Add(Me.TableLayoutPanel1)
		Me.Animales.Location = New System.Drawing.Point(4, 35)
		Me.Animales.Name = "Animales"
		Me.Animales.Size = New System.Drawing.Size(1087, 540)
		Me.Animales.TabIndex = 8
		Me.Animales.Text = "Animales"
		Me.Animales.UseVisualStyleBackColor = True
		'
		'TableLayoutPanel1
		'
		Me.TableLayoutPanel1.ColumnCount = 1
		Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TableLayoutPanel1.Controls.Add(Me.DGVAnimals, 0, 1)
		Me.TableLayoutPanel1.Controls.Add(Me.FlowLayoutPanel4, 0, 0)
		Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.TableLayoutPanel1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
		Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
		Me.TableLayoutPanel1.RowCount = 2
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 81.0!))
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TableLayoutPanel1.Size = New System.Drawing.Size(1087, 540)
		Me.TableLayoutPanel1.TabIndex = 4
		'
		'DGVAnimals
		'
		Me.DGVAnimals.AllowUserToAddRows = False
		Me.DGVAnimals.AllowUserToDeleteRows = False
		Me.DGVAnimals.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
		Me.DGVAnimals.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.DGVAnimals.Dock = System.Windows.Forms.DockStyle.Fill
		Me.DGVAnimals.EnableHeadersVisualStyles = False
		Me.DGVAnimals.Location = New System.Drawing.Point(3, 84)
		Me.DGVAnimals.Name = "DGVAnimals"
		Me.DGVAnimals.ReadOnly = True
		Me.DGVAnimals.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
		Me.DGVAnimals.RowHeadersVisible = False
		Me.DGVAnimals.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.DGVAnimals.ShowCellErrors = False
		Me.DGVAnimals.ShowCellToolTips = False
		Me.DGVAnimals.ShowEditingIcon = False
		Me.DGVAnimals.ShowRowErrors = False
		Me.DGVAnimals.Size = New System.Drawing.Size(1081, 453)
		Me.DGVAnimals.TabIndex = 0
		'
		'FlowLayoutPanel4
		'
		Me.FlowLayoutPanel4.Controls.Add(Me.Button14)
		Me.FlowLayoutPanel4.Controls.Add(Me.Button15)
		Me.FlowLayoutPanel4.Controls.Add(Me.btnEliminar)
		Me.FlowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
		Me.FlowLayoutPanel4.Location = New System.Drawing.Point(3, 3)
		Me.FlowLayoutPanel4.Name = "FlowLayoutPanel4"
		Me.FlowLayoutPanel4.Size = New System.Drawing.Size(1081, 75)
		Me.FlowLayoutPanel4.TabIndex = 1
		'
		'Button14
		'
		Me.Button14.BackColor = System.Drawing.Color.Gainsboro
		Me.Button14.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
		Me.Button14.FlatAppearance.BorderSize = 0
		Me.Button14.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
		Me.Button14.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
		Me.Button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button14.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Button14.Location = New System.Drawing.Point(3, 3)
		Me.Button14.Name = "Button14"
		Me.Button14.Size = New System.Drawing.Size(112, 66)
		Me.Button14.TabIndex = 35
		Me.Button14.Text = "Crear"
		Me.Button14.UseVisualStyleBackColor = False
		'
		'Button15
		'
		Me.Button15.BackColor = System.Drawing.Color.Gainsboro
		Me.Button15.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
		Me.Button15.FlatAppearance.BorderSize = 0
		Me.Button15.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
		Me.Button15.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
		Me.Button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button15.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Button15.Location = New System.Drawing.Point(121, 3)
		Me.Button15.Name = "Button15"
		Me.Button15.Size = New System.Drawing.Size(112, 66)
		Me.Button15.TabIndex = 36
		Me.Button15.Text = "Modificar"
		Me.Button15.UseVisualStyleBackColor = False
		'
		'btnEliminar
		'
		Me.btnEliminar.BackColor = System.Drawing.Color.Gainsboro
		Me.btnEliminar.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
		Me.btnEliminar.FlatAppearance.BorderSize = 0
		Me.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
		Me.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
		Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnEliminar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnEliminar.Location = New System.Drawing.Point(239, 3)
		Me.btnEliminar.Name = "btnEliminar"
		Me.btnEliminar.Size = New System.Drawing.Size(110, 66)
		Me.btnEliminar.TabIndex = 31
		Me.btnEliminar.Text = "Eliminar"
		Me.btnEliminar.UseVisualStyleBackColor = False
		'
		'StatusDiasVacio
		'
		Me.StatusDiasVacio.Controls.Add(Me.FLStatusDiasVacio)
		Me.StatusDiasVacio.Location = New System.Drawing.Point(4, 35)
		Me.StatusDiasVacio.Name = "StatusDiasVacio"
		Me.StatusDiasVacio.Padding = New System.Windows.Forms.Padding(3)
		Me.StatusDiasVacio.Size = New System.Drawing.Size(1087, 540)
		Me.StatusDiasVacio.TabIndex = 7
		Me.StatusDiasVacio.Text = "Status Días Vacío"
		Me.StatusDiasVacio.UseVisualStyleBackColor = True
		'
		'FLStatusDiasVacio
		'
		Me.FLStatusDiasVacio.AutoScroll = True
		Me.FLStatusDiasVacio.Dock = System.Windows.Forms.DockStyle.Fill
		Me.FLStatusDiasVacio.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.FLStatusDiasVacio.Location = New System.Drawing.Point(3, 3)
		Me.FLStatusDiasVacio.Name = "FLStatusDiasVacio"
		Me.FLStatusDiasVacio.Size = New System.Drawing.Size(1081, 534)
		Me.FLStatusDiasVacio.TabIndex = 0
		'
		'Lista_Productos_proceso
		'
		Me.Lista_Productos_proceso.Controls.Add(Me.TLP_Facturacion)
		Me.Lista_Productos_proceso.Location = New System.Drawing.Point(4, 35)
		Me.Lista_Productos_proceso.Name = "Lista_Productos_proceso"
		Me.Lista_Productos_proceso.Size = New System.Drawing.Size(1087, 540)
		Me.Lista_Productos_proceso.TabIndex = 4
		Me.Lista_Productos_proceso.Text = "Lista de Productos en Proceso"
		Me.Lista_Productos_proceso.UseVisualStyleBackColor = True
		'
		'TLP_Facturacion
		'
		Me.TLP_Facturacion.ColumnCount = 1
		Me.TLP_Facturacion.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TLP_Facturacion.Controls.Add(Me.DGW_ProductsProcess, 0, 1)
		Me.TLP_Facturacion.Controls.Add(Me.FlowLayoutPanel1, 0, 0)
		Me.TLP_Facturacion.Dock = System.Windows.Forms.DockStyle.Fill
		Me.TLP_Facturacion.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TLP_Facturacion.Location = New System.Drawing.Point(0, 0)
		Me.TLP_Facturacion.Name = "TLP_Facturacion"
		Me.TLP_Facturacion.RowCount = 2
		Me.TLP_Facturacion.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 196.0!))
		Me.TLP_Facturacion.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TLP_Facturacion.Size = New System.Drawing.Size(1087, 540)
		Me.TLP_Facturacion.TabIndex = 1
		'
		'DGW_ProductsProcess
		'
		Me.DGW_ProductsProcess.AllowUserToAddRows = False
		Me.DGW_ProductsProcess.AllowUserToDeleteRows = False
		Me.DGW_ProductsProcess.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
		Me.DGW_ProductsProcess.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.DGW_ProductsProcess.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
		Me.DGW_ProductsProcess.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Correlativo, Me.BusinessDay, Me.Commercial_Name, Me.Fullpayment, Me.semana, Me.DocumentNumber, Me.Column8, Me.Date_EndProject, Me.UsuarioAnulo, Me.IdProceso, Me.Id_Circle, Me.Id_CicloRef, Me.IS_StageAlarm, Me.ID_Product_FK})
		Me.DGW_ProductsProcess.Dock = System.Windows.Forms.DockStyle.Fill
		Me.DGW_ProductsProcess.EnableHeadersVisualStyles = False
		Me.DGW_ProductsProcess.Location = New System.Drawing.Point(3, 199)
		Me.DGW_ProductsProcess.Name = "DGW_ProductsProcess"
		Me.DGW_ProductsProcess.ReadOnly = True
		Me.DGW_ProductsProcess.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
		Me.DGW_ProductsProcess.RowHeadersVisible = False
		Me.DGW_ProductsProcess.RowHeadersWidth = 50
		Me.DGW_ProductsProcess.ShowCellErrors = False
		Me.DGW_ProductsProcess.ShowCellToolTips = False
		Me.DGW_ProductsProcess.ShowEditingIcon = False
		Me.DGW_ProductsProcess.ShowRowErrors = False
		Me.DGW_ProductsProcess.Size = New System.Drawing.Size(1081, 338)
		Me.DGW_ProductsProcess.TabIndex = 0
		'
		'Correlativo
		'
		Me.Correlativo.DataPropertyName = "Id_Production"
		Me.Correlativo.HeaderText = "Correlativo"
		Me.Correlativo.Name = "Correlativo"
		Me.Correlativo.ReadOnly = True
		'
		'BusinessDay
		'
		Me.BusinessDay.DataPropertyName = "description_name"
		Me.BusinessDay.HeaderText = "Tipo de Lote"
		Me.BusinessDay.Name = "BusinessDay"
		Me.BusinessDay.ReadOnly = True
		'
		'Commercial_Name
		'
		Me.Commercial_Name.DataPropertyName = "nombrelote"
		Me.Commercial_Name.HeaderText = "Descripción Lote"
		Me.Commercial_Name.Name = "Commercial_Name"
		Me.Commercial_Name.ReadOnly = True
		'
		'Fullpayment
		'
		Me.Fullpayment.DataPropertyName = "descripProce"
		Me.Fullpayment.HeaderText = "Proceso Actual"
		Me.Fullpayment.Name = "Fullpayment"
		Me.Fullpayment.ReadOnly = True
		'
		'semana
		'
		Me.semana.DataPropertyName = "semana"
		Me.semana.HeaderText = "Semana"
		Me.semana.Name = "semana"
		Me.semana.ReadOnly = True
		'
		'DocumentNumber
		'
		Me.DocumentNumber.DataPropertyName = "etapa"
		Me.DocumentNumber.HeaderText = "Etapa Actual"
		Me.DocumentNumber.Name = "DocumentNumber"
		Me.DocumentNumber.ReadOnly = True
		Me.DocumentNumber.Visible = False
		'
		'Column8
		'
		Me.Column8.DataPropertyName = "Initial_Inventory"
		Me.Column8.HeaderText = "Inv. Inicial"
		Me.Column8.Name = "Column8"
		Me.Column8.ReadOnly = True
		'
		'Date_EndProject
		'
		Me.Date_EndProject.DataPropertyName = "Final_Inventory"
		Me.Date_EndProject.HeaderText = "Inv. Final"
		Me.Date_EndProject.Name = "Date_EndProject"
		Me.Date_EndProject.ReadOnly = True
		'
		'UsuarioAnulo
		'
		Me.UsuarioAnulo.DataPropertyName = "date_init"
		Me.UsuarioAnulo.HeaderText = "Fecha Inicio"
		Me.UsuarioAnulo.Name = "UsuarioAnulo"
		Me.UsuarioAnulo.ReadOnly = True
		'
		'IdProceso
		'
		Me.IdProceso.DataPropertyName = "id_process"
		Me.IdProceso.HeaderText = "IdProceso"
		Me.IdProceso.Name = "IdProceso"
		Me.IdProceso.ReadOnly = True
		Me.IdProceso.Visible = False
		'
		'Id_Circle
		'
		Me.Id_Circle.DataPropertyName = "id_circle_act"
		Me.Id_Circle.HeaderText = "Id_CicloAct"
		Me.Id_Circle.Name = "Id_Circle"
		Me.Id_Circle.ReadOnly = True
		Me.Id_Circle.Visible = False
		'
		'Id_CicloRef
		'
		Me.Id_CicloRef.DataPropertyName = "id_circle_ref"
		Me.Id_CicloRef.HeaderText = "Id_CicloRef"
		Me.Id_CicloRef.Name = "Id_CicloRef"
		Me.Id_CicloRef.ReadOnly = True
		Me.Id_CicloRef.Visible = False
		'
		'IS_StageAlarm
		'
		Me.IS_StageAlarm.DataPropertyName = "IS_StageAlarm"
		Me.IS_StageAlarm.HeaderText = "Alerta"
		Me.IS_StageAlarm.Name = "IS_StageAlarm"
		Me.IS_StageAlarm.ReadOnly = True
		'
		'ID_Product_FK
		'
		Me.ID_Product_FK.DataPropertyName = "ID_Product_FK"
		Me.ID_Product_FK.HeaderText = "ID_Product_FK"
		Me.ID_Product_FK.Name = "ID_Product_FK"
		Me.ID_Product_FK.ReadOnly = True
		Me.ID_Product_FK.Visible = False
		'
		'FlowLayoutPanel1
		'
		Me.FlowLayoutPanel1.Controls.Add(Me.cmdCreateLote)
		Me.FlowLayoutPanel1.Controls.Add(Me.cmdModLote)
		Me.FlowLayoutPanel1.Controls.Add(Me.cmdCatalogoClienteFinanciero)
		Me.FlowLayoutPanel1.Controls.Add(Me.cmdCatalogoClienteFinancieroSeleccion)
		Me.FlowLayoutPanel1.Controls.Add(Me.cmdReporteProveedores)
		Me.FlowLayoutPanel1.Controls.Add(Me.btnFormDinamico)
		Me.FlowLayoutPanel1.Controls.Add(Me.cmdReportGeneral)
		Me.FlowLayoutPanel1.Controls.Add(Me.cmdOutPut)
		Me.FlowLayoutPanel1.Controls.Add(Me.Button16)
		Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.FlowLayoutPanel1.Location = New System.Drawing.Point(3, 3)
		Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
		Me.FlowLayoutPanel1.Size = New System.Drawing.Size(1081, 190)
		Me.FlowLayoutPanel1.TabIndex = 1
		'
		'cmdCreateLote
		'
		Me.cmdCreateLote.BackColor = System.Drawing.Color.Gainsboro
		Me.cmdCreateLote.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
		Me.cmdCreateLote.FlatAppearance.BorderSize = 0
		Me.cmdCreateLote.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
		Me.cmdCreateLote.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
		Me.cmdCreateLote.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.cmdCreateLote.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdCreateLote.Location = New System.Drawing.Point(3, 3)
		Me.cmdCreateLote.Name = "cmdCreateLote"
		Me.cmdCreateLote.Size = New System.Drawing.Size(110, 66)
		Me.cmdCreateLote.TabIndex = 31
		Me.cmdCreateLote.Text = "Crear Lote"
		Me.cmdCreateLote.UseVisualStyleBackColor = False
		'
		'cmdModLote
		'
		Me.cmdModLote.BackColor = System.Drawing.Color.Gainsboro
		Me.cmdModLote.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
		Me.cmdModLote.FlatAppearance.BorderSize = 0
		Me.cmdModLote.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
		Me.cmdModLote.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
		Me.cmdModLote.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.cmdModLote.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdModLote.Location = New System.Drawing.Point(119, 3)
		Me.cmdModLote.Name = "cmdModLote"
		Me.cmdModLote.Size = New System.Drawing.Size(129, 66)
		Me.cmdModLote.TabIndex = 36
		Me.cmdModLote.Text = "Modificar Lote"
		Me.cmdModLote.UseVisualStyleBackColor = False
		'
		'cmdCatalogoClienteFinanciero
		'
		Me.cmdCatalogoClienteFinanciero.BackColor = System.Drawing.Color.Gainsboro
		Me.cmdCatalogoClienteFinanciero.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
		Me.cmdCatalogoClienteFinanciero.FlatAppearance.BorderSize = 0
		Me.cmdCatalogoClienteFinanciero.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
		Me.cmdCatalogoClienteFinanciero.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
		Me.cmdCatalogoClienteFinanciero.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.cmdCatalogoClienteFinanciero.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdCatalogoClienteFinanciero.Location = New System.Drawing.Point(254, 3)
		Me.cmdCatalogoClienteFinanciero.Name = "cmdCatalogoClienteFinanciero"
		Me.cmdCatalogoClienteFinanciero.Size = New System.Drawing.Size(152, 66)
		Me.cmdCatalogoClienteFinanciero.TabIndex = 33
		Me.cmdCatalogoClienteFinanciero.Text = "Orden Producción Total"
		Me.cmdCatalogoClienteFinanciero.UseVisualStyleBackColor = False
		'
		'cmdCatalogoClienteFinancieroSeleccion
		'
		Me.cmdCatalogoClienteFinancieroSeleccion.BackColor = System.Drawing.Color.Gainsboro
		Me.cmdCatalogoClienteFinancieroSeleccion.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
		Me.cmdCatalogoClienteFinancieroSeleccion.FlatAppearance.BorderSize = 0
		Me.cmdCatalogoClienteFinancieroSeleccion.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
		Me.cmdCatalogoClienteFinancieroSeleccion.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
		Me.cmdCatalogoClienteFinancieroSeleccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.cmdCatalogoClienteFinancieroSeleccion.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdCatalogoClienteFinancieroSeleccion.Location = New System.Drawing.Point(412, 3)
		Me.cmdCatalogoClienteFinancieroSeleccion.Name = "cmdCatalogoClienteFinancieroSeleccion"
		Me.cmdCatalogoClienteFinancieroSeleccion.Size = New System.Drawing.Size(152, 66)
		Me.cmdCatalogoClienteFinancieroSeleccion.TabIndex = 38
		Me.cmdCatalogoClienteFinancieroSeleccion.Text = "Orden Producción Selección"
		Me.cmdCatalogoClienteFinancieroSeleccion.UseVisualStyleBackColor = False
		'
		'cmdReporteProveedores
		'
		Me.cmdReporteProveedores.BackColor = System.Drawing.Color.Gainsboro
		Me.cmdReporteProveedores.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
		Me.cmdReporteProveedores.FlatAppearance.BorderSize = 0
		Me.cmdReporteProveedores.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
		Me.cmdReporteProveedores.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
		Me.cmdReporteProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.cmdReporteProveedores.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdReporteProveedores.Location = New System.Drawing.Point(570, 3)
		Me.cmdReporteProveedores.Name = "cmdReporteProveedores"
		Me.cmdReporteProveedores.Size = New System.Drawing.Size(112, 66)
		Me.cmdReporteProveedores.TabIndex = 32
		Me.cmdReporteProveedores.Text = "Procesar"
		Me.cmdReporteProveedores.UseVisualStyleBackColor = False
		'
		'btnFormDinamico
		'
		Me.btnFormDinamico.BackColor = System.Drawing.Color.Gainsboro
		Me.btnFormDinamico.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
		Me.btnFormDinamico.FlatAppearance.BorderSize = 0
		Me.btnFormDinamico.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
		Me.btnFormDinamico.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
		Me.btnFormDinamico.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnFormDinamico.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnFormDinamico.Location = New System.Drawing.Point(688, 3)
		Me.btnFormDinamico.Name = "btnFormDinamico"
		Me.btnFormDinamico.Size = New System.Drawing.Size(112, 66)
		Me.btnFormDinamico.TabIndex = 35
		Me.btnFormDinamico.Text = "Ingresar Información"
		Me.btnFormDinamico.UseVisualStyleBackColor = False
		'
		'cmdReportGeneral
		'
		Me.cmdReportGeneral.BackColor = System.Drawing.Color.Gainsboro
		Me.cmdReportGeneral.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
		Me.cmdReportGeneral.FlatAppearance.BorderSize = 0
		Me.cmdReportGeneral.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
		Me.cmdReportGeneral.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
		Me.cmdReportGeneral.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.cmdReportGeneral.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdReportGeneral.Location = New System.Drawing.Point(806, 3)
		Me.cmdReportGeneral.Name = "cmdReportGeneral"
		Me.cmdReportGeneral.Size = New System.Drawing.Size(152, 66)
		Me.cmdReportGeneral.TabIndex = 37
		Me.cmdReportGeneral.Text = "Reporte General Lotes"
		Me.cmdReportGeneral.UseVisualStyleBackColor = False
		Me.cmdReportGeneral.Visible = False
		'
		'cmdOutPut
		'
		Me.cmdOutPut.BackColor = System.Drawing.Color.Gainsboro
		Me.cmdOutPut.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
		Me.cmdOutPut.FlatAppearance.BorderSize = 0
		Me.cmdOutPut.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
		Me.cmdOutPut.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
		Me.cmdOutPut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.cmdOutPut.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdOutPut.Location = New System.Drawing.Point(964, 3)
		Me.cmdOutPut.Name = "cmdOutPut"
		Me.cmdOutPut.Size = New System.Drawing.Size(110, 66)
		Me.cmdOutPut.TabIndex = 41
		Me.cmdOutPut.Text = "Salida"
		Me.cmdOutPut.UseVisualStyleBackColor = False
		'
		'Button16
		'
		Me.Button16.BackColor = System.Drawing.Color.Gainsboro
		Me.Button16.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
		Me.Button16.FlatAppearance.BorderSize = 0
		Me.Button16.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
		Me.Button16.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
		Me.Button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button16.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Button16.Location = New System.Drawing.Point(3, 75)
		Me.Button16.Name = "Button16"
		Me.Button16.Size = New System.Drawing.Size(110, 66)
		Me.Button16.TabIndex = 42
		Me.Button16.Text = "Transferir Lote"
		Me.Button16.UseVisualStyleBackColor = False
		'
		'VistaGeneral
		'
		Me.VistaGeneral.BackColor = System.Drawing.Color.White
		Me.VistaGeneral.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.VistaGeneral.Controls.Add(Me.gbStudentDetails)
		Me.VistaGeneral.Location = New System.Drawing.Point(4, 35)
		Me.VistaGeneral.Name = "VistaGeneral"
		Me.VistaGeneral.Padding = New System.Windows.Forms.Padding(3)
		Me.VistaGeneral.Size = New System.Drawing.Size(1087, 540)
		Me.VistaGeneral.TabIndex = 0
		Me.VistaGeneral.Text = "Vista General"
		'
		'gbStudentDetails
		'
		Me.gbStudentDetails.Controls.Add(Me.FLIndicators)
		Me.gbStudentDetails.Dock = System.Windows.Forms.DockStyle.Fill
		Me.gbStudentDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.gbStudentDetails.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.gbStudentDetails.ForeColor = System.Drawing.Color.Black
		Me.gbStudentDetails.Location = New System.Drawing.Point(3, 3)
		Me.gbStudentDetails.Name = "gbStudentDetails"
		Me.gbStudentDetails.Size = New System.Drawing.Size(1079, 532)
		Me.gbStudentDetails.TabIndex = 0
		Me.gbStudentDetails.TabStop = False
		Me.gbStudentDetails.Text = "Indicadores Personalizados"
		'
		'FLIndicators
		'
		Me.FLIndicators.Dock = System.Windows.Forms.DockStyle.Fill
		Me.FLIndicators.Location = New System.Drawing.Point(3, 21)
		Me.FLIndicators.Name = "FLIndicators"
		Me.FLIndicators.Size = New System.Drawing.Size(1073, 508)
		Me.FLIndicators.TabIndex = 0
		'
		'tcMain
		'
		Me.tcMain.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
		Me.tcMain.Controls.Add(Me.VistaGeneral)
		Me.tcMain.Controls.Add(Me.Lista_Productos_proceso)
		Me.tcMain.Controls.Add(Me.StatusDiasVacio)
		Me.tcMain.Controls.Add(Me.Animales)
		Me.tcMain.Controls.Add(Me.DescargaProductos)
		Me.tcMain.Controls.Add(Me.Genetica)
		Me.tcMain.Controls.Add(Me.TipoOrigen)
		Me.tcMain.Controls.Add(Me.OrigenAnimal)
		Me.tcMain.Controls.Add(Me.GrupoAnimales)
		Me.tcMain.Dock = System.Windows.Forms.DockStyle.Fill
		Me.tcMain.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.tcMain.HotTrack = True
		Me.tcMain.Location = New System.Drawing.Point(0, 0)
		Me.tcMain.Name = "tcMain"
		Me.tcMain.SelectedIndex = 0
		Me.tcMain.Size = New System.Drawing.Size(1095, 579)
		Me.tcMain.TabIndex = 1
		Me.tcMain.TabStop = False
		'
		'Operaciones_Produccion
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.Controls.Add(Me.tcMain)
		Me.Name = "Operaciones_Produccion"
		Me.Size = New System.Drawing.Size(1095, 579)
		Me.GrupoAnimales.ResumeLayout(False)
		Me.TLPAnimalGroups.ResumeLayout(False)
		CType(Me.DGVAnimalGroup, System.ComponentModel.ISupportInitialize).EndInit()
		Me.FlowLayoutPanel9.ResumeLayout(False)
		Me.OrigenAnimal.ResumeLayout(False)
		Me.TableLayoutPanel4.ResumeLayout(False)
		CType(Me.DGW_Origin, System.ComponentModel.ISupportInitialize).EndInit()
		Me.FlowLayoutPanel8.ResumeLayout(False)
		Me.TipoOrigen.ResumeLayout(False)
		Me.TableLayoutPanel3.ResumeLayout(False)
		CType(Me.DGW_OriginType, System.ComponentModel.ISupportInitialize).EndInit()
		Me.FlowLayoutPanel7.ResumeLayout(False)
		Me.Genetica.ResumeLayout(False)
		Me.TableLayoutPanel2.ResumeLayout(False)
		CType(Me.DGW_Genetic, System.ComponentModel.ISupportInitialize).EndInit()
		Me.FlowLayoutPanel6.ResumeLayout(False)
		Me.DescargaProductos.ResumeLayout(False)
		Me.TLP_PendientesDescarga.ResumeLayout(False)
		CType(Me.DGW_DescargaProductos, System.ComponentModel.ISupportInitialize).EndInit()
		Me.FlowLayoutPanel5.ResumeLayout(False)
		Me.Animales.ResumeLayout(False)
		Me.TableLayoutPanel1.ResumeLayout(False)
		CType(Me.DGVAnimals, System.ComponentModel.ISupportInitialize).EndInit()
		Me.FlowLayoutPanel4.ResumeLayout(False)
		Me.StatusDiasVacio.ResumeLayout(False)
		Me.Lista_Productos_proceso.ResumeLayout(False)
		Me.TLP_Facturacion.ResumeLayout(False)
		CType(Me.DGW_ProductsProcess, System.ComponentModel.ISupportInitialize).EndInit()
		Me.FlowLayoutPanel1.ResumeLayout(False)
		Me.VistaGeneral.ResumeLayout(False)
		Me.gbStudentDetails.ResumeLayout(False)
		Me.tcMain.ResumeLayout(False)
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents StatusTransaction As DataGridViewCheckBoxColumn
	Friend WithEvents GrupoAnimales As TabPage
	Friend WithEvents TLPAnimalGroups As TableLayoutPanel
	Friend WithEvents DGVAnimalGroup As DataGridView
	Friend WithEvents Id_Group As DataGridViewTextBoxColumn
	Friend WithEvents Description As DataGridViewTextBoxColumn
	Friend WithEvents DataGridViewTextBoxColumn22 As DataGridViewTextBoxColumn
	Friend WithEvents DataGridViewTextBoxColumn28 As DataGridViewTextBoxColumn
	Friend WithEvents DataGridViewTextBoxColumn29 As DataGridViewTextBoxColumn
	Friend WithEvents DataGridViewTextBoxColumn34 As DataGridViewTextBoxColumn
	Friend WithEvents FlowLayoutPanel9 As FlowLayoutPanel
	Private WithEvents cmdCreate_AnimalGroup As Button
	Private WithEvents cmdUpdate_AnimalGroup As Button
	Private WithEvents cmdDel_AnimalGroup As Button
	Friend WithEvents OrigenAnimal As TabPage
	Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
	Friend WithEvents DGW_Origin As DataGridView
	Friend WithEvents Id_Origin As DataGridViewTextBoxColumn
	Friend WithEvents Origin_Name As DataGridViewTextBoxColumn
	Friend WithEvents DataGridViewTextBoxColumn30 As DataGridViewTextBoxColumn
	Friend WithEvents DataGridViewTextBoxColumn31 As DataGridViewTextBoxColumn
	Friend WithEvents DataGridViewTextBoxColumn32 As DataGridViewTextBoxColumn
	Friend WithEvents DataGridViewTextBoxColumn33 As DataGridViewTextBoxColumn
	Friend WithEvents FlowLayoutPanel8 As FlowLayoutPanel
	Private WithEvents cmdCreate_Origin As Button
	Private WithEvents cmdUpdate_Origin As Button
	Private WithEvents cmdDel_Origin As Button
	Friend WithEvents TipoOrigen As TabPage
	Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
	Friend WithEvents DGW_OriginType As DataGridView
	Friend WithEvents Id_TypeOrigin As DataGridViewTextBoxColumn
	Friend WithEvents TypeOrigin_Name As DataGridViewTextBoxColumn
	Friend WithEvents DataGridViewTextBoxColumn23 As DataGridViewTextBoxColumn
	Friend WithEvents DataGridViewTextBoxColumn24 As DataGridViewTextBoxColumn
	Friend WithEvents DataGridViewTextBoxColumn25 As DataGridViewTextBoxColumn
	Friend WithEvents DataGridViewTextBoxColumn26 As DataGridViewTextBoxColumn
	Friend WithEvents FlowLayoutPanel7 As FlowLayoutPanel
	Private WithEvents cmdCreate_TypeOrigin As Button
	Private WithEvents cmdUpdate_TypeOrigin As Button
	Private WithEvents cmdDel_TypeOrigin As Button
	Friend WithEvents Genetica As TabPage
	Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
	Friend WithEvents DGW_Genetic As DataGridView
	Friend WithEvents id_Genetica As DataGridViewTextBoxColumn
	Friend WithEvents Genetic_Name As DataGridViewTextBoxColumn
	Friend WithEvents Create_User As DataGridViewTextBoxColumn
	Friend WithEvents DataGridViewTextBoxColumn27 As DataGridViewTextBoxColumn
	Friend WithEvents UserModify As DataGridViewTextBoxColumn
	Friend WithEvents Modify_User As DataGridViewTextBoxColumn
	Friend WithEvents FlowLayoutPanel6 As FlowLayoutPanel
	Private WithEvents cmdCreate_GeneticaAnimals As Button
	Private WithEvents cmdUpdate_GeneticaAnimals As Button
	Private WithEvents cmdDel_GeneticaAnimals As Button
	Friend WithEvents DescargaProductos As TabPage
	Friend WithEvents TLP_PendientesDescarga As TableLayoutPanel
	Friend WithEvents DGW_DescargaProductos As DataGridView
	Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
	Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
	Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
	Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
	Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
	Friend WithEvents DataGridViewTextBoxColumn18 As DataGridViewTextBoxColumn
	Friend WithEvents DataGridViewTextBoxColumn19 As DataGridViewTextBoxColumn
	Friend WithEvents DataGridViewTextBoxColumn20 As DataGridViewTextBoxColumn
	Friend WithEvents FlowLayoutPanel5 As FlowLayoutPanel
	Private WithEvents cmdPendienteDescarga_PasarInventario As Button
	Friend WithEvents Animales As TabPage
	Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
	Friend WithEvents DGVAnimals As DataGridView
	Friend WithEvents FlowLayoutPanel4 As FlowLayoutPanel
	Private WithEvents Button14 As Button
	Private WithEvents Button15 As Button
	Private WithEvents btnEliminar As Button
	Friend WithEvents StatusDiasVacio As TabPage
	Friend WithEvents FLStatusDiasVacio As FlowLayoutPanel
	Friend WithEvents Lista_Productos_proceso As TabPage
	Friend WithEvents TLP_Facturacion As TableLayoutPanel
	Friend WithEvents DGW_ProductsProcess As DataGridView
	Friend WithEvents Correlativo As DataGridViewTextBoxColumn
	Friend WithEvents BusinessDay As DataGridViewTextBoxColumn
	Friend WithEvents Commercial_Name As DataGridViewTextBoxColumn
	Friend WithEvents Fullpayment As DataGridViewTextBoxColumn
	Friend WithEvents semana As DataGridViewTextBoxColumn
	Friend WithEvents DocumentNumber As DataGridViewTextBoxColumn
	Friend WithEvents Column8 As DataGridViewTextBoxColumn
	Friend WithEvents Date_EndProject As DataGridViewTextBoxColumn
	Friend WithEvents UsuarioAnulo As DataGridViewTextBoxColumn
	Friend WithEvents IdProceso As DataGridViewTextBoxColumn
	Friend WithEvents Id_Circle As DataGridViewTextBoxColumn
	Friend WithEvents Id_CicloRef As DataGridViewTextBoxColumn
	Friend WithEvents IS_StageAlarm As DataGridViewTextBoxColumn
	Friend WithEvents ID_Product_FK As DataGridViewTextBoxColumn
	Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
	Private WithEvents cmdCreateLote As Button
	Private WithEvents cmdModLote As Button
	Private WithEvents cmdCatalogoClienteFinanciero As Button
	Private WithEvents cmdCatalogoClienteFinancieroSeleccion As Button
	Private WithEvents cmdReporteProveedores As Button
	Private WithEvents btnFormDinamico As Button
	Private WithEvents cmdReportGeneral As Button
	Private WithEvents cmdOutPut As Button
	Private WithEvents Button16 As Button
	Private WithEvents VistaGeneral As TabPage
	Private WithEvents gbStudentDetails As GroupBox
	Friend WithEvents FLIndicators As FlowLayoutPanel
	Private WithEvents tcMain As TabControl
End Class
