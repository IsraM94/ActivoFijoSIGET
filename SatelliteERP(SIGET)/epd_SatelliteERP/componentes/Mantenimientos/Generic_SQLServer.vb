Imports System.Data.SqlClient
Imports System.IO
Imports System.Net

Public Class Generic_SQLServer : Implements IDisposable
    Dim process As New ProcessGeneral
    Private connStr As String = DataCenter()
    Property Server As String
    Property BaseDeDatos As String

    Friend Function DataCenter() As String

        REM Dim a As String = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Epdsoft\SatelliteERP", "ConnectionStrings", "Error")
        Dim a As String = ""
        Try

            a = SQLConfiguration.EpdConnectionString.ToString
            Dim connectionString As System.Data.SqlClient.SqlConnectionStringBuilder = New System.Data.SqlClient.SqlConnectionStringBuilder(a)



            Server = connectionString.DataSource
            BaseDeDatos = connectionString.InitialCatalog
        Catch ex As Exception

        End Try



        Return a 'My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Epdsoft\SatelliteERP", "ConnectionStrings", "Error") REM trae el valor del regedit
    End Function
    Public Sub SaveLogException(ByVal Function_ As String, ByVal Exception As String)
        Dim ds As New DataSet("Err")
        Try
            Using da As New SqlDataAdapter("SP_ERP_SaveLogException", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@User", _User)
                da.SelectCommand.Parameters.AddWithValue("@Function", Function_)
                da.SelectCommand.Parameters.AddWithValue("@Computer", _Equipo)
                da.SelectCommand.Parameters.AddWithValue("@Exception", Exception)
                da.SelectCommand.Parameters.AddWithValue("@IpAddress", Dns.GetHostEntry(_Equipo).AddressList(0).ToString())
                da.Fill(ds, "LogErr")
            End Using
        Catch ex As SqlException
            My.Computer.FileSystem.WriteAllText(_Address & Path.DirectorySeparatorChar & "ERP.txt", "Fecha: [" & Date.Today & "] Hora: [" & Date.Today.ToString & "] [ERR]" & ex.Message.ToString & " Usuario: [" & _User & "]", True)
        Catch ex As Exception
            My.Computer.FileSystem.WriteAllText(_Address & Path.DirectorySeparatorChar & "ERP.txt", "Fecha: [" & Date.Today & "] [ERR]" & ex.Message.ToString & " Usuario: [" & _User & "]", True)
        End Try
    End Sub


    Public Function ERP_PROC_login(ByVal usuario As String) As DataSet
        Dim resp As Integer = 0
        connStr = DataCenter()
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_PROC_login", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@usuario", SqlDbType.VarChar).Value = usuario

                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return ds
                            'Return resp
                        Catch ex As SqlException
                            MessageBox.Show("Fallo en la conexión con la base de datos, comuniquese con soporte tecnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return Nothing
                        Catch ex As Exception
                            MessageBox.Show("Ocurrio un error al cargar la informacion.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(5, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return Nothing
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function
#Region "Taxes"
    Public Function GetTaxes(ByVal id_Company As Long) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_Generic_SP_GetTaxes", conn)
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
    Public Function SetTaxes(ByVal Id_Tax As Long, ByVal id_Company As Long, ByVal Id_CollectingAgency As Long, ByVal Name_Tax As String,
                                 ByVal Is_TaxParent As Boolean, ByVal Is_TaxLine As Boolean, ByVal Is_TaxProduct As Boolean, ByVal IsPercent As Boolean,
                                 ByVal Value As Decimal) As String
        Using conn As New SqlClient.SqlConnection(connStr)
            Dim resp As String = ""
            Using cmd As New SqlCommand("ERP_Generic_SP_SetTaxes", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_Tax", SqlDbType.BigInt).Value = Id_Tax
                cmd.Parameters.Add("@Id_Company_FK", SqlDbType.BigInt).Value = id_Company
                cmd.Parameters.Add("@Id_CollectingAgency_FK", SqlDbType.BigInt).Value = Id_CollectingAgency
                cmd.Parameters.Add("@Name_Tax", SqlDbType.VarChar).Value = Name_Tax
                cmd.Parameters.Add("@Is_TaxParent", SqlDbType.Bit).Value = Is_TaxParent
                cmd.Parameters.Add("@Is_TaxLine", SqlDbType.Bit).Value = Is_TaxLine
                cmd.Parameters.Add("@Is_TaxProduct", SqlDbType.Bit).Value = Is_TaxProduct
                cmd.Parameters.Add("@IsPercent", SqlDbType.Bit).Value = IsPercent
                cmd.Parameters.Add("@Value", SqlDbType.Decimal).Value = Value
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            resp = ds.Tables("datos").Rows(0)(0).ToString
                            Return resp
                        Catch ex As SqlException
                            MessageBox.Show("Fallo en la conexión con la base de datos, comuniquese con soporte tecnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "EX|" & ex.ToString

                        Catch ex As Exception
                            MessageBox.Show("Ocurrio un error al cargar la informacion.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(2, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "EX|" & ex.ToString

                        End Try
                        Return resp
                    End Using
                End Using
            End Using
        End Using
    End Function
    Public Function InsertTaxes(ByVal id_Company As Long, ByVal Id_CollectingAgency As Long, ByVal Name_Tax As String,
                              ByVal Is_TaxParent As Boolean, ByVal Is_TaxLine As Boolean, ByVal Is_TaxProduct As Boolean, ByVal IsPercent As Boolean,
                              ByVal Value As Decimal) As String
        Using conn As New SqlClient.SqlConnection(connStr)
            Dim resp As String = ""
            Using cmd As New SqlCommand("ERP_Generic_SP_InsertTaxes", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_Company_FK", SqlDbType.BigInt).Value = id_Company
                cmd.Parameters.Add("@Id_CollectingAgency_FK", SqlDbType.BigInt).Value = Id_CollectingAgency
                cmd.Parameters.Add("@Name_Tax", SqlDbType.VarChar).Value = Name_Tax
                cmd.Parameters.Add("@Is_TaxParent", SqlDbType.Bit).Value = Is_TaxParent
                cmd.Parameters.Add("@Is_TaxLine", SqlDbType.Bit).Value = Is_TaxLine
                cmd.Parameters.Add("@Is_TaxProduct", SqlDbType.Bit).Value = Is_TaxProduct
                cmd.Parameters.Add("@IsPercent", SqlDbType.Bit).Value = IsPercent
                cmd.Parameters.Add("@Value", SqlDbType.Decimal).Value = Value
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            resp = ds.Tables("datos").Rows(0)(0).ToString
                            Return resp
                        Catch ex As SqlException
                            MessageBox.Show("Fallo en la conexión con la base de datos, comuniquese con soporte técnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "EX|" & ex.ToString

                        Catch ex As Exception
                            MessageBox.Show("Ocurrio un error al cargar la información.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(2, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "EX|" & ex.ToString

                        End Try
                        Return resp
                    End Using
                End Using
            End Using
        End Using
    End Function
    Public Function DelTaxes(ByVal Id_Tax As Long, ByVal id_Company As Long) As String
        Using conn As New SqlClient.SqlConnection(connStr)
            Dim resp As String = ""
            Using cmd As New SqlCommand("ERP_Generic_SP_DelTaxes", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_Tax", SqlDbType.BigInt).Value = Id_Tax
                cmd.Parameters.Add("@Id_Company_FK", SqlDbType.BigInt).Value = id_Company
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            resp = ds.Tables("datos").Rows(0)(0).ToString
                            Return resp
                        Catch ex As SqlException
                            MessageBox.Show("Fallo en la conexión con la base de datos, comuniquese con soporte tecnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "EX|" & ex.ToString

                        Catch ex As Exception
                            MessageBox.Show("Ocurrio un error al cargar la informacion.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(2, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "EX|" & ex.ToString

                        End Try
                        Return resp
                    End Using
                End Using
            End Using
        End Using
    End Function



#End Region
#Region "Deparments"
    Public Function GetMarca(ByVal ID_Company As Integer, ByVal Busqueda As String, ByVal tipo As Integer) As DataTable
        Dim dt As New DataTable
        Dim ds As New DataSet("data")
        Try
            Using da As New SqlDataAdapter("ERP_SP_GetInventoryMarca_LIKE", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@Id_Company", _ID_Company)
                da.SelectCommand.Parameters.AddWithValue("@busqueda", Busqueda)
                da.SelectCommand.Parameters.AddWithValue("@tipo", tipo)
                da.Fill(ds, "Marca")
            End Using
            dt = ds.Tables("Marca")
        Catch ex As SqlException
            SaveLogException(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message.ToString)
        Catch ex As Exception
            SaveLogException(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message.ToString)
        End Try
        Return dt
    End Function

    Public Function GetDeparment(ByVal id_Company As Long) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_Generic_SP_GetDepartment", conn)
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

    Public Function GetDeparment(ByVal id_Company As Long, ByVal Busqueda As String) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Dim dt As New DataTable
            Dim ds As New DataSet("data")
            Try
                Using da As New SqlDataAdapter("ERP_Generic_SP_GetDepartment_LIKE", New SqlClient.SqlConnection(connStr))
                    da.SelectCommand.CommandType = CommandType.StoredProcedure
                    da.SelectCommand.Parameters.AddWithValue("@Id_Company", _ID_Company)
                    da.SelectCommand.Parameters.AddWithValue("@busqueda", Busqueda)

                    da.Fill(ds, "Depto")
                End Using
                dt = ds.Tables("Depto")
            Catch ex As SqlException
                SaveLogException(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message.ToString)
            Catch ex As Exception
                SaveLogException(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message.ToString)
            End Try
            Return dt
        End Using

    End Function



    Public Function SetDepartent(ByVal Id_Deparment As Long, ByVal id_Company As Long, ByVal Name_Deparment As String) As String
        Using conn As New SqlClient.SqlConnection(connStr)
            Dim resp As String = ""
            Using cmd As New SqlCommand("ERP_Generic_SP_SetDeparment", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_Deparment", SqlDbType.BigInt).Value = Id_Deparment
                cmd.Parameters.Add("@Id_Company", SqlDbType.BigInt).Value = id_Company
                cmd.Parameters.Add("@Name_Deparment", SqlDbType.VarChar).Value = Name_Deparment
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            resp = ds.Tables("datos").Rows(0)(0).ToString
                            Return resp
                        Catch ex As SqlException
                            MessageBox.Show("Fallo en la conexión con la base de datos, comuniquese con soporte técnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "EX|" + ex.ToString

                        Catch ex As Exception
                            MessageBox.Show("Ocurrio un error al cargar la información.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(2, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "EX|" + ex.ToString

                        End Try
                        Return resp
                    End Using
                End Using
            End Using
        End Using
    End Function
    Public Function InsertDepartent(ByVal id_Company As Long, ByVal Name_Deparment As String) As String
        Using conn As New SqlClient.SqlConnection(connStr)
            Dim resp As String = ""
            Using cmd As New SqlCommand("ERP_Generic_SP_InsertDeparment", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_Company", SqlDbType.BigInt).Value = id_Company
                cmd.Parameters.Add("@Name_Deparment", SqlDbType.VarChar).Value = Name_Deparment
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            resp = ds.Tables("datos").Rows(0)(0).ToString


                        Catch ex As SqlException
                            MessageBox.Show("Fallo en la conexión con la base de datos, comuniquese con soporte técnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "EX|" + ex.ToString

                        Catch ex As Exception
                            MessageBox.Show("Ocurrio un error al cargar la información.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(2, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "EX|" + ex.ToString

                        End Try
                        Return resp
                    End Using
                End Using
            End Using
        End Using
    End Function
    Public Function DelDeparment(ByVal Id_Deparment As Long, ByVal id_Company As Long) As String
        Using conn As New SqlClient.SqlConnection(connStr)
            Dim resp As String = ""
            Using cmd As New SqlCommand("ERP_Generic_SP_DelDeparment", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_Deparment", SqlDbType.BigInt).Value = Id_Deparment
                cmd.Parameters.Add("@Id_Company_FK", SqlDbType.BigInt).Value = id_Company
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            resp = ds.Tables("datos").Rows(0)(0).ToString
                            Return resp
                        Catch ex As SqlException
                            MessageBox.Show("Fallo en la conexión con la base de datos, comuniquese con soporte técnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "EX|" + ex.ToString

                        Catch ex As Exception
                            MessageBox.Show("Ocurrio un error al cargar la información.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(2, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "EX|" + ex.ToString

                        End Try
                        Return resp
                    End Using
                End Using
            End Using
        End Using
    End Function
#End Region
#Region "CollectingAgency"

    Public Function GetCollectingAgency(ByVal id_Company As Long) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_Generic_SP_GetCollectingAgency", conn)
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

    Public Function SetCollectingAgency(ByVal Id_CollectingAgency As Long, ByVal id_Company As Long, ByVal Name_CollectingAgency As String) As String
        Using conn As New SqlClient.SqlConnection(connStr)
            Dim resp As String = ""
            Using cmd As New SqlCommand("ERP_Generic_SP_SetCollectingAgency", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_CollectingAgency", SqlDbType.BigInt).Value = Id_CollectingAgency
                cmd.Parameters.Add("@Id_Company_FK", SqlDbType.BigInt).Value = id_Company
                cmd.Parameters.Add("@Name_CollectingAgency", SqlDbType.VarChar).Value = Name_CollectingAgency
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            resp = ds.Tables("datos").Rows(0)(0).ToString
                            Return resp
                        Catch ex As SqlException
                            MessageBox.Show("Fallo en la conexión con la base de datos, comuniquese con soporte técnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "EX|" + ex.ToString

                        Catch ex As Exception
                            MessageBox.Show("Ocurrio un error al cargar la información.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(2, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "EX|" + ex.ToString

                        End Try
                        Return resp
                    End Using
                End Using
            End Using
        End Using
    End Function
    Public Function InsertCollectingAgency(ByVal id_Company As Long, ByVal Name_CollectingAgency As String) As String
        Using conn As New SqlClient.SqlConnection(connStr)
            Dim resp As String = ""
            Using cmd As New SqlCommand("ERP_Generic_SP_InsertCollectingAgency", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_Company_FK", SqlDbType.BigInt).Value = id_Company
                cmd.Parameters.Add("@Name_CollectingAgency", SqlDbType.VarChar).Value = Name_CollectingAgency
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            resp = ds.Tables("datos").Rows(0)(0).ToString

                            Return resp
                        Catch ex As SqlException
                            MessageBox.Show("Fallo en la conexión con la base de datos, comuniquese con soporte técnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "EX|" + ex.ToString

                        Catch ex As Exception
                            MessageBox.Show("Ocurrio un error al cargar la información.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(2, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "EX|" + ex.ToString

                        End Try
                        Return resp
                    End Using
                End Using
            End Using
        End Using
    End Function
    Public Function DelCollectingAgency(ByVal Id_Tax As Long, ByVal id_Company As Long) As String
        Using conn As New SqlClient.SqlConnection(connStr)
            Dim resp As String = ""
            Using cmd As New SqlCommand("ERP_Generic_SP_DelCollectingAgency", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_CollectingAgency", SqlDbType.BigInt).Value = Id_Tax
                cmd.Parameters.Add("@Id_Company_FK", SqlDbType.BigInt).Value = id_Company
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            resp = ds.Tables("datos").Rows(0)(0).ToString
                            Return resp
                        Catch ex As SqlException
                            MessageBox.Show("Fallo en la conexión con la base de datos, comuniquese con soporte técnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "EX|" + ex.ToString

                        Catch ex As Exception
                            MessageBox.Show("Ocurrio un error al cargar la información.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(2, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "EX|" + ex.ToString

                        End Try
                        Return resp
                    End Using
                End Using
            End Using
        End Using
    End Function
#End Region
#Region "Municipality"

    Public Function GetMunicipality(ByVal id_Company As Long) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_Generic_SP_GetMunicipality", conn)
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

    Public Function SetMunicipality(ByVal Id_Municipality As Long, ByVal id_Company As Long, ByVal id_Deparment As Long, ByVal Name_Municipality As String) As String
        Using conn As New SqlClient.SqlConnection(connStr)
            Dim resp As String = ""
            Using cmd As New SqlCommand("ERP_Generic_SP_SetMunicipality", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_Municipality", SqlDbType.BigInt).Value = Id_Municipality
                cmd.Parameters.Add("@Id_Company_FK", SqlDbType.BigInt).Value = id_Company
                cmd.Parameters.Add("@Id_Deparment_FK", SqlDbType.BigInt).Value = id_Deparment
                cmd.Parameters.Add("@Name_Municipality", SqlDbType.VarChar).Value = Name_Municipality
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            resp = ds.Tables("datos").Rows(0)(0).ToString

                            Return resp
                        Catch ex As SqlException
                            MessageBox.Show("Fallo en la conexión con la base de datos, comuniquese con soporte técnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "EX|" + ex.ToString

                        Catch ex As Exception
                            MessageBox.Show("Ocurrio un error al cargar la información.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(2, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "EX|" + ex.ToString

                        End Try
                        Return resp
                    End Using
                End Using
            End Using
        End Using
    End Function
    Public Function InsertMunicipality(ByVal id_Company As Long, ByVal id_Deparment As Long, ByVal Name_Municipality As String) As String
        Using conn As New SqlClient.SqlConnection(connStr)
            Dim resp As String = ""
            Using cmd As New SqlCommand("ERP_Generic_SP_InsertMunicipality", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_Company_FK", SqlDbType.BigInt).Value = id_Company
                cmd.Parameters.Add("@Id_Deparment_FK", SqlDbType.BigInt).Value = id_Deparment
                cmd.Parameters.Add("@Name_Municipality", SqlDbType.VarChar).Value = Name_Municipality
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            resp = ds.Tables("datos").Rows(0)(0).ToString
                            Return resp
                        Catch ex As SqlException
                            MessageBox.Show("Fallo en la conexión con la base de datos, comuniquese con soporte técnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "EX|" + ex.ToString

                        Catch ex As Exception
                            MessageBox.Show("Ocurrio un error al cargar la información.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(2, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "EX|" + ex.ToString

                        End Try
                        Return resp
                    End Using
                End Using
            End Using
        End Using
    End Function
    Public Function DelMunicipality(ByVal Id_Municipality As Long, ByVal id_Company As Long) As String
        Using conn As New SqlClient.SqlConnection(connStr)
            Dim resp As String = ""
            Using cmd As New SqlCommand("ERP_Generic_SP_DelMunicipality", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_Municipality", SqlDbType.BigInt).Value = Id_Municipality
                cmd.Parameters.Add("@Id_Company_FK", SqlDbType.BigInt).Value = id_Company
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            resp = ds.Tables("datos").Rows(0)(0).ToString
                            Return resp
                        Catch ex As SqlException
                            MessageBox.Show("Fallo en la conexión con la base de datos, comuniquese con soporte técnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "EX|" + ex.ToString

                        Catch ex As Exception
                            MessageBox.Show("Ocurrio un error al cargar la información.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(2, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "EX|" + ex.ToString

                        End Try
                        Return resp
                    End Using
                End Using
            End Using
        End Using
    End Function
#End Region
#Region "Country"

    Public Function GetCountry(ByVal id_Company As Long) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_Generic_SP_GetCountry", conn)
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

    Public Function SetCountry(ByVal Id_Country As Long, ByVal id_Company As Long, ByVal Name_Country As String, ByVal ShortName As String) As String
        Using conn As New SqlClient.SqlConnection(connStr)
            Dim resp As String = ""
            Using cmd As New SqlCommand("ERP_Generic_SP_SetCountry", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_Country", SqlDbType.BigInt).Value = Id_Country
                cmd.Parameters.Add("@Id_Company_FK", SqlDbType.BigInt).Value = id_Company
                cmd.Parameters.Add("@Name_Country", SqlDbType.VarChar).Value = Name_Country
                cmd.Parameters.Add("@ShortName", SqlDbType.VarChar).Value = ShortName
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            resp = ds.Tables("datos").Rows(0)(0).ToString
                            Return resp
                        Catch ex As SqlException
                            MessageBox.Show("Fallo en la conexión con la base de datos, comuniquese con soporte técnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "EX|" + ex.ToString

                        Catch ex As Exception
                            MessageBox.Show("Ocurrio un error al cargar la información.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(2, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "EX|" + ex.ToString

                        End Try
                        Return resp
                    End Using
                End Using
            End Using
        End Using
    End Function
    Public Function InsertCountry(ByVal id_Company As Long, ByVal Name_Country As String, ByVal ShortName As String) As String
        Using conn As New SqlClient.SqlConnection(connStr)
            Dim resp As String = ""
            Using cmd As New SqlCommand("ERP_Generic_SP_InsertCountry", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_Company_FK", SqlDbType.BigInt).Value = id_Company
                cmd.Parameters.Add("@Name_Country", SqlDbType.VarChar).Value = Name_Country
                cmd.Parameters.Add("@ShortName", SqlDbType.VarChar).Value = ShortName
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            resp = ds.Tables("datos").Rows(0)(0).ToString
                            Return resp
                        Catch ex As SqlException
                            MessageBox.Show("Fallo en la conexión con la base de datos, comuniquese con soporte técnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "EX|" + ex.ToString

                        Catch ex As Exception
                            MessageBox.Show("Ocurrio un error al cargar la información.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(2, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "EX|" + ex.ToString

                        End Try
                        Return resp
                    End Using
                End Using
            End Using
        End Using
    End Function
    Public Function DelCountry(ByVal Id_Country As Long, ByVal id_Company As Long) As String
        Using conn As New SqlClient.SqlConnection(connStr)
            Dim resp As String = ""
            Using cmd As New SqlCommand("ERP_Generic_SP_DelCountry", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_Country", SqlDbType.BigInt).Value = Id_Country
                cmd.Parameters.Add("@Id_Company_FK", SqlDbType.BigInt).Value = id_Company
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            resp = ds.Tables("datos").Rows(0)(0).ToString
                            Return resp
                        Catch ex As SqlException
                            MessageBox.Show("Fallo en la conexión con la base de datos, comuniquese con soporte técnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "EX|" + ex.ToString

                        Catch ex As Exception
                            MessageBox.Show("Ocurrio un error al cargar la información.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(2, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "EX|" + ex.ToString

                        End Try
                        Return resp
                    End Using
                End Using
            End Using
        End Using
    End Function
#End Region
#Region "UnitMeasure"

    Public Function GetUnitMeasure(ByVal id_Company As Long) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_Generic_SP_GetUnitMeasure", conn)
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

    Public Function SetUnitMeasure(ByVal Id_UnitMeasure As Long, ByVal id_Company As Long, ByVal Name_UnitMeasure As String, ByVal Unit_Conversion As Decimal) As String
        Using conn As New SqlClient.SqlConnection(connStr)
            Dim resp As String = ""
            Using cmd As New SqlCommand("ERP_Generic_SP_SetUnitMeasure", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_UnitMeasure", SqlDbType.BigInt).Value = Id_UnitMeasure
                cmd.Parameters.Add("@Id_Company", SqlDbType.BigInt).Value = id_Company
                cmd.Parameters.Add("@Name_UnitMeasure", SqlDbType.VarChar).Value = Name_UnitMeasure
                cmd.Parameters.Add("@Unit_Conversion", SqlDbType.Decimal).Value = Unit_Conversion
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            resp = ds.Tables("datos").Rows(0)(0).ToString
                            Return resp
                        Catch ex As SqlException
                            MessageBox.Show("Fallo en la conexión con la base de datos, comuniquese con soporte técnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "EX|" + ex.ToString

                        Catch ex As Exception
                            MessageBox.Show("Ocurrio un error al cargar la información.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(2, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "EX|" + ex.ToString

                        End Try
                        Return resp
                    End Using
                End Using
            End Using
        End Using
    End Function
    Public Function InsertUnitMeasure(ByVal id_Company As Long, ByVal Name_UnitMeasure As String, ByVal Unit_Conversion As Decimal) As String
        Dim resp As String = ""
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_Generic_SP_InsertUnitMeasure", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_Company", SqlDbType.BigInt).Value = id_Company
                cmd.Parameters.Add("@Name_UnitMeasure", SqlDbType.VarChar).Value = Name_UnitMeasure
                cmd.Parameters.Add("@Unit_Conversion", SqlDbType.Decimal).Value = Unit_Conversion
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            resp = ds.Tables("datos").Rows(0)(0).ToString
                            Return resp
                        Catch ex As SqlException
                            MessageBox.Show("Fallo en la conexión con la base de datos, comuniquese con soporte técnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "EX|" + ex.ToString

                        Catch ex As Exception
                            MessageBox.Show("Ocurrio un error al cargar la información.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(2, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "EX|" + ex.ToString

                        End Try
                        Return resp
                    End Using
                End Using
            End Using
        End Using
    End Function
    Public Function DelUnitMeasure(ByVal Id_UnitMeasure As Long, ByVal id_Company As Long) As String
        Using conn As New SqlClient.SqlConnection(connStr)
            Dim resp As String = ""
            Using cmd As New SqlCommand("ERP_Generic_SP_DelUnitMeasure", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_UnitMeasure", SqlDbType.BigInt).Value = Id_UnitMeasure
                cmd.Parameters.Add("@Id_Company_FK", SqlDbType.BigInt).Value = id_Company

                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            resp = ds.Tables("datos").Rows(0)(0).ToString
                            Return resp
                        Catch ex As SqlException
                            MessageBox.Show("Fallo en la conexión con la base de datos, comuniquese con soporte técnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "EX|" + ex.ToString

                        Catch ex As Exception
                            MessageBox.Show("Ocurrio un error al cargar la información.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(2, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "EX|" + ex.ToString

                        End Try
                        Return resp
                    End Using
                End Using
            End Using
        End Using
    End Function
#End Region
#Region "CustomerMaster"
    Public Function GetCustomerMaster(ByVal id_Company As Long) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_Generic_GetCustomerMaster", conn)
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
    Public Function GetCustomerMaster(ByVal id_Company As Long, ByVal Word As String) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_Generic_GetCustomerMaster_Where", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_Company", SqlDbType.BigInt).Value = id_Company
                cmd.Parameters.Add("@Word", SqlDbType.VarChar).Value = Word
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

    Public Function GetCustomerMaster_Provider(ByVal id_Company As Long, ByVal Word As String) As DataTable
        Dim dt As New DataTable
        Dim ds As New DataSet("Data")
        Try
            Using da As New SqlDataAdapter("ERP_Generic_GetCustomerMaster_Provider", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@Id_Company", id_Company)
                da.SelectCommand.Parameters.AddWithValue("@Word", Word)
                da.Fill(ds, "Product")
            End Using
            dt = ds.Tables("Product")
        Catch ex As SqlException
            SaveLogException(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message.ToString)
        Catch ex As Exception
            SaveLogException(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message.ToString)
        End Try
        Return dt
    End Function

#End Region
#Region "TypeCustomer"
    Public Function GetTypeCustomer(ByVal id_Company As Long) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_Generic_GetTypeCustomer", conn)
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
#End Region
#Region "TypeCustomer"
    Public Function GetDepreciation(ByVal id_Company As Long) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_Generic_SP_GetDepreciation", conn)
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

    Public Function Generic_FromXLS_GetBienes(ByVal id_reponsable As Long) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("Generic_FromXLS_GetBienes", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@idResponsable", SqlDbType.BigInt).Value = id_reponsable
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

    Public Function Generic_FromXLS_GetBienes(ByVal id_reponsable As Long, ByVal busqueda As String) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("[Generic_FromXLS_GetBienes_LIKE]", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@idResponsable", SqlDbType.BigInt).Value = id_reponsable
                cmd.Parameters.Add("@busqueda", SqlDbType.VarChar).Value = busqueda
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

#Region "Product"
    Public Function GetProduct(ByVal id_Company As Long, ByVal Word As String) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_Inventory_GetProducts_Where", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_Company", SqlDbType.BigInt).Value = id_Company
                cmd.Parameters.Add("@Word", SqlDbType.VarChar).Value = Word
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

    Public Function GetProductProcess(ByVal id_Company As Long, ByVal Word As String) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_Prod_SP_Select_ProductsProcess", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_Company", SqlDbType.BigInt).Value = id_Company
                cmd.Parameters.Add("@Word", SqlDbType.VarChar).Value = Word
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

#End Region

    Public Function GetTipoCliente(ByVal Id_Company As Long) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_Generic_GetTypeCustomer", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_Company", SqlDbType.BigInt).Value = Id_Company
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return ds.Tables("datos")
                        Catch ex As SqlException
                            MessageBox.Show("Fallo en la conexión con la base de datos, comuniquese con soporte tecnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return New DataTable("datos")
                        Catch ex As Exception
                            MessageBox.Show("Ocurrio un error al cargar la informacion.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(5, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return New DataTable("datos")
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function
    Public Function GetContactEmploye(ByVal Id_Company As Long) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_RRHH_GetContactEmploye", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_Company", SqlDbType.BigInt).Value = Id_Company
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return ds.Tables("datos")
                        Catch ex As SqlException
                            MessageBox.Show("Fallo en la conexión con la base de datos, comuniquese con soporte tecnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return New DataTable("datos")
                        Catch ex As Exception
                            MessageBox.Show("Ocurrio un error al cargar la informacion.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(5, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return New DataTable("datos")
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function
    Public Function SetClienteCuentasPorCobrar(ByVal Id_Customer As Long, ByVal id_Company As Long, ByVal Id_TypeCustomer_FK As Long,
                                    ByVal Id_Minicipality_FK As Long, ByVal Id_EmployeelContact_FK As Long, ByVal Id_CompanyCategory_Fk As Long,
                                    ByVal Is_Exempt As Boolean, ByVal Is_LegalEntity As Boolean, ByVal Business_Name As String,
                                    ByVal Commercial_Name As String, ByVal First_Name As String, ByVal Last_Name As String, ByVal Address As String,
                                    ByVal OfficePhone As String, ByVal Email_Contact As String, ByVal Identity_DocumentNumber As String, ByVal Tax_Registration_Number As String,
                                    ByVal Tax_Identification_Number As String, ByVal Is_BigContributor As Boolean, ByVal Turning_Company As String, ByVal Is_supplier As Long,
                                    ByVal DepemdeSIC As Boolean, ByVal IDSIC As String, ByVal Observaciones As String) As String

        Dim resp As Integer = 0
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_Generic_SetCustomerMaster", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_Customer", SqlDbType.BigInt).Value = Id_Customer
                cmd.Parameters.Add("@IdCompany", SqlDbType.BigInt).Value = id_Company
                cmd.Parameters.Add("@Id_TypeCustomer_FK", SqlDbType.BigInt).Value = Id_TypeCustomer_FK
                cmd.Parameters.Add("@Id_Minicipality_FK", SqlDbType.BigInt).Value = Id_Minicipality_FK
                cmd.Parameters.Add("@Id_EmployeelContact_FK", SqlDbType.BigInt).Value = Id_EmployeelContact_FK
                cmd.Parameters.Add("@Id_CompanyCategory_Fk", SqlDbType.BigInt).Value = Id_CompanyCategory_Fk
                cmd.Parameters.Add("@Is_Exempt", SqlDbType.Bit).Value = Is_Exempt
                cmd.Parameters.Add("@Is_LegalEntity", SqlDbType.Bit).Value = Is_LegalEntity
                cmd.Parameters.Add("@Business_Name", SqlDbType.VarChar).Value = Business_Name
                cmd.Parameters.Add("@Commercial_Name", SqlDbType.VarChar).Value = Commercial_Name
                cmd.Parameters.Add("@First_Name", SqlDbType.VarChar).Value = First_Name
                cmd.Parameters.Add("@Last_Name", SqlDbType.VarChar).Value = Last_Name
                cmd.Parameters.Add("@Address", SqlDbType.VarChar).Value = Address
                cmd.Parameters.Add("@OfficePhone", SqlDbType.VarChar).Value = OfficePhone
                cmd.Parameters.Add("@Email_Contact", SqlDbType.VarChar).Value = Email_Contact
                cmd.Parameters.Add("@Identity_DocumentNumber", SqlDbType.VarChar).Value = Identity_DocumentNumber
                cmd.Parameters.Add("@Tax_Registration_Number", SqlDbType.VarChar).Value = Tax_Registration_Number
                cmd.Parameters.Add("@Tax_Identification_Number", SqlDbType.VarChar).Value = Tax_Identification_Number
                cmd.Parameters.Add("@Is_BigContributor", SqlDbType.Bit).Value = Is_BigContributor
                cmd.Parameters.Add("@Turning_Company", SqlDbType.VarChar).Value = Turning_Company
                cmd.Parameters.Add("@Is_supplier", SqlDbType.BigInt).Value = Is_supplier

                cmd.Parameters.Add("@DepemdeSIC", SqlDbType.Bit).Value = DepemdeSIC
                cmd.Parameters.Add("@IDSIC", SqlDbType.VarChar).Value = IDSIC
                cmd.Parameters.Add("@Observaciones", SqlDbType.VarChar).Value = Observaciones


                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            resp = ds.Tables("datos").Rows(0).Item(0)
                            Return resp
                        Catch ex As SqlException
                            MessageBox.Show("Fallo en la conexión con la base de datos, comuniquese con soporte tecnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return resp
                        Catch ex As Exception
                            MessageBox.Show("Ocurrio un error al cargar la informacion.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(5, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return resp
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function

    Public Function InsertClienteCuentasPorCobrar(ByVal id_Company As Long, ByVal Id_TypeCustomer_FK As Long,
                                    ByVal Id_Minicipality_FK As Long, ByVal Id_EmployeelContact_FK As Long, ByVal Id_CompanyCategory_Fk As Long,
                                    ByVal Is_Exempt As Boolean, ByVal Is_LegalEntity As Boolean, ByVal Business_Name As String,
                                    ByVal Commercial_Name As String, ByVal First_Name As String, ByVal Last_Name As String, ByVal Address As String,
                                    ByVal OfficePhone As String, ByVal Email_Contact As String, ByVal Identity_DocumentNumber As String, ByVal Tax_Registration_Number As String,
                                    ByVal Tax_Identification_Number As String, ByVal Is_Suplier As Boolean, ByVal Is_BigContributor As Boolean, ByVal Turning_Company As String,
                                    ByVal DepemdeSIC As Boolean, ByVal IDSIC As String, ByVal Observaciones As String) As String
        Dim resp As String = "err"
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_Generic_InsertCustomerMaster", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@IdCompany", SqlDbType.BigInt).Value = id_Company
                cmd.Parameters.Add("@Id_TypeCustomer_FK", SqlDbType.BigInt).Value = Id_TypeCustomer_FK
                cmd.Parameters.Add("@Id_Minicipality_FK", SqlDbType.BigInt).Value = Id_Minicipality_FK
                cmd.Parameters.Add("@Id_EmployeelContact_FK", SqlDbType.BigInt).Value = Id_EmployeelContact_FK
                cmd.Parameters.Add("@Id_CompanyCategory_Fk", SqlDbType.BigInt).Value = Id_CompanyCategory_Fk
                cmd.Parameters.Add("@Is_Exempt", SqlDbType.Bit).Value = Is_Exempt
                cmd.Parameters.Add("@Is_LegalEntity", SqlDbType.Bit).Value = Is_LegalEntity
                cmd.Parameters.Add("@Business_Name", SqlDbType.VarChar).Value = Business_Name
                cmd.Parameters.Add("@Commercial_Name", SqlDbType.VarChar).Value = Commercial_Name
                cmd.Parameters.Add("@First_Name", SqlDbType.VarChar).Value = First_Name
                cmd.Parameters.Add("@Last_Name", SqlDbType.VarChar).Value = Last_Name
                cmd.Parameters.Add("@Address", SqlDbType.VarChar).Value = Address
                cmd.Parameters.Add("@OfficePhone", SqlDbType.VarChar).Value = OfficePhone
                cmd.Parameters.Add("@Email_Contact", SqlDbType.VarChar).Value = Email_Contact
                cmd.Parameters.Add("@Identity_DocumentNumber", SqlDbType.VarChar).Value = Identity_DocumentNumber
                cmd.Parameters.Add("@Tax_Registration_Number", SqlDbType.VarChar).Value = Tax_Registration_Number
                cmd.Parameters.Add("@Tax_Identification_Number", SqlDbType.VarChar).Value = Tax_Identification_Number
                cmd.Parameters.Add("@Is_Supplier", SqlDbType.Bit).Value = Is_Suplier
                cmd.Parameters.Add("@Is_BigContributor", SqlDbType.Bit).Value = Is_BigContributor
                cmd.Parameters.Add("@Turning_Company", SqlDbType.VarChar).Value = Turning_Company

                cmd.Parameters.Add("@DepemdeSIC", SqlDbType.Bit).Value = DepemdeSIC
                cmd.Parameters.Add("@IDSIC", SqlDbType.VarChar).Value = IDSIC
                cmd.Parameters.Add("@Observaciones", SqlDbType.VarChar).Value = Observaciones



                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            resp = ds.Tables("datos").Rows(0).Item(0)
                            Return resp
                        Catch ex As SqlException
                            MessageBox.Show("Fallo en la conexión con la base de datos, comuniquese con soporte tecnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return resp
                        Catch ex As Exception
                            MessageBox.Show("Ocurrió un error al cargar la información.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(5, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return resp
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function
    Public Function GetTypeCreditLine() As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_SP_GetTypeCreditLine", conn)
                cmd.CommandType = CommandType.StoredProcedure
                'cmd.Parameters.Add("@Id_Cliente", SqlDbType.BigInt).Value = IdCliente
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return ds.Tables("datos")
                        Catch ex As SqlException
                            MessageBox.Show("Fallo en la conexión con la base de datos, comuniquese con soporte tecnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return New DataTable("datos")
                        Catch ex As Exception
                            MessageBox.Show("Ocurrio un error al cargar la informacion.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(5, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return New DataTable("datos")
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function
    Public Function GetCompanyCategory(ByVal Id_Company As Long) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_Generic_SP_GetCompanyCategory", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_Company_FK", SqlDbType.BigInt).Value = Id_Company
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return ds.Tables("datos")
                        Catch ex As SqlException
                            MessageBox.Show("Fallo en la conexión con la base de datos, comuniquese con soporte tecnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return New DataTable("datos")
                        Catch ex As Exception
                            MessageBox.Show("Ocurrio un error al cargar la informacion.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(5, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return New DataTable("datos")
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function

    Public Function SetCreditLine(ByVal ID_CreditLine As Long, ByVal ID_TypeCreditLine As Long, ByVal Id_Customer As Long, ByVal Valor As String,
                                  ByVal Saldo As Long, ByVal concepto As String, ByVal Vigencia As String, ByVal DateStar As DateTime,
                                  ByVal DateEnd As DateTime, ByVal ActiveLine As Boolean, ByVal DaysInvoiceExpiration As Integer) As String
        Dim resp As Integer = 0
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_SP_SetCreditLine", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@ID_CreditLine", SqlDbType.BigInt).Value = ID_CreditLine
                cmd.Parameters.Add("@ID_TypeCreditLine", SqlDbType.BigInt).Value = ID_TypeCreditLine
                cmd.Parameters.Add("@Id_Customer", SqlDbType.BigInt).Value = Id_Customer
                cmd.Parameters.Add("@Valor", SqlDbType.VarChar).Value = Valor
                cmd.Parameters.Add("@Saldo", SqlDbType.VarChar).Value = Saldo
                cmd.Parameters.Add("@Concepto", SqlDbType.VarChar).Value = concepto
                cmd.Parameters.Add("@Vigencia", SqlDbType.VarChar).Value = Vigencia
                cmd.Parameters.Add("@DateStar", SqlDbType.DateTime).Value = DateStar
                cmd.Parameters.Add("@DateEnd", SqlDbType.DateTime).Value = DateEnd
                cmd.Parameters.Add("@ActiveLine", SqlDbType.Bit).Value = ActiveLine
                cmd.Parameters.AddWithValue("@DaysInvoiceExpiration", DaysInvoiceExpiration)
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            resp = ds.Tables("datos").Rows(0).Item(0)
                            Return resp
                        Catch ex As SqlException
                            MessageBox.Show("Fallo en la conexión con la base de datos, comuniquese con soporte tecnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return resp
                        Catch ex As Exception
                            MessageBox.Show("Ocurrio un error al cargar la informacion.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(5, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return resp
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function

    Public Function InsertCreditLine(ByVal ID_TypeCreditLine As Long, ByVal Id_Customer As Long, ByVal Valor As String,
                                  ByVal Saldo As Long, ByVal concepto As String, ByVal Vigencia As String, ByVal DateStar As DateTime,
                                  ByVal DateEnd As DateTime, ByVal ActiveLine As Boolean, ByVal Id_Company As Long, ByVal DaysInvoiceExpiration As Integer) As String
        Dim resp As Integer = 0
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_SP_InsertCreditLine", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@ID_TypeCreditLine", SqlDbType.BigInt).Value = ID_TypeCreditLine
                cmd.Parameters.AddWithValue("@Id_Customer", Id_Customer)
                cmd.Parameters.AddWithValue("@Valor", Valor)
                cmd.Parameters.AddWithValue("@Saldo", Saldo)
                cmd.Parameters.AddWithValue("@Concepto", concepto)
                cmd.Parameters.AddWithValue("@Vigencia", Vigencia)
                cmd.Parameters.AddWithValue("@DateStar", DateStar)
                cmd.Parameters.AddWithValue("@DateEnd", DateEnd)
                cmd.Parameters.AddWithValue("@ActiveLine", ActiveLine)
                cmd.Parameters.AddWithValue("@Id_Company", Id_Company)
                cmd.Parameters.AddWithValue("@DaysInvoiceExpiration", DaysInvoiceExpiration)
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            resp = ds.Tables("datos").Rows(0).Item(0)
                            Return resp
                        Catch ex As SqlException
                            MessageBox.Show("Fallo en la conexión con la base de datos, comuniquese con soporte tecnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return resp
                        Catch ex As Exception
                            MessageBox.Show("Ocurrio un error al cargar la información.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(5, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return resp
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function
    Public Function GetCreditLine(ByVal Id_company As Long, Id_Customer As Long, ByVal Activas As Boolean, ByVal Inactivas As Boolean, ByVal Atrasadas As Boolean) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_SP_GetCreditLine", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_Company", SqlDbType.BigInt).Value = Id_company
                cmd.Parameters.Add("@Id_Customer", SqlDbType.BigInt).Value = Id_Customer
                cmd.Parameters.Add("@Activas", SqlDbType.Bit).Value = Activas
                cmd.Parameters.Add("@Inactivas", SqlDbType.Bit).Value = Inactivas
                cmd.Parameters.Add("@Atrasadas", SqlDbType.Bit).Value = Atrasadas
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return ds.Tables("datos")
                        Catch ex As SqlException
                            MessageBox.Show("Fallo en la conexión con la base de datos, comuniquese con soporte tecnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return New DataTable("datos")
                        Catch ex As Exception
                            MessageBox.Show("Ocurrio un error al cargar la informacion.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(5, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return New DataTable("datos")
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function
    Public Function DelCreditLine(ByVal ID_CreditLine As Long) As String
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_SP_DelCreditLine", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@ID_CreditLine", SqlDbType.BigInt).Value = ID_CreditLine
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return "OK"
                        Catch ex As SqlException
                            MessageBox.Show("Fallo en la conexión con la base de datos, comuniquese con soporte tecnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "ERROR"
                        Catch ex As Exception
                            MessageBox.Show("Ocurrio un error al cargar la informacion.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(5, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "ERROR"
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function

    Public Function DelClienteCuentasPorCobrar(ByVal Id_Customer As Long, ByVal IdCompany As Long) As String
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_Generic_DelCustomerMaster", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_Customer", SqlDbType.BigInt).Value = Id_Customer
                cmd.Parameters.Add("@IdCompany", SqlDbType.BigInt).Value = IdCompany
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return "OK"
                        Catch ex As SqlException
                            MessageBox.Show("Fallo en la conexión con la base de datos, comuniquese con soporte técnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "ERROR"
                        Catch ex As Exception
                            MessageBox.Show("Ocurrio un error al cargar la información.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(5, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "ERROR"
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function

    Public Function SearchCustomers(ByVal Id_company As Long, ByVal Search As String, ByVal TipoConsulta As Long) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("Generic_SearchCustomerMaster", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_Company", SqlDbType.BigInt).Value = Id_company
                cmd.Parameters.Add("@Search", SqlDbType.VarChar).Value = Search
                cmd.Parameters.Add("@TipoConsulta", SqlDbType.BigInt).Value = TipoConsulta
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return ds.Tables("datos")
                        Catch ex As SqlException
                            MessageBox.Show("Fallo en la conexión con la base de datos, comuniquese con soporte tecnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return New DataTable("datos")
                        Catch ex As Exception
                            MessageBox.Show("Ocurrio un error al cargar la informacion.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(2, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return New DataTable("datos")
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function

    Public Function GetCustomerClientList(ByVal ID_Company As Integer, ByVal Id_Tipocliente As Long, ByVal Id_Categoria As Long, ByVal Id_Rubro As Long, ByVal Id_TipoConsulta As Long, Optional Busquedad As String = "") As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_Generic_GetCustomerMasterFilter", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_Company", SqlDbType.BigInt).Value = ID_Company
                cmd.Parameters.Add("@Id_TipoCliente", SqlDbType.BigInt).Value = Id_Tipocliente
                cmd.Parameters.Add("@Id_Categoria", SqlDbType.BigInt).Value = Id_Categoria
                cmd.Parameters.Add("@Id_Rubro", SqlDbType.BigInt).Value = Id_Rubro
                cmd.Parameters.Add("@Id_TipoConsulta", SqlDbType.BigInt).Value = Id_TipoConsulta
                cmd.Parameters.Add("@Busquedad", SqlDbType.VarChar).Value = Busquedad

                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return ds.Tables("datos")
                        Catch ex As SqlException
                            MessageBox.Show("Fallo en la conexión con la base de datos, comuniquese con soporte tecnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return New DataTable("datos")
                        Catch ex As Exception
                            MessageBox.Show("Ocurrio un error al cargar la informacion.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(2, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return New DataTable("datos")
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function

    Public Function GetTypeDocument() As DataTable
        Dim dt As New DataTable
        Dim ds As New DataSet("data")
        Try
            Using da As New SqlDataAdapter("ERP_AR_GetCreditDocument", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@Id_Company", _ID_Company)
                da.Fill(ds, "Document")
            End Using
            dt = ds.Tables("Document")
        Catch ex As SqlException
            MessageBox.Show("Fallo en la conexión con la base de datos, comuniquese con soporte tecnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
            Return New DataTable("datos")
        Catch ex As Exception
            MessageBox.Show("Ocurrio un error al cargar la informacion.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(2, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
            Return New DataTable("datos")
        End Try
        Return dt
    End Function
    Public Function GetListClient(ByVal Id_Company As Long, ByVal Tipo As Boolean) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_AR_GetCustomerList", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_Company", SqlDbType.BigInt).Value = Id_Company
                cmd.Parameters.Add("@Tipo", SqlDbType.Bit).Value = Tipo
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return ds.Tables("datos")
                        Catch ex As SqlException
                            MessageBox.Show("Fallo en la conexión con la base de datos, comuniquese con soporte tecnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return New DataTable("datos")
                        Catch ex As Exception
                            MessageBox.Show("Ocurrio un error al cargar la informacion.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(2, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return New DataTable("datos")
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function
    Public Function GetCreditLineByCustomer(ByVal ID_CustomerM As Long) As DataTable
        Dim dt As New DataTable
        Dim ds As New DataSet("data")
        Try
            Using da As New SqlDataAdapter("ERP_AR_GetCreditLineByCustomer", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@Id_Company", _ID_Company)
                da.SelectCommand.Parameters.AddWithValue("@ID_Customer", ID_CustomerM)
                da.Fill(ds, "CreditLine")
            End Using
            dt = ds.Tables("CreditLine")
        Catch ex As SqlException
            MessageBox.Show("Fallo en la conexión con la base de datos, comuniquese con soporte tecnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
            Return New DataTable("datos")
        Catch ex As Exception
            MessageBox.Show("Ocurrio un error al cargar la informacion.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(2, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
            Return New DataTable("datos")
        End Try
        Return dt
    End Function

    Public Function AddAccountsReceivable(ByVal ID_Company_FK As Integer, ByVal ID_Customer_FK As Integer, ByVal ID_TypeDocument_FK As Integer, ByVal ID_CreditLine_FK As Integer, ByVal DocumentNumber As Integer, ByVal SaldoDeudor As Double, ByVal AmountOfFees As Integer, ByVal DateInit As Date, ByVal PaymentType_FK As Integer, ByVal CreditDescription As String) As Long
        Dim resp As Integer = 0
        Dim ds As New DataSet("data")
        Try
            Using da As New SqlDataAdapter("ERP_AR_AddAccountsReceivable", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@ID_Company_FK", ID_Company_FK)
                da.SelectCommand.Parameters.AddWithValue("@ID_Customer_FK", ID_Customer_FK)
                da.SelectCommand.Parameters.AddWithValue("@ID_TypeDocument_FK", ID_TypeDocument_FK)
                da.SelectCommand.Parameters.AddWithValue("@ID_CreditLine_FK", ID_CreditLine_FK)
                da.SelectCommand.Parameters.AddWithValue("@DocumentNumber", DocumentNumber)
                da.SelectCommand.Parameters.AddWithValue("@SaldoDeudor", SaldoDeudor)
                da.SelectCommand.Parameters.AddWithValue("@AmountOfFees", AmountOfFees)
                da.SelectCommand.Parameters.AddWithValue("@DateInit", DateInit)
                da.SelectCommand.Parameters.AddWithValue("@PaymentType_FK", PaymentType_FK)
                da.SelectCommand.Parameters.AddWithValue("@Credit_Description", CreditDescription)
                da.Fill(ds, "AddAccounts")
                resp = ds.Tables("AddAccounts").Rows(0).Item("ID")
            End Using
        Catch ex As SqlException
            MessageBox.Show("Fallo en la conexión con la base de datos, comuniquese con soporte tecnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
            Return resp
        Catch ex As Exception
            MessageBox.Show("Ocurrio un error al cargar la informacion.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(2, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
            Return resp
        End Try
        Return resp
    End Function

    Public Function AddDetailsAccountsReceivable(ByVal ID_AccountsList_FK As Integer, ByVal QuotaNumber As Double, ByVal PaymentDate As Date, ByVal Ammount As Double) As Integer
        Dim resp As Integer = 0
        Dim ds As New DataSet("data")
        Try
            Using da As New SqlDataAdapter("ERP_AR_AddDetailsAccountReceivable", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@ID_AccountsList_FK", ID_AccountsList_FK)
                da.SelectCommand.Parameters.AddWithValue("@QuotaNumber", QuotaNumber)
                da.SelectCommand.Parameters.AddWithValue("@PaymentDate", PaymentDate)
                da.SelectCommand.Parameters.AddWithValue("@Ammount", Ammount)
                da.Fill(ds, "AddAccounts")
                resp = 1
            End Using
        Catch ex As SqlException
            MessageBox.Show("Fallo en la conexión con la base de datos, comuniquese con soporte tecnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
            Return resp
        Catch ex As Exception
            MessageBox.Show("Ocurrio un error al cargar la informacion.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(2, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
            Return resp
        End Try
        Return resp
    End Function
#Region "Cuentas por pagar"

    Public Function GetListAllClient(ByVal Id_Company As Long, ByVal Tipo As Boolean) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_AR_GetAllCustomerList", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_Company", SqlDbType.BigInt).Value = Id_Company
                cmd.Parameters.Add("@Tipo", SqlDbType.Bit).Value = Tipo
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return ds.Tables("datos")
                        Catch ex As SqlException
                            MessageBox.Show("Fallo en la conexión con la base de datos, comuniquese con soporte tecnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return New DataTable("datos")
                        Catch ex As Exception
                            MessageBox.Show("Ocurrio un error al cargar la informacion.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(2, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return New DataTable("datos")
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function
#End Region
    Public Function GetPagoRestante(ByVal Id_AccountReceivable As Long) As DataTable
        Dim DT_Resp As New DataTable
        Dim ds As New DataSet("data")
        Try
            Using da As New SqlDataAdapter("ERP_AR_GetPaymentData", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@Id_AccountReceivable", Id_AccountReceivable)
                da.Fill(ds, "GetPagoRestante")
                DT_Resp = ds.Tables("GetPagoRestante")
            End Using
        Catch ex As SqlException
            MessageBox.Show("Fallo en la conexión con la base de datos, comuniquese con soporte técnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
        Catch ex As Exception
            MessageBox.Show("Ocurrio un error al cargar la información.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(2, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
        End Try
        Return DT_Resp
    End Function

    Public Function GetPagoRestantePagos(ByVal Id_AccountPayable As Long) As DataTable
        Dim DT_Resp As New DataTable
        Dim ds As New DataSet("data")
        Try
            Using da As New SqlDataAdapter("ERP_AP_GetPaymentData", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@Id_AccountPayable", Id_AccountPayable)
                da.Fill(ds, "GetPagoRestante")
                DT_Resp = ds.Tables("GetPagoRestante")
            End Using
        Catch ex As SqlException
            MessageBox.Show("Fallo en la conexión con la base de datos, comuniquese con soporte técnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
        Catch ex As Exception
            MessageBox.Show("Ocurrio un error al cargar la información.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(2, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
        End Try
        Return DT_Resp
    End Function

    Public Function InsertAccountReceibaleQuota(ByVal Id_Employee As Long, ByVal Id_AccountReceivable As Long, ByVal Id_AccountReceivableQuota As Long, ByVal Id_Company As Long, ByVal Id_PaymentType As Long) As DataTable
        Dim ds As New DataSet
        Dim dt As New DataTable
        Try
            Using da As New SqlDataAdapter("ERP_AR_AddPayoutQuota", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@Id_AccountReceivable", Id_AccountReceivable)
                da.SelectCommand.Parameters.AddWithValue("@Id_AccountReceivableListDetails", Id_AccountReceivableQuota)
                da.SelectCommand.Parameters.AddWithValue("@Id_Company", Id_Company)
                da.SelectCommand.Parameters.AddWithValue("@Id_paymentType", Id_PaymentType)
                da.SelectCommand.Parameters.AddWithValue("@Id_Employee", Id_Employee)
                da.Fill(ds, "InsertAccountReceibaleQuota")
                dt = ds.Tables(0)
            End Using
        Catch ex As SqlException
            MessageBox.Show("Fallo en la conexión con la base de datos, comuniquese con soporte técnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
        Catch ex As Exception
            MessageBox.Show("Ocurrio un error al cargar la información.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(2, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
        End Try
        Return dt
    End Function

    Public Function InsertAccountReceibaleFinalize(ByVal Id_Employee As Long, ByVal Id_AccountReceivable As Long, ByVal Id_Company As Long, ByVal Id_PaymentType As Long) As String
        Dim ds As New DataSet
        Dim res As String = ""
        Try
            Using da As New SqlDataAdapter("ERP_AR_AddAccountsReceivableFinalize", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@Id_AccountReceivable", Id_AccountReceivable)
                da.SelectCommand.Parameters.AddWithValue("@Id_Company", Id_Company)
                da.SelectCommand.Parameters.AddWithValue("@Id_paymentType", Id_PaymentType)
                da.SelectCommand.Parameters.AddWithValue("@Id_Employee", Id_Employee)
                da.Fill(ds, "InsertAccountReceibaleFinalize")
                res = ds.Tables("InsertAccountReceibaleFinalize").Rows(0).Item(0)
            End Using
        Catch ex As SqlException
            MessageBox.Show("Fallo en la conexión con la base de datos, comuniquese con soporte técnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
        Catch ex As Exception
            MessageBox.Show("Ocurrio un error al cargar la información.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(2, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
        End Try
        Return res
    End Function

    Public Function InsertAccountPayableQuota(ByVal Id_Employee As Long, ByVal Id_AccountReceivable As Long, ByVal Id_AccountReceivableQuota As Long, ByVal Id_Company As Long, ByVal Id_PaymentType As Long, ByVal PayableDate As Date, ByVal NCheque As String) As String
        Dim ds As New DataSet
        Dim res As String = ""
        Try
            Using da As New SqlDataAdapter("ERP_AP_AddPayoutQuota", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@Id_AccountPayable", Id_AccountReceivable)
                da.SelectCommand.Parameters.AddWithValue("@Id_AccountPayableListDetails", Id_AccountReceivableQuota)
                da.SelectCommand.Parameters.AddWithValue("@Id_Company", Id_Company)
                da.SelectCommand.Parameters.AddWithValue("@Id_paymentType", Id_PaymentType)
                da.SelectCommand.Parameters.AddWithValue("@Id_Empleado", Id_Employee)
                da.SelectCommand.Parameters.AddWithValue("@Fecha_Pago", PayableDate)
                da.SelectCommand.Parameters.AddWithValue("@N_Cheque", NCheque)
                da.Fill(ds, "InsertAccountReceibaleQuota")
                res = ds.Tables("InsertAccountReceibaleQuota").Rows(0).Item(0)
            End Using
        Catch ex As SqlException
            MessageBox.Show("Fallo en la conexión con la base de datos, comuniquese con soporte técnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
        Catch ex As Exception
            MessageBox.Show("Ocurrio un error al cargar la información.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(2, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
        End Try
        Return res
    End Function

    Public Function InsertAccountPayableFinalize(ByVal Id_Employee As Long, ByVal Id_AccountReceivable As Long, ByVal Id_Company As Long, ByVal Id_PaymentType As Long, ByVal PayableDate As Date, ByVal NCheque As String) As String
        Dim ds As New DataSet
        Dim res As String = ""
        Try
            Using da As New SqlDataAdapter("ERP_AP_AddAccountsPayableFinalize", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@Id_AccountPayable", Id_AccountReceivable)
                da.SelectCommand.Parameters.AddWithValue("@Id_Company", Id_Company)
                da.SelectCommand.Parameters.AddWithValue("@Id_paymentType", Id_PaymentType)
                da.SelectCommand.Parameters.AddWithValue("@Id_Empleado", Id_Employee)
                da.SelectCommand.Parameters.AddWithValue("@Fecha_Pago", PayableDate)
                da.SelectCommand.Parameters.AddWithValue("@N_Cheque", NCheque)
                da.Fill(ds, "InsertAccountReceibaleFinalize")
                res = ds.Tables("InsertAccountReceibaleFinalize").Rows(0).Item(0)
            End Using
        Catch ex As SqlException
            MessageBox.Show("Fallo en la conexión con la base de datos, comuniquese con soporte técnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
        Catch ex As Exception
            MessageBox.Show("Ocurrio un error al cargar la información.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(2, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
        End Try
        Return res
    End Function

    Public Function SearchCobros(ByVal Id_company As Long, ByVal TextSearch As String, ByVal TypeSearch As Long) As DataTable
        Dim DT_Resp As New DataTable
        Dim ds As New DataSet("data")
        Try
            Using da As New SqlDataAdapter("ERP_AR_AccountReceviableSearch", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@Id_company", Id_company)
                da.SelectCommand.Parameters.AddWithValue("@search", TextSearch)
                da.SelectCommand.Parameters.AddWithValue("@TypeSearch", TypeSearch)
                da.Fill(ds, "SearchCobros")
                DT_Resp = ds.Tables("SearchCobros")
            End Using
        Catch ex As SqlException
            MessageBox.Show("Fallo en la conexión con la base de datos, comuniquese con soporte técnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
        Catch ex As Exception
            MessageBox.Show("Ocurrio un error al cargar la información.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(2, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
        End Try
        Return DT_Resp
    End Function

    Public Function SearchCobrosPagar(ByVal Id_company As Long, ByVal TextSearch As String, ByVal TypeSearch As Long) As DataTable
        Dim DT_Resp As New DataTable
        Dim ds As New DataSet("data")
        Try
            Using da As New SqlDataAdapter("ERP_AP_AccountsPayableSearch", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@Id_company", Id_company)
                da.SelectCommand.Parameters.AddWithValue("@search", TextSearch)
                da.SelectCommand.Parameters.AddWithValue("@TypeSearch", TypeSearch)
                da.Fill(ds, "SearchCobros")
                DT_Resp = ds.Tables("SearchCobros")
            End Using
        Catch ex As SqlException
            MessageBox.Show("Fallo en la conexión con la base de datos, comuniquese con soporte técnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
        Catch ex As Exception
            MessageBox.Show("Ocurrio un error al cargar la información.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(2, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
        End Try
        Return DT_Resp
    End Function
    Public Function GetListAccountsReceivableBalanceDue(ByVal Id_Company As Long) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("Operation_AccountsReceivable_BalanceDue_Select", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_Company", SqlDbType.BigInt).Value = Id_Company
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return ds.Tables("datos")
                        Catch ex As SqlException
                            MessageBox.Show("Fallo en la conexión con la base de datos, comuniquese con soporte tecnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return New DataTable("datos")
                        Catch ex As Exception
                            MessageBox.Show("Ocurrio un error al cargar la informacion.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(2, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return New DataTable("datos")
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function

    Public Function GetListAccountsPayableBalanceDue(ByVal Id_Company As Long) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("Operation_AccountsPayable_BalanceDue_Select", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_Company", SqlDbType.BigInt).Value = Id_Company
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return ds.Tables("datos")
                        Catch ex As SqlException
                            MessageBox.Show("Fallo en la conexión con la base de datos, comuniquese con soporte tecnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return New DataTable("datos")
                        Catch ex As Exception
                            MessageBox.Show("Ocurrio un error al cargar la informacion.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(2, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return New DataTable("datos")
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function
    Public Function GetNumberOfOrder(ByVal ID_Customer As Integer) As Integer
        Dim resp As Integer = 0
        Dim ds As New DataSet("Data")
        Try
            Using da As New SqlDataAdapter("ERP_SP_Inventory_GetNumberOfOrder", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@ID_Customer_FK", ID_Customer)
                da.Fill(ds, 0)
                resp = ds.Tables(0).Rows(0).Item("ID")
            End Using
        Catch ex As SqlException

        Catch ex As Exception

        End Try
        Return resp
    End Function
    Public Function GetMaxNumberOfOrder() As Integer
        Dim resp As Integer = 0
        Dim ds As New DataSet("Data")
        Try
            Using da As New SqlDataAdapter("ERP_SP_Inventory_GetMaxNumberOfOrder", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.Fill(ds, 0)
                resp = ds.Tables(0).Rows(0).Item("ID")
            End Using
        Catch ex As SqlException

        Catch ex As Exception

        End Try
        Return resp
    End Function

    Public Function SaveOrder(ByVal ID_Company As Long, ByVal ID_Order As Long, ID_Customer As Long, ByVal ID_Product As Long, ByVal Quantity As Double) As Integer
        Dim resp As Integer = 0
        Dim ds As New DataSet("Data")
        Try
            Using da As New SqlDataAdapter("ERP_SP_Inventory_SavePurchaseOrders", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@ID_PurchaseOrder", ID_Order)
                da.SelectCommand.Parameters.AddWithValue("@ID_Customer_FK", ID_Customer)
                da.SelectCommand.Parameters.AddWithValue("@ID_Product_FK", ID_Product)
                da.SelectCommand.Parameters.AddWithValue("@Quantity", Quantity)
                da.SelectCommand.Parameters.AddWithValue("@ID_Estate", 0)
                da.SelectCommand.Parameters.AddWithValue("@ID_Company", ID_Company)

                da.Fill(ds, 0)
                resp = 1
            End Using
        Catch ex As SqlException

        Catch ex As Exception

        End Try
        Return resp
    End Function

    Public Function UpdateStateOrder(ByVal ID_Company As Long, ByVal ID_Order As Long, ByVal ID_Estate As Integer)
        Dim resp As Integer = 0
        Dim ds As New DataSet("Data")
        Try
            Using da As New SqlDataAdapter("ERP_SP_Inventory_UpdateStatePurchaseOrders", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@Id_Company", ID_Company)
                da.SelectCommand.Parameters.AddWithValue("@Id_Orden", ID_Order)
                da.SelectCommand.Parameters.AddWithValue("@estado", ID_Estate)
                da.Fill(ds, 0)
                resp = 1

            End Using
        Catch ex As SqlException

        Catch ex As Exception

        End Try
        Return resp
    End Function

    Public Function AddInventory(ByVal ID_Header As Long, ByVal ID_Company As Integer, ByVal ID_CustomerMaster As Integer, ByVal BarCode As String, ByVal Total As Integer, ByVal Type As Integer) As Integer
        Dim resp As Integer = 0
        Dim ds As New DataSet("Data")
        Try
            Using da As New SqlDataAdapter("SP_ERP_InventoryAdmin", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure

                da.SelectCommand.Parameters.AddWithValue("@ID_Header_FK", ID_Header)
                da.SelectCommand.Parameters.AddWithValue("@ID_Company", ID_Company)
                da.SelectCommand.Parameters.AddWithValue("@ID_CustomerMaster", ID_CustomerMaster)
                da.SelectCommand.Parameters.AddWithValue("@BarCode", BarCode)
                da.SelectCommand.Parameters.AddWithValue("@Total", Total)
                da.SelectCommand.Parameters.AddWithValue("@Type", Type)
                da.Fill(ds, "Update")
                resp = ds.Tables("Update").Rows(0).Item("resp")
            End Using
        Catch ex As SqlException

        Catch ex As Exception

        End Try
        Return resp
    End Function

    Public Function AddHeaderImputsAndOutputs(ByVal ID_Company As Long, ByVal Autorizo As String, ByVal Comentario As String) As Integer
        Dim resp As Integer = 0
        Dim ds As New DataSet("Data")
        Try
            Using da As New SqlDataAdapter("ERP_SP_Inventory_SaveheaderInputsAndOutputs", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@ID_Company", ID_Company)
                da.SelectCommand.Parameters.AddWithValue("@Autorizo", Autorizo)
                da.SelectCommand.Parameters.AddWithValue("@Comentario", Comentario)
                da.Fill(ds, "Insert")
                resp = ds.Tables("Insert").Rows(0).Item("ID")
            End Using
        Catch ex As SqlException

        Catch ex As Exception

        End Try
        Return resp
    End Function

#Region "Calendario cuentas por cobrar"
    Public Function AddAccountsPayable(ByVal ID_Company_FK As Integer, ByVal ID_Customer_FK As Integer, ByVal ID_TypeDocument_FK As Integer, ByVal DocumentNumber As Long, ByVal SaldoDeudor As Double, ByVal AmountOfFees As Integer, ByVal DateInit As Date, ByVal PaymentType_FK As Integer, ByVal CreditDescription As String) As Long
        Dim resp As Integer = 0
        Dim ds As New DataSet("data")
        Try
            Using da As New SqlDataAdapter("ERP_AP_AddAccountPayable", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@ID_Company_FK", ID_Company_FK)
                da.SelectCommand.Parameters.AddWithValue("@ID_Customer_FK", ID_Customer_FK)
                da.SelectCommand.Parameters.AddWithValue("@ID_TypeDocument_FK", ID_TypeDocument_FK)
                da.SelectCommand.Parameters.AddWithValue("@DocumentNumber", DocumentNumber)
                da.SelectCommand.Parameters.AddWithValue("@SaldoDeudor", SaldoDeudor)
                da.SelectCommand.Parameters.AddWithValue("@AmountOfFees", AmountOfFees)
                da.SelectCommand.Parameters.AddWithValue("@DateInit", DateInit)
                da.SelectCommand.Parameters.AddWithValue("@PaymentType_FK", PaymentType_FK)
                da.SelectCommand.Parameters.AddWithValue("@Credit_Description", CreditDescription)
                da.Fill(ds, "AddAccounts")
                resp = ds.Tables("AddAccounts").Rows(0).Item("ID")
            End Using
        Catch ex As SqlException
            MessageBox.Show("Fallo en la conexión con la base de datos, comuniquese con soporte tecnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
            Return resp
        Catch ex As Exception
            MessageBox.Show("Ocurrio un error al cargar la informacion.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(2, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
            Return resp
        End Try
        Return resp
    End Function

    Public Function GetQuotasAccountsReceivable(ByVal Id_company As Long) As DataTable
        Dim DT_Resp As New DataTable
        Dim ds As New DataSet("data")
        Try
            Using da As New SqlDataAdapter("ERP_AR_GetQuotas", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@Id_Company", Id_company)
                da.Fill(ds, "Quotas")
                DT_Resp = ds.Tables("Quotas")
            End Using
        Catch ex As SqlException
            MessageBox.Show("Fallo en la conexión con la base de datos, comuniquese con soporte técnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
        Catch ex As Exception
            MessageBox.Show("Ocurrio un error al cargar la información.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(2, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
        End Try
        Return DT_Resp
    End Function

    Public Function GetAccountsPayableList(ByVal ID_Company) As DataTable
        Dim DT_Resp As New DataTable
        Dim ds As New DataSet("data")
        Try
            Using da As New SqlDataAdapter("ERP_AP_AccountsPayableList", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@Id_Company", ID_Company)
                da.Fill(ds, "Quotas")
                DT_Resp = ds.Tables("Quotas")
            End Using
        Catch ex As SqlException
            MessageBox.Show("Fallo en la conexión con la base de datos, comuniquese con soporte técnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
        Catch ex As Exception
            MessageBox.Show("Ocurrio un error al cargar la información.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(2, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
        End Try
        Return DT_Resp
    End Function
    Public Function GetQuotasdaysAccountReceivable(ByVal Id_company As Long, ByVal Fecha As Date) As DataTable
        Dim DT_Resp As New DataTable
        Dim ds As New DataSet("data")
        Try
            Using da As New SqlDataAdapter("ERP_AR_GetQuotasbyday", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@Id_Company", Id_company)
                da.SelectCommand.Parameters.AddWithValue("@Fecha", Fecha)
                da.Fill(ds, "Quotas")
                DT_Resp = ds.Tables("Quotas")
            End Using
        Catch ex As SqlException
            MessageBox.Show("Fallo en la conexión con la base de datos, comuniquese con soporte técnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
        Catch ex As Exception
            MessageBox.Show("Ocurrio un error al cargar la información.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(2, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
        End Try
        Return DT_Resp
    End Function

    Public Function GetQuotasdaysAccountPayable(ByVal Id_company As Long, ByVal Fecha As Date) As DataTable
        Dim DT_Resp As New DataTable
        Dim ds As New DataSet("data")
        Try
            Using da As New SqlDataAdapter("ERP_AP_GetQuotasbyday", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@Id_Company", Id_company)
                da.SelectCommand.Parameters.AddWithValue("@Fecha", Fecha)
                da.Fill(ds, "Quotas")
                DT_Resp = ds.Tables("Quotas")
            End Using
        Catch ex As SqlException
            MessageBox.Show("Fallo en la conexión con la base de datos, comuniquese con soporte técnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
        Catch ex As Exception
            MessageBox.Show("Ocurrio un error al cargar la información.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(2, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
        End Try
        Return DT_Resp
    End Function
#End Region

#Region "Cuentas por cobrar"
    Public Function GetQuotasAccountsPayable(ByVal Id_company As Long) As DataTable
        Dim DT_Resp As New DataTable
        Dim ds As New DataSet("data")
        Try
            Using da As New SqlDataAdapter("ERP_AP_GetQuotas", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@Id_Company", Id_company)
                da.Fill(ds, "Quotas")
                DT_Resp = ds.Tables("Quotas")
            End Using
        Catch ex As SqlException
            MessageBox.Show("Fallo en la conexión con la base de datos, comuniquese con soporte técnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
        Catch ex As Exception
            MessageBox.Show("Ocurrio un error al cargar la información.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(2, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
        End Try
        Return DT_Resp
    End Function

#End Region

#Region "Centro de costo"

    Public Function GetCostCenter(ByVal Id_company As Long) As DataTable
        Dim DT_Resp As New DataTable
        Dim ds As New DataSet("data")
        Try
            Using da As New SqlDataAdapter("ERP_RRHH_GetCostCenter", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@Id_Company", Id_company)
                da.Fill(ds, "datos")
                DT_Resp = ds.Tables("datos")
            End Using
        Catch ex As SqlException
            MessageBox.Show("Fallo en la conexión con la base de datos, comuniquese con soporte técnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
        Catch ex As Exception
            MessageBox.Show("Ocurrio un error al cargar la información.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(2, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
        End Try
        Return DT_Resp
    End Function

#End Region

#Region "Crear Campos Dinamicos"
    Public Function Campos(ByVal ID_Proceso As Long) As DataTable
        Dim ds As New DataSet
        Dim dt As New DataTable
        Try
            Using da As New SqlDataAdapter("ERP_Prod_SP_Campos_GetCampos", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@ID_Process", ID_Proceso)
                da.Fill(ds, "data")
            End Using
            If ds.Tables.Count > 0 Then
                dt = ds.Tables(0)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return dt
    End Function


    Public Function AddRegistro(ByVal Query As String) As String
        Dim ds As New DataSet
        Dim resp As String = ""
        Try
            Using da As New SqlDataAdapter("ERP_SP_Prod_Form_AddRegistro", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@Query", Query)
                da.Fill(ds, "data")
            End Using
            If ds.Tables.Count > 0 Then
                If ds.Tables(0).Rows.Count > 0 Then
                    resp = ds.Tables(0).Rows(0).Item("resp")
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return resp
    End Function

#End Region
#Region "Banco"

    Public Function Generic_GetBankCatalog(ByVal Id_company As Long) As DataTable
        Dim ds As New DataSet
        Dim dt As New DataTable
        Try
            Using da As New SqlDataAdapter("ERP_Generic_SP_GetBankCatalog", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@Id_company_FK", Id_company)
                da.Fill(ds, "data")
            End Using
            If ds.Tables.Count > 0 Then
                dt = ds.Tables(0)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return dt
    End Function
#End Region

#Region "Lot"
    Public Function GetLotes(ByVal id_Company As Long, ByVal porcentaje As Double, ByVal grupo As String, ByVal Ciclo As Long) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_Prod_SP_Select_GetDataLote_Indicators", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_Company", SqlDbType.BigInt).Value = id_Company
                cmd.Parameters.Add("@PorcentajeAnimalesVacio", SqlDbType.BigInt).Value = porcentaje
                cmd.Parameters.Add("@Group", SqlDbType.VarChar).Value = grupo
                cmd.Parameters.Add("@Ciclo", SqlDbType.BigInt).Value = Ciclo
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

    Public Function GetLotesVacio(ByVal id_Company As Long) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_Prod_SP_Select_GetDataLote_Vacio", conn)
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

    Public Function GetModelo(ByVal id_Company As Long) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("[ERP_SP_GetModelo]", conn)
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

    Public Function GetModelo(ByVal id_Company As Long, ByVal busqueda As String) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("[ERP_SP_GetModelo_LIKE]", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_Company", SqlDbType.BigInt).Value = id_Company
                cmd.Parameters.Add("@busqueda", SqlDbType.VarChar).Value = busqueda
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
#End Region

#Region "Mantenimiento Animales"
    Public Function GetAnimalsList(ByVal _tipoConsulta As Integer, ByVal _codigoAnimal As String) As DataTable

        Dim dt As New DataTable
        Dim ds As New DataSet("data")
        Try
            Using da As New SqlDataAdapter("ERP_Production_SelectAnimal", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@tipoconsulta", _tipoConsulta)
                da.SelectCommand.Parameters.AddWithValue("@animalcode", _codigoAnimal)
                da.Fill(ds, "AnimalList")
            End Using
            dt = ds.Tables("AnimalList")
        Catch ex As SqlException
            MessageBox.Show("Fallo en la conexión con la base de datos, comuniquese con soporte tecnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
            Return New DataTable("datos")
        Catch ex As Exception
            MessageBox.Show("Ocurrio un error al cargar la informacion.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(2, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
            Return New DataTable("datos")
        End Try
        Return dt
    End Function

    Public Function AddAnimals(ByVal AnimalGroup As Long, ByVal CodigoAnimal As String, ByVal NombreAnimal As String, ByVal FechaProceso As String, ByVal CicloAnimal As Integer, ByVal RegistryAnimal As String, ByVal Genetic As Integer, ByVal BirthDate As String, ByVal CodigoCamada As Integer, ByVal TipoOrigen As Integer, ByVal Origen As Integer, ByVal StartPlace As String, ByVal padre As String, ByVal madre As String, ByVal Peso As Double, ByVal Precio As Double, ByVal Comentarios As String) As String
        Dim resp As String
        Dim ds As New DataSet("data")
        Try
            Using da As New SqlDataAdapter("ERP_Production_InsertAnimal", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@ID_Grupo", AnimalGroup)
                da.SelectCommand.Parameters.AddWithValue("@AnimalCode", CodigoAnimal)
                da.SelectCommand.Parameters.AddWithValue("@AnimalName", NombreAnimal)
                da.SelectCommand.Parameters.AddWithValue("@DateProcess", FechaProceso)
                da.SelectCommand.Parameters.AddWithValue("@AnimalCycle", CicloAnimal)
                da.SelectCommand.Parameters.AddWithValue("@RegistryAnimal", RegistryAnimal)
                da.SelectCommand.Parameters.AddWithValue("@Genetic", Genetic)
                da.SelectCommand.Parameters.AddWithValue("@BirthDate", BirthDate)
                da.SelectCommand.Parameters.AddWithValue("@litterCode", CodigoCamada)
                da.SelectCommand.Parameters.AddWithValue("@OriginType", TipoOrigen)
                da.SelectCommand.Parameters.AddWithValue("@StartPlace", StartPlace)
                da.SelectCommand.Parameters.AddWithValue("@Origin", Origen)
                da.SelectCommand.Parameters.AddWithValue("@Father", padre)
                da.SelectCommand.Parameters.AddWithValue("@Mother", madre)
                da.SelectCommand.Parameters.AddWithValue("@Weight", Peso)
                da.SelectCommand.Parameters.AddWithValue("@Price", Precio)
                da.SelectCommand.Parameters.AddWithValue("@CommentAnimal", Comentarios)
                da.Fill(ds, "AddAnimals")
                resp = ds.Tables("AddAnimals").Rows(0).Item("resp")
            End Using
        Catch ex As SqlException
            MessageBox.Show("Fallo en la conexión con la base de datos, comuniquese con soporte tecnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
            Return resp
        Catch ex As Exception
            MessageBox.Show("Ocurrio un error al cargar la informacion.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(2, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
            Return resp
        End Try
        Return resp
    End Function

    Public Function UpdateAnimals(ByVal AnimalGroup As Long, ByVal id As Integer, ByVal CodigoAnimal As String, ByVal NombreAnimal As String, ByVal FechaProceso As String, ByVal CicloAnimal As Integer, ByVal RegistryAnimal As String, ByVal Genetic As Integer, ByVal BirthDate As String, ByVal CodigoCamada As Integer, ByVal TipoOrigen As Integer, ByVal Origen As Integer, ByVal StartPlace As String, ByVal padre As String, ByVal madre As String, ByVal Peso As Double, ByVal Precio As Double, ByVal Comentarios As String) As String
        Dim resp As String
        Dim ds As New DataSet("data")
        Try
            Using da As New SqlDataAdapter("ERP_Production_UpdateAnimal", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@ID_Grupo", AnimalGroup)
                da.SelectCommand.Parameters.AddWithValue("@IDAnimal", id)
                da.SelectCommand.Parameters.AddWithValue("@AnimalCode", CodigoAnimal)
                da.SelectCommand.Parameters.AddWithValue("@AnimalName", NombreAnimal)
                da.SelectCommand.Parameters.AddWithValue("@DateProcess", FechaProceso)
                da.SelectCommand.Parameters.AddWithValue("@AnimalCycle", CicloAnimal)
                da.SelectCommand.Parameters.AddWithValue("@RegistryAnimal", RegistryAnimal)
                da.SelectCommand.Parameters.AddWithValue("@Genetic", Genetic)
                da.SelectCommand.Parameters.AddWithValue("@BirthDate", BirthDate)
                da.SelectCommand.Parameters.AddWithValue("@litterCode", CodigoCamada)
                da.SelectCommand.Parameters.AddWithValue("@OriginType", TipoOrigen)
                da.SelectCommand.Parameters.AddWithValue("@StartPlace", StartPlace)
                da.SelectCommand.Parameters.AddWithValue("@Origin", Origen)
                da.SelectCommand.Parameters.AddWithValue("@Father", padre)
                da.SelectCommand.Parameters.AddWithValue("@Mother", madre)
                da.SelectCommand.Parameters.AddWithValue("@Weight", Peso)
                da.SelectCommand.Parameters.AddWithValue("@Price", Precio)
                da.SelectCommand.Parameters.AddWithValue("@CommentAnimal", Comentarios)
                da.Fill(ds, "UpdateAnimals")
                resp = ds.Tables("UpdateAnimals").Rows(0).Item("resp")
            End Using
        Catch ex As SqlException
            MessageBox.Show("Fallo en la conexión con la base de datos, comuniquese con soporte tecnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
            Return resp
        Catch ex As Exception
            MessageBox.Show("Ocurrio un error al cargar la informacion.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(2, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
            Return resp
        End Try
        Return resp
    End Function

    Public Function DeleteAnimals(ByVal id As Integer) As String
        Dim resp As String
        Dim ds As New DataSet("data")
        Try
            Using da As New SqlDataAdapter("ERP_Production_DeleteAnimal", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@IDAnimal", id)

                da.Fill(ds, "DeleteAnimals")
                resp = ds.Tables("DeleteAnimals").Rows(0).Item("resp")
            End Using
        Catch ex As SqlException
            MessageBox.Show("Fallo en la conexión con la base de datos, comuniquese con soporte tecnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
            Return resp
        Catch ex As Exception
            MessageBox.Show("Ocurrio un error al cargar la informacion.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(2, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
            Return resp
        End Try
        Return resp
    End Function

    Public Function GetCicles() As DataTable
        Dim dt As DataTable
        Dim ds As New DataSet("CiclosList")
        Try
            Using da As New SqlDataAdapter("ERP_Production_SelectCiclos", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.Fill(ds, "CiclosList")
            End Using
            dt = ds.Tables("CiclosList")
        Catch ex As SqlException
            MessageBox.Show("Fallo en la conexión con la base de datos, comuniquese con soporte tecnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
        Catch ex As Exception
            MessageBox.Show("Ocurrio un error al cargar la informacion.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(2, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
        End Try
        Return dt
    End Function

#End Region

#Region "Mantenimiento Marcas"

    Public Function InsertMarca(ByVal id_Company As Long, ByVal description As String, ByVal is_FixedAssets As Boolean, ByVal is_Products As Boolean) As String
        Dim resp As String = ""
        Dim ds As New DataSet("data")
        Try
            Using da As New SqlDataAdapter("ERP_Maintenance_InsertBranch", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@id_Company", id_Company)
                da.SelectCommand.Parameters.AddWithValue("@Descripcion", description)
                da.SelectCommand.Parameters.AddWithValue("@is_FixedAssets", is_FixedAssets)
                da.SelectCommand.Parameters.AddWithValue("@is_Products", is_Products)
                da.Fill(ds, "AddMarcas")
                resp = ds.Tables("AddMarcas").Rows(0).Item("resp")
            End Using
        Catch ex As SqlException
            MessageBox.Show("Fallo en la conexión con la base de datos, comuniquese con soporte tecnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
            Return resp

        Catch ex As Exception
            MessageBox.Show("Ocurrio un error al cargar la informacion.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(2, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)


            Return resp
        End Try
        Return resp
    End Function

    Public Function SetMarca(ByVal id_Company As Long, ByVal id_Marca As Long, ByVal description As String, ByVal is_FixedAssets As Boolean, ByVal is_Products As Boolean) As String
        Dim resp As String = ""
        Dim ds As New DataSet("data")
        Try
            Using da As New SqlDataAdapter("ERP_Maintenance_UpdateBranch", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@id_Branch", id_Marca)
                da.SelectCommand.Parameters.AddWithValue("@id_Company", id_Company)
                da.SelectCommand.Parameters.AddWithValue("@Description", description)
                da.SelectCommand.Parameters.AddWithValue("@is_FixedAssets", is_FixedAssets)
                da.SelectCommand.Parameters.AddWithValue("@is_Products", is_Products)
                da.Fill(ds, "AddMarcas")
                resp = ds.Tables("AddMarcas").Rows(0).Item("resp")
            End Using
        Catch ex As SqlException
            MessageBox.Show("Fallo en la conexión con la base de datos, comuniquese con soporte tecnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
            Return resp

        Catch ex As Exception
            MessageBox.Show("Ocurrio un error al cargar la informacion.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(2, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
            Return resp


        End Try
        Return resp
    End Function

    Public Function SetMarcaFijoProducto(ByVal id_Company As Long, ByVal id_Marca As Long, ByVal is_FixedAssets As Boolean, ByVal is_Products As Boolean) As String
        Dim resp As String = ""
        Dim ds As New DataSet("data")
        Try
            Using da As New SqlDataAdapter("ERP_Maintenance_UpdateBranchProcess", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@id_Company", id_Company)
                da.SelectCommand.Parameters.AddWithValue("@id_Branch", id_Marca)
                da.SelectCommand.Parameters.AddWithValue("@is_FixedAssets", is_FixedAssets)
                da.SelectCommand.Parameters.AddWithValue("@is_Products", is_Products)
                da.Fill(ds, "AddMarcas")
                resp = ds.Tables("AddMarcas").Rows(0).Item("resp")
            End Using
        Catch ex As SqlException
            MessageBox.Show("Fallo en la conexión con la base de datos, comuniquese con soporte tecnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
            Return resp

        Catch ex As Exception
            MessageBox.Show("Ocurrio un error al cargar la informacion.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(2, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
            Return resp


        End Try
        Return resp
    End Function

    Public Function DeleteMarca(ByVal id_Company As Long, ByVal id_Marca As Long) As String
        Dim resp As String = ""
        Dim ds As New DataSet("data")
        Try
            Using da As New SqlDataAdapter("ERP_Maintenance_DeleteBranch", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@id_Branch", id_Marca)
                da.SelectCommand.Parameters.AddWithValue("@id_Company", id_Company)
                da.Fill(ds, "DeleteMarcas")
                resp = ds.Tables("DeleteMarcas").Rows(0).Item("resp")
            End Using
        Catch ex As SqlException
            MessageBox.Show("Fallo en la conexión con la base de datos, comuniquese con soporte técnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
            Return "EX|" + ex.ToString

        Catch ex As Exception
            MessageBox.Show("Ocurrio un error al cargar la información.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(2, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
            Return "EX|" + ex.ToString


        End Try
        Return resp
    End Function


#End Region

#Region "Mantenimiento Categorias"

    Public Function InsertCategoria(ByVal id_Company As Long, ByVal description As String, ByVal ledgerCodeProduct As String, ByVal ledgerAccountNumber As String) As String
        Dim resp As String = ""
        Dim ds As New DataSet("data")
        Try
            Using da As New SqlDataAdapter("ERP_Maintenance_InsertInventoryCategory", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@id_Company", id_Company)
                da.SelectCommand.Parameters.AddWithValue("@Description", description)
                da.SelectCommand.Parameters.AddWithValue("@ledgerCodeProduct", ledgerCodeProduct)
                da.SelectCommand.Parameters.AddWithValue("@ledgerAccountNumber", ledgerAccountNumber)
                da.Fill(ds, "AddCategorias")
                resp = ds.Tables("AddCategorias").Rows(0).Item("resp")
            End Using
        Catch ex As SqlException
            MessageBox.Show("Fallo en la conexión con la base de datos, comuniquese con soporte técnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
            Return "EX|" + ex.ToString

        Catch ex As Exception
            MessageBox.Show("Ocurrio un error al cargar la información.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(2, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
            Return "EX|" + ex.ToString

        End Try
        Return resp
    End Function

    Public Function SetCategoria(ByVal id_Company As Long, ByVal id_Category As Long, ByVal description As String, ByVal ledgerCodeProduct As String, ByVal ledgerAccountNumber As String) As String
        Dim resp As String
        Dim ds As New DataSet("data")
        Try
            Using da As New SqlDataAdapter("ERP_Maintenance_UpdateInventoryCategory", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@id_inventoryCategory", id_Category)
                da.SelectCommand.Parameters.AddWithValue("@id_Company", id_Company)
                da.SelectCommand.Parameters.AddWithValue("@Description", description)
                da.SelectCommand.Parameters.AddWithValue("@ledgerCodeProduct", ledgerCodeProduct)
                da.SelectCommand.Parameters.AddWithValue("@ledgerAccountNumber", ledgerAccountNumber)
                da.Fill(ds, "SetCategoria")
                resp = ds.Tables("SetCategoria").Rows(0).Item("resp")
            End Using
        Catch ex As SqlException
            MessageBox.Show("Fallo en la conexión con la base de datos, comuniquese con soporte técnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
            Return "EX|" & ex.ToString

        Catch ex As Exception
            MessageBox.Show("Ocurrio un error al cargar la información.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(2, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
            Return "EX|" & ex.ToString

        End Try
        Return resp
    End Function

    Public Function DeleteCategoria(ByVal id_Company As Long, ByVal id_Categoria As Long) As String
        Dim resp As String = ""
        Dim ds As New DataSet("data")
        Try
            Using da As New SqlDataAdapter("ERP_Maintenance_DeleteInventoryCategory", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@id_inventoryCategory", id_Categoria)
                da.SelectCommand.Parameters.AddWithValue("@id_Company", id_Company)
                da.Fill(ds, "DeleteCategoria")
                resp = ds.Tables("DeleteCategoria").Rows(0).Item("resp")
            End Using
        Catch ex As SqlException
            MessageBox.Show("Fallo en la conexión con la base de datos, comuniquese con soporte técnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
            Return "EX|" + ex.ToString

        Catch ex As Exception
            MessageBox.Show("Ocurrio un error al cargar la información.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(2, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
            Return "EX|" + ex.ToString


        End Try
        Return resp
    End Function

#End Region

#Region "Mantenimiento Lineas"


    Public Function GetLines(ByVal id_Company As Long) As DataTable
        Dim dt As DataTable
        Dim ds As New DataSet("LinesList")
        Try
            Using da As New SqlDataAdapter("ERP_Maintenance_SelectInventoryLine", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@id_Company", id_Company)
                da.Fill(ds, "LinesList")
            End Using
            dt = ds.Tables("LinesList")
        Catch ex As SqlException
            MessageBox.Show("Fallo en la conexión con la base de datos, comuniquese con soporte técnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
        Catch ex As Exception
            MessageBox.Show("Ocurrio un error al cargar la información.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(2, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
        End Try
        Return dt
    End Function

    Public Function GetLines(ByVal id_Company As Long, ByVal busqueda As String) As DataTable
        Dim dt As DataTable
        Dim ds As New DataSet("LinesList")
        Try
            Using da As New SqlDataAdapter("[ERP_Maintenance_SelectInventoryLine_LIKE]", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@id_Company", id_Company)
                da.SelectCommand.Parameters.AddWithValue("@busqueda", busqueda)
                da.Fill(ds, "LinesList")
            End Using
            dt = ds.Tables("LinesList")
        Catch ex As SqlException
            MessageBox.Show("Fallo en la conexión con la base de datos, comuniquese con soporte técnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
        Catch ex As Exception
            MessageBox.Show("Ocurrio un error al cargar la información.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(2, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
        End Try
        Return dt
    End Function


    Public Function InsertLinea(ByVal id_Company As Long, ByVal id_Category As Long, ByVal description As String) As String
        Dim resp As String = ""
        Dim ds As New DataSet("Linea")
        Try
            Using da As New SqlDataAdapter("ERP_Maintenance_InsertInventoryLine", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@id_Company", id_Company)
                da.SelectCommand.Parameters.AddWithValue("@id_Category", id_Category)
                da.SelectCommand.Parameters.AddWithValue("@Description", description)
                da.Fill(ds, "AddLinea")
                resp = ds.Tables("AddLinea").Rows(0).Item("resp")
            End Using
        Catch ex As SqlException
            MessageBox.Show("Fallo en la conexión con la base de datos, comuniquese con soporte técnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
            Return "EX|" + ex.ToString

        Catch ex As Exception
            MessageBox.Show("Ocurrio un error al cargar la información.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(2, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
            Return "EX|" + ex.ToString


        End Try
        Return resp
    End Function

    Public Function SetLinea(ByVal id_Company As Long, ByVal id_Line As Long, ByVal id_Category As Long, ByVal description As String) As String
        Dim resp As String = ""
        Dim ds As New DataSet("SetLinea")
        Try
            Using da As New SqlDataAdapter("ERP_Maintenance_UpdateInventoryLine", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@id_Category", id_Category)
                da.SelectCommand.Parameters.AddWithValue("@id_Line", id_Line)
                da.SelectCommand.Parameters.AddWithValue("@id_Company", id_Company)
                da.SelectCommand.Parameters.AddWithValue("@Description", description)
                da.Fill(ds, "SetLinea")
                resp = ds.Tables("SetLinea").Rows(0).Item("resp")
            End Using
        Catch ex As SqlException
            MessageBox.Show("Fallo en la conexión con la base de datos, comuniquese con soporte técnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
            Return "EX|" + ex.ToString

        Catch ex As Exception
            MessageBox.Show("Ocurrio un error al cargar la información.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(2, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
            Return "EX|" + ex.ToString


        End Try
        Return resp
    End Function

    Public Function DeleteLinea(ByVal id_Company As Long, ByVal id_Linea As Long) As String
        Dim resp As String
        Dim ds As New DataSet("SetLinea")
        Try
            Using da As New SqlDataAdapter("ERP_Maintenance_DeleteInventoryLine", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@id_Line", id_Linea)
                da.SelectCommand.Parameters.AddWithValue("@id_Company", id_Company)
                da.Fill(ds, "DeleteLinea")
                resp = ds.Tables("DeleteLinea").Rows(0).Item("resp")
            End Using
        Catch ex As SqlException
            MessageBox.Show("Fallo en la conexión con la base de datos, comuniquese con soporte técnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
            Return "EX|" + ex.ToString

        Catch ex As Exception
            MessageBox.Show("Ocurrio un error al cargar la información.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(2, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
            Return "EX|" + ex.ToString

        End Try
        Return resp
    End Function

#End Region

#Region "Mantenimiento Bodegas"


    Public Function GetStowages(ByVal id_Company As Long) As DataTable
        Dim dt As DataTable
        Dim ds As New DataSet("StowageList")
        Try
            Using da As New SqlDataAdapter("ERP_Maintenance_SelectInventoryStowage", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@id_Company", id_Company)
                da.Fill(ds, "StowageList")
            End Using
            dt = ds.Tables("StowageList")
        Catch ex As SqlException
            MessageBox.Show("Fallo en la conexión con la base de datos, comuniquese con soporte tecnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
        Catch ex As Exception
            MessageBox.Show("Ocurrio un error al cargar la informacion.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(2, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
        End Try
        Return dt
    End Function

    Public Function GetStowages(ByVal id_Company As Long, ByVal busqueda As String) As DataTable
        Dim dt As DataTable
        Dim ds As New DataSet("StowageList")
        Try
            Using da As New SqlDataAdapter("ERP_Maintenance_SelectInventoryStowage_LIKE", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@id_Company", id_Company)
                da.SelectCommand.Parameters.AddWithValue("@busqueda", busqueda)
                da.Fill(ds, "StowageList")
            End Using
            dt = ds.Tables("StowageList")
        Catch ex As SqlException
            MessageBox.Show("Fallo en la conexión con la base de datos, comuniquese con soporte tecnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
        Catch ex As Exception
            MessageBox.Show("Ocurrio un error al cargar la informacion.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(2, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
        End Try
        Return dt
    End Function


    Public Function InsertStowages(ByVal id_Location As Long, ByVal description As String) As String
        Dim resp As String = ""
        Dim ds As New DataSet("Bodegas")
        Try
            Using da As New SqlDataAdapter("ERP_Maintenance_InsertInventoryStowage", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@id_Location", id_Location)
                da.SelectCommand.Parameters.AddWithValue("@Description", description)
                da.Fill(ds, "AddBodegas")
                resp = ds.Tables("AddBodegas").Rows(0).Item("resp")
            End Using
        Catch ex As SqlException
            MessageBox.Show("Fallo en la conexión con la base de datos, comuniquese con soporte tecnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
            Return resp
        Catch ex As Exception
            MessageBox.Show("Ocurrio un error al cargar la informacion.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(2, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
            Return resp
        End Try
        Return resp
    End Function

    Public Function SetStowages(ByVal id_stowage As Long, ByVal id_Location As Long, ByVal description As String) As String
        Dim resp As String = ""
        Dim ds As New DataSet("SetBodegas")
        Try
            Using da As New SqlDataAdapter("ERP_Maintenance_UpdateInventoryStowage", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@id_stowage", id_stowage)
                da.SelectCommand.Parameters.AddWithValue("@id_Location", id_Location)
                da.SelectCommand.Parameters.AddWithValue("@Description", description)
                da.Fill(ds, "SetBodegas")
                resp = ds.Tables("SetBodegas").Rows(0).Item("resp")
            End Using
        Catch ex As SqlException
            MessageBox.Show("Fallo en la conexión con la base de datos, comuniquese con soporte técnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
            Return "EX|" + ex.ToString

        Catch ex As Exception
            MessageBox.Show("Ocurrio un error al cargar la información.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(2, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
            Return "EX|" + ex.ToString

        End Try
        Return resp
    End Function


    Public Function DeleteStowages(ByVal id_Company As Long, ByVal id_Stowage As Long) As String
        Dim resp As String = ""
        Dim ds As New DataSet("DeleteStowage")
        Try
            Using da As New SqlDataAdapter("ERP_Maintenance_DeleteInventoryStowage", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@id_Stowage", id_Stowage)
                da.Fill(ds, "DeleteStowage")
                resp = ds.Tables("DeleteStowage").Rows(0).Item("resp")
            End Using
        Catch ex As SqlException
            MessageBox.Show("Fallo en la conexión con la base de datos, comuniquese con soporte técnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
            Return "EX|" + ex.ToString

        Catch ex As Exception
            MessageBox.Show("Ocurrio un error al cargar la información.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(2, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
            Return "EX|" + ex.ToString

        End Try
        Return resp
    End Function


#End Region

#Region "Mantenimiento Location"


    Public Function GetLocation(ByVal id_Company As Long) As DataTable
        Dim dt As DataTable
        Dim ds As New DataSet("LocationList")
        Try
            Using da As New SqlDataAdapter("ERP_Maintenance_SelectInventoryLocation", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@id_Company", id_Company)
                da.Fill(ds, "LocationList")
            End Using
            dt = ds.Tables("LocationList")
        Catch ex As SqlException
            MessageBox.Show("Fallo en la conexión con la base de datos, comuniquese con soporte tecnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
        Catch ex As Exception
            MessageBox.Show("Ocurrio un error al cargar la informacion.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(2, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
        End Try
        Return dt
    End Function

    Public Function GetLocationStowage(ByVal id_Company As Long) As DataTable
        Dim dt As DataTable
        Dim ds As New DataSet("LocationList")
        Try
            Using da As New SqlDataAdapter("ERP_Maintenance_SelectInventoryLocationStowage", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@id_Company", id_Company)
                da.Fill(ds, "LocationList")
            End Using
            dt = ds.Tables("LocationList")
        Catch ex As SqlException
            MessageBox.Show("Fallo en la conexión con la base de datos, comuniquese con soporte tecnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
        Catch ex As Exception
            MessageBox.Show("Ocurrio un error al cargar la informacion.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(2, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
        End Try
        Return dt
    End Function

    Public Function GetLocation(ByVal id_Company As Long, ByVal busqueda As String) As DataTable
        Dim dt As DataTable
        Dim ds As New DataSet("LocationList")
        Try
            Using da As New SqlDataAdapter("ERP_Maintenance_SelectInventoryLocation_LIKE", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@id_Company", id_Company)
                da.SelectCommand.Parameters.AddWithValue("@busqueda", busqueda)
                da.Fill(ds, "LocationList")
            End Using
            dt = ds.Tables("LocationList")
        Catch ex As SqlException
            MessageBox.Show("Fallo en la conexión con la base de datos, comuniquese con soporte tecnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
        Catch ex As Exception
            MessageBox.Show("Ocurrio un error al cargar la informacion.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(2, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
        End Try
        Return dt
    End Function

    Public Function InsertLocation(ByVal id_Company As Long, ByVal id_municipality As Long, ByVal description As String) As String
        Dim resp As String
        Dim ds As New DataSet("Location")
        Try
            Using da As New SqlDataAdapter("ERP_Maintenance_InsertInventoryLocation", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@id_company", id_Company)
                da.SelectCommand.Parameters.AddWithValue("@Id_Municipality", id_municipality)
                da.SelectCommand.Parameters.AddWithValue("@Description", description)
                da.Fill(ds, "AddLocation")
                resp = ds.Tables("AddLocation").Rows(0).Item("resp")
            End Using
        Catch ex As SqlException
            MessageBox.Show("Fallo en la conexión con la base de datos, comuniquese con soporte tecnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
            Return resp
        Catch ex As Exception
            MessageBox.Show("Ocurrio un error al cargar la informacion.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(2, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
            Return resp
        End Try
        Return resp
    End Function

    Public Function SetLocation(ByVal id_Company As Long, ByVal id_Location As Long, ByVal id_municipality As Long, ByVal description As String) As String
        Dim resp As String
        Dim ds As New DataSet("SetLocation")
        Try
            Using da As New SqlDataAdapter("ERP_Maintenance_UpdateInventoryLocation", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@id_Company", id_Company)
                da.SelectCommand.Parameters.AddWithValue("@id_Location", id_Location)
                da.SelectCommand.Parameters.AddWithValue("@Id_Municipality", id_municipality)

                da.SelectCommand.Parameters.AddWithValue("@Description", description)
                da.Fill(ds, "SetLocation")
                resp = ds.Tables("SetLocation").Rows(0).Item("resp")
            End Using
        Catch ex As SqlException
            MessageBox.Show("Fallo en la conexión con la base de datos, comuniquese con soporte tecnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
            Return resp
        Catch ex As Exception
            MessageBox.Show("Ocurrio un error al cargar la informacion.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(2, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
            Return resp
        End Try
        Return resp
    End Function

    Public Function DeleteLocation(ByVal id_Company As Long, ByVal id_Location As Long) As String
        Dim resp As String
        Dim ds As New DataSet("DeleteLocation")
        Try
            Using da As New SqlDataAdapter("ERP_Maintenance_DeleteInventoryLocation", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@id_Location", id_Location)
                da.SelectCommand.Parameters.AddWithValue("@id_Company", id_Company)
                da.Fill(ds, "DeleteLocation")
                resp = ds.Tables("DeleteLocation").Rows(0).Item("resp")
            End Using
        Catch ex As SqlException
            MessageBox.Show("Fallo en la conexión con la base de datos, comuniquese con soporte tecnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
            Return resp
        Catch ex As Exception
            MessageBox.Show("Ocurrio un error al cargar la informacion.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(2, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
            Return resp
        End Try
        Return resp
    End Function

    Public Function GetMunicipalityByID(ByVal id_Company As Long, ByVal id_Department As Long) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_Generic_SP_GetMunicipalityByID", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_Company", SqlDbType.BigInt).Value = id_Company
                cmd.Parameters.Add("@Id_Department", SqlDbType.BigInt).Value = id_Department
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


#End Region

#Region "Respaldos"
    Sub query(ByVal que As String)

        Using conn As New SqlClient.SqlConnection(connStr)
            conn.Open()
            Dim cmd As SqlCommand
            cmd = New SqlCommand(que, conn)
            cmd.ExecuteNonQuery()
            conn.Close()
        End Using

    End Sub

#End Region

#Region "Mantenimiento Employee"
    Public Function GetEmployee(ByVal Id_Company As Long) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_RRHH_GetEmployee", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_Company", SqlDbType.BigInt).Value = Id_Company
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
    'funcion busqueda empleado rey
    Public Function GetEmployee(ByVal Id_Company As Long, ByVal busqueda As String) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_RRHH_GetEmployee_LIKE", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_Company", SqlDbType.BigInt).Value = Id_Company
                cmd.Parameters.Add("@busqueda", SqlDbType.VarChar).Value = busqueda
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

    Public Function GetEmployee(ByVal Id_Company As Long, ByVal Id_employee As Integer) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_RRHH_GetEmployeeResponsable", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_Company", SqlDbType.BigInt).Value = Id_Company
                cmd.Parameters.Add("@Id_employee", SqlDbType.BigInt).Value = Id_employee
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
    Public Function InsertEmpoloyee(ByVal id_Company As Long, ByVal Id_Department As Long, ByVal Id_WorkPosition As Long,
                                    ByVal Id_Location As Long, ByVal Name_Employee As String, ByVal LastName_Employee As String, ByVal DUI As String,
                                    ByVal Email As String, ByVal Telephone As String, ByVal Extension As String,
                                    ByVal Salary As String,
                                    ByVal UserSiget As String, ByVal SecondSurname_employee As String, ByVal ThridSurname_employee As String, ByVal SecondName_Employee As String, ByVal ThridName_Employee As String,
                                    ByVal id_EmployeBoss As Integer,
                                    ByVal id_Legacy_Responsable As String) As String
        Dim resp As Integer = 0
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_RRHH_InsertEmployee2", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_Company", SqlDbType.BigInt).Value = id_Company
                cmd.Parameters.Add("@Id_Deparment", SqlDbType.BigInt).Value = Id_Department
                cmd.Parameters.Add("@Id_WorkPosition", SqlDbType.BigInt).Value = Id_WorkPosition
                cmd.Parameters.Add("@Id_Location", SqlDbType.BigInt).Value = Id_Location
                cmd.Parameters.Add("@FirstName_Employee", SqlDbType.VarChar).Value = Name_Employee
                cmd.Parameters.Add("@LastName_employee", SqlDbType.VarChar).Value = LastName_Employee
                cmd.Parameters.Add("@DUI", SqlDbType.VarChar).Value = DUI
                cmd.Parameters.Add("@Email", SqlDbType.VarChar).Value = Email
                cmd.Parameters.Add("@Telephone_employee", SqlDbType.VarChar).Value = Telephone
                cmd.Parameters.Add("@Extension_employee", SqlDbType.VarChar).Value = Extension
                cmd.Parameters.Add("@Salary", SqlDbType.Money).Value = Salary

                'Campos nuevos
                cmd.Parameters.Add("@UserSiget", SqlDbType.VarChar).Value = UserSiget
                cmd.Parameters.Add("@SecondSurname_employee", SqlDbType.VarChar).Value = SecondSurname_employee
                cmd.Parameters.Add("@ThridSurname_employee", SqlDbType.VarChar).Value = ThridSurname_employee
                cmd.Parameters.Add("@SecondName_Employee", SqlDbType.VarChar).Value = SecondName_Employee
                cmd.Parameters.Add("@ThridName_Employee", SqlDbType.VarChar).Value = ThridName_Employee

                cmd.Parameters.Add("@Id_employee_Boss_FK", SqlDbType.BigInt).Value = id_EmployeBoss

                cmd.Parameters.Add("@id_Legacy_Responsable", SqlDbType.VarChar).Value = id_Legacy_Responsable

                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            resp = ds.Tables("datos").Rows(0).Item(0)
                            Return resp
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return resp
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function
    Public Function SetEmployee(ByVal Id_Employee As Long, ByVal id_Company As Long, ByVal Id_Deparment As Long, ByVal Id_WorkPosition As Long,
                                    ByVal Id_Location As Long, ByVal Name_Employee As String, ByVal LastName_Employee As String, ByVal DUI As String,
                                    ByVal Email As String, ByVal Telephone As String, ByVal Extension As String,
                                    ByVal Salary As String,
                                ByVal UserSiget As String, ByVal SecondSurname_employee As String, ByVal ThridSurname_employee As String, ByVal SecondName_Employee As String, ByVal ThridName_Employee As String,
                                ByVal id_EmployeBoss As Integer, ByVal id_Legacy_Responsable As String) As String
        Dim resp As Integer = 0
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_RRHH_SetEmployee", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_Employee", SqlDbType.BigInt).Value = Id_Employee
                cmd.Parameters.Add("@FirstName_Employee", SqlDbType.VarChar).Value = Name_Employee
                cmd.Parameters.Add("@LastName_employee", SqlDbType.VarChar).Value = LastName_Employee '1 apellido
                cmd.Parameters.Add("@Email", SqlDbType.VarChar).Value = Email
                cmd.Parameters.Add("@Id_Location", SqlDbType.BigInt).Value = Id_Location 'Ubicacion Organi
                cmd.Parameters.Add("@Id_Deparment", SqlDbType.BigInt).Value = Id_Deparment
                cmd.Parameters.Add("@Id_WorkPosition", SqlDbType.BigInt).Value = Id_WorkPosition 'Cargo

                'Campos nuevos

                cmd.Parameters.Add("@UserSiget", SqlDbType.VarChar).Value = UserSiget
                cmd.Parameters.Add("@SecondSurname_employee", SqlDbType.VarChar).Value = SecondSurname_employee
                cmd.Parameters.Add("@ThridSurname_employee", SqlDbType.VarChar).Value = ThridSurname_employee
                cmd.Parameters.Add("@SecondName_Employee", SqlDbType.VarChar).Value = SecondName_Employee
                cmd.Parameters.Add("@ThridName_Employee", SqlDbType.VarChar).Value = ThridName_Employee

                cmd.Parameters.Add("@Id_employee_Boss_FK", SqlDbType.BigInt).Value = id_EmployeBoss

                'Campos que no los requeridos
                cmd.Parameters.Add("@Id_Company", SqlDbType.BigInt).Value = id_Company
                cmd.Parameters.Add("@DUI", SqlDbType.VarChar).Value = DUI
                cmd.Parameters.Add("@Telephone_employee", SqlDbType.VarChar).Value = Telephone
                cmd.Parameters.Add("@Extension_employee", SqlDbType.VarChar).Value = Extension
                cmd.Parameters.Add("@Salary", SqlDbType.Money).Value = Salary
                cmd.Parameters.Add("@id_Legacy_Responsable", SqlDbType.VarChar).Value = id_Legacy_Responsable
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            resp = ds.Tables("datos").Rows(0).Item(0)
                            Return resp
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return resp
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function

    Public Function DelEmpoloyee(ByVal Id_employee As Long) As String
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_RRHH_DelEmployee", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_Employee", SqlDbType.BigInt).Value = Id_employee
                'cmd.Parameters.Add("@Id_Company", SqlDbType.BigInt).Value = Id_Company
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return "OK"
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "ERROR"
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function
#End Region

#Region "Mantenimiento Department"
    Public Function GetDepartment(ByVal id_Company As Long) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_RRHH_GetDepartment", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_Company", SqlDbType.BigInt).Value = id_Company
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return ds.Tables("datos")
                        Catch ex As SqlException
                            MessageBox.Show("Ocurrio un error en la conexión con la base de datos.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                        Catch ex As Exception
                            process.AlmacenarLog(5, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return New DataTable("datos")
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function

    Public Function InsertDepartment(ByVal id_Company As Long, ByVal Name_Deparment As String) As Integer
        Dim resp As Integer = 0
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_RRHH_InsertDepartment", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_Company_FK", SqlDbType.BigInt).Value = id_Company
                cmd.Parameters.Add("@Name_Department", SqlDbType.VarChar).Value = Name_Deparment
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            resp = ds.Tables("datos").Rows(0).Item(0)
                            Return resp
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return resp
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function
    Public Function SetRRHHDepartment(ByVal Id_Deparment As Long, ByVal id_Company As Long, ByVal Name_CostCenter As String) As String
        Dim resp As Integer = 0
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_RRHH_SetDepartment", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_Deparment", SqlDbType.BigInt).Value = Id_Deparment
                cmd.Parameters.Add("@Id_Company_FK", SqlDbType.BigInt).Value = id_Company
                cmd.Parameters.Add("@Name_Deparmnet", SqlDbType.VarChar).Value = Name_CostCenter
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            resp = ds.Tables("datos").Rows(0).Item(0)
                            Return resp
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return resp
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function

    Public Function DelRRHHDeparment(ByVal Id_Deparment As Long, ByVal id_Company As Long) As String
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_RRHH_DelDeparment", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_Deparment", SqlDbType.BigInt).Value = Id_Deparment
                cmd.Parameters.Add("@Id_Company_FK", SqlDbType.BigInt).Value = id_Company
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return "OK"
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "ERROR"
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function

#End Region

#Region "Mantenimiento WorkPosition"
    Public Function GetWorkPosition(ByVal Id_Company As Long) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_RRHH_GetWorkPosition", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_Company", SqlDbType.BigInt).Value = Id_Company
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

    Public Function InsertWorkPosition(ByVal id_Company As Long, ByVal Name_WorkPosition As String, ByVal Is_CustomerService As Boolean) As String
        Dim resp As Integer = 0
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_RRHH_InsertWorkPosition", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_Company_FK", SqlDbType.BigInt).Value = id_Company
                cmd.Parameters.Add("@Name_WorkPosition", SqlDbType.VarChar).Value = Name_WorkPosition
                cmd.Parameters.Add("@Is_CustomerService", SqlDbType.Bit).Value = Is_CustomerService
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            resp = ds.Tables("datos").Rows(0).Item(0)
                            Return resp
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return resp
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function

    Public Function SetWorkPosition(ByVal Id_WorkPosition As Long, ByVal id_Company As Long, ByVal Name_WorkPosition As String, ByVal Is_CustomerService As Boolean) As String
        Dim resp As Integer = 0
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_RRHH_SetWorkPosition", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_WorkPosition", SqlDbType.BigInt).Value = Id_WorkPosition
                cmd.Parameters.Add("@Id_Company_FK", SqlDbType.BigInt).Value = id_Company
                cmd.Parameters.Add("@Name_WorkPosition", SqlDbType.VarChar).Value = Name_WorkPosition
                cmd.Parameters.Add("@Is_CustomerService", SqlDbType.Bit).Value = Is_CustomerService
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            resp = ds.Tables("datos").Rows(0).Item(0)
                            Return resp
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return resp
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function

    Public Function DelWorkPosition(ByVal Id_WorkPosition As Long) As String
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_RRHH_DelWorkPosition", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_WorkPosition", SqlDbType.BigInt).Value = Id_WorkPosition
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return "OK"
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "ERROR"
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function
#End Region

#Region "Mantenimiento Location RRHH"
    Public Function GetLocationRRHH(ByVal Id_Company As Long) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_RRHH_GetLocation", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_Company", SqlDbType.BigInt).Value = Id_Company
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

    Public Function GetBossRRHH() As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_RRHH_GetBoss", conn)
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

    Public Function InsertLocationRRHH(ByVal Id_Company As Long, ByVal Name_Location As String, ByVal Address_Location As String) As String
        Dim resp As Integer = 0
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_RRHH_InsertLocation", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_Company", SqlDbType.BigInt).Value = Id_Company
                cmd.Parameters.Add("@Name_Location", SqlDbType.VarChar).Value = Name_Location
                cmd.Parameters.Add("@Address_Location", SqlDbType.VarChar).Value = Address_Location
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            resp = ds.Tables("datos").Rows(0).Item(0)
                            Return resp
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return resp
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function

    Public Function SetLocationRRHH(ByVal Id_Location As Long, ByVal Id_Company As Long, ByVal Name_Location As String, ByVal Address_Location As String) As String
        Dim resp As Integer = 0
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_RRHH_SetLocation", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_Location", SqlDbType.BigInt).Value = Id_Location
                cmd.Parameters.Add("@Id_Company", SqlDbType.BigInt).Value = Id_Company
                cmd.Parameters.Add("@Name_Location", SqlDbType.VarChar).Value = Name_Location
                cmd.Parameters.Add("@Address_Location", SqlDbType.VarChar).Value = Address_Location
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            resp = ds.Tables("datos").Rows(0).Item(0)
                            Return resp
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return resp
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function

    Public Function DelLocationRRHH(ByVal Id_Location As Long, ByVal IdCompany As Long) As String
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_RRHH_DelLocation", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_Location", SqlDbType.BigInt).Value = Id_Location
                cmd.Parameters.Add("@IdCompany", SqlDbType.BigInt).Value = IdCompany
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return "OK"
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
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
#End Region

#Region "Bank"

    Public Function GetBank(ByVal id_Company As Long) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_Generic_SP_GetBankCatalog", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_Company_FK", SqlDbType.BigInt).Value = id_Company
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

    Public Function SetBank(ByVal Id_Bank As Long, ByVal id_Company As Long, ByVal Bank_Name As String) As String
        Using conn As New SqlClient.SqlConnection(connStr)
            Dim resp As String = ""
            Using cmd As New SqlCommand("ERP_Generic_SP_SetBankCatalog", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_BankCatalog", SqlDbType.BigInt).Value = Id_Bank
                cmd.Parameters.Add("@Id_Company_FK", SqlDbType.BigInt).Value = id_Company
                cmd.Parameters.Add("@Bank_Name", SqlDbType.VarChar).Value = Bank_Name
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            resp = ds.Tables("datos").Rows(0)(0).ToString
                        Catch ex As SqlException
                            MessageBox.Show("Fallo en la conexión con la base de datos, comuniquese con soporte técnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "EX|" + ex.ToString

                        Catch ex As Exception
                            MessageBox.Show("Ocurrio un error al cargar la información.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(2, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "EX|" + ex.ToString

                        End Try
                        Return resp
                    End Using
                End Using
            End Using
        End Using
    End Function

    Public Function InsertBank(ByVal id_Company As Long, ByVal Bank_Name As String) As String
        Using conn As New SqlClient.SqlConnection(connStr)
            Dim resp As String = ""
            Using cmd As New SqlCommand("ERP_Generic_SP_InsertBankCatalog", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_Company_FK", SqlDbType.BigInt).Value = id_Company
                cmd.Parameters.Add("@Bank_Name", SqlDbType.VarChar).Value = Bank_Name
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            resp = ds.Tables("datos").Rows(0)(0).ToString
                            Return resp
                        Catch ex As SqlException
                            MessageBox.Show("Fallo en la conexión con la base de datos, comuniquese con soporte técnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "EX|" + ex.ToString

                        Catch ex As Exception
                            MessageBox.Show("Ocurrio un error al cargar la información.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(2, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "EX|" + ex.ToString

                        End Try
                        Return resp
                    End Using
                End Using
            End Using
        End Using
    End Function
    Public Function DelBank(ByVal Id_Bank As Long, ByVal id_Company As Long) As String
        Using conn As New SqlClient.SqlConnection(connStr)
            Dim resp As String = ""
            Using cmd As New SqlCommand("ERP_Generic_SP_DelBankCatalog", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_BankCatalog", SqlDbType.BigInt).Value = Id_Bank
                cmd.Parameters.Add("@Id_Company_FK", SqlDbType.BigInt).Value = id_Company
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            resp = ds.Tables("datos").Rows(0)(0).ToString
                            Return resp
                        Catch ex As SqlException
                            MessageBox.Show("Fallo en la conexión con la base de datos, comuniquese con soporte técnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "EX|" + ex.ToString

                        Catch ex As Exception
                            MessageBox.Show("Ocurrio un error al cargar la información.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(2, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "EX|" + ex.ToString

                        End Try
                        Return resp
                    End Using
                End Using
            End Using
        End Using
    End Function
#End Region

#Region "Genetic"

    Public Function GetGenetic(ByVal id_Company As Long) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_Production_SelectGenetic", conn)
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

    Public Function SetGenetic(ByVal Id_Genetic As Long, ByVal id_Company As Long, ByVal Genetic_Name As String) As String
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_Production_UpdateGenetic", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_Genetic", SqlDbType.BigInt).Value = Id_Genetic
                cmd.Parameters.Add("@Id_Company", SqlDbType.BigInt).Value = id_Company
                cmd.Parameters.Add("@Genetic_Name", SqlDbType.VarChar).Value = Genetic_Name
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return "OK"
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "ERROR"
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function
    Public Function InsertGenetic(ByVal id_Company As Long, ByVal Genetic_Name As String) As String
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_Production_InsertGenetic", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_Company", SqlDbType.BigInt).Value = id_Company
                cmd.Parameters.Add("@Genetic_Name", SqlDbType.VarChar).Value = Genetic_Name
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return "OK"
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "ERROR"
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function
    Public Function DelGenetic(ByVal Id_Genetic As Long, ByVal id_Company As Long) As String
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_Production_DeleteGenetic", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_Genetic", SqlDbType.BigInt).Value = Id_Genetic
                cmd.Parameters.Add("@Id_Company", SqlDbType.BigInt).Value = id_Company
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return "OK"
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "ERROR"
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function
#End Region

#Region "Origin Type"

    Public Function GetOriginType(ByVal id_Company As Long) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_Production_SelectTypeOrigin", conn)
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

    Public Function SetOriginType(ByVal Id_TypeOrigin As Long, ByVal id_Company As Long, ByVal TypeOrigin_Name As String) As String
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_Production_UpdateTypeOrigin", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_TypeOrigin", SqlDbType.BigInt).Value = Id_TypeOrigin
                cmd.Parameters.Add("@Id_Company", SqlDbType.BigInt).Value = id_Company
                cmd.Parameters.Add("@TypeOrigin_Name", SqlDbType.VarChar).Value = TypeOrigin_Name
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return "OK"
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "ERROR"
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function
    Public Function InsertOriginType(ByVal id_Company As Long, ByVal OriginType_Name As String) As String
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_Production_InsertTypeOrigin", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_Company", SqlDbType.BigInt).Value = id_Company
                cmd.Parameters.Add("@TypeOrigin_Name", SqlDbType.VarChar).Value = OriginType_Name
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return "OK"
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "ERROR"
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function
    Public Function DelOriginType(ByVal Id_TypeOrigin As Long, ByVal id_Company As Long) As String
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_Production_DeleteTypeOrigin", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_TypeOrigin", SqlDbType.BigInt).Value = Id_TypeOrigin
                cmd.Parameters.Add("@Id_Company", SqlDbType.BigInt).Value = id_Company
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return "OK"
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "ERROR"
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function
#End Region

#Region "Origin"

    Public Function GetOrigin(ByVal id_Company As Long) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_Production_SelectOrigin", conn)
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

    Public Function SetOrigin(ByVal Id_Origin As Long, ByVal id_Company As Long, ByVal Origin_Name As String) As String
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_Production_UpdateOrigin", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_Origin", SqlDbType.BigInt).Value = Id_Origin
                cmd.Parameters.Add("@Id_Company", SqlDbType.BigInt).Value = id_Company
                cmd.Parameters.Add("@Origin_Name", SqlDbType.VarChar).Value = Origin_Name
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return "OK"
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "ERROR"
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function
    Public Function InsertOrigin(ByVal id_Company As Long, ByVal Origin_Name As String) As String
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_Production_InsertOrigin", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_Company", SqlDbType.BigInt).Value = id_Company
                cmd.Parameters.Add("@Origin_Name", SqlDbType.VarChar).Value = Origin_Name
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return "OK"
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "ERROR"
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function
    Public Function DelOrigin(ByVal Id_TypeOrigin As Long, ByVal id_Company As Long) As String
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_Production_DeleteOrigin", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_Origin", SqlDbType.BigInt).Value = Id_TypeOrigin
                cmd.Parameters.Add("@Id_Company", SqlDbType.BigInt).Value = id_Company
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return "OK"
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "ERROR"
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function
#End Region

#Region "Category Maintenance"

    Public Function GetCategoryMaintenance(ByVal id_Company As Long) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_Generic_SelectCategoryMaintenance", conn)
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

    Public Function SetCategoryMaintenance(ByVal Id_Category As Long, ByVal Category_Name As String) As String
        Using conn As New SqlClient.SqlConnection(connStr)
            Dim resp As String = ""
            Using cmd As New SqlCommand("ERP_Generic_UpdateCategoryMaintenance", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_CategoryMaintenance", SqlDbType.BigInt).Value = Id_Category
                cmd.Parameters.Add("@CategoryMaintenanceDescription", SqlDbType.VarChar).Value = Category_Name
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            resp = ds.Tables("datos").Rows(0)(0).ToString
                            Return resp
                        Catch ex As SqlException
                            MessageBox.Show("Fallo en la conexión con la base de datos, comuniquese con soporte técnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "EX|" + ex.ToString

                        Catch ex As Exception
                            MessageBox.Show("Ocurrio un error al cargar la información.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(2, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "EX|" + ex.ToString

                        End Try
                        Return resp
                    End Using
                End Using
            End Using
        End Using
    End Function
    Public Function InsertCategoryMaintenance(ByVal Category_Name As String) As String
        Using conn As New SqlClient.SqlConnection(connStr)
            Dim resp As String = ""
            Using cmd As New SqlCommand("ERP_Generic_InsertCategoryMaintenance", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@CategoryMaintenanceDescription", SqlDbType.VarChar).Value = Category_Name
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            resp = ds.Tables("datos").Rows(0)(0).ToString
                            Return resp
                        Catch ex As SqlException
                            MessageBox.Show("Fallo en la conexión con la base de datos, comuniquese con soporte técnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "EX|" + ex.ToString

                        Catch ex As Exception
                            MessageBox.Show("Ocurrio un error al cargar la información.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(2, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "EX|" + ex.ToString

                        End Try
                        Return resp
                    End Using
                End Using
            End Using
        End Using
    End Function
    Public Function DelCategoryMaintenance(ByVal Id_Category As Long) As String
        Using conn As New SqlClient.SqlConnection(connStr)
            Dim resp As String = ""
            Using cmd As New SqlCommand("ERP_Generic_DeleteCategoryMaintenance", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_CategoryMaintenance", SqlDbType.BigInt).Value = Id_Category
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            resp = ds.Tables("datos").Rows(0)(0).ToString
                            Return resp
                        Catch ex As SqlException
                            MessageBox.Show("Fallo en la conexión con la base de datos, comuniquese con soporte técnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "EX|" + ex.ToString

                        Catch ex As Exception
                            MessageBox.Show("Ocurrio un error al cargar la información.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(2, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "EX|" + ex.ToString

                        End Try
                        Return resp
                    End Using
                End Using
            End Using
        End Using
    End Function
#End Region

#Region "Option Maintenance"

    Public Function GetOptionMaintenance(ByVal id_Company As Long) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_Generic_SelectOptionMaintenance", conn)
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

    Public Function SetOptionMaintenance(ByVal Id_Option As Long, ByVal id_Category As Long, ByVal Option_Name As String) As String
        Using conn As New SqlClient.SqlConnection(connStr)
            Dim resp As String = ""
            Using cmd As New SqlCommand("ERP_Generic_UpdateOptionMaintenance", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_OptionMaintenance", SqlDbType.BigInt).Value = Id_Option
                cmd.Parameters.Add("@Id_Category", SqlDbType.BigInt).Value = id_Category
                cmd.Parameters.Add("@OptionMaintenanceDescription", SqlDbType.VarChar).Value = Option_Name
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            resp = ds.Tables("datos").Rows(0)(0).ToString

                            Return resp
                        Catch ex As SqlException
                            MessageBox.Show("Fallo en la conexión con la base de datos, comuniquese con soporte técnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "EX|" + ex.ToString

                        Catch ex As Exception
                            MessageBox.Show("Ocurrio un error al cargar la información.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(2, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "EX|" + ex.ToString

                        End Try
                        Return resp
                    End Using
                End Using
            End Using
        End Using
    End Function
    Public Function InsertOptionMaintenance(ByVal id_Category As Long, ByVal Option_Name As String) As String
        Using conn As New SqlClient.SqlConnection(connStr)
            Dim resp As String = ""
            Using cmd As New SqlCommand("ERP_Generic_InsertOptionMaintenance", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@ID_CategoryMaintenance_FK", SqlDbType.BigInt).Value = id_Category
                cmd.Parameters.Add("@OptionMaintenanceDescription", SqlDbType.VarChar).Value = Option_Name
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            resp = ds.Tables("datos").Rows(0)(0).ToString
                        Catch ex As SqlException
                            MessageBox.Show("Fallo en la conexión con la base de datos, comuniquese con soporte técnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "EX|" + ex.ToString

                        Catch ex As Exception
                            MessageBox.Show("Ocurrio un error al cargar la información.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(2, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "EX|" + ex.ToString

                        End Try
                        Return resp
                    End Using
                End Using
            End Using
        End Using
    End Function
    Public Function DelOptionMaintenance(ByVal Id_TypeOrigin As Long, ByVal id_Company As Long) As String
        Using conn As New SqlClient.SqlConnection(connStr)
            Dim resp As String = ""
            Using cmd As New SqlCommand("ERP_Generic_DeleteOptionMaintenance", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_OptionMaintenance", SqlDbType.BigInt).Value = Id_TypeOrigin
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            resp = ds.Tables("datos").Rows(0)(0).ToString
                            Return resp
                        Catch ex As SqlException
                            MessageBox.Show("Fallo en la conexión con la base de datos, comuniquese con soporte técnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "EX|" + ex.ToString

                        Catch ex As Exception
                            MessageBox.Show("Ocurrio un error al cargar la información.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(2, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "EX|" + ex.ToString

                        End Try
                        Return resp
                    End Using
                End Using
            End Using
        End Using
    End Function
#End Region

#Region "Grupo Animales"

    Public Function GetAnimalGroup(ByVal id_Company As Long) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_Production_SelectAnimalGroup", conn)
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

    Public Function SetAnimalGroup(ByVal Id_AnimalGroup As Long, ByVal id_Company As Long, ByVal AnimalGroup_Name As String) As String
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_Production_UpdateAnimalGroup", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_Group", SqlDbType.BigInt).Value = Id_AnimalGroup
                cmd.Parameters.Add("@Id_Company", SqlDbType.BigInt).Value = id_Company
                cmd.Parameters.Add("@Description", SqlDbType.VarChar).Value = AnimalGroup_Name
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return "OK"
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "ERROR"
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function
    Public Function InsertAnimalGroup(ByVal idCompany As Long, ByVal AnimalGroup_Name As String) As String
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_Production_InsertAnimalGroup", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@ID_Company", SqlDbType.BigInt).Value = idCompany
                cmd.Parameters.Add("@Description", SqlDbType.VarChar).Value = AnimalGroup_Name
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return "OK"
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "ERROR"
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function
    Public Function DelAnimalGroup(ByVal Id_AnimalGroup As Long, ByVal id_Company As Long) As String
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_Production_DelAnimalGroup", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_Group", SqlDbType.BigInt).Value = Id_AnimalGroup
                cmd.Parameters.Add("@Id_Company", SqlDbType.BigInt).Value = id_Company
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return "OK"
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "ERROR"
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function
#End Region

#Region "Financiero Bancos"
    Public Function ERP_Finance_SelectBankBalance(ByVal id_Company As Long, is_PettyCash As Boolean) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_Finance_SelectBankBalance", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_Company_FK", SqlDbType.BigInt).Value = id_Company
                cmd.Parameters.Add("@isPettyCash", SqlDbType.BigInt).Value = is_PettyCash
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
#End Region

#Region "Financiero Movimientos Bancos"
    Public Function ERP_Finance_SelectBankMovements(ByVal id_Company As Long) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_Finance_SelectBankMovements", conn)
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
    Public Function ERP_Finance_InsertBankMovements(ByVal id_Company As Long, ByVal movement_Type As Integer, ByVal id_Bank As Long, ByVal payedto As String, ByVal BankMovement_Description As String, ByVal BankMovement_amount As Double, ByVal ispettyCash As Boolean) As String
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_Finance_InsertBankMovements", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_Company", SqlDbType.BigInt).Value = id_Company
                cmd.Parameters.Add("@movement_Type", SqlDbType.VarChar).Value = movement_Type
                cmd.Parameters.Add("@id_bank", SqlDbType.VarChar).Value = id_Bank
                cmd.Parameters.Add("@payedto", SqlDbType.VarChar).Value = payedto
                cmd.Parameters.Add("@BankMovement_Description", SqlDbType.VarChar).Value = BankMovement_Description
                cmd.Parameters.Add("@BankMovementAmount", SqlDbType.Money).Value = BankMovement_amount
                cmd.Parameters.Add("@is_PettyCash", SqlDbType.Bit).Value = ispettyCash
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return "OK"
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "ERROR"
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function
#End Region

#Region "Financiero Movimientos Caja Chica"
    Public Function ERP_Finance_MovementsSelectPettyCash(ByVal id_Company As Long) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_Finance_MovementsSelectPettyCash", conn)
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
#End Region

#Region "Data Indicators"
    Public Function ERP_Config_GetDataIndicators() As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_Generic_SP_SelectIndicators", conn)
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

    Public Function ERP_Config_SetDataIndicators(ByVal id_Indicator As Long, ByVal Value_Indicator As Integer) As String
        Using conn As New SqlClient.SqlConnection(connStr)
            Dim resp As String = ""
            Using cmd As New SqlCommand("ERP_Generic_SP_SetIndicators", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@id_Indicators", SqlDbType.BigInt).Value = id_Indicator
                cmd.Parameters.Add("@value_Indicators", SqlDbType.Int).Value = Value_Indicator
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            resp = ds.Tables("datos").Rows(0)(0).ToString
                            Return resp
                        Catch ex As SqlException
                            MessageBox.Show("Fallo en la conexión con la base de datos, comuniquese con soporte técnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "EX|" + ex.ToString

                        Catch ex As Exception
                            MessageBox.Show("Ocurrio un error al cargar la información.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(2, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "EX|" + ex.ToString

                        End Try
                        Return resp
                    End Using
                End Using
            End Using
        End Using
    End Function

#End Region

#Region "Configuración Accesos"
    Public Function ERP_Config_GetAccessUserName(ByVal Busquedad As String) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_Config_GetAccessUserName", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@idcompany", SqlDbType.BigInt).Value = Data_Id_Company
                cmd.Parameters.Add("@Busquedad", SqlDbType.VarChar).Value = Busquedad
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
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
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
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return New DataTable("datos")
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function

    Public Function ERP_Config_InsertAccessUserName(ByVal username As String, ByVal Password As String, ByVal Rol As Integer, ByVal Empleado As Integer) As String
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_Config_InsertAccessUserName", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@IdCompany", SqlDbType.BigInt).Value = Data_Id_Company
                cmd.Parameters.Add("@username", SqlDbType.VarChar).Value = username
                cmd.Parameters.Add("@Password", SqlDbType.VarChar).Value = Password
                cmd.Parameters.Add("@Rol", SqlDbType.Int).Value = Rol
                cmd.Parameters.Add("@Empleado", SqlDbType.Int).Value = Empleado
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            If ds.Tables.Count > 0 Then
                                Return ds.Tables(0).Rows(0).Item("resp")
                            End If
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "Error"
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function
    Public Function ERP_Config_UpdateAccessUserName(ByVal id_Username As Long, ByVal username As String, ByVal Password As String, ByVal Rol As Integer, ByVal Empleado As Integer) As String
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_Config_UpdateAccessUserName", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@IdCompany", SqlDbType.BigInt).Value = Data_Id_Company
                cmd.Parameters.Add("@idUsername", SqlDbType.BigInt).Value = id_Username
                cmd.Parameters.Add("@username", SqlDbType.VarChar).Value = username
                cmd.Parameters.Add("@Rol", SqlDbType.Int).Value = Rol
                cmd.Parameters.Add("@Empleado", SqlDbType.Int).Value = Empleado
                cmd.Parameters.Add("@Password", SqlDbType.VarChar).Value = Password
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")

                            Dim resp As String = ds.Tables(0).Rows(0).Item("resp")
                            Return resp
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "ERROR"
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function


    Public Function ERP_Config_UpdateAccessUserNamePassword(ByVal id_Username As Long, ByVal Password As String, ByVal NewPassword As String, ByVal username As String) As String
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_Config_UpdateAccessUserNamePassword", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@IdCompany", SqlDbType.BigInt).Value = Data_Id_Company
                cmd.Parameters.Add("@idUsername", SqlDbType.BigInt).Value = id_Username
                cmd.Parameters.Add("@Password", SqlDbType.VarChar).Value = Password
                cmd.Parameters.Add("@NewPassword", SqlDbType.VarChar).Value = NewPassword
                cmd.Parameters.Add("@username", SqlDbType.VarChar).Value = username

                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")

                            Dim resp As String = ds.Tables(0).Rows(0).Item("resp")
                            If resp <> "ok" Then
                                process.AlmacenarLog(4, resp, System.Reflection.MethodBase.GetCurrentMethod().Name)
                                resp = "ERROR"
                            End If
                            Return resp
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "ERROR"
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function

    Public Function ERP_Config_DeleteAccessUserName(ByVal id_Username As Long) As String
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_Config_DeleteAccessUserName", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@IdCompany", SqlDbType.BigInt).Value = Data_Id_Company
                cmd.Parameters.Add("@idUsername", SqlDbType.BigInt).Value = id_Username
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return "OK"
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
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
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "ERROR"
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function

#End Region

#Region "Customer Type"

    Public Function ERP_Generic_SP_GetTypeCustomer(ByVal id_Company As Long) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_Generic_SP_GetTypeCustomer", conn)
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

    Public Function ERP_Generic_SP_GetTypeCustomer(ByVal id_Company As Long, ByVal busqueda As String) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("[ERP_Generic_SP_GetTypeCustomer_LIKE]", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_Company", SqlDbType.BigInt).Value = id_Company
                cmd.Parameters.Add("@busqueda", SqlDbType.VarChar).Value = busqueda
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

    Public Function ERP_Generic_SP_UpdateTypeCustomer(ByVal Id_TypeCustomer As Long, ByVal id_Company As Long, ByVal TypeSystem As String, ByVal DescriptionCustomer As String) As String
        Dim resp As String = ""
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_Generic_SP_UpdateTypeCustomer", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_TypeCustomer", SqlDbType.BigInt).Value = Id_TypeCustomer
                cmd.Parameters.Add("@Id_Company", SqlDbType.BigInt).Value = id_Company
                cmd.Parameters.Add("@TypeSystem", SqlDbType.VarChar).Value = TypeSystem
                cmd.Parameters.Add("@DescriptionCustomer", SqlDbType.VarChar).Value = DescriptionCustomer
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            resp = ds.Tables("datos").Rows(0).Item(0).ToString()
                            Return resp
                        Catch ex As SqlException
                            MessageBox.Show("Fallo en la conexión con la base de datos, comuniquese con soporte técnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "EX|" + ex.ToString

                        Catch ex As Exception
                            MessageBox.Show("Ocurrio un error al cargar la información.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(2, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "EX|" + ex.ToString

                        End Try
                        Return resp
                    End Using
                End Using
            End Using
        End Using
    End Function
    Public Function ERP_Generic_SP_InsertTypeCustomer(ByVal id_Company As Long, ByVal TypeSystem As String, ByVal DescriptionCustomer As String) As String
        Dim resp As String = ""
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_Generic_SP_InsertTypeCustomer", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_Company", SqlDbType.BigInt).Value = id_Company
                cmd.Parameters.Add("@TypeSystem", SqlDbType.VarChar).Value = TypeSystem
                cmd.Parameters.Add("@DescriptionCustomer", SqlDbType.VarChar).Value = DescriptionCustomer
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            resp = ds.Tables("datos").Rows(0).Item(0).ToString()
                            Return resp
                        Catch ex As SqlException
                            MessageBox.Show("Fallo en la conexión con la base de datos, comuniquese con soporte técnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "EX|" + ex.ToString

                        Catch ex As Exception
                            MessageBox.Show("Ocurrio un error al cargar la información.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(2, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "EX|" + ex.ToString

                        End Try
                        Return resp
                    End Using
                End Using
            End Using
        End Using
    End Function
    Public Function ERP_Generic_SP_DelTypeCustomer(ByVal Id_TypeCustomer As Long, ByVal id_Company As Long) As String
        Dim resp As String = ""
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_Generic_SP_DelTypeCustomer", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_TypeCustomer", SqlDbType.BigInt).Value = Id_TypeCustomer
                cmd.Parameters.Add("@Id_Company", SqlDbType.BigInt).Value = id_Company
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            resp = ds.Tables("datos").Rows(0).Item(0)
                            Return resp
                        Catch ex As SqlException
                            MessageBox.Show("Fallo en la conexión con la base de datos, comuniquese con soporte técnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "EX|" + ex.ToString

                        Catch ex As Exception
                            MessageBox.Show("Ocurrio un error al cargar la información.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(2, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "EX|" + ex.ToString

                        End Try
                        Return resp
                    End Using
                End Using
            End Using
        End Using
    End Function
#End Region

#Region "Credit Document Type"

    Public Function ERP_AR_GetCreditDocument(ByVal id_Company As Long) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_AR_GetCreditDocument", conn)
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

    Public Function ERP_AR_SetCreditDocument(ByVal id_CreditDocument As Long, ByVal id_Company As Long, ByVal is_invoice As Boolean, ByVal Description As String) As String
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_AR_SetCreditDocument", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@id_CreditDocument", SqlDbType.BigInt).Value = id_CreditDocument
                cmd.Parameters.Add("@Id_Company", SqlDbType.BigInt).Value = id_Company
                cmd.Parameters.Add("@is_invoice", SqlDbType.Bit).Value = is_invoice
                cmd.Parameters.Add("@Description", SqlDbType.VarChar).Value = Description
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return "OK"
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "ERROR"
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function
    Public Function ERP_AR_InsertCreditDocument(ByVal id_Company As Long, ByVal is_invoice As Boolean, ByVal Description As String) As String
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_AR_InsertCreditDocument", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_Company", SqlDbType.BigInt).Value = id_Company
                cmd.Parameters.Add("@is_invoice", SqlDbType.Bit).Value = is_invoice
                cmd.Parameters.Add("@Description", SqlDbType.VarChar).Value = Description
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return "OK"
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "ERROR"
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function
    Public Function ERP_AR_DelCreditDocument(ByVal id_CreditDocument As Long, ByVal id_Company As Long) As String
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_AR_DelCreditDocument", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@id_CreditDocument", SqlDbType.BigInt).Value = id_CreditDocument
                cmd.Parameters.Add("@Id_Company", SqlDbType.BigInt).Value = id_Company
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return "OK"
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "ERROR"
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function
#End Region

#Region "Giro General"

    Public Function ERP_Generic_SP_GetCompanyCategory(ByVal id_Company As Long) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_Generic_SP_GetCompanyCategory", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_Company_FK", SqlDbType.BigInt).Value = id_Company
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
    Public Function ERP_Generic_SP_GetCompanyCategory(ByVal id_Company As Long, ByVal busqueda As String) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_Generic_SP_GetCompanyCategory_LIKE", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_Company_FK", SqlDbType.BigInt).Value = id_Company
                cmd.Parameters.Add("@busqueda", SqlDbType.VarChar).Value = busqueda
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

    Public Function ERP_Generic_SP_UpdateCompanyCategory(ByVal ID_CompanyCategory As Long, ByVal id_Company As Long, ByVal CompanyCategory As String) As String
        Dim resp As String = ""
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_Generic_SP_UpdateCompanyCategory", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@ID_CompanyCategory", SqlDbType.BigInt).Value = ID_CompanyCategory
                cmd.Parameters.Add("@Id_Company_FK", SqlDbType.BigInt).Value = id_Company
                cmd.Parameters.Add("@Description_CompanyCategory", SqlDbType.VarChar).Value = CompanyCategory
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            resp = ds.Tables("datos").Rows(0).Item(0)
                            Return resp
                        Catch ex As SqlException
                            MessageBox.Show("Fallo en la conexión con la base de datos, comuniquese con soporte técnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "EX|" + ex.ToString

                        Catch ex As Exception
                            MessageBox.Show("Ocurrio un error al cargar la información.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(2, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "EX|" + ex.ToString

                        End Try
                        Return resp
                    End Using
                End Using
            End Using
        End Using
    End Function
    Public Function ERP_Generic_SP_InsertCompanyCategory(ByVal id_Company As Long, ByVal CompanyCategory As String) As String
        Dim resp As String = ""
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_Generic_SP_InsertCompanyCategory", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_Company_FK", SqlDbType.BigInt).Value = id_Company
                cmd.Parameters.Add("@Description_CompanyCategory", SqlDbType.VarChar).Value = CompanyCategory
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            resp = ds.Tables("datos").Rows(0).Item(0)
                        Catch ex As SqlException
                            MessageBox.Show("Fallo en la conexión con la base de datos, comuniquese con soporte técnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "EX|" + ex.ToString

                        Catch ex As Exception
                            MessageBox.Show("Ocurrio un error al cargar la información.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(2, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "EX|" + ex.ToString

                        End Try
                        Return resp
                    End Using
                End Using
            End Using
        End Using
    End Function
    Public Function ERP_Generic_SP_DelCompanyCategory(ByVal ID_CompanyCategory As Long, ByVal id_Company As Long) As String
        Dim resp As String = ""
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_Generic_SP_DelCompanyCategory", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@ID_CompanyCategory", SqlDbType.BigInt).Value = ID_CompanyCategory
                cmd.Parameters.Add("@Id_Company_FK", SqlDbType.BigInt).Value = id_Company
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            resp = ds.Tables("datos").Rows(0).Item(0)
                            Return resp
                        Catch ex As SqlException
                            MessageBox.Show("Fallo en la conexión con la base de datos, comuniquese con soporte técnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "EX|" + ex.ToString

                        Catch ex As Exception
                            MessageBox.Show("Ocurrio un error al cargar la información.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(2, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "EX|" + ex.ToString

                        End Try
                        Return resp
                    End Using
                End Using
            End Using
        End Using
    End Function
#End Region

#Region "Departamentos Empresa"

    Public Function ERP_RRHH_GetDepartment(ByVal id_Company As Long) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_RRHH_GetDepartment", conn)
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

    Public Function ERP_RRHH_GetDepartment(ByVal id_Company As Long, ByVal busqueda As String) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_RRHH_GetDepartment_LIKE", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_Company", SqlDbType.BigInt).Value = id_Company
                cmd.Parameters.Add("@busqueda", SqlDbType.VarChar).Value = busqueda
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

    Public Function ERP_RRHH_SetDepartment(ByVal Id_Deparment As Long, ByVal id_Company As Long, ByVal Name_Deparmnet As String, codigoInterno As String) As String
        Dim resp As String = ""
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_RRHH_SetDepartment", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_Deparment", SqlDbType.BigInt).Value = Id_Deparment
                cmd.Parameters.Add("@Id_Company_FK", SqlDbType.BigInt).Value = id_Company
                cmd.Parameters.Add("@Name_Deparmnet", SqlDbType.VarChar).Value = Name_Deparmnet
                cmd.Parameters.Add("@Codigo_interno", SqlDbType.VarChar).Value = codigoInterno
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            resp = ds.Tables("datos").Rows(0).Item("resp")
                        Catch ex As SqlException
                            MessageBox.Show("Fallo en la conexión con la base de datos, comuniquese con soporte tecnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return resp

                        Catch ex As Exception
                            MessageBox.Show("Ocurrio un error al cargar la informacion.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(2, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)


                            Return resp
                        End Try
                    End Using
                End Using
            End Using
        End Using
        Return resp
    End Function
    Public Function ERP_RRHH_InsertDepartment(ByVal id_Company As Long, ByVal Name_Deparmnet As String, ByVal codigoInterno As String) As String
        Dim resp As String = ""
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_RRHH_InsertDepartment", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_Company_FK", SqlDbType.BigInt).Value = id_Company
                cmd.Parameters.Add("@Name_Department", SqlDbType.VarChar).Value = Name_Deparmnet
                cmd.Parameters.Add("@Codigo_interno", SqlDbType.VarChar).Value = codigoInterno
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            resp = ds.Tables("datos").Rows(0).Item("resp")

                        Catch ex As SqlException
                            MessageBox.Show("Fallo en la conexión con la base de datos, comuniquese con soporte tecnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return resp

                        Catch ex As Exception
                            MessageBox.Show("Ocurrio un error al cargar la informacion.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(2, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)


                            Return resp
                        End Try


                    End Using
                End Using
            End Using
        End Using
        Return resp
    End Function
    Public Function ERP_RRHH_DelDeparment(ByVal Id_Deparment As Long, ByVal id_Company As Long) As String
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_RRHH_DelDeparment", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_Deparment", SqlDbType.BigInt).Value = Id_Deparment
                cmd.Parameters.Add("@Id_Company_FK", SqlDbType.BigInt).Value = id_Company
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return "OK"
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "ERROR"
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function
#End Region

#Region "Posición de Trabajo"

    Public Function ERP_RRHH_GetWorkPosition(ByVal id_Company As Long) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_RRHH_GetWorkPosition", conn)
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
    Public Function ERP_RRHH_GetWorkPosition(ByVal id_Company As Long, ByVal busqueda As String) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_RRHH_GetWorkPosition_LIKE", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_Company", SqlDbType.BigInt).Value = id_Company
                cmd.Parameters.Add("@busqueda", SqlDbType.VarChar).Value = busqueda
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

    Public Function ERP_RRHH_SetWorkPosition(ByVal Id_WorkPosition As Long, ByVal id_Company As Long, ByVal Name_WorkPosition As String, ByVal Is_CustomerService As Boolean) As String
        Dim resp As String = ""
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_RRHH_SetWorkPosition", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_WorkPosition", SqlDbType.BigInt).Value = Id_WorkPosition
                cmd.Parameters.Add("@Id_Company_FK", SqlDbType.BigInt).Value = id_Company
                cmd.Parameters.Add("@Name_WorkPosition", SqlDbType.VarChar).Value = Name_WorkPosition
                cmd.Parameters.Add("@Is_CustomerService", SqlDbType.Bit).Value = Is_CustomerService

                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            resp = ds.Tables("datos").Rows(0).Item("resp")
                        Catch ex As SqlException
                            MessageBox.Show("Fallo en la conexión con la base de datos, comuniquese con soporte tecnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return resp

                        Catch ex As Exception
                            MessageBox.Show("Ocurrio un error al cargar la informacion.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(2, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)


                            Return resp
                        End Try

                    End Using
                End Using
            End Using
        End Using
        Return resp
    End Function
    Public Function ERP_RRHH_InsertWorkPosition(ByVal id_Company As Long, ByVal Name_WorkPosition As String, ByVal Is_CustomerService As Boolean) As String
        Dim resp As String = ""
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_RRHH_InsertWorkPosition", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_Company_FK", SqlDbType.BigInt).Value = id_Company
                cmd.Parameters.Add("@Name_WorkPosition", SqlDbType.VarChar).Value = Name_WorkPosition
                cmd.Parameters.Add("@Is_CustomerService", SqlDbType.Bit).Value = Is_CustomerService
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            resp = ds.Tables("datos").Rows(0).Item("resp")
                        Catch ex As SqlException
                            MessageBox.Show("Fallo en la conexión con la base de datos, comuniquese con soporte tecnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return resp

                        Catch ex As Exception
                            MessageBox.Show("Ocurrio un error al cargar la informacion.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(2, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)



                        End Try

                    End Using
                End Using
            End Using
        End Using
        Return resp
    End Function
    Public Function ERP_RRHH_DelWorkPosition(ByVal id_company_FK As Long, ByVal Id_WorkPosition As Long) As String
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_RRHH_DelWorkPosition", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@id_company_FK", SqlDbType.BigInt).Value = id_company_FK
                cmd.Parameters.Add("@Id_WorkPosition", SqlDbType.BigInt).Value = Id_WorkPosition
                '
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return "OK"
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "ERROR"
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function
#End Region

#Region "Ubicación de Trabajo"
    Public Function ERP_RRHH_GetLocation(ByVal id_Company As Long) As DataTable
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

    Public Function ERP_RRHH_GetLocation(ByVal id_Company As Long, ByVal busqueda As String) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_RRHH_GetLocation_LIKE", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_Company", SqlDbType.BigInt).Value = id_Company
                cmd.Parameters.Add("@busqueda", SqlDbType.VarChar).Value = busqueda
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

    Public Function ERP_RRHH_SetLocation(ByVal Id_Location As Long, ByVal id_Company As Long, ByVal Name_Location As String, ByVal Address_Location As String, ByVal UbicacionPrimaria As Integer) As String
        Dim resp As String = ""
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_RRHH_SetLocation", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_Location", SqlDbType.BigInt).Value = Id_Location
                cmd.Parameters.Add("@Id_Company", SqlDbType.BigInt).Value = id_Company
                cmd.Parameters.Add("@Name_Location", SqlDbType.VarChar).Value = Name_Location
                cmd.Parameters.Add("@Address_Location", SqlDbType.VarChar).Value = Address_Location
                cmd.Parameters.Add("@UbicacionPrimaria", SqlDbType.VarChar).Value = UbicacionPrimaria

                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            resp = ds.Tables("datos").Rows(0).Item("resp")
                        Catch ex As SqlException
                            MessageBox.Show("Fallo en la conexión con la base de datos, comuniquese con soporte tecnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return resp

                        Catch ex As Exception
                            MessageBox.Show("Ocurrio un error al cargar la informacion.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(2, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)


                            Return resp
                        End Try

                    End Using
                End Using
            End Using
        End Using
        Return resp
    End Function
    Public Function ERP_RRHH_InsertLocation(ByVal id_Company As Long, ByVal Name_Location As String, ByVal Address_Location As String, ByVal UbicacionPrimaria As Integer) As String
        Dim resp As String = ""
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_RRHH_InsertLocation", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_Company", SqlDbType.BigInt).Value = id_Company
                cmd.Parameters.Add("@Name_Location", SqlDbType.VarChar).Value = Name_Location
                cmd.Parameters.Add("@Address_Location", SqlDbType.VarChar).Value = Address_Location
                cmd.Parameters.Add("@UbicacionPrimaria", SqlDbType.VarChar).Value = UbicacionPrimaria

                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            resp = ds.Tables("datos").Rows(0).Item("resp")
                        Catch ex As SqlException
                            MessageBox.Show("Fallo en la conexión con la base de datos, comuniquese con soporte tecnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return resp

                        Catch ex As Exception
                            MessageBox.Show("Ocurrio un error al cargar la informacion.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(2, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)


                            Return resp
                        End Try

                    End Using
                End Using
            End Using
        End Using
        Return resp
    End Function
    Public Function ERP_RRHH_DelLocation(ByVal Id_WorkPosition As Long, ByVal id_Company As Long) As String
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_RRHH_DelLocation", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_Location", SqlDbType.BigInt).Value = Id_WorkPosition
                cmd.Parameters.Add("@IdCompany", SqlDbType.BigInt).Value = id_Company
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return "OK"
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "ERROR"
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function
#End Region

#Region "Unidad de Medida"
    Public Function ERP_Generic_SP_GetUnitMeasure(ByVal id_Company As Long) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_Generic_SP_GetUnitMeasure", conn)
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
    Public Function ERP_Generic_SP_GetUnitMeasure(ByVal id_Company As Long, ByVal busqueda As String) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_Generic_SP_GetUnitMeasure_LIKE", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_Company", SqlDbType.BigInt).Value = id_Company
                cmd.Parameters.Add("@busqueda", SqlDbType.VarChar).Value = busqueda
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

    Public Function ERP_Generic_SP_SetUnitMeasure(ByVal id_UnitMeasure As Long, ByVal id_Company As Long, ByVal Name_UnitMeasure As String, ByVal Unit_Conversion As String) As String
        Dim resp As String = ""
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_Generic_SP_SetUnitMeasure", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@id_UnitMeasure", SqlDbType.BigInt).Value = id_UnitMeasure
                cmd.Parameters.Add("@Id_Company", SqlDbType.BigInt).Value = id_Company
                cmd.Parameters.Add("@Name_UnitMeasure", SqlDbType.VarChar).Value = Name_UnitMeasure
                cmd.Parameters.Add("@Unit_Conversion", SqlDbType.VarChar).Value = Unit_Conversion
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            resp = ds.Tables("datos").Rows(0).Item(0)
                            Return resp
                        Catch ex As SqlException
                            MessageBox.Show("Fallo en la conexión con la base de datos, comuniquese con soporte técnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "EX|" + ex.ToString

                        Catch ex As Exception
                            MessageBox.Show("Ocurrio un error al cargar la información.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(2, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "EX|" + ex.ToString

                        End Try
                        Return resp
                    End Using
                End Using
            End Using
        End Using
    End Function
    Public Function ERP_Generic_SP_InsertUnitMeasure(ByVal id_Company As Long, ByVal Name_UnitMeasure As String, ByVal Unit_Conversion As String) As String
        Dim resp As String = ""
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_Generic_SP_InsertUnitMeasure", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_Company", SqlDbType.BigInt).Value = id_Company
                cmd.Parameters.Add("@Name_UnitMeasure", SqlDbType.VarChar).Value = Name_UnitMeasure
                cmd.Parameters.Add("@Unit_Conversion", SqlDbType.VarChar).Value = Unit_Conversion
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            resp = ds.Tables("datos").Rows(0).Item(0)
                            Return resp
                        Catch ex As SqlException
                            MessageBox.Show("Fallo en la conexión con la base de datos, comuniquese con soporte técnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "EX|" + ex.ToString

                        Catch ex As Exception
                            MessageBox.Show("Ocurrio un error al cargar la información.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(2, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "EX|" + ex.ToString

                        End Try
                        Return resp
                    End Using
                End Using
            End Using
        End Using
    End Function
    Public Function ERP_Generic_SP_DelUnitMeasure(ByVal id_UnitMeasure As Long, ByVal id_Company As Long) As String
        Dim resp As String = ""
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_Generic_SP_DelUnitMeasure", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@id_UnitMeasure", SqlDbType.BigInt).Value = id_UnitMeasure
                cmd.Parameters.Add("@Id_Company_FK", SqlDbType.BigInt).Value = id_Company
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            resp = ds.Tables("datos").Rows(0).Item(0)
                            Return resp
                        Catch ex As SqlException
                            MessageBox.Show("Fallo en la conexión con la base de datos, comuniquese con soporte técnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "EX|" + ex.ToString

                        Catch ex As Exception
                            MessageBox.Show("Ocurrio un error al cargar la información.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(2, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "EX|" + ex.ToString

                        End Try
                        Return resp
                    End Using
                End Using
            End Using
        End Using
    End Function
#End Region

#Region "Tipo de Producto"

    Public Function SP_ERP_Generic_GetProductCondition(ByVal id_Company As Long, Optional tipo As Integer = 0) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("SP_ERP_Generic_GetProductCondition", conn)
                cmd.CommandType = CommandType.StoredProcedure
                'cmd.Parameters.Add("@Id_Company", SqlDbType.BigInt).Value = id_Company
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
    Public Function SP_ERP_Generic_GetProductCondition(ByVal id_Company As Long, ByVal busqueda As String) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("SP_ERP_Generic_GetProductCondition_LIKE", conn)
                cmd.CommandType = CommandType.StoredProcedure
                'cmd.Parameters.Add("@Id_Company", SqlDbType.BigInt).Value = id_Company
                cmd.Parameters.Add("@busqueda", SqlDbType.VarChar).Value = busqueda
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

    Public Function SP_ERP_Generic_SetProductCondition(ByVal id_ProductCondition As Long, ByVal id_Company As Long, ByVal Name_Condition As String) As String
        Dim resp As String = ""
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("SP_ERP_Generic_SetProductCondition", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@id_ProductCondition", SqlDbType.BigInt).Value = id_ProductCondition
                cmd.Parameters.Add("@Id_Company_FK", SqlDbType.BigInt).Value = id_Company
                cmd.Parameters.Add("@Name_Condition", SqlDbType.VarChar).Value = Name_Condition
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            resp = ds.Tables("datos").Rows(0).Item(0)
                        Catch ex As SqlException
                            MessageBox.Show("Fallo en la conexión con la base de datos, comuniquese con soporte técnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "EX|" + ex.ToString

                        Catch ex As Exception
                            MessageBox.Show("Ocurrio un error al cargar la información.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(2, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "EX|" + ex.ToString

                        End Try
                        Return resp
                    End Using
                End Using
            End Using
        End Using
    End Function
    Public Function SP_ERP_Generic_InsertProductCondition(ByVal id_Company As Long, ByVal Name_Condition As String) As String
        Dim resp As String = ""
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("SP_ERP_Generic_InsertProductCondition", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_Company_FK", SqlDbType.BigInt).Value = id_Company
                cmd.Parameters.Add("@Name_Condition", SqlDbType.VarChar).Value = Name_Condition
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            resp = ds.Tables("datos").Rows(0).Item(0)
                            Return resp
                        Catch ex As SqlException
                            MessageBox.Show("Fallo en la conexión con la base de datos, comuniquese con soporte técnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "EX|" + ex.ToString

                        Catch ex As Exception
                            MessageBox.Show("Ocurrio un error al cargar la información.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(2, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "EX|" + ex.ToString

                        End Try
                        Return resp
                    End Using
                End Using
            End Using
        End Using
    End Function
    Public Function SP_ERP_Generic_DelProductCondition(ByVal id_ProductCondition As Long, ByVal id_Company As Long) As String
        Dim resp As String = ""
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("SP_ERP_Generic_DelProductCondition", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@id_ProductCondition", SqlDbType.BigInt).Value = id_ProductCondition
                cmd.Parameters.Add("@Id_Company_FK", SqlDbType.BigInt).Value = id_Company
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            resp = ds.Tables("datos").Rows(0).Item(0)
                            Return resp
                        Catch ex As SqlException
                            MessageBox.Show("Fallo en la conexión con la base de datos, comuniquese con soporte técnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "EX|" + ex.ToString

                        Catch ex As Exception
                            MessageBox.Show("Ocurrio un error al cargar la información.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(2, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "EX|" + ex.ToString

                        End Try
                        Return resp
                    End Using
                End Using
            End Using
        End Using
    End Function
#End Region

#Region "Tipo de Línea de Crédito"

    Public Function ERP_SP_GetTypeCreditLine(ByVal id_Company As Long) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_SP_GetTypeCreditLine", conn)
                cmd.CommandType = CommandType.StoredProcedure
                'cmd.Parameters.Add("@Id_Company", SqlDbType.BigInt).Value = id_Company
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

    Public Function ERP_SP_SetTypeCreditLine(ByVal IdTypeCreditLine As Long, ByVal id_Company As Long, ByVal TypeCreditLine As String, ByVal DescriptionCreditLine As String) As String
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_SP_SetTypeCreditLine", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@IdTypeCreditLine", SqlDbType.BigInt).Value = IdTypeCreditLine
                cmd.Parameters.Add("@Id_Company_FK", SqlDbType.BigInt).Value = id_Company
                cmd.Parameters.Add("@TypeCreditLine", SqlDbType.VarChar).Value = TypeCreditLine
                cmd.Parameters.Add("@DescriptionCreditLine", SqlDbType.VarChar).Value = DescriptionCreditLine
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return "OK"
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "ERROR"
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function
    Public Function ERP_SP_InsertTypeCreditLine(ByVal id_Company As Long, ByVal TypeCreditLine As String, ByVal DescriptionCreditLine As String) As String
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_SP_InsertTypeCreditLine", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_Company_FK", SqlDbType.BigInt).Value = id_Company
                cmd.Parameters.Add("@TypeCreditLine", SqlDbType.VarChar).Value = TypeCreditLine
                cmd.Parameters.Add("@DescriptionCreditLine", SqlDbType.VarChar).Value = DescriptionCreditLine
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return "OK"
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "ERROR"
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function
    Public Function ERP_SP_DelTypeCreditLine(ByVal IdTypeCreditLine As Long, ByVal id_Company As Long) As String
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_SP_DelTypeCreditLine", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@IdTypeCreditLine", SqlDbType.BigInt).Value = IdTypeCreditLine
                cmd.Parameters.Add("@Id_Company_FK", SqlDbType.BigInt).Value = id_Company
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return "OK"
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "ERROR"
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function
#End Region

#Region "Catálogo de Pagos Parciales"

    Public Function ERP_AccountsReceivable_GET_PartialPaymentsCatalog(ByVal id_Company As Long) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_AccountsReceivable_GET_PartialPaymentsCatalog", conn)
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

    Public Function ERP_AccountsReceivable_Set_PartialPaymentsCatalog(ByVal id_catalog As Long, ByVal id_Company As Long, ByVal DescriptionCatalog As String) As String
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_AccountsReceivable_Set_PartialPaymentsCatalog", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@id_catalog", SqlDbType.BigInt).Value = id_catalog
                cmd.Parameters.Add("@Id_Company", SqlDbType.BigInt).Value = id_Company
                cmd.Parameters.Add("@DescriptionCatalog", SqlDbType.VarChar).Value = DescriptionCatalog
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return "OK"
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "ERROR"
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function
    Public Function ERP_AccountsReceivable_Insert_PartialPaymentsCatalog(ByVal id_Company As Long, ByVal DescriptionCatalog As String) As String
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_AccountsReceivable_Insert_PartialPaymentsCatalog", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_Company", SqlDbType.BigInt).Value = id_Company
                cmd.Parameters.Add("@DescriptionCatalog", SqlDbType.VarChar).Value = DescriptionCatalog
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return "OK"
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "ERROR"
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function
    Public Function ERP_AccountsReceivable_Del_PartialPaymentsCatalog(ByVal id_catalog As Long, ByVal id_Company As Long) As String
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_AccountsReceivable_Del_PartialPaymentsCatalog", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@id_catalog", SqlDbType.BigInt).Value = id_catalog
                cmd.Parameters.Add("@Id_Company", SqlDbType.BigInt).Value = id_Company
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return "OK"
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "ERROR"
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function
#End Region


    Public Function ERP_Inventory_GetProducts_RecipesDelete(ByVal ID_Product As Long) As Integer
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_Inventory_GetProducts_RecipesDelete", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@ID_Product", SqlDbType.BigInt).Value = ID_Product
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try

                            da.Fill(ds, "datos")
                            Return 1

                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return 0
                        End Try
                    End Using
                End Using




            End Using
        End Using
    End Function

    Public Function ERP_RRHH_UpdateReportDetail(ByVal Id_Header_FK As Long, ByVal Id_Define_Field_FK As Long, ByVal is_Active As Boolean) As Integer
        Dim resp As Integer = 0

        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_RRHH_UpdateReportDetail", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_Header_FK", SqlDbType.BigInt).Value = Id_Header_FK
                cmd.Parameters.Add("@Id_Define_Field_FK", SqlDbType.BigInt).Value = Id_Define_Field_FK
                cmd.Parameters.Add("@is_Active", SqlDbType.Bit).Value = is_Active
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            resp = ds.Tables("datos").Rows(0).Item(0)
                            Return resp
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return resp
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function

    Public Function ERP_RRHH_UpdateReportHeaders(ByVal Id_Header As Long, ByVal Name_Header As String, ByVal Descrip_Header As String, ByVal id_Modulo_FK As Long) As String
        Dim resp As Integer = 0

        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_RRHH_UpdateReportHeaders", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_Header", SqlDbType.BigInt).Value = Id_Header
                cmd.Parameters.Add("@Name_Header", SqlDbType.VarChar).Value = Name_Header
                cmd.Parameters.Add("@Descrip_Header", SqlDbType.VarChar).Value = Descrip_Header
                cmd.Parameters.Add("@id_Modulo_FK", SqlDbType.BigInt).Value = id_Modulo_FK
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            resp = ds.Tables("datos").Rows(0).Item(0)
                            Return resp
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return resp
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function
#Region "Activo Fijo Define"


    Public Function ERP_FixedAssets_SP_GetType(ByVal Id_Company As Long) As DataTable

        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_FixedAssets_SP_GetType", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_Company", SqlDbType.BigInt).Value = Id_Company
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "GetType_Define")
                            Return ds.Tables("GetType_Define")
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return New DataTable("GetType_Define")
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function

    Public Function ERP_FixedAssets_SP_GetTypeTangible(ByVal Id_Company As Long, ByVal Tangible As Boolean) As DataTable

        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_FixedAssets_SP_GetTypeTangible", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_Company", SqlDbType.BigInt).Value = Id_Company
                cmd.Parameters.Add("@Tangible", SqlDbType.Bit).Value = Tangible
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "GetType_Define")
                            Return ds.Tables("GetType_Define")
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return New DataTable("GetType_Define")
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function
    Public Function GetERP_FixedAssets_SP_GetType_Define(ByVal id_FixedType As Int64, ID_Fixed As Int64) As DataTable

        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_FixedAssets_SP_GetType_Define", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_FixedType", SqlDbType.BigInt).Value = id_FixedType
                cmd.Parameters.Add("@ID_FixedAssets", SqlDbType.BigInt).Value = ID_Fixed
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "GetType_Define")
                            Return ds.Tables("GetType_Define")
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return New DataTable("GetType_Define")
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function

    Public Function GetERP_FixedAssets_SP_SetType_Define(ByVal Campo_Descripcion As String, ID_Fixed As Int64, Campo_Valor As String, Id_FixedAssetsType As Int64, ID_FixedAssets As Int64) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_FixedAssets_SP_SetType_Details", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Campo_Descripcion", SqlDbType.VarChar).Value = Campo_Descripcion
                cmd.Parameters.Add("@ID_FixedAssets_Type_Define", SqlDbType.BigInt).Value = ID_Fixed
                cmd.Parameters.Add("@Campo_Valor", SqlDbType.VarChar).Value = Campo_Valor
                cmd.Parameters.Add("@Id_FixedAssetsType", SqlDbType.BigInt).Value = Id_FixedAssetsType
                cmd.Parameters.Add("@ID_FixedAssets", SqlDbType.BigInt).Value = ID_FixedAssets

                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "GetType_Define")
                            Return ds.Tables("GetType_Define")
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return New DataTable("GetType_Define")
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function

    Public Function GetERP_FixedAssets_SP_ModType_Define(ByVal Campo_Descripcion As String, ID_Fixed As Int64, Campo_Valor As String, Id_FixedAssetsType As Int64, ID_FixedAssets As Int64, ID_FixedAssets_Type_Details As Int64) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_FixedAssets_SP_ModType_Details", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Campo_Descripcion", SqlDbType.VarChar).Value = Campo_Descripcion
                cmd.Parameters.Add("@ID_FixedAssets_Type_Define", SqlDbType.BigInt).Value = ID_Fixed
                cmd.Parameters.Add("@Campo_Valor", SqlDbType.VarChar).Value = Campo_Valor
                cmd.Parameters.Add("@Id_FixedAssetsType", SqlDbType.BigInt).Value = Id_FixedAssetsType
                cmd.Parameters.Add("@ID_FixedAssets", SqlDbType.BigInt).Value = ID_FixedAssets
                cmd.Parameters.Add("@ID_FixedAssets_Type_Details", SqlDbType.BigInt).Value = ID_FixedAssets_Type_Details
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "GetType_Define")
                            Return ds.Tables("GetType_Define")
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return New DataTable("GetType_Define")
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function

    Public Function GetERP_Generic_FromXLS_Get(ByVal Codigo As String) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("SP_Generic_FromXLS_Get", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Codigo", SqlDbType.VarChar).Value = Codigo
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "Generic_FromXLS")
                            Return ds.Tables("Generic_FromXLS")
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return New DataTable("Generic_FromXLS")
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function
    Public Function GetERP_Generic_FromXLS_Actualiza(ByVal Codigo As String, ID_Code_Import As Int64) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("SP_Generic_FromXLS_Up_CodImport", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Codigo", SqlDbType.VarChar).Value = Codigo
                cmd.Parameters.Add("@ID_Code_Import", SqlDbType.VarChar).Value = ID_Code_Import
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "Generic_FromXLS_UP")
                            Return ds.Tables("Generic_FromXLS_UP")
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return New DataTable("Generic_FromXLS")
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function

    Public Function GetERP_getHistorico() As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_RRHH_GetFiexdAssets", conn)
                cmd.CommandType = CommandType.StoredProcedure
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "Historico")
                            Return ds.Tables("Historico")
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return New DataTable("Historico")
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function
    Public Function Generic_FromXLS_Set(dt As DataTable) As Integer
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("SP_Generic_FromXLS_Set", conn)
                cmd.CommandType = CommandType.StoredProcedure
                For Each regIn As DataColumn In dt.Columns
                    Select Case regIn.DataType.Name
                        Case "Float"
                            cmd.Parameters.Add(String.Format("@{0}", regIn.ColumnName), SqlDbType.Float, 64, regIn.ColumnName)
                                'Case "Double"

                                '    cmd.Parameters.Add(String.Format("@{0}", regIn.ColumnName), SqlDbType.BigInt, 64, regIn.ColumnName)
                        Case "DateTime"
                            cmd.Parameters.Add(String.Format("@{0}", regIn.ColumnName), SqlDbType.DateTime, 8, regIn.ColumnName)
                        Case Else
                            cmd.Parameters.Add(String.Format("@{0}", regIn.ColumnName), SqlDbType.VarChar, 300, regIn.ColumnName)
                    End Select

                Next
                dt.AcceptChanges()
                For Each dato As DataRow In dt.Rows
                    dato.SetAdded()
                Next

                Using da As New SqlClient.SqlDataAdapter(cmd)
                    da.InsertCommand = cmd

                    Using ds As New DataSet
                        Try
                            Dim ret As Integer
                            ret = da.Update(dt)
                            Return ret
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return -2
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function

    Public Function Generic_ActualizaCatalogos_Legacy() As DataSet
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("SP_ImportCatalogos_Legacy", conn)
                cmd.CommandType = CommandType.StoredProcedure
                Using da As New SqlClient.SqlDataAdapter(cmd)


                    Using ds As New DataSet
                        Try
                            da.Fill(ds)
                            Return ds
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return Nothing
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function
#End Region

#Region "Creacion Reportes"
    Public Function ERP_RRHH_InsertReportHeaders(ByVal Name_Header As String, ByVal Descrip_Header As String, ByVal id_Modulo_FK As Long) As String
        Dim resp As Integer = 0
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_RRHH_InsertReportHeaders", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Name_Header", SqlDbType.VarChar).Value = Name_Header
                cmd.Parameters.Add("@Descrip_Header", SqlDbType.VarChar).Value = Descrip_Header
                cmd.Parameters.Add("@id_Modulo_FK", SqlDbType.BigInt).Value = id_Modulo_FK
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            resp = ds.Tables("datos").Rows(0).Item(0)
                            Return resp
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return resp
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function


    Public Function ERP_RRHH_InsertReportDetail(ByVal Id_Header_FK As Long, ByVal Id_Define_Field_FK As Long) As Integer
        Dim resp As Integer = 0
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_RRHH_InsertReportDetail", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_Header_FK", SqlDbType.BigInt).Value = Id_Header_FK
                cmd.Parameters.Add("@Id_Define_Field_FK", SqlDbType.BigInt).Value = Id_Define_Field_FK
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            resp = ds.Tables("datos").Rows(0).Item(0)
                            Return resp
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return resp
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function

#End Region

#Region "Reportes Genericos"

    Public Function ERP_Generic_GetTituloReporte(ByVal id_Company As Long, ByVal idReport As Long) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_RRHH_GetGenericReportHeaderByIDHeader", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@id_Report", SqlDbType.BigInt).Value = idReport
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
    Public Function ERP_Generic_GetHeaderReport(ByVal id_Company As Long, ByVal idReport As Long) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_Generic_ReportHeaderData", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@id_Header", SqlDbType.BigInt).Value = idReport
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "Table1")
                            Return ds.Tables("Table1")
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return New DataTable("Table1")
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function
    Public Function ERP_Generic_GetBodyReportData(ByVal id_Company As Long) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_FixedAssets_Master_Select_Report", conn)
                cmd.CommandType = CommandType.StoredProcedure
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "Table")
                            Return ds.Tables("Table")
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return New DataTable("Table")
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function

    Public Function AgregarValores(ByVal Id_Company As Integer, ByVal Codigo As String, ByVal NombreActivo As String, ByVal Id_FixedAssetsType As String,
                                                         ByVal Id_FixedAssetsTypeSub As String, ByVal UbicacionPrimaria As String, ByVal UbicacionSecundaria As String,
                                                         ByVal UnidadOrganizativa As String, ByVal Id_Employee As Integer, ByVal fechaInicial As Date,
                                                         ByVal fechaFinal As Date, ByVal Id_estado_Fk As Integer, ByVal FechaAdquisicionInicial As Date,
                                                         ByVal FechaAdquisicionFinal As Date, ByVal RangoValorAdquisicionInicial As Decimal, ByVal RangoValorAdquisicionFinal As Decimal,
                                                         ByVal FechasAct As Boolean, ByVal FechaAd As Boolean, ByVal ValorAd As Boolean, ByVal OrdenadoPor As String, ByVal Comando As String, ByVal conn As SqlConnection) As SqlCommand
        Dim cmd As New SqlCommand(Comando, conn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@Id_Company", SqlDbType.BigInt).Value = Id_Company
        cmd.Parameters.AddWithValue("@Codigo", SqlDbType.VarChar).Value = Codigo
        cmd.Parameters.AddWithValue("@Nombre", SqlDbType.VarChar).Value = NombreActivo
        cmd.Parameters.AddWithValue("@Id_FixedAssetsType", SqlDbType.VarChar).Value = Id_FixedAssetsType
        cmd.Parameters.AddWithValue("@Id_FixedAssetsTypeSub", SqlDbType.VarChar).Value = Id_FixedAssetsTypeSub
        cmd.Parameters.AddWithValue("@UbicacionPrimaria", SqlDbType.VarChar).Value = UbicacionPrimaria
        cmd.Parameters.AddWithValue("@UbicacionSecundaria", SqlDbType.VarChar).Value = UbicacionSecundaria
        cmd.Parameters.AddWithValue("@UnidadOrganizativa", SqlDbType.VarChar).Value = UnidadOrganizativa
        cmd.Parameters.AddWithValue("@Id_Employee", SqlDbType.BigInt).Value = Id_Employee
        cmd.Parameters.AddWithValue("@DateInitial", SqlDbType.BigInt).Value = fechaInicial.ToString("yyyyMMdd")
        cmd.Parameters.AddWithValue("@DateFinal", SqlDbType.BigInt).Value = fechaFinal.ToString("yyyyMMdd")
        cmd.Parameters.AddWithValue("@Id_estado_Fk", SqlDbType.BigInt).Value = Id_estado_Fk
        cmd.Parameters.AddWithValue("@FechaAdquisicionInicial", SqlDbType.BigInt).Value = FechaAdquisicionInicial.ToString("yyyyMMdd")
        cmd.Parameters.AddWithValue("@FechaAdquisicionFinal", SqlDbType.BigInt).Value = FechaAdquisicionFinal.ToString("yyyyMMdd")
        cmd.Parameters.AddWithValue("@RangoValorAdquisicionInicial", SqlDbType.VarChar).Value = RangoValorAdquisicionInicial
        cmd.Parameters.AddWithValue("@RangoValorAdquisicionFinal", SqlDbType.VarChar).Value = RangoValorAdquisicionFinal
        cmd.Parameters.AddWithValue("@FechasAct", SqlDbType.Bit).Value = FechasAct
        cmd.Parameters.AddWithValue("@FechaAdquisicion", SqlDbType.Bit).Value = FechaAd
        cmd.Parameters.AddWithValue("@ValorAdquisicion", SqlDbType.Bit).Value = ValorAd
        cmd.Parameters.AddWithValue("@OrdenadoPor", SqlDbType.VarChar).Value = OrdenadoPor
        Return cmd
    End Function

    Public Function ERP_GetBodyReportInventory_transfers(ByVal Id_Company As Integer, ByVal Codigo As String, ByVal NombreActivo As String, ByVal Id_FixedAssetsType As String,
                                                         ByVal Id_FixedAssetsTypeSub As String, ByVal UbicacionPrimaria As String, ByVal UbicacionSecundaria As String,
                                                         ByVal UnidadOrganizativa As String, ByVal Id_Employee As Integer, ByVal fechaInicial As Date,
                                                         ByVal fechaFinal As Date, ByVal Id_estado_Fk As Integer, ByVal FechaAdquisicionInicial As Date,
                                                         ByVal FechaAdquisicionFinal As Date, ByVal RangoValorAdquisicionInicial As Decimal, ByVal RangoValorAdquisicionFinal As Decimal,
                                                         ByVal FechasAct As Boolean, ByVal FechaAd As Boolean, ByVal ValorAd As Boolean, ByVal OrdenadoPor As String) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As SqlCommand = AgregarValores(Id_Company, Codigo, NombreActivo, Id_FixedAssetsType,
                                                         Id_FixedAssetsTypeSub, UbicacionPrimaria, UbicacionSecundaria,
                                                         UnidadOrganizativa, Id_Employee, fechaInicial,
                                                         fechaFinal, Id_estado_Fk, FechaAdquisicionInicial,
                                                         FechaAdquisicionFinal, RangoValorAdquisicionInicial, RangoValorAdquisicionFinal,
                                                         FechasAct, FechaAd, ValorAd, OrdenadoPor, "ERP_GetBodyReportInventory_transfers", conn)


                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "Table")
                            Return ds.Tables("Table")
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return New DataTable("Table")
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function

    Public Function ERP_GetBodyReportFiexdAssetsState(ByVal Id_Company As Integer, ByVal Codigo As String, ByVal NombreActivo As String, ByVal Id_FixedAssetsType As String,
                                                         ByVal Id_FixedAssetsTypeSub As String, ByVal UbicacionPrimaria As String, ByVal UbicacionSecundaria As String,
                                                         ByVal UnidadOrganizativa As String, ByVal Id_Employee As Integer, ByVal fechaInicial As Date,
                                                         ByVal fechaFinal As Date, ByVal Id_estado_Fk As Integer, ByVal FechaAdquisicionInicial As Date,
                                                         ByVal FechaAdquisicionFinal As Date, ByVal RangoValorAdquisicionInicial As Decimal, ByVal RangoValorAdquisicionFinal As Decimal,
                                                         ByVal FechasAct As Boolean, ByVal FechaAd As Boolean, ByVal ValorAd As Boolean, ByVal OrdenadoPor As String) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)

            Using cmd As SqlCommand = AgregarValores(Id_Company, Codigo, NombreActivo, Id_FixedAssetsType,
                                                     Id_FixedAssetsTypeSub, UbicacionPrimaria, UbicacionSecundaria,
                                                     UnidadOrganizativa, Id_Employee, fechaInicial,
                                                     fechaFinal, Id_estado_Fk, FechaAdquisicionInicial,
                                                     FechaAdquisicionFinal, RangoValorAdquisicionInicial, RangoValorAdquisicionFinal,
                                                     FechasAct, FechaAd, ValorAd, OrdenadoPor, "ERP_GetBodyReportFiexdAssetsState", conn)

                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "Table")
                            Return ds.Tables("Table")
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return New DataTable("Table")
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function


    Public Function ERP_GetBodyReportFiexdAssetsGeneral(ByVal Id_Company As Integer, ByVal Codigo As String, ByVal NombreActivo As String, ByVal Id_FixedAssetsType As String,
                                                         ByVal Id_FixedAssetsTypeSub As String, ByVal UbicacionPrimaria As String, ByVal UbicacionSecundaria As String,
                                                         ByVal UnidadOrganizativa As String, ByVal Id_Employee As Integer, ByVal fechaInicial As Date,
                                                         ByVal fechaFinal As Date, ByVal Id_estado_Fk As Integer, ByVal FechaAdquisicionInicial As Date,
                                                         ByVal FechaAdquisicionFinal As Date, ByVal RangoValorAdquisicionInicial As Decimal, ByVal RangoValorAdquisicionFinal As Decimal,
                                                         ByVal FechasAct As Boolean, ByVal FechaAd As Boolean, ByVal ValorAd As Boolean, ByVal OrdenadoPor As String) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As SqlCommand = AgregarValores(Id_Company, Codigo, NombreActivo, Id_FixedAssetsType,
                                                 Id_FixedAssetsTypeSub, UbicacionPrimaria, UbicacionSecundaria,
                                                 UnidadOrganizativa, Id_Employee, fechaInicial,
                                                 fechaFinal, Id_estado_Fk, FechaAdquisicionInicial,
                                                 FechaAdquisicionFinal, RangoValorAdquisicionInicial, RangoValorAdquisicionFinal,
                                                 FechasAct, FechaAd, ValorAd, OrdenadoPor, "ERP_FixedAssets_SP_GetGeneralReport", conn)

                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "ReportAssetssGeneral")
                            Return ds.Tables("ReportAssetssGeneral")
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return New DataTable("ReportAssetssGeneral")
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function


    Public Function ERP_GetBodyReportFiexdAssetstYPE(ByVal Id_Company As Integer, ByVal Codigo As String, ByVal NombreActivo As String, ByVal Id_FixedAssetsType As String,
                                                         ByVal Id_FixedAssetsTypeSub As String, ByVal UbicacionPrimaria As String, ByVal UbicacionSecundaria As String,
                                                         ByVal UnidadOrganizativa As String, ByVal Id_Employee As Integer, ByVal fechaInicial As Date,
                                                         ByVal fechaFinal As Date, ByVal Id_estado_Fk As Integer, ByVal FechaAdquisicionInicial As Date,
                                                         ByVal FechaAdquisicionFinal As Date, ByVal RangoValorAdquisicionInicial As Decimal, ByVal RangoValorAdquisicionFinal As Decimal,
                                                         ByVal FechasAct As Boolean, ByVal FechaAd As Boolean, ByVal ValorAd As Boolean, ByVal OrdenadoPor As String) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As SqlCommand = AgregarValores(Id_Company, Codigo, NombreActivo, Id_FixedAssetsType,
                                                 Id_FixedAssetsTypeSub, UbicacionPrimaria, UbicacionSecundaria,
                                                 UnidadOrganizativa, Id_Employee, fechaInicial,
                                                 fechaFinal, Id_estado_Fk, FechaAdquisicionInicial,
                                                 FechaAdquisicionFinal, RangoValorAdquisicionInicial, RangoValorAdquisicionFinal,
                                                 FechasAct, FechaAd, ValorAd, OrdenadoPor, "ERP_FixedAssets_SP_GetReportTypeAssets", conn)


                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "ReportAssetssGeneral")
                            Return ds.Tables("ReportAssetssGeneral")
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return New DataTable("ReportAssetssGeneral")
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function
#End Region


#Region "FixedAssetTypeDefine"
    Public Function GetFixedAssetTypeDefine() As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_FixedAssets_SP_GetTypeDefine", conn)
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
    Public Function InsertFixedAssetTypeDefine(ByVal Id_FixedAssetsType As Long, ByVal Name_Def As String) As String
        Using conn As New SqlClient.SqlConnection(connStr)
            Dim resp As String = ""
            Using cmd As New SqlCommand("ERP_FixedAssets_SP_InsertType_Define", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_FixedAssetsType", SqlDbType.BigInt).Value = Id_FixedAssetsType
                cmd.Parameters.Add("@Name_Def", SqlDbType.VarChar).Value = Name_Def
                cmd.Parameters.Add("@Val_Regex", SqlDbType.VarChar).Value = "Val"
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            resp = ds.Tables("datos").Rows(0)(0).ToString

                            Return resp
                        Catch ex As SqlException
                            MessageBox.Show("Fallo en la conexión con la base de datos, comuniquese con soporte técnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "EX|" + ex.ToString

                        Catch ex As Exception
                            MessageBox.Show("Ocurrio un error al cargar la información.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(2, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "EX|" + ex.ToString

                        End Try
                        Return resp
                    End Using
                End Using
            End Using
        End Using
    End Function

    Public Function SetFixedAssetTypeDefine(ByVal ID_FixedAssets_Type_Define As Long, ByVal Id_FixedAssetsType As Long, ByVal Name_Def As String) As String
        Using conn As New SqlClient.SqlConnection(connStr)
            Dim resp As String = ""
            Using cmd As New SqlCommand("ERP_FixedAssets_SP_UpdateType_Define", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@ID_FixedAssets_Type_Define", SqlDbType.BigInt).Value = ID_FixedAssets_Type_Define
                cmd.Parameters.Add("@Id_FixedAssetsType", SqlDbType.BigInt).Value = Id_FixedAssetsType
                cmd.Parameters.Add("@Name_Def", SqlDbType.VarChar).Value = Name_Def
                cmd.Parameters.Add("@Val_Regex", SqlDbType.VarChar).Value = "Val"
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            resp = ds.Tables("datos").Rows(0)(0).ToString
                            Return resp

                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return resp

                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function


    Public Function ERP_FixedAssets_SP_UpdateType(ByVal Id_FixedAssetsType As Long, ByVal Id_Company_FK As Long, ByVal Name_FixedAssetsType As String, ByVal Description_FixedAssetsType As String, ByVal VidaUtil As Integer, ByVal isTangible As Boolean, ByVal AccountingAccount As String) As String
        Using conn As New SqlClient.SqlConnection(connStr)
            Dim resp As String = ""
            Using cmd As New SqlCommand("[ERP_FixedAssets_SP_UpdateType]", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_FixedAssetsType", SqlDbType.BigInt).Value = Id_FixedAssetsType
                cmd.Parameters.Add("@Id_Company_FK", SqlDbType.BigInt).Value = Id_Company_FK
                cmd.Parameters.Add("@Name_FixedAssetsType", SqlDbType.VarChar).Value = Name_FixedAssetsType
                cmd.Parameters.Add("@Description_FixedAssetsType", SqlDbType.VarChar).Value = Description_FixedAssetsType
                cmd.Parameters.Add("@VidaUtil", SqlDbType.BigInt).Value = VidaUtil
                cmd.Parameters.Add("@isTangible", SqlDbType.Bit).Value = isTangible
                cmd.Parameters.Add("@AccountingAccount", SqlDbType.VarChar).Value = AccountingAccount
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            resp = ds.Tables("datos").Rows(0)(0).ToString
                            Return resp
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return resp

                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function



    Public Function ERP_FixedAssets_SP_InsertType(ByVal Id_Company_FK As Long, ByVal Name_FixedAssetsType As String, ByVal Description_FixedAssetsType As String, ByVal VidaUtil As Integer, ByVal isTangible As Boolean, ByVal AccountingAccount As String) As String
        Using conn As New SqlClient.SqlConnection(connStr)
            Dim resp As String = ""
            Using cmd As New SqlCommand("[ERP_FixedAssets_SP_InsertType]", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_Company_FK", SqlDbType.BigInt).Value = Id_Company_FK
                cmd.Parameters.Add("@Name_FixedAssetsType", SqlDbType.VarChar).Value = Name_FixedAssetsType
                cmd.Parameters.Add("@Description_FixedAssetsType", SqlDbType.VarChar).Value = Description_FixedAssetsType
                cmd.Parameters.Add("@VidaUtil", SqlDbType.BigInt).Value = VidaUtil
                cmd.Parameters.Add("@isTangible", SqlDbType.Bit).Value = isTangible
                cmd.Parameters.Add("@AccountingAccount", SqlDbType.VarChar).Value = AccountingAccount

                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            resp = ds.Tables("datos").Rows(0)(0).ToString
                            Return resp
                        Catch ex As SqlException
                            MessageBox.Show("Fallo en la conexión con la base de datos, comuniquese con soporte técnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "EX|" + ex.ToString

                        Catch ex As Exception
                            MessageBox.Show("Ocurrio un error al cargar la información.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(2, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "EX|" + ex.ToString

                        End Try
                        Return resp
                    End Using
                End Using
            End Using
        End Using
    End Function

    Public Function ERP_InsertFixedAssets_State(ByVal nombreEstado As String, ByVal DescripcionEstado As String, chkIsLow As Boolean, isDischarged As Boolean) As String
        Using conn As New SqlClient.SqlConnection(connStr)
            Dim resp As String = ""
            Using cmd As New SqlCommand("[ERP_InsertFixedAssets_State]", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@nombreEstado", SqlDbType.VarChar).Value = nombreEstado
                cmd.Parameters.Add("@DescripcionEstado", SqlDbType.VarChar).Value = DescripcionEstado
                cmd.Parameters.Add("@Is_Low", SqlDbType.Bit).Value = chkIsLow
                cmd.Parameters.Add("@isDischarged", SqlDbType.Bit).Value = isDischarged
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            resp = ds.Tables("datos").Rows(0)(0).ToString
                            Return resp

                        Catch ex As SqlException
                            MessageBox.Show("Fallo en la conexión con la base de datos, comuniquese con soporte técnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "EX|" + ex.ToString
                        Catch ex As Exception
                            MessageBox.Show("Ocurrio un error al cargar la información.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(2, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "EX|" + ex.ToString

                        End Try
                        Return resp
                    End Using
                End Using
            End Using
        End Using
    End Function

    Public Function ERP_SetFixedAssets_State(ByVal id_estado As Integer, ByVal nombreEstado As String, ByVal DescripcionEstado As String, chkIsLow As Boolean, isDischarged As Boolean) As String
        Using conn As New SqlClient.SqlConnection(connStr)
            Dim resp As String = ""
            Using cmd As New SqlCommand("[ERP_SetFixedAssets_State]", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@id_estado", SqlDbType.BigInt).Value = id_estado
                cmd.Parameters.Add("@nombreEstado", SqlDbType.VarChar).Value = nombreEstado
                cmd.Parameters.Add("@DescripcionEstado", SqlDbType.VarChar).Value = DescripcionEstado
                cmd.Parameters.Add("@Is_Low", SqlDbType.Bit).Value = chkIsLow
                cmd.Parameters.Add("@isDischarged", SqlDbType.Bit).Value = isDischarged

                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            resp = ds.Tables("datos").Rows(0)(0).ToString
                            Return resp

                        Catch ex As SqlException
                            MessageBox.Show("Fallo en la conexión con la base de datos, comuniquese con soporte técnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "EX|" + ex.ToString
                        Catch ex As Exception
                            MessageBox.Show("Ocurrio un error al cargar la información.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(2, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "EX|" + ex.ToString

                        End Try
                        Return resp
                    End Using
                End Using
            End Using
        End Using
    End Function


    Public Function DelFixedAssetTypeDefine(ByVal ID_FixedAssets_Type_Define As Long) As String
        Using conn As New SqlClient.SqlConnection(connStr)
            Dim resp As String = ""
            Using cmd As New SqlCommand("ERP_FixedAssets_SP_DelType_Define", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_FixedAssetsType", SqlDbType.BigInt).Value = ID_FixedAssets_Type_Define
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            resp = ds.Tables("datos").Rows(0)(0).ToString
                            Return resp
                        Catch ex As SqlException
                            MessageBox.Show("Fallo en la conexión con la base de datos, comuniquese con soporte técnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "EX|" + ex.ToString

                        Catch ex As Exception
                            MessageBox.Show("Ocurrio un error al cargar la información.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(2, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "EX|" + ex.ToString

                        End Try
                        Return resp
                    End Using
                End Using
            End Using
        End Using
    End Function

    Public Function ERP_SP_DelModelo(ByVal id As Long) As String
        Using conn As New SqlClient.SqlConnection(connStr)
            Dim resp As String = ""
            Using cmd As New SqlCommand("ERP_SP_DelModelo", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@id", SqlDbType.BigInt).Value = id
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            resp = ds.Tables("datos").Rows(0)(0).ToString
                            Return resp
                        Catch ex As SqlException
                            MessageBox.Show("Fallo en la conexión con la base de datos, comuniquese con soporte técnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "EX|" + ex.ToString

                        Catch ex As Exception
                            MessageBox.Show("Ocurrio un error al cargar la información.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(2, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "EX|" + ex.ToString

                        End Try
                        Return resp
                    End Using
                End Using
            End Using
        End Using
    End Function

    Public Function ERP_DelFixedAssetType(ByVal Id_FixedAssetsType As Long) As String
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_DelFixedAssetType", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_FixedAssetsType", SqlDbType.BigInt).Value = Id_FixedAssetsType
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return ds.Tables("datos").Rows(0).Item(0)
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "ERROR"
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function

    Public Function ERP_DelFixedAssets_State(ByVal id As Long) As String
        Using conn As New SqlClient.SqlConnection(connStr)
            Dim resp As String = ""
            Using cmd As New SqlCommand("ERP_DelFixedAssets_State", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@id", SqlDbType.BigInt).Value = id
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return ds.Tables("datos").Rows(0).Item(0)
                        Catch ex As SqlException
                            MessageBox.Show("Fallo en la conexión con la base de datos, comuniquese con soporte técnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "EX|" + ex.ToString
                        Catch ex As Exception
                            MessageBox.Show("Ocurrio un error al cargar la información.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(2, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "EX|" + ex.ToString

                        End Try
                        Return resp
                    End Using
                End Using
            End Using
        End Using
    End Function

    Public Function GetFixedAsset() As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_RRHH_GetFixedAssets_Type", conn)
                cmd.CommandType = CommandType.StoredProcedure
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return ds.Tables("datos")
                        Catch ex As SqlException
                            MessageBox.Show("Ocurrio un error en la conexión con la base de datos.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                        Catch ex As Exception
                            process.AlmacenarLog(5, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return New DataTable("datos")
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function
#End Region

    Public Function ERP_SP_InsertModelo(ByVal Id_Company As Integer, ByVal Description As String, ByVal ID_inventory_Marca As Integer) As String
        Dim resp As String = ""
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_SP_InsertModelo", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_Company", SqlDbType.BigInt).Value = Id_Company
                cmd.Parameters.Add("@Description", SqlDbType.VarChar).Value = Description
                cmd.Parameters.Add("@ID_inventory_Marca", SqlDbType.BigInt).Value = ID_inventory_Marca
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            resp = ds.Tables("datos").Rows(0).Item(0)
                            Return resp
                        Catch ex As SqlException
                            MessageBox.Show("Fallo en la conexión con la base de datos, comuniquese con soporte técnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "EX|" + ex.ToString
                        Catch ex As Exception
                            MessageBox.Show("Ocurrio un error al cargar la información.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(2, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "EX|" + ex.ToString

                        End Try
                        Return resp
                    End Using
                End Using
            End Using
        End Using
    End Function


    Public Function ERP_SP_UpdateModelo(ByVal id As Integer, ByVal Id_Company As Integer, ByVal Description As String, ByVal ID_inventory_Marca As Integer) As String
        Dim resp As String = ""

        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_SP_UpdateModelo", conn)


                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@id", SqlDbType.BigInt).Value = id
                cmd.Parameters.Add("@Id_Company", SqlDbType.BigInt).Value = Id_Company
                cmd.Parameters.Add("@Description", SqlDbType.VarChar).Value = Description
                cmd.Parameters.Add("@ID_inventory_Marca", SqlDbType.BigInt).Value = ID_inventory_Marca
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            resp = ds.Tables("datos").Rows(0).Item(0)
                            Return resp

                        Catch ex As SqlException
                            MessageBox.Show("Fallo en la conexión con la base de datos, comuniquese con soporte técnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "EX|" + ex.ToString
                        Catch ex As Exception
                            MessageBox.Show("Ocurrio un error al cargar la información.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(2, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "EX|" + ex.ToString

                        End Try
                        Return resp
                    End Using
                End Using
            End Using
        End Using
    End Function

    Public Function ERP_SP_InsertReason(ByVal name_reason As String, ByVal descip As String) As String
        Using conn As New SqlClient.SqlConnection(connStr)
            Dim resp As String = ""

            Using cmd As New SqlCommand("ERP_SP_InsertReason", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@name_reason", SqlDbType.VarChar).Value = name_reason
                cmd.Parameters.Add("@descrip", SqlDbType.VarChar).Value = descip
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            resp = ds.Tables("datos").Rows(0).Item(0)

                            '  Return resp
                        Catch ex As SqlException
                            MessageBox.Show("Fallo en la conexión con la base de datos, comuniquese con soporte técnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "EX|" + ex.ToString
                        Catch ex As Exception
                            MessageBox.Show("Ocurrio un error al cargar la información.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(2, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "EX|" + ex.ToString

                        End Try
                        Return resp
                    End Using
                End Using
            End Using
        End Using
    End Function

    Public Function ERP_SP_SetReason(ByVal id As Integer, ByVal name_reason As String, ByVal descip As String) As String
        Using conn As New SqlClient.SqlConnection(connStr)
            Dim resp As String = ""
            Using cmd As New SqlCommand("ERP_SP_SetReason", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = id
                cmd.Parameters.Add("@name_reason", SqlDbType.VarChar).Value = name_reason
                cmd.Parameters.Add("@descrip", SqlDbType.VarChar).Value = descip
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            resp = ds.Tables("datos").Rows(0).Item(0)
                            '   Return resp
                        Catch ex As SqlException
                            MessageBox.Show("Fallo en la conexión con la base de datos, comuniquese con soporte técnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "EX|" + ex.ToString
                        Catch ex As Exception
                            MessageBox.Show("Ocurrio un error al cargar la información.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(2, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "EX|" + ex.ToString

                        End Try
                        Return resp
                    End Using
                End Using
            End Using
        End Using
    End Function

    Public Function ERP_SP_DelReason(ByVal id As Long) As String
        Using conn As New SqlClient.SqlConnection(connStr)
            Dim resp As String = ""
            Using cmd As New SqlCommand("ERP_SP_DelReason", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@id", SqlDbType.BigInt).Value = id
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            resp = ds.Tables("datos").Rows(0).Item(0)
                            'Return resp
                        Catch ex As SqlException
                            MessageBox.Show("Fallo en la conexión con la base de datos, comuniquese con soporte técnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "EX|" + ex.ToString
                        Catch ex As Exception
                            MessageBox.Show("Ocurrio un error al cargar la información.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(2, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "EX|" + ex.ToString

                        End Try
                        Return resp
                    End Using
                End Using
            End Using
        End Using
    End Function

    'Public Function ERP_SP_UpdateModelo(ByVal id As Integer, ByVal Id_Company As Integer, ByVal Description As String, ByVal ID_inventory_Marca As Integer) As Integer
    '    Using conn As New SqlClient.SqlConnection(connStr)
    '        Using cmd As New SqlCommand("ERP_SP_UpdateModelo", conn)
    '            cmd.CommandType = CommandType.StoredProcedure
    '            cmd.Parameters.Add("@id", SqlDbType.BigInt).Value = id
    '            cmd.Parameters.Add("@Id_Company", SqlDbType.BigInt).Value = Id_Company
    '            cmd.Parameters.Add("@Description", SqlDbType.VarChar).Value = Description
    '            cmd.Parameters.Add("@ID_inventory_Marca", SqlDbType.BigInt).Value = ID_inventory_Marca
    '            Using da As New SqlClient.SqlDataAdapter(cmd)
    '                Using ds As New DataSet
    '                    Try
    '                        da.Fill(ds, "datos")
    '                        Return ds.Tables("datos").Rows(0).Item(0)
    '                    Catch ex As Exception
    '                        process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
    '                        Return 3
    '                    End Try
    '                End Using
    '            End Using
    '        End Using
    '    End Using
    'End Function

    Public Function Get_ResponsableFixedAssets(ByVal ID_FixedAssets As Integer) As String
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("Get_ResponsableFixedAssets", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@ID_FixedAssets", SqlDbType.BigInt).Value = ID_FixedAssets
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return ds.Tables("datos").Rows(0).Item(0)
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return 3
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function

    Public Function isMenber(ByVal rol As String) As Boolean
        Dim resp As Boolean = 0
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_isMember", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@rol", SqlDbType.VarChar).Value = rol

                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            resp = ds.Tables("datos").Rows(0).Item(0)
                            Return resp
                        Catch ex As SqlException
                            MessageBox.Show("Fallo en la conexión con la base de datos, comuniquese con soporte tecnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return resp
                        Catch ex As Exception
                            MessageBox.Show("Ocurrio un error al cargar la informacion.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(5, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return resp
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function

#Region "Modules"
    Public Function InsertModules(ByVal Name As String) As String
        Dim resp As Integer = 0
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("[ERP_RRHH_InsertModule]", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Name", SqlDbType.VarChar).Value = Name
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            resp = ds.Tables("datos").Rows(0).Item(0)
                            Return resp
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return resp
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function

    Public Function UpdateModules(ByVal id As Integer, ByVal Name As String) As String
        Dim resp As Integer = 0
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("[ERP_RRHH_UpdateModule]", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@id", SqlDbType.BigInt).Value = id
                cmd.Parameters.Add("@Name", SqlDbType.VarChar).Value = Name
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            resp = ds.Tables("datos").Rows(0).Item(0)
                            Return resp
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return resp
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function

    Public Function DelModules(ByVal id As Integer) As String
        Dim resp As String = ""
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("[ERP_RRHH_DelModule]", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@id", SqlDbType.BigInt).Value = id
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            resp = ds.Tables("datos").Rows(0).Item(0).ToString()

                            Return resp
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return resp
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function

    Public Function ERP_RRHH_DelReportHeaders(ByVal id As Integer) As String
        Dim resp As String = ""
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("[ERP_RRHH_DelReportHeaders]", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_Header", SqlDbType.BigInt).Value = id
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            resp = ds.Tables("datos").Rows(0).Item(0).ToString()

                            Return resp
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return resp
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function
#End Region

#Region "Reportes"
    Public Function Inventory_GetInventoryMarcaReport(ByVal Data_Id_Company As Long) As DataTable
        Dim dt As New DataTable
        Dim ds As New DataSet("Data")
        Try
            Using da As New SqlDataAdapter("ERP_SP_GetInventoryMarca", New SqlClient.SqlConnection(connStr))
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

    Public Function Inventory_GetInventoryCategoriaReport(ByVal Data_Id_Company As Long) As DataTable
        Dim dt As New DataTable
        Dim ds As New DataSet("Data")
        Try
            Using da As New SqlDataAdapter("ERP_SP_Inventory_GetCategory", New SqlClient.SqlConnection(connStr))
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
#End Region


#Region "Report Depreciation"

    Public Function ERP_GetProductCapitalizable(ByVal Id_Company As Integer) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_Finance_Get_ProductCapitalizable", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@Id_Company", SqlDbType.BigInt).Value = Id_Company
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "Table")
                            Return ds.Tables("Table")
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return New DataTable("Table")
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function

    Public Function ERP_GetReportDepreciationFixedAssetHeader(ByVal Id_Company As Integer, ByVal Id_Header As Integer, ByVal clasificacion As Long) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_Finance_Get_ReportDepreciationFixedAssetHeader", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@Id_Company", SqlDbType.BigInt).Value = Id_Company
                cmd.Parameters.AddWithValue("@Id_Header", SqlDbType.Int).Value = Id_Header
                cmd.Parameters.AddWithValue("@Id_FixedAssetsType", SqlDbType.Int).Value = clasificacion
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "Table")
                            Return ds.Tables("Table")
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return New DataTable("Table")
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function

    Public Function ERP_GetReportDepreciationFixedAssetPreview(ByVal Id_Company As Integer, ByVal FechaProceso As Date, ByVal Id_HeaderDepreciation As Integer) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_Finance_Get_ReportDepreciationFixedAssetPreview", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@Id_Company", SqlDbType.BigInt).Value = Id_Company
                cmd.Parameters.AddWithValue("@FechaProceso", SqlDbType.Date).Value = FechaProceso
                cmd.Parameters.Add("@Id_HeaderDepreciation", SqlDbType.Int).Value = Id_HeaderDepreciation

                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "Table")
                            Return ds.Tables("Table")
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return New DataTable("Table")
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function

    Public Function ERP_GetReportDepreciationFixedAssetPreviewAprob(ByVal Id_Company As Integer, ByVal FechaProceso As Date, ByVal Id_HeaderDepreciation As Integer) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_Finance_Get_ReportDepreciationFixedAssetPreviewTempAprob", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@Id_Company", SqlDbType.BigInt).Value = Id_Company
                cmd.Parameters.AddWithValue("@FechaProceso", SqlDbType.Date).Value = FechaProceso
                cmd.Parameters.Add("@Id_Header", SqlDbType.Int).Value = Id_HeaderDepreciation

                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "Table")
                            Return ds.Tables("Table")
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return New DataTable("Table")
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function


    Public Function ERP_DeletePreview() As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_DeletePreviewData", conn)
                cmd.CommandType = CommandType.StoredProcedure

                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "Table")
                            Return ds.Tables("Table")
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return New DataTable("Table")
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function



    Public Function ERP_InsertDataPreview(ByVal Id_FixedAsset As Integer, ByVal FechaProceso As Date) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_InsertPreviewData", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@ID_FixedAssets_FK", SqlDbType.BigInt).Value = Id_FixedAsset
                cmd.Parameters.AddWithValue("@FechaProceso", SqlDbType.Date).Value = FechaProceso

                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "Table")
                            Return ds.Tables("Table")
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return New DataTable("Table")
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function

    Public Function ERP_GetReportDepreciationFixedAssetPreviewData(ByVal Id_Company As Integer, ByVal Id_HeaderDepreciation As Integer) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_Finance_Get_ReportDepreciationFixedAssetPreviewData", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@Id_Company", SqlDbType.BigInt).Value = Id_Company
                cmd.Parameters.Add("@Id_HeaderDepreciation", SqlDbType.Int).Value = Id_HeaderDepreciation

                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "Table")
                            Return ds.Tables("Table")
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return New DataTable("Table")
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function



    Public Function ERP_GetReportDepreciationFixedAssetPreviewTemp(ByVal Id_Company As Integer, ByVal FechaProceso As String, ByVal IdString As String) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_Finance_Get_ReportDepreciationFixedAssetPreviewTemp", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@Id_Company", SqlDbType.BigInt).Value = Id_Company
                cmd.Parameters.AddWithValue("@FechaProceso", SqlDbType.VarChar).Value = FechaProceso

                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "Table")
                            Return ds.Tables("Table")
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return New DataTable("Table")
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function


    Public Function ERP_GetReportAmortizacionFixedAssetPreviewData(ByVal Id_Company As Integer, ByVal Id_HeaderDepreciation As Integer) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_Finance_Get_AmortizacionFixedAssetPreviewData", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@Id_Company", SqlDbType.BigInt).Value = Id_Company
                cmd.Parameters.Add("@Id_HeaderAmortizacion", SqlDbType.Int).Value = Id_HeaderDepreciation

                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "Table")
                            Return ds.Tables("Table")
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return New DataTable("Table")
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function

    Public Function ERP_GetAmortizacionCalc(ByVal FechaProceso As String, ByVal IdString As String) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_FixedAssets_Amortizacion_Calc", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@Id_Company", SqlDbType.BigInt).Value = _ID_Company
                cmd.Parameters.AddWithValue("@IdString", SqlDbType.VarChar).Value = IdString
                cmd.Parameters.AddWithValue("@FechaProceso", SqlDbType.VarChar).Value = FechaProceso

                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "Table")
                            Return ds.Tables("Table")
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return New DataTable("Table")
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function




    Public Function ERP_GetCapitalizable() As Integer
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_FINANCE_GET_CAPITALIZABLE", conn)
                cmd.CommandType = CommandType.StoredProcedure

                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "TableCa")
                            Return ds.Tables("TableCa").Rows(0).Item(0)
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return 0
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function
    Public Function ERP_GetReportDepreciationFixedAsset(ByVal Id_Company As Integer, ByVal Status As Integer, ByVal clasificacion As Long, ByVal IdHeader As Integer) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_Finance_Get_ReportDepreciationFixedAsset", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@Id_Company", SqlDbType.BigInt).Value = Id_Company
                cmd.Parameters.AddWithValue("@Status", SqlDbType.Int).Value = Status
                cmd.Parameters.AddWithValue("@Id_FixedAssetsType", SqlDbType.Int).Value = clasificacion
                cmd.Parameters.AddWithValue("@IdHeader", SqlDbType.Int).Value = IdHeader

                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "Table")
                            Return ds.Tables("Table")
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return New DataTable("Table")
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function

    Public Function ERP_GetReportDepreciationHeader(ByVal Id_Company As Integer, ByVal clasificacion As Long, ByVal Id_Header As Long) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_Finance_Get_ReportDepreciationHeader", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@Id_Company", SqlDbType.Int).Value = Id_Company
                cmd.Parameters.AddWithValue("@Id_FixedAssetsType", SqlDbType.BigInt).Value = clasificacion
                cmd.Parameters.AddWithValue("@IdHeader", SqlDbType.BigInt).Value = Id_Header

                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "Table")
                            Return ds.Tables("Table")
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return New DataTable("Table")
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function


#End Region



#Region "Visor de Log"
    Public Function ERP_VisorLogTables() As DataTable
        Dim resp As Integer = 0
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_SP_ShowLog_Tables", conn)
                cmd.CommandType = CommandType.StoredProcedure
                'cmd.Parameters.Add("@usuario", SqlDbType.VarChar).Value = usuario

                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "DatosVisorTablas")
                            If (ds.Tables.Count > 0) Then
                                Return ds.Tables(0)
                            Else
                                Return Nothing
                            End If
                            'Return resp
                        Catch ex As SqlException
                            MessageBox.Show("Fallo en la conexión con la base de datos, comuniquese con soporte tecnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return Nothing
                        Catch ex As Exception
                            MessageBox.Show("Ocurrio un error al cargar la informacion.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(5, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return Nothing
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function

    Public Function ERP_VisorLog(ByVal Id_ObjectTable As String, ByVal Registros As Integer, ByVal FechaInicio As Date, ByVal FechaFin As Date) As DataTable
        Dim resp As Integer = 0
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_SP_ShowLog", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Tabla", SqlDbType.VarChar).Value = Id_ObjectTable
                cmd.Parameters.Add("@Registros", SqlDbType.Int).Value = Registros
                cmd.Parameters.Add("@FechaInicio", SqlDbType.Date).Value = FechaInicio
                cmd.Parameters.Add("@FechaFin", SqlDbType.Date).Value = FechaFin

                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "DatosVisorLog")
                            If (ds.Tables.Count > 0) Then
                                Return ds.Tables(0)
                            Else
                                Return Nothing
                            End If

                            'Return resp
                        Catch ex As SqlException
                            MessageBox.Show("Fallo en la conexión con la base de datos, comuniquese con soporte tecnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return Nothing
                        Catch ex As Exception
                            MessageBox.Show("Ocurrio un error al cargar la informacion.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(5, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return Nothing
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function

    Public Function ERP_VisorLog(ByVal Id_ObjectTable As String, ByVal Campo As String, ByVal Busquedad As String) As DataTable
        Dim resp As Integer = 0
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_SP_ShowLog", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_ObjectTable", SqlDbType.VarChar).Value = Id_ObjectTable

                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "DatosVisorLog")
                            If (ds.Tables.Count > 0) Then
                                Return ds.Tables(0)
                            Else
                                Return Nothing
                            End If

                            'Return resp
                        Catch ex As SqlException
                            MessageBox.Show("Fallo en la conexión con la base de datos, comuniquese con soporte tecnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return Nothing
                        Catch ex As Exception
                            MessageBox.Show("Ocurrio un error al cargar la informacion.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(5, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return Nothing
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function

    Public Function ERP_VisorColumn(ByVal Object_ID As String) As DataTable
        Dim resp As Integer = 0
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_SP_ShowLogColumn", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Object_ID", SqlDbType.VarChar).Value = Object_ID


                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "DatosVisorColumnas")
                            If (ds.Tables.Count > 0) Then
                                Return ds.Tables(0)
                            Else
                                Return Nothing
                            End If
                            'Return resp
                        Catch ex As SqlException
                            MessageBox.Show("Fallo en la conexión con la base de datos, comuniquese con soporte tecnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return Nothing
                        Catch ex As Exception
                            MessageBox.Show("Ocurrio un error al cargar la informacion.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(5, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return Nothing
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function


    Public Function ERP_VisorColumnData(ByVal TablaSelecc As String, ByVal Campo As String, ByVal Busquedad As String, ByVal Registros As Integer, ByVal FechaInicio As Date, ByVal FechaFin As Date) As DataTable
        Dim resp As Integer = 0
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_SP_ShowLogColumnData", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Tabla", SqlDbType.VarChar).Value = TablaSelecc
                cmd.Parameters.Add("@Campo", SqlDbType.VarChar).Value = Campo
                cmd.Parameters.Add("@Busquedad", SqlDbType.VarChar).Value = Busquedad
                cmd.Parameters.Add("@Top", SqlDbType.Int).Value = Registros
                cmd.Parameters.Add("@FechaInicio", SqlDbType.Date).Value = FechaInicio
                cmd.Parameters.Add("@FechaFin", SqlDbType.Date).Value = FechaFin


                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "DatosVisorColumnas")
                            If (ds.Tables.Count > 0) Then
                                Return ds.Tables(0)
                            Else
                                Return Nothing
                            End If
                            'Return resp
                        Catch ex As SqlException
                            MessageBox.Show("Fallo en la conexión con la base de datos, comuniquese con soporte tecnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return Nothing
                        Catch ex As Exception
                            MessageBox.Show("Ocurrio un error al cargar la informacion.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(5, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return Nothing
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function


#End Region

#Region "Access Menu"
    Public Function GetAccessMenu(ByVal NameUser As String) As DataTable

        Dim dt As New DataTable
        Dim ds As New DataSet("AccessMenu")
        Try
            Using da As New SqlDataAdapter("ERP_Generic_SP_GetAccessMenu", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@NameUser", NameUser)
                da.Fill(ds, "AccessMenu")
            End Using
            dt = ds.Tables("AccessMenu")
        Catch ex As SqlException
            MessageBox.Show("Fallo en la conexión con la base de datos, comuniquese con soporte tecnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
            Return New DataTable("AccessMenu")
        Catch ex As Exception
            MessageBox.Show("Ocurrio un error al cargar la informacion.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(2, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
            Return New DataTable("AccessMenu")
        End Try
        Return dt
    End Function


    Public Function GetAccessRole() As DataTable

        Dim dt As New DataTable
        Dim ds As New DataSet("Roles")
        Try
            Using da As New SqlDataAdapter("ERP_Generic_SP_GetRolesAccess", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                'da.SelectCommand.Parameters.AddWithValue("@NameUser", NameUser)
                da.Fill(ds, "Roles")
            End Using
            dt = ds.Tables("Roles")
        Catch ex As SqlException
            MessageBox.Show("Fallo en la conexión con la base de datos, comuniquese con soporte tecnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
            Return New DataTable("Roles")
        Catch ex As Exception
            MessageBox.Show("Ocurrio un error al cargar la informacion.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(2, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
            Return New DataTable("Roles")
        End Try
        Return dt
    End Function
#End Region

#Region "para cargar los select del filtro de ficha resumida de activo"

    Public Function SP_ERP_Inventory_GetLocationPrimary() As DataTable

        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("SP_ERP_Inventory_GetLocationPrimary", conn)
                cmd.CommandType = CommandType.StoredProcedure
                'cmd.Parameters.Add("@Id_Company", SqlDbType.BigInt).Value = Id_Company
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "GetLocationPrimary")
                            Return ds.Tables("GetLocationPrimary")
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return New DataTable("GetLocationPrimary")
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function

    Public Function SP_ERP_Inventory_GetLocationSecundary() As DataTable

        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("SP_ERP_Inventory_GetLocationSecundary", conn)
                cmd.CommandType = CommandType.StoredProcedure
                'cmd.Parameters.Add("@Id_Company", SqlDbType.BigInt).Value = Id_Company
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "GetLocationSecundary")
                            Return ds.Tables("GetLocationSecundary")
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return New DataTable("GetLocationSecundary")
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function


    Public Function SP_ERP_Inventary_GetUnidadesOrganizativas() As DataTable

        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("SP_ERP_Inventary_GetUnidadesOrganizativas", conn)
                cmd.CommandType = CommandType.StoredProcedure
                'cmd.Parameters.Add("@Id_Company", SqlDbType.BigInt).Value = Id_Company
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "GetUnidadesOrganizativas")
                            Return ds.Tables("GetUnidadesOrganizativas")
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return New DataTable("GetUnidadesOrganizativas")
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function

    Public Function SP_ERP_Inventary_GetUnidadesOrganizativasUbicacion(ByVal Id_UbicacionSecundaria As Integer) As DataTable

        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("SP_ERP_Inventary_GetUnidadesOrganizativasUbicacion", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_UbicacionSecundaria", SqlDbType.BigInt).Value = Id_UbicacionSecundaria
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "GetUnidadesOrganizativas")
                            Return ds.Tables("GetUnidadesOrganizativas")
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return New DataTable("GetUnidadesOrganizativas")
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function

    Public Function SP_ERP_Inventory_getEmpleadoResponsable(ByVal Id_Unidad As Integer) As DataTable

        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("SP_ERP_Inventory_getEmpleadoResponsable", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_Unidad", SqlDbType.BigInt).Value = Id_Unidad
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "getEmpleadoResponsable")
                            Return ds.Tables("getEmpleadoResponsable")
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return New DataTable("getEmpleadoResponsable")
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function


    Public Function SP_ERP_AlmacenGetHeaderEntrada(ByVal Id_Header As Integer) As DataTable

        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("SP_ERP_AlmacenGetHeader", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_Header", SqlDbType.BigInt).Value = Id_Header
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "getdata")
                            Return ds.Tables("getdata")
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return Nothing
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function

    Public Function SP_ERP_AlmacenGetHeaderEntradaDetails(ByVal Id_Header As Integer) As DataTable

        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("SP_ERP_AlmacenGetHeaderDetails", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_Header", SqlDbType.BigInt).Value = Id_Header
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "getdata")
                            Return ds.Tables("getdata")
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return New DataTable("getdata")
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function

#End Region

#Region "Enviar Email"
    Public Function ConfigurationEmail() As DataSet
        Dim ds As New DataSet("Data")
        Try
            Using conn As New SqlClient.SqlConnection(connStr)
                Using da As New SqlDataAdapter("SP_ERP_ConfigurationSendEmail", conn)
                    da.SelectCommand.CommandType = CommandType.StoredProcedure
                    da.SelectCommand.Parameters.AddWithValue("@Key", _PasswordMail)
                    da.Fill(ds, "Configuration")
                End Using
            End Using
        Catch ex As SqlException
            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
        Catch ex As Exception
            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
        End Try
        Return ds
    End Function


    Public Function AddLogEnvioEmail(ByVal ID_Solicitud As Long, ByVal Etapa As Long, ByVal Subject As String, ByVal Body As String, ByVal Email As String) As Boolean
        Dim resp As Boolean = False
        Dim ds As New DataSet
        Try
            Using conn As New SqlClient.SqlConnection(connStr)
                Using da As New SqlDataAdapter("SP_Distribuciones_SaveLogEnvioEmail", conn)
                    da.SelectCommand.CommandType = CommandType.StoredProcedure
                    da.SelectCommand.Parameters.AddWithValue("@ID_Distribucion", ID_Solicitud)
                    da.SelectCommand.Parameters.AddWithValue("@ID_Etapa", Etapa)
                    da.SelectCommand.Parameters.AddWithValue("@Subject", Subject)
                    da.SelectCommand.Parameters.AddWithValue("@Body", Body)
                    da.SelectCommand.Parameters.AddWithValue("@Email", Email)
                    da.Fill(ds, "saveLog")
                End Using
            End Using
        Catch ex As SqlException
            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
        Catch ex As Exception
            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
        End Try
        Return resp
    End Function


#End Region

    Public Function ERP_FixedAssets_MasterimageCompany() As DataTable

        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_FixedAssets_Masterimage_Company", conn)
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
End Class
