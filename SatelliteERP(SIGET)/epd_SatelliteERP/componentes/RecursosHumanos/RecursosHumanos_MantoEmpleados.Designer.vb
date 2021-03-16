<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RecursosHumanos_MantoEmpleados
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmb_UbicaconPrimaria = New System.Windows.Forms.ComboBox()
        Me.CB_Location = New System.Windows.Forms.ComboBox()
        Me.txtIdResponsable = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtThridName_Employee = New System.Windows.Forms.TextBox()
        Me.txtSecondName_Employee = New System.Windows.Forms.TextBox()
        Me.cmbImmediateBoss = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.txtSalary = New System.Windows.Forms.TextBox()
        Me.txtUserSiget = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtThridSurname = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtSecondSurname_employee = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblThridName_Employee = New System.Windows.Forms.Label()
        Me.lblSecondName_Employee = New System.Windows.Forms.Label()
        Me.lblPrimerNombre = New System.Windows.Forms.Label()
        Me.lblCodigoEmpleado = New System.Windows.Forms.Label()
        Me.txtTelephoneEmployee = New System.Windows.Forms.MaskedTextBox()
        Me.txtDUI = New System.Windows.Forms.MaskedTextBox()
        Me.lblDUI = New System.Windows.Forms.Label()
        Me.cmdDiscount = New System.Windows.Forms.Button()
        Me.txtExtensionEmployee = New System.Windows.Forms.TextBox()
        Me.lblExtensionEmployee = New System.Windows.Forms.Label()
        Me.lblTelephoneEmployee = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblUbication = New System.Windows.Forms.Label()
        Me.txtLastNameEmployee = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.comboListWorkPosition = New System.Windows.Forms.ComboBox()
        Me.comboListDeparment = New System.Windows.Forms.ComboBox()
        Me.lblWorkPosition = New System.Windows.Forms.Label()
        Me.txtNameEmployee = New System.Windows.Forms.TextBox()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.lblDepartment = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cmb_UbicaconPrimaria)
        Me.GroupBox1.Controls.Add(Me.CB_Location)
        Me.GroupBox1.Controls.Add(Me.txtIdResponsable)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtThridName_Employee)
        Me.GroupBox1.Controls.Add(Me.txtSecondName_Employee)
        Me.GroupBox1.Controls.Add(Me.cmbImmediateBoss)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtCode)
        Me.GroupBox1.Controls.Add(Me.txtSalary)
        Me.GroupBox1.Controls.Add(Me.txtUserSiget)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtThridSurname)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtSecondSurname_employee)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.lblThridName_Employee)
        Me.GroupBox1.Controls.Add(Me.lblSecondName_Employee)
        Me.GroupBox1.Controls.Add(Me.lblPrimerNombre)
        Me.GroupBox1.Controls.Add(Me.lblCodigoEmpleado)
        Me.GroupBox1.Controls.Add(Me.txtTelephoneEmployee)
        Me.GroupBox1.Controls.Add(Me.txtDUI)
        Me.GroupBox1.Controls.Add(Me.lblDUI)
        Me.GroupBox1.Controls.Add(Me.cmdDiscount)
        Me.GroupBox1.Controls.Add(Me.txtExtensionEmployee)
        Me.GroupBox1.Controls.Add(Me.lblExtensionEmployee)
        Me.GroupBox1.Controls.Add(Me.lblTelephoneEmployee)
        Me.GroupBox1.Controls.Add(Me.txtEmail)
        Me.GroupBox1.Controls.Add(Me.lblEmail)
        Me.GroupBox1.Controls.Add(Me.lblUbication)
        Me.GroupBox1.Controls.Add(Me.txtLastNameEmployee)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.comboListWorkPosition)
        Me.GroupBox1.Controls.Add(Me.comboListDeparment)
        Me.GroupBox1.Controls.Add(Me.lblWorkPosition)
        Me.GroupBox1.Controls.Add(Me.txtNameEmployee)
        Me.GroupBox1.Controls.Add(Me.cmdCancel)
        Me.GroupBox1.Controls.Add(Me.cmdSave)
        Me.GroupBox1.Controls.Add(Me.lblDepartment)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1209, 480)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Configuración de Empleado"
        '
        'cmb_UbicaconPrimaria
        '
        Me.cmb_UbicaconPrimaria.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmb_UbicaconPrimaria.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmb_UbicaconPrimaria.BackColor = System.Drawing.Color.Gainsboro
        Me.cmb_UbicaconPrimaria.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmb_UbicaconPrimaria.Font = New System.Drawing.Font("Segoe UI", 13.25!)
        Me.cmb_UbicaconPrimaria.ForeColor = System.Drawing.SystemColors.MenuText
        Me.cmb_UbicaconPrimaria.FormattingEnabled = True
        Me.cmb_UbicaconPrimaria.Location = New System.Drawing.Point(612, 83)
        Me.cmb_UbicaconPrimaria.Name = "cmb_UbicaconPrimaria"
        Me.cmb_UbicaconPrimaria.Size = New System.Drawing.Size(591, 33)
        Me.cmb_UbicaconPrimaria.TabIndex = 88
        '
        'CB_Location
        '
        Me.CB_Location.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CB_Location.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CB_Location.BackColor = System.Drawing.Color.Gainsboro
        Me.CB_Location.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CB_Location.Font = New System.Drawing.Font("Segoe UI", 13.25!)
        Me.CB_Location.FormattingEnabled = True
        Me.CB_Location.Location = New System.Drawing.Point(612, 124)
        Me.CB_Location.Name = "CB_Location"
        Me.CB_Location.Size = New System.Drawing.Size(591, 33)
        Me.CB_Location.TabIndex = 87
        '
        'txtIdResponsable
        '
        Me.txtIdResponsable.BackColor = System.Drawing.Color.Gainsboro
        Me.txtIdResponsable.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtIdResponsable.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdResponsable.Location = New System.Drawing.Point(623, 402)
        Me.txtIdResponsable.MaxLength = 30
        Me.txtIdResponsable.Name = "txtIdResponsable"
        Me.txtIdResponsable.ShortcutsEnabled = False
        Me.txtIdResponsable.Size = New System.Drawing.Size(176, 26)
        Me.txtIdResponsable.TabIndex = 33
        Me.txtIdResponsable.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(420, 403)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(205, 25)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Id Responsable Legacy:"
        Me.Label2.Visible = False
        '
        'txtThridName_Employee
        '
        Me.txtThridName_Employee.BackColor = System.Drawing.Color.Gainsboro
        Me.txtThridName_Employee.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtThridName_Employee.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtThridName_Employee.Location = New System.Drawing.Point(200, 167)
        Me.txtThridName_Employee.MaxLength = 50
        Me.txtThridName_Employee.Name = "txtThridName_Employee"
        Me.txtThridName_Employee.ShortcutsEnabled = False
        Me.txtThridName_Employee.Size = New System.Drawing.Size(216, 26)
        Me.txtThridName_Employee.TabIndex = 7
        '
        'txtSecondName_Employee
        '
        Me.txtSecondName_Employee.BackColor = System.Drawing.Color.Gainsboro
        Me.txtSecondName_Employee.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSecondName_Employee.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSecondName_Employee.Location = New System.Drawing.Point(200, 127)
        Me.txtSecondName_Employee.MaxLength = 50
        Me.txtSecondName_Employee.Name = "txtSecondName_Employee"
        Me.txtSecondName_Employee.ShortcutsEnabled = False
        Me.txtSecondName_Employee.Size = New System.Drawing.Size(216, 26)
        Me.txtSecondName_Employee.TabIndex = 5
        '
        'cmbImmediateBoss
        '
        Me.cmbImmediateBoss.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbImmediateBoss.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbImmediateBoss.BackColor = System.Drawing.Color.Gainsboro
        Me.cmbImmediateBoss.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbImmediateBoss.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbImmediateBoss.FormattingEnabled = True
        Me.cmbImmediateBoss.Location = New System.Drawing.Point(612, 240)
        Me.cmbImmediateBoss.Name = "cmbImmediateBoss"
        Me.cmbImmediateBoss.Size = New System.Drawing.Size(573, 29)
        Me.cmbImmediateBoss.TabIndex = 25
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(478, 246)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(139, 25)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Jefe Inmediato:"
        '
        'txtCode
        '
        Me.txtCode.BackColor = System.Drawing.Color.Gainsboro
        Me.txtCode.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCode.Enabled = False
        Me.txtCode.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCode.Location = New System.Drawing.Point(200, 46)
        Me.txtCode.MaxLength = 50
        Me.txtCode.Name = "txtCode"
        Me.txtCode.ReadOnly = True
        Me.txtCode.ShortcutsEnabled = False
        Me.txtCode.Size = New System.Drawing.Size(98, 26)
        Me.txtCode.TabIndex = 1
        '
        'txtSalary
        '
        Me.txtSalary.Location = New System.Drawing.Point(232, 505)
        Me.txtSalary.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSalary.Name = "txtSalary"
        Me.txtSalary.Size = New System.Drawing.Size(76, 33)
        Me.txtSalary.TabIndex = 63
        Me.txtSalary.Text = "1"
        '
        'txtUserSiget
        '
        Me.txtUserSiget.BackColor = System.Drawing.Color.Gainsboro
        Me.txtUserSiget.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUserSiget.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserSiget.Location = New System.Drawing.Point(612, 47)
        Me.txtUserSiget.MaxLength = 250
        Me.txtUserSiget.Name = "txtUserSiget"
        Me.txtUserSiget.ShortcutsEnabled = False
        Me.txtUserSiget.Size = New System.Drawing.Size(247, 26)
        Me.txtUserSiget.TabIndex = 17
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(516, 47)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(101, 25)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "UserSiget: "
        '
        'txtThridSurname
        '
        Me.txtThridSurname.BackColor = System.Drawing.Color.Gainsboro
        Me.txtThridSurname.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtThridSurname.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtThridSurname.Location = New System.Drawing.Point(200, 289)
        Me.txtThridSurname.MaxLength = 50
        Me.txtThridSurname.Name = "txtThridSurname"
        Me.txtThridSurname.ShortcutsEnabled = False
        Me.txtThridSurname.Size = New System.Drawing.Size(216, 26)
        Me.txtThridSurname.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(34, 285)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(157, 25)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Apellido Casada: "
        '
        'txtSecondSurname_employee
        '
        Me.txtSecondSurname_employee.BackColor = System.Drawing.Color.Gainsboro
        Me.txtSecondSurname_employee.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSecondSurname_employee.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSecondSurname_employee.Location = New System.Drawing.Point(200, 249)
        Me.txtSecondSurname_employee.MaxLength = 50
        Me.txtSecondSurname_employee.Name = "txtSecondSurname_employee"
        Me.txtSecondSurname_employee.ShortcutsEnabled = False
        Me.txtSecondSurname_employee.Size = New System.Drawing.Size(216, 26)
        Me.txtSecondSurname_employee.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(19, 246)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(171, 25)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Segundo Apellido: "
        '
        'lblThridName_Employee
        '
        Me.lblThridName_Employee.AutoSize = True
        Me.lblThridName_Employee.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblThridName_Employee.Location = New System.Drawing.Point(47, 166)
        Me.lblThridName_Employee.Name = "lblThridName_Employee"
        Me.lblThridName_Employee.Size = New System.Drawing.Size(141, 25)
        Me.lblThridName_Employee.TabIndex = 6
        Me.lblThridName_Employee.Text = "Tercer Nombre:"
        '
        'lblSecondName_Employee
        '
        Me.lblSecondName_Employee.AutoSize = True
        Me.lblSecondName_Employee.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSecondName_Employee.Location = New System.Drawing.Point(20, 126)
        Me.lblSecondName_Employee.Name = "lblSecondName_Employee"
        Me.lblSecondName_Employee.Size = New System.Drawing.Size(165, 25)
        Me.lblSecondName_Employee.TabIndex = 4
        Me.lblSecondName_Employee.Text = "Segundo Nombre:"
        '
        'lblPrimerNombre
        '
        Me.lblPrimerNombre.AutoSize = True
        Me.lblPrimerNombre.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrimerNombre.Location = New System.Drawing.Point(41, 86)
        Me.lblPrimerNombre.Name = "lblPrimerNombre"
        Me.lblPrimerNombre.Size = New System.Drawing.Size(146, 25)
        Me.lblPrimerNombre.TabIndex = 2
        Me.lblPrimerNombre.Text = "Primer Nombre:"
        '
        'lblCodigoEmpleado
        '
        Me.lblCodigoEmpleado.AutoSize = True
        Me.lblCodigoEmpleado.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigoEmpleado.Location = New System.Drawing.Point(22, 47)
        Me.lblCodigoEmpleado.Name = "lblCodigoEmpleado"
        Me.lblCodigoEmpleado.Size = New System.Drawing.Size(166, 25)
        Me.lblCodigoEmpleado.TabIndex = 0
        Me.lblCodigoEmpleado.Text = "Código Empleado:"
        '
        'txtTelephoneEmployee
        '
        Me.txtTelephoneEmployee.Location = New System.Drawing.Point(614, 279)
        Me.txtTelephoneEmployee.Margin = New System.Windows.Forms.Padding(2)
        Me.txtTelephoneEmployee.Mask = "0000-0000"
        Me.txtTelephoneEmployee.Name = "txtTelephoneEmployee"
        Me.txtTelephoneEmployee.Size = New System.Drawing.Size(187, 33)
        Me.txtTelephoneEmployee.TabIndex = 27
        '
        'txtDUI
        '
        Me.txtDUI.Location = New System.Drawing.Point(616, 320)
        Me.txtDUI.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDUI.Mask = "00000000-0"
        Me.txtDUI.Name = "txtDUI"
        Me.txtDUI.Size = New System.Drawing.Size(187, 33)
        Me.txtDUI.TabIndex = 29
        '
        'lblDUI
        '
        Me.lblDUI.AutoSize = True
        Me.lblDUI.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDUI.Location = New System.Drawing.Point(570, 325)
        Me.lblDUI.Name = "lblDUI"
        Me.lblDUI.Size = New System.Drawing.Size(47, 25)
        Me.lblDUI.TabIndex = 28
        Me.lblDUI.Text = "DUI:"
        '
        'cmdDiscount
        '
        Me.cmdDiscount.BackColor = System.Drawing.Color.Gainsboro
        Me.cmdDiscount.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdDiscount.FlatAppearance.BorderSize = 0
        Me.cmdDiscount.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.cmdDiscount.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.cmdDiscount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdDiscount.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDiscount.Location = New System.Drawing.Point(56, 518)
        Me.cmdDiscount.Name = "cmdDiscount"
        Me.cmdDiscount.Size = New System.Drawing.Size(98, 29)
        Me.cmdDiscount.TabIndex = 48
        Me.cmdDiscount.Text = "Descuentos"
        Me.cmdDiscount.UseVisualStyleBackColor = False
        Me.cmdDiscount.Visible = False
        '
        'txtExtensionEmployee
        '
        Me.txtExtensionEmployee.BackColor = System.Drawing.Color.Gainsboro
        Me.txtExtensionEmployee.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtExtensionEmployee.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtExtensionEmployee.Location = New System.Drawing.Point(620, 362)
        Me.txtExtensionEmployee.MaxLength = 4
        Me.txtExtensionEmployee.Name = "txtExtensionEmployee"
        Me.txtExtensionEmployee.ShortcutsEnabled = False
        Me.txtExtensionEmployee.Size = New System.Drawing.Size(176, 26)
        Me.txtExtensionEmployee.TabIndex = 31
        '
        'lblExtensionEmployee
        '
        Me.lblExtensionEmployee.AutoSize = True
        Me.lblExtensionEmployee.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExtensionEmployee.Location = New System.Drawing.Point(430, 365)
        Me.lblExtensionEmployee.Name = "lblExtensionEmployee"
        Me.lblExtensionEmployee.Size = New System.Drawing.Size(191, 25)
        Me.lblExtensionEmployee.TabIndex = 30
        Me.lblExtensionEmployee.Text = "Extensión Empleado: "
        '
        'lblTelephoneEmployee
        '
        Me.lblTelephoneEmployee.AutoSize = True
        Me.lblTelephoneEmployee.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelephoneEmployee.Location = New System.Drawing.Point(439, 286)
        Me.lblTelephoneEmployee.Name = "lblTelephoneEmployee"
        Me.lblTelephoneEmployee.Size = New System.Drawing.Size(182, 25)
        Me.lblTelephoneEmployee.TabIndex = 26
        Me.lblTelephoneEmployee.Text = "Teléfono Empleado: "
        '
        'txtEmail
        '
        Me.txtEmail.BackColor = System.Drawing.Color.Gainsboro
        Me.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEmail.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(200, 330)
        Me.txtEmail.MaxLength = 250
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.ShortcutsEnabled = False
        Me.txtEmail.Size = New System.Drawing.Size(216, 26)
        Me.txtEmail.TabIndex = 15
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.Location = New System.Drawing.Point(123, 325)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(67, 25)
        Me.lblEmail.TabIndex = 14
        Me.lblEmail.Text = "Email: "
        '
        'lblUbication
        '
        Me.lblUbication.AutoSize = True
        Me.lblUbication.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUbication.Location = New System.Drawing.Point(478, 132)
        Me.lblUbication.Name = "lblUbication"
        Me.lblUbication.Size = New System.Drawing.Size(139, 25)
        Me.lblUbication.TabIndex = 18
        Me.lblUbication.Text = "Ubicación Sec: "
        '
        'txtLastNameEmployee
        '
        Me.txtLastNameEmployee.BackColor = System.Drawing.Color.Gainsboro
        Me.txtLastNameEmployee.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtLastNameEmployee.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastNameEmployee.Location = New System.Drawing.Point(200, 208)
        Me.txtLastNameEmployee.MaxLength = 50
        Me.txtLastNameEmployee.Name = "txtLastNameEmployee"
        Me.txtLastNameEmployee.ShortcutsEnabled = False
        Me.txtLastNameEmployee.Size = New System.Drawing.Size(216, 26)
        Me.txtLastNameEmployee.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(39, 206)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 25)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Primer Apellido: "
        '
        'comboListWorkPosition
        '
        Me.comboListWorkPosition.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.comboListWorkPosition.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.comboListWorkPosition.BackColor = System.Drawing.Color.Gainsboro
        Me.comboListWorkPosition.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.comboListWorkPosition.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboListWorkPosition.FormattingEnabled = True
        Me.comboListWorkPosition.Location = New System.Drawing.Point(612, 201)
        Me.comboListWorkPosition.Name = "comboListWorkPosition"
        Me.comboListWorkPosition.Size = New System.Drawing.Size(573, 29)
        Me.comboListWorkPosition.TabIndex = 23
        '
        'comboListDeparment
        '
        Me.comboListDeparment.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.comboListDeparment.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.comboListDeparment.BackColor = System.Drawing.Color.Gainsboro
        Me.comboListDeparment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.comboListDeparment.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboListDeparment.FormattingEnabled = True
        Me.comboListDeparment.Location = New System.Drawing.Point(612, 162)
        Me.comboListDeparment.Name = "comboListDeparment"
        Me.comboListDeparment.Size = New System.Drawing.Size(573, 29)
        Me.comboListDeparment.TabIndex = 21
        '
        'lblWorkPosition
        '
        Me.lblWorkPosition.AutoSize = True
        Me.lblWorkPosition.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWorkPosition.Location = New System.Drawing.Point(437, 206)
        Me.lblWorkPosition.Name = "lblWorkPosition"
        Me.lblWorkPosition.Size = New System.Drawing.Size(184, 25)
        Me.lblWorkPosition.TabIndex = 22
        Me.lblWorkPosition.Text = "Posición de Trabajo: "
        '
        'txtNameEmployee
        '
        Me.txtNameEmployee.BackColor = System.Drawing.Color.Gainsboro
        Me.txtNameEmployee.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNameEmployee.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNameEmployee.Location = New System.Drawing.Point(200, 86)
        Me.txtNameEmployee.MaxLength = 50
        Me.txtNameEmployee.Name = "txtNameEmployee"
        Me.txtNameEmployee.ShortcutsEnabled = False
        Me.txtNameEmployee.Size = New System.Drawing.Size(216, 26)
        Me.txtNameEmployee.TabIndex = 3
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
        Me.cmdCancel.Location = New System.Drawing.Point(503, 423)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(98, 29)
        Me.cmdCancel.TabIndex = 35
        Me.cmdCancel.Text = "Cancelar"
        Me.cmdCancel.UseVisualStyleBackColor = False
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
        Me.cmdSave.Location = New System.Drawing.Point(399, 423)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(98, 29)
        Me.cmdSave.TabIndex = 34
        Me.cmdSave.Text = "Grabar"
        Me.cmdSave.UseVisualStyleBackColor = False
        '
        'lblDepartment
        '
        Me.lblDepartment.AutoSize = True
        Me.lblDepartment.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDepartment.Location = New System.Drawing.Point(478, 166)
        Me.lblDepartment.Name = "lblDepartment"
        Me.lblDepartment.Size = New System.Drawing.Size(142, 25)
        Me.lblDepartment.TabIndex = 20
        Me.lblDepartment.Text = "Departamento: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(464, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(148, 25)
        Me.Label3.TabIndex = 89
        Me.Label3.Text = "Ubicación Princ:"
        '
        'RecursosHumanos_MantoEmpleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(1233, 506)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "RecursosHumanos_MantoEmpleados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Finaciero_CrearCuentaoContable"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Private WithEvents lblDUI As Label
    Private WithEvents cmdDiscount As Button
    Private WithEvents txtExtensionEmployee As TextBox
    Private WithEvents lblExtensionEmployee As Label
    Private WithEvents lblTelephoneEmployee As Label
    Private WithEvents txtEmail As TextBox
    Private WithEvents lblEmail As Label
    Private WithEvents lblUbication As Label
    Private WithEvents txtLastNameEmployee As TextBox
    Private WithEvents Label1 As Label
    Private WithEvents comboListWorkPosition As ComboBox
    Private WithEvents comboListDeparment As ComboBox
    Private WithEvents lblWorkPosition As Label
    Private WithEvents txtNameEmployee As TextBox
    Private WithEvents cmdCancel As Button
    Private WithEvents cmdSave As Button
    Private WithEvents lblDepartment As Label
    Friend WithEvents txtDUI As MaskedTextBox
    Friend WithEvents txtTelephoneEmployee As MaskedTextBox
    Private WithEvents lblPrimerNombre As Label
    Private WithEvents lblCodigoEmpleado As Label
    Private WithEvents lblThridName_Employee As Label
    Private WithEvents lblSecondName_Employee As Label
    Private WithEvents txtThridSurname As TextBox
    Private WithEvents Label5 As Label
    Private WithEvents txtSecondSurname_employee As TextBox
    Private WithEvents Label4 As Label
    Private WithEvents txtUserSiget As TextBox
    Private WithEvents Label6 As Label
    Friend WithEvents txtSalary As TextBox
    Private WithEvents txtCode As TextBox
    Private WithEvents Label7 As Label
    Private WithEvents cmbImmediateBoss As ComboBox
    Private WithEvents txtThridName_Employee As TextBox
    Private WithEvents txtSecondName_Employee As TextBox
    Private WithEvents txtIdResponsable As TextBox
    Private WithEvents Label2 As Label
    Friend WithEvents cmb_UbicaconPrimaria As ComboBox
    Private WithEvents CB_Location As ComboBox
    Private WithEvents Label3 As Label
End Class
