<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ModuloConfiguracionReportes
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
        Me.tabMantenimientos = New System.Windows.Forms.TabControl()
        Me.TPConfReportes = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.dgv_GenericReports = New System.Windows.Forms.DataGridView()
        Me.Id_Header = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Name_Header = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descrip_Header = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Create_Users = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Create_Date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Modify_Users = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Modify_Date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_Modulo_Fk = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.cmdDefinirReporte = New System.Windows.Forms.Button()
        Me.cmdModificarReporte = New System.Windows.Forms.Button()
        Me.cmdEliminarReporte = New System.Windows.Forms.Button()
        Me.TPModulos = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.dtg_Modulo = New System.Windows.Forms.DataGridView()
        Me.id_Module = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Name_ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Create_Users_ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Create_Date_ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Modify_Users_ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Modify_Date_ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.tabMantenimientos.SuspendLayout()
        Me.TPConfReportes.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.dgv_GenericReports, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.TPModulos.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.dtg_Modulo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabMantenimientos
        '
        Me.tabMantenimientos.Controls.Add(Me.TPConfReportes)
        Me.tabMantenimientos.Controls.Add(Me.TPModulos)
        Me.tabMantenimientos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabMantenimientos.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.tabMantenimientos.Location = New System.Drawing.Point(0, 0)
        Me.tabMantenimientos.Name = "tabMantenimientos"
        Me.tabMantenimientos.SelectedIndex = 0
        Me.tabMantenimientos.Size = New System.Drawing.Size(773, 487)
        Me.tabMantenimientos.TabIndex = 1
        '
        'TPConfReportes
        '
        Me.TPConfReportes.Controls.Add(Me.TableLayoutPanel1)
        Me.TPConfReportes.Location = New System.Drawing.Point(4, 32)
        Me.TPConfReportes.Name = "TPConfReportes"
        Me.TPConfReportes.Padding = New System.Windows.Forms.Padding(3)
        Me.TPConfReportes.Size = New System.Drawing.Size(765, 451)
        Me.TPConfReportes.TabIndex = 0
        Me.TPConfReportes.Text = "Configuración de Reportes"
        Me.TPConfReportes.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.dgv_GenericReports, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.FlowLayoutPanel1, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(759, 445)
        Me.TableLayoutPanel1.TabIndex = 4
        '
        'dgv_GenericReports
        '
        Me.dgv_GenericReports.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgv_GenericReports.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_GenericReports.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id_Header, Me.Name_Header, Me.Descrip_Header, Me.Create_Users, Me.Create_Date, Me.Modify_Users, Me.Modify_Date, Me.id_Modulo_Fk})
        Me.dgv_GenericReports.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_GenericReports.EnableHeadersVisualStyles = False
        Me.dgv_GenericReports.Location = New System.Drawing.Point(3, 78)
        Me.dgv_GenericReports.Name = "dgv_GenericReports"
        Me.dgv_GenericReports.RowHeadersVisible = False
        Me.dgv_GenericReports.ShowCellErrors = False
        Me.dgv_GenericReports.ShowCellToolTips = False
        Me.dgv_GenericReports.ShowEditingIcon = False
        Me.dgv_GenericReports.ShowRowErrors = False
        Me.dgv_GenericReports.Size = New System.Drawing.Size(753, 364)
        Me.dgv_GenericReports.TabIndex = 4
        '
        'Id_Header
        '
        Me.Id_Header.DataPropertyName = "Id_Header"
        Me.Id_Header.HeaderText = "Id Encabezado"
        Me.Id_Header.Name = "Id_Header"
        '
        'Name_Header
        '
        Me.Name_Header.DataPropertyName = "Name_Header"
        Me.Name_Header.HeaderText = "Nombre Encabezado"
        Me.Name_Header.Name = "Name_Header"
        '
        'Descrip_Header
        '
        Me.Descrip_Header.DataPropertyName = "Descrip_Header"
        Me.Descrip_Header.HeaderText = "Descipcion Encabezado"
        Me.Descrip_Header.Name = "Descrip_Header"
        '
        'Create_Users
        '
        Me.Create_Users.DataPropertyName = "Create_Users"
        Me.Create_Users.HeaderText = "Usuario Creacion"
        Me.Create_Users.Name = "Create_Users"
        '
        'Create_Date
        '
        Me.Create_Date.DataPropertyName = "Create_Date"
        Me.Create_Date.HeaderText = "Fecha Creacion"
        Me.Create_Date.Name = "Create_Date"
        '
        'Modify_Users
        '
        Me.Modify_Users.DataPropertyName = "Modify_Users"
        Me.Modify_Users.HeaderText = "Usuario Modificacion"
        Me.Modify_Users.Name = "Modify_Users"
        '
        'Modify_Date
        '
        Me.Modify_Date.DataPropertyName = "Modify_Date"
        Me.Modify_Date.HeaderText = "Fecha Modificacion"
        Me.Modify_Date.Name = "Modify_Date"
        '
        'id_Modulo_Fk
        '
        Me.id_Modulo_Fk.DataPropertyName = "id_Modulo_Fk"
        Me.id_Modulo_Fk.HeaderText = "Modulo"
        Me.id_Modulo_Fk.Name = "id_Modulo_Fk"
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.cmdDefinirReporte)
        Me.FlowLayoutPanel1.Controls.Add(Me.cmdModificarReporte)
        Me.FlowLayoutPanel1.Controls.Add(Me.cmdEliminarReporte)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(753, 68)
        Me.FlowLayoutPanel1.TabIndex = 1
        '
        'cmdDefinirReporte
        '
        Me.cmdDefinirReporte.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.cmdDefinirReporte.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdDefinirReporte.FlatAppearance.BorderSize = 0
        Me.cmdDefinirReporte.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdDefinirReporte.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdDefinirReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdDefinirReporte.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDefinirReporte.Location = New System.Drawing.Point(3, 3)
        Me.cmdDefinirReporte.Name = "cmdDefinirReporte"
        Me.cmdDefinirReporte.Size = New System.Drawing.Size(98, 66)
        Me.cmdDefinirReporte.TabIndex = 30
        Me.cmdDefinirReporte.Text = "Definir Reporte"
        Me.cmdDefinirReporte.UseVisualStyleBackColor = False
        '
        'cmdModificarReporte
        '
        Me.cmdModificarReporte.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.cmdModificarReporte.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdModificarReporte.FlatAppearance.BorderSize = 0
        Me.cmdModificarReporte.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdModificarReporte.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdModificarReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdModificarReporte.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdModificarReporte.Location = New System.Drawing.Point(107, 3)
        Me.cmdModificarReporte.Name = "cmdModificarReporte"
        Me.cmdModificarReporte.Size = New System.Drawing.Size(98, 66)
        Me.cmdModificarReporte.TabIndex = 31
        Me.cmdModificarReporte.Text = "Modificar Reporte"
        Me.cmdModificarReporte.UseVisualStyleBackColor = False
        '
        'cmdEliminarReporte
        '
        Me.cmdEliminarReporte.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.cmdEliminarReporte.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdEliminarReporte.FlatAppearance.BorderSize = 0
        Me.cmdEliminarReporte.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdEliminarReporte.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdEliminarReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdEliminarReporte.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEliminarReporte.Location = New System.Drawing.Point(211, 3)
        Me.cmdEliminarReporte.Name = "cmdEliminarReporte"
        Me.cmdEliminarReporte.Size = New System.Drawing.Size(98, 66)
        Me.cmdEliminarReporte.TabIndex = 32
        Me.cmdEliminarReporte.Text = "Eliminar Reporte"
        Me.cmdEliminarReporte.UseVisualStyleBackColor = False
        '
        'TPModulos
        '
        Me.TPModulos.Controls.Add(Me.TableLayoutPanel2)
        Me.TPModulos.Location = New System.Drawing.Point(4, 32)
        Me.TPModulos.Name = "TPModulos"
        Me.TPModulos.Padding = New System.Windows.Forms.Padding(3)
        Me.TPModulos.Size = New System.Drawing.Size(765, 451)
        Me.TPModulos.TabIndex = 1
        Me.TPModulos.Text = "Modulos"
        Me.TPModulos.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.dtg_Modulo, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.FlowLayoutPanel2, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(759, 445)
        Me.TableLayoutPanel2.TabIndex = 5
        '
        'dtg_Modulo
        '
        Me.dtg_Modulo.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dtg_Modulo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dtg_Modulo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_Module, Me.Name_, Me.Create_Users_, Me.Create_Date_, Me.Modify_Users_, Me.Modify_Date_})
        Me.dtg_Modulo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtg_Modulo.EnableHeadersVisualStyles = False
        Me.dtg_Modulo.Location = New System.Drawing.Point(3, 78)
        Me.dtg_Modulo.Name = "dtg_Modulo"
        Me.dtg_Modulo.RowHeadersVisible = False
        Me.dtg_Modulo.ShowCellErrors = False
        Me.dtg_Modulo.ShowCellToolTips = False
        Me.dtg_Modulo.ShowEditingIcon = False
        Me.dtg_Modulo.ShowRowErrors = False
        Me.dtg_Modulo.Size = New System.Drawing.Size(753, 364)
        Me.dtg_Modulo.TabIndex = 3
        '
        'id_Module
        '
        Me.id_Module.DataPropertyName = "id_Module"
        Me.id_Module.HeaderText = "ID"
        Me.id_Module.Name = "id_Module"
        '
        'Name_
        '
        Me.Name_.DataPropertyName = "Name"
        Me.Name_.HeaderText = "Nombre"
        Me.Name_.Name = "Name_"
        '
        'Create_Users_
        '
        Me.Create_Users_.DataPropertyName = "Create_Users"
        Me.Create_Users_.HeaderText = "Usuario Creacion"
        Me.Create_Users_.Name = "Create_Users_"
        '
        'Create_Date_
        '
        Me.Create_Date_.DataPropertyName = "Create_Date"
        Me.Create_Date_.HeaderText = "Fecha Creacion"
        Me.Create_Date_.Name = "Create_Date_"
        '
        'Modify_Users_
        '
        Me.Modify_Users_.DataPropertyName = "Modify_Users"
        Me.Modify_Users_.HeaderText = "Usuario Modificacion"
        Me.Modify_Users_.Name = "Modify_Users_"
        '
        'Modify_Date_
        '
        Me.Modify_Date_.DataPropertyName = "Modify_Date"
        Me.Modify_Date_.HeaderText = "Fecha Modificacion"
        Me.Modify_Date_.Name = "Modify_Date_"
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.Controls.Add(Me.Button5)
        Me.FlowLayoutPanel2.Controls.Add(Me.Button6)
        Me.FlowLayoutPanel2.Controls.Add(Me.Button7)
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(753, 68)
        Me.FlowLayoutPanel2.TabIndex = 1
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.Button5.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button5.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(3, 3)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(98, 66)
        Me.Button5.TabIndex = 30
        Me.Button5.Text = "Agregar"
        Me.Button5.UseVisualStyleBackColor = False
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
        Me.Button6.Location = New System.Drawing.Point(107, 3)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(98, 66)
        Me.Button6.TabIndex = 31
        Me.Button6.Text = "Modificar"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.Button7.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.Button7.FlatAppearance.BorderSize = 0
        Me.Button7.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button7.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Location = New System.Drawing.Point(211, 3)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(98, 66)
        Me.Button7.TabIndex = 32
        Me.Button7.Text = "Eliminar"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'ModuloConfiguracionReportes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.tabMantenimientos)
        Me.Name = "ModuloConfiguracionReportes"
        Me.Size = New System.Drawing.Size(773, 487)
        Me.tabMantenimientos.ResumeLayout(False)
        Me.TPConfReportes.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.dgv_GenericReports, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.TPModulos.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        CType(Me.dtg_Modulo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tabMantenimientos As TabControl
    Friend WithEvents TPConfReportes As TabPage
    Friend WithEvents TPModulos As TabPage
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents dtg_Modulo As DataGridView
    Friend WithEvents id_Module As DataGridViewTextBoxColumn
    Friend WithEvents Name_ As DataGridViewTextBoxColumn
    Friend WithEvents Create_Users_ As DataGridViewTextBoxColumn
    Friend WithEvents Create_Date_ As DataGridViewTextBoxColumn
    Friend WithEvents Modify_Users_ As DataGridViewTextBoxColumn
    Friend WithEvents Modify_Date_ As DataGridViewTextBoxColumn
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Private WithEvents Button5 As Button
    Private WithEvents Button6 As Button
    Private WithEvents Button7 As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Private WithEvents cmdDefinirReporte As Button
    Private WithEvents cmdModificarReporte As Button
    Private WithEvents cmdEliminarReporte As Button
    Friend WithEvents dgv_GenericReports As DataGridView
    Friend WithEvents Id_Header As DataGridViewTextBoxColumn
    Friend WithEvents Name_Header As DataGridViewTextBoxColumn
    Friend WithEvents Descrip_Header As DataGridViewTextBoxColumn
    Friend WithEvents Create_Users As DataGridViewTextBoxColumn
    Friend WithEvents Create_Date As DataGridViewTextBoxColumn
    Friend WithEvents Modify_Users As DataGridViewTextBoxColumn
    Friend WithEvents Modify_Date As DataGridViewTextBoxColumn
    Friend WithEvents id_Modulo_Fk As DataGridViewTextBoxColumn
End Class
