<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLegacy
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
        Me.dgvProducto = New System.Windows.Forms.DataGridView()
        Me.ID_FixedAssets = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Name_FiexdAssets = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Number_Purchase = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Date_Acquisition = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Amount_Acquired = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtCodBar = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmdDiscount = New System.Windows.Forms.Button()
        Me.cbxResponsable = New System.Windows.Forms.ComboBox()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.btnPrintCodeBar = New System.Windows.Forms.Button()
        Me.lblDepartment = New System.Windows.Forms.Label()
        Me.chkConsulta = New System.Windows.Forms.CheckBox()
        CType(Me.dgvProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvProducto
        '
        Me.dgvProducto.AllowUserToAddRows = False
        Me.dgvProducto.ColumnHeadersHeight = 26
        Me.dgvProducto.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID_FixedAssets, Me.Name_FiexdAssets, Me.Number_Purchase, Me.Date_Acquisition, Me.Amount_Acquired})
        Me.dgvProducto.Location = New System.Drawing.Point(24, 261)
        Me.dgvProducto.Name = "dgvProducto"
        Me.dgvProducto.ReadOnly = True
        Me.dgvProducto.RowHeadersWidth = 45
        Me.dgvProducto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProducto.Size = New System.Drawing.Size(694, 160)
        Me.dgvProducto.TabIndex = 7
        '
        'ID_FixedAssets
        '
        Me.ID_FixedAssets.DataPropertyName = "ID_FixedAssets"
        Me.ID_FixedAssets.FillWeight = 76.80492!
        Me.ID_FixedAssets.HeaderText = "ID"
        Me.ID_FixedAssets.Name = "ID_FixedAssets"
        Me.ID_FixedAssets.ReadOnly = True
        '
        'Name_FiexdAssets
        '
        Me.Name_FiexdAssets.DataPropertyName = "Name_FiexdAssets"
        Me.Name_FiexdAssets.FillWeight = 163.0311!
        Me.Name_FiexdAssets.HeaderText = "Nombre Bien"
        Me.Name_FiexdAssets.Name = "Name_FiexdAssets"
        Me.Name_FiexdAssets.ReadOnly = True
        Me.Name_FiexdAssets.Width = 212
        '
        'Number_Purchase
        '
        Me.Number_Purchase.DataPropertyName = "Number_Purchase"
        Me.Number_Purchase.FillWeight = 109.4714!
        Me.Number_Purchase.HeaderText = "Codigo Barra"
        Me.Number_Purchase.Name = "Number_Purchase"
        Me.Number_Purchase.ReadOnly = True
        Me.Number_Purchase.Width = 143
        '
        'Date_Acquisition
        '
        Me.Date_Acquisition.DataPropertyName = "Date_Acquisition"
        Me.Date_Acquisition.FillWeight = 72.67368!
        Me.Date_Acquisition.HeaderText = "F. Aquisicion"
        Me.Date_Acquisition.Name = "Date_Acquisition"
        Me.Date_Acquisition.ReadOnly = True
        Me.Date_Acquisition.Width = 94
        '
        'Amount_Acquired
        '
        Me.Amount_Acquired.DataPropertyName = "Amount_Acquired"
        Me.Amount_Acquired.FillWeight = 78.0189!
        Me.Amount_Acquired.HeaderText = "Monto"
        Me.Amount_Acquired.Name = "Amount_Acquired"
        Me.Amount_Acquired.ReadOnly = True
        Me.Amount_Acquired.Width = 102
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.chkConsulta)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.dgvProducto)
        Me.GroupBox1.Controls.Add(Me.btnAdd)
        Me.GroupBox1.Controls.Add(Me.txtCodBar)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cmdDiscount)
        Me.GroupBox1.Controls.Add(Me.cbxResponsable)
        Me.GroupBox1.Controls.Add(Me.cmdCancel)
        Me.GroupBox1.Controls.Add(Me.btnPrintCodeBar)
        Me.GroupBox1.Controls.Add(Me.lblDepartment)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(724, 460)
        Me.GroupBox1.TabIndex = 37
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Carga de Inventario Legacy"
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
        Me.Button1.Location = New System.Drawing.Point(400, 427)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(148, 29)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Reporte Legacy"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.Gainsboro
        Me.btnAdd.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.btnAdd.FlatAppearance.BorderSize = 0
        Me.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(403, 131)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(98, 29)
        Me.btnAdd.TabIndex = 3
        Me.btnAdd.Text = "Agregar"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'txtCodBar
        '
        Me.txtCodBar.BackColor = System.Drawing.Color.Gainsboro
        Me.txtCodBar.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCodBar.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodBar.Location = New System.Drawing.Point(40, 134)
        Me.txtCodBar.MaxLength = 50
        Me.txtCodBar.Name = "txtCodBar"
        Me.txtCodBar.Size = New System.Drawing.Size(357, 26)
        Me.txtCodBar.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.Label3.Location = New System.Drawing.Point(35, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(197, 25)
        Me.Label3.TabIndex = 49
        Me.Label3.Text = "Código Barra(Legacy):"
        '
        'cmdDiscount
        '
        Me.cmdDiscount.BackColor = System.Drawing.Color.Gainsboro
        Me.cmdDiscount.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdDiscount.FlatAppearance.BorderSize = 0
        Me.cmdDiscount.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.cmdDiscount.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.cmdDiscount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdDiscount.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDiscount.Location = New System.Drawing.Point(246, 427)
        Me.cmdDiscount.Name = "cmdDiscount"
        Me.cmdDiscount.Size = New System.Drawing.Size(148, 29)
        Me.cmdDiscount.TabIndex = 5
        Me.cmdDiscount.Text = "Reporte Activos"
        Me.cmdDiscount.UseVisualStyleBackColor = False
        '
        'cbxResponsable
        '
        Me.cbxResponsable.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbxResponsable.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbxResponsable.BackColor = System.Drawing.Color.Gainsboro
        Me.cbxResponsable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxResponsable.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbxResponsable.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxResponsable.FormattingEnabled = True
        Me.cbxResponsable.Location = New System.Drawing.Point(158, 36)
        Me.cbxResponsable.Name = "cbxResponsable"
        Me.cbxResponsable.Size = New System.Drawing.Size(546, 29)
        Me.cbxResponsable.TabIndex = 1
        '
        'cmdCancel
        '
        Me.cmdCancel.BackColor = System.Drawing.Color.Gainsboro
        Me.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancel.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdCancel.FlatAppearance.BorderSize = 0
        Me.cmdCancel.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.cmdCancel.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.cmdCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCancel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancel.Location = New System.Drawing.Point(558, 427)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(98, 29)
        Me.cmdCancel.TabIndex = 6
        Me.cmdCancel.Text = "Salir"
        Me.cmdCancel.UseVisualStyleBackColor = False
        '
        'btnPrintCodeBar
        '
        Me.btnPrintCodeBar.BackColor = System.Drawing.Color.Gainsboro
        Me.btnPrintCodeBar.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.btnPrintCodeBar.FlatAppearance.BorderSize = 0
        Me.btnPrintCodeBar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.btnPrintCodeBar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.btnPrintCodeBar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrintCodeBar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrintCodeBar.Location = New System.Drawing.Point(64, 427)
        Me.btnPrintCodeBar.Name = "btnPrintCodeBar"
        Me.btnPrintCodeBar.Size = New System.Drawing.Size(176, 29)
        Me.btnPrintCodeBar.TabIndex = 4
        Me.btnPrintCodeBar.Text = "Imprimir Barras"
        Me.btnPrintCodeBar.UseVisualStyleBackColor = False
        '
        'lblDepartment
        '
        Me.lblDepartment.AutoSize = True
        Me.lblDepartment.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.lblDepartment.Location = New System.Drawing.Point(35, 36)
        Me.lblDepartment.Name = "lblDepartment"
        Me.lblDepartment.Size = New System.Drawing.Size(131, 25)
        Me.lblDepartment.TabIndex = 20
        Me.lblDepartment.Text = "Responsable : "
        '
        'chkConsulta
        '
        Me.chkConsulta.AutoSize = True
        Me.chkConsulta.Location = New System.Drawing.Point(40, 74)
        Me.chkConsulta.Name = "chkConsulta"
        Me.chkConsulta.Size = New System.Drawing.Size(224, 29)
        Me.chkConsulta.TabIndex = 50
        Me.chkConsulta.Text = "Consulta Información"
        Me.chkConsulta.UseVisualStyleBackColor = True
        '
        'frmLegacy
        '
        Me.AcceptButton = Me.btnAdd
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.CancelButton = Me.cmdCancel
        Me.ClientSize = New System.Drawing.Size(752, 491)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmLegacy"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmLegacy"
        CType(Me.dgvProducto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents dgvProducto As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Private WithEvents cmdDiscount As Button
    Private WithEvents cbxResponsable As ComboBox
    Private WithEvents cmdCancel As Button
    Private WithEvents btnPrintCodeBar As Button
    Private WithEvents lblDepartment As Label
    Private WithEvents btnAdd As Button
    Private WithEvents txtCodBar As TextBox
    Private WithEvents Label3 As Label
    Friend WithEvents ID_FixedAssets As DataGridViewTextBoxColumn
    Friend WithEvents Name_FiexdAssets As DataGridViewTextBoxColumn
    Friend WithEvents Number_Purchase As DataGridViewTextBoxColumn
    Friend WithEvents Date_Acquisition As DataGridViewTextBoxColumn
    Friend WithEvents Amount_Acquired As DataGridViewTextBoxColumn
    Private WithEvents Button1 As Button
    Friend WithEvents chkConsulta As CheckBox
End Class
