<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Generic_SeleccionarCliente
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmdSelect = New System.Windows.Forms.Button()
        Me.DGW_Custom = New System.Windows.Forms.DataGridView()
        Me.Id_Customer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Name_Company = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tax_Registration_Number = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OfficePhone = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Identity_DocumentNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmdSearch = New System.Windows.Forms.Button()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.lblNoCuentaContable = New System.Windows.Forms.Label()
        Me.txtWhere = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGW_Custom, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.cmdSelect)
        Me.GroupBox1.Controls.Add(Me.DGW_Custom)
        Me.GroupBox1.Controls.Add(Me.cmdSearch)
        Me.GroupBox1.Controls.Add(Me.cmdCancel)
        Me.GroupBox1.Controls.Add(Me.lblNoCuentaContable)
        Me.GroupBox1.Controls.Add(Me.txtWhere)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(742, 409)
        Me.GroupBox1.TabIndex = 34
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Selección de Proveedor"
        '
        'cmdSelect
        '
        Me.cmdSelect.BackColor = System.Drawing.Color.Gainsboro
        Me.cmdSelect.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdSelect.FlatAppearance.BorderSize = 0
        Me.cmdSelect.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.cmdSelect.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.cmdSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdSelect.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSelect.Location = New System.Drawing.Point(534, 374)
        Me.cmdSelect.Name = "cmdSelect"
        Me.cmdSelect.Size = New System.Drawing.Size(98, 29)
        Me.cmdSelect.TabIndex = 23
        Me.cmdSelect.Text = "Seleccionar"
        Me.cmdSelect.UseVisualStyleBackColor = False
        '
        'DGW_Custom
        '
        Me.DGW_Custom.AllowUserToAddRows = False
        Me.DGW_Custom.AllowUserToDeleteRows = False
        Me.DGW_Custom.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGW_Custom.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id_Customer, Me.Name_Company, Me.Tax_Registration_Number, Me.OfficePhone, Me.Identity_DocumentNumber, Me.Column8})
        Me.DGW_Custom.EnableHeadersVisualStyles = False
        Me.DGW_Custom.Location = New System.Drawing.Point(12, 67)
        Me.DGW_Custom.Name = "DGW_Custom"
        Me.DGW_Custom.ReadOnly = True
        Me.DGW_Custom.RowHeadersVisible = False
        Me.DGW_Custom.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGW_Custom.ShowCellErrors = False
        Me.DGW_Custom.ShowCellToolTips = False
        Me.DGW_Custom.ShowEditingIcon = False
        Me.DGW_Custom.ShowRowErrors = False
        Me.DGW_Custom.Size = New System.Drawing.Size(724, 296)
        Me.DGW_Custom.TabIndex = 22
        '
        'Id_Customer
        '
        Me.Id_Customer.DataPropertyName = "Id_Customer"
        Me.Id_Customer.HeaderText = "Correlativo"
        Me.Id_Customer.Name = "Id_Customer"
        Me.Id_Customer.ReadOnly = True
        Me.Id_Customer.Width = 200
        '
        'Name_Company
        '
        Me.Name_Company.DataPropertyName = "Name_Company"
        Me.Name_Company.HeaderText = "Cliente /Razón Social"
        Me.Name_Company.Name = "Name_Company"
        Me.Name_Company.ReadOnly = True
        Me.Name_Company.Width = 250
        '
        'Tax_Registration_Number
        '
        Me.Tax_Registration_Number.DataPropertyName = "Tax_Registration_Number"
        Me.Tax_Registration_Number.HeaderText = "Registro"
        Me.Tax_Registration_Number.Name = "Tax_Registration_Number"
        Me.Tax_Registration_Number.ReadOnly = True
        Me.Tax_Registration_Number.Width = 89
        '
        'OfficePhone
        '
        Me.OfficePhone.DataPropertyName = "OfficePhone"
        Me.OfficePhone.HeaderText = "Teléfono"
        Me.OfficePhone.Name = "OfficePhone"
        Me.OfficePhone.ReadOnly = True
        Me.OfficePhone.Width = 93
        '
        'Identity_DocumentNumber
        '
        Me.Identity_DocumentNumber.DataPropertyName = "Identity_DocumentNumber"
        Me.Identity_DocumentNumber.HeaderText = "Dui"
        Me.Identity_DocumentNumber.Name = "Identity_DocumentNumber"
        Me.Identity_DocumentNumber.ReadOnly = True
        Me.Identity_DocumentNumber.Width = 57
        '
        'Column8
        '
        Me.Column8.HeaderText = "Línea Activa"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Width = 112
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
        Me.cmdSearch.Location = New System.Drawing.Point(702, 34)
        Me.cmdSearch.Name = "cmdSearch"
        Me.cmdSearch.Size = New System.Drawing.Size(34, 27)
        Me.cmdSearch.TabIndex = 21
        Me.cmdSearch.Text = "X"
        Me.cmdSearch.UseVisualStyleBackColor = False
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
        Me.cmdCancel.Location = New System.Drawing.Point(638, 374)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(98, 29)
        Me.cmdCancel.TabIndex = 6
        Me.cmdCancel.Text = "Cancelar"
        Me.cmdCancel.UseVisualStyleBackColor = False
        '
        'lblNoCuentaContable
        '
        Me.lblNoCuentaContable.AutoSize = True
        Me.lblNoCuentaContable.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.lblNoCuentaContable.Location = New System.Drawing.Point(11, 35)
        Me.lblNoCuentaContable.Name = "lblNoCuentaContable"
        Me.lblNoCuentaContable.Size = New System.Drawing.Size(82, 25)
        Me.lblNoCuentaContable.TabIndex = 20
        Me.lblNoCuentaContable.Text = "Buscar : "
        '
        'txtWhere
        '
        Me.txtWhere.BackColor = System.Drawing.Color.Gainsboro
        Me.txtWhere.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtWhere.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWhere.Location = New System.Drawing.Point(98, 35)
        Me.txtWhere.MaxLength = 50
        Me.txtWhere.Name = "txtWhere"
        Me.txtWhere.ShortcutsEnabled = False
        Me.txtWhere.Size = New System.Drawing.Size(598, 26)
        Me.txtWhere.TabIndex = 1
        '
        'Generic_SeleccionarCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CadetBlue
        Me.ClientSize = New System.Drawing.Size(766, 434)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Generic_SeleccionarCliente"
        Me.Text = "Generic_SeleccionarCliente"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DGW_Custom, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Private WithEvents cmdSearch As Button
    Private WithEvents cmdCancel As Button
    Private WithEvents lblNoCuentaContable As Label
    Private WithEvents txtWhere As TextBox
    Friend WithEvents DGW_Custom As DataGridView
    Private WithEvents cmdSelect As Button
    Friend WithEvents Id_Customer As DataGridViewTextBoxColumn
    Friend WithEvents Name_Company As DataGridViewTextBoxColumn
    Friend WithEvents Tax_Registration_Number As DataGridViewTextBoxColumn
    Friend WithEvents OfficePhone As DataGridViewTextBoxColumn
    Friend WithEvents Identity_DocumentNumber As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
End Class
