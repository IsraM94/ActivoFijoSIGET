<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ERP_Inventory_SubProducts
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
        Me.GBSearch = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.cmdUpdate = New System.Windows.Forms.Button()
        Me.cmdAdd = New System.Windows.Forms.Button()
        Me.dgvProducts = New System.Windows.Forms.DataGridView()
        Me.ID_SubProduct = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameProduct = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GBSearch.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgvProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GBSearch
        '
        Me.GBSearch.BackColor = System.Drawing.SystemColors.Control
        Me.GBSearch.Controls.Add(Me.TableLayoutPanel1)
        Me.GBSearch.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBSearch.Location = New System.Drawing.Point(9, 10)
        Me.GBSearch.Name = "GBSearch"
        Me.GBSearch.Size = New System.Drawing.Size(777, 456)
        Me.GBSearch.TabIndex = 33
        Me.GBSearch.TabStop = False
        Me.GBSearch.Text = "Búsqueda"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.dgvProducts, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 29)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.36986!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 78.63013!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(771, 424)
        Me.TableLayoutPanel1.TabIndex = 31
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cmdCancel)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 368)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(765, 53)
        Me.Panel1.TabIndex = 0
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
        Me.cmdCancel.Location = New System.Drawing.Point(649, 15)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(98, 29)
        Me.cmdCancel.TabIndex = 32
        Me.cmdCancel.Text = "Cerrar"
        Me.cmdCancel.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.cmdUpdate)
        Me.Panel2.Controls.Add(Me.cmdAdd)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(765, 72)
        Me.Panel2.TabIndex = 1
        '
        'cmdUpdate
        '
        Me.cmdUpdate.Dock = System.Windows.Forms.DockStyle.Left
        Me.cmdUpdate.Location = New System.Drawing.Point(112, 0)
        Me.cmdUpdate.Name = "cmdUpdate"
        Me.cmdUpdate.Size = New System.Drawing.Size(112, 72)
        Me.cmdUpdate.TabIndex = 1
        Me.cmdUpdate.Text = "Modificar"
        Me.cmdUpdate.UseVisualStyleBackColor = True
        '
        'cmdAdd
        '
        Me.cmdAdd.Dock = System.Windows.Forms.DockStyle.Left
        Me.cmdAdd.Location = New System.Drawing.Point(0, 0)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(112, 72)
        Me.cmdAdd.TabIndex = 0
        Me.cmdAdd.Text = "Agregar"
        Me.cmdAdd.UseVisualStyleBackColor = True
        '
        'dgvProducts
        '
        Me.dgvProducts.AllowUserToAddRows = False
        Me.dgvProducts.AllowUserToDeleteRows = False
        Me.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProducts.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID_SubProduct, Me.NameProduct, Me.Price})
        Me.dgvProducts.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvProducts.Location = New System.Drawing.Point(3, 81)
        Me.dgvProducts.Name = "dgvProducts"
        Me.dgvProducts.ReadOnly = True
        Me.dgvProducts.RowHeadersVisible = False
        Me.dgvProducts.Size = New System.Drawing.Size(765, 281)
        Me.dgvProducts.TabIndex = 2
        '
        'ID_SubProduct
        '
        Me.ID_SubProduct.DataPropertyName = "ID_SubProduct"
        Me.ID_SubProduct.HeaderText = "Correlativo"
        Me.ID_SubProduct.Name = "ID_SubProduct"
        Me.ID_SubProduct.ReadOnly = True
        Me.ID_SubProduct.Width = 150
        '
        'NameProduct
        '
        Me.NameProduct.DataPropertyName = "NameProduct"
        Me.NameProduct.HeaderText = "Descripción"
        Me.NameProduct.Name = "NameProduct"
        Me.NameProduct.ReadOnly = True
        Me.NameProduct.Width = 460
        '
        'Price
        '
        Me.Price.DataPropertyName = "Price"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle1.Format = "C2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.Price.DefaultCellStyle = DataGridViewCellStyle1
        Me.Price.HeaderText = "Precio"
        Me.Price.Name = "Price"
        Me.Price.ReadOnly = True
        Me.Price.Width = 150
        '
        'ERP_Inventory_SubProducts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(798, 478)
        Me.Controls.Add(Me.GBSearch)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ERP_Inventory_SubProducts"
        Me.Text = "ERP_Inventory_SubProducts"
        Me.GBSearch.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.dgvProducts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GBSearch As GroupBox
	Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
	Friend WithEvents Panel1 As Panel
	Private WithEvents cmdCancel As Button
	Friend WithEvents Panel2 As Panel
	Friend WithEvents cmdUpdate As Button
	Friend WithEvents cmdAdd As Button
	Friend WithEvents dgvProducts As DataGridView
	Friend WithEvents ID_SubProduct As DataGridViewTextBoxColumn
	Friend WithEvents NameProduct As DataGridViewTextBoxColumn
	Friend WithEvents Price As DataGridViewTextBoxColumn
End Class
