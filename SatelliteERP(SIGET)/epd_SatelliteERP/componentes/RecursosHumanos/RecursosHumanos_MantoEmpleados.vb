Public Class RecursosHumanos_MantoEmpleados
#Region "Property"
    Private objDatos As New Generic_SQLServer
    Private _ObjValidacion As New Validaciones
    Private _DT_Deparment As New DataTable
    Private _DT_WorkPosition As New DataTable
    Private _DT_Location As New DataTable
    Private _DT_Boss As New DataTable
    Property Id_Employee As Long
    Property Id_legacy As Long
    Property Id_Discount As Long
    Property Id_Company As Long
    Property id_Deparment As Long
    Property Deparment As String
    Property IdPrimaryLocation As Integer
    Property Id_Location As Long
    Property Locationn As String
    Property Id_WorkPosition As Long
    Property WorkPosition As String
    Property Name_employee As String
    Property LastName_Employee As String
    Property DUI As String
    Property Email As String
    Property Telephone As String
    Property Extension As String
    Property Salary As Double

    'Ultimas propiedades
    Property UserSiget As String
    Property SecondSurname_employee As String
    Property ThridSurname_employee As String
    Property SecondName_Employee As String
    Property ThridName_Employee As String
    Property JefeInmediato As String
    '
    Property OpcionSeleccionada As Funcion
    Enum Funcion
        Agregar
        Actualizar
    End Enum

#End Region


    Private Sub RecursosHumanos_MantoEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            txtNameEmployee.Focus()
            _DT_Deparment = objDatos.GetDepartment(Data_Id_Company)
            If Not _DT_Deparment Is Nothing Then
                comboListDeparment.DataSource = _DT_Deparment
                comboListDeparment.DisplayMember = "Name_Deparmnet"
                comboListDeparment.ValueMember = "Id_Deparment"
                comboListDeparment.SelectedIndex = -1
            End If

            _DT_WorkPosition = objDatos.GetWorkPosition(Data_Id_Company)
            If Not _DT_WorkPosition Is Nothing Then
                comboListWorkPosition.DataSource = _DT_WorkPosition
                comboListWorkPosition.DisplayMember = "Name_WorkPosition"
                comboListWorkPosition.ValueMember = "Id_WorkPosition"
                comboListWorkPosition.SelectedIndex = -1
            End If

            _DT_Location = objDatos.GetLocationRRHH(Data_Id_Company)
            If Not _DT_Location Is Nothing Then
                CB_Location.DataSource = _DT_Location
                CB_Location.DisplayMember = "Name_Location"
                CB_Location.ValueMember = "Id_Location"
                CB_Location.SelectedIndex = -1
            End If

            _DT_Boss = objDatos.GetBossRRHH()
            If Not _DT_Boss Is Nothing Then
                cmbImmediateBoss.DataSource = _DT_Boss
                cmbImmediateBoss.DisplayMember = "Nombrejefe"
                cmbImmediateBoss.ValueMember = "Id_employee"
                cmbImmediateBoss.SelectedIndex = -1
            End If
            cmdDiscount.Enabled = False
        Catch ex As Exception
            MessageBox.Show("Ocurrió un problema al cargar la información", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Try
            Using obj As New HumanResources_SQLServer
                Dim _dtLocation As DataTable = obj.GetLocation(Data_Id_Company)
                CB_Location.DataSource = _dtLocation
                CB_Location.DisplayMember = "Name_Location"
                CB_Location.ValueMember = "Id_Location"
                CB_Location.SelectedIndex = -1
            End Using
        Catch ex As Exception

        End Try
        Try
            Dim dt As New DataTable
            Using obj As New Generic_SQLServer
                dt = obj.SP_ERP_Inventory_GetLocationPrimary()
            End Using
            cmb_UbicaconPrimaria.DataSource = dt
            cmb_UbicaconPrimaria.ValueMember = "ID_Location"
            cmb_UbicaconPrimaria.DisplayMember = "NameLocation"
            cmb_UbicaconPrimaria.SelectedIndex = -1
        Catch ex As Exception

        End Try
        If OpcionSeleccionada = Funcion.Actualizar Then
            'cmdDiscount.Enabled = True
            comboListDeparment.SelectedValue = _id_Deparment
            comboListWorkPosition.SelectedValue = _Id_WorkPosition
            cmb_UbicaconPrimaria.SelectedValue = IdPrimaryLocation

            Try
                Dim cont As Integer = 0
                cont = 0
                For i As Integer = 0 To CB_Location.Items.Count
                    If (CB_Location.Items(i).item(0) = _Id_Location) Then
                        CB_Location.SelectedIndex = cont
                        Exit For
                    End If
                    cont += 1
                Next
            Catch ex2 As Exception

            End Try

            cmbImmediateBoss.SelectedValue = _JefeInmediato

            txtNameEmployee.Text = _Name_employee
            txtLastNameEmployee.Text = _LastName_Employee
            txtDUI.Text = _DUI
            txtEmail.Text = _Email
            txtTelephoneEmployee.Text = _Telephone
            txtExtensionEmployee.Text = _Extension
            txtSalary.Text = _Salary

            txtIdResponsable.Enabled = False

            txtSecondSurname_employee.Text = _SecondSurname_employee
            txtThridSurname.Text = _ThridSurname_employee
            txtSecondName_Employee.Text = _SecondName_Employee
            txtThridName_Employee.Text = _ThridName_Employee
            txtUserSiget.Text = _UserSiget
            cmbImmediateBoss.Text = _JefeInmediato

            txtCode.Text = _Id_Employee
            txtIdResponsable.Text = _Id_legacy
            'txtImmediateBoss.Text = _JefeInmediato

        End If
        txtUserSiget.Enabled = False
    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        Dim resultado As Integer = 0
        If txtNameEmployee.Text.Trim = "" Then
            MessageBox.Show("Por favor introduzca el primer nombre del empleado", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
            txtNameEmployee.Select()
            Exit Sub
        End If
        'If txtSecondName_Employee.Text.Trim = "" Then
        '    MessageBox.Show("Por favor introduzca el segundo nombre", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
        '    txtSalary.Select()
        '    Exit Sub
        'End If

        If txtLastNameEmployee.Text.Trim = "" Then
            MessageBox.Show("Por favor introduzca el primer apellido del empleado.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
            txtLastNameEmployee.Select()
            Exit Sub
        End If

        'If txtSecondSurname_employee.Text.Trim = "" Then
        '    MessageBox.Show("Ingrese el segundo apellido", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
        '   txtSecondSurname_employee.Select()
        '    Exit Sub
        'End If

        'If txtEmail.Text.Trim = "" Then
        '    MessageBox.Show("Por favor introduzca el email del empleado", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
        '    txtEmail.Select()
        '    Exit Sub
        'End If
        'If Not _ObjValidacion.ValidateEmail(txtEmail.Text.Trim) Then
        '    MessageBox.Show("Por favor introduzca un email válido, con el formato siguiente(ejemplo@ejemplo.com)", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
        '    txtEmail.Select()
        '    Exit Sub
        'End If

        'If txtUserSiget.Text.Trim = "" Then
        '    MessageBox.Show("Ingrese el userSiget", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
        '    txtSalary.Select()
        '    Exit Sub
        'End If


        If CB_Location.SelectedIndex = -1 Then
            MessageBox.Show("Por favor seleccione una ubicación de trabajo", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If



        If comboListDeparment.SelectedIndex = -1 Then
            MessageBox.Show("Por favor seleccione un departamento", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If
        If comboListWorkPosition.SelectedIndex = -1 Then
            MessageBox.Show("Por favor seleccione una posición de trabajo", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If
        'If cmbImmediateBoss.Text.Trim = "" Then
        '    MessageBox.Show("Por favor seleccione el jefe inmediato", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
        '    txtSalary.Select()
        '    Exit Sub
        'End If

        'If txtTelephoneEmployee.Text.Trim = "" Then
        '    MessageBox.Show("Por favor introduzca el teléfono del empleado, con el formato siguiente(1234-5678)", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
        '    txtTelephoneEmployee.Select()
        '    Exit Sub
        'End If
        'If Not _ObjValidacion.ValidateTelephone(txtTelephoneEmployee.Text.Trim) Then
        '    MessageBox.Show("Por favor introduzca un número de teléfono válido, con el formato siguiente(1234-5678)", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
        '    txtTelephoneEmployee.Select()
        '    Exit Sub
        'End If


        If txtDUI.Text.Trim = "" Then
            MessageBox.Show("Por favor introduzca el DUI del empleado.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
            txtDUI.Select()
            Exit Sub
        End If
        If Not _ObjValidacion.ValidateDUI(txtDUI.Text.Trim) Then
            MessageBox.Show("Por favor introduzca un DUI válido, con el formato siguiente(12345678-0)", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
            txtDUI.Select()
            Exit Sub
        End If


        'If txtExtensionEmployee.Text.Trim = "" Then
        '    MessageBox.Show("Por favor introduzca el número de extensión del empleado", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
        '    txtExtensionEmployee.Select()
        '    Exit Sub
        'End If


        'txtSalary.Text = 1
        'If txtSalary.Text.Trim = "" Then
        '    MessageBox.Show("Por favor introduzca el salario del empleado", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
        '    txtSalary.Select()
        '    Exit Sub
        'End If

        'If txtThridName_Employee.Text.Trim = "" Then
        '    MessageBox.Show("Si no tienen 3° nombre, ingrese No", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
        '    txtSalary.Select()
        '    Exit Sub
        'End If

        'If txtThridSurname.Text.Trim = "" Then
        '    MessageBox.Show("Si no se a casado ingrese No", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
        '    txtSalary.Select()
        '    Exit Sub
        'End If



        '_Salary = txtSalary.Text.Trim = 1
        'If _Salary <= 0.0 Then
        '    MessageBox.Show("Por favor introduzca el salario del empleado", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
        '    txtSalary.Select()
        '    Exit Sub
        'End If

        _id_Deparment = comboListDeparment.SelectedValue
        _Id_WorkPosition = comboListWorkPosition.SelectedValue
        _Id_Location = CB_Location.SelectedValue
        _Name_employee = txtNameEmployee.Text.Trim
        _LastName_Employee = txtLastNameEmployee.Text.Trim
        _DUI = txtDUI.Text.Trim
        _Email = txtEmail.Text.Trim
        _Telephone = txtTelephoneEmployee.Text.Trim
        _Extension = txtExtensionEmployee.Text.Trim

        _UserSiget = txtUserSiget.Text.Trim
        _SecondSurname_employee = txtSecondSurname_employee.Text.Trim
        _ThridSurname_employee = txtThridSurname.Text.Trim
        _SecondName_Employee = txtSecondName_Employee.Text.Trim
        _ThridName_Employee = txtThridName_Employee.Text.Trim
        _JefeInmediato = cmbImmediateBoss.SelectedValue

        Try
            _Id_legacy = txtIdResponsable.Text

        Catch ex As Exception
            _Id_legacy = 0
        End Try
        Dim selectedItem As Object
        selectedItem = cmbImmediateBoss.SelectedItem

        If OpcionSeleccionada = Funcion.Agregar Then
            resultado = objDatos.InsertEmpoloyee(Data_Id_Company, _id_Deparment, _Id_WorkPosition, _Id_Location, _Name_employee, _LastName_Employee, _DUI, _Email, _Telephone, _Extension, _Salary, _UserSiget, _SecondSurname_employee, _ThridSurname_employee, _SecondName_Employee, _ThridName_Employee, _JefeInmediato, txtIdResponsable.Text)
            If resultado = 1 Then
                MessageBox.Show("El registro se agregó correctamente", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                DialogResult = DialogResult.OK
                Close()
            ElseIf resultado = 2 Then
                MessageBox.Show("Ya existe un empleado con este número de DUI, por favor verifique", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtDUI.Select()
                Exit Sub
            Else
                MessageBox.Show("No se pudo agregar el registro", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        ElseIf OpcionSeleccionada = Funcion.Actualizar Then
            resultado = objDatos.SetEmployee(_Id_Employee, Data_Id_Company, _id_Deparment, _Id_WorkPosition, _Id_Location, _Name_employee, _LastName_Employee, _DUI, _Email, _Telephone, _Extension, _Salary, _UserSiget, _SecondSurname_employee, _ThridSurname_employee, _SecondName_Employee, _ThridName_Employee, _JefeInmediato, txtIdResponsable.Text)
            If resultado = 1 Then
                MessageBox.Show("El registro se actualizó correctamente", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                DialogResult = DialogResult.OK
                Close()
            ElseIf resultado = 2 Then
                MessageBox.Show("Ya existe un empleado con este número de DUI, por favor verifique", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtDUI.Select()
                Exit Sub

            ElseIf resultado = 3 Then
                MessageBox.Show("Ya existe un empleado con este UsuarioSiget, por favor verifique", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtDUI.Select()
                Exit Sub
            Else
                MessageBox.Show("No se pudo actualizar el registro", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        End If
    End Sub


    Private Sub txtNameEmployee_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNameEmployee.KeyPress
        e.Handled = _ObjValidacion.JustLetters(sender, e)
    End Sub

    Private Sub txtLastNameEmployee_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLastNameEmployee.KeyPress
        e.Handled = _ObjValidacion.JustLetters(sender, e)
    End Sub

    Private Sub txtExtensionEmployee_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtExtensionEmployee.KeyPress
        e.Handled = _ObjValidacion.JustNumbers(sender, e)
    End Sub

    Private Sub txtSalary_KeyPress(sender As Object, e As KeyPressEventArgs)
        e.Handled = _ObjValidacion.JustNumbers(sender, e)
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub txtEmail_TextChanged(sender As Object, e As EventArgs) Handles txtEmail.TextChanged

    End Sub

    Private Sub txtSecondName_Employee_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSecondName_Employee.KeyPress
        e.Handled = _ObjValidacion.JustLetters(sender, e)
    End Sub

    Private Sub txtThridName_Employee_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtThridName_Employee.KeyPress
        e.Handled = _ObjValidacion.JustLetters(sender, e)
    End Sub

    Private Sub txtSecondSurname_employee_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSecondSurname_employee.KeyPress
        e.Handled = _ObjValidacion.JustLetters(sender, e)
    End Sub

    Private Sub txtThridSurname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtThridSurname.KeyPress
        e.Handled = _ObjValidacion.JustLetters(sender, e)
    End Sub

    Public Event DropDownOpened As EventHandler

    Private abierto As Integer = 1
    Private abierto2 As Integer = 1

    Private Sub comboListLocation_DropDown(sender As Object, e As EventArgs)
        abierto = 0
    End Sub

    Private Sub comboListLocation_KeyPress(sender As Object, e As KeyPressEventArgs)
        If (abierto = 0) Then
            e.Handled = True
        End If
    End Sub

    Private Sub comboListLocation_DropDownClosed(sender As Object, e As EventArgs)
        abierto = 1
    End Sub

    Private Sub comboListDeparment_DropDown(sender As Object, e As EventArgs) Handles comboListDeparment.DropDown
        abierto = 0
    End Sub

    Private Sub comboListDeparment_KeyPress(sender As Object, e As KeyPressEventArgs) Handles comboListDeparment.KeyPress
        If (abierto = 0) Then
            e.Handled = True
        End If
    End Sub

    Private Sub comboListDeparment_DropDownClosed(sender As Object, e As EventArgs) Handles comboListDeparment.DropDownClosed
        abierto = 1
    End Sub

    Private Sub comboListWorkPosition_DropDown(sender As Object, e As EventArgs) Handles comboListWorkPosition.DropDown
        abierto = 0
    End Sub

    Private Sub comboListWorkPosition_KeyPress(sender As Object, e As KeyPressEventArgs) Handles comboListWorkPosition.KeyPress
        If (abierto = 0) Then
            e.Handled = True
        End If
    End Sub

    Private Sub comboListWorkPosition_DropDownClosed(sender As Object, e As EventArgs) Handles comboListWorkPosition.DropDownClosed
        abierto = 1
    End Sub

    Private Sub cmbImmediateBoss_DropDown(sender As Object, e As EventArgs) Handles cmbImmediateBoss.DropDown
        abierto = 0
    End Sub

    Private Sub cmbImmediateBoss_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbImmediateBoss.KeyPress
        If (abierto = 0) Then
            e.Handled = True
        End If
    End Sub

    Private Sub cmbImmediateBoss_DropDownClosed(sender As Object, e As EventArgs) Handles cmbImmediateBoss.DropDownClosed
        abierto = 1
    End Sub
#Region " Move Form "
    Public MoveForm As Boolean
    Public MoveForm_MousePosition As Point
    Public Sub MoveForm_MouseDown(sender As Object, e As MouseEventArgs) Handles _
    MyBase.MouseDown ' Add more handles here (Example: PictureBox1.MouseDown)
        If e.Button = MouseButtons.Left Then
            MoveForm = True
            Me.Cursor = Cursors.NoMove2D
            MoveForm_MousePosition = e.Location
        End If
    End Sub
    Public Sub MoveForm_MouseMove(sender As Object, e As MouseEventArgs) Handles _
    MyBase.MouseMove ' Add more handles here (Example: PictureBox1.MouseMove)
        If MoveForm Then
            Me.Location = Me.Location + (e.Location - MoveForm_MousePosition)
        End If
    End Sub
    Public Sub MoveForm_MouseUp(sender As Object, e As MouseEventArgs) Handles _
    MyBase.MouseUp ' Add more handles here (Example: PictureBox1.MouseUp)
        If e.Button = MouseButtons.Left Then
            MoveForm = False
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub lblUbication_Click(sender As Object, e As EventArgs) Handles lblUbication.Click

    End Sub

    Private Sub cmb_UbicaconPrimaria_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_UbicaconPrimaria.SelectedIndexChanged
        Try
            CB_Location.SelectedIndex = -1
            CB_Location.Items.Clear()

        Catch ex As Exception

        End Try

        If (cmb_UbicaconPrimaria.SelectedIndex > 0) Then
            Using obj As New HumanResources_SQLServer
                Dim _dtLocation As DataTable = obj.GetLocationByPrimary(Data_Id_Company, cmb_UbicaconPrimaria.SelectedValue)
                CB_Location.DataSource = _dtLocation
                CB_Location.DisplayMember = "Name_Location"
                CB_Location.ValueMember = "Id_Location"
                CB_Location.SelectedIndex = -1
            End Using
        End If
    End Sub

#End Region

End Class