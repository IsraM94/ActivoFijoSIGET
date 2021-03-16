<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ModuloRecursosHumanos
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
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle23 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle24 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.tcMain = New System.Windows.Forms.TabControl()
        Me.VistaGeneral = New System.Windows.Forms.TabPage()
        Me.gbStudentDetails = New System.Windows.Forms.GroupBox()
        Me.NominaEmpleados = New System.Windows.Forms.TabPage()
        Me.TLP_PlanDePagos = New System.Windows.Forms.TableLayoutPanel()
        Me.dgvemployee = New System.Windows.Forms.DataGridView()
        Me.FlowLayoutPanel3 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btnBuscarEmpleado = New System.Windows.Forms.Button()
        Me.Departamentos = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.dgvDepartamentos = New System.Windows.Forms.DataGridView()
        Me.Id_Deparment = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Name_Deparmnet = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Create_Users = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CreateDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Modify_Users = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Modify_Date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InternalCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.cmdCreateDepartment = New System.Windows.Forms.Button()
        Me.cmdModifyDepartment = New System.Windows.Forms.Button()
        Me.cmdDeleteDepartment = New System.Windows.Forms.Button()
        Me.btnBuscarDepartamento = New System.Windows.Forms.Button()
        Me.WorkPosition = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.dgvWorkPosition = New System.Windows.Forms.DataGridView()
        Me.Id_WorkPosition = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Name_WorkPosition = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Is_CustomerService = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.cmbCreateWorkPosition = New System.Windows.Forms.Button()
        Me.cmbActualizarWorkPosition = New System.Windows.Forms.Button()
        Me.cmbEliminarWorkPosition = New System.Windows.Forms.Button()
        Me.btnBuscarPosicionTrabajo = New System.Windows.Forms.Button()
        Me.UbicacionEmpleados = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.dgvWorkLocation = New System.Windows.Forms.DataGridView()
        Me.Id_Location = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UbicacionPrimaria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Name_Location = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Address_Location = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdLocationPrimary = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FlowLayoutPanel4 = New System.Windows.Forms.FlowLayoutPanel()
        Me.cmdCrearUbicacion = New System.Windows.Forms.Button()
        Me.cmdModificarUbicacion = New System.Windows.Forms.Button()
        Me.cmdEliminarUbicacion = New System.Windows.Forms.Button()
        Me.btnBuscarUbicacion = New System.Windows.Forms.Button()
        Me.btnAllEmpleados = New System.Windows.Forms.Button()
        Me.ID_Employee = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Id_Company_FK = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Id_Department_FK = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Id_WorkPosition_FK = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Id_LocationJob_FK = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Departamento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Posicion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ubicacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ubicacionprimari = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SegundoNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TercerNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Apellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SegundoApellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TercerApellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DUI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Telefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Extension = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Salario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Contacto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Id_employee_Boss_FK = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserSiget = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Create_Date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_responsable = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.responsable = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdPrimaryLocation = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tcMain.SuspendLayout()
        Me.VistaGeneral.SuspendLayout()
        Me.NominaEmpleados.SuspendLayout()
        Me.TLP_PlanDePagos.SuspendLayout()
        CType(Me.dgvemployee, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel3.SuspendLayout()
        Me.Departamentos.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.dgvDepartamentos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.WorkPosition.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.dgvWorkPosition, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.UbicacionEmpleados.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.dgvWorkLocation, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'tcMain
        '
        Me.tcMain.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.tcMain.Controls.Add(Me.VistaGeneral)
        Me.tcMain.Controls.Add(Me.NominaEmpleados)
        Me.tcMain.Controls.Add(Me.Departamentos)
        Me.tcMain.Controls.Add(Me.WorkPosition)
        Me.tcMain.Controls.Add(Me.UbicacionEmpleados)
        Me.tcMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tcMain.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tcMain.HotTrack = True
        Me.tcMain.Location = New System.Drawing.Point(0, 0)
        Me.tcMain.Name = "tcMain"
        Me.tcMain.SelectedIndex = 0
        Me.tcMain.Size = New System.Drawing.Size(1095, 579)
        Me.tcMain.TabIndex = 1
        Me.tcMain.TabStop = False
        '
        'VistaGeneral
        '
        Me.VistaGeneral.BackColor = System.Drawing.Color.White
        Me.VistaGeneral.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.VistaGeneral.Controls.Add(Me.gbStudentDetails)
        Me.VistaGeneral.Location = New System.Drawing.Point(4, 35)
        Me.VistaGeneral.Name = "VistaGeneral"
        Me.VistaGeneral.Padding = New System.Windows.Forms.Padding(3)
        Me.VistaGeneral.Size = New System.Drawing.Size(1087, 540)
        Me.VistaGeneral.TabIndex = 0
        Me.VistaGeneral.Text = "Vista General"
        '
        'gbStudentDetails
        '
        Me.gbStudentDetails.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbStudentDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.gbStudentDetails.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbStudentDetails.ForeColor = System.Drawing.Color.Black
        Me.gbStudentDetails.Location = New System.Drawing.Point(3, 3)
        Me.gbStudentDetails.Name = "gbStudentDetails"
        Me.gbStudentDetails.Size = New System.Drawing.Size(1079, 532)
        Me.gbStudentDetails.TabIndex = 0
        Me.gbStudentDetails.TabStop = False
        Me.gbStudentDetails.Text = "DashBoard"
        '
        'NominaEmpleados
        '
        Me.NominaEmpleados.Controls.Add(Me.TLP_PlanDePagos)
        Me.NominaEmpleados.Location = New System.Drawing.Point(4, 35)
        Me.NominaEmpleados.Name = "NominaEmpleados"
        Me.NominaEmpleados.Size = New System.Drawing.Size(1087, 540)
        Me.NominaEmpleados.TabIndex = 5
        Me.NominaEmpleados.Text = "Empleados"
        Me.NominaEmpleados.UseVisualStyleBackColor = True
        '
        'TLP_PlanDePagos
        '
        Me.TLP_PlanDePagos.ColumnCount = 1
        Me.TLP_PlanDePagos.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLP_PlanDePagos.Controls.Add(Me.dgvemployee, 0, 1)
        Me.TLP_PlanDePagos.Controls.Add(Me.FlowLayoutPanel3, 0, 0)
        Me.TLP_PlanDePagos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TLP_PlanDePagos.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TLP_PlanDePagos.Location = New System.Drawing.Point(0, 0)
        Me.TLP_PlanDePagos.Name = "TLP_PlanDePagos"
        Me.TLP_PlanDePagos.RowCount = 2
        Me.TLP_PlanDePagos.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75.0!))
        Me.TLP_PlanDePagos.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLP_PlanDePagos.Size = New System.Drawing.Size(1087, 540)
        Me.TLP_PlanDePagos.TabIndex = 3
        '
        'dgvemployee
        '
        Me.dgvemployee.AllowUserToAddRows = False
        Me.dgvemployee.AllowUserToDeleteRows = False
        Me.dgvemployee.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvemployee.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgvemployee.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID_Employee, Me.Id_Company_FK, Me.Id_Department_FK, Me.Id_WorkPosition_FK, Me.Id_LocationJob_FK, Me.Departamento, Me.Posicion, Me.Ubicacion, Me.ubicacionprimari, Me.Nombre, Me.SegundoNombre, Me.TercerNombre, Me.Apellido, Me.SegundoApellido, Me.TercerApellido, Me.DUI, Me.Email, Me.Telefono, Me.Extension, Me.Salario, Me.Contacto, Me.Id_employee_Boss_FK, Me.UserSiget, Me.Column1, Me.Create_Date, Me.Column3, Me.Column4, Me.id_responsable, Me.responsable, Me.IdPrimaryLocation})
        Me.dgvemployee.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvemployee.EnableHeadersVisualStyles = False
        Me.dgvemployee.Location = New System.Drawing.Point(3, 78)
        Me.dgvemployee.Name = "dgvemployee"
        Me.dgvemployee.ReadOnly = True
        Me.dgvemployee.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvemployee.RowHeadersVisible = False
        Me.dgvemployee.ShowCellErrors = False
        Me.dgvemployee.ShowCellToolTips = False
        Me.dgvemployee.ShowEditingIcon = False
        Me.dgvemployee.ShowRowErrors = False
        Me.dgvemployee.Size = New System.Drawing.Size(1081, 459)
        Me.dgvemployee.TabIndex = 0
        '
        'FlowLayoutPanel3
        '
        Me.FlowLayoutPanel3.Controls.Add(Me.Button1)
        Me.FlowLayoutPanel3.Controls.Add(Me.Button2)
        Me.FlowLayoutPanel3.Controls.Add(Me.Button3)
        Me.FlowLayoutPanel3.Controls.Add(Me.btnBuscarEmpleado)
        Me.FlowLayoutPanel3.Controls.Add(Me.btnAllEmpleados)
        Me.FlowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel3.Location = New System.Drawing.Point(3, 3)
        Me.FlowLayoutPanel3.Name = "FlowLayoutPanel3"
        Me.FlowLayoutPanel3.Size = New System.Drawing.Size(1081, 69)
        Me.FlowLayoutPanel3.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(3, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 66)
        Me.Button1.TabIndex = 37
        Me.Button1.Text = "Crear Empleado"
        Me.Button1.UseVisualStyleBackColor = False
        Me.Button1.Visible = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(121, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(112, 66)
        Me.Button2.TabIndex = 38
        Me.Button2.Text = "Modificar Empleado"
        Me.Button2.UseVisualStyleBackColor = False
        Me.Button2.Visible = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(239, 3)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(112, 66)
        Me.Button3.TabIndex = 38
        Me.Button3.Text = "Eliminar Empleado"
        Me.Button3.UseVisualStyleBackColor = False
        Me.Button3.Visible = False
        '
        'btnBuscarEmpleado
        '
        Me.btnBuscarEmpleado.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.btnBuscarEmpleado.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.btnBuscarEmpleado.FlatAppearance.BorderSize = 0
        Me.btnBuscarEmpleado.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnBuscarEmpleado.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnBuscarEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscarEmpleado.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarEmpleado.Location = New System.Drawing.Point(357, 3)
        Me.btnBuscarEmpleado.Name = "btnBuscarEmpleado"
        Me.btnBuscarEmpleado.Size = New System.Drawing.Size(102, 66)
        Me.btnBuscarEmpleado.TabIndex = 49
        Me.btnBuscarEmpleado.Text = "Buscar Empleado"
        Me.btnBuscarEmpleado.UseVisualStyleBackColor = False
        '
        'Departamentos
        '
        Me.Departamentos.Controls.Add(Me.TableLayoutPanel1)
        Me.Departamentos.Location = New System.Drawing.Point(4, 35)
        Me.Departamentos.Name = "Departamentos"
        Me.Departamentos.Size = New System.Drawing.Size(1087, 540)
        Me.Departamentos.TabIndex = 6
        Me.Departamentos.Text = "Departamentos"
        Me.Departamentos.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.dgvDepartamentos, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.FlowLayoutPanel1, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1087, 540)
        Me.TableLayoutPanel1.TabIndex = 4
        '
        'dgvDepartamentos
        '
        Me.dgvDepartamentos.AllowUserToAddRows = False
        Me.dgvDepartamentos.AllowUserToDeleteRows = False
        Me.dgvDepartamentos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvDepartamentos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id_Deparment, Me.Name_Deparmnet, Me.Create_Users, Me.CreateDate, Me.Modify_Users, Me.Modify_Date, Me.InternalCode})
        Me.dgvDepartamentos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvDepartamentos.EnableHeadersVisualStyles = False
        Me.dgvDepartamentos.Location = New System.Drawing.Point(3, 78)
        Me.dgvDepartamentos.Name = "dgvDepartamentos"
        Me.dgvDepartamentos.ReadOnly = True
        Me.dgvDepartamentos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvDepartamentos.RowHeadersVisible = False
        Me.dgvDepartamentos.ShowCellErrors = False
        Me.dgvDepartamentos.ShowCellToolTips = False
        Me.dgvDepartamentos.ShowEditingIcon = False
        Me.dgvDepartamentos.ShowRowErrors = False
        Me.dgvDepartamentos.Size = New System.Drawing.Size(1081, 459)
        Me.dgvDepartamentos.TabIndex = 0
        '
        'Id_Deparment
        '
        Me.Id_Deparment.DataPropertyName = "Id_Deparment"
        Me.Id_Deparment.HeaderText = "Correlativo"
        Me.Id_Deparment.Name = "Id_Deparment"
        Me.Id_Deparment.ReadOnly = True
        Me.Id_Deparment.Width = 87
        '
        'Name_Deparmnet
        '
        Me.Name_Deparmnet.DataPropertyName = "Name_Deparmnet"
        Me.Name_Deparmnet.HeaderText = "Departamento"
        Me.Name_Deparmnet.Name = "Name_Deparmnet"
        Me.Name_Deparmnet.ReadOnly = True
        '
        'Create_Users
        '
        Me.Create_Users.DataPropertyName = "Create_Users"
        Me.Create_Users.HeaderText = " Creación"
        Me.Create_Users.Name = "Create_Users"
        Me.Create_Users.ReadOnly = True
        '
        'CreateDate
        '
        Me.CreateDate.DataPropertyName = "Create_Date"
        DataGridViewCellStyle19.Format = "d"
        DataGridViewCellStyle19.NullValue = Nothing
        Me.CreateDate.DefaultCellStyle = DataGridViewCellStyle19
        Me.CreateDate.HeaderText = "Fecha Creación"
        Me.CreateDate.Name = "CreateDate"
        Me.CreateDate.ReadOnly = True
        Me.CreateDate.Width = 180
        '
        'Modify_Users
        '
        Me.Modify_Users.DataPropertyName = "Modify_Users"
        Me.Modify_Users.HeaderText = "Modifico"
        Me.Modify_Users.Name = "Modify_Users"
        Me.Modify_Users.ReadOnly = True
        '
        'Modify_Date
        '
        Me.Modify_Date.DataPropertyName = "Modify_Date"
        DataGridViewCellStyle20.Format = "d"
        DataGridViewCellStyle20.NullValue = Nothing
        Me.Modify_Date.DefaultCellStyle = DataGridViewCellStyle20
        Me.Modify_Date.HeaderText = "Fecha Modificación"
        Me.Modify_Date.Name = "Modify_Date"
        Me.Modify_Date.ReadOnly = True
        Me.Modify_Date.Width = 180
        '
        'InternalCode
        '
        Me.InternalCode.DataPropertyName = "InternalCode"
        Me.InternalCode.HeaderText = "Código Interno"
        Me.InternalCode.Name = "InternalCode"
        Me.InternalCode.ReadOnly = True
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.cmdCreateDepartment)
        Me.FlowLayoutPanel1.Controls.Add(Me.cmdModifyDepartment)
        Me.FlowLayoutPanel1.Controls.Add(Me.cmdDeleteDepartment)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnBuscarDepartamento)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(1081, 69)
        Me.FlowLayoutPanel1.TabIndex = 1
        '
        'cmdCreateDepartment
        '
        Me.cmdCreateDepartment.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.cmdCreateDepartment.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdCreateDepartment.FlatAppearance.BorderSize = 0
        Me.cmdCreateDepartment.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdCreateDepartment.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdCreateDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCreateDepartment.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCreateDepartment.Location = New System.Drawing.Point(3, 3)
        Me.cmdCreateDepartment.Name = "cmdCreateDepartment"
        Me.cmdCreateDepartment.Size = New System.Drawing.Size(133, 66)
        Me.cmdCreateDepartment.TabIndex = 37
        Me.cmdCreateDepartment.Text = "Crear Departamento"
        Me.cmdCreateDepartment.UseVisualStyleBackColor = False
        Me.cmdCreateDepartment.Visible = False
        '
        'cmdModifyDepartment
        '
        Me.cmdModifyDepartment.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.cmdModifyDepartment.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdModifyDepartment.FlatAppearance.BorderSize = 0
        Me.cmdModifyDepartment.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdModifyDepartment.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdModifyDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdModifyDepartment.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdModifyDepartment.Location = New System.Drawing.Point(142, 3)
        Me.cmdModifyDepartment.Name = "cmdModifyDepartment"
        Me.cmdModifyDepartment.Size = New System.Drawing.Size(134, 66)
        Me.cmdModifyDepartment.TabIndex = 38
        Me.cmdModifyDepartment.Text = "Modificar Departamento"
        Me.cmdModifyDepartment.UseVisualStyleBackColor = False
        Me.cmdModifyDepartment.Visible = False
        '
        'cmdDeleteDepartment
        '
        Me.cmdDeleteDepartment.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.cmdDeleteDepartment.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdDeleteDepartment.FlatAppearance.BorderSize = 0
        Me.cmdDeleteDepartment.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdDeleteDepartment.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdDeleteDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdDeleteDepartment.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDeleteDepartment.Location = New System.Drawing.Point(282, 3)
        Me.cmdDeleteDepartment.Name = "cmdDeleteDepartment"
        Me.cmdDeleteDepartment.Size = New System.Drawing.Size(134, 66)
        Me.cmdDeleteDepartment.TabIndex = 38
        Me.cmdDeleteDepartment.Text = "Eliminar Departamento"
        Me.cmdDeleteDepartment.UseVisualStyleBackColor = False
        Me.cmdDeleteDepartment.Visible = False
        '
        'btnBuscarDepartamento
        '
        Me.btnBuscarDepartamento.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.btnBuscarDepartamento.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.btnBuscarDepartamento.FlatAppearance.BorderSize = 0
        Me.btnBuscarDepartamento.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnBuscarDepartamento.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnBuscarDepartamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscarDepartamento.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarDepartamento.Location = New System.Drawing.Point(422, 3)
        Me.btnBuscarDepartamento.Name = "btnBuscarDepartamento"
        Me.btnBuscarDepartamento.Size = New System.Drawing.Size(130, 66)
        Me.btnBuscarDepartamento.TabIndex = 49
        Me.btnBuscarDepartamento.Text = "Buscar Departamento"
        Me.btnBuscarDepartamento.UseVisualStyleBackColor = False
        '
        'WorkPosition
        '
        Me.WorkPosition.Controls.Add(Me.TableLayoutPanel2)
        Me.WorkPosition.Location = New System.Drawing.Point(4, 35)
        Me.WorkPosition.Name = "WorkPosition"
        Me.WorkPosition.Padding = New System.Windows.Forms.Padding(3)
        Me.WorkPosition.Size = New System.Drawing.Size(1087, 540)
        Me.WorkPosition.TabIndex = 7
        Me.WorkPosition.Text = "Posición de Trabajo"
        Me.WorkPosition.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.dgvWorkPosition, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.FlowLayoutPanel2, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1081, 534)
        Me.TableLayoutPanel2.TabIndex = 5
        '
        'dgvWorkPosition
        '
        Me.dgvWorkPosition.AllowUserToAddRows = False
        Me.dgvWorkPosition.AllowUserToDeleteRows = False
        Me.dgvWorkPosition.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvWorkPosition.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id_WorkPosition, Me.Name_WorkPosition, Me.Is_CustomerService, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.dgvWorkPosition.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvWorkPosition.EnableHeadersVisualStyles = False
        Me.dgvWorkPosition.Location = New System.Drawing.Point(3, 78)
        Me.dgvWorkPosition.Name = "dgvWorkPosition"
        Me.dgvWorkPosition.ReadOnly = True
        Me.dgvWorkPosition.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvWorkPosition.RowHeadersVisible = False
        Me.dgvWorkPosition.ShowCellErrors = False
        Me.dgvWorkPosition.ShowCellToolTips = False
        Me.dgvWorkPosition.ShowEditingIcon = False
        Me.dgvWorkPosition.ShowRowErrors = False
        Me.dgvWorkPosition.Size = New System.Drawing.Size(1075, 453)
        Me.dgvWorkPosition.TabIndex = 0
        '
        'Id_WorkPosition
        '
        Me.Id_WorkPosition.DataPropertyName = "Id_WorkPosition"
        Me.Id_WorkPosition.HeaderText = "Correlativo"
        Me.Id_WorkPosition.Name = "Id_WorkPosition"
        Me.Id_WorkPosition.ReadOnly = True
        Me.Id_WorkPosition.Width = 87
        '
        'Name_WorkPosition
        '
        Me.Name_WorkPosition.DataPropertyName = "Name_WorkPosition"
        Me.Name_WorkPosition.HeaderText = "Posición de Trabajo"
        Me.Name_WorkPosition.Name = "Name_WorkPosition"
        Me.Name_WorkPosition.ReadOnly = True
        '
        'Is_CustomerService
        '
        Me.Is_CustomerService.DataPropertyName = "Is_CustomerService"
        Me.Is_CustomerService.HeaderText = "Empleado Contacto"
        Me.Is_CustomerService.Name = "Is_CustomerService"
        Me.Is_CustomerService.ReadOnly = True
        Me.Is_CustomerService.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Is_CustomerService.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Create_Users"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Creación"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Create_Date"
        DataGridViewCellStyle21.Format = "d"
        DataGridViewCellStyle21.NullValue = Nothing
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle21
        Me.DataGridViewTextBoxColumn4.HeaderText = "Fecha Creación"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 180
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Modify_Users"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Modificó"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Modify_Date"
        DataGridViewCellStyle22.Format = "d"
        DataGridViewCellStyle22.NullValue = Nothing
        Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle22
        Me.DataGridViewTextBoxColumn6.HeaderText = "Fecha Modificación"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 180
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.Controls.Add(Me.cmbCreateWorkPosition)
        Me.FlowLayoutPanel2.Controls.Add(Me.cmbActualizarWorkPosition)
        Me.FlowLayoutPanel2.Controls.Add(Me.cmbEliminarWorkPosition)
        Me.FlowLayoutPanel2.Controls.Add(Me.btnBuscarPosicionTrabajo)
        Me.FlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(1075, 69)
        Me.FlowLayoutPanel2.TabIndex = 1
        '
        'cmbCreateWorkPosition
        '
        Me.cmbCreateWorkPosition.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.cmbCreateWorkPosition.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmbCreateWorkPosition.FlatAppearance.BorderSize = 0
        Me.cmbCreateWorkPosition.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmbCreateWorkPosition.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmbCreateWorkPosition.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbCreateWorkPosition.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCreateWorkPosition.Location = New System.Drawing.Point(3, 3)
        Me.cmbCreateWorkPosition.Name = "cmbCreateWorkPosition"
        Me.cmbCreateWorkPosition.Size = New System.Drawing.Size(150, 66)
        Me.cmbCreateWorkPosition.TabIndex = 37
        Me.cmbCreateWorkPosition.Text = "Crear Posición de Trabajo"
        Me.cmbCreateWorkPosition.UseVisualStyleBackColor = False
        Me.cmbCreateWorkPosition.Visible = False
        '
        'cmbActualizarWorkPosition
        '
        Me.cmbActualizarWorkPosition.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.cmbActualizarWorkPosition.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmbActualizarWorkPosition.FlatAppearance.BorderSize = 0
        Me.cmbActualizarWorkPosition.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmbActualizarWorkPosition.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmbActualizarWorkPosition.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbActualizarWorkPosition.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbActualizarWorkPosition.Location = New System.Drawing.Point(159, 3)
        Me.cmbActualizarWorkPosition.Name = "cmbActualizarWorkPosition"
        Me.cmbActualizarWorkPosition.Size = New System.Drawing.Size(166, 66)
        Me.cmbActualizarWorkPosition.TabIndex = 38
        Me.cmbActualizarWorkPosition.Text = "Modificar Posición de Trabajo"
        Me.cmbActualizarWorkPosition.UseVisualStyleBackColor = False
        Me.cmbActualizarWorkPosition.Visible = False
        '
        'cmbEliminarWorkPosition
        '
        Me.cmbEliminarWorkPosition.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.cmbEliminarWorkPosition.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmbEliminarWorkPosition.FlatAppearance.BorderSize = 0
        Me.cmbEliminarWorkPosition.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmbEliminarWorkPosition.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmbEliminarWorkPosition.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbEliminarWorkPosition.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbEliminarWorkPosition.Location = New System.Drawing.Point(331, 3)
        Me.cmbEliminarWorkPosition.Name = "cmbEliminarWorkPosition"
        Me.cmbEliminarWorkPosition.Size = New System.Drawing.Size(162, 66)
        Me.cmbEliminarWorkPosition.TabIndex = 38
        Me.cmbEliminarWorkPosition.Text = "Eliminar Posición de Trabajo"
        Me.cmbEliminarWorkPosition.UseVisualStyleBackColor = False
        Me.cmbEliminarWorkPosition.Visible = False
        '
        'btnBuscarPosicionTrabajo
        '
        Me.btnBuscarPosicionTrabajo.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.btnBuscarPosicionTrabajo.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.btnBuscarPosicionTrabajo.FlatAppearance.BorderSize = 0
        Me.btnBuscarPosicionTrabajo.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnBuscarPosicionTrabajo.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnBuscarPosicionTrabajo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscarPosicionTrabajo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarPosicionTrabajo.Location = New System.Drawing.Point(499, 3)
        Me.btnBuscarPosicionTrabajo.Name = "btnBuscarPosicionTrabajo"
        Me.btnBuscarPosicionTrabajo.Size = New System.Drawing.Size(138, 66)
        Me.btnBuscarPosicionTrabajo.TabIndex = 49
        Me.btnBuscarPosicionTrabajo.Text = "Buscar Posición de Trabajo"
        Me.btnBuscarPosicionTrabajo.UseVisualStyleBackColor = False
        '
        'UbicacionEmpleados
        '
        Me.UbicacionEmpleados.Controls.Add(Me.TableLayoutPanel3)
        Me.UbicacionEmpleados.Location = New System.Drawing.Point(4, 35)
        Me.UbicacionEmpleados.Name = "UbicacionEmpleados"
        Me.UbicacionEmpleados.Padding = New System.Windows.Forms.Padding(3)
        Me.UbicacionEmpleados.Size = New System.Drawing.Size(1087, 540)
        Me.UbicacionEmpleados.TabIndex = 8
        Me.UbicacionEmpleados.Text = "Ubicación"
        Me.UbicacionEmpleados.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.dgvWorkLocation, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.FlowLayoutPanel4, 0, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(1081, 534)
        Me.TableLayoutPanel3.TabIndex = 6
        '
        'dgvWorkLocation
        '
        Me.dgvWorkLocation.AllowUserToAddRows = False
        Me.dgvWorkLocation.AllowUserToDeleteRows = False
        Me.dgvWorkLocation.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvWorkLocation.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id_Location, Me.UbicacionPrimaria, Me.Name_Location, Me.Address_Location, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.IdLocationPrimary})
        Me.dgvWorkLocation.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvWorkLocation.EnableHeadersVisualStyles = False
        Me.dgvWorkLocation.Location = New System.Drawing.Point(3, 78)
        Me.dgvWorkLocation.Name = "dgvWorkLocation"
        Me.dgvWorkLocation.ReadOnly = True
        Me.dgvWorkLocation.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvWorkLocation.RowHeadersVisible = False
        Me.dgvWorkLocation.ShowCellErrors = False
        Me.dgvWorkLocation.ShowCellToolTips = False
        Me.dgvWorkLocation.ShowEditingIcon = False
        Me.dgvWorkLocation.ShowRowErrors = False
        Me.dgvWorkLocation.Size = New System.Drawing.Size(1075, 453)
        Me.dgvWorkLocation.TabIndex = 0
        '
        'Id_Location
        '
        Me.Id_Location.DataPropertyName = "Id_Location"
        Me.Id_Location.HeaderText = "Correlativo"
        Me.Id_Location.Name = "Id_Location"
        Me.Id_Location.ReadOnly = True
        '
        'UbicacionPrimaria
        '
        Me.UbicacionPrimaria.DataPropertyName = "UbicacionPrimaria"
        Me.UbicacionPrimaria.HeaderText = "Ubicacion Primaria"
        Me.UbicacionPrimaria.Name = "UbicacionPrimaria"
        Me.UbicacionPrimaria.ReadOnly = True
        Me.UbicacionPrimaria.Width = 160
        '
        'Name_Location
        '
        Me.Name_Location.DataPropertyName = "Name_Location"
        Me.Name_Location.HeaderText = "Ubicación de Trabajo"
        Me.Name_Location.Name = "Name_Location"
        Me.Name_Location.ReadOnly = True
        Me.Name_Location.Width = 160
        '
        'Address_Location
        '
        Me.Address_Location.DataPropertyName = "Address_Location"
        Me.Address_Location.HeaderText = "Dirección de Ubicación"
        Me.Address_Location.Name = "Address_Location"
        Me.Address_Location.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Create_Users"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Creación"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Create_Date"
        DataGridViewCellStyle23.Format = "d"
        DataGridViewCellStyle23.NullValue = Nothing
        Me.DataGridViewTextBoxColumn8.DefaultCellStyle = DataGridViewCellStyle23
        Me.DataGridViewTextBoxColumn8.HeaderText = "Fecha Creación"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Modify_Users"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Modificó"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Modify_Date"
        DataGridViewCellStyle24.Format = "d"
        DataGridViewCellStyle24.NullValue = Nothing
        Me.DataGridViewTextBoxColumn10.DefaultCellStyle = DataGridViewCellStyle24
        Me.DataGridViewTextBoxColumn10.HeaderText = "Fecha Modificación"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'IdLocationPrimary
        '
        Me.IdLocationPrimary.DataPropertyName = "Id_LocationPrimary"
        Me.IdLocationPrimary.HeaderText = "IdLocationPrimary"
        Me.IdLocationPrimary.Name = "IdLocationPrimary"
        Me.IdLocationPrimary.ReadOnly = True
        Me.IdLocationPrimary.Visible = False
        '
        'FlowLayoutPanel4
        '
        Me.FlowLayoutPanel4.Controls.Add(Me.cmdCrearUbicacion)
        Me.FlowLayoutPanel4.Controls.Add(Me.cmdModificarUbicacion)
        Me.FlowLayoutPanel4.Controls.Add(Me.cmdEliminarUbicacion)
        Me.FlowLayoutPanel4.Controls.Add(Me.btnBuscarUbicacion)
        Me.FlowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel4.Location = New System.Drawing.Point(3, 3)
        Me.FlowLayoutPanel4.Name = "FlowLayoutPanel4"
        Me.FlowLayoutPanel4.Size = New System.Drawing.Size(1075, 69)
        Me.FlowLayoutPanel4.TabIndex = 1
        '
        'cmdCrearUbicacion
        '
        Me.cmdCrearUbicacion.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.cmdCrearUbicacion.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdCrearUbicacion.FlatAppearance.BorderSize = 0
        Me.cmdCrearUbicacion.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdCrearUbicacion.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdCrearUbicacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCrearUbicacion.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCrearUbicacion.Location = New System.Drawing.Point(3, 3)
        Me.cmdCrearUbicacion.Name = "cmdCrearUbicacion"
        Me.cmdCrearUbicacion.Size = New System.Drawing.Size(112, 66)
        Me.cmdCrearUbicacion.TabIndex = 37
        Me.cmdCrearUbicacion.Text = "Crear Ubicación"
        Me.cmdCrearUbicacion.UseVisualStyleBackColor = False
        Me.cmdCrearUbicacion.Visible = False
        '
        'cmdModificarUbicacion
        '
        Me.cmdModificarUbicacion.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.cmdModificarUbicacion.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdModificarUbicacion.FlatAppearance.BorderSize = 0
        Me.cmdModificarUbicacion.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdModificarUbicacion.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdModificarUbicacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdModificarUbicacion.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdModificarUbicacion.Location = New System.Drawing.Point(121, 3)
        Me.cmdModificarUbicacion.Name = "cmdModificarUbicacion"
        Me.cmdModificarUbicacion.Size = New System.Drawing.Size(121, 66)
        Me.cmdModificarUbicacion.TabIndex = 38
        Me.cmdModificarUbicacion.Text = "Modificar Ubicación"
        Me.cmdModificarUbicacion.UseVisualStyleBackColor = False
        Me.cmdModificarUbicacion.Visible = False
        '
        'cmdEliminarUbicacion
        '
        Me.cmdEliminarUbicacion.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.cmdEliminarUbicacion.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdEliminarUbicacion.FlatAppearance.BorderSize = 0
        Me.cmdEliminarUbicacion.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdEliminarUbicacion.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdEliminarUbicacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdEliminarUbicacion.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEliminarUbicacion.Location = New System.Drawing.Point(248, 3)
        Me.cmdEliminarUbicacion.Name = "cmdEliminarUbicacion"
        Me.cmdEliminarUbicacion.Size = New System.Drawing.Size(117, 66)
        Me.cmdEliminarUbicacion.TabIndex = 38
        Me.cmdEliminarUbicacion.Text = "Eliminar Ubicación"
        Me.cmdEliminarUbicacion.UseVisualStyleBackColor = False
        Me.cmdEliminarUbicacion.Visible = False
        '
        'btnBuscarUbicacion
        '
        Me.btnBuscarUbicacion.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.btnBuscarUbicacion.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.btnBuscarUbicacion.FlatAppearance.BorderSize = 0
        Me.btnBuscarUbicacion.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnBuscarUbicacion.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnBuscarUbicacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscarUbicacion.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarUbicacion.Location = New System.Drawing.Point(371, 3)
        Me.btnBuscarUbicacion.Name = "btnBuscarUbicacion"
        Me.btnBuscarUbicacion.Size = New System.Drawing.Size(138, 66)
        Me.btnBuscarUbicacion.TabIndex = 50
        Me.btnBuscarUbicacion.Text = "Buscar Ubicación"
        Me.btnBuscarUbicacion.UseVisualStyleBackColor = False
        '
        'btnAllEmpleados
        '
        Me.btnAllEmpleados.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.btnAllEmpleados.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.btnAllEmpleados.FlatAppearance.BorderSize = 0
        Me.btnAllEmpleados.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnAllEmpleados.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnAllEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAllEmpleados.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAllEmpleados.Location = New System.Drawing.Point(465, 3)
        Me.btnAllEmpleados.Name = "btnAllEmpleados"
        Me.btnAllEmpleados.Size = New System.Drawing.Size(102, 66)
        Me.btnAllEmpleados.TabIndex = 50
        Me.btnAllEmpleados.Text = "Todos Empleados"
        Me.btnAllEmpleados.UseVisualStyleBackColor = False
        '
        'ID_Employee
        '
        Me.ID_Employee.DataPropertyName = "ID_Employee"
        Me.ID_Employee.HeaderText = "Correlativo"
        Me.ID_Employee.Name = "ID_Employee"
        Me.ID_Employee.ReadOnly = True
        Me.ID_Employee.Width = 87
        '
        'Id_Company_FK
        '
        Me.Id_Company_FK.DataPropertyName = "Id_Company_FK"
        Me.Id_Company_FK.HeaderText = "Id_Company_FK"
        Me.Id_Company_FK.Name = "Id_Company_FK"
        Me.Id_Company_FK.ReadOnly = True
        Me.Id_Company_FK.Width = 65
        '
        'Id_Department_FK
        '
        Me.Id_Department_FK.DataPropertyName = "Id_Department_FK"
        Me.Id_Department_FK.HeaderText = "Id_Departament_FK"
        Me.Id_Department_FK.Name = "Id_Department_FK"
        Me.Id_Department_FK.ReadOnly = True
        Me.Id_Department_FK.Width = 66
        '
        'Id_WorkPosition_FK
        '
        Me.Id_WorkPosition_FK.DataPropertyName = "Id_WorkPosition_FK"
        Me.Id_WorkPosition_FK.HeaderText = "Id_WorkPosition_FK"
        Me.Id_WorkPosition_FK.Name = "Id_WorkPosition_FK"
        Me.Id_WorkPosition_FK.ReadOnly = True
        Me.Id_WorkPosition_FK.Width = 65
        '
        'Id_LocationJob_FK
        '
        Me.Id_LocationJob_FK.DataPropertyName = "Id_LocationJob_FK"
        Me.Id_LocationJob_FK.HeaderText = "Id_LocationJob_FK"
        Me.Id_LocationJob_FK.Name = "Id_LocationJob_FK"
        Me.Id_LocationJob_FK.ReadOnly = True
        Me.Id_LocationJob_FK.Width = 66
        '
        'Departamento
        '
        Me.Departamento.DataPropertyName = "Departamento"
        Me.Departamento.HeaderText = "Departamento"
        Me.Departamento.Name = "Departamento"
        Me.Departamento.ReadOnly = True
        Me.Departamento.Width = 210
        '
        'Posicion
        '
        Me.Posicion.DataPropertyName = "Posicion de Trabajo"
        Me.Posicion.HeaderText = "Posición de Trabajo"
        Me.Posicion.Name = "Posicion"
        Me.Posicion.ReadOnly = True
        Me.Posicion.Width = 250
        '
        'Ubicacion
        '
        Me.Ubicacion.DataPropertyName = "Ubicacion"
        Me.Ubicacion.HeaderText = "Ubicación Secundaria"
        Me.Ubicacion.Name = "Ubicacion"
        Me.Ubicacion.ReadOnly = True
        Me.Ubicacion.Width = 210
        '
        'ubicacionprimari
        '
        Me.ubicacionprimari.DataPropertyName = "locationprimary"
        Me.ubicacionprimari.HeaderText = "Ubicación Primaria"
        Me.ubicacionprimari.Name = "ubicacionprimari"
        Me.ubicacionprimari.ReadOnly = True
        Me.ubicacionprimari.Width = 250
        '
        'Nombre
        '
        Me.Nombre.DataPropertyName = "Nombre"
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        Me.Nombre.Width = 150
        '
        'SegundoNombre
        '
        Me.SegundoNombre.DataPropertyName = "Segundo Nombre"
        Me.SegundoNombre.HeaderText = "Segundo Nombre"
        Me.SegundoNombre.Name = "SegundoNombre"
        Me.SegundoNombre.ReadOnly = True
        Me.SegundoNombre.Width = 150
        '
        'TercerNombre
        '
        Me.TercerNombre.DataPropertyName = "Tercer Nombre"
        Me.TercerNombre.HeaderText = "Tercer Nombre"
        Me.TercerNombre.Name = "TercerNombre"
        Me.TercerNombre.ReadOnly = True
        Me.TercerNombre.Width = 150
        '
        'Apellido
        '
        Me.Apellido.DataPropertyName = "Apellido"
        Me.Apellido.HeaderText = "Apellido"
        Me.Apellido.Name = "Apellido"
        Me.Apellido.ReadOnly = True
        Me.Apellido.Width = 180
        '
        'SegundoApellido
        '
        Me.SegundoApellido.DataPropertyName = "Segundo Apellido"
        Me.SegundoApellido.HeaderText = "Segundo Apellido"
        Me.SegundoApellido.Name = "SegundoApellido"
        Me.SegundoApellido.ReadOnly = True
        Me.SegundoApellido.Width = 180
        '
        'TercerApellido
        '
        Me.TercerApellido.DataPropertyName = "Tercer Apellido"
        Me.TercerApellido.HeaderText = "Tercer Apellido"
        Me.TercerApellido.Name = "TercerApellido"
        Me.TercerApellido.ReadOnly = True
        Me.TercerApellido.Width = 180
        '
        'DUI
        '
        Me.DUI.DataPropertyName = "DUI"
        Me.DUI.HeaderText = "DUI"
        Me.DUI.Name = "DUI"
        Me.DUI.ReadOnly = True
        Me.DUI.Width = 180
        '
        'Email
        '
        Me.Email.DataPropertyName = "Email"
        Me.Email.HeaderText = "Email Empleado"
        Me.Email.Name = "Email"
        Me.Email.ReadOnly = True
        Me.Email.Width = 200
        '
        'Telefono
        '
        Me.Telefono.DataPropertyName = "Telefono"
        Me.Telefono.HeaderText = "Teléfono"
        Me.Telefono.Name = "Telefono"
        Me.Telefono.ReadOnly = True
        Me.Telefono.Width = 180
        '
        'Extension
        '
        Me.Extension.DataPropertyName = "Extension"
        Me.Extension.HeaderText = "Extensión"
        Me.Extension.Name = "Extension"
        Me.Extension.ReadOnly = True
        Me.Extension.Width = 180
        '
        'Salario
        '
        Me.Salario.DataPropertyName = "Salario Actual"
        Me.Salario.HeaderText = "Salario"
        Me.Salario.Name = "Salario"
        Me.Salario.ReadOnly = True
        Me.Salario.Visible = False
        Me.Salario.Width = 180
        '
        'Contacto
        '
        Me.Contacto.DataPropertyName = "Contact"
        Me.Contacto.HeaderText = "Contacto"
        Me.Contacto.Name = "Contacto"
        Me.Contacto.ReadOnly = True
        Me.Contacto.Width = 200
        '
        'Id_employee_Boss_FK
        '
        Me.Id_employee_Boss_FK.DataPropertyName = "Id_employee_Boss_FK"
        Me.Id_employee_Boss_FK.HeaderText = "Id_employee_Boss_FK"
        Me.Id_employee_Boss_FK.Name = "Id_employee_Boss_FK"
        Me.Id_employee_Boss_FK.ReadOnly = True
        Me.Id_employee_Boss_FK.Visible = False
        '
        'UserSiget
        '
        Me.UserSiget.DataPropertyName = "UserSiget"
        Me.UserSiget.HeaderText = "Usuario Siget"
        Me.UserSiget.Name = "UserSiget"
        Me.UserSiget.ReadOnly = True
        Me.UserSiget.Width = 180
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "Create_Users"
        Me.Column1.HeaderText = "Usuario Creacion"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Visible = False
        Me.Column1.Width = 180
        '
        'Create_Date
        '
        Me.Create_Date.DataPropertyName = "Create_Date"
        Me.Create_Date.HeaderText = "Fecha Creacion"
        Me.Create_Date.Name = "Create_Date"
        Me.Create_Date.ReadOnly = True
        Me.Create_Date.Visible = False
        Me.Create_Date.Width = 180
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "Modify_Users"
        Me.Column3.HeaderText = "Usuario Modificacion"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Visible = False
        Me.Column3.Width = 180
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "Modify_Date"
        Me.Column4.HeaderText = "Fecha Modificacion"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Visible = False
        Me.Column4.Width = 180
        '
        'id_responsable
        '
        Me.id_responsable.DataPropertyName = "id_responsable"
        Me.id_responsable.HeaderText = "idResponsable"
        Me.id_responsable.Name = "id_responsable"
        Me.id_responsable.ReadOnly = True
        Me.id_responsable.Visible = False
        '
        'responsable
        '
        Me.responsable.DataPropertyName = "responsable"
        Me.responsable.HeaderText = "Responsable"
        Me.responsable.Name = "responsable"
        Me.responsable.ReadOnly = True
        Me.responsable.Width = 250
        '
        'IdPrimaryLocation
        '
        Me.IdPrimaryLocation.DataPropertyName = "IdPrimaryLocation"
        Me.IdPrimaryLocation.HeaderText = "IdPrimaryLocation"
        Me.IdPrimaryLocation.Name = "IdPrimaryLocation"
        Me.IdPrimaryLocation.ReadOnly = True
        Me.IdPrimaryLocation.Visible = False
        '
        'ModuloRecursosHumanos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.tcMain)
        Me.Name = "ModuloRecursosHumanos"
        Me.Size = New System.Drawing.Size(1095, 579)
        Me.tcMain.ResumeLayout(False)
        Me.VistaGeneral.ResumeLayout(False)
        Me.NominaEmpleados.ResumeLayout(False)
        Me.TLP_PlanDePagos.ResumeLayout(False)
        CType(Me.dgvemployee, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel3.ResumeLayout(False)
        Me.Departamentos.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.dgvDepartamentos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.WorkPosition.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        CType(Me.dgvWorkPosition, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.UbicacionEmpleados.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        CType(Me.dgvWorkLocation, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents tcMain As TabControl
    Private WithEvents VistaGeneral As TabPage
    Private WithEvents gbStudentDetails As GroupBox
    Friend WithEvents NominaEmpleados As TabPage
    Friend WithEvents TLP_PlanDePagos As TableLayoutPanel
    Friend WithEvents dgvemployee As DataGridView
    Friend WithEvents FlowLayoutPanel3 As FlowLayoutPanel
    Private WithEvents Button1 As Button
    Private WithEvents Button2 As Button
    Private WithEvents Button3 As Button
    Friend WithEvents Departamentos As TabPage
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents dgvDepartamentos As DataGridView
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Private WithEvents cmdCreateDepartment As Button
    Private WithEvents cmdModifyDepartment As Button
    Private WithEvents cmdDeleteDepartment As Button
    Friend WithEvents WorkPosition As TabPage
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents dgvWorkPosition As DataGridView
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Private WithEvents cmbCreateWorkPosition As Button
    Private WithEvents cmbActualizarWorkPosition As Button
    Private WithEvents cmbEliminarWorkPosition As Button
    Friend WithEvents UbicacionEmpleados As TabPage
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents dgvWorkLocation As DataGridView
    Friend WithEvents FlowLayoutPanel4 As FlowLayoutPanel
    Private WithEvents cmdCrearUbicacion As Button
    Private WithEvents cmdModificarUbicacion As Button
    Private WithEvents cmdEliminarUbicacion As Button
    Friend WithEvents Id_WorkPosition As DataGridViewTextBoxColumn
    Friend WithEvents Name_WorkPosition As DataGridViewTextBoxColumn
    Friend WithEvents Is_CustomerService As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Private WithEvents btnBuscarEmpleado As Button
    Private WithEvents btnBuscarDepartamento As Button
    Private WithEvents btnBuscarPosicionTrabajo As Button
    Private WithEvents btnBuscarUbicacion As Button
    Friend WithEvents Id_Deparment As DataGridViewTextBoxColumn
    Friend WithEvents Name_Deparmnet As DataGridViewTextBoxColumn
    Friend WithEvents Create_Users As DataGridViewTextBoxColumn
    Friend WithEvents CreateDate As DataGridViewTextBoxColumn
    Friend WithEvents Modify_Users As DataGridViewTextBoxColumn
    Friend WithEvents Modify_Date As DataGridViewTextBoxColumn
    Friend WithEvents InternalCode As DataGridViewTextBoxColumn
    Friend WithEvents Id_Location As DataGridViewTextBoxColumn
    Friend WithEvents UbicacionPrimaria As DataGridViewTextBoxColumn
    Friend WithEvents Name_Location As DataGridViewTextBoxColumn
    Friend WithEvents Address_Location As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents IdLocationPrimary As DataGridViewTextBoxColumn
    Private WithEvents btnAllEmpleados As Button
    Friend WithEvents ID_Employee As DataGridViewTextBoxColumn
    Friend WithEvents Id_Company_FK As DataGridViewTextBoxColumn
    Friend WithEvents Id_Department_FK As DataGridViewTextBoxColumn
    Friend WithEvents Id_WorkPosition_FK As DataGridViewTextBoxColumn
    Friend WithEvents Id_LocationJob_FK As DataGridViewTextBoxColumn
    Friend WithEvents Departamento As DataGridViewTextBoxColumn
    Friend WithEvents Posicion As DataGridViewTextBoxColumn
    Friend WithEvents Ubicacion As DataGridViewTextBoxColumn
    Friend WithEvents ubicacionprimari As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents SegundoNombre As DataGridViewTextBoxColumn
    Friend WithEvents TercerNombre As DataGridViewTextBoxColumn
    Friend WithEvents Apellido As DataGridViewTextBoxColumn
    Friend WithEvents SegundoApellido As DataGridViewTextBoxColumn
    Friend WithEvents TercerApellido As DataGridViewTextBoxColumn
    Friend WithEvents DUI As DataGridViewTextBoxColumn
    Friend WithEvents Email As DataGridViewTextBoxColumn
    Friend WithEvents Telefono As DataGridViewTextBoxColumn
    Friend WithEvents Extension As DataGridViewTextBoxColumn
    Friend WithEvents Salario As DataGridViewTextBoxColumn
    Friend WithEvents Contacto As DataGridViewTextBoxColumn
    Friend WithEvents Id_employee_Boss_FK As DataGridViewTextBoxColumn
    Friend WithEvents UserSiget As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Create_Date As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents id_responsable As DataGridViewTextBoxColumn
    Friend WithEvents responsable As DataGridViewTextBoxColumn
    Friend WithEvents IdPrimaryLocation As DataGridViewTextBoxColumn
End Class
