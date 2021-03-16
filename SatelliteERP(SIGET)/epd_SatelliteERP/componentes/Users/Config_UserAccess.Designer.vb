<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Config_UserAccess
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
        Me.GroupBoxEmployee = New System.Windows.Forms.GroupBox()
        Me.txt_ConfigAccess_BuscarUsuario = New System.Windows.Forms.TextBox()
        Me.dgvCreditLine = New System.Windows.Forms.DataGridView()
        Me.id_AccessUser = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_Config_FK = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Is_Active = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.CMSCreditLine = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.NuevaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActualizarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBoxEmployee.SuspendLayout()
        CType(Me.dgvCreditLine, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.cmdCancel.Location = New System.Drawing.Point(468, 455)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(98, 28)
        Me.cmdCancel.TabIndex = 4
        Me.cmdCancel.Text = "Cancelar"
        Me.cmdCancel.UseVisualStyleBackColor = False
        '
        'GroupBoxEmployee
        '
        Me.GroupBoxEmployee.Controls.Add(Me.txt_ConfigAccess_BuscarUsuario)
        Me.GroupBoxEmployee.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxEmployee.Location = New System.Drawing.Point(20, 32)
        Me.GroupBoxEmployee.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBoxEmployee.Name = "GroupBoxEmployee"
        Me.GroupBoxEmployee.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBoxEmployee.Size = New System.Drawing.Size(546, 104)
        Me.GroupBoxEmployee.TabIndex = 0
        Me.GroupBoxEmployee.TabStop = False
        Me.GroupBoxEmployee.Text = "Datos Usuario"
        '
        'txt_ConfigAccess_BuscarUsuario
        '
        Me.txt_ConfigAccess_BuscarUsuario.Enabled = False
        Me.txt_ConfigAccess_BuscarUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ConfigAccess_BuscarUsuario.Location = New System.Drawing.Point(47, 53)
        Me.txt_ConfigAccess_BuscarUsuario.Name = "txt_ConfigAccess_BuscarUsuario"
        Me.txt_ConfigAccess_BuscarUsuario.Size = New System.Drawing.Size(365, 24)
        Me.txt_ConfigAccess_BuscarUsuario.TabIndex = 5
        '
        'dgvCreditLine
        '
        Me.dgvCreditLine.AllowUserToAddRows = False
        Me.dgvCreditLine.AllowUserToDeleteRows = False
        Me.dgvCreditLine.ColumnHeadersHeight = 35
        Me.dgvCreditLine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvCreditLine.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_AccessUser, Me.id_Config_FK, Me.nombre, Me.Is_Active})
        Me.dgvCreditLine.ContextMenuStrip = Me.CMSCreditLine
        Me.dgvCreditLine.Location = New System.Drawing.Point(20, 153)
        Me.dgvCreditLine.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvCreditLine.MultiSelect = False
        Me.dgvCreditLine.Name = "dgvCreditLine"
        Me.dgvCreditLine.RowTemplate.Height = 24
        Me.dgvCreditLine.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCreditLine.Size = New System.Drawing.Size(546, 292)
        Me.dgvCreditLine.TabIndex = 0
        '
        'id_AccessUser
        '
        Me.id_AccessUser.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.id_AccessUser.DataPropertyName = "id_Access"
        Me.id_AccessUser.HeaderText = "Correlativo"
        Me.id_AccessUser.Name = "id_AccessUser"
        Me.id_AccessUser.ReadOnly = True
        Me.id_AccessUser.Width = 136
        '
        'id_Config_FK
        '
        Me.id_Config_FK.DataPropertyName = "id_Config_FK"
        Me.id_Config_FK.HeaderText = "id"
        Me.id_Config_FK.Name = "id_Config_FK"
        Me.id_Config_FK.ReadOnly = True
        Me.id_Config_FK.Visible = False
        Me.id_Config_FK.Width = 40
        '
        'nombre
        '
        Me.nombre.DataPropertyName = "nombre"
        Me.nombre.HeaderText = "Nombre"
        Me.nombre.Name = "nombre"
        Me.nombre.ReadOnly = True
        Me.nombre.Width = 190
        '
        'Is_Active
        '
        Me.Is_Active.DataPropertyName = "Is_Active"
        Me.Is_Active.HeaderText = "Activo"
        Me.Is_Active.Name = "Is_Active"
        Me.Is_Active.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Is_Active.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Is_Active.Width = 177
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
        Me.GroupBox1.Controls.Add(Me.dgvCreditLine)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.GroupBoxEmployee)
        Me.GroupBox1.Controls.Add(Me.cmdCancel)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 11)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(584, 489)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Configuración Accesos por Usuario"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(368, 455)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 28)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Modificar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Config_UserAccess
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(612, 512)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Config_UserAccess"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ERP_CreditLine"
        Me.GroupBoxEmployee.ResumeLayout(False)
        Me.GroupBoxEmployee.PerformLayout()
        CType(Me.dgvCreditLine, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CMSCreditLine.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents cmdCancel As Button
    Friend WithEvents GroupBoxEmployee As GroupBox
    Friend WithEvents dgvCreditLine As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CMSCreditLine As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents NuevaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ActualizarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txt_ConfigAccess_BuscarUsuario As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents id_AccessUser As DataGridViewTextBoxColumn
    Friend WithEvents id_Config_FK As DataGridViewTextBoxColumn
    Friend WithEvents nombre As DataGridViewTextBoxColumn
    Friend WithEvents Is_Active As DataGridViewCheckBoxColumn
End Class
