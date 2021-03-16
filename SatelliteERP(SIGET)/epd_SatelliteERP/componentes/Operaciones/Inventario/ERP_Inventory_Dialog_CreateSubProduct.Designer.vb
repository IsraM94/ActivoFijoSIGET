<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ERP_Inventory_Dialog_CreateSubProduct
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
        Me.GBSearch = New System.Windows.Forms.GroupBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.cmdOk = New System.Windows.Forms.Button()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.GBSearch.SuspendLayout()
        Me.SuspendLayout()
        '
        'GBSearch
        '
        Me.GBSearch.BackColor = System.Drawing.SystemColors.Control
        Me.GBSearch.Controls.Add(Me.txtPrice)
        Me.GBSearch.Controls.Add(Me.Label2)
        Me.GBSearch.Controls.Add(Me.Label1)
        Me.GBSearch.Controls.Add(Me.cmdCancel)
        Me.GBSearch.Controls.Add(Me.cmdOk)
        Me.GBSearch.Controls.Add(Me.txtName)
        Me.GBSearch.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBSearch.Location = New System.Drawing.Point(8, 10)
        Me.GBSearch.Name = "GBSearch"
        Me.GBSearch.Size = New System.Drawing.Size(547, 254)
        Me.GBSearch.TabIndex = 33
        Me.GBSearch.TabStop = False
        Me.GBSearch.Text = "Crear Sub Producto"
        '
        'txtPrice
        '
        Me.txtPrice.BackColor = System.Drawing.Color.Gainsboro
        Me.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPrice.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrice.Location = New System.Drawing.Point(122, 142)
        Me.txtPrice.MaxLength = 50
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.ShortcutsEnabled = False
        Me.txtPrice.Size = New System.Drawing.Size(368, 26)
        Me.txtPrice.TabIndex = 33
        Me.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(34, 142)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 25)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Precio:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 25)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Nombre:"
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
        Me.cmdCancel.Location = New System.Drawing.Point(305, 197)
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
        Me.cmdOk.Location = New System.Drawing.Point(201, 197)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(98, 29)
        Me.cmdOk.TabIndex = 29
        Me.cmdOk.Text = "OK"
        Me.cmdOk.UseVisualStyleBackColor = False
        '
        'txtName
        '
        Me.txtName.BackColor = System.Drawing.Color.Gainsboro
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtName.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(122, 65)
        Me.txtName.MaxLength = 50
        Me.txtName.Multiline = True
        Me.txtName.Name = "txtName"
        Me.txtName.ShortcutsEnabled = False
        Me.txtName.Size = New System.Drawing.Size(368, 71)
        Me.txtName.TabIndex = 26
        '
        'ERP_Inventory_Dialog_CreateSubProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(565, 275)
        Me.Controls.Add(Me.GBSearch)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ERP_Inventory_Dialog_CreateSubProduct"
        Me.Text = "ERP_Inventory_Dialog_CreateSubProduct"
        Me.GBSearch.ResumeLayout(False)
        Me.GBSearch.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GBSearch As GroupBox
	Private WithEvents cmdCancel As Button
	Private WithEvents cmdOk As Button
	Private WithEvents txtName As TextBox
	Private WithEvents txtPrice As TextBox
	Friend WithEvents Label2 As Label
	Friend WithEvents Label1 As Label
End Class
