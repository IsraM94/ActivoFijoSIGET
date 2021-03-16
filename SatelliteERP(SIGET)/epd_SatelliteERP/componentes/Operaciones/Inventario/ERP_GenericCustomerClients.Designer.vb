<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ERP_GenericCustomerClients
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
        Me.Eliminar = New System.Windows.Forms.ToolStripMenuItem()
        Me.CMSdgvCustomer = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Nuevo = New System.Windows.Forms.ToolStripMenuItem()
        Me.Actualizar = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.cmdAplicar = New System.Windows.Forms.Button()
        Me.GbClientes = New System.Windows.Forms.GroupBox()
        Me.cmdClean = New System.Windows.Forms.Button()
        Me.cmdReporte = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cbRubro = New System.Windows.Forms.ComboBox()
        Me.cbCategoria = New System.Windows.Forms.ComboBox()
        Me.cbTipoCliente = New System.Windows.Forms.ComboBox()
        Me.lblRubro = New System.Windows.Forms.Label()
        Me.lblCategoria = New System.Windows.Forms.Label()
        Me.lblTipoCliente = New System.Windows.Forms.Label()
        Me.cmdSearch = New System.Windows.Forms.Button()
        Me.dgvClientes = New System.Windows.Forms.DataGridView()
        Me.Id_Customer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Name_Company = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescriptionCustomer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Name_Municipality = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Address = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContactEmployee = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OfficePhone = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Identity_DocumentNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Id_CompanyCategory_Fk = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Business_Name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Commercial_Name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.First_Name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Last_Name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Email_Contact = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tax_Registration_Number = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tax_Identification_Number = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Is_Exempt = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Is_LegalEntity = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Is_BigContributor = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.CMSdgvCustomer.SuspendLayout()
        Me.GbClientes.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Eliminar
        '
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.Size = New System.Drawing.Size(126, 22)
        Me.Eliminar.Text = "Eliminar"
        '
        'CMSdgvCustomer
        '
        Me.CMSdgvCustomer.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Nuevo, Me.Actualizar, Me.Eliminar})
        Me.CMSdgvCustomer.Name = "CMSdgvProducts"
        Me.CMSdgvCustomer.Size = New System.Drawing.Size(127, 70)
        '
        'Nuevo
        '
        Me.Nuevo.Name = "Nuevo"
        Me.Nuevo.Size = New System.Drawing.Size(126, 22)
        Me.Nuevo.Text = "Nuevo"
        '
        'Actualizar
        '
        Me.Actualizar.Name = "Actualizar"
        Me.Actualizar.Size = New System.Drawing.Size(126, 22)
        Me.Actualizar.Text = "Actualizar"
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
        Me.cmdCancel.Location = New System.Drawing.Point(858, 499)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(193, 37)
        Me.cmdCancel.TabIndex = 8
        Me.cmdCancel.Text = "Salir"
        Me.cmdCancel.UseVisualStyleBackColor = False
        '
        'cmdAplicar
        '
        Me.cmdAplicar.BackColor = System.Drawing.Color.Gainsboro
        Me.cmdAplicar.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdAplicar.FlatAppearance.BorderSize = 0
        Me.cmdAplicar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.cmdAplicar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.cmdAplicar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAplicar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAplicar.Location = New System.Drawing.Point(953, 39)
        Me.cmdAplicar.Name = "cmdAplicar"
        Me.cmdAplicar.Size = New System.Drawing.Size(98, 28)
        Me.cmdAplicar.TabIndex = 4
        Me.cmdAplicar.Text = "Aplicar"
        Me.cmdAplicar.UseVisualStyleBackColor = False
        '
        'GbClientes
        '
        Me.GbClientes.BackColor = System.Drawing.SystemColors.Control
        Me.GbClientes.Controls.Add(Me.cmdClean)
        Me.GbClientes.Controls.Add(Me.cmdReporte)
        Me.GbClientes.Controls.Add(Me.GroupBox2)
        Me.GbClientes.Controls.Add(Me.cmdAplicar)
        Me.GbClientes.Controls.Add(Me.cmdSearch)
        Me.GbClientes.Controls.Add(Me.dgvClientes)
        Me.GbClientes.Controls.Add(Me.cmdCancel)
        Me.GbClientes.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GbClientes.Location = New System.Drawing.Point(12, 12)
        Me.GbClientes.Name = "GbClientes"
        Me.GbClientes.Size = New System.Drawing.Size(1070, 551)
        Me.GbClientes.TabIndex = 41
        Me.GbClientes.TabStop = False
        Me.GbClientes.Text = "Configuración de Clientes"
        '
        'cmdClean
        '
        Me.cmdClean.BackColor = System.Drawing.Color.Gainsboro
        Me.cmdClean.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdClean.FlatAppearance.BorderSize = 0
        Me.cmdClean.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.cmdClean.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.cmdClean.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdClean.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClean.Location = New System.Drawing.Point(953, 73)
        Me.cmdClean.Name = "cmdClean"
        Me.cmdClean.Size = New System.Drawing.Size(98, 28)
        Me.cmdClean.TabIndex = 5
        Me.cmdClean.Text = "Limpiar"
        Me.cmdClean.UseVisualStyleBackColor = False
        '
        'cmdReporte
        '
        Me.cmdReporte.BackColor = System.Drawing.Color.Gainsboro
        Me.cmdReporte.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdReporte.FlatAppearance.BorderSize = 0
        Me.cmdReporte.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.cmdReporte.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.cmdReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdReporte.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdReporte.Location = New System.Drawing.Point(659, 499)
        Me.cmdReporte.Name = "cmdReporte"
        Me.cmdReporte.Size = New System.Drawing.Size(193, 37)
        Me.cmdReporte.TabIndex = 7
        Me.cmdReporte.Text = "Reporte Preview"
        Me.cmdReporte.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cbRubro)
        Me.GroupBox2.Controls.Add(Me.cbCategoria)
        Me.GroupBox2.Controls.Add(Me.cbTipoCliente)
        Me.GroupBox2.Controls.Add(Me.lblRubro)
        Me.GroupBox2.Controls.Add(Me.lblCategoria)
        Me.GroupBox2.Controls.Add(Me.lblTipoCliente)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(21, 28)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(926, 72)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Filtros"
        '
        'cbRubro
        '
        Me.cbRubro.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbRubro.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbRubro.BackColor = System.Drawing.Color.Gainsboro
        Me.cbRubro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbRubro.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbRubro.FormattingEnabled = True
        Me.cbRubro.Location = New System.Drawing.Point(718, 34)
        Me.cbRubro.Name = "cbRubro"
        Me.cbRubro.Size = New System.Drawing.Size(201, 29)
        Me.cbRubro.TabIndex = 3
        '
        'cbCategoria
        '
        Me.cbCategoria.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbCategoria.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbCategoria.BackColor = System.Drawing.Color.Gainsboro
        Me.cbCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbCategoria.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCategoria.FormattingEnabled = True
        Me.cbCategoria.Location = New System.Drawing.Point(438, 34)
        Me.cbCategoria.Name = "cbCategoria"
        Me.cbCategoria.Size = New System.Drawing.Size(201, 29)
        Me.cbCategoria.TabIndex = 2
        '
        'cbTipoCliente
        '
        Me.cbTipoCliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbTipoCliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbTipoCliente.BackColor = System.Drawing.Color.Gainsboro
        Me.cbTipoCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbTipoCliente.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTipoCliente.FormattingEnabled = True
        Me.cbTipoCliente.Location = New System.Drawing.Point(124, 34)
        Me.cbTipoCliente.Name = "cbTipoCliente"
        Me.cbTipoCliente.Size = New System.Drawing.Size(201, 29)
        Me.cbTipoCliente.TabIndex = 1
        '
        'lblRubro
        '
        Me.lblRubro.AutoSize = True
        Me.lblRubro.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.lblRubro.Location = New System.Drawing.Point(645, 35)
        Me.lblRubro.Name = "lblRubro"
        Me.lblRubro.Size = New System.Drawing.Size(67, 25)
        Me.lblRubro.TabIndex = 0
        Me.lblRubro.Text = "Rubro:"
        '
        'lblCategoria
        '
        Me.lblCategoria.AutoSize = True
        Me.lblCategoria.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.lblCategoria.Location = New System.Drawing.Point(334, 34)
        Me.lblCategoria.Name = "lblCategoria"
        Me.lblCategoria.Size = New System.Drawing.Size(98, 25)
        Me.lblCategoria.TabIndex = 0
        Me.lblCategoria.Text = "Categoría:"
        '
        'lblTipoCliente
        '
        Me.lblTipoCliente.AutoSize = True
        Me.lblTipoCliente.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.lblTipoCliente.Location = New System.Drawing.Point(8, 35)
        Me.lblTipoCliente.Name = "lblTipoCliente"
        Me.lblTipoCliente.Size = New System.Drawing.Size(117, 25)
        Me.lblTipoCliente.TabIndex = 0
        Me.lblTipoCliente.Text = "Tipo Cliente:"
        '
        'cmdSearch
        '
        Me.cmdSearch.BackColor = System.Drawing.Color.Gainsboro
        Me.cmdSearch.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdSearch.FlatAppearance.BorderSize = 0
        Me.cmdSearch.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.cmdSearch.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.cmdSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdSearch.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSearch.Location = New System.Drawing.Point(21, 499)
        Me.cmdSearch.Name = "cmdSearch"
        Me.cmdSearch.Size = New System.Drawing.Size(193, 37)
        Me.cmdSearch.TabIndex = 6
        Me.cmdSearch.Text = "Buscar Cliente"
        Me.cmdSearch.UseVisualStyleBackColor = False
        '
        'dgvClientes
        '
        Me.dgvClientes.AllowUserToAddRows = False
        Me.dgvClientes.AllowUserToDeleteRows = False
        Me.dgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvClientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id_Customer, Me.Name_Company, Me.DescriptionCustomer, Me.Name_Municipality, Me.Address, Me.ContactEmployee, Me.OfficePhone, Me.Identity_DocumentNumber, Me.Id_CompanyCategory_Fk, Me.Business_Name, Me.Commercial_Name, Me.First_Name, Me.Last_Name, Me.Email_Contact, Me.Tax_Registration_Number, Me.Tax_Identification_Number, Me.Is_Exempt, Me.Is_LegalEntity, Me.Is_BigContributor})
        Me.dgvClientes.ContextMenuStrip = Me.CMSdgvCustomer
        Me.dgvClientes.Location = New System.Drawing.Point(21, 105)
        Me.dgvClientes.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvClientes.MultiSelect = False
        Me.dgvClientes.Name = "dgvClientes"
        Me.dgvClientes.ReadOnly = True
        Me.dgvClientes.RowTemplate.Height = 24
        Me.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvClientes.Size = New System.Drawing.Size(1030, 389)
        Me.dgvClientes.TabIndex = 0
        '
        'Id_Customer
        '
        Me.Id_Customer.DataPropertyName = "Id_Customer"
        Me.Id_Customer.HeaderText = "Id_Customer"
        Me.Id_Customer.Name = "Id_Customer"
        Me.Id_Customer.ReadOnly = True
        Me.Id_Customer.Width = 149
        '
        'Name_Company
        '
        Me.Name_Company.DataPropertyName = "Name_Company"
        Me.Name_Company.HeaderText = "Name_Company"
        Me.Name_Company.Name = "Name_Company"
        Me.Name_Company.ReadOnly = True
        Me.Name_Company.Width = 182
        '
        'DescriptionCustomer
        '
        Me.DescriptionCustomer.DataPropertyName = "DescriptionCustomer"
        Me.DescriptionCustomer.HeaderText = "DescriptionCustomer"
        Me.DescriptionCustomer.Name = "DescriptionCustomer"
        Me.DescriptionCustomer.ReadOnly = True
        Me.DescriptionCustomer.Width = 225
        '
        'Name_Municipality
        '
        Me.Name_Municipality.DataPropertyName = "Name_Municipality"
        Me.Name_Municipality.HeaderText = "Name_Municipality"
        Me.Name_Municipality.Name = "Name_Municipality"
        Me.Name_Municipality.ReadOnly = True
        Me.Name_Municipality.Width = 207
        '
        'Address
        '
        Me.Address.DataPropertyName = "Address"
        Me.Address.HeaderText = "Address"
        Me.Address.Name = "Address"
        Me.Address.ReadOnly = True
        Me.Address.Width = 108
        '
        'ContactEmployee
        '
        Me.ContactEmployee.DataPropertyName = "ContactEmployee"
        Me.ContactEmployee.HeaderText = "ContactEmployee"
        Me.ContactEmployee.Name = "ContactEmployee"
        Me.ContactEmployee.ReadOnly = True
        Me.ContactEmployee.Width = 192
        '
        'OfficePhone
        '
        Me.OfficePhone.DataPropertyName = "OfficePhone"
        Me.OfficePhone.HeaderText = "OfficePhone"
        Me.OfficePhone.Name = "OfficePhone"
        Me.OfficePhone.ReadOnly = True
        Me.OfficePhone.Width = 146
        '
        'Identity_DocumentNumber
        '
        Me.Identity_DocumentNumber.DataPropertyName = "Identity_DocumentNumber"
        Me.Identity_DocumentNumber.HeaderText = "Identity_DocumentNumber"
        Me.Identity_DocumentNumber.Name = "Identity_DocumentNumber"
        Me.Identity_DocumentNumber.ReadOnly = True
        Me.Identity_DocumentNumber.Width = 281
        '
        'Id_CompanyCategory_Fk
        '
        Me.Id_CompanyCategory_Fk.DataPropertyName = "Id_CompanyCategory_Fk"
        Me.Id_CompanyCategory_Fk.HeaderText = "Id_CompanyCategory_Fk"
        Me.Id_CompanyCategory_Fk.Name = "Id_CompanyCategory_Fk"
        Me.Id_CompanyCategory_Fk.ReadOnly = True
        Me.Id_CompanyCategory_Fk.Width = 259
        '
        'Business_Name
        '
        Me.Business_Name.DataPropertyName = "Business_Name"
        Me.Business_Name.HeaderText = "Business_Name"
        Me.Business_Name.Name = "Business_Name"
        Me.Business_Name.ReadOnly = True
        Me.Business_Name.Width = 172
        '
        'Commercial_Name
        '
        Me.Commercial_Name.DataPropertyName = "Commercial_Name"
        Me.Commercial_Name.HeaderText = "Commercial_Name"
        Me.Commercial_Name.Name = "Commercial_Name"
        Me.Commercial_Name.ReadOnly = True
        Me.Commercial_Name.Width = 202
        '
        'First_Name
        '
        Me.First_Name.DataPropertyName = "First_Name"
        Me.First_Name.HeaderText = "First_Name"
        Me.First_Name.Name = "First_Name"
        Me.First_Name.ReadOnly = True
        Me.First_Name.Width = 135
        '
        'Last_Name
        '
        Me.Last_Name.DataPropertyName = "Last_Name"
        Me.Last_Name.HeaderText = "Last_Name"
        Me.Last_Name.Name = "Last_Name"
        Me.Last_Name.ReadOnly = True
        Me.Last_Name.Width = 132
        '
        'Email_Contact
        '
        Me.Email_Contact.DataPropertyName = "Email_Contact"
        Me.Email_Contact.HeaderText = "Email_Contact"
        Me.Email_Contact.Name = "Email_Contact"
        Me.Email_Contact.ReadOnly = True
        Me.Email_Contact.Width = 161
        '
        'Tax_Registration_Number
        '
        Me.Tax_Registration_Number.DataPropertyName = "Tax_Registration_Number"
        Me.Tax_Registration_Number.HeaderText = "Tax_Registration_Number"
        Me.Tax_Registration_Number.Name = "Tax_Registration_Number"
        Me.Tax_Registration_Number.ReadOnly = True
        Me.Tax_Registration_Number.Width = 265
        '
        'Tax_Identification_Number
        '
        Me.Tax_Identification_Number.DataPropertyName = "Tax_Identification_Number"
        Me.Tax_Identification_Number.HeaderText = "Tax_Identification_Number"
        Me.Tax_Identification_Number.Name = "Tax_Identification_Number"
        Me.Tax_Identification_Number.ReadOnly = True
        Me.Tax_Identification_Number.Width = 276
        '
        'Is_Exempt
        '
        Me.Is_Exempt.DataPropertyName = "Is_Exempt"
        Me.Is_Exempt.FalseValue = "0"
        Me.Is_Exempt.HeaderText = "Is_Exempt"
        Me.Is_Exempt.Name = "Is_Exempt"
        Me.Is_Exempt.ReadOnly = True
        Me.Is_Exempt.TrueValue = "1"
        Me.Is_Exempt.Width = 107
        '
        'Is_LegalEntity
        '
        Me.Is_LegalEntity.DataPropertyName = "Is_LegalEntity"
        Me.Is_LegalEntity.FalseValue = "0"
        Me.Is_LegalEntity.HeaderText = "Is_LegalEntity"
        Me.Is_LegalEntity.Name = "Is_LegalEntity"
        Me.Is_LegalEntity.ReadOnly = True
        Me.Is_LegalEntity.TrueValue = "1"
        Me.Is_LegalEntity.Width = 138
        '
        'Is_BigContributor
        '
        Me.Is_BigContributor.DataPropertyName = "Is_BigContributor"
        Me.Is_BigContributor.FalseValue = "0"
        Me.Is_BigContributor.HeaderText = "Is_BigContributor"
        Me.Is_BigContributor.Name = "Is_BigContributor"
        Me.Is_BigContributor.ReadOnly = True
        Me.Is_BigContributor.TrueValue = "1"
        Me.Is_BigContributor.Width = 176
        '
        'ERP_GenericCustomerClients
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(1094, 576)
        Me.Controls.Add(Me.GbClientes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ERP_GenericCustomerClients"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ERP_GenericCustomerClients"
        Me.CMSdgvCustomer.ResumeLayout(False)
        Me.GbClientes.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Eliminar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CMSdgvCustomer As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents Nuevo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Actualizar As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents cmdCancel As System.Windows.Forms.Button
    Private WithEvents cmdAplicar As System.Windows.Forms.Button
    Friend WithEvents GbClientes As System.Windows.Forms.GroupBox
    Private WithEvents cmdClean As System.Windows.Forms.Button
    Private WithEvents cmdReporte As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Private WithEvents cbRubro As System.Windows.Forms.ComboBox
    Private WithEvents cbCategoria As System.Windows.Forms.ComboBox
    Private WithEvents cbTipoCliente As System.Windows.Forms.ComboBox
    Private WithEvents lblRubro As System.Windows.Forms.Label
    Private WithEvents lblCategoria As System.Windows.Forms.Label
    Private WithEvents lblTipoCliente As System.Windows.Forms.Label
    Private WithEvents cmdSearch As System.Windows.Forms.Button
    Friend WithEvents dgvClientes As System.Windows.Forms.DataGridView
    Friend WithEvents Id_Customer As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Name_Company As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescriptionCustomer As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Name_Municipality As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Address As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ContactEmployee As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OfficePhone As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Identity_DocumentNumber As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Id_CompanyCategory_Fk As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Business_Name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Commercial_Name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents First_Name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Last_Name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Email_Contact As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Tax_Registration_Number As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Tax_Identification_Number As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Is_Exempt As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Is_LegalEntity As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Is_BigContributor As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
