<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PorcentajeAccionesEstrategicasDirecto
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
        Me.GroupDatosUsuario = New System.Windows.Forms.GroupBox()
        Me.DG_Acciones = New System.Windows.Forms.DataGridView()
        Me.CMSCreditLine = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.NuevaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActualizarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnGrabar = New System.Windows.Forms.Button()
        Me.Id_AccionP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Id_Result = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Anio1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Anio2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Anio3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Anio4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Anio5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupDatosUsuario.SuspendLayout()
        CType(Me.DG_Acciones, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.cmdCancel.Location = New System.Drawing.Point(726, 447)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(98, 28)
        Me.cmdCancel.TabIndex = 4
        Me.cmdCancel.Text = "Cerrar"
        Me.cmdCancel.UseVisualStyleBackColor = False
        '
        'GroupDatosUsuario
        '
        Me.GroupDatosUsuario.Controls.Add(Me.DG_Acciones)
        Me.GroupDatosUsuario.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupDatosUsuario.Location = New System.Drawing.Point(16, 32)
        Me.GroupDatosUsuario.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupDatosUsuario.Name = "GroupDatosUsuario"
        Me.GroupDatosUsuario.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupDatosUsuario.Size = New System.Drawing.Size(816, 400)
        Me.GroupDatosUsuario.TabIndex = 0
        Me.GroupDatosUsuario.TabStop = False
        Me.GroupDatosUsuario.Text = "Porcentaje Correspondiente"
        '
        'DG_Acciones
        '
        Me.DG_Acciones.AllowUserToAddRows = False
        Me.DG_Acciones.AllowUserToDeleteRows = False
        Me.DG_Acciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_Acciones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id_AccionP, Me.Id_Result, Me.Anio1, Me.Anio2, Me.Anio3, Me.Anio4, Me.Anio5})
        Me.DG_Acciones.Location = New System.Drawing.Point(10, 42)
        Me.DG_Acciones.Name = "DG_Acciones"
        Me.DG_Acciones.Size = New System.Drawing.Size(795, 340)
        Me.DG_Acciones.TabIndex = 30
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
        Me.GroupBox1.Controls.Add(Me.GroupDatosUsuario)
        Me.GroupBox1.Controls.Add(Me.btnGrabar)
        Me.GroupBox1.Controls.Add(Me.cmdCancel)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 11)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(845, 481)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Acciones Estrategicas"
        '
        'btnGrabar
        '
        Me.btnGrabar.BackColor = System.Drawing.Color.Gainsboro
        Me.btnGrabar.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.btnGrabar.FlatAppearance.BorderSize = 0
        Me.btnGrabar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.btnGrabar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.btnGrabar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGrabar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGrabar.Location = New System.Drawing.Point(555, 447)
        Me.btnGrabar.Name = "btnGrabar"
        Me.btnGrabar.Size = New System.Drawing.Size(151, 28)
        Me.btnGrabar.TabIndex = 4
        Me.btnGrabar.Text = "Guardar y Cerrar"
        Me.btnGrabar.UseVisualStyleBackColor = False
        '
        'Id_AccionP
        '
        Me.Id_AccionP.DataPropertyName = "Id_A"
        Me.Id_AccionP.HeaderText = ""
        Me.Id_AccionP.Name = "Id_AccionP"
        Me.Id_AccionP.Visible = False
        '
        'Id_Result
        '
        Me.Id_Result.DataPropertyName = "Id_Result"
        Me.Id_Result.HeaderText = ""
        Me.Id_Result.Name = "Id_Result"
        Me.Id_Result.Visible = False
        '
        'Anio1
        '
        Me.Anio1.DataPropertyName = "Anio1"
        Me.Anio1.HeaderText = "Año 1"
        Me.Anio1.Name = "Anio1"
        Me.Anio1.Width = 150
        '
        'Anio2
        '
        Me.Anio2.DataPropertyName = "Anio2"
        Me.Anio2.HeaderText = "Año 2"
        Me.Anio2.Name = "Anio2"
        Me.Anio2.Width = 150
        '
        'Anio3
        '
        Me.Anio3.DataPropertyName = "Anio3"
        Me.Anio3.HeaderText = "Año 3"
        Me.Anio3.Name = "Anio3"
        Me.Anio3.Width = 150
        '
        'Anio4
        '
        Me.Anio4.DataPropertyName = "Anio4"
        Me.Anio4.HeaderText = "Año 4"
        Me.Anio4.Name = "Anio4"
        Me.Anio4.Width = 150
        '
        'Anio5
        '
        Me.Anio5.DataPropertyName = "Anio5"
        Me.Anio5.HeaderText = "Año 5"
        Me.Anio5.Name = "Anio5"
        Me.Anio5.Width = 150
        '
        'PorcentajeAccionesEstrategicasDirecto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CadetBlue
        Me.ClientSize = New System.Drawing.Size(866, 503)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "PorcentajeAccionesEstrategicasDirecto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ERP_CreditLine"
        Me.GroupDatosUsuario.ResumeLayout(False)
        CType(Me.DG_Acciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CMSCreditLine.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents cmdCancel As Button
    Friend WithEvents GroupDatosUsuario As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CMSCreditLine As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents NuevaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ActualizarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents btnGrabar As Button
    Friend WithEvents DG_Acciones As DataGridView
    Friend WithEvents Id_AccionP As DataGridViewTextBoxColumn
    Friend WithEvents Id_Result As DataGridViewTextBoxColumn
    Friend WithEvents Anio1 As DataGridViewTextBoxColumn
    Friend WithEvents Anio2 As DataGridViewTextBoxColumn
    Friend WithEvents Anio3 As DataGridViewTextBoxColumn
    Friend WithEvents Anio4 As DataGridViewTextBoxColumn
    Friend WithEvents Anio5 As DataGridViewTextBoxColumn
End Class
