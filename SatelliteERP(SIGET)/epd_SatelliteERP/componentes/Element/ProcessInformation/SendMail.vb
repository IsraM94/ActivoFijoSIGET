Imports System.Data
Imports System.Data.SqlClient
Imports System.Net.Mail
Public Class SendEmail : Implements IDisposable
    Private ConnStr As String = ""
    Property Server As String
    Property BaseDeDatos As String
    Private Function GenerarConnectionString() As String
        Dim cnn As String = ""
        Try
            cnn = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Epdsoft\SatelliteERP", "ConnectionStringsSendMail", "Error")
        Catch ex As Exception

        End Try

        Return cnn
    End Function
    Public Function SendEmail(ByVal SendTo As String, ByVal Subject As String, ByVal Body As String, ByVal Id_Solicitud As Long) As Boolean
        Dim resp As Boolean = False
        ConnStr = GenerarConnectionString()

        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("SP_ERP_SENDMAIL", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@CadenaMail", SqlDbType.VarChar).Value = SendTo
                cmd.Parameters.Add("@Asunto", SqlDbType.VarChar).Value = Subject
                cmd.Parameters.Add("@Cuerpo", SqlDbType.VarChar).Value = Body
                Dim process As New ProcessGeneral
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return 1
                        Catch ex As Exception
                            Process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return 3
                        End Try
                    End Using
                End Using
            End Using
        End Using
        Return resp
    End Function

#Region "IDisposable Support"
    Private disposedValue As Boolean ' To detect redundant calls

    ' IDisposable
    Protected Overridable Sub Dispose(disposing As Boolean)
        If Not disposedValue Then
            If disposing Then
                ' TODO: dispose managed state (managed objects).
            End If

            ' TODO: free unmanaged resources (unmanaged objects) and override Finalize() below.
            ' TODO: set large fields to null.
        End If
        disposedValue = True
    End Sub

    ' TODO: override Finalize() only if Dispose(disposing As Boolean) above has code to free unmanaged resources.
    'Protected Overrides Sub Finalize()
    '    ' Do not change this code.  Put cleanup code in Dispose(disposing As Boolean) above.
    '    Dispose(False)
    '    MyBase.Finalize()
    'End Sub

    ' This code added by Visual Basic to correctly implement the disposable pattern.
    Public Sub Dispose() Implements IDisposable.Dispose
        ' Do not change this code.  Put cleanup code in Dispose(disposing As Boolean) above.
        Dispose(True)
        ' TODO: uncomment the following line if Finalize() is overridden above.
        GC.SuppressFinalize(Me)
    End Sub
#End Region

End Class
