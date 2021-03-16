<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ERP_Finance_Bank_Entradas
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
        Me.GBEntradaBancos = New System.Windows.Forms.GroupBox()
        Me.txtActualAmount = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbBancos = New System.Windows.Forms.ComboBox()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.txtPagadoa = New System.Windows.Forms.TextBox()
        Me.txtAmountMovement = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GBEntradaBancos.SuspendLayout()
        Me.SuspendLayout()
        '
        'GBEntradaBancos
        '
        Me.GBEntradaBancos.BackColor = System.Drawing.SystemColors.Control
        Me.GBEntradaBancos.Controls.Add(Me.txtActualAmount)
        Me.GBEntradaBancos.Controls.Add(Me.Label5)
        Me.GBEntradaBancos.Controls.Add(Me.cbBancos)
        Me.GBEntradaBancos.Controls.Add(Me.cmdCancel)
        Me.GBEntradaBancos.Controls.Add(Me.cmdSave)
        Me.GBEntradaBancos.Controls.Add(Me.txtDescription)
        Me.GBEntradaBancos.Controls.Add(Me.txtPagadoa)
        Me.GBEntradaBancos.Controls.Add(Me.txtAmountMovement)
        Me.GBEntradaBancos.Controls.Add(Me.Label3)
        Me.GBEntradaBancos.Controls.Add(Me.Label2)
        Me.GBEntradaBancos.Controls.Add(Me.Label4)
        Me.GBEntradaBancos.Controls.Add(Me.Label1)
        Me.GBEntradaBancos.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBEntradaBancos.Location = New System.Drawing.Point(12, 12)
        Me.GBEntradaBancos.Name = "GBEntradaBancos"
        Me.GBEntradaBancos.Size = New System.Drawing.Size(526, 352)
        Me.GBEntradaBancos.TabIndex = 31
        Me.GBEntradaBancos.TabStop = False
        Me.GBEntradaBancos.Text = "Configuración Entrada Bancos"
        '
        'txtActualAmount
        '
        Me.txtActualAmount.BackColor = System.Drawing.Color.Gainsboro
        Me.txtActualAmount.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtActualAmount.Enabled = False
        Me.txtActualAmount.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtActualAmount.Location = New System.Drawing.Point(192, 220)
        Me.txtActualAmount.Name = "txtActualAmount"
        Me.txtActualAmount.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtActualAmount.Size = New System.Drawing.Size(173, 26)
        Me.txtActualAmount.TabIndex = 31
        Me.txtActualAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(45, 221)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(121, 25)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Saldo Actual:"
        '
        'cbBancos
        '
        Me.cbBancos.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbBancos.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbBancos.BackColor = System.Drawing.Color.Gainsboro
        Me.cbBancos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbBancos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbBancos.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbBancos.FormattingEnabled = True
        Me.cbBancos.Location = New System.Drawing.Point(192, 41)
        Me.cbBancos.Name = "cbBancos"
        Me.cbBancos.Size = New System.Drawing.Size(316, 29)
        Me.cbBancos.TabIndex = 1
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
        Me.cmdCancel.Location = New System.Drawing.Point(386, 307)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(98, 29)
        Me.cmdCancel.TabIndex = 30
        Me.cmdCancel.Text = "Cancelar"
        Me.cmdCancel.UseVisualStyleBackColor = False
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
        Me.cmdSave.Location = New System.Drawing.Point(282, 307)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(98, 29)
        Me.cmdSave.TabIndex = 29
        Me.cmdSave.Text = "Grabar"
        Me.cmdSave.UseVisualStyleBackColor = False
        '
        'txtDescription
        '
        Me.txtDescription.BackColor = System.Drawing.Color.Gainsboro
        Me.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDescription.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescription.Location = New System.Drawing.Point(192, 86)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(316, 72)
        Me.txtDescription.TabIndex = 3
        '
        'txtPagadoa
        '
        Me.txtPagadoa.BackColor = System.Drawing.Color.Gainsboro
        Me.txtPagadoa.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPagadoa.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPagadoa.Location = New System.Drawing.Point(192, 269)
        Me.txtPagadoa.Name = "txtPagadoa"
        Me.txtPagadoa.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtPagadoa.Size = New System.Drawing.Size(316, 26)
        Me.txtPagadoa.TabIndex = 5
        '
        'txtAmountMovement
        '
        Me.txtAmountMovement.BackColor = System.Drawing.Color.Gainsboro
        Me.txtAmountMovement.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAmountMovement.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmountMovement.Location = New System.Drawing.Point(192, 171)
        Me.txtAmountMovement.Name = "txtAmountMovement"
        Me.txtAmountMovement.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtAmountMovement.Size = New System.Drawing.Size(173, 26)
        Me.txtAmountMovement.TabIndex = 4
        Me.txtAmountMovement.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(45, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 25)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Descripción"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(45, 172)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 25)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Monto:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(49, 270)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 25)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Pagado a:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(45, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 25)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Banco:"
        '
        'ERP_Finance_Bank_Entradas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(552, 376)
        Me.Controls.Add(Me.GBEntradaBancos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ERP_Finance_Bank_Entradas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Mantenimiento_Generic_Municipality"
        Me.GBEntradaBancos.ResumeLayout(False)
        Me.GBEntradaBancos.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GBEntradaBancos As GroupBox
    Private WithEvents cmdCancel As Button
    Private WithEvents cmdSave As Button
    Private WithEvents txtAmountMovement As TextBox
    Private WithEvents Label1 As Label
    Private WithEvents cbBancos As ComboBox
    Private WithEvents txtDescription As TextBox
    Private WithEvents Label3 As Label
    Private WithEvents Label2 As Label
    Private WithEvents txtPagadoa As TextBox
    Private WithEvents Label4 As Label
    Private WithEvents txtActualAmount As TextBox
    Private WithEvents Label5 As Label
End Class
