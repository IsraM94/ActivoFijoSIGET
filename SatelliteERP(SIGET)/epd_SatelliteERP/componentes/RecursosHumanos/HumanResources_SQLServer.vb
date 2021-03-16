Imports System.Data.SqlClient

Public Class HumanResources_SQLServer : Implements IDisposable

    Dim process As New ProcessGeneral
    Private connStr As String = DataCenter()
    Friend Function DataCenter() As String
        Return SQLConfiguration.EpdConnectionString.ToString
        REM Return My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Epdsoft\SatelliteERP", "ConnectionStrings", "Error") REM trae el valor del regedit
        Dim a As String = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Retail Pro\Epdsoft", "ConnectionStrings", "Error")
    End Function


    Public Function GetEmploye(ByVal id_Company As Long) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_RRHH_GetEmployee", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_Company", SqlDbType.BigInt).Value = id_Company
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return ds.Tables("datos")
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return New DataTable("datos")
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function
    Public Function GetContactEmploye(ByVal id_Company As Long) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_RRHH_GetContactEmploye", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_Company", SqlDbType.BigInt).Value = id_Company
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return ds.Tables("datos")
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return New DataTable("datos")
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function
    Public Function GetLocation(ByVal id_Company As Long) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_RRHH_GetLocation", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_Company", SqlDbType.BigInt).Value = id_Company
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return ds.Tables("datos")
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return New DataTable("datos")
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function

    Public Function GetLocationByPrimary(ByVal id_Company As Long, ByVal IdUbicacionPrimaria As Integer) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_RRHH_GetLocationByPrimary", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_Company", SqlDbType.BigInt).Value = id_Company
                cmd.Parameters.Add("@IdUbicacionPrimaria", SqlDbType.BigInt).Value = IdUbicacionPrimaria
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return ds.Tables("datos")
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return New DataTable("datos")
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function

    Public Function GetEstados() As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_getFixedAssets_State", conn)
                cmd.CommandType = CommandType.StoredProcedure
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return ds.Tables("datos")
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return New DataTable("datos")
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function

    Public Function GetColor() As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("SP_ERP_GetGenericColors", conn)
                cmd.CommandType = CommandType.StoredProcedure
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return ds.Tables("datos")
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return New DataTable("datos")
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function

    Public Function GetMaterials() As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("SP_ERP_GetGenericMaterials", conn)
                cmd.CommandType = CommandType.StoredProcedure
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return ds.Tables("datos")
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return New DataTable("datos")
                        End Try
                    End Using
                End Using
            End Using
        End Using
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
