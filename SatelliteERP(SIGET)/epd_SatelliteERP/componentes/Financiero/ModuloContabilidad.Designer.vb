<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModuloContabilidad
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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
        Me.components = New System.ComponentModel.Container()
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Efectivo en caja")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Caja General")
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Caja chica")
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Cuentas Corrientes")
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Cuentas Ahorro")
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Efectivo en Bancos", New System.Windows.Forms.TreeNode() {TreeNode4, TreeNode5})
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Activo Corriente", New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2, TreeNode3, TreeNode6})
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Cuentas por cobrar")
        Dim TreeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Accionistas")
        Dim TreeNode10 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Activos", New System.Windows.Forms.TreeNode() {TreeNode7, TreeNode8, TreeNode9})
        Dim TreeNode11 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Pasivo")
        Dim TreeNode12 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Patrimonio")
        Dim TreeNode13 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Nodo4")
        Dim TreeNode14 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Nodo5")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ModuloContabilidad))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle23 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle24 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle25 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle26 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle27 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle28 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle29 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle30 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle31 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle32 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle33 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle34 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle35 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle36 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle37 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle38 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle39 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle40 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle41 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle42 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle43 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle44 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle45 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle46 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle47 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle48 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle49 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle50 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ERP_Finance_ReportAccountingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EPD_SatelliteERPDataSet = New epd_SatelliteERP.EPD_SatelliteERPDataSet()
        Me.pnlMain = New System.Windows.Forms.Panel()
        Me.lblMainTitle = New System.Windows.Forms.Label()
        Me.tcMain = New System.Windows.Forms.TabControl()
        Me.CatalogoContable = New System.Windows.Forms.TabPage()
        Me.gbStudentDetails = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.NumeroCuentaContable = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreCuentaContable = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsersCreate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateCreate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsersModify = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateModify = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.CM_CuentaContable = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CrearCuentaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarCuentaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarCuentaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.lblCopyright = New System.Windows.Forms.Label()
        Me.TrabajarPartidas = New System.Windows.Forms.TabPage()
        Me.FLP_PartidasContables = New System.Windows.Forms.TableLayoutPanel()
        Me.DG_AccountingIitemHeading = New System.Windows.Forms.DataGridView()
        Me.Imagen = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Correlativo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NoPartida = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Clasificacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Concepto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalAbono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalCargo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Usuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaCreacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Is_Square = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Date_Square = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Is_Posting = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DatePosting = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CM_PartidasContables = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CrearPartidaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CrearPartidaFechaPorParametroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarPartidaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarPartidaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CrearPartidadContablePorDistribucionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FLP_MenuPartidas = New System.Windows.Forms.FlowLayoutPanel()
        Me.cmdCreate = New System.Windows.Forms.Button()
        Me.cmdPreview = New System.Windows.Forms.Button()
        Me.cmdLibroMayor = New System.Windows.Forms.Button()
        Me.cmd_Partida_RevertirPartida = New System.Windows.Forms.Button()
        Me.cmd_Partida_CopiaPartida = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Contabilizar = New System.Windows.Forms.TabPage()
        Me.FLP_Contabilizar = New System.Windows.Forms.TableLayoutPanel()
        Me.DG_Contabilizar = New System.Windows.Forms.DataGridView()
        Me.Imagen1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Id_AccountingIitemHeading = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BusinessDay = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Name_ClassificationItemType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Concept_AccountingIitemHeading = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total_Charge = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total_Deposit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsersCreate1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateCreate1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Is_Square1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Date_Square1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Is_Posting1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DatePosting1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FLP_MenuContablizar = New System.Windows.Forms.FlowLayoutPanel()
        Me.cmdContabilizar = New System.Windows.Forms.Button()
        Me.cmdPartidaGestionContable = New System.Windows.Forms.Button()
        Me.cmdContabilidadLibroMayorPreview = New System.Windows.Forms.Button()
        Me.cmdContabilidadLibroAuxiliarPreview = New System.Windows.Forms.Button()
        Me.cmdBalance = New System.Windows.Forms.Button()
        Me.cmdBalanceComprobacion = New System.Windows.Forms.Button()
        Me.CloseGestion = New System.Windows.Forms.TabPage()
        Me.TLP_Ledger = New System.Windows.Forms.TableLayoutPanel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewImageColumn3 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn2 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FLP_LedgerTools = New System.Windows.Forms.FlowLayoutPanel()
        Me.cmdLadgerPreview = New System.Windows.Forms.Button()
        Me.cmdLadgerPrinter = New System.Windows.Forms.Button()
        Me.cmdClosePeriod = New System.Windows.Forms.Button()
        Me.cmdLadgerPrinterCero = New System.Windows.Forms.Button()
        Me.cmdLadgerPreviewFull = New System.Windows.Forms.Button()
        Me.cmdLadgerPriviewFull = New System.Windows.Forms.Button()
        Me.HistoryYear = New System.Windows.Forms.TabPage()
        Me.TLP_FiscalDocTools = New System.Windows.Forms.TableLayoutPanel()
        Me.DGW_YearCurrentList = New System.Windows.Forms.DataGridView()
        Me.DataGridViewImageColumn4 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.cmdPartidaContable = New System.Windows.Forms.Button()
        Me.cmdLibroDiarioHistorico = New System.Windows.Forms.Button()
        Me.cmdHistoryLibroMayor = New System.Windows.Forms.Button()
        Me.cmdHistoryLibroAuxiliar = New System.Windows.Forms.Button()
        Me.cmdHistoryBalanceGeneral = New System.Windows.Forms.Button()
        Me.cmdHistoryBalanceComprobacion = New System.Windows.Forms.Button()
        Me.HistoryYearOld = New System.Windows.Forms.TabPage()
        Me.TLP_YearOLD = New System.Windows.Forms.TableLayoutPanel()
        Me.DGW_YearOLD = New System.Windows.Forms.DataGridView()
        Me.DataGridViewImageColumn5 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.ConfigExternal = New System.Windows.Forms.TabPage()
        Me.TLP_ConfigExternal = New System.Windows.Forms.TableLayoutPanel()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewImageColumn6 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn25 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn26 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn27 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn28 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn29 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FlowLayoutPanel3 = New System.Windows.Forms.FlowLayoutPanel()
        Me.cmdPartidaConfigSistemaExternoCreate = New System.Windows.Forms.Button()
        Me.cmdPartidaConfigSistemaExternoModify = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn2 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.ERP_Finance_ReportAccountingTableAdapter = New epd_SatelliteERP.EPD_SatelliteERPDataSetTableAdapters.ERP_Finance_ReportAccountingTableAdapter()
        CType(Me.ERP_Finance_ReportAccountingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EPD_SatelliteERPDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlMain.SuspendLayout()
        Me.tcMain.SuspendLayout()
        Me.CatalogoContable.SuspendLayout()
        Me.gbStudentDetails.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CM_CuentaContable.SuspendLayout()
        Me.TrabajarPartidas.SuspendLayout()
        Me.FLP_PartidasContables.SuspendLayout()
        CType(Me.DG_AccountingIitemHeading, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CM_PartidasContables.SuspendLayout()
        Me.FLP_MenuPartidas.SuspendLayout()
        Me.Contabilizar.SuspendLayout()
        Me.FLP_Contabilizar.SuspendLayout()
        CType(Me.DG_Contabilizar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FLP_MenuContablizar.SuspendLayout()
        Me.CloseGestion.SuspendLayout()
        Me.TLP_Ledger.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FLP_LedgerTools.SuspendLayout()
        Me.HistoryYear.SuspendLayout()
        Me.TLP_FiscalDocTools.SuspendLayout()
        CType(Me.DGW_YearCurrentList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.HistoryYearOld.SuspendLayout()
        Me.TLP_YearOLD.SuspendLayout()
        CType(Me.DGW_YearOLD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.ConfigExternal.SuspendLayout()
        Me.TLP_ConfigExternal.SuspendLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'ERP_Finance_ReportAccountingBindingSource
        '
        Me.ERP_Finance_ReportAccountingBindingSource.DataMember = "ERP_Finance_ReportAccounting"
        Me.ERP_Finance_ReportAccountingBindingSource.DataSource = Me.EPD_SatelliteERPDataSet
        '
        'EPD_SatelliteERPDataSet
        '
        Me.EPD_SatelliteERPDataSet.DataSetName = "EPD_SatelliteERPDataSet"
        Me.EPD_SatelliteERPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'pnlMain
        '
        Me.pnlMain.BackColor = System.Drawing.Color.Transparent
        Me.pnlMain.Controls.Add(Me.lblMainTitle)
        Me.pnlMain.Controls.Add(Me.tcMain)
        Me.pnlMain.Location = New System.Drawing.Point(-43, -41)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(1139, 648)
        Me.pnlMain.TabIndex = 17
        '
        'lblMainTitle
        '
        Me.lblMainTitle.AutoSize = True
        Me.lblMainTitle.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMainTitle.Location = New System.Drawing.Point(-5, -2)
        Me.lblMainTitle.Name = "lblMainTitle"
        Me.lblMainTitle.Size = New System.Drawing.Size(175, 30)
        Me.lblMainTitle.TabIndex = 5
        Me.lblMainTitle.Text = "Manage Students"
        '
        'tcMain
        '
        Me.tcMain.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.tcMain.Controls.Add(Me.CatalogoContable)
        Me.tcMain.Controls.Add(Me.TrabajarPartidas)
        Me.tcMain.Controls.Add(Me.Contabilizar)
        Me.tcMain.Controls.Add(Me.CloseGestion)
        Me.tcMain.Controls.Add(Me.HistoryYear)
        Me.tcMain.Controls.Add(Me.HistoryYearOld)
        Me.tcMain.Controls.Add(Me.ConfigExternal)
        Me.tcMain.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tcMain.HotTrack = True
        Me.tcMain.Location = New System.Drawing.Point(47, 44)
        Me.tcMain.Name = "tcMain"
        Me.tcMain.SelectedIndex = 0
        Me.tcMain.Size = New System.Drawing.Size(1095, 579)
        Me.tcMain.TabIndex = 1
        Me.tcMain.TabStop = False
        '
        'CatalogoContable
        '
        Me.CatalogoContable.BackColor = System.Drawing.Color.White
        Me.CatalogoContable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CatalogoContable.Controls.Add(Me.gbStudentDetails)
        Me.CatalogoContable.Controls.Add(Me.lblCopyright)
        Me.CatalogoContable.Location = New System.Drawing.Point(4, 35)
        Me.CatalogoContable.Name = "CatalogoContable"
        Me.CatalogoContable.Padding = New System.Windows.Forms.Padding(3)
        Me.CatalogoContable.Size = New System.Drawing.Size(1087, 540)
        Me.CatalogoContable.TabIndex = 0
        Me.CatalogoContable.Text = "Catálogo Contable"
        '
        'gbStudentDetails
        '
        Me.gbStudentDetails.Controls.Add(Me.TableLayoutPanel1)
        Me.gbStudentDetails.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbStudentDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.gbStudentDetails.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbStudentDetails.ForeColor = System.Drawing.Color.Black
        Me.gbStudentDetails.Location = New System.Drawing.Point(3, 3)
        Me.gbStudentDetails.Name = "gbStudentDetails"
        Me.gbStudentDetails.Size = New System.Drawing.Size(1079, 532)
        Me.gbStudentDetails.TabIndex = 4
        Me.gbStudentDetails.TabStop = False
        Me.gbStudentDetails.Text = "Catalogo Contable"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 660.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.DataGridView2, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TreeView1, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 21)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1073, 508)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AllowUserToResizeColumns = False
        Me.DataGridView2.AllowUserToResizeRows = False
        Me.DataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NumeroCuentaContable, Me.NombreCuentaContable, Me.UsersCreate, Me.DateCreate, Me.UsersModify, Me.DateModify})
        Me.DataGridView2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView2.EnableHeadersVisualStyles = False
        Me.DataGridView2.Location = New System.Drawing.Point(416, 3)
        Me.DataGridView2.MultiSelect = False
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.RowHeadersVisible = False
        Me.DataGridView2.Size = New System.Drawing.Size(654, 502)
        Me.DataGridView2.TabIndex = 1
        '
        'NumeroCuentaContable
        '
        Me.NumeroCuentaContable.DataPropertyName = "NumeroCuentaContable"
        Me.NumeroCuentaContable.HeaderText = "No. Cuenta Contable"
        Me.NumeroCuentaContable.Name = "NumeroCuentaContable"
        Me.NumeroCuentaContable.ReadOnly = True
        Me.NumeroCuentaContable.Width = 141
        '
        'NombreCuentaContable
        '
        Me.NombreCuentaContable.DataPropertyName = "NombreCuentaContable"
        Me.NombreCuentaContable.FillWeight = 300.0!
        Me.NombreCuentaContable.HeaderText = "Cuenta Contable"
        Me.NombreCuentaContable.Name = "NombreCuentaContable"
        Me.NombreCuentaContable.ReadOnly = True
        Me.NombreCuentaContable.Width = 300
        '
        'UsersCreate
        '
        Me.UsersCreate.DataPropertyName = "UsersCreate"
        Me.UsersCreate.HeaderText = "Usuario Creo"
        Me.UsersCreate.Name = "UsersCreate"
        Me.UsersCreate.ReadOnly = True
        Me.UsersCreate.Width = 101
        '
        'DateCreate
        '
        Me.DateCreate.DataPropertyName = "DateCreate"
        Me.DateCreate.HeaderText = "Fecha Creacion"
        Me.DateCreate.Name = "DateCreate"
        Me.DateCreate.ReadOnly = True
        Me.DateCreate.Width = 111
        '
        'UsersModify
        '
        Me.UsersModify.DataPropertyName = "UsersModify"
        Me.UsersModify.HeaderText = "Usuario Modifico"
        Me.UsersModify.Name = "UsersModify"
        Me.UsersModify.ReadOnly = True
        Me.UsersModify.Width = 123
        '
        'DateModify
        '
        Me.DateModify.DataPropertyName = "DateModify"
        Me.DateModify.HeaderText = "Fecha Modificacion"
        Me.DateModify.Name = "DateModify"
        Me.DateModify.ReadOnly = True
        Me.DateModify.Width = 132
        '
        'TreeView1
        '
        Me.TreeView1.ContextMenuStrip = Me.CM_CuentaContable
        Me.TreeView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeView1.ImageIndex = 0
        Me.TreeView1.ImageList = Me.ImageList1
        Me.TreeView1.Location = New System.Drawing.Point(3, 3)
        Me.TreeView1.Name = "TreeView1"
        TreeNode1.Name = "Efectivo en caja"
        TreeNode1.Text = "Efectivo en caja"
        TreeNode2.Name = "Caja General"
        TreeNode2.Text = "Caja General"
        TreeNode3.Name = "Caja chica"
        TreeNode3.Text = "Caja chica"
        TreeNode4.Name = "Cuentas Corrientes"
        TreeNode4.Text = "Cuentas Corrientes"
        TreeNode5.Name = "Cuentas Ahorro"
        TreeNode5.Text = "Cuentas Ahorro"
        TreeNode6.Name = "Efectivo en Bancos"
        TreeNode6.Text = "Efectivo en Bancos"
        TreeNode7.Name = "Activo Corriente"
        TreeNode7.Text = "Activo Corriente"
        TreeNode8.Name = "Cuentas por cobrar"
        TreeNode8.Text = "Cuentas por cobrar"
        TreeNode9.Name = "Accionistas"
        TreeNode9.Text = "Accionistas"
        TreeNode10.Name = "Activos"
        TreeNode10.Text = "Activos"
        TreeNode11.Name = "Pasivo"
        TreeNode11.Text = "Pasivo"
        TreeNode12.Name = "Patrimonio"
        TreeNode12.Text = "Patrimonio"
        TreeNode13.Name = "Nodo4"
        TreeNode13.Text = "Nodo4"
        TreeNode14.Name = "Nodo5"
        TreeNode14.Text = "Nodo5"
        Me.TreeView1.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode10, TreeNode11, TreeNode12, TreeNode13, TreeNode14})
        Me.TreeView1.SelectedImageIndex = 0
        Me.TreeView1.Size = New System.Drawing.Size(407, 502)
        Me.TreeView1.TabIndex = 0
        '
        'CM_CuentaContable
        '
        Me.CM_CuentaContable.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CrearCuentaToolStripMenuItem, Me.EliminarCuentaToolStripMenuItem, Me.ModificarCuentaToolStripMenuItem})
        Me.CM_CuentaContable.Name = "ContextMenuStrip1"
        Me.CM_CuentaContable.Size = New System.Drawing.Size(167, 70)
        '
        'CrearCuentaToolStripMenuItem
        '
        Me.CrearCuentaToolStripMenuItem.Name = "CrearCuentaToolStripMenuItem"
        Me.CrearCuentaToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.CrearCuentaToolStripMenuItem.Text = "Crear Cuenta"
        '
        'EliminarCuentaToolStripMenuItem
        '
        Me.EliminarCuentaToolStripMenuItem.Name = "EliminarCuentaToolStripMenuItem"
        Me.EliminarCuentaToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.EliminarCuentaToolStripMenuItem.Text = "Eliminar Cuenta"
        '
        'ModificarCuentaToolStripMenuItem
        '
        Me.ModificarCuentaToolStripMenuItem.Name = "ModificarCuentaToolStripMenuItem"
        Me.ModificarCuentaToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.ModificarCuentaToolStripMenuItem.Text = "Modificar Cuenta"
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "Fecha-Verde.png")
        Me.ImageList1.Images.SetKeyName(1, "Suma-Verde.png")
        Me.ImageList1.Images.SetKeyName(2, "FechaTope-Verde.png")
        Me.ImageList1.Images.SetKeyName(3, "Mayor y Menior-Verde.png")
        '
        'lblCopyright
        '
        Me.lblCopyright.AutoSize = True
        Me.lblCopyright.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCopyright.Location = New System.Drawing.Point(395, 508)
        Me.lblCopyright.Name = "lblCopyright"
        Me.lblCopyright.Size = New System.Drawing.Size(249, 21)
        Me.lblCopyright.TabIndex = 4
        Me.lblCopyright.Text = "Copyright @ EPDSOFT.COM, 2016"
        '
        'TrabajarPartidas
        '
        Me.TrabajarPartidas.Controls.Add(Me.FLP_PartidasContables)
        Me.TrabajarPartidas.Location = New System.Drawing.Point(4, 35)
        Me.TrabajarPartidas.Name = "TrabajarPartidas"
        Me.TrabajarPartidas.Size = New System.Drawing.Size(1087, 540)
        Me.TrabajarPartidas.TabIndex = 4
        Me.TrabajarPartidas.Text = "Partidas"
        Me.TrabajarPartidas.UseVisualStyleBackColor = True
        '
        'FLP_PartidasContables
        '
        Me.FLP_PartidasContables.ColumnCount = 1
        Me.FLP_PartidasContables.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.FLP_PartidasContables.Controls.Add(Me.DG_AccountingIitemHeading, 0, 1)
        Me.FLP_PartidasContables.Controls.Add(Me.FLP_MenuPartidas, 0, 0)
        Me.FLP_PartidasContables.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FLP_PartidasContables.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.FLP_PartidasContables.Location = New System.Drawing.Point(0, 0)
        Me.FLP_PartidasContables.Name = "FLP_PartidasContables"
        Me.FLP_PartidasContables.RowCount = 2
        Me.FLP_PartidasContables.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75.0!))
        Me.FLP_PartidasContables.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.FLP_PartidasContables.Size = New System.Drawing.Size(1087, 540)
        Me.FLP_PartidasContables.TabIndex = 1
        '
        'DG_AccountingIitemHeading
        '
        Me.DG_AccountingIitemHeading.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DG_AccountingIitemHeading.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Imagen, Me.Correlativo, Me.NoPartida, Me.Estado, Me.Fecha, Me.Clasificacion, Me.Concepto, Me.TotalAbono, Me.TotalCargo, Me.Usuario, Me.FechaCreacion, Me.Is_Square, Me.Date_Square, Me.Is_Posting, Me.DatePosting})
        Me.DG_AccountingIitemHeading.ContextMenuStrip = Me.CM_PartidasContables
        Me.DG_AccountingIitemHeading.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DG_AccountingIitemHeading.EnableHeadersVisualStyles = False
        Me.DG_AccountingIitemHeading.Location = New System.Drawing.Point(3, 78)
        Me.DG_AccountingIitemHeading.Name = "DG_AccountingIitemHeading"
        Me.DG_AccountingIitemHeading.RowHeadersVisible = False
        Me.DG_AccountingIitemHeading.ShowCellErrors = False
        Me.DG_AccountingIitemHeading.ShowCellToolTips = False
        Me.DG_AccountingIitemHeading.ShowEditingIcon = False
        Me.DG_AccountingIitemHeading.ShowRowErrors = False
        Me.DG_AccountingIitemHeading.Size = New System.Drawing.Size(1081, 459)
        Me.DG_AccountingIitemHeading.TabIndex = 0
        '
        'Imagen
        '
        Me.Imagen.Frozen = True
        Me.Imagen.HeaderText = ""
        Me.Imagen.Image = Global.epd_SatelliteERP.My.Resources.Resources.Roja_Bandera
        Me.Imagen.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch
        Me.Imagen.Name = "Imagen"
        Me.Imagen.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Imagen.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Imagen.Width = 50
        '
        'Correlativo
        '
        Me.Correlativo.DataPropertyName = "Id_AccountingIitemHeading"
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.Correlativo.DefaultCellStyle = DataGridViewCellStyle1
        Me.Correlativo.HeaderText = "Correlativo"
        Me.Correlativo.Name = "Correlativo"
        Me.Correlativo.Width = 123
        '
        'NoPartida
        '
        Me.NoPartida.DataPropertyName = "Id_AccountingIitemHeading"
        Me.NoPartida.HeaderText = "No. Partida"
        Me.NoPartida.Name = "NoPartida"
        '
        'Estado
        '
        Me.Estado.HeaderText = "Estado"
        Me.Estado.Name = "Estado"
        '
        'Fecha
        '
        Me.Fecha.DataPropertyName = "BusinessDay"
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.Fecha.DefaultCellStyle = DataGridViewCellStyle2
        Me.Fecha.HeaderText = "Fecha"
        Me.Fecha.Name = "Fecha"
        Me.Fecha.Width = 82
        '
        'Clasificacion
        '
        Me.Clasificacion.DataPropertyName = "Name_ClassificationItemType"
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.Clasificacion.DefaultCellStyle = DataGridViewCellStyle3
        Me.Clasificacion.HeaderText = "Clasificacion"
        Me.Clasificacion.Name = "Clasificacion"
        Me.Clasificacion.Width = 133
        '
        'Concepto
        '
        Me.Concepto.DataPropertyName = "Concept_AccountingIitemHeading"
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.Concepto.DefaultCellStyle = DataGridViewCellStyle4
        Me.Concepto.HeaderText = "Concepto"
        Me.Concepto.Name = "Concepto"
        Me.Concepto.Width = 114
        '
        'TotalAbono
        '
        Me.TotalAbono.DataPropertyName = "Total_Charge"
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.TotalAbono.DefaultCellStyle = DataGridViewCellStyle5
        Me.TotalAbono.HeaderText = "Total Abono"
        Me.TotalAbono.Name = "TotalAbono"
        Me.TotalAbono.Width = 136
        '
        'TotalCargo
        '
        Me.TotalCargo.DataPropertyName = "Total_Deposit"
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.TotalCargo.DefaultCellStyle = DataGridViewCellStyle6
        Me.TotalCargo.HeaderText = "Total Cargo"
        Me.TotalCargo.Name = "TotalCargo"
        Me.TotalCargo.Width = 129
        '
        'Usuario
        '
        Me.Usuario.DataPropertyName = "UsersCreate"
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.Usuario.DefaultCellStyle = DataGridViewCellStyle7
        Me.Usuario.HeaderText = "Usuario"
        Me.Usuario.Name = "Usuario"
        Me.Usuario.Width = 97
        '
        'FechaCreacion
        '
        Me.FechaCreacion.DataPropertyName = "DateCreate"
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.FechaCreacion.DefaultCellStyle = DataGridViewCellStyle8
        Me.FechaCreacion.HeaderText = "Fecha Creacion"
        Me.FechaCreacion.Name = "FechaCreacion"
        Me.FechaCreacion.Width = 155
        '
        'Is_Square
        '
        Me.Is_Square.DataPropertyName = "Is_Square"
        Me.Is_Square.HeaderText = "Cuadrada"
        Me.Is_Square.Name = "Is_Square"
        Me.Is_Square.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Is_Square.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'Date_Square
        '
        Me.Date_Square.DataPropertyName = "Date_Square"
        Me.Date_Square.HeaderText = "F. Cuadre"
        Me.Date_Square.Name = "Date_Square"
        '
        'Is_Posting
        '
        Me.Is_Posting.DataPropertyName = "Is_Posting"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        DataGridViewCellStyle9.NullValue = False
        Me.Is_Posting.DefaultCellStyle = DataGridViewCellStyle9
        Me.Is_Posting.HeaderText = "Contabilizado"
        Me.Is_Posting.Name = "Is_Posting"
        Me.Is_Posting.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Is_Posting.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Is_Posting.Width = 105
        '
        'DatePosting
        '
        Me.DatePosting.DataPropertyName = "DatePosting"
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.DatePosting.DefaultCellStyle = DataGridViewCellStyle10
        Me.DatePosting.HeaderText = "F. Contabilizacion"
        Me.DatePosting.Name = "DatePosting"
        Me.DatePosting.Width = 110
        '
        'CM_PartidasContables
        '
        Me.CM_PartidasContables.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CrearPartidaToolStripMenuItem, Me.CrearPartidaFechaPorParametroToolStripMenuItem, Me.ModificarPartidaToolStripMenuItem, Me.EliminarPartidaToolStripMenuItem, Me.CrearPartidadContablePorDistribucionToolStripMenuItem})
        Me.CM_PartidasContables.Name = "CM_PartidasContables"
        Me.CM_PartidasContables.Size = New System.Drawing.Size(288, 114)
        '
        'CrearPartidaToolStripMenuItem
        '
        Me.CrearPartidaToolStripMenuItem.Name = "CrearPartidaToolStripMenuItem"
        Me.CrearPartidaToolStripMenuItem.Size = New System.Drawing.Size(287, 22)
        Me.CrearPartidaToolStripMenuItem.Text = "Crear Partida"
        '
        'CrearPartidaFechaPorParametroToolStripMenuItem
        '
        Me.CrearPartidaFechaPorParametroToolStripMenuItem.Name = "CrearPartidaFechaPorParametroToolStripMenuItem"
        Me.CrearPartidaFechaPorParametroToolStripMenuItem.Size = New System.Drawing.Size(287, 22)
        Me.CrearPartidaFechaPorParametroToolStripMenuItem.Text = "Crear Partida Fecha (Por Parametro)"
        '
        'ModificarPartidaToolStripMenuItem
        '
        Me.ModificarPartidaToolStripMenuItem.Name = "ModificarPartidaToolStripMenuItem"
        Me.ModificarPartidaToolStripMenuItem.Size = New System.Drawing.Size(287, 22)
        Me.ModificarPartidaToolStripMenuItem.Text = "Modificar Partida"
        '
        'EliminarPartidaToolStripMenuItem
        '
        Me.EliminarPartidaToolStripMenuItem.Name = "EliminarPartidaToolStripMenuItem"
        Me.EliminarPartidaToolStripMenuItem.Size = New System.Drawing.Size(287, 22)
        Me.EliminarPartidaToolStripMenuItem.Text = "Eliminar Partida"
        '
        'CrearPartidadContablePorDistribucionToolStripMenuItem
        '
        Me.CrearPartidadContablePorDistribucionToolStripMenuItem.Name = "CrearPartidadContablePorDistribucionToolStripMenuItem"
        Me.CrearPartidadContablePorDistribucionToolStripMenuItem.Size = New System.Drawing.Size(287, 22)
        Me.CrearPartidadContablePorDistribucionToolStripMenuItem.Text = "Crear Partidad Contable por distribucion"
        '
        'FLP_MenuPartidas
        '
        Me.FLP_MenuPartidas.Controls.Add(Me.cmdCreate)
        Me.FLP_MenuPartidas.Controls.Add(Me.cmdPreview)
        Me.FLP_MenuPartidas.Controls.Add(Me.cmdLibroMayor)
        Me.FLP_MenuPartidas.Controls.Add(Me.cmd_Partida_RevertirPartida)
        Me.FLP_MenuPartidas.Controls.Add(Me.cmd_Partida_CopiaPartida)
        Me.FLP_MenuPartidas.Controls.Add(Me.Button6)
        Me.FLP_MenuPartidas.Controls.Add(Me.Button12)
        Me.FLP_MenuPartidas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FLP_MenuPartidas.Location = New System.Drawing.Point(3, 3)
        Me.FLP_MenuPartidas.Name = "FLP_MenuPartidas"
        Me.FLP_MenuPartidas.Size = New System.Drawing.Size(1081, 69)
        Me.FLP_MenuPartidas.TabIndex = 1
        '
        'cmdCreate
        '
        Me.cmdCreate.BackColor = System.Drawing.Color.Gainsboro
        Me.cmdCreate.ContextMenuStrip = Me.CM_PartidasContables
        Me.cmdCreate.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdCreate.FlatAppearance.BorderSize = 0
        Me.cmdCreate.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.cmdCreate.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.cmdCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCreate.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCreate.Location = New System.Drawing.Point(3, 3)
        Me.cmdCreate.Name = "cmdCreate"
        Me.cmdCreate.Size = New System.Drawing.Size(98, 66)
        Me.cmdCreate.TabIndex = 30
        Me.cmdCreate.Text = "Crear"
        Me.cmdCreate.UseVisualStyleBackColor = False
        '
        'cmdPreview
        '
        Me.cmdPreview.BackColor = System.Drawing.Color.Gainsboro
        Me.cmdPreview.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdPreview.FlatAppearance.BorderSize = 0
        Me.cmdPreview.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.cmdPreview.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.cmdPreview.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdPreview.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPreview.Location = New System.Drawing.Point(107, 3)
        Me.cmdPreview.Name = "cmdPreview"
        Me.cmdPreview.Size = New System.Drawing.Size(98, 66)
        Me.cmdPreview.TabIndex = 31
        Me.cmdPreview.Text = "Vista Preliminar"
        Me.cmdPreview.UseVisualStyleBackColor = False
        '
        'cmdLibroMayor
        '
        Me.cmdLibroMayor.BackColor = System.Drawing.Color.Gainsboro
        Me.cmdLibroMayor.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdLibroMayor.FlatAppearance.BorderSize = 0
        Me.cmdLibroMayor.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.cmdLibroMayor.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.cmdLibroMayor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdLibroMayor.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLibroMayor.Location = New System.Drawing.Point(211, 3)
        Me.cmdLibroMayor.Name = "cmdLibroMayor"
        Me.cmdLibroMayor.Size = New System.Drawing.Size(114, 66)
        Me.cmdLibroMayor.TabIndex = 32
        Me.cmdLibroMayor.Text = "Libro Diario Preliminar"
        Me.cmdLibroMayor.UseVisualStyleBackColor = False
        '
        'cmd_Partida_RevertirPartida
        '
        Me.cmd_Partida_RevertirPartida.BackColor = System.Drawing.Color.Gainsboro
        Me.cmd_Partida_RevertirPartida.ContextMenuStrip = Me.CM_PartidasContables
        Me.cmd_Partida_RevertirPartida.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmd_Partida_RevertirPartida.FlatAppearance.BorderSize = 0
        Me.cmd_Partida_RevertirPartida.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.cmd_Partida_RevertirPartida.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.cmd_Partida_RevertirPartida.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_Partida_RevertirPartida.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_Partida_RevertirPartida.Location = New System.Drawing.Point(331, 3)
        Me.cmd_Partida_RevertirPartida.Name = "cmd_Partida_RevertirPartida"
        Me.cmd_Partida_RevertirPartida.Size = New System.Drawing.Size(98, 66)
        Me.cmd_Partida_RevertirPartida.TabIndex = 33
        Me.cmd_Partida_RevertirPartida.Text = "Revertir"
        Me.cmd_Partida_RevertirPartida.UseVisualStyleBackColor = False
        '
        'cmd_Partida_CopiaPartida
        '
        Me.cmd_Partida_CopiaPartida.BackColor = System.Drawing.Color.Gainsboro
        Me.cmd_Partida_CopiaPartida.ContextMenuStrip = Me.CM_PartidasContables
        Me.cmd_Partida_CopiaPartida.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmd_Partida_CopiaPartida.FlatAppearance.BorderSize = 0
        Me.cmd_Partida_CopiaPartida.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.cmd_Partida_CopiaPartida.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.cmd_Partida_CopiaPartida.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_Partida_CopiaPartida.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_Partida_CopiaPartida.Location = New System.Drawing.Point(435, 3)
        Me.cmd_Partida_CopiaPartida.Name = "cmd_Partida_CopiaPartida"
        Me.cmd_Partida_CopiaPartida.Size = New System.Drawing.Size(98, 66)
        Me.cmd_Partida_CopiaPartida.TabIndex = 34
        Me.cmd_Partida_CopiaPartida.Text = "Copiar"
        Me.cmd_Partida_CopiaPartida.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.Gainsboro
        Me.Button6.ContextMenuStrip = Me.CM_PartidasContables
        Me.Button6.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.Button6.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(539, 3)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(116, 66)
        Me.Button6.TabIndex = 35
        Me.Button6.Text = "Revertir mes anterior"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button12
        '
        Me.Button12.BackColor = System.Drawing.Color.Gainsboro
        Me.Button12.ContextMenuStrip = Me.CM_PartidasContables
        Me.Button12.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.Button12.FlatAppearance.BorderSize = 0
        Me.Button12.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.Button12.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.Button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button12.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button12.Location = New System.Drawing.Point(661, 3)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(98, 66)
        Me.Button12.TabIndex = 36
        Me.Button12.Text = "Copiar mes anterior"
        Me.Button12.UseVisualStyleBackColor = False
        '
        'Contabilizar
        '
        Me.Contabilizar.BackColor = System.Drawing.Color.White
        Me.Contabilizar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Contabilizar.Controls.Add(Me.FLP_Contabilizar)
        Me.Contabilizar.Location = New System.Drawing.Point(4, 35)
        Me.Contabilizar.Name = "Contabilizar"
        Me.Contabilizar.Padding = New System.Windows.Forms.Padding(3)
        Me.Contabilizar.Size = New System.Drawing.Size(1087, 540)
        Me.Contabilizar.TabIndex = 1
        Me.Contabilizar.Text = "Gestión Contable"
        '
        'FLP_Contabilizar
        '
        Me.FLP_Contabilizar.ColumnCount = 1
        Me.FLP_Contabilizar.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.FLP_Contabilizar.Controls.Add(Me.DG_Contabilizar, 0, 1)
        Me.FLP_Contabilizar.Controls.Add(Me.FLP_MenuContablizar, 0, 0)
        Me.FLP_Contabilizar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FLP_Contabilizar.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.FLP_Contabilizar.Location = New System.Drawing.Point(3, 3)
        Me.FLP_Contabilizar.Name = "FLP_Contabilizar"
        Me.FLP_Contabilizar.RowCount = 2
        Me.FLP_Contabilizar.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75.0!))
        Me.FLP_Contabilizar.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.FLP_Contabilizar.Size = New System.Drawing.Size(1079, 532)
        Me.FLP_Contabilizar.TabIndex = 2
        '
        'DG_Contabilizar
        '
        Me.DG_Contabilizar.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DG_Contabilizar.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Imagen1, Me.Id_AccountingIitemHeading, Me.BusinessDay, Me.Name_ClassificationItemType, Me.Concept_AccountingIitemHeading, Me.Total_Charge, Me.Total_Deposit, Me.UsersCreate1, Me.DateCreate1, Me.Is_Square1, Me.Date_Square1, Me.Is_Posting1, Me.DatePosting1})
        Me.DG_Contabilizar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DG_Contabilizar.EnableHeadersVisualStyles = False
        Me.DG_Contabilizar.Location = New System.Drawing.Point(3, 78)
        Me.DG_Contabilizar.Name = "DG_Contabilizar"
        Me.DG_Contabilizar.RowHeadersVisible = False
        Me.DG_Contabilizar.ShowCellErrors = False
        Me.DG_Contabilizar.ShowCellToolTips = False
        Me.DG_Contabilizar.ShowEditingIcon = False
        Me.DG_Contabilizar.ShowRowErrors = False
        Me.DG_Contabilizar.Size = New System.Drawing.Size(1073, 451)
        Me.DG_Contabilizar.TabIndex = 0
        '
        'Imagen1
        '
        Me.Imagen1.Frozen = True
        Me.Imagen1.HeaderText = ""
        Me.Imagen1.Image = Global.epd_SatelliteERP.My.Resources.Resources.Roja_Bandera
        Me.Imagen1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch
        Me.Imagen1.Name = "Imagen1"
        Me.Imagen1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Imagen1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Imagen1.Width = 50
        '
        'Id_AccountingIitemHeading
        '
        Me.Id_AccountingIitemHeading.DataPropertyName = "Id_AccountingIitemHeading"
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.Id_AccountingIitemHeading.DefaultCellStyle = DataGridViewCellStyle11
        Me.Id_AccountingIitemHeading.HeaderText = "Correlativo"
        Me.Id_AccountingIitemHeading.Name = "Id_AccountingIitemHeading"
        Me.Id_AccountingIitemHeading.Width = 123
        '
        'BusinessDay
        '
        Me.BusinessDay.DataPropertyName = "BusinessDay"
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.BusinessDay.DefaultCellStyle = DataGridViewCellStyle12
        Me.BusinessDay.HeaderText = "Fecha"
        Me.BusinessDay.Name = "BusinessDay"
        Me.BusinessDay.Width = 82
        '
        'Name_ClassificationItemType
        '
        Me.Name_ClassificationItemType.DataPropertyName = "Name_ClassificationItemType"
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.Name_ClassificationItemType.DefaultCellStyle = DataGridViewCellStyle13
        Me.Name_ClassificationItemType.HeaderText = "Clasificacion"
        Me.Name_ClassificationItemType.Name = "Name_ClassificationItemType"
        Me.Name_ClassificationItemType.Width = 133
        '
        'Concept_AccountingIitemHeading
        '
        Me.Concept_AccountingIitemHeading.DataPropertyName = "Concept_AccountingIitemHeading"
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.Concept_AccountingIitemHeading.DefaultCellStyle = DataGridViewCellStyle14
        Me.Concept_AccountingIitemHeading.HeaderText = "Concepto"
        Me.Concept_AccountingIitemHeading.Name = "Concept_AccountingIitemHeading"
        Me.Concept_AccountingIitemHeading.Width = 114
        '
        'Total_Charge
        '
        Me.Total_Charge.DataPropertyName = "Total_Charge"
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.Total_Charge.DefaultCellStyle = DataGridViewCellStyle15
        Me.Total_Charge.HeaderText = "Total Abono"
        Me.Total_Charge.Name = "Total_Charge"
        Me.Total_Charge.Width = 136
        '
        'Total_Deposit
        '
        Me.Total_Deposit.DataPropertyName = "Total_Deposit"
        DataGridViewCellStyle16.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.Total_Deposit.DefaultCellStyle = DataGridViewCellStyle16
        Me.Total_Deposit.HeaderText = "Total Cargo"
        Me.Total_Deposit.Name = "Total_Deposit"
        Me.Total_Deposit.Width = 129
        '
        'UsersCreate1
        '
        Me.UsersCreate1.DataPropertyName = "UsersCreate"
        DataGridViewCellStyle17.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.UsersCreate1.DefaultCellStyle = DataGridViewCellStyle17
        Me.UsersCreate1.HeaderText = "Usuario"
        Me.UsersCreate1.Name = "UsersCreate1"
        Me.UsersCreate1.Width = 97
        '
        'DateCreate1
        '
        Me.DateCreate1.DataPropertyName = "DateCreate"
        DataGridViewCellStyle18.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.DateCreate1.DefaultCellStyle = DataGridViewCellStyle18
        Me.DateCreate1.HeaderText = "Fecha Creacion"
        Me.DateCreate1.Name = "DateCreate1"
        Me.DateCreate1.Width = 155
        '
        'Is_Square1
        '
        Me.Is_Square1.DataPropertyName = "Is_Square"
        Me.Is_Square1.HeaderText = "Cuadrada"
        Me.Is_Square1.Name = "Is_Square1"
        Me.Is_Square1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Is_Square1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'Date_Square1
        '
        Me.Date_Square1.DataPropertyName = "Date_Square"
        Me.Date_Square1.HeaderText = "F. Cuadre"
        Me.Date_Square1.Name = "Date_Square1"
        '
        'Is_Posting1
        '
        Me.Is_Posting1.DataPropertyName = "Is_Posting"
        DataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle19.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        DataGridViewCellStyle19.NullValue = False
        Me.Is_Posting1.DefaultCellStyle = DataGridViewCellStyle19
        Me.Is_Posting1.HeaderText = "Contabilizado"
        Me.Is_Posting1.Name = "Is_Posting1"
        Me.Is_Posting1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Is_Posting1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Is_Posting1.Width = 105
        '
        'DatePosting1
        '
        Me.DatePosting1.DataPropertyName = "DatePosting"
        DataGridViewCellStyle20.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.DatePosting1.DefaultCellStyle = DataGridViewCellStyle20
        Me.DatePosting1.HeaderText = "F. Contabilizacion"
        Me.DatePosting1.Name = "DatePosting1"
        Me.DatePosting1.Width = 110
        '
        'FLP_MenuContablizar
        '
        Me.FLP_MenuContablizar.Controls.Add(Me.cmdContabilizar)
        Me.FLP_MenuContablizar.Controls.Add(Me.cmdPartidaGestionContable)
        Me.FLP_MenuContablizar.Controls.Add(Me.cmdContabilidadLibroMayorPreview)
        Me.FLP_MenuContablizar.Controls.Add(Me.cmdContabilidadLibroAuxiliarPreview)
        Me.FLP_MenuContablizar.Controls.Add(Me.cmdBalance)
        Me.FLP_MenuContablizar.Controls.Add(Me.cmdBalanceComprobacion)
        Me.FLP_MenuContablizar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FLP_MenuContablizar.Location = New System.Drawing.Point(3, 3)
        Me.FLP_MenuContablizar.Name = "FLP_MenuContablizar"
        Me.FLP_MenuContablizar.Size = New System.Drawing.Size(1073, 69)
        Me.FLP_MenuContablizar.TabIndex = 1
        '
        'cmdContabilizar
        '
        Me.cmdContabilizar.BackColor = System.Drawing.Color.Gainsboro
        Me.cmdContabilizar.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdContabilizar.FlatAppearance.BorderSize = 0
        Me.cmdContabilizar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.cmdContabilizar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.cmdContabilizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdContabilizar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdContabilizar.Location = New System.Drawing.Point(3, 3)
        Me.cmdContabilizar.Name = "cmdContabilizar"
        Me.cmdContabilizar.Size = New System.Drawing.Size(110, 66)
        Me.cmdContabilizar.TabIndex = 30
        Me.cmdContabilizar.Text = "Postier"
        Me.cmdContabilizar.UseVisualStyleBackColor = False
        '
        'cmdPartidaGestionContable
        '
        Me.cmdPartidaGestionContable.BackColor = System.Drawing.Color.Gainsboro
        Me.cmdPartidaGestionContable.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdPartidaGestionContable.FlatAppearance.BorderSize = 0
        Me.cmdPartidaGestionContable.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.cmdPartidaGestionContable.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.cmdPartidaGestionContable.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdPartidaGestionContable.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPartidaGestionContable.Location = New System.Drawing.Point(119, 3)
        Me.cmdPartidaGestionContable.Name = "cmdPartidaGestionContable"
        Me.cmdPartidaGestionContable.Size = New System.Drawing.Size(110, 66)
        Me.cmdPartidaGestionContable.TabIndex = 35
        Me.cmdPartidaGestionContable.Text = "Partida"
        Me.cmdPartidaGestionContable.UseVisualStyleBackColor = False
        '
        'cmdContabilidadLibroMayorPreview
        '
        Me.cmdContabilidadLibroMayorPreview.BackColor = System.Drawing.Color.Gainsboro
        Me.cmdContabilidadLibroMayorPreview.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdContabilidadLibroMayorPreview.FlatAppearance.BorderSize = 0
        Me.cmdContabilidadLibroMayorPreview.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.cmdContabilidadLibroMayorPreview.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.cmdContabilidadLibroMayorPreview.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdContabilidadLibroMayorPreview.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdContabilidadLibroMayorPreview.Location = New System.Drawing.Point(235, 3)
        Me.cmdContabilidadLibroMayorPreview.Name = "cmdContabilidadLibroMayorPreview"
        Me.cmdContabilidadLibroMayorPreview.Size = New System.Drawing.Size(110, 66)
        Me.cmdContabilidadLibroMayorPreview.TabIndex = 31
        Me.cmdContabilidadLibroMayorPreview.Text = "Libro Mayor Preview"
        Me.cmdContabilidadLibroMayorPreview.UseVisualStyleBackColor = False
        '
        'cmdContabilidadLibroAuxiliarPreview
        '
        Me.cmdContabilidadLibroAuxiliarPreview.BackColor = System.Drawing.Color.Gainsboro
        Me.cmdContabilidadLibroAuxiliarPreview.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdContabilidadLibroAuxiliarPreview.FlatAppearance.BorderSize = 0
        Me.cmdContabilidadLibroAuxiliarPreview.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.cmdContabilidadLibroAuxiliarPreview.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.cmdContabilidadLibroAuxiliarPreview.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdContabilidadLibroAuxiliarPreview.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdContabilidadLibroAuxiliarPreview.Location = New System.Drawing.Point(351, 3)
        Me.cmdContabilidadLibroAuxiliarPreview.Name = "cmdContabilidadLibroAuxiliarPreview"
        Me.cmdContabilidadLibroAuxiliarPreview.Size = New System.Drawing.Size(110, 66)
        Me.cmdContabilidadLibroAuxiliarPreview.TabIndex = 32
        Me.cmdContabilidadLibroAuxiliarPreview.Text = "Libro Auxiliar Preview"
        Me.cmdContabilidadLibroAuxiliarPreview.UseVisualStyleBackColor = False
        '
        'cmdBalance
        '
        Me.cmdBalance.BackColor = System.Drawing.Color.Gainsboro
        Me.cmdBalance.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdBalance.FlatAppearance.BorderSize = 0
        Me.cmdBalance.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.cmdBalance.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.cmdBalance.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdBalance.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdBalance.Location = New System.Drawing.Point(467, 3)
        Me.cmdBalance.Name = "cmdBalance"
        Me.cmdBalance.Size = New System.Drawing.Size(131, 66)
        Me.cmdBalance.TabIndex = 33
        Me.cmdBalance.Text = "Balance General Preview"
        Me.cmdBalance.UseVisualStyleBackColor = False
        '
        'cmdBalanceComprobacion
        '
        Me.cmdBalanceComprobacion.BackColor = System.Drawing.Color.Gainsboro
        Me.cmdBalanceComprobacion.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdBalanceComprobacion.FlatAppearance.BorderSize = 0
        Me.cmdBalanceComprobacion.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.cmdBalanceComprobacion.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.cmdBalanceComprobacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdBalanceComprobacion.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdBalanceComprobacion.Location = New System.Drawing.Point(604, 3)
        Me.cmdBalanceComprobacion.Name = "cmdBalanceComprobacion"
        Me.cmdBalanceComprobacion.Size = New System.Drawing.Size(179, 66)
        Me.cmdBalanceComprobacion.TabIndex = 34
        Me.cmdBalanceComprobacion.Text = "Balance Comprobacion Preview"
        Me.cmdBalanceComprobacion.UseVisualStyleBackColor = False
        '
        'CloseGestion
        '
        Me.CloseGestion.Controls.Add(Me.TLP_Ledger)
        Me.CloseGestion.Location = New System.Drawing.Point(4, 35)
        Me.CloseGestion.Name = "CloseGestion"
        Me.CloseGestion.Size = New System.Drawing.Size(1087, 540)
        Me.CloseGestion.TabIndex = 5
        Me.CloseGestion.Text = "Gestión Cierre"
        Me.CloseGestion.UseVisualStyleBackColor = True
        '
        'TLP_Ledger
        '
        Me.TLP_Ledger.ColumnCount = 1
        Me.TLP_Ledger.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLP_Ledger.Controls.Add(Me.DataGridView1, 0, 1)
        Me.TLP_Ledger.Controls.Add(Me.FLP_LedgerTools, 0, 0)
        Me.TLP_Ledger.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TLP_Ledger.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.TLP_Ledger.Location = New System.Drawing.Point(0, 0)
        Me.TLP_Ledger.Name = "TLP_Ledger"
        Me.TLP_Ledger.RowCount = 2
        Me.TLP_Ledger.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75.0!))
        Me.TLP_Ledger.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLP_Ledger.Size = New System.Drawing.Size(1087, 540)
        Me.TLP_Ledger.TabIndex = 3
        '
        'DataGridView1
        '
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewImageColumn3, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewCheckBoxColumn2, Me.DataGridViewTextBoxColumn10})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.Location = New System.Drawing.Point(3, 78)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.ShowCellErrors = False
        Me.DataGridView1.ShowCellToolTips = False
        Me.DataGridView1.ShowEditingIcon = False
        Me.DataGridView1.ShowRowErrors = False
        Me.DataGridView1.Size = New System.Drawing.Size(1081, 459)
        Me.DataGridView1.TabIndex = 2
        '
        'DataGridViewImageColumn3
        '
        Me.DataGridViewImageColumn3.Frozen = True
        Me.DataGridViewImageColumn3.HeaderText = ""
        Me.DataGridViewImageColumn3.Image = Global.epd_SatelliteERP.My.Resources.Resources.Roja_Bandera
        Me.DataGridViewImageColumn3.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch
        Me.DataGridViewImageColumn3.Name = "DataGridViewImageColumn3"
        Me.DataGridViewImageColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewImageColumn3.Width = 50
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Id_AccountingIitemHeading"
        DataGridViewCellStyle21.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle21
        Me.DataGridViewTextBoxColumn1.HeaderText = "Correlativo"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 123
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "BusinessDay"
        DataGridViewCellStyle22.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle22
        Me.DataGridViewTextBoxColumn2.HeaderText = "Fecha"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 82
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Name_ClassificationItemType"
        DataGridViewCellStyle23.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle23
        Me.DataGridViewTextBoxColumn3.HeaderText = "Observacion Cierre"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 133
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Concept_AccountingIitemHeading"
        DataGridViewCellStyle24.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle24
        Me.DataGridViewTextBoxColumn4.HeaderText = "Debe Cierre"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 114
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Total_Charge"
        DataGridViewCellStyle25.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle25
        Me.DataGridViewTextBoxColumn5.HeaderText = "Haber Cierre"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 136
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "UsersCreate"
        DataGridViewCellStyle26.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.DataGridViewTextBoxColumn7.DefaultCellStyle = DataGridViewCellStyle26
        Me.DataGridViewTextBoxColumn7.HeaderText = "Usuario"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 97
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "DateCreate"
        DataGridViewCellStyle27.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.DataGridViewTextBoxColumn8.DefaultCellStyle = DataGridViewCellStyle27
        Me.DataGridViewTextBoxColumn8.HeaderText = "Fecha Creacion"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 155
        '
        'DataGridViewCheckBoxColumn2
        '
        Me.DataGridViewCheckBoxColumn2.DataPropertyName = "Is_Posting"
        DataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle28.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        DataGridViewCellStyle28.NullValue = False
        Me.DataGridViewCheckBoxColumn2.DefaultCellStyle = DataGridViewCellStyle28
        Me.DataGridViewCheckBoxColumn2.HeaderText = "Cerrado"
        Me.DataGridViewCheckBoxColumn2.Name = "DataGridViewCheckBoxColumn2"
        Me.DataGridViewCheckBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewCheckBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewCheckBoxColumn2.Width = 105
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "DatePosting"
        DataGridViewCellStyle29.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.DataGridViewTextBoxColumn10.DefaultCellStyle = DataGridViewCellStyle29
        Me.DataGridViewTextBoxColumn10.HeaderText = "F. Cierre"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.Width = 110
        '
        'FLP_LedgerTools
        '
        Me.FLP_LedgerTools.Controls.Add(Me.cmdLadgerPreview)
        Me.FLP_LedgerTools.Controls.Add(Me.cmdLadgerPrinter)
        Me.FLP_LedgerTools.Controls.Add(Me.cmdClosePeriod)
        Me.FLP_LedgerTools.Controls.Add(Me.cmdLadgerPrinterCero)
        Me.FLP_LedgerTools.Controls.Add(Me.cmdLadgerPreviewFull)
        Me.FLP_LedgerTools.Controls.Add(Me.cmdLadgerPriviewFull)
        Me.FLP_LedgerTools.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FLP_LedgerTools.Location = New System.Drawing.Point(3, 3)
        Me.FLP_LedgerTools.Name = "FLP_LedgerTools"
        Me.FLP_LedgerTools.Size = New System.Drawing.Size(1081, 69)
        Me.FLP_LedgerTools.TabIndex = 1
        '
        'cmdLadgerPreview
        '
        Me.cmdLadgerPreview.BackColor = System.Drawing.Color.Gainsboro
        Me.cmdLadgerPreview.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdLadgerPreview.FlatAppearance.BorderSize = 0
        Me.cmdLadgerPreview.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.cmdLadgerPreview.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.cmdLadgerPreview.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdLadgerPreview.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLadgerPreview.Location = New System.Drawing.Point(3, 3)
        Me.cmdLadgerPreview.Name = "cmdLadgerPreview"
        Me.cmdLadgerPreview.Size = New System.Drawing.Size(110, 66)
        Me.cmdLadgerPreview.TabIndex = 30
        Me.cmdLadgerPreview.Text = "Vista Previa"
        Me.cmdLadgerPreview.UseVisualStyleBackColor = False
        '
        'cmdLadgerPrinter
        '
        Me.cmdLadgerPrinter.BackColor = System.Drawing.Color.Gainsboro
        Me.cmdLadgerPrinter.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdLadgerPrinter.FlatAppearance.BorderSize = 0
        Me.cmdLadgerPrinter.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.cmdLadgerPrinter.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.cmdLadgerPrinter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdLadgerPrinter.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLadgerPrinter.Location = New System.Drawing.Point(119, 3)
        Me.cmdLadgerPrinter.Name = "cmdLadgerPrinter"
        Me.cmdLadgerPrinter.Size = New System.Drawing.Size(110, 66)
        Me.cmdLadgerPrinter.TabIndex = 31
        Me.cmdLadgerPrinter.Text = "Cerrar dia actual"
        Me.cmdLadgerPrinter.UseVisualStyleBackColor = False
        '
        'cmdClosePeriod
        '
        Me.cmdClosePeriod.BackColor = System.Drawing.Color.Gainsboro
        Me.cmdClosePeriod.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdClosePeriod.FlatAppearance.BorderSize = 0
        Me.cmdClosePeriod.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.cmdClosePeriod.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.cmdClosePeriod.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdClosePeriod.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClosePeriod.Location = New System.Drawing.Point(235, 3)
        Me.cmdClosePeriod.Name = "cmdClosePeriod"
        Me.cmdClosePeriod.Size = New System.Drawing.Size(110, 66)
        Me.cmdClosePeriod.TabIndex = 32
        Me.cmdClosePeriod.Text = "Cerrar Mes actual"
        Me.cmdClosePeriod.UseVisualStyleBackColor = False
        '
        'cmdLadgerPrinterCero
        '
        Me.cmdLadgerPrinterCero.BackColor = System.Drawing.Color.Gainsboro
        Me.cmdLadgerPrinterCero.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdLadgerPrinterCero.FlatAppearance.BorderSize = 0
        Me.cmdLadgerPrinterCero.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.cmdLadgerPrinterCero.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.cmdLadgerPrinterCero.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdLadgerPrinterCero.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLadgerPrinterCero.Location = New System.Drawing.Point(351, 3)
        Me.cmdLadgerPrinterCero.Name = "cmdLadgerPrinterCero"
        Me.cmdLadgerPrinterCero.Size = New System.Drawing.Size(110, 66)
        Me.cmdLadgerPrinterCero.TabIndex = 33
        Me.cmdLadgerPrinterCero.Text = "Copia contable"
        Me.cmdLadgerPrinterCero.UseVisualStyleBackColor = False
        '
        'cmdLadgerPreviewFull
        '
        Me.cmdLadgerPreviewFull.BackColor = System.Drawing.Color.Gainsboro
        Me.cmdLadgerPreviewFull.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdLadgerPreviewFull.FlatAppearance.BorderSize = 0
        Me.cmdLadgerPreviewFull.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.cmdLadgerPreviewFull.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.cmdLadgerPreviewFull.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdLadgerPreviewFull.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLadgerPreviewFull.Location = New System.Drawing.Point(467, 3)
        Me.cmdLadgerPreviewFull.Name = "cmdLadgerPreviewFull"
        Me.cmdLadgerPreviewFull.Size = New System.Drawing.Size(142, 66)
        Me.cmdLadgerPreviewFull.TabIndex = 34
        Me.cmdLadgerPreviewFull.Text = "Lista de Copia contable"
        Me.cmdLadgerPreviewFull.UseVisualStyleBackColor = False
        '
        'cmdLadgerPriviewFull
        '
        Me.cmdLadgerPriviewFull.BackColor = System.Drawing.Color.Gainsboro
        Me.cmdLadgerPriviewFull.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdLadgerPriviewFull.FlatAppearance.BorderSize = 0
        Me.cmdLadgerPriviewFull.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.cmdLadgerPriviewFull.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.cmdLadgerPriviewFull.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdLadgerPriviewFull.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLadgerPriviewFull.Location = New System.Drawing.Point(615, 3)
        Me.cmdLadgerPriviewFull.Name = "cmdLadgerPriviewFull"
        Me.cmdLadgerPriviewFull.Size = New System.Drawing.Size(125, 66)
        Me.cmdLadgerPriviewFull.TabIndex = 35
        Me.cmdLadgerPriviewFull.Text = "Re-estableser copia contable"
        Me.cmdLadgerPriviewFull.UseVisualStyleBackColor = False
        '
        'HistoryYear
        '
        Me.HistoryYear.Controls.Add(Me.TLP_FiscalDocTools)
        Me.HistoryYear.Location = New System.Drawing.Point(4, 35)
        Me.HistoryYear.Name = "HistoryYear"
        Me.HistoryYear.Size = New System.Drawing.Size(1087, 540)
        Me.HistoryYear.TabIndex = 6
        Me.HistoryYear.Text = "Histórico Año Actual"
        Me.HistoryYear.UseVisualStyleBackColor = True
        '
        'TLP_FiscalDocTools
        '
        Me.TLP_FiscalDocTools.ColumnCount = 1
        Me.TLP_FiscalDocTools.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLP_FiscalDocTools.Controls.Add(Me.DGW_YearCurrentList, 0, 1)
        Me.TLP_FiscalDocTools.Controls.Add(Me.FlowLayoutPanel1, 0, 0)
        Me.TLP_FiscalDocTools.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TLP_FiscalDocTools.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.TLP_FiscalDocTools.Location = New System.Drawing.Point(0, 0)
        Me.TLP_FiscalDocTools.Name = "TLP_FiscalDocTools"
        Me.TLP_FiscalDocTools.RowCount = 2
        Me.TLP_FiscalDocTools.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75.0!))
        Me.TLP_FiscalDocTools.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLP_FiscalDocTools.Size = New System.Drawing.Size(1087, 540)
        Me.TLP_FiscalDocTools.TabIndex = 4
        '
        'DGW_YearCurrentList
        '
        Me.DGW_YearCurrentList.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGW_YearCurrentList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewImageColumn4, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15})
        Me.DGW_YearCurrentList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGW_YearCurrentList.EnableHeadersVisualStyles = False
        Me.DGW_YearCurrentList.Location = New System.Drawing.Point(3, 78)
        Me.DGW_YearCurrentList.Name = "DGW_YearCurrentList"
        Me.DGW_YearCurrentList.RowHeadersVisible = False
        Me.DGW_YearCurrentList.ShowCellErrors = False
        Me.DGW_YearCurrentList.ShowCellToolTips = False
        Me.DGW_YearCurrentList.ShowEditingIcon = False
        Me.DGW_YearCurrentList.ShowRowErrors = False
        Me.DGW_YearCurrentList.Size = New System.Drawing.Size(1081, 459)
        Me.DGW_YearCurrentList.TabIndex = 3
        '
        'DataGridViewImageColumn4
        '
        Me.DataGridViewImageColumn4.Frozen = True
        Me.DataGridViewImageColumn4.HeaderText = ""
        Me.DataGridViewImageColumn4.Image = Global.epd_SatelliteERP.My.Resources.Resources.Roja_Bandera
        Me.DataGridViewImageColumn4.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch
        Me.DataGridViewImageColumn4.Name = "DataGridViewImageColumn4"
        Me.DataGridViewImageColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewImageColumn4.Width = 50
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "PeriodClose"
        DataGridViewCellStyle30.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.DataGridViewTextBoxColumn9.DefaultCellStyle = DataGridViewCellStyle30
        Me.DataGridViewTextBoxColumn9.HeaderText = "Periodo"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Width = 82
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Total_BalancePrevious"
        DataGridViewCellStyle31.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.DataGridViewTextBoxColumn11.DefaultCellStyle = DataGridViewCellStyle31
        Me.DataGridViewTextBoxColumn11.HeaderText = "Saldo Anterior"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.Width = 133
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Total_Charge"
        DataGridViewCellStyle32.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.DataGridViewTextBoxColumn12.DefaultCellStyle = DataGridViewCellStyle32
        Me.DataGridViewTextBoxColumn12.HeaderText = "Debe Cierre"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.Width = 114
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "Total_Deposit"
        DataGridViewCellStyle33.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.DataGridViewTextBoxColumn13.DefaultCellStyle = DataGridViewCellStyle33
        Me.DataGridViewTextBoxColumn13.HeaderText = "Haber Cierre"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.Width = 136
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "Total_BalanceCurrent"
        DataGridViewCellStyle34.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.DataGridViewTextBoxColumn16.DefaultCellStyle = DataGridViewCellStyle34
        Me.DataGridViewTextBoxColumn16.HeaderText = "Saldo a Fin periodo"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.Width = 110
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "UsersClose"
        DataGridViewCellStyle35.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.DataGridViewTextBoxColumn14.DefaultCellStyle = DataGridViewCellStyle35
        Me.DataGridViewTextBoxColumn14.HeaderText = "Usuario Cierre"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.Width = 97
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "DateClose"
        DataGridViewCellStyle36.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.DataGridViewTextBoxColumn15.DefaultCellStyle = DataGridViewCellStyle36
        Me.DataGridViewTextBoxColumn15.HeaderText = "Fecha Cierre"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.Width = 155
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.cmdPartidaContable)
        Me.FlowLayoutPanel1.Controls.Add(Me.cmdLibroDiarioHistorico)
        Me.FlowLayoutPanel1.Controls.Add(Me.cmdHistoryLibroMayor)
        Me.FlowLayoutPanel1.Controls.Add(Me.cmdHistoryLibroAuxiliar)
        Me.FlowLayoutPanel1.Controls.Add(Me.cmdHistoryBalanceGeneral)
        Me.FlowLayoutPanel1.Controls.Add(Me.cmdHistoryBalanceComprobacion)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(1081, 69)
        Me.FlowLayoutPanel1.TabIndex = 1
        '
        'cmdPartidaContable
        '
        Me.cmdPartidaContable.BackColor = System.Drawing.Color.Gainsboro
        Me.cmdPartidaContable.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdPartidaContable.FlatAppearance.BorderSize = 0
        Me.cmdPartidaContable.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.cmdPartidaContable.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.cmdPartidaContable.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdPartidaContable.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPartidaContable.Location = New System.Drawing.Point(3, 3)
        Me.cmdPartidaContable.Name = "cmdPartidaContable"
        Me.cmdPartidaContable.Size = New System.Drawing.Size(110, 66)
        Me.cmdPartidaContable.TabIndex = 30
        Me.cmdPartidaContable.Text = "Partida"
        Me.cmdPartidaContable.UseVisualStyleBackColor = False
        '
        'cmdLibroDiarioHistorico
        '
        Me.cmdLibroDiarioHistorico.BackColor = System.Drawing.Color.Gainsboro
        Me.cmdLibroDiarioHistorico.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdLibroDiarioHistorico.FlatAppearance.BorderSize = 0
        Me.cmdLibroDiarioHistorico.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.cmdLibroDiarioHistorico.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.cmdLibroDiarioHistorico.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdLibroDiarioHistorico.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLibroDiarioHistorico.Location = New System.Drawing.Point(119, 3)
        Me.cmdLibroDiarioHistorico.Name = "cmdLibroDiarioHistorico"
        Me.cmdLibroDiarioHistorico.Size = New System.Drawing.Size(114, 66)
        Me.cmdLibroDiarioHistorico.TabIndex = 39
        Me.cmdLibroDiarioHistorico.Text = "Libro Diario"
        Me.cmdLibroDiarioHistorico.UseVisualStyleBackColor = False
        '
        'cmdHistoryLibroMayor
        '
        Me.cmdHistoryLibroMayor.BackColor = System.Drawing.Color.Gainsboro
        Me.cmdHistoryLibroMayor.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdHistoryLibroMayor.FlatAppearance.BorderSize = 0
        Me.cmdHistoryLibroMayor.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.cmdHistoryLibroMayor.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.cmdHistoryLibroMayor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdHistoryLibroMayor.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdHistoryLibroMayor.Location = New System.Drawing.Point(239, 3)
        Me.cmdHistoryLibroMayor.Name = "cmdHistoryLibroMayor"
        Me.cmdHistoryLibroMayor.Size = New System.Drawing.Size(110, 66)
        Me.cmdHistoryLibroMayor.TabIndex = 35
        Me.cmdHistoryLibroMayor.Text = "Libro Mayor"
        Me.cmdHistoryLibroMayor.UseVisualStyleBackColor = False
        '
        'cmdHistoryLibroAuxiliar
        '
        Me.cmdHistoryLibroAuxiliar.BackColor = System.Drawing.Color.Gainsboro
        Me.cmdHistoryLibroAuxiliar.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdHistoryLibroAuxiliar.FlatAppearance.BorderSize = 0
        Me.cmdHistoryLibroAuxiliar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.cmdHistoryLibroAuxiliar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.cmdHistoryLibroAuxiliar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdHistoryLibroAuxiliar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdHistoryLibroAuxiliar.Location = New System.Drawing.Point(355, 3)
        Me.cmdHistoryLibroAuxiliar.Name = "cmdHistoryLibroAuxiliar"
        Me.cmdHistoryLibroAuxiliar.Size = New System.Drawing.Size(110, 66)
        Me.cmdHistoryLibroAuxiliar.TabIndex = 36
        Me.cmdHistoryLibroAuxiliar.Text = "Libro Auxiliar"
        Me.cmdHistoryLibroAuxiliar.UseVisualStyleBackColor = False
        '
        'cmdHistoryBalanceGeneral
        '
        Me.cmdHistoryBalanceGeneral.BackColor = System.Drawing.Color.Gainsboro
        Me.cmdHistoryBalanceGeneral.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdHistoryBalanceGeneral.FlatAppearance.BorderSize = 0
        Me.cmdHistoryBalanceGeneral.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.cmdHistoryBalanceGeneral.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.cmdHistoryBalanceGeneral.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdHistoryBalanceGeneral.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdHistoryBalanceGeneral.Location = New System.Drawing.Point(471, 3)
        Me.cmdHistoryBalanceGeneral.Name = "cmdHistoryBalanceGeneral"
        Me.cmdHistoryBalanceGeneral.Size = New System.Drawing.Size(113, 66)
        Me.cmdHistoryBalanceGeneral.TabIndex = 37
        Me.cmdHistoryBalanceGeneral.Text = "Balance General"
        Me.cmdHistoryBalanceGeneral.UseVisualStyleBackColor = False
        '
        'cmdHistoryBalanceComprobacion
        '
        Me.cmdHistoryBalanceComprobacion.BackColor = System.Drawing.Color.Gainsboro
        Me.cmdHistoryBalanceComprobacion.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdHistoryBalanceComprobacion.FlatAppearance.BorderSize = 0
        Me.cmdHistoryBalanceComprobacion.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.cmdHistoryBalanceComprobacion.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.cmdHistoryBalanceComprobacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdHistoryBalanceComprobacion.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdHistoryBalanceComprobacion.Location = New System.Drawing.Point(590, 3)
        Me.cmdHistoryBalanceComprobacion.Name = "cmdHistoryBalanceComprobacion"
        Me.cmdHistoryBalanceComprobacion.Size = New System.Drawing.Size(122, 66)
        Me.cmdHistoryBalanceComprobacion.TabIndex = 38
        Me.cmdHistoryBalanceComprobacion.Text = "Balance Comprobación"
        Me.cmdHistoryBalanceComprobacion.UseVisualStyleBackColor = False
        '
        'HistoryYearOld
        '
        Me.HistoryYearOld.BackColor = System.Drawing.Color.White
        Me.HistoryYearOld.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.HistoryYearOld.Controls.Add(Me.TLP_YearOLD)
        Me.HistoryYearOld.Location = New System.Drawing.Point(4, 35)
        Me.HistoryYearOld.Name = "HistoryYearOld"
        Me.HistoryYearOld.Padding = New System.Windows.Forms.Padding(3)
        Me.HistoryYearOld.Size = New System.Drawing.Size(1087, 540)
        Me.HistoryYearOld.TabIndex = 3
        Me.HistoryYearOld.Text = "Histórico Años Anteriores"
        '
        'TLP_YearOLD
        '
        Me.TLP_YearOLD.ColumnCount = 1
        Me.TLP_YearOLD.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLP_YearOLD.Controls.Add(Me.DGW_YearOLD, 0, 1)
        Me.TLP_YearOLD.Controls.Add(Me.FlowLayoutPanel2, 0, 0)
        Me.TLP_YearOLD.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TLP_YearOLD.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.TLP_YearOLD.Location = New System.Drawing.Point(3, 3)
        Me.TLP_YearOLD.Name = "TLP_YearOLD"
        Me.TLP_YearOLD.RowCount = 2
        Me.TLP_YearOLD.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75.0!))
        Me.TLP_YearOLD.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLP_YearOLD.Size = New System.Drawing.Size(1079, 532)
        Me.TLP_YearOLD.TabIndex = 5
        '
        'DGW_YearOLD
        '
        Me.DGW_YearOLD.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGW_YearOLD.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewImageColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn22})
        Me.DGW_YearOLD.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGW_YearOLD.EnableHeadersVisualStyles = False
        Me.DGW_YearOLD.Location = New System.Drawing.Point(3, 78)
        Me.DGW_YearOLD.Name = "DGW_YearOLD"
        Me.DGW_YearOLD.RowHeadersVisible = False
        Me.DGW_YearOLD.ShowCellErrors = False
        Me.DGW_YearOLD.ShowCellToolTips = False
        Me.DGW_YearOLD.ShowEditingIcon = False
        Me.DGW_YearOLD.ShowRowErrors = False
        Me.DGW_YearOLD.Size = New System.Drawing.Size(1073, 451)
        Me.DGW_YearOLD.TabIndex = 3
        '
        'DataGridViewImageColumn5
        '
        Me.DataGridViewImageColumn5.Frozen = True
        Me.DataGridViewImageColumn5.HeaderText = ""
        Me.DataGridViewImageColumn5.Image = Global.epd_SatelliteERP.My.Resources.Resources.Roja_Bandera
        Me.DataGridViewImageColumn5.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch
        Me.DataGridViewImageColumn5.Name = "DataGridViewImageColumn5"
        Me.DataGridViewImageColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewImageColumn5.Width = 50
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "PeriodClose"
        DataGridViewCellStyle37.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle37
        Me.DataGridViewTextBoxColumn6.HeaderText = "Periodo"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 82
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "Total_BalancePrevious"
        DataGridViewCellStyle38.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.DataGridViewTextBoxColumn17.DefaultCellStyle = DataGridViewCellStyle38
        Me.DataGridViewTextBoxColumn17.HeaderText = "Saldo Anterior"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.Width = 133
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "Total_Charge"
        DataGridViewCellStyle39.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.DataGridViewTextBoxColumn18.DefaultCellStyle = DataGridViewCellStyle39
        Me.DataGridViewTextBoxColumn18.HeaderText = "Debe Cierre"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.Width = 114
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "Total_Deposit"
        DataGridViewCellStyle40.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.DataGridViewTextBoxColumn19.DefaultCellStyle = DataGridViewCellStyle40
        Me.DataGridViewTextBoxColumn19.HeaderText = "Haber Cierre"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.Width = 136
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "Total_BalanceCurrent"
        DataGridViewCellStyle41.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.DataGridViewTextBoxColumn20.DefaultCellStyle = DataGridViewCellStyle41
        Me.DataGridViewTextBoxColumn20.HeaderText = "Saldo a Fin periodo"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        Me.DataGridViewTextBoxColumn20.Width = 110
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "UsersClose"
        DataGridViewCellStyle42.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.DataGridViewTextBoxColumn21.DefaultCellStyle = DataGridViewCellStyle42
        Me.DataGridViewTextBoxColumn21.HeaderText = "Usuario Cierre"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        Me.DataGridViewTextBoxColumn21.Width = 97
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "DateClose"
        DataGridViewCellStyle43.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.DataGridViewTextBoxColumn22.DefaultCellStyle = DataGridViewCellStyle43
        Me.DataGridViewTextBoxColumn22.HeaderText = "Fecha Cierre"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        Me.DataGridViewTextBoxColumn22.Width = 155
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.Controls.Add(Me.Button7)
        Me.FlowLayoutPanel2.Controls.Add(Me.Button8)
        Me.FlowLayoutPanel2.Controls.Add(Me.Button9)
        Me.FlowLayoutPanel2.Controls.Add(Me.Button10)
        Me.FlowLayoutPanel2.Controls.Add(Me.Button11)
        Me.FlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(1073, 69)
        Me.FlowLayoutPanel2.TabIndex = 1
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.Gainsboro
        Me.Button7.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.Button7.FlatAppearance.BorderSize = 0
        Me.Button7.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.Button7.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Location = New System.Drawing.Point(3, 3)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(114, 66)
        Me.Button7.TabIndex = 39
        Me.Button7.Text = "Libro Diario"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.Gainsboro
        Me.Button8.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.Button8.FlatAppearance.BorderSize = 0
        Me.Button8.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.Button8.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.Location = New System.Drawing.Point(123, 3)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(110, 66)
        Me.Button8.TabIndex = 35
        Me.Button8.Text = "Libro Mayor"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.Gainsboro
        Me.Button9.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.Button9.FlatAppearance.BorderSize = 0
        Me.Button9.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.Button9.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button9.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.Location = New System.Drawing.Point(239, 3)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(110, 66)
        Me.Button9.TabIndex = 36
        Me.Button9.Text = "Libro Auxiliar"
        Me.Button9.UseVisualStyleBackColor = False
        '
        'Button10
        '
        Me.Button10.BackColor = System.Drawing.Color.Gainsboro
        Me.Button10.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.Button10.FlatAppearance.BorderSize = 0
        Me.Button10.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.Button10.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button10.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button10.Location = New System.Drawing.Point(355, 3)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(113, 66)
        Me.Button10.TabIndex = 37
        Me.Button10.Text = "Balance General"
        Me.Button10.UseVisualStyleBackColor = False
        '
        'Button11
        '
        Me.Button11.BackColor = System.Drawing.Color.Gainsboro
        Me.Button11.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.Button11.FlatAppearance.BorderSize = 0
        Me.Button11.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.Button11.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.Button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button11.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button11.Location = New System.Drawing.Point(474, 3)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(122, 66)
        Me.Button11.TabIndex = 38
        Me.Button11.Text = "Balance Comprobación"
        Me.Button11.UseVisualStyleBackColor = False
        '
        'ConfigExternal
        '
        Me.ConfigExternal.Controls.Add(Me.TLP_ConfigExternal)
        Me.ConfigExternal.Location = New System.Drawing.Point(4, 35)
        Me.ConfigExternal.Name = "ConfigExternal"
        Me.ConfigExternal.Size = New System.Drawing.Size(1087, 540)
        Me.ConfigExternal.TabIndex = 7
        Me.ConfigExternal.Text = "Sistemas Externos"
        Me.ConfigExternal.UseVisualStyleBackColor = True
        '
        'TLP_ConfigExternal
        '
        Me.TLP_ConfigExternal.ColumnCount = 1
        Me.TLP_ConfigExternal.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLP_ConfigExternal.Controls.Add(Me.DataGridView3, 0, 1)
        Me.TLP_ConfigExternal.Controls.Add(Me.FlowLayoutPanel3, 0, 0)
        Me.TLP_ConfigExternal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TLP_ConfigExternal.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.TLP_ConfigExternal.Location = New System.Drawing.Point(0, 0)
        Me.TLP_ConfigExternal.Name = "TLP_ConfigExternal"
        Me.TLP_ConfigExternal.RowCount = 2
        Me.TLP_ConfigExternal.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75.0!))
        Me.TLP_ConfigExternal.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLP_ConfigExternal.Size = New System.Drawing.Size(1087, 540)
        Me.TLP_ConfigExternal.TabIndex = 6
        '
        'DataGridView3
        '
        Me.DataGridView3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView3.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewImageColumn6, Me.DataGridViewTextBoxColumn23, Me.DataGridViewTextBoxColumn24, Me.DataGridViewTextBoxColumn25, Me.DataGridViewTextBoxColumn26, Me.DataGridViewTextBoxColumn27, Me.DataGridViewTextBoxColumn28, Me.DataGridViewTextBoxColumn29})
        Me.DataGridView3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView3.EnableHeadersVisualStyles = False
        Me.DataGridView3.Location = New System.Drawing.Point(3, 78)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.RowHeadersVisible = False
        Me.DataGridView3.ShowCellErrors = False
        Me.DataGridView3.ShowCellToolTips = False
        Me.DataGridView3.ShowEditingIcon = False
        Me.DataGridView3.ShowRowErrors = False
        Me.DataGridView3.Size = New System.Drawing.Size(1081, 459)
        Me.DataGridView3.TabIndex = 3
        '
        'DataGridViewImageColumn6
        '
        Me.DataGridViewImageColumn6.Frozen = True
        Me.DataGridViewImageColumn6.HeaderText = ""
        Me.DataGridViewImageColumn6.Image = Global.epd_SatelliteERP.My.Resources.Resources.Roja_Bandera
        Me.DataGridViewImageColumn6.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch
        Me.DataGridViewImageColumn6.Name = "DataGridViewImageColumn6"
        Me.DataGridViewImageColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewImageColumn6.Width = 50
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "PeriodClose"
        DataGridViewCellStyle44.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.DataGridViewTextBoxColumn23.DefaultCellStyle = DataGridViewCellStyle44
        Me.DataGridViewTextBoxColumn23.HeaderText = "Periodo"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        Me.DataGridViewTextBoxColumn23.Width = 82
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.DataPropertyName = "Total_BalancePrevious"
        DataGridViewCellStyle45.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.DataGridViewTextBoxColumn24.DefaultCellStyle = DataGridViewCellStyle45
        Me.DataGridViewTextBoxColumn24.HeaderText = "Saldo Anterior"
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        Me.DataGridViewTextBoxColumn24.Width = 133
        '
        'DataGridViewTextBoxColumn25
        '
        Me.DataGridViewTextBoxColumn25.DataPropertyName = "Total_Charge"
        DataGridViewCellStyle46.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.DataGridViewTextBoxColumn25.DefaultCellStyle = DataGridViewCellStyle46
        Me.DataGridViewTextBoxColumn25.HeaderText = "Debe Cierre"
        Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
        Me.DataGridViewTextBoxColumn25.Width = 114
        '
        'DataGridViewTextBoxColumn26
        '
        Me.DataGridViewTextBoxColumn26.DataPropertyName = "Total_Deposit"
        DataGridViewCellStyle47.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.DataGridViewTextBoxColumn26.DefaultCellStyle = DataGridViewCellStyle47
        Me.DataGridViewTextBoxColumn26.HeaderText = "Haber Cierre"
        Me.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26"
        Me.DataGridViewTextBoxColumn26.Width = 136
        '
        'DataGridViewTextBoxColumn27
        '
        Me.DataGridViewTextBoxColumn27.DataPropertyName = "Total_BalanceCurrent"
        DataGridViewCellStyle48.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.DataGridViewTextBoxColumn27.DefaultCellStyle = DataGridViewCellStyle48
        Me.DataGridViewTextBoxColumn27.HeaderText = "Saldo a Fin periodo"
        Me.DataGridViewTextBoxColumn27.Name = "DataGridViewTextBoxColumn27"
        Me.DataGridViewTextBoxColumn27.Width = 110
        '
        'DataGridViewTextBoxColumn28
        '
        Me.DataGridViewTextBoxColumn28.DataPropertyName = "UsersClose"
        DataGridViewCellStyle49.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.DataGridViewTextBoxColumn28.DefaultCellStyle = DataGridViewCellStyle49
        Me.DataGridViewTextBoxColumn28.HeaderText = "Usuario Cierre"
        Me.DataGridViewTextBoxColumn28.Name = "DataGridViewTextBoxColumn28"
        Me.DataGridViewTextBoxColumn28.Width = 97
        '
        'DataGridViewTextBoxColumn29
        '
        Me.DataGridViewTextBoxColumn29.DataPropertyName = "DateClose"
        DataGridViewCellStyle50.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.DataGridViewTextBoxColumn29.DefaultCellStyle = DataGridViewCellStyle50
        Me.DataGridViewTextBoxColumn29.HeaderText = "Fecha Cierre"
        Me.DataGridViewTextBoxColumn29.Name = "DataGridViewTextBoxColumn29"
        Me.DataGridViewTextBoxColumn29.Width = 155
        '
        'FlowLayoutPanel3
        '
        Me.FlowLayoutPanel3.Controls.Add(Me.cmdPartidaConfigSistemaExternoCreate)
        Me.FlowLayoutPanel3.Controls.Add(Me.cmdPartidaConfigSistemaExternoModify)
        Me.FlowLayoutPanel3.Controls.Add(Me.Button3)
        Me.FlowLayoutPanel3.Controls.Add(Me.Button4)
        Me.FlowLayoutPanel3.Controls.Add(Me.Button5)
        Me.FlowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel3.Location = New System.Drawing.Point(3, 3)
        Me.FlowLayoutPanel3.Name = "FlowLayoutPanel3"
        Me.FlowLayoutPanel3.Size = New System.Drawing.Size(1081, 69)
        Me.FlowLayoutPanel3.TabIndex = 1
        '
        'cmdPartidaConfigSistemaExternoCreate
        '
        Me.cmdPartidaConfigSistemaExternoCreate.BackColor = System.Drawing.Color.Gainsboro
        Me.cmdPartidaConfigSistemaExternoCreate.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdPartidaConfigSistemaExternoCreate.FlatAppearance.BorderSize = 0
        Me.cmdPartidaConfigSistemaExternoCreate.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.cmdPartidaConfigSistemaExternoCreate.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.cmdPartidaConfigSistemaExternoCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdPartidaConfigSistemaExternoCreate.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPartidaConfigSistemaExternoCreate.Location = New System.Drawing.Point(3, 3)
        Me.cmdPartidaConfigSistemaExternoCreate.Name = "cmdPartidaConfigSistemaExternoCreate"
        Me.cmdPartidaConfigSistemaExternoCreate.Size = New System.Drawing.Size(164, 66)
        Me.cmdPartidaConfigSistemaExternoCreate.TabIndex = 39
        Me.cmdPartidaConfigSistemaExternoCreate.Text = "Crear Configurar Definición Partidas"
        Me.cmdPartidaConfigSistemaExternoCreate.UseVisualStyleBackColor = False
        '
        'cmdPartidaConfigSistemaExternoModify
        '
        Me.cmdPartidaConfigSistemaExternoModify.BackColor = System.Drawing.Color.Gainsboro
        Me.cmdPartidaConfigSistemaExternoModify.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdPartidaConfigSistemaExternoModify.FlatAppearance.BorderSize = 0
        Me.cmdPartidaConfigSistemaExternoModify.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.cmdPartidaConfigSistemaExternoModify.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.cmdPartidaConfigSistemaExternoModify.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdPartidaConfigSistemaExternoModify.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPartidaConfigSistemaExternoModify.Location = New System.Drawing.Point(173, 3)
        Me.cmdPartidaConfigSistemaExternoModify.Name = "cmdPartidaConfigSistemaExternoModify"
        Me.cmdPartidaConfigSistemaExternoModify.Size = New System.Drawing.Size(165, 66)
        Me.cmdPartidaConfigSistemaExternoModify.TabIndex = 35
        Me.cmdPartidaConfigSistemaExternoModify.Text = "Modificar Configurar Definición Partidas"
        Me.cmdPartidaConfigSistemaExternoModify.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Gainsboro
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(344, 3)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(110, 66)
        Me.Button3.TabIndex = 36
        Me.Button3.Text = "Imprimir Definicion"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Gainsboro
        Me.Button4.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(460, 3)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(160, 66)
        Me.Button4.TabIndex = 37
        Me.Button4.Text = "Imprimir Lista completa"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Gainsboro
        Me.Button5.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.Button5.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(626, 3)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(150, 66)
        Me.Button5.TabIndex = 38
        Me.Button5.Text = "Imprimir Definiciones todas"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.Frozen = True
        Me.DataGridViewImageColumn1.HeaderText = "Column4"
        Me.DataGridViewImageColumn1.Image = Global.epd_SatelliteERP.My.Resources.Resources.Roja_Bandera
        Me.DataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewImageColumn1.Width = 50
        '
        'DataGridViewImageColumn2
        '
        Me.DataGridViewImageColumn2.Frozen = True
        Me.DataGridViewImageColumn2.HeaderText = ""
        Me.DataGridViewImageColumn2.Image = Global.epd_SatelliteERP.My.Resources.Resources.Roja_Bandera
        Me.DataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch
        Me.DataGridViewImageColumn2.Name = "DataGridViewImageColumn2"
        Me.DataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewImageColumn2.Width = 50
        '
        'ERP_Finance_ReportAccountingTableAdapter
        '
        Me.ERP_Finance_ReportAccountingTableAdapter.ClearBeforeFill = True
        '
        'ModuloContabilidad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.pnlMain)
        Me.Name = "ModuloContabilidad"
        Me.Size = New System.Drawing.Size(1096, 575)
        CType(Me.ERP_Finance_ReportAccountingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EPD_SatelliteERPDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlMain.ResumeLayout(False)
        Me.pnlMain.PerformLayout()
        Me.tcMain.ResumeLayout(False)
        Me.CatalogoContable.ResumeLayout(False)
        Me.CatalogoContable.PerformLayout()
        Me.gbStudentDetails.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CM_CuentaContable.ResumeLayout(False)
        Me.TrabajarPartidas.ResumeLayout(False)
        Me.FLP_PartidasContables.ResumeLayout(False)
        CType(Me.DG_AccountingIitemHeading, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CM_PartidasContables.ResumeLayout(False)
        Me.FLP_MenuPartidas.ResumeLayout(False)
        Me.Contabilizar.ResumeLayout(False)
        Me.FLP_Contabilizar.ResumeLayout(False)
        CType(Me.DG_Contabilizar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FLP_MenuContablizar.ResumeLayout(False)
        Me.CloseGestion.ResumeLayout(False)
        Me.TLP_Ledger.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FLP_LedgerTools.ResumeLayout(False)
        Me.HistoryYear.ResumeLayout(False)
        Me.TLP_FiscalDocTools.ResumeLayout(False)
        CType(Me.DGW_YearCurrentList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.HistoryYearOld.ResumeLayout(False)
        Me.TLP_YearOLD.ResumeLayout(False)
        CType(Me.DGW_YearOLD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.ConfigExternal.ResumeLayout(False)
        Me.TLP_ConfigExternal.ResumeLayout(False)
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents pnlMain As Panel
    Private WithEvents lblMainTitle As Label
    Private WithEvents lblCopyright As Label
    Private WithEvents tcMain As TabControl
    Private WithEvents CatalogoContable As TabPage
    Private WithEvents gbStudentDetails As GroupBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TreeView1 As TreeView
    Friend WithEvents TrabajarPartidas As TabPage
    Friend WithEvents DG_AccountingIitemHeading As DataGridView
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents CM_CuentaContable As ContextMenuStrip
    Friend WithEvents CrearCuentaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarCuentaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModificarCuentaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NumeroCuentaContable As DataGridViewTextBoxColumn
    Friend WithEvents NombreCuentaContable As DataGridViewTextBoxColumn
    Friend WithEvents UsersCreate As DataGridViewTextBoxColumn
    Friend WithEvents DateCreate As DataGridViewTextBoxColumn
    Friend WithEvents UsersModify As DataGridViewTextBoxColumn
    Friend WithEvents DateModify As DataGridViewTextBoxColumn
    Friend WithEvents FLP_PartidasContables As TableLayoutPanel
    Friend WithEvents FLP_MenuPartidas As FlowLayoutPanel
    Private WithEvents cmdPreview As Button
    Private WithEvents cmdLibroMayor As Button
    Private WithEvents cmdCreate As Button
    Friend WithEvents CM_PartidasContables As ContextMenuStrip
    Friend WithEvents CrearPartidaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CrearPartidaFechaPorParametroToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModificarPartidaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarPartidaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Private WithEvents Contabilizar As TabPage
    Friend WithEvents FLP_Contabilizar As TableLayoutPanel
    Friend WithEvents DG_Contabilizar As DataGridView
    Friend WithEvents FLP_MenuContablizar As FlowLayoutPanel
    Friend WithEvents Imagen1 As DataGridViewImageColumn
    Friend WithEvents Id_AccountingIitemHeading As DataGridViewTextBoxColumn
    Friend WithEvents BusinessDay As DataGridViewTextBoxColumn
    Friend WithEvents Name_ClassificationItemType As DataGridViewTextBoxColumn
    Friend WithEvents Concept_AccountingIitemHeading As DataGridViewTextBoxColumn
    Friend WithEvents Total_Charge As DataGridViewTextBoxColumn
    Friend WithEvents Total_Deposit As DataGridViewTextBoxColumn
    Friend WithEvents UsersCreate1 As DataGridViewTextBoxColumn
    Friend WithEvents DateCreate1 As DataGridViewTextBoxColumn
    Friend WithEvents Is_Square1 As DataGridViewCheckBoxColumn
    Friend WithEvents Date_Square1 As DataGridViewTextBoxColumn
    Friend WithEvents Is_Posting1 As DataGridViewCheckBoxColumn
    Friend WithEvents DatePosting1 As DataGridViewTextBoxColumn
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents CloseGestion As TabPage
    Friend WithEvents TLP_Ledger As TableLayoutPanel
    Friend WithEvents FLP_LedgerTools As FlowLayoutPanel
    Private WithEvents cmdLadgerPreview As Button
    Private WithEvents cmdLadgerPrinter As Button
    Private WithEvents cmdClosePeriod As Button
    Private WithEvents cmdLadgerPrinterCero As Button
    Private WithEvents cmdLadgerPreviewFull As Button
    Private WithEvents cmdLadgerPriviewFull As Button
    Friend WithEvents DataGridViewImageColumn2 As DataGridViewImageColumn
    Friend WithEvents HistoryYear As TabPage
    Friend WithEvents TLP_FiscalDocTools As TableLayoutPanel
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Private WithEvents cmdPartidaContable As Button
    Friend WithEvents ERP_Finance_ReportAccountingBindingSource As BindingSource
    Friend WithEvents EPD_SatelliteERPDataSet As EPD_SatelliteERPDataSet
    Friend WithEvents ERP_Finance_ReportAccountingTableAdapter As EPD_SatelliteERPDataSetTableAdapters.ERP_Finance_ReportAccountingTableAdapter
    Private WithEvents cmdContabilidadLibroMayorPreview As Button
    Private WithEvents cmdContabilidadLibroAuxiliarPreview As Button
    Private WithEvents cmdBalance As Button
    Private WithEvents cmdBalanceComprobacion As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataGridViewImageColumn3 As DataGridViewImageColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn2 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Private WithEvents cmdContabilizar As Button
    Friend WithEvents DGW_YearCurrentList As DataGridView
    Private WithEvents cmdLibroDiarioHistorico As Button
    Private WithEvents cmdHistoryLibroMayor As Button
    Private WithEvents cmdHistoryLibroAuxiliar As Button
    Private WithEvents cmdHistoryBalanceGeneral As Button
    Private WithEvents cmdHistoryBalanceComprobacion As Button
    Friend WithEvents DataGridViewImageColumn4 As DataGridViewImageColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Private WithEvents HistoryYearOld As TabPage
    Friend WithEvents TLP_YearOLD As TableLayoutPanel
    Friend WithEvents DGW_YearOLD As DataGridView
    Friend WithEvents DataGridViewImageColumn5 As DataGridViewImageColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As DataGridViewTextBoxColumn
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Private WithEvents Button7 As Button
    Private WithEvents Button8 As Button
    Private WithEvents Button9 As Button
    Private WithEvents Button10 As Button
    Private WithEvents Button11 As Button
    Private WithEvents cmdPartidaGestionContable As Button
    Friend WithEvents ConfigExternal As TabPage
    Friend WithEvents TLP_ConfigExternal As TableLayoutPanel
    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents DataGridViewImageColumn6 As DataGridViewImageColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn25 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn26 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn27 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn28 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn29 As DataGridViewTextBoxColumn
    Friend WithEvents FlowLayoutPanel3 As FlowLayoutPanel
    Private WithEvents cmdPartidaConfigSistemaExternoCreate As Button
    Private WithEvents cmdPartidaConfigSistemaExternoModify As Button
    Private WithEvents Button3 As Button
    Private WithEvents Button4 As Button
    Private WithEvents Button5 As Button
    Private WithEvents cmd_Partida_RevertirPartida As Button
    Private WithEvents cmd_Partida_CopiaPartida As Button
    Private WithEvents Button6 As Button
    Private WithEvents Button12 As Button
    Friend WithEvents CrearPartidadContablePorDistribucionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Imagen As DataGridViewImageColumn
    Friend WithEvents Correlativo As DataGridViewTextBoxColumn
    Friend WithEvents NoPartida As DataGridViewTextBoxColumn
    Friend WithEvents Estado As DataGridViewTextBoxColumn
    Friend WithEvents Fecha As DataGridViewTextBoxColumn
    Friend WithEvents Clasificacion As DataGridViewTextBoxColumn
    Friend WithEvents Concepto As DataGridViewTextBoxColumn
    Friend WithEvents TotalAbono As DataGridViewTextBoxColumn
    Friend WithEvents TotalCargo As DataGridViewTextBoxColumn
    Friend WithEvents Usuario As DataGridViewTextBoxColumn
    Friend WithEvents FechaCreacion As DataGridViewTextBoxColumn
    Friend WithEvents Is_Square As DataGridViewCheckBoxColumn
    Friend WithEvents Date_Square As DataGridViewTextBoxColumn
    Friend WithEvents Is_Posting As DataGridViewCheckBoxColumn
    Friend WithEvents DatePosting As DataGridViewTextBoxColumn
End Class
