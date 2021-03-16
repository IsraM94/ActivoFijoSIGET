<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ModuloUsers
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
        Me.ID_UserName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Rol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Empleado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn33 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn34 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn35 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn36 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_Company_FK = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idrol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idempleado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FlowLayoutPanel7 = New System.Windows.Forms.FlowLayoutPanel()
        Me.cmdAccessUsers = New System.Windows.Forms.Button()
        Me.cmdCreateAccessUsers = New System.Windows.Forms.Button()
        Me.cmdModifyUsers = New System.Windows.Forms.Button()
        Me.DeleteUsers = New System.Windows.Forms.Button()
        Me.DeactiveUsers = New System.Windows.Forms.Button()
        Me.DateTimePicker4 = New System.Windows.Forms.DateTimePicker()
        Me.CambioPassword = New System.Windows.Forms.TabPage()
        Me.GroupDatosUsuario = New System.Windows.Forms.GroupBox()
        Me.btnGrabar = New System.Windows.Forms.Button()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.lblPass = New System.Windows.Forms.Label()
        Me.txtConfirmarPassword = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNuevo = New System.Windows.Forms.TextBox()
        Me.lblValor = New System.Windows.Forms.Label()
        Me.txtPassActual = New System.Windows.Forms.TextBox()
        Me.txtBusquedad = New System.Windows.Forms.TextBox()
        Me.tabUsuarios.SuspendLayout()
        Me.TagPageUserAccess.SuspendLayout()
        Me.TLPCategoriasMantenimientos.SuspendLayout()
        CType(Me.DG_SystemUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel7.SuspendLayout()
        Me.CambioPassword.SuspendLayout()
        Me.GroupDatosUsuario.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabUsuarios
        '
        Me.tabUsuarios.Controls.Add(Me.TagPageUserAccess)
        Me.tabUsuarios.Controls.Add(Me.CambioPassword)
        Me.tabUsuarios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabUsuarios.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.tabUsuarios.Location = New System.Drawing.Point(0, 0)
        Me.tabUsuarios.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tabUsuarios.Name = "tabUsuarios"
        Me.tabUsuarios.SelectedIndex = 0
        Me.tabUsuarios.Size = New System.Drawing.Size(1031, 599)
        Me.tabUsuarios.TabIndex = 1
        '
        'TagPageUserAccess
        '
        Me.TagPageUserAccess.Controls.Add(Me.TLPCategoriasMantenimientos)
        Me.TagPageUserAccess.Location = New System.Drawing.Point(4, 39)
        Me.TagPageUserAccess.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TagPageUserAccess.Name = "TagPageUserAccess"
        Me.TagPageUserAccess.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TagPageUserAccess.Size = New System.Drawing.Size(1023, 556)
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
        Me.TLPCategoriasMantenimientos.Location = New System.Drawing.Point(4, 4)
        Me.TLPCategoriasMantenimientos.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TLPCategoriasMantenimientos.Name = "TLPCategoriasMantenimientos"
        Me.TLPCategoriasMantenimientos.RowCount = 2
        Me.TLPCategoriasMantenimientos.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 92.0!))
        Me.TLPCategoriasMantenimientos.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLPCategoriasMantenimientos.Size = New System.Drawing.Size(1015, 548)
        Me.TLPCategoriasMantenimientos.TabIndex = 6
        '
        'DG_SystemUsers
        '
        Me.DG_SystemUsers.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DG_SystemUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_SystemUsers.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID_UserName, Me.UserName, Me.Rol, Me.Empleado, Me.DataGridViewTextBoxColumn33, Me.DataGridViewTextBoxColumn34, Me.DataGridViewTextBoxColumn35, Me.DataGridViewTextBoxColumn36, Me.id_Company_FK, Me.Status, Me.idrol, Me.idempleado})
        Me.DG_SystemUsers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DG_SystemUsers.EnableHeadersVisualStyles = False
        Me.DG_SystemUsers.Location = New System.Drawing.Point(4, 96)
        Me.DG_SystemUsers.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DG_SystemUsers.Name = "DG_SystemUsers"
        Me.DG_SystemUsers.ShowCellErrors = False
        Me.DG_SystemUsers.ShowCellToolTips = False
        Me.DG_SystemUsers.ShowEditingIcon = False
        Me.DG_SystemUsers.ShowRowErrors = False
        Me.DG_SystemUsers.Size = New System.Drawing.Size(1007, 448)
        Me.DG_SystemUsers.TabIndex = 0
        '
        'ID_UserName
        '
        Me.ID_UserName.DataPropertyName = "ID_UserName"
        Me.ID_UserName.HeaderText = "ID"
        Me.ID_UserName.Name = "ID_UserName"
        Me.ID_UserName.Width = 89
        '
        'UserName
        '
        Me.UserName.DataPropertyName = "UserName"
        Me.UserName.HeaderText = "Nombre Usuario"
        Me.UserName.Name = "UserName"
        Me.UserName.Width = 89
        '
        'Rol
        '
        Me.Rol.DataPropertyName = "role"
        Me.Rol.HeaderText = "Rol Asignado"
        Me.Rol.Name = "Rol"
        Me.Rol.Width = 150
        '
        'Empleado
        '
        Me.Empleado.DataPropertyName = "employee"
        Me.Empleado.HeaderText = "Empleado Asignado"
        Me.Empleado.Name = "Empleado"
        Me.Empleado.Width = 250
        '
        'DataGridViewTextBoxColumn33
        '
        Me.DataGridViewTextBoxColumn33.DataPropertyName = "UsersCreate"
        Me.DataGridViewTextBoxColumn33.HeaderText = "Usuario Creo"
        Me.DataGridViewTextBoxColumn33.Name = "DataGridViewTextBoxColumn33"
        Me.DataGridViewTextBoxColumn33.Width = 89
        '
        'DataGridViewTextBoxColumn34
        '
        Me.DataGridViewTextBoxColumn34.DataPropertyName = "DateCreate"
        Me.DataGridViewTextBoxColumn34.HeaderText = "Fecha Creo"
        Me.DataGridViewTextBoxColumn34.Name = "DataGridViewTextBoxColumn34"
        Me.DataGridViewTextBoxColumn34.Width = 89
        '
        'DataGridViewTextBoxColumn35
        '
        Me.DataGridViewTextBoxColumn35.DataPropertyName = "UsersModify"
        Me.DataGridViewTextBoxColumn35.HeaderText = "Usuario Mod."
        Me.DataGridViewTextBoxColumn35.Name = "DataGridViewTextBoxColumn35"
        '
        'DataGridViewTextBoxColumn36
        '
        Me.DataGridViewTextBoxColumn36.DataPropertyName = "DateModify"
        Me.DataGridViewTextBoxColumn36.HeaderText = "Fecha Mod."
        Me.DataGridViewTextBoxColumn36.Name = "DataGridViewTextBoxColumn36"
        '
        'id_Company_FK
        '
        Me.id_Company_FK.HeaderText = "id_Company_FK"
        Me.id_Company_FK.Name = "id_Company_FK"
        Me.id_Company_FK.Visible = False
        '
        'Status
        '
        Me.Status.DataPropertyName = "estado"
        Me.Status.HeaderText = "Estado"
        Me.Status.Name = "Status"
        '
        'idrol
        '
        Me.idrol.DataPropertyName = "idrol"
        Me.idrol.HeaderText = "idrol"
        Me.idrol.Name = "idrol"
        Me.idrol.Visible = False
        '
        'idempleado
        '
        Me.idempleado.DataPropertyName = "idempleado"
        Me.idempleado.HeaderText = "idempleado"
        Me.idempleado.Name = "idempleado"
        Me.idempleado.Visible = False
        '
        'FlowLayoutPanel7
        '
        Me.FlowLayoutPanel7.AutoScroll = True
        Me.FlowLayoutPanel7.Controls.Add(Me.cmdAccessUsers)
        Me.FlowLayoutPanel7.Controls.Add(Me.cmdCreateAccessUsers)
        Me.FlowLayoutPanel7.Controls.Add(Me.cmdModifyUsers)
        Me.FlowLayoutPanel7.Controls.Add(Me.DeleteUsers)
        Me.FlowLayoutPanel7.Controls.Add(Me.DeactiveUsers)
        Me.FlowLayoutPanel7.Controls.Add(Me.txtBusquedad)
        Me.FlowLayoutPanel7.Controls.Add(Me.DateTimePicker4)
        Me.FlowLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel7.Location = New System.Drawing.Point(4, 4)
        Me.FlowLayoutPanel7.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.FlowLayoutPanel7.Name = "FlowLayoutPanel7"
        Me.FlowLayoutPanel7.Size = New System.Drawing.Size(1007, 84)
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
        Me.cmdAccessUsers.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAccessUsers.Location = New System.Drawing.Point(4, 4)
        Me.cmdAccessUsers.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdAccessUsers.Name = "cmdAccessUsers"
        Me.cmdAccessUsers.Size = New System.Drawing.Size(144, 81)
        Me.cmdAccessUsers.TabIndex = 30
        Me.cmdAccessUsers.Text = "Ver Permisos Usuarios"
        Me.cmdAccessUsers.UseVisualStyleBackColor = False
        Me.cmdAccessUsers.Visible = False
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
        Me.cmdCreateAccessUsers.Location = New System.Drawing.Point(156, 4)
        Me.cmdCreateAccessUsers.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdCreateAccessUsers.Name = "cmdCreateAccessUsers"
        Me.cmdCreateAccessUsers.Size = New System.Drawing.Size(144, 81)
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
        Me.cmdModifyUsers.Location = New System.Drawing.Point(308, 4)
        Me.cmdModifyUsers.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdModifyUsers.Name = "cmdModifyUsers"
        Me.cmdModifyUsers.Size = New System.Drawing.Size(144, 81)
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
        Me.DeleteUsers.Location = New System.Drawing.Point(460, 4)
        Me.DeleteUsers.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DeleteUsers.Name = "DeleteUsers"
        Me.DeleteUsers.Size = New System.Drawing.Size(144, 81)
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
        Me.DeactiveUsers.Location = New System.Drawing.Point(612, 4)
        Me.DeactiveUsers.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DeactiveUsers.Name = "DeactiveUsers"
        Me.DeactiveUsers.Size = New System.Drawing.Size(144, 81)
        Me.DeactiveUsers.TabIndex = 30
        Me.DeactiveUsers.Text = "Desactivar Usuario"
        Me.DeactiveUsers.UseVisualStyleBackColor = False
        '
        'DateTimePicker4
        '
        Me.DateTimePicker4.Location = New System.Drawing.Point(257, 91)
        Me.DateTimePicker4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DateTimePicker4.Name = "DateTimePicker4"
        Me.DateTimePicker4.Size = New System.Drawing.Size(515, 36)
        Me.DateTimePicker4.TabIndex = 34
        '
        'CambioPassword
        '
        Me.CambioPassword.BackColor = System.Drawing.Color.SteelBlue
        Me.CambioPassword.Controls.Add(Me.GroupDatosUsuario)
        Me.CambioPassword.Location = New System.Drawing.Point(4, 39)
        Me.CambioPassword.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CambioPassword.Name = "CambioPassword"
        Me.CambioPassword.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CambioPassword.Size = New System.Drawing.Size(1023, 556)
        Me.CambioPassword.TabIndex = 8
        Me.CambioPassword.Text = "Cambio Password"
        '
        'GroupDatosUsuario
        '
        Me.GroupDatosUsuario.BackColor = System.Drawing.SystemColors.Control
        Me.GroupDatosUsuario.Controls.Add(Me.btnGrabar)
        Me.GroupDatosUsuario.Controls.Add(Me.cmdCancel)
        Me.GroupDatosUsuario.Controls.Add(Me.lblPass)
        Me.GroupDatosUsuario.Controls.Add(Me.txtConfirmarPassword)
        Me.GroupDatosUsuario.Controls.Add(Me.Label1)
        Me.GroupDatosUsuario.Controls.Add(Me.txtNuevo)
        Me.GroupDatosUsuario.Controls.Add(Me.lblValor)
        Me.GroupDatosUsuario.Controls.Add(Me.txtPassActual)
        Me.GroupDatosUsuario.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupDatosUsuario.Location = New System.Drawing.Point(20, 20)
        Me.GroupDatosUsuario.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupDatosUsuario.Name = "GroupDatosUsuario"
        Me.GroupDatosUsuario.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupDatosUsuario.Size = New System.Drawing.Size(977, 517)
        Me.GroupDatosUsuario.TabIndex = 1
        Me.GroupDatosUsuario.TabStop = False
        Me.GroupDatosUsuario.Text = "Datos Usuario"
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
        Me.btnGrabar.Location = New System.Drawing.Point(345, 276)
        Me.btnGrabar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnGrabar.Name = "btnGrabar"
        Me.btnGrabar.Size = New System.Drawing.Size(131, 34)
        Me.btnGrabar.TabIndex = 11
        Me.btnGrabar.Text = "Grabar"
        Me.btnGrabar.UseVisualStyleBackColor = False
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
        Me.cmdCancel.Location = New System.Drawing.Point(503, 276)
        Me.cmdCancel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(131, 34)
        Me.cmdCancel.TabIndex = 12
        Me.cmdCancel.Text = "Cancelar"
        Me.cmdCancel.UseVisualStyleBackColor = False
        '
        'lblPass
        '
        Me.lblPass.AutoSize = True
        Me.lblPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPass.Location = New System.Drawing.Point(17, 202)
        Me.lblPass.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPass.Name = "lblPass"
        Me.lblPass.Size = New System.Drawing.Size(237, 29)
        Me.lblPass.TabIndex = 10
        Me.lblPass.Text = "Confirmar Password:"
        '
        'txtConfirmarPassword
        '
        Me.txtConfirmarPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConfirmarPassword.Location = New System.Drawing.Point(285, 202)
        Me.txtConfirmarPassword.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtConfirmarPassword.Name = "txtConfirmarPassword"
        Me.txtConfirmarPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtConfirmarPassword.Size = New System.Drawing.Size(437, 34)
        Me.txtConfirmarPassword.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(51, 139)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(202, 29)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Nuevo Password:"
        '
        'txtNuevo
        '
        Me.txtNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNuevo.Location = New System.Drawing.Point(285, 139)
        Me.txtNuevo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtNuevo.Name = "txtNuevo"
        Me.txtNuevo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtNuevo.Size = New System.Drawing.Size(437, 34)
        Me.txtNuevo.TabIndex = 3
        '
        'lblValor
        '
        Me.lblValor.AutoSize = True
        Me.lblValor.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValor.Location = New System.Drawing.Point(37, 78)
        Me.lblValor.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblValor.Name = "lblValor"
        Me.lblValor.Size = New System.Drawing.Size(213, 29)
        Me.lblValor.TabIndex = 6
        Me.lblValor.Text = "Contraseña Actual:"
        '
        'txtPassActual
        '
        Me.txtPassActual.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassActual.Location = New System.Drawing.Point(285, 71)
        Me.txtPassActual.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPassActual.Name = "txtPassActual"
        Me.txtPassActual.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassActual.Size = New System.Drawing.Size(437, 34)
        Me.txtPassActual.TabIndex = 1
        '
        'txtBusquedad
        '
        Me.txtBusquedad.Location = New System.Drawing.Point(3, 92)
        Me.txtBusquedad.Multiline = True
        Me.txtBusquedad.Name = "txtBusquedad"
        Me.txtBusquedad.Size = New System.Drawing.Size(248, 61)
        Me.txtBusquedad.TabIndex = 35
        '
        'ModuloUsers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.tabUsuarios)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "ModuloUsers"
        Me.Size = New System.Drawing.Size(1031, 599)
        Me.tabUsuarios.ResumeLayout(False)
        Me.TagPageUserAccess.ResumeLayout(False)
        Me.TLPCategoriasMantenimientos.ResumeLayout(False)
        CType(Me.DG_SystemUsers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel7.ResumeLayout(False)
        Me.FlowLayoutPanel7.PerformLayout()
        Me.CambioPassword.ResumeLayout(False)
        Me.GroupDatosUsuario.ResumeLayout(False)
        Me.GroupDatosUsuario.PerformLayout()
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
    Friend WithEvents DateTimePicker4 As DateTimePicker
    Friend WithEvents ID_UserName As DataGridViewTextBoxColumn
    Friend WithEvents UserName As DataGridViewTextBoxColumn
    Friend WithEvents Rol As DataGridViewTextBoxColumn
    Friend WithEvents Empleado As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn33 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn34 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn35 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn36 As DataGridViewTextBoxColumn
    Friend WithEvents id_Company_FK As DataGridViewTextBoxColumn
    Friend WithEvents Status As DataGridViewTextBoxColumn
    Friend WithEvents idrol As DataGridViewTextBoxColumn
    Friend WithEvents idempleado As DataGridViewTextBoxColumn
    Friend WithEvents CambioPassword As TabPage
    Friend WithEvents GroupDatosUsuario As GroupBox
    Private WithEvents lblPass As Label
    Friend WithEvents txtConfirmarPassword As TextBox
    Private WithEvents Label1 As Label
    Friend WithEvents txtNuevo As TextBox
    Private WithEvents lblValor As Label
    Friend WithEvents txtPassActual As TextBox
    Private WithEvents btnGrabar As Button
    Private WithEvents cmdCancel As Button
    Friend WithEvents txtBusquedad As TextBox
End Class
