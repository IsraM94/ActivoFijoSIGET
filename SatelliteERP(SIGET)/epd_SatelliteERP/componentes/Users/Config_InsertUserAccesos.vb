Public Class Config_InsertUserAccesos

#Region "Properties"
    Private objsql As New Generic_SQLServer
    Private _Inactivas As Boolean = False
    Private _Activas As Boolean = False
    Private _Atrasadas As Boolean = False
    Private _DT_CreditLine As DataTable = Nothing
    Private _DT_TypeCreditLine As DataTable = Nothing
    Property _isInsert As Boolean = True
    Property _username As String = ""
    Property _id_username As Long
    Property _Rol As String
    Property _Empleado As String

    Property Resp As String = ""

    Enum funcion
        Actualizar
        Agregar
    End Enum
    Property OpcionSeleccionada As funcion
#End Region

    Private Sub Config_InsertUserAccesos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Using objSqlHumanResources As New HumanResources_SQLServer
                Dim _dtContactEmploye As DataTable = objSqlHumanResources.GetEmploye(Data_Id_Company)
                CB_ContactEmploye.DataSource = _dtContactEmploye
                CB_ContactEmploye.DisplayMember = "Contact"
                CB_ContactEmploye.ValueMember = "Id_employee"
                CB_ContactEmploye.SelectedIndex = -1
            End Using
        Catch ex As Exception

        End Try


        Try
            Using objSqlHumanResources As New Generic_SQLServer
                Dim _dtContactEmploye As DataTable = objSqlHumanResources.GetAccessRole()
                cb_RolAsignado.DataSource = _dtContactEmploye
                cb_RolAsignado.DisplayMember = "name_role"
                cb_RolAsignado.ValueMember = "id_role"
                cb_RolAsignado.SelectedIndex = -1
            End Using
        Catch ex As Exception

        End Try

        txt_ConfigAccess_BuscarUsuario.Focus()
        txt_ConfigAccess_BuscarUsuario.Text = _username
        If Not _isInsert Then
            txt_ConfigAccess_BuscarUsuario.Enabled = False
            CB_ContactEmploye.Enabled = False
        End If

        Try
            CB_ContactEmploye.SelectedValue = _Empleado
        Catch ex As Exception

        End Try
        Try
            cb_RolAsignado.SelectedValue = _Rol
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmdGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        If txt_ConfigAccess_BuscarUsuario.Text = "" Or txt_ConfigAccess_BuscarUsuario.Text = " " Then
            MessageBox.Show("No puede dejar campos en blanco.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_ConfigAccess_BuscarUsuario.Focus()
            Exit Sub
        End If



        If cb_RolAsignado.SelectedIndex = -1 And cb_RolAsignado.SelectedText = "" Then
            MessageBox.Show("Seleccione un rol para el Usuario", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)

            cb_RolAsignado.Focus()
            Exit Sub
        End If


        If _isInsert Then
            If txtPassword.Text = "" Or txtPassword.Text = " " Then
                MessageBox.Show("No puede dejar campos en blanco.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtPassword.Focus()
                Exit Sub
            End If

            If txtConfirmar.Text = "" Or txtConfirmar.Text = " " Then
                MessageBox.Show("No puede dejar campos en blanco.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtConfirmar.Focus()
                Exit Sub
            End If
        End If


        If (txtPassword.Text.ToString.ToUpper <> txtConfirmar.Text.ToString.ToUpper) Then
            MessageBox.Show("El password ingresado no es igual, favor verificar.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtConfirmar.Focus()
            Exit Sub
        End If




        If CB_ContactEmploye.SelectedIndex = -1 And CB_ContactEmploye.Text = "" Then
            MessageBox.Show("Selecciona un empleado", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)

            CB_ContactEmploye.Focus()
            Exit Sub
        End If


        Dim dt As String = ""

        If _isInsert Then
            dt = objsql.ERP_Config_InsertAccessUserName(txt_ConfigAccess_BuscarUsuario.Text, txtPassword.Text.ToString, cb_RolAsignado.SelectedValue, CB_ContactEmploye.SelectedValue)
        Else
            dt = objsql.ERP_Config_UpdateAccessUserName(_id_username, txt_ConfigAccess_BuscarUsuario.Text, txtPassword.Text.ToString, cb_RolAsignado.SelectedValue, CB_ContactEmploye.SelectedValue)
        End If

        If dt = "Error" Then
            Resp = "Error"
        ElseIf dt = "existe" Then
            Resp = "Existe"
        Else
            Resp = "OK"
        End If
        Me.Close()
    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        Resp = "Cancel"
        Me.Close()
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

    Private Sub GroupDatosUsuario_Enter(sender As Object, e As EventArgs) Handles GroupDatosUsuario.Enter

    End Sub
#End Region
End Class