<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ERP_CuentasPorPagar_ListaLineasCreditos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GbListaLineasCredito = New System.Windows.Forms.GroupBox()
        Me.DGVListaLineaCredito = New System.Windows.Forms.DataGridView()
        Me.ID_AccountsPayableList = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Description_Credit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DocumentNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Doc_Credit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID_Customer_FK = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Name_Company = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SaldoDeudor = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.GbListaLineasCredito.Text = "Lista de Lineas de Crédito"
        '
        'DGVListaLineaCredito
        '
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGVListaLineaCredito.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGVListaLineaCredito.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGVListaLineaCredito.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID_AccountsPayableList, Me.Description_Credit, Me.DocumentNumber, Me.Doc_Credit, Me.ID_Customer_FK, Me.Name_Company, Me.SaldoDeudor})
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
        'ID_AccountsPayableList
        '
        Me.ID_AccountsPayableList.DataPropertyName = "ID_AccountsPayableList"
        Me.ID_AccountsPayableList.HeaderText = "Correlativo"
        Me.ID_AccountsPayableList.Name = "ID_AccountsPayableList"
        Me.ID_AccountsPayableList.Width = 107
        '
        'Description_Credit
        '
        Me.Description_Credit.DataPropertyName = "Description_Credit"
        Me.Description_Credit.HeaderText = "Descripción Crédito"
        Me.Description_Credit.Name = "Description_Credit"
        Me.Description_Credit.Width = 114
        '
        'DocumentNumber
        '
        Me.DocumentNumber.DataPropertyName = "DocumentNumber"
        Me.DocumentNumber.HeaderText = "No. Documento"
        Me.DocumentNumber.Name = "DocumentNumber"
        Me.DocumentNumber.Width = 179
        '
        'Doc_Credit
        '
        Me.Doc_Credit.DataPropertyName = "Doc_Credit"
        Me.Doc_Credit.HeaderText = "Tipo Documento"
        Me.Doc_Credit.Name = "Doc_Credit"
        Me.Doc_Credit.Width = 160
        '
        'ID_Customer_FK
        '
        Me.ID_Customer_FK.DataPropertyName = "ID_Customer_FK"
        Me.ID_Customer_FK.HeaderText = "ID Customer"
        Me.ID_Customer_FK.Name = "ID_Customer_FK"
        Me.ID_Customer_FK.Visible = False
        Me.ID_Customer_FK.Width = 108
        '
        'Name_Company
        '
        Me.Name_Company.DataPropertyName = "Name_Company"
        Me.Name_Company.HeaderText = "Nombre Compañia"
        Me.Name_Company.Name = "Name_Company"
        Me.Name_Company.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Name_Company.Width = 143
        '
        'SaldoDeudor
        '
        Me.SaldoDeudor.DataPropertyName = "SaldoDeudor"
        Me.SaldoDeudor.HeaderText = "Saldo Actual"
        Me.SaldoDeudor.Name = "SaldoDeudor"
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
        Me.cmdSelect.Text = "Selecionar"
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
        'ERP_CuentasPorPagar_ListaLineasCreditos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(903, 433)
        Me.Controls.Add(Me.GbListaLineasCredito)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ERP_CuentasPorPagar_ListaLineasCreditos"
        Me.Text = "ERP_CuentasPorCobrar_ListaLineasCreditos"
        Me.GbListaLineasCredito.ResumeLayout(False)
        CType(Me.DGVListaLineaCredito, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GbListaLineasCredito As GroupBox
    Private WithEvents cmdSelect As Button
    Private WithEvents cmdCancel As Button
    Friend WithEvents DGVListaLineaCredito As DataGridView
    Friend WithEvents ID_AccountsPayableList As DataGridViewTextBoxColumn
    Friend WithEvents Description_Credit As DataGridViewTextBoxColumn
    Friend WithEvents DocumentNumber As DataGridViewTextBoxColumn
    Friend WithEvents Doc_Credit As DataGridViewTextBoxColumn
    Friend WithEvents ID_Customer_FK As DataGridViewTextBoxColumn
    Friend WithEvents Name_Company As DataGridViewTextBoxColumn
    Friend WithEvents SaldoDeudor As DataGridViewTextBoxColumn
End Class
