<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ReportesGenerales_ReportViewer
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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Financiero_ReportViewer))
        Me.ERP_SP_Inventory_GetPurchaseOrdersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ERP_DS_Inventary = New epd_SatelliteERP.ERP_DS_Inventary()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.ERP_SP_Inventory_Report_PumpReadingsTableAdapter = New epd_SatelliteERP.EPD_SatelliteERPDataSet_InventarioTableAdapters.ERP_SP_Inventory_Report_PumpReadingsTableAdapter()
        Me.ERP_SP_Inventory_Report_PumpReadingsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EPD_SatelliteERPDataSet_Inventario = New epd_SatelliteERP.EPD_SatelliteERPDataSet_Inventario()
        Me.EPD_SatelliteERPDataSet = New epd_SatelliteERP.EPD_SatelliteERPDataSet()
        Me.ERP_Finance_ReportAccountingHighBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ERP_Finance_ReportAccountingHighTableAdapter = New epd_SatelliteERP.EPD_SatelliteERPDataSetTableAdapters.ERP_Finance_ReportAccountingHighTableAdapter()
        Me.SatelliteERP_InventarioDataInventoryStowage = New epd_SatelliteERP.SatelliteERP_InventarioDataInventoryStowage()
        Me.ERP_Maintenance_SelectInventoryStowageBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ERP_Maintenance_SelectInventoryStowageTableAdapter = New epd_SatelliteERP.SatelliteERP_InventarioDataInventoryStowageTableAdapters.ERP_Maintenance_SelectInventoryStowageTableAdapter()
        CType(Me.ERP_SP_Inventory_GetPurchaseOrdersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ERP_DS_Inventary, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ERP_SP_Inventory_Report_PumpReadingsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EPD_SatelliteERPDataSet_Inventario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EPD_SatelliteERPDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ERP_Finance_ReportAccountingHighBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SatelliteERP_InventarioDataInventoryStowage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ERP_Maintenance_SelectInventoryStowageBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ERP_SP_Inventory_GetPurchaseOrdersBindingSource
        '
        Me.ERP_SP_Inventory_GetPurchaseOrdersBindingSource.DataMember = "ERP_SP_Inventory_GetPurchaseOrders"
        Me.ERP_SP_Inventory_GetPurchaseOrdersBindingSource.DataSource = Me.ERP_DS_Inventary
        '
        'ERP_DS_Inventary
        '
        Me.ERP_DS_Inventary.DataSetName = "ERP_DS_Inventary"
        Me.ERP_DS_Inventary.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.AutoScroll = True
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "Datos"
        ReportDataSource1.Value = Me.ERP_SP_Inventory_GetPurchaseOrdersBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.EnableExternalImages = True
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(589, 434)
        Me.ReportViewer1.TabIndex = 0
        '
        'ERP_SP_Inventory_Report_PumpReadingsTableAdapter
        '
        Me.ERP_SP_Inventory_Report_PumpReadingsTableAdapter.ClearBeforeFill = True
        '
        'ERP_SP_Inventory_Report_PumpReadingsBindingSource
        '
        Me.ERP_SP_Inventory_Report_PumpReadingsBindingSource.DataMember = "ERP_SP_Inventory_Report_PumpReadings"
        Me.ERP_SP_Inventory_Report_PumpReadingsBindingSource.DataSource = Me.EPD_SatelliteERPDataSet_Inventario
        '
        'EPD_SatelliteERPDataSet_Inventario
        '
        Me.EPD_SatelliteERPDataSet_Inventario.DataSetName = "EPD_SatelliteERPDataSet_Inventario"
        Me.EPD_SatelliteERPDataSet_Inventario.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EPD_SatelliteERPDataSet
        '
        Me.EPD_SatelliteERPDataSet.DataSetName = "EPD_SatelliteERPDataSet"
        Me.EPD_SatelliteERPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ERP_Finance_ReportAccountingHighBindingSource
        '
        Me.ERP_Finance_ReportAccountingHighBindingSource.DataMember = "ERP_Finance_ReportAccountingHigh"
        Me.ERP_Finance_ReportAccountingHighBindingSource.DataSource = Me.EPD_SatelliteERPDataSet
        '
        'ERP_Finance_ReportAccountingHighTableAdapter
        '
        Me.ERP_Finance_ReportAccountingHighTableAdapter.ClearBeforeFill = True
        '
        'SatelliteERP_InventarioDataInventoryStowage
        '
        Me.SatelliteERP_InventarioDataInventoryStowage.DataSetName = "SatelliteERP_InventarioDataInventoryStowage"
        Me.SatelliteERP_InventarioDataInventoryStowage.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ERP_Maintenance_SelectInventoryStowageBindingSource
        '
        Me.ERP_Maintenance_SelectInventoryStowageBindingSource.DataMember = "ERP_Maintenance_SelectInventoryStowage"
        Me.ERP_Maintenance_SelectInventoryStowageBindingSource.DataSource = Me.SatelliteERP_InventarioDataInventoryStowage
        '
        'ERP_Maintenance_SelectInventoryStowageTableAdapter
        '
        Me.ERP_Maintenance_SelectInventoryStowageTableAdapter.ClearBeforeFill = True
        '
        'Financiero_ReportViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(589, 434)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Financiero_ReportViewer"
        Me.Text = "Visor de docuemntos"
        CType(Me.ERP_SP_Inventory_GetPurchaseOrdersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ERP_DS_Inventary, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ERP_SP_Inventory_Report_PumpReadingsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EPD_SatelliteERPDataSet_Inventario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EPD_SatelliteERPDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ERP_Finance_ReportAccountingHighBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SatelliteERP_InventarioDataInventoryStowage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ERP_Maintenance_SelectInventoryStowageBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ERP_SP_Inventory_GetPurchaseOrdersBindingSource As BindingSource
    Friend WithEvents ERP_DS_Inventary As ERP_DS_Inventary
    Friend WithEvents ERP_SP_Inventory_Report_PumpReadingsTableAdapter As EPD_SatelliteERPDataSet_InventarioTableAdapters.ERP_SP_Inventory_Report_PumpReadingsTableAdapter
    Friend WithEvents ERP_SP_Inventory_Report_PumpReadingsBindingSource As BindingSource
    Friend WithEvents EPD_SatelliteERPDataSet_Inventario As EPD_SatelliteERPDataSet_Inventario
    Friend WithEvents ERP_Finance_ReportAccountingHighBindingSource As BindingSource
    Friend WithEvents EPD_SatelliteERPDataSet As EPD_SatelliteERPDataSet
    Friend WithEvents ERP_Finance_ReportAccountingHighTableAdapter As EPD_SatelliteERPDataSetTableAdapters.ERP_Finance_ReportAccountingHighTableAdapter
    Friend WithEvents ERP_Maintenance_SelectInventoryStowageBindingSource As BindingSource
    Friend WithEvents SatelliteERP_InventarioDataInventoryStowage As SatelliteERP_InventarioDataInventoryStowage
    Friend WithEvents ERP_Maintenance_SelectInventoryStowageTableAdapter As SatelliteERP_InventarioDataInventoryStowageTableAdapters.ERP_Maintenance_SelectInventoryStowageTableAdapter
End Class
