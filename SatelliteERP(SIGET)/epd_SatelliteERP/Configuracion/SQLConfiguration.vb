Imports System.Data.SqlClient

Module SQLConfiguration


    Public EpdConnectionString As SqlConnectionStringBuilder = Nothing


    Public Sub GenerarConnectionString(usuario As String, password As String)
        Dim cnn As String = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Epdsoft\SatelliteERP", "ConnectionStrings", "Error")

        'cnn = _CadenaConexionLogin
        cnn = cnn.Replace("[user]", usuario)
        cnn = cnn.Replace("[password]", password)
        _CadenaConexion = cnn
        EpdConnectionString = New SqlConnectionStringBuilder(cnn)
    End Sub

    Public Function probarConectividad() As Boolean
        Try
            Using cn As New SqlConnection(EpdConnectionString.ConnectionString)
                cn.Open()
                cn.Close()
                Return True
            End Using
        Catch ex As SqlException
            Try
                Using obj As New Operaciones_SQLServer
                    obj.SaveLogException(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message.ToString)
                End Using
            Catch ex2 As Exception

            End Try

            MessageBox.Show("Error en inicio de Sesion, Verifique su Usuario y Contraseña", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False

        Catch ex As Exception
            Try
                Using obj As New Operaciones_SQLServer
                    obj.SaveLogException(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message.ToString)
                End Using
            Catch ex2 As Exception

            End Try
            MessageBox.Show("Error en inicio de Sesion, Verifique su Usuario y Contraseña", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False

        End Try

        Return False
    End Function



End Module
