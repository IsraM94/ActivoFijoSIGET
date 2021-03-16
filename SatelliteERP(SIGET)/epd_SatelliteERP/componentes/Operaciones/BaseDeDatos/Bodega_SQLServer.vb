Imports System.Data.SqlClient

Public Class Bodega_SQLServer : Implements IDisposable
    ' Luis eliminar este y pasarlo a Inventory
    Dim process As New ProcessGeneral
    Private connStr As String = DataCenter()

    Friend Function DataCenter() As String
        Return SQLConfiguration.EpdConnectionString.ToString
        REM Return My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Epdsoft\SatelliteERP", "ConnectionStrings", "Error") REM trae el valor del regedit
        Dim a As String = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Retail Pro\Epdsoft", "ConnectionStrings", "Error")
    End Function

    Private MSGERROR As String = "Fallo en la conexión con la base de datos, comuniquese con soporte técnico."

    Public Function Inventory_GetInventoryStowageReport(ByVal Data_Id_Company As Long) As DataTable
        Dim dt As New DataTable
        Dim ds As New DataSet("Data")
        Try
            Using da As New SqlDataAdapter("ERP_Maintenance_SelectInventoryStowage", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@id_Company", Data_Id_Company)
                da.Fill(ds, "datos")
                dt = ds.Tables("datos")
            End Using
        Catch ex As SqlException

        Catch ex As Exception

        End Try
        Return dt
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
