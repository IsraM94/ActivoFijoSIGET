<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MatrizProcesoEjes
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
        Me.DG_BuscarEjes = New System.Windows.Forms.DataGridView()
        Me.lblValor = New System.Windows.Forms.Label()
        Me.txt_Buscar = New System.Windows.Forms.TextBox()
        Me.CMSCreditLine = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.NuevaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActualizarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnGrabar = New System.Windows.Forms.Button()
        Me.IdE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodeAxesF = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameEjes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupDatosUsuario.SuspendLayout()
        CType(Me.DG_BuscarEjes, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.cmdCancel.Location = New System.Drawing.Point(617, 447)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(98, 28)
        Me.cmdCancel.TabIndex = 4
        Me.cmdCancel.Text = "Cerrar"
        Me.cmdCancel.UseVisualStyleBackColor = False
        '
        'GroupDatosUsuario
        '
        Me.GroupDatosUsuario.Controls.Add(Me.DG_BuscarEjes)
        Me.GroupDatosUsuario.Controls.Add(Me.lblValor)
        Me.GroupDatosUsuario.Controls.Add(Me.txt_Buscar)
        Me.GroupDatosUsuario.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupDatosUsuario.Location = New System.Drawing.Point(20, 32)
        Me.GroupDatosUsuario.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupDatosUsuario.Name = "GroupDatosUsuario"
        Me.GroupDatosUsuario.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupDatosUsuario.Size = New System.Drawing.Size(744, 400)
        Me.GroupDatosUsuario.TabIndex = 0
        Me.GroupDatosUsuario.TabStop = False
        Me.GroupDatosUsuario.Text = "Datos Proceso Eje"
        '
        'DG_BuscarEjes
        '
        Me.DG_BuscarEjes.AllowUserToAddRows = False
        Me.DG_BuscarEjes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_BuscarEjes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdE, Me.CodeAxesF, Me.NameEjes})
        Me.DG_BuscarEjes.Location = New System.Drawing.Point(16, 119)
        Me.DG_BuscarEjes.Name = "DG_BuscarEjes"
        Me.DG_BuscarEjes.ReadOnly = True
        Me.DG_BuscarEjes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_BuscarEjes.Size = New System.Drawing.Size(698, 247)
        Me.DG_BuscarEjes.TabIndex = 30
        '
        'lblValor
        '
        Me.lblValor.AutoSize = True
        Me.lblValor.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.lblValor.Location = New System.Drawing.Point(11, 42)
        Me.lblValor.Name = "lblValor"
        Me.lblValor.Size = New System.Drawing.Size(68, 25)
        Me.lblValor.TabIndex = 29
        Me.lblValor.Text = "Buscar"
        '
        'txt_Buscar
        '
        Me.txt_Buscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Buscar.Location = New System.Drawing.Point(149, 39)
        Me.txt_Buscar.MaxLength = 150
        Me.txt_Buscar.Name = "txt_Buscar"
        Me.txt_Buscar.Size = New System.Drawing.Size(350, 31)
        Me.txt_Buscar.TabIndex = 28
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
        Me.GroupBox1.Size = New System.Drawing.Size(779, 481)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Proceso Eje"
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
        Me.btnGrabar.Location = New System.Drawing.Point(499, 447)
        Me.btnGrabar.Name = "btnGrabar"
        Me.btnGrabar.Size = New System.Drawing.Size(98, 28)
        Me.btnGrabar.TabIndex = 4
        Me.btnGrabar.Text = "Seleccionar"
        Me.btnGrabar.UseVisualStyleBackColor = False
        '
        'IdE
        '
        Me.IdE.DataPropertyName = "ID_StrategicAxes"
        Me.IdE.HeaderText = "Id"
        Me.IdE.Name = "IdE"
        Me.IdE.ReadOnly = True
        Me.IdE.Visible = False
        '
        'CodeAxesF
        '
        Me.CodeAxesF.DataPropertyName = "codeAxes"
        Me.CodeAxesF.HeaderText = "Codigo"
        Me.CodeAxesF.Name = "CodeAxesF"
        Me.CodeAxesF.ReadOnly = True
        '
        'NameEjes
        '
        Me.NameEjes.DataPropertyName = "Name"
        Me.NameEjes.HeaderText = "Ejes Estratégicos "
        Me.NameEjes.Name = "NameEjes"
        Me.NameEjes.ReadOnly = True
        Me.NameEjes.Width = 400
        '
        'MatrizProcesoEjes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CadetBlue
        Me.ClientSize = New System.Drawing.Size(803, 503)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "MatrizProcesoEjes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ERP_CreditLine"
        Me.GroupDatosUsuario.ResumeLayout(False)
        Me.GroupDatosUsuario.PerformLayout()
        CType(Me.DG_BuscarEjes, System.ComponentModel.ISupportInitialize).EndInit()
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
    Private WithEvents lblValor As Label
    Friend WithEvents txt_Buscar As TextBox
    Friend WithEvents DG_BuscarEjes As DataGridView
    Friend WithEvents IdE As DataGridViewTextBoxColumn
    Friend WithEvents CodeAxesF As DataGridViewTextBoxColumn
    Friend WithEvents NameEjes As DataGridViewTextBoxColumn
End Class
