<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Financiero_PartidaConfExterna
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Financiero_PartidaConfExterna))
        Me.IL_Banderas = New System.Windows.Forms.ImageList(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CB_TypeItem = New System.Windows.Forms.ComboBox()
        Me.txtConcept = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.txtPartida_NoPartida = New System.Windows.Forms.TextBox()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.dgvDetails = New System.Windows.Forms.DataGridView()
        Me.Id_ModulesAccountingitemDetall = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Description = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreCuentaContable = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Name_CostCenter = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Debit = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Credit = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.CMSDgvDetails = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Eliminar = New System.Windows.Forms.ToolStripMenuItem()
        Me.label50 = New System.Windows.Forms.Label()
        Me.label49 = New System.Windows.Forms.Label()
        Me.cbListAccount = New System.Windows.Forms.ComboBox()
        Me.cmdAdd = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        CType(Me.dgvDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CMSDgvDetails.SuspendLayout()
        Me.SuspendLayout()
        '
        'IL_Banderas
        '
        Me.IL_Banderas.ImageStream = CType(resources.GetObject("IL_Banderas.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.IL_Banderas.TransparentColor = System.Drawing.Color.Transparent
        Me.IL_Banderas.Images.SetKeyName(0, "Roja-Bandera.png")
        Me.IL_Banderas.Images.SetKeyName(1, "Verde-Bandera.png")
        Me.IL_Banderas.Images.SetKeyName(2, "Amarillo-bandera.png")
        Me.IL_Banderas.Images.SetKeyName(3, "Azul-Bandera.png")
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(72, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 21)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Tipo Partida  : "
        '
        'CB_TypeItem
        '
        Me.CB_TypeItem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CB_TypeItem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CB_TypeItem.BackColor = System.Drawing.Color.Gainsboro
        Me.CB_TypeItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_TypeItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CB_TypeItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_TypeItem.FormattingEnabled = True
        Me.CB_TypeItem.Location = New System.Drawing.Point(186, 90)
        Me.CB_TypeItem.Name = "CB_TypeItem"
        Me.CB_TypeItem.Size = New System.Drawing.Size(477, 29)
        Me.CB_TypeItem.TabIndex = 0
        '
        'txtConcept
        '
        Me.txtConcept.BackColor = System.Drawing.Color.Gainsboro
        Me.txtConcept.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtConcept.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConcept.Location = New System.Drawing.Point(188, 59)
        Me.txtConcept.Name = "txtConcept"
        Me.txtConcept.ReadOnly = True
        Me.txtConcept.Size = New System.Drawing.Size(550, 26)
        Me.txtConcept.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(168, 25)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Concepto General:"
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
        Me.cmdCancel.Location = New System.Drawing.Point(640, 500)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(98, 29)
        Me.cmdCancel.TabIndex = 4
        Me.cmdCancel.Text = "Cancelar"
        Me.cmdCancel.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.CB_TypeItem)
        Me.GroupBox1.Controls.Add(Me.txtConcept)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cmdCancel)
        Me.GroupBox1.Controls.Add(Me.cmdSave)
        Me.GroupBox1.Controls.Add(Me.txtPartida_NoPartida)
        Me.GroupBox1.Controls.Add(Me.FlowLayoutPanel1)
        Me.GroupBox1.Controls.Add(Me.label50)
        Me.GroupBox1.Controls.Add(Me.label49)
        Me.GroupBox1.Controls.Add(Me.cbListAccount)
        Me.GroupBox1.Controls.Add(Me.cmdAdd)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(757, 537)
        Me.GroupBox1.TabIndex = 30
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Partida Contable - Config Sistemas Externos"
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
        Me.cmdSave.Location = New System.Drawing.Point(536, 500)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(98, 29)
        Me.cmdSave.TabIndex = 3
        Me.cmdSave.Text = "Grabar"
        Me.cmdSave.UseVisualStyleBackColor = False
        '
        'txtPartida_NoPartida
        '
        Me.txtPartida_NoPartida.BackColor = System.Drawing.Color.Gainsboro
        Me.txtPartida_NoPartida.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPartida_NoPartida.Enabled = False
        Me.txtPartida_NoPartida.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPartida_NoPartida.Location = New System.Drawing.Point(536, 22)
        Me.txtPartida_NoPartida.Name = "txtPartida_NoPartida"
        Me.txtPartida_NoPartida.Size = New System.Drawing.Size(202, 26)
        Me.txtPartida_NoPartida.TabIndex = 0
        Me.txtPartida_NoPartida.Text = "0"
        Me.txtPartida_NoPartida.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.dgvDetails)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(15, 158)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(723, 325)
        Me.FlowLayoutPanel1.TabIndex = 28
        '
        'dgvDetails
        '
        Me.dgvDetails.AllowUserToAddRows = False
        Me.dgvDetails.AllowUserToDeleteRows = False
        Me.dgvDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetails.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id_ModulesAccountingitemDetall, Me.Description, Me.NombreCuentaContable, Me.Name_CostCenter, Me.Debit, Me.Credit})
        Me.dgvDetails.ContextMenuStrip = Me.CMSDgvDetails
        Me.dgvDetails.Location = New System.Drawing.Point(2, 2)
        Me.dgvDetails.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvDetails.MultiSelect = False
        Me.dgvDetails.Name = "dgvDetails"
        Me.dgvDetails.ReadOnly = True
        Me.dgvDetails.RowTemplate.Height = 24
        Me.dgvDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDetails.Size = New System.Drawing.Size(721, 323)
        Me.dgvDetails.TabIndex = 0
        '
        'Id_ModulesAccountingitemDetall
        '
        Me.Id_ModulesAccountingitemDetall.DataPropertyName = "Id_ModulesAccountingitemDetall"
        Me.Id_ModulesAccountingitemDetall.HeaderText = "ID"
        Me.Id_ModulesAccountingitemDetall.Name = "Id_ModulesAccountingitemDetall"
        Me.Id_ModulesAccountingitemDetall.ReadOnly = True
        Me.Id_ModulesAccountingitemDetall.Width = 59
        '
        'Description
        '
        Me.Description.DataPropertyName = "Description"
        Me.Description.HeaderText = "Descripción"
        Me.Description.Name = "Description"
        Me.Description.ReadOnly = True
        Me.Description.Width = 161
        '
        'NombreCuentaContable
        '
        Me.NombreCuentaContable.DataPropertyName = "NombreCuentaContable"
        Me.NombreCuentaContable.HeaderText = "Cuenta Contable"
        Me.NombreCuentaContable.Name = "NombreCuentaContable"
        Me.NombreCuentaContable.ReadOnly = True
        Me.NombreCuentaContable.Width = 194
        '
        'Name_CostCenter
        '
        Me.Name_CostCenter.DataPropertyName = "Name_CostCenter"
        Me.Name_CostCenter.HeaderText = "Centro de Costo"
        Me.Name_CostCenter.Name = "Name_CostCenter"
        Me.Name_CostCenter.ReadOnly = True
        Me.Name_CostCenter.Width = 134
        '
        'Debit
        '
        Me.Debit.DataPropertyName = "Debit"
        Me.Debit.HeaderText = "Debe"
        Me.Debit.Name = "Debit"
        Me.Debit.ReadOnly = True
        Me.Debit.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Debit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Debit.Width = 92
        '
        'Credit
        '
        Me.Credit.DataPropertyName = "Credit"
        Me.Credit.HeaderText = "Haber"
        Me.Credit.Name = "Credit"
        Me.Credit.ReadOnly = True
        Me.Credit.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Credit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'CMSDgvDetails
        '
        Me.CMSDgvDetails.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Eliminar})
        Me.CMSDgvDetails.Name = "CMSDgvDetails"
        Me.CMSDgvDetails.Size = New System.Drawing.Size(118, 26)
        '
        'Eliminar
        '
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.Size = New System.Drawing.Size(117, 22)
        Me.Eliminar.Text = "Eliminar"
        '
        'label50
        '
        Me.label50.AutoSize = True
        Me.label50.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label50.Location = New System.Drawing.Point(479, 27)
        Me.label50.Name = "label50"
        Me.label50.Size = New System.Drawing.Size(45, 21)
        Me.label50.TabIndex = 0
        Me.label50.Text = "No.  :"
        '
        'label49
        '
        Me.label49.AutoSize = True
        Me.label49.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label49.Location = New System.Drawing.Point(39, 129)
        Me.label49.Name = "label49"
        Me.label49.Size = New System.Drawing.Size(140, 21)
        Me.label49.TabIndex = 0
        Me.label49.Text = "Cuenta Contable  : "
        '
        'cbListAccount
        '
        Me.cbListAccount.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbListAccount.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbListAccount.BackColor = System.Drawing.Color.Gainsboro
        Me.cbListAccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbListAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbListAccount.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbListAccount.FormattingEnabled = True
        Me.cbListAccount.Location = New System.Drawing.Point(185, 125)
        Me.cbListAccount.Name = "cbListAccount"
        Me.cbListAccount.Size = New System.Drawing.Size(478, 29)
        Me.cbListAccount.TabIndex = 1
        '
        'cmdAdd
        '
        Me.cmdAdd.BackColor = System.Drawing.Color.Gainsboro
        Me.cmdAdd.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdAdd.FlatAppearance.BorderSize = 0
        Me.cmdAdd.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.cmdAdd.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.cmdAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAdd.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAdd.Location = New System.Drawing.Point(669, 125)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(69, 29)
        Me.cmdAdd.TabIndex = 2
        Me.cmdAdd.Text = "add"
        Me.cmdAdd.UseVisualStyleBackColor = False
        '
        'Financiero_PartidaConfExterna
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(782, 562)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Financiero_PartidaConfExterna"
        Me.Text = "FormPartida1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        CType(Me.dgvDetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CMSDgvDetails.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents IL_Banderas As System.Windows.Forms.ImageList
    Private WithEvents Label3 As System.Windows.Forms.Label
    Private WithEvents CB_TypeItem As System.Windows.Forms.ComboBox
    Private WithEvents txtConcept As System.Windows.Forms.TextBox
    Private WithEvents Label2 As System.Windows.Forms.Label
    Private WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents cmdSave As System.Windows.Forms.Button
    Private WithEvents txtPartida_NoPartida As System.Windows.Forms.TextBox
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Private WithEvents label50 As System.Windows.Forms.Label
    Private WithEvents label49 As System.Windows.Forms.Label
    Private WithEvents cbListAccount As System.Windows.Forms.ComboBox
    Private WithEvents cmdAdd As System.Windows.Forms.Button
    Friend WithEvents dgvDetails As System.Windows.Forms.DataGridView
    Friend WithEvents CMSDgvDetails As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents Eliminar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Id_ModulesAccountingitemDetall As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Description As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreCuentaContable As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Name_CostCenter As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Debit As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Credit As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
