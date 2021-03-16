Imports System.Data.SqlClient

Public Class POA_SQLServer : Implements IDisposable
    Dim process As New ProcessGeneral
    Private connStr As String = DataCenter()
    Property Server As String
    Property BaseDeDatos As String

    Friend Function DataCenter() As String
        Dim connectionString As SqlConnectionStringBuilder = SQLConfiguration.EpdConnectionString
        Server = connectionString.DataSource
        BaseDeDatos = connectionString.InitialCatalog

        Return connectionString.ConnectionString
    End Function

#Region "Unidad Medida"
    Public Function ERP_StrategicPlan_MeasureType() As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_StrategicPlan_GetMeasureType", conn)
                cmd.CommandType = CommandType.StoredProcedure
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return ds.Tables("datos")
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.Message, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return New DataTable("datos")
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function

#End Region

#Region "Gerencia o Unidad Asesoria"
    Public Function ERP_StrategicPlan_GetManagement() As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_StrategicPlan_GetManagement", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@idcompany", SqlDbType.BigInt).Value = Data_Id_Company
                cmd.Parameters.Add("@Id_Departamento", SqlDbType.BigInt).Value = _Id_DptoPlani
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return ds.Tables("datos")
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.Message, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return New DataTable("datos")
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function

    Public Function ERP_StrategicPlan_GetManagementPadre() As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_StrategicPlan_GetManagementPadre", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@idcompany", SqlDbType.BigInt).Value = Data_Id_Company
                cmd.Parameters.Add("@Id_Departamento", SqlDbType.BigInt).Value = _Id_DptoPlani
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return ds.Tables("datos")
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.Message, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return New DataTable("datos")
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function

    Public Function ERP_StrategicPlan_InsertManagement(ByVal management As String, ByVal description As String, ByVal ID_DepartmentPadre As Long, ByVal GerenciaPadre As Boolean) As String
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_StrategicPlan_InsertManagement", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@idcompany", SqlDbType.BigInt).Value = Data_Id_Company
                cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = management
                cmd.Parameters.Add("@Description", SqlDbType.VarChar).Value = description
                cmd.Parameters.Add("@ID_DepartmenPadre", SqlDbType.Int).Value = ID_DepartmentPadre
                cmd.Parameters.Add("@Padre", SqlDbType.Bit).Value = GerenciaPadre
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return "OK"
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.Message, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "ERROR"
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function


    Public Function ERP_StrategicPlan_UpdateManagement(ByVal id_Management As Long, ByVal name As String, ByVal description As String, ByVal ID_Servicio As Long, ByVal GerenciaPadre As Boolean) As String
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_StrategicPlan_UpdateManagement", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@IdCompany", SqlDbType.BigInt).Value = Data_Id_Company
                cmd.Parameters.Add("@ID_Management", SqlDbType.BigInt).Value = id_Management
                cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = name
                cmd.Parameters.Add("@Description", SqlDbType.VarChar).Value = description
                cmd.Parameters.Add("@ID_DepartmenPadre", SqlDbType.Int).Value = ID_Servicio
                cmd.Parameters.Add("@Padre", SqlDbType.Int).Value = GerenciaPadre
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return "OK"
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.Message, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "ERROR"
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function

    Public Function ERP_Config_SetUserAccess(ByVal username As String, ByVal id_access As Long, ByVal activo As Boolean) As String
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_Config_SetAccessUsers", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@nameUser", SqlDbType.VarChar).Value = username
                cmd.Parameters.Add("@idconfig", SqlDbType.BigInt).Value = id_access
                cmd.Parameters.Add("@activo", SqlDbType.Bit).Value = activo
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return "OK"
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.Message, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "ERROR"
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function
    Public Function ERP_Config_GetUserAccess(ByVal username As String) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_Config_GetAccessUsers", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@nameUser", SqlDbType.VarChar).Value = username
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return ds.Tables("datos")
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.Message, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return New DataTable("datos")
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function

    Public Function EERP_StrategicPlan_DeleteManagement(ByVal id_Managment As Long) As String
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_StrategicPlan_DeleteManagement", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@IdCompany", SqlDbType.BigInt).Value = Data_Id_Company
                cmd.Parameters.Add("@idmanagement", SqlDbType.BigInt).Value = id_Managment
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return "OK"
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.Message, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "ERROR"
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function

    Public Function ERP_Config_DeactivateAccessUserName(ByVal id_Username As Long) As String
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_Config_DeactiveAccessUserName", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@IdCompany", SqlDbType.BigInt).Value = Data_Id_Company
                cmd.Parameters.Add("@idUsername", SqlDbType.BigInt).Value = id_Username
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return "OK"
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.Message, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "ERROR"
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function

#End Region

#Region "Objetivos Estrategicos "
    Public Function ERP_StrategicPlan_GetStrategicObjective(ByVal Id_Departamento As Integer) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_StrategicPlan_GetStrategicObjective", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@idcompany", SqlDbType.BigInt).Value = Data_Id_Company
                cmd.Parameters.Add("@Id_Departamento", SqlDbType.BigInt).Value = Id_Departamento
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return ds.Tables("datos")
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.Message, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return New DataTable("datos")
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function

    Public Function ERP_StrategicPlan_GetStrategicObjectiveDepartment() As String
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_StrategicPlan_GetObjetiveDepartment", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@idcompany", SqlDbType.BigInt).Value = Data_Id_Company
                cmd.Parameters.Add("@Id_Departamento", SqlDbType.BigInt).Value = _Id_DptoPlani
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return ds.Tables("datos").Rows(0).Item(0).ToString
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.Message, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return ""
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function

    Public Function ERP_Config_SetUserAccess1(ByVal username As String, ByVal id_access As Long, ByVal activo As Boolean) As String
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_Config_SetAccessUsers", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@nameUser", SqlDbType.VarChar).Value = username
                cmd.Parameters.Add("@idconfig", SqlDbType.BigInt).Value = id_access
                cmd.Parameters.Add("@activo", SqlDbType.Bit).Value = activo
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return "OK"
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.Message, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "ERROR"
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function
    Public Function ERP_Config_GetUserAccess1(ByVal username As String) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_Config_GetAccessUsers", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@nameUser", SqlDbType.VarChar).Value = username
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return ds.Tables("datos")
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.Message, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return New DataTable("datos")
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function

    Public Function ERP_StrategicPlan_Insertobjective(ByVal objective As String, ByVal description As String) As String
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_StrategicPlan_Insertobjective", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@idcompany", SqlDbType.BigInt).Value = Data_Id_Company
                cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = objective
                cmd.Parameters.Add("@Description", SqlDbType.VarChar).Value = description
                cmd.Parameters.Add("@Id_Department", SqlDbType.Int).Value = _Id_DepartmentGlobal
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return "OK"
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.Message, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "ERROR"
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function
    Public Function ERP_StrategicPlan_UpdateObjective(ByVal id_objective As Long, ByVal name As String, ByVal description As String) As String
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_StrategicPlan_UpdateObjective", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@IdCompany", SqlDbType.BigInt).Value = Data_Id_Company
                cmd.Parameters.Add("@idstrategicObjective", SqlDbType.BigInt).Value = id_objective
                cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = name
                cmd.Parameters.Add("@Description", SqlDbType.VarChar).Value = description
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return "OK"
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.Message, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "ERROR"
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function

    Public Function EERP_StrategicPlan_DeleteObjective(ByVal id_objective As Long) As String
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_StrategicPlan_DeleteObjective", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@IdCompany", SqlDbType.BigInt).Value = Data_Id_Company
                cmd.Parameters.Add("@idstrategicObjective", SqlDbType.BigInt).Value = id_objective
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return "OK"
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.Message, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "ERROR"
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function

    Public Function ERP_Config_DeactivateAccessUserName1(ByVal id_Username As Long) As String
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_Config_DeactiveAccessUserName", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@IdCompany", SqlDbType.BigInt).Value = Data_Id_Company
                cmd.Parameters.Add("@idUsername", SqlDbType.BigInt).Value = id_Username
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return "OK"
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.Message, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "ERROR"
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function

#End Region

#Region "Ejes Estrategicos"

    Public Function ERP_StrategicPlan_GetStrategicAxes(ByVal Tipo As Integer, ByVal Id_Departamento As Integer) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_StrategicPlan_GetStrategicAxes", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@idcompany", SqlDbType.BigInt).Value = Data_Id_Company
                If Id_Departamento > 0 Then
                    cmd.Parameters.Add("@Id_Departamento", SqlDbType.BigInt).Value = Id_Departamento
                Else
                    cmd.Parameters.Add("@Id_Departamento", SqlDbType.BigInt).Value = _Id_DptoPlani
                End If
                cmd.Parameters.Add("@Tipo", SqlDbType.BigInt).Value = Tipo
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return ds.Tables("datos")
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.Message, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return New DataTable("datos")
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function


    Public Function ERP_StrategicPlan_GetStrategicAxesCode(ByVal Id_Departamento As Integer) As String
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_StrategicPlan_GETCodeStrategicAxes", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@idcompany", SqlDbType.BigInt).Value = Data_Id_Company
                cmd.Parameters.Add("@Id_Departamento", SqlDbType.BigInt).Value = _Id_DptoPlani
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return ds.Tables("datos").Rows(0).Item("resp").ToString
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.Message, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return ""
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function

    Public Function ERP_StrategicPlan_SearchAxes(ByVal text As String) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_StrategicPlan_SearchAxes", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@idcompany", SqlDbType.BigInt).Value = Data_Id_Company
                cmd.Parameters.Add("@Id_Departamento", SqlDbType.BigInt).Value = _Id_DptoPlani
                cmd.Parameters.Add("@text", SqlDbType.VarChar).Value = text
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return ds.Tables("datos")
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.Message, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return New DataTable("datos")
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function

    Public Function ERP_StrategicPlan_InsertStrategicAxes(ByVal strategicaxes As String, ByVal description As String, Byval Id_UnidadEncargada As integer ) As String
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_StrategicPlan_InsertStrategicAxes", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@idcompany", SqlDbType.BigInt).Value = Data_Id_Company
                cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = strategicaxes
                cmd.Parameters.Add("@Description", SqlDbType.VarChar).Value = description
                cmd.Parameters.Add("@Id_Departamento", SqlDbType.Int).Value = _Id_DepartmentGlobal
                cmd.Parameters.Add("@Id_UnidadEncargada", SqlDbType.Int).Value = Id_UnidadEncargada
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return ds.Tables(0).Rows(0).Item("resp")
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.Message, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "ERROR"
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function

    Public Function ERP_StrategicPlan_UpdateStrategicAxes(ByVal idstrategicAxes As Long, ByVal name As String, ByVal description As String, ByVal Id_UnidadEncargada As Integer) As String
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_StrategicPlan_UpdateStrategicAxes", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@IdCompany", SqlDbType.BigInt).Value = Data_Id_Company
                cmd.Parameters.Add("@idstrategicAxes", SqlDbType.BigInt).Value = idstrategicAxes
                cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = name
                cmd.Parameters.Add("@Description", SqlDbType.VarChar).Value = description
                cmd.Parameters.Add("@Id_UnidadEncargada", SqlDbType.Int).Value = Id_UnidadEncargada
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return "OK"
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.Message, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "ERROR"
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function

    Public Function EERP_StrategicPlan_DeleteStrategicAxes(ByVal idstrategicAxes As Long) As String
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_StrategicPlan_DeleteStrategicAxes", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@IdCompany", SqlDbType.BigInt).Value = Data_Id_Company
                cmd.Parameters.Add("@idstrategicAxes", SqlDbType.BigInt).Value = idstrategicAxes
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return "OK"
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.Message, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "ERROR"
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function
#End Region

#Region "Acciones Estrategicas"

    Public Function ERP_StrategicPlan_GetStrategicActions(ByVal Tipo As Integer, ByVal Id_Departamento As Integer) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_StrategicPlan_GetStrategicActions", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@idcompany", SqlDbType.BigInt).Value = Data_Id_Company
                If Id_Departamento > 0 Then
                    cmd.Parameters.Add("@Id_Departamento", SqlDbType.BigInt).Value = Id_Departamento
                Else
                    cmd.Parameters.Add("@Id_Departamento", SqlDbType.BigInt).Value = _Id_DptoPlani
                End If

                cmd.Parameters.Add("@Tipo", SqlDbType.BigInt).Value = Tipo
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return ds.Tables("datos")
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.Message, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return New DataTable("datos")
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function


    Public Function ERP_StrategicPlan_GetStrategicActionsAlert(ByVal Id_Departamento As Integer) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_StrategicPlan_GetStrategicActionsAlert", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@idcompany", SqlDbType.BigInt).Value = Data_Id_Company
                cmd.Parameters.Add("@Id_Departamento", SqlDbType.BigInt).Value = Id_Departamento
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return ds.Tables("datos")
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.Message, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return New DataTable("datos")
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function

    Public Function ERP_StrategicPlan_GetPOAObservaciones(ByVal Id_Encabezado As Integer) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_StrategicPlan_GetPOAObservaciones", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_Encabezado", SqlDbType.BigInt).Value = Id_Encabezado
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return ds.Tables("datos")
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.Message, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return New DataTable("datos")
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function

    Public Function ERP_StrategicPlan_GetPEIObservaciones(ByVal Id_Encabezado As Integer) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_StrategicPlan_GetPEIObservaciones", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_Process", SqlDbType.BigInt).Value = Id_Encabezado
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return ds.Tables("datos")
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.Message, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return New DataTable("datos")
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function

    Public Function ERP_StrategicPlan_GetStrategicActionsAlertOperational(ByVal Id_Departamento As Integer) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_StrategicPlan_GetStrategicActionsAlertOperational", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@idcompany", SqlDbType.BigInt).Value = Data_Id_Company
                cmd.Parameters.Add("@Id_Departamento", SqlDbType.BigInt).Value = Id_Departamento
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return ds.Tables("datos")
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.Message, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return New DataTable("datos")
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function

    Public Function ERP_StrategicPlan_GetStrategicActionsResult(ByVal Id_Resultado As Integer) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_StrategicPlan_GetStrategicActionsResult", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@idcompany", SqlDbType.BigInt).Value = Data_Id_Company
                cmd.Parameters.Add("@Id_Resultado", SqlDbType.BigInt).Value = Id_Resultado
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return ds.Tables("datos")
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.Message, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return New DataTable("datos")
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function

    Public Function ERP_StrategicPlan_GetStrategicActionsById(ByVal Id_Accion As Integer) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_StrategicPlan_GetStrategicActionsById", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@idcompany", SqlDbType.BigInt).Value = Data_Id_Company
                cmd.Parameters.Add("@Id_Accion", SqlDbType.BigInt).Value = Id_Accion
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return ds.Tables("datos")
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.Message, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return New DataTable("datos")
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function

    Public Function ERP_StrategicPlan_GetStrategicActionsbyDeparment(ByVal Id_Departamento As Integer, ByVal Anio As Integer, ByVal Id_EncabezadoPOA As Integer) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_StrategicPlan_GetStrategicActionsbyDepartment", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@idcompany", SqlDbType.BigInt).Value = Data_Id_Company
                cmd.Parameters.Add("@Id_Departamento", SqlDbType.BigInt).Value = Id_Departamento
                cmd.Parameters.Add("@Anio", SqlDbType.BigInt).Value = Anio
                cmd.Parameters.Add("@Id_EncabezadoPOA", SqlDbType.BigInt).Value = Id_EncabezadoPOA
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return ds.Tables("datos")
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.Message, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return New DataTable("datos")
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function

    Public Function ERP_StrategicPlan_GetStrategicActionsbyDeparmentEjecucion(ByVal Id_Departamento As Integer, ByVal Anio As Integer, ByVal Id_Encabezado As Integer) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_StrategicPlan_GetStrategicActionsbyDepartmentEjecucion", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@idcompany", SqlDbType.BigInt).Value = Data_Id_Company
                cmd.Parameters.Add("@Id_Departamento", SqlDbType.BigInt).Value = Id_Departamento
                cmd.Parameters.Add("@Anio", SqlDbType.BigInt).Value = Anio
                cmd.Parameters.Add("@Id_EncabezadoPOA", SqlDbType.BigInt).Value = Id_Encabezado
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return ds.Tables("datos")
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.Message, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return New DataTable("datos")
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function

    Public Function ERP_StrategicPlan_InserStrategicActions(ByVal StrategicActions As String, ByVal description As String, ByVal id_result As Long, ByVal Id_UnitLider As Long,
                                                            ByVal Id_MeasureType As Long, ByVal FechaVencimiento As Date, ByVal Indicador As String,
                                                            ByVal Anio1 As Decimal, ByVal Anio2 As Decimal, ByVal Anio3 As Decimal, ByVal Anio4 As Decimal, ByVal Anio5 As Decimal,
                                                            ByVal Quinquenio As Integer, ByVal AccionApoyo As Boolean) As String
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_StrategicPlan_InserStrategicActions", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@idcompany", SqlDbType.BigInt).Value = Data_Id_Company
                cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = StrategicActions
                cmd.Parameters.Add("@Description", SqlDbType.VarChar).Value = description
                cmd.Parameters.Add("@ID_Result", SqlDbType.VarChar).Value = id_result
                cmd.Parameters.Add("@Id_UnitLider", SqlDbType.Int).Value = Id_UnitLider
                cmd.Parameters.Add("@Id_MeasureType", SqlDbType.Int).Value = Id_MeasureType
                cmd.Parameters.Add("@FechaVencimiento", SqlDbType.Date).Value = FechaVencimiento
                cmd.Parameters.Add("@ID_Department", SqlDbType.BigInt).Value = _Id_DepartmentGlobal
                cmd.Parameters.Add("@Indicador", SqlDbType.VarChar).Value = Indicador
                cmd.Parameters.Add("@Anio1", SqlDbType.Int).Value = Anio1
                cmd.Parameters.Add("@Anio2", SqlDbType.Int).Value = Anio2
                cmd.Parameters.Add("@Anio3", SqlDbType.Int).Value = Anio3
                cmd.Parameters.Add("@Anio4", SqlDbType.Int).Value = Anio4
                cmd.Parameters.Add("@Anio5", SqlDbType.Int).Value = Anio5
                cmd.Parameters.Add("@Quinquenio", SqlDbType.Int).Value = Quinquenio
                cmd.Parameters.Add("@AccionApoyo", SqlDbType.Bit).Value = AccionApoyo

                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return "OK"
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.Message, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "ERROR"
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function

    Public Function ERP_StrategicPlan_UpdateStrategicActions(ByVal idstrategicActions As Long, ByVal ID_Result As Long, ByVal name As String, ByVal description As String,
                                                             ByVal Id_UnitLider As Long, ByVal IdMeasureType As Long, ByVal FechaVencimiento As Date, ByVal Indicador As String,
                                                             ByVal Anio1 As Decimal, ByVal Anio2 As Decimal, ByVal Anio3 As Decimal, ByVal Anio4 As Decimal, ByVal Anio5 As Decimal,
                                                             ByVal Quinquenio As Integer, ByVal AccionApoyo As Boolean) As String
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_StrategicPlan_UpdateStrategicActions", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@IdCompany", SqlDbType.BigInt).Value = Data_Id_Company
                cmd.Parameters.Add("@idstrategicActions", SqlDbType.BigInt).Value = idstrategicActions
                cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = name
                cmd.Parameters.Add("@Description", SqlDbType.VarChar).Value = description
                cmd.Parameters.Add("@ID_Result", SqlDbType.BigInt).Value = ID_Result
                cmd.Parameters.Add("@FechaVencimiento", SqlDbType.Date).Value = FechaVencimiento
                cmd.Parameters.Add("@Id_UnitLider", SqlDbType.Int).Value = Id_UnitLider
                cmd.Parameters.Add("@Id_Deparment", SqlDbType.Int).Value = _Id_DepartmentGlobal
                cmd.Parameters.Add("@Indicador", SqlDbType.VarChar).Value = Indicador
                cmd.Parameters.Add("@Anio1", SqlDbType.Int).Value = Anio1
                cmd.Parameters.Add("@Anio2", SqlDbType.Int).Value = Anio2
                cmd.Parameters.Add("@Anio3", SqlDbType.Int).Value = Anio3
                cmd.Parameters.Add("@Anio4", SqlDbType.Int).Value = Anio4
                cmd.Parameters.Add("@Anio5", SqlDbType.Int).Value = Anio5
                cmd.Parameters.Add("@Quinquenio", SqlDbType.Int).Value = Quinquenio
                cmd.Parameters.Add("@AccionApoyo", SqlDbType.Bit).Value = AccionApoyo

                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return "OK"
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.Message, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "ERROR"
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function

    Public Function EERP_StrategicPlan_DeleteStrategicActions(ByVal idstrategicActions As Long) As String
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_StrategicPlan_DeleteStrategicActions", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@IdCompany", SqlDbType.BigInt).Value = Data_Id_Company
                cmd.Parameters.Add("@idstrategicActions", SqlDbType.BigInt).Value = idstrategicActions
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return "OK"
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.Message, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "ERROR"
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function

    Public Function ERP_StrategicPlan_Getservices() As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_StrategicPlan_Getservices", conn)
                cmd.CommandType = CommandType.StoredProcedure
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return ds.Tables("datos")
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.Message, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return New DataTable("datos")
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function


    Public Function ERP_StrategicPlan_UpdateStrategicActionsPercentage(ByVal idstrategicActions As Long, ByVal Id_Result As Long, ByVal Anio1 As Integer, ByVal Anio2 As Integer, ByVal Anio3 As Integer, ByVal Anio4 As Integer, ByVal Anio5 As Integer) As String
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_StrategicPlan_UpdateStrategicActionsPercentage", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@IdCompany", SqlDbType.BigInt).Value = Data_Id_Company
                cmd.Parameters.Add("@idstrategicActions", SqlDbType.BigInt).Value = idstrategicActions
                cmd.Parameters.Add("@idResult", SqlDbType.BigInt).Value = Id_Result
                cmd.Parameters.Add("@Anio1", SqlDbType.BigInt).Value = Anio1
                cmd.Parameters.Add("@Anio2", SqlDbType.BigInt).Value = Anio2
                cmd.Parameters.Add("@Anio3", SqlDbType.BigInt).Value = Anio3
                cmd.Parameters.Add("@Anio4", SqlDbType.BigInt).Value = Anio4
                cmd.Parameters.Add("@Anio5", SqlDbType.BigInt).Value = Anio5
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return "OK"
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.Message, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "ERROR"
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function


    Public Function ERP_SP_CrearCodigoAcciones() As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("SP_CrearCodigoAcciones", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_Departamento", SqlDbType.BigInt).Value = _Id_DptoPlani
                cmd.Parameters.Add("@Tipo", SqlDbType.BigInt).Value = 1
                cmd.Parameters.Add("@Anio", SqlDbType.BigInt).Value = 0
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return ds.Tables("datos")
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.Message, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return New DataTable("datos")
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function

#End Region

#Region "Responsable Ejecucion"

    Public Function ERP_StrategicPlan_GetResponsibleExecution(ByVal Id_departamento As Integer) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_StrategicPlan_GetResponsibleExecution", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@idcompany", SqlDbType.BigInt).Value = Data_Id_Company
                If Id_departamento > 0 Then
                    cmd.Parameters.Add("@Id_Departamento", SqlDbType.BigInt).Value = Id_departamento
                Else
                    cmd.Parameters.Add("@Id_Departamento", SqlDbType.BigInt).Value = _Id_DptoPlani
                End If
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return ds.Tables("datos")
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.Message, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return New DataTable("datos")
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function

    Public Function ERP_StrategicPlan_InserResponsibleExecution(ByVal ResponsibleExecution As String, ByVal description As String) As String
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_StrategicPlan_InserResponsibleExecution", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@idcompany", SqlDbType.BigInt).Value = Data_Id_Company
                cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = ResponsibleExecution
                cmd.Parameters.Add("@Description", SqlDbType.VarChar).Value = description
                cmd.Parameters.Add("@Id_Departamento", SqlDbType.VarChar).Value = _Id_DepartmentGlobal
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return "OK"
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.Message, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "ERROR"
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function

    Public Function ERP_StrategicPlan_UpdateResponsibleExecution(ByVal idresponsibleExecution As Long, ByVal name As String, ByVal description As String) As String
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_StrategicPlan_UpdateResponsibleExecution", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@IdCompany", SqlDbType.BigInt).Value = Data_Id_Company
                cmd.Parameters.Add("@idresponsibleExecution", SqlDbType.BigInt).Value = idresponsibleExecution
                cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = name
                cmd.Parameters.Add("@Description", SqlDbType.VarChar).Value = description
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return "OK"
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.Message, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "ERROR"
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function

    Public Function EERP_StrategicPlan_DeleteResponsibleExecution(ByVal idresponsibleExecution As Long) As String
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_StrategicPlan_DeleteResponsibleExecution", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@IdCompany", SqlDbType.BigInt).Value = Data_Id_Company
                cmd.Parameters.Add("@idresponsibleExecution", SqlDbType.BigInt).Value = idresponsibleExecution
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return "OK"
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.Message, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "ERROR"
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function


#End Region

#Region "Acciones Operativas"

    Public Function ERP_StrategicPlan_GetOperationalAction(ByVal Id_Departamento As Integer) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_StrategicPlan_GetOperationalAction", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@idcompany", SqlDbType.BigInt).Value = Data_Id_Company
                If Id_Departamento > 0 Then
                    cmd.Parameters.Add("@Id_Departamento", SqlDbType.BigInt).Value = Id_Departamento
                Else
                    cmd.Parameters.Add("@Id_Departamento", SqlDbType.BigInt).Value = _Id_DptoPlani
                End If
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return ds.Tables("datos")
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.Message, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return New DataTable("datos")
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function

    Public Function ERP_StrategicPlan_GetOperationalActionPOA(ByVal Anio As Integer) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_StrategicPlan_GetOperationalActionPOA", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@idcompany", SqlDbType.BigInt).Value = Data_Id_Company
                cmd.Parameters.Add("@Id_Departamento", SqlDbType.BigInt).Value = _Id_DptoPlani
                cmd.Parameters.Add("@Anio", SqlDbType.BigInt).Value = Anio
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return ds.Tables(0)
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.Message, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return New DataTable("datos")
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function

    Public Function ERP_StrategicPlan_GetPOASeguimientoStatus(ByVal Mes As Integer, ByVal Id_EncabezadoPOA As Integer, ByVal TipoAccion As Integer) As String
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_StrategicPlan_GetStatusSeguimientoPOA", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@idcompany", SqlDbType.BigInt).Value = Data_Id_Company
                cmd.Parameters.Add("@Id_Departamento", SqlDbType.BigInt).Value = _Id_DptoPlani
                cmd.Parameters.Add("@Mes", SqlDbType.BigInt).Value = Mes
                cmd.Parameters.Add("@Id_EncabezadoPOA", SqlDbType.BigInt).Value = Id_EncabezadoPOA
                cmd.Parameters.Add("@TipoAccion", SqlDbType.SmallInt).Value = TipoAccion
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            If Not IsNothing(ds) Then
                                Return ds.Tables(0).Rows(0).Item("resp")
                            End If

                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.Message, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return ""
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function

    Public Function ERP_StrategicPlan_InsertOperationalAction(ByVal ID_StrategicActions_FK As Long, ByVal name As String, ByVal description As String, ByVal Id_MeasureType As Long, ByVal FechaVencimiento As Date, ByVal Indicador As String, ByVal Id_UnidadLider As Integer, ByVal Anio As String) As String
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_StrategicPlan_InsertOperationalAction", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@idcompany", SqlDbType.BigInt).Value = Data_Id_Company
                cmd.Parameters.Add("@ID_StrategicActions_FK", SqlDbType.BigInt).Value = ID_StrategicActions_FK
                cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = name
                cmd.Parameters.Add("@Description", SqlDbType.VarChar).Value = description
                cmd.Parameters.Add("@Id_MeasureType", SqlDbType.BigInt).Value = Id_MeasureType
                cmd.Parameters.Add("@FechaVencimiento", SqlDbType.Date).Value = FechaVencimiento
                cmd.Parameters.Add("@Indicador", SqlDbType.VarChar).Value = Indicador
                cmd.Parameters.Add("@Id_department", SqlDbType.VarChar).Value = _Id_DepartmentGlobal
                cmd.Parameters.Add("@Id_UnitLider", SqlDbType.Int).Value = Id_UnidadLider
                cmd.Parameters.Add("@Anio", SqlDbType.VarChar).Value = Anio

                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return "OK"
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.Message, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "ERROR"
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function

    Public Function ERP_StrategicPlan_UpdateOperationalAction(ByVal ID_OperationalAction As Long, ByVal ID_StrategicActions_FK As Long, ByVal name As String, ByVal description As String, ByVal Id_MeasureType As Long, ByVal FechaVencimiento As Date, ByVal Indicador As String, ByVal Id_UnidadLider As Integer, ByVal Anio As String) As String
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_StrategicPlan_UpdateOperationalAction", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@IdCompany", SqlDbType.BigInt).Value = Data_Id_Company
                cmd.Parameters.Add("@ID_OperationalAction", SqlDbType.BigInt).Value = ID_OperationalAction
                cmd.Parameters.Add("@ID_StrategicActions_FK", SqlDbType.BigInt).Value = ID_StrategicActions_FK
                cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = name
                cmd.Parameters.Add("@Description", SqlDbType.VarChar).Value = description
                cmd.Parameters.Add("@Id_MeasureType", SqlDbType.BigInt).Value = Id_MeasureType
                cmd.Parameters.Add("@FechaVencimiento", SqlDbType.Date).Value = FechaVencimiento
                cmd.Parameters.Add("@Indicador", SqlDbType.VarChar).Value = Indicador
                cmd.Parameters.Add("@Id_UnitLider", SqlDbType.Int).Value = Id_UnidadLider
                cmd.Parameters.Add("@Anio", SqlDbType.VarChar).Value = Anio

                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return "OK"
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.Message, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "ERROR"
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function

    Public Function EERP_StrategicPlan_DeleteOperationalAction(ByVal ID_OperationalAction As Long) As String
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_StrategicPlan_DeleteOperationalAction", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@IdCompany", SqlDbType.BigInt).Value = Data_Id_Company
                cmd.Parameters.Add("@ID_OperationalAction", SqlDbType.BigInt).Value = ID_OperationalAction
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return "OK"
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.Message, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "ERROR"
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function
#End Region

#Region "Resultados"

    Public Function ERP_StrategicPlan_GetResult(ByVal Tipo As Integer, ByVal Id_Departamento As Integer) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_StrategicPlan_GetResult", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@idcompany", SqlDbType.BigInt).Value = Data_Id_Company
                If Id_Departamento > 0 Then
                    cmd.Parameters.Add("@Id_Departamento", SqlDbType.BigInt).Value = Id_Departamento
                Else
                    cmd.Parameters.Add("@Id_Departamento", SqlDbType.BigInt).Value = _Id_DptoPlani
                End If
                cmd.Parameters.Add("@Tipo", SqlDbType.BigInt).Value = Tipo
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return ds.Tables("datos")
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.Message, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return New DataTable("datos")
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function


    Public Function ERP_StrategicPlan_GetResultAxes(ByVal Tipo As Integer, ByVal IdAxes As Integer) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_StrategicPlan_GetResultAxes", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@idcompany", SqlDbType.BigInt).Value = Data_Id_Company
                cmd.Parameters.Add("@Id_Departamento", SqlDbType.BigInt).Value = _Id_DptoPlani
                cmd.Parameters.Add("@Tipo", SqlDbType.BigInt).Value = Tipo
                cmd.Parameters.Add("@IdAxes", SqlDbType.BigInt).Value = IdAxes
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return ds.Tables("datos")
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.Message, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return New DataTable("datos")
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function

    Public Function ERP_StrategicPlan_GetLiderAxes(ByVal IdAxes As Integer) As Integer
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_StrategicPlan_GetLiderAxes", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@idcompany", SqlDbType.BigInt).Value = Data_Id_Company
                cmd.Parameters.Add("@IdAxes", SqlDbType.BigInt).Value = IdAxes
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return ds.Tables("datos").Rows(0).Item("resp")
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.Message, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return 0
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function



    Public Function ERP_StrategicPlan_InsertResult(ByVal result As String, ByVal description As String, ByVal ID_StrategicAxes As Long) As String
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_StrategicPlan_InsertResult", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@idcompany", SqlDbType.BigInt).Value = Data_Id_Company
                cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = result
                cmd.Parameters.Add("@Description", SqlDbType.VarChar).Value = description
                cmd.Parameters.Add("@ID_StrategicAxes", SqlDbType.VarChar).Value = ID_StrategicAxes
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return "OK"
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.Message, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "ERROR"
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function

    Public Function ERP_StrategicPlan_UpdateResult(ByVal idresponsibleExecution As Long, ByVal result As String, ByVal description As String, ByVal ID_StrategicAxes As Long) As String
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_StrategicPlan_UpdateResult", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@IdCompany", SqlDbType.BigInt).Value = Data_Id_Company
                cmd.Parameters.Add("@idresult", SqlDbType.BigInt).Value = idresponsibleExecution
                cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = result
                cmd.Parameters.Add("@Description", SqlDbType.VarChar).Value = description
                cmd.Parameters.Add("@ID_StrategicAxes", SqlDbType.VarChar).Value = ID_StrategicAxes
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return "OK"
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.Message, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "ERROR"
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function

    Public Function EERP_StrategicPlan_DeleteResult(ByVal idresponsibleExecution As Long) As String
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_StrategicPlan_DeleteResult", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@IdCompany", SqlDbType.BigInt).Value = Data_Id_Company
                cmd.Parameters.Add("@idresult", SqlDbType.BigInt).Value = idresponsibleExecution
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return "OK"
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.Message, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "ERROR"
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function



#End Region

#Region "Indicadores"

    Public Function ERP_StrategicPlan_Getindicator(ByVal Id_Departamento As Integer) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_StrategicPlan_Getindicator", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@idcompany", SqlDbType.BigInt).Value = Data_Id_Company
                If Id_Departamento > 0 Then
                    cmd.Parameters.Add("@Id_Departamento", SqlDbType.BigInt).Value = Id_Departamento
                Else
                    cmd.Parameters.Add("@Id_Departamento", SqlDbType.BigInt).Value = _Id_DptoPlani
                End If
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return ds.Tables("datos")
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.Message, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return New DataTable("datos")
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function

    Public Function ERP_StrategicPlan_SearchIndicatortByIdResult(ByVal ID_Result As Long, ByVal Id_Axes As Integer) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_StrategicPlan_SearchIndicatortByIdResult", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@idcompany", SqlDbType.BigInt).Value = Data_Id_Company
                cmd.Parameters.Add("@ID_Result", SqlDbType.VarChar).Value = ID_Result
                cmd.Parameters.Add("@Id_Axes", SqlDbType.Int).Value = Id_Axes
                cmd.Parameters.Add("@Id_DptoPlani", SqlDbType.Int).Value = _Id_DptoPlani
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return ds.Tables("datos")
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.Message, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return New DataTable("datos")
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function

    Public Function ERP_StrategicPlan_Insertindicators(ByVal ID_Result As Long, ByVal indicator As String, ByVal description As String) As String
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_StrategicPlan_Insertindicators", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@idcompany", SqlDbType.BigInt).Value = Data_Id_Company
                cmd.Parameters.Add("@ID_Result", SqlDbType.BigInt).Value = ID_Result
                cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = indicator
                cmd.Parameters.Add("@Description", SqlDbType.VarChar).Value = description
                cmd.Parameters.Add("@Id_Department", SqlDbType.VarChar).Value = _Id_DptoPlani
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return "OK"
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.Message, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "ERROR"
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function

    Public Function ERP_StrategicPlan_Updateindicators(ByVal idindicator As Long, ByVal ID_Result As Long, ByVal indicator As String, ByVal description As String) As String
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_StrategicPlan_Updateindicators", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@IdCompany", SqlDbType.BigInt).Value = Data_Id_Company
                cmd.Parameters.Add("@idindicator", SqlDbType.BigInt).Value = idindicator
                cmd.Parameters.Add("@ID_Result", SqlDbType.BigInt).Value = ID_Result
                cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = indicator
                cmd.Parameters.Add("@Description", SqlDbType.VarChar).Value = description
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return "OK"
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.Message, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "ERROR"
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function

    Public Function EERP_StrategicPlan_Deleteindicators(ByVal idindicator As Long) As String
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_StrategicPlan_Deleteindicators", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@IdCompany", SqlDbType.BigInt).Value = Data_Id_Company
                cmd.Parameters.Add("@idindicator", SqlDbType.BigInt).Value = idindicator
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return "OK"
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.Message, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "ERROR"
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function

#End Region

#Region "Unidad Lider"

    Public Function ERP_StrategicPlan_GetUnitLider(ByVal Id_Departamento As Integer) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_StrategicPlan_Getfreeunit", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@idcompany", SqlDbType.BigInt).Value = Data_Id_Company
                If Id_Departamento > 0 Then
                    cmd.Parameters.Add("@Id_Departamento", SqlDbType.BigInt).Value = Id_Departamento
                Else
                    cmd.Parameters.Add("@Id_Departamento", SqlDbType.BigInt).Value = _Id_DptoPlani
                End If
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return ds.Tables("datos")
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.Message, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return New DataTable("datos")
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function

    Public Function ERP_StrategicPlan_Insertfreeunit(ByVal name As String, ByVal Siglas As String, ByVal ID_Management As Long) As String
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_StrategicPlan_Insertfreeunit", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@idcompany", SqlDbType.BigInt).Value = Data_Id_Company
                cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = name
                cmd.Parameters.Add("@ID_Management", SqlDbType.BigInt).Value = ID_Management
                cmd.Parameters.Add("@Siglas", SqlDbType.VarChar).Value = Siglas
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return "OK"
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.Message, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "ERROR"
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function

    Public Function ERP_StrategicPlan_Updatefreeunit(ByVal ID_Freeunit As Long, ByVal name As String, ByVal Siglas As String, ByVal ID_Management As Long) As String
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_StrategicPlan_Updatefreeunit", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@IdCompany", SqlDbType.BigInt).Value = Data_Id_Company
                cmd.Parameters.Add("@ID_Freeunit", SqlDbType.BigInt).Value = ID_Freeunit
                cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = name
                cmd.Parameters.Add("@Siglas", SqlDbType.VarChar).Value = Siglas
                cmd.Parameters.Add("@ID_Management", SqlDbType.BigInt).Value = ID_Management
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return "OK"
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.Message, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "ERROR"
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function

    Public Function EERP_StrategicPlan_Deletefreeunit(ByVal ID_Freeunit As Long) As String
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_StrategicPlan_Deletefreeunit", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@IdCompany", SqlDbType.BigInt).Value = Data_Id_Company
                cmd.Parameters.Add("@ID_Freeunit", SqlDbType.BigInt).Value = ID_Freeunit
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return "OK"
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.Message, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "ERROR"
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function

#End Region

#Region "Filosofia Institucional"

    Public Function ERP_StrategicPlan_GetInstitutionalPhilosophy() As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_StrategicPlan_GetInstitutionalPhilosophy", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@idcompany", SqlDbType.BigInt).Value = Data_Id_Company
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return ds.Tables("datos")
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.Message, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return New DataTable("datos")
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function

    Public Function ERP_StrategicPlan_InsertInstitutionalPhilosophy(ByVal Vision As String, ByVal Mision As String, ByVal Valore As String) As String
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_StrategicPlan_InsertInstitutionalPhilosophy", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@idcompany", SqlDbType.BigInt).Value = Data_Id_Company
                cmd.Parameters.Add("@Vision", SqlDbType.VarChar).Value = Vision
                cmd.Parameters.Add("@Mision", SqlDbType.VarChar).Value = Mision
                cmd.Parameters.Add("@Valores", SqlDbType.VarChar).Value = Valore
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return "OK"
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.Message, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "ERROR"
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function

    Public Function ERP_StrategicPlan_UpdateInstitutionalPhilosophy(ByVal ID_InstitutionalPhilosophy As Long, ByVal Vision As String, ByVal Mision As String, ByVal Valore As String) As String
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_StrategicPlan_UpdateInstitutionalPhilosophy", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@IdCompany", SqlDbType.BigInt).Value = Data_Id_Company
                cmd.Parameters.Add("@ID_InstitutionalPhilosophy", SqlDbType.BigInt).Value = ID_InstitutionalPhilosophy
                cmd.Parameters.Add("@Vision", SqlDbType.VarChar).Value = Vision
                cmd.Parameters.Add("@Mision", SqlDbType.VarChar).Value = Mision
                cmd.Parameters.Add("@Valores", SqlDbType.VarChar).Value = Valore
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return "OK"
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.Message, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "ERROR"
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function

    Public Function EERP_StrategicPlan_DeleteInstitutionalPhilosophy(ByVal ID_InstitutionalPhilosophy As Long) As String
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_StrategicPlan_DeleteInstitutionalPhilosophy", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@IdCompany", SqlDbType.BigInt).Value = Data_Id_Company
                cmd.Parameters.Add("@ID_InstitutionalPhilosophy", SqlDbType.BigInt).Value = ID_InstitutionalPhilosophy
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return "OK"
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.Message, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "ERROR"
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function

#End Region

#Region "Procesos"

    Public Function ERP_StrategicPlan_GetProcess() As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_StrategicPlan_GetProcess", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@ID_Departamento", SqlDbType.BigInt).Value = _Id_DptoPlani
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return ds.Tables("datos")
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.Message, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return New DataTable("datos")
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function

    Public Function ERP_StrategicPlan_GetProcessAxcesByID(ByVal ID_Objetive As Long) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_StrategicPlan_GetProcessAxcesByID", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@ID_Objetive", SqlDbType.BigInt).Value = ID_Objetive
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return ds.Tables("datos")
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.Message, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return New DataTable("datos")
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function

    Public Function ERP_StrategicPlan_InserProcess(ByVal ID_Objective As Long, ByVal IdDepartamento As Integer, ByVal Quinquenio As Integer) As Integer
        Dim resp As Integer = 0
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_StrategicPlan_InserProcess", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@ID_Objective", SqlDbType.BigInt).Value = ID_Objective
                cmd.Parameters.Add("@ID_Departamento", SqlDbType.BigInt).Value = IdDepartamento
                cmd.Parameters.Add("@Quinquenio", SqlDbType.Int).Value = Quinquenio
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try

                            da.Fill(ds, "datos")
                            resp = ds.Tables("datos").Rows(0)(0).ToString()
                            Return resp

                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.Message, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return 0
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function

    Public Function ERP_StrategicPlan_InserProcessAxes(ByVal ID_Process As Long, ByVal ID_Eje As Long, ByVal Percentage As Decimal) As Integer
        Dim resp As Integer = 0
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_StrategicPlan_InserProcessAxes", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@ID_Process", SqlDbType.BigInt).Value = ID_Process
                cmd.Parameters.Add("@ID_Eje", SqlDbType.BigInt).Value = ID_Eje
                cmd.Parameters.Add("@Percentage", SqlDbType.Decimal).Value = Percentage
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            resp = ds.Tables("datos").Rows(0)(0).ToString()
                            Return resp

                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.Message, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return 0
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function

    Public Function ERP_StrategicPlan_InserProcessResult(ByVal ID_ProcessAxes As Long, ByVal ID_Result As Long, ByVal Percentage As Decimal, ByVal ID_Process As Long) As Integer
        Dim resp As Integer = 0
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_StrategicPlan_InserProcessResult", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@ID_ProcessAxes", SqlDbType.BigInt).Value = ID_ProcessAxes
                cmd.Parameters.Add("@ID_Result", SqlDbType.BigInt).Value = ID_Result
                cmd.Parameters.Add("@Percentage", SqlDbType.Decimal).Value = Percentage
                cmd.Parameters.Add("@ID_Process", SqlDbType.BigInt).Value = ID_Process
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            resp = ds.Tables("datos").Rows(0)(0).ToString()
                            Return resp

                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.Message, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return 0
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function

    Public Function ERP_StrategicPlan_InserProcessIndicator(ByVal ID_ProcessResult As Long, ByVal ID_Indicator As Long,
                                                            ByVal Percentage As Decimal, ByVal ID_Process As Long, ByVal Id_Result As Integer) As Integer
        Dim resp As Integer = 0
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_StrategicPlan_InserProcessIndicator", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@ID_ProcessResult", SqlDbType.BigInt).Value = ID_ProcessResult
                cmd.Parameters.Add("@ID_Indicator", SqlDbType.BigInt).Value = ID_Indicator
                cmd.Parameters.Add("@Percentage", SqlDbType.Decimal).Value = Percentage
                cmd.Parameters.Add("@ID_Process", SqlDbType.BigInt).Value = ID_Process
                cmd.Parameters.Add("@Id_Result", SqlDbType.BigInt).Value = Id_Result
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            resp = ds.Tables("datos").Rows(0)(0).ToString()
                            Return resp

                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.Message, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return 0
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function

    Public Function ERP_StrategicPlan_SearchIndicatortByIdResult(ByVal ID_Result As Long, ByVal bandera As Long, ByVal idResultAdd As Long) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_StrategicPlan_SearchIndicatortByIdResult", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@idcompany", SqlDbType.BigInt).Value = Data_Id_Company
                cmd.Parameters.Add("@ID_Result", SqlDbType.VarChar).Value = ID_Result
                cmd.Parameters.Add("@bandera", SqlDbType.VarChar).Value = bandera
                cmd.Parameters.Add("@idResultAdd", SqlDbType.BigInt).Value = idResultAdd

                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return ds.Tables("datos")
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.Message, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return New DataTable("datos")
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function

    Public Function ERP_StrategicPlan_SearchResultByIdAxes(ByVal idstrategicAxes As Long, ByVal bandera As Long, ByVal idEjeadd As Long) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_StrategicPlan_SearchResultByIdAxes", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@idcompany", SqlDbType.BigInt).Value = Data_Id_Company
                cmd.Parameters.Add("@idstrategicAxes", SqlDbType.BigInt).Value = idstrategicAxes

                cmd.Parameters.Add("@idEjeadd", SqlDbType.BigInt).Value = idEjeadd
                If idstrategicAxes = 0 Then
                    cmd.Parameters.Add("@bandera", SqlDbType.BigInt).Value = 0
                Else
                    cmd.Parameters.Add("@bandera", SqlDbType.BigInt).Value = bandera
                End If
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return ds.Tables("datos")
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.Message, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return New DataTable("datos")
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function

    Public Function EERP_StrategicPlan_DeleteProcess(ByVal ID_Process As Long) As String
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_StrategicPlan_DeleteProcess", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@ID_Process", SqlDbType.BigInt).Value = ID_Process
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return "OK"
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.Message, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "ERROR"
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function


    Public Function ERP_StrategicGetReporPei(ByVal Id_Objetivo As Long, ByVal IdDpto As Integer) As DataSet
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_StrategicPlan_ReportePei", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@IdObjetivo", SqlDbType.BigInt).Value = Id_Objetivo
                cmd.Parameters.Add("@IdDpto", SqlDbType.BigInt).Value = IdDpto
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return ds
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.Message, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return Nothing
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function

#End Region

#Region "POA"

    Public Function ERP_StrategicPlan_getPOAInfo(ByVal IdGerencia As Integer) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_StrategicPlan_GetPOAInfo", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@IdGerencia", SqlDbType.BigInt).Value = IdGerencia
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return ds.Tables("datos")
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.Message, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return New DataTable("datos")
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function

    Public Function ERP_StrategicPlan_ProcessEjecucion(ByVal IdMes As Integer, ByVal Id_Accion As Integer, ByVal Porcentaje As Double,
                                                       ByVal Ruta As String, ByVal Anio As Integer, ByVal NombreArchivo As String,
                                                       ByVal Observaciones As String, ByVal TipoAccion As Integer) As Integer
        Dim NuevaRuta As String = ""
        Dim folderExists As Boolean
        _RutaArchivosRespaldo = _RutaArchivosRespaldoOri & "DocumentosPOASeguimiento"

        folderExists = My.Computer.FileSystem.DirectoryExists(_RutaArchivosRespaldo)
        If Not folderExists Then
            My.Computer.FileSystem.CreateDirectory(_RutaArchivosRespaldo)
        End If

        folderExists = My.Computer.FileSystem.DirectoryExists(_RutaArchivosRespaldo & "/" & Anio)
        If Not folderExists Then
            My.Computer.FileSystem.CreateDirectory(_RutaArchivosRespaldo & "/" & Anio)
        End If

        folderExists = My.Computer.FileSystem.DirectoryExists(_RutaArchivosRespaldo & "/" & Anio & "/" & IdMes)
        If Not folderExists Then
            My.Computer.FileSystem.CreateDirectory(_RutaArchivosRespaldo & "/" & Anio & "/" & IdMes)
        End If

        NuevaRuta = _RutaArchivosRespaldo & "/" & Anio & "/" & IdMes & "/" & Date.Now.Date.ToString("yyyyMM") & "_" & (IdMes + 1).ToString & "_" & Id_Accion & "_" & NombreArchivo

        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_StrategicPlan_ProcessEjecucionAcciones", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@IdDepartment", SqlDbType.BigInt).Value = _Id_DptoPlani
                cmd.Parameters.Add("@IdAccion", SqlDbType.BigInt).Value = Id_Accion
                cmd.Parameters.Add("@Anio", SqlDbType.BigInt).Value = Anio
                cmd.Parameters.Add("@Mes", SqlDbType.SmallInt).Value = IdMes
                cmd.Parameters.Add("@Porcentaje", SqlDbType.Decimal).Value = Porcentaje
                cmd.Parameters.Add("@Ruta", SqlDbType.VarChar).Value = NuevaRuta
                cmd.Parameters.Add("@NombreArchivo", SqlDbType.VarChar).Value = NombreArchivo
                cmd.Parameters.Add("@ObservacionEje", SqlDbType.VarChar).Value = Observaciones
                cmd.Parameters.Add("@TipoAccion", SqlDbType.SmallInt).Value = TipoAccion


                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")

                            CopiarArchivos(Ruta, NuevaRuta)

                            Return ds.Tables("datos").Rows(0).Item("resp")
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.Message, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return 0
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function



    Public Function ERP_StrategicPlan_ProcessArchivosPOAPEI(ByVal Id_Encabezado As Integer, ByVal Ruta As String, ByVal NombreArchivo As String, ByVal Observaciones As String, ByVal TipoArchivo As String, ByVal Anio As Integer) As Integer

        Dim NuevaRuta As String = ""
        Dim folderExists As Boolean

        If Anio = 0 Then
            Anio = Convert.ToInt16(Date.Now.Date.ToString("yyyy").ToString)
        End If

        _RutaArchivosRespaldo = _RutaArchivosRespaldoOri
        If TipoArchivo = "PEI" Then
            _RutaArchivosRespaldo = _RutaArchivosRespaldo & "DocumentosPEI"
            folderExists = My.Computer.FileSystem.DirectoryExists(_RutaArchivosRespaldo)
        ElseIf TipoArchivo = "MAPA" Then
            _RutaArchivosRespaldo = _RutaArchivosRespaldo & "DocumentosMAPA"
            folderExists = My.Computer.FileSystem.DirectoryExists(_RutaArchivosRespaldo)
        Else
            _RutaArchivosRespaldo = _RutaArchivosRespaldo & "DocumentosPOA"
            folderExists = My.Computer.FileSystem.DirectoryExists(_RutaArchivosRespaldo)
        End If

        If Not folderExists Then
            My.Computer.FileSystem.CreateDirectory(_RutaArchivosRespaldo)
        End If

        folderExists = My.Computer.FileSystem.DirectoryExists(_RutaArchivosRespaldo & "/" & Anio & Date.Now.Date.ToString("MM"))
        If Not folderExists Then
            My.Computer.FileSystem.CreateDirectory(_RutaArchivosRespaldo & "/" & Anio & Date.Now.Date.ToString("MM"))
        End If

        NuevaRuta = _RutaArchivosRespaldo & "/" & Anio & Date.Now.Date.ToString("MM") & "/" & Date.Now.Date.ToString("yyyyMM") & "_" & Id_Encabezado & "_" & NombreArchivo

        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_StrategicPlan_ProcessRespaldoPEIPOA", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_Encabezado", SqlDbType.BigInt).Value = Id_Encabezado
                cmd.Parameters.Add("@Ruta", SqlDbType.VarChar).Value = NuevaRuta
                cmd.Parameters.Add("@NombreArchivo", SqlDbType.VarChar).Value = NombreArchivo
                cmd.Parameters.Add("@Observacion", SqlDbType.VarChar).Value = Observaciones
                cmd.Parameters.Add("@TipoArchivo", SqlDbType.VarChar).Value = TipoArchivo


                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            CopiarArchivos(Ruta, NuevaRuta)
                            Return ds.Tables("datos").Rows(0).Item("resp")
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.Message, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return 0
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function

    Private Sub CopiarArchivos(ByVal Ruta As String, ByVal NuevaRuta As String)
        Try
            My.Computer.FileSystem.CopyFile(Ruta, NuevaRuta)
        Catch ex As Exception
            process.AlmacenarLog(1, ex.Message, System.Reflection.MethodBase.GetCurrentMethod().Name)
        End Try
    End Sub


    Public Function ERP_StrategicPlan_ProcessPOA(ByVal IdEncabezado As Integer, ByVal Id_Departamento As Integer, ByVal Id_Accion As Integer, ByVal Id_Objetivo As Integer, ByVal Anio As Integer,
                                                 ByVal Enero As Double, ByVal Febrero As Double, ByVal Marzo As Double, ByVal Abril As Double, ByVal Mayo As Double, ByVal Junio As Double,
                                                 ByVal Julio As Double, ByVal Agosto As Double, ByVal Septiembre As Double, ByVal Octubre As Double, ByVal Noviembre As Double, ByVal Diciembre As Double,
                                                 ByVal TipoMedicion As Integer, ByVal Recursos As Double, ByVal MetaDiciembre As Double, ByVal TipoAccion As Integer, ByVal Indicador As String) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_StrategicPlan_ProcessPOA", conn)

                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@IdDeparment", SqlDbType.BigInt).Value = Id_Departamento
                cmd.Parameters.Add("@Id_Encabezado", SqlDbType.BigInt).Value = IdEncabezado
                cmd.Parameters.Add("@Id_Accion", SqlDbType.BigInt).Value = Id_Accion
                cmd.Parameters.Add("@Id_Objetivo", SqlDbType.BigInt).Value = Id_Objetivo
                cmd.Parameters.Add("@Anio", SqlDbType.BigInt).Value = Anio
                cmd.Parameters.Add("@Enero", SqlDbType.Decimal).Value = Enero
                cmd.Parameters.Add("@Febrero", SqlDbType.Decimal).Value = Febrero
                cmd.Parameters.Add("@Marzo", SqlDbType.Decimal).Value = Marzo
                cmd.Parameters.Add("@Abril", SqlDbType.Decimal).Value = Abril
                cmd.Parameters.Add("@Mayo", SqlDbType.Decimal).Value = Mayo
                cmd.Parameters.Add("@Junio", SqlDbType.Decimal).Value = Junio
                cmd.Parameters.Add("@Julio", SqlDbType.Decimal).Value = Julio
                cmd.Parameters.Add("@Agosto", SqlDbType.Decimal).Value = Agosto
                cmd.Parameters.Add("@Septiembre", SqlDbType.Decimal).Value = Septiembre
                cmd.Parameters.Add("@Octubre", SqlDbType.Decimal).Value = Octubre
                cmd.Parameters.Add("@Noviembre", SqlDbType.Decimal).Value = Noviembre
                cmd.Parameters.Add("@Diciembre", SqlDbType.Decimal).Value = Diciembre
                cmd.Parameters.Add("@TipoMedicion", SqlDbType.Int).Value = TipoMedicion
                cmd.Parameters.Add("@Recursos", SqlDbType.Decimal).Value = Recursos
                cmd.Parameters.Add("@MetaDiciembre", SqlDbType.Decimal).Value = MetaDiciembre
                cmd.Parameters.Add("@TipoAccionEstr_Apo", SqlDbType.Int).Value = TipoAccion
                cmd.Parameters.Add("@Indicador", SqlDbType.VarChar).Value = Indicador

                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return ds.Tables("datos")
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.Message, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return New DataTable("datos")
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function

    Public Function ERP_StrategicPlan_ProcessPOAEncabezado(ByVal Id_Departamento As Integer, ByVal Anio As Integer,
                                                 ByVal Fecha As Date, ByVal IdResponsable As Integer, ByVal IdJefe As Integer,
                                                           ByVal Objetivo As String) As Integer
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_StrategicPlan_ProcessPOAEncabezado", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@IdDeparment", SqlDbType.Int).Value = Id_Departamento
                cmd.Parameters.Add("@Anio", SqlDbType.Int).Value = Anio
                cmd.Parameters.Add("@Fecha", SqlDbType.Date).Value = Fecha
                cmd.Parameters.Add("@IdResponsable", SqlDbType.Int).Value = IdResponsable
                cmd.Parameters.Add("@IdJefe", SqlDbType.Int).Value = IdJefe
                cmd.Parameters.Add("@Objetivo", SqlDbType.VarChar).Value = Objetivo

                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return ds.Tables("datos").Rows(0).Item("resp")
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.Message, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return 0
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function

    Public Function ERP_StrategicGetReporPOA(ByVal Id_Departamento As Long, ByVal Anio As Integer, ByVal IdEncabezado As Integer) As DataSet
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_StrategicPlan_GetPOAInfoReport", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@IdGerencia", SqlDbType.BigInt).Value = Id_Departamento
                cmd.Parameters.Add("@Anio", SqlDbType.BigInt).Value = Anio
                cmd.Parameters.Add("@IdEncabezado", SqlDbType.BigInt).Value = IdEncabezado
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return ds
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.Message, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return Nothing
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function

    Public Function ERP_StrategicGetReporPOAEjecucion(ByVal Id_Departamento As Long, ByVal Anio As Integer, ByVal IdEncabezado As Integer, ByVal IdMesReportado As Integer) As DataSet
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_StrategicPlan_GetPOAInfoEjecucionReport", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@IdGerencia", SqlDbType.BigInt).Value = Id_Departamento
                cmd.Parameters.Add("@Anio", SqlDbType.BigInt).Value = Anio
                cmd.Parameters.Add("@IdEncabezado", SqlDbType.BigInt).Value = IdEncabezado
                cmd.Parameters.Add("@IdMesReportado", SqlDbType.BigInt).Value = IdMesReportado
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return ds
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.Message, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return Nothing
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function

    Public Function ERP_StrategicPlan_GetAccionesArchivos(ByVal IdDepartment As Integer, ByVal IdAccion As Integer, ByVal Anio As Integer, ByVal Mes As Integer) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_StrategicPlan_GetProcessEjecucionArchivos", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@IdDepartment", SqlDbType.BigInt).Value = IdDepartment
                cmd.Parameters.Add("@IdAccion", SqlDbType.BigInt).Value = IdAccion
                cmd.Parameters.Add("@Anio", SqlDbType.BigInt).Value = Anio
                cmd.Parameters.Add("@Mes", SqlDbType.BigInt).Value = Mes

                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return ds.Tables("datos")
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.Message, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return New DataTable("datos")
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function

    Public Function ERP_StrategicPlan_GetDocumentRespaldoPEIPOA(ByVal Id_Encabezado As Integer, ByVal TipoSP As String, ByVal Anio As Integer) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_StrategicPlan_GetRespaldoPEIPOA", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_Encabezado", SqlDbType.BigInt).Value = Id_Encabezado
                cmd.Parameters.Add("@TipoSP", SqlDbType.VarChar).Value = TipoSP
                cmd.Parameters.Add("@Anio", SqlDbType.BigInt).Value = Anio

                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return ds.Tables("datos")
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.Message, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return New DataTable("datos")
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function

    Public Function ERP_StrategicPlan_ProcessAproRecha(ByVal IdDepartment As Integer, ByVal Id_EncabezadoPOA As Integer, ByVal Observaciones As String, ByVal Tipo As Integer) As String
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_StrategicPlan_ProcessAprobarRechazar", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@IdDepartment", SqlDbType.BigInt).Value = IdDepartment
                cmd.Parameters.Add("@Id_EncabezadoPOA", SqlDbType.BigInt).Value = Id_EncabezadoPOA
                cmd.Parameters.Add("@Observacion", SqlDbType.VarChar).Value = Observaciones
                cmd.Parameters.Add("@Tipo", SqlDbType.BigInt).Value = Tipo

                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")

                            Dim EnvioCorreo As New SendEmail
                            Try
                                If ds.Tables.Count > 0 Then
                                    If ds.Tables("datos").Rows.Count > 0 Then
                                        For Each DataInfo As DataRow In ds.Tables("datos").Rows
                                            EnvioCorreo.SendEmail(DataInfo("email"), DataInfo("Subject"), DataInfo("Body"), Id_EncabezadoPOA)
                                        Next
                                    End If
                                End If
                            Catch ex As Exception

                            End Try

                            Return "OK"
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.Message, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "Error"
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function



    Public Function ERP_StrategicPlan_ProcessAproRechaPEI(ByVal IdDepartment As Integer, ByVal Id_PEI As Integer, ByVal Observaciones As String, ByVal Tipo As Integer) As String
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_StrategicPlan_ProcessAprobarRechazarPEI", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@IdDepartment", SqlDbType.BigInt).Value = IdDepartment
                cmd.Parameters.Add("@Id_PEI", SqlDbType.BigInt).Value = Id_PEI
                cmd.Parameters.Add("@Observacion", SqlDbType.VarChar).Value = Observaciones
                cmd.Parameters.Add("@Tipo", SqlDbType.BigInt).Value = Tipo

                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")

                            Dim EnvioCorreo As New SendEmail
                            Try
                                If ds.Tables.Count > 0 Then
                                    If ds.Tables("datos").Rows.Count > 0 Then
                                        For Each DataInfo As DataRow In ds.Tables("datos").Rows
                                            EnvioCorreo.SendEmail(DataInfo("email"), DataInfo("Subject"), DataInfo("Body"), Id_PEI)
                                        Next
                                    End If
                                End If
                            Catch ex As Exception

                            End Try

                            Return "OK"
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.Message, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "Error"
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function


    Public Function ERP_StrategicPlan_ProcessAproRechaSeguimientoPOA(ByVal Id_Encabezado As Integer, ByVal Id_Seguimiento As Integer, ByVal Id_Mes As Integer, ByVal Observaciones As String, ByVal Tipo As Integer) As String
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_StrategicPlan_ProcessAprobarRechazarSeguimientoPOA", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_Seguimiento", SqlDbType.BigInt).Value = Id_Seguimiento
                cmd.Parameters.Add("@Id_EncabezadoPOA", SqlDbType.BigInt).Value = Id_Encabezado
                cmd.Parameters.Add("@Id_Mes", SqlDbType.BigInt).Value = Id_Mes
                cmd.Parameters.Add("@Observacion", SqlDbType.VarChar).Value = Observaciones
                cmd.Parameters.Add("@Tipo", SqlDbType.BigInt).Value = Tipo

                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return "OK"
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.Message, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "Error"
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function

#End Region
    Public Function ERP_StrategicPlan_getMeses() As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("SP_GETMESES", conn)
                cmd.CommandType = CommandType.StoredProcedure
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return ds.Tables("datos")
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.Message, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return New DataTable("datos")
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function

    Public Function ERP_StrategicPlan_getYearPOA(ByVal Id_Department As Integer) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_StrategicPlan_GETAniosPOA", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@IdDepartment", Id_Department)
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return ds.Tables("datos")
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.Message, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return New DataTable("datos")
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function


    Public Function ERP_StrategicPlan_getAniosMapa(ByVal Id_Department As Integer) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_StrategicPlan_GETAniosMapa", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@IdDepartment", Id_Department)
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return ds.Tables("datos")
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.Message, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return New DataTable("datos")
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function

    Public Function ERP_StrategicPlan_getYear(ByVal Id_Department As Integer) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("SP_GETAnios", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@IdDepartment", Id_Department)
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return ds.Tables("datos")
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.Message, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return New DataTable("datos")
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function



    Public Function ERP_StrategicPlan_getDocumentosEjecucion(ByVal Id_Department As Integer, ByVal Id_Mes As Integer, ByVal Anio As Integer) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("SP_GETDocumentosEjecucion", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@IdDepartment", Id_Department)
                cmd.Parameters.AddWithValue("@IdMes", Id_Mes)
                cmd.Parameters.AddWithValue("@Anio", Anio)
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return ds.Tables("datos")
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.Message, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return New DataTable("datos")
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function


    Public Function ERP_StrategicPlan_getReportIndicador(ByVal Id_Departamento As Integer, ByVal Id_Encabezado As Integer, ByVal Anio As Integer, ByVal Tipo As Integer) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Dim SP As String = ""
            If Tipo = 1 Then
                SP = "ERP_StrategicPlan_GetPOAIndicadores"
            ElseIf Tipo = 2 Then
                SP = "ERP_StrategicPlan_GetPOAIndicadoresCombinado"
            ElseIf Tipo = 3 Then
                SP = "ERP_StrategicPlan_GetPOAIndicadoresGeneral"
                Anio = 0
                Id_Departamento = 0
            Else
                SP = "ERP_StrategicPlan_GetPOAIndicadoresCombinadoGeneral"
                Anio = 0
                Id_Departamento = 0
            End If
            Using cmd As New SqlCommand(SP, conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@IdGerencia", SqlDbType.BigInt).Value = Id_Departamento
                cmd.Parameters.Add("@Anio", SqlDbType.BigInt).Value = Anio
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return ds.Tables("datos")
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.Message, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return New DataTable("datos")
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function


#Region "Acciones no programadas"

    Public Function ERP_StrategicPlan_GetProgrammedAction(ByVal Id_Departamento As Integer) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_StrategicPlan_GetProgrammedAction", conn)
                cmd.Parameters.Add("@Id_Department", SqlDbType.BigInt).Value = Id_Departamento
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@idcompany", SqlDbType.BigInt).Value = Data_Id_Company
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return ds.Tables("datos")
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.Message, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return New DataTable("datos")
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function

    Public Function ERP_StrategicPlan_InsertProgrammedAction(ByVal Id_Departamento As Integer, ByVal DevelopmentActions As String, ByVal StartMonth As Integer, ByVal FinishDate As Date, ByVal budget As Double, ByVal ID_Freeunit_FK As Long, ByVal Administrator As String) As String
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_StrategicPlan_InsertProgrammedAction", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@idcompany", SqlDbType.BigInt).Value = Data_Id_Company
                cmd.Parameters.Add("@Id_Department", SqlDbType.BigInt).Value = Id_Departamento
                cmd.Parameters.Add("@DevelopmentActions", SqlDbType.VarChar).Value = DevelopmentActions
                cmd.Parameters.Add("@StartMonth", SqlDbType.Int).Value = StartMonth
                cmd.Parameters.Add("@FinishDate", SqlDbType.Date).Value = FinishDate
                cmd.Parameters.Add("@budget", SqlDbType.Money).Value = budget
                cmd.Parameters.Add("@ID_Freeunit_FK", SqlDbType.BigInt).Value = ID_Freeunit_FK
                cmd.Parameters.Add("@Administrator", SqlDbType.VarChar).Value = Administrator
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return "OK"
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.Message, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "ERROR"
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function

    Public Function ERP_StrategicPlan_UpdateProgrammedAction(ByVal Id_Departamento As Integer, ByVal ID_ProgrammedAction As Long, ByVal DevelopmentActions As String, ByVal StartMonth As Integer, ByVal FinishDate As Date, ByVal budget As Double, ByVal ID_Freeunit_FK As Long, ByVal Administrator As String) As String
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_StrategicPlan_UpdateProgrammedAction", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@idcompany", SqlDbType.BigInt).Value = Data_Id_Company
                cmd.Parameters.Add("@Id_Department", SqlDbType.BigInt).Value = Id_Departamento
                cmd.Parameters.Add("@DevelopmentActions", SqlDbType.VarChar).Value = DevelopmentActions
                cmd.Parameters.Add("@StartMonth", SqlDbType.Int).Value = StartMonth
                cmd.Parameters.Add("@FinishDate", SqlDbType.Date).Value = FinishDate
                cmd.Parameters.Add("@budget", SqlDbType.Money).Value = budget
                cmd.Parameters.Add("@ID_Freeunit_FK", SqlDbType.BigInt).Value = ID_Freeunit_FK
                cmd.Parameters.Add("@Administrator", SqlDbType.VarChar).Value = Administrator
                cmd.Parameters.Add("@ID_ProgrammedAction", SqlDbType.VarChar).Value = ID_ProgrammedAction
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return "OK"
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.Message, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "ERROR"
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function

    Public Function EERP_StrategicPlan_DeleteProgrammedAction(ByVal ID_ProgrammedAction As Long) As String
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_StrategicPlan_DeleteProgrammedAction", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@IdCompany", SqlDbType.BigInt).Value = Data_Id_Company
                cmd.Parameters.Add("@ID_ProgrammedAction", SqlDbType.BigInt).Value = ID_ProgrammedAction
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return "OK"
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.Message, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "ERROR"
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function
#End Region

#Region "Probabilidad de ocurencia"

    Public Function ERP_StrategicPlan_GetProbabilityOccurrence() As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_StrategicPlan_GetProbabilityOccurrence", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@idcompany", SqlDbType.BigInt).Value = Data_Id_Company
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return ds.Tables("datos")
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.Message, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return New DataTable("datos")
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function

    Public Function ERP_StrategicPlan_GetProbabilityOccurrenceMap() As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_StrategicPlan_GetProbabilityOccurrenceMap", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@idcompany", SqlDbType.BigInt).Value = Data_Id_Company
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return ds.Tables("datos")
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.Message, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return New DataTable("datos")
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function

    Public Function ERP_StrategicPlan_InsertProbabilityOccurrence(ByVal Probability As Integer, ByVal description As String) As String
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_StrategicPlan_InsertProbabilityOccurrence", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@idcompany", SqlDbType.BigInt).Value = Data_Id_Company
                cmd.Parameters.Add("@Probability", SqlDbType.Int).Value = Probability
                cmd.Parameters.Add("@Description", SqlDbType.VarChar).Value = description
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return "OK"
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.Message, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "ERROR"
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function

    Public Function ERP_StrategicPlan_UpdateProbabilityOccurrence(ByVal ID_ProbabilityOccurrence As Long, ByVal Probability As Integer, ByVal description As String) As String
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_StrategicPlan_UpdateProbabilityOccurrence", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@IdCompany", SqlDbType.BigInt).Value = Data_Id_Company
                cmd.Parameters.Add("@ID_ProbabilityOccurrence", SqlDbType.BigInt).Value = ID_ProbabilityOccurrence
                cmd.Parameters.Add("@Probability", SqlDbType.Int).Value = Probability
                cmd.Parameters.Add("@Description", SqlDbType.VarChar).Value = description
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return "OK"
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.Message, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "ERROR"
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function

    Public Function EERP_StrategicPlan_DeleteProbabilityOccurrence(ByVal ID_ProbabilityOccurrence As Long) As String
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_StrategicPlan_DeleteProbabilityOccurrence", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@IdCompany", SqlDbType.BigInt).Value = Data_Id_Company
                cmd.Parameters.Add("@ID_ProbabilityOccurrence", SqlDbType.BigInt).Value = ID_ProbabilityOccurrence
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return "OK"
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.Message, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "ERROR"
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function
#End Region

#Region "Grado de Impacto"

    Public Function ERP_StrategicPlan_GetImpactGrade() As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_StrategicPlan_GetImpactGrade", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@idcompany", SqlDbType.BigInt).Value = Data_Id_Company
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return ds.Tables("datos")
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.Message, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return New DataTable("datos")
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function

    Public Function ERP_StrategicPlan_GetImpactGradeMap() As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_StrategicPlan_GetImpactGradeMap", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@idcompany", SqlDbType.BigInt).Value = Data_Id_Company
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return ds.Tables("datos")
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.Message, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return New DataTable("datos")
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function

    Public Function ERP_StrategicPlan_InsertImpactGrade(ByVal Probability As Integer, ByVal description As String) As String
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_StrategicPlan_InsertImpactGrade", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@idcompany", SqlDbType.BigInt).Value = Data_Id_Company
                cmd.Parameters.Add("@Probability", SqlDbType.Int).Value = Probability
                cmd.Parameters.Add("@Description", SqlDbType.VarChar).Value = description
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return "OK"
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.Message, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "ERROR"
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function

    Public Function ERP_StrategicPlan_UpdateImpactGrade(ByVal ID_ImpactGrade As Long, ByVal Probability As Integer, ByVal description As String) As String
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_StrategicPlan_UpdateImpactGrade", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@IdCompany", SqlDbType.BigInt).Value = Data_Id_Company
                cmd.Parameters.Add("@ID_ImpactGrade", SqlDbType.BigInt).Value = ID_ImpactGrade
                cmd.Parameters.Add("@Probability", SqlDbType.VarChar).Value = Probability
                cmd.Parameters.Add("@Description", SqlDbType.VarChar).Value = description
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return "OK"
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.Message, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "ERROR"
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function

    Public Function EERP_StrategicPlan_DeleteImpactGrade(ByVal ID_ImpactGrade As Long) As String
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_StrategicPlan_DeleteImpactGrade", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@IdCompany", SqlDbType.BigInt).Value = Data_Id_Company
                cmd.Parameters.Add("@ID_ImpactGrade", SqlDbType.BigInt).Value = ID_ImpactGrade
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return "OK"
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.Message, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "ERROR"
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function
#End Region

#Region "Mapa de Riesgo"

    Public Function ERP_StrategicPlan_GetMapRiesgo(ByVal Id_Departamento As Integer) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_StrategicPlan_GetMapRiesgo", conn)
                cmd.CommandType = CommandType.StoredProcedure
                If Id_Departamento > 0 Then
                    cmd.Parameters.Add("@Id_departamento", SqlDbType.BigInt).Value = Id_Departamento
                Else
                    cmd.Parameters.Add("@Id_departamento", SqlDbType.BigInt).Value = _Id_DptoPlani
                End If
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return ds.Tables("datos")
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.Message, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return New DataTable("datos")
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function

    Public Function ERP_StrategicPlan_GetMapRiesgoOperaciones(ByVal Id_RiskMap As Integer) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_StrategicPlan_GetMapRiesgoOperaciones", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_RiskMap", SqlDbType.BigInt).Value = Id_RiskMap
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return ds.Tables("datos")
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.Message, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return New DataTable("datos")
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function

    Public Function ERP_StrategicPlan_GetMapRiesgoAcciones(ByVal Id_RiskMap As Integer) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_StrategicPlan_GetMapRiesgoAcciones", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_RiskMap", SqlDbType.BigInt).Value = Id_RiskMap
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return ds.Tables("datos")
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.Message, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return New DataTable("datos")
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function

    Public Function ERP_StrategicPlan_GetMapRiesgoReport(ByVal Id_RiskMap As Integer) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_StrategicPlan_GetMapRiesgoReport", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_RiskMap", SqlDbType.BigInt).Value = Id_RiskMap
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return ds.Tables("datos")
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.Message, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return New DataTable("datos")
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function

    Public Function ERP_StrategicPlan_InsertMapRiesgo(ByVal Proceso As String, ByVal Objetivo As String, ByVal DescripcionRiesgo As String, ByVal Probabilidad As Integer,
                                                      ByVal Grado As Integer, ByVal Equipo As String, ByVal Seguimiento As String, ByVal Indicador As String,
                                                      ByVal Responsable As Integer, ByVal ResposanbleAuto As Integer) As String
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_StrategicPlan_InsertMapRiesgo", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@idcompany", SqlDbType.BigInt).Value = Data_Id_Company
                cmd.Parameters.Add("@Id_Departamento", SqlDbType.Int).Value = _Id_DepartmentGlobal
                cmd.Parameters.Add("@Proceso", SqlDbType.VarChar).Value = Proceso
                cmd.Parameters.Add("@Objetivo", SqlDbType.VarChar).Value = Objetivo
                cmd.Parameters.Add("@DescripcionRiesgo", SqlDbType.VarChar).Value = DescripcionRiesgo
                cmd.Parameters.Add("@Probabilidad", SqlDbType.Int).Value = Probabilidad
                cmd.Parameters.Add("@Grado", SqlDbType.Int).Value = Grado
                cmd.Parameters.Add("@Equipo", SqlDbType.VarChar).Value = Equipo
                cmd.Parameters.Add("@Seguimiento", SqlDbType.VarChar).Value = Seguimiento
                cmd.Parameters.Add("@Indicador", SqlDbType.VarChar).Value = Indicador
                cmd.Parameters.Add("@IdResponsable", SqlDbType.SmallInt).Value = Responsable
                cmd.Parameters.Add("@IdResponsableAutoriza", SqlDbType.SmallInt).Value = ResposanbleAuto
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return ds.Tables(0).Rows(0).Item("resp")
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.Message, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "ERROR"
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function

    Public Function ERP_StrategicPlan_UpdateMapRiesgoEvaluacion(ByVal IdMapRisk As Integer, ByVal Probabilidad As Integer, ByVal Grado As Integer, ByVal IdResponsableEvaluacion As Integer, ByVal IdResponsableAutorizacionEval As Integer) As String
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_StrategicPlan_UpdateMapRiesgoEvaluacion", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@IdMapRisk", SqlDbType.Int).Value = IdMapRisk
                cmd.Parameters.Add("@Id_Department", SqlDbType.Int).Value = _Id_DptoPlani
                cmd.Parameters.Add("@Probabilidad", SqlDbType.Int).Value = Probabilidad
                cmd.Parameters.Add("@Grado", SqlDbType.Int).Value = Grado
                cmd.Parameters.Add("@IdResponsableEvaluacion", SqlDbType.Int).Value = IdResponsableEvaluacion
                cmd.Parameters.Add("@IdResponsableAutorizacionEval", SqlDbType.Int).Value = IdResponsableAutorizacionEval
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return ds.Tables(0).Rows(0).Item("resp")
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.Message, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "ERROR"
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function

    Public Function ERP_StrategicPlan_InsertMapRiesgoOpciones(ByVal Id_RiskMap As Integer, ByVal OpcionManejo As String, ByVal Contador As Integer) As String
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_StrategicPlan_InsertMapRiesgoOpciones", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@idcompany", SqlDbType.BigInt).Value = Data_Id_Company
                cmd.Parameters.Add("@Id_RiskMap", SqlDbType.Int).Value = Id_RiskMap
                cmd.Parameters.Add("@OpcionManejo", SqlDbType.VarChar).Value = OpcionManejo
                cmd.Parameters.Add("@Contador", SqlDbType.Int).Value = Contador
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return "OK"
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.Message, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "ERROR"
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function

    Public Function ERP_StrategicPlan_InsertMapRiesgoAcciones(ByVal Id_RiskMap As Integer, ByVal AccionManejo As String, ByVal Contador As Integer) As String
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_StrategicPlan_InsertMapRiesgoAcciones", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@idcompany", SqlDbType.BigInt).Value = Data_Id_Company
                cmd.Parameters.Add("@Id_RiskMap", SqlDbType.Int).Value = Id_RiskMap
                cmd.Parameters.Add("@AccionManejo", SqlDbType.VarChar).Value = AccionManejo
                cmd.Parameters.Add("@Contador", SqlDbType.Int).Value = Contador
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return "OK"
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.Message, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "ERROR"
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function


    Public Function ERP_StrategicPlan_InsertMapRiesgoAccionesEvaluacion(ByVal Id_RiskMap As Integer, ByVal ID_RiskMapAccion As Integer, ByVal Resultado As String, ByVal Observacion As String) As String
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_StrategicPlan_InsertMapRiesgoEvaluacion", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_RiskMap", SqlDbType.Int).Value = Id_RiskMap
                cmd.Parameters.Add("@ID_RiskMapAccion_FK", SqlDbType.BigInt).Value = ID_RiskMapAccion
                cmd.Parameters.Add("@Resultado", SqlDbType.VarChar).Value = Resultado
                cmd.Parameters.Add("@Observacion", SqlDbType.VarChar).Value = Observacion
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return "OK"
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.Message, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "ERROR"
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function

    Public Function ERP_StrategicPlan_UpdateMapRiesgo(ByVal ID_RiskMap As Integer, ByVal Proceso As String, ByVal Objetivo As String, ByVal DescripcionRiesgo As String, ByVal Probabilidad As Integer,
                                                      ByVal Grado As Integer, ByVal Equipo As String, ByVal Seguimiento As String, ByVal Indicador As String,
                                                      ByVal Responsable As Integer, ByVal ResposanbleAuto As Integer) As String
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_StrategicPlan_UpdateMapRiesgo", conn)
                cmd.CommandType = CommandType.StoredProcedure

                cmd.Parameters.Add("@ID_RiskMap", SqlDbType.BigInt).Value = ID_RiskMap
                cmd.Parameters.Add("@idcompany", SqlDbType.BigInt).Value = Data_Id_Company
                cmd.Parameters.Add("@Id_Departamento", SqlDbType.Int).Value = _Id_DptoPlani
                cmd.Parameters.Add("@Proceso", SqlDbType.VarChar).Value = Proceso
                cmd.Parameters.Add("@Objetivo", SqlDbType.VarChar).Value = Objetivo
                cmd.Parameters.Add("@DescripcionRiesgo", SqlDbType.VarChar).Value = DescripcionRiesgo
                cmd.Parameters.Add("@Probabilidad", SqlDbType.Int).Value = Probabilidad
                cmd.Parameters.Add("@Grado", SqlDbType.Int).Value = Grado
                cmd.Parameters.Add("@Equipo", SqlDbType.VarChar).Value = Equipo
                cmd.Parameters.Add("@Seguimiento", SqlDbType.VarChar).Value = Seguimiento
                cmd.Parameters.Add("@Indicador", SqlDbType.VarChar).Value = Indicador
                cmd.Parameters.Add("@IdResponsable", SqlDbType.SmallInt).Value = Responsable
                cmd.Parameters.Add("@IdResponsableAutoriza", SqlDbType.SmallInt).Value = ResposanbleAuto
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return ds.Tables(0).Rows(0).Item("resp").ToString
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.Message, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "ERROR"
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function


    Public Function ERP_StrategicPlan_GetResponsibleMapRisk(ByVal Id_departamento As Integer) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_StrategicPlan_GetResponsibleMapRisk", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@idcompany", SqlDbType.BigInt).Value = Data_Id_Company
                If Id_departamento > 0 Then
                    cmd.Parameters.Add("@Id_Departamento", SqlDbType.BigInt).Value = Id_departamento
                Else
                    cmd.Parameters.Add("@Id_Departamento", SqlDbType.BigInt).Value = _Id_DptoPlani
                End If
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return ds.Tables("datos")
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.Message, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return New DataTable("datos")
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function

    Public Function ERP_StrategicPlan_InserResponsibleMapRisk(ByVal ResponsibleExecution As String, ByVal description As String) As String
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_StrategicPlan_InserResponsibleMapRisk", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@idcompany", SqlDbType.BigInt).Value = Data_Id_Company
                cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = ResponsibleExecution
                cmd.Parameters.Add("@Description", SqlDbType.VarChar).Value = description
                cmd.Parameters.Add("@Id_Departamento", SqlDbType.VarChar).Value = _Id_DepartmentGlobal
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return "OK"
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.Message, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "ERROR"
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function

    Public Function ERP_StrategicPlan_UpdateResponsibleMapRisk(ByVal idresponsibleExecution As Long, ByVal name As String, ByVal description As String) As String
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_StrategicPlan_UpdateResponsibleMapRisk", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@IdCompany", SqlDbType.BigInt).Value = Data_Id_Company
                cmd.Parameters.Add("@idresponsibleExecution", SqlDbType.BigInt).Value = idresponsibleExecution
                cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = name
                cmd.Parameters.Add("@Description", SqlDbType.VarChar).Value = description
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return "OK"
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.Message, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "ERROR"
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function

    Public Function EERP_StrategicPlan_DeleteResponsibleMapRisk(ByVal idresponsibleExecution As Long) As String
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_StrategicPlan_DeleteResponsibleMapRisk", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@IdCompany", SqlDbType.BigInt).Value = Data_Id_Company
                cmd.Parameters.Add("@idresponsibleExecution", SqlDbType.BigInt).Value = idresponsibleExecution
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return "OK"
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.Message, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "ERROR"
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function



#End Region


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
