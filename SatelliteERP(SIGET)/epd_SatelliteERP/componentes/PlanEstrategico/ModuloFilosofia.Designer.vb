<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ModuloFilosofia
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
        Me.tabPlanificacion = New System.Windows.Forms.TabControl()
        Me.TabPageFilosofiaInstitucional = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel8 = New System.Windows.Forms.TableLayoutPanel()
        Me.DG_Filosofia = New System.Windows.Forms.DataGridView()
        Me.ID_InstitutionalPhilosophy = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Mision = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Vision = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Valores = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn57 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn58 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn59 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn60 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn61 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn62 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FlowLayoutPanel10 = New System.Windows.Forms.FlowLayoutPanel()
        Me.cmdVerFilosofiaInstitucional = New System.Windows.Forms.Button()
        Me.cmdAgregarFilosofiaInstitucional = New System.Windows.Forms.Button()
        Me.cmdModificarFilosofiaInstitucional = New System.Windows.Forms.Button()
        Me.cmdEliminarFilosofiaInstitucional = New System.Windows.Forms.Button()
        Me.tabPlanificacion.SuspendLayout()
        Me.TabPageFilosofiaInstitucional.SuspendLayout()
        Me.TableLayoutPanel8.SuspendLayout()
        CType(Me.DG_Filosofia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel10.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabPlanificacion
        '
        Me.tabPlanificacion.Controls.Add(Me.TabPageFilosofiaInstitucional)
        Me.tabPlanificacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabPlanificacion.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.tabPlanificacion.Location = New System.Drawing.Point(0, 0)
        Me.tabPlanificacion.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tabPlanificacion.Name = "tabPlanificacion"
        Me.tabPlanificacion.SelectedIndex = 0
        Me.tabPlanificacion.Size = New System.Drawing.Size(1031, 599)
        Me.tabPlanificacion.TabIndex = 1
        '
        'TabPageFilosofiaInstitucional
        '
        Me.TabPageFilosofiaInstitucional.Controls.Add(Me.TableLayoutPanel8)
        Me.TabPageFilosofiaInstitucional.Location = New System.Drawing.Point(4, 39)
        Me.TabPageFilosofiaInstitucional.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabPageFilosofiaInstitucional.Name = "TabPageFilosofiaInstitucional"
        Me.TabPageFilosofiaInstitucional.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabPageFilosofiaInstitucional.Size = New System.Drawing.Size(1023, 556)
        Me.TabPageFilosofiaInstitucional.TabIndex = 16
        Me.TabPageFilosofiaInstitucional.Text = "Filosofía Institucional"
        Me.TabPageFilosofiaInstitucional.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel8
        '
        Me.TableLayoutPanel8.ColumnCount = 1
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel8.Controls.Add(Me.DG_Filosofia, 0, 1)
        Me.TableLayoutPanel8.Controls.Add(Me.FlowLayoutPanel10, 0, 0)
        Me.TableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel8.Location = New System.Drawing.Point(4, 4)
        Me.TableLayoutPanel8.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TableLayoutPanel8.Name = "TableLayoutPanel8"
        Me.TableLayoutPanel8.RowCount = 2
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 92.0!))
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel8.Size = New System.Drawing.Size(1015, 548)
        Me.TableLayoutPanel8.TabIndex = 13
        '
        'DG_Filosofia
        '
        Me.DG_Filosofia.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DG_Filosofia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_Filosofia.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID_InstitutionalPhilosophy, Me.Mision, Me.Vision, Me.Valores, Me.DataGridViewTextBoxColumn57, Me.DataGridViewTextBoxColumn58, Me.DataGridViewTextBoxColumn59, Me.DataGridViewTextBoxColumn60, Me.DataGridViewTextBoxColumn61, Me.DataGridViewTextBoxColumn62})
        Me.DG_Filosofia.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DG_Filosofia.EnableHeadersVisualStyles = False
        Me.DG_Filosofia.Location = New System.Drawing.Point(4, 96)
        Me.DG_Filosofia.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DG_Filosofia.Name = "DG_Filosofia"
        Me.DG_Filosofia.ShowCellErrors = False
        Me.DG_Filosofia.ShowCellToolTips = False
        Me.DG_Filosofia.ShowEditingIcon = False
        Me.DG_Filosofia.ShowRowErrors = False
        Me.DG_Filosofia.Size = New System.Drawing.Size(1007, 448)
        Me.DG_Filosofia.TabIndex = 0
        '
        'ID_InstitutionalPhilosophy
        '
        Me.ID_InstitutionalPhilosophy.DataPropertyName = "ID_InstitutionalPhilosophy"
        Me.ID_InstitutionalPhilosophy.HeaderText = "ID"
        Me.ID_InstitutionalPhilosophy.Name = "ID_InstitutionalPhilosophy"
        Me.ID_InstitutionalPhilosophy.Width = 89
        '
        'Mision
        '
        Me.Mision.DataPropertyName = "Mision"
        Me.Mision.HeaderText = "Misión"
        Me.Mision.Name = "Mision"
        Me.Mision.Width = 89
        '
        'Vision
        '
        Me.Vision.DataPropertyName = "Vision"
        Me.Vision.HeaderText = "Visión"
        Me.Vision.Name = "Vision"
        '
        'Valores
        '
        Me.Valores.DataPropertyName = "Valores"
        Me.Valores.HeaderText = "Valores"
        Me.Valores.Name = "Valores"
        '
        'DataGridViewTextBoxColumn57
        '
        Me.DataGridViewTextBoxColumn57.DataPropertyName = "UsersCreate"
        Me.DataGridViewTextBoxColumn57.HeaderText = "Usuario Creo"
        Me.DataGridViewTextBoxColumn57.Name = "DataGridViewTextBoxColumn57"
        Me.DataGridViewTextBoxColumn57.Width = 89
        '
        'DataGridViewTextBoxColumn58
        '
        Me.DataGridViewTextBoxColumn58.DataPropertyName = "DateCreate"
        Me.DataGridViewTextBoxColumn58.HeaderText = "Fecha Creo"
        Me.DataGridViewTextBoxColumn58.Name = "DataGridViewTextBoxColumn58"
        Me.DataGridViewTextBoxColumn58.Width = 89
        '
        'DataGridViewTextBoxColumn59
        '
        Me.DataGridViewTextBoxColumn59.DataPropertyName = "UsersModify"
        Me.DataGridViewTextBoxColumn59.HeaderText = "Usuario Mod."
        Me.DataGridViewTextBoxColumn59.Name = "DataGridViewTextBoxColumn59"
        '
        'DataGridViewTextBoxColumn60
        '
        Me.DataGridViewTextBoxColumn60.DataPropertyName = "DateModify"
        Me.DataGridViewTextBoxColumn60.HeaderText = "Fecha Mod."
        Me.DataGridViewTextBoxColumn60.Name = "DataGridViewTextBoxColumn60"
        '
        'DataGridViewTextBoxColumn61
        '
        Me.DataGridViewTextBoxColumn61.HeaderText = "id_Company_FK"
        Me.DataGridViewTextBoxColumn61.Name = "DataGridViewTextBoxColumn61"
        Me.DataGridViewTextBoxColumn61.Visible = False
        '
        'DataGridViewTextBoxColumn62
        '
        Me.DataGridViewTextBoxColumn62.DataPropertyName = "estado"
        Me.DataGridViewTextBoxColumn62.HeaderText = "Estado"
        Me.DataGridViewTextBoxColumn62.Name = "DataGridViewTextBoxColumn62"
        '
        'FlowLayoutPanel10
        '
        Me.FlowLayoutPanel10.Controls.Add(Me.cmdVerFilosofiaInstitucional)
        Me.FlowLayoutPanel10.Controls.Add(Me.cmdAgregarFilosofiaInstitucional)
        Me.FlowLayoutPanel10.Controls.Add(Me.cmdModificarFilosofiaInstitucional)
        Me.FlowLayoutPanel10.Controls.Add(Me.cmdEliminarFilosofiaInstitucional)
        Me.FlowLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel10.Location = New System.Drawing.Point(4, 4)
        Me.FlowLayoutPanel10.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.FlowLayoutPanel10.Name = "FlowLayoutPanel10"
        Me.FlowLayoutPanel10.Size = New System.Drawing.Size(1007, 84)
        Me.FlowLayoutPanel10.TabIndex = 1
        '
        'cmdVerFilosofiaInstitucional
        '
        Me.cmdVerFilosofiaInstitucional.BackColor = System.Drawing.Color.Gainsboro
        Me.cmdVerFilosofiaInstitucional.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdVerFilosofiaInstitucional.FlatAppearance.BorderSize = 0
        Me.cmdVerFilosofiaInstitucional.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.cmdVerFilosofiaInstitucional.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.cmdVerFilosofiaInstitucional.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdVerFilosofiaInstitucional.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdVerFilosofiaInstitucional.Location = New System.Drawing.Point(4, 4)
        Me.cmdVerFilosofiaInstitucional.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdVerFilosofiaInstitucional.Name = "cmdVerFilosofiaInstitucional"
        Me.cmdVerFilosofiaInstitucional.Size = New System.Drawing.Size(144, 81)
        Me.cmdVerFilosofiaInstitucional.TabIndex = 30
        Me.cmdVerFilosofiaInstitucional.Text = "Ver Filosofía Institucional"
        Me.cmdVerFilosofiaInstitucional.UseVisualStyleBackColor = False
        Me.cmdVerFilosofiaInstitucional.Visible = False
        '
        'cmdAgregarFilosofiaInstitucional
        '
        Me.cmdAgregarFilosofiaInstitucional.BackColor = System.Drawing.Color.Gainsboro
        Me.cmdAgregarFilosofiaInstitucional.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdAgregarFilosofiaInstitucional.FlatAppearance.BorderSize = 0
        Me.cmdAgregarFilosofiaInstitucional.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.cmdAgregarFilosofiaInstitucional.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.cmdAgregarFilosofiaInstitucional.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAgregarFilosofiaInstitucional.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAgregarFilosofiaInstitucional.Location = New System.Drawing.Point(156, 4)
        Me.cmdAgregarFilosofiaInstitucional.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdAgregarFilosofiaInstitucional.Name = "cmdAgregarFilosofiaInstitucional"
        Me.cmdAgregarFilosofiaInstitucional.Size = New System.Drawing.Size(191, 81)
        Me.cmdAgregarFilosofiaInstitucional.TabIndex = 30
        Me.cmdAgregarFilosofiaInstitucional.Text = "Agregar Filosofía Institucional"
        Me.cmdAgregarFilosofiaInstitucional.UseVisualStyleBackColor = False
        Me.cmdAgregarFilosofiaInstitucional.Visible = False
        '
        'cmdModificarFilosofiaInstitucional
        '
        Me.cmdModificarFilosofiaInstitucional.BackColor = System.Drawing.Color.Gainsboro
        Me.cmdModificarFilosofiaInstitucional.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdModificarFilosofiaInstitucional.FlatAppearance.BorderSize = 0
        Me.cmdModificarFilosofiaInstitucional.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.cmdModificarFilosofiaInstitucional.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.cmdModificarFilosofiaInstitucional.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdModificarFilosofiaInstitucional.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdModificarFilosofiaInstitucional.Location = New System.Drawing.Point(355, 4)
        Me.cmdModificarFilosofiaInstitucional.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdModificarFilosofiaInstitucional.Name = "cmdModificarFilosofiaInstitucional"
        Me.cmdModificarFilosofiaInstitucional.Size = New System.Drawing.Size(201, 81)
        Me.cmdModificarFilosofiaInstitucional.TabIndex = 30
        Me.cmdModificarFilosofiaInstitucional.Text = "Modificar Filosofía Institucional"
        Me.cmdModificarFilosofiaInstitucional.UseVisualStyleBackColor = False
        Me.cmdModificarFilosofiaInstitucional.Visible = False
        '
        'cmdEliminarFilosofiaInstitucional
        '
        Me.cmdEliminarFilosofiaInstitucional.BackColor = System.Drawing.Color.Gainsboro
        Me.cmdEliminarFilosofiaInstitucional.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdEliminarFilosofiaInstitucional.FlatAppearance.BorderSize = 0
        Me.cmdEliminarFilosofiaInstitucional.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.cmdEliminarFilosofiaInstitucional.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.cmdEliminarFilosofiaInstitucional.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdEliminarFilosofiaInstitucional.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEliminarFilosofiaInstitucional.Location = New System.Drawing.Point(564, 4)
        Me.cmdEliminarFilosofiaInstitucional.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdEliminarFilosofiaInstitucional.Name = "cmdEliminarFilosofiaInstitucional"
        Me.cmdEliminarFilosofiaInstitucional.Size = New System.Drawing.Size(187, 81)
        Me.cmdEliminarFilosofiaInstitucional.TabIndex = 30
        Me.cmdEliminarFilosofiaInstitucional.Text = "Eliminar Filosofía Institucional"
        Me.cmdEliminarFilosofiaInstitucional.UseVisualStyleBackColor = False
        Me.cmdEliminarFilosofiaInstitucional.Visible = False
        '
        'ModuloFilosofia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.tabPlanificacion)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "ModuloFilosofia"
        Me.Size = New System.Drawing.Size(1031, 599)
        Me.tabPlanificacion.ResumeLayout(False)
        Me.TabPageFilosofiaInstitucional.ResumeLayout(False)
        Me.TableLayoutPanel8.ResumeLayout(False)
        CType(Me.DG_Filosofia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel10.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tabPlanificacion As TabControl
    Friend WithEvents TabPageFilosofiaInstitucional As TabPage
    Friend WithEvents TableLayoutPanel8 As TableLayoutPanel
    Friend WithEvents DG_Filosofia As DataGridView
    Friend WithEvents ID_InstitutionalPhilosophy As DataGridViewTextBoxColumn
    Friend WithEvents Mision As DataGridViewTextBoxColumn
    Friend WithEvents Vision As DataGridViewTextBoxColumn
    Friend WithEvents Valores As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn57 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn58 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn59 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn60 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn61 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn62 As DataGridViewTextBoxColumn
    Friend WithEvents FlowLayoutPanel10 As FlowLayoutPanel
    Private WithEvents cmdVerFilosofiaInstitucional As Button
    Private WithEvents cmdAgregarFilosofiaInstitucional As Button
    Private WithEvents cmdModificarFilosofiaInstitucional As Button
    Private WithEvents cmdEliminarFilosofiaInstitucional As Button
End Class
