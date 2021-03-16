<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ERP_Mantenimiento_OutletCatalog
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
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.label49 = New System.Windows.Forms.Label()
        Me.txtNameOutletCatalog = New System.Windows.Forms.TextBox()
        Me.chkEntry = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.chkEntry)
        Me.GroupBox1.Controls.Add(Me.cmdCancel)
        Me.GroupBox1.Controls.Add(Me.cmdSave)
        Me.GroupBox1.Controls.Add(Me.label49)
        Me.GroupBox1.Controls.Add(Me.txtNameOutletCatalog)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(492, 203)
        Me.GroupBox1.TabIndex = 31
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Crear Catálogo de Entrada/Salida"
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
        Me.cmdCancel.Location = New System.Drawing.Point(382, 144)
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
        Me.cmdSave.Location = New System.Drawing.Point(261, 144)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(98, 29)
        Me.cmdSave.TabIndex = 29
        Me.cmdSave.Text = "Grabar"
        Me.cmdSave.UseVisualStyleBackColor = False
        '
        'label49
        '
        Me.label49.AutoSize = True
        Me.label49.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.label49.Location = New System.Drawing.Point(9, 60)
        Me.label49.Name = "label49"
        Me.label49.Size = New System.Drawing.Size(171, 25)
        Me.label49.TabIndex = 20
        Me.label49.Text = "Nombre Catálogo :"
        '
        'txtNameOutletCatalog
        '
        Me.txtNameOutletCatalog.BackColor = System.Drawing.Color.Gainsboro
        Me.txtNameOutletCatalog.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNameOutletCatalog.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNameOutletCatalog.Location = New System.Drawing.Point(186, 60)
        Me.txtNameOutletCatalog.MaxLength = 150
        Me.txtNameOutletCatalog.Name = "txtNameOutletCatalog"
        Me.txtNameOutletCatalog.Size = New System.Drawing.Size(243, 26)
        Me.txtNameOutletCatalog.TabIndex = 26
        '
        'chkEntry
        '
        Me.chkEntry.AutoSize = True
        Me.chkEntry.Location = New System.Drawing.Point(186, 92)
        Me.chkEntry.Name = "chkEntry"
        Me.chkEntry.Size = New System.Drawing.Size(145, 29)
        Me.chkEntry.TabIndex = 31
        Me.chkEntry.Text = "Tipo Entrada"
        Me.chkEntry.UseVisualStyleBackColor = True
        '
        'ERP_Mantenimiento_OutletCatalog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(518, 229)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ERP_Mantenimiento_OutletCatalog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Mantenimiento_Generic_Municipality"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Private WithEvents cmdCancel As Button
    Private WithEvents cmdSave As Button
    Private WithEvents label49 As Label
    Private WithEvents txtNameOutletCatalog As TextBox
    Friend WithEvents chkEntry As CheckBox
End Class
