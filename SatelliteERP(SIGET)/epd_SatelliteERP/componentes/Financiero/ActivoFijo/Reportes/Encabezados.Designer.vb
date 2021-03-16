<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Encabezados
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgv_GenericReports = New System.Windows.Forms.DataGridView()
        Me.Id_Define_Field = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Field = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Caption = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Create_Users = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Create_Date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Modify_Users = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Modify_Date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.is_Active = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmb_id_Modulo_FK = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDescrip_Header = New System.Windows.Forms.TextBox()
        Me.label49 = New System.Windows.Forms.Label()
        Me.txtName_Header = New System.Windows.Forms.TextBox()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv_GenericReports, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.dgv_GenericReports)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cmb_id_Modulo_FK)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtDescrip_Header)
        Me.GroupBox1.Controls.Add(Me.label49)
        Me.GroupBox1.Controls.Add(Me.txtName_Header)
        Me.GroupBox1.Controls.Add(Me.cmdSave)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(10, 11)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(550, 592)
        Me.GroupBox1.TabIndex = 37
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Configuración de Encabezados"
        '
        'dgv_GenericReports
        '
        Me.dgv_GenericReports.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgv_GenericReports.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgv_GenericReports.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id_Define_Field, Me.Field, Me.Caption, Me.Create_Users, Me.Create_Date, Me.Modify_Users, Me.Modify_Date, Me.is_Active})
        Me.dgv_GenericReports.EnableHeadersVisualStyles = False
        Me.dgv_GenericReports.Location = New System.Drawing.Point(19, 206)
        Me.dgv_GenericReports.Name = "dgv_GenericReports"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.dgv_GenericReports.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_GenericReports.RowHeadersVisible = False
        Me.dgv_GenericReports.ShowCellErrors = False
        Me.dgv_GenericReports.ShowCellToolTips = False
        Me.dgv_GenericReports.ShowEditingIcon = False
        Me.dgv_GenericReports.ShowRowErrors = False
        Me.dgv_GenericReports.Size = New System.Drawing.Size(525, 304)
        Me.dgv_GenericReports.TabIndex = 75
        '
        'Id_Define_Field
        '
        Me.Id_Define_Field.DataPropertyName = "Id_Define_Field"
        Me.Id_Define_Field.HeaderText = "Id"
        Me.Id_Define_Field.Name = "Id_Define_Field"
        Me.Id_Define_Field.Width = 55
        '
        'Field
        '
        Me.Field.DataPropertyName = "Field"
        Me.Field.HeaderText = "Campo"
        Me.Field.Name = "Field"
        Me.Field.Visible = False
        '
        'Caption
        '
        Me.Caption.DataPropertyName = "Caption"
        Me.Caption.HeaderText = "Caption"
        Me.Caption.Name = "Caption"
        Me.Caption.Width = 107
        '
        'Create_Users
        '
        Me.Create_Users.DataPropertyName = "Create_Users"
        Me.Create_Users.HeaderText = "Usuario Creacion"
        Me.Create_Users.Name = "Create_Users"
        Me.Create_Users.Visible = False
        Me.Create_Users.Width = 189
        '
        'Create_Date
        '
        Me.Create_Date.DataPropertyName = "Create_Date"
        Me.Create_Date.HeaderText = "Fecha Creacion"
        Me.Create_Date.Name = "Create_Date"
        Me.Create_Date.Visible = False
        Me.Create_Date.Width = 170
        '
        'Modify_Users
        '
        Me.Modify_Users.DataPropertyName = "Modify_Users"
        Me.Modify_Users.HeaderText = "Usuario Modificacion"
        Me.Modify_Users.Name = "Modify_Users"
        Me.Modify_Users.Visible = False
        Me.Modify_Users.Width = 227
        '
        'Modify_Date
        '
        Me.Modify_Date.DataPropertyName = "Modify_Date"
        Me.Modify_Date.HeaderText = "Fecha Modificacion"
        Me.Modify_Date.Name = "Modify_Date"
        Me.Modify_Date.Visible = False
        Me.Modify_Date.Width = 208
        '
        'is_Active
        '
        Me.is_Active.DataPropertyName = "is_Active"
        Me.is_Active.HeaderText = "Activo"
        Me.is_Active.Name = "is_Active"
        Me.is_Active.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.is_Active.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.is_Active.Width = 93
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.Label2.Location = New System.Drawing.Point(40, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 25)
        Me.Label2.TabIndex = 74
        Me.Label2.Text = "Modulo:"
        '
        'cmb_id_Modulo_FK
        '
        Me.cmb_id_Modulo_FK.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmb_id_Modulo_FK.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmb_id_Modulo_FK.BackColor = System.Drawing.Color.Gainsboro
        Me.cmb_id_Modulo_FK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_id_Modulo_FK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmb_id_Modulo_FK.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_id_Modulo_FK.FormattingEnabled = True
        Me.cmb_id_Modulo_FK.Location = New System.Drawing.Point(124, 38)
        Me.cmb_id_Modulo_FK.Name = "cmb_id_Modulo_FK"
        Me.cmb_id_Modulo_FK.Size = New System.Drawing.Size(351, 29)
        Me.cmb_id_Modulo_FK.TabIndex = 73
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Gainsboro
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(428, 538)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(98, 29)
        Me.Button1.TabIndex = 71
        Me.Button1.Text = "Cancelar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.Label1.Location = New System.Drawing.Point(14, 132)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 25)
        Me.Label1.TabIndex = 67
        Me.Label1.Text = "Descripcion:"
        '
        'txtDescrip_Header
        '
        Me.txtDescrip_Header.BackColor = System.Drawing.Color.Gainsboro
        Me.txtDescrip_Header.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDescrip_Header.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescrip_Header.Location = New System.Drawing.Point(128, 132)
        Me.txtDescrip_Header.Name = "txtDescrip_Header"
        Me.txtDescrip_Header.Size = New System.Drawing.Size(347, 26)
        Me.txtDescrip_Header.TabIndex = 68
        '
        'label49
        '
        Me.label49.AutoSize = True
        Me.label49.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.label49.Location = New System.Drawing.Point(40, 85)
        Me.label49.Name = "label49"
        Me.label49.Size = New System.Drawing.Size(85, 25)
        Me.label49.TabIndex = 65
        Me.label49.Text = "Nombre:"
        '
        'txtName_Header
        '
        Me.txtName_Header.BackColor = System.Drawing.Color.Gainsboro
        Me.txtName_Header.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtName_Header.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName_Header.Location = New System.Drawing.Point(128, 87)
        Me.txtName_Header.Name = "txtName_Header"
        Me.txtName_Header.Size = New System.Drawing.Size(256, 26)
        Me.txtName_Header.TabIndex = 66
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
        Me.cmdSave.Location = New System.Drawing.Point(323, 538)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(98, 29)
        Me.cmdSave.TabIndex = 17
        Me.cmdSave.Text = "Grabar"
        Me.cmdSave.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(124, 164)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(204, 36)
        Me.Button2.TabIndex = 76
        Me.Button2.Text = "Todos"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(340, 164)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(204, 36)
        Me.Button3.TabIndex = 77
        Me.Button3.Text = "Ninguno"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Encabezados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(574, 613)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Encabezados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Encabezados"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgv_GenericReports, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Private WithEvents cmdSave As Button
    Private WithEvents Label1 As Label
    Private WithEvents txtDescrip_Header As TextBox
    Private WithEvents label49 As Label
    Private WithEvents txtName_Header As TextBox
    Private WithEvents Button1 As Button
    Private WithEvents Label2 As Label
    Private WithEvents cmb_id_Modulo_FK As ComboBox
    Friend WithEvents dgv_GenericReports As DataGridView
    Friend WithEvents Id_Define_Field As DataGridViewTextBoxColumn
    Friend WithEvents Field As DataGridViewTextBoxColumn
    Friend WithEvents Caption As DataGridViewTextBoxColumn
    Friend WithEvents Create_Users As DataGridViewTextBoxColumn
    Friend WithEvents Create_Date As DataGridViewTextBoxColumn
    Friend WithEvents Modify_Users As DataGridViewTextBoxColumn
    Friend WithEvents Modify_Date As DataGridViewTextBoxColumn
    Friend WithEvents is_Active As DataGridViewCheckBoxColumn
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
