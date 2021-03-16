Public Class ERP_ClientesCuentasPorCobrar

#Region "Property"
    Property IsBigContributter As Boolean = False
    Property Is_Supplier As Boolean = False
    Private _DT_TipoCliente As DataTable = Nothing
    Private _DT_Municipality As DataTable = Nothing
    Private _DT_ContactEmployee As DataTable = Nothing
    Private _DT_CompanyCategory As DataTable = Nothing

    Property Id_Customer As Long = Nothing
    Property id_Company As Long = Data_Id_Company
    Property Id_TypeCustomer_FK As Long = Nothing
    Property Id_Minicipality_FK As Long = Nothing
    Property Id_EmployeelContact_FK As Long = Nothing
    Property Id_CompanyCategory_Fk As Long = Nothing
    Property Is_Exempt As Boolean = False
    Property Is_LegalEntity As Boolean = False
    Property Business_Name As String = ""
    Property Commercial_Name As String = ""
    Property First_Name As String = ""
    Property Last_Name As String = ""
    Property Address As String = ""
    Property OfficePhone As String = ""
    Property Email_Contact As String = ""
    Property Identity_DocumentNumber As String = ""
    Property Tax_Registration_Number As String = ""
    Property Tax_Identification_Number As String = ""
    Property OpcionSeleccionada As Funcion
    Property TipoConsulta As Proceso
    Property Turning_Company As String
    Property Company_Category As String
    Private islegalty As Boolean = False
    Property DepemdeSIC As Boolean = False
    Property IDSIC As String
    Property Observaciones As String
    Enum Funcion
        Agregar
        Actualizar
    End Enum

    Enum Proceso
        Clientes
        Proveedores
    End Enum

#End Region
   
    Private Sub ERP_ClientesCuentasPorCobrar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtNameCompany.ReadOnly = True
        txtComercialNameCompany.ReadOnly = True
        If FillCBTipoCliente() Then
            FillCBMunicipality()
            FillCBCompanyCategory()
            FillCBContactEmployee()
        End If
        Select Case _OpcionSeleccionada
            Case Funcion.Actualizar
                GBAddCustomer.Text = "Actualizar "
                Try
                    chkBigContributer.Checked = _IsBigContributter
                    checkExentoIVA.Checked = Is_Exempt
                    CheckLegalEntity.Checked = Is_LegalEntity
                    txtNameCompany.Text = Business_Name
                    txtComercialNameCompany.Text = Commercial_Name
                    txtFirstName.Text = First_Name
                    txtLastName.Text = Last_Name
                    txtAddress.Text = Address
                    txtTelephoneContact.Text = OfficePhone
                    txtEmailContact.Text = Email_Contact
                    txtDUI.Text = Identity_DocumentNumber
                    txtRegistrationNumber.Text = Tax_Registration_Number
                    txtNIT.Text = Tax_Identification_Number
                    txt_Turning_Company.Text = Turning_Company
                    Try
                        cbCompanyCategory.SelectedIndex = Id_CompanyCategory_Fk
                    Catch ex As Exception
                        ' La categoria no existe genera un error
                    End Try


                    CK_Proveedor.Checked = Is_Supplier
                    CK_DepemdeSIC.Checked = DepemdeSIC
                    txtObservaciones.Text = Observaciones
                    txtIDSIC.Text = IDSIC
                Catch ex As Exception
                    Using objLog As New ProcessGeneral
                        objLog.AlmacenarLog(5, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                    End Using
                End Try
            Case Funcion.Agregar
                GBAddCustomer.Text = "Agregar "
        End Select
        Select Case TipoConsulta
            Case Proceso.Clientes
                GBAddCustomer.Text = GBAddCustomer.Text + "Proveedores"
            Case Proceso.Proveedores
                GBAddCustomer.Text = GBAddCustomer.Text + "Proveedores"
                _Is_Supplier = True
        End Select
    End Sub

#Region "Fill cb"

    Public Function FillCBTipoCliente() As Boolean
        Dim resp As Boolean = False
        Using objDatos As New Generic_SQLServer
            Try
                _DT_TipoCliente = objDatos.GetTipoCliente(Data_Id_Company)
                If _DT_TipoCliente.Rows.Count <> 0 Then
                    resp = True
                    cbTipoCliente.DataSource = _DT_TipoCliente
                    cbTipoCliente.DisplayMember = "DescriptionCustomer"
                    cbTipoCliente.ValueMember = "Id_TypeCustomer"
                    Dim con As Integer = 0
                    Dim pos As Integer = -1
                    For Each Data As DataRow In _DT_TipoCliente.Rows
                        If (Data("DescriptionCustomer").ToString.ToUpper.Contains("CONSUMIDOR FINAL")) Then
                            pos = con
                            Exit For
                        End If
                        con += 1
                    Next

                    cbTipoCliente.SelectedIndex = pos
                    Select Case _OpcionSeleccionada
                        Case Funcion.Actualizar
                            Try
                                cbTipoCliente.SelectedValue = Id_TypeCustomer_FK
                            Catch ex As ArgumentException
                                Using objLog As New ProcessGeneral
                                    objLog.AlmacenarLog(5, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                                End Using
                            Catch ex As Exception
                                Using objLog As New ProcessGeneral
                                    objLog.AlmacenarLog(5, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                                End Using
                            End Try
                    End Select
                End If
            Catch ex As ArgumentException
                Using objLog As New ProcessGeneral
                    objLog.AlmacenarLog(5, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                End Using
            Catch ex As Exception
                Using objLog As New ProcessGeneral
                    objLog.AlmacenarLog(5, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                End Using
            End Try
            Return resp
        End Using
    End Function

    Private Sub FillCBMunicipality()
        Using objDatos As New Generic_SQLServer
            Try
                _DT_Municipality = objDatos.GetMunicipality(Data_Id_Company)
                If _DT_Municipality.Rows.Count <> 0 Then
                    cbMinicipality.DataSource = _DT_Municipality
                    cbMinicipality.DisplayMember = "Name_Municipality"
                    cbMinicipality.ValueMember = "Id_Minicipality"
                    cbMinicipality.SelectedIndex = -1
                    Select Case _OpcionSeleccionada
                        Case Funcion.Actualizar
                            Try
                                cbMinicipality.SelectedValue = Id_Minicipality_FK
                            Catch ex As ArgumentException
                                Using objLog As New ProcessGeneral
                                    objLog.AlmacenarLog(5, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                                End Using
                            Catch ex As Exception
                                Using objLog As New ProcessGeneral
                                    objLog.AlmacenarLog(5, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                                End Using
                            End Try
                    End Select
                End If
            Catch ex As ArgumentException
                Using objLog As New ProcessGeneral
                    objLog.AlmacenarLog(5, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                End Using
            Catch ex As Exception
                Using objLog As New ProcessGeneral
                    objLog.AlmacenarLog(5, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                End Using
            End Try
        End Using
    End Sub

    Private Sub FillCBCompanyCategory()
        Using objDatos As New Generic_SQLServer
            Try
                _DT_CompanyCategory = objDatos.GetCompanyCategory(Data_Id_Company)
                Dim pos As Integer = -1
                If _DT_CompanyCategory.Rows.Count <> 0 Then
					cbCompanyCategory.DataSource = _DT_CompanyCategory
					cbCompanyCategory.DisplayMember = "Description_CompanyCategory"
                    cbCompanyCategory.ValueMember = "ID_CompanyCategory"
                    Dim con As Integer = 0

                    For Each Data As DataRow In _DT_CompanyCategory.Rows
                        If (Data("Description_CompanyCategory").ToString.ToUpper.Contains("COMERCIALES")) Then
                            pos = con
                            Exit For
                        End If
                        con += 1
                    Next
                    cbCompanyCategory.SelectedIndex = pos
                    Select Case _OpcionSeleccionada
						Case Funcion.Actualizar
                            Try
                                If CheckLegalEntity.Checked = True Then
                                    cbCompanyCategory.SelectedValue = Id_CompanyCategory_Fk
                                Else
                                    cbCompanyCategory.Enabled = False
                                End If
                            Catch ex As ArgumentException
                                Using objLog As New ProcessGeneral
                                    objLog.AlmacenarLog(5, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                                End Using
                            Catch ex As Exception
                                Using objLog As New ProcessGeneral
									objLog.AlmacenarLog(5, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
								End Using
							End Try
					End Select
				End If
                Try
                    If (pos <= 0) Then
                        cbCompanyCategory.SelectedValue = Id_CompanyCategory_Fk
                    End If

                Catch ex As Exception

                End Try
			Catch ex As ArgumentException
                Using objLog As New ProcessGeneral
                    objLog.AlmacenarLog(5, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                End Using
            Catch ex As Exception
                Using objLog As New ProcessGeneral
                    objLog.AlmacenarLog(5, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                End Using
            End Try
        End Using
    End Sub

    Private Sub FillCBContactEmployee()
        Using objDatos As New Generic_SQLServer
            Try
                _DT_ContactEmployee = objDatos.GetContactEmploye(Data_Id_Company)
                If _DT_ContactEmployee.Rows.Count <> 0 Then
                    cbContactEmploye.DataSource = _DT_ContactEmployee
                    cbContactEmploye.DisplayMember = "Contact"
                    cbContactEmploye.ValueMember = "Id_employee"
                    cbContactEmploye.SelectedIndex = -1
                    Select Case _OpcionSeleccionada
                        Case Funcion.Actualizar
                            Try
                                cbContactEmploye.SelectedValue = Id_EmployeelContact_FK
                            Catch ex As ArgumentException
                                Using objLog As New ProcessGeneral
                                    objLog.AlmacenarLog(5, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                                End Using
                            Catch ex As Exception
                                Using objLog As New ProcessGeneral
                                    objLog.AlmacenarLog(5, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                                End Using
                            End Try
                    End Select
                End If
            Catch ex As ArgumentException
                Using objLog As New ProcessGeneral
                    objLog.AlmacenarLog(5, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                End Using
            Catch ex As Exception
                Using objLog As New ProcessGeneral
                    objLog.AlmacenarLog(5, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                End Using
            End Try
        End Using
    End Sub

#End Region

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        Dim resultado As String = Nothing
		If CheckLegalEntity.Checked Then
			islegalty = True
		End If


		Using ObjValidacion As New Validaciones
            'If txtFirstName.Text.Trim = "" Then
            '    MessageBox.Show("Por favor introduzca un nombre", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
            '    txtFirstName.Select()
            '    Exit Sub
            'End If
            'If txtLastName.Text.Trim = "" Then
            '	MessageBox.Show("Por favor introduzca un apellido", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
            '	txtLastName.Select()
            '	Exit Sub
            'End If
            '         If txtAddress.Text.Trim = "" And islegalty Then
            '	MessageBox.Show("Por favor introduzca la dirección", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
            '	txtAddress.Select()
            '	Exit Sub
            'End If
            'If txtTelephoneContact.Text.Trim = "" And islegalty Then
            '	MessageBox.Show("Por favor introduzca el teléfono", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
            '	txtTelephoneContact.Select()
            '	Exit Sub
            'End If
            'If Not ObjValidacion.ValidatePhone(txtTelephoneContact.Text.Trim) Then
            '	MessageBox.Show("Por favor introduzca un teléfono válido (2345-6789)", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
            '	txtTelephoneContact.Select()
            '	Exit Sub
            'End If
            'If txtEmailContact.Text.Trim = "" And islegalty Then
            '	MessageBox.Show("Por favor introduzca el Email", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
            '	txtEmailContact.Select()
            '	Exit Sub
            'End If
            'If Not ObjValidacion.ValidateEmail(txtEmailContact.Text.Trim) Then
            '	MessageBox.Show("Por favor introduzca un email válido (ejemplo@ejemplo.com)", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
            '	txtEmailContact.Select()
            '	Exit Sub
            'End If
            'If txtDUI.Text.Trim = "" Then
            '	MessageBox.Show("Por favor introduzca el DUI", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
            '	txtDUI.Select()
            '	Exit Sub
            'End If
            'If Not ObjValidacion.ValidateDUI(txtDUI.Text.Trim) And islegalty Then
            '	MessageBox.Show("Por favor introduzca un número de DUI válido (12345678-0)", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
            '	txtDUI.Select()
            '	Exit Sub
            'End If
            'If txtRegistrationNumber.Text.Trim = "" And islegalty Then
            '    MessageBox.Show("Por favor introduzca el número de registro fiscal", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
            '    txtRegistrationNumber.Select()
            '    Exit Sub
            'End If
            If txtNIT.Text.Trim = "" Then
                MessageBox.Show("Por favor introduzca el número de NIT", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
                txtNIT.Select()
                Exit Sub
            End If
            If txtNIT.Text.Trim = "" And islegalty Then
				MessageBox.Show("Por favor introduzca el número de NIT", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
				txtNIT.Select()
				Exit Sub
			End If
			If Not ObjValidacion.ValidateNIT(txtNIT.Text.Trim) Then
				MessageBox.Show("Por favor introduzca un número de NIT válido (123-456789-123-1)", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
				txtNIT.Select()
				Exit Sub
			End If
			If cbTipoCliente.SelectedIndex = -1 Then
                MessageBox.Show("Por favor seleccione un Tipo de Proveedor", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Exit Sub
			End If
            If cbMinicipality.SelectedIndex = -1 Then
                MessageBox.Show("Por favor seleccione una Municipalidad", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Exit Sub
            End If
            'If cbContactEmploye.SelectedIndex = -1 Then
            '    MessageBox.Show("Por favor seleccione un empleado de contacto", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
            '    Exit Sub
            'End If

            If CheckLegalEntity.Checked = True Then
				txtNameCompany.ReadOnly = False
				txtComercialNameCompany.ReadOnly = False
				txtNameCompany.Select()
				If Is_LegalEntity = True And txtNameCompany.Text = "" Then
					MessageBox.Show("Por favor introduzca el nombre de la empresa", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
					Exit Sub
				End If
                '''If Is_LegalEntity = True And txtComercialNameCompany.Text = "" Then
                '''	MessageBox.Show("Por favor introduzca el nombre comercial de la empresa", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
                '''	Exit Sub
                '''End If
                If cbCompanyCategory.SelectedIndex = -1 Then
					MessageBox.Show("Por favor seleccione un giro de empresa", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
					Exit Sub
				End If
			End If
		End Using


		IsBigContributter = chkBigContributer.Checked
        Id_TypeCustomer_FK = cbTipoCliente.SelectedValue
        Id_Minicipality_FK = cbMinicipality.SelectedValue
        Id_EmployeelContact_FK = -1
        Id_CompanyCategory_Fk = cbCompanyCategory.SelectedValue
        Is_Exempt = checkExentoIVA.Checked
        Is_LegalEntity = CheckLegalEntity.Checked
        Business_Name = txtNameCompany.Text.Trim
        Commercial_Name = txtComercialNameCompany.Text.Trim
        First_Name = txtFirstName.Text.Trim
        Last_Name = txtLastName.Text.Trim
        Address = txtAddress.Text.Trim
        OfficePhone = txtTelephoneContact.Text.Trim
        Email_Contact = txtEmailContact.Text.Trim
        Identity_DocumentNumber = txtDUI.Text.Trim
        Tax_Registration_Number = txtRegistrationNumber.Text.Trim
        Tax_Identification_Number = txtNIT.Text.Trim
        Select Case _OpcionSeleccionada
            Case Funcion.Actualizar
                Using objDatos As New Generic_SQLServer
                    resultado = objDatos.SetClienteCuentasPorCobrar(Id_Customer, Data_Id_Company, Id_TypeCustomer_FK, Id_Minicipality_FK, Id_EmployeelContact_FK, Id_CompanyCategory_Fk, Is_Exempt,
                                                                    Is_LegalEntity, Business_Name, Commercial_Name, First_Name, Last_Name, Address, OfficePhone,
                                                                    Email_Contact, Identity_DocumentNumber, Tax_Registration_Number, Tax_Identification_Number,
                                                                    IsBigContributter, txt_Turning_Company.Text, CK_Proveedor.Checked,
                                                                    CK_DepemdeSIC.Checked, txtIDSIC.Text, txtObservaciones.Text)
                    If resultado = 1 Then
                        MessageBox.Show("El registro se actualizó correctamente.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                        DialogResult = DialogResult.OK
                        Close()
                    ElseIf resultado = 2 Then
                        MessageBox.Show("Ya existe un registro con el DUI, NIT o número de registro que desea agregar, por favor verifique.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                End Using
            Case Funcion.Agregar
                Using objDatos As New Generic_SQLServer
                    resultado = objDatos.InsertClienteCuentasPorCobrar(Data_Id_Company, Id_TypeCustomer_FK, Id_Minicipality_FK, Id_EmployeelContact_FK, Id_CompanyCategory_Fk, Is_Exempt, Is_LegalEntity,
                                                                       Business_Name, Commercial_Name, First_Name, Last_Name, Address, OfficePhone, Email_Contact, Identity_DocumentNumber, Tax_Registration_Number,
                                                                       Tax_Identification_Number, CK_Proveedor.Checked, IsBigContributter, txt_Turning_Company.Text,
                                                                       CK_DepemdeSIC.Checked, txtIDSIC.Text, txtObservaciones.Text)
                    If Not resultado = "err" Then

                        MessageBox.Show("El registro se agregó correctamente.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Id_Customer = resultado

                    Else
                        MessageBox.Show("Ya existe un registro con el DUI, NIT o número de registro que desea agregar, por favor verifique.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                End Using
        End Select
        DialogResult = DialogResult.OK
        Close()
    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub




    Private Sub CheckLegalEntity_CheckedChanged(sender As Object, e As EventArgs) Handles CheckLegalEntity.CheckedChanged
        If CheckLegalEntity.Checked = True Then
            txtNameCompany.ReadOnly = False
            txtComercialNameCompany.ReadOnly = False
            cbCompanyCategory.Enabled = True
            txtNameCompany.Select()
            _Is_LegalEntity = True
        Else
            txtNameCompany.Text = ""
            txtComercialNameCompany.Text = ""
            txtFirstName.Select()
            _Is_LegalEntity = False
        End If
        If CheckLegalEntity.Checked = False Then
            txtNameCompany.ReadOnly = True
            txtComercialNameCompany.ReadOnly = True
            cbCompanyCategory.SelectedIndex = -1
            cbCompanyCategory.Enabled = False
            txtNameCompany.Text = ""
            txtComercialNameCompany.Text = ""
            txtFirstName.Select()
        End If
    End Sub

    Private Sub txtNameCompany_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNameCompany.KeyPress
        'Using ObjValidacionx As New Validaciones
        '    e.Handled = ObjValidacionx.JustLetters(sender, e)
        'End Using
    End Sub

    Private Sub txtComercialNameCompany_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtComercialNameCompany.KeyPress
        'Using ObjValidacion As New Validaciones
        '    e.Handled = ObjValidacion.JustLetters(sender, e)
        'End Using
    End Sub

    Private Sub txtFirstName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFirstName.KeyPress
        Using ObjValidacion As New Validaciones
            e.Handled = ObjValidacion.JustLetters(sender, e)
        End Using
    End Sub

    Private Sub txtLastName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLastName.KeyPress
        Using ObjValidacion As New Validaciones
            e.Handled = ObjValidacion.JustLetters(sender, e)
        End Using

    End Sub

    Private Sub txtRegistrationNumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRegistrationNumber.KeyPress
        Using ObjValidacion As New Validaciones
			e.Handled = ObjValidacion.JustNumbersAndGuion(sender, e)
		End Using

    End Sub

    Private Sub txtTelephoneContact_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTelephoneContact.KeyPress
        Using objValidacion As New Validaciones
            e.Handled = objValidacion.JustNumbers(sender, e)
        End Using
        If Not e.KeyChar = "." Then
            If Not e.KeyChar = Convert.ToChar(8) Then
                If (txtTelephoneContact.Text.Trim.Length = 4) Then
                    txtTelephoneContact.Text &= "-"
                    txtTelephoneContact.Select(5, 0)
                End If
            End If
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtDUI_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDUI.KeyPress
        Using objValidacion As New Validaciones
            e.Handled = objValidacion.JustNumbers(sender, e)
        End Using

        If Not e.KeyChar = Convert.ToChar(8) Then
            If Not e.KeyChar = "." Then
                If (txtDUI.Text.Trim.Length = 8) Then
                    txtDUI.Text &= "-"
                    txtDUI.Select(9, 0)
                End If
            Else
                e.Handled = True
            End If

        End If
    End Sub

	Private Sub txtNIT_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNIT.KeyPress
        Using objValidacion As New Validaciones
            e.Handled = objValidacion.JustNumbers(sender, e)
        End Using
        If Not e.KeyChar = "." Then
            If Not e.KeyChar = Convert.ToChar(8) Then
                If (txtNIT.Text.Trim.Length = 4) Then
                    txtNIT.Text &= "-"
                    txtNIT.Select(5, 0)
                ElseIf (txtNIT.Text.Trim.Length = 11) Then
                    txtNIT.Text &= "-"
                    txtNIT.Select(12, 0)
                ElseIf (txtNIT.Text.Trim.Length = 15) Then
                    txtNIT.Text &= "-"
                    txtNIT.Select(16, 0)
                End If
            End If
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub GBAddCustomer_Enter(sender As Object, e As EventArgs) Handles GBAddCustomer.Enter

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

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
#End Region
End Class