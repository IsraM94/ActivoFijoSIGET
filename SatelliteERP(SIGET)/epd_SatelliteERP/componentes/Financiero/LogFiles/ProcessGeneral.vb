Imports System.Text
Imports System.Security.Cryptography

Friend Class ProcessGeneral : Implements IDisposable

    Private keyRegedit As String = "HKEY_LOCAL_MACHINE\SOFTWARE\Epdsoft\EPD_SatelliteERP"
    Public Function AlmacenarLog(ByVal TipoLog As Integer, ByVal ExError As String, ByVal Namefunction As String)
        Try
            Dim ruta As String = "C:\EPD_SatelliteERP\Log"
            Dim folderExists As Boolean
            folderExists = My.Computer.FileSystem.DirectoryExists(ruta)
            If Not (folderExists) Then
                My.Computer.FileSystem.CreateDirectory(ruta)
            End If
            Select Case TipoLog
                Case 1
                    My.Computer.FileSystem.WriteAllText(ruta & "\AlmacenaInformacion_" & Now.ToString("yyyyMMdd") & ".txt", " <-" & Date.Now & "-> " & ExError + vbCrLf, True)
                Case 2
                    My.Computer.FileSystem.WriteAllText(ruta & "\ExtraerInformacion_" & Now.ToString("yyyyMMdd") & ".txt", " <-" & Date.Now & "-> " & ExError + vbCrLf, True)
                Case 3
                    My.Computer.FileSystem.WriteAllText(ruta & "\UpdateInformacion_" & Now.ToString("yyyyMMdd") & ".txt", " <-" & Date.Now & "-> " & ExError + vbCrLf, True)
                Case 4
                    My.Computer.FileSystem.WriteAllText(ruta & "\ConexionBD_" & Now.ToString("yyyyMMdd") & ".txt", " <-" & Date.Now & "-> " & ExError + vbCrLf, True)
                Case 5
                    My.Computer.FileSystem.WriteAllText(ruta & "\Aplicacion_" & Now.ToString("yyyyMMdd") & ".txt", " <-" & Date.Now & "-> " & ExError + vbCrLf, True)
            End Select

            Using obj As New Operaciones_SQLServer
                obj.SaveLogException(System.Reflection.MethodBase.GetCurrentMethod().Name, ExError.ToString)
            End Using

        Catch ex As Exception

        End Try
        Return "OK"
    End Function

    Public Function RutaRegedit() As String
        Return keyRegedit
    End Function
    Friend Function Encriptar(ByVal cadena As String) As String
        Dim IV() As Byte = ASCIIEncoding.ASCII.GetBytes("EpdSoft0") 'La clave debe ser de 8 caracteres
        Dim EncryptionKey() As Byte = Convert.FromBase64String("EpdSPvIvSoftcmt2015/c43Gkgh7rL21") 'No se puede alterar la cantidad de caracteres pero si la clave

        Dim buffer() As Byte = Encoding.UTF8.GetBytes(cadena)
        Dim des As TripleDESCryptoServiceProvider = New TripleDESCryptoServiceProvider
        des.Key = EncryptionKey
        des.IV = IV
        Return Convert.ToBase64String(des.CreateEncryptor().TransformFinalBlock(buffer, 0, buffer.Length()))
    End Function

    Friend Function Desencriptar(ByVal Input As String) As String
        Dim IV() As Byte = ASCIIEncoding.ASCII.GetBytes("EpdSoft0") 'La clave debe ser de 8 caracteres
        Dim EncryptionKey() As Byte = Convert.FromBase64String("EpdSPvIvSoftcmt2015/c43Gkgh7rL21") 'No se puede alterar la cantidad de caracteres pero si la clave
        Dim buffer() As Byte = Convert.FromBase64String(Input)
        Dim des As TripleDESCryptoServiceProvider = New TripleDESCryptoServiceProvider
        des.Key = EncryptionKey
        des.IV = IV
        Return Encoding.UTF8.GetString(des.CreateDecryptor().TransformFinalBlock(buffer, 0, buffer.Length()))

    End Function
    Friend Function GernerarID() As Integer
        Dim SystemTraceNumber As Integer
        Try
            SystemTraceNumber = My.Computer.Registry.GetValue(keyRegedit, "SystemTraceNumber", "1")
            If (SystemTraceNumber + 1) > 9999 Then
                SystemTraceNumber = 1
            End If
            My.Computer.Registry.SetValue(keyRegedit, "SystemTraceNumber", SystemTraceNumber + 1)
        Catch ex As Exception
            AlmacenarLog(5, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
        End Try
        Return SystemTraceNumber
    End Function
    Friend Function GetIsTesting() As Boolean
        Dim keyValue As Object
        keyValue = My.Computer.Registry.GetValue(keyRegedit, "IsTesting", "0")
        If keyValue = "1" Then
            Return True
        Else
            Return False
        End If
    End Function
    Friend Function GetIsLog() As Boolean
        Dim keyValue As Object
        keyValue = My.Computer.Registry.GetValue(keyRegedit, "IsLog", "0")
        If keyValue = "1" Then
            Return True
        Else
            Return False
        End If
    End Function

#Region "IDisposable Support"
    Private disposedValue As Boolean ' Para detectar llamadas redundantes

    ' IDisposable
    Protected Overridable Sub Dispose(disposing As Boolean)
        If Not disposedValue Then
            If disposing Then
                ' TODO: elimine el estado administrado (objetos administrados).
            End If

            ' TODO: libere los recursos no administrados (objetos no administrados) y reemplace Finalize() a continuación.
            ' TODO: configure los campos grandes en nulos.
        End If
        disposedValue = True
    End Sub

    ' TODO: reemplace Finalize() solo si el anterior Dispose(disposing As Boolean) tiene código para liberar recursos no administrados.
    'Protected Overrides Sub Finalize()
    '    ' No cambie este código. Coloque el código de limpieza en el anterior Dispose(disposing As Boolean).
    '    Dispose(False)
    '    MyBase.Finalize()
    'End Sub

    ' Visual Basic agrega este código para implementar correctamente el patrón descartable.
    Public Sub Dispose() Implements IDisposable.Dispose
        ' No cambie este código. Coloque el código de limpieza en el anterior Dispose(disposing As Boolean).
        Dispose(True)
        ' TODO: quite la marca de comentario de la siguiente línea si Finalize() se ha reemplazado antes.
        ' GC.SuppressFinalize(Me)
    End Sub
#End Region
End Class
