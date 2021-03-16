<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ERP_Bank_Research
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
        Me.GBSearch = New System.Windows.Forms.GroupBox()
        Me.DGV_ChooseBank = New System.Windows.Forms.DataGridView()
        Me.id_BankCatalog = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Description_BankCatalog = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.cmdOk = New System.Windows.Forms.Button()
        Me.GBSearch.SuspendLayout()
        CType(Me.DGV_ChooseBank, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GBSearch
        '
        Me.GBSearch.BackColor = System.Drawing.SystemColors.Control
        Me.GBSearch.Controls.Add(Me.DGV_ChooseBank)
        Me.GBSearch.Controls.Add(Me.cmdCancel)
        Me.GBSearch.Controls.Add(Me.cmdOk)
        Me.GBSearch.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBSearch.Location = New System.Drawing.Point(10, 11)
        Me.GBSearch.Name = "GBSearch"
        Me.GBSearch.Size = New System.Drawing.Size(368, 287)
        Me.GBSearch.TabIndex = 32
        Me.GBSearch.TabStop = False
        Me.GBSearch.Text = "Selecione Banco"
        '
        'DGV_ChooseBank
        '
        Me.DGV_ChooseBank.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_ChooseBank.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_BankCatalog, Me.Description_BankCatalog})
        Me.DGV_ChooseBank.Location = New System.Drawing.Point(6, 32)
        Me.DGV_ChooseBank.Name = "DGV_ChooseBank"
        Me.DGV_ChooseBank.RowHeadersVisible = False
        Me.DGV_ChooseBank.Size = New System.Drawing.Size(349, 208)
        Me.DGV_ChooseBank.TabIndex = 31
        '
        'id_BankCatalog
        '
        Me.id_BankCatalog.DataPropertyName = "id_BankCatalog"
        Me.id_BankCatalog.HeaderText = "Correlativo"
        Me.id_BankCatalog.Name = "id_BankCatalog"
        '
        'Description_BankCatalog
        '
        Me.Description_BankCatalog.DataPropertyName = "Name_BankCatalog"
        Me.Description_BankCatalog.HeaderText = "Descripción de Banco"
        Me.Description_BankCatalog.Name = "Description_BankCatalog"
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
        Me.cmdCancel.Location = New System.Drawing.Point(257, 246)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(98, 29)
        Me.cmdCancel.TabIndex = 30
        Me.cmdCancel.Text = "Cancelar"
        Me.cmdCancel.UseVisualStyleBackColor = False
        '
        'cmdOk
        '
        Me.cmdOk.BackColor = System.Drawing.Color.Gainsboro
        Me.cmdOk.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdOk.FlatAppearance.BorderSize = 0
        Me.cmdOk.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.cmdOk.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.cmdOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdOk.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOk.Location = New System.Drawing.Point(153, 246)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(98, 29)
        Me.cmdOk.TabIndex = 29
        Me.cmdOk.Text = "OK"
        Me.cmdOk.UseVisualStyleBackColor = False
        '
        'ERP_Bank_Research
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(390, 306)
        Me.Controls.Add(Me.GBSearch)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ERP_Bank_Research"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ERP_Mantenimiento_DialogSearch"
        Me.GBSearch.ResumeLayout(False)
        CType(Me.DGV_ChooseBank, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GBSearch As GroupBox
    Private WithEvents cmdCancel As Button
    Private WithEvents cmdOk As Button
    Friend WithEvents DGV_ChooseBank As DataGridView
    Friend WithEvents id_BankCatalog As DataGridViewTextBoxColumn
    Friend WithEvents Description_BankCatalog As DataGridViewTextBoxColumn
End Class
