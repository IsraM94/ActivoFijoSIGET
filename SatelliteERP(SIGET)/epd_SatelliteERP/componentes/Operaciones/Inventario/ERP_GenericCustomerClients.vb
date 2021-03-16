Public Class ERP_GenericCustomerClients

    Private _Id_TipoCliente As Long = 0
    Private _Id_Categoria As Long = 0
    Private _Id_Rubro As Long = 0
    Private _DT_Clientes As New DataTable
    Private _TypeCustomer As Long = 0

    Enum OpcionSeleccionada
        Clientes = 1
        Proveedores = 2
    End Enum

#Region "Properties"
    Private _TipoConsulta As OpcionSeleccionada
    Public Property TipoConsulta() As OpcionSeleccionada
        Get
            Return _TipoConsulta
        End Get
        Set(ByVal value As OpcionSeleccionada)
            _TipoConsulta = value
        End Set
    End Property

#End Region


#Region "Fill CB and DGV"

    Private Sub FillTipoCliente()
        Dim DT_Cliente As New DataTable
        DT_Cliente.Columns.Add("Id")
        DT_Cliente.Columns.Add("Tipo")
        DT_Cliente.Rows.Add(1, "Empresa")
        DT_Cliente.Rows.Add(2, "Persona Natural")
        Try
            If DT_Cliente IsNot Nothing Then
                If DT_Cliente.Rows.Count <> 0 Then
                    RemoveHandler cbTipoCliente.SelectedIndexChanged, AddressOf cbTipoCliente_SelectedIndexChanged
                    cbTipoCliente.DataSource = DT_Cliente
                    cbTipoCliente.DisplayMember = "Tipo"
                    cbTipoCliente.ValueMember = "Id"
                    cbTipoCliente.SelectedIndex = -1
                    AddHandler cbTipoCliente.SelectedIndexChanged, AddressOf cbTipoCliente_SelectedIndexChanged
                End If
            End If
        Catch ex As ArgumentException
            Using objLog As New Generic_SQLServer
                objLog.SaveLogException(System.Reflection.MethodBase.GetCurrentMethod.Name, ex.ToString)
            End Using
        Catch ex As Exception
            Using objLog As New Generic_SQLServer
                objLog.SaveLogException(System.Reflection.MethodBase.GetCurrentMethod.Name, ex.ToString)
            End Using
        End Try
    End Sub


    Private Sub FillCategoria()
        Dim DT_Categoria As New DataTable
        Try
            Using objSql As New Generic_SQLServer
                REM Se utilizo Funcion Existente
                DT_Categoria = objSql.GetTipoCliente(Data_Id_Company)
            End Using
            If DT_Categoria.Rows.Count <> 0 Then
                cbCategoria.DataSource = DT_Categoria
                cbCategoria.DisplayMember = "DescriptionCustomer"
                cbCategoria.ValueMember = "Id_TypeCustomer"
                cbCategoria.SelectedIndex = -1
            End If
        Catch ex As ArgumentException
            Using objLog As New Generic_SQLServer
                objLog.SaveLogException(System.Reflection.MethodBase.GetCurrentMethod.Name, ex.ToString)
            End Using
        Catch ex As Exception
            Using objLog As New Generic_SQLServer
                objLog.SaveLogException(System.Reflection.MethodBase.GetCurrentMethod.Name, ex.ToString)
            End Using
        End Try
    End Sub

    Private Sub FillRubro()
        Dim DT_Rubro As New DataTable
        Try
            Using objSql As New Generic_SQLServer
                REM Se utilizo function existente
                DT_Rubro = objSql.GetCompanyCategory(Data_Id_Company)
            End Using
            If DT_Rubro IsNot Nothing Then
                If DT_Rubro.Rows.Count <> 0 Then
                    cbRubro.DataSource = DT_Rubro
                    cbRubro.DisplayMember = "Description_CompanyCategory"
                    cbRubro.ValueMember = "ID_CompanyCategory"
                    cbRubro.SelectedIndex = -1
                End If
            End If
        Catch ex As ArgumentException
            Using objLog As New Generic_SQLServer
                objLog.SaveLogException(System.Reflection.MethodBase.GetCurrentMethod.Name, ex.ToString)
            End Using
        Catch ex As Exception
            Using objLog As New Generic_SQLServer
                objLog.SaveLogException(System.Reflection.MethodBase.GetCurrentMethod.Name, ex.ToString)
            End Using
        End Try
    End Sub

    Private Sub fillDGV(ByVal TipoConsulta As Long)
        If cbTipoCliente.SelectedIndex = -1 Then
            _Id_TipoCliente = -1
        Else
            _Id_TipoCliente = cbTipoCliente.SelectedValue
        End If
        If cbCategoria.SelectedIndex = -1 Then
            _Id_Categoria = -1
        Else
            _Id_Categoria = cbCategoria.SelectedValue
        End If
        If cbRubro.SelectedIndex = -1 Then
            _Id_Rubro = -1
        Else
            _Id_Rubro = cbRubro.SelectedValue
        End If
        Try
            Using objSql As New Generic_SQLServer
                _DT_Clientes = objSql.GetCustomerClientList(Data_Id_Company, _Id_TipoCliente, _Id_Categoria, _Id_Rubro, tipoconsulta)
            End Using
            If _DT_Clientes IsNot Nothing Then
                dgvClientes.DataSource = _DT_Clientes
                dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            End If
        Catch ex As Exception
            MessageBox.Show("Ocurrio un problema mientras se procesaba la información", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

#End Region


    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub

    Private Sub ERP_GenericCustomerClients_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillTipoCliente()
        FillCategoria()
        FillRubro()
        If _TipoConsulta = OpcionSeleccionada.Clientes Then
            _TypeCustomer = 1
        ElseIf _TipoConsulta = OpcionSeleccionada.Proveedores Then
            GbClientes.Text = "Configuración Proveedores"
            lblTipoCliente.Text = "Proveedor"
            cbTipoCliente.Enabled = False
            cmdSearch.Text = "Buscar Proveedor"
            _TypeCustomer = 2
        End If
        fillDGV(_TypeCustomer)
    End Sub

    Private Sub cmdClean_Click(sender As Object, e As EventArgs) Handles cmdClean.Click
        cbTipoCliente.SelectedValue = -1
        cbCategoria.SelectedValue = -1
        cbRubro.SelectedValue = -1
        cbRubro.Enabled = True
    End Sub

    Private Sub cmdAplicar_Click(sender As Object, e As EventArgs) Handles cmdAplicar.Click
        fillDGV(_TypeCustomer)
    End Sub

    Private Sub cbTipoCliente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbTipoCliente.SelectedIndexChanged
        If cbTipoCliente.SelectedValue = 2 Then
            cbRubro.Enabled = False
        End If
    End Sub

    Private Sub cmdSearch_Click(sender As Object, e As EventArgs) Handles cmdSearch.Click
        Using objSearch As New ERP_Mantenimiento_DialogSearch
            If _TypeCustomer = 1 Then
                objSearch.Search = ERP_Mantenimiento_DialogSearch.Process.Clientes
            ElseIf _TypeCustomer = 2 Then
                objSearch.Search = ERP_Mantenimiento_DialogSearch.Process.Proveedores
            End If
            objSearch.DGVContainer = dgvClientes
            objSearch.DT_Products = _DT_Clientes
            objSearch.ShowDialog()
        End Using
    End Sub

    Private Sub Nuevo_Click(sender As Object, e As EventArgs) Handles Nuevo.Click
        Using Objcreate As New ERP_ClientesCuentasPorCobrar
            If _TypeCustomer = 1 Then
                Objcreate.TipoConsulta = ERP_ClientesCuentasPorCobrar.Proceso.Clientes
                Objcreate.OpcionSeleccionada = ERP_ClientesCuentasPorCobrar.Funcion.Actualizar
            ElseIf _TypeCustomer = 2 Then
                Objcreate.TipoConsulta = ERP_ClientesCuentasPorCobrar.Proceso.Proveedores
                Objcreate.OpcionSeleccionada = ERP_ClientesCuentasPorCobrar.Funcion.Agregar
            End If
            If Objcreate.ShowDialog() = DialogResult.OK Then
                fillDGV(_TypeCustomer)
            End If
        End Using
    End Sub

    Private Sub Actualizar_Click(sender As Object, e As EventArgs) Handles Actualizar.Click
        Dim resul As DialogResult = Nothing
        If dgvClientes.CurrentRow IsNot Nothing Then
            Using ObjUpdate As New ERP_ClientesCuentasPorCobrar
                If _TypeCustomer = 1 Then
                    ObjUpdate.TipoConsulta = ERP_ClientesCuentasPorCobrar.Proceso.Clientes
                ElseIf _TypeCustomer = 2 Then
                    ObjUpdate.TipoConsulta = ERP_ClientesCuentasPorCobrar.Proceso.Proveedores
                End If
                ObjUpdate.OpcionSeleccionada = ERP_ClientesCuentasPorCobrar.Funcion.Actualizar
                Try
                    ObjUpdate.IsBigContributter = dgvClientes.CurrentRow.Cells("Is_BigContributor").Value
                    ObjUpdate.Id_Customer = dgvClientes.CurrentRow.Cells("Id_Customer").Value
                    ObjUpdate.id_Company = dgvClientes.CurrentRow.Cells("id_Company_FK").Value
                    ObjUpdate.Id_TypeCustomer_FK = dgvClientes.CurrentRow.Cells("Id_TypeCustomer_FK").Value
                    ObjUpdate.Id_Minicipality_FK = dgvClientes.CurrentRow.Cells("Id_Minicipality_FK").Value
                    ObjUpdate.Id_EmployeelContact_FK = dgvClientes.CurrentRow.Cells("Id_EmployeelContact_FK").Value
                    ObjUpdate.Id_CompanyCategory_Fk = dgvClientes.CurrentRow.Cells("Id_CompanyCategory_Fk").Value
                    ObjUpdate.Is_Exempt = dgvClientes.CurrentRow.Cells("Is_Exempt").Value
                    ObjUpdate.Is_LegalEntity = dgvClientes.CurrentRow.Cells("Is_LegalEntity").Value
                    ObjUpdate.Business_Name = dgvClientes.CurrentRow.Cells("Business_Name").Value
                    ObjUpdate.Commercial_Name = dgvClientes.CurrentRow.Cells("Commercial_Name").Value
                    ObjUpdate.First_Name = dgvClientes.CurrentRow.Cells("First_Name").Value
                    ObjUpdate.Last_Name = dgvClientes.CurrentRow.Cells("Last_Name").Value
                    ObjUpdate.Address = dgvClientes.CurrentRow.Cells("Address").Value
                    ObjUpdate.OfficePhone = dgvClientes.CurrentRow.Cells("OfficePhone").Value
                    ObjUpdate.Email_Contact = dgvClientes.CurrentRow.Cells("Email_Contact").Value
                    ObjUpdate.Identity_DocumentNumber = dgvClientes.CurrentRow.Cells("Identity_DocumentNumber").Value
                    ObjUpdate.Tax_Registration_Number = dgvClientes.CurrentRow.Cells("Tax_Registration_Number").Value
                    ObjUpdate.Tax_Identification_Number = dgvClientes.CurrentRow.Cells("Tax_Identification_Number").Value
                    resul = ObjUpdate.ShowDialog()
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
            If resul = System.Windows.Forms.DialogResult.OK Then
                fillDGV(_TypeCustomer)
            End If
        End If
    End Sub

    Private Sub Eliminar_Click(sender As Object, e As EventArgs) Handles Eliminar.Click
        Dim consulta As String = Nothing
        If _TypeCustomer = 1 Then
            consulta = "cliente"
        ElseIf _TypeCustomer = 2 Then
            consulta = "proveedor"
        End If 
        If dgvClientes.CurrentRow IsNot Nothing Then
            Using objSql As New Generic_SQLServer
                Dim Id_Customer As Long = dgvClientes.CurrentRow.Cells("Id_Customer").Value
                Dim values As String = dgvClientes.CurrentRow.Cells("Identity_DocumentNumber").Value
                If MessageBox.Show("¿Desea eliminar el" & consulta & "con número de identificación: " & values & "?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    Dim resultado As String = objSql.DelClienteCuentasPorCobrar(Id_Customer, Data_Id_Company)
                    If resultado = "OK" Then
                        MessageBox.Show("El registro ha sido eliminado exitosamente", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                        fillDGV(_TypeCustomer)
                    End If
                End If
            End Using
        End If
    End Sub

    Private Sub cmdReporte_Click(sender As Object, e As EventArgs) Handles cmdReporte.Click
        'Using objReport As New PlantillaReporte("ERP_Generic_GetCustomerMasterFilterTableAdapter")
        '    objReport.Id_tipoClient = _Id_TipoCliente
        '    objReport.Id_CategoriaEmpresa = _Id_Categoria
        '    objReport.Id_RubroEmpresa = _Id_Rubro
        '    objReport.TipoCustomer = _TypeCustomer
        '    objReport.ShowDialog()
        'End Using
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
#End Region
End Class