<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ERP_Inventory_Dialog_LocationAndStowage
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTipoCliente = New System.Windows.Forms.Label()
        Me.cbStowage = New System.Windows.Forms.ComboBox()
        Me.cbLocation = New System.Windows.Forms.ComboBox()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.cmdOk = New System.Windows.Forms.Button()
        Me.GBSearch.SuspendLayout()
        Me.SuspendLayout()
        '
        'GBSearch
        '
        Me.GBSearch.BackColor = System.Drawing.SystemColors.Control
        Me.GBSearch.Controls.Add(Me.Label1)
        Me.GBSearch.Controls.Add(Me.lblTipoCliente)
        Me.GBSearch.Controls.Add(Me.cbStowage)
        Me.GBSearch.Controls.Add(Me.cbLocation)
        Me.GBSearch.Controls.Add(Me.cmdCancel)
        Me.GBSearch.Controls.Add(Me.cmdOk)
        Me.GBSearch.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBSearch.Location = New System.Drawing.Point(10, 11)
        Me.GBSearch.Name = "GBSearch"
        Me.GBSearch.Size = New System.Drawing.Size(573, 232)
        Me.GBSearch.TabIndex = 33
        Me.GBSearch.TabStop = False
        Me.GBSearch.Text = "Configurar Bodega"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.Label1.Location = New System.Drawing.Point(5, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 25)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Ubicación:"
        '
        'lblTipoCliente
        '
        Me.lblTipoCliente.AutoSize = True
        Me.lblTipoCliente.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.lblTipoCliente.Location = New System.Drawing.Point(23, 107)
        Me.lblTipoCliente.Name = "lblTipoCliente"
        Me.lblTipoCliente.Size = New System.Drawing.Size(80, 25)
        Me.lblTipoCliente.TabIndex = 33
        Me.lblTipoCliente.Text = "Bodega:"
        '
        'cbStowage
        '
        Me.cbStowage.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbStowage.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbStowage.BackColor = System.Drawing.Color.Gainsboro
        Me.cbStowage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbStowage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbStowage.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbStowage.FormattingEnabled = True
        Me.cbStowage.Location = New System.Drawing.Point(104, 107)
        Me.cbStowage.Name = "cbStowage"
        Me.cbStowage.Size = New System.Drawing.Size(451, 29)
        Me.cbStowage.TabIndex = 32
        '
        'cbLocation
        '
        Me.cbLocation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbLocation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbLocation.BackColor = System.Drawing.Color.Gainsboro
        Me.cbLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbLocation.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbLocation.FormattingEnabled = True
        Me.cbLocation.Location = New System.Drawing.Point(104, 63)
        Me.cbLocation.Name = "cbLocation"
        Me.cbLocation.Size = New System.Drawing.Size(451, 29)
        Me.cbLocation.TabIndex = 31
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
        Me.cmdCancel.Location = New System.Drawing.Point(312, 175)
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
        Me.cmdOk.Location = New System.Drawing.Point(208, 175)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(98, 29)
        Me.cmdOk.TabIndex = 29
        Me.cmdOk.Text = "Aceptar"
        Me.cmdOk.UseVisualStyleBackColor = False
        '
        'ERP_Inventory_Dialog_LocationAndStowage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CadetBlue
        Me.ClientSize = New System.Drawing.Size(593, 253)
        Me.Controls.Add(Me.GBSearch)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ERP_Inventory_Dialog_LocationAndStowage"
        Me.Text = "ERP_Inventory_Dialog_LocationAndStowage"
        Me.GBSearch.ResumeLayout(False)
        Me.GBSearch.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GBSearch As GroupBox
	Private WithEvents cmdCancel As Button
	Private WithEvents cmdOk As Button
	Private WithEvents cbStowage As ComboBox
	Private WithEvents cbLocation As ComboBox
	Private WithEvents Label1 As Label
	Private WithEvents lblTipoCliente As Label
End Class
