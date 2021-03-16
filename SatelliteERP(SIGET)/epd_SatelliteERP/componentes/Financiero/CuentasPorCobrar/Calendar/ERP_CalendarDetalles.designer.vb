<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ERP_CalendarDetalles
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GbDetallesCPC = New System.Windows.Forms.GroupBox()
        Me.cmdPagar = New System.Windows.Forms.Button()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.dgvClientes = New System.Windows.Forms.DataGridView()
        Me.Tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID_AccountsList = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Id_Customer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Name_Company = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Description_Credit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ammount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PaymentDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID_AccountsDetails = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID_AccountsPayableDetails = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuotaNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GbDetallesCPC.SuspendLayout()
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GbDetallesCPC
        '
        Me.GbDetallesCPC.BackColor = System.Drawing.SystemColors.Control
        Me.GbDetallesCPC.Controls.Add(Me.dgvClientes)
        Me.GbDetallesCPC.Controls.Add(Me.cmdPagar)
        Me.GbDetallesCPC.Controls.Add(Me.lblFecha)
        Me.GbDetallesCPC.Controls.Add(Me.lbl1)
        Me.GbDetallesCPC.Controls.Add(Me.cmdCancel)
        Me.GbDetallesCPC.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GbDetallesCPC.Location = New System.Drawing.Point(12, 12)
        Me.GbDetallesCPC.Name = "GbDetallesCPC"
        Me.GbDetallesCPC.Size = New System.Drawing.Size(851, 474)
        Me.GbDetallesCPC.TabIndex = 42
        Me.GbDetallesCPC.TabStop = False
        Me.GbDetallesCPC.Text = "Cuentas por cobrar"
        '
        'cmdPagar
        '
        Me.cmdPagar.BackColor = System.Drawing.Color.Gainsboro
        Me.cmdPagar.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdPagar.FlatAppearance.BorderSize = 0
        Me.cmdPagar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.cmdPagar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.cmdPagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdPagar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPagar.Location = New System.Drawing.Point(442, 430)
        Me.cmdPagar.Name = "cmdPagar"
        Me.cmdPagar.Size = New System.Drawing.Size(193, 37)
        Me.cmdPagar.TabIndex = 25
        Me.cmdPagar.Text = "Procesar Pago"
        Me.cmdPagar.UseVisualStyleBackColor = False
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.lblFecha.Location = New System.Drawing.Point(127, 39)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(58, 25)
        Me.lblFecha.TabIndex = 24
        Me.lblFecha.Text = "None"
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.lbl1.Location = New System.Drawing.Point(56, 39)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(75, 25)
        Me.lbl1.TabIndex = 23
        Me.lbl1.Text = "Fecha : "
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
        Me.cmdCancel.Location = New System.Drawing.Point(641, 430)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(193, 37)
        Me.cmdCancel.TabIndex = 8
        Me.cmdCancel.Text = "Salir"
        Me.cmdCancel.UseVisualStyleBackColor = False
        '
        'dgvClientes
        '
        Me.dgvClientes.AllowUserToAddRows = False
        Me.dgvClientes.AllowUserToDeleteRows = False
        Me.dgvClientes.AllowUserToResizeColumns = False
        Me.dgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvClientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Tipo, Me.ID_AccountsList, Me.Id_Customer, Me.Name_Company, Me.Description_Credit, Me.Ammount, Me.PaymentDate, Me.ID_AccountsDetails, Me.ID_AccountsPayableDetails, Me.QuotaNumber})
        Me.dgvClientes.Location = New System.Drawing.Point(19, 65)
        Me.dgvClientes.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvClientes.MultiSelect = False
        Me.dgvClientes.Name = "dgvClientes"
        Me.dgvClientes.ReadOnly = True
        Me.dgvClientes.RowTemplate.Height = 24
        Me.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvClientes.Size = New System.Drawing.Size(813, 345)
        Me.dgvClientes.TabIndex = 26
        '
        'Tipo
        '
        Me.Tipo.DataPropertyName = "Tipo"
        Me.Tipo.HeaderText = "Tipo Cuenta"
        Me.Tipo.Name = "Tipo"
        Me.Tipo.ReadOnly = True
        Me.Tipo.Width = 132
        '
        'ID_AccountsList
        '
        Me.ID_AccountsList.DataPropertyName = "ID_AccountsList"
        Me.ID_AccountsList.HeaderText = "ID_AccountsList"
        Me.ID_AccountsList.Name = "ID_AccountsList"
        Me.ID_AccountsList.ReadOnly = True
        Me.ID_AccountsList.Visible = False
        Me.ID_AccountsList.Width = 177
        '
        'Id_Customer
        '
        Me.Id_Customer.DataPropertyName = "Id_Customer"
        Me.Id_Customer.HeaderText = "Id_Customer"
        Me.Id_Customer.Name = "Id_Customer"
        Me.Id_Customer.ReadOnly = True
        Me.Id_Customer.Visible = False
        Me.Id_Customer.Width = 149
        '
        'Name_Company
        '
        Me.Name_Company.DataPropertyName = "Name_Company"
        Me.Name_Company.HeaderText = "Nombre de la Compañia"
        Me.Name_Company.Name = "Name_Company"
        Me.Name_Company.ReadOnly = True
        Me.Name_Company.Width = 149
        '
        'Description_Credit
        '
        Me.Description_Credit.DataPropertyName = "Description_Credit"
        Me.Description_Credit.HeaderText = "Descripción"
        Me.Description_Credit.Name = "Description_Credit"
        Me.Description_Credit.ReadOnly = True
        Me.Description_Credit.Width = 141
        '
        'Ammount
        '
        Me.Ammount.DataPropertyName = "Ammount"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "C2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.Ammount.DefaultCellStyle = DataGridViewCellStyle1
        Me.Ammount.HeaderText = "Monto"
        Me.Ammount.Name = "Ammount"
        Me.Ammount.ReadOnly = True
        Me.Ammount.Width = 98
        '
        'PaymentDate
        '
        Me.PaymentDate.DataPropertyName = "PaymentDate"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.PaymentDate.DefaultCellStyle = DataGridViewCellStyle2
        Me.PaymentDate.HeaderText = "Fecha de Pago"
        Me.PaymentDate.Name = "PaymentDate"
        Me.PaymentDate.ReadOnly = True
        Me.PaymentDate.Width = 150
        '
        'ID_AccountsDetails
        '
        Me.ID_AccountsDetails.DataPropertyName = "ID_AccountsDetails"
        Me.ID_AccountsDetails.HeaderText = "Correlativo Cuenta"
        Me.ID_AccountsDetails.Name = "ID_AccountsDetails"
        Me.ID_AccountsDetails.ReadOnly = True
        Me.ID_AccountsDetails.Width = 186
        '
        'ID_AccountsPayableDetails
        '
        Me.ID_AccountsPayableDetails.DataPropertyName = "ID_AccountsPayableDetails"
        Me.ID_AccountsPayableDetails.HeaderText = "Id Cuenta por pagar"
        Me.ID_AccountsPayableDetails.Name = "ID_AccountsPayableDetails"
        Me.ID_AccountsPayableDetails.ReadOnly = True
        Me.ID_AccountsPayableDetails.Width = 150
        '
        'QuotaNumber
        '
        Me.QuotaNumber.DataPropertyName = "QuotaNumber"
        Me.QuotaNumber.HeaderText = "Número de Cuota"
        Me.QuotaNumber.Name = "QuotaNumber"
        Me.QuotaNumber.ReadOnly = True
        Me.QuotaNumber.Width = 131
        '
        'ERP_CalendarDetalles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CadetBlue
        Me.ClientSize = New System.Drawing.Size(877, 498)
        Me.Controls.Add(Me.GbDetallesCPC)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ERP_CalendarDetalles"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ERP_CalendarDetalles"
        Me.GbDetallesCPC.ResumeLayout(False)
        Me.GbDetallesCPC.PerformLayout()
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GbDetallesCPC As System.Windows.Forms.GroupBox
    Private WithEvents cmdCancel As System.Windows.Forms.Button
    Private WithEvents lblFecha As System.Windows.Forms.Label
    Private WithEvents lbl1 As System.Windows.Forms.Label
    Private WithEvents cmdPagar As Button
    Friend WithEvents dgvClientes As DataGridView
    Friend WithEvents Tipo As DataGridViewTextBoxColumn
    Friend WithEvents ID_AccountsList As DataGridViewTextBoxColumn
    Friend WithEvents Id_Customer As DataGridViewTextBoxColumn
    Friend WithEvents Name_Company As DataGridViewTextBoxColumn
    Friend WithEvents Description_Credit As DataGridViewTextBoxColumn
    Friend WithEvents Ammount As DataGridViewTextBoxColumn
    Friend WithEvents PaymentDate As DataGridViewTextBoxColumn
    Friend WithEvents ID_AccountsDetails As DataGridViewTextBoxColumn
    Friend WithEvents ID_AccountsPayableDetails As DataGridViewTextBoxColumn
    Friend WithEvents QuotaNumber As DataGridViewTextBoxColumn
End Class
