<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EditarRequisicion
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ExistenciasProducto = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.NombreProducto = New System.Windows.Forms.TextBox()
        Me.Observacion = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CantidadSolicitada = New System.Windows.Forms.TextBox()
        Me.CantidadEntregar = New System.Windows.Forms.TextBox()
        Me.cmdAceptar = New System.Windows.Forms.Button()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmdDenegar = New System.Windows.Forms.Button()
        Me.cmdAprobar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cb_Bodega1 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.lblValor = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.ExistenciasProducto)
        Me.GroupBox1.Controls.Add(Me.Observacion)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.NombreProducto)
        Me.GroupBox1.Controls.Add(Me.CantidadSolicitada)
        Me.GroupBox1.Controls.Add(Me.CantidadEntregar)
        Me.GroupBox1.Controls.Add(Me.cmdAceptar)
        Me.GroupBox1.Controls.Add(Me.cmdCancelar)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cmdDenegar)
        Me.GroupBox1.Controls.Add(Me.cmdAprobar)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cb_Bodega1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cmdCancel)
        Me.GroupBox1.Controls.Add(Me.cmdSave)
        Me.GroupBox1.Controls.Add(Me.lblValor)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(443, 359)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Abastecer Requisición"
        '
        'ExistenciasProducto
        '
        Me.ExistenciasProducto.Enabled = False
        Me.ExistenciasProducto.Location = New System.Drawing.Point(177, 135)
        Me.ExistenciasProducto.MaxLength = 200
        Me.ExistenciasProducto.Name = "ExistenciasProducto"
        Me.ExistenciasProducto.ReadOnly = True
        Me.ExistenciasProducto.Size = New System.Drawing.Size(246, 33)
        Me.ExistenciasProducto.TabIndex = 58
        Me.ExistenciasProducto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(84, 141)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 21)
        Me.Label5.TabIndex = 57
        Me.Label5.Text = "Existencias:"
        '
        'NombreProducto
        '
        Me.NombreProducto.Enabled = False
        Me.NombreProducto.Location = New System.Drawing.Point(177, 40)
        Me.NombreProducto.MaxLength = 200
        Me.NombreProducto.Multiline = True
        Me.NombreProducto.Name = "NombreProducto"
        Me.NombreProducto.ReadOnly = True
        Me.NombreProducto.Size = New System.Drawing.Size(246, 85)
        Me.NombreProducto.TabIndex = 56
        '
        'Observacion
        '
        Me.Observacion.Location = New System.Drawing.Point(140, 312)
        Me.Observacion.MaxLength = 200
        Me.Observacion.Name = "Observacion"
        Me.Observacion.Size = New System.Drawing.Size(31, 33)
        Me.Observacion.TabIndex = 55
        Me.Observacion.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(34, 318)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 21)
        Me.Label4.TabIndex = 54
        Me.Label4.Text = "Observación:"
        Me.Label4.Visible = False
        '
        'CantidadSolicitada
        '
        Me.CantidadSolicitada.Enabled = False
        Me.CantidadSolicitada.Location = New System.Drawing.Point(177, 182)
        Me.CantidadSolicitada.Name = "CantidadSolicitada"
        Me.CantidadSolicitada.ReadOnly = True
        Me.CantidadSolicitada.Size = New System.Drawing.Size(246, 33)
        Me.CantidadSolicitada.TabIndex = 53
        Me.CantidadSolicitada.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'CantidadEntregar
        '
        Me.CantidadEntregar.Location = New System.Drawing.Point(177, 228)
        Me.CantidadEntregar.MaxLength = 8
        Me.CantidadEntregar.Name = "CantidadEntregar"
        Me.CantidadEntregar.Size = New System.Drawing.Size(246, 33)
        Me.CantidadEntregar.TabIndex = 52
        Me.CantidadEntregar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cmdAceptar
        '
        Me.cmdAceptar.BackColor = System.Drawing.Color.Gainsboro
        Me.cmdAceptar.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdAceptar.FlatAppearance.BorderSize = 0
        Me.cmdAceptar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.cmdAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.cmdAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAceptar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAceptar.Location = New System.Drawing.Point(229, 314)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(98, 28)
        Me.cmdAceptar.TabIndex = 51
        Me.cmdAceptar.Text = "Aceptar"
        Me.cmdAceptar.UseVisualStyleBackColor = False
        '
        'cmdCancelar
        '
        Me.cmdCancelar.BackColor = System.Drawing.Color.Gainsboro
        Me.cmdCancelar.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdCancelar.FlatAppearance.BorderSize = 0
        Me.cmdCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.cmdCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.cmdCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCancelar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.Location = New System.Drawing.Point(333, 314)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(98, 28)
        Me.cmdCancelar.TabIndex = 50
        Me.cmdCancelar.Text = "Cancelar"
        Me.cmdCancelar.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(21, 234)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(150, 21)
        Me.Label3.TabIndex = 49
        Me.Label3.Text = "Cantidad a entregar:"
        '
        'cmdDenegar
        '
        Me.cmdDenegar.BackColor = System.Drawing.Color.Gainsboro
        Me.cmdDenegar.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdDenegar.FlatAppearance.BorderSize = 0
        Me.cmdDenegar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.cmdDenegar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.cmdDenegar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdDenegar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDenegar.Location = New System.Drawing.Point(200, 506)
        Me.cmdDenegar.Name = "cmdDenegar"
        Me.cmdDenegar.Size = New System.Drawing.Size(98, 28)
        Me.cmdDenegar.TabIndex = 46
        Me.cmdDenegar.Text = "Denegar"
        Me.cmdDenegar.UseVisualStyleBackColor = False
        '
        'cmdAprobar
        '
        Me.cmdAprobar.BackColor = System.Drawing.Color.Gainsboro
        Me.cmdAprobar.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdAprobar.FlatAppearance.BorderSize = 0
        Me.cmdAprobar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.cmdAprobar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.cmdAprobar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAprobar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAprobar.Location = New System.Drawing.Point(89, 506)
        Me.cmdAprobar.Name = "cmdAprobar"
        Me.cmdAprobar.Size = New System.Drawing.Size(98, 28)
        Me.cmdAprobar.TabIndex = 46
        Me.cmdAprobar.Text = "Aprobar"
        Me.cmdAprobar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(33, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(138, 21)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "Nombre producto:"
        '
        'cb_Bodega1
        '
        Me.cb_Bodega1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cb_Bodega1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cb_Bodega1.BackColor = System.Drawing.Color.Gainsboro
        Me.cb_Bodega1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_Bodega1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cb_Bodega1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_Bodega1.FormattingEnabled = True
        Me.cb_Bodega1.Location = New System.Drawing.Point(177, 276)
        Me.cb_Bodega1.Name = "cb_Bodega1"
        Me.cb_Bodega1.Size = New System.Drawing.Size(246, 29)
        Me.cb_Bodega1.TabIndex = 43
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(106, 279)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 21)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Bodega:"
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
        Me.cmdCancel.Location = New System.Drawing.Point(427, 506)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(98, 28)
        Me.cmdCancel.TabIndex = 9
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
        Me.cmdSave.Location = New System.Drawing.Point(314, 506)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(98, 28)
        Me.cmdSave.TabIndex = 8
        Me.cmdSave.Text = "Grabar"
        Me.cmdSave.UseVisualStyleBackColor = False
        '
        'lblValor
        '
        Me.lblValor.AutoSize = True
        Me.lblValor.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValor.Location = New System.Drawing.Point(27, 188)
        Me.lblValor.Name = "lblValor"
        Me.lblValor.Size = New System.Drawing.Size(144, 21)
        Me.lblValor.TabIndex = 0
        Me.lblValor.Text = "Cantidad solicitada:"
        '
        'EditarRequisicion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CadetBlue
        Me.ClientSize = New System.Drawing.Size(463, 379)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "EditarRequisicion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EditarRequisicion"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Private WithEvents Label3 As Label
    Private WithEvents cmdDenegar As Button
    Private WithEvents cmdAprobar As Button
    Private WithEvents Label1 As Label
    Private WithEvents cb_Bodega1 As ComboBox
    Private WithEvents Label2 As Label
    Private WithEvents cmdCancel As Button
    Private WithEvents cmdSave As Button
    Private WithEvents lblValor As Label
    Private WithEvents cmdAceptar As Button
    Private WithEvents cmdCancelar As Button
    Friend WithEvents CantidadSolicitada As TextBox
    Friend WithEvents CantidadEntregar As TextBox
    Friend WithEvents Observacion As TextBox
    Private WithEvents Label4 As Label
    Friend WithEvents NombreProducto As TextBox
    Friend WithEvents ExistenciasProducto As TextBox
    Private WithEvents Label5 As Label
End Class
