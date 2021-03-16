Imports System.IO
Imports System.Xml

Public Class LoginForm

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.
    Private objSql As New Generic_SQLServer
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        If UsernameTextBox.Text.Length = 0 Then
            MessageBox.Show("El usuario no puede ser vacio", "SatellitePOS", MessageBoxButtons.OK, MessageBoxIcon.Error)
            UsernameTextBox.Focus()
            Exit Sub
        End If
        If PasswordTextBox.Text.Length = 0 Then
            MessageBox.Show("El password no puede ser vacio", "SatellitePOS", MessageBoxButtons.OK, MessageBoxIcon.Error)
            PasswordTextBox.Focus()
            Exit Sub
        End If
        _Password = PasswordTextBox.Text
        _User = UsernameTextBox.Text
        Try
            SQLConfiguration.GenerarConnectionString(_User, _Password)

            If (SQLConfiguration.probarConectividad) Then
                _UserSQL = UsernameTextBox.Text.Trim
                ' Permissions.RefrescarPermisos()
                Dim resp As DataSet = objSql.ERP_PROC_login(_User)
                If (resp.Tables.Count > 0) Then
                    If (resp.Tables(0).Rows.Count > 0) Then
                        'MessageBox.Show("Login exitoso", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                        _Id_EmployeeGlobal = resp.Tables(0).Rows(0).Item("Id_employee").ToString
                        _Id_DepartmentGlobal = resp.Tables(0).Rows(0).Item("id_Department_FK").ToString
                        _NombreDepartamento = resp.Tables(0).Rows(0).Item("Name_Deparmnet").ToString
                        _DepartamentoHijo = resp.Tables(0).Rows(0).Item("Hijo").ToString
                        _CompanyLogo = llenarFLW()


                        Me.DialogResult = DialogResult.OK

                        Close()
                    Else
                        MessageBox.Show("Debe asignar el usuario, a un Empleado.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)

                        Me.DialogResult = DialogResult.Cancel

                    End If
                Else
                    MessageBox.Show("Login fallo", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Me.DialogResult = DialogResult.Cancel
                    Me.Close()

                End If

            End If
        Catch ex As Exception

            Try
                Using objLog As New ProcessGeneral
                    objLog.AlmacenarLog(1, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                End Using
            Catch ex2 As Exception

            End Try
            MessageBox.Show("Ocurrio un error mientras se procesaba la información. Favor validar los registros del sistema", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SQLConfiguration.EpdConnectionString = Nothing
        ''Permissions.LimpiarPermisos()
        Try
            Dim keyValue As Object
            keyValue = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\Software\WinPOSLocal", "user", "")
            'lblSecurity.Text = Security.Value
        Catch ex As Exception
        End Try
    End Sub

    Private Sub lblSecurity_Click(sender As Object, e As EventArgs)
        'Using objObtenerLicencia As New GenAccessFile
        '    If objObtenerLicencia.CreateFileXML() = "OK" Then
        '        MessageBox.Show("La licencia se enviara en un tiempo no mayor a un día.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    End If
        'End Using
    End Sub


    Public Function Bytes2Image(ByVal bytes() As Byte) As Image
        If bytes Is Nothing Then Return Nothing
        '
        Dim ms As New MemoryStream(bytes)
        Dim bm As Bitmap = Nothing
        Try
            bm = New Bitmap(ms)
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine(ex.Message)
        End Try
        Return bm
    End Function

    Function llenarFLW() As String

        Using obj As New Generic_SQLServer

            For Each row As DataRow In obj.ERP_FixedAssets_MasterimageCompany().Rows

                Dim val As Byte() = (row("Image"))
                'pbImage.Image = Bytes2Image(val)

                Dim mpnl As New Panel
                mpnl.Width = 150
                mpnl.Height = 190

                Dim mPic As New PictureBox
                mPic.Image = Bytes2Image(val)
                mPic.Name = (row("ID_MasterImage"))
                mPic.Width = 150
                mPic.Height = 150


                Dim Carpeta As String = My.Computer.FileSystem.CurrentDirectory
                Dim Imagen As Image = mPic.Image

                Imagen.Save(Carpeta & "\CompanyLogo.jpeg", Imaging.ImageFormat.Jpeg)

                _CompanyLogo = Carpeta & "\CompanyLogo.jpeg"
            Next
            Return _CompanyLogo
        End Using
    End Function

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
