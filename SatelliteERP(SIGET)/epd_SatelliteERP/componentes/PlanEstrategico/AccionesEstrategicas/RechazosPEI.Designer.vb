<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RechazosPEI
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
        Me.components = New System.ComponentModel.Container()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.DG_Rechazos = New System.Windows.Forms.DataGridView()
        Me.FechaRechazo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Motivo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Usuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CMSCreditLine = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.NuevaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActualizarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.DG_Rechazos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CMSCreditLine.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
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
        Me.cmdCancel.Location = New System.Drawing.Point(784, 379)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(98, 28)
        Me.cmdCancel.TabIndex = 4
        Me.cmdCancel.Text = "Cerrar"
        Me.cmdCancel.UseVisualStyleBackColor = False
        '
        'DG_Rechazos
        '
        Me.DG_Rechazos.AllowUserToAddRows = False
        Me.DG_Rechazos.AllowUserToDeleteRows = False
        Me.DG_Rechazos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_Rechazos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FechaRechazo, Me.Motivo, Me.Usuario})
        Me.DG_Rechazos.Location = New System.Drawing.Point(6, 32)
        Me.DG_Rechazos.Name = "DG_Rechazos"
        Me.DG_Rechazos.ReadOnly = True
        Me.DG_Rechazos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_Rechazos.Size = New System.Drawing.Size(876, 341)
        Me.DG_Rechazos.TabIndex = 30
        '
        'FechaRechazo
        '
        Me.FechaRechazo.DataPropertyName = "Fecha"
        Me.FechaRechazo.HeaderText = "Fecha de Observación"
        Me.FechaRechazo.Name = "FechaRechazo"
        Me.FechaRechazo.ReadOnly = True
        Me.FechaRechazo.Width = 200
        '
        'Motivo
        '
        Me.Motivo.DataPropertyName = "Observation"
        Me.Motivo.HeaderText = "Observación"
        Me.Motivo.Name = "Motivo"
        Me.Motivo.ReadOnly = True
        Me.Motivo.Width = 500
        '
        'Usuario
        '
        Me.Usuario.DataPropertyName = "Responsable"
        Me.Usuario.HeaderText = "Responsable"
        Me.Usuario.Name = "Usuario"
        Me.Usuario.ReadOnly = True
        Me.Usuario.Width = 150
        '
        'CMSCreditLine
        '
        Me.CMSCreditLine.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevaToolStripMenuItem, Me.ActualizarToolStripMenuItem, Me.EliminarToolStripMenuItem})
        Me.CMSCreditLine.Name = "CMSCreditLine"
        Me.CMSCreditLine.Size = New System.Drawing.Size(126, 70)
        '
        'NuevaToolStripMenuItem
        '
        Me.NuevaToolStripMenuItem.Name = "NuevaToolStripMenuItem"
        Me.NuevaToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.NuevaToolStripMenuItem.Text = "Nueva"
        '
        'ActualizarToolStripMenuItem
        '
        Me.ActualizarToolStripMenuItem.Name = "ActualizarToolStripMenuItem"
        Me.ActualizarToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.ActualizarToolStripMenuItem.Text = "Modificar"
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.DG_Rechazos)
        Me.GroupBox1.Controls.Add(Me.cmdCancel)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 11)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(888, 423)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Historial de Motivos de Observaciones PEI"
        '
        'RechazosPEI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CadetBlue
        Me.ClientSize = New System.Drawing.Size(912, 448)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "RechazosPEI"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ERP_CreditLine"
        CType(Me.DG_Rechazos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CMSCreditLine.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents cmdCancel As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CMSCreditLine As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents NuevaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ActualizarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DG_Rechazos As DataGridView
    Friend WithEvents FechaRechazo As DataGridViewTextBoxColumn
    Friend WithEvents Motivo As DataGridViewTextBoxColumn
    Friend WithEvents Usuario As DataGridViewTextBoxColumn
End Class
