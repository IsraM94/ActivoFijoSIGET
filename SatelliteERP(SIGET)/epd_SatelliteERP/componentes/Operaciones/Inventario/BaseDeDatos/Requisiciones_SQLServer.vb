Imports System.Data.SqlClient
Imports System.IO
Imports System.Net

Public Class Requisiciones_SQLServer : Implements IDisposable
    ' Luis eliminar este y pasarlo a Inventory
    Dim process As New ProcessGeneral
    Private connStr As String = DataCenter()

    Friend Function DataCenter() As String
        Return SQLConfiguration.EpdConnectionString.ToString
        REM Return My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Epdsoft\SatelliteERP", "ConnectionStrings", "Error") REM trae el valor del regedit
        Dim a As String = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Retail Pro\Epdsoft", "ConnectionStrings", "Error")
    End Function


    Private MSGERROR As String = "Fallo en la conexión con la base de datos, comuniquese con soporte técnico."

    Public Function Inventory_GetRequisitionsHeader(ByVal Id_Department As Integer) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_Inventory_GetRequisitionsHeader", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_Company", SqlDbType.BigInt).Value = _ID_Company
                cmd.Parameters.Add("@Id_Department", SqlDbType.BigInt).Value = Id_Department
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


    Public Function Inventory_GetRequisitionsHeaderEncargadoBodega(ByVal Id_Department As Integer, ByVal Busquedad As String) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_Inventory_GetRequisitionsHeaderEncargadoBodega", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_Company", SqlDbType.BigInt).Value = _ID_Company
                cmd.Parameters.Add("@Id_Department", SqlDbType.BigInt).Value = Id_Department
                cmd.Parameters.Add("@busqueda", SqlDbType.VarChar).Value = Busquedad
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


    Public Function Inventory_GetRequisitionsHeaderJefeBodega(ByVal Id_Department As Integer, ByVal Busquedad As String) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_Inventory_GetRequisitionsHeaderJefeBodega", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_Company", SqlDbType.BigInt).Value = _ID_Company
                cmd.Parameters.Add("@Id_Department", SqlDbType.BigInt).Value = Id_Department
                cmd.Parameters.Add("@busqueda", SqlDbType.VarChar).Value = Busquedad
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

    Public Function Inventory_GetRequisitionsHeaderEmployee(ByVal IdUnidad As Integer) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_Inventory_GetRequisitionsHeaderEmployee", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@IdUnidad", SqlDbType.BigInt).Value = IdUnidad
                'cmd.Parameters.Add("@IdEmpleado", SqlDbType.BigInt).Value = IdEmpleado
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
    Public Function Inventory_GetRequisitionsHeader(ByVal busqueda As String, ByVal tipo As Integer, ByVal Id_DepartmentAlmacen As Integer) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_Inventory_GetRequisitionsHeader_LIKE", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@busqueda", SqlDbType.VarChar).Value = busqueda
                cmd.Parameters.Add("@tipo", SqlDbType.Int).Value = tipo
                cmd.Parameters.Add("@Id_Department", SqlDbType.Int).Value = Id_DepartmentAlmacen
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

    Public Function ERP_Inventory_GetAllProducts(ByVal Id_Company As Long, ByVal Word As String, ByVal ID_Stowage_FK As Long) As DataTable
        Dim dt As New DataTable
        Dim ds As New DataSet("Data")
        Try
            Using da As New SqlDataAdapter("ERP_Inventory_GetAllProducts", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@Id_Company", Id_Company)
                da.SelectCommand.Parameters.AddWithValue("@Word", Word)
                da.SelectCommand.Parameters.AddWithValue("@ID_Stowage_FK", ID_Stowage_FK)
                da.Fill(ds, "Products")
                dt = ds.Tables("Products")
            End Using
        Catch ex As SqlException

        Catch ex As Exception

        End Try
        Return dt
    End Function
    Public Function ERP_Inventory_InsertRequisitions(ByVal Id_Company As Long, ByVal Id_Employee As Long, ByVal id_stowage As Long, ByVal Id_Department As Integer,
                                                     Optional ByVal Id_Requisitions_Type As Long = -1, Optional CodeRequisitions As String = "") As Long
        Dim resp As Long = 0
        Dim ds As New DataSet("Data")
        Try
            Using da As New SqlDataAdapter("ERP_Inventory_InsertRequisitions", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@Id_Company", Id_Company)
                If Not Id_Requisitions_Type = -1 Then
                    da.SelectCommand.Parameters.AddWithValue("@Id_Requisitions_Type", Id_Requisitions_Type)
                End If
                da.SelectCommand.Parameters.AddWithValue("@Id_Employee", Id_Employee)
                da.SelectCommand.Parameters.AddWithValue("@Id_Stowage", id_stowage)
                da.SelectCommand.Parameters.AddWithValue("@Id_Department_Fk", Id_Department)
                da.SelectCommand.Parameters.AddWithValue("@CodeRequisitions", CodeRequisitions)
                da.Fill(ds, "Resp")
                resp = ds.Tables("Resp").Rows(0)("resp")
            End Using
        Catch ex As SqlException
            MessageBox.Show("Fallo en la conexión con la base de datos, comuniquese con soporte tecnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
            Return -1
        Catch ex As Exception
            MessageBox.Show("Ocurrio un error al cargar la informacion.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(5, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
            Return -1
        End Try
        Return resp
    End Function
    Public Function ERP_Inventory_InsertRequisitionsDetails(ByVal Id_Requisitions_Header As Long, ByVal Id_Producto As Long, ByVal RequiredQuantity As Decimal, ByVal Id_Requisitions_Details As Integer) As Long
        Dim resp As Long = 0
        Dim ds As New DataSet("Data")
        Try
            Using da As New SqlDataAdapter("ERP_Inventory_InsertRequisitionsDetails", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@Id_Requisitions_Header", Id_Requisitions_Header)
                da.SelectCommand.Parameters.AddWithValue("@Id_Producto", Id_Producto)
                da.SelectCommand.Parameters.AddWithValue("@RequiredQuantity", RequiredQuantity)
                da.SelectCommand.Parameters.AddWithValue("@Id_Requisitions_Details", Id_Requisitions_Details)
                da.Fill(ds, "Resp")
                resp = ds.Tables("Resp").Rows(0)("resp")
            End Using
        Catch ex As SqlException
            MessageBox.Show("Fallo en la conexión con la base de datos, comuniquese con soporte tecnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
            Return -1
        Catch ex As Exception
            MessageBox.Show("Ocurrio un error al cargar la informacion.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(5, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
            Return -1
        End Try
        Return resp
    End Function

    Public Function ERP_Inventory_InsertRequisitionsDetailsDisabled(ByVal Id_Requisitions_Header As Long) As Long
        Dim resp As Long = 0
        Dim ds As New DataSet("Data")
        Try
            Using da As New SqlDataAdapter("ERP_Inventory_InsertRequisitionsDetailsDisabled", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@Id_Requisitions_Header", Id_Requisitions_Header)
                da.Fill(ds, "Resp")
                resp = ds.Tables("Resp").Rows(0)("resp")
            End Using
        Catch ex As SqlException
            MessageBox.Show("Fallo en la conexión con la base de datos, comuniquese con soporte tecnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
            Return -1
        Catch ex As Exception
            MessageBox.Show("Ocurrio un error al cargar la informacion.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(5, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
            Return -1
        End Try
        Return resp
    End Function


    Public Function ERP_Inventory_InsertRequisitionHeaderAproved(ByVal Id_Requisitions_Header As Long) As Long
        Dim resp As Long = 0
        Dim ds As New DataSet("Data")
        Try
            Using da As New SqlDataAdapter("ERP_Inventory_InsertRequisitionsHeaderAproved", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@Id_Requisitions_Header", Id_Requisitions_Header)
                da.SelectCommand.Parameters.AddWithValue("@User", _UserSQL)
                da.SelectCommand.Parameters.AddWithValue("@Acceso", "MAIL_CrearRequisicion")
                da.SelectCommand.Parameters.AddWithValue("@Id_Department", _Id_DepartmentGlobal)

                da.Fill(ds, "Data")

                Dim EnvioCorreo As New SendEmail
                If ds.Tables.Count > 0 Then
                    If ds.Tables("Data").Rows.Count > 0 Then
                        For Each DataInfo As DataRow In ds.Tables("Data").Rows
                            EnvioCorreo.SendEmail(DataInfo("email"), DataInfo("Subject"), DataInfo("Body"), Id_Requisitions_Header)
                        Next
                    End If
                End If
                Return 1
            End Using
        Catch ex As SqlException
            MessageBox.Show("Fallo en la conexión con la base de datos, comuniquese con soporte tecnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
            Return -1
        Catch ex As Exception
            MessageBox.Show("Ocurrio un error al cargar la informacion.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(5, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
            Return -1
        End Try
        Return resp
    End Function


#Region "Tipos de Requisiciones"
    Public Function Inventory_SelectRequisitions(Optional Id_RequisitionTypes As Long = 0) As DataTable

        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("SP_Inventory_SelectRequisitionTypes", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_RequisitionTypes", SqlDbType.BigInt).Value = Id_RequisitionTypes
                'cmd.Parameters.Add("@Id_Company", SqlDbType.BigInt).Value = id_Company
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

    Public Function SP_Inventory_SelectRequisitionTypes(Optional Id_RequisitionTypes As Long = 0) As DataTable
        Dim dt As New DataTable
        Dim ds As New DataSet

        Try
            Using da As New SqlDataAdapter("SP_Inventory_SelectRequisitionTypes", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@Id_RequisitionTypes", Id_RequisitionTypes)
                da.Fill(ds, "datos")

                dt = ds.Tables("datos")
            End Using
        Catch ex As SqlException
            MessageBox.Show("Fallo la conexión con la base de datos,comuniquese con soperte técnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("Ocurrio un error al cargar la información.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
        Return dt

    End Function


    Public Function GetDataEntradaProdutos(ByVal Busquedad As String) As DataTable
        Dim dt As New DataTable
        Dim ds As New DataSet

        Try
            Using da As New SqlDataAdapter("SP_Inventory_GetDataEntradasProductos", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@Busquedad", Busquedad)
                da.SelectCommand.Parameters.AddWithValue("@ID_Company", _ID_Company)

                da.Fill(ds, "datos")

                dt = ds.Tables("datos")
            End Using
        Catch ex As SqlException
            MessageBox.Show("Fallo la conexión con la base de datos,comuniquese con soperte técnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("Ocurrio un error al cargar la información.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
        Return dt

    End Function

    Public Function SP_Inventory_InsertRequisitionTypes(ByVal RequisitionType As String) As String
        Dim dt As New DataTable
        Dim ds As New DataSet
        Dim resp As String = ""
        Try
            Using da As New SqlDataAdapter("SP_Inventory_InsertRequisitionTypes", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@RequisitionType", RequisitionType)
                da.Fill(ds, "datos")
                resp = ds.Tables("datos").Rows(0)(0).ToString
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

    Public Function SP_Inventory_UpdateRequisitionType(ByVal Id_RequisitionTypes As Integer, ByVal RequisitionType As String) As String
        Dim dt As New DataTable
        Dim ds As New DataSet
        Dim resp As String = ""
        Try
            Using da As New SqlDataAdapter("SP_Inventory_UpdateRequisitiontypes", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@Id_RequisitionTypes", Id_RequisitionTypes)
                da.SelectCommand.Parameters.AddWithValue("@RequisitionType", RequisitionType)

                da.Fill(ds, "datos")
                resp = ds.Tables("datos").Rows(0)(0).ToString
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

    Public Function SP_Inventory_DeleteRequisitionType(ByVal Id_RequisitionTypes As Integer) As String
        Dim dt As New DataTable
        Dim ds As New DataSet
        Dim resp As String = ""
        Try
            Using da As New SqlDataAdapter("SP_Inventory_DeleteRequisitionTypes", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@Id_RequisitionTypes", Id_RequisitionTypes)
                da.Fill(ds, "datos")
                resp = ds.Tables("datos").Rows(0)(0).ToString
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

#Region "Revision de Requisiciones"
    Public Function Inventory_ApproveRequisitions(ByVal Id_Requisitions_Header As Long, ByVal Is_Approved As Boolean, ByVal MotivoRechazo As String) As Long
        Dim resp As Long = 0
        Dim ds As New DataSet("Data")
        Try
            Using da As New SqlDataAdapter("SP_Inventory_ApproveRequisitions", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@Id_Requisitions_Header", Id_Requisitions_Header)
                da.SelectCommand.Parameters.AddWithValue("@Is_Approved", Is_Approved)
                da.SelectCommand.Parameters.AddWithValue("@MotivoRechazo", MotivoRechazo)
                da.SelectCommand.Parameters.AddWithValue("@User", _UserSQL)
                If Is_Approved Then
                    da.SelectCommand.Parameters.AddWithValue("@Acceso", "MAIL_AprobacionRequisicion")
                Else
                    da.SelectCommand.Parameters.AddWithValue("@Acceso", "MAIL_CrearRequisicionRechazo")
                End If

                da.SelectCommand.Parameters.AddWithValue("@Id_Department", _Id_DepartmentGlobal)
                da.Fill(ds, "Data")
                Dim EnvioCorreo As New SendEmail
                If ds.Tables.Count > 0 Then
                    If ds.Tables("Data").Rows.Count > 0 Then
                        For Each DataInfo As DataRow In ds.Tables("Data").Rows
                            EnvioCorreo.SendEmail(DataInfo("email"), DataInfo("Subject"), DataInfo("Body"), Id_Requisitions_Header)
                        Next
                    End If
                End If
                Return 1
            End Using
        Catch ex As SqlException
            MessageBox.Show("Fallo en la conexión con la base de datos, comuniquese con soporte tecnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
            Return -1
        Catch ex As Exception
            MessageBox.Show("Ocurrio un error al cargar la informacion.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(5, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
            Return -1
        End Try
        Return resp
    End Function

    Public Function Inventory_GetRequisitionsHeaderByID(ByVal Id_Requisitions_Header As Long) As DataSet
        Dim resp As Long = 0
        Dim ds As New DataSet("Data")
        Try
            Using da As New SqlDataAdapter("SP_Inventory_GetRequisitionsHeaderByID", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@Id_Requisitions_Header", Id_Requisitions_Header)
                da.Fill(ds, "Resp")
                'resp = ds.Tables("Resp").Rows(0)("resp")
            End Using
        Catch ex As SqlException
            MessageBox.Show("Fallo en la conexión con la base de datos, comuniquese con soporte tecnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
            Return ds
        Catch ex As Exception
            MessageBox.Show("Ocurrio un error al cargar la informacion.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(5, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
            Return ds
        End Try
        Return ds
    End Function
    Public Function Inventory_GetRequisitionsDetailsByID(ByVal Id_Requisitions_Header_FK As Long) As DataSet
        Dim resp As Long = 0
        Dim ds As New DataSet("Data")
        Try
            Using da As New SqlDataAdapter("SP_Inventory_GetRequisitionsDetailsByID", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@Id_Requisitions_Header_FK", Id_Requisitions_Header_FK)
                da.Fill(ds, "Resp")
                'resp = ds.Tables("Resp").Rows(0)("resp")
            End Using
        Catch ex As SqlException
            MessageBox.Show("Fallo en la conexión con la base de datos, comuniquese con soporte tecnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
            Return ds
        Catch ex As Exception
            MessageBox.Show("Ocurrio un error al cargar la informacion.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(5, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
            Return ds
        End Try
        Return ds
    End Function

#End Region

#Region "Abastecer Requisiciones"
    Public Function Inventory_InsertSupplyRequisitions(ByVal Id_Company As Long, ByVal Id_RequisitionHeader_FK As Long, ByVal Id_RequisitionDetails_FK As Long, ByVal SupplyQuantity As Decimal, ByVal Observation As String, ByVal ID_Bodega As Long, ByVal ID_Producto As Long, ByVal ID_Output_FK As Long) As Long
        Dim resp As Long = 0

        Dim ds As New DataSet("Data")
        Try
            Using da As New SqlDataAdapter("ERP_Inventory_InsertSupplyRequisitions", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@Id_Company", Id_Company)
                da.SelectCommand.Parameters.AddWithValue("@Id_RequisitionHeader_FK", Id_RequisitionHeader_FK)
                da.SelectCommand.Parameters.AddWithValue("@Id_RequisitionDetails_FK", Id_RequisitionDetails_FK)
                da.SelectCommand.Parameters.AddWithValue("@SupplyQuantity", SupplyQuantity)
                da.SelectCommand.Parameters.AddWithValue("@Observation", Observation)

                da.SelectCommand.Parameters.AddWithValue("@ID_Bodega", ID_Bodega)
                da.SelectCommand.Parameters.AddWithValue("@ID_Producto", ID_Producto)
                da.SelectCommand.Parameters.AddWithValue("@ID_Output_FK", ID_Output_FK)
                da.Fill(ds, "Resp")
                resp = ds.Tables("Resp").Rows(0)("resp")
            End Using
        Catch ex As SqlException
            MessageBox.Show("Fallo en la conexión con la base de datos, comuniquese con soporte tecnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
            Return -1
        Catch ex As Exception
            MessageBox.Show("Ocurrio un error al cargar la informacion.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(5, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
            Return -1
        End Try
        Return resp
    End Function

    Public Function SP_Inventory_SuppliedRequisitions(ByVal Id_Requisitions_Header As Long, ByVal Is_Supplied As Boolean) As Long
        Dim resp As Long = 0
        Dim ds As New DataSet("Data")
        Try
            Using da As New SqlDataAdapter("SP_Inventory_SuppliedRequisitions", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@Id_Requisitions_Header", Id_Requisitions_Header)
                da.SelectCommand.Parameters.AddWithValue("@Is_Supplied", Is_Supplied)
                da.Fill(ds, "Resp")
                resp = ds.Tables("Resp").Rows(0)("resp")
            End Using
        Catch ex As SqlException
            MessageBox.Show("Fallo en la conexión con la base de datos, comuniquese con soporte tecnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
            Return -1
        Catch ex As Exception
            MessageBox.Show("Ocurrio un error al cargar la informacion.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(5, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
            Return -1
        End Try
        Return resp
    End Function



    Public Function Inventory_GetSuppliedRequisitionsReport(ByVal Id_Requisitions_Header As Long) As DataTable
        Dim dt As New DataTable
        Dim ds As New DataSet("Data")
        Try
            Using da As New SqlDataAdapter("SP_Inventory_GetSuppliedRequisitionsReport", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@Id_Requisitions_Header_FK", Id_Requisitions_Header)
                da.Fill(ds, "Products")
                dt = ds.Tables("Products")
            End Using
        Catch ex As SqlException

        Catch ex As Exception

        End Try
        Return dt
    End Function

#End Region

#Region "para obtener el stock de producto por bodega"
    Public Function Inventory_SelectStock(ByRef bodega As Integer, ByVal ID_Producto As Integer) As String

        Using conn As New SqlClient.SqlConnection(connStr)
            Dim resp As String = ""
            Using cmd As New SqlCommand("SP_Inventory_SelectStock", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@ID_Bodega", SqlDbType.BigInt).Value = bodega
                cmd.Parameters.Add("@ID_Producto", SqlDbType.BigInt).Value = ID_Producto

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
