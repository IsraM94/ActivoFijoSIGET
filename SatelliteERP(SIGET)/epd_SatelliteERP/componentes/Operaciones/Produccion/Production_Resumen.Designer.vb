<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Production_Resumen
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.SP_Report_ScheduledBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EPD_SatelliteERPDataSet2 = New epd_SatelliteERP.EPD_SatelliteERPDataSet2()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.rpActividades = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.SP_Report_ScheduledTableAdapter = New epd_SatelliteERP.EPD_SatelliteERPDataSet2TableAdapters.SP_Report_ScheduledTableAdapter()
        Me.SP_Report_ScheduledTableAdapterGeneral = New epd_SatelliteERP.EPD_SatelliteERPDataSet2TableAdapters.SP_Report_ScheduledTableAdapter()
        Me.SPReportScheduledGeneralTableAdapterBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.SPReportScheduledGeneralTableAdapterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.SP_Report_ScheduledBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EPD_SatelliteERPDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.SPReportScheduledGeneralTableAdapterBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SPReportScheduledGeneralTableAdapterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SP_Report_ScheduledBindingSource
        '
        Me.SP_Report_ScheduledBindingSource.DataMember = "SP_Report_Scheduled"
        Me.SP_Report_ScheduledBindingSource.DataSource = Me.EPD_SatelliteERPDataSet2
        '
        'EPD_SatelliteERPDataSet2
        '
        Me.EPD_SatelliteERPDataSet2.DataSetName = "EPD_SatelliteERPDataSet2"
        Me.EPD_SatelliteERPDataSet2.Locale = New System.Globalization.CultureInfo("en-US")
        Me.EPD_SatelliteERPDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.rpActividades)
        Me.GroupBox1.Controls.Add(Me.cmdCancel)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(7, 16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(826, 430)
        Me.GroupBox1.TabIndex = 33
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Lista"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Gainsboro
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(322, 381)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(98, 38)
        Me.Button1.TabIndex = 35
        Me.Button1.Text = "imprimir"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'rpActividades
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.SP_Report_ScheduledBindingSource
        Me.rpActividades.LocalReport.DataSources.Add(ReportDataSource1)
        Me.rpActividades.LocalReport.ReportEmbeddedResource = "epd_SatelliteERP.Report_Production_Process.rdlc"
        Me.rpActividades.Location = New System.Drawing.Point(16, 32)
        Me.rpActividades.Name = "rpActividades"
        Me.rpActividades.Size = New System.Drawing.Size(804, 336)
        Me.rpActividades.TabIndex = 34
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
        Me.cmdCancel.Location = New System.Drawing.Point(435, 381)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(98, 38)
        Me.cmdCancel.TabIndex = 33
        Me.cmdCancel.Text = "Cancelar"
        Me.cmdCancel.UseVisualStyleBackColor = False
        '
        'SP_Report_ScheduledTableAdapter
        '
        Me.SP_Report_ScheduledTableAdapter.ClearBeforeFill = True
        '
        'SP_Report_ScheduledTableAdapterGeneral
        '
        Me.SP_Report_ScheduledTableAdapterGeneral.ClearBeforeFill = True
        '
        'SPReportScheduledGeneralTableAdapterBindingSource1
        '
        Me.SPReportScheduledGeneralTableAdapterBindingSource1.DataSource = GetType(epd_SatelliteERP.EPD_SatelliteERPDataSet2TableAdapters.SP_Report_ScheduledGeneralTableAdapter)
        '
        'SPReportScheduledGeneralTableAdapterBindingSource
        '
        Me.SPReportScheduledGeneralTableAdapterBindingSource.DataSource = GetType(epd_SatelliteERP.EPD_SatelliteERPDataSet2TableAdapters.SP_Report_ScheduledGeneralTableAdapter)
        '
        'Production_Resumen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(843, 463)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Production_Resumen"
        Me.Text = "Production_Resumen"
        CType(Me.SP_Report_ScheduledBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EPD_SatelliteERPDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.SPReportScheduledGeneralTableAdapterBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SPReportScheduledGeneralTableAdapterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Private WithEvents cmdCancel As Button
    Friend WithEvents SP_Report_ScheduledBindingSource As BindingSource
    Friend WithEvents EPD_SatelliteERPDataSet2 As EPD_SatelliteERPDataSet2
    Friend WithEvents SP_Report_ScheduledTableAdapter As EPD_SatelliteERPDataSet2TableAdapters.SP_Report_ScheduledTableAdapter
    Private WithEvents Button1 As Button
    Friend WithEvents rpActividades As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents SPReportScheduledGeneralTableAdapterBindingSource As BindingSource
    Friend WithEvents SP_Report_ScheduledTableAdapterGeneral As EPD_SatelliteERPDataSet2TableAdapters.SP_Report_ScheduledTableAdapter
    Friend WithEvents SPReportScheduledGeneralTableAdapterBindingSource1 As BindingSource
End Class
