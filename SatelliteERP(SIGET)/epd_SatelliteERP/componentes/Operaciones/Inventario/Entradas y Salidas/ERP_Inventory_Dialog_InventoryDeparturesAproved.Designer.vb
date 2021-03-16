<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ERP_Inventory_Dialog_InventoryDeparturesAproved
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnReimprimir = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cb_FiltroSalidas = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtBusquedad = New System.Windows.Forms.TextBox()
        Me.dgSalidasPro = New System.Windows.Forms.DataGridView()
        Me.Id_Output = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoSalida = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaCreacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Comentario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.usuariocreate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.cmdAprobar = New System.Windows.Forms.Button()
        Me.Menu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AgregarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgSalidasPro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Menu.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.btnReimprimir)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cb_FiltroSalidas)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtBusquedad)
        Me.GroupBox1.Controls.Add(Me.dgSalidasPro)
        Me.GroupBox1.Controls.Add(Me.cmdCancel)
        Me.GroupBox1.Controls.Add(Me.cmdAprobar)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1091, 619)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Listado de Salidas Pendientes de Aprobación"
        '
        'btnReimprimir
        '
        Me.btnReimprimir.BackColor = System.Drawing.Color.Gainsboro
        Me.btnReimprimir.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.btnReimprimir.FlatAppearance.BorderSize = 0
        Me.btnReimprimir.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.btnReimprimir.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.btnReimprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReimprimir.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReimprimir.Location = New System.Drawing.Point(499, 573)
        Me.btnReimprimir.Name = "btnReimprimir"
        Me.btnReimprimir.Size = New System.Drawing.Size(151, 28)
        Me.btnReimprimir.TabIndex = 17
        Me.btnReimprimir.Text = "Re imprimir Salida"
        Me.btnReimprimir.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(120, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 21)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Estado Salida: "
        '
        'cb_FiltroSalidas
        '
        Me.cb_FiltroSalidas.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cb_FiltroSalidas.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cb_FiltroSalidas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_FiltroSalidas.FormattingEnabled = True
        Me.cb_FiltroSalidas.Items.AddRange(New Object() {"Todas Salidas", "Salidas en Proceso", "Salidas de Revisión", "Salidas Aprobadas", "Salidas Denegadas"})
        Me.cb_FiltroSalidas.Location = New System.Drawing.Point(235, 52)
        Me.cb_FiltroSalidas.Name = "cb_FiltroSalidas"
        Me.cb_FiltroSalidas.Size = New System.Drawing.Size(261, 33)
        Me.cb_FiltroSalidas.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(620, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 21)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Palabra Busquedad:"
        '
        'txtBusquedad
        '
        Me.txtBusquedad.Location = New System.Drawing.Point(771, 42)
        Me.txtBusquedad.Name = "txtBusquedad"
        Me.txtBusquedad.Size = New System.Drawing.Size(239, 33)
        Me.txtBusquedad.TabIndex = 13
        '
        'dgSalidasPro
        '
        Me.dgSalidasPro.AllowUserToAddRows = False
        Me.dgSalidasPro.AllowUserToDeleteRows = False
        Me.dgSalidasPro.AllowUserToResizeColumns = False
        Me.dgSalidasPro.AllowUserToResizeRows = False
        Me.dgSalidasPro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgSalidasPro.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id_Output, Me.TipoSalida, Me.DataGridViewTextBoxColumn2, Me.FechaCreacion, Me.Estado, Me.Comentario, Me.usuariocreate})
        Me.dgSalidasPro.Location = New System.Drawing.Point(15, 104)
        Me.dgSalidasPro.Margin = New System.Windows.Forms.Padding(2)
        Me.dgSalidasPro.MultiSelect = False
        Me.dgSalidasPro.Name = "dgSalidasPro"
        Me.dgSalidasPro.ReadOnly = True
        Me.dgSalidasPro.RowHeadersVisible = False
        Me.dgSalidasPro.RowTemplate.Height = 24
        Me.dgSalidasPro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgSalidasPro.Size = New System.Drawing.Size(1071, 448)
        Me.dgSalidasPro.TabIndex = 11
        '
        'Id_Output
        '
        Me.Id_Output.DataPropertyName = "ID_Output"
        Me.Id_Output.HeaderText = "Correlativo"
        Me.Id_Output.Name = "Id_Output"
        Me.Id_Output.ReadOnly = True
        Me.Id_Output.Width = 110
        '
        'TipoSalida
        '
        Me.TipoSalida.DataPropertyName = "Name_Outlet"
        Me.TipoSalida.HeaderText = "Tipo Salida"
        Me.TipoSalida.Name = "TipoSalida"
        Me.TipoSalida.ReadOnly = True
        Me.TipoSalida.Width = 200
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Bodega"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Bodega"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 220
        '
        'FechaCreacion
        '
        Me.FechaCreacion.DataPropertyName = "Date_Create"
        Me.FechaCreacion.HeaderText = "Fecha Creación"
        Me.FechaCreacion.Name = "FechaCreacion"
        Me.FechaCreacion.ReadOnly = True
        Me.FechaCreacion.Width = 150
        '
        'Estado
        '
        Me.Estado.DataPropertyName = "Estado"
        Me.Estado.HeaderText = "Estado"
        Me.Estado.Name = "Estado"
        Me.Estado.ReadOnly = True
        '
        'Comentario
        '
        Me.Comentario.DataPropertyName = "Comentario"
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.Comentario.DefaultCellStyle = DataGridViewCellStyle2
        Me.Comentario.HeaderText = "Comentario"
        Me.Comentario.Name = "Comentario"
        Me.Comentario.ReadOnly = True
        Me.Comentario.Width = 300
        '
        'usuariocreate
        '
        Me.usuariocreate.DataPropertyName = "usercreate"
        Me.usuariocreate.HeaderText = "Usuario Creación"
        Me.usuariocreate.Name = "usuariocreate"
        Me.usuariocreate.ReadOnly = True
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
        Me.cmdCancel.Location = New System.Drawing.Point(666, 573)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(98, 28)
        Me.cmdCancel.TabIndex = 9
        Me.cmdCancel.Text = "Cancelar"
        Me.cmdCancel.UseVisualStyleBackColor = False
        '
        'cmdAprobar
        '
        Me.cmdAprobar.BackColor = System.Drawing.Color.Gainsboro
        Me.cmdAprobar.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdAprobar.FlatAppearance.BorderSize = 0
        Me.cmdAprobar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.cmdAprobar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.cmdAprobar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAprobar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAprobar.Location = New System.Drawing.Point(380, 573)
        Me.cmdAprobar.Name = "cmdAprobar"
        Me.cmdAprobar.Size = New System.Drawing.Size(98, 28)
        Me.cmdAprobar.TabIndex = 8
        Me.cmdAprobar.Text = "Ver Salida"
        Me.cmdAprobar.UseVisualStyleBackColor = False
        '
        'Menu
        '
        Me.Menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarToolStripMenuItem, Me.EliminarToolStripMenuItem})
        Me.Menu.Name = "Menu"
        Me.Menu.Size = New System.Drawing.Size(118, 48)
        '
        'AgregarToolStripMenuItem
        '
        Me.AgregarToolStripMenuItem.Name = "AgregarToolStripMenuItem"
        Me.AgregarToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.AgregarToolStripMenuItem.Text = "Agregar"
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
        '
        'ERP_Inventory_Dialog_InventoryDeparturesAproved
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CadetBlue
        Me.ClientSize = New System.Drawing.Size(1109, 640)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ERP_Inventory_Dialog_InventoryDeparturesAproved"
        Me.Text = "ERP_Inventory_Dialog_InventoryDepartures"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgSalidasPro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Menu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Private WithEvents cmdCancel As Button
    Private WithEvents cmdAprobar As Button
    Friend WithEvents Menu As ContextMenuStrip
    Friend WithEvents AgregarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents dgSalidasPro As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents cb_FiltroSalidas As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtBusquedad As TextBox
    Friend WithEvents Id_Output As DataGridViewTextBoxColumn
    Friend WithEvents TipoSalida As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents FechaCreacion As DataGridViewTextBoxColumn
    Friend WithEvents Estado As DataGridViewTextBoxColumn
    Friend WithEvents Comentario As DataGridViewTextBoxColumn
    Friend WithEvents usuariocreate As DataGridViewTextBoxColumn
    Private WithEvents btnReimprimir As Button
End Class
