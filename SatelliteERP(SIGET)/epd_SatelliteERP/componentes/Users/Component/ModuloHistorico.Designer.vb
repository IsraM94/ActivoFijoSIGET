<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ModuloHistorico
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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
        Me.tabUsuarios = New System.Windows.Forms.TabControl()
        Me.TagPageUserAccess = New System.Windows.Forms.TabPage()
        Me.TLPCategoriasMantenimientos = New System.Windows.Forms.TableLayoutPanel()
        Me.DG_SystemUsers = New System.Windows.Forms.DataGridView()
        Me.ID_FixedAssets = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Name_FiexdAssets = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Description = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FlowLayoutPanel7 = New System.Windows.Forms.FlowLayoutPanel()
        Me.cmdAccessUsers = New System.Windows.Forms.Button()
        Me.cmdCreateAccessUsers = New System.Windows.Forms.Button()
        Me.cmdModifyUsers = New System.Windows.Forms.Button()
        Me.DeleteUsers = New System.Windows.Forms.Button()
        Me.DeactiveUsers = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.tabUsuarios.SuspendLayout()
        Me.TagPageUserAccess.SuspendLayout()
        Me.TLPCategoriasMantenimientos.SuspendLayout()
        CType(Me.DG_SystemUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel7.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabUsuarios
        '
        Me.tabUsuarios.Controls.Add(Me.TagPageUserAccess)
        Me.tabUsuarios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabUsuarios.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.tabUsuarios.Location = New System.Drawing.Point(0, 0)
        Me.tabUsuarios.Name = "tabUsuarios"
        Me.tabUsuarios.SelectedIndex = 0
        Me.tabUsuarios.Size = New System.Drawing.Size(773, 487)
        Me.tabUsuarios.TabIndex = 1
        '
        'TagPageUserAccess
        '
        Me.TagPageUserAccess.Controls.Add(Me.TLPCategoriasMantenimientos)
        Me.TagPageUserAccess.Location = New System.Drawing.Point(4, 32)
        Me.TagPageUserAccess.Name = "TagPageUserAccess"
        Me.TagPageUserAccess.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.TagPageUserAccess.Size = New System.Drawing.Size(765, 451)
        Me.TagPageUserAccess.TabIndex = 7
        Me.TagPageUserAccess.Text = "Accesos de Usuarios"
        Me.TagPageUserAccess.UseVisualStyleBackColor = True
        '
        'TLPCategoriasMantenimientos
        '
        Me.TLPCategoriasMantenimientos.ColumnCount = 1
        Me.TLPCategoriasMantenimientos.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLPCategoriasMantenimientos.Controls.Add(Me.DG_SystemUsers, 0, 1)
        Me.TLPCategoriasMantenimientos.Controls.Add(Me.FlowLayoutPanel7, 0, 0)
        Me.TLPCategoriasMantenimientos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TLPCategoriasMantenimientos.Location = New System.Drawing.Point(3, 3)
        Me.TLPCategoriasMantenimientos.Name = "TLPCategoriasMantenimientos"
        Me.TLPCategoriasMantenimientos.RowCount = 2
        Me.TLPCategoriasMantenimientos.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75.0!))
        Me.TLPCategoriasMantenimientos.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLPCategoriasMantenimientos.Size = New System.Drawing.Size(759, 445)
        Me.TLPCategoriasMantenimientos.TabIndex = 6
        '
        'DG_SystemUsers
        '
        Me.DG_SystemUsers.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DG_SystemUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_SystemUsers.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID_FixedAssets, Me.Name_FiexdAssets, Me.Description})
        Me.DG_SystemUsers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DG_SystemUsers.EnableHeadersVisualStyles = False
        Me.DG_SystemUsers.Location = New System.Drawing.Point(3, 78)
        Me.DG_SystemUsers.Name = "DG_SystemUsers"
        Me.DG_SystemUsers.ShowCellErrors = False
        Me.DG_SystemUsers.ShowCellToolTips = False
        Me.DG_SystemUsers.ShowEditingIcon = False
        Me.DG_SystemUsers.ShowRowErrors = False
        Me.DG_SystemUsers.Size = New System.Drawing.Size(753, 364)
        Me.DG_SystemUsers.TabIndex = 0
        '
        'ID_FixedAssets
        '
        Me.ID_FixedAssets.DataPropertyName = "ID_FixedAssets"
        Me.ID_FixedAssets.HeaderText = "ID_FixedAssets"
        Me.ID_FixedAssets.Name = "ID_FixedAssets"
        '
        'Name_FiexdAssets
        '
        Me.Name_FiexdAssets.DataPropertyName = "Name_FiexdAssets"
        Me.Name_FiexdAssets.HeaderText = "Name_FiexdAssets"
        Me.Name_FiexdAssets.Name = "Name_FiexdAssets"
        '
        'Description
        '
        Me.Description.DataPropertyName = "Description"
        Me.Description.HeaderText = "Description"
        Me.Description.Name = "Description"
        '
        'FlowLayoutPanel7
        '
        Me.FlowLayoutPanel7.Controls.Add(Me.cmdAccessUsers)
        Me.FlowLayoutPanel7.Controls.Add(Me.cmdCreateAccessUsers)
        Me.FlowLayoutPanel7.Controls.Add(Me.cmdModifyUsers)
        Me.FlowLayoutPanel7.Controls.Add(Me.DeleteUsers)
        Me.FlowLayoutPanel7.Controls.Add(Me.DeactiveUsers)
        Me.FlowLayoutPanel7.Controls.Add(Me.DateTimePicker1)
        Me.FlowLayoutPanel7.Controls.Add(Me.DateTimePicker2)
        Me.FlowLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel7.Location = New System.Drawing.Point(3, 3)
        Me.FlowLayoutPanel7.Name = "FlowLayoutPanel7"
        Me.FlowLayoutPanel7.Size = New System.Drawing.Size(753, 69)
        Me.FlowLayoutPanel7.TabIndex = 1
        '
        'cmdAccessUsers
        '
        Me.cmdAccessUsers.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.cmdAccessUsers.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdAccessUsers.FlatAppearance.BorderSize = 0
        Me.cmdAccessUsers.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdAccessUsers.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdAccessUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAccessUsers.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAccessUsers.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmdAccessUsers.Location = New System.Drawing.Point(3, 3)
        Me.cmdAccessUsers.Name = "cmdAccessUsers"
        Me.cmdAccessUsers.Size = New System.Drawing.Size(108, 66)
        Me.cmdAccessUsers.TabIndex = 30
        Me.cmdAccessUsers.Text = "Ver Nuevos"
        Me.cmdAccessUsers.UseVisualStyleBackColor = False
        '
        'cmdCreateAccessUsers
        '
        Me.cmdCreateAccessUsers.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.cmdCreateAccessUsers.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdCreateAccessUsers.FlatAppearance.BorderSize = 0
        Me.cmdCreateAccessUsers.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdCreateAccessUsers.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdCreateAccessUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCreateAccessUsers.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCreateAccessUsers.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmdCreateAccessUsers.Location = New System.Drawing.Point(117, 3)
        Me.cmdCreateAccessUsers.Name = "cmdCreateAccessUsers"
        Me.cmdCreateAccessUsers.Size = New System.Drawing.Size(108, 66)
        Me.cmdCreateAccessUsers.TabIndex = 30
        Me.cmdCreateAccessUsers.Text = "Agregar Usuarios"
        Me.cmdCreateAccessUsers.UseVisualStyleBackColor = False
        '
        'cmdModifyUsers
        '
        Me.cmdModifyUsers.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.cmdModifyUsers.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdModifyUsers.FlatAppearance.BorderSize = 0
        Me.cmdModifyUsers.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdModifyUsers.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdModifyUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdModifyUsers.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdModifyUsers.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmdModifyUsers.Location = New System.Drawing.Point(231, 3)
        Me.cmdModifyUsers.Name = "cmdModifyUsers"
        Me.cmdModifyUsers.Size = New System.Drawing.Size(108, 66)
        Me.cmdModifyUsers.TabIndex = 30
        Me.cmdModifyUsers.Text = "Modificar Usuario"
        Me.cmdModifyUsers.UseVisualStyleBackColor = False
        '
        'DeleteUsers
        '
        Me.DeleteUsers.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.DeleteUsers.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.DeleteUsers.FlatAppearance.BorderSize = 0
        Me.DeleteUsers.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.DeleteUsers.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.DeleteUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DeleteUsers.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteUsers.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DeleteUsers.Location = New System.Drawing.Point(345, 3)
        Me.DeleteUsers.Name = "DeleteUsers"
        Me.DeleteUsers.Size = New System.Drawing.Size(108, 66)
        Me.DeleteUsers.TabIndex = 30
        Me.DeleteUsers.Text = "Eliminar Usuario"
        Me.DeleteUsers.UseVisualStyleBackColor = False
        '
        'DeactiveUsers
        '
        Me.DeactiveUsers.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.DeactiveUsers.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.DeactiveUsers.FlatAppearance.BorderSize = 0
        Me.DeactiveUsers.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.DeactiveUsers.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.DeactiveUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DeactiveUsers.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeactiveUsers.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DeactiveUsers.Location = New System.Drawing.Point(459, 3)
        Me.DeactiveUsers.Name = "DeactiveUsers"
        Me.DeactiveUsers.Size = New System.Drawing.Size(108, 66)
        Me.DeactiveUsers.TabIndex = 30
        Me.DeactiveUsers.Text = "Desactivar Usuario"
        Me.DeactiveUsers.UseVisualStyleBackColor = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(572, 2)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(151, 31)
        Me.DateTimePicker1.TabIndex = 31
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(2, 74)
        Me.DateTimePicker2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(151, 31)
        Me.DateTimePicker2.TabIndex = 32
        '
        'ModuloHistorico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.tabUsuarios)
        Me.Name = "ModuloHistorico"
        Me.Size = New System.Drawing.Size(773, 487)
        Me.tabUsuarios.ResumeLayout(False)
        Me.TagPageUserAccess.ResumeLayout(False)
        Me.TLPCategoriasMantenimientos.ResumeLayout(False)
        CType(Me.DG_SystemUsers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel7.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tabUsuarios As TabControl
    Friend WithEvents TagPageUserAccess As TabPage
    Friend WithEvents TLPCategoriasMantenimientos As TableLayoutPanel
    Friend WithEvents DG_SystemUsers As DataGridView
    Friend WithEvents FlowLayoutPanel7 As FlowLayoutPanel
    Private WithEvents cmdAccessUsers As Button
    Private WithEvents cmdCreateAccessUsers As Button
    Private WithEvents cmdModifyUsers As Button
    Private WithEvents DeleteUsers As Button
    Private WithEvents DeactiveUsers As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents ID_FixedAssets As DataGridViewTextBoxColumn
    Friend WithEvents Name_FiexdAssets As DataGridViewTextBoxColumn
    Friend WithEvents Description As DataGridViewTextBoxColumn
End Class
