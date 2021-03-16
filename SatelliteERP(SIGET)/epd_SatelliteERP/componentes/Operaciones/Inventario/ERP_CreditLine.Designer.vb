<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ERP_CreditLine
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
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.GroupBoxEmployee = New System.Windows.Forms.GroupBox()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblNDocument = New System.Windows.Forms.Label()
        Me.lblEmailCliente = New System.Windows.Forms.Label()
        Me.lblDocument = New System.Windows.Forms.Label()
        Me.lblDepartment = New System.Windows.Forms.Label()
        Me.lblNameClient = New System.Windows.Forms.Label()
        Me.lblCliente = New System.Windows.Forms.Label()
        Me.dgvCreditLine = New System.Windows.Forms.DataGridView()
        Me.Id_LineaDeCredito = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DaysInvoiceExpiration = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID_TypeCreditLine_FK = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TypeCreditLine = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Valor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Saldo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Concepto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateStart = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateEnd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Vigencia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Inactive = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CMSCreditLine = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.NuevaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActualizarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RbAtrasadas = New System.Windows.Forms.RadioButton()
        Me.RbInactivas = New System.Windows.Forms.RadioButton()
        Me.RbActivas = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmdSelecionar = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBoxEmployee.SuspendLayout()
        CType(Me.dgvCreditLine, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CMSCreditLine.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
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
        Me.cmdCancel.Location = New System.Drawing.Point(663, 450)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(98, 28)
        Me.cmdCancel.TabIndex = 4
        Me.cmdCancel.Text = "Cancelar"
        Me.cmdCancel.UseVisualStyleBackColor = False
        '
        'GroupBoxEmployee
        '
        Me.GroupBoxEmployee.Controls.Add(Me.lblTelefono)
        Me.GroupBoxEmployee.Controls.Add(Me.lblEmail)
        Me.GroupBoxEmployee.Controls.Add(Me.lblNDocument)
        Me.GroupBoxEmployee.Controls.Add(Me.lblEmailCliente)
        Me.GroupBoxEmployee.Controls.Add(Me.lblDocument)
        Me.GroupBoxEmployee.Controls.Add(Me.lblDepartment)
        Me.GroupBoxEmployee.Controls.Add(Me.lblNameClient)
        Me.GroupBoxEmployee.Controls.Add(Me.lblCliente)
        Me.GroupBoxEmployee.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxEmployee.Location = New System.Drawing.Point(20, 32)
        Me.GroupBoxEmployee.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBoxEmployee.Name = "GroupBoxEmployee"
        Me.GroupBoxEmployee.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBoxEmployee.Size = New System.Drawing.Size(741, 104)
        Me.GroupBoxEmployee.TabIndex = 0
        Me.GroupBoxEmployee.TabStop = False
        Me.GroupBoxEmployee.Text = "Datos Cliente"
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Font = New System.Drawing.Font("Segoe UI", 12.25!)
        Me.lblTelefono.Location = New System.Drawing.Point(471, 74)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(52, 23)
        Me.lblTelefono.TabIndex = 0
        Me.lblTelefono.Text = "None"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Segoe UI", 12.25!)
        Me.lblEmail.Location = New System.Drawing.Point(471, 33)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(52, 23)
        Me.lblEmail.TabIndex = 0
        Me.lblEmail.Text = "None"
        '
        'lblNDocument
        '
        Me.lblNDocument.AutoSize = True
        Me.lblNDocument.Font = New System.Drawing.Font("Segoe UI", 12.25!)
        Me.lblNDocument.Location = New System.Drawing.Point(147, 72)
        Me.lblNDocument.Name = "lblNDocument"
        Me.lblNDocument.Size = New System.Drawing.Size(52, 23)
        Me.lblNDocument.TabIndex = 0
        Me.lblNDocument.Text = "None"
        '
        'lblEmailCliente
        '
        Me.lblEmailCliente.AutoSize = True
        Me.lblEmailCliente.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.lblEmailCliente.Location = New System.Drawing.Point(402, 33)
        Me.lblEmailCliente.Name = "lblEmailCliente"
        Me.lblEmailCliente.Size = New System.Drawing.Size(72, 25)
        Me.lblEmailCliente.TabIndex = 0
        Me.lblEmailCliente.Text = "Email : "
        '
        'lblDocument
        '
        Me.lblDocument.AutoSize = True
        Me.lblDocument.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.lblDocument.Location = New System.Drawing.Point(5, 71)
        Me.lblDocument.Name = "lblDocument"
        Me.lblDocument.Size = New System.Drawing.Size(150, 25)
        Me.lblDocument.TabIndex = 0
        Me.lblDocument.Text = "N° Documento : "
        '
        'lblDepartment
        '
        Me.lblDepartment.AutoSize = True
        Me.lblDepartment.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.lblDepartment.Location = New System.Drawing.Point(379, 72)
        Me.lblDepartment.Name = "lblDepartment"
        Me.lblDepartment.Size = New System.Drawing.Size(95, 25)
        Me.lblDepartment.TabIndex = 0
        Me.lblDepartment.Text = "Teléfono :"
        '
        'lblNameClient
        '
        Me.lblNameClient.AutoSize = True
        Me.lblNameClient.Font = New System.Drawing.Font("Segoe UI", 12.25!)
        Me.lblNameClient.Location = New System.Drawing.Point(147, 36)
        Me.lblNameClient.Name = "lblNameClient"
        Me.lblNameClient.Size = New System.Drawing.Size(52, 23)
        Me.lblNameClient.TabIndex = 0
        Me.lblNameClient.Text = "None"
        '
        'lblCliente
        '
        Me.lblCliente.AutoSize = True
        Me.lblCliente.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCliente.Location = New System.Drawing.Point(70, 34)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(80, 25)
        Me.lblCliente.TabIndex = 0
        Me.lblCliente.Text = "Cliente :"
        '
        'dgvCreditLine
        '
        Me.dgvCreditLine.AllowUserToAddRows = False
        Me.dgvCreditLine.AllowUserToDeleteRows = False
        Me.dgvCreditLine.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvCreditLine.ColumnHeadersHeight = 35
        Me.dgvCreditLine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvCreditLine.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id_LineaDeCredito, Me.DaysInvoiceExpiration, Me.ID_TypeCreditLine_FK, Me.TypeCreditLine, Me.Valor, Me.Saldo, Me.Concepto, Me.DateStart, Me.DateEnd, Me.Vigencia, Me.Inactive})
        Me.dgvCreditLine.ContextMenuStrip = Me.CMSCreditLine
        Me.dgvCreditLine.Location = New System.Drawing.Point(20, 212)
        Me.dgvCreditLine.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvCreditLine.MultiSelect = False
        Me.dgvCreditLine.Name = "dgvCreditLine"
        Me.dgvCreditLine.ReadOnly = True
        Me.dgvCreditLine.RowTemplate.Height = 24
        Me.dgvCreditLine.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCreditLine.Size = New System.Drawing.Size(741, 233)
        Me.dgvCreditLine.TabIndex = 0
        '
        'Id_LineaDeCredito
        '
        Me.Id_LineaDeCredito.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Id_LineaDeCredito.DataPropertyName = "Id_LineaDeCredito"
        Me.Id_LineaDeCredito.HeaderText = "Correlativo"
        Me.Id_LineaDeCredito.Name = "Id_LineaDeCredito"
        Me.Id_LineaDeCredito.ReadOnly = True
        Me.Id_LineaDeCredito.Width = 136
        '
        'DaysInvoiceExpiration
        '
        Me.DaysInvoiceExpiration.DataPropertyName = "DaysInvoiceExpiration"
        Me.DaysInvoiceExpiration.HeaderText = "DaysInvoiceExpiration"
        Me.DaysInvoiceExpiration.Name = "DaysInvoiceExpiration"
        Me.DaysInvoiceExpiration.ReadOnly = True
        Me.DaysInvoiceExpiration.Visible = False
        Me.DaysInvoiceExpiration.Width = 137
        '
        'ID_TypeCreditLine_FK
        '
        Me.ID_TypeCreditLine_FK.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.ID_TypeCreditLine_FK.DataPropertyName = "ID_TypeCreditLine_FK"
        Me.ID_TypeCreditLine_FK.HeaderText = "ID_TypeCreditLine_FK"
        Me.ID_TypeCreditLine_FK.Name = "ID_TypeCreditLine_FK"
        Me.ID_TypeCreditLine_FK.ReadOnly = True
        Me.ID_TypeCreditLine_FK.Visible = False
        Me.ID_TypeCreditLine_FK.Width = 228
        '
        'TypeCreditLine
        '
        Me.TypeCreditLine.DataPropertyName = "TypeCreditLine"
        Me.TypeCreditLine.HeaderText = "Tipo de Línea de Crédito"
        Me.TypeCreditLine.Name = "TypeCreditLine"
        Me.TypeCreditLine.ReadOnly = True
        Me.TypeCreditLine.Width = 254
        '
        'Valor
        '
        Me.Valor.DataPropertyName = "Valor"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "C2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.Valor.DefaultCellStyle = DataGridViewCellStyle1
        Me.Valor.HeaderText = "Valor"
        Me.Valor.Name = "Valor"
        Me.Valor.ReadOnly = True
        Me.Valor.Width = 84
        '
        'Saldo
        '
        Me.Saldo.DataPropertyName = "Saldo"
        Me.Saldo.HeaderText = "Saldo"
        Me.Saldo.Name = "Saldo"
        Me.Saldo.ReadOnly = True
        Me.Saldo.Width = 87
        '
        'Concepto
        '
        Me.Concepto.DataPropertyName = "Concepto"
        Me.Concepto.HeaderText = "Concepto"
        Me.Concepto.Name = "Concepto"
        Me.Concepto.ReadOnly = True
        Me.Concepto.Width = 123
        '
        'DateStart
        '
        Me.DateStart.DataPropertyName = "DateStart"
        Me.DateStart.HeaderText = "Fecha de Inicio"
        Me.DateStart.Name = "DateStart"
        Me.DateStart.ReadOnly = True
        Me.DateStart.Width = 168
        '
        'DateEnd
        '
        Me.DateEnd.DataPropertyName = "DateEnd"
        Me.DateEnd.HeaderText = "Fecha Fin"
        Me.DateEnd.Name = "DateEnd"
        Me.DateEnd.ReadOnly = True
        Me.DateEnd.Width = 119
        '
        'Vigencia
        '
        Me.Vigencia.DataPropertyName = "Vigencia"
        Me.Vigencia.HeaderText = "Vigencia"
        Me.Vigencia.Name = "Vigencia"
        Me.Vigencia.ReadOnly = True
        Me.Vigencia.Width = 113
        '
        'Inactive
        '
        Me.Inactive.DataPropertyName = "Inactive"
        Me.Inactive.HeaderText = "Inactive"
        Me.Inactive.Name = "Inactive"
        Me.Inactive.ReadOnly = True
        Me.Inactive.Visible = False
        Me.Inactive.Width = 70
        '
        'CMSCreditLine
        '
        Me.CMSCreditLine.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevaToolStripMenuItem, Me.ActualizarToolStripMenuItem, Me.EliminarToolStripMenuItem})
        Me.CMSCreditLine.Name = "CMSCreditLine"
        Me.CMSCreditLine.Size = New System.Drawing.Size(126, 70)
        '
        'NuevaToolStripMenuItem
        '
        Me.NuevaToolStripMenuItem.Name = "NuevaToolStripMenuItem"
        Me.NuevaToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.NuevaToolStripMenuItem.Text = "Nueva"
        '
        'ActualizarToolStripMenuItem
        '
        Me.ActualizarToolStripMenuItem.Name = "ActualizarToolStripMenuItem"
        Me.ActualizarToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.ActualizarToolStripMenuItem.Text = "Modificar"
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
        '
        'RbAtrasadas
        '
        Me.RbAtrasadas.AutoSize = True
        Me.RbAtrasadas.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbAtrasadas.Location = New System.Drawing.Point(281, 33)
        Me.RbAtrasadas.Margin = New System.Windows.Forms.Padding(2)
        Me.RbAtrasadas.Name = "RbAtrasadas"
        Me.RbAtrasadas.Size = New System.Drawing.Size(112, 29)
        Me.RbAtrasadas.TabIndex = 3
        Me.RbAtrasadas.TabStop = True
        Me.RbAtrasadas.Text = "Atrasadas"
        Me.RbAtrasadas.UseVisualStyleBackColor = True
        '
        'RbInactivas
        '
        Me.RbInactivas.AutoSize = True
        Me.RbInactivas.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbInactivas.Location = New System.Drawing.Point(151, 33)
        Me.RbInactivas.Margin = New System.Windows.Forms.Padding(2)
        Me.RbInactivas.Name = "RbInactivas"
        Me.RbInactivas.Size = New System.Drawing.Size(103, 29)
        Me.RbInactivas.TabIndex = 2
        Me.RbInactivas.TabStop = True
        Me.RbInactivas.Text = "Inactivas"
        Me.RbInactivas.UseVisualStyleBackColor = True
        '
        'RbActivas
        '
        Me.RbActivas.AutoSize = True
        Me.RbActivas.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbActivas.Location = New System.Drawing.Point(26, 33)
        Me.RbActivas.Margin = New System.Windows.Forms.Padding(2)
        Me.RbActivas.Name = "RbActivas"
        Me.RbActivas.Size = New System.Drawing.Size(89, 29)
        Me.RbActivas.TabIndex = 1
        Me.RbActivas.TabStop = True
        Me.RbActivas.Text = "Activas"
        Me.RbActivas.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.cmdSelecionar)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.dgvCreditLine)
        Me.GroupBox1.Controls.Add(Me.GroupBoxEmployee)
        Me.GroupBox1.Controls.Add(Me.cmdCancel)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 11)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(778, 489)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Configuración Línea de Crédito"
        '
        'cmdSelecionar
        '
        Me.cmdSelecionar.BackColor = System.Drawing.Color.Gainsboro
        Me.cmdSelecionar.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdSelecionar.FlatAppearance.BorderSize = 0
        Me.cmdSelecionar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.cmdSelecionar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.cmdSelecionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdSelecionar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSelecionar.Location = New System.Drawing.Point(559, 450)
        Me.cmdSelecionar.Name = "cmdSelecionar"
        Me.cmdSelecionar.Size = New System.Drawing.Size(98, 28)
        Me.cmdSelecionar.TabIndex = 5
        Me.cmdSelecionar.Text = "Seleccionar"
        Me.cmdSelecionar.UseVisualStyleBackColor = False
        Me.cmdSelecionar.Visible = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.RbAtrasadas)
        Me.GroupBox3.Controls.Add(Me.RbInactivas)
        Me.GroupBox3.Controls.Add(Me.RbActivas)
        Me.GroupBox3.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(20, 140)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Size = New System.Drawing.Size(408, 68)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Líneas de Crédito"
        '
        'ERP_CreditLine
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(802, 512)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "ERP_CreditLine"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ERP_CreditLine"
        Me.GroupBoxEmployee.ResumeLayout(False)
        Me.GroupBoxEmployee.PerformLayout()
        CType(Me.dgvCreditLine, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CMSCreditLine.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents cmdCancel As Button
    Friend WithEvents GroupBoxEmployee As GroupBox
    Private WithEvents lblTelefono As Label
    Private WithEvents lblEmail As Label
    Private WithEvents lblNDocument As Label
    Private WithEvents lblEmailCliente As Label
    Private WithEvents lblDocument As Label
    Private WithEvents lblDepartment As Label
    Private WithEvents lblNameClient As Label
    Private WithEvents lblCliente As Label
    Friend WithEvents dgvCreditLine As DataGridView
    Friend WithEvents RbAtrasadas As RadioButton
    Friend WithEvents RbInactivas As RadioButton
    Friend WithEvents RbActivas As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents CMSCreditLine As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents NuevaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ActualizarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents cmdSelecionar As Button
    Friend WithEvents Id_LineaDeCredito As DataGridViewTextBoxColumn
    Friend WithEvents DaysInvoiceExpiration As DataGridViewTextBoxColumn
    Friend WithEvents ID_TypeCreditLine_FK As DataGridViewTextBoxColumn
    Friend WithEvents TypeCreditLine As DataGridViewTextBoxColumn
    Friend WithEvents Valor As DataGridViewTextBoxColumn
    Friend WithEvents Saldo As DataGridViewTextBoxColumn
    Friend WithEvents Concepto As DataGridViewTextBoxColumn
    Friend WithEvents DateStart As DataGridViewTextBoxColumn
    Friend WithEvents DateEnd As DataGridViewTextBoxColumn
    Friend WithEvents Vigencia As DataGridViewTextBoxColumn
    Friend WithEvents Inactive As DataGridViewTextBoxColumn
End Class
