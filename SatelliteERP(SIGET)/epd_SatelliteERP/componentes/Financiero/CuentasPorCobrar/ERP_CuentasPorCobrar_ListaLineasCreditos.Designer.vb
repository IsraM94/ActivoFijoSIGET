<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ERP_CuentasPorCobrar_ListaLineasCreditos
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GbListaLineasCredito = New System.Windows.Forms.GroupBox()
        Me.DGVListaLineaCredito = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn25 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Email_Contact = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Saldo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmdSelect = New System.Windows.Forms.Button()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.GbListaLineasCredito.SuspendLayout()
        CType(Me.DGVListaLineaCredito, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GbListaLineasCredito
        '
        Me.GbListaLineasCredito.BackColor = System.Drawing.SystemColors.Control
        Me.GbListaLineasCredito.Controls.Add(Me.DGVListaLineaCredito)
        Me.GbListaLineasCredito.Controls.Add(Me.cmdSelect)
        Me.GbListaLineasCredito.Controls.Add(Me.cmdCancel)
        Me.GbListaLineasCredito.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GbListaLineasCredito.Location = New System.Drawing.Point(12, 12)
        Me.GbListaLineasCredito.Name = "GbListaLineasCredito"
        Me.GbListaLineasCredito.Size = New System.Drawing.Size(880, 406)
        Me.GbListaLineasCredito.TabIndex = 45
        Me.GbListaLineasCredito.TabStop = False
        Me.GbListaLineasCredito.Text = "Lista de Líneas de Crédito"
        '
        'DGVListaLineaCredito
        '
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGVListaLineaCredito.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGVListaLineaCredito.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGVListaLineaCredito.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn22, Me.DataGridViewTextBoxColumn23, Me.DataGridViewTextBoxColumn24, Me.DataGridViewTextBoxColumn25, Me.Email_Contact, Me.Saldo})
        Me.DGVListaLineaCredito.EnableHeadersVisualStyles = False
        Me.DGVListaLineaCredito.Location = New System.Drawing.Point(6, 32)
        Me.DGVListaLineaCredito.Name = "DGVListaLineaCredito"
        Me.DGVListaLineaCredito.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DGVListaLineaCredito.RowHeadersVisible = False
        Me.DGVListaLineaCredito.ShowCellErrors = False
        Me.DGVListaLineaCredito.ShowCellToolTips = False
        Me.DGVListaLineaCredito.ShowEditingIcon = False
        Me.DGVListaLineaCredito.ShowRowErrors = False
        Me.DGVListaLineaCredito.Size = New System.Drawing.Size(862, 307)
        Me.DGVListaLineaCredito.TabIndex = 9
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "ID_AccountsList"
        Me.DataGridViewTextBoxColumn21.HeaderText = "Correlativo"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        Me.DataGridViewTextBoxColumn21.Width = 107
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "Description_Credit"
        Me.DataGridViewTextBoxColumn22.HeaderText = "Descripción Crédito"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        Me.DataGridViewTextBoxColumn22.Width = 200
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "DocumentNumber"
        Me.DataGridViewTextBoxColumn23.HeaderText = "No. Documento"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        Me.DataGridViewTextBoxColumn23.Width = 179
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.DataPropertyName = "Description"
        Me.DataGridViewTextBoxColumn24.HeaderText = "Tipo Documento"
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        Me.DataGridViewTextBoxColumn24.Width = 160
        '
        'DataGridViewTextBoxColumn25
        '
        Me.DataGridViewTextBoxColumn25.DataPropertyName = "TypeCreditLine"
        Me.DataGridViewTextBoxColumn25.HeaderText = "Tipo Línea"
        Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
        Me.DataGridViewTextBoxColumn25.Width = 108
        '
        'Email_Contact
        '
        Me.Email_Contact.DataPropertyName = "Concepto"
        Me.Email_Contact.HeaderText = "Concepto"
        Me.Email_Contact.Name = "Email_Contact"
        Me.Email_Contact.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Email_Contact.Width = 143
        '
        'Saldo
        '
        Me.Saldo.DataPropertyName = "SaldoDeudor"
        Me.Saldo.HeaderText = "Saldo Actual"
        Me.Saldo.Name = "Saldo"
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
        Me.cmdSelect.Location = New System.Drawing.Point(560, 354)
        Me.cmdSelect.Name = "cmdSelect"
        Me.cmdSelect.Size = New System.Drawing.Size(153, 37)
        Me.cmdSelect.TabIndex = 7
        Me.cmdSelect.Text = "Seleccionar"
        Me.cmdSelect.UseVisualStyleBackColor = False
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
        Me.cmdCancel.Location = New System.Drawing.Point(719, 354)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(153, 37)
        Me.cmdCancel.TabIndex = 8
        Me.cmdCancel.Text = "Salir"
        Me.cmdCancel.UseVisualStyleBackColor = False
        '
        'ERP_CuentasPorCobrar_ListaLineasCreditos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(903, 433)
        Me.Controls.Add(Me.GbListaLineasCredito)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ERP_CuentasPorCobrar_ListaLineasCreditos"
        Me.Text = "ERP_CuentasPorCobrar_ListaLineasCreditos"
        Me.GbListaLineasCredito.ResumeLayout(False)
        CType(Me.DGVListaLineaCredito, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GbListaLineasCredito As GroupBox
    Private WithEvents cmdSelect As Button
    Private WithEvents cmdCancel As Button
    Friend WithEvents DGVListaLineaCredito As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn21 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn25 As DataGridViewTextBoxColumn
    Friend WithEvents Email_Contact As DataGridViewTextBoxColumn
    Friend WithEvents Saldo As DataGridViewTextBoxColumn
End Class
