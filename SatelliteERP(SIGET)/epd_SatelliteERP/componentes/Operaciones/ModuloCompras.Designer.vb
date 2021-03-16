<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ModuloCompras
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ModuloCompras))
        Me.tcMain = New System.Windows.Forms.TabControl()
        Me.VistaGeneral = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.FlowLayoutPanel4 = New System.Windows.Forms.FlowLayoutPanel()
        Me.UC_Actividades1 = New epd_SatelliteERP.UC_Actividades()
        Me.UC_Actividades3 = New epd_SatelliteERP.UC_Actividades()
        Me.UC_Actividades5 = New epd_SatelliteERP.UC_Actividades()
        Me.UC_Actividades6 = New epd_SatelliteERP.UC_Actividades()
        Me.UC_Actividades2 = New epd_SatelliteERP.UC_Actividades()
        Me.UC_Actividades4 = New epd_SatelliteERP.UC_Actividades()
        Me.LabelTituloActividades = New System.Windows.Forms.Label()
        Me.Compras = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.DGV_PurchaseOrders = New System.Windows.Forms.DataGridView()
        Me.Id_PurchaseOrder = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FlowLayoutPanel5 = New System.Windows.Forms.FlowLayoutPanel()
        Me.cmdComprasCrearOrden = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button15 = New System.Windows.Forms.Button()
        Me.cmdCompras_ListaExistencias = New System.Windows.Forms.Button()
        Me.cmdCompras_ListaExistenciasValorizada = New System.Windows.Forms.Button()
        Me.cmdOrderDetails = New System.Windows.Forms.Button()
        Me.tcMain.SuspendLayout()
        Me.VistaGeneral.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.FlowLayoutPanel4.SuspendLayout()
        Me.Compras.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.DGV_PurchaseOrders, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'tcMain
        '
        Me.tcMain.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.tcMain.Controls.Add(Me.VistaGeneral)
        Me.tcMain.Controls.Add(Me.Compras)
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
        Me.VistaGeneral.Controls.Add(Me.TableLayoutPanel1)
        Me.VistaGeneral.Location = New System.Drawing.Point(4, 35)
        Me.VistaGeneral.Name = "VistaGeneral"
        Me.VistaGeneral.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.VistaGeneral.Size = New System.Drawing.Size(1087, 540)
        Me.VistaGeneral.TabIndex = 0
        Me.VistaGeneral.Text = "Vista General"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.FlowLayoutPanel4, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelTituloActividades, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.96992!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.03008!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1079, 532)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'FlowLayoutPanel4
        '
        Me.FlowLayoutPanel4.Controls.Add(Me.UC_Actividades1)
        Me.FlowLayoutPanel4.Controls.Add(Me.UC_Actividades3)
        Me.FlowLayoutPanel4.Controls.Add(Me.UC_Actividades5)
        Me.FlowLayoutPanel4.Controls.Add(Me.UC_Actividades6)
        Me.FlowLayoutPanel4.Controls.Add(Me.UC_Actividades2)
        Me.FlowLayoutPanel4.Controls.Add(Me.UC_Actividades4)
        Me.FlowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel4.Location = New System.Drawing.Point(3, 71)
        Me.FlowLayoutPanel4.Name = "FlowLayoutPanel4"
        Me.FlowLayoutPanel4.Size = New System.Drawing.Size(1073, 458)
        Me.FlowLayoutPanel4.TabIndex = 0
        '
        'UC_Actividades1
        '
        Me.UC_Actividades1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.UC_Actividades1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UC_Actividades1.ColorFondo = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.UC_Actividades1.Descripcion = "Verificacion de informacion de compras y revisar lo que falta"
        Me.UC_Actividades1.Fecha = "2016-05-01"
        Me.UC_Actividades1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UC_Actividades1.Location = New System.Drawing.Point(4, 5)
        Me.UC_Actividades1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.UC_Actividades1.Name = "UC_Actividades1"
        Me.UC_Actividades1.NombreActividad = "Revisar Compras"
        Me.UC_Actividades1.PictureActidad = CType(resources.GetObject("UC_Actividades1.PictureActidad"), System.Drawing.Image)
        Me.UC_Actividades1.Size = New System.Drawing.Size(199, 112)
        Me.UC_Actividades1.TabIndex = 0
        '
        'UC_Actividades3
        '
        Me.UC_Actividades3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.UC_Actividades3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UC_Actividades3.ColorFondo = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.UC_Actividades3.Descripcion = "Verificacion de informacion de compras y revisar lo que falta"
        Me.UC_Actividades3.Fecha = "2016-05-01"
        Me.UC_Actividades3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UC_Actividades3.Location = New System.Drawing.Point(211, 5)
        Me.UC_Actividades3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.UC_Actividades3.Name = "UC_Actividades3"
        Me.UC_Actividades3.NombreActividad = "Revisar Compras"
        Me.UC_Actividades3.PictureActidad = CType(resources.GetObject("UC_Actividades3.PictureActidad"), System.Drawing.Image)
        Me.UC_Actividades3.Size = New System.Drawing.Size(199, 112)
        Me.UC_Actividades3.TabIndex = 2
        '
        'UC_Actividades5
        '
        Me.UC_Actividades5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.UC_Actividades5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UC_Actividades5.ColorFondo = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.UC_Actividades5.Descripcion = "Verificacion de informacion de compras y revisar lo que falta"
        Me.UC_Actividades5.Fecha = "2016-05-01"
        Me.UC_Actividades5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UC_Actividades5.Location = New System.Drawing.Point(418, 5)
        Me.UC_Actividades5.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.UC_Actividades5.Name = "UC_Actividades5"
        Me.UC_Actividades5.NombreActividad = "Revisar Compras"
        Me.UC_Actividades5.PictureActidad = CType(resources.GetObject("UC_Actividades5.PictureActidad"), System.Drawing.Image)
        Me.UC_Actividades5.Size = New System.Drawing.Size(199, 112)
        Me.UC_Actividades5.TabIndex = 4
        '
        'UC_Actividades6
        '
        Me.UC_Actividades6.BackColor = System.Drawing.Color.Crimson
        Me.UC_Actividades6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UC_Actividades6.ColorFondo = System.Drawing.Color.Crimson
        Me.UC_Actividades6.Descripcion = "Verificar existencias de maximos y minimos"
        Me.UC_Actividades6.Fecha = "2016-05-01"
        Me.UC_Actividades6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UC_Actividades6.Location = New System.Drawing.Point(625, 5)
        Me.UC_Actividades6.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.UC_Actividades6.Name = "UC_Actividades6"
        Me.UC_Actividades6.NombreActividad = "Actividades Diarias"
        Me.UC_Actividades6.PictureActidad = Global.epd_SatelliteERP.My.Resources.Resources.Roja_Bandera
        Me.UC_Actividades6.Size = New System.Drawing.Size(199, 112)
        Me.UC_Actividades6.TabIndex = 5
        '
        'UC_Actividades2
        '
        Me.UC_Actividades2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.UC_Actividades2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UC_Actividades2.ColorFondo = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.UC_Actividades2.Descripcion = "Verificar existencias de maximos y minimos"
        Me.UC_Actividades2.Fecha = "2016-05-01"
        Me.UC_Actividades2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UC_Actividades2.Location = New System.Drawing.Point(832, 5)
        Me.UC_Actividades2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.UC_Actividades2.Name = "UC_Actividades2"
        Me.UC_Actividades2.NombreActividad = "Actividades Diarias"
        Me.UC_Actividades2.PictureActidad = CType(resources.GetObject("UC_Actividades2.PictureActidad"), System.Drawing.Image)
        Me.UC_Actividades2.Size = New System.Drawing.Size(199, 112)
        Me.UC_Actividades2.TabIndex = 1
        '
        'UC_Actividades4
        '
        Me.UC_Actividades4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.UC_Actividades4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UC_Actividades4.ColorFondo = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.UC_Actividades4.Descripcion = "Verificacion de informacion de compras y revisar lo que falta"
        Me.UC_Actividades4.Fecha = "2016-05-01"
        Me.UC_Actividades4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UC_Actividades4.Location = New System.Drawing.Point(4, 127)
        Me.UC_Actividades4.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.UC_Actividades4.Name = "UC_Actividades4"
        Me.UC_Actividades4.NombreActividad = "Revisar Compras"
        Me.UC_Actividades4.PictureActidad = CType(resources.GetObject("UC_Actividades4.PictureActidad"), System.Drawing.Image)
        Me.UC_Actividades4.Size = New System.Drawing.Size(199, 112)
        Me.UC_Actividades4.TabIndex = 3
        '
        'LabelTituloActividades
        '
        Me.LabelTituloActividades.AutoSize = True
        Me.LabelTituloActividades.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelTituloActividades.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTituloActividades.Location = New System.Drawing.Point(3, 0)
        Me.LabelTituloActividades.Name = "LabelTituloActividades"
        Me.LabelTituloActividades.Size = New System.Drawing.Size(1073, 68)
        Me.LabelTituloActividades.TabIndex = 1
        Me.LabelTituloActividades.Text = "Actividades pendientes"
        Me.LabelTituloActividades.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Compras
        '
        Me.Compras.Controls.Add(Me.TableLayoutPanel2)
        Me.Compras.Location = New System.Drawing.Point(4, 35)
        Me.Compras.Name = "Compras"
        Me.Compras.Size = New System.Drawing.Size(1087, 540)
        Me.Compras.TabIndex = 9
        Me.Compras.Text = "Compras"
        Me.Compras.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.DGV_PurchaseOrders, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.FlowLayoutPanel5, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 81.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1087, 540)
        Me.TableLayoutPanel2.TabIndex = 3
        '
        'DGV_PurchaseOrders
        '
        Me.DGV_PurchaseOrders.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGV_PurchaseOrders.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id_PurchaseOrder, Me.Estado, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.Column1})
        Me.DGV_PurchaseOrders.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGV_PurchaseOrders.EnableHeadersVisualStyles = False
        Me.DGV_PurchaseOrders.Location = New System.Drawing.Point(3, 84)
        Me.DGV_PurchaseOrders.Name = "DGV_PurchaseOrders"
        Me.DGV_PurchaseOrders.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DGV_PurchaseOrders.RowHeadersVisible = False
        Me.DGV_PurchaseOrders.ShowCellErrors = False
        Me.DGV_PurchaseOrders.ShowCellToolTips = False
        Me.DGV_PurchaseOrders.ShowEditingIcon = False
        Me.DGV_PurchaseOrders.ShowRowErrors = False
        Me.DGV_PurchaseOrders.Size = New System.Drawing.Size(1081, 453)
        Me.DGV_PurchaseOrders.TabIndex = 0
        '
        'Id_PurchaseOrder
        '
        Me.Id_PurchaseOrder.DataPropertyName = "Id_PurchaseOrder"
        Me.Id_PurchaseOrder.HeaderText = "Correlativo"
        Me.Id_PurchaseOrder.Name = "Id_PurchaseOrder"
        Me.Id_PurchaseOrder.Width = 107
        '
        'Estado
        '
        Me.Estado.DataPropertyName = "Estado"
        Me.Estado.HeaderText = "Estado"
        Me.Estado.Name = "Estado"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "Commercial_Name"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Cliente / Razón Social"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.Width = 179
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "Comentario"
        Me.DataGridViewTextBoxColumn15.HeaderText = "Comentario"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.Width = 112
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "MontoAproximado"
        Me.DataGridViewTextBoxColumn16.HeaderText = "Monto Aprox."
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.Width = 125
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "FechaIngreso"
        Me.DataGridViewTextBoxColumn17.HeaderText = "Fecha Ing."
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "Usuario"
        Me.Column1.HeaderText = "Usuario"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 84
        '
        'FlowLayoutPanel5
        '
        Me.FlowLayoutPanel5.Controls.Add(Me.cmdComprasCrearOrden)
        Me.FlowLayoutPanel5.Controls.Add(Me.Button6)
        Me.FlowLayoutPanel5.Controls.Add(Me.Button15)
        Me.FlowLayoutPanel5.Controls.Add(Me.cmdCompras_ListaExistencias)
        Me.FlowLayoutPanel5.Controls.Add(Me.cmdCompras_ListaExistenciasValorizada)
        Me.FlowLayoutPanel5.Controls.Add(Me.cmdOrderDetails)
        Me.FlowLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel5.Location = New System.Drawing.Point(3, 3)
        Me.FlowLayoutPanel5.Name = "FlowLayoutPanel5"
        Me.FlowLayoutPanel5.Size = New System.Drawing.Size(1081, 75)
        Me.FlowLayoutPanel5.TabIndex = 1
        '
        'cmdComprasCrearOrden
        '
        Me.cmdComprasCrearOrden.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.cmdComprasCrearOrden.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdComprasCrearOrden.FlatAppearance.BorderSize = 0
        Me.cmdComprasCrearOrden.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdComprasCrearOrden.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdComprasCrearOrden.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdComprasCrearOrden.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdComprasCrearOrden.Location = New System.Drawing.Point(3, 3)
        Me.cmdComprasCrearOrden.Name = "cmdComprasCrearOrden"
        Me.cmdComprasCrearOrden.Size = New System.Drawing.Size(124, 66)
        Me.cmdComprasCrearOrden.TabIndex = 35
        Me.cmdComprasCrearOrden.Text = "Crear Orden"
        Me.cmdComprasCrearOrden.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.Button6.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button6.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(133, 3)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(124, 66)
        Me.Button6.TabIndex = 36
        Me.Button6.Text = "Eliminar Orden"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button15
        '
        Me.Button15.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.Button15.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.Button15.FlatAppearance.BorderSize = 0
        Me.Button15.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button15.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button15.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button15.Location = New System.Drawing.Point(263, 3)
        Me.Button15.Name = "Button15"
        Me.Button15.Size = New System.Drawing.Size(124, 66)
        Me.Button15.TabIndex = 34
        Me.Button15.Text = "Reporte de Órdenes"
        Me.Button15.UseVisualStyleBackColor = False
        '
        'cmdCompras_ListaExistencias
        '
        Me.cmdCompras_ListaExistencias.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.cmdCompras_ListaExistencias.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdCompras_ListaExistencias.FlatAppearance.BorderSize = 0
        Me.cmdCompras_ListaExistencias.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdCompras_ListaExistencias.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdCompras_ListaExistencias.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCompras_ListaExistencias.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCompras_ListaExistencias.Location = New System.Drawing.Point(393, 3)
        Me.cmdCompras_ListaExistencias.Name = "cmdCompras_ListaExistencias"
        Me.cmdCompras_ListaExistencias.Size = New System.Drawing.Size(124, 66)
        Me.cmdCompras_ListaExistencias.TabIndex = 39
        Me.cmdCompras_ListaExistencias.Text = "Listado Existencias"
        Me.cmdCompras_ListaExistencias.UseVisualStyleBackColor = False
        '
        'cmdCompras_ListaExistenciasValorizada
        '
        Me.cmdCompras_ListaExistenciasValorizada.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.cmdCompras_ListaExistenciasValorizada.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdCompras_ListaExistenciasValorizada.FlatAppearance.BorderSize = 0
        Me.cmdCompras_ListaExistenciasValorizada.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdCompras_ListaExistenciasValorizada.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdCompras_ListaExistenciasValorizada.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCompras_ListaExistenciasValorizada.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCompras_ListaExistenciasValorizada.Location = New System.Drawing.Point(523, 3)
        Me.cmdCompras_ListaExistenciasValorizada.Name = "cmdCompras_ListaExistenciasValorizada"
        Me.cmdCompras_ListaExistenciasValorizada.Size = New System.Drawing.Size(163, 66)
        Me.cmdCompras_ListaExistenciasValorizada.TabIndex = 40
        Me.cmdCompras_ListaExistenciasValorizada.Text = "Listado Existencias Valorizado"
        Me.cmdCompras_ListaExistenciasValorizada.UseVisualStyleBackColor = False
        '
        'cmdOrderDetails
        '
        Me.cmdOrderDetails.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.cmdOrderDetails.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdOrderDetails.FlatAppearance.BorderSize = 0
        Me.cmdOrderDetails.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdOrderDetails.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdOrderDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdOrderDetails.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOrderDetails.Location = New System.Drawing.Point(692, 3)
        Me.cmdOrderDetails.Name = "cmdOrderDetails"
        Me.cmdOrderDetails.Size = New System.Drawing.Size(141, 66)
        Me.cmdOrderDetails.TabIndex = 34
        Me.cmdOrderDetails.Text = "Reporte Detalle de Órdenes"
        Me.cmdOrderDetails.UseVisualStyleBackColor = False
        '
        'ModuloCompras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.tcMain)
        Me.Name = "ModuloCompras"
        Me.Size = New System.Drawing.Size(1095, 579)
        Me.tcMain.ResumeLayout(False)
        Me.VistaGeneral.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.FlowLayoutPanel4.ResumeLayout(False)
        Me.Compras.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        CType(Me.DGV_PurchaseOrders, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel5.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents tcMain As TabControl
    Private WithEvents VistaGeneral As TabPage
	Friend WithEvents StatusTransaction As DataGridViewCheckBoxColumn
	Friend WithEvents Compras As TabPage
	Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
	Friend WithEvents FlowLayoutPanel4 As FlowLayoutPanel
	Friend WithEvents LabelTituloActividades As Label
	Friend WithEvents UC_Actividades1 As UC_Actividades
	Friend WithEvents UC_Actividades2 As UC_Actividades
	Friend WithEvents UC_Actividades3 As UC_Actividades
	Friend WithEvents UC_Actividades4 As UC_Actividades
	Friend WithEvents UC_Actividades5 As UC_Actividades
	Friend WithEvents UC_Actividades6 As UC_Actividades
	Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
	Friend WithEvents DGV_PurchaseOrders As DataGridView
	Friend WithEvents FlowLayoutPanel5 As FlowLayoutPanel
	Private WithEvents cmdComprasCrearOrden As Button
	Private WithEvents Button6 As Button
	Private WithEvents Button15 As Button
    Private WithEvents cmdCompras_ListaExistencias As Button
    Private WithEvents cmdCompras_ListaExistenciasValorizada As Button
    Private WithEvents cmdOrderDetails As Button
    Friend WithEvents Id_PurchaseOrder As DataGridViewTextBoxColumn
    Friend WithEvents Estado As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
End Class
