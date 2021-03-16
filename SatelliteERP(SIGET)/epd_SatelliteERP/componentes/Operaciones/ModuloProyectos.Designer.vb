<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModuloProyectos
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
		Me.tcMain = New System.Windows.Forms.TabControl()
		Me.VistaGeneral = New System.Windows.Forms.TabPage()
		Me.gbStudentDetails = New System.Windows.Forms.GroupBox()
		Me.Proyectos = New System.Windows.Forms.TabPage()
		Me.TLP_Facturacion = New System.Windows.Forms.TableLayoutPanel()
		Me.DGW_FacturasLista = New System.Windows.Forms.DataGridView()
		Me.Correlativo = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.BusinessDay = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Commercial_Name = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Fullpayment = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.DocumentNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.DescriptionCustomer = New System.Windows.Forms.DataGridViewCheckBoxColumn()
		Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Date_EndProject = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.FechaAnulacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.UsuarioAnulo = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
		Me.cmdCreateProyecto = New System.Windows.Forms.Button()
		Me.cmdCreateCF = New System.Windows.Forms.Button()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.Button3 = New System.Windows.Forms.Button()
		Me.Button5 = New System.Windows.Forms.Button()
		Me.Button2 = New System.Windows.Forms.Button()
		Me.Button4 = New System.Windows.Forms.Button()
		Me.Button6 = New System.Windows.Forms.Button()
		Me.tcMain.SuspendLayout()
		Me.VistaGeneral.SuspendLayout()
		Me.Proyectos.SuspendLayout()
		Me.TLP_Facturacion.SuspendLayout()
		CType(Me.DGW_FacturasLista, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.FlowLayoutPanel1.SuspendLayout()
		Me.SuspendLayout()
		'
		'tcMain
		'
		Me.tcMain.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
		Me.tcMain.Controls.Add(Me.VistaGeneral)
		Me.tcMain.Controls.Add(Me.Proyectos)
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
		'Proyectos
		'
		Me.Proyectos.Controls.Add(Me.TLP_Facturacion)
		Me.Proyectos.Location = New System.Drawing.Point(4, 35)
		Me.Proyectos.Name = "Proyectos"
		Me.Proyectos.Size = New System.Drawing.Size(1087, 540)
		Me.Proyectos.TabIndex = 4
		Me.Proyectos.Text = "Proyectos"
		Me.Proyectos.UseVisualStyleBackColor = True
		'
		'TLP_Facturacion
		'
		Me.TLP_Facturacion.ColumnCount = 1
		Me.TLP_Facturacion.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TLP_Facturacion.Controls.Add(Me.DGW_FacturasLista, 0, 1)
		Me.TLP_Facturacion.Controls.Add(Me.FlowLayoutPanel1, 0, 0)
		Me.TLP_Facturacion.Dock = System.Windows.Forms.DockStyle.Fill
		Me.TLP_Facturacion.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TLP_Facturacion.Location = New System.Drawing.Point(0, 0)
		Me.TLP_Facturacion.Name = "TLP_Facturacion"
		Me.TLP_Facturacion.RowCount = 2
		Me.TLP_Facturacion.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75.0!))
		Me.TLP_Facturacion.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TLP_Facturacion.Size = New System.Drawing.Size(1087, 540)
		Me.TLP_Facturacion.TabIndex = 1
		'
		'DGW_FacturasLista
		'
		Me.DGW_FacturasLista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
		Me.DGW_FacturasLista.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.DGW_FacturasLista.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Correlativo, Me.BusinessDay, Me.Commercial_Name, Me.Fullpayment, Me.DocumentNumber, Me.DescriptionCustomer, Me.Column8, Me.Date_EndProject, Me.FechaAnulacion, Me.UsuarioAnulo})
		Me.DGW_FacturasLista.Dock = System.Windows.Forms.DockStyle.Fill
		Me.DGW_FacturasLista.EnableHeadersVisualStyles = False
		Me.DGW_FacturasLista.Location = New System.Drawing.Point(3, 78)
		Me.DGW_FacturasLista.Name = "DGW_FacturasLista"
		Me.DGW_FacturasLista.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
		Me.DGW_FacturasLista.RowHeadersVisible = False
		Me.DGW_FacturasLista.ShowCellErrors = False
		Me.DGW_FacturasLista.ShowCellToolTips = False
		Me.DGW_FacturasLista.ShowEditingIcon = False
		Me.DGW_FacturasLista.ShowRowErrors = False
		Me.DGW_FacturasLista.Size = New System.Drawing.Size(1081, 459)
		Me.DGW_FacturasLista.TabIndex = 0
		'
		'Correlativo
		'
		Me.Correlativo.DataPropertyName = "ID_TransactionHeader"
		Me.Correlativo.HeaderText = "Correlativo"
		Me.Correlativo.Name = "Correlativo"
		Me.Correlativo.Width = 107
		'
		'BusinessDay
		'
		Me.BusinessDay.DataPropertyName = "BusinessDay"
		Me.BusinessDay.HeaderText = "Fecha"
		Me.BusinessDay.Name = "BusinessDay"
		Me.BusinessDay.Width = 72
		'
		'Commercial_Name
		'
		Me.Commercial_Name.DataPropertyName = "Commercial_Name"
		Me.Commercial_Name.HeaderText = "Cliente / Razón Social"
		Me.Commercial_Name.Name = "Commercial_Name"
		Me.Commercial_Name.Width = 179
		'
		'Fullpayment
		'
		Me.Fullpayment.DataPropertyName = "Name_Project"
		Me.Fullpayment.HeaderText = "Nombre Proyecto"
		Me.Fullpayment.Name = "Fullpayment"
		Me.Fullpayment.Width = 151
		'
		'DocumentNumber
		'
		Me.DocumentNumber.HeaderText = "Tipo Proyecto"
		Me.DocumentNumber.Name = "DocumentNumber"
		Me.DocumentNumber.Width = 126
		'
		'DescriptionCustomer
		'
		Me.DescriptionCustomer.DataPropertyName = "StatusTransaction"
		Me.DescriptionCustomer.HeaderText = "Estado"
		Me.DescriptionCustomer.Name = "DescriptionCustomer"
		Me.DescriptionCustomer.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
		Me.DescriptionCustomer.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
		Me.DescriptionCustomer.Width = 79
		'
		'Column8
		'
		Me.Column8.DataPropertyName = "Percent_Project"
		Me.Column8.HeaderText = "Avance"
		Me.Column8.Name = "Column8"
		Me.Column8.Width = 82
		'
		'Date_EndProject
		'
		Me.Date_EndProject.DataPropertyName = "Date_EndProject"
		Me.Date_EndProject.HeaderText = "Fecha Finalización"
		Me.Date_EndProject.Name = "Date_EndProject"
		Me.Date_EndProject.Width = 154
		'
		'FechaAnulacion
		'
		Me.FechaAnulacion.HeaderText = "Líder Proyecto"
		Me.FechaAnulacion.Name = "FechaAnulacion"
		Me.FechaAnulacion.Width = 129
		'
		'UsuarioAnulo
		'
		Me.UsuarioAnulo.HeaderText = "Líder Interno"
		Me.UsuarioAnulo.Name = "UsuarioAnulo"
		Me.UsuarioAnulo.Width = 118
		'
		'FlowLayoutPanel1
		'
		Me.FlowLayoutPanel1.Controls.Add(Me.cmdCreateProyecto)
		Me.FlowLayoutPanel1.Controls.Add(Me.cmdCreateCF)
		Me.FlowLayoutPanel1.Controls.Add(Me.Button1)
		Me.FlowLayoutPanel1.Controls.Add(Me.Button3)
		Me.FlowLayoutPanel1.Controls.Add(Me.Button5)
		Me.FlowLayoutPanel1.Controls.Add(Me.Button2)
		Me.FlowLayoutPanel1.Controls.Add(Me.Button4)
		Me.FlowLayoutPanel1.Controls.Add(Me.Button6)
		Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.FlowLayoutPanel1.Location = New System.Drawing.Point(3, 3)
		Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
		Me.FlowLayoutPanel1.Size = New System.Drawing.Size(1081, 69)
		Me.FlowLayoutPanel1.TabIndex = 1
		'
		'cmdCreateProyecto
		'
		Me.cmdCreateProyecto.BackColor = System.Drawing.Color.Gainsboro
		Me.cmdCreateProyecto.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
		Me.cmdCreateProyecto.FlatAppearance.BorderSize = 0
		Me.cmdCreateProyecto.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
		Me.cmdCreateProyecto.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
		Me.cmdCreateProyecto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.cmdCreateProyecto.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdCreateProyecto.Location = New System.Drawing.Point(3, 3)
		Me.cmdCreateProyecto.Name = "cmdCreateProyecto"
		Me.cmdCreateProyecto.Size = New System.Drawing.Size(98, 66)
		Me.cmdCreateProyecto.TabIndex = 31
		Me.cmdCreateProyecto.Text = "Crear Proyecto"
		Me.cmdCreateProyecto.UseVisualStyleBackColor = False
		'
		'cmdCreateCF
		'
		Me.cmdCreateCF.BackColor = System.Drawing.Color.Gainsboro
		Me.cmdCreateCF.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
		Me.cmdCreateCF.FlatAppearance.BorderSize = 0
		Me.cmdCreateCF.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
		Me.cmdCreateCF.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
		Me.cmdCreateCF.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.cmdCreateCF.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdCreateCF.Location = New System.Drawing.Point(107, 3)
		Me.cmdCreateCF.Name = "cmdCreateCF"
		Me.cmdCreateCF.Size = New System.Drawing.Size(113, 66)
		Me.cmdCreateCF.TabIndex = 33
		Me.cmdCreateCF.Text = "Modificar Proyecto"
		Me.cmdCreateCF.UseVisualStyleBackColor = False
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
		Me.Button1.Location = New System.Drawing.Point(226, 3)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(112, 66)
		Me.Button1.TabIndex = 32
		Me.Button1.Text = "Seguimiento Proyecto"
		Me.Button1.UseVisualStyleBackColor = False
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
		Me.Button3.Size = New System.Drawing.Size(112, 66)
		Me.Button3.TabIndex = 34
		Me.Button3.Text = "Pagos de Proyectos"
		Me.Button3.UseVisualStyleBackColor = False
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
		Me.Button5.Location = New System.Drawing.Point(462, 3)
		Me.Button5.Name = "Button5"
		Me.Button5.Size = New System.Drawing.Size(123, 66)
		Me.Button5.TabIndex = 37
		Me.Button5.Text = "Vista Informe Proyecto"
		Me.Button5.UseVisualStyleBackColor = False
		'
		'Button2
		'
		Me.Button2.BackColor = System.Drawing.Color.Gainsboro
		Me.Button2.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
		Me.Button2.FlatAppearance.BorderSize = 0
		Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
		Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
		Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Button2.Location = New System.Drawing.Point(591, 3)
		Me.Button2.Name = "Button2"
		Me.Button2.Size = New System.Drawing.Size(123, 66)
		Me.Button2.TabIndex = 36
		Me.Button2.Text = "Envio Informe Proyecto"
		Me.Button2.UseVisualStyleBackColor = False
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
		Me.Button4.Location = New System.Drawing.Point(720, 3)
		Me.Button4.Name = "Button4"
		Me.Button4.Size = New System.Drawing.Size(112, 66)
		Me.Button4.TabIndex = 35
		Me.Button4.Text = "Anular Proyecto"
		Me.Button4.UseVisualStyleBackColor = False
		'
		'Button6
		'
		Me.Button6.BackColor = System.Drawing.Color.Gainsboro
		Me.Button6.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
		Me.Button6.FlatAppearance.BorderSize = 0
		Me.Button6.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
		Me.Button6.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
		Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Button6.Location = New System.Drawing.Point(838, 3)
		Me.Button6.Name = "Button6"
		Me.Button6.Size = New System.Drawing.Size(112, 66)
		Me.Button6.TabIndex = 38
		Me.Button6.Text = "Planilla de Proyecto"
		Me.Button6.UseVisualStyleBackColor = False
		'
		'ModuloProyectos
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.Controls.Add(Me.tcMain)
		Me.Name = "ModuloProyectos"
		Me.Size = New System.Drawing.Size(1095, 579)
		Me.tcMain.ResumeLayout(False)
		Me.VistaGeneral.ResumeLayout(False)
		Me.Proyectos.ResumeLayout(False)
		Me.TLP_Facturacion.ResumeLayout(False)
		CType(Me.DGW_FacturasLista, System.ComponentModel.ISupportInitialize).EndInit()
		Me.FlowLayoutPanel1.ResumeLayout(False)
		Me.ResumeLayout(False)

	End Sub

	Private WithEvents tcMain As TabControl
    Private WithEvents VistaGeneral As TabPage
    Private WithEvents gbStudentDetails As GroupBox
    Friend WithEvents Proyectos As TabPage
    Friend WithEvents TLP_Facturacion As TableLayoutPanel
    Friend WithEvents DGW_FacturasLista As DataGridView
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Private WithEvents cmdCreateProyecto As Button
    Private WithEvents Button1 As Button
    Private WithEvents cmdCreateCF As Button
    Private WithEvents Button3 As Button
    Private WithEvents Button4 As Button
    Friend WithEvents StatusTransaction As DataGridViewCheckBoxColumn
    Private WithEvents Button2 As Button
    Private WithEvents Button5 As Button
    Private WithEvents Button6 As Button
    Friend WithEvents Correlativo As DataGridViewTextBoxColumn
    Friend WithEvents BusinessDay As DataGridViewTextBoxColumn
    Friend WithEvents Commercial_Name As DataGridViewTextBoxColumn
    Friend WithEvents Fullpayment As DataGridViewTextBoxColumn
    Friend WithEvents DocumentNumber As DataGridViewTextBoxColumn
    Friend WithEvents DescriptionCustomer As DataGridViewCheckBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Date_EndProject As DataGridViewTextBoxColumn
    Friend WithEvents FechaAnulacion As DataGridViewTextBoxColumn
    Friend WithEvents UsuarioAnulo As DataGridViewTextBoxColumn
End Class
