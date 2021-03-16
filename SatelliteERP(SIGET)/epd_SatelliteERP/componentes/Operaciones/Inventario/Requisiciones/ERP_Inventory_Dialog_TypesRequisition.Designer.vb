<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ERP_Inventory_Dialog_TypesRequisition
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
        Me.GroupTiposRequisciones = New System.Windows.Forms.GroupBox()
        Me.label49 = New System.Windows.Forms.Label()
        Me.txtTypeRequisition = New System.Windows.Forms.TextBox()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.cmdSaveTipoRequisicion = New System.Windows.Forms.Button()
        Me.GroupTiposRequisciones.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupTiposRequisciones
        '
        Me.GroupTiposRequisciones.BackColor = System.Drawing.SystemColors.Control
        Me.GroupTiposRequisciones.Controls.Add(Me.label49)
        Me.GroupTiposRequisciones.Controls.Add(Me.txtTypeRequisition)
        Me.GroupTiposRequisciones.Controls.Add(Me.cmdCancel)
        Me.GroupTiposRequisciones.Controls.Add(Me.cmdSaveTipoRequisicion)
        Me.GroupTiposRequisciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupTiposRequisciones.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupTiposRequisciones.Location = New System.Drawing.Point(12, 12)
        Me.GroupTiposRequisciones.Name = "GroupTiposRequisciones"
        Me.GroupTiposRequisciones.Size = New System.Drawing.Size(495, 178)
        Me.GroupTiposRequisciones.TabIndex = 3
        Me.GroupTiposRequisciones.TabStop = False
        Me.GroupTiposRequisciones.Text = "Agregar Tipos de Requisiciones"
        '
        'label49
        '
        Me.label49.AutoSize = True
        Me.label49.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.label49.Location = New System.Drawing.Point(6, 59)
        Me.label49.Name = "label49"
        Me.label49.Size = New System.Drawing.Size(187, 25)
        Me.label49.TabIndex = 27
        Me.label49.Text = " Tipo de requisición :"
        '
        'txtTypeRequisition
        '
        Me.txtTypeRequisition.BackColor = System.Drawing.Color.Gainsboro
        Me.txtTypeRequisition.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTypeRequisition.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTypeRequisition.Location = New System.Drawing.Point(199, 59)
        Me.txtTypeRequisition.MaxLength = 150
        Me.txtTypeRequisition.Name = "txtTypeRequisition"
        Me.txtTypeRequisition.Size = New System.Drawing.Size(264, 26)
        Me.txtTypeRequisition.TabIndex = 28
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
        Me.cmdCancel.Location = New System.Drawing.Point(327, 120)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(98, 28)
        Me.cmdCancel.TabIndex = 9
        Me.cmdCancel.Text = "Cancelar"
        Me.cmdCancel.UseVisualStyleBackColor = False
        '
        'cmdSaveTipoRequisicion
        '
        Me.cmdSaveTipoRequisicion.BackColor = System.Drawing.Color.Gainsboro
        Me.cmdSaveTipoRequisicion.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdSaveTipoRequisicion.FlatAppearance.BorderSize = 0
        Me.cmdSaveTipoRequisicion.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.cmdSaveTipoRequisicion.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.cmdSaveTipoRequisicion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdSaveTipoRequisicion.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSaveTipoRequisicion.Location = New System.Drawing.Point(199, 120)
        Me.cmdSaveTipoRequisicion.Name = "cmdSaveTipoRequisicion"
        Me.cmdSaveTipoRequisicion.Size = New System.Drawing.Size(98, 28)
        Me.cmdSaveTipoRequisicion.TabIndex = 8
        Me.cmdSaveTipoRequisicion.Text = "Grabar"
        Me.cmdSaveTipoRequisicion.UseVisualStyleBackColor = False
        '
        'ERP_Inventory_Dialog_TypesRequisition
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(522, 201)
        Me.Controls.Add(Me.GroupTiposRequisciones)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ERP_Inventory_Dialog_TypesRequisition"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ERP_Inventory_Dialog_TypesRequisition"
        Me.GroupTiposRequisciones.ResumeLayout(False)
        Me.GroupTiposRequisciones.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupTiposRequisciones As GroupBox
    Private WithEvents cmdCancel As Button
    Private WithEvents cmdSaveTipoRequisicion As Button
    Private WithEvents label49 As Label
    Private WithEvents txtTypeRequisition As TextBox
End Class
