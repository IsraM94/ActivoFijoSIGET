<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ERP_Inventory_Dialog_Requisitions
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblNumeroRequisicion = New System.Windows.Forms.Label()
        Me.lblTitRequ = New System.Windows.Forms.Label()
        Me.btnEnviarApro = New System.Windows.Forms.Button()
        Me.lblrazon = New System.Windows.Forms.Label()
        Me.lblrazontext = New System.Windows.Forms.Label()
        Me.cmdModificar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cb_RequisitionType = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cb_departamento = New System.Windows.Forms.ComboBox()
        Me.cb_Employee = New System.Windows.Forms.ComboBox()
        Me.cmdDenegar = New System.Windows.Forms.Button()
        Me.cmdAprobar = New System.Windows.Forms.Button()
        Me.cb_Catalog = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.pnRechazo = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtRechazo = New System.Windows.Forms.TextBox()
        Me.cmdDenegarRequ = New System.Windows.Forms.Button()
        Me.dgvProductsOutput = New System.Windows.Forms.DataGridView()
        Me.Menu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AgregarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.lblValor = New System.Windows.Forms.Label()
        Me.correlativo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CorrelativoN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.product = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Id_Requisitions_Header = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Id_Requisitions_Details = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoUnidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExistenciaPro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.pnRechazo.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgvProductsOutput, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Menu.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.lblNumeroRequisicion)
        Me.GroupBox1.Controls.Add(Me.lblTitRequ)
        Me.GroupBox1.Controls.Add(Me.btnEnviarApro)
        Me.GroupBox1.Controls.Add(Me.lblrazon)
        Me.GroupBox1.Controls.Add(Me.lblrazontext)
        Me.GroupBox1.Controls.Add(Me.cmdModificar)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cb_RequisitionType)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cb_departamento)
        Me.GroupBox1.Controls.Add(Me.cb_Employee)
        Me.GroupBox1.Controls.Add(Me.cmdDenegar)
        Me.GroupBox1.Controls.Add(Me.cmdAprobar)
        Me.GroupBox1.Controls.Add(Me.cb_Catalog)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.cmdCancel)
        Me.GroupBox1.Controls.Add(Me.cmdSave)
        Me.GroupBox1.Controls.Add(Me.lblValor)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1116, 482)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Requisiciones"
        '
        'lblNumeroRequisicion
        '
        Me.lblNumeroRequisicion.AutoSize = True
        Me.lblNumeroRequisicion.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumeroRequisicion.Location = New System.Drawing.Point(179, 100)
        Me.lblNumeroRequisicion.Name = "lblNumeroRequisicion"
        Me.lblNumeroRequisicion.Size = New System.Drawing.Size(0, 21)
        Me.lblNumeroRequisicion.TabIndex = 55
        '
        'lblTitRequ
        '
        Me.lblTitRequ.AutoSize = True
        Me.lblTitRequ.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitRequ.Location = New System.Drawing.Point(2, 100)
        Me.lblTitRequ.Name = "lblTitRequ"
        Me.lblTitRequ.Size = New System.Drawing.Size(176, 21)
        Me.lblTitRequ.TabIndex = 54
        Me.lblTitRequ.Text = "Numero de Requisición:"
        Me.lblTitRequ.Visible = False
        '
        'btnEnviarApro
        '
        Me.btnEnviarApro.BackColor = System.Drawing.Color.Gainsboro
        Me.btnEnviarApro.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.btnEnviarApro.FlatAppearance.BorderSize = 0
        Me.btnEnviarApro.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.btnEnviarApro.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.btnEnviarApro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEnviarApro.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnviarApro.Location = New System.Drawing.Point(873, 448)
        Me.btnEnviarApro.Name = "btnEnviarApro"
        Me.btnEnviarApro.Size = New System.Drawing.Size(159, 28)
        Me.btnEnviarApro.TabIndex = 53
        Me.btnEnviarApro.Text = "Enviar a Aprobación"
        Me.btnEnviarApro.UseVisualStyleBackColor = False
        Me.btnEnviarApro.Visible = False
        '
        'lblrazon
        '
        Me.lblrazon.AutoSize = True
        Me.lblrazon.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblrazon.Location = New System.Drawing.Point(503, 100)
        Me.lblrazon.Name = "lblrazon"
        Me.lblrazon.Size = New System.Drawing.Size(0, 21)
        Me.lblrazon.TabIndex = 52
        '
        'lblrazontext
        '
        Me.lblrazontext.AutoSize = True
        Me.lblrazontext.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblrazontext.Location = New System.Drawing.Point(365, 100)
        Me.lblrazontext.Name = "lblrazontext"
        Me.lblrazontext.Size = New System.Drawing.Size(139, 21)
        Me.lblrazontext.TabIndex = 51
        Me.lblrazontext.Text = "Razón de Rechazo:"
        Me.lblrazontext.Visible = False
        '
        'cmdModificar
        '
        Me.cmdModificar.BackColor = System.Drawing.Color.Gainsboro
        Me.cmdModificar.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdModificar.FlatAppearance.BorderSize = 0
        Me.cmdModificar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.cmdModificar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.cmdModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdModificar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdModificar.Location = New System.Drawing.Point(285, 448)
        Me.cmdModificar.Name = "cmdModificar"
        Me.cmdModificar.Size = New System.Drawing.Size(130, 28)
        Me.cmdModificar.TabIndex = 50
        Me.cmdModificar.Text = "Guardar y Salir"
        Me.cmdModificar.UseVisualStyleBackColor = False
        Me.cmdModificar.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(54, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 21)
        Me.Label3.TabIndex = 49
        Me.Label3.Text = "Departamento:"
        '
        'cb_RequisitionType
        '
        Me.cb_RequisitionType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cb_RequisitionType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cb_RequisitionType.BackColor = System.Drawing.Color.Gainsboro
        Me.cb_RequisitionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_RequisitionType.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cb_RequisitionType.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_RequisitionType.FormattingEnabled = True
        Me.cb_RequisitionType.Location = New System.Drawing.Point(1037, 57)
        Me.cb_RequisitionType.Name = "cb_RequisitionType"
        Me.cb_RequisitionType.Size = New System.Drawing.Size(37, 29)
        Me.cb_RequisitionType.TabIndex = 45
        Me.cb_RequisitionType.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(904, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 21)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "Tipo Requisición:"
        Me.Label1.Visible = False
        '
        'cb_departamento
        '
        Me.cb_departamento.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cb_departamento.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cb_departamento.BackColor = System.Drawing.Color.Gainsboro
        Me.cb_departamento.Enabled = False
        Me.cb_departamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cb_departamento.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_departamento.FormattingEnabled = True
        Me.cb_departamento.ItemHeight = 21
        Me.cb_departamento.Location = New System.Drawing.Point(173, 58)
        Me.cb_departamento.Name = "cb_departamento"
        Me.cb_departamento.Size = New System.Drawing.Size(662, 29)
        Me.cb_departamento.TabIndex = 48
        '
        'cb_Employee
        '
        Me.cb_Employee.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cb_Employee.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cb_Employee.BackColor = System.Drawing.Color.Gainsboro
        Me.cb_Employee.Enabled = False
        Me.cb_Employee.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cb_Employee.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_Employee.FormattingEnabled = True
        Me.cb_Employee.ItemHeight = 21
        Me.cb_Employee.Location = New System.Drawing.Point(1037, 18)
        Me.cb_Employee.Name = "cb_Employee"
        Me.cb_Employee.Size = New System.Drawing.Size(37, 29)
        Me.cb_Employee.TabIndex = 47
        Me.cb_Employee.Visible = False
        '
        'cmdDenegar
        '
        Me.cmdDenegar.BackColor = System.Drawing.Color.Gainsboro
        Me.cmdDenegar.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdDenegar.FlatAppearance.BorderSize = 0
        Me.cmdDenegar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.cmdDenegar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.cmdDenegar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdDenegar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDenegar.Location = New System.Drawing.Point(525, 448)
        Me.cmdDenegar.Name = "cmdDenegar"
        Me.cmdDenegar.Size = New System.Drawing.Size(98, 28)
        Me.cmdDenegar.TabIndex = 46
        Me.cmdDenegar.Text = "Denegar"
        Me.cmdDenegar.UseVisualStyleBackColor = False
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
        Me.cmdAprobar.Location = New System.Drawing.Point(421, 448)
        Me.cmdAprobar.Name = "cmdAprobar"
        Me.cmdAprobar.Size = New System.Drawing.Size(98, 28)
        Me.cmdAprobar.TabIndex = 46
        Me.cmdAprobar.Text = "Aprobar"
        Me.cmdAprobar.UseVisualStyleBackColor = False
        '
        'cb_Catalog
        '
        Me.cb_Catalog.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cb_Catalog.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cb_Catalog.BackColor = System.Drawing.Color.Gainsboro
        Me.cb_Catalog.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cb_Catalog.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_Catalog.FormattingEnabled = True
        Me.cb_Catalog.Location = New System.Drawing.Point(173, 23)
        Me.cb_Catalog.Name = "cb_Catalog"
        Me.cb_Catalog.Size = New System.Drawing.Size(662, 29)
        Me.cb_Catalog.TabIndex = 43
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(102, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 21)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Bodega:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.pnRechazo)
        Me.GroupBox2.Controls.Add(Me.dgvProductsOutput)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 122)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1100, 313)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Productos"
        '
        'pnRechazo
        '
        Me.pnRechazo.BackColor = System.Drawing.Color.CadetBlue
        Me.pnRechazo.Controls.Add(Me.Panel2)
        Me.pnRechazo.Location = New System.Drawing.Point(372, 77)
        Me.pnRechazo.Name = "pnRechazo"
        Me.pnRechazo.Size = New System.Drawing.Size(427, 207)
        Me.pnRechazo.TabIndex = 2
        Me.pnRechazo.Visible = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.txtRechazo)
        Me.Panel2.Controls.Add(Me.cmdDenegarRequ)
        Me.Panel2.Location = New System.Drawing.Point(13, 14)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(396, 178)
        Me.Panel2.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(189, 25)
        Me.Label4.TabIndex = 54
        Me.Label4.Text = "Motivos de Rechazo"
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
        Me.Button1.Location = New System.Drawing.Point(249, 128)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(98, 33)
        Me.Button1.TabIndex = 53
        Me.Button1.Text = "Cancelar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txtRechazo
        '
        Me.txtRechazo.Location = New System.Drawing.Point(20, 39)
        Me.txtRechazo.Multiline = True
        Me.txtRechazo.Name = "txtRechazo"
        Me.txtRechazo.Size = New System.Drawing.Size(364, 83)
        Me.txtRechazo.TabIndex = 52
        '
        'cmdDenegarRequ
        '
        Me.cmdDenegarRequ.BackColor = System.Drawing.Color.Gainsboro
        Me.cmdDenegarRequ.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdDenegarRequ.FlatAppearance.BorderSize = 0
        Me.cmdDenegarRequ.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.cmdDenegarRequ.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.cmdDenegarRequ.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdDenegarRequ.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDenegarRequ.Location = New System.Drawing.Point(30, 128)
        Me.cmdDenegarRequ.Name = "cmdDenegarRequ"
        Me.cmdDenegarRequ.Size = New System.Drawing.Size(182, 33)
        Me.cmdDenegarRequ.TabIndex = 51
        Me.cmdDenegarRequ.Text = "Denegar Requisición"
        Me.cmdDenegarRequ.UseVisualStyleBackColor = False
        '
        'dgvProductsOutput
        '
        Me.dgvProductsOutput.AllowUserToAddRows = False
        Me.dgvProductsOutput.AllowUserToDeleteRows = False
        Me.dgvProductsOutput.AllowUserToResizeColumns = False
        Me.dgvProductsOutput.AllowUserToResizeRows = False
        Me.dgvProductsOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProductsOutput.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.correlativo, Me.CorrelativoN, Me.product, Me.Cantidad, Me.Id_Requisitions_Header, Me.Id_Requisitions_Details, Me.TipoUnidad, Me.ExistenciaPro})
        Me.dgvProductsOutput.ContextMenuStrip = Me.Menu
        Me.dgvProductsOutput.Location = New System.Drawing.Point(5, 31)
        Me.dgvProductsOutput.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvProductsOutput.MultiSelect = False
        Me.dgvProductsOutput.Name = "dgvProductsOutput"
        Me.dgvProductsOutput.ReadOnly = True
        Me.dgvProductsOutput.RowHeadersVisible = False
        Me.dgvProductsOutput.RowTemplate.Height = 24
        Me.dgvProductsOutput.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProductsOutput.Size = New System.Drawing.Size(1084, 279)
        Me.dgvProductsOutput.TabIndex = 1
        '
        'Menu
        '
        Me.Menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarToolStripMenuItem, Me.ModificarToolStripMenuItem, Me.EliminarToolStripMenuItem})
        Me.Menu.Name = "Menu"
        Me.Menu.Size = New System.Drawing.Size(126, 70)
        '
        'AgregarToolStripMenuItem
        '
        Me.AgregarToolStripMenuItem.Name = "AgregarToolStripMenuItem"
        Me.AgregarToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.AgregarToolStripMenuItem.Text = "Agregar"
        Me.AgregarToolStripMenuItem.Visible = False
        '
        'ModificarToolStripMenuItem
        '
        Me.ModificarToolStripMenuItem.Name = "ModificarToolStripMenuItem"
        Me.ModificarToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.ModificarToolStripMenuItem.Text = "Modificar"
        Me.ModificarToolStripMenuItem.Visible = False
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
        Me.EliminarToolStripMenuItem.Visible = False
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
        Me.cmdCancel.Location = New System.Drawing.Point(769, 448)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(98, 28)
        Me.cmdCancel.TabIndex = 9
        Me.cmdCancel.Text = "Cancelar"
        Me.cmdCancel.UseVisualStyleBackColor = False
        '
        'cmdSave
        '
        Me.cmdSave.BackColor = System.Drawing.Color.Gainsboro
        Me.cmdSave.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdSave.FlatAppearance.BorderSize = 0
        Me.cmdSave.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.cmdSave.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.cmdSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdSave.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSave.Location = New System.Drawing.Point(629, 448)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(134, 28)
        Me.cmdSave.TabIndex = 8
        Me.cmdSave.Text = "Guardar y Salir"
        Me.cmdSave.UseVisualStyleBackColor = False
        '
        'lblValor
        '
        Me.lblValor.AutoSize = True
        Me.lblValor.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValor.Location = New System.Drawing.Point(949, 26)
        Me.lblValor.Name = "lblValor"
        Me.lblValor.Size = New System.Drawing.Size(82, 21)
        Me.lblValor.TabIndex = 0
        Me.lblValor.Text = "Empleado:"
        Me.lblValor.Visible = False
        '
        'correlativo
        '
        Me.correlativo.DataPropertyName = "Id_Producto_FK"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.correlativo.DefaultCellStyle = DataGridViewCellStyle1
        Me.correlativo.HeaderText = "Id_Product"
        Me.correlativo.Name = "correlativo"
        Me.correlativo.ReadOnly = True
        Me.correlativo.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.correlativo.Visible = False
        Me.correlativo.Width = 120
        '
        'CorrelativoN
        '
        Me.CorrelativoN.DataPropertyName = "number_purchase"
        Me.CorrelativoN.HeaderText = "Correlativo"
        Me.CorrelativoN.Name = "CorrelativoN"
        Me.CorrelativoN.ReadOnly = True
        Me.CorrelativoN.Width = 120
        '
        'product
        '
        Me.product.DataPropertyName = "Name_Product"
        Me.product.HeaderText = "Descripción"
        Me.product.Name = "product"
        Me.product.ReadOnly = True
        Me.product.Width = 350
        '
        'Cantidad
        '
        Me.Cantidad.DataPropertyName = "RequiredQuantity"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.Cantidad.DefaultCellStyle = DataGridViewCellStyle2
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.ReadOnly = True
        Me.Cantidad.Width = 80
        '
        'Id_Requisitions_Header
        '
        Me.Id_Requisitions_Header.DataPropertyName = "Id_Requisitions_Header"
        Me.Id_Requisitions_Header.HeaderText = "Id_Requisitions_Header"
        Me.Id_Requisitions_Header.Name = "Id_Requisitions_Header"
        Me.Id_Requisitions_Header.ReadOnly = True
        Me.Id_Requisitions_Header.Visible = False
        '
        'Id_Requisitions_Details
        '
        Me.Id_Requisitions_Details.DataPropertyName = "Id_Requisitions_Details"
        Me.Id_Requisitions_Details.HeaderText = "Id_Requisition_Details"
        Me.Id_Requisitions_Details.Name = "Id_Requisitions_Details"
        Me.Id_Requisitions_Details.ReadOnly = True
        Me.Id_Requisitions_Details.Visible = False
        '
        'TipoUnidad
        '
        Me.TipoUnidad.DataPropertyName = "Name_UnitMeasure"
        Me.TipoUnidad.HeaderText = "Tipo de Unidad"
        Me.TipoUnidad.Name = "TipoUnidad"
        Me.TipoUnidad.ReadOnly = True
        Me.TipoUnidad.Width = 200
        '
        'ExistenciaPro
        '
        Me.ExistenciaPro.DataPropertyName = "ExistenciaPro"
        Me.ExistenciaPro.HeaderText = "Existencia Producto"
        Me.ExistenciaPro.Name = "ExistenciaPro"
        Me.ExistenciaPro.ReadOnly = True
        Me.ExistenciaPro.Width = 120
        '
        'ERP_Inventory_Dialog_Requisitions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CadetBlue
        Me.ClientSize = New System.Drawing.Size(1133, 499)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ERP_Inventory_Dialog_Requisitions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ERP_Inventory_Dialog_InventoryDepartures"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.pnRechazo.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.dgvProductsOutput, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Menu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Private WithEvents cb_Catalog As ComboBox
    Private WithEvents Label2 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dgvProductsOutput As DataGridView
    Private WithEvents cmdCancel As Button
    Private WithEvents cmdSave As Button
    Private WithEvents lblValor As Label
    Friend WithEvents Menu As ContextMenuStrip
    Friend WithEvents AgregarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As ToolStripMenuItem
    Private WithEvents cb_RequisitionType As ComboBox
    Private WithEvents Label1 As Label
    Private WithEvents cmdAprobar As Button
    Private WithEvents cmdDenegar As Button
    Private WithEvents cb_Employee As ComboBox
    Private WithEvents Label3 As Label
    Private WithEvents cb_departamento As ComboBox
    Private WithEvents cmdModificar As Button
    Friend WithEvents ModificarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents pnRechazo As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtRechazo As TextBox
    Private WithEvents cmdDenegarRequ As Button
    Private WithEvents lblrazon As Label
    Private WithEvents lblrazontext As Label
    Private WithEvents Button1 As Button
    Friend WithEvents Label4 As Label
    Private WithEvents btnEnviarApro As Button
    Private WithEvents lblNumeroRequisicion As Label
    Private WithEvents lblTitRequ As Label
    Friend WithEvents correlativo As DataGridViewTextBoxColumn
    Friend WithEvents CorrelativoN As DataGridViewTextBoxColumn
    Friend WithEvents product As DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents Id_Requisitions_Header As DataGridViewTextBoxColumn
    Friend WithEvents Id_Requisitions_Details As DataGridViewTextBoxColumn
    Friend WithEvents TipoUnidad As DataGridViewTextBoxColumn
    Friend WithEvents ExistenciaPro As DataGridViewTextBoxColumn
End Class
